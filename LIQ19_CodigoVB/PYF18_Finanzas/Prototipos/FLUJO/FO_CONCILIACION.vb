Public Class FO_CONCILIACION

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_ID_VERSION As Integer = 0

#End Region

#Region "VARIABLES LOCALES"

    Dim VL_HOY As Date = Now.ToString("dd/MM/yyyy")
    Dim VM_MOV_IDS As ArrayList = New ArrayList()

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ZONA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_CUENTA_BANCO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESTATUS_CONCILIACION, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, DT_LI_F_OPERACION, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_EXCLUIR_CONCILIADO, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_SQL_LISTADO_SIN_CONCILIAR() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_CUENTA_BANCO, False)
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ZONA, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_SQL_LISTADO_RESUMEN() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, "-1", False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, DT_F_CONCILIACION, True)
        Return VP_PARAMETROS
    End Function

    Public Function FM_AGREGAR_CONCILIACION(ByVal PP_ID_MOV) As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_ID_MOV, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_TIPO_LIBRO_INGRESO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, DT_F_CONCILIACION, True)
        Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
        Return VP_PARAMETROS
    End Function

    Public Function FM_QUITAR_CONCILIACION(ByVal PP_ID_MOV) As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_ID_MOV, False)
        Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FLAG(ByVal PP_ID_MOV) As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_ID_MOV, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ESTATUS_CONCILIACION, False)
        Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
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

    Public Function FM_VALIDAR_TAMANO_ARRAY() As String
        Dim PP_RESPUESTA As String = ""
        Dim VL_TAM As Integer = VM_MOV_IDS.Count
        If VL_TAM = 0 Then
            PP_RESPUESTA = "Seleccione el o los Movimientos a conciliar o marcar."
        End If
        Return PP_RESPUESTA
    End Function

#End Region

