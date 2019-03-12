Public Class FO_SPLASH3

    Dim VM_TIEMPO As Integer = 0
    Dim VM_INCREMENTO As Integer = 1




    Private Sub FO_SPLASH3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(Screen.PrimaryScreen.Bounds.Width * 0.5, Screen.PrimaryScreen.Bounds.Height * 0.5)
        'PictureBox1.Height = Me.Height * 0.355
        Me.StartPosition = FormStartPosition.CenterScreen

        LA_SYS_VERSION.Text = "Entrega " + Application.ProductVersion

        REM ///////////////////////////////////////////////////////////////////// 
        REM /// #0 N/A | #1 PROD | #2 PERF | #3 UAT | #4 CERT | #5 LAB (BRUNO) | #6 UNIT | #7 DESA

        Dim VP_AMBIENTE As String = "#" + LIQ19_Constantes.CG_SYS_AMBIENTE.ToString()

        If LIQ19_Constantes.CG_SYS_AMBIENTE = 1 Then
            VP_AMBIENTE = "PROD"
        End If

        REM ///////////////////////////////////////////////////////////////////// 

        If LIQ19_Constantes.CG_SYS_AMBIENTE = 5 Then
            VP_AMBIENTE = "LAB"
        End If

        REM ///////////////////////////////////////////////////////////////////// 

        If LIQ19_Constantes.CG_SYS_AMBIENTE = 6 Then
            VP_AMBIENTE = "UNI.HGF"
        End If

        REM ///////////////////////////////////////////////////////////////////// 

        If LIQ19_Constantes.CG_SYS_AMBIENTE = 7 Then
            VP_AMBIENTE = "DESA"
        End If

        REM ///////////////////////////////////////////////////////////////////// 

        LA_SYS_VERSION.Text = "Entrega @Ambiente=" + VP_AMBIENTE + " | [EXE] " + LIQ19_Constantes.CG_VERSION_EXE + " | [BD] " + LIQ19_Constantes.CG_VERSION_DTB

        'Call LIQ19_Codigo.PG_TOMZA_SYS_SetUp()

        TI_TIMER_TEXTO.Enabled = True
        TI_TIMER_TEXTO.Start()

    End Sub


    Private Sub TI_TIMER_Tick(sender As Object, e As EventArgs) Handles TI_TIMER.Tick

        TI_TIMER.Enabled = False
    End Sub

    Private Sub TI_TIMER_TEXTO_Tick(sender As Object, e As EventArgs) Handles TI_TIMER_TEXTO.Tick
        If VM_INCREMENTO <> 0 Then

            If VM_TIEMPO = 0 Then
                Label1.Text = "loading"
            Else
                Label1.Text = Label1.Text + "."
                If VM_TIEMPO > 6 Then
                    VM_INCREMENTO = 0
                    PM_CARGAR_LOGIN()
                End If
            End If

        End If

        VM_TIEMPO = VM_TIEMPO + VM_INCREMENTO

    End Sub

    Private Sub FO_SPLASH3_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        TI_TIMER_TEXTO.Enabled = False
        TI_TIMER_TEXTO.Stop()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        TI_TIMER_TEXTO.Enabled = False
        TI_TIMER_TEXTO.Stop()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PM_CARGAR_LOGIN()


    End Sub

    Private Sub PM_CARGAR_LOGIN()

        REM /// #0 N/A | #1 PROD | #2 PERF | #3 UAT | #4 CERT | #5 LAB (BRUNO) | #6 UNIT | #7 DESA
        If (LIQ19_Constantes.CG_SYS_AMBIENTE = 1) Or (LIQ19_Constantes.CG_SYS_AMBIENTE = 2) Then
            Dim VP_LOGIN As New FO_Login
            VP_LOGIN.Show()
            Me.Close()
        Else
            Dim VP_LOGIN As New FO_Login

            VP_LOGIN.Show()
            Me.Close()

        End If

    End Sub

End Class