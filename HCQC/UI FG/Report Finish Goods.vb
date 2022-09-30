Imports System.Data.SqlClient
Imports CrystalDecisions.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Report_Finish_Goods
    Dim rpt As New Finish_Good_Certification 'The report you created.
    Dim sql As String = ""
    Dim dapid As New SqlDataAdapter()
    Dim dapmt As New SqlDataAdapter()
    Dim dapvg As New SqlDataAdapter()
    Dim myDS As New HCQC_serverDataSet() 'The DataSet you created.
    Dim con1 As New SqlConnection

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click

        Try
            openDB()
            sql = "UPDATE fg_id SET to1='" & MetroComboBox1.Text & "', adres='" & taddress.Text & "' where no_lab='" & Me.Prenolab.Text & "'"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        Try
            CrystalReportViewer1.Refresh()
            openDB()
            sql = "SELECT * FROM fg_id"
            dapid = New SqlDataAdapter(sql, con)
            sql = "SELECT * FROM fg_mt"
            dapmt = New SqlDataAdapter(sql, con)
            sql = "SELECT * FROM fg_vg"
            dapvg = New SqlDataAdapter(sql, con)

            myDS = New HCQC_serverDataSet
            dapid.Fill(myDS, "fg_id")
            dapmt.Fill(myDS, "fg_mt")
            dapvg.Fill(myDS, "fg_vg")
            '---------------------------'
            rpt.Database.Tables(0).SetDataSource(myDS)
            rpt.SetParameterValue("No.Lab", Me.Prenolab.Text)
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
            sql = "UPDATE fg_id SET tgl_print='" & Now & "' where no_lab='" & Me.Prenolab.Text & "'"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroComboBox1.SelectedIndexChanged
        If MetroComboBox1.Text = "Prosesing/HCP" Then
            taddress.Text = "Jl. Pare-Wates KM. 9 Desa Sumberagung, Kec Plosoklaten, Kediri 64175"
            Prenolab.Focus()
        ElseIf MetroComboBox1.Text = "Lainnya" Or MetroComboBox1.Text = "" Then
            taddress.Text = ""
            taddress.Focus()
        End If
    End Sub

    Private Sub Prenolab_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Prenolab.GotFocus
        Me.AcceptButton = MetroButton1
    End Sub
End Class