Imports System.Windows.Forms.DataVisualization.Charting
Public Class FO_PERFORMANCE_N3_X_TEMP

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_ID_ROW As String = ""
    Public VM_VISIBILIDAD_GRAFICA As Byte = 0
    Public VP_TIPO_GRAFICO As String
#End Region

#Region "FUNCIONES_FM"
    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIEMPO_YYYY, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ZONA_UO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TEMPORADA, False)

        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True

        'If TB_K_PARAMETRO_SUCURSAL_D0M4.Text <> "" Then
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_PARAMETRO_SUCURSAL_D0M4, False)
        'PP_NUEVO = False
        'End If
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_YYYY, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_V01_VALOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_V02_VALOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_P01_VALOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_P02_VALOR, False)

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
        Me.Show()
    End Sub

    Public Sub PM_CB_INIT()
        Codigo_FI.PG_FI_CONTROL_DATA_SETUP(VM_ID_BASE_DE_DATOS, Me)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_ZONA_UO, "ZONA_UO")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_TIEMPO_YYYY, "TIEMPO_YYYY")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_UNIDAD_OPERATIVA, "UNIDAD_OPERATIVA")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_TEMPORADA, "TEMPORADA")
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
        Codigo_FI.FG_FI_LOAD_X_ID(VM_ID_BASE_DE_DATOS,  Me, PP_ID)

        'CB_UNIDAD_OPERATIVA.Select()
    End Sub
    Public Sub PM_BT_GRAFICAR_CLICK(ByRef PP_FORMA As Object, ByRef PP_CHART As System.Windows.Forms.DataVisualization.Charting.Chart, ByRef PP_TIPO_GRAFICO As String, PP_ID As String)
        Codigo_ABC.PG_BT_GRAFICAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_CHART, PP_TIPO_GRAFICO, PP_ID)

    End Sub
    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)

        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_YYYY, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XLS_UO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_XLS_UNIDAD_OPERATIVA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_VALOR_ACUMULADO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_V01_VALOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_V02_VALOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_P01_VALOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_P02_VALOR, PP_ROW)


    End Sub

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, 
        '            ANCHO_CELDA, ALINEACION, SOLO_LECTURA, Visible, FROZEN, FORMAT
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_YYYY", "AÑO", GetType(Integer), 80, 1, 1, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "XLS_UO", "XLS_UO", GetType(Integer), 80, 1, 1, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_UNIDAD_OPERATIVA", "UNIDAD OPERATIVA", GetType(Integer), 80, 1, 1, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_METRICA", "METRICA", GetType(Integer), 80, 1, 1, 1, 1, 0)

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_TEMPORADA", "K_TEMPORADA", GetType(Integer), 90, 1, 1, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_TEMPORADA", "TEMPORADA", GetType(String), 90, 1, 1, 1, 1, 0)


        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "VALOR_ACUMULADO", "ACUMULADO", GetType(Integer), 90, 1, 1, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "V00_VALOR", "PREVIO", GetType(Decimal), 100, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "V01_VALOR", "ENERO", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "V02_VALOR", "FEBRERO", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "P01_VALOR", "MARZO", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "P02_VALOR", "ABRIL", GetType(Decimal), 89, 1, 1, 1, 0, 0)

    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_YYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "XLS_UO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_METRICA")


        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_TEMPORADA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_TEMPORADA")


        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "VALOR_ACUMULADO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "V00_VALOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "V01_VALOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "V02_VALOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "P01_VALOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "P02_VALOR")
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

    Private Sub BT_BUSCAR_Click(sender As Object, e As EventArgs) Handles BT_LI_BUSCAR.Click
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
    End Sub

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

    Private Sub BT_EDITAR_Click(sender As Object, e As EventArgs) Handles BT_EDITAR.Click
        PM_BT_EDITAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub BT_ELIMINAR_Click(sender As Object, e As EventArgs) Handles BT_ELIMINAR.Click
        PM_BT_ELIMINAR_CLICK(Me, LI_LISTADO)
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
        GB_FICHA.Enabled = True
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


    Private Sub BT_EXPORTAR_EXCEL_Click_1(sender As Object, e As EventArgs) Handles BT_EXPORTAR_EXCEL.Click
        PM_BT_EXPORTAR_EXCEL_CLICK(LI_LISTADO)
    End Sub

    Private Sub BT_LISTADO_Click_1(sender As Object, e As EventArgs) Handles BT_LISTADO.Click
        PM_BT_LISTADO_CLICK(Me)
    End Sub

    Private Sub CB_LI_TIEMPO_YYYY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_LI_TIEMPO_YYYY.SelectedIndexChanged

    End Sub

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