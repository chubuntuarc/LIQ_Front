<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FO_CREDITO_BANCO
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
        Me.GB_FILTROS = New System.Windows.Forms.GroupBox()
        Me.CB_LI_MOTIVO_CREDITO_BANCARIO = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.CB_LI_RAZON_SOCIAL2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_LI_ESTATUS_CREDITO_BANCARIO = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CB_LI_MONEDA = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CB_LI_BANCO = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CB_LI_TIPO_CREDITO_BANCARIO = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CB_LI_GRUPO_CREDITO = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CB_LI_RAZON_SOCIAL = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BT_LI_BUSCAR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_LI_BUSCAR = New System.Windows.Forms.TextBox()
        Me.LI_LISTADO = New System.Windows.Forms.DataGridView()
        Me.GB_OPERACION = New System.Windows.Forms.GroupBox()
        Me.LB_RESULTADO = New System.Windows.Forms.TextBox()
        Me.GB_LISTADO = New System.Windows.Forms.GroupBox()
        Me.GB_CONTROL = New System.Windows.Forms.GroupBox()
        Me.LB_VERSION = New System.Windows.Forms.Label()
        Me.LB_RELOJ = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_F_ALTA = New System.Windows.Forms.TextBox()
        Me.TB_F_CAMBIO = New System.Windows.Forms.TextBox()
        Me.TB_K_CREDITO_BANCARIO = New System.Windows.Forms.TextBox()
        Me.LB_ID = New System.Windows.Forms.Label()
        Me.TI_RELOJ = New System.Windows.Forms.Timer(Me.components)
        Me.FL_MENU_2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_SALIR = New System.Windows.Forms.Button()
        Me.BT_CANCELAR = New System.Windows.Forms.Button()
        Me.BT_GUARDAR = New System.Windows.Forms.Button()
        Me.BT_LISTADO = New System.Windows.Forms.Button()
        Me.BT_EXPORTAR_EXCEL = New System.Windows.Forms.Button()
        Me.BT_VER_TABLA_AMORTIZACION = New System.Windows.Forms.Button()
        Me.BT_ESTADO_CUENTA = New System.Windows.Forms.Button()
        Me.GB_FICHA = New System.Windows.Forms.GroupBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.DT_F_INICIO = New System.Windows.Forms.MaskedTextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TB_JUSTIFICACION = New System.Windows.Forms.TextBox()
        Me.CB_MOTIVO_CREDITO_BANCARIO = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.CB_RAZON_SOCIAL2 = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.DT_F_AUTORIZACION = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TB_CANTIDAD_PERIODOS = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TB_TASA_INTERES_ANUAL = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TB_MONTO_PRESTAMO = New System.Windows.Forms.TextBox()
        Me.CB_TIPO_CALCULO_CREDITO = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TB_NUMERO_CREDITO = New System.Windows.Forms.TextBox()
        Me.CB_CUENTA_BANCO_PAGO = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CB_ESTATUS_CREDITO_BANCARIO = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CB_MONEDA = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CB_BANCO = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CB_TIPO_CREDITO_BANCARIO = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CB_GRUPO_CREDITO = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CB_RAZON_SOCIAL = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CB_USUARIO_CAMBIO = New System.Windows.Forms.ComboBox()
        Me.CB_USUARIO_ALTA = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_C_CREDITO_BANCARIO = New System.Windows.Forms.TextBox()
        Me.TB_D_CREDITO_BANCARIO = New System.Windows.Forms.TextBox()
        Me.FL_MENU_1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_AGREGAR = New System.Windows.Forms.Button()
        Me.BT_EDITAR = New System.Windows.Forms.Button()
        Me.BT_ELIMINAR = New System.Windows.Forms.Button()
        Me.BT_CLONAR = New System.Windows.Forms.Button()
        Me.GB_FILTROS.SuspendLayout()
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_OPERACION.SuspendLayout()
        Me.GB_LISTADO.SuspendLayout()
        Me.GB_CONTROL.SuspendLayout()
        Me.FL_MENU_2.SuspendLayout()
        Me.GB_FICHA.SuspendLayout()
        Me.FL_MENU_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_FILTROS
        '
        Me.GB_FILTROS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_FILTROS.BackColor = System.Drawing.Color.White
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_MOTIVO_CREDITO_BANCARIO)
        Me.GB_FILTROS.Controls.Add(Me.Label29)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_RAZON_SOCIAL2)
        Me.GB_FILTROS.Controls.Add(Me.Label3)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_ESTATUS_CREDITO_BANCARIO)
        Me.GB_FILTROS.Controls.Add(Me.Label13)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_MONEDA)
        Me.GB_FILTROS.Controls.Add(Me.Label14)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_BANCO)
        Me.GB_FILTROS.Controls.Add(Me.Label10)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_TIPO_CREDITO_BANCARIO)
        Me.GB_FILTROS.Controls.Add(Me.Label12)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_GRUPO_CREDITO)
        Me.GB_FILTROS.Controls.Add(Me.Label4)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_RAZON_SOCIAL)
        Me.GB_FILTROS.Controls.Add(Me.Label11)
        Me.GB_FILTROS.Controls.Add(Me.BT_LI_BUSCAR)
        Me.GB_FILTROS.Controls.Add(Me.Label1)
        Me.GB_FILTROS.Controls.Add(Me.TB_LI_BUSCAR)
        Me.GB_FILTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FILTROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_FILTROS.Location = New System.Drawing.Point(13, 56)
        Me.GB_FILTROS.Name = "GB_FILTROS"
        Me.GB_FILTROS.Size = New System.Drawing.Size(1314, 116)
        Me.GB_FILTROS.TabIndex = 48
        Me.GB_FILTROS.TabStop = False
        Me.GB_FILTROS.Text = "Filtros"
        '
        'CB_LI_MOTIVO_CREDITO_BANCARIO
        '
        Me.CB_LI_MOTIVO_CREDITO_BANCARIO.FormattingEnabled = True
        Me.CB_LI_MOTIVO_CREDITO_BANCARIO.Location = New System.Drawing.Point(527, 82)
        Me.CB_LI_MOTIVO_CREDITO_BANCARIO.Name = "CB_LI_MOTIVO_CREDITO_BANCARIO"
        Me.CB_LI_MOTIVO_CREDITO_BANCARIO.Size = New System.Drawing.Size(169, 21)
        Me.CB_LI_MOTIVO_CREDITO_BANCARIO.TabIndex = 27
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(531, 66)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(84, 13)
        Me.Label29.TabIndex = 26
        Me.Label29.Text = "Motivo Crédito"
        '
        'CB_LI_RAZON_SOCIAL2
        '
        Me.CB_LI_RAZON_SOCIAL2.FormattingEnabled = True
        Me.CB_LI_RAZON_SOCIAL2.Location = New System.Drawing.Point(301, 36)
        Me.CB_LI_RAZON_SOCIAL2.Name = "CB_LI_RAZON_SOCIAL2"
        Me.CB_LI_RAZON_SOCIAL2.Size = New System.Drawing.Size(220, 21)
        Me.CB_LI_RAZON_SOCIAL2.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(304, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Razón Social Beneficiada"
        '
        'CB_LI_ESTATUS_CREDITO_BANCARIO
        '
        Me.CB_LI_ESTATUS_CREDITO_BANCARIO.FormattingEnabled = True
        Me.CB_LI_ESTATUS_CREDITO_BANCARIO.Location = New System.Drawing.Point(412, 82)
        Me.CB_LI_ESTATUS_CREDITO_BANCARIO.Name = "CB_LI_ESTATUS_CREDITO_BANCARIO"
        Me.CB_LI_ESTATUS_CREDITO_BANCARIO.Size = New System.Drawing.Size(109, 21)
        Me.CB_LI_ESTATUS_CREDITO_BANCARIO.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(415, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Estatus"
        '
        'CB_LI_MONEDA
        '
        Me.CB_LI_MONEDA.FormattingEnabled = True
        Me.CB_LI_MONEDA.Location = New System.Drawing.Point(301, 82)
        Me.CB_LI_MONEDA.Name = "CB_LI_MONEDA"
        Me.CB_LI_MONEDA.Size = New System.Drawing.Size(105, 21)
        Me.CB_LI_MONEDA.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(305, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Moneda"
        '
        'CB_LI_BANCO
        '
        Me.CB_LI_BANCO.FormattingEnabled = True
        Me.CB_LI_BANCO.Location = New System.Drawing.Point(145, 82)
        Me.CB_LI_BANCO.Name = "CB_LI_BANCO"
        Me.CB_LI_BANCO.Size = New System.Drawing.Size(150, 21)
        Me.CB_LI_BANCO.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(148, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Banco"
        '
        'CB_LI_TIPO_CREDITO_BANCARIO
        '
        Me.CB_LI_TIPO_CREDITO_BANCARIO.FormattingEnabled = True
        Me.CB_LI_TIPO_CREDITO_BANCARIO.Location = New System.Drawing.Point(12, 82)
        Me.CB_LI_TIPO_CREDITO_BANCARIO.Name = "CB_LI_TIPO_CREDITO_BANCARIO"
        Me.CB_LI_TIPO_CREDITO_BANCARIO.Size = New System.Drawing.Size(128, 21)
        Me.CB_LI_TIPO_CREDITO_BANCARIO.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Tipo de Crédito"
        '
        'CB_LI_GRUPO_CREDITO
        '
        Me.CB_LI_GRUPO_CREDITO.FormattingEnabled = True
        Me.CB_LI_GRUPO_CREDITO.Location = New System.Drawing.Point(527, 36)
        Me.CB_LI_GRUPO_CREDITO.Name = "CB_LI_GRUPO_CREDITO"
        Me.CB_LI_GRUPO_CREDITO.Size = New System.Drawing.Size(169, 21)
        Me.CB_LI_GRUPO_CREDITO.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(530, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Grupo Crédito"
        '
        'CB_LI_RAZON_SOCIAL
        '
        Me.CB_LI_RAZON_SOCIAL.FormattingEnabled = True
        Me.CB_LI_RAZON_SOCIAL.Location = New System.Drawing.Point(145, 36)
        Me.CB_LI_RAZON_SOCIAL.Name = "CB_LI_RAZON_SOCIAL"
        Me.CB_LI_RAZON_SOCIAL.Size = New System.Drawing.Size(150, 21)
        Me.CB_LI_RAZON_SOCIAL.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(148, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(130, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Razón Social Acreditada"
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
        Me.BT_LI_BUSCAR.Location = New System.Drawing.Point(1233, 45)
        Me.BT_LI_BUSCAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_LI_BUSCAR.Name = "BT_LI_BUSCAR"
        Me.BT_LI_BUSCAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_LI_BUSCAR.TabIndex = 3
        Me.BT_LI_BUSCAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_LI_BUSCAR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Buscar"
        '
        'TB_LI_BUSCAR
        '
        Me.TB_LI_BUSCAR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LI_BUSCAR.Location = New System.Drawing.Point(12, 36)
        Me.TB_LI_BUSCAR.Name = "TB_LI_BUSCAR"
        Me.TB_LI_BUSCAR.Size = New System.Drawing.Size(128, 22)
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
        Me.LI_LISTADO.Size = New System.Drawing.Size(1291, 471)
        Me.LI_LISTADO.TabIndex = 2
        '
        'GB_OPERACION
        '
        Me.GB_OPERACION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_OPERACION.BackColor = System.Drawing.Color.White
        Me.GB_OPERACION.Controls.Add(Me.LB_RESULTADO)
        Me.GB_OPERACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_OPERACION.Location = New System.Drawing.Point(13, 690)
        Me.GB_OPERACION.Name = "GB_OPERACION"
        Me.GB_OPERACION.Size = New System.Drawing.Size(868, 52)
        Me.GB_OPERACION.TabIndex = 50
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
        Me.LB_RESULTADO.Location = New System.Drawing.Point(9, 16)
        Me.LB_RESULTADO.Multiline = True
        Me.LB_RESULTADO.Name = "LB_RESULTADO"
        Me.LB_RESULTADO.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.LB_RESULTADO.Size = New System.Drawing.Size(850, 30)
        Me.LB_RESULTADO.TabIndex = 5
        '
        'GB_LISTADO
        '
        Me.GB_LISTADO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_LISTADO.BackColor = System.Drawing.Color.White
        Me.GB_LISTADO.Controls.Add(Me.LI_LISTADO)
        Me.GB_LISTADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_LISTADO.Location = New System.Drawing.Point(13, 178)
        Me.GB_LISTADO.Name = "GB_LISTADO"
        Me.GB_LISTADO.Size = New System.Drawing.Size(1314, 510)
        Me.GB_LISTADO.TabIndex = 49
        Me.GB_LISTADO.TabStop = False
        Me.GB_LISTADO.Text = "Listado"
        '
        'GB_CONTROL
        '
        Me.GB_CONTROL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_CONTROL.BackColor = System.Drawing.Color.White
        Me.GB_CONTROL.Controls.Add(Me.LB_VERSION)
        Me.GB_CONTROL.Controls.Add(Me.LB_RELOJ)
        Me.GB_CONTROL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_CONTROL.Location = New System.Drawing.Point(888, 690)
        Me.GB_CONTROL.Name = "GB_CONTROL"
        Me.GB_CONTROL.Size = New System.Drawing.Size(440, 52)
        Me.GB_CONTROL.TabIndex = 51
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(255, 434)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Fecha Alta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(479, 435)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Usuario de Última Modificación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 435)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Usuario Alta"
        '
        'TB_F_ALTA
        '
        Me.TB_F_ALTA.Enabled = False
        Me.TB_F_ALTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_F_ALTA.Location = New System.Drawing.Point(252, 450)
        Me.TB_F_ALTA.Name = "TB_F_ALTA"
        Me.TB_F_ALTA.Size = New System.Drawing.Size(215, 22)
        Me.TB_F_ALTA.TabIndex = 22
        '
        'TB_F_CAMBIO
        '
        Me.TB_F_CAMBIO.Enabled = False
        Me.TB_F_CAMBIO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_F_CAMBIO.Location = New System.Drawing.Point(701, 451)
        Me.TB_F_CAMBIO.Name = "TB_F_CAMBIO"
        Me.TB_F_CAMBIO.Size = New System.Drawing.Size(215, 22)
        Me.TB_F_CAMBIO.TabIndex = 22
        '
        'TB_K_CREDITO_BANCARIO
        '
        Me.TB_K_CREDITO_BANCARIO.Enabled = False
        Me.TB_K_CREDITO_BANCARIO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_K_CREDITO_BANCARIO.Location = New System.Drawing.Point(30, 43)
        Me.TB_K_CREDITO_BANCARIO.Name = "TB_K_CREDITO_BANCARIO"
        Me.TB_K_CREDITO_BANCARIO.Size = New System.Drawing.Size(138, 22)
        Me.TB_K_CREDITO_BANCARIO.TabIndex = 21
        '
        'LB_ID
        '
        Me.LB_ID.AutoSize = True
        Me.LB_ID.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ID.Location = New System.Drawing.Point(33, 27)
        Me.LB_ID.Name = "LB_ID"
        Me.LB_ID.Size = New System.Drawing.Size(34, 13)
        Me.LB_ID.TabIndex = 19
        Me.LB_ID.Text = "#CRE"
        '
        'TI_RELOJ
        '
        '
        'FL_MENU_2
        '
        Me.FL_MENU_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FL_MENU_2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FL_MENU_2.BackColor = System.Drawing.Color.White
        Me.FL_MENU_2.Controls.Add(Me.BT_SALIR)
        Me.FL_MENU_2.Controls.Add(Me.BT_CANCELAR)
        Me.FL_MENU_2.Controls.Add(Me.BT_GUARDAR)
        Me.FL_MENU_2.Controls.Add(Me.BT_LISTADO)
        Me.FL_MENU_2.Controls.Add(Me.BT_EXPORTAR_EXCEL)
        Me.FL_MENU_2.Controls.Add(Me.BT_VER_TABLA_AMORTIZACION)
        Me.FL_MENU_2.Controls.Add(Me.BT_ESTADO_CUENTA)
        Me.FL_MENU_2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FL_MENU_2.Location = New System.Drawing.Point(795, 8)
        Me.FL_MENU_2.Name = "FL_MENU_2"
        Me.FL_MENU_2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FL_MENU_2.Size = New System.Drawing.Size(532, 40)
        Me.FL_MENU_2.TabIndex = 53
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
        Me.BT_SALIR.Location = New System.Drawing.Point(462, 6)
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
        Me.BT_CANCELAR.Location = New System.Drawing.Point(392, 6)
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
        Me.BT_GUARDAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_accept
        Me.BT_GUARDAR.Location = New System.Drawing.Point(322, 6)
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
        Me.BT_LISTADO.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.listado
        Me.BT_LISTADO.Location = New System.Drawing.Point(249, 6)
        Me.BT_LISTADO.Name = "BT_LISTADO"
        Me.BT_LISTADO.Size = New System.Drawing.Size(70, 34)
        Me.BT_LISTADO.TabIndex = 25
        Me.BT_LISTADO.UseVisualStyleBackColor = False
        '
        'BT_EXPORTAR_EXCEL
        '
        Me.BT_EXPORTAR_EXCEL.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_EXPORTAR_EXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_EXPORTAR_EXCEL.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_export
        Me.BT_EXPORTAR_EXCEL.Location = New System.Drawing.Point(173, 6)
        Me.BT_EXPORTAR_EXCEL.Name = "BT_EXPORTAR_EXCEL"
        Me.BT_EXPORTAR_EXCEL.Size = New System.Drawing.Size(70, 34)
        Me.BT_EXPORTAR_EXCEL.TabIndex = 28
        Me.BT_EXPORTAR_EXCEL.Tag = ""
        Me.BT_EXPORTAR_EXCEL.UseVisualStyleBackColor = True
        '
        'BT_VER_TABLA_AMORTIZACION
        '
        Me.BT_VER_TABLA_AMORTIZACION.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_VER_TABLA_AMORTIZACION.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_VER_TABLA_AMORTIZACION.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.AMORTIZACIONES_opt
        Me.BT_VER_TABLA_AMORTIZACION.Location = New System.Drawing.Point(97, 6)
        Me.BT_VER_TABLA_AMORTIZACION.Name = "BT_VER_TABLA_AMORTIZACION"
        Me.BT_VER_TABLA_AMORTIZACION.Size = New System.Drawing.Size(70, 34)
        Me.BT_VER_TABLA_AMORTIZACION.TabIndex = 29
        Me.BT_VER_TABLA_AMORTIZACION.Tag = "Ver la tabla de amortizacion"
        Me.BT_VER_TABLA_AMORTIZACION.UseVisualStyleBackColor = True
        '
        'BT_ESTADO_CUENTA
        '
        Me.BT_ESTADO_CUENTA.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_ESTADO_CUENTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_ESTADO_CUENTA.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.SOLICITUD1
        Me.BT_ESTADO_CUENTA.Location = New System.Drawing.Point(21, 6)
        Me.BT_ESTADO_CUENTA.Name = "BT_ESTADO_CUENTA"
        Me.BT_ESTADO_CUENTA.Size = New System.Drawing.Size(70, 34)
        Me.BT_ESTADO_CUENTA.TabIndex = 30
        Me.BT_ESTADO_CUENTA.Tag = "Ver Estado de Cuenta"
        Me.BT_ESTADO_CUENTA.UseVisualStyleBackColor = True
        '
        'GB_FICHA
        '
        Me.GB_FICHA.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GB_FICHA.BackColor = System.Drawing.Color.White
        Me.GB_FICHA.Controls.Add(Me.Label33)
        Me.GB_FICHA.Controls.Add(Me.DT_F_INICIO)
        Me.GB_FICHA.Controls.Add(Me.Label32)
        Me.GB_FICHA.Controls.Add(Me.TB_JUSTIFICACION)
        Me.GB_FICHA.Controls.Add(Me.CB_MOTIVO_CREDITO_BANCARIO)
        Me.GB_FICHA.Controls.Add(Me.Label31)
        Me.GB_FICHA.Controls.Add(Me.CB_RAZON_SOCIAL2)
        Me.GB_FICHA.Controls.Add(Me.Label30)
        Me.GB_FICHA.Controls.Add(Me.Label28)
        Me.GB_FICHA.Controls.Add(Me.DT_F_AUTORIZACION)
        Me.GB_FICHA.Controls.Add(Me.Label27)
        Me.GB_FICHA.Controls.Add(Me.Label26)
        Me.GB_FICHA.Controls.Add(Me.TB_CANTIDAD_PERIODOS)
        Me.GB_FICHA.Controls.Add(Me.Label25)
        Me.GB_FICHA.Controls.Add(Me.TB_TASA_INTERES_ANUAL)
        Me.GB_FICHA.Controls.Add(Me.Label24)
        Me.GB_FICHA.Controls.Add(Me.TB_MONTO_PRESTAMO)
        Me.GB_FICHA.Controls.Add(Me.CB_TIPO_CALCULO_CREDITO)
        Me.GB_FICHA.Controls.Add(Me.Label23)
        Me.GB_FICHA.Controls.Add(Me.Label22)
        Me.GB_FICHA.Controls.Add(Me.TB_NUMERO_CREDITO)
        Me.GB_FICHA.Controls.Add(Me.CB_CUENTA_BANCO_PAGO)
        Me.GB_FICHA.Controls.Add(Me.Label21)
        Me.GB_FICHA.Controls.Add(Me.CB_ESTATUS_CREDITO_BANCARIO)
        Me.GB_FICHA.Controls.Add(Me.Label15)
        Me.GB_FICHA.Controls.Add(Me.CB_MONEDA)
        Me.GB_FICHA.Controls.Add(Me.Label16)
        Me.GB_FICHA.Controls.Add(Me.CB_BANCO)
        Me.GB_FICHA.Controls.Add(Me.Label17)
        Me.GB_FICHA.Controls.Add(Me.CB_TIPO_CREDITO_BANCARIO)
        Me.GB_FICHA.Controls.Add(Me.Label18)
        Me.GB_FICHA.Controls.Add(Me.CB_GRUPO_CREDITO)
        Me.GB_FICHA.Controls.Add(Me.Label19)
        Me.GB_FICHA.Controls.Add(Me.CB_RAZON_SOCIAL)
        Me.GB_FICHA.Controls.Add(Me.Label20)
        Me.GB_FICHA.Controls.Add(Me.CB_USUARIO_CAMBIO)
        Me.GB_FICHA.Controls.Add(Me.CB_USUARIO_ALTA)
        Me.GB_FICHA.Controls.Add(Me.Label5)
        Me.GB_FICHA.Controls.Add(Me.Label9)
        Me.GB_FICHA.Controls.Add(Me.Label6)
        Me.GB_FICHA.Controls.Add(Me.Label2)
        Me.GB_FICHA.Controls.Add(Me.TB_F_ALTA)
        Me.GB_FICHA.Controls.Add(Me.TB_F_CAMBIO)
        Me.GB_FICHA.Controls.Add(Me.TB_K_CREDITO_BANCARIO)
        Me.GB_FICHA.Controls.Add(Me.LB_ID)
        Me.GB_FICHA.Controls.Add(Me.Label7)
        Me.GB_FICHA.Controls.Add(Me.Label8)
        Me.GB_FICHA.Controls.Add(Me.TB_C_CREDITO_BANCARIO)
        Me.GB_FICHA.Controls.Add(Me.TB_D_CREDITO_BANCARIO)
        Me.GB_FICHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FICHA.Location = New System.Drawing.Point(188, 179)
        Me.GB_FICHA.Name = "GB_FICHA"
        Me.GB_FICHA.Size = New System.Drawing.Size(960, 498)
        Me.GB_FICHA.TabIndex = 47
        Me.GB_FICHA.TabStop = False
        Me.GB_FICHA.Text = "Ficha"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(590, 316)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(16, 13)
        Me.Label33.TabIndex = 77
        Me.Label33.Text = "%"
        '
        'DT_F_INICIO
        '
        Me.DT_F_INICIO.Culture = New System.Globalization.CultureInfo("es-MX")
        Me.DT_F_INICIO.Location = New System.Drawing.Point(747, 358)
        Me.DT_F_INICIO.Mask = "00/00/0000"
        Me.DT_F_INICIO.Name = "DT_F_INICIO"
        Me.DT_F_INICIO.Size = New System.Drawing.Size(169, 20)
        Me.DT_F_INICIO.TabIndex = 76
        Me.DT_F_INICIO.Tag = "1"
        Me.DT_F_INICIO.ValidatingType = GetType(Date)
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(33, 245)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(70, 13)
        Me.Label32.TabIndex = 75
        Me.Label32.Text = "Justificación"
        '
        'TB_JUSTIFICACION
        '
        Me.TB_JUSTIFICACION.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_JUSTIFICACION.Location = New System.Drawing.Point(30, 261)
        Me.TB_JUSTIFICACION.Name = "TB_JUSTIFICACION"
        Me.TB_JUSTIFICACION.Size = New System.Drawing.Size(886, 22)
        Me.TB_JUSTIFICACION.TabIndex = 74
        Me.TB_JUSTIFICACION.Tag = "1"
        '
        'CB_MOTIVO_CREDITO_BANCARIO
        '
        Me.CB_MOTIVO_CREDITO_BANCARIO.FormattingEnabled = True
        Me.CB_MOTIVO_CREDITO_BANCARIO.Location = New System.Drawing.Point(30, 175)
        Me.CB_MOTIVO_CREDITO_BANCARIO.Name = "CB_MOTIVO_CREDITO_BANCARIO"
        Me.CB_MOTIVO_CREDITO_BANCARIO.Size = New System.Drawing.Size(433, 21)
        Me.CB_MOTIVO_CREDITO_BANCARIO.TabIndex = 73
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(33, 159)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(101, 13)
        Me.Label31.TabIndex = 72
        Me.Label31.Text = "Motivo del crédito"
        '
        'CB_RAZON_SOCIAL2
        '
        Me.CB_RAZON_SOCIAL2.FormattingEnabled = True
        Me.CB_RAZON_SOCIAL2.Location = New System.Drawing.Point(472, 128)
        Me.CB_RAZON_SOCIAL2.Name = "CB_RAZON_SOCIAL2"
        Me.CB_RAZON_SOCIAL2.Size = New System.Drawing.Size(444, 21)
        Me.CB_RAZON_SOCIAL2.TabIndex = 71
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(475, 112)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(135, 13)
        Me.Label30.TabIndex = 70
        Me.Label30.Text = "Razón Social Beneficiada"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(750, 392)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(121, 13)
        Me.Label28.TabIndex = 69
        Me.Label28.Text = "Fecha de Autorización"
        '
        'DT_F_AUTORIZACION
        '
        Me.DT_F_AUTORIZACION.Enabled = False
        Me.DT_F_AUTORIZACION.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_F_AUTORIZACION.Location = New System.Drawing.Point(747, 408)
        Me.DT_F_AUTORIZACION.Name = "DT_F_AUTORIZACION"
        Me.DT_F_AUTORIZACION.Size = New System.Drawing.Size(169, 20)
        Me.DT_F_AUTORIZACION.TabIndex = 68
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(750, 342)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(84, 13)
        Me.Label27.TabIndex = 67
        Me.Label27.Text = "Fecha de Inicio"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(623, 295)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(89, 13)
        Me.Label26.TabIndex = 65
        Me.Label26.Text = "No. de Períodos"
        '
        'TB_CANTIDAD_PERIODOS
        '
        Me.TB_CANTIDAD_PERIODOS.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CANTIDAD_PERIODOS.Location = New System.Drawing.Point(620, 311)
        Me.TB_CANTIDAD_PERIODOS.Name = "TB_CANTIDAD_PERIODOS"
        Me.TB_CANTIDAD_PERIODOS.Size = New System.Drawing.Size(121, 22)
        Me.TB_CANTIDAD_PERIODOS.TabIndex = 64
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(473, 295)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(115, 13)
        Me.Label25.TabIndex = 63
        Me.Label25.Text = "Tasa de Interés Anual"
        '
        'TB_TASA_INTERES_ANUAL
        '
        Me.TB_TASA_INTERES_ANUAL.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_TASA_INTERES_ANUAL.Location = New System.Drawing.Point(470, 311)
        Me.TB_TASA_INTERES_ANUAL.Name = "TB_TASA_INTERES_ANUAL"
        Me.TB_TASA_INTERES_ANUAL.Size = New System.Drawing.Size(118, 22)
        Me.TB_TASA_INTERES_ANUAL.TabIndex = 62
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(263, 296)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(102, 13)
        Me.Label24.TabIndex = 61
        Me.Label24.Text = "Monto del Crédito"
        '
        'TB_MONTO_PRESTAMO
        '
        Me.TB_MONTO_PRESTAMO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_MONTO_PRESTAMO.Location = New System.Drawing.Point(260, 312)
        Me.TB_MONTO_PRESTAMO.Name = "TB_MONTO_PRESTAMO"
        Me.TB_MONTO_PRESTAMO.Size = New System.Drawing.Size(201, 22)
        Me.TB_MONTO_PRESTAMO.TabIndex = 60
        '
        'CB_TIPO_CALCULO_CREDITO
        '
        Me.CB_TIPO_CALCULO_CREDITO.FormattingEnabled = True
        Me.CB_TIPO_CALCULO_CREDITO.Location = New System.Drawing.Point(747, 311)
        Me.CB_TIPO_CALCULO_CREDITO.Name = "CB_TIPO_CALCULO_CREDITO"
        Me.CB_TIPO_CALCULO_CREDITO.Size = New System.Drawing.Size(169, 21)
        Me.CB_TIPO_CALCULO_CREDITO.TabIndex = 59
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(750, 295)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(86, 13)
        Me.Label23.TabIndex = 58
        Me.Label23.Text = "Tipo de Cálculo"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(30, 296)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(105, 13)
        Me.Label22.TabIndex = 57
        Me.Label22.Text = "Número de Crédito"
        '
        'TB_NUMERO_CREDITO
        '
        Me.TB_NUMERO_CREDITO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NUMERO_CREDITO.Location = New System.Drawing.Point(28, 312)
        Me.TB_NUMERO_CREDITO.Name = "TB_NUMERO_CREDITO"
        Me.TB_NUMERO_CREDITO.Size = New System.Drawing.Size(226, 22)
        Me.TB_NUMERO_CREDITO.TabIndex = 56
        '
        'CB_CUENTA_BANCO_PAGO
        '
        Me.CB_CUENTA_BANCO_PAGO.FormattingEnabled = True
        Me.CB_CUENTA_BANCO_PAGO.Location = New System.Drawing.Point(472, 217)
        Me.CB_CUENTA_BANCO_PAGO.Name = "CB_CUENTA_BANCO_PAGO"
        Me.CB_CUENTA_BANCO_PAGO.Size = New System.Drawing.Size(269, 21)
        Me.CB_CUENTA_BANCO_PAGO.TabIndex = 55
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(475, 201)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(91, 13)
        Me.Label21.TabIndex = 54
        Me.Label21.Text = "Cuenta Bancaria"
        '
        'CB_ESTATUS_CREDITO_BANCARIO
        '
        Me.CB_ESTATUS_CREDITO_BANCARIO.FormattingEnabled = True
        Me.CB_ESTATUS_CREDITO_BANCARIO.Location = New System.Drawing.Point(620, 407)
        Me.CB_ESTATUS_CREDITO_BANCARIO.Name = "CB_ESTATUS_CREDITO_BANCARIO"
        Me.CB_ESTATUS_CREDITO_BANCARIO.Size = New System.Drawing.Size(121, 21)
        Me.CB_ESTATUS_CREDITO_BANCARIO.TabIndex = 53
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(623, 391)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Estatus"
        '
        'CB_MONEDA
        '
        Me.CB_MONEDA.FormattingEnabled = True
        Me.CB_MONEDA.Location = New System.Drawing.Point(747, 217)
        Me.CB_MONEDA.Name = "CB_MONEDA"
        Me.CB_MONEDA.Size = New System.Drawing.Size(169, 21)
        Me.CB_MONEDA.TabIndex = 51
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(750, 201)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Moneda"
        '
        'CB_BANCO
        '
        Me.CB_BANCO.FormattingEnabled = True
        Me.CB_BANCO.Location = New System.Drawing.Point(30, 217)
        Me.CB_BANCO.Name = "CB_BANCO"
        Me.CB_BANCO.Size = New System.Drawing.Size(433, 21)
        Me.CB_BANCO.TabIndex = 49
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(33, 201)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 13)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "Banco"
        '
        'CB_TIPO_CREDITO_BANCARIO
        '
        Me.CB_TIPO_CREDITO_BANCARIO.FormattingEnabled = True
        Me.CB_TIPO_CREDITO_BANCARIO.Location = New System.Drawing.Point(747, 175)
        Me.CB_TIPO_CREDITO_BANCARIO.Name = "CB_TIPO_CREDITO_BANCARIO"
        Me.CB_TIPO_CREDITO_BANCARIO.Size = New System.Drawing.Size(169, 21)
        Me.CB_TIPO_CREDITO_BANCARIO.TabIndex = 47
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(750, 159)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 13)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Tipo de Crédito"
        '
        'CB_GRUPO_CREDITO
        '
        Me.CB_GRUPO_CREDITO.FormattingEnabled = True
        Me.CB_GRUPO_CREDITO.Location = New System.Drawing.Point(472, 175)
        Me.CB_GRUPO_CREDITO.Name = "CB_GRUPO_CREDITO"
        Me.CB_GRUPO_CREDITO.Size = New System.Drawing.Size(269, 21)
        Me.CB_GRUPO_CREDITO.TabIndex = 45
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(475, 159)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 13)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Grupo Crédito"
        '
        'CB_RAZON_SOCIAL
        '
        Me.CB_RAZON_SOCIAL.FormattingEnabled = True
        Me.CB_RAZON_SOCIAL.Location = New System.Drawing.Point(30, 128)
        Me.CB_RAZON_SOCIAL.Name = "CB_RAZON_SOCIAL"
        Me.CB_RAZON_SOCIAL.Size = New System.Drawing.Size(433, 21)
        Me.CB_RAZON_SOCIAL.TabIndex = 43
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(33, 112)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(130, 13)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "Razón Social Acreditada"
        '
        'CB_USUARIO_CAMBIO
        '
        Me.CB_USUARIO_CAMBIO.Enabled = False
        Me.CB_USUARIO_CAMBIO.FormattingEnabled = True
        Me.CB_USUARIO_CAMBIO.Location = New System.Drawing.Point(476, 451)
        Me.CB_USUARIO_CAMBIO.Name = "CB_USUARIO_CAMBIO"
        Me.CB_USUARIO_CAMBIO.Size = New System.Drawing.Size(215, 21)
        Me.CB_USUARIO_CAMBIO.TabIndex = 25
        '
        'CB_USUARIO_ALTA
        '
        Me.CB_USUARIO_ALTA.Enabled = False
        Me.CB_USUARIO_ALTA.FormattingEnabled = True
        Me.CB_USUARIO_ALTA.Location = New System.Drawing.Point(30, 450)
        Me.CB_USUARIO_ALTA.Name = "CB_USUARIO_ALTA"
        Me.CB_USUARIO_ALTA.Size = New System.Drawing.Size(215, 21)
        Me.CB_USUARIO_ALTA.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(704, 435)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Última Modificación"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Comentarios"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(177, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Descripción"
        '
        'TB_C_CREDITO_BANCARIO
        '
        Me.TB_C_CREDITO_BANCARIO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_C_CREDITO_BANCARIO.Location = New System.Drawing.Point(30, 85)
        Me.TB_C_CREDITO_BANCARIO.Name = "TB_C_CREDITO_BANCARIO"
        Me.TB_C_CREDITO_BANCARIO.Size = New System.Drawing.Size(886, 22)
        Me.TB_C_CREDITO_BANCARIO.TabIndex = 10
        '
        'TB_D_CREDITO_BANCARIO
        '
        Me.TB_D_CREDITO_BANCARIO.AccessibleDescription = ""
        Me.TB_D_CREDITO_BANCARIO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_D_CREDITO_BANCARIO.Location = New System.Drawing.Point(174, 43)
        Me.TB_D_CREDITO_BANCARIO.Name = "TB_D_CREDITO_BANCARIO"
        Me.TB_D_CREDITO_BANCARIO.Size = New System.Drawing.Size(742, 22)
        Me.TB_D_CREDITO_BANCARIO.TabIndex = 8
        Me.TB_D_CREDITO_BANCARIO.Tag = "1"
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
        Me.FL_MENU_1.Size = New System.Drawing.Size(810, 40)
        Me.FL_MENU_1.TabIndex = 52
        '
        'BT_AGREGAR
        '
        Me.BT_AGREGAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_AGREGAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_AGREGAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_AGREGAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_AGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_AGREGAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_1add
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
        Me.BT_EDITAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_edit
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
        Me.BT_ELIMINAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_delete
        Me.BT_ELIMINAR.Location = New System.Drawing.Point(210, 3)
        Me.BT_ELIMINAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_ELIMINAR.Name = "BT_ELIMINAR"
        Me.BT_ELIMINAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_ELIMINAR.TabIndex = 6
        Me.BT_ELIMINAR.UseVisualStyleBackColor = True
        '
        'BT_CLONAR
        '
        Me.BT_CLONAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_CLONAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_CLONAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_CLONAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_CLONAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_CLONAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.adn_icon
        Me.BT_CLONAR.Location = New System.Drawing.Point(140, 3)
        Me.BT_CLONAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_CLONAR.Name = "BT_CLONAR"
        Me.BT_CLONAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_CLONAR.TabIndex = 8
        Me.BT_CLONAR.UseVisualStyleBackColor = True
        '
        'FO_CREDITO_BANCO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(1000, 480)
        Me.ClientSize = New System.Drawing.Size(1342, 749)
        Me.Controls.Add(Me.FL_MENU_2)
        Me.Controls.Add(Me.GB_FICHA)
        Me.Controls.Add(Me.GB_FILTROS)
        Me.Controls.Add(Me.GB_OPERACION)
        Me.Controls.Add(Me.GB_LISTADO)
        Me.Controls.Add(Me.GB_CONTROL)
        Me.Controls.Add(Me.FL_MENU_1)
        Me.DoubleBuffered = True
        Me.Name = "FO_CREDITO_BANCO"
        Me.Text = "Credito Banco"
        Me.GB_FILTROS.ResumeLayout(False)
        Me.GB_FILTROS.PerformLayout()
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_OPERACION.ResumeLayout(False)
        Me.GB_OPERACION.PerformLayout()
        Me.GB_LISTADO.ResumeLayout(False)
        Me.GB_CONTROL.ResumeLayout(False)
        Me.FL_MENU_2.ResumeLayout(False)
        Me.GB_FICHA.ResumeLayout(False)
        Me.GB_FICHA.PerformLayout()
        Me.FL_MENU_1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents BT_ELIMINAR As Button
    Public WithEvents GB_FILTROS As GroupBox
    Public WithEvents BT_LI_BUSCAR As Button
    Friend WithEvents Label1 As Label
    Public WithEvents TB_LI_BUSCAR As TextBox
    Public WithEvents LI_LISTADO As DataGridView
    Public WithEvents GB_LISTADO As GroupBox
    Public WithEvents GB_FICHA As GroupBox
    Public WithEvents CB_USUARIO_CAMBIO As ComboBox
    Public WithEvents CB_USUARIO_ALTA As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents TB_F_ALTA As TextBox
    Public WithEvents TB_F_CAMBIO As TextBox
    Public WithEvents TB_K_CREDITO_BANCARIO As TextBox
    Friend WithEvents LB_ID As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Public WithEvents TB_C_CREDITO_BANCARIO As TextBox
    Public WithEvents TB_D_CREDITO_BANCARIO As TextBox
    Public WithEvents LB_VERSION As Label
    Public WithEvents LB_RELOJ As Label
    Public WithEvents BT_SALIR As Button
    Public WithEvents BT_CANCELAR As Button
    Public WithEvents BT_GUARDAR As Button
    Public WithEvents BT_LISTADO As Button
    Public WithEvents BT_AGREGAR As Button
    Public WithEvents BT_EDITAR As Button
    Public WithEvents TI_RELOJ As Timer
    Public WithEvents CB_LI_RAZON_SOCIAL As ComboBox
    Friend WithEvents Label11 As Label
    Public WithEvents CB_LI_ESTATUS_CREDITO_BANCARIO As ComboBox
    Friend WithEvents Label13 As Label
    Public WithEvents CB_LI_MONEDA As ComboBox
    Friend WithEvents Label14 As Label
    Public WithEvents CB_LI_BANCO As ComboBox
    Friend WithEvents Label10 As Label
    Public WithEvents CB_LI_TIPO_CREDITO_BANCARIO As ComboBox
    Friend WithEvents Label12 As Label
    Public WithEvents CB_LI_GRUPO_CREDITO As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label26 As Label
    Public WithEvents TB_CANTIDAD_PERIODOS As TextBox
    Friend WithEvents Label25 As Label
    Public WithEvents TB_TASA_INTERES_ANUAL As TextBox
    Friend WithEvents Label24 As Label
    Public WithEvents TB_MONTO_PRESTAMO As TextBox
    Public WithEvents CB_TIPO_CALCULO_CREDITO As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Public WithEvents TB_NUMERO_CREDITO As TextBox
    Public WithEvents CB_CUENTA_BANCO_PAGO As ComboBox
    Friend WithEvents Label21 As Label
    Public WithEvents CB_ESTATUS_CREDITO_BANCARIO As ComboBox
    Friend WithEvents Label15 As Label
    Public WithEvents CB_MONEDA As ComboBox
    Friend WithEvents Label16 As Label
    Public WithEvents CB_BANCO As ComboBox
    Friend WithEvents Label17 As Label
    Public WithEvents CB_TIPO_CREDITO_BANCARIO As ComboBox
    Friend WithEvents Label18 As Label
    Public WithEvents CB_GRUPO_CREDITO As ComboBox
    Friend WithEvents Label19 As Label
    Public WithEvents CB_RAZON_SOCIAL As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents DT_F_AUTORIZACION As DateTimePicker
    Friend WithEvents Label27 As Label
    Public WithEvents CB_LI_MOTIVO_CREDITO_BANCARIO As ComboBox
    Friend WithEvents Label29 As Label
    Public WithEvents CB_LI_RAZON_SOCIAL2 As ComboBox
    Friend WithEvents Label3 As Label
    Public WithEvents CB_RAZON_SOCIAL2 As ComboBox
    Friend WithEvents Label30 As Label
    Public WithEvents CB_MOTIVO_CREDITO_BANCARIO As ComboBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Public WithEvents TB_JUSTIFICACION As TextBox
    Friend WithEvents DT_F_INICIO As MaskedTextBox
    Friend WithEvents Label33 As Label
    Public WithEvents GB_OPERACION As GroupBox
    Public WithEvents GB_CONTROL As GroupBox
    Public WithEvents FL_MENU_2 As FlowLayoutPanel
    Public WithEvents FL_MENU_1 As FlowLayoutPanel
    Public WithEvents LB_RESULTADO As TextBox
    Public WithEvents BT_EXPORTAR_EXCEL As Button
    Public WithEvents BT_VER_TABLA_AMORTIZACION As Button
    Public WithEvents BT_ESTADO_CUENTA As Button
    Public WithEvents BT_CLONAR As Button
End Class
