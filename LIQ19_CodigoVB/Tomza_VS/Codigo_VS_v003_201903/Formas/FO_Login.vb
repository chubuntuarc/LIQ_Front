Public Class FO_Login

    Public VM_BD_Index As Integer = 0

#Region "CONSTRUCTOR"
    Public Sub New()
        InitializeComponent()
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inicio de Sesión"
        LA_SYS_NOMBRE.Text = SYS_SetUp.CG_SYS_NOMBRE
    End Sub

#End Region

#Region "FUNCIONES_PM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_Login, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CONTRASENA, True)
        Return VP_PARAMETROS
    End Function

#End Region

#Region "SUBS_PM"



    Private Sub PM_SISTEMA_COMPATIBILIDAD()

        Dim VP_SISTEMA_EXE = SYS_SetUp.CG_SQL_SP_SISTEMA_EXE
        Dim VP_VERSION_EXE = SYS_SetUp.CG_VERSION_EXE
        Dim VP_VERSION_DB = SYS_SetUp.CG_VERSION_DTB

        Call Codigo_SQL.PG_SISTEMA_COMPATIBILIDAD(Me, VM_BD_Index, VP_SISTEMA_EXE, VP_VERSION_EXE, VP_VERSION_DB)

    End Sub

    Private Sub PM_BT_INICIAR_SESION_CLICK(ByRef PP_FORMA As Object)

        VM_BD_Index = CB_SERVER.SelectedIndex

        If VM_BD_Index > -1 Then

            Codigo_ABC.PG_BT_INICIAR_SESION_CLICK(PP_FORMA, VM_BD_Index)

            Call PM_SISTEMA_COMPATIBILIDAD()

        Else
            MsgBox("Seleccione un <Servidor> por favor.")
        End If

    End Sub

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean

        VP_VALIDACION = (PP_MENSAJE_VALIDACION = "")

        Return VP_VALIDACION
    End Function

#End Region

#Region "EVENTOS"
    Private Sub BT_SALIR_Click(sender As Object, e As EventArgs) Handles BT_SALIR.Click
        Application.Exit()
    End Sub

    Private Sub BT_INCIAR_SESION_Click(sender As Object, e As EventArgs) Handles BT_INCIAR_SESION.Click
        PM_BT_INICIAR_SESION_CLICK(Me)
    End Sub


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_CB_SERVER_INIT()

        If CB_SERVER.Items.Count = 0 Then
            Call Codigo_Mensaje.PG_MENSAJE_AVISO("No hay Conexiones/BD disponibles, verifique.", False)
            End
        End If

        CB_SERVER.SelectedIndex = 0
        Codigo_FRM.PG_FRM_INIT_BASIC(Me)


        If SYS_SetUp.CG_SYS_AUTO_LOGIN Then

            REM /// #0 N/A | #1 PROD | #2 PERF | #3 UAT | #4 CERT | #5 LAB (BRUNO) | #6 UNIT | #7 DESA

            TB_Login.Text = SYS_SetUp.CG_SYS_USR_LOGIN
            TB_CONTRASENA.Text = SYS_SetUp.CG_SYS_USR_PWD

            PM_BT_INICIAR_SESION_CLICK(Me)

        End If

    End Sub




    Private Sub PM_CB_SERVER_INIT()

        Me.CancelButton = Me.BT_SALIR

        CB_SERVER.Items.Clear()

        Dim VP_LISTA_CONEXIONES As List(Of CL_BD_CONEXION) = SYS_SetUp.PG_BD_CONEXION_List_Init()

        Dim VP_OPCION_CB As String

        For Each VP_CONEXION_ITEM As CL_BD_CONEXION In VP_LISTA_CONEXIONES

            VP_OPCION_CB = ""

            VP_OPCION_CB = VP_CONEXION_ITEM.GetSQL_OPCION_COMBO

            CB_SERVER.Items.Add(VP_OPCION_CB)

        Next

    End Sub

    Private Sub CB_SERVER_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_SERVER.KeyPress

        PM_BT_INICIAR_SESION_CLICK(Me)

    End Sub

    Private Sub TB_CONTRASENA_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_CONTRASENA.KeyDown
        If e.KeyCode = Keys.Enter Then

            PM_BT_INICIAR_SESION_CLICK(Me)

        End If
    End Sub

    Private Sub TB_CONTRASENA_TextChanged(sender As Object, e As EventArgs) Handles TB_CONTRASENA.TextChanged

    End Sub

#End Region

End Class