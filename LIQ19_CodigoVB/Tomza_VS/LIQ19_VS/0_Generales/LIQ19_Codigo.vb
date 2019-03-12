Public Class LIQ19_Codigo
    Public Shared Sub PG_LI_CLEAR(ByRef PP_LISTADO As DataGridView)
        PP_LISTADO.Rows.Clear()
    End Sub

    Public Shared Sub PG_LI_ROW_ADD(ByRef PP_LISTADO As DataGridView)
        PP_LISTADO.Rows.Add()
    End Sub

    Public Shared Sub PG_BT_BUSCAR_DETALLE(ByVal PP_ID_BASE_DE_DATOS As Integer, ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView, Optional ByVal PP_SP As String = "", Optional ByVal PP_PARAMETROS As String = "")
        PP_FORMA.Cursor = Cursors.WaitCursor
        Try

            Dim VP_PARAMETROS As String
            If PP_PARAMETROS IsNot "" Then
                VP_PARAMETROS = PP_PARAMETROS
            Else
                VP_PARAMETROS = PP_FORMA.FM_SQL_LISTADO()
            End If


            Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
            Dim VP_STORED_PROCEDURE As String

            If PP_SP = "" Then
                VP_STORED_PROCEDURE = FG_SQL_LIST(PP_FORMA)
            Else
                VP_STORED_PROCEDURE = PP_SP
            End If

            Dim VP_TABLA As Data.DataTable
            VP_TABLA = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(PP_ID_BASE_DE_DATOS, VP_STORED_PROCEDURE, VP_PARAMETROS)
            If VP_TABLA.Rows.Count > 500 Then
                If Codigo_Mensaje.FG_MENSAJE_CONFIRMACION("La busqueda arrojó mas de 500 registros." + vbCrLf + "¿Desea mostrarlos?") Then
                    PG_LI_LOAD_DETALLE(PP_FORMA, PP_LISTADO, VP_TABLA)
                End If
            Else
                PG_LI_LOAD_DETALLE(PP_FORMA, PP_LISTADO, VP_TABLA)
            End If
            Dim VP_REGISTROS As String
            VP_REGISTROS = VP_TABLA.Rows.Count().ToString()
            PP_FORMA.LB_RESULTADO.Text = "Resultado de la operación: " + VP_REGISTROS + " registros." + Environment.NewLine + PP_FORMA.LB_RESULTADO.Text
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_BUSCAR_CLICK")
        End Try
        PP_FORMA.Cursor = Cursors.Default
    End Sub

    Public Shared Sub PG_LI_LOAD_DETALLE(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView, ByVal PP_DATATABLE As DataTable)
        Try
            PG_LI_CLEAR(PP_LISTADO)
            Dim PP_PB_PROGRESSBAR As BARRA_DE_PROGRESO_PANEL
            PP_PB_PROGRESSBAR = ProgressBarPanel.FG_PROGRESSBAR_INIT(PP_FORMA, 0, PP_DATATABLE.Rows.Count, "Carga de Registros", Color.DarkOrange)
            Dim PP_COUNT As Integer = 0
            Dim VP_LISTADO_NOMBRE = PP_LISTADO.Name
            PP_LISTADO.Visible = False
            For Each VP_ROW_DATA As DataRow In PP_DATATABLE.Rows
                PG_LI_ROW_ADD(PP_LISTADO)
                PP_FORMA.PM_LI_ROW_WRITE_DETALLE(PP_LISTADO, VP_ROW_DATA)
                PP_COUNT += 1
                ProgressBarPanel.PG_PROGRESSBAR_INCREMENT(PP_PB_PROGRESSBAR, PP_COUNT)
            Next
            PP_LISTADO.Visible = True
            ProgressBarPanel.PG_PROGRESSBAR_END(PP_PB_PROGRESSBAR)
            PP_LISTADO.CurrentCell = Nothing
            'PP_LISTADO.CurrentCell.Selected = False
            ' PP_LISTADO.ClearSelection()
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_LI_LOAD")

        End Try

    End Sub

    Public Shared Function FG_SQL_LIST(ByRef PP_FORMA As Object)
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SQL_BASICO(Constantes_Sistema.CG_SQL_SP_LIST, PP_FORMA.VM_NOMBRE_TABLA)
        Return VP_STORED_PROCEDURE
    End Function

    Private Shared Function FG_SQL_BASICO(ByVal PP_TIPO As String, ByVal PP_NOMBRE_TABLA As String)
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = "[dbo].[" + Constantes_Sistema.CG_SQL_PG_PREFIJO + "_" + PP_TIPO + "_" + PP_NOMBRE_TABLA + "]"
        Return VP_STORED_PROCEDURE
    End Function
End Class
