Public Class Listado
    Public Shared Sub NUEVO(PP_DATOS As DataTable, PP_LISTADO As DataGridView, PP_CAMPOS As ArrayList, PP_TITULOS As ArrayList, PP_TIPOS As ArrayList)
        Codigo_LI.PG_LI_CLEAR(PP_LISTADO)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LISTADO, 8, 17)

        'GENERAR TITULOS
        For VP_INDICE As Integer = 1 To PP_TITULOS.Count

            Dim VP_CAMPO = PP_CAMPOS(VP_INDICE - 1)
            Dim VP_TITULO = PP_TITULOS(VP_INDICE - 1)
            Dim VP_TIPO = PP_TIPOS(VP_INDICE - 1)

            Select Case VP_TIPO
                Case 1
                    Codigo_LI.PG_LI_COLUMN_ADD(PP_LISTADO, VP_CAMPO, VP_TITULO, GetType(Integer), 50, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
                Case 2
                    Codigo_LI.PG_LI_COLUMN_ADD(PP_LISTADO, VP_CAMPO, VP_TITULO, GetType(String), 150, 1, 0, 1, 1, 0, Nothing, Color.LightYellow, 1)
                Case 3
                    Codigo_LI.PG_LI_COLUMN_ADD(PP_LISTADO, VP_CAMPO, VP_TITULO, GetType(String), 60, 2, 0, 1, 0, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
                Case 4
                    Codigo_LI.PG_LI_COLUMN_ADD(PP_LISTADO, VP_CAMPO, VP_TITULO, GetType(String), 150, 1, 0, 1, 0, 0, Nothing, Nothing, 1)
                Case 5
                    Codigo_LI.PG_LI_COLUMN_ADD(PP_LISTADO, VP_CAMPO, VP_TITULO, GetType(String), 60, 2, 0, 1, 0, 0, Color.Orange, Nothing, 1)
            End Select

        Next

        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LISTADO, 100, 2, 0, 0, 0, 0)

        'GENERAR COLUMNAS
        For VP_INDICE As Integer = 0 To PP_DATOS.Rows.Count - 1

            Dim VP_ROW_DATA As DataRow = PP_DATOS.Rows(VP_INDICE)

            PP_LISTADO.Rows.Insert(VP_INDICE, VP_ROW_DATA(PP_CAMPOS(0)))

            For index As Integer = 1 To PP_CAMPOS.Count - 1
                PP_LISTADO.Rows(VP_INDICE).Cells(index).Value = VP_ROW_DATA(PP_CAMPOS(index))
            Next

            Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_INDICE, PP_CAMPOS.Count, VP_ROW_DATA)

        Next

    End Sub
End Class
