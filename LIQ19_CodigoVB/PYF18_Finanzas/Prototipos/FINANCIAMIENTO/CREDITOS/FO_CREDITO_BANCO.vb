Public Class FO_CREDITO_BANCO
#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_RAZON_SOCIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_RAZON_SOCIAL2, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_GRUPO_CREDITO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_MOTIVO_CREDITO_BANCARIO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIPO_CREDITO_BANCARIO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_BANCO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_MONEDA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESTATUS_CREDITO_BANCARIO, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_CREDITO_BANCARIO.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_CREDITO_BANCARIO, False)
            PP_NUEVO = False

        End If
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_D_CREDITO_BANCARIO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_C_CREDITO_BANCARIO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_RAZON_SOCIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_RAZON_SOCIAL2, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_GRUPO_CREDITO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_MOTIVO_CREDITO_BANCARIO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_JUSTIFICACION, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_TIPO_CREDITO_BANCARIO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_BANCO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_MONEDA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_CUENTA_BANCO_PAGO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_NUMERO_CREDITO, True)
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
        Codigo_FI.PG_FI_FIELDS_VALIDATE(GB_FICHA, VP_VALIDACION, PP_MENSAJE_VALIDACION)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_MONTO_PRESTAMO)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_TASA_INTERES_ANUAL)
        Codigo_CTRL.PG_TB_INTEGER_VALIDATE(PP_MENSAJE_VALIDACION, TB_CANTIDAD_PERIODOS)
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
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_BANCO, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_BANCO, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_CUENTA_BANCO_PAGO, "CUENTA_BANCO")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_ESTATUS_CREDITO_BANCARIO, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_ESTATUS_CREDITO_BANCARIO, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_GRUPO_CREDITO, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_GRUPO_CREDITO, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_MONEDA, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_MONEDA, "")
        Codigo_CB.PG_CB_RAZON_SOCIAL_Load(VM_ID_BASE_DE_DATOS, Me, CB_RAZON_SOCIAL, 1, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_RAZON_SOCIAL_Load(VM_ID_BASE_DE_DATOS, Me, CB_RAZON_SOCIAL2, 1, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_RAZON_SOCIAL_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_RAZON_SOCIAL, 1, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_RAZON_SOCIAL_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_RAZON_SOCIAL2, 1, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_TIPO_CALCULO_CREDITO, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_TIPO_CREDITO_BANCARIO, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_TIPO_CREDITO_BANCARIO, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_MOTIVO_CREDITO_BANCARIO, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_MOTIVO_CREDITO_BANCARIO, "")

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
        TB_D_CREDITO_BANCARIO.Select()
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)

        If VM_IN_MODO_OPERACION <> Modo_Operacion.Clon Then
            Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_CREDITO_BANCARIO, PP_ROW)
            Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)
        End If

        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_D_CREDITO_BANCARIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_C_CREDITO_BANCARIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_CREDITO_BANCARIO, PP_ROW)

        Codigo_CTRL.PG_CO_DATA_LOAD("", DT_F_AUTORIZACION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", DT_F_INICIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CANTIDAD_PERIODOS, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("TASA_INTERES_ANUAL_0_100", TB_TASA_INTERES_ANUAL, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_MONTO_PRESTAMO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_TIPO_CALCULO_CREDITO, PP_ROW)

        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_MOTIVO_CREDITO_BANCARIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_NUMERO_CREDITO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_JUSTIFICACION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_CUENTA_BANCO_PAGO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ESTATUS_CREDITO_BANCARIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_MONEDA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_BANCO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_TIPO_CREDITO_BANCARIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_GRUPO_CREDITO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("K_RAZON_SOCIAL_ACREDITADA", CB_RAZON_SOCIAL, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("K_RAZON_SOCIAL_BENEFICIADA", CB_RAZON_SOCIAL2, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_USUARIO_CAMBIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_USUARIO_ALTA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_C_CREDITO_BANCARIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_D_CREDITO_BANCARIO, PP_ROW)

    End Sub

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Try
            Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 16)
            'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, 
            '            ANCHO_CELDA, ALINEACION, SOLO_LECTURA, Visible, FROZEN, FORMAT
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_CREDITO_BANCARIO", "#CRE", GetType(Integer), 60, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_CREDITO_BANCARIO", "Descripción", GetType(String), 300, 1, 0, 1, 1, 0, Nothing, Nothing, 1)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_ACREDITADA", "Acreditada", GetType(String), 150, 1, 0, 1, 0, 0, Color.DarkOrange, Nothing, 1)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_BENEFICIADA", "Beneficiada", GetType(String), 150, 1, 0, 1, 0, 0, Color.DarkOrange, Nothing, 1)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ESTATUS_CREDITO_BANCARIO", "Estatus", GetType(String), 60, 2, 0, 1, 0, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_GRUPO_CREDITO", "Grupo", GetType(String), 60, 2, 0, 1, 0, 0)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_MOTIVO_CREDITO_BANCARIO", "Motivo", GetType(String), 60, 2, 0, 1, 0, 0)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_TIPO_CREDITO_BANCARIO", "Tipo", GetType(String), 60, 2, 0, 1, 0, 0)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_BANCO", "Banco", GetType(String), 60, 2, 0, 1, 0, 0)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_MONEDA", "Moneda", GetType(String), 60, 2, 0, 1, 0, 0)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_CUENTA_BANCO", "Siglas Cuenta", GetType(String), 80, 2, 0, 1, 0, 0)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "CUENTA", "Cuenta", GetType(String), 80, 2, 0, 1, 0, 0)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "CLABE", "CLABE", GetType(String), 80, 2, 0, 1, 0, 0)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_TIPO_CALCULO_CREDITO", "Tipo de Cálculo", GetType(String), 60, 2, 0, 1, 0, 0)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "NUMERO_CREDITO", "Número de Crédito", GetType(String), 80, 2, 0, 1, 0, 0)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "MONTO_PRESTAMO", "Monto Préstamo", GetType(Decimal), 100, 3, 0, 1, 0, 2, Color.Black, Color.LightYellow, 1)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "TASA_INTERES_ANUAL_0_100", "Tasa", GetType(Decimal), 60, 2, 0, 1, 0, 3, Color.Black, Color.LightYellow, 1)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "CANTIDAD_PERIODOS", "Periodos", GetType(Integer), 80, 2, 0, 1, 0, 0, Color.Black, Color.LightYellow, 1)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "C_CREDITO_BANCARIO", "Comentarios", GetType(String), 250, 1, 0, 1, 0, 0)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_INICIO", "Fecha de Inicio", GetType(Date), 80, 2, 0, 1, 0, 0)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_AUTORIZACION", "Fecha Autorizacion", GetType(Date), 80, 2, 0, 1, 0, 0)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_USUARIO_CAMBIO", "Ultimo Cambio", GetType(String), 80, 2, 0, 1, 0, 0)
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_CAMBIO", "Modificación", GetType(Date), 80, 2, 0, 1, 0, 0)
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PM_LI_FORMAT")
        End Try

    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        Try
            VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_CREDITO_BANCARIO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_CREDITO_BANCARIO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_ACREDITADA")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_BENEFICIADA")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ESTATUS_CREDITO_BANCARIO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_GRUPO_CREDITO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_MOTIVO_CREDITO_BANCARIO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_TIPO_CREDITO_BANCARIO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_BANCO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_MONEDA")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_CUENTA_BANCO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CUENTA")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CLABE")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_TIPO_CALCULO_CREDITO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "NUMERO_CREDITO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MONTO_PRESTAMO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_PORCENTAJE(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "TASA_INTERES_ANUAL_0_100")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CANTIDAD_PERIODOS")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "C_CREDITO_BANCARIO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_FECHA(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_INICIO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_FECHA(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_AUTORIZACION")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_USUARIO_CAMBIO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_FECHA(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_CAMBIO")
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PM_LI_ROW_WRITE")

        End Try

    End Sub

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_BUSCAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
    End Sub

    Private Sub PM_BT_AGREGAR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_AGREGAR_CLICK(PP_FORMA)
    End Sub

    Public Sub PG_FRM_CONFIG()
        BT_VER_TABLA_AMORTIZACION.Enabled = (VM_IN_MODO_OPERACION = Modo_Operacion.Listado)
        BT_ESTADO_CUENTA.Enabled = (VM_IN_MODO_OPERACION = Modo_Operacion.Listado)
        BT_EXPORTAR_EXCEL.Enabled = (VM_IN_MODO_OPERACION = Modo_Operacion.Listado)
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

    Public Sub PM_BT_VER_TABLA_AMORTIZACION_CLICK(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)

        Dim VP_ID_ROW As Integer = 0
        VP_ID_ROW = Codigo_LI.FG_LI_ROW_CURRENT(PP_LISTADO)

        Dim VP_ID As Integer = 0
        VP_ID = FM_ID_SELECCIONADO(PP_LISTADO, VP_ID_ROW)

        Dim VP_CREDITO_BANCO_AMORTIZACION As New FO_CREDITO_BANCO_AMORTIZACION("CREDITO_BANCARIO", VG_ID_DB, VP_ID)
        Codigo_FRM.PG_FRM_ABRIR(PP_FORMA, VP_CREDITO_BANCO_AMORTIZACION, "CREDITO_BANCARIO", "Tabla de Simulación de Amortizaciones por Crédito Bancario", VG_ID_DB, False, True)


    End Sub

    Private Sub PM_BT_ESTADO_CUENTA_CLICK(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)

        Dim VP_ID_CREDITO As String

        Try
            If Codigo_LI.FG_LI_ROW_SELECTED(PP_LISTADO) Then
                Dim VP_ROW As Integer
                VP_ROW = Codigo_LI.FG_LI_ROW_CURRENT(PP_LISTADO)

                'VP_ID_AMORTIZACION = PP_FORMA.FM_ID_SELECCIONADO(PP_LISTADO, VP_ROW)
                VP_ID_CREDITO = PP_FORMA.FM_ID_SELECCIONADO(PP_LISTADO, VP_ROW)

                Dim VP_ESTADO_CUENTA As New FO_CREDITO_BANCO_ESTADO_CUENTA
                VP_ESTADO_CUENTA.VM_K_CREDITO_BANCARIO = VP_ID_CREDITO
                VP_ESTADO_CUENTA.VM_ID_BASE_DE_DATOS = VG_ID_DB
                'VP_ESTADO_CUENTA.PM_FO_SHOW("CREDITO_BANCARIO", VG_ID_DB, VP_ID_CREDITO)
                Codigo_FRM.PG_FRM_ABRIR(PP_FORMA, VP_ESTADO_CUENTA, "CREDITO_BANCARIO", "Estado de Cuenta de Crédito Bancario", VG_ID_DB, False, True)
            End If

        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PM_BT_ESTADO_CUENTA")
        End Try

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

    Private Sub BT_VER_TABLA_AMORTIZACION_Click(sender As Object, e As EventArgs) Handles BT_VER_TABLA_AMORTIZACION.Click
        PM_BT_VER_TABLA_AMORTIZACION_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub BT_ESTADO_CUENTA_Click(sender As Object, e As EventArgs) Handles BT_ESTADO_CUENTA.Click
        PM_BT_ESTADO_CUENTA_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub LI_LISTADO_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LI_LISTADO.CellDoubleClick
        If e.RowIndex <> -1 Then
            Codigo_LI.PG_LI_DOUBLE_CLICK(Me, LI_LISTADO)
        End If
    End Sub

    Private Sub BT_CLONAR_Click(sender As Object, e As EventArgs) Handles BT_CLONAR.Click
        PM_BT_CLONAR_CLICK(Me, LI_LISTADO)
    End Sub

#End Region

End Class