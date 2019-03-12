Imports System.Reflection

Public Class Codigo_FRM
    Public Shared MoveForm As Boolean
    Public Shared MoveForm_MousePosition As Point



    Public Shared Sub PG_FRM_ABRIR(ByRef PP_FORMA As Object, ByRef PP_FORMA_NUEVA As Object, ByRef PP_NOMBRE_TABLA As String, ByVal PP_TITULO_TABPAGE As String, ByVal PP_BD_Index As String, Optional ByVal PP_ES_MENU As Boolean = False, Optional ByVal PP_INICIALIZADA As Boolean = False)
        Dim TP_TAB_PAGE As TabPage = PP_FORMA.Parent
        Dim TC_MAIN_TABCONTROL As TabControlEx = TP_TAB_PAGE.Parent
        Codigo_FRM.PG_FO_SHOW(PP_FORMA_NUEVA, PP_NOMBRE_TABLA, PP_TITULO_TABPAGE, PP_BD_Index, TC_MAIN_TABCONTROL, PP_ES_MENU, PP_INICIALIZADA)
    End Sub

    Public Shared Sub PG_FO_SHOW(ByRef PP_FORMA As Object, ByRef PP_NOMBRE_TABLA As String, ByVal PP_BD_Index As String, ByRef PP_PANEL As Panel)
        PP_FORMA.Visible = False
        PP_FORMA.AutoSizeMode = AutoSizeMode.GrowAndShrink
        PP_FORMA.VM_NOMBRE_TABLA = PP_NOMBRE_TABLA
        PP_FORMA.VM_BD_Index = PP_BD_Index
        PP_FORMA.FormBorderStyle = FormBorderStyle.None
        PP_FORMA.WindowState = FormWindowState.Normal
        ' PP_FORMA.SetTopLevel(False)
        PP_FORMA.TopLevel = False
        PP_PANEL.Controls.Clear()
        PP_PANEL.Controls.Add(PP_FORMA)
        PP_FORMA.Dock = DockStyle.Fill

        PG_FO_TITLE_SET(PP_BD_Index, PP_FORMA, PP_PANEL)
        PP_FORMA.Visible = True

    End Sub


    Private Shared Function FG_CREAR_INSTANCIA(ByVal PP_TYPE As Type) As Object
        Return Activator.CreateInstance(PP_TYPE)
    End Function


    Public Shared Sub PG_FO_SHOW(ByRef PP_FORMA As Object, ByRef PP_NOMBRE_TABLA As String, ByVal PP_TITULO_TAB_PAGE As String, ByVal PP_BD_Index As String, ByRef PP_MAIN_TABCONTROL As TabControl, Optional ByVal PP_ES_MENU As Boolean = False, Optional PP_INICIALIZADA As Boolean = False)
        On Error Resume Next

        Dim VP_TYPE As Type
        Dim VP_FORMA As Object
        If PP_INICIALIZADA Then
            VP_FORMA = PP_FORMA
        Else
            VP_TYPE = PP_FORMA.GetType()
            VP_FORMA = FG_CREAR_INSTANCIA(VP_TYPE)
        End If

        If PP_ES_MENU Then

            VP_FORMA.Visible = False
            VP_FORMA.AutoSizeMode = AutoSizeMode.GrowAndShrink
            VP_FORMA.VM_NOMBRE_TABLA = PP_NOMBRE_TABLA
            VP_FORMA.VM_BD_Index = PP_BD_Index
            VP_FORMA.FormBorderStyle = FormBorderStyle.None
            VP_FORMA.WindowState = FormWindowState.Normal
            ' PP_FORMA.SetTopLevel(False)
            VP_FORMA.TopLevel = False
            PP_MAIN_TABCONTROL.Visible = True
            Dim VP_NEW_TAB_PAGE As New TabPage
            VP_NEW_TAB_PAGE.Tag = If((PP_ES_MENU = True), 1, 0)
            VP_NEW_TAB_PAGE.BackColor = Color.White
            VP_NEW_TAB_PAGE.Text = PP_TITULO_TAB_PAGE + "     "

            If PP_ES_MENU Then
                VP_NEW_TAB_PAGE.Size = New Size(PP_MAIN_TABCONTROL.Width - 10, PP_MAIN_TABCONTROL.Height - 30)
                VP_FORMA.Size = New Size(VP_NEW_TAB_PAGE.Width - 10, VP_NEW_TAB_PAGE.Height - 10)
                VP_FORMA.Location = New Point(5, 5)
                VP_NEW_TAB_PAGE.Margin = New Padding(5, 5, 5, 5)
                VP_NEW_TAB_PAGE.Padding = New Padding(5, 5, 5, 5)
            Else
                VP_FORMA.Dock = DockStyle.Fill
            End If
            VP_NEW_TAB_PAGE.Controls.Add(VP_FORMA)        ' 

            PP_MAIN_TABCONTROL.TabPages.Add(VP_NEW_TAB_PAGE)

            VP_FORMA.Visible = True
            PP_MAIN_TABCONTROL.SelectedTab = VP_NEW_TAB_PAGE
        Else

            VP_FORMA.Visible = False
            'VP_FORMA.AutoSizeMode = AutoSizeMode.GrowAndShrink
            VP_FORMA.VM_NOMBRE_TABLA = PP_NOMBRE_TABLA
            VP_FORMA.VM_BD_Index = PP_BD_Index
            VP_FORMA.AutoSizeMode = AutoSizeMode.GrowAndShrink
            VP_FORMA.FormBorderStyle = FormBorderStyle.None
            VP_FORMA.WindowState = FormWindowState.Normal
            VP_FORMA.AutoScaleMode = AutoScaleMode.Inherit
            VP_FORMA.TopLevel = False
            PP_MAIN_TABCONTROL.Visible = True
            Dim VP_NEW_TAB_PAGE As New TabPage
            VP_NEW_TAB_PAGE.Tag = 0
            VP_NEW_TAB_PAGE.BackColor = Color.White
            VP_NEW_TAB_PAGE.Text = PP_TITULO_TAB_PAGE + "     "
            VP_NEW_TAB_PAGE.Controls.Add(VP_FORMA)
            VP_FORMA.Dock = DockStyle.Fill

            PP_MAIN_TABCONTROL.TabPages.Add(VP_NEW_TAB_PAGE)
            VP_FORMA.Visible = True
            PP_MAIN_TABCONTROL.SelectedTab = VP_NEW_TAB_PAGE
        End If

        On Error GoTo 0
    End Sub



    Public Shared Function FG_TITULO_VENTANA(PP_BD_Index As Integer, PP_TITULO As String) As String

        Dim VP_RESULTADO As String = ""

        Dim VP_DB As String = ""
        Dim VP_SERVER As String = ""

        Codigo_SQL.FG_CONNECTION_GET(PP_BD_Index, VP_SERVER, VP_DB)

        VP_RESULTADO = LIQ19_Constantes.CG_TITULO_VENTANA
        VP_RESULTADO = VP_RESULTADO + " @ " + PP_TITULO
        VP_RESULTADO = VP_RESULTADO + " | Exe " + LIQ19_Constantes.CG_VERSION_EXE + " Bd " + LIQ19_Constantes.CG_VERSION_DTB
        VP_RESULTADO = VP_RESULTADO + " | " + VP_SERVER + " -> " + VP_DB + ""

        Return VP_RESULTADO

    End Function


    Public Shared Sub PG_FO_TITLE_SET(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_PANEL As Panel)

        On Error Resume Next

        Dim VP_TITULO As String

        VP_TITULO = FG_TITULO_VENTANA(PP_BD_Index, PP_FORMA.TEXT)

        PP_FORMA.VM_D_BASE_DE_DATOS = PP_BD_Index

        Dim VP_PARENT As Object
        VP_PARENT = PP_PANEL.Parent
        VP_PARENT.Text = VP_TITULO
        On Error GoTo 0

    End Sub

    Public Shared Sub PG_FRM_TITLE_CHANGE(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object)

        PP_FORMA.Text = FG_TITULO_VENTANA(PP_BD_Index, PP_FORMA.TEXT)

    End Sub


    Public Shared Sub PG_FRM_VER_GET(ByRef PP_FORMA As Object)
        Dim versionNumber As New Version
        versionNumber = Assembly.GetExecutingAssembly().GetName().Version
        PP_FORMA.LB_VERSION.Text = "Versión: " + versionNumber.ToString()

    End Sub

    Public Shared Sub PG_FRM_CONFIG(ByRef PP_FORMA As Object)

        Dim VP_IN_MODO_OPERACION As Integer = PP_FORMA.VM_IN_MODO_OPERACION

        On Error Resume Next
        'PP_FORMA.Visible = False
        PP_FORMA.BT_AGREGAR.Enabled = (VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP1_Listado Or VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP2_Ficha)
        PP_FORMA.BT_EDITAR.Enabled = (VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP1_Listado Or VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP2_Ficha)
        PP_FORMA.BT_ELIMINAR.Enabled = (VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP1_Listado Or VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP2_Ficha)
        PP_FORMA.BT_GUARDAR.Enabled = (VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP3_Edicion Or VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP4_Clon)
        PP_FORMA.BT_CANCELAR.Enabled = (VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP3_Edicion Or VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP4_Clon)
        PP_FORMA.BT_SALIR.Enabled = (VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP1_Listado)
        PP_FORMA.BT_LISTADO.Enabled = (VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP2_Ficha)
        PP_FORMA.BT_EXPORTAR_EXCEL.Enabled = (VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP1_Listado)
        PP_FORMA.GB_FICHA.Visible = (VP_IN_MODO_OPERACION <> MOP_Modo_Operacion.MOP1_Listado)
        PP_FORMA.GB_FICHA.Visible = (VP_IN_MODO_OPERACION <> MOP_Modo_Operacion.MOP1_Listado)
        PP_FORMA.GB_LISTADO.Enabled = (VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP1_Listado)
        PP_FORMA.GB_FILTROS.Enabled = (VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP1_Listado)
        'PP_FORMA.GB_PYC.Visible = (VP_IN_MODO_OPERACION = 4)
        PP_FORMA.PG_FRM_CONFIG()
        Codigo_FI.PG_CN_CONFIG(PP_FORMA)
        If VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP1_Listado Then
            PP_FORMA.CancelButton = PP_FORMA.BT_SALIR
        Else
            If PP_FORMA.BT_LISTADO.Enabled Then
                PP_FORMA.CancelButton = PP_FORMA.BT_LISTADO
            Else
                PP_FORMA.CancelButton = PP_FORMA.BT_CANCELAR
            End If
        End If
        On Error GoTo 0
        'PP_FORMA.Visible = True
    End Sub

    Public Shared Sub PG_FRM_CONFIG_FICHA(ByRef PP_FORMA As Object)

        Dim VP_IN_MODO_OPERACION As Integer = PP_FORMA.VM_IN_MODO_OPERACION

        On Error Resume Next
        PP_FORMA.Visible = False
        PP_FORMA.BT_AGREGAR.Enabled = (VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP1_Listado Or VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP2_Ficha)
        PP_FORMA.BT_EDITAR.Enabled = (VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP1_Listado Or VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP2_Ficha)
        PP_FORMA.BT_ELIMINAR.Enabled = (VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP1_Listado Or VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP2_Ficha)
        PP_FORMA.BT_GUARDAR.Enabled = (VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP3_Edicion Or VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP4_Clon)
        PP_FORMA.BT_CANCELAR.Enabled = (VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP3_Edicion Or VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP4_Clon)
        PP_FORMA.BT_SALIR.Enabled = (VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP3_Edicion Or VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP4_Clon)
        PP_FORMA.BT_LISTADO.Enabled = (VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP2_Ficha)
        PP_FORMA.BT_EXPORTAR_EXCEL.Enabled = (VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP1_Listado)
        PP_FORMA.GB_FICHA.Visible = (VP_IN_MODO_OPERACION <> MOP_Modo_Operacion.MOP1_Listado)
        'PP_FORMA.GB_FICHA.Visible = (VP_IN_MODO_OPERACION <> 1)
        PP_FORMA.GB_LISTADO.Enabled = (VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP1_Listado)
        PP_FORMA.GB_FILTROS.Enabled = (VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP1_Listado)
        'PP_FORMA.GB_PYC.Visible = (VP_IN_MODO_OPERACION = 4)
        PP_FORMA.PG_FRM_CONFIG()
        Codigo_FI.PG_CN_CONFIG(PP_FORMA)
        If VP_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP1_Listado Then
            PP_FORMA.CancelButton = PP_FORMA.BT_SALIR
        Else
            If PP_FORMA.BT_LISTADO.Enabled Then
                PP_FORMA.CancelButton = PP_FORMA.BT_LISTADO
            Else
                PP_FORMA.CancelButton = PP_FORMA.BT_CANCELAR
            End If
        End If
        On Error GoTo 0
        PP_FORMA.Visible = True
    End Sub



    Public Shared Sub PG_FRM_BT_SET_TOOLTIP(ByRef PP_FORMA As Object)

        On Error Resume Next

        Dim VP_TOOLTIP_AGREGAR As New ToolTip
        VP_TOOLTIP_AGREGAR.SetToolTip(PP_FORMA.BT_AGREGAR, "Agregar")
        Dim VP_TOOLTIP_EDITAR As New ToolTip
        VP_TOOLTIP_EDITAR.SetToolTip(PP_FORMA.BT_EDITAR, "Editar")
        Dim VP_TOOLTIP_ELIMINAR As New ToolTip
        VP_TOOLTIP_ELIMINAR.SetToolTip(PP_FORMA.BT_ELIMINAR, "Eliminar")
        Dim VP_TOOLTIP_GUARDAR As New ToolTip
        VP_TOOLTIP_GUARDAR.SetToolTip(PP_FORMA.BT_GUARDAR, "Guardar")
        Dim VP_TOOLTIP_CANCELAR As New ToolTip
        VP_TOOLTIP_CANCELAR.SetToolTip(PP_FORMA.BT_CANCELAR, "Cancelar")
        Dim VP_TOOLTIP_LISTADO As New ToolTip
        VP_TOOLTIP_LISTADO.SetToolTip(PP_FORMA.BT_LISTADO, "Volver al Listado")
        Dim VP_TOOLTIP_SALIR As New ToolTip
        VP_TOOLTIP_SALIR.SetToolTip(PP_FORMA.BT_SALIR, "Salir")
        Dim VP_TOOLTIP_EXPORTAR_EXCEL As New ToolTip
        VP_TOOLTIP_EXPORTAR_EXCEL.SetToolTip(PP_FORMA.BT_EXPORTAR_EXCEL, "Exportar a Excel")
        Dim VP_TOOLTIP_BUSCAR As New ToolTip
        VP_TOOLTIP_BUSCAR.SetToolTip(PP_FORMA.BT_LI_BUSCAR, "Buscar")
        Dim VP_TOOLTIP_FILTROS As New ToolTip
        VP_TOOLTIP_FILTROS.SetToolTip(PP_FORMA.GB_FILTROS, "Criterios de Búsqueda")
        Dim VP_TOOLTIP_GB_LISTADO As New ToolTip
        VP_TOOLTIP_GB_LISTADO.SetToolTip(PP_FORMA.GB_LISTADO, "Listado")
        Dim VP_TOOLTIP_FICHA As New ToolTip
        VP_TOOLTIP_FICHA.SetToolTip(PP_FORMA.GB_FICHA, "Ficha")
        Dim VP_TOOLTIP_CONTROL As New ToolTip
        VP_TOOLTIP_CONTROL.SetToolTip(PP_FORMA.GB_CONTROL, "Control")
        Dim VP_TOOLTIP_HERRAMIENTAS As New ToolTip
        VP_TOOLTIP_HERRAMIENTAS.SetToolTip(PP_FORMA.FL_MENU_1, "Barra de Herramientas")
        VP_TOOLTIP_HERRAMIENTAS.SetToolTip(PP_FORMA.FL_MENU_2, "Barra de Herramientas")
        Dim VP_TOOLTIP_OPERACION As New ToolTip
        VP_TOOLTIP_OPERACION.SetToolTip(PP_FORMA.GB_OPERACION, "Operación")
        'Dim VP_TOOLTIP_LI_LISTADO As New ToolTip
        'VP_TOOLTIP_LI_LISTADO.SetToolTip(PP_FORMA.LI_LISTADO, "Listado")
        Dim VP_TOOLTIP_CLON As New ToolTip
        VP_TOOLTIP_CLON.SetToolTip(PP_FORMA.BT_CLONAR, "Clonar Registro")
        'BT_CLONAR


        'REVISA TODOS LOS BOTONES DE LA FORMA PARA PONERLE TOOLTIP A LOS BOTONES ESPECIALES
        Dim VP_BOTONES_DE_LA_FORMA As New Collection
        PG_CONTROLS_CHILDRENS_GET_X_NAME(PP_FORMA, GetType(Button), VP_BOTONES_DE_LA_FORMA)
        For Each VP_BOTON As Button In VP_BOTONES_DE_LA_FORMA
            Codigo_BT.PG_BT_TOOLTIP_ADD(VP_BOTON)
        Next

        'REVISA TODOS LOS MASKEDTEXTBOX PARA PONERLES TOOLTIP DEL FORMATO DE FECHA VALIDO
        Dim VP_MASKEDTEXTBOX_DE_LA_FORMA As New Collection
        PG_CONTROLS_CHILDRENS_GET(PP_FORMA, GetType(MaskedTextBox), VP_MASKEDTEXTBOX_DE_LA_FORMA)
        For Each VP_MASKEDTEXTBOX As MaskedTextBox In VP_MASKEDTEXTBOX_DE_LA_FORMA
            Codigo_CTRL.PG_MT_TOOLTIP_ADD(VP_MASKEDTEXTBOX)
        Next


        On Error GoTo 0

    End Sub

    Public Shared Sub PG_FRM_CTRL_ADD_EVENTS(ByRef PP_FORMA As Object)

        On Error Resume Next

        Dim VP_TEXTBOX As TextBox = PP_FORMA.TB_LI_BUSCAR
        VP_TEXTBOX.Tag = PP_FORMA
        AddHandler VP_TEXTBOX.KeyPress, AddressOf EG_TB_BUSCAR

        On Error GoTo 0

    End Sub

    Private Shared Sub EG_TB_BUSCAR(sender As Object, e As KeyPressEventArgs)
        On Error Resume Next
        Dim VP_FORMA As Object = sender.Tag
        Dim VP_TB_LI_BUSCAR As TextBox = sender
        'If VP_TB_LI_BUSCAR.Text.LongCount > 3 Then
        '    VP_FORMA.PM_BT_BUSCAR_CLICK(VP_FORMA, VP_FORMA.LI_LISTADO)
        'Else
        If e.KeyChar = ChrW(Keys.Enter) Then
            VP_FORMA.PM_BT_BUSCAR_CLICK(VP_FORMA, VP_FORMA.LI_LISTADO)
        End If
        On Error GoTo 0
    End Sub

    Public Shared Sub PG_TI_TICK(ByRef PP_LABEL As Label)
        PP_LABEL.Text = DateTime.Now.ToString
    End Sub

    Public Shared Sub PG_FRM_INIT(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object)
        On Error Resume Next
        PP_FORMA.Visible = False
        PG_FRM_INIT_BASIC(PP_FORMA)
        PG_FRM_TITLE_CHANGE(PP_BD_Index, PP_FORMA)
        PP_FORMA.VM_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP1_Listado
        PP_FORMA.VM_BD_Index = PP_BD_Index
        PG_FRM_CONFIG(PP_FORMA)
        PG_FRM_VER_GET(PP_FORMA)
        PP_FORMA.WindowState = FormWindowState.Maximized
        PP_FORMA.BackColor = Color.White
        PP_FORMA.TI_RELOJ.Start()
        Codigo_FRM.PG_FRM_BT_SET_TOOLTIP(PP_FORMA)
        PP_FORMA.PM_CB_INIT()
        PP_FORMA.PM_LI_INIT()
        PP_FORMA.PM_BT_INIT()
        PP_FORMA.PM_CH_INIT()
        PP_FORMA.PM_TB_INIT()
        PP_FORMA.PM_RD_INIT()
        PP_FORMA.PM_DT_INIT()
        Codigo_FRM.PG_FRM_BT_INIT(PP_FORMA)
        PP_FORMA.Visible = True
        PG_FRM_CTRL_ADD_EVENTS(PP_FORMA)
        'AddHandler PP_FORMA.l, AddressOf LimpiarCombos



        Codigo_Permiso.PG_CONSULTAR_PERMISOS(PP_BD_Index, PP_FORMA, VG_USUARIO_ACCION)

        PG_FRM_CONFIG(PP_FORMA)

        On Error GoTo 0
    End Sub

    Public Shared Sub PG_FRM_INIT_FICHA(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object)
        On Error Resume Next
        PP_FORMA.Visible = False
        PG_FRM_INIT_BASIC(PP_FORMA)
        PG_FRM_TITLE_CHANGE(PP_BD_Index, PP_FORMA)
        PP_FORMA.VM_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP3_Edicion
        PP_FORMA.VM_BD_Index = PP_BD_Index
        PG_FRM_CONFIG_FICHA(PP_FORMA)
        PG_FRM_VER_GET(PP_FORMA)
        PP_FORMA.WindowState = FormWindowState.Maximized
        PP_FORMA.BackColor = Color.White
        PP_FORMA.TI_RELOJ.Start()
        Codigo_FRM.PG_FRM_BT_SET_TOOLTIP(PP_FORMA)
        PP_FORMA.PM_CB_INIT()
        'PP_FORMA.PM_LI_INIT()
        PP_FORMA.PM_BT_INIT()
        PP_FORMA.PM_CH_INIT()
        PP_FORMA.PM_RD_INIT()
        PP_FORMA.PM_DT_INIT()
        PP_FORMA.PM_TB_INIT()
        Codigo_FRM.PG_FRM_BT_INIT(PP_FORMA)
        PP_FORMA.Visible = True
        On Error GoTo 0
    End Sub

    Public Shared Sub PG_FRM_INIT_BASIC(ByRef PP_FORMA As Object)
        On Error Resume Next

        PP_FORMA.DoubleBuffered = True
        Dim VP_FORMA As Form = PP_FORMA
        'AddHandler VP_FORMA.MouseDown, AddressOf MoveForm_MouseDown
        'AddHandler VP_FORMA.MouseMove, AddressOf MoveForm_MouseMove
        'AddHandler VP_FORMA.MouseUp, AddressOf MoveForm_MouseUp


        On Error GoTo 0
    End Sub


    Private Shared Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            sender.Cursor = Cursors.Default
        End If
    End Sub

    Private Shared Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs)
        If MoveForm Then
            sender.Location = sender.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Private Shared Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            sender.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Public Shared Sub PG_FRM_LI_DATA_CONTROL_LOAD(ByRef PP_LISTADO As DataGridView, ByVal PP_ROW As Integer, ByRef PP_COLUMNA As Integer, ByRef PP_ROW_DATA As DataRow)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, "K_USUARIO_ALTA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, "F_ALTA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, "K_USUARIO_CAMBIO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, "D_USUARIO_CAMBIO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, "F_CAMBIO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, "L_BORRADO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, "K_USUARIO_BAJA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, "F_BAJA")

    End Sub

    Public Shared Sub PG_FRM_LI_FORMAT_CONTROL_LOAD(ByRef PP_LISTADO As DataGridView, ByVal PP_ANCHO As Integer, ByVal PP_ALINEACION As Integer, ByVal PP_EDIT As Integer, ByVal PP_VISIBLE As Integer, ByVal PP_FROZEN As Integer, ByVal PP_FORMATO As Integer)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LISTADO, "K_USUARIO_ALTA", "Usuario Alta", GetType(Integer), PP_ANCHO, PP_ALINEACION, PP_EDIT, PP_VISIBLE, PP_FROZEN, PP_FORMATO)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LISTADO, "F_ALTA", "Fecha Alta", GetType(String), PP_ANCHO, PP_ALINEACION, PP_EDIT, PP_VISIBLE, PP_FROZEN, PP_FORMATO)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LISTADO, "K_USUARIO_CAMBIO", "Modificó", GetType(Integer), PP_ANCHO, PP_ALINEACION, PP_EDIT, PP_VISIBLE, PP_FROZEN, PP_FORMATO)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LISTADO, "D_USUARIO_CAMBIO", "Modificó", GetType(String), PP_ANCHO, PP_ALINEACION, PP_EDIT, 1, PP_FROZEN, PP_FORMATO)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LISTADO, "F_CAMBIO", "Actualización", GetType(String), 140, PP_ALINEACION, PP_EDIT, 1, PP_FROZEN, PP_FORMATO)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LISTADO, "L_BORRADO", "Borrado", GetType(Integer), PP_ANCHO, PP_ALINEACION, PP_EDIT, PP_VISIBLE, PP_FROZEN, PP_FORMATO)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LISTADO, "K_USUARIO_BAJA", "Usuario Baja", GetType(Integer), PP_ANCHO, PP_ALINEACION, PP_EDIT, PP_VISIBLE, PP_FROZEN, PP_FORMATO)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LISTADO, "F_BAJA", "Fecha Baja", GetType(String), PP_ANCHO, PP_ALINEACION, PP_EDIT, PP_VISIBLE, PP_FROZEN, PP_FORMATO)
    End Sub

    Public Shared Sub PG_FRM_BT_INIT(ByVal PP_FORMA As Form)
        Dim VP_CONTROLES As New Collection
        PG_CONTROLS_CHILDRENS_GET(PP_FORMA, GetType(Button), VP_CONTROLES)
        For Each VP_CONTROL As Button In VP_CONTROLES
            Codigo_BT.PG_BT_INIT(VP_CONTROL)
        Next
    End Sub


End Class
