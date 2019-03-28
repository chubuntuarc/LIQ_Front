Imports System.Data.SqlClient

Public Class Codigo_SQL
    Public Const CG_SQL_EJECUTAR As String = "EXECUTE"
    REM ----------------------------------------------------
    Public Const CG_SQL_PG_PREFIJO As String = "PG"
    Public Const CG_SQL_SP_DELETE As String = "DL"
    Public Const CG_SQL_SP_INSERT As String = "IN"
    Public Const CG_SQL_SP_UPDATE As String = "UP"
    Public Const CG_SQL_SP_UPSERTE As String = "IU"
    Public Const CG_SQL_SP_SEEK As String = "SK"
    Public Const CG_SQL_SP_LIST As String = "LI"
    Public Const CG_SQL_SP_REGLA As String = "RN"
    REM ----------------------------------------------------
    Public Const CG_SQL_SP_LOG_DESARROLLO As String = "LOG_DESARROLLO"
    Public Const CG_SQL_SP_COMBO_BASICO As String = "TABLA_N1_Load"
    Public Const CG_SQL_SP_GRAFICA As String = "GRAFICA"
    Public Const CG_SQL_SP_USUARIOS_GRUPO As String = "USUARIO"

    Public Const CG_SQL_MASIVO As String = "MASIVO"
    Public Const CG_SQL_SP_DEBUG As String = "0"
    Public Const CG_SQL_CIRCULAR As String = "PRECIOS"

    Public Const CG_SQL_SP_ICS As String = "ICS"
    Public Const CG_SQL_SP_LOG As String = "LOG"
    Public Const CG_SQL_SP_ESTATUS As String = "ESTATUS"

    Public Const CG_SQL_SP_PREFIJO_IN_UP As String = "IN_UP"

    Public Const CG_SQL_CB_PREFIJO As String = "CB"

    Public Const CG_SQL_SP_VER As String = "VERSION"




    Public Shared Function FG_RN_GetDato(ByRef PP_BD_Index As Integer, PP_STORED_PROCEDURE As String, PP_PARAMETROS As String, PP_COLUMNA As String) As String

        Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(PP_PARAMETROS)

        Dim VP_TABLA As Data.DataTable
        VP_TABLA = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(PP_BD_Index, PP_STORED_PROCEDURE, PP_PARAMETROS)

        Dim VP_RESULTADO As String = ""

        Dim VP_N_REGISTROS As Integer
        VP_N_REGISTROS = VP_TABLA.Rows.Count()

        If VP_N_REGISTROS <> 0 Then

            VP_RESULTADO = (Codigo_SQL.FG_DataRow_READ_str(VP_TABLA.Rows(0), PP_COLUMNA))

        End If

        Return VP_RESULTADO

    End Function


    Public Shared Function FG_DataRow_IsDBNull(ByVal PP_ROW_DATA As DataRow, ByVal PP_NOMBRE_DATO As String) As Boolean

        Dim VP_ES_NULO As Boolean = False

        Try

            VP_ES_NULO = IsDBNull(PP_ROW_DATA(PP_NOMBRE_DATO))

        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("FG_DataRow_IsDBNull")
        End Try

        Return VP_ES_NULO

    End Function


    Public Shared CL_BD_CONEXION_LISTA As New List(Of CL_BD_CONEXION)



    Public Shared Sub PG_BOTON_ACTIVO(ByRef PP_BOTON As Object, ByRef PP_BD_Index As Integer, PP_FO_NOMBRE As String)

        'Dim VP_STORED_PROCEDURE As String = "[PG_SK_SYS_PERFIL_DEFINICION]"
        Dim VP_STORED_PROCEDURE As String = "[PG_SK_SYS2_ACCESO_USR_FRM_ACCIONES]"
        Dim VP_PARAMETROS As String = PP_FO_NOMBRE

        Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

        Dim VP_TABLA As Data.DataTable
        VP_TABLA = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(PP_BD_Index, VP_STORED_PROCEDURE, VP_PARAMETROS)

        Dim VP_N_REGISTROS As Integer
        VP_N_REGISTROS = VP_TABLA.Rows.Count()

        If VP_N_REGISTROS = 0 Then
            PP_BOTON.VISIBLE = False
        Else
            PP_BOTON.VISIBLE = (FG_DataRow_READ_int(VP_TABLA.Rows(0), "K_SYS2_PERFIL_ACCESO") <> 4)
        End If

    End Sub


    Public Shared Function FG_DataRow_READ_decimal(ByVal PP_ROW_DATA As DataRow, ByVal PP_NOMBRE_DATO As String, PP_DEFAULT As Decimal) As Decimal

        Dim VP_VALOR As Decimal = PP_DEFAULT

        Try

            VP_VALOR = Convert.ToBoolean(PP_ROW_DATA(PP_NOMBRE_DATO))

        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("FG_DataRow_READ_decimal")
        End Try

        Return VP_VALOR

    End Function


    Public Shared Function FG_DataRow_READ_int(ByVal PP_ROW_DATA As DataRow, ByVal PP_NOMBRE_DATO As String, Optional PP_DEFAULT As Integer = 0) As Integer

        Dim VP_VALOR As Integer = PP_DEFAULT

        Try

            VP_VALOR = PP_ROW_DATA(PP_NOMBRE_DATO)

        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("FG_DataRow_READ_int")
        End Try

        Return VP_VALOR

    End Function


    Public Shared Function FG_DataRow_READ_boolean(ByVal PP_ROW_DATA As DataRow, ByVal PP_NOMBRE_DATO As String, PP_DEFAULT As Boolean) As Boolean

        Dim VP_VALOR As Boolean = PP_DEFAULT

        Try

            VP_VALOR = Convert.ToBoolean(PP_ROW_DATA(PP_NOMBRE_DATO))

        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("FG_DataRow_READ_boolean")
        End Try

        Return VP_VALOR

    End Function


    Public Shared Function FG_DataRow_READ_str(ByVal PP_ROW_DATA As DataRow, ByVal PP_NOMBRE_DATO As String, Optional PP_DEFAULT As String = "") As String

        Dim VP_VALOR As String = PP_DEFAULT

        Try

            VP_VALOR = PP_ROW_DATA(PP_NOMBRE_DATO)

        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("FG_DataRow_READ_str")
        End Try

        Return VP_VALOR

    End Function


