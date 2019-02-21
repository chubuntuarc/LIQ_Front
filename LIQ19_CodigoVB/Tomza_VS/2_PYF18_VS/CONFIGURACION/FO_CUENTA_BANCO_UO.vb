Public Class FO_CUENTA_BANCO_UO
#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ZONA_UO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_RAZON_SOCIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIPO_CUENTA_BANCO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_BANCO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_MONEDA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESTATUS_CUENTA_BANCO, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean) As String
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_CUENTA_BANCO_UO.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_CUENTA_BANCO_UO, False)
            PP_NUEVO = False
        End If

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_TIPO_CUENTA_BANCO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_CUENTA_BANCO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_PRINCIPAL, False)

        Return VP_PARAMETROS
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_PARAMETROS As String = ""
        Dim VP_CUENTA_BANCO As Integer = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_CUENTA_BANCO")
        Dim VP_UNIDAD_OPERATIVA As Integer = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_UNIDAD_OPERATIVA")
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_CUENTA_BANCO, False)
        Return VP_PARAMETROS
    End Function

    'Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
    '    Dim VP_PARAMETROS As String = ""
    '    Dim VP_CUENTA_BANCO As Integer = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_CUENTA_BANCO_UO")
    '    Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_CUENTA_BANCO, False)
    '    Return VP_PARAMETROS
    'End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "D_CUENTA_BANCO")
        Return VP_ID
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_VALOR As String)
        Codigo_CTRL.PG_CB_MAYOR_A_CERO(PP_VALOR, CB_TIPO_CUENTA_BANCO)
        Codigo_CTRL.PG_CB_MAYOR_A_CERO(PP_VALOR, CB_UNIDAD_OPERATIVA)
        Codigo_CTRL.PG_CB_MAYOR_A_CERO(PP_VALOR, CB_CUENTA_BANCO)

        Codigo_CTRL.PG_TB_MAYOR_A_CERO(PP_VALOR, TB_K_CUENTA_BANCO)
        Return True
    End Function

#End Region

