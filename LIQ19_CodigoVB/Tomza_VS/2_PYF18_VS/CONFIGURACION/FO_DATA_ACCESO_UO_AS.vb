Imports System.Windows.Forms.DataVisualization.Charting
Public Class FO_DATA_ACCESO_UO_AS

#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_ID_ROW As Integer = -1
    Public VM_K_USUARIO As Integer = 0
    Dim VM_BANDERA_LOAD_COMPLETE As Boolean = False
    Public VM_UC_UNIDAD_OPERATIVA As UC_UNIDAD_OPERATIVA

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_USUARIO, False)

        If VP_PARAMETROS = "-1" Then
            VP_PARAMETROS = ""
        End If

        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean) As String
        Dim VP_LISTADO As DataGridView
        Dim VP_ID As String = ""
        Dim VP_PARAMETROS As String = ""

        PP_NUEVO = True

        VP_LISTADO = VM_UC_UNIDAD_OPERATIVA.LI_LISTADO
        If VP_LISTADO.Rows.Count > 0 Then
            Dim VP_ROW As Integer = Codigo_LI.FG_LI_ROW_CURRENT(VP_LISTADO)

            'IF PARA CUANDO SE MANDE TODO EL GRID Y NO TENGA UN REGISTRO SELECCIONADO SE ASIGNA DIFERENTE EL INDEX
            If VM_ID_ROW <> -1 Then
                VP_ROW = VM_ID_ROW
            End If

            VP_ID = VM_UC_UNIDAD_OPERATIVA.FM_ID_SELECCIONADO(VP_LISTADO, VP_ROW)

            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_USUARIO, False)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_ID, False)

        End If
        Return VP_PARAMETROS
    End Function


    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "D_UNIDAD_OPERATIVA")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        Dim VP_UO As String = ""

        VP_UO = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_UNIDAD_OPERATIVA")

        Codigo_CTRL.PG_CO_PARAMETRO(VP_ID, CB_USUARIO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_ID, VP_UO, False)


        Return VP_ID
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_VALOR As String)
        Return True
    End Function

#End Region

#Region "SUB_PM_INIT"

    Public Sub PM_FO_SHOW(ByRef PP_NOMBRE_TABLA As String, ByVal PP_ID_BASE_DE_DATOS As String)
        VM_NOMBRE_TABLA = PP_NOMBRE_TABLA
        VM_ID_BASE_DE_DATOS = PP_ID_BASE_DE_DATOS
        Show()
    End Sub

    Public Sub PM_CB_INIT()
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_USUARIO)
    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
    End Sub

    Private Sub PM_FO_INIT(ByRef PP_FORMA As Object)
        Codigo_FRM.PG_FRM_INIT(VM_ID_BASE_DE_DATOS, PP_FORMA)
        VM_UC_UNIDAD_OPERATIVA = New UC_UNIDAD_OPERATIVA
        VM_UC_UNIDAD_OPERATIVA.VM_ID_BASE_DE_DATOS = VM_ID_BASE_DE_DATOS
        VM_UC_UNIDAD_OPERATIVA.VM_NOMBRE_TABLA = "UNIDAD_OPERATIVA"
        Panel1.Controls.Add(VM_UC_UNIDAD_OPERATIVA)
        VM_UC_UNIDAD_OPERATIVA.Dock = DockStyle.Fill
        VM_UC_UNIDAD_OPERATIVA.PM_BT_BUSCAR_CLICK(VM_UC_UNIDAD_OPERATIVA, VM_UC_UNIDAD_OPERATIVA.LI_LISTADO)
        VM_BANDERA_LOAD_COMPLETE = True
        If VM_K_USUARIO > 0 Then
            Codigo_CB.PG_CB_VALUE_LOAD(CB_USUARIO, VM_K_USUARIO)
            PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
            CB_USUARIO.Enabled = False
        End If
    End Sub

#End Region

