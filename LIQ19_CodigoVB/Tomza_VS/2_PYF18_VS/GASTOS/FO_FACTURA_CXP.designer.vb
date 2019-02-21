<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FO_FACTURA_CXP
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
        Me.CB_LI_TIPO_COMPROBANTE = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.TB_LI_F_FINAL = New System.Windows.Forms.MaskedTextBox()
        Me.TB_LI_F_INICIAL = New System.Windows.Forms.MaskedTextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.CB_LI_ESTATUS_FACTURA_CXP = New System.Windows.Forms.ComboBox()
        Me.CB_LI_CAPTURA_FACTURA_CXP = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BT_LI_BUSCAR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_LI_BUSCAR = New System.Windows.Forms.TextBox()
        Me.GB_LISTADO = New System.Windows.Forms.GroupBox()
        Me.LI_LISTADO = New System.Windows.Forms.DataGridView()
        Me.GB_OPERACION = New System.Windows.Forms.GroupBox()
        Me.LB_RESULTADO = New System.Windows.Forms.TextBox()
        Me.LB_RELOJ = New System.Windows.Forms.Label()
        Me.GB_CONTROL = New System.Windows.Forms.GroupBox()
        Me.LB_VERSION = New System.Windows.Forms.Label()
        Me.TB_K_FACTURA_CXP = New System.Windows.Forms.TextBox()
        Me.LB_ID = New System.Windows.Forms.Label()
        Me.TI_RELOJ = New System.Windows.Forms.Timer(Me.components)
        Me.FL_MENU_2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_SALIR = New System.Windows.Forms.Button()
        Me.BT_CANCELAR = New System.Windows.Forms.Button()
        Me.BT_GUARDAR = New System.Windows.Forms.Button()
        Me.BT_LISTADO = New System.Windows.Forms.Button()
        Me.BT_EXPORTAR_EXCEL = New System.Windows.Forms.Button()
        Me.GB_FICHA = New System.Windows.Forms.GroupBox()
        Me.BT_VER_PDF = New System.Windows.Forms.Button()
        Me.CB_TIPO_COMPROBANTE = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TB_SALDO = New System.Windows.Forms.TextBox()
        Me.TB_ABONOS = New System.Windows.Forms.TextBox()
        Me.L2 = New System.Windows.Forms.Label()
        Me.L = New System.Windows.Forms.Label()
        Me.CB_USUARIO_CAMBIO = New System.Windows.Forms.ComboBox()
        Me.CB_USUARIO_ALTA = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_F_ALTA = New System.Windows.Forms.TextBox()
        Me.TB_F_CAMBIO = New System.Windows.Forms.TextBox()
        Me.TB_RFC_RECEPTOR = New System.Windows.Forms.TextBox()
        Me.TB_RFC_EMISOR = New System.Windows.Forms.TextBox()
        Me.TB_F_EMISION = New System.Windows.Forms.MaskedTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_ESTATUS_FACTURA_CXP = New System.Windows.Forms.ComboBox()
        Me.TB_IVA = New System.Windows.Forms.TextBox()
        Me.TB_TOTAL = New System.Windows.Forms.TextBox()
        Me.TB_C_FACTURA_CXP = New System.Windows.Forms.TextBox()
        Me.CB_CAPTURA_FACTURA_CXP = New System.Windows.Forms.ComboBox()
        Me.TB_SUBTOTAL = New System.Windows.Forms.TextBox()
        Me.TB_FOLIO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_SERIE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BT_ELIMINAR = New System.Windows.Forms.Button()
        Me.FL_MENU_1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_AGREGAR = New System.Windows.Forms.Button()
        Me.BT_EDITAR = New System.Windows.Forms.Button()
        Me.DT_F_INSTRUCCION = New System.Windows.Forms.DateTimePicker()
        Me.BT_GENERAR_INSTRUCCION = New System.Windows.Forms.Button()
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
        'GB_FILTROS
        '
        Me.GB_FILTROS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_FILTROS.BackColor = System.Drawing.Color.White
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_TIPO_COMPROBANTE)
        Me.GB_FILTROS.Controls.Add(Me.Label14)
        Me.GB_FILTROS.Controls.Add(Me.Label39)
        Me.GB_FILTROS.Controls.Add(Me.Label38)
        Me.GB_FILTROS.Controls.Add(Me.TB_LI_F_FINAL)
        Me.GB_FILTROS.Controls.Add(Me.TB_LI_F_INICIAL)
        Me.GB_FILTROS.Controls.Add(Me.Label37)
        Me.GB_FILTROS.Controls.Add(Me.Label32)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_ESTATUS_FACTURA_CXP)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_CAPTURA_FACTURA_CXP)
        Me.GB_FILTROS.Controls.Add(Me.Label10)
        Me.GB_FILTROS.Controls.Add(Me.Label15)
        Me.GB_FILTROS.Controls.Add(Me.BT_LI_BUSCAR)
        Me.GB_FILTROS.Controls.Add(Me.Label1)
        Me.GB_FILTROS.Controls.Add(Me.TB_LI_BUSCAR)
        Me.GB_FILTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FILTROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_FILTROS.Location = New System.Drawing.Point(13, 56)
        Me.GB_FILTROS.Name = "GB_FILTROS"
        Me.GB_FILTROS.Size = New System.Drawing.Size(806, 106)
        Me.GB_FILTROS.TabIndex = 34
        Me.GB_FILTROS.TabStop = False
        Me.GB_FILTROS.Text = "Filtros"
        '
        'CB_LI_TIPO_COMPROBANTE
        '
        Me.CB_LI_TIPO_COMPROBANTE.FormattingEnabled = True
        Me.CB_LI_TIPO_COMPROBANTE.Location = New System.Drawing.Point(222, 71)
        Me.CB_LI_TIPO_COMPROBANTE.Name = "CB_LI_TIPO_COMPROBANTE"
        Me.CB_LI_TIPO_COMPROBANTE.Size = New System.Drawing.Size(151, 21)
        Me.CB_LI_TIPO_COMPROBANTE.TabIndex = 15
        Me.CB_LI_TIPO_COMPROBANTE.Tag = "1"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(225, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 13)
        Me.Label14.TabIndex = 205
        Me.Label14.Text = "Tipo de Comprobante"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.DarkGray
        Me.Label39.Location = New System.Drawing.Point(508, 92)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(71, 13)
        Me.Label39.TabIndex = 41
        Me.Label39.Text = "dd/mm/aaaa"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.DarkGray
        Me.Label38.Location = New System.Drawing.Point(379, 92)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(71, 13)
        Me.Label38.TabIndex = 40
        Me.Label38.Text = "dd/mm/aaaa"
        '
        'TB_LI_F_FINAL
        '
        Me.TB_LI_F_FINAL.Location = New System.Drawing.Point(510, 72)
        Me.TB_LI_F_FINAL.Mask = "00/00/0000"
        Me.TB_LI_F_FINAL.Name = "TB_LI_F_FINAL"
        Me.TB_LI_F_FINAL.Size = New System.Drawing.Size(123, 20)
        Me.TB_LI_F_FINAL.TabIndex = 25
        Me.TB_LI_F_FINAL.ValidatingType = GetType(Date)
        '
        'TB_LI_F_INICIAL
        '
        Me.TB_LI_F_INICIAL.Location = New System.Drawing.Point(379, 72)
        Me.TB_LI_F_INICIAL.Mask = "00/00/0000"
        Me.TB_LI_F_INICIAL.Name = "TB_LI_F_INICIAL"
        Me.TB_LI_F_INICIAL.Size = New System.Drawing.Size(125, 20)
        Me.TB_LI_F_INICIAL.TabIndex = 20
        Me.TB_LI_F_INICIAL.ValidatingType = GetType(Date)
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(514, 56)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(56, 13)
        Me.Label37.TabIndex = 37
        Me.Label37.Text = "Fecha Fin"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(382, 56)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(68, 13)
        Me.Label32.TabIndex = 36
        Me.Label32.Text = "Fecha Inicio"
        '
        'CB_LI_ESTATUS_FACTURA_CXP
        '
        Me.CB_LI_ESTATUS_FACTURA_CXP.DropDownWidth = 346
        Me.CB_LI_ESTATUS_FACTURA_CXP.FormattingEnabled = True
        Me.CB_LI_ESTATUS_FACTURA_CXP.Location = New System.Drawing.Point(12, 72)
        Me.CB_LI_ESTATUS_FACTURA_CXP.Name = "CB_LI_ESTATUS_FACTURA_CXP"
        Me.CB_LI_ESTATUS_FACTURA_CXP.Size = New System.Drawing.Size(204, 21)
        Me.CB_LI_ESTATUS_FACTURA_CXP.TabIndex = 10
        '
        'CB_LI_CAPTURA_FACTURA_CXP
        '
        Me.CB_LI_CAPTURA_FACTURA_CXP.FormattingEnabled = True
        Me.CB_LI_CAPTURA_FACTURA_CXP.Location = New System.Drawing.Point(442, 30)
        Me.CB_LI_CAPTURA_FACTURA_CXP.Name = "CB_LI_CAPTURA_FACTURA_CXP"
        Me.CB_LI_CAPTURA_FACTURA_CXP.Size = New System.Drawing.Size(190, 21)
        Me.CB_LI_CAPTURA_FACTURA_CXP.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Estatus Factura"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(445, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 13)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Tipo Captura"
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
        Me.BT_LI_BUSCAR.Location = New System.Drawing.Point(730, 43)
        Me.BT_LI_BUSCAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_LI_BUSCAR.Name = "BT_LI_BUSCAR"
        Me.BT_LI_BUSCAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_LI_BUSCAR.TabIndex = 30
        Me.BT_LI_BUSCAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_LI_BUSCAR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Buscar"
        '
        'TB_LI_BUSCAR
        '
        Me.TB_LI_BUSCAR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LI_BUSCAR.Location = New System.Drawing.Point(12, 30)
        Me.TB_LI_BUSCAR.Name = "TB_LI_BUSCAR"
        Me.TB_LI_BUSCAR.Size = New System.Drawing.Size(424, 22)
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
        Me.GB_LISTADO.Location = New System.Drawing.Point(13, 160)
        Me.GB_LISTADO.Name = "GB_LISTADO"
        Me.GB_LISTADO.Size = New System.Drawing.Size(806, 397)
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
        Me.LI_LISTADO.Size = New System.Drawing.Size(783, 358)
        Me.LI_LISTADO.TabIndex = 2
        '
        'GB_OPERACION
        '
        Me.GB_OPERACION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_OPERACION.BackColor = System.Drawing.Color.White
        Me.GB_OPERACION.Controls.Add(Me.LB_RESULTADO)
        Me.GB_OPERACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_OPERACION.Location = New System.Drawing.Point(13, 559)
        Me.GB_OPERACION.Name = "GB_OPERACION"
        Me.GB_OPERACION.Size = New System.Drawing.Size(360, 52)
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
        Me.LB_RESULTADO.Location = New System.Drawing.Point(6, 16)
        Me.LB_RESULTADO.Multiline = True
        Me.LB_RESULTADO.Name = "LB_RESULTADO"
        Me.LB_RESULTADO.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.LB_RESULTADO.Size = New System.Drawing.Size(348, 30)
        Me.LB_RESULTADO.TabIndex = 6
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
        Me.GB_CONTROL.Location = New System.Drawing.Point(380, 559)
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
        'TB_K_FACTURA_CXP
        '
        Me.TB_K_FACTURA_CXP.Enabled = False
        Me.TB_K_FACTURA_CXP.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_K_FACTURA_CXP.Location = New System.Drawing.Point(641, 19)
        Me.TB_K_FACTURA_CXP.Name = "TB_K_FACTURA_CXP"
        Me.TB_K_FACTURA_CXP.Size = New System.Drawing.Size(79, 22)
        Me.TB_K_FACTURA_CXP.TabIndex = 35
        '
        'LB_ID
        '
        Me.LB_ID.AutoSize = True
        Me.LB_ID.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ID.Location = New System.Drawing.Point(620, 22)
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
        Me.FL_MENU_2.Location = New System.Drawing.Point(430, 8)
        Me.FL_MENU_2.Name = "FL_MENU_2"
        Me.FL_MENU_2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FL_MENU_2.Size = New System.Drawing.Size(389, 40)
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
        Me.BT_SALIR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_exit
        Me.BT_SALIR.Location = New System.Drawing.Point(319, 3)
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
        Me.BT_CANCELAR.Location = New System.Drawing.Point(249, 3)
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
        Me.BT_GUARDAR.Location = New System.Drawing.Point(179, 3)
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
        Me.BT_LISTADO.Location = New System.Drawing.Point(109, 3)
        Me.BT_LISTADO.Margin = New System.Windows.Forms.Padding(0)
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
        Me.BT_EXPORTAR_EXCEL.Location = New System.Drawing.Point(39, 3)
        Me.BT_EXPORTAR_EXCEL.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_EXPORTAR_EXCEL.Name = "BT_EXPORTAR_EXCEL"
        Me.BT_EXPORTAR_EXCEL.Size = New System.Drawing.Size(70, 34)
        Me.BT_EXPORTAR_EXCEL.TabIndex = 28
        Me.BT_EXPORTAR_EXCEL.Tag = "Copiar al portapapeles"
        Me.BT_EXPORTAR_EXCEL.UseVisualStyleBackColor = True
        '
        'GB_FICHA
        '
        Me.GB_FICHA.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GB_FICHA.BackColor = System.Drawing.Color.White
        Me.GB_FICHA.Controls.Add(Me.BT_VER_PDF)
        Me.GB_FICHA.Controls.Add(Me.CB_TIPO_COMPROBANTE)
        Me.GB_FICHA.Controls.Add(Me.Label21)
        Me.GB_FICHA.Controls.Add(Me.TB_SALDO)
        Me.GB_FICHA.Controls.Add(Me.TB_ABONOS)
        Me.GB_FICHA.Controls.Add(Me.L2)
        Me.GB_FICHA.Controls.Add(Me.L)
        Me.GB_FICHA.Controls.Add(Me.CB_USUARIO_CAMBIO)
        Me.GB_FICHA.Controls.Add(Me.CB_USUARIO_ALTA)
        Me.GB_FICHA.Controls.Add(Me.Label5)
        Me.GB_FICHA.Controls.Add(Me.Label9)
        Me.GB_FICHA.Controls.Add(Me.Label6)
        Me.GB_FICHA.Controls.Add(Me.Label2)
        Me.GB_FICHA.Controls.Add(Me.TB_F_ALTA)
        Me.GB_FICHA.Controls.Add(Me.TB_F_CAMBIO)
        Me.GB_FICHA.Controls.Add(Me.TB_RFC_RECEPTOR)
        Me.GB_FICHA.Controls.Add(Me.TB_RFC_EMISOR)
        Me.GB_FICHA.Controls.Add(Me.TB_F_EMISION)
        Me.GB_FICHA.Controls.Add(Me.Label18)
        Me.GB_FICHA.Controls.Add(Me.Label16)
        Me.GB_FICHA.Controls.Add(Me.Label3)
        Me.GB_FICHA.Controls.Add(Me.CB_ESTATUS_FACTURA_CXP)
        Me.GB_FICHA.Controls.Add(Me.TB_IVA)
        Me.GB_FICHA.Controls.Add(Me.TB_TOTAL)
        Me.GB_FICHA.Controls.Add(Me.TB_C_FACTURA_CXP)
        Me.GB_FICHA.Controls.Add(Me.CB_CAPTURA_FACTURA_CXP)
        Me.GB_FICHA.Controls.Add(Me.TB_SUBTOTAL)
        Me.GB_FICHA.Controls.Add(Me.TB_FOLIO)
        Me.GB_FICHA.Controls.Add(Me.Label4)
        Me.GB_FICHA.Controls.Add(Me.TB_SERIE)
        Me.GB_FICHA.Controls.Add(Me.Label8)
        Me.GB_FICHA.Controls.Add(Me.Label20)
        Me.GB_FICHA.Controls.Add(Me.Label19)
        Me.GB_FICHA.Controls.Add(Me.Label17)
        Me.GB_FICHA.Controls.Add(Me.Label12)
        Me.GB_FICHA.Controls.Add(Me.Label11)
        Me.GB_FICHA.Controls.Add(Me.Label7)
        Me.GB_FICHA.Controls.Add(Me.TB_K_FACTURA_CXP)
        Me.GB_FICHA.Controls.Add(Me.LB_ID)
        Me.GB_FICHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FICHA.Location = New System.Drawing.Point(42, 195)
        Me.GB_FICHA.Name = "GB_FICHA"
        Me.GB_FICHA.Size = New System.Drawing.Size(751, 283)
        Me.GB_FICHA.TabIndex = 33
        Me.GB_FICHA.TabStop = False
        Me.GB_FICHA.Text = "Ficha"
        '
        'BT_VER_PDF
        '
        Me.BT_VER_PDF.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BT_VER_PDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_VER_PDF.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_VER_PDF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_VER_PDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_VER_PDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_VER_PDF.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.SENDPDF
        Me.BT_VER_PDF.Location = New System.Drawing.Point(650, 227)
        Me.BT_VER_PDF.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_VER_PDF.Name = "BT_VER_PDF"
        Me.BT_VER_PDF.Size = New System.Drawing.Size(70, 34)
        Me.BT_VER_PDF.TabIndex = 209
        Me.BT_VER_PDF.UseVisualStyleBackColor = True
        '
        'CB_TIPO_COMPROBANTE
        '
        Me.CB_TIPO_COMPROBANTE.FormattingEnabled = True
        Me.CB_TIPO_COMPROBANTE.Location = New System.Drawing.Point(197, 93)
        Me.CB_TIPO_COMPROBANTE.Name = "CB_TIPO_COMPROBANTE"
        Me.CB_TIPO_COMPROBANTE.Size = New System.Drawing.Size(147, 21)
        Me.CB_TIPO_COMPROBANTE.TabIndex = 150
        Me.CB_TIPO_COMPROBANTE.Tag = "1"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(200, 78)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(109, 13)
        Me.Label21.TabIndex = 207
        Me.Label21.Text = "Tipo de Comprobante"
        '
        'TB_SALDO
        '
        Me.TB_SALDO.Enabled = False
        Me.TB_SALDO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_SALDO.Location = New System.Drawing.Point(596, 172)
        Me.TB_SALDO.Name = "TB_SALDO"
        Me.TB_SALDO.Size = New System.Drawing.Size(125, 22)
        Me.TB_SALDO.TabIndex = 170
        Me.TB_SALDO.Tag = "1"
        '
        'TB_ABONOS
        '
        Me.TB_ABONOS.AccessibleDescription = ""
        Me.TB_ABONOS.Enabled = False
        Me.TB_ABONOS.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_ABONOS.Location = New System.Drawing.Point(596, 144)
        Me.TB_ABONOS.Name = "TB_ABONOS"
        Me.TB_ABONOS.Size = New System.Drawing.Size(125, 22)
        Me.TB_ABONOS.TabIndex = 160
        Me.TB_ABONOS.Tag = "1"
        '
        'L2
        '
        Me.L2.AutoSize = True
        Me.L2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L2.Location = New System.Drawing.Point(559, 177)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(34, 13)
        Me.L2.TabIndex = 202
        Me.L2.Text = "Saldo"
        '
        'L
        '
        Me.L.AutoSize = True
        Me.L.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L.Location = New System.Drawing.Point(550, 148)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(43, 13)
        Me.L.TabIndex = 201
        Me.L.Text = "Abonos"
        '
        'CB_USUARIO_CAMBIO
        '
        Me.CB_USUARIO_CAMBIO.Enabled = False
        Me.CB_USUARIO_CAMBIO.FormattingEnabled = True
        Me.CB_USUARIO_CAMBIO.Location = New System.Drawing.Point(246, 243)
        Me.CB_USUARIO_CAMBIO.Name = "CB_USUARIO_CAMBIO"
        Me.CB_USUARIO_CAMBIO.Size = New System.Drawing.Size(125, 21)
        Me.CB_USUARIO_CAMBIO.TabIndex = 1002
        '
        'CB_USUARIO_ALTA
        '
        Me.CB_USUARIO_ALTA.Enabled = False
        Me.CB_USUARIO_ALTA.FormattingEnabled = True
        Me.CB_USUARIO_ALTA.Location = New System.Drawing.Point(19, 242)
        Me.CB_USUARIO_ALTA.Name = "CB_USUARIO_ALTA"
        Me.CB_USUARIO_ALTA.Size = New System.Drawing.Size(120, 21)
        Me.CB_USUARIO_ALTA.TabIndex = 1000
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(146, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 195
        Me.Label5.Text = "Fecha Alta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(378, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 196
        Me.Label9.Text = "F. Modificación"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(250, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 197
        Me.Label6.Text = "Us. Modificación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 198
        Me.Label2.Text = "Usuario Alta"
        '
        'TB_F_ALTA
        '
        Me.TB_F_ALTA.Enabled = False
        Me.TB_F_ALTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_F_ALTA.Location = New System.Drawing.Point(143, 242)
        Me.TB_F_ALTA.Name = "TB_F_ALTA"
        Me.TB_F_ALTA.Size = New System.Drawing.Size(99, 22)
        Me.TB_F_ALTA.TabIndex = 1001
        '
        'TB_F_CAMBIO
        '
        Me.TB_F_CAMBIO.Enabled = False
        Me.TB_F_CAMBIO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_F_CAMBIO.Location = New System.Drawing.Point(375, 242)
        Me.TB_F_CAMBIO.Name = "TB_F_CAMBIO"
        Me.TB_F_CAMBIO.Size = New System.Drawing.Size(111, 22)
        Me.TB_F_CAMBIO.TabIndex = 1003
        '
        'TB_RFC_RECEPTOR
        '
        Me.TB_RFC_RECEPTOR.AccessibleDescription = ""
        Me.TB_RFC_RECEPTOR.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TB_RFC_RECEPTOR.Location = New System.Drawing.Point(260, 135)
        Me.TB_RFC_RECEPTOR.Name = "TB_RFC_RECEPTOR"
        Me.TB_RFC_RECEPTOR.Size = New System.Drawing.Size(226, 22)
        Me.TB_RFC_RECEPTOR.TabIndex = 50
        Me.TB_RFC_RECEPTOR.Tag = "1"
        '
        'TB_RFC_EMISOR
        '
        Me.TB_RFC_EMISOR.AccessibleDescription = ""
        Me.TB_RFC_EMISOR.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TB_RFC_EMISOR.Location = New System.Drawing.Point(22, 135)
        Me.TB_RFC_EMISOR.Name = "TB_RFC_EMISOR"
        Me.TB_RFC_EMISOR.Size = New System.Drawing.Size(232, 22)
        Me.TB_RFC_EMISOR.TabIndex = 40
        Me.TB_RFC_EMISOR.Tag = "1"
        '
        'TB_F_EMISION
        '
        Me.TB_F_EMISION.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TB_F_EMISION.Location = New System.Drawing.Point(350, 49)
        Me.TB_F_EMISION.Mask = "00/00/0000"
        Me.TB_F_EMISION.Name = "TB_F_EMISION"
        Me.TB_F_EMISION.Size = New System.Drawing.Size(136, 22)
        Me.TB_F_EMISION.TabIndex = 80
        Me.TB_F_EMISION.Tag = "1"
        Me.TB_F_EMISION.ValidatingType = GetType(Date)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(353, 34)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 13)
        Me.Label18.TabIndex = 188
        Me.Label18.Text = "Fecha Emisión"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(263, 120)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 13)
        Me.Label16.TabIndex = 186
        Me.Label16.Text = "RFC del Receptor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 184
        Me.Label3.Text = "RFC del Emisor"
        '
        'CB_ESTATUS_FACTURA_CXP
        '
        Me.CB_ESTATUS_FACTURA_CXP.FormattingEnabled = True
        Me.CB_ESTATUS_FACTURA_CXP.Location = New System.Drawing.Point(350, 93)
        Me.CB_ESTATUS_FACTURA_CXP.Name = "CB_ESTATUS_FACTURA_CXP"
        Me.CB_ESTATUS_FACTURA_CXP.Size = New System.Drawing.Size(136, 21)
        Me.CB_ESTATUS_FACTURA_CXP.TabIndex = 140
        Me.CB_ESTATUS_FACTURA_CXP.Tag = "1"
        '
        'TB_IVA
        '
        Me.TB_IVA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_IVA.Location = New System.Drawing.Point(596, 88)
        Me.TB_IVA.Name = "TB_IVA"
        Me.TB_IVA.Size = New System.Drawing.Size(125, 22)
        Me.TB_IVA.TabIndex = 100
        Me.TB_IVA.Tag = "1"
        '
        'TB_TOTAL
        '
        Me.TB_TOTAL.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_TOTAL.Location = New System.Drawing.Point(596, 116)
        Me.TB_TOTAL.Name = "TB_TOTAL"
        Me.TB_TOTAL.Size = New System.Drawing.Size(125, 22)
        Me.TB_TOTAL.TabIndex = 110
        Me.TB_TOTAL.Tag = "1"
        '
        'TB_C_FACTURA_CXP
        '
        Me.TB_C_FACTURA_CXP.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_C_FACTURA_CXP.Location = New System.Drawing.Point(22, 179)
        Me.TB_C_FACTURA_CXP.Name = "TB_C_FACTURA_CXP"
        Me.TB_C_FACTURA_CXP.Size = New System.Drawing.Size(464, 22)
        Me.TB_C_FACTURA_CXP.TabIndex = 120
        Me.TB_C_FACTURA_CXP.Tag = "1"
        '
        'CB_CAPTURA_FACTURA_CXP
        '
        Me.CB_CAPTURA_FACTURA_CXP.FormattingEnabled = True
        Me.CB_CAPTURA_FACTURA_CXP.Location = New System.Drawing.Point(22, 93)
        Me.CB_CAPTURA_FACTURA_CXP.Name = "CB_CAPTURA_FACTURA_CXP"
        Me.CB_CAPTURA_FACTURA_CXP.Size = New System.Drawing.Size(169, 21)
        Me.CB_CAPTURA_FACTURA_CXP.TabIndex = 130
        Me.CB_CAPTURA_FACTURA_CXP.Tag = "1"
        '
        'TB_SUBTOTAL
        '
        Me.TB_SUBTOTAL.AccessibleDescription = ""
        Me.TB_SUBTOTAL.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_SUBTOTAL.Location = New System.Drawing.Point(596, 60)
        Me.TB_SUBTOTAL.Name = "TB_SUBTOTAL"
        Me.TB_SUBTOTAL.Size = New System.Drawing.Size(125, 22)
        Me.TB_SUBTOTAL.TabIndex = 90
        Me.TB_SUBTOTAL.Tag = "1"
        '
        'TB_FOLIO
        '
        Me.TB_FOLIO.AccessibleDescription = ""
        Me.TB_FOLIO.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TB_FOLIO.Location = New System.Drawing.Point(197, 49)
        Me.TB_FOLIO.Name = "TB_FOLIO"
        Me.TB_FOLIO.Size = New System.Drawing.Size(147, 22)
        Me.TB_FOLIO.TabIndex = 70
        Me.TB_FOLIO.Tag = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(200, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 148
        Me.Label4.Text = "Folio"
        '
        'TB_SERIE
        '
        Me.TB_SERIE.AccessibleDescription = ""
        Me.TB_SERIE.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TB_SERIE.Location = New System.Drawing.Point(22, 49)
        Me.TB_SERIE.Name = "TB_SERIE"
        Me.TB_SERIE.Size = New System.Drawing.Size(169, 22)
        Me.TB_SERIE.TabIndex = 60
        Me.TB_SERIE.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 146
        Me.Label8.Text = "Serie"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(569, 93)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(24, 13)
        Me.Label20.TabIndex = 111
        Me.Label20.Text = "IVA"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(562, 121)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(31, 13)
        Me.Label19.TabIndex = 109
        Me.Label19.Text = "Total"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(547, 65)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 13)
        Me.Label17.TabIndex = 106
        Me.Label17.Text = "Subtotal"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(353, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 97
        Me.Label12.Text = "Estatus Factura"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 96
        Me.Label11.Text = "Tipo Captura"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 163)
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
        Me.BT_ELIMINAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_delete
        Me.BT_ELIMINAR.Location = New System.Drawing.Point(140, 3)
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
        Me.FL_MENU_1.BackColor = System.Drawing.Color.White
        Me.FL_MENU_1.Controls.Add(Me.BT_AGREGAR)
        Me.FL_MENU_1.Controls.Add(Me.BT_EDITAR)
        Me.FL_MENU_1.Controls.Add(Me.BT_ELIMINAR)
        Me.FL_MENU_1.Controls.Add(Me.DT_F_INSTRUCCION)
        Me.FL_MENU_1.Controls.Add(Me.BT_GENERAR_INSTRUCCION)
        Me.FL_MENU_1.Location = New System.Drawing.Point(13, 8)
        Me.FL_MENU_1.Name = "FL_MENU_1"
        Me.FL_MENU_1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FL_MENU_1.Size = New System.Drawing.Size(691, 40)
        Me.FL_MENU_1.TabIndex = 38
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
        'DT_F_INSTRUCCION
        '
        Me.DT_F_INSTRUCCION.CustomFormat = "dd/MM/yyyy"
        Me.DT_F_INSTRUCCION.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_F_INSTRUCCION.Location = New System.Drawing.Point(213, 10)
        Me.DT_F_INSTRUCCION.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.DT_F_INSTRUCCION.Name = "DT_F_INSTRUCCION"
        Me.DT_F_INSTRUCCION.Size = New System.Drawing.Size(97, 20)
        Me.DT_F_INSTRUCCION.TabIndex = 9
        '
        'BT_GENERAR_INSTRUCCION
        '
        Me.BT_GENERAR_INSTRUCCION.FlatAppearance.BorderSize = 0
        Me.BT_GENERAR_INSTRUCCION.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_GENERAR_INSTRUCCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_GENERAR_INSTRUCCION.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.php4wrREz_opt
        Me.BT_GENERAR_INSTRUCCION.Location = New System.Drawing.Point(313, 3)
        Me.BT_GENERAR_INSTRUCCION.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_GENERAR_INSTRUCCION.Name = "BT_GENERAR_INSTRUCCION"
        Me.BT_GENERAR_INSTRUCCION.Size = New System.Drawing.Size(70, 34)
        Me.BT_GENERAR_INSTRUCCION.TabIndex = 10
        Me.BT_GENERAR_INSTRUCCION.Tag = "Generar Instrucción"
        Me.BT_GENERAR_INSTRUCCION.UseVisualStyleBackColor = True
        '
        'FO_FACTURA_CXP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(834, 618)
        Me.Controls.Add(Me.GB_FICHA)
        Me.Controls.Add(Me.GB_FILTROS)
        Me.Controls.Add(Me.GB_LISTADO)
        Me.Controls.Add(Me.GB_OPERACION)
        Me.Controls.Add(Me.GB_CONTROL)
        Me.Controls.Add(Me.FL_MENU_2)
        Me.Controls.Add(Me.FL_MENU_1)
        Me.Name = "FO_FACTURA_CXP"
        Me.Text = "Facturas de Cuentas por Cobrar"
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
    Public WithEvents GB_FILTROS As GroupBox
    Public WithEvents BT_LI_BUSCAR As Button
    Friend WithEvents Label1 As Label
    Public WithEvents TB_LI_BUSCAR As TextBox
    Public WithEvents GB_LISTADO As GroupBox
    Public WithEvents LI_LISTADO As DataGridView
    Public WithEvents LB_RELOJ As Label
    Public WithEvents LB_VERSION As Label
    Public WithEvents TB_K_FACTURA_CXP As TextBox
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
    Public WithEvents CB_ESTATUS_FACTURA_CXP As ComboBox
    Public WithEvents TB_IVA As TextBox
    Public WithEvents TB_TOTAL As TextBox
    Public WithEvents CB_CAPTURA_FACTURA_CXP As ComboBox
    Public WithEvents TB_SUBTOTAL As TextBox
    Public WithEvents TB_FOLIO As TextBox
    Friend WithEvents Label4 As Label
    Public WithEvents TB_SERIE As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TB_LI_F_FINAL As MaskedTextBox
    Friend WithEvents TB_LI_F_INICIAL As MaskedTextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Label32 As Label
    Public WithEvents CB_LI_ESTATUS_FACTURA_CXP As ComboBox
    Public WithEvents CB_LI_CAPTURA_FACTURA_CXP As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_F_EMISION As MaskedTextBox
    Friend WithEvents Label18 As Label
    Public WithEvents TB_RFC_RECEPTOR As TextBox
    Public WithEvents TB_RFC_EMISOR As TextBox
    Public WithEvents GB_OPERACION As GroupBox
    Public WithEvents GB_CONTROL As GroupBox
    Public WithEvents FL_MENU_2 As FlowLayoutPanel
    Public WithEvents FL_MENU_1 As FlowLayoutPanel
    Public WithEvents BT_EXPORTAR_EXCEL As Button
    Public WithEvents TB_C_FACTURA_CXP As TextBox
    Friend WithEvents Label7 As Label
    Public WithEvents CB_USUARIO_CAMBIO As ComboBox
    Public WithEvents CB_USUARIO_ALTA As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents TB_F_ALTA As TextBox
    Public WithEvents TB_F_CAMBIO As TextBox
    Public WithEvents TB_SALDO As TextBox
    Public WithEvents TB_ABONOS As TextBox
    Friend WithEvents L2 As Label
    Friend WithEvents L As Label
    Public WithEvents CB_LI_TIPO_COMPROBANTE As ComboBox
    Friend WithEvents Label14 As Label
    Public WithEvents CB_TIPO_COMPROBANTE As ComboBox
    Friend WithEvents Label21 As Label
    Public WithEvents LB_RESULTADO As TextBox
    Public WithEvents BT_VER_PDF As Button
    Friend WithEvents DT_F_INSTRUCCION As DateTimePicker
    Public WithEvents BT_GENERAR_INSTRUCCION As Button
End Class
