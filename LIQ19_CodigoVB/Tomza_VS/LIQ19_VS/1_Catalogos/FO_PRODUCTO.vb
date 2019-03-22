Public Class FO_PRODUCTO

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESTATUS_PRODUCTO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIPO_PRODUCTO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_UNIDAD, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_PRODUCTO.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_PRODUCTO, False)
            PP_NUEVO = False
        End If

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_D_PRODUCTO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_S_PRODUCTO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_O_PRODUCTO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ESTATUS_PRODUCTO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_TIPO_PRODUCTO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_UNIDAD, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CANTIDAD, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_FACTOR_KILOS, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_FACTOR_LITROS, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CANTIDAD_KILOS, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CANTIDAD_LITROS, False)

        Return VP_PARAMETROS

    End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "D_PRODUCTO")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_PRODUCTO")
        Return VP_ID
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean
        Codigo_FI.PG_FI_FIELDS_VALIDATE(GB_FICHA, VP_VALIDACION, PP_MENSAJE_VALIDACION)

        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_CANTIDAD)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_FACTOR_KILOS)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_FACTOR_LITROS)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_CANTIDAD_KILOS)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_CANTIDAD_LITROS)

        VP_VALIDACION = (PP_MENSAJE_VALIDACION = "")
        Return VP_VALIDACION
    End Function

#End Region

#Region "SUB_PM_INIT"

    Public Sub PM_FO_SHOW(ByRef PP_NOMBRE_TABLA As String, ByVal PP_ID_BASE_DE_DATOS As String)
        VM_NOMBRE_TABLA = "PUNTO_VENTA"
        VM_ID_BASE_DE_DATOS = PP_ID_BASE_DE_DATOS
        Me.Show()
    End Sub

    Public Sub PM_CB_INIT()
        Codigo_FI.PG_FI_CONTROL_DATA_SETUP(VM_ID_BASE_DE_DATOS, Me)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_ESTATUS_PRODUCTO, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_TIPO_PRODUCTO, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD, "")

        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ESTATUS_PRODUCTO, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_TIPO_PRODUCTO, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_UNIDAD, "")

    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
    End Sub

    Public Sub PM_TB_INIT()
        LIQ19_Codigo.PG_TB_INIT(TB_CANTIDAD, 1)
        LIQ19_Codigo.PG_TB_INIT(TB_FACTOR_KILOS, 2)
        LIQ19_Codigo.PG_TB_INIT(TB_FACTOR_LITROS, 1)
        LIQ19_Codigo.PG_TB_INIT(TB_CANTIDAD_KILOS, 2)
        LIQ19_Codigo.PG_TB_INIT(TB_CANTIDAD_LITROS, 2)
    End Sub

    Private Sub PM_FO_INIT(ByRef PP_FORMA As Object)
        Codigo_FRM.PG_FRM_INIT(VM_ID_BASE_DE_DATOS, PP_FORMA)
    End Sub

#End Region

