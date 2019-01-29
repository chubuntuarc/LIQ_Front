Imports System.Windows.Forms.DataVisualization.Charting
Public Class FO_CUENTA_BANCO_UO_AS

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_ID_ROW As Integer = -1
    Public VM_K_UNIDAD_OPERATIVA As Integer = 0
    Public VM_FO_CUENTA_BANCO As FO_CUENTA
    Public VM_BANDERA_CARGA_FO_CUENTA_BANCO As Boolean = False
#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, "", True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, -1, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, -1, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, -1, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, -1, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, -1, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, -1, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean) As String
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_CUENTA_BANCO_UO.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_CUENTA_BANCO_UO, False)
            PP_NUEVO = False
        End If

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_TIPO_CUENTA_BANCO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_CUENTA_BANCO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_PRINCIPAL, False)

        Return VP_PARAMETROS
    End Function


    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "D_UNIDAD_OPERATIVA")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_CUENTA_BANCO_UO")
        Return VP_ID
    End Function

    Public Function FM_CUENTA_UO_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_PARAMETROS As String = ""
        Dim VP_CUENTA_BANCO As Integer = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_CUENTA_BANCO")
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_CUENTA_BANCO, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_VALOR As String)
        Codigo_CTRL.PG_CB_MAYOR_A_CERO(PP_VALOR, CB_TIPO_CUENTA_BANCO)
        Codigo_CTRL.PG_TB_MAYOR_A_CERO(PP_VALOR, TB_K_CUENTA_BANCO)
        Return True
    End Function

#End Region

#Region "SUB_PM_INIT"

    Public Sub PM_FO_SHOW(ByRef PP_NOMBRE_TABLA As String, ByVal PP_ID_BASE_DE_DATOS As String)
        VM_NOMBRE_TABLA = PP_NOMBRE_TABLA
        VM_ID_BASE_DE_DATOS = PP_ID_BASE_DE_DATOS
        Show()
    End Sub

    Public Sub PM_CB_INIT()
        Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_UNIDAD_OPERATIVA)
        Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_TIPO_CUENTA_BANCO)
    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
    End Sub

    Private Sub PM_FO_INIT(ByRef PP_FORMA As Object)
        Codigo_FRM.PG_FRM_INIT(VM_ID_BASE_DE_DATOS, PP_FORMA)
        VM_FO_CUENTA_BANCO = New FO_CUENTA
        VM_FO_CUENTA_BANCO.VM_ID_BASE_DE_DATOS = VM_ID_BASE_DE_DATOS
        VM_FO_CUENTA_BANCO.VM_NOMBRE_TABLA = "CUENTA_BANCO"
        VM_FO_CUENTA_BANCO.FormBorderStyle = FormBorderStyle.None
        VM_FO_CUENTA_BANCO.TopLevel = False
        ' Codigo_FRM.PG_FRM_INIT(VM_ID_BASE_DE_DATOS, VM_FO_CUENTA_BANCO)
        'VM_FO_CUENTA_BANCO.Margin = New Padding(-13, -52, -13, 0)
        ' VM_FO_CUENTA_BANCO.Padding = New Padding(-13, -52, -13, 0)
        Panel1.Padding = New Padding(0, -52, 0, 0)
        VM_FO_CUENTA_BANCO.Dock = DockStyle.Fill
        ' VM_FO_CUENTA_BANCO.Size = New Size((Panel1.Size.Width - 20), (Panel1.Size.Height - 20))
        'VM_FO_CUENTA_BANCO.Location = New Point(-13, -50)
        Panel1.Controls.Add(VM_FO_CUENTA_BANCO)
        VM_FO_CUENTA_BANCO.FL_MENU_1.Visible = False
        VM_FO_CUENTA_BANCO.FL_MENU_2.Visible = False
        Dim VP_UNIDAD As String = ""
        If VM_K_UNIDAD_OPERATIVA > 0 Then
            Codigo_CB.PG_CB_VALUE_LOAD(CB_UNIDAD_OPERATIVA, VM_K_UNIDAD_OPERATIVA)
            PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
            CB_UNIDAD_OPERATIVA.Enabled = False
        End If
        VP_UNIDAD = Codigo_CB.FG_CB_ITEM_TEXT(CB_UNIDAD_OPERATIVA)
        VM_FO_CUENTA_BANCO.TB_LI_BUSCAR.Text = VP_UNIDAD.Substring(0, VP_UNIDAD.Length - 7)
        VM_FO_CUENTA_BANCO.Visible = True
        VM_FO_CUENTA_BANCO.PM_BT_BUSCAR_CLICK(VM_FO_CUENTA_BANCO, VM_FO_CUENTA_BANCO.LI_LISTADO)
        VM_BANDERA_CARGA_FO_CUENTA_BANCO = True
        RemoveHandler VM_FO_CUENTA_BANCO.LI_LISTADO.CellDoubleClick, AddressOf VM_FO_CUENTA_BANCO.LI_LISTADO_CellDoubleClick
        GB_FICHA.Visible = True
    End Sub

