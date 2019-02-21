<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FO_CREDITO_BANCO_AMORTIZACION
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LI_LISTADO = New System.Windows.Forms.DataGridView()
        Me.GB_OPERACION = New System.Windows.Forms.GroupBox()
        Me.LB_RESULTADO = New System.Windows.Forms.TextBox()
        Me.GB_LISTADO = New System.Windows.Forms.GroupBox()
        Me.GB_CONTROL = New System.Windows.Forms.GroupBox()
        Me.LB_VERSION = New System.Windows.Forms.Label()
        Me.LB_RELOJ = New System.Windows.Forms.Label()
        Me.TB_K_CREDITO_BANCARIO = New System.Windows.Forms.TextBox()
        Me.LB_ID = New System.Windows.Forms.Label()
        Me.TI_RELOJ = New System.Windows.Forms.Timer(Me.components)
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_SALIR = New System.Windows.Forms.Button()
        Me.BT_GUARDAR = New System.Windows.Forms.Button()
        Me.BT_EXPORTAR_EXCEL = New System.Windows.Forms.Button()
        Me.GB_DATOS_CREDITO_BANCARIO = New System.Windows.Forms.GroupBox()
        Me.CB_RAZON_SOCIAL_BENEFICIADA = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.DT_F_AUTORIZACION = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.DT_F_INICIO = New System.Windows.Forms.DateTimePicker()
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
        Me.CB_TIPO_CREDITO_BANCARIO = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CB_GRUPO_CREDITO = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CB_RAZON_SOCIAL_ACREDITADA = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_C_CREDITO_BANCARIO = New System.Windows.Forms.TextBox()
        Me.TB_D_CREDITO_BANCARIO = New System.Windows.Forms.TextBox()
        Me.FL_MENU = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_OPERACION.SuspendLayout()
        Me.GB_LISTADO.SuspendLayout()
        Me.GB_CONTROL.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.GB_DATOS_CREDITO_BANCARIO.SuspendLayout()
        Me.SuspendLayout()
        '
        'LI_LISTADO
        '
        Me.LI_LISTADO.AllowUserToAddRows = False
        Me.LI_LISTADO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LI_LISTADO.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LI_LISTADO.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.LI_LISTADO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LI_LISTADO.Location = New System.Drawing.Point(12, 26)
        Me.LI_LISTADO.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.LI_LISTADO.Name = "LI_LISTADO"
        Me.LI_LISTADO.Size = New System.Drawing.Size(1296, 351)
        Me.LI_LISTADO.TabIndex = 2
        '
        'GB_OPERACION
        '
        Me.GB_OPERACION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_OPERACION.BackColor = System.Drawing.Color.White
        Me.GB_OPERACION.Controls.Add(Me.LB_RESULTADO)
        Me.GB_OPERACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_OPERACION.Location = New System.Drawing.Point(13, 589)
        Me.GB_OPERACION.Name = "GB_OPERACION"
        Me.GB_OPERACION.Size = New System.Drawing.Size(873, 52)
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
        Me.LB_RESULTADO.Location = New System.Drawing.Point(6, 16)
        Me.LB_RESULTADO.Multiline = True
        Me.LB_RESULTADO.Name = "LB_RESULTADO"
        Me.LB_RESULTADO.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.LB_RESULTADO.Size = New System.Drawing.Size(861, 30)
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
        Me.GB_LISTADO.Location = New System.Drawing.Point(13, 200)
        Me.GB_LISTADO.Name = "GB_LISTADO"
        Me.GB_LISTADO.Size = New System.Drawing.Size(1319, 390)
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
        Me.GB_CONTROL.Location = New System.Drawing.Point(893, 589)
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
        'TB_K_CREDITO_BANCARIO
        '
        Me.TB_K_CREDITO_BANCARIO.Enabled = False
        Me.TB_K_CREDITO_BANCARIO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_K_CREDITO_BANCARIO.Location = New System.Drawing.Point(26, 33)
        Me.TB_K_CREDITO_BANCARIO.Name = "TB_K_CREDITO_BANCARIO"
        Me.TB_K_CREDITO_BANCARIO.Size = New System.Drawing.Size(75, 22)
        Me.TB_K_CREDITO_BANCARIO.TabIndex = 21
        '
        'LB_ID
        '
        Me.LB_ID.AutoSize = True
        Me.LB_ID.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ID.Location = New System.Drawing.Point(29, 18)
        Me.LB_ID.Name = "LB_ID"
        Me.LB_ID.Size = New System.Drawing.Size(18, 13)
        Me.LB_ID.TabIndex = 19
        Me.LB_ID.Text = "ID"
        '
        'TI_RELOJ
        '
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel2.Controls.Add(Me.BT_SALIR)
        Me.FlowLayoutPanel2.Controls.Add(Me.BT_GUARDAR)
        Me.FlowLayoutPanel2.Controls.Add(Me.BT_EXPORTAR_EXCEL)
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(864, 8)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(468, 40)
        Me.FlowLayoutPanel2.TabIndex = 53
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
        Me.BT_SALIR.Location = New System.Drawing.Point(398, 6)
        Me.BT_SALIR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_SALIR.Name = "BT_SALIR"
        Me.BT_SALIR.Size = New System.Drawing.Size(70, 34)
        Me.BT_SALIR.TabIndex = 23
        Me.BT_SALIR.UseVisualStyleBackColor = True
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
        Me.BT_GUARDAR.Location = New System.Drawing.Point(328, 6)
        Me.BT_GUARDAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_GUARDAR.Name = "BT_GUARDAR"
        Me.BT_GUARDAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_GUARDAR.TabIndex = 23
        Me.BT_GUARDAR.UseVisualStyleBackColor = True
        '
        'BT_EXPORTAR_EXCEL
        '
        Me.BT_EXPORTAR_EXCEL.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_EXPORTAR_EXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_EXPORTAR_EXCEL.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_export
        Me.BT_EXPORTAR_EXCEL.Location = New System.Drawing.Point(255, 6)
        Me.BT_EXPORTAR_EXCEL.Name = "BT_EXPORTAR_EXCEL"
        Me.BT_EXPORTAR_EXCEL.Size = New System.Drawing.Size(70, 34)
        Me.BT_EXPORTAR_EXCEL.TabIndex = 28
        Me.BT_EXPORTAR_EXCEL.Tag = "Copiar al portapapeles"
        Me.BT_EXPORTAR_EXCEL.UseVisualStyleBackColor = True
        '
        'GB_DATOS_CREDITO_BANCARIO
        '
        Me.GB_DATOS_CREDITO_BANCARIO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_DATOS_CREDITO_BANCARIO.BackColor = System.Drawing.Color.White
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.CB_RAZON_SOCIAL_BENEFICIADA)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.Label1)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.Label28)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.DT_F_AUTORIZACION)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.Label27)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.DT_F_INICIO)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.Label26)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.TB_CANTIDAD_PERIODOS)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.Label25)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.TB_TASA_INTERES_ANUAL)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.Label24)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.TB_MONTO_PRESTAMO)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.CB_TIPO_CALCULO_CREDITO)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.Label23)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.Label22)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.TB_NUMERO_CREDITO)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.CB_TIPO_CREDITO_BANCARIO)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.Label18)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.CB_GRUPO_CREDITO)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.Label19)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.CB_RAZON_SOCIAL_ACREDITADA)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.Label20)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.TB_K_CREDITO_BANCARIO)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.LB_ID)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.Label7)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.Label8)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.TB_C_CREDITO_BANCARIO)
        Me.GB_DATOS_CREDITO_BANCARIO.Controls.Add(Me.TB_D_CREDITO_BANCARIO)
        Me.GB_DATOS_CREDITO_BANCARIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_DATOS_CREDITO_BANCARIO.Location = New System.Drawing.Point(13, 50)
        Me.GB_DATOS_CREDITO_BANCARIO.Name = "GB_DATOS_CREDITO_BANCARIO"
        Me.GB_DATOS_CREDITO_BANCARIO.Size = New System.Drawing.Size(1319, 147)
        Me.GB_DATOS_CREDITO_BANCARIO.TabIndex = 47
        Me.GB_DATOS_CREDITO_BANCARIO.TabStop = False
        Me.GB_DATOS_CREDITO_BANCARIO.Text = "Ficha"
        '
        'CB_RAZON_SOCIAL_BENEFICIADA
        '
        Me.CB_RAZON_SOCIAL_BENEFICIADA.Enabled = False
        Me.CB_RAZON_SOCIAL_BENEFICIADA.FormattingEnabled = True
        Me.CB_RAZON_SOCIAL_BENEFICIADA.Location = New System.Drawing.Point(652, 74)
        Me.CB_RAZON_SOCIAL_BENEFICIADA.Name = "CB_RAZON_SOCIAL_BENEFICIADA"
        Me.CB_RAZON_SOCIAL_BENEFICIADA.Size = New System.Drawing.Size(643, 21)
        Me.CB_RAZON_SOCIAL_BENEFICIADA.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(655, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Razón Social Beneficiada"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(1033, 99)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(121, 13)
        Me.Label28.TabIndex = 69
        Me.Label28.Text = "Fecha de Autorización"
        '
        'DT_F_AUTORIZACION
        '
        Me.DT_F_AUTORIZACION.CustomFormat = "yyyy-MM-dd"
        Me.DT_F_AUTORIZACION.Enabled = False
        Me.DT_F_AUTORIZACION.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_F_AUTORIZACION.Location = New System.Drawing.Point(1030, 116)
        Me.DT_F_AUTORIZACION.Name = "DT_F_AUTORIZACION"
        Me.DT_F_AUTORIZACION.Size = New System.Drawing.Size(130, 20)
        Me.DT_F_AUTORIZACION.TabIndex = 68
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(1178, 99)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(84, 13)
        Me.Label27.TabIndex = 67
        Me.Label27.Text = "Fecha de inicio"
        '
        'DT_F_INICIO
        '
        Me.DT_F_INICIO.CustomFormat = "yyyy-MM-dd"
        Me.DT_F_INICIO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_F_INICIO.Location = New System.Drawing.Point(1166, 116)
        Me.DT_F_INICIO.Name = "DT_F_INICIO"
        Me.DT_F_INICIO.Size = New System.Drawing.Size(130, 20)
        Me.DT_F_INICIO.TabIndex = 66
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(908, 99)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(89, 13)
        Me.Label26.TabIndex = 65
        Me.Label26.Text = "No. de Períodos"
        '
        'TB_CANTIDAD_PERIODOS
        '
        Me.TB_CANTIDAD_PERIODOS.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CANTIDAD_PERIODOS.Location = New System.Drawing.Point(905, 114)
        Me.TB_CANTIDAD_PERIODOS.Name = "TB_CANTIDAD_PERIODOS"
        Me.TB_CANTIDAD_PERIODOS.Size = New System.Drawing.Size(119, 22)
        Me.TB_CANTIDAD_PERIODOS.TabIndex = 64
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(758, 99)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(115, 13)
        Me.Label25.TabIndex = 63
        Me.Label25.Text = "Tasa de Interés Anual"
        '
        'TB_TASA_INTERES_ANUAL
        '
        Me.TB_TASA_INTERES_ANUAL.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_TASA_INTERES_ANUAL.Location = New System.Drawing.Point(755, 114)
        Me.TB_TASA_INTERES_ANUAL.Name = "TB_TASA_INTERES_ANUAL"
        Me.TB_TASA_INTERES_ANUAL.Size = New System.Drawing.Size(144, 22)
        Me.TB_TASA_INTERES_ANUAL.TabIndex = 62
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(572, 98)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(102, 13)
        Me.Label24.TabIndex = 61
        Me.Label24.Text = "Monto del Crédito"
        '
        'TB_MONTO_PRESTAMO
        '
        Me.TB_MONTO_PRESTAMO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_MONTO_PRESTAMO.Location = New System.Drawing.Point(569, 114)
        Me.TB_MONTO_PRESTAMO.Name = "TB_MONTO_PRESTAMO"
        Me.TB_MONTO_PRESTAMO.Size = New System.Drawing.Size(180, 22)
        Me.TB_MONTO_PRESTAMO.TabIndex = 60
        '
        'CB_TIPO_CALCULO_CREDITO
        '
        Me.CB_TIPO_CALCULO_CREDITO.FormattingEnabled = True
        Me.CB_TIPO_CALCULO_CREDITO.Location = New System.Drawing.Point(184, 115)
        Me.CB_TIPO_CALCULO_CREDITO.Name = "CB_TIPO_CALCULO_CREDITO"
        Me.CB_TIPO_CALCULO_CREDITO.Size = New System.Drawing.Size(178, 21)
        Me.CB_TIPO_CALCULO_CREDITO.TabIndex = 59
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(187, 98)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(86, 13)
        Me.Label23.TabIndex = 58
        Me.Label23.Text = "Tipo de Cálculo"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(370, 98)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(105, 13)
        Me.Label22.TabIndex = 57
        Me.Label22.Text = "Numero de Crédito"
        '
        'TB_NUMERO_CREDITO
        '
        Me.TB_NUMERO_CREDITO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NUMERO_CREDITO.Location = New System.Drawing.Point(368, 114)
        Me.TB_NUMERO_CREDITO.Name = "TB_NUMERO_CREDITO"
        Me.TB_NUMERO_CREDITO.Size = New System.Drawing.Size(195, 22)
        Me.TB_NUMERO_CREDITO.TabIndex = 56
        '
        'CB_TIPO_CREDITO_BANCARIO
        '
        Me.CB_TIPO_CREDITO_BANCARIO.Enabled = False
        Me.CB_TIPO_CREDITO_BANCARIO.FormattingEnabled = True
        Me.CB_TIPO_CREDITO_BANCARIO.Location = New System.Drawing.Point(27, 115)
        Me.CB_TIPO_CREDITO_BANCARIO.Name = "CB_TIPO_CREDITO_BANCARIO"
        Me.CB_TIPO_CREDITO_BANCARIO.Size = New System.Drawing.Size(151, 21)
        Me.CB_TIPO_CREDITO_BANCARIO.TabIndex = 47
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(30, 98)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 13)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Tipo de Crédito"
        '
        'CB_GRUPO_CREDITO
        '
        Me.CB_GRUPO_CREDITO.Enabled = False
        Me.CB_GRUPO_CREDITO.FormattingEnabled = True
        Me.CB_GRUPO_CREDITO.Location = New System.Drawing.Point(918, 34)
        Me.CB_GRUPO_CREDITO.Name = "CB_GRUPO_CREDITO"
        Me.CB_GRUPO_CREDITO.Size = New System.Drawing.Size(377, 21)
        Me.CB_GRUPO_CREDITO.TabIndex = 45
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(921, 18)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 13)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Grupo Crédito"
        '
        'CB_RAZON_SOCIAL_ACREDITADA
        '
        Me.CB_RAZON_SOCIAL_ACREDITADA.Enabled = False
        Me.CB_RAZON_SOCIAL_ACREDITADA.FormattingEnabled = True
        Me.CB_RAZON_SOCIAL_ACREDITADA.Location = New System.Drawing.Point(26, 74)
        Me.CB_RAZON_SOCIAL_ACREDITADA.Name = "CB_RAZON_SOCIAL_ACREDITADA"
        Me.CB_RAZON_SOCIAL_ACREDITADA.Size = New System.Drawing.Size(620, 21)
        Me.CB_RAZON_SOCIAL_ACREDITADA.TabIndex = 43
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(29, 58)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(130, 13)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "Razón Social Acreditada"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(416, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Comentarios"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(110, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Descripción"
        '
        'TB_C_CREDITO_BANCARIO
        '
        Me.TB_C_CREDITO_BANCARIO.Enabled = False
        Me.TB_C_CREDITO_BANCARIO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_C_CREDITO_BANCARIO.Location = New System.Drawing.Point(413, 33)
        Me.TB_C_CREDITO_BANCARIO.Name = "TB_C_CREDITO_BANCARIO"
        Me.TB_C_CREDITO_BANCARIO.Size = New System.Drawing.Size(499, 22)
        Me.TB_C_CREDITO_BANCARIO.TabIndex = 10
        '
        'TB_D_CREDITO_BANCARIO
        '
        Me.TB_D_CREDITO_BANCARIO.AccessibleDescription = ""
        Me.TB_D_CREDITO_BANCARIO.Enabled = False
        Me.TB_D_CREDITO_BANCARIO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_D_CREDITO_BANCARIO.Location = New System.Drawing.Point(107, 33)
        Me.TB_D_CREDITO_BANCARIO.Name = "TB_D_CREDITO_BANCARIO"
        Me.TB_D_CREDITO_BANCARIO.Size = New System.Drawing.Size(300, 22)
        Me.TB_D_CREDITO_BANCARIO.TabIndex = 8
        Me.TB_D_CREDITO_BANCARIO.Tag = "1"
        '
        'FL_MENU
        '
        Me.FL_MENU.BackColor = System.Drawing.Color.White
        Me.FL_MENU.Location = New System.Drawing.Point(13, 8)
        Me.FL_MENU.Name = "FL_MENU"
        Me.FL_MENU.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FL_MENU.Size = New System.Drawing.Size(885, 40)
        Me.FL_MENU.TabIndex = 52
        '
        'FO_CREDITO_BANCO_AMORTIZACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1347, 648)
        Me.Controls.Add(Me.GB_DATOS_CREDITO_BANCARIO)
        Me.Controls.Add(Me.GB_OPERACION)
        Me.Controls.Add(Me.GB_LISTADO)
        Me.Controls.Add(Me.GB_CONTROL)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FL_MENU)
        Me.Name = "FO_CREDITO_BANCO_AMORTIZACION"
        Me.Text = "Tabla de Simulación de Amortizaciones por Crédito Bancario"
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_OPERACION.ResumeLayout(False)
        Me.GB_OPERACION.PerformLayout()
        Me.GB_LISTADO.ResumeLayout(False)
        Me.GB_CONTROL.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.GB_DATOS_CREDITO_BANCARIO.ResumeLayout(False)
        Me.GB_DATOS_CREDITO_BANCARIO.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents LI_LISTADO As DataGridView
    Friend WithEvents GB_OPERACION As GroupBox
    Public WithEvents GB_LISTADO As GroupBox
    Public WithEvents GB_DATOS_CREDITO_BANCARIO As GroupBox
    Public WithEvents TB_K_CREDITO_BANCARIO As TextBox
    Friend WithEvents LB_ID As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Public WithEvents TB_C_CREDITO_BANCARIO As TextBox
    Public WithEvents TB_D_CREDITO_BANCARIO As TextBox
    Friend WithEvents GB_CONTROL As GroupBox
    Public WithEvents LB_VERSION As Label
    Public WithEvents LB_RELOJ As Label
    Public WithEvents BT_SALIR As Button
    Public WithEvents BT_GUARDAR As Button
    Public WithEvents BT_EXPORTAR_EXCEL As Button
    Public WithEvents TI_RELOJ As Timer
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FL_MENU As FlowLayoutPanel
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
    Public WithEvents CB_TIPO_CREDITO_BANCARIO As ComboBox
    Friend WithEvents Label18 As Label
    Public WithEvents CB_GRUPO_CREDITO As ComboBox
    Friend WithEvents Label19 As Label
    Public WithEvents CB_RAZON_SOCIAL_ACREDITADA As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents DT_F_AUTORIZACION As DateTimePicker
    Friend WithEvents Label27 As Label
    Friend WithEvents DT_F_INICIO As DateTimePicker
    Public WithEvents LB_RESULTADO As TextBox
    Public WithEvents CB_RAZON_SOCIAL_BENEFICIADA As ComboBox
    Friend WithEvents Label1 As Label
End Class
