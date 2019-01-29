Imports System
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Drawing.Image
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.PowerPacks.Printing
Imports System.Printing
Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6

Public Class FO_POLIZA_CHEQUE

#Region "VARIABLES Y CONSTANTES MODULARES"
    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0
#End Region

#Region "VARIABLES LOCALES"

    Public VL_PRINTER As Printer = New Printer
    Public VM_RP_ID_DOCUMENTO, VM_RP_ID_REPORTE, VM_RP_CHEQUE_FECHA, VM_RP_CHEQUE_BENEFICIARIO,
    VM_RP_CHEQUE_MONTO, VM_RP_CHEQUE_MONTO_LETRAS, VM_RP_CHEQUE_LEYENDA_ABONO,
    VM_ID_REPORTE, VM_RP_BENEFICIARIO, VM_RP_BANCO, VM_RP_CUENTA_BANCARIA, VM_RP_CONCEPTO,
    VM_RP_CONCEPTO_BANCO, VM_RP_MONTO_BANCO,
    VM_RP_CUENTA, VM_RP_K_TRASPASO, VM_RP_MONTO As String

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_OBTENER_DATOS_POLIZA(ByRef PP_TABLA As DataTable, ByVal PP_ROW As Integer, ByVal PP_COL_NOMBRE As String) As String
        Dim VP_DATO As String = ""
        VP_DATO = PP_TABLA.Rows(PP_ROW).Item(PP_COL_NOMBRE).ToString
        Return VP_DATO
    End Function

#End Region

#Region "SUB_PM_INIT"
    Public Sub PM_FO_SHOW(ByRef PP_NOMBRE_TABLA As String, ByVal PP_ID_BASE_DE_DATOS As String)
        VM_NOMBRE_TABLA = PP_NOMBRE_TABLA
        VM_ID_BASE_DE_DATOS = PP_ID_BASE_DE_DATOS
        Me.Show()
    End Sub
#End Region

#Region "SUBS_PM"

