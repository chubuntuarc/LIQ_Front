<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FO_FLUJO_FIRMA_X_K_USUARIO
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FO_FLUJO_FIRMA_X_K_USUARIO))
        Me.FL_MENU_1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GB_OPERACION = New System.Windows.Forms.GroupBox()
        Me.LB_RESULTADO = New System.Windows.Forms.TextBox()
        Me.CB_MODO_AUTORIZACION = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TB_OBSERVACIONES_FIRMA = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TB_N_PASO = New System.Windows.Forms.TextBox()
        Me.GB_FILTROS = New System.Windows.Forms.GroupBox()
        Me.CH_L_VER_PENDIENTES = New System.Windows.Forms.CheckBox()
        Me.CB_LI_ESTATUS_FIRMA = New System.Windows.Forms.ComboBox()
        Me.GB_FICHA = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TB_MONTO_AUTORIZADO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_MONTO_AUTORIZAR = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TB_D_AUTORIZACION_FIRMA = New System.Windows.Forms.TextBox()
        Me.CB_ESTATUS_FIRMA_ = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CB_ESTATUS_FIRMA = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TB_K_FLUJO_FIRMA = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CB_USUARIO_CAMBIO = New System.Windows.Forms.ComboBox()
        Me.CB_USUARIO_ALTA = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_F_ALTA = New System.Windows.Forms.TextBox()
        Me.TB_F_CAMBIO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_N_DIAS_FLUJO_FIRMA = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CB_ROL_AUTORIZACION = New System.Windows.Forms.ComboBox()
        Me.TB_K_AUTORIZACION_FIRMA = New System.Windows.Forms.TextBox()
        Me.LB_ID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GB_CONTROL = New System.Windows.Forms.GroupBox()
        Me.LB_VERSION = New System.Windows.Forms.Label()
        Me.LB_RELOJ = New System.Windows.Forms.Label()
        Me.TI_RELOJ = New System.Windows.Forms.Timer(Me.components)
        Me.FL_MENU_2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GB_LISTADO = New System.Windows.Forms.GroupBox()
        Me.LI_LISTADO = New System.Windows.Forms.DataGridView()
        Me.BT_SALIR = New System.Windows.Forms.Button()
        Me.BT_CANCELAR = New System.Windows.Forms.Button()
        Me.BT_GUARDAR = New System.Windows.Forms.Button()
        Me.BT_LISTADO = New System.Windows.Forms.Button()
        Me.BT_EXPORTAR_EXCEL = New System.Windows.Forms.Button()
        Me.BT_AGREGAR = New System.Windows.Forms.Button()
        Me.BT_EDITAR = New System.Windows.Forms.Button()
        Me.BT_ELIMINAR = New System.Windows.Forms.Button()
        Me.BT_ESTATUS_REVISION = New System.Windows.Forms.Button()
        Me.BT_ESTATUS_RECHAZADO = New System.Windows.Forms.Button()
        Me.BT_ESTATUS_AUTORIZADO = New System.Windows.Forms.Button()
        Me.BT_LI_BUSCAR = New System.Windows.Forms.Button()
        Me.FL_MENU_1.SuspendLayout()
        Me.GB_OPERACION.SuspendLayout()
        Me.GB_FILTROS.SuspendLayout()
        Me.GB_FICHA.SuspendLayout()
        Me.GB_CONTROL.SuspendLayout()
        Me.FL_MENU_2.SuspendLayout()
        Me.GB_LISTADO.SuspendLayout()
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FL_MENU_1
        '
        Me.FL_MENU_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FL_MENU_1.BackColor = System.Drawing.Color.White
        Me.FL_MENU_1.Controls.Add(Me.BT_AGREGAR)
        Me.FL_MENU_1.Controls.Add(Me.BT_EDITAR)
        Me.FL_MENU_1.Controls.Add(Me.BT_ELIMINAR)
        Me.FL_MENU_1.Controls.Add(Me.BT_ESTATUS_REVISION)
        Me.FL_MENU_1.Controls.Add(Me.BT_ESTATUS_RECHAZADO)
        Me.FL_MENU_1.Controls.Add(Me.BT_ESTATUS_AUTORIZADO)
        Me.FL_MENU_1.Location = New System.Drawing.Point(13, 8)
        Me.FL_MENU_1.Name = "FL_MENU_1"
        Me.FL_MENU_1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FL_MENU_1.Size = New System.Drawing.Size(978, 40)
        Me.FL_MENU_1.TabIndex = 66
        '
        'GB_OPERACION
        '
        Me.GB_OPERACION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_OPERACION.BackColor = System.Drawing.Color.White
        Me.GB_OPERACION.Controls.Add(Me.LB_RESULTADO)
        Me.GB_OPERACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_OPERACION.Location = New System.Drawing.Point(13, 581)
        Me.GB_OPERACION.Name = "GB_OPERACION"
        Me.GB_OPERACION.Size = New System.Drawing.Size(619, 52)
        Me.GB_OPERACION.TabIndex = 64
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
        Me.LB_RESULTADO.Size = New System.Drawing.Size(607, 30)
        Me.LB_RESULTADO.TabIndex = 5
        '
        'CB_MODO_AUTORIZACION
        '
        Me.CB_MODO_AUTORIZACION.Enabled = False
        Me.CB_MODO_AUTORIZACION.FormattingEnabled = True
        Me.CB_MODO_AUTORIZACION.Location = New System.Drawing.Point(311, 32)
        Me.CB_MODO_AUTORIZACION.Name = "CB_MODO_AUTORIZACION"
        Me.CB_MODO_AUTORIZACION.Size = New System.Drawing.Size(148, 21)
        Me.CB_MODO_AUTORIZACION.TabIndex = 140
        Me.CB_MODO_AUTORIZACION.Tag = "1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Estatus Firma"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(312, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(106, 13)
        Me.Label21.TabIndex = 48
        Me.Label21.Text = "Modo Autorización"
        '
        'TB_OBSERVACIONES_FIRMA
        '
        Me.TB_OBSERVACIONES_FIRMA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_OBSERVACIONES_FIRMA.Location = New System.Drawing.Point(13, 183)
        Me.TB_OBSERVACIONES_FIRMA.Multiline = True
        Me.TB_OBSERVACIONES_FIRMA.Name = "TB_OBSERVACIONES_FIRMA"
        Me.TB_OBSERVACIONES_FIRMA.Size = New System.Drawing.Size(622, 42)
        Me.TB_OBSERVACIONES_FIRMA.TabIndex = 110
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(173, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 13)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "# PASO"
        '
        'TB_N_PASO
        '
        Me.TB_N_PASO.Enabled = False
        Me.TB_N_PASO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_N_PASO.Location = New System.Drawing.Point(176, 32)
        Me.TB_N_PASO.Name = "TB_N_PASO"
        Me.TB_N_PASO.Size = New System.Drawing.Size(47, 22)
        Me.TB_N_PASO.TabIndex = 90
        Me.TB_N_PASO.Tag = "1"
        '
        'GB_FILTROS
        '
        Me.GB_FILTROS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_FILTROS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GB_FILTROS.BackColor = System.Drawing.Color.White
        Me.GB_FILTROS.Controls.Add(Me.CH_L_VER_PENDIENTES)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_ESTATUS_FIRMA)
        Me.GB_FILTROS.Controls.Add(Me.BT_LI_BUSCAR)
        Me.GB_FILTROS.Controls.Add(Me.Label13)
        Me.GB_FILTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FILTROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_FILTROS.Location = New System.Drawing.Point(13, 53)
        Me.GB_FILTROS.Name = "GB_FILTROS"
        Me.GB_FILTROS.Size = New System.Drawing.Size(1041, 67)
        Me.GB_FILTROS.TabIndex = 62
        Me.GB_FILTROS.TabStop = False
        Me.GB_FILTROS.Text = "Filtros"
        '
        'CH_L_VER_PENDIENTES
        '
        Me.CH_L_VER_PENDIENTES.AutoSize = True
        Me.CH_L_VER_PENDIENTES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CH_L_VER_PENDIENTES.Location = New System.Drawing.Point(210, 36)
        Me.CH_L_VER_PENDIENTES.Name = "CH_L_VER_PENDIENTES"
        Me.CH_L_VER_PENDIENTES.Size = New System.Drawing.Size(98, 17)
        Me.CH_L_VER_PENDIENTES.TabIndex = 73
        Me.CH_L_VER_PENDIENTES.Text = "Ver Pendientes"
        Me.CH_L_VER_PENDIENTES.UseVisualStyleBackColor = True
        '
        'CB_LI_ESTATUS_FIRMA
        '
        Me.CB_LI_ESTATUS_FIRMA.FormattingEnabled = True
        Me.CB_LI_ESTATUS_FIRMA.Location = New System.Drawing.Point(15, 32)
        Me.CB_LI_ESTATUS_FIRMA.Name = "CB_LI_ESTATUS_FIRMA"
        Me.CB_LI_ESTATUS_FIRMA.Size = New System.Drawing.Size(175, 21)
        Me.CB_LI_ESTATUS_FIRMA.TabIndex = 40
        '
        'GB_FICHA
        '
        Me.GB_FICHA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GB_FICHA.BackColor = System.Drawing.Color.White
        Me.GB_FICHA.Controls.Add(Me.Label11)
        Me.GB_FICHA.Controls.Add(Me.TB_MONTO_AUTORIZADO)
        Me.GB_FICHA.Controls.Add(Me.Label7)
        Me.GB_FICHA.Controls.Add(Me.TB_MONTO_AUTORIZAR)
        Me.GB_FICHA.Controls.Add(Me.Label24)
        Me.GB_FICHA.Controls.Add(Me.TB_D_AUTORIZACION_FIRMA)
        Me.GB_FICHA.Controls.Add(Me.CB_ESTATUS_FIRMA_)
        Me.GB_FICHA.Controls.Add(Me.Label15)
        Me.GB_FICHA.Controls.Add(Me.CB_ESTATUS_FIRMA)
        Me.GB_FICHA.Controls.Add(Me.Label12)
        Me.GB_FICHA.Controls.Add(Me.TB_K_FLUJO_FIRMA)
        Me.GB_FICHA.Controls.Add(Me.Label8)
        Me.GB_FICHA.Controls.Add(Me.CB_USUARIO_CAMBIO)
        Me.GB_FICHA.Controls.Add(Me.CB_USUARIO_ALTA)
        Me.GB_FICHA.Controls.Add(Me.Label5)
        Me.GB_FICHA.Controls.Add(Me.Label9)
        Me.GB_FICHA.Controls.Add(Me.Label6)
        Me.GB_FICHA.Controls.Add(Me.Label2)
        Me.GB_FICHA.Controls.Add(Me.TB_F_ALTA)
        Me.GB_FICHA.Controls.Add(Me.TB_F_CAMBIO)
        Me.GB_FICHA.Controls.Add(Me.Label4)
        Me.GB_FICHA.Controls.Add(Me.TB_N_DIAS_FLUJO_FIRMA)
        Me.GB_FICHA.Controls.Add(Me.CB_MODO_AUTORIZACION)
        Me.GB_FICHA.Controls.Add(Me.Label21)
        Me.GB_FICHA.Controls.Add(Me.Label20)
        Me.GB_FICHA.Controls.Add(Me.TB_OBSERVACIONES_FIRMA)
        Me.GB_FICHA.Controls.Add(Me.Label16)
        Me.GB_FICHA.Controls.Add(Me.TB_N_PASO)
        Me.GB_FICHA.Controls.Add(Me.CB_ROL_AUTORIZACION)
        Me.GB_FICHA.Controls.Add(Me.TB_K_AUTORIZACION_FIRMA)
        Me.GB_FICHA.Controls.Add(Me.LB_ID)
        Me.GB_FICHA.Controls.Add(Me.Label3)
        Me.GB_FICHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FICHA.Location = New System.Drawing.Point(243, 166)
        Me.GB_FICHA.Name = "GB_FICHA"
        Me.GB_FICHA.Size = New System.Drawing.Size(644, 285)
        Me.GB_FICHA.TabIndex = 61
        Me.GB_FICHA.TabStop = False
        Me.GB_FICHA.Text = "Ficha"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(470, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 13)
        Me.Label11.TabIndex = 1011
        Me.Label11.Text = "Monto Autorizado"
        '
        'TB_MONTO_AUTORIZADO
        '
        Me.TB_MONTO_AUTORIZADO.Enabled = False
        Me.TB_MONTO_AUTORIZADO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_MONTO_AUTORIZADO.Location = New System.Drawing.Point(473, 90)
        Me.TB_MONTO_AUTORIZADO.Name = "TB_MONTO_AUTORIZADO"
        Me.TB_MONTO_AUTORIZADO.Size = New System.Drawing.Size(111, 22)
        Me.TB_MONTO_AUTORIZADO.TabIndex = 1012
        Me.TB_MONTO_AUTORIZADO.Tag = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(350, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 1009
        Me.Label7.Text = "Monto Autorizar"
        '
        'TB_MONTO_AUTORIZAR
        '
        Me.TB_MONTO_AUTORIZAR.Enabled = False
        Me.TB_MONTO_AUTORIZAR.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_MONTO_AUTORIZAR.Location = New System.Drawing.Point(348, 90)
        Me.TB_MONTO_AUTORIZAR.Name = "TB_MONTO_AUTORIZAR"
        Me.TB_MONTO_AUTORIZAR.Size = New System.Drawing.Size(111, 22)
        Me.TB_MONTO_AUTORIZAR.TabIndex = 1010
        Me.TB_MONTO_AUTORIZAR.Tag = "1"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(16, 125)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(151, 13)
        Me.Label24.TabIndex = 1007
        Me.Label24.Text = "Descripción de Autorización"
        '
        'TB_D_AUTORIZACION_FIRMA
        '
        Me.TB_D_AUTORIZACION_FIRMA.Enabled = False
        Me.TB_D_AUTORIZACION_FIRMA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_D_AUTORIZACION_FIRMA.Location = New System.Drawing.Point(13, 141)
        Me.TB_D_AUTORIZACION_FIRMA.Multiline = True
        Me.TB_D_AUTORIZACION_FIRMA.Name = "TB_D_AUTORIZACION_FIRMA"
        Me.TB_D_AUTORIZACION_FIRMA.Size = New System.Drawing.Size(622, 21)
        Me.TB_D_AUTORIZACION_FIRMA.TabIndex = 1008
        '
        'CB_ESTATUS_FIRMA_
        '
        Me.CB_ESTATUS_FIRMA_.FormattingEnabled = True
        Me.CB_ESTATUS_FIRMA_.Location = New System.Drawing.Point(176, 90)
        Me.CB_ESTATUS_FIRMA_.Name = "CB_ESTATUS_FIRMA_"
        Me.CB_ESTATUS_FIRMA_.Size = New System.Drawing.Size(156, 21)
        Me.CB_ESTATUS_FIRMA_.TabIndex = 1005
        Me.CB_ESTATUS_FIRMA_.Tag = "1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(179, 74)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 13)
        Me.Label15.TabIndex = 1006
        Me.Label15.Text = "Estatus Firma"
        '
        'CB_ESTATUS_FIRMA
        '
        Me.CB_ESTATUS_FIRMA.FormattingEnabled = True
        Me.CB_ESTATUS_FIRMA.Location = New System.Drawing.Point(468, 32)
        Me.CB_ESTATUS_FIRMA.Name = "CB_ESTATUS_FIRMA"
        Me.CB_ESTATUS_FIRMA.Size = New System.Drawing.Size(167, 21)
        Me.CB_ESTATUS_FIRMA.TabIndex = 160
        Me.CB_ESTATUS_FIRMA.Tag = "1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(471, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 161
        Me.Label12.Text = "Estatus Flujo"
        '
        'TB_K_FLUJO_FIRMA
        '
        Me.TB_K_FLUJO_FIRMA.Enabled = False
        Me.TB_K_FLUJO_FIRMA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_K_FLUJO_FIRMA.Location = New System.Drawing.Point(13, 32)
        Me.TB_K_FLUJO_FIRMA.Name = "TB_K_FLUJO_FIRMA"
        Me.TB_K_FLUJO_FIRMA.Size = New System.Drawing.Size(74, 22)
        Me.TB_K_FLUJO_FIRMA.TabIndex = 71
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 159
        Me.Label8.Text = "# FJF"
        '
        'CB_USUARIO_CAMBIO
        '
        Me.CB_USUARIO_CAMBIO.Enabled = False
        Me.CB_USUARIO_CAMBIO.FormattingEnabled = True
        Me.CB_USUARIO_CAMBIO.Location = New System.Drawing.Point(311, 245)
        Me.CB_USUARIO_CAMBIO.Name = "CB_USUARIO_CAMBIO"
        Me.CB_USUARIO_CAMBIO.Size = New System.Drawing.Size(170, 21)
        Me.CB_USUARIO_CAMBIO.TabIndex = 1002
        '
        'CB_USUARIO_ALTA
        '
        Me.CB_USUARIO_ALTA.Enabled = False
        Me.CB_USUARIO_ALTA.FormattingEnabled = True
        Me.CB_USUARIO_ALTA.Location = New System.Drawing.Point(13, 245)
        Me.CB_USUARIO_ALTA.Name = "CB_USUARIO_ALTA"
        Me.CB_USUARIO_ALTA.Size = New System.Drawing.Size(151, 21)
        Me.CB_USUARIO_ALTA.TabIndex = 1000
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(173, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 153
        Me.Label5.Text = "Fecha Alta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(490, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 13)
        Me.Label9.TabIndex = 154
        Me.Label9.Text = "Última Modificación"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(314, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 13)
        Me.Label6.TabIndex = 155
        Me.Label6.Text = "Us Última Modificación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 156
        Me.Label2.Text = "Usuario Alta"
        '
        'TB_F_ALTA
        '
        Me.TB_F_ALTA.Enabled = False
        Me.TB_F_ALTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_F_ALTA.Location = New System.Drawing.Point(170, 244)
        Me.TB_F_ALTA.Name = "TB_F_ALTA"
        Me.TB_F_ALTA.Size = New System.Drawing.Size(129, 22)
        Me.TB_F_ALTA.TabIndex = 1001
        '
        'TB_F_CAMBIO
        '
        Me.TB_F_CAMBIO.Enabled = False
        Me.TB_F_CAMBIO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_F_CAMBIO.Location = New System.Drawing.Point(487, 245)
        Me.TB_F_CAMBIO.Name = "TB_F_CAMBIO"
        Me.TB_F_CAMBIO.Size = New System.Drawing.Size(148, 22)
        Me.TB_F_CAMBIO.TabIndex = 1003
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(231, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "# Días Flujo"
        '
        'TB_N_DIAS_FLUJO_FIRMA
        '
        Me.TB_N_DIAS_FLUJO_FIRMA.Enabled = False
        Me.TB_N_DIAS_FLUJO_FIRMA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_N_DIAS_FLUJO_FIRMA.Location = New System.Drawing.Point(233, 32)
        Me.TB_N_DIAS_FLUJO_FIRMA.Name = "TB_N_DIAS_FLUJO_FIRMA"
        Me.TB_N_DIAS_FLUJO_FIRMA.Size = New System.Drawing.Size(70, 22)
        Me.TB_N_DIAS_FLUJO_FIRMA.TabIndex = 80
        Me.TB_N_DIAS_FLUJO_FIRMA.Tag = "1"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 167)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(129, 13)
        Me.Label20.TabIndex = 47
        Me.Label20.Text = "Observaciones de Firma"
        '
        'CB_ROL_AUTORIZACION
        '
        Me.CB_ROL_AUTORIZACION.Enabled = False
        Me.CB_ROL_AUTORIZACION.FormattingEnabled = True
        Me.CB_ROL_AUTORIZACION.Location = New System.Drawing.Point(13, 90)
        Me.CB_ROL_AUTORIZACION.Name = "CB_ROL_AUTORIZACION"
        Me.CB_ROL_AUTORIZACION.Size = New System.Drawing.Size(154, 21)
        Me.CB_ROL_AUTORIZACION.TabIndex = 150
        Me.CB_ROL_AUTORIZACION.Tag = "1"
        '
        'TB_K_AUTORIZACION_FIRMA
        '
        Me.TB_K_AUTORIZACION_FIRMA.Enabled = False
        Me.TB_K_AUTORIZACION_FIRMA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_K_AUTORIZACION_FIRMA.Location = New System.Drawing.Point(96, 32)
        Me.TB_K_AUTORIZACION_FIRMA.Name = "TB_K_AUTORIZACION_FIRMA"
        Me.TB_K_AUTORIZACION_FIRMA.Size = New System.Drawing.Size(71, 22)
        Me.TB_K_AUTORIZACION_FIRMA.TabIndex = 72
        '
        'LB_ID
        '
        Me.LB_ID.AutoSize = True
        Me.LB_ID.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ID.Location = New System.Drawing.Point(98, 16)
        Me.LB_ID.Name = "LB_ID"
        Me.LB_ID.Size = New System.Drawing.Size(36, 13)
        Me.LB_ID.TabIndex = 19
        Me.LB_ID.Text = "#AUT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Rol Autorización"
        '
        'GB_CONTROL
        '
        Me.GB_CONTROL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_CONTROL.BackColor = System.Drawing.Color.White
        Me.GB_CONTROL.Controls.Add(Me.LB_VERSION)
        Me.GB_CONTROL.Controls.Add(Me.LB_RELOJ)
        Me.GB_CONTROL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_CONTROL.Location = New System.Drawing.Point(637, 581)
        Me.GB_CONTROL.Name = "GB_CONTROL"
        Me.GB_CONTROL.Size = New System.Drawing.Size(417, 52)
        Me.GB_CONTROL.TabIndex = 65
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
        Me.LB_RELOJ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_RELOJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_RELOJ.Location = New System.Drawing.Point(228, 34)
        Me.LB_RELOJ.Name = "LB_RELOJ"
        Me.LB_RELOJ.Size = New System.Drawing.Size(177, 13)
        Me.LB_RELOJ.TabIndex = 0
        Me.LB_RELOJ.Text = "Label9"
        Me.LB_RELOJ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.FL_MENU_2.Location = New System.Drawing.Point(678, 8)
        Me.FL_MENU_2.Name = "FL_MENU_2"
        Me.FL_MENU_2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FL_MENU_2.Size = New System.Drawing.Size(376, 40)
        Me.FL_MENU_2.TabIndex = 67
        '
        'GB_LISTADO
        '
        Me.GB_LISTADO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_LISTADO.BackColor = System.Drawing.Color.White
        Me.GB_LISTADO.Controls.Add(Me.LI_LISTADO)
        Me.GB_LISTADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_LISTADO.Location = New System.Drawing.Point(13, 126)
        Me.GB_LISTADO.Name = "GB_LISTADO"
        Me.GB_LISTADO.Size = New System.Drawing.Size(1041, 452)
        Me.GB_LISTADO.TabIndex = 63
        Me.GB_LISTADO.TabStop = False
        Me.GB_LISTADO.Text = "Listado"
        '
        'LI_LISTADO
        '
        Me.LI_LISTADO.AllowUserToAddRows = False
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
        Me.LI_LISTADO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LI_LISTADO.Location = New System.Drawing.Point(3, 16)
        Me.LI_LISTADO.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.LI_LISTADO.Name = "LI_LISTADO"
        Me.LI_LISTADO.Size = New System.Drawing.Size(1035, 433)
        Me.LI_LISTADO.TabIndex = 2
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
        Me.BT_SALIR.Location = New System.Drawing.Point(306, 6)
        Me.BT_SALIR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_SALIR.Name = "BT_SALIR"
        Me.BT_SALIR.Size = New System.Drawing.Size(70, 31)
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
        Me.BT_CANCELAR.Location = New System.Drawing.Point(236, 6)
        Me.BT_CANCELAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_CANCELAR.Name = "BT_CANCELAR"
        Me.BT_CANCELAR.Size = New System.Drawing.Size(70, 31)
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
        Me.BT_GUARDAR.Location = New System.Drawing.Point(166, 6)
        Me.BT_GUARDAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_GUARDAR.Name = "BT_GUARDAR"
        Me.BT_GUARDAR.Size = New System.Drawing.Size(70, 31)
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
        Me.BT_LISTADO.Location = New System.Drawing.Point(93, 6)
        Me.BT_LISTADO.Name = "BT_LISTADO"
        Me.BT_LISTADO.Size = New System.Drawing.Size(70, 31)
        Me.BT_LISTADO.TabIndex = 25
        Me.BT_LISTADO.UseVisualStyleBackColor = False
        '
        'BT_EXPORTAR_EXCEL
        '
        Me.BT_EXPORTAR_EXCEL.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_EXPORTAR_EXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_EXPORTAR_EXCEL.Image = Global.PYF18_Finanzas.My.Resources.Resources.rsz_export
        Me.BT_EXPORTAR_EXCEL.Location = New System.Drawing.Point(17, 6)
        Me.BT_EXPORTAR_EXCEL.Name = "BT_EXPORTAR_EXCEL"
        Me.BT_EXPORTAR_EXCEL.Size = New System.Drawing.Size(70, 31)
        Me.BT_EXPORTAR_EXCEL.TabIndex = 28
        Me.BT_EXPORTAR_EXCEL.Tag = "Copiar al portapapeles"
        Me.BT_EXPORTAR_EXCEL.UseVisualStyleBackColor = True
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
        Me.BT_AGREGAR.Visible = False
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
        Me.BT_EDITAR.Visible = False
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
        Me.BT_ELIMINAR.Location = New System.Drawing.Point(140, 3)
        Me.BT_ELIMINAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_ELIMINAR.Name = "BT_ELIMINAR"
        Me.BT_ELIMINAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_ELIMINAR.TabIndex = 6
        Me.BT_ELIMINAR.UseVisualStyleBackColor = True
        Me.BT_ELIMINAR.Visible = False
        '
        'BT_ESTATUS_REVISION
        '
        Me.BT_ESTATUS_REVISION.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BT_ESTATUS_REVISION.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_ESTATUS_REVISION.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_ESTATUS_REVISION.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_ESTATUS_REVISION.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_ESTATUS_REVISION.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_ESTATUS_REVISION.Image = CType(resources.GetObject("BT_ESTATUS_REVISION.Image"), System.Drawing.Image)
        Me.BT_ESTATUS_REVISION.Location = New System.Drawing.Point(210, 3)
        Me.BT_ESTATUS_REVISION.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_ESTATUS_REVISION.Name = "BT_ESTATUS_REVISION"
        Me.BT_ESTATUS_REVISION.Size = New System.Drawing.Size(70, 34)
        Me.BT_ESTATUS_REVISION.TabIndex = 25
        Me.BT_ESTATUS_REVISION.Tag = "Mandar a Revisión"
        Me.BT_ESTATUS_REVISION.UseVisualStyleBackColor = True
        '
        'BT_ESTATUS_RECHAZADO
        '
        Me.BT_ESTATUS_RECHAZADO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BT_ESTATUS_RECHAZADO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_ESTATUS_RECHAZADO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_ESTATUS_RECHAZADO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_ESTATUS_RECHAZADO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_ESTATUS_RECHAZADO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_ESTATUS_RECHAZADO.Image = CType(resources.GetObject("BT_ESTATUS_RECHAZADO.Image"), System.Drawing.Image)
        Me.BT_ESTATUS_RECHAZADO.Location = New System.Drawing.Point(280, 3)
        Me.BT_ESTATUS_RECHAZADO.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_ESTATUS_RECHAZADO.Name = "BT_ESTATUS_RECHAZADO"
        Me.BT_ESTATUS_RECHAZADO.Size = New System.Drawing.Size(70, 34)
        Me.BT_ESTATUS_RECHAZADO.TabIndex = 26
        Me.BT_ESTATUS_RECHAZADO.Tag = "Rechazar"
        Me.BT_ESTATUS_RECHAZADO.UseVisualStyleBackColor = True
        '
        'BT_ESTATUS_AUTORIZADO
        '
        Me.BT_ESTATUS_AUTORIZADO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BT_ESTATUS_AUTORIZADO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_ESTATUS_AUTORIZADO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_ESTATUS_AUTORIZADO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_ESTATUS_AUTORIZADO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BT_ESTATUS_AUTORIZADO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_ESTATUS_AUTORIZADO.Image = Global.PYF18_Finanzas.My.Resources.Resources.rsz_autorizar
        Me.BT_ESTATUS_AUTORIZADO.Location = New System.Drawing.Point(350, 3)
        Me.BT_ESTATUS_AUTORIZADO.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_ESTATUS_AUTORIZADO.Name = "BT_ESTATUS_AUTORIZADO"
        Me.BT_ESTATUS_AUTORIZADO.Size = New System.Drawing.Size(70, 34)
        Me.BT_ESTATUS_AUTORIZADO.TabIndex = 24
        Me.BT_ESTATUS_AUTORIZADO.Tag = "Autorizar"
        Me.BT_ESTATUS_AUTORIZADO.UseVisualStyleBackColor = True
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
        Me.BT_LI_BUSCAR.Location = New System.Drawing.Point(955, 24)
        Me.BT_LI_BUSCAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_LI_BUSCAR.Name = "BT_LI_BUSCAR"
        Me.BT_LI_BUSCAR.Size = New System.Drawing.Size(70, 33)
        Me.BT_LI_BUSCAR.TabIndex = 70
        Me.BT_LI_BUSCAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_LI_BUSCAR.UseVisualStyleBackColor = True
        '
        'FO_FLUJO_FIRMA_X_K_USUARIO
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1062, 640)
        Me.Controls.Add(Me.GB_FICHA)
        Me.Controls.Add(Me.FL_MENU_2)
        Me.Controls.Add(Me.FL_MENU_1)
        Me.Controls.Add(Me.GB_OPERACION)
        Me.Controls.Add(Me.GB_FILTROS)
        Me.Controls.Add(Me.GB_CONTROL)
        Me.Controls.Add(Me.GB_LISTADO)
        Me.Name = "FO_FLUJO_FIRMA_X_K_USUARIO"
        Me.Text = "Firma de Autorizaciòn"
        Me.FL_MENU_1.ResumeLayout(False)
        Me.GB_OPERACION.ResumeLayout(False)
        Me.GB_OPERACION.PerformLayout()
        Me.GB_FILTROS.ResumeLayout(False)
        Me.GB_FILTROS.PerformLayout()
        Me.GB_FICHA.ResumeLayout(False)
        Me.GB_FICHA.PerformLayout()
        Me.GB_CONTROL.ResumeLayout(False)
        Me.FL_MENU_2.ResumeLayout(False)
        Me.GB_LISTADO.ResumeLayout(False)
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents BT_LI_BUSCAR As Button
    Public WithEvents BT_AGREGAR As Button
    Public WithEvents BT_EDITAR As Button
    Public WithEvents BT_ELIMINAR As Button
    Public WithEvents CB_MODO_AUTORIZACION As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label21 As Label
    Public WithEvents TB_OBSERVACIONES_FIRMA As TextBox
    Friend WithEvents Label16 As Label
    Public WithEvents TB_N_PASO As TextBox
    Public WithEvents GB_FILTROS As GroupBox
    Public WithEvents CB_LI_ESTATUS_FIRMA As ComboBox
    Friend WithEvents Label20 As Label
    Public WithEvents CB_ROL_AUTORIZACION As ComboBox
    Public WithEvents TB_K_AUTORIZACION_FIRMA As TextBox
    Public WithEvents LB_VERSION As Label
    Public WithEvents LB_RELOJ As Label
    Public WithEvents TI_RELOJ As Timer
    Public WithEvents BT_SALIR As Button
    Public WithEvents BT_CANCELAR As Button
    Public WithEvents BT_GUARDAR As Button
    Public WithEvents BT_LISTADO As Button
    Public WithEvents BT_EXPORTAR_EXCEL As Button
    Public WithEvents GB_FICHA As GroupBox
    Friend WithEvents LB_ID As Label
    Friend WithEvents Label3 As Label
    Public WithEvents GB_LISTADO As GroupBox
    Public WithEvents LI_LISTADO As DataGridView
    Friend WithEvents Label4 As Label
    Public WithEvents TB_N_DIAS_FLUJO_FIRMA As TextBox
    Public WithEvents CB_USUARIO_CAMBIO As ComboBox
    Public WithEvents CB_USUARIO_ALTA As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents TB_F_ALTA As TextBox
    Public WithEvents TB_F_CAMBIO As TextBox
    Public WithEvents FL_MENU_1 As FlowLayoutPanel
    Public WithEvents GB_OPERACION As GroupBox
    Public WithEvents GB_CONTROL As GroupBox
    Public WithEvents FL_MENU_2 As FlowLayoutPanel
    Public WithEvents LB_RESULTADO As TextBox
    Public WithEvents CB_ESTATUS_FIRMA As ComboBox
    Friend WithEvents Label12 As Label
    Public WithEvents TB_K_FLUJO_FIRMA As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label24 As Label
    Public WithEvents TB_D_AUTORIZACION_FIRMA As TextBox
    Public WithEvents CB_ESTATUS_FIRMA_ As ComboBox
    Friend WithEvents Label15 As Label
    Public WithEvents BT_ESTATUS_REVISION As Button
    Public WithEvents BT_ESTATUS_RECHAZADO As Button
    Public WithEvents BT_ESTATUS_AUTORIZADO As Button
    Friend WithEvents Label11 As Label
    Public WithEvents TB_MONTO_AUTORIZADO As TextBox
    Friend WithEvents Label7 As Label
    Public WithEvents TB_MONTO_AUTORIZAR As TextBox
    Friend WithEvents CH_L_VER_PENDIENTES As CheckBox
End Class
