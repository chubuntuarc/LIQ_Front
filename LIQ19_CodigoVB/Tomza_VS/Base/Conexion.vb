Imports System.Data.SqlClient

'Clase con los metodos y funciones de la conexion a base de datos.
Public Class Conexion

    'Valores de la conexion.
    Public Shared con As New SqlConnection
    Public Shared Cadena_conexion As String = "Data Source=" + SYS_SetUp.CG_SQL_SERVIDOR + ";Initial Catalog=" + SYS_SetUp.CG_SQL_BASE_DATOS + "; Persist Security Info=True;User ID=" + SYS_SetUp.CG_SQL_USUARIO + ";Password=" + SYS_SetUp.CG_SQL_PASSWORD
    Public Shared Instruccion As String = ""
    Public Shared Comando_SQL As SqlCommand
    Public Shared SQL_Adapter As SqlDataAdapter
    Public Shared SQL_DataTable As New DataTable

    'Arrancar conexion a base de datos SQL Server.
    Public Shared Sub Abrir()
        Try
            con.ConnectionString = Cadena_conexion 'Asignar la cadena de conexion.
            con.Open()  'Abrir la conexion a base de datos.
            Console.WriteLine("Conexion exitosa.")
        Catch ex As Exception
            Mensaje.Advertencia("Error de conexión: " + ex.ToString())
        End Try
    End Sub

    'Cerrar la conexion a base de datos.
    Public Shared Sub Cerrar()
        Try
            con.Close() 'Se cierra la conexion con la base de datos.
            Console.WriteLine("Cierre exitoso.")
        Catch ex As Exception
            Mensaje.Advertencia("Error al cerrar la conexion: " + ex.ToString())
        End Try
    End Sub

End Class
