Public Class SYS_SetUp

    Public Const CG_SQL_SP_USUARIO_ACCION As String = "69"
    Public Const CG_SQL_SP_VIG As String = "VIGENTE"
    Public Const CG_SQL_SP_VIGENTE As Integer = 1
    '=========================================================================
    Public Const CG_NOMBRE_PROYECTO As String = "LIQ19"
    '=========================================================================
    Public Const CG_SQL_SERVIDOR As String = "DESKTOP-I0DN4KS\LOCAL"
    Public Const CG_SQL_BASE_DATOS As String = "LIQ19_Liquidaciones_V9999_R0"
    Public Const CG_SQL_USUARIO As String = "sa"
    Public Const CG_SQL_PASSWORD As String = "123456"

    Public Const CG_SYS_RUTA_0_LOG As String = "C:\TOMZA.SYS\LIQ19.sys\LIQ19_LOG.sys"
    '=========================================================================

    REM ===========================================================================
    Public Const CG_TITULO_VENTANA As String = "L I Q 19 (DEMO)"
    Public Const CG_SYS_NOMBRE As String = "LIQ19"
    Public Const CG_SYS_SIGLAS As String = "LIQ19"
    'Public Const CG_SQL_SP_SISTEMA_EXE As String = "2005"
    Public Const CG_SQL_SP_SISTEMA_EXE As String = "2005"

    REM ===========================================================================
    REM /// #0 N/A | #1 PROD | #2 PERF | #3 UAT | #4 CERT | #5 LAB (BRUNO) | #6 UNIT | #7 DESA
    Public Const CG_SYS_AMBIENTE As Integer = 7
    Public Const CG_SYS_DEBUG As Boolean = False
    ' -------------------------------
    Public Const CG_VERSION_EXE As String = "V0100" 'D
    Public Const CG_VERSION_DTB As String = "V0006" 'A
    ' -------------------------------
    Public Const CG_SYS_AUTO_LOGIN As Boolean = True
    Public Const CG_SYS_USR_LOGIN As String = "JAR" 'JAR
    Public Const CG_SYS_USR_PWD As String = "PWD18" 'PWD18

    REM ===========================================================================

    Public Shared Sub PG_TOMZA_SYS_SetUp()

        Call Codigo_General.PG_CREAR_DIRECTORIO("C:\TOMZA.SYS")

        Call Codigo_General.PG_CREAR_DIRECTORIO("C:\TOMZA.SYS\LIQ19.sys")

        'Call Codigo_General.PG_CREAR_DIRECTORIO(ADG18_Constantes.CG_SYS_RUTA_0_LOG)​
        'Call Codigo_General.PG_CREAR_DIRECTORIO(ADG18_Constantes.CG_SYS_RUTA_1_RECIBO_PDF)​
        'Call Codigo_General.PG_CREAR_DIRECTORIO(ADG18_Constantes.CG_SYS_RUTA_2_MEDIDORES_IMG)​
        'Call Codigo_General.PG_CREAR_DIRECTORIO(ADG18_Constantes.CG_SYS_RUTA_3_EDOCTA_IMG)​
        'Call Codigo_General.PG_CREAR_DIRECTORIO(ADG18_Constantes.CG_SYS_RUTA_4_MEDIDORES_SERVER)​

        'Call Codigo_General.PG_CREAR_DIRECTORIO(ADG18_Constantes.CG_SYS_RUTA_5_RPT_RECIBO_PDF)​

    End Sub

    Public Shared Function PG_BD_CONEXION_List_Init() As List(Of CL_BD_CONEXION)


        Dim VP_CONTADOR As Integer = 0

        Try
            Codigo_SQL.CL_BD_CONEXION_LISTA.Clear()

            REM ////////////////////////////////////////////////////////////////////////////
            REM /// #0 N/A | #1 PROD | #2 PERF | #3 UAT | #4 CERT | #5 LAB (BRUNO) | #6 UNIT | #7 DESA
            If SYS_SetUp.CG_SYS_AMBIENTE = 7 Then
                Codigo_SQL.CL_BD_CONEXION_LISTA.Add(New CL_BD_CONEXION("DESA", VP_CONTADOR, "DESKTOP-I0DN4KS\LOCAL", "LIQ19_Liquidaciones_V9999_R0", "sa", "123456", 0))
                VP_CONTADOR += 1
            End If

            REM ////////////////////////////////////////////////////////////////////////////
            REM /// #0 N/A | #1 PROD | #2 PERF | #3 UAT | #4 CERT | #5 LAB (BRUNO) | #6 UNIT | #7 DESA
            If SYS_SetUp.CG_SYS_AMBIENTE = 5 Then
                Codigo_SQL.CL_BD_CONEXION_LISTA.Add(New CL_BD_CONEXION("LAB", VP_CONTADOR, "DESKTOP-KTP3PGG\SQLEXPRESS", "LIQ19_LiquidacionesGas_V9999_R0", "sa", "JI-15186#KF", 0))
                VP_CONTADOR += 1

            End If

            REM ////////////////////////////////////////////////////////////////////////////
            REM /// #0 N/A | #1 PROD | #2 PERF | #3 UAT | #4 CERT | #5 LAB (BRUNO) | #6 UNIT | #7 DESA
            If SYS_SetUp.CG_SYS_AMBIENTE = 6 Then
                'CL_BD_CONEXION_LISTA.Add(New CL_BD_CONEXION("UNI#hgf", VP_CONTADOR, "LAPTOP-RGTRQFC1\SQLEXPRESS", "LIQ19_LiquidacionesGas_V0107_R0", "sa", "151169", 0))
                'VP_CONTADOR += 1
                Codigo_SQL.CL_BD_CONEXION_LISTA.Add(New CL_BD_CONEXION("UNI#hgf", VP_CONTADOR, "LAPTOP-RGTRQFC1\SQLEXPRESS", "LIQ19_Liquidaciones_V9999_R0", "sa", "151169", 0))
                VP_CONTADOR += 1

            End If

            REM ////////////////////////////////////////////////////////////////////////////
            REM /// #0 N/A | #1 PROD | #2 PERF | #3 UAT | #4 CERT | #5 LAB (BRUNO) | #6 UNIT | #7 DESA
            If (SYS_SetUp.CG_SYS_AMBIENTE = 1 Or SYS_SetUp.CG_SYS_AMBIENTE = 2) Then
                'CG_LISTADO_CONEXION.Add(New CL_BD_CONEXION("PROD/PERF", VP_CONTADOR, "189.206.194.186\SQLEXPRESS", "LIQ19_LiquidacionesGas_V0015_R0", "sa", "HS+24856-RQ", 0))
                'VP_CONTADOR += 1
                Codigo_SQL.CL_BD_CONEXION_LISTA.Add(New CL_BD_CONEXION("PROD/PERF", VP_CONTADOR, "189.206.194.186\SQLEXPRESS", "LIQ19_LiquidacionesGas_V9999_R0", "sa", "HS+24856-RQ", 0))
                VP_CONTADOR += 1
            End If

        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CONNECTION_INIT")
        End Try

        Return Codigo_SQL.CL_BD_CONEXION_LISTA

    End Function

End Class
