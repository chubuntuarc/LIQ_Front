<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resultado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LI_RESULTADO = New System.Windows.Forms.DataGridView()
        Me.BT_ACEPTAR = New System.Windows.Forms.Button()
        CType(Me.LI_RESULTADO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LI_RESULTADO
        '
        Me.LI_RESULTADO.AllowUserToAddRows = False
        Me.LI_RESULTADO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LI_RESULTADO.Location = New System.Drawing.Point(3, 3)
        Me.LI_RESULTADO.Name = "LI_RESULTADO"
        Me.LI_RESULTADO.Size = New System.Drawing.Size(361, 282)
        Me.LI_RESULTADO.TabIndex = 0
        '
        'BT_ACEPTAR
        '
        Me.BT_ACEPTAR.Location = New System.Drawing.Point(108, 313)
        Me.BT_ACEPTAR.Name = "BT_ACEPTAR"
        Me.BT_ACEPTAR.Size = New System.Drawing.Size(75, 23)
        Me.BT_ACEPTAR.TabIndex = 1
        Me.BT_ACEPTAR.Text = "Aceptar"
        Me.BT_ACEPTAR.UseVisualStyleBackColor = True
        '
        'Resultado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 343)
        Me.Controls.Add(Me.BT_ACEPTAR)
        Me.Controls.Add(Me.LI_RESULTADO)
        Me.Name = "Resultado"
        Me.Text = "Resultado"
        CType(Me.LI_RESULTADO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LI_RESULTADO As DataGridView
    Friend WithEvents BT_ACEPTAR As Button
End Class
