Imports System.Drawing
Imports MetroFramework.Forms
Imports System.Globalization
Imports System.Windows.Forms
Imports MetroFramework

<System.Serializable()> Public Class MinForm

    Private Sub MinForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If InputToolStripMenuItem.Enabled = False Then
            SampelMasukToolStripMenuItem2.Enabled = False
            SampelTesKontrolToolStripMenuItem2.Enabled = False
            KadarAirToolStripMenuItem5.Enabled = False
            DayaTumbuhToolStripMenuItem5.Enabled = False
        Else
            SampelMasukToolStripMenuItem2.Enabled = True
            SampelTesKontrolToolStripMenuItem2.Enabled = True
            KadarAirToolStripMenuItem5.Enabled = True
            DayaTumbuhToolStripMenuItem5.Enabled = True
        End If

        If InputToolStripMenuItem1.Enabled = False Then
            SampelMasukToolStripMenuItem3.Enabled = False
            SampleTesKontrolToolStripMenuItem.Enabled = False
            RafaksiToolStripMenuItem2.Enabled = False
            KadarAirToolStripMenuItem.Enabled = False
            DayaTumbuhToolStripMenuItem.Enabled = False
            InspectionRMToolStripMenuItem.Enabled = False
        Else
            SampelMasukToolStripMenuItem3.Enabled = True
            SampleTesKontrolToolStripMenuItem.Enabled = True
            KadarAirToolStripMenuItem.Enabled = True
            RafaksiToolStripMenuItem2.Enabled = True
            DayaTumbuhToolStripMenuItem.Enabled = True
            InspectionRMToolStripMenuItem.Enabled = True
        End If

        If InputToolStripMenuItem2.Enabled = False Then
            SampelMasukToolStripMenuItem4.Enabled = False
            SampelTesKontrolToolStripMenuItem.Enabled = False
            KadarAirToolStripMenuItem3.Enabled = False
            DayaTumbuhToolStripMenuItem4.Enabled = False
        Else
            SampelMasukToolStripMenuItem4.Enabled = True
            SampelTesKontrolToolStripMenuItem.Enabled = True
            KadarAirToolStripMenuItem3.Enabled = True
            DayaTumbuhToolStripMenuItem4.Enabled = True
        End If

        If InputToolStripMenuItem3.Enabled = False Then
            SampelMasukToolStripMenuItem5.Enabled = False
            SampelTesKontrolToolStripMenuItem1.Enabled = False
            ArsipKontrolToolStripMenuItem.Enabled = False
            DayaTumbuhToolStripMenuItem1.Enabled = False
        Else
            SampelMasukToolStripMenuItem5.Enabled = True
            SampelTesKontrolToolStripMenuItem1.Enabled = True
            ArsipKontrolToolStripMenuItem.Enabled = True
            DayaTumbuhToolStripMenuItem1.Enabled = True
        End If

        If InputToolStripMenuItem4.Enabled = False Then
            SampelMasukToolStripMenuItem.Enabled = False
            DayaTumbuhToolStripMenuItem2.Enabled = False
        Else
            SampelMasukToolStripMenuItem.Enabled = True
            DayaTumbuhToolStripMenuItem2.Enabled = True
        End If
    End Sub

    Private Sub MetroTile1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile1.Click
        'menu Gravity
        MetroContextMenu1.Show(MetroTile1, New Point(0, MetroTile1.Height))
    End Sub

    Private Sub MetroTile2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile2.Click
        'menu Periodik
        MetroMenuPeriodik.Show(MetroTile2, New Point(0, MetroTile2.Height))
    End Sub

    Private Sub MetroTile3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile3.Click
        'menuFinish Good
        MetroMenuFinishGd.Show(MetroTile3, New Point(0, MetroTile3.Height))
    End Sub

    Private Sub MetroTile4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile4.Click
        'menuExternal
        MetroMenuExternal.Show(MetroTile4, New Point(0, MetroTile4.Height))
    End Sub

    Private Sub MetroTile7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile7.Click
        'menu Row Material
        MetroMenuRM.Show(MetroTile7, New Point(0, MetroTile7.Height))
    End Sub
    'Ganti gaya/Style
    Private Sub MetroTile5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile5.Click
        Dim m = New Random()
        Dim int = m.Next(0, 14)
        Me.Style = int
        MetroStyleManager1.Style = int
        My.Settings.gaya = int
    End Sub
    'Ganti Tema/Theme
    Private Sub MetroTile6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile6.Click
        If ((MetroStyleManager1.Theme = MetroThemeStyle.Light) And ((Me.Theme = MetroThemeStyle.Light) Or (Me.Theme = MetroThemeStyle.Default))) Then
            Me.Theme = MetroThemeStyle.Dark
            MetroStyleManager1.Theme = MetroThemeStyle.Dark
            WindowsApplication1.My.Settings.tema = MetroThemeStyle.Dark
        ElseIf (MetroStyleManager1.Theme = MetroThemeStyle.Dark) And (Me.Theme = MetroThemeStyle.Dark) Then
            Me.Theme = MetroThemeStyle.Light
            MetroStyleManager1.Theme = MetroThemeStyle.Light
            WindowsApplication1.My.Settings.tema = MetroThemeStyle.Light
        End If
    End Sub

    'Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
    '    WIP.Show()
    '    WIP.Focus()
    'End Sub

    'Private Sub MetroButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton3.Click
    '    FinishGood.Show()
    '    FinishGood.Focus()
    '    'FinishGood.TopMost = True
    'End Sub

    'Private Sub MetroButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton4.Click
    '    External_Certification.Show()
    '    External_Certification.Focus()
    'End Sub

    'Private Sub ReportGravityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Parameter_Grafity.Show()
    '    Parameter_Grafity.Focus()

    'End Sub

    Private Sub KadarAirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MoistureTest1.Show()
        MoistureTest1.Focus()
        'MoistureTest1.TopMost = True
    End Sub

    'Private Sub MetroButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton2.Click
    '    Periodic.Show()
    '    Periodic.Focus()
    'End Sub

    Private Sub ReportDTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Report_External.Show()
        Report_External.FocusMe()
        'Report_Data_View.Show()
    End Sub

    Private Sub DayaTumbuhToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Daya_Tumbuh_Periodik.Show()
        Daya_Tumbuh_Periodik.FocusMe()
    End Sub

    Private Sub DataListToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataListToolStripMenuItem2.Click
        Data_List_Finish_Goods.Show()
        Data_List_Finish_Goods.FocusMe()
    End Sub

    Private Sub ReportFinishGoodToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportFinishGoodToolStripMenuItem.Click
        Report_Finish_Goods.Show()
        Report_Finish_Goods.FocusMe()
    End Sub

    Private Sub pnl_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ReportRawMaterialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Report_Raw_Material.Show()
        Report_Raw_Material.FocusMe()
    End Sub

    Private Sub InspetionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Inspection_Raw_Material_Seedless.Show()
        Inspection_Raw_Material_Seedless.FocusMe()
    End Sub

    Private Sub LeadTimeToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeadTimeToolStripMenuItem3.Click
        Lead_Time_FG.Show()
        Lead_Time_FG.FocusMe()
    End Sub

    Private Sub MetroLink1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroLink1.Click
        About_HCQC_aplication.Show()
        About_HCQC_aplication.FocusMe()
    End Sub

    'menampilkan meni
    Private Sub SampelMasukToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampelMasukToolStripMenuItem2.Click
        PenerimaSampelGravity.Show()
        PenerimaSampelGravity.FocusMe()
    End Sub

    Private Sub SampelTesKontrolToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampelTesKontrolToolStripMenuItem2.Click
        Sample_Test_Control_G.Show()
        Sample_Test_Control_G.FocusMe()
    End Sub

    Private Sub KadarAirToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KadarAirToolStripMenuItem5.Click
        MoistureTest1.Show()
        MoistureTest1.Focus()
    End Sub

    Private Sub RafaksiToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RafaksiToolStripMenuItem2.Click
        PurityAndRafakctionAnalysis.Show()
        PurityAndRafakctionAnalysis.Focus()
    End Sub

    Private Sub DayaTumbuhToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DayaTumbuhToolStripMenuItem5.Click
        Daya_Tumbuh.Show()
        Daya_Tumbuh.FocusMe()
    End Sub

    Private Sub DataGlobalRMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGlobalRMToolStripMenuItem.Click
        Data_List_Grafity.Show()
        Data_List_Grafity.FocusMe()
    End Sub

    Private Sub DataKadarAirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataKadarAirToolStripMenuItem.Click
        Data_List_Moisture_Test.Show()
        Data_List_Moisture_Test.FocusMe()
    End Sub

    Private Sub DataRafaksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataRafaksiToolStripMenuItem.Click
        Data_List_Refraction.Show()
    End Sub

    Private Sub DataDayaTumbuhToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataDayaTumbuhToolStripMenuItem.Click
        Data_List_Daya_Tumbuh.Show()
        Data_List_Daya_Tumbuh.FocusMe()
    End Sub

    Private Sub LaporanWIPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanWIPToolStripMenuItem.Click
        Data_List_WIP.Show()
        Data_List_WIP.FocusMe()
    End Sub

    Private Sub LeadTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeadTimeToolStripMenuItem.Click
        Lead_Time_Gravity.Show()
        Lead_Time_Gravity.FocusMe()
    End Sub

    Private Sub CetakWIPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakWIPToolStripMenuItem.Click
        PreviewGrafity.Show()
        PreviewGrafity.FocusMe()
    End Sub

    Private Sub SampelMasukToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampelMasukToolStripMenuItem3.Click
        PenerimaanSampleRM.Show()
        PenerimaanSampleRM.FocusMe()
    End Sub

    Private Sub SampleTesKontrolToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampleTesKontrolToolStripMenuItem.Click
        Sample_Test_Control.Show()
        Sample_Test_Control.FocusMe()
    End Sub

    Private Sub KadarAirToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KadarAirToolStripMenuItem.Click
        MoistureTestRM.Show()
        MoistureTestRM.FocusMe()
    End Sub

    Private Sub DayaTumbuhToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DayaTumbuhToolStripMenuItem.Click
        DayaTumbuhRM.Show()
        DayaTumbuhRM.FocusMe()
    End Sub

    Private Sub InspectionRMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InspectionRMToolStripMenuItem.Click
        Inspection_Raw_Material_Seedless.Show()
        Inspection_Raw_Material_Seedless.FocusMe()
    End Sub

    Private Sub DataGlobalRMToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGlobalRMToolStripMenuItem1.Click
        Data_List_Raw_Material.Show()
        Data_List_Raw_Material.FocusMe()
    End Sub

    Private Sub DataListInspectionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataListInspectionToolStripMenuItem1.Click
        Data_List_Inspeksi_Rm.Show()
        Data_List_Inspeksi_Rm.FocusMe()
    End Sub

    Private Sub CetakRawToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakRawToolStripMenuItem.Click
        Report_Raw_Material.Show()
        Report_Raw_Material.FocusMe()
    End Sub

    Private Sub LeadTimeToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeadTimeToolStripMenuItem5.Click
        Lead_Time_RM.Show()
        Lead_Time_RM.FocusMe()
    End Sub

    Private Sub SampelMasukToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampelMasukToolStripMenuItem4.Click
        PenerimaanSamplePeriodik.Show()
        PenerimaanSamplePeriodik.Focus()
    End Sub

    Private Sub SampelTesKontrolToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampelTesKontrolToolStripMenuItem.Click
        Sample_Test_Control_P.Show()
        Sample_Test_Control.FocusMe()
    End Sub

    Private Sub DataGlobalPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGlobalPToolStripMenuItem.Click
        Data_List_Periodik.Show()
        Data_List_Periodik.FocusMe()
    End Sub

    Private Sub LeadTimeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeadTimeToolStripMenuItem1.Click
        Lead_Time_Periodic.Show()
        Lead_Time_Periodic.FocusMe()
    End Sub

    Private Sub SampelMasukToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampelMasukToolStripMenuItem5.Click
        PenerimaanSampleFinish.Show()
        PenerimaanSampleFinish.FocusMe()
    End Sub

    Private Sub SampelTesKontrolToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampelTesKontrolToolStripMenuItem1.Click
        Sample_Test_Control_FG.Show()
        Sample_Test_Control_FG.FocusMe()
    End Sub

    Private Sub ArsipKontrolToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArsipKontrolToolStripMenuItem.Click
        Finish_Goods_Arsip.Show()
        Finish_Goods_Arsip.FocusMe()
    End Sub

    Private Sub DayaTumbuhToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DayaTumbuhToolStripMenuItem1.Click
        DayaTumbuhFG.Show()
        DayaTumbuhFG.FocusMe()
    End Sub

    Private Sub SampelMasukToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampelMasukToolStripMenuItem.Click
        Dim _pnl As New SampelMasukExternal(Me)
        AddHandler _pnl.Shown, AddressOf pnl_Shown
        _pnl.swiper(True)
        If SampelMasukToolStripMenuItem.Enabled = True Then
            SampelMasukToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub DayaTumbuhToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DayaTumbuhToolStripMenuItem2.Click
        Daya_Tumbuh_External.Show()
        Daya_Tumbuh_External.FocusMe()
    End Sub

    Private Sub DataGlobalEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGlobalEToolStripMenuItem.Click
        Data_List_External.Show()
        Data_List_External.FocusMe()
    End Sub

    Private Sub LeadTimeToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeadTimeToolStripMenuItem2.Click
        Lead_Time_External.Show()
        Lead_Time_External.FocusMe()
    End Sub

    Private Sub CetakEksternalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakEksternalToolStripMenuItem.Click
        Report_External.Show()
        Report_External.FocusMe()
    End Sub

    Private Sub MenuStrip1_MenuDeactivate(ByVal sender As Object, ByVal e As EventArgs) _
     Handles InputToolStripMenuItem.MouseHover


    End Sub

    Private Sub SampelTestKontrolToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampelTestKontrolToolStripMenuItem.Click
        Sample_Test_Control_E.Show()
        Sample_Test_Control_E.FocusMe()
    End Sub
End Class