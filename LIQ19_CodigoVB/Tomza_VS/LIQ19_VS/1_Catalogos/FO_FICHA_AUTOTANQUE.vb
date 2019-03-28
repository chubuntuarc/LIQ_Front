Public Class FO_FICHA_AUTOTANQUE

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
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_UNIDAD_OPERATIVA, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL_PDV(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_PUNTO_VENTA.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_PUNTO_VENTA, False)
            PP_NUEVO = False
        End If

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_D_PUNTO_VENTA, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ESTATUS_PUNTO_VENTA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_TIPO_PUNTO_VENTA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_OPERADOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_AYUDANTE_1, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_AYUDANTE_2, False)

        Return VP_PARAMETROS

    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_PUNTO_VENTA.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_PUNTO_VENTA, False)
            PP_NUEVO = False
        Else
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_PDV, False)
        End If

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LECTURA_INICIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LECTURA_FINAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MATRICULA, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_MARCA_UNIDAD, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MODELO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_KILOMETRAJE, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_SERIE, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CAPACIDAD, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PORCENTAJE, False)

        Return VP_PARAMETROS

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

        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_LECTURA_INICIAL)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_LECTURA_FINAL)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_MODELO)

        VP_VALIDACION = (PP_MENSAJE_VALIDACION = "")
        Return VP_VALIDACION
    End Function

#End Region

