Public Class FO_AUTORIZACION

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 3

#End Region

#Region "VARIABLES LOCALES"

    Dim VL_MODO, VL_DIAS_AUT, VL_ROLA, VL_ROLB, VL_ROLC As Integer

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESTATUS_AUTORIZACION, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIPO_AUTORIZACION, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ROL_AUTORIZACION, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_MODO_AUTORIZACION, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        'Dim VP_L_CAPTURA As Integer = 1
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_AUTORIZACION.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_AUTORIZACION, False)
            PP_NUEVO = False
        End If

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_D_AUTORIZACION, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_S_AUTORIZACION, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_C_AUTORIZACION, True)
        '==============================     ================================ 
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ESTATUS_AUTORIZACION, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_TIPO_AUTORIZACION, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LIMITE_INFERIOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LIMITE_SUPERIOR, False)
        '==============================     ================================ PASO 1
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_MODO_AUTORIZACION_P1, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_N_DIAS_AUTORIZACION_P1, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ROL_AUTORIZACION_P1A, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ROL_AUTORIZACION_P1B, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ROL_AUTORIZACION_P1C, False)
        '==============================     ================================ PASO 2
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_MODO_AUTORIZACION_P2, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_N_DIAS_AUTORIZACION_P2, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ROL_AUTORIZACION_P2A, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ROL_AUTORIZACION_P2B, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ROL_AUTORIZACION_P2C, False)
        '==============================     ================================ PASO 3
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_MODO_AUTORIZACION_P3, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_N_DIAS_AUTORIZACION_P3, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ROL_AUTORIZACION_P3A, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ROL_AUTORIZACION_P3B, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ROL_AUTORIZACION_P3C, False)
        '==============================     ================================ PASO 4
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_MODO_AUTORIZACION_P4, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_N_DIAS_AUTORIZACION_P4, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ROL_AUTORIZACION_P4A, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ROL_AUTORIZACION_P4B, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ROL_AUTORIZACION_P4C, False)
        '==============================     ================================ PASO 5
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_MODO_AUTORIZACION_P5, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_N_DIAS_AUTORIZACION_P5, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ROL_AUTORIZACION_P5A, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ROL_AUTORIZACION_P5B, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ROL_AUTORIZACION_P5C, False)

        Return VP_PARAMETROS
    End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "D_AUTORIZACION")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_AUTORIZACION")
        Return VP_ID
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean
        If TB_LIMITE_INFERIOR.Text = "" Then
            TB_LIMITE_INFERIOR.Text = 0
        End If
        If TB_LIMITE_SUPERIOR.Text = "" Then
            TB_LIMITE_SUPERIOR.Text = 0
        End If
        If TB_N_DIAS_AUTORIZACION_P1.Text = "" Then
            TB_N_DIAS_AUTORIZACION_P1.Text = 0
        End If
        If TB_N_DIAS_AUTORIZACION_P2.Text = "" Then
            TB_N_DIAS_AUTORIZACION_P2.Text = 0
        End If
        If TB_N_DIAS_AUTORIZACION_P3.Text = "" Then
            TB_N_DIAS_AUTORIZACION_P3.Text = 0
        End If
        If TB_N_DIAS_AUTORIZACION_P4.Text = "" Then
            TB_N_DIAS_AUTORIZACION_P4.Text = 0
        End If
        If TB_N_DIAS_AUTORIZACION_P5.Text = "" Then
            TB_N_DIAS_AUTORIZACION_P5.Text = 0
        End If
        Codigo_FI.PG_FI_FIELDS_VALIDATE(GB_FICHA, VP_VALIDACION, PP_MENSAJE_VALIDACION)
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

        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ESTATUS_AUTORIZACION, "ESTATUS_AUTORIZACION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_TIPO_AUTORIZACION, "TIPO_AUTORIZACION")
        '==============================     ================================ 
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_MODO_AUTORIZACION_P1, "MODO_AUTORIZACION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ROL_AUTORIZACION_P1A, "ROL_AUTORIZACION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ROL_AUTORIZACION_P1B, "ROL_AUTORIZACION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ROL_AUTORIZACION_P1C, "ROL_AUTORIZACION")
        '==============================     ================================ 
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_MODO_AUTORIZACION_P2, "MODO_AUTORIZACION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ROL_AUTORIZACION_P2A, "ROL_AUTORIZACION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ROL_AUTORIZACION_P2B, "ROL_AUTORIZACION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ROL_AUTORIZACION_P2C, "ROL_AUTORIZACION")
        '==============================     ================================ 
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_MODO_AUTORIZACION_P3, "MODO_AUTORIZACION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ROL_AUTORIZACION_P3A, "ROL_AUTORIZACION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ROL_AUTORIZACION_P3B, "ROL_AUTORIZACION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ROL_AUTORIZACION_P3C, "ROL_AUTORIZACION")
        '==============================     ================================ 
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_MODO_AUTORIZACION_P4, "MODO_AUTORIZACION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ROL_AUTORIZACION_P4A, "ROL_AUTORIZACION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ROL_AUTORIZACION_P4B, "ROL_AUTORIZACION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ROL_AUTORIZACION_P4C, "ROL_AUTORIZACION")
        '==============================     ================================ 
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_MODO_AUTORIZACION_P5, "MODO_AUTORIZACION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ROL_AUTORIZACION_P5A, "ROL_AUTORIZACION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ROL_AUTORIZACION_P5B, "ROL_AUTORIZACION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ROL_AUTORIZACION_P5C, "ROL_AUTORIZACION")
        '==============================     ================================ 
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_ESTATUS_AUTORIZACION, "ESTATUS_AUTORIZACION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_TIPO_AUTORIZACION, "TIPO_AUTORIZACION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_MODO_AUTORIZACION, "MODO_AUTORIZACION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_ROL_AUTORIZACION, "ROL_AUTORIZACION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_USUARIO_ALTA, "USUARIO")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_USUARIO_CAMBIO, "USUARIO")
        '==============================     
        Codigo_CTRL.PG_TB_INIT(TB_LIMITE_INFERIOR, 1)
        Codigo_CTRL.PG_TB_INIT(TB_LIMITE_SUPERIOR, 1)
        '==============================     
        Codigo_CTRL.PG_TB_INIT(TB_N_DIAS_AUTORIZACION_P1, 1)
        Codigo_CTRL.PG_TB_INIT(TB_N_DIAS_AUTORIZACION_P2, 1)
        Codigo_CTRL.PG_TB_INIT(TB_N_DIAS_AUTORIZACION_P3, 1)
        Codigo_CTRL.PG_TB_INIT(TB_N_DIAS_AUTORIZACION_P4, 1)
        Codigo_CTRL.PG_TB_INIT(TB_N_DIAS_AUTORIZACION_P5, 1)
    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
    End Sub

    Public Sub PM_CH_INIT()
        CH_P1.Checked = True : CH_P2.Checked = True : CH_P3.Checked = True
        CH_P4.Checked = True : CH_P5.Checked = True
        CH_MODO.Checked = True : CH_DIAS_AUT.Checked = False : CH_ROLA.Checked = False
        CH_ROLB.Checked = False : CH_ROLC.Checked = False
    End Sub

    Public Sub PM_LI_VALIDAR_CHECKS(ByVal x As Boolean)
        If x = True Then
            If CH_MODO.Checked Then VL_MODO = 1 Else VL_MODO = 0
            If CH_DIAS_AUT.Checked Then VL_DIAS_AUT = 1 Else VL_DIAS_AUT = 0
            If CH_ROLA.Checked Then VL_ROLA = 1 Else VL_ROLA = 0
            If CH_ROLB.Checked Then VL_ROLB = 1 Else VL_ROLB = 0
            If CH_ROLC.Checked Then VL_ROLC = 1 Else VL_ROLC = 0
        Else
            VL_MODO = 0 : VL_DIAS_AUT = 0 : VL_ROLA = 0 : VL_ROLB = 0 : VL_ROLC = 0
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
        Codigo_FI.FG_FI_LOAD_X_ID(VM_ID_BASE_DE_DATOS,  Me, PP_ID)
        TB_D_AUTORIZACION.Select()
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)

        If VM_IN_MODO_OPERACION <> Modo_Operacion.Clon Then
            Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_AUTORIZACION, PP_ROW)
            Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)
        End If

        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_D_AUTORIZACION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_S_AUTORIZACION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_C_AUTORIZACION, PP_ROW)

        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ESTATUS_AUTORIZACION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_TIPO_AUTORIZACION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_LIMITE_INFERIOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_LIMITE_SUPERIOR, PP_ROW)

        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_MODO_AUTORIZACION_P1, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_N_DIAS_AUTORIZACION_P1, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ROL_AUTORIZACION_P1A, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ROL_AUTORIZACION_P1B, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ROL_AUTORIZACION_P1C, PP_ROW)

        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_MODO_AUTORIZACION_P2, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_N_DIAS_AUTORIZACION_P2, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ROL_AUTORIZACION_P2A, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ROL_AUTORIZACION_P2B, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ROL_AUTORIZACION_P2C, PP_ROW)

        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_MODO_AUTORIZACION_P3, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_N_DIAS_AUTORIZACION_P3, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ROL_AUTORIZACION_P3A, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ROL_AUTORIZACION_P3B, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ROL_AUTORIZACION_P3C, PP_ROW)

        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_MODO_AUTORIZACION_P4, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_N_DIAS_AUTORIZACION_P4, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ROL_AUTORIZACION_P4A, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ROL_AUTORIZACION_P4B, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ROL_AUTORIZACION_P4C, PP_ROW)

        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_MODO_AUTORIZACION_P5, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_N_DIAS_AUTORIZACION_P5, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ROL_AUTORIZACION_P5A, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ROL_AUTORIZACION_P5B, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ROL_AUTORIZACION_P5C, PP_ROW)
        PM_FORMATO_DECIMAL()
    End Sub

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2) (OPCIONALES COLOR LETRA, COLOR FONDO, BOLD [0, 1])]
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_AUTORIZACION", "#AUT", GetType(Integer), 40, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_AUTORIZACION", "Descripción", GetType(String), 220, 1, 0, 1, 1, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_TIPO_AUTORIZACION", "Tipo", GetType(String), 60, 2, 0, 1, 1, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ESTATUS_AUTORIZACION", "Estatus", GetType(String), 60, 2, 0, 1, 1, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_AUTORIZACION", "Siglas", GetType(String), 50, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "C_AUTORIZACION", "Comentarios", GetType(String), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "LIMITE_INFERIOR", "Límite Inferior", GetType(Integer), 80, 3, 0, 1, 0, 1, Nothing, Nothing, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "LIMITE_SUPERIOR", "Límite Superior", GetType(Integer), 80, 3, 0, 1, 0, 1, Nothing, Nothing, 0)

        ' PASO 1
        PM_LI_VALIDAR_CHECKS(CH_P1.Checked)
        PM_LI_PASOS("1", "P#1")

        ' PASO 2
        PM_LI_VALIDAR_CHECKS(CH_P2.Checked)
        PM_LI_PASOS("2", "P#2")

        ' PASO 3
        PM_LI_VALIDAR_CHECKS(CH_P3.Checked)
        PM_LI_PASOS("3", "P#3")

        ' PASO 4
        PM_LI_VALIDAR_CHECKS(CH_P4.Checked)
        PM_LI_PASOS("4", "P#4")
        ' PASO 5
        PM_LI_VALIDAR_CHECKS(CH_P5.Checked)
        PM_LI_PASOS("5", "P#5")
