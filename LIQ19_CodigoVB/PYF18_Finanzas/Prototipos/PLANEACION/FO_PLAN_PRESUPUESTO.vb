Imports PYF18_Finanzas

Public Class FO_PLAN_PRESUPUESTO

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_ID_VERSION As Integer = 0
    Public VM_CELL_COLOR As Color = Color.Yellow

#End Region

#Region "VARIABLES LOCALES"

    Dim VL_HOY As Date = Now : Dim ID_MES As Integer = 0
    Dim VL_EST, VL_PROC, VL_EJER, VL_REM, VL_P_REM As Integer

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ZONA_UO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_RAZON_SOCIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_AÑO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TEMPORADA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESTATUS_PLAN_PRESUPUESTO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_NIVEL_RUBRO_PRESUPUESTO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_EX_CEROS, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_EX_ETIQUETAS, False)

        Return VP_PARAMETROS
    End Function

    Public Function FM_LI_SQL_SAVE(ByVal PP_LI_LISTADO As DataGridView, ByVal PP_INDR As Integer) As String

        Dim VP_PARAMETROS As String = ""

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("K_PLAN_PRESUPUESTO"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("K_RUBRO_PRESUPUESTO"), False)

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("S_CALCULO_PARTIDA_PRESUPUESTO"), True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("D_PROGRAMACION_PARTIDA"), True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("MONTO_BASE"), False)

        Return VP_PARAMETROS

    End Function

    Public Function FM_LI_SQL_RECALCULO(ByVal PP_LI_LISTADO As DataGridView, ByVal PP_INDR As Integer) As String

        Dim VP_PARAMETROS As String = ""

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("K_PLAN_PRESUPUESTO"), False)
        ' Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("K_RUBRO_PRESUPUESTO"), False)

        Return VP_PARAMETROS

    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_L_CAPTURA As Integer = 1
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_MOVIMIENTO_BANCO.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_MOVIMIENTO_BANCO, False)
            PP_NUEVO = False
        End If

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_TIPO_MOVIMIENTO_BANCO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_FORMA_MOVIMIENTO_BANCO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CIE_CLIENTE, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_CUENTA_BANCO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_F_OPERACION, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_F_LIQ, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_COD_DESCRIPCION, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_REFERENCIA, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MONTO_MOVIMIENTO, False)

        Return VP_PARAMETROS
    End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "D_PLAN_PRESUPUESTO")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_PLAN_PRESUPUESTO")
        Return VP_ID
    End Function

    Public Function FM_K_SELECCIONADO() As String
        Dim VP_ID As String = ""
        Dim VP_ROW As Integer = 0
        VP_ROW = Codigo_LI.FG_LI_ROW_CURRENT(LI_LISTADO)
        VP_ID = Codigo_LI.FG_LI_CELL_READ(LI_LISTADO, VP_ROW, "K_PLAN_PRESUPUESTO")
        Return VP_ID
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean

        Codigo_FI.PG_FI_FIELDS_VALIDATE(GB_FICHA, VP_VALIDACION, PP_MENSAJE_VALIDACION)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_MONTO_MOVIMIENTO)
        Codigo_CTRL.PG_TB_DATE_VALIDATE(PP_MENSAJE_VALIDACION, TB_F_OPERACION)
        Codigo_CTRL.PG_TB_DATE_VALIDATE(PP_MENSAJE_VALIDACION, TB_F_LIQ)

        VP_VALIDACION = (PP_MENSAJE_VALIDACION = "")

        Return VP_VALIDACION
    End Function

    Public Function FM_GENERAR_PRESUPUESTO()
        Dim VP_PARAMETROS As String = ""
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_PLAN_GASTO, False)
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_MES, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_HEADER_ES_MES(ByVal COL_NAME As String)
        Dim ES_MES As Boolean = False
        Select Case COL_NAME
            Case "Enero" : ES_MES = True : ID_MES = 1
            Case "Febrero" : ES_MES = True : ID_MES = 2
            Case "Marzo" : ES_MES = True : ID_MES = 3
            Case "Abril" : ES_MES = True : ID_MES = 4
            Case "Mayo" : ES_MES = True : ID_MES = 5
            Case "Junio" : ES_MES = True : ID_MES = 6
            Case "Julio" : ES_MES = True : ID_MES = 7
            Case "Agosto" : ES_MES = True : ID_MES = 8
            Case "Septiembre" : ES_MES = True : ID_MES = 9
            Case "Octubre" : ES_MES = True : ID_MES = 10
            Case "Noviembre" : ES_MES = True : ID_MES = 11
            Case "Diciembre" : ES_MES = True : ID_MES = 12
        End Select
        Return ES_MES
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
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_AÑO, "TIEMPO_YYYY")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_TEMPORADA)
        Codigo_CB.PG_CB_ZONA_UO_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_ZONA_UO, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_RAZON_SOCIAL_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_RAZON_SOCIAL, 1, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 1, CB_LI_ZONA_UO, CB_LI_RAZON_SOCIAL, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_ESTATUS_PLAN_PRESUPUESTO)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_NIVEL_RUBRO_PRESUPUESTO)
    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
    End Sub

    Public Sub PM_CH_INIT()
        CH_VER_PREVIO.Checked = True
        'CH_EX_CEROS.Checked = True : CH_EX_ETIQUETAS.Checked = False
    End Sub

    Private Sub PM_FO_INIT(ByRef PP_FORMA As Object)
        Codigo_FRM.PG_FRM_INIT(VM_ID_BASE_DE_DATOS, PP_FORMA)
    End Sub

