Public Class FO_ASISTENTE_PRESUPUESTO

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_ID_VERSION As Integer = 0

#End Region

#Region "VARIABLES LOCALES"
    Dim VM_UNIDAD_OPERATIVA_IDS As New List(Of PLAN_GASTO_UO)

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ZONA_UO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_REGION, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_RAZON_SOCIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_AÑO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESCENARIO_PLAN, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, 4, False)
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
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "D_UNIDAD_OPERATIVA")
        Return VP_ID
    End Function

    Public Function FM_S_UO_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "S_UNIDAD_OPERATIVA")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_UNIDAD_OPERATIVA")
        Return VP_ID
    End Function
    Public Function FM_ID_PLAN_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_PLAN_GASTO")
        Return VP_ID
    End Function
    Public Function FM_K_YYYY_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_YYYY")
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

    Public Function FM_GENERAR_MASIVO()
        Dim VP_PARAMETROS As String = ""
        '  Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_PLAN_GASTO, False)

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_MES, False)
        ' Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
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
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_ESCENARIO_PLAN, "ESCENARIO_PLAN")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_REGION)
        Codigo_CB.PG_CB_ZONA_UO_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_ZONA_UO, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_RAZON_SOCIAL_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_RAZON_SOCIAL, 1, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_MES, "MES")
    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
    End Sub

    Public Sub PM_CH_INIT()
        'CH_TRI1.Checked = True : CH_TRI2.Checked = True
        'CH_TRI3.Checked = True : CH_TRI4.Checked = True
        'CH_EX_CEROS.Checked = True : CH_EX_ETIQUETAS.Checked = False
    End Sub

    Private Sub PM_FO_INIT(ByRef PP_FORMA As Object)
        Codigo_FRM.PG_FRM_INIT(VM_ID_BASE_DE_DATOS, PP_FORMA)
    End Sub

#End Region

