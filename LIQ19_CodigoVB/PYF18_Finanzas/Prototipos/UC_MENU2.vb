Imports System.Linq
Public Class UC_MENU2
    Dim VM_FORMA_PADRE As Object
    Dim LL_MENU As New Label
    Dim VM_DIRECTORIO As New List(Of SUBMENU_FUNCION)
    Dim VM_MENU_CARGADO As Boolean = False

#Region "CARGAR_MENU"
    Private Sub PM_CARGAR_MENU()

        Dim VP_MENU_CATALOGOS As New ContextMenuStrip()
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_CATALOGOS, ">Puntos de Venta", FO_PUNTO_VENTA, "PUNTO_VENTA", "Puntos de Venta", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_CATALOGOS, ">Razones sociales", FO_RAZON_SOCIAL, "RAZON_SOCIAL", "Razones Sociales", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_CATALOGOS, ">Zonas", FO_GENERICO_T1, "ZONA_UO", "Zonas", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_CATALOGOS, ">Unidades Operativas", FO_UNIDAD_OPERATIVA, "UNIDAD_OPERATIVA", "Unidades Operativas", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_CATALOGOS, ">Almacenes", FO_ALMACEN, "ALMACEN", "Almacenes", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_CATALOGOS, ">Parámetros Planta", FO_PARAMETRO_SUCURSAL, "PARAMETRO_SUCURSAL", "Parámetros de Planta", VG_ID_DB, 1, ""))
        PP_SUBMENU_ADD_EVENT(VP_MENU_CATALOGOS, PB_SUBMENU1)

        Dim VP_MENU_PRESUPUESTOS As New ContextMenuStrip()
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_PRESUPUESTOS, ">Rubros de Presupuesto", FO_GENERICO_T1, "RUBRO_PRESUPUESTO", "Rubros de Presupuesto", VG_ID_DB, 1, ""))
        'VM_DIRECTORIO.Add(New SUBMENU_FUNCION(VP_MENU_PRESUPUESTOS, ">Clasificaciones de Gasto", FO_CLASIFICACION_GASTO, "CLASIFICACION_GASTO", "Clasificaciones de Gasto", VG_ID_DB))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_PRESUPUESTOS, ">Plan de Gasto", FO_PLAN_GASTO, "PARTIDA_PLAN_GASTO", "Plan de Gasto", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_PRESUPUESTOS, ">Presupuesto", FO_PROGRAMACION_PRESUPUESTO, "PARTIDA_PRESUPUESTO", "Presupuesto", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_PRESUPUESTOS, ">Asistente de Presupuesto", FO_ASISTENTE_PRESUPUESTO, "PLAN_GASTO", "Asistente de Presupuesto", VG_ID_DB, 1, ""))
        PP_SUBMENU_ADD_EVENT(VP_MENU_PRESUPUESTOS, PB_SUBMENU2)

        Dim VP_MENU_FINANCIAMIENTO As New ContextMenuStrip()
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_FINANCIAMIENTO, ">Bancos", FO_BANCO, "BANCO", "Bancos", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_FINANCIAMIENTO, ">Cuentas Bancarias", FO_CUENTA, "CUENTA_BANCO", "Cuentas Bancarias", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_FINANCIAMIENTO, ">Créditos Bancarios", FO_CREDITO_BANCO, "CREDITO_BANCARIO", "Creditos Bancarios", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_FINANCIAMIENTO, ">Consulta General de Compromisos", FO_AMORTIZACION, "TABLA_AMORTIZACION", "Consulta General de Compromisos Bancarios", VG_ID_DB, 1, ""))
        PP_SUBMENU_ADD_EVENT(VP_MENU_FINANCIAMIENTO, PB_SUBMENU4)

        Dim VP_MENU_PLANEACION As New ContextMenuStrip()
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_PLANEACION, ">Control Plan Presupuesto", FO_TRACKING_PLAN_PRESUPUESTO, "PLAN_PRESUPUESTO", "Control Plan Presupuesto", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_PLANEACION, ">Plan Presupuesto", FO_PLAN_PRESUPUESTO, "PARTIDA_PLAN_PRESUPUESTO", "Plan Presupuesto", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_PLANEACION, ">Perfiles de Precio/Costo", FO_PRECIO_COSTO_PERFIL, "PRECIO_COSTO_PERFIL", "Perfiles de Precio/Costo", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_PLANEACION, ">Parámetros Cédula", FO_PARAMETRO_DOCUMENTO_D0M4, "PARAMETRO_DOCUMENTO_D0M4", "Parámetros Cédula", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_PLANEACION, ">Asistente de Venta/Objetivo", FO_ASISTENTE_POB, "PLAN_POV", "Asistente de Venta/Objetivo", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_PLANEACION, ">Asistente de Cédula-Mensual/Flujo-Proyectado", FO_ASISTENTE_CEMEC, "CEMEC", "Asistente de Cédula-Mensual/Flujo-Proyectado", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_PLANEACION, ">Visor Cédula Compromiso", FO_DATA_N1_X_DI_D0M4_CEMEC, "DATA_N1_X_DI_D0M4", "Visor Cédula Compromiso", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_PLANEACION, ">Visor de Flujo Proyectado", FO_DATA_N1_X_DI_D0M4_FLUP, "DATA_N1_X_DI_D0M4", "Visor de Flujo Proyectado", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_PLANEACION, ">Performance Historico", FO_PERFORMANCE_N3_X_ME, "PERFORMANCE_N3_X_ME", "Performance Historico", VG_ID_DB, 1, ""))
        PP_SUBMENU_ADD_EVENT(VP_MENU_PLANEACION, PB_SUBMENU3)

        Dim VP_MENU_FLUJO As New ContextMenuStrip()
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_FLUJO, ">Acta de Ingresos", FO_ACTA_INGRESOS, "", "Acta de Ingresos", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_FLUJO, ">Libro de Ingresos", FO_LIBRO_INGRESOS, "LIBRO_INGRESOS", "Libro de Ingresos", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_FLUJO, ">Conciliación de Ingresos", FO_CONCILIACION, "CONCILIACION_INGRESO", "Conciliación de Ingresos", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_FLUJO, ">Movimientos Banco", FO_MOVIMIENTO_BANCO, "MOVIMIENTO_BANCO", "Movimiento Banco", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_FLUJO, ">Traspasos", FO_TRASPASOS, "TRASPASO", "Traspasos", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_FLUJO, ">Gestión de Tesorería", FO_GESTION_TESO, "", "Gestión de Tesorería", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_FLUJO, ">Instrucciones", FO_INSTRUCCIONES, "INSTRUCCION", "Instrucciones", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_FLUJO, ">Flujo Diario", Nothing, "", "", 0, 0, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_FLUJO, ">Flujo Diario Global", FO_FLUJO_DIARIO, "MOVIMIENTO_FLUJO_DIARIO", "Flujo Diario Global", VG_ID_DB, 2, ">Flujo Diario"))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_FLUJO, ">Flujo Diario por Razón Social", FO_RESUMEN_FLUJO_DIARIO_X_RZS, "", "Flujo Diario por Razón Social", VG_ID_DB, 2, ">Flujo Diario"))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_FLUJO, ">Flujo Diario por Planta", FO_RESUMEN_FLUJO_DIARIO_X_UNO, "", "Flujo Diario por Planta", VG_ID_DB, 2, ">Flujo Diario"))
        PG_SUBMENU_CHECK_PERMISOS(VP_MENU_FLUJO, "VP_MENU_FLUJO")
        PP_SUBMENU_ADD_EVENT(VP_MENU_FLUJO, PB_SUBMENU5)

        Dim VP_MENU_GASTOS As New ContextMenuStrip()
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_GASTOS, ">Proveedores", FO_PROVEEDOR, "PROVEEDOR", "Proveedores", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_GASTOS, ">Facturas de Cuentas por Pagar", FO_FACTURA_CXP, "FACTURA_CXP", "Facturas de Cuentas por Pagar", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_GASTOS, ">Carga de Facturas XML", FO_FACTURA_CXP_XML, "FACTURA_CXP_XML", "Carga de Facturas XML", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_GASTOS, ">Antigüedad de Saldos", FO_ANTIGUEDAD_SALDOS, "", "Antigüedad de Saldos", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_GASTOS, ">Viaje", Nothing, "", "", 0, 0, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_GASTOS, ">Solicitud de Viaje", FO_VIAJE, "VIAJE", "Solicitud Viaje", VG_ID_DB, 2, ">Viaje"))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_GASTOS, ">Presupuesto Viaje", FO_PRESUPUESTO_VIAJE, "PRESUPUESTO_VIAJE", "Presupuesto Viaje", VG_ID_DB, 2, ">Viaje"))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_GASTOS, ">Gasto Viaje", FO_GASTO_VIAJE, "GASTO_VIAJE", "Gasto Viaje", VG_ID_DB, 2, ">Viaje"))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_GASTOS, ">Captura de Gasto Viaje", FO_GASTO_VIAJE_CAPTURA, "VIAJE", "Captura de Gasto Viaje", VG_ID_DB, 2, ">Viaje"))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_GASTOS, ">Carga de Facturas de Viaje", FO_FACTURA_GASTO_VIAJE_CAPTURA_XML, "VIATICO_XML", "Carga de Facturas de Viaje", VG_ID_DB, 2, ">Viaje"))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_GASTOS, ">Facturas de Viaje", FO_FACTURAS_GASTO_VIAJE, "VIATICO_XML", "Facturas de Viaje", VG_ID_DB, 2, ">Viaje"))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_GASTOS, ">Proveedor Viático", FO_PROVEEDOR_VIATICO, "PROVEEDOR_VIATICO", "Proveedor Viático", VG_ID_DB, 2, ">Viaje"))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_GASTOS, ">Recurso Viaje", FO_RECURSO_VIAJE, "RECURSO_VIAJE", "Recurso Viaje", VG_ID_DB, 2, ">Viaje"))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_GASTOS, ">Cuentas Contables", FO_CUENTA_CONTABLE, "CUENTA_CONTABLE", "Cuentas Contables", VG_ID_DB, 1, ""))
        PG_SUBMENU_CHECK_PERMISOS(VP_MENU_GASTOS, "VP_MENU_GASTOS")
        PP_SUBMENU_ADD_EVENT(VP_MENU_GASTOS, PB_SUBMENU6)

        Dim VP_MENU_CONFIGURACION As New ContextMenuStrip()
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_CONFIGURACION, ">Control Anual", Nothing, "", "", 0, 0, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_CONFIGURACION, ">Control Anual Global", FO_CONTROL_ANUAL, "CONTROL_X_MES", "Control Anual Global", VG_ID_DB, 2, ">Control Anual"))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_CONFIGURACION, ">Control Anual por Razón Social", FO_CONTROL_ANUAL_RAZON_SOCIAL, "CONTROL_X_MES_X_RAZON_SOCIAL", "Control Anual por Razón Social", VG_ID_DB, 2, ">Control Anual"))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_CONFIGURACION, ">Control Anual por Planta", FO_CONTROL_ANUAL_UNIDAD_OPERATIVA, "CONTROL_X_MES_X_UNIDAD_OPERATIVA", "Control Anual por Planta", VG_ID_DB, 2, ">Control Anual"))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_CONFIGURACION, ">Usuario-Planta", FO_DATA_ACCESO_UO, "DATA_ACCESO_UO", "Usuario-Planta", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_CONFIGURACION, ">Cuenta Bancaria-Planta", FO_CUENTA_BANCO_UO, "CUENTA_BANCO_UO", "Cuenta Bancaria-Planta", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_CONFIGURACION, ">Cuenta Bancaria-Planta Administración", FO_CUENTA_BANCO_UO_AS, "CUENTA_BANCO_UO", "Cuenta Bancaria-Planta Administración", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_CONFIGURACION, ">Cuenta Contable-Planta", FO_CUENTA_CONTABLE_UO, "CUENTA_CONTABLE_UO", "Cuenta Contable-Planta", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_CONFIGURACION, ">Accesos de Personal", FO_PERSONAL_ACCESO_ORGANIZACION, "PERSONAL_ACCESO_ORGANIZACION", "Accesos de Personal", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_CONFIGURACION, ">Asignación de Roles", FO_ROL_ASIGNACION, "ROL_ASIGNACION", "Asignación de Roles", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_CONFIGURACION, ">Autorizaciones", FO_AUTORIZACION, "AUTORIZACION", "Autorizaciones", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_CONFIGURACION, ">Firmas de Autorización", FO_FLUJO_FIRMA_X_K_USUARIO, "FLUJO_FIRMA_X_K_USUARIO", "Firmas de Autorización", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_CONFIGURACION, ">Monitoreo Firmas de Autorización", FO_MONITOREO_AUTORIZACION_FIRMA, "AUTORIZACION_FIRMA", "Monitoreo Firmas de Autorización", VG_ID_DB, 1, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_CONFIGURACION, ">Registro Dactilar", Nothing, "", "", VG_ID_DB, 0, ""))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_CONFIGURACION, ">Administración de Registro Dactilar", FO_REGISTRO_DACTILAR, "REGISTRO_DACTILAR", "Administración de Registro Dactilar", VG_ID_DB, 2, ">Registro Dactilar"))
        VM_DIRECTORIO.Add(New SUBMENU_FUNCION(Me, VP_MENU_CONFIGURACION, ">Validación Dactilar", FO_HUELLA, "REGISTRO_DACTILAR", "Validación Dactilar", VG_ID_DB, 2, ">Registro Dactilar"))
        PP_SUBMENU_ADD_EVENT(VP_MENU_CONFIGURACION, PB_SUBMENU8)

    End Sub
