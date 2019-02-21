<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FO_ASISTENTE_PRESUPUESTO
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CB_USUARIO_CAMBIO = New System.Windows.Forms.ComboBox()
        Me.CB_USUARIO_ALTA = New System.Windows.Forms.ComboBox()
        Me.GB_FICHA = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_F_ALTA = New System.Windows.Forms.TextBox()
        Me.TB_F_CAMBIO = New System.Windows.Forms.TextBox()
        Me.TB_F_LIQ = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_CIE_CLIENTE = New System.Windows.Forms.TextBox()
        Me.CB_TIPO_MOVIMIENTO_BANCO = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TB_COD_DESCRIPCION = New System.Windows.Forms.TextBox()
        Me.TB_F_OPERACION = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TB_REFERENCIA = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TB_MONTO_MOVIMIENTO = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CB_CUENTA_BANCO = New System.Windows.Forms.ComboBox()
        Me.CB_FORMA_MOVIMIENTO_BANCO = New System.Windows.Forms.ComboBox()
        Me.TB_K_MOVIMIENTO_BANCO = New System.Windows.Forms.TextBox()
        Me.LB_ID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FL_MENU_2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_SALIR = New System.Windows.Forms.Button()
        Me.BT_CANCELAR = New System.Windows.Forms.Button()
        Me.BT_GUARDAR = New System.Windows.Forms.Button()
        Me.BT_LISTADO = New System.Windows.Forms.Button()
        Me.BT_EXPORTAR_EXCEL = New System.Windows.Forms.Button()
        Me.TI_RELOJ = New System.Windows.Forms.Timer(Me.components)
        Me.GB_LISTADO = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.RT_EVENTOS = New System.Windows.Forms.RichTextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_PROG_MASIVO = New System.Windows.Forms.Button()
        Me.CB_MES = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CH_GENERAR_TRASPASOS = New System.Windows.Forms.CheckBox()
        Me.CH_DISTRIBUCION_SEMANAL = New System.Windows.Forms.CheckBox()
        Me.CH_GENERAR_PRESUPUESTO = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.LI_LISTADO = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CH_SELECCIONAR_TODOS = New System.Windows.Forms.CheckBox()
        Me.LB_VERSION = New System.Windows.Forms.Label()
        Me.LB_RELOJ = New System.Windows.Forms.Label()
        Me.GB_CONTROL = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_LI_BUSCAR = New System.Windows.Forms.TextBox()
        Me.FL_MENU_1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.CB_LI_ESCENARIO_PLAN = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LB_RESULTADO = New System.Windows.Forms.TextBox()
        Me.GB_OPERACION = New System.Windows.Forms.GroupBox()
        Me.CB_LI_AÑO = New System.Windows.Forms.ComboBox()
        Me.GB_FILTROS = New System.Windows.Forms.GroupBox()
        Me.CB_LI_RAZON_SOCIAL = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.CB_LI_REGION = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.CB_LI_ZONA_UO = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BT_LI_BUSCAR = New System.Windows.Forms.Button()
        Me.GB_FICHA.SuspendLayout()
        Me.FL_MENU_2.SuspendLayout()
        Me.GB_LISTADO.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GB_CONTROL.SuspendLayout()
        Me.GB_OPERACION.SuspendLayout()
        Me.GB_FILTROS.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Gray
        Me.Label18.Location = New System.Drawing.Point(552, 194)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 13)
        Me.Label18.TabIndex = 168
        Me.Label18.Text = "[dd/mm/aaaa]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(179, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 161
        Me.Label5.Text = "Fecha Alta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(506, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 13)
        Me.Label9.TabIndex = 162
        Me.Label9.Text = "Ultima modificación"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Gray
        Me.Label14.Location = New System.Drawing.Point(444, 194)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 13)
        Me.Label14.TabIndex = 167
        Me.Label14.Text = "[dd/mm/aaaa]"
        '
        'CB_USUARIO_CAMBIO
        '
        Me.CB_USUARIO_CAMBIO.Enabled = False
        Me.CB_USUARIO_CAMBIO.FormattingEnabled = True
        Me.CB_USUARIO_CAMBIO.Location = New System.Drawing.Point(327, 236)
        Me.CB_USUARIO_CAMBIO.Name = "CB_USUARIO_CAMBIO"
        Me.CB_USUARIO_CAMBIO.Size = New System.Drawing.Size(170, 21)
        Me.CB_USUARIO_CAMBIO.TabIndex = 166
        '
        'CB_USUARIO_ALTA
        '
        Me.CB_USUARIO_ALTA.Enabled = False
        Me.CB_USUARIO_ALTA.FormattingEnabled = True
        Me.CB_USUARIO_ALTA.Location = New System.Drawing.Point(20, 236)
        Me.CB_USUARIO_ALTA.Name = "CB_USUARIO_ALTA"
        Me.CB_USUARIO_ALTA.Size = New System.Drawing.Size(150, 21)
        Me.CB_USUARIO_ALTA.TabIndex = 165
        '
        'GB_FICHA
        '
        Me.GB_FICHA.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GB_FICHA.BackColor = System.Drawing.Color.White
        Me.GB_FICHA.Controls.Add(Me.Label18)
        Me.GB_FICHA.Controls.Add(Me.Label14)
        Me.GB_FICHA.Controls.Add(Me.CB_USUARIO_CAMBIO)
        Me.GB_FICHA.Controls.Add(Me.CB_USUARIO_ALTA)
        Me.GB_FICHA.Controls.Add(Me.Label5)
        Me.GB_FICHA.Controls.Add(Me.Label9)
        Me.GB_FICHA.Controls.Add(Me.Label6)
        Me.GB_FICHA.Controls.Add(Me.Label2)
        Me.GB_FICHA.Controls.Add(Me.TB_F_ALTA)
        Me.GB_FICHA.Controls.Add(Me.TB_F_CAMBIO)
        Me.GB_FICHA.Controls.Add(Me.TB_F_LIQ)
        Me.GB_FICHA.Controls.Add(Me.Label8)
        Me.GB_FICHA.Controls.Add(Me.Label4)
        Me.GB_FICHA.Controls.Add(Me.TB_CIE_CLIENTE)
        Me.GB_FICHA.Controls.Add(Me.CB_TIPO_MOVIMIENTO_BANCO)
        Me.GB_FICHA.Controls.Add(Me.Label21)
        Me.GB_FICHA.Controls.Add(Me.Label20)
        Me.GB_FICHA.Controls.Add(Me.TB_COD_DESCRIPCION)
        Me.GB_FICHA.Controls.Add(Me.TB_F_OPERACION)
        Me.GB_FICHA.Controls.Add(Me.Label17)
        Me.GB_FICHA.Controls.Add(Me.TB_REFERENCIA)
        Me.GB_FICHA.Controls.Add(Me.Label16)
        Me.GB_FICHA.Controls.Add(Me.TB_MONTO_MOVIMIENTO)
        Me.GB_FICHA.Controls.Add(Me.Label15)
        Me.GB_FICHA.Controls.Add(Me.CB_CUENTA_BANCO)
        Me.GB_FICHA.Controls.Add(Me.CB_FORMA_MOVIMIENTO_BANCO)
        Me.GB_FICHA.Controls.Add(Me.TB_K_MOVIMIENTO_BANCO)
        Me.GB_FICHA.Controls.Add(Me.LB_ID)
        Me.GB_FICHA.Controls.Add(Me.Label3)
        Me.GB_FICHA.Controls.Add(Me.Label7)
        Me.GB_FICHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FICHA.Location = New System.Drawing.Point(256, 53)
        Me.GB_FICHA.Name = "GB_FICHA"
        Me.GB_FICHA.Size = New System.Drawing.Size(669, 275)
        Me.GB_FICHA.TabIndex = 82
        Me.GB_FICHA.TabStop = False
        Me.GB_FICHA.Text = "Ficha"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(330, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 13)
        Me.Label6.TabIndex = 163
        Me.Label6.Text = "Us Ultima Modificación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "Usuario Alta"
        '
        'TB_F_ALTA
        '
        Me.TB_F_ALTA.Enabled = False
        Me.TB_F_ALTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_F_ALTA.Location = New System.Drawing.Point(176, 235)
        Me.TB_F_ALTA.Name = "TB_F_ALTA"
        Me.TB_F_ALTA.Size = New System.Drawing.Size(145, 22)
        Me.TB_F_ALTA.TabIndex = 159
        '
        'TB_F_CAMBIO
        '
        Me.TB_F_CAMBIO.Enabled = False
        Me.TB_F_CAMBIO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_F_CAMBIO.Location = New System.Drawing.Point(503, 235)
        Me.TB_F_CAMBIO.Name = "TB_F_CAMBIO"
        Me.TB_F_CAMBIO.Size = New System.Drawing.Size(145, 22)
        Me.TB_F_CAMBIO.TabIndex = 160
        '
        'TB_F_LIQ
        '
        Me.TB_F_LIQ.Culture = New System.Globalization.CultureInfo("es-MX")
        Me.TB_F_LIQ.Location = New System.Drawing.Point(548, 171)
        Me.TB_F_LIQ.Mask = "00/00/0000"
        Me.TB_F_LIQ.Name = "TB_F_LIQ"
        Me.TB_F_LIQ.Size = New System.Drawing.Size(100, 20)
        Me.TB_F_LIQ.TabIndex = 150
        Me.TB_F_LIQ.Tag = "1"
        Me.TB_F_LIQ.ValidatingType = GetType(Date)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(551, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "F Liquidación"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "CIE Cliente"
        '
        'TB_CIE_CLIENTE
        '
        Me.TB_CIE_CLIENTE.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CIE_CLIENTE.Location = New System.Drawing.Point(18, 129)
        Me.TB_CIE_CLIENTE.Name = "TB_CIE_CLIENTE"
        Me.TB_CIE_CLIENTE.Size = New System.Drawing.Size(195, 22)
        Me.TB_CIE_CLIENTE.TabIndex = 100
        Me.TB_CIE_CLIENTE.Tag = "1"
        '
        'CB_TIPO_MOVIMIENTO_BANCO
        '
        Me.CB_TIPO_MOVIMIENTO_BANCO.FormattingEnabled = True
        Me.CB_TIPO_MOVIMIENTO_BANCO.Location = New System.Drawing.Point(219, 130)
        Me.CB_TIPO_MOVIMIENTO_BANCO.Name = "CB_TIPO_MOVIMIENTO_BANCO"
        Me.CB_TIPO_MOVIMIENTO_BANCO.Size = New System.Drawing.Size(223, 21)
        Me.CB_TIPO_MOVIMIENTO_BANCO.TabIndex = 110
        Me.CB_TIPO_MOVIMIENTO_BANCO.Tag = "1"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(222, 114)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 13)
        Me.Label21.TabIndex = 48
        Me.Label21.Text = "Tipo"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(21, 67)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 13)
        Me.Label20.TabIndex = 47
        Me.Label20.Text = "Descripción"
        '
        'TB_COD_DESCRIPCION
        '
        Me.TB_COD_DESCRIPCION.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_COD_DESCRIPCION.Location = New System.Drawing.Point(18, 83)
        Me.TB_COD_DESCRIPCION.Name = "TB_COD_DESCRIPCION"
        Me.TB_COD_DESCRIPCION.Size = New System.Drawing.Size(630, 22)
        Me.TB_COD_DESCRIPCION.TabIndex = 80
        '
        'TB_F_OPERACION
        '
        Me.TB_F_OPERACION.Culture = New System.Globalization.CultureInfo("es-MX")
        Me.TB_F_OPERACION.Location = New System.Drawing.Point(442, 171)
        Me.TB_F_OPERACION.Mask = "00/00/0000"
        Me.TB_F_OPERACION.Name = "TB_F_OPERACION"
        Me.TB_F_OPERACION.Size = New System.Drawing.Size(100, 20)
        Me.TB_F_OPERACION.TabIndex = 140
        Me.TB_F_OPERACION.Tag = "1"
        Me.TB_F_OPERACION.ValidatingType = GetType(Date)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(410, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 13)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Referencia"
        '
        'TB_REFERENCIA
        '
        Me.TB_REFERENCIA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_REFERENCIA.Location = New System.Drawing.Point(407, 41)
        Me.TB_REFERENCIA.Name = "TB_REFERENCIA"
        Me.TB_REFERENCIA.Size = New System.Drawing.Size(241, 22)
        Me.TB_REFERENCIA.TabIndex = 90
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(180, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 13)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "Monto Movimiento"
        '
        'TB_MONTO_MOVIMIENTO
        '
        Me.TB_MONTO_MOVIMIENTO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_MONTO_MOVIMIENTO.Location = New System.Drawing.Point(177, 41)
        Me.TB_MONTO_MOVIMIENTO.Name = "TB_MONTO_MOVIMIENTO"
        Me.TB_MONTO_MOVIMIENTO.Size = New System.Drawing.Size(224, 22)
        Me.TB_MONTO_MOVIMIENTO.TabIndex = 70
        Me.TB_MONTO_MOVIMIENTO.Tag = "1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(445, 155)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 13)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "F Operación"
        '
        'CB_CUENTA_BANCO
        '
        Me.CB_CUENTA_BANCO.FormattingEnabled = True
        Me.CB_CUENTA_BANCO.Location = New System.Drawing.Point(18, 171)
        Me.CB_CUENTA_BANCO.Name = "CB_CUENTA_BANCO"
        Me.CB_CUENTA_BANCO.Size = New System.Drawing.Size(418, 21)
        Me.CB_CUENTA_BANCO.TabIndex = 130
        Me.CB_CUENTA_BANCO.Tag = "1"
        '
        'CB_FORMA_MOVIMIENTO_BANCO
        '
        Me.CB_FORMA_MOVIMIENTO_BANCO.FormattingEnabled = True
        Me.CB_FORMA_MOVIMIENTO_BANCO.Location = New System.Drawing.Point(448, 130)
        Me.CB_FORMA_MOVIMIENTO_BANCO.Name = "CB_FORMA_MOVIMIENTO_BANCO"
        Me.CB_FORMA_MOVIMIENTO_BANCO.Size = New System.Drawing.Size(200, 21)
        Me.CB_FORMA_MOVIMIENTO_BANCO.TabIndex = 120
        Me.CB_FORMA_MOVIMIENTO_BANCO.Tag = "1"
        '
        'TB_K_MOVIMIENTO_BANCO
        '
        Me.TB_K_MOVIMIENTO_BANCO.Enabled = False
        Me.TB_K_MOVIMIENTO_BANCO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_K_MOVIMIENTO_BANCO.Location = New System.Drawing.Point(18, 41)
        Me.TB_K_MOVIMIENTO_BANCO.Name = "TB_K_MOVIMIENTO_BANCO"
        Me.TB_K_MOVIMIENTO_BANCO.Size = New System.Drawing.Size(152, 22)
        Me.TB_K_MOVIMIENTO_BANCO.TabIndex = 21
        '
        'LB_ID
        '
        Me.LB_ID.AutoSize = True
        Me.LB_ID.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ID.Location = New System.Drawing.Point(21, 25)
        Me.LB_ID.Name = "LB_ID"
        Me.LB_ID.Size = New System.Drawing.Size(18, 13)
        Me.LB_ID.TabIndex = 19
        Me.LB_ID.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(451, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Forma"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Cuenta Banco"
        '
        'FL_MENU_2
        '
        Me.FL_MENU_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FL_MENU_2.BackColor = System.Drawing.Color.White
        Me.FL_MENU_2.Controls.Add(Me.BT_SALIR)
        Me.FL_MENU_2.Controls.Add(Me.BT_CANCELAR)
        Me.FL_MENU_2.Controls.Add(Me.BT_GUARDAR)
        Me.FL_MENU_2.Controls.Add(Me.BT_LISTADO)
        Me.FL_MENU_2.Controls.Add(Me.BT_EXPORTAR_EXCEL)
        Me.FL_MENU_2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FL_MENU_2.Location = New System.Drawing.Point(790, 8)
        Me.FL_MENU_2.Name = "FL_MENU_2"
        Me.FL_MENU_2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FL_MENU_2.Size = New System.Drawing.Size(379, 40)
        Me.FL_MENU_2.TabIndex = 88
        '
        'BT_SALIR
        '
        Me.BT_SALIR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BT_SALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_SALIR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_SALIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_SALIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_SALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_SALIR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_exit
        Me.BT_SALIR.Location = New System.Drawing.Point(309, 6)
        Me.BT_SALIR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_SALIR.Name = "BT_SALIR"
        Me.BT_SALIR.Size = New System.Drawing.Size(70, 31)
        Me.BT_SALIR.TabIndex = 23
        Me.BT_SALIR.UseVisualStyleBackColor = True
        '
        'BT_CANCELAR
        '
        Me.BT_CANCELAR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BT_CANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_CANCELAR.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BT_CANCELAR.Enabled = False
        Me.BT_CANCELAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_CANCELAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_CANCELAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_CANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_CANCELAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_cancel
        Me.BT_CANCELAR.Location = New System.Drawing.Point(239, 6)
        Me.BT_CANCELAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_CANCELAR.Name = "BT_CANCELAR"
        Me.BT_CANCELAR.Size = New System.Drawing.Size(70, 31)
        Me.BT_CANCELAR.TabIndex = 23
        Me.BT_CANCELAR.UseVisualStyleBackColor = True
        Me.BT_CANCELAR.Visible = False
        '
        'BT_GUARDAR
        '
        Me.BT_GUARDAR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BT_GUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_GUARDAR.Enabled = False
        Me.BT_GUARDAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_GUARDAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_GUARDAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_GUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_GUARDAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_accept
        Me.BT_GUARDAR.Location = New System.Drawing.Point(169, 6)
        Me.BT_GUARDAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_GUARDAR.Name = "BT_GUARDAR"
        Me.BT_GUARDAR.Size = New System.Drawing.Size(70, 31)
        Me.BT_GUARDAR.TabIndex = 23
        Me.BT_GUARDAR.UseVisualStyleBackColor = True
        Me.BT_GUARDAR.Visible = False
        '
        'BT_LISTADO
        '
        Me.BT_LISTADO.BackColor = System.Drawing.Color.White
        Me.BT_LISTADO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_LISTADO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_LISTADO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_LISTADO.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.listado
        Me.BT_LISTADO.Location = New System.Drawing.Point(96, 6)
        Me.BT_LISTADO.Name = "BT_LISTADO"
        Me.BT_LISTADO.Size = New System.Drawing.Size(70, 31)
        Me.BT_LISTADO.TabIndex = 25
        Me.BT_LISTADO.UseVisualStyleBackColor = False
        Me.BT_LISTADO.Visible = False
        '
        'BT_EXPORTAR_EXCEL
        '
        Me.BT_EXPORTAR_EXCEL.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_EXPORTAR_EXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_EXPORTAR_EXCEL.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_export
        Me.BT_EXPORTAR_EXCEL.Location = New System.Drawing.Point(20, 6)
        Me.BT_EXPORTAR_EXCEL.Name = "BT_EXPORTAR_EXCEL"
        Me.BT_EXPORTAR_EXCEL.Size = New System.Drawing.Size(70, 31)
        Me.BT_EXPORTAR_EXCEL.TabIndex = 28
        Me.BT_EXPORTAR_EXCEL.Tag = "Copiar al portapapeles"
        Me.BT_EXPORTAR_EXCEL.UseVisualStyleBackColor = True
        '
        'TI_RELOJ
        '
        '
        'GB_LISTADO
        '
        Me.GB_LISTADO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_LISTADO.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GB_LISTADO.BackColor = System.Drawing.Color.White
        Me.GB_LISTADO.Controls.Add(Me.TableLayoutPanel1)
        Me.GB_LISTADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_LISTADO.Location = New System.Drawing.Point(10, 118)
        Me.GB_LISTADO.Name = "GB_LISTADO"
        Me.GB_LISTADO.Size = New System.Drawing.Size(1160, 317)
        Me.GB_LISTADO.TabIndex = 84
        Me.GB_LISTADO.TabStop = False
        Me.GB_LISTADO.Text = "Listado"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1154, 298)
        Me.TableLayoutPanel1.TabIndex = 66
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.RT_EVENTOS, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(464, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(687, 292)
        Me.TableLayoutPanel2.TabIndex = 66
        '
        'RT_EVENTOS
        '
        Me.RT_EVENTOS.BackColor = System.Drawing.Color.LightYellow
        Me.RT_EVENTOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RT_EVENTOS.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RT_EVENTOS.Location = New System.Drawing.Point(3, 43)
        Me.RT_EVENTOS.Name = "RT_EVENTOS"
        Me.RT_EVENTOS.Size = New System.Drawing.Size(681, 246)
        Me.RT_EVENTOS.TabIndex = 48
        Me.RT_EVENTOS.Text = ""
        Me.RT_EVENTOS.WordWrap = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.BT_PROG_MASIVO)
        Me.FlowLayoutPanel1.Controls.Add(Me.CB_MES)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label22)
        Me.FlowLayoutPanel1.Controls.Add(Me.CH_GENERAR_TRASPASOS)
        Me.FlowLayoutPanel1.Controls.Add(Me.CH_DISTRIBUCION_SEMANAL)
        Me.FlowLayoutPanel1.Controls.Add(Me.CH_GENERAR_PRESUPUESTO)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(681, 34)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'BT_PROG_MASIVO
        '
        Me.BT_PROG_MASIVO.FlatAppearance.BorderSize = 0
        Me.BT_PROG_MASIVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_PROG_MASIVO.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.procesar_opt
        Me.BT_PROG_MASIVO.Location = New System.Drawing.Point(618, 0)
        Me.BT_PROG_MASIVO.Margin = New System.Windows.Forms.Padding(10, 0, 3, 0)
        Me.BT_PROG_MASIVO.Name = "BT_PROG_MASIVO"
        Me.BT_PROG_MASIVO.Size = New System.Drawing.Size(60, 37)
        Me.BT_PROG_MASIVO.TabIndex = 63
        Me.BT_PROG_MASIVO.Tag = "Procesar"
        Me.BT_PROG_MASIVO.UseVisualStyleBackColor = True
        '
        'CB_MES
        '
        Me.CB_MES.FormattingEnabled = True
        Me.CB_MES.Location = New System.Drawing.Point(509, 5)
        Me.CB_MES.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.CB_MES.Name = "CB_MES"
        Me.CB_MES.Size = New System.Drawing.Size(96, 21)
        Me.CB_MES.TabIndex = 65
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(475, 10)
        Me.Label22.Margin = New System.Windows.Forms.Padding(20, 10, 3, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(28, 13)
        Me.Label22.TabIndex = 64
        Me.Label22.Text = "Mes"
        '
        'CH_GENERAR_TRASPASOS
        '
        Me.CH_GENERAR_TRASPASOS.AutoSize = True
        Me.CH_GENERAR_TRASPASOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CH_GENERAR_TRASPASOS.Location = New System.Drawing.Point(323, 8)
        Me.CH_GENERAR_TRASPASOS.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.CH_GENERAR_TRASPASOS.Name = "CH_GENERAR_TRASPASOS"
        Me.CH_GENERAR_TRASPASOS.Size = New System.Drawing.Size(129, 17)
        Me.CH_GENERAR_TRASPASOS.TabIndex = 68
        Me.CH_GENERAR_TRASPASOS.Text = "C) Generar Traspasos"
        Me.CH_GENERAR_TRASPASOS.UseVisualStyleBackColor = True
        '
        'CH_DISTRIBUCION_SEMANAL
        '
        Me.CH_DISTRIBUCION_SEMANAL.AutoSize = True
        Me.CH_DISTRIBUCION_SEMANAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CH_DISTRIBUCION_SEMANAL.Location = New System.Drawing.Point(165, 8)
        Me.CH_DISTRIBUCION_SEMANAL.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.CH_DISTRIBUCION_SEMANAL.Name = "CH_DISTRIBUCION_SEMANAL"
        Me.CH_DISTRIBUCION_SEMANAL.Size = New System.Drawing.Size(152, 17)
        Me.CH_DISTRIBUCION_SEMANAL.TabIndex = 66
        Me.CH_DISTRIBUCION_SEMANAL.Text = "B) Distribuir Semanalmente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.CH_DISTRIBUCION_SEMANAL.UseVisualStyleBackColor = True
        '
        'CH_GENERAR_PRESUPUESTO
        '
        Me.CH_GENERAR_PRESUPUESTO.AutoSize = True
        Me.CH_GENERAR_PRESUPUESTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CH_GENERAR_PRESUPUESTO.Location = New System.Drawing.Point(20, 8)
        Me.CH_GENERAR_PRESUPUESTO.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.CH_GENERAR_PRESUPUESTO.Name = "CH_GENERAR_PRESUPUESTO"
        Me.CH_GENERAR_PRESUPUESTO.Size = New System.Drawing.Size(139, 17)
        Me.CH_GENERAR_PRESUPUESTO.TabIndex = 67
        Me.CH_GENERAR_PRESUPUESTO.Text = "A) Generar Presupuesto"
        Me.CH_GENERAR_PRESUPUESTO.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.LI_LISTADO, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(455, 292)
        Me.TableLayoutPanel3.TabIndex = 67
        '
        'LI_LISTADO
        '
        Me.LI_LISTADO.AllowUserToAddRows = False
        Me.LI_LISTADO.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LI_LISTADO.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.LI_LISTADO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LI_LISTADO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LI_LISTADO.Location = New System.Drawing.Point(0, 40)
        Me.LI_LISTADO.Margin = New System.Windows.Forms.Padding(0)
        Me.LI_LISTADO.Name = "LI_LISTADO"
        Me.LI_LISTADO.Size = New System.Drawing.Size(455, 252)
        Me.LI_LISTADO.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CH_SELECCIONAR_TODOS)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(449, 34)
        Me.Panel1.TabIndex = 4
        '
        'CH_SELECCIONAR_TODOS
        '
        Me.CH_SELECCIONAR_TODOS.AutoSize = True
        Me.CH_SELECCIONAR_TODOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CH_SELECCIONAR_TODOS.Location = New System.Drawing.Point(5, 10)
        Me.CH_SELECCIONAR_TODOS.Name = "CH_SELECCIONAR_TODOS"
        Me.CH_SELECCIONAR_TODOS.Size = New System.Drawing.Size(111, 17)
        Me.CH_SELECCIONAR_TODOS.TabIndex = 0
        Me.CH_SELECCIONAR_TODOS.Text = "Seleccionar todos"
        Me.CH_SELECCIONAR_TODOS.UseVisualStyleBackColor = True
        '
        'LB_VERSION
        '
        Me.LB_VERSION.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LB_VERSION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_VERSION.Location = New System.Drawing.Point(6, 34)
        Me.LB_VERSION.Name = "LB_VERSION"
        Me.LB_VERSION.Size = New System.Drawing.Size(162, 13)
        Me.LB_VERSION.TabIndex = 1
        Me.LB_VERSION.Text = "Label10"
        Me.LB_VERSION.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LB_RELOJ
        '
        Me.LB_RELOJ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_RELOJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_RELOJ.Location = New System.Drawing.Point(244, 34)
        Me.LB_RELOJ.Name = "LB_RELOJ"
        Me.LB_RELOJ.Size = New System.Drawing.Size(177, 13)
        Me.LB_RELOJ.TabIndex = 0
        Me.LB_RELOJ.Text = "Label9"
        Me.LB_RELOJ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GB_CONTROL
        '
        Me.GB_CONTROL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_CONTROL.BackColor = System.Drawing.Color.White
        Me.GB_CONTROL.Controls.Add(Me.LB_VERSION)
        Me.GB_CONTROL.Controls.Add(Me.LB_RELOJ)
        Me.GB_CONTROL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_CONTROL.Location = New System.Drawing.Point(742, 434)
        Me.GB_CONTROL.Name = "GB_CONTROL"
        Me.GB_CONTROL.Size = New System.Drawing.Size(428, 52)
        Me.GB_CONTROL.TabIndex = 86
        Me.GB_CONTROL.TabStop = False
        Me.GB_CONTROL.Text = "Control"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Buscar"
        '
        'TB_LI_BUSCAR
        '
        Me.TB_LI_BUSCAR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LI_BUSCAR.Location = New System.Drawing.Point(6, 29)
        Me.TB_LI_BUSCAR.Name = "TB_LI_BUSCAR"
        Me.TB_LI_BUSCAR.Size = New System.Drawing.Size(150, 22)
        Me.TB_LI_BUSCAR.TabIndex = 10
        '
        'FL_MENU_1
        '
        Me.FL_MENU_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FL_MENU_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FL_MENU_1.BackColor = System.Drawing.Color.White
        Me.FL_MENU_1.Location = New System.Drawing.Point(11, 8)
        Me.FL_MENU_1.Name = "FL_MENU_1"
        Me.FL_MENU_1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FL_MENU_1.Size = New System.Drawing.Size(934, 40)
        Me.FL_MENU_1.TabIndex = 87
        '
        'CB_LI_ESCENARIO_PLAN
        '
        Me.CB_LI_ESCENARIO_PLAN.FormattingEnabled = True
        Me.CB_LI_ESCENARIO_PLAN.Location = New System.Drawing.Point(725, 30)
        Me.CB_LI_ESCENARIO_PLAN.Name = "CB_LI_ESCENARIO_PLAN"
        Me.CB_LI_ESCENARIO_PLAN.Size = New System.Drawing.Size(102, 21)
        Me.CB_LI_ESCENARIO_PLAN.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(728, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Escenario Plan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(619, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Año"
        '
        'LB_RESULTADO
        '
        Me.LB_RESULTADO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_RESULTADO.BackColor = System.Drawing.Color.White
        Me.LB_RESULTADO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LB_RESULTADO.Enabled = False
        Me.LB_RESULTADO.Font = New System.Drawing.Font("Courier New", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_RESULTADO.Location = New System.Drawing.Point(7, 16)
        Me.LB_RESULTADO.Multiline = True
        Me.LB_RESULTADO.Name = "LB_RESULTADO"
        Me.LB_RESULTADO.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.LB_RESULTADO.Size = New System.Drawing.Size(711, 30)
        Me.LB_RESULTADO.TabIndex = 7
        '
        'GB_OPERACION
        '
        Me.GB_OPERACION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_OPERACION.BackColor = System.Drawing.Color.White
        Me.GB_OPERACION.Controls.Add(Me.LB_RESULTADO)
        Me.GB_OPERACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_OPERACION.Location = New System.Drawing.Point(11, 434)
        Me.GB_OPERACION.Name = "GB_OPERACION"
        Me.GB_OPERACION.Size = New System.Drawing.Size(724, 52)
        Me.GB_OPERACION.TabIndex = 85
        Me.GB_OPERACION.TabStop = False
        Me.GB_OPERACION.Text = "Operación"
        '
        'CB_LI_AÑO
        '
        Me.CB_LI_AÑO.FormattingEnabled = True
        Me.CB_LI_AÑO.Location = New System.Drawing.Point(616, 30)
        Me.CB_LI_AÑO.Name = "CB_LI_AÑO"
        Me.CB_LI_AÑO.Size = New System.Drawing.Size(103, 21)
        Me.CB_LI_AÑO.TabIndex = 30
        '
        'GB_FILTROS
        '
        Me.GB_FILTROS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_FILTROS.BackColor = System.Drawing.Color.White
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_RAZON_SOCIAL)
        Me.GB_FILTROS.Controls.Add(Me.Label25)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_REGION)
        Me.GB_FILTROS.Controls.Add(Me.Label24)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_ZONA_UO)
        Me.GB_FILTROS.Controls.Add(Me.Label19)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_ESCENARIO_PLAN)
        Me.GB_FILTROS.Controls.Add(Me.Label11)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_AÑO)
        Me.GB_FILTROS.Controls.Add(Me.BT_LI_BUSCAR)
        Me.GB_FILTROS.Controls.Add(Me.Label13)
        Me.GB_FILTROS.Controls.Add(Me.Label1)
        Me.GB_FILTROS.Controls.Add(Me.TB_LI_BUSCAR)
        Me.GB_FILTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FILTROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_FILTROS.Location = New System.Drawing.Point(11, 51)
        Me.GB_FILTROS.Name = "GB_FILTROS"
        Me.GB_FILTROS.Size = New System.Drawing.Size(1159, 65)
        Me.GB_FILTROS.TabIndex = 83
        Me.GB_FILTROS.TabStop = False
        Me.GB_FILTROS.Text = "Filtros"
        '
        'CB_LI_RAZON_SOCIAL
        '
        Me.CB_LI_RAZON_SOCIAL.FormattingEnabled = True
        Me.CB_LI_RAZON_SOCIAL.Location = New System.Drawing.Point(430, 30)
        Me.CB_LI_RAZON_SOCIAL.Name = "CB_LI_RAZON_SOCIAL"
        Me.CB_LI_RAZON_SOCIAL.Size = New System.Drawing.Size(180, 21)
        Me.CB_LI_RAZON_SOCIAL.TabIndex = 65
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(433, 15)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 13)
        Me.Label25.TabIndex = 64
        Me.Label25.Text = "Razón Social"
        '
        'CB_LI_REGION
        '
        Me.CB_LI_REGION.FormattingEnabled = True
        Me.CB_LI_REGION.Location = New System.Drawing.Point(281, 30)
        Me.CB_LI_REGION.Name = "CB_LI_REGION"
        Me.CB_LI_REGION.Size = New System.Drawing.Size(144, 21)
        Me.CB_LI_REGION.TabIndex = 63
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(285, 15)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(44, 13)
        Me.Label24.TabIndex = 62
        Me.Label24.Text = "Región"
        '
        'CB_LI_ZONA_UO
        '
        Me.CB_LI_ZONA_UO.FormattingEnabled = True
        Me.CB_LI_ZONA_UO.Location = New System.Drawing.Point(162, 30)
        Me.CB_LI_ZONA_UO.Name = "CB_LI_ZONA_UO"
        Me.CB_LI_ZONA_UO.Size = New System.Drawing.Size(113, 21)
        Me.CB_LI_ZONA_UO.TabIndex = 61
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(166, 15)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(33, 13)
        Me.Label19.TabIndex = 60
        Me.Label19.Text = "Zona"
        '
        'BT_LI_BUSCAR
        '
        Me.BT_LI_BUSCAR.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BT_LI_BUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_LI_BUSCAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_LI_BUSCAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_LI_BUSCAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_LI_BUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_LI_BUSCAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_search
        Me.BT_LI_BUSCAR.Location = New System.Drawing.Point(1086, 25)
        Me.BT_LI_BUSCAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_LI_BUSCAR.Name = "BT_LI_BUSCAR"
        Me.BT_LI_BUSCAR.Size = New System.Drawing.Size(70, 33)
        Me.BT_LI_BUSCAR.TabIndex = 3
        Me.BT_LI_BUSCAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_LI_BUSCAR.UseVisualStyleBackColor = True
        '
        'FO_ASISTENTE_PRESUPUESTO
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1181, 493)
        Me.Controls.Add(Me.FL_MENU_2)
        Me.Controls.Add(Me.FL_MENU_1)
        Me.Controls.Add(Me.GB_LISTADO)
        Me.Controls.Add(Me.GB_CONTROL)
        Me.Controls.Add(Me.GB_OPERACION)
        Me.Controls.Add(Me.GB_FILTROS)
        Me.Controls.Add(Me.GB_FICHA)
        Me.Name = "FO_ASISTENTE_PRESUPUESTO"
        Me.Text = "FO_PRESUPUESTO_MASIVO"
        Me.GB_FICHA.ResumeLayout(False)
        Me.GB_FICHA.PerformLayout()
        Me.FL_MENU_2.ResumeLayout(False)
        Me.GB_LISTADO.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GB_CONTROL.ResumeLayout(False)
        Me.GB_OPERACION.ResumeLayout(False)
        Me.GB_OPERACION.PerformLayout()
        Me.GB_FILTROS.ResumeLayout(False)
        Me.GB_FILTROS.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label18 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Public WithEvents CB_USUARIO_CAMBIO As ComboBox
    Public WithEvents CB_USUARIO_ALTA As ComboBox
    Public WithEvents GB_FICHA As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents TB_F_ALTA As TextBox
    Public WithEvents TB_F_CAMBIO As TextBox
    Friend WithEvents TB_F_LIQ As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Public WithEvents TB_CIE_CLIENTE As TextBox
    Public WithEvents CB_TIPO_MOVIMIENTO_BANCO As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Public WithEvents TB_COD_DESCRIPCION As TextBox
    Friend WithEvents TB_F_OPERACION As MaskedTextBox
    Friend WithEvents Label17 As Label
    Public WithEvents TB_REFERENCIA As TextBox
    Friend WithEvents Label16 As Label
    Public WithEvents TB_MONTO_MOVIMIENTO As TextBox
    Friend WithEvents Label15 As Label
    Public WithEvents CB_CUENTA_BANCO As ComboBox
    Public WithEvents CB_FORMA_MOVIMIENTO_BANCO As ComboBox
    Public WithEvents TB_K_MOVIMIENTO_BANCO As TextBox
    Friend WithEvents LB_ID As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Public WithEvents BT_SALIR As Button
    Public WithEvents BT_CANCELAR As Button
    Public WithEvents BT_GUARDAR As Button
    Public WithEvents BT_EXPORTAR_EXCEL As Button
    Public WithEvents FL_MENU_2 As FlowLayoutPanel
    Public WithEvents BT_LISTADO As Button
    Public WithEvents TI_RELOJ As Timer
    Public WithEvents GB_LISTADO As GroupBox
    Public WithEvents LB_VERSION As Label
    Public WithEvents LB_RELOJ As Label
    Public WithEvents GB_CONTROL As GroupBox
    Friend WithEvents Label1 As Label
    Public WithEvents TB_LI_BUSCAR As TextBox
    Public WithEvents FL_MENU_1 As FlowLayoutPanel
    Public WithEvents CB_LI_ESCENARIO_PLAN As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Public WithEvents LB_RESULTADO As TextBox
    Public WithEvents GB_OPERACION As GroupBox
    Public WithEvents CB_LI_AÑO As ComboBox
    Public WithEvents BT_LI_BUSCAR As Button
    Public WithEvents GB_FILTROS As GroupBox
    Public WithEvents CB_LI_RAZON_SOCIAL As ComboBox
    Friend WithEvents Label25 As Label
    Public WithEvents CB_LI_REGION As ComboBox
    Friend WithEvents Label24 As Label
    Public WithEvents CB_LI_ZONA_UO As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label22 As Label
    Public WithEvents CB_MES As ComboBox
    Public WithEvents BT_PROG_MASIVO As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Public WithEvents RT_EVENTOS As RichTextBox
    Friend WithEvents CH_DISTRIBUCION_SEMANAL As CheckBox
    Friend WithEvents CH_GENERAR_PRESUPUESTO As CheckBox
    Friend WithEvents CH_GENERAR_TRASPASOS As CheckBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Public WithEvents LI_LISTADO As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CH_SELECCIONAR_TODOS As CheckBox
End Class
