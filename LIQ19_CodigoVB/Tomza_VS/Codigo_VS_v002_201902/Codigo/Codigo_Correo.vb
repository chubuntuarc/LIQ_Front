Imports System.IO

Public Class Codigo_Correo
    Public Shared Sub PG_ENVIAR_CORREO(ByVal PP_ASUNTO As String, ByVal PP_DESTINATARIO As String,
                                       ByVal PP_REMITENTE As String, ByVal PP_REMITENTE_DISPLAY As String, PP_CONTRASEÑA_REMITENTE As String,
                                       ByVal PP_HOST As String, ByVal PP_BODY As String, ByVal PP_PUERTO As Integer,
                                       ByVal PP_ENABLE_SSL As Boolean, ByVal PP_RUTA_ARCHIVO As String)

        Dim _Message As New System.Net.Mail.MailMessage()
        Dim _SMTP As New System.Net.Mail.SmtpClient
        'CONFIGURACIÓN DEL STMP
        _SMTP.Credentials = New System.Net.NetworkCredential(PP_REMITENTE, PP_CONTRASEÑA_REMITENTE)
        _SMTP.Host = PP_HOST
        _SMTP.Port = PP_PUERTO
        _SMTP.EnableSsl = PP_ENABLE_SSL
        ' CONFIGURACION DEL MENSAJE
        _Message.[To].Add(PP_DESTINATARIO) 'Para quién se lo envio.
        _Message.From = New System.Net.Mail.MailAddress(PP_REMITENTE, PP_REMITENTE_DISPLAY, System.Text.Encoding.UTF8) 'Quien lo envía
        _Message.Subject = PP_ASUNTO
        _Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
        _Message.Body = PP_BODY
        _Message.BodyEncoding = System.Text.Encoding.UTF8
        _Message.Priority = System.Net.Mail.MailPriority.High
        If File.Exists(PP_RUTA_ARCHIVO) Then
            Dim VP_ADJUNTO As New System.Net.Mail.Attachment(PP_RUTA_ARCHIVO) ', System.Net.Mime.TransferEncoding.Base64
            _Message.Attachments.Add(VP_ADJUNTO)
        Else
            Codigo_Mensaje.PG_MENSAJE_AVISO("Archivo no encontrado")

        End If
        _Message.IsBodyHtml = False
        'ENVIO 
        Try
            _SMTP.Send(_Message)
            Codigo_Mensaje.PG_MENSAJE_INFORMACION("Se ha enviado el correo exitosamente.")
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_ENVIAR_CORREO")
        End Try
    End Sub

    Public Shared Sub PG_ENVIAR_CORREO_DESDE_PREDETERMINADO(ByVal PP_ASUNTO As String, ByVal PP_DESTINATARIO As String,
                                                            ByVal PP_BODY As String, ByVal PP_RUTA_ARCHIVO As String)
        Dim _Message As New System.Net.Mail.MailMessage()
        Dim _SMTP As New System.Net.Mail.SmtpClient
        'CONFIGURACIÓN DEL STMP
        _SMTP.Credentials = New System.Net.NetworkCredential("lbarraza.g@tomza.com", "Passw0RD#476")
        _SMTP.Host = "smtp.office365.com"
        _SMTP.Port = 587
        _SMTP.EnableSsl = True
        ' CONFIGURACION DEL MENSAJE
        _Message.[To].Add(PP_DESTINATARIO) 'Para quién se lo envio.
        _Message.From = New System.Net.Mail.MailAddress("lbarraza.g@tomza.com", "Laura", System.Text.Encoding.UTF8) 'Quien lo envía
        _Message.Subject = PP_ASUNTO
        _Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
        _Message.Body = PP_BODY
        _Message.BodyEncoding = System.Text.Encoding.UTF8
        _Message.Priority = System.Net.Mail.MailPriority.High
        Dim VP_ADJUNTO As System.Net.Mail.Attachment = Nothing
        If File.Exists(PP_RUTA_ARCHIVO) Then
            VP_ADJUNTO = New System.Net.Mail.Attachment(PP_RUTA_ARCHIVO) ', System.Net.Mime.TransferEncoding.Base64
            _Message.Attachments.Add(VP_ADJUNTO)
        Else
            Codigo_Mensaje.PG_MENSAJE_AVISO("Archivo no encontrado")

        End If
        _Message.IsBodyHtml = False
        'ENVIO 
        Try
            _SMTP.Send(_Message)
            _SMTP.Dispose()
            VP_ADJUNTO.Dispose()
            Codigo_Mensaje.PG_MENSAJE_INFORMACION("Se ha enviado el correo exitosamente.")
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_ENVIAR_CORREO")
        End Try
    End Sub

    Public Shared Sub PG_ENVIAR_CORREO_DESDE_PREMA(ByVal PP_ASUNTO As String, ByVal PP_DESTINATARIO As String,
                                                           ByVal PP_BODY As String, ByVal PP_RUTA_ARCHIVO As String)
        Dim _Message As New System.Net.Mail.MailMessage()
        Dim _SMTP As New System.Net.Mail.SmtpClient
        'CONFIGURACIÓN DEL STMP
        _SMTP.Credentials = New System.Net.NetworkCredential("pr3m4.desarrollo@gmail.com", "Tomza2018")
        _SMTP.Host = "smtp.gmail.com"
        _SMTP.Port = 587
        _SMTP.EnableSsl = True

        ' CONFIGURACION DEL MENSAJE
        _Message.[To].Add(PP_DESTINATARIO) 'Para quién se lo envio. 
        _Message.From = New System.Net.Mail.MailAddress("pr3m4.desarrollo@gmail.com", "prema", System.Text.Encoding.UTF8) 'Quien lo envía
        _Message.Subject = PP_ASUNTO
        _Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
        _Message.Body = PP_BODY
        _Message.BodyEncoding = System.Text.Encoding.UTF8
        _Message.Priority = System.Net.Mail.MailPriority.High
        Dim VP_ADJUNTO As System.Net.Mail.Attachment = Nothing
        If File.Exists(PP_RUTA_ARCHIVO) Then
            VP_ADJUNTO = New System.Net.Mail.Attachment(PP_RUTA_ARCHIVO) ', System.Net.Mime.TransferEncoding.Base64
            _Message.Attachments.Add(VP_ADJUNTO)
        Else
            Codigo_Mensaje.PG_MENSAJE_AVISO("Archivo no encontrado")

        End If
        _Message.IsBodyHtml = False
        'ENVIO 
        Try
            _SMTP.Send(_Message)
            _SMTP.Dispose()
            VP_ADJUNTO.Dispose()
            Codigo_Mensaje.PG_MENSAJE_INFORMACION("Se ha enviado el correo exitosamente.")
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_ENVIAR_CORREO")
        End Try
    End Sub

End Class
