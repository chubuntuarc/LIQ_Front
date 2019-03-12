Public Class FO_PRELIQUIDACION

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_CELL_COLOR As Color = Color.Yellow
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_TIPO_FICHA As Integer = 0
    Public VM_ROW As DataRow

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESTATUS_PRELIQUIDACION, False)

        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_PRELIQUIDACION.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_PRELIQUIDACION, False)
            PP_NUEVO = False
        End If

        PM_GUARDAR_DETALLE_PRELIQUIDACION(LI_DETALLE)

        Return VP_PARAMETROS

    End Function

    Public Function FM_TIPO_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_TIPO_PRELIQUIDACION")
        Return VP_ID
    End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "D_PRELIQUIDACION")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_PRELIQUIDACION")
        Return VP_ID
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean

        Codigo_FI.PG_FI_FIELDS_VALIDATE(GB_FICHA, VP_VALIDACION, PP_MENSAJE_VALIDACION)
        'Codigo_CTRL.PG_TB_INTEGER_VALIDATE(PP_MENSAJE_VALIDACION, TB_O_PUNTO_VENTA)

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
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_ESTATUS_PRELIQUIDACION, "ESTATUS_PRELIQUIDACION")
        CB_LI_ESTATUS_PRELIQUIDACION.SelectedIndex = 1

        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_K_OPERADOR, "OPERADOR")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_K_PUNTO_VENTA, "PUNTO_VENTA")
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

        If VM_TIPO_FICHA = 0 Then
            Dim VP_PARAMETROS As String = "'',-1,-1,1"
            PM_LI_FORMAT_DETALLE(LI_DETALLE) 'Encabezado lista de detalle de preliquidacion
            LIQ19_Codigo.PG_BT_BUSCAR_DETALLE(VM_ID_BASE_DE_DATOS, Me, LI_DETALLE, "PG_LI_PRODUCTO", VP_PARAMETROS)
        End If


        Codigo_FI.FG_FI_LOAD_X_ID(VM_ID_BASE_DE_DATOS, Me, PP_ID)
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)

        VM_ROW = PP_ROW

        If VM_IN_MODO_OPERACION <> MOP_Modo_Operacion.MOP4_Clon Then
            Codigo_CTRL.PG_CO_DATA_LOAD("K_PUNTO_VENTA", CB_K_PUNTO_VENTA, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("K_PRELIQUIDACION", TB_K_PRELIQUIDACION, PP_ROW)
            Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)
        End If

        Codigo_CTRL.PG_CO_DATA_LOAD("K_OPERADOR", CB_K_OPERADOR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_UNIDAD_OPERATIVA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_LECTURA_INICIAL, PP_ROW)

        Dim VP_K_PRELIQUIDACION As String = PP_ROW.Item(0)

        PM_LI_FORMAT_DETALLE(LI_DETALLE) 'Encabezado lista de detalle de preliquidacion
        Dim VP_PARAMETROS As String = "''," + VP_K_PRELIQUIDACION

        LIQ19_Codigo.PG_BT_BUSCAR_DETALLE(VM_ID_BASE_DE_DATOS, Me, LI_DETALLE, "PG_LI_DETALLE_PRELIQUIDACION", VP_PARAMETROS)


        Try
            Dim VP_PARAMETROS_DETALLE As String = "''," + TB_K_PRELIQUIDACION.Text

            Dim VP_DATATABLE As New Data.DataTable

            Codigo_ABC.PG_BT_EJECUTAR_ACCION_TABLA_CLICK(VM_ID_BASE_DE_DATOS, Me, "PG_LI_DETALLE_PRELIQUIDACION", VP_PARAMETROS_DETALLE, VP_DATATABLE) 'SE CREA UNA TABLA CON LOS VALORES DEVUELTOS POR EL SP

            Dim VP_LECTURA_INICIAL As String = Codigo_LI.FG_LI_CELL_READ(VP_DATATABLE, 0, "LECTURA_INICIAL") 'OBTIENE EL VALOR INDICADO
            Dim VP_PESO_INICIAL As String = Codigo_LI.FG_LI_CELL_READ(VP_DATATABLE, 0, "PESO_INICIAL") 'OBTIENE EL VALOR INDICADO
            Dim VP_NIVEL_INICIAL As String = Codigo_LI.FG_LI_CELL_READ(VP_DATATABLE, 0, "NIVEL_INICIAL") 'OBTIENE EL VALOR INDICADO
            Dim VP_CARBURACION_INICIAL As String = Codigo_LI.FG_LI_CELL_READ(VP_DATATABLE, 0, "CARBURACION_INICIAL") 'OBTIENE EL VALOR INDICADO

            TB_LECTURA_INICIAL.Text = VP_LECTURA_INICIAL
            TB_PESO_INICIAL.Text = VP_PESO_INICIAL
            TB_NIVEL_INICIAL.Text = VP_NIVEL_INICIAL
            TB_CARBURACION_INICIAL.Text = VP_CARBURACION_INICIAL
        Catch ex As Exception
            MessageBox.Show("Error " + ex.ToString())
        End Try

    End Sub

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 17)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, 
        '            ANCHO_CELDA, ALINEACION, SOLO_LECTURA, Visible, FROZEN, FORMAT..

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_PRELIQUIDACION", "#PRE", GetType(Integer), 50, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_PUNTO_VENTA", "Punto de venta", GetType(String), 150, 1, 0, 1, 1, 0, Nothing, Color.LightYellow, 1)

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_ESTATUS_PRELIQUIDACION", "Estatus", GetType(String), 60, 2, 0, 1, 0, 0, Color.DarkSlateGray, Color.Gainsboro, 1)

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_OPERADOR", "Operador", GetType(String), 150, 1, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_UNIDAD_OPERATIVA", "Unidad operativa", GetType(String), 150, 1, 0, 1, 0, 0, Nothing, Nothing, 1)

        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)

    End Sub

    Private Sub PM_LI_FORMAT_DETALLE(ByRef PP_LI_DETALLE As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_DETALLE, 8, 17)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, 
        '            ANCHO_CELDA, ALINEACION, SOLO_LECTURA, Visible, FROZEN, FORMAT, COLOR_FONT, COLOR_BACK, BOLD

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_DETALLE, "K_PRODUCTO", "#PRO", GetType(Integer), 50, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_DETALLE, "D_PRODUCTO", "Producto", GetType(String), 150, 1, 0, 1, 1, 0, Color.Orange, Nothing, 1)

        'Revisar si es insert 0 o update 1
        If VM_TIPO_FICHA = 0 Then
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_DETALLE, "O_PRODUCTO", "Carga inicial", GetType(String), 60, 2, 1, 1, 0, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
        Else
            Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_DETALLE, "TANQUE_INICIAL", "Carga inicial", GetType(String), 60, 2, 1, 1, 0, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
        End If

        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_DETALLE, 100, 2, 0, 0, 0, 0)

    End Sub


    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_PRELIQUIDACION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_PUNTO_VENTA")

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_ESTATUS_PRELIQUIDACION")

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_OPERADOR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")

        Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)

    End Sub

    Public Sub PM_LI_ROW_WRITE_DETALLE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_PRODUCTO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_PRODUCTO")

        'Revisar si es insert 0 o update 1
        If VM_TIPO_FICHA = 0 Then
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "O_PRODUCTO")
        Else
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "TANQUE_INICIAL")
        End If


        Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)

    End Sub

    Public Sub PM_GUARDAR_DETALLE_PRELIQUIDACION(ByRef PP_LISTADO As DataGridView)

        Try
            Dim VP_CONTA As Integer = 0
            'REGISTRAR PRELIQUIDACION
            Dim VP_PARAMETROS As String = ""

            Dim VP_D_PRELIQUIDACION As String = "PRELIQUIDACION"
            Dim VP_S_PRELIQUIDACION As String = "PRE"
            Dim VP_O_PRELIQUIDACION As Integer = 0
            Dim VP_L_PRELIQUIDACION As Integer = 1
            Dim VP_K_TIPO_PRLEIQUIDACION As Integer = 1 'ESTO SE DEBE DE CONSEGUIR DE LA FORMA
            Dim VP_K_ESTATUS_PRELIQUIDACION As Integer = 1
            Dim VP_K_PUNTO_VENTA As Integer = Integer.Parse(Codigo_CB.FG_CB_ITEM_VALUE(CB_K_PUNTO_VENTA))

            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_D_PRELIQUIDACION, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_S_PRELIQUIDACION, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_O_PRELIQUIDACION, False)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_L_PRELIQUIDACION, False)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_K_TIPO_PRLEIQUIDACION, False)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_K_ESTATUS_PRELIQUIDACION, False)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_K_PUNTO_VENTA, False)

            Console.WriteLine("PARAMETROS: " + VP_PARAMETROS)

            Dim VP_CLAVE As String
            Dim VP_MENSAJE As String
            If TB_K_PRELIQUIDACION.Text = "" Then
                Codigo_SQL.FG_SQL_EJECUTAR_ACCION_int(VM_ID_BASE_DE_DATOS, "PG_IN_PRELIQUIDACION", "0,0,0," + VP_PARAMETROS, VP_CLAVE, VP_MENSAJE)
            End If

            Dim VP_K_PRELIQUIDACION As Integer = Integer.Parse(VP_CLAVE)

            If VP_MENSAJE = "" Then
                VP_MENSAJE = "Operación Exitosa [#PRE: " + VP_CLAVE + "]."
                TB_K_PRELIQUIDACION.Text = VP_CLAVE

                'REGISTRAR DETALLE DE PRELIQUIDACION
                For Each VP_ROW_DATA As DataGridViewRow In PP_LISTADO.Rows
                    Dim VP_K_TOTALES As String = ""
                    VP_CONTA = VP_ROW_DATA.Index
                    VP_K_TOTALES = Codigo_LI.FG_LI_CELL_VALUE(PP_LISTADO, VP_CONTA, "D_PRODUCTO")
                    If VP_K_TOTALES <> "Totales" Then

                        Dim VP_PARAMETROS_DETALLE As String = ""

                        VP_K_PRELIQUIDACION = TB_K_PRELIQUIDACION.Text
                        Dim VP_K_PRODUCTO As String = Codigo_LI.FG_LI_CELL_VALUE(PP_LISTADO, VP_CONTA, "K_PRODUCTO")
                        Dim VP_LECTURA_INICIAL As String = TB_LECTURA_INICIAL.Text
                        Dim VP_LECTURA_FINAL As String = TB_LECTURA_INICIAL.Text
                        Dim VP_PESO_INICIAL As String = TB_PESO_INICIAL.Text
                        Dim VP_PESO_FINAL As String = TB_PESO_INICIAL.Text
                        Dim VP_NIVEL_INICIAL As String = TB_NIVEL_INICIAL.Text
                        Dim VP_NIVEL_FINAL As String = TB_NIVEL_INICIAL.Text
                        Dim VP_CARBURACION_INICIAL As String = TB_CARBURACION_INICIAL.Text
                        Dim VP_CARBURACION_FINAL As String = TB_CARBURACION_INICIAL.Text
                        Dim VP_TANQUE_INICIAL As String = Codigo_LI.FG_LI_CELL_VALUE(PP_LISTADO, VP_CONTA, "O_PRODUCTO")
                        Dim VP_TANQUE_FINAL As String = Codigo_LI.FG_LI_CELL_VALUE(PP_LISTADO, VP_CONTA, "O_PRODUCTO")

                        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS_DETALLE, VP_K_PRELIQUIDACION, False)
                        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS_DETALLE, VP_K_PRODUCTO, False)
                        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS_DETALLE, VP_LECTURA_INICIAL, False)
                        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS_DETALLE, VP_LECTURA_FINAL, False)
                        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS_DETALLE, VP_PESO_INICIAL, False)
                        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS_DETALLE, VP_PESO_FINAL, False)
                        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS_DETALLE, VP_NIVEL_INICIAL, False)
                        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS_DETALLE, VP_NIVEL_FINAL, False)
                        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS_DETALLE, VP_CARBURACION_INICIAL, False)
                        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS_DETALLE, VP_CARBURACION_FINAL, False)
                        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS_DETALLE, VP_TANQUE_INICIAL, False)
                        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS_DETALLE, VP_TANQUE_FINAL, False)

                        Dim VP_CLAVE_DETALLE As String
                        Dim VP_MENSAJE_DETALLE As String

                        Codigo_SQL.FG_SQL_EJECUTAR_ACCION_int(VM_ID_BASE_DE_DATOS, "PG_IN_DETALLE_PRELIQUIDACION", "0,0,0," + VP_PARAMETROS_DETALLE, VP_CLAVE_DETALLE, VP_MENSAJE_DETALLE)

                        If VP_MENSAJE_DETALLE = "" Then
                            VP_MENSAJE_DETALLE = "Operación Exitosa [#PRE: " + VP_CLAVE + " #DETALLE: " + VP_CLAVE_DETALLE + "]."
                        Else
                            Codigo_Mensaje.PG_MENSAJE_AVISO(VP_MENSAJE_DETALLE)
                        End If

                    End If
                Next

            Else
                Codigo_Mensaje.PG_MENSAJE_AVISO(VP_MENSAJE)
            End If
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_GUARDAR_CLICK")
        End Try
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

