Public Class ProgressBarPanel
    Public Shared Function FG_PROGRESSBAR_INIT(ByRef PP_FORMA As Object, ByVal PP_MIN As Integer, ByVal PP_MAX As Integer, ByVal PP_TITULO As String, ByVal PP_COLOR As Color) As BARRA_DE_PROGRESO_PANEL
        On Error Resume Next
        Dim VP_PB_BARRA As New Panel
        Dim VP_GB_OPERACION As GroupBox = PP_FORMA.GB_OPERACION
        Dim VP_LB_RESULTADO As TextBox = PP_FORMA.LB_RESULTADO
        VP_PB_BARRA.Height = VP_LB_RESULTADO.Height - 13
        VP_PB_BARRA.Width = 0
        VP_PB_BARRA.BackColor = PP_COLOR
        VP_GB_OPERACION.Controls.Add(VP_PB_BARRA)
        VP_PB_BARRA.Location = New Point(VP_LB_RESULTADO.Location.X + 1, VP_LB_RESULTADO.Location.Y + 12)
        VP_PB_BARRA.Visible = True
        VP_PB_BARRA.BringToFront()

        Dim VP_PROGRESSBAREX As New BARRA_DE_PROGRESO_PANEL(VP_LB_RESULTADO, VP_PB_BARRA, PP_MIN, PP_MAX, PP_TITULO)

        Dim VP_LABEL As New Label
        VP_LABEL.Text = PP_TITULO


        Return VP_PROGRESSBAREX
        On Error GoTo 0
    End Function

    Public Shared Sub PG_PROGRESSBAR_INCREMENT(ByRef VP_PB_BARRA As BARRA_DE_PROGRESO_PANEL, ByVal PP_VALUE As Integer)
        On Error Resume Next
        VP_PB_BARRA.PG_BARRA_DE_PROGRESO_ACT(PP_VALUE)
        'Application.DoEvents()
        On Error GoTo 0
    End Sub

    Public Shared Sub PG_PROGRESSBAR_INCREMENT(ByRef VP_PB_BARRA As BARRA_DE_PROGRESO_PANEL, ByVal PP_VALUE As Integer, ByVal PP_NOMBRE_ITEM As String)
        On Error Resume Next
        VP_PB_BARRA.PG_BARRA_DE_PROGRESO_ACT(PP_VALUE, PP_NOMBRE_ITEM)
        'Application.DoEvents()
        On Error GoTo 0
    End Sub

    Public Shared Sub PG_PROGRESSBAR_END(ByRef VP_PB_BARRA As BARRA_DE_PROGRESO_PANEL)
        On Error Resume Next
        VP_PB_BARRA.PG_BARRA_DE_PROGRESO_FINALIZAR()
        On Error GoTo 0
    End Sub

End Class
