Public Class FO_CREDITO_BANCO_ESTADO
#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_K_AMORTIZACION As Integer = 0

    Public Sub New(vM_NOMBRE_TABLA As String, vM_ID_BASE_DE_DATOS As Integer, vM_K_AMORTIZACION As Integer)
        Me.VM_NOMBRE_TABLA = vM_NOMBRE_TABLA
        Me.VM_ID_BASE_DE_DATOS = vM_ID_BASE_DE_DATOS
        Me.VM_K_AMORTIZACION = vM_K_AMORTIZACION
        InitializeComponent()
    End Sub
    'Public VM_K_CREDITO_BANCARIO As Integer = 0

#End Region

#Region "FUNCIONES_FM"


    Public Function FM_FI_SQL()
        Dim VP_PARAMETROS = ""

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VM_K_AMORTIZACION.ToString(), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PAGO_INTERESES, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PAGO_COMISIONES, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PAGO_AMORTIZACION, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_COMISIONES_BANCO, False)

        Return VP_PARAMETROS

    End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "D_CREDITO_BANCARIO")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_CREDITO_BANCARIO")
        Return VP_ID
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean
        Codigo_FI.PG_FI_FIELDS_VALIDATE(GB_DATOS_CREDITO_BANCARIO, VP_VALIDACION, PP_MENSAJE_VALIDACION)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_COMISIONES_BANCO)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_PAGO_AMORTIZACION)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_PAGO_INTERESES)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_PAGO_COMISIONES)
        VP_VALIDACION = (PP_MENSAJE_VALIDACION = "")
        Return VP_VALIDACION
    End Function


#End Region

#Region "SUB_PM_INIT"

    Public Sub PM_FO_SHOW(ByRef PP_NOMBRE_TABLA As String, ByVal PP_ID_BASE_DE_DATOS As String, ByVal PP_ID_AMORTIZACION As Integer)
        VM_NOMBRE_TABLA = PP_NOMBRE_TABLA
        VM_ID_BASE_DE_DATOS = PP_ID_BASE_DE_DATOS
        'VM_K_CREDITO_BANCARIO = PP_ID_AMORTIZACION
        VM_K_AMORTIZACION = PP_ID_AMORTIZACION

        Me.Show()
    End Sub

    Public Sub PM_CB_INIT()


    End Sub


    Public Sub PM_TB_INIT()
        Codigo_CTRL.PG_TB_INIT(TB_COMISIONES_BANCO, 1)
        Codigo_CTRL.PG_TB_INIT(TB_PAGO_AMORTIZACION, 1)
        Codigo_CTRL.PG_TB_INIT(TB_PAGO_COMISIONES, 1)
        Codigo_CTRL.PG_TB_INIT(TB_PAGO_INTERESES, 1)
    End Sub

    Public Sub PM_LI_INIT()

    End Sub

    Private Sub PM_FO_INIT(ByRef PP_FORMA As Object)
        StartPosition = FormStartPosition.CenterScreen
        PM_TB_INIT()
        PM_FI_LOAD(VM_K_AMORTIZACION)

        'PM_FO_ACTIVAR(PP_FORMA)
    End Sub


#End Region

#Region "SUBS_PM"

    ''' <summary>
    ''' 'FUNCION QUE CARGARA LA PARTE DE LA FICHA
    ''' </summary>
    Public Sub PM_FI_LOAD(ByVal PP_ID As String)
        Codigo_FI.FG_FI_LOAD_X_ID(VM_ID_BASE_DE_DATOS, Me, PP_ID)
        'VM_NOMBRE_TABLA = "TABLA_AMORTIZACION"
        'TB_D_CREDITO_BANCARIO.Select()
        'PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_N_PERIODO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PAGO_INTERESES, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PAGO_COMISIONES, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PAGO_AMORTIZACION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_COMISIONES_BANCO, PP_ROW)

    End Sub



    Private Sub PM_BT_CANCELAR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_CANCELAR_CLICK(PP_FORMA)
    End Sub

    Private Sub PM_BT_SALIR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_SALIR_CLICK(PP_FORMA)
    End Sub

    Public Sub PM_BT_GUARDAR_CLICK(ByVal PP_ID_BASE_DE_DATOS As Integer, ByRef PP_FORMA As Object)

        PM_LI_SAVE(PP_ID_BASE_DE_DATOS, PP_FORMA)
        Close()
    End Sub


    Public Sub PM_LI_SAVE(ByVal PP_ID_BASE_DE_DATOS As Integer, ByRef PP_FORMA As Object)

        Dim VP_PARAMETROS As String
        VP_PARAMETROS = PP_FORMA.FM_FI_SQL()

        Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

        Dim VP_SP As String
        VP_SP = Codigo_CON.FG_SQL_UPDATE(PP_FORMA)


        Dim VP_EXITO As Boolean = False
        VP_EXITO = Codigo_CON.FG_SQL_EJECUTAR_OPERACION(PP_FORMA, PP_ID_BASE_DE_DATOS, VP_SP, VP_PARAMETROS)



    End Sub

    Public Sub PM_MODO_AUXILIAR()

    End Sub

#End Region

#Region "EVENTOS"

    Private Sub BT_CANCELAR_Click(sender As Object, e As EventArgs) Handles BT_CANCELAR.Click
        PM_BT_CANCELAR_CLICK(Me)
    End Sub

    Private Sub BT_GUARDAR_Click(sender As Object, e As EventArgs) Handles BT_GUARDAR.Click

        PM_BT_GUARDAR_CLICK(VM_ID_BASE_DE_DATOS, Me)

    End Sub

    Private Sub FO_CREDITO_BANCO_ESTADO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT(Me)
    End Sub

#End Region
End Class