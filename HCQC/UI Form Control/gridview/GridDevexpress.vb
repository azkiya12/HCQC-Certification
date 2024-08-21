Imports System.ComponentModel
Imports System.IO
Imports System.Text
Imports System.Threading.Tasks

Public Class GridDevexpress

    Private Sub GridDevexpress_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.Containermenu2.BtnGlobal.Enabled = True
    End Sub

    Public Sub LoadTextTrackingTemplating()

        ComboBoxEdit1.Properties.Items.Clear()
        Dim FolderPath As String = "C:\hcqc asset"
        Dim FilePath As String = "C:\hcqc asset\GStyle_Global.txt"

        CreateGStyleTracking(FilePath, FolderPath)

        ''Dim FilePath As String = My.Application.Info.DirectoryPath + "\GStyle_tracking.txt"
        ComboBoxEdit1.Properties.Items.AddRange(File.ReadAllLines(FilePath))
    End Sub

    Public Sub DeleteTextTrackingTemplating()
        Dim FilePath As String = "C:\hcqc asset\GStyle_Global.txt"
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
            GridView.SaveLayoutToXml(fileName)
        End If

        Dim textline As String
        Dim stringcek As Boolean = False
        Dim FilePath As String = "C:\hcqc asset\GStyle_GLobal.txt"
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
            MetroMessageBox.Show(Me, "File GStyle_Global.txt tidak ditemukan.")
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
        Dim FilePath As String = "C:\hcqc asset\GStyle_Global.txt"
        Dim searchText As String = ComboBoxEdit1.SelectedItem
        Dim lines As List(Of String) = File.ReadAllLines(FilePath).ToList()

        Try
            GridView.RestoreLayoutFromXml(fileName)
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

    Private Sub LinkRefresh_Click(sender As Object, e As EventArgs) Handles LinkRefresh.Click
        'BackgroundWorker1.RunWorkerAsync()
        If LinkRefresh.Tag = "thisyear" Then
            LinkThisYear_Click(sender, e)
        ElseIf LinkRefresh.Tag = "lastyear" Then
            LinkLastYear_Click(sender, e)
        ElseIf LinkRefresh.Tag = "bydate" Then
            BtnFilterDate_Click(sender, e)
        End If
    End Sub

    Private Async Function FillByLastYearAsync() As Task
        Await Task.Delay(1500)
        ' Menjalankan metode Fill dalam sebuah task
        Report_global_viewTableAdapter.Fill(HCQC_NewDataset.report_global_view)
    End Function

    Private Async Sub LinkLastYear_Click(sender As Object, e As EventArgs) Handles LinkLastYear.Click
        BtnFilterDate.Enabled = False
        Dim dt As Date = Now
        Dim startDt As New Date(dt.Year - 1, 1, 1)
        Dim fillterStr, fillterStr2 As String
        StartDate.Value = startDt.ToString("dd-MMM-yyyy")
        EndDate.Value = Today.ToString("dd-MMM-yyyy")

        ProgressSpinner1.Visible = True
        LabelStatus.Text = "Loading...| Get data Last Year"
        MetroPanel1.Enabled = False

        Await FillByLastYearAsync()
        ''Me.Report_global_viewTableAdapter.FillByLastYear(Me.HCQC_NewDataset.report_global_view)

        fillterStr = Year(Now)
        fillterStr = "QC" & fillterStr & "%"

        fillterStr2 = Year(Now) - 1
        fillterStr2 = "QC" & fillterStr2 & "%"


        'GerminationTableAdapter1.FillByStr(Me.HCQC_NewDataset.germination, fillterStr, fillterStr2)
        LabelStatus.Text = "Loading...| 2 get data Germination"
        Await GerminationTableAdapter1.FillAsync(Me.HCQC_NewDataset, fillterStr, fillterStr2)
        LabelStatus.Text = "Loading...| 3 get data Viability"
        Await ViabilityTableAdapter1.FillAsync(Me.HCQC_NewDataset, fillterStr, fillterStr2)
        LabelStatus.Text = "Loading...| 4 get data Rafactiony"
        Await RafactionTableAdapter1.FillAsync(Me.HCQC_NewDataset, fillterStr, fillterStr2)
        LabelStatus.Text = "Loading...| 5 get data Moisture"
        Await MoistureTableAdapter1.FillAsync(Me.HCQC_NewDataset, fillterStr, fillterStr2)
        LabelStatus.Text = "Loading...| 6 get data Purity"
        Await PurityTableAdapter1.FillAsync(Me.HCQC_NewDataset, fillterStr, fillterStr2)
        LabelStatus.Text = "Loading...| 7 get data ArchiveFG"
        Await ArchiveTableAdapter1.FillAsync(Me.HCQC_NewDataset, fillterStr, fillterStr2)
        BtnFilterDate.Enabled = True
        ProgressSpinner1.Visible = False
        MetroPanel1.Enabled = True
        BtnFilterDate.Enabled = True
        LabelStatus.Text = "Nilai persentase -1 menandakan bahwa sampel tidak di lakukan pengujian tertentu"
        LinkRefresh.Tag = "lastyear"

    End Sub

    Private Async Sub LinkThisYear_Click(sender As Object, e As EventArgs) Handles LinkThisYear.Click
        BtnFilterDate.Enabled = False
        Dim dt As Date = Now
        Dim startDt As New Date(dt.Year, 1, 1)
        StartDate.Value = startDt.ToString("dd-MMM-yyyy")
        EndDate.Value = Today.ToString("dd-MMM-yyyy")

        ProgressSpinner1.Visible = True
        LabelStatus.Text = "Loading get data this year..."
        MetroPanel1.Enabled = False

        Await Task.Delay(1500)
        Me.Report_global_viewTableAdapter.FillByThisYear(Me.HCQC_NewDataset.report_global_view)
        Dim fillterStr, fillterStr2 As String
        fillterStr = Year(Now)
        fillterStr = "QC" & fillterStr & "%"

        fillterStr2 = Year(Now)
        fillterStr2 = "QC" & fillterStr2 & "%"
        LabelStatus.Text = "Loading...|2 get data Germination"

        'GerminationTableAdapter1.FillByStr(Me.HCQC_NewDataset.germination, fillterStr, fillterStr2)
        Await GerminationTableAdapter1.FillAsync(Me.HCQC_NewDataset, fillterStr, fillterStr2)
        LabelStatus.Text = "Loading...|3 get data Viability"
        Await ViabilityTableAdapter1.FillAsync(Me.HCQC_NewDataset, fillterStr, fillterStr2)
        LabelStatus.Text = "Loading...|4 get data Rafactiony"
        Await RafactionTableAdapter1.FillAsync(Me.HCQC_NewDataset, fillterStr, fillterStr2)
        LabelStatus.Text = "Loading...|5 get data Moisture"
        Await MoistureTableAdapter1.FillAsync(Me.HCQC_NewDataset, fillterStr, fillterStr2)
        LabelStatus.Text = "Loading...|6 get data Purity"
        Await PurityTableAdapter1.FillAsync(Me.HCQC_NewDataset, fillterStr, fillterStr2)
        LabelStatus.Text = "Loading...|7 get data ArchiveFG"
        Await ArchiveTableAdapter1.FillAsync(Me.HCQC_NewDataset, fillterStr, fillterStr2)

        BtnFilterDate.Enabled = True
        ProgressSpinner1.Visible = False
        MetroPanel1.Enabled = True
        LabelStatus.Text = "Nilai persentase -1 menandakan bahwa sampel tidak di lakukan pengujian tertentu"
        LinkRefresh.Tag = "thisyear"
    End Sub

    Private Async Sub BtnFilterDate_Click(sender As Object, e As EventArgs) Handles BtnFilterDate.Click

        'If StartDate.Value.Date > EndDate.Value.Date Then
        '    MetroMessageBox.Show(Me, "'Start Date' harus lebih kecil dari 'End Date'", "Global Report HCQC")
        '    Return
        'End If

        ProgressSpinner1.Visible = True

        LabelStatus.Text = "Loading get data"
        MetroPanel1.Enabled = False
        BtnFilterDate.Enabled = False

        '' Mengatur tanggal awal
        Dim getstartDate As DateTime = EndDate.Value.Date

        '' Menambahkan satu hari ke tanggal awal dan mengurangi satu detik
        Dim endDateTime As DateTime = getstartDate.AddDays(1).AddSeconds(-1)


        Dim filterStart, filterEnd As String
        filterStart = StartDate.Value.Date.ToString("yyyy") & StartDate.Value.Date.ToString("MM")
        filterStart = "QC" & filterStart & "%"

        filterEnd = EndDate.Value.Date.ToString("yyyy") & EndDate.Value.Date.ToString("MM")
        filterEnd = "QC" & filterEnd & "%"
        'Console.WriteLine(filterStart & " --- " & filterEnd)
        Console.WriteLine("------" & StartDate.Value.Date.ToString("yyyy-MM-ddTHH:mm:ss"))
        Console.WriteLine("------" & EndDate.Value.Date.ToString("yyyy-MM-ddTHH:mm:ss"))
        Console.WriteLine("------" & endDateTime.ToString("yyyy-MM-ddTHH:mm:ss"))
        Await Task.Delay(1000)
        Me.Report_global_viewTableAdapter.FillByDateRange(Me.HCQC_NewDataset.report_global_view, StartDate.Value.Date.ToString("yyyy-MM-ddTHH:mm:ss"), endDateTime.ToString("yyyy-MM-ddTHH:mm:ss"))

        LabelStatus.Text = "Loading...|2 get data Germination"
        Await GerminationTableAdapter1.FillAsync(Me.HCQC_NewDataset, filterStart, filterEnd)
        LabelStatus.Text = "Loading...|3 get data Viability"
        Await ViabilityTableAdapter1.FillAsync(Me.HCQC_NewDataset, filterStart, filterEnd)
        LabelStatus.Text = "Loading...|4 get data Rafactiony"
        Await RafactionTableAdapter1.FillAsync(Me.HCQC_NewDataset, filterStart, filterEnd)
        LabelStatus.Text = "Loading...|5 get data Moisture"
        Await MoistureTableAdapter1.FillAsync(Me.HCQC_NewDataset, filterStart, filterEnd)
        LabelStatus.Text = "Loading...|6 get data Purity"
        Await PurityTableAdapter1.FillAsync(Me.HCQC_NewDataset, filterStart, filterEnd)
        LabelStatus.Text = "Loading...|7 get data ArchiveFG"
        Await ArchiveTableAdapter1.FillAsync(Me.HCQC_NewDataset, filterStart, filterEnd)

        ProgressSpinner1.Visible = False
        MetroPanel1.Enabled = True
        BtnFilterDate.Enabled = True
        LabelStatus.Text = "Nilai persentase -1 menandakan bahwa sampel tidak di lakukan pengujian tertentu"
        LinkRefresh.Tag = "bydate"
    End Sub

    Private Sub GridDevexpress_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadTextTrackingTemplating()
    End Sub
End Class