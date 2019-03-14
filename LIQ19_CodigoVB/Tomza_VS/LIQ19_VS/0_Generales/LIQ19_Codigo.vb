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
End Class
