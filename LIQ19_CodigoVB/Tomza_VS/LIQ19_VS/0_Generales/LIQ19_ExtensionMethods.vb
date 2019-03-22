Imports System.Runtime.CompilerServices

Module LIQ19_ExtensionMethods

    '<Extension()>
    'Public Sub DoubleBuffered_g(ByRef dgv As DataGridView, ByVal setting As Boolean)
    '    Dim dgvType As Type = dgv.[GetType]()
    '    Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
    '    pi.SetValue(dgv, setting, Nothing)
    'End Sub

    'AX   //   EXTENSION METHODS PARA PERMITIR SÓLO VALORES DE TIPO NÚMERO EN LOS CONTROLES. 20190204
    <Extension()>
    Public Sub PG_TB_SOLO_DECIMALES(ByVal PP_NOMBRE_TB As TextBox, e As KeyPressEventArgs) ' Funciona con el evento KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not PP_NOMBRE_TB.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    <Extension()>
    Public Sub PG_TB_SOLO_ENTEROS(ByVal PP_NOMBRE_TB As TextBox, e As KeyPressEventArgs) ' Funciona con el evento KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Module
