Imports System.Windows.Forms.DataVisualization.Charting
Public Class FO_ESTIMACION

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_ID_ROW As String = ""
    Public VM_VISIBILIDAD_GRAFICA As Byte = 0
    Public VP_TIPO_GRAFICO As String
    Private VM_ID_DOCUMENTO As String
#End Region

#Region "FUNCIONES_FM"
    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VM_ID_DOCUMENTO, False)

        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True

        'If TB_K_PARAMETRO_SUCURSAL_D0M4.Text <> "" Then
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_PARAMETRO_SUCURSAL_D0M4, False)
        'PP_NUEVO = False
        'End If
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_YYYY, False)
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_V01_VALOR, False)
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_V02_VALOR, False)
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_P01_VALOR, False)
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_P02_VALOR, False)

        Return VP_PARAMETROS

    End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "D_PARAMETRO_SUCURSAL_D0M4")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        Dim VP_PARAMETROS As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_YYYY")
        Dim VP_ID2 As String = ""
        VP_ID2 = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_UNIDAD_OPERATIVA")
        Dim VP_ID3 As String = ""
        VP_ID3 = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_TEMPORADA")
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_ID, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_ID2, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_ID3, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean

        Codigo_FI.PG_FI_FIELDS_VALIDATE(GB_GRAFICA, VP_VALIDACION, PP_MENSAJE_VALIDACION)

        'Codigo_CTRL.PG_TB_INTEGER_VALIDATE(PP_MENSAJE_VALIDACION, TB_O_DOCUMENTO_D0M4)


        VP_VALIDACION = (PP_MENSAJE_VALIDACION = "")

        Return VP_VALIDACION
    End Function

#End Region

#Region "SUB_PM_INIT"

    Public Sub PM_FO_SHOW(ByRef PP_NOMBRE_TABLA As String, ByVal PP_ID_BASE_DE_DATOS As String, ByVal PP_ID_DOCUMENTO_D0M4 As Integer)
        VM_NOMBRE_TABLA = PP_NOMBRE_TABLA
        VM_ID_BASE_DE_DATOS = PP_ID_BASE_DE_DATOS
        VM_ID_DOCUMENTO = PP_ID_DOCUMENTO_D0M4
        PM_FO_INIT(Me)
        PM_FI_LOAD(VM_ID_DOCUMENTO)
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
        PM_GRAFICA_LOAD(Me, CHART, GB_TIPO_GRAFICA)
        Me.Show()
    End Sub

    Private Sub PM_GRAFICA_LOAD(ByRef PP_FORMA As Object, ByRef PP_GRAFICO As Chart, ByRef PP_GROUPBOX As GroupBox)

        PP_GRAFICO.Refresh()
        PP_GROUPBOX.Enabled = True
        VP_TIPO_GRAFICO = GB_TIPO_GRAFICA_SELECCIONADO(PP_GROUPBOX)
        PM_BT_GRAFICAR_CLICK(Me, PP_GRAFICO, VP_TIPO_GRAFICO, VM_ID_DOCUMENTO)
        '  TI_RELOJ.Enabled = False
    End Sub

    Public Sub PM_CB_INIT()
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_UNIDAD_OPERATIVA, "UNIDAD_OPERATIVA")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_YYYY, "TIEMPO_YYYY")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_TEMPORADA, "TEMPORADA")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_TIPO_CALCULO, "TIPO_CALCULO")
    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
    End Sub

    Private Sub PM_FO_INIT(ByRef PP_FORMA As Object)
        Codigo_FRM.PG_FRM_INIT(VM_ID_BASE_DE_DATOS, PP_FORMA)
    End Sub

#End Region

