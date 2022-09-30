Imports System.Data.SqlClient
Imports CrystalDecisions.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class PreviewGrafity
    Dim rpt2 As New WIP_Certification_new_DT2 'The report you created.
    Dim rpt As New WIP_Certification_new 'The report you created.
    Dim daptr As New SqlDataAdapter()
    Dim daptr1 As New SqlDataAdapter()
    Dim daptr2 As New SqlDataAdapter()
    Dim daptr4 As New SqlDataAdapter()
    Dim myDS As New HCQC_serverDataSet() 'The DataSet you created.
    Dim con1 As New SqlConnection
    Dim sql As String = ""

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        If MetroRadioButton1.Checked = True Then
            Try
                CrystalReportViewer1.Refresh()
                openDB()
                sql = "SELECT * FROM wip_msk WHERE (no_lab='" & Prenolab.Text & "')"
                daptr = New SqlDataAdapter(sql, con)
                sql = "SELECT * FROM wip_mt2 WHERE (no_lab='" & Prenolab.Text & "')"
                daptr1 = New SqlDataAdapter(sql, con)
                sql = "SELECT *  FROM wip_ir2 WHERE (no_lab='" & Prenolab.Text & "')"
                daptr2 = New SqlDataAdapter(sql, con)
                sql = "SELECT * FROM wip_vg WHERE (no_lab='" & Prenolab.Text & "')"
                daptr4 = New SqlDataAdapter(sql, con)

                myDS = New HCQC_serverDataSet
                daptr.Fill(myDS, "wip_msk")
                daptr1.Fill(myDS, "wip_mt2")
                daptr2.Fill(myDS, "wip_ir2")
                daptr4.Fill(myDS, "wip_vg")
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
        Else
            Try
                CrystalReportViewer1.Refresh()
                openDB()
                sql = "SELECT * FROM wip_msk WHERE (no_lab='" & Prenolab.Text & "')"
                daptr = New SqlDataAdapter(sql, con)
                sql = "SELECT * FROM wip_mt2 WHERE (no_lab='" & Prenolab.Text & "')"
                daptr1 = New SqlDataAdapter(sql, con)
                sql = "SELECT *  FROM wip_ir2 WHERE (no_lab='" & Prenolab.Text & "')"
                daptr2 = New SqlDataAdapter(sql, con)
                sql = "SELECT * FROM wip_vg WHERE (no_lab='" & Prenolab.Text & "')"
                daptr4 = New SqlDataAdapter(sql, con)

                myDS = New HCQC_serverDataSet
                daptr.Fill(myDS, "wip_msk")
                daptr1.Fill(myDS, "wip_mt2")
                daptr2.Fill(myDS, "wip_ir2")
                daptr4.Fill(myDS, "wip_vg")
                rpt2.Database.Tables(0).SetDataSource(myDS)
                rpt2.SetParameterValue("Nolab_rpt", Me.Prenolab.Text)
                rpt2.SummaryInfo.ReportTitle = Prenolab.Text
                'rpt.RecordSelectionFormula = ("{@varto}='" & MetroComboBox1.Text & "'")
                'rpt.RecordSelectionFormula = "{@varadres}='" & MetroTextBox2.Text & "'"
                CrystalReportViewer1.ReportSource = rpt2
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        End If
       
    End Sub

    Private Sub MetroButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton2.Click
        rpt.SummaryInfo.ReportTitle = Prenolab.Text
        rpt2.SummaryInfo.ReportTitle = Prenolab.Text
        CrystalReportViewer1.PrintReport()
        openDB()

        Try
            sql = "UPDATE wip_msk SET tgl_print='" & Now & "' where no_lab='" & Me.Prenolab.Text & "'"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Prosesing/HCP" Then
            MetroTextBox2.Text = "Jl. Pare-Wates KM. 9 Desa Sumberagung, Kec Plosoklaten, Kediri 64175"
            Prenolab.Focus()
        ElseIf ComboBox1.Text = "Lainnya" Or ComboBox1.Text = "" Then
            MetroTextBox2.Text = ""
            MetroTextBox2.Focus()
        End If
    End Sub

    Private Sub Prenolab_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Prenolab.GotFocus
        Me.AcceptButton = MetroButton1
    End Sub

End Class