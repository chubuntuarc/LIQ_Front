Public Class FO_RESUMEN_FLUJO_DIARIO_X_UNO

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_ID_VERSION As Integer = 0

#End Region

#Region "VARIABLES LOCALES"

    Dim VL_HOY As Date = Now.ToString("dd/MM/yyyy")
    Dim VL_AYER As Date = Now.AddDays(-1).ToString("dd/MM/yyyy")

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESTATUS_RESUMEN_FLUJO_DIARIO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIPO_UO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ZONA_UO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_RAZON_SOCIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_F_INICIAL, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_F_FINAL, True)
        Return VP_PARAMETROS
    End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "COD_DESCRIPCION")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_MOVIMIENTO_BANCO")
        Return VP_ID
    End Function

#End Region

#Region "SUB_PM_INIT"

    Public Sub PM_FO_SHOW(ByRef PP_NOMBRE_TABLA As String, ByVal PP_ID_BASE_DE_DATOS As String)
        VM_NOMBRE_TABLA = PP_NOMBRE_TABLA
        VM_ID_BASE_DE_DATOS = PP_ID_BASE_DE_DATOS
        Me.Show()
    End Sub

    Public Sub PM_CB_INIT()
        Codigo_FI.PG_FI_CONTROL_DATA_SETUP(VM_ID_BASE_DE_DATOS, Me)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_ESTATUS_RESUMEN_FLUJO_DIARIO, "ESTATUS_RESUMEN_FLUJO_DIARIO")
        Codigo_CB.PG_CB_RAZON_SOCIAL_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_RAZON_SOCIAL, 1, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_ZONA_UO_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_ZONA_UO, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_TIPO_UO, "TIPO_UO")
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 1, CB_LI_ZONA_UO, CB_LI_RAZON_SOCIAL, VG_USUARIO_ACCION)
    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
    End Sub

    Public Sub PM_DT_INIT()
        PM_FECHAS_FILTRO_SEMANA()
    End Sub

    Private Sub PM_FO_INIT(ByRef PP_FORMA As Object)
        Codigo_FRM.PG_FRM_INIT(VM_ID_BASE_DE_DATOS, PP_FORMA)
    End Sub

#End Region

#Region "SUBS_PM"

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)]
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_RESUMEN_FLUJO_DIARIO_X_UNO", "#RFD", GetType(Integer), 65, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_RAZON_SOCIAL", "Razón Social", GetType(String), 80, 1, 0, 1, 1, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_UNIDAD_OPERATIVA", "Oficina", GetType(String), 100, 1, 0, 1, 1, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_OPERACION_DDMMMYYYY", "Fecha", GetType(Date), 100, 2, 0, 1, 0, 0, Color.Orange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ESTATUS_RESUMEN_FLUJO_DIARIO", "Estatus", GetType(String), 80, 2, 0, 1, 0, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "SALDO_INICIAL", "Saldo Inicial", GetType(Decimal), 80, 3, 0, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "INGRESO_BANCO", "Ingreso Banco", GetType(Decimal), 80, 3, 0, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "INGRESO_LIBRO", "Ingreso Libro", GetType(Decimal), 80, 3, 0, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "INGRESO_CONCILIADO", "Ingreso Conciliado", GetType(Decimal), 80, 3, 0, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "GAS", "Gas", GetType(Decimal), 80, 3, 0, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "FLETE", "Flete", GetType(Decimal), 80, 3, 0, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "OBLIGACIONES", "Obligaciones", GetType(Decimal), 80, 3, 0, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "NOMINA", "Nómina", GetType(Decimal), 80, 3, 0, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "CXP", "CxP", GetType(Decimal), 80, 3, 0, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "TRASPASOS", "Traspasos", GetType(Decimal), 80, 3, 0, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "GASTO_CORPORATIVO", "Gasto Corporativo", GetType(Decimal), 80, 3, 0, 1, 0, 1)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "SALDO_FINAL", "Saldo Final", GetType(Decimal), 80, 3, 0, 1, 0, 1)
    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_RESUMEN_FLUJO_DIARIO_X_UNO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_RAZON_SOCIAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_OPERACION_DDMMMYYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ESTATUS_RESUMEN_FLUJO_DIARIO")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "SALDO_INICIAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "INGRESO_BANCO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "INGRESO_LIBRO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "INGRESO_CONCILIADO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "GAS")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "FLETE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "OBLIGACIONES")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "NOMINA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CXP")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "TRASPASOS")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "GASTO_CORPORATIVO")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "SALDO_FINAL")
    End Sub

    Public Sub PM_FECHAS_FILTRO_SEMANA()
        TB_LI_F_INICIAL.Text = VL_HOY.AddDays(-7)
        TB_LI_F_FINAL.Text = VL_HOY
    End Sub

    Public Sub PM_FECHAS_FILTRO_HOY()
        TB_LI_F_INICIAL.Text = VL_HOY
        TB_LI_F_FINAL.Text = VL_HOY
    End Sub

    Public Sub PM_FECHAS_FILTRO_AYER()
        TB_LI_F_INICIAL.Text = VL_AYER
        TB_LI_F_FINAL.Text = VL_AYER
    End Sub

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        PM_LI_FORMAT(LI_LISTADO)
        Codigo_ABC.PG_BT_BUSCAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO, "[PG_LI_RESUMEN_FLUJO_DIARIO_X_UNO]")
    End Sub

    Private Sub PM_BT_AGREGAR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_AGREGAR_CLICK(PP_FORMA)
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

#End Region

#Region "EVENTOS"

    Private Sub Catalogo_T1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT(Me)
    End Sub

    Private Sub BT_AGREGAR_Click(sender As Object, e As EventArgs) Handles BT_AGREGAR.Click
        PM_BT_AGREGAR_CLICK(Me)
    End Sub

    Private Sub BT_BUSCAR_Click(sender As Object, e As EventArgs) Handles BT_LI_BUSCAR.Click
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub BT_CANCELAR_Click(sender As Object, e As EventArgs) Handles BT_CANCELAR.Click
        PM_BT_CANCELAR_CLICK(Me)
    End Sub

    Private Sub BT_SALIR_Click(sender As Object, e As EventArgs) Handles BT_SALIR.Click
        PM_BT_SALIR_CLICK(Me)
    End Sub

    Private Sub BT_GUARDAR_Click(sender As Object, e As EventArgs) Handles BT_GUARDAR.Click
        PM_BT_GUARDAR_CLICK(Me, LI_LISTADO)
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

    Private Sub BT_AYER_Click(sender As Object, e As EventArgs) Handles BT_AYER.Click
        PM_FECHAS_FILTRO_AYER()
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub BT_HOY_Click(sender As Object, e As EventArgs) Handles BT_HOY.Click
        PM_FECHAS_FILTRO_HOY()
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
    End Sub

#End Region

#Region "EVENTOS CHANGE VALUE DE LOS COMBOS DE ZONA Y RAZÓN SOCIAL"

    Private Sub CB_LI_ZONA_UO_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_LI_ZONA_UO.SelectedValueChanged
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 1, CB_LI_ZONA_UO, CB_LI_RAZON_SOCIAL, VG_USUARIO_ACCION)
    End Sub

    Private Sub CB_LI_RAZON_SOCIAL_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_LI_RAZON_SOCIAL.SelectedValueChanged
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 1, CB_LI_ZONA_UO, CB_LI_RAZON_SOCIAL, VG_USUARIO_ACCION)
    End Sub

#End Region

End Class