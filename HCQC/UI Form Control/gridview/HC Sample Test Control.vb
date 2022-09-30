Public Class HC_Sample_Test_Control
    Private Sub HC_Sample_Test_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCQC_NewDataset.report_status_pengujian' table. You can move, or remove it, as needed.
        Me.Report_status_pengujianTableAdapter.Fill(Me.HCQC_NewDataset.report_status_pengujian)
    End Sub

    Private Sub LinkRefresh_Click(sender As Object, e As EventArgs) Handles LinkRefresh.Click
        Me.Report_status_pengujianTableAdapter.Fill(Me.HCQC_NewDataset.report_status_pengujian)
        GridControl1.RefreshDataSource()
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
End Class