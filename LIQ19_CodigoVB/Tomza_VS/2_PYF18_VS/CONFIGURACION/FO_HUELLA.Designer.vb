<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FO_HUELLA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PB_HUELLA = New System.Windows.Forms.PictureBox()
        Me.RT_ESTATUS = New System.Windows.Forms.RichTextBox()
        Me.LB_PROMPT = New System.Windows.Forms.Label()
        CType(Me.PB_HUELLA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB_HUELLA
        '
        Me.PB_HUELLA.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PB_HUELLA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PB_HUELLA.Location = New System.Drawing.Point(85, 66)
        Me.PB_HUELLA.Name = "PB_HUELLA"
        Me.PB_HUELLA.Size = New System.Drawing.Size(277, 377)
        Me.PB_HUELLA.TabIndex = 0
        Me.PB_HUELLA.TabStop = False
        '
        'RT_ESTATUS
        '
        Me.RT_ESTATUS.Location = New System.Drawing.Point(444, 84)
        Me.RT_ESTATUS.Name = "RT_ESTATUS"
        Me.RT_ESTATUS.Size = New System.Drawing.Size(453, 359)
        Me.RT_ESTATUS.TabIndex = 1
        Me.RT_ESTATUS.Text = ""
        '
        'LB_PROMPT
        '
        Me.LB_PROMPT.AutoSize = True
        Me.LB_PROMPT.Location = New System.Drawing.Point(444, 68)
        Me.LB_PROMPT.Name = "LB_PROMPT"
        Me.LB_PROMPT.Size = New System.Drawing.Size(10, 13)
        Me.LB_PROMPT.TabIndex = 2
        Me.LB_PROMPT.Text = "."
        '
        'FO_HUELLA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 519)
        Me.Controls.Add(Me.LB_PROMPT)
        Me.Controls.Add(Me.RT_ESTATUS)
        Me.Controls.Add(Me.PB_HUELLA)
        Me.Name = "FO_HUELLA"
        Me.Text = "FO_HUELLA"
        CType(Me.PB_HUELLA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents LB_PROMPT As Label
    Public WithEvents PB_HUELLA As PictureBox
    Public WithEvents RT_ESTATUS As RichTextBox
End Class
