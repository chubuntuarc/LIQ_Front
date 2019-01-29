Public Class FO_CUENTA_CONTABLE_UO

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_ID_ROW As String = ""
    Public VM_FILTRO_REFRESH As Boolean = False
    Public VM_CELL_COLOR As Color = Color.Yellow

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_FORMATO_CUENTA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_SOLO_PRESUPUESTO, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        'Dim VP_PARAMETROS = ""
        'PP_NUEVO = True
        'If TB_K_CUENTA_CONTABLE.Text <> "" Then
        '    Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_CUENTA_CONTABLE, False)
        '    PP_NUEVO = False
        'End If
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_D_CUENTA_CONTABLE, True)
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_C_CUENTA_CONTABLE, True)
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_S_CUENTA_CONTABLE, True)
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_O_CUENTA_CONTABLE, False)
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_D_CUENTA_CONTABLE_2, True)
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_D_CUENTA_CONTABLE_3, True)
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CODIGO, True)
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_AFECTABLE, False)
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_PRESUPUESTO, False)
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_ES_CUENTA_CONTABLE, False)
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_NIVEL_CUENTA_CONTABLE, False)
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_TIPO_CUENTA_CONTABLE, False)
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_SAT_AGRUPADOR, False)
        'Return VP_PARAMETROS

    End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "D_CUENTA_CONTABLE")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_CUENTA_CONTABLE")
        Return VP_ID
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean

        '  Codigo_FI.PG_FI_FIELDS_VALIDATE(GB_FICHA, VP_VALIDACION, PP_MENSAJE_VALIDACION)

        VP_VALIDACION = (PP_MENSAJE_VALIDACION = "")

        Return VP_VALIDACION
    End Function

    Public Function FM_LI_DATA_VALIDATE(ByRef PP_LISTADO As DataGridView) As Boolean
        Dim VP_INDR As Integer
        Dim VP_RESULTADO As Boolean = False
        For Each VP_FILA In PP_LISTADO.Rows
            VP_INDR = VP_FILA.Index
            Dim VP_DATO As String = PP_LISTADO.Rows(VP_INDR).Cells("Modificado").Value
            If VP_DATO = 1 Then
                Return True
            End If
        Next

        Return False

    End Function

    Public Function FM_LI_SQL_SAVE(ByVal PP_LI_LISTADO As DataGridView, ByVal PP_INDR As Integer) As String

        Dim VP_PARAMETROS As String = ""

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("K_CUENTA_CONTABLE_UO"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("K_CUENTA_CONTABLE"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_FORMATO_CUENTA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("O_CUENTA_CONTABLE"), False)
        Dim VP_BOOLEANO As Boolean = False
        VP_BOOLEANO = Codigo_LI.FG_LI_CELL_READ(PP_LI_LISTADO, PP_INDR, "EXISTE")
        Dim VP_EXISTE As Integer = Convert.ToInt32(VP_BOOLEANO)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_EXISTE, False)
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
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_UNIDAD_OPERATIVA, 0, 1, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
        'Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_UNIDAD_OPERATIVA)
        Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_FORMATO_CUENTA)
        'Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_SAT_AGRUPADOR)
        'Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_SAT_AGRUPADOR)
        'Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_FORMATO_CUENTA)
        'Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_TIPO_CUENTA_CONTABLE)
        VM_FILTRO_REFRESH = True
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

    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)

    End Sub

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 21)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, 
        '            ANCHO_CELDA, ALINEACION, SOLO_LECTURA, Visible, FROZEN, FORMAT
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_CUENTA_CONTABLE_UO", "#CCT", GetType(Integer), 60, 2, 0, 0, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "EXISTE", "Inlcuir", GetType(Integer), 60, 2, 1, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_CUENTA_CONTABLE", "#CCT", GetType(Integer), 60, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_CUENTA_CONTABLE", "Cuenta Contable", GetType(String), 250, 1, 0, 1, 1, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_UNIDAD_OPERATIVA", "K_UNIDAD_OPERATIVA", GetType(String), 180, 2, 0, 0, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_UNIDAD_OPERATIVA", "Unidad Operativa", GetType(Integer), 180, 1, 0, 0, 1, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "CODIGO", "Código", GetType(String), 80, 1, 0, 0, 0, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_TIPO_CUENTA_CONTABLE", "Tipo Cuenta Contable", GetType(String), 150, 1, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_SAT_AGRUPADOR", "Agrupador SAT", GetType(String), 150, 1, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "CLAVE", "Clave SAT", GetType(String), 100, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "O_CUENTA_CONTABLE", "#CCT", GetType(Integer), 60, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "L_AFECTABLE", "Es afectable", GetType(Integer), 80, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "L_PRESUPUESTO", "Es presupuesto", GetType(Integer), 80, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "L_ES_CUENTA_CONTABLE", "Es Cuenta Contable", GetType(Integer), 80, 2, 0, 1, 0, 0)
        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "Modificado", "Modificado", GetType(Integer), 90, 3, 1, 0, 0, 0)
        PP_LI_LISTADO.SelectionMode = DataGridViewSelectionMode.CellSelect
    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_CUENTA_CONTABLE_UO", 0)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "EXISTE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_CUENTA_CONTABLE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_CUENTA_CONTABLE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CODIGO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_TIPO_CUENTA_CONTABLE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_SAT_AGRUPADOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CLAVE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "O_CUENTA_CONTABLE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "L_AFECTABLE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "L_PRESUPUESTO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "L_ES_CUENTA_CONTABLE")
        Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)

        Codigo_LI.PG_LI_ROW_EDIT(PP_LISTADO, VP_ROW, False)
        If PP_ROW_DATA.Table.Columns.Contains("Modificado") Then
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "Modificado")
            Codigo_LI.PG_LI_ROW_COLOR_CHANGE(PP_LISTADO, VP_ROW, Color.Red)
        Else
            Codigo_LI.PG_LI_CELL_ZERO_FILL(PP_LISTADO, VP_ROW)
        End If
    End Sub

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        VM_NOMBRE_TABLA = "CUENTA_CONTABLE_UO_X_UNO"
        Codigo_ABC.PG_BT_BUSCAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
        VM_NOMBRE_TABLA = "CUENTA_CONTABLE_UO"
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

        Dim VP_INDR As Integer
        Try
            For Each VP_FILA In PP_LISTADO.Rows
                VP_INDR = VP_FILA.Index
                Dim VP_DATO As String = Codigo_LI.FG_LI_CELL_VALUE(PP_LISTADO, VP_INDR, "Modificado")
                If VP_DATO = 1 Then
                    VP_PARAMETROS = FM_LI_SQL_SAVE(PP_LISTADO, VP_INDR)

                    Dim VP_SP As String
                    VP_SP = Codigo_CON.FG_SQL_UPSERT(PP_FORMA)
                    Dim VP_EXITO As Boolean = False
                    VP_EXITO = Codigo_CON.FG_SQL_EJECUTAR_ACCION(PP_FORMA, VM_ID_BASE_DE_DATOS, PP_LISTADO, VP_SP, VP_PARAMETROS)
                End If
            Next
            ' BT_ACTUALIZAR.Enabled = True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub PM_BT_SELECCIONAR_TODOS_CHECK(sender As CheckBox, PP_LISTADO As DataGridView)
        If sender.Checked Then
            For Each VP_ROW As DataGridViewRow In LI_LISTADO.Rows
                Dim VL_CHK As DataGridViewCheckBoxCell = VP_ROW.Cells(1)
                VL_CHK.Value = True
                If BT_GUARDAR.Enabled = False Then
                    BT_GUARDAR.Visible = True
                    BT_GUARDAR.Enabled = True
                End If
                Codigo_LI.PG_LI_CELL_COLOR_CHANGE(LI_LISTADO, VP_ROW.Index, 1, VM_CELL_COLOR)
                Codigo_LI.PG_LI_CELL_MOD_WRITE(LI_LISTADO, VP_ROW.Index, 1)
            Next
        Else
            For Each VP_ROW As DataGridViewRow In LI_LISTADO.Rows
                Dim VL_CHK As DataGridViewCheckBoxCell = VP_ROW.Cells(1)
                VL_CHK.Value = False
                If BT_GUARDAR.Enabled = False Then
                    BT_GUARDAR.Visible = True
                    BT_GUARDAR.Enabled = True
                End If
                Codigo_LI.PG_LI_CELL_COLOR_CHANGE(LI_LISTADO, VP_ROW.Index, 1, VM_CELL_COLOR)
                Codigo_LI.PG_LI_CELL_MOD_WRITE(LI_LISTADO, VP_ROW.Index, 1)
            Next
        End If

    End Sub

