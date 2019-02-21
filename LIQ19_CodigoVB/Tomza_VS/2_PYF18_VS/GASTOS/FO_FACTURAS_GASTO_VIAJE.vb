Imports LIQ19_Liquidaciones

Public Class FO_FACTURAS_GASTO_VIAJE

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0

#End Region

#Region "VARIABLES LOCALES"

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_VIAJE, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_PROVEEDOR_VIATICO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_F_INICIAL, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_F_FINAL, True)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_VIATICO_XML.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_VIATICO_XML, False)
            PP_NUEVO = False
        End If

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_C_VIATICO_XML, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_VIAJE, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_FECHA, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_FOLIO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_FORMAPAGO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_LUGAREXPEDICION, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_METODOPAGO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_MONEDA, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_NOCERTIFICADO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_SERIE, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_SUBTOTAL, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_TIPOCAMBIO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_TIPODECOMPROBANTE, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_TOTAL, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_VERSION, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_EMI_NOMBRE, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_EMI_REGIMENFISCAL, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_EMI_RFC, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_REC_NOMBRE, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_REC_RFC, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_REC_USOCFDI, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_TOTALIMPUESTOSTRASLADADOS, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_IMPORTE, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_IMPUESTO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_TASAOCUOTA, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_TIPOFACTOR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_FECHATIMBRADO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_NOCERTIFICADOSAT, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_VIATICO_XML_UUID, True)

        Return VP_PARAMETROS
    End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "C_VIATICO_XML")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_VIATICO_XML")
        Return VP_ID
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean

        Codigo_FI.PG_FI_FIELDS_VALIDATE(GB_FICHA, VP_VALIDACION, PP_MENSAJE_VALIDACION)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_VIATICO_XML_IMPUESTO)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_VIATICO_XML_SUBTOTAL)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_VIATICO_XML_TOTALIMPUESTOSTRASLADADOS)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_VIATICO_XML_TOTAL)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_VIATICO_XML_IMPORTE)
        Codigo_CTRL.PG_TB_DATE_VALIDATE(PP_MENSAJE_VALIDACION, TB_VIATICO_XML_FECHA)
        Codigo_CTRL.PG_TB_DATE_VALIDATE(PP_MENSAJE_VALIDACION, TB_VIATICO_XML_FECHATIMBRADO)

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
        Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_LI_VIAJE, "")
        Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_VIAJE, "")
        Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_LI_PROVEEDOR_VIATICO, "")

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
        Codigo_FI.FG_FI_LOAD_X_ID(VM_ID_BASE_DE_DATOS, Me, PP_ID)
        CB_VIAJE.Select()
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_C_VIATICO_XML, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_VIAJE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("VIATICO_XML_Fecha", TB_VIATICO_XML_FECHA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_VIATICO_XML_FOLIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_VIATICO_XML_FORMAPAGO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_VIATICO_XML_LUGAREXPEDICION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_VIATICO_XML_METODOPAGO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_VIATICO_XML_MONEDA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_VIATICO_XML_NOCERTIFICADO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_VIATICO_XML_SERIE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_VIATICO_XML_SUBTOTAL, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_VIATICO_XML_TIPOCAMBIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_VIATICO_XML_TIPODECOMPROBANTE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_VIATICO_XML_TOTAL, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_VIATICO_XML_VERSION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_VIATICO_XML_EMI_NOMBRE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_VIATICO_XML_EMI_REGIMENFISCAL, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_VIATICO_XML_EMI_RFC, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_VIATICO_XML_REC_NOMBRE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_VIATICO_XML_REC_RFC, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_VIATICO_XML_REC_USOCFDI, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_VIATICO_XML_TOTALIMPUESTOSTRASLADADOS, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_VIATICO_XML_IMPORTE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_VIATICO_XML_IMPUESTO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_VIATICO_XML_TASAOCUOTA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_VIATICO_XML_TIPOFACTOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("VIATICO_XML_FechaTimbrado", TB_VIATICO_XML_FECHATIMBRADO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_VIATICO_XML_NOCERTIFICADOSAT, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_VIATICO_XML_UUID, PP_ROW)

    End Sub

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 20)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, 
        '            ANCHO_CELDA, ALINEACION, SOLO_LECTURA, Visible, FROZEN, FORMAT
        'Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "", "", GetType(Integer), 20, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_VIAJE", "#Vi", GetType(Integer), 60, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_VIATICO_XML", "#FCP", GetType(Integer), 60, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "C_VIATICO_XML", "Nombre Archivo", GetType(String), 300, 1, 0, 1, 1, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "VIATICO_XML_EMI_Rfc", "RFC Emisor", GetType(String), 120, 2, 0, 1, 1, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "VIATICO_XML_REC_Rfc", "RFC Receptor", GetType(String), 120, 2, 0, 1, 1, 0, Color.DarkOrange, Nothing, 1)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ESTATUS_FACTURA_CXP", "Estatus", GetType(String), 60, 2, 0, 1, 0, 0, Color.LightSlateGray, Color.Gainsboro, 1)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_CAPTURA_FACTURA_CXP", "Tipo Captura", GetType(String), 60, 2, 0, 1, 0, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_TIPO_COMPROBANTE", "Tipo Doc.", GetType(String), 60, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_VIATICO_DDMMMYYYY", "F. Emisión", GetType(Date), 80, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_TIMBRADO_DDMMMYYYY", "F. Timbrado", GetType(Date), 80, 2, 0, 1, 0, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_VENCIMIENTO_DDMMMYYYY", "Fecha", GetType(Date), 120, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "VIATICO_XML_Serie", "Serie", GetType(String), 60, 2, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "VIATICO_XML_Folio", "Folio", GetType(String), 80, 2, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "VIATICO_XML_SubTotal", "Subtotal", GetType(Decimal), 80, 3, 0, 1, 0, 1)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "IVA", "IVA", GetType(Decimal), 80, 3, 0, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "VIATICO_XML_TotalImpuestosTrasladados", "Otros Impuestos", GetType(Decimal), 80, 3, 0, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "VIATICO_XML_Total", "Total", GetType(Decimal), 80, 3, 0, 1, 0, 1, Nothing, Color.LightYellow)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "ABONOS", "Abonos", GetType(Decimal), 80, 3, 0, 1, 0, 1)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "SALDO", "Saldo", GetType(Decimal), 80, 3, 0, 1, 0, 1, Nothing, Color.LightYellow)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_CAPTURA_FACTURA_CXP", "K Captura Factura CXP", GetType(Integer), 50, 2, 0, 0, 0, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_ESTATUS_FACTURA_CXP", "K Estatus Factura CXP", GetType(Integer), 50, 2, 0, 0, 0, 0)
        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)
    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_VIAJE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_VIATICO_XML")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "C_VIATICO_XML")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "VIATICO_XML_EMI_Rfc")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "VIATICO_XML_REC_Rfc")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_VIATICO_DDMMMYYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_TIMBRADO_DDMMMYYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "VIATICO_XML_Serie")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "VIATICO_XML_Folio")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "VIATICO_XML_SubTotal")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "VIATICO_XML_TotalImpuestosTrasladados")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "VIATICO_XML_Total")

        Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)
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

    Public Sub PM_MODO_AUXILIAR()

    End Sub

    'Private Sub PM_BT_VER_PDF_CLICK(FO_GASTO_VIATICO_XML As FO_FACTURAS_GASTO_VIAJE)
    '    Dim VP_CUADRO_DE_SALVADO As New SaveFileDialog()
    '    VP_CUADRO_DE_SALVADO.FileName = TB_K_VIATICO_XML.Text.ToString() + ".pdf"
    '    VP_CUADRO_DE_SALVADO.Filter = "PDF (*.pdf*)|*.pdf"

    '    If VP_CUADRO_DE_SALVADO.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        Try
    '            Dim VP_ORIGEN_PDF As String = "C:\FACTURAS\VIAJE\" + TB_K_VIATICO_XML.Text.ToString() + ".pdf"

    '            System.IO.File.Copy(VP_ORIGEN_PDF, VP_CUADRO_DE_SALVADO.FileName, True)
    '        Catch ex As Exception
    '            Codigo_Message.PG_MENSAJE_ERROR_VS("PM_BT_VER_PDF_CLICK")
    '        End Try
    '    End If
    'End Sub

#End Region

#Region "EVENTOS"

    Private Sub Catalogo_T1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT(Me)
    End Sub

    Private Sub BT_AGREGAR_Click(sender As Object, e As EventArgs) Handles BT_AGREGAR.Click
        'PM_BT_AGREGAR_CLICK(Me)
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
            Codigo_LI.PG_LI_DOUBLE_CLICK(Me, LI_LISTADO)
        End If
    End Sub

    Private Sub BT_VER_PDF_Click(sender As Object, e As EventArgs) Handles BT_VER_PDF.Click
        'PM_BT_VER_PDF_CLICK(Me)
    End Sub

#End Region

End Class