Public Class FO_MONITOREO_AUTORIZACION_FIRMA

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_ID_VERSION As Integer = 0

#End Region

#Region "VARIABLES LOCALES"

    Dim VL_ID_AUTORIZACION, VL_A, VL_B, VL_C As Integer

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ZONA_UO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_RAZON_SOCIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIPO_AUTORIZACION, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_AUTORIZACION, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESTATUS_FIRMA, False)
        Codigo_CTRL.PG_CO_PARAMETRO_FECHA(VP_PARAMETROS, TB_LI_F_APERTURA, True)
        Codigo_CTRL.PG_CO_PARAMETRO_FECHA(VP_PARAMETROS, TB_LI_F_CIERRE, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_SOLO_AUTORIZACION_DIRECTA, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_SQL_FLUJO_FIRMA_X_K_AUTORIZACION() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VL_ID_AUTORIZACION, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_AUTORIZACION_FIRMA.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_AUTORIZACION_FIRMA, False)
            PP_NUEVO = False
        End If

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_D_AUTORIZACION_FIRMA, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_C_AUTORIZACION_FIRMA, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ESTATUS_FIRMA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_F_APERTURA, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_F_CIERRE, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_USUARIO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_AUTORIZACION, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MONTO_AUTORIZAR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MONTO_AUTORIZADO, False)

        Return VP_PARAMETROS
    End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "D_AUTORIZACION_FIRMA")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_AUTORIZACION_FIRMA")
        Return VP_ID
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

        Codigo_CB.PG_CB_ZONA_UO_TODOS_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_ZONA_UO, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_RAZON_SOCIAL_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_RAZON_SOCIAL, 1, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 1, New ComboBox, CB_LI_RAZON_SOCIAL, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_UNIDAD_OPERATIVA)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_ESTATUS_FIRMA, "ESTATUS_FIRMA")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ESTATUS_FIRMA, "ESTATUS_FIRMA")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_USUARIO, "USUARIO")
        Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_LI_AUTORIZACION)
        Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS,Me, CB_AUTORIZACION, "AUTORIZACION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_USUARIO_ALTA, "USUARIO")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_USUARIO_CAMBIO, "USUARIO")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_TIPO_AUTORIZACION)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_TIPO_AUTORIZACION)

    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
        PM_LI_FORMAT_FLUJO_FIRMA_X_K_AUTORIZACION(LI_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION)
        PM_CH_INIT()
        PM_FI_LOAD("")
    End Sub

    Private Sub PM_FO_INIT(ByRef PP_FORMA As Object)
        Codigo_FRM.PG_FRM_INIT(VM_ID_BASE_DE_DATOS, PP_FORMA)
        PM_LI_INIT()
    End Sub

    Public Sub PM_CH_INIT()
        CH_A.Checked = True : CH_B.Checked = False : CH_C.Checked = False
    End Sub

    Public Sub PM_LI_VALIDAR_CHECKS(ByVal x As Boolean)
        If x = True Then
            If CH_A.Checked Then VL_A = 1 Else VL_A = 0
            If CH_B.Checked Then VL_B = 1 Else VL_B = 0
            If CH_C.Checked Then VL_C = 1 Else VL_C = 0
        Else
            VL_A = 0 : VL_B = 0 : VL_C = 0
        End If
    End Sub

    Public Sub PM_BUSCAR_FLUJO_FIRMA_X_K_AUTORIZACION(ByRef PP_LISTADO As DataGridView, ByVal PP_SP As String)
        Me.Cursor = Cursors.WaitCursor

        Dim VP_PARAMETROS As String
        VP_PARAMETROS = FM_SQL_FLUJO_FIRMA_X_K_AUTORIZACION()

        Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
        Dim VP_STORED_PROCEDURE As String = PP_SP

        Dim VP_TABLA As Data.DataTable
        VP_TABLA = Codigo_CON.FG_SP_EXECUTE_DATATABLE(VM_ID_BASE_DE_DATOS, VP_STORED_PROCEDURE, VP_PARAMETROS)

        PG_LI_LOAD_FLUJO_FIRMA_X_K_AUTORIZACION(LI_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, VP_TABLA)

        Cursor = Cursors.Default
        Dim VP_REGISTROS As String
        VP_REGISTROS = VP_TABLA.Rows.Count().ToString()
        LB_RESULTADO.Text = "Resultado de la operacion: " + VP_REGISTROS + " registros." + Environment.NewLine + LB_RESULTADO.Text
    End Sub

    Public Sub PG_LI_LOAD_FLUJO_FIRMA_X_K_AUTORIZACION(ByRef PP_LISTADO As DataGridView, ByVal PP_DATATABLE As DataTable)
        Codigo_LI.PG_LI_CLEAR(PP_LISTADO)

        Dim VP_LISTADO_NOMBRE = PP_LISTADO.Name
        For Each VP_ROW_DATA As DataRow In PP_DATATABLE.Rows
            Codigo_LI.PG_LI_ROW_ADD(PP_LISTADO)
            PM_LI_ROW_WRITE_FLUJO_FIRMA_X_K_AUTORIZACION(PP_LISTADO, VP_ROW_DATA)
        Next
        PP_LISTADO.CurrentCell = Nothing
    End Sub