#Region "CONEXION"

    Public Shared Function FG_CONNECTION_GET(ByVal PP_BD_Index As Integer, Optional ByRef PP_SERVER As String = "", Optional ByRef PP_BASE_DE_DATOS As String = "") As String
        Dim VG_SQL_BD_SERVER As String = ""
        Dim VG_SQL_BD_DATABASE As String = ""
        Dim VG_SQL_BD_PASSWORD As String = ""
        Dim VG_SQL_BD_USER As String = ""
        Dim VP_CADENA_CONEXION As String = ""

        Try
            SYS_SetUp.PG_BD_CONEXION_List_Init()

            Dim CG_CONEXION_ACTUAL As CL_BD_CONEXION

            CG_CONEXION_ACTUAL = CL_BD_CONEXION_LISTA.Where(Function(X) X.GetSQL_BD_ID = PP_BD_Index).FirstOrDefault()
            VG_SQL_BD_SERVER = CG_CONEXION_ACTUAL.GetSQL_BD_SERVER
            VG_SQL_BD_DATABASE = CG_CONEXION_ACTUAL.GetSQL_BD_DATABASE
            VG_SQL_BD_USER = CG_CONEXION_ACTUAL.GetSQL_BD_USER
            VG_SQL_BD_PASSWORD = CG_CONEXION_ACTUAL.GetSQL_BD_PASSWORD
            VG_DESARROLLO = CG_CONEXION_ACTUAL.GetSQL_BD_DESARROLLO
            PP_BASE_DE_DATOS = VG_SQL_BD_DATABASE
            PP_SERVER = VG_SQL_BD_SERVER
            VP_CADENA_CONEXION = "Data Source=" + VG_SQL_BD_SERVER + ";Initial Catalog=" + VG_SQL_BD_DATABASE + "; Persist Security Info=True;User ID=" + VG_SQL_BD_USER + ";Password=" + VG_SQL_BD_PASSWORD
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("FG_CONNECTION_GET")
        End Try
        Return VP_CADENA_CONEXION
    End Function

#End Region

