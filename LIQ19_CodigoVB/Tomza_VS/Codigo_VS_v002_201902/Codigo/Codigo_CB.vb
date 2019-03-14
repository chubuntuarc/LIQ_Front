Public Class Codigo_CB

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

    Public Shared Sub PG_CB_RAZON_SOCIAL_Load(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_CB_COMBO As ComboBox, ByVal PP_L_CON_TODOS As Integer, ByVal PP_CB_ESTATUS As ComboBox, ByVal PP_CB_TIPO As ComboBox, ByVal PP_K_USUARIO As Integer) ', ByVal PP_CB_REGION As ComboBox)
        Try
            Dim VP_PARAMETROS, VP_ESTATUS_VALUE, VP_TIPO_VALUE, VP_REGION_VALUE As String
            VP_ESTATUS_VALUE = FG_CB_ITEM_VALUE(PP_CB_ESTATUS)
            VP_TIPO_VALUE = FG_CB_ITEM_VALUE(PP_CB_TIPO)
            VP_REGION_VALUE = "-1" ' FG_CB_ITEM_VALUE(PP_CB_REGION)
            VP_PARAMETROS = PP_L_CON_TODOS.ToString + ", " + VP_ESTATUS_VALUE + ", " + VP_TIPO_VALUE + ", " + VP_REGION_VALUE
            PG_CB_LOAD_X_ORDEN(PP_BD_Index, PP_FORMA, PP_CB_COMBO, "[PG_CB_RAZON_SOCIAL_Load]", VP_PARAMETROS, PP_K_USUARIO)
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CB_RAZON_SOCIAL_Load")
        End Try
    End Sub

    Public Shared Sub PG_CB_RAZON_SOCIAL_GASERAS_Load(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_CB_COMBO As ComboBox, ByVal PP_L_CON_TODOS As Integer, ByVal PP_CB_ESTATUS As ComboBox, ByVal PP_K_USUARIO As Integer) ', ByVal PP_CB_REGION As ComboBox)
        Try
            Dim VP_PARAMETROS, VP_ESTATUS_VALUE, VP_TIPO_VALUE, VP_REGION_VALUE As String

            VP_ESTATUS_VALUE = FG_CB_ITEM_VALUE(PP_CB_ESTATUS)
            VP_TIPO_VALUE = "1" ' RAZÓN SOCIAL TIPO 1 = GASERAS
            VP_REGION_VALUE = "-1" 'FG_CB_ITEM_VALUE(PP_CB_REGION)

            VP_PARAMETROS = PP_L_CON_TODOS.ToString + ", " + VP_ESTATUS_VALUE + ", " + VP_TIPO_VALUE + ", " + VP_REGION_VALUE
            PG_CB_LOAD_X_ORDEN(PP_BD_Index, PP_FORMA, PP_CB_COMBO, "[PG_CB_RAZON_SOCIAL_Load]", VP_PARAMETROS, PP_K_USUARIO)
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CB_RAZON_SOCIAL_GASERAS_Load")
        End Try
    End Sub

    Public Shared Sub PG_CB_ZONA_UO_Load(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_CB_COMBO As ComboBox, ByVal PP_K_USUARIO As Integer)
        Try
            Dim VP_PARAMETROS As String
            VP_PARAMETROS = (0).ToString
            PG_CB_LOAD_X_ORDEN(PP_BD_Index, PP_FORMA, PP_CB_COMBO, "[PG_CB_ZONA_UO_Load]", VP_PARAMETROS, PP_K_USUARIO)
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CB_ZONA_UO_Load")
        End Try
    End Sub

    Public Shared Sub PG_CB_ZONA_UO_TODOS_Load(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_CB_COMBO As ComboBox, ByVal PP_K_USUARIO As Integer)
        Try
            Dim VP_PARAMETROS As String
            VP_PARAMETROS = (1).ToString
            PG_CB_LOAD_X_ORDEN(PP_BD_Index, PP_FORMA, PP_CB_COMBO, "[PG_CB_ZONA_UO_Load]", VP_PARAMETROS, PP_K_USUARIO)
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CB_ZONA_UO_Load")
        End Try
    End Sub

    Public Shared Sub PG_CB_UNIDAD_OPERATIVA_Load(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_CB_COMBO As ComboBox, ByVal PP_L_CON_TODOS As Integer, ByVal PP_L_CON_RAZON_SOCIAL As Integer, ByVal PP_CB_ZONA_UO As ComboBox, ByVal PP_CB_RAZON_SOCIAL As ComboBox, ByVal PP_K_USUARIO As Integer)
        Try
            Dim VP_PARAMETROS, VP_ZONA_VALUE, VP_RS_VALUE As String

            VP_ZONA_VALUE = FG_CB_ITEM_VALUE(PP_CB_ZONA_UO)
            VP_RS_VALUE = FG_CB_ITEM_VALUE(PP_CB_RAZON_SOCIAL)

            VP_PARAMETROS = PP_L_CON_TODOS.ToString + ", " + PP_L_CON_RAZON_SOCIAL.ToString + ", " + VP_ZONA_VALUE + ", " + VP_RS_VALUE

            PG_CB_LOAD_X_ORDEN(PP_BD_Index, PP_FORMA, PP_CB_COMBO, "[PG_CB_UNIDAD_OPERATIVA_Load]", VP_PARAMETROS, PP_K_USUARIO)
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CB_UNIDAD_OPERATIVA_Load")
        End Try
    End Sub

    Public Shared Sub PG_CB_CUENTA_BANCO_Load(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_CB_COMBO As ComboBox, ByVal PP_L_CON_TODOS As Integer, ByVal PP_CB_RAZON_SOCIAL As ComboBox, ByVal PP_CB_UNIDAD_OPERATIVA As ComboBox, ByVal PP_CB_BANCO As ComboBox,
                                          ByVal PP_CB_MONEDA As ComboBox, ByVal PP_CB_ESTATUS As ComboBox, ByVal PP_CB_TIPO As ComboBox, ByVal PP_CB_ESTADO As ComboBox, ByVal PP_K_USUARIO As Integer)
        Try
            Dim VP_PARAMETROS, VP_RS_VALUE, VP_UNIDAD_OPERATIVA, VP_BANCO_VALUE, VP_MONEDA_VALUE, VP_ESTATUS_VALUE, VP_TIPO_VALUE, VP_ESTADO_VALUE As String
            VP_RS_VALUE = FG_CB_ITEM_VALUE(PP_CB_RAZON_SOCIAL)
            VP_UNIDAD_OPERATIVA = FG_CB_ITEM_VALUE(PP_CB_UNIDAD_OPERATIVA)
            VP_BANCO_VALUE = FG_CB_ITEM_VALUE(PP_CB_BANCO)
            VP_MONEDA_VALUE = FG_CB_ITEM_VALUE(PP_CB_MONEDA)
            VP_ESTATUS_VALUE = FG_CB_ITEM_VALUE(PP_CB_ESTATUS)
            VP_TIPO_VALUE = FG_CB_ITEM_VALUE(PP_CB_TIPO)
            VP_ESTADO_VALUE = FG_CB_ITEM_VALUE(PP_CB_ESTADO)
            VP_PARAMETROS = PP_L_CON_TODOS.ToString + ", " + VP_RS_VALUE + ", " + VP_UNIDAD_OPERATIVA + ", " + VP_BANCO_VALUE + ", " + VP_MONEDA_VALUE + ", " + VP_ESTATUS_VALUE + ", " + VP_TIPO_VALUE + ", " + VP_ESTADO_VALUE
            PG_CB_LOAD_X_ORDEN(PP_BD_Index, PP_FORMA, PP_CB_COMBO, "[PG_CB_CUENTA_BANCO_Load]", VP_PARAMETROS, PP_K_USUARIO)
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CB_CUENTA_BANCO_Load")
        End Try
    End Sub


    Public Shared Sub PG_CB_CUENTA_BANCO_Load_X_ORGANIZACION(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_CB_COMBO As ComboBox, ByVal PP_L_CON_TODOS As Integer,
                                              ByVal PP_CB_RAZON_SOCIAL As ComboBox, ByVal PP_CB_UNIDAD_OPERATIVA As ComboBox, ByVal PP_K_USUARIO As Integer)
        PG_CB_CUENTA_BANCO_Load(PP_BD_Index, PP_FORMA, PP_CB_COMBO, PP_L_CON_TODOS, PP_CB_RAZON_SOCIAL,
                                PP_CB_UNIDAD_OPERATIVA, New ComboBox, New ComboBox, New ComboBox, New ComboBox, New ComboBox, PP_K_USUARIO)
    End Sub

    Public Shared Sub PG_CB_RUBRO_PRESUPUESTO_Load(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_CB_COMBO As ComboBox, ByVal PP_L_CON_TODOS As Integer, ByVal PP_K_USUARIO As Integer)
        Try
            Dim VP_PARAMETROS As String
            VP_PARAMETROS = PP_L_CON_TODOS.ToString
            PG_CB_LOAD_X_ORDEN(PP_BD_Index, PP_FORMA, PP_CB_COMBO, "[PG_CB_RUBRO_PRESUPUESTO_Load]", VP_PARAMETROS, PP_K_USUARIO)
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CB_RUBRO_PRESUPUESTO_Load")
        End Try
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
