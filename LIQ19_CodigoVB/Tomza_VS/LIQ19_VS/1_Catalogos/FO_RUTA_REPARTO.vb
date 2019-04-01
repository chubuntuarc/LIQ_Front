Public Class FO_RUTA_REPARTO

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESTATUS_RUTA_REPARTO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIPO_RUTA_REPARTO, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_RUTA_REPARTO.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_RUTA_REPARTO, False)
            PP_NUEVO = False
        End If

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_D_RUTA_REPARTO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_C_RUTA_REPARTO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_S_RUTA_REPARTO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ESTATUS_RUTA_REPARTO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_TIPO_RUTA_REPARTO, False)

        Return VP_PARAMETROS

    End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "D_RUTA_REPARTO")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_RUTA_REPARTO")
        Return VP_ID
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean
        Codigo_FI.PG_FI_FIELDS_VALIDATE(GB_FICHA, VP_VALIDACION, PP_MENSAJE_VALIDACION)

        'Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_MODELO)

        VP_VALIDACION = (PP_MENSAJE_VALIDACION = "")
        Return VP_VALIDACION
    End Function

#End Region

#Region "SUB_PM_INIT"

    Public Sub PM_FO_SHOW(ByRef PP_NOMBRE_TABLA As String, ByVal PP_ID_BASE_DE_DATOS As String)
        VM_NOMBRE_TABLA = "RUTA_REPARTO"
        VM_ID_BASE_DE_DATOS = PP_ID_BASE_DE_DATOS
        Me.Show()
    End Sub

    Public Sub PM_CB_INIT()
        Codigo_FI.PG_FI_CONTROL_DATA_SETUP(VM_ID_BASE_DE_DATOS, Me)
        Codigo_TOMZA.PG_CB_UNIDAD_OPERATIVA_x_AccesoLoad(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_ESTATUS_RUTA_REPARTO, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_TIPO_RUTA_REPARTO, "")

        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_UNIDAD_OPERATIVA, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ESTATUS_RUTA_REPARTO, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_TIPO_RUTA_REPARTO, "")

    End Sub

    Public Sub PM_LI_INIT()
        'JAR || CREAR LISTADOS SENCILLOS../
        ' Dim VP_PARAMETROS_DETALLE As String = "''," + CB_LI_ESTATUS_PUNTO_VENTA.SelectedValue + ",2," + CB_LI_UNIDAD_OPERATIVA
        Dim VP_PARAMETROS_DETALLE As String = "'',-1,-1,-1"
        Dim VP_DATATABLE As New DataTable
        Codigo_ABC.PG_BT_EJECUTAR_ACCION_TABLA_CLICK(VM_ID_BASE_DE_DATOS, Me, "PG_LI_RUTA_REPARTO", VP_PARAMETROS_DETALLE, VP_DATATABLE)
        Dim VM_CAMPOS As New ArrayList From {"K_RUTA_REPARTO", "D_RUTA_REPARTO", "D_ESTATUS_RUTA_REPARTO", "S_RUTA_REPARTO", "C_RUTA_REPARTO", "D_UNIDAD_OPERATIVA", "D_TIPO_RUTA_REPARTO"}
        Dim VM_TITULOS As New ArrayList From {"RUTA", "Descripcion", "Estatus", "Siglas", "Comentario", "Unidad Operativa", "Tipo Unidad"}
        '///  K--ID | D--DESCRIPCION | S--SIGLAS | ESTATUS | GENERAL | CENTRADO | LECTURA | SERIE
        Dim VM_TIPOS As New ArrayList From {"K", "D", "ESTATUS", "S", "IZQUIERDA LARGO", "CENTRADO LARGO", "CENTRADO LARGO"}

        LIQ19_Codigo.NUEVO_LISTADO(VP_DATATABLE, LI_LISTADO, VM_CAMPOS, VM_TITULOS, VM_TIPOS)
    End Sub

    Public Sub PM_TB_INIT()
        LIQ19_Codigo.PG_TB_INIT(TB_D_RUTA_REPARTO, 3)
        LIQ19_Codigo.PG_TB_INIT(TB_S_RUTA_REPARTO, 4)
        LIQ19_Codigo.PG_TB_INIT(TB_C_RUTA_REPARTO, 3)
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
        Codigo_FI.FG_FI_LOAD_X_ID(VM_ID_BASE_DE_DATOS, Me, PP_ID)
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)

        If VM_IN_MODO_OPERACION <> MOP_Modo_Operacion.MOP4_Clon Then
            Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_RUTA_REPARTO, PP_ROW)
            Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)
        End If

        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_D_RUTA_REPARTO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_C_RUTA_REPARTO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_S_RUTA_REPARTO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_UNIDAD_OPERATIVA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ESTATUS_RUTA_REPARTO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_TIPO_RUTA_REPARTO, PP_ROW)


    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_RUTA_REPARTO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_RUTA_REPARTO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_ESTATUS_RUTA_REPARTO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_RUTA_REPARTO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "C_RUTA_REPARTO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_TIPO_RUTA_REPARTO")

        Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)
    End Sub

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_BUSCAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
    End Sub

    Private Sub PM_BT_AGREGAR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_AGREGAR_CLICK(PP_FORMA)
        PM_TB_INIT()
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

    Private Sub PM_BT_CLONAR_CLICK(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_CLONAR_CLICK(PP_FORMA, PP_LISTADO)
    End Sub

#End Region

#Region "EVENTOS"

    Private Sub BT_AGREGAR_Click(sender As Object, e As EventArgs) Handles BT_AGREGAR.Click
        PM_BT_AGREGAR_CLICK(Me)
    End Sub

    Private Sub BT_BUSCAR_Click(sender As Object, e As EventArgs) Handles BT_LI_BUSCAR.Click
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub Catalogo_T1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT(Me)
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
            Codigo_LI.PG_LI_DOUBLE_CLICK(Me, LI_LISTADO)
        End If
    End Sub

    Private Sub BT_CLONAR_Click(sender As Object, e As EventArgs) Handles BT_CLONAR.Click
        PM_BT_CLONAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub CB_LI_UNIDAD_OPERATIVA_DropDown(sender As Object, e As EventArgs) Handles CB_LI_UNIDAD_OPERATIVA.DropDown
        Codigo_LI.PG_LI_CLEAR(LI_LISTADO)
    End Sub

    Private Sub CB_LI_ESTATUS_RUTA_REPARTO_DropDown(sender As Object, e As EventArgs) Handles CB_LI_ESTATUS_RUTA_REPARTO.DropDown
        Codigo_LI.PG_LI_CLEAR(LI_LISTADO)
    End Sub

    Private Sub CB_LI_TIPO_RUTA_REPARTO_DropDown(sender As Object, e As EventArgs) Handles CB_LI_TIPO_RUTA_REPARTO.DropDown
        Codigo_LI.PG_LI_CLEAR(LI_LISTADO)
    End Sub

#End Region

End Class