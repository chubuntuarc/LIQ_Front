<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FO_PERFORMANCE_N3_X_TEMP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GB_FILTROS = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TB_LI_BUSCAR = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_LI_TEMPORADA = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CB_LI_ZONA_UO = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CB_LI_TIEMPO_YYYY = New System.Windows.Forms.ComboBox()
        Me.CB_LI_UNIDAD_OPERATIVA = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BT_LI_BUSCAR = New System.Windows.Forms.Button()
        Me.FL_MENU = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_EDITAR = New System.Windows.Forms.Button()
        Me.BT_ELIMINAR = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GB_LISTADO = New System.Windows.Forms.GroupBox()
        Me.GB_FICHA = New System.Windows.Forms.GroupBox()
        Me.GB_TIPO_GRAFICA = New System.Windows.Forms.GroupBox()
        Me.RB_PAY = New System.Windows.Forms.RadioButton()
        Me.RB_CIRCULAR = New System.Windows.Forms.RadioButton()
        Me.RB_PUNTOS = New System.Windows.Forms.RadioButton()
        Me.RB_BARRAS = New System.Windows.Forms.RadioButton()
        Me.RB_LINEAS = New System.Windows.Forms.RadioButton()
        Me.RB_COLUMNA = New System.Windows.Forms.RadioButton()
        Me.RB_AREA = New System.Windows.Forms.RadioButton()
        Me.CB_UNIDAD_OPERATIVA = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TB_P02_VALOR = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TB_P01_VALOR = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TB_V02_VALOR = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TB_V01_VALOR = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_VALOR_ACUMULADO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_XLS_UNIDAD_OPERATIVA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_XLS_UO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_K_YYYY = New System.Windows.Forms.TextBox()
        Me.CHART = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LI_LISTADO = New System.Windows.Forms.DataGridView()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_SALIR = New System.Windows.Forms.Button()
        Me.BT_CANCELAR = New System.Windows.Forms.Button()
        Me.BT_GUARDAR = New System.Windows.Forms.Button()
        Me.BT_LISTADO = New System.Windows.Forms.Button()
        Me.BT_EXPORTAR_EXCEL = New System.Windows.Forms.Button()
        Me.GB_OPERACION = New System.Windows.Forms.GroupBox()
        Me.LB_RESULTADO = New System.Windows.Forms.Label()
        Me.GB_CONTROL = New System.Windows.Forms.GroupBox()
        Me.LB_VERSION = New System.Windows.Forms.Label()
        Me.LB_RELOJ = New System.Windows.Forms.Label()
        Me.TI_RELOJ = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GB_FILTROS.SuspendLayout()
        Me.FL_MENU.SuspendLayout()
        Me.GB_LISTADO.SuspendLayout()
        Me.GB_FICHA.SuspendLayout()
        Me.GB_TIPO_GRAFICA.SuspendLayout()
        CType(Me.CHART, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.GB_OPERACION.SuspendLayout()
        Me.GB_CONTROL.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_FILTROS
        '
        Me.GB_FILTROS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_FILTROS.BackColor = System.Drawing.Color.White
        Me.GB_FILTROS.Controls.Add(Me.Label14)
        Me.GB_FILTROS.Controls.Add(Me.TB_LI_BUSCAR)
        Me.GB_FILTROS.Controls.Add(Me.Label1)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_TEMPORADA)
        Me.GB_FILTROS.Controls.Add(Me.Label16)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_ZONA_UO)
        Me.GB_FILTROS.Controls.Add(Me.Label15)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_TIEMPO_YYYY)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_UNIDAD_OPERATIVA)
        Me.GB_FILTROS.Controls.Add(Me.Label13)
        Me.GB_FILTROS.Controls.Add(Me.BT_LI_BUSCAR)
        Me.GB_FILTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FILTROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_FILTROS.Location = New System.Drawing.Point(12, 55)
        Me.GB_FILTROS.Name = "GB_FILTROS"
        Me.GB_FILTROS.Size = New System.Drawing.Size(1319, 61)
        Me.GB_FILTROS.TabIndex = 103
        Me.GB_FILTROS.TabStop = False
        Me.GB_FILTROS.Text = "Filtros"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Buscar"
        '
        'TB_LI_BUSCAR
        '
        Me.TB_LI_BUSCAR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LI_BUSCAR.Location = New System.Drawing.Point(12, 32)
        Me.TB_LI_BUSCAR.Name = "TB_LI_BUSCAR"
        Me.TB_LI_BUSCAR.Size = New System.Drawing.Size(252, 22)
        Me.TB_LI_BUSCAR.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(803, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Temporada"
        '
        'CB_LI_TEMPORADA
        '
        Me.CB_LI_TEMPORADA.FormattingEnabled = True
        Me.CB_LI_TEMPORADA.Location = New System.Drawing.Point(799, 32)
        Me.CB_LI_TEMPORADA.Name = "CB_LI_TEMPORADA"
        Me.CB_LI_TEMPORADA.Size = New System.Drawing.Size(123, 21)
        Me.CB_LI_TEMPORADA.TabIndex = 36
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(273, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 13)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Zona"
        '
        'CB_LI_ZONA_UO
        '
        Me.CB_LI_ZONA_UO.FormattingEnabled = True
        Me.CB_LI_ZONA_UO.Location = New System.Drawing.Point(270, 32)
        Me.CB_LI_ZONA_UO.Name = "CB_LI_ZONA_UO"
        Me.CB_LI_ZONA_UO.Size = New System.Drawing.Size(174, 21)
        Me.CB_LI_ZONA_UO.TabIndex = 34
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(674, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Año"
        '
        'CB_LI_TIEMPO_YYYY
        '
        Me.CB_LI_TIEMPO_YYYY.FormattingEnabled = True
        Me.CB_LI_TIEMPO_YYYY.Location = New System.Drawing.Point(670, 32)
        Me.CB_LI_TIEMPO_YYYY.Name = "CB_LI_TIEMPO_YYYY"
        Me.CB_LI_TIEMPO_YYYY.Size = New System.Drawing.Size(123, 21)
        Me.CB_LI_TIEMPO_YYYY.TabIndex = 23
        '
        'CB_LI_UNIDAD_OPERATIVA
        '
        Me.CB_LI_UNIDAD_OPERATIVA.FormattingEnabled = True
        Me.CB_LI_UNIDAD_OPERATIVA.Location = New System.Drawing.Point(450, 32)
        Me.CB_LI_UNIDAD_OPERATIVA.Name = "CB_LI_UNIDAD_OPERATIVA"
        Me.CB_LI_UNIDAD_OPERATIVA.Size = New System.Drawing.Size(214, 21)
        Me.CB_LI_UNIDAD_OPERATIVA.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(454, 16)
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
        Me.BT_LI_BUSCAR.Location = New System.Drawing.Point(1228, 19)
        Me.BT_LI_BUSCAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_LI_BUSCAR.Name = "BT_LI_BUSCAR"
        Me.BT_LI_BUSCAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_LI_BUSCAR.TabIndex = 3
        Me.BT_LI_BUSCAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_LI_BUSCAR.UseVisualStyleBackColor = True
        '
        'FL_MENU
        '
        Me.FL_MENU.BackColor = System.Drawing.Color.White
        Me.FL_MENU.Controls.Add(Me.BT_EDITAR)
        Me.FL_MENU.Controls.Add(Me.BT_ELIMINAR)
        Me.FL_MENU.Controls.Add(Me.Button2)
        Me.FL_MENU.Controls.Add(Me.Button3)
        Me.FL_MENU.Location = New System.Drawing.Point(12, 7)
        Me.FL_MENU.Name = "FL_MENU"
        Me.FL_MENU.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FL_MENU.Size = New System.Drawing.Size(735, 40)
        Me.FL_MENU.TabIndex = 105
        '
        'BT_EDITAR
        '
        Me.BT_EDITAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_EDITAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_EDITAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_EDITAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_EDITAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_EDITAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_edit
        Me.BT_EDITAR.Location = New System.Drawing.Point(0, 3)
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
        Me.BT_ELIMINAR.Location = New System.Drawing.Point(70, 3)
        Me.BT_ELIMINAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_ELIMINAR.Name = "BT_ELIMINAR"
        Me.BT_ELIMINAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_ELIMINAR.TabIndex = 6
        Me.BT_ELIMINAR.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(140, 3)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 10)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(215, 3)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 10)
        Me.Button3.TabIndex = 40
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GB_LISTADO
        '
        Me.GB_LISTADO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_LISTADO.BackColor = System.Drawing.Color.White
        Me.GB_LISTADO.Controls.Add(Me.LI_LISTADO)
        Me.GB_LISTADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_LISTADO.Location = New System.Drawing.Point(12, 122)
        Me.GB_LISTADO.Name = "GB_LISTADO"
        Me.GB_LISTADO.Size = New System.Drawing.Size(1319, 518)
        Me.GB_LISTADO.TabIndex = 104
        Me.GB_LISTADO.TabStop = False
        Me.GB_LISTADO.Text = "Listado"
        '
        'GB_FICHA
        '
        Me.GB_FICHA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GB_FICHA.BackColor = System.Drawing.Color.White
        Me.GB_FICHA.Controls.Add(Me.Panel1)
        Me.GB_FICHA.Controls.Add(Me.GB_TIPO_GRAFICA)
        Me.GB_FICHA.Controls.Add(Me.CHART)
        Me.GB_FICHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FICHA.Location = New System.Drawing.Point(133, 150)
        Me.GB_FICHA.Name = "GB_FICHA"
        Me.GB_FICHA.Size = New System.Drawing.Size(1045, 456)
        Me.GB_FICHA.TabIndex = 53
        Me.GB_FICHA.TabStop = False
        Me.GB_FICHA.Text = "Ficha"
        '
        'GB_TIPO_GRAFICA
        '
        Me.GB_TIPO_GRAFICA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_TIPO_GRAFICA.BackColor = System.Drawing.Color.Gainsboro
        Me.GB_TIPO_GRAFICA.Controls.Add(Me.RB_PAY)
        Me.GB_TIPO_GRAFICA.Controls.Add(Me.RB_CIRCULAR)
        Me.GB_TIPO_GRAFICA.Controls.Add(Me.RB_PUNTOS)
        Me.GB_TIPO_GRAFICA.Controls.Add(Me.RB_BARRAS)
        Me.GB_TIPO_GRAFICA.Controls.Add(Me.RB_LINEAS)
        Me.GB_TIPO_GRAFICA.Controls.Add(Me.RB_COLUMNA)
        Me.GB_TIPO_GRAFICA.Controls.Add(Me.RB_AREA)
        Me.GB_TIPO_GRAFICA.Location = New System.Drawing.Point(378, 243)
        Me.GB_TIPO_GRAFICA.Name = "GB_TIPO_GRAFICA"
        Me.GB_TIPO_GRAFICA.Size = New System.Drawing.Size(110, 187)
        Me.GB_TIPO_GRAFICA.TabIndex = 108
        Me.GB_TIPO_GRAFICA.TabStop = False
        Me.GB_TIPO_GRAFICA.Text = "Tipo de Grafico"
        '
        'RB_PAY
        '
        Me.RB_PAY.AutoSize = True
        Me.RB_PAY.Location = New System.Drawing.Point(6, 21)
        Me.RB_PAY.Name = "RB_PAY"
        Me.RB_PAY.Size = New System.Drawing.Size(43, 17)
        Me.RB_PAY.TabIndex = 7
        Me.RB_PAY.TabStop = True
        Me.RB_PAY.Text = "Pay"
        Me.RB_PAY.UseVisualStyleBackColor = True
        '
        'RB_CIRCULAR
        '
        Me.RB_CIRCULAR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RB_CIRCULAR.AutoSize = True
        Me.RB_CIRCULAR.Location = New System.Drawing.Point(6, 159)
        Me.RB_CIRCULAR.Name = "RB_CIRCULAR"
        Me.RB_CIRCULAR.Size = New System.Drawing.Size(85, 17)
        Me.RB_CIRCULAR.TabIndex = 6
        Me.RB_CIRCULAR.TabStop = True
        Me.RB_CIRCULAR.Text = "Area Apilada"
        Me.RB_CIRCULAR.UseVisualStyleBackColor = True
        '
        'RB_PUNTOS
        '
        Me.RB_PUNTOS.AutoSize = True
        Me.RB_PUNTOS.Location = New System.Drawing.Point(7, 136)
        Me.RB_PUNTOS.Name = "RB_PUNTOS"
        Me.RB_PUNTOS.Size = New System.Drawing.Size(58, 17)
        Me.RB_PUNTOS.TabIndex = 4
        Me.RB_PUNTOS.TabStop = True
        Me.RB_PUNTOS.Text = "Puntos"
        Me.RB_PUNTOS.UseVisualStyleBackColor = True
        '
        'RB_BARRAS
        '
        Me.RB_BARRAS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RB_BARRAS.AutoSize = True
        Me.RB_BARRAS.Location = New System.Drawing.Point(7, 113)
        Me.RB_BARRAS.Name = "RB_BARRAS"
        Me.RB_BARRAS.Size = New System.Drawing.Size(55, 17)
        Me.RB_BARRAS.TabIndex = 3
        Me.RB_BARRAS.TabStop = True
        Me.RB_BARRAS.Text = "Barras"
        Me.RB_BARRAS.UseVisualStyleBackColor = True
        '
        'RB_LINEAS
        '
        Me.RB_LINEAS.AutoSize = True
        Me.RB_LINEAS.Location = New System.Drawing.Point(7, 90)
        Me.RB_LINEAS.Name = "RB_LINEAS"
        Me.RB_LINEAS.Size = New System.Drawing.Size(56, 17)
        Me.RB_LINEAS.TabIndex = 2
        Me.RB_LINEAS.TabStop = True
        Me.RB_LINEAS.Text = "Lineas"
        Me.RB_LINEAS.UseVisualStyleBackColor = True
        '
        'RB_COLUMNA
        '
        Me.RB_COLUMNA.AutoSize = True
        Me.RB_COLUMNA.Location = New System.Drawing.Point(7, 67)
        Me.RB_COLUMNA.Name = "RB_COLUMNA"
        Me.RB_COLUMNA.Size = New System.Drawing.Size(66, 17)
        Me.RB_COLUMNA.TabIndex = 1
        Me.RB_COLUMNA.TabStop = True
        Me.RB_COLUMNA.Text = "Columna"
        Me.RB_COLUMNA.UseVisualStyleBackColor = True
        '
        'RB_AREA
        '
        Me.RB_AREA.AutoSize = True
        Me.RB_AREA.Location = New System.Drawing.Point(7, 44)
        Me.RB_AREA.Name = "RB_AREA"
        Me.RB_AREA.Size = New System.Drawing.Size(47, 17)
        Me.RB_AREA.TabIndex = 0
        Me.RB_AREA.TabStop = True
        Me.RB_AREA.Text = "Área"
        Me.RB_AREA.UseVisualStyleBackColor = True
        '
        'CB_UNIDAD_OPERATIVA
        '
        Me.CB_UNIDAD_OPERATIVA.FormattingEnabled = True
        Me.CB_UNIDAD_OPERATIVA.Location = New System.Drawing.Point(13, 76)
        Me.CB_UNIDAD_OPERATIVA.Name = "CB_UNIDAD_OPERATIVA"
        Me.CB_UNIDAD_OPERATIVA.Size = New System.Drawing.Size(442, 21)
        Me.CB_UNIDAD_OPERATIVA.TabIndex = 103
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Unidad Operativa"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(338, 152)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(85, 13)
        Me.Label21.TabIndex = 44
        Me.Label21.Text = "% Temporada B"
        '
        'TB_P02_VALOR
        '
        Me.TB_P02_VALOR.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_P02_VALOR.Location = New System.Drawing.Point(335, 168)
        Me.TB_P02_VALOR.Name = "TB_P02_VALOR"
        Me.TB_P02_VALOR.Size = New System.Drawing.Size(120, 22)
        Me.TB_P02_VALOR.TabIndex = 43
        Me.TB_P02_VALOR.Tag = "1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(212, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "% Temporada A"
        '
        'TB_P01_VALOR
        '
        Me.TB_P01_VALOR.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_P01_VALOR.Location = New System.Drawing.Point(209, 168)
        Me.TB_P01_VALOR.Name = "TB_P01_VALOR"
        Me.TB_P01_VALOR.Size = New System.Drawing.Size(120, 22)
        Me.TB_P01_VALOR.TabIndex = 41
        Me.TB_P01_VALOR.Tag = "1"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(338, 102)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 13)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Valor Temporada B"
        '
        'TB_V02_VALOR
        '
        Me.TB_V02_VALOR.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_V02_VALOR.Location = New System.Drawing.Point(335, 118)
        Me.TB_V02_VALOR.Name = "TB_V02_VALOR"
        Me.TB_V02_VALOR.Size = New System.Drawing.Size(120, 22)
        Me.TB_V02_VALOR.TabIndex = 39
        Me.TB_V02_VALOR.Tag = "1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(212, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 13)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Valor Temporada A"
        '
        'TB_V01_VALOR
        '
        Me.TB_V01_VALOR.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_V01_VALOR.Location = New System.Drawing.Point(209, 118)
        Me.TB_V01_VALOR.Name = "TB_V01_VALOR"
        Me.TB_V01_VALOR.Size = New System.Drawing.Size(120, 22)
        Me.TB_V01_VALOR.TabIndex = 37
        Me.TB_V01_VALOR.Tag = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Acumulado"
        '
        'TB_VALOR_ACUMULADO
        '
        Me.TB_VALOR_ACUMULADO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_VALOR_ACUMULADO.Location = New System.Drawing.Point(13, 118)
        Me.TB_VALOR_ACUMULADO.Name = "TB_VALOR_ACUMULADO"
        Me.TB_VALOR_ACUMULADO.Size = New System.Drawing.Size(190, 22)
        Me.TB_VALOR_ACUMULADO.TabIndex = 33
        Me.TB_VALOR_ACUMULADO.Tag = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(210, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "XLS Unidad Operativa"
        '
        'TB_XLS_UNIDAD_OPERATIVA
        '
        Me.TB_XLS_UNIDAD_OPERATIVA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XLS_UNIDAD_OPERATIVA.Location = New System.Drawing.Point(207, 30)
        Me.TB_XLS_UNIDAD_OPERATIVA.Name = "TB_XLS_UNIDAD_OPERATIVA"
        Me.TB_XLS_UNIDAD_OPERATIVA.Size = New System.Drawing.Size(248, 22)
        Me.TB_XLS_UNIDAD_OPERATIVA.TabIndex = 31
        Me.TB_XLS_UNIDAD_OPERATIVA.Tag = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(133, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "XLS UO"
        '
        'TB_XLS_UO
        '
        Me.TB_XLS_UO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XLS_UO.Location = New System.Drawing.Point(130, 30)
        Me.TB_XLS_UO.Name = "TB_XLS_UO"
        Me.TB_XLS_UO.Size = New System.Drawing.Size(71, 22)
        Me.TB_XLS_UO.TabIndex = 29
        Me.TB_XLS_UO.Tag = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "AÑO"
        '
        'TB_K_YYYY
        '
        Me.TB_K_YYYY.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_K_YYYY.Location = New System.Drawing.Point(13, 30)
        Me.TB_K_YYYY.Name = "TB_K_YYYY"
        Me.TB_K_YYYY.Size = New System.Drawing.Size(111, 22)
        Me.TB_K_YYYY.TabIndex = 26
        Me.TB_K_YYYY.Tag = "1"
        '
        'CHART
        '
        Me.CHART.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.CHART.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.CHART.Legends.Add(Legend1)
        Me.CHART.Location = New System.Drawing.Point(552, 22)
        Me.CHART.Name = "CHART"
        Me.CHART.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Me.CHART.Size = New System.Drawing.Size(466, 391)
        Me.CHART.TabIndex = 101
        Me.CHART.Text = "3"
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
        Me.LI_LISTADO.Size = New System.Drawing.Size(1292, 479)
        Me.LI_LISTADO.TabIndex = 2
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel2.Controls.Add(Me.BT_SALIR)
        Me.FlowLayoutPanel2.Controls.Add(Me.BT_CANCELAR)
        Me.FlowLayoutPanel2.Controls.Add(Me.BT_GUARDAR)
        Me.FlowLayoutPanel2.Controls.Add(Me.BT_LISTADO)
        Me.FlowLayoutPanel2.Controls.Add(Me.BT_EXPORTAR_EXCEL)
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(753, 7)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(581, 40)
        Me.FlowLayoutPanel2.TabIndex = 106
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
        Me.BT_SALIR.Location = New System.Drawing.Point(511, 6)
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
        Me.BT_CANCELAR.Location = New System.Drawing.Point(441, 6)
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
        Me.BT_GUARDAR.Location = New System.Drawing.Point(371, 6)
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
        Me.BT_LISTADO.Location = New System.Drawing.Point(298, 6)
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
        Me.BT_EXPORTAR_EXCEL.Location = New System.Drawing.Point(222, 6)
        Me.BT_EXPORTAR_EXCEL.Name = "BT_EXPORTAR_EXCEL"
        Me.BT_EXPORTAR_EXCEL.Size = New System.Drawing.Size(70, 34)
        Me.BT_EXPORTAR_EXCEL.TabIndex = 28
        Me.BT_EXPORTAR_EXCEL.Tag = "Copiar al portapapeles"
        Me.BT_EXPORTAR_EXCEL.UseVisualStyleBackColor = True
        '
        'GB_OPERACION
        '
        Me.GB_OPERACION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_OPERACION.BackColor = System.Drawing.Color.White
        Me.GB_OPERACION.Controls.Add(Me.LB_RESULTADO)
        Me.GB_OPERACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_OPERACION.Location = New System.Drawing.Point(12, 644)
        Me.GB_OPERACION.Name = "GB_OPERACION"
        Me.GB_OPERACION.Size = New System.Drawing.Size(873, 52)
        Me.GB_OPERACION.TabIndex = 108
        Me.GB_OPERACION.TabStop = False
        Me.GB_OPERACION.Text = "Operación"
        '
        'LB_RESULTADO
        '
        Me.LB_RESULTADO.AutoSize = True
        Me.LB_RESULTADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_RESULTADO.Location = New System.Drawing.Point(70, 25)
        Me.LB_RESULTADO.Name = "LB_RESULTADO"
        Me.LB_RESULTADO.Size = New System.Drawing.Size(0, 13)
        Me.LB_RESULTADO.TabIndex = 1
        '
        'GB_CONTROL
        '
        Me.GB_CONTROL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_CONTROL.BackColor = System.Drawing.Color.White
        Me.GB_CONTROL.Controls.Add(Me.LB_VERSION)
        Me.GB_CONTROL.Controls.Add(Me.LB_RELOJ)
        Me.GB_CONTROL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_CONTROL.Location = New System.Drawing.Point(892, 644)
        Me.GB_CONTROL.Name = "GB_CONTROL"
        Me.GB_CONTROL.Size = New System.Drawing.Size(440, 52)
        Me.GB_CONTROL.TabIndex = 109
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TB_K_YYYY)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.CB_UNIDAD_OPERATIVA)
        Me.Panel1.Controls.Add(Me.TB_XLS_UO)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.TB_XLS_UNIDAD_OPERATIVA)
        Me.Panel1.Controls.Add(Me.TB_P02_VALOR)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.TB_VALOR_ACUMULADO)
        Me.Panel1.Controls.Add(Me.TB_P01_VALOR)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.TB_V01_VALOR)
        Me.Panel1.Controls.Add(Me.TB_V02_VALOR)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(19, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(471, 200)
        Me.Panel1.TabIndex = 109
        '
        'FO_PERFORMANCE_N3_X_TEMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1347, 702)
        Me.Controls.Add(Me.GB_FICHA)
        Me.Controls.Add(Me.GB_OPERACION)
        Me.Controls.Add(Me.GB_CONTROL)
        Me.Controls.Add(Me.GB_FILTROS)
        Me.Controls.Add(Me.FL_MENU)
        Me.Controls.Add(Me.GB_LISTADO)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Name = "FO_PERFORMANCE_N3_X_TEMP"
        Me.Text = "FO_PERFORMANCE_N3_X_TEMP"
        Me.GB_FILTROS.ResumeLayout(False)
        Me.GB_FILTROS.PerformLayout()
        Me.FL_MENU.ResumeLayout(False)
        Me.GB_LISTADO.ResumeLayout(False)
        Me.GB_FICHA.ResumeLayout(False)
        Me.GB_TIPO_GRAFICA.ResumeLayout(False)
        Me.GB_TIPO_GRAFICA.PerformLayout()
        CType(Me.CHART, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.GB_OPERACION.ResumeLayout(False)
        Me.GB_OPERACION.PerformLayout()
        Me.GB_CONTROL.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents GB_FILTROS As GroupBox
    Friend WithEvents Label16 As Label
    Public WithEvents CB_LI_ZONA_UO As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents CB_LI_TIEMPO_YYYY As ComboBox
    Friend WithEvents CB_LI_UNIDAD_OPERATIVA As ComboBox
    Friend WithEvents Label13 As Label
    Public WithEvents BT_LI_BUSCAR As Button
    Friend WithEvents FL_MENU As FlowLayoutPanel
    Public WithEvents BT_EDITAR As Button
    Public WithEvents BT_ELIMINAR As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Public WithEvents GB_LISTADO As GroupBox
    Public WithEvents GB_FICHA As GroupBox
    Friend WithEvents CHART As DataVisualization.Charting.Chart
    Friend WithEvents Label21 As Label
    Public WithEvents TB_P02_VALOR As TextBox
    Friend WithEvents Label12 As Label
    Public WithEvents TB_P01_VALOR As TextBox
    Friend WithEvents Label17 As Label
    Public WithEvents TB_V02_VALOR As TextBox
    Friend WithEvents Label11 As Label
    Public WithEvents TB_V01_VALOR As TextBox
    Friend WithEvents Label8 As Label
    Public WithEvents TB_VALOR_ACUMULADO As TextBox
    Friend WithEvents Label7 As Label
    Public WithEvents TB_XLS_UNIDAD_OPERATIVA As TextBox
    Friend WithEvents Label3 As Label
    Public WithEvents TB_XLS_UO As TextBox
    Friend WithEvents Label4 As Label
    Public WithEvents TB_K_YYYY As TextBox
    Public WithEvents LI_LISTADO As DataGridView
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Public WithEvents BT_SALIR As Button
    Public WithEvents BT_CANCELAR As Button
    Public WithEvents BT_GUARDAR As Button
    Public WithEvents BT_LISTADO As Button
    Public WithEvents BT_EXPORTAR_EXCEL As Button
    Friend WithEvents GB_OPERACION As GroupBox
    Public WithEvents LB_RESULTADO As Label
    Friend WithEvents GB_CONTROL As GroupBox
    Public WithEvents LB_VERSION As Label
    Public WithEvents LB_RELOJ As Label
    Public WithEvents TI_RELOJ As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_LI_TEMPORADA As ComboBox
    Friend WithEvents Label14 As Label
    Public WithEvents TB_LI_BUSCAR As TextBox
    Friend WithEvents CB_UNIDAD_OPERATIVA As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GB_TIPO_GRAFICA As GroupBox
    Friend WithEvents RB_PAY As RadioButton
    Friend WithEvents RB_CIRCULAR As RadioButton
    Friend WithEvents RB_PUNTOS As RadioButton
    Friend WithEvents RB_BARRAS As RadioButton
    Friend WithEvents RB_LINEAS As RadioButton
    Friend WithEvents RB_COLUMNA As RadioButton
    Friend WithEvents RB_AREA As RadioButton
    Friend WithEvents Panel1 As Panel
End Class
