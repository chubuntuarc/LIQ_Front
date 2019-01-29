Public Class FO_FLUJO_DIARIO

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_ID_VERSION As Integer = 0

#End Region

#Region "VARIABLES LOCALES"

    Dim VL_HOY As Date = Now.ToString("dd/MM/yyyy")
    Dim VL_AYER As Date = Now.AddDays(-1).ToString("dd/MM/yyyy")

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIPO_MOVIMIENTO_FLUJO_DIARIO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESTATUS_MOVIMIENTO_FLUJO_DIARIO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_RUBRO_FLUJO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ZONA_UO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_RAZON_SOCIAL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_F_INICIAL, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_F_FINAL, True)
        Return VP_PARAMETROS
    End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "REFERENCIA_1")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_MOVIMIENTO_FLUJO_DIARIO")
        Return VP_ID
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
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_TIPO_MOVIMIENTO_FLUJO_DIARIO)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_ESTATUS_MOVIMIENTO_FLUJO_DIARIO)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_RUBRO_FLUJO)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_TIPO_RAZON_SOCIAL)
        Codigo_CB.PG_CB_RAZON_SOCIAL_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_RAZON_SOCIAL, 1, New ComboBox, CB_LI_TIPO_RAZON_SOCIAL, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_ZONA_UO_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_ZONA_UO, VG_USUARIO_ACCION)
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 1, CB_LI_ZONA_UO, CB_LI_RAZON_SOCIAL, VG_USUARIO_ACCION)
    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
    End Sub

    Public Sub PM_CH_INIT()
        CH_REFERENCIAS.Checked = True : CH_CARGOS.Checked = False : CH_CONTROL.Checked = False
    End Sub

    Public Sub PM_DT_INIT()
        PM_FECHAS_FILTRO_SEMANA()
    End Sub

    Private Sub PM_FO_INIT(ByRef PP_FORMA As Object)
        Codigo_FRM.PG_FRM_INIT(VM_ID_BASE_DE_DATOS, PP_FORMA)
    End Sub

#End Region

