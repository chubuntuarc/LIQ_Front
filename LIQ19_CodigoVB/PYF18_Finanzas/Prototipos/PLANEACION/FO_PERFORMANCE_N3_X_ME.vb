
Imports System.Windows.Forms.DataVisualization.Charting
Public Class FO_PERFORMANCE_N3_X_ME
#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VP_K_PERFORMANCE_N3_X_ME As String = ""
    Public VM_VISIBILIDAD_GRAFICA As Byte = 0
    Public VP_TIPO_GRAFICO As String
#End Region

#Region "FUNCIONES_FM"
    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ZONA_UO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_RAZON_SOCIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIEMPO_YYYY_INICIO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIEMPO_YYYY_FIN, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_METRICA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_DIVISOR, False)

        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_F_ALTA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_YYYY, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_F_CAMBIO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_M01_VALOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_M02_VALOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_M03_VALOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_M04_VALOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_M05_VALOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_M06_VALOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_M07_VALOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_M08_VALOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_M09_VALOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_M10_VALOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_M11_VALOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_M12_VALOR, False)

        Return VP_PARAMETROS

    End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "D_")
        Return VP_ID
    End Function

    Public Function FM_K_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_K_YYYY As String = ""
        VP_K_YYYY = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_YYYY")
        Dim VP_K_UNIDAD_OPERATIVA As String = ""
        VP_K_UNIDAD_OPERATIVA = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_UNIDAD_OPERATIVA")
        Dim VP_K_METRICA As String = ""
        VP_K_METRICA = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_METRICA")

        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_K_YYYY, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_K_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_K_METRICA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_DIVISOR, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_K_YYYY As String = ""
        VP_K_YYYY = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_YYYY")
        Dim VP_K_UNIDAD_OPERATIVA As String = ""
        VP_K_UNIDAD_OPERATIVA = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "XLS_UO")

        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_K_YYYY, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_K_UNIDAD_OPERATIVA, False)
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_K_METRICA, False)
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_DIVISOR, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_K_UO_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_K_UNIDAD_OPERATIVA As String = ""
        VP_K_UNIDAD_OPERATIVA = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_UNIDAD_OPERATIVA")
        Dim VP_K_METRICA As String = ""
        VP_K_METRICA = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_METRICA")

        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_K_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_K_METRICA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_DIVISOR, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean

        Codigo_FI.PG_FI_FIELDS_VALIDATE(GB_FICHA, VP_VALIDACION, PP_MENSAJE_VALIDACION)

        'Codigo_CTRL.PG_TB_INTEGER_VALIDATE(PP_MENSAJE_VALIDACION, TB_O_DOCUMENTO_D0M4)


        VP_VALIDACION = (PP_MENSAJE_VALIDACION = "")

        Return VP_VALIDACION
    End Function

#End Region

