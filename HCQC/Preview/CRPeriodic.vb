Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class CRPeriodic

    Private Sub CRPeriodic_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim rpt As New Periodik_Certificate 'The report you created.
        Dim dapid As New SqlDataAdapter()
        Dim dapmt As New SqlDataAdapter()
        Dim dapvg As New SqlDataAdapter()
        Dim myDS As New HCQC_serverDataSet() 'The DataSet you created.
        Dim con1 As New SqlConnection
        Dim sql As String
        Try
            openDB()
            sql = "SELECT * FROM periodik_id"
            dapid = New SqlDataAdapter(sql, con)
            sql = "SELECT * FROM periodik_mt"
            dapmt = New SqlDataAdapter(sql, con)
            sql = "SELECT * FROM periodik_vg"
            dapvg = New SqlDataAdapter(sql, con)

            myDS = New HCQC_serverDataSet
            dapid.Fill(myDS, "periodik_id")
            dapmt.Fill(myDS, "periodik_mt")
            dapvg.Fill(myDS, "periodik_vg")
            rpt.Database.Tables(0).SetDataSource(myDS)
            rpt.SetParameterValue("Nolab_rpt", Parameter_Grafity.tnolab.Text)
            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
End Class