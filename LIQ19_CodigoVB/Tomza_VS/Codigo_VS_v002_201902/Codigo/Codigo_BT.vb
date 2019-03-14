Public Class Codigo_BT
    Public Shared Sub PG_BT_INIT(ByRef PP_BOTON As Button)
        PP_BOTON.BackColor = Color.White
        AddHandler PP_BOTON.MouseHover, AddressOf PG_BT_MOUSEHOVER
        AddHandler PP_BOTON.MouseLeave, AddressOf PG_BT_MOUSELEAVE
        'PG_BT_TOOLTIP_ADD(PP_BOTON)
    End Sub

    Public Shared Sub PG_BT_TOOLTIP_ADD(ByRef PP_BOTON As Button)
        Try
            Dim VP_TOOLTIP As New ToolTip
            Dim ToolTip1 As ToolTip = New System.Windows.Forms.ToolTip()
            Dim VP_BOTON_TOOLTIP As String = ToolTip1.GetToolTip(PP_BOTON)

            If VP_BOTON_TOOLTIP = "" And PP_BOTON.Tag <> "" Then
                If PP_BOTON.Tag <> "" Then
                    VP_BOTON_TOOLTIP = PP_BOTON.Tag
                Else
                    Dim VP_NOMBRE_BOTON As String
                    VP_NOMBRE_BOTON = Right(PP_BOTON.Name, PP_BOTON.Name.Length - 3)
                    VP_NOMBRE_BOTON = VP_NOMBRE_BOTON.FG_STRING_FORMAT(4)
                    VP_NOMBRE_BOTON = VP_NOMBRE_BOTON.Replace("_", " ")
                    VP_BOTON_TOOLTIP = VP_NOMBRE_BOTON
                End If
                VP_TOOLTIP.SetToolTip(PP_BOTON, VP_BOTON_TOOLTIP)
            End If
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_TOOLTIP_ADD")
        End Try
    End Sub

    Private Shared Sub PG_BT_MOUSELEAVE(sender As Object, e As EventArgs)
        Dim VP_BOTON As Button = sender
        VP_BOTON.FlatAppearance.BorderSize = 0
        VP_BOTON.FlatAppearance.BorderColor = Color.White
    End Sub

    Private Shared Sub PG_BT_MOUSEHOVER(sender As Object, e As EventArgs)
        Dim VP_BOTON As Button = sender
        VP_BOTON.FlatAppearance.BorderSize = 1
        VP_BOTON.FlatAppearance.BorderColor = Color.DimGray
    End Sub

    Public Shared Sub PG_BT_DISABLE(ByRef PP_FORMA As Object)
        On Error Resume Next
        If PP_FORMA.BT_PUBLICAR.Enabled Then
            PP_FORMA.BT_PUBLICAR.Enabled = False
            PP_FORMA.LB_DISPONIBLE.Text = ""

        End If
        On Error GoTo 0
    End Sub

End Class
