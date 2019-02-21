<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FO_REPORTE_VISUALIZER
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PG_RT_SOLICITUD_DE_SERVICIOS_BANCA_DE_EMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SOLICITUD_DE_SERVICIO_BANCA = New LIQ19_Liquidaciones.SOLICITUD_DE_SERVICIO_BANCA()
        Me.PG_RT_SOLICITUD_DE_SERVICIOS_BANCA_DE_EMPRESASTableAdapter = New LIQ19_Liquidaciones.SOLICITUD_DE_SERVICIO_BANCATableAdapters.PG_RT_SOLICITUD_DE_SERVICIOS_BANCA_DE_EMPRESASTableAdapter()
        CType(Me.PG_RT_SOLICITUD_DE_SERVICIOS_BANCA_DE_EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SOLICITUD_DE_SERVICIO_BANCA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "SOLICITUD_DE_SERVICIO_BANCA"
        ReportDataSource1.Value = Me.PG_RT_SOLICITUD_DE_SERVICIOS_BANCA_DE_EMPRESASBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportPath = ""
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.ServerReport.ReportServerUrl = New System.Uri("", System.UriKind.Relative)
        Me.ReportViewer1.Size = New System.Drawing.Size(1131, 789)
        Me.ReportViewer1.TabIndex = 0
        '
        'PG_RT_SOLICITUD_DE_SERVICIOS_BANCA_DE_EMPRESASBindingSource
        '
        Me.PG_RT_SOLICITUD_DE_SERVICIOS_BANCA_DE_EMPRESASBindingSource.DataMember = "PG_RT_SOLICITUD_DE_SERVICIOS_BANCA_DE_EMPRESAS"
        Me.PG_RT_SOLICITUD_DE_SERVICIOS_BANCA_DE_EMPRESASBindingSource.DataSource = Me.SOLICITUD_DE_SERVICIO_BANCA
        '
        'SOLICITUD_DE_SERVICIO_BANCA
        '
        Me.SOLICITUD_DE_SERVICIO_BANCA.DataSetName = "SOLICITUD_DE_SERVICIO_BANCA"
        Me.SOLICITUD_DE_SERVICIO_BANCA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PG_RT_SOLICITUD_DE_SERVICIOS_BANCA_DE_EMPRESASTableAdapter
        '
        Me.PG_RT_SOLICITUD_DE_SERVICIOS_BANCA_DE_EMPRESASTableAdapter.ClearBeforeFill = True
        '
        'FO_REPORTE_VISUALIZER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 789)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FO_REPORTE_VISUALIZER"
        Me.Text = "Visor de Reportes"
        CType(Me.PG_RT_SOLICITUD_DE_SERVICIOS_BANCA_DE_EMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SOLICITUD_DE_SERVICIO_BANCA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PG_RT_SOLICITUD_DE_SERVICIOS_BANCA_DE_EMPRESASBindingSource As BindingSource
    Friend WithEvents SOLICITUD_DE_SERVICIO_BANCA As SOLICITUD_DE_SERVICIO_BANCA
    Friend WithEvents PG_RT_SOLICITUD_DE_SERVICIOS_BANCA_DE_EMPRESASTableAdapter As SOLICITUD_DE_SERVICIO_BANCATableAdapters.PG_RT_SOLICITUD_DE_SERVICIOS_BANCA_DE_EMPRESASTableAdapter
End Class
