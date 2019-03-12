Public Class UC_MENU2

    Dim VM_FORMA_PADRE As Object
    Dim LL_MENU As New Label


#Region "GENERALES"
    'Public Sub CALL PM_FO_ABRIR(ByRef PP_FORMA As Object, ByRef PP_NOMBRE_TABLA As String, ByVal PP_BD_Index As String)
    '    Dim PL_PANEL As Panel = Me.Parent
    '    VM_FORMA_PADRE.FL_DIRECTORIO.Controls.Add(LL_MENU)
    '    LL_MENU.ForeColor = Color.White
    '    LL_MENU.Font = VM_FORMA_PADRE.FL_DIRECTORIO.Font
    '    Codigo_FRM.PG_FO_SHOW(PP_FORMA, PP_NOMBRE_TABLA, PP_BD_Index, PL_PANEL)
    'End Sub

    Public Sub PM_FO_ABRIR(ByRef PP_FORMA As Object, ByRef PP_NOMBRE_TABLA As String, ByVal PP_TITULO_TABPAGE As String, ByVal PP_BD_Index As String)
        'Dim TP_TAB_PAGE As TabPage = Me.Parent
        'Dim TC_MAIN_TABCONTROL As TabControlEx = TP_TAB_PAGE.Parent
        'Codigo_FRM.PG_FO_SHOW(PP_FORMA, PP_NOMBRE_TABLA, PP_TITULO_TABPAGE, PP_BD_Index, TC_MAIN_TABCONTROL)

        Codigo_FRM.PG_FRM_ABRIR(Me, PP_FORMA, PP_NOMBRE_TABLA, PP_TITULO_TABPAGE, PP_BD_Index)

    End Sub

    Private Sub UC_MENU2_Load() Handles MyBase.Load

        LL_MENU.Margin = New Padding(2, 0, 2, 0)
        LL_MENU.AutoSize = True

        Call PM_MENU_0_MASTER_Init()
        Call PM_MENU_0_PB_Init()

    End Sub

    Private Sub PM_MENU_0_MASTER_Init()

        Call PM_MENU_1_CATALOGOS_Load()
        Call PM_MENU_2_GESTION_Load()
        Call PM_MENU_3_COMERCIALIZACION_Load()
        Call PM_MENU_4_COMISIONES_Load()
        Call PM_MENU_5_INVENTARIOS_Load()

    End Sub

    Private Sub PM_MENU_0_PB_Init()

        Dim VP_PB_ARRAY() As PictureBox = {PB_SUBMENU_1, PB_SUBMENU_2, PB_SUBMENU_3,
                                            PB_SUBMENU_4, PB_SUBMENU_5,
                                            PB_SUBMENU_6}
        For Each PB In VP_PB_ARRAY
            AddHandler PB.Paint, AddressOf FM_PB_PAINT
        Next

    End Sub

    Private Function FM_PB_PAINT(sender As Object, e As PaintEventArgs) As PaintEventHandler

        Dim VP_PARENT_COLOR As Color = sender.PARENT.BACKCOLOR
        Dim bBrush As SolidBrush = New SolidBrush(VP_PARENT_COLOR)

        Dim point1 As Point = New Point(0, 0)
        Dim point2 As Point = New Point(35, 0)
        Dim point3 As Point = New Point(0, 35)
        Dim curvePoints() As PointF = {point1, point2, point3}

        e.Graphics.FillPolygon(bBrush, curvePoints)

    End Function


#End Region

