Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Public Class FO_FACTURA_GASTO_VIAJE_CAPTURA_XML

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_LISTA_XML As New List(Of XML)

#End Region

#Region "FUNCIONES_FM"
    Public Function FM_SQL_DATOS_XML(ByRef PP_XML As XML) As String
        Dim VP_PARAMETROS = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.PP_NOMBRE1.ToUpper, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_VIAJE, False)
        Codigo_CTRL.PG_CO_PARAMETRO_FECHA(VP_PARAMETROS, PP_XML.VL_XML_FECHA_MOSTRAR1, True)
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.VL_XML_FECHA_MOSTRAR1, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_FOLIO1.ToUpper, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_FORMAPAGO1.ToUpper, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_LUGAREXPEDICION1.ToUpper, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_METODO_PAGO1.ToUpper, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_MONEDA1.ToUpper, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_NOCERTIFICADO1.ToUpper, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_SERIE1.ToUpper, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_SUBTOTAL1, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_TIPOCAMBIO1.ToUpper, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_TIPODECOMPROBANTE1.ToUpper, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_TOTAL1, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_VERSION1.ToUpper, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_EMI_NOMBRE1.ToUpper, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_EMI_REGIMENFISCAL1.ToUpper, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_EMI_RFC1.ToUpper, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_REC_NOMBRE1.ToUpper, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_REC_RFC1.ToUpper, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_REC_USOCFDI1.ToUpper, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_TOTALIMPUESTOSTRASLADADOS1.ToUpper, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_IMPORTE1, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_IMPUESTO1.ToUpper, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_TASAOCUOTA1.ToUpper, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_TIPOFACTOR1.ToUpper, True)
        Codigo_CTRL.PG_CO_PARAMETRO_FECHA(VP_PARAMETROS, PP_XML.VL_XML_FECHATIMBRADO_MOSTRAR1.ToUpper, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_NOCERTIFICADOSAT1.ToUpper, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_XML.XML_UUID1.ToUpper, True)

        Return VP_PARAMETROS
    End Function

#End Region

#Region "SUB_PM_INIT"

    Public Sub PM_FO_SHOW(ByRef PP_NOMBRE_TABLA As String, ByVal PP_ID_BASE_DE_DATOS As String)
        VM_NOMBRE_TABLA = PP_NOMBRE_TABLA
        VM_ID_BASE_DE_DATOS = PP_ID_BASE_DE_DATOS
        Me.Show()
    End Sub

    Private Sub PM_FO_INIT(ByRef PP_FORMA As Object)
        Codigo_FRM.PG_FRM_INIT(VM_ID_BASE_DE_DATOS, PP_FORMA)

    End Sub


    Public Sub PM_CB_INIT()
        Codigo_FI.PG_FI_CONTROL_DATA_SETUP(VM_ID_BASE_DE_DATOS, Me)
        Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_VIAJE, "")

    End Sub
#End Region