#Region "SUB_PM_INIT"

    Public Sub PM_FO_SHOW(ByRef PP_NOMBRE_TABLA As String, ByVal PP_ID_BASE_DE_DATOS As String)

        VM_NOMBRE_TABLA = PP_NOMBRE_TABLA
        VM_ID_BASE_DE_DATOS = PP_ID_BASE_DE_DATOS
        Show()
    End Sub

    Public Sub PM_CB_INIT()
        Codigo_FI.PG_FI_CONTROL_DATA_SETUP(VM_ID_BASE_DE_DATOS, Me)
        Codigo_CB.PG_CB_ZONA_UO_TODOS_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_ZONA_UO, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_RAZON_SOCIAL_GASERAS_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_RAZON_SOCIAL, 1, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_UNIDAD_OPERATIVA, 1, 0, CB_LI_ZONA_UO, CB_LI_RAZON_SOCIAL, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_DIVISOR)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_METRICA)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_TIEMPO_YYYY_INICIO, "TIEMPO_YYYY")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_TIEMPO_YYYY_FIN, "TIEMPO_YYYY")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_USUARIO_ALTA, "USUARIO")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_USUARIO_CAMBIO, "USUARIO")
        Codigo_CB.PG_CB_VALUE_LOAD(CB_LI_TIEMPO_YYYY_INICIO, Now.Year - 1)
        Codigo_CB.PG_CB_VALUE_LOAD(CB_LI_TIEMPO_YYYY_FIN, Now.Year)
    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
    End Sub

    Private Sub PM_FO_INIT(ByRef PP_FORMA As Object)
        Codigo_FRM.PG_FRM_INIT(VM_ID_BASE_DE_DATOS, PP_FORMA)
    End Sub

    Private Sub PM_GR_INIT(ByRef PP_GRAFICA As DataVisualization.Charting.Chart, ByVal PP_ANGULO_X As Integer)

        PP_GRAFICA.ChartAreas(0).AxisY.MajorGrid.Enabled = True
        'PP_GRAFICA.ChartAreas(0).AxisY.ArrowStyle = DataVisualization.Charting.AxisArrowStyle.SharpTriangle
        PP_GRAFICA.ChartAreas(0).AxisY.LineWidth = 1

        PP_GRAFICA.ChartAreas(0).AxisY.LabelStyle.Font = New Font("Arial", 7)
        PP_GRAFICA.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Arial", 7)
        PP_GRAFICA.ChartAreas(0).AxisX.LabelStyle.Angle = PP_ANGULO_X
        PP_GRAFICA.ChartAreas(0).AxisX.MajorGrid.Enabled = False

        PP_GRAFICA.ChartAreas(0).BackColor = Color.White
        Me.Refresh()
    End Sub

    Public Sub PM_TB_INIT()
        Codigo_CTRL.PG_TB_INIT(TB_M01_VALOR, 1)
        Codigo_CTRL.PG_TB_INIT(TB_M02_VALOR, 1)
        Codigo_CTRL.PG_TB_INIT(TB_M03_VALOR, 1)
        Codigo_CTRL.PG_TB_INIT(TB_M04_VALOR, 1)
        Codigo_CTRL.PG_TB_INIT(TB_M05_VALOR, 1)
        Codigo_CTRL.PG_TB_INIT(TB_M06_VALOR, 1)
        Codigo_CTRL.PG_TB_INIT(TB_M07_VALOR, 1)
        Codigo_CTRL.PG_TB_INIT(TB_M08_VALOR, 1)
        Codigo_CTRL.PG_TB_INIT(TB_M09_VALOR, 1)
        Codigo_CTRL.PG_TB_INIT(TB_M10_VALOR, 1)
        Codigo_CTRL.PG_TB_INIT(TB_M11_VALOR, 1)
        Codigo_CTRL.PG_TB_INIT(TB_M12_VALOR, 1)
        Codigo_CTRL.PG_TB_INIT(TB_VALOR_ACUMULADO, 1)
    End Sub

#End Region

