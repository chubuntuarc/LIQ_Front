Imports PYF18_Finanzas

Public Class FO_PLAN_GASTO

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_ID_VERSION As Integer = 0

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
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIPO_UO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_AÑO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESCENARIO_PLAN, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESTATUS_PLAN_GASTO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_NIVEL_RUBRO_PRESUPUESTO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_EX_CEROS, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_EX_ETIQUETAS, False)
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
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_PLAN_GASTO")
        Return VP_ID
    End Function

    Public Function FM_K_SELECCIONADO() As String
        Dim VP_ID As String = ""
        Dim VP_ROW As Integer = 0
        VP_ROW = Codigo_LI.FG_LI_ROW_CURRENT(LI_LISTADO)
        VP_ID = Codigo_LI.FG_LI_CELL_READ(LI_LISTADO, VP_ROW, "K_PLAN_GASTO")
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
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_PLAN_GASTO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_MES, False)
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
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_ESCENARIO_PLAN, "ESCENARIO_PLAN")
        Codigo_CB.PG_CB_ZONA_UO_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_ZONA_UO, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_RAZON_SOCIAL_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_RAZON_SOCIAL, 1, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 1, CB_LI_ZONA_UO, CB_LI_RAZON_SOCIAL, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_NIVEL_RUBRO_PRESUPUESTO)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_TIPO_UO)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_ESTATUS_PLAN_GASTO, "ESTATUS_PLAN_GASTO")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_MES, "MES")
    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
    End Sub

    Public Sub PM_CH_INIT()
        CH_TRI1.Checked = True : CH_TRI2.Checked = True
        CH_TRI3.Checked = True : CH_TRI4.Checked = True
        CH_EX_CEROS.Checked = True : CH_EX_ETIQUETAS.Checked = False
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
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_PLAN_GASTO", "#PGA", GetType(Integer), 40, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_RUBRO_PRESUPUESTO", "#RUB", GetType(Integer), 40, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_PROGRAMACION_PARTIDA", "#PRG", GetType(Integer), 40, 2, 0, 0, 1, 0)

        ' Donde
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_UNIDAD_OPERATIVA", "#PRG", GetType(Integer), 40, 2, 0, 0, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_UNIDAD_OPERATIVA", "Unidad Operativa", GetType(String), 100, 1, 0, 1, 1, 0, Nothing, Nothing, 1)

        ' Cuándo
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_YYYY", "Año", GetType(String), 40, 2, 0, 1, 1, 0, Color.DarkOrange, Nothing, 1)

        ' Qué
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ESCENARIO_PLAN", "Escenario", GetType(String), 70, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_NIVEL_RUBRO_PRESUPUESTO", "Nivel", GetType(String), 40, 2, 0, 0, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_RUBRO_PRESUPUESTO", "Rubro", GetType(String), 180, 1, 0, 1, 1, 1)

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_PROGRAMACION_PARTIDA", "Uso", GetType(String), 60, 2, 0, 1, 0, 1)

        ' Cuánto
        For i As Integer = 1 To 12
            Dim VP_PREFIJO As String = "M"
            If i < 10 Then
                VP_PREFIJO += "0" + i.ToString
            Else
                VP_PREFIJO += i.ToString
            End If
            PM_LI_MONTOS_ESTIMADOS(VP_PREFIJO, i)
        Next

        ' Estatus
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_ESTATUS_PLAN_GASTO", "Estatus", GetType(String), 80, 2, 0, 0, 0, 0)
        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)
    End Sub

    Public Sub PM_LI_MONTOS_ESTIMADOS(ByVal PP_PREFIJO As String, ByVal PP_PREFIJO_M As Integer)
        Dim VP_MES As String = ""
        Dim VP_VIS As Integer
        Select Case PP_PREFIJO_M
            Case 1 : VP_MES = "Enero" : VP_VIS = Codigo_CTRL.FG_CO_VALUE(CH_TRI1)
            Case 2 : VP_MES = "Febrero" : VP_VIS = Codigo_CTRL.FG_CO_VALUE(CH_TRI1)
            Case 3 : VP_MES = "Marzo" : VP_VIS = Codigo_CTRL.FG_CO_VALUE(CH_TRI1)
            Case 4 : VP_MES = "Abril" : VP_VIS = Codigo_CTRL.FG_CO_VALUE(CH_TRI2)
            Case 5 : VP_MES = "Mayo" : VP_VIS = Codigo_CTRL.FG_CO_VALUE(CH_TRI2)
            Case 6 : VP_MES = "Junio" : VP_VIS = Codigo_CTRL.FG_CO_VALUE(CH_TRI2)
            Case 7 : VP_MES = "Julio" : VP_VIS = Codigo_CTRL.FG_CO_VALUE(CH_TRI3)
            Case 8 : VP_MES = "Agosto" : VP_VIS = Codigo_CTRL.FG_CO_VALUE(CH_TRI3)
            Case 9 : VP_MES = "Septiembre" : VP_VIS = Codigo_CTRL.FG_CO_VALUE(CH_TRI3)
            Case 10 : VP_MES = "Octubre" : VP_VIS = Codigo_CTRL.FG_CO_VALUE(CH_TRI4)
            Case 11 : VP_MES = "Noviembre" : VP_VIS = Codigo_CTRL.FG_CO_VALUE(CH_TRI4)
            Case 12 : VP_MES = "Diciembre" : VP_VIS = Codigo_CTRL.FG_CO_VALUE(CH_TRI4)
        End Select
        Codigo_LI.PG_LI_COLUMN_ADD(LI_LISTADO, PP_PREFIJO + "_MONTO_ESTIMADO", VP_MES, GetType(Decimal), 80, 3, 0, VP_VIS, 0, 2)
    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer : Dim VP_NIVEL As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        VP_NIVEL = Codigo_LI.FG_LI_CELL_READ_RUNTIME(PP_ROW_DATA, "K_NIVEL_RUBRO_PRESUPUESTO")

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_PLAN_GASTO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_RUBRO_PRESUPUESTO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_PROGRAMACION_PARTIDA")

        ' Donde
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")

        '' Cuándo
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_YYYY")

        '' Qué
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ESCENARIO_PLAN")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_NIVEL_RUBRO_PRESUPUESTO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_RUBRO_PRESUPUESTO")

        If VP_NIVEL > 0 Then
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_PROGRAMACION_PARTIDA")
            For i As Integer = 1 To 12
                Dim VP_PREFIJO As String = "M"
                If i < 10 Then
                    VP_PREFIJO += "0" + i.ToString
                Else
                    VP_PREFIJO += i.ToString
                End If
                PM_LI_ROW_MONTOS_ESTIMADOS(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, VP_PREFIJO)
            Next

            ' Estatus
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_ESTATUS_PLAN_GASTO")
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
        Codigo_LI.PG_LI_CELL_FONT_PROPERTIES_RUNTIME(PP_LISTADO.Rows(VP_ROW), "D_RUBRO_PRESUPUESTO", VP_NIVEL, "PPO")
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

    Public Sub PM_BT_PROG_PPTO_SEMANAL_CLICK(ByRef PP_FORMA As Object)
        Dim VP_EXITO As Boolean = False
        Dim VP_MSJ As String = ""
        Dim VP_CLAVE As Integer = 0
        Dim PP_PARAMETROS As String = FM_GENERAR_PRESUPUESTO()
        Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "[PG_PR_PRESUPUESTO_GENERAR]", PP_PARAMETROS, VP_CLAVE, VP_MSJ)
        If VP_MSJ = "" Then
            PM_SUMARIZAR_PRESUPUESTOS(PP_FORMA)
            VP_MSJ = "Presupuesto generado exitosamente."
        Else
            VP_MSJ = "No fue posible generar el Presupuesto. Causa: " + VP_MSJ
        End If
        Codigo_Message.PG_MENSAJE_INFORMACION(VP_MSJ)

    End Sub

    Private Sub PM_SUMARIZAR_PRESUPUESTOS(ByRef PP_FORMA As Object)
        Dim VP_CLAVE As Integer = 0
        Dim VP_MSJ As String = ""
        Dim VP_PARAMETROS As String = ""
        Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "[PG_PR_PRESUPUESTO_SUMARIZAR]", VP_PARAMETROS, VP_CLAVE, VP_MSJ)

    End Sub

    Private Sub PM_BT_PLAN_GASTO_AUTORIZAR_CLICK(ByRef PP_FORMA As Object)
        Try
            Dim VP_EXITO As Boolean = False
            Dim VP_MSJ As String = ""
            Dim VP_CLAVE As Integer = 0
            Dim VP_PARAMETROS As String = ""
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, 1, False)
            Dim VP_K_PLAN_GASTO As Integer = 0
            VP_K_PLAN_GASTO = FM_K_SELECCIONADO()
            If VP_K_PLAN_GASTO > 0 Then
                Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_K_PLAN_GASTO, False)
                Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "[PG_TR_PLAN_GASTO_AUTORIZADO]", VP_PARAMETROS, VP_CLAVE, VP_MSJ)
                If VP_MSJ = "" Then
                    VP_MSJ = "Plan de Gasto <Autorizado> exitosamente."
                Else
                    VP_MSJ = "No fue posible <Autorizar> el Plan de Gasto. Causa: " + VP_MSJ
                End If
                Codigo_Message.PG_MENSAJE_INFORMACION(VP_MSJ)
            Else
                Codigo_Message.PG_MENSAJE_INFORMACION("Seleccione un registro para obtener el plan a Autorizar")
            End If
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PM_BT_PLAN_GASTO_AUTORIZAR_CLICK")
        End Try
    End Sub

    Public Sub PM_CARGAR_DATOS_PARA_PRESUPUESTO(ByRef PP_LISTADO As DataGridView)
        Dim COL_HEADER As String = PP_LISTADO.CurrentCell.OwningColumn.HeaderText
        If FM_HEADER_ES_MES(COL_HEADER) Then
            Dim ID_PGA As Integer = PP_LISTADO.CurrentRow.Cells("K_PLAN_GASTO").Value
            TB_K_PLAN_GASTO.Text = ID_PGA
            Codigo_CB.PG_CB_VALUE_LOAD(CB_MES, ID_MES)
        End If
    End Sub