#Region "SUBS_PM"

    ''' <summary>
    ''' 'FUNCION QUE CARGARA LA PARTE DE LA FICHA
    ''' </summary>
    Public Sub PM_FI_LOAD(ByVal PP_ID As String)
        Codigo_FI.FG_FI_LOAD_X_ID(VM_ID_BASE_DE_DATOS, Me, PP_ID)

    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)

        If VM_IN_MODO_OPERACION <> MOP_Modo_Operacion.MOP4_Clon Then
            Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_PRODUCTO, PP_ROW)
            Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)
        End If

        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_PRODUCTO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_D_PRODUCTO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_S_PRODUCTO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_O_PRODUCTO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ESTATUS_PRODUCTO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_TIPO_PRODUCTO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_UNIDAD, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CANTIDAD, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_FACTOR_KILOS, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_FACTOR_LITROS, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CANTIDAD_KILOS, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CANTIDAD_LITROS, PP_ROW)
        ''-----------------------------------------------------------------''


    End Sub

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 17)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, 
        '            ANCHO_CELDA, ALINEACION, SOLO_LECTURA, Visible, FROZEN, FORMAT
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_PRODUCTO", "#PRO", GetType(Integer), 50, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_PRODUCTO", "Producto", GetType(String), 150, 1, 0, 1, 1, 0, Nothing, Color.LightYellow, 1)

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_ESTATUS_PRODUCTO", "Estatus", GetType(String), 60, 2, 0, 1, 0, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_TIPO_PRODUCTO", "Tipo", GetType(String), 60, 2, 0, 1, 0, 0, Color.Orange, Nothing, 1)

        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)

    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_PRODUCTO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_PRODUCTO")

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_ESTATUS_PRODUCTO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_TIPO_PRODUCTO")

        Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)

    End Sub

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_BUSCAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
    End Sub

    Private Sub PM_BT_AGREGAR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_AGREGAR_CLICK(PP_FORMA)
        PM_TB_INIT()
    End Sub

    Private Sub PM_BT_CANCELAR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_CANCELAR_CLICK(PP_FORMA)
    End Sub

    Private Sub PM_BT_SALIR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_SALIR_CLICK(PP_FORMA)
    End Sub

    Private Sub PM_BT_EDITAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_EDITAR_CLICK(PP_FORMA, PP_LISTADO)
    End Sub

    Public Sub PM_BT_GUARDAR_CLICK(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_GUARDAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
    End Sub

    Public Sub PM_BT_ELIMINAR_CLICK(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_ELIMINAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
    End Sub

    Private Sub PM_TI_TICK(ByRef PP_LABEL As Label)
        Codigo_FRM.PG_TI_TICK(PP_LABEL)
    End Sub

    Private Sub PM_BT_LISTADO_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_LISTADO_CLICK(PP_FORMA)
    End Sub

    Private Sub PM_BT_EXPORTAR_EXCEL_CLICK(ByRef PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_EXPORTAR_EXCEL_CLICK(PP_LISTADO)
    End Sub

    Public Sub PM_LI_SAVE(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        PM_BT_BUSCAR_CLICK(PP_FORMA, PP_LISTADO)
    End Sub

    Public Sub PM_MODO_AUXILIAR()

    End Sub

    Private Sub PM_BT_CLONAR_CLICK(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_CLONAR_CLICK(PP_FORMA, PP_LISTADO)
    End Sub

#End Region

#Region "EVENTOS"

    Private Sub BT_AGREGAR_Click(sender As Object, e As EventArgs) Handles BT_AGREGAR.Click
        PM_BT_AGREGAR_CLICK(Me)
    End Sub

    Private Sub BT_BUSCAR_Click(sender As Object, e As EventArgs) Handles BT_LI_BUSCAR.Click
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub Catalogo_T1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT(Me)
    End Sub

    Private Sub BT_CANCELAR_Click(sender As Object, e As EventArgs) Handles BT_CANCELAR.Click
        PM_BT_CANCELAR_CLICK(Me)
    End Sub

    Private Sub BT_SALIR_Click(sender As Object, e As EventArgs) Handles BT_SALIR.Click
        PM_BT_SALIR_CLICK(Me)
    End Sub

    Private Sub BT_GUARDAR_Click(sender As Object, e As EventArgs) Handles BT_GUARDAR.Click
        PM_BT_GUARDAR_CLICK(Me, LI_LISTADO) 'YA QUE SE TIENE EL ID DEL PDV, SE GUARDAN LOS DATOS DEL AUTOTANQUE.
    End Sub

    Private Sub BT_EDITAR_Click(sender As Object, e As EventArgs) Handles BT_EDITAR.Click
        PM_BT_EDITAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub BT_ELIMINAR_Click(sender As Object, e As EventArgs) Handles BT_ELIMINAR.Click
        PM_BT_ELIMINAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub TI_RELOJ_Tick(sender As Object, e As EventArgs) Handles TI_RELOJ.Tick
        PM_TI_TICK(LB_RELOJ)
    End Sub

    Private Sub BT_LISTADO_Click(sender As Object, e As EventArgs) Handles BT_LISTADO.Click
        PM_BT_LISTADO_CLICK(Me)
    End Sub

    Private Sub BT_EXPORTAR_EXCEL_Click(sender As Object, e As EventArgs) Handles BT_EXPORTAR_EXCEL.Click
        PM_BT_EXPORTAR_EXCEL_CLICK(LI_LISTADO)
    End Sub

    Private Sub LI_LISTADO_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LI_LISTADO.CellDoubleClick
        If e.RowIndex <> -1 Then
            Codigo_LI.PG_LI_DOUBLE_CLICK(Me, LI_LISTADO)
        End If
    End Sub

    Private Sub BT_CLONAR_Click(sender As Object, e As EventArgs) Handles BT_CLONAR.Click
        PM_BT_CLONAR_CLICK(Me, LI_LISTADO)
    End Sub

#End Region

End Class