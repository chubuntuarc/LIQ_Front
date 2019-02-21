Public Class FO_PROVEEDOR

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_FILTRO_REFRESH As Boolean = False

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESTATUS_PROVEEDOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_CATEGORIA_PROVEEDOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_FISCAL_ESTADO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_OFICINA_ESTADO, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_PROVEEDOR.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_PROVEEDOR, False)
            PP_NUEVO = False

        End If

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_D_PROVEEDOR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_C_PROVEEDOR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_S_PROVEEDOR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_RAZON_SOCIAL, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_RFC_PROVEEDOR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CURP, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CORREO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_TELEFONO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_N_DIAS_CREDITO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_FISCAL_CALLE, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_FISCAL_NUMERO_EXTERIOR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_FISCAL_NUMERO_INTERIOR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_FISCAL_COLONIA, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_FISCAL_POBLACION, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_FISCAL_CP, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_FISCAL_MUNICIPIO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_FISCAL_ESTADO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_OFICINA_CALLE, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_OFICINA_NUMERO_EXTERIOR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_OFICINA_NUMERO_INTERIOR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_OFICINA_COLONIA, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_OFICINA_POBLACION, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_OFICINA_CP, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_OFICINA_MUNICIPIO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_OFICINA_ESTADO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ESTATUS_PROVEEDOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_CATEGORIA_PROVEEDOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CONTACTO_VENTA, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CONTACTO_VENTA_TELEFONO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CONTACTO_VENTA_CORREO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CONTACTO_PAGO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CONTACTO_PAGO_TELEFONO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CONTACTO_PAGO_CORREO, True)

        Return VP_PARAMETROS

    End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "D_PROVEEDOR")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_PROVEEDOR")
        Return VP_ID
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean

        Codigo_FI.PG_FI_FIELDS_VALIDATE(GB_FICHA, VP_VALIDACION, PP_MENSAJE_VALIDACION)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_N_DIAS_CREDITO)

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
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_ESTATUS_PROVEEDOR, "ESTATUS_PROVEEDOR")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_CATEGORIA_PROVEEDOR, "CATEGORIA_PROVEEDOR")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_FISCAL_ESTADO, "ESTADO")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_OFICINA_ESTADO, "ESTADO")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_ESTATUS_PROVEEDOR, "ESTATUS_PROVEEDOR")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_CATEGORIA_PROVEEDOR, "CATEGORIA_PROVEEDOR")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_FISCAL_ESTADO, "ESTADO")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_OFICINA_ESTADO, "ESTADO")
        VM_FILTRO_REFRESH = True
    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
    End Sub

    Private Sub PM_FO_INIT(ByRef PP_FORMA As Object)
        Codigo_FRM.PG_FRM_INIT(VM_ID_BASE_DE_DATOS, PP_FORMA)
        ponertooltipsparaimprimir()
    End Sub

#End Region

