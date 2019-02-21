Imports System.IO
Imports System.Xml
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Public Class Codigo_XML_V2

    Public Shared Sub PG_NODOS(ByRef PP_TREEVIEW As TreeView, ByRef rootNode As String)
        Dim info As DirectoryInfo = New DirectoryInfo(rootNode)
        Dim PP_ROOTNODE As New TreeNode
        If info.Exists Then
            'rootNode = New TreeNode(info.Name)
            PP_ROOTNODE = New TreeNode(info.Name)
            PP_ROOTNODE.Tag = info
            PG_DIRECTORIO(info.GetDirectories, PP_ROOTNODE)
            PP_TREEVIEW.Nodes.Add(PP_ROOTNODE)
        End If

    End Sub

    Public Shared Sub PG_DIRECTORIO(ByVal subDirs() As DirectoryInfo, ByVal nodeToAddTo As TreeNode)
        Dim aNode As TreeNode
        Dim subSubDirs() As DirectoryInfo
        For Each subDir As DirectoryInfo In subDirs
            aNode = New TreeNode(subDir.Name, 0, 0)
            aNode.Tag = subDir
            aNode.ImageKey = "folder"
            On Error GoTo 0
            subSubDirs = subDir.GetDirectories

            If (subSubDirs.Length <> 0) Then
                PG_DIRECTORIO(subSubDirs, aNode)
            End If

            nodeToAddTo.Nodes.Add(aNode)
        Next

    End Sub

    Public Shared Function PG_OBTENER_ATRIBUTOS(ByVal PP_ID_BASE_DE_DATOS As Integer, ByRef PP_FORMA As Object,
                                                ByRef PP_LV_DIR As ListView, ByRef PP_RT_EVENTOS As RichTextBox,
                                                ByRef PP_TV_DIR As TreeView, Optional ByRef PP_REFERENCIA As Integer = 0) As List(Of XML)
        Dim VP_LISTA_XML As New List(Of XML)
        Dim VP_CONTA_OK As Integer = 0
        Dim VP_CONTA_KO As Integer = 0
        Dim VP_CONTA_EXISTENTE As Integer = 0
        Dim VP_CONTA_PRE As Integer = 0
        Dim VP_CONTA_PRE_KO As Integer = 0
        Dim VP_CONTA_PRE_OK As Integer = 0
        Dim VP_CONTA_PRO_KO As Integer = 0

        If PP_LV_DIR.SelectedItems.Count <= 0 Then
            Codigo_Message.PG_MENSAJE_AVISO("Selecciona el o los [ARCHIVOS]")
        Else
            Dim registro As ListViewItem
            Dim VP_PB_PROGRESSBAR As BARRA_DE_PROGRESO_PANEL
            Dim VP_COUNT = PP_LV_DIR.SelectedItems.Count
            VP_PB_PROGRESSBAR = ProgressBarPanel.FG_PROGRESSBAR_INIT(PP_FORMA, 0, VP_COUNT, "Carga de Archivos", Color.DarkOrange)
            ' PP_FORMA.PB_ESTATUS_CARGA.Maximum = PP_FORMA.LV_DIR.SelectedItems.Count
            Dim VP_CONTADOR As Integer = 0
            Dim VP_INICIO As New DateTime
            VP_INICIO = DateTime.Now

            For Each registro In PP_LV_DIR.SelectedItems
                VP_CONTADOR = VP_CONTADOR + 1
                ProgressBarPanel.PG_PROGRESSBAR_INCREMENT(VP_PB_PROGRESSBAR, VP_CONTADOR)
                Dim VP_CLAVE As Integer = 0
                Dim VP_XML As New XML
                Try
                    VP_XML.PP_NOMBRE1 = registro.Text
                    If VP_XML.PP_NOMBRE1.ToUpper.EndsWith(".XML") Then
                        Dim RUTA As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                        Dim R As String = PP_TV_DIR.SelectedNode.FullPath
                        Dim Rutas As String = PP_TV_DIR.SelectedNode.Text
                        Dim VL_ARREGLO_DIR As String() = RUTA.ToString.Split("\")

                        Dim VL_UNIDAD As String = VL_ARREGLO_DIR(0)
                        Dim VL_USUARIO As String = VL_ARREGLO_DIR(1)
                        Dim VL_PERFIL As String = VL_ARREGLO_DIR(2)
                        Dim VL_DESKTOP As String = VL_ARREGLO_DIR(3)
                        Dim PP_ARCHIVO As String = (VL_UNIDAD + "\" + VL_USUARIO + "\" + VL_PERFIL + "\" + R + "\" + VP_XML.PP_NOMBRE1)

                        Dim VP_ARCHIVO = File.ReadAllText(PP_ARCHIVO)
                        Dim VP_ARCHIVO_XML = VP_ARCHIVO.ToLower()
                        Dim xmlDocument As XmlDocument = New XmlDocument()
                        xmlDocument.LoadXml(VP_ARCHIVO_XML)

                        VP_XML.XML_FECHA1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "fecha", "fechaf", "")
                        VP_XML.XML_FORMAPAGO1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "formadepago", "formapago", "")
                        VP_XML.XML_FECHA1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "fecha", "fechaf", "")
                        VP_XML.XML_FOLIO1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "folio", "foliof", "")
                        VP_XML.XML_FORMAPAGO1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "formadepago", "formapago", "formapagof")
                        VP_XML.XML_LUGAREXPEDICION1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "lugarexpedicion", "", "")
                        VP_XML.XML_METODO_PAGO1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "metododepago", "metodopago", "")
                        VP_XML.XML_MONEDA1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "moneda", "", "")
                        VP_XML.XML_NOCERTIFICADO1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "nocertificado", "", "")
                        VP_XML.XML_SERIE1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "serie", "", "")
                        VP_XML.XML_SUBTOTAL1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "subtotal", "", "")
                        VP_XML.XML_TIPOCAMBIO1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "tipocambio", "", "")
                        VP_XML.XML_TIPODECOMPROBANTE1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "tipodecomprobante", "", "")
                        VP_XML.XML_TOTAL1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "total", "", "")
                        VP_XML.XML_VERSION1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "version", "", "")
                        VP_XML.XML_EMI_NOMBRE1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:emisor", "nombre", "", "")
                        VP_XML.XML_EMI_REGIMENFISCAL1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:regimenfiscal", "regimen", "", "")
                        VP_XML.XML_EMI_RFC1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:emisor", "rfc", "", "")
                        VP_XML.XML_REC_NOMBRE1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:receptor", "nombre", "", "")
                        VP_XML.XML_REC_RFC1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:receptor", "rfc", "", "")
                        VP_XML.XML_REC_USOCFDI1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:receptor", "usocfdi", "", "")
                        VP_XML.XML_TOTALIMPUESTOSTRASLADADOS1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:impuestos", "totalimpuestostrasladados", "", "")
                        VP_XML.XML_IMPORTE1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:traslado", "importe", "", "")
                        VP_XML.XML_IMPUESTO1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:traslado", "impuesto", "", "")
                        VP_XML.XML_TASAOCUOTA1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:traslado", "tasa", "tasaocuota", "")
                        VP_XML.XML_TIPOFACTOR1 = FG_XML_GET_VALOR(xmlDocument, "cfdi:traslado", "tipofactor", "", "")
                        VP_XML.XML_FECHATIMBRADO1 = FG_XML_GET_VALOR(xmlDocument, "tfd:timbrefiscaldigital", "fechatimbrado", "", "")
                        VP_XML.XML_NOCERTIFICADOSAT1 = FG_XML_GET_VALOR(xmlDocument, "tfd:timbrefiscaldigital", "nocertificadosat", "", "")
                        VP_XML.XML_UUID1 = FG_XML_GET_VALOR(xmlDocument, "tfd:timbrefiscaldigital", "uuid", "", "")

                        VP_XML.VL_XML_FECHA_MOSTRAR1 = Codigo_ABC.FG_DT_CONVIERTE_FECHA_XML_A_SQL(VP_XML.XML_FECHA1)  'VP_XML.XML_FECHA1 '
                        VP_XML.VL_XML_FECHATIMBRADO_MOSTRAR1 = Codigo_ABC.FG_DT_CONVIERTE_FECHA_XML_A_SQL(VP_XML.XML_FECHATIMBRADO1)

                        If VP_XML.XML_TOTALIMPUESTOSTRASLADADOS1 = "" Then
                            VP_XML.XML_TOTALIMPUESTOSTRASLADADOS1 = 0
                        End If
                        If VP_XML.XML_IMPORTE1 = "" Then
                            VP_XML.XML_IMPORTE1 = 0
                        End If

                        Dim VP_TABLA As Data.DataTable
                        VP_TABLA = FG_VERIFICAR_RFC_FACTURA_XML(PP_FORMA, VP_XML.XML_EMI_RFC1, PP_REFERENCIA)

                        If VP_TABLA.Rows.Count = 0 Then
                            Dim VP_TEXTO3 As String = vbCrLf + "[ PRE ]   //   " + "[PROVEEDOR], [RFC]: " + VP_XML.XML_EMI_RFC1.ToUpper + " //  , [RAZON SOCIAL]: " + VP_XML.XML_EMI_NOMBRE1.ToUpper + " no existe. Se hará un [PREREGISTRO]"
                            PG_RT_WRITE_TEXT(PP_RT_EVENTOS, VP_TEXTO3, Color.YellowGreen)
                            VP_CONTA_PRE += 1

                            Dim VP_TABLAP As Data.DataTable
                            VP_TABLAP = FG_PREREGISTRO_PROVEEDOR(PP_FORMA, VP_XML.XML_EMI_RFC1, VP_XML.XML_EMI_NOMBRE1, PP_REFERENCIA)

                            If VP_TABLAP.Rows.Count = 0 Then
                                Dim VP_TEXTO4 As String = vbCrLf + "[ERROR]   //   " + "[PROVEEDOR], [RFC]: " + VP_XML.XML_EMI_RFC1.ToUpper + " //  , [RAZON SOCIAL]: " + VP_XML.XML_EMI_NOMBRE1.ToUpper + " //  [PROBLEMA] al realizar el [PREREGISTRO] del [PROVEEDOR]"
                                PG_RT_WRITE_TEXT(PP_RT_EVENTOS, VP_TEXTO4, Color.Red)
                                VP_CONTA_PRE_KO += 1
                            Else
                                Dim VP_TEXTO5 As String = vbCrLf + "[ O.K ]   //   " + "[PROVEEDOR], [RFC]: " + VP_XML.XML_EMI_RFC1.ToUpper + " //  , [RAZON SOCIAL]: " + VP_XML.XML_EMI_NOMBRE1.ToUpper + " //  [CORRECTA] la carga del [PREREGISTRO] del [PROVEEDOR]"
                                PG_RT_WRITE_TEXT(PP_RT_EVENTOS, VP_TEXTO5, Color.Green)
                                VP_CONTA_PRE_OK += 1

                                Dim VP_MENSAJE As String = ""

                                VP_MENSAJE = FG_INSERTAR_FACTURA_XML(PP_ID_BASE_DE_DATOS, PP_FORMA, VP_XML, VP_ARCHIVO, VP_CLAVE)
                                If VP_MENSAJE = "" Then
                                    VP_CONTA_OK += 1

                                Else
                                    VP_CONTA_EXISTENTE += 1
                                End If
                            End If
                        Else
                            Dim VP_ESTATUS As String = ""
                            If PP_REFERENCIA <> 0 Then
                                VP_ESTATUS = Codigo_LI.FG_LI_CELL_READ(VP_TABLA, 0, "K_ESTATUS_PROVEEDOR_VIATICO")
                            Else
                                VP_ESTATUS = Codigo_LI.FG_LI_CELL_READ(VP_TABLA, 0, "K_ESTATUS_PROVEEDOR")
                            End If

                            If VP_ESTATUS = 3 Then
                                Dim VP_TEXTO6 As String = vbCrLf + "[ERROR]   //   " + "[PROVEEDOR], [RFC]: " + VP_XML.XML_EMI_RFC1.ToUpper + " //  , [RAZON SOCIAL]: " + VP_XML.XML_EMI_NOMBRE1.ToUpper + " //  [PROBLEMA] con el [PROVEEDOR], se encuentra [SUSPENDIDO]"
                                PG_RT_WRITE_TEXT(PP_RT_EVENTOS, VP_TEXTO6, Color.YellowGreen)
                                VP_CONTA_PRO_KO += 1
                            ElseIf VP_ESTATUS = 4 Then
                                Dim VP_TEXTO7 As String = vbCrLf + "[ERROR]   //   " + "[PROVEEDOR], [RFC]: " + VP_XML.XML_EMI_RFC1.ToUpper + " //  , [RAZON SOCIAL]: " + VP_XML.XML_EMI_NOMBRE1.ToUpper + " //  [PROBLEMA] con el [PROVEEDOR], fue dado de [BAJA]"
                                PG_RT_WRITE_TEXT(PP_RT_EVENTOS, VP_TEXTO7, Color.YellowGreen)
                                VP_CONTA_PRO_KO += 1
                            Else
                                Dim VP_MENSAJE As String = ""
                                VP_MENSAJE = FG_INSERTAR_FACTURA_XML(PP_ID_BASE_DE_DATOS, PP_FORMA, VP_XML, VP_ARCHIVO, VP_CLAVE)
                                If VP_MENSAJE = "" Then
                                    VP_CONTA_OK += 1
                                Else
                                    VP_CONTA_EXISTENTE += 1
                                End If
                            End If
                        End If

                        '----------------------------------------------------
                        '///////////GUARDA PDF SI LO ENCUENTRA CON EL MISMO NOMBRE QUE EL XML/////////////
                        Dim vOrigen As String = PP_ARCHIVO
                        Dim VP_ORIGEN_PDF As String = PP_ARCHIVO.Substring(0, PP_ARCHIVO.Length - 3)
                        VP_ORIGEN_PDF = VP_ORIGEN_PDF + "pdf"

                        Dim vDestino As String = "\\10.0.5.34\cfdi_docs\" + VP_CLAVE.ToString() + ".pdf"

                        'Try
                        '    'System.IO.File.Copy(VP_ORIGEN_PDF, vDestino, True)
                        'Catch ex As Exception

                        'End Try
                        '-----------------------------------------------------
                        If VP_CONTADOR <= VP_COUNT Then
                            PP_RT_EVENTOS.SelectionStart = Len(PP_RT_EVENTOS.Text)
                            PP_RT_EVENTOS.ScrollToCaret()
                            PP_RT_EVENTOS.Select()

                            If VP_CONTADOR = VP_COUNT Then
                                PP_FORMA.LB_PROCESADOS.Text = "Total de archivos procesados:" + VP_COUNT.ToString
                                PP_FORMA.LB_OK.Text = " // Correctos: " + VP_CONTA_OK.ToString
                                PP_FORMA.LB_EXISTENTE.Text = " // Existentes: " + VP_CONTA_EXISTENTE.ToString
                                PP_FORMA.LB_PRE.Text = " // Preregistros: " + VP_CONTA_PRE.ToString
                                PP_FORMA.LB_PRE_OK.Text = " // Preregistros Correctos: " + VP_CONTA_PRE_OK.ToString
                                PP_FORMA.LB_PRE_KO.Text = " // Preregistros con Errores: " + VP_CONTA_PRE_KO.ToString
                                PP_FORMA.LB_PRO_KO.Text = " // Proveedores Suspendidos/Bajas: " + VP_CONTA_PRO_KO.ToString
                                Codigo_Message.PG_MENSAJE_AVISO("[Carga] de archivos [XML] finalizada")
                                Dim VP_FINAL As New DateTime
                                VP_FINAL = DateTime.Now
                                Dim VP_TIEMPO_TOTAL As TimeSpan = VP_FINAL - VP_INICIO
                                Dim VP_SEGUNDOS As String = Convert.ToInt32(VP_TIEMPO_TOTAL.TotalSeconds).ToString()
                                Dim VP_TEXTO_R As String = Environment.NewLine + Environment.NewLine + "Proceso finalizado, se procesaron " + VP_COUNT.ToString() + " archivos XML en " + VP_SEGUNDOS + " segundos."
                                PG_RT_WRITE_TEXT(PP_RT_EVENTOS, VP_TEXTO_R, Color.Blue)

                                PP_RT_EVENTOS.SelectionStart = Len(PP_RT_EVENTOS.Text)
                                PP_RT_EVENTOS.ScrollToCaret()
                                PP_RT_EVENTOS.Select()

                            End If
                        End If

                    Else
                        Codigo_Message.PG_MENSAJE_AVISO("Seleccione un [ARCHIVO], el item seleccionado es una [CARPETA]")
                    End If
                Catch ex As Exception
                    VP_CONTADOR = VP_CONTADOR + 1
                    Dim VP_TEXTO999 As String = Environment.NewLine + "[ERROR]   //   Archivo Ilegible, Código de Error" + ex.Message + ""
                    PG_RT_WRITE_TEXT(PP_RT_EVENTOS, VP_TEXTO999, Color.Red)

                    VP_CONTA_PRE_KO += 1
                End Try

                Application.DoEvents()
            Next
            ProgressBarPanel.PG_PROGRESSBAR_END(VP_PB_PROGRESSBAR)
        End If

        PP_LV_DIR.SelectedIndices.Clear()
        Return VP_LISTA_XML
    End Function

    Private Shared Sub PG_RT_WRITE_TEXT(ByRef PP_RT As RichTextBox, ByVal PP_TEXTO As String, ByVal PP_COLOR As Color)
        PP_RT.SelectionColor = PP_COLOR
        PP_RT.SelectedText = PP_TEXTO
    End Sub


    Public Shared Sub PG_VERIFICAR_VALORES(ByVal PP_FORMA As Object)
        Dim XML_FECHA, XML_FOLIO, XML_FORMAPAGO,
            XML_LUGAREXPEDICION, XML_METODO_PAGO,
            XML_MONEDA, XML_NOCERTIFICADO, XML_SERIE,
            XML_SUBTOTAL, XML_TIPOCAMBIO,
            XML_TIPODECOMPROBANTE, XML_TOTAL, XML_VERSION,
            XML_EMI_NOMBRE, XML_EMI_REGIMENFISCAL, XML_EMI_RFC,
            XML_REC_NOMBRE, XML_REC_RFC, XML_REC_USOCFDI,
            XML_IMPORTE, XML_TOTALIMPUESTOSTRASLADADOS,
            XML_IMPUESTO, XML_TASAOCUOTA, XML_TIPOFACTOR,
            XML_FECHATIMBRADO, XML_NOCERTIFICADOSAT, XML_UUID As String
        Dim VL_XML_FECHA_MOSTRAR As String
        Dim VL_XML_FECHATIMBRADO_MOSTRAR As String


        If PP_FORMA.LV_DIR.SelectedItems.Count <= 0 Then
            Codigo_Message.PG_MENSAJE_AVISO("Selecciona el o los [ARCHIVOS]")
        Else
            Try
                Dim registro As Integer = 0
                For Each registro In PP_FORMA.LV_DIR.SelectedIndices
                    Dim VP_XML As New XML
                    Dim PP_COUNT As Integer = PP_FORMA.LV_DIR.SelectedIndices.Count
                    Dim PP_NOMBRE As String = PP_FORMA.LV_DIR.Items(registro).Text

                    If PP_NOMBRE.ToUpper.EndsWith(".XML") Then

                        Dim RUTA As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                        Dim R As String = PP_FORMA.TV_DIR.SelectedNode.FullPath
                        Dim Rutas As String = PP_FORMA.TV_DIR.SelectedNode.Text

                        Dim VL_ARREGLO_DIR As String() = RUTA.ToString.Split("\")
                        Dim VL_UNIDAD As String = VL_ARREGLO_DIR(0)
                        Dim VL_USUARIO As String = VL_ARREGLO_DIR(1)
                        Dim VL_PERFIL As String = VL_ARREGLO_DIR(2)
                        Dim VL_DESKTOP As String = VL_ARREGLO_DIR(3)

                        Dim PP_ARCHIVO As String = (VL_UNIDAD + "\" + VL_USUARIO + "\" + VL_PERFIL + "\" + R + "\" + PP_NOMBRE)

                        Dim VP_ARCHIVO = File.ReadAllText(PP_ARCHIVO)
                        Dim VP_ARCHIVO_XML = VP_ARCHIVO.ToLower()
                        Dim xmlDocument As XmlDocument = New XmlDocument()
                        xmlDocument.LoadXml(VP_ARCHIVO_XML)

                        XML_FECHA = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "fecha", "fechaf", "")
                        XML_FOLIO = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "folio", "foliof", "")
                        XML_FORMAPAGO = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "formadepago", "formapago", "formapagof")
                        XML_LUGAREXPEDICION = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "lugarexpedicion", "", "")
                        XML_METODO_PAGO = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "metododepago", "metodopago", "")
                        XML_MONEDA = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "moneda", "", "")
                        XML_NOCERTIFICADO = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "nocertificado", "", "")
                        XML_SERIE = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "serie", "", "")
                        XML_SUBTOTAL = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "subtotal", "", "")
                        XML_TIPOCAMBIO = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "tipocambio", "", "")
                        XML_TIPODECOMPROBANTE = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "tipodecomprobante", "", "")
                        XML_TOTAL = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "total", "", "")
                        XML_VERSION = FG_XML_GET_VALOR(xmlDocument, "cfdi:comprobante", "version", "", "")
                        XML_EMI_NOMBRE = FG_XML_GET_VALOR(xmlDocument, "cfdi:emisor", "nombre", "", "")
                        XML_EMI_REGIMENFISCAL = FG_XML_GET_VALOR(xmlDocument, "cfdi:regimenfiscal", "regimen", "", "")
                        XML_EMI_RFC = FG_XML_GET_VALOR(xmlDocument, "cfdi:emisor", "rfc", "", "")
                        XML_REC_NOMBRE = FG_XML_GET_VALOR(xmlDocument, "cfdi:receptor", "nombre", "", "")
                        XML_REC_RFC = FG_XML_GET_VALOR(xmlDocument, "cfdi:receptor", "rfc", "", "")
                        XML_REC_USOCFDI = FG_XML_GET_VALOR(xmlDocument, "cfdi:receptor", "usocfdi", "", "")
                        XML_TOTALIMPUESTOSTRASLADADOS = FG_XML_GET_VALOR(xmlDocument, "cfdi:impuestos", "totalimpuestostrasladados", "", "")
                        XML_IMPORTE = FG_XML_GET_VALOR(xmlDocument, "cfdi:traslado", "importe", "", "")
                        XML_IMPUESTO = FG_XML_GET_VALOR(xmlDocument, "cfdi:traslado", "impuesto", "", "")
                        XML_TASAOCUOTA = FG_XML_GET_VALOR(xmlDocument, "cfdi:traslado", "tasa", "tasaocuota", "")
                        XML_TIPOFACTOR = FG_XML_GET_VALOR(xmlDocument, "cfdi:traslado", "tipofactor", "", "")
                        XML_FECHATIMBRADO = FG_XML_GET_VALOR(xmlDocument, "tfd:timbrefiscaldigital", "fechatimbrado", "", "")
                        XML_NOCERTIFICADOSAT = FG_XML_GET_VALOR(xmlDocument, "tfd:timbrefiscaldigital", "nocertificadosat", "", "")
                        XML_UUID = FG_XML_GET_VALOR(xmlDocument, "tfd:timbrefiscaldigital", "uuid", "", "")


                        VL_XML_FECHA_MOSTRAR = Codigo_ABC.FG_DT_CONVIERTE_FECHA_MX_A_US(XML_FECHA)
                        VL_XML_FECHATIMBRADO_MOSTRAR = Codigo_ABC.FG_DT_CONVIERTE_FECHA_MX_A_US(XML_FECHATIMBRADO)

                        If XML_TOTALIMPUESTOSTRASLADADOS = "" Then
                            XML_TOTALIMPUESTOSTRASLADADOS = 0
                        End If
                        If XML_IMPORTE = "" Then
                            XML_IMPORTE = 0
                        End If

                        PP_FORMA.TB_C_FACTURA_CXP_XML.Text = PP_NOMBRE.ToString().ToUpper()
                        PP_FORMA.TB_XML_FECHA.Text = VL_XML_FECHA_MOSTRAR.ToString().ToUpper()
                        PP_FORMA.TB_XML_FOLIO.Text = XML_FOLIO.ToString().ToUpper()
                        PP_FORMA.TB_XML_FORMAPAGO.Text = XML_FORMAPAGO.ToString().ToUpper()
                        PP_FORMA.TB_XML_LUGAREXPEDICION.Text = XML_LUGAREXPEDICION.ToString().ToUpper()
                        PP_FORMA.TB_XML_METODOPAGO.Text = XML_METODO_PAGO.ToString().ToUpper()
                        PP_FORMA.TB_XML_MONEDA.Text = XML_MONEDA.ToString().ToUpper()
                        PP_FORMA.TB_XML_NOCERTIFICADO.Text = XML_NOCERTIFICADO.ToString().ToUpper()
                        PP_FORMA.TB_XML_SERIE.Text = XML_SERIE.ToString().ToUpper()
                        PP_FORMA.TB_XML_TIPOCAMBIO.Text = XML_TIPOCAMBIO.ToString().ToUpper()
                        PP_FORMA.TB_XML_TIPODECOMPROBANTE.Text = XML_TIPODECOMPROBANTE.ToString().ToUpper()
                        PP_FORMA.TB_XML_VERSION.Text = XML_VERSION.ToString().ToUpper()
                        PP_FORMA.TB_XML_EMI_NOMBRE.Text = XML_EMI_NOMBRE.ToString().ToUpper()
                        PP_FORMA.TB_XML_EMI_REGIMENFISCAL.Text = XML_EMI_REGIMENFISCAL.ToString().ToUpper()
                        PP_FORMA.TB_XML_EMI_RFC.Text = XML_EMI_RFC.ToString().ToUpper()
                        PP_FORMA.TB_XML_REC_NOMBRE.Text = XML_REC_NOMBRE.ToString().ToUpper()
                        PP_FORMA.TB_XML_REC_RFC.Text = XML_REC_RFC.ToString().ToUpper()
                        PP_FORMA.TB_XML_REC_USOCFDI.Text = XML_REC_USOCFDI.ToString().ToUpper()
                        Codigo_CTRL.PG_TB_INIT(PP_FORMA.TB_XML_TOTALIMPUESTOSTRASLADADOS, 1)
                        Codigo_CTRL.PG_TB_INIT(PP_FORMA.TB_XML_IMPORTE, 1)
                        Codigo_CTRL.PG_TB_INIT(PP_FORMA.TB_XML_TOTAL, 1)
                        Codigo_CTRL.PG_TB_INIT(PP_FORMA.TB_XML_SUBTOTAL, 1)
                        PP_FORMA.TB_XML_TOTAL.Text = XML_TOTAL.ToString()
                        PP_FORMA.TB_XML_SUBTOTAL.Text = XML_SUBTOTAL.ToString()
                        PP_FORMA.TB_XML_TOTALIMPUESTOSTRASLADADOS.Text = XML_TOTALIMPUESTOSTRASLADADOS.ToString()
                        PP_FORMA.TB_XML_IMPORTE.Text = XML_IMPORTE.ToString()
                        PP_FORMA.TB_XML_IMPUESTO.Text = XML_IMPUESTO.ToString().ToUpper()
                        PP_FORMA.TB_XML_TASAOCUOTA.Text = XML_TASAOCUOTA.ToString().ToUpper()
                        PP_FORMA.TB_XML_TIPOFACTOR.Text = XML_TIPOFACTOR.ToString().ToUpper()
                        PP_FORMA.TB_XML_FECHATIMBRADO.Text = VL_XML_FECHATIMBRADO_MOSTRAR.ToString().ToUpper()
                        PP_FORMA.TB_XML_NOCERTIFICADOSAT.Text = XML_NOCERTIFICADOSAT.ToString().ToUpper()
                        PP_FORMA.TB_XML_UUID.Text = XML_UUID.ToString().ToUpper()

                        PP_FORMA.VM_IN_MODO_OPERACION = Modo_Operacion.Edición
                        Codigo_FRM.PG_FRM_CONFIG(PP_FORMA)
                    Else
                        Codigo_Message.PG_MENSAJE_AVISO("Seleccione un [ARCHIVO], el item seleccionado es una [CARPETA]")
                    End If
                Next
            Catch ex As Exception
                Codigo_Message.PG_MENSAJE_AVISO("[ERROR]   //   Archivo Ilegible, Código de Error: " + vbCrLf + ex.Message + vbCrLf + "Intente con otro Archivo.")
            End Try
        End If
        PP_FORMA.LV_DIR.SelectedIndices.Clear()
    End Sub


    Public Shared Function FG_XML_GET_VALOR(ByVal PP_XML_NODOS As XmlDocument, ByVal PP_TAGNAME As String,
                                            ByVal PP_DATO_1 As String, ByVal PP_DATO_2 As String, ByVal PP_DATO_3 As String) As String
        Dim VP_VALOR As String = ""
        Dim VP_NODOS_X_ETIQUETA As XmlNodeList = PP_XML_NODOS.GetElementsByTagName(PP_TAGNAME)
        Try
            Dim VP_ENUMERADOR As IEnumerator = VP_NODOS_X_ETIQUETA.GetEnumerator()
            If VP_ENUMERADOR.MoveNext() Then
                Dim VP_XML_NODO As XmlNode = CType(VP_ENUMERADOR.Current, XmlNode)
                If Not IsNothing(VP_XML_NODO.Attributes(PP_DATO_1)) Then
                    VP_VALOR = VP_XML_NODO.Attributes(PP_DATO_1).InnerXml
                ElseIf Not IsNothing(VP_XML_NODO.Attributes(PP_DATO_2)) Then
                    VP_VALOR = VP_XML_NODO.Attributes(PP_DATO_2).InnerXml
                ElseIf Not IsNothing(VP_XML_NODO.Attributes(PP_DATO_3)) Then
                    VP_VALOR = VP_XML_NODO.Attributes(PP_DATO_3).InnerXml
                End If
            End If
        Catch VP_E As Exception
            Codigo_Message.PG_MENSAJE_ERROR_VS("FG_XML_GET_VALOR")
        End Try
        Return VP_VALOR
    End Function

    'Este procedimiento es para Insertar los XML en la tabla //   AXR
    Public Shared Function FG_INSERTAR_FACTURA_XML(ByVal PP_ID_BASE_DE_DATOS As Integer, ByRef PP_FORMA As Object,
                                                   ByRef PP_XML As XML, ByRef VP_ARCHIVO As String) As String
        Dim VP_PARAMETROS As String = ""
        Dim VP_SP As String = ""
        Dim VP_TABLA As New Data.DataTable
        Dim VP_MENSAJE As String = ""
        Try
            VP_PARAMETROS = PP_FORMA.FM_SQL_DATOS_XML(PP_XML)
            VP_ARCHIVO = VP_ARCHIVO
            Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
            VP_SP = Codigo_CON.FG_SQL_INSERT(PP_FORMA)
            VP_TABLA = Codigo_CON.FG_SP_EXECUTE_DATATABLE(PP_ID_BASE_DE_DATOS, VP_SP, VP_PARAMETROS, VP_ARCHIVO)
            VP_MENSAJE = Codigo_LI.FG_LI_CELL_READ(VP_TABLA, 0, "MENSAJE")
            Dim VP_ID = Codigo_LI.FG_LI_CELL_READ(VP_TABLA, 0, "CLAVE")
            If VP_MENSAJE <> "" Then
                Dim VP_TEXTO1 As String = Environment.NewLine + "[EXISTE]   //   " + "[ARCHIVO XML]: " + PP_XML.PP_NOMBRE1.ToUpper + " //  [Serie]: " + PP_XML.XML_SERIE1.ToUpper + " //  [Folio]: " + PP_XML.XML_FOLIO1.ToUpper + " //  [ARCHIVO XML] ya existe."
                PG_RT_WRITE_TEXT(PP_FORMA.RT_EVENTOS, VP_TEXTO1, Color.OrangeRed)
            Else
                Dim VP_TEXTO2 As String = Environment.NewLine + "[ O.K ]   //   " + "[ARCHIVO XML]: " + PP_XML.PP_NOMBRE1.ToUpper + " //  [Serie]: " + PP_XML.XML_SERIE1.ToUpper + " //  [Folio]: " + PP_XML.XML_FOLIO1.ToUpper + " //  [CORRECTA] la carga del [ARCHIVO XML]"
                PG_RT_WRITE_TEXT(PP_FORMA.RT_EVENTOS, VP_TEXTO2, Color.Green)
            End If
        Catch ex As ArgumentException
            Codigo_Message.PG_MENSAJE_ERROR_VS("FG_BT_INSERTAR_FACTURA_XML_CLICK")
        End Try
        Return VP_MENSAJE

    End Function

    'Este procedimiento es para Insertar los XML en la tabla //   AXR
    Public Shared Function FG_INSERTAR_FACTURA_XML(ByVal PP_ID_BASE_DE_DATOS As Integer, ByRef PP_FORMA As Object,
                                                   ByRef PP_XML As XML, ByRef VP_ARCHIVO As String, ByRef PP_CLAVE As Integer) As String
        Dim VP_PARAMETROS As String = ""
        Dim VP_SP As String = ""
        Dim VP_TABLA As New Data.DataTable
        Dim VP_MENSAJE As String = ""
        Try
            VP_PARAMETROS = PP_FORMA.FM_SQL_DATOS_XML(PP_XML)
            VP_ARCHIVO = VP_ARCHIVO
            Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
            VP_SP = Codigo_CON.FG_SQL_INSERT(PP_FORMA)
            VP_TABLA = Codigo_CON.FG_SP_EXECUTE_DATATABLE(PP_ID_BASE_DE_DATOS, VP_SP, VP_PARAMETROS, VP_ARCHIVO)

            VP_MENSAJE = Codigo_LI.FG_LI_CELL_READ(VP_TABLA, 0, "MENSAJE")
            Dim VP_ID = Codigo_LI.FG_LI_CELL_READ(VP_TABLA, 0, "CLAVE")
            PP_CLAVE = VP_ID
            If VP_MENSAJE <> "" Then
                Dim VP_TEXTO1 As String = Environment.NewLine + "[EXISTE]   //   " + "[ARCHIVO XML]: " + PP_XML.PP_NOMBRE1.ToUpper + " //  [Serie]: " + PP_XML.XML_SERIE1.ToUpper + " //  [Folio]: " + PP_XML.XML_FOLIO1.ToUpper + " //  [ARCHIVO XML] ya existe."
                PG_RT_WRITE_TEXT(PP_FORMA.RT_EVENTOS, VP_TEXTO1, Color.OrangeRed)
            Else
                Dim VP_TEXTO2 As String = Environment.NewLine + "[ O.K ]   //   " + "[ARCHIVO XML]: " + PP_XML.PP_NOMBRE1.ToUpper + " //  [Serie]: " + PP_XML.XML_SERIE1.ToUpper + " //  [Folio]: " + PP_XML.XML_FOLIO1.ToUpper + " //  [CORRECTA] la carga del [ARCHIVO XML]"
                PG_RT_WRITE_TEXT(PP_FORMA.RT_EVENTOS, VP_TEXTO2, Color.Green)
            End If
        Catch ex As ArgumentException
            Codigo_Message.PG_MENSAJE_ERROR_VS("FG_BT_INSERTAR_FACTURA_XML_CLICK")
        End Try
        Return VP_MENSAJE
    End Function


    'Código para verificar si existe un proveedor en base al RFC_PROVEEDOR_VIATICO   //   AXR
    Public Shared Function FG_VERIFICAR_RFC_FACTURA_XML(ByRef PP_FORMA As Object, ByRef PP_EMI_RFC As String, Optional ByRef PP_REFERENCIA As Integer = 0)
        Dim VP_PARAMETROS As String = ""
        Dim VP_TABLA As Data.DataTable


        If PP_REFERENCIA <> 0 Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_EMI_RFC, True)
            Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
            Dim VP_STORED_PROCEDURE As String
            VP_STORED_PROCEDURE = "PG_SK_PROVEEDOR_VIATICO_EXISTE"

            VP_TABLA = Codigo_CON.FG_SP_EXECUTE_DATATABLE(VG_ID_DB, VP_STORED_PROCEDURE, VP_PARAMETROS)
        Else
            Dim VP_COMODIN_ENTERO As Integer = -1

            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_EMI_RFC, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_ENTERO, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_ENTERO, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_ENTERO, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_ENTERO, True)
            Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

            Dim VP_STORED_PROCEDURE As String
            VP_STORED_PROCEDURE = "PG_LI_PROVEEDOR"

            VP_TABLA = Codigo_CON.FG_SP_EXECUTE_DATATABLE(VG_ID_DB, VP_STORED_PROCEDURE, VP_PARAMETROS)
        End If
        Return VP_TABLA
    End Function


    'Código para realizar un INSERT de PROVEEDOR_VIATICO con ESTATUS de PREREGISTRO  //   AXR
    Public Shared Function FG_PREREGISTRO_PROVEEDOR(ByRef PP_FORMA As Object, ByRef PP_EMI_RFC As String, ByRef PP_NOMBRE As String, Optional ByRef PP_REFERENCIA As Integer = 0)
        Dim VP_PARAMETROS As String = ""
        Dim VP_TABLA As Data.DataTable

        If PP_REFERENCIA <> 0 Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_NOMBRE.ToUpper, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_EMI_RFC.ToUpper, True)

            Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

            Dim VP_STORED_PROCEDURE As String
            VP_STORED_PROCEDURE = "PG_IN_PROVEEDOR_VIATICO_PREREGISTRO"

            VP_TABLA = Codigo_CON.FG_SP_EXECUTE_DATATABLE(VG_ID_DB, VP_STORED_PROCEDURE, VP_PARAMETROS)

        Else
            Dim VP_COMODIN_CHAR As String = ""
            Dim VP_COMODIN_INTEGER As Integer = 0
            Dim VP_COMODIN_ESTATUS As Integer = 1
            Dim VP_COMODIN_CATEGORIA As Integer = 0
            Dim VP_DIAS_C As Integer = 30

            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_NOMBRE.ToUpper, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_NOMBRE.ToUpper, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_EMI_RFC.ToUpper, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_DIAS_C, False)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_INTEGER, False)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_INTEGER, False)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_ESTATUS, False)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CATEGORIA, False)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_CHAR, True)

            Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

            Dim VP_STORED_PROCEDURE As String
            VP_STORED_PROCEDURE = "PG_IN_PROVEEDOR"

            VP_TABLA = Codigo_CON.FG_SP_EXECUTE_DATATABLE(VG_ID_DB, VP_STORED_PROCEDURE, VP_PARAMETROS)
        End If
        Return VP_TABLA
    End Function

