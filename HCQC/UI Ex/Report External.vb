Imports System.Data.SqlClient
Imports CrystalDecisions.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Report_External
    Dim rpt As New External_Cerfication_2018 'The report you created.
    Dim sql As String = ""
    Dim dapmt As New SqlDataAdapter()
    Dim myDS As New HCQC_serverDataSet() 'The DataSet you created.
    Dim con1 As New SqlConnection
    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        Try
            openDB()
            sql = "UPDATE extnl_msk SET to1='" & MetroComboBox1.Text & "', adres='" & taddress.Text & "' where no_lab='" & Me.Prenolab.Text & "'"
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

            sql = "SELECT dbo.extnl_msk.no_lab, variety, nojob, weightA, unitA, weightB, unitB, nama, asal, hv_dt, exp_dt, Dtqc, uji_ka, uji_ra, uji_dt, uji_aat, uji_tz, uji_ect, brt_in, taken, ppc2, " & _
                         "vg_dt_t, vg_fn_c, DATEDIFF(DAY, vg_dt_t, vg_fn_c) AS wkt_uji, vg_mtd, [Index Vigor (%)] AS vg, [Germination (%)] AS dt, [Abnormal Seedling (%)] AS Abnormal, " & _
                         "[Hard Seed (%)] AS Hard, [Fresh Seed (%)] AS Fresh, [Dead Seed (%)] AS Dead, ket, vg_ket, jns_bnh " & _
                  "FROM   extnl_msk LEFT OUTER JOIN" & _
                         " (SELECT  no_lab, char1s, percn " & _
                           "FROM  extnl_vg) AS ps PIVOT (SUM(percn) FOR char1s IN ([Index Vigor (%)], [Germination (%)], [Abnormal Seedling (%)], [Hard Seed (%)], [Fresh Seed (%)], " & _
                         "[Dead Seed (%)])) AS pv ON dbo.extnl_msk.no_lab = pv.no_lab"
            dapmt = New SqlDataAdapter(sql, con)
            myDS = New HCQC_serverDataSet
            dapmt.Fill(myDS, "ExternalJoin")

            '---------------------------'
            rpt.Database.Tables(0).SetDataSource(myDS)
            rpt.SetParameterValue("No_lab", Me.Prenolab.Text)
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
            sql = "UPDATE extnl_msk SET tgl_print='" & Now & "' where no_lab='" & Me.Prenolab.Text & "'"
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