#End Region

#Region "EVENTOS DE LA FORMA"

    Public Sub PM_ABRIR(ByRef PP_FORMA As Object, ByRef PP_NOMBRE_TABLA As String, ByVal PP_TITULO_TABPAGE As String, ByVal PP_ID_BASE_DE_DATOS As String)
        Codigo_FRM.PG_FRM_ABRIR(Me, PP_FORMA, PP_NOMBRE_TABLA, PP_TITULO_TABPAGE, PP_ID_BASE_DE_DATOS)
    End Sub

    Private Sub UC_MENU2_Load() Handles MyBase.Load
        LL_MENU.Margin = New Padding(2, 0, 2, 0)
        LL_MENU.AutoSize = True
        Me.Cursor = Cursors.WaitCursor
        PM_INICIALIZAR_PB()
        Timer1.Enabled = True
        Timer1.Start()

    End Sub

    Private Sub PM_INICIALIZAR_PB()
        Dim VP_PB_ARRAY() As PictureBox = {PB_SUBMENU1, PB_SUBMENU2, PB_SUBMENU3,
                                            PB_SUBMENU4, PB_SUBMENU5, PB_SUBMENU6,
                                            PB_SUBMENU7, PB_SUBMENU8}
        For Each PB In VP_PB_ARRAY
            AddHandler PB.Paint, AddressOf PB_PAINT
        Next

    End Sub

    Private Function PB_PAINT(sender As Object, e As PaintEventArgs) As PaintEventHandler
        Dim VP_PARENT_COLOR As Color = sender.PARENT.BACKCOLOR
        Dim bBrush As SolidBrush = New SolidBrush(VP_PARENT_COLOR)
        Dim point1 As Point = New Point(0, 0)
        Dim point2 As Point = New Point(35, 0)
        Dim point3 As Point = New Point(0, 35)
        Dim curvePoints() As PointF = {point1, point2, point3}
        e.Graphics.FillPolygon(bBrush, curvePoints)
    End Function

    Private Sub LocationXY(sender As Object, e As EventArgs)
        Dim VP_CONTEXT_MENUSTRIP As ContextMenuStrip = sender.Tag
        Dim VP_POINT As New Point(sender.Width / 2, sender.Height / 2)
        VP_CONTEXT_MENUSTRIP.Show(sender.PointToScreen(VP_POINT))
    End Sub

    Public Sub PP_SUBMENU_ADD_EVENT(ByRef PP_CONTEXTMENUSTRIP As ContextMenuStrip, ByRef PP_PB_CUADRO_MENU As PictureBox)
        'PG_SUBMENU_CHECK_PERMISOS(PP_CONTEXTMENUSTRIP)
        AddHandler PP_CONTEXTMENUSTRIP.ItemClicked, AddressOf PG_VP_MENU_CLICK
        PP_PB_CUADRO_MENU.ContextMenuStrip = PP_CONTEXTMENUSTRIP
        PP_PB_CUADRO_MENU.Tag = PP_CONTEXTMENUSTRIP
        AddHandler PP_PB_CUADRO_MENU.Click, AddressOf LocationXY
    End Sub

    Public Sub PG_SUBMENU_CHECK_PERMISOS(ByRef PP_CONTEXTMENUSTRIP As ContextMenuStrip, ByRef PP_NOMBRE_GRUPO As String)
        Dim VP_DATATABLE As DataTable = Codigo_Permiso.FG_CONSULTAR_PERMISOS(VG_ID_DB, PP_NOMBRE_GRUPO, VG_USUARIO_ACCION)
        Dim VP_SUBMENU_COLLECTION As ToolStripItemCollection = PP_CONTEXTMENUSTRIP.Items

        Dim VP_LISTA_ToolStripItem As New List(Of ToolStripItem)
        For Each VP_ITEM_SUBMENU In VP_SUBMENU_COLLECTION
            VP_LISTA_ToolStripItem.Add(VP_ITEM_SUBMENU)
        Next

        For VP_I As Integer = 0 To PP_CONTEXTMENUSTRIP.Items.Count - 1 Step 1
            Dim VP_MENUITEM As ToolStripMenuItem = PP_CONTEXTMENUSTRIP.Items.Item(VP_I)
            If VP_MENUITEM.DropDownItems.Count > 0 Then
                Try
                    Dim VP_SUBMENU_COLLECTION_DROPDOWN As ToolStripItemCollection = VP_MENUITEM.DropDownItems
                    For Each VP_ITEM_SUBMENU In VP_SUBMENU_COLLECTION_DROPDOWN
                        VP_LISTA_ToolStripItem.Add(VP_ITEM_SUBMENU)
                    Next
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Next

        For Each VP_ROW As DataRow In VP_DATATABLE.Rows
            Dim VP_SUBMENU_ACTUAL As ToolStripMenuItem = Nothing
            Dim VP_INDICE_ACTUAL As Integer = 0

            For Each VP_ITEM_LISTA As ToolStripMenuItem In VP_LISTA_ToolStripItem
                If VP_ITEM_LISTA.Text = VP_ROW(5) Then
                    VP_SUBMENU_ACTUAL = VP_ITEM_LISTA
                End If
            Next

            While VP_SUBMENU_ACTUAL Is Nothing And VP_INDICE_ACTUAL < VP_LISTA_ToolStripItem.Count
                If VP_LISTA_ToolStripItem.Item(VP_INDICE_ACTUAL).Text = VP_ROW(5) Then
                    VP_SUBMENU_ACTUAL = VP_SUBMENU_COLLECTION.Item(VP_INDICE_ACTUAL)
                End If
                VP_INDICE_ACTUAL += 1
            End While
            If VP_SUBMENU_ACTUAL Is Nothing Then
                Codigo_Message.PG_MENSAJE_AVISO("No se encontró el menú " + VP_ROW(5) + ", favor de revisar el nombre del permiso")
            Else
                VP_SUBMENU_ACTUAL.Enabled = Convert.ToBoolean(VP_ROW(3))
                VP_SUBMENU_ACTUAL.Visible = Convert.ToBoolean(VP_ROW(2))
            End If
        Next

    End Sub

