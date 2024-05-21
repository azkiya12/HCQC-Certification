Imports System.ComponentModel
Imports DgvFilterPopup
Public Class Periodic_Scedule
    Private Sub Periodic_Scedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCQC_serverDataSet.report_periodicnext_view' table. You can move, or remove it, as needed.
        Me.Report_periodicnext_viewTableAdapter.FillByThisMonth(Me.HCQC_serverDataSet.report_periodicnext_view)

        Dim DgvFilter As New DgvFilterManager
        DgvFilter.DataGridView = MetroGrid1
        MetroGrid1.ColumnHeadersHeight = 25
    End Sub
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

    Private Sub Periodic_Scedule_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.Containermenu2.BtnPeriodic.Enabled = True
    End Sub

    Private Sub LinkRefresh_Click(sender As Object, e As EventArgs) Handles LinkRefresh.Click
        Periodic_Scedule_Load(sender, e)
    End Sub

    Private Sub LinkThisMonth_Click(sender As Object, e As EventArgs) Handles LinkThisMonth.Click
        Me.Report_periodicnext_viewTableAdapter.FillByThisMonth(Me.HCQC_serverDataSet.report_periodicnext_view)
    End Sub

    Private Sub LinkLastMonth_Click(sender As Object, e As EventArgs) Handles LinkLastMonth.Click
        Me.Report_periodicnext_viewTableAdapter.FillByLastMonth(Me.HCQC_serverDataSet.report_periodicnext_view)
    End Sub

    Private Sub BtnFilterDate_Click(sender As Object, e As EventArgs) Handles BtnFilterDate.Click
        Dim filterStart, filterEnd As String

        filterStart = StartDate.Value.Date.ToString("yyyyMMdd")
        filterEnd = EndDate.Value.Date.ToString("yyyyMMdd")

        Me.Report_periodicnext_viewTableAdapter.FillByBetween(Me.HCQC_serverDataSet.report_periodicnext_view, filterStart, filterEnd)

    End Sub
End Class