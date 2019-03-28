Public Class Codigo_SP


    Public Shared Sub PG_RN_FECHA_HOY_YYYY_MM_GET(ByRef PP_BD_Index As Integer, ByRef PP_K_YYYY As Integer, ByRef PP_K_MES As Integer)

        Dim VP_STORED_PROCEDURE As String = "[PG_RN_FECHA_HOY_YYYY_MM_GET]"
        Dim VP_PARAMETROS As String = ""

        Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

        Dim VP_TABLA As Data.DataTable
        VP_TABLA = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(PP_BD_Index, VP_STORED_PROCEDURE, VP_PARAMETROS)

        Dim VP_N_REGISTROS As Integer
        VP_N_REGISTROS = VP_TABLA.Rows.Count()

        REM ------------------------------------------------

        Dim VP_K_YYYY As Integer
        Dim VP_K_MES As Integer

        If VP_N_REGISTROS <> 0 Then

            VP_K_YYYY = Codigo_SQL.FG_DataRow_READ_int(VP_TABLA.Rows(0), "K_YYYY", Now.Year)
            VP_K_MES = Codigo_SQL.FG_DataRow_READ_int(VP_TABLA.Rows(0), "K_MES", Now.Month)

        End If

        REM ------------------------------------------------

        PP_K_YYYY = VP_K_YYYY
        PP_K_MES = VP_K_MES

    End Sub


End Class
