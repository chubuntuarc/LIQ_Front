<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FO_FACTURA_CXP_XML
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FO_FACTURA_CXP_XML))
        Me.FL_MENU = New System.Windows.Forms.GroupBox()
        Me.FB_DIALOG = New System.Windows.Forms.FolderBrowserDialog()
        Me.EL_REGISTROS_XML = New System.Diagnostics.EventLog()
        Me.OF_DIALOG = New System.Windows.Forms.OpenFileDialog()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TV_DIR = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.LB_CONTEO_ARCHIVOS = New System.Windows.Forms.Label()
        Me.LB_NOMBRE_CARPETA = New System.Windows.Forms.Label()
        Me.LV_DIR = New System.Windows.Forms.ListView()
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RT_EVENTOS = New System.Windows.Forms.RichTextBox()
        Me.GB_FICHA = New System.Windows.Forms.GroupBox()
        Me.TB_XML_UUID = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TB_XML_NOCERTIFICADOSAT = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TB_XML_FECHATIMBRADO = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TB_XML_TIPOFACTOR = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TB_XML_TASAOCUOTA = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TB_XML_IMPUESTO = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TB_XML_IMPORTE = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TB_XML_TOTALIMPUESTOSTRASLADADOS = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TB_XML_REC_USOCFDI = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TB_XML_REC_NOMBRE = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TB_XML_EMI_REGIMENFISCAL = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TB_XML_EMI_NOMBRE = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TB_XML_VERSION = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TB_XML_TIPODECOMPROBANTE = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TB_XML_TIPOCAMBIO = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TB_XML_NOCERTIFICADO = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TB_XML_MONEDA = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TB_XML_LUGAREXPEDICION = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TB_XML_METODOPAGO = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TB_XML_FORMAPAGO = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TB_XML_REC_RFC = New System.Windows.Forms.TextBox()
        Me.TB_XML_EMI_RFC = New System.Windows.Forms.TextBox()
        Me.TB_XML_FECHA = New System.Windows.Forms.MaskedTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_XML_TOTAL = New System.Windows.Forms.TextBox()
        Me.TB_C_FACTURA_CXP_XML = New System.Windows.Forms.TextBox()
        Me.TB_XML_SUBTOTAL = New System.Windows.Forms.TextBox()
        Me.TB_XML_FOLIO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_XML_SERIE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GB_OPERACION = New System.Windows.Forms.GroupBox()
        Me.LB_RESULTADO = New System.Windows.Forms.TextBox()
        Me.LB_PRO_KO = New System.Windows.Forms.Label()
        Me.LB_PRE_KO = New System.Windows.Forms.Label()
        Me.LB_PRE_OK = New System.Windows.Forms.Label()
        Me.LB_EXISTENTE = New System.Windows.Forms.Label()
        Me.LB_PRE = New System.Windows.Forms.Label()
        Me.LB_KO = New System.Windows.Forms.Label()
        Me.LB_OK = New System.Windows.Forms.Label()
        Me.LB_PROCESADOS = New System.Windows.Forms.Label()
        Me.GB_CONTROL = New System.Windows.Forms.GroupBox()
        Me.LB_VERSION = New System.Windows.Forms.Label()
        Me.LB_RELOJ = New System.Windows.Forms.Label()
        Me.TI_RELOJ = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LL_COPIAR_A_TXT = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BT_SELECCIONAR_TODOS = New System.Windows.Forms.Button()
        Me.BT_CANCELAR = New System.Windows.Forms.Button()
        Me.BT_SALIR = New System.Windows.Forms.Button()
        Me.BT_CARGAR_XML = New System.Windows.Forms.Button()
        Me.BT_VERIFICAR_XML = New System.Windows.Forms.Button()
        Me.FL_MENU.SuspendLayout()
        CType(Me.EL_REGISTROS_XML, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GB_FICHA.SuspendLayout()
        Me.GB_OPERACION.SuspendLayout()
        Me.GB_CONTROL.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FL_MENU
        '
        Me.FL_MENU.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FL_MENU.BackColor = System.Drawing.Color.White
        Me.FL_MENU.Controls.Add(Me.BT_SELECCIONAR_TODOS)
        Me.FL_MENU.Controls.Add(Me.BT_CANCELAR)
        Me.FL_MENU.Controls.Add(Me.BT_SALIR)
        Me.FL_MENU.Controls.Add(Me.BT_CARGAR_XML)
        Me.FL_MENU.Controls.Add(Me.BT_VERIFICAR_XML)
        Me.FL_MENU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FL_MENU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FL_MENU.Location = New System.Drawing.Point(2, 3)
        Me.FL_MENU.Name = "FL_MENU"
        Me.FL_MENU.Size = New System.Drawing.Size(1156, 64)
        Me.FL_MENU.TabIndex = 35
        Me.FL_MENU.TabStop = False
        Me.FL_MENU.Text = "Menú de Controles"
        '
        'EL_REGISTROS_XML
        '
        Me.EL_REGISTROS_XML.SynchronizingObject = Me
        '
        'OF_DIALOG
        '
        Me.OF_DIALOG.FileName = "OpenFileDialog1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TV_DIR)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.LB_CONTEO_ARCHIVOS)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LB_NOMBRE_CARPETA)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LV_DIR)
        Me.SplitContainer1.Size = New System.Drawing.Size(456, 454)
        Me.SplitContainer1.SplitterDistance = 151
        Me.SplitContainer1.TabIndex = 46
        '
        'TV_DIR
        '
        Me.TV_DIR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TV_DIR.Location = New System.Drawing.Point(0, 0)
        Me.TV_DIR.Name = "TV_DIR"
        Me.TV_DIR.Size = New System.Drawing.Size(151, 454)
        Me.TV_DIR.StateImageList = Me.ImageList1
        Me.TV_DIR.TabIndex = 42
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder.PNG")
        Me.ImageList1.Images.SetKeyName(1, "xml.PNG")
        '
        'LB_CONTEO_ARCHIVOS
        '
        Me.LB_CONTEO_ARCHIVOS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_CONTEO_ARCHIVOS.BackColor = System.Drawing.Color.Transparent
        Me.LB_CONTEO_ARCHIVOS.Enabled = False
        Me.LB_CONTEO_ARCHIVOS.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_CONTEO_ARCHIVOS.Location = New System.Drawing.Point(150, 4)
        Me.LB_CONTEO_ARCHIVOS.Name = "LB_CONTEO_ARCHIVOS"
        Me.LB_CONTEO_ARCHIVOS.Size = New System.Drawing.Size(133, 20)
        Me.LB_CONTEO_ARCHIVOS.TabIndex = 58
        Me.LB_CONTEO_ARCHIVOS.Text = "XML en carpeta: 0"
        Me.LB_CONTEO_ARCHIVOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LB_NOMBRE_CARPETA
        '
        Me.LB_NOMBRE_CARPETA.AutoSize = True
        Me.LB_NOMBRE_CARPETA.BackColor = System.Drawing.Color.Transparent
        Me.LB_NOMBRE_CARPETA.Enabled = False
        Me.LB_NOMBRE_CARPETA.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_NOMBRE_CARPETA.Location = New System.Drawing.Point(64, 7)
        Me.LB_NOMBRE_CARPETA.Name = "LB_NOMBRE_CARPETA"
        Me.LB_NOMBRE_CARPETA.Size = New System.Drawing.Size(101, 15)
        Me.LB_NOMBRE_CARPETA.TabIndex = 58
        Me.LB_NOMBRE_CARPETA.Text = "Carpeta actual:___"
        Me.LB_NOMBRE_CARPETA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LV_DIR
        '
        Me.LV_DIR.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nombre})
        Me.LV_DIR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LV_DIR.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LV_DIR.LargeImageList = Me.ImageList1
        Me.LV_DIR.Location = New System.Drawing.Point(0, 0)
        Me.LV_DIR.Name = "LV_DIR"
        Me.LV_DIR.Size = New System.Drawing.Size(301, 454)
        Me.LV_DIR.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.LV_DIR.StateImageList = Me.ImageList1
        Me.LV_DIR.TabIndex = 0
        Me.LV_DIR.UseCompatibleStateImageBehavior = False
        Me.LV_DIR.View = System.Windows.Forms.View.Details
        '
        'Nombre
        '
        Me.Nombre.Tag = "Nombre"
        Me.Nombre.Text = "Nombre"
        '
        'RT_EVENTOS
        '
        Me.RT_EVENTOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RT_EVENTOS.Location = New System.Drawing.Point(465, 3)
        Me.RT_EVENTOS.Name = "RT_EVENTOS"
        Me.RT_EVENTOS.Size = New System.Drawing.Size(688, 454)
        Me.RT_EVENTOS.TabIndex = 47
        Me.RT_EVENTOS.Text = ""
        Me.RT_EVENTOS.WordWrap = False
        '
        'GB_FICHA
        '
        Me.GB_FICHA.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GB_FICHA.BackColor = System.Drawing.Color.White
        Me.GB_FICHA.Controls.Add(Me.TB_XML_UUID)
        Me.GB_FICHA.Controls.Add(Me.Label34)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_NOCERTIFICADOSAT)
        Me.GB_FICHA.Controls.Add(Me.Label33)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_FECHATIMBRADO)
        Me.GB_FICHA.Controls.Add(Me.Label12)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_TIPOFACTOR)
        Me.GB_FICHA.Controls.Add(Me.Label11)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_TASAOCUOTA)
        Me.GB_FICHA.Controls.Add(Me.Label32)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_IMPUESTO)
        Me.GB_FICHA.Controls.Add(Me.Label31)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_IMPORTE)
        Me.GB_FICHA.Controls.Add(Me.Label30)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_TOTALIMPUESTOSTRASLADADOS)
        Me.GB_FICHA.Controls.Add(Me.Label29)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_REC_USOCFDI)
        Me.GB_FICHA.Controls.Add(Me.Label28)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_REC_NOMBRE)
        Me.GB_FICHA.Controls.Add(Me.Label27)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_EMI_REGIMENFISCAL)
        Me.GB_FICHA.Controls.Add(Me.Label26)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_EMI_NOMBRE)
        Me.GB_FICHA.Controls.Add(Me.Label25)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_VERSION)
        Me.GB_FICHA.Controls.Add(Me.Label24)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_TIPODECOMPROBANTE)
        Me.GB_FICHA.Controls.Add(Me.Label23)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_TIPOCAMBIO)
        Me.GB_FICHA.Controls.Add(Me.Label22)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_NOCERTIFICADO)
        Me.GB_FICHA.Controls.Add(Me.Label21)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_MONEDA)
        Me.GB_FICHA.Controls.Add(Me.Label15)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_LUGAREXPEDICION)
        Me.GB_FICHA.Controls.Add(Me.Label14)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_METODOPAGO)
        Me.GB_FICHA.Controls.Add(Me.Label13)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_FORMAPAGO)
        Me.GB_FICHA.Controls.Add(Me.Label10)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_REC_RFC)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_EMI_RFC)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_FECHA)
        Me.GB_FICHA.Controls.Add(Me.Label18)
        Me.GB_FICHA.Controls.Add(Me.Label16)
        Me.GB_FICHA.Controls.Add(Me.Label3)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_TOTAL)
        Me.GB_FICHA.Controls.Add(Me.TB_C_FACTURA_CXP_XML)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_SUBTOTAL)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_FOLIO)
        Me.GB_FICHA.Controls.Add(Me.Label4)
        Me.GB_FICHA.Controls.Add(Me.TB_XML_SERIE)
        Me.GB_FICHA.Controls.Add(Me.Label8)
        Me.GB_FICHA.Controls.Add(Me.Label19)
        Me.GB_FICHA.Controls.Add(Me.Label17)
        Me.GB_FICHA.Controls.Add(Me.Label7)
        Me.GB_FICHA.Controls.Add(Me.Label6)
        Me.GB_FICHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FICHA.Location = New System.Drawing.Point(85, 123)
        Me.GB_FICHA.Name = "GB_FICHA"
        Me.GB_FICHA.Size = New System.Drawing.Size(990, 385)
        Me.GB_FICHA.TabIndex = 49
        Me.GB_FICHA.TabStop = False
        Me.GB_FICHA.Text = "Ficha"
        '
        'TB_XML_UUID
        '
        Me.TB_XML_UUID.AccessibleDescription = ""
        Me.TB_XML_UUID.Enabled = False
        Me.TB_XML_UUID.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_UUID.Location = New System.Drawing.Point(334, 39)
        Me.TB_XML_UUID.Name = "TB_XML_UUID"
        Me.TB_XML_UUID.Size = New System.Drawing.Size(314, 22)
        Me.TB_XML_UUID.TabIndex = 232
        Me.TB_XML_UUID.Tag = ""
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(337, 24)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(95, 13)
        Me.Label34.TabIndex = 231
        Me.Label34.Text = "UUID (Folio Fiscal)"
        '
        'TB_XML_NOCERTIFICADOSAT
        '
        Me.TB_XML_NOCERTIFICADOSAT.AccessibleDescription = ""
        Me.TB_XML_NOCERTIFICADOSAT.Enabled = False
        Me.TB_XML_NOCERTIFICADOSAT.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_NOCERTIFICADOSAT.Location = New System.Drawing.Point(654, 85)
        Me.TB_XML_NOCERTIFICADOSAT.Name = "TB_XML_NOCERTIFICADOSAT"
        Me.TB_XML_NOCERTIFICADOSAT.Size = New System.Drawing.Size(314, 22)
        Me.TB_XML_NOCERTIFICADOSAT.TabIndex = 230
        Me.TB_XML_NOCERTIFICADOSAT.Tag = ""
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(657, 69)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(136, 13)
        Me.Label33.TabIndex = 229
        Me.Label33.Text = "Número de Certificado SAT"
        '
        'TB_XML_FECHATIMBRADO
        '
        Me.TB_XML_FECHATIMBRADO.Enabled = False
        Me.TB_XML_FECHATIMBRADO.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TB_XML_FECHATIMBRADO.Location = New System.Drawing.Point(760, 39)
        Me.TB_XML_FECHATIMBRADO.Mask = "00/00/0000"
        Me.TB_XML_FECHATIMBRADO.Name = "TB_XML_FECHATIMBRADO"
        Me.TB_XML_FECHATIMBRADO.Size = New System.Drawing.Size(100, 22)
        Me.TB_XML_FECHATIMBRADO.TabIndex = 228
        Me.TB_XML_FECHATIMBRADO.Tag = ""
        Me.TB_XML_FECHATIMBRADO.ValidatingType = GetType(Date)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(763, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 13)
        Me.Label12.TabIndex = 227
        Me.Label12.Text = "Fecha Timbrado"
        '
        'TB_XML_TIPOFACTOR
        '
        Me.TB_XML_TIPOFACTOR.AccessibleDescription = ""
        Me.TB_XML_TIPOFACTOR.Enabled = False
        Me.TB_XML_TIPOFACTOR.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_TIPOFACTOR.Location = New System.Drawing.Point(507, 211)
        Me.TB_XML_TIPOFACTOR.Name = "TB_XML_TIPOFACTOR"
        Me.TB_XML_TIPOFACTOR.Size = New System.Drawing.Size(141, 22)
        Me.TB_XML_TIPOFACTOR.TabIndex = 226
        Me.TB_XML_TIPOFACTOR.Tag = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(510, 195)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 225
        Me.Label11.Text = "Tipo Factor"
        '
        'TB_XML_TASAOCUOTA
        '
        Me.TB_XML_TASAOCUOTA.Enabled = False
        Me.TB_XML_TASAOCUOTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_TASAOCUOTA.Location = New System.Drawing.Point(654, 211)
        Me.TB_XML_TASAOCUOTA.Name = "TB_XML_TASAOCUOTA"
        Me.TB_XML_TASAOCUOTA.Size = New System.Drawing.Size(155, 22)
        Me.TB_XML_TASAOCUOTA.TabIndex = 224
        Me.TB_XML_TASAOCUOTA.Tag = ""
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(657, 195)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(70, 13)
        Me.Label32.TabIndex = 223
        Me.Label32.Text = "Tasa / Cuota"
        '
        'TB_XML_IMPUESTO
        '
        Me.TB_XML_IMPUESTO.Enabled = False
        Me.TB_XML_IMPUESTO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_IMPUESTO.Location = New System.Drawing.Point(334, 253)
        Me.TB_XML_IMPUESTO.Name = "TB_XML_IMPUESTO"
        Me.TB_XML_IMPUESTO.Size = New System.Drawing.Size(167, 22)
        Me.TB_XML_IMPUESTO.TabIndex = 222
        Me.TB_XML_IMPUESTO.Tag = ""
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(337, 238)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(50, 13)
        Me.Label31.TabIndex = 221
        Me.Label31.Text = "Impuesto"
        '
        'TB_XML_IMPORTE
        '
        Me.TB_XML_IMPORTE.Enabled = False
        Me.TB_XML_IMPORTE.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_IMPORTE.Location = New System.Drawing.Point(813, 344)
        Me.TB_XML_IMPORTE.Name = "TB_XML_IMPORTE"
        Me.TB_XML_IMPORTE.Size = New System.Drawing.Size(155, 22)
        Me.TB_XML_IMPORTE.TabIndex = 220
        Me.TB_XML_IMPORTE.Tag = ""
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(769, 349)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(42, 13)
        Me.Label30.TabIndex = 219
        Me.Label30.Text = "Importe"
        '
        'TB_XML_TOTALIMPUESTOSTRASLADADOS
        '
        Me.TB_XML_TOTALIMPUESTOSTRASLADADOS.Enabled = False
        Me.TB_XML_TOTALIMPUESTOSTRASLADADOS.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_TOTALIMPUESTOSTRASLADADOS.Location = New System.Drawing.Point(813, 280)
        Me.TB_XML_TOTALIMPUESTOSTRASLADADOS.Name = "TB_XML_TOTALIMPUESTOSTRASLADADOS"
        Me.TB_XML_TOTALIMPUESTOSTRASLADADOS.Size = New System.Drawing.Size(155, 22)
        Me.TB_XML_TOTALIMPUESTOSTRASLADADOS.TabIndex = 218
        Me.TB_XML_TOTALIMPUESTOSTRASLADADOS.Tag = ""
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(695, 284)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(116, 13)
        Me.Label29.TabIndex = 217
        Me.Label29.Text = "Impuestos Trasladados"
        '
        'TB_XML_REC_USOCFDI
        '
        Me.TB_XML_REC_USOCFDI.AccessibleDescription = ""
        Me.TB_XML_REC_USOCFDI.Enabled = False
        Me.TB_XML_REC_USOCFDI.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_REC_USOCFDI.Location = New System.Drawing.Point(654, 168)
        Me.TB_XML_REC_USOCFDI.Name = "TB_XML_REC_USOCFDI"
        Me.TB_XML_REC_USOCFDI.Size = New System.Drawing.Size(155, 22)
        Me.TB_XML_REC_USOCFDI.TabIndex = 216
        Me.TB_XML_REC_USOCFDI.Tag = ""
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(657, 152)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(68, 13)
        Me.Label28.TabIndex = 215
        Me.Label28.Text = "Uso de CFDI"
        '
        'TB_XML_REC_NOMBRE
        '
        Me.TB_XML_REC_NOMBRE.Enabled = False
        Me.TB_XML_REC_NOMBRE.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_REC_NOMBRE.Location = New System.Drawing.Point(24, 168)
        Me.TB_XML_REC_NOMBRE.Name = "TB_XML_REC_NOMBRE"
        Me.TB_XML_REC_NOMBRE.Size = New System.Drawing.Size(304, 22)
        Me.TB_XML_REC_NOMBRE.TabIndex = 214
        Me.TB_XML_REC_NOMBRE.Tag = ""
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(27, 152)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(122, 13)
        Me.Label27.TabIndex = 213
        Me.Label27.Text = "Nombre del RECEPTOR"
        '
        'TB_XML_EMI_REGIMENFISCAL
        '
        Me.TB_XML_EMI_REGIMENFISCAL.AccessibleDescription = ""
        Me.TB_XML_EMI_REGIMENFISCAL.Enabled = False
        Me.TB_XML_EMI_REGIMENFISCAL.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_EMI_REGIMENFISCAL.Location = New System.Drawing.Point(654, 127)
        Me.TB_XML_EMI_REGIMENFISCAL.Name = "TB_XML_EMI_REGIMENFISCAL"
        Me.TB_XML_EMI_REGIMENFISCAL.Size = New System.Drawing.Size(314, 22)
        Me.TB_XML_EMI_REGIMENFISCAL.TabIndex = 212
        Me.TB_XML_EMI_REGIMENFISCAL.Tag = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(657, 111)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(79, 13)
        Me.Label26.TabIndex = 211
        Me.Label26.Text = "Régimen Fiscal"
        '
        'TB_XML_EMI_NOMBRE
        '
        Me.TB_XML_EMI_NOMBRE.Enabled = False
        Me.TB_XML_EMI_NOMBRE.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_EMI_NOMBRE.Location = New System.Drawing.Point(24, 127)
        Me.TB_XML_EMI_NOMBRE.Name = "TB_XML_EMI_NOMBRE"
        Me.TB_XML_EMI_NOMBRE.Size = New System.Drawing.Size(304, 22)
        Me.TB_XML_EMI_NOMBRE.TabIndex = 210
        Me.TB_XML_EMI_NOMBRE.Tag = ""
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(28, 111)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(111, 13)
        Me.Label25.TabIndex = 209
        Me.Label25.Text = "Nombre del EMISOR"
        '
        'TB_XML_VERSION
        '
        Me.TB_XML_VERSION.AccessibleDescription = ""
        Me.TB_XML_VERSION.Enabled = False
        Me.TB_XML_VERSION.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_VERSION.Location = New System.Drawing.Point(866, 39)
        Me.TB_XML_VERSION.Name = "TB_XML_VERSION"
        Me.TB_XML_VERSION.Size = New System.Drawing.Size(102, 22)
        Me.TB_XML_VERSION.TabIndex = 208
        Me.TB_XML_VERSION.Tag = ""
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(869, 23)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(84, 13)
        Me.Label24.TabIndex = 207
        Me.Label24.Text = "Versión de CFDI"
        '
        'TB_XML_TIPODECOMPROBANTE
        '
        Me.TB_XML_TIPODECOMPROBANTE.AccessibleDescription = ""
        Me.TB_XML_TIPODECOMPROBANTE.Enabled = False
        Me.TB_XML_TIPODECOMPROBANTE.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_TIPODECOMPROBANTE.Location = New System.Drawing.Point(813, 168)
        Me.TB_XML_TIPODECOMPROBANTE.Name = "TB_XML_TIPODECOMPROBANTE"
        Me.TB_XML_TIPODECOMPROBANTE.Size = New System.Drawing.Size(155, 22)
        Me.TB_XML_TIPODECOMPROBANTE.TabIndex = 206
        Me.TB_XML_TIPODECOMPROBANTE.Tag = ""
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(817, 152)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(94, 13)
        Me.Label23.TabIndex = 205
        Me.Label23.Text = "Tipo Comprobante"
        '
        'TB_XML_TIPOCAMBIO
        '
        Me.TB_XML_TIPOCAMBIO.AccessibleDescription = ""
        Me.TB_XML_TIPOCAMBIO.Enabled = False
        Me.TB_XML_TIPOCAMBIO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_TIPOCAMBIO.Location = New System.Drawing.Point(334, 211)
        Me.TB_XML_TIPOCAMBIO.Name = "TB_XML_TIPOCAMBIO"
        Me.TB_XML_TIPOCAMBIO.Size = New System.Drawing.Size(167, 22)
        Me.TB_XML_TIPOCAMBIO.TabIndex = 204
        Me.TB_XML_TIPOCAMBIO.Tag = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(337, 195)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 13)
        Me.Label22.TabIndex = 203
        Me.Label22.Text = "Tipo Cambio"
        '
        'TB_XML_NOCERTIFICADO
        '
        Me.TB_XML_NOCERTIFICADO.AccessibleDescription = ""
        Me.TB_XML_NOCERTIFICADO.Enabled = False
        Me.TB_XML_NOCERTIFICADO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_NOCERTIFICADO.Location = New System.Drawing.Point(334, 85)
        Me.TB_XML_NOCERTIFICADO.Name = "TB_XML_NOCERTIFICADO"
        Me.TB_XML_NOCERTIFICADO.Size = New System.Drawing.Size(314, 22)
        Me.TB_XML_NOCERTIFICADO.TabIndex = 202
        Me.TB_XML_NOCERTIFICADO.Tag = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(337, 69)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 13)
        Me.Label21.TabIndex = 201
        Me.Label21.Text = "Número de Certificado"
        '
        'TB_XML_MONEDA
        '
        Me.TB_XML_MONEDA.AccessibleDescription = ""
        Me.TB_XML_MONEDA.Enabled = False
        Me.TB_XML_MONEDA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_MONEDA.Location = New System.Drawing.Point(813, 211)
        Me.TB_XML_MONEDA.Name = "TB_XML_MONEDA"
        Me.TB_XML_MONEDA.Size = New System.Drawing.Size(155, 22)
        Me.TB_XML_MONEDA.TabIndex = 200
        Me.TB_XML_MONEDA.Tag = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(816, 196)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 199
        Me.Label15.Text = "Moneda"
        '
        'TB_XML_LUGAREXPEDICION
        '
        Me.TB_XML_LUGAREXPEDICION.Enabled = False
        Me.TB_XML_LUGAREXPEDICION.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_LUGAREXPEDICION.Location = New System.Drawing.Point(24, 211)
        Me.TB_XML_LUGAREXPEDICION.Name = "TB_XML_LUGAREXPEDICION"
        Me.TB_XML_LUGAREXPEDICION.Size = New System.Drawing.Size(304, 22)
        Me.TB_XML_LUGAREXPEDICION.TabIndex = 198
        Me.TB_XML_LUGAREXPEDICION.Tag = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(27, 195)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 13)
        Me.Label14.TabIndex = 197
        Me.Label14.Text = "Lugar de Expedición"
        '
        'TB_XML_METODOPAGO
        '
        Me.TB_XML_METODOPAGO.AccessibleDescription = ""
        Me.TB_XML_METODOPAGO.Enabled = False
        Me.TB_XML_METODOPAGO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_METODOPAGO.Location = New System.Drawing.Point(174, 253)
        Me.TB_XML_METODOPAGO.Name = "TB_XML_METODOPAGO"
        Me.TB_XML_METODOPAGO.Size = New System.Drawing.Size(154, 22)
        Me.TB_XML_METODOPAGO.TabIndex = 196
        Me.TB_XML_METODOPAGO.Tag = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(177, 238)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 13)
        Me.Label13.TabIndex = 195
        Me.Label13.Text = "Método de Pago"
        '
        'TB_XML_FORMAPAGO
        '
        Me.TB_XML_FORMAPAGO.AccessibleDescription = ""
        Me.TB_XML_FORMAPAGO.Enabled = False
        Me.TB_XML_FORMAPAGO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_FORMAPAGO.Location = New System.Drawing.Point(24, 253)
        Me.TB_XML_FORMAPAGO.Name = "TB_XML_FORMAPAGO"
        Me.TB_XML_FORMAPAGO.Size = New System.Drawing.Size(144, 22)
        Me.TB_XML_FORMAPAGO.TabIndex = 193
        Me.TB_XML_FORMAPAGO.Tag = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 238)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 192
        Me.Label10.Text = "Forma de Pago"
        '
        'TB_XML_REC_RFC
        '
        Me.TB_XML_REC_RFC.AccessibleDescription = ""
        Me.TB_XML_REC_RFC.Enabled = False
        Me.TB_XML_REC_RFC.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_REC_RFC.Location = New System.Drawing.Point(334, 168)
        Me.TB_XML_REC_RFC.Name = "TB_XML_REC_RFC"
        Me.TB_XML_REC_RFC.Size = New System.Drawing.Size(314, 22)
        Me.TB_XML_REC_RFC.TabIndex = 191
        Me.TB_XML_REC_RFC.Tag = ""
        '
        'TB_XML_EMI_RFC
        '
        Me.TB_XML_EMI_RFC.AccessibleDescription = ""
        Me.TB_XML_EMI_RFC.Enabled = False
        Me.TB_XML_EMI_RFC.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_EMI_RFC.Location = New System.Drawing.Point(334, 127)
        Me.TB_XML_EMI_RFC.Name = "TB_XML_EMI_RFC"
        Me.TB_XML_EMI_RFC.Size = New System.Drawing.Size(314, 22)
        Me.TB_XML_EMI_RFC.TabIndex = 190
        Me.TB_XML_EMI_RFC.Tag = ""
        '
        'TB_XML_FECHA
        '
        Me.TB_XML_FECHA.Enabled = False
        Me.TB_XML_FECHA.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TB_XML_FECHA.Location = New System.Drawing.Point(654, 39)
        Me.TB_XML_FECHA.Mask = "00/00/0000"
        Me.TB_XML_FECHA.Name = "TB_XML_FECHA"
        Me.TB_XML_FECHA.Size = New System.Drawing.Size(100, 22)
        Me.TB_XML_FECHA.TabIndex = 189
        Me.TB_XML_FECHA.Tag = ""
        Me.TB_XML_FECHA.ValidatingType = GetType(Date)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(657, 23)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 13)
        Me.Label18.TabIndex = 188
        Me.Label18.Text = "Fecha Emisión"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(337, 152)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 13)
        Me.Label16.TabIndex = 186
        Me.Label16.Text = "RFC del Receptor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(337, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 184
        Me.Label3.Text = "RFC del Emisor"
        '
        'TB_XML_TOTAL
        '
        Me.TB_XML_TOTAL.Enabled = False
        Me.TB_XML_TOTAL.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_TOTAL.Location = New System.Drawing.Point(813, 307)
        Me.TB_XML_TOTAL.Name = "TB_XML_TOTAL"
        Me.TB_XML_TOTAL.Size = New System.Drawing.Size(155, 22)
        Me.TB_XML_TOTAL.TabIndex = 153
        Me.TB_XML_TOTAL.Tag = ""
        '
        'TB_C_FACTURA_CXP_XML
        '
        Me.TB_C_FACTURA_CXP_XML.Enabled = False
        Me.TB_C_FACTURA_CXP_XML.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_C_FACTURA_CXP_XML.Location = New System.Drawing.Point(24, 39)
        Me.TB_C_FACTURA_CXP_XML.Name = "TB_C_FACTURA_CXP_XML"
        Me.TB_C_FACTURA_CXP_XML.Size = New System.Drawing.Size(304, 22)
        Me.TB_C_FACTURA_CXP_XML.TabIndex = 152
        Me.TB_C_FACTURA_CXP_XML.Tag = ""
        '
        'TB_XML_SUBTOTAL
        '
        Me.TB_XML_SUBTOTAL.AccessibleDescription = ""
        Me.TB_XML_SUBTOTAL.Enabled = False
        Me.TB_XML_SUBTOTAL.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_SUBTOTAL.Location = New System.Drawing.Point(813, 253)
        Me.TB_XML_SUBTOTAL.Name = "TB_XML_SUBTOTAL"
        Me.TB_XML_SUBTOTAL.Size = New System.Drawing.Size(155, 22)
        Me.TB_XML_SUBTOTAL.TabIndex = 150
        Me.TB_XML_SUBTOTAL.Tag = ""
        '
        'TB_XML_FOLIO
        '
        Me.TB_XML_FOLIO.AccessibleDescription = ""
        Me.TB_XML_FOLIO.Enabled = False
        Me.TB_XML_FOLIO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_FOLIO.Location = New System.Drawing.Point(149, 85)
        Me.TB_XML_FOLIO.Name = "TB_XML_FOLIO"
        Me.TB_XML_FOLIO.Size = New System.Drawing.Size(179, 22)
        Me.TB_XML_FOLIO.TabIndex = 149
        Me.TB_XML_FOLIO.Tag = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(152, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 148
        Me.Label4.Text = "Folio"
        '
        'TB_XML_SERIE
        '
        Me.TB_XML_SERIE.AccessibleDescription = ""
        Me.TB_XML_SERIE.Enabled = False
        Me.TB_XML_SERIE.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XML_SERIE.Location = New System.Drawing.Point(24, 85)
        Me.TB_XML_SERIE.Name = "TB_XML_SERIE"
        Me.TB_XML_SERIE.Size = New System.Drawing.Size(119, 22)
        Me.TB_XML_SERIE.TabIndex = 147
        Me.TB_XML_SERIE.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 146
        Me.Label8.Text = "Serie"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(780, 310)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(31, 13)
        Me.Label19.TabIndex = 109
        Me.Label19.Text = "Total"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(765, 259)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 13)
        Me.Label17.TabIndex = 106
        Me.Label17.Text = "Subtotal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Nombre del Archivo"
        '
        'GB_OPERACION
        '
        Me.GB_OPERACION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_OPERACION.BackColor = System.Drawing.Color.White
        Me.GB_OPERACION.Controls.Add(Me.LB_RESULTADO)
        Me.GB_OPERACION.Controls.Add(Me.LB_PRO_KO)
        Me.GB_OPERACION.Controls.Add(Me.LB_PRE_KO)
        Me.GB_OPERACION.Controls.Add(Me.LB_PRE_OK)
        Me.GB_OPERACION.Controls.Add(Me.LB_EXISTENTE)
        Me.GB_OPERACION.Controls.Add(Me.LB_PRE)
        Me.GB_OPERACION.Controls.Add(Me.LB_KO)
        Me.GB_OPERACION.Controls.Add(Me.LB_OK)
        Me.GB_OPERACION.Controls.Add(Me.LB_PROCESADOS)
        Me.GB_OPERACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_OPERACION.Location = New System.Drawing.Point(2, 552)
        Me.GB_OPERACION.Name = "GB_OPERACION"
        Me.GB_OPERACION.Size = New System.Drawing.Size(691, 70)
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
        Me.LB_RESULTADO.Location = New System.Drawing.Point(9, 22)
        Me.LB_RESULTADO.Multiline = True
        Me.LB_RESULTADO.Name = "LB_RESULTADO"
        Me.LB_RESULTADO.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.LB_RESULTADO.Size = New System.Drawing.Size(676, 42)
        Me.LB_RESULTADO.TabIndex = 10
        Me.LB_RESULTADO.Visible = False
        '
        'LB_PRO_KO
        '
        Me.LB_PRO_KO.Enabled = False
        Me.LB_PRO_KO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_PRO_KO.Location = New System.Drawing.Point(639, 41)
        Me.LB_PRO_KO.Name = "LB_PRO_KO"
        Me.LB_PRO_KO.Size = New System.Drawing.Size(228, 24)
        Me.LB_PRO_KO.TabIndex = 9
        Me.LB_PRO_KO.Text = "."
        Me.LB_PRO_KO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LB_PRE_KO
        '
        Me.LB_PRE_KO.Enabled = False
        Me.LB_PRE_KO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_PRE_KO.Location = New System.Drawing.Point(446, 41)
        Me.LB_PRE_KO.Name = "LB_PRE_KO"
        Me.LB_PRE_KO.Size = New System.Drawing.Size(186, 24)
        Me.LB_PRE_KO.TabIndex = 8
        Me.LB_PRE_KO.Text = "."
        Me.LB_PRE_KO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LB_PRE_OK
        '
        Me.LB_PRE_OK.Enabled = False
        Me.LB_PRE_OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_PRE_OK.Location = New System.Drawing.Point(210, 41)
        Me.LB_PRE_OK.Name = "LB_PRE_OK"
        Me.LB_PRE_OK.Size = New System.Drawing.Size(230, 24)
        Me.LB_PRE_OK.TabIndex = 7
        Me.LB_PRE_OK.Text = "."
        Me.LB_PRE_OK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LB_EXISTENTE
        '
        Me.LB_EXISTENTE.Enabled = False
        Me.LB_EXISTENTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_EXISTENTE.Location = New System.Drawing.Point(510, 16)
        Me.LB_EXISTENTE.Name = "LB_EXISTENTE"
        Me.LB_EXISTENTE.Size = New System.Drawing.Size(247, 24)
        Me.LB_EXISTENTE.TabIndex = 6
        Me.LB_EXISTENTE.Text = "."
        Me.LB_EXISTENTE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LB_PRE
        '
        Me.LB_PRE.Enabled = False
        Me.LB_PRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_PRE.Location = New System.Drawing.Point(9, 41)
        Me.LB_PRE.Name = "LB_PRE"
        Me.LB_PRE.Size = New System.Drawing.Size(195, 24)
        Me.LB_PRE.TabIndex = 5
        Me.LB_PRE.Text = "."
        Me.LB_PRE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LB_KO
        '
        Me.LB_KO.Enabled = False
        Me.LB_KO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_KO.Location = New System.Drawing.Point(718, 17)
        Me.LB_KO.Name = "LB_KO"
        Me.LB_KO.Size = New System.Drawing.Size(143, 24)
        Me.LB_KO.TabIndex = 4
        Me.LB_KO.Text = "."
        Me.LB_KO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LB_OK
        '
        Me.LB_OK.Enabled = False
        Me.LB_OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_OK.Location = New System.Drawing.Point(233, 16)
        Me.LB_OK.Name = "LB_OK"
        Me.LB_OK.Size = New System.Drawing.Size(270, 24)
        Me.LB_OK.TabIndex = 3
        Me.LB_OK.Text = "."
        Me.LB_OK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LB_PROCESADOS
        '
        Me.LB_PROCESADOS.Enabled = False
        Me.LB_PROCESADOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_PROCESADOS.Location = New System.Drawing.Point(6, 16)
        Me.LB_PROCESADOS.Name = "LB_PROCESADOS"
        Me.LB_PROCESADOS.Size = New System.Drawing.Size(221, 24)
        Me.LB_PROCESADOS.TabIndex = 2
        Me.LB_PROCESADOS.Text = "No se han procesado Archivos"
        Me.LB_PROCESADOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GB_CONTROL
        '
        Me.GB_CONTROL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_CONTROL.BackColor = System.Drawing.Color.White
        Me.GB_CONTROL.Controls.Add(Me.LB_VERSION)
        Me.GB_CONTROL.Controls.Add(Me.LB_RELOJ)
        Me.GB_CONTROL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_CONTROL.Location = New System.Drawing.Point(695, 552)
        Me.GB_CONTROL.Name = "GB_CONTROL"
        Me.GB_CONTROL.Size = New System.Drawing.Size(463, 70)
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
        'TI_RELOJ
        '
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SplitContainer1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RT_EVENTOS, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 88)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1156, 460)
        Me.TableLayoutPanel1.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 15)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Directorio de Carpetas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(165, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 15)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Explorador de Archivos [XML]"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(469, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 15)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Mensajes de Resultados"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LL_COPIAR_A_TXT
        '
        Me.LL_COPIAR_A_TXT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LL_COPIAR_A_TXT.AutoSize = True
        Me.LL_COPIAR_A_TXT.Location = New System.Drawing.Point(1055, 72)
        Me.LL_COPIAR_A_TXT.Name = "LL_COPIAR_A_TXT"
        Me.LL_COPIAR_A_TXT.Size = New System.Drawing.Size(82, 13)
        Me.LL_COPIAR_A_TXT.TabIndex = 58
        Me.LL_COPIAR_A_TXT.TabStop = True
        Me.LL_COPIAR_A_TXT.Text = "<Copiar a TXT>"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(752, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(235, 13)
        Me.Label6.TabIndex = 233
        Me.Label6.Text = "______________________________________"
        '
        'BT_SELECCIONAR_TODOS
        '
        Me.BT_SELECCIONAR_TODOS.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BT_SELECCIONAR_TODOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_SELECCIONAR_TODOS.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_SELECCIONAR_TODOS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_SELECCIONAR_TODOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_SELECCIONAR_TODOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_SELECCIONAR_TODOS.Image = CType(resources.GetObject("BT_SELECCIONAR_TODOS.Image"), System.Drawing.Image)
        Me.BT_SELECCIONAR_TODOS.Location = New System.Drawing.Point(829, 19)
        Me.BT_SELECCIONAR_TODOS.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_SELECCIONAR_TODOS.Name = "BT_SELECCIONAR_TODOS"
        Me.BT_SELECCIONAR_TODOS.Size = New System.Drawing.Size(70, 36)
        Me.BT_SELECCIONAR_TODOS.TabIndex = 26
        Me.BT_SELECCIONAR_TODOS.Tag = "Seleccionar Todos"
        Me.BT_SELECCIONAR_TODOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_SELECCIONAR_TODOS.UseVisualStyleBackColor = True
        '
        'BT_CANCELAR
        '
        Me.BT_CANCELAR.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BT_CANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_CANCELAR.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BT_CANCELAR.Enabled = False
        Me.BT_CANCELAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_CANCELAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_CANCELAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_CANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_CANCELAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_cancel
        Me.BT_CANCELAR.Location = New System.Drawing.Point(975, 19)
        Me.BT_CANCELAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_CANCELAR.Name = "BT_CANCELAR"
        Me.BT_CANCELAR.Size = New System.Drawing.Size(70, 36)
        Me.BT_CANCELAR.TabIndex = 25
        Me.BT_CANCELAR.UseVisualStyleBackColor = True
        '
        'BT_SALIR
        '
        Me.BT_SALIR.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BT_SALIR.BackgroundImage = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_exit
        Me.BT_SALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_SALIR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_SALIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_SALIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_SALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_SALIR.Location = New System.Drawing.Point(1070, 19)
        Me.BT_SALIR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_SALIR.Name = "BT_SALIR"
        Me.BT_SALIR.Size = New System.Drawing.Size(70, 36)
        Me.BT_SALIR.TabIndex = 24
        Me.BT_SALIR.UseVisualStyleBackColor = True
        '
        'BT_CARGAR_XML
        '
        Me.BT_CARGAR_XML.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BT_CARGAR_XML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_CARGAR_XML.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_CARGAR_XML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_CARGAR_XML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_CARGAR_XML.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_CARGAR_XML.Image = CType(resources.GetObject("BT_CARGAR_XML.Image"), System.Drawing.Image)
        Me.BT_CARGAR_XML.Location = New System.Drawing.Point(901, 19)
        Me.BT_CARGAR_XML.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_CARGAR_XML.Name = "BT_CARGAR_XML"
        Me.BT_CARGAR_XML.Size = New System.Drawing.Size(70, 36)
        Me.BT_CARGAR_XML.TabIndex = 10
        Me.BT_CARGAR_XML.Tag = "Cargar XML"
        Me.BT_CARGAR_XML.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_CARGAR_XML.UseVisualStyleBackColor = True
        '
        'BT_VERIFICAR_XML
        '
        Me.BT_VERIFICAR_XML.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BT_VERIFICAR_XML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_VERIFICAR_XML.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_VERIFICAR_XML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_VERIFICAR_XML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_VERIFICAR_XML.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_VERIFICAR_XML.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.phpT5WEEo_opt
        Me.BT_VERIFICAR_XML.Location = New System.Drawing.Point(749, 19)
        Me.BT_VERIFICAR_XML.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_VERIFICAR_XML.Name = "BT_VERIFICAR_XML"
        Me.BT_VERIFICAR_XML.Size = New System.Drawing.Size(70, 36)
        Me.BT_VERIFICAR_XML.TabIndex = 9
        Me.BT_VERIFICAR_XML.Tag = "Vista Previa"
        Me.BT_VERIFICAR_XML.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_VERIFICAR_XML.UseVisualStyleBackColor = True
        '
        'FO_FACTURA_CXP_XML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 625)
        Me.Controls.Add(Me.LL_COPIAR_A_TXT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GB_FICHA)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.GB_OPERACION)
        Me.Controls.Add(Me.GB_CONTROL)
        Me.Controls.Add(Me.FL_MENU)
        Me.Name = "FO_FACTURA_CXP_XML"
        Me.Text = "CARGA XML DE FACTURAS  DE CUENTAS POR PAGAR"
        Me.FL_MENU.ResumeLayout(False)
        CType(Me.EL_REGISTROS_XML, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GB_FICHA.ResumeLayout(False)
        Me.GB_FICHA.PerformLayout()
        Me.GB_OPERACION.ResumeLayout(False)
        Me.GB_OPERACION.PerformLayout()
        Me.GB_CONTROL.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents FL_MENU As GroupBox
    Public WithEvents BT_VERIFICAR_XML As Button
    Friend WithEvents FB_DIALOG As FolderBrowserDialog
    Friend WithEvents EL_REGISTROS_XML As EventLog
    Public WithEvents BT_CARGAR_XML As Button
    Friend WithEvents OF_DIALOG As OpenFileDialog
    Friend WithEvents SplitContainer1 As SplitContainer
    Public WithEvents TV_DIR As TreeView
    Public WithEvents RT_EVENTOS As RichTextBox
    Public WithEvents ImageList1 As ImageList
    Friend WithEvents Nombre As ColumnHeader
    Public WithEvents LV_DIR As ListView
    Public WithEvents BT_SALIR As Button
    Public WithEvents GB_FICHA As GroupBox
    Public WithEvents TB_XML_UUID As TextBox
    Friend WithEvents Label34 As Label
    Public WithEvents TB_XML_NOCERTIFICADOSAT As TextBox
    Friend WithEvents Label33 As Label
    Public WithEvents TB_XML_FECHATIMBRADO As MaskedTextBox
    Friend WithEvents Label12 As Label
    Public WithEvents TB_XML_TIPOFACTOR As TextBox
    Friend WithEvents Label11 As Label
    Public WithEvents TB_XML_TASAOCUOTA As TextBox
    Friend WithEvents Label32 As Label
    Public WithEvents TB_XML_IMPUESTO As TextBox
    Friend WithEvents Label31 As Label
    Public WithEvents TB_XML_IMPORTE As TextBox
    Friend WithEvents Label30 As Label
    Public WithEvents TB_XML_TOTALIMPUESTOSTRASLADADOS As TextBox
    Friend WithEvents Label29 As Label
    Public WithEvents TB_XML_REC_USOCFDI As TextBox
    Friend WithEvents Label28 As Label
    Public WithEvents TB_XML_REC_NOMBRE As TextBox
    Friend WithEvents Label27 As Label
    Public WithEvents TB_XML_EMI_REGIMENFISCAL As TextBox
    Friend WithEvents Label26 As Label
    Public WithEvents TB_XML_EMI_NOMBRE As TextBox
    Friend WithEvents Label25 As Label
    Public WithEvents TB_XML_VERSION As TextBox
    Friend WithEvents Label24 As Label
    Public WithEvents TB_XML_TIPODECOMPROBANTE As TextBox
    Friend WithEvents Label23 As Label
    Public WithEvents TB_XML_TIPOCAMBIO As TextBox
    Friend WithEvents Label22 As Label
    Public WithEvents TB_XML_NOCERTIFICADO As TextBox
    Friend WithEvents Label21 As Label
    Public WithEvents TB_XML_MONEDA As TextBox
    Friend WithEvents Label15 As Label
    Public WithEvents TB_XML_LUGAREXPEDICION As TextBox
    Friend WithEvents Label14 As Label
    Public WithEvents TB_XML_METODOPAGO As TextBox
    Friend WithEvents Label13 As Label
    Public WithEvents TB_XML_FORMAPAGO As TextBox
    Friend WithEvents Label10 As Label
    Public WithEvents TB_XML_REC_RFC As TextBox
    Public WithEvents TB_XML_EMI_RFC As TextBox
    Public WithEvents TB_XML_FECHA As MaskedTextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label3 As Label
    Public WithEvents TB_XML_TOTAL As TextBox
    Public WithEvents TB_C_FACTURA_CXP_XML As TextBox
    Public WithEvents TB_XML_SUBTOTAL As TextBox
    Public WithEvents TB_XML_FOLIO As TextBox
    Friend WithEvents Label4 As Label
    Public WithEvents TB_XML_SERIE As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label7 As Label
    Public WithEvents BT_CANCELAR As Button
    Public WithEvents BT_SELECCIONAR_TODOS As Button
    Friend WithEvents GB_CONTROL As GroupBox
    Public WithEvents LB_VERSION As Label
    Public WithEvents LB_RELOJ As Label
    Public WithEvents TI_RELOJ As Timer
    Public WithEvents LB_PROCESADOS As Label
    Public WithEvents LB_OK As Label
    Public WithEvents LB_KO As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Public WithEvents Label5 As Label
    Public WithEvents Label2 As Label
    Public WithEvents Label1 As Label
    Public WithEvents LB_PRE_KO As Label
    Public WithEvents LB_PRE_OK As Label
    Public WithEvents LB_EXISTENTE As Label
    Public WithEvents LB_PRE As Label
    Public WithEvents LB_PRO_KO As Label
    Public WithEvents LB_RESULTADO As TextBox
    Public WithEvents GB_OPERACION As GroupBox
    Public WithEvents LB_NOMBRE_CARPETA As Label
    Public WithEvents LB_CONTEO_ARCHIVOS As Label
    Friend WithEvents LL_COPIAR_A_TXT As LinkLabel
    Friend WithEvents Label6 As Label
End Class