#Region "FUNCIONES_SQL"

    Public Shared Sub PG_SISTEMA_COMPATIBILIDAD(ByRef PP_FORMA As Object, ByRef PP_BD_Index As Integer, PP_SISTEMA As Integer, PP_VERSION_EXE As String, PP_VERSION_BD As String)

        Dim VP_MENSAJE As String = ""
        Dim VP_CLAVE As Integer = 0

        Dim VP_PARAMETROS = PP_SISTEMA.ToString + ", '" + PP_VERSION_EXE + "','" + PP_VERSION_BD + "'"

        Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(PP_BD_Index, PP_FORMA, "[PG_SP_DATABASE_TAG_COMPATIBILIDAD]", VP_PARAMETROS, VP_CLAVE, VP_MENSAJE)

        If VP_MENSAJE <> "" Then
            Codigo_Mensaje.PG_MENSAJE_AVISO(VP_MENSAJE)
            End
        End If



    End Sub

    Public Shared Function FG_SP_LIST(ByRef PP_FORMA As Object)
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SP_NOMBRE_Ensamblar(CG_SQL_SP_LIST, PP_FORMA.VM_NOMBRE_TABLA)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SP_Seek(ByRef PP_FORMA As Object)
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SP_NOMBRE_Ensamblar(CG_SQL_SP_SEEK, PP_FORMA.VM_NOMBRE_TABLA)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SP_Insert(ByRef PP_FORMA As Object)
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SP_NOMBRE_Ensamblar(CG_SQL_SP_INSERT, PP_FORMA.VM_NOMBRE_TABLA)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SP_Insert_Update(ByRef PP_FORMA As Object)
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SP_NOMBRE_Ensamblar(CG_SQL_SP_PREFIJO_IN_UP, PP_FORMA.VM_NOMBRE_TABLA)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SP_Update(ByRef PP_FORMA As Object)
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SP_NOMBRE_Ensamblar(CG_SQL_SP_UPDATE, PP_FORMA.VM_NOMBRE_TABLA)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SP_Upsert(ByRef PP_FORMA As Object)
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SP_NOMBRE_Ensamblar(CG_SQL_SP_UPSERTE, PP_FORMA.VM_NOMBRE_TABLA)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SP_UPDATE_ICS()
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SP_NOMBRE_Ensamblar(CG_SQL_SP_UPDATE, CG_SQL_SP_ICS)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SP_Delete(ByRef PP_FORMA As Object)
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SP_NOMBRE_Ensamblar(CG_SQL_SP_DELETE, PP_FORMA.VM_NOMBRE_TABLA)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SP_CB_LOAD(Optional ByVal PP_L_USAR_ORDEN As Integer = 0) As String

        Dim VP_STORED_PROCEDURE As String
        'If PP_L_USAR_ORDEN = 1 Then
        '    VP_STORED_PROCEDURE = FG_SP_NOMBRE_Ensamblar(CG_SQL_CB_PREFIJO, CG_SQL_SP_COMBO)
        'Else
        VP_STORED_PROCEDURE = FG_SP_NOMBRE_Ensamblar(CG_SQL_CB_PREFIJO, CG_SQL_SP_COMBO_BASICO)
        'End If

        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SP_VERSION(ByRef PP_FORMA As Object) As String
        Dim VP_STORED_PROCEDURE As String
        Dim VP_NOMBRE_TABLA As String
        VP_NOMBRE_TABLA = CG_SQL_SP_VER + "_" + PP_FORMA.VM_NOMBRE_TABLA

        VP_STORED_PROCEDURE = FG_SP_NOMBRE_Ensamblar(CG_SQL_SP_INSERT, VP_NOMBRE_TABLA)
        Return VP_STORED_PROCEDURE
    End Function

    Private Shared Function FG_SP_NOMBRE_Ensamblar(ByVal PP_TIPO As String, ByVal PP_NOMBRE_TABLA As String) As String
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = "[dbo].[" + CG_SQL_PG_PREFIJO + "_" + PP_TIPO + "_" + PP_NOMBRE_TABLA + "]"
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SP_Update_VER(ByRef PP_FORMA As Object) As String
        Dim VP_STORED_PROCEDURE As String
        Dim VP_NOMBRE_TABLA As String
        VP_NOMBRE_TABLA = CG_SQL_SP_ESTATUS + "_" + PP_FORMA.VM_NOMBRE_TABLA_PADRE

        VP_STORED_PROCEDURE = FG_SP_NOMBRE_Ensamblar(CG_SQL_SP_UPDATE, VP_NOMBRE_TABLA)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SP_LIST_MASIVO(ByRef PP_FORMA As Object) As String
        Dim VP_STORED_PROCEDURE As String
        Dim VP_NOMBRE_SP As String
        VP_NOMBRE_SP = PP_FORMA.VM_NOMBRE_TABLA + "_" + CG_SQL_MASIVO
        VP_STORED_PROCEDURE = FG_SP_NOMBRE_Ensamblar(CG_SQL_SP_LIST, VP_NOMBRE_SP)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SP_LIST_USUARIOS_GRUPO(ByRef PP_FORMA As Object) As String
        Dim VP_STORED_PROCEDURE As String
        Dim VP_NOMBRE_SP As String
        VP_NOMBRE_SP = CG_SQL_SP_USUARIOS_GRUPO + "_" + PP_FORMA.VM_NOMBRE_TABLA
        VP_STORED_PROCEDURE = FG_SP_NOMBRE_Ensamblar(CG_SQL_SP_LIST, VP_NOMBRE_SP)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SP_CIRCULAR(ByRef PP_FORMA As Object) As String
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SP_NOMBRE_Ensamblar(CG_SQL_SP_LIST, CG_SQL_CIRCULAR)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SP_Seek_USER_CORREO(ByRef PP_FORMA As Object) As String
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SP_NOMBRE_Ensamblar(CG_SQL_SP_SEEK, CG_SQL_SP_USUARIOS_GRUPO)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SP_LOG() As String
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SP_NOMBRE_Ensamblar(CG_SQL_SP_LOG, CG_SQL_SP_INSERT)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SP_LOG_DESARROLLO() As String
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SP_NOMBRE_Ensamblar(CG_SQL_SP_LOG_DESARROLLO, CG_SQL_SP_INSERT)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SP_GRAFICAR_OBJ(ByRef PP_FORMA As Object) As String
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SP_NOMBRE_Ensamblar(CG_SQL_SP_GRAFICA, PP_FORMA.VM_NOMBRE_TABLA)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SP_GRAFICAR_STR(ByRef PP_NOMBRE_TABLA As String) As String
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SP_NOMBRE_Ensamblar(CG_SQL_SP_GRAFICA, PP_NOMBRE_TABLA)
        Return VP_STORED_PROCEDURE
    End Function