#Region "DIBUJO_POLIZA"

    Public Sub PM_DIBUJO_SECCION_A(ByRef PP_Xcm As Decimal, ByRef PP_Ycm As Decimal, ByRef PP_ANcm As Decimal, ByRef PP_ALcm As Decimal)

        PM_RECTANGULO_CM(PP_Xcm, PP_Ycm, PP_ANcm, PP_ALcm)

    End Sub

    Public Sub PM_DIBUJO_SECCION_B(ByRef PP_Xcm As Decimal, ByRef PP_Ycm As Decimal, ByRef PP_ANcm As Decimal, ByRef PP_ALcm As Decimal)

        PM_RECTANGULO_CM(PP_Xcm, PP_Ycm, PP_ANcm, PP_ALcm)

    End Sub

    Public Sub PM_DIBUJO_SECCION_C(ByRef PP_Xcm As Decimal, ByRef PP_Ycm As Decimal, ByRef PP_ANcm As Decimal, ByRef PP_ALcm As Decimal)

        PM_RECTANGULO_CM(PP_Xcm, PP_Ycm, PP_ANcm, PP_ALcm)
        PM_RECTANGULO_CM(PP_Xcm, (PP_Ycm + 0.5), PP_ANcm, 1)
        PM_RECTANGULO_CM(PP_Xcm, (PP_Ycm + 1.5), PP_ANcm, 0.5)

        PM_RECTANGULO_CM((PP_Xcm + 5), PP_Ycm, 5, 1.5)
        PM_RECTANGULO_CM((PP_Xcm + 10), PP_Ycm, 5, 1.5)

        PM_RECTANGULO_CM((PP_Xcm + PP_ANcm - 7.5), (PP_Ycm + 1.5), 7.5, (PP_ALcm - 1.5))

    End Sub

    Public Sub PM_DIBUJO_SECCION_D(ByRef PP_Xcm As Decimal, ByRef PP_Ycm As Decimal, ByRef PP_ANcm As Decimal, ByRef PP_ALcm As Decimal)
        PM_RECTANGULO_CM(PP_Xcm, PP_Ycm, PP_ANcm, PP_ALcm)

        PM_RECTANGULO_CM(PP_Xcm, (PP_Ycm + 0.5), PP_ANcm, PP_ALcm - 1.5)         'es de 1.5 / Para cambiar se cambia 1

        PM_RECTANGULO_CM(PP_Xcm, PP_Ycm, 2.5, 10)                       'es de 10 / Para cambiar se cambia 10.5
        PM_RECTANGULO_CM(PP_Xcm + 2.5, PP_Ycm, 2.5, 10)                 'es de 10 / Para cambiar se cambia 10.5

        'PM_RECTANGULO_CM(PP_Xcm + PP_ANcm - 7.5, PP_Ycm, 2.5, 10)           'se quita el tercer cuadro de derecha a izquierda de la sección
        PM_RECTANGULO_CM(PP_Xcm + PP_ANcm - 5, PP_Ycm, 2.5, 10.5)              'es de 10.5 / Para cambiar se cambia 10.5
        PM_RECTANGULO_CM(PP_Xcm + PP_ANcm - 2.5, PP_Ycm, 2.5, 10.5)            'es de 10.5 / Para cambiar se cambia 10.5

    End Sub

    Public Sub PM_DIBUJO_SECCION_E(ByRef PP_Xcm As Decimal, ByRef PP_Ycm As Decimal, ByRef PP_ANcm As Decimal, ByRef PP_ALcm As Decimal)
        PM_RECTANGULO_CM(PP_Xcm, PP_Ycm, PP_ANcm, PP_ALcm)
        PM_RECTANGULO_CM(PP_Xcm, PP_Ycm + 0.5, PP_ANcm, PP_ALcm - 1.5)

        PM_RECTANGULO_CM(PP_Xcm, PP_Ycm, 5, PP_ALcm - 1)

        PM_RECTANGULO_CM(PP_Xcm + 5, PP_Ycm, PP_ANcm - 7.5, PP_ALcm - 1)

        PM_RECTANGULO_CM(PP_Xcm + PP_ANcm - 7.5, PP_Ycm, 2.5, PP_ALcm - 1)
        PM_RECTANGULO_CM(PP_Xcm + PP_ANcm - 5, PP_Ycm, 2.5, PP_ALcm - 1)
        PM_RECTANGULO_CM(PP_Xcm + PP_ANcm - 2.5, PP_Ycm, 2.5, PP_ALcm - 1)

    End Sub

#End Region

