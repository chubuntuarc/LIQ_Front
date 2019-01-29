<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FO_WIZARD_PRESUPUESTO
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
        Me.components = New System.ComponentModel.Container()
        Me.BT_NEXT = New System.Windows.Forms.Button()
        Me.BT_BACK = New System.Windows.Forms.Button()
        Me.BT_SALIR = New System.Windows.Forms.Button()
        Me.UC_PARAMETRO_POB1 = New PYF18_Finanzas.UC_PARAMETRO_POB()
        Me.UC_DOCUMENTO_D0M4_PRESUPUESTO1 = New PYF18_Finanzas.UC_DOCUMENTO_D0M4_PRESUPUESTO()
        Me.SuspendLayout()
        '
        'BT_NEXT
        '
        Me.BT_NEXT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_NEXT.Location = New System.Drawing.Point(1286, 265)
        Me.BT_NEXT.Name = "BT_NEXT"
        Me.BT_NEXT.Size = New System.Drawing.Size(75, 23)
        Me.BT_NEXT.TabIndex = 1
        Me.BT_NEXT.Text = "Siguiente >>"
        Me.BT_NEXT.UseVisualStyleBackColor = True
        '
        'BT_BACK
        '
        Me.BT_BACK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_BACK.Location = New System.Drawing.Point(1286, 236)
        Me.BT_BACK.Name = "BT_BACK"
        Me.BT_BACK.Size = New System.Drawing.Size(75, 23)
        Me.BT_BACK.TabIndex = 2
        Me.BT_BACK.Text = "<< Anterior"
        Me.BT_BACK.UseVisualStyleBackColor = True
        '
        'BT_SALIR
        '
        Me.BT_SALIR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_SALIR.BackColor = System.Drawing.Color.White
        Me.BT_SALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_SALIR.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.BT_SALIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_SALIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_SALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_SALIR.Image = Global.PYF18_Finanzas.My.Resources.Resources.rsz_exit
        Me.BT_SALIR.Location = New System.Drawing.Point(1286, 295)
        Me.BT_SALIR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_SALIR.Name = "BT_SALIR"
        Me.BT_SALIR.Size = New System.Drawing.Size(75, 35)
        Me.BT_SALIR.TabIndex = 24
        Me.BT_SALIR.UseVisualStyleBackColor = False
        '
        'UC_PARAMETRO_POB1
        '
        Me.UC_PARAMETRO_POB1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UC_PARAMETRO_POB1.Location = New System.Drawing.Point(0, 0)
        Me.UC_PARAMETRO_POB1.Name = "UC_PARAMETRO_POB1"
        Me.UC_PARAMETRO_POB1.Size = New System.Drawing.Size(1280, 740)
        Me.UC_PARAMETRO_POB1.TabIndex = 26
        Me.UC_PARAMETRO_POB1.Visible = False
        '
        'UC_DOCUMENTO_D0M4_PRESUPUESTO1
        '
        Me.UC_DOCUMENTO_D0M4_PRESUPUESTO1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UC_DOCUMENTO_D0M4_PRESUPUESTO1.Location = New System.Drawing.Point(0, 0)
        Me.UC_DOCUMENTO_D0M4_PRESUPUESTO1.Name = "UC_DOCUMENTO_D0M4_PRESUPUESTO1"
        Me.UC_DOCUMENTO_D0M4_PRESUPUESTO1.Size = New System.Drawing.Size(1280, 740)
        Me.UC_DOCUMENTO_D0M4_PRESUPUESTO1.TabIndex = 25
        '
        'FO_WIZARD_PRESUPUESTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.UC_PARAMETRO_POB1)
        Me.Controls.Add(Me.UC_DOCUMENTO_D0M4_PRESUPUESTO1)
        Me.Controls.Add(Me.BT_SALIR)
        Me.Controls.Add(Me.BT_BACK)
        Me.Controls.Add(Me.BT_NEXT)
        Me.DoubleBuffered = True
        Me.Name = "FO_WIZARD_PRESUPUESTO"
        Me.Text = "FO_WIZARD_PRESUPUESTO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BT_NEXT As Button
    Friend WithEvents BT_BACK As Button
    Public WithEvents BT_SALIR As Button
    Friend WithEvents UC_DOCUMENTO_D0M4_PRESUPUESTO1 As UC_DOCUMENTO_D0M4_PRESUPUESTO
    Friend WithEvents UC_PARAMETRO_POB1 As UC_PARAMETRO_POB
End Class
