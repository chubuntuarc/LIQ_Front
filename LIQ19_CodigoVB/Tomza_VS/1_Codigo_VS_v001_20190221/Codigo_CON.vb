Imports System.Data.SqlClient

Public Class Codigo_CON

#Region "CONEXION"

    Public Shared CG_LISTADO_CONEXION As New List(Of CG_SQL_CONEXION)

    Public Shared Function PG_CONNECTION_INIT() As List(Of CG_SQL_CONEXION)
        Dim VP_CONTADOR As Integer = 0

        Try
            CG_LISTADO_CONEXION.Clear()
            CG_LISTADO_CONEXION.Add(New CG_SQL_CONEXION(VP_CONTADOR, "DESKTOP-I0DN4KS\LOCAL", "LIQ19_Liquidaciones_V9999_R0", "sa", "123456", 0))
            VP_CONTADOR += 1
            CG_LISTADO_CONEXION.Add(New CG_SQL_CONEXION(VP_CONTADOR, "DESKTOP-FTVBJI8\SQLEXPRESS", "LIQ19_Liquidaciones_V0043_R0", "sa", "ilAgrA", 0))
            VP_CONTADOR += 1
            CG_LISTADO_CONEXION.Add(New CG_SQL_CONEXION(VP_CONTADOR, "DESKTOP-KTP3PGG\SQLEXPRESS", "LIQ19_Liquidaciones_V0042_R0", "sa", "JI-15186#KF", 0))
            VP_CONTADOR += 1
            CG_LISTADO_CONEXION.Add(New CG_SQL_CONEXION(VP_CONTADOR, "DESKTOP-FTVBJI8\SQLEXPRESS", "LIQ19_Liquidaciones_V9999_R0", "sa", "ilAgrA", 0))
            VP_CONTADOR += 1
            CG_LISTADO_CONEXION.Add(New CG_SQL_CONEXION(VP_CONTADOR, "DESKTOP-KTP3PGG\SQLEXPRESS", "LIQ19_Liquidaciones_V0038_R0", "sa", "JI-15186#KF", 0))
            VP_CONTADOR += 1
            CG_LISTADO_CONEXION.Add(New CG_SQL_CONEXION(VP_CONTADOR, "DESKTOP-FTVBJI8\SQLEXPRESS", "LIQ19_Liquidaciones_V0038_R0", "sa", "ilAgrA", 0))
            VP_CONTADOR += 1
            CG_LISTADO_CONEXION.Add(New CG_SQL_CONEXION(VP_CONTADOR, "DESKTOP-KTP3PGG\SQLEXPRESS", "LIQ19_Liquidaciones_V0037_R0", "sa", "JI-15186#KF", 0))
            VP_CONTADOR += 1
            CG_LISTADO_CONEXION.Add(New CG_SQL_CONEXION(VP_CONTADOR, "DESKTOP-KTP3PGG\SQLEXPRESS", "LIQ19_Liquidaciones_V0036_R0", "sa", "JI-15186#KF", 0))
            VP_CONTADOR += 1
            CG_LISTADO_CONEXION.Add(New CG_SQL_CONEXION(VP_CONTADOR, "DESKTOP-KTP3PGG\SQLEXPRESS", "LIQ19_Liquidaciones_V0035_R0", "sa", "JI-15186#KF", 0))
            VP_CONTADOR += 1
            CG_LISTADO_CONEXION.Add(New CG_SQL_CONEXION(VP_CONTADOR, "DESKTOP-KTP3PGG\SQLEXPRESS", "LIQ19_Liquidaciones_V0034_R0", "sa", "JI-15186#KF", 0))

        Catch ex As ArgumentException
            Codigo_Message.PG_MENSAJE_ERROR_VS("PG_CONNECTION_INIT")
        End Try
        Return CG_LISTADO_CONEXION
    End Function

    Public Shared Function FG_CONNECTION_GET(ByVal PP_ID_BASE_DE_DATOS As Integer, Optional ByRef PP_SERVER As String = "", Optional ByRef PP_BASE_DE_DATOS As String = "") As String
        Dim VG_SQL_BD_SERVER As String = ""
        Dim VG_SQL_BD_DATABASE As String = ""
        Dim VG_SQL_BD_PASSWORD As String = ""
        Dim VG_SQL_BD_USER As String = ""
        Dim VP_CADENA_CONEXION As String = ""
        Try
            PG_CONNECTION_INIT()
            Dim CG_CONEXION_ACTUAL As CG_SQL_CONEXION
            CG_CONEXION_ACTUAL = CG_LISTADO_CONEXION.Where(Function(X) X.GetSQL_BD_ID = PP_ID_BASE_DE_DATOS).FirstOrDefault()
            VG_SQL_BD_SERVER = CG_CONEXION_ACTUAL.GetSQL_BD_SERVER
            VG_SQL_BD_DATABASE = CG_CONEXION_ACTUAL.GetSQL_BD_DATABASE
            VG_SQL_BD_USER = CG_CONEXION_ACTUAL.GetSQL_BD_USER
            VG_SQL_BD_PASSWORD = CG_CONEXION_ACTUAL.GetSQL_BD_PASSWORD
            VG_DESARROLLO = CG_CONEXION_ACTUAL.GetSQL_BD_DESARROLLO
            PP_BASE_DE_DATOS = VG_SQL_BD_DATABASE
            PP_SERVER = VG_SQL_BD_SERVER
            VP_CADENA_CONEXION = "Data Source=" + VG_SQL_BD_SERVER + ";Initial Catalog=" + VG_SQL_BD_DATABASE + "; Persist Security Info=True;User ID=" + VG_SQL_BD_USER + ";Password=" + VG_SQL_BD_PASSWORD
        Catch ex As ArgumentException
            Codigo_Message.PG_MENSAJE_ERROR_VS("FG_CONNECTION_GET")
        End Try
        Return VP_CADENA_CONEXION
    End Function

