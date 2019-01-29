Imports PYF18_Finanzas

Public Class FO_FACTURA_CXP

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0

#End Region

#Region "VARIABLES LOCALES"

    Dim VL_HOY As Date = Now.ToString("dd/MM/yyyy")
    Dim VL_INICIO_MES As Date = DateSerial(Year(VL_HOY), Month(VL_HOY) + 0, 1).ToString("dd/MM/yyyy")
    Dim VM_FACT_IDS As ArrayList = New ArrayList()

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_CAPTURA_FACTURA_CXP, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESTATUS_FACTURA_CXP, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIPO_COMPROBANTE, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_F_INICIAL, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_F_FINAL, True)
        Return VP_PARAMETROS
    End Function

    Public Function FM_SQL_GENERAR_INSTRUCCION(ByVal PP_ID_FACT) As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_ID_FACT, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, DT_F_INSTRUCCION, True)
        Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_FACTURA_CXP.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_FACTURA_CXP, False)
            PP_NUEVO = False
        End If

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_C_FACTURA_CXP, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_TIPO_COMPROBANTE, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_RFC_EMISOR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_RFC_RECEPTOR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_F_EMISION, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_SERIE, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_FOLIO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_SUBTOTAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_IVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_TOTAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_CAPTURA_FACTURA_CXP, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ESTATUS_FACTURA_CXP, False)

        Return VP_PARAMETROS
    End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "C_FACTURA_CXP")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_FACTURA_CXP")
        Return VP_ID
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean

        Codigo_FI.PG_FI_FIELDS_VALIDATE(GB_FICHA, VP_VALIDACION, PP_MENSAJE_VALIDACION)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_SUBTOTAL)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_IVA)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_TOTAL)
        Codigo_CTRL.PG_TB_DATE_VALIDATE(PP_MENSAJE_VALIDACION, TB_F_EMISION)

        VP_VALIDACION = (PP_MENSAJE_VALIDACION = "")

        Return VP_VALIDACION
    End Function

    Public Function FM_VALIDAR_TAMANO_ARRAY() As String
        Dim PP_RESPUESTA As String = ""
        Dim VL_TAM As Integer = VM_FACT_IDS.Count
        If VL_TAM = 0 Then
            PP_RESPUESTA = "Seleccione la o las Facturas para generar la Instrucción."
        End If
        Return PP_RESPUESTA
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
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_CAPTURA_FACTURA_CXP, "CAPTURA_FACTURA_CXP")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_ESTATUS_FACTURA_CXP, "ESTATUS_FACTURA_CXP")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_CAPTURA_FACTURA_CXP, "CAPTURA_FACTURA_CXP")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_ESTATUS_FACTURA_CXP, "ESTATUS_FACTURA_CXP")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_TIPO_COMPROBANTE)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_TIPO_COMPROBANTE)
    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
    End Sub

    Public Sub PM_DT_INIT()
        TB_LI_F_INICIAL.Text = VL_INICIO_MES
        TB_LI_F_FINAL.Text = VL_HOY
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
        Codigo_CB.PG_CB_VALUE_LOAD(CB_CAPTURA_FACTURA_CXP, 1)
        PM_DESMARCAR_TODOS_CHECKS(LI_LISTADO)
        PM_LIMPIAR_ARRAY(VM_FACT_IDS)
        PM_AGREGAR_ID_FICHA_A_ARRAY(VM_FACT_IDS)
        TB_RFC_EMISOR.Select()
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_FACTURA_CXP, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_C_FACTURA_CXP, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_RFC_EMISOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_RFC_RECEPTOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_SERIE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_FOLIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_SUBTOTAL, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_TOTAL, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_ABONOS, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_SALDO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_IVA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_F_EMISION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_TIPO_COMPROBANTE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_CAPTURA_FACTURA_CXP, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ESTATUS_FACTURA_CXP, PP_ROW)
        Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)
    End Sub

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 20)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, 
        '            ANCHO_CELDA, ALINEACION, SOLO_LECTURA, Visible, FROZEN, FORMAT
        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "", "", GetType(Integer), 20, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_FACTURA_CXP", "#FCP", GetType(Integer), 85, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "C_FACTURA_CXP", "Comentarios", GetType(String), 300, 1, 0, 1, 1, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "RFC_EMISOR", "RFC Emisor", GetType(String), 120, 2, 0, 1, 1, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "RFC_RECEPTOR", "RFC Receptor", GetType(String), 120, 2, 0, 1, 1, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ESTATUS_FACTURA_CXP", "Estatus", GetType(String), 60, 2, 0, 1, 0, 0, Color.LightSlateGray, Color.Gainsboro, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_CAPTURA_FACTURA_CXP", "Tipo Captura", GetType(String), 60, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_TIPO_COMPROBANTE", "Tipo Doc.", GetType(String), 60, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_EMISION_DDMMMYYYY", "F. Emisión", GetType(Date), 80, 2, 0, 1, 0, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_VENCIMIENTO_DDMMMYYYY", "Fecha", GetType(Date), 120, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "SERIE", "Serie", GetType(String), 60, 2, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "FOLIO", "Folio", GetType(String), 80, 2, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "SUBTOTAL", "Subtotal", GetType(Decimal), 80, 3, 0, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "IVA", "IVA", GetType(Decimal), 80, 3, 0, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "OTROS_IMPUESTOS", "Otros Impuestos", GetType(Decimal), 80, 3, 0, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "TOTAL", "Total", GetType(Decimal), 80, 3, 0, 1, 0, 1, Nothing, Color.LightYellow)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "ABONOS", "Abonos", GetType(Decimal), 80, 3, 0, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "SALDO", "Saldo", GetType(Decimal), 80, 3, 0, 1, 0, 1, Nothing, Color.LightYellow)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_CAPTURA_FACTURA_CXP", "K Captura Factura CXP", GetType(Integer), 50, 2, 0, 0, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_ESTATUS_FACTURA_CXP", "K Estatus Factura CXP", GetType(Integer), 50, 2, 0, 0, 0, 0)
        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)
    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_FACTURA_CXP")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "C_FACTURA_CXP")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "RFC_EMISOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "RFC_RECEPTOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ESTATUS_FACTURA_CXP")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_CAPTURA_FACTURA_CXP")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_TIPO_COMPROBANTE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_EMISION_DDMMMYYYY")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_VENCIMIENTO_DDMMMYYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "SERIE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "FOLIO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "SUBTOTAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "IVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "OTROS_IMPUESTOS")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "TOTAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "ABONOS")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "SALDO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_CAPTURA_FACTURA_CXP")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_ESTATUS_FACTURA_CXP")
        Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)
    End Sub

    Public Sub PM_BT_GENERAR_INSTRUCCION()
        Dim MSJ As String = FM_VALIDAR_TAMANO_ARRAY()
        If MSJ = "" Then
            Dim VP_ERRORES As Boolean = False
            Dim VP_CLAVE As Integer : Dim VP_MENSAJE As String = ""
            Dim VP_CANTIDAD_FACTURAS As Integer = VM_FACT_IDS.Count
            Dim VP_CANTIDAD_ERRORES As Integer = 0
            Dim VP_IDS_FALLADOS As String = ""
            Dim VP_IDS_EXITOSOS As String = ""

            For Each i As Integer In VM_FACT_IDS
                Dim ID As Integer = i
                Dim PP_PARAMETROS As String = FM_SQL_GENERAR_INSTRUCCION(ID)
                Codigo_CON.FG_SQL_EJECUTAR_ACCION(VM_ID_BASE_DE_DATOS, "[PG_PR_INSTRUCCION_X_K_FACTURA_CXP]", PP_PARAMETROS, VP_CLAVE, VP_MENSAJE)
                If VP_MENSAJE <> "" Then
                    VP_ERRORES = True
                    VP_CANTIDAD_ERRORES += 1
                    VP_IDS_FALLADOS += "CXP[# " + ID.ToString + "]" + vbCrLf
                    Codigo_Message.PG_MENSAJE_AVISO(VP_MENSAJE)
                Else
                    VP_IDS_EXITOSOS += "CXP[# " + ID.ToString + "]" + vbCrLf
                End If
            Next

            Dim VP_TXT_MSJ As String = ""

            If VP_ERRORES = False Then
                VP_TXT_MSJ = "La Instrucción fue generada exitosamente y sin errores."
            ElseIf VP_ERRORES = True And (VP_CANTIDAD_ERRORES < VP_CANTIDAD_FACTURAS) Then
                Dim VP_AGREGADOS As Integer = VP_CANTIDAD_FACTURAS - VP_CANTIDAD_ERRORES

                VP_TXT_MSJ = "La Instrucción se generó exitosamente con "

                If VP_AGREGADOS = 1 Then
                    VP_TXT_MSJ += "la siguiente Factura: " + vbCrLf
                ElseIf VP_AGREGADOS > 1 Then
                    VP_TXT_MSJ += "las siguientes Facturas: " + vbCrLf
                End If

                VP_TXT_MSJ += VP_IDS_EXITOSOS
                VP_TXT_MSJ += "y no fue posible agregar "

                If VP_CANTIDAD_ERRORES = 1 Then
                    VP_TXT_MSJ += "la siguiente Factura: " + vbCrLf
                ElseIf VP_CANTIDAD_ERRORES > 1 Then
                    VP_TXT_MSJ += "las siguientes Facturas: " + vbCrLf
                End If

                VP_TXT_MSJ += VP_IDS_FALLADOS
            ElseIf VP_ERRORES = True And (VP_CANTIDAD_ERRORES = VP_CANTIDAD_FACTURAS) Then
                VP_TXT_MSJ = "No fue posible generar la Instrucción."
            End If

            Codigo_Message.PG_MENSAJE_INFORMACION(VP_TXT_MSJ)

            PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
            PM_LIMPIAR_ARRAY(VM_FACT_IDS)
        Else
            Codigo_Message.PG_MENSAJE_AVISO(MSJ)
        End If
    End Sub

    Public Sub PM_LIMPIAR_ARRAY(ByRef PP_ARRAY As ArrayList)
        PP_ARRAY.Clear()
    End Sub

    Public Sub PM_DESMARCAR_TODOS_CHECKS(ByRef PP_LISTADO As DataGridView)
        For Each VP_ROW As DataGridViewRow In PP_LISTADO.Rows
            Dim VP_CHK As DataGridViewCheckBoxCell = VP_ROW.Cells(0)
            VP_CHK.Value = False
        Next
    End Sub

    Public Sub PM_AGREGAR_ID_FICHA_A_ARRAY(ByRef PP_ARRAY As ArrayList)
        If TB_K_FACTURA_CXP.Text <> "" Then
            Dim VP_ID_INS As Integer = Convert.ToInt64(TB_K_FACTURA_CXP.Text)
            PP_ARRAY.Add(VP_ID_INS)
        End If
    End Sub

    Public Sub PM_LI_CELL_CLICK(e As DataGridViewCellEventArgs)
        Dim VL_CHK As DataGridViewCheckBoxCell = LI_LISTADO.Rows(e.RowIndex).Cells(0)
        Dim VL_ID_MOV As Integer = FM_ID_SELECCIONADO(LI_LISTADO, Codigo_LI.FG_LI_ROW_CURRENT(LI_LISTADO))
        'Dim TXT As String = ""
        'MsgBox(VL_ID_MOV.ToString)
        If VL_CHK.Value = True Then
            VL_CHK.Value = False
            VM_FACT_IDS.Remove(VL_ID_MOV)
            LI_LISTADO.CurrentCell = Nothing
        Else
            VL_CHK.Value = True
            VM_FACT_IDS.Add(VL_ID_MOV)
        End If
        'For Each I As Integer In VM_MOV_IDS
        '    TXT += I.ToString + ", "
        'Next
        'MsgBox(TXT)
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

    Private Sub PM_BT_VER_PDF_CLICK(fO_FACTURA_CXP As FO_FACTURA_CXP)
        Dim VP_CUADRO_DE_SALVADO As New SaveFileDialog()
        VP_CUADRO_DE_SALVADO.FileName = TB_K_FACTURA_CXP.Text.ToString() + ".pdf"
        VP_CUADRO_DE_SALVADO.Filter = "PDF (*.pdf*)|*.pdf"

        If VP_CUADRO_DE_SALVADO.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim VP_ORIGEN_PDF As String = "C:\Users\LAURA BARRAZA\Desktop\New folder\" + TB_K_FACTURA_CXP.Text.ToString() + ".pdf"

                System.IO.File.Copy(VP_ORIGEN_PDF, VP_CUADRO_DE_SALVADO.FileName, True)
            Catch ex As Exception
                Codigo_Message.PG_MENSAJE_ERROR_VS("PM_BT_VER_PDF_CLICK")
            End Try
        End If
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
        PM_LIMPIAR_ARRAY(VM_FACT_IDS)
    End Sub

    Private Sub BT_SALIR_Click(sender As Object, e As EventArgs) Handles BT_SALIR.Click
        PM_BT_SALIR_CLICK(Me)
    End Sub

    Private Sub BT_GUARDAR_Click(sender As Object, e As EventArgs) Handles BT_GUARDAR.Click
        PM_BT_GUARDAR_CLICK(Me, LI_LISTADO)
        PM_LIMPIAR_ARRAY(VM_FACT_IDS)
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
        PM_LIMPIAR_ARRAY(VM_FACT_IDS)
    End Sub

    Private Sub BT_EXPORTAR_EXCEL_Click(sender As Object, e As EventArgs) Handles BT_EXPORTAR_EXCEL.Click
        PM_BT_EXPORTAR_EXCEL_CLICK(LI_LISTADO)
    End Sub

    Private Sub BT_GENERAR_INSTRUCCION_Click(sender As Object, e As EventArgs) Handles BT_GENERAR_INSTRUCCION.Click
        PM_BT_GENERAR_INSTRUCCION()
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

    Private Sub BT_VER_PDF_Click(sender As Object, e As EventArgs) Handles BT_VER_PDF.Click
        PM_BT_VER_PDF_CLICK(Me)
    End Sub

#End Region

End Class