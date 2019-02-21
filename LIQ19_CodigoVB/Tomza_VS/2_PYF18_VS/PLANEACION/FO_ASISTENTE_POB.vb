Imports LIQ19_Liquidaciones

Public Class FO_ASISTENTE_POB
#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_BANDERA_CARGAR_GRAFICA_3 As Integer = 0
    Public VM_DATAGRID As New DataGridView
    Public VM_CELL_COLOR As Color = Color.Yellow
    Dim VM_PLAN_POV_IDS As ArrayList = New ArrayList()

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ZONA_UO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_RAZON_SOCIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIEMPO_YYYY, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TEMPORADA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESTATUS_ACTIVO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_DIVISOR, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        Dim VP_PADRE As Object = Me.Parent

        If TB_K_PLAN_POV.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_PLAN_POV, False)
            PP_NUEVO = False
        End If
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_D_PLAN_POV, True)

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_PADRE.PP_UNIDAD_OPERATIVA1, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_PADRE.PP_YYYY1, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_TEMPORADA, False)
        Dim VP_HISTORICO_VALOR As String = ""
        VP_HISTORICO_VALOR = CB_HISTORICO_CONSIDERABLE.Text
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_HISTORICO_VALOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_INCREMENTO_COMPROMISO_KG, False)

        Return VP_PARAMETROS

    End Function

    Public Function FM_LI_SQL_SAVE(ByVal PP_LI_LISTADO As DataGridView, ByVal PP_INDR As Integer) As String
        Dim VP_PARAMETROS As String = ""

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("K_PLAN_POV"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("CRECIMIENTO_MERCADO_0_100"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("INCREMENTO_PARTICIPACION_0_100"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("COMPROMISO_KG_X_MES"), False)

        Return VP_PARAMETROS

    End Function

    'Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
    '    Dim VP_PARAMETROS = ""
    '    PP_NUEVO = True
    '    Dim VP_PADRE As Object = Me.Parent

    '    If TB_K_PLAN_POV.Text <> "" Then
    '        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_PLAN_POV, False)
    '        PP_NUEVO = False
    '    End If
    '    Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_D_PLAN_POV, True)

    '    Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_PADRE.PP_UNIDAD_OPERATIVA1, False)
    '    Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_PADRE.PP_YYYY1, False)
    '    Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_TEMPORADA, False)
    '    Dim VP_HISTORICO_VALOR As String = ""
    '    VP_HISTORICO_VALOR = CB_HISTORICO_CONSIDERABLE.Text
    '    Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_HISTORICO_VALOR, False)
    '    Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_INCREMENTO_COMPROMISO_KG, False)
    '    Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_TIPO_CALCULO, False)

    '    Return VP_PARAMETROS

    'End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "D_PLAN_POV")
        Return VP_ID
    End Function

    Public Function FM_TEMP_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_TEMPORADA")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_PLAN_POV")
        Return VP_ID
    End Function

    Public Function FM_UNIDAD_OPERATIVA_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_UNIDAD_OPERATIVA")
        Return VP_ID
    End Function

    Public Function FM_ZONA_UO_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_ZONA_UO")
        Return VP_ID
    End Function

    Public Function FM_YYYY_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_YYYY")
        Return VP_ID
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
        'LISTADO PRINCIPAL
        Codigo_CB.PG_CB_ZONA_UO_TODOS_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_ZONA_UO, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_RAZON_SOCIAL_GASERAS_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_RAZON_SOCIAL, 1, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 0, CB_LI_ZONA_UO, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_TIEMPO_YYYY, "TIEMPO_YYYY")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_TIEMPO_YYYY, "TIEMPO_YYYY")
        Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_LI_TEMPORADA, "TEMPORADA")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_ESTATUS_ACTIVO)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_DIVISOR)
        'FICHA,PENDIENTE
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_UNIDAD_OPERATIVA)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_USUARIO_ALTA, "USUARIO")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_USUARIO_CAMBIO, "USUARIO")
        Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_TEMPORADA, "TEMPORADA")

        'GRAFICA LATERAL
        Codigo_CB.PG_CB_ZONA_UO_Load(VM_ID_BASE_DE_DATOS, Me, CB_GR_ZONA_UO, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_RAZON_SOCIAL_GASERAS_Load(VM_ID_BASE_DE_DATOS, Me, CB_GR_RAZON_SOCIAL, 1, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_GR_UNIDAD_OPERATIVA, 1, 0, CB_GR_ZONA_UO, CB_GR_RAZON_SOCIAL, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_YYYY_INICIAL, "TIEMPO_YYYY")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_YYYY_FINAL, "TIEMPO_YYYY")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_GR_LI_TEMPORADA, "TEMPORADA")

        'GRAFICA INFERIOR

        Codigo_CB.PG_CB_ZONA_UO_Load(VM_ID_BASE_DE_DATOS, Me, CB_PVO_ZONA_UO, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_RAZON_SOCIAL_GASERAS_Load(VM_ID_BASE_DE_DATOS, Me, CB_PVO_RAZON_SOCIAL, 1, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_PVO_UNIDAD_OPERATIVA, 1, 0, CB_PVO_ZONA_UO, CB_PVO_RAZON_SOCIAL, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_PVO_TIEMPO_YYYY, "TIEMPO_YYYY")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_PVO_TEMPORADA, "TEMPORADA")

        '--------CARGA DE VALORES DEFAULT-----------------------------------------
        Codigo_CB.PG_CB_VALUE_LOAD(CB_DIVISOR, 1000)
        Codigo_CB.PG_CB_VALUE_LOAD(CB_LI_TIEMPO_YYYY, Now.Year)
        Codigo_CB.PG_CB_VALUE_LOAD(CB_YYYY_FINAL, Now.Year)

    End Sub

    Public Sub PM_TB_INIT()
        Codigo_CTRL.PG_TB_INIT(TB_INCREMENTO_COMPROMISO_KG, 1)
    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
    End Sub

    Private Sub PM_FO_INIT(ByRef PP_FORMA As Object)
        'Me.PM_FO_SHOW("PARAMETRO_POB", "6")
        Codigo_FRM.PG_FRM_INIT(VM_ID_BASE_DE_DATOS, PP_FORMA)
        PM_ACTUALIZAR_GRAFICA_1()
        PM_ACTUALIZAR_GRAFICA_2()

    End Sub

    Private Sub PM_GR_INIT(ByRef PP_GRAFICA As DataVisualization.Charting.Chart, ByVal PP_ANGULO_X As Integer)

        PP_GRAFICA.ChartAreas(0).AxisY.MajorGrid.Enabled = True
        PP_GRAFICA.ChartAreas(0).AxisY.LineWidth = 1
        PP_GRAFICA.ChartAreas(0).AxisY.LabelStyle.Font = New Font("Arial", 7)
        PP_GRAFICA.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Arial", 7)
        PP_GRAFICA.ChartAreas(0).AxisX.LabelStyle.Angle = PP_ANGULO_X
        PP_GRAFICA.ChartAreas(0).AxisX.MajorGrid.Enabled = False
        PP_GRAFICA.ChartAreas(0).BackColor = Color.White
        Me.Refresh()
    End Sub

