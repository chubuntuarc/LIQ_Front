Public Class FO_GASTO_VIAJE_CAPTURA

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_CELL_COLOR As Color = Color.LightGreen
#End Region

#Region "VARIABLES LOCALES"
    Dim VM_RP_K_VIAJE As String
    Dim VL_DESC_TOTALES As String
    Dim VL_TOTAL_PRESUPUESTO As Decimal
    Dim VL_TOTAL_GASTO As Decimal
#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_AUTORIZACION, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_RAZON_SOCIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESTATUS_VIAJE, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_PERSONA_RESPONSABLE, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_F_INICIAL, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_F_FINAL, True)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_VIAJE.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_VIAJE, False)
            PP_NUEVO = False
        End If

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_AUTORIZACION, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_RAZON_SOCIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ESTATUS_VIAJE, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_PERSONA_RESPONSABLE, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_D_VIAJE, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_ORIGEN, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_DESTINO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MOTIVO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_F_INICIAL, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_F_FINAL, True)

        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_RUBRO(ByVal PP_PARAMETROS_RUBROS As String)
        Dim VP_PARAMETROS As String = ""

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_VIAJE, False)

        Return VP_PARAMETROS
    End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "D_VIAJE")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_VIAJE")
        Return VP_ID
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean

        Codigo_FI.PG_FI_FIELDS_VALIDATE(GB_FICHA, VP_VALIDACION, PP_MENSAJE_VALIDACION)
        Codigo_CTRL.PG_TB_DATE_VALIDATE(PP_MENSAJE_VALIDACION, TB_F_INICIAL)
        Codigo_CTRL.PG_TB_DATE_VALIDATE(PP_MENSAJE_VALIDACION, TB_F_FINAL)

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
        Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_LI_AUTORIZACION, "AUTORIZACION")
        Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_AUTORIZACION, "AUTORIZACION")
        Codigo_CB.PG_CB_RAZON_SOCIAL_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_RAZON_SOCIAL, 1, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_RAZON_SOCIAL_Load(VM_ID_BASE_DE_DATOS, Me, CB_RAZON_SOCIAL, 0, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 1, New ComboBox, CB_LI_RAZON_SOCIAL, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_UNIDAD_OPERATIVA, 0, 1, New ComboBox, CB_RAZON_SOCIAL, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_ESTATUS_VIAJE, "ESTATUS_VIAJE")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ESTATUS_VIAJE, "ESTATUS_VIAJE")
        Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_LI_PERSONA_RESPONSABLE, "PERSONA")
        Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_PERSONA_RESPONSABLE, "PERSONA")
        'Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_PASAJERO, "PERSONA")

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
        TB_D_VIAJE.Select()

        VL_DESC_TOTALES = ""
        VL_TOTAL_PRESUPUESTO = 0
        VL_TOTAL_GASTO = 0

        Dim VP_VIAJE As String
        Dim VP_PARAMETROS_RUBROS As String = ""
        Dim VP_PARAMETROS_PASAJERO As String = ""

        VP_VIAJE = TB_K_VIAJE.Text

        PM_LI_FORMAT_RUBRO(LI_LISTADO_RUBRO)
        PM_LI_FORMAT_PASAJERO(LI_LISTADO_PASAJERO)
        PM_LI_FORMAT_RUBRO_GASTO(LI_LISTADO_RUBRO_GASTO)

        PM_LI_CARGAR_LISTADO_RUBRO_PASAJERO_GASTO(LI_LISTADO_RUBRO, "PG_LI_PRESUPUESTO_VIAJE_X_K_VIAJE", VP_VIAJE, 1)   'AX // Se utiliza el mismo PM_LI_CARGAR el #1 es para RUBRO
        PM_LI_CARGAR_LISTADO_RUBRO_PASAJERO_GASTO(LI_LISTADO_PASAJERO, "PG_LI_PASAJERO_X_K_VIAJE", VP_VIAJE, 2)         'AX // El #2 es para PASAJERO 
        PM_LI_CARGAR_LISTADO_RUBRO_PASAJERO_GASTO(LI_LISTADO_RUBRO_GASTO, "PG_LI_GASTO_VIAJE_X_K_VIAJE", VP_VIAJE, 3)   'AX // El #3 para RUBRO GASTO

        PM_LI_AGREGAR_FILA_TOTALES(LI_LISTADO_RUBRO, 1)           'AX //  SE ENVIA #1 PARA CARGAR TOTALES PRESUPUESTO
        PM_LI_AGREGAR_FILA_TOTALES(LI_LISTADO_RUBRO_GASTO, 3)     'AX //  SE ENVIA #3 PARA CARGAR TOTALES GASTO
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_VIAJE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_AUTORIZACION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_RAZON_SOCIAL, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_UNIDAD_OPERATIVA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ESTATUS_VIAJE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_PERSONA_RESPONSABLE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_D_VIAJE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_ORIGEN, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_DESTINO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_MOTIVO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("F_INICIO_REAL", TB_F_INICIAL, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("F_FINAL_REAL", TB_F_FINAL, PP_ROW)
        'Codigo_CTRL.PG_CO_DATA_LOAD("", CB_PASAJERO, PP_ROW)

        Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)
    End Sub

