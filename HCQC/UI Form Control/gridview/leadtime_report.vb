Imports DgvFilterPopup
Public Class leadtime_report
    Private Sub MetroGrid1_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles MetroGrid1.RowPostPaint
        'penomoran pada MetroGrid view
        MetroGrid1 = DirectCast(sender, DataGridView)
        Dim rowNumber As String = (e.RowIndex + 1).ToString()
        While rowNumber.Length < MetroGrid1.RowCount.ToString().Length
            rowNumber = "0" & rowNumber
        End While

        Dim size As SizeF = e.Graphics.MeasureString(rowNumber, Me.Font)
        If MetroGrid1.RowHeadersWidth < CInt(size.Width + 20) Then
            MetroGrid1.RowHeadersWidth = CInt(size.Width + 20)
        End If

        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(rowNumber, MetroGrid1.Font, b, e.RowBounds.Location.X + 15,
        e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

    Private Sub leadtime_report_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'HCQC_serverDataSet.report_leadtime_view' table. You can move, or remove it, as needed.
        Me.Report_leadtime_viewTableAdapter.Fill(Me.HCQC_serverDataSet.report_leadtime_view)

        Dim DgvFilter As New DgvFilterManager
        DgvFilter.DataGridView = MetroGrid1
        MetroGrid1.ColumnHeadersHeight = 25
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        Me.Report_leadtime_viewTableAdapter.Fill(Me.HCQC_serverDataSet.report_leadtime_view)
    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles BtnRefresStatus.Click
        'TODO: This line of code loads data into the 'HCQC_NewDataset.report_status_pengujian' table. You can move, or remove it, as needed.
        Me.Report_status_pengujianTableAdapter.Fill(Me.HCQC_NewDataset.report_status_pengujian)

        Dim DgvFilter2 As New DgvFilterManager
        DgvFilter2.DataGridView = MetroGrid2
        MetroGrid2.ColumnHeadersHeight = 25
    End Sub

    Private Sub leadtime_report_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.Containermenu2.BtnLeadTime.Enabled = True
    End Sub
End Class