#End Region

#Region "SUBS_PM"

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)], (OPCIONALES COLOR LETRA, COLOR FONDO, BOLD [0, 1])
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_PLAN_PRESUPUESTO", "#PPR", GetType(Integer), 60, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_RUBRO_PRESUPUESTO", "#RUB", GetType(Integer), 60, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_PROGRAMACION_PARTIDA", "#PRG", GetType(Integer), 40, 2, 0, 0, 1, 0)

        ' Donde
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ZONA_UO", "Zona", GetType(String), 40, 2, 0, 1, 1, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_RAZON_SOCIAL", "RZS", GetType(String), 50, 2, 0, 1, 1, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_UNIDAD_OPERATIVA", "UNO", GetType(String), 60, 1, 0, 1, 1, 0, Color.DarkOrange, Nothing, 1)

        ' Cuándo
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_YYYY", "Año", GetType(Integer), 40, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_TEMPORADA", "Temporada", GetType(String), 80, 2, 0, 0, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_TEMPORADA", "Temp", GetType(String), 40, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_TEMPORADA", "Temporada", GetType(String), 80, 2, 0, 0, 1, 0)
        ' Estatus
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ESTATUS_PLAN_PRESUPUESTO", "Estatus", GetType(String), 60, 2, 0, 1, 1, 0)
        ' Qué
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_RUBRO_PRESUPUESTO", "Rubro", GetType(String), 160, 1, 0, 1, 1, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_NIVEL_RUBRO_PRESUPUESTO", "Nivel", GetType(String), 40, 2, 0, 1, 1, 0)

        ' Datos

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_CALCULO_PARTIDA_PRESUPUESTO", "Cálculo", GetType(String), 60, 2, 1, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_PROGRAMACION_PARTIDA", "Uso", GetType(String), 60, 2, 1, 1, 1, 1)

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "MONTO_BASE", "Monto Base", GetType(Decimal), 70, 3, 1, 1, 0, 2)
        Dim VP_VER_PREVIO As Integer = IIf(CH_VER_PREVIO.Checked, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M01_PREVIO", "Mes 1 Previo", GetType(Decimal), 70, 3, 0, VP_VER_PREVIO, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M02_PREVIO", "Mes 2 Previo", GetType(Decimal), 70, 3, 0, VP_VER_PREVIO, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M03_PREVIO", "Mes 3 Previo", GetType(Decimal), 70, 3, 0, VP_VER_PREVIO, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M04_PREVIO", "Mes 4 Previo", GetType(Decimal), 70, 3, 0, VP_VER_PREVIO, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M05_PREVIO", "Mes 5 Previo", GetType(Decimal), 70, 3, 0, VP_VER_PREVIO, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M06_PREVIO", "Mes 6 Previo", GetType(Decimal), 70, 3, 0, VP_VER_PREVIO, 0, 2)
        Dim VP_VER_REVISADO As Integer = IIf(CH_VER_REVISADO.Checked, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M01_REVISADO", "Mes 1 Revisado", GetType(Decimal), 70, 3, 0, VP_VER_REVISADO, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M02_REVISADO", "Mes 2 Revisado", GetType(Decimal), 70, 3, 0, VP_VER_REVISADO, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M03_REVISADO", "Mes 3 Revisado", GetType(Decimal), 70, 3, 0, VP_VER_REVISADO, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M04_REVISADO", "Mes 4 Revisado", GetType(Decimal), 70, 3, 0, VP_VER_REVISADO, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M05_REVISADO", "Mes 5 Revisado", GetType(Decimal), 70, 3, 0, VP_VER_REVISADO, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M06_REVISADO", "Mes 6 Revisado", GetType(Decimal), 70, 3, 0, VP_VER_REVISADO, 0, 2)
        Dim VP_VER_AUTORIZADO As Integer = IIf(CH_VER_AUTORIZADO.Checked, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M01_AUTORIZADO", "Mes 1 Autorizado", GetType(Decimal), 70, 3, 0, VP_VER_AUTORIZADO, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M02_AUTORIZADO", "Mes 2 Autorizado", GetType(Decimal), 70, 3, 0, VP_VER_AUTORIZADO, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M03_AUTORIZADO", "Mes 3 Autorizado", GetType(Decimal), 70, 3, 0, VP_VER_AUTORIZADO, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M04_AUTORIZADO", "Mes 4 Autorizado", GetType(Decimal), 70, 3, 0, VP_VER_AUTORIZADO, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M05_AUTORIZADO", "Mes 5 Autorizado", GetType(Decimal), 70, 3, 0, VP_VER_AUTORIZADO, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M06_AUTORIZADO", "Mes 6 Autorizado", GetType(Decimal), 70, 3, 0, VP_VER_AUTORIZADO, 0, 2)

        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "Modificado", "Modificado", GetType(Integer), 90, 3, 1, 0, 0, 0)
    End Sub

    Private Sub PM_LI_FORMAT_X_TEMPORADA(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        Dim VP_K_TEMPORADA As Integer = Codigo_CB.FG_CB_ITEM_VALUE(CB_LI_TEMPORADA)
        If VP_K_TEMPORADA = 1 Then
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M01_PREVIO", "Abril Previo")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M02_PREVIO", "Mayo Previo")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M03_PREVIO", "Junio Previo")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M04_PREVIO", "Julio Previo")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M05_PREVIO", "Agosto Previo")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M06_PREVIO", "Septiembre Previo")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M01_REVISADO", "Abril Revisado")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M02_REVISADO", "Mayo Revisado")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M03_REVISADO", "Junio Revisado")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M04_REVISADO", "Julio Revisado")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M05_REVISADO", "Agosto Revisado")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M06_REVISADO", "Septiembre Revisado")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M01_AUTORIZADO", "Abril Autorizado")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M02_AUTORIZADO", "Mayo Autorizado")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M03_AUTORIZADO", "Junio Autorizado")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M04_AUTORIZADO", "Julio Autorizado")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M05_AUTORIZADO", "Agosto Autorizado")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M06_AUTORIZADO", "Septiembre Autorizado")
        ElseIf VP_K_TEMPORADA = 2 Then
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M01_PREVIO", "Octubre Previo")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M02_PREVIO", "Noviembre Previo")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M03_PREVIO", "Diciembre Previo")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M04_PREVIO", "Enero Previo")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M05_PREVIO", "Febrero Previo")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M06_PREVIO", "Marzo Previo")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M01_REVISADO", "Octubre Revisado")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M02_REVISADO", "Noviembre Revisado")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M03_REVISADO", "Diciembre Revisado")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M04_REVISADO", "Enero Revisado")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M05_REVISADO", "Febrero Revisado")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M06_REVISADO", "Marzo Revisado")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M01_AUTORIZADO", "Octubre Autorizado")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M02_AUTORIZADO", "Noviembre Autorizado")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M03_AUTORIZADO", "Diciembre Autorizado")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M04_AUTORIZADO", "Enero Autorizado")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M05_AUTORIZADO", "Febrero Autorizado")
            Codigo_LI.PG_LI_COLUMN_HEAD_CHANGE(PP_LISTADO, "M06_AUTORIZADO", "Marzo Autorizado")
        End If
    End Sub


    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Dim VP_NIVEL As Integer
        VP_NIVEL = Codigo_LI.FG_LI_CELL_READ_RUNTIME(PP_ROW_DATA, "K_NIVEL_RUBRO_PRESUPUESTO")

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_PLAN_PRESUPUESTO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_RUBRO_PRESUPUESTO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_PROGRAMACION_PARTIDA")

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ZONA_UO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_RAZON_SOCIAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_UNIDAD_OPERATIVA")

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_YYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_TEMPORADA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_TEMPORADA")

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_TEMPORADA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ESTATUS_PLAN_PRESUPUESTO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_RUBRO_PRESUPUESTO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_NIVEL_RUBRO_PRESUPUESTO")
        If VP_NIVEL > 0 Then
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_CALCULO_PARTIDA_PRESUPUESTO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_PROGRAMACION_PARTIDA")
            If VP_NIVEL = 5 Then
                Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MONTO_BASE")
            Else
                VP_COLUMNA += 1
            End If
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M01_PREVIO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M02_PREVIO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M03_PREVIO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M04_PREVIO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M05_PREVIO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M06_PREVIO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M01_REVISADO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M02_REVISADO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M03_REVISADO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M04_REVISADO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M05_REVISADO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M06_REVISADO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M01_AUTORIZADO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M02_AUTORIZADO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M03_AUTORIZADO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M04_AUTORIZADO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M05_AUTORIZADO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M06_AUTORIZADO")
            Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)
        End If

        Codigo_LI.PG_LI_CELL_FONT_PROPERTIES_RUNTIME(PP_LISTADO.Rows(VP_ROW), "D_RUBRO_PRESUPUESTO", VP_NIVEL, "PPO")

        If VP_NIVEL > 0 Then
            Dim VP_COL As Integer = PP_LISTADO.Rows(VP_ROW).Cells("D_RUBRO_PRESUPUESTO").ColumnIndex
            If VP_NIVEL = 1 Then
                PP_LISTADO.Rows(VP_ROW).DefaultCellStyle.BackColor = Color.Black
                PP_LISTADO.Rows(VP_ROW).DefaultCellStyle.ForeColor = Color.White
            ElseIf VP_NIVEL = 4 Then
                For i As Integer = 0 To PP_LISTADO.Columns.Count - 1
                    If i >= VP_COL Then
                        PP_LISTADO.Rows(VP_ROW).Cells(i).Style.Font = New Font("Arial", 8, FontStyle.Bold)
                        PP_LISTADO.Rows(VP_ROW).Cells(i).Style.BackColor = Color.LightYellow
                    End If
                Next
            ElseIf VP_NIVEL = 2 Then
                For i As Integer = 0 To PP_LISTADO.Columns.Count - 1
                    If i >= VP_COL Then
                        PP_LISTADO.Rows(VP_ROW).Cells(i).Style.BackColor = Color.Gainsboro
                    End If
                Next
            End If
        Else
            For i As Integer = 0 To PP_LISTADO.Columns.Count - 1
                If i >= (11) Then
                    PP_LISTADO.Rows(VP_ROW).Cells(i).Style.BackColor = Color.DarkOrange
                    PP_LISTADO.Rows(VP_ROW).Cells(i).Style.ForeColor = Color.White
                End If
            Next
        End If
        If VP_NIVEL = 5 Then
            Codigo_LI.PG_LI_ROW_EDIT(PP_LISTADO, VP_ROW, False)
        Else
            Codigo_LI.PG_LI_ROW_EDIT(PP_LISTADO, VP_ROW, True)
        End If
        Codigo_LI.PG_LI_CELL_ZERO_FILL(PP_LISTADO, VP_ROW)
    End Sub

    Public Sub PM_LI_ROW_MONTOS_ESTIMADOS(ByRef PP_LISTADO As DataGridView, ByVal PP_ROW As Integer, ByRef PP_COLUMNA As Integer, ByRef PP_ROW_DATA As DataRow, ByVal PP_PREFIJO As String)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, PP_PREFIJO + "_MONTO_ESTIMADO")
    End Sub

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        PM_LI_FORMAT(LI_LISTADO)
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
        PM_LI_SAVE(PP_FORMA, PP_LISTADO)
    End Sub

    Public Sub PM_LI_SAVE(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Dim VP_PARAMETROS As String = ""
        Dim VP_FILA As DataGridViewRow
        Dim VP_INDR As Integer
        Try
            For Each VP_FILA In PP_LISTADO.Rows
                VP_INDR = VP_FILA.Index
                Dim VP_DATO As String = Codigo_LI.FG_LI_CELL_VALUE(PP_LISTADO, VP_INDR, "Modificado")
                If VP_DATO = 1 Then
                    VP_PARAMETROS = ""
                    VP_PARAMETROS = FM_LI_SQL_SAVE(PP_LISTADO, VP_INDR)
                    Dim VP_CLAVE As Integer = 0
                    Dim VP_MENSAJE As String = ""
                    Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "[PG_UP_PARTIDA_PLAN_PRESUPUESTO_PARAMETROS]", VP_PARAMETROS, VP_CLAVE, VP_MENSAJE)
                    If VP_MENSAJE <> "" Then
                        Codigo_Message.PG_MENSAJE_INFORMACION(VP_MENSAJE)
                    Else
                        PP_FORMA.LB_RESULTADO.Text = "Resultado de la operación: " + "Operación exitosa  [#" + VP_CLAVE.ToString() + "]." + Environment.NewLine + PP_FORMA.LB_RESULTADO.Text
                    End If
                End If
            Next
            Dim VP_CLAVE_RECALCULO As Integer = 0
            Dim VP_MENSAJE_RECALCULO As String = ""
            VP_PARAMETROS = ""
            VP_PARAMETROS = FM_LI_SQL_RECALCULO(PP_LISTADO, VP_INDR)
            Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "[PG_PR_PARTIDA_PLAN_PRESUPUESTO_RECALCULO]", VP_PARAMETROS, VP_CLAVE_RECALCULO, VP_MENSAJE_RECALCULO)
            If VP_MENSAJE_RECALCULO <> "" Then
                Codigo_Message.PG_MENSAJE_INFORMACION(VP_MENSAJE_RECALCULO)
            End If
            PM_BT_BUSCAR_CLICK(PP_FORMA, PP_LISTADO)
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PM_LI_SAVE")
        End Try
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

    Public Sub PM_BT_PROG_PPTO_SEMANAL_CLICK(ByRef PP_FORMA As Object)
        Dim VP_EXITO As Boolean = False
        Dim VP_MSJ As String = ""
        Dim VP_CLAVE As Integer = 0
        Dim PP_PARAMETROS As String = FM_GENERAR_PRESUPUESTO()
        Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "[PG_PR_PRESUPUESTO_GENERAR]", PP_PARAMETROS, VP_CLAVE, VP_MSJ)
        If VP_MSJ = "" Then
            VP_MSJ = "Presupuesto generado exitosamente."
        Else
            VP_MSJ = "No fue posible generar el Presupuesto. Causa: " + VP_MSJ
        End If
        Codigo_Message.PG_MENSAJE_INFORMACION(VP_MSJ)
    End Sub

    Public Sub PM_CARGAR_DATOS_PARA_PRESUPUESTO(ByRef PP_LISTADO As DataGridView)
        Dim COL_HEADER As String = PP_LISTADO.CurrentCell.OwningColumn.HeaderText
        If FM_HEADER_ES_MES(COL_HEADER) Then
            Dim ID_PGA As Integer = PP_LISTADO.CurrentRow.Cells("K_PLAN_GASTO").Value
            'TB_K_PLAN_GASTO.Text = ID_PGA
            'Codigo_CB.PG_CB_VALUE_LOAD(CB_MES, ID_MES)
        End If
    End Sub

    Private Sub PM_MANDAR_A_PLAN_GASTO(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView, PP_K_ZONA_UO As Integer, PP_K_RAZON_SOCIAL As Integer, PP_K_UNIDAD_OPERATIVA As Integer, PP_ST_MENSAJE As String)
        Dim VP_EXITO As Boolean = False
        Dim VP_MSJ As String = ""
        Dim VP_CLAVE As Integer = 0
        Dim PP_PARAMETROS As String = FM_GENERAR_PRESUPUESTO()
        Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "[PG_PR_PLAN_GASTO_MASIVO]", PP_PARAMETROS, VP_CLAVE, VP_MSJ)
        If VP_MSJ = "" Then
            VP_MSJ = "Plan de Gasto <Generado> exitosamente."
        Else
            VP_MSJ = "No fue posible generar el Plan Gasto. Causa: " + VP_MSJ
        End If
        Codigo_Message.PG_MENSAJE_INFORMACION(VP_MSJ)
    End Sub

    Private Sub PM_BT_PLAN_GASTO_AUTORIZAR_CLICK(ByRef PP_FORMA As Object)
        Dim VP_EXITO As Boolean = False
        Dim VP_MSJ As String = ""
        Dim VP_CLAVE As Integer = 0
        Dim PP_PARAMETROS As String = FM_K_SELECCIONADO()
        Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "[PG_PR_PLAN_GASTO_GENERAR_X_K_PLAN_PRESUPUESTO]", PP_PARAMETROS, VP_CLAVE, VP_MSJ)
        If VP_MSJ = "" Then
            VP_MSJ = "Plan de Presupuesto <Autorizado> y Plan de Gasto <Generado> exitosamente"
        Else
            VP_MSJ = "No fue posible <Autorizar> el Plan de Presupuesto. Causa: " + VP_MSJ
        End If
        Codigo_Message.PG_MENSAJE_INFORMACION(VP_MSJ)
    End Sub

