Imports DgvFilterPopup
Public Class Data_List_Inspection
    Private Sub Data_List_Inspection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCQC_serverDataSet.report_inspection' table. You can move, or remove it, as needed.
        Me.Report_inspectionTableAdapter.Fill(Me.HCQC_serverDataSet.report_inspection)

        Dim DgvFilter As New DgvFilterManager
        DgvFilter.DataGridView = MetroGrid1
        MetroGrid1.ColumnHeadersHeight = 25
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        Data_List_Inspection_Load(sender, e)
    End Sub

    Private Sub MetroGrid1_RowPostPaint(ByVal sender As Object, ByVal e As DataGridViewRowPostPaintEventArgs) Handles MetroGrid1.RowPostPaint
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
End Class