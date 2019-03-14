Imports System
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Drawing.Image
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.PowerPacks.Printing
Imports System.Printing
Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6

Public Class Codigo_Imprimir

#Region "VARIABLES LOCALES"

    Dim VL_PRINTER As Printer = New Printer

    Public Property VL_PRINTER1 As Printer
        Get
            Return VL_PRINTER
        End Get
        Set(value As Printer)
            VL_PRINTER = value
        End Set
    End Property

#End Region

#Region "CONFIGURACIÓN"

    Public Sub PG_FUENTE_BASE()
        'Dim VP_TAMANO_FUENTE As Integer = 9
        'VL_PRINTER.FontSize = VP_TAMANO_FUENTE
        VL_PRINTER1.ScaleWidth = 2159
        VL_PRINTER1.ScaleHeight = 2790
        VL_PRINTER1.FontName = "Courier New"
    End Sub

#End Region

#Region "SUBS PM DIBUJO_POLIZA"

    Public Sub PG_DIBUJO_SECCION_A(ByRef PP_Xcm As Decimal, ByRef PP_Ycm As Decimal, ByRef PP_ANcm As Decimal, ByRef PP_ALcm As Decimal)
        PG_RECTANGULO_CM(PP_Xcm, PP_Ycm, PP_ANcm, PP_ALcm)     'Con esta línea se dibuja el rectángulo principal.
    End Sub

    Public Sub PG_DIBUJO_SECCION_B(ByRef PP_Xcm As Decimal, ByRef PP_Ycm As Decimal, ByRef PP_ANcm As Decimal, ByRef PP_ALcm As Decimal)
        PG_RECTANGULO_CM(PP_Xcm, PP_Ycm, PP_ANcm, PP_ALcm)
    End Sub

    Public Sub PG_DIBUJO_SECCION_C(ByRef PP_Xcm As Decimal, ByRef PP_Ycm As Decimal, ByRef PP_ANcm As Decimal, ByRef PP_ALcm As Decimal)
        PG_RECTANGULO_CM(PP_Xcm, PP_Ycm, PP_ANcm, PP_ALcm)
        PG_RECTANGULO_CM(PP_Xcm, (PP_Ycm + 0.5), PP_ANcm, 1)
        PG_RECTANGULO_CM(PP_Xcm, (PP_Ycm + 1.5), PP_ANcm, 0.5)

        PG_RECTANGULO_CM((PP_Xcm + 5), PP_Ycm, 5, 1.5)
        PG_RECTANGULO_CM((PP_Xcm + 10), PP_Ycm, 5, 1.5)

        PG_RECTANGULO_CM((PP_Xcm + PP_ANcm - 7.5), (PP_Ycm + 1.5), 7.5, (PP_ALcm - 1.5))
    End Sub

    Public Sub PG_DIBUJO_SECCION_D(ByRef PP_Xcm As Decimal, ByRef PP_Ycm As Decimal, ByRef PP_ANcm As Decimal, ByRef PP_ALcm As Decimal)
        PG_RECTANGULO_CM(PP_Xcm, PP_Ycm, PP_ANcm, PP_ALcm)

        PG_RECTANGULO_CM(PP_Xcm, (PP_Ycm + 0.5), PP_ANcm, PP_ALcm - 1.5)         'es de 1.5 / Para cambiar se cambia 1

        PG_RECTANGULO_CM(PP_Xcm, PP_Ycm, 2.5, 10)                       'es de 10 / Para cambiar se cambia 10.5
        PG_RECTANGULO_CM(PP_Xcm + 2.5, PP_Ycm, 2.5, 10)                 'es de 10 / Para cambiar se cambia 10.5

        'PG_RECTANGULO_CM(PP_Xcm + PP_ANcm - 7.5, PP_Ycm, 2.5, 10)           'se quita el tercer cuadro de derecha a izquierda de la sección
        PG_RECTANGULO_CM(PP_Xcm + PP_ANcm - 5, PP_Ycm, 2.5, 10.5)              'es de 10.5 / Para cambiar se cambia 10.5
        PG_RECTANGULO_CM(PP_Xcm + PP_ANcm - 2.5, PP_Ycm, 2.5, 10.5)            'es de 10.5 / Para cambiar se cambia 10.5

    End Sub

    Public Sub PG_DIBUJO_SECCION_E(ByRef PP_Xcm As Decimal, ByRef PP_Ycm As Decimal, ByRef PP_ANcm As Decimal, ByRef PP_ALcm As Decimal)
        PG_RECTANGULO_CM(PP_Xcm, PP_Ycm, PP_ANcm, PP_ALcm)
        PG_RECTANGULO_CM(PP_Xcm, PP_Ycm + 0.5, PP_ANcm, PP_ALcm - 1.5)

        PG_RECTANGULO_CM(PP_Xcm, PP_Ycm, 5, PP_ALcm - 1)

        PG_RECTANGULO_CM(PP_Xcm + 5, PP_Ycm, PP_ANcm - 7.5, PP_ALcm - 1)

        PG_RECTANGULO_CM(PP_Xcm + PP_ANcm - 7.5, PP_Ycm, 2.5, PP_ALcm - 1)
        PG_RECTANGULO_CM(PP_Xcm + PP_ANcm - 5, PP_Ycm, 2.5, PP_ALcm - 1)
        PG_RECTANGULO_CM(PP_Xcm + PP_ANcm - 2.5, PP_Ycm, 2.5, PP_ALcm - 1)
    End Sub

