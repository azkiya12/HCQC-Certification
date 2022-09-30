Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Public Class upload_file
    Private Sub upload_file_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set AutoGenerateColumns False.
        MetroGrid1.AutoGenerateColumns = False

        'Set Columns Count.
        MetroGrid1.ColumnCount = 2

        'Add Columns.
        MetroGrid1.Columns(0).Name = "Id"
        MetroGrid1.Columns(0).HeaderText = "Image Id"
        MetroGrid1.Columns(0).DataPropertyName = "Id"

        MetroGrid1.Columns(1).HeaderText = "Name"
        MetroGrid1.Columns(1).Name = "Name"
        MetroGrid1.Columns(1).DataPropertyName = "Name"

        'Add a Image Column to the DataGridView at the third position.
        Dim imageColumn As DataGridViewImageColumn = New DataGridViewImageColumn()
        imageColumn.Name = "Data"
        imageColumn.DataPropertyName = "Data"
        imageColumn.HeaderText = "Image"
        imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch
        MetroGrid1.Columns.Insert(2, imageColumn)
        MetroGrid1.RowTemplate.Height = 100
        MetroGrid1.Columns(2).Width = 100

        'Bind DataGridView.
        Me.BindDataGridView()
    End Sub

    Private Sub BindDataGridView()
        Using conn As SqlConnection = New SqlConnection(My.Settings.HCQC_serverConnectionString)
            Using sda As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM tblFiles", conn)
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)
                MetroGrid1.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Using openFileDialog1 As OpenFileDialog = New OpenFileDialog()
            If openFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim fileName As String = openFileDialog1.FileName
                Dim bytes As Byte() = File.ReadAllBytes(fileName)
                Dim contentType As String = ""
                Select Case Path.GetExtension(fileName)
                    Case ".jpg"
                        contentType = "image/jpeg"
                    Case ".png"
                        contentType = "image/png"
                    Case ".gif"
                        contentType = "image/gif"
                    Case ".bmp"
                        contentType = "image/bmp"
                End Select

                Using conn As SqlConnection = New SqlConnection(My.Settings.HCQC_serverConnectionString)
                    Dim sql As String = "INSERT INTO tblFiles VALUES(@Name, @ContentType, @Data)"
                    Using cmd As SqlCommand = New SqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@Name", Path.GetFileName(fileName))
                        cmd.Parameters.AddWithValue("@ContentType", contentType)
                        cmd.Parameters.AddWithValue("@Data", bytes)
                        conn.Open()
                        cmd.ExecuteNonQuery()
                        conn.Close()
                    End Using
                End Using

                Me.BindDataGridView()
            End If
        End Using
    End Sub
End Class