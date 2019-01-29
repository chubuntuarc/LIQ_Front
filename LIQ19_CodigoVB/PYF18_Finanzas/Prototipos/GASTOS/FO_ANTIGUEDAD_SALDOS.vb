Public Class FO_ANTIGUEDAD_SALDOS

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0

#End Region

#Region "VARIABLES LOCALES"

    Dim VL_HOY As Date = Now.ToString("dd/MM/yyyy")
    Dim VL_DESC_TOTALES As String : Dim VL_TITULO As String = "Razón Social" : Dim VL_TIPO_VISTA_DATOS As Integer
    Dim VL_VENCIDO_TOTAL, VL_VIGENTE_TOTAL, VL_VENCIDO_MAS_DE_120 As Decimal
    Dim VL_VENCIDO_091_A_120, VL_VENCIDO_061_A_090, VL_VENCIDO_031_A_060 As Decimal
    Dim VL_VENCIDO_001_A_030, VL_VIGENTE_000_HASTA_030, VL_VIGENTE_031_HASTA_060 As Decimal
    Dim VL_VIGENTE_061_HASTA_090, VL_VIGENTE_091_HASTA_120, VL_VIGENTE_MAYOR_A_121 As Decimal

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        PM_LI_VALIDAR_RD()
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VL_TIPO_VISTA_DATOS, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_CATEGORIA_PROVEEDOR, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_RAZON_SOCIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_F_INICIAL, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_F_FINAL, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, "NULL", False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_L_CAPTURA As Integer = 1
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_MOVIMIENTO_BANCO.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_MOVIMIENTO_BANCO, False)
            PP_NUEVO = False
        End If

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_TIPO_MOVIMIENTO_BANCO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_FORMA_MOVIMIENTO_BANCO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CIE_CLIENTE, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_CUENTA_BANCO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_F_OPERACION, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_F_LIQ, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_COD_DESCRIPCION, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_REFERENCIA, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MONTO_MOVIMIENTO, False)

        Return VP_PARAMETROS
    End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "COD_DESCRIPCION")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_MOVIMIENTO_BANCO")
        Return VP_ID
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean

        Codigo_FI.PG_FI_FIELDS_VALIDATE(GB_FICHA, VP_VALIDACION, PP_MENSAJE_VALIDACION)
        Codigo_CTRL.PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, TB_MONTO_MOVIMIENTO)
        Codigo_CTRL.PG_TB_DATE_VALIDATE(PP_MENSAJE_VALIDACION, TB_F_OPERACION)
        Codigo_CTRL.PG_TB_DATE_VALIDATE(PP_MENSAJE_VALIDACION, TB_F_LIQ)

        VP_VALIDACION = (PP_MENSAJE_VALIDACION = "")
        Return VP_VALIDACION
    End Function

#End Region

