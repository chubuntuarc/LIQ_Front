
Imports System.Globalization

Public Class Codigo_LI

#Region "SUBS_LI"
    Public Shared Sub PG_LI_CLEAR(ByRef PP_LISTADO As DataGridView)
        PP_LISTADO.Rows.Clear()
    End Sub

    Public Shared Sub PG_LI_FORMAT_SETUP(ByRef PP_LISTADO As DataGridView, ByVal PP_LI_FONT_SIZE As Integer, ByVal PP_LI_ROW_SIZE As Integer)
        PP_LISTADO.DoubleBuffered_g(True)
        PG_LI_CLEAR(PP_LISTADO)
        PP_LISTADO.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        PP_LISTADO.RowHeadersVisible = False
        PP_LISTADO.Columns.Clear()
        PP_LISTADO.DefaultCellStyle.Font = New Font("Leelawadee UI", PP_LI_FONT_SIZE, FontStyle.Regular)
        PP_LISTADO.RowTemplate.Height = PP_LI_ROW_SIZE
        PP_LISTADO.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        PP_LISTADO.AllowUserToResizeRows = False
        ' AddHandler PP_LISTADO.RowPostPaint, AddressOf PG_LI_ROW_POST_PAINT
        AddHandler PP_LISTADO.KeyDown, AddressOf PG_LI_KEY_DOWN

    End Sub

    Public Shared Sub PG_LI_KEY_DOWN(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim LI_LISTADO As DataGridView = sender
        If e.Control AndAlso e.KeyCode = Keys.V Then
            Try
                Dim VP_ROWINDEX As Integer
                VP_ROWINDEX = LI_LISTADO.CurrentRow.Index
                Dim VP_CELLINIT As Integer
                VP_CELLINIT = LI_LISTADO.CurrentCell.ColumnIndex

                For Each VP_LINE As String In Clipboard.GetText.Split(vbNewLine)
                    If VP_LINE <> Chr(10) Then
                        Dim AP_ITEM() As String = VP_LINE.Trim.Split(vbTab)
                        Dim VP_CELLINDEX As Integer = VP_CELLINIT
                        For Each VP_VALOR As String In AP_ITEM
                            LI_LISTADO.Rows(VP_ROWINDEX).Cells(VP_CELLINDEX).Value = VP_VALOR
                            VP_CELLINDEX = VP_CELLINDEX + 1
                        Next
                        VP_ROWINDEX = VP_ROWINDEX + 1
                    End If
                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="VP_CELL">Represena la celda del grid a evaluar del grid</param>
    Public Shared Function PG_LI_CELL_VALIDATE(VP_CELL As DataGridViewCell)
        If VP_CELL.GetType Is GetType(String) Then
            'Si la celda es del tipo string 
            If VP_CELL.Value.ToString.Length > 0 Then 'validacion de vacio Default como ejemplo
                'Validacion de strings
                Return True
            End If
        End If
        Return False
    End Function

    Public Shared Sub PG_LI_LOAD(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView, ByVal PP_DATATABLE As DataTable)
        Try
            PG_LI_CLEAR(PP_LISTADO)
            Dim PP_PB_PROGRESSBAR As BARRA_DE_PROGRESO_PANEL
            PP_PB_PROGRESSBAR = ProgressBarPanel.FG_PROGRESSBAR_INIT(PP_FORMA, 0, PP_DATATABLE.Rows.Count, "Carga de Registros", Color.DarkOrange)
            Dim PP_COUNT As Integer = 0
            Dim VP_LISTADO_NOMBRE = PP_LISTADO.Name
            PP_LISTADO.Visible = False
            For Each VP_ROW_DATA As DataRow In PP_DATATABLE.Rows
                PG_LI_ROW_ADD(PP_LISTADO)
                PP_FORMA.PM_LI_ROW_WRITE(PP_LISTADO, VP_ROW_DATA)
                PP_COUNT += 1
                ProgressBarPanel.PG_PROGRESSBAR_INCREMENT(PP_PB_PROGRESSBAR, PP_COUNT)
            Next
            PP_LISTADO.Visible = True
            ProgressBarPanel.PG_PROGRESSBAR_END(PP_PB_PROGRESSBAR)
            PP_LISTADO.CurrentCell = Nothing
            'PP_LISTADO.CurrentCell.Selected = False
            ' PP_LISTADO.ClearSelection()
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PG_LI_LOAD")

        End Try

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
            Codigo_Message.PG_MENSAJE_ERROR_VS("PG_LI_LOAD")

        End Try

    End Sub

    Public Shared Sub PG_LI_RESET(ByVal PP_ID_BASE_DE_DATOS As Integer, ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView, ByVal PP_EXITO As Boolean)
        If PP_EXITO Then
            PP_FORMA.VM_IN_MODO_OPERACION = Modo_Operacion.Listado
            Codigo_FRM.PG_FRM_CONFIG(PP_FORMA)

            PP_FORMA.PM_BT_BUSCAR_CLICK(PP_FORMA, PP_LISTADO)

            On Error Resume Next
            Codigo_FI.PG_FI_CONTROL_CLEAR(PP_FORMA.GB_FICHA)
            On Error GoTo 0
        End If
    End Sub

    Public Shared Sub PG_LI_DOUBLE_CLICK(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Dim VP_ID As String

        Try
            If PP_LISTADO.Rows.Count > 0 Then
                Dim VP_ROW As Integer = FG_LI_ROW_CURRENT(PP_LISTADO)
                VP_ID = PP_FORMA.FM_ID_SELECCIONADO(PP_LISTADO, VP_ROW)

                PP_FORMA.PM_FI_LOAD(VP_ID)

                PP_FORMA.VM_IN_MODO_OPERACION = Modo_Operacion.Ver_Ficha
                Codigo_FRM.PG_FRM_CONFIG(PP_FORMA)
            End If

        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PG_LI_DOUBLE_CLICK")
        End Try
    End Sub


#End Region

#Region "SUB_ROWS"

    ''' <summary>
    ''' PROCEDIMIENTO PARA PONERLE EL INDICE AL ROW
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Shared Sub PG_LI_ROW_POST_PAINT(sender As Object, e As DataGridViewRowPostPaintEventArgs)

        Dim LI_LISTADO As DataGridView = sender
        Dim VP_ROW_INDEX = (e.RowIndex + 1).ToString()

        Dim VP_CENTER As New StringFormat With {
        .Alignment = StringAlignment.Center,
        .LineAlignment = StringAlignment.Center
        }

        Dim VP_HEADER_BOUNDS As New Rectangle(e.RowBounds.Left, e.RowBounds.Top, LI_LISTADO.RowHeadersWidth, e.RowBounds.Height)
        e.Graphics.DrawString(VP_ROW_INDEX, New Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, VP_HEADER_BOUNDS, VP_CENTER)

    End Sub

    Public Shared Sub PG_LI_ROW_ADD(ByRef PP_LISTADO As DataGridView)
        PP_LISTADO.Rows.Add()
    End Sub

    ''' <summary>
    ''' cambia el color de fondo del row
    ''' </summary>
    Public Shared Sub PG_LI_ROW_COLOR_CHANGE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer, ByVal PP_COLOR As Color)
        Try
            PP_LISTADO.Rows(PP_ROW).DefaultCellStyle.BackColor = PP_COLOR
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PG_LI_COLOR_CHANGE")
        End Try

    End Sub

    ''' <summary>
    ''' recibe un data grid mas el indice de row y columna 
    ''' el indice de row para saber que row se pondra como visible 
    ''' el indice de columna es para verificar su valor, si es 1, el row sera visible
    ''' si es 0, el row será invisible 
    ''' </summary>
    Public Shared Sub PG_LI_ROW_VISIBLE(ByRef PP_LISTADO As DataGridView, ByVal VP_COL As String, ByRef PP_ROW As Integer)
        Try
            If PP_LISTADO.Rows(PP_ROW).Cells(VP_COL).Value = 1 Then
                PP_LISTADO.Rows(PP_ROW).Visible = True
            Else
                PP_LISTADO.Rows(PP_ROW).Visible = False
            End If
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PG_LI_ROW_VISIBLE")
        End Try

    End Sub

    ''' <summary>
    ''' verifica si el row en la columna especificada tiene un 1. si es asi, la el row será editable
    ''' si tiene un 0, el row sera readonly
    ''' </summary>
    Public Shared Sub PG_LI_ROW_EDIT(ByRef PP_LISTADO As DataGridView, ByVal VP_COL As String, ByRef PP_ROW As Integer)
        Try
            If PP_LISTADO.Rows(PP_ROW).Cells(VP_COL).Value = 1 Then
                PP_LISTADO.Rows(PP_ROW).ReadOnly = False
            Else
                PP_LISTADO.Rows(PP_ROW).ReadOnly = True
            End If
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PG_LI_ROW_EDIT")
        End Try

    End Sub
    ''' <summary>
    ''' permite o evita la edicion de un row en la grilla
    ''' </summary>
    ''' <param name="PP_LISTADO"></param>
    Public Shared Sub PG_LI_ROW_EDIT(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer, ByVal VP_READ_ONLY As Boolean)
        Try
            PP_LISTADO.Rows(PP_ROW).ReadOnly = VP_READ_ONLY

        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PG_LI_ROW_EDIT")
        End Try

    End Sub

    Public Shared Sub PG_LI_ROW_PAINT(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer, ByVal PP_COLOR As Color)
        Try
            PP_LISTADO.Rows(PP_ROW).DefaultCellStyle.BackColor = PP_COLOR
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PG_LI_ROW_PAINT")
        End Try


    End Sub


#End Region

#Region "SUB_CELLS"
    ''' <summary>
    ''' 'coloca un 1 a la ultima columna para indicar que ese row se modifico
    ''' </summary>
    Public Shared Sub PG_LI_CELL_MOD_WRITE(ByRef PP_LISTADO As DataGridView, ByVal VP_ROW As Integer, ByVal VP_COL As Integer)
        Try
            PP_LISTADO.Rows(VP_ROW).Cells("Modificado").Value = 1
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PG_LI_CELL_MOD_WRITE")
        End Try

    End Sub

    Public Shared Function FG_LI_CELL_GET_COLUMN_NAME(ByRef PP_LISTADO As DataGridView) As String
        Dim COL_NAME As String = ""
        Try
            COL_NAME = PP_LISTADO.CurrentCell.OwningColumn.Name
        Catch ex As ArgumentException
            Codigo_Message.PG_MENSAJE_ERROR_VS("FG_LI_CELL_GET_COLUMN")
        End Try
        Return COL_NAME
    End Function

    Public Shared Function FG_LI_CELL_GET_COLUMN_TYPE(ByRef PP_LISTADO As DataGridView) As Type
        Dim COL_NAME As Type = Nothing
        Try
            COL_NAME = PP_LISTADO.CurrentCell.OwningColumn.ValueType
        Catch ex As ArgumentException
            Codigo_Message.PG_MENSAJE_ERROR_VS("FG_LI_CELL_GET_COLUMN")
        End Try
        Return COL_NAME
    End Function

    Public Shared Sub PG_LI_CELL_FONT_PROPERTIES(ByRef PP_ROW As DataGridViewRow, ByVal PP_COLUMNA As String)
        Dim VP_BOLD As Integer = PP_ROW.Cells("L_BOLD").Value
        Dim VP_ITALICA As Integer = PP_ROW.Cells("L_ITALICA").Value
        Dim VP_INDENTAR As Integer = PP_ROW.Cells("N_INDENTAR").Value
        Dim VP_ALIGN As Integer = PP_ROW.Cells("K_ALIGN").Value
        Dim VP_FONTSTYLEBOLD As Font = New Font("Arial", 8, FontStyle.Bold)
        Dim VP_FONTSTYLEITALICA As Font = New Font("Arial", 8, FontStyle.Italic)
        Dim VP_PADDING As Padding = New Padding(5, 0, 0, 0)
        Dim VP_LEFT As New DataGridViewContentAlignment
        Dim VP_CENTER As New DataGridViewContentAlignment
        Dim VP_RIGHT As New DataGridViewContentAlignment

        VP_LEFT = DataGridViewContentAlignment.MiddleLeft
        VP_CENTER = DataGridViewContentAlignment.MiddleCenter
        VP_RIGHT = DataGridViewContentAlignment.MiddleRight
        Try

            If VP_BOLD = 1 Then
                PP_ROW.Cells(PP_COLUMNA).Style.Font = VP_FONTSTYLEBOLD
            End If
            If VP_ITALICA = 1 Then
                PP_ROW.Cells(PP_COLUMNA).Style.Font = VP_FONTSTYLEITALICA
            End If
            If VP_INDENTAR = 1 Then
                PP_ROW.Cells(PP_COLUMNA).Style.Padding = VP_PADDING
            End If
            Select Case VP_ALIGN
                Case 1
                    PP_ROW.Cells(PP_COLUMNA).Style.Alignment = VP_LEFT
                Case 2
                    PP_ROW.Cells(PP_COLUMNA).Style.Alignment = VP_CENTER
                Case 3
                    PP_ROW.Cells(PP_COLUMNA).Style.Alignment = VP_RIGHT
            End Select
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PG_LI_CELL_FONT_PROPERTIES")
        End Try
    End Sub

    Public Shared Sub PG_LI_CELL_FONT_PROPERTIES_RUNTIME(ByRef PP_ROW As DataGridViewRow, ByVal PP_COLUMNA As String, ByVal PP_NIVEL As Integer, ByVal PP_TIPO_FORMATO As String) ' PP_TIPO_FORMATO [1:PRESUPUESTO(PPO) / 2=PÓLIZA FLUJO DIARIO(PFD)]
        Dim VP_BOLD As Integer = 0 : Dim VP_ITALICA As Integer = 0 : Dim VP_INDENTAR As Integer = 0 : Dim VP_ALIGN As Integer = 0

        If PP_TIPO_FORMATO = "PPO" Then ' FORMATO PARA PRESUPUESTO Y PLAN DE GASTO
            Select Case PP_NIVEL
                Case 0 ' Nivel 0
                    VP_BOLD = 1 : VP_ITALICA = 0 : VP_INDENTAR = 0 : VP_ALIGN = 1 ' ETIQUETAS // LETRAS BLANCAS, FONDO ANARANJADO
                Case 1 ' Nivel 1
                    VP_BOLD = 1 : VP_ITALICA = 0 : VP_INDENTAR = 1 : VP_ALIGN = 3 ' GRAN TOTAL // LETRAS BLANCAS, NEGRITAS, FONDO NEGRO
                Case 2 ' Nivel 2
                    VP_BOLD = 1 : VP_ITALICA = 0 : VP_INDENTAR = 0 : VP_ALIGN = 3 ' TOTAL SECCIÓN // NEGRITAS, FONDO GRIS
                Case 3 ' Nivel 3
                    VP_BOLD = 0 : VP_ITALICA = 0 : VP_INDENTAR = 0 : VP_ALIGN = 0 ' NO SE USA //
                Case 4 ' Nivel 4
                    VP_BOLD = 1 : VP_ITALICA = 0 : VP_INDENTAR = 0 : VP_ALIGN = 2 ' TÍTULOS SUBSECCIONES // CENTRADO, NEGRITAS, FONDO AMARILLO
                Case 5 ' Nivel 5
                    VP_BOLD = 0 : VP_ITALICA = 1 : VP_INDENTAR = 0 : VP_ALIGN = 1 ' NODOS DE TRABAJO (LOS QUE TIENEN LOS DINEROS) // ITÁLICA
            End Select
        ElseIf PP_TIPO_FORMATO = "PFD" Then ' FORMATO PARA FLUJO DIARIO
            Select Case PP_NIVEL
                Case 0 ' Nivel 0
                    VP_BOLD = 1 : VP_ITALICA = 0 : VP_INDENTAR = 0 : VP_ALIGN = 1 ' ETIQUETAS // LETRAS BLANCAS, FONDO ANARANJADO
                Case 1 ' Nivel 1
                    VP_BOLD = 1 : VP_ITALICA = 1 : VP_INDENTAR = 0 : VP_ALIGN = 2 ' INGRESOS // ITÁLICA, CENTRADO
                Case 2 ' Nivel 2
                    VP_BOLD = 1 : VP_ITALICA = 1 : VP_INDENTAR = 0 : VP_ALIGN = 2 ' EGRESOS // ITÁLICA, CENTRADO
                Case 3 ' Nivel 3
                    VP_BOLD = 1 : VP_ITALICA = 0 : VP_INDENTAR = 0 : VP_ALIGN = 3 ' SUBTOTAL // NEGRITAS, LETRAS NEGRAS, FONDO GRIS
                Case 4 ' Nivel 4
                    VP_BOLD = 1 : VP_ITALICA = 0 : VP_INDENTAR = 1 : VP_ALIGN = 3 ' SALDO FINAL // LETRAS BLANCAS, FONDO NEGRO
                    'Case 5
                    '    VP_BOLD = 0 : VP_ITALICA = 1 : VP_INDENTAR = 0 : VP_ALIGN = 1
            End Select
        End If

        Dim VP_FONTSTYLEBOLD As Font = New Font("Arial", 8, FontStyle.Bold)
        Dim VP_FONTSTYLEITALICA As Font = New Font("Arial", 8, FontStyle.Italic)
        Dim VP_PADDING As Padding = New Padding(5 + (VP_INDENTAR * 5), 0, 0, 0)
        Dim VP_LEFT As New DataGridViewContentAlignment
        Dim VP_CENTER As New DataGridViewContentAlignment
        Dim VP_RIGHT As New DataGridViewContentAlignment

        VP_LEFT = DataGridViewContentAlignment.MiddleLeft
        VP_CENTER = DataGridViewContentAlignment.MiddleCenter
        VP_RIGHT = DataGridViewContentAlignment.MiddleRight
        Try
            If VP_BOLD = 1 Then
                PP_ROW.Cells(PP_COLUMNA).Style.Font = VP_FONTSTYLEBOLD
            End If
            If VP_ITALICA = 1 Then
                PP_ROW.Cells(PP_COLUMNA).Style.Font = VP_FONTSTYLEITALICA
            End If
            If VP_INDENTAR > 0 Then
                PP_ROW.Cells(PP_COLUMNA).Style.Padding = VP_PADDING
            End If
            Select Case VP_ALIGN
                Case 1
                    PP_ROW.Cells(PP_COLUMNA).Style.Alignment = VP_LEFT
                Case 2
                    PP_ROW.Cells(PP_COLUMNA).Style.Alignment = VP_CENTER
                Case 3
                    PP_ROW.Cells(PP_COLUMNA).Style.Alignment = VP_RIGHT
            End Select
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PG_LI_CELL_FONT_PROPERTIES_RUNTIME")
        End Try
    End Sub

    Public Shared Sub PG_LI_CELL_LOAD(ByRef PP_ROW As DataGridViewRow, ByVal PP_COLUMN As Integer, ByVal PP_VALOR As Object)
        Try
            PP_ROW.Cells(PP_COLUMN).Value = PP_VALOR
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub PG_LI_CELL_WRITE(ByRef PP_LISTADO As DataGridView, ByVal PP_ROW As Integer, ByVal PP_COLUMN As Integer, ByVal PP_ROW_DATA As DataRow, ByVal PP_NOMBRE_DATO As String, Optional PP_DEFAULT As String = "")
        Dim VP_VALOR_DECIMAL As Decimal = 0
        Dim VP_VALOR_ENTERO As Integer = 0
        Dim VP_CELDA As DataGridViewCell

        If IsDBNull(PP_ROW_DATA(PP_NOMBRE_DATO)) Then
            VP_CELDA = PP_LISTADO.Rows(PP_ROW).Cells(PP_COLUMN)
            If VP_CELDA.ValueType Is GetType(Decimal) Then
                PP_LISTADO.Rows(PP_ROW).Cells(PP_COLUMN).Value = VP_VALOR_DECIMAL
            ElseIf VP_CELDA.ValueType Is GetType(Integer) Then
                PP_LISTADO.Rows(PP_ROW).Cells(PP_COLUMN).Value = VP_VALOR_ENTERO
            Else
                PP_LISTADO.Rows(PP_ROW).Cells(PP_COLUMN).Value = PP_DEFAULT
            End If
        Else
            PP_LISTADO.Rows(PP_ROW).Cells(PP_COLUMN).Value = PP_ROW_DATA(PP_NOMBRE_DATO)
        End If
    End Sub


    Public Shared Sub PG_LI_CELL_WRITE(ByRef PP_LISTADO As DataGridView, ByVal PP_ROW As Integer, ByVal PP_COLUMN As Integer, ByVal PP_VALOR As String)
        Try
            PP_LISTADO.Rows(PP_ROW).Cells(PP_COLUMN).Value = PP_VALOR
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub PG_LI_CELL_WRITE_PORCENTAJE(ByRef PP_LISTADO As DataGridView, ByVal PP_ROW As Integer, ByVal PP_COLUMN As Integer, ByVal PP_ROW_DATA As DataRow, ByVal PP_NOMBRE_DATO As String, Optional PP_DEFAULT As String = "")
        Try
            If IsDBNull(PP_ROW_DATA(PP_NOMBRE_DATO)) Then
                PP_LISTADO.Rows(PP_ROW).Cells(PP_COLUMN).Value = PP_DEFAULT
            Else
                PP_LISTADO.Rows(PP_ROW).Cells(PP_COLUMN).Value = PP_ROW_DATA(PP_NOMBRE_DATO) ' / 100
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub PG_LI_CELL_WRITE_FECHA(ByRef PP_LISTADO As DataGridView, ByVal PP_ROW As Integer, ByVal PP_COLUMN As Integer, ByVal PP_ROW_DATA As DataRow, ByVal PP_NOMBRE_DATO As String)
        Try
            If Not IsDBNull(PP_ROW_DATA(PP_NOMBRE_DATO)) Then
                Dim VP_DATE As Date = PP_ROW_DATA(PP_NOMBRE_DATO)
                PP_LISTADO.Rows(PP_ROW).Cells(PP_COLUMN).Value = VP_DATE.ToString("dd-MM-yyyy")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub PG_LI_CELL_WRITE_CHECK(ByRef PP_LISTADO As DataGridView, ByVal PP_ROW As Integer, ByVal PP_COLUMN As Integer)
        Try
            Dim CH As DataGridViewCheckBoxCell = PP_LISTADO.Rows(PP_ROW).Cells(PP_COLUMN)
            CH.Value = False
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub PG_LI_CELL_WRITE_CHECK(ByRef PP_LISTADO As DataGridView, ByVal PP_ROW As Integer, ByVal PP_COLUMN As Integer, ByVal PP_ROW_DATA As DataRow, ByVal PP_NOMBRE_DATO As String, Optional PP_DEFAULT As String = "")
        Try
            Dim CH As DataGridViewCheckBoxCell = PP_LISTADO.Rows(PP_ROW).Cells(PP_COLUMN)
            If Not IsDBNull(PP_ROW_DATA(PP_NOMBRE_DATO)) Then
                Dim VP_VALOR As Integer = Convert.ToInt32(PP_ROW_DATA(PP_NOMBRE_DATO))
                CH.Value = VP_VALOR
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub PG_LI_CELL_WRITE_CERO_VACIO(ByRef PP_LISTADO As DataGridView, ByVal PP_ROW As Integer, ByVal PP_COLUMN As Integer, ByVal PP_ROW_DATA As DataRow, ByVal PP_NOMBRE_DATO As String, Optional PP_DEFAULT As String = "")
        Try
            If PP_ROW_DATA(PP_NOMBRE_DATO) = "0" Then
                PP_LISTADO.Rows(PP_ROW).Cells(PP_COLUMN).Value = PP_DEFAULT
            Else
                PP_LISTADO.Rows(PP_ROW).Cells(PP_COLUMN).Value = PP_ROW_DATA(PP_NOMBRE_DATO)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub PG_LI_CELL_WRITE_SECUENCIAL(ByRef PP_LISTADO As DataGridView, ByVal PP_ROW As Integer, ByRef PP_COLUMN As Integer, ByVal PP_ROW_DATA As DataRow, ByVal PP_NOMBRE_DATO As String, Optional PP_DEFAULT As String = "")
        PG_LI_CELL_WRITE(PP_LISTADO, PP_ROW, PP_COLUMN, PP_ROW_DATA, PP_NOMBRE_DATO, PP_DEFAULT)
        PP_COLUMN = PP_COLUMN + 1
    End Sub

    Public Shared Sub PG_LI_CELL_WRITE_SECUENCIAL_VALOR(ByRef PP_LISTADO As DataGridView, ByVal PP_ROW As Integer, ByRef PP_COLUMN As Integer, ByVal PP_VALOR As String)
        PG_LI_CELL_WRITE(PP_LISTADO, PP_ROW, PP_COLUMN, PP_VALOR)
        PP_COLUMN = PP_COLUMN + 1
    End Sub

    Public Shared Sub PG_LI_CELL_WRITE_SECUENCIAL_PORCENTAJE(ByRef PP_LISTADO As DataGridView, ByVal PP_ROW As Integer, ByRef PP_COLUMN As Integer, ByVal PP_ROW_DATA As DataRow, ByVal PP_NOMBRE_DATO As String, Optional PP_DEFAULT As String = "")
        PG_LI_CELL_WRITE_PORCENTAJE(PP_LISTADO, PP_ROW, PP_COLUMN, PP_ROW_DATA, PP_NOMBRE_DATO, PP_DEFAULT)
        PP_COLUMN = PP_COLUMN + 1
    End Sub

    Public Shared Sub PG_LI_CELL_WRITE_SECUENCIAL_FECHA(ByRef PP_LISTADO As DataGridView, ByVal PP_ROW As Integer, ByRef PP_COLUMN As Integer, ByVal PP_ROW_DATA As DataRow, ByVal PP_NOMBRE_DATO As String)
        PG_LI_CELL_WRITE_FECHA(PP_LISTADO, PP_ROW, PP_COLUMN, PP_ROW_DATA, PP_NOMBRE_DATO)
        PP_COLUMN = PP_COLUMN + 1
    End Sub

    Public Shared Sub PG_LI_CELL_WRITE_SECUENCIAL_CHECK(ByRef PP_LISTADO As DataGridView, ByVal PP_ROW As Integer, ByRef PP_COLUMN As Integer)
        PG_LI_CELL_WRITE_CHECK(PP_LISTADO, PP_ROW, PP_COLUMN)
        PP_COLUMN = PP_COLUMN + 1
    End Sub

    Public Shared Sub PG_LI_CELL_WRITE_SECUENCIAL_CHECK(ByRef PP_LISTADO As DataGridView, ByVal PP_ROW As Integer, ByRef PP_COLUMN As Integer, ByVal PP_ROW_DATA As DataRow, ByVal PP_NOMBRE_DATO As String)
        PG_LI_CELL_WRITE_CHECK(PP_LISTADO, PP_ROW, PP_COLUMN, PP_ROW_DATA, PP_NOMBRE_DATO)
        PP_COLUMN = PP_COLUMN + 1
    End Sub

    Public Shared Sub PG_LI_CELL_WRITE_SECUENCIAL_CERO_VACIO(ByRef PP_LISTADO As DataGridView, ByVal PP_ROW As Integer, ByRef PP_COLUMN As Integer, ByVal PP_ROW_DATA As DataRow, ByVal PP_NOMBRE_DATO As String, Optional PP_DEFAULT As String = "")
        PG_LI_CELL_WRITE_CERO_VACIO(PP_LISTADO, PP_ROW, PP_COLUMN, PP_ROW_DATA, PP_NOMBRE_DATO, PP_DEFAULT)
        PP_COLUMN = PP_COLUMN + 1
    End Sub

    ''' <summary>
    ''' le aplica color dorado a la celda
    ''' </summary>
    Public Shared Sub PG_LI_CELL_MOD_COLOR(ByRef PP_LISTADO As DataGridView, ByVal VP_ROW As Integer, ByVal VP_COL As Integer)
        Try
            'PP_LISTADO.Rows(VP_ROW).Cells(VP_COL).Style.BackColor = Color.Gold
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PG_LI_MOD_COLOR")
        End Try
    End Sub

    ''' <summary>
    ''' 'llena la ultima columna con ceros
    ''' </summary>
    Public Shared Sub PG_LI_CELL_ZERO_FILL(ByRef PP_LISTADO As DataGridView, ByVal VP_ROW As Integer)
        Try
            PP_LISTADO.Rows(VP_ROW).Cells("Modificado").Value = 0
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PG_LI_CELL_ZERO_FILL")
        End Try

    End Sub

    ''' <summary>
    ''' 'cambia el color de fondo de la celda
    ''' </summary>
    Public Shared Sub PG_LI_CELL_COLOR_CHANGE(ByRef PP_LISTADO As DataGridView, ByVal VP_ROW As Integer, ByVal VP_COL As Integer, ByVal VP_COLOR As Color)
        Try
            PP_LISTADO.Rows(VP_ROW).Cells(VP_COL).Style.BackColor = VP_COLOR
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PG_LI_CELL_COLOR_CHANGE")
        End Try
    End Sub
#End Region

#Region "SUB_COLUMNS"
    Public Shared Sub PG_LI_COLUMN_ADD(ByRef PP_LISTADO As DataGridView, ByVal Nom_col As String, ByVal Head_Txt As String,
                                       ByVal Tipo_Dato As System.Type, ByVal PP_ANCHO As Integer, ByVal PP_ALINEACION As Integer,
                                       PP_READ As Integer, PP_VISIBLE As Integer, PP_FROZEN As Integer, ByVal PP_FORMAT As Integer,
                                       Optional ByVal PP_COLOR_FONT As Color = Nothing, Optional ByVal PP_COLOR_BACKGROUND As Color = Nothing,
                                       Optional ByVal PP_BOLD As Integer = 0)
        Try



            Dim NuevaCol As New DataGridViewTextBoxColumn With {
                .HeaderText = Head_Txt,
                .Name = Nom_col,
                .Width = PP_ANCHO
            }
            NuevaCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            Select Case PP_FORMAT
                Case 1
                    NuevaCol.DefaultCellStyle.Format = String.Format("n", System.Globalization.CultureInfo.CreateSpecificCulture("hi-IN"))
                Case 2
                    NuevaCol.DefaultCellStyle.Format = String.Format("n", System.Globalization.CultureInfo.CreateSpecificCulture("hi-IN"))
                   'NuevaCol.DefaultCellStyle.Format = String.Format("c", System.Globalization.CultureInfo.CreateSpecificCulture("hi-IN"))
                Case 3
                    NuevaCol.DefaultCellStyle.Format = String.Format("n2", System.Globalization.CultureInfo.CreateSpecificCulture("hi-IN"))
                Case 4
                    NuevaCol.DefaultCellStyle.Format = String.Format("n0", System.Globalization.CultureInfo.CreateSpecificCulture("hi-IN"))
            End Select

            Select Case PP_ALINEACION
                Case 1
                    NuevaCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Case 2
                    NuevaCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Case 3
                    NuevaCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End Select
            If PP_VISIBLE = 1 Then
                NuevaCol.Visible = True
            Else
                NuevaCol.Visible = False
            End If
            If PP_FROZEN = 1 Then
                NuevaCol.Frozen = True
            Else
                NuevaCol.Frozen = False
            End If
            NuevaCol.ValueType = Tipo_Dato

            If PP_COLOR_FONT <> Nothing Then
                NuevaCol.DefaultCellStyle.ForeColor = PP_COLOR_FONT
            End If

            If PP_COLOR_BACKGROUND <> Nothing Then
                NuevaCol.DefaultCellStyle.BackColor = PP_COLOR_BACKGROUND
            End If

            If PP_BOLD > 0 Then
                If PP_BOLD = 1 Then
                    NuevaCol.DefaultCellStyle.Font = New Font(PP_LISTADO.Font, FontStyle.Bold)
                End If
            End If


            ' fragmento de codigo que evalua si la columna se podra o no modificar
            If PP_READ = 1 Then
                PP_LISTADO.Columns.Add(NuevaCol)
            Else
                PP_LISTADO.Columns.Add(NuevaCol)
                PP_LISTADO.Columns(Nom_col).ReadOnly = True
            End If



        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PG_LI_COLUMN_ADD")
        End Try
    End Sub


    Public Shared Sub PG_LI_COLUMN_ADD_CHECK(ByRef PP_LISTADO As DataGridView, ByVal Nom_col As String, ByVal Head_Txt As String,
                                       ByVal Tipo_Dato As System.Type, ByVal PP_ANCHO As Integer, ByVal PP_ALINEACION As Integer,
                                       PP_READ As Integer, PP_VISIBLE As Integer, PP_FROZEN As Integer, ByVal PP_MONEY As Integer)
        Try
            Dim NuevaCol As New DataGridViewCheckBoxColumn With {
                .HeaderText = Head_Txt,
                .Name = Nom_col,
                .Width = PP_ANCHO,
                .FalseValue = False,
                .TrueValue = True
            }

            NuevaCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            'Select Case PP_MONEY
            '    Case 1
            '        NuevaCol.DefaultCellStyle.Format = String.Format("n", System.Globalization.CultureInfo.CreateSpecificCulture("hi-IN"))
            '    Case 2
            '        NuevaCol.DefaultCellStyle.Format = "c"
            'End Select

            Select Case PP_ALINEACION
                Case 1
                    NuevaCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Case 2
                    NuevaCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Case 3
                    NuevaCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End Select
            If PP_VISIBLE = 1 Then
                NuevaCol.Visible = True
            Else
                NuevaCol.Visible = False
            End If
            If PP_FROZEN = 1 Then
                NuevaCol.Frozen = True
            Else
                NuevaCol.Frozen = False
            End If
            'NuevaCol.ValueType = Tipo_Dato
            ' fragmento de codigo que evalua si la columna se podra o no modificar
            If PP_READ = 1 Then
                PP_LISTADO.Columns.Add(NuevaCol)
            Else
                PP_LISTADO.Columns.Add(NuevaCol)
                PP_LISTADO.Columns(Nom_col).ReadOnly = True
            End If

        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PG_LI_COLUMN_ADD_CHECK")
        End Try
    End Sub


    ''' <summary>
    ''' 'Cambia el color de la fuente de la columna
    ''' </summary>
    Public Shared Sub PG_LI_COLUMN_FONT_COLOR_CHANGE(ByRef PP_LISTADO As DataGridView, ByVal PP_NOM_COL As String, ByVal PP_COLOR As Color)
        Try
            PP_LISTADO.Columns(PP_NOM_COL).DefaultCellStyle.ForeColor = PP_COLOR
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PG_LI_COLUMN_FONT_COLOR_CHANGE")
        End Try

    End Sub

    ''' <summary>
    ''' 'cambia el color de fondo de la columna
    ''' </summary>
    Public Shared Sub PG_LI_COLUMN_COLOR_CHANGE(ByRef PP_LISTADO As DataGridView, ByVal VP_NOM_COL As String, ByVal VP_COLOR As Color)
        Try
            PP_LISTADO.Columns(VP_NOM_COL).DefaultCellStyle.BackColor = VP_COLOR
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PG_LI_COLUMN_COLOR_CHANGE")
        End Try

    End Sub

    ''' <summary>
    ''' 'cambia el titulo de la columna
    ''' </summary>
    Public Shared Sub PG_LI_COLUMN_HEAD_CHANGE(ByRef PP_LISTADO As DataGridView, ByVal VP_NOM_COL As String, ByVal VP_TITULO As String)
        Try
            PP_LISTADO.Columns(VP_NOM_COL).HeaderText = VP_TITULO
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("PG_LI_COLUMN_HEAD_CHANGE")
        End Try

    End Sub

#End Region

#Region "FUNCIONES"
    Public Shared Function FG_LI_CELL_READ(ByVal PP_LISTADO As DataGridView, ByVal PP_ROW As Integer, ByVal PP_COLUMNA As String) As String
        Dim VP_ID As String = ""
        Try
            VP_ID = PP_LISTADO.Rows(PP_ROW).Cells(PP_COLUMNA).Value
        Catch ex As Exception
            'Codigo_Message.PG_MENSAJE_ERROR_VS("FG_LI_CELL_READ")
        End Try
        Return VP_ID
    End Function

    Public Shared Function FG_LI_CELL_READ_RUNTIME(ByVal PP_DATAROW As DataRow, ByVal PP_COLUMNA As String) As String
        Dim VP_VALUE As String = ""
        Try
            VP_VALUE = PP_DATAROW(PP_COLUMNA).ToString()
        Catch ex As Exception
            'Codigo_Message.PG_MENSAJE_ERROR_VS("FG_LI_CELL_READ_RUNTIME")
        End Try
        Return VP_VALUE
    End Function

    Public Shared Function FG_LI_CELL_VALUE(ByRef PP_LI_LISTADO As DataGridView, ByVal INDR As Integer, ByVal INDC As String)
        Dim VP_VALOR As String = ""
        Try
            VP_VALOR = CStr(PP_LI_LISTADO.Rows(INDR).Cells(INDC).Value)
        Catch ex As Exception
            'Codigo_Message.PG_MENSAJE_ERROR_VS("FG_LI_CELL_VALUE")
        End Try
        Return VP_VALOR
    End Function

    ''' <summary>
    ''' Recibe un DataTable, indice de row y el nombre de la columna para retornar el valor contenido
    ''' </summary>
    Public Shared Function FG_LI_CELL_READ(ByVal PP_LISTADO As DataTable, ByVal PP_ROW As Integer, ByVal PP_COLUMNA As String) As String
        Dim VP_VALUE As String = ""
        'VP_VALUE = PP_LISTADO(PP_ROW)(PP_COLUMNA).Value
        Try
            VP_VALUE = PP_LISTADO.Rows(PP_ROW)(PP_COLUMNA).ToString()
        Catch ex As Exception
            'Codigo_Message.PG_MENSAJE_ERROR_VS("FG_LI_CELL_READ")
        End Try
        Return VP_VALUE
    End Function

    Public Shared Function FG_LI_CELL_VALUE(ByRef PP_LI_CELL As DataGridViewCell)
        Dim VP_VALOR As String = ""
        Try
            VP_VALOR = CStr(PP_LI_CELL.Value)
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("FG_LI_CELL_VALUE")
        End Try
        Return VP_VALOR
    End Function

    Public Shared Function FG_LI_ROW_CURRENT(ByVal PP_LISTADO As DataGridView) As Integer
        Dim VP_ROW As Integer = -1
        Try
            If PP_LISTADO.CurrentCell IsNot Nothing Then
                VP_ROW = PP_LISTADO.CurrentCell.RowIndex
            End If
        Catch ex As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("FG_LI_ROW_CURRENT")
        End Try
        Return VP_ROW
    End Function

    Public Shared Function FG_LI_MAX_ROW(ByVal PP_LISTADO As DataGridView) As Integer

        Return PP_LISTADO.Rows.Count - 1
    End Function

    Public Shared Function FG_LI_ROW_INDEX(ByVal PP_LISTADO As DataGridView, ByVal PP_VALUE As String, ByVal PP_COLUMNA As String) As Integer
        Try
            If PP_LISTADO.Rows.Count > 0 Then
                For Each VP_ROW As DataGridViewRow In PP_LISTADO.Rows
                    If VP_ROW.Cells(PP_COLUMNA).Value = PP_VALUE Then
                        Return VP_ROW.Index
                    End If
                Next
            Else
                Codigo_Message.PG_MENSAJE_AVISO("El <Listado> se encuentra vacio, verifique.")
                Return -1
            End If
        Catch ex As Exception
            Return -1
        End Try
        Return -1
    End Function

    Public Shared Function FG_LI_ROW_SELECTED(ByVal PP_LISTADO As DataGridView) As Boolean
        Try
            If PP_LISTADO.Rows.Count > 0 Then
                If PP_LISTADO.CurrentCell Is Nothing Then
                    Codigo_Message.PG_MENSAJE_AVISO("Favor de <Seleccionar> un registro.")
                    Return False
                Else
                    Return True
                End If
            Else
                Codigo_Message.PG_MENSAJE_AVISO("El <Listado> se encuentra vacio, verifique.")
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function

    Public Shared Function FG_LI_NOT_EMPTY(ByVal PP_LISTADO As DataGridView) As Boolean
        Try
            If PP_LISTADO.Rows.Count > 0 Then
                Return True
            Else
                Codigo_Message.PG_MENSAJE_AVISO("El <Listado> se encuentra vacio, verifique.")
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function

#End Region
End Class