End Class


Public Class XML_V2
    Private XML_FECHA, XML_FOLIO, XML_FORMAPAGO,
XML_LUGAREXPEDICION, XML_METODO_PAGO,
XML_MONEDA, XML_NOCERTIFICADO, XML_SERIE,
XML_SUBTOTAL, XML_TIPOCAMBIO,
XML_TIPODECOMPROBANTE, XML_TOTAL, XML_VERSION,
XML_EMI_NOMBRE, XML_EMI_REGIMENFISCAL, XML_EMI_RFC,
XML_REC_NOMBRE, XML_REC_RFC, XML_REC_USOCFDI,
XML_IMPORTE, XML_TOTALIMPUESTOSTRASLADADOS,
XML_IMPUESTO, XML_TASAOCUOTA, XML_TIPOFACTOR,
XML_FECHATIMBRADO, XML_NOCERTIFICADOSAT, XML_UUID As String
    Private PP_NOMBRE As String
    Private VL_XML_FECHA_MOSTRAR As String
    Private VL_XML_FECHATIMBRADO_MOSTRAR As String

    Public Property XML_FECHA1 As String
        Get
            Return XML_FECHA
        End Get
        Set(value As String)
            XML_FECHA = value
        End Set
    End Property

    Public Property XML_FOLIO1 As String
        Get
            Return XML_FOLIO
        End Get
        Set(value As String)
            XML_FOLIO = value
        End Set
    End Property

    Public Property XML_FORMAPAGO1 As String
        Get
            Return XML_FORMAPAGO
        End Get
        Set(value As String)
            XML_FORMAPAGO = value
        End Set
    End Property

    Public Property XML_LUGAREXPEDICION1 As String
        Get
            Return XML_LUGAREXPEDICION
        End Get
        Set(value As String)
            XML_LUGAREXPEDICION = value
        End Set
    End Property

    Public Property XML_METODO_PAGO1 As String
        Get
            Return XML_METODO_PAGO
        End Get
        Set(value As String)
            XML_METODO_PAGO = value
        End Set
    End Property

    Public Property XML_MONEDA1 As String
        Get
            Return XML_MONEDA
        End Get
        Set(value As String)
            XML_MONEDA = value
        End Set
    End Property

    Public Property XML_NOCERTIFICADO1 As String
        Get
            Return XML_NOCERTIFICADO
        End Get
        Set(value As String)
            XML_NOCERTIFICADO = value
        End Set
    End Property

    Public Property XML_SERIE1 As String
        Get
            Return XML_SERIE
        End Get
        Set(value As String)
            XML_SERIE = value
        End Set
    End Property

    Public Property XML_SUBTOTAL1 As String
        Get
            Return XML_SUBTOTAL
        End Get
        Set(value As String)
            XML_SUBTOTAL = value
        End Set
    End Property

    Public Property XML_TIPOCAMBIO1 As String
        Get
            Return XML_TIPOCAMBIO
        End Get
        Set(value As String)
            XML_TIPOCAMBIO = value
        End Set
    End Property

    Public Property XML_TIPODECOMPROBANTE1 As String
        Get
            Return XML_TIPODECOMPROBANTE
        End Get
        Set(value As String)
            XML_TIPODECOMPROBANTE = value
        End Set
    End Property

    Public Property XML_TOTAL1 As String
        Get
            Return XML_TOTAL
        End Get
        Set(value As String)
            XML_TOTAL = value
        End Set
    End Property

    Public Property XML_VERSION1 As String
        Get
            Return XML_VERSION
        End Get
        Set(value As String)
            XML_VERSION = value
        End Set
    End Property

    Public Property XML_EMI_NOMBRE1 As String
        Get
            Return XML_EMI_NOMBRE
        End Get
        Set(value As String)
            XML_EMI_NOMBRE = value
        End Set
    End Property

    Public Property XML_EMI_REGIMENFISCAL1 As String
        Get
            Return XML_EMI_REGIMENFISCAL
        End Get
        Set(value As String)
            XML_EMI_REGIMENFISCAL = value
        End Set
    End Property

    Public Property XML_EMI_RFC1 As String
        Get
            Return XML_EMI_RFC
        End Get
        Set(value As String)
            XML_EMI_RFC = value
        End Set
    End Property

    Public Property XML_REC_NOMBRE1 As String
        Get
            Return XML_REC_NOMBRE
        End Get
        Set(value As String)
            XML_REC_NOMBRE = value
        End Set
    End Property

    Public Property XML_REC_RFC1 As String
        Get
            Return XML_REC_RFC
        End Get
        Set(value As String)
            XML_REC_RFC = value
        End Set
    End Property

    Public Property XML_REC_USOCFDI1 As String
        Get
            Return XML_REC_USOCFDI
        End Get
        Set(value As String)
            XML_REC_USOCFDI = value
        End Set
    End Property

    Public Property XML_IMPORTE1 As String
        Get
            Return XML_IMPORTE
        End Get
        Set(value As String)
            XML_IMPORTE = value
        End Set
    End Property

    Public Property XML_TOTALIMPUESTOSTRASLADADOS1 As String
        Get
            Return XML_TOTALIMPUESTOSTRASLADADOS
        End Get
        Set(value As String)
            XML_TOTALIMPUESTOSTRASLADADOS = value
        End Set
    End Property

    Public Property XML_IMPUESTO1 As String
        Get
            Return XML_IMPUESTO
        End Get
        Set(value As String)
            XML_IMPUESTO = value
        End Set
    End Property

    Public Property XML_TASAOCUOTA1 As String
        Get
            Return XML_TASAOCUOTA
        End Get
        Set(value As String)
            XML_TASAOCUOTA = value
        End Set
    End Property

    Public Property XML_TIPOFACTOR1 As String
        Get
            Return XML_TIPOFACTOR
        End Get
        Set(value As String)
            XML_TIPOFACTOR = value
        End Set
    End Property

    Public Property XML_FECHATIMBRADO1 As String
        Get
            Return XML_FECHATIMBRADO
        End Get
        Set(value As String)
            XML_FECHATIMBRADO = value
        End Set
    End Property

    Public Property XML_NOCERTIFICADOSAT1 As String
        Get
            Return XML_NOCERTIFICADOSAT
        End Get
        Set(value As String)
            XML_NOCERTIFICADOSAT = value
        End Set
    End Property

    Public Property XML_UUID1 As String
        Get
            Return XML_UUID
        End Get
        Set(value As String)
            XML_UUID = value
        End Set
    End Property

    Public Property PP_NOMBRE1 As String
        Get
            Return PP_NOMBRE
        End Get
        Set(value As String)
            PP_NOMBRE = value
        End Set
    End Property

    Public Property VL_XML_FECHA_MOSTRAR1 As String
        Get
            Return VL_XML_FECHA_MOSTRAR
        End Get
        Set(value As String)
            VL_XML_FECHA_MOSTRAR = value
        End Set
    End Property

    Public Property VL_XML_FECHATIMBRADO_MOSTRAR1 As String
        Get
            Return VL_XML_FECHATIMBRADO_MOSTRAR
        End Get
        Set(value As String)
            VL_XML_FECHATIMBRADO_MOSTRAR = value
        End Set
    End Property

End Class