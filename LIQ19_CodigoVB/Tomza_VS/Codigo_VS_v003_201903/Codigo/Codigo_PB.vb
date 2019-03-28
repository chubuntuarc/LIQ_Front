Public Class Codigo_PB

#Region "SUBS"

    Public Shared Sub PG_PB_INIT(ByRef PP_PB_PROGRESSBAR As ProgressBar, ByVal PP_MIN As Integer, ByVal PP_MAX As Integer)

    End Sub

    Public Shared Sub PG_PB_LOAD(ByRef PP_PB_PROGRESSBAR As ProgressBar, ByVal PP_VAL As Integer)


    End Sub


    Public Shared Sub PG_PB_CLEAR(ByRef PP_COMBO As ComboBox)

    End Sub

#End Region

End Class

Public Class BARRA_DE_PROGRESO
    Dim PB_BARRA_DE_PROGRESO As ProgressBar
    Dim PB_MIN As Integer
    Dim PB_MAX As Integer
    Dim PB_VALUE As Integer
    Dim PB_TITULO As Label
    Dim PB_ETIQUETA_PROGRESO As Label

    Public Sub New(pB_BARRA_DE_PROGRESO As ProgressBar, pB_MIN As Integer, pB_MAX As Integer, pB_TITULO As String)
        Dim PP_GB_PADRE = pB_BARRA_DE_PROGRESO.Parent
        Me.PB_BARRA_DE_PROGRESO = pB_BARRA_DE_PROGRESO
        Me.PB_MIN = pB_MIN
        Me.PB_BARRA_DE_PROGRESO.Minimum = Me.PB_MIN
        Me.PB_MAX = pB_MAX
        Me.PB_BARRA_DE_PROGRESO.Maximum = Me.PB_MAX1
        Me.PB_BARRA_DE_PROGRESO.Value = Me.PB_MIN
        Me.PB_TITULO = New Label()

        Me.PB_TITULO.Location = New Point(pB_BARRA_DE_PROGRESO.Location.X, pB_BARRA_DE_PROGRESO.Location.Y - 15)
        Me.PB_TITULO.AutoSize = False
        Me.PB_TITULO.Width = pB_BARRA_DE_PROGRESO.Width - 240
        Me.PB_TITULO.Height = 13
        Me.PB_TITULO.TextAlign = ContentAlignment.MiddleLeft
        Me.PB_TITULO.Text = pB_TITULO
        Me.PB_TITULO.Visible = True
        PP_GB_PADRE.Controls.Add(Me.PB_TITULO)
        Me.PB_TITULO.BringToFront()
        Me.PB_ETIQUETA_PROGRESO = New Label()

        Me.PB_ETIQUETA_PROGRESO.Text = "Progreso: " + pB_MIN.ToString + "/" + pB_MAX.ToString()
        Me.PB_ETIQUETA_PROGRESO.Location = New Point(pB_BARRA_DE_PROGRESO.Location.X + pB_BARRA_DE_PROGRESO.Width - 250, pB_BARRA_DE_PROGRESO.Location.Y - 15)
        Me.PB_ETIQUETA_PROGRESO.AutoSize = False
        Me.PB_ETIQUETA_PROGRESO.Width = 250
        Me.PB_ETIQUETA_PROGRESO.Height = 13
        Me.PB_ETIQUETA_PROGRESO.TextAlign = ContentAlignment.MiddleRight
        Me.PB_ETIQUETA_PROGRESO.Visible = True
        PP_GB_PADRE.Controls.Add(Me.PB_ETIQUETA_PROGRESO)
        Me.PB_ETIQUETA_PROGRESO.BringToFront()
    End Sub

    Public Property PB_MAX1 As Integer
        Get
            Return PB_MAX
        End Get
        Set(value As Integer)
            PB_MAX = value
        End Set
    End Property

    Public Sub PG_BARRA_DE_PROGRESO_ACT(ByVal PP_VALUE As Integer)

        If Me.PB_MAX > PP_VALUE Then
            PB_BARRA_DE_PROGRESO.Value = PP_VALUE
            Me.PB_ETIQUETA_PROGRESO.Text = "Progreso: " + PP_VALUE.ToString + "/" + PB_MAX1.ToString()
            If PP_VALUE > PB_MAX1 * 0.95 Then
                Threading.Thread.Sleep(10)
                If PP_VALUE > PB_MAX1 * 0.98 Then
                    Threading.Thread.Sleep(70)
                End If
            End If


        End If

    End Sub

    Public Sub PG_BARRA_DE_PROGRESO_FINALIZAR()
        Me.PB_ETIQUETA_PROGRESO.Dispose()
        Me.PB_TITULO.Dispose()
        Me.PB_BARRA_DE_PROGRESO.Dispose()
    End Sub

End Class



