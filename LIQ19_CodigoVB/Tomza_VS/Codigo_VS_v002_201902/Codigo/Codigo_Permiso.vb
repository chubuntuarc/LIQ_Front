Public Class Codigo_Permiso
    Public Shared Sub PG_CONSULTAR_PERMISOS(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByVal PP_K_USUARIO As Integer)
        Try
            Dim VP_NOMBRE_FORMA As String = ""
            VP_NOMBRE_FORMA = PP_FORMA.Name
            Dim VP_STORED_PROCEDURE As String = "PG_LI_PERMISO_FUNCION_X_K_USUARIO"
            Dim VP_PARAMETROS As String = ""
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_NOMBRE_FORMA, True)
            Dim VP_DATATABLE_PERMISOS As New DataTable
            Codigo_ABC.PG_BT_EJECUTAR_ACCION_TABLA_CLICK(PP_BD_Index, PP_FORMA, VP_STORED_PROCEDURE, VP_PARAMETROS, VP_DATATABLE_PERMISOS)

            Dim VP_BOTONES_DE_LA_FORMA As New Collection
            PG_CONTROLS_CHILDRENS_GET_X_NAME(PP_FORMA, GetType(Button), VP_BOTONES_DE_LA_FORMA)
            PG_CONTROLS_CHILDRENS_GET_X_NAME(PP_FORMA, GetType(GroupBox), VP_BOTONES_DE_LA_FORMA)
            PG_CONTROLS_CHILDRENS_GET_X_NAME(PP_FORMA, GetType(ComboBox), VP_BOTONES_DE_LA_FORMA)
            PG_CONTROLS_CHILDRENS_GET_X_NAME(PP_FORMA, GetType(DataGridView), VP_BOTONES_DE_LA_FORMA)

            Dim VP_ROW As DataRow

            Dim VP_NOMBRE_CONTROL As String
            Dim VP_BOTON As Control

            For Each VP_ROW In VP_DATATABLE_PERMISOS.Rows

                VP_NOMBRE_CONTROL = Codigo_SQL.FG_DataRow_READ_str(VP_ROW, "D_PROCESO")



                If VP_NOMBRE_CONTROL <> "" Then

                    If VP_BOTONES_DE_LA_FORMA.Contains(VP_NOMBRE_CONTROL) Then


                        VP_BOTON = VP_BOTONES_DE_LA_FORMA.Item(VP_NOMBRE_CONTROL)
                        VP_BOTON.Visible = Codigo_SQL.FG_DataRow_READ_boolean(VP_ROW, "L_VISIBLE", False)
                        VP_BOTON.Enabled = Codigo_SQL.FG_DataRow_READ_boolean(VP_ROW, "L_ACTIVO", False)
                    Else
                        Codigo_Mensaje.PG_MENSAJE_AVISO("El control <" + VP_NOMBRE_CONTROL + "> no existe, reportar a Sistemas.")

                    End If

                    End If

            Next
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CONSULTAR_PERMISOS")
        End Try
    End Sub


    Public Shared Function FG_CONSULTAR_PERMISOS(ByVal PP_BD_Index As Integer, ByVal VP_GRUPO As String, ByVal PP_K_USUARIO As Integer) As DataTable

        Dim VP_DATATABLE_PERMISOS As New DataTable
        Try
            Dim VP_PARAMETROS As String = ""

            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_GRUPO, True)
            Dim VP_STORED_PROCEDURE As String = "PG_LI_PERMISO_MENU_X_K_USUARIO"

            Codigo_ABC.PG_BT_EJECUTAR_ACCION_TABLA_CLICK(PP_BD_Index, Nothing, VP_STORED_PROCEDURE, VP_PARAMETROS, VP_DATATABLE_PERMISOS)

        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("FG_CONSULTAR_PERMISOS")
        End Try

        Return VP_DATATABLE_PERMISOS
    End Function

End Class
