Public Class containermenu

    Sub AutentificatioUser()
        Dim level As String = _DataToValue("SELECT [userlevel] FROM [login] WHERE [id]='" & login.Luserid.Text & "'")
        If _DataToValue("SELECT [aproved] FROM [login] WHERE [id]='" & login.Luserid.Text & "'") = True Then
            If level = 2 Or level = 7 Or level = 8 Then
                BtnRequest.Enabled = True
                BtnQcMenu.Enabled = False
                BtnSamReceipt2.Enabled = False
                BtnSamArchive.Enabled = False

                BtnRafraction.Enabled = False
                BtnViability.Enabled = False
                BtnInspection.Enabled = False

                BtnMoisture.Enabled = False
                BtnPurity.Enabled = False
                BtnGermination.Enabled = False
                BtnListReportSas.Enabled = False
            End If
        Else
            BtnRequest.Enabled = False
            BtnQcMenu.Enabled = False
            BtnSamReceipt2.Enabled = False
            BtnSamArchive.Enabled = False

            BtnRafraction.Enabled = False
            BtnViability.Enabled = False
            BtnInspection.Enabled = False

            BtnMoisture.Enabled = False
            BtnPurity.Enabled = False
            BtnGermination.Enabled = False
            BtnListReportSas.Enabled = False
        End If
    End Sub
    Public Sub ShowUserControl(ByVal Control As MetroUserControl, ByVal TitleControl As String) ', ByVal DelString As String)
        'deklarasi awal
        'Dim USmoisture As Moisture_Test = New Moisture_Test

        'menghapus usercontrol sesuai nama yang aktif
        If (MainForm.Label1.Text = "") = False Then
            Dim c As Control = MainForm.MetroPanel3.Controls.Find(MainForm.Label1.Text, False)(0)
            For Each contr As IDisposable In MainForm.MetroPanel3.Controls
                c.Dispose()
            Next

            If c IsNot Nothing Then
                MainForm.MetroPanel3.Controls.Remove(c)
                MainForm.Label1.Text = ""
            End If
        End If

        ''Memastikan Posisi MetroPanel3 Order Kedepan/BringToFront
        MainForm.MetroPanel3.BringToFront()
        MainForm.MetroPanel2.SendToBack()
        Dim count As Integer = MainForm.MetroPanel3.Controls.OfType(Of TextBox).ToList.Count
        ''Menampilkan Titile yg di panggil
        MainForm.LTitileControl.Text = TitleControl

        ''Memanggil UserControl Ke MetroPanel3
        Control.Size = New Point(MainForm.MetroPanel3.Width - 6, MainForm.MetroPanel3.Height - 3)
        Control.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Control.Name = "txt_" & (count + 1)
        MainForm.MetroPanel3.Controls.Add(Control)
        MainForm.MetroPanel3.AutoScroll = True
        MainForm.Label1.Text = Control.Name

    End Sub

    Private Sub BtnMainMenu_Click(sender As Object, e As EventArgs) Handles BtnMainMenu.Click
        If PnMainMenu.Visible = False Then
            BunifuTransition1.ShowSync(PnMainMenu, False, BunifuAnimatorNS.Animation.VertSlide)
        Else
            PnMainMenu.Visible = False
        End If
    End Sub

    Private Sub BtnSampling_Click(sender As Object, e As EventArgs) Handles BtnSampling.Click
        If PnSampling.Visible = False Then
            BunifuTransition1.ShowSync(PnSampling, False, BunifuAnimatorNS.Animation.VertSlide)
        Else
            PnSampling.Visible = False
        End If
    End Sub

    Private Sub BtnInternal_Click(sender As Object, e As EventArgs) Handles BtnInternal.Click
        If PnInternal.Visible = False Then
            BunifuTransition1.ShowSync(PnInternal, False, BunifuAnimatorNS.Animation.VertSlide)
        Else
            PnInternal.Visible = False
        End If
    End Sub

    Private Sub BtnStandard_Click(sender As Object, e As EventArgs) Handles BtnStandard.Click
        If PnStandar.Visible = False Then
            BunifuTransition1.ShowSync(PnStandar, False, BunifuAnimatorNS.Animation.VertSlide)
        Else
            PnStandar.Visible = False
        End If
    End Sub

    Private Sub BtnMonitor_Click(sender As Object, e As EventArgs) Handles BtnMonitor.Click
        If PnMonitor.Visible = False Then
            BunifuTransition1.ShowSync(PnMonitor, False, BunifuAnimatorNS.Animation.VertSlide)
        Else
            PnMonitor.Visible = False
        End If
    End Sub

    Private Sub BtnBtnQcMenu_Click(sender As Object, e As EventArgs) Handles BtnQcMenu.Click
        MainForm.MetroPanel4.BringToFront()
        ''membershkan usercontrol pada panel 3
        If (MainForm.Label1.Text = "") = False Then
            Dim c As Control = MainForm.MetroPanel3.Controls.Find(MainForm.Label1.Text, False)(0)
            For Each contr As IDisposable In MainForm.MetroPanel3.Controls
                c.Dispose()
            Next

            If c IsNot Nothing Then
                MainForm.MetroPanel3.Controls.Remove(c)
                MainForm.Label1.Text = ""
            End If
        End If
        MainForm.LTitileControl.Text = "Testing Request"
    End Sub

    Private Sub BtnSamReceipt2_Click(sender As Object, e As EventArgs) Handles BtnSamReceipt2.Click
        'MainForm.MetroPanel5.Controls.Clear()
        MainForm.MetroPanel2.BringToFront()
        'MainForm.Label1.Text = ""
        ''membershkan usercontrol pada panel 3
        If (MainForm.Label1.Text = "") = False Then
            Dim c As Control = MainForm.MetroPanel3.Controls.Find(MainForm.Label1.Text, False)(0)
            For Each contr As IDisposable In MainForm.MetroPanel3.Controls
                c.Dispose()
            Next

            If c IsNot Nothing Then
                MainForm.MetroPanel3.Controls.Remove(c)
                MainForm.Label1.Text = ""
            End If
        End If
        MainForm.LTitileControl.Text = "Sample Receipt"
        MainForm.Sample_Receipt1.tlabnum.Select()
    End Sub

    'button ini sudah di pindah di form Germination Test
    Private Sub BtnSamControl_Click(sender As Object, e As EventArgs)
        Dim USControl As Sample_Control = New Sample_Control
        ShowUserControl(USControl, "Sample Control")
        USControl.tlabnum.Select()
    End Sub

    Private Sub BtnSamArchive_Click(sender As Object, e As EventArgs) Handles BtnSamArchive.Click
        Dim USArchive As Sample_Archive = New Sample_Archive
        ShowUserControl(USArchive, "Sample Archive")
        USArchive.tlabnum.Select()
    End Sub

    Private Sub BtnRafraction_Click(sender As Object, e As EventArgs) Handles BtnRafraction.Click
        Dim USRafraction As Internal_Rafraction_Test = New Internal_Rafraction_Test
        ShowUserControl(USRafraction, "Rafaction Test")
        USRafraction.tlabnum.Select()
    End Sub

    Private Sub BtnViability_Click(sender As Object, e As EventArgs) Handles BtnViability.Click
        Dim USviability As Viability_Test = New Viability_Test
        ShowUserControl(USviability, "Viabiliti Test")
        USviability.tlabnum.Select()
    End Sub

    Private Sub BtnInspection_Click(sender As Object, e As EventArgs) Handles BtnInspection.Click
        Dim USinspection As Inspection_RM = New Inspection_RM
        ShowUserControl(USinspection, "Inspection RM")
        USinspection.tlabnum.Select()
    End Sub

    Private Sub BtnMoisture_Click(sender As Object, e As EventArgs) Handles BtnMoisture.Click
        Dim USmoisture As Moisture_Test = New Moisture_Test
        ShowUserControl(USmoisture, "Moisture Test")
        USmoisture.tlabnum.Select()
    End Sub

    Private Sub BtnPurity_Click(sender As Object, e As EventArgs) Handles BtnPurity.Click
        Dim USpurity As PurityTest = New PurityTest
        ShowUserControl(USpurity, "Purity Test")
        USpurity.tlabnum.Select()
    End Sub

    Private Sub BtnGermination_Click(sender As Object, e As EventArgs) Handles BtnGermination.Click
        Dim USgermination As Germination_Test = New Germination_Test
        ShowUserControl(USgermination, "Germination Test")
        USgermination.tlabnum.Select()
    End Sub

    Private Sub BtnRequest_Click(sender As Object, e As EventArgs) Handles BtnRequest.Click
        Dim USRequest As Request_Sampling_From = New Request_Sampling_From
        ShowUserControl(USRequest, "Sampling and Testing Request Form")
        USRequest.tid_hvsprod.Select()
    End Sub

    Private Sub BtnTracking_Click(sender As Object, e As EventArgs) Handles BtnTracking.Click
        Dim UStracking As Sample_Tracking = New Sample_Tracking
        ShowUserControl(UStracking, "Sample Tracking")
    End Sub

    Private Sub BtnCheckin_Click(sender As Object, e As EventArgs) Handles BtnCheckin.Click
        Dim USCheckInSample As Check_in_Sample = New Check_in_Sample
        ShowUserControl(USCheckInSample, "Test Check In")
    End Sub

    Private Sub Containermenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        AutentificatioUser()
    End Sub

    Private Sub BtnListDetail_Click(sender As Object, e As EventArgs) Handles BtnListDetail.Click
        'Menampilkan Internal Datalist
        Dim xChildWindows = Application.OpenForms.OfType(Of Internal_report)
        If xChildWindows.Any Then
            xChildWindows.First().Focus() 'Focus if exists
        Else
            Dim xfrmNew As New Internal_report() 'Open window if doeasn't exists
            xfrmNew.Show()
            BtnListDetail.Enabled = False
        End If
    End Sub

    Private Sub BtnDetailList2_Click(sender As Object, e As EventArgs) Handles BtnDetailList2.Click
        'Menampilkan Standart ISTA Datalist
        Dim xChildWindows = Application.OpenForms.OfType(Of ista_report)
        If xChildWindows.Any Then
            xChildWindows.First().Focus() 'Focus if exists
        Else
            Dim xfrmNew As New ista_report() 'Open window if doeasn't exists
            xfrmNew.Show()
            BtnDetailList2.Enabled = False
        End If
    End Sub

    Private Sub BtnGlobal_Click(sender As Object, e As EventArgs) Handles BtnGlobal.Click
        Dim xChildWindows = Application.OpenForms.OfType(Of global_report)
        If xChildWindows.Any Then
            xChildWindows.First().Focus() 'Focus if exists
        Else
            Dim xfrmNew As New GridDevexpress() 'Open window if doeasn't exists
            xfrmNew.Show()
            BtnGlobal.Enabled = False
        End If
    End Sub

    Private Sub BtnPeriodic_Click(sender As Object, e As EventArgs) Handles BtnPeriodic.Click
        'Periodic Lead Time Scedule
        Dim xChildWindows = Application.OpenForms.OfType(Of Periodic_Scedule)
        If xChildWindows.Any Then
            xChildWindows.First().Focus() 'Focus if exists
        Else
            Dim xfrmNew As New Periodic_Scedule() 'Open window if doeasn't exists
            xfrmNew.Show()
            BtnPeriodic.Enabled = False
        End If
    End Sub

    Private Sub BtnLeadTime_Click(sender As Object, e As EventArgs) Handles BtnLeadTime.Click
        'Lead Time Schedule from receipt
        Dim xChildWindows = Application.OpenForms.OfType(Of leadtime_report)
        If xChildWindows.Any Then
            xChildWindows.First().Focus() 'Focus if exists
        Else
            Dim xfrmNew As New leadtime_report() 'Open window if doeasn't exists
            xfrmNew.Show()
            BtnLeadTime.Enabled = False
        End If
    End Sub

    Private Sub BtnListReportSas_Click(sender As Object, e As EventArgs) Handles BtnListReportSas.Click
        Dim xChildWindows = Application.OpenForms.OfType(Of sas_report)
        If xChildWindows.Any Then
            xChildWindows.First().Focus() 'Focus if exists
        Else
            Dim xfrmNew As New sas_report() 'Open window if doeasn't exists
            xfrmNew.Show()
            BtnListReportSas.Enabled = False
        End If
    End Sub

    Private Sub BtnHarvestPlan_Click(sender As Object, e As EventArgs) Handles BtnHarvestPlan.Click
        Dim xChildWindows = Application.OpenForms.OfType(Of Harvest_Planning)
        If xChildWindows.Any Then
            xChildWindows.First().Focus() 'Focus if exists
        Else
            Dim xfrmNew As New Harvest_Planning() 'Open window if doeasn't exists
            xfrmNew.Show()
            BtnHarvestPlan.Enabled = False
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim USDataListLama As Data_List_Program_Lama = New Data_List_Program_Lama
        ShowUserControl(USDataListLama, "Data List Program Lama")
    End Sub

    Private Sub AboutMeButton_Click(sender As Object, e As EventArgs) Handles AboutMeButton.Click
        About_HCQC_aplication.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class