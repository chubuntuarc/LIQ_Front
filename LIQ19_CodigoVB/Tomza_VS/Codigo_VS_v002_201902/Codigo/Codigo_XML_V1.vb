Imports System.IO
Imports System.Xml
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Public Class Codigo_XML_V1

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

    Public Shared Function PG_OBTENER_ATRIBUTOS(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object) As List(Of XML)
        Dim VP_LISTA_XML As New List(Of XML)
        Dim VP_CONTA_OK As Integer = 0
        Dim VP_CONTA_KO As Integer = 0
        Dim VP_CONTA_EXISTENTE As Integer = 0
        Dim VP_CONTA_PRE As Integer = 0
        Dim VP_CONTA_PRE_KO As Integer = 0
        Dim VP_CONTA_PRE_OK As Integer = 0
        Dim VP_CONTA_PRO_KO As Integer = 0

        If PP_FORMA.LV_DIR.SelectedItems.Count <= 0 Then
            Codigo_Mensaje.PG_MENSAJE_AVISO("Selecciona el o los [ARCHIVOS]")
        Else
            Dim registro As ListViewItem
            Dim VP_PB_PROGRESSBAR As BARRA_DE_PROGRESO_PANEL
            Dim VP_COUNT = PP_FORMA.LV_DIR.SelectedItems.Count
            VP_PB_PROGRESSBAR = ProgressBarPanel.FG_PROGRESSBAR_INIT(PP_FORMA, 0, VP_COUNT, "Carga de Archivos", Color.DarkOrange)
            ' PP_FORMA.PB_ESTATUS_CARGA.Maximum = PP_FORMA.LV_DIR.SelectedItems.Count
            Dim VP_CONTADOR As Integer = 0
            Dim VP_INICIO As New DateTime
            VP_INICIO = DateTime.Now

            For Each registro In PP_FORMA.LV_DIR.SelectedItems
                VP_CONTADOR = VP_CONTADOR + 1
                ProgressBarPanel.PG_PROGRESSBAR_INCREMENT(VP_PB_PROGRESSBAR, VP_CONTADOR)
                Dim VP_CLAVE As Integer = 0
                Dim VP_XML As New XML
                Try
                    VP_XML.PP_NOMBRE1 = registro.Text
                    If VP_XML.PP_NOMBRE1.ToUpper.EndsWith(".XML") Then
                        Dim RUTA As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                        Dim R As String = PP_FORMA.TV_DIR.SelectedNode.FullPath
                        Dim Rutas As String = PP_FORMA.TV_DIR.SelectedNode.Text
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

                        VP_XML.XML_FECHA1 = PG_getDatoXmlCFDi("fechaf", xmlDocument)
                        VP_XML.XML_FOLIO1 = PG_getDatoXmlCFDi("foliof", xmlDocument)
                        VP_XML.XML_FORMAPAGO1 = PG_getDatoXmlCFDi("formapagof", xmlDocument)
                        VP_XML.XML_LUGAREXPEDICION1 = PG_getDatoXmlCFDi("lugarexpedicionf", xmlDocument)
                        VP_XML.XML_METODO_PAGO1 = PG_getDatoXmlCFDi("metodopagof", xmlDocument)
                        VP_XML.XML_MONEDA1 = PG_getDatoXmlCFDi("monedaf", xmlDocument)
                        VP_XML.XML_NOCERTIFICADO1 = PG_getDatoXmlCFDi("ncertificado", xmlDocument)
                        VP_XML.XML_SERIE1 = PG_getDatoXmlCFDi("serief", xmlDocument)
                        VP_XML.XML_SUBTOTAL1 = PG_getDatoXmlCFDi("subtotalf", xmlDocument)
                        VP_XML.XML_TIPOCAMBIO1 = PG_getDatoXmlCFDi("tipocambiof", xmlDocument)
                        VP_XML.XML_TIPODECOMPROBANTE1 = PG_getDatoXmlCFDi("tipocfd", xmlDocument)
                        VP_XML.XML_TOTAL1 = PG_getDatoXmlCFDi("totalf", xmlDocument)
                        VP_XML.XML_VERSION1 = PG_getDatoXmlCFDi("version_cfdi", xmlDocument)
                        VP_XML.XML_EMI_NOMBRE1 = PG_getDatoXmlCFDi("razone", xmlDocument)
                        VP_XML.XML_EMI_REGIMENFISCAL1 = PG_getDatoXmlCFDi("regimenfiscale", xmlDocument)
                        VP_XML.XML_EMI_RFC1 = PG_getDatoXmlCFDi("rfce", xmlDocument)
                        VP_XML.XML_REC_NOMBRE1 = PG_getDatoXmlCFDi("razonr", xmlDocument)
                        VP_XML.XML_REC_RFC1 = PG_getDatoXmlCFDi("rfcr", xmlDocument)
                        VP_XML.XML_REC_USOCFDI1 = PG_getDatoXmlCFDi("usocfdi", xmlDocument)
                        VP_XML.XML_TOTALIMPUESTOSTRASLADADOS1 = PG_getDatoXmlCFDi("totalimpuestostrasladados", xmlDocument)
                        VP_XML.XML_IMPORTE1 = PG_getDatoXmlCFDi("importe_traslado", xmlDocument)
                        VP_XML.XML_IMPUESTO1 = PG_getDatoXmlCFDi("impuesto_traslado", xmlDocument)
                        VP_XML.XML_TASAOCUOTA1 = PG_getDatoXmlCFDi("tasaiva_traslado", xmlDocument)
                        VP_XML.XML_TIPOFACTOR1 = PG_getDatoXmlCFDi("tipo_factor", xmlDocument)
                        VP_XML.XML_FECHATIMBRADO1 = PG_getDatoXmlCFDi("fechatimbrado", xmlDocument)
                        VP_XML.XML_NOCERTIFICADOSAT1 = PG_getDatoXmlCFDi("nocertificadosat", xmlDocument)
                        VP_XML.XML_UUID1 = PG_getDatoXmlCFDi("uuid", xmlDocument)

                        VP_XML.VL_XML_FECHA_MOSTRAR1 = Codigo_ABC.FG_DT_CONVIERTE_FECHA_XML_A_SQL(VP_XML.XML_FECHA1)  'VP_XML.XML_FECHA1 '
                        VP_XML.VL_XML_FECHATIMBRADO_MOSTRAR1 = Codigo_ABC.FG_DT_CONVIERTE_FECHA_XML_A_SQL(VP_XML.XML_FECHATIMBRADO1)

                        If VP_XML.XML_TOTALIMPUESTOSTRASLADADOS1 = "" Then
                            VP_XML.XML_TOTALIMPUESTOSTRASLADADOS1 = 0
                        End If
                        If VP_XML.XML_IMPORTE1 = "" Then
                            VP_XML.XML_IMPORTE1 = 0
                        End If

                        Dim VP_TABLA As Data.DataTable
                        VP_TABLA = FG_VERIFICAR_RFC_FACTURA_XML(PP_FORMA, VP_XML.XML_EMI_RFC1)

                        If VP_TABLA.Rows.Count = 0 Then
                            Dim VP_TEXTO3 As String = vbCrLf + "[ PRE ]   //   " + "[PROVEEDOR], [RFC]: " + VP_XML.XML_EMI_RFC1.ToUpper + " //  , [RAZON SOCIAL]: " + VP_XML.XML_EMI_NOMBRE1.ToUpper + " no existe. Se hará un [PREREGISTRO]"
                            PP_FORMA.RT_EVENTOS.SelectionColor = Color.YellowGreen
                            PP_FORMA.RT_EVENTOS.SelectedText = VP_TEXTO3

                            VP_CONTA_PRE += 1

                            Dim VP_TABLAP As Data.DataTable
                            VP_TABLAP = FG_PREREGISTRO_PROVEEDOR(PP_FORMA, VP_XML.XML_EMI_RFC1, VP_XML.XML_EMI_NOMBRE1)

                            If VP_TABLAP.Rows.Count = 0 Then
                                Dim VP_TEXTO4 As String = vbCrLf + "[ERROR]   //   " + "[PROVEEDOR], [RFC]: " + VP_XML.XML_EMI_RFC1.ToUpper + " //  , [RAZON SOCIAL]: " + VP_XML.XML_EMI_NOMBRE1.ToUpper + " //  [PROBLEMA] al realizar el [PREREGISTRO] del [PROVEEDOR]"
                                PP_FORMA.RT_EVENTOS.SelectionColor = Color.Red
                                PP_FORMA.RT_EVENTOS.SelectedText = VP_TEXTO4
                                VP_CONTA_PRE_KO += 1
                            Else
                                Dim VP_TEXTO5 As String = vbCrLf + "[ O.K ]   //   " + "[PROVEEDOR], [RFC]: " + VP_XML.XML_EMI_RFC1.ToUpper + " //  , [RAZON SOCIAL]: " + VP_XML.XML_EMI_NOMBRE1.ToUpper + " //  [CORRECTA] la carga del [PREREGISTRO] del [PROVEEDOR]"
                                PP_FORMA.RT_EVENTOS.SelectionColor = Color.Green
                                PP_FORMA.RT_EVENTOS.SelectedText = VP_TEXTO5
                                VP_CONTA_PRE_OK += 1

                                Dim VP_MENSAJE As String = ""

                                VP_MENSAJE = FG_INSERTAR_FACTURA_XML(PP_BD_Index, PP_FORMA, VP_XML, VP_ARCHIVO, VP_CLAVE)
                                If VP_MENSAJE = "" Then
                                    VP_CONTA_OK += 1

                                Else
                                    VP_CONTA_EXISTENTE += 1
                                End If
                            End If
                        Else
                            Dim VP_ESTATUS As String = ""
                            VP_ESTATUS = Codigo_LI.FG_LI_CELL_READ(VP_TABLA, 0, "K_ESTATUS_PROVEEDOR")

                            If VP_ESTATUS = 3 Then
                                Dim VP_TEXTO6 As String = vbCrLf + "[ERROR]   //   " + "[PROVEEDOR], [RFC]: " + VP_XML.XML_EMI_RFC1.ToUpper + " //  , [RAZON SOCIAL]: " + VP_XML.XML_EMI_NOMBRE1.ToUpper + " //  [PROBLEMA] con el [PROVEEDOR], se encuentra [SUSPENDIDO]"
                                PP_FORMA.RT_EVENTOS.SelectionColor = Color.YellowGreen
                                PP_FORMA.RT_EVENTOS.SelectedText = VP_TEXTO6
                                VP_CONTA_PRO_KO += 1
                            ElseIf VP_ESTATUS = 4 Then
                                Dim VP_TEXTO7 As String = vbCrLf + "[ERROR]   //   " + "[PROVEEDOR], [RFC]: " + VP_XML.XML_EMI_RFC1.ToUpper + " //  , [RAZON SOCIAL]: " + VP_XML.XML_EMI_NOMBRE1.ToUpper + " //  [PROBLEMA] con el [PROVEEDOR], fue dado de [BAJA]"
                                PP_FORMA.RT_EVENTOS.SelectionColor = Color.YellowGreen
                                PP_FORMA.RT_EVENTOS.SelectedText = VP_TEXTO7
                                VP_CONTA_PRO_KO += 1
                            Else
                                Dim VP_MENSAJE As String = ""
                                VP_MENSAJE = FG_INSERTAR_FACTURA_XML(PP_BD_Index, PP_FORMA, VP_XML, VP_ARCHIVO, VP_CLAVE)
                                If VP_MENSAJE = "" Then
                                    VP_CONTA_OK += 1
                                Else
                                    VP_CONTA_EXISTENTE += 1
                                End If
                            End If
                        End If
                        '----------------------------------------------------
                        Dim vOrigen As String = PP_ARCHIVO
                        Dim VP_ORIGEN_PDF As String = PP_ARCHIVO.Substring(0, PP_ARCHIVO.Length - 3)
                        VP_ORIGEN_PDF = VP_ORIGEN_PDF + "pdf"

                        Dim vDestino As String = "\\10.0.5.34\cfdi_docs\" + VP_CLAVE.ToString() + ".pdf"


                        'My.Computer.FileSystem.CopyFile(
                        '   vOrigen,
                        '    vDestino,
                        'Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                        'Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
                        Try
                            System.IO.File.Copy(VP_ORIGEN_PDF, vDestino, True)
                        Catch ex As Exception

                        End Try


                        '-----------------------------------------------------
                        If VP_CONTADOR <= VP_COUNT Then
                            PP_FORMA.RT_EVENTOS.SelectionStart = Len(PP_FORMA.RT_EVENTOS.Text)
                            PP_FORMA.RT_EVENTOS.ScrollToCaret()
                            PP_FORMA.RT_EVENTOS.Select
                            If VP_CONTADOR = VP_COUNT Then
                                Select Case VP_COUNT
                                    Case 1
                                        PP_FORMA.LB_PROCESADOS.Text = "Se Procesó: " + VP_COUNT.ToString + " Archivo"
                                    Case Else
                                        PP_FORMA.LB_PROCESADOS.Text = "Se Procesaron: " + VP_COUNT.ToString + " Archivos"
                                End Select

                                Select Case VP_CONTA_OK
                                    Case 0
                                        PP_FORMA.LB_OK.Text = ""
                                    Case 1
                                        PP_FORMA.LB_OK.Text = " // " + VP_CONTA_OK.ToString + " [Archivo Procesado Correctamente]"
                                    Case Else
                                        PP_FORMA.LB_OK.Text = " // " + VP_CONTA_OK.ToString + " [Archivos Procesados Correctamente]"
                                End Select
                                Select Case VP_CONTA_EXISTENTE
                                    Case 0
                                        PP_FORMA.LB_EXISTENTE.Text = ""
                                    Case 1
                                        PP_FORMA.LB_EXISTENTE.Text = " // " + VP_CONTA_EXISTENTE.ToString + " [Archivo Existente]"
                                    Case Else
                                        PP_FORMA.LB_EXISTENTE.Text = " // " + VP_CONTA_EXISTENTE.ToString + " [Archivos Existentes]"
                                End Select
                                Select Case VP_CONTA_PRE
                                    Case 0
                                        PP_FORMA.LB_PRE.Text = ""
                                    Case 1
                                        PP_FORMA.LB_PRE.Text = " // " + VP_CONTA_PRE.ToString + " [Archivo de Preregistro]"
                                    Case Else
                                        PP_FORMA.LB_PRE.Text = " // " + VP_CONTA_PRE.ToString + " [Archivos de Preregistro]"
                                End Select
                                Select Case VP_CONTA_PRE_OK
                                    Case 0
                                        PP_FORMA.LB_PRE_OK.Text = ""
                                    Case 1
                                        PP_FORMA.LB_PRE_OK.Text = " // " + VP_CONTA_PRE_OK.ToString + " [Preregistro Correcto]"
                                    Case Else
                                        PP_FORMA.LB_PRE_OK.Text = " // " + VP_CONTA_PRE_OK.ToString + " [Preregistros Correctos]"
                                End Select
                                Select Case VP_CONTA_PRE_KO
                                    Case 0
                                        PP_FORMA.LB_PRE_KO.Text = ""
                                    Case 1
                                        PP_FORMA.LB_PRE_KO.Text = " // " + VP_CONTA_PRE_KO.ToString + " [Preregistro con Error]"
                                    Case Else
                                        PP_FORMA.LB_PRE_KO.Text = " // " + VP_CONTA_PRE_KO.ToString + " [Preregistros con Errores]"
                                End Select
                                Select Case VP_CONTA_PRO_KO
                                    Case 0
                                        PP_FORMA.LB_PRO_KO.Text = ""
                                    Case 1
                                        PP_FORMA.LB_PRO_KO.Text = " // " + VP_CONTA_PRO_KO.ToString + " [Proveedor Suspendido/Baja]"
                                    Case Else
                                        PP_FORMA.LB_PRO_KO.Text = " // " + VP_CONTA_PRO_KO.ToString + " [Proveedores Suspendidos/Bajas]"
                                End Select

                                Codigo_Mensaje.PG_MENSAJE_AVISO("[CARGA] de archivos [XML] finalizada")
                                Dim VP_FINAL As New DateTime
                                VP_FINAL = DateTime.Now
                                Dim VP_TIEMPO_TOTAL As TimeSpan = VP_FINAL - VP_INICIO

                                Dim VP_TEXTO_R As String = Environment.NewLine + Environment.NewLine + "Proceso finalizado, se procesaron " + VP_COUNT.ToString() + " archivos XML en " + VP_TIEMPO_TOTAL.TotalSeconds.ToString() + " segundos."
                                PP_FORMA.RT_EVENTOS.SelectionColor = Color.Blue
                                PP_FORMA.RT_EVENTOS.SelectedText = VP_TEXTO_R
                                PP_FORMA.RT_EVENTOS.SelectionStart = Len(PP_FORMA.RT_EVENTOS.Text)
                                PP_FORMA.RT_EVENTOS.ScrollToCaret()
                                PP_FORMA.RT_EVENTOS.Select

                            End If
                        End If

                    Else
                        Codigo_Mensaje.PG_MENSAJE_AVISO("Seleccione un [ARCHIVO], el item seleccionado es una [CARPETA]")
                    End If
                Catch ex As Exception
                    VP_CONTADOR = VP_CONTADOR + 1
                    Dim VP_TEXTO999 As String = Environment.NewLine + "[ERROR]   //   Archivo Ilegible, Código de Error" + ex.Message + ""
                    PP_FORMA.RT_EVENTOS.SelectionColor = Color.Red
                    PP_FORMA.RT_EVENTOS.SelectedText = VP_TEXTO999
                    VP_CONTA_PRE_KO += 1
                End Try

                Application.DoEvents()
            Next
            ProgressBarPanel.PG_PROGRESSBAR_END(VP_PB_PROGRESSBAR)
        End If

        PP_FORMA.LV_DIR.SelectedIndices.Clear()
        Return VP_LISTA_XML
    End Function

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
            Codigo_Mensaje.PG_MENSAJE_AVISO("Selecciona el o los [ARCHIVOS]")
        Else

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

                    XML_FECHA = PG_getDatoXmlCFDi("fechaf", xmlDocument)
                    XML_FOLIO = PG_getDatoXmlCFDi("foliof", xmlDocument)
                    XML_FORMAPAGO = PG_getDatoXmlCFDi("formapagof", xmlDocument)
                    XML_LUGAREXPEDICION = PG_getDatoXmlCFDi("lugarexpedicionf", xmlDocument)
                    XML_METODO_PAGO = PG_getDatoXmlCFDi("metodopagof", xmlDocument)
                    XML_MONEDA = PG_getDatoXmlCFDi("monedaf", xmlDocument)
                    XML_NOCERTIFICADO = PG_getDatoXmlCFDi("ncertificado", xmlDocument)
                    XML_SERIE = PG_getDatoXmlCFDi("serief", xmlDocument)
                    XML_SUBTOTAL = PG_getDatoXmlCFDi("subtotalf", xmlDocument)
                    XML_TIPOCAMBIO = PG_getDatoXmlCFDi("tipocambiof", xmlDocument)
                    XML_TIPODECOMPROBANTE = PG_getDatoXmlCFDi("tipocfd", xmlDocument)
                    XML_TOTAL = PG_getDatoXmlCFDi("totalf", xmlDocument)
                    XML_VERSION = PG_getDatoXmlCFDi("version_cfdi", xmlDocument)
                    XML_EMI_NOMBRE = PG_getDatoXmlCFDi("razone", xmlDocument)
                    XML_EMI_REGIMENFISCAL = PG_getDatoXmlCFDi("regimenfiscale", xmlDocument)
                    XML_EMI_RFC = PG_getDatoXmlCFDi("rfce", xmlDocument)
                    XML_REC_NOMBRE = PG_getDatoXmlCFDi("razonr", xmlDocument)
                    XML_REC_RFC = PG_getDatoXmlCFDi("rfcr", xmlDocument)
                    XML_REC_USOCFDI = PG_getDatoXmlCFDi("usocfdi", xmlDocument)
                    XML_TOTALIMPUESTOSTRASLADADOS = PG_getDatoXmlCFDi("totalimpuestostrasladados", xmlDocument)
                    XML_IMPORTE = PG_getDatoXmlCFDi("importe_traslado", xmlDocument)
                    XML_IMPUESTO = PG_getDatoXmlCFDi("impuesto_traslado", xmlDocument)
                    XML_TASAOCUOTA = PG_getDatoXmlCFDi("tasaiva_traslado", xmlDocument)
                    XML_TIPOFACTOR = PG_getDatoXmlCFDi("tipo_factor", xmlDocument)
                    XML_FECHATIMBRADO = PG_getDatoXmlCFDi("fechatimbrado", xmlDocument)
                    XML_NOCERTIFICADOSAT = PG_getDatoXmlCFDi("nocertificadosat", xmlDocument)
                    XML_UUID = PG_getDatoXmlCFDi("uuid", xmlDocument)

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
                    PP_FORMA.TB_XML_SUBTOTAL.Text = XML_SUBTOTAL.ToString()
                    PP_FORMA.TB_XML_TIPOCAMBIO.Text = XML_TIPOCAMBIO.ToString().ToUpper()
                    PP_FORMA.TB_XML_TIPODECOMPROBANTE.Text = XML_TIPODECOMPROBANTE.ToString().ToUpper()
                    PP_FORMA.TB_XML_TOTAL.Text = XML_TOTAL.ToString()
                    PP_FORMA.TB_XML_VERSION.Text = XML_VERSION.ToString().ToUpper()
                    PP_FORMA.TB_XML_EMI_NOMBRE.Text = XML_EMI_NOMBRE.ToString().ToUpper()
                    PP_FORMA.TB_XML_EMI_REGIMENFISCAL.Text = XML_EMI_REGIMENFISCAL.ToString().ToUpper()
                    PP_FORMA.TB_XML_EMI_RFC.Text = XML_EMI_RFC.ToString().ToUpper()
                    PP_FORMA.TB_XML_REC_NOMBRE.Text = XML_REC_NOMBRE.ToString().ToUpper()
                    PP_FORMA.TB_XML_REC_RFC.Text = XML_REC_RFC.ToString().ToUpper()
                    PP_FORMA.TB_XML_REC_USOCFDI.Text = XML_REC_USOCFDI.ToString().ToUpper()
                    PP_FORMA.TB_XML_TOTALIMPUESTOSTRASLADADOS.Text = XML_TOTALIMPUESTOSTRASLADADOS.ToString()
                    PP_FORMA.TB_XML_IMPORTE.Text = XML_IMPORTE.ToString()
                    PP_FORMA.TB_XML_IMPUESTO.Text = XML_IMPUESTO.ToString().ToUpper()
                    PP_FORMA.TB_XML_TASAOCUOTA.Text = XML_TASAOCUOTA.ToString().ToUpper()
                    PP_FORMA.TB_XML_TIPOFACTOR.Text = XML_TIPOFACTOR.ToString().ToUpper()
                    PP_FORMA.TB_XML_FECHATIMBRADO.Text = VL_XML_FECHATIMBRADO_MOSTRAR.ToString().ToUpper()
                    PP_FORMA.TB_XML_NOCERTIFICADOSAT.Text = XML_NOCERTIFICADOSAT.ToString().ToUpper()
                    PP_FORMA.TB_XML_UUID.Text = XML_UUID.ToString().ToUpper()

                    PP_FORMA.VM_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP3_Edicion
                    Codigo_FRM.PG_FRM_CONFIG(PP_FORMA)
                Else
                    Codigo_Mensaje.PG_MENSAJE_AVISO("Seleccione un [ARCHIVO], el item seleccionado es una [CARPETA]")
                End If
            Next
        End If
        PP_FORMA.LV_DIR.SelectedIndices.Clear()
    End Sub


    Public Shared Function PG_getDatoXmlCFDi(ByVal dato As String, ByVal xmlDoc As XmlDocument) As String
        Dim text As String = ""
        Dim flag As Boolean = Operators.CompareString(dato, "cadena", False) = 0
        If flag Then
            Dim elementsByTagName As XmlNodeList = xmlDoc.GetElementsByTagName("tfd:TimbreFiscalDigital")
            Try
                Dim enumerator As IEnumerator = elementsByTagName.GetEnumerator()
                While enumerator.MoveNext()
                    Dim xmlNode As XmlNode = CType(enumerator.Current, XmlNode)
                    text = "||" + xmlNode.Attributes("version").InnerXml
                    Console.Write("version: " + xmlNode.Attributes("version").InnerXml + vbCrLf)
                    text = text + "|" + xmlNode.Attributes("uuid").InnerXml
                    Console.Write("UUID: " + xmlNode.Attributes("uuid").InnerXml + vbCrLf)
                    text = text + "|" + xmlNode.Attributes("fechatimbrado").InnerXml
                    Console.Write("fechatimbrado: " + xmlNode.Attributes("fechatimbrado").InnerXml + vbCrLf)
                    text = text + "|" + xmlNode.Attributes("sellocfd").InnerXml
                    Console.Write("SelloCFD: " + xmlNode.Attributes("sellocfd").InnerXml + vbCrLf)
                    text = text + "|" + xmlNode.Attributes("nocertificadosat").InnerXml
                    Console.Write("NoCertificadoSAT: " + xmlNode.Attributes("nocertificadosat").InnerXml + vbCrLf)
                    text += "||"
                    Console.WriteLine("Cadena Completa: " + text)
                End While
            Finally
                Dim enumerator As IEnumerator
                flag = (TypeOf enumerator Is IDisposable)
                If flag Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        Else
            flag = (Operators.CompareString(dato, "certificado", False) = 0)
            If flag Then
                Dim elementsByTagName2 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:comprobante")
                Try
                    Dim enumerator2 As IEnumerator = elementsByTagName2.GetEnumerator()
                    If enumerator2.MoveNext() Then
                        Dim xmlNode2 As XmlNode = CType(enumerator2.Current, XmlNode)
                        text = xmlNode2.Attributes("certificado").InnerXml
                    End If
                Finally
                    Dim enumerator2 As IEnumerator
                    flag = (TypeOf enumerator2 Is IDisposable)
                    If flag Then
                        TryCast(enumerator2, IDisposable).Dispose()
                    End If
                End Try
            Else
                flag = (Operators.CompareString(dato, "ncertificado", False) = 0)
                If flag Then
                    Dim elementsByTagName3 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:comprobante")
                    Try
                        Dim enumerator3 As IEnumerator = elementsByTagName3.GetEnumerator()
                        If enumerator3.MoveNext() Then
                            Dim xmlNode3 As XmlNode = CType(enumerator3.Current, XmlNode)
                            text = xmlNode3.Attributes("nocertificado").InnerXml
                        End If
                    Finally
                        Dim enumerator3 As IEnumerator
                        flag = (TypeOf enumerator3 Is IDisposable)
                        If flag Then
                            TryCast(enumerator3, IDisposable).Dispose()
                        End If
                    End Try
                Else
                    flag = (Operators.CompareString(dato, "docrelacionado", False) = 0)
                    If flag Then
                        Dim elementsByTagName4 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:cfdirelacionado")
                        Try
                            Dim enumerator4 As IEnumerator = elementsByTagName4.GetEnumerator()
                            If enumerator4.MoveNext() Then
                                Dim xmlNode4 As XmlNode = CType(enumerator4.Current, XmlNode)
                                text = xmlNode4.Attributes("uuid").InnerXml
                            End If
                        Finally
                            Dim enumerator4 As IEnumerator
                            flag = (TypeOf enumerator4 Is IDisposable)
                            If flag Then
                                TryCast(enumerator4, IDisposable).Dispose()
                            End If
                        End Try
                    Else
                        flag = (Operators.CompareString(dato, "tiporelacion", False) = 0)
                        If flag Then
                            Dim elementsByTagName5 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:cfdirelacionados")
                            Try
                                Dim enumerator5 As IEnumerator = elementsByTagName5.GetEnumerator()
                                If enumerator5.MoveNext() Then
                                    Dim xmlNode5 As XmlNode = CType(enumerator5.Current, XmlNode)
                                    text = xmlNode5.Attributes("tiporelacion").InnerXml
                                End If
                            Finally
                                Dim enumerator5 As IEnumerator
                                flag = (TypeOf enumerator5 Is IDisposable)
                                If flag Then
                                    TryCast(enumerator5, IDisposable).Dispose()
                                End If
                            End Try
                        Else
                            flag = (Operators.CompareString(dato, "uuid", False) = 0)
                            If flag Then
                                Dim elementsByTagName6 As XmlNodeList = xmlDoc.GetElementsByTagName("tfd:timbrefiscaldigital")
                                Try
                                    Dim enumerator6 As IEnumerator = elementsByTagName6.GetEnumerator()
                                    If enumerator6.MoveNext() Then
                                        Dim xmlNode6 As XmlNode = CType(enumerator6.Current, XmlNode)
                                        text = xmlNode6.Attributes("uuid").InnerXml
                                    End If
                                Finally
                                    Dim enumerator6 As IEnumerator
                                    flag = (TypeOf enumerator6 Is IDisposable)
                                    If flag Then
                                        TryCast(enumerator6, IDisposable).Dispose()
                                    End If
                                End Try
                            Else
                                flag = (Operators.CompareString(dato, "fechatimbrado", False) = 0)
                                If flag Then
                                    Dim elementsByTagName7 As XmlNodeList = xmlDoc.GetElementsByTagName("tfd:timbrefiscaldigital")
                                    Try
                                        Dim enumerator7 As IEnumerator = elementsByTagName7.GetEnumerator()
                                        If enumerator7.MoveNext() Then
                                            Dim xmlNode7 As XmlNode = CType(enumerator7.Current, XmlNode)
                                            text = xmlNode7.Attributes("fechatimbrado").InnerXml
                                        End If
                                    Finally
                                        Dim enumerator7 As IEnumerator
                                        flag = (TypeOf enumerator7 Is IDisposable)
                                        If flag Then
                                            TryCast(enumerator7, IDisposable).Dispose()
                                        End If
                                    End Try
                                Else
                                    flag = (Operators.CompareString(dato, "nocertificadosat", False) = 0)
                                    If flag Then
                                        Dim elementsByTagName8 As XmlNodeList = xmlDoc.GetElementsByTagName("tfd:timbrefiscaldigital")
                                        Try
                                            Dim enumerator8 As IEnumerator = elementsByTagName8.GetEnumerator()
                                            If enumerator8.MoveNext() Then
                                                Dim xmlNode8 As XmlNode = CType(enumerator8.Current, XmlNode)
                                                text = xmlNode8.Attributes("nocertificadosat").InnerXml
                                            End If
                                        Finally
                                            Dim enumerator8 As IEnumerator
                                            flag = (TypeOf enumerator8 Is IDisposable)
                                            If flag Then
                                                TryCast(enumerator8, IDisposable).Dispose()
                                            End If
                                        End Try
                                    Else
                                        flag = (Operators.CompareString(dato, "sellocfd", False) = 0)
                                        If flag Then
                                            Dim elementsByTagName9 As XmlNodeList = xmlDoc.GetElementsByTagName("tfd:timbrefiscaldigital")
                                            Try
                                                Dim enumerator9 As IEnumerator = elementsByTagName9.GetEnumerator()
                                                If enumerator9.MoveNext() Then
                                                    Dim xmlNode9 As XmlNode = CType(enumerator9.Current, XmlNode)
                                                    text = xmlNode9.Attributes("sellocfd").InnerXml
                                                End If
                                            Finally
                                                Dim enumerator9 As IEnumerator
                                                flag = (TypeOf enumerator9 Is IDisposable)
                                                If flag Then
                                                    TryCast(enumerator9, IDisposable).Dispose()
                                                End If
                                            End Try
                                        Else
                                            flag = (Operators.CompareString(dato, "sellosat", False) = 0)
                                            If flag Then
                                                Dim elementsByTagName10 As XmlNodeList = xmlDoc.GetElementsByTagName("tfd:timbrefiscaldigital")
                                                Try
                                                    Dim enumerator10 As IEnumerator = elementsByTagName10.GetEnumerator()
                                                    If enumerator10.MoveNext() Then
                                                        Dim xmlNode10 As XmlNode = CType(enumerator10.Current, XmlNode)
                                                        text = xmlNode10.Attributes("sellosat").InnerXml
                                                    End If
                                                Finally
                                                    Dim enumerator10 As IEnumerator
                                                    flag = (TypeOf enumerator10 Is IDisposable)
                                                    If flag Then
                                                        TryCast(enumerator10, IDisposable).Dispose()
                                                    End If
                                                End Try
                                            Else
                                                flag = (Operators.CompareString(dato, "totalimpuestostrasladados", False) = 0)
                                                If flag Then
                                                    Dim elementsByTagName11 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:traslado")
                                                    'Dim xmlnode11 As XmlNode = xmlDoc.SelectSingleNode("cfdi:impuestos")
                                                    Try
                                                        Dim enumerator11 As IEnumerator = elementsByTagName11.GetEnumerator()
                                                        If enumerator11.MoveNext() Then
                                                            Dim xmlNode11 As XmlNode = CType(enumerator11.Current, XmlNode)
                                                            text = xmlNode11.Attributes("importe").InnerXml
                                                        End If
                                                    Finally
                                                        Dim enumerator11 As IEnumerator
                                                        flag = (TypeOf enumerator11 Is IDisposable)
                                                        If flag Then
                                                            TryCast(enumerator11, IDisposable).Dispose()
                                                        End If
                                                    End Try
                                                Else
                                                    flag = (Operators.CompareString(dato, "tasaiva_traslado", False) = 0)
                                                    If flag Then
                                                        Dim elementsByTagName12 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:traslado")
                                                        Try
                                                            Dim enumerator12 As IEnumerator = elementsByTagName12.GetEnumerator()
                                                            If enumerator12.MoveNext() Then
                                                                Dim xmlNode12 As XmlNode = CType(enumerator12.Current, XmlNode)
                                                                text = xmlNode12.Attributes("tasa").InnerXml
                                                            End If
                                                        Catch ex As Exception
                                                            Try
                                                                Dim enumerator12 As IEnumerator = elementsByTagName12.GetEnumerator()
                                                                If enumerator12.MoveNext() Then
                                                                    Dim xmlNode12 As XmlNode = CType(enumerator12.Current, XmlNode)
                                                                    text = xmlNode12.Attributes("tasaocuota").InnerXml
                                                                End If
                                                            Finally
                                                                Dim enumerator12 As IEnumerator
                                                                flag = (TypeOf enumerator12 Is IDisposable)
                                                                If flag Then
                                                                    TryCast(enumerator12, IDisposable).Dispose()
                                                                End If
                                                            End Try
                                                        End Try
                                                    Else
                                                        flag = (Operators.CompareString(dato, "totalivaretenciones", False) = 0)
                                                        If flag Then
                                                            Dim elementsByTagName13 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:retencion")
                                                            Try
                                                                Dim enumerator13 As IEnumerator = elementsByTagName13.GetEnumerator()
                                                                If enumerator13.MoveNext() Then
                                                                    Dim xmlNode13 As XmlNode = CType(enumerator13.Current, XmlNode)
                                                                    text = xmlNode13.Attributes("importe").InnerXml
                                                                End If
                                                            Finally
                                                                Dim enumerator13 As IEnumerator
                                                                flag = (TypeOf enumerator13 Is IDisposable)
                                                                If flag Then
                                                                    TryCast(enumerator13, IDisposable).Dispose()
                                                                End If
                                                            End Try
                                                        Else
                                                            flag = (Operators.CompareString(dato, "tipocfd", False) = 0)
                                                            If flag Then
                                                                Dim elementsByTagName14 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:comprobante")
                                                                Try
                                                                    Dim enumerator14 As IEnumerator = elementsByTagName14.GetEnumerator()
                                                                    If enumerator14.MoveNext() Then
                                                                        Dim xmlNode14 As XmlNode = CType(enumerator14.Current, XmlNode)
                                                                        text = xmlNode14.Attributes("tipodecomprobante").InnerXml
                                                                    End If
                                                                Finally
                                                                    Dim enumerator14 As IEnumerator
                                                                    flag = (TypeOf enumerator14 Is IDisposable)
                                                                    If flag Then
                                                                        TryCast(enumerator14, IDisposable).Dispose()
                                                                    End If
                                                                End Try
                                                            Else
                                                                flag = (Operators.CompareString(dato, "serief", False) = 0)
                                                                If flag Then
                                                                    Dim elementsByTagName15 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:comprobante")
                                                                    Try
                                                                        Dim enumerator15 As IEnumerator = elementsByTagName15.GetEnumerator()
                                                                        If enumerator15.MoveNext() Then
                                                                            Dim xmlNode15 As XmlNode = CType(enumerator15.Current, XmlNode)
                                                                            text = xmlNode15.Attributes("serie").InnerXml
                                                                        End If
                                                                    Catch ex As Exception
                                                                        Try
                                                                            Dim enumerator15 As IEnumerator = elementsByTagName15.GetEnumerator()
                                                                            If enumerator15.MoveNext() Then
                                                                                Dim xmlNode15 As XmlNode = CType(enumerator15.Current, XmlNode)
                                                                                text = ""
                                                                            End If
                                                                        Finally
                                                                            Dim enumerator15 As IEnumerator
                                                                            flag = (TypeOf enumerator15 Is IDisposable)
                                                                            If flag Then
                                                                                TryCast(enumerator15, IDisposable).Dispose()
                                                                            End If
                                                                        End Try
                                                                    End Try
                                                                Else
                                                                    flag = (Operators.CompareString(dato, "foliof", False) = 0)
                                                                    If flag Then
                                                                        Dim elementsByTagName16 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:comprobante")
                                                                        Try
                                                                            Dim enumerator16 As IEnumerator = elementsByTagName16.GetEnumerator()
                                                                            If enumerator16.MoveNext() Then
                                                                                Dim xmlNode16 As XmlNode = CType(enumerator16.Current, XmlNode)
                                                                                text = xmlNode16.Attributes("folio").InnerXml
                                                                            End If
                                                                        Catch ex As Exception
                                                                            Try
                                                                                Dim enumerator16 As IEnumerator = elementsByTagName16.GetEnumerator()
                                                                                If enumerator16.MoveNext() Then
                                                                                    Dim xmlNode16 As XmlNode = CType(enumerator16.Current, XmlNode)
                                                                                    text = ""
                                                                                End If
                                                                            Finally
                                                                                Dim enumerator16 As IEnumerator
                                                                                flag = (TypeOf enumerator16 Is IDisposable)
                                                                                If flag Then
                                                                                    TryCast(enumerator16, IDisposable).Dispose()
                                                                                End If
                                                                            End Try
                                                                        End Try
                                                                    Else
                                                                        flag = (Operators.CompareString(dato, "fechaf", False) = 0)
                                                                        If flag Then
                                                                            Dim elementsByTagName17 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:comprobante")
                                                                            Try
                                                                                Dim enumerator17 As IEnumerator = elementsByTagName17.GetEnumerator()
                                                                                If enumerator17.MoveNext() Then
                                                                                    Dim xmlNode17 As XmlNode = CType(enumerator17.Current, XmlNode)
                                                                                    text = xmlNode17.Attributes("fecha").InnerXml
                                                                                End If
                                                                            Finally
                                                                                Dim enumerator17 As IEnumerator
                                                                                flag = (TypeOf enumerator17 Is IDisposable)
                                                                                If flag Then
                                                                                    TryCast(enumerator17, IDisposable).Dispose()
                                                                                End If
                                                                            End Try
                                                                        Else
                                                                            flag = (Operators.CompareString(dato, "formapagof", False) = 0)
                                                                            If flag Then
                                                                                Dim elementsByTagName18 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:comprobante")
                                                                                Try
                                                                                    Dim enumerator18 As IEnumerator = elementsByTagName18.GetEnumerator()
                                                                                    If enumerator18.MoveNext() Then
                                                                                        Dim xmlNode18 As XmlNode = CType(enumerator18.Current, XmlNode)
                                                                                        text = xmlNode18.Attributes("formadepago").InnerXml
                                                                                    End If
                                                                                Catch ex As Exception
                                                                                    Try
                                                                                        Dim enumerator18 As IEnumerator = elementsByTagName18.GetEnumerator()
                                                                                        If enumerator18.MoveNext() Then
                                                                                            Dim xmlNode18 As XmlNode = CType(enumerator18.Current, XmlNode)
                                                                                            text = xmlNode18.Attributes("formapago").InnerXml
                                                                                        End If
                                                                                    Finally
                                                                                        Dim enumerator18 As IEnumerator
                                                                                        flag = (TypeOf enumerator18 Is IDisposable)
                                                                                        If flag Then
                                                                                            TryCast(enumerator18, IDisposable).Dispose()
                                                                                        End If
                                                                                    End Try
                                                                                End Try
                                                                            Else
                                                                                flag = (Operators.CompareString(dato, "metodopagof", False) = 0)
                                                                                If flag Then
                                                                                    Dim elementsByTagName19 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:comprobante")
                                                                                    Try
                                                                                        Dim enumerator19 As IEnumerator = elementsByTagName19.GetEnumerator()
                                                                                        If enumerator19.MoveNext() Then
                                                                                            Dim xmlNode19 As XmlNode = CType(enumerator19.Current, XmlNode)
                                                                                            text = xmlNode19.Attributes("metododepago").InnerXml

                                                                                        End If
                                                                                    Catch ex As Exception
                                                                                        Try
                                                                                            Dim enumerator19 As IEnumerator = elementsByTagName19.GetEnumerator()
                                                                                            If enumerator19.MoveNext() Then
                                                                                                Dim xmlNode19 As XmlNode = CType(enumerator19.Current, XmlNode)
                                                                                                text = xmlNode19.Attributes("metodopago").InnerXml
                                                                                            End If
                                                                                        Finally
                                                                                            Dim enumerator19 As IEnumerator
                                                                                            flag = (TypeOf enumerator19 Is IDisposable)
                                                                                            If flag Then
                                                                                                TryCast(enumerator19, IDisposable).Dispose()
                                                                                            End If
                                                                                        End Try
                                                                                    End Try
                                                                                Else
                                                                                    flag = (Operators.CompareString(dato, "cuentapagof", False) = 0)
                                                                                    If flag Then
                                                                                        Dim elementsByTagName20 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:comprobante")
                                                                                        Try
                                                                                            Dim enumerator20 As IEnumerator = elementsByTagName20.GetEnumerator()
                                                                                            If enumerator20.MoveNext() Then
                                                                                                Dim xmlNode20 As XmlNode = CType(enumerator20.Current, XmlNode)
                                                                                                text = xmlNode20.Attributes("numctapago").InnerXml
                                                                                            End If
                                                                                        Finally
                                                                                            Dim enumerator20 As IEnumerator
                                                                                            flag = (TypeOf enumerator20 Is IDisposable)
                                                                                            If flag Then
                                                                                                TryCast(enumerator20, IDisposable).Dispose()
                                                                                            End If
                                                                                        End Try
                                                                                    Else
                                                                                        flag = (Operators.CompareString(dato, "condicionespagof", False) = 0)
                                                                                        If flag Then
                                                                                            Dim elementsByTagName21 As XmlNodeList = xmlDoc.GetElementsByTagName("msgmedio")
                                                                                            Try
                                                                                                Dim enumerator21 As IEnumerator = elementsByTagName21.GetEnumerator()
                                                                                                If enumerator21.MoveNext() Then
                                                                                                    Dim xmlNode21 As XmlNode = CType(enumerator21.Current, XmlNode)
                                                                                                    text = xmlNode21.Attributes("texto").InnerXml
                                                                                                End If
                                                                                            Finally
                                                                                                Dim enumerator21 As IEnumerator
                                                                                                flag = (TypeOf enumerator21 Is IDisposable)
                                                                                                If flag Then
                                                                                                    TryCast(enumerator21, IDisposable).Dispose()
                                                                                                End If
                                                                                            End Try
                                                                                        Else
                                                                                            flag = (Operators.CompareString(dato, "sucursal", False) = 0)
                                                                                            If flag Then
                                                                                                Dim elementsByTagName22 As XmlNodeList = xmlDoc.GetElementsByTagName("sucursal")
                                                                                                Try
                                                                                                    Dim enumerator22 As IEnumerator = elementsByTagName22.GetEnumerator()
                                                                                                    If enumerator22.MoveNext() Then
                                                                                                        Dim xmlNode22 As XmlNode = CType(enumerator22.Current, XmlNode)
                                                                                                        text = xmlNode22.Attributes("texto").InnerXml
                                                                                                    End If
                                                                                                Finally
                                                                                                    Dim enumerator22 As IEnumerator
                                                                                                    flag = (TypeOf enumerator22 Is IDisposable)
                                                                                                    If flag Then
                                                                                                        TryCast(enumerator22, IDisposable).Dispose()
                                                                                                    End If
                                                                                                End Try
                                                                                            Else
                                                                                                flag = (Operators.CompareString(dato, "lugarexpedicionf", False) = 0)
                                                                                                If flag Then
                                                                                                    Dim elementsByTagName23 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:comprobante")
                                                                                                    Try
                                                                                                        Dim enumerator23 As IEnumerator = elementsByTagName23.GetEnumerator()
                                                                                                        If enumerator23.MoveNext() Then
                                                                                                            Dim xmlNode23 As XmlNode = CType(enumerator23.Current, XmlNode)
                                                                                                            text = xmlNode23.Attributes("lugarexpedicion").InnerXml
                                                                                                        End If
                                                                                                    Finally
                                                                                                        Dim enumerator23 As IEnumerator
                                                                                                        flag = (TypeOf enumerator23 Is IDisposable)
                                                                                                        If flag Then
                                                                                                            TryCast(enumerator23, IDisposable).Dispose()
                                                                                                        End If
                                                                                                    End Try
                                                                                                Else
                                                                                                    flag = (Operators.CompareString(dato, "tipocambiof", False) = 0)
                                                                                                    If flag Then
                                                                                                        Dim elementsByTagName24 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:comprobante")
                                                                                                        Try
                                                                                                            Dim enumerator24 As IEnumerator = elementsByTagName24.GetEnumerator()
                                                                                                            If enumerator24.MoveNext() Then
                                                                                                                Dim xmlNode24 As XmlNode = CType(enumerator24.Current, XmlNode)
                                                                                                                text = xmlNode24.Attributes("tipocambio").InnerXml
                                                                                                            End If
                                                                                                        Catch ex As Exception
                                                                                                            Try
                                                                                                                Dim enumerator24 As IEnumerator = elementsByTagName24.GetEnumerator()
                                                                                                                If enumerator24.MoveNext() Then
                                                                                                                    Dim xmlNode24 As XmlNode = CType(enumerator24.Current, XmlNode)
                                                                                                                    text = ""
                                                                                                                End If
                                                                                                            Finally
                                                                                                                Dim enumerator24 As IEnumerator
                                                                                                                flag = (TypeOf enumerator24 Is IDisposable)
                                                                                                                If flag Then
                                                                                                                    TryCast(enumerator24, IDisposable).Dispose()
                                                                                                                End If
                                                                                                            End Try
                                                                                                        End Try
                                                                                                    Else
                                                                                                        flag = (Operators.CompareString(dato, "monedaf", False) = 0)
                                                                                                        If flag Then
                                                                                                            Dim elementsByTagName25 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:comprobante")
                                                                                                            Try
                                                                                                                Dim enumerator25 As IEnumerator = elementsByTagName25.GetEnumerator()
                                                                                                                If enumerator25.MoveNext() Then
                                                                                                                    Dim xmlNode25 As XmlNode = CType(enumerator25.Current, XmlNode)
                                                                                                                    text = xmlNode25.Attributes("moneda").InnerXml
                                                                                                                End If
                                                                                                            Catch ex As Exception
                                                                                                                Try
                                                                                                                    Dim enumerator25 As IEnumerator = elementsByTagName25.GetEnumerator()
                                                                                                                    If enumerator25.MoveNext() Then
                                                                                                                        Dim xmlNode25 As XmlNode = CType(enumerator25.Current, XmlNode)
                                                                                                                        text = ""
                                                                                                                    End If
                                                                                                                Finally
                                                                                                                    Dim enumerator25 As IEnumerator
                                                                                                                    flag = (TypeOf enumerator25 Is IDisposable)
                                                                                                                    If flag Then
                                                                                                                        TryCast(enumerator25, IDisposable).Dispose()
                                                                                                                    End If
                                                                                                                End Try
                                                                                                            End Try
                                                                                                        Else
                                                                                                            flag = (Operators.CompareString(dato, "subtotalf", False) = 0)
                                                                                                            If flag Then
                                                                                                                Dim elementsByTagName26 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:comprobante")
                                                                                                                Try
                                                                                                                    Dim enumerator26 As IEnumerator = elementsByTagName26.GetEnumerator()
                                                                                                                    If enumerator26.MoveNext() Then
                                                                                                                        Dim xmlNode26 As XmlNode = CType(enumerator26.Current, XmlNode)
                                                                                                                        text = xmlNode26.Attributes("subtotal").InnerXml
                                                                                                                    End If
                                                                                                                Finally
                                                                                                                    Dim enumerator26 As IEnumerator
                                                                                                                    flag = (TypeOf enumerator26 Is IDisposable)
                                                                                                                    If flag Then
                                                                                                                        TryCast(enumerator26, IDisposable).Dispose()
                                                                                                                    End If
                                                                                                                End Try
                                                                                                            Else
                                                                                                                flag = (Operators.CompareString(dato, "descuentof", False) = 0)
                                                                                                                If flag Then
                                                                                                                    Dim elementsByTagName27 As XmlNodeList = xmlDoc.GetElementsByTagName("comprobante")
                                                                                                                    Try
                                                                                                                        Dim enumerator27 As IEnumerator = elementsByTagName27.GetEnumerator()
                                                                                                                        If enumerator27.MoveNext() Then
                                                                                                                            Dim xmlNode27 As XmlNode = CType(enumerator27.Current, XmlNode)
                                                                                                                            text = xmlNode27.Attributes("descuento").InnerXml
                                                                                                                        End If
                                                                                                                    Finally
                                                                                                                        Dim enumerator27 As IEnumerator
                                                                                                                        flag = (TypeOf enumerator27 Is IDisposable)
                                                                                                                        If flag Then
                                                                                                                            TryCast(enumerator27, IDisposable).Dispose()
                                                                                                                        End If
                                                                                                                    End Try
                                                                                                                Else
                                                                                                                    flag = (Operators.CompareString(dato, "totalf", False) = 0)
                                                                                                                    If flag Then
                                                                                                                        Dim elementsByTagName28 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:comprobante")
                                                                                                                        Try
                                                                                                                            Dim enumerator28 As IEnumerator = elementsByTagName28.GetEnumerator()
                                                                                                                            If enumerator28.MoveNext() Then
                                                                                                                                Dim xmlNode28 As XmlNode = CType(enumerator28.Current, XmlNode)
                                                                                                                                text = xmlNode28.Attributes("total").InnerXml
                                                                                                                            End If
                                                                                                                        Finally
                                                                                                                            Dim enumerator28 As IEnumerator
                                                                                                                            flag = (TypeOf enumerator28 Is IDisposable)
                                                                                                                            If flag Then
                                                                                                                                TryCast(enumerator28, IDisposable).Dispose()
                                                                                                                            End If
                                                                                                                        End Try
                                                                                                                    Else
                                                                                                                        flag = (Operators.CompareString(dato, "referencias", False) = 0)
                                                                                                                        If flag Then
                                                                                                                            Dim elementsByTagName29 As XmlNodeList = xmlDoc.GetElementsByTagName("referencias")
                                                                                                                            Try
                                                                                                                                Dim enumerator29 As IEnumerator = elementsByTagName29.GetEnumerator()
                                                                                                                                If enumerator29.MoveNext() Then
                                                                                                                                    Dim xmlNode29 As XmlNode = CType(enumerator29.Current, XmlNode)
                                                                                                                                    text = xmlNode29.Attributes("texto").InnerXml
                                                                                                                                End If
                                                                                                                            Finally
                                                                                                                                Dim enumerator29 As IEnumerator
                                                                                                                                flag = (TypeOf enumerator29 Is IDisposable)
                                                                                                                                If flag Then
                                                                                                                                    TryCast(enumerator29, IDisposable).Dispose()
                                                                                                                                End If
                                                                                                                            End Try
                                                                                                                        Else
                                                                                                                            flag = (Operators.CompareString(dato, "zona", False) = 0)
                                                                                                                            If flag Then
                                                                                                                                Dim elementsByTagName30 As XmlNodeList = xmlDoc.GetElementsByTagName("zona")
                                                                                                                                Try
                                                                                                                                    Dim enumerator30 As IEnumerator = elementsByTagName30.GetEnumerator()
                                                                                                                                    If enumerator30.MoveNext() Then
                                                                                                                                        Dim xmlNode30 As XmlNode = CType(enumerator30.Current, XmlNode)
                                                                                                                                        text = xmlNode30.Attributes("texto").InnerXml
                                                                                                                                    End If
                                                                                                                                Finally
                                                                                                                                    Dim enumerator30 As IEnumerator
                                                                                                                                    flag = (TypeOf enumerator30 Is IDisposable)
                                                                                                                                    If flag Then
                                                                                                                                        TryCast(enumerator30, IDisposable).Dispose()
                                                                                                                                    End If
                                                                                                                                End Try
                                                                                                                            Else
                                                                                                                                flag = (Operators.CompareString(dato, "supervision", False) = 0)
                                                                                                                                If flag Then
                                                                                                                                    Dim elementsByTagName31 As XmlNodeList = xmlDoc.GetElementsByTagName("supervision")
                                                                                                                                    Try
                                                                                                                                        Dim enumerator31 As IEnumerator = elementsByTagName31.GetEnumerator()
                                                                                                                                        If enumerator31.MoveNext() Then
                                                                                                                                            Dim xmlNode31 As XmlNode = CType(enumerator31.Current, XmlNode)
                                                                                                                                            text = xmlNode31.Attributes("texto").InnerXml
                                                                                                                                        End If
                                                                                                                                    Finally
                                                                                                                                        Dim enumerator31 As IEnumerator
                                                                                                                                        flag = (TypeOf enumerator31 Is IDisposable)
                                                                                                                                        If flag Then
                                                                                                                                            TryCast(enumerator31, IDisposable).Dispose()
                                                                                                                                        End If
                                                                                                                                    End Try
                                                                                                                                Else
                                                                                                                                    flag = (Operators.CompareString(dato, "grupo", False) = 0)
                                                                                                                                    If flag Then
                                                                                                                                        Dim elementsByTagName32 As XmlNodeList = xmlDoc.GetElementsByTagName("grupo")
                                                                                                                                        Try
                                                                                                                                            Dim enumerator32 As IEnumerator = elementsByTagName32.GetEnumerator()
                                                                                                                                            If enumerator32.MoveNext() Then
                                                                                                                                                Dim xmlNode32 As XmlNode = CType(enumerator32.Current, XmlNode)
                                                                                                                                                text = xmlNode32.Attributes("texto").InnerXml
                                                                                                                                            End If
                                                                                                                                        Finally
                                                                                                                                            Dim enumerator32 As IEnumerator
                                                                                                                                            flag = (TypeOf enumerator32 Is IDisposable)
                                                                                                                                            If flag Then
                                                                                                                                                TryCast(enumerator32, IDisposable).Dispose()
                                                                                                                                            End If
                                                                                                                                        End Try
                                                                                                                                    Else
                                                                                                                                        flag = (Operators.CompareString(dato, "indicaciones", False) = 0)
                                                                                                                                        If flag Then
                                                                                                                                            Dim elementsByTagName33 As XmlNodeList = xmlDoc.GetElementsByTagName("indicaciones")
                                                                                                                                            Try
                                                                                                                                                Dim enumerator33 As IEnumerator = elementsByTagName33.GetEnumerator()
                                                                                                                                                If enumerator33.MoveNext() Then
                                                                                                                                                    Dim xmlNode33 As XmlNode = CType(enumerator33.Current, XmlNode)
                                                                                                                                                    text = xmlNode33.Attributes("texto").InnerXml
                                                                                                                                                End If
                                                                                                                                            Finally
                                                                                                                                                Dim enumerator33 As IEnumerator
                                                                                                                                                flag = (TypeOf enumerator33 Is IDisposable)
                                                                                                                                                If flag Then
                                                                                                                                                    TryCast(enumerator33, IDisposable).Dispose()
                                                                                                                                                End If
                                                                                                                                            End Try
                                                                                                                                        Else
                                                                                                                                            flag = (Operators.CompareString(dato, "msgmedio", False) = 0)
                                                                                                                                            If flag Then
                                                                                                                                                Dim elementsByTagName34 As XmlNodeList = xmlDoc.GetElementsByTagName("msgmedio")
                                                                                                                                                Try
                                                                                                                                                    Dim enumerator34 As IEnumerator = elementsByTagName34.GetEnumerator()
                                                                                                                                                    If enumerator34.MoveNext() Then
                                                                                                                                                        Dim xmlNode34 As XmlNode = CType(enumerator34.Current, XmlNode)
                                                                                                                                                        text = xmlNode34.Attributes("texto").InnerXml
                                                                                                                                                    End If
                                                                                                                                                Finally
                                                                                                                                                    Dim enumerator34 As IEnumerator
                                                                                                                                                    flag = (TypeOf enumerator34 Is IDisposable)
                                                                                                                                                    If flag Then
                                                                                                                                                        TryCast(enumerator34, IDisposable).Dispose()
                                                                                                                                                    End If
                                                                                                                                                End Try
                                                                                                                                            Else
                                                                                                                                                flag = (Operators.CompareString(dato, "msgcorto", False) = 0)
                                                                                                                                                If flag Then
                                                                                                                                                    Dim elementsByTagName35 As XmlNodeList = xmlDoc.GetElementsByTagName("msgcorto")
                                                                                                                                                    Try
                                                                                                                                                        Dim enumerator35 As IEnumerator = elementsByTagName35.GetEnumerator()
                                                                                                                                                        If enumerator35.MoveNext() Then
                                                                                                                                                            Dim xmlNode35 As XmlNode = CType(enumerator35.Current, XmlNode)
                                                                                                                                                            text = xmlNode35.Attributes("texto").InnerXml
                                                                                                                                                        End If
                                                                                                                                                    Finally
                                                                                                                                                        Dim enumerator35 As IEnumerator
                                                                                                                                                        flag = (TypeOf enumerator35 Is IDisposable)
                                                                                                                                                        If flag Then
                                                                                                                                                            TryCast(enumerator35, IDisposable).Dispose()
                                                                                                                                                        End If
                                                                                                                                                    End Try
                                                                                                                                                Else
                                                                                                                                                    flag = (Operators.CompareString(dato, "msgcorto2", False) = 0)
                                                                                                                                                    If flag Then
                                                                                                                                                        Dim elementsByTagName36 As XmlNodeList = xmlDoc.GetElementsByTagName("msgcorto2")
                                                                                                                                                        Try
                                                                                                                                                            Dim enumerator36 As IEnumerator = elementsByTagName36.GetEnumerator()
                                                                                                                                                            If enumerator36.MoveNext() Then
                                                                                                                                                                Dim xmlNode36 As XmlNode = CType(enumerator36.Current, XmlNode)
                                                                                                                                                                text = xmlNode36.Attributes("texto").InnerXml
                                                                                                                                                            End If
                                                                                                                                                        Finally
                                                                                                                                                            Dim enumerator36 As IEnumerator
                                                                                                                                                            flag = (TypeOf enumerator36 Is IDisposable)
                                                                                                                                                            If flag Then
                                                                                                                                                                TryCast(enumerator36, IDisposable).Dispose()
                                                                                                                                                            End If
                                                                                                                                                        End Try
                                                                                                                                                    Else
                                                                                                                                                        flag = (Operators.CompareString(dato, "msgcorto3", False) = 0)
                                                                                                                                                        If flag Then
                                                                                                                                                            Dim elementsByTagName37 As XmlNodeList = xmlDoc.GetElementsByTagName("msgcorto3")
                                                                                                                                                            Try
                                                                                                                                                                Dim enumerator37 As IEnumerator = elementsByTagName37.GetEnumerator()
                                                                                                                                                                If enumerator37.MoveNext() Then
                                                                                                                                                                    Dim xmlNode37 As XmlNode = CType(enumerator37.Current, XmlNode)
                                                                                                                                                                    text = xmlNode37.Attributes("texto").InnerXml
                                                                                                                                                                End If
                                                                                                                                                            Finally
                                                                                                                                                                Dim enumerator37 As IEnumerator
                                                                                                                                                                flag = (TypeOf enumerator37 Is IDisposable)
                                                                                                                                                                If flag Then
                                                                                                                                                                    TryCast(enumerator37, IDisposable).Dispose()
                                                                                                                                                                End If
                                                                                                                                                            End Try
                                                                                                                                                        Else
                                                                                                                                                            flag = (Operators.CompareString(dato, "rfce", False) = 0)
                                                                                                                                                            If flag Then
                                                                                                                                                                Dim elementsByTagName38 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:emisor")
                                                                                                                                                                Try
                                                                                                                                                                    Dim enumerator38 As IEnumerator = elementsByTagName38.GetEnumerator()
                                                                                                                                                                    If enumerator38.MoveNext() Then
                                                                                                                                                                        Dim xmlNode38 As XmlNode = CType(enumerator38.Current, XmlNode)
                                                                                                                                                                        text = xmlNode38.Attributes("rfc").InnerXml
                                                                                                                                                                    End If
                                                                                                                                                                Finally
                                                                                                                                                                    Dim enumerator38 As IEnumerator
                                                                                                                                                                    flag = (TypeOf enumerator38 Is IDisposable)
                                                                                                                                                                    If flag Then
                                                                                                                                                                        TryCast(enumerator38, IDisposable).Dispose()
                                                                                                                                                                    End If
                                                                                                                                                                End Try
                                                                                                                                                            Else
                                                                                                                                                                flag = (Operators.CompareString(dato, "rfcr", False) = 0)
                                                                                                                                                                If flag Then
                                                                                                                                                                    Dim elementsByTagName39 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:receptor")
                                                                                                                                                                    Try
                                                                                                                                                                        Dim enumerator39 As IEnumerator = elementsByTagName39.GetEnumerator()
                                                                                                                                                                        If enumerator39.MoveNext() Then
                                                                                                                                                                            Dim xmlNode39 As XmlNode = CType(enumerator39.Current, XmlNode)
                                                                                                                                                                            text = xmlNode39.Attributes("rfc").InnerXml
                                                                                                                                                                        End If
                                                                                                                                                                    Finally
                                                                                                                                                                        Dim enumerator39 As IEnumerator
                                                                                                                                                                        flag = (TypeOf enumerator39 Is IDisposable)
                                                                                                                                                                        If flag Then
                                                                                                                                                                            TryCast(enumerator39, IDisposable).Dispose()
                                                                                                                                                                        End If
                                                                                                                                                                    End Try
                                                                                                                                                                Else
                                                                                                                                                                    'flag = (Operators.CompareString(dato, "idemisor", False) = 0)
                                                                                                                                                                    'If flag Then
                                                                                                                                                                    '    text = "0"
                                                                                                                                                                    'Else
                                                                                                                                                                    flag = (Operators.CompareString(dato, "razone", False) = 0)
                                                                                                                                                                    If flag Then
                                                                                                                                                                        Dim elementsByTagName40 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:emisor")
                                                                                                                                                                        Try
                                                                                                                                                                            Dim enumerator40 As IEnumerator = elementsByTagName40.GetEnumerator()
                                                                                                                                                                            If enumerator40.MoveNext() Then
                                                                                                                                                                                Dim xmlNode40 As XmlNode = CType(enumerator40.Current, XmlNode)
                                                                                                                                                                                text = xmlNode40.Attributes("nombre").InnerXml
                                                                                                                                                                            End If
                                                                                                                                                                        Finally
                                                                                                                                                                            Dim enumerator40 As IEnumerator
                                                                                                                                                                            flag = (TypeOf enumerator40 Is IDisposable)
                                                                                                                                                                            If flag Then
                                                                                                                                                                                TryCast(enumerator40, IDisposable).Dispose()
                                                                                                                                                                            End If
                                                                                                                                                                        End Try
                                                                                                                                                                    Else
                                                                                                                                                                        flag = (Operators.CompareString(dato, "callee", False) = 0)
                                                                                                                                                                        If flag Then
                                                                                                                                                                            Dim elementsByTagName41 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:domiciliofiscal")
                                                                                                                                                                            Try
                                                                                                                                                                                Dim enumerator41 As IEnumerator = elementsByTagName41.GetEnumerator()
                                                                                                                                                                                If enumerator41.MoveNext() Then
                                                                                                                                                                                    Dim xmlNode41 As XmlNode = CType(enumerator41.Current, XmlNode)
                                                                                                                                                                                    text = xmlNode41.Attributes("calle").InnerXml
                                                                                                                                                                                End If
                                                                                                                                                                            Finally
                                                                                                                                                                                Dim enumerator41 As IEnumerator
                                                                                                                                                                                flag = (TypeOf enumerator41 Is IDisposable)
                                                                                                                                                                                If flag Then
                                                                                                                                                                                    TryCast(enumerator41, IDisposable).Dispose()
                                                                                                                                                                                End If
                                                                                                                                                                            End Try
                                                                                                                                                                        Else
                                                                                                                                                                            flag = (Operators.CompareString(dato, "numexte", False) = 0)
                                                                                                                                                                            If flag Then
                                                                                                                                                                                Dim elementsByTagName42 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:domiciliofiscal")
                                                                                                                                                                                Try
                                                                                                                                                                                    Dim enumerator42 As IEnumerator = elementsByTagName42.GetEnumerator()
                                                                                                                                                                                    If enumerator42.MoveNext() Then
                                                                                                                                                                                        Dim xmlNode42 As XmlNode = CType(enumerator42.Current, XmlNode)
                                                                                                                                                                                        text = xmlNode42.Attributes("noexterior").InnerXml
                                                                                                                                                                                    End If
                                                                                                                                                                                Finally
                                                                                                                                                                                    Dim enumerator42 As IEnumerator
                                                                                                                                                                                    flag = (TypeOf enumerator42 Is IDisposable)
                                                                                                                                                                                    If flag Then
                                                                                                                                                                                        TryCast(enumerator42, IDisposable).Dispose()
                                                                                                                                                                                    End If
                                                                                                                                                                                End Try
                                                                                                                                                                            Else
                                                                                                                                                                                flag = (Operators.CompareString(dato, "numinte", False) = 0)
                                                                                                                                                                                If flag Then
                                                                                                                                                                                    Dim elementsByTagName43 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:domiciliofiscal")
                                                                                                                                                                                    Try
                                                                                                                                                                                        Dim enumerator43 As IEnumerator = elementsByTagName43.GetEnumerator()
                                                                                                                                                                                        While enumerator43.MoveNext()
                                                                                                                                                                                            Dim xmlNode43 As XmlNode = CType(enumerator43.Current, XmlNode)
                                                                                                                                                                                            flag = (xmlNode43.Attributes("nointerior") IsNot Nothing)
                                                                                                                                                                                            If flag Then
                                                                                                                                                                                                text = xmlNode43.Attributes("nointerior").InnerXml
                                                                                                                                                                                                Exit While
                                                                                                                                                                                            End If
                                                                                                                                                                                        End While
                                                                                                                                                                                    Finally
                                                                                                                                                                                        Dim enumerator43 As IEnumerator
                                                                                                                                                                                        flag = (TypeOf enumerator43 Is IDisposable)
                                                                                                                                                                                        If flag Then
                                                                                                                                                                                            TryCast(enumerator43, IDisposable).Dispose()
                                                                                                                                                                                        End If
                                                                                                                                                                                    End Try
                                                                                                                                                                                Else
                                                                                                                                                                                    flag = (Operators.CompareString(dato, "coloniae", False) = 0)
                                                                                                                                                                                    If flag Then
                                                                                                                                                                                        Dim elementsByTagName44 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:domiciliofiscal")
                                                                                                                                                                                        Try
                                                                                                                                                                                            Dim enumerator44 As IEnumerator = elementsByTagName44.GetEnumerator()
                                                                                                                                                                                            If enumerator44.MoveNext() Then
                                                                                                                                                                                                Dim xmlNode44 As XmlNode = CType(enumerator44.Current, XmlNode)
                                                                                                                                                                                                text = xmlNode44.Attributes("colonia").InnerXml
                                                                                                                                                                                            End If
                                                                                                                                                                                        Finally
                                                                                                                                                                                            Dim enumerator44 As IEnumerator
                                                                                                                                                                                            flag = (TypeOf enumerator44 Is IDisposable)
                                                                                                                                                                                            If flag Then
                                                                                                                                                                                                TryCast(enumerator44, IDisposable).Dispose()
                                                                                                                                                                                            End If
                                                                                                                                                                                        End Try
                                                                                                                                                                                    Else
                                                                                                                                                                                        flag = (Operators.CompareString(dato, "localidade", False) = 0)
                                                                                                                                                                                        If flag Then
                                                                                                                                                                                            Dim elementsByTagName45 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:domiciliofiscal")
                                                                                                                                                                                            Try
                                                                                                                                                                                                Dim enumerator45 As IEnumerator = elementsByTagName45.GetEnumerator()
                                                                                                                                                                                                If enumerator45.MoveNext() Then
                                                                                                                                                                                                    Dim xmlNode45 As XmlNode = CType(enumerator45.Current, XmlNode)
                                                                                                                                                                                                    text = xmlNode45.Attributes("localidad").InnerXml
                                                                                                                                                                                                End If
                                                                                                                                                                                            Finally
                                                                                                                                                                                                Dim enumerator45 As IEnumerator
                                                                                                                                                                                                flag = (TypeOf enumerator45 Is IDisposable)
                                                                                                                                                                                                If flag Then
                                                                                                                                                                                                    TryCast(enumerator45, IDisposable).Dispose()
                                                                                                                                                                                                End If
                                                                                                                                                                                            End Try
                                                                                                                                                                                        Else
                                                                                                                                                                                            flag = (Operators.CompareString(dato, "municipioe", False) = 0)
                                                                                                                                                                                            If flag Then
                                                                                                                                                                                                Dim elementsByTagName46 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:domiciliofiscal")
                                                                                                                                                                                                Try
                                                                                                                                                                                                    Dim enumerator46 As IEnumerator = elementsByTagName46.GetEnumerator()
                                                                                                                                                                                                    If enumerator46.MoveNext() Then
                                                                                                                                                                                                        Dim xmlNode46 As XmlNode = CType(enumerator46.Current, XmlNode)
                                                                                                                                                                                                        text = xmlNode46.Attributes("municipio").InnerXml
                                                                                                                                                                                                    End If
                                                                                                                                                                                                Finally
                                                                                                                                                                                                    Dim enumerator46 As IEnumerator
                                                                                                                                                                                                    flag = (TypeOf enumerator46 Is IDisposable)
                                                                                                                                                                                                    If flag Then
                                                                                                                                                                                                        TryCast(enumerator46, IDisposable).Dispose()
                                                                                                                                                                                                    End If
                                                                                                                                                                                                End Try
                                                                                                                                                                                            Else
                                                                                                                                                                                                flag = (Operators.CompareString(dato, "estadoe", False) = 0)
                                                                                                                                                                                                If flag Then
                                                                                                                                                                                                    Dim elementsByTagName47 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:domiciliofiscal")
                                                                                                                                                                                                    Try
                                                                                                                                                                                                        Dim enumerator47 As IEnumerator = elementsByTagName47.GetEnumerator()
                                                                                                                                                                                                        If enumerator47.MoveNext() Then
                                                                                                                                                                                                            Dim xmlNode47 As XmlNode = CType(enumerator47.Current, XmlNode)
                                                                                                                                                                                                            text = xmlNode47.Attributes("estado").InnerXml
                                                                                                                                                                                                        End If
                                                                                                                                                                                                    Finally
                                                                                                                                                                                                        Dim enumerator47 As IEnumerator
                                                                                                                                                                                                        flag = (TypeOf enumerator47 Is IDisposable)
                                                                                                                                                                                                        If flag Then
                                                                                                                                                                                                            TryCast(enumerator47, IDisposable).Dispose()
                                                                                                                                                                                                        End If
                                                                                                                                                                                                    End Try
                                                                                                                                                                                                Else
                                                                                                                                                                                                    flag = (Operators.CompareString(dato, "paise", False) = 0)
                                                                                                                                                                                                    If flag Then
                                                                                                                                                                                                        Dim elementsByTagName48 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:domiciliofiscal")
                                                                                                                                                                                                        Try
                                                                                                                                                                                                            Dim enumerator48 As IEnumerator = elementsByTagName48.GetEnumerator()
                                                                                                                                                                                                            If enumerator48.MoveNext() Then
                                                                                                                                                                                                                Dim xmlNode48 As XmlNode = CType(enumerator48.Current, XmlNode)
                                                                                                                                                                                                                text = xmlNode48.Attributes("pais").InnerXml
                                                                                                                                                                                                            End If
                                                                                                                                                                                                        Finally
                                                                                                                                                                                                            Dim enumerator48 As IEnumerator
                                                                                                                                                                                                            flag = (TypeOf enumerator48 Is IDisposable)
                                                                                                                                                                                                            If flag Then
                                                                                                                                                                                                                TryCast(enumerator48, IDisposable).Dispose()
                                                                                                                                                                                                            End If
                                                                                                                                                                                                        End Try
                                                                                                                                                                                                    Else
                                                                                                                                                                                                        flag = (Operators.CompareString(dato, "cpe", False) = 0)
                                                                                                                                                                                                        If flag Then
                                                                                                                                                                                                            Dim elementsByTagName49 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:domiciliofiscal")
                                                                                                                                                                                                            Try
                                                                                                                                                                                                                Dim enumerator49 As IEnumerator = elementsByTagName49.GetEnumerator()
                                                                                                                                                                                                                If enumerator49.MoveNext() Then
                                                                                                                                                                                                                    Dim xmlNode49 As XmlNode = CType(enumerator49.Current, XmlNode)
                                                                                                                                                                                                                    text = xmlNode49.Attributes("codigopostal").InnerXml
                                                                                                                                                                                                                End If
                                                                                                                                                                                                            Finally
                                                                                                                                                                                                                Dim enumerator49 As IEnumerator
                                                                                                                                                                                                                flag = (TypeOf enumerator49 Is IDisposable)
                                                                                                                                                                                                                If flag Then
                                                                                                                                                                                                                    TryCast(enumerator49, IDisposable).Dispose()
                                                                                                                                                                                                                End If
                                                                                                                                                                                                            End Try
                                                                                                                                                                                                        Else
                                                                                                                                                                                                            flag = (Operators.CompareString(dato, "regimenfiscale", False) = 0)
                                                                                                                                                                                                            If flag Then
                                                                                                                                                                                                                Dim elementsByTagName50 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:regimenfiscal")
                                                                                                                                                                                                                Try
                                                                                                                                                                                                                    Dim enumerator50 As IEnumerator = elementsByTagName50.GetEnumerator()
                                                                                                                                                                                                                    If enumerator50.MoveNext() Then
                                                                                                                                                                                                                        Dim xmlNode50 As XmlNode = CType(enumerator50.Current, XmlNode)
                                                                                                                                                                                                                        text = xmlNode50.Attributes("regimen").InnerXml
                                                                                                                                                                                                                    End If
                                                                                                                                                                                                                Finally
                                                                                                                                                                                                                    Dim enumerator50 As IEnumerator
                                                                                                                                                                                                                    flag = (TypeOf enumerator50 Is IDisposable)
                                                                                                                                                                                                                    If flag Then
                                                                                                                                                                                                                        TryCast(enumerator50, IDisposable).Dispose()
                                                                                                                                                                                                                    End If
                                                                                                                                                                                                                End Try
                                                                                                                                                                                                            Else
                                                                                                                                                                                                                flag = (Operators.CompareString(dato, "idreceptor", False) = 0)
                                                                                                                                                                                                                If flag Then
                                                                                                                                                                                                                    Dim elementsByTagName51 As XmlNodeList = xmlDoc.GetElementsByTagName("receptor")
                                                                                                                                                                                                                    Try
                                                                                                                                                                                                                        Dim enumerator51 As IEnumerator = elementsByTagName51.GetEnumerator()
                                                                                                                                                                                                                        If enumerator51.MoveNext() Then
                                                                                                                                                                                                                            Dim xmlNode51 As XmlNode = CType(enumerator51.Current, XmlNode)
                                                                                                                                                                                                                            text = xmlNode51.Attributes("ncliente").InnerXml
                                                                                                                                                                                                                        End If
                                                                                                                                                                                                                    Finally
                                                                                                                                                                                                                        Dim enumerator51 As IEnumerator
                                                                                                                                                                                                                        flag = (TypeOf enumerator51 Is IDisposable)
                                                                                                                                                                                                                        If flag Then
                                                                                                                                                                                                                            TryCast(enumerator51, IDisposable).Dispose()
                                                                                                                                                                                                                        End If
                                                                                                                                                                                                                    End Try
                                                                                                                                                                                                                Else
                                                                                                                                                                                                                    flag = (Operators.CompareString(dato, "razonr", False) = 0)
                                                                                                                                                                                                                    If flag Then
                                                                                                                                                                                                                        Dim elementsByTagName52 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:receptor")
                                                                                                                                                                                                                        Try
                                                                                                                                                                                                                            Dim enumerator52 As IEnumerator = elementsByTagName52.GetEnumerator()
                                                                                                                                                                                                                            If enumerator52.MoveNext() Then
                                                                                                                                                                                                                                Dim xmlNode52 As XmlNode = CType(enumerator52.Current, XmlNode)
                                                                                                                                                                                                                                text = xmlNode52.Attributes("nombre").InnerXml
                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                        Finally
                                                                                                                                                                                                                            Dim enumerator52 As IEnumerator
                                                                                                                                                                                                                            flag = (TypeOf enumerator52 Is IDisposable)
                                                                                                                                                                                                                            If flag Then
                                                                                                                                                                                                                                TryCast(enumerator52, IDisposable).Dispose()
                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                        End Try
                                                                                                                                                                                                                    Else
                                                                                                                                                                                                                        flag = (Operators.CompareString(dato, "caller", False) = 0)
                                                                                                                                                                                                                        If flag Then
                                                                                                                                                                                                                            Dim elementsByTagName53 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:domicilio")
                                                                                                                                                                                                                            Try
                                                                                                                                                                                                                                Dim enumerator53 As IEnumerator = elementsByTagName53.GetEnumerator()
                                                                                                                                                                                                                                If enumerator53.MoveNext() Then
                                                                                                                                                                                                                                    Dim xmlNode53 As XmlNode = CType(enumerator53.Current, XmlNode)
                                                                                                                                                                                                                                    text = xmlNode53.Attributes("calle").InnerXml
                                                                                                                                                                                                                                End If
                                                                                                                                                                                                                            Finally
                                                                                                                                                                                                                                Dim enumerator53 As IEnumerator
                                                                                                                                                                                                                                flag = (TypeOf enumerator53 Is IDisposable)
                                                                                                                                                                                                                                If flag Then
                                                                                                                                                                                                                                    TryCast(enumerator53, IDisposable).Dispose()
                                                                                                                                                                                                                                End If
                                                                                                                                                                                                                            End Try
                                                                                                                                                                                                                        Else
                                                                                                                                                                                                                            flag = (Operators.CompareString(dato, "numextr", False) = 0)
                                                                                                                                                                                                                            If flag Then
                                                                                                                                                                                                                                Dim elementsByTagName54 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:domicilio")
                                                                                                                                                                                                                                Try
                                                                                                                                                                                                                                    Dim enumerator54 As IEnumerator = elementsByTagName54.GetEnumerator()
                                                                                                                                                                                                                                    If enumerator54.MoveNext() Then
                                                                                                                                                                                                                                        Dim xmlNode54 As XmlNode = CType(enumerator54.Current, XmlNode)
                                                                                                                                                                                                                                        text = xmlNode54.Attributes("noexterior").InnerXml
                                                                                                                                                                                                                                    End If
                                                                                                                                                                                                                                Finally
                                                                                                                                                                                                                                    Dim enumerator54 As IEnumerator
                                                                                                                                                                                                                                    flag = (TypeOf enumerator54 Is IDisposable)
                                                                                                                                                                                                                                    If flag Then
                                                                                                                                                                                                                                        TryCast(enumerator54, IDisposable).Dispose()
                                                                                                                                                                                                                                    End If
                                                                                                                                                                                                                                End Try
                                                                                                                                                                                                                            Else
                                                                                                                                                                                                                                flag = (Operators.CompareString(dato, "numintr", False) = 0)
                                                                                                                                                                                                                                If flag Then
                                                                                                                                                                                                                                    Dim elementsByTagName55 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:domicilio")
                                                                                                                                                                                                                                    Try
                                                                                                                                                                                                                                        Dim enumerator55 As IEnumerator = elementsByTagName55.GetEnumerator()
                                                                                                                                                                                                                                        While enumerator55.MoveNext()
                                                                                                                                                                                                                                            Dim xmlNode55 As XmlNode = CType(enumerator55.Current, XmlNode)
                                                                                                                                                                                                                                            flag = (xmlNode55.Attributes("nointerior") IsNot Nothing)
                                                                                                                                                                                                                                            If flag Then
                                                                                                                                                                                                                                                text = xmlNode55.Attributes("nointerior").InnerXml
                                                                                                                                                                                                                                                Exit While
                                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                                        End While
                                                                                                                                                                                                                                    Finally
                                                                                                                                                                                                                                        Dim enumerator55 As IEnumerator
                                                                                                                                                                                                                                        flag = (TypeOf enumerator55 Is IDisposable)
                                                                                                                                                                                                                                        If flag Then
                                                                                                                                                                                                                                            TryCast(enumerator55, IDisposable).Dispose()
                                                                                                                                                                                                                                        End If
                                                                                                                                                                                                                                    End Try
                                                                                                                                                                                                                                Else
                                                                                                                                                                                                                                    flag = (Operators.CompareString(dato, "coloniar", False) = 0)
                                                                                                                                                                                                                                    If flag Then
                                                                                                                                                                                                                                        Dim elementsByTagName56 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:domicilio")
                                                                                                                                                                                                                                        Try
                                                                                                                                                                                                                                            Dim enumerator56 As IEnumerator = elementsByTagName56.GetEnumerator()
                                                                                                                                                                                                                                            If enumerator56.MoveNext() Then
                                                                                                                                                                                                                                                Dim xmlNode56 As XmlNode = CType(enumerator56.Current, XmlNode)
                                                                                                                                                                                                                                                text = xmlNode56.Attributes("colonia").InnerXml
                                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                                        Finally
                                                                                                                                                                                                                                            Dim enumerator56 As IEnumerator
                                                                                                                                                                                                                                            flag = (TypeOf enumerator56 Is IDisposable)
                                                                                                                                                                                                                                            If flag Then
                                                                                                                                                                                                                                                TryCast(enumerator56, IDisposable).Dispose()
                                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                                        End Try
                                                                                                                                                                                                                                    Else
                                                                                                                                                                                                                                        flag = (Operators.CompareString(dato, "localidadr", False) = 0)
                                                                                                                                                                                                                                        If flag Then
                                                                                                                                                                                                                                            Dim elementsByTagName57 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:domicilio")
                                                                                                                                                                                                                                            Try
                                                                                                                                                                                                                                                Dim enumerator57 As IEnumerator = elementsByTagName57.GetEnumerator()
                                                                                                                                                                                                                                                If enumerator57.MoveNext() Then
                                                                                                                                                                                                                                                    Dim xmlNode57 As XmlNode = CType(enumerator57.Current, XmlNode)
                                                                                                                                                                                                                                                    text = xmlNode57.Attributes("localidad").InnerXml
                                                                                                                                                                                                                                                End If
                                                                                                                                                                                                                                            Finally
                                                                                                                                                                                                                                                Dim enumerator57 As IEnumerator
                                                                                                                                                                                                                                                flag = (TypeOf enumerator57 Is IDisposable)
                                                                                                                                                                                                                                                If flag Then
                                                                                                                                                                                                                                                    TryCast(enumerator57, IDisposable).Dispose()
                                                                                                                                                                                                                                                End If
                                                                                                                                                                                                                                            End Try
                                                                                                                                                                                                                                        Else
                                                                                                                                                                                                                                            flag = (Operators.CompareString(dato, "municipior", False) = 0)
                                                                                                                                                                                                                                            If flag Then
                                                                                                                                                                                                                                                Dim elementsByTagName58 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:domicilio")
                                                                                                                                                                                                                                                Try
                                                                                                                                                                                                                                                    Dim enumerator58 As IEnumerator = elementsByTagName58.GetEnumerator()
                                                                                                                                                                                                                                                    If enumerator58.MoveNext() Then
                                                                                                                                                                                                                                                        Dim xmlNode58 As XmlNode = CType(enumerator58.Current, XmlNode)
                                                                                                                                                                                                                                                        text = xmlNode58.Attributes("municipio").InnerXml
                                                                                                                                                                                                                                                    End If
                                                                                                                                                                                                                                                Finally
                                                                                                                                                                                                                                                    Dim enumerator58 As IEnumerator
                                                                                                                                                                                                                                                    flag = (TypeOf enumerator58 Is IDisposable)
                                                                                                                                                                                                                                                    If flag Then
                                                                                                                                                                                                                                                        TryCast(enumerator58, IDisposable).Dispose()
                                                                                                                                                                                                                                                    End If
                                                                                                                                                                                                                                                End Try
                                                                                                                                                                                                                                            Else
                                                                                                                                                                                                                                                flag = (Operators.CompareString(dato, "estador", False) = 0)
                                                                                                                                                                                                                                                If flag Then
                                                                                                                                                                                                                                                    Dim elementsByTagName59 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:domicilio")
                                                                                                                                                                                                                                                    Try
                                                                                                                                                                                                                                                        Dim enumerator59 As IEnumerator = elementsByTagName59.GetEnumerator()
                                                                                                                                                                                                                                                        If enumerator59.MoveNext() Then
                                                                                                                                                                                                                                                            Dim xmlNode59 As XmlNode = CType(enumerator59.Current, XmlNode)
                                                                                                                                                                                                                                                            text = xmlNode59.Attributes("estado").InnerXml
                                                                                                                                                                                                                                                        End If
                                                                                                                                                                                                                                                    Finally
                                                                                                                                                                                                                                                        Dim enumerator59 As IEnumerator
                                                                                                                                                                                                                                                        flag = (TypeOf enumerator59 Is IDisposable)
                                                                                                                                                                                                                                                        If flag Then
                                                                                                                                                                                                                                                            TryCast(enumerator59, IDisposable).Dispose()
                                                                                                                                                                                                                                                        End If
                                                                                                                                                                                                                                                    End Try
                                                                                                                                                                                                                                                Else
                                                                                                                                                                                                                                                    flag = (Operators.CompareString(dato, "paisr", False) = 0)
                                                                                                                                                                                                                                                    If flag Then
                                                                                                                                                                                                                                                        Dim elementsByTagName60 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:domicilio")
                                                                                                                                                                                                                                                        Try
                                                                                                                                                                                                                                                            Dim enumerator60 As IEnumerator = elementsByTagName60.GetEnumerator()
                                                                                                                                                                                                                                                            If enumerator60.MoveNext() Then
                                                                                                                                                                                                                                                                Dim xmlNode60 As XmlNode = CType(enumerator60.Current, XmlNode)
                                                                                                                                                                                                                                                                text = xmlNode60.Attributes("pais").InnerXml
                                                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                                                        Finally
                                                                                                                                                                                                                                                            Dim enumerator60 As IEnumerator
                                                                                                                                                                                                                                                            flag = (TypeOf enumerator60 Is IDisposable)
                                                                                                                                                                                                                                                            If flag Then
                                                                                                                                                                                                                                                                TryCast(enumerator60, IDisposable).Dispose()
                                                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                                                        End Try
                                                                                                                                                                                                                                                    Else
                                                                                                                                                                                                                                                        flag = (Operators.CompareString(dato, "cpr", False) = 0)
                                                                                                                                                                                                                                                        If flag Then
                                                                                                                                                                                                                                                            Dim elementsByTagName61 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:domicilio")
                                                                                                                                                                                                                                                            Try
                                                                                                                                                                                                                                                                Dim enumerator61 As IEnumerator = elementsByTagName61.GetEnumerator()
                                                                                                                                                                                                                                                                If enumerator61.MoveNext() Then
                                                                                                                                                                                                                                                                    Dim xmlNode61 As XmlNode = CType(enumerator61.Current, XmlNode)
                                                                                                                                                                                                                                                                    text = xmlNode61.Attributes("codigopostal").InnerXml
                                                                                                                                                                                                                                                                End If
                                                                                                                                                                                                                                                            Finally
                                                                                                                                                                                                                                                                Dim enumerator61 As IEnumerator
                                                                                                                                                                                                                                                                flag = (TypeOf enumerator61 Is IDisposable)
                                                                                                                                                                                                                                                                If flag Then
                                                                                                                                                                                                                                                                    TryCast(enumerator61, IDisposable).Dispose()
                                                                                                                                                                                                                                                                End If
                                                                                                                                                                                                                                                            End Try
                                                                                                                                                                                                                                                        Else
                                                                                                                                                                                                                                                            flag = (Operators.CompareString(dato, "impuesto_traslado", False) = 0)
                                                                                                                                                                                                                                                            If flag Then
                                                                                                                                                                                                                                                                Dim elementsByTagName62 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:traslado")
                                                                                                                                                                                                                                                                Try
                                                                                                                                                                                                                                                                    Dim enumerator62 As IEnumerator = elementsByTagName62.GetEnumerator()
                                                                                                                                                                                                                                                                    If enumerator62.MoveNext() Then
                                                                                                                                                                                                                                                                        Dim xmlNode62 As XmlNode = CType(enumerator62.Current, XmlNode)
                                                                                                                                                                                                                                                                        text = xmlNode62.Attributes("impuesto").InnerXml
                                                                                                                                                                                                                                                                    End If
                                                                                                                                                                                                                                                                Finally
                                                                                                                                                                                                                                                                    Dim enumerator62 As IEnumerator
                                                                                                                                                                                                                                                                    flag = (TypeOf enumerator62 Is IDisposable)
                                                                                                                                                                                                                                                                    If flag Then
                                                                                                                                                                                                                                                                        TryCast(enumerator62, IDisposable).Dispose()
                                                                                                                                                                                                                                                                    End If
                                                                                                                                                                                                                                                                End Try
                                                                                                                                                                                                                                                            Else
                                                                                                                                                                                                                                                                flag = (Operators.CompareString(dato, "importe_traslado", False) = 0)
                                                                                                                                                                                                                                                                If flag Then
                                                                                                                                                                                                                                                                    Dim elementsByTagName63 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:traslado")
                                                                                                                                                                                                                                                                    Try
                                                                                                                                                                                                                                                                        Dim enumerator63 As IEnumerator = elementsByTagName63.GetEnumerator()
                                                                                                                                                                                                                                                                        If enumerator63.MoveNext() Then
                                                                                                                                                                                                                                                                            Dim xmlNode63 As XmlNode = CType(enumerator63.Current, XmlNode)
                                                                                                                                                                                                                                                                            text = xmlNode63.Attributes("importe").InnerXml
                                                                                                                                                                                                                                                                        End If
                                                                                                                                                                                                                                                                    Finally
                                                                                                                                                                                                                                                                        Dim enumerator63 As IEnumerator
                                                                                                                                                                                                                                                                        flag = (TypeOf enumerator63 Is IDisposable)
                                                                                                                                                                                                                                                                        If flag Then
                                                                                                                                                                                                                                                                            TryCast(enumerator63, IDisposable).Dispose()
                                                                                                                                                                                                                                                                        End If
                                                                                                                                                                                                                                                                    End Try
                                                                                                                                                                                                                                                                Else
                                                                                                                                                                                                                                                                    flag = (Operators.CompareString(dato, "total_traslado", False) = 0)
                                                                                                                                                                                                                                                                    If flag Then
                                                                                                                                                                                                                                                                        Dim elementsByTagName64 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:impuestos")
                                                                                                                                                                                                                                                                        Try
                                                                                                                                                                                                                                                                            Dim enumerator64 As IEnumerator = elementsByTagName64.GetEnumerator()
                                                                                                                                                                                                                                                                            If enumerator64.MoveNext() Then
                                                                                                                                                                                                                                                                                Dim xmlNode64 As XmlNode = CType(enumerator64.Current, XmlNode)
                                                                                                                                                                                                                                                                                text = xmlNode64.Attributes("totalimpuestostrasladados").InnerXml
                                                                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                                                                        Finally
                                                                                                                                                                                                                                                                            Dim enumerator64 As IEnumerator
                                                                                                                                                                                                                                                                            flag = (TypeOf enumerator64 Is IDisposable)
                                                                                                                                                                                                                                                                            If flag Then
                                                                                                                                                                                                                                                                                TryCast(enumerator64, IDisposable).Dispose()
                                                                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                                                                        End Try
                                                                                                                                                                                                                                                                    Else
                                                                                                                                                                                                                                                                        flag = (Operators.CompareString(dato, "version_cfdi", False) = 0)
                                                                                                                                                                                                                                                                        If flag Then
                                                                                                                                                                                                                                                                            Dim elementsByTagName65 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:comprobante")
                                                                                                                                                                                                                                                                            Try
                                                                                                                                                                                                                                                                                Dim enumerator65 As IEnumerator = elementsByTagName65.GetEnumerator()
                                                                                                                                                                                                                                                                                If enumerator65.MoveNext() Then
                                                                                                                                                                                                                                                                                    Dim xmlNode65 As XmlNode = CType(enumerator65.Current, XmlNode)
                                                                                                                                                                                                                                                                                    text = xmlNode65.Attributes("version").InnerXml
                                                                                                                                                                                                                                                                                End If
                                                                                                                                                                                                                                                                            Finally
                                                                                                                                                                                                                                                                                Dim enumerator65 As IEnumerator
                                                                                                                                                                                                                                                                                flag = (TypeOf enumerator65 Is IDisposable)
                                                                                                                                                                                                                                                                                If flag Then
                                                                                                                                                                                                                                                                                    TryCast(enumerator65, IDisposable).Dispose()
                                                                                                                                                                                                                                                                                End If
                                                                                                                                                                                                                                                                            End Try
                                                                                                                                                                                                                                                                        Else
                                                                                                                                                                                                                                                                            flag = (Operators.CompareString(dato, "moneda", False) = 0)
                                                                                                                                                                                                                                                                            If flag Then
                                                                                                                                                                                                                                                                                Dim elementsByTagName66 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:comprobante")
                                                                                                                                                                                                                                                                                Try
                                                                                                                                                                                                                                                                                    Dim enumerator66 As IEnumerator = elementsByTagName66.GetEnumerator()
                                                                                                                                                                                                                                                                                    If enumerator66.MoveNext() Then
                                                                                                                                                                                                                                                                                        Dim xmlNode66 As XmlNode = CType(enumerator66.Current, XmlNode)
                                                                                                                                                                                                                                                                                        text = xmlNode66.Attributes("moneda").InnerXml
                                                                                                                                                                                                                                                                                    End If
                                                                                                                                                                                                                                                                                Finally
                                                                                                                                                                                                                                                                                    Dim enumerator66 As IEnumerator
                                                                                                                                                                                                                                                                                    flag = (TypeOf enumerator66 Is IDisposable)
                                                                                                                                                                                                                                                                                    If flag Then
                                                                                                                                                                                                                                                                                        TryCast(enumerator66, IDisposable).Dispose()
                                                                                                                                                                                                                                                                                    End If
                                                                                                                                                                                                                                                                                End Try
                                                                                                                                                                                                                                                                            Else
                                                                                                                                                                                                                                                                                flag = (Operators.CompareString(dato, "usocfdi", False) = 0)
                                                                                                                                                                                                                                                                                If flag Then
                                                                                                                                                                                                                                                                                    Dim elementsByTagName67 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:receptor")
                                                                                                                                                                                                                                                                                    Try
                                                                                                                                                                                                                                                                                        Dim enumerator67 As IEnumerator = elementsByTagName67.GetEnumerator()
                                                                                                                                                                                                                                                                                        If enumerator67.MoveNext() Then
                                                                                                                                                                                                                                                                                            Dim xmlNode67 As XmlNode = CType(enumerator67.Current, XmlNode)
                                                                                                                                                                                                                                                                                            text = xmlNode67.Attributes("usocfdi").InnerXml
                                                                                                                                                                                                                                                                                        End If
                                                                                                                                                                                                                                                                                    Catch ex As Exception
                                                                                                                                                                                                                                                                                        Try
                                                                                                                                                                                                                                                                                            Dim enumerator67 As IEnumerator = elementsByTagName67.GetEnumerator()
                                                                                                                                                                                                                                                                                            If enumerator67.MoveNext() Then
                                                                                                                                                                                                                                                                                                Dim xmlNode67 As XmlNode = CType(enumerator67.Current, XmlNode)
                                                                                                                                                                                                                                                                                                text = ""
                                                                                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                                                                                        Finally
                                                                                                                                                                                                                                                                                            Dim enumerator67 As IEnumerator
                                                                                                                                                                                                                                                                                            flag = (TypeOf enumerator67 Is IDisposable)
                                                                                                                                                                                                                                                                                            If flag Then
                                                                                                                                                                                                                                                                                                TryCast(enumerator67, IDisposable).Dispose()
                                                                                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                                                                                        End Try
                                                                                                                                                                                                                                                                                    End Try
                                                                                                                                                                                                                                                                                Else
                                                                                                                                                                                                                                                                                    flag = (Operators.CompareString(dato, "tipo_factor", False) = 0)
                                                                                                                                                                                                                                                                                    If flag Then
                                                                                                                                                                                                                                                                                        Dim elementsByTagName68 As XmlNodeList = xmlDoc.GetElementsByTagName("cfdi:traslado")
                                                                                                                                                                                                                                                                                        Try
                                                                                                                                                                                                                                                                                            Dim enumerator68 As IEnumerator = elementsByTagName68.GetEnumerator()
                                                                                                                                                                                                                                                                                            If enumerator68.MoveNext() Then
                                                                                                                                                                                                                                                                                                Dim xmlNode68 As XmlNode = CType(enumerator68.Current, XmlNode)
                                                                                                                                                                                                                                                                                                text = xmlNode68.Attributes("tipofactor").InnerXml
                                                                                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                                                                                        Catch ex As Exception
                                                                                                                                                                                                                                                                                            Try
                                                                                                                                                                                                                                                                                                Dim enumerator68 As IEnumerator = elementsByTagName68.GetEnumerator()
                                                                                                                                                                                                                                                                                                If enumerator68.MoveNext() Then
                                                                                                                                                                                                                                                                                                    Dim xmlNode68 As XmlNode = CType(enumerator68.Current, XmlNode)
                                                                                                                                                                                                                                                                                                    text = ""
                                                                                                                                                                                                                                                                                                End If
                                                                                                                                                                                                                                                                                            Finally
                                                                                                                                                                                                                                                                                                Dim enumerator68 As IEnumerator
                                                                                                                                                                                                                                                                                                flag = (TypeOf enumerator68 Is IDisposable)
                                                                                                                                                                                                                                                                                                If flag Then
                                                                                                                                                                                                                                                                                                    TryCast(enumerator68, IDisposable).Dispose()
                                                                                                                                                                                                                                                                                                End If
                                                                                                                                                                                                                                                                                            End Try
                                                                                                                                                                                                                                                                                        End Try
                                                                                                                                                                                                                                                                                    End If
                                                                                                                                                                                                                                                                                End If
                                                                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                                                                        End If
                                                                                                                                                                                                                                                                    End If
                                                                                                                                                                                                                                                                End If
                                                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                                                        End If
                                                                                                                                                                                                                                                    End If
                                                                                                                                                                                                                                                End If
                                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                                        End If
                                                                                                                                                                                                                                    End If
                                                                                                                                                                                                                                End If
                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                        End If
                                                                                                                                                                                                                    End If
                                                                                                                                                                                                                End If
                                                                                                                                                                                                            End If
                                                                                                                                                                                                        End If
                                                                                                                                                                                                    End If
                                                                                                                                                                                                End If
                                                                                                                                                                                            End If
                                                                                                                                                                                        End If
                                                                                                                                                                                    End If
                                                                                                                                                                                End If
                                                                                                                                                                            End If
                                                                                                                                                                        End If
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        Console.WriteLine(dato + ": " + text)
        Return text
    End Function

    'Este procedimiento es para Insertar los XML en la tabla //   AXR
    Public Shared Function FG_INSERTAR_FACTURA_XML(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_XML As XML, ByRef VP_ARCHIVO As String) As String
        Dim VP_PARAMETROS As String = ""
        Dim VP_SP As String = ""
        Dim VP_TABLA As New Data.DataTable
        Dim VP_MENSAJE As String = ""
        Try
            VP_PARAMETROS = PP_FORMA.FM_SQL_DATOS_XML(PP_XML)

            VP_ARCHIVO = VP_ARCHIVO

            Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

            VP_SP = Codigo_SQL.FG_SP_Insert(PP_FORMA)

            VP_TABLA = Codigo_SQL.FG_SP_EXECUTE_DATATABLE_XML(PP_BD_Index, VP_SP, VP_PARAMETROS, VP_ARCHIVO)

            VP_MENSAJE = Codigo_LI.FG_LI_CELL_READ(VP_TABLA, 0, "MENSAJE")
            Dim VP_ID = Codigo_LI.FG_LI_CELL_READ(VP_TABLA, 0, "CLAVE")
            If VP_MENSAJE <> "" Then
                Dim VP_TEXTO1 As String = Environment.NewLine + "[EXISTE]   //   " + "[ARCHIVO XML]: " + PP_XML.PP_NOMBRE1.ToUpper + " //  [Serie]: " + PP_XML.XML_SERIE1.ToUpper + " //  [Folio]: " + PP_XML.XML_FOLIO1.ToUpper + " //  [ARCHIVO XML] ya existe."
                PP_FORMA.RT_EVENTOS.SelectionColor = Color.OrangeRed
                PP_FORMA.RT_EVENTOS.SelectedText = VP_TEXTO1
            Else
                Dim VP_TEXTO2 As String = Environment.NewLine + "[ O.K ]   //   " + "[ARCHIVO XML]: " + PP_XML.PP_NOMBRE1.ToUpper + " //  [Serie]: " + PP_XML.XML_SERIE1.ToUpper + " //  [Folio]: " + PP_XML.XML_FOLIO1.ToUpper + " //  [CORRECTA] la carga del [ARCHIVO XML]"
                PP_FORMA.RT_EVENTOS.SelectionColor = Color.Green
                PP_FORMA.RT_EVENTOS.SelectedText = VP_TEXTO2
            End If
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("FG_BT_INSERTAR_FACTURA_XML_CLICK")
        End Try
        Return VP_MENSAJE

    End Function

    'Este procedimiento es para Insertar los XML en la tabla //   AXR
    Public Shared Function FG_INSERTAR_FACTURA_XML(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_XML As XML, ByRef VP_ARCHIVO As String, ByRef PP_CLAVE As Integer) As String
        Dim VP_PARAMETROS As String = ""
        Dim VP_SP As String = ""
        Dim VP_TABLA As New Data.DataTable
        Dim VP_MENSAJE As String = ""
        Try
            VP_PARAMETROS = PP_FORMA.FM_SQL_DATOS_XML(PP_XML)

            VP_ARCHIVO = VP_ARCHIVO

            Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

            VP_SP = Codigo_SQL.FG_SP_Insert(PP_FORMA)

            VP_TABLA = Codigo_SQL.FG_SP_EXECUTE_DATATABLE_XML(PP_BD_Index, VP_SP, VP_PARAMETROS, VP_ARCHIVO)

            VP_MENSAJE = Codigo_LI.FG_LI_CELL_READ(VP_TABLA, 0, "MENSAJE")
            Dim VP_ID = Codigo_LI.FG_LI_CELL_READ(VP_TABLA, 0, "CLAVE")
            PP_CLAVE = VP_ID
            If VP_MENSAJE <> "" Then
                Dim VP_TEXTO1 As String = Environment.NewLine + "[EXISTE]   //   " + "[ARCHIVO XML]: " + PP_XML.PP_NOMBRE1.ToUpper + " //  [Serie]: " + PP_XML.XML_SERIE1.ToUpper + " //  [Folio]: " + PP_XML.XML_FOLIO1.ToUpper + " //  [ARCHIVO XML] ya existe."
                PP_FORMA.RT_EVENTOS.SelectionColor = Color.OrangeRed
                PP_FORMA.RT_EVENTOS.SelectedText = VP_TEXTO1
            Else
                Dim VP_TEXTO2 As String = Environment.NewLine + "[ O.K ]   //   " + "[ARCHIVO XML]: " + PP_XML.PP_NOMBRE1.ToUpper + " //  [Serie]: " + PP_XML.XML_SERIE1.ToUpper + " //  [Folio]: " + PP_XML.XML_FOLIO1.ToUpper + " //  [CORRECTA] la carga del [ARCHIVO XML]"
                PP_FORMA.RT_EVENTOS.SelectionColor = Color.Green
                PP_FORMA.RT_EVENTOS.SelectedText = VP_TEXTO2
            End If
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("FG_BT_INSERTAR_FACTURA_XML_CLICK")
        End Try
        Return VP_MENSAJE
    End Function


    'Código para verificar si existe un proveedor en base al RFC   //   AXR
    Public Shared Function FG_VERIFICAR_RFC_FACTURA_XML(ByRef PP_FORMA As Object, ByRef PP_EMI_RFC As String)
        Dim VP_PARAMETROS As String = ""
        Dim VP_COMODIN_ENTERO As Integer = -1

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, PP_EMI_RFC, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_ENTERO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_ENTERO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_ENTERO, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_COMODIN_ENTERO, True)

        Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = "PG_LI_PROVEEDOR"


        Dim VP_TABLA As Data.DataTable
        VP_TABLA = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(VG_BD_Index, VP_STORED_PROCEDURE, VP_PARAMETROS)

        Return VP_TABLA

    End Function


    'Código para realizar un INSERT de PROVEEDOR con ESTATUS de PREREGISTRO  //   AXR
    Public Shared Function FG_PREREGISTRO_PROVEEDOR(ByRef PP_FORMA As Object, ByRef PP_EMI_RFC As String, ByRef PP_NOMBRE As String)
        Dim VP_PARAMETROS As String = ""
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

        Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

        Dim VP_STORED_PROCEDURE As String
        VP_STORED_PROCEDURE = "PG_IN_PROVEEDOR"


        Dim VP_TABLA As Data.DataTable
        VP_TABLA = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(VG_BD_Index, VP_STORED_PROCEDURE, VP_PARAMETROS)

        Return VP_TABLA

    End Function

End Class


Public Class XML
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