#End Region

#Region "EVENTOS"

    Private Sub BT_AGREGAR_Click(sender As Object, e As EventArgs) Handles BT_AGREGAR.Click
        VM_TIPO_FICHA = 0
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
        VM_TIPO_FICHA = 1
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
            VM_TIPO_FICHA = 1
            Codigo_LI.PG_LI_DOUBLE_CLICK(Me, LI_LISTADO)
        End If
    End Sub

    Private Sub BT_CLONAR_Click(sender As Object, e As EventArgs) Handles BT_CLONAR.Click
        PM_BT_CLONAR_CLICK(Me, LI_LISTADO)
    End Sub

#End Region

#Region "EVENTOS LISTADO"

    Private Sub LI_DETALLE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LI_DETALLE.KeyPress
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
                Handles LI_DETALLE.EditingControlShowing

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

    Private Sub LI_DETALLE_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles LI_DETALLE.CellBeginEdit
        Codigo_LI.PG_LI_CELL_COLOR_CHANGE(LI_DETALLE, e.RowIndex, e.ColumnIndex, VM_CELL_COLOR)
    End Sub

#End Region

#Region "EVENTOS CHANGE VALUE DE LOS PUNTOS DE VENTA"

    Private Sub CB_K_PUNTO_VENTA_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_K_PUNTO_VENTA.SelectedValueChanged

        If CB_K_PUNTO_VENTA.SelectedIndex <> -1 Then
            Dim VP_PARAMETROS = Codigo_CB.FG_CB_ITEM_VALUE(CB_K_PUNTO_VENTA)

            Dim VP_DATATABLE As New Data.DataTable

            Codigo_ABC.PG_BT_EJECUTAR_ACCION_TABLA_CLICK(VM_ID_BASE_DE_DATOS, Me, "PG_SK_PUNTO_VENTA", VP_PARAMETROS, VP_DATATABLE) 'SE CREA UNA TABLA CON LOS VALORES DEVUELTOS POR EL SP

            Dim VP_K_OPERADOR As Integer = Integer.Parse(Codigo_LI.FG_LI_CELL_READ(VP_DATATABLE, 0, "K_OPERADOR")) 'OBTIENE EL VALOR INDICADO
            Dim VP_K_UNIDAD_OPERATIVA As Integer = Integer.Parse(Codigo_LI.FG_LI_CELL_READ(VP_DATATABLE, 0, "K_UNIDAD_OPERATIVA")) 'OBTIENE EL VALOR INDICADO

            Codigo_CB.PG_CB_VALUE_LOAD(CB_K_OPERADOR, VP_K_OPERADOR) 'ASIGNAR EL VALOR AL CB DE OPERADOR
            Codigo_CB.PG_CB_VALUE_LOAD(CB_UNIDAD_OPERATIVA, VP_K_UNIDAD_OPERATIVA) 'ASIGNAR EL VALOR AL CB DE UNIDAD OPERATIVA
        End If

    End Sub

    Private Sub CH_ACTIVAR_PORTATIL_CheckedChanged(sender As Object, e As EventArgs) Handles CH_ACTIVAR_PORTATIL.CheckedChanged
        If CH_ACTIVAR_PORTATIL.Checked = True Then
            LI_PORTATIL.Visible = True
        Else
            LI_PORTATIL.Visible = False
        End If
    End Sub

#End Region

End Class