#Region "MENU_CLICK"


    Private Sub PM_MENU_1_CATALOGOS_Load()

        Dim VP_MENU_CATALOGOS As New ContextMenuStrip()

        VP_MENU_CATALOGOS.Items.Add("OK> Preliquidaciones")
        VP_MENU_CATALOGOS.Items.Add("OK> Puntos de venta")

        PB_SUBMENU_1.Tag = VP_MENU_CATALOGOS
        AddHandler VP_MENU_CATALOGOS.ItemClicked, AddressOf PM_MENU_1_CATALOGOS_CLICK
        PB_SUBMENU_1.ContextMenuStrip = VP_MENU_CATALOGOS

    End Sub

    Private Sub PM_MENU_1_CATALOGOS_CLICK(sender As Object, e As ToolStripItemClickedEventArgs)
        Select Case e.ClickedItem.Text

            Case "OK> Preliquidaciones" : LL_PRELIQUIDACION_LinkClicked()
            Case "OK> Puntos de venta" : LL_PUNTO_VENTA_LinkClicked()

        End Select
    End Sub

    Private Sub PM_MENU_2_GESTION_Load()

        'Dim VP_MENU_GESTION As New ContextMenuStrip()
        'VP_MENU_GESTION.Items.Add("OK> Sitios")
        'VP_MENU_GESTION.Items.Add("OK> Clientes")
        'VP_MENU_GESTION.Items.Add("OK> Condición Comercial")
        'VP_MENU_GESTION.Items.Add("OK> Cargos")

        'PB_SUBMENU_2.Tag = VP_MENU_GESTION
        'AddHandler VP_MENU_GESTION.ItemClicked, AddressOf PM_MENU_2_GESTION_CLICK
        'PB_SUBMENU_2.ContextMenuStrip = VP_MENU_GESTION

    End Sub

    Private Sub PM_MENU_2_GESTION_CLICK(sender As Object, e As ToolStripItemClickedEventArgs)
        Select Case e.ClickedItem.Text

            'Case "OK> Sitios" : LL_SITIO_LinkClicked()
            'Case "OK> Clientes" : LL_CLIENTE_LinkClicked()
            'Case "OK> Condición Comercial" : LL_CONDICION_COMERCIAL_LinkClicked()
            'Case "OK> Cargos" : LL_CARGO_LinkClicked()

        End Select
    End Sub

    Private Sub PM_MENU_3_COMERCIALIZACION_Load()

        'Dim VP_MENU_COMERCIALIZACIÓN As New ContextMenuStrip()
        'VP_MENU_COMERCIALIZACIÓN.Items.Add("OK> Control de Recibos/Sitio")
        'VP_MENU_COMERCIALIZACIÓN.Items.Add("OK> Lecturas")
        'VP_MENU_COMERCIALIZACIÓN.Items.Add("OK> Recibos")
        'VP_MENU_COMERCIALIZACIÓN.Items.Add("OK> Renglón Recibo")
        'VP_MENU_COMERCIALIZACIÓN.Items.Add("---------------")
        'VP_MENU_COMERCIALIZACIÓN.Items.Add("OK> Gestión Recibos (Pdf/Print/M@il)")
        'VP_MENU_COMERCIALIZACIÓN.Items.Add("> Gestión Estado/Cuenta (Pdf)")
        'VP_MENU_COMERCIALIZACIÓN.Items.Add("---------------")
        'VP_MENU_COMERCIALIZACIÓN.Items.Add("> Pagos")
        'VP_MENU_COMERCIALIZACIÓN.Items.Add("> Aplicar Pagos")
        'VP_MENU_COMERCIALIZACIÓN.Items.Add("> Pagos Aplicados")
        'VP_MENU_COMERCIALIZACIÓN.Items.Add("---------------")
        'VP_MENU_COMERCIALIZACIÓN.Items.Add("> Desconexión/Reconexión")
        'VP_MENU_COMERCIALIZACIÓN.Items.Add("> Bitacora Desconexión/Reconexión")

        'PB_SUBMENU_3.Tag = VP_MENU_COMERCIALIZACIÓN
        'AddHandler VP_MENU_COMERCIALIZACIÓN.ItemClicked, AddressOf PM_MENU_3_COMERCIALIZACION_CLICK
        'PB_SUBMENU_3.ContextMenuStrip = VP_MENU_COMERCIALIZACIÓN

    End Sub

    Private Sub PM_MENU_3_COMERCIALIZACION_CLICK(sender As Object, e As ToolStripItemClickedEventArgs)
        Select Case e.ClickedItem.Text

            'Case "OK> Control de Recibos/Sitio" : LL_SITIO_CONTROL_RECIBO_LinkClicked()
            'Case "OK> Lecturas" : LL_LECTURA_LinkClicked()
            'Case "OK> Recibos" : LL_RECIBO_LinkClicked()
            'Case "OK> Renglón Recibo" : LL_RENGLON_RECIBO_LinkClicked()
            'Case "OK> Gestión Recibos (Pdf/Print/M@il)" : LL_GENERA_RECIBO_PDF_LinkClicked()
            'Case "> Gestión Estado/Cuenta (Pdf)" : LL_GENERA_ESTADO_CUENTA_PDF_LinkClicked()
            'Case "> Pagos" : LL_PAGO_LinkClicked()
            'Case "> Aplicar Pagos" : LL_APLICAR_PAGO_LinkClicked()
            'Case "> Pagos Aplicados" : LL_PAGO_RECIBO_LinkClicked()
            'Case "> Desconexión/Reconexión" : LL_CLIENTE_DESCONEXION_RECONEXION_LinkClicked()
            'Case "> Bitacora Desconexión/Reconexión" : LL_BITACORA_DESCONEXION_RECONEXION_LinkClicked()

        End Select
    End Sub

    Private Sub PM_MENU_4_COMISIONES_Load()

        'Dim VP_MENU_COMISIONES As New ContextMenuStrip()
        'VP_MENU_COMISIONES.Items.Add("OK> Administrador")
        'VP_MENU_COMISIONES.Items.Add("> Gestión Comisión")
        'VP_MENU_COMISIONES.Items.Add("> Calcular Comisión")
        'VP_MENU_COMISIONES.Items.Add("> Bitácora")

        'PB_SUBMENU_4.Tag = VP_MENU_COMISIONES
        'AddHandler VP_MENU_COMISIONES.ItemClicked, AddressOf PM_MENU_4_COMISIONES_CLICK
        'PB_SUBMENU_4.ContextMenuStrip = VP_MENU_COMISIONES

    End Sub

    Private Sub PM_MENU_4_COMISIONES_CLICK(sender As Object, e As ToolStripItemClickedEventArgs)
        'Select Case e.ClickedItem.Text

        '    Case "OK> Administrador" : LL_ADMINISTRADOR_LinkClicked()
        '    Case "> Gestión Comisión" : LL_SITIO_ADMINISTRADOR_LinkClicked()
        '    Case "> Calcular Comisión" : LL_CALCULAR_COMISION_LinkClicked()
        '    Case "> Bitácora" : LL_BITACORA_COMISION_LinkClicked()

        'End Select
    End Sub

    Private Sub PM_MENU_5_INVENTARIOS_Load()

        'Dim VP_MENU_INVENTARIOS As New ContextMenuStrip()
        'VP_MENU_INVENTARIOS.Items.Add("OK> Almacenes")
        'VP_MENU_INVENTARIOS.Items.Add("OK> Movimientos")
        'VP_MENU_INVENTARIOS.Items.Add("OK> Sábana")

        'PB_SUBMENU_5.Tag = VP_MENU_INVENTARIOS
        'AddHandler VP_MENU_INVENTARIOS.ItemClicked, AddressOf PM_MENU_5_INVENTARIOS_CLICK
        'PB_SUBMENU_5.ContextMenuStrip = VP_MENU_INVENTARIOS

    End Sub

    Private Sub PM_MENU_5_INVENTARIOS_CLICK(sender As Object, e As ToolStripItemClickedEventArgs)

        'Select Case e.ClickedItem.Text

        '    Case "OK> Almacenes" : LL_ALMACEN_SITIO_LinkClicked()
        '    Case "OK> Movimientos" : LL_MOVIMIENTO_ALMACEN_LinkClicked()
        '    Case "OK> Sábana" : LL_HISTORIA_ALMACEN_LinkClicked()

        'End Select
    End Sub

#End Region

    Public Sub PP_SUBMENU_ADD(ByRef PP_CONTEXTMENUSTRIP As ContextMenuStrip, ByVal PP_SUBMENU_TEXT As String, ByVal PP_FUNCTION As String)

    End Sub

#Region "LINKCLICK"

    Private Sub LL_PRELIQUIDACION_LinkClicked()
        Call PM_FO_ABRIR(FO_PRELIQUIDACION, "PRELIQUIDACION", "Preliquidaciones", VG_BD_Index)
    End Sub
    Private Sub LL_PUNTO_VENTA_LinkClicked()
        Call PM_FO_ABRIR(FO_PUNTO_VENTA, "PUNTO_VENTA", "Puntos de Venta", VG_BD_Index)
    End Sub

    Private Sub PB_SUBMENU_3_Click(sender As Object, e As EventArgs) Handles PB_SUBMENU_3.Click

    End Sub

#End Region

End Class
