Public Class FO_CUENTA_CONTABLE

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_ID_ROW As String = ""
    Public VM_FILTRO_REFRESH As Boolean = False

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_NIVEL_CUENTA_CONTABLE, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIPO_CUENTA_CONTABLE, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_SAT_AGRUPADOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_LI_AFECTABLE, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_LI_PRESUPUESTO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_LI_ES_CUENTA_CONTABLE, False)

        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_CUENTA_CONTABLE.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_CUENTA_CONTABLE, False)
            PP_NUEVO = False
        End If
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_D_CUENTA_CONTABLE, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_C_CUENTA_CONTABLE, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_S_CUENTA_CONTABLE, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_O_CUENTA_CONTABLE, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_D_CUENTA_CONTABLE_2, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_D_CUENTA_CONTABLE_3, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CODIGO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_AFECTABLE, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_PRESUPUESTO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_ES_CUENTA_CONTABLE, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_NIVEL_CUENTA_CONTABLE, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_TIPO_CUENTA_CONTABLE, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_SAT_AGRUPADOR, False)
        Return VP_PARAMETROS

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

        Codigo_FI.PG_FI_FIELDS_VALIDATE(GB_FICHA, VP_VALIDACION, PP_MENSAJE_VALIDACION)

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

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("K_CUENTA_CONTABLE"), False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("D_CUENTA_CONTABLE"), True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("CUENTA_CONTABLE"), True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("RFC_CUENTA_CONTABLE"), True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("CORREO"), True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("TELEFONO"), True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("CALLE"), True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("COLONIA"), True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("POBLACION"), True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("MUNICIPIO"), True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("ESTADO"), True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_LI_LISTADO.Rows(PP_INDR).Cells("PAIS"), True)

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
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_NIVEL_CUENTA_CONTABLE)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_NIVEL_CUENTA_CONTABLE)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_SAT_AGRUPADOR)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_SAT_AGRUPADOR)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_TIPO_CUENTA_CONTABLE)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_TIPO_CUENTA_CONTABLE)
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
        Codigo_FI.FG_FI_LOAD_X_ID(VM_ID_BASE_DE_DATOS,  Me, PP_ID)
        'CB_UNIDAD_OPERATIVA.Select()
        CB_SAT_AGRUPADOR.Enabled = True
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)

        If VM_IN_MODO_OPERACION <> Modo_Operacion.Clon Then
            Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_CUENTA_CONTABLE, PP_ROW)
            Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)
        End If
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_D_CUENTA_CONTABLE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_S_CUENTA_CONTABLE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_D_CUENTA_CONTABLE_2, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_D_CUENTA_CONTABLE_3, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_SAT_AGRUPADOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_TIPO_CUENTA_CONTABLE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_NIVEL_CUENTA_CONTABLE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_TIPO_CUENTA_CONTABLE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CODIGO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CH_L_AFECTABLE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CH_L_PRESUPUESTO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CH_L_ES_CUENTA_CONTABLE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_O_CUENTA_CONTABLE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_C_CUENTA_CONTABLE, PP_ROW)

    End Sub

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 21)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, 
        '            ANCHO_CELDA, ALINEACION, SOLO_LECTURA, Visible, FROZEN, FORMAT

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_CUENTA_CONTABLE", "#RZS", GetType(Integer), 50, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_CUENTA_CONTABLE", "Descripción", GetType(String), 250, 1, 0, 1, 1, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_CUENTA_CONTABLE", "Siglas", GetType(String), 60, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "O_CUENTA_CONTABLE", "Orden", GetType(Integer), 60, 1, 0, 0, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "C_CUENTA_CONTABLE", "Comentarios", GetType(String), 50, 1, 0, 0, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_CUENTA_CONTABLE_2", "Nombre 2", GetType(String), 150, 1, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_CUENTA_CONTABLE_3", "Nombre 3", GetType(String), 150, 1, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "CODIGO", "Código", GetType(String), 120, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_NIVEL_CUENTA_CONTABLE", "Nivel", GetType(String), 80, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_TIPO_CUENTA_CONTABLE", "Tipo", GetType(String), 140, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "L_AFECTABLE", "Es afectable", GetType(Integer), 80, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "L_PRESUPUESTO", "Es presupuesto", GetType(Integer), 80, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "L_ES_CUENTA_CONTABLE", "Es Cuenta Contable", GetType(Integer), 80, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_SAT_AGRUPADOR", "Agrupador SAT", GetType(String), 380, 1, 0, 1, 1, 0)
        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)
        ' Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "Modificado", "Modificado", GetType(Integer), 100, 3, 1, 1, 0, 0)
    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_CUENTA_CONTABLE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_CUENTA_CONTABLE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_CUENTA_CONTABLE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "O_CUENTA_CONTABLE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "C_CUENTA_CONTABLE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_CUENTA_CONTABLE_2")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_CUENTA_CONTABLE_3")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CODIGO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_NIVEL_CUENTA_CONTABLE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_TIPO_CUENTA_CONTABLE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "L_AFECTABLE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "L_PRESUPUESTO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "L_ES_CUENTA_CONTABLE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_SAT_AGRUPADOR")
        Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)
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
                    VP_SP = Codigo_CON.FG_SQL_UPDATE(PP_FORMA)


                    Dim VP_EXITO As Boolean = False
                    VP_EXITO = Codigo_CON.FG_SQL_EJECUTAR_ACCION(PP_FORMA, VM_ID_BASE_DE_DATOS, PP_LISTADO, VP_SP, VP_PARAMETROS)


                End If
            Next
            ' BT_ACTUALIZAR.Enabled = True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
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

    Private Sub CB_LI_REGION_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_LI_NIVEL_CUENTA_CONTABLE.SelectedValueChanged
        If VM_FILTRO_REFRESH Then
            PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
        End If
    End Sub

    Private Sub BT_CLONAR_Click(sender As Object, e As EventArgs) Handles BT_CLONAR.Click
        PM_BT_CLONAR_CLICK(Me, LI_LISTADO)
    End Sub

#End Region
End Class