#Region "SUB_PM_INIT"

    Public Sub PM_FO_SHOW(ByRef PP_NOMBRE_TABLA As String, ByVal PP_ID_BASE_DE_DATOS As String)
        VM_NOMBRE_TABLA = PP_NOMBRE_TABLA
        VM_ID_BASE_DE_DATOS = PP_ID_BASE_DE_DATOS
        Me.Show()
    End Sub

    Public Sub PM_CB_INIT()
        Codigo_FI.PG_FI_CONTROL_DATA_SETUP(VM_ID_BASE_DE_DATOS, Me)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_CATEGORIA_PROVEEDOR, "CATEGORIA_PROVEEDOR")
        Codigo_CB.PG_CB_RAZON_SOCIAL_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_RAZON_SOCIAL, 1, New ComboBox, New ComboBox, VG_USUARIO_ACCION)
    End Sub

    Public Sub PM_LI_INIT()
        PM_RESET_VARIABLES_LOCALES()
        PM_LI_FORMAT(LI_LISTADO)
    End Sub

    Public Sub PM_RESET_VARIABLES_LOCALES()
        VL_DESC_TOTALES = ""
        VL_VENCIDO_TOTAL = 0 : VL_VIGENTE_TOTAL = 0 : VL_VENCIDO_MAS_DE_120 = 0
        VL_VENCIDO_091_A_120 = 0 : VL_VENCIDO_061_A_090 = 0 : VL_VENCIDO_031_A_060 = 0
        VL_VENCIDO_001_A_030 = 0 : VL_VIGENTE_000_HASTA_030 = 0 : VL_VIGENTE_031_HASTA_060 = 0
        VL_VIGENTE_061_HASTA_090 = 0 : VL_VIGENTE_091_HASTA_120 = 0 : VL_VIGENTE_MAYOR_A_121 = 0
    End Sub

    Public Sub PM_LI_VALIDAR_RD()
        If RD_LI_PROVEEDOR.Checked Then
            VL_TIPO_VISTA_DATOS = 1
            VL_TITULO = "Proveedor"
        ElseIf RD_LI_RAZON_SOCIAL.Checked Then
            VL_TIPO_VISTA_DATOS = 2
            VL_TITULO = "Razón Social"
        ElseIf RD_LI_UNIDAD_OPERATIVA.Checked Then
            VL_TIPO_VISTA_DATOS = 3
            VL_TITULO = "Unidad Operativa"
        End If
    End Sub

    Public Sub PM_RD_INIT()
        RD_LI_PROVEEDOR.Checked = False : RD_LI_RAZON_SOCIAL.Checked = True : RD_LI_UNIDAD_OPERATIVA.Checked = False
    End Sub

    Public Sub PM_DT_INIT()
        TB_LI_F_INICIAL.Text = Codigo_ABC.FG_DT_CONVIERTE_FECHA_US_A_MX(VL_HOY.AddDays(-7))
        TB_LI_F_FINAL.Text = Codigo_ABC.FG_DT_CONVIERTE_FECHA_US_A_MX(VL_HOY)
        TB_F_OPERACION.Text = Codigo_ABC.FG_DT_CONVIERTE_FECHA_US_A_MX(VL_HOY)
        TB_F_LIQ.Text = Codigo_ABC.FG_DT_CONVIERTE_FECHA_US_A_MX(VL_HOY)
    End Sub

    Private Sub PM_FO_INIT(ByRef PP_FORMA As Object)
        Codigo_FRM.PG_FRM_INIT(VM_ID_BASE_DE_DATOS, PP_FORMA)
    End Sub

#End Region

