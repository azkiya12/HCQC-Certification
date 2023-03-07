Imports System.Data.SqlClient
Imports DgvFilterPopup

Public Class ista_report
    Friend Event SaveLabnumber(ByVal strData As String)
    ReadOnly tglnow As Date = Today

    Private Sub ista_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCQC_serverDataSet.report_ista_view' table. You can move, or remove it, as needed.
        LinkThisMonth1_Click(sender, e)

        Dim DgvFilter As New DgvFilterManager
        DgvFilter.DataGridView = MetroGrid1
        MetroGrid1.ColumnHeadersHeight = 25

    End Sub

    Private Sub LinkThisMonth1_Click(sender As Object, e As EventArgs) Handles LinkThisMonth1.Click
        Me.Report_ista_viewTableAdapter.FillByThisMonth(Me.HCQC_serverDataSet.report_ista_view)
        Dim dt As Date = Now
        Dim startDt As New Date(dt.Year, dt.Month, 1)
        StartDate.Value = startDt.ToString("dd-MMM-yyyy")
        EndDate.Value = Today.ToString("dd-MMM-yyyy")
        MetroGrid1.Refresh()
    End Sub

    Private Sub LinkLastMonth1_Click(sender As Object, e As EventArgs) Handles LinkLastMonth1.Click
        Me.Report_ista_viewTableAdapter.FillByLastMonth(Me.HCQC_serverDataSet.report_ista_view)
        Dim dt, startDt As Date
        dt = Now
        dt = dt.AddMonths(-1)

        startDt = New DateTime(dt.Year, dt.Month, 1)

        StartDate.Value = startDt.ToString("dd-MMM-yyyy")
        EndDate.Value = Today.ToString("dd-MMM-yyyy")
        MetroGrid1.Refresh()
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

    Private Sub ista_report_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.Containermenu2.BtnDetailList2.Enabled = True
    End Sub

    Private Sub Tsearch_ButtonClick(sender As Object, e As EventArgs) Handles Tsearch.ButtonClick
        If String.IsNullOrEmpty(Tsearch.Text) Then
            MetroMessageBox.Show(Me, "Text kosong, tidak ada data yang di cari")
        Else
            Me.Report_ista_viewTableAdapter.FillByVar(Me.HCQC_serverDataSet.report_ista_view, "%" + Trim(Tsearch.Text) + "%")
        End If
    End Sub

    Private Sub Tsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles Tsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Tsearch_ButtonClick(sender, e)
        End If
    End Sub

    Private Sub MetroGrid1_ConclutionContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick
        If e.RowIndex = -1 OrElse MetroGrid1.Columns(e.ColumnIndex).Name <> "BtnQcPassColumn" Then Return

        ''Procedure to GET Conclution Sample Staff
        Dim row As DataGridViewRow = MetroGrid1.Rows(e.RowIndex)
        If MetroGrid1.Columns(e.ColumnIndex).Name = "BtnQcPassColumn" Then
            ''If _isBOF("spl_conclu", "labnum", row.Cells("Labnum").Value.ToString) = False Then
            ''menampilkan form dialog remark
            'RaiseEvent SaveLabnumber(row.Item("labnum").Value)
            Dim ConclutionDialog = New Conclution
            ConclutionDialog.Llabnum.Text = row.Cells("Labnum").Value
            ConclutionDialog.Lvariety.Text = row.Cells("VarietyColumn").Value
            ConclutionDialog.Ljob.Text = row.Cells("NomnlColumn").Value + "/" + row.Cells("NojobColumn").Value
            ConclutionDialog.Lharvest.Text = row.Cells("HarvestColumn").Value

            Dim strstatus As String = _DataToValue("SELECT [status] FROM [HCQC_server].[dbo].[spl_conclu] WHERE [labnum]='" & row.Cells("Labnum").Value & "'").ToString
            'Dim cekvalue As String = MetroGrid1.Rows(e.RowIndex).Cells.Item("ConcludedColumn").Value

            If strstatus = "" Then
                ConclutionDialog.BtnSave.Text = "Save"
                ConclutionDialog.BtnDelete.Enabled = False
                ConclutionDialog.BtnDelete.Visible = False
            Else
                ConclutionDialog.BtnSave.Text = "Update"
                ConclutionDialog.BtnDelete.Enabled = True
                ConclutionDialog.BtnDelete.Visible = True
            End If

            If ConclutionDialog.ShowDialog(Me) = DialogResult.OK Then
                'Me.Qc_confirm_viewTableAdapter.FillByRejected(Me.HCQC_NewDataset.qc_confirm_view)
                MetroGrid1.Rows.RemoveAt(e.RowIndex)
                ConclutionDialog.Close()
                'notification neet to verification
                MainForm.LabelNotifVerivicaion.Text = MainForm.LabelNotifVerivicaion.Text - 1
                MainForm.Containermenu2.LabelNotifContainerTracing.Text = MainForm.Containermenu2.LabelNotifContainerTracing.Text - 1

                'MainForm.LabelNotifVerivicaion.Text = VerificationCount(MainForm.PanelNotifVerification)
                'MainForm.Containermenu2.LabelNotifContainerTracing.Text = VerificationCount(MainForm.Conatinermenu2.Panel2)

            End If
            ''End If
        End If

    End Sub


End Class