Imports DgvFilterPopup

Public Class List_of_Production_Number

    Friend Event SaveProductionNo(ByVal strData As String)
    Private Sub List_of_Production_Number_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCQC_NewDataset.report_a1' table. You can move, or remove it, as needed.
        Me.Report_a1TableAdapter.Fill(Me.HCQC_NewDataset.report_a1)

        ''filter Control Header Gridview1
        Dim DgvFilter As New DgvFilterManager
        DgvFilter.DataGridView = MetroGrid1
        MetroGrid1.ColumnHeadersHeight = 25
    End Sub

    Private Sub MetroGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick
        If e.RowIndex = -1 OrElse MetroGrid1.Columns(e.ColumnIndex).Name <> "IdcodeColumn" Then Return

        Dim row As DataGridViewRow = MetroGrid1.Rows(e.RowIndex)
        With MetroGrid1
            If MetroGrid1.Columns(e.ColumnIndex).Name = "IdcodeColumn" Then
                Dim i As Integer
                i = .CurrentRow.Index
                RaiseEvent SaveProductionNo(.Rows(i).Cells("IdcodeColumn").Value.ToString)
                Close()
            End If
        End With
    End Sub

    Private Sub List_of_Production_Number_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class