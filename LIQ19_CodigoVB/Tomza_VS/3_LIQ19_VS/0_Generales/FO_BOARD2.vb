Imports System.IO
Imports System.Text

Public Class FO_BOARD2
#Region "VARIABLES Y CONSTANTES MODULARES"

    Dim VC_TABLA_NAME As String
    Dim VC_TAB_PADRE As Panel
    Dim rs As New Resizer
    Dim VM_LOGIN_OPEN As Boolean = False

#End Region

    Public Sub PM_FO_SHOW()
        Dim VP_SERVER As String = ""
        Dim VP_BASE_DATOS As String = ""
        Codigo_CON.FG_CONNECTION_GET(VG_ID_DB, VP_SERVER, VP_BASE_DATOS)
        Me.Text = "Tomza | ERP : LIQ19     SRV=" + VP_SERVER + "  BD=" + VP_BASE_DATOS + " "

        LB_USUARIO.Text = "Hola " + VG_USUARIO
        StartPosition = FormStartPosition.CenterScreen
        Show()
        PG_CAMBIAR_CULTURE_INFO()
        PM_CARGAR_OPCIONES_DEL_SISTEMA()
    End Sub

    Public Sub PM_CARGAR_OPCIONES_DEL_SISTEMA()
        Dim VP_MENU_SISTEMAS As New ContextMenuStrip()

        VP_MENU_SISTEMAS.Items.Add("Enviar Bitacora a Sistemas")
        AddHandler VP_MENU_SISTEMAS.ItemClicked, AddressOf PM_ENVIAR_BITACORA_A_SISTEMAS
        PB_LOGO.ContextMenuStrip = VP_MENU_SISTEMAS
    End Sub

    Public Function PM_ENVIAR_BITACORA_A_SISTEMAS()
        Dim VP_RUTA As String = ""
        VP_RUTA = Application.StartupPath
        Dim VP_NOMBRE_ARCHIVO As String = "Bitácora_" + Application.ProductName + "_" + Application.ProductVersion
        Dim VP_DIRECCION_ARCHIVO As String = VP_RUTA + "\" + VP_NOMBRE_ARCHIVO + ".txt"
        Try
            If File.Exists(VP_DIRECCION_ARCHIVO) Then
                Dim VP_SUBJECT As String = "Bitácora de errores " + VG_USUARIO + "  " + Now.ToString("dd/MM/yyyy hh:mm tt")
                Dim ipAddress As Net.IPAddress
                Dim ipHostInfo As Net.IPHostEntry = Net.Dns.Resolve(Net.Dns.GetHostName())
                ipAddress = ipHostInfo.AddressList(0)

                Dim VP_BODY As String = "Bitácora Adjunta: "
                VP_BODY += " -Usuario [" + VG_USUARIO + "]"
                VP_BODY += " -Computadora [" + Environment.MachineName + "]"
                VP_BODY += " -IP [" + ipAddress.ToString() + "]"
                Codigo_Correo.PG_ENVIAR_CORREO_DESDE_PREDETERMINADO(VP_SUBJECT, "lbarraza.g@tomza.com", VP_BODY, VP_DIRECCION_ARCHIVO)
            End If
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PM_ENVIAR_BITACORA_A_SISTEMAS")
        End Try
        Return True
    End Function

    Public Sub MENU_LOAD(ByRef PP_FORMA As Object)

        Dim VP_TABS_COLLECTION As New List(Of TabPage)
        For Each VP_TABPAGE As TabPage In TC_MAIN_TABCONTROL.TabPages
            VP_TABS_COLLECTION.Add(VP_TABPAGE)
        Next

        Dim VP_MENU_CURRENT As Boolean = False
        Dim VP_TABS_CONTADOR As Integer = VP_TABS_COLLECTION.Count
        Dim VP_I As Integer = 0
        While VP_I < VP_TABS_CONTADOR And VP_MENU_CURRENT = False
            Dim VP_CONTROL As Control = VP_TABS_COLLECTION.Item(VP_I).Controls(0)
            If VP_CONTROL.GetType = GetType(UC_MENU2) Then
                VP_MENU_CURRENT = True
                TC_MAIN_TABCONTROL.SelectedTab = VP_TABS_COLLECTION.Item(VP_I)
            End If
            VP_I += 1
        End While

        If VP_MENU_CURRENT = False Then
            Codigo_FRM.PG_FRM_BT_INIT(PP_FORMA)
            Codigo_FRM.PG_FRM_INIT_BASIC(PP_FORMA)
            Dim VP_MENU As New UC_MENU2
            PL_PANEL.AutoScroll = True
            PL_PANEL.HorizontalScroll.Visible = True
            PL_PANEL.VerticalScroll.Visible = True
            Codigo_FRM.PG_FO_SHOW(VP_MENU, "", "Desktop", VG_ID_DB, TC_MAIN_TABCONTROL, True)
            VP_MENU.Dock = DockStyle.None
            VP_MENU.Top = PL_PANEL.Height / 2 - VP_MENU.Height / 2
            VP_MENU.Left = PL_PANEL.Width / 2 - VP_MENU.Width / 2
            'Dim LL_MENU As New LinkLabel
            'LL_MENU.Text = "MENU ISAAC"
            'LL_MENU.Font = LB_USUARIO.Font
            'FL_DIRECTORIO.Font = LB_USUARIO.Font
            'LL_MENU.Margin = New Padding(2, 0, 0, 0)
            'LL_MENU.AutoSize = True
            'LL_MENU.ActiveLinkColor = Color.Gold
            'LL_MENU.LinkColor = Color.Gray
            'AddHandler LL_MENU.Click, AddressOf LL_MENU_LinkClicked
            'FL_DIRECTORIO.Controls.Clear()
            'FL_DIRECTORIO.Controls.Add(LL_MENU)
            MENU_RELOAD()
        End If
    End Sub

    Public Sub MENU_RELOAD()
        On Error Resume Next
        If Not (Me.WindowState = FormWindowState.Minimized) Then
            Dim VP_SCREEN_WIDTH As Integer = Me.Width
            Dim VP_SCREEN_HEIGHT As Integer = Me.Height


            Dim VP_PAGE_FOCUS As TabPage = TC_MAIN_TABCONTROL.SelectedTab

            If VP_PAGE_FOCUS Is Nothing Then
            Else


                Dim VP_COLLECTION_CONTROLS As New List(Of TabPage)
                For Each VP_USER_CONTROL As TabPage In TC_MAIN_TABCONTROL.TabPages
                    VP_COLLECTION_CONTROLS.Add(VP_USER_CONTROL)
                Next
                TC_MAIN_TABCONTROL.MaximumSize = New Drawing.Size(Me.Width, Me.Height)
                'If VP_SCREEN_WIDTH < 900 Or VP_SCREEN_HEIGHT < 750 Then
                '    LB_USUARIO.Font = New Font(LB_USUARIO.Font.FontFamily, 8, FontStyle.Regular Or FontStyle.Underline)
                'End If

                TC_MAIN_TABCONTROL.TabPages.Clear()

                For Each VP_TAB_PAGE As TabPage In VP_COLLECTION_CONTROLS
                    Dim VP_USER_CONTROL As Control = VP_TAB_PAGE.Controls(0)
                    TableLayoutPanel1.Refresh()
                    TableLayoutPanel1.Dock = DockStyle.Fill
                    PL_PANEL.Width = Me.Width - 10
                    PL_PANEL.Height = TableLayoutPanel1.Height - 72
                    PL_PANEL.ResumeLayout()
                    VP_USER_CONTROL.MaximumSize = New Size(Me.Width, Me.Height - 60)


                    If VP_USER_CONTROL.GetType = GetType(UC_MENU2) Then

                        VP_USER_CONTROL.Dock = DockStyle.None
                        ' VP_USER_CONTROL.Size = New Size(PL_PANEL.Size.Width * 0.8, PL_PANEL.Size.Height * 0.8)
                        VP_USER_CONTROL.Top = PL_PANEL.Height / 2 - VP_USER_CONTROL.Height / 1.6
                        VP_USER_CONTROL.Left = PL_PANEL.Width / 2 - VP_USER_CONTROL.Width / 2
                        'If VP_SCREEN_WIDTH < 900 Or VP_SCREEN_HEIGHT < 750 Then
                        '    LB_USUARIO.Font = New Font(LB_USUARIO.Font.FontFamily, 8, FontStyle.Regular Or FontStyle.Underline)
                        'End If

                    Else

                        'VP_USER_CONTROL.Size = New Size(PL_PANEL.Size.Width * 0.8, PL_PANEL.Size.Height * 0.8)
                        VP_USER_CONTROL.Width = PL_PANEL.Width - 10
                        VP_USER_CONTROL.Height = PL_PANEL.Height - 10
                        ' VP_USER_CONTROL.Dock = DockStyle.Fill
                    End If


                    'Else
                    '    VP_USER_CONTROL.Width = PL_PANEL.Width - 10
                    '    VP_USER_CONTROL.Height = PL_PANEL.Height - 10

                    'End If
                    VP_TAB_PAGE.Margin = New Padding(5, 5, 5, 5)
                    TC_MAIN_TABCONTROL.TabPages.Add(VP_TAB_PAGE)

                Next
                TC_MAIN_TABCONTROL.SelectedTab = VP_PAGE_FOCUS
            End If

        End If
        On Error GoTo 0
    End Sub

    Private Function LL_MENU_LinkClicked() As EventHandler
        MENU_LOAD(Me)
        Return Nothing
    End Function

    Private Sub Menú_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MENU_LOAD(Me)

    End Sub

    Private Function FM_TABLE_NAME(ByVal PP_SENDER As Object) As String
        Dim VP_NOMBRE_TABLA As String = ""
        VP_NOMBRE_TABLA = PP_SENDER.Name
        VP_NOMBRE_TABLA = Strings.Right(VP_NOMBRE_TABLA, (VP_NOMBRE_TABLA.Length - 3))
        Return VP_NOMBRE_TABLA
    End Function

    'Private Sub BT_SALIR_Click(sender As Object, e As EventArgs)
    '    Application.Exit()
    'End Sub

    'Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    Application.Exit()
    'End Sub

    Public Sub PM_ABRIR(ByRef PP_FORMA As Object, ByRef PP_NOMBRE_TABLA As String, ByVal PP_ID_BASE_DE_DATOS As String)
        Codigo_FRM.PG_FO_SHOW(PP_FORMA, PP_NOMBRE_TABLA, PP_ID_BASE_DE_DATOS, PL_PANEL)
    End Sub

    Private Sub LB_LOGIN_LinkClicked()

    End Sub

    Private Sub FO_BOARD2_Resize(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        MENU_RELOAD()
    End Sub

    Private Sub LB_LOGIN_LinkClicked(sender As Object, e As EventArgs) Handles LB_LOGIN.Click
        VM_LOGIN_OPEN = True
        Dim VP_LOGIN As New LoginISAAC
        VP_LOGIN.Show()

        Me.Close()
    End Sub

    Private Sub HOME_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click, Label1.Click
        MENU_LOAD(Me)
    End Sub

    Private Function GetIPv4Address() As String
        GetIPv4Address = String.Empty
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)

        For Each ipheal As System.Net.IPAddress In iphe.AddressList
            If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                GetIPv4Address = strHostName + "-" + ipheal.ToString()
            End If
        Next

    End Function

    Private Sub Panel1_DoubleClick(sender As Object, e As EventArgs) Handles Panel1.DoubleClick
        Dim VP_SERVER As String = ""
        Dim VP_BASE_DATOS As String = ""
        Codigo_CON.FG_CONNECTION_GET(VG_ID_DB, VP_SERVER, VP_BASE_DATOS)
        Me.Text = "Tomza | ERP :   LIQ19    [ SRV: " + VP_SERVER.ToLower + "   BD: " + VP_BASE_DATOS.ToLower + " ]"
        Refresh()
    End Sub


    Public Sub PG_CAMBIAR_CULTURE_INFO()
        Try
            Dim languageChosen As String = "es-MX"

            ' Code for CultureInfo
            Dim cultureInfo As System.Globalization.CultureInfo
            cultureInfo = New System.Globalization.CultureInfo(languageChosen)

            ' Code for Setting the CurrentCulture
            Threading.Thread.CurrentThread.CurrentCulture = cultureInfo
            Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo
            'MsgBox("es-MX")
        Catch ex As Exception
            'MsgBox("NO SE PUDO NI MERGAS")
        End Try
    End Sub

    Private Sub FO_BOARD2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not VM_LOGIN_OPEN Then
            Application.Exit()
        End If

    End Sub
