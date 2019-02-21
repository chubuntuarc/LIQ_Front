Public Class FO_PROGRAMACION_PRESUPUESTO

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_ID_VERSION As Integer = 0
    Public VM_CELL_COLOR As Color = Color.Yellow

#End Region

#Region "VARIABLES LOCALES"

    Dim VL_HOY As Date = Now
    Dim VL_EST, VL_PROC, VL_EJER, VL_REM, VL_P_REM As Integer

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIPO_UO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ZONA_UO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_RAZON_SOCIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_REGION, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_AÑO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_MES, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESTATUS_PRESUPUESTO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_NIVEL_RUBRO_PRESUPUESTO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_EX_CEROS, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_EX_ETIQUETAS, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_LI_SQL_SAVE(ByVal PP_LI_LISTADO As DataGridView, ByVal PP_INDR As Integer) As String

        Dim VP_PARAMETROS As String = ""

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("K_PRESUPUESTO"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("K_RUBRO_PRESUPUESTO"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("MES_MONTO_ESTIMADO"), False)

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
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "COD_DESCRIPCION")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_MOVIMIENTO_BANCO")
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
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_PRESUPUESTOS, False)
        ' Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
        Return VP_PARAMETROS
    End Function

    Public Function FM_GENERAR_TRASPASO()
        Dim VP_PARAMETROS As String = "" : Dim VP_PP = "[PG_SK_PRESUPUESTO]"
        Dim VP_PARAMETROS_SK As String = "0, 0, 0"
        Dim VP_K_PRESUPUESTO, VP_K_UO, VP_K_YYYY, VP_K_MM As Integer
        Dim VP_DATATABLE As New DataTable

        VP_K_PRESUPUESTO = Codigo_CTRL.FG_CO_VALUE(CB_PRESUPUESTOS)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS_SK, VP_K_PRESUPUESTO, False)
        VP_DATATABLE = Codigo_CON.FG_SP_EXECUTE_DATATABLE(VM_ID_BASE_DE_DATOS, VP_PP, VP_PARAMETROS_SK)

        VP_K_UO = Codigo_LI.FG_LI_CELL_READ(VP_DATATABLE, 0, "K_UNIDAD_OPERATIVA")
        VP_K_YYYY = Codigo_LI.FG_LI_CELL_READ(VP_DATATABLE, 0, "K_YYYY")
        VP_K_MM = Codigo_LI.FG_LI_CELL_READ(VP_DATATABLE, 0, "K_MM")

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_K_UO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_K_YYYY, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_K_MM, False)

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
        Codigo_FI.PG_FI_CONTROL_DATA_SETUP(VM_ID_BASE_DE_DATOS, Me)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_AÑO, "TIEMPO_YYYY")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_MES, "MES")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_ESTATUS_PRESUPUESTO, "ESTATUS_PRESUPUESTO")
        Codigo_CB.PG_CB_ZONA_UO_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_ZONA_UO, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_REGION)
        'Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_RAZON_SOCIAL)
        Codigo_CB.PG_CB_RAZON_SOCIAL_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_RAZON_SOCIAL, 1, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 1, CB_LI_ZONA_UO, CB_LI_RAZON_SOCIAL, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_NIVEL_RUBRO_PRESUPUESTO)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_TIPO_UO)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_PRESUPUESTOS, "PRESUPUESTO")
    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
    End Sub

    Public Sub PM_CH_INIT()
        CH_MES.Checked = True : CH_S1.Checked = False : CH_S2.Checked = False
        CH_S3.Checked = False : CH_S4.Checked = False : CH_S5.Checked = False
        CH_EST.Checked = True : CH_PROC.Checked = False : CH_EJER.Checked = True
        CH_REM.Checked = False : CH_P_REM.Checked = True : CH_EX_CEROS.Checked = True
    End Sub

    Public Sub PM_LI_VALIDAR_CHECKS(ByVal x As Boolean)
        If x = True Then
            If CH_EST.Checked Then VL_EST = 1 Else VL_EST = 0
            If CH_PROC.Checked Then VL_PROC = 1 Else VL_PROC = 0
            If CH_EJER.Checked Then VL_EJER = 1 Else VL_EJER = 0
            If CH_REM.Checked Then VL_REM = 1 Else VL_REM = 0
            If CH_P_REM.Checked Then VL_P_REM = 1 Else VL_P_REM = 0
        Else
            VL_EST = 0 : VL_PROC = 0 : VL_EJER = 0 : VL_REM = 0 : VL_P_REM = 0
        End If
    End Sub

    Public Sub PM_FI_DT_INIT()
        If TB_K_MOVIMIENTO_BANCO.Text = "" Then
            TB_F_OPERACION.Text = Codigo_ABC.FG_DT_CONVIERTE_FECHA_US_A_MX(VL_HOY)
            TB_F_LIQ.Text = Codigo_ABC.FG_DT_CONVIERTE_FECHA_US_A_MX(VL_HOY)
        Else
            TB_F_OPERACION.Text = Codigo_ABC.FG_DT_CONVIERTE_FECHA_US_A_MX(TB_F_OPERACION.Text)
            TB_F_LIQ.Text = Codigo_ABC.FG_DT_CONVIERTE_FECHA_US_A_MX(TB_F_LIQ.Text)
        End If
    End Sub

    Private Sub PM_FO_INIT(ByRef PP_FORMA As Object)
        Codigo_FRM.PG_FRM_INIT(VM_ID_BASE_DE_DATOS, PP_FORMA)
    End Sub