#End Region

#Region "SUBS PM ROTULADO_GUIAS"

    Public Sub PG_ROTULADO_SECCION_COLUMNAS_RENGLONES(ByRef PP_Ncol As Decimal, ByRef PP_Nrow As Decimal, ByRef PP_Texto As String)
        'VL_PRINTER.FontSize = 9
#Region "RENGLONES (88)"
        '--RENGLONES ====================   88  
        PG_TEXTO_CM(1, 1, "1") : PG_TEXTO_CM(1, 2, "2") : PG_TEXTO_CM(1, 3, "3") : PG_TEXTO_CM(1, 4, "4") : PG_TEXTO_CM(1, 5, "5") : PG_TEXTO_CM(1, 6, "6") : PG_TEXTO_CM(1, 7, "7") : PG_TEXTO_CM(1, 8, "8") : PG_TEXTO_CM(1, 9, "9") : PG_TEXTO_CM(1, 10, "10")
        PG_TEXTO_CM(1, 11, "11") : PG_TEXTO_CM(1, 12, "12") : PG_TEXTO_CM(1, 13, "13") : PG_TEXTO_CM(1, 14, "14") : PG_TEXTO_CM(1, 15, "15") : PG_TEXTO_CM(1, 16, "16") : PG_TEXTO_CM(1, 17, "17") : PG_TEXTO_CM(1, 18, "18") : PG_TEXTO_CM(1, 19, "19") : PG_TEXTO_CM(1, 20, "20")
        PG_TEXTO_CM(1, 21, "21") : PG_TEXTO_CM(1, 22, "22") : PG_TEXTO_CM(1, 23, "23") : PG_TEXTO_CM(1, 24, "24") : PG_TEXTO_CM(1, 25, "25") : PG_TEXTO_CM(1, 26, "26") : PG_TEXTO_CM(1, 27, "27") : PG_TEXTO_CM(1, 28, "28") : PG_TEXTO_CM(1, 29, "29") : PG_TEXTO_CM(1, 30, "30")
        PG_TEXTO_CM(1, 31, "31") : PG_TEXTO_CM(1, 32, "32") : PG_TEXTO_CM(1, 33, "33") : PG_TEXTO_CM(1, 34, "34") : PG_TEXTO_CM(1, 35, "35") : PG_TEXTO_CM(1, 36, "36") : PG_TEXTO_CM(1, 37, "37") : PG_TEXTO_CM(1, 38, "38") : PG_TEXTO_CM(1, 39, "39") : PG_TEXTO_CM(1, 40, "40")
        PG_TEXTO_CM(1, 41, "41") : PG_TEXTO_CM(1, 42, "42") : PG_TEXTO_CM(1, 43, "43") : PG_TEXTO_CM(1, 44, "44") : PG_TEXTO_CM(1, 45, "45") : PG_TEXTO_CM(1, 46, "46") : PG_TEXTO_CM(1, 47, "47") : PG_TEXTO_CM(1, 48, "48") : PG_TEXTO_CM(1, 49, "49") : PG_TEXTO_CM(1, 50, "50")
        PG_TEXTO_CM(1, 51, "51") : PG_TEXTO_CM(1, 52, "52") : PG_TEXTO_CM(1, 53, "53") : PG_TEXTO_CM(1, 54, "54") : PG_TEXTO_CM(1, 55, "55") : PG_TEXTO_CM(1, 56, "56") : PG_TEXTO_CM(1, 57, "57") : PG_TEXTO_CM(1, 58, "58") : PG_TEXTO_CM(1, 59, "59") : PG_TEXTO_CM(1, 60, "60")
        PG_TEXTO_CM(1, 61, "61") : PG_TEXTO_CM(1, 62, "62") : PG_TEXTO_CM(1, 63, "63") : PG_TEXTO_CM(1, 64, "64") : PG_TEXTO_CM(1, 65, "65") : PG_TEXTO_CM(1, 66, "66") : PG_TEXTO_CM(1, 67, "67") : PG_TEXTO_CM(1, 68, "68") : PG_TEXTO_CM(1, 69, "69") : PG_TEXTO_CM(1, 70, "70")
        PG_TEXTO_CM(1, 71, "71") : PG_TEXTO_CM(1, 72, "72") : PG_TEXTO_CM(1, 73, "73") : PG_TEXTO_CM(1, 74, "74") : PG_TEXTO_CM(1, 75, "75") : PG_TEXTO_CM(1, 76, "76") : PG_TEXTO_CM(1, 77, "77") : PG_TEXTO_CM(1, 78, "78") : PG_TEXTO_CM(1, 79, "79") : PG_TEXTO_CM(1, 80, "80")
        PG_TEXTO_CM(1, 81, "81") : PG_TEXTO_CM(1, 82, "82") : PG_TEXTO_CM(1, 83, "83") : PG_TEXTO_CM(1, 84, "84") : PG_TEXTO_CM(1, 85, "85") : PG_TEXTO_CM(1, 86, "86") : PG_TEXTO_CM(1, 87, "87") : PG_TEXTO_CM(1, 88, "88")

