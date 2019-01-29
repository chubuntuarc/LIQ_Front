Public Class FO_FLUJO_FIRMA_X_K_USUARIO

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0

#End Region

#Region "VARIABLES LOCALES"

    Dim VM_ARRAY_LIST As ArrayList = New ArrayList()
    Dim VM_USUARIO_A, VM_USUARIO_B, VM_USUARIO_C As String

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        'Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_VER_PENDIENTES, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ESTATUS_FIRMA, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = False

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_FLUJO_FIRMA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_ESTATUS_FIRMA_, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_OBSERVACIONES_FIRMA, True)
        Return VP_PARAMETROS
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_FLUJO_FIRMA")
        Return VP_ID
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean

        VP_VALIDACION = (PP_MENSAJE_VALIDACION = "")

        Return VP_VALIDACION
    End Function

    Public Function FM_VALIDAR_TAMANO_ARRAY(ByRef PP_ARRAY As ArrayList) As String
        Dim VP_RESPUESTA As String = ""
        Dim VP_TAMANO_ARRAY As Integer = PP_ARRAY.Count
        If VP_TAMANO_ARRAY = 0 Then
            VP_RESPUESTA = "Seleccione al menos un [FLUJO FIRMA] para Actualizar el Estatus."
        End If
        Return VP_RESPUESTA
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
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_LI_ESTATUS_FIRMA, "ESTATUS_FIRMA")

        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_MODO_AUTORIZACION, "MODO_AUTORIZACION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ESTATUS_FIRMA, "ESTATUS_FIRMA")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ROL_AUTORIZACION, "ROL_AUTORIZACION")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_ESTATUS_FIRMA_, "ESTATUS_FIRMA")

        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_USUARIO_ALTA, "USUARIO")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, CB_USUARIO_CAMBIO, "USUARIO")
    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
    End Sub

    Private Sub PM_FO_INIT(ByRef PP_FORMA As Object)
        Codigo_FRM.PG_FRM_INIT(VM_ID_BASE_DE_DATOS, PP_FORMA)

        Codigo_CB.PG_CB_VALUE_LOAD(CB_LI_ESTATUS_FIRMA, 1)
        CH_L_VER_PENDIENTES.Checked = True
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
        CH_L_VER_PENDIENTES.Checked = False
        Codigo_CB.PG_CB_VALUE_LOAD(CB_LI_ESTATUS_FIRMA, -1)

    End Sub

#End Region

