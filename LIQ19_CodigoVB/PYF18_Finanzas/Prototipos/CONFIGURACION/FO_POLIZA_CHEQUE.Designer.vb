<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FO_POLIZA_CHEQUE
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FO_POLIZA_CHEQUE))
        Me.GB_FILTROS = New System.Windows.Forms.GroupBox()
        Me.TB_K_INSTRUCCION = New System.Windows.Forms.TextBox()
        Me.LB_ID = New System.Windows.Forms.Label()
        Me.BT_IMPRIMIR = New System.Windows.Forms.Button()
        Me.GB_FILTROS.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_FILTROS
        '
        Me.GB_FILTROS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_FILTROS.BackColor = System.Drawing.Color.White
        Me.GB_FILTROS.Controls.Add(Me.TB_K_INSTRUCCION)
        Me.GB_FILTROS.Controls.Add(Me.LB_ID)
        Me.GB_FILTROS.Controls.Add(Me.BT_IMPRIMIR)
        Me.GB_FILTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FILTROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_FILTROS.Location = New System.Drawing.Point(12, 12)
        Me.GB_FILTROS.Name = "GB_FILTROS"
        Me.GB_FILTROS.Size = New System.Drawing.Size(951, 444)
        Me.GB_FILTROS.TabIndex = 35
        Me.GB_FILTROS.TabStop = False
        Me.GB_FILTROS.Text = "Impresión de Póliza para Cheque"
        '
        'TB_K_INSTRUCCION
        '
        Me.TB_K_INSTRUCCION.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_K_INSTRUCCION.Location = New System.Drawing.Point(15, 88)
        Me.TB_K_INSTRUCCION.Name = "TB_K_INSTRUCCION"
        Me.TB_K_INSTRUCCION.Size = New System.Drawing.Size(107, 22)
        Me.TB_K_INSTRUCCION.TabIndex = 74
        '
        'LB_ID
        '
        Me.LB_ID.AutoSize = True
        Me.LB_ID.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ID.Location = New System.Drawing.Point(17, 72)
        Me.LB_ID.Name = "LB_ID"
        Me.LB_ID.Size = New System.Drawing.Size(32, 13)
        Me.LB_ID.TabIndex = 73
        Me.LB_ID.Text = "#INS"
        '
        'BT_IMPRIMIR
        '
        Me.BT_IMPRIMIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_IMPRIMIR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_IMPRIMIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_IMPRIMIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_IMPRIMIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_IMPRIMIR.Image = CType(resources.GetObject("BT_IMPRIMIR.Image"), System.Drawing.Image)
        Me.BT_IMPRIMIR.Location = New System.Drawing.Point(152, 76)
        Me.BT_IMPRIMIR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_IMPRIMIR.Name = "BT_IMPRIMIR"
        Me.BT_IMPRIMIR.Size = New System.Drawing.Size(51, 34)
        Me.BT_IMPRIMIR.TabIndex = 40
        Me.BT_IMPRIMIR.UseVisualStyleBackColor = True
        '
        'FO_POLIZA_CHEQUE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 484)
        Me.Controls.Add(Me.GB_FILTROS)
        Me.Name = "FO_POLIZA_CHEQUE"
        Me.Text = "FO_POLIZA"
        Me.GB_FILTROS.ResumeLayout(False)
        Me.GB_FILTROS.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents GB_FILTROS As GroupBox
    Public WithEvents BT_IMPRIMIR As Button
    Public WithEvents TB_K_INSTRUCCION As TextBox
    Friend WithEvents LB_ID As Label
End Class
