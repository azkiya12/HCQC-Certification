﻿Imports System.Data.SqlClient
Imports DgvFilterPopup

Public Class ista_report
    Friend Event SaveLabnumber(ByVal strData As String)
    ReadOnly tglnow As Date = Today

    Private Sub ista_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCQC_serverDataSet.report_ista_view' table. You can move, or remove it, as needed.
        LinkRefresh_Click(sender, e)

        Dim DgvFilter As New DgvFilterManager
        DgvFilter.DataGridView = MetroGrid1
        MetroGrid1.ColumnHeadersHeight = 25

    End Sub

    Private Sub LinkRefresh_Click(sender As Object, e As EventArgs) Handles LinkRefresh.Click
        Me.Report_ista_viewTableAdapter.Fill(Me.HCQC_serverDataSet.report_ista_view)
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
            LinkRefresh_Click(sender, e)
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
            If _isBOF("spl_conclu", "labnum", row.Cells("Labnum").Value.ToString) = False Then
                ''menampilkan form dialog remark
                'RaiseEvent SaveLabnumber(row.Item("labnum").Value)
                Dim ConclutionDialog = New Conclution
                ConclutionDialog.Llabnum.Text = row.Cells("Labnum").Value
                ConclutionDialog.Lvariety.Text = row.Cells("VarietyColumn").Value
                ConclutionDialog.Lfarmer.Text = row.Cells("FarmerColumn").Value
                ConclutionDialog.Ljob.Text = row.Cells("NomnlColumn").Value + "/" + row.Cells("NojobColumn").Value
                ConclutionDialog.Lharvest.Text = row.Cells("HarvestColumn").Value
                ConclutionDialog.LLocation.Text = row.Cells("LocationColumn").Value

                Dim strstatus As String = _DataToValue("SELECT [status] FROM [HCQC_server].[dbo].[spl_conclu] WHERE [labnum]='" & row.Cells("Labnum").Value & "'").ToString
                Dim cekvalue As String = MetroGrid1.Rows(e.RowIndex).Cells.Item("ConcludedColumn").Value
                If cekvalue = "" Then
                    ConclutionDialog.BtnSave.Text = "Save"
                Else
                    ConclutionDialog.BtnSave.Text = "Update"
                End If

                If ConclutionDialog.ShowDialog(Me) = DialogResult.OK Then
                    'Me.Qc_confirm_viewTableAdapter.FillByRejected(Me.HCQC_NewDataset.qc_confirm_view)
                    MetroGrid1.Rows.RemoveAt(e.RowIndex)
                    ConclutionDialog.Close()
                    'notification neet to verification
                    MainForm.LabelNotifVerivicaion.Text = MainForm.LabelNotifVerivicaion.Text - 1
                    MainForm.Containermenu2.LabelNotifContainerTracing.Text = MainForm.Containermenu2.LabelNotifContainerTracing.Text - 1

                    'MainForm.LabelNotifVerivicaion.Text = VerificationCount(MainForm.PanelNotifVerification)
                    'MainForm.Containermenu2.LabelNotifContainerTracing.Text = VerificationCount(MainForm.Containermenu2.Panel2)
                End If
            Else
                MetroMessageBox.Show(Me, "Nomor Lab ini sudah di Terima QC Laboatorium")
            End If
        End If

    End Sub
End Class