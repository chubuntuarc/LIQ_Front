Public Class FO_CREDITO_BANCO_AMORTIZACION
#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_K_CREDITO_BANCARIO As Integer = 0

    Public VM_IN_MODO_OPERACION As Integer = 0

    Public Sub New(ByRef PP_NOMBRE_TABLA As String, ByVal PP_ID_BASE_DE_DATOS As String, ByVal PP_ID_CREDITO_BANCARIO As Integer)
        VM_NOMBRE_TABLA = PP_NOMBRE_TABLA
        VM_ID_BASE_DE_DATOS = PP_ID_BASE_DE_DATOS
        VM_K_CREDITO_BANCARIO = PP_ID_CREDITO_BANCARIO
        InitializeComponent()
        'Me.Show()
    End Sub

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VM_K_CREDITO_BANCARIO, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, 0, False)
        If TB_K_CREDITO_BANCARIO.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_CREDITO_BANCARIO, False)
            PP_NUEVO = False

        End If
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_TIPO_CALCULO_CREDITO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MONTO_PRESTAMO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_TASA_INTERES_ANUAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CANTIDAD_PERIODOS, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, DT_F_INICIO, True)

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
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_MONTO_PRESTAMO)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_TASA_INTERES_ANUAL)
        Codigo_CTRL.PG_TB_INTEGER_VALIDATE(PP_MENSAJE_VALIDACION, TB_CANTIDAD_PERIODOS)
        VP_VALIDACION = (PP_MENSAJE_VALIDACION = "")
        Return VP_VALIDACION
    End Function

#End Region

