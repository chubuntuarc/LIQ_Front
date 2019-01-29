<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FO_CREDITO_BANCO_ESTADO
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
        Me.GB_DATOS_CREDITO_BANCARIO = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_COMISIONES_BANCO = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TB_PAGO_AMORTIZACION = New System.Windows.Forms.TextBox()
        Me.TB_N_PERIODO = New System.Windows.Forms.TextBox()
        Me.LB_ID = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_PAGO_COMISIONES = New System.Windows.Forms.TextBox()
        Me.TB_PAGO_INTERESES = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_CANCELAR = New System.Windows.Forms.Button()
        Me.BT_GUARDAR = New System.Windows.Forms.Button()
        Me.GB_DATOS_CREDITO_BANCARIO.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_DATOS_CREDITO_BANCARIO
        '
        Me.GB_DATOS_CREDITO_BANCARIO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_DATOS_CREDITO_BANCARIO.BackColor = System.Drawing.Color.White
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.Label1)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.TB_COMISIONES_BANCO)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.Label22)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.TB_PAGO_AMORTIZACION)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.TB_N_PERIODO)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.LB_ID)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.Label7)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.Label8)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.TB_PAGO_COMISIONES)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.TB_PAGO_INTERESES)
        Me.GB_DATOS_CREDITO_BANCARIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_DATOS_CREDITO_BANCARIO.Location = New System.Drawing.Point(3, 58)
        Me.GB_DATOS_CREDITO_BANCARIO.Name = "GB_DATOS_CREDITO_BANCARIO"
        Me.GB_DATOS_CREDITO_BANCARIO.Size = New System.Drawing.Size(365, 187)
        Me.GB_DATOS_CREDITO_BANCARIO.TabIndex = 55
        Me.GB_DATOS_CREDITO_BANCARIO.TabStop = False
        Me.GB_DATOS_CREDITO_BANCARIO.Text = "Ficha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Agregar una Comisión Bancaria:"
        '
        'TB_COMISIONES_BANCO
        '
        Me.TB_COMISIONES_BANCO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_COMISIONES_BANCO.Location = New System.Drawing.Point(219, 60)
        Me.TB_COMISIONES_BANCO.Name = "TB_COMISIONES_BANCO"
        Me.TB_COMISIONES_BANCO.Size = New System.Drawing.Size(118, 22)
        Me.TB_COMISIONES_BANCO.TabIndex = 58
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(110, 148)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(106, 13)
        Me.Label22.TabIndex = 57
        Me.Label22.Text = "Pago Amortización:"
        '
        'TB_PAGO_AMORTIZACION
        '
        Me.TB_PAGO_AMORTIZACION.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PAGO_AMORTIZACION.Location = New System.Drawing.Point(219, 144)
        Me.TB_PAGO_AMORTIZACION.Name = "TB_PAGO_AMORTIZACION"
        Me.TB_PAGO_AMORTIZACION.Size = New System.Drawing.Size(118, 22)
        Me.TB_PAGO_AMORTIZACION.TabIndex = 56
        '
        'TB_N_PERIODO
        '
        Me.TB_N_PERIODO.Enabled = False
        Me.TB_N_PERIODO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_N_PERIODO.Location = New System.Drawing.Point(262, 32)
        Me.TB_N_PERIODO.Name = "TB_N_PERIODO"
        Me.TB_N_PERIODO.Size = New System.Drawing.Size(75, 22)
        Me.TB_N_PERIODO.TabIndex = 21
        '
        'LB_ID
        '
        Me.LB_ID.AutoSize = True
        Me.LB_ID.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ID.Location = New System.Drawing.Point(265, 16)
        Me.LB_ID.Name = "LB_ID"
        Me.LB_ID.Size = New System.Drawing.Size(70, 13)
        Me.LB_ID.TabIndex = 19
        Me.LB_ID.Text = "No. Periodo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(118, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Pago Comisiones:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(132, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Pago Intereses:"
        '
        'TB_PAGO_COMISIONES
        '
        Me.TB_PAGO_COMISIONES.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PAGO_COMISIONES.Location = New System.Drawing.Point(219, 116)
        Me.TB_PAGO_COMISIONES.Name = "TB_PAGO_COMISIONES"
        Me.TB_PAGO_COMISIONES.Size = New System.Drawing.Size(118, 22)
        Me.TB_PAGO_COMISIONES.TabIndex = 10
        '
        'TB_PAGO_INTERESES
        '
        Me.TB_PAGO_INTERESES.AccessibleDescription = ""
        Me.TB_PAGO_INTERESES.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PAGO_INTERESES.Location = New System.Drawing.Point(219, 88)
        Me.TB_PAGO_INTERESES.Name = "TB_PAGO_INTERESES"
        Me.TB_PAGO_INTERESES.Size = New System.Drawing.Size(118, 22)
        Me.TB_PAGO_INTERESES.TabIndex = 8
        Me.TB_PAGO_INTERESES.Tag = "1"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel2.Controls.Add(Me.BT_CANCELAR)
        Me.FlowLayoutPanel2.Controls.Add(Me.BT_GUARDAR)
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 12)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(365, 40)
        Me.FlowLayoutPanel2.TabIndex = 60
        '
        'BT_CANCELAR
        '
        Me.BT_CANCELAR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BT_CANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_CANCELAR.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BT_CANCELAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_CANCELAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_CANCELAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_CANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_CANCELAR.Image = Global.PYF18_Finanzas.My.Resources.Resources.rsz_cancel
        Me.BT_CANCELAR.Location = New System.Drawing.Point(295, 3)
        Me.BT_CANCELAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_CANCELAR.Name = "BT_CANCELAR"
        Me.BT_CANCELAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_CANCELAR.TabIndex = 23
        Me.BT_CANCELAR.UseVisualStyleBackColor = True
        '
        'BT_GUARDAR
        '
        Me.BT_GUARDAR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BT_GUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_GUARDAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_GUARDAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_GUARDAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_GUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_GUARDAR.Image = Global.PYF18_Finanzas.My.Resources.Resources.rsz_accept
        Me.BT_GUARDAR.Location = New System.Drawing.Point(225, 3)
        Me.BT_GUARDAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_GUARDAR.Name = "BT_GUARDAR"
        Me.BT_GUARDAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_GUARDAR.TabIndex = 23
        Me.BT_GUARDAR.UseVisualStyleBackColor = True
        '
        'FO_CREDITO_BANCO_ESTADO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 251)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.GB_DATOS_CREDITO_BANCARIO)
        Me.Name = "FO_CREDITO_BANCO_ESTADO"
        Me.Text = "Ajuste Amortización"
        Me.GB_DATOS_CREDITO_BANCARIO.ResumeLayout(False)
        Me.GB_DATOS_CREDITO_BANCARIO.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents GB_DATOS_CREDITO_BANCARIO As GroupBox
    Friend WithEvents Label22 As Label
    Public WithEvents TB_PAGO_AMORTIZACION As TextBox
    Public WithEvents TB_N_PERIODO As TextBox
    Friend WithEvents LB_ID As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Public WithEvents TB_PAGO_COMISIONES As TextBox
    Public WithEvents TB_PAGO_INTERESES As TextBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Public WithEvents BT_CANCELAR As Button
    Public WithEvents BT_GUARDAR As Button
    Friend WithEvents Label1 As Label
    Public WithEvents TB_COMISIONES_BANCO As TextBox
End Class
