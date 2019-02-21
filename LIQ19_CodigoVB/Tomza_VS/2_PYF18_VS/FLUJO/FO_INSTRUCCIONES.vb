Imports Microsoft.VisualBasic.PowerPacks.Printing
Imports System.Printing
Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6

Public Class FO_INSTRUCCIONES

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0

#End Region

#Region "VARIABLES LOCALES"

    Dim VL_HOY As Date = Now.ToString("dd/MM/yyyy")
    Dim VL_AYER As Date = Now.AddDays(-1).ToString("dd/MM/yyyy")
    Dim VM_ID_INSTRUCCION As Integer
    Dim VM_INS_IDS As ArrayList = New ArrayList()

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIPO_INSTRUCCION, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESTATUS_INSTRUCCION, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_CUENTA_BANCO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_F_INICIAL, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_F_FINAL, True)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_INSTRUCCION.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_INSTRUCCION, False)
            PP_NUEVO = False
        End If

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_TIPO_INSTRUCCION, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_FORMA_INSTRUCCION, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_CUENTA_BANCO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_F_INSTRUCCION, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_RAZON_SOCIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_PROVEEDOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_BENEFICIARIO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_REFERENCIA_1, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_REFERENCIA_2, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MONTO_INSTRUCCION, False)

        Return VP_PARAMETROS
    End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "REFERENCIA_1")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_INSTRUCCION")
        Return VP_ID
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean

        Codigo_FI.PG_FI_FIELDS_VALIDATE(GB_FICHA, VP_VALIDACION, PP_MENSAJE_VALIDACION)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_MONTO_INSTRUCCION)
        Codigo_CTRL.PG_TB_DATE_VALIDATE(PP_MENSAJE_VALIDACION, TB_F_INSTRUCCION)

        VP_VALIDACION = (PP_MENSAJE_VALIDACION = "")

        Return VP_VALIDACION
    End Function

    Public Function FM_VALIDAR_TAMANO_ARRAY(ByRef PP_ARRAY As ArrayList) As String
        Dim VP_RESPUESTA As String = ""
        Dim VP_TAM As Integer = PP_ARRAY.Count
        If VP_TAM = 0 Then
            VP_RESPUESTA = "Seleccione la o las Instrucciones para imprimirles la Póliza de Cheque."
        End If
        Return VP_RESPUESTA
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
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_TIPO_INSTRUCCION, "TIPO_INSTRUCCION")
        Codigo_CB.PG_CB_CUENTA_BANCO_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_CUENTA_BANCO, 1, New ComboBox, New ComboBox, New ComboBox, New ComboBox, New ComboBox, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_ESTATUS_INSTRUCCION, "ESTATUS_INSTRUCCION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_TIPO_INSTRUCCION, "TIPO_INSTRUCCION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_FORMA_INSTRUCCION, "FORMA_INSTRUCCION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ESTATUS_INSTRUCCION, "ESTATUS_INSTRUCCION")
        'Codigo_CB.PG_CB_CUENTA_BANCO_Load(VM_ID_BASE_DE_DATOS, Me, CB_CUENTA_BANCO, 0, CB_RAZON_SOCIAL, New ComboBox, New ComboBox, New ComboBox, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_CUENTA_BANCO_Load_X_ORGANIZACION(VM_ID_BASE_DE_DATOS, Me, CB_CUENTA_BANCO, 0, CB_RAZON_SOCIAL, CB_UNIDAD_OPERATIVA, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_PROVEEDOR, "PROVEEDOR")
        Codigo_CB.PG_CB_RAZON_SOCIAL_Load(VM_ID_BASE_DE_DATOS, Me, CB_RAZON_SOCIAL, 0, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_UNIDAD_OPERATIVA, 0, 1, New ComboBox, CB_RAZON_SOCIAL, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_USUARIO_ALTA, "USUARIO")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_USUARIO_CAMBIO, "USUARIO")
    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
    End Sub

    Public Sub PM_FI_LI_INIT(ByVal PP_ID As String)
        Codigo_LI.PG_LI_CLEAR(LI_LISTADO_DETALLE)
        If TB_K_INSTRUCCION.Text <> "" Then
            PM_LI_FORMAT_DETALLE(LI_LISTADO_DETALLE, False) ' FALSE POR QUE NO ES UNA NUEVA INSTRUCCIÓN
            PM_LI_CARGAR_LISTADO_DETALLE(LI_LISTADO_DETALLE, "[PG_LI_DETALLE_INSTRUCCION_X_K_INSTRUCCION]", PP_ID)
        Else
            PM_LI_FORMAT_DETALLE(LI_LISTADO_DETALLE, True) ' TRUE POR QUE SI ES UNA NUEVA INSTRUCCIÓN
        End If
    End Sub

    Public Sub PM_DT_INIT()
        PM_FECHAS_FILTRO_SEMANA()
    End Sub

    Public Sub PM_FI_DT_INIT()
        If TB_K_INSTRUCCION.Text = "" Then
            TB_F_INSTRUCCION.Text = VL_HOY
        End If
    End Sub

    Public Sub PM_FI_CH_INIT()
        If TB_K_INSTRUCCION.Text = "" Then
            CH_L_CAPTURA.Checked = True
        End If
        CH_L_CAPTURA.Enabled = False
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
        Codigo_FI.FG_FI_LOAD_X_ID(VM_ID_BASE_DE_DATOS, Me, PP_ID)
        PM_FI_DT_INIT()
        PM_FI_CH_INIT()
        PM_FI_LI_INIT(PP_ID)
        PM_DESMARCAR_TODOS_CHECKS(LI_LISTADO)
        PM_LIMPIAR_ARRAY(VM_INS_IDS)
        PM_AGREGAR_ID_FICHA_A_ARRAY(VM_INS_IDS)
        TB_MONTO_INSTRUCCION.Select()
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)

        If VM_IN_MODO_OPERACION <> Modo_Operacion.Clon Then
            Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_INSTRUCCION, PP_ROW)
            Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)
        End If
        Codigo_CTRL.PG_CO_DATA_LOAD("K_RESUMEN_FLUJO_DIARIO_X_UNO", TB_K_RFDxUNO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_BENEFICIARIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_MONTO_INSTRUCCION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_F_INSTRUCCION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_REFERENCIA_1, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("L_CAPTURA_MANUAL", CH_L_CAPTURA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_REFERENCIA_2, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_TIPO_INSTRUCCION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_FORMA_INSTRUCCION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ESTATUS_INSTRUCCION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_RAZON_SOCIAL, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_UNIDAD_OPERATIVA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_CUENTA_BANCO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_PROVEEDOR, PP_ROW)
    End Sub

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 20)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)]
        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "", "", GetType(Integer), 20, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_INSTRUCCION", "#INS", GetType(Integer), 85, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "CUENTA", "Cuenta Banco", GetType(String), 100, 2, 0, 1, 1, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_RAZON_SOCIAL", "Razón Social", GetType(String), 80, 2, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_UNIDAD_OPERATIVA", "Unidad Operativa", GetType(String), 80, 2, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "RFC_PROVEEDOR", "RFC Proveedor", GetType(String), 110, 2, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_INSTRUCCION_DDMMMYYYY", "Fecha Instrucción", GetType(Date), 100, 2, 0, 1, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_TIPO_INSTRUCCION", "Tipo", GetType(Decimal), 80, 2, 0, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ESTATUS_INSTRUCCION", "Estatus", GetType(String), 80, 2, 0, 1, 0, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_FORMA_INSTRUCCION", "Forma", GetType(String), 100, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "BENEFICIARIO", "Beneficiario", GetType(String), 200, 1, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "REFERENCIA_1", "Referencia 1", GetType(String), 250, 1, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "REFERENCIA_2", "Referencia 2", GetType(String), 400, 1, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "MONTO_INSTRUCCION", "Monto", GetType(Decimal), 90, 3, 0, 1, 0, 2)
        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)
    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_INSTRUCCION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CUENTA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_RAZON_SOCIAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "RFC_PROVEEDOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_INSTRUCCION_DDMMMYYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_TIPO_INSTRUCCION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ESTATUS_INSTRUCCION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_FORMA_INSTRUCCION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "BENEFICIARIO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "REFERENCIA_1")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "REFERENCIA_2")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MONTO_INSTRUCCION")
        Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)
    End Sub

    Private Sub PM_LI_FORMAT_DETALLE(ByRef PP_LI_LISTADO_DETALLE As DataGridView, ByVal PP_MODO As Boolean)
        Dim VP_TIPO_INS As Integer = Codigo_CB.FG_CB_ITEM_VALUE(CB_TIPO_INSTRUCCION)
        Dim VP_VER_TRA, VP_VER_CXP As Integer : Dim VP_VER_DET As Integer = 1

        If PP_MODO = True Then ' MODO NUEVA INSTRUCCIÓN
            VP_VER_DET = 0 : VP_VER_TRA = 0 : VP_VER_CXP = 0
        Else ' MODO EDICIÓN
            If VP_TIPO_INS = 101 Then ' 101 = TIPO TRASPASO
                VP_VER_TRA = 1 : VP_VER_CXP = 0
            ElseIf VP_TIPO_INS = 102 Then ' 102 = TIPO CXP
                VP_VER_TRA = 0 : VP_VER_CXP = 1
            End If
        End If

        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO_DETALLE, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)]
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_DETALLE, "K_DETALLE_INSTRUCCION", "#DET", GetType(Integer), 70, 2, 0, VP_VER_DET, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_DETALLE, "K_INSTRUCCION", "#INS", GetType(String), 70, 2, 0, 0, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_DETALLE, "K_TRASPASO", "#TRA", GetType(String), 75, 2, 0, VP_VER_TRA, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_DETALLE, "F_TRASPASO_DDMMMYYYY", "F. Traspaso", GetType(Date), 100, 2, 0, VP_VER_TRA, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_DETALLE, "D_TRASPASO", "Traspaso", GetType(String), 200, 1, 0, VP_VER_TRA, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_DETALLE, "K_FACTURA_CXP", "#CXP", GetType(String), 75, 2, 0, VP_VER_CXP, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_DETALLE, "F_CXP_DDMMMYYYY", "Fecha CXP", GetType(Date), 100, 2, 0, VP_VER_CXP, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_DETALLE, "C_FACTURA_CXP", "CXP", GetType(String), 200, 1, 0, VP_VER_CXP, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_DETALLE, "MONTO", "Monto", GetType(String), 90, 3, 0, VP_VER_DET, 0, 1, Nothing, Color.LightYellow, 0)
    End Sub

    Public Sub PM_LI_ROW_WRITE_DETALLE(ByRef PP_LISTADO_DETALLE As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO_DETALLE)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_DETALLE, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_DETALLE_INSTRUCCION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_DETALLE, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_INSTRUCCION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_DETALLE, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_TRASPASO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_DETALLE, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_TRASPASO_DDMMMYYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_DETALLE, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_TRASPASO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_DETALLE, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_FACTURA_CXP")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_DETALLE, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_CXP_DDMMMYYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_DETALLE, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "C_FACTURA_CXP")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_DETALLE, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MONTO")
    End Sub

    Public Sub PM_LI_CARGAR_LISTADO_DETALLE(ByVal PP_LISTADO As DataGridView, ByVal PP_SP As String, ByVal PP_PARAMETROS As String)
        Me.Cursor = Cursors.WaitCursor
        Dim VP_PARAMETROS As String = PP_PARAMETROS

        Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
        Dim VP_STORED_PROCEDURE As String = PP_SP

        Dim VP_TABLA As Data.DataTable
        VP_TABLA = Codigo_CON.FG_SP_EXECUTE_DATATABLE(VM_ID_BASE_DE_DATOS, VP_STORED_PROCEDURE, VP_PARAMETROS)

        PG_LI_LOAD_DETALLE(PP_LISTADO, VP_TABLA)

        Me.Cursor = Cursors.Default
        Dim VP_REGISTROS As String
        VP_REGISTROS = VP_TABLA.Rows.Count().ToString()
        LB_RESULTADO.Text = "Resultado de la operación: " + VP_REGISTROS + " registros." + Environment.NewLine + LB_RESULTADO.Text
    End Sub

    Public Sub PG_LI_LOAD_DETALLE(ByRef PP_LISTADO As DataGridView, ByVal PP_DATATABLE As DataTable)
        Codigo_LI.PG_LI_CLEAR(PP_LISTADO)
        For Each VP_ROW_DATA As DataRow In PP_DATATABLE.Rows
            Codigo_LI.PG_LI_ROW_ADD(PP_LISTADO)
            PM_LI_ROW_WRITE_DETALLE(PP_LISTADO, VP_ROW_DATA)
        Next
        PP_LISTADO.CurrentCell = Nothing
    End Sub

    Public Sub PG_BT_GENERAR_POLIZA_CHEQUE(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView, ByRef PP_ARRAY As ArrayList)
        Dim MSJ As String = FM_VALIDAR_TAMANO_ARRAY(PP_ARRAY)
        If MSJ = "" Then
            Me.Cursor = Cursors.WaitCursor
            PM_IMPRIMIR_CHEQUES(PP_ARRAY)
            If VM_IN_MODO_OPERACION = Modo_Operacion.Listado Then
                PM_BT_BUSCAR_CLICK(PP_FORMA, PP_LISTADO)
                PM_LIMPIAR_ARRAY(PP_ARRAY)
            End If
            Me.Cursor = Cursors.Default
        Else
            Codigo_Message.PG_MENSAJE_AVISO(MSJ)
        End If
    End Sub

    Public Sub PM_IMPRIMIR_CHEQUES(ByRef PP_ARRAY As ArrayList)
        For Each i As Integer In PP_ARRAY
            Dim VP_ID_INS As Integer = i
            Dim PP_PARAMETROS As String = VP_ID_INS
            'SE MODIFICÓ ESTA SECCIÓN   //   AX   //   AQUÍ INICIA
            Dim VP_IMPRESION As New Codigo_Imprimir
            Dim VP_POLIZA_CHEQUE As New POLIZA_CHEQUE
            VP_POLIZA_CHEQUE.PM_RP_003_POLIZA_CHEQUE(VP_IMPRESION, Me, VP_ID_INS, 0)
            'SE MODIFICÓ ESTA SECCIÓN   //   AX   //   AQUÍ TERMINA
        Next
    End Sub

    Public Sub PM_DESMARCAR_TODOS_CHECKS(ByRef PP_LISTADO As DataGridView)
        For Each VP_ROW As DataGridViewRow In PP_LISTADO.Rows
            Dim VP_CHK As DataGridViewCheckBoxCell = VP_ROW.Cells(0)
            VP_CHK.Value = False
        Next
    End Sub

    Public Sub PM_AGREGAR_ID_FICHA_A_ARRAY(ByRef PP_ARRAY As ArrayList)
        If TB_K_INSTRUCCION.Text <> "" Then
            Dim VP_ID_INS As Integer = Convert.ToInt16(TB_K_INSTRUCCION.Text)
            PP_ARRAY.Add(VP_ID_INS)
        End If
    End Sub

    Public Sub PM_LI_CELL_CLICK(e As DataGridViewCellEventArgs)
        Dim VP_CHK As DataGridViewCheckBoxCell = LI_LISTADO.Rows(e.RowIndex).Cells(0)
        Dim VP_ID_INS As Integer = FM_ID_SELECCIONADO(LI_LISTADO, Codigo_LI.FG_LI_ROW_CURRENT(LI_LISTADO))
        'Dim TXT As String = "" : MsgBox(VP_ID_INS.ToString)
        If VP_CHK.Value = True Then
            VP_CHK.Value = False
            VM_INS_IDS.Remove(VP_ID_INS)
            LI_LISTADO.CurrentCell = Nothing
        Else
            VP_CHK.Value = True
            VM_INS_IDS.Add(VP_ID_INS)
        End If
        'For Each I As Integer In VM_INS_IDS
        '    TXT += I.ToString + ", "
        'Next : MsgBox(TXT)
    End Sub

    Public Sub PM_FECHAS_FILTRO_SEMANA()
        TB_LI_F_INICIAL.Text = VL_HOY.AddDays(-7)
        TB_LI_F_FINAL.Text = VL_HOY
    End Sub

    Public Sub PM_FECHAS_FILTRO_HOY()
        TB_LI_F_INICIAL.Text = VL_HOY
        TB_LI_F_FINAL.Text = VL_HOY
    End Sub

    Public Sub PM_FECHAS_FILTRO_AYER()
        TB_LI_F_INICIAL.Text = VL_AYER
        TB_LI_F_FINAL.Text = VL_AYER
    End Sub

    Public Sub PM_LIMPIAR_ARRAY(ByRef PP_ARRAY As ArrayList)
        PP_ARRAY.Clear()
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

    Private Sub PM_BT_CLONAR_CLICK(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_CLONAR_CLICK(PP_FORMA, PP_LISTADO)
    End Sub

#End Region

#Region "EVENTOS"

    Private Sub Catalogo_T1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT(Me)
    End Sub

    Private Sub BT_AGREGAR_Click(sender As Object, e As EventArgs) Handles BT_AGREGAR.Click
        PM_BT_AGREGAR_CLICK(Me)
    End Sub

    Private Sub BT_BUSCAR_Click(sender As Object, e As EventArgs) Handles BT_LI_BUSCAR.Click
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub BT_CANCELAR_Click(sender As Object, e As EventArgs) Handles BT_CANCELAR.Click
        PM_BT_CANCELAR_CLICK(Me)
        PM_LIMPIAR_ARRAY(VM_INS_IDS)
    End Sub

    Private Sub BT_SALIR_Click(sender As Object, e As EventArgs) Handles BT_SALIR.Click
        PM_BT_SALIR_CLICK(Me)
    End Sub

    Private Sub BT_GUARDAR_Click(sender As Object, e As EventArgs) Handles BT_GUARDAR.Click
        PM_BT_GUARDAR_CLICK(Me, LI_LISTADO)
        PM_LIMPIAR_ARRAY(VM_INS_IDS)
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
        PM_LIMPIAR_ARRAY(VM_INS_IDS)
    End Sub

    Private Sub BT_EXPORTAR_EXCEL_Click(sender As Object, e As EventArgs) Handles BT_EXPORTAR_EXCEL.Click
        PM_BT_EXPORTAR_EXCEL_CLICK(LI_LISTADO)
    End Sub

    Private Sub BT_POLIZA_CHEQUE_Click(sender As Object, e As EventArgs) Handles BT_POLIZA_CHEQUE.Click
        PG_BT_GENERAR_POLIZA_CHEQUE(Me, LI_LISTADO, VM_INS_IDS)
    End Sub

    Private Sub BT_AYER_Click(sender As Object, e As EventArgs) Handles BT_AYER.Click
        PM_FECHAS_FILTRO_AYER()
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub BT_HOY_Click(sender As Object, e As EventArgs) Handles BT_HOY.Click
        PM_FECHAS_FILTRO_HOY()
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub LI_LISTADO_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LI_LISTADO.CellClick
        If e.RowIndex <> -1 Then
            PM_LI_CELL_CLICK(e)
        End If
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

#Region "EVENTO CHANGE VALUE DEL COMBO DE RAZÓN SOCIAL"

    Private Sub CB_RAZON_SOCIAL_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_RAZON_SOCIAL.SelectedValueChanged
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_UNIDAD_OPERATIVA, 0, 1, New ComboBox, CB_RAZON_SOCIAL, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_CUENTA_BANCO_Load_X_ORGANIZACION(VM_ID_BASE_DE_DATOS, Me, CB_CUENTA_BANCO, 0, CB_RAZON_SOCIAL, CB_UNIDAD_OPERATIVA, VG_USUARIO_ACCION)
    End Sub

    Private Sub CB_UNIDAD_OPERATIVA_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_UNIDAD_OPERATIVA.SelectedValueChanged
        Codigo_CB.PG_CB_CUENTA_BANCO_Load_X_ORGANIZACION(VM_ID_BASE_DE_DATOS, Me, CB_CUENTA_BANCO, 0, CB_RAZON_SOCIAL, CB_UNIDAD_OPERATIVA, VG_USUARIO_ACCION)
    End Sub



#End Region

End Class


Public Class POLIZA_CHEQUE

    Dim VM_RP_ID_DOCUMENTO, VM_RP_EMISOR, VM_RP_TITULO, VM_RP_ID_REPORTE, VM_RP_CHEQUE_FECHA,
    VM_RP_CHEQUE_BENEFICIARIO, VM_RP_CHEQUE_MONTO, VM_RP_CHEQUE_MONTO_LETRAS, VM_RP_CHEQUE_LEYENDA_ABONO,
    VM_ID_REPORTE, VM_RP_BENEFICIARIO, VM_RP_BANCO, VM_RP_CUENTA_BANCARIA, VM_RP_CONCEPTO,
    VM_RP_CONCEPTO_BANCO, VM_RP_MONTO_BANCO, VM_RP_CUENTA, VM_RP_K_TRASPASO, VM_RP_MONTO As String

#Region "Variables Locales de la Clase"
    Public Property VM_RP_ID_DOCUMENTO1 As String
        Get
            Return VM_RP_ID_DOCUMENTO
        End Get
        Set(value As String)
            VM_RP_ID_DOCUMENTO = value
        End Set
    End Property

    Public Property VM_RP_EMISOR1 As String
        Get
            Return VM_RP_EMISOR
        End Get
        Set(value As String)
            VM_RP_EMISOR = value
        End Set
    End Property

    Public Property VM_RP_TITULO1 As String
        Get
            Return VM_RP_TITULO
        End Get
        Set(value As String)
            VM_RP_TITULO = value
        End Set
    End Property

    Public Property VM_RP_ID_REPORTE1 As String
        Get
            Return VM_RP_ID_REPORTE
        End Get
        Set(value As String)
            VM_RP_ID_REPORTE = value
        End Set
    End Property

    Public Property VM_RP_CHEQUE_FECHA1 As String
        Get
            Return VM_RP_CHEQUE_FECHA
        End Get
        Set(value As String)
            VM_RP_CHEQUE_FECHA = value
        End Set
    End Property

    Public Property VM_RP_CHEQUE_BENEFICIARIO1 As String
        Get
            Return VM_RP_CHEQUE_BENEFICIARIO
        End Get
        Set(value As String)
            VM_RP_CHEQUE_BENEFICIARIO = value
        End Set
    End Property

    Public Property VM_RP_CHEQUE_MONTO1 As String
        Get
            Return VM_RP_CHEQUE_MONTO
        End Get
        Set(value As String)
            VM_RP_CHEQUE_MONTO = value
        End Set
    End Property

    Public Property VM_RP_CHEQUE_MONTO_LETRAS1 As String
        Get
            Return VM_RP_CHEQUE_MONTO_LETRAS
        End Get
        Set(value As String)
            VM_RP_CHEQUE_MONTO_LETRAS = value
        End Set
    End Property

    Public Property VM_RP_CHEQUE_LEYENDA_ABONO1 As String
        Get
            Return VM_RP_CHEQUE_LEYENDA_ABONO
        End Get
        Set(value As String)
            VM_RP_CHEQUE_LEYENDA_ABONO = value
        End Set
    End Property

    Public Property VM_ID_REPORTE1 As String
        Get
            Return VM_ID_REPORTE
        End Get
        Set(value As String)
            VM_ID_REPORTE = value
        End Set
    End Property

    Public Property VM_RP_BENEFICIARIO1 As String
        Get
            Return VM_RP_BENEFICIARIO
        End Get
        Set(value As String)
            VM_RP_BENEFICIARIO = value
        End Set
    End Property

    Public Property VM_RP_BANCO1 As String
        Get
            Return VM_RP_BANCO
        End Get
        Set(value As String)
            VM_RP_BANCO = value
        End Set
    End Property

    Public Property VM_RP_CUENTA_BANCARIA1 As String
        Get
            Return VM_RP_CUENTA_BANCARIA
        End Get
        Set(value As String)
            VM_RP_CUENTA_BANCARIA = value
        End Set
    End Property

    Public Property VM_RP_CONCEPTO1 As String
        Get
            Return VM_RP_CONCEPTO
        End Get
        Set(value As String)
            VM_RP_CONCEPTO = value
        End Set
    End Property

    Public Property VM_RP_CONCEPTO_BANCO1 As String
        Get
            Return VM_RP_CONCEPTO_BANCO
        End Get
        Set(value As String)
            VM_RP_CONCEPTO_BANCO = value
        End Set
    End Property

    Public Property VM_RP_MONTO_BANCO1 As String
        Get
            Return VM_RP_MONTO_BANCO
        End Get
        Set(value As String)
            VM_RP_MONTO_BANCO = value
        End Set
    End Property

    Public Property VM_RP_CUENTA1 As String
        Get
            Return VM_RP_CUENTA
        End Get
        Set(value As String)
            VM_RP_CUENTA = value
        End Set
    End Property

    Public Property VM_RP_K_TRASPASO1 As String
        Get
            Return VM_RP_K_TRASPASO
        End Get
        Set(value As String)
            VM_RP_K_TRASPASO = value
        End Set
    End Property

    Public Property VM_RP_MONTO1 As String
        Get
            Return VM_RP_MONTO
        End Get
        Set(value As String)
            VM_RP_MONTO = value
        End Set
    End Property
#End Region

#Region "SUBS PM ROTULADO_POLIZA"

    Public Sub PM_ROTULADO_SECCION_A(ByRef PP_IMPRESION As Codigo_Imprimir, ByRef PP_Ncol As Decimal, ByRef PP_Nrow As Decimal, ByVal PP_A0 As String, ByVal PP_A1 As String, ByVal PP_A2 As String)
        PP_IMPRESION.VL_PRINTER1.FontSize = 9
        'SECCIÓN A    //  DATOS
        '--========================================================
        PP_IMPRESION.PG_TEXTO_CM(2, 2, PP_A0)
        '--========================================================
        PP_IMPRESION.PG_TEXTO_CM(88, 2, PP_A2)
        '--========================================================
        'Para alinear el título centrado, Funciona con los títulos de TRASPASO y CXP
        PP_IMPRESION.VL_PRINTER1.FontSize = 14
        PP_IMPRESION.PG_TEXTO_CM(41, 2, PP_A1.PadLeft(12, " "))
        '--========================================================

    End Sub

    Public Sub PM_ROTULADO_SECCION_B(ByRef PP_IMPRESION As Codigo_Imprimir, ByRef PP_Ncol As Decimal, ByRef PP_Nrow As Decimal, ByVal PP_B0 As String, ByVal PP_B1 As String, ByVal PP_B2 As String, ByVal PP_B3 As String, ByVal PP_B4 As String, ByVal PP_C1 As String)
        PP_IMPRESION.VL_PRINTER1.FontSize = 9

        Select Case PP_C1
            Case "BANAMEX"
                'SECCION B    //  DATOS    //    BANAMEX
                '--========================================================
                PP_IMPRESION.PG_TEXTO_CM(20, 8, PP_B0)
                PP_IMPRESION.PG_TEXTO_CM(65, 10, PP_B1)
                PP_IMPRESION.PG_TEXTO_CM(12, 14, PP_B2)
                PP_IMPRESION.PG_TEXTO_CM(75, 16, Microsoft.VisualBasic.Left(PP_B3, (PP_B3.Length - 2)).PadLeft(13, " "))
                PP_IMPRESION.PG_TEXTO_CM(12, 17, PP_B4)
                '--========================================================
            Case Else
                'SECCION B    //  DATOS    //    MODIFICAR MEDIDAS Y AGREGAR EL CASE DEL BANCO CORRESPONDIENTE
                '--========================================================
                PP_IMPRESION.PG_TEXTO_CM(20, 8, PP_B0)
                PP_IMPRESION.PG_TEXTO_CM(65, 10, PP_B1)
                PP_IMPRESION.PG_TEXTO_CM(12, 14, PP_B2)
                PP_IMPRESION.PG_TEXTO_CM(75, 16, Microsoft.VisualBasic.Left(PP_B3, (PP_B3.Length - 2)).PadLeft(13, " "))
                PP_IMPRESION.PG_TEXTO_CM(12, 17, PP_B4)
                '--========================================================
        End Select
    End Sub

    Public Sub PM_ROTULADO_SECCION_C(ByRef PP_IMPRESION As Codigo_Imprimir, ByRef PP_Ncol As Decimal, ByRef PP_Nrow As Decimal, ByVal PP_C0 As String, ByVal PP_C1 As String, ByVal PP_C2 As String, ByVal PP_C3 As String)
        PP_IMPRESION.VL_PRINTER1.FontSize = 9
        'SECCIÓN C    //  ENCABEZADOS
        '--========================================================
        PP_IMPRESION.PG_TEXTO_CM(6, 31, "BENEFICIARIO")
        PP_IMPRESION.PG_TEXTO_CM(34, 31, "BANCO")
        PP_IMPRESION.PG_TEXTO_CM(58, 31, "NÚM. CUENTA")
        PP_IMPRESION.PG_TEXTO_CM(29, 36, "CONCEPTO")
        PP_IMPRESION.PG_TEXTO_CM(85, 36, "FIRMA")
        '--========================================================

        'SECCIÓN C    //  DATOS
        '--========================================================
        PP_IMPRESION.PG_TEXTO_CM(4, 33, PP_C0)
        PP_IMPRESION.PG_TEXTO_CM(30, 34, PP_C1)
        PP_IMPRESION.PG_TEXTO_CM(52, 33, PP_C2)
        PP_IMPRESION.PG_TEXTO_CM(4, 39, PP_C3)
        '--========================================================

    End Sub

    Public Sub PM_ROTULADO_SECCION_D(ByRef PP_IMPRESION As Codigo_Imprimir, ByRef PP_Ncol As Decimal, ByRef PP_Nrow As Decimal, ByVal PP_D0 As String, ByVal PP_D1 As String)
        PP_IMPRESION.VL_PRINTER1.FontSize = 9
        'SECCIÓN D    //  ENCABEZADOS
        '--========================================================
        PP_IMPRESION.PG_TEXTO_CM(13, 46, "#ID_DETALLE")
        PP_IMPRESION.PG_TEXTO_CM(46, 46, "CONCEPTO")
        PP_IMPRESION.PG_TEXTO_CM(82, 46, "$ DETALLE")
        PP_IMPRESION.PG_TEXTO_CM(95, 46, "$ TOTAL")
        '--========================================================

        'SECCIÓN D    //  DATOS
        '--=============================================================================
        PP_IMPRESION.PG_TEXTO_CM(26, 48, PP_D0)
        PP_IMPRESION.PG_TEXTO_CM(92, 48, (Microsoft.VisualBasic.Left(PP_D1, (PP_D1.Length - 2))).PadLeft(13, " "))
        '--=============================================================================

    End Sub

    Public Sub PM_ROTULADO_SECCION_E(ByRef PP_IMPRESION As Codigo_Imprimir, ByRef PP_Ncol As Decimal, ByRef PP_Nrow As Decimal, ByVal PP_E0 As String)
        PP_IMPRESION.VL_PRINTER1.FontSize = 9
        'SECCIÓN E    //  DATOS
        '--========================================================
        PP_IMPRESION.PG_TEXTO_CM(3, 87, PP_E0)
        '--========================================================

    End Sub
#End Region

#Region "SUBS PG RP 003 PÓLIZA CHEQUE"

    Public Sub PM_RP_003_POLIZA_CHEQUE(ByRef PP_IMPRESION As Codigo_Imprimir, ByRef PP_FORMA As Object, ByVal PP_ID As String, ByVal PP_L_REFERENCIAS As Integer)
        Try
            Dim VL_PRINTER = New Printer
            Dim VM_IMPRESION = New Codigo_Imprimir
            VM_IMPRESION.VL_PRINTER1 = VL_PRINTER
            PP_IMPRESION = VM_IMPRESION
            VL_PRINTER.DocumentName = "POLIZA_" + PP_ID

            PM_SK_RP_003_POLIZA_CHEQUE(PP_FORMA, "[PG_RP_003_POLIZA_CHEQUE]", PP_ID, 0, VM_IMPRESION)
            PM_SK_RP_003_POLIZA_CHEQUE(PP_FORMA, "[PG_RP_003_POLIZA_CHEQUE_DETALLE]", PP_ID, 1, VM_IMPRESION)

            VM_IMPRESION.PG_FUENTE_BASE()

            '--======================================
            VM_IMPRESION.PG_DIBUJO_SECCION_A(0.5, 0.5, 21, 25)
            VM_IMPRESION.PG_DIBUJO_SECCION_B(0.5, 1.5, 21, 8)
            VM_IMPRESION.PG_DIBUJO_SECCION_C(0.5, 9.5, 21, 4.5)
            VM_IMPRESION.PG_DIBUJO_SECCION_D(0.5, 14, 21, 11)
            VM_IMPRESION.PG_DIBUJO_SECCION_E(0.5, 25, 21, 2)
            '--======================================
            PM_ROTULADO_SECCION_A(PP_IMPRESION, 0, 0, VM_RP_EMISOR, VM_RP_TITULO, VM_RP_ID_DOCUMENTO)
            PM_ROTULADO_SECCION_B(PP_IMPRESION, 0, 0, VM_RP_CHEQUE_LEYENDA_ABONO, VM_RP_CHEQUE_FECHA, VM_RP_BENEFICIARIO, VM_RP_CHEQUE_MONTO, VM_RP_CHEQUE_MONTO_LETRAS, VM_RP_BANCO)
            PM_ROTULADO_SECCION_C(PP_IMPRESION, 0, 0, VM_RP_BENEFICIARIO, VM_RP_BANCO, VM_RP_CUENTA_BANCARIA, VM_RP_CONCEPTO)
            PM_ROTULADO_SECCION_D(PP_IMPRESION, 0, 0, VM_RP_CONCEPTO_BANCO1, VM_RP_MONTO_BANCO1)
            PM_ROTULADO_SECCION_E(PP_IMPRESION, 0, 0, VM_ID_REPORTE1)

            If PP_L_REFERENCIAS = 1 Then 'Se recibe desde la Forma // 0=USUARIO     1=PRUEBAS
                VM_IMPRESION.PG_ROTULADO_SECCION_COLUMNAS_RENGLONES(0, 0, "")
            End If
            '--======================================


            VL_PRINTER.EndDoc()

        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PM_RP_003_POLIZA_CHEQUE")
        End Try

    End Sub

    Public Sub PM_RP_003_POLIZA_CHEQUE_CARGAR(ByRef PP_TABLA As DataTable, ByRef PP_IMPRESION As Codigo_Imprimir)
        Try
            'SECCIÓN A
            '--=============================================================================
            VM_RP_EMISOR1 = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_EMISOR")
            VM_RP_TITULO1 = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_TITULO")
            VM_RP_ID_DOCUMENTO1 = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_ID_DOCUMENTO")

            'SECCIÓN B
            '--=============================================================================
            VM_RP_CHEQUE_FECHA1 = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_CHEQUE_FECHA")
            VM_RP_CHEQUE_BENEFICIARIO1 = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_CHEQUE_BENEFICIARIO")
            VM_RP_CHEQUE_MONTO1 = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_CHEQUE_MONTO")
            VM_RP_CHEQUE_MONTO_LETRAS1 = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_CHEQUE_MONTO_LETRAS")
            VM_RP_CHEQUE_LEYENDA_ABONO1 = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_CHEQUE_LEYENDA_ABONO")

            'SECCIÓN C
            '--=============================================================================
            VM_ID_REPORTE1 = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_ID_REPORTE")
            VM_RP_BENEFICIARIO1 = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_BENEFICIARIO")
            VM_RP_BANCO1 = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_BANCO")
            VM_RP_CUENTA_BANCARIA1 = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_CUENTA_BANCARIA")
            VM_RP_CONCEPTO1 = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_CONCEPTO")

            'SECCIÓN D
            '--=============================================================================
            VM_RP_CONCEPTO_BANCO1 = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_CONCEPTO_BANCO")
            VM_RP_MONTO_BANCO1 = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_MONTO_BANCO")

            'SECCIÓN E
            '--=============================================================================
            VM_ID_REPORTE1 = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_ID_REPORTE")

        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PM_RP_003_POLIZA_CHEQUE_CARGAR")
        End Try
    End Sub

    Public Sub PM_RP_003_POLIZA_CHEQUE_DETALLE(ByVal PP_TABLA As DataTable, ByRef PP_IMPRESION As Codigo_Imprimir)
        PP_IMPRESION.PG_FUENTE_BASE()
        PP_IMPRESION.VL_PRINTER1.FontSize = 9
        Dim VP_COL, VP_COL2, VP_COL3, VP_ROW, VP_CONTA As Integer
        VP_COL = 14 : VP_COL2 = 26 : VP_COL3 = 81 : VP_ROW = 50 : VP_CONTA = 0

        Try
            For Each VP_ROW_DATA As DataRow In PP_TABLA.Rows
                VM_RP_K_TRASPASO1 = FM_OBTENER_DATOS_POLIZA(PP_TABLA, VP_CONTA, "RP_K_TRASPASO")
                VM_RP_CUENTA1 = FM_OBTENER_DATOS_POLIZA(PP_TABLA, VP_CONTA, "RP_CUENTA")
                VM_RP_MONTO1 = FM_OBTENER_DATOS_POLIZA(PP_TABLA, VP_CONTA, "RP_MONTO")

                PP_IMPRESION.PG_TEXTO_CM(VP_COL, VP_ROW, VM_RP_K_TRASPASO1)
                PP_IMPRESION.PG_TEXTO_CM(VP_COL2, VP_ROW, VM_RP_CUENTA1)
                PP_IMPRESION.PG_TEXTO_CM(VP_COL3, VP_ROW, (Microsoft.VisualBasic.Left(VM_RP_MONTO1, (VM_RP_MONTO1.Length - 2))).PadLeft(12, " "))

                VP_ROW = VP_ROW + 1 : VP_CONTA = VP_CONTA + 1
            Next
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PM_RP_003_POLIZA_CHEQUE_DETALLE")
        End Try
    End Sub

#End Region

#Region "SUB PG LLAMADA A BASE DE DATOS"

    Public Sub PM_SK_RP_003_POLIZA_CHEQUE(ByRef PP_FORMA As Object, ByVal PP_SP As String, ByVal PP_PARAMETROS As String, ByRef PP_BANDERA As Integer, ByRef PP_IMPRESION As Codigo_Imprimir)
        Dim VP_PARAMETROS As String = PP_PARAMETROS

        Try
            Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
            Dim VP_STORED_PROCEDURE As String = PP_SP

            Dim VP_TABLA As Data.DataTable
            VP_TABLA = Codigo_CON.FG_SP_EXECUTE_DATATABLE(PP_FORMA.VM_ID_BASE_DE_DATOS, VP_STORED_PROCEDURE, VP_PARAMETROS)

            If PP_BANDERA = 0 Then
                PM_RP_003_POLIZA_CHEQUE_CARGAR(VP_TABLA, PP_IMPRESION)
            Else
                PM_RP_003_POLIZA_CHEQUE_DETALLE(VP_TABLA, PP_IMPRESION)
            End If

        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PM_SK_RP_003_POLIZA_CHEQUE")
        End Try
    End Sub

    Public Function FM_OBTENER_DATOS_POLIZA(ByRef PP_TABLA As DataTable, ByVal PP_ROW As Integer, ByVal PP_COL_NOMBRE As String) As String
        Dim VP_DATO As String = ""
        Try
            VP_DATO = PP_TABLA.Rows(PP_ROW).Item(PP_COL_NOMBRE).ToString
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("FM_OBTENER_DATOS_POLIZA")
        End Try
        Return VP_DATO
    End Function
#End Region

End Class
