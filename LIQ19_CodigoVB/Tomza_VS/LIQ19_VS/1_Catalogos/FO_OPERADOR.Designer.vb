<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FO_OPERADOR
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
        Me.CB_LI_ESTATUS_OPERADOR = New System.Windows.Forms.ComboBox()
        Me.GB_FILTROS = New System.Windows.Forms.GroupBox()
        Me.CB_LI_SEXO = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.CB_LI_ESTADO_CIVIL = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.TB_LI_F_INICIAL = New System.Windows.Forms.MaskedTextBox()
        Me.TB_LI_F_FINAL = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BT_LI_BUSCAR = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_LI_BUSCAR = New System.Windows.Forms.TextBox()
        Me.GB_LISTADO = New System.Windows.Forms.GroupBox()
        Me.LI_LISTADO = New System.Windows.Forms.DataGridView()
        Me.GB_OPERACION = New System.Windows.Forms.GroupBox()
        Me.LB_RESULTADO = New System.Windows.Forms.TextBox()
        Me.LB_RELOJ = New System.Windows.Forms.Label()
        Me.GB_CONTROL = New System.Windows.Forms.GroupBox()
        Me.LB_VERSION = New System.Windows.Forms.Label()
        Me.TI_RELOJ = New System.Windows.Forms.Timer(Me.components)
        Me.FL_MENU_2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_SALIR = New System.Windows.Forms.Button()
        Me.BT_CANCELAR = New System.Windows.Forms.Button()
        Me.BT_GUARDAR = New System.Windows.Forms.Button()
        Me.BT_LISTADO = New System.Windows.Forms.Button()
        Me.BT_EXPORTAR_EXCEL = New System.Windows.Forms.Button()
        Me.FL_MENU_1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_AGREGAR = New System.Windows.Forms.Button()
        Me.BT_EDITAR = New System.Windows.Forms.Button()
        Me.BT_CLONAR = New System.Windows.Forms.Button()
        Me.BT_ELIMINAR = New System.Windows.Forms.Button()
        Me.GB_FICHA = New System.Windows.Forms.GroupBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.TB_ESTADO = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.TB_F_VIGENCIA_LICENCIA = New System.Windows.Forms.MaskedTextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TB_NUMERO_LICENCIA_OPERADOR = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TB_NUMERO_INTERIOR = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TB_NUMERO_EXTERIOR = New System.Windows.Forms.TextBox()
        Me.TB_TELEFONO = New System.Windows.Forms.TextBox()
        Me.TB_NSS = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TB_APELLIDO_MATERNO = New System.Windows.Forms.TextBox()
        Me.CB_SEXO = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.CB_ESTADO_CIVIL = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TB_APELLIDO_PATERNO = New System.Windows.Forms.TextBox()
        Me.TB_NOMBRE = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TB_SALARIO_DIARIO_INTEGRADO = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TB_SALARIO_DIARIO = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TB_MUNICIPIO = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TB_COLONIA = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TB_CORREO = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TB_CALLE = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TB_F_NACIMIENTO = New System.Windows.Forms.MaskedTextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TB_F_INGRESO = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TB_CP = New System.Windows.Forms.TextBox()
        Me.CB_USUARIO_CAMBIO = New System.Windows.Forms.ComboBox()
        Me.CB_USUARIO_ALTA = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_F_ALTA = New System.Windows.Forms.TextBox()
        Me.TB_F_CAMBIO = New System.Windows.Forms.TextBox()
        Me.CB_ESTATUS_OPERADOR = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_K_OPERADOR = New System.Windows.Forms.TextBox()
        Me.LB_ID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_CURP = New System.Windows.Forms.TextBox()
        Me.TB_C_CHOFER = New System.Windows.Forms.TextBox()
        Me.TB_RFC = New System.Windows.Forms.TextBox()
        Me.GB_FILTROS.SuspendLayout()
        Me.GB_LISTADO.SuspendLayout()
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_OPERACION.SuspendLayout()
        Me.GB_CONTROL.SuspendLayout()
        Me.FL_MENU_2.SuspendLayout()
        Me.FL_MENU_1.SuspendLayout()
        Me.GB_FICHA.SuspendLayout()
        Me.SuspendLayout()
        '
        'CB_LI_ESTATUS_OPERADOR
        '
        Me.CB_LI_ESTATUS_OPERADOR.FormattingEnabled = True
        Me.CB_LI_ESTATUS_OPERADOR.Location = New System.Drawing.Point(204, 32)
        Me.CB_LI_ESTATUS_OPERADOR.Name = "CB_LI_ESTATUS_OPERADOR"
        Me.CB_LI_ESTATUS_OPERADOR.Size = New System.Drawing.Size(170, 21)
        Me.CB_LI_ESTATUS_OPERADOR.TabIndex = 9
        '
        'GB_FILTROS
        '
        Me.GB_FILTROS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_FILTROS.BackColor = System.Drawing.Color.White
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_SEXO)
        Me.GB_FILTROS.Controls.Add(Me.Label39)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_ESTADO_CIVIL)
        Me.GB_FILTROS.Controls.Add(Me.Label38)
        Me.GB_FILTROS.Controls.Add(Me.TB_LI_F_INICIAL)
        Me.GB_FILTROS.Controls.Add(Me.TB_LI_F_FINAL)
        Me.GB_FILTROS.Controls.Add(Me.Label15)
        Me.GB_FILTROS.Controls.Add(Me.Label16)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_ESTATUS_OPERADOR)
        Me.GB_FILTROS.Controls.Add(Me.BT_LI_BUSCAR)
        Me.GB_FILTROS.Controls.Add(Me.Label13)
        Me.GB_FILTROS.Controls.Add(Me.Label1)
        Me.GB_FILTROS.Controls.Add(Me.TB_LI_BUSCAR)
        Me.GB_FILTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FILTROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_FILTROS.Location = New System.Drawing.Point(13, 56)
        Me.GB_FILTROS.Name = "GB_FILTROS"
        Me.GB_FILTROS.Size = New System.Drawing.Size(1028, 76)
        Me.GB_FILTROS.TabIndex = 34
        Me.GB_FILTROS.TabStop = False
        Me.GB_FILTROS.Text = "Filtros"
        '
        'CB_LI_SEXO
        '
        Me.CB_LI_SEXO.FormattingEnabled = True
        Me.CB_LI_SEXO.Location = New System.Drawing.Point(718, 33)
        Me.CB_LI_SEXO.Name = "CB_LI_SEXO"
        Me.CB_LI_SEXO.Size = New System.Drawing.Size(118, 21)
        Me.CB_LI_SEXO.TabIndex = 118
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(721, 17)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(31, 13)
        Me.Label39.TabIndex = 117
        Me.Label39.Text = "Sexo"
        '
        'CB_LI_ESTADO_CIVIL
        '
        Me.CB_LI_ESTADO_CIVIL.FormattingEnabled = True
        Me.CB_LI_ESTADO_CIVIL.Location = New System.Drawing.Point(591, 32)
        Me.CB_LI_ESTADO_CIVIL.Name = "CB_LI_ESTADO_CIVIL"
        Me.CB_LI_ESTADO_CIVIL.Size = New System.Drawing.Size(117, 21)
        Me.CB_LI_ESTADO_CIVIL.TabIndex = 116
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(594, 16)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(66, 13)
        Me.Label38.TabIndex = 115
        Me.Label38.Text = "Estado Civil"
        '
        'TB_LI_F_INICIAL
        '
        Me.TB_LI_F_INICIAL.Location = New System.Drawing.Point(386, 34)
        Me.TB_LI_F_INICIAL.Mask = "00/00/0000"
        Me.TB_LI_F_INICIAL.Name = "TB_LI_F_INICIAL"
        Me.TB_LI_F_INICIAL.Size = New System.Drawing.Size(92, 20)
        Me.TB_LI_F_INICIAL.TabIndex = 113
        Me.TB_LI_F_INICIAL.ValidatingType = GetType(Date)
        '
        'TB_LI_F_FINAL
        '
        Me.TB_LI_F_FINAL.Location = New System.Drawing.Point(494, 34)
        Me.TB_LI_F_FINAL.Mask = "00/00/0000"
        Me.TB_LI_F_FINAL.Name = "TB_LI_F_FINAL"
        Me.TB_LI_F_FINAL.Size = New System.Drawing.Size(88, 20)
        Me.TB_LI_F_FINAL.TabIndex = 114
        Me.TB_LI_F_FINAL.ValidatingType = GetType(Date)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(497, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 12)
        Me.Label15.TabIndex = 112
        Me.Label15.Text = "Final [dd/mm/aaaa]"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(389, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 12)
        Me.Label16.TabIndex = 111
        Me.Label16.Text = "Inicial [dd/mm/aaaa]"
        '
        'BT_LI_BUSCAR
        '
        Me.BT_LI_BUSCAR.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BT_LI_BUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_LI_BUSCAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_LI_BUSCAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_LI_BUSCAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_LI_BUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_LI_BUSCAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.ICO_BT_LI_BUSCAR
        Me.BT_LI_BUSCAR.Location = New System.Drawing.Point(947, 19)
        Me.BT_LI_BUSCAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_LI_BUSCAR.Name = "BT_LI_BUSCAR"
        Me.BT_LI_BUSCAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_LI_BUSCAR.TabIndex = 3
        Me.BT_LI_BUSCAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_LI_BUSCAR.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(207, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Estatus"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Buscar"
        '
        'TB_LI_BUSCAR
        '
        Me.TB_LI_BUSCAR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_LI_BUSCAR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LI_BUSCAR.Location = New System.Drawing.Point(12, 32)
        Me.TB_LI_BUSCAR.Name = "TB_LI_BUSCAR"
        Me.TB_LI_BUSCAR.Size = New System.Drawing.Size(180, 22)
        Me.TB_LI_BUSCAR.TabIndex = 1
        '
        'GB_LISTADO
        '
        Me.GB_LISTADO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_LISTADO.BackColor = System.Drawing.Color.White
        Me.GB_LISTADO.Controls.Add(Me.LI_LISTADO)
        Me.GB_LISTADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_LISTADO.Location = New System.Drawing.Point(13, 138)
        Me.GB_LISTADO.Name = "GB_LISTADO"
        Me.GB_LISTADO.Size = New System.Drawing.Size(1028, 406)
        Me.GB_LISTADO.TabIndex = 35
        Me.GB_LISTADO.TabStop = False
        Me.GB_LISTADO.Text = "Listado"
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
        Me.LI_LISTADO.Size = New System.Drawing.Size(1005, 367)
        Me.LI_LISTADO.TabIndex = 2
        '
        'GB_OPERACION
        '
        Me.GB_OPERACION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_OPERACION.BackColor = System.Drawing.Color.White
        Me.GB_OPERACION.Controls.Add(Me.LB_RESULTADO)
        Me.GB_OPERACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_OPERACION.Location = New System.Drawing.Point(13, 546)
        Me.GB_OPERACION.Name = "GB_OPERACION"
        Me.GB_OPERACION.Size = New System.Drawing.Size(582, 52)
        Me.GB_OPERACION.TabIndex = 36
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
        Me.LB_RESULTADO.Size = New System.Drawing.Size(570, 30)
        Me.LB_RESULTADO.TabIndex = 4
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
        Me.GB_CONTROL.Location = New System.Drawing.Point(602, 546)
        Me.GB_CONTROL.Name = "GB_CONTROL"
        Me.GB_CONTROL.Size = New System.Drawing.Size(440, 52)
        Me.GB_CONTROL.TabIndex = 37
        Me.GB_CONTROL.TabStop = False
        Me.GB_CONTROL.Text = "Control"
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
        'TI_RELOJ
        '
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
        Me.FL_MENU_2.Location = New System.Drawing.Point(656, 8)
        Me.FL_MENU_2.Name = "FL_MENU_2"
        Me.FL_MENU_2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FL_MENU_2.Size = New System.Drawing.Size(385, 40)
        Me.FL_MENU_2.TabIndex = 39
        '
        'BT_SALIR
        '
        Me.BT_SALIR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BT_SALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_SALIR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_SALIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_SALIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_SALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_SALIR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.ICO_BT_SALIR
        Me.BT_SALIR.Location = New System.Drawing.Point(315, 6)
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
        Me.BT_CANCELAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.ICO_BT_CANCELAR
        Me.BT_CANCELAR.Location = New System.Drawing.Point(245, 6)
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
        Me.BT_GUARDAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.ICO_BT_GUARDAR
        Me.BT_GUARDAR.Location = New System.Drawing.Point(175, 6)
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
        Me.BT_LISTADO.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.ICO_BT_LISTADO
        Me.BT_LISTADO.Location = New System.Drawing.Point(102, 6)
        Me.BT_LISTADO.Name = "BT_LISTADO"
        Me.BT_LISTADO.Size = New System.Drawing.Size(70, 34)
        Me.BT_LISTADO.TabIndex = 25
        Me.BT_LISTADO.UseVisualStyleBackColor = False
        '
        'BT_EXPORTAR_EXCEL
        '
        Me.BT_EXPORTAR_EXCEL.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_EXPORTAR_EXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_EXPORTAR_EXCEL.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.ICO_BT_EXPORTAR_EXCEL
        Me.BT_EXPORTAR_EXCEL.Location = New System.Drawing.Point(26, 6)
        Me.BT_EXPORTAR_EXCEL.Name = "BT_EXPORTAR_EXCEL"
        Me.BT_EXPORTAR_EXCEL.Size = New System.Drawing.Size(70, 34)
        Me.BT_EXPORTAR_EXCEL.TabIndex = 28
        Me.BT_EXPORTAR_EXCEL.Tag = "Copiar al portapapeles"
        Me.BT_EXPORTAR_EXCEL.UseVisualStyleBackColor = True
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
        Me.FL_MENU_1.Size = New System.Drawing.Size(646, 40)
        Me.FL_MENU_1.TabIndex = 38
        '
        'BT_AGREGAR
        '
        Me.BT_AGREGAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_AGREGAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_AGREGAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_AGREGAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_AGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_AGREGAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.ICO_BT_AGREGAR
        Me.BT_AGREGAR.Location = New System.Drawing.Point(0, 3)
        Me.BT_AGREGAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_AGREGAR.Name = "BT_AGREGAR"
        Me.BT_AGREGAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_AGREGAR.TabIndex = 4
        Me.BT_AGREGAR.UseVisualStyleBackColor = True
        '
        'BT_EDITAR
        '
        Me.BT_EDITAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_EDITAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_EDITAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_EDITAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_EDITAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_EDITAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.ICO_BT_EDITAR
        Me.BT_EDITAR.Location = New System.Drawing.Point(70, 3)
        Me.BT_EDITAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_EDITAR.Name = "BT_EDITAR"
        Me.BT_EDITAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_EDITAR.TabIndex = 5
        Me.BT_EDITAR.UseVisualStyleBackColor = True
        '
        'BT_CLONAR
        '
        Me.BT_CLONAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_CLONAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_CLONAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_CLONAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_CLONAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_CLONAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.ICO_BT_CLONAR
        Me.BT_CLONAR.Location = New System.Drawing.Point(140, 3)
        Me.BT_CLONAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_CLONAR.Name = "BT_CLONAR"
        Me.BT_CLONAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_CLONAR.TabIndex = 8
        Me.BT_CLONAR.UseVisualStyleBackColor = True
        '
        'BT_ELIMINAR
        '
        Me.BT_ELIMINAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_ELIMINAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_ELIMINAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_ELIMINAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_ELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_ELIMINAR.ForeColor = System.Drawing.Color.Black
        Me.BT_ELIMINAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.ICO_BT_ELIMINAR
        Me.BT_ELIMINAR.Location = New System.Drawing.Point(210, 3)
        Me.BT_ELIMINAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_ELIMINAR.Name = "BT_ELIMINAR"
        Me.BT_ELIMINAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_ELIMINAR.TabIndex = 6
        Me.BT_ELIMINAR.UseVisualStyleBackColor = True
        '
        'GB_FICHA
        '
        Me.GB_FICHA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GB_FICHA.BackColor = System.Drawing.Color.White
        Me.GB_FICHA.Controls.Add(Me.Label40)
        Me.GB_FICHA.Controls.Add(Me.TB_ESTADO)
        Me.GB_FICHA.Controls.Add(Me.Label36)
        Me.GB_FICHA.Controls.Add(Me.TB_F_VIGENCIA_LICENCIA)
        Me.GB_FICHA.Controls.Add(Me.Label37)
        Me.GB_FICHA.Controls.Add(Me.Label35)
        Me.GB_FICHA.Controls.Add(Me.TB_NUMERO_LICENCIA_OPERADOR)
        Me.GB_FICHA.Controls.Add(Me.Label34)
        Me.GB_FICHA.Controls.Add(Me.TB_NUMERO_INTERIOR)
        Me.GB_FICHA.Controls.Add(Me.Label33)
        Me.GB_FICHA.Controls.Add(Me.TB_NUMERO_EXTERIOR)
        Me.GB_FICHA.Controls.Add(Me.TB_TELEFONO)
        Me.GB_FICHA.Controls.Add(Me.TB_NSS)
        Me.GB_FICHA.Controls.Add(Me.Label28)
        Me.GB_FICHA.Controls.Add(Me.TB_APELLIDO_MATERNO)
        Me.GB_FICHA.Controls.Add(Me.CB_SEXO)
        Me.GB_FICHA.Controls.Add(Me.Label32)
        Me.GB_FICHA.Controls.Add(Me.CB_ESTADO_CIVIL)
        Me.GB_FICHA.Controls.Add(Me.Label31)
        Me.GB_FICHA.Controls.Add(Me.Label29)
        Me.GB_FICHA.Controls.Add(Me.Label30)
        Me.GB_FICHA.Controls.Add(Me.TB_APELLIDO_PATERNO)
        Me.GB_FICHA.Controls.Add(Me.TB_NOMBRE)
        Me.GB_FICHA.Controls.Add(Me.Label27)
        Me.GB_FICHA.Controls.Add(Me.Label26)
        Me.GB_FICHA.Controls.Add(Me.TB_SALARIO_DIARIO_INTEGRADO)
        Me.GB_FICHA.Controls.Add(Me.Label25)
        Me.GB_FICHA.Controls.Add(Me.TB_SALARIO_DIARIO)
        Me.GB_FICHA.Controls.Add(Me.Label24)
        Me.GB_FICHA.Controls.Add(Me.TB_MUNICIPIO)
        Me.GB_FICHA.Controls.Add(Me.Label23)
        Me.GB_FICHA.Controls.Add(Me.TB_COLONIA)
        Me.GB_FICHA.Controls.Add(Me.Label22)
        Me.GB_FICHA.Controls.Add(Me.TB_CORREO)
        Me.GB_FICHA.Controls.Add(Me.Label21)
        Me.GB_FICHA.Controls.Add(Me.TB_CALLE)
        Me.GB_FICHA.Controls.Add(Me.Label10)
        Me.GB_FICHA.Controls.Add(Me.TB_F_NACIMIENTO)
        Me.GB_FICHA.Controls.Add(Me.Label20)
        Me.GB_FICHA.Controls.Add(Me.Label18)
        Me.GB_FICHA.Controls.Add(Me.TB_F_INGRESO)
        Me.GB_FICHA.Controls.Add(Me.Label17)
        Me.GB_FICHA.Controls.Add(Me.Label19)
        Me.GB_FICHA.Controls.Add(Me.TB_CP)
        Me.GB_FICHA.Controls.Add(Me.CB_USUARIO_CAMBIO)
        Me.GB_FICHA.Controls.Add(Me.CB_USUARIO_ALTA)
        Me.GB_FICHA.Controls.Add(Me.Label5)
        Me.GB_FICHA.Controls.Add(Me.Label9)
        Me.GB_FICHA.Controls.Add(Me.Label6)
        Me.GB_FICHA.Controls.Add(Me.Label2)
        Me.GB_FICHA.Controls.Add(Me.TB_F_ALTA)
        Me.GB_FICHA.Controls.Add(Me.TB_F_CAMBIO)
        Me.GB_FICHA.Controls.Add(Me.CB_ESTATUS_OPERADOR)
        Me.GB_FICHA.Controls.Add(Me.Label11)
        Me.GB_FICHA.Controls.Add(Me.Label4)
        Me.GB_FICHA.Controls.Add(Me.TB_K_OPERADOR)
        Me.GB_FICHA.Controls.Add(Me.LB_ID)
        Me.GB_FICHA.Controls.Add(Me.Label3)
        Me.GB_FICHA.Controls.Add(Me.Label7)
        Me.GB_FICHA.Controls.Add(Me.Label8)
        Me.GB_FICHA.Controls.Add(Me.TB_CURP)
        Me.GB_FICHA.Controls.Add(Me.TB_C_CHOFER)
        Me.GB_FICHA.Controls.Add(Me.TB_RFC)
        Me.GB_FICHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FICHA.Location = New System.Drawing.Point(212, 167)
        Me.GB_FICHA.Name = "GB_FICHA"
        Me.GB_FICHA.Size = New System.Drawing.Size(583, 402)
        Me.GB_FICHA.TabIndex = 41
        Me.GB_FICHA.TabStop = False
        Me.GB_FICHA.Text = "Ficha"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(181, 197)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(42, 13)
        Me.Label40.TabIndex = 213
        Me.Label40.Text = "Estado"
        Me.Label40.Visible = False
        '
        'TB_ESTADO
        '
        Me.TB_ESTADO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_ESTADO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_ESTADO.Location = New System.Drawing.Point(185, 213)
        Me.TB_ESTADO.MaxLength = 16
        Me.TB_ESTADO.Name = "TB_ESTADO"
        Me.TB_ESTADO.Size = New System.Drawing.Size(150, 22)
        Me.TB_ESTADO.TabIndex = 170
        Me.TB_ESTADO.Tag = ""
        Me.TB_ESTADO.Visible = False
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Segoe UI", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(157, 284)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(65, 12)
        Me.Label36.TabIndex = 211
        Me.Label36.Text = "[dd/mm/aaaa]"
        '
        'TB_F_VIGENCIA_LICENCIA
        '
        Me.TB_F_VIGENCIA_LICENCIA.Location = New System.Drawing.Point(156, 258)
        Me.TB_F_VIGENCIA_LICENCIA.Mask = "00/00/0000"
        Me.TB_F_VIGENCIA_LICENCIA.Name = "TB_F_VIGENCIA_LICENCIA"
        Me.TB_F_VIGENCIA_LICENCIA.Size = New System.Drawing.Size(85, 20)
        Me.TB_F_VIGENCIA_LICENCIA.TabIndex = 210
        Me.TB_F_VIGENCIA_LICENCIA.Tag = ""
        Me.TB_F_VIGENCIA_LICENCIA.ValidatingType = GetType(Date)
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(154, 242)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(103, 13)
        Me.Label37.TabIndex = 210
        Me.Label37.Text = "F Vigencia Licencia"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(29, 240)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(54, 13)
        Me.Label35.TabIndex = 208
        Me.Label35.Text = "#Licencia"
        '
        'TB_NUMERO_LICENCIA_OPERADOR
        '
        Me.TB_NUMERO_LICENCIA_OPERADOR.AccessibleDescription = ""
        Me.TB_NUMERO_LICENCIA_OPERADOR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_NUMERO_LICENCIA_OPERADOR.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NUMERO_LICENCIA_OPERADOR.Location = New System.Drawing.Point(25, 256)
        Me.TB_NUMERO_LICENCIA_OPERADOR.Name = "TB_NUMERO_LICENCIA_OPERADOR"
        Me.TB_NUMERO_LICENCIA_OPERADOR.Size = New System.Drawing.Size(120, 22)
        Me.TB_NUMERO_LICENCIA_OPERADOR.TabIndex = 200
        Me.TB_NUMERO_LICENCIA_OPERADOR.Tag = ""
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(246, 156)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(53, 13)
        Me.Label34.TabIndex = 206
        Me.Label34.Text = "#Exterior"
        '
        'TB_NUMERO_INTERIOR
        '
        Me.TB_NUMERO_INTERIOR.AccessibleDescription = ""
        Me.TB_NUMERO_INTERIOR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_NUMERO_INTERIOR.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NUMERO_INTERIOR.Location = New System.Drawing.Point(247, 172)
        Me.TB_NUMERO_INTERIOR.Name = "TB_NUMERO_INTERIOR"
        Me.TB_NUMERO_INTERIOR.Size = New System.Drawing.Size(50, 22)
        Me.TB_NUMERO_INTERIOR.TabIndex = 130
        Me.TB_NUMERO_INTERIOR.Tag = ""
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(184, 156)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(52, 13)
        Me.Label33.TabIndex = 204
        Me.Label33.Text = "#Interior"
        '
        'TB_NUMERO_EXTERIOR
        '
        Me.TB_NUMERO_EXTERIOR.AccessibleDescription = ""
        Me.TB_NUMERO_EXTERIOR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_NUMERO_EXTERIOR.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NUMERO_EXTERIOR.Location = New System.Drawing.Point(185, 172)
        Me.TB_NUMERO_EXTERIOR.Name = "TB_NUMERO_EXTERIOR"
        Me.TB_NUMERO_EXTERIOR.Size = New System.Drawing.Size(50, 22)
        Me.TB_NUMERO_EXTERIOR.TabIndex = 120
        Me.TB_NUMERO_EXTERIOR.Tag = ""
        '
        'TB_TELEFONO
        '
        Me.TB_TELEFONO.AccessibleDescription = ""
        Me.TB_TELEFONO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_TELEFONO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_TELEFONO.Location = New System.Drawing.Point(344, 213)
        Me.TB_TELEFONO.Name = "TB_TELEFONO"
        Me.TB_TELEFONO.Size = New System.Drawing.Size(120, 22)
        Me.TB_TELEFONO.TabIndex = 180
        Me.TB_TELEFONO.Tag = "1"
        '
        'TB_NSS
        '
        Me.TB_NSS.AccessibleDescription = ""
        Me.TB_NSS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_NSS.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NSS.Location = New System.Drawing.Point(314, 115)
        Me.TB_NSS.Name = "TB_NSS"
        Me.TB_NSS.Size = New System.Drawing.Size(150, 22)
        Me.TB_NSS.TabIndex = 90
        Me.TB_NSS.Tag = "1"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(409, 17)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(97, 13)
        Me.Label28.TabIndex = 199
        Me.Label28.Text = "Apellido Materno"
        '
        'TB_APELLIDO_MATERNO
        '
        Me.TB_APELLIDO_MATERNO.AccessibleDescription = ""
        Me.TB_APELLIDO_MATERNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_APELLIDO_MATERNO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_APELLIDO_MATERNO.Location = New System.Drawing.Point(412, 33)
        Me.TB_APELLIDO_MATERNO.Name = "TB_APELLIDO_MATERNO"
        Me.TB_APELLIDO_MATERNO.Size = New System.Drawing.Size(150, 22)
        Me.TB_APELLIDO_MATERNO.TabIndex = 20
        Me.TB_APELLIDO_MATERNO.Tag = "1"
        '
        'CB_SEXO
        '
        Me.CB_SEXO.FormattingEnabled = True
        Me.CB_SEXO.Location = New System.Drawing.Point(366, 76)
        Me.CB_SEXO.Name = "CB_SEXO"
        Me.CB_SEXO.Size = New System.Drawing.Size(196, 21)
        Me.CB_SEXO.TabIndex = 60
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(363, 60)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(31, 13)
        Me.Label32.TabIndex = 197
        Me.Label32.Text = "Sexo"
        '
        'CB_ESTADO_CIVIL
        '
        Me.CB_ESTADO_CIVIL.FormattingEnabled = True
        Me.CB_ESTADO_CIVIL.Location = New System.Drawing.Point(186, 76)
        Me.CB_ESTADO_CIVIL.Name = "CB_ESTADO_CIVIL"
        Me.CB_ESTADO_CIVIL.Size = New System.Drawing.Size(174, 21)
        Me.CB_ESTADO_CIVIL.TabIndex = 50
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(189, 62)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(62, 13)
        Me.Label31.TabIndex = 195
        Me.Label31.Text = "Estado Civil"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(246, 17)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(93, 13)
        Me.Label29.TabIndex = 190
        Me.Label29.Text = "Apellido Paterno"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(82, 17)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(48, 13)
        Me.Label30.TabIndex = 191
        Me.Label30.Text = "Nombre"
        '
        'TB_APELLIDO_PATERNO
        '
        Me.TB_APELLIDO_PATERNO.AccessibleDescription = ""
        Me.TB_APELLIDO_PATERNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_APELLIDO_PATERNO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_APELLIDO_PATERNO.Location = New System.Drawing.Point(248, 33)
        Me.TB_APELLIDO_PATERNO.Name = "TB_APELLIDO_PATERNO"
        Me.TB_APELLIDO_PATERNO.Size = New System.Drawing.Size(150, 22)
        Me.TB_APELLIDO_PATERNO.TabIndex = 10
        Me.TB_APELLIDO_PATERNO.Tag = "1"
        '
        'TB_NOMBRE
        '
        Me.TB_NOMBRE.AccessibleDescription = ""
        Me.TB_NOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_NOMBRE.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NOMBRE.Location = New System.Drawing.Point(85, 33)
        Me.TB_NOMBRE.Name = "TB_NOMBRE"
        Me.TB_NOMBRE.Size = New System.Drawing.Size(150, 22)
        Me.TB_NOMBRE.TabIndex = 1
        Me.TB_NOMBRE.Tag = "1"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(348, 200)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(49, 13)
        Me.Label27.TabIndex = 188
        Me.Label27.Text = "Teléfono"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(341, 241)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(24, 13)
        Me.Label26.TabIndex = 185
        Me.Label26.Text = "SDI"
        '
        'TB_SALARIO_DIARIO_INTEGRADO
        '
        Me.TB_SALARIO_DIARIO_INTEGRADO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_SALARIO_DIARIO_INTEGRADO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_SALARIO_DIARIO_INTEGRADO.Location = New System.Drawing.Point(344, 256)
        Me.TB_SALARIO_DIARIO_INTEGRADO.MaxLength = 100
        Me.TB_SALARIO_DIARIO_INTEGRADO.Name = "TB_SALARIO_DIARIO_INTEGRADO"
        Me.TB_SALARIO_DIARIO_INTEGRADO.Size = New System.Drawing.Size(75, 22)
        Me.TB_SALARIO_DIARIO_INTEGRADO.TabIndex = 230
        Me.TB_SALARIO_DIARIO_INTEGRADO.Tag = ""
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(257, 241)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(76, 13)
        Me.Label25.TabIndex = 183
        Me.Label25.Text = "Salario Diario"
        '
        'TB_SALARIO_DIARIO
        '
        Me.TB_SALARIO_DIARIO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_SALARIO_DIARIO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_SALARIO_DIARIO.Location = New System.Drawing.Point(260, 256)
        Me.TB_SALARIO_DIARIO.MaxLength = 100
        Me.TB_SALARIO_DIARIO.Name = "TB_SALARIO_DIARIO"
        Me.TB_SALARIO_DIARIO.Size = New System.Drawing.Size(75, 22)
        Me.TB_SALARIO_DIARIO.TabIndex = 220
        Me.TB_SALARIO_DIARIO.Tag = ""
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(28, 197)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(59, 13)
        Me.Label24.TabIndex = 181
        Me.Label24.Text = "Municipio"
        '
        'TB_MUNICIPIO
        '
        Me.TB_MUNICIPIO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_MUNICIPIO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_MUNICIPIO.Location = New System.Drawing.Point(25, 213)
        Me.TB_MUNICIPIO.MaxLength = 16
        Me.TB_MUNICIPIO.Name = "TB_MUNICIPIO"
        Me.TB_MUNICIPIO.Size = New System.Drawing.Size(150, 22)
        Me.TB_MUNICIPIO.TabIndex = 160
        Me.TB_MUNICIPIO.Tag = ""
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(315, 156)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(47, 13)
        Me.Label23.TabIndex = 180
        Me.Label23.Text = "Colonia"
        '
        'TB_COLONIA
        '
        Me.TB_COLONIA.AccessibleDescription = ""
        Me.TB_COLONIA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_COLONIA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_COLONIA.Location = New System.Drawing.Point(314, 172)
        Me.TB_COLONIA.Name = "TB_COLONIA"
        Me.TB_COLONIA.Size = New System.Drawing.Size(150, 22)
        Me.TB_COLONIA.TabIndex = 140
        Me.TB_COLONIA.Tag = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(411, 290)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(42, 13)
        Me.Label22.TabIndex = 178
        Me.Label22.Text = "Correo"
        '
        'TB_CORREO
        '
        Me.TB_CORREO.AccessibleDescription = ""
        Me.TB_CORREO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_CORREO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CORREO.Location = New System.Drawing.Point(412, 306)
        Me.TB_CORREO.Name = "TB_CORREO"
        Me.TB_CORREO.Size = New System.Drawing.Size(150, 22)
        Me.TB_CORREO.TabIndex = 250
        Me.TB_CORREO.Tag = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(23, 156)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(32, 13)
        Me.Label21.TabIndex = 176
        Me.Label21.Text = "Calle"
        '
        'TB_CALLE
        '
        Me.TB_CALLE.AccessibleDescription = ""
        Me.TB_CALLE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_CALLE.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CALLE.Location = New System.Drawing.Point(25, 172)
        Me.TB_CALLE.Name = "TB_CALLE"
        Me.TB_CALLE.Size = New System.Drawing.Size(150, 22)
        Me.TB_CALLE.TabIndex = 110
        Me.TB_CALLE.Tag = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(475, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 12)
        Me.Label10.TabIndex = 174
        Me.Label10.Text = "[dd/mm/aaaa]"
        '
        'TB_F_NACIMIENTO
        '
        Me.TB_F_NACIMIENTO.Location = New System.Drawing.Point(477, 115)
        Me.TB_F_NACIMIENTO.Mask = "00/00/0000"
        Me.TB_F_NACIMIENTO.Name = "TB_F_NACIMIENTO"
        Me.TB_F_NACIMIENTO.Size = New System.Drawing.Size(85, 20)
        Me.TB_F_NACIMIENTO.TabIndex = 100
        Me.TB_F_NACIMIENTO.Tag = ""
        Me.TB_F_NACIMIENTO.ValidatingType = GetType(Date)
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(477, 99)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(74, 13)
        Me.Label20.TabIndex = 172
        Me.Label20.Text = "F Nacimiento"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(476, 239)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 12)
        Me.Label18.TabIndex = 171
        Me.Label18.Text = "[dd/mm/aaaa]"
        '
        'TB_F_INGRESO
        '
        Me.TB_F_INGRESO.Location = New System.Drawing.Point(477, 213)
        Me.TB_F_INGRESO.Mask = "00/00/0000"
        Me.TB_F_INGRESO.Name = "TB_F_INGRESO"
        Me.TB_F_INGRESO.Size = New System.Drawing.Size(85, 20)
        Me.TB_F_INGRESO.TabIndex = 190
        Me.TB_F_INGRESO.Tag = ""
        Me.TB_F_INGRESO.ValidatingType = GetType(Date)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(475, 197)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 13)
        Me.Label17.TabIndex = 168
        Me.Label17.Text = "F Ingreso"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(489, 156)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(20, 13)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = "CP"
        '
        'TB_CP
        '
        Me.TB_CP.AccessibleDescription = ""
        Me.TB_CP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_CP.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CP.Location = New System.Drawing.Point(487, 172)
        Me.TB_CP.Name = "TB_CP"
        Me.TB_CP.Size = New System.Drawing.Size(75, 22)
        Me.TB_CP.TabIndex = 150
        Me.TB_CP.Tag = ""
        '
        'CB_USUARIO_CAMBIO
        '
        Me.CB_USUARIO_CAMBIO.Enabled = False
        Me.CB_USUARIO_CAMBIO.FormattingEnabled = True
        Me.CB_USUARIO_CAMBIO.Location = New System.Drawing.Point(310, 358)
        Me.CB_USUARIO_CAMBIO.Name = "CB_USUARIO_CAMBIO"
        Me.CB_USUARIO_CAMBIO.Size = New System.Drawing.Size(123, 21)
        Me.CB_USUARIO_CAMBIO.TabIndex = 41
        '
        'CB_USUARIO_ALTA
        '
        Me.CB_USUARIO_ALTA.Enabled = False
        Me.CB_USUARIO_ALTA.FormattingEnabled = True
        Me.CB_USUARIO_ALTA.Location = New System.Drawing.Point(25, 358)
        Me.CB_USUARIO_ALTA.Name = "CB_USUARIO_ALTA"
        Me.CB_USUARIO_ALTA.Size = New System.Drawing.Size(123, 21)
        Me.CB_USUARIO_ALTA.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(154, 341)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Fecha Alta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(442, 341)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Ultima modificación"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(274, 342)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Usuario de Ultima Modificación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 343)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Usuario Alta"
        '
        'TB_F_ALTA
        '
        Me.TB_F_ALTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_F_ALTA.Enabled = False
        Me.TB_F_ALTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_F_ALTA.Location = New System.Drawing.Point(154, 357)
        Me.TB_F_ALTA.Name = "TB_F_ALTA"
        Me.TB_F_ALTA.Size = New System.Drawing.Size(123, 22)
        Me.TB_F_ALTA.TabIndex = 34
        '
        'TB_F_CAMBIO
        '
        Me.TB_F_CAMBIO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_F_CAMBIO.Enabled = False
        Me.TB_F_CAMBIO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_F_CAMBIO.Location = New System.Drawing.Point(439, 357)
        Me.TB_F_CAMBIO.Name = "TB_F_CAMBIO"
        Me.TB_F_CAMBIO.Size = New System.Drawing.Size(123, 22)
        Me.TB_F_CAMBIO.TabIndex = 35
        '
        'CB_ESTATUS_OPERADOR
        '
        Me.CB_ESTATUS_OPERADOR.FormattingEnabled = True
        Me.CB_ESTATUS_OPERADOR.Location = New System.Drawing.Point(25, 76)
        Me.CB_ESTATUS_OPERADOR.Name = "CB_ESTATUS_OPERADOR"
        Me.CB_ESTATUS_OPERADOR.Size = New System.Drawing.Size(150, 21)
        Me.CB_ESTATUS_OPERADOR.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(28, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Estatus"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(317, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "NSS"
        '
        'TB_K_OPERADOR
        '
        Me.TB_K_OPERADOR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_K_OPERADOR.Enabled = False
        Me.TB_K_OPERADOR.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_K_OPERADOR.Location = New System.Drawing.Point(25, 33)
        Me.TB_K_OPERADOR.Name = "TB_K_OPERADOR"
        Me.TB_K_OPERADOR.Size = New System.Drawing.Size(50, 22)
        Me.TB_K_OPERADOR.TabIndex = 0
        '
        'LB_ID
        '
        Me.LB_ID.AutoSize = True
        Me.LB_ID.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ID.Location = New System.Drawing.Point(28, 17)
        Me.LB_ID.Name = "LB_ID"
        Me.LB_ID.Size = New System.Drawing.Size(35, 13)
        Me.LB_ID.TabIndex = 19
        Me.LB_ID.Text = "#OPE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "CURP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Comentarios"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(185, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "RFC"
        '
        'TB_CURP
        '
        Me.TB_CURP.AccessibleDescription = ""
        Me.TB_CURP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_CURP.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CURP.Location = New System.Drawing.Point(25, 115)
        Me.TB_CURP.Name = "TB_CURP"
        Me.TB_CURP.Size = New System.Drawing.Size(150, 22)
        Me.TB_CURP.TabIndex = 70
        Me.TB_CURP.Tag = "1"
        '
        'TB_C_CHOFER
        '
        Me.TB_C_CHOFER.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_C_CHOFER.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_C_CHOFER.Location = New System.Drawing.Point(25, 306)
        Me.TB_C_CHOFER.Name = "TB_C_CHOFER"
        Me.TB_C_CHOFER.Size = New System.Drawing.Size(375, 22)
        Me.TB_C_CHOFER.TabIndex = 240
        '
        'TB_RFC
        '
        Me.TB_RFC.AccessibleDescription = ""
        Me.TB_RFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_RFC.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_RFC.Location = New System.Drawing.Point(185, 115)
        Me.TB_RFC.Name = "TB_RFC"
        Me.TB_RFC.Size = New System.Drawing.Size(120, 22)
        Me.TB_RFC.TabIndex = 80
        Me.TB_RFC.Tag = "1"
        '
        'FO_OPERADOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(800, 450)
        Me.ClientSize = New System.Drawing.Size(1056, 605)
        Me.Controls.Add(Me.GB_FICHA)
        Me.Controls.Add(Me.FL_MENU_2)
        Me.Controls.Add(Me.GB_FILTROS)
        Me.Controls.Add(Me.GB_LISTADO)
        Me.Controls.Add(Me.GB_OPERACION)
        Me.Controls.Add(Me.GB_CONTROL)
        Me.Controls.Add(Me.FL_MENU_1)
        Me.Name = "FO_OPERADOR"
        Me.Text = "Choferes"
        Me.GB_FILTROS.ResumeLayout(False)
        Me.GB_FILTROS.PerformLayout()
        Me.GB_LISTADO.ResumeLayout(False)
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_OPERACION.ResumeLayout(False)
        Me.GB_OPERACION.PerformLayout()
        Me.GB_CONTROL.ResumeLayout(False)
        Me.FL_MENU_2.ResumeLayout(False)
        Me.FL_MENU_1.ResumeLayout(False)
        Me.GB_FICHA.ResumeLayout(False)
        Me.GB_FICHA.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents CB_LI_ESTATUS_OPERADOR As ComboBox
    Public WithEvents GB_FILTROS As GroupBox
    Public WithEvents BT_LI_BUSCAR As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
    Public WithEvents TB_LI_BUSCAR As TextBox
    Public WithEvents GB_LISTADO As GroupBox
    Public WithEvents LI_LISTADO As DataGridView
    Public WithEvents LB_RELOJ As Label
    Public WithEvents LB_VERSION As Label
    Public WithEvents TI_RELOJ As Timer
    Public WithEvents BT_SALIR As Button
    Public WithEvents BT_CANCELAR As Button
    Public WithEvents BT_GUARDAR As Button
    Public WithEvents BT_LISTADO As Button
    Public WithEvents BT_ELIMINAR As Button
    Public WithEvents BT_AGREGAR As Button
    Public WithEvents BT_EDITAR As Button
    Public WithEvents GB_OPERACION As GroupBox
    Public WithEvents GB_CONTROL As GroupBox
    Public WithEvents FL_MENU_2 As FlowLayoutPanel
    Public WithEvents FL_MENU_1 As FlowLayoutPanel
    Public WithEvents BT_EXPORTAR_EXCEL As Button
    Public WithEvents LB_RESULTADO As TextBox
    Public WithEvents BT_CLONAR As Button
    Friend WithEvents TB_LI_F_INICIAL As MaskedTextBox
    Friend WithEvents TB_LI_F_FINAL As MaskedTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Public WithEvents CB_LI_SEXO As ComboBox
    Friend WithEvents Label39 As Label
    Public WithEvents CB_LI_ESTADO_CIVIL As ComboBox
    Friend WithEvents Label38 As Label
    Public WithEvents GB_FICHA As GroupBox
    Friend WithEvents Label40 As Label
    Public WithEvents TB_ESTADO As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents TB_F_VIGENCIA_LICENCIA As MaskedTextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Label35 As Label
    Public WithEvents TB_NUMERO_LICENCIA_OPERADOR As TextBox
    Friend WithEvents Label34 As Label
    Public WithEvents TB_NUMERO_INTERIOR As TextBox
    Friend WithEvents Label33 As Label
    Public WithEvents TB_NUMERO_EXTERIOR As TextBox
    Public WithEvents TB_TELEFONO As TextBox
    Public WithEvents TB_NSS As TextBox
    Friend WithEvents Label28 As Label
    Public WithEvents TB_APELLIDO_MATERNO As TextBox
    Public WithEvents CB_SEXO As ComboBox
    Friend WithEvents Label32 As Label
    Public WithEvents CB_ESTADO_CIVIL As ComboBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Public WithEvents TB_APELLIDO_PATERNO As TextBox
    Public WithEvents TB_NOMBRE As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Public WithEvents TB_SALARIO_DIARIO_INTEGRADO As TextBox
    Friend WithEvents Label25 As Label
    Public WithEvents TB_SALARIO_DIARIO As TextBox
    Friend WithEvents Label24 As Label
    Public WithEvents TB_MUNICIPIO As TextBox
    Friend WithEvents Label23 As Label
    Public WithEvents TB_COLONIA As TextBox
    Friend WithEvents Label22 As Label
    Public WithEvents TB_CORREO As TextBox
    Friend WithEvents Label21 As Label
    Public WithEvents TB_CALLE As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TB_F_NACIMIENTO As MaskedTextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TB_F_INGRESO As MaskedTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Public WithEvents TB_CP As TextBox
    Public WithEvents CB_USUARIO_CAMBIO As ComboBox
    Public WithEvents CB_USUARIO_ALTA As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents TB_F_ALTA As TextBox
    Public WithEvents TB_F_CAMBIO As TextBox
    Public WithEvents CB_ESTATUS_OPERADOR As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Public WithEvents TB_K_OPERADOR As TextBox
    Friend WithEvents LB_ID As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Public WithEvents TB_CURP As TextBox
    Public WithEvents TB_C_CHOFER As TextBox
    Public WithEvents TB_RFC As TextBox
End Class