#Region "SUBS_PM"

    ''' <summary>
    ''' 'FUNCION QUE CARGARA LA PARTE DE LA FICHA
    ''' </summary>
    Public Sub PM_FI_LOAD(ByVal PP_ID As String)
        Codigo_FI.FG_FI_LOAD_X_ID(VM_ID_BASE_DE_DATOS, Me, PP_ID)
        'CB_UNIDAD_OPERATIVA.Select()
    End Sub
    Public Sub PM_BT_GRAFICAR_CLICK(ByRef PP_FORMA As Object, ByRef PP_CHART As System.Windows.Forms.DataVisualization.Charting.Chart, ByRef PP_TIPO_GRAFICO As SeriesChartType, PP_PARAMETROS As String, PP_SP As String, PP_SERIE_HORIZONTAL As Integer)
        'Codigo_ABC.PG_BT_GRAFICAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_CHART, PP_TIPO_GRAFICO, PP_ID)
        Dim VP_PARAMETROS As String
        VP_PARAMETROS = PP_PARAMETROS
        Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
        Dim VP_DATATABLE As DataTable = Codigo_CON.FG_SP_EXECUTE_DATATABLE(VG_ID_DB, PP_SP, VP_PARAMETROS)
        PM_GR_INIT(PP_CHART, 0)
        If PP_SERIE_HORIZONTAL = 1 Then
            Codigo_ABC.PG_BT_GRAFICAR_CLICK(PP_CHART, VP_DATATABLE, PP_TIPO_GRAFICO, 0, 1)
        Else
            Codigo_ABC.PG_BT_GRAFICAR_CLICK(PP_CHART, VP_DATATABLE, PP_TIPO_GRAFICO, 0, 1, 2)
        End If


    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)

        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_F_ALTA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_YYYY, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_F_CAMBIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XLS_UO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XLS_UNIDAD_OPERATIVA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_VALOR_ACUMULADO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_UNIDAD_OPERATIVA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_M01_VALOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_M02_VALOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_M03_VALOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_M04_VALOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_M05_VALOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_M06_VALOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_M07_VALOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_M08_VALOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_M09_VALOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_M10_VALOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_M11_VALOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_M12_VALOR, PP_ROW)
        Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)
        'PM_BT_GRAFICAR_CLICK(Me, CHART, SeriesChartType.StepLine, FM_ID_SELECCIONADO(LI_LISTADO, 0), "[PG_GR_005a_VENTA_SERIE_ANUAL_X_MESES]")

    End Sub

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, 
        '            ANCHO_CELDA, ALINEACION, SOLO_LECTURA, Visible, FROZEN, FORMAT
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_YYYY", "AÑO", GetType(Integer), 60, 2, 1, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "XLS_UO", "#UOE", GetType(Integer), 60, 2, 1, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_UNIDAD_OPERATIVA", "Unidad Operativa", GetType(Integer), 250, 1, 1, 0, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_UNIDAD_OPERATIVA", "Unidad Operativa", GetType(String), 250, 1, 1, 1, 1, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_METRICA", "METRICA", GetType(Integer), 80, 1, 1, 0, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_METRICA", "METRICA", GetType(String), 80, 2, 1, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_VALOR_ACUMULADO", "Cifra Anual", GetType(Integer), 90, 3, 1, 1, 1, 1, Nothing, Color.LightYellow)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_M00_VALOR", "PREVIO", GetType(Decimal), 100, 3, 1, 0, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_M01_VALOR", "Enero", GetType(Decimal), 89, 3, 1, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_M02_VALOR", "Febrero", GetType(Decimal), 89, 3, 1, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_M03_VALOR", "Marzo", GetType(Decimal), 89, 3, 1, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_M04_VALOR", "Abril", GetType(Decimal), 89, 3, 1, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_M05_VALOR", "Mayo", GetType(Decimal), 89, 3, 1, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_M06_VALOR", "Junio", GetType(Decimal), 89, 3, 1, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_M07_VALOR", "Julio", GetType(Decimal), 89, 3, 1, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_M08_VALOR", "Agosto", GetType(Decimal), 89, 3, 1, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_M09_VALOR", "Septiembre", GetType(Decimal), 89, 3, 1, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_M10_VALOR", "Octubre", GetType(Decimal), 89, 3, 1, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_M11_VALOR", "Noviembre", GetType(Decimal), 89, 3, 1, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_M12_VALOR", "Diciembre", GetType(Decimal), 89, 3, 1, 1, 0, 1)
        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)


    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_YYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "XLS_UO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_METRICA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_METRICA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_VALOR_ACUMULADO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_M00_VALOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_M01_VALOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_M02_VALOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_M03_VALOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_M04_VALOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_M05_VALOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_M06_VALOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_M07_VALOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_M08_VALOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_M09_VALOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_M10_VALOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_M11_VALOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_M12_VALOR")
        Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)
        Codigo_LI.PG_LI_ROW_EDIT(PP_LISTADO, VP_ROW, False)
    End Sub

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_BUSCAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
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

    Public Sub PM_MODO_AUXILIAR()

    End Sub

#End Region

#Region "EVENTOS BOTONES"

    Private Sub BT_BUSCAR_Click(sender As Object, e As EventArgs) Handles BT_LI_BUSCAR.Click
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub Catalogo_T1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT(Me)
    End Sub

    Private Sub BT_CANCELAR_Click(sender As Object, e As EventArgs) Handles BT_CANCELAR.Click
        PM_BT_CANCELAR_CLICK(Me)
    End Sub

    Private Sub BT_SALIR_Click(sender As Object, e As EventArgs)
        PM_BT_SALIR_CLICK(Me)
    End Sub
    Private Sub BT_GUARDAR_Click(sender As Object, e As EventArgs)
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

    Private Sub BT_LISTADO_Click(sender As Object, e As EventArgs)
        PM_BT_LISTADO_CLICK(Me)
    End Sub

    Private Sub BT_EXPORTAR_EXCEL_Click(sender As Object, e As EventArgs)
        PM_BT_EXPORTAR_EXCEL_CLICK(LI_LISTADO)
    End Sub


    Private Sub BT_EXPORTAR_EXCEL_Click_1(sender As Object, e As EventArgs) Handles BT_EXPORTAR_EXCEL.Click
        PM_BT_EXPORTAR_EXCEL_CLICK(LI_LISTADO)
    End Sub

    Private Sub BT_LISTADO_Click_1(sender As Object, e As EventArgs) Handles BT_LISTADO.Click
        PM_BT_LISTADO_CLICK(Me)
    End Sub

    Private Sub BT_SALIR_Click_1(sender As Object, e As EventArgs) Handles BT_SALIR.Click
        PM_BT_SALIR_CLICK(Me)
    End Sub

    Private Sub LI_LISTADO_DoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LI_LISTADO.CellDoubleClick
        CHART.Refresh()
        Codigo_LI.PG_LI_DOUBLE_CLICK(Me, LI_LISTADO)
        Dim VM_ID_ROW As Integer = Codigo_LI.FG_LI_ROW_CURRENT(LI_LISTADO)
        VP_K_PERFORMANCE_N3_X_ME = FM_K_SELECCIONADO(LI_LISTADO, VM_ID_ROW)
        PM_BT_GRAFICAR_CLICK(Me, CHART, DataVisualization.Charting.SeriesChartType.Spline, VP_K_PERFORMANCE_N3_X_ME, "[PG_GR_005a_VENTA_SERIE_ANUAL_X_MESES]", 1)
        GB_FICHA.Enabled = True

    End Sub

    Private Sub RB_ANUAL_CheckedChanged(sender As Object, e As EventArgs) Handles RB_ANUAL.CheckedChanged
        If sender.Checked And Visible Then
            Dim VM_ID_ROW As Integer = Codigo_LI.FG_LI_ROW_CURRENT(LI_LISTADO)
            PM_BT_GRAFICAR_CLICK(Me, CHART, SeriesChartType.Spline, FM_K_UO_SELECCIONADO(LI_LISTADO, VM_ID_ROW), "[PG_GR_005b_VENTA_SERIE_ANUAL]", 0)
        End If
    End Sub

    Private Sub RB_MENSUAL_CheckedChanged(sender As Object, e As EventArgs) Handles RB_MENSUAL.CheckedChanged
        If sender.Checked And Visible Then
            Dim VM_ID_ROW As Integer = Codigo_LI.FG_LI_ROW_CURRENT(LI_LISTADO)
            PM_BT_GRAFICAR_CLICK(Me, CHART, SeriesChartType.Spline, FM_K_SELECCIONADO(LI_LISTADO, VM_ID_ROW), "[PG_GR_005a_VENTA_SERIE_ANUAL_X_MESES]", 1)
        End If
    End Sub



#End Region

#Region "EVENTOS COMBOS"
    Private Sub CB_LI_ZONA_UO_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_LI_ZONA_UO.SelectedValueChanged, CB_LI_RAZON_SOCIAL.SelectedValueChanged
        If Visible Then
            Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_UNIDAD_OPERATIVA, 1, 0, CB_LI_ZONA_UO, CB_LI_RAZON_SOCIAL, VG_USUARIO_ACCION)
        End If
    End Sub

#End Region
End Class