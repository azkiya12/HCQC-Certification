Public Class RafactionDataReport
    Private Sub RafactionDataReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LinkThisYear_Click(sender, e)

    End Sub

    Private Sub Tsearch_ButtonClick(sender As Object, e As EventArgs) Handles Tsearch.ButtonClick
        If String.IsNullOrEmpty(Tsearch.Text) Then
            MetroMessageBox.Show(Me, "Text kosong, tidak ada data yang di cari")
        Else
            Me.Rafaction_viewTableAdapter.FillByStrParameter(Me.HCQC_NewDataset.rafaction_view, "%" + Trim(Tsearch.Text) + "%")
        End If

        TagRefresh("InputParameter")
    End Sub

    Private Sub Tsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles Tsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Tsearch_ButtonClick(sender, e)
        End If
    End Sub

    Private Sub LinkThisYear_Click(sender As Object, e As EventArgs) Handles LinkThisYear.Click
        Me.Rafaction_viewTableAdapter.FillByThisYear(Me.HCQC_NewDataset.rafaction_view)
        TagRefresh("ThisYear")
    End Sub

    Sub TagRefresh(ByVal TagText As String)
        LinkRefresh.Tag = TagText
    End Sub
    Private Sub LinkLastYear_Click(sender As Object, e As EventArgs) Handles LinkLastYear.Click
        Me.Rafaction_viewTableAdapter.FillByLastYear(Me.HCQC_NewDataset.rafaction_view)
        TagRefresh("LastYear")
    End Sub

    Private Sub BtnFilterDate_Click(sender As Object, e As EventArgs) Handles BtnFilterDate.Click
        '' Mengatur tanggal awal
        Dim getstartDate As DateTime = EndDate.Value.Date

        '' Menambahkan satu hari ke tanggal awal dan mengurangi satu detik
        Dim endDateTime As DateTime = getstartDate.AddDays(1).AddSeconds(-1)

        Me.Rafaction_viewTableAdapter.FillByDateRange(Me.HCQC_NewDataset.rafaction_view, StartDate.Value.Date.ToString("yyyy-MM-ddTHH:mm:ss"), endDateTime.ToString("yyyy-MM-ddTHH:mm:ss"))
        TagRefresh("DateFilter")
    End Sub

    Private Sub LinkRefresh_Click(sender As Object, e As EventArgs) Handles LinkRefresh.Click
        If LinkRefresh.Tag = "ThisYear" Then
            LinkThisYear_Click(sender, e)
        End If
        If LinkRefresh.Tag = "LastYear" Then
            LinkLastYear_Click(sender, e)
        End If
        If LinkRefresh.Tag = "DateFilter" Then
            BtnFilterDate_Click(sender, e)
        End If
        If LinkRefresh.Tag = "InputParameter" Then
            Tsearch_ButtonClick(sender, e)
        End If
    End Sub
End Class