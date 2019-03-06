Imports System.Data.SqlClient

'Clase para registrar los movimientos, lecturas, altas, bajas, cambios.
Public Class Movimiento

    'Leer un dato especifico
    Public Shared Function OBTENER(PP_TABLA As String, Optional PP_PARAMETROS As ArrayList = Nothing, Optional PP_VALORES As ArrayList = Nothing, Optional PP_TIPO As Integer = -1) As DataTable

        Conexion.Abrir() 'Abrir la conexion a la base de datos.

        Try
            Dim Comando As SqlCommand = Conexion.con.CreateCommand
            Comando.CommandType = CommandType.StoredProcedure 'Se indica que es un procedimiento almacenado.
            Comando.Parameters.Add(New SqlParameter("@PP_L_DEBUG", 0))
            Comando.Parameters.Add(New SqlParameter("@PP_K_SISTEMA_EXE", 0))
            Comando.Parameters.Add(New SqlParameter("@PP_K_USUARIO_ACCION", 0))

            If PP_PARAMETROS.Count > 0 Then
                For index As Integer = 1 To PP_PARAMETROS.Count
                    Dim campo = "@PP_" + PP_PARAMETROS(index - 1).ToString().ToUpper()
                    Dim valor = PP_VALORES(index - 1)
                    Comando.Parameters.Add(New SqlParameter(campo, valor))
                Next
            End If

            If PP_TIPO = -1 Then
                Comando.CommandText = "PG_LI_" + PP_TABLA.ToUpper()
            ElseIf PP_TIPO = 1 Then
                Comando.CommandText = "PG_SK_" + PP_TABLA.ToUpper()
            End If

            Comando.CommandTimeout = 3000

            Conexion.SQL_Adapter = New SqlDataAdapter(Comando) 'Ejecutar comando en DataAdapter.

            Conexion.SQL_Adapter.Fill(Conexion.SQL_DataTable) 'Capturar respuesta en datatable.

            Conexion.Cerrar() 'Cerrar la conexion a la base de datos.
            Return Conexion.SQL_DataTable 'Devolver el resultado de la consulta
        Catch ex As Exception
            Mensaje.Advertencia("Error: " + ex.ToString())
            Conexion.Cerrar() 'Cerrar la conexion a la base de datos.
            Return Nothing
        End Try



    End Function

End Class
