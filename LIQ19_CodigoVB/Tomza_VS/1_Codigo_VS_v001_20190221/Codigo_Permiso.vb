Public Class Codigo_Permiso
    Public Shared Sub PG_CONSULTAR_PERMISOS(ByVal PP_ID_BASE_DE_DATOS As Integer, ByRef PP_FORMA As Object, ByVal PP_K_USUARIO As Integer)
        Try
            Dim VP_NOMBRE_FORMA As String = ""
            VP_NOMBRE_FORMA = PP_FORMA.Name
            Dim VP_STORED_PROCEDURE As String = "PG_LI_PERMISO_FUNCION_X_K_USUARIO"
            Dim VP_PARAMETROS As String = ""
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_NOMBRE_FORMA, True)
            Dim VP_DATATABLE_PERMISOS As New DataTable
            Codigo_ABC.PG_BT_EJECUTAR_ACCION_TABLA_CLICK(PP_ID_BASE_DE_DATOS, PP_FORMA, VP_STORED_PROCEDURE, VP_PARAMETROS, VP_DATATABLE_PERMISOS)

            Dim VP_BOTONES_DE_LA_FORMA As New Collection
            PG_CONTROLS_CHILDRENS_GET_X_NAME(PP_FORMA, GetType(Button), VP_BOTONES_DE_LA_FORMA)
            PG_CONTROLS_CHILDRENS_GET_X_NAME(PP_FORMA, GetType(GroupBox), VP_BOTONES_DE_LA_FORMA)
            PG_CONTROLS_CHILDRENS_GET_X_NAME(PP_FORMA, GetType(ComboBox), VP_BOTONES_DE_LA_FORMA)
            PG_CONTROLS_CHILDRENS_GET_X_NAME(PP_FORMA, GetType(DataGridView), VP_BOTONES_DE_LA_FORMA)

            For Each VP_ROW As DataRow In VP_DATATABLE_PERMISOS.Rows
                If VP_BOTONES_DE_LA_FORMA.Contains(VP_ROW(5)) Then
                    Dim VP_BOTON As Control = VP_BOTONES_DE_LA_FORMA.Item(VP_ROW(5).ToString())
                    VP_BOTON.Visible = Convert.ToBoolean(VP_ROW(2))
                    VP_BOTON.Enabled = Convert.ToBoolean(VP_ROW(3))
                Else
                    Codigo_Message.PG_MENSAJE_AVISO("El control " + VP_ROW(5) + " no existe")
                End If
            Next
        Catch ex As ArgumentException
            Codigo_Message.PG_MENSAJE_ERROR_VS("PG_CONSULTAR_PERMISOS")
        End Try
    End Sub

    Public Shared Function FG_CONSULTAR_PERMISOS(ByVal PP_ID_BASE_DE_DATOS As Integer, ByVal VP_GRUPO As String, ByVal PP_K_USUARIO As Integer) As DataTable
        Dim VP_DATATABLE_PERMISOS As New DataTable
        Try
            Dim VP_PARAMETROS As String = ""
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_GRUPO, True)
            Dim VP_STORED_PROCEDURE As String = "PG_LI_PERMISO_MENU_X_K_USUARIO"

            Codigo_ABC.PG_BT_EJECUTAR_ACCION_TABLA_CLICK(PP_ID_BASE_DE_DATOS, Nothing, VP_STORED_PROCEDURE, VP_PARAMETROS, VP_DATATABLE_PERMISOS)

        Catch ex As ArgumentException
            Codigo_Message.PG_MENSAJE_ERROR_VS("PG_CONSULTAR_PERMISOS")
        End Try
        Return VP_DATATABLE_PERMISOS
    End Function

End Class