#End Region

#Region "MENU_CLICK"

    Public Sub PG_VP_MENU_CLICK(sender As Object, e As ToolStripItemClickedEventArgs)
        Dim CM_MENU As ContextMenuStrip = sender
        Dim TT_TEXT As String = e.ClickedItem.Text
        Dim VP_SUBMENU_FUNCION As SUBMENU_FUNCION = VM_DIRECTORIO.Where(Function(X) X.VM_CONTEXTMENUSTRIP1.Name = CM_MENU.Name And X.VM_SUBMENU_TEXT1 = TT_TEXT).FirstOrDefault()
        If VP_SUBMENU_FUNCION.VM_NIVEL1 = 1 Then
            PM_ABRIR(VP_SUBMENU_FUNCION.VM_FORMA1, VP_SUBMENU_FUNCION.VM_NOMBRE_TABLA1, VP_SUBMENU_FUNCION.VM_TITULO_TABPAGE1, VP_SUBMENU_FUNCION.VM_ID_BASE_DE_DATOS1)
        End If
    End Sub

    Private Sub PB_SUBMENU1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If VM_MENU_CARGADO = False Then
            VM_MENU_CARGADO = True
            PM_CARGAR_MENU()
            Cursor = Cursors.Default
            Timer1.Stop()
            Timer1.Enabled = False
            'PM_VERIFICAR_PENDIENTES(Me) 'AX //  Verificar Estatus Pendientes de Flujo Firma
        End If
    End Sub

    Public Sub PM_VERIFICAR_PENDIENTES(ByRef PP_FORMA As Object) 'AX //  Verificar Estatus Pendientes de Flujo Firma
        Dim VP_PARAMETROS As String = ""
        Dim VP_CLAVE, VP_MENSAJE As String
        Dim VP_RESULTADO As Integer

        Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VG_ID_DB, PP_FORMA, "PG_RN_FLUJO_FIRMA_PENDIENTES_AUTORIZAR", VP_PARAMETROS, VP_CLAVE, VP_MENSAJE)

        If VP_MENSAJE = "" Then
            'VP_MENSAJE = ""    'AX //  Si no hay pendientes, no se muestra al usuario mensaje alguno.
        Else
            VP_RESULTADO = Codigo_Message.FG_MENSAJE_DECISION_SINO(VP_MENSAJE + Environment.NewLine + "¿Desea hacerlo ahora mismo?")
        End If

        Select Case VP_RESULTADO
            Case 1 'yes/si
                Codigo_FRM.PG_FRM_ABRIR(Me, FO_FLUJO_FIRMA_X_K_USUARIO, "FLUJO_FIRMA_X_K_USUARIO", "Firmas de Autorización", VG_ID_DB)
            Case 2 'no

        End Select
    End Sub
    'AX   //   PARA ENVIAR A LAURA   //   20181113   //  FIN