#End Region

#Region "EVENTOS"

    Private Sub Catalogo_T1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT(Me)
    End Sub

    Private Sub BT_BUSCAR_Click(sender As Object, e As EventArgs) Handles BT_LI_BUSCAR.Click
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
        PM_LI_FORMAT_X_TEMPORADA(Me, LI_LISTADO)
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

    Private Sub BT_PROG_PPTO_SEMANAL_Click(sender As Object, e As EventArgs)
        PM_BT_PROG_PPTO_SEMANAL_CLICK(Me)
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
            PM_CARGAR_DATOS_PARA_PRESUPUESTO(LI_LISTADO)
        End If
    End Sub

    Private Sub LI_LISTADO_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles LI_LISTADO.CellBeginEdit
        If BT_GUARDAR.Visible = False Then
            BT_GUARDAR.Visible = True
            BT_GUARDAR.Enabled = True
        End If
        Codigo_LI.PG_LI_CELL_COLOR_CHANGE(LI_LISTADO, e.RowIndex, e.ColumnIndex, VM_CELL_COLOR)
        Codigo_LI.PG_LI_CELL_MOD_WRITE(LI_LISTADO, e.RowIndex, e.ColumnIndex)

    End Sub

    Private Sub cellTextBox_KeyDown(
    ByVal sender As Object,
    ByVal e As System.Windows.Forms.KeyEventArgs) Handles cellTextBox.KeyDown

    End Sub

    Private Sub cellTextBox_KeyPress(
    ByVal sender As Object,
    ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cellTextBox.KeyPress
        Dim CURRENT_COL_NAME As Type
        CURRENT_COL_NAME = Codigo_LI.FG_LI_CELL_GET_COLUMN_TYPE(LI_LISTADO)
        If CURRENT_COL_NAME Is GetType(Decimal) Then
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

        cellTextBox = TryCast(e.Control, DataGridViewTextBoxEditingControl)
        Dim style As DataGridViewCellStyle = e.CellStyle
        With style
            .Font = New Font(style.Font.FontFamily, 10, FontStyle.Bold)
            .BackColor = Color.Beige
        End With
    End Sub


    Private Sub BT_GENERAR_ZONA_UO_Click(sender As Object, e As EventArgs) Handles BT_GENERAR_ZONA_UO.Click

        Dim VP_K_ZONA_UO As Integer = Codigo_CB.FG_CB_ITEM_VALUE(CB_LI_ZONA_UO)
        If VP_K_ZONA_UO = -1 Then
            Codigo_Message.PG_MENSAJE_AVISO("No es posible completar la operación, seleccione una Zona válida")
        Else
            Dim VP_D_YYYY As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_AÑO)
            Dim VP_D_ZONA_UO As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_ZONA_UO)
            Dim VP_D_TEMPORADA As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_TEMPORADA)
            Dim VP_MENSAJE = "¿Desea <Generar> el Plan de Gasto? " + vbCrLf + vbCrLf + " -Zona:= " + VP_D_ZONA_UO + vbCrLf + " -Año:= " + VP_D_YYYY + vbCrLf + " -Temporada:= " + VP_D_TEMPORADA + vbCrLf + vbCrLf + "IMPORTANTE: La información actual será borrada."

            PM_MANDAR_A_PLAN_GASTO(Me, LI_LISTADO, Codigo_CB.FG_CB_ITEM_VALUE(CB_LI_ZONA_UO), -1, -1, VP_MENSAJE)
        End If

    End Sub

    Private Sub BT_GENERAR_RAZON_SOCIAL_Click(sender As Object, e As EventArgs) Handles BT_GENERAR_RAZON_SOCIAL.Click
        Dim VP_K_RAZON_SOCIAL As Integer = Codigo_CB.FG_CB_ITEM_VALUE(CB_LI_RAZON_SOCIAL)
        If VP_K_RAZON_SOCIAL = -1 Then
            Codigo_Message.PG_MENSAJE_AVISO("No es posible completar la operación, seleccione una Razón Social válida")
        Else
            Dim VP_D_YYYY As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_AÑO)
            Dim VP_D_RAZON_SOCIAL As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_RAZON_SOCIAL)
            Dim VP_D_TEMPORADA As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_TEMPORADA)
            Dim VP_MENSAJE = "¿Desea <Generar> el Plan de Gasto? " + vbCrLf + vbCrLf + " -Razón Social:= " + VP_D_RAZON_SOCIAL + vbCrLf + " -Año:= " + VP_D_YYYY + vbCrLf + " -Temporada:= " + VP_D_TEMPORADA + vbCrLf + vbCrLf + "IMPORTANTE: La información actual será borrada."

            PM_MANDAR_A_PLAN_GASTO(Me, LI_LISTADO, Codigo_CB.FG_CB_ITEM_VALUE(CB_LI_ZONA_UO), -1, -1, VP_MENSAJE)
        End If
    End Sub

    Private Sub BT_GENERAR_UNIDAD_OPERATIVA_Click(sender As Object, e As EventArgs) Handles BT_GENERAR_UNIDAD_OPERATIVA.Click
        Dim VP_K_UNIDAD_OPERATIVA As Integer = Codigo_CB.FG_CB_ITEM_VALUE(CB_LI_UNIDAD_OPERATIVA)
        If VP_K_UNIDAD_OPERATIVA = -1 Then
            Codigo_Message.PG_MENSAJE_AVISO("No es posible completar la operación, seleccione una Unidad Operativa válida")
        Else
            Dim VP_D_YYYY As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_AÑO)
            Dim VP_D_UNIDAD_OPERATIVA As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_UNIDAD_OPERATIVA)
            Dim VP_D_TEMPORADA As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_TEMPORADA)
            Dim VP_MENSAJE = "¿Desea <Generar> el Plan de Gasto? " + vbCrLf + vbCrLf + " -Unidad Operativa:= " + VP_D_UNIDAD_OPERATIVA + vbCrLf + " -Año:= " + VP_D_YYYY + vbCrLf + " -Temporada:= " + VP_D_TEMPORADA + vbCrLf + vbCrLf + "IMPORTANTE: La información actual será borrada."

            PM_MANDAR_A_PLAN_GASTO(Me, LI_LISTADO, Codigo_CB.FG_CB_ITEM_VALUE(CB_LI_ZONA_UO), -1, -1, VP_MENSAJE)
        End If
    End Sub

    Private Sub BT_PLAN_PRESUPUESTO_AUTORIZAR_Click(sender As Object, e As EventArgs) Handles BT_PLAN_PRESUPUESTO_AUTORIZAR.Click
        PM_BT_PLAN_GASTO_AUTORIZAR_CLICK(Me)
    End Sub

    Private WithEvents cellTextBox As DataGridViewTextBoxEditingControl

    Private Sub LI_LISTADO_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LI_LISTADO.CellDoubleClick
        'If e.RowIndex <> -1 Then
        '    Codigo_LI.PG_LI_DOUBLE_CLICK(Me, LI_LISTADO)
        'End If
    End Sub

#End Region

#Region "EVENTOS CHANGE VALUE DE LOS COMBOS DE ZONA Y RAZÓN SOCIAL"

    Private Sub CB_ZONA_UO_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_LI_ZONA_UO.SelectedValueChanged
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 1, CB_LI_ZONA_UO, CB_LI_RAZON_SOCIAL, VG_USUARIO_ACCION)
    End Sub

    Private Sub CB_RAZON_SOCIAL_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_LI_RAZON_SOCIAL.SelectedValueChanged
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 1, CB_LI_ZONA_UO, CB_LI_RAZON_SOCIAL, VG_USUARIO_ACCION)
    End Sub

#End Region

End Class