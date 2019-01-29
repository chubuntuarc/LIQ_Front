Public Class ProgressBarEx
    Public Shared Function FG_PROGRESSBAR_INIT(ByRef PP_FORMA As Object, ByVal PP_MIN As Integer, ByVal PP_MAX As Integer, ByVal PP_TITULO As String) As BARRA_DE_PROGRESO
        On Error Resume Next
        Dim VP_PB_BARRA As New ProgressBar()
        Dim VP_GB_OPERACION As GroupBox = PP_FORMA.GB_OPERACION
        VP_PB_BARRA.Height = 30
        VP_PB_BARRA.Width = VP_GB_OPERACION.Width - 10

        VP_GB_OPERACION.Controls.Add(VP_PB_BARRA)
        VP_PB_BARRA.Location = New Point(5, 15)
        VP_PB_BARRA.Visible = True
        VP_PB_BARRA.BringToFront()

        Dim VP_PROGRESSBAREX As New BARRA_DE_PROGRESO(VP_PB_BARRA, PP_MIN, PP_MAX, PP_TITULO)

        Dim VP_LABEL As New Label
        VP_LABEL.Text = PP_TITULO


        Return VP_PROGRESSBAREX
        On Error GoTo 0
    End Function

    Public Shared Function FG_PROGRESSBAR_INIT(ByRef PP_GROUPBOX As GroupBox, ByVal PP_MIN As Integer, ByVal PP_MAX As Integer, ByVal PP_TITULO As String) As BARRA_DE_PROGRESO
        On Error Resume Next
        Dim VP_PB_BARRA As New ProgressBar()
        Dim VP_GB_OPERACION As GroupBox = PP_GROUPBOX
        VP_PB_BARRA.Height = 30
        VP_PB_BARRA.Width = VP_GB_OPERACION.Width - 10

        VP_GB_OPERACION.Controls.Add(VP_PB_BARRA)
        VP_PB_BARRA.Location = New Point(5, 15)
        VP_PB_BARRA.Visible = True
        VP_PB_BARRA.BringToFront()

        Dim VP_PROGRESSBAREX As New BARRA_DE_PROGRESO(VP_PB_BARRA, PP_MIN, PP_MAX, PP_TITULO)

        Dim VP_LABEL As New Label
        VP_LABEL.Text = PP_TITULO


        Return VP_PROGRESSBAREX
        On Error GoTo 0
    End Function

    Public Shared Sub PG_PROGRESSBAR_INCREMENT(ByRef VP_PB_BARRA As BARRA_DE_PROGRESO, ByVal PP_VALUE As Integer)
        On Error Resume Next
        VP_PB_BARRA.PG_BARRA_DE_PROGRESO_ACT(PP_VALUE)
        Application.DoEvents()
        On Error GoTo 0
    End Sub

    Public Shared Sub PG_PROGRESSBAR_END(ByRef VP_PB_BARRA As BARRA_DE_PROGRESO)
        On Error Resume Next
        VP_PB_BARRA.PG_BARRA_DE_PROGRESO_FINALIZAR()
        Application.DoEvents()
        On Error GoTo 0
    End Sub

End Class
