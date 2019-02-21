<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FO_WIZARD
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
        Me.BT_CALC = New System.Windows.Forms.Button()
        Me.UC_PRECIO_COSTO_PERFIL1 = New LIQ19_Liquidaciones.UC_PRECIO_COSTO_PERFIL()
        Me.UC_DOCUMENTO_D0M41 = New LIQ19_Liquidaciones.UC_DOCUMENTO_D0M4()
        Me.BT_SALIR = New System.Windows.Forms.Button()
        Me.UC_PARAMETRO_DOCUMENTO_D0M41 = New LIQ19_Liquidaciones.UC_PARAMETRO_DOCUMENTO_D0M4()
        Me.SuspendLayout()
        '
        'BT_NEXT
        '
        Me.BT_NEXT.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BT_NEXT.Location = New System.Drawing.Point(1286, 265)
        Me.BT_NEXT.Name = "BT_NEXT"
        Me.BT_NEXT.Size = New System.Drawing.Size(75, 23)
        Me.BT_NEXT.TabIndex = 1
        Me.BT_NEXT.Text = "Siguiente >>"
        Me.BT_NEXT.UseVisualStyleBackColor = True
        '
        'BT_BACK
        '
        Me.BT_BACK.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BT_BACK.Location = New System.Drawing.Point(1286, 236)
        Me.BT_BACK.Name = "BT_BACK"
        Me.BT_BACK.Size = New System.Drawing.Size(75, 23)
        Me.BT_BACK.TabIndex = 2
        Me.BT_BACK.Text = "<< Anterior"
        Me.BT_BACK.UseVisualStyleBackColor = True
        '
        'BT_CALC
        '
        Me.BT_CALC.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BT_CALC.Location = New System.Drawing.Point(1286, 294)
        Me.BT_CALC.Name = "BT_CALC"
        Me.BT_CALC.Size = New System.Drawing.Size(75, 23)
        Me.BT_CALC.TabIndex = 3
        Me.BT_CALC.Text = "Σ"
        Me.BT_CALC.UseVisualStyleBackColor = True
        '
        'UC_PRECIO_COSTO_PERFIL1
        '
        Me.UC_PRECIO_COSTO_PERFIL1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UC_PRECIO_COSTO_PERFIL1.Location = New System.Drawing.Point(0, 0)
        Me.UC_PRECIO_COSTO_PERFIL1.Name = "UC_PRECIO_COSTO_PERFIL1"
        Me.UC_PRECIO_COSTO_PERFIL1.Size = New System.Drawing.Size(1280, 740)
        Me.UC_PRECIO_COSTO_PERFIL1.TabIndex = 0
        '
        'UC_DOCUMENTO_D0M41
        '
        Me.UC_DOCUMENTO_D0M41.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UC_DOCUMENTO_D0M41.Location = New System.Drawing.Point(0, 0)
        Me.UC_DOCUMENTO_D0M41.Name = "UC_DOCUMENTO_D0M41"
        Me.UC_DOCUMENTO_D0M41.Size = New System.Drawing.Size(1280, 740)
        Me.UC_DOCUMENTO_D0M41.TabIndex = 4
        Me.UC_DOCUMENTO_D0M41.Visible = False
        '
        'BT_SALIR
        '
        Me.BT_SALIR.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BT_SALIR.BackColor = System.Drawing.Color.White
        Me.BT_SALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_SALIR.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.BT_SALIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_SALIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_SALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_SALIR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_exit
        Me.BT_SALIR.Location = New System.Drawing.Point(1286, 324)
        Me.BT_SALIR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_SALIR.Name = "BT_SALIR"
        Me.BT_SALIR.Size = New System.Drawing.Size(75, 35)
        Me.BT_SALIR.TabIndex = 24
        Me.BT_SALIR.UseVisualStyleBackColor = False
        '
        'UC_PARAMETRO_DOCUMENTO_D0M41
        '
        Me.UC_PARAMETRO_DOCUMENTO_D0M41.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UC_PARAMETRO_DOCUMENTO_D0M41.Location = New System.Drawing.Point(0, 0)
        Me.UC_PARAMETRO_DOCUMENTO_D0M41.Name = "UC_PARAMETRO_DOCUMENTO_D0M41"
        Me.UC_PARAMETRO_DOCUMENTO_D0M41.Size = New System.Drawing.Size(1280, 740)
        Me.UC_PARAMETRO_DOCUMENTO_D0M41.TabIndex = 25
        Me.UC_PARAMETRO_DOCUMENTO_D0M41.Visible = False
        '
        'FO_WIZARD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.UC_PARAMETRO_DOCUMENTO_D0M41)
        Me.Controls.Add(Me.BT_SALIR)
        Me.Controls.Add(Me.UC_DOCUMENTO_D0M41)
        Me.Controls.Add(Me.BT_CALC)
        Me.Controls.Add(Me.BT_BACK)
        Me.Controls.Add(Me.BT_NEXT)
        Me.Controls.Add(Me.UC_PRECIO_COSTO_PERFIL1)
        Me.DoubleBuffered = True
        Me.Name = "FO_WIZARD"
        Me.Text = "FO_WIZARD"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_PRECIO_COSTO_PERFIL1 As UC_PRECIO_COSTO_PERFIL
    Friend WithEvents BT_NEXT As Button
    Friend WithEvents BT_BACK As Button
    Friend WithEvents BT_CALC As Button
    Friend WithEvents UC_DOCUMENTO_D0M41 As UC_DOCUMENTO_D0M4
    Public WithEvents BT_SALIR As Button
    Friend WithEvents UC_PARAMETRO_DOCUMENTO_D0M41 As UC_PARAMETRO_DOCUMENTO_D0M4
End Class
