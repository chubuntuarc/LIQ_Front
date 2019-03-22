<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FO_PRODUCTO
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GB_LISTADO = New System.Windows.Forms.GroupBox()
        Me.LI_LISTADO = New System.Windows.Forms.DataGridView()
        Me.GB_OPERACION = New System.Windows.Forms.GroupBox()
        Me.LB_RESULTADO = New System.Windows.Forms.TextBox()
        Me.GB_CONTROL = New System.Windows.Forms.GroupBox()
        Me.LB_VERSION = New System.Windows.Forms.Label()
        Me.LB_RELOJ = New System.Windows.Forms.Label()
        Me.BT_AGREGAR = New System.Windows.Forms.Button()
        Me.FL_MENU_1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_EDITAR = New System.Windows.Forms.Button()
        Me.BT_CLONAR = New System.Windows.Forms.Button()
        Me.BT_ELIMINAR = New System.Windows.Forms.Button()
        Me.TI_RELOJ = New System.Windows.Forms.Timer(Me.components)
        Me.FL_MENU_2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_SALIR = New System.Windows.Forms.Button()
        Me.BT_CANCELAR = New System.Windows.Forms.Button()
        Me.BT_GUARDAR = New System.Windows.Forms.Button()
        Me.BT_LISTADO = New System.Windows.Forms.Button()
        Me.BT_EXPORTAR_EXCEL = New System.Windows.Forms.Button()
        Me.GB_FICHA = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TB_CANTIDAD_LITROS = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_CANTIDAD_KILOS = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_FACTOR_LITROS = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_FACTOR_KILOS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_CANTIDAD = New System.Windows.Forms.TextBox()
        Me.CB_UNIDAD = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CB_TIPO_PRODUCTO = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TB_O_PRODUCTO = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TB_K_PRODUCTO = New System.Windows.Forms.TextBox()
        Me.TB_S_PRODUCTO = New System.Windows.Forms.TextBox()
        Me.TB_K_PDV = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TB_D_PRODUCTO = New System.Windows.Forms.TextBox()
        Me.CB_USUARIO_CAMBIO = New System.Windows.Forms.ComboBox()
        Me.CB_USUARIO_ALTA = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_F_ALTA = New System.Windows.Forms.TextBox()
        Me.TB_F_CAMBIO = New System.Windows.Forms.TextBox()
        Me.CB_ESTATUS_PRODUCTO = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LB_ID = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GB_FILTROS = New System.Windows.Forms.GroupBox()
        Me.CB_LI_UNIDAD = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CB_LI_TIPO_PRODUCTO = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.CB_LI_ESTATUS_PRODUCTO = New System.Windows.Forms.ComboBox()
        Me.BT_LI_BUSCAR = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_LI_BUSCAR = New System.Windows.Forms.TextBox()
        Me.GB_LISTADO.SuspendLayout()
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_OPERACION.SuspendLayout()
        Me.GB_CONTROL.SuspendLayout()
        Me.FL_MENU_1.SuspendLayout()
        Me.FL_MENU_2.SuspendLayout()
        Me.GB_FICHA.SuspendLayout()
        Me.GB_FILTROS.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_LISTADO
        '
        Me.GB_LISTADO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_LISTADO.BackColor = System.Drawing.Color.White
        Me.GB_LISTADO.Controls.Add(Me.LI_LISTADO)
        Me.GB_LISTADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_LISTADO.Location = New System.Drawing.Point(27, 264)
        Me.GB_LISTADO.Margin = New System.Windows.Forms.Padding(6)
        Me.GB_LISTADO.Name = "GB_LISTADO"
        Me.GB_LISTADO.Padding = New System.Windows.Forms.Padding(6)
        Me.GB_LISTADO.Size = New System.Drawing.Size(2056, 781)
        Me.GB_LISTADO.TabIndex = 58
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LI_LISTADO.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.LI_LISTADO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LI_LISTADO.Location = New System.Drawing.Point(24, 50)
        Me.LI_LISTADO.Margin = New System.Windows.Forms.Padding(24, 19, 24, 19)
        Me.LI_LISTADO.Name = "LI_LISTADO"
        Me.LI_LISTADO.Size = New System.Drawing.Size(2010, 706)
        Me.LI_LISTADO.TabIndex = 2
        '
        'GB_OPERACION
        '
        Me.GB_OPERACION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_OPERACION.BackColor = System.Drawing.Color.White
        Me.GB_OPERACION.Controls.Add(Me.LB_RESULTADO)
        Me.GB_OPERACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_OPERACION.Location = New System.Drawing.Point(27, 1049)
        Me.GB_OPERACION.Margin = New System.Windows.Forms.Padding(6)
        Me.GB_OPERACION.Name = "GB_OPERACION"
        Me.GB_OPERACION.Padding = New System.Windows.Forms.Padding(6)
        Me.GB_OPERACION.Size = New System.Drawing.Size(1164, 100)
        Me.GB_OPERACION.TabIndex = 59
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
        Me.LB_RESULTADO.Location = New System.Drawing.Point(12, 29)
        Me.LB_RESULTADO.Margin = New System.Windows.Forms.Padding(6)
        Me.LB_RESULTADO.Multiline = True
        Me.LB_RESULTADO.Name = "LB_RESULTADO"
        Me.LB_RESULTADO.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.LB_RESULTADO.Size = New System.Drawing.Size(1138, 56)
        Me.LB_RESULTADO.TabIndex = 4
        '
        'GB_CONTROL
        '
        Me.GB_CONTROL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_CONTROL.BackColor = System.Drawing.Color.White
        Me.GB_CONTROL.Controls.Add(Me.LB_VERSION)
        Me.GB_CONTROL.Controls.Add(Me.LB_RELOJ)
        Me.GB_CONTROL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_CONTROL.Location = New System.Drawing.Point(1205, 1049)
        Me.GB_CONTROL.Margin = New System.Windows.Forms.Padding(6)
        Me.GB_CONTROL.Name = "GB_CONTROL"
        Me.GB_CONTROL.Padding = New System.Windows.Forms.Padding(6)
        Me.GB_CONTROL.Size = New System.Drawing.Size(880, 100)
        Me.GB_CONTROL.TabIndex = 60
        Me.GB_CONTROL.TabStop = False
        Me.GB_CONTROL.Text = "Control"
        '
        'LB_VERSION
        '
        Me.LB_VERSION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_VERSION.Location = New System.Drawing.Point(12, 65)
        Me.LB_VERSION.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LB_VERSION.Name = "LB_VERSION"
        Me.LB_VERSION.Size = New System.Drawing.Size(324, 25)
        Me.LB_VERSION.TabIndex = 1
        Me.LB_VERSION.Text = "Label10"
        Me.LB_VERSION.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LB_RELOJ
        '
        Me.LB_RELOJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_RELOJ.Location = New System.Drawing.Point(502, 65)
        Me.LB_RELOJ.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LB_RELOJ.Name = "LB_RELOJ"
        Me.LB_RELOJ.Size = New System.Drawing.Size(354, 25)
        Me.LB_RELOJ.TabIndex = 0
        Me.LB_RELOJ.Text = "Label9"
        Me.LB_RELOJ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BT_AGREGAR
        '
        Me.BT_AGREGAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_AGREGAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_AGREGAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_AGREGAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_AGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_AGREGAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.ICO_BT_AGREGAR
        Me.BT_AGREGAR.Location = New System.Drawing.Point(0, 6)
        Me.BT_AGREGAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_AGREGAR.Name = "BT_AGREGAR"
        Me.BT_AGREGAR.Size = New System.Drawing.Size(140, 65)
        Me.BT_AGREGAR.TabIndex = 4
        Me.BT_AGREGAR.UseVisualStyleBackColor = True
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
        Me.FL_MENU_1.Location = New System.Drawing.Point(27, 14)
        Me.FL_MENU_1.Margin = New System.Windows.Forms.Padding(6)
        Me.FL_MENU_1.Name = "FL_MENU_1"
        Me.FL_MENU_1.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.FL_MENU_1.Size = New System.Drawing.Size(1292, 77)
        Me.FL_MENU_1.TabIndex = 61
        '
        'BT_EDITAR
        '
        Me.BT_EDITAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_EDITAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_EDITAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_EDITAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_EDITAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_EDITAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.ICO_BT_EDITAR
        Me.BT_EDITAR.Location = New System.Drawing.Point(140, 6)
        Me.BT_EDITAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_EDITAR.Name = "BT_EDITAR"
        Me.BT_EDITAR.Size = New System.Drawing.Size(140, 65)
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
        Me.BT_CLONAR.Location = New System.Drawing.Point(280, 6)
        Me.BT_CLONAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_CLONAR.Name = "BT_CLONAR"
        Me.BT_CLONAR.Size = New System.Drawing.Size(140, 65)
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
        Me.BT_ELIMINAR.Location = New System.Drawing.Point(420, 6)
        Me.BT_ELIMINAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_ELIMINAR.Name = "BT_ELIMINAR"
        Me.BT_ELIMINAR.Size = New System.Drawing.Size(140, 65)
        Me.BT_ELIMINAR.TabIndex = 6
        Me.BT_ELIMINAR.UseVisualStyleBackColor = True
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
        Me.FL_MENU_2.Location = New System.Drawing.Point(1082, 14)
        Me.FL_MENU_2.Margin = New System.Windows.Forms.Padding(6)
        Me.FL_MENU_2.Name = "FL_MENU_2"
        Me.FL_MENU_2.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.FL_MENU_2.Size = New System.Drawing.Size(770, 77)
        Me.FL_MENU_2.TabIndex = 62
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
        Me.BT_SALIR.Location = New System.Drawing.Point(630, 12)
        Me.BT_SALIR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_SALIR.Name = "BT_SALIR"
        Me.BT_SALIR.Size = New System.Drawing.Size(140, 65)
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
        Me.BT_CANCELAR.Location = New System.Drawing.Point(490, 12)
        Me.BT_CANCELAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_CANCELAR.Name = "BT_CANCELAR"
        Me.BT_CANCELAR.Size = New System.Drawing.Size(140, 65)
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
        Me.BT_GUARDAR.Location = New System.Drawing.Point(350, 12)
        Me.BT_GUARDAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_GUARDAR.Name = "BT_GUARDAR"
        Me.BT_GUARDAR.Size = New System.Drawing.Size(140, 65)
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
        Me.BT_LISTADO.Location = New System.Drawing.Point(204, 12)
        Me.BT_LISTADO.Margin = New System.Windows.Forms.Padding(6)
        Me.BT_LISTADO.Name = "BT_LISTADO"
        Me.BT_LISTADO.Size = New System.Drawing.Size(140, 65)
        Me.BT_LISTADO.TabIndex = 25
        Me.BT_LISTADO.UseVisualStyleBackColor = False
        '
        'BT_EXPORTAR_EXCEL
        '
        Me.BT_EXPORTAR_EXCEL.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_EXPORTAR_EXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_EXPORTAR_EXCEL.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.ICO_BT_EXPORTAR_EXCEL
        Me.BT_EXPORTAR_EXCEL.Location = New System.Drawing.Point(52, 12)
        Me.BT_EXPORTAR_EXCEL.Margin = New System.Windows.Forms.Padding(6)
        Me.BT_EXPORTAR_EXCEL.Name = "BT_EXPORTAR_EXCEL"
        Me.BT_EXPORTAR_EXCEL.Size = New System.Drawing.Size(140, 65)
        Me.BT_EXPORTAR_EXCEL.TabIndex = 28
        Me.BT_EXPORTAR_EXCEL.Tag = "Copiar al portapapeles"
        Me.BT_EXPORTAR_EXCEL.UseVisualStyleBackColor = True
        '
        'GB_FICHA
        '
        Me.GB_FICHA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GB_FICHA.BackColor = System.Drawing.Color.White
        Me.GB_FICHA.Controls.Add(Me.Label10)
        Me.GB_FICHA.Controls.Add(Me.TB_CANTIDAD_LITROS)
        Me.GB_FICHA.Controls.Add(Me.Label8)
        Me.GB_FICHA.Controls.Add(Me.TB_CANTIDAD_KILOS)
        Me.GB_FICHA.Controls.Add(Me.Label7)
        Me.GB_FICHA.Controls.Add(Me.TB_FACTOR_LITROS)
        Me.GB_FICHA.Controls.Add(Me.Label4)
        Me.GB_FICHA.Controls.Add(Me.TB_FACTOR_KILOS)
        Me.GB_FICHA.Controls.Add(Me.Label3)
        Me.GB_FICHA.Controls.Add(Me.TB_CANTIDAD)
        Me.GB_FICHA.Controls.Add(Me.CB_UNIDAD)
        Me.GB_FICHA.Controls.Add(Me.Label21)
        Me.GB_FICHA.Controls.Add(Me.CB_TIPO_PRODUCTO)
        Me.GB_FICHA.Controls.Add(Me.Label20)
        Me.GB_FICHA.Controls.Add(Me.Label14)
        Me.GB_FICHA.Controls.Add(Me.TB_O_PRODUCTO)
        Me.GB_FICHA.Controls.Add(Me.Label12)
        Me.GB_FICHA.Controls.Add(Me.TB_K_PRODUCTO)
        Me.GB_FICHA.Controls.Add(Me.TB_S_PRODUCTO)
        Me.GB_FICHA.Controls.Add(Me.TB_K_PDV)
        Me.GB_FICHA.Controls.Add(Me.Label30)
        Me.GB_FICHA.Controls.Add(Me.TB_D_PRODUCTO)
        Me.GB_FICHA.Controls.Add(Me.CB_USUARIO_CAMBIO)
        Me.GB_FICHA.Controls.Add(Me.CB_USUARIO_ALTA)
        Me.GB_FICHA.Controls.Add(Me.Label5)
        Me.GB_FICHA.Controls.Add(Me.Label9)
        Me.GB_FICHA.Controls.Add(Me.Label6)
        Me.GB_FICHA.Controls.Add(Me.Label2)
        Me.GB_FICHA.Controls.Add(Me.TB_F_ALTA)
        Me.GB_FICHA.Controls.Add(Me.TB_F_CAMBIO)
        Me.GB_FICHA.Controls.Add(Me.CB_ESTATUS_PRODUCTO)
        Me.GB_FICHA.Controls.Add(Me.Label11)
        Me.GB_FICHA.Controls.Add(Me.LB_ID)
        Me.GB_FICHA.Controls.Add(Me.GroupBox1)
        Me.GB_FICHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FICHA.Location = New System.Drawing.Point(473, 326)
        Me.GB_FICHA.Margin = New System.Windows.Forms.Padding(6)
        Me.GB_FICHA.Name = "GB_FICHA"
        Me.GB_FICHA.Padding = New System.Windows.Forms.Padding(6)
        Me.GB_FICHA.Size = New System.Drawing.Size(1166, 510)
        Me.GB_FICHA.TabIndex = 64
        Me.GB_FICHA.TabStop = False
        Me.GB_FICHA.Text = "Ficha"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(753, 332)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(157, 30)
        Me.Label10.TabIndex = 293
        Me.Label10.Text = "Cantidad Litros"
        '
        'TB_CANTIDAD_LITROS
        '
        Me.TB_CANTIDAD_LITROS.AccessibleDescription = ""
        Me.TB_CANTIDAD_LITROS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_CANTIDAD_LITROS.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CANTIDAD_LITROS.Location = New System.Drawing.Point(753, 363)
        Me.TB_CANTIDAD_LITROS.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_CANTIDAD_LITROS.Name = "TB_CANTIDAD_LITROS"
        Me.TB_CANTIDAD_LITROS.Size = New System.Drawing.Size(315, 36)
        Me.TB_CANTIDAD_LITROS.TabIndex = 292
        Me.TB_CANTIDAD_LITROS.Tag = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(411, 332)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 30)
        Me.Label8.TabIndex = 291
        Me.Label8.Text = "Cantidad Kilos"
        '
        'TB_CANTIDAD_KILOS
        '
        Me.TB_CANTIDAD_KILOS.AccessibleDescription = ""
        Me.TB_CANTIDAD_KILOS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_CANTIDAD_KILOS.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CANTIDAD_KILOS.Location = New System.Drawing.Point(411, 363)
        Me.TB_CANTIDAD_KILOS.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_CANTIDAD_KILOS.Name = "TB_CANTIDAD_KILOS"
        Me.TB_CANTIDAD_KILOS.Size = New System.Drawing.Size(315, 36)
        Me.TB_CANTIDAD_KILOS.TabIndex = 290
        Me.TB_CANTIDAD_KILOS.Tag = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(753, 238)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 30)
        Me.Label7.TabIndex = 289
        Me.Label7.Text = "Factor Litros"
        '
        'TB_FACTOR_LITROS
        '
        Me.TB_FACTOR_LITROS.AccessibleDescription = ""
        Me.TB_FACTOR_LITROS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_FACTOR_LITROS.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FACTOR_LITROS.Location = New System.Drawing.Point(753, 269)
        Me.TB_FACTOR_LITROS.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_FACTOR_LITROS.Name = "TB_FACTOR_LITROS"
        Me.TB_FACTOR_LITROS.Size = New System.Drawing.Size(315, 36)
        Me.TB_FACTOR_LITROS.TabIndex = 288
        Me.TB_FACTOR_LITROS.Tag = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(411, 238)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 30)
        Me.Label4.TabIndex = 287
        Me.Label4.Text = "Factor Kilos"
        '
        'TB_FACTOR_KILOS
        '
        Me.TB_FACTOR_KILOS.AccessibleDescription = ""
        Me.TB_FACTOR_KILOS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_FACTOR_KILOS.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FACTOR_KILOS.Location = New System.Drawing.Point(411, 269)
        Me.TB_FACTOR_KILOS.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_FACTOR_KILOS.Name = "TB_FACTOR_KILOS"
        Me.TB_FACTOR_KILOS.Size = New System.Drawing.Size(315, 36)
        Me.TB_FACTOR_KILOS.TabIndex = 286
        Me.TB_FACTOR_KILOS.Tag = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 238)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 30)
        Me.Label3.TabIndex = 285
        Me.Label3.Text = "Cantidad"
        '
        'TB_CANTIDAD
        '
        Me.TB_CANTIDAD.AccessibleDescription = ""
        Me.TB_CANTIDAD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_CANTIDAD.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CANTIDAD.Location = New System.Drawing.Point(61, 269)
        Me.TB_CANTIDAD.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_CANTIDAD.Name = "TB_CANTIDAD"
        Me.TB_CANTIDAD.Size = New System.Drawing.Size(315, 36)
        Me.TB_CANTIDAD.TabIndex = 284
        Me.TB_CANTIDAD.Tag = "1"
        '
        'CB_UNIDAD
        '
        Me.CB_UNIDAD.FormattingEnabled = True
        Me.CB_UNIDAD.Location = New System.Drawing.Point(753, 180)
        Me.CB_UNIDAD.Margin = New System.Windows.Forms.Padding(6)
        Me.CB_UNIDAD.Name = "CB_UNIDAD"
        Me.CB_UNIDAD.Size = New System.Drawing.Size(315, 33)
        Me.CB_UNIDAD.TabIndex = 283
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(759, 153)
        Me.Label21.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(81, 26)
        Me.Label21.TabIndex = 282
        Me.Label21.Text = "Unidad"
        '
        'CB_TIPO_PRODUCTO
        '
        Me.CB_TIPO_PRODUCTO.FormattingEnabled = True
        Me.CB_TIPO_PRODUCTO.Location = New System.Drawing.Point(411, 180)
        Me.CB_TIPO_PRODUCTO.Margin = New System.Windows.Forms.Padding(6)
        Me.CB_TIPO_PRODUCTO.Name = "CB_TIPO_PRODUCTO"
        Me.CB_TIPO_PRODUCTO.Size = New System.Drawing.Size(315, 33)
        Me.CB_TIPO_PRODUCTO.TabIndex = 281
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(417, 153)
        Me.Label20.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 26)
        Me.Label20.TabIndex = 280
        Me.Label20.Text = "Tipo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(931, 32)
        Me.Label14.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 30)
        Me.Label14.TabIndex = 279
        Me.Label14.Text = "Orden"
        '
        'TB_O_PRODUCTO
        '
        Me.TB_O_PRODUCTO.AccessibleDescription = ""
        Me.TB_O_PRODUCTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_O_PRODUCTO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_O_PRODUCTO.Location = New System.Drawing.Point(931, 63)
        Me.TB_O_PRODUCTO.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_O_PRODUCTO.Name = "TB_O_PRODUCTO"
        Me.TB_O_PRODUCTO.Size = New System.Drawing.Size(166, 36)
        Me.TB_O_PRODUCTO.TabIndex = 278
        Me.TB_O_PRODUCTO.Tag = "1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(753, 32)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 30)
        Me.Label12.TabIndex = 277
        Me.Label12.Text = "Siglas"
        '
        'TB_K_PRODUCTO
        '
        Me.TB_K_PRODUCTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_K_PRODUCTO.Enabled = False
        Me.TB_K_PRODUCTO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_K_PRODUCTO.Location = New System.Drawing.Point(50, 63)
        Me.TB_K_PRODUCTO.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_K_PRODUCTO.Name = "TB_K_PRODUCTO"
        Me.TB_K_PRODUCTO.Size = New System.Drawing.Size(96, 36)
        Me.TB_K_PRODUCTO.TabIndex = 0
        '
        'TB_S_PRODUCTO
        '
        Me.TB_S_PRODUCTO.AccessibleDescription = ""
        Me.TB_S_PRODUCTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_S_PRODUCTO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_S_PRODUCTO.Location = New System.Drawing.Point(753, 63)
        Me.TB_S_PRODUCTO.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_S_PRODUCTO.Name = "TB_S_PRODUCTO"
        Me.TB_S_PRODUCTO.Size = New System.Drawing.Size(166, 36)
        Me.TB_S_PRODUCTO.TabIndex = 276
        Me.TB_S_PRODUCTO.Tag = "1"
        '
        'TB_K_PDV
        '
        Me.TB_K_PDV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_K_PDV.Enabled = False
        Me.TB_K_PDV.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_K_PDV.Location = New System.Drawing.Point(50, 63)
        Me.TB_K_PDV.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_K_PDV.Name = "TB_K_PDV"
        Me.TB_K_PDV.Size = New System.Drawing.Size(58, 36)
        Me.TB_K_PDV.TabIndex = 257
        Me.TB_K_PDV.Visible = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(164, 33)
        Me.Label30.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(125, 30)
        Me.Label30.TabIndex = 191
        Me.Label30.Text = "Descripción"
        '
        'TB_D_PRODUCTO
        '
        Me.TB_D_PRODUCTO.AccessibleDescription = ""
        Me.TB_D_PRODUCTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_D_PRODUCTO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_D_PRODUCTO.Location = New System.Drawing.Point(170, 63)
        Me.TB_D_PRODUCTO.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_D_PRODUCTO.Name = "TB_D_PRODUCTO"
        Me.TB_D_PRODUCTO.Size = New System.Drawing.Size(572, 36)
        Me.TB_D_PRODUCTO.TabIndex = 1
        Me.TB_D_PRODUCTO.Tag = "1"
        '
        'CB_USUARIO_CAMBIO
        '
        Me.CB_USUARIO_CAMBIO.Enabled = False
        Me.CB_USUARIO_CAMBIO.FormattingEnabled = True
        Me.CB_USUARIO_CAMBIO.Location = New System.Drawing.Point(562, 464)
        Me.CB_USUARIO_CAMBIO.Margin = New System.Windows.Forms.Padding(6)
        Me.CB_USUARIO_CAMBIO.Name = "CB_USUARIO_CAMBIO"
        Me.CB_USUARIO_CAMBIO.Size = New System.Drawing.Size(294, 33)
        Me.CB_USUARIO_CAMBIO.TabIndex = 41
        '
        'CB_USUARIO_ALTA
        '
        Me.CB_USUARIO_ALTA.Enabled = False
        Me.CB_USUARIO_ALTA.FormattingEnabled = True
        Me.CB_USUARIO_ALTA.Location = New System.Drawing.Point(46, 464)
        Me.CB_USUARIO_ALTA.Margin = New System.Windows.Forms.Padding(6)
        Me.CB_USUARIO_ALTA.Name = "CB_USUARIO_ALTA"
        Me.CB_USUARIO_ALTA.Size = New System.Drawing.Size(242, 33)
        Me.CB_USUARIO_ALTA.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(304, 431)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 30)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Fecha Alta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(880, 431)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(204, 30)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Ultima modificación"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(544, 433)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(315, 30)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Usuario de Ultima Modificación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 435)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 30)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Usuario Alta"
        '
        'TB_F_ALTA
        '
        Me.TB_F_ALTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_F_ALTA.Enabled = False
        Me.TB_F_ALTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_F_ALTA.Location = New System.Drawing.Point(304, 462)
        Me.TB_F_ALTA.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_F_ALTA.Name = "TB_F_ALTA"
        Me.TB_F_ALTA.Size = New System.Drawing.Size(242, 36)
        Me.TB_F_ALTA.TabIndex = 34
        '
        'TB_F_CAMBIO
        '
        Me.TB_F_CAMBIO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_F_CAMBIO.Enabled = False
        Me.TB_F_CAMBIO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_F_CAMBIO.Location = New System.Drawing.Point(874, 462)
        Me.TB_F_CAMBIO.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_F_CAMBIO.Name = "TB_F_CAMBIO"
        Me.TB_F_CAMBIO.Size = New System.Drawing.Size(242, 36)
        Me.TB_F_CAMBIO.TabIndex = 35
        '
        'CB_ESTATUS_PRODUCTO
        '
        Me.CB_ESTATUS_PRODUCTO.FormattingEnabled = True
        Me.CB_ESTATUS_PRODUCTO.Location = New System.Drawing.Point(62, 180)
        Me.CB_ESTATUS_PRODUCTO.Margin = New System.Windows.Forms.Padding(6)
        Me.CB_ESTATUS_PRODUCTO.Name = "CB_ESTATUS_PRODUCTO"
        Me.CB_ESTATUS_PRODUCTO.Size = New System.Drawing.Size(314, 33)
        Me.CB_ESTATUS_PRODUCTO.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(68, 153)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 26)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Estatus"
        '
        'LB_ID
        '
        Me.LB_ID.AutoSize = True
        Me.LB_ID.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ID.Location = New System.Drawing.Point(56, 33)
        Me.LB_ID.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LB_ID.Name = "LB_ID"
        Me.LB_ID.Size = New System.Drawing.Size(71, 30)
        Me.LB_ID.TabIndex = 19
        Me.LB_ID.Text = "#PRO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(50, 119)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(1047, 302)
        Me.GroupBox1.TabIndex = 294
        Me.GroupBox1.TabStop = False
        '
        'GB_FILTROS
        '
        Me.GB_FILTROS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_FILTROS.BackColor = System.Drawing.Color.White
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_UNIDAD)
        Me.GB_FILTROS.Controls.Add(Me.Label19)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_TIPO_PRODUCTO)
        Me.GB_FILTROS.Controls.Add(Me.Label38)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_ESTATUS_PRODUCTO)
        Me.GB_FILTROS.Controls.Add(Me.BT_LI_BUSCAR)
        Me.GB_FILTROS.Controls.Add(Me.Label13)
        Me.GB_FILTROS.Controls.Add(Me.Label1)
        Me.GB_FILTROS.Controls.Add(Me.TB_LI_BUSCAR)
        Me.GB_FILTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FILTROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_FILTROS.Location = New System.Drawing.Point(28, 106)
        Me.GB_FILTROS.Margin = New System.Windows.Forms.Padding(6)
        Me.GB_FILTROS.Name = "GB_FILTROS"
        Me.GB_FILTROS.Padding = New System.Windows.Forms.Padding(6)
        Me.GB_FILTROS.Size = New System.Drawing.Size(2056, 146)
        Me.GB_FILTROS.TabIndex = 65
        Me.GB_FILTROS.TabStop = False
        Me.GB_FILTROS.Text = "Filtros"
        '
        'CB_LI_UNIDAD
        '
        Me.CB_LI_UNIDAD.FormattingEnabled = True
        Me.CB_LI_UNIDAD.Location = New System.Drawing.Point(1122, 62)
        Me.CB_LI_UNIDAD.Margin = New System.Windows.Forms.Padding(6)
        Me.CB_LI_UNIDAD.Name = "CB_LI_UNIDAD"
        Me.CB_LI_UNIDAD.Size = New System.Drawing.Size(336, 34)
        Me.CB_LI_UNIDAD.TabIndex = 118
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(1128, 31)
        Me.Label19.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 30)
        Me.Label19.TabIndex = 117
        Me.Label19.Text = "Unidad"
        '
        'CB_LI_TIPO_PRODUCTO
        '
        Me.CB_LI_TIPO_PRODUCTO.Enabled = False
        Me.CB_LI_TIPO_PRODUCTO.FormattingEnabled = True
        Me.CB_LI_TIPO_PRODUCTO.Location = New System.Drawing.Point(770, 62)
        Me.CB_LI_TIPO_PRODUCTO.Margin = New System.Windows.Forms.Padding(6)
        Me.CB_LI_TIPO_PRODUCTO.Name = "CB_LI_TIPO_PRODUCTO"
        Me.CB_LI_TIPO_PRODUCTO.Size = New System.Drawing.Size(336, 34)
        Me.CB_LI_TIPO_PRODUCTO.TabIndex = 116
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(776, 31)
        Me.Label38.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(56, 30)
        Me.Label38.TabIndex = 115
        Me.Label38.Text = "Tipo"
        '
        'CB_LI_ESTATUS_PRODUCTO
        '
        Me.CB_LI_ESTATUS_PRODUCTO.FormattingEnabled = True
        Me.CB_LI_ESTATUS_PRODUCTO.Location = New System.Drawing.Point(408, 62)
        Me.CB_LI_ESTATUS_PRODUCTO.Margin = New System.Windows.Forms.Padding(6)
        Me.CB_LI_ESTATUS_PRODUCTO.Name = "CB_LI_ESTATUS_PRODUCTO"
        Me.CB_LI_ESTATUS_PRODUCTO.Size = New System.Drawing.Size(336, 34)
        Me.CB_LI_ESTATUS_PRODUCTO.TabIndex = 9
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
        Me.BT_LI_BUSCAR.Location = New System.Drawing.Point(1684, 34)
        Me.BT_LI_BUSCAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_LI_BUSCAR.Name = "BT_LI_BUSCAR"
        Me.BT_LI_BUSCAR.Size = New System.Drawing.Size(140, 65)
        Me.BT_LI_BUSCAR.TabIndex = 3
        Me.BT_LI_BUSCAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_LI_BUSCAR.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(414, 31)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 30)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Estatus"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 30)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Buscar"
        '
        'TB_LI_BUSCAR
        '
        Me.TB_LI_BUSCAR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_LI_BUSCAR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LI_BUSCAR.Location = New System.Drawing.Point(24, 62)
        Me.TB_LI_BUSCAR.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_LI_BUSCAR.Name = "TB_LI_BUSCAR"
        Me.TB_LI_BUSCAR.Size = New System.Drawing.Size(356, 37)
        Me.TB_LI_BUSCAR.TabIndex = 1
        '
        'FO_PRODUCTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2112, 1163)
        Me.Controls.Add(Me.GB_FILTROS)
        Me.Controls.Add(Me.GB_FICHA)
        Me.Controls.Add(Me.GB_LISTADO)
        Me.Controls.Add(Me.GB_OPERACION)
        Me.Controls.Add(Me.GB_CONTROL)
        Me.Controls.Add(Me.FL_MENU_1)
        Me.Controls.Add(Me.FL_MENU_2)
        Me.Name = "FO_PRODUCTO"
        Me.Text = "FO_PRODUCTO"
        Me.GB_LISTADO.ResumeLayout(False)
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_OPERACION.ResumeLayout(False)
        Me.GB_OPERACION.PerformLayout()
        Me.GB_CONTROL.ResumeLayout(False)
        Me.FL_MENU_1.ResumeLayout(False)
        Me.FL_MENU_2.ResumeLayout(False)
        Me.GB_FICHA.ResumeLayout(False)
        Me.GB_FICHA.PerformLayout()
        Me.GB_FILTROS.ResumeLayout(False)
        Me.GB_FILTROS.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents GB_LISTADO As GroupBox
    Public WithEvents LI_LISTADO As DataGridView
    Public WithEvents GB_OPERACION As GroupBox
    Public WithEvents LB_RESULTADO As TextBox
    Public WithEvents GB_CONTROL As GroupBox
    Public WithEvents LB_VERSION As Label
    Public WithEvents LB_RELOJ As Label
    Public WithEvents BT_AGREGAR As Button
    Public WithEvents FL_MENU_1 As FlowLayoutPanel
    Public WithEvents BT_EDITAR As Button
    Public WithEvents BT_CLONAR As Button
    Public WithEvents BT_ELIMINAR As Button
    Public WithEvents TI_RELOJ As Timer
    Public WithEvents FL_MENU_2 As FlowLayoutPanel
    Public WithEvents BT_SALIR As Button
    Public WithEvents BT_CANCELAR As Button
    Public WithEvents BT_GUARDAR As Button
    Public WithEvents BT_LISTADO As Button
    Public WithEvents BT_EXPORTAR_EXCEL As Button
    Public WithEvents GB_FICHA As GroupBox
    Friend WithEvents Label10 As Label
    Public WithEvents TB_CANTIDAD_LITROS As TextBox
    Friend WithEvents Label8 As Label
    Public WithEvents TB_CANTIDAD_KILOS As TextBox
    Friend WithEvents Label7 As Label
    Public WithEvents TB_FACTOR_LITROS As TextBox
    Friend WithEvents Label4 As Label
    Public WithEvents TB_FACTOR_KILOS As TextBox
    Friend WithEvents Label3 As Label
    Public WithEvents TB_CANTIDAD As TextBox
    Public WithEvents CB_UNIDAD As ComboBox
    Friend WithEvents Label21 As Label
    Public WithEvents CB_TIPO_PRODUCTO As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label14 As Label
    Public WithEvents TB_O_PRODUCTO As TextBox
    Friend WithEvents Label12 As Label
    Public WithEvents TB_K_PRODUCTO As TextBox
    Public WithEvents TB_S_PRODUCTO As TextBox
    Public WithEvents TB_K_PDV As TextBox
    Friend WithEvents Label30 As Label
    Public WithEvents TB_D_PRODUCTO As TextBox
    Public WithEvents CB_USUARIO_CAMBIO As ComboBox
    Public WithEvents CB_USUARIO_ALTA As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents TB_F_ALTA As TextBox
    Public WithEvents TB_F_CAMBIO As TextBox
    Public WithEvents CB_ESTATUS_PRODUCTO As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents LB_ID As Label
    Public WithEvents GroupBox1 As GroupBox
    Public WithEvents GB_FILTROS As GroupBox
    Public WithEvents CB_LI_UNIDAD As ComboBox
    Friend WithEvents Label19 As Label
    Public WithEvents CB_LI_TIPO_PRODUCTO As ComboBox
    Friend WithEvents Label38 As Label
    Public WithEvents CB_LI_ESTATUS_PRODUCTO As ComboBox
    Public WithEvents BT_LI_BUSCAR As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
    Public WithEvents TB_LI_BUSCAR As TextBox
End Class