#End Region

#Region "OPERACION_BD"

    Public Shared Function FG_CULTURE_INFO_GET(ByVal PP_BD_Index As Integer) As Integer
        Dim VP_CULTURE_INFO As Integer = 0
        Dim VP_SENTENCIA As String
        VP_SENTENCIA = "select @@LANGID AS 'LANGID' "

        Dim VP_CONNECTION As String = ""
        VP_CONNECTION = FG_CONNECTION_GET(PP_BD_Index)

        Dim VP_SqlDataAdapter As New SqlDataAdapter
        Dim VP_DataTable As New DataTable
        Dim VP_REEJECUTAR As Boolean

        If FG_SERVER_SqlConnection(VP_CONNECTION) Then

            Try
                VP_SqlDataAdapter = New SqlDataAdapter(VP_SENTENCIA, VP_CONNECTION)
                VP_SqlDataAdapter.Fill(VP_DataTable)
                Dim VP_RESULTADO As String = ""

                Try

                    VP_RESULTADO = Codigo_LI.FG_LI_CELL_READ(VP_DataTable, 0, "LANGID")
                    VP_CULTURE_INFO = Convert.ToInt32(VP_RESULTADO)

                Catch ex As Exception
                    Codigo_Mensaje.PG_MENSAJE_ERROR_VS("FG_CULTURE_INFO_GET")
                    VP_RESULTADO = ex.Message
                End Try

                Return VP_RESULTADO

            Catch ex As Exception

                VP_REEJECUTAR = Codigo_Mensaje.FG_MENSAJE_ERROR_VS("FG_CULTURE_INFO_GET")

            End Try
        End If
        Return VP_CULTURE_INFO
    End Function


    Public Shared Function FG_SQL_EJECUTAR_OPERACION(ByRef PP_FORMA As Object, ByVal PP_BD_Index As Integer, ByVal PP_SP As String, ByVal PP_PARAMETROS As String) As Boolean
        Dim VP_DataTable As DataTable
        VP_DataTable = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(PP_BD_Index, PP_SP, PP_PARAMETROS)
        Dim VP_EXITO As Boolean = False
        Dim VP_RESULTADO As String
        VP_RESULTADO = FG_MG_MENSAJE_GET(VP_DataTable)
        Dim VP_FOLIO As String
        VP_FOLIO = Codigo_LI.FG_LI_CELL_READ(VP_DataTable, 0, "CLAVE")
        If VP_RESULTADO = "" Then
            VP_RESULTADO = "Operación Exitosa [#" + VP_FOLIO + "]."
            VP_EXITO = True

        Else

            Codigo_Mensaje.PG_MENSAJE_AVISO(VP_RESULTADO)
        End If

        Dim VP_MENSAJE As String
        VP_MENSAJE = VP_RESULTADO
        On Error Resume Next
        PP_FORMA.LB_RESULTADO.Text = "Resultado de la operación: " + VP_RESULTADO + Environment.NewLine + PP_FORMA.LB_RESULTADO.Text

        On Error GoTo 0
        Return VP_EXITO
    End Function

    Public Shared Function FG_SQL_EJECUTAR_ACCION_obj(ByRef PP_FORMA As Object, ByVal PP_BD_Index As Integer, ByVal PP_SP As String, ByVal PP_PARAMETROS As String) As Boolean
        Dim VP_DataTable As DataTable
        Dim VP_EXITO As Boolean = False
        Try
            VP_DataTable = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(PP_BD_Index, PP_SP, PP_PARAMETROS)
            Dim VP_RESULTADO As String
            VP_RESULTADO = FG_MG_MENSAJE_GET(VP_DataTable)
            Dim VP_FOLIO As String
            VP_FOLIO = Codigo_LI.FG_LI_CELL_READ(VP_DataTable, 0, "CLAVE")

            If VP_RESULTADO = "" Then
                VP_RESULTADO = "Operación Exitosa [#" + VP_FOLIO + "]."
                PP_FORMA.VM_ID_VERSION = VP_FOLIO
                VP_EXITO = True
            Else
                If PP_FORMA.FM_LI_DATA_VALIDATE(PP_FORMA.LI_LISTADO) Then
                    Codigo_ABC.VER_MOSTRAR(PP_FORMA, PP_FORMA.PP_LISTADO, 3)
                End If
            End If
            PP_FORMA.LB_RESULTADO.Text = "Resultado de la operación: " + VP_RESULTADO + Environment.NewLine + PP_FORMA.LB_RESULTADO.Text
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("FG_SQL_EJECUTAR_ACCION4")
        End Try
        Return VP_EXITO
    End Function

    Public Shared Function FG_SQL_EJECUTAR_ACCION_obj(ByRef PP_FORMA As Object, ByVal PP_BD_Index As Integer, ByRef PP_LISTADO As DataGridView, ByVal PP_SP As String, ByVal PP_PARAMETROS As String) As Boolean
        Dim VP_DataTable As DataTable
        VP_DataTable = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(PP_BD_Index, PP_SP, PP_PARAMETROS)

        Dim VP_EXITO As Boolean = False

        Dim VP_RESULTADO As String
        VP_RESULTADO = FG_MG_MENSAJE_GET(VP_DataTable)

        Dim VP_FOLIO As String
        VP_FOLIO = Codigo_LI.FG_LI_CELL_READ(VP_DataTable, 0, "CLAVE")

        If VP_RESULTADO = "" Then
            VP_RESULTADO = "Operación Exitosa [#" + VP_FOLIO + "]."
            VP_EXITO = True
            'PP_FORMA.VM_ID_VERSION = VP_FOLIO
        Else
            Codigo_ABC.VER_MOSTRAR(PP_FORMA, PP_LISTADO, 3)
        End If
        PP_FORMA.LB_RESULTADO.Text = "Resultado de la operación: " + VP_RESULTADO + Environment.NewLine + PP_FORMA.LB_RESULTADO.Text

        Return VP_EXITO
    End Function

    Public Shared Function FG_SQL_EJECUTAR_ACCION_int(ByRef PP_BD_Index As Integer, ByVal PP_SP As String, ByVal PP_PARAMETROS As String) As Boolean
        Dim VP_EXITO As Boolean
        Dim VP_RESULTADO As String
        Dim VP_FOLIO As String
        Dim VP_DESCRIPCION As String
        Dim VP_MENSAJE As String
        Dim VP_DataTable As DataTable
        Try
            VP_DataTable = FG_SP_EXECUTE_DATATABLE(PP_BD_Index, PP_SP, PP_PARAMETROS)

            VP_RESULTADO = FG_MG_MENSAJE_GET(VP_DataTable)
            VP_EXITO = Codigo_LI.FG_LI_CELL_READ(VP_DataTable, 0, "EXITO")
            VP_FOLIO = Codigo_LI.FG_LI_CELL_READ(VP_DataTable, 0, "CLAVE")
            VP_DESCRIPCION = Codigo_LI.FG_LI_CELL_READ(VP_DataTable, 0, "DESCR")
            If VP_EXITO Then
                VG_USUARIO_ACCION = VP_FOLIO
                VG_USUARIO = VP_DESCRIPCION
                VG_BD_Index = PP_BD_Index
            Else

                VP_MENSAJE = VP_RESULTADO
                Codigo_Mensaje.PG_MENSAJE_INFORMACION(VP_RESULTADO)
                PG_LOGOUT()
            End If
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("FG_SQL_EJECUTAR_ACCION_int")
            Call PG_LOGOUT()
            Return False
        End Try

        Return VP_EXITO
    End Function

    'Public Shared Function FG_SQL_EJECUTAR_ACCION(ByRef PP_BD_Index As Integer, ByVal PP_SP As String, ByVal PP_PARAMETROS As String, ByRef PP_CLAVE As Integer, ByRef PP_MENSAJE As String) As Boolean
    '    Dim VP_EXITO As Boolean
    '    Dim VP_DataTable As DataTable
    '    Try
    '        VP_DataTable = FG_SP_EXECUTE_DATATABLE(PP_BD_Index, PP_SP, PP_PARAMETROS)
    '        PP_CLAVE = Codigo_LI.FG_LI_CELL_READ(VP_DataTable, 0, "CLAVE")
    '        PP_MENSAJE = Codigo_LI.FG_LI_CELL_READ(VP_DataTable, 0, "MENSAJE")

    '    Catch ex As Exception
    '        '  Codigo_Message.PG_MENSAJE_ERROR_VS("FG_SQL_EJECUTAR_ACCION")
    '        Return False
    '    End Try

    '    Return VP_EXITO
    'End Function

    Public Shared Function FG_SQL_EJECUTAR_ACCION_int(ByRef PP_BD_Index As Integer, ByVal PP_SP As String, ByVal PP_PARAMETROS As String, ByRef PP_CLAVE As Integer, ByRef PP_MENSAJE As String) As Boolean
        Dim VP_EXITO As Boolean
        Dim VP_DataTable As DataTable
        Try
            VP_DataTable = FG_SP_EXECUTE_DATATABLE(PP_BD_Index, PP_SP, PP_PARAMETROS)
            PP_CLAVE = Codigo_LI.FG_LI_CELL_READ(VP_DataTable, 0, "CLAVE")
            PP_MENSAJE = Codigo_LI.FG_LI_CELL_READ(VP_DataTable, 0, "MENSAJE")

        Catch ex As Exception
            '  Codigo_Message.PG_MENSAJE_ERROR_VS("FG_SQL_EJECUTAR_ACCION")
            Return False
        End Try

        Return VP_EXITO
    End Function

    Public Shared Sub PG_LOGOUT()
        VG_USUARIO_ACCION = 0
        VG_USUARIO = 0
        VG_BD_Index = 0
        VG_DESARROLLO = 0
    End Sub

    Public Shared Function FG_SERVER_SqlConnection(ByVal PP_CONNECTION As String) As Boolean
        Dim VP_CONEXION_OK As Boolean = False
        PP_CONNECTION = PP_CONNECTION + ";Connection Timeout=3;"

        Using VP_CONEXION As New SqlConnection(PP_CONNECTION)
            Try
                VP_CONEXION.Open()
                VP_CONEXION_OK = True
            Catch ex As Exception
                Call Codigo_Mensaje.PG_MENSAJE_INFORMACION("No fue posible acceder a la BaseDatos/Server [ " + PP_CONNECTION + " ].")
                Codigo_Mensaje.PG_MENSAJE_ERROR_VS("FG_SERVER_SqlConnection")

            End Try
        End Using

        Return VP_CONEXION_OK
    End Function

    Public Shared Function FG_SP_EXECUTE_DATATABLE(ByVal PP_BD_Index As Integer, ByVal PP_STORED_PROCEDURE As String, ByVal PP_PARAMETROS As String) As DataTable
        Dim VP_SENTENCIA As String
        VP_SENTENCIA = CG_SQL_EJECUTAR + " " + PP_STORED_PROCEDURE + " " + PP_PARAMETROS

        Dim VP_CONNECTION As String = ""
        VP_CONNECTION = FG_CONNECTION_GET(PP_BD_Index)

        Dim VP_SqlDataAdapter As New SqlDataAdapter
        Dim VP_DataTable As New DataTable
        Dim VP_EJECUTAR_SENTENCIA As Boolean = True
        Dim VP_REEJECUTAR As Boolean
        FG_SP_BITACORA_WRITE(PP_BD_Index, PP_STORED_PROCEDURE, PP_PARAMETROS)

        If FG_SERVER_SqlConnection(VP_CONNECTION) Then

            While VP_EJECUTAR_SENTENCIA
                Try

                    VP_SqlDataAdapter = New SqlDataAdapter(VP_SENTENCIA, VP_CONNECTION)

                    VP_SqlDataAdapter.Fill(VP_DataTable)

                    VP_EJECUTAR_SENTENCIA = False

                Catch ex As Exception
                    'VP_REEJECUTAR = Codigo_Message.FG_MENSAJE_ERROR_VS("FG_SP_EXECUTE_DATATABLE - " + PP_STORED_PROCEDURE)
                    VP_REEJECUTAR = Codigo_Mensaje.FG_MENSAJE_ERROR_SP("FG_SP_EXECUTE_DATATABLE", PP_STORED_PROCEDURE, PP_PARAMETROS)
                    VP_EJECUTAR_SENTENCIA = VP_REEJECUTAR

                End Try

            End While

        End If


        Return VP_DataTable

    End Function

    Public Shared Function FG_SP_BITACORA_WRITE(ByVal PP_BD_Index As Integer, ByVal PP_STORED_PROCEDURE As String, ByVal PP_PARAMETROS As String) As DataTable
        Dim VP_SENTENCIA As String
        VP_SENTENCIA = CG_SQL_EJECUTAR + " " + PP_STORED_PROCEDURE + " " + PP_PARAMETROS

        Dim VP_COMANDO As String = " PG_IN_BITACORA_SQL "
        Dim VP_PARAMETROS As String = "@xml"
        Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
        VP_COMANDO = VP_COMANDO + " " + VP_PARAMETROS
        Dim VP_CONNECTION As String = ""
        VP_CONNECTION = FG_CONNECTION_GET(PP_BD_Index)

        Dim VP_CONEXION As New SqlConnection(VP_CONNECTION)
        Dim VP_READER As SqlDataReader
        Dim VP_DATATABLE As New DataTable
        Dim VP_EJECUTAR_SENTENCIA As Boolean = True
        Dim VP_REEJECUTAR As Boolean

        If FG_SERVER_SqlConnection(VP_CONNECTION) Then

            While VP_EJECUTAR_SENTENCIA
                Try

                    Dim VP_COMMAND As New SqlCommand(VP_COMANDO, VP_CONEXION)

                    'asociacion de parametros a las variables
                    VP_COMMAND.Parameters.AddWithValue("@xml", VP_SENTENCIA)

                    'se abre la conexion a la bd
                    VP_COMMAND.Connection.Open()

                    'se ejecuta la sentencia que no retorna nada
                    'VP_COMMAND.ExecuteNonQuery()

                    VP_READER = VP_COMMAND.ExecuteReader()
                    VP_DATATABLE.Load(VP_READER)

                    VP_EJECUTAR_SENTENCIA = False

                    'cierre de conexion a la bd
                    VP_COMMAND.Connection.Close()

                Catch ex As Exception

                    VP_REEJECUTAR = Codigo_Mensaje.FG_MENSAJE_ERROR_VS("FG_SP_BITACORA_WRITE")
                    VP_EJECUTAR_SENTENCIA = VP_REEJECUTAR

                End Try

            End While

        End If



        Return VP_DATATABLE

    End Function

    Public Shared Function FG_SP_EXECUTE_DATATABLE_XML(ByVal PP_BD_Index As Integer, ByVal PP_STORED_PROCEDURE As String, ByVal PP_PARAMETROS As String, ByVal PP_ARCHIVO As String) As DataTable
        Dim VP_SENTENCIA As String
        VP_SENTENCIA = PP_STORED_PROCEDURE + " " + PP_PARAMETROS + ", @xml"

        Dim VP_CONNECTION As String = ""
        VP_CONNECTION = FG_CONNECTION_GET(PP_BD_Index)

        Dim VP_CONEXION As New SqlConnection(VP_CONNECTION)
        Dim VP_READER As SqlDataReader
        Dim VP_DATATABLE As New DataTable
        Dim VP_EJECUTAR_SENTENCIA As Boolean = True
        Dim VP_REEJECUTAR As Boolean

        If FG_SERVER_SqlConnection(VP_CONNECTION) Then

            While VP_EJECUTAR_SENTENCIA
                Try

                    Dim VP_COMMAND As New SqlCommand(VP_SENTENCIA, VP_CONEXION)

                    'asociacion de parametros a las variables
                    VP_COMMAND.Parameters.AddWithValue("@xml", PP_ARCHIVO)

                    'se abre la conexion a la bd
                    VP_COMMAND.Connection.Open()

                    'se ejecuta la sentencia que no retorna nada
                    'VP_COMMAND.ExecuteNonQuery()

                    VP_READER = VP_COMMAND.ExecuteReader()
                    VP_DATATABLE.Load(VP_READER)

                    VP_EJECUTAR_SENTENCIA = False

                    'cierre de conexion a la bd
                    VP_COMMAND.Connection.Close()

                Catch ex As Exception

                    VP_REEJECUTAR = Codigo_Mensaje.FG_MENSAJE_ERROR_VS("FG_SP_EXECUTE_DATATABLE_XML")
                    VP_EJECUTAR_SENTENCIA = VP_REEJECUTAR

                End Try

            End While

        End If

        Return VP_DATATABLE

    End Function


    Private Shared Function FG_MG_MENSAJE_GET(ByVal PP_TABLA As DataTable) As String
        Dim VP_RESULTADO As String = ""

        Try

            VP_RESULTADO = Codigo_LI.FG_LI_CELL_READ(PP_TABLA, 0, "MENSAJE")

        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("FG_MG_MENSAJE_GET")
            VP_RESULTADO = ex.Message
        End Try

        Return VP_RESULTADO

    End Function

