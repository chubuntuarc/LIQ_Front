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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TI_RELOJ = New System.Windows.Forms.Timer(Me.components)
        Me.GB_FICHA = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TB_DIRECCION = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TB_SUCURSAL = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TB_PLACA = New System.Windows.Forms.TextBox()
        Me.CB_USUARIO_CAMBIO = New System.Windows.Forms.ComboBox()
        Me.CB_USUARIO_ALTA = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_F_ALTA = New System.Windows.Forms.TextBox()
        Me.TB_F_CAMBIO = New System.Windows.Forms.TextBox()
        Me.CB_TIPO_PUNTO_VENTA = New System.Windows.Forms.ComboBox()
        Me.CH_L_PUNTO_VENTA = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_O_PUNTO_VENTA = New System.Windows.Forms.TextBox()
        Me.TB_K_PUNTO_VENTA = New System.Windows.Forms.TextBox()
        Me.LB_ID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_S_PUNTO_VENTA = New System.Windows.Forms.TextBox()
        Me.TB_C_PUNTO_VENTA = New System.Windows.Forms.TextBox()
        Me.TB_D_PUNTO_VENTA = New System.Windows.Forms.TextBox()
        Me.FL_MENU_2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_SALIR = New System.Windows.Forms.Button()
        Me.BT_CANCELAR = New System.Windows.Forms.Button()
        Me.BT_GUARDAR = New System.Windows.Forms.Button()
        Me.BT_LISTADO = New System.Windows.Forms.Button()
        Me.BT_EXPORTAR_EXCEL = New System.Windows.Forms.Button()
        Me.GB_FILTROS = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TB_LI_DIRECCION = New System.Windows.Forms.Label()
        Me.TB_LI_PLACA = New System.Windows.Forms.TextBox()
        Me.TB_LI_SUCURSAL = New System.Windows.Forms.TextBox()
        Me.BT_LI_BUSCAR = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
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
        Me.GB_FICHA.SuspendLayout()
        Me.FL_MENU_2.SuspendLayout()
        Me.GB_FILTROS.SuspendLayout()
        Me.GB_LISTADO.SuspendLayout()
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_OPERACION.SuspendLayout()
        Me.GB_CONTROL.SuspendLayout()
        Me.FL_MENU_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TI_RELOJ
        '
        '
        'GB_FICHA
        '
        Me.GB_FICHA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GB_FICHA.BackColor = System.Drawing.Color.White
        Me.GB_FICHA.Controls.Add(Me.Label10)
        Me.GB_FICHA.Controls.Add(Me.TB_DIRECCION)
        Me.GB_FICHA.Controls.Add(Me.Label12)
        Me.GB_FICHA.Controls.Add(Me.TB_SUCURSAL)
        Me.GB_FICHA.Controls.Add(Me.Label19)
        Me.GB_FICHA.Controls.Add(Me.TB_PLACA)
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
        Me.GB_FICHA.Location = New System.Drawing.Point(99, 307)
        Me.GB_FICHA.Margin = New System.Windows.Forms.Padding(6)
        Me.GB_FICHA.Name = "GB_FICHA"
        Me.GB_FICHA.Padding = New System.Windows.Forms.Padding(6)
        Me.GB_FICHA.Size = New System.Drawing.Size(1916, 441)
        Me.GB_FICHA.TabIndex = 40
        Me.GB_FICHA.TabStop = False
        Me.GB_FICHA.Text = "Ficha"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(724, 215)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 30)
        Me.Label10.TabIndex = 128
        Me.Label10.Text = "Dirección"
        '
        'TB_DIRECCION
        '
        Me.TB_DIRECCION.AccessibleDescription = ""
        Me.TB_DIRECCION.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_DIRECCION.Location = New System.Drawing.Point(718, 246)
        Me.TB_DIRECCION.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_DIRECCION.Name = "TB_DIRECCION"
        Me.TB_DIRECCION.Size = New System.Drawing.Size(634, 36)
        Me.TB_DIRECCION.TabIndex = 127
        Me.TB_DIRECCION.Tag = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(724, 127)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 30)
        Me.Label12.TabIndex = 126
        Me.Label12.Text = "Sucursal"
        '
        'TB_SUCURSAL
        '
        Me.TB_SUCURSAL.AccessibleDescription = ""
        Me.TB_SUCURSAL.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_SUCURSAL.Location = New System.Drawing.Point(718, 158)
        Me.TB_SUCURSAL.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_SUCURSAL.Name = "TB_SUCURSAL"
        Me.TB_SUCURSAL.Size = New System.Drawing.Size(1034, 36)
        Me.TB_SUCURSAL.TabIndex = 125
        Me.TB_SUCURSAL.Tag = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(74, 215)
        Me.Label19.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 30)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = "Placa"
        '
        'TB_PLACA
        '
        Me.TB_PLACA.AccessibleDescription = ""
        Me.TB_PLACA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PLACA.Location = New System.Drawing.Point(68, 246)
        Me.TB_PLACA.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_PLACA.Name = "TB_PLACA"
        Me.TB_PLACA.Size = New System.Drawing.Size(634, 36)
        Me.TB_PLACA.TabIndex = 46
        Me.TB_PLACA.Tag = ""
        '
        'CB_USUARIO_CAMBIO
        '
        Me.CB_USUARIO_CAMBIO.Enabled = False
        Me.CB_USUARIO_CAMBIO.FormattingEnabled = True
        Me.CB_USUARIO_CAMBIO.Location = New System.Drawing.Point(957, 351)
        Me.CB_USUARIO_CAMBIO.Margin = New System.Windows.Forms.Padding(6)
        Me.CB_USUARIO_CAMBIO.Name = "CB_USUARIO_CAMBIO"
        Me.CB_USUARIO_CAMBIO.Size = New System.Drawing.Size(426, 33)
        Me.CB_USUARIO_CAMBIO.TabIndex = 41
        '
        'CB_USUARIO_ALTA
        '
        Me.CB_USUARIO_ALTA.Enabled = False
        Me.CB_USUARIO_ALTA.FormattingEnabled = True
        Me.CB_USUARIO_ALTA.Location = New System.Drawing.Point(65, 349)
        Me.CB_USUARIO_ALTA.Margin = New System.Windows.Forms.Padding(6)
        Me.CB_USUARIO_ALTA.Name = "CB_USUARIO_ALTA"
        Me.CB_USUARIO_ALTA.Size = New System.Drawing.Size(426, 33)
        Me.CB_USUARIO_ALTA.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(515, 318)
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
        Me.Label9.Location = New System.Drawing.Point(1413, 320)
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
        Me.Label6.Location = New System.Drawing.Point(963, 320)
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
        Me.Label2.Location = New System.Drawing.Point(71, 320)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 30)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Usuario Alta"
        '
        'TB_F_ALTA
        '
        Me.TB_F_ALTA.Enabled = False
        Me.TB_F_ALTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_F_ALTA.Location = New System.Drawing.Point(509, 349)
        Me.TB_F_ALTA.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_F_ALTA.Name = "TB_F_ALTA"
        Me.TB_F_ALTA.Size = New System.Drawing.Size(426, 36)
        Me.TB_F_ALTA.TabIndex = 34
        '
        'TB_F_CAMBIO
        '
        Me.TB_F_CAMBIO.Enabled = False
        Me.TB_F_CAMBIO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_F_CAMBIO.Location = New System.Drawing.Point(1407, 351)
        Me.TB_F_CAMBIO.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_F_CAMBIO.Name = "TB_F_CAMBIO"
        Me.TB_F_CAMBIO.Size = New System.Drawing.Size(426, 36)
        Me.TB_F_CAMBIO.TabIndex = 35
        '
        'CB_TIPO_PUNTO_VENTA
        '
        Me.CB_TIPO_PUNTO_VENTA.FormattingEnabled = True
        Me.CB_TIPO_PUNTO_VENTA.Location = New System.Drawing.Point(168, 165)
        Me.CB_TIPO_PUNTO_VENTA.Margin = New System.Windows.Forms.Padding(6)
        Me.CB_TIPO_PUNTO_VENTA.Name = "CB_TIPO_PUNTO_VENTA"
        Me.CB_TIPO_PUNTO_VENTA.Size = New System.Drawing.Size(534, 33)
        Me.CB_TIPO_PUNTO_VENTA.TabIndex = 31
        '
        'CH_L_PUNTO_VENTA
        '
        Me.CH_L_PUNTO_VENTA.AutoSize = True
        Me.CH_L_PUNTO_VENTA.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CH_L_PUNTO_VENTA.Enabled = False
        Me.CH_L_PUNTO_VENTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CH_L_PUNTO_VENTA.Location = New System.Drawing.Point(1764, 133)
        Me.CH_L_PUNTO_VENTA.Margin = New System.Windows.Forms.Padding(6)
        Me.CH_L_PUNTO_VENTA.Name = "CH_L_PUNTO_VENTA"
        Me.CH_L_PUNTO_VENTA.Size = New System.Drawing.Size(76, 57)
        Me.CH_L_PUNTO_VENTA.TabIndex = 30
        Me.CH_L_PUNTO_VENTA.Text = "Activo"
        Me.CH_L_PUNTO_VENTA.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(174, 135)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 26)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Tipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(76, 137)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 26)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Orden"
        '
        'TB_O_PUNTO_VENTA
        '
        Me.TB_O_PUNTO_VENTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_O_PUNTO_VENTA.Location = New System.Drawing.Point(72, 167)
        Me.TB_O_PUNTO_VENTA.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_O_PUNTO_VENTA.Name = "TB_O_PUNTO_VENTA"
        Me.TB_O_PUNTO_VENTA.Size = New System.Drawing.Size(80, 32)
        Me.TB_O_PUNTO_VENTA.TabIndex = 26
        Me.TB_O_PUNTO_VENTA.Tag = "1"
        '
        'TB_K_PUNTO_VENTA
        '
        Me.TB_K_PUNTO_VENTA.Enabled = False
        Me.TB_K_PUNTO_VENTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_K_PUNTO_VENTA.Location = New System.Drawing.Point(72, 85)
        Me.TB_K_PUNTO_VENTA.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_K_PUNTO_VENTA.Name = "TB_K_PUNTO_VENTA"
        Me.TB_K_PUNTO_VENTA.Size = New System.Drawing.Size(80, 36)
        Me.TB_K_PUNTO_VENTA.TabIndex = 21
        '
        'LB_ID
        '
        Me.LB_ID.AutoSize = True
        Me.LB_ID.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ID.Location = New System.Drawing.Point(78, 54)
        Me.LB_ID.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LB_ID.Name = "LB_ID"
        Me.LB_ID.Size = New System.Drawing.Size(71, 30)
        Me.LB_ID.TabIndex = 19
        Me.LB_ID.Text = "#PDV"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(724, 54)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 30)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Siglas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(892, 54)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 30)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Comentarios"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(174, 54)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 30)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Descripción"
        '
        'TB_S_PUNTO_VENTA
        '
        Me.TB_S_PUNTO_VENTA.AccessibleDescription = ""
        Me.TB_S_PUNTO_VENTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_S_PUNTO_VENTA.Location = New System.Drawing.Point(718, 85)
        Me.TB_S_PUNTO_VENTA.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_S_PUNTO_VENTA.Name = "TB_S_PUNTO_VENTA"
        Me.TB_S_PUNTO_VENTA.Size = New System.Drawing.Size(152, 36)
        Me.TB_S_PUNTO_VENTA.TabIndex = 9
        Me.TB_S_PUNTO_VENTA.Tag = ""
        '
        'TB_C_PUNTO_VENTA
        '
        Me.TB_C_PUNTO_VENTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_C_PUNTO_VENTA.Location = New System.Drawing.Point(886, 85)
        Me.TB_C_PUNTO_VENTA.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_C_PUNTO_VENTA.Name = "TB_C_PUNTO_VENTA"
        Me.TB_C_PUNTO_VENTA.Size = New System.Drawing.Size(954, 36)
        Me.TB_C_PUNTO_VENTA.TabIndex = 10
        '
        'TB_D_PUNTO_VENTA
        '
        Me.TB_D_PUNTO_VENTA.AccessibleDescription = ""
        Me.TB_D_PUNTO_VENTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_D_PUNTO_VENTA.Location = New System.Drawing.Point(168, 85)
        Me.TB_D_PUNTO_VENTA.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_D_PUNTO_VENTA.Name = "TB_D_PUNTO_VENTA"
        Me.TB_D_PUNTO_VENTA.Size = New System.Drawing.Size(534, 36)
        Me.TB_D_PUNTO_VENTA.TabIndex = 8
        Me.TB_D_PUNTO_VENTA.Tag = "1"
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
        Me.FL_MENU_2.Location = New System.Drawing.Point(1085, 14)
        Me.FL_MENU_2.Margin = New System.Windows.Forms.Padding(6)
        Me.FL_MENU_2.Name = "FL_MENU_2"
        Me.FL_MENU_2.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.FL_MENU_2.Size = New System.Drawing.Size(763, 77)
        Me.FL_MENU_2.TabIndex = 46
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
        Me.BT_SALIR.Location = New System.Drawing.Point(319, 12)
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
        Me.BT_CANCELAR.Image = Global.PYF18_Finanzas.My.Resources.Resources.rsz_cancel
        Me.BT_CANCELAR.Location = New System.Drawing.Point(179, 12)
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
        Me.BT_GUARDAR.Image = Global.PYF18_Finanzas.My.Resources.Resources.rsz_accept
        Me.BT_GUARDAR.Location = New System.Drawing.Point(39, 12)
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
        Me.BT_LISTADO.Image = Global.PYF18_Finanzas.My.Resources.Resources.listado
        Me.BT_LISTADO.Location = New System.Drawing.Point(617, 12)
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
        Me.BT_EXPORTAR_EXCEL.Image = Global.PYF18_Finanzas.My.Resources.Resources.rsz_export
        Me.BT_EXPORTAR_EXCEL.Location = New System.Drawing.Point(465, 12)
        Me.BT_EXPORTAR_EXCEL.Margin = New System.Windows.Forms.Padding(6)
        Me.BT_EXPORTAR_EXCEL.Name = "BT_EXPORTAR_EXCEL"
        Me.BT_EXPORTAR_EXCEL.Size = New System.Drawing.Size(140, 65)
        Me.BT_EXPORTAR_EXCEL.TabIndex = 28
        Me.BT_EXPORTAR_EXCEL.Tag = "Copiar al portapapeles"
        Me.BT_EXPORTAR_EXCEL.UseVisualStyleBackColor = True
        '
        'GB_FILTROS
        '
        Me.GB_FILTROS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_FILTROS.BackColor = System.Drawing.Color.White
        Me.GB_FILTROS.Controls.Add(Me.TextBox1)
        Me.GB_FILTROS.Controls.Add(Me.TB_LI_DIRECCION)
        Me.GB_FILTROS.Controls.Add(Me.TB_LI_PLACA)
        Me.GB_FILTROS.Controls.Add(Me.TB_LI_SUCURSAL)
        Me.GB_FILTROS.Controls.Add(Me.BT_LI_BUSCAR)
        Me.GB_FILTROS.Controls.Add(Me.Label21)
        Me.GB_FILTROS.Controls.Add(Me.Label16)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_ESTATUS_PUNTO_VENTA)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_TIPO_PUNTO_VENTA)
        Me.GB_FILTROS.Controls.Add(Me.Label13)
        Me.GB_FILTROS.Controls.Add(Me.Label14)
        Me.GB_FILTROS.Controls.Add(Me.Label1)
        Me.GB_FILTROS.Controls.Add(Me.TB_LI_BUSCAR)
        Me.GB_FILTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FILTROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_FILTROS.Location = New System.Drawing.Point(27, 107)
        Me.GB_FILTROS.Margin = New System.Windows.Forms.Padding(6)
        Me.GB_FILTROS.Name = "GB_FILTROS"
        Me.GB_FILTROS.Padding = New System.Windows.Forms.Padding(6)
        Me.GB_FILTROS.Size = New System.Drawing.Size(2056, 202)
        Me.GB_FILTROS.TabIndex = 41
        Me.GB_FILTROS.TabStop = False
        Me.GB_FILTROS.Text = "Filtros"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(774, 143)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(356, 37)
        Me.TextBox1.TabIndex = 123
        '
        'TB_LI_DIRECCION
        '
        Me.TB_LI_DIRECCION.AutoSize = True
        Me.TB_LI_DIRECCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LI_DIRECCION.Location = New System.Drawing.Point(782, 115)
        Me.TB_LI_DIRECCION.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.TB_LI_DIRECCION.Name = "TB_LI_DIRECCION"
        Me.TB_LI_DIRECCION.Size = New System.Drawing.Size(103, 26)
        Me.TB_LI_DIRECCION.TabIndex = 122
        Me.TB_LI_DIRECCION.Text = "Dirección"
        '
        'TB_LI_PLACA
        '
        Me.TB_LI_PLACA.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LI_PLACA.Location = New System.Drawing.Point(396, 143)
        Me.TB_LI_PLACA.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_LI_PLACA.Name = "TB_LI_PLACA"
        Me.TB_LI_PLACA.Size = New System.Drawing.Size(356, 37)
        Me.TB_LI_PLACA.TabIndex = 121
        '
        'TB_LI_SUCURSAL
        '
        Me.TB_LI_SUCURSAL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LI_SUCURSAL.Location = New System.Drawing.Point(24, 143)
        Me.TB_LI_SUCURSAL.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_LI_SUCURSAL.Name = "TB_LI_SUCURSAL"
        Me.TB_LI_SUCURSAL.Size = New System.Drawing.Size(356, 37)
        Me.TB_LI_SUCURSAL.TabIndex = 120
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
        Me.BT_LI_BUSCAR.Location = New System.Drawing.Point(1685, 62)
        Me.BT_LI_BUSCAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_LI_BUSCAR.Name = "BT_LI_BUSCAR"
        Me.BT_LI_BUSCAR.Size = New System.Drawing.Size(140, 65)
        Me.BT_LI_BUSCAR.TabIndex = 3
        Me.BT_LI_BUSCAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_LI_BUSCAR.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(30, 115)
        Me.Label21.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(97, 26)
        Me.Label21.TabIndex = 119
        Me.Label21.Text = "Sucursal"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(404, 115)
        Me.Label16.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 26)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Placa"
        '
        'CB_LI_ESTATUS_PUNTO_VENTA
        '
        Me.CB_LI_ESTATUS_PUNTO_VENTA.FormattingEnabled = True
        Me.CB_LI_ESTATUS_PUNTO_VENTA.Location = New System.Drawing.Point(774, 62)
        Me.CB_LI_ESTATUS_PUNTO_VENTA.Margin = New System.Windows.Forms.Padding(6)
        Me.CB_LI_ESTATUS_PUNTO_VENTA.Name = "CB_LI_ESTATUS_PUNTO_VENTA"
        Me.CB_LI_ESTATUS_PUNTO_VENTA.Size = New System.Drawing.Size(336, 34)
        Me.CB_LI_ESTATUS_PUNTO_VENTA.TabIndex = 9
        '
        'CB_LI_TIPO_PUNTO_VENTA
        '
        Me.CB_LI_TIPO_PUNTO_VENTA.FormattingEnabled = True
        Me.CB_LI_TIPO_PUNTO_VENTA.Location = New System.Drawing.Point(396, 63)
        Me.CB_LI_TIPO_PUNTO_VENTA.Margin = New System.Windows.Forms.Padding(6)
        Me.CB_LI_TIPO_PUNTO_VENTA.Name = "CB_LI_TIPO_PUNTO_VENTA"
        Me.CB_LI_TIPO_PUNTO_VENTA.Size = New System.Drawing.Size(356, 34)
        Me.CB_LI_TIPO_PUNTO_VENTA.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(780, 31)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 30)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Estatus"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(402, 33)
        Me.Label14.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 26)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Tipo"
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
        Me.TB_LI_BUSCAR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LI_BUSCAR.Location = New System.Drawing.Point(24, 62)
        Me.TB_LI_BUSCAR.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_LI_BUSCAR.Name = "TB_LI_BUSCAR"
        Me.TB_LI_BUSCAR.Size = New System.Drawing.Size(356, 37)
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
        Me.GB_LISTADO.Location = New System.Drawing.Point(27, 320)
        Me.GB_LISTADO.Margin = New System.Windows.Forms.Padding(6)
        Me.GB_LISTADO.Name = "GB_LISTADO"
        Me.GB_LISTADO.Padding = New System.Windows.Forms.Padding(6)
        Me.GB_LISTADO.Size = New System.Drawing.Size(2056, 725)
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LI_LISTADO.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.LI_LISTADO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LI_LISTADO.Location = New System.Drawing.Point(24, 50)
        Me.LI_LISTADO.Margin = New System.Windows.Forms.Padding(24, 19, 24, 19)
        Me.LI_LISTADO.Name = "LI_LISTADO"
        Me.LI_LISTADO.Size = New System.Drawing.Size(2010, 650)
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
        Me.GB_CONTROL.TabIndex = 44
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
        Me.FL_MENU_1.Size = New System.Drawing.Size(2056, 77)
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
        Me.BT_AGREGAR.Location = New System.Drawing.Point(0, 6)
        Me.BT_AGREGAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_AGREGAR.Name = "BT_AGREGAR"
        Me.BT_AGREGAR.Size = New System.Drawing.Size(140, 65)
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
        Me.BT_CLONAR.Image = Global.PYF18_Finanzas.My.Resources.Resources.adn_icon
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
        Me.BT_ELIMINAR.Image = Global.PYF18_Finanzas.My.Resources.Resources.rsz_delete
        Me.BT_ELIMINAR.Location = New System.Drawing.Point(420, 6)
        Me.BT_ELIMINAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_ELIMINAR.Name = "BT_ELIMINAR"
        Me.BT_ELIMINAR.Size = New System.Drawing.Size(140, 65)
        Me.BT_ELIMINAR.TabIndex = 6
        Me.BT_ELIMINAR.UseVisualStyleBackColor = True
        '
        'FO_PUNTO_VENTA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(800, 450)
        Me.ClientSize = New System.Drawing.Size(2112, 1163)
        Me.Controls.Add(Me.GB_FICHA)
        Me.Controls.Add(Me.FL_MENU_2)
        Me.Controls.Add(Me.GB_FILTROS)
        Me.Controls.Add(Me.GB_LISTADO)
        Me.Controls.Add(Me.GB_OPERACION)
        Me.Controls.Add(Me.GB_CONTROL)
        Me.Controls.Add(Me.FL_MENU_1)
        Me.Name = "FO_PUNTO_VENTA"
        Me.Text = "Puntos de Venta"
        Me.GB_FICHA.ResumeLayout(False)
        Me.GB_FICHA.PerformLayout()
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
    Public WithEvents TI_RELOJ As Timer
    Public WithEvents GB_FICHA As GroupBox
    Friend WithEvents Label19 As Label
    Public WithEvents TB_PLACA As TextBox
    Public WithEvents CB_USUARIO_CAMBIO As ComboBox
    Public WithEvents CB_USUARIO_ALTA As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents TB_F_ALTA As TextBox
    Public WithEvents TB_F_CAMBIO As TextBox
    Public WithEvents CB_TIPO_PUNTO_VENTA As ComboBox
    Friend WithEvents CH_L_PUNTO_VENTA As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_O_PUNTO_VENTA As TextBox
    Public WithEvents TB_K_PUNTO_VENTA As TextBox
    Friend WithEvents LB_ID As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Public WithEvents TB_S_PUNTO_VENTA As TextBox
    Public WithEvents TB_C_PUNTO_VENTA As TextBox
    Public WithEvents TB_D_PUNTO_VENTA As TextBox
    Public WithEvents FL_MENU_2 As FlowLayoutPanel
    Public WithEvents BT_SALIR As Button
    Public WithEvents BT_CANCELAR As Button
    Public WithEvents BT_GUARDAR As Button
    Public WithEvents BT_LISTADO As Button
    Public WithEvents BT_EXPORTAR_EXCEL As Button
    Public WithEvents GB_FILTROS As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label16 As Label
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
    Public WithEvents TB_LI_SUCURSAL As TextBox
    Public WithEvents TB_LI_PLACA As TextBox
    Public WithEvents TextBox1 As TextBox
    Friend WithEvents TB_LI_DIRECCION As Label
    Friend WithEvents Label12 As Label
    Public WithEvents TB_SUCURSAL As TextBox
    Friend WithEvents Label10 As Label
    Public WithEvents TB_DIRECCION As TextBox
End Class
