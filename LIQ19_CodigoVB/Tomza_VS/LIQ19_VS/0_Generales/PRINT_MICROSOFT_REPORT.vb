Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.IO
Imports System.Text
Imports Microsoft.Reporting.WinForms
Module PRINT_MICROSOFT_REPORT
    'VARIABLES PRIVADAS DE LA CLASE
    Private VP_INDICE_PAGINA_ACTUAL As Integer
    Private VP_CONJUNTO_STREAMS As IList(Of Stream)
    Private VP_DOCUMENTO_IMPRIMIR As PrintDocument

    Private VP_IMPRESORA_DEFAULT = FG_IMPRESORA_DEFAULT()

    Private warnings() As Warning = Nothing 'NECEARIO PARA RENDER EN REPORTE LOCAL

    'IMPRIMIR UN REPORTE RDLC CON UNA ESPECIFICACION DE PAPEL
    '"PP_TIPO_PAPEL / A4, Letter"
    '"PP_LANDSCAPE / False, True"
    '"PP_NOMBRE_IMPRESORA --VACIO (IMPRESORA POR DEFECTO) / "NOMBRE IMPRESORA"

    Public Sub PG_IMPRIMIR_REPORTE(ByVal PP_REPORTE As LocalReport, Optional PP_TIPO_PAPEL As String = "Letter", Optional ByVal PP_LANDSCAPE As Boolean = True, Optional ByVal PP_NOMBRE_IMPRESORA As String = Nothing)
        VP_DOCUMENTO_IMPRIMIR = New PrintDocument()

        'REVISAR SI SE ENVIA LA IMPRESORA POR DEFECTO O SE ASIGNA UNA
        If PP_NOMBRE_IMPRESORA <> Nothing Then VP_DOCUMENTO_IMPRIMIR.PrinterSettings.PrinterName = PP_NOMBRE_IMPRESORA 'SI SE ESPECIFICA LA IMPRESORA , AQUI SE INDICA  QUE SE UTILIZAFRA PARA IMPRIMIR EL DOCUMENTO.
        If Not VP_DOCUMENTO_IMPRIMIR.PrinterSettings.IsValid Then 'SE VALIDA QUE LA IMPRESORA PUEDA USARSE

            Codigo_Mensaje.PG_MENSAJE_AVISO("No se encontro la impresora especificada.")
            Throw New Exception("Cannot find the specified printer")
        Else 'SI LA IMPRESORA ES VALIDA
            Dim VP_TAMANO_PAPEL As PaperSize
            Dim VP_TIPO_PAPEL_ENCONTRADO As Boolean = False

            'BUSQUEDA DE TAMANO DE PAPEL, PARA ASIGNARLO AL DOCUMENTO
            For i = 0 To VP_DOCUMENTO_IMPRIMIR.PrinterSettings.PaperSizes.Count - 1 'SE REVISAN LOS TIPOS DE PAPEL DISPONIBLES
                If VP_DOCUMENTO_IMPRIMIR.PrinterSettings.PaperSizes.Item(i).Kind.ToString = PP_TIPO_PAPEL Then 'SE DETECTA EL TIPO DE PAPEL IGUAL AL RECIBIDO
                    VP_TAMANO_PAPEL = VP_DOCUMENTO_IMPRIMIR.PrinterSettings.PaperSizes.Item(i) 'SE ASIGNA EL TAMANO DE PAPEL INDICADO
                    VP_DOCUMENTO_IMPRIMIR.DefaultPageSettings.PaperSize = VP_TAMANO_PAPEL 'EL TAMANO DE PAPEL SE LE ASIGNA AL DOCUMENTO A IMPRIMIR
                    VP_TIPO_PAPEL_ENCONTRADO = True 'SE INDICA QUE SE ENCONTRO EL TIPO DE PAPEL DESEADO
                End If
            Next

            If Not VP_TIPO_PAPEL_ENCONTRADO Then

                Codigo_Mensaje.PG_MENSAJE_AVISO("No se encontro el tamano de papel indicado")
                Throw New Exception("paper size is invalid")
            End If

            VP_DOCUMENTO_IMPRIMIR.DefaultPageSettings.Landscape = PP_LANDSCAPE 'SE INDICA SI EL DOCUMENTO SE IMPRIME EN MODO LANDSCAPE

            'EXPORTAR EL REPORTE LOCAL COMO EMF (ENHACED METAFILE)
            PG_EXPORTAR_REPORTE_LOCAL(PP_REPORTE)

            'IMPRIMIR EL DOCUMENTO
            PG_IMPRIMIR()

        End If

    End Sub

    'SE INDICA AL RENDER DE REPORTE EL ORDEN EN QUE DEBEN AGREGARSE LAS IMAGENES.
    Private Function FG_CREAR_STREAM(ByVal PP_NOMBRE As String, ByVal PP_EXTENSION_ARCHIVO As String,
                                     ByVal ENCODING As Encoding, ByVal MIMETYPE As String, ByVal WILLSEEK As Boolean) As Stream
        Dim STREAM As Stream = New MemoryStream()
        VP_CONJUNTO_STREAMS.Add(STREAM) 'SE AGREGA EL STREAM/REPORTE A LA LISTA DE REPORTES
        Return STREAM
    End Function

    'PROCEDIMIENTO PARA EXPORTAR EL REPORTE RECIBIDO A METAFILE
    Private Sub PG_EXPORTAR_REPORTE_LOCAL(ByVal PP_REPORTE_LOCAL As LocalReport)
        Dim VP_ANCHO As Integer
        Dim VP_ALTO As Integer

        'REVISAR SI EL DOCUMENTO ES LANDSCAPE PARA INDICAR EL ALTO Y ANCHO DEL DOCUMENTO
        If VP_DOCUMENTO_IMPRIMIR.DefaultPageSettings.Landscape = True Then
            VP_ANCHO = VP_DOCUMENTO_IMPRIMIR.DefaultPageSettings.PaperSize.Height
            VP_ALTO = VP_DOCUMENTO_IMPRIMIR.DefaultPageSettings.PaperSize.Width
        Else
            VP_ANCHO = VP_DOCUMENTO_IMPRIMIR.DefaultPageSettings.PaperSize.Width
            VP_ALTO = VP_DOCUMENTO_IMPRIMIR.DefaultPageSettings.PaperSize.Height
        End If

        Dim VP_FORMATO_SALIDA As String = "<DeviceInfo>" &
            "<OutputFormat>EMF</OutputFormat>" &
            "<PageWidth>" & VP_ANCHO / 100 & "in</PageWidth>" &
            "<PageHeight>" & VP_ALTO / 100 & "in</PageHeight>" &
            "<MarginTop>0.0in</MarginTop>" &
            "<MarginLeft>0.0in</MarginLeft>" &
            "<MarginRight>0.0in</MarginRight>" &
            "<MarginBottom>0.0in</MarginBottom>" &
            "</DeviceInfo>"

        VP_CONJUNTO_STREAMS = New List(Of Stream)() 'SE INICIALIZA LA LISTA DE REPORTES
        PP_REPORTE_LOCAL.Render("image", VP_FORMATO_SALIDA, AddressOf FG_CREAR_STREAM, warnings)

        'SE REVISA LA CANT
        For Each STREAM As Stream In VP_CONJUNTO_STREAMS
            STREAM.Position = 0 'SE ESTABLECE LA POSICION EN EL STREAM ACTUAL
        Next

    End Sub

    'SE GENERA LA PAGINA A IMPRIMIR
    Private Sub PG_PAGINA_IMPRESION(ByVal SENDER As Object, ByVal EV As PrintPageEventArgs)
        'IMAGEN DE PAGINA
        Dim VP_IMAGEN_PAGINA As New Metafile(VP_CONJUNTO_STREAMS(VP_INDICE_PAGINA_ACTUAL)) 'SE CREA LA IMAGEN A PARTIR DE EL STREAM INDICADO POR EL INDICE

        'AJUSTAR EL AREA DE IMRPESION
        Dim VP_AJUSTE_PAGINA As New Rectangle(EV.PageBounds.Left - CInt(EV.PageSettings.HardMarginX),
                                              EV.PageBounds.Top - CInt(EV.PageSettings.HardMarginY),
                                              EV.PageBounds.Width, EV.PageBounds.Height)

        'DIBUJAR FONDO BLANCO EN EL REPORTE
        EV.Graphics.FillRectangle(Brushes.White, VP_AJUSTE_PAGINA)

        'DIBUJAR EL CONTENIDO DEL REPORTE
        EV.Graphics.DrawImage(VP_IMAGEN_PAGINA, VP_AJUSTE_PAGINA)

        'PREPARAR PARA LA PAGINA SIGUIENTE
        VP_INDICE_PAGINA_ACTUAL += 1
        EV.HasMorePages = (VP_INDICE_PAGINA_ACTUAL < VP_CONJUNTO_STREAMS.Count)

    End Sub

    Private Sub PG_IMPRIMIR()
        'REVISAR SI EXISTEN REPORTES A IMPRIMIR
        If VP_CONJUNTO_STREAMS Is Nothing OrElse VP_CONJUNTO_STREAMS.Count = 0 Then
            Throw New Exception("Error: no stream to print.")
        End If

        AddHandler VP_DOCUMENTO_IMPRIMIR.PrintPage, AddressOf PG_PAGINA_IMPRESION 'SE INDICA LA PAGINA A IMPRIMIR EN EL DOCUMENTO

        VP_INDICE_PAGINA_ACTUAL = 0

        VP_DOCUMENTO_IMPRIMIR.Print() 'SE IMPRIME EL DOCUMENTO

    End Sub


    'SE OBTIENE EL NOMBRE POR DEFECTO DE LA IMPRESORA
    Public Function FG_IMPRESORA_DEFAULT() As String

        Dim oPS As New PrinterSettings

        Try
            VP_IMPRESORA_DEFAULT = oPS.PrinterName
        Catch ex As System.Exception
            VP_IMPRESORA_DEFAULT = ""
        Finally
            oPS = Nothing
        End Try

        Return VP_IMPRESORA_DEFAULT

    End Function

End Module