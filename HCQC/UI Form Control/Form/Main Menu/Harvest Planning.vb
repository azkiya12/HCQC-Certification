Imports ZXing
Imports ZXing.Common
Imports DgvFilterPopup
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class Harvest_Planning

    Public Function GetDefaultPrinter() As String
        Dim settings As PrinterSettings = New PrinterSettings()
        Return settings.PrinterName
    End Function

    Private Sub Harvest_Planning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCQC_NewDataset.HarvestProduction' table. You can move, or remove it, as needed.
        'Me.HarvestProductionTableAdapter.Fill(Me.HCQC_NewDataset.HarvestProduction)

        LabelPrinter.Text = GetDefaultPrinter()

        Dim DgvFilter As New DgvFilterManager
        DgvFilter.DataGridView = MetroGrid1
        MetroGrid1.ColumnHeadersHeight = 25

        LinkReport.BackColor = Color.FromArgb(70, 179, 226)
        LinkReport.Style = MetroColorStyle.Black
        NavigationFrame1.Tag = "Page2"

        _ComboData("select  Year(input_date) FROM [HCQC_server].[dbo].[spl_request] group by Year(input_date) order by Year(input_date) desc", Me.ComboBtn1)
        ComboBtn1.Items.Add("Show All")
    End Sub

    Private Sub Harvest_Planning_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.Containermenu2.BtnHarvestPlan.Enabled = True
    End Sub

    Private Sub LinkData_Click(sender As Object, e As EventArgs) Handles LinkData.Click
        NavigationFrame1.SelectedPage = NavigationPage1
        NavigationFrame1.Tag = "Page1"
        LinkReport.BackColor = Color.Transparent
        LinkReport.Style = MetroColorStyle.Blue
        LinkData.Style = MetroColorStyle.Black
    End Sub

    Private Sub LinkReport_Click(sender As Object, e As EventArgs) Handles LinkReport.Click
        NavigationFrame1.SelectedPage = NavigationPage2
        NavigationFrame1.Tag = "Page2"
        LinkData.BackColor = Color.Transparent
        LinkData.Style = MetroColorStyle.Blue
        LinkReport.Style = MetroColorStyle.Black

    End Sub

    Private Sub LinkData_MouseEnter(sender As Object, e As EventArgs) Handles LinkData.MouseEnter
        LinkData.BackColor = Color.FromArgb(70, 179, 226)
    End Sub

    Private Sub LinkData_MouseLeave(sender As Object, e As EventArgs) Handles LinkData.MouseLeave
        If NavigationFrame1.Tag <> "Page1" Then
            LinkData.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub LinkReport_MouseEnter(sender As Object, e As EventArgs) Handles LinkReport.MouseEnter
        LinkReport.BackColor = Color.FromArgb(70, 179, 226)
    End Sub

    Private Sub LinkReport_MouseLeave(sender As Object, e As EventArgs) Handles LinkReport.MouseLeave
        If NavigationFrame1.Tag <> "Page2" Then
            LinkReport.BackColor = Color.Transparent
        End If

    End Sub

    '-------panel Barcode Production----------------

    Private Sub OnOptionsSave(ByVal strData As String)
        'Or whatever you want to do on frmMain with Options Data.
        LabelPrinter.Text = strData
    End Sub

    Sub ShowReport()
        Dim Vdt As New HCQC_NewDataset.report_a1_TableDataTable
        Dim dt As New HCQC_NewDataset.report_a1DataTable
        Dim ta As New HCQC_NewDatasetTableAdapters.report_a1TableAdapter
        Vdt.Clear()
        dt.Clear()

        'Filling Products DataTable from DB
        ta.Fill(dt) ''dibaca dt/report_a1DataTable akan di isi dengan sting SQL pada ta/TableAdapter

        For i As Integer = 0 To MetroGrid2.Rows.Count() - 1 Step +1
            'Dim check As Boolean = MetroGrid1.Rows(i).Cells(0).Value
            Dim row2 As DataGridViewRow = MetroGrid2.Rows(i)
            'If check = True Then
            Vdt.Rows.Add(row2.Cells(1).Value, ConvertToByteArray(EncodeBarCode(row2.Cells(1).Value, 65)))
            'End If
        Next

        'Create a AveryMailLabels report object
        'and set its data source with the DataSet

        Dim report As New report_a1     '--file Crystal Report yg akan tampil
        report.Database.Tables(0).SetDataSource(CType(dt, DataTable))
        report.Database.Tables(1).SetDataSource(CType(Vdt, DataTable))
        Print_Label.CrystalReportViewer1.ReportSource = report
        Print_Label.ShowDialog(Me)
    End Sub

    ''Funsi untuk menampilkan barcode dan Crystal Report
    ''--------------------------------------------------------------------------
    Public Shared Function ConvertToByteArray(ByVal value As Bitmap) As Byte()
        'Fungsion untuk Convert Bitmap to Byte Array
        Dim bitmapBytes As Byte()
        Using stream As New System.IO.MemoryStream
            value.Save(stream, System.Drawing.Imaging.ImageFormat.Png)
            bitmapBytes = stream.ToArray
        End Using
        Return bitmapBytes
    End Function

    Public Function EncodeBarCode(ByVal barcodeValue As String, ByVal barcodeSize As Int32) As Bitmap
        ''Fungsion untuk membuat BarCode Type128
        Dim Writer = New BarcodeWriter With
            {
            .Format = BarcodeFormat.CODE_128,
            .Options = New EncodingOptions() With {.Height = barcodeSize, .Width = barcodeSize, .Margin = 1}
            }
        Return Writer.Write(barcodeValue)
    End Function
    ''--------------------------------------------------------------------------


    Public Sub TermalPrintLA1()
        Dim VCode, VHarvest, VCrop, VKontrak, VnoRen As String
        Dim zplcom As String

        For Each row As DataGridViewRow In MetroGrid2.Rows
            VCode = CType(row.Cells("IdColumn").Value, String)

            VHarvest = CType(row.Cells("HarvestColumn2").Value, String)
            VCrop = CType(row.Cells("CropColumn").Value, String) 'header text AREA

            VKontrak = CType(row.Cells("ContractColumn").Value, String)
            VnoRen = CType(row.Cells("PlantColumn").Value, String)

            zplcom = "CT~~CD,~CC^~CT~
                        ^XA
                        ~TA000
                        ~JSN
                        ^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR6,6
                        ~SD30
                        ^JUS^LRN^CI27^PA0,1,1,0
                        ^XZ

                        ^XA
                        ^MMT^LS0
                        ^BY3,3,30^FT45,54^BCN,,Y,N
                        ^FH\^FD>;" & VCode.Insert(8, ">6") & "^FS
                        ^FT238,128^AAN,18,10^FB156,1,0,R^FH\^FD" & VnoRen & "^FS
                        ^FT19,107^A@N,14,13,TT0003M_^FH\^CI28^FDNo. Kontrak^FS^CI27
                        ^FT106,106^AAN,18,10^FB288,1,0,R^FH\^FD" & VKontrak & "^FS
                        ^FT19,128^A@N,14,13,TT0003M_^FH\^CI28^FDNo. Rencana Panen^FS^CI27
                        ^FT19,153^A@N,17,18,TT0003M_^FH\^CI28^FD" & VCrop & "^FS^CI27
                        ^FPH,1^FT269,153^A@N,17,18,TT0003M_^FB124,1,9,R^FH\^CI28^FDP: " & VHarvest & "^FS^CI27
                        ^BY3,3,30^FT469,54^BCN,,Y,N
                        ^FH\^FD>;" & VCode.Insert(8, ">6") & "^FS
                        ^FT662,128^AAN,18,10^FB156,1,0,R^FH\^FD" & VnoRen & "^FS
                        ^FT443,107^A@N,14,13,TT0003M_^FH\^CI28^FDNo. Kontrak^FS^CI27
                        ^FT530,106^AAN,18,10^FB288,1,0,R^FH\^FD" & VKontrak & "^FS
                        ^FT443,128^A@N,14,13,TT0003M_^FH\^CI28^FDNo. Rencana Panen^FS^CI27
                        ^FT443,153^A@N,17,18,TT0003M_^FH\^CI28^FD" & VCrop & "^FS^CI27
                        ^FPH,1^FT693,153^A@N,17,18,TT0003M_^FB124,1,9,R^FH\^CI28^FDP: " & VHarvest & "^FS^CI27
                        ^PQ" & trequestcopy.Text & ",0,1,Y
                        ^XZ"

            Printer.RawHelper.SendStringToPrinter(LabelPrinter.Text, zplcom)
        Next

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

        If MetroGrid1.Columns(e.ColumnIndex).Name = "CheckColumn" Then
            Dim count1 As Integer = 0
            For Each row As DataGridViewRow In MetroGrid1.Rows
                If row.Cells("CheckColumn").Value IsNot Nothing And row.Cells("CheckColumn").Value = True Then
                    count1 += 1
                End If
            Next
            LabelCount.Text = count1
        End If
    End Sub
    '------------------------------------------------------------------Fungsi untuk Checkbox Select All pada DataGrid
    Public Sub btnDelete_Click(sender As Object, e As EventArgs)
        ''Procedure to update status when button print label clicked
        Dim selectedRows As List(Of DataGridViewRow) = (From row In MetroGrid1.Rows.Cast(Of DataGridViewRow)()
                                                        Where Convert.ToBoolean(row.Cells("CheckColumn").Value) = True).ToList()
        'If MessageBox.Show(String.Format("Do you want to delete {0} rows?", selectedRows.Count), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
        For Each row As DataGridViewRow In selectedRows
            Using cmd As New SqlCommand("sp_InsertTglPrintLabel", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_login", SqlDbType.Int).Value = login.Luserid.Text
                cmd.Parameters.AddWithValue("@Id_barcode", row.Cells("IdcodeColumn").Value)  ''mengambil nilai/value dari dalam gridview.row.cell tertentu
                'cmd.Parameters.Add("@tgl_print", SqlDbType.DateTime).Value = Now
                cmd.Parameters.Add("@mark", SqlDbType.VarChar).Value = Print_Label.LabelMark.Text
                con.Open()
                cmd.ExecuteScalar()
                con.Close()
            End Using
        Next
        'Me.BindGrid()
        'End If
    End Sub

    Public Sub FlagRawStorage()
        ''mengirim tanda/flag/mark ke database telah di print
        For Each row As DataGridViewRow In MetroGrid2.Rows
            Using cmd As New SqlCommand("sp_InsertTglPrintLabel", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_login", SqlDbType.Int).Value = login.Luserid.Text
                cmd.Parameters.AddWithValue("@Id_barcode", row.Cells("IdColumn").Value)  ''mengambil nilai/value dari dalam gridview.row.cell tertentu

                cmd.Parameters.Add("@mark", SqlDbType.VarChar).Value = "LA1"
                con.Open()
                cmd.ExecuteScalar()
                con.Close()
            End Using
        Next
    End Sub
    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click

        ' loop to check if the checkbox cell is checked
        For i As Integer = 0 To MetroGrid1.Rows.Count() - 1 Step +1

            ' rowAlreadyExist => if the row already exist on MetroGrid2
            Dim rowAlreadyExist As Boolean = False
            Dim check As Boolean = MetroGrid1.Rows(i).Cells(0).Value
            Dim row As DataGridViewRow = MetroGrid1.Rows(i)
            If check = True Then

                ' the MetroGrid2 have one row or more
                If MetroGrid2.Rows.Count() > 0 Then

                    ' loop to see if the row already exist on MetroGrid2
                    For j As Integer = 0 To MetroGrid2.Rows.Count() - 1 Step +1
                        If row.Cells(1).Value.ToString() = MetroGrid2.Rows(j).Cells(1).Value.ToString() Then
                            rowAlreadyExist = True
                            Exit For
                        End If
                    Next

                    If rowAlreadyExist = False Then
                        MetroGrid2.Rows.Add(False,
                                            row.Cells("idcodecolumn1").Value.ToString(),
                                            row.Cells("varietycolumn1").Value.ToString(),
                                            row.Cells("areaColumn").Value.ToString(),
                                            row.Cells("norencanaColumn1").Value.ToString(),
                                            row.Cells("ContractColumn1").Value.ToString,
                                            SqlToBindingDate("[harvest]", row.Cells(1).Value.ToString()))
                    End If

                Else
                    MetroGrid2.Rows.Add(False,
                                            row.Cells("idcodecolumn1").Value.ToString(),
                                            row.Cells("varietycolumn1").Value.ToString(),
                                            row.Cells("areaColumn").Value.ToString(),
                                            row.Cells("norencanaColumn1").Value.ToString(),
                                            row.Cells("ContractColumn1").Value.ToString,
                                            SqlToBindingDate("[harvest]", row.Cells(1).Value.ToString()))
                End If
            End If
        Next
        Dim int As Integer
        int = MetroGrid2.Rows.Count()
        LabelCount.Text = int
    End Sub

    Function SqlToBindingDate(column As String, parameter As String)
        Dim hasil As String
        hasil = _DataToValue("SELECT convert(varchar, " & column & ", 103)
                              From  [harvestprod]
                              WHERE ([idcode]='" & parameter & "')")
        Return hasil
    End Function

    Private Sub BtnPreview_Click(sender As Object, e As EventArgs) Handles BtnPreview.Click
        If trequestcopy.Text <= 0 Then
            MetroMessageBox.Show(Me, "Number Of Copy must be more than 0")
            trequestcopy.Focus()
        Else
            If Not LabelCount.Text = "..." Then
                If String.IsNullOrEmpty(LabelCount.Text) = False And LabelCount.Text > 0 Then
                    If LabelPrinter.Text.Contains("ZPL") Then
                        ''proses cetak dengan menggunakan code ZPL
                        TermalPrintLA1()
                        ''menyimpan Log Production code yg di cetak ke dalam database
                        FlagRawStorage()
                    Else
                        ShowReport()
                    End If
                Else
                    MetroMessageBox.Show(Me, "1. Select kotak pada DataList")
                End If
            Else
                MetroMessageBox.Show(Me, "1. Select kotak pada DataList")
            End If
        End If
    End Sub
    Private Sub BindGrid()

        If ComboBtn1.Text = "Show All" Then
            'TODO: This line of code loads data into the 'HCQC_NewDataset.report_a1' table. You can move, or remove it, as needed.
            Me.Report_a1TableAdapter.Fill(Me.HCQC_NewDataset.report_a1)
        Else
            Me.Report_a1TableAdapter.FillByTahun(Me.HCQC_NewDataset.report_a1, ComboBtn1.Text)
        End If

        'Assign Click event to the DataGridView Cell.
        AddHandler MetroGrid1.CellContentClick, AddressOf DataGridView_CellClick
    End Sub

    Private Sub LInkRefresh_Click(sender As Object, e As EventArgs) Handles LInkRefresh.Click
        'Console.WriteLine(ComboBtn1.Text)
        If (String.IsNullOrEmpty(ComboBtn1.Text)) Then
            MessageBox.Show("klik Pilih Tahun... lalu klik Refresh untuk menampilkan data")
            Exit Sub
        End If
        BindGrid()
    End Sub

    Private Sub MetroLink2_Click(sender As Object, e As EventArgs) Handles MetroLink2.Click
        Me.Report_a1TableAdapter.FillByNotPrint(Me.HCQC_NewDataset.report_a1)
    End Sub

    Private Sub LabelPrinter_Click(sender As Object, e As EventArgs) Handles LabelPrinter.Click
        Dim Select_Printer = New Select_Printer
        AddHandler Select_Printer.SavedOptions, AddressOf OnOptionsSave
        Select_Printer.ShowDialog(Me)
    End Sub

    Private Sub LinkImport_Click(sender As Object, e As EventArgs) Handles LinkImport.Click
        Dim F_Import As Form = New Form_Import
        F_Import.ShowDialog(Me)
    End Sub

    Private Sub linkClearAll_Click(sender As Object, e As EventArgs) Handles linkClearAll.Click
        MetroGrid2.Rows.Clear()
        Dim int As Integer
        int = MetroGrid2.Rows.Count()
        LabelCount.Text = int
    End Sub

    Private Sub BtnSendBack_Click(sender As Object, e As EventArgs) Handles BtnSendBack.Click

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
        LabelCount.Text = int
    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        If (String.IsNullOrEmpty(ComboBtn1.Text)) Then
            MessageBox.Show("klik Pilih Tahun... lalu klik Refresh untuk menampilkan data")
            Return
        End If

        If ComboBtn1.Text = "Show All" Then
            'TODO: This line of code loads data into the 'HCQC_NewDataset.HarvestProduction' table. You can move, or remove it, as needed.
            Me.HarvestProductionTableAdapter.Fill(Me.HCQC_NewDataset.HarvestProduction)
        Else
            Me.HarvestProductionTableAdapter.FillByTahun(Me.HCQC_NewDataset.HarvestProduction, ComboBtn1.Text)
        End If
    End Sub

    Private Sub LinkDirectUpdateSAS_Click(sender As Object, e As EventArgs) Handles LinkDirectUpdateSAS.Click
        Dim f_direckFormUpload As Form = New DirectImportfromSAS
        f_direckFormUpload.ShowDialog(Me)
    End Sub

    Private Sub ComboBtn1_Click(sender As Object, e As EventArgs) Handles ComboBtn1.Click

    End Sub
End Class