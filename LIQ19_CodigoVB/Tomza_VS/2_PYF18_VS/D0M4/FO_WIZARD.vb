Public Class FO_WIZARD
#Region "VARIABLES Y CONSTANTES MODULARES"

    Public PP_UNIDAD_OPERATIVA As Integer = 0
    Public PP_YYYY As Integer = 0
    Public PP_MES As Integer = 0
    Public PP_K_PRECIO_COSTO_PERFIL As Integer = 0
    Public PP_K_DOCUMENTO_D0M4 As Integer = 0
    Public PP_K_PARAMETRO_DOCUMENTO_D0M4 As Integer = 0
    Public PAGE_NO As Integer = 1
#End Region

    Private Sub FO_WIZARD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BT_NEXT_Click(sender As Object, e As EventArgs) Handles BT_NEXT.Click
        Select Case PAGE_NO
            Case 1
                If PP_K_PRECIO_COSTO_PERFIL > 0 Then
                    PAGE_NO = 2
                    UC_DOCUMENTO_D0M41.Visible = True
                    UC_PRECIO_COSTO_PERFIL1.Visible = False
                    UC_PARAMETRO_DOCUMENTO_D0M41.Visible = False
                Else
                    MsgBox("Seleccione con doble click o agregue un nuevo perfil de precio/costo")
                End If

            Case 2
                If PP_K_DOCUMENTO_D0M4 > 0 Then
                    PAGE_NO = 3
                    UC_DOCUMENTO_D0M41.Visible = False
                    UC_PRECIO_COSTO_PERFIL1.Visible = False
                    UC_PARAMETRO_DOCUMENTO_D0M41.Visible = True
                Else
                    MsgBox("Seleccione con doble click o agregue un nuevo documento")
                End If

        End Select

    End Sub

    Private Sub BT_BACK_Click(sender As Object, e As EventArgs) Handles BT_BACK.Click
        Select Case PAGE_NO
            Case 1
                MessageBox.Show("Ya te encuentras en la primera seccion del wizard")

            Case 2
                PAGE_NO = 1
                UC_DOCUMENTO_D0M41.Visible = False
                UC_PRECIO_COSTO_PERFIL1.Visible = True
                UC_PARAMETRO_DOCUMENTO_D0M41.Visible = False
            Case 3
                PAGE_NO = 2
                UC_DOCUMENTO_D0M41.Visible = True
                UC_PRECIO_COSTO_PERFIL1.Visible = False
                UC_PARAMETRO_DOCUMENTO_D0M41.Visible = False


        End Select
    End Sub

    Private Sub BT_CALC_Click(sender As Object, e As EventArgs) Handles BT_CALC.Click
        If PP_K_DOCUMENTO_D0M4 = 0 Or PP_K_PRECIO_COSTO_PERFIL = 0 Then
            MessageBox.Show("IMPOSIBLE GENERAR SIN HABER SELECCIONADO UN PERFIL, UN DOCUMENTO Y SUS PARAMETROS")
        End If
    End Sub

    Private Sub BT_SALIR_Click(sender As Object, e As EventArgs) Handles BT_SALIR.Click
        PM_BT_SALIR_CLICK(Me)
    End Sub
    Private Sub PM_BT_SALIR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_SALIR_CLICK(PP_FORMA)
    End Sub
End Class