#End Region

#Region "FUNCIONES_SQL"

    Public Shared Function FG_SQL_LIST(ByRef PP_FORMA As Object)
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SQL_BASICO(Constantes_Sistema.CG_SQL_SP_LIST, PP_FORMA.VM_NOMBRE_TABLA)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SQL_SEEK(ByRef PP_FORMA As Object)
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SQL_BASICO(Constantes_Sistema.CG_SQL_SP_SEEK, PP_FORMA.VM_NOMBRE_TABLA)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SQL_INSERT(ByRef PP_FORMA As Object)
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SQL_BASICO(Constantes_Sistema.CG_SQL_SP_INSERT, PP_FORMA.VM_NOMBRE_TABLA)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SQL_INSERT_UPDATE(ByRef PP_FORMA As Object)
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SQL_BASICO(Constantes_Sistema.CG_SQL_SP_PREFIJO_IN_UP, PP_FORMA.VM_NOMBRE_TABLA)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SQL_UPDATE(ByRef PP_FORMA As Object)
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SQL_BASICO(Constantes_Sistema.CG_SQL_SP_UPDATE, PP_FORMA.VM_NOMBRE_TABLA)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SQL_UPSERT(ByRef PP_FORMA As Object)
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SQL_BASICO(Constantes_Sistema.CG_SQL_SP_UPSERTE, PP_FORMA.VM_NOMBRE_TABLA)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SQL_UPDATE_ICS()
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SQL_BASICO(Constantes_Sistema.CG_SQL_SP_UPDATE, Constantes_Sistema.CG_SQL_SP_ICS)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SQL_DELETE(ByRef PP_FORMA As Object)
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SQL_BASICO(Constantes_Sistema.CG_SQL_SP_DELETE, PP_FORMA.VM_NOMBRE_TABLA)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SQL_CB_LOAD(Optional ByVal PP_L_USAR_ORDEN As Integer = 0)

        Dim VP_STORED_PROCEDURE As String
        'If PP_L_USAR_ORDEN = 1 Then
        '    VP_STORED_PROCEDURE = FG_SQL_BASICO(Constantes_Sistema.CG_SQL_CB_PREFIJO, Constantes_Sistema.CG_SQL_SP_COMBO)
        'Else
        VP_STORED_PROCEDURE = FG_SQL_BASICO(Constantes_Sistema.CG_SQL_CB_PREFIJO, Constantes_Sistema.CG_SQL_SP_COMBO_BASICO)
        'End If

        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SQL_VERSION(ByRef PP_FORMA As Object)
        Dim VP_STORED_PROCEDURE As String
        Dim VP_NOMBRE_TABLA As String
        VP_NOMBRE_TABLA = Constantes_Sistema.CG_SQL_SP_VER + "_" + PP_FORMA.VM_NOMBRE_TABLA

        VP_STORED_PROCEDURE = FG_SQL_BASICO(Constantes_Sistema.CG_SQL_SP_INSERT, VP_NOMBRE_TABLA)
        Return VP_STORED_PROCEDURE
    End Function

    Private Shared Function FG_SQL_BASICO(ByVal PP_TIPO As String, ByVal PP_NOMBRE_TABLA As String)
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = "[dbo].[" + Constantes_Sistema.CG_SQL_PG_PREFIJO + "_" + PP_TIPO + "_" + PP_NOMBRE_TABLA + "]"
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SQL_UP_VER(ByRef PP_FORMA As Object)
        Dim VP_STORED_PROCEDURE As String
        Dim VP_NOMBRE_TABLA As String
        VP_NOMBRE_TABLA = Constantes_Sistema.CG_SQL_SP_ESTATUS + "_" + PP_FORMA.VM_NOMBRE_TABLA_PADRE

        VP_STORED_PROCEDURE = FG_SQL_BASICO(Constantes_Sistema.CG_SQL_SP_UPDATE, VP_NOMBRE_TABLA)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SQL_LIST_MASIVO(ByRef PP_FORMA As Object)
        Dim VP_STORED_PROCEDURE As String
        Dim VP_NOMBRE_SP As String
        VP_NOMBRE_SP = PP_FORMA.VM_NOMBRE_TABLA + "_" + Constantes_Sistema.CG_SQL_MASIVO
        VP_STORED_PROCEDURE = FG_SQL_BASICO(Constantes_Sistema.CG_SQL_SP_LIST, VP_NOMBRE_SP)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SQL_LIST_USUARIOS_GRUPO(ByRef PP_FORMA As Object)
        Dim VP_STORED_PROCEDURE As String
        Dim VP_NOMBRE_SP As String
        VP_NOMBRE_SP = Constantes_Sistema.CG_SQL_SP_USUARIOS_GRUPO + "_" + PP_FORMA.VM_NOMBRE_TABLA
        VP_STORED_PROCEDURE = FG_SQL_BASICO(Constantes_Sistema.CG_SQL_SP_LIST, VP_NOMBRE_SP)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SQL_CIRCULAR(ByRef PP_FORMA As Object)
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SQL_BASICO(Constantes_Sistema.CG_SQL_SP_LIST, Constantes_Sistema.CG_SQL_CIRCULAR)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SQL_SK_USER_CORREO(ByRef PP_FORMA As Object)
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SQL_BASICO(Constantes_Sistema.CG_SQL_SP_SEEK, Constantes_Sistema.CG_SQL_SP_USUARIOS_GRUPO)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SQL_LOG()
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SQL_BASICO(Constantes_Sistema.CG_SQL_SP_LOG, Constantes_Sistema.CG_SQL_SP_INSERT)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SQL_LOG_DESARROLLO()
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SQL_BASICO(Constantes_Sistema.CG_SQL_SP_LOG_DESARROLLO, Constantes_Sistema.CG_SQL_SP_INSERT)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SQL_GRAFICAR(ByRef PP_FORMA As Object)
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SQL_BASICO(Constantes_Sistema.CG_SQL_SP_GRAFICA, PP_FORMA.VM_NOMBRE_TABLA)
        Return VP_STORED_PROCEDURE
    End Function

    Public Shared Function FG_SQL_GRAFICAR(ByRef PP_NOMBRE_TABLA As String)
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SQL_BASICO(Constantes_Sistema.CG_SQL_SP_GRAFICA, PP_NOMBRE_TABLA)
        Return VP_STORED_PROCEDURE
    End Function