#Region "SUBS_PM"

    ''' <summary>
    ''' 'FUNCIÓN QUE CARGARÁ LA PARTE DE LA FICHA
    ''' </summary>
    Public Sub PM_FI_LOAD(ByVal PP_ID As String)
        Codigo_FI.FG_FI_LOAD_X_ID(VM_ID_BASE_DE_DATOS, Me, PP_ID)
        TB_OBSERVACIONES_FIRMA.Select()
        PM_LIMPIAR_ARRAY(VM_ARRAY_LIST)
        For Each row As DataGridViewRow In LI_LISTADO.Rows
            row.Cells(0).Value = False
        Next
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_FLUJO_FIRMA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_AUTORIZACION_FIRMA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_N_PASO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_N_DIAS_FLUJO_FIRMA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_MODO_AUTORIZACION, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_ESTATUS_FIRMA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_D_AUTORIZACION_FIRMA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_MONTO_AUTORIZAR, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_MONTO_AUTORIZADO, PP_ROW)

        VM_USUARIO_A = Codigo_LI.FG_LI_CELL_READ_RUNTIME(PP_ROW, "USUARIO_FIRMAA_D_USUARIO")
        VM_USUARIO_B = Codigo_LI.FG_LI_CELL_READ_RUNTIME(PP_ROW, "USUARIO_FIRMAB_D_USUARIO")
        VM_USUARIO_C = Codigo_LI.FG_LI_CELL_READ_RUNTIME(PP_ROW, "USUARIO_FIRMAC_D_USUARIO")

        If VM_USUARIO_A = VG_USUARIO Then
            Codigo_CTRL.PG_CO_DATA_LOAD("K_ROL_AUTORIZACION_A", CB_ROL_AUTORIZACION, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("K_ESTATUS_FIRMA_A", CB_ESTATUS_FIRMA_, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("OBSERVACIONES_FIRMA_A", TB_OBSERVACIONES_FIRMA, PP_ROW)
        ElseIf VM_USUARIO_B = VG_USUARIO Then
            Codigo_CTRL.PG_CO_DATA_LOAD("K_ROL_AUTORIZACION_B", CB_ROL_AUTORIZACION, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("K_ESTATUS_FIRMA_B", CB_ESTATUS_FIRMA_, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("OBSERVACIONES_FIRMA_B", TB_OBSERVACIONES_FIRMA, PP_ROW)
        ElseIf VM_USUARIO_C = VG_USUARIO Then
            Codigo_CTRL.PG_CO_DATA_LOAD("K_ROL_AUTORIZACION_C", CB_ROL_AUTORIZACION, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("K_ESTATUS_FIRMA_C", CB_ESTATUS_FIRMA_, PP_ROW)
            Codigo_CTRL.PG_CO_DATA_LOAD("OBSERVACIONES_FIRMA_C", TB_OBSERVACIONES_FIRMA, PP_ROW)
        End If

        Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)

        VM_USUARIO_A = "" : VM_USUARIO_B = "" : VM_USUARIO_C = ""
    End Sub
#Region "FORMAT&WRITE"
    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView) ', ByVal PP_K_USUARIO As Integer)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 20)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)]
        Codigo_LI.PG_LI_COLUMN_ADD_CHECK(PP_LI_LISTADO, "", "", GetType(Integer), 20, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_FLUJO_FIRMA", "#FJF", GetType(Integer), 60, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_AUTORIZACION_FIRMA", "#AUT", GetType(Integer), 60, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_AUTORIZACION_FIRMA", "Descripción Autorización", GetType(String), 280, 1, 0, 1, 1, 0, Nothing, Nothing, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "MONTO_AUTORIZAR", "Monto Autorizar", GetType(Decimal), 80, 3, 0, 1, 0, 2, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "MONTO_AUTORIZADO", "Monto Autorizado", GetType(Decimal), 80, 3, 0, 1, 0, 2, Color.DarkOrange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "FLU0_D_ESTATUS_FIRMA_FLUJO", "Estatus Flujo", GetType(Integer), 100, 2, 0, 1, 0, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "N_PASO", "Paso", GetType(Integer), 60, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_MODO_AUTORIZACION", "Modo", GetType(String), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "N_DIAS_FLUJO_FIRMA", "Días Flujo", GetType(Integer), 60, 2, 0, 1, 0, 0, Nothing, Nothing, 0)

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "USUARIO_FIRMAA_D_USUARIO", "Usuario Firma-A", GetType(String), 100, 2, 0, 0, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "USUARIO_FIRMAB_D_USUARIO", "Usuario Firma-B", GetType(String), 100, 2, 0, 0, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "USUARIO_FIRMAC_D_USUARIO", "Usuario Firma-C", GetType(String), 100, 2, 0, 0, 0, 0)

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "ESTATUS_FIRMA", "Estatus Firma", GetType(String), 100, 2, 0, 1, 0, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "ROL", "Rol ", GetType(Integer), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "USUARIO FIRMA", "Usuario Firma", GetType(String), 160, 2, 0, 1, 0, 0, Nothing, Nothing, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "OBSERVACIONES", "Observaciones", GetType(String), 400, 1, 0, 1, 0, 0, Nothing, Nothing, 0)

    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL_CHECK(PP_LISTADO, VP_ROW, VP_COLUMNA)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_FLUJO_FIRMA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_AUTORIZACION_FIRMA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_AUTORIZACION_FIRMA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MONTO_AUTORIZAR")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MONTO_AUTORIZADO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "FLU0_D_ESTATUS_FIRMA_FLUJO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "N_PASO", "Paso")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_MODO_AUTORIZACION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "N_DIAS_FLUJO_FIRMA")

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "USUARIO_FIRMAA_D_USUARIO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "USUARIO_FIRMAB_D_USUARIO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "USUARIO_FIRMAC_D_USUARIO")

        VM_USUARIO_A = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, VP_ROW, "USUARIO_FIRMAA_D_USUARIO")
        VM_USUARIO_B = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, VP_ROW, "USUARIO_FIRMAB_D_USUARIO")
        VM_USUARIO_C = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, VP_ROW, "USUARIO_FIRMAC_D_USUARIO")

        If VM_USUARIO_A = VG_USUARIO Then
            PM_LI_ROW_LETRAS(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "A")
        ElseIf VM_USUARIO_B = VG_USUARIO Then
            PM_LI_ROW_LETRAS(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "B")
        ElseIf VM_USUARIO_C = VG_USUARIO Then
            PM_LI_ROW_LETRAS(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "C")
        End If

        VM_USUARIO_A = "" : VM_USUARIO_B = "" : VM_USUARIO_C = ""
    End Sub

    Public Sub PM_LI_ROW_LETRAS(ByRef PP_LISTADO As DataGridView, ByVal PP_ROW As Integer, ByRef PP_COLUMNA As Integer, ByRef PP_ROW_DATA As DataRow, ByVal PP_PREFIJO As String)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, "FLU" + PP_PREFIJO + "_ESTATUS_FIRMA" + PP_PREFIJO + "_D_ESTATUS_FIRMA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, "ROL" + PP_PREFIJO + "_D_ROL_AUTORIZACION")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, "USUARIO_FIRMA" + PP_PREFIJO + "_D_USUARIO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, "OBSERVACIONES_FIRMA_" + PP_PREFIJO)
    End Sub

#End Region

    Public Sub PM_LI_CELL_CLICK(e As DataGridViewCellEventArgs)
        Dim VP_CHK As DataGridViewCheckBoxCell = LI_LISTADO.Rows(e.RowIndex).Cells(0)
        Dim VP_ID_K_FLUJO As Integer = FM_ID_SELECCIONADO(LI_LISTADO, Codigo_LI.FG_LI_ROW_CURRENT(LI_LISTADO))
        'Dim TXT As String = ""
        'MsgBox(VP_ID_K_FLUJO.ToString)
        If VP_CHK.Value = True Then
            VP_CHK.Value = False
            VM_ARRAY_LIST.Remove(VP_ID_K_FLUJO)
            LI_LISTADO.CurrentCell = Nothing
        Else
            VP_CHK.Value = True
            VM_ARRAY_LIST.Add(VP_ID_K_FLUJO)
        End If
        'For Each I As Integer In VM_ARRAY_LIST
        '    TXT += I.ToString + ", "
        'Next
        'MsgBox(TXT)
    End Sub

    Public Sub PM_LI_GUARDAR_ESTATUS(ByRef PP_FORMA As Object, ByRef PP_ARRAY As ArrayList, ByRef PP_LISTADO As DataGridView, ByVal PP_ESTATUS As Integer)
        Dim MSJ As String = FM_VALIDAR_TAMANO_ARRAY(PP_ARRAY)
        If MSJ = "" Then
            For Each i As Integer In PP_ARRAY
                Dim VP_K_FLUJO_FIRMA As Integer = i
                Dim VP_PARAMETROS As String = VP_K_FLUJO_FIRMA
                Dim VP_DATATABLE As New Data.DataTable
                VM_USUARIO_A = "" : VM_USUARIO_B = "" : VM_USUARIO_C = ""

                Codigo_ABC.PG_BT_EJECUTAR_ACCION_TABLA_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "PG_SK_FLUJO_FIRMA_X_K_USUARIO", VP_PARAMETROS, VP_DATATABLE)

                VM_USUARIO_A = Codigo_LI.FG_LI_CELL_READ(VP_DATATABLE, 0, "USUARIO_FIRMAA_D_USUARIO")
                VM_USUARIO_B = Codigo_LI.FG_LI_CELL_READ(VP_DATATABLE, 0, "USUARIO_FIRMAB_D_USUARIO")
                VM_USUARIO_C = Codigo_LI.FG_LI_CELL_READ(VP_DATATABLE, 0, "USUARIO_FIRMAC_D_USUARIO")

                Dim VP_OBSERVACIONES As String = ""
                If VM_USUARIO_A = VG_USUARIO Then
                    VP_OBSERVACIONES = Codigo_LI.FG_LI_CELL_READ(VP_DATATABLE, 0, "OBSERVACIONES_FIRMA_A")
                ElseIf VM_USUARIO_B = VG_USUARIO Then
                    VP_OBSERVACIONES = Codigo_LI.FG_LI_CELL_READ(VP_DATATABLE, 0, "OBSERVACIONES_FIRMA_B")
                ElseIf VM_USUARIO_C = VG_USUARIO Then
                    VP_OBSERVACIONES = Codigo_LI.FG_LI_CELL_READ(VP_DATATABLE, 0, "OBSERVACIONES_FIRMA_C")
                End If

                Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_ESTATUS, False)
                Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_OBSERVACIONES, True)

                Dim VP_CLAVE As String
                Dim VP_MENSAJE As String
                Codigo_ABC.PG_BT_EJECUTAR_ACCION_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, "PG_UP_FLUJO_FIRMA_X_K_USUARIO", VP_PARAMETROS, VP_CLAVE, VP_MENSAJE)

                If VP_MENSAJE = "" Then
                    VP_MENSAJE = "Operación Exitosa [#" + VP_CLAVE + "]."
                Else
                    Codigo_Message.PG_MENSAJE_AVISO(VP_MENSAJE)
                End If

                PM_BT_BUSCAR_CLICK(PP_FORMA, PP_LISTADO)

                On Error Resume Next
                PP_FORMA.LB_RESULTADO.Text = "Resultado de la operación: " + VP_MENSAJE + Environment.NewLine + PP_FORMA.LB_RESULTADO.Text
                On Error GoTo 0
            Next
            PM_LIMPIAR_ARRAY(PP_ARRAY)
        Else
            Codigo_Message.PG_MENSAJE_AVISO(MSJ)
        End If
    End Sub

    Public Sub PM_LIMPIAR_ARRAY(ByRef PP_ARRAY As ArrayList)
        PP_ARRAY.Clear()
    End Sub

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
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
        Codigo_ABC.PG_BT_ELIMINAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
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
        'PM_BT_AGREGAR_CLICK(Me)
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
        'PM_BT_ELIMINAR_CLICK(Me, LI_LISTADO)
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

    Private Sub BT_ESTATUS_REVISION_Click(sender As Object, e As EventArgs) Handles BT_ESTATUS_REVISION.Click
        Codigo_CB.PG_CB_VALUE_LOAD(CB_ESTATUS_FIRMA_, 2)
        If VM_IN_MODO_OPERACION = Modo_Operacion.Ver_Ficha Or VM_IN_MODO_OPERACION = Modo_Operacion.Edición Then
            PM_BT_GUARDAR_CLICK(Me, LI_LISTADO)
        Else
            PM_LI_GUARDAR_ESTATUS(Me, VM_ARRAY_LIST, LI_LISTADO, 2)
        End If
    End Sub

    Private Sub BT_ESTATUS_RECHAZADO_Click(sender As Object, e As EventArgs) Handles BT_ESTATUS_RECHAZADO.Click
        Codigo_CB.PG_CB_VALUE_LOAD(CB_ESTATUS_FIRMA_, 4)
        If VM_IN_MODO_OPERACION = Modo_Operacion.Ver_Ficha Or VM_IN_MODO_OPERACION = Modo_Operacion.Edición Then
            PM_BT_GUARDAR_CLICK(Me, LI_LISTADO)
        Else
            PM_LI_GUARDAR_ESTATUS(Me, VM_ARRAY_LIST, LI_LISTADO, 4)
        End If
    End Sub

    Private Sub BT_ESTATUS_AUTORIZADO_Click(sender As Object, e As EventArgs) Handles BT_ESTATUS_AUTORIZADO.Click
        Codigo_CB.PG_CB_VALUE_LOAD(CB_ESTATUS_FIRMA_, 3)
        If VM_IN_MODO_OPERACION = Modo_Operacion.Ver_Ficha Or VM_IN_MODO_OPERACION = Modo_Operacion.Edición Then
            PM_BT_GUARDAR_CLICK(Me, LI_LISTADO)
        Else
            PM_LI_GUARDAR_ESTATUS(Me, VM_ARRAY_LIST, LI_LISTADO, 3)
        End If
    End Sub

    Private Sub LI_LISTADO_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LI_LISTADO.CellClick
        If e.RowIndex <> -1 Then
            PM_LI_CELL_CLICK(e)
        End If
    End Sub

    Private Sub LI_LISTADO_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LI_LISTADO.CellDoubleClick
        If e.RowIndex <> -1 Then

            Codigo_LI.PG_LI_DOUBLE_CLICK(Me, LI_LISTADO)
        End If
    End Sub

#End Region

End Class