#End Region

#Region "SUBS_PM"

    ''' <summary>
    ''' 'FUNCION QUE CARGARA LA PARTE DE LA FICHA
    ''' </summary>
    Public Sub PM_FI_LOAD(ByVal PP_ID As String)
        Codigo_FI.FG_FI_LOAD_X_ID(VM_ID_BASE_DE_DATOS,  Me, PP_ID)
        'CB_UNIDAD_OPERATIVA.Select()
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)

        Dim VP_PADRE As Object = Me.Parent

        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_D_PLAN_POV, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_TEMPORADA, PP_ROW)
        Dim VP_HISTORICO_CONSIDERABLE As String = ""
        Codigo_CTRL.PG_CO_DATA_LOAD("HISTORICO_CONSIDERABLE", VP_HISTORICO_CONSIDERABLE, PP_ROW)
        CB_HISTORICO_CONSIDERABLE.SelectedValue = VP_HISTORICO_CONSIDERABLE
        Codigo_CTRL.PG_CO_DATA_LOAD_MONEY("", TB_INCREMENTO_COMPROMISO_KG, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_PLAN_POV, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_UNIDAD_OPERATIVA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("K_YYYY", CB_TIEMPO_YYYY, PP_ROW)
        Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)
    End Sub

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 20)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, 
        '            ANCHO_CELDA, ALINEACION, SOLO_LECTURA, Visible, FROZEN, FORMAT

        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "", "", GetType(Integer), 20, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_PLAN_POV", "#POV", GetType(Integer), 60, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_PLAN_POV", "Descripción", GetType(String), 120, 1, 0, 1, 1, 0, Nothing, Nothing, 1)
        ' Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "O_PLAN_POV", "", GetType(Integer), 89, 1, 1, 0, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_UNIDAD_OPERATIVA", "K_UNIDAD_OPERATIVA", GetType(Integer), 89, 1, 0, 0, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_ZONA_UO", "K_ZONA_UO", GetType(Integer), 89, 1, 0, 0, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ZONA_UO", "Zona", GetType(String), 60, 2, 0, 1, 1, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_UNIDAD_OPERATIVA", "Unidad Operativa", GetType(String), 120, 1, 0, 1, 1, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ESTATUS_ACTIVO", "Estatus", GetType(String), 70, 2, 0, 1, 0, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_YYYY", "Año", GetType(Integer), 60, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_TEMPORADA", "Temporada", GetType(String), 80, 2, 0, 0, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_TEMPORADA", "Temporada", GetType(String), 80, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_TEMPORADA", "Temporada", GetType(String), 80, 2, 0, 0, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "N_HISTORICOS", "Base Historia", GetType(Integer), 70, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "CRECIMIENTO_MERCADO_0_100", "Mercado %", GetType(Integer), 70, 2, 1, 1, 0, 4, Nothing, Color.LightYellow)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "INCREMENTO_PARTICIPACION_0_100", "Crecimiento %", GetType(Integer), 70, 2, 1, 1, 0, 4, Nothing, Color.LightYellow)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "COMPROMISO_KG_X_MES", "Compromiso Kg/Mes", GetType(Decimal), 90, 3, 1, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_VENTAS_KG_H0", "Temporada Anterior", GetType(Decimal), 120, 3, 0, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_VENTAS_KG_H1", "Temporada Inmediata", GetType(Decimal), 120, 3, 0, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_VENTAS_KG_PR", "Temporada Proyectada", GetType(Decimal), 120, 3, 0, 1, 0, 1)

        If CH_HISTORIA_0.Checked Then
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_VENTAS_KG_H0_01", "H0_01", GetType(Decimal), 89, 3, 1, 1, 0, 1)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_VENTAS_KG_H0_02", "H0_02", GetType(Decimal), 89, 3, 1, 1, 0, 1)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_VENTAS_KG_H0_03", "H0_03", GetType(Decimal), 89, 3, 1, 1, 0, 1)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_VENTAS_KG_H0_04", "H0_04", GetType(Decimal), 89, 3, 1, 1, 0, 1)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_VENTAS_KG_H0_05", "H0_05", GetType(Decimal), 89, 3, 1, 1, 0, 1)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_VENTAS_KG_H0_06", "H0_06", GetType(Decimal), 89, 3, 1, 1, 0, 1)
        End If
        If CH_HISTORIA_1.Checked Then
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_VENTAS_KG_H1_01", "H1_01", GetType(Decimal), 89, 3, 1, 1, 0, 1)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_VENTAS_KG_H1_02", "H1_02", GetType(Decimal), 89, 3, 1, 1, 0, 1)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_VENTAS_KG_H1_03", "H1_03", GetType(Decimal), 89, 3, 1, 1, 0, 1)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_VENTAS_KG_H1_04", "H1_04", GetType(Decimal), 89, 3, 1, 1, 0, 1)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_VENTAS_KG_H1_05", "H1_05", GetType(Decimal), 89, 3, 1, 1, 0, 1)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_VENTAS_KG_H1_06", "H1_06", GetType(Decimal), 89, 3, 1, 1, 0, 1)
        End If
        If CH_PROYECTADO.Checked Then
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_VENTAS_KG_PR_01", "PR_01", GetType(Decimal), 89, 3, 1, 1, 0, 1)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_VENTAS_KG_PR_02", "PR_02", GetType(Decimal), 89, 3, 1, 1, 0, 1)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_VENTAS_KG_PR_03", "PR_03", GetType(Decimal), 89, 3, 1, 1, 0, 1)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_VENTAS_KG_PR_04", "PR_04", GetType(Decimal), 89, 3, 1, 1, 0, 1)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_VENTAS_KG_PR_05", "PR_05", GetType(Decimal), 89, 3, 1, 1, 0, 1)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DIV_VENTAS_KG_PR_06", "PR_06", GetType(Decimal), 89, 3, 1, 1, 0, 1)
        End If

        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "Modificado", "Modificado", GetType(Integer), 90, 3, 1, 0, 0, 0)
    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_PLAN_POV")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_PLAN_POV")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_ZONA_UO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ZONA_UO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ESTATUS_ACTIVO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_YYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_TEMPORADA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_TEMPORADA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_TEMPORADA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "N_HISTORICOS")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CRECIMIENTO_MERCADO_0_100")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "INCREMENTO_PARTICIPACION_0_100")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "COMPROMISO_KG_X_MES")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_VENTAS_KG_H0")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_VENTAS_KG_H1")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_VENTAS_KG_PR")

        If CH_HISTORIA_0.Checked Then
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_VENTAS_KG_H0_01")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_VENTAS_KG_H0_02")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_VENTAS_KG_H0_03")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_VENTAS_KG_H0_04")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_VENTAS_KG_H0_05")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_VENTAS_KG_H0_06")
        End If
        If CH_HISTORIA_1.Checked Then
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_VENTAS_KG_H1_01")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_VENTAS_KG_H1_02")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_VENTAS_KG_H1_03")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_VENTAS_KG_H1_04")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_VENTAS_KG_H1_05")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_VENTAS_KG_H1_06")
        End If
        If CH_PROYECTADO.Checked Then
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_VENTAS_KG_PR_01")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_VENTAS_KG_PR_02")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_VENTAS_KG_PR_03")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_VENTAS_KG_PR_04")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_VENTAS_KG_PR_05")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DIV_VENTAS_KG_PR_06")
        End If

        Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)
        Codigo_LI.PG_LI_ROW_EDIT(PP_LISTADO, VP_ROW, False)
        If PP_ROW_DATA.Table.Columns.Contains("Modificado") Then
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "Modificado")

            Codigo_LI.PG_LI_ROW_COLOR_CHANGE(PP_LISTADO, VP_ROW, Color.Red)
        Else
            Codigo_LI.PG_LI_CELL_ZERO_FILL(PP_LISTADO, VP_ROW)
        End If
    End Sub

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        PM_LI_FORMAT(PP_LISTADO)
        Codigo_ABC.PG_BT_BUSCAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
        PP_LISTADO.SelectionMode = DataGridViewSelectionMode.CellSelect
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
        If VM_IN_MODO_OPERACION = Modo_Operacion.Listado Then
            Codigo_ABC.PG_LI_SAVE(PP_FORMA, PP_LISTADO)
            BT_GUARDAR.Enabled = False
        Else
            Codigo_ABC.PG_BT_GUARDAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
        End If

        '  Codigo_ABC.PG_BT_GUARDAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
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

    Private Sub PM_LI_DOUBLE_CLICK(PP_FORMA As Object, PP_LISTADO As DataGridView)

        If PP_LISTADO.Rows.Count > 0 Then
            VM_BANDERA_CARGAR_GRAFICA_3 = 1
            Dim VP_ROW As Integer = Codigo_LI.FG_LI_ROW_CURRENT(PP_LISTADO)
            PM_ACTUALIZAR_GRAFICA_3(PP_LISTADO, VP_ROW)
            PM_CARGAR_GRAFICAS()
            VM_BANDERA_CARGAR_GRAFICA_3 = 0
        End If

    End Sub

    Private Sub PM_ACTUALIZAR_GRAFICA_3(ByRef PP_LISTADO As DataGridView, ByVal PP_ROW As Integer)
        Dim VP_ID As String = ""
        Dim VP_PARAMETROS As String = ""

        VP_ID = FM_ID_SELECCIONADO(PP_LISTADO, PP_ROW)
        Dim VP_K_PLAN_POV As String = FM_ID_SELECCIONADO(PP_LISTADO, PP_ROW)
        TB_PVO_K_PLAN_POV.Text = VP_K_PLAN_POV
        Dim VP_ZONA_UO As String = FM_ZONA_UO_SELECCIONADO(PP_LISTADO, PP_ROW)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_ZONA_UO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, -1, False)
        Codigo_CB.PG_CB_VALUE_LOAD(CB_PVO_ZONA_UO, VP_ZONA_UO)
        Codigo_CB.PG_CB_VALUE_LOAD(CB_PVO_RAZON_SOCIAL, -1)
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_PVO_UNIDAD_OPERATIVA, 1, 0, CB_PVO_ZONA_UO, CB_PVO_RAZON_SOCIAL, VG_USUARIO_ACCION)
        Dim VP_K_UNIDAD_OPERATIVA As String = FM_UNIDAD_OPERATIVA_SELECCIONADO(PP_LISTADO, PP_ROW)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_K_UNIDAD_OPERATIVA, False)
        Dim VP_K_YYYY As String = FM_YYYY_SELECCIONADO(PP_LISTADO, PP_ROW)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_K_YYYY, False)
        Dim VP_TEMPORADA As String = FM_TEMP_SELECCIONADO(PP_LISTADO, PP_ROW)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_TEMPORADA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_K_PLAN_POV, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_DIVISOR, False)
        PM_CARGAR_GRAFICA_3(VP_PARAMETROS)
        Codigo_CB.PG_CB_VALUE_LOAD(CB_PVO_UNIDAD_OPERATIVA, VP_K_UNIDAD_OPERATIVA)
        Codigo_CB.PG_CB_VALUE_LOAD(CB_PVO_TIEMPO_YYYY, VP_K_YYYY)
        Codigo_CB.PG_CB_VALUE_LOAD(CB_PVO_TEMPORADA, VP_TEMPORADA)
    End Sub

    Private Sub PM_ACTUALIZAR_GRAFICA_3()
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_PVO_ZONA_UO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_PVO_RAZON_SOCIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_PVO_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_PVO_TIEMPO_YYYY, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_PVO_TEMPORADA, False)

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, IIf(TB_PVO_K_PLAN_POV.Text.Length = 0, 0, TB_PVO_K_PLAN_POV), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_DIVISOR, False)
        PM_CARGAR_GRAFICA_3(VP_PARAMETROS)
    End Sub

    Private Sub PM_CARGAR_GRAFICA_3(ByVal PP_PARAMETROS As String)

        Codigo_CON.PG_SQL_PARAMETROS_CONTROL(PP_PARAMETROS)
        Dim VP_DATATABLE As DataTable = Codigo_CON.FG_SP_EXECUTE_DATATABLE(VG_ID_DB, "[PG_GR_003_VENTA_PROYECCION]", PP_PARAMETROS)
        PM_GR_INIT(GR_GRAFICA_3, 0)
        Codigo_ABC.PG_BT_GRAFICAR_CLICK(GR_GRAFICA_3, VP_DATATABLE, DataVisualization.Charting.SeriesChartType.Spline, 0, 1)
    End Sub

    Private Sub PM_CARGAR_GRAFICAS()
        Dim VP_UNIDAD_OPERATIVA As String = ""
        Dim VP_ROW As Integer = Codigo_LI.FG_LI_ROW_CURRENT(LI_LISTADO)
        VP_UNIDAD_OPERATIVA = FM_UNIDAD_OPERATIVA_SELECCIONADO(LI_LISTADO, VP_ROW)
        Dim VP_YYYY As String = ""
        VP_YYYY = FM_YYYY_SELECCIONADO(LI_LISTADO, VP_ROW)
        Dim VP_YYYY_MENOS_UNO As Integer = 0
        VP_YYYY_MENOS_UNO = Convert.ToInt32(VP_YYYY) - 1
        Dim VP_ZONA_UO As String = ""
        VP_ZONA_UO = FM_ZONA_UO_SELECCIONADO(LI_LISTADO, VP_ROW)
        Codigo_CB.PG_CB_VALUE_LOAD(CB_GR_ZONA_UO, VP_ZONA_UO)
        Codigo_CB.PG_CB_VALUE_LOAD(CB_GR_UNIDAD_OPERATIVA, VP_UNIDAD_OPERATIVA)
        Codigo_CB.PG_CB_VALUE_LOAD(CB_YYYY_FINAL, VP_YYYY_MENOS_UNO)
        PM_ACTUALIZAR_GRAFICA_1()
        PM_ACTUALIZAR_GRAFICA_2()
        PM_ACTUALIZAR_GRAFICA_3()

    End Sub

    Private Sub PM_BT_EXPORTAR_EXCEL_CLICK(ByRef PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_EXPORTAR_EXCEL_CLICK(PP_LISTADO)
    End Sub

    Public Sub PM_LI_SAVE(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Dim VP_PARAMETROS As String = ""
        Dim VP_FILA As DataGridViewRow
        Dim VP_TABLA As New DataTable
        Dim VP_INDICES As New List(Of Integer)
        Dim VP_RESULTADO As DataTable

        Dim VP_INDR As Integer

        Try
            VP_RESULTADO = Codigo_Tabla.FG_TABLA_RESULTADOS()
            For Each VP_FILA In PP_LISTADO.Rows
                VP_INDR = VP_FILA.Index
                Dim VP_DATO As String = Codigo_LI.FG_LI_CELL_VALUE(PP_LISTADO, VP_INDR, "Modificado")
                If VP_DATO = 1 Then
                    Dim VP_NUEVO_ROW As DataRow = VP_RESULTADO.NewRow()
                    VP_PARAMETROS = FM_LI_SQL_SAVE(PP_LISTADO, VP_INDR)
                    Dim VP_CLAVE As Integer = 0
                    Dim VP_MENSAJE As String = ""
                    Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "[PG_UP_PLAN_POV_PARAMETROS_VARIACION]", VP_PARAMETROS, VP_CLAVE, VP_MENSAJE)
                    If VP_MENSAJE <> "" Then
                        Codigo_Message.PG_MENSAJE_INFORMACION(VP_MENSAJE)
                    Else
                        PP_FORMA.LB_RESULTADO.Text = "Resultado de la operación: " + "Operación exitosa  [#" + VP_CLAVE.ToString() + "]." + Environment.NewLine + PP_FORMA.LB_RESULTADO.Text
                    End If
                End If
            Next
            PM_BT_BUSCAR_CLICK(PP_FORMA, PP_LISTADO)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub PM_ACTUALIZAR_GRAFICA_1()
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_GR_ZONA_UO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_GR_RAZON_SOCIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_GR_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_YYYY_INICIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_YYYY_FINAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_DIVISOR, False)
        Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
        Dim VP_DATATABLE As DataTable = Codigo_CON.FG_SP_EXECUTE_DATATABLE(VG_ID_DB, "[PG_GR_001_VENTA_ANUAL]", VP_PARAMETROS)
        PM_GR_INIT(GR_GRAFICA_1, 0)
        Codigo_ABC.PG_BT_GRAFICAR_CLICK(GR_GRAFICA_1, VP_DATATABLE, DataVisualization.Charting.SeriesChartType.Spline, 0, 1, 0)
    End Sub

    Public Sub PM_ACTUALIZAR_GRAFICA_2()
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_GR_ZONA_UO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_GR_RAZON_SOCIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_GR_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_YYYY_INICIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_YYYY_FINAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_GR_LI_TEMPORADA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_DIVISOR, False)
        Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
        Dim VP_DATATABLE As DataTable = Codigo_CON.FG_SP_EXECUTE_DATATABLE(VG_ID_DB, "[PG_GR_002_VENTA_X_TEMPORADA]", VP_PARAMETROS)
        PM_GR_INIT(GR_GRAFICA_2, -90)
        Codigo_ABC.PG_BT_GRAFICAR_CLICK(GR_GRAFICA_2, VP_DATATABLE, DataVisualization.Charting.SeriesChartType.Spline, 0, 3, 0)
    End Sub

    Private Sub PM_REPROCESAR(PP_FORMA As Object, PP_LISTADO As DataGridView)
        Try
            Me.Cursor = Cursors.WaitCursor
            For Each VP_ROW As DataGridViewRow In PP_LISTADO.Rows
                Dim VP_CLAVE As Integer = 0
                Dim VP_MENSAJE As String = ""
                Dim VP_PARAMETROS As String = ""
                Dim VP_INDR = VP_ROW.Index
                Dim VP_DATO As String = Codigo_LI.FG_LI_CELL_VALUE(PP_LISTADO, VP_INDR, "K_PLAN_POV")
                Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, 1, False)
                Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, Codigo_LI.FG_LI_CELL_VALUE(PP_LISTADO, VP_INDR, "K_PLAN_POV"), False)
                Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "[PG_PR_PLAN_POV_PROYECTAR_TEMPORADA]", VP_PARAMETROS, VP_CLAVE, VP_MENSAJE)
                If VP_MENSAJE <> "" Then
                    Codigo_Message.PG_MENSAJE_AVISO(VP_MENSAJE)
                End If
            Next
            Me.Cursor = Cursors.Default
            Codigo_Message.PG_MENSAJE_INFORMACION("<Reproceso Proyección> de Objetivo de Ventas Finalizado.")
        Catch ex As Exception

        End Try
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub PM_BT_EJECUTAR_CAMBIO_CLICK(PP_FORMA As Object, PP_LISTADO As DataGridView)
        Try
            If Codigo_Message.FG_MENSAJE_CONFIRMACION("Desea Cambiar los valores de las proyecciones seleccionadas por los valores ingresados?") Then
                Me.Cursor = Cursors.WaitCursor
                For Each VP_ID As Integer In VM_PLAN_POV_IDS
                    Dim VP_PARAMETROS As String = ""
                    Dim VP_CLAVE As Integer = 0
                    Dim VP_MENSAJE As String = ""
                    Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_ID, False)
                    Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, (IIf(TB_MERCADO.Text.Length = 0, "NULL", TB_MERCADO)), False)
                    Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, (IIf(TB_CRECIMIENTO.Text.Length = 0, "NULL", TB_CRECIMIENTO)), False)
                    Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, (IIf(TB_COMPROMISO.Text.Length = 0, "NULL", TB_COMPROMISO)), False)
                    Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "[PG_UP_PLAN_POV_PARAMETROS_VARIACION]", VP_PARAMETROS, VP_CLAVE, VP_MENSAJE)
                    If VP_MENSAJE <> "" Then
                        Codigo_Message.PG_MENSAJE_AVISO(VP_MENSAJE)
                    End If
                Next
                Me.Cursor = Cursors.Default
                Codigo_Message.PG_MENSAJE_INFORMACION("<Cambio de Valores Proyección> de Objetivo de Ventas Finalizado.")
                PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
            End If

        Catch ex As Exception

        End Try

    End Sub

    Public Sub PM_LI_CELL_CLICK(e As DataGridViewCellEventArgs)
        Dim VL_CHK As DataGridViewCheckBoxCell = LI_LISTADO.Rows(e.RowIndex).Cells(0)
        Dim VL_ID_MOV As Integer = FM_ID_SELECCIONADO(LI_LISTADO, Codigo_LI.FG_LI_ROW_CURRENT(LI_LISTADO))
        'Dim TXT As String = ""
        'MsgBox(VL_ID_MOV.ToString)
        If VL_CHK.Value = True Then
            VL_CHK.Value = False
            VM_PLAN_POV_IDS.Remove(VL_ID_MOV)
            LI_LISTADO.CurrentCell = Nothing
        Else
            VL_CHK.Value = True
            VM_PLAN_POV_IDS.Add(VL_ID_MOV)
        End If
        'For Each I As Integer In VM_MOV_IDS
        '    TXT += I.ToString + ", "
        'Next
        'MsgBox(TXT)
    End Sub


    'Private Sub PM_BT_GENERAR_ZONA_UO_CLICK(PP_FORMA As Object, PP_LISTADO As DataGridView)
    '    Try
    '        Dim VP_D_YYYY As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_TIEMPO_YYYY)
    '        Dim VP_D_ZONA_UO As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_ZONA_UO)
    '        Dim VP_D_TEMPORADA As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_TEMPORADA)
    '        If Codigo_Message.FG_MENSAJE_CONFIRMACION("¿Desea <Generar Proyección> de Objetivo de Ventas? " + vbCrLf + vbCrLf + " -Zona:= " + VP_D_ZONA_UO + vbCrLf + " -Año:= " + VP_D_YYYY + vbCrLf + " -Temporada:= " + VP_D_TEMPORADA + vbCrLf + vbCrLf + "--La información actual será eliminada--") Then

    '            Dim VP_PARAMETROS As String = ""
    '            Dim VP_CLAVE As Integer = 0
    '            Dim VP_MENSAJE As String = ""
    '            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ZONA_UO, False)
    '            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, -1, False)
    '            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, -1, False)
    '            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIEMPO_YYYY, False)
    '            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TEMPORADA, False)
    '            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, (IIf(TB_MERCADO.Text.Length = 0, "NULL", TB_MERCADO)), False)
    '            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, (IIf(TB_CRECIMIENTO.Text.Length = 0, "NULL", TB_CRECIMIENTO)), False)
    '            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, (IIf(TB_COMPROMISO.Text.Length = 0, "NULL", TB_COMPROMISO)), False)
    '            Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "[PG_PR_PLAN_POV_MASIVO]", VP_PARAMETROS, VP_CLAVE, VP_MENSAJE)
    '            If VP_MENSAJE <> "" Then
    '                Codigo_Message.PG_MENSAJE_AVISO(VP_MENSAJE)
    '            End If

    '            PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
    '        End If

    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub PM_BT_GENERAR_RAZON_SOCIAL_CLICK(PP_FORMA As Object, PP_LISTADO As DataGridView)
    '    Try
    '        Dim VP_D_YYYY As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_TIEMPO_YYYY)
    '        Dim VP_D_RAZON_SOCIAL As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_RAZON_SOCIAL)
    '        Dim VP_D_TEMPORADA As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_TEMPORADA)
    '        If Codigo_Message.FG_MENSAJE_CONFIRMACION("¿Desea <Generar Proyección> de Objetivo de Ventas? " + vbCrLf + vbCrLf + " -Razón Social:= " + VP_D_RAZON_SOCIAL + vbCrLf + " -Año:= " + VP_D_YYYY + vbCrLf + " -Temporada:= " + VP_D_TEMPORADA + vbCrLf + vbCrLf + "IMPORTANTE: La información actual será borrada.") Then
    '            Dim VP_PARAMETROS As String = ""
    '            Dim VP_CLAVE As Integer = 0
    '            Dim VP_MENSAJE As String = ""
    '            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, -1, False)
    '            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_RAZON_SOCIAL, False)
    '            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, -1, False)
    '            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIEMPO_YYYY, False)
    '            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TEMPORADA, False)
    '            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, (IIf(TB_MERCADO.Text.Length = 0, "NULL", TB_MERCADO)), False)
    '            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, (IIf(TB_CRECIMIENTO.Text.Length = 0, "NULL", TB_CRECIMIENTO)), False)
    '            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, (IIf(TB_COMPROMISO.Text.Length = 0, "NULL", TB_COMPROMISO)), False)
    '            Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "[PG_PR_PLAN_POV_MASIVO]", VP_PARAMETROS, VP_CLAVE, VP_MENSAJE)
    '            If VP_MENSAJE <> "" Then
    '                Codigo_Message.PG_MENSAJE_AVISO(VP_MENSAJE)
    '            End If
    '            PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
    '        End If

    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub PM_BT_PLAN_POV_MASIVO_CLICK(PP_FORMA As Object, PP_LISTADO As DataGridView, PP_K_ZONA_UO As Integer, PP_K_RAZON_SOCIAL As Integer, PP_K_UNIDAD_OPERATIVA As Integer, PP_ST_MENSAJE As String)
        Try
            '    Dim VP_D_YYYY As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_TIEMPO_YYYY)
            '    Dim VP_D_UNIDAD_OPERATIVA_UO As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_UNIDAD_OPERATIVA)
            '    Dim VP_D_TEMPORADA As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_TEMPORADA)
            If Codigo_Message.FG_MENSAJE_CONFIRMACION(PP_ST_MENSAJE) Then

                Me.Cursor = Cursors.WaitCursor
                Dim VP_PARAMETROS As String = ""
                Dim VP_CLAVE As Integer = 0
                Dim VP_MENSAJE As String = ""
                Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_K_ZONA_UO, False)
                Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_K_RAZON_SOCIAL, False)
                Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_K_UNIDAD_OPERATIVA, False)


                Dim VP_K_TIEMPO_YYYY As Integer = Codigo_CB.FG_CB_ITEM_VALUE(CB_LI_TIEMPO_YYYY)
                Dim VP_K_TEMPORADA As Integer = Codigo_CB.FG_CB_ITEM_VALUE(CB_LI_TEMPORADA)

                If VP_K_TIEMPO_YYYY = -1 Or VP_K_TEMPORADA = -1 Then
                    Codigo_Message.PG_MENSAJE_AVISO("No es posible completar la operación, seleccione un año y temporada válidos")
                Else
                    Dim VP_TABLA As New DataTable
                    Codigo_ABC.PG_BT_EJECUTAR_ACCION_TABLA_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "[PG_LI_PLANTA_LOTE_PROCESO]", VP_PARAMETROS, VP_TABLA)
                    If VP_TABLA.Rows.Count > 0 Then
                        Dim VP_CONTADOR As Integer = 0
                        Dim VP_CONTADOR_REGISTROS As Integer = 0
                        VP_CONTADOR_REGISTROS = VP_TABLA.Rows.Count
                        Dim PP_PB_PROGRESSBAR As BARRA_DE_PROGRESO_PANEL
                        PP_PB_PROGRESSBAR = ProgressBarPanel.FG_PROGRESSBAR_INIT(PP_FORMA, 0, VP_TABLA.Rows.Count, "Carga de Registros", Color.DarkOrange)
                        While VP_CONTADOR < VP_CONTADOR_REGISTROS
                            Dim VP_K_UNIDAD_OPERATIVA As Integer = 0
                            Dim VP_D_UNIDAD_OPERATIVA As String = ""
                            Dim VP_ROW As DataRow = VP_TABLA.Rows(VP_CONTADOR)

                            VP_K_UNIDAD_OPERATIVA = VP_ROW("K_UNIDAD_OPERATIVA")
                            VP_D_UNIDAD_OPERATIVA = VP_ROW("D_UNIDAD_OPERATIVA")

                            Dim VP_PARAMETROS_LOTE As String = ""
                            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS_LOTE, -1, False)
                            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS_LOTE, -1, False)
                            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS_LOTE, VP_K_UNIDAD_OPERATIVA, False)
                            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS_LOTE, VP_K_TIEMPO_YYYY, False)
                            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS_LOTE, VP_K_TEMPORADA, False)
                            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS_LOTE, (IIf(TB_MERCADO.Text.Length = 0, "NULL", TB_MERCADO)), False)
                            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS_LOTE, (IIf(TB_CRECIMIENTO.Text.Length = 0, "NULL", TB_CRECIMIENTO)), False)
                            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS_LOTE, (IIf(TB_COMPROMISO.Text.Length = 0, "NULL", TB_COMPROMISO)), False)

                            Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "[PG_PR_PLAN_POV_MASIVO]", VP_PARAMETROS_LOTE, VP_CLAVE, VP_MENSAJE)
                            If VP_MENSAJE <> "" Then
                                Codigo_Message.PG_MENSAJE_AVISO(VP_MENSAJE)
                            End If
                            VP_CONTADOR += 1
                            ProgressBarPanel.PG_PROGRESSBAR_INCREMENT(PP_PB_PROGRESSBAR, VP_CONTADOR, VP_D_UNIDAD_OPERATIVA)
                        End While
                        ProgressBarPanel.PG_PROGRESSBAR_END(PP_PB_PROGRESSBAR)

                    End If

                    Codigo_Message.PG_MENSAJE_INFORMACION("<Generación Proyección> de Objetivo de Ventas Finalizado.")
                    PM_BT_BUSCAR_CLICK(PP_FORMA, PP_LISTADO)
                End If
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub PM_MODO_AUXILIAR()

    End Sub

#End Region

#Region "EVENTOS"

    Private Sub BT_AGREGAR_Click(sender As Object, e As EventArgs) Handles BT_AGREGAR.Click
        PM_BT_AGREGAR_CLICK(Me)
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

    Private Sub TI_RELOJ_Tick(sender As Object, e As EventArgs) Handles TI_RELOJ.Tick
        PM_TI_TICK(LB_RELOJ)
    End Sub

    Private Sub BT_LISTADO_Click(sender As Object, e As EventArgs) Handles BT_LISTADO.Click
        PM_BT_LISTADO_CLICK(Me)
    End Sub

    Private Sub UC_PARAMETRO_DOCUMENTO_D0M4_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BT_GUARDAR_Click(sender As Object, e As EventArgs) Handles BT_GUARDAR.Click
        PM_BT_GUARDAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub BT_LI_BUSCAR_Click(sender As Object, e As EventArgs) Handles BT_LI_BUSCAR.Click
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub LI_LISTADO_DoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LI_LISTADO.CellClick
        If e.RowIndex <> -1 Then
            PM_LI_DOUBLE_CLICK(Me, LI_LISTADO)
        End If
    End Sub

    Private Sub BT_EDITAR_Click(sender As Object, e As EventArgs) Handles BT_EDITAR.Click
        PM_BT_EDITAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub CB_DIVISOR_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_DIVISOR.SelectedValueChanged
        If Me.Visible Then
            PM_ACTUALIZAR_GRAFICA_1()
            PM_ACTUALIZAR_GRAFICA_2()
        End If
    End Sub

    Private Sub CB_GR_UNIDAD_OPERATIVA_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_GR_UNIDAD_OPERATIVA.SelectedValueChanged
        If Me.Visible Then
            PM_ACTUALIZAR_GRAFICA_1()
            PM_ACTUALIZAR_GRAFICA_2()
        End If
    End Sub

    Private Sub CB_GR_TEMPROADA_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_GR_LI_TEMPORADA.SelectedValueChanged
        If Me.Visible Then
            PM_ACTUALIZAR_GRAFICA_1()
            PM_ACTUALIZAR_GRAFICA_2()
        End If
    End Sub

    Private Sub CB_YYYY_INICIAL_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_YYYY_INICIAL.SelectedValueChanged
        If Me.Visible Then
            PM_ACTUALIZAR_GRAFICA_1()
            PM_ACTUALIZAR_GRAFICA_2()
        End If
    End Sub

    Private Sub CB_YYYY_FINAL_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_YYYY_FINAL.SelectedValueChanged
        If Me.Visible Then
            PM_ACTUALIZAR_GRAFICA_1()
            PM_ACTUALIZAR_GRAFICA_2()
        End If
    End Sub

    Private Sub CB_GR_ZONA_UO_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_GR_ZONA_UO.SelectedValueChanged
        If Me.Visible Then
            Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_GR_UNIDAD_OPERATIVA, 1, 0, CB_GR_ZONA_UO, CB_GR_RAZON_SOCIAL, VG_USUARIO_ACCION)
        End If
    End Sub

    Private Sub CB_GR_RAZON_SOCIAL_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_GR_RAZON_SOCIAL.SelectedValueChanged
        If Me.Visible Then
            Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_GR_UNIDAD_OPERATIVA, 1, 0, CB_GR_ZONA_UO, CB_GR_RAZON_SOCIAL, VG_USUARIO_ACCION)
        End If
    End Sub

    Private Sub CB_PVO_LI_ZONA_UO_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_PVO_ZONA_UO.SelectedValueChanged
        If Me.Visible And VM_BANDERA_CARGAR_GRAFICA_3 = 0 Then
            Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_PVO_UNIDAD_OPERATIVA, 1, 0, CB_PVO_ZONA_UO, CB_PVO_RAZON_SOCIAL, VG_USUARIO_ACCION)
            PM_ACTUALIZAR_GRAFICA_3()
        End If
    End Sub

    Private Sub CB_PVO_RAZON_SOCIAL_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_PVO_RAZON_SOCIAL.SelectedValueChanged
        If Me.Visible And VM_BANDERA_CARGAR_GRAFICA_3 = 0 Then
            Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_PVO_UNIDAD_OPERATIVA, 1, 0, CB_PVO_ZONA_UO, CB_PVO_RAZON_SOCIAL, VG_USUARIO_ACCION)
            PM_ACTUALIZAR_GRAFICA_3()
        End If
    End Sub

    Private Sub CB_LI_TIEMPO_YYYY_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_LI_TIEMPO_YYYY.SelectedValueChanged, CB_PVO_TEMPORADA.SelectedValueChanged, CB_PVO_UNIDAD_OPERATIVA.SelectedValueChanged
        If Me.Visible And VM_BANDERA_CARGAR_GRAFICA_3 = 0 Then
            PM_ACTUALIZAR_GRAFICA_3()
        End If
    End Sub

    Private Sub TB_PVO_K_PLAN_POV_KeyUp(sender As Object, e As KeyEventArgs) Handles TB_PVO_K_PLAN_POV.KeyUp
        If sender.Text.Length = 0 Then
            sender.Text = "0"
        End If
    End Sub

    Private Sub LI_LISTADO_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles LI_LISTADO.CellBeginEdit
        If BT_GUARDAR.Enabled = False Then
            BT_GUARDAR.Visible = True
            BT_GUARDAR.Enabled = True
        End If
        Codigo_LI.PG_LI_CELL_COLOR_CHANGE(LI_LISTADO, e.RowIndex, e.ColumnIndex, VM_CELL_COLOR)
        Codigo_LI.PG_LI_CELL_MOD_WRITE(LI_LISTADO, e.RowIndex, e.ColumnIndex)
    End Sub

    Private Sub BT_REPROCESAR_Click(sender As Object, e As EventArgs) Handles BT_REPROCESAR.Click
        PM_REPROCESAR(Me, LI_LISTADO)

    End Sub

    Private Sub BT_EXPORTAR_EXCEL_Click(sender As Object, e As EventArgs) Handles BT_EXPORTAR_EXCEL.Click
        PM_BT_EXPORTAR_EXCEL_CLICK(LI_LISTADO)
    End Sub
    Private Sub LI_LISTADO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LI_LISTADO.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        Else
            If Char.IsPunctuation(e.KeyChar) Then
                If sender.Text.IndexOf(".") > 0 Then
                    e.Handled = True
                Else
                    e.Handled = False
                End If
            End If
        End If
    End Sub

    Private Sub cellTextBox_KeyDown(
    ByVal sender As Object,
    ByVal e As System.Windows.Forms.KeyEventArgs) Handles cellTextBox.KeyDown

    End Sub

    Private Sub cellTextBox_KeyPress(
    ByVal sender As Object,
    ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cellTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        Else
            If Char.IsPunctuation(e.KeyChar) Then
                If sender.Text.IndexOf(".") > 0 Then
                    e.Handled = True
                Else
                    e.Handled = False
                End If
            End If
        End If
    End Sub

    Private Sub cellTextBox_KeyUp(
    ByVal sender As Object,
    ByVal e As System.Windows.Forms.KeyEventArgs) Handles cellTextBox.KeyUp

    End Sub

    Private Sub DataGridView1_EditingControlShowing(
                ByVal sender As Object,
                ByVal e As DataGridViewEditingControlShowingEventArgs) _
                Handles LI_LISTADO.EditingControlShowing

        ' Este evento se producirá cuando la celda pasa a modo de edición.

        ' Referenciamos el control DataGridViewTextBoxEditingControl actual.
        '
        cellTextBox = TryCast(e.Control, DataGridViewTextBoxEditingControl)

        ' Obtenemos el estilo de la celda actual
        '
        Dim style As DataGridViewCellStyle = e.CellStyle

        ' Mientras se edita la celda, aumentaremos la fuente
        ' y rellenaremos el color de fondo de la celda actual.
        '
        With style
            .Font = New Font(style.Font.FontFamily, 10, FontStyle.Bold)
            .BackColor = Color.Beige
        End With

    End Sub

    Private WithEvents cellTextBox As DataGridViewTextBoxEditingControl

    Private Sub LI_LISTADO_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LI_LISTADO.CellDoubleClick
        'If e.RowIndex <> -1 Then
        '    Codigo_LI.PG_LI_DOUBLE_CLICK(Me, LI_LISTADO)
        'End If
    End Sub

    Private Sub LI_LISTADO_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LI_LISTADO.CellClick
        If e.RowIndex <> -1 Then
            PM_LI_CELL_CLICK(e)
        End If
    End Sub

    Private Sub BT_EJECUTAR_CAMBIO_Click(sender As Object, e As EventArgs) Handles BT_EJECUTAR_CAMBIO.Click
        PM_BT_EJECUTAR_CAMBIO_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub CH_SELECCIONAR_TODOS_CheckedChanged(sender As Object, e As EventArgs) Handles CH_SELECCIONAR_TODOS.CheckedChanged
        PM_BT_SELECCIONAR_TODOS_CHECK(sender, LI_LISTADO)
        If CH_SELECCIONAR_TODOS.Checked Then
            For Each VP_ROW As DataGridViewRow In LI_LISTADO.Rows

            Next
        End If
    End Sub

    Private Sub PM_BT_SELECCIONAR_TODOS_CHECK(sender As CheckBox, PP_LISTADO As DataGridView)
        VM_PLAN_POV_IDS.Clear()
        If sender.Checked Then
            For Each VP_ROW As DataGridViewRow In LI_LISTADO.Rows
                Dim VL_CHK As DataGridViewCheckBoxCell = VP_ROW.Cells(0)
                Dim VL_K_PLAN_POV = FM_ID_SELECCIONADO(PP_LISTADO, VP_ROW.Index)
                VL_CHK.Value = True
                VM_PLAN_POV_IDS.Add(VL_K_PLAN_POV)
            Next
        Else
            For Each VP_ROW As DataGridViewRow In LI_LISTADO.Rows
                Dim VL_CHK As DataGridViewCheckBoxCell = VP_ROW.Cells(0)
                VL_CHK.Value = False
            Next
        End If

    End Sub

    Private Sub BT_GENERAR_ZONA_UO_Click(sender As Object, e As EventArgs) Handles BT_GENERAR_ZONA_UO.Click
        Dim VP_K_ZONA_UO As Integer = Codigo_CB.FG_CB_ITEM_VALUE(CB_LI_ZONA_UO)
        If VP_K_ZONA_UO = -1 Then
            Codigo_Message.PG_MENSAJE_AVISO("No es posible completar la operación, seleccione una Zona válida")
        Else
            Dim VP_D_YYYY As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_TIEMPO_YYYY)
            Dim VP_D_ZONA_UO As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_ZONA_UO)
            Dim VP_D_TEMPORADA As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_TEMPORADA)
            Dim VP_MENSAJE = "¿Desea <Generar Proyección> de Objetivo de Ventas? " + vbCrLf + vbCrLf + " -Zona:= " + VP_D_ZONA_UO + vbCrLf + " -Año:= " + VP_D_YYYY + vbCrLf + " -Temporada:= " + VP_D_TEMPORADA + vbCrLf + vbCrLf + "IMPORTANTE: La información actual será borrada."
            PM_BT_PLAN_POV_MASIVO_CLICK(Me, LI_LISTADO, VP_K_ZONA_UO, -1, -1, VP_MENSAJE)
        End If

    End Sub

    Private Sub BT_GENERAR_RAZON_SOCIAL_Click(sender As Object, e As EventArgs) Handles BT_GENERAR_RAZON_SOCIAL.Click
        Dim VP_K_RAZON_SOCIAL As Integer = Codigo_CB.FG_CB_ITEM_VALUE(CB_LI_RAZON_SOCIAL)

        If VP_K_RAZON_SOCIAL = -1 Then
            Codigo_Message.PG_MENSAJE_AVISO("No es posible completar la operación, seleccione una Razón Social válida")
        Else
            Dim VP_D_YYYY As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_TIEMPO_YYYY)
            Dim VP_D_RAZON_SOCIAL As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_RAZON_SOCIAL)
            Dim VP_D_TEMPORADA As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_TEMPORADA)
            Dim VP_MENSAJE = "¿Desea <Generar Proyección> de Objetivo de Ventas? " + vbCrLf + vbCrLf + " -Razón Social:= " + VP_D_RAZON_SOCIAL + vbCrLf + " -Año:= " + VP_D_YYYY + vbCrLf + " -Temporada:= " + VP_D_TEMPORADA + vbCrLf + vbCrLf + "IMPORTANTE: La información actual será borrada."
            PM_BT_PLAN_POV_MASIVO_CLICK(Me, LI_LISTADO, -1, VP_K_RAZON_SOCIAL, -1, VP_MENSAJE)
        End If
    End Sub

    Private Sub BT_GENERAR_UNIDAD_OPERATIVA_Click(sender As Object, e As EventArgs) Handles BT_GENERAR_UNIDAD_OPERATIVA.Click
        Dim VP_K_UNIDAD_OPERATIVA As Integer = Codigo_CB.FG_CB_ITEM_VALUE(CB_LI_UNIDAD_OPERATIVA)
        If VP_K_UNIDAD_OPERATIVA = -1 Then
            Codigo_Message.PG_MENSAJE_AVISO("No es posible completar la operación, seleccione una Unidad Operativa válida")
        Else
            Dim VP_D_YYYY As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_TIEMPO_YYYY)
            Dim VP_D_UNIDAD_OPERATIVA As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_UNIDAD_OPERATIVA)
            Dim VP_D_TEMPORADA As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_TEMPORADA)
            Dim VP_MENSAJE = "¿Desea <Generar Proyección> de Objetivo de Ventas? " + vbCrLf + vbCrLf + " -Unidad Operativa:= " + VP_D_UNIDAD_OPERATIVA + vbCrLf + " -Año:= " + VP_D_YYYY + vbCrLf + " -Temporada:= " + VP_D_TEMPORADA + vbCrLf + vbCrLf + "IMPORTANTE: La información actual será borrada."
            PM_BT_PLAN_POV_MASIVO_CLICK(Me, LI_LISTADO, -1, -1, VP_K_UNIDAD_OPERATIVA, VP_MENSAJE)
        End If
    End Sub

    Private Sub CB_LI_ZONA_UO_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_LI_ZONA_UO.SelectedValueChanged
        If Me.Visible Then
            Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 0, CB_LI_ZONA_UO, CB_LI_RAZON_SOCIAL, VG_USUARIO_ACCION)
        End If


    End Sub

    Private Sub CB_LI_RAZON_SOCIAL_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_LI_RAZON_SOCIAL.SelectedValueChanged
        If Me.Visible Then
            Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 0, CB_LI_ZONA_UO, CB_LI_RAZON_SOCIAL, VG_USUARIO_ACCION)
        End If
    End Sub

#End Region

End Class
