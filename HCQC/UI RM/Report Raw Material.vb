Imports System.Data.SqlClient
Imports CrystalDecisions.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Report_Raw_Material
    Dim rpt As New Raw_Material_Certificate 'The report you created.
    Dim sql As String = ""
    Dim dapid As New SqlDataAdapter()
    Dim dapmt As New SqlDataAdapter()
    Dim dapvg As New SqlDataAdapter()
    Dim myDS As New HCQC_serverDataSet() 'The DataSet you created.
    Dim con1 As New SqlConnection
    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
 
        Try
            CrystalReportViewer1.Refresh()
            openDB()
            sql = "SELECT * FROM rm_msk LEFT OUTER JOIN rm_mt ON rm_msk.no_lab = rm_mt.no_lab"
            dapid = New SqlDataAdapter(sql, con)
            'sql = "SELECT * FROM rm_mt"
            'dapmt = New SqlDataAdapter(sql, con)
            sql = "SELECT * FROM rm_vg"
            dapvg = New SqlDataAdapter(sql, con)

            myDS = New HCQC_serverDataSet
            dapid.Fill(myDS, "rm_msk")
            'dapmt.Fill(myDS, "rm_msk")
            dapvg.Fill(myDS, "rm_vg")
            '---------------------------'
            rpt.Database.Tables(0).SetDataSource(myDS)
            rpt.SetParameterValue("Nolab_rpt", Me.Prenolab.Text)
            rpt.SummaryInfo.ReportTitle = Prenolab.Text

            'rpt.RecordSelectionFormula = ("{@varto}='" & MetroComboBox1.Text & "'")
            'rpt.RecordSelectionFormula = "{@varadres}='" & MetroTextBox2.Text & "'"
            CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub MetroButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton2.Click
        CrystalReportViewer1.PrintReport()
        openDB()
        Try
            sql = "UPDATE rm_msk SET tgl_print='" & Now & "' where no_lab='" & Me.Prenolab.Text & "'"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Prenolab_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Prenolab.GotFocus
        Me.AcceptButton = MetroButton1
    End Sub
End Class