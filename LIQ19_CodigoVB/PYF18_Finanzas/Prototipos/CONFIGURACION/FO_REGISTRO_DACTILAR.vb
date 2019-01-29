Public Class FO_REGISTRO_DACTILAR
#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_HUELLA_1 As Byte() = New Byte() {}
    Public VM_HUELLA_2 As Byte() = New Byte() {}
    Public VM_HUELLA_3 As Byte() = New Byte() {}
    Public VM_HUELLA_4 As Byte() = New Byte() {}
    Public VM_HUELLA_5 As Byte() = New Byte() {}
    Public VM_HUELLA_6 As Byte() = New Byte() {}
    Public VM_HUELLA_7 As Byte() = New Byte() {}
    Public VM_HUELLA_8 As Byte() = New Byte() {}
    Public VM_HUELLA_9 As Byte() = New Byte() {}
    Public VM_HUELLA_10 As Byte() = New Byte() {}
    Public VM_ID_HUELLA_EN_PROCESO As Integer = 0
    Private VM_CARGA_FICHA = 0


#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESTATUS_REGISTRO_DACTILAR, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_REGISTRO_DACTILAR.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_REGISTRO_DACTILAR, False)
            PP_NUEVO = False

        End If
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_D_REGISTRO_DACTILAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_USUARIO, False)



        Return VP_PARAMETROS

    End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "D_USUARIO")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_REGISTRO_DACTILAR")
        Return VP_ID
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean

        Codigo_FI.PG_FI_FIELDS_VALIDATE(GB_FICHA, VP_VALIDACION, PP_MENSAJE_VALIDACION)



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
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_ESTATUS_REGISTRO_DACTILAR)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ESTATUS_REGISTRO_DACTILAR, "ESTATUS_ACTIVO")
        Codigo_CB.PG_CB_LOAD_X_DESCRIPCION(VM_ID_BASE_DE_DATOS, Me, CB_USUARIO)
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
        TB_D_REGISTRO_DACTILAR.Select()
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)

        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_REGISTRO_DACTILAR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_D_REGISTRO_DACTILAR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_USUARIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CH_L_DEDO_1, PP_ROW)
        If CH_L_DEDO_1.Checked Then
            VM_HUELLA_1 = PP_ROW("V_DEDO_1")
        End If
        Codigo_CTRL.PG_CO_DATA_LOAD("", CH_L_DEDO_2, PP_ROW)
        If CH_L_DEDO_2.Checked Then
            VM_HUELLA_2 = PP_ROW("V_DEDO_2")
        End If
        Codigo_CTRL.PG_CO_DATA_LOAD("", CH_L_DEDO_3, PP_ROW)
        If CH_L_DEDO_3.Checked Then
            VM_HUELLA_3 = PP_ROW("V_DEDO_3")
        End If
        Codigo_CTRL.PG_CO_DATA_LOAD("", CH_L_DEDO_4, PP_ROW)
        If CH_L_DEDO_4.Checked Then
            VM_HUELLA_4 = PP_ROW("V_DEDO_4")
        End If
        Codigo_CTRL.PG_CO_DATA_LOAD("", CH_L_DEDO_5, PP_ROW)
        If CH_L_DEDO_5.Checked Then
            VM_HUELLA_5 = PP_ROW("V_DEDO_5")
        End If
        Codigo_CTRL.PG_CO_DATA_LOAD("", CH_L_DEDO_6, PP_ROW)
        If CH_L_DEDO_6.Checked Then
            VM_HUELLA_6 = PP_ROW("V_DEDO_6")
        End If
        Codigo_CTRL.PG_CO_DATA_LOAD("", CH_L_DEDO_7, PP_ROW)
        If CH_L_DEDO_7.Checked Then
            VM_HUELLA_7 = PP_ROW("V_DEDO_7")
        End If
        Codigo_CTRL.PG_CO_DATA_LOAD("", CH_L_DEDO_8, PP_ROW)
        If CH_L_DEDO_8.Checked Then
            VM_HUELLA_8 = PP_ROW("V_DEDO_8")
        End If
        Codigo_CTRL.PG_CO_DATA_LOAD("", CH_L_DEDO_9, PP_ROW)
        If CH_L_DEDO_9.Checked Then
            VM_HUELLA_9 = PP_ROW("V_DEDO_9")
        End If
        Codigo_CTRL.PG_CO_DATA_LOAD("", CH_L_DEDO_10, PP_ROW)
        If CH_L_DEDO_10.Checked Then
            VM_HUELLA_10 = PP_ROW("V_DEDO_10")
        End If
        Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)
        VM_CARGA_FICHA = 0

    End Sub

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 21)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, 
        '            ANCHO_CELDA, ALINEACION, SOLO_LECTURA, Visible, FROZEN, FORMAT
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_REGISTRO_DACTILAR", "#RDC", GetType(Integer), 50, 2, 0, 1, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_REGISTRO_DACTILAR", "Descripción", GetType(String), 200, 1, 0, 1, 0, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_USUARIO", "Usuario", GetType(String), 150, 1, 0, 1, 0, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ESTATUS_REGISTRO_DACTILAR", "Estatus", GetType(String), 60, 2, 0, 1, 0, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "L_DEDO_1", "Dedo 1", GetType(CheckBox), 70, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "L_DEDO_2", "Dedo 2", GetType(CheckBox), 70, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "L_DEDO_3", "Dedo 3", GetType(CheckBox), 70, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "L_DEDO_4", "Dedo 4", GetType(CheckBox), 70, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "L_DEDO_5", "Dedo 5", GetType(CheckBox), 70, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "L_DEDO_6", "Dedo 6", GetType(CheckBox), 70, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "L_DEDO_7", "Dedo 7", GetType(CheckBox), 70, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "L_DEDO_8", "Dedo 8", GetType(CheckBox), 70, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "L_DEDO_9", "Dedo 9", GetType(CheckBox), 70, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "L_DEDO_10", "Dedo 10", GetType(CheckBox), 70, 2, 0, 1, 0, 0)
        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)

    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_REGISTRO_DACTILAR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_REGISTRO_DACTILAR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_USUARIO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ESTATUS_REGISTRO_DACTILAR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "L_DEDO_1")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "L_DEDO_2")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "L_DEDO_3")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "L_DEDO_4")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "L_DEDO_5")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "L_DEDO_6")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "L_DEDO_7")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "L_DEDO_8")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "L_DEDO_9")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "L_DEDO_10")
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

        ' Codigo_ABC.PG_BT_GUARDAR_CLICK(VM_ID_BASE_DE_DATOS,PP_FORMA, PP_LISTADO)
        Dim VP_SP As String = ""
        Dim VP_PARAMETROS As String = ""
        If TB_K_REGISTRO_DACTILAR.Text.Length = 0 Then
            VP_SP = "EXECUTE [PG_IN_REGISTRO_DACTILAR]"
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_D_REGISTRO_DACTILAR, False)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_USUARIO, True)
        Else
            VP_SP = "EXECUTE [PG_UP_REGISTRO_DACTILAR]"
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_REGISTRO_DACTILAR, False)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_D_REGISTRO_DACTILAR, True)
        End If
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_DEDO_1, False)
        PM_SP_PARAMETROS_ADD(VP_PARAMETROS, "@H1")
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_DEDO_2, False)
        PM_SP_PARAMETROS_ADD(VP_PARAMETROS, "@H2")
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_DEDO_3, False)
        PM_SP_PARAMETROS_ADD(VP_PARAMETROS, "@H3")
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_DEDO_4, False)
        PM_SP_PARAMETROS_ADD(VP_PARAMETROS, "@H4")
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_DEDO_5, False)
        PM_SP_PARAMETROS_ADD(VP_PARAMETROS, "@H5")
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_DEDO_6, False)
        PM_SP_PARAMETROS_ADD(VP_PARAMETROS, "@H6")
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_DEDO_7, False)
        PM_SP_PARAMETROS_ADD(VP_PARAMETROS, "@H7")
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_DEDO_8, False)
        PM_SP_PARAMETROS_ADD(VP_PARAMETROS, "@H8")
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_DEDO_9, False)
        PM_SP_PARAMETROS_ADD(VP_PARAMETROS, "@H9")
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_DEDO_10, False)
        PM_SP_PARAMETROS_ADD(VP_PARAMETROS, "@H10")
        Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

        Dim VP_SENTENCIA As String = VP_SP + VP_PARAMETROS

        Dim VP_CONNECTION As String = ""
        VP_CONNECTION = Codigo_CON.FG_CONNECTION_GET(VM_ID_BASE_DE_DATOS)

        Dim VP_CONEXION As New SqlClient.SqlConnection(VP_CONNECTION)
        Dim VP_READER As SqlClient.SqlDataReader
        Dim VP_DATATABLE As New DataTable
        Dim VP_EJECUTAR_SENTENCIA As Boolean = True

        If Codigo_CON.FG_CONEXION_CHECK(VP_CONNECTION) Then

            While VP_EJECUTAR_SENTENCIA
                Try
                    Dim VP_COMMAND As New SqlClient.SqlCommand(VP_SENTENCIA, VP_CONEXION)
                    PM_SQL_COMMAND_PARAMETROS_ADD(VP_COMMAND, "@H1", VM_HUELLA_1)
                    PM_SQL_COMMAND_PARAMETROS_ADD(VP_COMMAND, "@H2", VM_HUELLA_2)
                    PM_SQL_COMMAND_PARAMETROS_ADD(VP_COMMAND, "@H3", VM_HUELLA_3)
                    PM_SQL_COMMAND_PARAMETROS_ADD(VP_COMMAND, "@H4", VM_HUELLA_4)
                    PM_SQL_COMMAND_PARAMETROS_ADD(VP_COMMAND, "@H5", VM_HUELLA_5)
                    PM_SQL_COMMAND_PARAMETROS_ADD(VP_COMMAND, "@H6", VM_HUELLA_6)
                    PM_SQL_COMMAND_PARAMETROS_ADD(VP_COMMAND, "@H7", VM_HUELLA_7)
                    PM_SQL_COMMAND_PARAMETROS_ADD(VP_COMMAND, "@H8", VM_HUELLA_8)
                    PM_SQL_COMMAND_PARAMETROS_ADD(VP_COMMAND, "@H9", VM_HUELLA_9)
                    PM_SQL_COMMAND_PARAMETROS_ADD(VP_COMMAND, "@H10", VM_HUELLA_10)

                    VP_COMMAND.Connection.Open()
                    VP_READER = VP_COMMAND.ExecuteReader()
                    VP_DATATABLE.Load(VP_READER)
                    VP_EJECUTAR_SENTENCIA = False
                    VP_COMMAND.Connection.Close()
                    VM_IN_MODO_OPERACION = Modo_Operacion.Listado
                    Codigo_FRM.PG_FRM_CONFIG(PP_FORMA)
                    PM_BT_BUSCAR_CLICK(PP_FORMA, PP_LISTADO)
                Catch ex As Exception

                End Try
            End While

        End If
    End Sub

    Private Sub PM_SP_PARAMETROS_ADD(ByRef PP_PARAMETROS As String, ByVal PP_PARAMETRO As String)
        PP_PARAMETROS = PP_PARAMETROS + ", " + PP_PARAMETRO

    End Sub

    Private Sub PM_SQL_COMMAND_PARAMETROS_ADD(ByRef PP_SQLCOMMAND As SqlClient.SqlCommand, ByVal PP_PARAMETRO As String, ByVal PP_PARAMETRO_VALUE As Object)
        PP_SQLCOMMAND.Parameters.AddWithValue(PP_PARAMETRO, PP_PARAMETRO_VALUE)
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

