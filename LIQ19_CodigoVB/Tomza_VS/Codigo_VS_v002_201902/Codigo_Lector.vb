Imports System.IO
Imports DPFP.Capture
Public Class Captura
    Implements DPFP.Capture.EventHandler

    Dim Capturer As DPFP.Capture.Capture
    Dim VM_PICTUREBOX As PictureBox
    Dim VM_RICHTEXTBOX As RichTextBox
    Dim VM_LABEL As Label

    Public Property Capturer1 As Capture
        Get
            Return Capturer
        End Get
        Set(value As Capture)
            Capturer = value
        End Set
    End Property

    Public Property VM_PICTUREBOX1 As PictureBox
        Get
            Return VM_PICTUREBOX
        End Get
        Set(value As PictureBox)
            VM_PICTUREBOX = value
        End Set
    End Property

    Public Property VM_RICHTEXTBOX1 As RichTextBox
        Get
            Return VM_RICHTEXTBOX
        End Get
        Set(value As RichTextBox)
            VM_RICHTEXTBOX = value
        End Set
    End Property

    Public Property VM_LABEL1 As Label
        Get
            Return VM_LABEL
        End Get
        Set(value As Label)
            VM_LABEL = value
        End Set
    End Property

    Public Sub New(ByRef PP_CAPTURER As Capture, ByRef PP_PICTUREBOX As PictureBox, ByRef PP_RICHTEXTBOX As RichTextBox, ByRef PP_LABEL As Label)
        Me.Capturer1 = PP_CAPTURER
        Me.VM_PICTUREBOX1 = PP_PICTUREBOX
        Me.VM_RICHTEXTBOX1 = PP_RICHTEXTBOX
        Me.VM_LABEL1 = PP_LABEL
    End Sub

    Public Overridable Sub Init()

        Try

            Capturer1 = New DPFP.Capture.Capture()                   ' Create a capture operation.

            If (Not Capturer1 Is Nothing) Then
                Capturer1.EventHandler = Me                              ' Subscribe for capturing events.
                StartCapture()
            Else
                SetPrompt("No es posible iniciar la captura!")
            End If
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_AVISO("No es posible iniciar la captura!")
        End Try

    End Sub

    Public Overridable Sub Process(ByVal Sample As DPFP.Sample)
        DrawPicture(ConvertSampleToBitmap(Sample))
    End Sub

    Protected Function ConvertSampleToBitmap(ByVal Sample As DPFP.Sample) As Bitmap
        Dim convertor As New DPFP.Capture.SampleConversion()  ' Create a sample convertor.
        Dim bitmap As Bitmap = Nothing              ' TODO: the size doesn't matter
        convertor.ConvertToPicture(Sample, bitmap)        ' TODO: return bitmap as a result
        Return bitmap
    End Function

    Protected Function ExtractFeatures(ByVal Sample As DPFP.Sample, ByVal Purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Dim extractor As New DPFP.Processing.FeatureExtraction()    ' Create a feature extractor
        Dim feedback As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
        Dim features As New DPFP.FeatureSet()
        extractor.CreateFeatureSet(Sample, Purpose, feedback, features) ' TODO: return features as a result?
        If (feedback = DPFP.Capture.CaptureFeedback.Good) Then
            Return features
        Else
            Return Nothing
        End If
    End Function

    Protected Sub StartCapture()
        If (Not Capturer1 Is Nothing) Then
            Try
                Capturer1.StartCapture()
                SetPrompt("Escaner listo, inicia el escanéo")
            Catch ex As Exception
                SetPrompt("Captura no iniciada!")
            End Try
        End If
    End Sub

    Protected Sub StopCapture()
        If (Not Capturer1 Is Nothing) Then
            Try
                Capturer1.StopCapture()
            Catch ex As Exception
                SetPrompt("No es posible terminar la captura!")
            End Try
        End If
    End Sub

    Private Sub Capture_Init()
        Init()
        StartCapture()
    End Sub

    Private Sub Capture_End()
        StopCapture()
    End Sub

    Sub OnComplete(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        'MakeReport("Captura realizada")
        'SetPrompt("Scan the same fingerprint again.")
        Process(Sample)
    End Sub

    Sub OnFingerGone(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerGone
        ' MakeReport("The finger was removed from the fingerprint reader.")
    End Sub

    Sub OnFingerTouch(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerTouch
        'MakeReport("The fingerprint reader was touched.")
    End Sub

    Sub OnReaderConnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderConnect
        MakeReport("Lector conectado")
    End Sub

    Sub OnReaderDisconnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderDisconnect
        MakeReport("Lector desconectado")
    End Sub

    Sub OnSampleQuality(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal CaptureFeedback As DPFP.Capture.CaptureFeedback) Implements DPFP.Capture.EventHandler.OnSampleQuality
        If CaptureFeedback = DPFP.Capture.CaptureFeedback.Good Then
            MakeReport("La calidad de la lectura es buena")
        Else
            MakeReport("La lectura tiene calidad pobre")
        End If
    End Sub

    Protected Sub SetStatus(ByVal status)
        VM_RICHTEXTBOX1.Text = status + vbCrLf + VM_RICHTEXTBOX1.Text
    End Sub

    Protected Sub SetPrompt(ByVal text)
        VM_LABEL1.Text = text
    End Sub

    Protected Sub MakeReport(ByVal status)
        VM_RICHTEXTBOX1.Text = status + vbCrLf + VM_RICHTEXTBOX1.Text
    End Sub

    Protected Sub DrawPicture(ByVal bmp)
        VM_PICTUREBOX1.Image = New Bitmap(bmp, VM_PICTUREBOX1.Size)
    End Sub


End Class
Public Class Verificacion
    Inherits Captura
    Private Template As DPFP.Template
    Private Verificator As DPFP.Verification.Verification

    Public Sub New(ByRef PP_CAPTURER As Capture, ByRef PP_PICTUREBOX As PictureBox, ByRef PP_RICHTEXTBOX As RichTextBox, ByRef PP_LABEL As Label)
        MyBase.New(PP_CAPTURER, PP_PICTUREBOX, PP_RICHTEXTBOX, PP_LABEL)

    End Sub

    Public Sub Verify(ByVal template As DPFP.Template)
        Me.Template = template
        ' ShowDialog()
    End Sub

    Public Overrides Sub Init()
        MyBase.Init()
        MyBase.SetPrompt("Verificación de Huella")
        Verificator = New DPFP.Verification.Verification()
        UpdateStatus(0)
    End Sub

    Public Overrides Sub Process(ByVal Sample As DPFP.Sample)
        MyBase.Process(Sample)
        ' MyBase.VM_PICTUREBOX1.Image = ConvertSampleToBitmap(Sample)

        ' Process the sample and create a feature set for the enrollment purpose.
        Dim features As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification)

        ' Check quality of the sample and start verification if it's good
        If Not features Is Nothing Then
            ' Compare the feature set with our template
            'Dim result As DPFP.Verification.Verification.Result = New DPFP.Verification.Verification.Result()
            Dim VP_PARAMETROS As String = "'',-1"
            Dim VP_DATATABLE As New Data.DataTable
            Codigo_ABC.PG_BT_EJECUTAR_ACCION_TABLA_CLICK(0, Me, "[PG_LI_REGISTRO_DACTILAR]", VP_PARAMETROS, VP_DATATABLE)
            Dim VP_CONTADOR As Integer = 0
            Dim VP_CONTADOR_REGISTROS As Integer = 0
            VP_CONTADOR_REGISTROS = VP_DATATABLE.Rows.Count
            Dim VP_BANDERA As Boolean = False
            While VP_CONTADOR < VP_CONTADOR_REGISTROS And VP_BANDERA = False
                Dim VP_K_USUARIO As Integer = 0
                Dim VP_D_USUARIO As String = ""
                Dim VP_HUELLA_1 As Byte() = New Byte() {}
                Dim VP_BYTEARRAY As Byte() = New Byte() {}

                VP_K_USUARIO = Codigo_LI.FG_LI_CELL_READ(VP_DATATABLE, VP_CONTADOR, "K_USUARIO")

                VP_D_USUARIO = Codigo_LI.FG_LI_CELL_READ(VP_DATATABLE, VP_CONTADOR, "D_USUARIO")
                Dim VP_DEDO = 1
                While VP_BANDERA = False And VP_DEDO < 11
                    If VP_DATATABLE.Rows(VP_CONTADOR)("L_DEDO_" + VP_DEDO.ToString()) = 1 Then
                        VP_HUELLA_1 = VP_DATATABLE.Rows(VP_CONTADOR)("V_DEDO_" + VP_DEDO.ToString())
                        If VP_HUELLA_1.Length > 100 Then
                            VP_BYTEARRAY = VP_HUELLA_1

                            Try

                                Dim stream As New MemoryStream(VP_HUELLA_1)
                                Dim VP_TEMPLATE As New DPFP.Template()
                                VP_TEMPLATE.DeSerialize(VP_HUELLA_1)
                                Dim vp_data As New DPFP.Template()
                                vp_data.DeSerialize(stream)
                                Dim result As DPFP.Verification.Verification.Result = New DPFP.Verification.Verification.Result()
                                Try
                                    Verificator.Verify(features, vp_data, result)
                                Catch ex As Exception
                                    Verificator.Verify(features, VP_TEMPLATE, result)
                                End Try
                                UpdateStatus(result.FARAchieved)
                                If result.Verified Then
                                    MyBase.SetStatus("Huella identificada.  Usuario  #" + VP_K_USUARIO.ToString() + "  " + VP_D_USUARIO)
                                    VP_BANDERA = True
                                End If
                            Catch ex As Exception

                                Codigo_Mensaje.PG_MENSAJE_AVISO(ex.Message)
                                StopCapture()
                            End Try
                        End If
                    End If
                    VP_DEDO += 1
                End While
                VP_CONTADOR += 1
            End While
            If VP_BANDERA = False Then
                MyBase.SetStatus("Huella no identificada.")
            End If
        End If
    End Sub

    Protected Sub UpdateStatus(ByVal FAR As Integer)
        ' Show "False accept rate" value
        ' SetStatus(String.Format("Tasa de aceptación falsa = {0}", FAR))
    End Sub

End Class
Public Class Enrolado
    Inherits Captura

    Public Event OnTemplate(ByVal template)

    Private Enroller As DPFP.Processing.Enrollment

    Public Sub New(ByRef PP_CAPTURER As Capture, ByRef PP_PICTUREBOX As PictureBox, ByRef PP_RICHTEXTBOX As RichTextBox, ByRef PP_LABEL As Label)
        MyBase.New(PP_CAPTURER, PP_PICTUREBOX, PP_RICHTEXTBOX, PP_LABEL)
    End Sub

    Public Overrides Sub Init()
        MyBase.Init()
        MyBase.SetPrompt("Registro de Huella")
        Enroller = New DPFP.Processing.Enrollment()     ' Create an enrollment.
        UpdateStatus()
    End Sub

    Public Overrides Sub Process(ByVal Sample As DPFP.Sample)
        MyBase.Process(Sample)

        ' Process the sample and create a feature set for the enrollment purpose.
        Dim features As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment)

        ' Check quality of the sample and add to enroller if it's good
        If (Not features Is Nothing) Then
            Try
                ' MakeReport("Captura completa.")
                Enroller.AddFeatures(features)        ' Add feature set to template.
            Finally
                UpdateStatus()

                ' Check if template has been created.
                Select Case Enroller.TemplateStatus
                    Case DPFP.Processing.Enrollment.Status.Ready    ' Report success and stop capturing
                        RaiseEvent OnTemplate(Enroller.Template)
                        'SetPrompt("Click Close, and then click Fingerprint Verification.")
                        StopCapture()

                    Case DPFP.Processing.Enrollment.Status.Failed   ' Report failure and restart capturing
                        Enroller.Clear()
                        StopCapture()
                        RaiseEvent OnTemplate(Nothing)
                        StartCapture()

                End Select
            End Try
        End If
    End Sub

    Protected Sub UpdateStatus()
        ' Show number of samples needed.
        SetStatus(String.Format("Toques restantes: {0}", Enroller.FeaturesNeeded))
    End Sub
End Class
