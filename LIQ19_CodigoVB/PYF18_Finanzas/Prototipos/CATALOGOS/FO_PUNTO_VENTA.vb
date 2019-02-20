Public Class FO_PUNTO_VENTA

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESTATUS_PUNTO_VENTA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIPO_PUNTO_VENTA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_K_UNIDAD_OPERATIVA, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_PUNTO_VENTA.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_PUNTO_VENTA, False)
            PP_NUEVO = False

        End If

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_D_PUNTO_VENTA, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_S_PUNTO_VENTA, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_C_PUNTO_VENTA, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_O_PUNTO_VENTA, False)
        ''-----------------------------------------------------------------''
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_PUNTO_VENTA, False)
        ''-----------------------------------------------------------------''
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_TIPO_PUNTO_VENTA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_UNIDAD_OPERATIVA, False)
        ''-----------------------------------------------------------------''
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_OPERADOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_AYUDANTE_1, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_AYUDANTE_2, False)
        ''-----------------------------------------------------------------''

        ''//AUTOTANUQES//
        If TB_LECTURA_INICIAL_AUT.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LECTURA_INICIAL_AUT, False)
        Else
            TB_LECTURA_INICIAL_AUT.Text = "0"
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LECTURA_INICIAL_AUT, False)
        End If

        If TB_LECTURA_FINAL_AUT.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LECTURA_FINAL_AUT, False)
        Else
            TB_LECTURA_FINAL_AUT.Text = "0"
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LECTURA_FINAL_AUT, False)
        End If

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MATRICULA_AUT, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MARCA_AUT, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MODELO_AUT, True)

        If TB_KILOMETRAJE_AUT.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_KILOMETRAJE_AUT, False)
        Else
            TB_KILOMETRAJE_AUT.Text = "0"
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_KILOMETRAJE_AUT, False)
        End If

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_SERIE_AUT, True)

        If TB_CAPACIDAD_AUT.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CAPACIDAD_AUT, False)
        Else
            TB_CAPACIDAD_AUT.Text = "0"
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CAPACIDAD_AUT, False)
        End If

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PORCENTAJE_AUT, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MEDIDOR_AUT, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_TIPO_MEDIDOR_AUT, True)
        ''-----------------------------------------------------------------''

        ''//ESTACIONES//
        If TB_LECTURA_INICIAL_EST.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LECTURA_INICIAL_EST, False)
        Else
            TB_LECTURA_INICIAL_EST.Text = "0"
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LECTURA_INICIAL_EST, False)
        End If

        If TB_LECTURA_FINAL_EST.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LECTURA_FINAL_EST, False)
        Else
            TB_LECTURA_FINAL_EST.Text = "0"
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LECTURA_FINAL_EST, False)
        End If

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_DIRECCION_EST, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CAPACIDAD_EST, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PORCENTAJE_EST, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MEDIDOR_EST, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_TIPO_MEDIDOR_EST, True)
        ''-----------------------------------------------------------------''

        ''//PORTATILES//
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MATRICULA_POR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MARCA_POR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MODELO_POR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_KILOMETRAJE_POR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_SERIE_POR, True)
        If TB_CAPACIDAD_POR.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CAPACIDAD_POR, False)
        Else
            TB_CAPACIDAD_POR.Text = "0"
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CAPACIDAD_POR, False)
        End If

        ''-----------------------------------------------------------------''

        Return VP_PARAMETROS

    End Function

    Public Function FM_TIPO_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_TIPO_PUNTO_VENTA")
        Return VP_ID
    End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "D_PUNTO_VENTA")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_PUNTO_VENTA")
        Return VP_ID
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean

        Codigo_FI.PG_FI_FIELDS_VALIDATE(GB_FICHA, VP_VALIDACION, PP_MENSAJE_VALIDACION)

        Codigo_CTRL.PG_TB_INTEGER_VALIDATE(PP_MENSAJE_VALIDACION, TB_O_PUNTO_VENTA)


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
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_TIPO_PUNTO_VENTA, "TIPO_PUNTO_VENTA")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_TIPO_PUNTO_VENTA, "TIPO_PUNTO_VENTA")

        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_ESTATUS_PUNTO_VENTA, "ESTATUS_PUNTO_VENTA")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_K_UNIDAD_OPERATIVA, "UNIDAD_OPERATIVA")

        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_OPERADOR, "OPERADOR")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_AYUDANTE_1, "OPERADOR")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_AYUDANTE_2, "OPERADOR")

        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_UNIDAD_OPERATIVA, "UNIDAD_OPERATIVA")
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
        TB_D_PUNTO_VENTA.Select()
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)

        If VM_IN_MODO_OPERACION <> Modo_Operacion.Clon Then
            Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_PUNTO_VENTA, PP_ROW)
            Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)
        End If

        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_D_PUNTO_VENTA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_C_PUNTO_VENTA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_S_PUNTO_VENTA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_O_PUNTO_VENTA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_TIPO_PUNTO_VENTA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_UNIDAD_OPERATIVA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CH_L_PUNTO_VENTA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_OPERADOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_AYUDANTE_1, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_AYUDANTE_2, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_C_PUNTO_VENTA, PP_ROW)
        ''-----------------------------------------------------------------''

        Dim VP_TIPO_PUNTO_VENTA = PP_ROW("K_TIPO_PUNTO_VENTA")

        ''//AUTOTANUQES//
        If VP_TIPO_PUNTO_VENTA = 1 Then
            GB_AUTOTANQUE.Visible = True
            GB_ESTACION_CARBURACION.Visible = False
            GB_PORTATIL.Visible = False
            ''-----------------------------------------------------------------''
            Codigo_CTRL.PG_CO_DATA_LOAD("LECTURA_INICIAL", TB_LECTURA_INICIAL_AUT, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("LECTURA_FINAL", TB_LECTURA_FINAL_AUT, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("MARCA", TB_MARCA_AUT, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("MODELO", TB_MODELO_AUT, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("KILOMETRAJE", TB_KILOMETRAJE_AUT, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("SERIE", TB_SERIE_AUT, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("CAPACIDAD", TB_CAPACIDAD_AUT, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("PORCENTAJE", TB_PORCENTAJE_AUT, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("MEDIDOR", TB_MEDIDOR_AUT, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("TIPO_MEDIDOR", TB_TIPO_MEDIDOR_AUT, PP_ROW)
        End If


        ''//ESTACIONES//
        If VP_TIPO_PUNTO_VENTA = 2 Then
            GB_AUTOTANQUE.Visible = False
            GB_ESTACION_CARBURACION.Visible = True
            GB_PORTATIL.Visible = False
            ''-----------------------------------------------------------------''
            Codigo_CTRL.PG_CO_DATA_LOAD("LECTURA_INICIAL", TB_LECTURA_INICIAL_EST, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("LECTURA_FINAL", TB_LECTURA_FINAL_EST, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("DIRECCION", TB_DIRECCION_EST, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("CAPACIDAD", TB_CAPACIDAD_EST, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("PORCENTAJE", TB_PORCENTAJE_EST, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("MEDIDOR", TB_MEDIDOR_EST, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("TIPO_MEDIDOR", TB_TIPO_MEDIDOR_EST, PP_ROW)
        End If


        ''//PORTATILES//
        If VP_TIPO_PUNTO_VENTA = 3 Then
            GB_AUTOTANQUE.Visible = False
            GB_ESTACION_CARBURACION.Visible = False
            GB_PORTATIL.Visible = True
            ''-----------------------------------------------------------------''
            Codigo_CTRL.PG_CO_DATA_LOAD("MATRICULA", TB_MATRICULA_POR, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("MARCA", TB_MARCA_POR, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("MODELO", TB_MODELO_POR, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("KILOMETRAJE", TB_KILOMETRAJE_POR, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("SERIE", TB_SERIE_POR, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("CAPACIDAD", TB_CAPACIDAD_POR, PP_ROW)
        End If


    End Sub

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 17)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, 
        '            ANCHO_CELDA, ALINEACION, SOLO_LECTURA, Visible, FROZEN, FORMAT
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_PUNTO_VENTA", "#PDV", GetType(Integer), 50, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_PUNTO_VENTA", "Punto de Venta", GetType(String), 150, 1, 0, 1, 1, 0, Nothing, Nothing, 1)

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_ESTATUS_PUNTO_VENTA", "Estatus", GetType(String), 60, 2, 0, 1, 0, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_TIPO_PUNTO_VENTA", "Tipo", GetType(String), 60, 2, 0, 1, 0, 0)

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_UNIDAD_OPERATIVA", "Unidad Operativa", GetType(String), 150, 1, 0, 1, 0, 0, Nothing, Nothing, 1)

        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)

    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_PUNTO_VENTA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_PUNTO_VENTA")

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_ESTATUS_PUNTO_VENTA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_TIPO_PUNTO_VENTA")

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")

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

    Private Sub PM_CB_TIPO_PUNTO_VENTA_VALOR_CAMBIA()
        Dim VP_TIPO_PUNTO_VENTA As String = CB_TIPO_PUNTO_VENTA.SelectedItem.Value.ToString()

        Select Case VP_TIPO_PUNTO_VENTA
            Case "1"
                GB_AUTOTANQUE.Visible = True
                GB_ESTACION_CARBURACION.Visible = False
                GB_PORTATIL.Visible = False
            Case "2"
                GB_AUTOTANQUE.Visible = False
                GB_ESTACION_CARBURACION.Visible = True
                GB_PORTATIL.Visible = False
            Case "3"
                GB_AUTOTANQUE.Visible = False
                GB_ESTACION_CARBURACION.Visible = False
                GB_PORTATIL.Visible = True
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

    Private Sub CB_TIPO_PUNTO_VENTA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_TIPO_PUNTO_VENTA.SelectedIndexChanged
        PM_CB_TIPO_PUNTO_VENTA_VALOR_CAMBIA()
    End Sub


#End Region

End Class