#End Region

#Region "COLUMNAS (104)"
        '--COLUMNAS ====================    104
        PG_TEXTO_CM(1, 1, "1") : PG_TEXTO_CM(2, 1, "2") : PG_TEXTO_CM(3, 1, "3") : PG_TEXTO_CM(4, 1, "4") : PG_TEXTO_CM(5, 1, "5") : PG_TEXTO_CM(6, 1, "6") : PG_TEXTO_CM(7, 1, "7") : PG_TEXTO_CM(8, 1, "8") : PG_TEXTO_CM(9, 1, "9") : PG_TEXTO_CM(10, 1, "0")
        PG_TEXTO_CM(11, 1, "1") : PG_TEXTO_CM(12, 1, "2") : PG_TEXTO_CM(13, 1, "3") : PG_TEXTO_CM(14, 1, "4") : PG_TEXTO_CM(15, 1, "5") : PG_TEXTO_CM(16, 1, "6") : PG_TEXTO_CM(17, 1, "7") : PG_TEXTO_CM(18, 1, "8") : PG_TEXTO_CM(19, 1, "9") : PG_TEXTO_CM(20, 1, "0")
        PG_TEXTO_CM(21, 1, "1") : PG_TEXTO_CM(22, 1, "2") : PG_TEXTO_CM(23, 1, "3") : PG_TEXTO_CM(24, 1, "4") : PG_TEXTO_CM(25, 1, "5") : PG_TEXTO_CM(26, 1, "6") : PG_TEXTO_CM(27, 1, "7") : PG_TEXTO_CM(28, 1, "8") : PG_TEXTO_CM(29, 1, "9") : PG_TEXTO_CM(30, 1, "0")
        PG_TEXTO_CM(31, 1, "1") : PG_TEXTO_CM(32, 1, "2") : PG_TEXTO_CM(33, 1, "3") : PG_TEXTO_CM(34, 1, "4") : PG_TEXTO_CM(35, 1, "5") : PG_TEXTO_CM(36, 1, "6") : PG_TEXTO_CM(37, 1, "7") : PG_TEXTO_CM(38, 1, "8") : PG_TEXTO_CM(39, 1, "9") : PG_TEXTO_CM(40, 1, "0")
        PG_TEXTO_CM(41, 1, "1") : PG_TEXTO_CM(42, 1, "2") : PG_TEXTO_CM(43, 1, "3") : PG_TEXTO_CM(44, 1, "4") : PG_TEXTO_CM(45, 1, "5") : PG_TEXTO_CM(46, 1, "6") : PG_TEXTO_CM(47, 1, "7") : PG_TEXTO_CM(48, 1, "8") : PG_TEXTO_CM(49, 1, "9") : PG_TEXTO_CM(50, 1, "0")
        PG_TEXTO_CM(51, 1, "1") : PG_TEXTO_CM(52, 1, "2") : PG_TEXTO_CM(53, 1, "3") : PG_TEXTO_CM(54, 1, "4") : PG_TEXTO_CM(55, 1, "5") : PG_TEXTO_CM(56, 1, "6") : PG_TEXTO_CM(57, 1, "7") : PG_TEXTO_CM(58, 1, "8") : PG_TEXTO_CM(59, 1, "9") : PG_TEXTO_CM(60, 1, "0")
        PG_TEXTO_CM(61, 1, "1") : PG_TEXTO_CM(62, 1, "2") : PG_TEXTO_CM(63, 1, "3") : PG_TEXTO_CM(64, 1, "4") : PG_TEXTO_CM(65, 1, "5") : PG_TEXTO_CM(66, 1, "6") : PG_TEXTO_CM(67, 1, "7") : PG_TEXTO_CM(68, 1, "8") : PG_TEXTO_CM(69, 1, "9") : PG_TEXTO_CM(70, 1, "0")
        PG_TEXTO_CM(71, 1, "1") : PG_TEXTO_CM(72, 1, "2") : PG_TEXTO_CM(73, 1, "3") : PG_TEXTO_CM(74, 1, "4") : PG_TEXTO_CM(75, 1, "5") : PG_TEXTO_CM(76, 1, "6") : PG_TEXTO_CM(77, 1, "7") : PG_TEXTO_CM(78, 1, "8") : PG_TEXTO_CM(79, 1, "9") : PG_TEXTO_CM(80, 1, "0")
        PG_TEXTO_CM(81, 1, "1") : PG_TEXTO_CM(82, 1, "2") : PG_TEXTO_CM(83, 1, "3") : PG_TEXTO_CM(84, 1, "4") : PG_TEXTO_CM(85, 1, "5") : PG_TEXTO_CM(86, 1, "6") : PG_TEXTO_CM(87, 1, "7") : PG_TEXTO_CM(88, 1, "8") : PG_TEXTO_CM(89, 1, "9") : PG_TEXTO_CM(90, 1, "0")
        PG_TEXTO_CM(91, 1, "1") : PG_TEXTO_CM(92, 1, "2") : PG_TEXTO_CM(93, 1, "3") : PG_TEXTO_CM(94, 1, "4") : PG_TEXTO_CM(95, 1, "5") : PG_TEXTO_CM(96, 1, "6") : PG_TEXTO_CM(97, 1, "7") : PG_TEXTO_CM(98, 1, "8") : PG_TEXTO_CM(99, 1, "9") : PG_TEXTO_CM(100, 1, "0")
        PG_TEXTO_CM(101, 1, "1") : PG_TEXTO_CM(102, 1, "2") : PG_TEXTO_CM(103, 1, "3") : PG_TEXTO_CM(104, 1, "4")