#Region "SUB_PM_INIT"

    Public Sub PM_FO_SHOW(ByRef PP_NOMBRE_TABLA As String, ByVal PP_ID_BASE_DE_DATOS As String)
        VM_NOMBRE_TABLA = PP_NOMBRE_TABLA
        VM_ID_BASE_DE_DATOS = PP_ID_BASE_DE_DATOS
        Me.Show()
    End Sub

    Public Sub PM_CB_INIT()
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_ESTATUS_CONCILIACION, "ESTATUS_CONCILIACION")
        Codigo_CB.PG_CB_ZONA_UO_TODOS_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_ZONA, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_CUENTA_BANCO_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_CUENTA_BANCO, 1, New ComboBox, New ComboBox, New ComboBox, New ComboBox, New ComboBox, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_TIPO_LIBRO_INGRESO, "TIPO_LIBRO_INGRESOS")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ESTATUS_CONCILIACION, "ESTATUS_CONCILIACION")
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_UNIDAD_OPERATIVA, 0, 0, CB_LI_ZONA, New ComboBox, VG_USUARIO_ACCION)
    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
        PM_LI_FORMAT_RESUMEN(LI_LISTADO_RESUMEN)
        PM_LI_FORMAT_SIN_CONCILIAR(LI_LISTADO_SIN_CONCILIAR)
    End Sub

    Private Sub PM_FO_INIT(ByRef PP_FORMA As Object)
        Codigo_FRM.PG_FRM_INIT(VM_ID_BASE_DE_DATOS, PP_FORMA)
        CB_ESTATUS_CONCILIACION.Enabled = True
    End Sub

    Public Sub PM_BUSCAR_SIN_CONCILIAR(ByRef PP_LISTADO As DataGridView, ByVal PP_SP As String)
        Me.Cursor = Cursors.WaitCursor

        Dim VP_PARAMETROS As String
        VP_PARAMETROS = FM_SQL_LISTADO_SIN_CONCILIAR()

        Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
        Dim VP_STORED_PROCEDURE As String = PP_SP

        Dim VP_TABLA As Data.DataTable
        VP_TABLA = Codigo_CON.FG_SP_EXECUTE_DATATABLE(VM_ID_BASE_DE_DATOS, VP_STORED_PROCEDURE, VP_PARAMETROS)

        PG_LI_LOAD_SIN_CONCILIAR(PP_LISTADO, VP_TABLA)

        Cursor = Cursors.Default
        Dim VP_REGISTROS As String
        VP_REGISTROS = VP_TABLA.Rows.Count().ToString()
        LB_RESULTADO.Text = "Resultado de la operacion: " + VP_REGISTROS + " registros." + Environment.NewLine + LB_RESULTADO.Text
    End Sub

    Public Sub PG_LI_LOAD_SIN_CONCILIAR(ByRef PP_LISTADO As DataGridView, ByVal PP_DATATABLE As DataTable)
        Codigo_LI.PG_LI_CLEAR(PP_LISTADO)

        Dim VP_LISTADO_NOMBRE = PP_LISTADO.Name
        For Each VP_ROW_DATA As DataRow In PP_DATATABLE.Rows
            Codigo_LI.PG_LI_ROW_ADD(PP_LISTADO)
            PM_LI_ROW_WRITE_SIN_CONCILIAR(PP_LISTADO, VP_ROW_DATA)
        Next
        PP_LISTADO.CurrentCell = Nothing
    End Sub

    Public Sub PM_BUSCAR_RESUMEN(ByRef PP_LISTADO As DataGridView, ByVal PP_SP As String)
        Me.Cursor = Cursors.WaitCursor

        Dim VP_PARAMETROS As String
        VP_PARAMETROS = FM_SQL_LISTADO_RESUMEN()

        Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
        Dim VP_STORED_PROCEDURE As String = PP_SP

        Dim VP_TABLA As Data.DataTable
        VP_TABLA = Codigo_CON.FG_SP_EXECUTE_DATATABLE(VM_ID_BASE_DE_DATOS, VP_STORED_PROCEDURE, VP_PARAMETROS)

        PG_LI_LOAD_RESUMEN(PP_LISTADO, VP_TABLA)

        Cursor = Cursors.Default
        Dim VP_REGISTROS As String
        VP_REGISTROS = VP_TABLA.Rows.Count().ToString()
        LB_RESULTADO.Text = "Resultado de la operacion: " + VP_REGISTROS + " registros." + Environment.NewLine + LB_RESULTADO.Text
    End Sub

    Public Sub PG_LI_LOAD_RESUMEN(ByRef PP_LISTADO As DataGridView, ByVal PP_DATATABLE As DataTable)
        Codigo_LI.PG_LI_CLEAR(PP_LISTADO)

        Dim VP_LISTADO_NOMBRE = PP_LISTADO.Name
        For Each VP_ROW_DATA As DataRow In PP_DATATABLE.Rows
            Codigo_LI.PG_LI_ROW_ADD(PP_LISTADO)
            PM_LI_ROW_WRITE_RESUMEN(PP_LISTADO, VP_ROW_DATA)
        Next
        PP_LISTADO.CurrentCell = Nothing
    End Sub

#End Region