#End Region

#Region "OPERACION_BD"

    Public Shared Function FG_CULTURE_INFO_GET(ByVal PP_ID_BASE_DE_DATOS As Integer) As Integer
        Dim VP_CULTURE_INFO As Integer = 0
        Dim VP_SENTENCIA As String
        VP_SENTENCIA = "select @@LANGID AS 'LANGID' "

        Dim VP_CONNECTION As String = ""
        VP_CONNECTION = FG_CONNECTION_GET(PP_ID_BASE_DE_DATOS)

        Dim VP_SqlDataAdapter As New SqlDataAdapter
        Dim VP_DataTable As New DataTable
        Dim VP_REEJECUTAR As Boolean

        If FG_CONEXION_CHECK(VP_CONNECTION) Then

            Try
                VP_SqlDataAdapter = New SqlDataAdapter(VP_SENTENCIA, VP_CONNECTION)
                VP_SqlDataAdapter.Fill(VP_DataTable)
                Dim VP_RESULTADO As String = ""

                Try

                    VP_RESULTADO = Codigo_LI.FG_LI_CELL_READ(VP_DataTable, 0, "LANGID")
                    VP_CULTURE_INFO = Convert.ToInt32(VP_RESULTADO)

                Catch ex As Exception
                    Codigo_Message.PG_MENSAJE_ERROR_VS("FG_CULTURE_INFO_GET")
                    VP_RESULTADO = ex.Message
                End Try

                Return VP_RESULTADO

            Catch ex As Exception

                VP_REEJECUTAR = Codigo_Message.FG_MENSAJE_ERROR_VS("FG_CULTURE_INFO_GET")

            End Try
        End If
        Return VP_CULTURE_INFO
    End Function


    Public Shared Function FG_SQL_EJECUTAR_OPERACION(ByRef PP_FORMA As Object, ByVal PP_ID_BASE_DE_DATOS As Integer, ByVal PP_SP As String, ByVal PP_PARAMETROS As String) As Boolean
        Dim VP_DataTable As DataTable
        VP_DataTable = Codigo_CON.FG_SP_EXECUTE_DATATABLE(PP_ID_BASE_DE_DATOS, PP_SP, PP_PARAMETROS)
        Dim VP_EXITO As Boolean = False
        Dim VP_RESULTADO As String
        VP_RESULTADO = FG_MG_MENSAJE_GET(VP_DataTable)
        Dim VP_FOLIO As String
        VP_FOLIO = Codigo_LI.FG_LI_CELL_READ(VP_DataTable, 0, "CLAVE")
        If VP_RESULTADO = "" Then
            VP_RESULTADO = "Operación Exitosa [#" + VP_FOLIO + "]."
            VP_EXITO = True

        Else

            Codigo_Message.PG_MENSAJE_AVISO(VP_RESULTADO)
        End If

        Dim VP_MENSAJE As String
        VP_MENSAJE = VP_RESULTADO
        On Error Resume Next
        PP_FORMA.LB_RESULTADO.Text = "Resultado de la operación: " + VP_RESULTADO + Environment.NewLine + PP_FORMA.LB_RESULTADO.Text

        On Error GoTo 0
        Return VP_EXITO
    End Function

    Public Shared Function FG_SQL_EJECUTAR_ACCION(ByRef PP_FORMA As Object, ByVal PP_ID_BASE_DE_DATOS As Integer, ByVal PP_SP As String, ByVal PP_PARAMETROS As String) As Boolean
        Dim VP_DataTable As DataTable
        Dim VP_EXITO As Boolean = False
        Try
            VP_DataTable = Codigo_CON.FG_SP_EXECUTE_DATATABLE(PP_ID_BASE_DE_DATOS, PP_SP, PP_PARAMETROS)
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
            Codigo_Message.PG_MENSAJE_ERROR_VS("FG_SQL_EJECUTAR_ACCION")
        End Try
        Return VP_EXITO
    End Function

    Public Shared Function FG_SQL_EJECUTAR_ACCION(ByRef PP_FORMA As Object, ByVal PP_ID_BASE_DE_DATOS As Integer, ByRef PP_LISTADO As DataGridView, ByVal PP_SP As String, ByVal PP_PARAMETROS As String) As Boolean
        Dim VP_DataTable As DataTable
        VP_DataTable = Codigo_CON.FG_SP_EXECUTE_DATATABLE(PP_ID_BASE_DE_DATOS, PP_SP, PP_PARAMETROS)

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

    Public Shared Function FG_SQL_EJECUTAR_ACCION(ByRef PP_ID_BASE_DE_DATOS As Integer, ByVal PP_SP As String, ByVal PP_PARAMETROS As String) As Boolean
        Dim VP_EXITO As Boolean
        Dim VP_RESULTADO As String
        Dim VP_FOLIO As String
        Dim VP_DESCRIPCION As String
        Dim VP_MENSAJE As String
        Dim VP_DataTable As DataTable
        Try
            VP_DataTable = FG_SP_EXECUTE_DATATABLE(PP_ID_BASE_DE_DATOS, PP_SP, PP_PARAMETROS)

            VP_RESULTADO = FG_MG_MENSAJE_GET(VP_DataTable)
            VP_EXITO = Codigo_LI.FG_LI_CELL_READ(VP_DataTable, 0, "EXITO")
            VP_FOLIO = Codigo_LI.FG_LI_CELL_READ(VP_DataTable, 0, "CLAVE")
            VP_DESCRIPCION = Codigo_LI.FG_LI_CELL_READ(VP_DataTable, 0, "DESCR")
            If VP_EXITO Then
                VG_USUARIO_ACCION = VP_FOLIO
                VG_USUARIO = VP_DESCRIPCION
                VG_ID_DB = PP_ID_BASE_DE_DATOS
            Else

                VP_MENSAJE = VP_RESULTADO
                Codigo_Message.PG_MENSAJE_INFORMACION(VP_RESULTADO)
                PG_LOGOUT()
            End If
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("FG_SQL_EJECUTAR_ACCION")
            PG_LOGOUT()
            Return False
        End Try

        Return VP_EXITO
    End Function

    'Public Shared Function FG_SQL_EJECUTAR_ACCION(ByRef PP_ID_BASE_DE_DATOS As Integer, ByVal PP_SP As String, ByVal PP_PARAMETROS As String, ByRef PP_CLAVE As Integer, ByRef PP_MENSAJE As String) As Boolean
    '    Dim VP_EXITO As Boolean
    '    Dim VP_DataTable As DataTable
    '    Try
    '        VP_DataTable = FG_SP_EXECUTE_DATATABLE(PP_ID_BASE_DE_DATOS, PP_SP, PP_PARAMETROS)
    '        PP_CLAVE = Codigo_LI.FG_LI_CELL_READ(VP_DataTable, 0, "CLAVE")
    '        PP_MENSAJE = Codigo_LI.FG_LI_CELL_READ(VP_DataTable, 0, "MENSAJE")

    '    Catch ex As Exception
    '        '  Codigo_Message.PG_MENSAJE_ERROR_VS("FG_SQL_EJECUTAR_ACCION")
    '        Return False
    '    End Try

    '    Return VP_EXITO
    'End Function

    Public Shared Function FG_SQL_EJECUTAR_ACCION(ByRef PP_ID_BASE_DE_DATOS As Integer, ByVal PP_SP As String, ByVal PP_PARAMETROS As String, ByRef PP_CLAVE As Integer, ByRef PP_MENSAJE As String) As Boolean
        Dim VP_EXITO As Boolean
        Dim VP_DataTable As DataTable
        Try
            VP_DataTable = FG_SP_EXECUTE_DATATABLE(PP_ID_BASE_DE_DATOS, PP_SP, PP_PARAMETROS)
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
        VG_ID_DB = 0
        VG_DESARROLLO = 0
    End Sub

    Public Shared Function FG_CONEXION_CHECK(ByVal PP_CONNECTION As String)

        PP_CONNECTION = PP_CONNECTION + ";Connection Timeout=3;"

        Using VP_CONEXION As New SqlConnection(PP_CONNECTION)
            Try
                VP_CONEXION.Open()
                Return True
            Catch ex As Exception
                Codigo_Message.PG_MENSAJE_ERROR_VS("FG_CONEXION_CHECK")
                Return False
            End Try
        End Using

    End Function

    Public Shared Function FG_SP_EXECUTE_DATATABLE(ByVal PP_ID_BASE_DE_DATOS As Integer, ByVal PP_STORED_PROCEDURE As String, ByVal PP_PARAMETROS As String) As DataTable
        Dim VP_SENTENCIA As String
        VP_SENTENCIA = Constantes_Sistema.CG_SQL_EJECUTAR + " " + PP_STORED_PROCEDURE + " " + PP_PARAMETROS

        Dim VP_CONNECTION As String = ""
        VP_CONNECTION = FG_CONNECTION_GET(PP_ID_BASE_DE_DATOS)

        Dim VP_SqlDataAdapter As New SqlDataAdapter
        Dim VP_DataTable As New DataTable
        Dim VP_EJECUTAR_SENTENCIA As Boolean = True
        Dim VP_REEJECUTAR As Boolean
        FG_SP_BITACORA_WRITE(PP_ID_BASE_DE_DATOS, PP_STORED_PROCEDURE, PP_PARAMETROS)
        If FG_CONEXION_CHECK(VP_CONNECTION) Then

            While VP_EJECUTAR_SENTENCIA
                Try

                    VP_SqlDataAdapter = New SqlDataAdapter(VP_SENTENCIA, VP_CONNECTION)

                    VP_SqlDataAdapter.Fill(VP_DataTable)

                    VP_EJECUTAR_SENTENCIA = False

                Catch ex As Exception
                    'VP_REEJECUTAR = Codigo_Message.FG_MENSAJE_ERROR_VS("FG_SP_EXECUTE_DATATABLE - " + PP_STORED_PROCEDURE)
                    VP_REEJECUTAR = Codigo_Message.FG_MENSAJE_ERROR_SP("FG_SP_EXECUTE_DATATABLE", PP_STORED_PROCEDURE, PP_PARAMETROS)
                    VP_EJECUTAR_SENTENCIA = VP_REEJECUTAR

                End Try

            End While

        End If


        Return VP_DataTable

    End Function

    Public Shared Function FG_SP_BITACORA_WRITE(ByVal PP_ID_BASE_DE_DATOS As Integer, ByVal PP_STORED_PROCEDURE As String, ByVal PP_PARAMETROS As String) As DataTable
        Dim VP_SENTENCIA As String
        VP_SENTENCIA = Constantes_Sistema.CG_SQL_EJECUTAR + " " + PP_STORED_PROCEDURE + " " + PP_PARAMETROS

        Dim VP_COMANDO As String = " PG_IN_BITACORA_SQL "
        Dim VP_PARAMETROS As String = "@xml"
        Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
        VP_COMANDO = VP_COMANDO + " " + VP_PARAMETROS
        Dim VP_CONNECTION As String = ""
        VP_CONNECTION = FG_CONNECTION_GET(PP_ID_BASE_DE_DATOS)

        Dim VP_CONEXION As New SqlConnection(VP_CONNECTION)
        Dim VP_READER As SqlDataReader
        Dim VP_DATATABLE As New DataTable
        Dim VP_EJECUTAR_SENTENCIA As Boolean = True
        Dim VP_REEJECUTAR As Boolean

        If FG_CONEXION_CHECK(VP_CONNECTION) Then

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

                    VP_REEJECUTAR = Codigo_Message.FG_MENSAJE_ERROR_VS("FG_SP_EXECUTE_DATATABLE")
                    VP_EJECUTAR_SENTENCIA = VP_REEJECUTAR

                End Try

            End While

        End If



        Return VP_DataTable

    End Function

    Public Shared Function FG_SP_EXECUTE_DATATABLE(ByVal PP_ID_BASE_DE_DATOS As Integer, ByVal PP_STORED_PROCEDURE As String, ByVal PP_PARAMETROS As String, ByVal PP_ARCHIVO As String) As DataTable
        Dim VP_SENTENCIA As String
        VP_SENTENCIA = PP_STORED_PROCEDURE + " " + PP_PARAMETROS + ", @xml"

        Dim VP_CONNECTION As String = ""
        VP_CONNECTION = FG_CONNECTION_GET(PP_ID_BASE_DE_DATOS)

        Dim VP_CONEXION As New SqlConnection(VP_CONNECTION)
        Dim VP_READER As SqlDataReader
        Dim VP_DATATABLE As New DataTable
        Dim VP_EJECUTAR_SENTENCIA As Boolean = True
        Dim VP_REEJECUTAR As Boolean

        If FG_CONEXION_CHECK(VP_CONNECTION) Then

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

                    VP_REEJECUTAR = Codigo_Message.FG_MENSAJE_ERROR_VS("FG_SP_EXECUTE_DATATABLE")
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
            Codigo_Message.PG_MENSAJE_ERROR_VS("FG_MG_MENSAJE_GET")
            VP_RESULTADO = ex.Message
        End Try

        Return VP_RESULTADO

    End Function