#Region "ROTULADO_POLIZA"

    Public Sub PM_ROTULADO_SECCION_A(ByRef PP_Ncol As Decimal, ByRef PP_Nrow As Decimal, ByRef PP_Texto As String)
        VL_PRINTER.FontSize = 9
        'SECCIÓN A    //  DATOS
        '--========================================================
        PM_TEXTO_CM(93, 2, VM_RP_ID_DOCUMENTO)
        '--========================================================

    End Sub

    Public Sub PM_ROTULADO_SECCION_B(ByRef PP_Ncol As Decimal, ByRef PP_Nrow As Decimal, ByRef PP_Texto As String)
        VL_PRINTER.FontSize = 9
        'SECCION B    //  DATOS
        '--========================================================
        PM_TEXTO_CM(14, 12, VM_RP_CHEQUE_LEYENDA_ABONO)
        PM_TEXTO_CM(53, 13, VM_RP_CHEQUE_FECHA)
        PM_TEXTO_CM(4, 14, VM_RP_CHEQUE_BENEFICIARIO)
        PM_TEXTO_CM(59, 15, VM_RP_CHEQUE_MONTO)
        PM_TEXTO_CM(4, 16, VM_RP_CHEQUE_MONTO_LETRAS)
        '--========================================================

    End Sub

    Public Sub PM_ROTULADO_SECCION_C(ByRef PP_Ncol As Decimal, ByRef PP_Nrow As Decimal, ByRef PP_Texto As String)
        VL_PRINTER.FontSize = 9
        'SECCIÓN C    //  ENCABEZADOS
        '--========================================================
        PM_TEXTO_CM(6, 31, "BENEFICIARIO")
        PM_TEXTO_CM(34, 31, "BANCO")
        PM_TEXTO_CM(58, 31, "NÚM. CUENTA")
        PM_TEXTO_CM(29, 36, "CONCEPTO")
        '--========================================================

        'SECCIÓN C    //  DATOS
        '--========================================================
        PM_TEXTO_CM(4, 34, VM_RP_BENEFICIARIO)
        PM_TEXTO_CM(30, 34, VM_RP_BANCO)
        PM_TEXTO_CM(52, 34, VM_RP_CUENTA_BANCARIA)
        PM_TEXTO_CM(4, 39, VM_RP_CONCEPTO)
        '--========================================================

    End Sub

    Public Sub PM_ROTULADO_SECCION_D(ByRef PP_Ncol As Decimal, ByRef PP_Nrow As Decimal, ByRef PP_Texto As String)
        VL_PRINTER.FontSize = 9
        'SECCIÓN D    //  ENCABEZADOS
        '--========================================================
        PM_TEXTO_CM(13, 46, "#ID_DETALLE")
        PM_TEXTO_CM(46, 46, "CONCEPTO")
        PM_TEXTO_CM(83, 46, "$ DETALLE")
        PM_TEXTO_CM(94, 46, "$ TOTAL")
        '--========================================================

        'SECCIÓN D    //  DATOS
        '--=============================================================================
        PM_TEXTO_CM(26, 48, VM_RP_CONCEPTO_BANCO)
        PM_TEXTO_CM(93, 48, VM_RP_MONTO_BANCO)
        '--=============================================================================

    End Sub

    Public Sub PM_ROTULADO_SECCION_E(ByRef PP_Ncol As Decimal, ByRef PP_Nrow As Decimal, ByRef PP_Texto As String)
        VL_PRINTER.FontSize = 9
        'SECCIÓN E    //  DATOS
        '--========================================================
        PM_TEXTO_CM(3, 87, VM_ID_REPORTE)
        '--========================================================

    End Sub

    Public Sub PM_ROTULADO_SECCION_COLUMNAS_RENGLONES(ByRef PP_Ncol As Decimal, ByRef PP_Nrow As Decimal, ByRef PP_Texto As String)

        VL_PRINTER.FontSize = 9