#End Region

End Class

Public Class SUBMENU_FUNCION
    Dim VM_CONTEXTMENUSTRIP As ContextMenuStrip
    Dim VM_SUBMENU_TEXT As String
    Dim VM_FORMA As Object
    Dim VM_NOMBRE_TABLA As String
    Dim VM_TITULO_TABPAGE As String
    Dim VM_ID_BASE_DE_DATOS As String
    Dim VM_NIVEL As Integer
    Dim VM_MENU_PADRE As String
    Dim VM_FORMA_PADRE As Object


    Public Sub New(ByRef PP_FORMA_PADRE As Object, ByRef PP_CONTEXTMENUSTRIP As ContextMenuStrip, ByRef PP_SUBMENU_TEXT As String, ByRef PP_FORMA As Object,
                   ByRef PP_NOMBRE_TABLA As String, ByRef PP_TITULO_TABPAGE As String, ByRef PP_ID_BASE_DE_DATOS As String,
                   ByVal PP_NIVEL As Integer, ByVal PP_MENU_PADRE As String)
        Me.VM_FORMA_PADRE = PP_FORMA_PADRE
        Me.VM_CONTEXTMENUSTRIP1 = PP_CONTEXTMENUSTRIP
        Me.VM_SUBMENU_TEXT1 = PP_SUBMENU_TEXT
        Me.VM_FORMA1 = PP_FORMA
        Me.VM_NOMBRE_TABLA1 = PP_NOMBRE_TABLA
        Me.VM_TITULO_TABPAGE1 = PP_TITULO_TABPAGE
        Me.VM_ID_BASE_DE_DATOS1 = PP_ID_BASE_DE_DATOS
        Me.VM_NIVEL1 = PP_NIVEL
        Me.VM_MENU_PADRE1 = PP_MENU_PADRE
        'Dim VP_NOMBRE_GRUPO As String = Right(PP_CONTEXTMENUSTRIP.Name, PP_CONTEXTMENUSTRIP.Name.Length - 3)

        If VM_NIVEL1 < 2 Then
            PP_CONTEXTMENUSTRIP.Items.Add(PP_SUBMENU_TEXT)
            'Dim VP_SUBMENU_ITEM As ToolStripMenuItem = PP_CONTEXTMENUSTRIP.Items.Find(PP_SUBMENU_TEXT, True).FirstOrDefault()
            'VP_SUBMENU_ITEM.Enabled = 'Convert.ToBoolean(VP_RESULTADO(3))

        End If
        If VM_NIVEL1 = 2 Then
            Dim VP_SUBMENUPADRE_COLLECTION = PP_CONTEXTMENUSTRIP.Items
            Dim VP_SUBMENUPADRE As ToolStripMenuItem = Nothing
            Dim VP_INDICE As Integer = 0
            While VP_SUBMENUPADRE Is Nothing
                If VP_SUBMENUPADRE_COLLECTION.Item(VP_INDICE).Text = PP_MENU_PADRE Then
                    VP_SUBMENUPADRE = VP_SUBMENUPADRE_COLLECTION.Item(VP_INDICE)
                    VP_SUBMENUPADRE.DropDownItems.Add(PP_SUBMENU_TEXT)
                    AddHandler VP_SUBMENUPADRE.DropDownItemClicked, AddressOf PG_VP_SUBMENU_ITEM_CLICK
                End If
                VP_INDICE += 1
            End While
        End If


    End Sub

    Private Sub PG_VP_SUBMENU_ITEM_CLICK(sender As Object, e As ToolStripItemClickedEventArgs)
        Dim VP_ITEM_TEXT As String = e.ClickedItem.Text
        If VP_ITEM_TEXT = VM_SUBMENU_TEXT1 Then
            PM_ABRIR(VM_FORMA1, VM_NOMBRE_TABLA1, VM_TITULO_TABPAGE1, VM_ID_BASE_DE_DATOS1)
        End If
    End Sub

    Public Sub PM_ABRIR(ByRef PP_FORMA As Object, ByRef PP_NOMBRE_TABLA As String, ByVal PP_TITULO_TABPAGE As String, ByVal PP_ID_BASE_DE_DATOS As String)
        Codigo_FRM.PG_FRM_ABRIR(VM_FORMA_PADRE, PP_FORMA, PP_NOMBRE_TABLA, PP_TITULO_TABPAGE, PP_ID_BASE_DE_DATOS)
    End Sub

    Public Property VM_CONTEXTMENUSTRIP1 As ContextMenuStrip
        Get
            Return VM_CONTEXTMENUSTRIP
        End Get
        Set(value As ContextMenuStrip)
            VM_CONTEXTMENUSTRIP = value
        End Set
    End Property

    Public Property VM_SUBMENU_TEXT1 As String
        Get
            Return VM_SUBMENU_TEXT
        End Get
        Set(value As String)
            VM_SUBMENU_TEXT = value
        End Set
    End Property

    Public Property VM_FORMA1 As Object
        Get
            Return VM_FORMA
        End Get
        Set(value As Object)
            VM_FORMA = value
        End Set
    End Property

    Public Property VM_NOMBRE_TABLA1 As String
        Get
            Return VM_NOMBRE_TABLA
        End Get
        Set(value As String)
            VM_NOMBRE_TABLA = value
        End Set
    End Property

    Public Property VM_TITULO_TABPAGE1 As String
        Get
            Return VM_TITULO_TABPAGE
        End Get
        Set(value As String)
            VM_TITULO_TABPAGE = value
        End Set
    End Property

    Public Property VM_ID_BASE_DE_DATOS1 As String
        Get
            Return VM_ID_BASE_DE_DATOS
        End Get
        Set(value As String)
            VM_ID_BASE_DE_DATOS = value
        End Set
    End Property

    Public Property VM_NIVEL1 As Integer
        Get
            Return VM_NIVEL
        End Get
        Set(value As Integer)
            VM_NIVEL = value
        End Set
    End Property

    Public Property VM_MENU_PADRE1 As String
        Get
            Return VM_MENU_PADRE
        End Get
        Set(value As String)
            VM_MENU_PADRE = value
        End Set
    End Property
End Class