#Region "SUB_PM_INIT"

    Public Sub PM_FO_SHOW(ByRef PP_NOMBRE_TABLA As String, ByVal PP_ID_BASE_DE_DATOS As String)
        VM_NOMBRE_TABLA = "PUNTO_VENTA"
        VM_ID_BASE_DE_DATOS = PP_ID_BASE_DE_DATOS
        Me.Show()
    End Sub

    Public Sub PM_CB_INIT()
        Codigo_FI.PG_FI_CONTROL_DATA_SETUP(VM_ID_BASE_DE_DATOS, Me)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_ESTATUS_PUNTO_VENTA, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_TIPO_PUNTO_VENTA, "")
        CB_LI_TIPO_PUNTO_VENTA.SelectedIndex = 1

        Codigo_TOMZA.PG_CB_UNIDAD_OPERATIVA_x_AccesoLoad(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, VG_USUARIO_ACCION)
        Codigo_TOMZA.PG_CB_ZONA_UO_x_AccesoLoad(VM_ID_BASE_DE_DATOS, Me, CB_LI_ZONA_UO, 1, VG_USUARIO_ACCION)
        Codigo_TOMZA.PG_CB_RAZON_SOCIAL_x_AccesoLoad(VM_ID_BASE_DE_DATOS, Me, CB_LI_RAZON_SOCIAL, 1, VG_USUARIO_ACCION)

        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ESTATUS_PUNTO_VENTA, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_TIPO_PUNTO_VENTA, "")

        Codigo_TOMZA.PG_CB_UNIDAD_OPERATIVA_x_AccesoLoad(VM_ID_BASE_DE_DATOS, Me, CB_UNIDAD_OPERATIVA, 1, VG_USUARIO_ACCION)

        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_OPERADOR, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_AYUDANTE_1, "OPERADOR")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_AYUDANTE_2, "OPERADOR")

        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_MARCA_UNIDAD, "")

    End Sub

    Public Sub PM_LI_INIT()
        'JAR || CREAR LISTADOS SENCILLOS../
        ' Dim VP_PARAMETROS_DETALLE As String = "''," + CB_LI_ESTATUS_PUNTO_VENTA.SelectedValue + ",2," + CB_LI_UNIDAD_OPERATIVA
        Dim VP_PARAMETROS_DETALLE As String = "'',-1,1,-1"
        Dim VP_DATATABLE As New DataTable
        Codigo_ABC.PG_BT_EJECUTAR_ACCION_TABLA_CLICK(VM_ID_BASE_DE_DATOS, Me, "PG_LI_PUNTO_VENTA", VP_PARAMETROS_DETALLE, VP_DATATABLE)
        Dim VM_CAMPOS As New ArrayList From {"K_PUNTO_VENTA", "D_PUNTO_VENTA", "S_ESTATUS_PUNTO_VENTA", "OPERADOR_NOMBRE", "D_UNIDAD_OPERATIVA", "LECTURA_INICIAL", "LECTURA_FINAL", "SERIE", "MATRICULA", "D_MARCA", "MODELO", "KILOMETRAJE", "CAPACIDAD", "PORCENTAJE"}
        Dim VM_TITULOS As New ArrayList From {"PDV", "Descripción", "Estatus", "Operador", "Unidad operativa", "Lectura inicial", "Lectura final", "No. Serie", "Matricula", "Marca", "Modelo", "Kilometraje", "Capacidad", "Porcentaje"}
        '///  K--ID | D--DESCRIPCION | S--SIGLAS | ESTATUS | GENERAL | CENTRADO | LECTURA | SERIE
        Dim VM_TIPOS As New ArrayList From {"K", "D", "ESTATUS", "GENERAL", "GENERAL", "LECTURA", "LECTURA", "SERIE", "CENTRADO", "CENTRADO LARGO", "CENTRADO", "DECIMAL LARGO", "DECIMAL LARGO", "PORCENTAJE"}

        LIQ19_Codigo.NUEVO_LISTADO(VP_DATATABLE, LI_LISTADO, VM_CAMPOS, VM_TITULOS, VM_TIPOS)
    End Sub

    Public Sub PM_TB_INIT()
        LIQ19_Codigo.PG_TB_INIT(TB_LECTURA_INICIAL, 2)
        LIQ19_Codigo.PG_TB_INIT(TB_LECTURA_FINAL, 2)
        LIQ19_Codigo.PG_TB_INIT(TB_MODELO, 1)
        LIQ19_Codigo.PG_TB_INIT(TB_KILOMETRAJE, 2)
        LIQ19_Codigo.PG_TB_INIT(TB_CAPACIDAD, 2)
        LIQ19_Codigo.PG_TB_INIT(TB_PORCENTAJE, 2)
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
        'Codigo_FI.FG_FI_LOAD_X_ID(VM_ID_BASE_DE_DATOS, Me, PP_ID)
        If PP_ID <> "" Then
            Dim VP_ROW As DataRow = Nothing
            Dim VP_ROW_AUT As DataRow = Nothing
            Dim VP_RESULTADO As Data.DataTable
            Dim VP_RESULTADO_AUTOTANQUE As Data.DataTable
            Dim VP_PARAMETROS As String = PP_ID
            Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

            VP_RESULTADO = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(VM_ID_BASE_DE_DATOS, "PG_SK_PUNTO_VENTA", VP_PARAMETROS)
            VP_RESULTADO_AUTOTANQUE = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(VM_ID_BASE_DE_DATOS, "PG_SK_FICHA_AUTOTANQUE", VP_PARAMETROS)

            If VP_RESULTADO.Rows.Count <> 0 Then
                VP_ROW = VP_RESULTADO.Rows(0)
                If VM_IN_MODO_OPERACION <> 4 Then
                    TB_K_PUNTO_VENTA.Text = VP_ROW(0).ToString()
                End If

                TB_D_PUNTO_VENTA.Text = VP_ROW(1).ToString()
                Codigo_CB.PG_CB_VALUE_LOAD(CB_ESTATUS_PUNTO_VENTA, Integer.Parse(VP_ROW("K_ESTATUS_PUNTO_VENTA")))
                Codigo_CB.PG_CB_VALUE_LOAD(CB_TIPO_PUNTO_VENTA, Integer.Parse(VP_ROW("K_TIPO_PUNTO_VENTA")))
                Codigo_CB.PG_CB_VALUE_LOAD(CB_UNIDAD_OPERATIVA, Integer.Parse(VP_ROW("K_UNIDAD_OPERATIVA")))
                Codigo_CB.PG_CB_VALUE_LOAD(CB_OPERADOR, Integer.Parse(VP_ROW("K_OPERADOR")))
                Codigo_CB.PG_CB_VALUE_LOAD(CB_AYUDANTE_1, Integer.Parse(VP_ROW("K_AYUDANTE_1")))
                Codigo_CB.PG_CB_VALUE_LOAD(CB_AYUDANTE_2, Integer.Parse(VP_ROW("K_AYUDANTE_2")))
                Codigo_CB.PG_CB_VALUE_LOAD(CB_USUARIO_ALTA, Integer.Parse(VP_ROW("K_USUARIO_ALTA")))
                TB_F_ALTA.Text = VP_ROW("F_ALTA").ToString()
                Codigo_CB.PG_CB_VALUE_LOAD(CB_USUARIO_CAMBIO, Integer.Parse(VP_ROW("K_USUARIO_CAMBIO")))
                TB_F_CAMBIO.Text = VP_ROW("F_CAMBIO").ToString()
            End If

            If VP_RESULTADO_AUTOTANQUE.Rows.Count <> 0 Then
                VP_ROW_AUT = VP_RESULTADO_AUTOTANQUE.Rows(0)
                Codigo_CB.PG_CB_VALUE_LOAD(CB_MARCA_UNIDAD, Integer.Parse(VP_ROW_AUT("K_MARCA")))
                TB_LECTURA_INICIAL.Text = VP_ROW_AUT("LECTURA_INICIAL").ToString()
                TB_LECTURA_FINAL.Text = VP_ROW_AUT("LECTURA_FINAL").ToString()
                TB_SERIE.Text = VP_ROW_AUT("SERIE").ToString()
                TB_MATRICULA.Text = VP_ROW_AUT("MATRICULA").ToString()
                TB_MODELO.Text = VP_ROW_AUT("MODELO").ToString()
                TB_KILOMETRAJE.Text = VP_ROW_AUT("KILOMETRAJE").ToString()
                TB_CAPACIDAD.Text = VP_ROW_AUT("CAPACIDAD").ToString()
                TB_PORCENTAJE.Text = VP_ROW_AUT("PORCENTAJE").ToString()
            End If

        End If


    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_PUNTO_VENTA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_PUNTO_VENTA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ESTATUS_PUNTO_VENTA")

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "OPERADOR_NOMBRE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "LECTURA_INICIAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "LECTURA_FINAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "SERIE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MATRICULA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_MARCA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MODELO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "KILOMETRAJE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CAPACIDAD")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PORCENTAJE")

        Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)
    End Sub

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_BUSCAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO, "PG_LI_PUNTO_VENTA")
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
        Codigo_ABC.PG_BT_ELIMINAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO, "PG_DL_PUNTO_VENTA")
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
        Dim VP_NUEVO As Boolean
        Dim VP_PARAMETROS As String = FM_FI_SQL_PDV(VP_NUEVO)
        Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
        Dim VP_CLAVE As Integer = 0
        Dim VP_DataTable As New DataTable

        If TB_K_PUNTO_VENTA.Text <> "" Then
            VP_DataTable = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(VM_ID_BASE_DE_DATOS, "PG_UP_PUNTO_VENTA", VP_PARAMETROS)
            VP_CLAVE = TB_K_PUNTO_VENTA.Text
        Else
            VP_DataTable = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(VM_ID_BASE_DE_DATOS, "PG_IN_PUNTO_VENTA", VP_PARAMETROS)
            VP_CLAVE = Codigo_LI.FG_LI_CELL_READ(VP_DataTable, 0, "CLAVE")
        End If

        TB_K_PDV.Text = VP_CLAVE.ToString()

        PM_BT_GUARDAR_CLICK(Me, LI_LISTADO) 'YA QUE SE TIENE EL ID DEL PDV, SE GUARDAN LOS DATOS DEL AUTOTANQUE.

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

    Private Sub CB_LI_UNIDAD_OPERATIVA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_LI_UNIDAD_OPERATIVA.SelectedIndexChanged

    End Sub

#End Region

End Class