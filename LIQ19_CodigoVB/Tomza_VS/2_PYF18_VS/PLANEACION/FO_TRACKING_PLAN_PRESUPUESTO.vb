Public Class FO_TRACKING_PLAN_PRESUPUESTO

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
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIEMPO_YYYY, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TEMPORADA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESTATUS_PLAN_PRESUPUESTO, False)
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
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_TIEMPO_YYYY)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_TEMPORADA)
        Codigo_CB.PG_CB_ZONA_UO_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_ZONA_UO, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_RAZON_SOCIAL_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_RAZON_SOCIAL, 1, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 1, CB_LI_ZONA_UO, CB_LI_RAZON_SOCIAL, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_ESTATUS_PLAN_PRESUPUESTO)
    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
    End Sub

    Public Sub PM_CH_INIT()
        CH_PARAMETROS.Checked = True : CH_PREVIO.Checked = True
        CH_REVISADO.Checked = True : CH_AUTORIZADO.Checked = True
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
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_PLAN_PRESUPUESTO", "#PPR", GetType(Integer), 40, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_PLAN_PRESUPUESTO", "#PPR", GetType(String), 140, 2, 0, 1, 1, 0, Nothing, Nothing, 1)
        ' Donde
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_UNIDAD_OPERATIVA", "K_UNIDAD_OPERATIVA", GetType(Integer), 89, 1, 0, 0, 1, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_ZONA_UO", "K_ZONA_UO", GetType(Integer), 89, 1, 0, 0, 1, 0)
        ' Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_RAZON_SOCIAL", "K_RAZON_SOCIAL", GetType(Integer), 89, 1, 0, 0, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ZONA_UO", "Zona", GetType(String), 60, 2, 0, 1, 1, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_RAZON_SOCIAL", "Razón Social", GetType(String), 60, 2, 0, 1, 1, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_UNIDAD_OPERATIVA", "Unidad Operativa", GetType(String), 120, 1, 0, 1, 1, 0, Color.DarkOrange, Nothing, 1)
        ' Cuándo
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_YYYY", "Año", GetType(Integer), 60, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_TEMPORADA", "Temporada", GetType(String), 80, 2, 0, 0, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_TEMPORADA", "Temporada", GetType(String), 80, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_TEMPORADA", "Temporada", GetType(String), 80, 2, 0, 0, 0, 0)
        ' Estatus
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_ESTATUS_PLAN_PRESUPUESTO", "Estatus", GetType(String), 80, 2, 0, 1, 0, 0)
        'Control
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "USR_P1_D_USUARIO", "U. Base", GetType(String), 80, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_PASO_1", "F. Base", GetType(DateTime), 80, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "USR_P2_D_USUARIO", "U. Working", GetType(String), 80, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_PASO_2", "F. Working", GetType(DateTime), 80, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "USR_P3_D_USUARIO", "U. Previo", GetType(String), 80, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_PASO_3", "F. Previo", GetType(DateTime), 80, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "USR_P4_D_USUARIO", "U. Revisado", GetType(String), 80, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_PASO_4", "F. Revisado", GetType(DateTime), 80, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "USR_P5_D_USUARIO", "U. Autorizado", GetType(String), 80, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_PASO_5", "F. Autorizado", GetType(DateTime), 80, 2, 0, 1, 0, 0)

        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)
    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_PLAN_PRESUPUESTO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_PLAN_PRESUPUESTO")
        ' Donde
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_UNIDAD_OPERATIVA")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_ZONA_UO")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_RAZON_SOCIAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ZONA_UO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_RAZON_SOCIAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")
        ' Cuándo
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_YYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_TEMPORADA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_TEMPORADA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_TEMPORADA")
        ' Estatus
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_ESTATUS_PLAN_PRESUPUESTO")
        'Control
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "USR_P1_D_USUARIO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_PASO_1")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "USR_P2_D_USUARIO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_PASO_2")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "USR_P3_D_USUARIO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_PASO_3")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "USR_P4_D_USUARIO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_PASO_4")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "USR_P5_D_USUARIO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_PASO_5")

        Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)
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

    Public Sub PM_BT_GENERAR_PLAN_PPTO_CLICK(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView, ByVal PP_MENSAJE As String, ByVal PP_K_ZONA_UO As Integer, ByVal PP_K_RAZON_SOCIAL As Integer, ByVal PP_K_UNIDAD_OPERATIVA As Integer)
        Try


            Dim VP_D_YYYY As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_TIEMPO_YYYY)
            Dim VP_D_TEMPORADA As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_TEMPORADA)
            If Codigo_Message.FG_MENSAJE_CONFIRMACION(PP_MENSAJE) Then

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
                            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS_LOTE, VP_K_UNIDAD_OPERATIVA, False)
                            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS_LOTE, VP_K_TIEMPO_YYYY, False)
                            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS_LOTE, VP_K_TEMPORADA, False)

                            Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "[PG_PR_PLAN_PRESUPUESTO_X_UNO]", VP_PARAMETROS_LOTE, VP_CLAVE, VP_MENSAJE)
                            If VP_MENSAJE <> "" Then
                                Codigo_Message.PG_MENSAJE_AVISO(VP_MENSAJE)
                            End If
                            VP_CONTADOR += 1
                            ProgressBarPanel.PG_PROGRESSBAR_INCREMENT(PP_PB_PROGRESSBAR, VP_CONTADOR, VP_D_UNIDAD_OPERATIVA)
                        End While
                        ProgressBarPanel.PG_PROGRESSBAR_END(PP_PB_PROGRESSBAR)

                    End If

                    Codigo_Message.PG_MENSAJE_INFORMACION("<Generación Plan de Presupuesto> Finalizado.")
                    PM_BT_BUSCAR_CLICK(PP_FORMA, PP_LISTADO)
                End If
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception

        End Try
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

    Private Sub BT_PROG_PPTO_SEMANAL_Click(sender As Object, e As EventArgs) Handles BT_GENERAR_PLAN_PPTO.Click

        Dim VP_K_ZONA_UO As Integer = Codigo_CB.FG_CB_ITEM_VALUE(CB_LI_ZONA_UO)
        Dim VP_K_RAZON_SOCIAL As Integer = Codigo_CB.FG_CB_ITEM_VALUE(CB_LI_RAZON_SOCIAL)
        Dim VP_K_UNIDAD_OPERATIVA As Integer = Codigo_CB.FG_CB_ITEM_VALUE(CB_LI_UNIDAD_OPERATIVA)

        If VP_K_ZONA_UO = -1 And VP_K_ZONA_UO = -1 And VP_K_UNIDAD_OPERATIVA = -1 Then
            Codigo_Message.PG_MENSAJE_AVISO("Seleccione una Zona, Razón Social o Unidad Operativa validos")
        Else
            Dim VP_D_ZONA_UO As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_ZONA_UO)
            Dim VP_D_RAZON_SOCIAL As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_RAZON_SOCIAL)
            Dim VP_D_UNIDAD_OPERATIVA As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_UNIDAD_OPERATIVA)
            Dim VP_D_TEMPORADA As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_TEMPORADA)
            Dim VP_D_TIEMPO_YYYY As String = Codigo_CB.FG_CB_ITEM_TEXT(CB_LI_TIEMPO_YYYY)
            Dim VP_MENSAJE As String = ""
            VP_MENSAJE += "Desea Generar la Base para el [Plan de Presupuesto] para:"
            VP_MENSAJE += vbCrLf + " -Zona: " + VP_D_ZONA_UO
            VP_MENSAJE += vbCrLf + " -Razón Social: " + VP_D_RAZON_SOCIAL
            VP_MENSAJE += vbCrLf + " -Unidad Operativa: " + VP_D_UNIDAD_OPERATIVA
            VP_MENSAJE += vbCrLf + " -Temporada: " + VP_D_TEMPORADA
            VP_MENSAJE += vbCrLf + " -Año: " + VP_D_TIEMPO_YYYY

            PM_BT_GENERAR_PLAN_PPTO_CLICK(Me, LI_LISTADO, VP_MENSAJE, VP_K_ZONA_UO, VP_K_RAZON_SOCIAL, VP_K_UNIDAD_OPERATIVA)
        End If
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
            'PM_CARGAR_DATOS_PARA_PRESUPUESTO(LI_LISTADO)
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