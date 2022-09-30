Imports System.Data.SqlClient
Imports DgvFilterPopup

Public Class Data_Request
    Private Sub Add_Data_Request_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCQC_NewDataset.spl_request' table. You can move, or remove it, as needed.
        Me.Spl_requestTableAdapter.FillByThisMonth(Me.HCQC_NewDataset.spl_request)

        ''Menamoilkan nomor urut pada datagrid view
        Dim DgvFilter As New DgvFilterManager
        DgvFilter.DataGridView = MetroGrid1
        MetroGrid1.ColumnHeadersHeight = 25
    End Sub

    Private Sub Tsearch_ButtonClick(sender As Object, e As EventArgs) Handles Tsearch.ButtonClick
        If String.IsNullOrEmpty(LTrim(RTrim(Tsearch.Text))) Then
            MetroToolTip1.Show("text kosong", Tsearch, 0, 25, 3000)
        Else
            Me.Spl_requestTableAdapter.FillByParameter(Me.HCQC_NewDataset.spl_request, "%" + Trim(Tsearch.Text) + "%")
        End If
    End Sub

    Private Sub Tsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles Tsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Tsearch_ButtonClick(sender, e)
        End If
    End Sub

    Private Sub Tsearch_GotFocus(sender As Object, e As EventArgs) Handles Tsearch.GotFocus, Tsearch.Click
        Tsearch.SelectAll()
    End Sub

    Private Sub Data_Request_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub BtnPreview_Click(sender As Object, e As EventArgs) Handles BtnSend.Click

        ' loop to check if the checkbox cell is checked
        For i As Integer = 0 To MetroGrid1.Rows.Count() - 1 Step +1

            ' rowAlreadyExist => if the row already exist on MetroGrid2
            Dim rowAlreadyExist As Boolean = False
            Dim check As Boolean = MetroGrid1.Rows(i).Cells(0).Value
            Dim row As DataGridViewRow = MetroGrid1.Rows(i)
            If check = True Then

                'Check the MetroGrid2 have one row or more
                If Multy_Request_Sample.MetroGrid2.Rows.Count() > 0 Then

                    'filtering loop to see if the row already exist on MetroGrid2
                    For j As Integer = 0 To Multy_Request_Sample.MetroGrid2.Rows.Count() - 1 Step +1
                        'membandingkan MetroGrid1 pada Column(3) Lab number dengan MetroGrid2 pada Column(1) Lab number
                        If row.Cells(3).Value.ToString() = Multy_Request_Sample.MetroGrid2.Rows(j).Cells(1).Value.ToString() Then
                            rowAlreadyExist = True
                            Exit For
                        End If
                    Next

                    If rowAlreadyExist = False Then
                        Multy_Request_Sample.MetroGrid2.Rows.Add(
                                            False,
                                            row.Cells(1).Value,
                                            row.Cells(2).Value.ToString(),
                                            row.Cells(3).Value.ToString(),
                                            row.Cells(4).Value.ToString(),
                                            CDate(row.Cells(5).Value),
                                            row.Cells(6).Value.ToString(),
                                            row.Cells(7).Value.ToString(),
                                            row.Cells(8).Value,
                                            row.Cells(9).Value)
                    End If

                Else
                    Multy_Request_Sample.MetroGrid2.Rows.Add(
                                            False,
                                            row.Cells(1).Value,
                                            row.Cells(2).Value.ToString(),
                                            row.Cells(3).Value.ToString(),
                                            row.Cells(4).Value.ToString(),
                                            CDate(row.Cells(5).Value),
                                            row.Cells(6).Value.ToString(),
                                            row.Cells(7).Value.ToString(),
                                            row.Cells(8).Value,
                                            row.Cells(9).Value)
                End If
            End If
        Next
    End Sub

    Private Sub LInkRefresh_Click(sender As Object, e As EventArgs) Handles LInkRefresh.Click
        Me.Spl_requestTableAdapter.FillByThisMonth(Me.HCQC_NewDataset.spl_request)
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Me.Close()
    End Sub

    Private Sub tsearch_KeyUp(sender As Object, e As KeyEventArgs)
        'MetroGrid1.DataSource = Me.PopulateDataGridView()
    End Sub

    'Private Function PopulateDataGridView() As DataTable
    '    Dim query As String = "SELECT   [id_hvsprod]
    '                                    ,[variety]
    '                                    ,[farmer]
    '                                    ,[location]
    '                                    ,[harvest]
    '                                    ,[nomnl]
    '                                    ,[nojob]
    '                                    ,[weight]
    '                                    ,[bag]
    '                                    ,[scope]
    '                                    ,[test_moi]
    '                                    ,[test_raf]
    '                                    ,[test_pur]
    '                                    ,[test_ger]
    '                                    ,[test_via]
    '                                    ,[remark]
    '                                    ,[input_date]
    '                                FROM [HCQC_server].[dbo].[spl_request]"
    '    query &= " Where [id_hvsprod] Like '%' + @SearchTerm + '%'"
    '    query &= " OR [variety] LIKE '%' + @SearchTerm + '%'"
    '    query &= " OR [farmer] LIKE '%' + @SearchTerm + '%'"
    '    query &= " OR [location] LIKE '%' + @SearchTerm + '%'"
    '    query &= " OR [nomnl] LIKE '%' + @SearchTerm + '%'"
    '    query &= " OR [nojob] LIKE '%' + @SearchTerm + '%'"
    '    query &= " OR [weight] LIKE '%' + @SearchTerm + '%'"
    '    query &= " OR [scope] LIKE '%' + @SearchTerm + '%'"
    '    query &= " OR [input_date] LIKE '%' + @SearchTerm + '%'"
    '    query &= " OR @SearchTerm = ''"

    '    Using cmd = New SqlCommand(query, con)
    '        cmd.Parameters.AddWithValue("@SearchTerm", tsearch.Text.Trim())
    '        Using adapter = New SqlDataAdapter(cmd)
    '            Dim dt As DataTable = New DataTable()
    '            adapter.Fill(dt)
    '            Return dt
    '        End Using
    '    End Using

    '    ''Menamoilkan nomor urut pada datagrid view
    '    Dim DgvFilter As New DgvFilterManager
    '    DgvFilter.DataGridView = MetroGrid1
    '    MetroGrid1.ColumnHeadersHeight = 25
    'End Function


    'Fungsi untuk Checkbox Select All pada DataGrid------------------------------------------------------------------
    Private Sub HeaderCheckBox_Clicked(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox1.Click
        'Necessary to end the edit mode of the Cell.
        MetroGrid1.EndEdit()

        'Loop and check and uncheck all row CheckBoxes based on Header Cell CheckBox.
        For Each row As DataGridViewRow In MetroGrid1.Rows
            Dim checkBox As DataGridViewCheckBoxCell = (TryCast(row.Cells("CheckColumn"), DataGridViewCheckBoxCell))
            checkBox.Value = CheckBox1.Checked
        Next
    End Sub
    Private Sub DataGridView_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        'Check to ensure that the row CheckBox is clicked.
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then

            'Loop to verify whether all row CheckBoxes are checked or not.
            Dim isChecked As Boolean = True
            For Each row As DataGridViewRow In MetroGrid1.Rows
                If Convert.ToBoolean(row.Cells("CheckColumn").EditedFormattedValue) = False Then
                    isChecked = False

                    Exit For
                End If
            Next
            CheckBox1.Checked = isChecked
        End If

    End Sub

    Private Sub MetroGrid1_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles MetroGrid1.RowPostPaint
        'penomoran pada MetroGrid2 view
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

    Public Sub dataGridView1_CountSelected(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles MetroGrid1.CellValueChanged
        'If MetroGrid1.Columns(e.ColumnIndex).Name = "CheckColumn" Then
        '    Dim count1 As Integer = 0
        '    For Each row As DataGridViewRow In MetroGrid1.Rows
        '        If row.Cells("CheckColumn").Value IsNot Nothing And row.Cells("CheckColumn").Value = True Then
        '            count1 += 1
        '        End If
        '    Next
        '    LabelCount.Text = count1
        'End If
    End Sub




    '------------------------------------------------------------------Fungsi untuk Checkbox Select All pada DataGrid
End Class