#End Region

#Region "SUBS_PM"


    ''' <summary>
    ''' 'FUNCIÓN QUE CARGARÁ LA PARTE DE LA FICHA
    ''' </summary>
    Public Sub PM_FI_LOAD(ByVal PP_ID As String)
        Codigo_FI.FG_FI_LOAD_X_ID(VM_ID_BASE_DE_DATOS, Me, PP_ID)
    End Sub


    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_CUENTA_BANCO_UO, PP_ROW, "")
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_D_CUENTA_BANCO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_CUENTA_BANCO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CUENTA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CLABE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_TIPO_CUENTA_BANCO, PP_ROW, "0")
        Codigo_CTRL.PG_CO_DATA_LOAD("", CH_L_PRINCIPAL, PP_ROW, "0")
    End Sub


    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 20)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, 
        '            ANCHO_CELDA, ALINEACION, SOLO_LECTURA, Visible, FROZEN, FORMAT
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_CUENTA_BANCO_UO", "#CBU", GetType(Integer), 50, 2, 0, 0, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_CUENTA_BANCO", "#CTA", GetType(Integer), 50, 2, 0, 1, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_CUENTA_BANCO", "Cuenta Bancaria", GetType(String), 400, 1, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_RAZON_SOCIAL", "Razón Social", GetType(String), 80, 1, 0, 1, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ESTATUS_CUENTA_BANCO", "Estatus", GetType(String), 70, 2, 0, 1, 0, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_TIPO_CUENTA_BANCO", "Tipo", GetType(String), 50, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "L_PRINCIPAL", "Principal", GetType(CheckBox), 70, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_BANCO", "Banco", GetType(String), 50, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_MONEDA", "Moneda", GetType(String), 50, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "CUENTA", "Cuenta", GetType(String), 80, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "CLABE", "CLABE", GetType(String), 100, 2, 0, 1, 0, 0)
    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_CUENTA_BANCO_UO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_CUENTA_BANCO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_CUENTA_BANCO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_RAZON_SOCIAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ESTATUS_CUENTA_BANCO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_TIPO_CUENTA_BANCO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "L_PRINCIPAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_BANCO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_MONEDA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CUENTA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CLABE")

    End Sub

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_BUSCAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
        GB_FICHA.Visible = True
    End Sub

    Private Sub PM_BT_LISTADO_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_LISTADO_CLICK(PP_FORMA)
    End Sub

    Private Sub PM_BT_SALIR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_SALIR_CLICK(PP_FORMA)
    End Sub

    Private Sub PM_BT_MAS_UNO_CLICK(ByRef PP_FORMA As Object)
        Dim VP_PARAMETROS As String = ""
        Dim VP_ID As String
        Dim VP_LISTADO = VM_FO_CUENTA_BANCO.LI_LISTADO
        If VP_LISTADO.Rows.Count > 0 Then
            Dim VP_ROW As Integer = Codigo_LI.FG_LI_ROW_CURRENT(VP_LISTADO)
            If VP_ROW > -1 Then
                VP_ID = VM_FO_CUENTA_BANCO.FM_ID_SELECCIONADO(VP_LISTADO, VP_ROW)
                Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_UNIDAD_OPERATIVA, False)
                Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_ID, False)
                PM_FI_LOAD(VP_PARAMETROS)
                If Codigo_CTRL.FG_CO_VALUE(TB_K_CUENTA_BANCO_UO).ToString() = "" Then
                    BT_ELIMINAR.Enabled = False
                End If
                VM_IN_MODO_OPERACION = Modo_Operacion.Edición
                Codigo_FRM.PG_FRM_CONFIG(Me)
                BT_GUARDAR.Enabled = True
            Else
                Codigo_Message.PG_MENSAJE_AVISO("Seleccione una cuenta bancaria")
            End If
        End If
        GB_FICHA.Visible = True
    End Sub

    Public Sub PM_BT_GUARDAR_CLICK(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_GUARDAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
        Codigo_FI.PG_FI_CONTROL_CLEAR(GB_FICHA)
        GB_FICHA.Visible = True
    End Sub

    Public Sub PM_BT_ELIMINAR_CLICK(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        If Codigo_LI.FG_LI_ROW_CURRENT(PP_LISTADO) > -1 Then
            Codigo_ABC.PG_BT_ELIMINAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
        Else
            Codigo_Message.PG_MENSAJE_AVISO("Seleccione un elemento para eliminarlo")
        End If
        Codigo_FI.PG_FI_CONTROL_CLEAR(GB_FICHA)
        GB_FICHA.Visible = True
    End Sub

    Private Sub PM_TI_TICK(ByRef PP_LABEL As Label)
        Codigo_FRM.PG_TI_TICK(PP_LABEL)
    End Sub

#End Region

#Region "EVENTOS"
    Private Sub DATA_ACCESO_UO_AS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT(Me)
    End Sub

    Private Sub BT_MAS_UNO_Click(sender As Object, e As EventArgs) Handles BT_MAS_UNO.Click
        PM_BT_MAS_UNO_CLICK(Me)
    End Sub

    Private Sub BT_SALIR_Click(sender As Object, e As EventArgs) Handles BT_SALIR.Click
        PM_BT_SALIR_CLICK(Me)
    End Sub

    Private Sub TI_RELOJ_Tick(sender As Object, e As EventArgs) Handles TI_RELOJ.Tick
        PM_TI_TICK(LB_RELOJ)
    End Sub

    Private Sub CB_UNIDAD_OPERATIVA_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_UNIDAD_OPERATIVA.SelectedValueChanged
        If Codigo_CB.FG_CB_ITEM_VALUE(CB_UNIDAD_OPERATIVA) <> "-1" And Visible And VM_BANDERA_CARGA_FO_CUENTA_BANCO Then
            Dim VP_UNIDAD = Codigo_CB.FG_CB_ITEM_TEXT(CB_UNIDAD_OPERATIVA)
            VM_FO_CUENTA_BANCO.TB_LI_BUSCAR.Text = VP_UNIDAD.Substring(0, VP_UNIDAD.Length - 7)
            VM_FO_CUENTA_BANCO.PM_BT_BUSCAR_CLICK(VM_FO_CUENTA_BANCO, VM_FO_CUENTA_BANCO.LI_LISTADO)
            PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
        End If
    End Sub

    Private Sub BT_GUARDAR_Click(sender As Object, e As EventArgs) Handles BT_GUARDAR.Click
        PM_BT_GUARDAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub BT_ELIMINAR_Click(sender As Object, e As EventArgs) Handles BT_ELIMINAR.Click
        PM_BT_ELIMINAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub LI_LISTADO_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LI_LISTADO.CellDoubleClick
        Dim VP_ID As String = ""
        If LI_LISTADO.Rows.Count > 0 Then
            Dim VP_ROW As Integer = Codigo_LI.FG_LI_ROW_CURRENT(LI_LISTADO)
            VP_ID = FM_CUENTA_UO_SELECCIONADO(LI_LISTADO, VP_ROW)
            PM_FI_LOAD(VP_ID)
            VM_IN_MODO_OPERACION = Modo_Operacion.Edición
            Codigo_FRM.PG_FRM_CONFIG(Me)
            BT_GUARDAR.Enabled = True
        End If
    End Sub


#End Region

End Class