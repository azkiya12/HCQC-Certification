Imports System.ComponentModel
Imports System.Threading.Tasks

Public Class GridDevexpress

    Private Sub GridDevexpress_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.Containermenu2.BtnGlobal.Enabled = True
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
End Class