#Region "coment"
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "MAU1_D_MODO_AUTORIZACION", "Modo P#1", GetType(String), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "N_DIAS_AUTORIZACION_P1", "Días Autorización", GetType(Integer), 50, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "ROL1A_D_ROL_AUTORIZACION", "Rol-A P#1", GetType(String), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "ROL1B_D_ROL_AUTORIZACION", "Rol-B P#1", GetType(String), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "ROL1C_D_ROL_AUTORIZACION", "Rol-C P#1", GetType(String), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 0)

        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "MAU2_D_MODO_AUTORIZACION", "Modo P#2", GetType(String), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "N_DIAS_AUTORIZACION_P2", "Días Autorización", GetType(Integer), 50, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "ROL2A_D_ROL_AUTORIZACION", "Rol-A P#2", GetType(String), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "ROL2B_D_ROL_AUTORIZACION", "Rol-B P#2", GetType(String), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "ROL2C_D_ROL_AUTORIZACION", "Rol-C P#2", GetType(String), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 0)

        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "MAU3_D_MODO_AUTORIZACION", "Modo P#3", GetType(String), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "N_DIAS_AUTORIZACION_P3", "Días Autorización", GetType(Integer), 50, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "ROL3A_D_ROL_AUTORIZACION", "Rol-A P#3", GetType(String), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "ROL3B_D_ROL_AUTORIZACION", "Rol-B P#3", GetType(String), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "ROL3C_D_ROL_AUTORIZACION", "Rol-C P#3", GetType(String), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 0)

        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "MAU4_D_MODO_AUTORIZACION", "Modo P#4", GetType(String), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "N_DIAS_AUTORIZACION_P4", "Días Autorización", GetType(Integer), 50, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "ROL4A_D_ROL_AUTORIZACION", "Rol-A P#4", GetType(String), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "ROL4B_D_ROL_AUTORIZACION", "Rol-B P#4", GetType(String), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "ROL4C_D_ROL_AUTORIZACION", "Rol-C P#4", GetType(String), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 0)

        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "MAU5_D_MODO_AUTORIZACION", "Modo P#5", GetType(String), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "N_DIAS_AUTORIZACION_P5", "Días Autorización", GetType(Integer), 50, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "ROL5A_D_ROL_AUTORIZACION", "Rol-A P#5", GetType(String), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "ROL5B_D_ROL_AUTORIZACION", "Rol-B P#5", GetType(String), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "ROL5C_D_ROL_AUTORIZACION", "Rol-C P#5", GetType(String), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
