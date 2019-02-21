<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FO_CONCILIACION
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.FL_MENU_1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_AGREGAR = New System.Windows.Forms.Button()
        Me.BT_EDITAR = New System.Windows.Forms.Button()
        Me.BT_ELIMINAR = New System.Windows.Forms.Button()
        Me.GB_OPERACION = New System.Windows.Forms.GroupBox()
        Me.LB_RESULTADO = New System.Windows.Forms.TextBox()
        Me.CB_LI_CUENTA_BANCO = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GB_FILTROS = New System.Windows.Forms.GroupBox()
        Me.CB_LI_ZONA = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CH_EXCLUIR_CONCILIADO = New System.Windows.Forms.CheckBox()
        Me.TB_LI_BUSCAR = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DT_LI_F_OPERACION = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CB_LI_ESTATUS_CONCILIACION = New System.Windows.Forms.ComboBox()
        Me.BT_LI_BUSCAR = New System.Windows.Forms.Button()
        Me.LB_VERSION = New System.Windows.Forms.Label()
        Me.GB_CONTROL = New System.Windows.Forms.GroupBox()
        Me.LB_RELOJ = New System.Windows.Forms.Label()
        Me.TI_RELOJ = New System.Windows.Forms.Timer(Me.components)
        Me.FL_MENU_2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_SALIR = New System.Windows.Forms.Button()
        Me.BT_CANCELAR = New System.Windows.Forms.Button()
        Me.BT_GUARDAR = New System.Windows.Forms.Button()
        Me.BT_LISTADO = New System.Windows.Forms.Button()
        Me.BT_EXPORTAR_EXCEL = New System.Windows.Forms.Button()
        Me.GB_LISTADO_SIN_CONCILIAR = New System.Windows.Forms.GroupBox()
        Me.LI_LISTADO_SIN_CONCILIAR = New System.Windows.Forms.DataGridView()
        Me.GB_CONCILIACION = New System.Windows.Forms.GroupBox()
        Me.CB_UNIDAD_OPERATIVA = New System.Windows.Forms.ComboBox()
        Me.DT_F_CONCILIACION = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BT_QUITAR_CONCILIACION = New System.Windows.Forms.Button()
        Me.BT_AGREGAR_CONCILIACION = New System.Windows.Forms.Button()
        Me.CB_TIPO_LIBRO_INGRESO = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GB_LISTADO = New System.Windows.Forms.GroupBox()
        Me.LI_LISTADO = New System.Windows.Forms.DataGridView()
        Me.GB_LISTADO_RESUMEN = New System.Windows.Forms.GroupBox()
        Me.LI_LISTADO_RESUMEN = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GB_NO_CONCILIACION = New System.Windows.Forms.GroupBox()
        Me.CB_ESTATUS_CONCILIACION = New System.Windows.Forms.ComboBox()
        Me.BT_FLAG_MOVIMIENTO = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FL_MENU_1.SuspendLayout()
        Me.GB_OPERACION.SuspendLayout()
        Me.GB_FILTROS.SuspendLayout()
        Me.GB_CONTROL.SuspendLayout()
        Me.FL_MENU_2.SuspendLayout()
        Me.GB_LISTADO_SIN_CONCILIAR.SuspendLayout()
        CType(Me.LI_LISTADO_SIN_CONCILIAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_CONCILIACION.SuspendLayout()
        Me.GB_LISTADO.SuspendLayout()
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_LISTADO_RESUMEN.SuspendLayout()
        CType(Me.LI_LISTADO_RESUMEN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GB_NO_CONCILIACION.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(833, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Fecha"
        '
        'FL_MENU_1
        '
        Me.FL_MENU_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FL_MENU_1.BackColor = System.Drawing.Color.White
        Me.FL_MENU_1.Controls.Add(Me.BT_AGREGAR)
        Me.FL_MENU_1.Controls.Add(Me.BT_EDITAR)
        Me.FL_MENU_1.Controls.Add(Me.BT_ELIMINAR)
        Me.FL_MENU_1.Location = New System.Drawing.Point(12, 7)
        Me.FL_MENU_1.Name = "FL_MENU_1"
        Me.FL_MENU_1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FL_MENU_1.Size = New System.Drawing.Size(1029, 40)
        Me.FL_MENU_1.TabIndex = 80
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
        Me.BT_AGREGAR.Visible = False
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
        Me.BT_ELIMINAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_delete
        Me.BT_ELIMINAR.Location = New System.Drawing.Point(140, 3)
        Me.BT_ELIMINAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_ELIMINAR.Name = "BT_ELIMINAR"
        Me.BT_ELIMINAR.Size = New System.Drawing.Size(70, 34)
        Me.BT_ELIMINAR.TabIndex = 6
        Me.BT_ELIMINAR.UseVisualStyleBackColor = True
        Me.BT_ELIMINAR.Visible = False
        '
        'GB_OPERACION
        '
        Me.GB_OPERACION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_OPERACION.BackColor = System.Drawing.Color.White
        Me.GB_OPERACION.Controls.Add(Me.LB_RESULTADO)
        Me.GB_OPERACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_OPERACION.Location = New System.Drawing.Point(12, 566)
        Me.GB_OPERACION.Name = "GB_OPERACION"
        Me.GB_OPERACION.Size = New System.Drawing.Size(916, 52)
        Me.GB_OPERACION.TabIndex = 78
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
        Me.LB_RESULTADO.Size = New System.Drawing.Size(904, 30)
        Me.LB_RESULTADO.TabIndex = 5
        '
        'CB_LI_CUENTA_BANCO
        '
        Me.CB_LI_CUENTA_BANCO.FormattingEnabled = True
        Me.CB_LI_CUENTA_BANCO.Location = New System.Drawing.Point(306, 31)
        Me.CB_LI_CUENTA_BANCO.Name = "CB_LI_CUENTA_BANCO"
        Me.CB_LI_CUENTA_BANCO.Size = New System.Drawing.Size(376, 21)
        Me.CB_LI_CUENTA_BANCO.TabIndex = 40
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(691, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Estatus"
        '
        'GB_FILTROS
        '
        Me.GB_FILTROS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_FILTROS.BackColor = System.Drawing.Color.White
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_ZONA)
        Me.GB_FILTROS.Controls.Add(Me.Label5)
        Me.GB_FILTROS.Controls.Add(Me.CH_EXCLUIR_CONCILIADO)
        Me.GB_FILTROS.Controls.Add(Me.TB_LI_BUSCAR)
        Me.GB_FILTROS.Controls.Add(Me.Label3)
        Me.GB_FILTROS.Controls.Add(Me.DT_LI_F_OPERACION)
        Me.GB_FILTROS.Controls.Add(Me.Label14)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_CUENTA_BANCO)
        Me.GB_FILTROS.Controls.Add(Me.Label11)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_ESTATUS_CONCILIACION)
        Me.GB_FILTROS.Controls.Add(Me.BT_LI_BUSCAR)
        Me.GB_FILTROS.Controls.Add(Me.Label13)
        Me.GB_FILTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FILTROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_FILTROS.Location = New System.Drawing.Point(12, 50)
        Me.GB_FILTROS.Name = "GB_FILTROS"
        Me.GB_FILTROS.Size = New System.Drawing.Size(1192, 62)
        Me.GB_FILTROS.TabIndex = 76
        Me.GB_FILTROS.TabStop = False
        Me.GB_FILTROS.Text = "Filtros"
        '
        'CB_LI_ZONA
        '
        Me.CB_LI_ZONA.FormattingEnabled = True
        Me.CB_LI_ZONA.Location = New System.Drawing.Point(146, 31)
        Me.CB_LI_ZONA.Name = "CB_LI_ZONA"
        Me.CB_LI_ZONA.Size = New System.Drawing.Size(154, 21)
        Me.CB_LI_ZONA.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(149, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Zona"
        '
        'CH_EXCLUIR_CONCILIADO
        '
        Me.CH_EXCLUIR_CONCILIADO.AutoSize = True
        Me.CH_EXCLUIR_CONCILIADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CH_EXCLUIR_CONCILIADO.Location = New System.Drawing.Point(951, 33)
        Me.CH_EXCLUIR_CONCILIADO.Name = "CH_EXCLUIR_CONCILIADO"
        Me.CH_EXCLUIR_CONCILIADO.Size = New System.Drawing.Size(114, 17)
        Me.CH_EXCLUIR_CONCILIADO.TabIndex = 44
        Me.CH_EXCLUIR_CONCILIADO.Text = "Excluir Conciliados"
        Me.CH_EXCLUIR_CONCILIADO.UseVisualStyleBackColor = True
        '
        'TB_LI_BUSCAR
        '
        Me.TB_LI_BUSCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LI_BUSCAR.Location = New System.Drawing.Point(6, 31)
        Me.TB_LI_BUSCAR.Name = "TB_LI_BUSCAR"
        Me.TB_LI_BUSCAR.Size = New System.Drawing.Size(134, 20)
        Me.TB_LI_BUSCAR.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Buscar"
        '
        'DT_LI_F_OPERACION
        '
        Me.DT_LI_F_OPERACION.CustomFormat = "dd/MM/yyyy"
        Me.DT_LI_F_OPERACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_LI_F_OPERACION.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_LI_F_OPERACION.Location = New System.Drawing.Point(833, 31)
        Me.DT_LI_F_OPERACION.Name = "DT_LI_F_OPERACION"
        Me.DT_LI_F_OPERACION.Size = New System.Drawing.Size(112, 20)
        Me.DT_LI_F_OPERACION.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(310, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Cuenta Banco"
        '
        'CB_LI_ESTATUS_CONCILIACION
        '
        Me.CB_LI_ESTATUS_CONCILIACION.FormattingEnabled = True
        Me.CB_LI_ESTATUS_CONCILIACION.Location = New System.Drawing.Point(688, 31)
        Me.CB_LI_ESTATUS_CONCILIACION.Name = "CB_LI_ESTATUS_CONCILIACION"
        Me.CB_LI_ESTATUS_CONCILIACION.Size = New System.Drawing.Size(139, 21)
        Me.CB_LI_ESTATUS_CONCILIACION.TabIndex = 30
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
        Me.BT_LI_BUSCAR.Location = New System.Drawing.Point(1121, 21)
        Me.BT_LI_BUSCAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_LI_BUSCAR.Name = "BT_LI_BUSCAR"
        Me.BT_LI_BUSCAR.Size = New System.Drawing.Size(70, 33)
        Me.BT_LI_BUSCAR.TabIndex = 3
        Me.BT_LI_BUSCAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_LI_BUSCAR.UseVisualStyleBackColor = True
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
        'GB_CONTROL
        '
        Me.GB_CONTROL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_CONTROL.BackColor = System.Drawing.Color.White
        Me.GB_CONTROL.Controls.Add(Me.LB_VERSION)
        Me.GB_CONTROL.Controls.Add(Me.LB_RELOJ)
        Me.GB_CONTROL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_CONTROL.Location = New System.Drawing.Point(934, 566)
        Me.GB_CONTROL.Name = "GB_CONTROL"
        Me.GB_CONTROL.Size = New System.Drawing.Size(270, 52)
        Me.GB_CONTROL.TabIndex = 79
        Me.GB_CONTROL.TabStop = False
        Me.GB_CONTROL.Text = "Control"
        '
        'LB_RELOJ
        '
        Me.LB_RELOJ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_RELOJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_RELOJ.Location = New System.Drawing.Point(81, 34)
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
        Me.FL_MENU_2.Location = New System.Drawing.Point(772, 7)
        Me.FL_MENU_2.Name = "FL_MENU_2"
        Me.FL_MENU_2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FL_MENU_2.Size = New System.Drawing.Size(431, 40)
        Me.FL_MENU_2.TabIndex = 81
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
        Me.BT_SALIR.Location = New System.Drawing.Point(361, 6)
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
        Me.BT_CANCELAR.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_cancel
        Me.BT_CANCELAR.Location = New System.Drawing.Point(291, 6)
        Me.BT_CANCELAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_CANCELAR.Name = "BT_CANCELAR"
        Me.BT_CANCELAR.Size = New System.Drawing.Size(70, 31)
        Me.BT_CANCELAR.TabIndex = 23
        Me.BT_CANCELAR.UseVisualStyleBackColor = True
        Me.BT_CANCELAR.Visible = False
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
        Me.BT_GUARDAR.Location = New System.Drawing.Point(221, 6)
        Me.BT_GUARDAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_GUARDAR.Name = "BT_GUARDAR"
        Me.BT_GUARDAR.Size = New System.Drawing.Size(70, 31)
        Me.BT_GUARDAR.TabIndex = 23
        Me.BT_GUARDAR.UseVisualStyleBackColor = True
        Me.BT_GUARDAR.Visible = False
        '
        'BT_LISTADO
        '
        Me.BT_LISTADO.BackColor = System.Drawing.Color.White
        Me.BT_LISTADO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_LISTADO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BT_LISTADO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_LISTADO.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.listado
        Me.BT_LISTADO.Location = New System.Drawing.Point(148, 6)
        Me.BT_LISTADO.Name = "BT_LISTADO"
        Me.BT_LISTADO.Size = New System.Drawing.Size(70, 31)
        Me.BT_LISTADO.TabIndex = 25
        Me.BT_LISTADO.UseVisualStyleBackColor = False
        Me.BT_LISTADO.Visible = False
        '
        'BT_EXPORTAR_EXCEL
        '
        Me.BT_EXPORTAR_EXCEL.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_EXPORTAR_EXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_EXPORTAR_EXCEL.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.rsz_export
        Me.BT_EXPORTAR_EXCEL.Location = New System.Drawing.Point(72, 6)
        Me.BT_EXPORTAR_EXCEL.Name = "BT_EXPORTAR_EXCEL"
        Me.BT_EXPORTAR_EXCEL.Size = New System.Drawing.Size(70, 31)
        Me.BT_EXPORTAR_EXCEL.TabIndex = 28
        Me.BT_EXPORTAR_EXCEL.Tag = "Copiar al portapapeles"
        Me.BT_EXPORTAR_EXCEL.UseVisualStyleBackColor = True
        '
        'GB_LISTADO_SIN_CONCILIAR
        '
        Me.GB_LISTADO_SIN_CONCILIAR.BackColor = System.Drawing.Color.White
        Me.GB_LISTADO_SIN_CONCILIAR.Controls.Add(Me.LI_LISTADO_SIN_CONCILIAR)
        Me.GB_LISTADO_SIN_CONCILIAR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_LISTADO_SIN_CONCILIAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_LISTADO_SIN_CONCILIAR.Location = New System.Drawing.Point(3, 312)
        Me.GB_LISTADO_SIN_CONCILIAR.Name = "GB_LISTADO_SIN_CONCILIAR"
        Me.GB_LISTADO_SIN_CONCILIAR.Size = New System.Drawing.Size(560, 127)
        Me.GB_LISTADO_SIN_CONCILIAR.TabIndex = 79
        Me.GB_LISTADO_SIN_CONCILIAR.TabStop = False
        Me.GB_LISTADO_SIN_CONCILIAR.Text = "Movimientos sin Conciliar"
        '
        'LI_LISTADO_SIN_CONCILIAR
        '
        Me.LI_LISTADO_SIN_CONCILIAR.AllowUserToAddRows = False
        Me.LI_LISTADO_SIN_CONCILIAR.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LI_LISTADO_SIN_CONCILIAR.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.LI_LISTADO_SIN_CONCILIAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LI_LISTADO_SIN_CONCILIAR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LI_LISTADO_SIN_CONCILIAR.Location = New System.Drawing.Point(3, 16)
        Me.LI_LISTADO_SIN_CONCILIAR.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.LI_LISTADO_SIN_CONCILIAR.Name = "LI_LISTADO_SIN_CONCILIAR"
        Me.LI_LISTADO_SIN_CONCILIAR.Size = New System.Drawing.Size(554, 108)
        Me.LI_LISTADO_SIN_CONCILIAR.TabIndex = 2
        '
        'GB_CONCILIACION
        '
        Me.GB_CONCILIACION.BackColor = System.Drawing.Color.White
        Me.GB_CONCILIACION.Controls.Add(Me.CB_UNIDAD_OPERATIVA)
        Me.GB_CONCILIACION.Controls.Add(Me.DT_F_CONCILIACION)
        Me.GB_CONCILIACION.Controls.Add(Me.Label4)
        Me.GB_CONCILIACION.Controls.Add(Me.BT_QUITAR_CONCILIACION)
        Me.GB_CONCILIACION.Controls.Add(Me.BT_AGREGAR_CONCILIACION)
        Me.GB_CONCILIACION.Controls.Add(Me.CB_TIPO_LIBRO_INGRESO)
        Me.GB_CONCILIACION.Controls.Add(Me.Label2)
        Me.GB_CONCILIACION.Controls.Add(Me.Label1)
        Me.GB_CONCILIACION.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_CONCILIACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_CONCILIACION.Location = New System.Drawing.Point(3, 3)
        Me.GB_CONCILIACION.Name = "GB_CONCILIACION"
        Me.GB_CONCILIACION.Size = New System.Drawing.Size(560, 104)
        Me.GB_CONCILIACION.TabIndex = 82
        Me.GB_CONCILIACION.TabStop = False
        Me.GB_CONCILIACION.Text = "Conciliación"
        '
        'CB_UNIDAD_OPERATIVA
        '
        Me.CB_UNIDAD_OPERATIVA.FormattingEnabled = True
        Me.CB_UNIDAD_OPERATIVA.Location = New System.Drawing.Point(132, 19)
        Me.CB_UNIDAD_OPERATIVA.Name = "CB_UNIDAD_OPERATIVA"
        Me.CB_UNIDAD_OPERATIVA.Size = New System.Drawing.Size(339, 21)
        Me.CB_UNIDAD_OPERATIVA.TabIndex = 48
        '
        'DT_F_CONCILIACION
        '
        Me.DT_F_CONCILIACION.CustomFormat = "dd/MM/yyyy"
        Me.DT_F_CONCILIACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_F_CONCILIACION.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_F_CONCILIACION.Location = New System.Drawing.Point(132, 79)
        Me.DT_F_CONCILIACION.Name = "DT_F_CONCILIACION"
        Me.DT_F_CONCILIACION.Size = New System.Drawing.Size(112, 20)
        Me.DT_F_CONCILIACION.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Fecha de Conciliación"
        '
        'BT_QUITAR_CONCILIACION
        '
        Me.BT_QUITAR_CONCILIACION.FlatAppearance.BorderSize = 0
        Me.BT_QUITAR_CONCILIACION.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_QUITAR_CONCILIACION.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.delconc_opt
        Me.BT_QUITAR_CONCILIACION.Location = New System.Drawing.Point(482, 51)
        Me.BT_QUITAR_CONCILIACION.Name = "BT_QUITAR_CONCILIACION"
        Me.BT_QUITAR_CONCILIACION.Size = New System.Drawing.Size(70, 31)
        Me.BT_QUITAR_CONCILIACION.TabIndex = 47
        Me.BT_QUITAR_CONCILIACION.Tag = "Quitar Conciliación"
        Me.BT_QUITAR_CONCILIACION.UseVisualStyleBackColor = True
        '
        'BT_AGREGAR_CONCILIACION
        '
        Me.BT_AGREGAR_CONCILIACION.FlatAppearance.BorderSize = 0
        Me.BT_AGREGAR_CONCILIACION.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_AGREGAR_CONCILIACION.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.addconc_opt
        Me.BT_AGREGAR_CONCILIACION.Location = New System.Drawing.Point(482, 13)
        Me.BT_AGREGAR_CONCILIACION.Name = "BT_AGREGAR_CONCILIACION"
        Me.BT_AGREGAR_CONCILIACION.Size = New System.Drawing.Size(70, 31)
        Me.BT_AGREGAR_CONCILIACION.TabIndex = 46
        Me.BT_AGREGAR_CONCILIACION.Tag = "Agregar Conciliación"
        Me.BT_AGREGAR_CONCILIACION.UseVisualStyleBackColor = True
        '
        'CB_TIPO_LIBRO_INGRESO
        '
        Me.CB_TIPO_LIBRO_INGRESO.FormattingEnabled = True
        Me.CB_TIPO_LIBRO_INGRESO.Location = New System.Drawing.Point(132, 49)
        Me.CB_TIPO_LIBRO_INGRESO.Name = "CB_TIPO_LIBRO_INGRESO"
        Me.CB_TIPO_LIBRO_INGRESO.Size = New System.Drawing.Size(339, 21)
        Me.CB_TIPO_LIBRO_INGRESO.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Tipo Ingreso"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Unidad Operativa"
        '
        'GB_LISTADO
        '
        Me.GB_LISTADO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_LISTADO.BackColor = System.Drawing.Color.White
        Me.GB_LISTADO.Controls.Add(Me.LI_LISTADO)
        Me.GB_LISTADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_LISTADO.Location = New System.Drawing.Point(12, 118)
        Me.GB_LISTADO.Name = "GB_LISTADO"
        Me.GB_LISTADO.Size = New System.Drawing.Size(619, 442)
        Me.GB_LISTADO.TabIndex = 77
        Me.GB_LISTADO.TabStop = False
        Me.GB_LISTADO.Text = "Listado de Movimientos"
        '
        'LI_LISTADO
        '
        Me.LI_LISTADO.AllowUserToAddRows = False
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
        Me.LI_LISTADO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LI_LISTADO.Location = New System.Drawing.Point(3, 16)
        Me.LI_LISTADO.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.LI_LISTADO.Name = "LI_LISTADO"
        Me.LI_LISTADO.Size = New System.Drawing.Size(613, 423)
        Me.LI_LISTADO.TabIndex = 2
        '
        'GB_LISTADO_RESUMEN
        '
        Me.GB_LISTADO_RESUMEN.BackColor = System.Drawing.Color.White
        Me.GB_LISTADO_RESUMEN.Controls.Add(Me.LI_LISTADO_RESUMEN)
        Me.GB_LISTADO_RESUMEN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_LISTADO_RESUMEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_LISTADO_RESUMEN.Location = New System.Drawing.Point(3, 113)
        Me.GB_LISTADO_RESUMEN.Name = "GB_LISTADO_RESUMEN"
        Me.GB_LISTADO_RESUMEN.Size = New System.Drawing.Size(560, 127)
        Me.GB_LISTADO_RESUMEN.TabIndex = 78
        Me.GB_LISTADO_RESUMEN.TabStop = False
        Me.GB_LISTADO_RESUMEN.Text = "Resumen de Conciliación"
        '
        'LI_LISTADO_RESUMEN
        '
        Me.LI_LISTADO_RESUMEN.AllowUserToAddRows = False
        Me.LI_LISTADO_RESUMEN.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LI_LISTADO_RESUMEN.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.LI_LISTADO_RESUMEN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LI_LISTADO_RESUMEN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LI_LISTADO_RESUMEN.Location = New System.Drawing.Point(3, 16)
        Me.LI_LISTADO_RESUMEN.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.LI_LISTADO_RESUMEN.Name = "LI_LISTADO_RESUMEN"
        Me.LI_LISTADO_RESUMEN.Size = New System.Drawing.Size(554, 108)
        Me.LI_LISTADO_RESUMEN.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GB_NO_CONCILIACION, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GB_LISTADO_SIN_CONCILIAR, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.GB_LISTADO_RESUMEN, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GB_CONCILIACION, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(637, 118)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(566, 442)
        Me.TableLayoutPanel1.TabIndex = 83
        '
        'GB_NO_CONCILIACION
        '
        Me.GB_NO_CONCILIACION.BackColor = System.Drawing.Color.White
        Me.GB_NO_CONCILIACION.Controls.Add(Me.CB_ESTATUS_CONCILIACION)
        Me.GB_NO_CONCILIACION.Controls.Add(Me.BT_FLAG_MOVIMIENTO)
        Me.GB_NO_CONCILIACION.Controls.Add(Me.Label7)
        Me.GB_NO_CONCILIACION.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_NO_CONCILIACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_NO_CONCILIACION.Location = New System.Drawing.Point(3, 246)
        Me.GB_NO_CONCILIACION.Name = "GB_NO_CONCILIACION"
        Me.GB_NO_CONCILIACION.Size = New System.Drawing.Size(560, 60)
        Me.GB_NO_CONCILIACION.TabIndex = 83
        Me.GB_NO_CONCILIACION.TabStop = False
        Me.GB_NO_CONCILIACION.Text = "No Conciliación"
        '
        'CB_ESTATUS_CONCILIACION
        '
        Me.CB_ESTATUS_CONCILIACION.FormattingEnabled = True
        Me.CB_ESTATUS_CONCILIACION.Location = New System.Drawing.Point(132, 19)
        Me.CB_ESTATUS_CONCILIACION.Name = "CB_ESTATUS_CONCILIACION"
        Me.CB_ESTATUS_CONCILIACION.Size = New System.Drawing.Size(339, 21)
        Me.CB_ESTATUS_CONCILIACION.TabIndex = 48
        '
        'BT_FLAG_MOVIMIENTO
        '
        Me.BT_FLAG_MOVIMIENTO.FlatAppearance.BorderSize = 0
        Me.BT_FLAG_MOVIMIENTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_FLAG_MOVIMIENTO.Image = Global.LIQ19_Liquidaciones.My.Resources.Resources.marcmov_opt
        Me.BT_FLAG_MOVIMIENTO.Location = New System.Drawing.Point(482, 13)
        Me.BT_FLAG_MOVIMIENTO.Name = "BT_FLAG_MOVIMIENTO"
        Me.BT_FLAG_MOVIMIENTO.Size = New System.Drawing.Size(70, 31)
        Me.BT_FLAG_MOVIMIENTO.TabIndex = 46
        Me.BT_FLAG_MOVIMIENTO.Tag = "Marcar Movimientos"
        Me.BT_FLAG_MOVIMIENTO.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Poner en Estatus de"
        '
        'FO_CONCILIACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1215, 626)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.GB_OPERACION)
        Me.Controls.Add(Me.GB_LISTADO)
        Me.Controls.Add(Me.GB_FILTROS)
        Me.Controls.Add(Me.GB_CONTROL)
        Me.Controls.Add(Me.FL_MENU_2)
        Me.Controls.Add(Me.FL_MENU_1)
        Me.Name = "FO_CONCILIACION"
        Me.Text = "FO_CONCILIACION"
        Me.FL_MENU_1.ResumeLayout(False)
        Me.GB_OPERACION.ResumeLayout(False)
        Me.GB_OPERACION.PerformLayout()
        Me.GB_FILTROS.ResumeLayout(False)
        Me.GB_FILTROS.PerformLayout()
        Me.GB_CONTROL.ResumeLayout(False)
        Me.FL_MENU_2.ResumeLayout(False)
        Me.GB_LISTADO_SIN_CONCILIAR.ResumeLayout(False)
        CType(Me.LI_LISTADO_SIN_CONCILIAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_CONCILIACION.ResumeLayout(False)
        Me.GB_CONCILIACION.PerformLayout()
        Me.GB_LISTADO.ResumeLayout(False)
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_LISTADO_RESUMEN.ResumeLayout(False)
        CType(Me.LI_LISTADO_RESUMEN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GB_NO_CONCILIACION.ResumeLayout(False)
        Me.GB_NO_CONCILIACION.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label14 As Label
    Public WithEvents FL_MENU_1 As FlowLayoutPanel
    Public WithEvents BT_AGREGAR As Button
    Public WithEvents BT_EDITAR As Button
    Public WithEvents BT_ELIMINAR As Button
    Public WithEvents GB_OPERACION As GroupBox
    Public WithEvents LB_RESULTADO As TextBox
    Public WithEvents CB_LI_CUENTA_BANCO As ComboBox
    Friend WithEvents Label13 As Label
    Public WithEvents GB_FILTROS As GroupBox
    Friend WithEvents Label11 As Label
    Public WithEvents CB_LI_ESTATUS_CONCILIACION As ComboBox
    Public WithEvents BT_LI_BUSCAR As Button
    Public WithEvents LB_VERSION As Label
    Public WithEvents GB_CONTROL As GroupBox
    Public WithEvents LB_RELOJ As Label
    Public WithEvents TI_RELOJ As Timer
    Public WithEvents FL_MENU_2 As FlowLayoutPanel
    Public WithEvents BT_SALIR As Button
    Public WithEvents BT_CANCELAR As Button
    Public WithEvents BT_GUARDAR As Button
    Public WithEvents BT_LISTADO As Button
    Public WithEvents BT_EXPORTAR_EXCEL As Button
    Friend WithEvents DT_LI_F_OPERACION As DateTimePicker
    Public WithEvents GB_LISTADO_SIN_CONCILIAR As GroupBox
    Public WithEvents LI_LISTADO_SIN_CONCILIAR As DataGridView
    Public WithEvents GB_CONCILIACION As GroupBox
    Public WithEvents CB_TIPO_LIBRO_INGRESO As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Public WithEvents GB_LISTADO As GroupBox
    Public WithEvents LI_LISTADO As DataGridView
    Friend WithEvents TB_LI_BUSCAR As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DT_F_CONCILIACION As DateTimePicker
    Friend WithEvents Label4 As Label
    Public WithEvents GB_LISTADO_RESUMEN As GroupBox
    Public WithEvents LI_LISTADO_RESUMEN As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Public WithEvents GB_NO_CONCILIACION As GroupBox
    Public WithEvents CB_ESTATUS_CONCILIACION As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CH_EXCLUIR_CONCILIADO As CheckBox
    Public WithEvents CB_LI_ZONA As ComboBox
    Friend WithEvents Label5 As Label
    Public WithEvents BT_QUITAR_CONCILIACION As Button
    Public WithEvents BT_AGREGAR_CONCILIACION As Button
    Public WithEvents BT_FLAG_MOVIMIENTO As Button
    Friend WithEvents CB_UNIDAD_OPERATIVA As ComboBox
End Class
