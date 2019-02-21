<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FO_CUENTA_BANCO_UO
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
        Me.FL_MENU_2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_SALIR = New System.Windows.Forms.Button()
        Me.BT_CANCELAR = New System.Windows.Forms.Button()
        Me.BT_GUARDAR = New System.Windows.Forms.Button()
        Me.BT_LISTADO = New System.Windows.Forms.Button()
        Me.BT_EXPORTAR_EXCEL = New System.Windows.Forms.Button()
        Me.FL_MENU_1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_AGREGAR = New System.Windows.Forms.Button()
        Me.BT_EDITAR = New System.Windows.Forms.Button()
        Me.BT_ELIMINAR = New System.Windows.Forms.Button()
        Me.TI_RELOJ = New System.Windows.Forms.Timer(Me.components)
        Me.GB_FILTROS = New System.Windows.Forms.GroupBox()
        Me.CB_LI_ESTATUS_CUENTA_BANCO = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_LI_MONEDA = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.CB_LI_BANCO = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CB_LI_RAZON_SOCIAL = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CB_LI_ZONA_UO = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CB_LI_TIPO_CUENTA_BANCO = New System.Windows.Forms.ComboBox()
        Me.CB_LI_UNIDAD_OPERATIVA = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BT_LI_BUSCAR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_LI_BUSCAR = New System.Windows.Forms.TextBox()
        Me.LB_RELOJ = New System.Windows.Forms.Label()
        Me.LB_VERSION = New System.Windows.Forms.Label()
        Me.GB_CONTROL = New System.Windows.Forms.GroupBox()
        Me.GB_OPERACION = New System.Windows.Forms.GroupBox()
        Me.LB_RESULTADO = New System.Windows.Forms.TextBox()
        Me.GB_LISTADO = New System.Windows.Forms.GroupBox()
        Me.LI_LISTADO = New System.Windows.Forms.DataGridView()
        Me.GB_FICHA = New System.Windows.Forms.GroupBox()
        Me.CB_UNIDAD_OPERATIVA = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CB_CUENTA_BANCO = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_K_CUENTA_BANCO_UO = New System.Windows.Forms.TextBox()
        Me.CH_L_PRINCIPAL = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TB_CLABE = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TB_CUENTA = New System.Windows.Forms.TextBox()
        Me.CB_TIPO_CUENTA_BANCO = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_K_CUENTA_BANCO = New System.Windows.Forms.TextBox()
        Me.TB_D_CUENTA_BANCO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LB_ID = New System.Windows.Forms.Label()
        Me.BT_CLONAR = New System.Windows.Forms.Button()
        Me.FL_MENU_2.SuspendLayout()
        Me.FL_MENU_1.SuspendLayout()
        Me.GB_FILTROS.SuspendLayout()
        Me.GB_CONTROL.SuspendLayout()
        Me.GB_OPERACION.SuspendLayout()
        Me.GB_LISTADO.SuspendLayout()
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_FICHA.SuspendLayout()
        Me.SuspendLayout()
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
        Me.FL_MENU_2.Location = New System.Drawing.Point(545, 8)
        Me.FL_MENU_2.Name = "FL_MENU_2"
        Me.FL_MENU_2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FL_MENU_2.Size = New System.Drawing.Size(430, 40)
        Me.FL_MENU_2.TabIndex = 52
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
        Me.BT_SALIR.Location = New System.Drawing.Point(360, 3)
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
        Me.BT_CANCELAR.Location = New System.Drawing.Point(290, 3)
        Me.BT_CANCELAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_CANCELAR.Name = "BT_CANCELAR"
        Me.BT_CANCELAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_CANCELAR.TabIndex = 26
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
        Me.BT_GUARDAR.Location = New System.Drawing.Point(220, 3)
        Me.BT_GUARDAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_GUARDAR.Name = "BT_GUARDAR"
        Me.BT_GUARDAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_GUARDAR.TabIndex = 27
        Me.BT_GUARDAR.UseVisualStyleBackColor = True
        '
        'BT_LISTADO
        '
        Me.BT_LISTADO.BackColor = System.Drawing.Color.White
        Me.BT_LISTADO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_LISTADO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_LISTADO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_LISTADO.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.listado
        Me.BT_LISTADO.Location = New System.Drawing.Point(150, 3)
        Me.BT_LISTADO.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_LISTADO.Name = "BT_LISTADO"
        Me.BT_LISTADO.Size = New System.Drawing.Size(70, 34)
        Me.BT_LISTADO.TabIndex = 28
        Me.BT_LISTADO.UseVisualStyleBackColor = False
        '
        'BT_EXPORTAR_EXCEL
        '
        Me.BT_EXPORTAR_EXCEL.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_EXPORTAR_EXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_EXPORTAR_EXCEL.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_export
        Me.BT_EXPORTAR_EXCEL.Location = New System.Drawing.Point(80, 3)
        Me.BT_EXPORTAR_EXCEL.Margin = New System.Windows.Forms.Padding(0)
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
        Me.FL_MENU_1.Size = New System.Drawing.Size(580, 40)
        Me.FL_MENU_1.TabIndex = 51
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
        Me.BT_EDITAR.TabIndex = 7
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
        Me.BT_ELIMINAR.TabIndex = 8
        Me.BT_ELIMINAR.UseVisualStyleBackColor = True
        '
        'TI_RELOJ
        '
        '
        'GB_FILTROS
        '
        Me.GB_FILTROS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_FILTROS.BackColor = System.Drawing.Color.White
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_ESTATUS_CUENTA_BANCO)
        Me.GB_FILTROS.Controls.Add(Me.Label2)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_MONEDA)
        Me.GB_FILTROS.Controls.Add(Me.Label23)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_BANCO)
        Me.GB_FILTROS.Controls.Add(Me.Label11)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_RAZON_SOCIAL)
        Me.GB_FILTROS.Controls.Add(Me.Label20)
        Me.GB_FILTROS.Controls.Add(Me.Label16)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_ZONA_UO)
        Me.GB_FILTROS.Controls.Add(Me.Label15)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_TIPO_CUENTA_BANCO)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_UNIDAD_OPERATIVA)
        Me.GB_FILTROS.Controls.Add(Me.Label13)
        Me.GB_FILTROS.Controls.Add(Me.BT_LI_BUSCAR)
        Me.GB_FILTROS.Controls.Add(Me.Label1)
        Me.GB_FILTROS.Controls.Add(Me.TB_LI_BUSCAR)
        Me.GB_FILTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FILTROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_FILTROS.Location = New System.Drawing.Point(13, 56)
        Me.GB_FILTROS.Name = "GB_FILTROS"
        Me.GB_FILTROS.Size = New System.Drawing.Size(962, 116)
        Me.GB_FILTROS.TabIndex = 47
        Me.GB_FILTROS.TabStop = False
        Me.GB_FILTROS.Text = "Filtros"
        '
        'CB_LI_ESTATUS_CUENTA_BANCO
        '
        Me.CB_LI_ESTATUS_CUENTA_BANCO.FormattingEnabled = True
        Me.CB_LI_ESTATUS_CUENTA_BANCO.Location = New System.Drawing.Point(674, 79)
        Me.CB_LI_ESTATUS_CUENTA_BANCO.Name = "CB_LI_ESTATUS_CUENTA_BANCO"
        Me.CB_LI_ESTATUS_CUENTA_BANCO.Size = New System.Drawing.Size(168, 21)
        Me.CB_LI_ESTATUS_CUENTA_BANCO.TabIndex = 86
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(677, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Estatus"
        '
        'CB_LI_MONEDA
        '
        Me.CB_LI_MONEDA.FormattingEnabled = True
        Me.CB_LI_MONEDA.Location = New System.Drawing.Point(545, 79)
        Me.CB_LI_MONEDA.Name = "CB_LI_MONEDA"
        Me.CB_LI_MONEDA.Size = New System.Drawing.Size(123, 21)
        Me.CB_LI_MONEDA.TabIndex = 84
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(548, 63)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(50, 13)
        Me.Label23.TabIndex = 83
        Me.Label23.Text = "Moneda"
        '
        'CB_LI_BANCO
        '
        Me.CB_LI_BANCO.FormattingEnabled = True
        Me.CB_LI_BANCO.Location = New System.Drawing.Point(372, 79)
        Me.CB_LI_BANCO.Name = "CB_LI_BANCO"
        Me.CB_LI_BANCO.Size = New System.Drawing.Size(167, 21)
        Me.CB_LI_BANCO.TabIndex = 82
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(375, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 13)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "Banco"
        '
        'CB_LI_RAZON_SOCIAL
        '
        Me.CB_LI_RAZON_SOCIAL.FormattingEnabled = True
        Me.CB_LI_RAZON_SOCIAL.Location = New System.Drawing.Point(545, 36)
        Me.CB_LI_RAZON_SOCIAL.Name = "CB_LI_RAZON_SOCIAL"
        Me.CB_LI_RAZON_SOCIAL.Size = New System.Drawing.Size(296, 21)
        Me.CB_LI_RAZON_SOCIAL.TabIndex = 47
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(549, 20)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 13)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "Razon Social"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(291, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 13)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Zona"
        '
        'CB_LI_ZONA_UO
        '
        Me.CB_LI_ZONA_UO.FormattingEnabled = True
        Me.CB_LI_ZONA_UO.Location = New System.Drawing.Point(288, 36)
        Me.CB_LI_ZONA_UO.Name = "CB_LI_ZONA_UO"
        Me.CB_LI_ZONA_UO.Size = New System.Drawing.Size(251, 21)
        Me.CB_LI_ZONA_UO.TabIndex = 34
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(213, 63)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(132, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Tipo de Cuenta Bancaria"
        '
        'CB_LI_TIPO_CUENTA_BANCO
        '
        Me.CB_LI_TIPO_CUENTA_BANCO.FormattingEnabled = True
        Me.CB_LI_TIPO_CUENTA_BANCO.Location = New System.Drawing.Point(210, 79)
        Me.CB_LI_TIPO_CUENTA_BANCO.Name = "CB_LI_TIPO_CUENTA_BANCO"
        Me.CB_LI_TIPO_CUENTA_BANCO.Size = New System.Drawing.Size(156, 21)
        Me.CB_LI_TIPO_CUENTA_BANCO.TabIndex = 23
        '
        'CB_LI_UNIDAD_OPERATIVA
        '
        Me.CB_LI_UNIDAD_OPERATIVA.FormattingEnabled = True
        Me.CB_LI_UNIDAD_OPERATIVA.Location = New System.Drawing.Point(13, 79)
        Me.CB_LI_UNIDAD_OPERATIVA.Name = "CB_LI_UNIDAD_OPERATIVA"
        Me.CB_LI_UNIDAD_OPERATIVA.Size = New System.Drawing.Size(190, 21)
        Me.CB_LI_UNIDAD_OPERATIVA.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Unidad Operativa"
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
        Me.BT_LI_BUSCAR.Location = New System.Drawing.Point(885, 44)
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
        Me.Label1.Location = New System.Drawing.Point(16, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Buscar"
        '
        'TB_LI_BUSCAR
        '
        Me.TB_LI_BUSCAR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LI_BUSCAR.Location = New System.Drawing.Point(13, 36)
        Me.TB_LI_BUSCAR.Name = "TB_LI_BUSCAR"
        Me.TB_LI_BUSCAR.Size = New System.Drawing.Size(269, 22)
        Me.TB_LI_BUSCAR.TabIndex = 1
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
        'GB_CONTROL
        '
        Me.GB_CONTROL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_CONTROL.BackColor = System.Drawing.Color.White
        Me.GB_CONTROL.Controls.Add(Me.LB_VERSION)
        Me.GB_CONTROL.Controls.Add(Me.LB_RELOJ)
        Me.GB_CONTROL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_CONTROL.Location = New System.Drawing.Point(536, 471)
        Me.GB_CONTROL.Name = "GB_CONTROL"
        Me.GB_CONTROL.Size = New System.Drawing.Size(440, 52)
        Me.GB_CONTROL.TabIndex = 50
        Me.GB_CONTROL.TabStop = False
        Me.GB_CONTROL.Text = "Control"
        '
        'GB_OPERACION
        '
        Me.GB_OPERACION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_OPERACION.BackColor = System.Drawing.Color.White
        Me.GB_OPERACION.Controls.Add(Me.LB_RESULTADO)
        Me.GB_OPERACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_OPERACION.Location = New System.Drawing.Point(13, 471)
        Me.GB_OPERACION.Name = "GB_OPERACION"
        Me.GB_OPERACION.Size = New System.Drawing.Size(516, 52)
        Me.GB_OPERACION.TabIndex = 49
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
        Me.LB_RESULTADO.Location = New System.Drawing.Point(6, 16)
        Me.LB_RESULTADO.Multiline = True
        Me.LB_RESULTADO.Name = "LB_RESULTADO"
        Me.LB_RESULTADO.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.LB_RESULTADO.Size = New System.Drawing.Size(504, 30)
        Me.LB_RESULTADO.TabIndex = 3
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
        Me.GB_LISTADO.Size = New System.Drawing.Size(962, 291)
        Me.GB_LISTADO.TabIndex = 48
        Me.GB_LISTADO.TabStop = False
        Me.GB_LISTADO.Text = "Listado"
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
        Me.LI_LISTADO.Location = New System.Drawing.Point(3, 16)
        Me.LI_LISTADO.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.LI_LISTADO.Name = "LI_LISTADO"
        Me.LI_LISTADO.Size = New System.Drawing.Size(956, 272)
        Me.LI_LISTADO.TabIndex = 2
        '
        'GB_FICHA
        '
        Me.GB_FICHA.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GB_FICHA.Controls.Add(Me.CB_UNIDAD_OPERATIVA)
        Me.GB_FICHA.Controls.Add(Me.Label7)
        Me.GB_FICHA.Controls.Add(Me.CB_CUENTA_BANCO)
        Me.GB_FICHA.Controls.Add(Me.Label6)
        Me.GB_FICHA.Controls.Add(Me.Label5)
        Me.GB_FICHA.Controls.Add(Me.TB_K_CUENTA_BANCO_UO)
        Me.GB_FICHA.Controls.Add(Me.CH_L_PRINCIPAL)
        Me.GB_FICHA.Controls.Add(Me.Label14)
        Me.GB_FICHA.Controls.Add(Me.TB_CLABE)
        Me.GB_FICHA.Controls.Add(Me.Label12)
        Me.GB_FICHA.Controls.Add(Me.TB_CUENTA)
        Me.GB_FICHA.Controls.Add(Me.CB_TIPO_CUENTA_BANCO)
        Me.GB_FICHA.Controls.Add(Me.Label4)
        Me.GB_FICHA.Controls.Add(Me.TB_K_CUENTA_BANCO)
        Me.GB_FICHA.Controls.Add(Me.TB_D_CUENTA_BANCO)
        Me.GB_FICHA.Controls.Add(Me.Label8)
        Me.GB_FICHA.Controls.Add(Me.LB_ID)
        Me.GB_FICHA.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_FICHA.Location = New System.Drawing.Point(240, 187)
        Me.GB_FICHA.Name = "GB_FICHA"
        Me.GB_FICHA.Size = New System.Drawing.Size(623, 192)
        Me.GB_FICHA.TabIndex = 59
        Me.GB_FICHA.TabStop = False
        Me.GB_FICHA.Text = "Ficha"
        '
        'CB_UNIDAD_OPERATIVA
        '
        Me.CB_UNIDAD_OPERATIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_UNIDAD_OPERATIVA.Location = New System.Drawing.Point(377, 64)
        Me.CB_UNIDAD_OPERATIVA.Name = "CB_UNIDAD_OPERATIVA"
        Me.CB_UNIDAD_OPERATIVA.Size = New System.Drawing.Size(240, 21)
        Me.CB_UNIDAD_OPERATIVA.TabIndex = 74
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(380, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Unidad Operativa"
        '
        'CB_CUENTA_BANCO
        '
        Me.CB_CUENTA_BANCO.FormattingEnabled = True
        Me.CB_CUENTA_BANCO.Location = New System.Drawing.Point(9, 64)
        Me.CB_CUENTA_BANCO.Name = "CB_CUENTA_BANCO"
        Me.CB_CUENTA_BANCO.Size = New System.Drawing.Size(362, 21)
        Me.CB_CUENTA_BANCO.TabIndex = 73
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Cuenta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(504, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "#CTUO"
        '
        'TB_K_CUENTA_BANCO_UO
        '
        Me.TB_K_CUENTA_BANCO_UO.Enabled = False
        Me.TB_K_CUENTA_BANCO_UO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_K_CUENTA_BANCO_UO.Location = New System.Drawing.Point(550, 21)
        Me.TB_K_CUENTA_BANCO_UO.Name = "TB_K_CUENTA_BANCO_UO"
        Me.TB_K_CUENTA_BANCO_UO.ReadOnly = True
        Me.TB_K_CUENTA_BANCO_UO.Size = New System.Drawing.Size(54, 22)
        Me.TB_K_CUENTA_BANCO_UO.TabIndex = 70
        '
        'CH_L_PRINCIPAL
        '
        Me.CH_L_PRINCIPAL.AutoSize = True
        Me.CH_L_PRINCIPAL.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CH_L_PRINCIPAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CH_L_PRINCIPAL.Location = New System.Drawing.Point(443, 153)
        Me.CH_L_PRINCIPAL.Name = "CH_L_PRINCIPAL"
        Me.CH_L_PRINCIPAL.Size = New System.Drawing.Size(66, 17)
        Me.CH_L_PRINCIPAL.TabIndex = 68
        Me.CH_L_PRINCIPAL.Text = "Principal"
        Me.CH_L_PRINCIPAL.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(198, 137)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 13)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Clabe"
        '
        'TB_CLABE
        '
        Me.TB_CLABE.Enabled = False
        Me.TB_CLABE.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CLABE.Location = New System.Drawing.Point(195, 153)
        Me.TB_CLABE.Name = "TB_CLABE"
        Me.TB_CLABE.ReadOnly = True
        Me.TB_CLABE.Size = New System.Drawing.Size(242, 22)
        Me.TB_CLABE.TabIndex = 43
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 137)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Cuenta"
        '
        'TB_CUENTA
        '
        Me.TB_CUENTA.Enabled = False
        Me.TB_CUENTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CUENTA.Location = New System.Drawing.Point(9, 153)
        Me.TB_CUENTA.Name = "TB_CUENTA"
        Me.TB_CUENTA.ReadOnly = True
        Me.TB_CUENTA.Size = New System.Drawing.Size(180, 22)
        Me.TB_CUENTA.TabIndex = 41
        '
        'CB_TIPO_CUENTA_BANCO
        '
        Me.CB_TIPO_CUENTA_BANCO.FormattingEnabled = True
        Me.CB_TIPO_CUENTA_BANCO.Location = New System.Drawing.Point(443, 108)
        Me.CB_TIPO_CUENTA_BANCO.Name = "CB_TIPO_CUENTA_BANCO"
        Me.CB_TIPO_CUENTA_BANCO.Size = New System.Drawing.Size(174, 21)
        Me.CB_TIPO_CUENTA_BANCO.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(446, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Tipo"
        '
        'TB_K_CUENTA_BANCO
        '
        Me.TB_K_CUENTA_BANCO.Enabled = False
        Me.TB_K_CUENTA_BANCO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_K_CUENTA_BANCO.Location = New System.Drawing.Point(9, 108)
        Me.TB_K_CUENTA_BANCO.Name = "TB_K_CUENTA_BANCO"
        Me.TB_K_CUENTA_BANCO.ReadOnly = True
        Me.TB_K_CUENTA_BANCO.Size = New System.Drawing.Size(104, 22)
        Me.TB_K_CUENTA_BANCO.TabIndex = 25
        '
        'TB_D_CUENTA_BANCO
        '
        Me.TB_D_CUENTA_BANCO.AccessibleDescription = ""
        Me.TB_D_CUENTA_BANCO.Enabled = False
        Me.TB_D_CUENTA_BANCO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_D_CUENTA_BANCO.Location = New System.Drawing.Point(119, 108)
        Me.TB_D_CUENTA_BANCO.Name = "TB_D_CUENTA_BANCO"
        Me.TB_D_CUENTA_BANCO.ReadOnly = True
        Me.TB_D_CUENTA_BANCO.Size = New System.Drawing.Size(318, 22)
        Me.TB_D_CUENTA_BANCO.TabIndex = 22
        Me.TB_D_CUENTA_BANCO.Tag = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(122, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Descripción"
        '
        'LB_ID
        '
        Me.LB_ID.AutoSize = True
        Me.LB_ID.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ID.Location = New System.Drawing.Point(6, 92)
        Me.LB_ID.Name = "LB_ID"
        Me.LB_ID.Size = New System.Drawing.Size(34, 13)
        Me.LB_ID.TabIndex = 24
        Me.LB_ID.Text = "#CTA"
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
        Me.BT_CLONAR.TabIndex = 9
        Me.BT_CLONAR.UseVisualStyleBackColor = True
        '
        'FO_CUENTA_BANCO_UO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(990, 530)
        Me.Controls.Add(Me.GB_FICHA)
        Me.Controls.Add(Me.FL_MENU_2)
        Me.Controls.Add(Me.FL_MENU_1)
        Me.Controls.Add(Me.GB_FILTROS)
        Me.Controls.Add(Me.GB_CONTROL)
        Me.Controls.Add(Me.GB_OPERACION)
        Me.Controls.Add(Me.GB_LISTADO)
        Me.Name = "FO_CUENTA_BANCO_UO"
        Me.Text = "FO_CUENTA_BANCO_UO"
        Me.FL_MENU_2.ResumeLayout(False)
        Me.FL_MENU_1.ResumeLayout(False)
        Me.GB_FILTROS.ResumeLayout(False)
        Me.GB_FILTROS.PerformLayout()
        Me.GB_CONTROL.ResumeLayout(False)
        Me.GB_OPERACION.ResumeLayout(False)
        Me.GB_OPERACION.PerformLayout()
        Me.GB_LISTADO.ResumeLayout(False)
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_FICHA.ResumeLayout(False)
        Me.GB_FICHA.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents BT_SALIR As Button
    Public WithEvents BT_AGREGAR As Button
    Public WithEvents TI_RELOJ As Timer
    Public WithEvents GB_FILTROS As GroupBox
    Friend WithEvents Label16 As Label
    Public WithEvents CB_LI_ZONA_UO As ComboBox
    Friend WithEvents CB_LI_UNIDAD_OPERATIVA As ComboBox
    Friend WithEvents Label13 As Label
    Public WithEvents BT_LI_BUSCAR As Button
    Friend WithEvents Label1 As Label
    Public WithEvents TB_LI_BUSCAR As TextBox
    Public WithEvents LB_RELOJ As Label
    Public WithEvents LB_VERSION As Label
    Public WithEvents GB_LISTADO As GroupBox
    Public WithEvents LB_RESULTADO As TextBox
    Public WithEvents FL_MENU_2 As FlowLayoutPanel
    Public WithEvents BT_EXPORTAR_EXCEL As Button
    Public WithEvents FL_MENU_1 As FlowLayoutPanel
    Public WithEvents GB_CONTROL As GroupBox
    Public WithEvents GB_OPERACION As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents CB_LI_TIPO_CUENTA_BANCO As ComboBox
    Public WithEvents LI_LISTADO As DataGridView
    Public WithEvents CB_LI_RAZON_SOCIAL As ComboBox
    Friend WithEvents Label20 As Label
    Public WithEvents CB_LI_MONEDA As ComboBox
    Friend WithEvents Label23 As Label
    Public WithEvents CB_LI_BANCO As ComboBox
    Friend WithEvents Label11 As Label
    Public WithEvents CB_LI_ESTATUS_CUENTA_BANCO As ComboBox
    Friend WithEvents Label2 As Label
    Public WithEvents GB_FICHA As GroupBox
    Public WithEvents TB_K_CUENTA_BANCO_UO As TextBox
    Friend WithEvents CH_L_PRINCIPAL As CheckBox
    Friend WithEvents Label14 As Label
    Public WithEvents TB_CLABE As TextBox
    Friend WithEvents Label12 As Label
    Public WithEvents TB_CUENTA As TextBox
    Public WithEvents CB_TIPO_CUENTA_BANCO As ComboBox
    Friend WithEvents Label4 As Label
    Public WithEvents TB_K_CUENTA_BANCO As TextBox
    Public WithEvents TB_D_CUENTA_BANCO As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents LB_ID As Label
    Friend WithEvents Label5 As Label
    Public WithEvents CB_CUENTA_BANCO As ComboBox
    Friend WithEvents Label6 As Label
    Public WithEvents BT_CANCELAR As Button
    Public WithEvents BT_GUARDAR As Button
    Public WithEvents BT_LISTADO As Button
    Public WithEvents BT_EDITAR As Button
    Public WithEvents BT_ELIMINAR As Button
    Public WithEvents CB_UNIDAD_OPERATIVA As ComboBox
    Friend WithEvents Label7 As Label
    Public WithEvents BT_CLONAR As Button
End Class
