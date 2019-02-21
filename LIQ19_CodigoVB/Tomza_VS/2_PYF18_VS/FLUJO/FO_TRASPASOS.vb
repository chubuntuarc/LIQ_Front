Public Class FO_TRASPASOS

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0

#End Region

#Region "VARIABLES LOCALES"

    Dim VL_HOY As Date = Now.ToString("dd/MM/yyyy")
    Dim VL_AYER As Date = Now.AddDays(-1).ToString("dd/MM/yyyy")
    Dim VM_TRA_IDS As ArrayList = New ArrayList()

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ZONA_UO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIPO_TRASPASO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESTATUS_TRASPASO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_CONCEPTO_TRASPASO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_RUBRO_PRESUPUESTO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_F_INICIAL, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_F_FINAL, True)
        Return VP_PARAMETROS
    End Function

    Public Function FM_SQL_GENERAR_INSTRUCCION(ByVal PP_ID_TRA) As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_ID_TRA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, DT_F_INSTRUCCION, True)
        Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_L_CAPTURA As Integer = 1
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_TRASPASO.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_TRASPASO, False)
            PP_NUEVO = False
        Else
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, 0, False)
        End If

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_D_TRASPASO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_TIPO_TRASPASO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_CONCEPTO_TRASPASO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_RUBRO_PRESUPUESTO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_L_CAPTURA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_C_TRASPASO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MONTO_APLICAR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_F_OPERACION, True)

        Return VP_PARAMETROS
    End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "D_TRASPASO")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_TRASPASO")
        Return VP_ID
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean

        Codigo_FI.PG_FI_FIELDS_VALIDATE(GB_FICHA, VP_VALIDACION, PP_MENSAJE_VALIDACION)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_MONTO_APLICAR)
        Codigo_CTRL.PG_TB_DATE_VALIDATE(PP_MENSAJE_VALIDACION, TB_F_OPERACION)
        Codigo_CTRL.PG_TB_MAYOR_A_CERO(PP_MENSAJE_VALIDACION, TB_MONTO_APLICAR)
        VP_VALIDACION = (PP_MENSAJE_VALIDACION = "")

        Return VP_VALIDACION
    End Function

    Public Function FM_VALIDAR_TAMANO_ARRAY() As String
        Dim PP_RESPUESTA As String = ""
        Dim VL_TAM As Integer = VM_TRA_IDS.Count
        If VL_TAM = 0 Then
            PP_RESPUESTA = "Seleccione el o los Traspasos para generar la Instrucción."
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
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_TIPO_TRASPASO)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_ESTATUS_TRASPASO)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_CONCEPTO_TRASPASO)
        Codigo_CB.PG_CB_RUBRO_PRESUPUESTO_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_RUBRO_PRESUPUESTO, 1, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_ZONA_UO_TODOS_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_ZONA_UO, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 1, CB_LI_ZONA_UO, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_TIPO_TRASPASO)
        Codigo_CB.PG_CB_RUBRO_PRESUPUESTO_Load(VM_ID_BASE_DE_DATOS, Me, CB_RUBRO_PRESUPUESTO, 0, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ESTATUS_TRASPASO)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_CONCEPTO_TRASPASO)
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_UNIDAD_OPERATIVA, 0, 1, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
    End Sub

    Public Sub PM_DT_INIT()
        PM_FECHAS_FILTRO_SEMANA()
    End Sub

    Public Sub PM_FI_DT_INIT()
        If TB_K_TRASPASO.Text = "" Then
            TB_F_OPERACION.Text = VL_HOY
        End If
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
        PM_DESMARCAR_TODOS_CHECKS(LI_LISTADO)
        PM_LIMPIAR_ARRAY(VM_TRA_IDS)
        PM_AGREGAR_ID_FICHA_A_ARRAY(VM_TRA_IDS)
        TB_D_TRASPASO.Select()
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)

        If VM_IN_MODO_OPERACION <> Modo_Operacion.Clon Then
            Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_TRASPASO, PP_ROW)
            Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)
        End If
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_MONTO_APLICAR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_D_TRASPASO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_C_TRASPASO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_TIPO_TRASPASO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("", TB_MONTO_AUTORIZADO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_RUBRO_PRESUPUESTO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ESTATUS_TRASPASO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_CONCEPTO_TRASPASO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_UNIDAD_OPERATIVA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_F_OPERACION, PP_ROW)
    End Sub

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 20)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)]
        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "", "", GetType(Integer), 20, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_TRASPASO", "#TRA", GetType(Integer), 85, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_UNIDAD_OPERATIVA", "Unidad Operativa", GetType(String), 150, 1, 0, 1, 1, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_OPERACION_DDMMMYYYY", "Fecha", GetType(Date), 100, 2, 0, 1, 0, 0, Color.Orange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_RUBRO_PRESUPUESTO", "Rubro Presupuesto", GetType(String), 250, 1, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "MONTO_APLICAR", "Monto Aplicar", GetType(Decimal), 80, 3, 0, 1, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "MONTO_AUTORIZADO", "Monto Autorizado", GetType(Decimal), 80, 3, 0, 1, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ESTATUS_TRASPASO", "Estatus", GetType(String), 80, 2, 0, 1, 0, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_TIPO_TRASPASO", "Tipo Traspaso", GetType(String), 80, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_CONCEPTO_TRASPASO", "Concepto", GetType(String), 100, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_TRASPASO", "Descripción", GetType(Decimal), 150, 1, 0, 1, 0, 1)
        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)
    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_TRASPASO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_OPERACION_DDMMMYYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_RUBRO_PRESUPUESTO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MONTO_APLICAR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MONTO_AUTORIZADO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ESTATUS_TRASPASO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_TIPO_TRASPASO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_CONCEPTO_TRASPASO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_TRASPASO")
        Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)
    End Sub

    Public Sub PM_BT_GENERAR_INSTRUCCION()
        Dim MSJ As String = FM_VALIDAR_TAMANO_ARRAY()
        If MSJ = "" Then
            Dim VP_ERRORES As Boolean = False
            Dim VP_CLAVE As Integer : Dim VP_MENSAJE As String = ""
            Dim VP_CANTIDAD_FACTURAS As Integer = VM_TRA_IDS.Count
            Dim VP_CANTIDAD_ERRORES As Integer = 0
            Dim VP_IDS_FALLADOS As String = ""
            Dim VP_IDS_EXITOSOS As String = ""

            For Each i As Integer In VM_TRA_IDS
                Dim ID As Integer = i
                Dim PP_PARAMETROS As String = FM_SQL_GENERAR_INSTRUCCION(ID)
                Codigo_CON.FG_SQL_EJECUTAR_ACCION(VM_ID_BASE_DE_DATOS, "[PG_PR_INSTRUCCION_X_K_TRASPASO]", PP_PARAMETROS, VP_CLAVE, VP_MENSAJE)
                If VP_MENSAJE <> "" Then
                    VP_ERRORES = True
                    VP_CANTIDAD_ERRORES += 1
                    VP_IDS_FALLADOS += "TRA[# " + ID.ToString + "]" + vbCrLf
                    Codigo_Message.PG_MENSAJE_AVISO(VP_MENSAJE)
                Else
                    VP_IDS_EXITOSOS += "TRA[# " + ID.ToString + "]" + vbCrLf
                End If
            Next

            Dim VP_TXT_MSJ As String = ""

            If VP_ERRORES = False Then
                VP_TXT_MSJ = "La Instrucción fue generada exitosamente y sin errores."
            ElseIf VP_ERRORES = True And (VP_CANTIDAD_ERRORES < VP_CANTIDAD_FACTURAS) Then
                Dim VP_AGREGADOS As Integer = VP_CANTIDAD_FACTURAS - VP_CANTIDAD_ERRORES

                VP_TXT_MSJ = "La Instrucción se generó exitosamente con "

                If VP_AGREGADOS = 1 Then
                    VP_TXT_MSJ += "el siguiente Traspaso: " + vbCrLf
                ElseIf VP_AGREGADOS > 1 Then
                    VP_TXT_MSJ += "los siguientes Traspasos: " + vbCrLf
                End If

                VP_TXT_MSJ += VP_IDS_EXITOSOS
                VP_TXT_MSJ += "y no fue posible agregar "

                If VP_CANTIDAD_ERRORES = 1 Then
                    VP_TXT_MSJ += "el siguiente Traspaso: " + vbCrLf
                ElseIf VP_CANTIDAD_ERRORES > 1 Then
                    VP_TXT_MSJ += "los siguientes Traspasos: " + vbCrLf
                End If

                VP_TXT_MSJ += VP_IDS_FALLADOS
            ElseIf VP_ERRORES = True And (VP_CANTIDAD_ERRORES = VP_CANTIDAD_FACTURAS) Then
                VP_TXT_MSJ = "No fue posible generar la Instrucción."
            End If

            Codigo_Message.PG_MENSAJE_INFORMACION(VP_TXT_MSJ)

            PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
            PM_LIMPIAR_ARRAY(VM_TRA_IDS)
        Else
            Codigo_Message.PG_MENSAJE_AVISO(MSJ)
        End If
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

    Public Sub PM_DESMARCAR_TODOS_CHECKS(ByRef PP_LISTADO As DataGridView)
        For Each VP_ROW As DataGridViewRow In PP_LISTADO.Rows
            Dim VP_CHK As DataGridViewCheckBoxCell = VP_ROW.Cells(0)
            VP_CHK.Value = False
        Next
    End Sub

    Public Sub PM_AGREGAR_ID_FICHA_A_ARRAY(ByRef PP_ARRAY As ArrayList)
        If TB_K_TRASPASO.Text <> "" Then
            Dim VP_ID_INS As Integer = Convert.ToInt32(TB_K_TRASPASO.Text)
            PP_ARRAY.Add(VP_ID_INS)
        End If
    End Sub

    Public Sub PM_LI_CELL_CLICK(e As DataGridViewCellEventArgs)
        Dim VL_CHK As DataGridViewCheckBoxCell = LI_LISTADO.Rows(e.RowIndex).Cells(0)
        Dim VL_ID_MOV As Integer = FM_ID_SELECCIONADO(LI_LISTADO, Codigo_LI.FG_LI_ROW_CURRENT(LI_LISTADO))
        'Dim TXT As String = "" : MsgBox(VL_ID_MOV.ToString)
        If VL_CHK.Value = True Then
            VL_CHK.Value = False
            VM_TRA_IDS.Remove(VL_ID_MOV)
            LI_LISTADO.CurrentCell = Nothing
        Else
            VL_CHK.Value = True
            VM_TRA_IDS.Add(VL_ID_MOV)
        End If
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
        PM_LIMPIAR_ARRAY(VM_TRA_IDS)
    End Sub

    Private Sub BT_SALIR_Click(sender As Object, e As EventArgs) Handles BT_SALIR.Click
        PM_BT_SALIR_CLICK(Me)
    End Sub

    Private Sub BT_GUARDAR_Click(sender As Object, e As EventArgs) Handles BT_GUARDAR.Click
        PM_BT_GUARDAR_CLICK(Me, LI_LISTADO)
        PM_LIMPIAR_ARRAY(VM_TRA_IDS)
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
        PM_LIMPIAR_ARRAY(VM_TRA_IDS)
    End Sub

    Private Sub BT_EXPORTAR_EXCEL_Click(sender As Object, e As EventArgs) Handles BT_EXPORTAR_EXCEL.Click
        PM_BT_EXPORTAR_EXCEL_CLICK(LI_LISTADO)
    End Sub

    Private Sub BT_GENERAR_INSTRUCCION_Click(sender As Object, e As EventArgs) Handles BT_GENERAR_INSTRUCCION.Click
        PM_BT_GENERAR_INSTRUCCION()
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

#Region "EVENTOS CHANGE VALUE DE LOS COMBOS DE ZONA Y RAZÓN SOCIAL"

    Private Sub CB_LI_ZONA_UO_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_LI_ZONA_UO.SelectedValueChanged
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 1, CB_LI_ZONA_UO, New ComboBox, VG_USUARIO_ACCION)
    End Sub

#End Region

End Class