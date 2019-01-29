Public Class FO_HUELLA



#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
    Public VM_ID_VERSION As Integer = 0

#End Region

    Public Sub PM_FO_SHOW(ByRef PP_NOMBRE_TABLA As String, ByVal PP_ID_BASE_DE_DATOS As String)
        VM_NOMBRE_TABLA = PP_NOMBRE_TABLA
        VM_ID_BASE_DE_DATOS = PP_ID_BASE_DE_DATOS
        Me.Show()
    End Sub

    Dim Capturer As DPFP.Capture.Capture
    Private Sub FO_HUELLA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Capturer = New DPFP.Capture.Capture
        Dim VP_VERIFICACION As New Verificacion(Capturer, PB_HUELLA, RT_ESTATUS, LB_PROMPT)
        VP_VERIFICACION.Init()

    End Sub
End Class