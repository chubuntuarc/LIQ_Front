<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FO_BOARD2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FO_BOARD2))
        Me.PL_PANEL = New System.Windows.Forms.Panel()
        Me.TC_MAIN_TABCONTROL = New PYF18_Finanzas.TabControlEx()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LB_LOGIN = New System.Windows.Forms.Label()
        Me.LB_USUARIO = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PB_LOGO = New System.Windows.Forms.PictureBox()
        Me.TI_TIMER = New System.Windows.Forms.Timer(Me.components)
        Me.PL_PANEL.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PL_PANEL
        '
        Me.PL_PANEL.AutoScroll = True
        Me.PL_PANEL.AutoSize = True
        Me.PL_PANEL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PL_PANEL.BackColor = System.Drawing.Color.Gainsboro
        Me.PL_PANEL.Controls.Add(Me.TC_MAIN_TABCONTROL)
        Me.PL_PANEL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PL_PANEL.Location = New System.Drawing.Point(4, 55)
        Me.PL_PANEL.Name = "PL_PANEL"
        Me.PL_PANEL.Size = New System.Drawing.Size(1339, 598)
        Me.PL_PANEL.TabIndex = 55
        '
        'TC_MAIN_TABCONTROL
        '
        Me.TC_MAIN_TABCONTROL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TC_MAIN_TABCONTROL.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TC_MAIN_TABCONTROL.Location = New System.Drawing.Point(0, 0)
        Me.TC_MAIN_TABCONTROL.Name = "TC_MAIN_TABCONTROL"
        Me.TC_MAIN_TABCONTROL.SelectedIndex = 0
        Me.TC_MAIN_TABCONTROL.Size = New System.Drawing.Size(1339, 598)
        Me.TC_MAIN_TABCONTROL.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PL_PANEL, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1347, 657)
        Me.TableLayoutPanel1.TabIndex = 57
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.LB_LOGIN)
        Me.Panel1.Controls.Add(Me.LB_USUARIO)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PB_LOGO)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1345, 50)
        Me.Panel1.TabIndex = 56
        '
        'LB_LOGIN
        '
        Me.LB_LOGIN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_LOGIN.AutoSize = True
        Me.LB_LOGIN.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_LOGIN.ForeColor = System.Drawing.Color.DimGray
        Me.LB_LOGIN.Location = New System.Drawing.Point(1209, 32)
        Me.LB_LOGIN.Name = "LB_LOGIN"
        Me.LB_LOGIN.Size = New System.Drawing.Size(71, 17)
        Me.LB_LOGIN.TabIndex = 6
        Me.LB_LOGIN.Text = "@ Log Out"
        '
        'LB_USUARIO
        '
        Me.LB_USUARIO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_USUARIO.BackColor = System.Drawing.Color.Transparent
        Me.LB_USUARIO.Font = New System.Drawing.Font("Leelawadee UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_USUARIO.ForeColor = System.Drawing.Color.DimGray
        Me.LB_USUARIO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LB_USUARIO.Location = New System.Drawing.Point(1096, 3)
        Me.LB_USUARIO.Name = "LB_USUARIO"
        Me.LB_USUARIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LB_USUARIO.Size = New System.Drawing.Size(191, 20)
        Me.LB_USUARIO.TabIndex = 2
        Me.LB_USUARIO.Text = "Hola >>>>>>>>>>>"
        Me.LB_USUARIO.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(75, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 45)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Main"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.PYF18_Finanzas.My.Resources.Resources.HOMEISSAC
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(71, 45)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PB_LOGO
        '
        Me.PB_LOGO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PB_LOGO.BackgroundImage = Global.PYF18_Finanzas.My.Resources.Resources.logo_transparente
        Me.PB_LOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PB_LOGO.Location = New System.Drawing.Point(1289, 3)
        Me.PB_LOGO.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.PB_LOGO.Name = "PB_LOGO"
        Me.PB_LOGO.Size = New System.Drawing.Size(49, 48)
        Me.PB_LOGO.TabIndex = 0
        Me.PB_LOGO.TabStop = False
        '
        'TI_TIMER
        '
        Me.TI_TIMER.Interval = 1000
        '
        'FO_BOARD2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1347, 657)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FO_BOARD2"
        Me.Text = " I S A A C"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PL_PANEL.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PB_LOGO As PictureBox
    Friend WithEvents LB_USUARIO As Label
    Public WithEvents PL_PANEL As Panel
    Public WithEvents TI_TIMER As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LB_LOGIN As Label
    Friend WithEvents TC_MAIN_TABCONTROL As TabControlEx
End Class
