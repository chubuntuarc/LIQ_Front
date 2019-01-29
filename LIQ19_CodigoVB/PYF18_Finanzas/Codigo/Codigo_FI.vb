Public Class Codigo_FI

    Public Shared MoveForm As Boolean
    Public Shared MoveForm_MousePosition As Point

    Public Shared Function FG_FI_FIELDS_VALIDITY_COLOR(ByVal PP_CONTROLES As GroupBox) As Boolean
        Dim VP_VALIDACION_OK As Boolean
        VP_VALIDACION_OK = True

        Dim VP_CONTROL As Control
        For Each VP_CONTROL In PP_CONTROLES.Controls
            If VP_CONTROL.GetType() = GetType(TextBox) Or VP_CONTROL.GetType() = GetType(MaskedTextBox) Then
                VP_CONTROL.BackColor = Color.White

                If VP_CONTROL.Tag <> Nothing Then
                    If VP_CONTROL.Tag.ToString() = "1" And VP_CONTROL.Text = "" Then
                        VP_CONTROL.BackColor = Color.Yellow
                        VP_VALIDACION_OK = False
                    End If
                End If
            End If
        Next
        Return VP_VALIDACION_OK
    End Function

    Public Shared Sub FG_FI_LOAD_X_ID(ByVal PP_ID_BASE_DE_DATOS As Integer, ByRef PP_FORMA As Object, ByVal PP_ID As String)
        On Error Resume Next
        Dim VP_ROW As DataRow = Nothing
        PG_FI_CONTROL_CLEAR(PP_FORMA.GB_FICHA)
        VP_ROW = Codigo_ABC.FG_DC_ID_SEARCH(PP_ID_BASE_DE_DATOS, PP_FORMA, PP_ID)
        If VP_ROW IsNot Nothing Then
            PP_FORMA.PM_FI_CARGAR(VP_ROW)
        End If
        PG_FI_MOVE(PP_FORMA.GB_FICHA)
        On Error GoTo 0
    End Sub

    Public Shared Sub PG_FI_MOVE(ByRef PP_FICHA As GroupBox)
        On Error Resume Next

        Dim VP_FICHA As GroupBox = PP_FICHA
        AddHandler VP_FICHA.MouseDown, AddressOf MoveForm_MouseDown
        AddHandler VP_FICHA.MouseMove, AddressOf MoveForm_MouseMove
        AddHandler VP_FICHA.MouseUp, AddressOf MoveForm_MouseUp

        On Error GoTo 0
    End Sub

    Private Shared Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            sender.Cursor = Cursors.Default
        End If
    End Sub

    Private Shared Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs)
        If MoveForm Then
            sender.Location = sender.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Private Shared Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            sender.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Public Shared Sub FG_FI_LOAD_X_ID(ByVal PP_ID_BASE_DE_DATOS As Integer, ByRef PP_FORMA As Object, ByRef PP_FICHA As GroupBox, ByVal PP_ID As String)

        Dim VP_ROW As DataRow = Nothing
        PG_FI_CONTROL_CLEAR(PP_FICHA)
        VP_ROW = Codigo_ABC.FG_DC_ID_SEARCH(PP_ID_BASE_DE_DATOS, PP_FORMA, PP_ID)
        If VP_ROW IsNot Nothing Then
            PP_FORMA.PM_FI_CARGAR(VP_ROW)
        End If

    End Sub

    Public Shared Sub PG_FI_CONTROL_DATA_LOAD(ByRef PP_FORMA As Object, ByVal PP_ROW As DataRow)

        On Error Resume Next


        Codigo_CTRL.PG_CO_DATA_LOAD("", PP_FORMA.CB_USUARIO_ALTA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", PP_FORMA.TB_F_ALTA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", PP_FORMA.CB_USUARIO_CAMBIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", PP_FORMA.TB_F_CAMBIO, PP_ROW)

        On Error GoTo 0

    End Sub

    Public Shared Sub PG_FI_CONTROL_DATA_SETUP(ByVal PP_ID_BASE_DE_DATOS As Integer, ByRef PP_FORMA As Object)
        On Error Resume Next
        'wiwi
        Codigo_CB.PG_CB_LOAD_X_ORDEN(PP_ID_BASE_DE_DATOS, PP_FORMA, PP_FORMA.CB_ESTATUS_ACTIVO, "ESTATUS_ACTIVO")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(PP_ID_BASE_DE_DATOS, PP_FORMA, PP_FORMA.CB_USUARIO_ALTA, "USUARIO")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(PP_ID_BASE_DE_DATOS, PP_FORMA, PP_FORMA.CB_USUARIO_CAMBIO, "USUARIO")

        On Error GoTo 0

    End Sub

    Public Shared Sub PG_FI_CONTROL_CLEAR(ByRef PP_GROUPBOX As GroupBox)
        On Error Resume Next
        Dim VP_CONTROL_COLLECTION As New Collection
        PG_CONTROLS_CHILDRENS_GET(PP_GROUPBOX, GetType(TextBox), VP_CONTROL_COLLECTION)
        PG_CONTROLS_CHILDRENS_GET(PP_GROUPBOX, GetType(CheckBox), VP_CONTROL_COLLECTION)
        PG_CONTROLS_CHILDRENS_GET(PP_GROUPBOX, GetType(ComboBox), VP_CONTROL_COLLECTION)
        PG_CONTROLS_CHILDRENS_GET(PP_GROUPBOX, GetType(MaskedTextBox), VP_CONTROL_COLLECTION)
        PG_CONTROLS_CHILDRENS_GET(PP_GROUPBOX, GetType(DateTimePicker), VP_CONTROL_COLLECTION)
        For Each VP_CONTROL As Control In VP_CONTROL_COLLECTION
            Codigo_CTRL.PG_CO_CLEAR(VP_CONTROL)
        Next
        On Error GoTo 0
    End Sub

    Public Shared Sub PG_CN_CONFIG(ByRef PP_FORMA As Object)
        PP_FORMA.GB_FICHA.Enabled = (PP_FORMA.VM_IN_MODO_OPERACION = Modo_Operacion.Edición Or PP_FORMA.VM_IN_MODO_OPERACION = Modo_Operacion.Clon)
    End Sub

    Public Shared Sub PG_FI_FIELDS_VALIDATE(ByRef PP_FICHA As GroupBox, ByRef PP_VALIDACION As Boolean, ByRef PP_MENSAJE As String)

        PP_VALIDACION = FG_FI_FIELDS_VALIDITY_COLOR(PP_FICHA)

        If PP_VALIDACION = False Then
            PP_MENSAJE = "Los datos en amarillo son obligatorios."
        End If
    End Sub

End Class