#Region "RENGLONES"
        '--RENGLONES ====================   
        PM_TEXTO_CM(1, 1, "1")
        PM_TEXTO_CM(1, 2, "2")
        PM_TEXTO_CM(1, 3, "3")
        PM_TEXTO_CM(1, 4, "4")
        PM_TEXTO_CM(1, 5, "5")
        PM_TEXTO_CM(1, 6, "6")
        PM_TEXTO_CM(1, 7, "7")
        PM_TEXTO_CM(1, 8, "8")
        PM_TEXTO_CM(1, 9, "9")

        PM_TEXTO_CM(1, 10, "10")
        PM_TEXTO_CM(1, 11, "11")
        PM_TEXTO_CM(1, 12, "12")
        PM_TEXTO_CM(1, 13, "13")
        PM_TEXTO_CM(1, 14, "14")
        PM_TEXTO_CM(1, 15, "15")
        PM_TEXTO_CM(1, 16, "16")
        PM_TEXTO_CM(1, 17, "17")
        PM_TEXTO_CM(1, 18, "18")
        PM_TEXTO_CM(1, 19, "19")

        PM_TEXTO_CM(1, 20, "20")
        PM_TEXTO_CM(1, 21, "21")
        PM_TEXTO_CM(1, 22, "22")
        PM_TEXTO_CM(1, 23, "23")
        PM_TEXTO_CM(1, 24, "24")
        PM_TEXTO_CM(1, 25, "25")
        PM_TEXTO_CM(1, 26, "26")
        PM_TEXTO_CM(1, 27, "27")
        PM_TEXTO_CM(1, 28, "28")
        PM_TEXTO_CM(1, 29, "29")

        PM_TEXTO_CM(1, 30, "30")
        PM_TEXTO_CM(1, 31, "31")
        PM_TEXTO_CM(1, 32, "32")
        PM_TEXTO_CM(1, 33, "33")
        PM_TEXTO_CM(1, 34, "34")
        PM_TEXTO_CM(1, 35, "35")
        PM_TEXTO_CM(1, 36, "36")
        PM_TEXTO_CM(1, 37, "37")
        PM_TEXTO_CM(1, 38, "38")
        PM_TEXTO_CM(1, 39, "39")

        PM_TEXTO_CM(1, 40, "40")
        PM_TEXTO_CM(1, 41, "41")
        PM_TEXTO_CM(1, 42, "42")
        PM_TEXTO_CM(1, 43, "43")
        PM_TEXTO_CM(1, 44, "44")
        PM_TEXTO_CM(1, 45, "45")
        PM_TEXTO_CM(1, 46, "46")
        PM_TEXTO_CM(1, 47, "47")
        PM_TEXTO_CM(1, 48, "48")
        PM_TEXTO_CM(1, 49, "49")

        PM_TEXTO_CM(1, 50, "50")
        PM_TEXTO_CM(1, 51, "51")
        PM_TEXTO_CM(1, 52, "52")
        PM_TEXTO_CM(1, 53, "53")

        PM_TEXTO_CM(1, 54, "54") '54
        PM_TEXTO_CM(1, 55, "55") '55
        PM_TEXTO_CM(1, 56, "56") '56
        PM_TEXTO_CM(1, 57, "57") '57
        PM_TEXTO_CM(1, 58, "58") '58
        PM_TEXTO_CM(1, 59, "59") '59
        PM_TEXTO_CM(1, 60, "60") '60
        PM_TEXTO_CM(1, 61, "61") '61
        PM_TEXTO_CM(1, 62, "62") '62
        PM_TEXTO_CM(1, 63, "63") '63
        PM_TEXTO_CM(1, 64, "64") '64
        PM_TEXTO_CM(1, 65, "65") '65
        PM_TEXTO_CM(1, 66, "66") '66
        PM_TEXTO_CM(1, 67, "67") '67
        PM_TEXTO_CM(1, 68, "68") '68
        PM_TEXTO_CM(1, 69, "69") '69
        PM_TEXTO_CM(1, 70, "70") '70
        PM_TEXTO_CM(1, 71, "71") '71
        PM_TEXTO_CM(1, 72, "72") '72
        PM_TEXTO_CM(1, 73, "73") '73
        PM_TEXTO_CM(1, 74, "74") '74
        PM_TEXTO_CM(1, 75, "75") '75
        PM_TEXTO_CM(1, 76, "76") '76
        PM_TEXTO_CM(1, 77, "77") '77
        PM_TEXTO_CM(1, 78, "78") '78
        PM_TEXTO_CM(1, 79, "79") '79
        PM_TEXTO_CM(1, 80, "80") '80
        PM_TEXTO_CM(1, 81, "81") '81
        PM_TEXTO_CM(1, 82, "82") '82
        PM_TEXTO_CM(1, 83, "83") '83
        PM_TEXTO_CM(1, 84, "84") '84
        PM_TEXTO_CM(1, 85, "85") '85
        PM_TEXTO_CM(1, 86, "86") '86
        PM_TEXTO_CM(1, 87, "87") '87
        PM_TEXTO_CM(1, 88, "88") '88
        'PM_TEXTO_CM(1, 89, "9") '89
        'PM_TEXTO_CM(1, 90, "0") '90
        'PM_TEXTO_CM(1, 91, "1") '91

#End Region

