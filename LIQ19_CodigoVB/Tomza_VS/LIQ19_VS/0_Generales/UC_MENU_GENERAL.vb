Public Class UC_MENU_GENERAL

    Private Sub UC_MENU2_Load() Handles MyBase.Load

        Dim LL_MENU As New Label
        LL_MENU.Margin = New Padding(2, 0, 2, 0)
        LL_MENU.AutoSize = True

        Dim VP_MENUS As New DataTable
        Dim VP_PARAMETROS As String = ""
        Codigo_ABC.PG_BT_EJECUTAR_ACCION_TABLA_CLICK(VG_BD_Index, Me, "PG_LI_MENU_GENERAL", VP_PARAMETROS, VP_MENUS)

        PM_MENUS(VP_MENUS) 'EJECUTAR FUNCION QUE ARMA LOS SUBMENUS.

    End Sub

    'PROCESO QUE ACTIVA LOS MENUS.====================================================================================================================================================
    Private Sub PM_MENUS(PP_MENUS)
        'SE RECORREN LOS MENUS
        For VP_INDICE As Integer = 0 To PP_MENUS.Rows.Count - 1
            Dim VP_MENU As DataRow = PP_MENUS.Rows(VP_INDICE)
            Dim VP_MENU_ID = Integer.Parse(VP_MENU("K_MENU"))
            Dim VP_MENU_NOMBRE = VP_MENU("D_MENU").ToString()
            Dim VP_PB_MENU As PictureBox = Me.Controls.Find("PB_" + VP_MENU_NOMBRE, True)(0) 'SE BUSCA EL PICTURE BOX CON ESE NOMBRE EN LA FOMA.

            Dim VP_MENU_CONTEXT As New ContextMenuStrip() 'SE CREA EL SUBMENU.
            PM_SUBMENUS(VP_MENU_CONTEXT, VP_PB_MENU, VP_MENU_ID) 'SE GENERAN LAS OPCIONES DEL SUBMENU.
        Next
    End Sub

    'PROCESO QUE GENERA LOS SUBMENUS.=================================================================================================================================================
    Private Sub PM_SUBMENUS(PP_MENU As ContextMenuStrip, PP_SUBMENU As PictureBox, PP_MENU_ID As Integer)

        'SE OBTIENEN LOS SUBMENUS
        Dim VP_SUBMENUS As New DataTable
        Codigo_ABC.PG_BT_EJECUTAR_ACCION_TABLA_CLICK(VG_BD_Index, Me, "PG_LI_SUBMENU", PP_MENU_ID.ToString(), VP_SUBMENUS)

        'SE RECORREN LOS SUBMENUS
        For VP_INDICE As Integer = 0 To VP_SUBMENUS.Rows.Count - 1
            Dim VP_SUBMENU As DataRow = VP_SUBMENUS.Rows(VP_INDICE)
            Dim VP_TITULO_SUBMENU = VP_SUBMENU("TITULO_SUBMENU").ToString()
            Dim VP_K_MENU = Integer.Parse(VP_SUBMENU("K_MENU"))

            If VP_K_MENU = PP_MENU_ID And VP_TITULO_SUBMENU IsNot "" Then
                PP_MENU.Items.Add(VP_TITULO_SUBMENU) 'SE AGREGA LA OPCION AL CONTEXTMENUSTRIP DEL PB.
            End If
        Next

        PP_SUBMENU.Tag = PP_MENU
        AddHandler PP_MENU.ItemClicked, AddressOf SUBMENU_CLICK 'SE INDICA LA ACCION A REALIZAR EN EL CLICK DEL SUBMENU.
        PP_SUBMENU.ContextMenuStrip = PP_MENU 'SE AGREGA EL SUBMENU.

        Dim PB_SUBMENU As PictureBox = PP_SUBMENU
        AddHandler PP_SUBMENU.Paint, AddressOf FM_PB_PAINT  'DIBUJAR EL DOBLES DEL PICTURE BOX.

    End Sub

    'PROCESO QUE EJECUTA LA ACCION SEGUN EL ELEMENTO AL QUE SE LE DE CLICK EN EL SUBMENU.=============================================================================================
    Private Sub SUBMENU_CLICK(sender As Object, e As ToolStripItemClickedEventArgs)
        Dim VP_TITULO_FORMA = e.ClickedItem.Text 'TITULO DE LA FORMA

        'SE OBTIENE LA INFORMACION DEL SUBMENU
        Dim VP_DATOS_SUBMENU As New DataTable
        Dim VP_PARAMETROS As String = "'" + VP_TITULO_FORMA.ToString() + "'"
        Codigo_ABC.PG_BT_EJECUTAR_ACCION_TABLA_CLICK(VG_BD_Index, Me, "PG_SK_SUBMENU", VP_PARAMETROS, VP_DATOS_SUBMENU) '<<-SE RECIBE EL TITULO Y EN BASE A ESO BUSCA LOS DATOS. <<MEJORAR, DEBERIA SER CON ID>>
        Dim VP_SUBMENU = VP_DATOS_SUBMENU.Rows(0)
        Dim VP_D_SUBMENU = VP_SUBMENU("D_SUBMENU") 'TABLA A LA QUE HACE REFERENCIA.

        Dim VP_FORMA As Object = Reflection.Assembly.GetExecutingAssembly.CreateInstance(Reflection.Assembly.GetExecutingAssembly().GetName.Name & ".FO_" & VP_D_SUBMENU) 'OBTENER LA FORMA

        Codigo_FRM.PG_FRM_ABRIR(Me, VP_FORMA, VP_D_SUBMENU, VP_TITULO_FORMA, VG_BD_Index) 'SE CARGA LA FORMA
    End Sub

    'PROCESO QUE DIBUJA EL DOBLES EN LOS MENUS.=======================================================================================================================================
    Private Sub FM_PB_PAINT(sender As Object, e As PaintEventArgs)
        Dim VP_PARENT_COLOR As Color = sender.PARENT.BACKCOLOR
        Dim bBrush As SolidBrush = New SolidBrush(VP_PARENT_COLOR)
        Dim point1 As Point = New Point(0, 0)
        Dim point2 As Point = New Point(35, 0)
        Dim point3 As Point = New Point(0, 35)
        Dim curvePoints() As PointF = {point1, point2, point3}

        e.Graphics.FillPolygon(bBrush, curvePoints)
    End Sub

End Class
