<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FO_PLAN_PRESUPUESTO
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CH_VER_AUTORIZADO = New System.Windows.Forms.CheckBox()
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
        Me.LI_LISTADO = New System.Windows.Forms.DataGridView()
        Me.GB_LISTADO = New System.Windows.Forms.GroupBox()
        Me.BT_GENERAR_UNIDAD_OPERATIVA = New System.Windows.Forms.Button()
        Me.BT_GENERAR_RAZON_SOCIAL = New System.Windows.Forms.Button()
        Me.BT_GENERAR_ZONA_UO = New System.Windows.Forms.Button()
        Me.LB_VERSION = New System.Windows.Forms.Label()
        Me.LB_RELOJ = New System.Windows.Forms.Label()
        Me.GB_CONTROL = New System.Windows.Forms.GroupBox()
        Me.CH_VER_REVISADO = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_LI_BUSCAR = New System.Windows.Forms.TextBox()
        Me.FL_MENU_1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.CH_VER_PREVIO = New System.Windows.Forms.CheckBox()
        Me.CB_LI_ESTATUS_PLAN_PRESUPUESTO = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CB_LI_TEMPORADA = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CB_LI_UNIDAD_OPERATIVA = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LB_RESULTADO = New System.Windows.Forms.TextBox()
        Me.GB_OPERACION = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CB_LI_AÑO = New System.Windows.Forms.ComboBox()
        Me.GB_FILTROS = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.CB_LI_NIVEL_RUBRO_PRESUPUESTO = New System.Windows.Forms.ComboBox()
        Me.CH_EX_ETIQUETAS = New System.Windows.Forms.CheckBox()
        Me.CH_EX_CEROS = New System.Windows.Forms.CheckBox()
        Me.CB_LI_RAZON_SOCIAL = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.CB_LI_ZONA_UO = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BT_LI_BUSCAR = New System.Windows.Forms.Button()
        Me.BT_PLAN_PRESUPUESTO_AUTORIZAR = New System.Windows.Forms.Button()
        Me.GB_FICHA.SuspendLayout()
        Me.FL_MENU_2.SuspendLayout()
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_LISTADO.SuspendLayout()
        Me.GB_CONTROL.SuspendLayout()
        Me.FL_MENU_1.SuspendLayout()
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
        'CH_VER_AUTORIZADO
        '
        Me.CH_VER_AUTORIZADO.AutoSize = True
        Me.CH_VER_AUTORIZADO.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CH_VER_AUTORIZADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CH_VER_AUTORIZADO.Location = New System.Drawing.Point(929, 63)
        Me.CH_VER_AUTORIZADO.Name = "CH_VER_AUTORIZADO"
        Me.CH_VER_AUTORIZADO.Size = New System.Drawing.Size(80, 31)
        Me.CH_VER_AUTORIZADO.TabIndex = 230
        Me.CH_VER_AUTORIZADO.Text = "Ver Autorizado"
        Me.CH_VER_AUTORIZADO.UseVisualStyleBackColor = True
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
        Me.FL_MENU_2.Location = New System.Drawing.Point(742, 8)
        Me.FL_MENU_2.Name = "FL_MENU_2"
        Me.FL_MENU_2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FL_MENU_2.Size = New System.Drawing.Size(427, 40)
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
        Me.BT_SALIR.Location = New System.Drawing.Point(357, 3)
        Me.BT_SALIR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_SALIR.Name = "BT_SALIR"
        Me.BT_SALIR.Size = New System.Drawing.Size(70, 34)
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
        Me.BT_CANCELAR.Location = New System.Drawing.Point(287, 3)
        Me.BT_CANCELAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_CANCELAR.Name = "BT_CANCELAR"
        Me.BT_CANCELAR.Size = New System.Drawing.Size(70, 34)
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
        Me.BT_GUARDAR.Location = New System.Drawing.Point(217, 3)
        Me.BT_GUARDAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_GUARDAR.Name = "BT_GUARDAR"
        Me.BT_GUARDAR.Size = New System.Drawing.Size(70, 34)
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
        Me.BT_LISTADO.Location = New System.Drawing.Point(147, 3)
        Me.BT_LISTADO.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_LISTADO.Name = "BT_LISTADO"
        Me.BT_LISTADO.Size = New System.Drawing.Size(70, 34)
        Me.BT_LISTADO.TabIndex = 25
        Me.BT_LISTADO.UseVisualStyleBackColor = False
        Me.BT_LISTADO.Visible = False
        '
        'BT_EXPORTAR_EXCEL
        '
        Me.BT_EXPORTAR_EXCEL.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_EXPORTAR_EXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_EXPORTAR_EXCEL.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_export
        Me.BT_EXPORTAR_EXCEL.Location = New System.Drawing.Point(77, 3)
        Me.BT_EXPORTAR_EXCEL.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_EXPORTAR_EXCEL.Name = "BT_EXPORTAR_EXCEL"
        Me.BT_EXPORTAR_EXCEL.Size = New System.Drawing.Size(70, 34)
        Me.BT_EXPORTAR_EXCEL.TabIndex = 28
        Me.BT_EXPORTAR_EXCEL.Tag = "Copiar al portapapeles"
        Me.BT_EXPORTAR_EXCEL.UseVisualStyleBackColor = True
        '
        'TI_RELOJ
        '
        '
        'LI_LISTADO
        '
        Me.LI_LISTADO.AllowUserToAddRows = False
        Me.LI_LISTADO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LI_LISTADO.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LI_LISTADO.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.LI_LISTADO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LI_LISTADO.Location = New System.Drawing.Point(8, 61)
        Me.LI_LISTADO.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.LI_LISTADO.Name = "LI_LISTADO"
        Me.LI_LISTADO.Size = New System.Drawing.Size(1141, 106)
        Me.LI_LISTADO.TabIndex = 2
        '
        'GB_LISTADO
        '
        Me.GB_LISTADO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_LISTADO.BackColor = System.Drawing.Color.White
        Me.GB_LISTADO.Controls.Add(Me.BT_GENERAR_UNIDAD_OPERATIVA)
        Me.GB_LISTADO.Controls.Add(Me.BT_GENERAR_RAZON_SOCIAL)
        Me.GB_LISTADO.Controls.Add(Me.BT_GENERAR_ZONA_UO)
        Me.GB_LISTADO.Controls.Add(Me.LI_LISTADO)
        Me.GB_LISTADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_LISTADO.Location = New System.Drawing.Point(10, 156)
        Me.GB_LISTADO.Name = "GB_LISTADO"
        Me.GB_LISTADO.Size = New System.Drawing.Size(1160, 174)
        Me.GB_LISTADO.TabIndex = 84
        Me.GB_LISTADO.TabStop = False
        Me.GB_LISTADO.Text = "Listado"
        '
        'BT_GENERAR_UNIDAD_OPERATIVA
        '
        Me.BT_GENERAR_UNIDAD_OPERATIVA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_GENERAR_UNIDAD_OPERATIVA.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_GENERAR_UNIDAD_OPERATIVA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_GENERAR_UNIDAD_OPERATIVA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_GENERAR_UNIDAD_OPERATIVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_GENERAR_UNIDAD_OPERATIVA.ForeColor = System.Drawing.Color.Black
        Me.BT_GENERAR_UNIDAD_OPERATIVA.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.phpGBF3Nw_opt
        Me.BT_GENERAR_UNIDAD_OPERATIVA.Location = New System.Drawing.Point(172, 16)
        Me.BT_GENERAR_UNIDAD_OPERATIVA.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_GENERAR_UNIDAD_OPERATIVA.Name = "BT_GENERAR_UNIDAD_OPERATIVA"
        Me.BT_GENERAR_UNIDAD_OPERATIVA.Size = New System.Drawing.Size(70, 39)
        Me.BT_GENERAR_UNIDAD_OPERATIVA.TabIndex = 22
        Me.BT_GENERAR_UNIDAD_OPERATIVA.Tag = "Generar Unidad Operativa"
        Me.BT_GENERAR_UNIDAD_OPERATIVA.UseVisualStyleBackColor = True
        '
        'BT_GENERAR_RAZON_SOCIAL
        '
        Me.BT_GENERAR_RAZON_SOCIAL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_GENERAR_RAZON_SOCIAL.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_GENERAR_RAZON_SOCIAL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_GENERAR_RAZON_SOCIAL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_GENERAR_RAZON_SOCIAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_GENERAR_RAZON_SOCIAL.ForeColor = System.Drawing.Color.Black
        Me.BT_GENERAR_RAZON_SOCIAL.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.php3AiLuq_opt
        Me.BT_GENERAR_RAZON_SOCIAL.Location = New System.Drawing.Point(90, 16)
        Me.BT_GENERAR_RAZON_SOCIAL.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_GENERAR_RAZON_SOCIAL.Name = "BT_GENERAR_RAZON_SOCIAL"
        Me.BT_GENERAR_RAZON_SOCIAL.Size = New System.Drawing.Size(70, 39)
        Me.BT_GENERAR_RAZON_SOCIAL.TabIndex = 21
        Me.BT_GENERAR_RAZON_SOCIAL.Tag = "Generar Razón Social"
        Me.BT_GENERAR_RAZON_SOCIAL.UseVisualStyleBackColor = True
        '
        'BT_GENERAR_ZONA_UO
        '
        Me.BT_GENERAR_ZONA_UO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_GENERAR_ZONA_UO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_GENERAR_ZONA_UO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_GENERAR_ZONA_UO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_GENERAR_ZONA_UO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_GENERAR_ZONA_UO.ForeColor = System.Drawing.Color.Black
        Me.BT_GENERAR_ZONA_UO.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.phpw0LqMn_opt
        Me.BT_GENERAR_ZONA_UO.Location = New System.Drawing.Point(8, 16)
        Me.BT_GENERAR_ZONA_UO.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_GENERAR_ZONA_UO.Name = "BT_GENERAR_ZONA_UO"
        Me.BT_GENERAR_ZONA_UO.Size = New System.Drawing.Size(70, 39)
        Me.BT_GENERAR_ZONA_UO.TabIndex = 20
        Me.BT_GENERAR_ZONA_UO.Tag = "Generar Zona"
        Me.BT_GENERAR_ZONA_UO.UseVisualStyleBackColor = True
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
        Me.GB_CONTROL.Location = New System.Drawing.Point(742, 335)
        Me.GB_CONTROL.Name = "GB_CONTROL"
        Me.GB_CONTROL.Size = New System.Drawing.Size(428, 52)
        Me.GB_CONTROL.TabIndex = 86
        Me.GB_CONTROL.TabStop = False
        Me.GB_CONTROL.Text = "Control"
        '
        'CH_VER_REVISADO
        '
        Me.CH_VER_REVISADO.AutoSize = True
        Me.CH_VER_REVISADO.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CH_VER_REVISADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CH_VER_REVISADO.Location = New System.Drawing.Point(860, 63)
        Me.CH_VER_REVISADO.Name = "CH_VER_REVISADO"
        Me.CH_VER_REVISADO.Size = New System.Drawing.Size(75, 31)
        Me.CH_VER_REVISADO.TabIndex = 220
        Me.CH_VER_REVISADO.Text = "Ver Revisado"
        Me.CH_VER_REVISADO.UseVisualStyleBackColor = True
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
        Me.TB_LI_BUSCAR.TabIndex = 100
        '
        'FL_MENU_1
        '
        Me.FL_MENU_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FL_MENU_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FL_MENU_1.BackColor = System.Drawing.Color.White
        Me.FL_MENU_1.Controls.Add(Me.BT_PLAN_PRESUPUESTO_AUTORIZAR)
        Me.FL_MENU_1.Location = New System.Drawing.Point(11, 8)
        Me.FL_MENU_1.Name = "FL_MENU_1"
        Me.FL_MENU_1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FL_MENU_1.Size = New System.Drawing.Size(764, 40)
        Me.FL_MENU_1.TabIndex = 87
        '
        'CH_VER_PREVIO
        '
        Me.CH_VER_PREVIO.AutoSize = True
        Me.CH_VER_PREVIO.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CH_VER_PREVIO.Checked = True
        Me.CH_VER_PREVIO.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CH_VER_PREVIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CH_VER_PREVIO.Location = New System.Drawing.Point(791, 63)
        Me.CH_VER_PREVIO.Name = "CH_VER_PREVIO"
        Me.CH_VER_PREVIO.Size = New System.Drawing.Size(60, 31)
        Me.CH_VER_PREVIO.TabIndex = 210
        Me.CH_VER_PREVIO.Text = "Ver Previo"
        Me.CH_VER_PREVIO.UseVisualStyleBackColor = True
        '
        'CB_LI_ESTATUS_PLAN_PRESUPUESTO
        '
        Me.CB_LI_ESTATUS_PLAN_PRESUPUESTO.FormattingEnabled = True
        Me.CB_LI_ESTATUS_PLAN_PRESUPUESTO.Location = New System.Drawing.Point(348, 73)
        Me.CB_LI_ESTATUS_PLAN_PRESUPUESTO.Name = "CB_LI_ESTATUS_PLAN_PRESUPUESTO"
        Me.CB_LI_ESTATUS_PLAN_PRESUPUESTO.Size = New System.Drawing.Size(119, 21)
        Me.CB_LI_ESTATUS_PLAN_PRESUPUESTO.TabIndex = 160
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(350, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Estatus"
        '
        'CB_LI_TEMPORADA
        '
        Me.CB_LI_TEMPORADA.FormattingEnabled = True
        Me.CB_LI_TEMPORADA.Location = New System.Drawing.Point(162, 73)
        Me.CB_LI_TEMPORADA.Name = "CB_LI_TEMPORADA"
        Me.CB_LI_TEMPORADA.Size = New System.Drawing.Size(180, 21)
        Me.CB_LI_TEMPORADA.TabIndex = 170
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(165, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Temporada"
        '
        'CB_LI_UNIDAD_OPERATIVA
        '
        Me.CB_LI_UNIDAD_OPERATIVA.FormattingEnabled = True
        Me.CB_LI_UNIDAD_OPERATIVA.Location = New System.Drawing.Point(616, 30)
        Me.CB_LI_UNIDAD_OPERATIVA.Name = "CB_LI_UNIDAD_OPERATIVA"
        Me.CB_LI_UNIDAD_OPERATIVA.Size = New System.Drawing.Size(180, 21)
        Me.CB_LI_UNIDAD_OPERATIVA.TabIndex = 130
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 57)
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
        Me.GB_OPERACION.Location = New System.Drawing.Point(11, 335)
        Me.GB_OPERACION.Name = "GB_OPERACION"
        Me.GB_OPERACION.Size = New System.Drawing.Size(724, 52)
        Me.GB_OPERACION.TabIndex = 85
        Me.GB_OPERACION.TabStop = False
        Me.GB_OPERACION.Text = "Operación"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(620, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Unidad Operativa"
        '
        'CB_LI_AÑO
        '
        Me.CB_LI_AÑO.FormattingEnabled = True
        Me.CB_LI_AÑO.Location = New System.Drawing.Point(6, 73)
        Me.CB_LI_AÑO.Name = "CB_LI_AÑO"
        Me.CB_LI_AÑO.Size = New System.Drawing.Size(150, 21)
        Me.CB_LI_AÑO.TabIndex = 150
        '
        'GB_FILTROS
        '
        Me.GB_FILTROS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_FILTROS.BackColor = System.Drawing.Color.White
        Me.GB_FILTROS.Controls.Add(Me.Label26)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_NIVEL_RUBRO_PRESUPUESTO)
        Me.GB_FILTROS.Controls.Add(Me.CH_EX_ETIQUETAS)
        Me.GB_FILTROS.Controls.Add(Me.CH_EX_CEROS)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_RAZON_SOCIAL)
        Me.GB_FILTROS.Controls.Add(Me.Label25)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_ZONA_UO)
        Me.GB_FILTROS.Controls.Add(Me.Label19)
        Me.GB_FILTROS.Controls.Add(Me.CH_VER_AUTORIZADO)
        Me.GB_FILTROS.Controls.Add(Me.CH_VER_REVISADO)
        Me.GB_FILTROS.Controls.Add(Me.CH_VER_PREVIO)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_ESTATUS_PLAN_PRESUPUESTO)
        Me.GB_FILTROS.Controls.Add(Me.Label12)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_TEMPORADA)
        Me.GB_FILTROS.Controls.Add(Me.Label11)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_UNIDAD_OPERATIVA)
        Me.GB_FILTROS.Controls.Add(Me.Label10)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_AÑO)
        Me.GB_FILTROS.Controls.Add(Me.BT_LI_BUSCAR)
        Me.GB_FILTROS.Controls.Add(Me.Label13)
        Me.GB_FILTROS.Controls.Add(Me.Label1)
        Me.GB_FILTROS.Controls.Add(Me.TB_LI_BUSCAR)
        Me.GB_FILTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FILTROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_FILTROS.Location = New System.Drawing.Point(11, 51)
        Me.GB_FILTROS.Name = "GB_FILTROS"
        Me.GB_FILTROS.Size = New System.Drawing.Size(1159, 105)
        Me.GB_FILTROS.TabIndex = 83
        Me.GB_FILTROS.TabStop = False
        Me.GB_FILTROS.Text = "Filtros"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(475, 58)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(32, 13)
        Me.Label26.TabIndex = 254
        Me.Label26.Text = "Nivel"
        '
        'CB_LI_NIVEL_RUBRO_PRESUPUESTO
        '
        Me.CB_LI_NIVEL_RUBRO_PRESUPUESTO.FormattingEnabled = True
        Me.CB_LI_NIVEL_RUBRO_PRESUPUESTO.Location = New System.Drawing.Point(473, 73)
        Me.CB_LI_NIVEL_RUBRO_PRESUPUESTO.Name = "CB_LI_NIVEL_RUBRO_PRESUPUESTO"
        Me.CB_LI_NIVEL_RUBRO_PRESUPUESTO.Size = New System.Drawing.Size(108, 21)
        Me.CB_LI_NIVEL_RUBRO_PRESUPUESTO.TabIndex = 251
        '
        'CH_EX_ETIQUETAS
        '
        Me.CH_EX_ETIQUETAS.AutoSize = True
        Me.CH_EX_ETIQUETAS.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CH_EX_ETIQUETAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CH_EX_ETIQUETAS.Location = New System.Drawing.Point(662, 55)
        Me.CH_EX_ETIQUETAS.Name = "CH_EX_ETIQUETAS"
        Me.CH_EX_ETIQUETAS.Size = New System.Drawing.Size(55, 44)
        Me.CH_EX_ETIQUETAS.TabIndex = 253
        Me.CH_EX_ETIQUETAS.Text = "Ocultar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Etiquetas"
        Me.CH_EX_ETIQUETAS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CH_EX_ETIQUETAS.UseVisualStyleBackColor = True
        '
        'CH_EX_CEROS
        '
        Me.CH_EX_CEROS.AutoSize = True
        Me.CH_EX_CEROS.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CH_EX_CEROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CH_EX_CEROS.Location = New System.Drawing.Point(589, 68)
        Me.CH_EX_CEROS.Name = "CH_EX_CEROS"
        Me.CH_EX_CEROS.Size = New System.Drawing.Size(72, 31)
        Me.CH_EX_CEROS.TabIndex = 252
        Me.CH_EX_CEROS.Text = "Excluir Ceros"
        Me.CH_EX_CEROS.UseVisualStyleBackColor = True
        '
        'CB_LI_RAZON_SOCIAL
        '
        Me.CB_LI_RAZON_SOCIAL.FormattingEnabled = True
        Me.CB_LI_RAZON_SOCIAL.Location = New System.Drawing.Point(348, 30)
        Me.CB_LI_RAZON_SOCIAL.Name = "CB_LI_RAZON_SOCIAL"
        Me.CB_LI_RAZON_SOCIAL.Size = New System.Drawing.Size(262, 21)
        Me.CB_LI_RAZON_SOCIAL.TabIndex = 120
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
        'CB_LI_ZONA_UO
        '
        Me.CB_LI_ZONA_UO.FormattingEnabled = True
        Me.CB_LI_ZONA_UO.Location = New System.Drawing.Point(162, 30)
        Me.CB_LI_ZONA_UO.Name = "CB_LI_ZONA_UO"
        Me.CB_LI_ZONA_UO.Size = New System.Drawing.Size(180, 21)
        Me.CB_LI_ZONA_UO.TabIndex = 110
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
        Me.BT_LI_BUSCAR.Location = New System.Drawing.Point(1083, 41)
        Me.BT_LI_BUSCAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_LI_BUSCAR.Name = "BT_LI_BUSCAR"
        Me.BT_LI_BUSCAR.Size = New System.Drawing.Size(70, 33)
        Me.BT_LI_BUSCAR.TabIndex = 250
        Me.BT_LI_BUSCAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_LI_BUSCAR.UseVisualStyleBackColor = True
        '
        'BT_PLAN_PRESUPUESTO_AUTORIZAR
        '
        Me.BT_PLAN_PRESUPUESTO_AUTORIZAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_PLAN_PRESUPUESTO_AUTORIZAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_PLAN_PRESUPUESTO_AUTORIZAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_autorizar
        Me.BT_PLAN_PRESUPUESTO_AUTORIZAR.Location = New System.Drawing.Point(0, 3)
        Me.BT_PLAN_PRESUPUESTO_AUTORIZAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_PLAN_PRESUPUESTO_AUTORIZAR.Name = "BT_PLAN_PRESUPUESTO_AUTORIZAR"
        Me.BT_PLAN_PRESUPUESTO_AUTORIZAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_PLAN_PRESUPUESTO_AUTORIZAR.TabIndex = 29
        Me.BT_PLAN_PRESUPUESTO_AUTORIZAR.Tag = "Autorizar Plan de Presupuesto"
        Me.BT_PLAN_PRESUPUESTO_AUTORIZAR.UseVisualStyleBackColor = True
        '
        'FO_PLAN_PRESUPUESTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 394)
        Me.Controls.Add(Me.FL_MENU_2)
        Me.Controls.Add(Me.FL_MENU_1)
        Me.Controls.Add(Me.GB_LISTADO)
        Me.Controls.Add(Me.GB_CONTROL)
        Me.Controls.Add(Me.GB_OPERACION)
        Me.Controls.Add(Me.GB_FILTROS)
        Me.Controls.Add(Me.GB_FICHA)
        Me.Name = "FO_PLAN_PRESUPUESTO"
        Me.Text = "FO_PLAN_PRESUPUESTO"
        Me.GB_FICHA.ResumeLayout(False)
        Me.GB_FICHA.PerformLayout()
        Me.FL_MENU_2.ResumeLayout(False)
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_LISTADO.ResumeLayout(False)
        Me.GB_CONTROL.ResumeLayout(False)
        Me.FL_MENU_1.ResumeLayout(False)
        Me.GB_OPERACION.ResumeLayout(False)
        Me.GB_OPERACION.PerformLayout()
        Me.GB_FILTROS.ResumeLayout(False)
        Me.GB_FILTROS.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label18 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CH_VER_AUTORIZADO As CheckBox
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
    Public WithEvents LI_LISTADO As DataGridView
    Public WithEvents GB_LISTADO As GroupBox
    Public WithEvents LB_VERSION As Label
    Public WithEvents LB_RELOJ As Label
    Public WithEvents GB_CONTROL As GroupBox
    Friend WithEvents CH_VER_REVISADO As CheckBox
    Friend WithEvents Label1 As Label
    Public WithEvents TB_LI_BUSCAR As TextBox
    Public WithEvents FL_MENU_1 As FlowLayoutPanel
    Friend WithEvents CH_VER_PREVIO As CheckBox
    Public WithEvents CB_LI_ESTATUS_PLAN_PRESUPUESTO As ComboBox
    Friend WithEvents Label12 As Label
    Public WithEvents CB_LI_TEMPORADA As ComboBox
    Friend WithEvents Label11 As Label
    Public WithEvents CB_LI_UNIDAD_OPERATIVA As ComboBox
    Friend WithEvents Label13 As Label
    Public WithEvents LB_RESULTADO As TextBox
    Public WithEvents GB_OPERACION As GroupBox
    Friend WithEvents Label10 As Label
    Public WithEvents CB_LI_AÑO As ComboBox
    Public WithEvents BT_LI_BUSCAR As Button
    Public WithEvents GB_FILTROS As GroupBox
    Public WithEvents CB_LI_RAZON_SOCIAL As ComboBox
    Friend WithEvents Label25 As Label
    Public WithEvents CB_LI_ZONA_UO As ComboBox
    Friend WithEvents Label19 As Label
    Public WithEvents CB_LI_NIVEL_RUBRO_PRESUPUESTO As ComboBox
    Friend WithEvents CH_EX_ETIQUETAS As CheckBox
    Friend WithEvents CH_EX_CEROS As CheckBox
    Friend WithEvents Label26 As Label
    Public WithEvents BT_GENERAR_UNIDAD_OPERATIVA As Button
    Public WithEvents BT_GENERAR_RAZON_SOCIAL As Button
    Public WithEvents BT_GENERAR_ZONA_UO As Button
    Public WithEvents BT_PLAN_PRESUPUESTO_AUTORIZAR As Button
End Class