#Region "SUB_PM_INIT"

    Public Sub PM_FO_SHOW(ByRef PP_NOMBRE_TABLA As String, ByVal PP_ID_BASE_DE_DATOS As String)
        VM_NOMBRE_TABLA = PP_NOMBRE_TABLA
        VM_ID_BASE_DE_DATOS = PP_ID_BASE_DE_DATOS
        'Me.Text = "Catálogo de " + PP_NOMBRE_TABLA.Replace("_", " ")
        'Me.Show()
    End Sub

    Public Sub PM_CB_INIT()
        Codigo_FI.PG_FI_CONTROL_DATA_SETUP(VM_ID_BASE_DE_DATOS, Me)
        Codigo_CB.PG_CB_ZONA_UO_TODOS_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_ZONA_UO, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_RAZON_SOCIAL_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_RAZON_SOCIAL, 1, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 1, CB_LI_ZONA_UO, New ComboBox, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_LI_TIPO_CUENTA_BANCO)

        Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_LI_BANCO)
        Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_LI_MONEDA)
        Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_LI_ESTATUS_CUENTA_BANCO)

        Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_UNIDAD_OPERATIVA)
        Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_TIPO_CUENTA_BANCO)
        Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_CUENTA_BANCO)

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
        'Dim PP_FORMA_ADMINISTRACION As New FO_CUENTA_BANCO_UO_AS
        'PP_FORMA_ADMINISTRACION.VM_K_UNIDAD_OPERATIVA = PP_ID
        'PM_ABRIR(PP_FORMA_ADMINISTRACION, "CUENTA_BANCO_UO_CUENTA_BANCO", VM_ID_BASE_DE_DATOS)
        ' Codigo_FRM.PG_FRM_ABRIR(Me, PP_FORMA_ADMINISTRACION, "CUENTA_BANCO_UO", "Asignación de Unidades Operativas a Cuentas Bancarias", VM_ID_BASE_DE_DATOS, False, True)
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)

        If VM_IN_MODO_OPERACION <> Modo_Operacion.Clon Then
            Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_CUENTA_BANCO_UO, PP_ROW, "")
        End If
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_CUENTA_BANCO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_UNIDAD_OPERATIVA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_D_CUENTA_BANCO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_CUENTA_BANCO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CUENTA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CLABE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_TIPO_CUENTA_BANCO, PP_ROW, "0")
        Codigo_CTRL.PG_CO_DATA_LOAD("", CH_L_PRINCIPAL, PP_ROW, "0")
    End Sub

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 20)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, 
        '            ANCHO_CELDA, ALINEACION, SOLO_LECTURA, Visible, FROZEN, FORMAT

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_CUENTA_BANCO_UO", "#CBU", GetType(Integer), 50, 2, 0, 1, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_CUENTA_BANCO", "#CTA", GetType(Integer), 80, 2, 0, 1, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_CUENTA_BANCO", "Cuenta Bancaria", GetType(String), 350, 1, 0, 1, 0, 0) ', Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_UNIDAD_OPERATIVA", "#UNO", GetType(Integer), 40, 2, 0, 0, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_UNIDAD_OPERATIVA", "Planta", GetType(String), 200, 1, 0, 1, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_RAZON_SOCIAL", "Razón Social", GetType(String), 80, 2, 0, 1, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ZONA_UO", "Zona", GetType(String), 60, 2, 0, 1, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ESTATUS_CUENTA_BANCO", "Estatus", GetType(String), 70, 2, 0, 1, 0, 0, Color.DarkSlateGray, Color.Gainsboro, 1)

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_TIPO_CUENTA_BANCO", "Tipo de Cuenta", GetType(String), 100, 2, 0, 0, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_TIPO_CUENTA_BANCO", "Tipo de Cuenta", GetType(String), 100, 2, 0, 1, 0, 0)

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_BANCO", "#BAN", GetType(Integer), 40, 1, 0, 0, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_BANCO", "Banco", GetType(String), 80, 2, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_MONEDA", "Monéda", GetType(String), 150, 2, 0, 1, 0, 0, Nothing, Nothing, 1)

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "CLABE", "CLABE", GetType(String), 120, 2, 0, 1, 0, 0)

        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "L_PRINCIPAL", "Principal", GetType(CheckBox), 100, 2, 0, 1, 0, 0)

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_APERTURA", "Apertura", GetType(Date), 100, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_CANCELACION", "Cancelación", GetType(Date), 100, 2, 0, 1, 0, 0)

        '

    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_CUENTA_BANCO_UO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_CUENTA_BANCO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_CUENTA_BANCO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_RAZON_SOCIAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ZONA_UO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ESTATUS_CUENTA_BANCO")

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_TIPO_CUENTA_BANCO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_TIPO_CUENTA_BANCO")

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_BANCO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_BANCO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_MONEDA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CLABE")

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "L_PRINCIPAL")

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_APERTURA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_CANCELACION")

    End Sub

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_BUSCAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
    End Sub

    Private Sub PM_BT_AGREGAR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_AGREGAR_CLICK(PP_FORMA)
        'PP_FORMA.VM_IN_MODO_OPERACION = Modo_Operacion.Edición
        'Dim VM_ID_BASE_DE_DATOS As Integer = VG_ID_DB
        'Dim PP_FORMA_ADMINISTRACION As New FO_CUENTA_BANCO_UO_AS
        'PP_FORMA_ADMINISTRACION.VM_K_UNIDAD_OPERATIVA = 0
        ''PM_ABRIR(PP_FORMA_ADMINISTRACION, "CUENTA_BANCO_UO_CUENTA_BANCO", VM_ID_BASE_DE_DATOS)
        'Codigo_FRM.PG_FRM_ABRIR(Me, PP_FORMA_ADMINISTRACION, "CUENTA_BANCO_UO", "Asignación de Cuentas Bancarias a Unidades Operativas", VM_ID_BASE_DE_DATOS, False, True)
    End Sub

    Public Sub PM_ABRIR(ByRef PP_FORMA As Object, ByRef PP_NOMBRE_TABLA As String, ByVal PP_ID_BASE_DE_DATOS As String)
        Dim PL_PANEL As Panel = Me.Parent
        Codigo_FRM.PG_FO_SHOW(PP_FORMA, PP_NOMBRE_TABLA, PP_ID_BASE_DE_DATOS, PL_PANEL)
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

    'Public Sub PM_LI_SAVE(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
    '    PM_BT_BUSCAR_MASIVO_CLICK(PP_FORMA, PP_LISTADO)
    'End Sub

    Private Sub PM_CB_CUENTA_BANCO_CARGAR_DATOS(PP_CB_CUENTA_BANCO As ComboBox)
        Dim VP_STORED_PROCEUDRE As String = "PG_SK_CUENTA_BANCO"
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_CB_CUENTA_BANCO, False)
        Dim VP_DATATABLE As New DataTable

        Codigo_ABC.PG_BT_EJECUTAR_ACCION_TABLA_CLICK(VM_ID_BASE_DE_DATOS, Me, VP_STORED_PROCEUDRE, VP_PARAMETROS, VP_DATATABLE)
        If VP_DATATABLE.Rows.Count > 0 Then
            Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_CUENTA_BANCO, VP_DATATABLE.Rows(0))
            Codigo_CTRL.PG_CO_DATA_LOAD("", TB_D_CUENTA_BANCO, VP_DATATABLE.Rows(0))
            Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CUENTA, VP_DATATABLE.Rows(0))
            Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CLABE, VP_DATATABLE.Rows(0))

        End If

    End Sub

    Private Sub PM_BT_CLONAR_CLICK(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_CLONAR_CLICK(PP_FORMA, PP_LISTADO)
    End Sub

    Public Sub PM_MODO_AUXILIAR()

    End Sub

#End Region

#Region "EVENTOS"

    Private Sub BT_AGREGAR_Click(sender As Object, e As EventArgs) Handles BT_AGREGAR.Click
        PM_BT_AGREGAR_CLICK(Me)
    End Sub

    Private Sub BT_BUSCAR_MASIVO_Click(sender As Object, e As EventArgs) Handles BT_LI_BUSCAR.Click
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub Catalogo_T1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT(Me)
    End Sub

    Private Sub TI_RELOJ_Tick(sender As Object, e As EventArgs) Handles TI_RELOJ.Tick
        PM_TI_TICK(LB_RELOJ)
    End Sub

    Private Sub LI_LISTADO_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LI_LISTADO.CellDoubleClick
        If e.RowIndex <> -1 Then
            Dim VP_ID As String = ""
            If LI_LISTADO.Rows.Count > 0 Then
                Dim VP_ROW As Integer = Codigo_LI.FG_LI_ROW_CURRENT(LI_LISTADO)
                VP_ID = FM_ID_SELECCIONADO(LI_LISTADO, VP_ROW)
                PM_FI_LOAD(VP_ID)
                VM_IN_MODO_OPERACION = Modo_Operacion.Edición
                Codigo_FRM.PG_FRM_CONFIG(Me)
                'BT_GUARDAR.Enabled = True
            End If
        End If
    End Sub

    Private Sub CB_LI_ZONA_UO_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_LI_ZONA_UO.SelectedValueChanged
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 1, CB_LI_ZONA_UO, New ComboBox, VG_USUARIO_ACCION)
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

    Private Sub BT_LISTADO_Click(sender As Object, e As EventArgs) Handles BT_LISTADO.Click
        PM_BT_LISTADO_CLICK(Me)
    End Sub

    Private Sub BT_EXPORTAR_EXCEL_Click(sender As Object, e As EventArgs) Handles BT_EXPORTAR_EXCEL.Click
        PM_BT_EXPORTAR_EXCEL_CLICK(LI_LISTADO)
    End Sub

    Private Sub CB_CUENTA_BANCO_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_CUENTA_BANCO.SelectedValueChanged
        PM_CB_CUENTA_BANCO_CARGAR_DATOS(CB_CUENTA_BANCO)
    End Sub

    Private Sub BT_CLONAR_Click(sender As Object, e As EventArgs) Handles BT_CLONAR.Click
        PM_BT_CLONAR_CLICK(Me, LI_LISTADO)
    End Sub


#End Region

End Class