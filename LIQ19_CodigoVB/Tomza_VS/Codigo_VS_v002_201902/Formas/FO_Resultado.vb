Public Class FO_Resultado
    Public VM_TABLA As New DataTable
#Region "SUBS-INIT"

    Public Sub New()
        InitializeComponent()

        StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub PM_FO_INIT()
        PM_LI_FORMAT(LI_RESULTADO)
        PM_LI_DATA_SHOW(Me, LI_RESULTADO, VM_TABLA)

    End Sub

    Public Sub PM_FO_SHOW(ByVal PP_TABLA As DataTable)
        VM_TABLA = PP_TABLA
    End Sub

#End Region

#Region "SUBS-PM"

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, 
        '            ANCHO_CELDA, ALINEACION, SOLO_LECTURA, Visible, FROZEN, FORMATO
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "CLAVE", "ID", GetType(Integer), 100, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "EXITO", "Exito", GetType(String), 50, 2, 0, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "MENSAJE", "Mensaje", GetType(String), 700, 1, 0, 1, 1, 0)


    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CLAVE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "EXITO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MENSAJE")


    End Sub

    Private Sub PM_LI_DATA_SHOW(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView, ByVal PP_TABLA As DataTable)
        For Each VP_ROW As DataRow In PP_TABLA.Rows
            Codigo_LI.PG_LI_ROW_ADD(PP_LISTADO)
            PP_FORMA.PM_LI_ROW_WRITE(PP_LISTADO, VP_ROW)

        Next
        PP_LISTADO.CurrentCell = Nothing
    End Sub

#End Region

#Region "EVENTOS"

    Private Sub Resultado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT()
    End Sub

    Private Sub BT_ACEPTAR_Click(sender As Object, e As EventArgs) Handles BT_ACEPTAR.Click
        Close()
    End Sub

#End Region
End Class