#End Region

#Region "EVENTOS"

    Private Sub BT_AGREGAR_Click(sender As Object, e As EventArgs) Handles BT_AGREGAR.Click
        PM_BT_AGREGAR_CLICK(Me)
    End Sub

    Private Sub BT_BUSCAR_Click(sender As Object, e As EventArgs) Handles BT_LI_BUSCAR.Click
        '
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
            VM_CARGA_FICHA = 1
            Codigo_LI.PG_LI_DOUBLE_CLICK(Me, LI_LISTADO)
        End If
    End Sub

    Private Sub PG_HUELLA_CAPTURADA(template As DPFP.Template)
        Dim VP_BYTEARRAY As Byte() = New Byte() {}
        template.Serialize(VP_BYTEARRAY)
        If VP_BYTEARRAY.Length > 100 Then
            Select Case VM_ID_HUELLA_EN_PROCESO
                Case 1
                    VM_HUELLA_1 = VP_BYTEARRAY
                    CH_L_DEDO_1.Checked = True
                Case 2
                    VM_HUELLA_2 = VP_BYTEARRAY
                    CH_L_DEDO_2.Checked = True
                Case 3
                    VM_HUELLA_3 = VP_BYTEARRAY
                    CH_L_DEDO_3.Checked = True
                Case 4
                    VM_HUELLA_4 = VP_BYTEARRAY
                    CH_L_DEDO_4.Checked = True
                Case 5
                    VM_HUELLA_5 = VP_BYTEARRAY
                    CH_L_DEDO_5.Checked = True
                Case 6
                    VM_HUELLA_6 = VP_BYTEARRAY
                    CH_L_DEDO_6.Checked = True
                Case 7
                    VM_HUELLA_7 = VP_BYTEARRAY
                    CH_L_DEDO_7.Checked = True
                Case 8
                    VM_HUELLA_8 = VP_BYTEARRAY
                    CH_L_DEDO_8.Checked = True
                Case 9
                    VM_HUELLA_9 = VP_BYTEARRAY
                    CH_L_DEDO_9.Checked = True
                Case 10
                    VM_HUELLA_10 = VP_BYTEARRAY
                    CH_L_DEDO_10.Checked = True
            End Select
        Else
            Select Case VM_ID_HUELLA_EN_PROCESO
                Case 1
                    VM_HUELLA_1 = New Byte() {}
                    CH_L_DEDO_1.Checked = False
                Case 2
                    VM_HUELLA_2 = New Byte() {}
                    CH_L_DEDO_2.Checked = False
                Case 3
                    VM_HUELLA_3 = New Byte() {}
                    CH_L_DEDO_3.Checked = False
                Case 4
                    VM_HUELLA_4 = New Byte() {}
                    CH_L_DEDO_4.Checked = False
                Case 5
                    VM_HUELLA_5 = New Byte() {}
                    CH_L_DEDO_5.Checked = False
                Case 6
                    VM_HUELLA_6 = New Byte() {}
                    CH_L_DEDO_6.Checked = False
                Case 7
                    VM_HUELLA_7 = New Byte() {}
                    CH_L_DEDO_7.Checked = False
                Case 8
                    VM_HUELLA_8 = New Byte() {}
                    CH_L_DEDO_8.Checked = False
                Case 9
                    VM_HUELLA_9 = New Byte() {}
                    CH_L_DEDO_9.Checked = False
                Case 10
                    VM_HUELLA_10 = New Byte() {}
                    CH_L_DEDO_10.Checked = False
            End Select
        End If

        PB_HUELLA.Image = Nothing
        LB_ETIQUETA.Text = ""
        RT_SALIDA.Text = ""

    End Sub

    Private Sub CH_L_DEDO_1_CheckedChanged(sender As Object, e As EventArgs) Handles CH_L_DEDO_1.CheckedChanged
        VM_ID_HUELLA_EN_PROCESO = 1
        If CH_L_DEDO_1.Checked And Me.Visible And VM_CARGA_FICHA = 0 And VM_IN_MODO_OPERACION = Modo_Operacion.Edición Then
            PM_ENROLAR()
        Else
            VM_HUELLA_1 = New Byte() {}
        End If
    End Sub

    Private Sub CH_L_DEDO_2_CheckedChanged(sender As Object, e As EventArgs) Handles CH_L_DEDO_2.CheckedChanged
        VM_ID_HUELLA_EN_PROCESO = 2
        If CH_L_DEDO_2.Checked And Me.Visible And VM_CARGA_FICHA = 0 And VM_IN_MODO_OPERACION = Modo_Operacion.Edición Then
            PM_ENROLAR()
        Else
            VM_HUELLA_2 = New Byte() {}
        End If
    End Sub

    Private Sub CH_L_DEDO_3_CheckedChanged(sender As Object, e As EventArgs) Handles CH_L_DEDO_3.CheckedChanged
        VM_ID_HUELLA_EN_PROCESO = 3
        If CH_L_DEDO_3.Checked And Me.Visible And VM_CARGA_FICHA = 0 And VM_IN_MODO_OPERACION = Modo_Operacion.Edición Then
            PM_ENROLAR()
        Else
            VM_HUELLA_3 = New Byte() {}
        End If
    End Sub

    Private Sub CH_L_DEDO_4_CheckedChanged(sender As Object, e As EventArgs) Handles CH_L_DEDO_4.CheckedChanged
        VM_ID_HUELLA_EN_PROCESO = 4
        If CH_L_DEDO_4.Checked And Me.Visible And VM_CARGA_FICHA = 0 And VM_IN_MODO_OPERACION = Modo_Operacion.Edición Then
            PM_ENROLAR()
        Else
            VM_HUELLA_4 = New Byte() {}
        End If
    End Sub

    Private Sub CH_L_DEDO_5_CheckedChanged(sender As Object, e As EventArgs) Handles CH_L_DEDO_5.CheckedChanged
        VM_ID_HUELLA_EN_PROCESO = 5
        If CH_L_DEDO_5.Checked And Me.Visible And VM_CARGA_FICHA = 0 And VM_IN_MODO_OPERACION = Modo_Operacion.Edición Then
            PM_ENROLAR()
        Else
            VM_HUELLA_5 = New Byte() {}
        End If
    End Sub

    Private Sub CH_L_DEDO_6_CheckedChanged(sender As Object, e As EventArgs) Handles CH_L_DEDO_6.CheckedChanged
        VM_ID_HUELLA_EN_PROCESO = 6
        If CH_L_DEDO_6.Checked And Me.Visible And VM_CARGA_FICHA = 0 And VM_IN_MODO_OPERACION = Modo_Operacion.Edición Then
            PM_ENROLAR()
        Else
            VM_HUELLA_6 = New Byte() {}
        End If
    End Sub

    Private Sub CH_L_DEDO_7_CheckedChanged(sender As Object, e As EventArgs) Handles CH_L_DEDO_7.CheckedChanged
        VM_ID_HUELLA_EN_PROCESO = 7
        If CH_L_DEDO_7.Checked And Me.Visible And VM_CARGA_FICHA = 0 And VM_IN_MODO_OPERACION = Modo_Operacion.Edición Then
            PM_ENROLAR()
        Else
            VM_HUELLA_7 = New Byte() {}
        End If
    End Sub

    Private Sub CH_L_DEDO_8_CheckedChanged(sender As Object, e As EventArgs) Handles CH_L_DEDO_8.CheckedChanged
        VM_ID_HUELLA_EN_PROCESO = 8
        If CH_L_DEDO_8.Checked And Me.Visible And VM_CARGA_FICHA = 0 And VM_IN_MODO_OPERACION = Modo_Operacion.Edición Then
            PM_ENROLAR()
        Else
            VM_HUELLA_8 = New Byte() {}
        End If
    End Sub

    Private Sub CH_L_DEDO_9_CheckedChanged(sender As Object, e As EventArgs) Handles CH_L_DEDO_9.CheckedChanged
        VM_ID_HUELLA_EN_PROCESO = 9
        If CH_L_DEDO_9.Checked And Me.Visible And VM_CARGA_FICHA = 0 And VM_IN_MODO_OPERACION = Modo_Operacion.Edición Then
            PM_ENROLAR()
        Else
            VM_HUELLA_9 = New Byte() {}
        End If
    End Sub

    Private Sub CH_L_DEDO_10_CheckedChanged(sender As Object, e As EventArgs) Handles CH_L_DEDO_10.CheckedChanged
        VM_ID_HUELLA_EN_PROCESO = 10
        If CH_L_DEDO_10.Checked And Me.Visible And VM_CARGA_FICHA = 0 And VM_IN_MODO_OPERACION = Modo_Operacion.Edición Then
            PM_ENROLAR()
        Else
            VM_HUELLA_10 = New Byte() {}
        End If
    End Sub

    Private Sub PM_ENROLAR()
        Dim Capturer As New DPFP.Capture.Capture
        CheckForIllegalCrossThreadCalls = False
        Dim VP_ENROLADO As New Enrolado(Capturer, PB_HUELLA, RT_SALIDA, LB_ETIQUETA)
        VP_ENROLADO.Init()
        AddHandler VP_ENROLADO.OnTemplate, AddressOf PG_HUELLA_CAPTURADA
    End Sub

#End Region

End Class