Public Class FO_GESTION_TESO

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_ID_VERSION As Integer = 0

#End Region

#Region "VARIABLES LOCALES"

    Dim VL_HOY As Date = Now.ToString("dd/MM/yyyy")
    Dim VP_DESGLOSE As Integer

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO_RESUMEN_FLUJO_DIARIO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_DESGLOSE_PLANTA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_RAZON_SOCIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_CUENTA_BANCO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, DT_LI_F_OPERACION, True)
        Return VP_PARAMETROS
    End Function

    Public Function FM_SQL_LISTADO_2_3_5_6()
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_DESGLOSE_PLANTA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_RAZON_SOCIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, DT_LI_F_OPERACION, True)
        Return VP_PARAMETROS
    End Function

    Public Function FM_SQL_LISTADO_OBLIGACIONES() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_DESGLOSE_PLANTA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_RAZON_SOCIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_CUENTA_BANCO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, DT_LI_F_OPERACION, True)
        Return VP_PARAMETROS
    End Function

#End Region

#Region "SUB_PM_INIT"

    Public Sub PM_FO_SHOW(ByRef PP_NOMBRE_TABLA As String, ByVal PP_ID_BASE_DE_DATOS As String)
        VM_NOMBRE_TABLA = PP_NOMBRE_TABLA
        VM_ID_BASE_DE_DATOS = PP_ID_BASE_DE_DATOS
        Me.Show()
    End Sub

    Public Sub PM_CB_INIT()
        Codigo_CB.PG_CB_RAZON_SOCIAL_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_RAZON_SOCIAL, 0, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 1, New ComboBox, CB_LI_RAZON_SOCIAL, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_CUENTA_BANCO_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_CUENTA_BANCO, 1, CB_LI_RAZON_SOCIAL, CB_LI_UNIDAD_OPERATIVA, New ComboBox, New ComboBox, New ComboBox, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
    End Sub

    Public Sub PM_CH_INIT()
        CH_DESGLOSE_PLANTA.Checked = False
    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT_RESUMEN_FLUJO_DIARIO(LI_LISTADO_RESUMEN_FLUJO_DIARIO)
        PM_LI_FORMAT_INGRESOS(LI_LISTADO_INGRESOS)
        PM_LI_FORMAT_ABASTECIMIENTO(LI_LISTADO_ABASTECIMIENTO)
        PM_LI_FORMAT_OBLIGACIONES(LI_LISTADO_OBLIGACIONES)
        PM_LI_FORMAT_CXP(LI_LISTADO_CXP)
        PM_LI_FORMAT_TRASPASOS(LI_LISTADO_TRASPASOS)
    End Sub

    Private Sub PM_FO_INIT(ByRef PP_FORMA As Object)
        Codigo_FRM.PG_FRM_INIT(VM_ID_BASE_DE_DATOS, PP_FORMA)
    End Sub

#End Region

