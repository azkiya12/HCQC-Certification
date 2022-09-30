Imports System.Data.SqlClient
Public Class Category_List
    Private Sub Category_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        OnRefreshEventHendler()
    End Sub

    Public Sub OnRefreshEventHendler()
        'TODO: This line of code loads data into the 'HCQC_NewDataset.category_crop' table. You can move, or remove it, as needed.
        Me.Category_cropTableAdapter.Fill(Me.HCQC_NewDataset.category_crop)
    End Sub
    Private Sub MetroLink3_Click(sender As Object, e As EventArgs) Handles MetroLink3.Click
        Dim returnForm = New Kategori_Crop
        returnForm.BtnSave.Text = "Add"
        If returnForm.ShowDialog(Me) = DialogResult.OK Then
            OnRefreshEventHendler()
            returnForm.Close()
        End If
    End Sub
    Private Sub MetroGrid1_CellContentEdit(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick
        Dim i As Integer

        If e.RowIndex = -1 OrElse MetroGrid1.Columns(e.ColumnIndex).Name <> "IdColumn" Then Return
        With MetroGrid1
            If e.RowIndex >= 0 Then
                'Find current mouse cursor position
                i = .CurrentRow.Index
                Dim returnForm = New Kategori_Crop

                returnForm.Tid.Text = .Rows(i).Cells("IdColumn").Value.ToString
                returnForm.TcropName.Text = .Rows(i).Cells("CropColumn").Value.ToString
                returnForm.TprodCode.Text = .Rows(i).Cells("prodcodeColumn").Value.ToString
                returnForm.TComersName.Text = .Rows(i).Cells("ComnameColumn").Value.ToString
                returnForm.ComboBox1.Text = .Rows(i).Cells("typeColumn").Value.ToString
                returnForm.BtnSave.Text = "Update"
                If returnForm.ShowDialog(Me) = DialogResult.OK Then
                    OnRefreshEventHendler()
                    returnForm.Close()
                End If
            End If
        End With
    End Sub

    Private Sub MetroGrid1_CellContentDelete(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick
        If e.RowIndex = -1 OrElse MetroGrid1.Columns(e.ColumnIndex).Name <> "DelColumn" Then Return

        If MetroGrid1.Columns(e.ColumnIndex).Name = "DelColumn" Then
            Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk menghapus data ini", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
            If result = DialogResult.Yes Then
                With MetroGrid1
                    Dim i As Integer = .CurrentRow.Index
                    Dim Vid As String = .Rows(i).Cells(0).Value

                    'refresh Gridview
                    Dim query As String = String.Empty
                    query &= "DELETE FROM [dbo].[category_crop] "
                    query &= " WHERE id=@id"

                    Using conn As New SqlConnection("Data Source=10.15.13.91\SQLEXPRESS;Initial CataLog=HCQC_server;User ID=admin;Password=administrator")
                        Using comm As New SqlCommand()
                            With comm
                                .Connection = conn
                                .CommandType = CommandType.Text
                                .CommandText = query
                                .Parameters.AddWithValue("@id", Vid)
                            End With
                            Try
                                conn.Open()
                                comm.ExecuteNonQuery()
                                conn.Close()
                                MetroMessageBox.Show(Me, "Success Change Password", "Profile", MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                                OnRefreshEventHendler()
                            Catch ex As SqlException
                                MetroMessageBox.Show(Me, ex.Message & " Troble error Change Password", "Profile", MessageBoxButtons.OK, MessageBoxIcon.None, 211)
                            End Try
                        End Using
                    End Using
                End With
            End If
        End If
    End Sub

    Private Sub Category_List_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class