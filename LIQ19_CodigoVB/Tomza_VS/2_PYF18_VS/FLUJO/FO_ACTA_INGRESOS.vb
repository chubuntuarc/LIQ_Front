Public Class FO_ACTA_INGRESOS

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0

#End Region

#Region "VARIABLES LOCALES"

    Dim VL_HOY As Date = Now.ToString("dd/MM/yyyy")
    Dim VL_ACT_CONT, VL_ACT_CRE, VL_ACT_COB, VL_ACT_VAL, VL_ACT_ANT, VL_ACT_CONT_KG, VL_ACT_CRE_KG As Decimal

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, MC_F_OPERACION, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MAS_CONTADO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MAS_CREDITO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MAS_COBRANZA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MAS_VALES, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MAS_ANTICIPADA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MAS_CONTADO_KG, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MAS_CREDITO_KG, False)

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MENOS_CONTADO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MENOS_CREDITO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MENOS_COBRANZA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MENOS_VALES, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MENOS_ANTICIPADA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MENOS_CONTADO_KG, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MENOS_CREDITO_KG, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean : Dim VM_CB_VALUE As Integer = Codigo_CB.FG_CB_ITEM_VALUE(CB_UNIDAD_OPERATIVA)
        If VM_CB_VALUE > 0 Then
            Dim LIMITE As Decimal = 1000000000.0

            Dim MAS_CONT As Decimal = Convert.ToDecimal(TB_MAS_CONTADO.Text)
            Dim MAS_CRE As Decimal = Convert.ToDecimal(TB_MAS_CREDITO.Text)
            Dim MAS_COB As Decimal = Convert.ToDecimal(TB_MAS_COBRANZA.Text)
            Dim MAS_VAL As Decimal = Convert.ToDecimal(TB_MAS_VALES.Text)
            Dim MAS_ANT As Decimal = Convert.ToDecimal(TB_MAS_ANTICIPADA.Text)
            Dim MAS_CONT_KG As Decimal = Convert.ToDecimal(TB_MAS_CONTADO_KG.Text)
            Dim MAS_CRE_KG As Decimal = Convert.ToDecimal(TB_MAS_CREDITO_KG.Text)

            Dim MENOS_CONT As Decimal = Convert.ToDecimal(TB_MENOS_CONTADO.Text)
            Dim MENOS_CRE As Decimal = Convert.ToDecimal(TB_MENOS_CREDITO.Text)
            Dim MENOS_COB As Decimal = Convert.ToDecimal(TB_MENOS_COBRANZA.Text)
            Dim MENOS_VAL As Decimal = Convert.ToDecimal(TB_MENOS_VALES.Text)
            Dim MENOS_ANT As Decimal = Convert.ToDecimal(TB_MENOS_ANTICIPADA.Text)
            Dim MENOS_CONT_KG As Decimal = Convert.ToDecimal(TB_MENOS_CONTADO_KG.Text)
            Dim MENOS_CRE_KG As Decimal = Convert.ToDecimal(TB_MENOS_CREDITO_KG.Text)

            If MAS_CONT >= LIMITE Or MAS_CRE >= LIMITE Or MAS_COB >= LIMITE Or MAS_VAL >= LIMITE Or MAS_ANT >= LIMITE Or MENOS_CONT >= LIMITE Or MENOS_CRE >= LIMITE Or MENOS_COB >= LIMITE Or MENOS_VAL >= LIMITE Or MENOS_ANT >= LIMITE Then
                PP_MENSAJE_VALIDACION = "Ninguna cantidad puede ser mayor o igual a 1,000,000,000.00"
            End If
        Else
            PP_MENSAJE_VALIDACION = "Seleccione una Unidad Operativa válida."
        End If
        VP_VALIDACION = (PP_MENSAJE_VALIDACION = "")
        Return VP_VALIDACION
    End Function

    Public Function FM_CONSULTA_ACTA_INGRESOS()
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, MC_F_OPERACION, True)
        Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
        Return VP_PARAMETROS
    End Function

    Public Function FM_OBTENER_NETO(ByVal PP_TB_MONTO As Control, ByVal PP_NUM_VAR As Integer, ByVal PP_SUMA As Boolean) As String
        Dim NETO As Decimal = 0 : Dim MAS, MENOS As Decimal
        If PP_TB_MONTO.Text = "" Then
            PP_TB_MONTO.Text = 0
        End If
        If PP_TB_MONTO.Text <> "." Then
            If PP_SUMA Then
                MAS = Convert.ToDecimal(PP_TB_MONTO.Text)
                Select Case PP_NUM_VAR
                    Case 1 ' Contado
                        NETO = VL_ACT_CONT + MAS
                    Case 2 ' Crédito
                        NETO = VL_ACT_CRE + MAS
                    Case 3 ' Cobranza
                        NETO = VL_ACT_COB + MAS
                    Case 4 ' Vales
                        NETO = VL_ACT_VAL + MAS
                    Case 5 ' Anticipada
                        NETO = VL_ACT_ANT + MAS
                    Case 6 ' Contado Kg
                        NETO = VL_ACT_CONT_KG + MAS
                    Case 7 ' Crédito Kg
                        NETO = VL_ACT_CRE_KG + MAS
                End Select
            Else
                MENOS = Convert.ToDecimal(PP_TB_MONTO.Text)
                Select Case PP_NUM_VAR
                    Case 1 ' Contado
                        NETO = VL_ACT_CONT - MENOS
                    Case 2 ' Crédito
                        NETO = VL_ACT_CRE - MENOS
                    Case 3 ' Cobranza
                        NETO = VL_ACT_COB - MENOS
                    Case 4 ' Vales
                        NETO = VL_ACT_VAL - MENOS
                    Case 5 ' Anticipada
                        NETO = VL_ACT_ANT - MENOS
                    Case 6 ' Contado Kg
                        NETO = VL_ACT_CONT_KG - MENOS
                    Case 7 ' Crédito Kg
                        NETO = VL_ACT_CRE_KG - MENOS
                End Select
            End If
        End If
        Return NETO.ToString("N2")
    End Function