#Region "SUBS LISTADOS"

    ' ===== Listado de RESUMEN DE FLUJO DIARIO =========================================================================================================================
    Private Sub PM_LI_FORMAT_RESUMEN_FLUJO_DIARIO(ByRef PP_LI_LISTADO_RESUMEN_FLUJO_DIARIO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO_RESUMEN_FLUJO_DIARIO, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)], (OPCIONALLES COLOR LETRA, COLOR FONDO, BOLD [0, 1])
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_RESUMEN_FLUJO_DIARIO, "S_RAZON_SOCIAL", "Razón Social", GetType(String), 80, 1, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_RESUMEN_FLUJO_DIARIO, "D_UNIDAD_OPERATIVA", "Oficina", GetType(String), 100, 1, 0, VP_DESGLOSE, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_RESUMEN_FLUJO_DIARIO, "D_RUBRO_FLUJO", "Rubro", GetType(String), 140, 1, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_RESUMEN_FLUJO_DIARIO, "IMPORTE", "Monto", GetType(Decimal), 90, 3, 0, 1, 0, 1, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_RESUMEN_FLUJO_DIARIO, "IMPORTE_LIBRO", "Libro", GetType(Decimal), 80, 3, 0, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_RESUMEN_FLUJO_DIARIO, "IMPORTE_CONCILIADO", "Conciliado", GetType(Decimal), 80, 3, 0, 1, 0, 1, Nothing, Color.LightYellow, 0)
    End Sub

    Public Sub PM_LI_ROW_WRITE_RESUMEN_FLUJO_DIARIO(ByRef PP_LISTADO_RESUMEN_FLUJO_DIARIO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO_RESUMEN_FLUJO_DIARIO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_RESUMEN_FLUJO_DIARIO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_RAZON_SOCIAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_RESUMEN_FLUJO_DIARIO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_RESUMEN_FLUJO_DIARIO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_RUBRO_FLUJO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_RESUMEN_FLUJO_DIARIO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "IMPORTE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_RESUMEN_FLUJO_DIARIO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "IMPORTE_LIBRO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_RESUMEN_FLUJO_DIARIO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "IMPORTE_CONCILIADO")
    End Sub
    ' ==================================================================================================================================================================

    ' ===== Listado de INGRESOS ========================================================================================================================================
    Private Sub PM_LI_FORMAT_INGRESOS(ByRef PP_LI_LISTADO_INGRESOS As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO_INGRESOS, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)], (OPCIONALLES COLOR LETRA, COLOR FONDO, BOLD [0, 1])
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_INGRESOS, "FECHA_YYYY", "Año", GetType(Integer), 40, 2, 0, 1, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_INGRESOS, "S_TIEMPO_MES", "Mes", GetType(Integer), 40, 2, 0, 1, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_INGRESOS, "S_RAZON_SOCIAL", "Razón Social", GetType(String), 80, 1, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_INGRESOS, "D_UNIDAD_OPERATIVA", "Oficina", GetType(String), 100, 1, 0, VP_DESGLOSE, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_INGRESOS, "S_TIPO_LIBRO_INGRESOS", "Ingreso", GetType(String), 80, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_INGRESOS, "TOTAL", "Total", GetType(Decimal), 90, 3, 0, 1, 0, 1, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_INGRESOS, "CONCILIADO", "Conciliado", GetType(Decimal), 80, 3, 0, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_INGRESOS, "POR_CONCILIAR", "Por Conciliar", GetType(Decimal), 80, 3, 0, 1, 0, 1, Nothing, Color.LightYellow, 0)
    End Sub

    Public Sub PM_LI_ROW_WRITE_INGRESOS(ByRef PP_LISTADO_INGRESOS As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO_INGRESOS)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_INGRESOS, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "FECHA_YYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_INGRESOS, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_TIEMPO_MES")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_INGRESOS, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_RAZON_SOCIAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_INGRESOS, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_INGRESOS, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_TIPO_LIBRO_INGRESOS")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_INGRESOS, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "TOTAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_INGRESOS, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CONCILIADO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_INGRESOS, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "POR_CONCILIAR")
    End Sub
    ' ==================================================================================================================================================================

    ' ===== Listado de ABASTECIMIENTO ==================================================================================================================================
    Private Sub PM_LI_FORMAT_ABASTECIMIENTO(ByRef PP_LI_LISTADO_ABASTECIMIENTO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO_ABASTECIMIENTO, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)]
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_ABASTECIMIENTO, "FECHA_YYYY", "Año", GetType(Integer), 40, 2, 0, 1, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_ABASTECIMIENTO, "S_TIEMPO_MES", "Mes", GetType(Integer), 40, 2, 0, 1, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_ABASTECIMIENTO, "N_SEMANA", "#Sem", GetType(Integer), 40, 2, 0, 1, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_ABASTECIMIENTO, "S_RAZON_SOCIAL", "Razón Social", GetType(String), 80, 1, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_ABASTECIMIENTO, "D_UNIDAD_OPERATIVA", "Oficina", GetType(String), 100, 1, 0, VP_DESGLOSE, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_ABASTECIMIENTO, "S_CATEGORIA_PROVEEDOR", "Categ.", GetType(String), 60, 1, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_ABASTECIMIENTO, "S_PROVEEDOR", "Proveedor", GetType(String), 80, 1, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_ABASTECIMIENTO, "TOTAL", "Total", GetType(Decimal), 80, 3, 0, 1, 0, 1, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_ABASTECIMIENTO, "ABONOS", "Abono", GetType(Decimal), 80, 3, 0, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_ABASTECIMIENTO, "SALDO", "Saldo", GetType(Decimal), 80, 3, 0, 1, 0, 1, Nothing, Color.LightYellow, 0)
    End Sub

    Public Sub PM_LI_ROW_WRITE_ABASTECIMIENTO(ByRef PP_LISTADO_ABASTECIMIENTO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO_ABASTECIMIENTO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_ABASTECIMIENTO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "FECHA_YYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_ABASTECIMIENTO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_TIEMPO_MES")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_ABASTECIMIENTO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "N_SEMANA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_ABASTECIMIENTO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_RAZON_SOCIAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_ABASTECIMIENTO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_ABASTECIMIENTO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_CATEGORIA_PROVEEDOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_ABASTECIMIENTO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_PROVEEDOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_ABASTECIMIENTO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "TOTAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_ABASTECIMIENTO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "ABONOS")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_ABASTECIMIENTO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "SALDO")
    End Sub
    ' ==================================================================================================================================================================

    ' ===== Listado de OBLIGACIONES ====================================================================================================================================
    Private Sub PM_LI_FORMAT_OBLIGACIONES(ByRef PP_LI_LISTADO_OBLIGACIONES As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO_OBLIGACIONES, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)], (OPCIONALLES COLOR LETRA, COLOR FONDO, BOLD [0, 1])
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_OBLIGACIONES, "", "#", GetType(Integer), 40, 2, 0, 1, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_OBLIGACIONES, "", "", GetType(String), 100, 1, 0, 1, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_OBLIGACIONES, "", "", GetType(String), 100, 1, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_OBLIGACIONES, "", "", GetType(Decimal), 80, 3, 0, 1, 0, 1, Nothing, Color.LightYellow, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_OBLIGACIONES, "", "", GetType(Decimal), 80, 3, 0, 1, 0, 1, Nothing, Color.LightYellow, 0)
    End Sub

    Public Sub PM_LI_ROW_WRITE_OBLIGACIONES(ByRef PP_LISTADO_OBLIGACIONES As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO_OBLIGACIONES)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_OBLIGACIONES, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_OBLIGACIONES, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_OBLIGACIONES, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_OBLIGACIONES, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_OBLIGACIONES, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "")
    End Sub
    ' ==================================================================================================================================================================

    ' ===== Listado de CXP =============================================================================================================================================
    Private Sub PM_LI_FORMAT_CXP(ByRef PP_LI_LISTADO_CXP As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO_CXP, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)], (OPCIONALLES COLOR LETRA, COLOR FONDO, BOLD [0, 1])
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_CXP, "FECHA_YYYY", "Año", GetType(Integer), 40, 2, 0, 1, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_CXP, "S_TIEMPO_MES", "Mes", GetType(Integer), 40, 2, 0, 1, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_CXP, "N_SEMANA", "#Sem", GetType(Integer), 40, 2, 0, 1, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_CXP, "S_RAZON_SOCIAL", "Razón Social", GetType(String), 80, 1, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_CXP, "D_UNIDAD_OPERATIVA", "Oficina", GetType(String), 100, 1, 0, VP_DESGLOSE, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_CXP, "D_CATEGORIA_PROVEEDOR", "Categoría", GetType(String), 120, 1, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_CXP, "S_PROVEEDOR", "Proveedor", GetType(String), 80, 1, 0, 0, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_CXP, "TOTAL", "Total", GetType(Decimal), 80, 3, 0, 1, 0, 1, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_CXP, "ABONOS", "Abono", GetType(Decimal), 80, 3, 0, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_CXP, "SALDO", "Saldo", GetType(Decimal), 80, 3, 0, 1, 0, 1, Nothing, Color.LightYellow, 0)
    End Sub

    Public Sub PM_LI_ROW_WRITE_CXP(ByRef PP_LISTADO_CXP As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO_CXP)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_CXP, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "FECHA_YYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_CXP, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_TIEMPO_MES")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_CXP, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "N_SEMANA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_CXP, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_RAZON_SOCIAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_CXP, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_CXP, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_CATEGORIA_PROVEEDOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_CXP, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_PROVEEDOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_CXP, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "TOTAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_CXP, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "ABONOS")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_CXP, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "SALDO")
    End Sub
    ' ==================================================================================================================================================================

    ' ===== Listado de TRASPASOS =======================================================================================================================================
    Private Sub PM_LI_FORMAT_TRASPASOS(ByRef PP_LI_LISTADO_TRASPASOS As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO_TRASPASOS, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)], (OPCIONALLES COLOR LETRA, COLOR FONDO, BOLD [0, 1])
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_TRASPASOS, "FECHA_YYYY", "Año", GetType(Integer), 40, 2, 0, 1, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_TRASPASOS, "S_TIEMPO_MES", "Mes", GetType(Integer), 40, 2, 0, 1, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_TRASPASOS, "N_SEMANA", "#Sem", GetType(Integer), 40, 2, 0, 1, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_TRASPASOS, "S_RAZON_SOCIAL", "Razón Social", GetType(String), 80, 1, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_TRASPASOS, "D_UNIDAD_OPERATIVA", "Oficina", GetType(String), 100, 1, 0, VP_DESGLOSE, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_TRASPASOS, "MONTO_AUTORIZADO", "Autorizado", GetType(Decimal), 80, 3, 0, 1, 0, 1, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_TRASPASOS, "MONTO_APLICAR", "Aplicado", GetType(Decimal), 80, 3, 0, 1, 0, 1, Nothing, Color.LightYellow, 0)
    End Sub

    Public Sub PM_LI_ROW_WRITE_TRASPASOS(ByRef PP_LISTADO_TRASPASOS As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO_TRASPASOS)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_TRASPASOS, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "FECHA_YYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_TRASPASOS, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_TIEMPO_MES")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_TRASPASOS, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "N_SEMANA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_TRASPASOS, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_RAZON_SOCIAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_TRASPASOS, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_TRASPASOS, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MONTO_AUTORIZADO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_TRASPASOS, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MONTO_APLICAR")
    End Sub
    ' ==================================================================================================================================================================

