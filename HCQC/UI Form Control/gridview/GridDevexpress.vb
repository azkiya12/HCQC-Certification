Imports System.ComponentModel

Public Class GridDevexpress

    Private Sub GridDevexpress_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.Containermenu2.BtnGlobal.Enabled = True
    End Sub

    Private Sub LinkRefresh_Click(sender As Object, e As EventArgs) Handles LinkRefresh.Click
        'BackgroundWorker1.RunWorkerAsync()
        GridControl1.RefreshDataSource()
    End Sub

    Private Sub LinkLastYear_Click(sender As Object, e As EventArgs) Handles LinkLastYear.Click
        BtnFilterDate.Enabled = False
        Dim dt As Date = Now
        Dim startDt As New Date(dt.Year - 1, 1, 1)
        StartDate.Value = startDt.ToString("dd-MMM-yyyy")
        EndDate.Value = Today.ToString("dd-MMM-yyyy")

        Me.Report_global_viewTableAdapter.FillByLastYear(Me.HCQC_NewDataset.report_global_view)

        Dim fillterStr, fillterStr2 As String
        fillterStr = Year(Now)
        fillterStr = "QC" & fillterStr & "%"

        fillterStr2 = Year(Now) - 1
        fillterStr2 = "QC" & fillterStr2 & "%"

        GerminationTableAdapter1.FillByStr(Me.HCQC_NewDataset.germination, fillterStr, fillterStr2)
        ViabilityTableAdapter1.FillByStr(Me.HCQC_NewDataset.viability, fillterStr, fillterStr2)
        RafactionTableAdapter1.FillByStr(Me.HCQC_NewDataset.rafaction, fillterStr, fillterStr2)
        MoistureTableAdapter1.FillByStr(Me.HCQC_NewDataset.moisture, fillterStr, fillterStr2)
        PurityTableAdapter1.FillByStr(Me.HCQC_NewDataset.purity, fillterStr, fillterStr2)
        ArchiveTableAdapter1.FillByStr(Me.HCQC_NewDataset.archive, fillterStr, fillterStr2)
        BtnFilterDate.Enabled = True
    End Sub

    Private Sub LinkThisYear_Click(sender As Object, e As EventArgs) Handles LinkThisYear.Click
        BtnFilterDate.Enabled = False
        Dim dt As Date = Now
        Dim startDt As New Date(dt.Year, 1, 1)
        StartDate.Value = startDt.ToString("dd-MMM-yyyy")
        EndDate.Value = Today.ToString("dd-MMM-yyyy")

        ProgressSpinner1.Visible = True
        LabelStatus.Text = "Loading get data this year..."
        MetroPanel1.Enabled = False
        Me.Report_global_viewTableAdapter.FillByThisYear(Me.HCQC_NewDataset.report_global_view)
        Dim fillterStr, fillterStr2 As String
        fillterStr = Year(Now)
        fillterStr = "QC" & fillterStr & "%"

        fillterStr2 = Year(Now)
        fillterStr2 = "QC" & fillterStr2 & "%"
        LabelStatus.Text = "Loading...|2 get data Germination"
        GerminationTableAdapter1.FillByStr(Me.HCQC_NewDataset.germination, fillterStr, fillterStr2)
        LabelStatus.Text = "Loading...|3 get data Viability"
        ViabilityTableAdapter1.FillByStr(Me.HCQC_NewDataset.viability, fillterStr, fillterStr2)
        LabelStatus.Text = "Loading...|4 get data Rafactiony"
        RafactionTableAdapter1.FillByStr(Me.HCQC_NewDataset.rafaction, fillterStr, fillterStr2)
        LabelStatus.Text = "Loading...|5 get data Moisture"
        MoistureTableAdapter1.FillByStr(Me.HCQC_NewDataset.moisture, fillterStr, fillterStr2)
        LabelStatus.Text = "Loading...|6 get data Purity"
        PurityTableAdapter1.FillByStr(Me.HCQC_NewDataset.purity, fillterStr, fillterStr2)
        LabelStatus.Text = "Loading...|7 get data ArchiveFG"
        ArchiveTableAdapter1.FillByStr(Me.HCQC_NewDataset.archive, fillterStr, fillterStr2)
        ProgressSpinner1.Visible = False
        MetroPanel1.Enabled = True
        BtnFilterDate.Enabled = True
        LabelStatus.Text = "Nilai persentase -1 menandakan bahwa sampel tidak di lakukan pengujian tertentu"
    End Sub

    Private Sub LinkAll_Click(sender As Object, e As EventArgs)
        Me.Report_global_viewTableAdapter.Fill(Me.HCQC_NewDataset.report_global_view)

        GerminationTableAdapter1.Fill(Me.HCQC_NewDataset.germination)
        ViabilityTableAdapter1.Fill(Me.HCQC_NewDataset.viability)
        RafactionTableAdapter1.Fill(Me.HCQC_NewDataset.rafaction)
        MoistureTableAdapter1.Fill(Me.HCQC_NewDataset.moisture)
        PurityTableAdapter1.Fill(Me.HCQC_NewDataset.purity)
        ArchiveTableAdapter1.Fill(Me.HCQC_NewDataset.archive)
    End Sub

    Private Sub BtnFilterDate_Click(sender As Object, e As EventArgs) Handles BtnFilterDate.Click
        'If StartDate.Value.Date > EndDate.Value.Date Then
        '    MetroMessageBox.Show(Me, "'Start Date' harus lebih kecil dari 'End Date'", "Global Report HCQC")
        '    Return
        'End If
        ProgressSpinner1.Visible = True

        LabelStatus.Text = "Loading get data this year..."
        MetroPanel1.Enabled = False
        BtnFilterDate.Enabled = False

        Dim filterStart, filterEnd As String
        filterStart = StartDate.Value.Date.ToString("yyyy") & StartDate.Value.Date.ToString("MM")
        filterStart = "QC" & filterStart & "%"

        filterEnd = EndDate.Value.Date.ToString("yyyy") & EndDate.Value.Date.ToString("MM")
        filterEnd = "QC" & filterEnd & "%"
        'Console.WriteLine(filterStart & " --- " & filterEnd)

        Me.Report_global_viewTableAdapter.FillByFilterDate(Me.HCQC_NewDataset.report_global_view, StartDate.Value.Date, EndDate.Value.Date)

        LabelStatus.Text = "Loading...|2 get data Germination"
        GerminationTableAdapter1.FillByStr(Me.HCQC_NewDataset.germination, filterStart, filterEnd)
        LabelStatus.Text = "Loading...|3 get data Viability"
        ViabilityTableAdapter1.FillByStr(Me.HCQC_NewDataset.viability, filterStart, filterEnd)
        LabelStatus.Text = "Loading...|4 get data Rafactiony"
        RafactionTableAdapter1.FillByStr(Me.HCQC_NewDataset.rafaction, filterStart, filterEnd)
        LabelStatus.Text = "Loading...|5 get data Moisture"
        MoistureTableAdapter1.FillByStr(Me.HCQC_NewDataset.moisture, filterStart, filterEnd)
        LabelStatus.Text = "Loading...|6 get data Purity"
        PurityTableAdapter1.FillByStr(Me.HCQC_NewDataset.purity, filterStart, filterEnd)
        LabelStatus.Text = "Loading...|7 get data ArchiveFG"
        ArchiveTableAdapter1.FillByStr(Me.HCQC_NewDataset.archive, filterStart, filterEnd)

        ProgressSpinner1.Visible = False
        MetroPanel1.Enabled = True
        BtnFilterDate.Enabled = True
        LabelStatus.Text = "Nilai persentase -1 menandakan bahwa sampel tidak di lakukan pengujian tertentu"
    End Sub
End Class