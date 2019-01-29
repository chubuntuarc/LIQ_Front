<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FO_CUENTA_CONTABLE
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GB_FICHA = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TB_O_CUENTA_CONTABLE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_C_CUENTA_CONTABLE = New System.Windows.Forms.TextBox()
        Me.CH_L_ES_CUENTA_CONTABLE = New System.Windows.Forms.CheckBox()
        Me.CH_L_PRESUPUESTO = New System.Windows.Forms.CheckBox()
        Me.CH_L_AFECTABLE = New System.Windows.Forms.CheckBox()
        Me.CB_TIPO_CUENTA_CONTABLE = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CB_SAT_AGRUPADOR = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TB_CODIGO = New System.Windows.Forms.TextBox()
        Me.lbx = New System.Windows.Forms.Label()
        Me.CB_NIVEL_CUENTA_CONTABLE = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CB_USUARIO_CAMBIO = New System.Windows.Forms.ComboBox()
        Me.CB_USUARIO_ALTA = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_F_ALTA = New System.Windows.Forms.TextBox()
        Me.TB_F_CAMBIO = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TB_S_CUENTA_CONTABLE = New System.Windows.Forms.TextBox()
        Me.TB_D_CUENTA_CONTABLE_3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_D_CUENTA_CONTABLE_2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_D_CUENTA_CONTABLE = New System.Windows.Forms.TextBox()
        Me.TB_K_CUENTA_CONTABLE = New System.Windows.Forms.TextBox()
        Me.LB_ID = New System.Windows.Forms.Label()
        Me.BT_LI_BUSCAR = New System.Windows.Forms.Button()
        Me.GB_FILTROS = New System.Windows.Forms.GroupBox()
        Me.CH_LI_ES_CUENTA_CONTABLE = New System.Windows.Forms.CheckBox()
        Me.CH_LI_PRESUPUESTO = New System.Windows.Forms.CheckBox()
        Me.CH_LI_AFECTABLE = New System.Windows.Forms.CheckBox()
        Me.CB_LI_SAT_AGRUPADOR = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CB_LI_TIPO_CUENTA_CONTABLE = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CB_LI_NIVEL_CUENTA_CONTABLE = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_LI_BUSCAR = New System.Windows.Forms.TextBox()
        Me.LI_LISTADO = New System.Windows.Forms.DataGridView()
        Me.BT_AGREGAR = New System.Windows.Forms.Button()
        Me.BT_SALIR = New System.Windows.Forms.Button()
        Me.BT_CANCELAR = New System.Windows.Forms.Button()
        Me.BT_GUARDAR = New System.Windows.Forms.Button()
        Me.BT_LISTADO = New System.Windows.Forms.Button()
        Me.BT_EXPORTAR_EXCEL = New System.Windows.Forms.Button()
        Me.BT_EDITAR = New System.Windows.Forms.Button()
        Me.BT_ELIMINAR = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GB_OPERACION = New System.Windows.Forms.GroupBox()
        Me.LB_RESULTADO = New System.Windows.Forms.TextBox()
        Me.FL_MENU_1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LB_VERSION = New System.Windows.Forms.Label()
        Me.LB_RELOJ = New System.Windows.Forms.Label()
        Me.GB_CONTROL = New System.Windows.Forms.GroupBox()
        Me.GB_LISTADO = New System.Windows.Forms.GroupBox()
        Me.TI_RELOJ = New System.Windows.Forms.Timer(Me.components)
        Me.BT_CLONAR = New System.Windows.Forms.Button()
        Me.GB_FICHA.SuspendLayout()
        Me.GB_FILTROS.SuspendLayout()
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.GB_OPERACION.SuspendLayout()
        Me.FL_MENU_1.SuspendLayout()
        Me.GB_CONTROL.SuspendLayout()
        Me.GB_LISTADO.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_FICHA
        '
        Me.GB_FICHA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GB_FICHA.BackColor = System.Drawing.Color.White
        Me.GB_FICHA.Controls.Add(Me.Label11)
        Me.GB_FICHA.Controls.Add(Me.TB_O_CUENTA_CONTABLE)
        Me.GB_FICHA.Controls.Add(Me.Label8)
        Me.GB_FICHA.Controls.Add(Me.TB_C_CUENTA_CONTABLE)
        Me.GB_FICHA.Controls.Add(Me.CH_L_ES_CUENTA_CONTABLE)
        Me.GB_FICHA.Controls.Add(Me.CH_L_PRESUPUESTO)
        Me.GB_FICHA.Controls.Add(Me.CH_L_AFECTABLE)
        Me.GB_FICHA.Controls.Add(Me.CB_TIPO_CUENTA_CONTABLE)
        Me.GB_FICHA.Controls.Add(Me.Label16)
        Me.GB_FICHA.Controls.Add(Me.CB_SAT_AGRUPADOR)
        Me.GB_FICHA.Controls.Add(Me.Label12)
        Me.GB_FICHA.Controls.Add(Me.TB_CODIGO)
        Me.GB_FICHA.Controls.Add(Me.lbx)
        Me.GB_FICHA.Controls.Add(Me.CB_NIVEL_CUENTA_CONTABLE)
        Me.GB_FICHA.Controls.Add(Me.Label18)
        Me.GB_FICHA.Controls.Add(Me.CB_USUARIO_CAMBIO)
        Me.GB_FICHA.Controls.Add(Me.CB_USUARIO_ALTA)
        Me.GB_FICHA.Controls.Add(Me.Label5)
        Me.GB_FICHA.Controls.Add(Me.Label9)
        Me.GB_FICHA.Controls.Add(Me.Label6)
        Me.GB_FICHA.Controls.Add(Me.Label2)
        Me.GB_FICHA.Controls.Add(Me.TB_F_ALTA)
        Me.GB_FICHA.Controls.Add(Me.TB_F_CAMBIO)
        Me.GB_FICHA.Controls.Add(Me.Label15)
        Me.GB_FICHA.Controls.Add(Me.Label13)
        Me.GB_FICHA.Controls.Add(Me.TB_S_CUENTA_CONTABLE)
        Me.GB_FICHA.Controls.Add(Me.TB_D_CUENTA_CONTABLE_3)
        Me.GB_FICHA.Controls.Add(Me.Label3)
        Me.GB_FICHA.Controls.Add(Me.TB_D_CUENTA_CONTABLE_2)
        Me.GB_FICHA.Controls.Add(Me.Label4)
        Me.GB_FICHA.Controls.Add(Me.TB_D_CUENTA_CONTABLE)
        Me.GB_FICHA.Controls.Add(Me.TB_K_CUENTA_CONTABLE)
        Me.GB_FICHA.Controls.Add(Me.LB_ID)
        Me.GB_FICHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FICHA.Location = New System.Drawing.Point(282, 156)
        Me.GB_FICHA.Name = "GB_FICHA"
        Me.GB_FICHA.Size = New System.Drawing.Size(700, 316)
        Me.GB_FICHA.TabIndex = 60
        Me.GB_FICHA.TabStop = False
        Me.GB_FICHA.Text = "Ficha"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(561, 191)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 149
        Me.Label11.Text = "Orden"
        '
        'TB_O_CUENTA_CONTABLE
        '
        Me.TB_O_CUENTA_CONTABLE.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_O_CUENTA_CONTABLE.Location = New System.Drawing.Point(556, 207)
        Me.TB_O_CUENTA_CONTABLE.Name = "TB_O_CUENTA_CONTABLE"
        Me.TB_O_CUENTA_CONTABLE.Size = New System.Drawing.Size(102, 22)
        Me.TB_O_CUENTA_CONTABLE.TabIndex = 148
        Me.TB_O_CUENTA_CONTABLE.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(32, 191)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 147
        Me.Label8.Text = "Comentarios"
        '
        'TB_C_CUENTA_CONTABLE
        '
        Me.TB_C_CUENTA_CONTABLE.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_C_CUENTA_CONTABLE.Location = New System.Drawing.Point(29, 207)
        Me.TB_C_CUENTA_CONTABLE.Name = "TB_C_CUENTA_CONTABLE"
        Me.TB_C_CUENTA_CONTABLE.Size = New System.Drawing.Size(523, 22)
        Me.TB_C_CUENTA_CONTABLE.TabIndex = 146
        Me.TB_C_CUENTA_CONTABLE.Tag = "1"
        '
        'CH_L_ES_CUENTA_CONTABLE
        '
        Me.CH_L_ES_CUENTA_CONTABLE.AutoSize = True
        Me.CH_L_ES_CUENTA_CONTABLE.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CH_L_ES_CUENTA_CONTABLE.Location = New System.Drawing.Point(549, 154)
        Me.CH_L_ES_CUENTA_CONTABLE.Name = "CH_L_ES_CUENTA_CONTABLE"
        Me.CH_L_ES_CUENTA_CONTABLE.Size = New System.Drawing.Size(105, 31)
        Me.CH_L_ES_CUENTA_CONTABLE.TabIndex = 145
        Me.CH_L_ES_CUENTA_CONTABLE.Text = "Es Cuenta Contable"
        Me.CH_L_ES_CUENTA_CONTABLE.UseVisualStyleBackColor = True
        '
        'CH_L_PRESUPUESTO
        '
        Me.CH_L_PRESUPUESTO.AutoSize = True
        Me.CH_L_PRESUPUESTO.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CH_L_PRESUPUESTO.Location = New System.Drawing.Point(446, 154)
        Me.CH_L_PRESUPUESTO.Name = "CH_L_PRESUPUESTO"
        Me.CH_L_PRESUPUESTO.Size = New System.Drawing.Size(85, 31)
        Me.CH_L_PRESUPUESTO.TabIndex = 144
        Me.CH_L_PRESUPUESTO.Text = "Es Presupuesto"
        Me.CH_L_PRESUPUESTO.UseVisualStyleBackColor = True
        '
        'CH_L_AFECTABLE
        '
        Me.CH_L_AFECTABLE.AutoSize = True
        Me.CH_L_AFECTABLE.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CH_L_AFECTABLE.Location = New System.Drawing.Point(354, 154)
        Me.CH_L_AFECTABLE.Name = "CH_L_AFECTABLE"
        Me.CH_L_AFECTABLE.Size = New System.Drawing.Size(71, 31)
        Me.CH_L_AFECTABLE.TabIndex = 143
        Me.CH_L_AFECTABLE.Text = "Es Afectable"
        Me.CH_L_AFECTABLE.UseVisualStyleBackColor = True
        '
        'CB_TIPO_CUENTA_CONTABLE
        '
        Me.CB_TIPO_CUENTA_CONTABLE.FormattingEnabled = True
        Me.CB_TIPO_CUENTA_CONTABLE.Location = New System.Drawing.Point(445, 127)
        Me.CB_TIPO_CUENTA_CONTABLE.Name = "CB_TIPO_CUENTA_CONTABLE"
        Me.CB_TIPO_CUENTA_CONTABLE.Size = New System.Drawing.Size(213, 21)
        Me.CB_TIPO_CUENTA_CONTABLE.TabIndex = 142
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(448, 111)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 13)
        Me.Label16.TabIndex = 141
        Me.Label16.Text = "Tipo"
        '
        'CB_SAT_AGRUPADOR
        '
        Me.CB_SAT_AGRUPADOR.FormattingEnabled = True
        Me.CB_SAT_AGRUPADOR.Location = New System.Drawing.Point(29, 167)
        Me.CB_SAT_AGRUPADOR.Name = "CB_SAT_AGRUPADOR"
        Me.CB_SAT_AGRUPADOR.Size = New System.Drawing.Size(306, 21)
        Me.CB_SAT_AGRUPADOR.TabIndex = 140
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(32, 151)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 139
        Me.Label12.Text = "Agrupador SAT"
        '
        'TB_CODIGO
        '
        Me.TB_CODIGO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CODIGO.Location = New System.Drawing.Point(29, 127)
        Me.TB_CODIGO.Name = "TB_CODIGO"
        Me.TB_CODIGO.Size = New System.Drawing.Size(194, 22)
        Me.TB_CODIGO.TabIndex = 136
        Me.TB_CODIGO.Tag = ""
        '
        'lbx
        '
        Me.lbx.AutoSize = True
        Me.lbx.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbx.Location = New System.Drawing.Point(32, 111)
        Me.lbx.Name = "lbx"
        Me.lbx.Size = New System.Drawing.Size(45, 13)
        Me.lbx.TabIndex = 135
        Me.lbx.Text = "Código"
        '
        'CB_NIVEL_CUENTA_CONTABLE
        '
        Me.CB_NIVEL_CUENTA_CONTABLE.FormattingEnabled = True
        Me.CB_NIVEL_CUENTA_CONTABLE.Location = New System.Drawing.Point(229, 127)
        Me.CB_NIVEL_CUENTA_CONTABLE.Name = "CB_NIVEL_CUENTA_CONTABLE"
        Me.CB_NIVEL_CUENTA_CONTABLE.Size = New System.Drawing.Size(212, 21)
        Me.CB_NIVEL_CUENTA_CONTABLE.TabIndex = 118
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(232, 111)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(31, 13)
        Me.Label18.TabIndex = 117
        Me.Label18.Text = "Nivel"
        '
        'CB_USUARIO_CAMBIO
        '
        Me.CB_USUARIO_CAMBIO.Enabled = False
        Me.CB_USUARIO_CAMBIO.FormattingEnabled = True
        Me.CB_USUARIO_CAMBIO.Location = New System.Drawing.Point(341, 274)
        Me.CB_USUARIO_CAMBIO.Name = "CB_USUARIO_CAMBIO"
        Me.CB_USUARIO_CAMBIO.Size = New System.Drawing.Size(150, 21)
        Me.CB_USUARIO_CAMBIO.TabIndex = 116
        '
        'CB_USUARIO_ALTA
        '
        Me.CB_USUARIO_ALTA.Enabled = False
        Me.CB_USUARIO_ALTA.FormattingEnabled = True
        Me.CB_USUARIO_ALTA.Location = New System.Drawing.Point(29, 274)
        Me.CB_USUARIO_ALTA.Name = "CB_USUARIO_ALTA"
        Me.CB_USUARIO_ALTA.Size = New System.Drawing.Size(150, 21)
        Me.CB_USUARIO_ALTA.TabIndex = 115
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(188, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "Fecha Alta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(500, 259)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 13)
        Me.Label9.TabIndex = 112
        Me.Label9.Text = "Ultima modificación"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(344, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "Ultimo Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Usuario Alta"
        '
        'TB_F_ALTA
        '
        Me.TB_F_ALTA.Enabled = False
        Me.TB_F_ALTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_F_ALTA.Location = New System.Drawing.Point(185, 273)
        Me.TB_F_ALTA.Name = "TB_F_ALTA"
        Me.TB_F_ALTA.Size = New System.Drawing.Size(150, 22)
        Me.TB_F_ALTA.TabIndex = 109
        '
        'TB_F_CAMBIO
        '
        Me.TB_F_CAMBIO.Enabled = False
        Me.TB_F_CAMBIO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_F_CAMBIO.Location = New System.Drawing.Point(497, 273)
        Me.TB_F_CAMBIO.Name = "TB_F_CAMBIO"
        Me.TB_F_CAMBIO.Size = New System.Drawing.Size(163, 22)
        Me.TB_F_CAMBIO.TabIndex = 110
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(561, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 13)
        Me.Label15.TabIndex = 107
        Me.Label15.Text = "Siglas"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(32, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(147, 13)
        Me.Label13.TabIndex = 104
        Me.Label13.Text = "Nombre 2 Cuenta Contable"
        '
        'TB_S_CUENTA_CONTABLE
        '
        Me.TB_S_CUENTA_CONTABLE.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_S_CUENTA_CONTABLE.Location = New System.Drawing.Point(558, 43)
        Me.TB_S_CUENTA_CONTABLE.Name = "TB_S_CUENTA_CONTABLE"
        Me.TB_S_CUENTA_CONTABLE.Size = New System.Drawing.Size(102, 22)
        Me.TB_S_CUENTA_CONTABLE.TabIndex = 37
        Me.TB_S_CUENTA_CONTABLE.Tag = ""
        '
        'TB_D_CUENTA_CONTABLE_3
        '
        Me.TB_D_CUENTA_CONTABLE_3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_D_CUENTA_CONTABLE_3.Location = New System.Drawing.Point(341, 85)
        Me.TB_D_CUENTA_CONTABLE_3.Name = "TB_D_CUENTA_CONTABLE_3"
        Me.TB_D_CUENTA_CONTABLE_3.Size = New System.Drawing.Size(317, 22)
        Me.TB_D_CUENTA_CONTABLE_3.TabIndex = 31
        Me.TB_D_CUENTA_CONTABLE_3.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(344, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Nombre 3 Cuenta Contable"
        '
        'TB_D_CUENTA_CONTABLE_2
        '
        Me.TB_D_CUENTA_CONTABLE_2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_D_CUENTA_CONTABLE_2.Location = New System.Drawing.Point(29, 85)
        Me.TB_D_CUENTA_CONTABLE_2.Name = "TB_D_CUENTA_CONTABLE_2"
        Me.TB_D_CUENTA_CONTABLE_2.Size = New System.Drawing.Size(306, 22)
        Me.TB_D_CUENTA_CONTABLE_2.TabIndex = 29
        Me.TB_D_CUENTA_CONTABLE_2.Tag = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(173, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Cuenta Contable"
        '
        'TB_D_CUENTA_CONTABLE
        '
        Me.TB_D_CUENTA_CONTABLE.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_D_CUENTA_CONTABLE.Location = New System.Drawing.Point(170, 43)
        Me.TB_D_CUENTA_CONTABLE.Name = "TB_D_CUENTA_CONTABLE"
        Me.TB_D_CUENTA_CONTABLE.Size = New System.Drawing.Size(382, 22)
        Me.TB_D_CUENTA_CONTABLE.TabIndex = 26
        Me.TB_D_CUENTA_CONTABLE.Tag = "1"
        '
        'TB_K_CUENTA_CONTABLE
        '
        Me.TB_K_CUENTA_CONTABLE.Enabled = False
        Me.TB_K_CUENTA_CONTABLE.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_K_CUENTA_CONTABLE.Location = New System.Drawing.Point(29, 43)
        Me.TB_K_CUENTA_CONTABLE.Name = "TB_K_CUENTA_CONTABLE"
        Me.TB_K_CUENTA_CONTABLE.Size = New System.Drawing.Size(135, 22)
        Me.TB_K_CUENTA_CONTABLE.TabIndex = 21
        '
        'LB_ID
        '
        Me.LB_ID.AutoSize = True
        Me.LB_ID.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ID.Location = New System.Drawing.Point(33, 27)
        Me.LB_ID.Name = "LB_ID"
        Me.LB_ID.Size = New System.Drawing.Size(34, 13)
        Me.LB_ID.TabIndex = 19
        Me.LB_ID.Text = "#CCT"
        '
        'BT_LI_BUSCAR
        '
        Me.BT_LI_BUSCAR.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BT_LI_BUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_LI_BUSCAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_LI_BUSCAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_LI_BUSCAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_LI_BUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_LI_BUSCAR.Image = Global.PYF18_Finanzas.My.Resources.Resources.rsz_search
        Me.BT_LI_BUSCAR.Location = New System.Drawing.Point(1155, 17)
        Me.BT_LI_BUSCAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_LI_BUSCAR.Name = "BT_LI_BUSCAR"
        Me.BT_LI_BUSCAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_LI_BUSCAR.TabIndex = 3
        Me.BT_LI_BUSCAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_LI_BUSCAR.UseVisualStyleBackColor = True
        '
        'GB_FILTROS
        '
        Me.GB_FILTROS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_FILTROS.BackColor = System.Drawing.Color.White
        Me.GB_FILTROS.Controls.Add(Me.CH_LI_ES_CUENTA_CONTABLE)
        Me.GB_FILTROS.Controls.Add(Me.CH_LI_PRESUPUESTO)
        Me.GB_FILTROS.Controls.Add(Me.CH_LI_AFECTABLE)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_SAT_AGRUPADOR)
        Me.GB_FILTROS.Controls.Add(Me.Label7)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_TIPO_CUENTA_CONTABLE)
        Me.GB_FILTROS.Controls.Add(Me.Label14)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_NIVEL_CUENTA_CONTABLE)
        Me.GB_FILTROS.Controls.Add(Me.Label10)
        Me.GB_FILTROS.Controls.Add(Me.BT_LI_BUSCAR)
        Me.GB_FILTROS.Controls.Add(Me.Label1)
        Me.GB_FILTROS.Controls.Add(Me.TB_LI_BUSCAR)
        Me.GB_FILTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FILTROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_FILTROS.Location = New System.Drawing.Point(13, 56)
        Me.GB_FILTROS.Name = "GB_FILTROS"
        Me.GB_FILTROS.Size = New System.Drawing.Size(1236, 63)
        Me.GB_FILTROS.TabIndex = 54
        Me.GB_FILTROS.TabStop = False
        Me.GB_FILTROS.Text = "Filtros"
        '
        'CH_LI_ES_CUENTA_CONTABLE
        '
        Me.CH_LI_ES_CUENTA_CONTABLE.AutoSize = True
        Me.CH_LI_ES_CUENTA_CONTABLE.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CH_LI_ES_CUENTA_CONTABLE.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CH_LI_ES_CUENTA_CONTABLE.Location = New System.Drawing.Point(918, 19)
        Me.CH_LI_ES_CUENTA_CONTABLE.Name = "CH_LI_ES_CUENTA_CONTABLE"
        Me.CH_LI_ES_CUENTA_CONTABLE.Size = New System.Drawing.Size(153, 31)
        Me.CH_LI_ES_CUENTA_CONTABLE.TabIndex = 148
        Me.CH_LI_ES_CUENTA_CONTABLE.Text = "Ver Solo Cuentas Contables"
        Me.CH_LI_ES_CUENTA_CONTABLE.UseVisualStyleBackColor = True
        '
        'CH_LI_PRESUPUESTO
        '
        Me.CH_LI_PRESUPUESTO.AutoSize = True
        Me.CH_LI_PRESUPUESTO.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CH_LI_PRESUPUESTO.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CH_LI_PRESUPUESTO.Location = New System.Drawing.Point(787, 19)
        Me.CH_LI_PRESUPUESTO.Name = "CH_LI_PRESUPUESTO"
        Me.CH_LI_PRESUPUESTO.Size = New System.Drawing.Size(120, 31)
        Me.CH_LI_PRESUPUESTO.TabIndex = 147
        Me.CH_LI_PRESUPUESTO.Text = "Ver Solo Presupuesto"
        Me.CH_LI_PRESUPUESTO.UseVisualStyleBackColor = True
        '
        'CH_LI_AFECTABLE
        '
        Me.CH_LI_AFECTABLE.AutoSize = True
        Me.CH_LI_AFECTABLE.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CH_LI_AFECTABLE.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CH_LI_AFECTABLE.Location = New System.Drawing.Point(675, 19)
        Me.CH_LI_AFECTABLE.Name = "CH_LI_AFECTABLE"
        Me.CH_LI_AFECTABLE.Size = New System.Drawing.Size(103, 31)
        Me.CH_LI_AFECTABLE.TabIndex = 146
        Me.CH_LI_AFECTABLE.Text = "Ver solo Afectable"
        Me.CH_LI_AFECTABLE.UseVisualStyleBackColor = True
        '
        'CB_LI_SAT_AGRUPADOR
        '
        Me.CB_LI_SAT_AGRUPADOR.FormattingEnabled = True
        Me.CB_LI_SAT_AGRUPADOR.Location = New System.Drawing.Point(500, 30)
        Me.CB_LI_SAT_AGRUPADOR.Name = "CB_LI_SAT_AGRUPADOR"
        Me.CB_LI_SAT_AGRUPADOR.Size = New System.Drawing.Size(157, 21)
        Me.CB_LI_SAT_AGRUPADOR.TabIndex = 126
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(503, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "Agrupador SAT"
        '
        'CB_LI_TIPO_CUENTA_CONTABLE
        '
        Me.CB_LI_TIPO_CUENTA_CONTABLE.FormattingEnabled = True
        Me.CB_LI_TIPO_CUENTA_CONTABLE.Location = New System.Drawing.Point(338, 31)
        Me.CB_LI_TIPO_CUENTA_CONTABLE.Name = "CB_LI_TIPO_CUENTA_CONTABLE"
        Me.CB_LI_TIPO_CUENTA_CONTABLE.Size = New System.Drawing.Size(157, 21)
        Me.CB_LI_TIPO_CUENTA_CONTABLE.TabIndex = 124
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(341, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 13)
        Me.Label14.TabIndex = 123
        Me.Label14.Text = "Tipo"
        '
        'CB_LI_NIVEL_CUENTA_CONTABLE
        '
        Me.CB_LI_NIVEL_CUENTA_CONTABLE.FormattingEnabled = True
        Me.CB_LI_NIVEL_CUENTA_CONTABLE.Location = New System.Drawing.Point(219, 31)
        Me.CB_LI_NIVEL_CUENTA_CONTABLE.Name = "CB_LI_NIVEL_CUENTA_CONTABLE"
        Me.CB_LI_NIVEL_CUENTA_CONTABLE.Size = New System.Drawing.Size(113, 21)
        Me.CB_LI_NIVEL_CUENTA_CONTABLE.TabIndex = 120
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(222, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 119
        Me.Label10.Text = "Nivel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Buscar"
        '
        'TB_LI_BUSCAR
        '
        Me.TB_LI_BUSCAR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LI_BUSCAR.Location = New System.Drawing.Point(12, 30)
        Me.TB_LI_BUSCAR.Name = "TB_LI_BUSCAR"
        Me.TB_LI_BUSCAR.Size = New System.Drawing.Size(201, 22)
        Me.TB_LI_BUSCAR.TabIndex = 1
        '
        'LI_LISTADO
        '
        Me.LI_LISTADO.AllowUserToAddRows = False
        Me.LI_LISTADO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.LI_LISTADO.Location = New System.Drawing.Point(12, 26)
        Me.LI_LISTADO.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.LI_LISTADO.Name = "LI_LISTADO"
        Me.LI_LISTADO.Size = New System.Drawing.Size(1213, 387)
        Me.LI_LISTADO.TabIndex = 2
        '
        'BT_AGREGAR
        '
        Me.BT_AGREGAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_AGREGAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_AGREGAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_AGREGAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_AGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_AGREGAR.Image = Global.PYF18_Finanzas.My.Resources.Resources.rsz_1add
        Me.BT_AGREGAR.Location = New System.Drawing.Point(0, 3)
        Me.BT_AGREGAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_AGREGAR.Name = "BT_AGREGAR"
        Me.BT_AGREGAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_AGREGAR.TabIndex = 4
        Me.BT_AGREGAR.UseVisualStyleBackColor = True
        '
        'BT_SALIR
        '
        Me.BT_SALIR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BT_SALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_SALIR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_SALIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_SALIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_SALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_SALIR.Image = Global.PYF18_Finanzas.My.Resources.Resources.rsz_exit
        Me.BT_SALIR.Location = New System.Drawing.Point(298, 6)
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
        Me.BT_CANCELAR.Image = Global.PYF18_Finanzas.My.Resources.Resources.rsz_cancel
        Me.BT_CANCELAR.Location = New System.Drawing.Point(228, 6)
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
        Me.BT_GUARDAR.Enabled = False
        Me.BT_GUARDAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_GUARDAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_GUARDAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_GUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_GUARDAR.Image = Global.PYF18_Finanzas.My.Resources.Resources.rsz_accept
        Me.BT_GUARDAR.Location = New System.Drawing.Point(158, 6)
        Me.BT_GUARDAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_GUARDAR.Name = "BT_GUARDAR"
        Me.BT_GUARDAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_GUARDAR.TabIndex = 23
        Me.BT_GUARDAR.UseVisualStyleBackColor = True
        '
        'BT_LISTADO
        '
        Me.BT_LISTADO.BackColor = System.Drawing.Color.White
        Me.BT_LISTADO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_LISTADO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_LISTADO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_LISTADO.Image = Global.PYF18_Finanzas.My.Resources.Resources.listado
        Me.BT_LISTADO.Location = New System.Drawing.Point(85, 6)
        Me.BT_LISTADO.Name = "BT_LISTADO"
        Me.BT_LISTADO.Size = New System.Drawing.Size(70, 34)
        Me.BT_LISTADO.TabIndex = 25
        Me.BT_LISTADO.UseVisualStyleBackColor = False
        '
        'BT_EXPORTAR_EXCEL
        '
        Me.BT_EXPORTAR_EXCEL.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_EXPORTAR_EXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_EXPORTAR_EXCEL.Image = Global.PYF18_Finanzas.My.Resources.Resources.rsz_export
        Me.BT_EXPORTAR_EXCEL.Location = New System.Drawing.Point(9, 6)
        Me.BT_EXPORTAR_EXCEL.Name = "BT_EXPORTAR_EXCEL"
        Me.BT_EXPORTAR_EXCEL.Size = New System.Drawing.Size(70, 34)
        Me.BT_EXPORTAR_EXCEL.TabIndex = 28
        Me.BT_EXPORTAR_EXCEL.Tag = "Copiar al portapapeles"
        Me.BT_EXPORTAR_EXCEL.UseVisualStyleBackColor = True
        '
        'BT_EDITAR
        '
        Me.BT_EDITAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_EDITAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_EDITAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_EDITAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_EDITAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_EDITAR.Image = Global.PYF18_Finanzas.My.Resources.Resources.rsz_edit
        Me.BT_EDITAR.Location = New System.Drawing.Point(70, 3)
        Me.BT_EDITAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_EDITAR.Name = "BT_EDITAR"
        Me.BT_EDITAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_EDITAR.TabIndex = 5
        Me.BT_EDITAR.UseVisualStyleBackColor = True
        '
        'BT_ELIMINAR
        '
        Me.BT_ELIMINAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_ELIMINAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_ELIMINAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_ELIMINAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_ELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_ELIMINAR.ForeColor = System.Drawing.Color.Black
        Me.BT_ELIMINAR.Image = Global.PYF18_Finanzas.My.Resources.Resources.rsz_delete
        Me.BT_ELIMINAR.Location = New System.Drawing.Point(210, 3)
        Me.BT_ELIMINAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_ELIMINAR.Name = "BT_ELIMINAR"
        Me.BT_ELIMINAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_ELIMINAR.TabIndex = 6
        Me.BT_ELIMINAR.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel2.Controls.Add(Me.BT_SALIR)
        Me.FlowLayoutPanel2.Controls.Add(Me.BT_CANCELAR)
        Me.FlowLayoutPanel2.Controls.Add(Me.BT_GUARDAR)
        Me.FlowLayoutPanel2.Controls.Add(Me.BT_LISTADO)
        Me.FlowLayoutPanel2.Controls.Add(Me.BT_EXPORTAR_EXCEL)
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(881, 8)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(368, 40)
        Me.FlowLayoutPanel2.TabIndex = 59
        '
        'GB_OPERACION
        '
        Me.GB_OPERACION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_OPERACION.BackColor = System.Drawing.Color.White
        Me.GB_OPERACION.Controls.Add(Me.LB_RESULTADO)
        Me.GB_OPERACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_OPERACION.Location = New System.Drawing.Point(13, 553)
        Me.GB_OPERACION.Name = "GB_OPERACION"
        Me.GB_OPERACION.Size = New System.Drawing.Size(790, 52)
        Me.GB_OPERACION.TabIndex = 56
        Me.GB_OPERACION.TabStop = False
        Me.GB_OPERACION.Text = "Operación"
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
        Me.LB_RESULTADO.Location = New System.Drawing.Point(6, 15)
        Me.LB_RESULTADO.Multiline = True
        Me.LB_RESULTADO.Name = "LB_RESULTADO"
        Me.LB_RESULTADO.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.LB_RESULTADO.Size = New System.Drawing.Size(778, 30)
        Me.LB_RESULTADO.TabIndex = 5
        '
        'FL_MENU_1
        '
        Me.FL_MENU_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FL_MENU_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FL_MENU_1.BackColor = System.Drawing.Color.White
        Me.FL_MENU_1.Controls.Add(Me.BT_AGREGAR)
        Me.FL_MENU_1.Controls.Add(Me.BT_EDITAR)
        Me.FL_MENU_1.Controls.Add(Me.BT_CLONAR)
        Me.FL_MENU_1.Controls.Add(Me.BT_ELIMINAR)
        Me.FL_MENU_1.Location = New System.Drawing.Point(13, 8)
        Me.FL_MENU_1.Name = "FL_MENU_1"
        Me.FL_MENU_1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FL_MENU_1.Size = New System.Drawing.Size(996, 40)
        Me.FL_MENU_1.TabIndex = 58
        '
        'LB_VERSION
        '
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
        Me.LB_RELOJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_RELOJ.Location = New System.Drawing.Point(251, 34)
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
        Me.GB_CONTROL.Location = New System.Drawing.Point(810, 553)
        Me.GB_CONTROL.Name = "GB_CONTROL"
        Me.GB_CONTROL.Size = New System.Drawing.Size(440, 52)
        Me.GB_CONTROL.TabIndex = 57
        Me.GB_CONTROL.TabStop = False
        Me.GB_CONTROL.Text = "Control"
        '
        'GB_LISTADO
        '
        Me.GB_LISTADO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_LISTADO.BackColor = System.Drawing.Color.White
        Me.GB_LISTADO.Controls.Add(Me.LI_LISTADO)
        Me.GB_LISTADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_LISTADO.Location = New System.Drawing.Point(13, 125)
        Me.GB_LISTADO.Name = "GB_LISTADO"
        Me.GB_LISTADO.Size = New System.Drawing.Size(1236, 426)
        Me.GB_LISTADO.TabIndex = 55
        Me.GB_LISTADO.TabStop = False
        Me.GB_LISTADO.Text = "Listado"
        '
        'TI_RELOJ
        '
        '
        'BT_CLONAR
        '
        Me.BT_CLONAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_CLONAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_CLONAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_CLONAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_CLONAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_CLONAR.Image = Global.PYF18_Finanzas.My.Resources.Resources.adn_icon
        Me.BT_CLONAR.Location = New System.Drawing.Point(140, 3)
        Me.BT_CLONAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_CLONAR.Name = "BT_CLONAR"
        Me.BT_CLONAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_CLONAR.TabIndex = 8
        Me.BT_CLONAR.UseVisualStyleBackColor = True
        '
        'FO_CUENTA_CONTABLE
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1264, 612)
        Me.Controls.Add(Me.GB_FICHA)
        Me.Controls.Add(Me.GB_FILTROS)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.GB_OPERACION)
        Me.Controls.Add(Me.FL_MENU_1)
        Me.Controls.Add(Me.GB_CONTROL)
        Me.Controls.Add(Me.GB_LISTADO)
        Me.DoubleBuffered = True
        Me.Name = "FO_CUENTA_CONTABLE"
        Me.Text = "FO_CUENTA_CONTABLE"
        Me.GB_FICHA.ResumeLayout(False)
        Me.GB_FICHA.PerformLayout()
        Me.GB_FILTROS.ResumeLayout(False)
        Me.GB_FILTROS.PerformLayout()
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.GB_OPERACION.ResumeLayout(False)
        Me.GB_OPERACION.PerformLayout()
        Me.FL_MENU_1.ResumeLayout(False)
        Me.GB_CONTROL.ResumeLayout(False)
        Me.GB_LISTADO.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents GB_FICHA As GroupBox
    Public WithEvents TB_S_CUENTA_CONTABLE As TextBox
    Public WithEvents TB_D_CUENTA_CONTABLE_3 As TextBox
    Friend WithEvents Label3 As Label
    Public WithEvents TB_D_CUENTA_CONTABLE_2 As TextBox
    Friend WithEvents Label4 As Label
    Public WithEvents TB_D_CUENTA_CONTABLE As TextBox
    Public WithEvents TB_K_CUENTA_CONTABLE As TextBox
    Friend WithEvents LB_ID As Label
    Public WithEvents BT_LI_BUSCAR As Button
    Public WithEvents GB_FILTROS As GroupBox
    Friend WithEvents Label1 As Label
    Public WithEvents TB_LI_BUSCAR As TextBox
    Public WithEvents LI_LISTADO As DataGridView
    Public WithEvents BT_AGREGAR As Button
    Public WithEvents BT_SALIR As Button
    Public WithEvents BT_CANCELAR As Button
    Public WithEvents BT_GUARDAR As Button
    Public WithEvents BT_LISTADO As Button
    Public WithEvents BT_EDITAR As Button
    Public WithEvents BT_ELIMINAR As Button
    Public WithEvents LB_VERSION As Label
    Public WithEvents LB_RELOJ As Label
    Public WithEvents GB_LISTADO As GroupBox
    Public WithEvents TI_RELOJ As Timer
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Public WithEvents CB_USUARIO_CAMBIO As ComboBox
    Public WithEvents CB_USUARIO_ALTA As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents TB_F_ALTA As TextBox
    Public WithEvents TB_F_CAMBIO As TextBox
    Public WithEvents CB_NIVEL_CUENTA_CONTABLE As ComboBox
    Friend WithEvents Label18 As Label
    Public WithEvents TB_CODIGO As TextBox
    Friend WithEvents lbx As Label
    Public WithEvents CB_LI_NIVEL_CUENTA_CONTABLE As ComboBox
    Friend WithEvents Label10 As Label
    Public WithEvents BT_EXPORTAR_EXCEL As Button
    Public WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Public WithEvents GB_OPERACION As GroupBox
    Public WithEvents FL_MENU_1 As FlowLayoutPanel
    Public WithEvents GB_CONTROL As GroupBox
    Public WithEvents LB_RESULTADO As TextBox
    Public WithEvents CB_SAT_AGRUPADOR As ComboBox
    Friend WithEvents Label12 As Label
    Public WithEvents CB_LI_TIPO_CUENTA_CONTABLE As ComboBox
    Friend WithEvents Label14 As Label
    Public WithEvents CB_TIPO_CUENTA_CONTABLE As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents CH_L_ES_CUENTA_CONTABLE As CheckBox
    Friend WithEvents CH_L_PRESUPUESTO As CheckBox
    Friend WithEvents CH_L_AFECTABLE As CheckBox
    Public WithEvents CB_LI_SAT_AGRUPADOR As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CH_LI_ES_CUENTA_CONTABLE As CheckBox
    Friend WithEvents CH_LI_PRESUPUESTO As CheckBox
    Friend WithEvents CH_LI_AFECTABLE As CheckBox
    Friend WithEvents Label8 As Label
    Public WithEvents TB_C_CUENTA_CONTABLE As TextBox
    Friend WithEvents Label11 As Label
    Public WithEvents TB_O_CUENTA_CONTABLE As TextBox
    Public WithEvents BT_CLONAR As Button
End Class