#Region "SUBS_PM"

    ''' <summary>
    ''' 'FUNCION QUE CARGARA LA PARTE DE LA FICHA
    ''' </summary>
    Public Sub PM_FI_LOAD(ByVal PP_ID As String)
        Codigo_FI.FG_FI_LOAD_X_ID(VM_ID_BASE_DE_DATOS, Me, PP_ID)
        TB_C_FACTURA_CXP_XML.Select()
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_C_FACTURA_CXP_XML, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_FECHA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_FOLIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_FORMAPAGO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_LUGAREXPEDICION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_METODOPAGO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_MONEDA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_NOCERTIFICADO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_SERIE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_SUBTOTAL, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_TIPOCAMBIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_TIPODECOMPROBANTE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_TOTAL, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_VERSION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_EMI_NOMBRE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_EMI_REGIMENFISCAL, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_EMI_RFC, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_REC_NOMBRE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_REC_RFC, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_REC_USOCFDI, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_TOTALIMPUESTOSTRASLADADOS, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_IMPORTE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_IMPUESTO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_TASAOCUOTA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_TIPOFACTOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_FECHATIMBRADO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_NOCERTIFICADOSAT, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XML_UUID, PP_ROW)

    End Sub

    Private Sub PM_BT_CARGAR_XML_Click(ByRef PP_FORMA As Object)
        Dim VP_COUNT As Integer = LV_DIR.SelectedIndices.Count
        Me.Cursor = Cursors.WaitCursor
        Dim VP_MENSAJE As String = "Deséa procesar los " + VP_COUNT.ToString() + " archivos seccionados"
        If Codigo_Message.FG_MENSAJE_CONFIRMACION(VP_MENSAJE) Then
            LB_RESULTADO.Visible = True
            Dim VP_REFERENCIA As Integer = 1
            'VM_LISTA_XML = Codigo_XML_V1.PG_OBTENER_ATRIBUTOS(VM_ID_BASE_DE_DATOS, PP_FORMA)
            VM_LISTA_XML = Codigo_XML_V2.PG_OBTENER_ATRIBUTOS(VM_ID_BASE_DE_DATOS, PP_FORMA, LV_DIR, RT_EVENTOS, TV_DIR, VP_REFERENCIA)
            LB_RESULTADO.Visible = False

        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PM_VERIFICAR_XML_Click(ByRef PP_FORMA As Object)
        'Codigo_XML_V1.PG_VERIFICAR_VALORES(PP_FORMA)
        Codigo_XML_V2.PG_VERIFICAR_VALORES(PP_FORMA)
    End Sub

    Private Sub PM_TI_TICK(ByRef PP_LABEL As Label)
        Codigo_FRM.PG_TI_TICK(PP_LABEL)
    End Sub

    Private Sub PM_BT_CANCELAR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_CANCELAR_CLICK(PP_FORMA)
    End Sub

    Private Sub PM_BT_SALIR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_SALIR_CLICK(PP_FORMA)
    End Sub

    Private Sub FACTURA_CXP_XML_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Dim rootOfCurrentPath = Path.GetPathRoot(Environment.CurrentDirectory)
        ' Dim driveWhereWindowsIsInstalled = Path.GetPathRoot(Environment.SystemDirectory)
        'Dim lola As String = "L:\TEMPORAL\Estados de Cuenta"
        'Dim RUTA As String = My.Computer.FileSystem.GetDriveInfo(lola).RootDirectory.ToString()
        ' MsgBox(RUTA)

        'Dim drives As System.Collections.ObjectModel.ReadOnlyCollection(Of IO.DriveInfo) = My.Computer.FileSystem.Drives
        'Dim rootDir As String = String.Empty
        ''Now loop thru each drive and populate the treeview
        'For i As Integer = 0 To drives.Count - 1
        '    rootDir = drives(i).Name
        '    If rootDir Like "*C*" Then
        Dim RUTA As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Codigo_XML_V1.PG_NODOS(TV_DIR, RUTA)
        'TV_DIR.Nodes.Add(RUTA)
        '        PopulateTreeView(RUTA, TV_DIR.Nodes(i))
        '    Else
        '        TV_DIR.Nodes.Add(rootDir)
        '        'Populate this root node
        '        PopulateTreeView(rootDir, TV_DIR.Nodes(i))
        '    End If
        '    'Add this drive as a root node

        'Next

        'Dim RUTA As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        ''Dim RUTA As String = System.Environment.GetFolderPath(rootOfCurrentPath)

    End Sub

    Private Sub PopulateTreeView(ByVal dir As String, ByVal parentNode As TreeNode)
        Dim folder As String = String.Empty
        Try
            Dim folders() As String = IO.Directory.GetDirectories(dir)
            If folders.Length <> 0 Then
                Dim childNode As TreeNode = Nothing
                For Each folder In folders
                    childNode = New TreeNode(folder)
                    parentNode.Nodes.Add(childNode)
                    PopulateTreeView(folder, childNode)
                Next
            End If
        Catch ex As UnauthorizedAccessException
            parentNode.Nodes.Add(folder & ": Access Denied")
        End Try
    End Sub

    Public Sub PM_MODO_AUXILIAR()

    End Sub

    Public Sub PG_FRM_CONFIG()
        BT_VERIFICAR_XML.Enabled = (VM_IN_MODO_OPERACION = Modo_Operacion.Listado)
        BT_CARGAR_XML.Enabled = (VM_IN_MODO_OPERACION = Modo_Operacion.Listado)
        BT_SELECCIONAR_TODOS.Enabled = (VM_IN_MODO_OPERACION = Modo_Operacion.Listado)
    End Sub


#End Region

#Region "EVENTOS"

    Private Sub Catalogo_T1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT(Me)
    End Sub

    Private Sub BT_CARGAR_XML_Click(sender As Object, e As EventArgs) Handles BT_CARGAR_XML.Click
        RT_EVENTOS.Text = ""
        PM_BT_CARGAR_XML_Click(Me)
    End Sub

    Private Sub BT_CANCELAR_Click(sender As Object, e As EventArgs) Handles BT_CANCELAR.Click
        PM_BT_CANCELAR_CLICK(Me)
    End Sub

    Private Sub BT_SALIR_Click(sender As Object, e As EventArgs) Handles BT_SALIR.Click
        PM_BT_SALIR_CLICK(Me)
    End Sub

    Private Sub BT_VERIFICAR_XML_Click(sender As Object, e As EventArgs) Handles BT_VERIFICAR_XML.Click
        PM_VERIFICAR_XML_Click(Me)
    End Sub

    Private Sub TI_RELOJ_Tick(sender As Object, e As EventArgs) Handles TI_RELOJ.Tick
        PM_TI_TICK(LB_RELOJ)
    End Sub

    Private Sub TV_DIR_NodeMouseClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles TV_DIR.NodeMouseClick
        Try
            Dim newSelected As TreeNode = e.Node
            LV_DIR.Items.Clear()
            Dim nodeDirInfo As DirectoryInfo = CType(newSelected.Tag, DirectoryInfo)
            Dim subItems() As ListViewItem.ListViewSubItem
            Dim item As ListViewItem = Nothing
            For Each dir As DirectoryInfo In nodeDirInfo.GetDirectories
                item = New ListViewItem(dir.Name, 0)
                subItems = New ListViewItem.ListViewSubItem() {New ListViewItem.ListViewSubItem(item, "Directory"), New ListViewItem.ListViewSubItem(item, dir.LastAccessTime.ToShortDateString)}
                item.SubItems.AddRange(subItems)
                LV_DIR.Items.Add(item)
            Next
            For Each file As FileInfo In nodeDirInfo.GetFiles(searchPattern:="*xml")
                item = New ListViewItem(file.Name, 1)
                subItems = New ListViewItem.ListViewSubItem() {New ListViewItem.ListViewSubItem(item, "File"), New ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString)}
                item.SubItems.AddRange(subItems)
                LV_DIR.Items.Add(item)
            Next
            LV_DIR.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            LB_NOMBRE_CARPETA.Text = "carpeta actual: " + nodeDirInfo.Name
            LB_CONTEO_ARCHIVOS.Text = "XML en carpeta: " + nodeDirInfo.GetFiles(searchPattern:="*xml").Count.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BT_SELECCIONAR_TODOS_Click(sender As Object, e As EventArgs) Handles BT_SELECCIONAR_TODOS.Click
        If LV_DIR.Items.Count = 0 Then
            Codigo_Message.PG_MENSAJE_AVISO("No hay [ARCHIVOS] para seleccionar")
        Else
            Dim registro As ListViewItem
            For Each registro In LV_DIR.Items
                registro.Selected = True
            Next
            LV_DIR.Select()
            BT_VERIFICAR_XML.Enabled = False
        End If
    End Sub

    Private Sub LV_DIR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LV_DIR.SelectedIndexChanged
        If VM_IN_MODO_OPERACION = Modo_Operacion.Edición Then
            BT_VERIFICAR_XML.Enabled = False
        Else
            If LV_DIR.SelectedItems.Count < 2 Then
                BT_VERIFICAR_XML.Enabled = True
            Else
                BT_VERIFICAR_XML.Enabled = False
            End If
        End If
    End Sub

    Private Sub LL_COPIAR_A_TXT_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LL_COPIAR_A_TXT.LinkClicked
        If RT_EVENTOS.Text.Length > 3 Then
            Dim a1 = RT_EVENTOS.Lines.Count()
            Dim str As String = ""
            For i As Int32 = 0 To a1 - 1
                str = str + vbCrLf + RT_EVENTOS.Lines(i)
            Next
            Dim VP_LOG_RESULTADO As String = Path.GetTempFileName()
            File.WriteAllText(VP_LOG_RESULTADO, str)
            Process.Start("notepad.exe", VP_LOG_RESULTADO)
        End If
    End Sub
#End Region
End Class