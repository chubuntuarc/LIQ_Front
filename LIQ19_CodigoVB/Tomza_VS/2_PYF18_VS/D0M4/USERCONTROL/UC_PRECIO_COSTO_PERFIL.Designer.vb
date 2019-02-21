<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_PRECIO_COSTO_PERFIL
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.BT_ELIMINAR = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CB_LI_ZONA_UO = New System.Windows.Forms.ComboBox()
        Me.CB_LI_TIEMPO_MES = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CB_LI_TIEMPO_YYYY = New System.Windows.Forms.ComboBox()
        Me.CB_LI_UNIDAD_OPERATIVA = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GB_FICHA = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TB_SMPT = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TB_SMRU = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TB_SMP = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TB_SMD = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TB_FG = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TB_MP_INB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_APG = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_CA = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TB_FLETE = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TB_MC = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TB_PC_PRECIO_COMPRA = New System.Windows.Forms.TextBox()
        Me.CB_MES = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CB_TIEMPO_YYYY = New System.Windows.Forms.ComboBox()
        Me.CB_UNIDAD_OPERATIVA = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CH_L_PRECIO_COSTO_PERFIL = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_O_PRECIO_COSTO_PERFIL = New System.Windows.Forms.TextBox()
        Me.CB_USUARIO_CAMBIO = New System.Windows.Forms.ComboBox()
        Me.CB_USUARIO_ALTA = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_F_ALTA = New System.Windows.Forms.TextBox()
        Me.TB_F_CAMBIO = New System.Windows.Forms.TextBox()
        Me.TB_K_PRECIO_COSTO_PERFIL = New System.Windows.Forms.TextBox()
        Me.LB_ID = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_PV_PRECIO_VENTA = New System.Windows.Forms.TextBox()
        Me.GB_FILTROS = New System.Windows.Forms.GroupBox()
        Me.BT_LI_BUSCAR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_LI_BUSCAR = New System.Windows.Forms.TextBox()
        Me.GB_LISTADO = New System.Windows.Forms.GroupBox()
        Me.LI_LISTADO = New System.Windows.Forms.DataGridView()
        Me.LB_RESULTADO = New System.Windows.Forms.Label()
        Me.LB_VERSION = New System.Windows.Forms.Label()
        Me.LB_RELOJ = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_CANCELAR = New System.Windows.Forms.Button()
        Me.BT_GUARDAR = New System.Windows.Forms.Button()
        Me.BT_LISTADO = New System.Windows.Forms.Button()
        Me.BT_EXPORTAR_EXCEL = New System.Windows.Forms.Button()
        Me.GB_CONTROL = New System.Windows.Forms.GroupBox()
        Me.FL_MENU = New System.Windows.Forms.FlowLayoutPanel()
        Me.BT_AGREGAR = New System.Windows.Forms.Button()
        Me.BT_EDITAR = New System.Windows.Forms.Button()
        Me.GB_OPERACION = New System.Windows.Forms.GroupBox()
        Me.TI_RELOJ = New System.Windows.Forms.Timer(Me.components)
        Me.Label26 = New System.Windows.Forms.Label()
        Me.GB_FICHA.SuspendLayout()
        Me.GB_FILTROS.SuspendLayout()
        Me.GB_LISTADO.SuspendLayout()
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.GB_CONTROL.SuspendLayout()
        Me.FL_MENU.SuspendLayout()
        Me.GB_OPERACION.SuspendLayout()
        Me.SuspendLayout()
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
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(212, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 13)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Zona"
        '
        'CB_LI_ZONA_UO
        '
        Me.CB_LI_ZONA_UO.FormattingEnabled = True
        Me.CB_LI_ZONA_UO.Location = New System.Drawing.Point(210, 31)
        Me.CB_LI_ZONA_UO.Name = "CB_LI_ZONA_UO"
        Me.CB_LI_ZONA_UO.Size = New System.Drawing.Size(133, 21)
        Me.CB_LI_ZONA_UO.TabIndex = 34
        '
        'CB_LI_TIEMPO_MES
        '
        Me.CB_LI_TIEMPO_MES.FormattingEnabled = True
        Me.CB_LI_TIEMPO_MES.Location = New System.Drawing.Point(678, 31)
        Me.CB_LI_TIEMPO_MES.Name = "CB_LI_TIEMPO_MES"
        Me.CB_LI_TIEMPO_MES.Size = New System.Drawing.Size(121, 21)
        Me.CB_LI_TIEMPO_MES.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(681, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Mes"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(553, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Año"
        '
        'CB_LI_TIEMPO_YYYY
        '
        Me.CB_LI_TIEMPO_YYYY.FormattingEnabled = True
        Me.CB_LI_TIEMPO_YYYY.Location = New System.Drawing.Point(550, 31)
        Me.CB_LI_TIEMPO_YYYY.Name = "CB_LI_TIEMPO_YYYY"
        Me.CB_LI_TIEMPO_YYYY.Size = New System.Drawing.Size(121, 21)
        Me.CB_LI_TIEMPO_YYYY.TabIndex = 23
        '
        'CB_LI_UNIDAD_OPERATIVA
        '
        Me.CB_LI_UNIDAD_OPERATIVA.FormattingEnabled = True
        Me.CB_LI_UNIDAD_OPERATIVA.Location = New System.Drawing.Point(351, 31)
        Me.CB_LI_UNIDAD_OPERATIVA.Name = "CB_LI_UNIDAD_OPERATIVA"
        Me.CB_LI_UNIDAD_OPERATIVA.Size = New System.Drawing.Size(193, 21)
        Me.CB_LI_UNIDAD_OPERATIVA.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(354, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Unidad Operativa"
        '
        'GB_FICHA
        '
        Me.GB_FICHA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GB_FICHA.BackColor = System.Drawing.Color.White
        Me.GB_FICHA.Controls.Add(Me.Label23)
        Me.GB_FICHA.Controls.Add(Me.TB_SMPT)
        Me.GB_FICHA.Controls.Add(Me.Label24)
        Me.GB_FICHA.Controls.Add(Me.TB_SMRU)
        Me.GB_FICHA.Controls.Add(Me.Label25)
        Me.GB_FICHA.Controls.Add(Me.TB_SMP)
        Me.GB_FICHA.Controls.Add(Me.Label20)
        Me.GB_FICHA.Controls.Add(Me.TB_SMD)
        Me.GB_FICHA.Controls.Add(Me.Label21)
        Me.GB_FICHA.Controls.Add(Me.TB_FG)
        Me.GB_FICHA.Controls.Add(Me.Label22)
        Me.GB_FICHA.Controls.Add(Me.TB_MP_INB)
        Me.GB_FICHA.Controls.Add(Me.Label3)
        Me.GB_FICHA.Controls.Add(Me.TB_APG)
        Me.GB_FICHA.Controls.Add(Me.Label7)
        Me.GB_FICHA.Controls.Add(Me.TB_CA)
        Me.GB_FICHA.Controls.Add(Me.Label19)
        Me.GB_FICHA.Controls.Add(Me.TB_FLETE)
        Me.GB_FICHA.Controls.Add(Me.Label18)
        Me.GB_FICHA.Controls.Add(Me.TB_MC)
        Me.GB_FICHA.Controls.Add(Me.Label17)
        Me.GB_FICHA.Controls.Add(Me.TB_PC_PRECIO_COMPRA)
        Me.GB_FICHA.Controls.Add(Me.CB_MES)
        Me.GB_FICHA.Controls.Add(Me.Label11)
        Me.GB_FICHA.Controls.Add(Me.Label12)
        Me.GB_FICHA.Controls.Add(Me.CB_TIEMPO_YYYY)
        Me.GB_FICHA.Controls.Add(Me.CB_UNIDAD_OPERATIVA)
        Me.GB_FICHA.Controls.Add(Me.Label10)
        Me.GB_FICHA.Controls.Add(Me.CH_L_PRECIO_COSTO_PERFIL)
        Me.GB_FICHA.Controls.Add(Me.Label4)
        Me.GB_FICHA.Controls.Add(Me.TB_O_PRECIO_COSTO_PERFIL)
        Me.GB_FICHA.Controls.Add(Me.CB_USUARIO_CAMBIO)
        Me.GB_FICHA.Controls.Add(Me.CB_USUARIO_ALTA)
        Me.GB_FICHA.Controls.Add(Me.Label5)
        Me.GB_FICHA.Controls.Add(Me.Label9)
        Me.GB_FICHA.Controls.Add(Me.Label6)
        Me.GB_FICHA.Controls.Add(Me.Label2)
        Me.GB_FICHA.Controls.Add(Me.TB_F_ALTA)
        Me.GB_FICHA.Controls.Add(Me.TB_F_CAMBIO)
        Me.GB_FICHA.Controls.Add(Me.TB_K_PRECIO_COSTO_PERFIL)
        Me.GB_FICHA.Controls.Add(Me.LB_ID)
        Me.GB_FICHA.Controls.Add(Me.Label8)
        Me.GB_FICHA.Controls.Add(Me.TB_PV_PRECIO_VENTA)
        Me.GB_FICHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FICHA.Location = New System.Drawing.Point(360, 207)
        Me.GB_FICHA.Name = "GB_FICHA"
        Me.GB_FICHA.Size = New System.Drawing.Size(709, 427)
        Me.GB_FICHA.TabIndex = 60
        Me.GB_FICHA.TabStop = False
        Me.GB_FICHA.Text = "Ficha"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(462, 229)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(34, 13)
        Me.Label23.TabIndex = 58
        Me.Label23.Text = "SMPT"
        '
        'TB_SMPT
        '
        Me.TB_SMPT.AccessibleDescription = ""
        Me.TB_SMPT.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_SMPT.Location = New System.Drawing.Point(459, 245)
        Me.TB_SMPT.Name = "TB_SMPT"
        Me.TB_SMPT.Size = New System.Drawing.Size(180, 22)
        Me.TB_SMPT.TabIndex = 46
        Me.TB_SMPT.Tag = "1"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(262, 229)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(38, 13)
        Me.Label24.TabIndex = 56
        Me.Label24.Text = "SMRU"
        '
        'TB_SMRU
        '
        Me.TB_SMRU.AccessibleDescription = ""
        Me.TB_SMRU.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_SMRU.Location = New System.Drawing.Point(259, 245)
        Me.TB_SMRU.Name = "TB_SMRU"
        Me.TB_SMRU.Size = New System.Drawing.Size(180, 22)
        Me.TB_SMRU.TabIndex = 45
        Me.TB_SMRU.Tag = "1"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(62, 229)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(29, 13)
        Me.Label25.TabIndex = 54
        Me.Label25.Text = "SMP"
        '
        'TB_SMP
        '
        Me.TB_SMP.AccessibleDescription = ""
        Me.TB_SMP.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_SMP.Location = New System.Drawing.Point(59, 245)
        Me.TB_SMP.Name = "TB_SMP"
        Me.TB_SMP.Size = New System.Drawing.Size(180, 22)
        Me.TB_SMP.TabIndex = 44
        Me.TB_SMP.Tag = "1"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(462, 187)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 13)
        Me.Label20.TabIndex = 52
        Me.Label20.Text = "SMD"
        '
        'TB_SMD
        '
        Me.TB_SMD.AccessibleDescription = ""
        Me.TB_SMD.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_SMD.Location = New System.Drawing.Point(459, 203)
        Me.TB_SMD.Name = "TB_SMD"
        Me.TB_SMD.Size = New System.Drawing.Size(180, 22)
        Me.TB_SMD.TabIndex = 43
        Me.TB_SMD.Tag = "1"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(262, 187)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(21, 13)
        Me.Label21.TabIndex = 50
        Me.Label21.Text = "FG"
        '
        'TB_FG
        '
        Me.TB_FG.AccessibleDescription = ""
        Me.TB_FG.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FG.Location = New System.Drawing.Point(259, 203)
        Me.TB_FG.Name = "TB_FG"
        Me.TB_FG.Size = New System.Drawing.Size(180, 22)
        Me.TB_FG.TabIndex = 42
        Me.TB_FG.Tag = "1"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(62, 187)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(46, 13)
        Me.Label22.TabIndex = 48
        Me.Label22.Text = "MP_INB"
        '
        'TB_MP_INB
        '
        Me.TB_MP_INB.AccessibleDescription = ""
        Me.TB_MP_INB.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_MP_INB.Location = New System.Drawing.Point(59, 203)
        Me.TB_MP_INB.Name = "TB_MP_INB"
        Me.TB_MP_INB.Size = New System.Drawing.Size(180, 22)
        Me.TB_MP_INB.TabIndex = 41
        Me.TB_MP_INB.Tag = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(461, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "APG"
        '
        'TB_APG
        '
        Me.TB_APG.AccessibleDescription = ""
        Me.TB_APG.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_APG.Location = New System.Drawing.Point(458, 161)
        Me.TB_APG.Name = "TB_APG"
        Me.TB_APG.Size = New System.Drawing.Size(180, 22)
        Me.TB_APG.TabIndex = 40
        Me.TB_APG.Tag = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(261, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "CA"
        '
        'TB_CA
        '
        Me.TB_CA.AccessibleDescription = ""
        Me.TB_CA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CA.Location = New System.Drawing.Point(258, 161)
        Me.TB_CA.Name = "TB_CA"
        Me.TB_CA.Size = New System.Drawing.Size(180, 22)
        Me.TB_CA.TabIndex = 39
        Me.TB_CA.Tag = "1"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(61, 145)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 13)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Flete"
        '
        'TB_FLETE
        '
        Me.TB_FLETE.AccessibleDescription = ""
        Me.TB_FLETE.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FLETE.Location = New System.Drawing.Point(58, 161)
        Me.TB_FLETE.Name = "TB_FLETE"
        Me.TB_FLETE.Size = New System.Drawing.Size(180, 22)
        Me.TB_FLETE.TabIndex = 38
        Me.TB_FLETE.Tag = "1"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(460, 103)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(24, 13)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "MC"
        '
        'TB_MC
        '
        Me.TB_MC.AccessibleDescription = ""
        Me.TB_MC.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_MC.Location = New System.Drawing.Point(457, 119)
        Me.TB_MC.Name = "TB_MC"
        Me.TB_MC.Size = New System.Drawing.Size(180, 22)
        Me.TB_MC.TabIndex = 37
        Me.TB_MC.Tag = "1"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(260, 103)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 13)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Precio Compra"
        '
        'TB_PC_PRECIO_COMPRA
        '
        Me.TB_PC_PRECIO_COMPRA.AccessibleDescription = ""
        Me.TB_PC_PRECIO_COMPRA.Enabled = False
        Me.TB_PC_PRECIO_COMPRA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PC_PRECIO_COMPRA.Location = New System.Drawing.Point(257, 119)
        Me.TB_PC_PRECIO_COMPRA.Name = "TB_PC_PRECIO_COMPRA"
        Me.TB_PC_PRECIO_COMPRA.Size = New System.Drawing.Size(180, 22)
        Me.TB_PC_PRECIO_COMPRA.TabIndex = 36
        Me.TB_PC_PRECIO_COMPRA.Tag = ""
        '
        'CB_MES
        '
        Me.CB_MES.FormattingEnabled = True
        Me.CB_MES.Location = New System.Drawing.Point(517, 55)
        Me.CB_MES.Name = "CB_MES"
        Me.CB_MES.Size = New System.Drawing.Size(121, 21)
        Me.CB_MES.TabIndex = 34
        Me.CB_MES.Tag = "1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(520, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Mes"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(372, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Año"
        '
        'CB_TIEMPO_YYYY
        '
        Me.CB_TIEMPO_YYYY.FormattingEnabled = True
        Me.CB_TIEMPO_YYYY.Location = New System.Drawing.Point(369, 55)
        Me.CB_TIEMPO_YYYY.Name = "CB_TIEMPO_YYYY"
        Me.CB_TIEMPO_YYYY.Size = New System.Drawing.Size(121, 21)
        Me.CB_TIEMPO_YYYY.TabIndex = 33
        Me.CB_TIEMPO_YYYY.Tag = "1"
        '
        'CB_UNIDAD_OPERATIVA
        '
        Me.CB_UNIDAD_OPERATIVA.FormattingEnabled = True
        Me.CB_UNIDAD_OPERATIVA.Location = New System.Drawing.Point(59, 55)
        Me.CB_UNIDAD_OPERATIVA.Name = "CB_UNIDAD_OPERATIVA"
        Me.CB_UNIDAD_OPERATIVA.Size = New System.Drawing.Size(267, 21)
        Me.CB_UNIDAD_OPERATIVA.TabIndex = 32
        Me.CB_UNIDAD_OPERATIVA.Tag = "1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(62, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Unidad Operativa"
        '
        'CH_L_PRECIO_COSTO_PERFIL
        '
        Me.CH_L_PRECIO_COSTO_PERFIL.AutoSize = True
        Me.CH_L_PRECIO_COSTO_PERFIL.Enabled = False
        Me.CH_L_PRECIO_COSTO_PERFIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CH_L_PRECIO_COSTO_PERFIL.Location = New System.Drawing.Point(374, 298)
        Me.CH_L_PRECIO_COSTO_PERFIL.Name = "CH_L_PRECIO_COSTO_PERFIL"
        Me.CH_L_PRECIO_COSTO_PERFIL.Size = New System.Drawing.Size(56, 17)
        Me.CH_L_PRECIO_COSTO_PERFIL.TabIndex = 48
        Me.CH_L_PRECIO_COSTO_PERFIL.Text = "Activo"
        Me.CH_L_PRECIO_COSTO_PERFIL.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Orden"
        Me.Label4.Visible = False
        '
        'TB_O_PRECIO_COSTO_PERFIL
        '
        Me.TB_O_PRECIO_COSTO_PERFIL.Enabled = False
        Me.TB_O_PRECIO_COSTO_PERFIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_O_PRECIO_COSTO_PERFIL.Location = New System.Drawing.Point(59, 298)
        Me.TB_O_PRECIO_COSTO_PERFIL.Name = "TB_O_PRECIO_COSTO_PERFIL"
        Me.TB_O_PRECIO_COSTO_PERFIL.Size = New System.Drawing.Size(269, 20)
        Me.TB_O_PRECIO_COSTO_PERFIL.TabIndex = 47
        Me.TB_O_PRECIO_COSTO_PERFIL.Tag = "1"
        Me.TB_O_PRECIO_COSTO_PERFIL.Text = "10"
        Me.TB_O_PRECIO_COSTO_PERFIL.Visible = False
        '
        'CB_USUARIO_CAMBIO
        '
        Me.CB_USUARIO_CAMBIO.Enabled = False
        Me.CB_USUARIO_CAMBIO.FormattingEnabled = True
        Me.CB_USUARIO_CAMBIO.Location = New System.Drawing.Point(369, 339)
        Me.CB_USUARIO_CAMBIO.Name = "CB_USUARIO_CAMBIO"
        Me.CB_USUARIO_CAMBIO.Size = New System.Drawing.Size(269, 21)
        Me.CB_USUARIO_CAMBIO.TabIndex = 25
        '
        'CB_USUARIO_ALTA
        '
        Me.CB_USUARIO_ALTA.Enabled = False
        Me.CB_USUARIO_ALTA.FormattingEnabled = True
        Me.CB_USUARIO_ALTA.Location = New System.Drawing.Point(59, 339)
        Me.CB_USUARIO_ALTA.Name = "CB_USUARIO_ALTA"
        Me.CB_USUARIO_ALTA.Size = New System.Drawing.Size(269, 21)
        Me.CB_USUARIO_ALTA.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(62, 371)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Fecha Alta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(372, 370)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Ultima modificación"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(372, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Usuario de Ultima Modificación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 323)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Usuario Alta"
        '
        'TB_F_ALTA
        '
        Me.TB_F_ALTA.Enabled = False
        Me.TB_F_ALTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_F_ALTA.Location = New System.Drawing.Point(59, 386)
        Me.TB_F_ALTA.Name = "TB_F_ALTA"
        Me.TB_F_ALTA.Size = New System.Drawing.Size(269, 22)
        Me.TB_F_ALTA.TabIndex = 22
        '
        'TB_F_CAMBIO
        '
        Me.TB_F_CAMBIO.Enabled = False
        Me.TB_F_CAMBIO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_F_CAMBIO.Location = New System.Drawing.Point(369, 386)
        Me.TB_F_CAMBIO.Name = "TB_F_CAMBIO"
        Me.TB_F_CAMBIO.Size = New System.Drawing.Size(269, 22)
        Me.TB_F_CAMBIO.TabIndex = 22
        '
        'TB_K_PRECIO_COSTO_PERFIL
        '
        Me.TB_K_PRECIO_COSTO_PERFIL.Enabled = False
        Me.TB_K_PRECIO_COSTO_PERFIL.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_K_PRECIO_COSTO_PERFIL.Location = New System.Drawing.Point(596, 11)
        Me.TB_K_PRECIO_COSTO_PERFIL.Name = "TB_K_PRECIO_COSTO_PERFIL"
        Me.TB_K_PRECIO_COSTO_PERFIL.Size = New System.Drawing.Size(42, 22)
        Me.TB_K_PRECIO_COSTO_PERFIL.TabIndex = 21
        '
        'LB_ID
        '
        Me.LB_ID.AutoSize = True
        Me.LB_ID.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ID.Location = New System.Drawing.Point(568, 14)
        Me.LB_ID.Name = "LB_ID"
        Me.LB_ID.Size = New System.Drawing.Size(18, 13)
        Me.LB_ID.TabIndex = 19
        Me.LB_ID.Text = "ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(60, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Precio Venta"
        '
        'TB_PV_PRECIO_VENTA
        '
        Me.TB_PV_PRECIO_VENTA.AccessibleDescription = ""
        Me.TB_PV_PRECIO_VENTA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PV_PRECIO_VENTA.Location = New System.Drawing.Point(57, 119)
        Me.TB_PV_PRECIO_VENTA.Name = "TB_PV_PRECIO_VENTA"
        Me.TB_PV_PRECIO_VENTA.Size = New System.Drawing.Size(180, 22)
        Me.TB_PV_PRECIO_VENTA.TabIndex = 35
        Me.TB_PV_PRECIO_VENTA.Tag = "1"
        '
        'GB_FILTROS
        '
        Me.GB_FILTROS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_FILTROS.BackColor = System.Drawing.Color.White
        Me.GB_FILTROS.Controls.Add(Me.Label16)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_ZONA_UO)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_TIEMPO_MES)
        Me.GB_FILTROS.Controls.Add(Me.Label14)
        Me.GB_FILTROS.Controls.Add(Me.Label15)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_TIEMPO_YYYY)
        Me.GB_FILTROS.Controls.Add(Me.CB_LI_UNIDAD_OPERATIVA)
        Me.GB_FILTROS.Controls.Add(Me.Label13)
        Me.GB_FILTROS.Controls.Add(Me.BT_LI_BUSCAR)
        Me.GB_FILTROS.Controls.Add(Me.Label1)
        Me.GB_FILTROS.Controls.Add(Me.TB_LI_BUSCAR)
        Me.GB_FILTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_FILTROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_FILTROS.Location = New System.Drawing.Point(3, 75)
        Me.GB_FILTROS.Name = "GB_FILTROS"
        Me.GB_FILTROS.Size = New System.Drawing.Size(1357, 63)
        Me.GB_FILTROS.TabIndex = 54
        Me.GB_FILTROS.TabStop = False
        Me.GB_FILTROS.Text = "Filtros"
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
        Me.BT_LI_BUSCAR.Location = New System.Drawing.Point(1279, 17)
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
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Buscar"
        '
        'TB_LI_BUSCAR
        '
        Me.TB_LI_BUSCAR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LI_BUSCAR.Location = New System.Drawing.Point(12, 31)
        Me.TB_LI_BUSCAR.Name = "TB_LI_BUSCAR"
        Me.TB_LI_BUSCAR.Size = New System.Drawing.Size(190, 22)
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
        Me.GB_LISTADO.Location = New System.Drawing.Point(3, 144)
        Me.GB_LISTADO.Name = "GB_LISTADO"
        Me.GB_LISTADO.Size = New System.Drawing.Size(1360, 534)
        Me.GB_LISTADO.TabIndex = 55
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
        Me.LI_LISTADO.Size = New System.Drawing.Size(1337, 495)
        Me.LI_LISTADO.TabIndex = 2
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
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel2.Controls.Add(Me.BT_CANCELAR)
        Me.FlowLayoutPanel2.Controls.Add(Me.BT_GUARDAR)
        Me.FlowLayoutPanel2.Controls.Add(Me.BT_LISTADO)
        Me.FlowLayoutPanel2.Controls.Add(Me.BT_EXPORTAR_EXCEL)
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(956, 27)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(404, 40)
        Me.FlowLayoutPanel2.TabIndex = 59
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
        Me.BT_CANCELAR.Location = New System.Drawing.Point(334, 6)
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
        Me.BT_GUARDAR.Location = New System.Drawing.Point(264, 6)
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
        Me.BT_LISTADO.Location = New System.Drawing.Point(191, 6)
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
        Me.BT_EXPORTAR_EXCEL.Location = New System.Drawing.Point(115, 6)
        Me.BT_EXPORTAR_EXCEL.Name = "BT_EXPORTAR_EXCEL"
        Me.BT_EXPORTAR_EXCEL.Size = New System.Drawing.Size(70, 34)
        Me.BT_EXPORTAR_EXCEL.TabIndex = 28
        Me.BT_EXPORTAR_EXCEL.Tag = "Copiar al portapapeles"
        Me.BT_EXPORTAR_EXCEL.UseVisualStyleBackColor = True
        '
        'GB_CONTROL
        '
        Me.GB_CONTROL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_CONTROL.BackColor = System.Drawing.Color.White
        Me.GB_CONTROL.Controls.Add(Me.LB_VERSION)
        Me.GB_CONTROL.Controls.Add(Me.LB_RELOJ)
        Me.GB_CONTROL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_CONTROL.Location = New System.Drawing.Point(901, 682)
        Me.GB_CONTROL.Name = "GB_CONTROL"
        Me.GB_CONTROL.Size = New System.Drawing.Size(459, 52)
        Me.GB_CONTROL.TabIndex = 57
        Me.GB_CONTROL.TabStop = False
        Me.GB_CONTROL.Text = "Control"
        '
        'FL_MENU
        '
        Me.FL_MENU.BackColor = System.Drawing.Color.White
        Me.FL_MENU.Controls.Add(Me.BT_AGREGAR)
        Me.FL_MENU.Controls.Add(Me.BT_EDITAR)
        Me.FL_MENU.Controls.Add(Me.BT_ELIMINAR)
        Me.FL_MENU.Location = New System.Drawing.Point(3, 27)
        Me.FL_MENU.Name = "FL_MENU"
        Me.FL_MENU.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FL_MENU.Size = New System.Drawing.Size(952, 40)
        Me.FL_MENU.TabIndex = 58
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
        'GB_OPERACION
        '
        Me.GB_OPERACION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_OPERACION.BackColor = System.Drawing.Color.White
        Me.GB_OPERACION.Controls.Add(Me.LB_RESULTADO)
        Me.GB_OPERACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_OPERACION.Location = New System.Drawing.Point(6, 682)
        Me.GB_OPERACION.Name = "GB_OPERACION"
        Me.GB_OPERACION.Size = New System.Drawing.Size(891, 52)
        Me.GB_OPERACION.TabIndex = 56
        Me.GB_OPERACION.TabStop = False
        Me.GB_OPERACION.Text = "Operación"
        '
        'TI_RELOJ
        '
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(419, 4)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(522, 20)
        Me.Label26.TabIndex = 7
        Me.Label26.Text = "SELECCIONA O CREA UN PERFIL DE PRECIOS Y COSTOS"
        '
        'UC_PRECIO_COSTO_PERFIL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.GB_FICHA)
        Me.Controls.Add(Me.GB_FILTROS)
        Me.Controls.Add(Me.GB_LISTADO)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.GB_CONTROL)
        Me.Controls.Add(Me.FL_MENU)
        Me.Controls.Add(Me.GB_OPERACION)
        Me.DoubleBuffered = True
        Me.Name = "UC_PRECIO_COSTO_PERFIL"
        Me.Size = New System.Drawing.Size(1363, 741)
        Me.GB_FICHA.ResumeLayout(False)
        Me.GB_FICHA.PerformLayout()
        Me.GB_FILTROS.ResumeLayout(False)
        Me.GB_FILTROS.PerformLayout()
        Me.GB_LISTADO.ResumeLayout(False)
        CType(Me.LI_LISTADO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.GB_CONTROL.ResumeLayout(False)
        Me.FL_MENU.ResumeLayout(False)
        Me.GB_OPERACION.ResumeLayout(False)
        Me.GB_OPERACION.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents BT_ELIMINAR As Button
    Friend WithEvents Label16 As Label
    Public WithEvents CB_LI_ZONA_UO As ComboBox
    Friend WithEvents CB_LI_TIEMPO_MES As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents CB_LI_TIEMPO_YYYY As ComboBox
    Friend WithEvents CB_LI_UNIDAD_OPERATIVA As ComboBox
    Friend WithEvents Label13 As Label
    Public WithEvents GB_FICHA As GroupBox
    Friend WithEvents Label23 As Label
    Public WithEvents TB_SMPT As TextBox
    Friend WithEvents Label24 As Label
    Public WithEvents TB_SMRU As TextBox
    Friend WithEvents Label25 As Label
    Public WithEvents TB_SMP As TextBox
    Friend WithEvents Label20 As Label
    Public WithEvents TB_SMD As TextBox
    Friend WithEvents Label21 As Label
    Public WithEvents TB_FG As TextBox
    Friend WithEvents Label22 As Label
    Public WithEvents TB_MP_INB As TextBox
    Friend WithEvents Label3 As Label
    Public WithEvents TB_APG As TextBox
    Friend WithEvents Label7 As Label
    Public WithEvents TB_CA As TextBox
    Friend WithEvents Label19 As Label
    Public WithEvents TB_FLETE As TextBox
    Friend WithEvents Label18 As Label
    Public WithEvents TB_MC As TextBox
    Friend WithEvents Label17 As Label
    Public WithEvents TB_PC_PRECIO_COMPRA As TextBox
    Friend WithEvents CB_MES As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CB_TIEMPO_YYYY As ComboBox
    Friend WithEvents CB_UNIDAD_OPERATIVA As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CH_L_PRECIO_COSTO_PERFIL As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_O_PRECIO_COSTO_PERFIL As TextBox
    Public WithEvents CB_USUARIO_CAMBIO As ComboBox
    Public WithEvents CB_USUARIO_ALTA As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents TB_F_ALTA As TextBox
    Public WithEvents TB_F_CAMBIO As TextBox
    Public WithEvents TB_K_PRECIO_COSTO_PERFIL As TextBox
    Friend WithEvents LB_ID As Label
    Friend WithEvents Label8 As Label
    Public WithEvents TB_PV_PRECIO_VENTA As TextBox
    Public WithEvents GB_FILTROS As GroupBox
    Public WithEvents BT_LI_BUSCAR As Button
    Friend WithEvents Label1 As Label
    Public WithEvents TB_LI_BUSCAR As TextBox
    Public WithEvents GB_LISTADO As GroupBox
    Public WithEvents LI_LISTADO As DataGridView
    Public WithEvents LB_RESULTADO As Label
    Public WithEvents LB_VERSION As Label
    Public WithEvents LB_RELOJ As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Public WithEvents BT_CANCELAR As Button
    Public WithEvents BT_GUARDAR As Button
    Public WithEvents BT_LISTADO As Button
    Public WithEvents BT_EXPORTAR_EXCEL As Button
    Friend WithEvents GB_CONTROL As GroupBox
    Friend WithEvents FL_MENU As FlowLayoutPanel
    Public WithEvents BT_AGREGAR As Button
    Public WithEvents BT_EDITAR As Button
    Friend WithEvents GB_OPERACION As GroupBox
    Public WithEvents TI_RELOJ As Timer
    Friend WithEvents Label26 As Label
End Class