#Region "SUBS_PM"

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Dim VP_REF, VP_CAR, VP_CON As Integer
        VP_REF = Codigo_CTRL.FG_CO_VALUE(CH_REFERENCIAS) : VP_CAR = Codigo_CTRL.FG_CO_VALUE(CH_CARGOS) : VP_CON = Codigo_CTRL.FG_CO_VALUE(CH_CONTROL)

        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)]
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_MOVIMIENTO_FLUJO_DIARIO", "#MFD", GetType(Integer), 80, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_RAZON_SOCIAL", "Razón Social", GetType(String), 80, 1, 0, 1, 1, 0, Nothing, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_UNIDAD_OPERATIVA", "Oficina", GetType(String), 80, 1, 0, 1, 1, 0, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ESTATUS_MOVIMIENTO_FLUJO_DIARIO", "Estatus", GetType(String), 80, 2, 0, 1, 1, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_RUBRO_FLUJO", "Rubro", GetType(String), 135, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_TIPO_MOVIMIENTO_FLUJO_DIARIO", "Tipo", GetType(String), 60, 2, 0, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_TIPO_MOVIMIENTO_FLUJO_DIARIO", "Nivel", GetType(String), 40, 2, 0, 0, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_MOVIMIENTO_FLUJO_DIARIO_DDMMMYYYY", "Fecha", GetType(Date), 100, 2, 0, 1, 0, 0, Color.Orange, Nothing, 1)
        ' REFERENCIAS
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "BENEFICIARIO", "Beneficiario", GetType(String), 200, 1, 0, VP_REF, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "REFERENCIA_1", "Referencia 1", GetType(String), 250, 1, 0, VP_REF, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "MONTO", "Monto", GetType(Decimal), 80, 3, 0, VP_REF, 0, 1, Nothing, Color.LightYellow, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "REFERENCIA_2", "Referencia 2", GetType(String), 350, 1, 0, VP_REF, 0, 0)
        ' CARGOS
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "CARGO", "Cargo", GetType(Decimal), 80, 3, 0, VP_CAR, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "ABONO", "Abono", GetType(Decimal), 80, 3, 0, VP_CAR, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "SALDO_FINAL", "Saldo", GetType(Decimal), 80, 3, 0, VP_CAR, 0, 1, Nothing, Color.LightYellow, 0)
        ' CONTROL
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "F_DOCUMENTO_DDMMMYYYY", "Fecha Doc", GetType(Date), 100, 2, 0, VP_CON, 0, 0, Color.Orange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_INSTRUCCION", "#INS", GetType(Integer), 60, 2, 0, VP_CON, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_FACTURA_CXP", "#CXP", GetType(Integer), 80, 2, 0, VP_CON, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_TRASPASO", "#TRA", GetType(Integer), 80, 2, 0, VP_CON, 0, 0, Color.White, Color.Black, 1)
    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0 : Dim VP_ROW, VP_TIPO As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        VP_TIPO = Codigo_LI.FG_LI_CELL_READ_RUNTIME(PP_ROW_DATA, "K_TIPO_MOVIMIENTO_FLUJO_DIARIO")

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_MOVIMIENTO_FLUJO_DIARIO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_RAZON_SOCIAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_ESTATUS_MOVIMIENTO_FLUJO_DIARIO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_RUBRO_FLUJO")

        If VP_TIPO > 0 Then
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "S_TIPO_MOVIMIENTO_FLUJO_DIARIO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_TIPO_MOVIMIENTO_FLUJO_DIARIO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_MOVIMIENTO_FLUJO_DIARIO_DDMMMYYYY")
            ' REFERENCIAS
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "BENEFICIARIO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "REFERENCIA_1")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MONTO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "REFERENCIA_2")
            ' CARGOS
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CERO_VACIO(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CARGO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CERO_VACIO(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "ABONO")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "SALDO_FINAL")
            ' CONTROL
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "F_DOCUMENTO_DDMMMYYYY")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_INSTRUCCION")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_FACTURA_CXP")
            Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_TRASPASO")

            Dim VP_COL As Integer = PP_LISTADO.Rows(VP_ROW).Cells("D_RUBRO_FLUJO").ColumnIndex
            Dim VP_BOLD As Font = New Font("Arial", 8, FontStyle.Bold)
            If VP_TIPO = 4 Then
                PP_LISTADO.Rows(VP_ROW).DefaultCellStyle.BackColor = Color.Gainsboro
                PP_LISTADO.Rows(VP_ROW).DefaultCellStyle.ForeColor = Color.Black
                PP_LISTADO.Rows(VP_ROW).DefaultCellStyle.Font = VP_BOLD
                PM_QUITAR_FECHAS(PP_LISTADO, VP_ROW)
            ElseIf VP_TIPO = 3 Then
                For i As Integer = 0 To PP_LISTADO.Columns.Count - 1
                    If i >= VP_COL Then
                        PP_LISTADO.Rows(VP_ROW).Cells(i).Style.BackColor = Color.LightYellow
                        PP_LISTADO.Rows(VP_ROW).Cells(i).Style.Font = VP_BOLD
                    End If
                Next
                PM_QUITAR_FECHAS(PP_LISTADO, VP_ROW)
            ElseIf VP_TIPO = 5 Then
                For i As Integer = 0 To PP_LISTADO.Columns.Count - 1
                    If i >= VP_COL Then
                        PP_LISTADO.Rows(VP_ROW).Cells(i).Style.BackColor = Color.Black
                        PP_LISTADO.Rows(VP_ROW).Cells(i).Style.ForeColor = Color.White
                        PP_LISTADO.Rows(VP_ROW).Cells(i).Style.Font = VP_BOLD
                    End If
                Next
                PM_QUITAR_FECHAS(PP_LISTADO, VP_ROW)
            End If
        Else
            For i As Integer = 0 To PP_LISTADO.Columns.Count - 1
                If i >= (VP_COLUMNA - 1) Then
                    PP_LISTADO.Rows(VP_ROW).Cells(i).Style.BackColor = Color.DarkOrange
                    PP_LISTADO.Rows(VP_ROW).Cells(i).Style.ForeColor = Color.White
                End If
            Next
        End If
        Codigo_LI.PG_LI_CELL_FONT_PROPERTIES_RUNTIME(PP_LISTADO.Rows(VP_ROW), "D_RUBRO_FLUJO", VP_TIPO, "PFD")
    End Sub

    Public Sub PM_QUITAR_FECHAS(ByRef PP_LISTADO As DataGridView, ByVal PP_ROW As Integer)
        PP_LISTADO.Rows(PP_ROW).Cells("F_MOVIMIENTO_FLUJO_DIARIO_DDMMMYYYY").Value = ""
        PP_LISTADO.Rows(PP_ROW).Cells("F_DOCUMENTO_DDMMMYYYY").Value = ""
    End Sub

    Public Sub PM_FECHAS_FILTRO_SEMANA()
        TB_LI_F_INICIAL.Text = VL_HOY.AddDays(-7)
        TB_LI_F_FINAL.Text = VL_HOY
    End Sub

    Public Sub PM_FECHAS_FILTRO_HOY()
        TB_LI_F_INICIAL.Text = VL_HOY
        TB_LI_F_FINAL.Text = VL_HOY
    End Sub

    Public Sub PM_FECHAS_FILTRO_AYER()
        TB_LI_F_INICIAL.Text = VL_AYER
        TB_LI_F_FINAL.Text = VL_AYER
    End Sub

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        PM_LI_FORMAT(LI_LISTADO)
        Codigo_ABC.PG_BT_BUSCAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
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
        Codigo_ABC.PG_BT_GUARDAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
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

    Private Sub BT_HOY_Click(sender As Object, e As EventArgs) Handles BT_HOY.Click
        PM_FECHAS_FILTRO_HOY()
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub BT_AYER_Click(sender As Object, e As EventArgs) Handles BT_AYER.Click
        PM_FECHAS_FILTRO_AYER()
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
    End Sub

#End Region

#Region "EVENTOS CHANGE VALUE DE LOS COMBOS DE TIPO RAZÓN SOCIAL, ZONA UO Y RAZÓN SOCIAL"

    Private Sub CB_LI_TIPO_RAZON_SOCIAL_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_LI_TIPO_RAZON_SOCIAL.SelectedValueChanged
        Codigo_CB.PG_CB_RAZON_SOCIAL_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_RAZON_SOCIAL, 1, New ComboBox, CB_LI_TIPO_RAZON_SOCIAL, VG_USUARIO_ACCION)
    End Sub

    Private Sub CB_LI_RAZON_SOCIAL_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_LI_RAZON_SOCIAL.SelectedValueChanged
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 1, CB_LI_ZONA_UO, CB_LI_RAZON_SOCIAL, VG_USUARIO_ACCION)
    End Sub

    Private Sub CB_LI_ZONA_UO_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_LI_ZONA_UO.SelectedValueChanged
        Codigo_CB.PG_CB_UNIDAD_OPERATIVA_Load(VM_ID_BASE_DE_DATOS, Me, CB_LI_UNIDAD_OPERATIVA, 1, 1, CB_LI_ZONA_UO, CB_LI_RAZON_SOCIAL, VG_USUARIO_ACCION)
    End Sub

#End Region

End Class