#Region "SUBS_PM"

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, 
        '            ANCHO_CELDA, ALINEACION, SOLO_LECTURA, Visible, FROZEN, FORMAT
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_UNIDAD_OPERATIVA", "#UO", GetType(Integer), 40, 2, 0, 1, 0, 0, Color.White, Color.Black, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_UNIDAD_OPERATIVA", "Unidad Operativa", GetType(String), 150, 1, 0, 1, 0, 0, Color.Orange, Nothing, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_ZONA_UO", "Zona", GetType(String), 100, 2, 0, 1, 0, 0, Nothing, Nothing, 1)

    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_ZONA_UO")

    End Sub

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_BUSCAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
    End Sub

    Private Sub PM_BT_LISTADO_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_LISTADO_CLICK(PP_FORMA)
    End Sub

    Private Sub BT_MAS_UNO_Click(sender As Object, e As EventArgs) Handles BT_MAS_UNO.Click
        If (Codigo_LI.FG_LI_ROW_CURRENT(VM_UC_UNIDAD_OPERATIVA.LI_LISTADO) > -1) Then
            Codigo_ABC.PG_BT_GUARDAR_CLICK(VM_ID_BASE_DE_DATOS, Me, LI_LISTADO)
        Else
            Codigo_Message.PG_MENSAJE_AVISO("Seleccione una Unidad Operativa")
        End If
    End Sub

    Private Sub PM_TI_TICK(ByRef PP_LABEL As Label)
        Codigo_FRM.PG_TI_TICK(PP_LABEL)
    End Sub

    Private Sub PM_BT_SALIR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_SALIR_CLICK(PP_FORMA)
    End Sub

#End Region

    Private Sub DATA_ACCESO_UO_AS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT(Me)
    End Sub

    Private Sub BT_MENOS_UNO_Click(sender As Object, e As EventArgs) Handles BT_MENOS_UNO.Click
        If (Codigo_LI.FG_LI_ROW_CURRENT(LI_LISTADO) > -1) Then
            Codigo_ABC.PG_BT_ELIMINAR_CLICK(VM_ID_BASE_DE_DATOS, Me, LI_LISTADO)
        Else
            Codigo_Message.PG_MENSAJE_AVISO("Seleccione una Unidad Operativa")
        End If
    End Sub

    Private Sub BT_MAS_TODOS_Click(sender As Object, e As EventArgs) Handles BT_MAS_TODOS.Click
        Dim VP_GRID As DataGridView
        Dim VP_DECISION As Boolean

        VP_GRID = VM_UC_UNIDAD_OPERATIVA.FM_LISTADO()

        VP_DECISION = Codigo_Message.FG_MENSAJE_CONFIRMACION("¿Desea añadir todos los registros?")

        If VP_DECISION Then

            If VP_GRID.Rows.Count > 0 Then
                For Each VP_REGISTRO As DataGridViewRow In VP_GRID.Rows
                    VM_ID_ROW = VP_REGISTRO.Index
                    Codigo_ABC.PG_BT_GUARDAR_MASIVO_CLICK(VM_ID_BASE_DE_DATOS, Me, LI_LISTADO)

                Next

            End If
        End If
        VM_ID_ROW = -1
        Codigo_LI.PG_LI_RESET(VM_ID_BASE_DE_DATOS, Me, LI_LISTADO, True)
    End Sub

    Private Sub BT_MENOS_TODOS_Click(sender As Object, e As EventArgs) Handles BT_MENOS_TODOS.Click

        Dim VP_DECISION As Boolean

        VP_DECISION = Codigo_Message.FG_MENSAJE_CONFIRMACION("¿Desea eliminar todos los registros?")

        If VP_DECISION Then

            If LI_LISTADO.Rows.Count > 0 Then

                Dim VP_REGISTRO As Integer = 0
                While VP_REGISTRO <= LI_LISTADO.Rows.Count - 1
                    VM_ID_ROW = VP_REGISTRO
                    Codigo_ABC.PG_BT_ELIMINAR_MASIVO_CLICK(VM_ID_BASE_DE_DATOS, Me, LI_LISTADO)

                    VP_REGISTRO += 1
                End While
            End If

        End If
        '  VM_ID_ROW = -1
        Codigo_LI.PG_LI_RESET(VM_ID_BASE_DE_DATOS, Me, LI_LISTADO, True)
    End Sub

    Private Sub BT_SALIR_Click(sender As Object, e As EventArgs) Handles BT_SALIR.Click
        PM_BT_SALIR_CLICK(Me)
    End Sub

    Private Sub TI_RELOJ_Tick(sender As Object, e As EventArgs) Handles TI_RELOJ.Tick
        PM_TI_TICK(LB_RELOJ)
    End Sub

    Private Sub CB_LI_USUARIO_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_USUARIO.SelectedValueChanged
        If Codigo_CB.FG_CB_ITEM_VALUE(CB_USUARIO) <> "-1" And VM_BANDERA_LOAD_COMPLETE Then
            PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
        End If
    End Sub

End Class