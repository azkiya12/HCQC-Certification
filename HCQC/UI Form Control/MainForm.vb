Imports System.ComponentModel
Imports System.Reflection
Public Class MainForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'you can turn on double buffering.
        SetDoubleBuffered(Me)
        SetDoubleBuffered(MetroPanel5)

        Me.Size = New Size(1100, 570)
        Label1.Text = ""
        Label1.BackColor = Color.FromArgb(45, 46, 52)
        LTitileControl.Text = "HCQC Dashboard"
        LinkLabel1.Text = _DataToValue("Select [name] from [login] where id='" & login.Luserid.Text & "'")
        Dim aproval As Boolean = _DataToValue("SELECT [aproved] FROM [login] WHERE [id]='" & login.Luserid.Text & "'")
        Dim level As String = _DataToValue("SELECT [userlevel] FROM [login] WHERE [id]='" & login.Luserid.Text & "'")
        If aproval = True Then
            If level = 2 Or level = 7 Or level = 8 Then
                'BtnLinkImport.Enabled = False
                BtnCategoryCrop.Enabled = False
            End If
        Else
            'BtnLinkImport.Enabled = False
            BtnCategoryCrop.Enabled = False
        End If

        'notification neet to verification
        LabelNotifVerivicaion.Text = VerificationCount(PanelNotifVerification)
        Containermenu2.LabelNotifContainerTracing.Text = VerificationCount(Containermenu2.Panel2)

        ''Dashboard Filter TODAY in first time open
        LinkToday_LinkClicked(sender, e)

    End Sub

    Public Shared Sub SetDoubleBuffered(ByVal control As Control)
        GetType(Control).InvokeMember("DoubleBuffered", BindingFlags.SetProperty Or BindingFlags.Instance Or BindingFlags.NonPublic, Nothing, control, New Object() {True})
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BtnClose.Click

        Dim xChildWindows = Application.OpenForms

        If xChildWindows.OfType(Of Internal_report).Any Then
            xChildWindows.Item("Internal_report").Close()
        End If

        If xChildWindows.OfType(Of ista_report).Any Then
            xChildWindows.Item("ista_report").Close()
        End If

        If xChildWindows.OfType(Of global_report).Any Then
            xChildWindows.Item("global_report").Close()
        End If

        If xChildWindows.OfType(Of Periodic_Scedule).Any Then
            xChildWindows.Item("Periodic_Scedule").Close()
        End If

        If xChildWindows.OfType(Of leadtime_report).Any Then
            xChildWindows.Item("leadtime_report").Close()
        End If

        If xChildWindows.OfType(Of sas_report).Any Then
            xChildWindows.Item("sas_report").Close()
        End If
        Me.Close()
    End Sub

    Private Sub LinkLabel1_Click(sender As Object, e As EventArgs) Handles LinkLabel1.Click
        If Containerusermenu1.Visible = False Then
            BunifuTransition1.ShowSync(Containerusermenu1, False, BunifuAnimatorNS.Animation.VertSlide)
            LinkLabel1.LinkColor = Color.Black
            Containerusermenu1.BringToFront()
        Else
            Containerusermenu1.Visible = False
            LinkLabel1.LinkColor = Color.White
        End If
    End Sub

    Private Sub MetroPanel1_MouseEnter(sender As Object, e As EventArgs) Handles MetroPanel1.MouseEnter
        Containerusermenu1.Visible = False
        LinkLabel1.LinkColor = Color.White
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        If Panel1.Width = 250 Then
            Panel1.Width = 38
        Else
            Panel1.Width = 250
        End If
    End Sub

    Private Sub BtnFullScreen_Click(sender As Object, e As EventArgs) Handles BtnFullScreen.Click
        If BtnFullScreen.Tag = "Normal" Then
            Me.Top = 0
            Me.Left = 0
            Me.Height = Screen.PrimaryScreen.WorkingArea.Height
            Me.Width = Screen.PrimaryScreen.WorkingArea.Width
            BtnFullScreen.Tag = "Full Screen"
        Else
            Me.Size = New Size(1100, 570)
            Me.StartPosition = FormStartPosition.CenterScreen
            BtnFullScreen.Tag = "Normal"
        End If
    End Sub

    Private Sub MainForm_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        'BtnClose.Image = CType(Resources.GetObject("BtnClose.Image"), System.Drawing.Image)
    End Sub

    Private Sub MainForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        _RunSQL_nomsgbox("UPDATE [dbo].[login] SET [status] =0 WHERE id='" & login.Luserid.Text & "'")

    End Sub

    Private Sub ClearControls()
        'menghapus usercontrol Pada panel 5
        For indx As Integer = MetroPanel5.Controls.Count - 1 To 0 Step -1
            Dim ctl As Control
            ctl = MetroPanel5.Controls.Item(indx)
            MetroPanel5.Controls.Remove(ctl)
            ctl.Dispose()
        Next
    End Sub

    Private Sub BtnQcConfirm_Click(sender As Object, e As EventArgs) Handles BtnQcConfirm.Click

        ClearControls()

        'MetroPanel5.Controls.Clear()
        Dim UsQcVerification As QC_Verification = New QC_Verification With {
            .Size = New Point(MetroPanel5.Width - 3, MetroPanel5.Height - 7),
            .Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top
        }
        MetroPanel5.Controls.Add(UsQcVerification)
        'notification neet to verification
        LabelNotifVerivicaion.Text = VerificationCount(PanelNotifVerification)
        Containermenu2.LabelNotifContainerTracing.Text = VerificationCount(Containermenu2.Panel2)
        'BtnSampleReturn.Normalcolor = Color.Gray
        BtnQcConfirm.Normalcolor = Color.FromArgb(46, 139, 87)
    End Sub

    Private Sub BtnLinkImport_MouseEnter(sender As Object, e As EventArgs)
        ' BtnLinkImport.BackColor = Color.FromArgb(70, 179, 226)
    End Sub

    Private Sub BtnLinkImport_MouseLeave(sender As Object, e As EventArgs)
        'BtnLinkImport.BackColor = Color.Transparent
    End Sub

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        login.Show()
    End Sub

    Private Sub BtnPrintLabel_Click(sender As Object, e As EventArgs) Handles BtnPrintLabel.Click
        Report_Label_HCQC.ShowDialog(Me)
    End Sub

    Private Sub BtnCategoryCrop_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BtnCategoryCrop.LinkClicked
        Category_List.ShowDialog(Me)
    End Sub

    Private Sub BtnCategoryCrop_MouseEnter(sender As Object, e As EventArgs) Handles BtnCategoryCrop.MouseEnter
        BtnCategoryCrop.BackColor = Color.FromArgb(70, 179, 226)
    End Sub

    Private Sub BtnCategoryCrop_MouseLeave(sender As Object, e As EventArgs) Handles BtnCategoryCrop.MouseLeave
        BtnCategoryCrop.BackColor = Color.Transparent
    End Sub

    Private Sub LinkReport_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkReport.LinkClicked
        Print_Report.Show()
    End Sub

    Private Sub LinkReport_MouseEnter(sender As Object, e As EventArgs) Handles LinkReport.MouseEnter
        LinkReport.BackColor = Color.FromArgb(70, 179, 226)
    End Sub

    Private Sub LinkReport_MouseLeave(sender As Object, e As EventArgs) Handles LinkReport.MouseLeave
        LinkReport.BackColor = Color.Transparent
    End Sub

    Sub GetCountMonth(ByVal filter As String)
        LTodayRequestHome.Text = _DataToValue("SELECT COUNT(id) [Request Count]
                                            FROM [HCQC_server].[dbo].[spl_request] 
                                            where convert(Date,input_date)= CONVERT(Date,GETDATE())")

        LabelValueRequest.Text = _DataToValue("SELECT COUNT(id) [Request Count]
                                            FROM [HCQC_server].[dbo].[spl_request] " & filter.Replace("[column]", "[input_date]"))

        LabelValueVerivication.Text = _DataToValue("SELECT COUNT(id) [Verivication Count]
                                            FROM [HCQC_server].[dbo].[qc_confirm] " & filter.Replace("[column]", "[tgl_confirm]"))

        LabelValueReceipt.Text = _DataToValue("SELECT COUNT(id) [Verivication Count]
                                            FROM [HCQC_server].[dbo].[receipt] " & filter.Replace("[column]", "[datein]"))

        LabelValueKA.Text = _DataToValue("SELECT COUNT(id) id FROM [HCQC_server].[dbo].[periodic_schedule]" &
                                         filter.Replace("[column]", "[test_date]") & " AND [test_on]='Moisture Test'")

        LabelValuePur.Text = _DataToValue("SELECT COUNT(id) id FROM [HCQC_server].[dbo].[periodic_schedule]" &
                                         filter.Replace("[column]", "[test_date]") & " AND [test_on]='Purity Test'")

        LabelValueRaf.Text = _DataToValue("SELECT COUNT(id) id FROM [HCQC_server].[dbo].[periodic_schedule]" &
                                         filter.Replace("[column]", "[test_date]") & " AND [test_on]='Rafaction Test'")

        LabelValueVia.Text = _DataToValue("SELECT COUNT(id) id FROM [HCQC_server].[dbo].[periodic_schedule]" &
                                         filter.Replace("[column]", "[test_date]") & " AND [test_on]='Viability Test'")

        LabelValueGerTest.Text = _DataToValue("SELECT COUNT(id) id FROM [HCQC_server].[dbo].[periodic_schedule]" &
                                         filter.Replace("[column]", "[test_date]") & " AND [test_on]='Germination Test'")

        LabelValueGerOut.Text = _DataToValue("SELECT COUNT(id) id FROM [HCQC_server].[dbo].[periodic_schedule]" &
                                         filter.Replace("[column]", "[test_date]") & " AND ([test_on]='Check Out Germination' OR [test_on]='Germination Vigor')")

        LabelValueSpl.Text = _DataToValue("SELECT COUNT(id) FROM [HCQC_server].[dbo].[receipt] " &
                                          filter.Replace("[column]", "[sampling]"))

        LabelC_moi.Text = _DataToValue("SELECT COUNT(dbo.spl_request.id) id FROM dbo.spl_request RIGHT OUTER JOIN dbo.receipt ON dbo.spl_request.id = dbo.receipt.id_request" &
                                        filter.Replace("[column]", "dbo.receipt.datein") & " AND dbo.spl_request.test_moi=1")
        LabelC_Pur.Text = _DataToValue("SELECT COUNT(dbo.spl_request.id) id FROM dbo.spl_request RIGHT OUTER JOIN dbo.receipt ON dbo.spl_request.id = dbo.receipt.id_request" &
                                        filter.Replace("[column]", "dbo.receipt.datein") & " AND dbo.spl_request.test_pur=1")
        LabelC_Raf.Text = _DataToValue("SELECT COUNT(dbo.spl_request.id) id FROM dbo.spl_request RIGHT OUTER JOIN dbo.receipt ON dbo.spl_request.id = dbo.receipt.id_request" &
                                        filter.Replace("[column]", "dbo.receipt.datein") & " AND dbo.spl_request.test_raf=1")
        LabelC_Via.Text = _DataToValue("SELECT COUNT(dbo.spl_request.id) id FROM dbo.spl_request RIGHT OUTER JOIN dbo.receipt ON dbo.spl_request.id = dbo.receipt.id_request" &
                                        filter.Replace("[column]", "dbo.receipt.datein") & " AND dbo.spl_request.test_via=1")
        LabelC_ger.Text = _DataToValue("SELECT COUNT(dbo.spl_request.id) id FROM dbo.spl_request RIGHT OUTER JOIN dbo.receipt ON dbo.spl_request.id = dbo.receipt.id_request" &
                                        filter.Replace("[column]", "dbo.receipt.datein") & " AND dbo.spl_request.test_ger=1")
    End Sub

    Public Sub LinkToday_LinkClicked(sender As Object, e As EventArgs) Handles LinkToday.LinkClicked
        LabelTitleRequest.Text = UCase(LinkToday.Text)
        LabelTitleVerification.Text = UCase(LinkToday.Text)
        LabelTitleReceipt.Text = UCase(LinkToday.Text)
        LabelTitleKa.Text = UCase(LinkToday.Text)
        LabelTitlePur.Text = UCase(LinkToday.Text)
        LabelTitleRaf.Text = UCase(LinkToday.Text)
        LabelTitleVia.Text = UCase(LinkToday.Text)
        LabelTitleGerTest.Text = UCase(LinkToday.Text)
        LabelTitleGerOut.Text = UCase(LinkToday.Text)
        LabelTitleSpl.Text = UCase(LinkToday.Text)

        ''filter This Day
        GetCountMonth(" where convert(Date,[column])= CONVERT(Date,GETDATE())")
    End Sub

    Private Sub LinkWeek_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkWeek.LinkClicked
        LabelTitleRequest.Text = UCase(LinkWeek.Text)
        LabelTitleVerification.Text = UCase(LinkWeek.Text)
        LabelTitleReceipt.Text = UCase(LinkWeek.Text)
        LabelTitleKa.Text = UCase(LinkWeek.Text)
        LabelTitlePur.Text = UCase(LinkWeek.Text)
        LabelTitleRaf.Text = UCase(LinkWeek.Text)
        LabelTitleVia.Text = UCase(LinkWeek.Text)
        LabelTitleGerTest.Text = UCase(LinkWeek.Text)
        LabelTitleGerOut.Text = UCase(LinkWeek.Text)
        LabelTitleSpl.Text = UCase(LinkWeek.Text)

        ''Filter This Week
        GetCountMonth(" WHERE  CONVERT(DATETIME, [column], 102) >= DATEADD(DAY, DATEDIFF(DAY, 0, GETDATE()) / 7 * 7, 0) AND 
                        CONVERT(DATETIME, [column], 102) < DATEADD(DAY, DATEDIFF(DAY, -1, GETDATE()), 0)")
    End Sub

    Private Sub LinkMonth_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkMonth.LinkClicked
        LabelTitleRequest.Text = UCase(LinkMonth.Text)
        LabelTitleVerification.Text = UCase(LinkMonth.Text)
        LabelTitleReceipt.Text = UCase(LinkMonth.Text)
        LabelTitleKa.Text = UCase(LinkMonth.Text)
        LabelTitlePur.Text = UCase(LinkMonth.Text)
        LabelTitleRaf.Text = UCase(LinkMonth.Text)
        LabelTitleVia.Text = UCase(LinkMonth.Text)
        LabelTitleGerTest.Text = UCase(LinkMonth.Text)
        LabelTitleGerOut.Text = UCase(LinkMonth.Text)
        LabelTitleSpl.Text = UCase(LinkMonth.Text)

        ''Filter This Month
        GetCountMonth(" WHERE ([column] >= DATEADD(dd, 1, EOMONTH(GETDATE(), - 1))) AND ([column] < DATEADD(dd, 1, EOMONTH(GETDATE())))")
    End Sub

    Private Sub LinkToday_MouseEnter(sender As Object, e As EventArgs) Handles LinkToday.MouseEnter
        LinkToday.BackColor = Color.DimGray
    End Sub

    Private Sub LinkToday_MouseLeave(sender As Object, e As EventArgs) Handles LinkToday.MouseLeave
        LinkToday.BackColor = Color.Transparent
    End Sub

    Private Sub LinkWeek_MouseEnter(sender As Object, e As EventArgs) Handles LinkWeek.MouseEnter
        LinkWeek.BackColor = Color.DimGray
    End Sub

    Private Sub LinkWeek_MouseLeave(sender As Object, e As EventArgs) Handles LinkWeek.MouseLeave
        LinkWeek.BackColor = Color.Transparent
    End Sub

    Private Sub LinkMonth_MouseEnter(sender As Object, e As EventArgs) Handles LinkMonth.MouseEnter
        LinkMonth.BackColor = Color.DimGray
    End Sub

    Private Sub LinkMonth_MouseLeave(sender As Object, e As EventArgs) Handles LinkMonth.MouseLeave
        LinkMonth.BackColor = Color.Transparent
    End Sub

    Public Sub LinkHome_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkHome.LinkClicked

        If (Label1.Text = "") = False Then
            Dim c As Control = MetroPanel3.Controls.Find(Label1.Text, False)(0)
            For Each contr As IDisposable In MetroPanel3.Controls
                c.Dispose()
            Next

            If c IsNot Nothing Then
                MetroPanel3.Controls.Remove(c)
                Label1.Text = ""
            End If
        End If
        MetroPanel5.Visible = False
        MetroPanel5.Controls.Clear()
        MetroPanel5.Visible = True
        DashboardPanel5.BringToFront()
        LTitileControl.Text = "HCQC Dashboard"
    End Sub

    Private Sub BtnClose_MouseEnter(sender As Object, e As EventArgs) Handles BtnClose.MouseEnter
        BtnClose.BackColor = Color.Red
    End Sub

    Private Sub BtnClose_MouseLeave(sender As Object, e As EventArgs) Handles BtnClose.MouseLeave
        BtnClose.BackColor = Color.Transparent
    End Sub

    Private Sub LinkHome_MouseEnter(sender As Object, e As EventArgs) Handles LinkHome.MouseEnter
        LinkHome.BackColor = Color.FromArgb(70, 179, 226)
    End Sub

    Private Sub LinkHome_MouseLeave(sender As Object, e As EventArgs) Handles LinkHome.MouseLeave
        LinkHome.BackColor = Color.Transparent
    End Sub

    Private Sub MainForm_Validating(sender As Object, e As CancelEventArgs) Handles Me.Validating
        SetDoubleBuffered(MetroPanel4)
    End Sub

End Class