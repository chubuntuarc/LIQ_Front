<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FO_DATA_N1_X_DI_D0M4_CEMEC
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
        Me.Label36 = New System.Windows.Forms.Label()
        Me.CB_LI_RAZON_SOCIAL = New System.Windows.Forms.ComboBox()
        Me.CB_LI_TIEMPO_MES = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CHB_COL_FILTRAR = New System.Windows.Forms.CheckBox()
        Me.CHB_PARAMETRICAS = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CB_LI_FORMATO_D0M4 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CB_LI_UNIDAD_OPERATIVA = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_LI_ZONA_UO = New System.Windows.Forms.ComboBox()
        Me.CB_LI_TIEMPO_YYYY = New System.Windows.Forms.ComboBox()
        Me.CB_LI_DATO_D0M4 = New System.Windows.Forms.ComboBox()
        Me.BT_LI_BUSCAR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_LI_BUSCAR = New System.Windows.Forms.TextBox()
        Me.GB_LISTADO = New System.Windows.Forms.GroupBox()
        Me.LI_LISTADO = New System.Windows.Forms.DataGridView()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_SALIR = New System.Windows.Forms.Button()
        Me.BT_EXPORTAR_EXCEL = New System.Windows.Forms.Button()
        Me.BT_ACTUALIZAR = New System.Windows.Forms.Button()
        Me.BT_GUARDAR = New System.Windows.Forms.Button()
        Me.FL_MENU = New System.Windows.Forms.FlowLayoutPanel()
        Me.GB_OPERACION = New System.Windows.Forms.GroupBox()
        Me.LB_RESULTADO = New System.Windows.Forms.TextBox()
        Me.LB_DISPONIBLE = New System.Windows.Forms.Label()
        Me.GB_CONTROL = New System.Windows.Forms.GroupBox()
        Me.LB_VERSION = New System.Windows.Forms.Label()
        Me.LB_RELOJ = New System.Windows.Forms.Label()
        Me.TI_RELOJ = New System.Windows.Forms.Timer(Me.components)
        Me.GB_FILTROS.SuspendLayout()
        Me.GB_LISTADO.SuspendLayout()
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.GB_OPERACION.SuspendLayout()
        Me.GB_CONTROL.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_FILTROS
        '
        Me.GB_FILTROS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_FILTROS.BackColor = System.Drawing.Color.White
        Me.GB_FILTROS.Controls.Add(Me.Label36)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_RAZON_SOCIAL)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_TIEMPO_MES)
        Me.GB_FILTROS.Controls.Add(Me.Label5)
        Me.GB_FILTROS.Controls.Add(Me.Label4)
        Me.GB_FILTROS.Controls.Add(Me.Label3)
        Me.GB_FILTROS.Controls.Add(Me.CHB_COL_FILTRAR)
        Me.GB_FILTROS.Controls.Add(Me.CHB_PARAMETRICAS)
        Me.GB_FILTROS.Controls.Add(Me.Label8)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_FORMATO_D0M4)
        Me.GB_FILTROS.Controls.Add(Me.Label7)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_UNIDAD_OPERATIVA)
        Me.GB_FILTROS.Controls.Add(Me.Label2)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_ZONA_UO)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_TIEMPO_YYYY)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_DATO_D0M4)
        Me.GB_FILTROS.Controls.Add(Me.BT_LI_BUSCAR)
        Me.GB_FILTROS.Controls.Add(Me.Label1)
        Me.GB_FILTROS.Controls.Add(Me.TB_LI_BUSCAR)
        Me.GB_FILTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FILTROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_FILTROS.Location = New System.Drawing.Point(14, 60)
        Me.GB_FILTROS.Name = "GB_FILTROS"
        Me.GB_FILTROS.Size = New System.Drawing.Size(1319, 110)
        Me.GB_FILTROS.TabIndex = 57
        Me.GB_FILTROS.TabStop = False
        Me.GB_FILTROS.Text = "Filtros"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(434, 24)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(70, 13)
        Me.Label36.TabIndex = 148
        Me.Label36.Text = "Razón Social"
        '
        'CB_LI_RAZON_SOCIAL
        '
        Me.CB_LI_RAZON_SOCIAL.FormattingEnabled = True
        Me.CB_LI_RAZON_SOCIAL.Location = New System.Drawing.Point(431, 40)
        Me.CB_LI_RAZON_SOCIAL.Name = "CB_LI_RAZON_SOCIAL"
        Me.CB_LI_RAZON_SOCIAL.Size = New System.Drawing.Size(168, 21)
        Me.CB_LI_RAZON_SOCIAL.TabIndex = 147
        '
        'CB_LI_TIEMPO_MES
        '
        Me.CB_LI_TIEMPO_MES.FormattingEnabled = True
        Me.CB_LI_TIEMPO_MES.Location = New System.Drawing.Point(431, 78)
        Me.CB_LI_TIEMPO_MES.Name = "CB_LI_TIEMPO_MES"
        Me.CB_LI_TIEMPO_MES.Size = New System.Drawing.Size(168, 21)
        Me.CB_LI_TIEMPO_MES.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(434, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Mes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(307, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Zona "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(882, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Formato D0M4"
        Me.Label3.Visible = False
        '
        'CHB_COL_FILTRAR
        '
        Me.CHB_COL_FILTRAR.AutoSize = True
        Me.CHB_COL_FILTRAR.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CHB_COL_FILTRAR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHB_COL_FILTRAR.Location = New System.Drawing.Point(610, 67)
        Me.CHB_COL_FILTRAR.Name = "CHB_COL_FILTRAR"
        Me.CHB_COL_FILTRAR.Size = New System.Drawing.Size(103, 31)
        Me.CHB_COL_FILTRAR.TabIndex = 10
        Me.CHB_COL_FILTRAR.Text = "Ocultar Columnas"
        Me.CHB_COL_FILTRAR.UseVisualStyleBackColor = True
        '
        'CHB_PARAMETRICAS
        '
        Me.CHB_PARAMETRICAS.AutoSize = True
        Me.CHB_PARAMETRICAS.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CHB_PARAMETRICAS.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHB_PARAMETRICAS.Location = New System.Drawing.Point(731, 67)
        Me.CHB_PARAMETRICAS.Name = "CHB_PARAMETRICAS"
        Me.CHB_PARAMETRICAS.Size = New System.Drawing.Size(94, 31)
        Me.CHB_PARAMETRICAS.TabIndex = 11
        Me.CHB_PARAMETRICAS.Text = "Ver Parametricas"
        Me.CHB_PARAMETRICAS.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CHB_PARAMETRICAS.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(307, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Año"
        '
        'CB_LI_FORMATO_D0M4
        '
        Me.CB_LI_FORMATO_D0M4.FormattingEnabled = True
        Me.CB_LI_FORMATO_D0M4.Location = New System.Drawing.Point(880, 83)
        Me.CB_LI_FORMATO_D0M4.Name = "CB_LI_FORMATO_D0M4"
        Me.CB_LI_FORMATO_D0M4.Size = New System.Drawing.Size(270, 21)
        Me.CB_LI_FORMATO_D0M4.TabIndex = 13
        Me.CB_LI_FORMATO_D0M4.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Dato D0M4"
        '
        'CB_LI_UNIDAD_OPERATIVA
        '
        Me.CB_LI_UNIDAD_OPERATIVA.FormattingEnabled = True
        Me.CB_LI_UNIDAD_OPERATIVA.Location = New System.Drawing.Point(605, 40)
        Me.CB_LI_UNIDAD_OPERATIVA.Name = "CB_LI_UNIDAD_OPERATIVA"
        Me.CB_LI_UNIDAD_OPERATIVA.Size = New System.Drawing.Size(217, 21)
        Me.CB_LI_UNIDAD_OPERATIVA.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(608, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Unidad Operativa"
        '
        'CB_LI_ZONA_UO
        '
        Me.CB_LI_ZONA_UO.FormattingEnabled = True
        Me.CB_LI_ZONA_UO.Location = New System.Drawing.Point(304, 40)
        Me.CB_LI_ZONA_UO.Name = "CB_LI_ZONA_UO"
        Me.CB_LI_ZONA_UO.Size = New System.Drawing.Size(121, 21)
        Me.CB_LI_ZONA_UO.TabIndex = 15
        '
        'CB_LI_TIEMPO_YYYY
        '
        Me.CB_LI_TIEMPO_YYYY.FormattingEnabled = True
        Me.CB_LI_TIEMPO_YYYY.Location = New System.Drawing.Point(304, 78)
        Me.CB_LI_TIEMPO_YYYY.Name = "CB_LI_TIEMPO_YYYY"
        Me.CB_LI_TIEMPO_YYYY.Size = New System.Drawing.Size(121, 21)
        Me.CB_LI_TIEMPO_YYYY.TabIndex = 16
        '
        'CB_LI_DATO_D0M4
        '
        Me.CB_LI_DATO_D0M4.FormattingEnabled = True
        Me.CB_LI_DATO_D0M4.Location = New System.Drawing.Point(18, 40)
        Me.CB_LI_DATO_D0M4.Name = "CB_LI_DATO_D0M4"
        Me.CB_LI_DATO_D0M4.Size = New System.Drawing.Size(280, 21)
        Me.CB_LI_DATO_D0M4.TabIndex = 17
        '
        'BT_LI_BUSCAR
        '
        Me.BT_LI_BUSCAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_LI_BUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_LI_BUSCAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_LI_BUSCAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_LI_BUSCAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_LI_BUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_LI_BUSCAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_search
        Me.BT_LI_BUSCAR.Location = New System.Drawing.Point(1238, 41)
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
        Me.Label1.Location = New System.Drawing.Point(20, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Buscar"
        '
        'TB_LI_BUSCAR
        '
        Me.TB_LI_BUSCAR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LI_BUSCAR.Location = New System.Drawing.Point(17, 77)
        Me.TB_LI_BUSCAR.Name = "TB_LI_BUSCAR"
        Me.TB_LI_BUSCAR.Size = New System.Drawing.Size(281, 22)
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
        Me.GB_LISTADO.Location = New System.Drawing.Point(14, 176)
        Me.GB_LISTADO.Name = "GB_LISTADO"
        Me.GB_LISTADO.Size = New System.Drawing.Size(1319, 275)
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
        Me.LI_LISTADO.Size = New System.Drawing.Size(1296, 236)
        Me.LI_LISTADO.TabIndex = 2
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel2.Controls.Add(Me.BT_SALIR)
        Me.FlowLayoutPanel2.Controls.Add(Me.BT_EXPORTAR_EXCEL)
        Me.FlowLayoutPanel2.Controls.Add(Me.BT_ACTUALIZAR)
        Me.FlowLayoutPanel2.Controls.Add(Me.BT_GUARDAR)
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(948, 12)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(385, 40)
        Me.FlowLayoutPanel2.TabIndex = 60
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
        Me.BT_SALIR.Location = New System.Drawing.Point(315, 6)
        Me.BT_SALIR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_SALIR.Name = "BT_SALIR"
        Me.BT_SALIR.Size = New System.Drawing.Size(70, 34)
        Me.BT_SALIR.TabIndex = 23
        Me.BT_SALIR.UseVisualStyleBackColor = True
        '
        'BT_EXPORTAR_EXCEL
        '
        Me.BT_EXPORTAR_EXCEL.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_EXPORTAR_EXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_EXPORTAR_EXCEL.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_export
        Me.BT_EXPORTAR_EXCEL.Location = New System.Drawing.Point(242, 6)
        Me.BT_EXPORTAR_EXCEL.Name = "BT_EXPORTAR_EXCEL"
        Me.BT_EXPORTAR_EXCEL.Size = New System.Drawing.Size(70, 34)
        Me.BT_EXPORTAR_EXCEL.TabIndex = 29
        Me.BT_EXPORTAR_EXCEL.UseVisualStyleBackColor = True
        '
        'BT_ACTUALIZAR
        '
        Me.BT_ACTUALIZAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_ACTUALIZAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_ACTUALIZAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_refresh
        Me.BT_ACTUALIZAR.Location = New System.Drawing.Point(166, 6)
        Me.BT_ACTUALIZAR.Name = "BT_ACTUALIZAR"
        Me.BT_ACTUALIZAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_ACTUALIZAR.TabIndex = 30
        Me.BT_ACTUALIZAR.UseVisualStyleBackColor = True
        Me.BT_ACTUALIZAR.Visible = False
        '
        'BT_GUARDAR
        '
        Me.BT_GUARDAR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BT_GUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_GUARDAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_GUARDAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_GUARDAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_GUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_GUARDAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_accept
        Me.BT_GUARDAR.Location = New System.Drawing.Point(93, 6)
        Me.BT_GUARDAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_GUARDAR.Name = "BT_GUARDAR"
        Me.BT_GUARDAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_GUARDAR.TabIndex = 23
        Me.BT_GUARDAR.UseVisualStyleBackColor = True
        '
        'FL_MENU
        '
        Me.FL_MENU.BackColor = System.Drawing.Color.White
        Me.FL_MENU.Location = New System.Drawing.Point(14, 12)
        Me.FL_MENU.Name = "FL_MENU"
        Me.FL_MENU.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FL_MENU.Size = New System.Drawing.Size(937, 40)
        Me.FL_MENU.TabIndex = 59
        '
        'GB_OPERACION
        '
        Me.GB_OPERACION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_OPERACION.BackColor = System.Drawing.Color.White
        Me.GB_OPERACION.Controls.Add(Me.LB_RESULTADO)
        Me.GB_OPERACION.Controls.Add(Me.LB_DISPONIBLE)
        Me.GB_OPERACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_OPERACION.Location = New System.Drawing.Point(15, 455)
        Me.GB_OPERACION.Name = "GB_OPERACION"
        Me.GB_OPERACION.Size = New System.Drawing.Size(873, 52)
        Me.GB_OPERACION.TabIndex = 63
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
        Me.LB_RESULTADO.Size = New System.Drawing.Size(861, 30)
        Me.LB_RESULTADO.TabIndex = 8
        '
        'LB_DISPONIBLE
        '
        Me.LB_DISPONIBLE.AutoSize = True
        Me.LB_DISPONIBLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_DISPONIBLE.Location = New System.Drawing.Point(550, 20)
        Me.LB_DISPONIBLE.Name = "LB_DISPONIBLE"
        Me.LB_DISPONIBLE.Size = New System.Drawing.Size(0, 13)
        Me.LB_DISPONIBLE.TabIndex = 2
        '
        'GB_CONTROL
        '
        Me.GB_CONTROL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_CONTROL.BackColor = System.Drawing.Color.White
        Me.GB_CONTROL.Controls.Add(Me.LB_VERSION)
        Me.GB_CONTROL.Controls.Add(Me.LB_RELOJ)
        Me.GB_CONTROL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_CONTROL.Location = New System.Drawing.Point(895, 455)
        Me.GB_CONTROL.Name = "GB_CONTROL"
        Me.GB_CONTROL.Size = New System.Drawing.Size(436, 52)
        Me.GB_CONTROL.TabIndex = 64
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
        'TI_RELOJ
        '
        '
        'FO_DATA_N1_X_DI_D0M4_CEMEC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1347, 508)
        Me.Controls.Add(Me.GB_CONTROL)
        Me.Controls.Add(Me.GB_OPERACION)
        Me.Controls.Add(Me.GB_FILTROS)
        Me.Controls.Add(Me.GB_LISTADO)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FL_MENU)
        Me.Name = "FO_DATA_N1_X_DI_D0M4_CEMEC"
        Me.Text = "FO_DATA_N1_X_DI_D0M4_CEMEC"
        Me.GB_FILTROS.ResumeLayout(False)
        Me.GB_FILTROS.PerformLayout()
        Me.GB_LISTADO.ResumeLayout(False)
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.GB_OPERACION.ResumeLayout(False)
        Me.GB_OPERACION.PerformLayout()
        Me.GB_CONTROL.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents GB_FILTROS As GroupBox
    Public WithEvents BT_LI_BUSCAR As Button
    Friend WithEvents Label1 As Label
    Public WithEvents TB_LI_BUSCAR As TextBox
    Public WithEvents GB_LISTADO As GroupBox
    Public WithEvents LI_LISTADO As DataGridView
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Public WithEvents BT_SALIR As Button
    Public WithEvents BT_EXPORTAR_EXCEL As Button
    Public WithEvents BT_GUARDAR As Button
    Friend WithEvents FL_MENU As FlowLayoutPanel
    Public WithEvents LB_DISPONIBLE As Label
    Friend WithEvents GB_CONTROL As GroupBox
    Public WithEvents LB_VERSION As Label
    Public WithEvents LB_RELOJ As Label
    Public WithEvents TI_RELOJ As Timer
    Friend WithEvents CB_LI_TIEMPO_MES As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CHB_COL_FILTRAR As CheckBox
    Friend WithEvents CHB_PARAMETRICAS As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CB_LI_FORMATO_D0M4 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CB_LI_UNIDAD_OPERATIVA As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CB_LI_ZONA_UO As ComboBox
    Friend WithEvents CB_LI_TIEMPO_YYYY As ComboBox
    Friend WithEvents CB_LI_DATO_D0M4 As ComboBox
    Public WithEvents LB_RESULTADO As TextBox
    Friend WithEvents Label36 As Label
    Public WithEvents CB_LI_RAZON_SOCIAL As ComboBox
    Public WithEvents BT_ACTUALIZAR As Button
    Public WithEvents GB_OPERACION As GroupBox
End Class
