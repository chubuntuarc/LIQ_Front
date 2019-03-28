Imports System.Text.RegularExpressions
Public Class Codigo_CTRL
    Public Shared Sub PG_CO_PARAMETRO(ByRef PP_PARAMETROS As String, ByVal PP_CONTROL As Object, ByVal PP_DELIMITADOR As Boolean)
        Dim VP_VALOR As String = ""

        If PP_CONTROL.GetType() = GetType(TextBox) Then
            VP_VALOR = PP_CONTROL.Text
        End If

        If PP_CONTROL.GetType() = GetType(ComboBox) Then
            VP_VALOR = Codigo_CB.FG_CB_ITEM_VALUE(PP_CONTROL)
        End If

        If PP_CONTROL.GetType() = GetType(CheckBox) Then
            Dim VP_CONTROL As CheckBox
            VP_CONTROL = PP_CONTROL

            VP_VALOR = Math.Abs(CInt(VP_CONTROL.Checked)).ToString()
        End If

        If PP_CONTROL.GetType() = GetType(DataGridViewTextBoxCell) Then
            Dim VP_CONTROL As DataGridViewTextBoxCell
            VP_CONTROL = CType(PP_CONTROL, DataGridViewTextBoxCell)
            VP_VALOR = VP_CONTROL.Value

        End If

        If PP_CONTROL.GetType() = GetType(MonthCalendar) Then
            Try
                If Not (VP_VALOR Is Nothing) Then
                    VP_VALOR = Codigo_ABC.FG_DT_CONVIERTE_FECHA_US_A_SQL(PP_CONTROL.SelectionStart.ToString())
                End If
            Catch ex As Exception

            End Try

        End If


        If PP_CONTROL.GetType() = GetType(DateTimePicker) Then
            Dim VP_CONTROL_DATEPICKER As DateTimePicker = PP_CONTROL
            Dim VP_FECHA_STRING As String = ""
            VP_FECHA_STRING = VP_CONTROL_DATEPICKER.Value.ToString("yyyy-MM-dd")
            VP_VALOR = VP_FECHA_STRING
        End If

        If PP_CONTROL.GetType() = GetType(MaskedTextBox) Then
            Dim VP_STRING_VALIDACION As String = ""
            Codigo_CTRL.PG_TB_DATE_VALIDATE(VP_STRING_VALIDACION, PP_CONTROL)

            'Dim VP_FECHA As String() = TryCast(PP_CONTROL, MaskedTextBox).Text.Split("/")
            'Dim VP_DIA As String = VP_FECHA(0) : Dim VP_MES As String = VP_FECHA(1) : Dim VP_AÑO As String = VP_FECHA(2)
            'Dim VP_FECHA_VALIDAR As String = VP_DIA + "/" + VP_MES + "/" + VP_AÑO
            If VP_STRING_VALIDACION = "" And PP_CONTROL.Text <> "  /  /" Then
                Dim VP_FECHA As String() = PP_CONTROL.Text.Split("/")
                Dim VP_DIA As String = VP_FECHA(0) : Dim VP_MES As String = VP_FECHA(1) : Dim VP_AÑO As String = VP_FECHA(2)
                Dim VP_FECHA_SQL As String = VP_AÑO + "-" + VP_MES + "-" + VP_DIA
                VP_VALOR = VP_FECHA_SQL
            Else
                If VP_STRING_VALIDACION <> "" Then
                    Codigo_Mensaje.PG_MENSAJE_AVISO(VP_STRING_VALIDACION)
                End If
                VP_VALOR = "NULL"
                PP_DELIMITADOR = False
            End If
        End If

        If PP_CONTROL.GetType() = GetType(String) Then
            VP_VALOR = PP_CONTROL
        End If

        If PP_CONTROL.GetType() = GetType(Integer) Then
            VP_VALOR = PP_CONTROL.ToString()
        End If

        If PP_DELIMITADOR Then
            VP_VALOR = "'" + VP_VALOR + "'"
        End If

        If PP_PARAMETROS = "" Then
            PP_PARAMETROS = " " + VP_VALOR + " "
        Else
            PP_PARAMETROS = PP_PARAMETROS + ", " + VP_VALOR + " "
        End If

    End Sub

    Public Shared Sub PG_CO_PARAMETRO_FECHA(ByRef PP_PARAMETROS As String, ByVal PP_CONTROL As Object, ByVal PP_DELIMITADOR As Boolean)
        Dim VP_VALOR As String = ""


        If PP_CONTROL.GetType() = GetType(MonthCalendar) Then
            Try
                If Not (VP_VALOR Is Nothing) Then

                    VP_VALOR = Codigo_ABC.FG_DT_CONVIERTE_FECHA_A_SQL(PP_CONTROL.SelectionStart.ToString())
                End If
            Catch ex As Exception

            End Try

        End If


        If PP_CONTROL.GetType() = GetType(DateTimePicker) Then
            Try
                If Not (VP_VALOR Is Nothing) Then
                    VP_VALOR = Codigo_ABC.FG_DT_CONVIERTE_FECHA_A_SQL(PP_CONTROL.Text)
                End If
            Catch ex As Exception

            End Try

        End If

        If PP_CONTROL.GetType() = GetType(MaskedTextBox) Then
            Dim VP_STRING_VALIDACION As String = ""
            Codigo_CTRL.PG_TB_DATE_VALIDATE(VP_STRING_VALIDACION, PP_CONTROL)

            'Dim VP_FECHA As String() = TryCast(PP_CONTROL, MaskedTextBox).Text.Split("/")
            'Dim VP_DIA As String = VP_FECHA(0) : Dim VP_MES As String = VP_FECHA(1) : Dim VP_AÑO As String = VP_FECHA(2)
            'Dim VP_FECHA_VALIDAR As String = VP_DIA + "/" + VP_MES + "/" + VP_AÑO
            If VP_STRING_VALIDACION = "" And PP_CONTROL.Text <> "  /  /" Then
                Dim VP_FECHA As String() = PP_CONTROL.Text.Split("/")
                Dim VP_DIA As String = VP_FECHA(0) : Dim VP_MES As String = VP_FECHA(1) : Dim VP_AÑO As String = VP_FECHA(2)
                Dim VP_FECHA_SQL As String = VP_AÑO + "-" + VP_MES + "-" + VP_DIA
                VP_VALOR = VP_FECHA_SQL
            Else
                If VP_STRING_VALIDACION <> "" Then
                    Codigo_Mensaje.PG_MENSAJE_AVISO(VP_STRING_VALIDACION)
                End If
                VP_VALOR = "NULL"
                PP_DELIMITADOR = False
            End If
        End If

        If PP_CONTROL.GetType() = GetType(String) Then
            VP_VALOR = Codigo_ABC.FG_DT_CONVIERTE_FECHA_A_SQL(PP_CONTROL)
        End If

        If PP_DELIMITADOR Then
            VP_VALOR = "'" + VP_VALOR + "'"
        End If

        If PP_PARAMETROS = "" Then
            PP_PARAMETROS = " " + VP_VALOR + " "
        Else
            PP_PARAMETROS = PP_PARAMETROS + ", " + VP_VALOR + " "
        End If

    End Sub

    Public Shared Function FG_CO_VALUE(ByVal PP_CONTROL As Object)
        Dim VP_VALOR As String = ""

        If PP_CONTROL.GetType() = GetType(TextBox) Then
            VP_VALOR = PP_CONTROL.Text
        End If

        If PP_CONTROL.GetType() = GetType(ComboBox) Then
            VP_VALOR = Codigo_CB.FG_CB_ITEM_VALUE(PP_CONTROL)
        End If

        If PP_CONTROL.GetType() = GetType(CheckBox) Then
            Dim VP_CONTROL As CheckBox
            VP_CONTROL = PP_CONTROL

            VP_VALOR = Math.Abs(CInt(VP_CONTROL.Checked)).ToString()
        End If

        If PP_CONTROL.GetType() = GetType(DataGridViewTextBoxCell) Then
            Dim VP_CONTROL As DataGridViewTextBoxCell
            VP_CONTROL = CType(PP_CONTROL, DataGridViewTextBoxCell)
            VP_VALOR = VP_CONTROL.Value
        End If

        If PP_CONTROL.GetType() = GetType(DateTimePicker) Then
            Try
                If Not (VP_VALOR Is Nothing) Then
                    VP_VALOR = PP_CONTROL.Text
                End If
            Catch ex As Exception

            End Try
        End If

        If PP_CONTROL.GetType() = GetType(String) Then
            VP_VALOR = PP_CONTROL
        End If

        If PP_CONTROL.GetType() = GetType(Integer) Then
            VP_VALOR = PP_CONTROL.ToString()
        End If

        Return VP_VALOR

    End Function

    Public Shared Sub PG_CO_PARAMETRO_CORREO(ByRef PP_PARAMETROS As String, ByVal PP_CONTROL As Object)
        Dim VP_VALOR As String = ""

        If PP_CONTROL.GetType() = GetType(DataGridViewTextBoxCell) Then
            Dim VP_CONTROL As DataGridViewTextBoxCell
            VP_CONTROL = CType(PP_CONTROL, DataGridViewTextBoxCell)
            VP_VALOR = VP_CONTROL.Value

        End If

        If PP_PARAMETROS = "" Then
            If VP_VALOR = " " Then
                PP_PARAMETROS = PP_PARAMETROS
            Else
                PP_PARAMETROS = VP_VALOR
            End If

        Else
            If VP_VALOR = " " Then
                PP_PARAMETROS = PP_PARAMETROS
            Else
                PP_PARAMETROS = PP_PARAMETROS + "," + VP_VALOR
            End If

        End If
    End Sub
    'Public Shared Sub PG_CO_PARAMETRO_CORREO(ByRef PP_MENSAJE_VALIDACION As String, ByRef PP_CONTROL As TextBox)
    '    'Dim REGEX_RESULT = Regex.IsMatch(PP_CONTROL.Text,
    '    '   "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$", "")

    '    If PP_MENSAJE_VALIDACION = "" Then
    '        Dim expresion = "\ b [ A - Z 0 - 9 ._% + - ] + @ [ A - Z 0 - 9 . - ] + \. [ A - Z ] {2,} \ b"

    '        If Not (Regex.IsMatch(PP_CONTROL.Text, expresion)) Then
    '            'Error = False
    '            Dim VP_NOMBRE_CAMPO = PP_CONTROL.Name
    '            PP_MENSAJE_VALIDACION = "Se requiere un valor valido para el <" + Right(PP_CONTROL.Name, 6) + ">"
    '            PP_CONTROL.BackColor = Color.LightBlue
    '            PP_CONTROL.Select()
    '        End If

    '    End If

    'End Sub
    ''' <summary>
    ''' Si PP_NOMBRE_TABLA viene vacio, tomara el nombre del control, de lo contrario lo construira con el PP_NOMBRE_TABLA 
    ''' </summary>
    Public Shared Sub PG_CO_DATA_LOAD_GENERICO(ByVal PP_NOMBRE_TABLA As String, ByRef PP_CONTROL As Control, ByVal PP_ROW As DataRow, Optional ByVal PP_VALOR_DEFAULT As String = "")
        Try
            Dim VP_NOMBRE_CAMPO As String = ""
            VP_NOMBRE_CAMPO = PP_CONTROL.Name
            VP_NOMBRE_CAMPO = Right(VP_NOMBRE_CAMPO, (VP_NOMBRE_CAMPO.Length - 3))


            If PP_CONTROL.GetType() = GetType(ComboBox) Then
                VP_NOMBRE_CAMPO = "K_" + VP_NOMBRE_CAMPO
            ElseIf PP_NOMBRE_TABLA <> "" Then
                VP_NOMBRE_CAMPO = Left(VP_NOMBRE_CAMPO, 2) + PP_NOMBRE_TABLA

            End If

            Dim VP_VALOR As String = ""
            VP_VALOR = Codigo_SQL.FG_CO_DATA_READ(PP_ROW, VP_NOMBRE_CAMPO, PP_VALOR_DEFAULT)

            If VP_VALOR Is Nothing Then
                VP_VALOR = ""
            End If

            If PP_CONTROL.GetType() = GetType(TextBox) Then
                PP_CONTROL.Text = VP_VALOR
            End If

            If PP_CONTROL.GetType() = GetType(ComboBox) Then
                Codigo_CB.PG_CB_VALUE_LOAD(PP_CONTROL, VP_VALOR)
            End If

            If PP_CONTROL.GetType() = GetType(CheckBox) Then
                Dim VP_CONTROL As CheckBox
                VP_CONTROL = PP_CONTROL

                VP_CONTROL.Checked = (CInt(VP_VALOR) = 1)

            End If

            If PP_CONTROL.GetType() = GetType(DateTimePicker) Then
                Dim VP_TIME As DateTimePicker = PP_CONTROL
                If String.IsNullOrWhiteSpace(VP_VALOR) Then
                    VP_TIME.Format = DateTimePickerFormat.Custom
                    VP_TIME.CustomFormat = " "
                    VP_TIME.Value = Date.FromOADate(0)
                    VP_TIME.Enabled = False
                Else
                    If Not (VP_VALOR Is Nothing) Then
                        PP_CONTROL.Text = VP_VALOR
                    End If
                End If
            End If

            If PP_CONTROL.GetType() = GetType(MaskedTextBox) And VP_NOMBRE_CAMPO Like "*F_*" Then
                Dim VP_VALOR_FECHA As Date
                VP_VALOR_FECHA = Codigo_SQL.FG_CO_DATA_READ_FECHA(PP_ROW, VP_NOMBRE_CAMPO, PP_VALOR_DEFAULT)
                Dim VP_FECHA_MOSTRAR As String = VP_VALOR_FECHA.ToString("ddMMyyyy")
                PP_CONTROL.Text = VP_FECHA_MOSTRAR
            End If


        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' Si PP_NOMBRE_TABLA viene vacio, tomara el nombre del control, de lo contrario lo construira con el PP_NOMBRE_TABLA 
    ''' </summary>
    Public Shared Sub PG_CO_DATA_LOAD(ByVal PP_NOMBRE_CAMPO As String, ByRef PP_CONTROL As Control, ByVal PP_ROW As DataRow, Optional ByVal PP_VALOR_DEFAULT As String = "")
        Try
            Dim VP_NOMBRE_CAMPO As String = ""
            VP_NOMBRE_CAMPO = PP_CONTROL.Name
            VP_NOMBRE_CAMPO = Right(VP_NOMBRE_CAMPO, (VP_NOMBRE_CAMPO.Length - 3))


            If PP_CONTROL.GetType() = GetType(ComboBox) Then
                VP_NOMBRE_CAMPO = "K_" + VP_NOMBRE_CAMPO
            ElseIf PP_NOMBRE_CAMPO <> "" Then
                VP_NOMBRE_CAMPO = Left(VP_NOMBRE_CAMPO, 2) + PP_NOMBRE_CAMPO

            End If

            If PP_NOMBRE_CAMPO <> "" Then
                VP_NOMBRE_CAMPO = PP_NOMBRE_CAMPO
            End If

            Dim VP_VALOR As String = ""
            VP_VALOR = Codigo_SQL.FG_CO_DATA_READ(PP_ROW, VP_NOMBRE_CAMPO, PP_VALOR_DEFAULT)

            If VP_VALOR Is Nothing Then
                VP_VALOR = ""
            End If

            If PP_CONTROL.GetType() = GetType(TextBox) Then
                PP_CONTROL.Text = VP_VALOR
            End If

            If PP_CONTROL.GetType() = GetType(ComboBox) Then
                Codigo_CB.PG_CB_VALUE_LOAD(PP_CONTROL, VP_VALOR)
            End If

            If PP_CONTROL.GetType() = GetType(CheckBox) Then
                Dim VP_CONTROL As CheckBox
                Dim VP_CHECK As Boolean
                VP_VALOR = VP_VALOR.ToUpper
                VP_CHECK = Not ((VP_VALOR = "FALSE") Or (VP_VALOR = "FALSO") Or (VP_VALOR = "0"))
                VP_CONTROL = PP_CONTROL

                'VP_CONTROL.Checked = (CInt(VP_VALOR) = 1)
                VP_CONTROL.Checked = (CInt(VP_CHECK) = 1 Or (VP_CHECK = True))

            End If






            If PP_CONTROL.GetType() = GetType(DateTimePicker) Then
                Dim VP_TIME As DateTimePicker = PP_CONTROL
                If String.IsNullOrWhiteSpace(VP_VALOR) Then
                    VP_TIME.Format = DateTimePickerFormat.Custom
                    VP_TIME.CustomFormat = " "
                    VP_TIME.Value = Date.FromOADate(0)
                    VP_TIME.Enabled = False
                Else
                    If Not (VP_VALOR Is Nothing) Then
                        PP_CONTROL.Text = VP_VALOR
                    End If
                End If
            End If

            If PP_CONTROL.GetType() = GetType(MaskedTextBox) And VP_NOMBRE_CAMPO Like "*F_*" Then
                Dim VP_VALOR_FECHA As Date
                VP_VALOR_FECHA = Codigo_SQL.FG_CO_DATA_READ_FECHA(PP_ROW, VP_NOMBRE_CAMPO, PP_VALOR_DEFAULT)
                Dim VP_FECHA_MOSTRAR As String = VP_VALOR_FECHA.ToString("ddMMyyyy")
                PP_CONTROL.Text = VP_FECHA_MOSTRAR
            End If


        Catch ex As Exception

        End Try

    End Sub


    ''' <summary>
    ''' Si PP_NOMBRE_TABLA viene vacio, tomara el nombre del control, de lo contrario lo construira con el PP_NOMBRE_TABLA 
    ''' </summary>
    Public Shared Sub PG_CO_DATA_LOAD_CURRENCY(ByVal PP_NOMBRE_CAMPO As String, ByRef PP_CONTROL As Control, ByVal PP_ROW As DataRow, Optional ByVal PP_VALOR_DEFAULT As String = "")
        Try
            Dim VP_NOMBRE_CAMPO As String = ""
            VP_NOMBRE_CAMPO = PP_CONTROL.Name
            VP_NOMBRE_CAMPO = Right(VP_NOMBRE_CAMPO, (VP_NOMBRE_CAMPO.Length - 3))

            If PP_NOMBRE_CAMPO <> "" Then
                VP_NOMBRE_CAMPO = Left(VP_NOMBRE_CAMPO, 2) + PP_NOMBRE_CAMPO
            End If

            If PP_NOMBRE_CAMPO <> "" Then
                VP_NOMBRE_CAMPO = PP_NOMBRE_CAMPO
            End If

            Dim VP_VALOR As String = ""
            VP_VALOR = Codigo_SQL.FG_CO_DATA_READ(PP_ROW, VP_NOMBRE_CAMPO, PP_VALOR_DEFAULT)

            If VP_VALOR Is Nothing Then
                VP_VALOR = ""
            End If

            PP_CONTROL.Text = VP_VALOR

            If PP_CONTROL.GetType() = GetType(TextBox) Then
                Dim VP_VALOR_NUMERICO = Convert.ToDouble(VP_VALOR)
                ' PP_CONTROL.Text = VP_VALOR_NUMERICO.ToString("N2")
                PP_CONTROL.Text = Format(VP_VALOR_NUMERICO, "0.00")
                Dim VP_CONTROL As TextBox = PP_CONTROL
                VP_CONTROL.TextAlign = HorizontalAlignment.Right
            End If

        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub PG_CO_DATA_LOAD_MONEY(ByVal PP_NOMBRE_CAMPO As String, ByRef PP_CONTROL As Control, ByVal PP_ROW As DataRow, Optional ByVal PP_VALOR_DEFAULT As String = "")
        Try
            Dim VP_NOMBRE_CAMPO As String = ""
            VP_NOMBRE_CAMPO = PP_CONTROL.Name
            VP_NOMBRE_CAMPO = Right(VP_NOMBRE_CAMPO, (VP_NOMBRE_CAMPO.Length - 3))

            If PP_NOMBRE_CAMPO <> "" Then
                VP_NOMBRE_CAMPO = Left(VP_NOMBRE_CAMPO, 2) + PP_NOMBRE_CAMPO
            End If

            If PP_NOMBRE_CAMPO <> "" Then
                VP_NOMBRE_CAMPO = PP_NOMBRE_CAMPO
            End If

            Dim VP_VALOR As String = ""
            VP_VALOR = Codigo_SQL.FG_CO_DATA_READ(PP_ROW, VP_NOMBRE_CAMPO, PP_VALOR_DEFAULT)

            If VP_VALOR Is Nothing Then
                VP_VALOR = ""
            End If

            PP_CONTROL.Text = VP_VALOR

            If PP_CONTROL.GetType() = GetType(TextBox) Then
                Dim VP_VALOR_NUMERICO = Convert.ToDecimal(VP_VALOR)
                'PP_CONTROL.Text = VP_VALOR_NUMERICO.ToString("N2")
                PP_CONTROL.Text = Format(VP_VALOR_NUMERICO, "0.00")
                Dim VP_CONTROL As TextBox = PP_CONTROL
                VP_CONTROL.TextAlign = HorizontalAlignment.Right
            End If
        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>
    ''' PARA SACAR EL DATO Y PONERLO EN UN STRING 
    ''' </summary>
    Public Shared Sub PG_CO_DATA_LOAD(ByVal PP_NOMBRE_COLUMNA As String, ByRef PP_CONTROL As String, ByVal PP_ROW As DataRow, Optional ByVal PP_VALOR_DEFAULT As String = "")
        Dim VP_NOMBRE_CAMPO As String = ""
        VP_NOMBRE_CAMPO = PP_NOMBRE_COLUMNA

        Dim VP_VALOR As String = ""
        VP_VALOR = Codigo_SQL.FG_CO_DATA_READ(PP_ROW, VP_NOMBRE_CAMPO, PP_VALOR_DEFAULT)

        PP_CONTROL = VP_VALOR

    End Sub

    Public Shared Sub PG_TB_INTEGER_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String, ByRef PP_CONTROL As TextBox)

        If PP_MENSAJE_VALIDACION = "" Then
            If IsNumeric(PP_CONTROL.Text) Then
                PP_CONTROL.Text = CInt(PP_CONTROL.Text)
            Else
                Dim VP_NOMBRE_CAMPO As String = ""
                If PP_CONTROL.Name Like "*_O_*" Then
                    VP_NOMBRE_CAMPO = "Orden"
                Else
                    VP_NOMBRE_CAMPO = PP_CONTROL.Name
                End If

                PP_MENSAJE_VALIDACION = "Se requiere un valor entero en <" + VP_NOMBRE_CAMPO + ">"
                PP_CONTROL.BackColor = Color.LightBlue
                PP_CONTROL.Select()
            End If

        End If
    End Sub

    Public Shared Sub PG_TB_NUMERIC_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String, ByRef PP_CONTROL As TextBox)

        If PP_MENSAJE_VALIDACION = "" Then
            If Not IsNumeric(PP_CONTROL.Text) Then
                PP_MENSAJE_VALIDACION = "Se requiere un valor numérico en <" + Right(PP_CONTROL.Name, PP_CONTROL.Name.Length - 3) + ">"
                PP_CONTROL.BackColor = Color.LightBlue

            End If

        End If
    End Sub

    Public Shared Sub PG_TB_MAYOR_A_CERO(ByRef PP_MENSAJE_VALIDACION As String, ByRef PP_CONTROL As TextBox)

        If PP_MENSAJE_VALIDACION = "" Then
            PG_TB_NUMERIC_VALIDATE(PP_MENSAJE_VALIDACION, PP_CONTROL)
            If PP_MENSAJE_VALIDACION = "" Then
                Dim VP_VALOR As Decimal = Codigo_CTRL.FG_CO_VALUE(PP_CONTROL)
                If VP_VALOR < 0 Then
                    PP_MENSAJE_VALIDACION = "Se requiere un valor numérico mayor a cero en <" + Right(PP_CONTROL.Name, PP_CONTROL.Name.Length - 3) + ">"
                    PP_CONTROL.BackColor = Color.LightBlue
                End If
            End If
        End If
    End Sub

    Public Shared Sub PG_CB_MAYOR_A_CERO(ByRef PP_MENSAJE_VALIDACION As String, ByRef PP_CONTROL As ComboBox)

        If PP_MENSAJE_VALIDACION = "" Then
            Dim VP_VALOR As Decimal = Codigo_CTRL.FG_CO_VALUE(PP_CONTROL)
            If VP_VALOR < 0 Then
                PP_MENSAJE_VALIDACION = "Seleccione una opcion en el control <" + Right(PP_CONTROL.Name, PP_CONTROL.Name.Length - 3) + ">"
                PP_CONTROL.BackColor = Color.LightBlue
            End If
        End If
    End Sub

    Public Shared Sub PG_TB_INIT(ByRef PP_CONTROL As TextBox, ByVal PP_FORMATO As Integer)
        If PP_FORMATO = 1 Then 'TIPO NUMERICO DINERO
            PP_CONTROL.TextAlign = HorizontalAlignment.Right
            PP_CONTROL.Text = 0
            AddHandler PP_CONTROL.KeyPress, AddressOf PP_CONTROL_KEYPRESS
        End If

    End Sub

    Private Shared Sub PP_CONTROL_KEYPRESS(sender As Object, e As KeyPressEventArgs)
        Dim PP_CONTROL As TextBox = sender
        PP_CONTROL.PG_TB_SOLO_NUMEROS(e)
    End Sub

    Public Shared Sub PG_TB_DATE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String, ByRef PP_CONTROL As MaskedTextBox)
        PP_CONTROL.BackColor = Color.White
        If PP_MENSAJE_VALIDACION = "" And PP_CONTROL.Text <> "  /  /" Then
            Dim VP_ES_FECHA As Boolean = False
            Dim VP_FECHA_STR As String() = PP_CONTROL.Text.Split("/")

            Try
                Dim VP_FECHA As Date = New Date(VP_FECHA_STR(2), VP_FECHA_STR(1), VP_FECHA_STR(0))
                If IsDate(VP_FECHA) Then
                    If VP_FECHA < (Now.AddYears(-50)) Then
                        PP_MENSAJE_VALIDACION = "Se requiere una fecha válida en [" + Right(PP_CONTROL.Name, PP_CONTROL.Name.LongCount - 3) + "]"
                        PP_CONTROL.BackColor = Color.LightBlue
                    End If
                Else
                    PP_MENSAJE_VALIDACION = "Se requiere una fecha válida en [" + Right(PP_CONTROL.Name, PP_CONTROL.Name.LongCount - 3) + "]"
                    PP_CONTROL.BackColor = Color.LightBlue
                End If
            Catch ex As Exception
                PP_MENSAJE_VALIDACION = "Se requiere una fecha válida en [" + Right(PP_CONTROL.Name, PP_CONTROL.Name.LongCount - 3) + "]"
                PP_CONTROL.BackColor = Color.LightBlue
            End Try
        ElseIf PP_CONTROL.Text = "  /  /" And Not PP_CONTROL.Name Like "*_LI_*" Then
            PP_MENSAJE_VALIDACION = "Se requiere una fecha válida en [" + Right(PP_CONTROL.Name, PP_CONTROL.Name.LongCount - 3) + "]"
        End If
    End Sub

    Public Shared Sub PG_CO_CLEAR(ByRef PP_CONTROL As Control)
        On Error Resume Next
        If PP_CONTROL.GetType() = GetType(TextBox) Then
            PP_CONTROL.Text = ""
            PP_CONTROL.BackColor = Color.White
        End If

        If PP_CONTROL.GetType() = GetType(ComboBox) Then
            Dim VP_COMBO As ComboBox
            VP_COMBO = PP_CONTROL
            VP_COMBO.SelectedIndex = 0
        End If

        If PP_CONTROL.GetType() = GetType(CheckBox) Then
            Dim VP_CONTROL As CheckBox
            VP_CONTROL = PP_CONTROL
            VP_CONTROL.Checked = True
            VP_CONTROL.BackColor = Color.White
        End If

        If PP_CONTROL.GetType() = GetType(MaskedTextBox) Then
            PP_CONTROL.Text = ""
            PP_CONTROL.BackColor = Color.White
        End If

        If PP_CONTROL.GetType() = GetType(DateTimePicker) Then
            PP_CONTROL.Text = ""
            PP_CONTROL.BackColor = Color.White
        End If
        On Error GoTo 0

    End Sub

    Public Shared Sub PG_CO_KEYPREES(ByVal PP_ASCII_CODE As Char, ByRef PP_CONTROL_FST As Control, ByRef PP_CONTROL_SCD As Control)
        If PP_ASCII_CODE = Convert.ToChar(Keys.Enter) Then
            If Not FG_CO_SET_FOCUS(PP_CONTROL_FST) Then
                FG_CO_SET_FOCUS(PP_CONTROL_SCD)
            End If
        End If
    End Sub

    Public Shared Function FG_CO_SET_FOCUS(ByRef PP_CONTROL As Control) As Boolean
        On Error Resume Next
        PP_CONTROL.Select()

        If PP_CONTROL.Focused = True Then
            Return True
        Else
            Return False
        End If

        On Error GoTo 0
    End Function

    Public Shared Sub PG_MT_TOOLTIP_ADD(ByRef PP_MASKEDTEXTBOX As MaskedTextBox)
        Dim VP_TOOLTIP As New ToolTip

        Dim ToolTip1 As ToolTip = New System.Windows.Forms.ToolTip()
        Dim VP_MASKEDTEXTBOX_TOOLTIP As String = "Formato aceptado [DD/MM/YYYY]"
        VP_TOOLTIP.SetToolTip(PP_MASKEDTEXTBOX, VP_MASKEDTEXTBOX_TOOLTIP)

    End Sub

End Class
