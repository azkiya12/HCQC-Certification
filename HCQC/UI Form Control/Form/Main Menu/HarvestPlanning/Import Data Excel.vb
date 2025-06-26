Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Globalization
Imports DevExpress.XtraBars


Public Class Import_Data_Excel
    Private barManager1 As BarManager
    Private popupMenu1 As PopupMenu
    Private btnGravity As BarButtonItem
    Private btnRawMaterial As BarButtonItem

    ' Di dalam Import_Data_Excel.vb
    Public Event UploadCompleted As EventHandler
    Public Property CallerSource As FormCaller

    Public Event ImportSelesai(dtResult As DataTable)

    Private dtLocal As New DataTable
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

    Public Sub SetCallerSource(source As FormCaller)
        Me.CallerSource = source

        Select Case source
            Case FormCaller.Multy_Request_Sample
                BtnUploadServer.Text = "Transfer to Multiple"
            Case FormCaller.Harvest_Planning
                BtnUploadServer.Text = "Upload Server"
            Case Else
                BtnUploadServer.Text = "Transfer"
        End Select
    End Sub

    Private Sub Raw_Material()

        MetroProgressBar1.Visible = True
        MetroProgressBar1.Maximum = MetroGrid1.Rows.Count
        ' Flag untuk mengecek jika insert berhasil
        Dim insertedRowCount As Integer = 0
        Dim parentForm As Form_Import = TryCast(Me.FindForm(), Form_Import)
        '-- proses upload to database
        If parentForm.CallerSource = FormCaller.Multy_Request_Sample Then

        End If
        Try

            openDB()
            Using cmd1 As New SqlCommand("sp_HarvestProd", con)
                cmd1.CommandType = CommandType.StoredProcedure

                ' Parameter Input
                cmd1.Parameters.Add("@harvest", SqlDbType.SmallDateTime)
                cmd1.Parameters.Add("@variety", SqlDbType.VarChar)
                cmd1.Parameters.Add("@norencana", SqlDbType.VarChar)
                cmd1.Parameters.Add("@nokontrak", SqlDbType.VarChar)
                cmd1.Parameters.Add("@blokno", SqlDbType.VarChar)
                cmd1.Parameters.Add("@cgrname", SqlDbType.VarChar)
                cmd1.Parameters.Add("@dusun", SqlDbType.VarChar)
                cmd1.Parameters.Add("@id_login", SqlDbType.Int)
                cmd1.Parameters.Add("@joblot", SqlDbType.VarChar)
                cmd1.Parameters.Add("@area", SqlDbType.VarChar)
                cmd1.Parameters.Add("@plant_qty", SqlDbType.Decimal)
                cmd1.Parameters.Add("@upload_id", SqlDbType.VarChar)

                ' Parameter Output
                Dim idParam As New SqlParameter("@IDCode", SqlDbType.Int)
                idParam.Direction = ParameterDirection.Output
                cmd1.Parameters.Add(idParam)

                For i As Integer = 0 To MetroGrid1.Rows.Count - 1
                    With cmd1
                        .Parameters("@harvest").Value = MetroGrid1.Rows(i).Cells("Transactio").Value
                        .Parameters("@area").Value = MetroGrid1.Rows(i).Cells("StorageLo").Value
                        .Parameters("@variety").Value = MetroGrid1.Rows(i).Cells("MaterialD").Value
                        .Parameters("@plant_qty").Value = CDec(MetroGrid1.Rows(i).Cells("QTYGRGI").Value)
                        .Parameters("@nokontrak").Value = MetroGrid1.Rows(i).Cells("ContractNo").Value
                        .Parameters("@norencana").Value = MetroGrid1.Rows(i).Cells("IDVendor").Value
                        .Parameters("@blokno").Value = MetroGrid1.Rows(i).Cells("Material").Value
                        .Parameters("@cgrname").Value = MetroGrid1.Rows(i).Cells("CGRName").Value
                        .Parameters("@dusun").Value = MetroGrid1.Rows(i).Cells("Dusun").Value
                        .Parameters("@joblot").Value = MetroGrid1.Rows(i).Cells("Batch").Value
                        .Parameters("@id_login").Value = login.Luserid.Text
                        .Parameters("@upload_id").Value = GetIPAddress()
                    End With

                    ' Eksekusi dan validasi hasil
                    Dim ekse = cmd1.ExecuteNonQuery()

                    If ekse > 0 Then
                        insertedRowCount += 1

                        If parentForm IsNot Nothing Then
                            If parentForm.CallerSource = FormCaller.Multy_Request_Sample Then
                                Dim newID As Integer = CInt(cmd1.Parameters("@IDCode").Value)
                                ' Tambahkan ke Grid2
                                Multy_Request_Sample.MetroGrid2.Rows.Add(
                                    False,
                                    newID.ToString(), ' ← Gunakan ID dari SP
                                    MetroGrid1.Rows(i).Cells("IDVendor").Value.ToString(),
                                    MetroGrid1.Rows(i).Cells("MaterialD").Value.ToString(),
                                    "",  ' Insp. lot RM
                                    MetroGrid1.Rows(i).Cells("CGRName").Value.ToString(),
                                    MetroGrid1.Rows(i).Cells("Dusun").Value.ToString(),
                                    MetroGrid1.Rows(i).Cells("Transactio").Value,
                                    "",  ' Manual
                                    MetroGrid1.Rows(i).Cells("Batch").Value,
                                    MetroGrid1.Rows(i).Cells("QTYGRGI").Value,
                                    "KG",
                                    "1",
                                    MetroGrid1.Rows(i).Cells("StorageLo").Value,
                                    "Raw Material"
                                )
                            End If
                        End If

                    End If

                    MetroProgressBar1.Value = i + 1
                Next
                Multy_Request_Sample.TComboScope.SelectedIndex = 0
            End Using

            If insertedRowCount > 0 Then
                MetroMessageBox.Show(Me, "Upload Harvest Production berhasil: " & insertedRowCount & " baris", "Upload", MessageBoxButtons.OK, MessageBoxIcon.Information, 211)

                MetroProgressBar1.Visible = False
                ProsesUploadSelesai()
            Else
                MessageBox.Show("Tidak ada data yang berhasil masuk ke database. Kemungkinan data sudah pernah ada.", "Gagal Upload", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        Finally
            con.Close()
            MetroProgressBar1.Visible = False
        End Try

    End Sub

    Private Sub Gravity()

        MetroProgressBar1.Visible = True
        MetroProgressBar1.Maximum = MetroGrid1.Rows.Count

        '' proses upload parent form import masal gravity
        '' loop to check if the checkbox cell is checked
        For i As Integer = 0 To MetroGrid1.Rows.Count - 1
            Dim row As DataGridViewRow = MetroGrid1.Rows(i)

            ' 🧠 Ambil data dinamis
            Dim dataRow As DataRow = GetHarvestProdData(row)

            ' Siapkan default
            Dim idcode As String = ""
            Dim cgrname As String = ""
            Dim dusun As String = ""
            Dim harvest As String = ""
            Dim nomnl As String = ""

            If dataRow IsNot Nothing Then
                idcode = dataRow("idcode").ToString()
                cgrname = dataRow("cgrname").ToString()
                dusun = dataRow("dusun").ToString()
                nomnl = dataRow("nomnl").ToString()
                If Not IsDBNull(dataRow("harvest")) Then
                    harvest = Convert.ToDateTime(dataRow("harvest")).ToString("dd-MM-yyyy")
                End If
            End If

            SetupDataTable()

            ' Jika CodeProd kodong dan terdapat IDVendor tambahkan IDVendor pada kolom farmer
            ' Untuk memudahkan identifikasi ID Vendor
            Dim doVendor As String = row.Cells("IDVendor").Value
            If String.IsNullOrWhiteSpace(idcode) And Not String.IsNullOrWhiteSpace(doVendor) Then
                cgrname = cgrname & " / " & row.Cells("IDVendor").Value
            End If

            dtLocal.Rows.Add(
                False,
                idcode,
                row.Cells("IDVendor").Value,
                row.Cells("MatDescription").Value,
                row.Cells("InspLot").Value,
                cgrname,
                dusun,
                harvest,
                nomnl,
                row.Cells("Batch").Value,
                Convert.ToDecimal(row.Cells("LotSize").Value),
                row.Cells("Unit").Value,
                "1",
                row.Cells("StorageLo").Value,
                "",
                row.Cells("Keterangan").Value,
                "",
                False,
                False,
                False,
                False,
                False,
                False,
                False
)
        Next

        ' Setelah semua baris ditambahkan ke dtTransfer
        RaiseEvent ImportSelesai(dtLocal)
        ProsesUploadSelesai()
    End Sub

    Private Function GetHarvestProdData(row As DataGridViewRow) As DataRow
        Dim dt As New DataTable()

        Try
            openDB()
            Dim cmd As New SqlCommand()
            cmd.Connection = con

            ' Ambil IDVendor dari row
            Dim idVendor As String = row.Cells("IDVendor").Value?.ToString()?.Trim()

            If Not String.IsNullOrEmpty(idVendor) Then
                ' ✅ Query jika IDVendor tersedia
                cmd.CommandText = "SELECT idcode, cgrname, dusun, harvest,'' AS nomnl FROM harvestprod WHERE norencana = @norencana"
                cmd.Parameters.AddWithValue("@norencana", idVendor)

            Else
                ' ✅ Cek nilai Batch
                Dim batch As String = row.Cells("Batch").Value?.ToString()?.Trim()

                If Not String.IsNullOrEmpty(batch) AndAlso batch.StartsWith("SA.") Then
                    Dim nojob As String = batch.Substring(3) ' hilangkan "SA."

                    ' Query ke spl_request
                    cmd.CommandText = "SELECT TOP 1 id_hvsprod AS idcode, farmer AS cgrname, location AS dusun, harvest, nomnl 
                                   FROM HCQC_server.dbo.spl_request 
                                   WHERE nojob = @nojob AND scope = 'Raw Material'"
                    cmd.Parameters.AddWithValue("@nojob", nojob)
                Else
                    Return Nothing
                End If
            End If

            ' 🔄 Eksekusi query
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)

        Catch ex As Exception
            MsgBox("GetHarvestProdData Error: " & ex.Message)
            Return Nothing
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

        ' ✅ Kembalikan baris pertama jika ada hasil
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)
        End If

        Return Nothing
    End Function


    Private Sub btnOpenFileExcel_Click(sender As Object, e As EventArgs) Handles btnOpenFileExcel.Click
        MetroGrid1.Columns.Clear()

        If Not String.IsNullOrEmpty(MetroTextBox1.Text) Then
            ' Misal TextBox kamu bernama MetroTextBox1
            Dim fullPath As String = MetroTextBox1.Text.Trim()
            ' Ambil hanya nama file
            Dim sheetname As String = System.IO.Path.GetFileNameWithoutExtension(fullPath)
            'Dim filePath As String = openFileDialog.FileName
            Dim dt As DataTable = ReadExcelToDataTable(MetroTextBox1.Text)
            'Dim dtC As DataTable = ReadExcelToDataTableClosed(MetroTextBox1.Text)

            MetroGrid1.DataSource = dt ' Menampilkan di DataGridView

        Else
            MetroMessageBox.Show(Form.ActiveForm, "Please Select file fist...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
        End If

        If MetroGrid1.Rows.Count <= 0 Then
            BtnUploadServer.Enabled = False
        Else
            BtnUploadServer.Enabled = True
        End If

        ' Menampilkan di Output Window (Debug)
        'For Each column As DataGridViewColumn In MetroGrid1.Columns
        '    Debug.WriteLine("nama Column " + column.Name)
        'Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If Not String.IsNullOrEmpty(MetroTextBox1.Text) Then
            'ReadCSVGoogle(MetroTextBox1.Text)
        Else
            MetroMessageBox.Show(Form.ActiveForm, "Please 'Click to Browse...' and Select file first...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
        End If

    End Sub

    Private Function ReadExcelToDataTable(ByVal filePath As String, Optional sheetName As String = "Sheet1") As DataTable

        Dim extension As String = System.IO.Path.GetExtension(filePath).ToLower()
        Dim connectionString As String
        ' Koneksi ke Excel
        Select Case extension
            Case ".xls"


                ' Untuk file Excel 97-2003
                connectionString = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={filePath};Extended Properties='Excel 8.0;HDR=YES;IMEX=1';"
            Case ".xlsx"
                ' Untuk file Excel 2007 ke atas
                connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath};Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1';"
            Case ".csv", ".txt"

                connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath};Extended Properties='Text;HDR=YES;FMT=Delimited';"
            Case Else

                Throw New Exception("Format file tidak dikenali: " & extension)
        End Select

        Dim query As String = "SELECT * FROM [" & sheetName & "$]" ' Ambil semua kolom untuk validasi

        'Dim query As String = "SELECT * FROM [" & sheetName & extension & "]" ' Ambil semua kolom untuk validasi
        Dim kategori As String = "Unknown"
        Dim dt As New DataTable()

        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Using command As New OleDbCommand(query, connection)
                    Using adapter As New OleDbDataAdapter(command)
                        Dim tempTable As New DataTable()
                        adapter.Fill(tempTable) ' Mengisi DataTable sementara
                        ' Simbol lain yang sering diubah: /, -, . → jadi #
                        ' Tentukan kategori
                        If tempTable.Columns.Contains("DO Vendor") Then
                            btnOpenFileExcel.Tag = "rawmaterial"
                            kategori = "RM"
                        ElseIf tempTable.Columns.Contains("Insp# Lot") Then
                            btnOpenFileExcel.Tag = "gravity"
                            kategori = "Gravity"
                        Else
                            MessageBox.Show("Error: Kolom 'DO Vendor' atau 'Insp. Lot' tidak ditemukan dalam file Excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return dt ' Mengembalikan DataTable kosong jika kategori tidak ditemukan
                        End If

                        ' Buat struktur tabel
                        If kategori = "RM" Then
                            dt.Columns.Add("IDVendor", GetType(String))
                            dt.Columns.Add("ContractNo", GetType(String))
                            dt.Columns.Add("CGRName", GetType(String))
                            dt.Columns.Add("Dusun", GetType(String))
                            dt.Columns.Add("Material", GetType(String))
                            dt.Columns.Add("MaterialD", GetType(String))
                            dt.Columns.Add("StorageLo", GetType(String))
                            dt.Columns.Add("Batch", GetType(String))
                            dt.Columns.Add("QTYGRGI", GetType(Decimal))
                            dt.Columns.Add("Transactio", GetType(String))

                        ElseIf kategori = "Gravity" Then
                            dt.Columns.Add("InspLot", GetType(String))
                            dt.Columns.Add("Material", GetType(String))
                            dt.Columns.Add("MatDescription", GetType(String))
                            dt.Columns.Add("Batch", GetType(String))
                            dt.Columns.Add("StorageLo", GetType(String))
                            dt.Columns.Add("LotSize", GetType(Decimal))
                            dt.Columns.Add("Unit", GetType(String))
                            dt.Columns.Add("IDVendor", GetType(String))
                            dt.Columns.Add("Keterangan", GetType(String))
                        End If

                        ' Proses isi data
                        For Each row As DataRow In tempTable.Rows
                            ' Cek apakah "IDVendor" kosong, jika kosong skip baris ini
                            If kategori = "RM" AndAlso (IsDBNull(row("DO Vendor")) OrElse String.IsNullOrWhiteSpace(row("DO Vendor").ToString())) Then
                                Continue For ' Skip baris ini jika "IDVendor" kosong
                            End If

                            ' Buat baris baru untuk DataTable hasil
                            Dim newRow As DataRow = dt.NewRow()

                            If kategori = "RM" Then
                                newRow("IDVendor") = SafeString(row, "DO Vendor")
                                newRow("ContractNo") = SafeString(row, "Contract No")
                                Debug.WriteLine("DO Vendor: " & row("Contract No").ToString())
                                newRow("CGRName") = SafeString(row, "CGR Name")
                                newRow("Material") = SafeString(row, "Material")
                                newRow("MaterialD") = SafeString(row, "Material D")
                                newRow("StorageLo") = SafeString(row, "Storage Lo")
                                newRow("Batch") = SafeString(row, "Batch")
                                newRow("QTYGRGI") = SafeConvertToDecimal(row, "QTY GR/GI")
                                newRow("Transactio") = SafeDateConvertToStringDateOnly(row, "Transactio")
                            ElseIf kategori = "Gravity" Then
                                newRow("InspLot") = SafeString(row, "Insp# Lot")
                                newRow("Material") = SafeString(row, "Material")
                                newRow("MatDescription") = SafeString(row, "Material description")
                                newRow("Batch") = SafeString(row, "Batch")
                                newRow("StorageLo") = SafeString(row, "Stor# loc#")
                                newRow("LotSize") = SafeConvertToDecimal(row, "Lot Size")
                                newRow("Unit") = SafeString(row, "Bun")
                                newRow("IDVendor") = GetFirstValueFromSafeString(row, "DO Vendor ID")
                                newRow("Keterangan") = SafeString(row, "DO Vendor ID")
                            End If

                            dt.Rows.Add(newRow)
                        Next

                        ' Menampilkan kategori dalam MessageBox
                        MessageBox.Show("Kategori Data: " & kategori, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error Upload Excel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    Private Function SafeDateConvertToStringDateOnly(row As DataRow, columnName As String) As String
        ' Periksa apakah kolom tersedia dan tidak null
        If Not row.Table.Columns.Contains(columnName) OrElse IsDBNull(row(columnName)) Then
            Return Today
        End If

        Try
            Dim value = row(columnName)

            ' Jika sudah Date
            If TypeOf value Is Date Then
                Return CDate(value).ToString("dd-MM-yyyy")
            End If

            ' Jika numeric (serial number Excel)
            If IsNumeric(value) Then
                Dim dt = DateTime.FromOADate(Convert.ToDouble(value))
                Return dt.ToString("dd-MM-yyyy")
            End If

            ' Jika string, coba parse
            Dim strVal As String = value.ToString().Trim()
            Dim parsedDate As DateTime
            If DateTime.TryParse(strVal, parsedDate) Then
                Return parsedDate.ToString("dd-MM-yyyy")
            End If

        Catch ex As Exception
            ' Jika gagal parsing, bisa log error jika dibutuhkan
        End Try

        Return Today
    End Function


    ' Penjelasan Fungsi SafeConvertToDecimal
    ' Mengatasi input dengan ribuan seperti 1.234,56 menjadi 1,234.56.
    ' Menggunakan InvariantCulture untuk memastikan titik (.) dikenali sebagai desimal.
    ' Jika input kosong atau invalid, akan mengembalikan 0.

    Private Function SafeConvertToDecimal(row As DataRow, columnName As String) As Decimal
        Try
            Dim value As String = row(columnName).ToString().Trim()

            ' Kosong → 0
            If String.IsNullOrWhiteSpace(value) Then Return 0D

            ' Tukar koma ke titik jika perlu
            value = value.Replace(",", ".")

            ' Coba parse pakai CultureInfo Invariant (format desimal titik)
            Return Decimal.Parse(value, NumberStyles.Any, CultureInfo.InvariantCulture)
        Catch
            ' Jika gagal parse, kembalikan 0
            Return 0D
        End Try
    End Function

    ' Fungsi Pendukung: Safe String Helper
    Private Function SafeString(row As DataRow, columnName As String) As String
        If row.Table.Columns.Contains(columnName) AndAlso Not IsDBNull(row(columnName)) Then
            Return row(columnName).ToString().Trim()
        End If
        Return ""
    End Function

    Private Function GetFirstValueFromSafeString(row As DataRow, columnName As String) As String
        Try
            Dim rawValue As String = row(columnName).ToString().Trim()

            If String.IsNullOrWhiteSpace(rawValue) Then
                Return ""
            End If

            ' Ambil nilai pertama dari string yang dipisah koma
            Dim parts() As String = rawValue.Split(","c)
            If parts.Length > 0 Then
                Return parts(0).Trim()
            Else
                Return ""
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub MetroTextBox1_Click(sender As Object, e As EventArgs) Handles MetroTextBox1.Click

        '' -- Open file directory
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Open File Production"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All Files (*.*)|*.*|Excel Files|*.xls;*.xlsx|CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt"
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

    Private Sub BtnUploadServer_Click(sender As Object, e As EventArgs) Handles BtnUploadServer.Click
        If btnOpenFileExcel.Tag = "gravity" Then
            Gravity()
            Dispose()
        ElseIf btnOpenFileExcel.Tag = "rawmaterial" Then
            Raw_Material()
        End If
    End Sub

    Private Sub MetroGrid1_Validating(sender As Object, e As CancelEventArgs) Handles MetroGrid1.Validating
        If MetroGrid1.Rows.Count <= 0 Then
            BtnUploadServer.Enabled = False
        Else
            BtnUploadServer.Enabled = True
        End If
    End Sub

    Private Sub Import_Data_Excel_Load(sender As Object, e As EventArgs) Handles Me.Load
        If MetroGrid1.Rows.Count = 0 Then
            BtnUploadServer.Enabled = False
        End If
    End Sub


    Private Sub LInkRawMatOption_Click(sender As Object, e As EventArgs) Handles LInkRawMatOption.Click
        LInkRawMatOption.Style = MetroColorStyle.Blue
        LInkQA33Option.Style = MetroColorStyle.Black
        tFormatHeader.Text = "DO Vendor | Contract No | CGR Name | Material | Material D | Storage Lo | Batch | QTY GR/GI | Transactio"
    End Sub

    Private Sub LInkQA33Option_Click(sender As Object, e As EventArgs) Handles LInkQA33Option.Click
        LInkRawMatOption.Style = MetroColorStyle.Black
        LInkQA33Option.Style = MetroColorStyle.Blue
        tFormatHeader.Text = "Insp. Lot | Material | Mat Description | Batch | Stor. loc. | Lot Size | Bun | DO Vendor ID"
    End Sub
End Class