#Region "COLUMNAS"
        '--COLUMNAS ====================
        PM_TEXTO_CM(1, 1, "1")
        PM_TEXTO_CM(2, 1, "2")
        PM_TEXTO_CM(3, 1, "3")
        PM_TEXTO_CM(4, 1, "4")
        PM_TEXTO_CM(5, 1, "5")
        PM_TEXTO_CM(6, 1, "6")
        PM_TEXTO_CM(7, 1, "7")
        PM_TEXTO_CM(8, 1, "8")
        PM_TEXTO_CM(9, 1, "9")
        PM_TEXTO_CM(10, 1, "0") '10
        PM_TEXTO_CM(11, 1, "1") '11
        PM_TEXTO_CM(12, 1, "2") '12
        PM_TEXTO_CM(13, 1, "3") '13
        PM_TEXTO_CM(14, 1, "4") '14
        PM_TEXTO_CM(15, 1, "5") '15
        PM_TEXTO_CM(16, 1, "6") '16
        PM_TEXTO_CM(17, 1, "7") '17
        PM_TEXTO_CM(18, 1, "8") '18
        PM_TEXTO_CM(19, 1, "9") '19
        PM_TEXTO_CM(20, 1, "0") '20
        PM_TEXTO_CM(21, 1, "1") '21
        PM_TEXTO_CM(22, 1, "2") '22
        PM_TEXTO_CM(23, 1, "3") '23
        PM_TEXTO_CM(24, 1, "4") '24
        PM_TEXTO_CM(25, 1, "5") '25
        PM_TEXTO_CM(26, 1, "6") '26
        PM_TEXTO_CM(27, 1, "7") '27
        PM_TEXTO_CM(28, 1, "8") '28
        PM_TEXTO_CM(29, 1, "9") '29
        PM_TEXTO_CM(30, 1, "0") '30
        PM_TEXTO_CM(31, 1, "1") '31
        PM_TEXTO_CM(32, 1, "2") '32
        PM_TEXTO_CM(33, 1, "3") '33
        PM_TEXTO_CM(34, 1, "4") '34
        PM_TEXTO_CM(35, 1, "5") '35
        PM_TEXTO_CM(36, 1, "6") '36
        PM_TEXTO_CM(37, 1, "7") '37
        PM_TEXTO_CM(38, 1, "8") '38
        PM_TEXTO_CM(39, 1, "9") '39
        PM_TEXTO_CM(40, 1, "0") '40
        PM_TEXTO_CM(41, 1, "1") '41
        PM_TEXTO_CM(42, 1, "2") '42
        PM_TEXTO_CM(43, 1, "3") '43
        PM_TEXTO_CM(44, 1, "4") '44
        PM_TEXTO_CM(45, 1, "5") '45
        PM_TEXTO_CM(46, 1, "6") '46
        PM_TEXTO_CM(47, 1, "7") '47
        PM_TEXTO_CM(48, 1, "8") '48
        PM_TEXTO_CM(49, 1, "9") '49
        PM_TEXTO_CM(50, 1, "0") '50
        PM_TEXTO_CM(51, 1, "1") '51
        PM_TEXTO_CM(52, 1, "2") '52
        PM_TEXTO_CM(53, 1, "3") '53
        PM_TEXTO_CM(54, 1, "4") '54
        PM_TEXTO_CM(55, 1, "5") '55
        PM_TEXTO_CM(56, 1, "6") '56
        PM_TEXTO_CM(57, 1, "7") '57
        PM_TEXTO_CM(58, 1, "8") '58
        PM_TEXTO_CM(59, 1, "9") '59
        PM_TEXTO_CM(60, 1, "0") '60
        PM_TEXTO_CM(61, 1, "1") '61
        PM_TEXTO_CM(62, 1, "2") '62
        PM_TEXTO_CM(63, 1, "3") '63
        PM_TEXTO_CM(64, 1, "4") '64
        PM_TEXTO_CM(65, 1, "5") '65
        PM_TEXTO_CM(66, 1, "6") '66
        PM_TEXTO_CM(67, 1, "7") '67
        PM_TEXTO_CM(68, 1, "8") '68
        PM_TEXTO_CM(69, 1, "9") '69
        PM_TEXTO_CM(70, 1, "0") '70
        PM_TEXTO_CM(71, 1, "1") '71
        PM_TEXTO_CM(72, 1, "2") '72
        PM_TEXTO_CM(73, 1, "3") '73
        PM_TEXTO_CM(74, 1, "4") '74
        PM_TEXTO_CM(75, 1, "5") '75
        PM_TEXTO_CM(76, 1, "6") '76
        PM_TEXTO_CM(77, 1, "7") '77
        PM_TEXTO_CM(78, 1, "8") '78
        PM_TEXTO_CM(79, 1, "9") '79
        PM_TEXTO_CM(80, 1, "0") '80
        PM_TEXTO_CM(81, 1, "1") '81
        PM_TEXTO_CM(82, 1, "2") '82
        PM_TEXTO_CM(83, 1, "3") '83
        PM_TEXTO_CM(84, 1, "4") '84
        PM_TEXTO_CM(85, 1, "5") '85
        PM_TEXTO_CM(86, 1, "6") '86
        PM_TEXTO_CM(87, 1, "7") '87
        PM_TEXTO_CM(88, 1, "8") '88
        PM_TEXTO_CM(89, 1, "9") '89
        PM_TEXTO_CM(90, 1, "0") '90
        PM_TEXTO_CM(91, 1, "1") '91
        PM_TEXTO_CM(92, 1, "2") '92
        PM_TEXTO_CM(93, 1, "3") '93
        PM_TEXTO_CM(94, 1, "4") '94
