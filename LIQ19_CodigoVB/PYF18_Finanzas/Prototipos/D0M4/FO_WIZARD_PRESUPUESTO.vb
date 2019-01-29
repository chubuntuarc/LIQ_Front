Public Class FO_WIZARD_PRESUPUESTO
#Region "VARIABLES Y CONSTANTES MODULARES"

    Private VM_ID_BASE_DE_DATOS As Integer = 0
    Private PP_UNIDAD_OPERATIVA As Integer = 0
    Private PP_YYYY As Integer = 0
    Private PP_MES As Integer = 0
    Private PP_K_PRECIO_COSTO_PERFIL As Integer = 0
    Private PP_K_DOCUMENTO_D0M4 As Integer = 0
    Private PP_K_PARAMETRO_POB As Integer = 0
    Private PP_K_FORMATO_D0M4 As Integer = 907
    Private PAGE_NO As Integer = 1

    Public Sub New(vM_ID_BASE_DE_DATOS As Integer)
        Me.VM_ID_BASE_DE_DATOS = vM_ID_BASE_DE_DATOS
        InitializeComponent()
    End Sub

    Public Property PP_UNIDAD_OPERATIVA1 As Integer
        Get
            Return PP_UNIDAD_OPERATIVA
        End Get
        Set(value As Integer)
            PP_UNIDAD_OPERATIVA = value
        End Set
    End Property

    Public Property PP_YYYY1 As Integer
        Get
            Return PP_YYYY
        End Get
        Set(value As Integer)
            PP_YYYY = value
        End Set
    End Property

    Public Property PP_MES1 As Integer
        Get
            Return PP_MES
        End Get
        Set(value As Integer)
            PP_MES = value
        End Set
    End Property

    Public Property PP_K_PRECIO_COSTO_PERFIL1 As Integer
        Get
            Return PP_K_PRECIO_COSTO_PERFIL
        End Get
        Set(value As Integer)
            PP_K_PRECIO_COSTO_PERFIL = value
        End Set
    End Property

    Public Property PP_K_DOCUMENTO_D0M41 As Integer
        Get
            Return PP_K_DOCUMENTO_D0M4
        End Get
        Set(value As Integer)
            PP_K_DOCUMENTO_D0M4 = value
        End Set
    End Property

    Public Property PP_K_PARAMETRO_POB1 As Integer
        Get
            Return PP_K_PARAMETRO_POB
        End Get
        Set(value As Integer)
            PP_K_PARAMETRO_POB = value
        End Set
    End Property

    Public Property PP_K_FORMATO_D0M41 As Integer
        Get
            Return PP_K_FORMATO_D0M4
        End Get
        Set(value As Integer)
            PP_K_FORMATO_D0M4 = value
        End Set
    End Property

    Public Property PAGE_NO1 As Integer
        Get
            Return PAGE_NO
        End Get
        Set(value As Integer)
            PAGE_NO = value
        End Set
    End Property
#End Region

    Private Sub FO_WIZARD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BT_NEXT_Click(sender As Object, e As EventArgs) Handles BT_NEXT.Click
        Select Case PAGE_NO1
            Case 1

                PAGE_NO1 = 2
                UC_DOCUMENTO_D0M4_PRESUPUESTO1.Visible = False
                UC_PARAMETRO_POB1.Visible = True
            Case 2
                If PP_K_DOCUMENTO_D0M41 > 0 Then
                    PAGE_NO1 = 3
                    UC_DOCUMENTO_D0M4_PRESUPUESTO1.Visible = False
                    UC_PARAMETRO_POB1.Visible = True
                Else
                    MsgBox("Seleccione con doble click o agregue un nuevo documento")
                End If

        End Select

    End Sub

    Private Sub BT_BACK_Click(sender As Object, e As EventArgs) Handles BT_BACK.Click
        Select Case PAGE_NO1
            Case 1
                MessageBox.Show("Ya te encuentras en la primera seccion del wizard")

            Case 2
                PAGE_NO1 = 1
                UC_DOCUMENTO_D0M4_PRESUPUESTO1.Visible = True
                UC_PARAMETRO_POB1.Visible = False
            Case 3
                PAGE_NO1 = 2
                UC_DOCUMENTO_D0M4_PRESUPUESTO1.Visible = True
                UC_PARAMETRO_POB1.Visible = False


        End Select
    End Sub

    Private Sub BT_SALIR_Click(sender As Object, e As EventArgs) Handles BT_SALIR.Click
        PM_BT_SALIR_CLICK(Me)
    End Sub
    Private Sub PM_BT_SALIR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_SALIR_CLICK(PP_FORMA)
    End Sub
End Class