#Region "SUBS_PM"

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)]
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "VI_D_NOMBRE", VL_TITULO, GetType(String), 200, 1, 0, 1, 1, 0, Color.Orange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "VI_VENCIDO_TOTAL", "Vencido Total", GetType(Decimal), 80, 3, 0, 1, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "VI_VIGENTE_TOTAL", "Vigente Total", GetType(Decimal), 80, 3, 0, 1, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "VI_VENCIDO_MAS_DE_120", "Vencido 120 +", GetType(Decimal), 80, 3, 0, 1, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "VI_VENCIDO_091_A_120", "Vencido 91-120", GetType(Decimal), 80, 3, 0, 1, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "VI_VENCIDO_061_A_090", "Vencido 61-90", GetType(Decimal), 80, 3, 0, 1, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "VI_VENCIDO_031_A_060", "Vencido 31-60", GetType(Decimal), 80, 3, 0, 1, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "VI_VENCIDO_001_A_030", "Vencido 1-30", GetType(Decimal), 80, 3, 0, 1, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "VI_VIGENTE_000_HASTA_030", "Vigente 0-30", GetType(Decimal), 80, 3, 0, 1, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "VI_VIGENTE_031_HASTA_060", "Vigente 31-60", GetType(Decimal), 80, 3, 0, 1, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "VI_VIGENTE_061_HASTA_090", "Vigente 61-90", GetType(Decimal), 80, 3, 0, 1, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "VI_VIGENTE_091_HASTA_120", "Vigente 91-120", GetType(Decimal), 80, 3, 0, 1, 0, 2)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "VI_VIGENTE_MAYOR_A_121", "Vigente 121 +", GetType(Decimal), 80, 3, 0, 1, 0, 2)
    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "VI_D_NOMBRE")
        VL_DESC_TOTALES = "Totales"

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "VI_VENCIDO_TOTAL")
        VL_VENCIDO_TOTAL = VL_VENCIDO_TOTAL + Convert.ToDecimal(Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, VP_ROW, "VI_VENCIDO_TOTAL"))

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "VI_VIGENTE_TOTAL")
        VL_VIGENTE_TOTAL = VL_VIGENTE_TOTAL + Convert.ToDecimal(Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, VP_ROW, "VI_VIGENTE_TOTAL"))

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "VI_VENCIDO_MAS_DE_120")
        VL_VENCIDO_MAS_DE_120 = VL_VENCIDO_MAS_DE_120 + Convert.ToDecimal(Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, VP_ROW, "VI_VENCIDO_MAS_DE_120"))

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "VI_VENCIDO_091_A_120")
        VL_VENCIDO_091_A_120 = VL_VENCIDO_091_A_120 + Convert.ToDecimal(Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, VP_ROW, "VI_VENCIDO_091_A_120"))

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "VI_VENCIDO_061_A_090")
        VL_VENCIDO_061_A_090 = VL_VENCIDO_061_A_090 + Convert.ToDecimal(Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, VP_ROW, "VI_VENCIDO_061_A_090"))

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "VI_VENCIDO_031_A_060")
        VL_VENCIDO_031_A_060 = VL_VENCIDO_031_A_060 + Convert.ToDecimal(Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, VP_ROW, "VI_VENCIDO_031_A_060"))

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "VI_VENCIDO_001_A_030")
        VL_VENCIDO_001_A_030 = VL_VENCIDO_001_A_030 + Convert.ToDecimal(Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, VP_ROW, "VI_VENCIDO_001_A_030"))

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "VI_VIGENTE_000_HASTA_030")
        VL_VIGENTE_000_HASTA_030 = VL_VIGENTE_000_HASTA_030 + Convert.ToDecimal(Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, VP_ROW, "VI_VIGENTE_000_HASTA_030"))

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "VI_VIGENTE_031_HASTA_060")
        VL_VIGENTE_031_HASTA_060 = VL_VIGENTE_031_HASTA_060 + Convert.ToDecimal(Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, VP_ROW, "VI_VIGENTE_031_HASTA_060"))

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "VI_VIGENTE_061_HASTA_090")
        VL_VIGENTE_061_HASTA_090 = VL_VIGENTE_061_HASTA_090 + Convert.ToDecimal(Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, VP_ROW, "VI_VIGENTE_061_HASTA_090"))

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "VI_VIGENTE_091_HASTA_120")
        VL_VIGENTE_091_HASTA_120 = VL_VIGENTE_091_HASTA_120 + Convert.ToDecimal(Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, VP_ROW, "VI_VIGENTE_091_HASTA_120"))

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "VI_VIGENTE_MAYOR_A_121")
        VL_VIGENTE_MAYOR_A_121 = VL_VIGENTE_MAYOR_A_121 + Convert.ToDecimal(Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, VP_ROW, "VI_VIGENTE_MAYOR_A_121"))
    End Sub

    Public Sub PM_LI_AGREGAR_FILA_TOTALES(ByVal PP_LISTADO As DataGridView)
        PP_LISTADO.Rows.Add(VL_DESC_TOTALES, VL_VENCIDO_TOTAL, VL_VIGENTE_TOTAL, VL_VENCIDO_MAS_DE_120, VL_VENCIDO_091_A_120, VL_VENCIDO_061_A_090, VL_VENCIDO_031_A_060,
                            VL_VENCIDO_001_A_030, VL_VIGENTE_000_HASTA_030, VL_VIGENTE_031_HASTA_060, VL_VIGENTE_061_HASTA_090, VL_VIGENTE_091_HASTA_120, VL_VIGENTE_MAYOR_A_121)
        For i As Integer = 0 To PP_LISTADO.Rows(0).Cells.Count - 1
            PP_LISTADO.Rows(PP_LISTADO.Rows.Count - 1).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleRight
            PP_LISTADO.Rows(PP_LISTADO.Rows.Count - 1).Cells(i).Style.Font = New Font("Arial", 8, FontStyle.Bold)
            PP_LISTADO.Rows(PP_LISTADO.Rows.Count - 1).Cells(i).Style.BackColor = Color.Black
            PP_LISTADO.Rows(PP_LISTADO.Rows.Count - 1).Cells(i).Style.ForeColor = Color.White
        Next
    End Sub

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        PM_LI_VALIDAR_RD()
        PM_LI_FORMAT(LI_LISTADO)
        Codigo_ABC.PG_BT_BUSCAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO, "[PG_RP_001_ANTIGUEDAD_SALDOS]")
        PM_LI_AGREGAR_FILA_TOTALES(PP_LISTADO)
        PM_RESET_VARIABLES_LOCALES()
    End Sub

    Private Sub PM_BT_AGREGAR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_AGREGAR_CLICK(PP_FORMA)
    End Sub

    Private Sub PM_BT_CANCELAR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_CANCELAR_CLICK(PP_FORMA)
    End Sub

    Private Sub PM_BT_SALIR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_SALIR_CLICK(PP_FORMA)
    End Sub

    Private Sub PM_BT_EDITAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_EDITAR_CLICK(PP_FORMA, PP_LISTADO)
    End Sub

    Public Sub PM_BT_GUARDAR_CLICK(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
         Codigo_ABC.PG_BT_GUARDAR_CLICK(VM_ID_BASE_DE_DATOS,PP_FORMA, PP_LISTADO)
    End Sub

    Public Sub PM_BT_ELIMINAR_CLICK(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_ELIMINAR_CLICK(VM_ID_BASE_DE_DATOS,PP_FORMA, PP_LISTADO)
    End Sub

    Private Sub PM_TI_TICK(ByRef PP_LABEL As Label)
        Codigo_FRM.PG_TI_TICK(PP_LABEL)
    End Sub

    Private Sub PM_BT_LISTADO_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_LISTADO_CLICK(PP_FORMA)
    End Sub

    Private Sub PM_BT_EXPORTAR_EXCEL_CLICK(ByRef PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_EXPORTAR_EXCEL_CLICK(PP_LISTADO)
    End Sub

    Public Sub PM_LI_SAVE(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        PM_BT_BUSCAR_CLICK(PP_FORMA, PP_LISTADO)
    End Sub

#End Region

#Region "EVENTOS"

    Private Sub Catalogo_T1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT(Me)
    End Sub

    Private Sub BT_AGREGAR_Click(sender As Object, e As EventArgs) Handles BT_AGREGAR.Click
        PM_BT_AGREGAR_CLICK(Me)
    End Sub

    Private Sub BT_BUSCAR_Click(sender As Object, e As EventArgs) Handles BT_LI_BUSCAR.Click
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub BT_CANCELAR_Click(sender As Object, e As EventArgs) Handles BT_CANCELAR.Click
        PM_BT_CANCELAR_CLICK(Me)
    End Sub

    Private Sub BT_SALIR_Click(sender As Object, e As EventArgs) Handles BT_SALIR.Click
        PM_BT_SALIR_CLICK(Me)
    End Sub

    Private Sub BT_GUARDAR_Click(sender As Object, e As EventArgs) Handles BT_GUARDAR.Click
        PM_BT_GUARDAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub BT_EDITAR_Click(sender As Object, e As EventArgs) Handles BT_EDITAR.Click
        PM_BT_EDITAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub BT_ELIMINAR_Click(sender As Object, e As EventArgs) Handles BT_ELIMINAR.Click
        PM_BT_ELIMINAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub TI_RELOJ_Tick(sender As Object, e As EventArgs) Handles TI_RELOJ.Tick
        PM_TI_TICK(LB_RELOJ)
    End Sub

    Private Sub BT_LISTADO_Click(sender As Object, e As EventArgs) Handles BT_LISTADO.Click
        PM_BT_LISTADO_CLICK(Me)
    End Sub

    Private Sub BT_EXPORTAR_EXCEL_Click(sender As Object, e As EventArgs) Handles BT_EXPORTAR_EXCEL.Click
        PM_BT_EXPORTAR_EXCEL_CLICK(LI_LISTADO)
    End Sub

#End Region

End Class