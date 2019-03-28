<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FO_Login
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
        Me.TB_CONTRASENA = New System.Windows.Forms.TextBox()
        Me.BT_SALIR = New System.Windows.Forms.Button()
        Me.BT_INCIAR_SESION = New System.Windows.Forms.Button()
        Me.TB_Login = New System.Windows.Forms.TextBox()
        Me.CB_SERVER = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LA_SYS_NOMBRE = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TB_CONTRASENA
        '
        Me.TB_CONTRASENA.BackColor = System.Drawing.Color.White
        Me.TB_CONTRASENA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_CONTRASENA.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CONTRASENA.Location = New System.Drawing.Point(109, 378)
        Me.TB_CONTRASENA.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_CONTRASENA.Name = "TB_CONTRASENA"
        Me.TB_CONTRASENA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_CONTRASENA.Size = New System.Drawing.Size(253, 32)
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
        Me.BT_SALIR.Location = New System.Drawing.Point(231, 486)
        Me.BT_SALIR.Margin = New System.Windows.Forms.Padding(4)
        Me.BT_SALIR.Name = "BT_SALIR"
        Me.BT_SALIR.Size = New System.Drawing.Size(147, 36)
        Me.BT_SALIR.TabIndex = 5
        Me.BT_SALIR.Text = "Salir"
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
        Me.BT_INCIAR_SESION.Location = New System.Drawing.Point(74, 486)
        Me.BT_INCIAR_SESION.Margin = New System.Windows.Forms.Padding(4)
        Me.BT_INCIAR_SESION.Name = "BT_INCIAR_SESION"
        Me.BT_INCIAR_SESION.Size = New System.Drawing.Size(147, 36)
        Me.BT_INCIAR_SESION.TabIndex = 4
        Me.BT_INCIAR_SESION.Text = "Acceder"
        Me.BT_INCIAR_SESION.UseVisualStyleBackColor = False
        '
        'TB_Login
        '
        Me.TB_Login.BackColor = System.Drawing.Color.White
        Me.TB_Login.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_Login.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_Login.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Login.Location = New System.Drawing.Point(109, 319)
        Me.TB_Login.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_Login.Name = "TB_Login"
        Me.TB_Login.Size = New System.Drawing.Size(253, 32)
        Me.TB_Login.TabIndex = 1
        Me.TB_Login.Tag = "1"
        '
        'CB_SERVER
        '
        Me.CB_SERVER.BackColor = System.Drawing.Color.White
        Me.CB_SERVER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_SERVER.DropDownWidth = 500
        Me.CB_SERVER.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CB_SERVER.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_SERVER.ForeColor = System.Drawing.Color.Black
        Me.CB_SERVER.ItemHeight = 28
        Me.CB_SERVER.Items.AddRange(New Object() {"BRUNO", "MACLOVIO", "LOCAL", "BRUNO27", "BRUNO28", "BRUNO29", "BRUNO30", "BRUNO31", "BRUNO32", "BRUNO33"})
        Me.CB_SERVER.Location = New System.Drawing.Point(72, 428)
        Me.CB_SERVER.Margin = New System.Windows.Forms.Padding(4)
        Me.CB_SERVER.Name = "CB_SERVER"
        Me.CB_SERVER.Size = New System.Drawing.Size(304, 36)
        Me.CB_SERVER.TabIndex = 3
        Me.CB_SERVER.Tag = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(91, 239)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 50)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Autenticación"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.LIQ19_Liquidaciones.My.Resources.Resources.IMG_LoginData
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(36, 304)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(375, 117)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.LIQ19_Liquidaciones.My.Resources.Resources.IMG_Candado
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(129, 108)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 127)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'LA_SYS_NOMBRE
        '
        Me.LA_SYS_NOMBRE.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LA_SYS_NOMBRE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.LA_SYS_NOMBRE.Location = New System.Drawing.Point(1, 11)
        Me.LA_SYS_NOMBRE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LA_SYS_NOMBRE.Name = "LA_SYS_NOMBRE"
        Me.LA_SYS_NOMBRE.Size = New System.Drawing.Size(449, 90)
        Me.LA_SYS_NOMBRE.TabIndex = 8
        Me.LA_SYS_NOMBRE.Text = "AGATA"
        Me.LA_SYS_NOMBRE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FO_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(447, 553)
        Me.Controls.Add(Me.TB_CONTRASENA)
        Me.Controls.Add(Me.TB_Login)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LA_SYS_NOMBRE)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB_SERVER)
        Me.Controls.Add(Me.BT_SALIR)
        Me.Controls.Add(Me.BT_INCIAR_SESION)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FO_Login"
        Me.Text = "SNI"
        Me.TransparencyKey = System.Drawing.Color.Red
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_CONTRASENA As TextBox
    Friend WithEvents TB_Login As TextBox
    Friend WithEvents BT_SALIR As Button
    Friend WithEvents BT_INCIAR_SESION As Button
    Friend WithEvents CB_SERVER As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LA_SYS_NOMBRE As Label
End Class