#Region "LI_LISTADO_VIAJE"

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 20)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)]
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_VIAJE", "#Vi", GetType(Integer), 60, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_RAZON_SOCIAL", "Razón Social", GetType(String), 80, 2, 0, 1, 1, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_UNIDAD_OPERATIVA", "Unidad Operativa", GetType(String), 80, 2, 0, 1, 1, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_VIAJE", "Descripión", GetType(String), 220, 1, 0, 1, 1, 0, Nothing, Nothing, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_INICIO_REAL_DDMMMYYYY", "Fecha Inicio", GetType(Date), 100, 2, 0, 1, 1, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_FINAL_REAL_DDMMMYYYY", "Fecha Fin", GetType(Date), 100, 2, 0, 1, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ESTATUS_VIAJE", "Estatus", GetType(String), 80, 2, 0, 1, 0, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_AUTORIZACION", "Autorización", GetType(String), 220, 1, 0, 0, 0, 0, Nothing, Nothing, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_PERSONA", "Responsable", GetType(String), 120, 1, 0, 1, 0, 0, Nothing, Nothing, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "MOTIVO", "Motivo", GetType(String), 220, 1, 0, 1, 0, 0, Nothing, Nothing, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "ORIGEN", "Origen", GetType(String), 120, 1, 0, 1, 0, 0, Nothing, Nothing, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DESTINO", "Destino", GetType(String), 120, 1, 0, 1, 0, 0, Nothing, Nothing, 0)

        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)
    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_VIAJE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_RAZON_SOCIAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_VIAJE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_INICIO_REAL_DDMMMYYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_FINAL_REAL_DDMMMYYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ESTATUS_VIAJE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_AUTORIZACION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_PERSONA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MOTIVO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "ORIGEN")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "DESTINO")

        Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)
    End Sub

#End Region

#Region "LI_RUBRO_VIATICO_X_K_VIAJE"

    Private Sub PM_LI_FORMAT_RUBRO(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 20)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)]
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_VIAJE", "#VI", GetType(Integer), 60, 2, 0, 0, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_PRESUPUESTO_VIAJE", "#PTO", GetType(Integer), 60, 2, 0, 0, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_RUBRO_VIATICO", "#RBV", GetType(Integer), 60, 2, 0, 0, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_RUBRO_VIATICO", "Rubro", GetType(String), 120, 1, 0, 1, 0, 0, Nothing, Nothing, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "MONTO_PROPUESTO", "$ Solicitado", GetType(Decimal), 80, 3, 0, 1, 0, 2, Color.DarkOrange, Nothing, 1)

    End Sub

    Public Sub PM_LI_ROW_WRITE_RUBRO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_VIAJE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_PRESUPUESTO_VIAJE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_RUBRO_VIATICO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_RUBRO_VIATICO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MONTO_PROPUESTO", "0.00")
        Codigo_LI.PG_LI_ROW_EDIT(PP_LISTADO, VP_ROW, True)

        VL_DESC_TOTALES = "Totales"
        VL_TOTAL_PRESUPUESTO = VL_TOTAL_PRESUPUESTO + Convert.ToDecimal(Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, VP_ROW, "MONTO_PROPUESTO"))
    End Sub

#End Region

