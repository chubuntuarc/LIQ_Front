Public Class LoginISAAC

    Dim DESARROLLO As Integer = 0

    Public Property DESARROLLO1 As Integer
        Get
            Return DESARROLLO
        End Get
        Set(value As Integer)
            DESARROLLO = value
        End Set
    End Property

#Region "CONSTRUCTOR"
    Public Sub New()
        InitializeComponent()
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inicio de Sesión"
    End Sub

#End Region

#Region "FUNCIONES_PM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LoginISAAC_ID, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CONTRASENA, True)
        Return VP_PARAMETROS
    End Function

#End Region

#Region "SUBS_PM"

    Private Sub PM_BT_INICIAR_SESION_CLICK(ByRef PP_FORMA As Object)
        Dim VP_ID_DB As Integer = 0
        VP_ID_DB = CB_SERVER.SelectedIndex
        If VP_ID_DB > -1 Then
            Codigo_ABC.PG_BT_INICIAR_SESION_CLICK(PP_FORMA, VP_ID_DB)
        Else
            MsgBox("Seleccione un servidor por favor")
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

    Private Sub LoginISAAC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_CB_SERVER_INIT()
        CB_SERVER.SelectedIndex = 0
        Codigo_FRM.PG_FRM_INIT_BASIC(Me)
        'If Debugger.IsAttached = True Then
        '    CB_SERVER.SelectedIndex = 2
        '    TB_LoginISAAC_ID.Text = "LBG"
        '    TB_CONTRASENA.Text = "PWD1001"
        '    PM_BT_INICIAR_SESION_CLICK(Me)
        'Else
        '    CB_SERVER.SelectedIndex = 0
        'End If
        ' 
        If DESARROLLO1 > 0 Then
            TB_CONTRASENA.Text = "TALL"
            TB_LoginISAAC_ID.Text = "TALL"

            PM_BT_INICIAR_SESION_CLICK(Me)
        End If
    End Sub

    Private Sub PM_CB_SERVER_INIT()
        CB_SERVER.Items.Clear()
        Dim VP_LISTA_CONEXIONES As List(Of CG_SQL_CONEXION) = Codigo_CON.PG_CONNECTION_INIT()
        For Each VL_CONEXION_ITEM As CG_SQL_CONEXION In VP_LISTA_CONEXIONES
            CB_SERVER.Items.Add(VL_CONEXION_ITEM.GetSQL_BD_SERVER + " \\ " + VL_CONEXION_ITEM.GetSQL_BD_DATABASE)
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

#End Region
End Class