End Class
Public Class Resizer

    '----------------------------------------------------------
    ' ControlInfo
    ' Structure of original state of all processed controls
    '----------------------------------------------------------
    Private Structure ControlInfo
        Public name As String
        Public parentName As String
        Public leftOffsetPercent As Double
        Public topOffsetPercent As Double
        Public heightPercent As Double
        Public originalHeight As Integer
        Public originalWidth As Integer
        Public widthPercent As Double
        Public originalFontSize As Single
    End Structure

    '-------------------------------------------------------------------------
    ' ctrlDict
    ' Dictionary of (control name, control info) for all processed controls
    '-------------------------------------------------------------------------
    Private ctrlDict As Dictionary(Of String, ControlInfo) = New Dictionary(Of String, ControlInfo)

    '----------------------------------------------------------------------------------------
    ' FindAllControls
    ' Recursive function to process all controls contained in the initially passed
    ' control container and store it in the Control dictionary
    '----------------------------------------------------------------------------------------
    Public Sub FindAllControls(thisCtrl As Control)

        '-- If the current control has a parent, store all original relative position
        '-- and size information in the dictionary.
        '-- Recursively call FindAllControls for each control contained in the
        '-- current Control
        For Each ctl As Control In thisCtrl.Controls
            Try
                If Not IsNothing(ctl.Parent) Then
                    Dim parentHeight = ctl.Parent.Height
                    Dim parentWidth = ctl.Parent.Width

                    Dim c As New ControlInfo
                    c.name = ctl.Name
                    c.parentName = ctl.Parent.Name
                    c.topOffsetPercent = Convert.ToDouble(ctl.Top) / Convert.ToDouble(parentHeight)
                    c.leftOffsetPercent = Convert.ToDouble(ctl.Left) / Convert.ToDouble(parentWidth)
                    c.heightPercent = Convert.ToDouble(ctl.Height) / Convert.ToDouble(parentHeight)
                    c.widthPercent = Convert.ToDouble(ctl.Width) / Convert.ToDouble(parentWidth)
                    c.originalFontSize = ctl.Font.Size
                    c.originalHeight = ctl.Height
                    c.originalWidth = ctl.Width
                    ctrlDict.Add(c.name, c)
                End If

            Catch ex As Exception
                Debug.Print(ex.Message)
            End Try

            If ctl.Controls.Count > 0 Then
                FindAllControls(ctl)
            End If

        Next '-- For Each

    End Sub

    '----------------------------------------------------------------------------------------
    ' ResizeAllControls
    ' Recursive function to resize and reposition all controls contained in the Control
    ' dictionary
    '----------------------------------------------------------------------------------------
    Public Sub ResizeAllControls(thisCtrl As Control)

        Dim fontRatioW As Single
        Dim fontRatioH As Single
        Dim fontRatio As Single
        Dim f As Font

        '-- Resize and reposition all controls in the passed control
        For Each ctl As Control In thisCtrl.Controls
            Try
                If Not IsNothing(ctl.Parent) Then
                    Dim parentHeight = ctl.Parent.Height
                    Dim parentWidth = ctl.Parent.Width

                    Dim c As New ControlInfo

                    Dim ret As Boolean = False
                    Try
                        '-- Get the current control's info from the control info dictionary
                        ret = ctrlDict.TryGetValue(ctl.Name, c)

                        '-- If found, adjust the current control based on control relative
                        '-- size and position information stored in the dictionary
                        If (ret) Then
                            '-- Size
                            ctl.Width = Int(parentWidth * c.widthPercent)
                            ctl.Height = Int(parentHeight * c.heightPercent)

                            '-- Position
                            ctl.Top = Int(parentHeight * c.topOffsetPercent)
                            ctl.Left = Int(parentWidth * c.leftOffsetPercent)

                            '-- Font
                            f = ctl.Font
                            fontRatioW = ctl.Width / c.originalWidth
                            fontRatioH = ctl.Height / c.originalHeight
                            fontRatio = (fontRatioW +
                            fontRatioH) / 2 '-- average change in control Height and Width
                            ctl.Font = New Font(f.FontFamily,
                            c.originalFontSize * fontRatio, f.Style)

                        End If
                    Catch
                    End Try
                End If
            Catch ex As Exception
            End Try

            '-- Recursive call for controls contained in the current control
            If ctl.Controls.Count > 0 Then
                ResizeAllControls(ctl)
            End If

        Next '-- For Each
    End Sub

End Class
