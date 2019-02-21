<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FO_ESTIMACION
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.GB_CONTROL = New System.Windows.Forms.GroupBox()
        Me.LB_VERSION = New System.Windows.Forms.Label()
        Me.LB_RELOJ = New System.Windows.Forms.Label()
        Me.GB_OPERACION = New System.Windows.Forms.GroupBox()
        Me.LB_DISPONIBLE = New System.Windows.Forms.Label()
        Me.LB_RESULTADO = New System.Windows.Forms.Label()
        Me.GB_LISTADO = New System.Windows.Forms.GroupBox()
        Me.LI_LISTADO = New System.Windows.Forms.DataGridView()
        Me.GB_GRAFICA = New System.Windows.Forms.GroupBox()
        Me.GB_TIPO_GRAFICA = New System.Windows.Forms.GroupBox()
        Me.RB_PAY = New System.Windows.Forms.RadioButton()
        Me.RB_CIRCULAR = New System.Windows.Forms.RadioButton()
        Me.RB_PUNTOS = New System.Windows.Forms.RadioButton()
        Me.RB_BARRAS = New System.Windows.Forms.RadioButton()
        Me.RB_LINEAS = New System.Windows.Forms.RadioButton()
        Me.RB_COLUMNA = New System.Windows.Forms.RadioButton()
        Me.RB_AREA = New System.Windows.Forms.RadioButton()
        Me.CHART = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GB_FICHA_DOCUMENTO = New System.Windows.Forms.GroupBox()
        Me.TB_D_DOCUMENTO_D0M4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CB_UNIDAD_OPERATIVA = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TB_K_DOCUMENTO_D0M4 = New System.Windows.Forms.TextBox()
        Me.LB_ID = New System.Windows.Forms.Label()
        Me.GB_FICHA_POB = New System.Windows.Forms.GroupBox()
        Me.TB_K_PARAMETRO_POB = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_D_PARAMETRO_POB = New System.Windows.Forms.TextBox()
        Me.CB_TIPO_CALCULO = New System.Windows.Forms.ComboBox()
        Me.CB_HISTORICO_CONSIDERABLE = New System.Windows.Forms.ComboBox()
        Me.CB_TEMPORADA = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_INCREMENTO_COMPROMISO_KG = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BT_SALIR = New System.Windows.Forms.Button()
        Me.BT_BACK = New System.Windows.Forms.Button()
        Me.BT_NEXT = New System.Windows.Forms.Button()
        Me.TI_RELOJ = New System.Windows.Forms.Timer(Me.components)
        Me.CB_YYYY = New System.Windows.Forms.ComboBox()
        Me.GB_CONTROL.SuspendLayout()
        Me.GB_OPERACION.SuspendLayout()
        Me.GB_LISTADO.SuspendLayout()
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_GRAFICA.SuspendLayout()
        Me.GB_TIPO_GRAFICA.SuspendLayout()
        CType(Me.CHART, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_FICHA_DOCUMENTO.SuspendLayout()
        Me.GB_FICHA_POB.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_CONTROL
        '
        Me.GB_CONTROL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_CONTROL.BackColor = System.Drawing.Color.White
        Me.GB_CONTROL.Controls.Add(Me.LB_VERSION)
        Me.GB_CONTROL.Controls.Add(Me.LB_RELOJ)
        Me.GB_CONTROL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_CONTROL.Location = New System.Drawing.Point(1063, 648)
        Me.GB_CONTROL.Name = "GB_CONTROL"
        Me.GB_CONTROL.Size = New System.Drawing.Size(376, 67)
        Me.GB_CONTROL.TabIndex = 67
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
        'GB_OPERACION
        '
        Me.GB_OPERACION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_OPERACION.BackColor = System.Drawing.Color.White
        Me.GB_OPERACION.Controls.Add(Me.LB_DISPONIBLE)
        Me.GB_OPERACION.Controls.Add(Me.LB_RESULTADO)
        Me.GB_OPERACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_OPERACION.Location = New System.Drawing.Point(2, 649)
        Me.GB_OPERACION.Name = "GB_OPERACION"
        Me.GB_OPERACION.Size = New System.Drawing.Size(1057, 67)
        Me.GB_OPERACION.TabIndex = 66
        Me.GB_OPERACION.TabStop = False
        Me.GB_OPERACION.Text = "Operación"
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
        'LB_RESULTADO
        '
        Me.LB_RESULTADO.AutoSize = True
        Me.LB_RESULTADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_RESULTADO.Location = New System.Drawing.Point(72, 25)
        Me.LB_RESULTADO.Name = "LB_RESULTADO"
        Me.LB_RESULTADO.Size = New System.Drawing.Size(0, 13)
        Me.LB_RESULTADO.TabIndex = 1
        '
        'GB_LISTADO
        '
        Me.GB_LISTADO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_LISTADO.BackColor = System.Drawing.Color.White
        Me.GB_LISTADO.Controls.Add(Me.LI_LISTADO)
        Me.GB_LISTADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_LISTADO.Location = New System.Drawing.Point(3, 130)
        Me.GB_LISTADO.Name = "GB_LISTADO"
        Me.GB_LISTADO.Size = New System.Drawing.Size(802, 516)
        Me.GB_LISTADO.TabIndex = 65
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
        Me.LI_LISTADO.Size = New System.Drawing.Size(779, 477)
        Me.LI_LISTADO.TabIndex = 2
        '
        'GB_GRAFICA
        '
        Me.GB_GRAFICA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_GRAFICA.BackColor = System.Drawing.Color.White
        Me.GB_GRAFICA.Controls.Add(Me.GB_TIPO_GRAFICA)
        Me.GB_GRAFICA.Controls.Add(Me.CHART)
        Me.GB_GRAFICA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_GRAFICA.Location = New System.Drawing.Point(809, 130)
        Me.GB_GRAFICA.Name = "GB_GRAFICA"
        Me.GB_GRAFICA.Size = New System.Drawing.Size(631, 516)
        Me.GB_GRAFICA.TabIndex = 68
        Me.GB_GRAFICA.TabStop = False
        Me.GB_GRAFICA.Text = "Grafica"
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
        Me.GB_TIPO_GRAFICA.Location = New System.Drawing.Point(507, 26)
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
        'CHART
        '
        Me.CHART.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CHART.BorderlineColor = System.Drawing.Color.Black
        Me.CHART.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea1.Name = "ChartArea1"
        Me.CHART.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.CHART.Legends.Add(Legend1)
        Me.CHART.Location = New System.Drawing.Point(15, 26)
        Me.CHART.Name = "CHART"
        Me.CHART.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Me.CHART.Size = New System.Drawing.Size(486, 474)
        Me.CHART.TabIndex = 101
        Me.CHART.Text = "3"
        '
        'GB_FICHA_DOCUMENTO
        '
        Me.GB_FICHA_DOCUMENTO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_FICHA_DOCUMENTO.BackColor = System.Drawing.Color.White
        Me.GB_FICHA_DOCUMENTO.Controls.Add(Me.CB_YYYY)
        Me.GB_FICHA_DOCUMENTO.Controls.Add(Me.TB_D_DOCUMENTO_D0M4)
        Me.GB_FICHA_DOCUMENTO.Controls.Add(Me.Label7)
        Me.GB_FICHA_DOCUMENTO.Controls.Add(Me.Label12)
        Me.GB_FICHA_DOCUMENTO.Controls.Add(Me.CB_UNIDAD_OPERATIVA)
        Me.GB_FICHA_DOCUMENTO.Controls.Add(Me.Label10)
        Me.GB_FICHA_DOCUMENTO.Controls.Add(Me.TB_K_DOCUMENTO_D0M4)
        Me.GB_FICHA_DOCUMENTO.Controls.Add(Me.LB_ID)
        Me.GB_FICHA_DOCUMENTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FICHA_DOCUMENTO.Location = New System.Drawing.Point(4, 5)
        Me.GB_FICHA_DOCUMENTO.Name = "GB_FICHA_DOCUMENTO"
        Me.GB_FICHA_DOCUMENTO.Size = New System.Drawing.Size(463, 121)
        Me.GB_FICHA_DOCUMENTO.TabIndex = 69
        Me.GB_FICHA_DOCUMENTO.TabStop = False
        Me.GB_FICHA_DOCUMENTO.Text = "Documento"
        '
        'TB_D_DOCUMENTO_D0M4
        '
        Me.TB_D_DOCUMENTO_D0M4.Enabled = False
        Me.TB_D_DOCUMENTO_D0M4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_D_DOCUMENTO_D0M4.Location = New System.Drawing.Point(15, 82)
        Me.TB_D_DOCUMENTO_D0M4.Name = "TB_D_DOCUMENTO_D0M4"
        Me.TB_D_DOCUMENTO_D0M4.Size = New System.Drawing.Size(434, 20)
        Me.TB_D_DOCUMENTO_D0M4.TabIndex = 40
        Me.TB_D_DOCUMENTO_D0M4.Tag = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Descripción del Documento"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(342, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Año"
        '
        'CB_UNIDAD_OPERATIVA
        '
        Me.CB_UNIDAD_OPERATIVA.FormattingEnabled = True
        Me.CB_UNIDAD_OPERATIVA.Location = New System.Drawing.Point(66, 41)
        Me.CB_UNIDAD_OPERATIVA.Name = "CB_UNIDAD_OPERATIVA"
        Me.CB_UNIDAD_OPERATIVA.Size = New System.Drawing.Size(267, 21)
        Me.CB_UNIDAD_OPERATIVA.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(69, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Unidad Operativa"
        '
        'TB_K_DOCUMENTO_D0M4
        '
        Me.TB_K_DOCUMENTO_D0M4.Enabled = False
        Me.TB_K_DOCUMENTO_D0M4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_K_DOCUMENTO_D0M4.Location = New System.Drawing.Point(15, 40)
        Me.TB_K_DOCUMENTO_D0M4.Name = "TB_K_DOCUMENTO_D0M4"
        Me.TB_K_DOCUMENTO_D0M4.Size = New System.Drawing.Size(45, 22)
        Me.TB_K_DOCUMENTO_D0M4.TabIndex = 21
        '
        'LB_ID
        '
        Me.LB_ID.AutoSize = True
        Me.LB_ID.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ID.Location = New System.Drawing.Point(18, 24)
        Me.LB_ID.Name = "LB_ID"
        Me.LB_ID.Size = New System.Drawing.Size(18, 13)
        Me.LB_ID.TabIndex = 19
        Me.LB_ID.Text = "ID"
        '
        'GB_FICHA_POB
        '
        Me.GB_FICHA_POB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_FICHA_POB.BackColor = System.Drawing.Color.White
        Me.GB_FICHA_POB.Controls.Add(Me.TB_K_PARAMETRO_POB)
        Me.GB_FICHA_POB.Controls.Add(Me.Label11)
        Me.GB_FICHA_POB.Controls.Add(Me.Label8)
        Me.GB_FICHA_POB.Controls.Add(Me.TB_D_PARAMETRO_POB)
        Me.GB_FICHA_POB.Controls.Add(Me.CB_TIPO_CALCULO)
        Me.GB_FICHA_POB.Controls.Add(Me.CB_HISTORICO_CONSIDERABLE)
        Me.GB_FICHA_POB.Controls.Add(Me.CB_TEMPORADA)
        Me.GB_FICHA_POB.Controls.Add(Me.Label1)
        Me.GB_FICHA_POB.Controls.Add(Me.Label2)
        Me.GB_FICHA_POB.Controls.Add(Me.Label3)
        Me.GB_FICHA_POB.Controls.Add(Me.TB_INCREMENTO_COMPROMISO_KG)
        Me.GB_FICHA_POB.Controls.Add(Me.Label4)
        Me.GB_FICHA_POB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FICHA_POB.Location = New System.Drawing.Point(472, 5)
        Me.GB_FICHA_POB.Name = "GB_FICHA_POB"
        Me.GB_FICHA_POB.Size = New System.Drawing.Size(734, 121)
        Me.GB_FICHA_POB.TabIndex = 70
        Me.GB_FICHA_POB.TabStop = False
        Me.GB_FICHA_POB.Text = "Parametros para cálculo de Proyección de Ventas Objetivo"
        '
        'TB_K_PARAMETRO_POB
        '
        Me.TB_K_PARAMETRO_POB.Enabled = False
        Me.TB_K_PARAMETRO_POB.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_K_PARAMETRO_POB.Location = New System.Drawing.Point(16, 41)
        Me.TB_K_PARAMETRO_POB.Name = "TB_K_PARAMETRO_POB"
        Me.TB_K_PARAMETRO_POB.Size = New System.Drawing.Size(51, 22)
        Me.TB_K_PARAMETRO_POB.TabIndex = 99
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 13)
        Me.Label11.TabIndex = 98
        Me.Label11.Text = "ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(75, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "Descripción"
        '
        'TB_D_PARAMETRO_POB
        '
        Me.TB_D_PARAMETRO_POB.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_D_PARAMETRO_POB.Location = New System.Drawing.Point(72, 41)
        Me.TB_D_PARAMETRO_POB.Name = "TB_D_PARAMETRO_POB"
        Me.TB_D_PARAMETRO_POB.Size = New System.Drawing.Size(391, 22)
        Me.TB_D_PARAMETRO_POB.TabIndex = 96
        Me.TB_D_PARAMETRO_POB.Tag = "1"
        '
        'CB_TIPO_CALCULO
        '
        Me.CB_TIPO_CALCULO.FormattingEnabled = True
        Me.CB_TIPO_CALCULO.Location = New System.Drawing.Point(469, 82)
        Me.CB_TIPO_CALCULO.Name = "CB_TIPO_CALCULO"
        Me.CB_TIPO_CALCULO.Size = New System.Drawing.Size(246, 21)
        Me.CB_TIPO_CALCULO.TabIndex = 95
        Me.CB_TIPO_CALCULO.Tag = ""
        '
        'CB_HISTORICO_CONSIDERABLE
        '
        Me.CB_HISTORICO_CONSIDERABLE.FormattingEnabled = True
        Me.CB_HISTORICO_CONSIDERABLE.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.CB_HISTORICO_CONSIDERABLE.Location = New System.Drawing.Point(16, 82)
        Me.CB_HISTORICO_CONSIDERABLE.Name = "CB_HISTORICO_CONSIDERABLE"
        Me.CB_HISTORICO_CONSIDERABLE.Size = New System.Drawing.Size(172, 21)
        Me.CB_HISTORICO_CONSIDERABLE.TabIndex = 94
        Me.CB_HISTORICO_CONSIDERABLE.Tag = ""
        '
        'CB_TEMPORADA
        '
        Me.CB_TEMPORADA.FormattingEnabled = True
        Me.CB_TEMPORADA.Location = New System.Drawing.Point(469, 41)
        Me.CB_TEMPORADA.Name = "CB_TEMPORADA"
        Me.CB_TEMPORADA.Size = New System.Drawing.Size(246, 21)
        Me.CB_TEMPORADA.TabIndex = 93
        Me.CB_TEMPORADA.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(197, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Incremento Compromiso en Kg"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(472, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Tipo de Cálculo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Años de Historico Considerable"
        '
        'TB_INCREMENTO_COMPROMISO_KG
        '
        Me.TB_INCREMENTO_COMPROMISO_KG.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_INCREMENTO_COMPROMISO_KG.Location = New System.Drawing.Point(194, 82)
        Me.TB_INCREMENTO_COMPROMISO_KG.Name = "TB_INCREMENTO_COMPROMISO_KG"
        Me.TB_INCREMENTO_COMPROMISO_KG.Size = New System.Drawing.Size(269, 22)
        Me.TB_INCREMENTO_COMPROMISO_KG.TabIndex = 29
        Me.TB_INCREMENTO_COMPROMISO_KG.Tag = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(515, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Temporada"
        '
        'BT_SALIR
        '
        Me.BT_SALIR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_SALIR.BackColor = System.Drawing.Color.White
        Me.BT_SALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_SALIR.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.BT_SALIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_SALIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_SALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_SALIR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_exit
        Me.BT_SALIR.Location = New System.Drawing.Point(1212, 89)
        Me.BT_SALIR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_SALIR.Name = "BT_SALIR"
        Me.BT_SALIR.Size = New System.Drawing.Size(227, 35)
        Me.BT_SALIR.TabIndex = 73
        Me.BT_SALIR.UseVisualStyleBackColor = False
        '
        'BT_BACK
        '
        Me.BT_BACK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_BACK.BackColor = System.Drawing.Color.White
        Me.BT_BACK.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.BT_BACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_BACK.Location = New System.Drawing.Point(1212, 10)
        Me.BT_BACK.Name = "BT_BACK"
        Me.BT_BACK.Size = New System.Drawing.Size(227, 35)
        Me.BT_BACK.TabIndex = 72
        Me.BT_BACK.Text = "Calcular    Σ"
        Me.BT_BACK.UseVisualStyleBackColor = False
        '
        'BT_NEXT
        '
        Me.BT_NEXT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_NEXT.BackColor = System.Drawing.Color.White
        Me.BT_NEXT.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.BT_NEXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_NEXT.Location = New System.Drawing.Point(1212, 50)
        Me.BT_NEXT.Name = "BT_NEXT"
        Me.BT_NEXT.Size = New System.Drawing.Size(227, 35)
        Me.BT_NEXT.TabIndex = 71
        Me.BT_NEXT.Text = "Recalcular    Σ"
        Me.BT_NEXT.UseVisualStyleBackColor = False
        '
        'TI_RELOJ
        '
        '
        'CB_YYYY
        '
        Me.CB_YYYY.FormattingEnabled = True
        Me.CB_YYYY.Location = New System.Drawing.Point(339, 40)
        Me.CB_YYYY.Name = "CB_YYYY"
        Me.CB_YYYY.Size = New System.Drawing.Size(110, 21)
        Me.CB_YYYY.TabIndex = 41
        '
        'FO_ESTIMACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1444, 718)
        Me.Controls.Add(Me.BT_SALIR)
        Me.Controls.Add(Me.BT_BACK)
        Me.Controls.Add(Me.BT_NEXT)
        Me.Controls.Add(Me.GB_FICHA_POB)
        Me.Controls.Add(Me.GB_FICHA_DOCUMENTO)
        Me.Controls.Add(Me.GB_GRAFICA)
        Me.Controls.Add(Me.GB_CONTROL)
        Me.Controls.Add(Me.GB_OPERACION)
        Me.Controls.Add(Me.GB_LISTADO)
        Me.Name = "FO_ESTIMACION"
        Me.Text = "PROYECCION DE VENTAS OBJETIVO"
        Me.GB_CONTROL.ResumeLayout(False)
        Me.GB_OPERACION.ResumeLayout(False)
        Me.GB_OPERACION.PerformLayout()
        Me.GB_LISTADO.ResumeLayout(False)
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_GRAFICA.ResumeLayout(False)
        Me.GB_TIPO_GRAFICA.ResumeLayout(False)
        Me.GB_TIPO_GRAFICA.PerformLayout()
        CType(Me.CHART, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_FICHA_DOCUMENTO.ResumeLayout(False)
        Me.GB_FICHA_DOCUMENTO.PerformLayout()
        Me.GB_FICHA_POB.ResumeLayout(False)
        Me.GB_FICHA_POB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GB_CONTROL As GroupBox
    Public WithEvents LB_VERSION As Label
    Public WithEvents LB_RELOJ As Label
    Friend WithEvents GB_OPERACION As GroupBox
    Public WithEvents LB_DISPONIBLE As Label
    Public WithEvents LB_RESULTADO As Label
    Public WithEvents GB_LISTADO As GroupBox
    Public WithEvents LI_LISTADO As DataGridView
    Public WithEvents GB_GRAFICA As GroupBox
    Friend WithEvents GB_TIPO_GRAFICA As GroupBox
    Friend WithEvents RB_PAY As RadioButton
    Friend WithEvents RB_CIRCULAR As RadioButton
    Friend WithEvents RB_PUNTOS As RadioButton
    Friend WithEvents RB_BARRAS As RadioButton
    Friend WithEvents RB_LINEAS As RadioButton
    Friend WithEvents RB_COLUMNA As RadioButton
    Friend WithEvents RB_AREA As RadioButton
    Friend WithEvents CHART As DataVisualization.Charting.Chart
    Public WithEvents GB_FICHA_DOCUMENTO As GroupBox
    Friend WithEvents TB_D_DOCUMENTO_D0M4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CB_UNIDAD_OPERATIVA As ComboBox
    Friend WithEvents Label10 As Label
    Public WithEvents TB_K_DOCUMENTO_D0M4 As TextBox
    Friend WithEvents LB_ID As Label
    Public WithEvents GB_FICHA_POB As GroupBox
    Public WithEvents TB_K_PARAMETRO_POB As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Public WithEvents TB_D_PARAMETRO_POB As TextBox
    Public WithEvents CB_TIPO_CALCULO As ComboBox
    Public WithEvents CB_HISTORICO_CONSIDERABLE As ComboBox
    Public WithEvents CB_TEMPORADA As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Public WithEvents TB_INCREMENTO_COMPROMISO_KG As TextBox
    Friend WithEvents Label4 As Label
    Public WithEvents BT_SALIR As Button
    Friend WithEvents BT_BACK As Button
    Friend WithEvents BT_NEXT As Button
    Public WithEvents TI_RELOJ As Timer
    Friend WithEvents CB_YYYY As ComboBox
End Class