#Region "SUBS_PM"

    ''' <summary>
    ''' 'FUNCION QUE CARGARA LA PARTE DE LA FICHA
    ''' </summary>
    Public Sub PM_FI_LOAD(ByVal PP_ID As String)
        Codigo_FI.FG_FI_LOAD_X_ID(VM_ID_BASE_DE_DATOS, Me, GB_FICHA_DOCUMENTO, PP_ID)
        Codigo_FI.FG_FI_LOAD_X_ID(VM_ID_BASE_DE_DATOS, Me, GB_FICHA_POB, PP_ID)


        'CB_UNIDAD_OPERATIVA.Select()
    End Sub
    Public Sub PM_BT_GRAFICAR_CLICK(ByRef PP_FORMA As Object, ByRef PP_CHART As System.Windows.Forms.DataVisualization.Charting.Chart, ByRef PP_TIPO_GRAFICO As String, PP_ID As String)
        Codigo_ABC.PG_BT_GRAFICAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_CHART, PP_TIPO_GRAFICO, PP_ID)

    End Sub
    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)

        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_DOCUMENTO_D0M4, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_UNIDAD_OPERATIVA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("TIEMPO_YYYY", CB_YYYY, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_D_DOCUMENTO_D0M4, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_PARAMETRO_POB, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_D_PARAMETRO_POB, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_TEMPORADA, PP_ROW)

        Dim VP_HISTORICO_CONSIDERABLE As String = ""
        Codigo_CTRL.PG_CO_DATA_LOAD("HISTORICO_CONSIDERABLE", VP_HISTORICO_CONSIDERABLE, PP_ROW)
        CB_HISTORICO_CONSIDERABLE.SelectedValue = VP_HISTORICO_CONSIDERABLE

        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_INCREMENTO_COMPROMISO_KG, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_TIPO_CALCULO, PP_ROW)
        Me.Refresh()

    End Sub

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION, SOLO_LECTURA, VISIBLE, FROZEN
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_DOCUMENTO_D0M4", "#DOC", GetType(String), 0, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_DATO_D0M4", "#DAT", GetType(String), 0, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ZONA_UO", "Zona", GetType(String), 35, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_UNIDAD_OPERATIVA", "Unidad Operativa", GetType(String), 100, 1, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_FORMATO_D0M4", "Tipo", GetType(String), 40, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_YYYY", "Año", GetType(String), 40, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "L_BOLD", "L_BOLD", GetType(String), 35, 2, 0, 0, 0, 0) '****
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "L_ITALICA", "L_ITALICA", GetType(String), 35, 2, 0, 0, 0, 0) '***
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "N_INDENTAR", "N_INDENTAR", GetType(String), 35, 2, 0, 0, 0, 0) '***
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_ALIGN", "K_ALIGN", GetType(String), 35, 2, 0, 0, 0, 0) '****
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_DATO_D0M4", "Dato", GetType(String), 180, 1, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_UNIDAD_DATO_D0M4", "Uni", GetType(String), 35, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "L_VISIBLE", "L_VISIBLE", GetType(String), 100, 1, 0, 0, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "L_EDITABLE", "L_EDITABLE", GetType(String), 0, 1, 0, 0, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "VALOR_ACUMULADO", "Acumulado", GetType(String), 100, 3, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M00_VALOR", "Mes 0", GetType(String), 100, 3, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M01_VALOR", "Mes 1", GetType(String), 100, 3, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M02_VALOR", "Mes 2", GetType(String), 100, 3, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M03_VALOR", "Mes 3", GetType(String), 100, 3, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M04_VALOR", "Mes 4", GetType(String), 100, 3, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M05_VALOR", "Mes 5", GetType(String), 100, 3, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "M06_VALOR", "Mes 6", GetType(String), 100, 3, 1, 1, 0, 0)


        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "Modificado", "Modificado", GetType(String), 100, 3, 1, 0, 0, 0)
    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_DOCUMENTO_D0M4")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_DATO_D0M4")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ZONA_UO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_FORMATO_D0M4")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_YYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "L_BOLD") '**
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "L_ITALICA") '**
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "N_INDENTAR") '**
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_ALIGN") '**
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_DATO_D0M4")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_UNIDAD_DATO_D0M4")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "L_VISIBLE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "L_EDITABLE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "VALOR_ACUMULADO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M00_VALOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M01_VALOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M02_VALOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M03_VALOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M04_VALOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M05_VALOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "M06_VALOR")


        Codigo_LI.PG_LI_CELL_ZERO_FILL(PP_LISTADO, VP_ROW)

        ' Codigo_LI.PG_LI_ROW_EDIT(PP_LISTADO, "L_EDITABLE", VP_ROW)

        'Codigo_LI.PG_LI_CELL_FONT_PROPERTIES(PP_LISTADO.Rows(VP_ROW), "D_UNIDAD_OPERATIVA")

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

    'Private Sub PM_BT_EDITAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
    '    Codigo_ABC.PG_BT_EDITAR_CLICK(PP_FORMA, PP_LISTADO)
    'End Sub

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

    Public Sub PM_MODO_AUXILIAR()

    End Sub

#End Region

#Region "EVENTOS"

    Private Sub Catalogo_T1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT(Me)
    End Sub

    Private Sub BT_CANCELAR_Click(sender As Object, e As EventArgs)
        PM_BT_CANCELAR_CLICK(Me)
    End Sub

    Private Sub BT_SALIR_Click(sender As Object, e As EventArgs)
        PM_BT_SALIR_CLICK(Me)
    End Sub
    Private Sub BT_GUARDAR_Click(sender As Object, e As EventArgs)
        PM_BT_GUARDAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Function GB_TIPO_GRAFICA_SELECCIONADO(ByVal PP_GROUPBOX As GroupBox) As String
        Dim VP_TIPO_GRAFICA As String = "Barras"
        Dim VP_RADIOBUTTONS As New Collection
        PG_CONTROLS_CHILDRENS_GET(PP_GROUPBOX, GetType(RadioButton), VP_RADIOBUTTONS)
        For Each VP_CONTROL As RadioButton In VP_RADIOBUTTONS
            If VP_CONTROL.Checked Then
                VP_TIPO_GRAFICA = VP_CONTROL.Text
            End If
        Next
        Return VP_TIPO_GRAFICA

    End Function



    Private Sub LI_LISTADO_DoubleClick(sender As Object, e As EventArgs) Handles LI_LISTADO.DoubleClick

        CHART.Refresh()
        Codigo_LI.PG_LI_DOUBLE_CLICK(Me, LI_LISTADO)
        GB_GRAFICA.Enabled = True
        GB_TIPO_GRAFICA.Enabled = True
        VP_TIPO_GRAFICO = GB_TIPO_GRAFICA_SELECCIONADO(GB_TIPO_GRAFICA)
        PM_BT_GRAFICAR_CLICK(Me, CHART, VP_TIPO_GRAFICO, VM_ID_ROW)
        '  TI_RELOJ.Enabled = False
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


    'Private Sub BT_EXPORTAR_EXCEL_Click_1(sender As Object, e As EventArgs) Handles BT_EXPORTAR_EXCEL.Click
    '    PM_BT_EXPORTAR_EXCEL_CLICK(LI_LISTADO)
    'End Sub


    Private Sub BT_SALIR_Click_1(sender As Object, e As EventArgs) Handles BT_SALIR.Click
        PM_BT_SALIR_CLICK(Me)
    End Sub

    Private Sub RB_TIPO_GRAFICA_Click(sender As Object, e As EventArgs) Handles RB_PUNTOS.Click, RB_PAY.Click, RB_LINEAS.Click, RB_COLUMNA.Click, RB_CIRCULAR.Click, RB_BARRAS.Click, RB_AREA.Click
        CHART.Refresh()
        VP_TIPO_GRAFICO = GB_TIPO_GRAFICA_SELECCIONADO(GB_TIPO_GRAFICA)
        PM_BT_GRAFICAR_CLICK(Me, CHART, VP_TIPO_GRAFICO, VM_ID_ROW)
    End Sub


#End Region
End Class