#End Region
    End Sub

#End Region

#Region "SUBS_PM ESCALAS"

    Public Sub PG_RECTANGULO_CM(ByRef PP_Xcm As Decimal, ByRef PP_Ycm As Decimal, ByRef PP_ANcm As Decimal, ByRef PP_ALcm As Decimal)
        Dim VP_X1, VP_Y1, VP_X2, VP_Y2 As Decimal
        Try
            VP_X1 = (2120 / 21.5) * PP_Xcm
            VP_Y1 = (2760 / 27) * PP_Ycm

            VP_X2 = (2120 / 21.5) * PP_ANcm
            VP_Y2 = (2760 / 27) * PP_ALcm

            VP_X2 = VP_X2 + VP_X1
            VP_Y2 = VP_Y2 + VP_Y1

            VL_PRINTER1.Line(VP_X1, VP_Y1, VP_X2, VP_Y2, 1, True, False)
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_RECTANGULO_CM")
        End Try
    End Sub

    Public Sub PG_TEXTO_CM(ByRef PP_Ncol As Decimal, ByRef PP_Nrow As Decimal, ByRef PP_Texto As String)
        Dim VP_X1, VP_Y1 As Decimal
        Try
            VP_X1 = ((2120 / 21.5) * (PP_Ncol * 0.2)) + ((2120 / 21.5) * (0.4))
            'VP_Y1 = (2760 / 27) * (PP_Nrow * 0.5)                              'Con esta medida el renglón queda más grande
            VP_Y1 = (2760 / 27) * (PP_Nrow * 0.3) + ((2120 / 21.5) * (0.2))

            VL_PRINTER1.CurrentX = VP_X1 : VL_PRINTER1.CurrentY = VP_Y1
            VL_PRINTER1.Print(PP_Texto)
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_TEXTO_CM")
        End Try
    End Sub

#End Region

End Class