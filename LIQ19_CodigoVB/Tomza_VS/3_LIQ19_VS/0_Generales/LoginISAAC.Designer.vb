<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginISAAC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginISAAC))
        Me.TB_CONTRASENA = New System.Windows.Forms.TextBox()
        Me.BT_SALIR = New System.Windows.Forms.Button()
        Me.BT_INCIAR_SESION = New System.Windows.Forms.Button()
        Me.TB_LoginISAAC_ID = New System.Windows.Forms.TextBox()
        Me.CB_SERVER = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TB_CONTRASENA
        '
        Me.TB_CONTRASENA.BackColor = System.Drawing.Color.White
        Me.TB_CONTRASENA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_CONTRASENA.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CONTRASENA.Location = New System.Drawing.Point(82, 307)
        Me.TB_CONTRASENA.Name = "TB_CONTRASENA"
        Me.TB_CONTRASENA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_CONTRASENA.Size = New System.Drawing.Size(190, 26)
        Me.TB_CONTRASENA.TabIndex = 2
        Me.TB_CONTRASENA.Tag = "1"
        '
        'BT_SALIR
        '
        Me.BT_SALIR.BackColor = System.Drawing.Color.White
        Me.BT_SALIR.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_SALIR.FlatAppearance.BorderSize = 2
        Me.BT_SALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_SALIR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_SALIR.ForeColor = System.Drawing.Color.Black
        Me.BT_SALIR.Location = New System.Drawing.Point(54, 395)
        Me.BT_SALIR.Name = "BT_SALIR"
        Me.BT_SALIR.Size = New System.Drawing.Size(110, 29)
        Me.BT_SALIR.TabIndex = 5
        Me.BT_SALIR.Text = "Salir"
        Me.BT_SALIR.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_SALIR.UseVisualStyleBackColor = False
        '
        'BT_INCIAR_SESION
        '
        Me.BT_INCIAR_SESION.BackColor = System.Drawing.Color.White
        Me.BT_INCIAR_SESION.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_INCIAR_SESION.FlatAppearance.BorderSize = 2
        Me.BT_INCIAR_SESION.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_INCIAR_SESION.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_INCIAR_SESION.ForeColor = System.Drawing.Color.Black
        Me.BT_INCIAR_SESION.Location = New System.Drawing.Point(173, 395)
        Me.BT_INCIAR_SESION.Name = "BT_INCIAR_SESION"
        Me.BT_INCIAR_SESION.Size = New System.Drawing.Size(110, 29)
        Me.BT_INCIAR_SESION.TabIndex = 4
        Me.BT_INCIAR_SESION.Text = "Acceder"
        Me.BT_INCIAR_SESION.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_INCIAR_SESION.UseVisualStyleBackColor = False
        '
        'TB_LoginISAAC_ID
        '
        Me.TB_LoginISAAC_ID.BackColor = System.Drawing.Color.White
        Me.TB_LoginISAAC_ID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_LoginISAAC_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_LoginISAAC_ID.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LoginISAAC_ID.Location = New System.Drawing.Point(82, 259)
        Me.TB_LoginISAAC_ID.Name = "TB_LoginISAAC_ID"
        Me.TB_LoginISAAC_ID.Size = New System.Drawing.Size(190, 26)
        Me.TB_LoginISAAC_ID.TabIndex = 1
        Me.TB_LoginISAAC_ID.Tag = "1"
        '
        'CB_SERVER
        '
        Me.CB_SERVER.BackColor = System.Drawing.Color.White
        Me.CB_SERVER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_SERVER.DropDownWidth = 500
        Me.CB_SERVER.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CB_SERVER.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_SERVER.ForeColor = System.Drawing.Color.Black
        Me.CB_SERVER.ItemHeight = 21
        Me.CB_SERVER.Items.AddRange(New Object() {"BRUNO", "MACLOVIO", "LOCAL", "BRUNO27", "BRUNO28", "BRUNO29", "BRUNO30", "BRUNO31", "BRUNO32", "BRUNO33"})
        Me.CB_SERVER.Location = New System.Drawing.Point(54, 348)
        Me.CB_SERVER.Name = "CB_SERVER"
        Me.CB_SERVER.Size = New System.Drawing.Size(229, 29)
        Me.CB_SERVER.TabIndex = 3
        Me.CB_SERVER.Tag = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(68, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 40)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Autenticación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(28, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(279, 73)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "I S A A C"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.LIQ19_Liquidaciones.My.Resources.Resources.LOGINDATA
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(27, 247)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(281, 95)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.LIQ19_Liquidaciones.My.Resources.Resources.CANDADO
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(97, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 103)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'LoginISAAC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(335, 449)
        Me.Controls.Add(Me.TB_CONTRASENA)
        Me.Controls.Add(Me.TB_LoginISAAC_ID)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB_SERVER)
        Me.Controls.Add(Me.BT_SALIR)
        Me.Controls.Add(Me.BT_INCIAR_SESION)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginISAAC"
        Me.Text = "SNI"
        Me.TransparencyKey = System.Drawing.Color.Red
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_CONTRASENA As TextBox
    Friend WithEvents TB_LoginISAAC_ID As TextBox
    Friend WithEvents BT_SALIR As Button
    Friend WithEvents BT_INCIAR_SESION As Button
    Friend WithEvents CB_SERVER As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
