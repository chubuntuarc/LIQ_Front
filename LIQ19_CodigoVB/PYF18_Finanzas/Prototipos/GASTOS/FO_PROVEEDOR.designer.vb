<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FO_PROVEEDOR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FO_PROVEEDOR))
        Me.CB_LI_ESTATUS_PROVEEDOR = New System.Windows.Forms.ComboBox()
        Me.GB_FILTROS = New System.Windows.Forms.GroupBox()
        Me.CB_LI_OFICINA_ESTADO = New System.Windows.Forms.ComboBox()
        Me.CB_LI_FISCAL_ESTADO = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CB_LI_CATEGORIA_PROVEEDOR = New System.Windows.Forms.ComboBox()
        Me.BT_LI_BUSCAR = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_LI_BUSCAR = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.GB_LISTADO = New System.Windows.Forms.GroupBox()
        Me.LI_LISTADO = New System.Windows.Forms.DataGridView()
        Me.GB_OPERACION = New System.Windows.Forms.GroupBox()
        Me.LB_RESULTADO = New System.Windows.Forms.TextBox()
        Me.LB_RELOJ = New System.Windows.Forms.Label()
        Me.GB_CONTROL = New System.Windows.Forms.GroupBox()
        Me.LB_VERSION = New System.Windows.Forms.Label()
        Me.TB_K_PROVEEDOR = New System.Windows.Forms.TextBox()
        Me.LB_ID = New System.Windows.Forms.Label()
        Me.TI_RELOJ = New System.Windows.Forms.Timer(Me.components)
        Me.FL_MENU_2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_SALIR = New System.Windows.Forms.Button()
        Me.BT_CANCELAR = New System.Windows.Forms.Button()
        Me.BT_GUARDAR = New System.Windows.Forms.Button()
        Me.BT_LISTADO = New System.Windows.Forms.Button()
        Me.BT_EXPORTAR_EXCEL = New System.Windows.Forms.Button()
        Me.GB_FICHA = New System.Windows.Forms.GroupBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.TB_N_DIAS_CREDITO = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.CB_OFICINA_ESTADO = New System.Windows.Forms.ComboBox()
        Me.TB_OFICINA_MUNICIPIO = New System.Windows.Forms.TextBox()
        Me.TB_OFICINA_POBLACION = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.CB_FISCAL_ESTADO = New System.Windows.Forms.ComboBox()
        Me.TB_OFICINA_CP = New System.Windows.Forms.TextBox()
        Me.TB_OFICINA_COLONIA = New System.Windows.Forms.TextBox()
        Me.TB_OFICINA_NUMERO_INTERIOR = New System.Windows.Forms.TextBox()
        Me.TB_OFICINA_NUMERO_EXTERIOR = New System.Windows.Forms.TextBox()
        Me.TB_OFICINA_CALLE = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.TB_CONTACTO_PAGO_CORREO = New System.Windows.Forms.TextBox()
        Me.TB_CONTACTO_PAGO_TELEFONO = New System.Windows.Forms.TextBox()
        Me.TB_CONTACTO_PAGO = New System.Windows.Forms.TextBox()
        Me.CB_USUARIO_ALTA = New System.Windows.Forms.ComboBox()
        Me.CB_USUARIO_CAMBIO = New System.Windows.Forms.ComboBox()
        Me.TB_F_ALTA = New System.Windows.Forms.TextBox()
        Me.TB_F_CAMBIO = New System.Windows.Forms.TextBox()
        Me.TB_CONTACTO_VENTA_CORREO = New System.Windows.Forms.TextBox()
        Me.TB_CONTACTO_VENTA_TELEFONO = New System.Windows.Forms.TextBox()
        Me.TB_CONTACTO_VENTA = New System.Windows.Forms.TextBox()
        Me.TB_CURP = New System.Windows.Forms.TextBox()
        Me.TB_FISCAL_MUNICIPIO = New System.Windows.Forms.TextBox()
        Me.TB_FISCAL_POBLACION = New System.Windows.Forms.TextBox()
        Me.TB_S_PROVEEDOR = New System.Windows.Forms.TextBox()
        Me.TB_FISCAL_CP = New System.Windows.Forms.TextBox()
        Me.TB_FISCAL_COLONIA = New System.Windows.Forms.TextBox()
        Me.TB_FISCAL_NUMERO_INTERIOR = New System.Windows.Forms.TextBox()
        Me.TB_FISCAL_NUMERO_EXTERIOR = New System.Windows.Forms.TextBox()
        Me.TB_FISCAL_CALLE = New System.Windows.Forms.TextBox()
        Me.CB_ESTATUS_PROVEEDOR = New System.Windows.Forms.ComboBox()
        Me.TB_TELEFONO = New System.Windows.Forms.TextBox()
        Me.TB_CORREO = New System.Windows.Forms.TextBox()
        Me.TB_C_PROVEEDOR = New System.Windows.Forms.TextBox()
        Me.CB_CATEGORIA_PROVEEDOR = New System.Windows.Forms.ComboBox()
        Me.TB_RFC_PROVEEDOR = New System.Windows.Forms.TextBox()
        Me.TB_RAZON_SOCIAL = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_D_PROVEEDOR = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BT_ELIMINAR = New System.Windows.Forms.Button()
        Me.FL_MENU_1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_AGREGAR = New System.Windows.Forms.Button()
        Me.BT_EDITAR = New System.Windows.Forms.Button()
        Me.BT_CLONAR = New System.Windows.Forms.Button()
        Me.GB_FILTROS.SuspendLayout()
        Me.GB_LISTADO.SuspendLayout()
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_OPERACION.SuspendLayout()
        Me.GB_CONTROL.SuspendLayout()
        Me.FL_MENU_2.SuspendLayout()
        Me.GB_FICHA.SuspendLayout()
        Me.FL_MENU_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CB_LI_ESTATUS_PROVEEDOR
        '
        Me.CB_LI_ESTATUS_PROVEEDOR.FormattingEnabled = True
        Me.CB_LI_ESTATUS_PROVEEDOR.Location = New System.Drawing.Point(239, 30)
        Me.CB_LI_ESTATUS_PROVEEDOR.Name = "CB_LI_ESTATUS_PROVEEDOR"
        Me.CB_LI_ESTATUS_PROVEEDOR.Size = New System.Drawing.Size(155, 21)
        Me.CB_LI_ESTATUS_PROVEEDOR.TabIndex = 9
        '
        'GB_FILTROS
        '
        Me.GB_FILTROS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_FILTROS.BackColor = System.Drawing.Color.White
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_OFICINA_ESTADO)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_FISCAL_ESTADO)
        Me.GB_FILTROS.Controls.Add(Me.Label16)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_ESTATUS_PROVEEDOR)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_CATEGORIA_PROVEEDOR)
        Me.GB_FILTROS.Controls.Add(Me.BT_LI_BUSCAR)
        Me.GB_FILTROS.Controls.Add(Me.Label13)
        Me.GB_FILTROS.Controls.Add(Me.Label14)
        Me.GB_FILTROS.Controls.Add(Me.Label1)
        Me.GB_FILTROS.Controls.Add(Me.TB_LI_BUSCAR)
        Me.GB_FILTROS.Controls.Add(Me.Label39)
        Me.GB_FILTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FILTROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_FILTROS.Location = New System.Drawing.Point(13, 56)
        Me.GB_FILTROS.Name = "GB_FILTROS"
        Me.GB_FILTROS.Size = New System.Drawing.Size(1271, 94)
        Me.GB_FILTROS.TabIndex = 34
        Me.GB_FILTROS.TabStop = False
        Me.GB_FILTROS.Text = "Filtros"
        '
        'CB_LI_OFICINA_ESTADO
        '
        Me.CB_LI_OFICINA_ESTADO.FormattingEnabled = True
        Me.CB_LI_OFICINA_ESTADO.Location = New System.Drawing.Point(722, 29)
        Me.CB_LI_OFICINA_ESTADO.Name = "CB_LI_OFICINA_ESTADO"
        Me.CB_LI_OFICINA_ESTADO.Size = New System.Drawing.Size(155, 21)
        Me.CB_LI_OFICINA_ESTADO.TabIndex = 35
        '
        'CB_LI_FISCAL_ESTADO
        '
        Me.CB_LI_FISCAL_ESTADO.FormattingEnabled = True
        Me.CB_LI_FISCAL_ESTADO.Location = New System.Drawing.Point(561, 29)
        Me.CB_LI_FISCAL_ESTADO.Name = "CB_LI_FISCAL_ESTADO"
        Me.CB_LI_FISCAL_ESTADO.Size = New System.Drawing.Size(155, 21)
        Me.CB_LI_FISCAL_ESTADO.TabIndex = 33
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(564, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(155, 21)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Estado Dom. Físcal"
        '
        'CB_LI_CATEGORIA_PROVEEDOR
        '
        Me.CB_LI_CATEGORIA_PROVEEDOR.FormattingEnabled = True
        Me.CB_LI_CATEGORIA_PROVEEDOR.Location = New System.Drawing.Point(400, 30)
        Me.CB_LI_CATEGORIA_PROVEEDOR.Name = "CB_LI_CATEGORIA_PROVEEDOR"
        Me.CB_LI_CATEGORIA_PROVEEDOR.Size = New System.Drawing.Size(155, 21)
        Me.CB_LI_CATEGORIA_PROVEEDOR.TabIndex = 31
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
        Me.BT_LI_BUSCAR.Location = New System.Drawing.Point(1190, 30)
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
        Me.Label13.Location = New System.Drawing.Point(243, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Estatus"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(403, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Categoría"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Buscar"
        '
        'TB_LI_BUSCAR
        '
        Me.TB_LI_BUSCAR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LI_BUSCAR.Location = New System.Drawing.Point(7, 29)
        Me.TB_LI_BUSCAR.Name = "TB_LI_BUSCAR"
        Me.TB_LI_BUSCAR.Size = New System.Drawing.Size(226, 22)
        Me.TB_LI_BUSCAR.TabIndex = 1
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(724, 16)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(154, 20)
        Me.Label39.TabIndex = 36
        Me.Label39.Text = "Estado Dom. Oficina"
        '
        'GB_LISTADO
        '
        Me.GB_LISTADO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_LISTADO.BackColor = System.Drawing.Color.White
        Me.GB_LISTADO.Controls.Add(Me.LI_LISTADO)
        Me.GB_LISTADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_LISTADO.Location = New System.Drawing.Point(13, 156)
        Me.GB_LISTADO.Name = "GB_LISTADO"
        Me.GB_LISTADO.Size = New System.Drawing.Size(1271, 493)
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
        Me.LI_LISTADO.Size = New System.Drawing.Size(1248, 454)
        Me.LI_LISTADO.TabIndex = 2
        '
        'GB_OPERACION
        '
        Me.GB_OPERACION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_OPERACION.BackColor = System.Drawing.Color.White
        Me.GB_OPERACION.Controls.Add(Me.LB_RESULTADO)
        Me.GB_OPERACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_OPERACION.Location = New System.Drawing.Point(13, 651)
        Me.GB_OPERACION.Name = "GB_OPERACION"
        Me.GB_OPERACION.Size = New System.Drawing.Size(825, 52)
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
        Me.LB_RESULTADO.Location = New System.Drawing.Point(7, 15)
        Me.LB_RESULTADO.Multiline = True
        Me.LB_RESULTADO.Name = "LB_RESULTADO"
        Me.LB_RESULTADO.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.LB_RESULTADO.Size = New System.Drawing.Size(806, 30)
        Me.LB_RESULTADO.TabIndex = 5
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
        Me.GB_CONTROL.Location = New System.Drawing.Point(845, 651)
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
        'TB_K_PROVEEDOR
        '
        Me.TB_K_PROVEEDOR.Enabled = False
        Me.TB_K_PROVEEDOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_K_PROVEEDOR.Location = New System.Drawing.Point(18, 33)
        Me.TB_K_PROVEEDOR.Name = "TB_K_PROVEEDOR"
        Me.TB_K_PROVEEDOR.Size = New System.Drawing.Size(42, 20)
        Me.TB_K_PROVEEDOR.TabIndex = 21
        '
        'LB_ID
        '
        Me.LB_ID.AutoSize = True
        Me.LB_ID.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ID.Location = New System.Drawing.Point(20, 17)
        Me.LB_ID.Name = "LB_ID"
        Me.LB_ID.Size = New System.Drawing.Size(18, 13)
        Me.LB_ID.TabIndex = 19
        Me.LB_ID.Text = "ID"
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
        Me.FL_MENU_2.Location = New System.Drawing.Point(908, 8)
        Me.FL_MENU_2.Name = "FL_MENU_2"
        Me.FL_MENU_2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FL_MENU_2.Size = New System.Drawing.Size(376, 40)
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
        Me.BT_SALIR.Image = Global.PYF18_Finanzas.My.Resources.Resources.rsz_exit
        Me.BT_SALIR.Location = New System.Drawing.Point(306, 6)
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
        Me.BT_CANCELAR.Location = New System.Drawing.Point(236, 6)
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
        Me.BT_GUARDAR.Location = New System.Drawing.Point(166, 6)
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
        Me.BT_LISTADO.Location = New System.Drawing.Point(93, 6)
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
        Me.BT_EXPORTAR_EXCEL.Location = New System.Drawing.Point(17, 6)
        Me.BT_EXPORTAR_EXCEL.Name = "BT_EXPORTAR_EXCEL"
        Me.BT_EXPORTAR_EXCEL.Size = New System.Drawing.Size(70, 34)
        Me.BT_EXPORTAR_EXCEL.TabIndex = 25
        Me.BT_EXPORTAR_EXCEL.Tag = "Exportar a Excel"
        Me.BT_EXPORTAR_EXCEL.UseVisualStyleBackColor = True
        '
        'GB_FICHA
        '
        Me.GB_FICHA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GB_FICHA.BackColor = System.Drawing.Color.White
        Me.GB_FICHA.Controls.Add(Me.Label48)
        Me.GB_FICHA.Controls.Add(Me.Label44)
        Me.GB_FICHA.Controls.Add(Me.Label47)
        Me.GB_FICHA.Controls.Add(Me.Label46)
        Me.GB_FICHA.Controls.Add(Me.Label45)
        Me.GB_FICHA.Controls.Add(Me.Label43)
        Me.GB_FICHA.Controls.Add(Me.TB_N_DIAS_CREDITO)
        Me.GB_FICHA.Controls.Add(Me.Label42)
        Me.GB_FICHA.Controls.Add(Me.CB_OFICINA_ESTADO)
        Me.GB_FICHA.Controls.Add(Me.TB_OFICINA_MUNICIPIO)
        Me.GB_FICHA.Controls.Add(Me.TB_OFICINA_POBLACION)
        Me.GB_FICHA.Controls.Add(Me.Label29)
        Me.GB_FICHA.Controls.Add(Me.Label40)
        Me.GB_FICHA.Controls.Add(Me.Label41)
        Me.GB_FICHA.Controls.Add(Me.CB_FISCAL_ESTADO)
        Me.GB_FICHA.Controls.Add(Me.TB_OFICINA_CP)
        Me.GB_FICHA.Controls.Add(Me.TB_OFICINA_COLONIA)
        Me.GB_FICHA.Controls.Add(Me.TB_OFICINA_NUMERO_INTERIOR)
        Me.GB_FICHA.Controls.Add(Me.TB_OFICINA_NUMERO_EXTERIOR)
        Me.GB_FICHA.Controls.Add(Me.TB_OFICINA_CALLE)
        Me.GB_FICHA.Controls.Add(Me.Label10)
        Me.GB_FICHA.Controls.Add(Me.Label15)
        Me.GB_FICHA.Controls.Add(Me.Label32)
        Me.GB_FICHA.Controls.Add(Me.Label37)
        Me.GB_FICHA.Controls.Add(Me.Label38)
        Me.GB_FICHA.Controls.Add(Me.TB_CONTACTO_PAGO_CORREO)
        Me.GB_FICHA.Controls.Add(Me.TB_CONTACTO_PAGO_TELEFONO)
        Me.GB_FICHA.Controls.Add(Me.TB_CONTACTO_PAGO)
        Me.GB_FICHA.Controls.Add(Me.CB_USUARIO_ALTA)
        Me.GB_FICHA.Controls.Add(Me.CB_USUARIO_CAMBIO)
        Me.GB_FICHA.Controls.Add(Me.TB_F_ALTA)
        Me.GB_FICHA.Controls.Add(Me.TB_F_CAMBIO)
        Me.GB_FICHA.Controls.Add(Me.TB_CONTACTO_VENTA_CORREO)
        Me.GB_FICHA.Controls.Add(Me.TB_CONTACTO_VENTA_TELEFONO)
        Me.GB_FICHA.Controls.Add(Me.TB_CONTACTO_VENTA)
        Me.GB_FICHA.Controls.Add(Me.TB_CURP)
        Me.GB_FICHA.Controls.Add(Me.TB_FISCAL_MUNICIPIO)
        Me.GB_FICHA.Controls.Add(Me.TB_FISCAL_POBLACION)
        Me.GB_FICHA.Controls.Add(Me.TB_S_PROVEEDOR)
        Me.GB_FICHA.Controls.Add(Me.TB_FISCAL_CP)
        Me.GB_FICHA.Controls.Add(Me.TB_FISCAL_COLONIA)
        Me.GB_FICHA.Controls.Add(Me.TB_FISCAL_NUMERO_INTERIOR)
        Me.GB_FICHA.Controls.Add(Me.TB_FISCAL_NUMERO_EXTERIOR)
        Me.GB_FICHA.Controls.Add(Me.TB_FISCAL_CALLE)
        Me.GB_FICHA.Controls.Add(Me.CB_ESTATUS_PROVEEDOR)
        Me.GB_FICHA.Controls.Add(Me.TB_TELEFONO)
        Me.GB_FICHA.Controls.Add(Me.TB_CORREO)
        Me.GB_FICHA.Controls.Add(Me.TB_C_PROVEEDOR)
        Me.GB_FICHA.Controls.Add(Me.CB_CATEGORIA_PROVEEDOR)
        Me.GB_FICHA.Controls.Add(Me.TB_RFC_PROVEEDOR)
        Me.GB_FICHA.Controls.Add(Me.TB_RAZON_SOCIAL)
        Me.GB_FICHA.Controls.Add(Me.Label4)
        Me.GB_FICHA.Controls.Add(Me.TB_D_PROVEEDOR)
        Me.GB_FICHA.Controls.Add(Me.Label8)
        Me.GB_FICHA.Controls.Add(Me.Label36)
        Me.GB_FICHA.Controls.Add(Me.Label35)
        Me.GB_FICHA.Controls.Add(Me.Label33)
        Me.GB_FICHA.Controls.Add(Me.Label34)
        Me.GB_FICHA.Controls.Add(Me.Label30)
        Me.GB_FICHA.Controls.Add(Me.Label31)
        Me.GB_FICHA.Controls.Add(Me.Label28)
        Me.GB_FICHA.Controls.Add(Me.Label27)
        Me.GB_FICHA.Controls.Add(Me.Label26)
        Me.GB_FICHA.Controls.Add(Me.Label25)
        Me.GB_FICHA.Controls.Add(Me.Label24)
        Me.GB_FICHA.Controls.Add(Me.Label23)
        Me.GB_FICHA.Controls.Add(Me.Label22)
        Me.GB_FICHA.Controls.Add(Me.Label21)
        Me.GB_FICHA.Controls.Add(Me.Label20)
        Me.GB_FICHA.Controls.Add(Me.Label19)
        Me.GB_FICHA.Controls.Add(Me.Label18)
        Me.GB_FICHA.Controls.Add(Me.Label17)
        Me.GB_FICHA.Controls.Add(Me.Label12)
        Me.GB_FICHA.Controls.Add(Me.Label11)
        Me.GB_FICHA.Controls.Add(Me.Label5)
        Me.GB_FICHA.Controls.Add(Me.Label9)
        Me.GB_FICHA.Controls.Add(Me.Label6)
        Me.GB_FICHA.Controls.Add(Me.Label2)
        Me.GB_FICHA.Controls.Add(Me.Label3)
        Me.GB_FICHA.Controls.Add(Me.Label7)
        Me.GB_FICHA.Controls.Add(Me.TB_K_PROVEEDOR)
        Me.GB_FICHA.Controls.Add(Me.LB_ID)
        Me.GB_FICHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FICHA.Location = New System.Drawing.Point(90, 181)
        Me.GB_FICHA.Name = "GB_FICHA"
        Me.GB_FICHA.Size = New System.Drawing.Size(1086, 425)
        Me.GB_FICHA.TabIndex = 33
        Me.GB_FICHA.TabStop = False
        Me.GB_FICHA.Text = "Ficha"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(9, 359)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(1114, 13)
        Me.Label48.TabIndex = 210
        Me.Label48.Text = resources.GetString("Label48.Text")
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(9, 299)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(1114, 13)
        Me.Label44.TabIndex = 206
        Me.Label44.Text = resources.GetString("Label44.Text")
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Location = New System.Drawing.Point(540, 149)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(9, 221)
        Me.Label47.TabIndex = 209
        Me.Label47.Text = "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(236, 157)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(95, 13)
        Me.Label46.TabIndex = 208
        Me.Label46.Text = "Domicilio Fiscal"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(770, 156)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(102, 13)
        Me.Label45.TabIndex = 207
        Me.Label45.Text = "Domicilio Oficina"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(9, 141)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(1114, 13)
        Me.Label43.TabIndex = 205
        Me.Label43.Text = resources.GetString("Label43.Text")
        '
        'TB_N_DIAS_CREDITO
        '
        Me.TB_N_DIAS_CREDITO.AccessibleDescription = ""
        Me.TB_N_DIAS_CREDITO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_N_DIAS_CREDITO.Location = New System.Drawing.Point(848, 33)
        Me.TB_N_DIAS_CREDITO.Name = "TB_N_DIAS_CREDITO"
        Me.TB_N_DIAS_CREDITO.Size = New System.Drawing.Size(72, 20)
        Me.TB_N_DIAS_CREDITO.TabIndex = 204
        Me.TB_N_DIAS_CREDITO.Tag = "1"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(851, 17)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(66, 13)
        Me.Label42.TabIndex = 203
        Me.Label42.Text = "Días Crédito"
        '
        'CB_OFICINA_ESTADO
        '
        Me.CB_OFICINA_ESTADO.FormattingEnabled = True
        Me.CB_OFICINA_ESTADO.Location = New System.Drawing.Point(899, 274)
        Me.CB_OFICINA_ESTADO.Name = "CB_OFICINA_ESTADO"
        Me.CB_OFICINA_ESTADO.Size = New System.Drawing.Size(165, 21)
        Me.CB_OFICINA_ESTADO.TabIndex = 202
        '
        'TB_OFICINA_MUNICIPIO
        '
        Me.TB_OFICINA_MUNICIPIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_OFICINA_MUNICIPIO.Location = New System.Drawing.Point(728, 275)
        Me.TB_OFICINA_MUNICIPIO.Name = "TB_OFICINA_MUNICIPIO"
        Me.TB_OFICINA_MUNICIPIO.Size = New System.Drawing.Size(165, 20)
        Me.TB_OFICINA_MUNICIPIO.TabIndex = 201
        Me.TB_OFICINA_MUNICIPIO.Tag = ""
        '
        'TB_OFICINA_POBLACION
        '
        Me.TB_OFICINA_POBLACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_OFICINA_POBLACION.Location = New System.Drawing.Point(557, 275)
        Me.TB_OFICINA_POBLACION.Name = "TB_OFICINA_POBLACION"
        Me.TB_OFICINA_POBLACION.Size = New System.Drawing.Size(165, 20)
        Me.TB_OFICINA_POBLACION.TabIndex = 200
        Me.TB_OFICINA_POBLACION.Tag = ""
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(902, 259)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(40, 13)
        Me.Label29.TabIndex = 199
        Me.Label29.Text = "Estado"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(731, 260)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(52, 13)
        Me.Label40.TabIndex = 198
        Me.Label40.Text = "Municipio"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(560, 259)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(54, 13)
        Me.Label41.TabIndex = 197
        Me.Label41.Text = "Población"
        '
        'CB_FISCAL_ESTADO
        '
        Me.CB_FISCAL_ESTADO.FormattingEnabled = True
        Me.CB_FISCAL_ESTADO.Location = New System.Drawing.Point(362, 274)
        Me.CB_FISCAL_ESTADO.Name = "CB_FISCAL_ESTADO"
        Me.CB_FISCAL_ESTADO.Size = New System.Drawing.Size(165, 21)
        Me.CB_FISCAL_ESTADO.TabIndex = 196
        '
        'TB_OFICINA_CP
        '
        Me.TB_OFICINA_CP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_OFICINA_CP.Location = New System.Drawing.Point(985, 236)
        Me.TB_OFICINA_CP.Name = "TB_OFICINA_CP"
        Me.TB_OFICINA_CP.Size = New System.Drawing.Size(80, 20)
        Me.TB_OFICINA_CP.TabIndex = 195
        Me.TB_OFICINA_CP.Tag = ""
        '
        'TB_OFICINA_COLONIA
        '
        Me.TB_OFICINA_COLONIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_OFICINA_COLONIA.Location = New System.Drawing.Point(557, 236)
        Me.TB_OFICINA_COLONIA.Name = "TB_OFICINA_COLONIA"
        Me.TB_OFICINA_COLONIA.Size = New System.Drawing.Size(423, 20)
        Me.TB_OFICINA_COLONIA.TabIndex = 194
        Me.TB_OFICINA_COLONIA.Tag = ""
        '
        'TB_OFICINA_NUMERO_INTERIOR
        '
        Me.TB_OFICINA_NUMERO_INTERIOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_OFICINA_NUMERO_INTERIOR.Location = New System.Drawing.Point(985, 196)
        Me.TB_OFICINA_NUMERO_INTERIOR.Name = "TB_OFICINA_NUMERO_INTERIOR"
        Me.TB_OFICINA_NUMERO_INTERIOR.Size = New System.Drawing.Size(80, 20)
        Me.TB_OFICINA_NUMERO_INTERIOR.TabIndex = 193
        Me.TB_OFICINA_NUMERO_INTERIOR.Tag = ""
        '
        'TB_OFICINA_NUMERO_EXTERIOR
        '
        Me.TB_OFICINA_NUMERO_EXTERIOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_OFICINA_NUMERO_EXTERIOR.Location = New System.Drawing.Point(899, 196)
        Me.TB_OFICINA_NUMERO_EXTERIOR.Name = "TB_OFICINA_NUMERO_EXTERIOR"
        Me.TB_OFICINA_NUMERO_EXTERIOR.Size = New System.Drawing.Size(80, 20)
        Me.TB_OFICINA_NUMERO_EXTERIOR.TabIndex = 192
        Me.TB_OFICINA_NUMERO_EXTERIOR.Tag = ""
        '
        'TB_OFICINA_CALLE
        '
        Me.TB_OFICINA_CALLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_OFICINA_CALLE.Location = New System.Drawing.Point(557, 196)
        Me.TB_OFICINA_CALLE.Name = "TB_OFICINA_CALLE"
        Me.TB_OFICINA_CALLE.Size = New System.Drawing.Size(336, 20)
        Me.TB_OFICINA_CALLE.TabIndex = 191
        Me.TB_OFICINA_CALLE.Tag = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(988, 220)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 13)
        Me.Label10.TabIndex = 190
        Me.Label10.Text = "CP"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(560, 220)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 13)
        Me.Label15.TabIndex = 189
        Me.Label15.Text = "Colonia"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(988, 180)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(67, 13)
        Me.Label32.TabIndex = 188
        Me.Label32.Text = "Num. Interior"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(902, 180)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(70, 13)
        Me.Label37.TabIndex = 187
        Me.Label37.Text = "Num. Exterior"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(560, 180)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(30, 13)
        Me.Label38.TabIndex = 186
        Me.Label38.Text = "Calle"
        '
        'TB_CONTACTO_PAGO_CORREO
        '
        Me.TB_CONTACTO_PAGO_CORREO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TB_CONTACTO_PAGO_CORREO.Location = New System.Drawing.Point(884, 336)
        Me.TB_CONTACTO_PAGO_CORREO.Name = "TB_CONTACTO_PAGO_CORREO"
        Me.TB_CONTACTO_PAGO_CORREO.Size = New System.Drawing.Size(181, 20)
        Me.TB_CONTACTO_PAGO_CORREO.TabIndex = 183
        '
        'TB_CONTACTO_PAGO_TELEFONO
        '
        Me.TB_CONTACTO_PAGO_TELEFONO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TB_CONTACTO_PAGO_TELEFONO.Location = New System.Drawing.Point(728, 336)
        Me.TB_CONTACTO_PAGO_TELEFONO.Name = "TB_CONTACTO_PAGO_TELEFONO"
        Me.TB_CONTACTO_PAGO_TELEFONO.Size = New System.Drawing.Size(150, 20)
        Me.TB_CONTACTO_PAGO_TELEFONO.TabIndex = 182
        '
        'TB_CONTACTO_PAGO
        '
        Me.TB_CONTACTO_PAGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TB_CONTACTO_PAGO.Location = New System.Drawing.Point(557, 336)
        Me.TB_CONTACTO_PAGO.Name = "TB_CONTACTO_PAGO"
        Me.TB_CONTACTO_PAGO.Size = New System.Drawing.Size(165, 20)
        Me.TB_CONTACTO_PAGO.TabIndex = 181
        '
        'CB_USUARIO_ALTA
        '
        Me.CB_USUARIO_ALTA.Enabled = False
        Me.CB_USUARIO_ALTA.FormattingEnabled = True
        Me.CB_USUARIO_ALTA.Location = New System.Drawing.Point(137, 391)
        Me.CB_USUARIO_ALTA.Name = "CB_USUARIO_ALTA"
        Me.CB_USUARIO_ALTA.Size = New System.Drawing.Size(191, 21)
        Me.CB_USUARIO_ALTA.TabIndex = 180
        '
        'CB_USUARIO_CAMBIO
        '
        Me.CB_USUARIO_CAMBIO.Enabled = False
        Me.CB_USUARIO_CAMBIO.FormattingEnabled = True
        Me.CB_USUARIO_CAMBIO.Location = New System.Drawing.Point(559, 390)
        Me.CB_USUARIO_CAMBIO.Name = "CB_USUARIO_CAMBIO"
        Me.CB_USUARIO_CAMBIO.Size = New System.Drawing.Size(191, 21)
        Me.CB_USUARIO_CAMBIO.TabIndex = 179
        '
        'TB_F_ALTA
        '
        Me.TB_F_ALTA.Enabled = False
        Me.TB_F_ALTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_F_ALTA.Location = New System.Drawing.Point(345, 390)
        Me.TB_F_ALTA.Name = "TB_F_ALTA"
        Me.TB_F_ALTA.Size = New System.Drawing.Size(191, 22)
        Me.TB_F_ALTA.TabIndex = 178
        '
        'TB_F_CAMBIO
        '
        Me.TB_F_CAMBIO.Enabled = False
        Me.TB_F_CAMBIO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_F_CAMBIO.Location = New System.Drawing.Point(767, 389)
        Me.TB_F_CAMBIO.Name = "TB_F_CAMBIO"
        Me.TB_F_CAMBIO.Size = New System.Drawing.Size(191, 22)
        Me.TB_F_CAMBIO.TabIndex = 177
        '
        'TB_CONTACTO_VENTA_CORREO
        '
        Me.TB_CONTACTO_VENTA_CORREO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TB_CONTACTO_VENTA_CORREO.Location = New System.Drawing.Point(347, 337)
        Me.TB_CONTACTO_VENTA_CORREO.Name = "TB_CONTACTO_VENTA_CORREO"
        Me.TB_CONTACTO_VENTA_CORREO.Size = New System.Drawing.Size(179, 20)
        Me.TB_CONTACTO_VENTA_CORREO.TabIndex = 172
        '
        'TB_CONTACTO_VENTA_TELEFONO
        '
        Me.TB_CONTACTO_VENTA_TELEFONO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TB_CONTACTO_VENTA_TELEFONO.Location = New System.Drawing.Point(191, 337)
        Me.TB_CONTACTO_VENTA_TELEFONO.Name = "TB_CONTACTO_VENTA_TELEFONO"
        Me.TB_CONTACTO_VENTA_TELEFONO.Size = New System.Drawing.Size(150, 20)
        Me.TB_CONTACTO_VENTA_TELEFONO.TabIndex = 171
        '
        'TB_CONTACTO_VENTA
        '
        Me.TB_CONTACTO_VENTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TB_CONTACTO_VENTA.Location = New System.Drawing.Point(20, 337)
        Me.TB_CONTACTO_VENTA.Name = "TB_CONTACTO_VENTA"
        Me.TB_CONTACTO_VENTA.Size = New System.Drawing.Size(165, 20)
        Me.TB_CONTACTO_VENTA.TabIndex = 170
        '
        'TB_CURP
        '
        Me.TB_CURP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CURP.Location = New System.Drawing.Point(550, 115)
        Me.TB_CURP.Name = "TB_CURP"
        Me.TB_CURP.Size = New System.Drawing.Size(260, 20)
        Me.TB_CURP.TabIndex = 169
        Me.TB_CURP.Tag = ""
        '
        'TB_FISCAL_MUNICIPIO
        '
        Me.TB_FISCAL_MUNICIPIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FISCAL_MUNICIPIO.Location = New System.Drawing.Point(191, 275)
        Me.TB_FISCAL_MUNICIPIO.Name = "TB_FISCAL_MUNICIPIO"
        Me.TB_FISCAL_MUNICIPIO.Size = New System.Drawing.Size(165, 20)
        Me.TB_FISCAL_MUNICIPIO.TabIndex = 167
        Me.TB_FISCAL_MUNICIPIO.Tag = ""
        '
        'TB_FISCAL_POBLACION
        '
        Me.TB_FISCAL_POBLACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FISCAL_POBLACION.Location = New System.Drawing.Point(20, 275)
        Me.TB_FISCAL_POBLACION.Name = "TB_FISCAL_POBLACION"
        Me.TB_FISCAL_POBLACION.Size = New System.Drawing.Size(165, 20)
        Me.TB_FISCAL_POBLACION.TabIndex = 165
        Me.TB_FISCAL_POBLACION.Tag = ""
        '
        'TB_S_PROVEEDOR
        '
        Me.TB_S_PROVEEDOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_S_PROVEEDOR.Location = New System.Drawing.Point(315, 33)
        Me.TB_S_PROVEEDOR.Name = "TB_S_PROVEEDOR"
        Me.TB_S_PROVEEDOR.Size = New System.Drawing.Size(66, 20)
        Me.TB_S_PROVEEDOR.TabIndex = 163
        Me.TB_S_PROVEEDOR.Tag = ""
        '
        'TB_FISCAL_CP
        '
        Me.TB_FISCAL_CP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FISCAL_CP.Location = New System.Drawing.Point(447, 235)
        Me.TB_FISCAL_CP.Name = "TB_FISCAL_CP"
        Me.TB_FISCAL_CP.Size = New System.Drawing.Size(80, 20)
        Me.TB_FISCAL_CP.TabIndex = 160
        Me.TB_FISCAL_CP.Tag = ""
        '
        'TB_FISCAL_COLONIA
        '
        Me.TB_FISCAL_COLONIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FISCAL_COLONIA.Location = New System.Drawing.Point(20, 235)
        Me.TB_FISCAL_COLONIA.Name = "TB_FISCAL_COLONIA"
        Me.TB_FISCAL_COLONIA.Size = New System.Drawing.Size(422, 20)
        Me.TB_FISCAL_COLONIA.TabIndex = 159
        Me.TB_FISCAL_COLONIA.Tag = ""
        '
        'TB_FISCAL_NUMERO_INTERIOR
        '
        Me.TB_FISCAL_NUMERO_INTERIOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FISCAL_NUMERO_INTERIOR.Location = New System.Drawing.Point(447, 195)
        Me.TB_FISCAL_NUMERO_INTERIOR.Name = "TB_FISCAL_NUMERO_INTERIOR"
        Me.TB_FISCAL_NUMERO_INTERIOR.Size = New System.Drawing.Size(80, 20)
        Me.TB_FISCAL_NUMERO_INTERIOR.TabIndex = 158
        Me.TB_FISCAL_NUMERO_INTERIOR.Tag = ""
        '
        'TB_FISCAL_NUMERO_EXTERIOR
        '
        Me.TB_FISCAL_NUMERO_EXTERIOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FISCAL_NUMERO_EXTERIOR.Location = New System.Drawing.Point(362, 195)
        Me.TB_FISCAL_NUMERO_EXTERIOR.Name = "TB_FISCAL_NUMERO_EXTERIOR"
        Me.TB_FISCAL_NUMERO_EXTERIOR.Size = New System.Drawing.Size(80, 20)
        Me.TB_FISCAL_NUMERO_EXTERIOR.TabIndex = 157
        Me.TB_FISCAL_NUMERO_EXTERIOR.Tag = ""
        '
        'TB_FISCAL_CALLE
        '
        Me.TB_FISCAL_CALLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FISCAL_CALLE.Location = New System.Drawing.Point(20, 195)
        Me.TB_FISCAL_CALLE.Name = "TB_FISCAL_CALLE"
        Me.TB_FISCAL_CALLE.Size = New System.Drawing.Size(336, 20)
        Me.TB_FISCAL_CALLE.TabIndex = 156
        Me.TB_FISCAL_CALLE.Tag = ""
        '
        'CB_ESTATUS_PROVEEDOR
        '
        Me.CB_ESTATUS_PROVEEDOR.FormattingEnabled = True
        Me.CB_ESTATUS_PROVEEDOR.Location = New System.Drawing.Point(926, 32)
        Me.CB_ESTATUS_PROVEEDOR.Name = "CB_ESTATUS_PROVEEDOR"
        Me.CB_ESTATUS_PROVEEDOR.Size = New System.Drawing.Size(139, 21)
        Me.CB_ESTATUS_PROVEEDOR.TabIndex = 155
        '
        'TB_TELEFONO
        '
        Me.TB_TELEFONO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_TELEFONO.Location = New System.Drawing.Point(285, 115)
        Me.TB_TELEFONO.Name = "TB_TELEFONO"
        Me.TB_TELEFONO.Size = New System.Drawing.Size(260, 20)
        Me.TB_TELEFONO.TabIndex = 154
        '
        'TB_CORREO
        '
        Me.TB_CORREO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CORREO.Location = New System.Drawing.Point(20, 115)
        Me.TB_CORREO.Name = "TB_CORREO"
        Me.TB_CORREO.Size = New System.Drawing.Size(260, 20)
        Me.TB_CORREO.TabIndex = 153
        '
        'TB_C_PROVEEDOR
        '
        Me.TB_C_PROVEEDOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_C_PROVEEDOR.Location = New System.Drawing.Point(18, 74)
        Me.TB_C_PROVEEDOR.Name = "TB_C_PROVEEDOR"
        Me.TB_C_PROVEEDOR.Size = New System.Drawing.Size(1047, 20)
        Me.TB_C_PROVEEDOR.TabIndex = 152
        '
        'CB_CATEGORIA_PROVEEDOR
        '
        Me.CB_CATEGORIA_PROVEEDOR.FormattingEnabled = True
        Me.CB_CATEGORIA_PROVEEDOR.Location = New System.Drawing.Point(815, 114)
        Me.CB_CATEGORIA_PROVEEDOR.Name = "CB_CATEGORIA_PROVEEDOR"
        Me.CB_CATEGORIA_PROVEEDOR.Size = New System.Drawing.Size(250, 21)
        Me.CB_CATEGORIA_PROVEEDOR.TabIndex = 151
        '
        'TB_RFC_PROVEEDOR
        '
        Me.TB_RFC_PROVEEDOR.AccessibleDescription = ""
        Me.TB_RFC_PROVEEDOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_RFC_PROVEEDOR.Location = New System.Drawing.Point(703, 33)
        Me.TB_RFC_PROVEEDOR.Name = "TB_RFC_PROVEEDOR"
        Me.TB_RFC_PROVEEDOR.Size = New System.Drawing.Size(139, 20)
        Me.TB_RFC_PROVEEDOR.TabIndex = 150
        Me.TB_RFC_PROVEEDOR.Tag = "1"
        '
        'TB_RAZON_SOCIAL
        '
        Me.TB_RAZON_SOCIAL.AccessibleDescription = ""
        Me.TB_RAZON_SOCIAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_RAZON_SOCIAL.Location = New System.Drawing.Point(387, 33)
        Me.TB_RAZON_SOCIAL.Name = "TB_RAZON_SOCIAL"
        Me.TB_RAZON_SOCIAL.Size = New System.Drawing.Size(310, 20)
        Me.TB_RAZON_SOCIAL.TabIndex = 149
        Me.TB_RAZON_SOCIAL.Tag = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(391, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 148
        Me.Label4.Text = "Razón Social"
        '
        'TB_D_PROVEEDOR
        '
        Me.TB_D_PROVEEDOR.AccessibleDescription = ""
        Me.TB_D_PROVEEDOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_D_PROVEEDOR.Location = New System.Drawing.Point(66, 33)
        Me.TB_D_PROVEEDOR.Name = "TB_D_PROVEEDOR"
        Me.TB_D_PROVEEDOR.Size = New System.Drawing.Size(243, 20)
        Me.TB_D_PROVEEDOR.TabIndex = 147
        Me.TB_D_PROVEEDOR.Tag = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(69, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 146
        Me.Label8.Text = "Proveedor"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(887, 320)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(76, 13)
        Me.Label36.TabIndex = 145
        Me.Label36.Text = "Correo Pagos"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(731, 320)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(85, 13)
        Me.Label35.TabIndex = 143
        Me.Label35.Text = "Teléfono Pagos"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(350, 321)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(79, 13)
        Me.Label33.TabIndex = 141
        Me.Label33.Text = "Correo Ventas"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(559, 321)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(158, 13)
        Me.Label34.TabIndex = 139
        Me.Label34.Text = "Nombre del Contacto - Pagos"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(23, 321)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(161, 13)
        Me.Label30.TabIndex = 136
        Me.Label30.Text = "Nombre del Contacto - Ventas"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(194, 321)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(88, 13)
        Me.Label31.TabIndex = 137
        Me.Label31.Text = "Teléfono Ventas"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(365, 258)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(40, 13)
        Me.Label28.TabIndex = 127
        Me.Label28.Text = "Estado"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(194, 259)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(52, 13)
        Me.Label27.TabIndex = 125
        Me.Label27.Text = "Municipio"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(450, 219)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(21, 13)
        Me.Label26.TabIndex = 123
        Me.Label26.Text = "CP"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(23, 259)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(54, 13)
        Me.Label25.TabIndex = 121
        Me.Label25.Text = "Población"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(23, 219)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(42, 13)
        Me.Label24.TabIndex = 119
        Me.Label24.Text = "Colonia"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(450, 179)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(67, 13)
        Me.Label23.TabIndex = 117
        Me.Label23.Text = "Num. Interior"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(365, 179)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(70, 13)
        Me.Label22.TabIndex = 115
        Me.Label22.Text = "Num. Exterior"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(23, 179)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(30, 13)
        Me.Label21.TabIndex = 113
        Me.Label21.Text = "Calle"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(288, 99)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 13)
        Me.Label20.TabIndex = 111
        Me.Label20.Text = "Teléfono"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(24, 99)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(38, 13)
        Me.Label19.TabIndex = 109
        Me.Label19.Text = "Correo"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(553, 99)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 13)
        Me.Label18.TabIndex = 107
        Me.Label18.Text = "CURP"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(706, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 13)
        Me.Label17.TabIndex = 106
        Me.Label17.Text = "RFC"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(930, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 97
        Me.Label12.Text = "Estatus"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(818, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 96
        Me.Label11.Text = "Categoría"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(339, 374)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Fecha Alta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(761, 373)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 13)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "Fecha de Última Modificación"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(556, 373)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 13)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Usuario de Última Modificación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(136, 375)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Usuario Alta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(318, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Siglas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Comentarios"
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
        Me.FL_MENU_1.Size = New System.Drawing.Size(1000, 40)
        Me.FL_MENU_1.TabIndex = 38
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
        'FO_PROVEEDOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 710)
        Me.Controls.Add(Me.GB_FICHA)
        Me.Controls.Add(Me.FL_MENU_2)
        Me.Controls.Add(Me.GB_FILTROS)
        Me.Controls.Add(Me.GB_LISTADO)
        Me.Controls.Add(Me.GB_OPERACION)
        Me.Controls.Add(Me.GB_CONTROL)
        Me.Controls.Add(Me.FL_MENU_1)
        Me.Name = "FO_PROVEEDOR"
        Me.Text = "Proveedor"
        Me.GB_FILTROS.ResumeLayout(False)
        Me.GB_FILTROS.PerformLayout()
        Me.GB_LISTADO.ResumeLayout(False)
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_OPERACION.ResumeLayout(False)
        Me.GB_OPERACION.PerformLayout()
        Me.GB_CONTROL.ResumeLayout(False)
        Me.FL_MENU_2.ResumeLayout(False)
        Me.GB_FICHA.ResumeLayout(False)
        Me.GB_FICHA.PerformLayout()
        Me.FL_MENU_1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents CB_LI_ESTATUS_PROVEEDOR As ComboBox
    Public WithEvents GB_FILTROS As GroupBox
    Public WithEvents CB_LI_CATEGORIA_PROVEEDOR As ComboBox
    Public WithEvents BT_LI_BUSCAR As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label1 As Label
    Public WithEvents TB_LI_BUSCAR As TextBox
    Public WithEvents GB_LISTADO As GroupBox
    Public WithEvents LI_LISTADO As DataGridView
    Public WithEvents LB_RELOJ As Label
    Public WithEvents LB_VERSION As Label
    Public WithEvents TB_K_PROVEEDOR As TextBox
    Friend WithEvents LB_ID As Label
    Public WithEvents TI_RELOJ As Timer
    Public WithEvents BT_SALIR As Button
    Public WithEvents BT_CANCELAR As Button
    Public WithEvents BT_GUARDAR As Button
    Public WithEvents BT_LISTADO As Button
    Public WithEvents GB_FICHA As GroupBox
    Public WithEvents BT_ELIMINAR As Button
    Public WithEvents BT_AGREGAR As Button
    Public WithEvents BT_EDITAR As Button
    Public WithEvents CB_USUARIO_ALTA As ComboBox
    Public WithEvents CB_USUARIO_CAMBIO As ComboBox
    Public WithEvents TB_F_ALTA As TextBox
    Public WithEvents TB_F_CAMBIO As TextBox
    Public WithEvents TB_CONTACTO_VENTA_CORREO As TextBox
    Public WithEvents TB_CONTACTO_VENTA_TELEFONO As TextBox
    Public WithEvents TB_CONTACTO_VENTA As TextBox
    Friend WithEvents TB_CURP As TextBox
    Friend WithEvents TB_FISCAL_MUNICIPIO As TextBox
    Friend WithEvents TB_FISCAL_POBLACION As TextBox
    Friend WithEvents TB_S_PROVEEDOR As TextBox
    Friend WithEvents TB_FISCAL_CP As TextBox
    Friend WithEvents TB_FISCAL_COLONIA As TextBox
    Friend WithEvents TB_FISCAL_NUMERO_INTERIOR As TextBox
    Friend WithEvents TB_FISCAL_NUMERO_EXTERIOR As TextBox
    Friend WithEvents TB_FISCAL_CALLE As TextBox
    Public WithEvents CB_ESTATUS_PROVEEDOR As ComboBox
    Public WithEvents TB_TELEFONO As TextBox
    Public WithEvents TB_CORREO As TextBox
    Public WithEvents TB_C_PROVEEDOR As TextBox
    Public WithEvents CB_CATEGORIA_PROVEEDOR As ComboBox
    Public WithEvents TB_RFC_PROVEEDOR As TextBox
    Public WithEvents TB_RAZON_SOCIAL As TextBox
    Friend WithEvents Label4 As Label
    Public WithEvents TB_D_PROVEEDOR As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Public WithEvents TB_CONTACTO_PAGO As TextBox
    Public WithEvents TB_CONTACTO_PAGO_TELEFONO As TextBox
    Public WithEvents TB_CONTACTO_PAGO_CORREO As TextBox
    Friend WithEvents TB_OFICINA_CP As TextBox
    Friend WithEvents TB_OFICINA_COLONIA As TextBox
    Friend WithEvents TB_OFICINA_NUMERO_INTERIOR As TextBox
    Friend WithEvents TB_OFICINA_NUMERO_EXTERIOR As TextBox
    Friend WithEvents TB_OFICINA_CALLE As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Public WithEvents CB_LI_FISCAL_ESTADO As ComboBox
    Friend WithEvents Label16 As Label
    Public WithEvents CB_FISCAL_ESTADO As ComboBox
    Friend WithEvents Label39 As Label
    Public WithEvents CB_LI_OFICINA_ESTADO As ComboBox
    Public WithEvents CB_OFICINA_ESTADO As ComboBox
    Friend WithEvents TB_OFICINA_MUNICIPIO As TextBox
    Friend WithEvents TB_OFICINA_POBLACION As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Public WithEvents TB_N_DIAS_CREDITO As TextBox
    Friend WithEvents Label42 As Label
    Public WithEvents BT_EXPORTAR_EXCEL As Button
    Public WithEvents FL_MENU_2 As FlowLayoutPanel
    Public WithEvents FL_MENU_1 As FlowLayoutPanel
    Public WithEvents GB_OPERACION As GroupBox
    Public WithEvents GB_CONTROL As GroupBox
    Public WithEvents LB_RESULTADO As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label43 As Label
    Public WithEvents BT_CLONAR As Button
End Class
