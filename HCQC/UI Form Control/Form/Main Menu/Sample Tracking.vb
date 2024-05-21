Imports System.Data.SqlClient
Imports DgvFilterPopup
Imports System.IO
Imports System.Reflection
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports System.Text

Public Class Sample_Tracking
    Private Sub Sample_Tracking_Load(sender As Object, e As EventArgs) Handles Me.Load
        ''TODO: This line of code loads data into the 'HCQC_NewDataset.report_sample_tracking' table. You can move, or remove it, as needed.
        'Me.Report_status_pengujianTableAdapter.FillByThisMonth(Me.HCQC_NewDataset.report_status_pengujian)
        'GridControl1.Refresh()

        ''METROGRID1 popup filter on Header
        Dim DgvFilter As New DgvFilterManager
        DgvFilter.DataGridView = MetroGrid1
        MetroGrid1.ColumnHeadersHeight = 25

        StartDate.Value = Today
        EndDate.Value = Today
        LoadTextTrackingTemplating()
    End Sub

    Public Sub LoadTextTrackingTemplating()

        ComboBoxEdit1.Properties.Items.Clear()
        Dim FolderPath As String = "C:\hcqc asset"
        Dim FilePath As String = "C:\hcqc asset\GStyle_tracking.txt"

        CreateGStyleTracking(FilePath, FolderPath)

        ''Dim FilePath As String = My.Application.Info.DirectoryPath + "\GStyle_tracking.txt"
        ComboBoxEdit1.Properties.Items.AddRange(System.IO.File.ReadAllLines(FilePath))
    End Sub

    Public Sub DeleteTextTrackingTemplating()
        Dim FilePath As String = "C:\hcqc asset\GStyle_tracking.txt"
        ''menghapus text "selectedText Combobox" di file DirectoryPart|GStyle_tracking.txt
        ''Dim FilePath As String = My.Application.Info.DirectoryPath + "\GStyle_tracking.txt"
        File.WriteAllLines(FilePath, File.ReadAllLines(FilePath).Where(Function(l) l <> ComboBoxEdit1.SelectedItem))
        LoadTextTrackingTemplating()
    End Sub

    Public Sub CreateGStyleTracking(ByVal FilePath As String, ByVal FolderPath As String)

        'memastikan terdapat folder "C:\hcqc asset"
        If Not Directory.Exists(FolderPath) Then
            Directory.CreateDirectory(FolderPath)
        End If

        'memastiakan terdapat file GStyle_tracking.txt
        If Not File.Exists(FilePath) Then
            File.Create(FilePath).Dispose()
        End If

    End Sub

    Private Sub SaveView_Click(sender As Object, e As EventArgs) Handles MetroLink2.Click
        ''proses SAVE file template view
        Dim fileName As String = "C:\hcqc asset\" + ComboBoxEdit1.Text + ".xml"
        Dim result As Integer = MetroMessageBox.Show(Me, "Simpan tampilan terakir", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, 211)
        If result = DialogResult.Cancel Then
            Return
        End If

        'Memastikan jika ada nama file yang sama akan di delete dulu
        If File.Exists(fileName) Then
            File.Delete(fileName)
        End If

        'jika file tidak ada maka lalukan proses SaveLayout
        If Not File.Exists(fileName) Then
            GridView1.SaveLayoutToXml(fileName)
        End If

        Dim textline As String
        Dim stringcek As Boolean = False
        Dim FilePath As String = "C:\hcqc asset\GStyle_tracking.txt"
        Dim ContentItem As String = ComboBoxEdit1.Text
        If File.Exists(FilePath) Then
            Try
                'Proses membaca catatan layout yang sudah di save pada file GStyle_tracking.txt
                Using objReader As New StreamReader(FilePath, Encoding.ASCII)
                    textline = objReader.ReadToEnd

                    ' Memeriksa apakah berhasil membaca baris pertama
                    If (textline Is Nothing) Or (Not textline.Contains(ContentItem)) Then
                        stringcek = True
                    End If
                End Using

            Catch ex As Exception
                MetroMessageBox.Show(Me, ex.Message)
                Return
            End Try
        Else
            MetroMessageBox.Show(Me, "File GStyle_tracking.txt tidak ditemukan.")
            Return
        End If

        Console.WriteLine(stringcek)
        ''jika tidak ada text maka tulis text di file .txt
        If stringcek = True Then
            'SaveTextTrackingTemplating()
            Using file As New StreamWriter(FilePath, True)
                file.WriteLine(ComboBoxEdit1.SelectedItem)
                file.Close()
            End Using
        End If

        ''proses load combobox
        LoadTextTrackingTemplating()
    End Sub

    Private Sub ComboBoxEdit1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit1.SelectedIndexChanged
        Dim fileName As String = "C:\hcqc asset\" + ComboBoxEdit1.Text + ".xml"
        Dim FilePath As String = "C:\hcqc asset\GStyle_tracking.txt"
        Dim searchText As String = ComboBoxEdit1.SelectedItem
        Dim lines As List(Of String) = File.ReadAllLines(FilePath).ToList()

        Try
            GridView1.RestoreLayoutFromXml(fileName)
        Catch ex As Exception
            'jika file .xml tidak ada hapus daftar list combobox
            lines.RemoveAll(Function(line) line.Trim() = searchText)
            File.WriteAllLines(FilePath, lines)
            MsgBox("GridViewTemplate is error on " & ex.Message.ToString)

            LoadTextTrackingTemplating()
        End Try
    End Sub

    Private Sub DeleteView_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        ''proses DELETE file template view
        Dim fileName As String = "C:\hcqc asset\" + ComboBoxEdit1.Text + ".xml"
        If ComboBoxEdit1.Text Is Nothing Then
            MetroMessageBox.Show(Me, "Tidak ada yang harus dihapus. Lanjutkan hidup dan terima keadaan.")
            Return
        End If

        Dim result As Integer = MetroMessageBox.Show(Me, "Yakin diHAPUS tampilan " & ComboBoxEdit1.Text & " ??", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, 211)
        If result = DialogResult.Cancel Then
            MetroMessageBox.Show(Me, "Tidak ada yang harus dihapus. Lanjutkan hidup dan terima keadaan.")
            Return
        End If

        If Not File.Exists(fileName) Then
            My.Computer.FileSystem.DeleteFile(
                fileName,
                FileIO.UIOption.AllDialogs,
                FileIO.RecycleOption.DeletePermanently,
                FileIO.UICancelOption.DoNothing)
        End If
        ''proses delete text file template view
        DeleteTextTrackingTemplating()
        ''proses load combobox
        LoadTextTrackingTemplating()

    End Sub
    Public Sub OnRefreshEventHendler()
        Me.Report_sampel_ambilTableAdapter.Fill(HCQC_NewDataset.report_sampel_ambil)
    End Sub

    Private Sub LinkAll2_Click(sender As Object, e As EventArgs)
        'OnRefreshEventHendler()
    End Sub

    Private Sub LInkRefresh_Click(sender As Object, e As EventArgs) Handles LInkRefresh.Click
        Me.Report_status_pengujianTableAdapter.Fill(Me.HCQC_NewDataset.report_status_pengujian)

        GridControl1.Refresh()
        'GridControl1.ActiveFilterString = "[City] = 'Paris'"
    End Sub

    Private Sub MetroTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControl1.SelectedIndexChanged
        'suppose your *finance tab* instance is TabPageFinance 
        If MetroTabControl1.SelectedTab Is MetroTabPage1 Then
            Me.Report_status_pengujianTableAdapter.FillByThisMonth(Me.HCQC_NewDataset.report_status_pengujian)
        End If

        'or suppose *finance tab* index is 0 
        If MetroTabControl1.SelectedTab Is MetroTabPage2 Then
            OnRefreshEventHendler()
        End If
    End Sub

    Private Sub LinkAll1_Click(sender As Object, e As EventArgs)
        Me.Report_status_pengujianTableAdapter.Fill(Me.HCQC_NewDataset.report_status_pengujian)
        GridControl1.Refresh()
    End Sub

    Private Sub LinkThisMonth1_Click(sender As Object, e As EventArgs) Handles LinkThisMonth1.Click
        Me.Report_status_pengujianTableAdapter.FillByThisMonth(Me.HCQC_NewDataset.report_status_pengujian)
        Dim dt As Date = Now
        Dim startDt As New Date(dt.Year, dt.Month, 1)
        StartDate.Value = startDt.ToString("dd-MMM-yyyy")
        EndDate.Value = Today.ToString("dd-MMM-yyyy")
        GridControl1.Refresh()
    End Sub

    Private Sub LinkLastMonth1_Click(sender As Object, e As EventArgs) Handles LinkLastMonth1.Click
        Me.Report_status_pengujianTableAdapter.FillByLastMonth(Me.HCQC_NewDataset.report_status_pengujian)
        Dim dt, startDt As Date
        dt = Now
        dt = dt.AddMonths(-1)

        startDt = New DateTime(dt.Year, dt.Month, 1)

        StartDate.Value = startDt.ToString("dd-MMM-yyyy")
        EndDate.Value = Today.ToString("dd-MMM-yyyy")
        GridControl1.Refresh()

    End Sub

    Private Sub BtnFilterDate_Click(sender As Object, e As EventArgs) Handles BtnFilterDate.Click
        If StartDate.Value.Date > EndDate.Value.Date Then
            MetroMessageBox.Show(Me, "'Start Date' harus lebih kecil dari 'End Date'", "Filter Date Tracking")
            Return
        End If
        '' Mengatur tanggal awal
        Dim getstartDate As DateTime = EndDate.Value.Date

        '' Menambahkan satu hari ke tanggal awal dan mengurangi satu detik
        Dim endDateTime As DateTime = getstartDate.AddDays(1).AddSeconds(-1)

        Me.Report_status_pengujianTableAdapter.FillByDateRange(Me.HCQC_NewDataset.report_status_pengujian, StartDate.Value.Date.ToString("yyyy-MM-ddTHH:mm:ss"), endDateTime.ToString("yyyy-MM-ddTHH:mm:ss"))
    End Sub

    Public Sub CariTextBox(ByVal parameterCari As String, ByVal strVal As String)
        If parameterCari = "Labnum" Then
            Lreqnum.Text = _DataToValue("SELECT [id] FROM [qc_confirm_viewer] WHERE " & parameterCari & "='" & strVal & "'")
            tVariety.Text = _DataToValue("SELECT [variety] FROM [qc_confirm_viewer] WHERE " & parameterCari & "='" & strVal & "'")
            tnomnl.Text = _DataToValue("SELECT [nomnl] FROM [qc_confirm_viewer] WHERE " & parameterCari & "='" & strVal & "' ")
            tlotref.Text = _DataToValue("SELECT [nojob] FROM [qc_confirm_viewer] WHERE " & parameterCari & "='" & strVal & "' ")
            Dim tglhvs As Date = _DataToValueDate("SELECT [harvest] FROM [qc_confirm_viewer] WHERE " & parameterCari & "='" & strVal & "' ")
            tharvest.Text = tglhvs.ToString("dd-MM-yyyy")
            tweight.Text = _DataToValue("SELECT [weight] FROM [qc_confirm_viewer] WHERE " & parameterCari & "='" & strVal & "' ")
            tscope.Text = _DataToValue("SELECT [scope] FROM [qc_confirm_viewer] WHERE " & parameterCari & "='" & strVal & "' ")
            Lraf.Text = _DataToValue("SELECT case when [StatusTL]=1 then 'Lulus' when [StatusTL]=0 then 'Tolak' else 'ProsesQC' end as StatusTL from [report_sample_tracking] where " & parameterCari & "='" & strVal & "'")
            Lfarmer.Text = _DataToValue("SELECT [farmer] FROM [qc_confirm_viewer] WHERE " & parameterCari & "='" & strVal & "'")
            LLocation.Text = _DataToValue("SELECT [location] FROM [qc_confirm_viewer] WHERE " & parameterCari & "='" & strVal & "'")
        ElseIf parameterCari = "id_hvsprod" Then
            Dim p As Integer
            p = _DataToValue("SELECT count([id_hvsprod]) FROM [qc_confirm_viewer] WHERE " & parameterCari & "='" & strVal & "'")
            'jika data lebih dari satu
            If p > 1 Then
                'tampilkan data usercontrol untuk memilih salah satu data

            End If
        End If
    End Sub

    Private Sub BtnCariLab_Click(sender As Object, e As EventArgs) Handles BtnCariLab.Click
        Dim Sid_req As String

        'memastikan combobox untuk emmulai pencarian Lab Number atau Production Code
        If CboxParameterCari.SelectedText = "Labnum" Then
            If _isBOFAND("receipt", "labnum", tlabnum.Text) = True Then
                'modul untuk cari
                CariTextBox("labnum", tlabnum.Text)

                If _isBOF("[spl_ambil]", "[id_request]", Lreqnum.Text) = False Then
                    BtnSave.Text = "Save"
                    Labelupdate.Visible = False
                    Ltgl_update.Visible = False
                ElseIf _isBOF("[spl_ambil]", "[id_request]", Lreqnum.Text) = True Then
                    BtnSave.Text = "Update"
                    Dim tglUpdate As Date = _DataToValueDate("SELECT [tgl] FROM [HCQC_server].[dbo].[spl_ambil] WHERE [labnum]='" & tlabnum.Text & "'")
                    Ltgl_update.Text = tglUpdate.ToString("dd-MM-yyyy")
                    Ltgl_update.Visible = True
                    Labelupdate.Visible = True

                    Tnama.Text = _DataToValue("SELECT [officer] FROM [HCQC_server].[dbo].[spl_ambil] WHERE [labnum]='" & tlabnum.Text & "'")
                    Tremark.Text = _DataToValue("SELECT [remark] FROM [HCQC_server].[dbo].[spl_ambil] WHERE [labnum]='" & tlabnum.Text & "'")
                End If
            Else
                MetroMessageBox.Show(Me, "Lab Number belum pernah di terima QC", "Check Out Sample QC", MessageBoxButtons.OK, MessageBoxIcon.Warning, 211)
            End If
        ElseIf CboxParameterCari.SelectedText = "Production Code" Then
            Sid_req = _DataToValue("SELECT [id] FROM [qc_confirm_viewer] WHERE [labnum]='" & tlabnum.Text & "'")

        End If

        tlabnum.SelectAll()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If String.IsNullOrEmpty(tlabnum.Text) Then
            MetroMessageBox.Show(Me, "Lab Number kosong")
        Else
            If BtnSave.Text = "Save" Then
                If _isBOF("[spl_ambil]", "[id_request]", Lreqnum.Text) = True Then
                    'MsgBox("sample request number kosong")
                    _RunSQL("INSERT INTO [dbo].[spl_ambil]
                               ([id_request]
                               ,[id_login]
                               ,[labnum]
                               ,[officer]
                               ,[remark]
                               ,[tgl]   )
                         VALUES
                               (" & Val(Lreqnum.Text) & "
                               ," & Val(login.Luserid.Text) & "
                               ,'" & Trim(tlabnum.Text) & "'
                               ,'" & Tnama.Text & "'
                               ,'" & Tremark.Text & "'
                               ,GETDATE())
                ")
                    bersih()
                End If

            ElseIf BtnSave.Text = "Update" Then
                _RunSQL("UPDATE [dbo].[spl_ambil]
                        SET [id_login] = " & Val(login.Luserid.Text) & "
                            ,[labnum]='" & Trim(tlabnum.Text) & "'
                            ,[officer] = '" & Tnama.Text & "'
                            ,[remark] = '" & Tremark.Text & "'
                            ,[tgl] = GETDATE()
                      WHERE [id_request] = " & Val(Lreqnum.Text) & " 
            ")
                bersih()
            End If
        End If

    End Sub

    Private Sub Tlabnum_KeyDown(sender As Object, e As KeyEventArgs) Handles tlabnum.KeyDown
        If ((e.KeyCode = Keys.Enter)) Then
            BtnCariLab_Click(sender, e)
        End If
    End Sub

    Sub bersih()
        Lreqnum.Text = "..."
        tVariety.Text = "..."
        tnomnl.Text = "..."
        tlotref.Text = "..."
        tharvest.Text = "..."
        tweight.Text = "..."
        tscope.Text = "..."
        Lraf.Text = "..."
        Lfarmer.Text = "..."
        LLocation.Text = "..."

        tlabnum.Text = ""
        Tnama.Text = ""
        Tremark.Text = ""
        BtnSave.Text = "Save"
    End Sub

    Private Sub Tsearch_ButtonClick(sender As Object, e As EventArgs)
        'If String.IsNullOrEmpty(Tsearch.Text) Then
        '    MetroMessageBox.Show(Me, "Text Pencarian kosong")
        'Else
        '    'Me.Report_sample_trackingTableAdapter.FillByVariable(Me.HCQC_NewDataset.report_sample_tracking, "%" + Trim(Tsearch.Text) + "%")
        'End If
    End Sub

    Private Sub tSearchReturn_ButtonClick(sender As Object, e As EventArgs) Handles tSearchReturn.ButtonClick
        If String.IsNullOrEmpty(tSearchReturn.Text) Then
            OnRefreshEventHendler()
        Else
            Me.Report_sampel_ambilTableAdapter.FillByStrvariable(HCQC_NewDataset.report_sampel_ambil, "%" + Trim(tSearchReturn.Text) + "%")
        End If
    End Sub

    Private Sub tSearchReturn_ClearClicked() Handles tSearchReturn.ClearClicked
        OnRefreshEventHendler()
    End Sub

    Private Sub tSearchReturn_KeyUp(sender As Object, e As KeyEventArgs) Handles tSearchReturn.KeyUp
        If e.KeyCode = Keys.Enter Then
            tSearchReturn_ButtonClick(sender, e)
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

    Private Sub MetroLink1_MouseEnter(sender As Object, e As EventArgs) Handles MetroLink1.MouseEnter
        MetroLink1.BackColor = Color.OrangeRed
    End Sub

    Private Sub MetroLink1_MouseLeave(sender As Object, e As EventArgs) Handles MetroLink1.MouseLeave
        MetroLink1.BackColor = Color.Transparent
    End Sub

    Private Sub MetroLink2_MouseLeave(sender As Object, e As EventArgs) Handles MetroLink2.MouseLeave
        MetroLink2.BackColor = Color.Transparent
    End Sub

    Private Sub MetroLink2_MouseEnter(sender As Object, e As EventArgs) Handles MetroLink2.MouseEnter
        MetroLink2.BackColor = Color.DodgerBlue
    End Sub
End Class