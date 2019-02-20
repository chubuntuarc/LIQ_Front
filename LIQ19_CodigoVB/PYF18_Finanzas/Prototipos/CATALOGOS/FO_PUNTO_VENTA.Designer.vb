<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FO_PUNTO_VENTA
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
        Me.TI_RELOJ = New System.Windows.Forms.Timer(Me.components)
        Me.FL_MENU_2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_LISTADO = New System.Windows.Forms.Button()
        Me.BT_EXPORTAR_EXCEL = New System.Windows.Forms.Button()
        Me.BT_SALIR = New System.Windows.Forms.Button()
        Me.BT_CANCELAR = New System.Windows.Forms.Button()
        Me.BT_GUARDAR = New System.Windows.Forms.Button()
        Me.GB_FILTROS = New System.Windows.Forms.GroupBox()
        Me.CB_LI_K_UNIDAD_OPERATIVA = New System.Windows.Forms.ComboBox()
        Me.BT_LI_BUSCAR = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CB_LI_ESTATUS_PUNTO_VENTA = New System.Windows.Forms.ComboBox()
        Me.CB_LI_TIPO_PUNTO_VENTA = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_LI_BUSCAR = New System.Windows.Forms.TextBox()
        Me.GB_LISTADO = New System.Windows.Forms.GroupBox()
        Me.LI_LISTADO = New System.Windows.Forms.DataGridView()
        Me.GB_OPERACION = New System.Windows.Forms.GroupBox()
        Me.LB_RESULTADO = New System.Windows.Forms.TextBox()
        Me.GB_CONTROL = New System.Windows.Forms.GroupBox()
        Me.LB_VERSION = New System.Windows.Forms.Label()
        Me.LB_RELOJ = New System.Windows.Forms.Label()
        Me.FL_MENU_1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_AGREGAR = New System.Windows.Forms.Button()
        Me.BT_EDITAR = New System.Windows.Forms.Button()
        Me.BT_CLONAR = New System.Windows.Forms.Button()
        Me.BT_ELIMINAR = New System.Windows.Forms.Button()
        Me.TB_D_PUNTO_VENTA = New System.Windows.Forms.TextBox()
        Me.TB_C_PUNTO_VENTA = New System.Windows.Forms.TextBox()
        Me.TB_S_PUNTO_VENTA = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LB_ID = New System.Windows.Forms.Label()
        Me.TB_K_PUNTO_VENTA = New System.Windows.Forms.TextBox()
        Me.TB_O_PUNTO_VENTA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CH_L_PUNTO_VENTA = New System.Windows.Forms.CheckBox()
        Me.CB_TIPO_PUNTO_VENTA = New System.Windows.Forms.ComboBox()
        Me.TB_F_CAMBIO = New System.Windows.Forms.TextBox()
        Me.TB_F_ALTA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CB_USUARIO_ALTA = New System.Windows.Forms.ComboBox()
        Me.CB_USUARIO_CAMBIO = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CB_UNIDAD_OPERATIVA = New System.Windows.Forms.ComboBox()
        Me.GB_AUTOTANQUE = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TB_MATRICULA_AUT = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TB_TIPO_MEDIDOR_AUT = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TB_MEDIDOR_AUT = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TB_PORCENTAJE_AUT = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TB_CAPACIDAD_AUT = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TB_SERIE_AUT = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TB_KILOMETRAJE_AUT = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TB_MODELO_AUT = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TB_MARCA_AUT = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TB_LECTURA_FINAL_AUT = New System.Windows.Forms.TextBox()
        Me.LB_LECTURA_INICIAL_AUT = New System.Windows.Forms.Label()
        Me.TB_LECTURA_INICIAL_AUT = New System.Windows.Forms.TextBox()
        Me.GB_FICHA = New System.Windows.Forms.GroupBox()
        Me.GB_PORTATIL = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TB_CAPACIDAD_POR = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TB_SERIE_POR = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TB_KILOMETRAJE_POR = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TB_MODELO_POR = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.TB_MARCA_POR = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TB_MATRICULA_POR = New System.Windows.Forms.TextBox()
        Me.GB_ESTACION_CARBURACION = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TB_TIPO_MEDIDOR_EST = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TB_MEDIDOR_EST = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TB_PORCENTAJE_EST = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TB_CAPACIDAD_EST = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TB_DIRECCION_EST = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TB_LECTURA_FINAL_EST = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TB_LECTURA_INICIAL_EST = New System.Windows.Forms.TextBox()
        Me.CB_OPERADOR = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.CB_AYUDANTE_1 = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.CB_AYUDANTE_2 = New System.Windows.Forms.ComboBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.FL_MENU_2.SuspendLayout()
        Me.GB_FILTROS.SuspendLayout()
        Me.GB_LISTADO.SuspendLayout()
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_OPERACION.SuspendLayout()
        Me.GB_CONTROL.SuspendLayout()
        Me.FL_MENU_1.SuspendLayout()
        Me.GB_AUTOTANQUE.SuspendLayout()
        Me.GB_FICHA.SuspendLayout()
        Me.GB_PORTATIL.SuspendLayout()
        Me.GB_ESTACION_CARBURACION.SuspendLayout()
        Me.SuspendLayout()
        '
        'TI_RELOJ
        '
        '
        'FL_MENU_2
        '
        Me.FL_MENU_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FL_MENU_2.BackColor = System.Drawing.Color.White
        Me.FL_MENU_2.Controls.Add(Me.BT_LISTADO)
        Me.FL_MENU_2.Controls.Add(Me.BT_EXPORTAR_EXCEL)
        Me.FL_MENU_2.Controls.Add(Me.BT_SALIR)
        Me.FL_MENU_2.Controls.Add(Me.BT_CANCELAR)
        Me.FL_MENU_2.Controls.Add(Me.BT_GUARDAR)
        Me.FL_MENU_2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FL_MENU_2.Location = New System.Drawing.Point(662, 7)
        Me.FL_MENU_2.Name = "FL_MENU_2"
        Me.FL_MENU_2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FL_MENU_2.Size = New System.Drawing.Size(382, 40)
        Me.FL_MENU_2.TabIndex = 46
        '
        'BT_LISTADO
        '
        Me.BT_LISTADO.BackColor = System.Drawing.Color.White
        Me.BT_LISTADO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_LISTADO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_LISTADO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_LISTADO.Image = Global.PYF18_Finanzas.My.Resources.Resources.listado
        Me.BT_LISTADO.Location = New System.Drawing.Point(309, 6)
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
        Me.BT_EXPORTAR_EXCEL.Location = New System.Drawing.Point(233, 6)
        Me.BT_EXPORTAR_EXCEL.Name = "BT_EXPORTAR_EXCEL"
        Me.BT_EXPORTAR_EXCEL.Size = New System.Drawing.Size(70, 34)
        Me.BT_EXPORTAR_EXCEL.TabIndex = 28
        Me.BT_EXPORTAR_EXCEL.Tag = "Copiar al portapapeles"
        Me.BT_EXPORTAR_EXCEL.UseVisualStyleBackColor = True
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
        Me.BT_SALIR.Location = New System.Drawing.Point(160, 6)
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
        Me.BT_CANCELAR.Location = New System.Drawing.Point(90, 6)
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
        Me.BT_GUARDAR.Location = New System.Drawing.Point(20, 6)
        Me.BT_GUARDAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_GUARDAR.Name = "BT_GUARDAR"
        Me.BT_GUARDAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_GUARDAR.TabIndex = 23
        Me.BT_GUARDAR.UseVisualStyleBackColor = True
        '
        'GB_FILTROS
        '
        Me.GB_FILTROS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_FILTROS.BackColor = System.Drawing.Color.White
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_K_UNIDAD_OPERATIVA)
        Me.GB_FILTROS.Controls.Add(Me.BT_LI_BUSCAR)
        Me.GB_FILTROS.Controls.Add(Me.Label21)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_ESTATUS_PUNTO_VENTA)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_TIPO_PUNTO_VENTA)
        Me.GB_FILTROS.Controls.Add(Me.Label13)
        Me.GB_FILTROS.Controls.Add(Me.Label14)
        Me.GB_FILTROS.Controls.Add(Me.Label1)
        Me.GB_FILTROS.Controls.Add(Me.TB_LI_BUSCAR)
        Me.GB_FILTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FILTROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_FILTROS.Location = New System.Drawing.Point(14, 56)
        Me.GB_FILTROS.Name = "GB_FILTROS"
        Me.GB_FILTROS.Size = New System.Drawing.Size(1028, 77)
        Me.GB_FILTROS.TabIndex = 41
        Me.GB_FILTROS.TabStop = False
        Me.GB_FILTROS.Text = "Filtros"
        '
        'CB_LI_K_UNIDAD_OPERATIVA
        '
        Me.CB_LI_K_UNIDAD_OPERATIVA.FormattingEnabled = True
        Me.CB_LI_K_UNIDAD_OPERATIVA.Location = New System.Drawing.Point(566, 32)
        Me.CB_LI_K_UNIDAD_OPERATIVA.Name = "CB_LI_K_UNIDAD_OPERATIVA"
        Me.CB_LI_K_UNIDAD_OPERATIVA.Size = New System.Drawing.Size(170, 21)
        Me.CB_LI_K_UNIDAD_OPERATIVA.TabIndex = 120
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
        Me.BT_LI_BUSCAR.Location = New System.Drawing.Point(946, 20)
        Me.BT_LI_BUSCAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_LI_BUSCAR.Name = "BT_LI_BUSCAR"
        Me.BT_LI_BUSCAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_LI_BUSCAR.TabIndex = 3
        Me.BT_LI_BUSCAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_LI_BUSCAR.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(570, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(90, 13)
        Me.Label21.TabIndex = 119
        Me.Label21.Text = "Unidad Operativa"
        '
        'CB_LI_ESTATUS_PUNTO_VENTA
        '
        Me.CB_LI_ESTATUS_PUNTO_VENTA.FormattingEnabled = True
        Me.CB_LI_ESTATUS_PUNTO_VENTA.Location = New System.Drawing.Point(387, 32)
        Me.CB_LI_ESTATUS_PUNTO_VENTA.Name = "CB_LI_ESTATUS_PUNTO_VENTA"
        Me.CB_LI_ESTATUS_PUNTO_VENTA.Size = New System.Drawing.Size(170, 21)
        Me.CB_LI_ESTATUS_PUNTO_VENTA.TabIndex = 9
        '
        'CB_LI_TIPO_PUNTO_VENTA
        '
        Me.CB_LI_TIPO_PUNTO_VENTA.FormattingEnabled = True
        Me.CB_LI_TIPO_PUNTO_VENTA.Location = New System.Drawing.Point(198, 33)
        Me.CB_LI_TIPO_PUNTO_VENTA.Name = "CB_LI_TIPO_PUNTO_VENTA"
        Me.CB_LI_TIPO_PUNTO_VENTA.Size = New System.Drawing.Size(180, 21)
        Me.CB_LI_TIPO_PUNTO_VENTA.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(390, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Estatus"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(201, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Tipo"
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
        Me.GB_LISTADO.Location = New System.Drawing.Point(14, 140)
        Me.GB_LISTADO.Name = "GB_LISTADO"
        Me.GB_LISTADO.Size = New System.Drawing.Size(1028, 353)
        Me.GB_LISTADO.TabIndex = 42
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
        Me.LI_LISTADO.Size = New System.Drawing.Size(1005, 314)
        Me.LI_LISTADO.TabIndex = 2
        '
        'GB_OPERACION
        '
        Me.GB_OPERACION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_OPERACION.BackColor = System.Drawing.Color.White
        Me.GB_OPERACION.Controls.Add(Me.LB_RESULTADO)
        Me.GB_OPERACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_OPERACION.Location = New System.Drawing.Point(13, 499)
        Me.GB_OPERACION.Name = "GB_OPERACION"
        Me.GB_OPERACION.Size = New System.Drawing.Size(582, 52)
        Me.GB_OPERACION.TabIndex = 43
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
        'GB_CONTROL
        '
        Me.GB_CONTROL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_CONTROL.BackColor = System.Drawing.Color.White
        Me.GB_CONTROL.Controls.Add(Me.LB_VERSION)
        Me.GB_CONTROL.Controls.Add(Me.LB_RELOJ)
        Me.GB_CONTROL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_CONTROL.Location = New System.Drawing.Point(601, 499)
        Me.GB_CONTROL.Name = "GB_CONTROL"
        Me.GB_CONTROL.Size = New System.Drawing.Size(440, 52)
        Me.GB_CONTROL.TabIndex = 44
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
        Me.FL_MENU_1.Location = New System.Drawing.Point(14, 7)
        Me.FL_MENU_1.Name = "FL_MENU_1"
        Me.FL_MENU_1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FL_MENU_1.Size = New System.Drawing.Size(1028, 40)
        Me.FL_MENU_1.TabIndex = 45
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
        'TB_D_PUNTO_VENTA
        '
        Me.TB_D_PUNTO_VENTA.AccessibleDescription = ""
        Me.TB_D_PUNTO_VENTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_D_PUNTO_VENTA.Location = New System.Drawing.Point(130, 44)
        Me.TB_D_PUNTO_VENTA.Name = "TB_D_PUNTO_VENTA"
        Me.TB_D_PUNTO_VENTA.Size = New System.Drawing.Size(220, 22)
        Me.TB_D_PUNTO_VENTA.TabIndex = 8
        Me.TB_D_PUNTO_VENTA.Tag = "1"
        '
        'TB_C_PUNTO_VENTA
        '
        Me.TB_C_PUNTO_VENTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_C_PUNTO_VENTA.Location = New System.Drawing.Point(620, 83)
        Me.TB_C_PUNTO_VENTA.Name = "TB_C_PUNTO_VENTA"
        Me.TB_C_PUNTO_VENTA.Size = New System.Drawing.Size(233, 22)
        Me.TB_C_PUNTO_VENTA.TabIndex = 10
        '
        'TB_S_PUNTO_VENTA
        '
        Me.TB_S_PUNTO_VENTA.AccessibleDescription = ""
        Me.TB_S_PUNTO_VENTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_S_PUNTO_VENTA.Location = New System.Drawing.Point(359, 43)
        Me.TB_S_PUNTO_VENTA.Name = "TB_S_PUNTO_VENTA"
        Me.TB_S_PUNTO_VENTA.Size = New System.Drawing.Size(78, 22)
        Me.TB_S_PUNTO_VENTA.TabIndex = 9
        Me.TB_S_PUNTO_VENTA.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(132, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Descripción"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(624, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Comentarios"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(363, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Siglas"
        '
        'LB_ID
        '
        Me.LB_ID.AutoSize = True
        Me.LB_ID.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ID.Location = New System.Drawing.Point(39, 28)
        Me.LB_ID.Name = "LB_ID"
        Me.LB_ID.Size = New System.Drawing.Size(36, 13)
        Me.LB_ID.TabIndex = 19
        Me.LB_ID.Text = "#PDV"
        '
        'TB_K_PUNTO_VENTA
        '
        Me.TB_K_PUNTO_VENTA.Enabled = False
        Me.TB_K_PUNTO_VENTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_K_PUNTO_VENTA.Location = New System.Drawing.Point(36, 44)
        Me.TB_K_PUNTO_VENTA.Name = "TB_K_PUNTO_VENTA"
        Me.TB_K_PUNTO_VENTA.Size = New System.Drawing.Size(42, 22)
        Me.TB_K_PUNTO_VENTA.TabIndex = 21
        '
        'TB_O_PUNTO_VENTA
        '
        Me.TB_O_PUNTO_VENTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_O_PUNTO_VENTA.Location = New System.Drawing.Point(85, 46)
        Me.TB_O_PUNTO_VENTA.Name = "TB_O_PUNTO_VENTA"
        Me.TB_O_PUNTO_VENTA.Size = New System.Drawing.Size(40, 20)
        Me.TB_O_PUNTO_VENTA.TabIndex = 26
        Me.TB_O_PUNTO_VENTA.Tag = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(87, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Orden"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(448, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Tipo"
        '
        'CH_L_PUNTO_VENTA
        '
        Me.CH_L_PUNTO_VENTA.AutoSize = True
        Me.CH_L_PUNTO_VENTA.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CH_L_PUNTO_VENTA.Enabled = False
        Me.CH_L_PUNTO_VENTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CH_L_PUNTO_VENTA.Location = New System.Drawing.Point(874, 34)
        Me.CH_L_PUNTO_VENTA.Name = "CH_L_PUNTO_VENTA"
        Me.CH_L_PUNTO_VENTA.Size = New System.Drawing.Size(41, 31)
        Me.CH_L_PUNTO_VENTA.TabIndex = 30
        Me.CH_L_PUNTO_VENTA.Text = "Activo"
        Me.CH_L_PUNTO_VENTA.UseVisualStyleBackColor = True
        '
        'CB_TIPO_PUNTO_VENTA
        '
        Me.CB_TIPO_PUNTO_VENTA.FormattingEnabled = True
        Me.CB_TIPO_PUNTO_VENTA.Location = New System.Drawing.Point(444, 43)
        Me.CB_TIPO_PUNTO_VENTA.Name = "CB_TIPO_PUNTO_VENTA"
        Me.CB_TIPO_PUNTO_VENTA.Size = New System.Drawing.Size(170, 21)
        Me.CB_TIPO_PUNTO_VENTA.TabIndex = 31
        '
        'TB_F_CAMBIO
        '
        Me.TB_F_CAMBIO.Enabled = False
        Me.TB_F_CAMBIO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_F_CAMBIO.Location = New System.Drawing.Point(707, 351)
        Me.TB_F_CAMBIO.Name = "TB_F_CAMBIO"
        Me.TB_F_CAMBIO.Size = New System.Drawing.Size(215, 22)
        Me.TB_F_CAMBIO.TabIndex = 35
        '
        'TB_F_ALTA
        '
        Me.TB_F_ALTA.Enabled = False
        Me.TB_F_ALTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_F_ALTA.Location = New System.Drawing.Point(258, 350)
        Me.TB_F_ALTA.Name = "TB_F_ALTA"
        Me.TB_F_ALTA.Size = New System.Drawing.Size(215, 22)
        Me.TB_F_ALTA.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 335)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Usuario Alta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(485, 335)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Usuario de Ultima Modificación"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(710, 335)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Ultima modificación"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(261, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Fecha Alta"
        '
        'CB_USUARIO_ALTA
        '
        Me.CB_USUARIO_ALTA.Enabled = False
        Me.CB_USUARIO_ALTA.FormattingEnabled = True
        Me.CB_USUARIO_ALTA.Location = New System.Drawing.Point(36, 350)
        Me.CB_USUARIO_ALTA.Name = "CB_USUARIO_ALTA"
        Me.CB_USUARIO_ALTA.Size = New System.Drawing.Size(215, 21)
        Me.CB_USUARIO_ALTA.TabIndex = 40
        '
        'CB_USUARIO_CAMBIO
        '
        Me.CB_USUARIO_CAMBIO.Enabled = False
        Me.CB_USUARIO_CAMBIO.FormattingEnabled = True
        Me.CB_USUARIO_CAMBIO.Location = New System.Drawing.Point(482, 351)
        Me.CB_USUARIO_CAMBIO.Name = "CB_USUARIO_CAMBIO"
        Me.CB_USUARIO_CAMBIO.Size = New System.Drawing.Size(215, 21)
        Me.CB_USUARIO_CAMBIO.TabIndex = 41
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(622, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 13)
        Me.Label12.TabIndex = 126
        Me.Label12.Text = "Unidad operativa"
        '
        'CB_UNIDAD_OPERATIVA
        '
        Me.CB_UNIDAD_OPERATIVA.FormattingEnabled = True
        Me.CB_UNIDAD_OPERATIVA.Location = New System.Drawing.Point(620, 44)
        Me.CB_UNIDAD_OPERATIVA.Name = "CB_UNIDAD_OPERATIVA"
        Me.CB_UNIDAD_OPERATIVA.Size = New System.Drawing.Size(233, 21)
        Me.CB_UNIDAD_OPERATIVA.TabIndex = 149
        '
        'GB_AUTOTANQUE
        '
        Me.GB_AUTOTANQUE.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GB_AUTOTANQUE.BackColor = System.Drawing.Color.White
        Me.GB_AUTOTANQUE.Controls.Add(Me.Label24)
        Me.GB_AUTOTANQUE.Controls.Add(Me.TB_MATRICULA_AUT)
        Me.GB_AUTOTANQUE.Controls.Add(Me.Label23)
        Me.GB_AUTOTANQUE.Controls.Add(Me.TB_TIPO_MEDIDOR_AUT)
        Me.GB_AUTOTANQUE.Controls.Add(Me.Label22)
        Me.GB_AUTOTANQUE.Controls.Add(Me.TB_MEDIDOR_AUT)
        Me.GB_AUTOTANQUE.Controls.Add(Me.Label20)
        Me.GB_AUTOTANQUE.Controls.Add(Me.TB_PORCENTAJE_AUT)
        Me.GB_AUTOTANQUE.Controls.Add(Me.Label19)
        Me.GB_AUTOTANQUE.Controls.Add(Me.TB_CAPACIDAD_AUT)
        Me.GB_AUTOTANQUE.Controls.Add(Me.Label18)
        Me.GB_AUTOTANQUE.Controls.Add(Me.TB_SERIE_AUT)
        Me.GB_AUTOTANQUE.Controls.Add(Me.Label17)
        Me.GB_AUTOTANQUE.Controls.Add(Me.TB_KILOMETRAJE_AUT)
        Me.GB_AUTOTANQUE.Controls.Add(Me.Label16)
        Me.GB_AUTOTANQUE.Controls.Add(Me.TB_MODELO_AUT)
        Me.GB_AUTOTANQUE.Controls.Add(Me.Label15)
        Me.GB_AUTOTANQUE.Controls.Add(Me.TB_MARCA_AUT)
        Me.GB_AUTOTANQUE.Controls.Add(Me.Label10)
        Me.GB_AUTOTANQUE.Controls.Add(Me.TB_LECTURA_FINAL_AUT)
        Me.GB_AUTOTANQUE.Controls.Add(Me.LB_LECTURA_INICIAL_AUT)
        Me.GB_AUTOTANQUE.Controls.Add(Me.TB_LECTURA_INICIAL_AUT)
        Me.GB_AUTOTANQUE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_AUTOTANQUE.Location = New System.Drawing.Point(6, 111)
        Me.GB_AUTOTANQUE.Name = "GB_AUTOTANQUE"
        Me.GB_AUTOTANQUE.Size = New System.Drawing.Size(946, 220)
        Me.GB_AUTOTANQUE.TabIndex = 150
        Me.GB_AUTOTANQUE.TabStop = False
        Me.GB_AUTOTANQUE.Text = "Detalles Autotanque"
        Me.GB_AUTOTANQUE.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(483, 25)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(55, 13)
        Me.Label24.TabIndex = 172
        Me.Label24.Text = "Matricula"
        '
        'TB_MATRICULA_AUT
        '
        Me.TB_MATRICULA_AUT.AccessibleDescription = ""
        Me.TB_MATRICULA_AUT.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_MATRICULA_AUT.Location = New System.Drawing.Point(480, 41)
        Me.TB_MATRICULA_AUT.Name = "TB_MATRICULA_AUT"
        Me.TB_MATRICULA_AUT.Size = New System.Drawing.Size(220, 22)
        Me.TB_MATRICULA_AUT.TabIndex = 171
        Me.TB_MATRICULA_AUT.Tag = ""
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(483, 155)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(76, 13)
        Me.Label23.TabIndex = 170
        Me.Label23.Text = "Tipo Medidor"
        '
        'TB_TIPO_MEDIDOR_AUT
        '
        Me.TB_TIPO_MEDIDOR_AUT.AccessibleDescription = ""
        Me.TB_TIPO_MEDIDOR_AUT.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_TIPO_MEDIDOR_AUT.Location = New System.Drawing.Point(480, 172)
        Me.TB_TIPO_MEDIDOR_AUT.Name = "TB_TIPO_MEDIDOR_AUT"
        Me.TB_TIPO_MEDIDOR_AUT.Size = New System.Drawing.Size(220, 22)
        Me.TB_TIPO_MEDIDOR_AUT.TabIndex = 169
        Me.TB_TIPO_MEDIDOR_AUT.Tag = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(250, 155)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 13)
        Me.Label22.TabIndex = 168
        Me.Label22.Text = "Medidor"
        '
        'TB_MEDIDOR_AUT
        '
        Me.TB_MEDIDOR_AUT.AccessibleDescription = ""
        Me.TB_MEDIDOR_AUT.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_MEDIDOR_AUT.Location = New System.Drawing.Point(246, 172)
        Me.TB_MEDIDOR_AUT.Name = "TB_MEDIDOR_AUT"
        Me.TB_MEDIDOR_AUT.Size = New System.Drawing.Size(220, 22)
        Me.TB_MEDIDOR_AUT.TabIndex = 167
        Me.TB_MEDIDOR_AUT.Tag = ""
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 155)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(61, 13)
        Me.Label20.TabIndex = 166
        Me.Label20.Text = "Porcentaje"
        '
        'TB_PORCENTAJE_AUT
        '
        Me.TB_PORCENTAJE_AUT.AccessibleDescription = ""
        Me.TB_PORCENTAJE_AUT.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PORCENTAJE_AUT.Location = New System.Drawing.Point(13, 172)
        Me.TB_PORCENTAJE_AUT.Name = "TB_PORCENTAJE_AUT"
        Me.TB_PORCENTAJE_AUT.Size = New System.Drawing.Size(220, 22)
        Me.TB_PORCENTAJE_AUT.TabIndex = 165
        Me.TB_PORCENTAJE_AUT.Tag = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(718, 86)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 13)
        Me.Label19.TabIndex = 164
        Me.Label19.Text = "Capacidad"
        '
        'TB_CAPACIDAD_AUT
        '
        Me.TB_CAPACIDAD_AUT.AccessibleDescription = ""
        Me.TB_CAPACIDAD_AUT.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CAPACIDAD_AUT.Location = New System.Drawing.Point(716, 102)
        Me.TB_CAPACIDAD_AUT.Name = "TB_CAPACIDAD_AUT"
        Me.TB_CAPACIDAD_AUT.Size = New System.Drawing.Size(220, 22)
        Me.TB_CAPACIDAD_AUT.TabIndex = 163
        Me.TB_CAPACIDAD_AUT.Tag = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(484, 86)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 13)
        Me.Label18.TabIndex = 162
        Me.Label18.Text = "Serie"
        '
        'TB_SERIE_AUT
        '
        Me.TB_SERIE_AUT.AccessibleDescription = ""
        Me.TB_SERIE_AUT.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_SERIE_AUT.Location = New System.Drawing.Point(482, 102)
        Me.TB_SERIE_AUT.Name = "TB_SERIE_AUT"
        Me.TB_SERIE_AUT.Size = New System.Drawing.Size(220, 22)
        Me.TB_SERIE_AUT.TabIndex = 161
        Me.TB_SERIE_AUT.Tag = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(251, 86)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 13)
        Me.Label17.TabIndex = 160
        Me.Label17.Text = "Kilometraje"
        '
        'TB_KILOMETRAJE_AUT
        '
        Me.TB_KILOMETRAJE_AUT.AccessibleDescription = ""
        Me.TB_KILOMETRAJE_AUT.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_KILOMETRAJE_AUT.Location = New System.Drawing.Point(248, 102)
        Me.TB_KILOMETRAJE_AUT.Name = "TB_KILOMETRAJE_AUT"
        Me.TB_KILOMETRAJE_AUT.Size = New System.Drawing.Size(220, 22)
        Me.TB_KILOMETRAJE_AUT.TabIndex = 159
        Me.TB_KILOMETRAJE_AUT.Tag = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 86)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 158
        Me.Label16.Text = "Modelo"
        '
        'TB_MODELO_AUT
        '
        Me.TB_MODELO_AUT.AccessibleDescription = ""
        Me.TB_MODELO_AUT.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_MODELO_AUT.Location = New System.Drawing.Point(13, 102)
        Me.TB_MODELO_AUT.Name = "TB_MODELO_AUT"
        Me.TB_MODELO_AUT.Size = New System.Drawing.Size(220, 22)
        Me.TB_MODELO_AUT.TabIndex = 157
        Me.TB_MODELO_AUT.Tag = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(718, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 156
        Me.Label15.Text = "Marca"
        '
        'TB_MARCA_AUT
        '
        Me.TB_MARCA_AUT.AccessibleDescription = ""
        Me.TB_MARCA_AUT.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_MARCA_AUT.Location = New System.Drawing.Point(716, 41)
        Me.TB_MARCA_AUT.Name = "TB_MARCA_AUT"
        Me.TB_MARCA_AUT.Size = New System.Drawing.Size(220, 22)
        Me.TB_MARCA_AUT.TabIndex = 155
        Me.TB_MARCA_AUT.Tag = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(250, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 154
        Me.Label10.Text = "Lectura final"
        '
        'TB_LECTURA_FINAL_AUT
        '
        Me.TB_LECTURA_FINAL_AUT.AccessibleDescription = ""
        Me.TB_LECTURA_FINAL_AUT.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LECTURA_FINAL_AUT.Location = New System.Drawing.Point(246, 41)
        Me.TB_LECTURA_FINAL_AUT.Name = "TB_LECTURA_FINAL_AUT"
        Me.TB_LECTURA_FINAL_AUT.Size = New System.Drawing.Size(220, 22)
        Me.TB_LECTURA_FINAL_AUT.TabIndex = 153
        Me.TB_LECTURA_FINAL_AUT.Tag = ""
        '
        'LB_LECTURA_INICIAL_AUT
        '
        Me.LB_LECTURA_INICIAL_AUT.AutoSize = True
        Me.LB_LECTURA_INICIAL_AUT.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_LECTURA_INICIAL_AUT.Location = New System.Drawing.Point(16, 25)
        Me.LB_LECTURA_INICIAL_AUT.Name = "LB_LECTURA_INICIAL_AUT"
        Me.LB_LECTURA_INICIAL_AUT.Size = New System.Drawing.Size(77, 13)
        Me.LB_LECTURA_INICIAL_AUT.TabIndex = 152
        Me.LB_LECTURA_INICIAL_AUT.Text = "Lectura inicial"
        '
        'TB_LECTURA_INICIAL_AUT
        '
        Me.TB_LECTURA_INICIAL_AUT.AccessibleDescription = ""
        Me.TB_LECTURA_INICIAL_AUT.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LECTURA_INICIAL_AUT.Location = New System.Drawing.Point(13, 41)
        Me.TB_LECTURA_INICIAL_AUT.Name = "TB_LECTURA_INICIAL_AUT"
        Me.TB_LECTURA_INICIAL_AUT.Size = New System.Drawing.Size(220, 22)
        Me.TB_LECTURA_INICIAL_AUT.TabIndex = 151
        Me.TB_LECTURA_INICIAL_AUT.Tag = ""
        '
        'GB_FICHA
        '
        Me.GB_FICHA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GB_FICHA.BackColor = System.Drawing.Color.White
        Me.GB_FICHA.Controls.Add(Me.CB_AYUDANTE_2)
        Me.GB_FICHA.Controls.Add(Me.Label40)
        Me.GB_FICHA.Controls.Add(Me.CB_AYUDANTE_1)
        Me.GB_FICHA.Controls.Add(Me.Label39)
        Me.GB_FICHA.Controls.Add(Me.CB_OPERADOR)
        Me.GB_FICHA.Controls.Add(Me.Label38)
        Me.GB_FICHA.Controls.Add(Me.GB_ESTACION_CARBURACION)
        Me.GB_FICHA.Controls.Add(Me.GB_AUTOTANQUE)
        Me.GB_FICHA.Controls.Add(Me.CB_UNIDAD_OPERATIVA)
        Me.GB_FICHA.Controls.Add(Me.Label12)
        Me.GB_FICHA.Controls.Add(Me.CB_USUARIO_CAMBIO)
        Me.GB_FICHA.Controls.Add(Me.CB_USUARIO_ALTA)
        Me.GB_FICHA.Controls.Add(Me.Label5)
        Me.GB_FICHA.Controls.Add(Me.Label9)
        Me.GB_FICHA.Controls.Add(Me.Label6)
        Me.GB_FICHA.Controls.Add(Me.Label2)
        Me.GB_FICHA.Controls.Add(Me.TB_F_ALTA)
        Me.GB_FICHA.Controls.Add(Me.TB_F_CAMBIO)
        Me.GB_FICHA.Controls.Add(Me.CB_TIPO_PUNTO_VENTA)
        Me.GB_FICHA.Controls.Add(Me.CH_L_PUNTO_VENTA)
        Me.GB_FICHA.Controls.Add(Me.Label11)
        Me.GB_FICHA.Controls.Add(Me.Label4)
        Me.GB_FICHA.Controls.Add(Me.TB_O_PUNTO_VENTA)
        Me.GB_FICHA.Controls.Add(Me.TB_K_PUNTO_VENTA)
        Me.GB_FICHA.Controls.Add(Me.LB_ID)
        Me.GB_FICHA.Controls.Add(Me.Label3)
        Me.GB_FICHA.Controls.Add(Me.Label7)
        Me.GB_FICHA.Controls.Add(Me.Label8)
        Me.GB_FICHA.Controls.Add(Me.TB_S_PUNTO_VENTA)
        Me.GB_FICHA.Controls.Add(Me.TB_C_PUNTO_VENTA)
        Me.GB_FICHA.Controls.Add(Me.TB_D_PUNTO_VENTA)
        Me.GB_FICHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FICHA.Location = New System.Drawing.Point(42, 139)
        Me.GB_FICHA.Name = "GB_FICHA"
        Me.GB_FICHA.Size = New System.Drawing.Size(958, 380)
        Me.GB_FICHA.TabIndex = 40
        Me.GB_FICHA.TabStop = False
        Me.GB_FICHA.Text = "Ficha"
        '
        'GB_PORTATIL
        '
        Me.GB_PORTATIL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GB_PORTATIL.BackColor = System.Drawing.Color.White
        Me.GB_PORTATIL.Controls.Add(Me.Label25)
        Me.GB_PORTATIL.Controls.Add(Me.TB_CAPACIDAD_POR)
        Me.GB_PORTATIL.Controls.Add(Me.Label26)
        Me.GB_PORTATIL.Controls.Add(Me.TB_SERIE_POR)
        Me.GB_PORTATIL.Controls.Add(Me.Label34)
        Me.GB_PORTATIL.Controls.Add(Me.TB_KILOMETRAJE_POR)
        Me.GB_PORTATIL.Controls.Add(Me.Label35)
        Me.GB_PORTATIL.Controls.Add(Me.TB_MODELO_POR)
        Me.GB_PORTATIL.Controls.Add(Me.Label36)
        Me.GB_PORTATIL.Controls.Add(Me.TB_MARCA_POR)
        Me.GB_PORTATIL.Controls.Add(Me.Label37)
        Me.GB_PORTATIL.Controls.Add(Me.TB_MATRICULA_POR)
        Me.GB_PORTATIL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_PORTATIL.Location = New System.Drawing.Point(0, 0)
        Me.GB_PORTATIL.Name = "GB_PORTATIL"
        Me.GB_PORTATIL.Size = New System.Drawing.Size(946, 221)
        Me.GB_PORTATIL.TabIndex = 172
        Me.GB_PORTATIL.TabStop = False
        Me.GB_PORTATIL.Text = "Detalles Portatil"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(250, 85)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(61, 13)
        Me.Label25.TabIndex = 162
        Me.Label25.Text = "Capacidad"
        '
        'TB_CAPACIDAD_POR
        '
        Me.TB_CAPACIDAD_POR.AccessibleDescription = ""
        Me.TB_CAPACIDAD_POR.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CAPACIDAD_POR.Location = New System.Drawing.Point(246, 101)
        Me.TB_CAPACIDAD_POR.Name = "TB_CAPACIDAD_POR"
        Me.TB_CAPACIDAD_POR.Size = New System.Drawing.Size(220, 22)
        Me.TB_CAPACIDAD_POR.TabIndex = 161
        Me.TB_CAPACIDAD_POR.Tag = ""
        Me.TB_CAPACIDAD_POR.Text = "0"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(16, 85)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(32, 13)
        Me.Label26.TabIndex = 160
        Me.Label26.Text = "Serie"
        '
        'TB_SERIE_POR
        '
        Me.TB_SERIE_POR.AccessibleDescription = ""
        Me.TB_SERIE_POR.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_SERIE_POR.Location = New System.Drawing.Point(13, 101)
        Me.TB_SERIE_POR.Name = "TB_SERIE_POR"
        Me.TB_SERIE_POR.Size = New System.Drawing.Size(220, 22)
        Me.TB_SERIE_POR.TabIndex = 159
        Me.TB_SERIE_POR.Tag = ""
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(716, 25)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(64, 13)
        Me.Label34.TabIndex = 158
        Me.Label34.Text = "Kilometraje"
        '
        'TB_KILOMETRAJE_POR
        '
        Me.TB_KILOMETRAJE_POR.AccessibleDescription = ""
        Me.TB_KILOMETRAJE_POR.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_KILOMETRAJE_POR.Location = New System.Drawing.Point(712, 41)
        Me.TB_KILOMETRAJE_POR.Name = "TB_KILOMETRAJE_POR"
        Me.TB_KILOMETRAJE_POR.Size = New System.Drawing.Size(220, 22)
        Me.TB_KILOMETRAJE_POR.TabIndex = 157
        Me.TB_KILOMETRAJE_POR.Tag = ""
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(484, 25)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(47, 13)
        Me.Label35.TabIndex = 156
        Me.Label35.Text = "Modelo"
        '
        'TB_MODELO_POR
        '
        Me.TB_MODELO_POR.AccessibleDescription = ""
        Me.TB_MODELO_POR.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_MODELO_POR.Location = New System.Drawing.Point(480, 41)
        Me.TB_MODELO_POR.Name = "TB_MODELO_POR"
        Me.TB_MODELO_POR.Size = New System.Drawing.Size(220, 22)
        Me.TB_MODELO_POR.TabIndex = 155
        Me.TB_MODELO_POR.Tag = ""
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(250, 25)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(38, 13)
        Me.Label36.TabIndex = 154
        Me.Label36.Text = "Marca"
        '
        'TB_MARCA_POR
        '
        Me.TB_MARCA_POR.AccessibleDescription = ""
        Me.TB_MARCA_POR.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_MARCA_POR.Location = New System.Drawing.Point(246, 41)
        Me.TB_MARCA_POR.Name = "TB_MARCA_POR"
        Me.TB_MARCA_POR.Size = New System.Drawing.Size(220, 22)
        Me.TB_MARCA_POR.TabIndex = 153
        Me.TB_MARCA_POR.Tag = ""
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(16, 25)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(55, 13)
        Me.Label37.TabIndex = 152
        Me.Label37.Text = "Matricula"
        '
        'TB_MATRICULA_POR
        '
        Me.TB_MATRICULA_POR.AccessibleDescription = ""
        Me.TB_MATRICULA_POR.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_MATRICULA_POR.Location = New System.Drawing.Point(13, 41)
        Me.TB_MATRICULA_POR.Name = "TB_MATRICULA_POR"
        Me.TB_MATRICULA_POR.Size = New System.Drawing.Size(220, 22)
        Me.TB_MATRICULA_POR.TabIndex = 151
        Me.TB_MATRICULA_POR.Tag = ""
        '
        'GB_ESTACION_CARBURACION
        '
        Me.GB_ESTACION_CARBURACION.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GB_ESTACION_CARBURACION.BackColor = System.Drawing.Color.White
        Me.GB_ESTACION_CARBURACION.Controls.Add(Me.GB_PORTATIL)
        Me.GB_ESTACION_CARBURACION.Controls.Add(Me.Label27)
        Me.GB_ESTACION_CARBURACION.Controls.Add(Me.TB_TIPO_MEDIDOR_EST)
        Me.GB_ESTACION_CARBURACION.Controls.Add(Me.Label28)
        Me.GB_ESTACION_CARBURACION.Controls.Add(Me.TB_MEDIDOR_EST)
        Me.GB_ESTACION_CARBURACION.Controls.Add(Me.Label29)
        Me.GB_ESTACION_CARBURACION.Controls.Add(Me.TB_PORCENTAJE_EST)
        Me.GB_ESTACION_CARBURACION.Controls.Add(Me.Label30)
        Me.GB_ESTACION_CARBURACION.Controls.Add(Me.TB_CAPACIDAD_EST)
        Me.GB_ESTACION_CARBURACION.Controls.Add(Me.Label31)
        Me.GB_ESTACION_CARBURACION.Controls.Add(Me.TB_DIRECCION_EST)
        Me.GB_ESTACION_CARBURACION.Controls.Add(Me.Label32)
        Me.GB_ESTACION_CARBURACION.Controls.Add(Me.TB_LECTURA_FINAL_EST)
        Me.GB_ESTACION_CARBURACION.Controls.Add(Me.Label33)
        Me.GB_ESTACION_CARBURACION.Controls.Add(Me.TB_LECTURA_INICIAL_EST)
        Me.GB_ESTACION_CARBURACION.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_ESTACION_CARBURACION.Location = New System.Drawing.Point(6, 111)
        Me.GB_ESTACION_CARBURACION.Name = "GB_ESTACION_CARBURACION"
        Me.GB_ESTACION_CARBURACION.Size = New System.Drawing.Size(946, 221)
        Me.GB_ESTACION_CARBURACION.TabIndex = 171
        Me.GB_ESTACION_CARBURACION.TabStop = False
        Me.GB_ESTACION_CARBURACION.Text = "Detalles Estación de Carburación"
        Me.GB_ESTACION_CARBURACION.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(484, 85)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(76, 13)
        Me.Label27.TabIndex = 164
        Me.Label27.Text = "Tipo Medidor"
        '
        'TB_TIPO_MEDIDOR_EST
        '
        Me.TB_TIPO_MEDIDOR_EST.AccessibleDescription = ""
        Me.TB_TIPO_MEDIDOR_EST.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_TIPO_MEDIDOR_EST.Location = New System.Drawing.Point(480, 101)
        Me.TB_TIPO_MEDIDOR_EST.Name = "TB_TIPO_MEDIDOR_EST"
        Me.TB_TIPO_MEDIDOR_EST.Size = New System.Drawing.Size(220, 22)
        Me.TB_TIPO_MEDIDOR_EST.TabIndex = 163
        Me.TB_TIPO_MEDIDOR_EST.Tag = ""
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(250, 85)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(51, 13)
        Me.Label28.TabIndex = 162
        Me.Label28.Text = "Medidor"
        '
        'TB_MEDIDOR_EST
        '
        Me.TB_MEDIDOR_EST.AccessibleDescription = ""
        Me.TB_MEDIDOR_EST.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_MEDIDOR_EST.Location = New System.Drawing.Point(246, 101)
        Me.TB_MEDIDOR_EST.Name = "TB_MEDIDOR_EST"
        Me.TB_MEDIDOR_EST.Size = New System.Drawing.Size(220, 22)
        Me.TB_MEDIDOR_EST.TabIndex = 161
        Me.TB_MEDIDOR_EST.Tag = ""
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(16, 85)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(61, 13)
        Me.Label29.TabIndex = 160
        Me.Label29.Text = "Porcentaje"
        '
        'TB_PORCENTAJE_EST
        '
        Me.TB_PORCENTAJE_EST.AccessibleDescription = ""
        Me.TB_PORCENTAJE_EST.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PORCENTAJE_EST.Location = New System.Drawing.Point(13, 101)
        Me.TB_PORCENTAJE_EST.Name = "TB_PORCENTAJE_EST"
        Me.TB_PORCENTAJE_EST.Size = New System.Drawing.Size(220, 22)
        Me.TB_PORCENTAJE_EST.TabIndex = 159
        Me.TB_PORCENTAJE_EST.Tag = ""
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(716, 25)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(61, 13)
        Me.Label30.TabIndex = 158
        Me.Label30.Text = "Capacidad"
        '
        'TB_CAPACIDAD_EST
        '
        Me.TB_CAPACIDAD_EST.AccessibleDescription = ""
        Me.TB_CAPACIDAD_EST.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CAPACIDAD_EST.Location = New System.Drawing.Point(712, 41)
        Me.TB_CAPACIDAD_EST.Name = "TB_CAPACIDAD_EST"
        Me.TB_CAPACIDAD_EST.Size = New System.Drawing.Size(220, 22)
        Me.TB_CAPACIDAD_EST.TabIndex = 157
        Me.TB_CAPACIDAD_EST.Tag = ""
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(484, 25)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(55, 13)
        Me.Label31.TabIndex = 156
        Me.Label31.Text = "Dirección"
        '
        'TB_DIRECCION_EST
        '
        Me.TB_DIRECCION_EST.AccessibleDescription = ""
        Me.TB_DIRECCION_EST.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_DIRECCION_EST.Location = New System.Drawing.Point(480, 41)
        Me.TB_DIRECCION_EST.Name = "TB_DIRECCION_EST"
        Me.TB_DIRECCION_EST.Size = New System.Drawing.Size(220, 22)
        Me.TB_DIRECCION_EST.TabIndex = 155
        Me.TB_DIRECCION_EST.Tag = ""
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(250, 25)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(70, 13)
        Me.Label32.TabIndex = 154
        Me.Label32.Text = "Lectura final"
        '
        'TB_LECTURA_FINAL_EST
        '
        Me.TB_LECTURA_FINAL_EST.AccessibleDescription = ""
        Me.TB_LECTURA_FINAL_EST.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LECTURA_FINAL_EST.Location = New System.Drawing.Point(246, 41)
        Me.TB_LECTURA_FINAL_EST.Name = "TB_LECTURA_FINAL_EST"
        Me.TB_LECTURA_FINAL_EST.Size = New System.Drawing.Size(220, 22)
        Me.TB_LECTURA_FINAL_EST.TabIndex = 153
        Me.TB_LECTURA_FINAL_EST.Tag = ""
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(16, 25)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(77, 13)
        Me.Label33.TabIndex = 152
        Me.Label33.Text = "Lectura inicial"
        '
        'TB_LECTURA_INICIAL_EST
        '
        Me.TB_LECTURA_INICIAL_EST.AccessibleDescription = ""
        Me.TB_LECTURA_INICIAL_EST.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LECTURA_INICIAL_EST.Location = New System.Drawing.Point(13, 41)
        Me.TB_LECTURA_INICIAL_EST.Name = "TB_LECTURA_INICIAL_EST"
        Me.TB_LECTURA_INICIAL_EST.Size = New System.Drawing.Size(220, 22)
        Me.TB_LECTURA_INICIAL_EST.TabIndex = 151
        Me.TB_LECTURA_INICIAL_EST.Tag = ""
        '
        'CB_OPERADOR
        '
        Me.CB_OPERADOR.FormattingEnabled = True
        Me.CB_OPERADOR.Location = New System.Drawing.Point(36, 83)
        Me.CB_OPERADOR.Name = "CB_OPERADOR"
        Me.CB_OPERADOR.Size = New System.Drawing.Size(226, 21)
        Me.CB_OPERADOR.TabIndex = 173
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(39, 69)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(57, 13)
        Me.Label38.TabIndex = 172
        Me.Label38.Text = "Operador"
        '
        'CB_AYUDANTE_1
        '
        Me.CB_AYUDANTE_1.FormattingEnabled = True
        Me.CB_AYUDANTE_1.Location = New System.Drawing.Point(268, 84)
        Me.CB_AYUDANTE_1.Name = "CB_AYUDANTE_1"
        Me.CB_AYUDANTE_1.Size = New System.Drawing.Size(170, 21)
        Me.CB_AYUDANTE_1.TabIndex = 175
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(271, 70)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(65, 13)
        Me.Label39.TabIndex = 174
        Me.Label39.Text = "Ayudante 1"
        '
        'CB_AYUDANTE_2
        '
        Me.CB_AYUDANTE_2.FormattingEnabled = True
        Me.CB_AYUDANTE_2.Location = New System.Drawing.Point(444, 83)
        Me.CB_AYUDANTE_2.Name = "CB_AYUDANTE_2"
        Me.CB_AYUDANTE_2.Size = New System.Drawing.Size(170, 21)
        Me.CB_AYUDANTE_2.TabIndex = 177
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(447, 69)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(65, 13)
        Me.Label40.TabIndex = 176
        Me.Label40.Text = "Ayudante 2"
        '
        'FO_PUNTO_VENTA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(800, 450)
        Me.ClientSize = New System.Drawing.Size(1056, 552)
        Me.Controls.Add(Me.GB_FICHA)
        Me.Controls.Add(Me.FL_MENU_2)
        Me.Controls.Add(Me.GB_FILTROS)
        Me.Controls.Add(Me.GB_LISTADO)
        Me.Controls.Add(Me.GB_OPERACION)
        Me.Controls.Add(Me.GB_CONTROL)
        Me.Controls.Add(Me.FL_MENU_1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FO_PUNTO_VENTA"
        Me.Text = "Puntos de Venta"
        Me.FL_MENU_2.ResumeLayout(False)
        Me.GB_FILTROS.ResumeLayout(False)
        Me.GB_FILTROS.PerformLayout()
        Me.GB_LISTADO.ResumeLayout(False)
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_OPERACION.ResumeLayout(False)
        Me.GB_OPERACION.PerformLayout()
        Me.GB_CONTROL.ResumeLayout(False)
        Me.FL_MENU_1.ResumeLayout(False)
        Me.GB_AUTOTANQUE.ResumeLayout(False)
        Me.GB_AUTOTANQUE.PerformLayout()
        Me.GB_FICHA.ResumeLayout(False)
        Me.GB_FICHA.PerformLayout()
        Me.GB_PORTATIL.ResumeLayout(False)
        Me.GB_PORTATIL.PerformLayout()
        Me.GB_ESTACION_CARBURACION.ResumeLayout(False)
        Me.GB_ESTACION_CARBURACION.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents TI_RELOJ As Timer
    Public WithEvents FL_MENU_2 As FlowLayoutPanel
    Public WithEvents BT_SALIR As Button
    Public WithEvents BT_CANCELAR As Button
    Public WithEvents BT_GUARDAR As Button
    Public WithEvents BT_LISTADO As Button
    Public WithEvents BT_EXPORTAR_EXCEL As Button
    Public WithEvents GB_FILTROS As GroupBox
    Friend WithEvents Label21 As Label
    Public WithEvents CB_LI_ESTATUS_PUNTO_VENTA As ComboBox
    Public WithEvents CB_LI_TIPO_PUNTO_VENTA As ComboBox
    Public WithEvents BT_LI_BUSCAR As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label1 As Label
    Public WithEvents TB_LI_BUSCAR As TextBox
    Public WithEvents GB_LISTADO As GroupBox
    Public WithEvents LI_LISTADO As DataGridView
    Public WithEvents GB_OPERACION As GroupBox
    Public WithEvents LB_RESULTADO As TextBox
    Public WithEvents GB_CONTROL As GroupBox
    Public WithEvents LB_VERSION As Label
    Public WithEvents LB_RELOJ As Label
    Public WithEvents FL_MENU_1 As FlowLayoutPanel
    Public WithEvents BT_AGREGAR As Button
    Public WithEvents BT_EDITAR As Button
    Public WithEvents BT_CLONAR As Button
    Public WithEvents BT_ELIMINAR As Button
    Public WithEvents CB_LI_K_UNIDAD_OPERATIVA As ComboBox
    Public WithEvents TB_D_PUNTO_VENTA As TextBox
    Public WithEvents TB_C_PUNTO_VENTA As TextBox
    Public WithEvents TB_S_PUNTO_VENTA As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LB_ID As Label
    Public WithEvents TB_K_PUNTO_VENTA As TextBox
    Friend WithEvents TB_O_PUNTO_VENTA As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CH_L_PUNTO_VENTA As CheckBox
    Public WithEvents CB_TIPO_PUNTO_VENTA As ComboBox
    Public WithEvents TB_F_CAMBIO As TextBox
    Public WithEvents TB_F_ALTA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Public WithEvents CB_USUARIO_ALTA As ComboBox
    Public WithEvents CB_USUARIO_CAMBIO As ComboBox
    Friend WithEvents Label12 As Label
    Public WithEvents CB_UNIDAD_OPERATIVA As ComboBox
    Public WithEvents GB_AUTOTANQUE As GroupBox
    Friend WithEvents LB_LECTURA_INICIAL_AUT As Label
    Public WithEvents TB_LECTURA_INICIAL_AUT As TextBox
    Public WithEvents GB_FICHA As GroupBox
    Friend WithEvents Label10 As Label
    Public WithEvents TB_LECTURA_FINAL_AUT As TextBox
    Friend WithEvents Label16 As Label
    Public WithEvents TB_MODELO_AUT As TextBox
    Friend WithEvents Label15 As Label
    Public WithEvents TB_MARCA_AUT As TextBox
    Friend WithEvents Label17 As Label
    Public WithEvents TB_KILOMETRAJE_AUT As TextBox
    Friend WithEvents Label23 As Label
    Public WithEvents TB_TIPO_MEDIDOR_AUT As TextBox
    Friend WithEvents Label22 As Label
    Public WithEvents TB_MEDIDOR_AUT As TextBox
    Friend WithEvents Label20 As Label
    Public WithEvents TB_PORCENTAJE_AUT As TextBox
    Friend WithEvents Label19 As Label
    Public WithEvents TB_CAPACIDAD_AUT As TextBox
    Friend WithEvents Label18 As Label
    Public WithEvents TB_SERIE_AUT As TextBox
    Public WithEvents GB_ESTACION_CARBURACION As GroupBox
    Friend WithEvents Label27 As Label
    Public WithEvents TB_TIPO_MEDIDOR_EST As TextBox
    Friend WithEvents Label28 As Label
    Public WithEvents TB_MEDIDOR_EST As TextBox
    Friend WithEvents Label29 As Label
    Public WithEvents TB_PORCENTAJE_EST As TextBox
    Friend WithEvents Label30 As Label
    Public WithEvents TB_CAPACIDAD_EST As TextBox
    Friend WithEvents Label31 As Label
    Public WithEvents TB_DIRECCION_EST As TextBox
    Friend WithEvents Label32 As Label
    Public WithEvents TB_LECTURA_FINAL_EST As TextBox
    Friend WithEvents Label33 As Label
    Public WithEvents TB_LECTURA_INICIAL_EST As TextBox
    Public WithEvents GB_PORTATIL As GroupBox
    Friend WithEvents Label25 As Label
    Public WithEvents TB_CAPACIDAD_POR As TextBox
    Friend WithEvents Label26 As Label
    Public WithEvents TB_SERIE_POR As TextBox
    Friend WithEvents Label34 As Label
    Public WithEvents TB_KILOMETRAJE_POR As TextBox
    Friend WithEvents Label35 As Label
    Public WithEvents TB_MODELO_POR As TextBox
    Friend WithEvents Label36 As Label
    Public WithEvents TB_MARCA_POR As TextBox
    Friend WithEvents Label37 As Label
    Public WithEvents TB_MATRICULA_POR As TextBox
    Friend WithEvents Label24 As Label
    Public WithEvents TB_MATRICULA_AUT As TextBox
    Public WithEvents CB_AYUDANTE_2 As ComboBox
    Friend WithEvents Label40 As Label
    Public WithEvents CB_AYUDANTE_1 As ComboBox
    Friend WithEvents Label39 As Label
    Public WithEvents CB_OPERADOR As ComboBox
    Friend WithEvents Label38 As Label
End Class
