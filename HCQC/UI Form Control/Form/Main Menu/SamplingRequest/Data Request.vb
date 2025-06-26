Imports DgvFilterPopup

Public Class Data_Request

    Public Event UploadCompleted As EventHandler
    Public Event ImportSelesai(dtResult As DataTable)
    Private dtLocal As New DataTable
    Dim FirstBuiltColumn As Boolean = False
    Private Sub SetupDataTable()
        With dtLocal.Columns
            If Not .Contains("CheckColumn1") Then .Add("CheckColumn1", GetType(Boolean))
            If Not .Contains("ProductionCodeColumn") Then .Add("ProductionCodeColumn", GetType(String))
            If Not .Contains("dovendorColumn") Then .Add("dovendorColumn", GetType(String))
            If Not .Contains("VarietyColumn") Then .Add("VarietyColumn", GetType(String))
            If Not .Contains("InsplotColumn") Then .Add("InsplotColumn", GetType(String))
            If Not .Contains("FarmerColumn") Then .Add("FarmerColumn", GetType(String))
            If Not .Contains("LocationColumn") Then .Add("LocationColumn", GetType(String))
            If Not .Contains("HarvestColumn") Then .Add("HarvestColumn", GetType(String))
            If Not .Contains("ManualColumn") Then .Add("ManualColumn", GetType(String))
            If Not .Contains("LotColumn") Then .Add("LotColumn", GetType(String))
            If Not .Contains("WeightColumn") Then .Add("WeightColumn", GetType(Decimal))
            If Not .Contains("UnitColumn") Then .Add("UnitColumn", GetType(String))
            If Not .Contains("BagColumn") Then .Add("BagColumn", GetType(String))
            If Not .Contains("smplLocation") Then .Add("smplLocation", GetType(String))
            If Not .Contains("ScopeColumn") Then .Add("ScopeColumn", GetType(String))
            If Not .Contains("KetColumn") Then .Add("KetColumn", GetType(String))
            If Not .Contains("TestRequest") Then .Add("TestRequest", GetType(String))
            If Not .Contains("SPL") Then .Add("SPL", GetType(Boolean))
            If Not .Contains("KesBnh") Then .Add("KesBnh", GetType(Boolean))
            If Not .Contains("MOI") Then .Add("MOI", GetType(Boolean))
            If Not .Contains("PUR") Then .Add("PUR", GetType(Boolean))
            If Not .Contains("RAF") Then .Add("RAF", GetType(Boolean))
            If Not .Contains("GER") Then .Add("GER", GetType(Boolean))
            If Not .Contains("VIA") Then .Add("VIA", GetType(Boolean))
        End With
    End Sub
    Private Sub ProsesUploadSelesai()
        ' Ini dipanggil ketika proses upload selesai
        RaiseEvent UploadCompleted(Me, EventArgs.Empty)
    End Sub

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
        Dim targetForm As Multy_Request_Sample = Application.OpenForms.OfType(Of Multy_Request_Sample)().FirstOrDefault()

        ' loop to check if the checkbox cell is checked
        For i As Integer = 0 To MetroGrid1.Rows.Count() - 1 Step +1
            SetupDataTable()

            Dim row As DataGridViewRow = MetroGrid1.Rows(i)

            Dim check As Boolean = MetroGrid1.Rows(i).Cells(0).Value
            If check = True Then
                ' rowAlreadyExist => if the row already exist on MetroGrid2
                Dim rowAlreadyExist As Boolean = False
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

                    If targetForm IsNot Nothing AndAlso targetForm.dtTransfer IsNot Nothing Then
                        ' Buat baris baru
                        Dim newRow As DataRow = targetForm.dtTransfer.NewRow()
                        newRow("CheckColumn1") = False
                        newRow("ProductionCodeColumn") = row.Cells("id_hvsprodColumn").Value
                        newRow("dovendorColumn") = ""
                        newRow("VarietyColumn") = row.Cells("VarietyDataGridViewTextBoxColumn").Value.ToString()
                        newRow("InsplotColumn") = row.Cells("insplot").Value.ToString()
                        newRow("FarmerColumn") = row.Cells("FarmerDataGridViewTextBoxColumn").Value.ToString()
                        newRow("LocationColumn") = row.Cells("LocationDataGridViewTextBoxColumn").Value.ToString()
                        newRow("HarvestColumn") = Convert.ToDateTime(row.Cells("HarvestDataGridViewTextBoxColumn").Value).ToString("dd-MM-yyyy")
                        newRow("ManualColumn") = row.Cells("NomnlDataGridViewTextBoxColumn").Value.ToString()
                        newRow("LotColumn") = row.Cells("NojobDataGridViewTextBoxColumn").Value.ToString()
                        newRow("WeightColumn") = row.Cells("WeightDataGridViewTextBoxColumn").Value
                        newRow("UnitColumn") = "KG"
                        newRow("BagColumn") = row.Cells("bagColumn").Value
                        newRow("smplLocation") = row.Cells("loc_sample").Value
                        newRow("ScopeColumn") = ""
                        newRow("KetColumn") = row.Cells("RemarkDataGridViewTextBoxColumn").Value
                        newRow("TestRequest") = ""
                        newRow("SPL") = False
                        newRow("KesBnh") = False
                        newRow("MOI") = False
                        newRow("PUR") = False
                        newRow("RAF") = False
                        newRow("GER") = False
                        newRow("VIA") = False

                        ' Tambah ke DataTable
                        targetForm.dtTransfer.Rows.Add(newRow)
                    Else
                        MessageBox.Show("Gagal menambahkan baris. Form tujuan tidak ditemukan atau belum diisi.")
                    End If

                Else
                    dtLocal.Rows.Add(
                            False,
                            row.Cells("id_hvsprodColumn").Value,
                            "",
                            row.Cells("VarietyDataGridViewTextBoxColumn").Value.ToString(),
                            row.Cells("insplot").Value.ToString(),
                            row.Cells("FarmerDataGridViewTextBoxColumn").Value.ToString(),
                            row.Cells("LocationDataGridViewTextBoxColumn").Value.ToString(),
                            Convert.ToDateTime(row.Cells("HarvestDataGridViewTextBoxColumn").Value).ToString("dd-MM-yyyy"),
                            row.Cells("NomnlDataGridViewTextBoxColumn").Value.ToString(),
                            row.Cells("NojobDataGridViewTextBoxColumn").Value.ToString(),
                            row.Cells("WeightDataGridViewTextBoxColumn").Value,
                            "KG",
                            row.Cells("bagColumn").Value,
                            row.Cells("loc_sample").Value,
                            "",
                            row.Cells("RemarkDataGridViewTextBoxColumn").Value,
                            "",
                            False,
                            False,
                            False,
                            False,
                            False,
                            False,
                            False)

                    FirstBuiltColumn = True
                End If
            End If
        Next

        If FirstBuiltColumn Then
            ' Setelah semua baris ditambahkan ke dtTransfer
            RaiseEvent ImportSelesai(dtLocal)
            ProsesUploadSelesai()
            FirstBuiltColumn = False
        End If

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


    'Fungsi untuk Checkbox Select All pada DataGrid--------------------------------------------------------
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