#Region "SUBS_PM"

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 20)
        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "", "", GetType(Integer), 20, 2, 0, 1, 1, 0)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)], (OPCIONALES COLOR LETRA, COLOR FONDO, BOLD [0, 1])
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_PLAN_GASTO", "#PLG", GetType(Integer), 40, 2, 0, 1, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_UNIDAD_OPERATIVA", "#UNO", GetType(Integer), 40, 2, 0, 1, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_UNIDAD_OPERATIVA", "Unidad Operativa", GetType(String), 150, 1, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_UNIDAD_OPERATIVA", "S Unidad Operativa", GetType(String), 30, 1, 0, 0, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_YYYY", "Año", GetType(Integer), 60, 2, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ESCENARIO_PLAN", "Escenario", GetType(String), 60, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ZONA_UO", "Zona", GetType(String), 60, 2, 0, 1, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_REGION", "Región", GetType(String), 60, 2, 0, 1, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_RAZON_SOCIAL", "Razón Social", GetType(String), 60, 2, 0, 1, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PRESUPUESTO", "PPTO", GetType(String), 50, 2, 0, 1, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "SEMANAS", "WEEK", GetType(String), 50, 2, 0, 1, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "TRASPASOS", "TRSP", GetType(String), 50, 2, 0, 1, 0, 0, Color.DarkOrange, Nothing, 1)

    End Sub


    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_PLAN_GASTO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_YYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ESCENARIO_PLAN")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ZONA_UO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_REGION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_RAZON_SOCIAL")
    End Sub


    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        VM_UNIDAD_OPERATIVA_IDS.Clear()
        PM_LI_FORMAT(LI_LISTADO)
        ' Codigo_ABC.PG_BT_BUSCAR_CLICK(PP_FORMA, PP_LISTADO, "PG_LI_")
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
         Codigo_ABC.PG_BT_GUARDAR_CLICK(VM_ID_BASE_DE_DATOS,PP_FORMA, PP_LISTADO)
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
        PM_BT_BUSCAR_CLICK(PP_FORMA, PP_LISTADO)
    End Sub

    'Public Sub PM_BT_GENERAR_TRASPASOS_CLICK(ByRef PP_FORMA As Object)
    '    Dim PP_PARAMETROS As String = FM_GENERAR_PRESUPUESTO()
    '    Codigo_CON.FG_SQL_EJECUTAR_ACCION(PP_FORMA, "[PG_PR_TRASPASO_X_K_PRESUPUESTO]", PP_PARAMETROS)
    'End Sub

    Public Function FM_PR_PRESUPUESTO_GENERAR_PARAMETROS(ByVal PP_PLAN_GASTO_UO As PLAN_GASTO_UO) As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_PLAN_GASTO_UO.VC_K_PLAN_GASTO1, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_MES, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_PR_PRESUPUESTO_SEMANAS_PARAMETROS(ByVal PP_PLAN_GASTO_UO As PLAN_GASTO_UO) As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_PLAN_GASTO_UO.VC_K_UNIDAD_OPERATIVA1, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_PLAN_GASTO_UO.VC_K_YYYY1, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_MES, False)
        Return VP_PARAMETROS
    End Function

    Public Sub PM_BT_PROG_MASIVO_CLICK(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)

        Dim COLOR_ORIGINAL As Color = Color.White
        For Each VP_ROW As DataGridViewRow In PP_LISTADO.Rows
            Codigo_LI.PG_LI_CELL_COLOR_CHANGE(LI_LISTADO, VP_ROW.Index, 9, COLOR_ORIGINAL)
            Codigo_LI.PG_LI_CELL_COLOR_CHANGE(LI_LISTADO, VP_ROW.Index, 10, COLOR_ORIGINAL)
            Codigo_LI.PG_LI_CELL_COLOR_CHANGE(LI_LISTADO, VP_ROW.Index, 11, COLOR_ORIGINAL)
        Next
        PP_LISTADO.Refresh()

        Application.DoEvents()

        Dim VP_MES_A_PROCESAR As Integer = -1
        VP_MES_A_PROCESAR = Codigo_CTRL.FG_CO_VALUE(CB_MES) - 1
        Dim PP_PB_PROGRESSBAR As BARRA_DE_PROGRESO_PANEL
        PP_PB_PROGRESSBAR = ProgressBarPanel.FG_PROGRESSBAR_INIT(PP_FORMA, 0, VM_UNIDAD_OPERATIVA_IDS.Count, "Carga de Registros", Color.DarkOrange)
        Dim VP_COUNT As Integer = 0
        RT_EVENTOS.Text = ""
        For Each VP_PLAN_UO In VM_UNIDAD_OPERATIVA_IDS
            Dim VP_ROW_INDEX As Integer = -1
            VP_ROW_INDEX = Codigo_LI.FG_LI_ROW_INDEX(LI_LISTADO, VP_PLAN_UO.VC_K_PLAN_GASTO1, "K_PLAN_GASTO")
            If CH_GENERAR_PRESUPUESTO.Checked Then
                Dim VP_PARAMETROS As String = ""
                Dim VP_CLAVE As Integer = 0
                Dim VP_MSJ As String = ""
                Dim VP_COLOR_ROW As Color = Color.White
                VP_PARAMETROS = FM_PR_PRESUPUESTO_GENERAR_PARAMETROS(VP_PLAN_UO)
                Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "[PG_PR_PRESUPUESTO_GENERAR]", VP_PARAMETROS, VP_CLAVE, VP_MSJ)
                If VP_MSJ = "" Then
                    VP_MSJ = "Presupuesto generado exitosamente."
                    VP_COLOR_ROW = Color.Green
                Else
                    VP_COLOR_ROW = Color.Red
                    VP_MSJ = "" + VP_MSJ
                End If
                Codigo_LI.PG_LI_CELL_COLOR_CHANGE(LI_LISTADO, VP_ROW_INDEX, 10, VP_COLOR_ROW)
                VP_PLAN_UO.VC_K_PRESUPUESTO1(VP_MES_A_PROCESAR) = VP_CLAVE
                Dim VP_TEXTO As String = ""
                VP_TEXTO = VP_TEXTO + vbCrLf + "PPTO>       Plan: " + VP_PLAN_UO.VC_K_PLAN_GASTO1.ToString().PadLeft(7)
                VP_TEXTO = VP_TEXTO + " | UO: " + VP_PLAN_UO.VC_S_UNIDAD_OPERATIVA1.ToString().PadLeft(5)
                VP_TEXTO = VP_TEXTO + " | Año: " + VP_PLAN_UO.VC_K_YYYY1.ToString().PadLeft(5)
                VP_TEXTO = VP_TEXTO + " | Mes: " + Codigo_CB.FG_CB_ITEM_TEXT(CB_MES).PadLeft(10)
                VP_TEXTO = VP_TEXTO + " | Mensaje: " + VP_MSJ
                RT_EVENTOS.SelectionColor = VP_COLOR_ROW
                RT_EVENTOS.SelectedText = VP_TEXTO
            End If
            If CH_DISTRIBUCION_SEMANAL.Checked Then
                Dim VP_PARAMETROS As String = ""
                Dim VP_CLAVE As Integer = 0
                Dim VP_MSJ As String = ""
                Dim VP_COLOR_ROW As Color = Color.White
                VP_PARAMETROS = FM_PR_PRESUPUESTO_SEMANAS_PARAMETROS(VP_PLAN_UO)
                Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "[PG_PR_PRESUPUESTO_PROGRAMAR_SEMANAS_X_PARAMETROS]", VP_PARAMETROS, VP_CLAVE, VP_MSJ)
                VP_PLAN_UO.VC_K_PRESUPUESTO1(VP_MES_A_PROCESAR) = VP_CLAVE
                If VP_MSJ = "" Then
                    VP_MSJ = "Distribución Semanal de Presupuesto exitosa."
                    VP_COLOR_ROW = Color.Green
                Else
                    VP_MSJ = "" + VP_MSJ
                    VP_COLOR_ROW = Color.Red
                End If
                Codigo_LI.PG_LI_CELL_COLOR_CHANGE(LI_LISTADO, VP_ROW_INDEX, 11, VP_COLOR_ROW)
                Dim VP_TEXTO As String = ""
                VP_TEXTO = VP_TEXTO + vbCrLf + "WEEK>Presupuesto: " + VP_PLAN_UO.VC_K_PRESUPUESTO1(VP_MES_A_PROCESAR).ToString().PadLeft(7)
                VP_TEXTO = VP_TEXTO + " | UO: " + VP_PLAN_UO.VC_S_UNIDAD_OPERATIVA1.ToString().PadLeft(5)
                VP_TEXTO = VP_TEXTO + " | Año: " + VP_PLAN_UO.VC_K_YYYY1.ToString().PadLeft(5)
                VP_TEXTO = VP_TEXTO + " | Mes: " + Codigo_CB.FG_CB_ITEM_TEXT(CB_MES).PadLeft(10)
                VP_TEXTO = VP_TEXTO + " | Mensaje: " + VP_MSJ
                RT_EVENTOS.SelectionColor = VP_COLOR_ROW
                RT_EVENTOS.SelectedText = VP_TEXTO

            End If
            If CH_GENERAR_TRASPASOS.Checked Then
                Dim VP_PARAMETROS As String = ""
                Dim VP_CLAVE As Integer = 0
                Dim VP_MSJ As String = ""
                Dim VP_COLOR_ROW As Color = Color.White
                VP_PARAMETROS = FM_PR_PRESUPUESTO_SEMANAS_PARAMETROS(VP_PLAN_UO)
                Cursor = Cursors.WaitCursor
                Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "[PG_PR_TRASPASO_X_PARAMETROS]", VP_PARAMETROS, VP_CLAVE, VP_MSJ)
                Cursor = Cursors.Default
                VP_PLAN_UO.VC_K_PRESUPUESTO1(VP_MES_A_PROCESAR) = VP_CLAVE
                If VP_MSJ = "" Then
                    VP_MSJ = "Generación de traspasos del presupuesto exitosa."
                    VP_COLOR_ROW = Color.Green
                Else
                    VP_MSJ = "" + VP_MSJ
                    VP_COLOR_ROW = Color.Red
                End If
                Codigo_LI.PG_LI_CELL_COLOR_CHANGE(LI_LISTADO, VP_ROW_INDEX, 12, VP_COLOR_ROW)
                Dim VP_TEXTO As String = ""
                VP_TEXTO = VP_TEXTO + vbCrLf + "TRSP>Presupuesto: " + VP_PLAN_UO.VC_K_PRESUPUESTO1(VP_MES_A_PROCESAR).ToString().PadLeft(7)
                VP_TEXTO = VP_TEXTO + " | UO: " + VP_PLAN_UO.VC_S_UNIDAD_OPERATIVA1.ToString().PadLeft(5)
                VP_TEXTO = VP_TEXTO + " | Año: " + VP_PLAN_UO.VC_K_YYYY1.ToString().PadLeft(5)
                VP_TEXTO = VP_TEXTO + " | Mes: " + Codigo_CB.FG_CB_ITEM_TEXT(CB_MES).PadLeft(10)
                VP_TEXTO = VP_TEXTO + " | Mensaje: " + VP_MSJ
                RT_EVENTOS.SelectionColor = VP_COLOR_ROW
                RT_EVENTOS.SelectedText = VP_TEXTO
            End If
            ProgressBarPanel.PG_PROGRESSBAR_INCREMENT(PP_PB_PROGRESSBAR, VP_COUNT)
            VP_COUNT = VP_COUNT + 1
        Next
        PM_SUMARIZAR_PRESUPUESTOS(PP_FORMA)
        Application.DoEvents()
        ProgressBarPanel.PG_PROGRESSBAR_END(PP_PB_PROGRESSBAR)
    End Sub

    Private Sub PM_SUMARIZAR_PRESUPUESTOS(ByRef PP_FORMA As Object)
        Dim VP_CLAVE As Integer = 0
        Dim VP_MSJ As String = ""
        Dim VP_PARAMETROS As String = ""
        Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "[PG_PR_PRESUPUESTO_SUMARIZAR]", VP_PARAMETROS, VP_CLAVE, VP_MSJ)

    End Sub

    Public Sub PM_LI_LISTADO_CELL_DOUBLE_CLICK(ByRef PP_LISTADO As DataGridView)
        If Codigo_LI.FG_LI_ROW_SELECTED(PP_LISTADO) Then
            Dim VL_CHK As DataGridViewCheckBoxCell = PP_LISTADO.Rows(Codigo_LI.FG_LI_ROW_CURRENT(PP_LISTADO)).Cells(0)
            Dim VL_K_UNIDAD_OPERATIVA = FM_ID_SELECCIONADO(PP_LISTADO, Codigo_LI.FG_LI_ROW_CURRENT(PP_LISTADO))
            Dim VL_D_UNIDAD_OPERATIVA = FM_DESC_SELECCIONADO(PP_LISTADO, Codigo_LI.FG_LI_ROW_CURRENT(PP_LISTADO))
            Dim VL_S_UNIDAD_OPERATIVA = FM_S_UO_SELECCIONADO(PP_LISTADO, Codigo_LI.FG_LI_ROW_CURRENT(PP_LISTADO))
            Dim VL_K_PLAN_GASTO = FM_ID_PLAN_SELECCIONADO(PP_LISTADO, Codigo_LI.FG_LI_ROW_CURRENT(PP_LISTADO))
            Dim VL_K_YYYY = FM_K_YYYY_SELECCIONADO(PP_LISTADO, Codigo_LI.FG_LI_ROW_CURRENT(PP_LISTADO))
            'Dim TXT As String = ""
            'MsgBox(VL_ID_MOV.ToString)
            If VL_CHK.Value = True Then
                VL_CHK.Value = False
                VM_UNIDAD_OPERATIVA_IDS.RemoveAll(Function(x) x.VC_K_PLAN_GASTO1 = VL_K_PLAN_GASTO And x.VC_K_UNIDAD_OPERATIVA1 = VL_K_UNIDAD_OPERATIVA And x.VC_K_YYYY1 = VL_K_YYYY)

            Else
                VL_CHK.Value = True
                Dim VL_OBJETO As New PLAN_GASTO_UO(VL_K_PLAN_GASTO, VL_K_UNIDAD_OPERATIVA, VL_D_UNIDAD_OPERATIVA, VL_S_UNIDAD_OPERATIVA, VL_K_YYYY)
                VM_UNIDAD_OPERATIVA_IDS.Add(VL_OBJETO)
            End If

        End If
    End Sub

    Private Sub PM_BT_SELECCIONAR_TODOS_CHECK(sender As CheckBox, lI_LISTADO As DataGridView)
        VM_UNIDAD_OPERATIVA_IDS.Clear()
        If sender.Checked Then
            For Each VP_ROW As DataGridViewRow In lI_LISTADO.Rows
                Dim VL_CHK As DataGridViewCheckBoxCell = VP_ROW.Cells(0)
                Dim VL_K_UNIDAD_OPERATIVA = FM_ID_SELECCIONADO(lI_LISTADO, VP_ROW.Index)
                Dim VL_D_UNIDAD_OPERATIVA = FM_DESC_SELECCIONADO(lI_LISTADO, VP_ROW.Index)
                Dim VL_S_UNIDAD_OPERATIVA = FM_S_UO_SELECCIONADO(lI_LISTADO, VP_ROW.Index)
                Dim VL_K_PLAN_GASTO = FM_ID_PLAN_SELECCIONADO(lI_LISTADO, VP_ROW.Index)
                Dim VL_K_YYYY = FM_K_YYYY_SELECCIONADO(lI_LISTADO, VP_ROW.Index)
                VL_CHK.Value = True
                Dim VL_OBJETO As New PLAN_GASTO_UO(VL_K_PLAN_GASTO, VL_K_UNIDAD_OPERATIVA, VL_D_UNIDAD_OPERATIVA, VL_S_UNIDAD_OPERATIVA, VL_K_YYYY)
                VM_UNIDAD_OPERATIVA_IDS.Add(VL_OBJETO)
            Next
        Else
            For Each VP_ROW As DataGridViewRow In lI_LISTADO.Rows
                Dim VL_CHK As DataGridViewCheckBoxCell = VP_ROW.Cells(0)
                VL_CHK.Value = False
            Next
        End If

    End Sub


