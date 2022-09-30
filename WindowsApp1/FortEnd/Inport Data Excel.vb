Imports System.Data.SqlClient

Public Class Inport_Data_Excel
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If Not String.IsNullOrEmpty(MetroTextBox1.Text) Then
            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim DtSet As System.Data.DataSet
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & MetroTextBox1.Text & ";Extended Properties=""Excel 12.0;IMEX=1""")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection)
            DtSet = New DataSet
            MyCommand.Fill(DtSet, "[Sheet1$]")
            MetroGrid1.DataSource = DtSet
            MetroGrid1.DataMember = "[Sheet1$]"
            MyConnection.Close()
        Else
            MetroFramework.MetroMessageBox.Show(Form.ActiveForm, "Please Select file fist...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
        End If

    End Sub

    Private Sub MetroTextBox1_Click(sender As Object, e As EventArgs) Handles MetroTextBox1.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            MetroTextBox1.Text = strFileName
        End If

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

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            'openDB()
            Using cmd1 As New SqlCommand("INSERT INTO supplierdata (supid,supname,supmobile,suploc)VALUES (@supid,@supname,@supmobile,@suploc)", con)
                cmd1.Parameters.Add("@supid", SqlDbType.Int)
                cmd1.Parameters.Add("@supname", SqlDbType.NChar)
                cmd1.Parameters.Add("@supmobile", SqlDbType.NChar)
                cmd1.Parameters.Add("@suploc", SqlDbType.NChar)
                con.Open()
                For Each row As DataGridViewRow In MetroGrid1.Rows
                    With cmd1
                        .Parameters("@supid").Value = row.Cells(0).Value
                        .Parameters("@supname").Value = row.Cells(1).Value
                        .Parameters("@supmobile").Value = row.Cells(2).Value
                        .Parameters("@suploc").Value = row.Cells(3).Value

                    End With
                    cmd1.ExecuteNonQuery()
                Next
            End Using 'You probably want to catch more specific exceptions
            'and handle them separately

        Catch ex As Exception 'You probably want to catch more specific exceptions
            'and handle them separately
            MessageBox.Show(ex.Message)
        End Try
        MessageBox.Show("CUSTOMER REGISTERED SUCCESFULLY")
    End Sub


    Public con As SqlClient.SqlConnection
    'Public Function openDB() As Boolean
    '    'membuka database, namun outputnya sebagai boolean (true/false), anda bisa menggunakan untuk cek koneksi database
    '    con = New SqlClient.SqlConnection
    '    'con.ConnectionString = "Data Source=10.15.13.91\SQLEXPRESS;Initial CataLog=HCQC_server;User ID=admin;Password=administrator"
    '    con.ConnectionString = My.Settings.HCQC_serverConnectionString
    '    Try
    '        con.Open()
    '        Return True
    '    Catch ex As Exception
    '        MsgBox("Terjadi Error Koneksi Database : " & ex.Message)
    '        Return False
    '    End Try

    'End Function
End Class
