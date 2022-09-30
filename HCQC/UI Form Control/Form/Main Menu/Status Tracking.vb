Public Class Status_Tracking

    Public Sub BindingDataGrid(ByVal bylabnum As String)
        _TableData("SELECT [labnum] as [Lab Number]
                          ,[Request]
                          ,CONVERT(date, [Start]) as [Test Date]
                          ,[Finish] as [Finish Date]
                      FROM [HCQC_server].[dbo].[log_status_sampleDate] WHERE [labnum]='" & bylabnum & "'", MetroGrid1)
        tmoi.Checked = Convert.ToBoolean(_DataToValue("Select [test_moi] FROM [HCQC_server].[dbo].[spl_request] WHere [id]=" & Lreqnum.Text & ""))
        tpur.Checked = Convert.ToBoolean(_DataToValue("Select [test_pur] FROM [HCQC_server].[dbo].[spl_request] WHere [id]=" & Lreqnum.Text & ""))
        traf.Checked = Convert.ToBoolean(_DataToValue("Select [test_raf] FROM [HCQC_server].[dbo].[spl_request] WHere [id]=" & Lreqnum.Text & ""))
        tvia.Checked = Convert.ToBoolean(_DataToValue("Select [test_via] FROM [HCQC_server].[dbo].[spl_request] WHere [id]=" & Lreqnum.Text & ""))
        tger.Checked = Convert.ToBoolean(_DataToValue("Select [test_ger] FROM [HCQC_server].[dbo].[spl_request] WHere [id]=" & Lreqnum.Text & ""))

        Lraf.Text = _DataToValue("SELECT case when [StatusTL]=1 then 'Lulus' when [StatusTL]=0 then 'Tolak' else 'ProsesQC' end as StatusTL from [report_sample_tracking] where [labnum]='" & bylabnum & "'")
        Tstatus.Text = _DataToValue("SELECT [status_confirm]
                                      FROM [HCQC_server].[dbo].[qc_confirm_view]
                                      WHERE [labnum]='" & bylabnum & "'")
    End Sub

    Private Sub Status_Tracking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindingDataGrid(LabelLabnum.Text)

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        BindingDataGrid(LabelLabnum.Text)
    End Sub

    Private Sub Status_Tracking_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Me.Close()
    End Sub

    Private Sub LabelLabnum_Click(sender As Object, e As EventArgs) Handles LabelLabnum.Click

    End Sub

    Private Sub Tstatus_MouseEnter(sender As Object, e As EventArgs) Handles Tstatus.MouseEnter
        Tstatus.ForeColor = Color.DarkGray
    End Sub

    Private Sub Tstatus_MouseLeave(sender As Object, e As EventArgs) Handles Tstatus.MouseLeave
        Tstatus.ForeColor = Color.Black
    End Sub

    Private Sub Tstatus_Click(sender As Object, e As EventArgs) Handles Tstatus.Click
        If Tstatus.Text = "Accepted" Then
            MetroMessageBox.Show(Me, "Sample Accepted (telah di setujui) Staff QC selanjutnya akan di ambil PPC dan test Laboratorium")
        ElseIf Tstatus.Text = "Rejected" Then
            Dim strRemark As String
            strRemark = _DataToValue("SELECT [information_rejected] FROM [qc_confirm_view] WHERE [labnum]='" & LabelLabnum.Text & "'")
            MetroMessageBox.Show(Me, "Sample Rejected (Di tolak) Staff QC karena " + strRemark)
        Else
            MetroMessageBox.Show(Me, "Mohon menunggu tanggapan dari Staf QC")
        End If
    End Sub
End Class