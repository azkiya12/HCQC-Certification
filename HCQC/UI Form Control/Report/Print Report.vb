Public Class Print_Report
    Sub ShowReport_A4()
        Dim ParameterLab As New HCQC_NewDataset.LabnumDataTableDataTable
        Dim record As New HCQC_NewDataset.report_externalDataTable
        Dim ta As New HCQC_NewDatasetTableAdapters.report_externalTableAdapter
        'duplikasi column dari record
        Dim DestinationData As DataTable = record.Clone()

        '--file Crystal Report yg akan tampil
        Dim report As New External_Cerfication_v1

        ParameterLab.Clear()
        record.Clear()
        DestinationData.Clear()

        'For Each dr As DataRow In record.Rows
        '    copydata.Rows.Add(record.Rows)
        'Next
        For i As Integer = 0 To MetroGrid2.Rows.Count() - 1 Step +1
            'Dim check As Boolean = MetroGrid2.Rows(i).Cells(0).Value
            Dim row2 As DataGridViewRow = MetroGrid2.Rows(i)
            'If check = True Then
            ParameterLab.Rows.Add(row2.Cells(1).Value)
            'End If
            'Filling Products DataTable from DB
            ta.FillByVariable(record, "%" + Trim(row2.Cells(1).Value) + "%") ''dibaca dt/report_a1DataTable akan di isi dengan sting SQL pada ta/TableAdapter
            For Each dr As DataRow In record.Rows
                'pindahkan hasil filter/pencarian FillByVariable ke penampungan sementara DestinationData
                DestinationData.ImportRow(dr)
            Next

        Next

        'Create a AveryMailLabels report object
        'and set its data source with the DataSet
        report.Database.Tables(0).SetDataSource(CType(DestinationData, DataTable))
        report.Database.Tables(1).SetDataSource(CType(ParameterLab, DataTable))

        Print_Label.CrystalReportViewer1.ReportSource = report
        Print_Label.Show()

        For Each row As DataGridViewRow In MetroGrid2.Rows
            'Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("CheckColumn").Value)
            'If isSelected Then
            'End If
        Next
    End Sub

    Private Sub Print_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCQC_NewDataset.report_external' table. You can move, or remove it, as needed.
        ''ShowDataAdapter(sender, e)

    End Sub

    Private Sub tSearchReturn_ButtonClick(sender As Object, e As EventArgs) Handles tSearchReturn.ButtonClick
        If String.IsNullOrEmpty(Trim(tSearchReturn.Text)) Then
            ShowDataAdapter(sender, e)
        Else
            Me.Report_externalTableAdapter.FillByVariable(Me.HCQC_NewDataset.report_external, "%" + Trim(tSearchReturn.Text) + "%")
        End If
    End Sub

    Private Sub ShowDataAdapter(sender As Object, e As EventArgs)
        Me.Report_externalTableAdapter.Fill(Me.HCQC_NewDataset.report_external)
    End Sub

    Private Sub tSearchReturn_KeyDown(sender As Object, e As KeyEventArgs) Handles tSearchReturn.KeyDown
        If e.KeyCode = Keys.Enter Then
            tSearchReturn_ButtonClick(sender, e)
        End If
    End Sub

    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        ' loop to check if the checkbox cell is checked
        For i As Integer = 0 To MetroGrid1.Rows.Count() - 1 Step +1

            ' rowAlreadyExist => if the row already exist on MetroGrid2
            Dim rowAlreadyExist As Boolean = False
            Dim row As DataGridViewRow = MetroGrid1.Rows(i)
            Dim check As Boolean = MetroGrid1.Rows(i).Cells(0).Value

            If check = True Then

                'Check the MetroGrid2 have one row or more
                If MetroGrid2.Rows.Count() > 0 Then

                    'filtering loop to see if the row already exist on MetroGrid2
                    For j As Integer = 0 To MetroGrid2.Rows.Count() - 1 Step +1
                        'membandingkan MetroGrid1 pada Column(3) Lab number dengan MetroGrid2 pada Column(1) Lab number
                        If row.Cells(1).Value.ToString() = MetroGrid2.Rows(j).Cells(2).Value.ToString() Then
                            rowAlreadyExist = True
                            Exit For
                        End If
                    Next

                    If rowAlreadyExist = False Then
                        MetroGrid2.Rows.Add(False,
                                            row.Cells(2).Value.ToString(),
                                            row.Cells(3).Value.ToString(),
                                            row.Cells(8).Value.ToString(),
                                            row.Cells(9).Value.ToString(),
                                            row.Cells(10).Value,
                                            row.Cells(11).Value.ToString())
                    End If

                Else
                    MetroGrid2.Rows.Add(False,
                                            row.Cells(2).Value.ToString(),
                                            row.Cells(3).Value.ToString(),
                                            row.Cells(8).Value.ToString(),
                                            row.Cells(9).Value.ToString(),
                                            row.Cells(10).Value,
                                            row.Cells(11).Value.ToString())
                End If
            End If
        Next

        Dim int As Integer
        int = MetroGrid2.Rows.Count()
        LabelCount2.Text = int
    End Sub

    Private Sub BtnSendBack_Click(sender As Object, e As EventArgs) Handles BtnSendBack.Click
        ''menghapus row pada Datagrid2 yang terpilih(CheckBox Selected)
        For i As Integer = MetroGrid2.Rows.Count() - 1 To 0 Step -1
            Dim delete As Boolean
            delete = MetroGrid2.Rows(i).Cells(0).Value

            ' if the checkbox cell is checked
            If delete = True Then
                Dim row As DataGridViewRow
                row = MetroGrid2.Rows(i)
                MetroGrid2.Rows.Remove(row)
            End If
        Next

        Dim int As Integer
        int = MetroGrid2.Rows.Count()
        LabelCount2.Text = int
    End Sub

    Private Sub BtnPreview2_Click(sender As Object, e As EventArgs) Handles BtnPreview2.Click
        ShowReport_A4()
    End Sub

    Private Sub Print_Report_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub LinkClearAll_Click(sender As Object, e As EventArgs) Handles LinkClearAll.Click
        MetroGrid2.Rows.Clear()
        Dim int As Integer
        int = MetroGrid2.Rows.Count()
        LabelCount2.Text = int
    End Sub


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