Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
'Imports CrystalDecisions.CrystalReports.ViewerObjectModel.PageObject
Public Class CRGrafti

    Private Sub CRGrafti_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim rpt As New CrystalReport1()
        Dim rpt As New WIP_Certification 'The report you created.
        Dim rpt2 As New Copy_of_WIP_Certification 'The report you created.
        Dim daptr As New SqlDataAdapter()
        Dim daptr1 As New SqlDataAdapter()
        Dim daptr2 As New SqlDataAdapter()
        Dim daptr3 As New SqlDataAdapter()
        Dim daptr4 As New SqlDataAdapter()
        Dim myDS As New HCQC_serverDataSet() 'The DataSet you created.
        Dim con1 As New SqlConnection
        Dim sql As String

        'Dim papersize As CrystalDecisions.Shared.PaperSize
        If Parameter_Grafity.RdLinY.Checked = True Then
            'Mencetak dengan Garis dan Kop
            Try
                openDB()
                sql = "SELECT * FROM wip_id"
                daptr = New SqlDataAdapter(sql, con)
                sql = "SELECT * FROM wip_mt"
                daptr1 = New SqlDataAdapter(sql, con)
                sql = "SELECT * FROM wip_pa"
                daptr3 = New SqlDataAdapter(sql, con)
                sql = "SELECT *  FROM wip_ir"
                daptr2 = New SqlDataAdapter(sql, con)
                sql = "SELECT * FROM wip_vg"
                daptr4 = New SqlDataAdapter(sql, con)

                myDS = New HCQC_serverDataSet
                daptr.Fill(myDS, "wip_id")
                daptr1.Fill(myDS, "wip_mt")
                daptr3.Fill(myDS, "wip_pa")
                daptr2.Fill(myDS, "wip_ir")
                daptr4.Fill(myDS, "wip_vg")
                rpt.Database.Tables(0).SetDataSource(myDS)
                rpt.SetParameterValue("Nolab_rpt", Parameter_Grafity.tnolab.Text)

                CrystalReportViewer1.ReportSource = rpt
                CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        ElseIf Parameter_Grafity.RdLinN.Checked = True Then
            Try
                openDB()
                sql = "SELECT * FROM wip_id"
                daptr = New SqlDataAdapter(sql, con)
                sql = "SELECT * FROM wip_mt"
                daptr1 = New SqlDataAdapter(sql, con)
                sql = "SELECT * FROM wip_pa"
                daptr3 = New SqlDataAdapter(sql, con)
                sql = "SELECT *  FROM wip_ir"
                daptr2 = New SqlDataAdapter(sql, con)
                sql = "SELECT * FROM wip_vg"
                daptr4 = New SqlDataAdapter(sql, con)

                myDS = New HCQC_serverDataSet
                daptr.Fill(myDS, "wip_id")
                daptr1.Fill(myDS, "wip_mt")
                daptr3.Fill(myDS, "wip_pa")
                daptr2.Fill(myDS, "wip_ir")
                daptr4.Fill(myDS, "wip_vg")
                rpt2.Database.Tables(0).SetDataSource(myDS)

                rpt2.SetParameterValue("Nolab_rpt", Parameter_Grafity.tnolab.Text)

                CrystalReportViewer1.ReportSource = rpt2
                CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        End If
        

    End Sub
End Class