#End Region

#Region "SUB_PM_INIT"

    Private Sub PM_FO_INIT(ByRef PP_FORMA As Object)
        Codigo_FRM.PG_FRM_INIT_FICHA(VM_ID_BASE_DE_DATOS, PP_FORMA)
        GB_FILTROS.Enabled = True
    End Sub

    Public Sub PM_FO_SHOW(ByRef PP_NOMBRE_TABLA As String, ByVal PP_ID_BASE_DE_DATOS As String)
        VM_NOMBRE_TABLA = PP_NOMBRE_TABLA
        VM_ID_BASE_DE_DATOS = PP_ID_BASE_DE_DATOS
        Me.Show()
    End Sub

    Public Sub PM_CB_INIT()
        Codigo_FI.PG_FI_CONTROL_DATA_SETUP(VM_ID_BASE_DE_DATOS, Me)
        Codigo_CB.PG_CB_ZONA_UO_Load(VM_ID_BASE_DE_DATOS, Me, CB_ZONA_UO, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_RAZON_SOCIAL_GASERAS_Load(VM_ID_BASE_DE_DATOS, Me, CB_RAZON_SOCIAL, 1, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_UNIDAD_OPERATIVA, 0, 0, CB_ZONA_UO, CB_RAZON_SOCIAL, VG_USUARIO_ACCION)
    End Sub

    Public Sub PM_TB_INIT()
        Codigo_CTRL.PG_TB_INIT(TB_MAS_CONTADO, 1)
        Codigo_CTRL.PG_TB_INIT(TB_MAS_CREDITO, 1)
        Codigo_CTRL.PG_TB_INIT(TB_MAS_COBRANZA, 1)
        Codigo_CTRL.PG_TB_INIT(TB_MAS_VALES, 1)
        Codigo_CTRL.PG_TB_INIT(TB_MAS_ANTICIPADA, 1)
        Codigo_CTRL.PG_TB_INIT(TB_MAS_CONTADO_KG, 1)
        Codigo_CTRL.PG_TB_INIT(TB_MAS_CREDITO_KG, 1)

        Codigo_CTRL.PG_TB_INIT(TB_MENOS_CONTADO, 1)
        Codigo_CTRL.PG_TB_INIT(TB_MENOS_CREDITO, 1)
        Codigo_CTRL.PG_TB_INIT(TB_MENOS_COBRANZA, 1)
        Codigo_CTRL.PG_TB_INIT(TB_MENOS_VALES, 1)
        Codigo_CTRL.PG_TB_INIT(TB_MENOS_ANTICIPADA, 1)
        Codigo_CTRL.PG_TB_INIT(TB_MENOS_CONTADO_KG, 1)
        Codigo_CTRL.PG_TB_INIT(TB_MENOS_CREDITO_KG, 1)

        Codigo_CTRL.PG_TB_INIT(TB_ACTUAL_CONTADO, 1)
        Codigo_CTRL.PG_TB_INIT(TB_ACTUAL_CREDITO, 1)
        Codigo_CTRL.PG_TB_INIT(TB_ACTUAL_COBRANZA, 1)
        Codigo_CTRL.PG_TB_INIT(TB_ACTUAL_VALES, 1)
        Codigo_CTRL.PG_TB_INIT(TB_ACTUAL_ANTICIPADA, 1)
        Codigo_CTRL.PG_TB_INIT(TB_ACTUAL_CONTADO_KG, 1)
        Codigo_CTRL.PG_TB_INIT(TB_ACTUAL_CREDITO_KG, 1)

        Codigo_CTRL.PG_TB_INIT(TB_NETA_CONTADO, 1)
        Codigo_CTRL.PG_TB_INIT(TB_NETA_CREDITO, 1)
        Codigo_CTRL.PG_TB_INIT(TB_NETA_COBRANZA, 1)
        Codigo_CTRL.PG_TB_INIT(TB_NETA_VALES, 1)
        Codigo_CTRL.PG_TB_INIT(TB_NETA_ANTICIPADA, 1)
        Codigo_CTRL.PG_TB_INIT(TB_NETA_CONTADO_KG, 1)
        Codigo_CTRL.PG_TB_INIT(TB_NETA_CREDITO_KG, 1)

        ' Actual
        TB_ACTUAL_CONTADO.Enabled = False : TB_ACTUAL_CREDITO.Enabled = False : TB_ACTUAL_COBRANZA.Enabled = False
        TB_ACTUAL_VALES.Enabled = False : TB_ACTUAL_ANTICIPADA.Enabled = False : TB_ACTUAL_CONTADO_KG.Enabled = False
        TB_ACTUAL_CREDITO_KG.Enabled = False

        ' Más
        TB_MAS_CONTADO.Text = 0 : TB_MAS_CREDITO.Text = 0 : TB_MAS_COBRANZA.Text = 0
        TB_MAS_VALES.Text = 0 : TB_MAS_ANTICIPADA.Text = 0 : TB_MAS_CONTADO_KG.Text = 0
        TB_MAS_CREDITO_KG.Text = 0

        ' Menos
        TB_MENOS_CONTADO.Text = 0 : TB_MENOS_CREDITO.Text = 0 : TB_MENOS_COBRANZA.Text = 0
        TB_MENOS_VALES.Text = 0 : TB_MENOS_ANTICIPADA.Text = 0 : TB_MENOS_CONTADO_KG.Text = 0
        TB_MENOS_CREDITO_KG.Text = 0

        ' Neta
        TB_NETA_CONTADO.Enabled = False : TB_NETA_CREDITO.Enabled = False : TB_NETA_COBRANZA.Enabled = False
        TB_NETA_VALES.Enabled = False : TB_NETA_ANTICIPADA.Enabled = False : TB_NETA_CONTADO_KG.Enabled = False
        TB_NETA_CREDITO_KG.Enabled = False
    End Sub

    Public Sub PM_FI_LIMPIAR_CAMPOS()
        TB_MAS_CONTADO.Text = 0 : TB_MAS_CREDITO.Text = 0 : TB_MAS_COBRANZA.Text = 0
        TB_MAS_VALES.Text = 0 : TB_MAS_ANTICIPADA.Text = 0 : TB_MAS_CONTADO_KG.Text = 0
        TB_MAS_CREDITO_KG.Text = 0
        '
        TB_MENOS_CONTADO.Text = 0 : TB_MENOS_CREDITO.Text = 0 : TB_MENOS_COBRANZA.Text = 0
        TB_MENOS_VALES.Text = 0 : TB_MENOS_ANTICIPADA.Text = 0 : TB_MENOS_CONTADO_KG.Text = 0
        TB_MENOS_CREDITO_KG.Text = 0

        TB_NETA_CONTADO.Text = "" : TB_NETA_CREDITO.Text = "" : TB_NETA_COBRANZA.Text = ""
        TB_NETA_VALES.Text = "" : TB_NETA_ANTICIPADA.Text = "" : TB_NETA_CONTADO_KG.Text = ""
        TB_NETA_CREDITO_KG.Text = ""
    End Sub

#End Region

#Region "SUBS_PM"

    ''' <summary>
    ''' 'FUNCIÓN QUE CARGARÁ LA PARTE DE LA FICHA
    ''' </summary>
    Public Sub PM_FI_LOAD(ByVal PP_ID As String)
        Codigo_FI.FG_FI_LOAD_X_ID(VM_ID_BASE_DE_DATOS, Me, PP_ID)
        TB_MAS_CONTADO.Select()
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("VENTA_CONTADO", TB_ACTUAL_CONTADO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("VENTA_CREDITO", TB_ACTUAL_CREDITO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("COBRANZA", TB_ACTUAL_COBRANZA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("VENTA_VALEGAS", TB_ACTUAL_VALES, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("VENTA_ANTICIPADA", TB_ACTUAL_ANTICIPADA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("VENTA_CONTADO_KG", TB_ACTUAL_CONTADO_KG, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_CURRENCY("VENTA_CREDITO_KG", TB_ACTUAL_CREDITO_KG, PP_ROW)
        Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)
        PM_CARGAR_VARIABLES_LOCALES()
    End Sub

    Public Sub PM_CARGAR_VARIABLES_LOCALES()
        VL_ACT_CONT = Convert.ToDecimal(TB_ACTUAL_CONTADO.Text)
        VL_ACT_CRE = Convert.ToDecimal(TB_ACTUAL_CREDITO.Text)
        VL_ACT_COB = Convert.ToDecimal(TB_ACTUAL_COBRANZA.Text)
        VL_ACT_VAL = Convert.ToDecimal(TB_ACTUAL_VALES.Text)
        VL_ACT_ANT = Convert.ToDecimal(TB_ACTUAL_ANTICIPADA.Text)
        VL_ACT_CONT_KG = Convert.ToDecimal(TB_ACTUAL_CONTADO_KG.Text)
        VL_ACT_CRE_KG = Convert.ToDecimal(TB_ACTUAL_CREDITO_KG.Text)

        TB_ACTUAL_CONTADO.Text = VL_ACT_CONT.ToString("N2")
        TB_ACTUAL_CREDITO.Text = VL_ACT_CRE.ToString("N2")
        TB_ACTUAL_COBRANZA.Text = VL_ACT_COB.ToString("N2")
        TB_ACTUAL_VALES.Text = VL_ACT_VAL.ToString("N2")
        TB_ACTUAL_ANTICIPADA.Text = VL_ACT_ANT.ToString("N2")
        TB_ACTUAL_CONTADO_KG.Text = VL_ACT_CONT_KG.ToString("N2")
        TB_ACTUAL_CREDITO_KG.Text = VL_ACT_CRE_KG.ToString("N2")
    End Sub

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object)
        Me.Cursor = Cursors.WaitCursor
        Dim VL_DATATABLE As DataTable
        Dim PP_PARAMETROS As String = FM_CONSULTA_ACTA_INGRESOS()
        VL_DATATABLE = Codigo_CON.FG_SP_EXECUTE_DATATABLE(VM_ID_BASE_DE_DATOS, "[PG_SK_LIBRO_INGRESOS_ACTA_X_K_UNIDAD_OPERATIVA]", PP_PARAMETROS)
        PM_FI_LIMPIAR_CAMPOS()
        PM_FI_CARGAR(VL_DATATABLE.Rows(0))
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PM_BT_CANCELAR_CLICK(ByRef PP_FORMA As Object)
        PM_FI_LIMPIAR_CAMPOS()
    End Sub

    Private Sub PM_BT_SALIR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_SALIR_CLICK(PP_FORMA)
    End Sub

    Public Sub PM_BT_GUARDAR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_GUARDAR_ESPECIAL_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "[PG_UP_LIBRO_INGRESOS_ACTA_X_K_UNIDAD_OPERATIVA]")
        PM_TB_INIT()
        PM_BT_BUSCAR_CLICK(PP_FORMA)
    End Sub

    Private Sub PM_TI_TICK(ByRef PP_LABEL As Label)
        Codigo_FRM.PG_TI_TICK(PP_LABEL)
    End Sub

#End Region

#Region "EVENTOS"

    Private Sub Catalogo_T1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT(Me)
        PM_BT_BUSCAR_CLICK(Me)
    End Sub

    Private Sub BT_BUSCAR_Click(sender As Object, e As EventArgs) Handles BT_LI_BUSCAR.Click
        PM_BT_BUSCAR_CLICK(Me)
    End Sub

    Private Sub BT_CANCELAR_Click(sender As Object, e As EventArgs) Handles BT_CANCELAR.Click
        PM_BT_CANCELAR_CLICK(Me)
    End Sub

    Private Sub BT_SALIR_Click(sender As Object, e As EventArgs) Handles BT_SALIR.Click
        PM_BT_SALIR_CLICK(Me)
    End Sub

    Private Sub BT_GUARDAR_Click(sender As Object, e As EventArgs) Handles BT_GUARDAR.Click
        PM_BT_GUARDAR_CLICK(Me)
    End Sub

    Private Sub TI_RELOJ_Tick(sender As Object, e As EventArgs) Handles TI_RELOJ.Tick
        PM_TI_TICK(LB_RELOJ)
    End Sub

    Private Sub CB_UNIDAD_OPERATIVA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_UNIDAD_OPERATIVA.SelectedIndexChanged
        PM_BT_BUSCAR_CLICK(Me)
    End Sub

    Private Sub MC_F_OPERACION_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MC_F_OPERACION.DateChanged
        PM_BT_BUSCAR_CLICK(Me)
    End Sub

#End Region

#Region "EVENTOS TEXTCHANGED PARA CALCULAR LA VENTA NETA"

    Private Sub TB_MAS_CONTADO_TextChanged(sender As Object, e As EventArgs) Handles TB_MAS_CONTADO.TextChanged
        TB_NETA_CONTADO.Text = FM_OBTENER_NETO(TB_MAS_CONTADO, 1, True)
    End Sub

    Private Sub TB_MAS_CREDITO_TextChanged(sender As Object, e As EventArgs) Handles TB_MAS_CREDITO.TextChanged
        TB_NETA_CREDITO.Text = FM_OBTENER_NETO(TB_MAS_CREDITO, 2, True)
    End Sub

    Private Sub TB_MAS_COBRANZA_TextChanged(sender As Object, e As EventArgs) Handles TB_MAS_COBRANZA.TextChanged
        TB_NETA_COBRANZA.Text = FM_OBTENER_NETO(TB_MAS_COBRANZA, 3, True)
    End Sub

    Private Sub TB_MAS_VALES_TextChanged(sender As Object, e As EventArgs) Handles TB_MAS_VALES.TextChanged
        TB_NETA_VALES.Text = FM_OBTENER_NETO(TB_MAS_VALES, 4, True)
    End Sub

    Private Sub TB_MAS_ANTICIPADA_TextChanged(sender As Object, e As EventArgs) Handles TB_MAS_ANTICIPADA.TextChanged
        TB_NETA_ANTICIPADA.Text = FM_OBTENER_NETO(TB_MAS_ANTICIPADA, 5, True)
    End Sub

    Private Sub TB_MAS_CONTADO_KG_TextChanged(sender As Object, e As EventArgs) Handles TB_MAS_CONTADO_KG.TextChanged
        TB_NETA_CONTADO_KG.Text = FM_OBTENER_NETO(TB_MAS_CONTADO_KG, 6, True)
    End Sub

    Private Sub TB_MAS_CREDITO_KG_TextChanged(sender As Object, e As EventArgs) Handles TB_MAS_CREDITO_KG.TextChanged
        TB_NETA_CREDITO_KG.Text = FM_OBTENER_NETO(TB_MAS_CREDITO_KG, 7, True)
    End Sub

    Private Sub TB_MENOS_CONTADO_TextChanged(sender As Object, e As EventArgs) Handles TB_MENOS_CONTADO.TextChanged
        TB_NETA_CONTADO.Text = FM_OBTENER_NETO(TB_MENOS_CONTADO, 1, False)
    End Sub

    Private Sub TB_MENOS_CREDITO_TextChanged(sender As Object, e As EventArgs) Handles TB_MENOS_CREDITO.TextChanged
        TB_NETA_CREDITO.Text = FM_OBTENER_NETO(TB_MENOS_CREDITO, 2, False)
    End Sub

    Private Sub TB_MENOS_COBRANZA_TextChanged(sender As Object, e As EventArgs) Handles TB_MENOS_COBRANZA.TextChanged
        TB_NETA_COBRANZA.Text = FM_OBTENER_NETO(TB_MENOS_COBRANZA, 3, False)
    End Sub

    Private Sub TB_MENOS_VALES_TextChanged(sender As Object, e As EventArgs) Handles TB_MENOS_VALES.TextChanged
        TB_NETA_VALES.Text = FM_OBTENER_NETO(TB_MENOS_VALES, 4, False)
    End Sub

    Private Sub TB_MENOS_ANTICIPADA_TextChanged(sender As Object, e As EventArgs) Handles TB_MENOS_ANTICIPADA.TextChanged
        TB_NETA_ANTICIPADA.Text = FM_OBTENER_NETO(TB_MENOS_ANTICIPADA, 5, False)
    End Sub

    Private Sub TB_MENOS_CONTADO_KG_TextChanged(sender As Object, e As EventArgs) Handles TB_MENOS_CONTADO_KG.TextChanged
        TB_NETA_CONTADO_KG.Text = FM_OBTENER_NETO(TB_MENOS_CONTADO_KG, 6, False)
    End Sub

    Private Sub TB_MENOS_CREDITO_KG_TextChanged(sender As Object, e As EventArgs) Handles TB_MENOS_CREDITO_KG.TextChanged
        TB_NETA_CREDITO_KG.Text = FM_OBTENER_NETO(TB_MENOS_CREDITO_KG, 7, False)
    End Sub

#End Region

#Region "EVENTOS KEYPRESS PARA VALIDAR SOLO NÚMEROS"

    Private Sub TB_MAS_CONTADO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_MAS_CONTADO.KeyPress
        TB_MENOS_CONTADO.Text = 0
    End Sub

    Private Sub TB_MAS_CREDITO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_MAS_CREDITO.KeyPress
        TB_MENOS_CREDITO.Text = 0
    End Sub

    Private Sub TB_MAS_COBRANZA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_MAS_COBRANZA.KeyPress
        TB_MENOS_COBRANZA.Text = 0
    End Sub

    Private Sub TB_MAS_VALES_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_MAS_VALES.KeyPress
        TB_MENOS_VALES.Text = 0
    End Sub

    Private Sub TB_MAS_ANTICIPADA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_MAS_ANTICIPADA.KeyPress
        TB_MENOS_ANTICIPADA.Text = 0
    End Sub

    Private Sub TB_MAS_CONTADO_KG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_MAS_CONTADO_KG.KeyPress
        TB_MENOS_CONTADO_KG.Text = 0
    End Sub

    Private Sub TB_MAS_CREDITO_KG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_MAS_CREDITO_KG.KeyPress
        TB_MENOS_CREDITO_KG.Text = 0
    End Sub

    Private Sub TB_MENOS_CONTADO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_MENOS_CONTADO.KeyPress
        TB_MAS_CONTADO.Text = 0
    End Sub

    Private Sub TB_MENOS_CREDITO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_MENOS_CREDITO.KeyPress
        TB_MAS_CREDITO.Text = 0
    End Sub

    Private Sub TB_MENOS_COBRANZA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_MENOS_COBRANZA.KeyPress
        TB_MAS_COBRANZA.Text = 0
    End Sub

    Private Sub TB_MENOS_VALES_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_MENOS_VALES.KeyPress
        TB_MAS_VALES.Text = 0
    End Sub

    Private Sub TB_MENOS_ANTICIPADA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_MENOS_ANTICIPADA.KeyPress
        TB_MAS_ANTICIPADA.Text = 0
    End Sub

    Private Sub TB_MENOS_CONTADO_KG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_MENOS_CONTADO_KG.KeyPress
        TB_MAS_CONTADO_KG.Text = 0
    End Sub

    Private Sub TB_MENOS_CREDITO_KG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_MENOS_CREDITO_KG.KeyPress
        TB_MAS_CREDITO_KG.Text = 0
    End Sub

#End Region

#Region "EVENTOS CHANGE VALUE DE LOS COMBOS DE ZONA Y RAZÓN SOCIAL"

    Private Sub CB_ZONA_UO_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_ZONA_UO.SelectedValueChanged
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_UNIDAD_OPERATIVA, 0, 0, CB_ZONA_UO, CB_RAZON_SOCIAL, VG_USUARIO_ACCION)
    End Sub

    Private Sub CB_RAZON_SOCIAL_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_RAZON_SOCIAL.SelectedValueChanged
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_UNIDAD_OPERATIVA, 0, 0, CB_ZONA_UO, CB_RAZON_SOCIAL, VG_USUARIO_ACCION)
    End Sub

#End Region

End Class