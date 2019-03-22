Imports System.Globalization
Imports System.Threading

Public Class LIQ19_Codigo
    'PROCESO PARA INICIALIZAR COMBOS
    Public Shared Sub PG_CREAR_COMBOS_FILTROS(PP_FORMA As Form, PP_ID_BASE_DE_DATOS As Integer, PP_COMBOS As ArrayList)
        Codigo_FI.PG_FI_CONTROL_DATA_SETUP(PP_ID_BASE_DE_DATOS, PP_FORMA)

        'GROUPBOX DE LOS FILTROS.
        Dim VP_GROUP As GroupBox = New GroupBox
        VP_GROUP.Name = "GB_FILTROS"
        VP_GROUP.Text = "Filtros"
        VP_GROUP.Width = 1880
        VP_GROUP.Height = 80
        VP_GROUP.Location = New Point(10, 58)
        PP_FORMA.Controls.Add(VP_GROUP)

        'INPUT PARA BUSCAR.
        Dim VP_INPUT As TextBox = New TextBox
        VP_INPUT.Name = "TB_LI_BUSCAR"
        VP_INPUT.Width = 190
        VP_INPUT.Location = New Point(10, 32)
        VP_GROUP.Controls.Add(VP_INPUT)

        'ETIQUETA INPUT BUSCAR
        Dim VP_LABEL_BUSCAR As Label = New Label
        VP_LABEL_BUSCAR.Name = "LB_LI_BUSCAR"
        VP_LABEL_BUSCAR.Location = New Point(10, 15)
        VP_LABEL_BUSCAR.Text = "Buscar"
        VP_GROUP.Controls.Add(VP_LABEL_BUSCAR)

        Dim VP_CONTADOR = 210
        For VP_INDICE As Integer = 0 To PP_COMBOS.Count - 1

            Dim VP_NOMBRE_COMBO = PP_COMBOS(VP_INDICE)

            Dim curCulture As CultureInfo = Thread.CurrentThread.CurrentCulture
            Dim tInfo As TextInfo = curCulture.TextInfo()

            Dim VP_CONVERSION_TEXTO = tInfo.ToTitleCase(tInfo.ToLower(VP_NOMBRE_COMBO)).ToString() 'CONVIERTE EL TEXTO
            Dim VP_POSICION As Integer = VP_CONVERSION_TEXTO.IndexOf("_")

            Dim VP_ETIQUETA = ""
            If VP_POSICION > 0 Then
                VP_ETIQUETA = VP_CONVERSION_TEXTO.Substring(0, VP_POSICION)
            Else
                VP_ETIQUETA = VP_CONVERSION_TEXTO
            End If

            'CREAR EL COMBOBOX
            Dim VP_COMBO As ComboBox = New ComboBox
            VP_COMBO.Name = "CB_LI_" + VP_NOMBRE_COMBO
            VP_COMBO.Width = 100
            VP_COMBO.Location = New Point(VP_CONTADOR, 32)
            VP_COMBO.BringToFront()

            Codigo_CB.PG_CB_LOAD_X_ORDEN(PP_ID_BASE_DE_DATOS, PP_FORMA, VP_COMBO, PP_COMBOS(VP_INDICE))

            'CREAR LA ETIQUETA
            Dim VP_LABEL As Label = New Label
            VP_LABEL.Name = "LB_LI_" + VP_ETIQUETA
            VP_LABEL.Location = New Point(VP_CONTADOR, 15)
            VP_LABEL.Text = VP_ETIQUETA
            VP_LABEL.BringToFront()

            'AGREGAR LOS ELEMENTOS AL GROUPBOX DE LA FORMA
            VP_GROUP.Controls.Add(VP_COMBO)
            VP_GROUP.Controls.Add(VP_LABEL)

            VP_CONTADOR += 110
        Next

    End Sub

    Public Shared Sub PG_LI_CLEAR(ByRef PP_LISTADO As DataGridView)
        PP_LISTADO.Rows.Clear()
    End Sub

    Public Shared Sub PG_LI_ROW_ADD(ByRef PP_LISTADO As DataGridView)
        PP_LISTADO.Rows.Add()
    End Sub

    Public Shared Sub PG_BT_BUSCAR_DETALLE(ByVal PP_ID_BASE_DE_DATOS As Integer, ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView, Optional ByVal PP_SP As String = "", Optional ByVal PP_PARAMETROS As String = "")
        PP_FORMA.Cursor = Cursors.WaitCursor
        Try

            Dim VP_PARAMETROS As String
            If PP_PARAMETROS IsNot "" Then
                VP_PARAMETROS = PP_PARAMETROS
            Else
                VP_PARAMETROS = PP_FORMA.FM_SQL_LISTADO()
            End If


            Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
            Dim VP_STORED_PROCEDURE As String

            If PP_SP = "" Then
                VP_STORED_PROCEDURE = FG_SQL_LIST(PP_FORMA)
            Else
                VP_STORED_PROCEDURE = PP_SP
            End If

            Dim VP_TABLA As Data.DataTable
            VP_TABLA = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(PP_ID_BASE_DE_DATOS, VP_STORED_PROCEDURE, VP_PARAMETROS)
            If VP_TABLA.Rows.Count > 500 Then
                If Codigo_Mensaje.FG_MENSAJE_CONFIRMACION("La busqueda arrojó mas de 500 registros." + vbCrLf + "¿Desea mostrarlos?") Then
                    PG_LI_LOAD_DETALLE(PP_FORMA, PP_LISTADO, VP_TABLA)
                End If
            Else
                PG_LI_LOAD_DETALLE(PP_FORMA, PP_LISTADO, VP_TABLA)
            End If
            Dim VP_REGISTROS As String
            VP_REGISTROS = VP_TABLA.Rows.Count().ToString()
            PP_FORMA.LB_RESULTADO.Text = "Resultado de la operación: " + VP_REGISTROS + " registros." + Environment.NewLine + PP_FORMA.LB_RESULTADO.Text
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_BUSCAR_CLICK")
        End Try
        PP_FORMA.Cursor = Cursors.Default
    End Sub

    Public Shared Sub PG_LI_LOAD_DETALLE(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView, ByVal PP_DATATABLE As DataTable)
        Try
            PG_LI_CLEAR(PP_LISTADO)
            Dim PP_PB_PROGRESSBAR As BARRA_DE_PROGRESO_PANEL
            PP_PB_PROGRESSBAR = ProgressBarPanel.FG_PROGRESSBAR_INIT(PP_FORMA, 0, PP_DATATABLE.Rows.Count, "Carga de Registros", Color.DarkOrange)
            Dim PP_COUNT As Integer = 0
            Dim VP_LISTADO_NOMBRE = PP_LISTADO.Name
            PP_LISTADO.Visible = False
            For Each VP_ROW_DATA As DataRow In PP_DATATABLE.Rows
                PG_LI_ROW_ADD(PP_LISTADO)
                PP_FORMA.PM_LI_ROW_WRITE_DETALLE(PP_LISTADO, VP_ROW_DATA)
                PP_COUNT += 1
                ProgressBarPanel.PG_PROGRESSBAR_INCREMENT(PP_PB_PROGRESSBAR, PP_COUNT)
            Next
            PP_LISTADO.Visible = True
            ProgressBarPanel.PG_PROGRESSBAR_END(PP_PB_PROGRESSBAR)
            PP_LISTADO.CurrentCell = Nothing
            'PP_LISTADO.CurrentCell.Selected = False
            ' PP_LISTADO.ClearSelection()
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_LI_LOAD")

        End Try

    End Sub

    Public Shared Function FG_SQL_LIST(ByRef PP_FORMA As Object)
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = FG_SQL_BASICO(Codigo_SQL.CG_SQL_SP_LIST, PP_FORMA.VM_NOMBRE_TABLA)
        Return VP_STORED_PROCEDURE
    End Function

    Private Shared Function FG_SQL_BASICO(ByVal PP_TIPO As String, ByVal PP_NOMBRE_TABLA As String)
        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = "[dbo].[" + Codigo_SQL.CG_SQL_PG_PREFIJO + "_" + PP_TIPO + "_" + PP_NOMBRE_TABLA + "]"
        Return VP_STORED_PROCEDURE
    End Function


    'AX  //   CODIGO PARA VERIFICAR FECHA CON UN RANGO MAYOR A 50 AÑOS 20190312
    Public Shared Sub PG_TB_DATE_VALIDATE_80_YYYY(ByRef PP_MENSAJE_VALIDACION As String, ByRef PP_CONTROL As MaskedTextBox)
        PP_CONTROL.BackColor = Color.White
        If PP_MENSAJE_VALIDACION = "" And PP_CONTROL.Text <> "  /  /" Then
            Dim VL_ES_FECHA As Boolean = False
            Dim VL_FECHA As String() = PP_CONTROL.Text.Split("/")

            Try
                Dim VP_FECHA As Date = New Date(VL_FECHA(2), VL_FECHA(1), VL_FECHA(0))
                If IsDate(VP_FECHA) Then
                    If VP_FECHA < (Now.AddYears(-80)) Then
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

    'AX  //   CODIGO PARA VERIFICAR EL PARAMETRO CON UN RANGO MAYOR A 50 AÑOS 20190312
    Public Shared Sub PG_CO_PARAMETRO_80_YYYY(ByRef PP_PARAMETROS As String, ByVal PP_CONTROL As Object, ByVal PP_DELIMITADOR As Boolean)
        Dim VP_VALOR As String = ""

        If PP_CONTROL.GetType() = GetType(MaskedTextBox) Then
            Dim VP_STRING_VALIDACION As String = ""
            PG_TB_DATE_VALIDATE_80_YYYY(VP_STRING_VALIDACION, PP_CONTROL)

            If VP_STRING_VALIDACION = "" And PP_CONTROL.Text <> "  /  /" Then
                Dim VL_FECHA As String() = PP_CONTROL.Text.Split("/")
                Dim VL_DIA As String = VL_FECHA(0) : Dim VL_MES As String = VL_FECHA(1) : Dim VL_AÑO As String = VL_FECHA(2)
                Dim VL_FECHA_SQL As String = VL_AÑO + "-" + VL_MES + "-" + VL_DIA
                VP_VALOR = VL_FECHA_SQL
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

    'AX  //   CODIGO PARA FORMATEAR LOS TEXTBOX DE LA FICHA  20190222
    ''' <summary>
    ''' Inicializa un objeto en la Ficha aplicando un Formato previamente definido.
    ''' <para> PP_CONTROL; Nombre del TextBox al que se le aplicará el formato.</para>
    ''' PP_FORMATO:
    ''' <para>1. Sólo permite el ingreso de números Enteros | 2. Sólo permite el ingreso de números con punto Decimal</para>
    ''' 3. Alinear el texto a la izquierda | 4. Alinear el texto al centro | 5. Alinear el texto ala derecha.
    ''' <para>PP_PRECARGADO; Sólo aplica para el PP_FORMATO 1 y 2</para>
    ''' 1=  Precarga el TextBox con [0] ó [0.00] por default. Según sea el caso
    ''' </summary>
    Public Shared Sub PG_TB_INIT(ByRef PP_CONTROL As TextBox, ByVal PP_FORMATO As Integer, Optional ByVal PP_PRECARGADO As Integer = 0)
        Select Case PP_FORMATO
            Case 1 'ENTERO
                PP_CONTROL.TextAlign = HorizontalAlignment.Right
                If PP_PRECARGADO = 1 Then
                    PP_CONTROL.Text = Format(PP_CONTROL.Text, "0")
                End If
                AddHandler PP_CONTROL.KeyPress, AddressOf PP_CONTROL_KEYPRESS_ENTEROS
            Case 2 'DECIMAL
                PP_CONTROL.TextAlign = HorizontalAlignment.Right
                If PP_PRECARGADO = 1 Then
                    PP_CONTROL.Text = Format(PP_CONTROL.Text, "0.00")
                End If
                AddHandler PP_CONTROL.KeyPress, AddressOf PP_CONTROL_KEYPRESS_DECIMALES
            Case 3 ' Alinear texto a la izquierda
                PP_CONTROL.TextAlign = HorizontalAlignment.Left
            Case 4 ' Alinear texto al centro
                PP_CONTROL.TextAlign = HorizontalAlignment.Center
            Case 5 ' Alinear texto a la derecha
                PP_CONTROL.TextAlign = HorizontalAlignment.Right
        End Select
    End Sub

    Private Shared Sub PP_CONTROL_KEYPRESS_DECIMALES(sender As Object, e As KeyPressEventArgs)
        Dim PP_CONTROL As TextBox = sender
        PP_CONTROL.PG_TB_SOLO_DECIMALES(e)
    End Sub

    Private Shared Sub PP_CONTROL_KEYPRESS_ENTEROS(sender As Object, e As KeyPressEventArgs)
        Dim PP_CONTROL As TextBox = sender
        PP_CONTROL.PG_TB_SOLO_ENTEROS(e)
    End Sub

    'JAR // GENERAR UN LISTADO SENCILLO  EN BASE A UN DATATABLE
    Public Shared Sub NUEVO_LISTADO(PP_DATOS As DataTable, PP_LISTADO As DataGridView, PP_CAMPOS As ArrayList, PP_TITULOS As ArrayList, PP_TIPOS As ArrayList)
        Codigo_LI.PG_LI_CLEAR(PP_LISTADO)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LISTADO, 8, 17)

        'GENERAR TITULOS
        For VP_INDICE As Integer = 1 To PP_TITULOS.Count

            Dim VP_CAMPO = PP_CAMPOS(VP_INDICE - 1)
            Dim VP_TITULO = PP_TITULOS(VP_INDICE - 1)
            Dim VP_TIPO = PP_TIPOS(VP_INDICE - 1)

            Select Case VP_TIPO
                Case 1
                    Codigo_LI.PG_LI_COLUMN_ADD(PP_LISTADO, VP_CAMPO, VP_TITULO, GetType(Integer), 50, 2, 0, 1, 1, 0, Color.White, Color.Black, 1)
                Case 2
                    Codigo_LI.PG_LI_COLUMN_ADD(PP_LISTADO, VP_CAMPO, VP_TITULO, GetType(String), 150, 1, 0, 1, 1, 0, Nothing, Color.LightYellow, 1)
                Case 3
                    Codigo_LI.PG_LI_COLUMN_ADD(PP_LISTADO, VP_CAMPO, VP_TITULO, GetType(String), 60, 2, 0, 1, 0, 0, Color.DarkSlateGray, Color.Gainsboro, 1)
                Case 4
                    Codigo_LI.PG_LI_COLUMN_ADD(PP_LISTADO, VP_CAMPO, VP_TITULO, GetType(String), 150, 1, 0, 1, 0, 0, Nothing, Nothing, 1)
                Case 5
                    Codigo_LI.PG_LI_COLUMN_ADD(PP_LISTADO, VP_CAMPO, VP_TITULO, GetType(String), 60, 2, 0, 1, 0, 0, Color.Orange, Nothing, 1)
            End Select

        Next

        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LISTADO, 100, 2, 0, 0, 0, 0)

        'GENERAR COLUMNAS
        For VP_INDICE As Integer = 0 To PP_DATOS.Rows.Count - 1

            Dim VP_ROW_DATA As DataRow = PP_DATOS.Rows(VP_INDICE)

            PP_LISTADO.Rows.Insert(VP_INDICE, VP_ROW_DATA(PP_CAMPOS(0)))

            For index As Integer = 1 To PP_CAMPOS.Count - 1
                PP_LISTADO.Rows(VP_INDICE).Cells(index).Value = VP_ROW_DATA(PP_CAMPOS(index))
            Next

            Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_INDICE, PP_CAMPOS.Count, VP_ROW_DATA)

        Next

    End Sub
End Class
