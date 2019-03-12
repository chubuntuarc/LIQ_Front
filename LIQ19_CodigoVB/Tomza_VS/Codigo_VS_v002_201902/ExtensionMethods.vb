Imports System.Reflection
Imports System.Runtime.CompilerServices

Module ExtensionMethods

    <Extension()>
    Public Sub DoubleBuffered_g(ByRef dgv As DataGridView, ByVal setting As Boolean)
        Dim dgvType As Type = dgv.[GetType]()
        Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(dgv, setting, Nothing)
    End Sub

    ''' <summary>
    ''' 1 CONVIERTE LA PRIMERA LETRA DE CADA PALABRA A MAYUSCULA EJ. "el carro verde"--->"El Carro Verde"
    ''' 2 CONVIERTE TODO A MAYUSCULAS EJ. "CarRo" ---> "CARRO"
    ''' 3 CONVIERTE TODO A MINUSCULAS EJ "CArRo"--->"carro"
    ''' 4 CONVIERTE EN TIPO ORACION  EJ. "el carro verde"--->"El carro verde"
    ''' </summary>
    <Extension()>
    Public Function FG_STRING_FORMAT(ByVal PP_STRING As String, ByVal PP_TIPO As Integer)
        Select Case PP_TIPO
            Case 1  'CONVIERTE LA PRIMERAS LETRAS EN MAYUSCULA
                PP_STRING = StrConv(PP_STRING, vbProperCase)
            Case 2
                PP_STRING = StrConv(PP_STRING, vbUpperCase)
            Case 3
                PP_STRING = StrConv(PP_STRING, vbLowerCase)
            Case 4
                PP_STRING = SentenceCase(PP_STRING)
        End Select
        Return PP_STRING
    End Function


    Public Function SentenceCase(ByVal PP_STRING As String) As String
        Dim VP_STR_STRING() As Char
        VP_STR_STRING = PP_STRING.ToCharArray()
        Dim sentenceStart As Boolean = True
        VP_STR_STRING = CStr(VP_STR_STRING).ToLower
        For i = 0 To Len(VP_STR_STRING) - 1
            If sentenceStart Then VP_STR_STRING(i) = CStr(VP_STR_STRING(i)).ToUpper
            If VP_STR_STRING(i) <> " " Then sentenceStart = InStr(".!?", VP_STR_STRING(i))
        Next
        Dim VP_STRING As String
        VP_STRING = New String(VP_STR_STRING)
        Return VP_STRING
    End Function






    Public Sub PG_CONTROLS_CHILDRENS_GET(ByVal PP_CONTROL As Control, ByVal PP_TYPE As System.Type, ByRef PP_COLLECTION As Collection)

        For Each VP_CONTROL As Control In PP_CONTROL.Controls
            If VP_CONTROL.GetType() Is PP_TYPE Then
                PP_COLLECTION.Add(VP_CONTROL)
            ElseIf VP_CONTROL.GetType() Is GetType(GroupBox) Or VP_CONTROL.GetType() Is GetType(FlowLayoutPanel) Then
                PG_CONTROLS_CHILDRENS_GET(VP_CONTROL, PP_TYPE, PP_COLLECTION)
            End If
        Next

    End Sub

    Public Sub PG_CONTROLS_CHILDRENS_GET_X_NAME(ByVal PP_CONTROL As Control, ByVal PP_TYPE As System.Type, ByRef PP_COLLECTION As Collection)

        For Each VP_CONTROL As Control In PP_CONTROL.Controls
            If VP_CONTROL.GetType() Is PP_TYPE Then
                PP_COLLECTION.Add(VP_CONTROL, VP_CONTROL.Name)
            ElseIf VP_CONTROL.GetType() Is GetType(GroupBox) Or VP_CONTROL.GetType() Is GetType(FlowLayoutPanel) Or VP_CONTROL.GetType() Is GetType(Panel) Or VP_CONTROL.GetType() Is GetType(TableLayoutPanel) Then
                PG_CONTROLS_CHILDRENS_GET_X_NAME(VP_CONTROL, PP_TYPE, PP_COLLECTION)
            End If
        Next

    End Sub


    <Extension()>
    Public Sub PG_TB_SOLO_NUMEROS(ByVal PP_NOMBRE_TB As TextBox, e As KeyPressEventArgs) ' Funciona con el evento KeyPress
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

End Module