#End Region
        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)
    End Sub

    Public Sub PM_LI_PASOS(ByVal PP_PREFIJO As String, ByVal PP_PREFIJO_S As String)
        Codigo_LI.PG_LI_COLUMN_ADD(LI_LISTADO, "MAU" + PP_PREFIJO + "_S_MODO_AUTORIZACION", PP_PREFIJO_S + " Modo", GetType(String), 80, 2, 0, VL_MODO, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(LI_LISTADO, "N_DIAS_AUTORIZACION_P" + PP_PREFIJO, PP_PREFIJO_S + " Días Aut", GetType(Integer), 50, 2, 0, VL_DIAS_AUT, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(LI_LISTADO, "ROL" + PP_PREFIJO + "A_D_ROL_AUTORIZACION" + PP_PREFIJO, PP_PREFIJO_S + " Rol-A", GetType(String), 100, 2, 0, VL_ROLA, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(LI_LISTADO, "ROL" + PP_PREFIJO + "B_D_ROL_AUTORIZACION" + PP_PREFIJO, PP_PREFIJO_S + " Rol-B", GetType(String), 100, 2, 0, VL_ROLB, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(LI_LISTADO, "ROL" + PP_PREFIJO + "C_D_ROL_AUTORIZACION" + PP_PREFIJO, PP_PREFIJO_S + " Rol-C", GetType(String), 100, 2, 0, VL_ROLC, 0, 2)
    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_AUTORIZACION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_AUTORIZACION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_TIPO_AUTORIZACION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ESTATUS_AUTORIZACION")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_AUTORIZACION")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "C_AUTORIZACION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "LIMITE_INFERIOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "LIMITE_SUPERIOR")

        ' Paso 1
        PM_LI_ROW_PASOS(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "1")

        ' Paso 2
        PM_LI_ROW_PASOS(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "2")

        ' Paso 3
        PM_LI_ROW_PASOS(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "3")

        ' Paso 4
        PM_LI_ROW_PASOS(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "4")

        ' Paso 5
        PM_LI_ROW_PASOS(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "5")

#Region "coment2"
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MAU1_D_MODO_AUTORIZACION")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "N_DIAS_AUTORIZACION_P1")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "ROL1A_D_ROL_AUTORIZACION")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "ROL1B_D_ROL_AUTORIZACION")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "ROL1C_D_ROL_AUTORIZACION")

        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MAU2_D_MODO_AUTORIZACION")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "N_DIAS_AUTORIZACION_P2")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "ROL2A_D_ROL_AUTORIZACION")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "ROL2B_D_ROL_AUTORIZACION")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "ROL2C_D_ROL_AUTORIZACION")

        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MAU3_D_MODO_AUTORIZACION")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "N_DIAS_AUTORIZACION_P3")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "ROL3A_D_ROL_AUTORIZACION")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "ROL3B_D_ROL_AUTORIZACION")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "ROL3C_D_ROL_AUTORIZACION")

        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MAU4_D_MODO_AUTORIZACION")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "N_DIAS_AUTORIZACION_P4")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "ROL4A_D_ROL_AUTORIZACION")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "ROL4B_D_ROL_AUTORIZACION")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "ROL4C_D_ROL_AUTORIZACION")

        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MAU5_D_MODO_AUTORIZACION")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "N_DIAS_AUTORIZACION_P5")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "ROL5A_D_ROL_AUTORIZACION")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "ROL5B_D_ROL_AUTORIZACION")
        'Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "ROL5C_D_ROL_AUTORIZACION")
#End Region
        Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)
    End Sub

    Public Sub PM_LI_ROW_PASOS(ByRef PP_LISTADO As DataGridView, ByVal PP_ROW As Integer, ByRef PP_COLUMNA As Integer, ByRef PP_ROW_DATA As DataRow, ByVal PP_PREFIJO As String)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, "MAU" + PP_PREFIJO + "_S_MODO_AUTORIZACION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, "N_DIAS_AUTORIZACION_P" + PP_PREFIJO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, "ROL" + PP_PREFIJO + "A_D_ROL_AUTORIZACION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, "ROL" + PP_PREFIJO + "B_D_ROL_AUTORIZACION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, "ROL" + PP_PREFIJO + "C_D_ROL_AUTORIZACION")
    End Sub

    Public Sub PM_FORMATO_DECIMAL()
        TB_LIMITE_INFERIOR.Text = Format(Convert.ToDecimal(TB_LIMITE_INFERIOR.Text), "0.00")
        TB_LIMITE_SUPERIOR.Text = Format(Convert.ToDecimal(TB_LIMITE_SUPERIOR.Text), "0.00")
    End Sub

    Public Sub PM_CEROS()
        TB_LIMITE_INFERIOR.Text = 0
        TB_LIMITE_SUPERIOR.Text = 0
        TB_N_DIAS_AUTORIZACION_P1.Text = 0
        TB_N_DIAS_AUTORIZACION_P2.Text = 0
        TB_N_DIAS_AUTORIZACION_P3.Text = 0

        TB_N_DIAS_AUTORIZACION_P4.Text = 0
        TB_N_DIAS_AUTORIZACION_P5.Text = 0
    End Sub

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        PM_LI_FORMAT(LI_LISTADO)
        Codigo_ABC.PG_BT_BUSCAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
    End Sub

    Private Sub PM_BT_AGREGAR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_AGREGAR_CLICK(PP_FORMA)
        PM_CEROS()
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

#End Region

End Class