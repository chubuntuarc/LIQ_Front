Imports System.IO

Public Class Codigo_General


    Public Shared Sub PG_CREAR_DIRECTORIO(PP_Ruta As String)

        If Not Directory.Exists(PP_Ruta) Then
            Call Codigo_Mensaje.PG_MENSAJE_AVISO("No se localizó el Directorio <" + PP_Ruta + ">, se creará automáticamente.", False)
            My.Computer.FileSystem.CreateDirectory(PP_Ruta)

        End If

    End Sub




End Class