#End Region

#Region "SUBS_PM"

    ''' <summary>
    ''' 'FUNCIÓN QUE CARGARÁ LA PARTE DE LA FICHA
    ''' </summary>
    Public Sub PM_FI_LOAD(ByVal PP_ID As String)
        Codigo_FI.FG_FI_LOAD_X_ID(VM_ID_BASE_DE_DATOS,  Me, PP_ID)
        PM_FI_DT_INIT()
        TB_MONTO_MOVIMIENTO.Select()
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_MOVIMIENTO_BANCO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_MONTO_MOVIMIENTO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_COD_DESCRIPCION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_REFERENCIA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CIE_CLIENTE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_TIPO_MOVIMIENTO_BANCO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("FORMA_PRESUPUESTO", CB_FORMA_MOVIMIENTO_BANCO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_CUENTA_BANCO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_F_OPERACION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_F_LIQ, PP_ROW)

        Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)

    End Sub

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)], (OPCIONALES COLOR LETRA, COLOR FONDO, BOLD [0, 1])
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_PRESUPUESTO", "#PRE", GetType(Integer), 50, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_RUBRO_PRESUPUESTO", "#RUB", GetType(Integer), 40, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)

        ' Donde
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_UNIDAD_OPERATIVA", "Unidad Operativa", GetType(String), 100, 1, 0, 1, 1, 0, Nothing, Nothing, 1)

        ' Cuándo
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_YYYY", "Año", GetType(String), 40, 2, 0, 1, 1, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_MES", "Mes", GetType(String), 40, 2, 0, 1, 1, 0, Color.DarkOrange, Nothing, 1)

        ' Qué
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_NIVEL_RUBRO_PRESUPUESTO", "Nivel", GetType(String), 40, 2, 0, 0, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_RUBRO_PRESUPUESTO", "Rubro", GetType(String), 180, 1, 0, 1, 1, 1)

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_PROGRAMACION_PARTIDA", "Uso", GetType(String), 60, 2, 0, 1, 0, 1)

        ' Cuánto // MES
        PM_LI_VALIDAR_CHECKS(CH_MES.Checked)
        PM_LI_MONTOS("MES", "")

        ' Cuánto // SEMANA 1
        PM_LI_VALIDAR_CHECKS(CH_S1.Checked)
        PM_LI_MONTOS("W01", "S#1 ")

        ' Cuánto // SEMANA 2
        PM_LI_VALIDAR_CHECKS(CH_S2.Checked)
        PM_LI_MONTOS("W02", "S#2 ")

        ' Cuánto // SEMANA 3
        PM_LI_VALIDAR_CHECKS(CH_S3.Checked)
        PM_LI_MONTOS("W03", "S#3 ")

        ' Cuánto // SEMANA 4
        PM_LI_VALIDAR_CHECKS(CH_S4.Checked)
        PM_LI_MONTOS("W04", "S#4 ")

        ' Cuánto // SEMANA 5
        PM_LI_VALIDAR_CHECKS(CH_S5.Checked)
        PM_LI_MONTOS("W05", "S#5 ")

        ' Estatus
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_ESTATUS_PRESUPUESTO", "Estatus", GetType(String), 80, 2, 0, 0, 0, 0)
        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "Modificado", "Modificado", GetType(Integer), 90, 3, 1, 1, 0, 0)
    End Sub

    Public Sub PM_LI_MONTOS(ByVal PP_PREFIJO As String, ByVal PP_PREFIJO_S As String)
        Codigo_LI.PG_LI_COLUMN_ADD(LI_LISTADO, PP_PREFIJO + "_MONTO_ESTIMADO", PP_PREFIJO_S + "Estimado", GetType(Decimal), 80, 3, 0, VL_EST, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(LI_LISTADO, PP_PREFIJO + "_MONTO_EN_PROCESO", PP_PREFIJO_S + "Proceso", GetType(Decimal), 80, 3, 0, VL_PROC, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(LI_LISTADO, PP_PREFIJO + "_MONTO_EJERCIDO", PP_PREFIJO_S + "Ejercido", GetType(Decimal), 80, 3, 0, VL_EJER, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(LI_LISTADO, PP_PREFIJO + "_MONTO_REMANENTE", PP_PREFIJO_S + "Remanente", GetType(Decimal), 80, 3, 0, VL_REM, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(LI_LISTADO, PP_PREFIJO + "_REMANENTE_100", PP_PREFIJO_S + "(%)", GetType(Decimal), 40, 2, 0, VL_P_REM, 0, 4, Nothing, Color.LightYellow, 0)
    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer : Dim VP_NIVEL As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        VP_NIVEL = Codigo_LI.FG_LI_CELL_READ_RUNTIME(PP_ROW_DATA, "K_NIVEL_RUBRO_PRESUPUESTO")

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_PRESUPUESTO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_RUBRO_PRESUPUESTO")

        ' Donde
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")

        ' Cuándo
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_YYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_MES")

        ' Qué
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_NIVEL_RUBRO_PRESUPUESTO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_RUBRO_PRESUPUESTO")

        If VP_NIVEL > 0 Then
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_PROGRAMACION_PARTIDA")

            ' Cuánto // MES
            PM_LI_ROW_MONTOS(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MES")

            ' Cuánto // Semana 1
            PM_LI_ROW_MONTOS(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "W01")

            ' Cuánto // Semana 2
            PM_LI_ROW_MONTOS(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "W02")

            ' Cuánto // Semana 3
            PM_LI_ROW_MONTOS(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "W03")

            ' Cuánto // Semana 4
            PM_LI_ROW_MONTOS(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "W04")

            ' Cuánto // Semana 5
            PM_LI_ROW_MONTOS(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "W05")

            ' Estatus
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_ESTATUS_PRESUPUESTO")
            Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)

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
                If i >= (VP_COLUMNA - 1) Then
                    PP_LISTADO.Rows(VP_ROW).Cells(i).Style.BackColor = Color.DarkOrange
                    PP_LISTADO.Rows(VP_ROW).Cells(i).Style.ForeColor = Color.White
                End If
            Next
        End If
        If VP_NIVEL <> 5 Then
            Codigo_LI.PG_LI_ROW_EDIT(PP_LISTADO, VP_ROW, True)
        End If
        Codigo_LI.PG_LI_CELL_ZERO_FILL(PP_LISTADO, VP_ROW)
        Codigo_LI.PG_LI_CELL_FONT_PROPERTIES_RUNTIME(PP_LISTADO.Rows(VP_ROW), "D_RUBRO_PRESUPUESTO", VP_NIVEL, "PPO")
    End Sub

    Public Sub PM_LI_ROW_MONTOS(ByRef PP_LISTADO As DataGridView, ByVal PP_ROW As Integer, ByRef PP_COLUMNA As Integer, ByRef PP_ROW_DATA As DataRow, ByVal PP_PREFIJO As String)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, PP_PREFIJO + "_MONTO_ESTIMADO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, PP_PREFIJO + "_MONTO_EN_PROCESO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, PP_PREFIJO + "_MONTO_EJERCIDO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, PP_PREFIJO + "_MONTO_REMANENTE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_PORCENTAJE(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, PP_PREFIJO + "_REMANENTE_100")
    End Sub

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        PM_LI_FORMAT(LI_LISTADO)
        Codigo_ABC.PG_BT_BUSCAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
        BT_GUARDAR.Visible = False
        BT_GUARDAR.Enabled = False
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



    Public Sub PM_BT_ELIMINAR_CLICK(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_ELIMINAR_CLICK(VM_ID_BASE_DE_DATOS,PP_FORMA, PP_LISTADO)
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
        Dim VP_PARAMETROS As String = ""
        Dim VP_FILA As DataGridViewRow
        Dim VP_INDR As Integer
        Try
            For Each VP_FILA In PP_LISTADO.Rows
                VP_INDR = VP_FILA.Index
                Dim VP_DATO As String = Codigo_LI.FG_LI_CELL_VALUE(PP_LISTADO, VP_INDR, "Modificado")
                If VP_DATO = 1 Then
                    VP_PARAMETROS = FM_LI_SQL_SAVE(PP_LISTADO, VP_INDR)
                    Dim VP_CLAVE As Integer = 0
                    Dim VP_MENSAJE As String = ""
                    Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(PP_FORMA, VM_ID_BASE_DE_DATOS, "[PG_UP_PARTIDA_PRESUPUESTO_MES_MONTO_ESTIMADO]", VP_PARAMETROS, VP_CLAVE, VP_MENSAJE)
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
            Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(PP_FORMA, VM_ID_BASE_DE_DATOS, "[PG_PR_PRESUPUESTO_SUMARIZAR]", VP_PARAMETROS, VP_CLAVE_RECALCULO, VP_MENSAJE_RECALCULO)

            PM_BT_BUSCAR_CLICK(PP_FORMA, PP_LISTADO)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub PM_BT_GENERAR_TRASPASOS_CLICK(ByRef PP_FORMA As Object)
        Dim VP_EXITO As Boolean = False
        Dim VP_MSJ As String = ""
        Dim PP_PARAMETROS As String = FM_GENERAR_TRASPASO()
        Dim VP_CLAVE As Integer = 0
        Me.Cursor = Cursors.WaitCursor
        Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "[PG_PR_TRASPASO_X_PARAMETROS]", PP_PARAMETROS, VP_CLAVE, VP_MSJ)
        Me.Cursor = Cursors.Default
        If VP_MSJ = "" Then
            VP_MSJ = "Traspasos generados exitosamente."
        End If
        Codigo_Message.PG_MENSAJE_INFORMACION(VP_MSJ)
    End Sub


    'Public Sub PM_BT_GENERAR_TRASPASOS_CLICK(ByRef PP_FORMA As Object)
    '    Dim VP_EXITO As Boolean = False
    '    Dim VP_MSJ As String = ""
    '    Dim PP_PARAMETROS As String = FM_GENERAR_PRESUPUESTO()
    '    Dim VP_CLAVE As Integer = 0

    '    Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "[PG_PR_TRASPASO_GENERAR_X_K_PRESUPUESTO]", PP_PARAMETROS, VP_CLAVE, VP_MSJ)

    '    If VP_MSJ = "" Then
    '        VP_MSJ = "Traspasos generados exitosamente."
    '    Else
    '        VP_MSJ = "No fue posible generar los Traspasos."
    '    End If
    '    Codigo_Message.PG_MENSAJE_INFORMACION(VP_MSJ)
    'End Sub

    Public Sub PM_BT_PROG_PPTO_SEMANAL_CLICK(ByRef PP_FORMA As Object)
        Dim VP_EXITO As Boolean = False
        Dim VP_CLAVE As Integer = 0
        Dim VP_MSJ As String = ""
        Dim PP_PARAMETROS As String = FM_GENERAR_PRESUPUESTO()
        'VP_EXITO = Codigo_CON.FG_SQL_EJECUTAR_ACCION(PP_FORMA, "[PG_PR_PRESUPUESTO_PROGRAMAR_SEMANAS]", PP_PARAMETROS)

        Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "[PG_PR_PRESUPUESTO_PROGRAMAR_SEMANAS]", PP_PARAMETROS, VP_CLAVE, VP_MSJ)

        If VP_MSJ = "" Then
            VP_MSJ = "Presupuesto Semanal generado exitosamente."
        End If
        Codigo_Message.PG_MENSAJE_INFORMACION(VP_MSJ)
    End Sub

#End Region

#Region "EVENTOS"

    Private Sub BT_Click(sender As Object, e As EventArgs) Handles BT_LI_BUSCAR.Click, BT_PROG_PPTO_SEMANAL.Click, BT_GENERAR_TRASPASOS.Click, BT_SALIR.Click, BT_EXPORTAR_EXCEL.Click
        Dim VP_MODIFICADO As Boolean = False
        Dim VP_CONTADOR As Integer = 0
        Dim VP_ROWS_COUNT As Integer = 0
        VP_ROWS_COUNT = LI_LISTADO.Rows.Count
        While VP_MODIFICADO = False And VP_CONTADOR < VP_ROWS_COUNT
            Dim VP_FILA As DataGridViewRow = LI_LISTADO.Rows(VP_CONTADOR)
            Dim VP_INDR As Integer = VP_FILA.Index
            Dim VP_DATO As String = Codigo_LI.FG_LI_CELL_VALUE(LI_LISTADO, VP_INDR, "Modificado")
            If VP_DATO = 1 Then
                VP_MODIFICADO = True
            End If
            VP_CONTADOR = VP_CONTADOR + 1
        End While
        If VP_MODIFICADO Then
            If Codigo_Message.FG_MENSAJE_CONFIRMACION("Tiene modificaciones sin guardar, desea guardar antes de proceder?") Then
                PM_BT_GUARDAR_CLICK(Me, LI_LISTADO)
            End If
        End If
    End Sub

    Private Sub Catalogo_T1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT(Me)
    End Sub

    Private Sub BT_AGREGAR_Click(sender As Object, e As EventArgs)
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

    Private Sub BT_EDITAR_Click(sender As Object, e As EventArgs)
        PM_BT_EDITAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub BT_ELIMINAR_Click(sender As Object, e As EventArgs)
        PM_BT_ELIMINAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub BT_GENERAR_TRASPASOS_Click(sender As Object, e As EventArgs) Handles BT_GENERAR_TRASPASOS.Click
        PM_BT_GENERAR_TRASPASOS_CLICK(Me)
    End Sub

    Private Sub BT_PROG_PPTO_SEMANAL_Click(sender As Object, e As EventArgs) Handles BT_PROG_PPTO_SEMANAL.Click
        PM_BT_PROG_PPTO_SEMANAL_CLICK(Me)
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
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

    Private Sub LI_LISTADO_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles LI_LISTADO.CellBeginEdit
        If BT_GUARDAR.Visible = False Then
            BT_GUARDAR.Visible = True
            BT_GUARDAR.Enabled = True
        End If
        Codigo_LI.PG_LI_CELL_COLOR_CHANGE(LI_LISTADO, e.RowIndex, e.ColumnIndex, VM_CELL_COLOR)
        Codigo_LI.PG_LI_CELL_MOD_WRITE(LI_LISTADO, e.RowIndex, e.ColumnIndex)

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