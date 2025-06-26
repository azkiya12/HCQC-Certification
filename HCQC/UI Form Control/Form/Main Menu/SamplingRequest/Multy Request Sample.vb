Imports System.Data.SqlClient
Imports System.Runtime.ConstrainedExecution
Imports DgvFilterPopup
Imports DocumentFormat.OpenXml.Drawing
Imports DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews
Imports Org.BouncyCastle.Asn1
Imports SixLabors.Fonts.Tables.General

Public Class Multy_Request_Sample
    Public dtTransfer As New DataTable
    Private Sub Multy_Request_Sample_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Tambahkan kolom TestRequest (Text)
        If Not MetroGrid2.Columns.Contains("TestRequest") Then
            Dim colRequest As New DataGridViewTextBoxColumn With {
                .Name = "TestRequest",
                .HeaderText = "Test Request",
                .ReadOnly = True,
                .Width = 150
            }
            MetroGrid2.Columns.Add(colRequest)
        End If

        ' Tambahkan 7 kolom checkbox tersembunyi
        Dim testTypes As String() = {"SPL", "KesBnh", "MOI", "PUR", "RAF", "GER", "VIA"}
        For Each test In testTypes
            If Not MetroGrid2.Columns.Contains(test) Then
                Dim colCheck As New DataGridViewCheckBoxColumn With {
                    .Name = test,
                    .HeaderText = test,
                    .Visible = False
                }
                MetroGrid2.Columns.Add(colCheck)
            End If
        Next
    End Sub

    Private Sub AturKolomMetroGrid2()

        Dim columnSettings As New Dictionary(Of String, (Name As String, Header As String, Width As Integer, ReadOn As Boolean)) From {
            {"CheckColumn1", ("CheckColumn1", "", 40, False)},
            {"ProductionCodeColumn", ("ProductionCodeColumn", "Production Code", 130, False)},
            {"dovendorColumn", ("dovendorColumn", "DO Vendor", 110, False)},
            {"VarietyColumn", ("VarietyColumn", "Variety", 130, False)},
            {"InsplotColumn", ("InsplotColumn", "Insp. Lot", 105, False)},
            {"FarmerColumn", ("FarmerColumn", "Farmer", 150, False)},
            {"LocationColumn", ("LocationColumn", "Location", 130, False)},
            {"HarvestColumn", ("HarvestColumn", "Harvest", 120, False)},
            {"ManualColumn", ("ManualColumn", "Manual", 110, False)},
            {"LotColumn", ("LotColumn", "Lot/Job", 120, False)},
            {"WeightColumn", ("WeightColumn", "Weight", 85, False)},
            {"UnitColumn", ("UnitColumn", "Unit", 65, False)},
            {"BagColumn", ("BagColumn", "Bags", 65, False)},
            {"smplLocation", ("smplLocation", "Sample Location", 130, False)},
            {"ScopeColumn", ("ScopeColumn", "Scope", 105, False)},
            {"KetColumn", ("KetColumn", "Keterangan", 180, False)},
            {"TestRequest", ("TestRequest", "Test Request", 190, False)}
        }

        For Each key In columnSettings.Keys
            If MetroGrid2.Columns.Contains(columnSettings(key).Name) Then
                Dim col = MetroGrid2.Columns(columnSettings(key).Name)
                col.HeaderText = columnSettings(key).Header
                col.Width = columnSettings(key).Width
                col.ReadOnly = columnSettings(key).ReadOn
            End If
        Next

        Dim columnSettings2 As New Dictionary(Of String, (Name As String, Header As String, Visible As Boolean)) From {
            {"TestRequest", ("TestRequest", "Test Request", True)},
            {"SPL", ("SPL", "SPL", False)},
            {"KesBnh", ("KesBnh", "KesBnh", False)},
            {"MOI", ("MOI", "MOI", False)},
            {"PUR", ("PUR", "PUR", False)},
            {"RAF", ("RAF", "RAF", False)},
            {"GER", ("GER", "GER", False)},
            {"VIA", ("VIA", "VIA", False)}
        }

        For Each key In columnSettings2.Keys
            If MetroGrid2.Columns.Contains(columnSettings2(key).Name) Then
                Dim col = MetroGrid2.Columns(columnSettings2(key).Name)
                col.HeaderText = columnSettings2(key).Header
                col.Visible = columnSettings2(key).Visible
            End If
        Next
    End Sub

    Private Sub ProsesImportSelesai(dtResult As DataTable)
        ' Hapus kolom yang sebelumnya dibuat via Designer
        MetroGrid2.Columns.Clear()

        ' Optional: cegah kolom ganda
        MetroGrid2.AutoGenerateColumns = True

        ' Bind ke datatable
        dtTransfer = dtResult
        MetroGrid2.DataSource = dtTransfer

        ' Atur ulang kolom jika perlu
        AturKolomMetroGrid2()

        PasangDgvFilter()
        MetroGrid2.ColumnHeadersHeight = 25
    End Sub
    Private Sub PasangDgvFilter()
        Static DgvFilter As DgvFilterManager = Nothing

        If DgvFilter Is Nothing Then
            DgvFilter = New DgvFilterManager(MetroGrid2)
        End If
    End Sub

    Private Sub MetroGrid2_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles MetroGrid2.DataBindingComplete
        Static DgvFilter As DgvFilterManager = Nothing

        If DgvFilter Is Nothing Then
            DgvFilter = New DgvFilterManager(MetroGrid2)
        End If
    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles Linkadd.Click
        Dim fData_request As New Data_Request()
        AddHandler fData_request.ImportSelesai, AddressOf ProsesImportSelesai
        fData_request.ShowDialog(Me)
    End Sub

    Private Sub LinkClear_Click(sender As Object, e As EventArgs) Handles LinkClear.Click
        MetroGrid2.Rows.Clear()
    End Sub

    Private Sub BtnClearSelected_Click(sender As Object, e As EventArgs) Handles BtnClearSelected.Click
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

    End Sub
    Private Sub MetroGrid2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid2.CellClick
        'membuat ComboBox
        ' Abaikan baris header atau kolom negatif
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

        ' Misal kita ingin mengubah cell di kolom "Status"
        Dim columnName As String = MetroGrid2.Columns(e.ColumnIndex).Name

        If columnName = "ScopeColumn" Then
            ' Hanya ubah jika belum ComboBoxCell
            If Not TypeOf MetroGrid2.Rows(e.RowIndex).Cells(e.ColumnIndex) Is DataGridViewComboBoxCell Then
                Dim comboCell As New DataGridViewComboBoxCell()
                comboCell.Items.AddRange("Raw Material", "Gravity", "Periodic", "Finish Good", "Other")
                comboCell.Value = MetroGrid2.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
                MetroGrid2.Rows(e.RowIndex).Cells(e.ColumnIndex) = comboCell
            End If
        End If
    End Sub

    Private Sub MetroGrid2_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid2.CellValueChanged
        'Kembalikan ke TextBoxCell
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

        Dim colName = MetroGrid2.Columns(e.ColumnIndex).Name
        If colName = "ScopeColumn" Then
            ' Ambil nilai yang dipilih
            Dim selectedValue = MetroGrid2.Rows(e.RowIndex).Cells(e.ColumnIndex).Value?.ToString()

            ' Ganti kembali ke TextBoxCell
            Dim textCell As New DataGridViewTextBoxCell()
            textCell.Value = selectedValue
            MetroGrid2.Rows(e.RowIndex).Cells(e.ColumnIndex) = textCell
        End If
    End Sub

    Private Sub MetroGrid2_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles MetroGrid2.CurrentCellDirtyStateChanged
        'Karena ComboBoxCell tidak selalu trigger CellValueChanged langsung, kamu harus commit edit saat pilihan berubah.
        If MetroGrid2.IsCurrentCellDirty Then
            MetroGrid2.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim tglharvest As Date
        Dim stridlogin As Integer = login.Luserid.Text
        Dim farmerValue As String = ""

        Try
            For Each row As DataGridViewRow In MetroGrid2.Rows

                Using cmd As New SqlCommand("INSERT INTO [spl_request] ([id_login]
                                                                   ,[id_hvsprod]
                                                                   ,[variety]
                                                                   ,[farmer]
                                                                   ,[location]
                                                                   ,[harvest]
                                                                   ,[nomnl]
                                                                   ,[nojob]
                                                                   ,[insplot]
                                                                   ,[weight]
                                                                   ,[unit]
                                                                   ,[scope]
                                                                   ,[bag]
                                                                   ,[test_sampling]
                                                                   ,[test_moi]
                                                                   ,[test_pur]
                                                                   ,[test_ger]
                                                                   ,[test_via]
                                                                   ,[test_raf]
                                                                   ,[remark]
                                                                   ,[loc_sample]
                                                                   ,[kesehatan_benih]
                                                                   ,[input_by]
                                                                   ,[input_date]) 
                                                 VALUES (@idlogin, @idprod, @variety, @farmer, @location, @harvest, @nomnl, @nojob, @insplot, @weight, @unit, @scope,
                                @bag, @testSampling, @testmoi, @testpur, @testger, @testvia, @testraf, @remark, @loc_sample, @kesehatan_benih, @inputby, GETDATE())", con)
                    cmd.Parameters.AddWithValue("@idlogin", stridlogin)
                    cmd.Parameters.AddWithValue("@idprod", row.Cells("ProductionCodeColumn").Value)
                    cmd.Parameters.AddWithValue("@variety", row.Cells("VarietyColumn").Value)
                    cmd.Parameters.AddWithValue("@farmer", row.Cells("FarmerColumn").Value.ToString())
                    cmd.Parameters.AddWithValue("@location", row.Cells("locationColumn").Value)

                    Dim tglharvestValue = row.Cells("HarvestColumn").Value
                    If DateTime.TryParse(tglharvestValue?.ToString(), tglharvest) Then
                        cmd.Parameters.AddWithValue("@harvest", tglharvest.ToString("yyyy-MM-dd"))
                    Else
                        ' Jika kosong/tidak valid, isi dengan tanggal hari ini
                        cmd.Parameters.AddWithValue("@harvest", DateTime.Today.ToString("yyyy-MM-dd"))
                    End If

                    cmd.Parameters.AddWithValue("@nomnl", row.Cells("ManualColumn").Value)
                    cmd.Parameters.AddWithValue("@nojob", row.Cells("LotColumn").Value)
                    cmd.Parameters.AddWithValue("@insplot", row.Cells("InsplotColumn").Value)
                    cmd.Parameters.AddWithValue("@weight", row.Cells("WeightColumn").Value)
                    cmd.Parameters.AddWithValue("@unit", row.Cells("UnitColumn").Value)
                    cmd.Parameters.AddWithValue("@bag", row.Cells("BagColumn").Value)

                    cmd.Parameters.AddWithValue("@scope", row.Cells("ScopeColumn").Value)
                    cmd.Parameters.AddWithValue("@testSampling", row.Cells("SPL").Value)
                    cmd.Parameters.AddWithValue("@testmoi", row.Cells("MOI").Value)
                    cmd.Parameters.AddWithValue("@testpur", row.Cells("PUR").Value)
                    cmd.Parameters.AddWithValue("@testger", row.Cells("RAF").Value)
                    cmd.Parameters.AddWithValue("@testvia", row.Cells("GER").Value)
                    cmd.Parameters.AddWithValue("@testraf", row.Cells("VIA").Value)
                    Dim remark As String
                    remark = IIf(row.Cells("KetColumn").Value Is Nothing, "", row.Cells("KetColumn").Value)
                    cmd.Parameters.AddWithValue("@remark", remark)
                    cmd.Parameters.AddWithValue("@loc_sample", row.Cells("smplLocation").Value)
                    cmd.Parameters.AddWithValue("@kesehatan_benih", row.Cells("KesBnh").Value)
                    cmd.Parameters.AddWithValue("@inputby", GetIPAddress)

                    con.Open()
                    'DebugSqlCommand(cmd)
                    cmd.ExecuteNonQuery()
                    con.Close()

                End Using

            Next
            Dim result As Integer = MetroMessageBox.Show(Me, "Multiple Save Successes. You will leave this form", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
            If result = DialogResult.Yes Then
                Me.Close()
            ElseIf result = DialogResult.No Then
                MetroGrid2.Rows.Clear()
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Troublesort " + ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, 211)
        Finally
            con.Close()
        End Try

    End Sub

    ' Fungsi untuk menambahkan item baru ke dalam ComboBoxColumn
    Private Sub TambahItemKeComboBoxColumn(valueBaru As String)
        Dim comboBoxColumn As DataGridViewComboBoxColumn = CType(MetroGrid2.Columns("KategoriColumn"), DataGridViewComboBoxColumn)

        ' Cek apakah valueBaru sudah ada di dalam ComboBoxColumn
        If Not comboBoxColumn.Items.Contains(valueBaru) Then
            comboBoxColumn.Items.Add(valueBaru) ' Menambahkan value baru ke dalam ComboBoxColumn
        End If

        ' Set nilai valueBaru sebagai pilihan otomatis di baris terakhir
        Dim lastRowIndex As Integer = MetroGrid2.Rows.Count - 1
        If lastRowIndex >= 0 Then
            MetroGrid2.Rows(lastRowIndex).Cells("KategoriColumn").Value = valueBaru
        End If
    End Sub

    Private Sub Multy_Request_Sample_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub LinkImport_Click(sender As Object, e As EventArgs) Handles LinkImport.Click
        Dim frm As New Form_Import()
        frm.CallerSource = FormCaller.Multy_Request_Sample
        AddHandler frm.Import_Data_Excel1.ImportSelesai, AddressOf ProsesImportSelesai
        frm.ShowDialog(Me)
    End Sub

    Private Sub BtnSetAll_Click(sender As Object, e As EventArgs) Handles BtnSetAll.Click
        Dim selectedScope As String = TComboScope.Text.Trim()

        If String.IsNullOrWhiteSpace(selectedScope) Then
            MessageBox.Show("Silakan pilih Scope of Sample terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        For Each row As DataGridViewRow In MetroGrid2.Rows
            If Not row.IsNewRow Then
                row.Cells("ScopeColumn").Value = selectedScope
            End If
        Next
    End Sub

    Private Sub BtnSetSelected_Click(sender As Object, e As EventArgs) Handles BtnSetSelected.Click
        Dim selectedScope As String = TComboScope.Text.Trim()

        If String.IsNullOrWhiteSpace(selectedScope) Then
            MessageBox.Show("Silakan pilih Scope of Sample terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MetroGrid2.SelectedRows.Count = 0 Then
            MessageBox.Show("Silakan pilih satu atau beberapa baris terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        For Each row As DataGridViewRow In MetroGrid2.SelectedRows
            If Not row.IsNewRow Then
                row.Cells("ScopeColumn").Value = selectedScope
            End If
        Next
    End Sub

    Private Sub BtnTestSetSelected_Click(sender As Object, e As EventArgs) Handles BtnTestSetSelected.Click
        If MetroGrid2.SelectedRows.Count = 0 Then
            MessageBox.Show("Silakan pilih baris yang ingin diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        For Each row As DataGridViewRow In MetroGrid2.SelectedRows
            If row.IsNewRow Then Continue For

            Dim testCodes As New List(Of String)

            ' Update nilai checkbox column sesuai checkbox control
            If tsampling.Checked Then
                row.Cells("SPL").Value = True
                testCodes.Add("SPL")
            Else
                row.Cells("SPL").Value = False
            End If

            If tkarantina.Checked Then
                row.Cells("KesBnh").Value = True
                testCodes.Add("KesBnh")
            Else
                row.Cells("KesBnh").Value = False
            End If

            If tmoi.Checked Then
                row.Cells("MOI").Value = True
                testCodes.Add("MOI")
            Else
                row.Cells("MOI").Value = False
            End If

            If tpur.Checked Then
                row.Cells("PUR").Value = True
                testCodes.Add("PUR")
            Else
                row.Cells("PUR").Value = False
            End If

            If traf.Checked Then
                row.Cells("RAF").Value = True
                testCodes.Add("RAF")
            Else
                row.Cells("RAF").Value = False
            End If

            If tger.Checked Then
                row.Cells("GER").Value = True
                testCodes.Add("GER")
            Else
                row.Cells("GER").Value = False
            End If

            If tvia.Checked Then
                row.Cells("VIA").Value = True
                testCodes.Add("VIA")
            Else
                row.Cells("VIA").Value = False
            End If

            row.Cells("TestRequest").Value = String.Join(",", testCodes)
        Next
    End Sub
End Class