#End Region

#Region "EVENTOS"

    Private Sub BT_AGREGAR_Click(sender As Object, e As EventArgs) Handles BT_AGREGAR.Click
        PM_BT_AGREGAR_CLICK(Me)
    End Sub

    Private Sub BT_BUSCAR_Click(sender As Object, e As EventArgs) Handles BT_LI_BUSCAR.Click

        'Codigo_Correo.PG_ENVIAR_CORREO_DESDE_PREMA("prueba", "danielpr96@gmail.com", "lolatest", "L:\2018.PROYECTOS\2018.PYF18_Finanzas\ENTREGAS A HECTOR\20181204\PYF18_R201_11.d_CI_Cuenta_Contable_UO_20181204_LBG.sql")

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

    'Private Sub LI_LISTADO_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LI_LISTADO.CellDoubleClick
    '    If e.RowIndex <> -1 Then
    '        Codigo_LI.PG_LI_DOUBLE_CLICK(Me, LI_LISTADO)
    '    End If
    'End Sub

    Private Sub LI_LISTADO_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles LI_LISTADO.CellBeginEdit
        If BT_GUARDAR.Enabled = False Then
            BT_GUARDAR.Visible = True
            BT_GUARDAR.Enabled = True
        End If
        Codigo_LI.PG_LI_CELL_COLOR_CHANGE(LI_LISTADO, e.RowIndex, e.ColumnIndex, VM_CELL_COLOR)
        Codigo_LI.PG_LI_CELL_MOD_WRITE(LI_LISTADO, e.RowIndex, e.ColumnIndex)
    End Sub

    Private Sub CH_SELECCIONAR_TODOS_CheckedChanged(sender As Object, e As EventArgs) Handles CH_SELECCIONAR_TODOS.CheckedChanged
        PM_BT_SELECCIONAR_TODOS_CHECK(sender, LI_LISTADO)
        If CH_SELECCIONAR_TODOS.Checked Then
            For Each VP_ROW As DataGridViewRow In LI_LISTADO.Rows

            Next
        End If
    End Sub

    Private Sub CB_UNIDAD_OPERATIVA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_UNIDAD_OPERATIVA.SelectedIndexChanged
        If VM_FILTRO_REFRESH Then
            PM_LI_INIT()
        End If
    End Sub


#End Region
End Class