#End Region

    End Sub

#End Region

    Public Sub PM_RECTANGULO_CM(ByRef PP_Xcm As Decimal, ByRef PP_Ycm As Decimal, ByRef PP_ANcm As Decimal, ByRef PP_ALcm As Decimal)
        Dim VP_X1, VP_Y1, VP_X2, VP_Y2 As Decimal

        VP_X1 = (2120 / 21.5) * PP_Xcm
        VP_Y1 = (2760 / 27) * PP_Ycm

        VP_X2 = (2120 / 21.5) * PP_ANcm
        VP_Y2 = (2760 / 27) * PP_ALcm

        VP_X2 = VP_X2 + VP_X1
        VP_Y2 = VP_Y2 + VP_Y1

        VL_PRINTER.Line(VP_X1, VP_Y1, VP_X2, VP_Y2, 1, True, False)

    End Sub

    Public Sub PM_TEXTO_CM(ByRef PP_Ncol As Decimal, ByRef PP_Nrow As Decimal, ByRef PP_Texto As String)
        Dim VP_X1, VP_Y1 As Decimal

        VP_X1 = ((2120 / 21.5) * (PP_Ncol * 0.2)) + ((2120 / 21.5) * (0.4))
        'VP_Y1 = (2760 / 27) * (PP_Nrow * 0.5)
        VP_Y1 = (2760 / 27) * (PP_Nrow * 0.3) + ((2120 / 21.5) * (0.2))

        VL_PRINTER.CurrentX = VP_X1 : VL_PRINTER.CurrentY = VP_Y1
        VL_PRINTER.Print(PP_Texto)

    End Sub

    Public Sub PM_FUENTE_BASE()
        VL_PRINTER.ScaleWidth = 2159
        VL_PRINTER.ScaleHeight = 2790
        VL_PRINTER.FontName = "Courier New"
    End Sub

    Private Sub PM_BT_IMPRIMIR_CLICK()
        PM_FUENTE_BASE()
        'VL_PRINTER.DocumentName = DateTime.Now.ToString("dd/mm/yyyy") + "POLIZA_CHEQUE"

        '--======================================
        PM_DIBUJO_SECCION_A(0.5, 0.5, 21, 25)
        PM_DIBUJO_SECCION_B(0.5, 2.5, 21, 7)
        PM_DIBUJO_SECCION_C(0.5, 9.5, 21, 4.5)
        PM_DIBUJO_SECCION_D(0.5, 14, 21, 11)
        PM_DIBUJO_SECCION_E(0.5, 25, 21, 2)

        '--======================================
        PM_ROTULADO_SECCION_A(0, 0, "")
        PM_ROTULADO_SECCION_B(0, 0, "")
        PM_ROTULADO_SECCION_C(0, 0, "")
        PM_ROTULADO_SECCION_D(0, 0, "")
        PM_ROTULADO_SECCION_E(0, 0, "")
        PM_ROTULADO_SECCION_COLUMNAS_RENGLONES(0, 0, "")
        '--======================================
        VL_PRINTER.EndDoc()
    End Sub

    Public Sub PG_RP_003_POLIZA_CHEQUE(ByVal PP_ID As String)
        PG_SK_RP_003_POLIZA_CHEQUE("[PG_RP_003_POLIZA_CHEQUE]", PP_ID, 0)
        PG_SK_RP_003_POLIZA_CHEQUE("[PG_RP_003_POLIZA_CHEQUE_DETALLE]", PP_ID, 1)

    End Sub

    Public Sub PG_SK_RP_003_POLIZA_CHEQUE(ByVal PP_SP As String, ByVal PP_PARAMETROS As String, ByRef PP_BANDERA As Integer)
        Me.Cursor = Cursors.WaitCursor
        Dim VP_PARAMETROS As String = PP_PARAMETROS

        Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
        Dim VP_STORED_PROCEDURE As String = PP_SP

        Dim VP_TABLA As Data.DataTable
        VP_TABLA = Codigo_CON.FG_SP_EXECUTE_DATATABLE(VM_ID_BASE_DE_DATOS, VP_STORED_PROCEDURE, VP_PARAMETROS)

        If PP_BANDERA = 0 Then
            PG_CARGAR_POLIZA_CHEQUE(VP_TABLA)
        Else
            PG_CARGAR_POLIZA_CHEQUE_DETALLE(VP_TABLA)
        End If

    End Sub

    Public Sub PG_CARGAR_POLIZA_CHEQUE(ByRef PP_TABLA As DataTable)
        'SECCIÓN A
        '--=============================================================================
        VM_RP_ID_DOCUMENTO = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_ID_DOCUMENTO")

        'SECCIÓN B
        '--=============================================================================
        VM_RP_CHEQUE_FECHA = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_CHEQUE_FECHA")
        VM_RP_CHEQUE_BENEFICIARIO = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_CHEQUE_BENEFICIARIO")
        VM_RP_CHEQUE_MONTO = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_CHEQUE_MONTO")
        VM_RP_CHEQUE_MONTO_LETRAS = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_CHEQUE_MONTO_LETRAS")
        VM_RP_CHEQUE_LEYENDA_ABONO = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_CHEQUE_LEYENDA_ABONO")

        'SECCIÓN C
        '--=============================================================================
        VM_ID_REPORTE = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_ID_REPORTE")
        VM_RP_BENEFICIARIO = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_BENEFICIARIO")
        VM_RP_BANCO = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_BANCO")
        VM_RP_CUENTA_BANCARIA = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_CUENTA_BANCARIA")
        VM_RP_CONCEPTO = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_CONCEPTO")

        'SECCIÓN D
        '--=============================================================================
        VM_RP_CONCEPTO_BANCO = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_CONCEPTO_BANCO")
        VM_RP_MONTO_BANCO = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_MONTO_BANCO")

        'SECCIÓN E
        '--=============================================================================
        VM_ID_REPORTE = FM_OBTENER_DATOS_POLIZA(PP_TABLA, 0, "RP_ID_REPORTE")
    End Sub

    Public Sub PG_CARGAR_POLIZA_CHEQUE_DETALLE(ByVal PP_TABLA As DataTable)
        PM_FUENTE_BASE()
        'VL_PRINTER.FontSize = 9
        Dim VP_COL, VP_COL2, VP_COL3, VP_ROW, VP_CONTA As Integer
        VP_COL = 14 : VP_COL2 = 26 : VP_COL3 = 81 : VP_ROW = 50 : VP_CONTA = 0

        For Each VP_ROW_DATA As DataRow In PP_TABLA.Rows
            VM_RP_K_TRASPASO = FM_OBTENER_DATOS_POLIZA(PP_TABLA, VP_CONTA, "RP_K_TRASPASO")
            VM_RP_CUENTA = FM_OBTENER_DATOS_POLIZA(PP_TABLA, VP_CONTA, "RP_CUENTA")
            VM_RP_MONTO = FM_OBTENER_DATOS_POLIZA(PP_TABLA, VP_CONTA, "RP_MONTO")

            PM_TEXTO_CM(VP_COL, VP_ROW, VM_RP_K_TRASPASO)
            PM_TEXTO_CM(VP_COL2, VP_ROW, VM_RP_CUENTA)
            PM_TEXTO_CM(VP_COL3, VP_ROW, VM_RP_MONTO)

            VP_ROW = VP_ROW + 1 : VP_CONTA = VP_CONTA + 1
        Next
    End Sub

#End Region

#Region "EVENTOS"

    Public Sub BT_IMPRIMIR_CLICK(sender As Object, e As EventArgs) Handles BT_IMPRIMIR.Click
        Dim VP_ID As String
        VP_ID = TB_K_INSTRUCCION.Text

        VL_PRINTER.DocumentName = "POLIZA"

        PG_RP_003_POLIZA_CHEQUE(VP_ID)

        PM_BT_IMPRIMIR_CLICK()
    End Sub

#End Region
End Class