#End Region

#Region "PARAMETROS"

    Public Shared Sub PG_SQL_PARAMETROS_CONTROL(ByRef PP_PARAMETROS As String, Optional ByRef PP_K_USUARIO As Integer = 0)
        Dim VP_PARAMETROS_FIJOS As String
        If PP_K_USUARIO = 0 Then
            VP_PARAMETROS_FIJOS = Constantes_Sistema.CG_SQL_SP_DEBUG + "," + Constantes_Sistema.CG_SQL_SP_SISTEMA_EXE + "," + VG_USUARIO_ACCION.ToString()
        Else
            VP_PARAMETROS_FIJOS = Constantes_Sistema.CG_SQL_SP_DEBUG + "," + Constantes_Sistema.CG_SQL_SP_SISTEMA_EXE + "," + PP_K_USUARIO.ToString()
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


Public Class CG_SQL_CONEXION
    Private SQL_BD_ID As Integer = 0
    Private SQL_BD_SERVER As String = ""
    Private SQL_BD_DATABASE As String = ""
    Private SQL_BD_USER As String = ""
    Private SQL_BD_PASSWORD As String = ""
    Private SQL_BD_DESARROLLO As Integer = 0

    Public Sub New(sQL_BD_ID As Integer, sQL_BD_SERVER As String, sQL_BD_DATABASE As String, sQL_BD_USER As String, sQL_BD_PASSWORD As String, sQL_BD_DESARROLLO As Integer)
        Me.SQL_BD_ID = sQL_BD_ID
        Me.SQL_BD_SERVER = sQL_BD_SERVER
        Me.SQL_BD_DATABASE = sQL_BD_DATABASE
        Me.SQL_BD_USER = sQL_BD_USER
        Me.SQL_BD_PASSWORD = sQL_BD_PASSWORD
        Me.SQL_BD_DESARROLLO = sQL_BD_DESARROLLO
    End Sub

    Public Function GetSQL_BD_ID() As String
        Return SQL_BD_ID
    End Function

    Public Function GetSQL_BD_SERVER() As String
        Return SQL_BD_SERVER
    End Function

    Public Function GetSQL_BD_DATABASE() As String
        Return SQL_BD_DATABASE
    End Function

    Public Function GetSQL_BD_USER() As String
        Return SQL_BD_USER
    End Function

    Public Function GetSQL_BD_PASSWORD() As String
        Return SQL_BD_PASSWORD
    End Function

    Public Function GetSQL_BD_DESARROLLO() As Integer
        Return SQL_BD_DESARROLLO
    End Function

End Class