#End Region

#Region "EVENTOS"

    Private Sub Catalogo_T1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT(Me)
        VM_UNIDAD_OPERATIVA_IDS.Clear()
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
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
        PM_LI_LISTADO_CELL_DOUBLE_CLICK(LI_LISTADO)
    End Sub

    Private Sub BT_PROG_MASIVO_Click(sender As Object, e As EventArgs) Handles BT_PROG_MASIVO.Click
        PM_BT_PROG_MASIVO_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub CH_SELECCIONAR_TODOS_CheckedChanged(sender As Object, e As EventArgs) Handles CH_SELECCIONAR_TODOS.CheckedChanged
        PM_BT_SELECCIONAR_TODOS_CHECK(sender, LI_LISTADO)
    End Sub

#End Region

End Class

Public Class PLAN_GASTO_UO
    Dim VC_K_PLAN_GASTO As Integer
    Dim VC_K_UNIDAD_OPERATIVA As Integer
    Dim VC_D_UNIDAD_OPERATIVA As String
    Dim VC_S_UNIDAD_OPERATIVA As String
    Dim VC_K_YYYY As Integer
    Dim VC_K_PRESUPUESTO(12) As Integer

    Public Sub New(vC_K_PLAN_GASTO As Integer, vC_K_UNIDAD_OPERATIVA As Integer, vC_D_UNIDAD_OPERATIVA As String, vC_S_UNIDAD_OPERATIVA As String, vC_K_YYYY As Integer)
        Me.VC_K_PLAN_GASTO1 = vC_K_PLAN_GASTO
        Me.VC_K_UNIDAD_OPERATIVA1 = vC_K_UNIDAD_OPERATIVA
        Me.VC_K_YYYY1 = vC_K_YYYY
        Me.VC_D_UNIDAD_OPERATIVA1 = vC_D_UNIDAD_OPERATIVA
        Me.VC_S_UNIDAD_OPERATIVA1 = vC_S_UNIDAD_OPERATIVA
    End Sub

    Public Property VC_K_PLAN_GASTO1 As Integer
        Get
            Return VC_K_PLAN_GASTO
        End Get
        Set(value As Integer)
            VC_K_PLAN_GASTO = value
        End Set
    End Property

    Public Property VC_K_UNIDAD_OPERATIVA1 As Integer
        Get
            Return VC_K_UNIDAD_OPERATIVA
        End Get
        Set(value As Integer)
            VC_K_UNIDAD_OPERATIVA = value
        End Set
    End Property

    Public Property VC_K_YYYY1 As Integer
        Get
            Return VC_K_YYYY
        End Get
        Set(value As Integer)
            VC_K_YYYY = value
        End Set
    End Property

    Public Property VC_K_PRESUPUESTO1 As Integer()
        Get
            Return VC_K_PRESUPUESTO
        End Get
        Set(value As Integer())
            VC_K_PRESUPUESTO = value
        End Set
    End Property

    Public Property VC_D_UNIDAD_OPERATIVA1 As String
        Get
            Return VC_D_UNIDAD_OPERATIVA
        End Get
        Set(value As String)
            VC_D_UNIDAD_OPERATIVA = value
        End Set
    End Property

    Public Property VC_S_UNIDAD_OPERATIVA1 As String
        Get
            Return VC_S_UNIDAD_OPERATIVA
        End Get
        Set(value As String)
            VC_S_UNIDAD_OPERATIVA = value
        End Set
    End Property
End Class