#End Region

#Region "PARAMETROS"

    Public Shared Sub PG_SQL_PARAMETROS_CONTROL(ByRef PP_PARAMETROS As String, Optional ByRef PP_K_USUARIO As Integer = 0)

        Dim VP_PARAMETROS_FIJOS As String
        If PP_K_USUARIO = 0 Then
            VP_PARAMETROS_FIJOS = CG_SQL_SP_DEBUG + "," + SYS_SetUp.CG_SQL_SP_SISTEMA_EXE + "," + VG_USUARIO_ACCION.ToString()
        Else
            VP_PARAMETROS_FIJOS = CG_SQL_SP_DEBUG + "," + SYS_SetUp.CG_SQL_SP_SISTEMA_EXE + "," + PP_K_USUARIO.ToString()
        End If


        If PP_PARAMETROS = "" Then
            PP_PARAMETROS = VP_PARAMETROS_FIJOS
        Else
            PP_PARAMETROS = VP_PARAMETROS_FIJOS + ", " + PP_PARAMETROS
        End If

    End Sub


    Public Shared Function FG_CO_DATA_READ(ByVal PP_ROW As DataRow, ByVal PP_NOMBRE_CAMPO As String, ByVal PP_VALOR_DEFAULT As String) As String
        Dim VP_VALOR As String = ""

        Try
            VP_VALOR = PP_ROW(PP_NOMBRE_CAMPO)

        Catch
            ' Codigo_Message.PG_MENSAJE_ERROR_VS("FG_CO_DATA_READ")
            VP_VALOR = PP_VALOR_DEFAULT
        End Try
        Return VP_VALOR
    End Function


    Public Shared Function FG_CO_DATA_READ_FECHA(ByVal PP_ROW As DataRow, ByVal PP_NOMBRE_CAMPO As String, ByVal PP_VALOR_DEFAULT As String) As Date
        Dim VP_VALOR As Date

        Try
            VP_VALOR = PP_ROW(PP_NOMBRE_CAMPO)

        Catch
            ' Codigo_Message.PG_MENSAJE_ERROR_VS("FG_CO_DATA_READ")
            VP_VALOR = PP_VALOR_DEFAULT
        End Try
        Return VP_VALOR
    End Function



