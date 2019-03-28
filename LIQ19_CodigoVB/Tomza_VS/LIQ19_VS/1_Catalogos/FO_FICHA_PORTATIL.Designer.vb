<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FO_FICHA_PORTATIL
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GB_FICHA = New System.Windows.Forms.GroupBox()
        Me.TB_K_PUNTO_VENTA = New System.Windows.Forms.TextBox()
        Me.TB_K_PDV = New System.Windows.Forms.TextBox()
        Me.GB_AUTOTANQUE = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_CAPACIDAD = New System.Windows.Forms.TextBox()
        Me.CB_MARCA = New System.Windows.Forms.ComboBox()
        Me.TB_KILOMETRAJE = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TB_SERIE = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_MODELO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_MATRICULA = New System.Windows.Forms.TextBox()
        Me.CB_AYUDANTE_2 = New System.Windows.Forms.ComboBox()
        Me.CB_TIPO_PUNTO_VENTA = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CB_ESTATUS_PUNTO_VENTA = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CB_AYUDANTE_1 = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.CB_OPERADOR = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TB_D_PUNTO_VENTA = New System.Windows.Forms.TextBox()
        Me.CB_USUARIO_CAMBIO = New System.Windows.Forms.ComboBox()
        Me.CB_USUARIO_ALTA = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_F_ALTA = New System.Windows.Forms.TextBox()
        Me.TB_F_CAMBIO = New System.Windows.Forms.TextBox()
        Me.CB_UNIDAD_OPERATIVA = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LB_ID = New System.Windows.Forms.Label()
        Me.FL_MENU_2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_SALIR = New System.Windows.Forms.Button()
        Me.BT_CANCELAR = New System.Windows.Forms.Button()
        Me.BT_GUARDAR = New System.Windows.Forms.Button()
        Me.BT_LISTADO = New System.Windows.Forms.Button()
        Me.BT_EXPORTAR_EXCEL = New System.Windows.Forms.Button()
        Me.GB_FILTROS = New System.Windows.Forms.GroupBox()
        Me.CB_LI_UNIDAD_OPERATIVA = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CB_LI_TIPO_PUNTO_VENTA = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.CB_LI_ESTATUS_PUNTO_VENTA = New System.Windows.Forms.ComboBox()
        Me.BT_LI_BUSCAR = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
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
        Me.TI_RELOJ = New System.Windows.Forms.Timer(Me.components)
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CB_LI_RAZON_SOCIAL = New System.Windows.Forms.ComboBox()
        Me.CB_LI_ZONA_UO = New System.Windows.Forms.ComboBox()
        Me.GB_FICHA.SuspendLayout()
        Me.GB_AUTOTANQUE.SuspendLayout()
        Me.FL_MENU_2.SuspendLayout()
        Me.GB_FILTROS.SuspendLayout()
        Me.GB_LISTADO.SuspendLayout()
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_OPERACION.SuspendLayout()
        Me.GB_CONTROL.SuspendLayout()
        Me.FL_MENU_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_FICHA
        '
        Me.GB_FICHA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GB_FICHA.BackColor = System.Drawing.Color.White
        Me.GB_FICHA.Controls.Add(Me.TB_K_PUNTO_VENTA)
        Me.GB_FICHA.Controls.Add(Me.TB_K_PDV)
        Me.GB_FICHA.Controls.Add(Me.GB_AUTOTANQUE)
        Me.GB_FICHA.Controls.Add(Me.CB_AYUDANTE_2)
        Me.GB_FICHA.Controls.Add(Me.CB_TIPO_PUNTO_VENTA)
        Me.GB_FICHA.Controls.Add(Me.Label14)
        Me.GB_FICHA.Controls.Add(Me.CB_ESTATUS_PUNTO_VENTA)
        Me.GB_FICHA.Controls.Add(Me.Label12)
        Me.GB_FICHA.Controls.Add(Me.CB_AYUDANTE_1)
        Me.GB_FICHA.Controls.Add(Me.Label32)
        Me.GB_FICHA.Controls.Add(Me.CB_OPERADOR)
        Me.GB_FICHA.Controls.Add(Me.Label31)
        Me.GB_FICHA.Controls.Add(Me.Label30)
        Me.GB_FICHA.Controls.Add(Me.TB_D_PUNTO_VENTA)
        Me.GB_FICHA.Controls.Add(Me.CB_USUARIO_CAMBIO)
        Me.GB_FICHA.Controls.Add(Me.CB_USUARIO_ALTA)
        Me.GB_FICHA.Controls.Add(Me.Label5)
        Me.GB_FICHA.Controls.Add(Me.Label9)
        Me.GB_FICHA.Controls.Add(Me.Label6)
        Me.GB_FICHA.Controls.Add(Me.Label2)
        Me.GB_FICHA.Controls.Add(Me.TB_F_ALTA)
        Me.GB_FICHA.Controls.Add(Me.TB_F_CAMBIO)
        Me.GB_FICHA.Controls.Add(Me.CB_UNIDAD_OPERATIVA)
        Me.GB_FICHA.Controls.Add(Me.Label11)
        Me.GB_FICHA.Controls.Add(Me.LB_ID)
        Me.GB_FICHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FICHA.Location = New System.Drawing.Point(237, 136)
        Me.GB_FICHA.Name = "GB_FICHA"
        Me.GB_FICHA.Size = New System.Drawing.Size(583, 332)
        Me.GB_FICHA.TabIndex = 63
        Me.GB_FICHA.TabStop = False
        Me.GB_FICHA.Text = "Ficha"
        '
        'TB_K_PUNTO_VENTA
        '
        Me.TB_K_PUNTO_VENTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_K_PUNTO_VENTA.Enabled = False
        Me.TB_K_PUNTO_VENTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_K_PUNTO_VENTA.Location = New System.Drawing.Point(25, 33)
        Me.TB_K_PUNTO_VENTA.Name = "TB_K_PUNTO_VENTA"
        Me.TB_K_PUNTO_VENTA.Size = New System.Drawing.Size(50, 22)
        Me.TB_K_PUNTO_VENTA.TabIndex = 0
        '
        'TB_K_PDV
        '
        Me.TB_K_PDV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_K_PDV.Enabled = False
        Me.TB_K_PDV.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_K_PDV.Location = New System.Drawing.Point(25, 33)
        Me.TB_K_PDV.Name = "TB_K_PDV"
        Me.TB_K_PDV.Size = New System.Drawing.Size(31, 22)
        Me.TB_K_PDV.TabIndex = 257
        Me.TB_K_PDV.Visible = False
        '
        'GB_AUTOTANQUE
        '
        Me.GB_AUTOTANQUE.Controls.Add(Me.Label8)
        Me.GB_AUTOTANQUE.Controls.Add(Me.TB_CAPACIDAD)
        Me.GB_AUTOTANQUE.Controls.Add(Me.CB_MARCA)
        Me.GB_AUTOTANQUE.Controls.Add(Me.TB_KILOMETRAJE)
        Me.GB_AUTOTANQUE.Controls.Add(Me.Label16)
        Me.GB_AUTOTANQUE.Controls.Add(Me.TB_SERIE)
        Me.GB_AUTOTANQUE.Controls.Add(Me.Label17)
        Me.GB_AUTOTANQUE.Controls.Add(Me.Label7)
        Me.GB_AUTOTANQUE.Controls.Add(Me.TB_MODELO)
        Me.GB_AUTOTANQUE.Controls.Add(Me.Label4)
        Me.GB_AUTOTANQUE.Controls.Add(Me.Label3)
        Me.GB_AUTOTANQUE.Controls.Add(Me.TB_MATRICULA)
        Me.GB_AUTOTANQUE.Location = New System.Drawing.Point(25, 108)
        Me.GB_AUTOTANQUE.Name = "GB_AUTOTANQUE"
        Me.GB_AUTOTANQUE.Size = New System.Drawing.Size(526, 166)
        Me.GB_AUTOTANQUE.TabIndex = 256
        Me.GB_AUTOTANQUE.TabStop = False
        Me.GB_AUTOTANQUE.Text = "Detalle Autotanque"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(357, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 280
        Me.Label8.Text = "Capacidad"
        '
        'TB_CAPACIDAD
        '
        Me.TB_CAPACIDAD.AccessibleDescription = ""
        Me.TB_CAPACIDAD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_CAPACIDAD.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CAPACIDAD.Location = New System.Drawing.Point(352, 85)
        Me.TB_CAPACIDAD.Name = "TB_CAPACIDAD"
        Me.TB_CAPACIDAD.Size = New System.Drawing.Size(158, 22)
        Me.TB_CAPACIDAD.TabIndex = 279
        Me.TB_CAPACIDAD.Tag = "1"
        '
        'CB_MARCA
        '
        Me.CB_MARCA.FormattingEnabled = True
        Me.CB_MARCA.Location = New System.Drawing.Point(178, 40)
        Me.CB_MARCA.Name = "CB_MARCA"
        Me.CB_MARCA.Size = New System.Drawing.Size(158, 21)
        Me.CB_MARCA.TabIndex = 278
        '
        'TB_KILOMETRAJE
        '
        Me.TB_KILOMETRAJE.AccessibleDescription = ""
        Me.TB_KILOMETRAJE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_KILOMETRAJE.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_KILOMETRAJE.Location = New System.Drawing.Point(6, 85)
        Me.TB_KILOMETRAJE.Name = "TB_KILOMETRAJE"
        Me.TB_KILOMETRAJE.Size = New System.Drawing.Size(158, 22)
        Me.TB_KILOMETRAJE.TabIndex = 275
        Me.TB_KILOMETRAJE.Tag = "1"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(186, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 13)
        Me.Label16.TabIndex = 274
        Me.Label16.Text = "Serie"
        '
        'TB_SERIE
        '
        Me.TB_SERIE.AccessibleDescription = ""
        Me.TB_SERIE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_SERIE.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_SERIE.Location = New System.Drawing.Point(181, 85)
        Me.TB_SERIE.Name = "TB_SERIE"
        Me.TB_SERIE.Size = New System.Drawing.Size(155, 22)
        Me.TB_SERIE.TabIndex = 273
        Me.TB_SERIE.Tag = "1"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(9, 69)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 13)
        Me.Label17.TabIndex = 272
        Me.Label17.Text = "Kilometraje"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(349, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 262
        Me.Label7.Text = "Modelo"
        '
        'TB_MODELO
        '
        Me.TB_MODELO.AccessibleDescription = ""
        Me.TB_MODELO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_MODELO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_MODELO.Location = New System.Drawing.Point(352, 39)
        Me.TB_MODELO.Name = "TB_MODELO"
        Me.TB_MODELO.Size = New System.Drawing.Size(158, 22)
        Me.TB_MODELO.TabIndex = 261
        Me.TB_MODELO.Tag = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(178, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 260
        Me.Label4.Text = "Marca"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 258
        Me.Label3.Text = "Matricula"
        '
        'TB_MATRICULA
        '
        Me.TB_MATRICULA.AccessibleDescription = ""
        Me.TB_MATRICULA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_MATRICULA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_MATRICULA.Location = New System.Drawing.Point(6, 39)
        Me.TB_MATRICULA.Name = "TB_MATRICULA"
        Me.TB_MATRICULA.Size = New System.Drawing.Size(159, 22)
        Me.TB_MATRICULA.TabIndex = 257
        Me.TB_MATRICULA.Tag = "1"
        '
        'CB_AYUDANTE_2
        '
        Me.CB_AYUDANTE_2.FormattingEnabled = True
        Me.CB_AYUDANTE_2.Location = New System.Drawing.Point(453, 76)
        Me.CB_AYUDANTE_2.Name = "CB_AYUDANTE_2"
        Me.CB_AYUDANTE_2.Size = New System.Drawing.Size(98, 21)
        Me.CB_AYUDANTE_2.TabIndex = 255
        '
        'CB_TIPO_PUNTO_VENTA
        '
        Me.CB_TIPO_PUNTO_VENTA.Enabled = False
        Me.CB_TIPO_PUNTO_VENTA.FormattingEnabled = True
        Me.CB_TIPO_PUNTO_VENTA.Location = New System.Drawing.Point(401, 33)
        Me.CB_TIPO_PUNTO_VENTA.Name = "CB_TIPO_PUNTO_VENTA"
        Me.CB_TIPO_PUNTO_VENTA.Size = New System.Drawing.Size(150, 21)
        Me.CB_TIPO_PUNTO_VENTA.TabIndex = 254
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(404, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 13)
        Me.Label14.TabIndex = 253
        Me.Label14.Text = "Tipo"
        '
        'CB_ESTATUS_PUNTO_VENTA
        '
        Me.CB_ESTATUS_PUNTO_VENTA.FormattingEnabled = True
        Me.CB_ESTATUS_PUNTO_VENTA.Location = New System.Drawing.Point(241, 33)
        Me.CB_ESTATUS_PUNTO_VENTA.Name = "CB_ESTATUS_PUNTO_VENTA"
        Me.CB_ESTATUS_PUNTO_VENTA.Size = New System.Drawing.Size(150, 21)
        Me.CB_ESTATUS_PUNTO_VENTA.TabIndex = 252
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(244, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 251
        Me.Label12.Text = "Estatus"
        '
        'CB_AYUDANTE_1
        '
        Me.CB_AYUDANTE_1.FormattingEnabled = True
        Me.CB_AYUDANTE_1.Location = New System.Drawing.Point(345, 76)
        Me.CB_AYUDANTE_1.Name = "CB_AYUDANTE_1"
        Me.CB_AYUDANTE_1.Size = New System.Drawing.Size(98, 21)
        Me.CB_AYUDANTE_1.TabIndex = 60
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(348, 62)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(57, 13)
        Me.Label32.TabIndex = 197
        Me.Label32.Text = "Ayudantes"
        '
        'CB_OPERADOR
        '
        Me.CB_OPERADOR.FormattingEnabled = True
        Me.CB_OPERADOR.Location = New System.Drawing.Point(186, 76)
        Me.CB_OPERADOR.Name = "CB_OPERADOR"
        Me.CB_OPERADOR.Size = New System.Drawing.Size(149, 21)
        Me.CB_OPERADOR.TabIndex = 50
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(189, 62)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(51, 13)
        Me.Label31.TabIndex = 195
        Me.Label31.Text = "Operador"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(82, 17)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(67, 13)
        Me.Label30.TabIndex = 191
        Me.Label30.Text = "Descripción"
        '
        'TB_D_PUNTO_VENTA
        '
        Me.TB_D_PUNTO_VENTA.AccessibleDescription = ""
        Me.TB_D_PUNTO_VENTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_D_PUNTO_VENTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_D_PUNTO_VENTA.Location = New System.Drawing.Point(85, 33)
        Me.TB_D_PUNTO_VENTA.Name = "TB_D_PUNTO_VENTA"
        Me.TB_D_PUNTO_VENTA.Size = New System.Drawing.Size(150, 22)
        Me.TB_D_PUNTO_VENTA.TabIndex = 1
        Me.TB_D_PUNTO_VENTA.Tag = "1"
        '
        'CB_USUARIO_CAMBIO
        '
        Me.CB_USUARIO_CAMBIO.Enabled = False
        Me.CB_USUARIO_CAMBIO.FormattingEnabled = True
        Me.CB_USUARIO_CAMBIO.Location = New System.Drawing.Point(283, 299)
        Me.CB_USUARIO_CAMBIO.Name = "CB_USUARIO_CAMBIO"
        Me.CB_USUARIO_CAMBIO.Size = New System.Drawing.Size(149, 21)
        Me.CB_USUARIO_CAMBIO.TabIndex = 41
        '
        'CB_USUARIO_ALTA
        '
        Me.CB_USUARIO_ALTA.Enabled = False
        Me.CB_USUARIO_ALTA.FormattingEnabled = True
        Me.CB_USUARIO_ALTA.Location = New System.Drawing.Point(25, 299)
        Me.CB_USUARIO_ALTA.Name = "CB_USUARIO_ALTA"
        Me.CB_USUARIO_ALTA.Size = New System.Drawing.Size(123, 21)
        Me.CB_USUARIO_ALTA.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(154, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Fecha Alta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(442, 282)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Ultima modificación"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(274, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Usuario de Ultima Modificación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 284)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Usuario Alta"
        '
        'TB_F_ALTA
        '
        Me.TB_F_ALTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_F_ALTA.Enabled = False
        Me.TB_F_ALTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_F_ALTA.Location = New System.Drawing.Point(154, 298)
        Me.TB_F_ALTA.Name = "TB_F_ALTA"
        Me.TB_F_ALTA.Size = New System.Drawing.Size(123, 22)
        Me.TB_F_ALTA.TabIndex = 34
        '
        'TB_F_CAMBIO
        '
        Me.TB_F_CAMBIO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_F_CAMBIO.Enabled = False
        Me.TB_F_CAMBIO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_F_CAMBIO.Location = New System.Drawing.Point(439, 298)
        Me.TB_F_CAMBIO.Name = "TB_F_CAMBIO"
        Me.TB_F_CAMBIO.Size = New System.Drawing.Size(123, 22)
        Me.TB_F_CAMBIO.TabIndex = 35
        '
        'CB_UNIDAD_OPERATIVA
        '
        Me.CB_UNIDAD_OPERATIVA.FormattingEnabled = True
        Me.CB_UNIDAD_OPERATIVA.Location = New System.Drawing.Point(25, 76)
        Me.CB_UNIDAD_OPERATIVA.Name = "CB_UNIDAD_OPERATIVA"
        Me.CB_UNIDAD_OPERATIVA.Size = New System.Drawing.Size(150, 21)
        Me.CB_UNIDAD_OPERATIVA.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(28, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Unidad Operativa"
        '
        'LB_ID
        '
        Me.LB_ID.AutoSize = True
        Me.LB_ID.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ID.Location = New System.Drawing.Point(28, 17)
        Me.LB_ID.Name = "LB_ID"
        Me.LB_ID.Size = New System.Drawing.Size(36, 13)
        Me.LB_ID.TabIndex = 19
        Me.LB_ID.Text = "#PDV"
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
        Me.FL_MENU_2.Location = New System.Drawing.Point(657, 7)
        Me.FL_MENU_2.Name = "FL_MENU_2"
        Me.FL_MENU_2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FL_MENU_2.Size = New System.Drawing.Size(385, 40)
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
        Me.BT_SALIR.Location = New System.Drawing.Point(315, 6)
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
        Me.BT_CANCELAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.ICO_BT_CANCELAR
        Me.BT_CANCELAR.Location = New System.Drawing.Point(245, 6)
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
        Me.BT_GUARDAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.ICO_BT_GUARDAR
        Me.BT_GUARDAR.Location = New System.Drawing.Point(175, 6)
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
        Me.BT_LISTADO.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.ICO_BT_LISTADO
        Me.BT_LISTADO.Location = New System.Drawing.Point(102, 6)
        Me.BT_LISTADO.Name = "BT_LISTADO"
        Me.BT_LISTADO.Size = New System.Drawing.Size(70, 34)
        Me.BT_LISTADO.TabIndex = 25
        Me.BT_LISTADO.UseVisualStyleBackColor = False
        '
        'BT_EXPORTAR_EXCEL
        '
        Me.BT_EXPORTAR_EXCEL.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_EXPORTAR_EXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_EXPORTAR_EXCEL.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.ICO_BT_EXPORTAR_EXCEL
        Me.BT_EXPORTAR_EXCEL.Location = New System.Drawing.Point(26, 6)
        Me.BT_EXPORTAR_EXCEL.Name = "BT_EXPORTAR_EXCEL"
        Me.BT_EXPORTAR_EXCEL.Size = New System.Drawing.Size(70, 34)
        Me.BT_EXPORTAR_EXCEL.TabIndex = 28
        Me.BT_EXPORTAR_EXCEL.Tag = "Copiar al portapapeles"
        Me.BT_EXPORTAR_EXCEL.UseVisualStyleBackColor = True
        '
        'GB_FILTROS
        '
        Me.GB_FILTROS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_FILTROS.BackColor = System.Drawing.Color.White
        Me.GB_FILTROS.Controls.Add(Me.Label21)
        Me.GB_FILTROS.Controls.Add(Me.Label20)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_RAZON_SOCIAL)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_ZONA_UO)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_UNIDAD_OPERATIVA)
        Me.GB_FILTROS.Controls.Add(Me.Label19)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_TIPO_PUNTO_VENTA)
        Me.GB_FILTROS.Controls.Add(Me.Label38)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_ESTATUS_PUNTO_VENTA)
        Me.GB_FILTROS.Controls.Add(Me.BT_LI_BUSCAR)
        Me.GB_FILTROS.Controls.Add(Me.Label13)
        Me.GB_FILTROS.Controls.Add(Me.Label1)
        Me.GB_FILTROS.Controls.Add(Me.TB_LI_BUSCAR)
        Me.GB_FILTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FILTROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_FILTROS.Location = New System.Drawing.Point(14, 55)
        Me.GB_FILTROS.Name = "GB_FILTROS"
        Me.GB_FILTROS.Size = New System.Drawing.Size(1028, 76)
        Me.GB_FILTROS.TabIndex = 57
        Me.GB_FILTROS.TabStop = False
        Me.GB_FILTROS.Text = "Filtros"
        '
        'CB_LI_UNIDAD_OPERATIVA
        '
        Me.CB_LI_UNIDAD_OPERATIVA.FormattingEnabled = True
        Me.CB_LI_UNIDAD_OPERATIVA.Location = New System.Drawing.Point(432, 33)
        Me.CB_LI_UNIDAD_OPERATIVA.Name = "CB_LI_UNIDAD_OPERATIVA"
        Me.CB_LI_UNIDAD_OPERATIVA.Size = New System.Drawing.Size(111, 21)
        Me.CB_LI_UNIDAD_OPERATIVA.TabIndex = 118
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(435, 17)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(98, 13)
        Me.Label19.TabIndex = 117
        Me.Label19.Text = "Unidad Operativa"
        '
        'CB_LI_TIPO_PUNTO_VENTA
        '
        Me.CB_LI_TIPO_PUNTO_VENTA.Enabled = False
        Me.CB_LI_TIPO_PUNTO_VENTA.FormattingEnabled = True
        Me.CB_LI_TIPO_PUNTO_VENTA.Location = New System.Drawing.Point(666, 33)
        Me.CB_LI_TIPO_PUNTO_VENTA.Name = "CB_LI_TIPO_PUNTO_VENTA"
        Me.CB_LI_TIPO_PUNTO_VENTA.Size = New System.Drawing.Size(170, 21)
        Me.CB_LI_TIPO_PUNTO_VENTA.TabIndex = 116
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(669, 17)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(29, 13)
        Me.Label38.TabIndex = 115
        Me.Label38.Text = "Tipo"
        '
        'CB_LI_ESTATUS_PUNTO_VENTA
        '
        Me.CB_LI_ESTATUS_PUNTO_VENTA.FormattingEnabled = True
        Me.CB_LI_ESTATUS_PUNTO_VENTA.Location = New System.Drawing.Point(549, 33)
        Me.CB_LI_ESTATUS_PUNTO_VENTA.Name = "CB_LI_ESTATUS_PUNTO_VENTA"
        Me.CB_LI_ESTATUS_PUNTO_VENTA.Size = New System.Drawing.Size(111, 21)
        Me.CB_LI_ESTATUS_PUNTO_VENTA.TabIndex = 9
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
        Me.BT_LI_BUSCAR.Location = New System.Drawing.Point(947, 19)
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
        Me.Label13.Location = New System.Drawing.Point(552, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Estatus"
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
        Me.TB_LI_BUSCAR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
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
        Me.GB_LISTADO.Location = New System.Drawing.Point(14, 137)
        Me.GB_LISTADO.Name = "GB_LISTADO"
        Me.GB_LISTADO.Size = New System.Drawing.Size(1028, 406)
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
        Me.LI_LISTADO.Size = New System.Drawing.Size(1005, 367)
        Me.LI_LISTADO.TabIndex = 2
        '
        'GB_OPERACION
        '
        Me.GB_OPERACION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_OPERACION.BackColor = System.Drawing.Color.White
        Me.GB_OPERACION.Controls.Add(Me.LB_RESULTADO)
        Me.GB_OPERACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_OPERACION.Location = New System.Drawing.Point(14, 545)
        Me.GB_OPERACION.Name = "GB_OPERACION"
        Me.GB_OPERACION.Size = New System.Drawing.Size(582, 52)
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
        Me.GB_CONTROL.Location = New System.Drawing.Point(603, 545)
        Me.GB_CONTROL.Name = "GB_CONTROL"
        Me.GB_CONTROL.Size = New System.Drawing.Size(440, 52)
        Me.GB_CONTROL.TabIndex = 60
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
        Me.FL_MENU_1.Size = New System.Drawing.Size(646, 40)
        Me.FL_MENU_1.TabIndex = 61
        '
        'BT_AGREGAR
        '
        Me.BT_AGREGAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_AGREGAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_AGREGAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_AGREGAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_AGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_AGREGAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.ICO_BT_AGREGAR
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
        Me.BT_EDITAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.ICO_BT_EDITAR
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
        Me.BT_CLONAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.ICO_BT_CLONAR
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
        Me.BT_ELIMINAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.ICO_BT_ELIMINAR
        Me.BT_ELIMINAR.Location = New System.Drawing.Point(210, 3)
        Me.BT_ELIMINAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_ELIMINAR.Name = "BT_ELIMINAR"
        Me.BT_ELIMINAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_ELIMINAR.TabIndex = 6
        Me.BT_ELIMINAR.UseVisualStyleBackColor = True
        '
        'TI_RELOJ
        '
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(317, 17)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 13)
        Me.Label21.TabIndex = 130
        Me.Label21.Text = "Razón Social"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(201, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(33, 13)
        Me.Label20.TabIndex = 129
        Me.Label20.Text = "Zona"
        '
        'CB_LI_RAZON_SOCIAL
        '
        Me.CB_LI_RAZON_SOCIAL.FormattingEnabled = True
        Me.CB_LI_RAZON_SOCIAL.Location = New System.Drawing.Point(315, 33)
        Me.CB_LI_RAZON_SOCIAL.Name = "CB_LI_RAZON_SOCIAL"
        Me.CB_LI_RAZON_SOCIAL.Size = New System.Drawing.Size(111, 21)
        Me.CB_LI_RAZON_SOCIAL.TabIndex = 128
        '
        'CB_LI_ZONA_UO
        '
        Me.CB_LI_ZONA_UO.FormattingEnabled = True
        Me.CB_LI_ZONA_UO.Location = New System.Drawing.Point(198, 33)
        Me.CB_LI_ZONA_UO.Name = "CB_LI_ZONA_UO"
        Me.CB_LI_ZONA_UO.Size = New System.Drawing.Size(111, 21)
        Me.CB_LI_ZONA_UO.TabIndex = 127
        '
        'FO_FICHA_PORTATIL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 605)
        Me.Controls.Add(Me.GB_FICHA)
        Me.Controls.Add(Me.FL_MENU_2)
        Me.Controls.Add(Me.GB_FILTROS)
        Me.Controls.Add(Me.GB_LISTADO)
        Me.Controls.Add(Me.GB_OPERACION)
        Me.Controls.Add(Me.GB_CONTROL)
        Me.Controls.Add(Me.FL_MENU_1)
        Me.Name = "FO_FICHA_PORTATIL"
        Me.Text = "FO_FICHA_PORTATIL"
        Me.GB_FICHA.ResumeLayout(False)
        Me.GB_FICHA.PerformLayout()
        Me.GB_AUTOTANQUE.ResumeLayout(False)
        Me.GB_AUTOTANQUE.PerformLayout()
        Me.FL_MENU_2.ResumeLayout(False)
        Me.GB_FILTROS.ResumeLayout(False)
        Me.GB_FILTROS.PerformLayout()
        Me.GB_LISTADO.ResumeLayout(False)
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_OPERACION.ResumeLayout(False)
        Me.GB_OPERACION.PerformLayout()
        Me.GB_CONTROL.ResumeLayout(False)
        Me.FL_MENU_1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents GB_FICHA As GroupBox
    Public WithEvents TB_K_PUNTO_VENTA As TextBox
    Public WithEvents TB_K_PDV As TextBox
    Friend WithEvents GB_AUTOTANQUE As GroupBox
    Public WithEvents TB_KILOMETRAJE As TextBox
    Friend WithEvents Label16 As Label
    Public WithEvents TB_SERIE As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label7 As Label
    Public WithEvents TB_MODELO As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Public WithEvents TB_MATRICULA As TextBox
    Public WithEvents CB_AYUDANTE_2 As ComboBox
    Public WithEvents CB_TIPO_PUNTO_VENTA As ComboBox
    Friend WithEvents Label14 As Label
    Public WithEvents CB_ESTATUS_PUNTO_VENTA As ComboBox
    Friend WithEvents Label12 As Label
    Public WithEvents CB_AYUDANTE_1 As ComboBox
    Friend WithEvents Label32 As Label
    Public WithEvents CB_OPERADOR As ComboBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Public WithEvents TB_D_PUNTO_VENTA As TextBox
    Public WithEvents CB_USUARIO_CAMBIO As ComboBox
    Public WithEvents CB_USUARIO_ALTA As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents TB_F_ALTA As TextBox
    Public WithEvents TB_F_CAMBIO As TextBox
    Public WithEvents CB_UNIDAD_OPERATIVA As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents LB_ID As Label
    Public WithEvents FL_MENU_2 As FlowLayoutPanel
    Public WithEvents BT_SALIR As Button
    Public WithEvents BT_CANCELAR As Button
    Public WithEvents BT_GUARDAR As Button
    Public WithEvents BT_LISTADO As Button
    Public WithEvents BT_EXPORTAR_EXCEL As Button
    Public WithEvents GB_FILTROS As GroupBox
    Public WithEvents CB_LI_UNIDAD_OPERATIVA As ComboBox
    Friend WithEvents Label19 As Label
    Public WithEvents CB_LI_TIPO_PUNTO_VENTA As ComboBox
    Friend WithEvents Label38 As Label
    Public WithEvents CB_LI_ESTATUS_PUNTO_VENTA As ComboBox
    Public WithEvents BT_LI_BUSCAR As Button
    Friend WithEvents Label13 As Label
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
    Public WithEvents CB_MARCA As ComboBox
    Friend WithEvents Label8 As Label
    Public WithEvents TB_CAPACIDAD As TextBox
    Public WithEvents TI_RELOJ As Timer
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Public WithEvents CB_LI_RAZON_SOCIAL As ComboBox
    Public WithEvents CB_LI_ZONA_UO As ComboBox
End Class