#Region "SUBS_PM"

    ' ===== Listado de Movimientos ===========================================================================================
    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 20)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)], (OPCIONALLES COLOR LETRA, COLOR FONDO, BOLD [0, 1])
        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "", "", GetType(Integer), 20, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_MOVIMIENTO_BANCO", "#MB", GetType(Integer), 40, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_CUENTA_BANCO", "Cuenta Bancaria", GetType(String), 280, 1, 0, 1, 1, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_MOVIMIENTO_DDMMMYYYY", "Banco", GetType(Date), 100, 2, 0, 1, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_TIPO_MOVIMIENTO_BANCO", "Tipo", GetType(Decimal), 60, 2, 0, 1, 0, 1, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_FORMA_MOVIMIENTO_BANCO", "Forma", GetType(String), 60, 2, 0, 1, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "REFERENCIA", "Referencia", GetType(String), 120, 1, 0, 1, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "MONTO_MOVIMIENTO", "Monto", GetType(Decimal), 80, 3, 0, 1, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ESTATUS_CONCILIACION", "Conciliación", GetType(String), 80, 2, 0, 1, 0, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_UNIDAD_OPERATIVA", "Oficina", GetType(String), 100, 1, 0, 1, 0, 0, Nothing, Color.LightYellow, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_OPERACION_DDMMMYYYY", "Operación", GetType(Date), 100, 2, 0, 1, 0, 0, Nothing, Color.LightYellow, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_TIPO_LIBRO_INGRESOS", "Ingreso", GetType(String), 80, 2, 0, 1, 0, 0, Nothing, Color.LightYellow, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_CONCILIACION", "Fecha", GetType(Date), 80, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_USUARIO_CONCILIO", "Usr/Ingresos", GetType(String), 90, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_LIQ_DDMMMYYYY", "Fecha Liq", GetType(Date), 80, 2, 0, 0, 0, 0) ' No mostrar
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "SALDO", "Saldo", GetType(Decimal), 80, 3, 0, 0, 0, 2) ' No mostrar
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "CIE_CLIENTE", "CIE Cliente", GetType(String), 100, 2, 0, 0, 0, 0) ' No mostrar
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "COD_DESCRIPCION", "Descripción", GetType(String), 150, 2, 0, 0, 0, 0) ' No mostrar
        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)
    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_MOVIMIENTO_BANCO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_CUENTA_BANCO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_MOVIMIENTO_DDMMMYYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_TIPO_MOVIMIENTO_BANCO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_FORMA_MOVIMIENTO_BANCO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "REFERENCIA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MONTO_MOVIMIENTO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ESTATUS_CONCILIACION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_OPERACION_DDMMMYYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_TIPO_LIBRO_INGRESOS")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_CONCILIACION", "-")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_USUARIO_CONCILIO", "--")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_LIQ_DDMMMYYYY") ' No mostrar
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "SALDO") ' No mostrar
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CIE_CLIENTE") ' No mostrar
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "COD_DESCRIPCION") ' No mostrar
        Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)
    End Sub
    ' ===========================================================================================================================

    ' ===== Listado de Resumen de Conciliación ====================================================================================
    Private Sub PM_LI_FORMAT_RESUMEN(ByRef PP_LI_LISTADO_RESUMEN As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO_RESUMEN, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)]
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_RESUMEN, "F_YYYY", "Año", GetType(Integer), 40, 2, 0, 1, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_RESUMEN, "F_MM", "Mes", GetType(Integer), 40, 2, 0, 1, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_RESUMEN, "D_UNIDAD_OPERATIVA", "Oficina", GetType(String), 100, 1, 0, 1, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_RESUMEN, "S_TIPO_LIBRO_INGRESOS", "Ingreso", GetType(String), 80, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_RESUMEN, "TOTAL", "Total", GetType(Decimal), 80, 3, 0, 1, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_RESUMEN, "CONCILIADO", "Conciliado", GetType(Decimal), 80, 3, 0, 1, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_RESUMEN, "POR_CONCILIAR", "Por Conciliar", GetType(Decimal), 80, 3, 0, 1, 0, 2, Nothing, Color.LightYellow, 0)
    End Sub

    Public Sub PM_LI_ROW_WRITE_RESUMEN(ByRef PP_LISTADO_RESUMEN As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO_RESUMEN)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_RESUMEN, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_YYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_RESUMEN, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_MM")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_RESUMEN, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_RESUMEN, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_TIPO_LIBRO_INGRESOS")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_RESUMEN, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "TOTAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_RESUMEN, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CONCILIADO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_RESUMEN, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "POR_CONCILIAR")
    End Sub
    ' =================================================================================================================================

    ' ===== Listado de Movimientos sin Conciliar ======================================================================================
    Private Sub PM_LI_FORMAT_SIN_CONCILIAR(ByRef PP_LI_LISTADO_SIN_CONCILIAR As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO_SIN_CONCILIAR, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)]
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_SIN_CONCILIAR, "F_YYYY", "Año", GetType(Integer), 40, 2, 0, 1, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_SIN_CONCILIAR, "F_MM", "Mes", GetType(Integer), 40, 2, 0, 1, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_SIN_CONCILIAR, "D_CUENTA_BANCO", "Cuenta Bancaria", GetType(String), 280, 1, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_SIN_CONCILIAR, "S_ESTATUS_CONCILIACION", "Conciliación", GetType(String), 80, 2, 0, 1, 0, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_SIN_CONCILIAR, "SUM_MONTO_MOVIMIENTO", "Monto", GetType(Decimal), 90, 3, 0, 1, 0, 2, Nothing, Color.LightYellow, 0)
    End Sub

    Public Sub PM_LI_ROW_WRITE_SIN_CONCILIAR(ByRef PP_LISTADO_SIN_CONCILIAR As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO_SIN_CONCILIAR)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_SIN_CONCILIAR, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_YYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_SIN_CONCILIAR, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_MM")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_SIN_CONCILIAR, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_CUENTA_BANCO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_SIN_CONCILIAR, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ESTATUS_CONCILIACION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_SIN_CONCILIAR, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "SUM_MONTO_MOVIMIENTO")
    End Sub
    ' ======================================================================================================================================

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_BUSCAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
        PM_CARGAR_LI_SIN_CONCILIAR()
    End Sub

    Public Sub PM_CARGAR_LI_SIN_CONCILIAR()
        PM_BUSCAR_SIN_CONCILIAR(LI_LISTADO_SIN_CONCILIAR, "[dbo].[PG_LI_MOVIMIENTO_BANCO_SIN_CONCILIAR]")
    End Sub

    Public Sub PM_CARGAR_LI_RESUMEN()
        PM_BUSCAR_RESUMEN(LI_LISTADO_RESUMEN, "[dbo].[PG_LI_CONCILIACION_INGRESO_RESUMEN]")
    End Sub

    Public Sub PM_BT_AGREGAR_CONCILIACION_CLICK()
        Dim MSJ As String = FM_VALIDAR_TAMANO_ARRAY()
        If MSJ = "" Then
            PM_AGREGAR_CONCILIACION()
            PM_CARGAR_LI_RESUMEN()
            PM_CARGAR_LI_SIN_CONCILIAR()
            PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
            PM_LIMPIAR_ARRAY()
        Else
            Codigo_Message.PG_MENSAJE_AVISO(MSJ)
        End If
    End Sub

    Public Sub PM_AGREGAR_CONCILIACION()
        For Each i As Integer In VM_MOV_IDS
            Dim ID As Integer = i
            Dim PP_PARAMETROS As String = FM_AGREGAR_CONCILIACION(ID)
            Codigo_CON.FG_SQL_EJECUTAR_ACCION(Me, VM_ID_BASE_DE_DATOS, "[PG_UP_CONCILIACION_INGRESO_AGREGAR]", PP_PARAMETROS)
        Next
    End Sub

    Public Sub PM_BT_QUITAR_CONCILIACION_CLICK()
        Dim MSJ As String = FM_VALIDAR_TAMANO_ARRAY()
        If MSJ = "" Then
            PM_QUITAR_CONCILIACION()
            PM_CARGAR_LI_RESUMEN()
            PM_CARGAR_LI_SIN_CONCILIAR()
            PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
            PM_LIMPIAR_ARRAY()
        Else
            Codigo_Message.PG_MENSAJE_AVISO(MSJ)
        End If
    End Sub

    Public Sub PM_QUITAR_CONCILIACION()
        For Each i As Integer In VM_MOV_IDS
            Dim ID As Integer = i
            Dim PP_PARAMETROS As String = FM_QUITAR_CONCILIACION(ID)
            Codigo_CON.FG_SQL_EJECUTAR_ACCION(Me, VM_ID_BASE_DE_DATOS, "[PG_UP_CONCILIACION_INGRESO_QUITAR]", PP_PARAMETROS)
        Next
    End Sub

    Public Sub PM_BT_FLAG_CLICK()
        Dim MSJ As String = FM_VALIDAR_TAMANO_ARRAY()
        If MSJ = "" Then
            PM_FLAG()
            PM_CARGAR_LI_RESUMEN()
            PM_CARGAR_LI_SIN_CONCILIAR()
            PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
            PM_LIMPIAR_ARRAY()
        Else
            Codigo_Message.PG_MENSAJE_AVISO(MSJ)
        End If
    End Sub

    Public Sub PM_FLAG()
        For Each i As Integer In VM_MOV_IDS
            Dim ID As Integer = i
            Dim PP_PARAMETROS As String = FM_FLAG(ID)
            Codigo_CON.FG_SQL_EJECUTAR_ACCION(Me, VM_ID_BASE_DE_DATOS, "[PG_UP_CONCILIACION_INGRESO_FLAG]", PP_PARAMETROS)
        Next
    End Sub

    Public Sub PM_LIMPIAR_ARRAY()
        VM_MOV_IDS.Clear()
    End Sub

    Public Sub PM_LI_CELL_CLICK(e As DataGridViewCellEventArgs)
        Dim VL_CHK As DataGridViewCheckBoxCell = LI_LISTADO.Rows(e.RowIndex).Cells(0)
        Dim VL_ID_MOV As Integer = FM_ID_SELECCIONADO(LI_LISTADO, Codigo_LI.FG_LI_ROW_CURRENT(LI_LISTADO))
        'Dim TXT As String = "" : MsgBox(VL_ID_MOV.ToString)
        If VL_CHK.Value = True Then
            VL_CHK.Value = False
            VM_MOV_IDS.Remove(VL_ID_MOV)
            LI_LISTADO.CurrentCell = Nothing
        Else
            VL_CHK.Value = True
            VM_MOV_IDS.Add(VL_ID_MOV)
        End If
        'For Each I As Integer In VM_MOV_IDS
        '    TXT += I.ToString + ", "
        'Next : MsgBox(TXT)
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

    Private Sub LI_LISTADO_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LI_LISTADO.CellClick
        If e.RowIndex <> -1 Then
            PM_LI_CELL_CLICK(e)
        End If
    End Sub

    Private Sub CB_UNIDAD_OPERATIVA_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_UNIDAD_OPERATIVA.Click
        PM_CARGAR_LI_RESUMEN()
    End Sub

    Private Sub DT_F_CONCILIACION_ValueChanged(sender As Object, e As EventArgs) Handles DT_F_CONCILIACION.ValueChanged
        PM_CARGAR_LI_RESUMEN()
    End Sub

    Private Sub BT_AGREGAR_CONCILIACION_Click(sender As Object, e As EventArgs) Handles BT_AGREGAR_CONCILIACION.Click
        PM_BT_AGREGAR_CONCILIACION_CLICK()
    End Sub

    Private Sub BT_QUITAR_CONCILIACION_Click(sender As Object, e As EventArgs) Handles BT_QUITAR_CONCILIACION.Click
        PM_BT_QUITAR_CONCILIACION_CLICK()
    End Sub

    Private Sub BT_FLAG_MOVIMIENTO_Click(sender As Object, e As EventArgs) Handles BT_FLAG_MOVIMIENTO.Click
        PM_BT_FLAG_CLICK()
    End Sub

    Private Sub CB_LI_ZONA_UO_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_LI_ZONA.SelectedValueChanged
        If Me.Visible Then
            Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_UNIDAD_OPERATIVA, 0, 0, CB_LI_ZONA, New ComboBox, VG_USUARIO_ACCION)
        End If
    End Sub

#End Region

End Class