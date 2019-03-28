Public Class Codigo_CB

#Region "CB_Custom"


    Public Shared Sub PG_CB_YYYY_MM_Load(ByVal PP_BD_Index As Integer, ByVal PP_FORMA As Object, ByRef PP_CB_YYYY As ComboBox, ByRef PP_CB_MES As ComboBox)

        Codigo_CB.PG_CB_LOAD_X_ORDEN(PP_BD_Index, PP_FORMA, PP_CB_YYYY)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(PP_BD_Index, PP_FORMA, PP_CB_MES)

    End Sub

    Public Shared Sub PG_CB_YYYY_MM_Hoy_Set(ByVal PP_BD_Index As Integer, ByRef PP_CB_YYYY As ComboBox, ByRef PP_CB_MES As ComboBox)

        Dim VP_K_YYYY As Integer
        Dim VP_K_MES As Integer

        Codigo_SP.PG_RN_FECHA_HOY_YYYY_MM_GET(PP_BD_Index, VP_K_YYYY, VP_K_MES)

        Codigo_CB.PG_CB_VALUE_LOAD(PP_CB_YYYY, VP_K_YYYY)
        Codigo_CB.PG_CB_VALUE_LOAD(PP_CB_MES, VP_K_MES)

    End Sub

    Public Shared Sub PG_CB_YYYY_MM_Init_Hoy(ByVal PP_BD_Index As Integer, ByVal PP_FORMA As Object, ByRef PP_CB_YYYY As ComboBox, ByRef PP_CB_MES As ComboBox)

        Codigo_CB.PG_CB_YYYY_MM_Load(PP_BD_Index, PP_FORMA, PP_CB_YYYY, PP_CB_MES)

        Codigo_CB.PG_CB_YYYY_MM_Hoy_Set(PP_BD_Index, PP_CB_YYYY, PP_CB_MES)

    End Sub


#End Region

