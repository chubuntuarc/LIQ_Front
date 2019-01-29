Public Class FO_SPLASH3

    Dim VM_CONT As Integer = 0
    Private Sub FO_SPLASH3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(Screen.PrimaryScreen.Bounds.Width * 0.5, Screen.PrimaryScreen.Bounds.Height * 0.5)
        'PictureBox1.Height = Me.Height * 0.355
        Me.StartPosition = FormStartPosition.CenterScreen
        Label2.Text = "Entrega " + Application.ProductVersion
        'If Debugger.IsAttached = True Then
        '    TI_TIMER.Interval = 100
        'End If

        'TI_TIMER.Enabled = True
        'TI_TIMER.Start()
        TI_TIMER_TEXTO.Enabled = True
        TI_TIMER_TEXTO.Start()
    End Sub
    Private Sub PM_CARGAR_LOGIN()
        Dim VP_LOGIN As New LoginISAAC
        VP_LOGIN.Show()
        Me.Close()
    End Sub

    Private Sub TI_TIMER_Tick(sender As Object, e As EventArgs) Handles TI_TIMER.Tick
        PM_CARGAR_LOGIN()
        TI_TIMER.Enabled = False
    End Sub

    Private Sub TI_TIMER_TEXTO_Tick(sender As Object, e As EventArgs) Handles TI_TIMER_TEXTO.Tick
        If VM_CONT = 0 Then
            Label1.Text = "loading"
        Else
            Label1.Text = Label1.Text + "."
            If VM_CONT > 6 Then
                VM_CONT = -1
            End If
        End If
        VM_CONT += 1

    End Sub

    Private Sub FO_SPLASH3_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        TI_TIMER_TEXTO.Enabled = False
        TI_TIMER_TEXTO.Stop()

        PM_CARGAR_LOGIN()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TI_TIMER_TEXTO.Enabled = False
        TI_TIMER_TEXTO.Stop()

        PM_CARGAR_LOGIN()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim VP_LOGIN As New LoginISAAC
        VP_LOGIN.DESARROLLO1 = 1
        VP_LOGIN.Show()
        Me.Close()
    End Sub
End Class