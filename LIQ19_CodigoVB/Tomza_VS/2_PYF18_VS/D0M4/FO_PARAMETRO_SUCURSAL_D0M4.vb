Imports System.Text

Public Class FO_PARAMETRO_SUCURSAL_D0M4
#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_DATAGRID As New DataGridView

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ZONA_UO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIEMPO_YYYY, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIEMPO_MES, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_PARAMETRO_SUCURSAL_D0M4.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_PARAMETRO_SUCURSAL_D0M4, False)
            PP_NUEVO = False
        End If
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_D_PARAMETRO_SUCURSAL_D0M4, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_TIEMPO_YYYY, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_MES, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_P2016_DTO_DESCUENTO_X_KG, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_DESCUENTO_CONTADO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_DESCUENTO_CREDITO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_P2023_PCN, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_P1003_VENTA_KG_CONTADO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_P1004_VENTA_KG_CREDITO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_P1012_CARTERA_CYC_INICIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_P1013_CARTERA_CYC_FINAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_COBRANZA_HOLGURA, False)

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PERFIL_VENTA_CONTADO_1_LUNES, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PERFIL_VENTA_CONTADO_2_MARTES, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PERFIL_VENTA_CONTADO_3_MIERCOLES, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PERFIL_VENTA_CONTADO_4_JUEVES, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PERFIL_VENTA_CONTADO_5_VIERNES, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PERFIL_VENTA_CONTADO_6_SABADO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PERFIL_VENTA_CONTADO_7_DOMINGO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PERFIL_VENTA_CREDITO_1_LUNES, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PERFIL_VENTA_CREDITO_2_MARTES, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PERFIL_VENTA_CREDITO_3_MIERCOLES, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PERFIL_VENTA_CREDITO_4_JUEVES, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PERFIL_VENTA_CREDITO_5_VIERNES, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PERFIL_VENTA_CREDITO_6_SABADO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PERFIL_VENTA_CREDITO_7_DOMINGO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PERFIL_COBRANZA_1_LUNES, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PERFIL_COBRANZA_2_MARTES, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PERFIL_COBRANZA_3_MIERCOLES, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PERFIL_COBRANZA_4_JUEVES, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PERFIL_COBRANZA_5_VIERNES, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PERFIL_COBRANZA_6_SABADO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PERFIL_COBRANZA_7_DOMINGO, False)
        Return VP_PARAMETROS

    End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "D_PARAMETRO_SUCURSAL_D0M4")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_PARAMETRO_SUCURSAL_D0M4")
        Return VP_ID
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean

        Codigo_FI.PG_FI_FIELDS_VALIDATE(GB_FICHA, VP_VALIDACION, PP_MENSAJE_VALIDACION)

        'Codigo_CTRL.PG_TB_INTEGER_VALIDATE(PP_MENSAJE_VALIDACION, TB_O_DOCUMENTO_D0M4)


        VP_VALIDACION = (PP_MENSAJE_VALIDACION = "")

        Return VP_VALIDACION
    End Function

    Public Function FM_LI_DATA_VALIDATE(ByRef PP_LISTADO As DataGridView) As Boolean
        'Dim VP_INDR As Integer
        'Dim VP_RESULTADO As Boolean = False
        'For Each VP_FILA In PP_LISTADO.Rows
        'VP_INDR = VP_FILA.Index
        'Dim VP_DATO As String = PP_LISTADO.Rows(VP_INDR).Cells("Modificado").Value
        'If VP_DATO = 1 Then
        'Return True
        'End If
        'Next
        'Return False
    End Function

    Public Function FM_LI_SQL_SAVE(ByVal PP_LI_LISTADO As DataGridView, ByVal PP_INDR As Integer) As String
        Dim VP_PARAMETROS As String = ""

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("K_PARAMETRO_SUCURSAL_D0M4"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("D_PARAMETRO_SUCURSAL_D0M4"), True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("K_UNIDAD_OPERATIVA"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("K_YYYY"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("K_MM"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("P2016_DTO_DESCUENTO_X_KG"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("DESCUENTO_CONTADO"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("DESCUENTO_CREDITO"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("P2023_PCN"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("P1003_VENTA_KG_CONTADO"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("P1004_VENTA_KG_CREDITO"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("P1012_CARTERA_CYC_INICIAL"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("P1013_CARTERA_CYC_FINAL"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("COBRANZA_HOLGURA"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("PERFIL_VENTA_CONTADO_1_LUNES"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("PERFIL_VENTA_CONTADO_2_MARTES"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("PERFIL_VENTA_CONTADO_3_MIERCOLES"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("PERFIL_VENTA_CONTADO_4_JUEVES"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("PERFIL_VENTA_CONTADO_5_VIERNES"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("PERFIL_VENTA_CONTADO_6_SABADO"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("PERFIL_VENTA_CONTADO_7_DOMINGO"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("PERFIL_VENTA_CREDITO_1_LUNES"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("PERFIL_VENTA_CREDITO_2_MARTES"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("PERFIL_VENTA_CREDITO_3_MIERCOLES"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("PERFIL_VENTA_CREDITO_4_JUEVES"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("PERFIL_VENTA_CREDITO_5_VIERNES"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("PERFIL_VENTA_CREDITO_6_SABADO"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("PERFIL_VENTA_CREDITO_7_DOMINGO"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("PERFIL_COBRANZA_1_LUNES"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("PERFIL_COBRANZA_2_MARTES"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("PERFIL_COBRANZA_3_MIERCOLES"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("PERFIL_COBRANZA_4_JUEVES"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("PERFIL_COBRANZA_5_VIERNES"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("PERFIL_COBRANZA_6_SABADO"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("PERFIL_COBRANZA_7_DOMINGO"), False)
        Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

        Return VP_PARAMETROS

    End Function

#End Region

#Region "SUB_PM_INIT"

    Public Sub PM_FO_SHOW(ByRef PP_NOMBRE_TABLA As String, ByVal PP_ID_BASE_DE_DATOS As String)

        VM_NOMBRE_TABLA = PP_NOMBRE_TABLA
        VM_ID_BASE_DE_DATOS = PP_ID_BASE_DE_DATOS
        Show()
    End Sub

    Public Sub PM_CB_INIT()
        Codigo_FI.PG_FI_CONTROL_DATA_SETUP(VM_ID_BASE_DE_DATOS, Me)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_TIEMPO_MES, "MES")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_ZONA_UO, "ZONA_UO")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_TIEMPO_YYYY, "TIEMPO_YYYY")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_UNIDAD_OPERATIVA, "UNIDAD_OPERATIVA")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_USUARIO_ALTA, "USUARIO")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_USUARIO_CAMBIO, "USUARIO")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_UNIDAD_OPERATIVA, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_TIEMPO_YYYY, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_MES, "")
    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
        VM_DATAGRID.AllowUserToAddRows = False
        PM_LI_FORMAT(VM_DATAGRID)
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
        'CB_UNIDAD_OPERATIVA.Select()
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_PARAMETRO_SUCURSAL_D0M4, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_D_PARAMETRO_SUCURSAL_D0M4, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_P2016_DTO_DESCUENTO_X_KG, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_DESCUENTO_CREDITO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_DESCUENTO_CONTADO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_P2023_PCN, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_P1003_VENTA_KG_CONTADO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_P1004_VENTA_KG_CREDITO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_P2023_PCN, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_P1013_CARTERA_CYC_FINAL, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_P1012_CARTERA_CYC_INICIAL, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_COBRANZA_HOLGURA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PERFIL_VENTA_CONTADO_1_LUNES, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PERFIL_VENTA_CONTADO_2_MARTES, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PERFIL_VENTA_CONTADO_3_MIERCOLES, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PERFIL_VENTA_CONTADO_4_JUEVES, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PERFIL_VENTA_CONTADO_5_VIERNES, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PERFIL_VENTA_CONTADO_6_SABADO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PERFIL_VENTA_CONTADO_7_DOMINGO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PERFIL_VENTA_CREDITO_1_LUNES, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PERFIL_VENTA_CREDITO_2_MARTES, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PERFIL_VENTA_CREDITO_3_MIERCOLES, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PERFIL_VENTA_CREDITO_4_JUEVES, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PERFIL_VENTA_CREDITO_5_VIERNES, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PERFIL_VENTA_CREDITO_6_SABADO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PERFIL_VENTA_CREDITO_7_DOMINGO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PERFIL_COBRANZA_1_LUNES, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PERFIL_COBRANZA_2_MARTES, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PERFIL_COBRANZA_3_MIERCOLES, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PERFIL_COBRANZA_4_JUEVES, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PERFIL_COBRANZA_5_VIERNES, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PERFIL_COBRANZA_6_SABADO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PERFIL_COBRANZA_7_DOMINGO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_USUARIO_ALTA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_USUARIO_CAMBIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_F_ALTA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_F_CAMBIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_UNIDAD_OPERATIVA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_TIEMPO_YYYY, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_MES, PP_ROW)
        Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)

    End Sub

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, 
        '            ANCHO_CELDA, ALINEACION, SOLO_LECTURA, Visible, FROZEN, FORMAT
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_PARAMETRO_SUCURSAL_D0M4", "ID", GetType(Integer), 80, 1, 1, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_PARAMETRO_SUCURSAL_D0M4", "DESCRIPCION", GetType(Integer), 80, 1, 1, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_UNIDAD_OPERATIVA", "ID UNIDAD OPERATIVA", GetType(String), 80, 1, 1, 0, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_UNIDAD_OPERATIVA", "UNIDAD OPERATIVA", GetType(String), 80, 1, 1, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_YYYY", "AÑO", GetType(Integer), 80, 1, 1, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_MM", "MES", GetType(Integer), 80, 1, 1, 0, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_MES", "MES", GetType(Integer), 80, 1, 1, 1, 1, 0)
        'Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_DOCUMENTO_D0M4", "DESCRIPCION", GetType(String), 170, 1, 1, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "P2016_DTO_DESCUENTO_X_KG", "DESCUENTO X KG", GetType(Decimal), 100, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DESCUENTO_CONTADO", "DESCUENTO DE CONTADO", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DESCUENTO_CREDITO", "DESCUENTO DE CREDITO", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "P2023_PCN", "PCN", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "P1003_VENTA_KG_CONTADO", "VENTA KG CONTADO", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "P1004_VENTA_KG_CREDITO", "VENTA KG CREDITO", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "P1012_CARTERA_CYC_INICIAL", "CARTERA CYC INICIAL", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "P1013_CARTERA_CYC_FINAL", "CARTERA CYC FINAL", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "COBRANZA_HOLGURA", "COBRANZA HOLGURA", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CONTADO_1_LUNES", "VENTA CONTADO LUNES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CONTADO_2_MARTES", "VENTA CONTADO MARTES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CONTADO_3_MIERCOLES", "VENTA CONTADO MIERCOLES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CONTADO_4_JUEVES", "VENTA CONTADO JUEVES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CONTADO_5_VIERNES", "VENTA CONTADO VIERNES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CONTADO_6_SABADO", "VENTA CONTADO SABADO", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CONTADO_7_DOMINGO", "VENTA CONTADO DOMINGO", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CREDITO_1_LUNES", "VENTA CREDITO LUNES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CREDITO_2_MARTES", "VENTA CREDITO MARTES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CREDITO_3_MIERCOLES", "VENTA CREDITO MIERCOLES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CREDITO_4_JUEVES", "VENTA CREDITO JUEVES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CREDITO_5_VIERNES", "VENTA CREDITO VIERNES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CREDITO_6_SABADO", "VENTA CREDITO SABADO", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CREDITO_7_DOMINGO", "VENTA CREDITO DOMINGO", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_COBRANZA_1_LUNES", "COBRANZA LUNES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_COBRANZA_2_MARTES", "COBRANZA MARTES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_COBRANZA_3_MIERCOLES", "COBRANZA MIERCOLES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_COBRANZA_4_JUEVES", "COBRANZA JUEVES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_COBRANZA_5_VIERNES", "COBRANZA VIERNES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_COBRANZA_6_SABADO", "COBRANZA SABADO", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_COBRANZA_7_DOMINGO", "COBRANZA DOMINGO", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "Modificado", "Modificado", GetType(Integer), 90, 3, 1, 1, 0, 0)
    End Sub

    Public Shared Sub PM_LI_ESCRIBE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_PARAMETRO_SUCURSAL_D0M4")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_PARAMETRO_SUCURSAL_D0M4")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_YYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_MM")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_MES")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "P2016_DTO_DESCUENTO_X_KG")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DESCUENTO_CONTADO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DESCUENTO_CREDITO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "P2023_PCN")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "P1003_VENTA_KG_CONTADO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "P1004_VENTA_KG_CREDITO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "P1012_CARTERA_CYC_INICIAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "P1013_CARTERA_CYC_FINAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "COBRANZA_HOLGURA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PERFIL_VENTA_CONTADO_1_LUNES")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PERFIL_VENTA_CONTADO_2_MARTES")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PERFIL_VENTA_CONTADO_3_MIERCOLES")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PERFIL_VENTA_CONTADO_4_JUEVES")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PERFIL_VENTA_CONTADO_5_VIERNES")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PERFIL_VENTA_CONTADO_6_SABADO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PERFIL_VENTA_CONTADO_7_DOMINGO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PERFIL_VENTA_CREDITO_1_LUNES")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PERFIL_VENTA_CREDITO_2_MARTES")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PERFIL_VENTA_CREDITO_3_MIERCOLES")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PERFIL_VENTA_CREDITO_4_JUEVES")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PERFIL_VENTA_CREDITO_5_VIERNES")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PERFIL_VENTA_CREDITO_6_SABADO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PERFIL_VENTA_CREDITO_7_DOMINGO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PERFIL_COBRANZA_1_LUNES")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PERFIL_COBRANZA_2_MARTES")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PERFIL_COBRANZA_3_MIERCOLES")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PERFIL_COBRANZA_4_JUEVES")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PERFIL_COBRANZA_5_VIERNES")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PERFIL_COBRANZA_6_SABADO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PERFIL_COBRANZA_7_DOMINGO")
        Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)
        Codigo_LI.PG_LI_ROW_EDIT(PP_LISTADO, VP_ROW, False)
        If PP_ROW_DATA.Table.Columns.Contains("Modificado") Then
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "Modificado")

            Codigo_LI.PG_LI_ROW_COLOR_CHANGE(PP_LISTADO, VP_ROW, Color.Red)
        Else
            Codigo_LI.PG_LI_CELL_ZERO_FILL(PP_LISTADO, VP_ROW)
        End If
        'Codigo_LI.PG_LI_CELL_ZERO_FILL(PP_LISTADO, VP_ROW)
    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_DATA As DataRow
        Dim VP_TABLA_TEMP As New DataTable

        If VM_DATAGRID.Rows.Count = 0 Then
            VP_DATA = PP_ROW_DATA
        Else
            VP_TABLA_TEMP = Codigo_Tabla.FG_TABLA_TEMPORAL()
            For Each VP_ROW As DataGridViewRow In VM_DATAGRID.Rows

                If VP_ROW.Cells("K_PARAMETRO_SUCURSAL_D0M4").Value = PP_ROW_DATA("K_PARAMETRO_SUCURSAL_D0M4") Then
                    Dim VP_DATA_ROW As DataRow = VP_TABLA_TEMP.NewRow()
                    For Each VP_CELL As DataGridViewCell In VP_ROW.Cells
                        VP_DATA_ROW(VP_CELL.ColumnIndex) = VP_ROW.Cells(VP_CELL.ColumnIndex).Value
                    Next
                    VP_DATA = VP_DATA_ROW
                End If
                If VP_DATA Is Nothing Then
                    VP_DATA = PP_ROW_DATA
                End If

            Next
        End If
        PM_LI_ESCRIBE(PP_LISTADO, VP_DATA)
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
        BT_GUARDAR.Enabled = False
    End Sub

    Public Sub PM_BT_GUARDAR_CLICK(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)

        Codigo_ABC.PG_LI_SAVE(PP_FORMA, PP_LISTADO)
        BT_GUARDAR.Enabled = False
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
        Dim VP_PARAMETROS As String = ""
        Dim VP_FILA As DataGridViewRow
        Dim VP_EXITO As Boolean
        Dim VP_TABLA As New DataTable
        Dim VP_IND As Integer
        Dim VP_INDICES As New List(Of Integer)
        Dim VP_MENSAJE As String = ""
        Dim VP_RESULTADO As DataTable
        Dim VP_VALIDATION As Boolean
        Dim VP_PARAMETROS_ARRAY As Array
        Dim VP_CONT As Integer
        Dim VP_VALOR As Integer

        Dim VP_INDR As Integer

        Try
            VP_RESULTADO = Codigo_Tabla.FG_TABLA_RESULTADOS()
            For Each VP_FILA In PP_LISTADO.Rows
                VP_INDR = VP_FILA.Index
                Dim VP_DATO As String = Codigo_LI.FG_LI_CELL_VALUE(PP_LISTADO, VP_INDR, "Modificado")
                If VP_DATO = 1 Then
                    Dim VP_NUEVO_ROW As DataRow = VP_RESULTADO.NewRow()
                    VP_PARAMETROS = FM_LI_SQL_SAVE(PP_LISTADO, VP_INDR)
                    Codigo_LI.PG_LI_ROW_ADD(PP_FORMA.VM_DATAGRID)
                    Codigo_Tabla.PG_ROW_CLONE(VP_FILA, PP_FORMA.VM_DATAGRID.Rows(PP_FORMA.VM_DATAGRID.Rows.Count - 1))

                    '*** Bloque que evalua cada celda para revisar si en algun momento alguna regla de validacion se cumple ***

                    'For Each VP_CELL In VP_FILA.Cells
                    'VP_VALIDATION = Codigo_LI.PG_LI_CELL_VALIDATE(VP_CELL)
                    'If VP_VALIDATION Then
                    'Exit For
                    'End If
                    'Next

                    Dim VP_SP As String
                    VP_SP = Codigo_CON.FG_SQL_UPDATE(PP_FORMA)

                    '*** Si la regla de validacion no se cumple debe de ejecutar el query de forma normal ***
                    VP_TABLA = Codigo_CON.FG_SP_EXECUTE_DATATABLE(VM_ID_BASE_DE_DATOS, VP_SP, VP_PARAMETROS)

                    '*** Si se cumple entonces no lo enviamos a ejecutar pero creamos un row en la datatable para seguir usando la funcionalidad de Olivo ***
                    'VP_PARAMETROS_ARRAY = VP_PARAMETROS.Split(New Char() {","c}) 

                    '*** Si es la primera vez que se crea el datatable del log de ejecucion entonces agregamos las columnas que normalmente
                    '*** se agregan cuando se obtiene el resultado desde SQL

                    'If (VP_CONT = 0) Then
                    'VP_TABLA.Columns.Add("CLAVE")
                    'VP_TABLA.Columns.Add("MENSAJE")
                    'VP_TABLA.Columns.Add("AFECTADO")
                    'VP_CONT = 1
                    'End If

                    'Creamos el row de error con un mensaje de error y el parametro bandera (0,1) que hace que la columna de afectado diga Si o No
                    'VP_TABLA.Rows.Add({VP_PARAMETROS_ARRAY.GetValue(3), "CUSTOM ERROR", 0})

                    VP_IND = Codigo_LI.FG_LI_CELL_READ(VP_TABLA, 0, "CLAVE")
                    VP_MENSAJE = Codigo_LI.FG_LI_CELL_READ(VP_TABLA, 0, "MENSAJE")
                    VP_EXITO = Codigo_LI.FG_LI_CELL_READ(VP_TABLA, 0, "AFECTADO")

                    'VP_NUEVO_ROW(0) = VP_PARAMETROS_ARRAY.GetValue(3) La fila no viene de sql entonces hubo un error 
                    'y por lo tanto el id lo escribimos manualmente

                    VP_NUEVO_ROW(0) = VP_IND
                    VP_NUEVO_ROW(2) = VP_MENSAJE
                    VP_RESULTADO.Rows.Add(VP_NUEVO_ROW)

                    If VP_EXITO Then
                        VP_INDICES.Add(VP_IND)
                        VP_NUEVO_ROW(1) = "SI"
                    Else
                        VP_NUEVO_ROW(1) = "NO"
                    End If

                End If
            Next

            Dim VP_FORMA As New Resultado()
            VP_FORMA.PM_FO_SHOW(VP_RESULTADO)
            VP_FORMA.ShowDialog()

            If VP_INDICES.Count > 0 Then
                For Each VP_ITEM As Integer In VP_INDICES
                    Dim VP_BORRADO As Integer = 0
                    Dim VP_REGISTRO As Integer = 0
                    While VP_REGISTRO <= PP_FORMA.VM_DATAGRID.Rows.Count - 1 And VP_BORRADO = 0
                        VP_VALOR = PP_FORMA.VM_DATAGRID.Rows(VP_REGISTRO).Cells("K_PARAMETRO_SUCURSAL_D0M4").Value
                        If VP_VALOR = VP_ITEM Then
                            VM_DATAGRID.Rows.RemoveAt(VP_REGISTRO)
                            VP_BORRADO = 1
                        End If
                        VP_REGISTRO += 1
                    End While

                Next
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub PM_MODO_AUXILIAR()

    End Sub

    Private Sub PM_PARAMETRO_SUCURSAL_D0M4_FORMCLOSING(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView, ByRef e As FormClosingEventArgs)
        'Codigo_BT.PG_BT_DISABLE(PP_FORMA)
        Dim VP_RESULTADO As Integer
        If FM_LI_DATA_VALIDATE(PP_LISTADO) Then
            VP_RESULTADO = Codigo_Message.FG_MENSAJE_DECISION("Hay cambios pendientes." + Environment.NewLine + "¿Desea Guardar los cambios?")
        End If
        Select Case VP_RESULTADO
            Case 1 'yes/si
                PM_LI_SAVE(PP_FORMA, PP_LISTADO)
            Case 2 'no

            Case 3 'cancel/cancelar
                e.Cancel = True
        End Select
    End Sub
#End Region

#Region "EVENTOS"
    Private Sub BT_AGREGAR_Click(sender As Object, e As EventArgs) Handles BT_AGREGAR.Click
        PM_BT_AGREGAR_CLICK(Me)
    End Sub

    Private Sub BT_BUSCAR_Click(sender As Object, e As EventArgs) Handles BT_LI_BUSCAR.Click
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)

    End Sub

    Private Sub BT_CANCELAR_Click(sender As Object, e As EventArgs) Handles BT_CANCELAR.Click, BT_CANCEL.Click
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

    Private Sub LI_LISTADO_DoubleClick(sender As Object, e As EventArgs) Handles LI_LISTADO.DoubleClick
        Codigo_LI.PG_LI_DOUBLE_CLICK(Me, LI_LISTADO)
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

    Private Sub LI_LISTADO_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles LI_LISTADO.CellBeginEdit
        Codigo_LI.PG_LI_CELL_MOD_COLOR(LI_LISTADO, e.RowIndex, e.ColumnIndex)
        Codigo_LI.PG_LI_CELL_MOD_WRITE(LI_LISTADO, e.RowIndex, e.ColumnIndex)
        BT_GUARDAR.Enabled = True
    End Sub

    Private Sub FO_PARAMETRO_SUCURSAL_D0M4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        PM_PARAMETRO_SUCURSAL_D0M4_FORMCLOSING(Me, LI_LISTADO, e)
    End Sub

    Private Sub BT_ANADIR_Click(sender As Object, e As EventArgs) Handles BT_ANADIR.Click
        PM_BT_GUARDAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub FO_PARAMETRO_SUCURSAL_D0M4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT(Me)
    End Sub

    Private Sub LI_LISTADO_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles LI_LISTADO.DataError
        If (e.Exception IsNot Nothing) Then
            MessageBox.Show("Imposible almacenar este valor en la tabla")
        End If
    End Sub

#End Region
End Class