#Region "SUB_PM_INIT"

    Public Sub PM_FO_SHOW(ByRef PP_NOMBRE_TABLA As String, ByVal PP_ID_BASE_DE_DATOS As String, ByVal PP_ID_CREDITO_BANCARIO As Integer)
        VM_NOMBRE_TABLA = PP_NOMBRE_TABLA
        VM_ID_BASE_DE_DATOS = PP_ID_BASE_DE_DATOS
        VM_K_CREDITO_BANCARIO = PP_ID_CREDITO_BANCARIO

        'Me.Show()
    End Sub

    Public Sub PM_CB_INIT()
        Codigo_FI.PG_FI_CONTROL_DATA_SETUP(VM_ID_BASE_DE_DATOS, Me)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_GRUPO_CREDITO, "")
        Codigo_CB.PG_CB_RAZON_SOCIAL_Load(VM_ID_BASE_DE_DATOS, Me, CB_RAZON_SOCIAL_ACREDITADA, 1, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_RAZON_SOCIAL_Load(VM_ID_BASE_DE_DATOS, Me, CB_RAZON_SOCIAL_BENEFICIADA, 1, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_TIPO_CALCULO_CREDITO, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_TIPO_CREDITO_BANCARIO, "")

    End Sub

    Public Sub PM_TB_INIT()
        Codigo_CTRL.PG_TB_INIT(TB_MONTO_PRESTAMO, 1)
    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
    End Sub

    Public Sub PM_FO_INIT(ByRef PP_FORMA As Object)
        Codigo_FRM.PG_FRM_INIT(VM_ID_BASE_DE_DATOS, PP_FORMA)
        PM_FI_LOAD(VM_K_CREDITO_BANCARIO)
        PM_FO_ACTIVAR(PP_FORMA)
    End Sub

    Private Sub PM_FO_ACTIVAR(ByRef PP_FORMA As Object)
        VM_IN_MODO_OPERACION = Modo_Operacion.Edición
        Codigo_FRM.PG_FRM_CONFIG(Me)
        GB_DATOS_CREDITO_BANCARIO.Enabled = True
        GB_LISTADO.Enabled = True
        GB_DATOS_CREDITO_BANCARIO.Visible = True
        GB_LISTADO.Visible = True
        BT_SALIR.Enabled = True
    End Sub

#End Region

#Region "SUBS_PM"

    ''' <summary>
    ''' 'FUNCION QUE CARGARA LA PARTE DE LA FICHA
    ''' </summary>
    Public Sub PM_FI_LOAD(ByVal PP_ID As String)
        Codigo_FI.FG_FI_LOAD_X_ID(VM_ID_BASE_DE_DATOS,  Me, PP_ID)
        TB_D_CREDITO_BANCARIO.Select()

        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_CREDITO_BANCARIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_D_CREDITO_BANCARIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_C_CREDITO_BANCARIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_CREDITO_BANCARIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", DT_F_AUTORIZACION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", DT_F_INICIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CANTIDAD_PERIODOS, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("TASA_INTERES_ANUAL_0_100", TB_TASA_INTERES_ANUAL, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_MONTO_PRESTAMO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_TIPO_CALCULO_CREDITO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_NUMERO_CREDITO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_TIPO_CREDITO_BANCARIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_GRUPO_CREDITO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_RAZON_SOCIAL_ACREDITADA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_RAZON_SOCIAL_BENEFICIADA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_C_CREDITO_BANCARIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_D_CREDITO_BANCARIO, PP_ROW)
        Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)

    End Sub

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, 
        '            ANCHO_CELDA, ALINEACION, SOLO_LECTURA, Visible, FROZEN,FORMATO
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_TABLA_AMORTIZACION", "#AMR", GetType(Integer), 80, 2, 0, 1, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "N_PERIODO", "Período", GetType(Integer), 60, 2, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_PERIODO_INICIO", "Inicio de Período", GetType(Date), 80, 2, 0, 1, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_PERIODO_FIN", "Fin de Período", GetType(Date), 80, 2, 0, 1, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ESTATUS_TABLA_AMORTIZACION", "Estatus", GetType(String), 60, 2, 0, 1, 0, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "N_DIAS_PERIODO", "Dias por Período", GetType(Integer), 60, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "SALDO_INICIAL", "Saldo Inicial", GetType(Decimal), 100, 3, 0, 1, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "INTERESES_GENERADOS", "Intereses", GetType(Decimal), 100, 3, 0, 1, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "COMISIONES_BANCO", "Comisiones", GetType(Decimal), 100, 3, 0, 3, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "AMORTIZACION_PERIODO", "Amortización", GetType(Decimal), 100, 3, 0, 1, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "SALDO_ACTUALIZADO", "Saldo Actualizado", GetType(Decimal), 100, 3, 0, 1, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PAGO_INTERESES", "Pago Intereses", GetType(Decimal), 100, 3, 0, 1, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PAGO_COMISIONES", "Pago Comisiones", GetType(Decimal), 100, 3, 0, 1, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PAGO_AMORTIZACION", "Pago Amortización", GetType(Decimal), 100, 3, 0, 1, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PAGO_TOTAL", "Pago Total", GetType(Decimal), 100, 3, 0, 1, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "SALDO_FINAL", "Saldo Final", GetType(Decimal), 100, 3, 0, 1, 0, 2)
        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)

    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_ROW As Integer
        Dim VP_COLUMNA As Integer = 0

        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_TABLA_AMORTIZACION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "N_PERIODO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_FECHA(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_PERIODO_INICIO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_FECHA(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_PERIODO_FIN")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ESTATUS_TABLA_AMORTIZACION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "N_DIAS_PERIODO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "SALDO_INICIAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "INTERESES_GENERADOS")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "COMISIONES_BANCO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "AMORTIZACION_PERIODO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "SALDO_ACTUALIZADO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PAGO_INTERESES")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PAGO_COMISIONES")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PAGO_AMORTIZACION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PAGO_TOTAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "SALDO_FINAL")
        Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)

    End Sub

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        VM_NOMBRE_TABLA = "TABLA_AMORTIZACION_X_K_CREDITO_BANCARIO"
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

        Codigo_ABC.PG_BT_GUARDAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO, "PG_OP_CREDITO_AMORTIZACION_SIMULACION")
        VM_NOMBRE_TABLA = "CREDITO_BANCARIO"
        PM_FO_ACTIVAR(PP_FORMA)

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

    Private Sub BT_AGREGAR_Click(sender As Object, e As EventArgs)
        PM_BT_AGREGAR_CLICK(Me)
    End Sub

    Private Sub BT_BUSCAR_Click(sender As Object, e As EventArgs)
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub Catalogo_T1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT(Me)
    End Sub

    Private Sub BT_CANCELAR_Click(sender As Object, e As EventArgs)
        PM_BT_CANCELAR_CLICK(Me)
    End Sub

    Private Sub BT_SALIR_Click(sender As Object, e As EventArgs) Handles BT_SALIR.Click
        PM_BT_SALIR_CLICK(Me)
    End Sub

    Private Sub BT_GUARDAR_Click(sender As Object, e As EventArgs) Handles BT_GUARDAR.Click
        VM_NOMBRE_TABLA = "CREDITO_BANCO"
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

    Private Sub BT_LISTADO_Click(sender As Object, e As EventArgs)
        PM_BT_LISTADO_CLICK(Me)
    End Sub

    Private Sub BT_EXPORTAR_EXCEL_Click(sender As Object, e As EventArgs) Handles BT_EXPORTAR_EXCEL.Click
        PM_BT_EXPORTAR_EXCEL_CLICK(LI_LISTADO)
    End Sub



#End Region

End Class