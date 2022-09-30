Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class CRExternal

    Private Sub CRExternal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim rpt As New External_Cerfication() 'The report you created.
        Dim daptr As New SqlDataAdapter()
        Dim myDS As New HCQC_serverDataSet() 'The DataSet you created.
        Dim con1 As New SqlConnection
        Dim sql As String
        Try
            openDB()
            sql = "SELECT * FROM eksternal"
            daptr = New SqlDataAdapter(sql, con)

            myDS = New HCQC_serverDataSet
            daptr.Fill(myDS, "eksternal")
            rpt.Database.Tables(0).SetDataSource(myDS)
            rpt.SetParameterValue("No_lab", Parameter_Grafity.tnolab.Text)
            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
End Class