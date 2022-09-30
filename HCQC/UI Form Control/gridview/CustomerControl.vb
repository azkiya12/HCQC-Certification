Imports DgvFilterPopup
Public Class CustomerControl
    'Sub TAMPIL()
    '    Try
    '        openDB()
    '        cmd = New SqlClient.SqlCommand("SELECT * FROM customer WHERE name LIKE '%" & MainForm.Sample_Receipt1.tCus.Text & "%'", con)
    '        adapter = New SqlClient.SqlDataAdapter With {
    '            .SelectCommand = cmd
    '        }
    '        Dim dset As DataSet = New Data.DataSet
    '        adapter.Fill(dset, "c")
    '        MetroGrid1.DataSource = dset
    '        MetroGrid1.DataMember = "c"
    '    Catch ex As Exception
    '        MetroMessageBox.Show(Me, "Error " & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
    '    Finally
    '        con.Close()
    '    End Try
    'End Sub
    Public Property CustomerID As Integer

    Private Sub CustomerControl_Load(sender As Object, e As EventArgs) Handles Me.Load

        'TODO: This line of code loads data into the 'HCQC_serverDataSet.customer' table. You can move, or remove it, as needed.

        Me.CustomerTableAdapter.Fill(Me.HCQC_serverDataSet.customer)

        If CustomerID = 1 Then
            'TAMPIL()
        End If
        'Menamoilkan nomor urut pada datagrid view
        Dim DgvFilter As New DgvFilterManager
        DgvFilter.DataGridView = MetroGrid1
        MetroGrid1.ColumnHeadersHeight = 25

    End Sub

    'gunakan event ini untuk memanggil formChild
    'Private Sub BtnCariCustomer_Click(sender As Object, e As EventArgs)
    '    Dim frmChild As New CustomerControl With {
    '        .CustomerID = 1
    '    }
    '    frmChild.ShowDialog()
    'End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Try
            BtnBack.Enabled = False
            Close()
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Error " & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
        End Try

    End Sub

    'Private Sub MetroGrid1_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick
    '    --copy datagrid row selected value to textbox--
    '    If CustomerID = 1 Then
    '        'MessageBox.Show("masuk gerid")
    '        Dim i As Integer
    '        With MetroGrid1
    '            If e.RowIndex >= 0 Then
    '                'Find current mouse cursor position
    '                i = .CurrentRow.Index
    '                MainForm.Sample_Receipt1.tidcus.Text = .Rows(i).Cells("Idcust").Value.ToString
    '                MainForm.Sample_Receipt1.tCus.Text = .Rows(i).Cells("NameGrid").Value.ToString
    '                MainForm.Sample_Receipt1.tcontact.Text = .Rows(i).Cells("Contact").Value.ToString
    '                MainForm.Sample_Receipt1.temail.Text = .Rows(i).Cells("Email").Value.ToString
    '                Me.Close()
    '            End If
    '        End With
    '    End If
    'End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Input_Customer.ShowDialog()
    End Sub

    Private Sub CustomerControl_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.CustomerTableAdapter.Fill(Me.HCQC_serverDataSet.customer)
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
End Class