#Region "LI_GASTO_RUBRO_VIATICO_X_K_VIAJE"

    Private Sub PM_LI_FORMAT_RUBRO_GASTO(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 20)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)]
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_VIAJE", "#VI", GetType(Integer), 60, 2, 0, 0, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_GASTO_VIAJE", "#GTO", GetType(Integer), 60, 2, 0, 0, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_RUBRO_VIATICO", "#RBV", GetType(Integer), 60, 2, 0, 0, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_RUBRO_VIATICO", "Rubro", GetType(String), 120, 1, 0, 1, 0, 0, Nothing, Nothing, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "MONTO", "$ Solicitado", GetType(Decimal), 80, 3, 1, 1, 0, 2, Color.DarkOrange, Nothing, 1)

    End Sub

    Public Sub PM_LI_ROW_WRITE_RUBRO_GASTO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_VIAJE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_GASTO_VIAJE", 0)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_RUBRO_VIATICO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_RUBRO_VIATICO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MONTO", "0.00")
        Codigo_LI.PG_LI_ROW_EDIT(PP_LISTADO, VP_ROW, False)

        VL_DESC_TOTALES = "Totales"
        VL_TOTAL_GASTO = VL_TOTAL_GASTO + Convert.ToDecimal(Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, VP_ROW, "MONTO"))

    End Sub

    Public Sub PG_GUARDAR_RUBRO_GASTO(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Dim VP_CONTA As Integer = 0
        Dim VP_EXITO As Boolean = False
        If TB_K_VIAJE.Text <> "" Then
            Try
                For Each VP_ROW_DATA As DataGridViewRow In PP_LISTADO.Rows
                    Dim VP_K_TOTALES As String = ""
                    VP_CONTA = VP_ROW_DATA.Index
                    VP_K_TOTALES = Codigo_LI.FG_LI_CELL_VALUE(PP_LISTADO, VP_CONTA, "D_RUBRO_VIATICO")
                    If VP_K_TOTALES <> "Totales" Then
                        Dim VP_PARAMETROS As String = ""
                        Dim VP_K_VIAJE As String = ""
                        Dim VP_K_GASTO_VIAJE As String = ""
                        Dim VP_K_RUBRO_VIATICO As String = ""
                        Dim VP_MONTO As String = ""
                        Dim VP_C_GASTO_VIAJE As String = ""
                        VP_K_VIAJE = TB_K_VIAJE.Text

                        VP_K_GASTO_VIAJE = Codigo_LI.FG_LI_CELL_VALUE(PP_LISTADO, VP_CONTA, "K_GASTO_VIAJE")
                        VP_K_RUBRO_VIATICO = Codigo_LI.FG_LI_CELL_VALUE(PP_LISTADO, VP_CONTA, "K_RUBRO_VIATICO")
                        VP_MONTO = Codigo_LI.FG_LI_CELL_VALUE(PP_LISTADO, VP_CONTA, "MONTO")
                        VP_C_GASTO_VIAJE = "INS // RUBRO GASTO: " + VP_K_RUBRO_VIATICO

                        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_K_VIAJE, False)
                        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_K_GASTO_VIAJE, False)
                        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_K_RUBRO_VIATICO, False)
                        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_MONTO, False)
                        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_C_GASTO_VIAJE, True)

                        Dim VP_CLAVE, VP_MENSAJE As String
                        Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "PG_IU_GASTO_VIAJE", VP_PARAMETROS, VP_CLAVE, VP_MENSAJE)

                        If VP_MENSAJE = "" Then
                            VP_EXITO = True
                        Else
                            Codigo_Message.PG_MENSAJE_AVISO(VP_MENSAJE)
                            Exit For
                        End If
                    End If
                Next
                Codigo_LI.PG_LI_RESET(VM_ID_BASE_DE_DATOS, PP_FORMA, LI_LISTADO, VP_EXITO)
            Catch E As Exception
                Codigo_Message.PG_MENSAJE_ERROR_VS("PG_BT_GUARDAR_CLICK")
            End Try
        Else
        End If
    End Sub

#End Region