#Region "SUBS_PM"

    ''' <summary>
    ''' 'FUNCION QUE CARGARA LA PARTE DE LA FICHA
    ''' </summary>
    Public Sub PM_FI_LOAD(ByVal PP_ID As String)
        Codigo_FI.FG_FI_LOAD_X_ID(VM_ID_BASE_DE_DATOS,  Me, PP_ID)
        TB_D_PROVEEDOR.Select()
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)
        If VM_IN_MODO_OPERACION <> Modo_Operacion.Clon Then
            Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_PROVEEDOR, PP_ROW)
            Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)
        End If
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_D_PROVEEDOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_C_PROVEEDOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_S_PROVEEDOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_RAZON_SOCIAL, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_RFC_PROVEEDOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CURP, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CORREO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_TELEFONO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_N_DIAS_CREDITO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_FISCAL_CALLE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_FISCAL_NUMERO_EXTERIOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_FISCAL_NUMERO_INTERIOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_FISCAL_COLONIA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_FISCAL_POBLACION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_FISCAL_CP, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_FISCAL_MUNICIPIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_OFICINA_CALLE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_OFICINA_NUMERO_EXTERIOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_OFICINA_NUMERO_INTERIOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_OFICINA_COLONIA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_OFICINA_POBLACION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_OFICINA_CP, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_OFICINA_MUNICIPIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CONTACTO_VENTA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CONTACTO_VENTA_TELEFONO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CONTACTO_VENTA_CORREO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CONTACTO_PAGO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CONTACTO_PAGO_TELEFONO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CONTACTO_PAGO_CORREO, PP_ROW)

        Codigo_CTRL.PG_CO_DATA_LOAD("FISCAL_K_ESTADO", CB_FISCAL_ESTADO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("OFICINA_K_ESTADO", CB_OFICINA_ESTADO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ESTATUS_PROVEEDOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_CATEGORIA_PROVEEDOR, PP_ROW)

    End Sub

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, 
        '            ANCHO_CELDA, ALINEACION, SOLO_LECTURA, Visible, FROZEN, FORMAT
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_PROVEEDOR", "#PRV", GetType(Integer), 50, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_PROVEEDOR", "Proveedor", GetType(String), 300, 1, 0, 1, 1, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "RAZON_SOCIAL", "Razón Social", GetType(String), 300, 1, 0, 1, 1, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ESTATUS_PROVEEDOR", "Estatus", GetType(String), 60, 2, 0, 1, 1, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_CATEGORIA_PROVEEDOR", "Categoría", GetType(String), 60, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "RFC_PROVEEDOR", "RFC", GetType(String), 110, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_PROVEEDOR", "Siglas", GetType(String), 60, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "CONTACTO_VENTA", "Cto Venta", GetType(String), 100, 1, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "CONTACTO_VENTA_TELEFONO", "Cto Vta Teléfono", GetType(String), 100, 1, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "CONTACTO_VENTA_CORREO", "Cto Vta Correo", GetType(String), 200, 1, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "CONTACTO_PAGO", "Cto Pago", GetType(String), 100, 1, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "CONTACTO_PAGO_TELEFONO", "Cto Pgo Teléfono", GetType(String), 100, 1, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "CONTACTO_PAGO_CORREO", "Cto Pgo Correo", GetType(String), 200, 1, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "C_PROVEEDOR", "Comentarios", GetType(String), 180, 1, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "CURP", "CURP", GetType(String), 150, 1, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "CORREO", "Correo", GetType(String), 200, 1, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "TELEFONO", "Teléfono", GetType(String), 100, 1, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "N_DIAS_CREDITO", "Días Crédito", GetType(Integer), 50, 2, 0, 1, 0, 0)

        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)

    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_PROVEEDOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_PROVEEDOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "RAZON_SOCIAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ESTATUS_PROVEEDOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_CATEGORIA_PROVEEDOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "RFC_PROVEEDOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_PROVEEDOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CONTACTO_VENTA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CONTACTO_VENTA_TELEFONO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CONTACTO_VENTA_CORREO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CONTACTO_PAGO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CONTACTO_PAGO_TELEFONO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CONTACTO_PAGO_CORREO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "C_PROVEEDOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CURP")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CORREO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "TELEFONO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "N_DIAS_CREDITO")

        Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)

    End Sub

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_BUSCAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
        Dim VP_TOOLTIP_LI_LISTADO As New ToolTip
        VP_TOOLTIP_LI_LISTADO.SetToolTip(Me.LI_LISTADO, "Listado")
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

    'AX // Al momento de Escribir se refresca autmaticamente el GRID.   //   20180925
    Private Sub TB_LI_BUSCAR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_LI_BUSCAR.KeyPress
        If VM_FILTRO_REFRESH = True Then
            PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
        End If
    End Sub
    Private Sub ponertooltipsparaimprimir()
        On Error Resume Next
        For Each lola As Control In GB_FICHA.Controls
            Dim VP_TOOLTIPlola As New ToolTip
            VP_TOOLTIPlola.ShowAlways = True
            VP_TOOLTIPlola.SetToolTip(lola, lola.Name)
        Next
        On Error GoTo 0
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