Imports System.Data.SqlClient
Imports DgvFilterPopup

Public Class QC_Return

    Private Sub QC_Return_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'HCQC_NewDataset.qc_confirm_view' table. You can move, or remove it, as needed.
        Me.Qc_confirm_viewTableAdapter.Fill(Me.HCQC_NewDataset.qc_confirm_view)

        ''METROGRID1
        Dim DgvFilter As New DgvFilterManager
        DgvFilter.DataGridView = MetroGrid1
        MetroGrid1.ColumnHeadersHeight = 25
    End Sub

    Private Sub MetroGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick
        If e.RowIndex = -1 OrElse MetroGrid1.Columns(e.ColumnIndex).Name <> "BtnCheck" Then Return

        If MetroGrid1.Columns(e.ColumnIndex).Name = "BtnCheck" Then
            If IsDBNull(MetroGrid1.Rows(e.RowIndex).Cells.Item("TglkirimColumn").Value) Then
                'If IsDBNull(MetroGrid1.Rows(e.RowIndex).Cells.Item("TglkirimColumn").Value) Then
                Dim StrStatus As String = MetroGrid1.Rows(e.RowIndex).Cells("RafaksiColumn").Value
                Dim StrBol As Boolean
                If StrStatus = "TL" Then
                    StrBol = 1
                ElseIf StrStatus = "L" Then
                    StrBol = 2
                Else
                    MetroMessageBox.Show(Me, "Select Action Table Column")
                    Return
                End If

                openDB()
                Using cmd As New SqlCommand("sp_QcReturn", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@Id_login", SqlDbType.Int).Value = login.Luserid.Text
                    cmd.Parameters.AddWithValue("@Id_request", MetroGrid1.Rows(e.RowIndex).Cells("Id_requestColumn").Value)
                    cmd.Parameters.Add("@Tgl_kirim", SqlDbType.DateTime).Value = Now
                    cmd.Parameters.Add("@Status", SqlDbType.Bit).Value = StrBol
                    cmd.ExecuteScalar()
                    con.Close()
                End Using

                Me.Qc_confirm_viewTableAdapter.Fill(Me.HCQC_NewDataset.qc_confirm_view)
            End If
        End If
    End Sub

    Private Sub MetroGrid1_DelCellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick
        If e.RowIndex = -1 OrElse MetroGrid1.Columns(e.ColumnIndex).Name <> "BtnDel" Then Return

        If MetroGrid1.Columns(e.ColumnIndex).Name = "BtnDel" Then
            Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk menghapus data ini", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
            If result = DialogResult.Yes Then
                If Not IsDBNull(MetroGrid1.Rows(e.RowIndex).Cells.Item("TglkirimColumn").Value) Then
                    'If IsDBNull(MetroGrid1.Rows(e.RowIndex).Cells.Item("TglkirimColumn").Value) Then
                    openDB()
                    Using cmd As New SqlCommand("sp_QcReturnDel", con)
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.AddWithValue("@Id_request", MetroGrid1.Rows(e.RowIndex).Cells("Id_requestColumn").Value)
                        cmd.Parameters.AddWithValue("@Tgl_confirm", MetroGrid1.Rows(e.RowIndex).Cells("TglkirimColumn").Value)
                        cmd.ExecuteScalar()
                        con.Close()
                    End Using

                    Me.Qc_confirm_viewTableAdapter.Fill(Me.HCQC_NewDataset.qc_confirm_view)
                End If
            End If
        End If
    End Sub
    Sub ButtonCelltoTextCell()
        For i As Integer = 0 To MetroGrid1.Rows.Count() - 1 Step +1
            If Not IsDBNull(MetroGrid1.Rows(i).Cells("TglkirimColumn").Value) Then
                'jika data sudah di isi/ada
                'Replace the ButtonCell for a TextCell'
                Dim cell As New DataGridViewTextBoxCell()
                'Set the value again'
                cell.Value = "Sended"
                'Override the cell'
                MetroGrid1.Rows(i).Cells("BtnCheck") = cell
            ElseIf IsDBNull(MetroGrid1.Rows(i).Cells("TglkirimColumn").Value) Then
                'jika data kosong
                'Replace the ButtonDel for a TextCell
                Dim celldel As New DataGridViewTextBoxCell()
                celldel.Value = "On Process"
                MetroGrid1.Rows(i).Cells("BtnDel") = celldel
            End If
        Next
    End Sub
    Private Sub MetroGrid1_RowValidated(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.RowValidated
        ButtonCelltoTextCell()
    End Sub

    Private Sub MetroGrid1_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles MetroGrid1.RowPostPaint
        ButtonCelltoTextCell()
    End Sub

    Private Sub MetroLink2_Click(sender As Object, e As EventArgs) Handles MetroLink2.Click
        'TODO: This line of code loads data into the 'HCQC_NewDataset.qc_confirm_view' table. You can move, or remove it, as needed.
        Me.Qc_confirm_viewTableAdapter.Fill(Me.HCQC_NewDataset.qc_confirm_view)
    End Sub
End Class
