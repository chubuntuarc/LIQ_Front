'Clase para crear mensajes de aviso en el sistema.
Public Class Mensaje

    'Mostrar mensaje de advertencia
    Public Shared Sub Advertencia(Mensaje As String, Optional Titulo As String = "Error del sistema")
        MessageBox.Show(Mensaje, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    'Mostrar mensaje de aviso
    Public Shared Sub Aviso(Mensaje As String, Optional Titulo As String = "Aviso del sistema")
        MessageBox.Show(Mensaje, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