#Region "RUBRO_PASAJERO_Y GASTO_CARGAR_LISTADO"

    Public Sub PM_LI_CARGAR_LISTADO_RUBRO_PASAJERO_GASTO(ByVal PP_LISTADO As DataGridView, ByVal PP_SP As String, ByVal PP_PARAMETROS As String, ByVal PP_BANDERA As Integer)
        Dim VM_PARAMETROS As String = PP_PARAMETROS
        Dim VM_STORED_PROCEDURE As String = PP_SP
        Dim VM_TABLA As Data.DataTable

        Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VM_PARAMETROS)
        VM_TABLA = Codigo_CON.FG_SP_EXECUTE_DATATABLE(VM_ID_BASE_DE_DATOS, VM_STORED_PROCEDURE, VM_PARAMETROS)

        PM_LI_LOAD_LISTADO_RUBRO_PASAJERO_GASTO(PP_LISTADO, VM_TABLA, PP_BANDERA)
    End Sub

    Public Sub PM_LI_LOAD_LISTADO_RUBRO_PASAJERO_GASTO(ByRef PP_LISTADO As DataGridView, ByVal PP_DATATABLE As DataTable, ByVal PP_BANDERA As Integer)
        Codigo_LI.PG_LI_CLEAR(PP_LISTADO)
        For Each VP_ROW_DATA As DataRow In PP_DATATABLE.Rows
            Codigo_LI.PG_LI_ROW_ADD(PP_LISTADO)
            If PP_BANDERA = 1 Then
                PM_LI_ROW_WRITE_RUBRO(PP_LISTADO, VP_ROW_DATA)
            ElseIf PP_BANDERA = 2 Then
                PM_LI_ROW_WRITE_PASAJERO(PP_LISTADO, VP_ROW_DATA)
            ElseIf PP_BANDERA = 3 Then
                PM_LI_ROW_WRITE_RUBRO_GASTO(PP_LISTADO, VP_ROW_DATA)
            End If
        Next
        PP_LISTADO.CurrentCell = Nothing
    End Sub

#End Region

#Region "AGREGAR FILAS TOTALES_PRESUPUESTO_Y_GASTO"
    Public Sub PM_LI_AGREGAR_FILA_TOTALES(ByVal PP_LISTADO As DataGridView, ByVal PP_IDENTIFICADOR As Integer)
        If PP_IDENTIFICADOR = 1 Then
            PP_LISTADO.Rows.Add(0, 0, 0, VL_DESC_TOTALES, VL_TOTAL_PRESUPUESTO)
        ElseIf PP_IDENTIFICADOR = 3 Then
            PP_LISTADO.Rows.Add(0, 0, 0, VL_DESC_TOTALES, VL_TOTAL_GASTO)
        End If
        For i As Integer = 0 To PP_LISTADO.Rows(0).Cells.Count - 1
            PP_LISTADO.Rows(PP_LISTADO.Rows.Count - 1).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleRight
            PP_LISTADO.Rows(PP_LISTADO.Rows.Count - 1).Cells(i).Style.Font = New Font("Arial", 8, FontStyle.Bold)
            PP_LISTADO.Rows(PP_LISTADO.Rows.Count - 1).Cells(i).Style.BackColor = Color.Black
            PP_LISTADO.Rows(PP_LISTADO.Rows.Count - 1).Cells(i).Style.ForeColor = Color.White
            PP_LISTADO.Rows(PP_LISTADO.Rows.Count - 1).Cells(i).ReadOnly = False
        Next
        PP_LISTADO.Rows(PP_LISTADO.Rows.Count - 1).Cells(2).Style.ForeColor = Color.Black
    End Sub
#End Region

#Region "LI_PASAJERO"

    Private Sub PM_LI_FORMAT_PASAJERO(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 20)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)]
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_PERSONA", "#Per", GetType(Integer), 60, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_PERSONA", "Pasajero", GetType(String), 200, 1, 0, 1, 0, 0, Nothing, Nothing, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PUESTO", "Puesto", GetType(String), 120, 2, 0, 1, 0, 0, Nothing, Nothing, 1)

    End Sub

    Public Sub PM_LI_ROW_WRITE_PASAJERO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_PERSONA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_PERSONA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PUESTO")

    End Sub