#End Region

#Region "SUBS_PM"

    ''' <summary>
    ''' 'FUNCIÓN QUE CARGARÁ LA PARTE DE LA FICHA
    ''' </summary>
    Public Sub PM_FI_LOAD(ByVal PP_ID As String)
        Codigo_FI.FG_FI_LOAD_X_ID(VM_ID_BASE_DE_DATOS,  Me, PP_ID)
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_AUTORIZACION_FIRMA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_D_AUTORIZACION_FIRMA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_C_AUTORIZACION_FIRMA, PP_ROW)

        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ESTATUS_FIRMA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_F_APERTURA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_F_CIERRE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_USUARIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_AUTORIZACION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_MONTO_AUTORIZAR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_MONTO_AUTORIZADO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("L_AUTORIZACION_DIRECTA", CH_L_AUTORIZACION_DIRECTA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_TIPO_AUTORIZACION, PP_ROW)
        Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)
    End Sub

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2) (OPCIONALES COLOR LETRA, COLOR FONDO, BOLD [0, 1])]
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_AUTORIZACION_FIRMA", "#AUF", GetType(Integer), 40, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_AUTORIZACION", "Autorización", GetType(String), 250, 1, 0, 1, 1, 0, Nothing, Nothing, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ESTATUS_FIRMA", "Estatus", GetType(String), 60, 2, 0, 1, 1, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_TIPO_AUTORIZACION", "Tipo", GetType(String), 60, 2, 0, 1, 1, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_APERTURA_DDMMMYYYY", "Apertura", GetType(Date), 100, 2, 0, 1, 1, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_CIERRE_DDMMMYYYY", "Cierre", GetType(Date), 100, 2, 0, 1, 0, 0, Color.DarkOrange, Nothing, 1)

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ZONA_UO", "Zona", GetType(String), 60, 2, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_RAZON_SOCIAL", "Razón Social", GetType(String), 80, 2, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_UNIDAD_OPERATIVA", "Unidad Operativa", GetType(String), 120, 1, 0, 1, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_TRANSACCION", "Folio Transacción", GetType(String), 80, 2, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "MONTO_AUTORIZAR", "Monto Autorizar", GetType(Integer), 80, 3, 0, 1, 0, 1, Nothing, Nothing, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "MONTO_AUTORIZADO", "Monto Autorizado", GetType(Integer), 80, 3, 0, 1, 0, 1, Nothing, Nothing, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_AUTORIZACION_FIRMA", "Descripción", GetType(String), 220, 1, 0, 1, 0, 0, Nothing, Nothing, 1)

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_USUARIO", "Usuario Autoriz. Directa", GetType(String), 160, 1, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "C_AUTORIZACION_FIRMA", "Comentarios", GetType(String), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 0)

        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)
    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_AUTORIZACION_FIRMA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_AUTORIZACION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ESTATUS_FIRMA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_TIPO_AUTORIZACION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_APERTURA_DDMMMYYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_CIERRE_DDMMMYYYY")

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ZONA_UO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_RAZON_SOCIAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_TRANSACCION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MONTO_AUTORIZAR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MONTO_AUTORIZADO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_AUTORIZACION_FIRMA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_USUARIO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "C_AUTORIZACION_FIRMA")

        Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)
    End Sub

    Private Sub PM_LI_FORMAT_FLUJO_FIRMA_X_K_AUTORIZACION(ByRef PP_LI_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, 8, 21)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)]
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, "K_FLUJO_FIRMA", "#FFK", GetType(Integer), 40, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, "D_MODO_AUTORIZACION", "Modo", GetType(String), 90, 1, 0, 1, 1, 0, Nothing, Nothing, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, "S_ESTATUS_FIRMA", "Estatus", GetType(String), 60, 2, 0, 1, 1, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, "N_PASO", "Paso", GetType(Integer), 40, 2, 0, 1, 1, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, "N_DIAS_FLUJO_FIRMA", "Días Flujo", GetType(Integer), 40, 2, 0, 1, 0, 0, Nothing, Nothing, 1)

        ' A
        PM_LI_VALIDAR_CHECKS(CH_A.Checked)
        PM_LI_LETRA(PP_LI_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, "A", "A", VL_A)

        ' B
        PM_LI_VALIDAR_CHECKS(CH_B.Checked)
        PM_LI_LETRA(PP_LI_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, "B", "B", VL_B)

        ' C
        PM_LI_VALIDAR_CHECKS(CH_C.Checked)
        PM_LI_LETRA(PP_LI_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, "C", "C", VL_C)

        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, "L_PROCESAR", "Procesar", GetType(CheckBox), 70, 2, 0, 1, 0, 0)

    End Sub

    Public Sub PM_LI_LETRA(ByRef PP_LISTADO As DataGridView, ByVal PP_PREFIJO As String, ByVal PP_PREFIJO_S As String, ByVal PP_VISIBLE As Integer)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LISTADO, "ESTATUS_FIRMA" + PP_PREFIJO + "_S_ESTATUS_FIRMA", "Estatus - " + PP_PREFIJO_S, GetType(String), 60, 2, 0, PP_VISIBLE, 0, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LISTADO, "ROL" + PP_PREFIJO + "_D_ROL_AUTORIZACION", "Rol - " + PP_PREFIJO_S, GetType(Integer), 100, 2, 0, PP_VISIBLE, 0, 0, Nothing, Nothing, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LISTADO, "USUARIO_FIRMA" + PP_PREFIJO + "_D_USUARIO", "Usuario Firma - " + PP_PREFIJO_S, GetType(String), 90, 2, 0, PP_VISIBLE, 0, 0, Nothing, Nothing, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LISTADO, "OBSERVACIONES_FIRMA_" + PP_PREFIJO, "Observaciones - " + PP_PREFIJO_S, GetType(String), 120, 2, 0, PP_VISIBLE, 0, 0, Nothing, Nothing, 0)
    End Sub

    Public Sub PM_LI_ROW_WRITE_FLUJO_FIRMA_X_K_AUTORIZACION(ByRef PP_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_FLUJO_FIRMA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_MODO_AUTORIZACION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ESTATUS_FIRMA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "N_PASO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "N_DIAS_FLUJO_FIRMA")

        ' A
        PM_LI_ROW_LETRAS(PP_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "A")

        ' B
        PM_LI_ROW_LETRAS(PP_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "B")

        ' C
        PM_LI_ROW_LETRAS(PP_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "C")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "L_PROCESAR")
    End Sub

    Public Sub PM_LI_ROW_LETRAS(ByRef PP_LI_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION As DataGridView, ByVal PP_ROW As Integer, ByRef PP_COLUMNA As Integer, ByRef PP_ROW_DATA As DataRow, ByVal PP_PREFIJO As String)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LI_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, PP_ROW, PP_COLUMNA, PP_ROW_DATA, "ESTATUS_FIRMA" + PP_PREFIJO + "_S_ESTATUS_FIRMA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LI_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, PP_ROW, PP_COLUMNA, PP_ROW_DATA, "ROL" + PP_PREFIJO + "_D_ROL_AUTORIZACION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LI_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, PP_ROW, PP_COLUMNA, PP_ROW_DATA, "USUARIO_FIRMA" + PP_PREFIJO + "_D_USUARIO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LI_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, PP_ROW, PP_COLUMNA, PP_ROW_DATA, "OBSERVACIONES_FIRMA_" + PP_PREFIJO)
    End Sub

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        PM_LI_FORMAT_FLUJO_FIRMA_X_K_AUTORIZACION(LI_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION)
        PM_FI_LOAD("")
        PM_CH_INIT()
        Codigo_ABC.PG_BT_BUSCAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
    End Sub

    Public Sub PM_CARGAR_LI_FLUJO_FIRMA_X_K_AUTORIZACION()
        PM_BUSCAR_FLUJO_FIRMA_X_K_AUTORIZACION(LI_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION, "[dbo].[PG_LI_FLUJO_FIRMA_X_K_AUTORIZACION]")
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

#End Region

#Region "EVENTOS"

    Private Sub Catalogo_T1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT(Me)
        GB_FICHA.Visible = True
    End Sub

    Private Sub BT_BUSCAR_Click(sender As Object, e As EventArgs) Handles BT_LI_BUSCAR.Click
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub BT_SALIR_Click(sender As Object, e As EventArgs) Handles BT_SALIR.Click
        PM_BT_SALIR_CLICK(Me)
    End Sub

    Private Sub CH_A_CheckedChanged(sender As Object, e As EventArgs) Handles CH_A.CheckedChanged
        PM_LI_FORMAT_FLUJO_FIRMA_X_K_AUTORIZACION(LI_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION)
        PM_CARGAR_LI_FLUJO_FIRMA_X_K_AUTORIZACION()
    End Sub

    Private Sub CH_B_CheckedChanged(sender As Object, e As EventArgs) Handles CH_B.CheckedChanged
        PM_LI_FORMAT_FLUJO_FIRMA_X_K_AUTORIZACION(LI_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION)
        PM_CARGAR_LI_FLUJO_FIRMA_X_K_AUTORIZACION()

    End Sub

    Private Sub CH_C_CheckedChanged(sender As Object, e As EventArgs) Handles CH_C.CheckedChanged
        PM_LI_FORMAT_FLUJO_FIRMA_X_K_AUTORIZACION(LI_LISTADO_FLUJO_FIRMA_X_K_AUTORIZACION)
        PM_CARGAR_LI_FLUJO_FIRMA_X_K_AUTORIZACION()
    End Sub

    'LOS BOTONES DE CONTROL VAN A ESTAR DESHABILITADOS INICIALMENTE, HASTA REQUERIR FUNCIONALIDAD   //   AX
    '--==================================================================================
    Private Sub BT_GUARDAR_Click(sender As Object, e As EventArgs) Handles BT_GUARDAR.Click
        'PM_BT_GUARDAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub BT_CANCELAR_Click(sender As Object, e As EventArgs) Handles BT_CANCELAR.Click
        'PM_BT_CANCELAR_CLICK(Me)
    End Sub

    Private Sub BT_AGREGAR_Click(sender As Object, e As EventArgs) Handles BT_AGREGAR.Click
        'PM_BT_AGREGAR_CLICK(Me)
    End Sub

    Private Sub BT_EDITAR_Click(sender As Object, e As EventArgs) Handles BT_EDITAR.Click
        'PM_BT_EDITAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub BT_ELIMINAR_Click(sender As Object, e As EventArgs) Handles BT_ELIMINAR.Click
        'PM_BT_ELIMINAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub BT_LISTADO_Click(sender As Object, e As EventArgs) Handles BT_LISTADO.Click
        'PM_BT_LISTADO_CLICK(Me)
    End Sub

    Private Sub BT_EXPORTAR_EXCEL_Click(sender As Object, e As EventArgs) Handles BT_EXPORTAR_EXCEL.Click
        'PM_BT_EXPORTAR_EXCEL_CLICK(LI_LISTADO)
    End Sub
    '--==================================================================================

    Private Sub TI_RELOJ_Tick(sender As Object, e As EventArgs) Handles TI_RELOJ.Tick
        PM_TI_TICK(LB_RELOJ)
    End Sub

    Private Sub LI_LISTADO_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LI_LISTADO.CellDoubleClick
        If e.RowIndex <> -1 Then
            VL_ID_AUTORIZACION = Convert.ToInt16(LI_LISTADO.CurrentRow.Cells(0).Value)

            Codigo_LI.PG_LI_DOUBLE_CLICK(Me, LI_LISTADO)
            VM_IN_MODO_OPERACION = Modo_Operacion.Listado
            Codigo_FRM.PG_FRM_CONFIG(Me)
            GB_FICHA.Visible = True
            PM_CARGAR_LI_FLUJO_FIRMA_X_K_AUTORIZACION()
        End If
    End Sub
#End Region

#Region "EVENTO CHANGE VALUE DEL COMBO DE RAZÓN SOCIAL"

    Private Sub CB_LI_ZONA_UO_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_LI_ZONA_UO.SelectedValueChanged
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 1, CB_LI_ZONA_UO, New ComboBox, VG_USUARIO_ACCION)
    End Sub

    Private Sub CB_LI_RAZON_SOCIAL_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_LI_RAZON_SOCIAL.SelectedValueChanged
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 0, 1, New ComboBox, CB_LI_RAZON_SOCIAL, VG_USUARIO_ACCION)
    End Sub


#End Region

End Class