#End Region

#Region "EVENTOS"

    Private Sub Catalogo_T1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT(Me)
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

    Private Sub BT_PROG_PPTO_SEMANAL_Click(sender As Object, e As EventArgs) Handles BT_PROG_PPTO.Click
        PM_BT_PROG_PPTO_SEMANAL_CLICK(Me)
    End Sub

    Private Sub TI_RELOJ_Tick(sender As Object, e As EventArgs) Handles TI_RELOJ.Tick
        PM_TI_TICK(LB_RELOJ)
    End Sub

    Private Sub BT_LISTADO_Click(sender As Object, e As EventArgs) Handles BT_LISTADO.Click
        PM_BT_LISTADO_CLICK(Me)
    End Sub

    Private Sub BT_PLAN_GASTO_AUTORIZAR_Click(sender As Object, e As EventArgs) Handles BT_PLAN_GASTO_AUTORIZAR.Click
        PM_BT_PLAN_GASTO_AUTORIZAR_CLICK(Me)
    End Sub

    Private Sub BT_EXPORTAR_EXCEL_Click(sender As Object, e As EventArgs) Handles BT_EXPORTAR_EXCEL.Click
        PM_BT_EXPORTAR_EXCEL_CLICK(LI_LISTADO)
    End Sub

    Private Sub LI_LISTADO_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LI_LISTADO.CellClick
        If e.RowIndex <> -1 Then
            PM_CARGAR_DATOS_PARA_PRESUPUESTO(LI_LISTADO)
        End If
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