#End Region

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
        PG_GUARDAR_RUBRO_GASTO(PP_FORMA, PP_LISTADO)
    End Sub

    Public Sub PM_BT_ELIMINAR_CLICK(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_ELIMINAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
    End Sub

    Private Sub PM_BT_EXPORTAR_EXCEL_CLICK(ByRef PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_EXPORTAR_EXCEL_CLICK(PP_LISTADO)
    End Sub

    Private Sub PM_BT_LISTADO_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_LISTADO_CLICK(PP_FORMA)
    End Sub

    Private Sub PM_TI_TICK(ByRef PP_LABEL As Label)
        Codigo_FRM.PG_TI_TICK(PP_LABEL)
    End Sub

    Public Sub PM_MODO_AUXILIAR()

    End Sub

#End Region

#Region "EVENTOS"

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
        PM_BT_GUARDAR_CLICK(Me, LI_LISTADO_RUBRO_GASTO)
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

    Private Sub Generico_T1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT(Me)
    End Sub

    Private Sub BT_EXPORTAR_EXCEL_Click(sender As Object, e As EventArgs) Handles BT_EXPORTAR_EXCEL.Click
        'PM_BT_EXPORTAR_EXCEL_CLICK(LI_LISTADO)
    End Sub

#End Region

#Region "EVENTO CHANGE VALUE DEL COMBO DE RAZÓN SOCIAL"

    Private Sub CB_RAZON_SOCIAL_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_RAZON_SOCIAL.SelectedValueChanged
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_UNIDAD_OPERATIVA, 0, 1, New ComboBox, CB_RAZON_SOCIAL, VG_USUARIO_ACCION)
    End Sub

    Private Sub CB_LI_RAZON_SOCIAL_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_LI_RAZON_SOCIAL.SelectedValueChanged
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 1, New ComboBox, CB_LI_RAZON_SOCIAL, VG_USUARIO_ACCION)
    End Sub

#End Region

#Region "EVENTOS LISTADO"

    Private Sub LI_LISTADO_RUBRO_GASTO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LI_LISTADO_RUBRO_GASTO.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        Else
            If Char.IsPunctuation(e.KeyChar) Then
                If sender.Text.IndexOf(".") > 0 Then
                    e.Handled = True
                Else
                    e.Handled = False
                End If
            End If
        End If
    End Sub

    Private Sub cellTextBox_KeyDown(
    ByVal sender As Object,
    ByVal e As System.Windows.Forms.KeyEventArgs) Handles cellTextBox.KeyDown

    End Sub

    Private Sub cellTextBox_KeyPress(
    ByVal sender As Object,
    ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cellTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        Else
            If Char.IsPunctuation(e.KeyChar) Then
                If sender.Text.IndexOf(".") > 0 Then
                    e.Handled = True
                Else
                    e.Handled = False
                End If
            End If
        End If
    End Sub

    Private Sub cellTextBox_KeyUp(
    ByVal sender As Object,
    ByVal e As System.Windows.Forms.KeyEventArgs) Handles cellTextBox.KeyUp

    End Sub

    Private Sub DataGridView1_EditingControlShowing(
                ByVal sender As Object,
                ByVal e As DataGridViewEditingControlShowingEventArgs) _
                Handles LI_LISTADO_RUBRO_GASTO.EditingControlShowing

        ' Este evento se producirá cuando la celda pasa a modo de edición.

        ' Referenciamos el control DataGridViewTextBoxEditingControl actual.
        '
        cellTextBox = TryCast(e.Control, DataGridViewTextBoxEditingControl)

        ' Obtenemos el estilo de la celda actual
        '
        Dim style As DataGridViewCellStyle = e.CellStyle

        ' Mientras se edita la celda, aumentaremos la fuente
        ' y rellenaremos el color de fondo de la celda actual.
        '
        With style
            .Font = New Font(style.Font.FontFamily, 10, FontStyle.Bold)
            .BackColor = Color.Beige
        End With

    End Sub

    Private WithEvents cellTextBox As DataGridViewTextBoxEditingControl

    Private Sub LI_LISTADO_RUBRO_GASTO_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles LI_LISTADO_RUBRO_GASTO.CellBeginEdit
        Codigo_LI.PG_LI_CELL_COLOR_CHANGE(LI_LISTADO_RUBRO_GASTO, e.RowIndex, e.ColumnIndex, VM_CELL_COLOR)
    End Sub

    Private Sub LI_LISTADO_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LI_LISTADO.CellDoubleClick
        If e.RowIndex <> -1 Then
            Codigo_LI.PG_LI_DOUBLE_CLICK(Me, LI_LISTADO)
        End If
    End Sub

#End Region
End Class