#End Region

End Class



Public Class CL_BD_CONEXION
    Private VM_SQL_BD_AMBIENTE As String = ""
    Private VM_SQL_BD_ID As Integer = 0
    Private VM_SQL_BD_SERVER As String = ""
    Private VM_SQL_BD_DATABASE As String = ""
    Private VM_SQL_BD_USER As String = ""
    Private VM_SQL_BD_PASSWORD As String = ""
    Private VM_SQL_BD_DESARROLLO As Integer = 0

    Public Sub New(sSQL_BD_AMBIENTE As String, sQL_BD_ID As Integer, sQL_BD_SERVER As String, sQL_BD_DATABASE As String, sQL_BD_USER As String, sQL_BD_PASSWORD As String, sQL_BD_DESARROLLO As Integer)
        Me.VM_SQL_BD_AMBIENTE = sSQL_BD_AMBIENTE
        Me.VM_SQL_BD_ID = sQL_BD_ID
        Me.VM_SQL_BD_SERVER = sQL_BD_SERVER
        Me.VM_SQL_BD_DATABASE = sQL_BD_DATABASE
        Me.VM_SQL_BD_USER = sQL_BD_USER
        Me.VM_SQL_BD_PASSWORD = sQL_BD_PASSWORD
        Me.VM_SQL_BD_DESARROLLO = sQL_BD_DESARROLLO
    End Sub

    Public Function GetSQL_BD_AMBIENTE() As String
        Return VM_SQL_BD_AMBIENTE
    End Function

    Public Function GetSQL_BD_ID() As String
        Return VM_SQL_BD_ID
    End Function

    Public Function GetSQL_BD_SERVER() As String
        Return VM_SQL_BD_SERVER
    End Function

    Public Function GetSQL_BD_DATABASE() As String
        Return VM_SQL_BD_DATABASE
    End Function

    Public Function GetSQL_BD_USER() As String
        Return VM_SQL_BD_USER
    End Function

    Public Function GetSQL_BD_PASSWORD() As String
        Return VM_SQL_BD_PASSWORD
    End Function

    Public Function GetSQL_BD_DESARROLLO() As Integer
        Return VM_SQL_BD_DESARROLLO
    End Function

    Public Function GetSQL_OPCION_COMBO() As String

        Dim VP_OPCION As String

        VP_OPCION = VM_SQL_BD_AMBIENTE + ">" + VM_SQL_BD_DATABASE + ">" + VM_SQL_BD_SERVER

        Return VP_OPCION

    End Function

End Class

