Public Class FO_CONTROL_ANUAL

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_ID_VERSION As Integer = 0

#End Region

#Region "VARIABLES LOCALES"

    Dim VL_HOY As Date = Now : Dim VP_NUM_MES As String = ""
#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_AÑO, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_AÑO.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_AÑO, False)
            PP_NUEVO = False
        End If

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_NUM_MES, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ESTATUS_CONTROL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_01_PPT_GENERAR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_02_PPT_EDITAR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_03_PPT_PROGRAMAR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_04_PPT_GENERAR_TRASPASOS, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_05_PFD_POLIZA_EDIT, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_06_PFD_INGRESOS_ADD, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_07_PFD_TRASPASO_ADD, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_08_PFD_FACTURA_ADD, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_09_PFD_INSTRUCCION_NEW, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_10_ACCION, False)

        Return VP_PARAMETROS
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_YYYY")
        Return VP_ID
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean

        VP_VALIDACION = (PP_MENSAJE_VALIDACION = "")

        Return VP_VALIDACION
    End Function

    Public Function FM_GENERAR_AÑO()
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_AÑO, False)
        Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
        Return VP_PARAMETROS
    End Function

    'Public Function FM_GENERAR_BLOQUE_CONTROL()
    '    Dim VP_PARAMETROS As String = ""
    '    Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_AÑO, False)
    '    Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
    '    Return VP_PARAMETROS
    'End Function

    Private Function FM_VALIDAR_AÑO() As String
        Dim PP_MENSAJE_VALIDACION As String = ""
        If Codigo_CB.FG_CB_ITEM_VALUE(CB_LI_AÑO) = -1 Then
            PP_MENSAJE_VALIDACION = "Escriba un Año válido."
        End If
        Return PP_MENSAJE_VALIDACION
    End Function

    Public Function FM_HEADER_ES_MES(ByVal COL_NAME As String)
        Dim ES_MES As Boolean = False
        Select Case COL_NAME
            Case "Enero" : ES_MES = True
            Case "Febrero" : ES_MES = True
            Case "Marzo" : ES_MES = True
            Case "Abril" : ES_MES = True
            Case "Mayo" : ES_MES = True
            Case "Junio" : ES_MES = True
            Case "Julio" : ES_MES = True
            Case "Agosto" : ES_MES = True
            Case "Septiembre" : ES_MES = True
            Case "Octubre" : ES_MES = True
            Case "Noviembre" : ES_MES = True
            Case "Diciembre" : ES_MES = True
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
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_AÑO, "TIEMPO_YYYY")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_ESTATUS_CONTROL, "ESTATUS_CONTROL")
    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
    End Sub

    Public Sub PM_CH_INIT()
        CH_TRI1.Checked = True : CH_TRI2.Checked = True
        CH_TRI3.Checked = True : CH_TRI4.Checked = True
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
        CB_ESTATUS_CONTROL.Enabled = True
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)
        Codigo_CTRL.PG_CO_DATA_LOAD("K_YYYY", TB_K_AÑO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("D_TIEMPO_MES", TB_MES, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("K_ESTATUS_CONTROL", CB_ESTATUS_CONTROL, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("L_01_PPT_GENERAR", CH_L_01_PPT_GENERAR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("L_02_PPT_EDITAR", CH_L_02_PPT_EDITAR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("L_03_PPT_PROGRAMAR", CH_L_03_PPT_PROGRAMAR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("L_04_PPT_GENERAR_TRASPASOS", CH_L_04_PPT_GENERAR_TRASPASOS, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("L_05_PFD_POLIZA_EDIT", CH_L_05_PFD_POLIZA_EDIT, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("L_06_PFD_INGRESOS_ADD", CH_L_06_PFD_INGRESOS_ADD, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("L_07_PFD_TRASPASO_ADD", CH_L_07_PFD_TRASPASO_ADD, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("L_08_PFD_FACTURA_ADD", CH_L_08_PFD_FACTURA_ADD, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("L_09_PFD_INSTRUCCION_NEW", CH_L_09_PFD_INSTRUCCION_NEW, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("L_10_ACCION", CH_L_10_ACCION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("L_11_ACCION", CH_L_11_ACCION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("L_12_ACCION", CH_L_12_ACCION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("L_13_ACCION", CH_L_13_ACCION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("L_14_ACCION", CH_L_14_ACCION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("L_15_ACCION", CH_L_15_ACCION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("L_16_ACCION", CH_L_16_ACCION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("L_17_ACCION", CH_L_17_ACCION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("L_18_ACCION", CH_L_18_ACCION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("L_19_ACCION", CH_L_19_ACCION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("L_20_ACCION", CH_L_20_ACCION, PP_ROW)
        Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)
        VP_NUM_MES = Codigo_CON.FG_CO_DATA_READ(PP_ROW, "K_MM", "")
    End Sub

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)]
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_YYYY", "Año", GetType(String), 40, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        For i As Integer = 1 To 12
            Dim VP_PREFIJO As String = "M"
            If i < 10 Then
                VP_PREFIJO += "0" + i.ToString
            Else
                VP_PREFIJO += i.ToString
            End If
            PM_LI_MESES(VP_PREFIJO, i)
        Next
    End Sub

    Public Sub PM_LI_MESES(ByVal PP_PREFIJO As String, ByVal PP_PREFIJO_M As Integer)
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
        Codigo_LI.PG_LI_COLUMN_ADD(LI_LISTADO, PP_PREFIJO + "_ESTATUS", VP_MES, GetType(Decimal), 80, 3, 0, VP_VIS, 0, 2)
    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_YYYY")
        For i As Integer = 1 To 12
            Dim VP_PREFIJO As String = "M"
            If i < 10 Then
                VP_PREFIJO += "0" + i.ToString
            Else
                VP_PREFIJO += i.ToString
            End If
            PM_LI_CELL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, VP_PREFIJO)
        Next
    End Sub

    Public Sub PM_LI_CELL(ByRef PP_LISTADO As DataGridView, ByVal PP_ROW As Integer, ByRef PP_COLUMNA As Integer, ByRef PP_ROW_DATA As DataRow, ByVal PP_PREFIJO As String)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, PP_PREFIJO + "_ESTATUS")
    End Sub

    Public Sub PM_LI_DOUBLE_CLICK(ByRef PP_LISTADO As DataGridView)
        Dim COL_HEADER As String = LI_LISTADO.CurrentCell.OwningColumn.HeaderText
        If FM_HEADER_ES_MES(COL_HEADER) Then
            PM_CARGAR_FICHA(LI_LISTADO)
        End If
    End Sub

    Public Sub PM_CARGAR_FICHA(ByRef PP_LISTADO As DataGridView)
        Dim VP_ID As String
        Try
            If PP_LISTADO.Rows.Count > 0 Then
                Dim VP_ROW As Integer = FG_LI_ROW_CURRENT(PP_LISTADO)
                VP_ID = FM_ID_SELECCIONADO(PP_LISTADO, VP_ROW)
                Dim VP_MES As Integer = FG_LI_COLUMN_CURRENT(PP_LISTADO)
                Dim VP_IDS As String = VP_ID.ToString + ", " + VP_MES.ToString
                PM_FI_LOAD(VP_IDS)

                VM_IN_MODO_OPERACION = Modo_Operacion.Ver_Ficha
                Codigo_FRM.PG_FRM_CONFIG(Me)
            End If
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PG_LI_DOUBLE_CLICK")
        End Try
    End Sub

    Public Function FG_LI_ROW_CURRENT(ByVal PP_LISTADO As DataGridView) As Integer
        Dim VP_ROW As Integer = -1
        If PP_LISTADO.CurrentCell IsNot Nothing Then
            VP_ROW = PP_LISTADO.CurrentCell.RowIndex
        End If
        Return VP_ROW
    End Function

    Public Function FG_LI_COLUMN_CURRENT(ByVal PP_LISTADO As DataGridView) As Integer
        Dim VP_COLUMN As Integer = -1
        Dim VP_MES As Integer = -1
        If PP_LISTADO.CurrentCell IsNot Nothing Then
            VP_COLUMN = PP_LISTADO.CurrentCell.ColumnIndex
            If VP_COLUMN = 1 Then VP_MES = 1
            If VP_COLUMN = 2 Then VP_MES = 2
            If VP_COLUMN = 3 Then VP_MES = 3
            If VP_COLUMN = 4 Then VP_MES = 4
            If VP_COLUMN = 5 Then VP_MES = 5
            If VP_COLUMN = 6 Then VP_MES = 6
            If VP_COLUMN = 7 Then VP_MES = 7
            If VP_COLUMN = 8 Then VP_MES = 8
            If VP_COLUMN = 9 Then VP_MES = 9
            If VP_COLUMN = 10 Then VP_MES = 10
            If VP_COLUMN = 11 Then VP_MES = 11
            If VP_COLUMN = 12 Then VP_MES = 12
        End If
        Return VP_MES
    End Function

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        PM_LI_FORMAT(PP_LISTADO)
        Codigo_ABC.PG_BT_BUSCAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO, "[PG_LI_MATRIZ_CONTROL_X_MES]")
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
        If VM_IN_MODO_OPERACION = Modo_Operacion.Ver_Ficha Then
            Codigo_ABC.PG_BT_EDITAR_CLICK(PP_FORMA, PP_LISTADO)
            CH_L_01_PPT_GENERAR.Select()
        Else
            Codigo_Message.PG_MENSAJE_INFORMACION("Para Editar, de doble click en alguna celda del Mes, luego al " + vbCrLf + "botón de Editar, cuando la Ficha se encuentre visible.")
        End If
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

    Public Sub PM_BT_AGREGAR_AÑO_CLICK(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Dim VM_MSJ As String = FM_VALIDAR_AÑO()
        If VM_MSJ = "" Then
            Dim PP_PARAMETROS As String = FM_GENERAR_AÑO() 'FM_GENERAR_BLOQUE_CONTROL()
            Codigo_CON.FG_SQL_EJECUTAR_ACCION(PP_FORMA, VM_ID_BASE_DE_DATOS, "[PG_IN_MATRIZ_CONTROL_X_MES]", PP_PARAMETROS)
        Else
            Codigo_Message.PG_MENSAJE_GUARDAR_VALIDAR(VM_MSJ)
        End If
        PM_BT_BUSCAR_CLICK(PP_FORMA, LI_LISTADO)
    End Sub

#End Region

#Region "EVENTOS"

    Private Sub Catalogo_T1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT(Me)
    End Sub

    Private Sub BT_AGREGAR_Click(sender As Object, e As EventArgs) Handles BT_AGREGAR.Click
        PM_BT_AGREGAR_AÑO_CLICK(Me, LI_LISTADO)
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

    Private Sub LI_LISTADO_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LI_LISTADO.CellDoubleClick
        If e.RowIndex <> -1 Then
            PM_LI_DOUBLE_CLICK(LI_LISTADO)
        End If
    End Sub

    Private Sub BT_GENERAR_BLOQUE_CONTROL_Click(sender As Object, e As EventArgs) Handles BT_GENERAR_BLOQUE_CONTROL.Click
        PM_BT_AGREGAR_AÑO_CLICK(Me, LI_LISTADO)
    End Sub

#End Region

End Class