#End Region

#Region "SUBS_PM"

    Public Sub PM_CARGAR_LISTADO(ByRef PP_LISTADO As DataGridView, ByVal PP_SP As String, ByVal NOMBRE_LISTADO As String)
        Me.Cursor = Cursors.WaitCursor
        Dim VP_PARAMETROS As String = ""

        Select Case NOMBRE_LISTADO
            Case "Resumen"
                VP_PARAMETROS = FM_SQL_LISTADO_RESUMEN_FLUJO_DIARIO()
            Case "Ingresos"
                VP_PARAMETROS = FM_SQL_LISTADO_2_3_5_6()
            Case "Abastecimiento"
                VP_PARAMETROS = FM_SQL_LISTADO_2_3_5_6()
            Case "Obligaciones"
                VP_PARAMETROS = FM_SQL_LISTADO_OBLIGACIONES()
                'VP_PARAMETROS = FM_SQL_LISTADO_2_3_5_6()
            Case "CXP"
                VP_PARAMETROS = FM_SQL_LISTADO_2_3_5_6()
            Case "Traspasos"
                VP_PARAMETROS = FM_SQL_LISTADO_2_3_5_6()
        End Select

        Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
        Dim VP_STORED_PROCEDURE As String = PP_SP

        Dim VP_TABLA As Data.DataTable
        VP_TABLA = Codigo_CON.FG_SP_EXECUTE_DATATABLE(VM_ID_BASE_DE_DATOS, VP_STORED_PROCEDURE, VP_PARAMETROS)

        PG_LI_LOAD(PP_LISTADO, VP_TABLA, NOMBRE_LISTADO)

        Me.Cursor = Cursors.Default
        Dim VP_REGISTROS As String
        VP_REGISTROS = VP_TABLA.Rows.Count().ToString()
        LB_RESULTADO.Text = "Resultado de la operación: " + VP_REGISTROS + " registros." + Environment.NewLine + LB_RESULTADO.Text
    End Sub

    Public Sub PG_LI_LOAD(ByRef PP_LISTADO As DataGridView, ByVal PP_DATATABLE As DataTable, ByVal NOMBRE_LISTADO As String)
        Codigo_LI.PG_LI_CLEAR(PP_LISTADO)

        For Each VP_ROW_DATA As DataRow In PP_DATATABLE.Rows
            Codigo_LI.PG_LI_ROW_ADD(PP_LISTADO)
            Select Case NOMBRE_LISTADO
                Case "Resumen"
                    PM_LI_ROW_WRITE_RESUMEN_FLUJO_DIARIO(PP_LISTADO, VP_ROW_DATA)
                Case "Ingresos"
                    PM_LI_ROW_WRITE_INGRESOS(PP_LISTADO, VP_ROW_DATA)
                Case "Abastecimiento"
                    PM_LI_ROW_WRITE_ABASTECIMIENTO(PP_LISTADO, VP_ROW_DATA)
                Case "Obligaciones"
                    PM_LI_ROW_WRITE_OBLIGACIONES(PP_LISTADO, VP_ROW_DATA)
                Case "CXP"
                    PM_LI_ROW_WRITE_CXP(PP_LISTADO, VP_ROW_DATA)
                Case "Traspasos"
                    PM_LI_ROW_WRITE_TRASPASOS(PP_LISTADO, VP_ROW_DATA)
            End Select
        Next

        PP_LISTADO.CurrentCell = Nothing
    End Sub

    Public Sub PM_BT_BUSCAR_CLICK()
        VP_DESGLOSE = Math.Abs(CInt(CH_DESGLOSE_PLANTA.Checked))
        ' Carga el Listado de RESUMEN DE FLUJO DIARIO [ #1 ] ==============================================================
        PM_LI_FORMAT_RESUMEN_FLUJO_DIARIO(LI_LISTADO_RESUMEN_FLUJO_DIARIO)
        PM_CARGAR_LISTADO(LI_LISTADO_RESUMEN_FLUJO_DIARIO, "[dbo].[PG_LI_GESTION_TESORERIA_1_RESUMEN]", "Resumen")
        ' Carga el Listado de INGRESOS  [ #2 ] ============================================================================
        PM_LI_FORMAT_INGRESOS(LI_LISTADO_INGRESOS)
        PM_CARGAR_LISTADO(LI_LISTADO_INGRESOS, "[dbo].[PG_LI_GESTION_TESORERIA_2_INGRESOS]", "Ingresos")
        ' Carga el Listado de ABASTECIMIENTO  [ #3 ] ======================================================================
        PM_LI_FORMAT_ABASTECIMIENTO(LI_LISTADO_ABASTECIMIENTO)
        PM_CARGAR_LISTADO(LI_LISTADO_ABASTECIMIENTO, "[dbo].[PG_LI_GESTION_TESORERIA_3_ABASTECIMIENTO]", "Abastecimiento")
        ' Carga el Listado de OBLIGACIONES  [ #4 ] ========================================================================
        'PM_LI_FORMAT_OBLIGACIONES(LI_LISTADO_OBLIGACIONES)
        'PM_CARGAR_LISTADO(LI_LISTADO_OBLIGACIONES, "[dbo].[PG_LI_GESTION_TESORERIA_4_OBLIGACIONES]", "Obligaciones")
        ' Carga el Listado de CXP  [ #5 ] =================================================================================
        PM_LI_FORMAT_CXP(LI_LISTADO_CXP)
        PM_CARGAR_LISTADO(LI_LISTADO_CXP, "[dbo].[PG_LI_GESTION_TESORERIA_5_CXP]", "CXP")
        ' Carga el Listado de TRASPASOS  [ #6 ] ===========================================================================
        PM_LI_FORMAT_TRASPASOS(LI_LISTADO_TRASPASOS)
        PM_CARGAR_LISTADO(LI_LISTADO_TRASPASOS, "[dbo].[PG_LI_GESTION_TESORERIA_6_TRASPASOS]", "Traspasos")
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
        'PM_BT_BUSCAR_CLICK(PP_FORMA, PP_LISTADO)
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
        PM_BT_BUSCAR_CLICK()
    End Sub

    Private Sub BT_CANCELAR_Click(sender As Object, e As EventArgs) Handles BT_CANCELAR.Click
        PM_BT_CANCELAR_CLICK(Me)
    End Sub

    Private Sub BT_SALIR_Click(sender As Object, e As EventArgs) Handles BT_SALIR.Click
        PM_BT_SALIR_CLICK(Me)
    End Sub

    Private Sub BT_GUARDAR_Click(sender As Object, e As EventArgs) Handles BT_GUARDAR.Click
        PM_BT_GUARDAR_CLICK(Me, LI_LISTADO_ABASTECIMIENTO)
    End Sub

    Private Sub BT_EDITAR_Click(sender As Object, e As EventArgs) Handles BT_EDITAR.Click
        PM_BT_EDITAR_CLICK(Me, LI_LISTADO_ABASTECIMIENTO)
    End Sub

    Private Sub BT_ELIMINAR_Click(sender As Object, e As EventArgs) Handles BT_ELIMINAR.Click
        PM_BT_ELIMINAR_CLICK(Me, LI_LISTADO_ABASTECIMIENTO)
    End Sub

    Private Sub TI_RELOJ_Tick(sender As Object, e As EventArgs) Handles TI_RELOJ.Tick
        PM_TI_TICK(LB_RELOJ)
    End Sub

    Private Sub BT_LISTADO_Click(sender As Object, e As EventArgs) Handles BT_LISTADO.Click
        PM_BT_LISTADO_CLICK(Me)
    End Sub

    Private Sub BT_EXPORTAR_EXCEL_Click(sender As Object, e As EventArgs) Handles BT_EXPORTAR_EXCEL.Click
        PM_BT_EXPORTAR_EXCEL_CLICK(LI_LISTADO_ABASTECIMIENTO)
    End Sub

    Private Sub CB_LI_RAZON_SOCIAL_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_LI_RAZON_SOCIAL.SelectedValueChanged
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 1, New ComboBox, CB_LI_RAZON_SOCIAL, VG_USUARIO_ACCION)
    End Sub

#End Region

End Class