Public Class BARRA_DE_PROGRESO_PANEL
    Dim PB_BASE_BARRA As TextBox
    Dim PB_BARRA_DE_PROGRESO As Panel
    Dim PB_MIN As Integer
    Dim PB_MAX As Integer
    Dim PB_VALUE As Integer
    Dim PB_TITULO As Label
    Dim PB_ETIQUETA_PROGRESO As Label

    Public Sub New(ByRef PP_LB_RESULTADO As TextBox, ByRef PP_PB_BARRA_DE_PROGRESO As Panel, PP_PB_MIN As Integer, PP_PB_MAX As Integer, PP_PB_TITULO As String)
        Dim PP_GB_PADRE = PP_LB_RESULTADO.Parent
        Me.PB_BASE_BARRA = PP_LB_RESULTADO
        Me.PB_BARRA_DE_PROGRESO = PP_PB_BARRA_DE_PROGRESO
        Me.PB_MIN = PP_PB_MIN
        Me.PB_MAX = PP_PB_MAX
        Me.PB_BARRA_DE_PROGRESO.Width = Me.PB_MIN
        PB_TITULO = New Label()
        PP_GB_PADRE.Controls.Add(PB_TITULO)
        PB_TITULO.Location = New Point(8, 17)
        PB_TITULO.AutoSize = False
        PB_TITULO.Width = PB_BASE_BARRA.Width - 240
        PB_TITULO.Height = 13
        PB_TITULO.BackColor = Color.White
        PB_TITULO.ForeColor = Color.Black
        PB_TITULO.TextAlign = ContentAlignment.TopLeft
        PB_TITULO.Text = PP_PB_TITULO
        PB_TITULO.Font = New Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular)
        PB_TITULO.Visible = True
        PB_TITULO.BringToFront()
        PB_ETIQUETA_PROGRESO = New Label()
        PP_GB_PADRE.Controls.Add(PB_ETIQUETA_PROGRESO)
        PB_ETIQUETA_PROGRESO.Text = "Progreso: " + PP_PB_MIN.ToString() + "/" + PP_PB_MAX.ToString()
        PB_ETIQUETA_PROGRESO.Location = New Point(PB_BASE_BARRA.Location.X - 1 + PB_BASE_BARRA.Width - 250, 17)
        PB_ETIQUETA_PROGRESO.AutoSize = False
        PB_ETIQUETA_PROGRESO.Width = 250
        PB_ETIQUETA_PROGRESO.Font = New Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular)
        PB_ETIQUETA_PROGRESO.BackColor = Color.White
        PB_ETIQUETA_PROGRESO.ForeColor = Color.Black
        PB_ETIQUETA_PROGRESO.Height = 13
        PB_ETIQUETA_PROGRESO.TextAlign = ContentAlignment.TopRight
        PB_ETIQUETA_PROGRESO.Visible = True
        PB_ETIQUETA_PROGRESO.BringToFront()
        Application.DoEvents()
    End Sub

    Public Property PB_MAX1 As Integer
        Get
            Return PB_MAX
        End Get
        Set(value As Integer)
            PB_MAX = value
        End Set
    End Property

    Public Sub PG_BARRA_DE_PROGRESO_ACT(ByVal PP_VALUE As Integer)

        If Me.PB_MAX > PP_VALUE Then
            PB_BARRA_DE_PROGRESO.Width = (PB_BASE_BARRA.Width * (PP_VALUE / PB_MAX))
            PB_ETIQUETA_PROGRESO.Text = "Progreso: " + PP_VALUE.ToString + "/" + PB_MAX1.ToString()
            PB_ETIQUETA_PROGRESO.Refresh()
            PB_BARRA_DE_PROGRESO.BringToFront()
            PB_BARRA_DE_PROGRESO.Refresh()
            'If PP_VALUE > PB_MAX1 * 0.95 Then
            '    Threading.Thread.Sleep(30)
            '    'If PP_VALUE > PB_MAX1 * 0.98 Then
            '    '    Threading.Thread.Sleep(70)
            '    'End If
            'End If
        End If

    End Sub

    Public Sub PG_BARRA_DE_PROGRESO_ACT(ByVal PP_VALUE As Integer, ByVal PP_NOMBRE_ITEM As String)

        If Me.PB_MAX > PP_VALUE Then
            PB_BARRA_DE_PROGRESO.Width = (PB_BASE_BARRA.Width * (PP_VALUE / PB_MAX))
            PB_ETIQUETA_PROGRESO.Text = "Item en Proceso: " + PP_NOMBRE_ITEM + "   Progreso: " + PP_VALUE.ToString + "/" + PB_MAX1.ToString()
            PB_ETIQUETA_PROGRESO.Refresh()
            PB_BARRA_DE_PROGRESO.BringToFront()
            PB_BARRA_DE_PROGRESO.Refresh()
            'If PP_VALUE > PB_MAX1 * 0.95 Then
            '    Threading.Thread.Sleep(30)
            '    'If PP_VALUE > PB_MAX1 * 0.98 Then
            '    '    Threading.Thread.Sleep(70)
            '    'End If
            'End If
        End If

    End Sub

    Public Sub PG_BARRA_DE_PROGRESO_FINALIZAR()
        Me.PB_ETIQUETA_PROGRESO.Dispose()
        Me.PB_TITULO.Dispose()
        Me.PB_BARRA_DE_PROGRESO.Dispose()
    End Sub

End Class