#Region "SUBS"

    Public Shared Sub PG_CB_INIT(ByRef PP_CB_COMBO As ComboBox)
        Try
            PP_CB_COMBO.BackColor = Color.White
            PG_CB_CLEAR(PP_CB_COMBO)
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CB_INIT")
        End Try
    End Sub

    Public Shared Sub PG_CB_LOAD_BASICO(ByVal PP_BD_Index As Integer, ByVal PP_FORMA As Object, ByRef PP_CB_COMBO As ComboBox, ByVal PP_L_USAR_ORDEN As Integer, Optional ByVal PP_NOMBRE_TABLA As String = "")
        Try
            PG_CB_INIT(PP_CB_COMBO)

            Dim VP_PARAMETROS As String

            Dim VP_NOMBRE_TABLA As String
            VP_NOMBRE_TABLA = PP_CB_COMBO.Name
            If PP_NOMBRE_TABLA = "" Then

                If VP_NOMBRE_TABLA Like "*_LI_*" Then
                    VP_NOMBRE_TABLA = Right(VP_NOMBRE_TABLA, (VP_NOMBRE_TABLA.Length - 6))
                    VP_PARAMETROS = "'" + VP_NOMBRE_TABLA + "', 1" ' Si tiene LI en el nombre el CB se carga Todos -1
                Else
                    VP_NOMBRE_TABLA = Right(VP_NOMBRE_TABLA, (VP_NOMBRE_TABLA.Length - 3))
                    VP_PARAMETROS = "'" + VP_NOMBRE_TABLA + "', 0"
                End If
            Else
                If VP_NOMBRE_TABLA Like "*_LI_*" Then
                    VP_NOMBRE_TABLA = PP_NOMBRE_TABLA
                    VP_PARAMETROS = "'" + VP_NOMBRE_TABLA + "', 1"
                Else
                    VP_NOMBRE_TABLA = PP_NOMBRE_TABLA
                    VP_PARAMETROS = "'" + VP_NOMBRE_TABLA + "', 0"
                End If

            End If
            VP_PARAMETROS = VP_PARAMETROS + "," + PP_L_USAR_ORDEN.ToString()

            Dim VP_tabla As New DataTable
            Dim row As DataRow

            Dim VP_SP As String
            VP_SP = Codigo_SQL.FG_SP_CB_LOAD(PP_L_USAR_ORDEN)

            Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

            PP_CB_COMBO.DropDownStyle = ComboBoxStyle.DropDownList
            PP_CB_COMBO.DisplayMember = "Text"
            PP_CB_COMBO.ValueMember = "Value"
            VP_tabla = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(PP_BD_Index, VP_SP, VP_PARAMETROS)

            For Each row In VP_tabla.Rows
                If Not (row("D_COMBOBOX") Like "<X>*") Then
                    PP_CB_COMBO.Items.Add(New With {.Text = row("D_COMBOBOX"), .Value = row("K_COMBOBOX")})
                End If
            Next
            If PP_CB_COMBO.Items.Count > 0 Then
                PP_CB_COMBO.SelectedIndex = 0
            End If
            PP_CB_COMBO.Font = New Font("Arial", 8, FontStyle.Regular)
            PP_CB_COMBO.Height = 12

            If PP_CB_COMBO.Name Like "*ESTATUS*" Then
                If PP_CB_COMBO.Name Like "*_LI_*" Then
                    PP_CB_COMBO.Enabled = True
                Else
                    PP_CB_COMBO.Enabled = False
                End If

            End If

            If PP_CB_COMBO.Name Like "*_LI_*" And PP_CB_COMBO.Tag <> "NOEVENTO" Then
                PP_CB_COMBO.Tag = PP_FORMA
                AddHandler PP_CB_COMBO.Click, AddressOf PG_CB_LI_COMBO_CLEAR_LIST
            End If

        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CB_LOAD")
        End Try
    End Sub

    Public Shared Sub PG_CB_LOAD_X_ORDEN(ByVal PP_BD_Index As Integer, ByVal PP_FORMA As Object, ByRef PP_CB_COMBO As ComboBox, Optional ByVal PP_NOMBRE_TABLA As String = "")
        PG_CB_LOAD_BASICO(PP_BD_Index, PP_FORMA, PP_CB_COMBO, 1, PP_NOMBRE_TABLA)
    End Sub

    Public Shared Sub PG_CB_LOAD_X_DESCRIPCION(ByVal PP_BD_Index As Integer, ByVal PP_FORMA As Object, ByRef PP_CB_COMBO As ComboBox, Optional ByVal PP_NOMBRE_TABLA As String = "")
        PG_CB_LOAD_BASICO(PP_BD_Index, PP_FORMA, PP_CB_COMBO, 0, PP_NOMBRE_TABLA)
    End Sub

    Private Shared Sub PG_CB_LI_COMBO_CLEAR_LIST(sender As Object, e As EventArgs)
        On Error Resume Next
        Dim VP_COMBOBOX As ComboBox = sender
        If VP_COMBOBOX.Tag <> Nothing Then
            Dim VP_FORMA As Object = VP_COMBOBOX.Tag
            VP_FORMA.PM_LI_INIT()
        End If
        On Error GoTo 0
    End Sub



    Public Shared Sub PG_CB_LOAD_X_ORDEN(ByVal PP_BD_Index As Integer, ByVal PP_FORMA As Object, ByRef PP_CB_COMBO As ComboBox, ByVal PP_SP As String, ByVal PP_PARAMETROS As String, Optional PP_K_USUARIO As Integer = 0)

        PG_CB_INIT(PP_CB_COMBO)

        Dim VP_PARAMETROS As String

        Dim VP_tabla As New DataTable
        Dim row As DataRow
        Try
            Dim VP_SP As String
            VP_SP = PP_SP
            VP_PARAMETROS = PP_PARAMETROS
            Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS, PP_K_USUARIO)

            PP_CB_COMBO.DropDownStyle = ComboBoxStyle.DropDownList
            PP_CB_COMBO.DisplayMember = "Text"
            PP_CB_COMBO.ValueMember = "Value"
            VP_tabla = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(PP_BD_Index, VP_SP, VP_PARAMETROS)

            For Each row In VP_tabla.Rows
                If Not (row("D_COMBOBOX") Like "<X>*") Then
                    PP_CB_COMBO.Items.Add(New With {.Text = row("D_COMBOBOX"), .Value = row("K_COMBOBOX")})
                End If
            Next
            If PP_CB_COMBO.Items.Count > 0 Then
                PP_CB_COMBO.SelectedIndex = 0
            End If
            PP_CB_COMBO.Font = New Font("Arial", 8, FontStyle.Regular)
            PP_CB_COMBO.Height = 12
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CB_LOAD")
        End Try
    End Sub


    Public Shared Sub PG_CB_CLEAR(ByRef PP_COMBO As ComboBox)
        Try
            PP_COMBO.Items.Clear()
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CB_CLEAR")
        End Try

    End Sub

    Public Shared Sub PG_CB_VALUE_LOAD(ByRef PP_COMBO As ComboBox, ByVal PP_VALOR As Integer)
        Try
            Dim VP_D_COMBOBOX As String = ""
            For Each item In PP_COMBO.Items
                If item.Value = PP_VALOR Then
                    VP_D_COMBOBOX = item.Text
                End If
            Next
            Dim VP_ITEM = PP_COMBO.Items
            PP_COMBO.SelectedIndex = FG_CB_ITEM_INDEX(PP_COMBO, VP_D_COMBOBOX)
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CB_VALUE_LOAD")
        End Try
    End Sub

#End Region

#Region "FUNCIONES"

    Public Shared Function FG_CB_ITEM_TEXT(ByRef PP_COMBO As ComboBox) As String
        Dim VP_VALOR As String = ""
        Try
            Dim VP_ITEM = PP_COMBO.SelectedItem
            VP_VALOR = VP_ITEM.Text
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("FG_CB_ITEM_TEXT")
        End Try
        Return VP_VALOR
    End Function

    Public Shared Function FG_CB_ITEM_INDEX(ByRef PP_COMBO As ComboBox, ByRef PP_VALOR As String) As Integer
        Dim VP_INDEX As Integer = 0
        Try
            VP_INDEX = PP_COMBO.FindString(PP_VALOR)
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("FG_CB_ITEM_INDEX")
        End Try
        Return VP_INDEX
    End Function

    Public Shared Function FG_CB_ITEM_VALUE(ByRef PP_COMBO As ComboBox) As String
        Dim VP_VALOR As String = ""
        Try
            If PP_COMBO.SelectedItem Is Nothing Then
                VP_VALOR = -1
            Else
                Dim VP_ITEM = PP_COMBO.SelectedItem
                VP_VALOR = VP_ITEM.Value
            End If
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("FG_CB_ITEM_VALUE")
        End Try
        Return VP_VALOR
    End Function

#End Region

End Class
