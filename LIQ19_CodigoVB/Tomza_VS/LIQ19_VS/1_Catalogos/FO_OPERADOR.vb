Public Class FO_OPERADOR

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESTATUS_OPERADOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_F_INICIAL, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_F_FINAL, True)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_OPERADOR.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_OPERADOR, False)
            PP_NUEVO = False

        End If

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_C_CHOFER, True)
        '========================================================================
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ESTATUS_OPERADOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ESTADO_CIVIL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_SEXO, False)
        '========================================================================
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_NOMBRE, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_APELLIDO_PATERNO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_APELLIDO_MATERNO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_RFC, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CURP, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_NSS, True)
        LIQ19_Codigo.PG_CO_PARAMETRO_80_YYYY(VP_PARAMETROS, TB_F_NACIMIENTO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_F_INGRESO, True)
        '========================================================================
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_TELEFONO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CORREO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CALLE, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_NUMERO_EXTERIOR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_NUMERO_INTERIOR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_COLONIA, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CP, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MUNICIPIO, True)
        '========================================================================
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_NUMERO_LICENCIA_OPERADOR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_F_VIGENCIA_LICENCIA, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_SALARIO_DIARIO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_SALARIO_DIARIO_INTEGRADO, False)

        Return VP_PARAMETROS

    End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "D_OPERADOR")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_OPERADOR")
        Return VP_ID
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean
        Codigo_FI.PG_FI_FIELDS_VALIDATE(GB_FICHA, VP_VALIDACION, PP_MENSAJE_VALIDACION)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_SALARIO_DIARIO)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_SALARIO_DIARIO_INTEGRADO)
        Codigo_CTRL.PG_TB_DATE_VALIDATE(PP_MENSAJE_VALIDACION, TB_F_VIGENCIA_LICENCIA)
        Codigo_CTRL.PG_TB_DATE_VALIDATE(PP_MENSAJE_VALIDACION, TB_F_INGRESO)
        LIQ19_Codigo.PG_TB_DATE_VALIDATE_80_YYYY(PP_MENSAJE_VALIDACION, TB_F_NACIMIENTO)
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
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ESTATUS_OPERADOR, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_ESTATUS_OPERADOR, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ESTADO_CIVIL, "ESTADO_CIVIL")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_SEXO, "SEXO")
    End Sub

    Public Sub PM_LI_INIT()
        'JAR || CREAR LISTADOS SENCILLOS../
        ' Dim VP_PARAMETROS_DETALLE As String = "''," + CB_LI_ESTATUS_PUNTO_VENTA.SelectedValue + ",2," + CB_LI_UNIDAD_OPERATIVA
        Dim VP_PARAMETROS_DETALLE As String = "'',-1,'',''"
        Dim VP_DATATABLE As New DataTable
        Codigo_ABC.PG_BT_EJECUTAR_ACCION_TABLA_CLICK(VM_ID_BASE_DE_DATOS, Me, "PG_LI_OPERADOR", VP_PARAMETROS_DETALLE, VP_DATATABLE)
        Dim VM_CAMPOS As New ArrayList From {"K_OPERADOR", "APELLIDO_PATERNO", "APELLIDO_MATERNO", "NOMBRE", "S_ESTATUS_OPERADOR", "SALARIO_DIARIO", "SALARIO_DIARIO_INTEGRADO", "NUMERO_LICENCIA_OPERADOR", "F_VIGENCIA_LICENCIA_DDMMMYYYY", "F_INGRESO_DDMMMYYYY", "RFC", "CURP", "NSS", "TELEFONO", "CORREO", "MUNICIPIO", "COLONIA", "CALLE", "NUMERO_EXTERIOR", "NUMERO_INTERIOR", "CP", "C_OPERADOR"}
        Dim VM_TITULOS As New ArrayList From {"OPE", "A. Materno", "A. Paterno", "Nombre", "Estatus", "SD", "SDI", "#Licencia", "Vigencia Licencia", "Ingreso", "RFC", "CURP", "NSS", "Teléfono", "Correo", "Municipio", "Colonia", "Calle", "#Exterior", "#Interior", "CP", "Comentarios"}
        '///  K--ID | D--DESCRIPCION | S--SIGLAS | ESTATUS | GENERAL | CENTRADO | LECTURA | SERIE | PRECIO | FECHA
        Dim VM_TIPOS As New ArrayList From {"K", "D", "D", "D", "ESTATUS", "PRECIO", "PRECIO", "GENERAL", "FECHA BOLD", "FECHA", "CENTRADO LARGO", "CENTRADO LARGO", "CENTRADO LARGO", "IZQUIERDA", "IZQUIERDA LARGO", "CENTRADO", "IZQUIERDA LARGO", "IZQUIERDA LARGO", "CENTRADO", "CENTRADO", "CENTRADO", "IZQUIERDA LARGO"}
        LIQ19_Codigo.NUEVO_LISTADO(VP_DATATABLE, LI_LISTADO, VM_CAMPOS, VM_TITULOS, VM_TIPOS)
    End Sub

    Public Sub PM_TB_INIT()
        LIQ19_Codigo.PG_TB_INIT(TB_K_OPERADOR, 5)
        LIQ19_Codigo.PG_TB_INIT(TB_SALARIO_DIARIO, 2, 1)
        LIQ19_Codigo.PG_TB_INIT(TB_SALARIO_DIARIO_INTEGRADO, 2, 1)
        LIQ19_Codigo.PG_TB_INIT(TB_NSS, 1)
        LIQ19_Codigo.PG_TB_INIT(TB_CP, 1)
        LIQ19_Codigo.PG_TB_INIT(TB_TELEFONO, 1)
        LIQ19_Codigo.PG_TB_INIT(TB_NUMERO_INTERIOR, 5)
        LIQ19_Codigo.PG_TB_INIT(TB_NUMERO_EXTERIOR, 5)
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
        TB_NOMBRE.Select()
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)

        If VM_IN_MODO_OPERACION <> MOP_Modo_Operacion.MOP4_Clon Then
            Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_OPERADOR, PP_ROW)
            Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)
        End If

        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_C_CHOFER, PP_ROW)
        '========================================================================
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ESTATUS_OPERADOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ESTADO_CIVIL, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_SEXO, PP_ROW)
        '========================================================================
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_NOMBRE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_APELLIDO_PATERNO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_APELLIDO_MATERNO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_RFC, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CURP, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_NSS, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_F_NACIMIENTO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_F_INGRESO, PP_ROW)
        '========================================================================
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_TELEFONO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CORREO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CALLE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_NUMERO_EXTERIOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_NUMERO_INTERIOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_COLONIA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CP, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_MUNICIPIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_NUMERO_LICENCIA_OPERADOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_F_VIGENCIA_LICENCIA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_MONEY("", TB_SALARIO_DIARIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD_MONEY("", TB_SALARIO_DIARIO_INTEGRADO, PP_ROW)

        Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)
    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_OPERADOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "APELLIDO_PATERNO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "APELLIDO_MATERNO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "NOMBRE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ESTATUS_OPERADOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "SALARIO_DIARIO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "SALARIO_DIARIO_INTEGRADO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "NUMERO_LICENCIA_OPERADOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_VIGENCIA_LICENCIA_DDMMMYYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_INGRESO_DDMMMYYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "RFC")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CURP")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "NSS")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "TELEFONO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CORREO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MUNICIPIO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "COLONIA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CALLE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "NUMERO_EXTERIOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "NUMERO_INTERIOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CP")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "C_OPERADOR")
        Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)
    End Sub

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_BUSCAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
    End Sub

    Private Sub PM_BT_AGREGAR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_AGREGAR_CLICK(PP_FORMA)
        PM_TB_INIT()
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

    Private Sub LI_LISTADO_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LI_LISTADO.CellDoubleClick
        If e.RowIndex <> -1 Then
            Codigo_LI.PG_LI_DOUBLE_CLICK(Me, LI_LISTADO)
        End If
    End Sub

    Private Sub BT_CLONAR_Click(sender As Object, e As EventArgs) Handles BT_CLONAR.Click
        PM_BT_CLONAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub CB_LI_ESTATUS_OPERADOR_DropDown(sender As Object, e As EventArgs) Handles CB_LI_ESTATUS_OPERADOR.DropDown
        Codigo_LI.PG_LI_CLEAR(LI_LISTADO)
    End Sub

#End Region
End Class