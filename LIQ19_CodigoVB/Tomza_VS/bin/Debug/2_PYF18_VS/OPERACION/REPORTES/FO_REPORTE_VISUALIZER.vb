Imports Microsoft.Reporting.WinForms

Public Class FO_REPORTE_VISUALIZER

    Dim DATASET As New DataTable
    Dim VM_K_TABLA_AMORTIZACION As Integer = 0
    Public Sub New(VP_DATASET As DataTable)

        Me.DATASET = VP_DATASET
    End Sub


    Public Sub New(PP_K_TABLA_AMORTIZACION As Integer)
        InitializeComponent()
        Me.VM_K_TABLA_AMORTIZACION = PP_K_TABLA_AMORTIZACION
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.Visible = False
        Me.ReportViewer1.ProcessingMode = ProcessingMode.Local
        ReportViewer1.LocalReport.DataSources.Clear()

        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VM_K_TABLA_AMORTIZACION, False)
        Codigo_CON.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
        Dim rds As New DataTable
        rds = Codigo_CON.FG_SP_EXECUTE_DATATABLE(VG_ID_DB, "[dbo].[PG_RT_SOLICITUD_DE_SERVICIOS_BANCA_DE_EMPRESAS]", VP_PARAMETROS)

        Dim RDS_LOLA As New ReportDataSource("SOLICITUD_DE_SERVICIO_BANCA", rds)
        Me.ReportViewer1.LocalReport.DataSources.Add(RDS_LOLA)
        Me.ReportViewer1.LocalReport.ReportPath = "C:\Users\LAURA BARRAZA\Source\Repos\pyf18_vb2\PYF18_CodigoVB\LIQ19_Liquidaciones\Prototipos\OPERACION\REPORTES\SOLICITUD_DE_SERVICIO_BANCA_RPT.rdlc"
        ReportViewer1.Visible = True
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class