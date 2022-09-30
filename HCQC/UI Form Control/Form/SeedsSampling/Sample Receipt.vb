Imports System.Data.SqlClient
Imports System.Globalization
Imports DgvFilterPopup
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors

Public Class Sample_Receipt

    ReadOnly tglnow As Date = Today
    Public Vstring, no1 As String
    Private barManager1 As BarManager
    Private popupMenu1 As PopupMenu
    Private btnPeriodic As BarButtonItem
    Private btnThisMonth As BarButtonItem
    Private btnLastMonth As BarButtonItem
    Private btnFinisGoods As BarButtonItem
    Private btnOther As BarButtonItem
    Private btnShowAll As BarButtonItem

    Private Sub DropDownOption()
        barManager1 = New BarManager()
        barManager1.Form = Me
        popupMenu1 = New PopupMenu(barManager1)

        btnThisMonth = New BarButtonItem(barManager1, "This Month")
        btnLastMonth = New BarButtonItem(barManager1, "Last Month")
        btnShowAll = New BarButtonItem(barManager1, "Show All")


        popupMenu1.AddItem(btnThisMonth)
        popupMenu1.AddItem(btnLastMonth)
        popupMenu1.AddItem(btnShowAll)

        DropDownButton1.DropDownControl = popupMenu1
        AddHandler DropDownButton1.Click, New System.EventHandler(AddressOf Me.dropDownButton1_Click)

        btnThisMonth.Tag = "thismonth"
        AddHandler btnThisMonth.ItemClick, AddressOf Me.btnThisMonth_ItemClick
        btnLastMonth.Tag = "lastmonth"
        AddHandler btnLastMonth.ItemClick, AddressOf Me.btnLastMonth_ItemClick
        btnShowAll.Tag = "showall"
        AddHandler btnShowAll.ItemClick, AddressOf Me.btnShowAll_ItemClick
    End Sub

    Private Sub UpdateDropDownButton(ByVal submenuItem As BarItem)
        DropDownButton1.Text = submenuItem.Caption
        DropDownButton1.Tag = submenuItem.Tag
    End Sub

    Private Sub Last_Month()
        Me.ReceiptListTableAdapter.FillByLastMonth(HCQC_NewDataset.ReceiptList)
    End Sub

    Private Sub This_Month()
        Me.ReceiptListTableAdapter.FillByThisMonth(HCQC_NewDataset.ReceiptList)
    End Sub

    Private Sub ShowAll()
        Me.ReceiptListTableAdapter.Fill(HCQC_NewDataset.ReceiptList)
    End Sub
    Private Sub dropDownButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownButton1.Click
        Dim tag As String = (TryCast(sender, DropDownButton)).Tag.ToString()

        If tag = "thismonth" Then
            This_Month()
        End If

        If tag = "lastmonth" Then
            Last_Month()
        End If

        If tag = "showall" Then
            ShowAll()
        End If
    End Sub

    Private Sub btnThisMonth_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        UpdateDropDownButton(e.Item)
        This_Month()
    End Sub

    Private Sub btnLastMonth_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        UpdateDropDownButton(e.Item)
        Last_Month()
    End Sub

    Private Sub btnShowAll_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        UpdateDropDownButton(e.Item)
        ShowAll()
    End Sub

    Public Sub TermalPrintLA2(sender As Object, e As EventArgs)
        Dim v_labnum, V_variety2, V_weight, V_job As String
        Dim zplcom As String


        v_labnum = tlabnum.Text
        V_variety2 = _DataToValue("SELECT [variety] FROM [qc_confirm_viewer]  WHERE [labnum]='" & tlabnum.Text & "'")
        V_weight = _DataToValue("SELECT [nomnl] FROM [qc_confirm_viewer]  WHERE [labnum]='" & tlabnum.Text & "'")
        V_job = _DataToValue("SELECT [nojob] FROM [qc_confirm_viewer]  WHERE [labnum]='" & tlabnum.Text & "'")

        zplcom = "CT~~CD,~CC^~CT~
                ^XA
                ~TA000
                ~JSN
                ^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR5,5
                ~SD30
                ^JUS^LRN^CI27^PA0,1,1,0
                ^XZ

                ^XA
                ^MMT^PW831^LL120^LS0
                ^BY1,3,37^FT46,76^BCN,,N,N
                ^FH\^FD>:QC" & v_labnum.Substring(v_labnum.Length - 10) & "^FS
                ^FT46,97^A0N,17,18^FH\^CI28^FD" & V_variety2 & "; " & V_weight & " / " & V_job & ";^FS^CI27
                ^FT46,32^AAN,18,10^FH\^FDQC" & v_labnum.Substring(v_labnum.Length - 10) & "^FS
                ^BY1,3,37^FT334,76^BCN,,N,N
                ^FH\^FD>:QC" & v_labnum.Substring(v_labnum.Length - 10) & "^FS
                ^FT334,97^A0N,17,18^FH\^CI28^FD" & V_variety2 & "; " & V_weight & " / " & V_job & ";^FS^CI27
                ^FT334,32^AAN,18,10^FH\^FDQC" & v_labnum.Substring(v_labnum.Length - 10) & "^FS
                ^BY1,3,37^FT621,76^BCN,,N,N
                ^FH\^FD>:QC" & v_labnum.Substring(v_labnum.Length - 10) & "^FS
                ^FT621,97^A0N,17,18^FH\^CI28^FD" & V_variety2 & "; " & V_weight & " / " & V_job & ";^FS^CI27
                ^FT621,32^AAN,18,10^FH\^FDQC" & v_labnum.Substring(v_labnum.Length - 10) & "^FS
                ^PQ" & tcopy.Text & ",0,1,Y
                ^XZ"

        If Cek_auto_print.Checked Then
            Printer.RawHelper.SendStringToPrinter(LabelPrinter.Text, zplcom)
        End If


    End Sub

    Private Sub LabelPrinter_Click(sender As Object, e As EventArgs) Handles LabelPrinter.Click
        Dim Select_Printer = New Select_Printer
        AddHandler Select_Printer.SavedOptions, AddressOf OnOptionsSave
        Select_Printer.ShowDialog(Me)
    End Sub

    Private Sub OnOptionsSave(ByVal strData As String)
        'Or whatever you want to do on frmMain with Options Data.
        LabelPrinter.Text = strData

    End Sub

    Private Sub BtnCariLab_Click(sender As Object, e As EventArgs) Handles BtnCariLab.Click
        Try
            Dim sql As String = ""
            openDB()
            sql = "SELECT [id]
                          ,[variety]
                          ,[farmer]
                          ,[location]
                          ,[harvest]
                          ,[weight]
                          ,[nomnl]
                          ,[nojob]
                          ,[scope]
                          ,[id_hvsprod]
                          ,[labnum]
                      FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum]='" & tlabnum.Text & "'"
            cmd = New SqlClient.SqlCommand(sql, con) With {
                .CommandType = CommandType.Text,
                .CommandText = sql
            }
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                Lreqnum.Text = dread.Item("id")
                Lvariety.Text = dread.Item("variety")
                Lfarmer.Text = dread.Item("farmer")
                LLocation.Text = dread.Item("location")
                Dim tglhvs As Date = dread.Item("harvest")
                Lharvest.Text = tglhvs.ToString(LabelDate.Text)
                LManual.Text = dread.Item("nomnl")
                Ljob.Text = dread.Item("nojob")
                LQtt.Text = dread.Item("weight")
                LScope.Text = dread.Item("scope")

                LProductionCode.Text = dread.Item("id_hvsprod")

                tsam.Checked = Convert.ToBoolean(_DataToValue("Select [test_sampling] from [HCQC_server].[dbo].[spl_request] WHERE [id]=" & Lreqnum.Text & ""))
                tmoi.Checked = Convert.ToBoolean(_DataToValue("Select [test_moi] from [HCQC_server].[dbo].[spl_request] WHERE [id]=" & Lreqnum.Text & ""))
                tpur.Checked = Convert.ToBoolean(_DataToValue("Select [test_pur] from [HCQC_server].[dbo].[spl_request] WHERE [id]=" & Lreqnum.Text & ""))
                traf.Checked = Convert.ToBoolean(_DataToValue("Select [test_raf] from [HCQC_server].[dbo].[spl_request] WHERE [id]=" & Lreqnum.Text & ""))
                tger.Checked = Convert.ToBoolean(_DataToValue("Select [test_ger] from [HCQC_server].[dbo].[spl_request] WHERE [id]=" & Lreqnum.Text & ""))
                tvia.Checked = Convert.ToBoolean(_DataToValue("Select [test_via] from [HCQC_server].[dbo].[spl_request] WHERE [id]=" & Lreqnum.Text & ""))
                Lremark.Text = _DataToValue("Select [remark] from [HCQC_server].[dbo].[spl_request] WHERE [id]=" & Lreqnum.Text & "")
                If _isBOF("receipt", "labnum", tlabnum.Text) = True Then

                    ''load if data have been receipt
                    Dim tglmsk As Date = _DataToValueDate("SELECT [datein] FROM receipt WHERE id_request='" & Lreqnum.Text & "'")
                    tdatereceive.Text = tglmsk.ToString(LabelDate.Text)

                    tsamqtt.Text = _DataToValue("SELECT [brt_in] FROM receipt WHERE id_request='" & Lreqnum.Text & "'")
                    Dim tglsampling As Date = _DataToValue("SELECT [sampling] FROM receipt WHERE id_request='" & Lreqnum.Text & "'")
                    tsampling.Text = tglsampling.ToString(LabelDate.Text)
                    tsampler.Text = _DataToValue("SELECT [sampler] FROM receipt WHERE id_request='" & Lreqnum.Text & "'")

                    tpack.Text = _DataToValue("SELECT [pack] FROM receipt WHERE id_request='" & Lreqnum.Text & "'")
                    tseed.Text = _DataToValue("SELECT [seeds] FROM receipt WHERE id_request='" & Lreqnum.Text & "'")
                    tlabel.Text = _DataToValue("SELECT [label] FROM receipt WHERE id_request='" & Lreqnum.Text & "'")
                    tremark.Text = _DataToValue("SELECT [remark] FROM receipt WHERE id_request='" & Lreqnum.Text & "'")

                    BtnSave2.Text = "Update"
                    BtnDel.Enabled = True

                Else
                    BtnSave2.Text = "Save"
                    BtnDel.Enabled = False
                    tlabnum.Focus()
                End If
                tlabnum.SelectAll()
            Else
                'jika data lab number tidak di temukan
                MetroMessageBox.Show(Me, "Lab Number belum terdaftar di QC Confirm", Me.Text, MessageBoxButtons.OK, 211)
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Error : " & ex.Message, Me.Text, MessageBoxButtons.OK, 211)
            Return
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BtnSave2_Click(sender As Object, e As EventArgs) Handles BtnSave2.Click
        If String.IsNullOrEmpty(tdatereceive.Text) Then
            MetroMessageBox.Show(Me, "Receivet Date harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        ElseIf String.IsNullOrEmpty(tlabnum.Text) Or Lreqnum.Text = "..." Then
            MetroMessageBox.Show(Me, "Lab Number harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tlabnum.WithError = True
            Return
        ElseIf String.IsNullOrEmpty(tsamqtt.Text) Then
            MetroMessageBox.Show(Me, "Sample Quantity (g) harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tsamqtt.WithError = True
        ElseIf String.IsNullOrEmpty(tsampling.Text) Then
            MetroMessageBox.Show(Me, "Sampling date harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)

        ElseIf String.IsNullOrEmpty(tsampler.Text) Then
            MetroMessageBox.Show(Me, "Sampler harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tsampler.WithError = True
        ElseIf String.IsNullOrEmpty(tpack.Text) Then
            MetroMessageBox.Show(Me, "Sample Pack harus disi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tpack.WithError = True
        ElseIf String.IsNullOrEmpty(tseed.Text) Then
            MetroMessageBox.Show(Me, "Sampler Seed harus disi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tseed.WithError = True
        ElseIf String.IsNullOrEmpty(tlabel.Text) Then
            MetroMessageBox.Show(Me, "Sampler Label harus disi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tlabel.WithError = True
        Else
            If BtnSave2.Text = "Save" Then
                Dim tglrecipt As Date
                tglrecipt = Date.ParseExact(tdatereceive.Text, formatDate, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None)
                Dim tglsampling As Date
                tglsampling = Date.ParseExact(tsampling.Text, formatDate, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None)
                Try
                    'Perulangan tidak diterapkan pada GRAVITY
                    'Proses Insert Rerecord Database
                    _RunSQL("INSERT INTO [dbo].[receipt]
                           ([id_request]
                           ,[id_login]
                           ,[labnum]
                           ,[datein]
                           ,[brt_in]
                           ,[sampling]
                           ,[sampler]
                           ,[pack]
                           ,[seeds]
                           ,[label]
                           ,[remark]
                           ,[input_by]
                           ,[input_at] )
                     VALUES
                           ('" & Lreqnum.Text & "'
                           ,'" & login.Luserid.Text & "'
                           ,'" & tlabnum.Text & "'
                           ,'" & tglrecipt.ToString("yyyy-MM-dd") & "'
                           ," & Val(tsamqtt.Text) & "
                           ,'" & tglsampling.ToString("yyyy-MM-dd") & "'
                           ,'" & tsampler.Text & "'
                           ,'" & tpack.Text & "'
                           ,'" & tseed.Text & "'
                           ,'" & tlabel.Text & "'
                           ,'" & tremark.Text & "'
                           ,'" & GetIPAddress() & "'
                           ,GETDATE() )")

                    _RunSQL_nomsgbox("UPDATE [dbo].[spl_request]
                        SET [test_sampling] = '" & tsam.CheckState & "'
                        ,[test_moi] = '" & tmoi.CheckState & "'
                        ,[test_pur] = '" & tpur.CheckState & "'
                        ,[test_ger] = '" & tger.CheckState & "'
                        ,[test_via] = '" & tvia.CheckState & "'
                        ,[test_raf] = '" & traf.CheckState & "'
                        ,[test_ontest]='" & tontest.CheckState & "' WHERE id='" & Lreqnum.Text & "'")

                    TermalPrintLA2(sender, e)
                    ClearText()
                Catch ex As Exception
                    MetroMessageBox.Show(Me, "Error : " & ex.Message, Me.Text, MessageBoxButtons.OK, 211)
                    Return
                End Try
            ElseIf BtnSave2.Text = "Update" Then
                BtnUpdate_Click(sender, e)
            End If
        End If

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs)
        If String.IsNullOrEmpty(tdatereceive.Text) Then
            MetroMessageBox.Show(Me, "Receivet Date harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        ElseIf String.IsNullOrEmpty(tlabnum.Text) Then
            MetroMessageBox.Show(Me, "Lab Number harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tlabnum.WithError = True
        ElseIf String.IsNullOrEmpty(tsamqtt.Text) Then
            MetroMessageBox.Show(Me, "Sample Quantity (g) harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tsamqtt.WithError = True
        ElseIf String.IsNullOrEmpty(tsampling.Text) Then
            MetroMessageBox.Show(Me, "Sampling date harus ada", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
        ElseIf String.IsNullOrEmpty(tsampler.Text) Then
            MetroMessageBox.Show(Me, "Sampler harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tsampler.WithError = True
        ElseIf String.IsNullOrEmpty(tpack.Text) Then
            MetroMessageBox.Show(Me, "Sample Pack harus disi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tpack.WithError = True
        ElseIf String.IsNullOrEmpty(tseed.Text) Then
            MetroMessageBox.Show(Me, "Sampler Seed harus disi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tseed.WithError = True
        ElseIf String.IsNullOrEmpty(tlabel.Text) Then
            MetroMessageBox.Show(Me, "Sampler Label harus disi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tlabel.WithError = True
        Else
            Dim tglrecipt As Date
            tglrecipt = Date.ParseExact(tdatereceive.Text, formatDate, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None)
            Dim tglsampling As Date
            tglsampling = Date.ParseExact(tsampling.Text, formatDate, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None)
            _RunSQL("UPDATE [dbo].[receipt]
                    SET [id_request] = '" & Lreqnum.Text & "'
                        ,[id_login] = '" & login.Luserid.Text & "'
                        ,[labnum] = '" & tlabnum.Text & "'
                        ,[datein] = '" & tglrecipt.ToString("yyyy-MM-dd") & "'
                        ,[brt_in] = '" & Val(tsamqtt.Text) & "'
                        ,[sampling]= '" & tglsampling.ToString("yyyy-MM-dd") & "'
                        ,[sampler] = '" & tsampler.Text & "'
                        ,[pack] = '" & tpack.Text & "'
                        ,[seeds] = '" & tseed.Text & "'
                        ,[label] = '" & tlabel.Text & "'
                        ,[remark] = '" & tremark.Text & "'      
                        ,[update_by] = '" & GetIPAddress() & "'
                        ,[update_at] = GETDATE() 
                  WHERE [labnum] = '" & tlabnum.Text & "'  ")

            _RunSQL_nomsgbox("UPDATE [dbo].[spl_request]
                        SET [test_sampling] = '" & tsam.CheckState & "'
                        ,[test_moi] = '" & tmoi.CheckState & "'
                        ,[test_pur] = '" & tpur.CheckState & "'
                        ,[test_ger] = '" & tger.CheckState & "'
                        ,[test_via] = '" & tvia.CheckState & "'
                        ,[test_raf] = '" & traf.CheckState & "'
                        ,[test_ontest]='" & tontest.CheckState & "' WHERE id='" & Lreqnum.Text & "'")

            If strupdate = 1 Then
                BtnSave2.Text = "Save"
                BtnDel.Enabled = False
                ClearText()
            End If
        End If
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk menghapus data ini " + tlabnum.Text, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
        If result = DialogResult.Yes Then
            _RunSQL("DELETE [dbo].[receipt] WHERE [id_request]='" & Lreqnum.Text & "'")
            BtnSave2.Text = "Save"
            BtnDel.Enabled = False
            Me.tlabnum.Focus()
        End If
    End Sub

    Private Sub Sample_Receipt_Load(sender As Object, e As EventArgs) Handles Me.Load

        DropDownOption()
        UpdateDropDownButton(btnThisMonth)
        Labeldate2.Text = LabelDate.Text
        tdatereceive.Text = tglnow.ToString(LabelDate.Text)
        tsampling.Text = tglnow.ToString(LabelDate.Text)
        BtnDel.Enabled = False

        Dim DgvFilter As New DgvFilterManager
        DgvFilter.DataGridView = MetroGrid1
        MetroGrid1.ColumnHeadersHeight = 25
    End Sub

    Private Sub tsamqtt_KeyDown(sender As Object, e As KeyEventArgs) Handles tsamqtt.KeyDown
        tsamqtt.WithError = False
    End Sub

    Private Sub tsampler_KeyDown(sender As Object, e As KeyEventArgs) Handles tsampler.KeyDown
        tsampler.WithError = False
    End Sub

    Private Sub tpack_KeyDown(sender As Object, e As KeyEventArgs) Handles tpack.KeyDown
        tpack.WithError = False
    End Sub

    Private Sub tseed_KeyDown(sender As Object, e As KeyEventArgs) Handles tseed.KeyDown
        tseed.WithError = False
    End Sub

    Private Sub tlabel_KeyDown(sender As Object, e As KeyEventArgs) Handles tlabel.KeyDown
        tlabel.WithError = False
    End Sub

    Private Sub tlabnum_KeyDown(sender As Object, e As KeyEventArgs) Handles tlabnum.KeyDown
        tlabnum.WithError = False
        If e.KeyCode = Keys.Enter Then
            BtnCariLab_Click(sender, e)
        End If
    End Sub

    Public Sub ClearText()
        tlabnum.Text = ""
        tdatereceive.Text = Today.ToString(LabelDate.Text)
        tsamqtt.Text = ""
        tsampling.Text = Today.ToString(LabelDate.Text)
        'tsampler.Text = ""
        'tpack.Text = ""
        'tseed.Text = ""
        'tlabel.Text = ""
        tremark.Text = ""

        Lreqnum.Text = "..."
        Lvariety.Text = "..."
        Lfarmer.Text = "..."
        LLocation.Text = "..."
        Lharvest.Text = "..."
        LManual.Text = "..."
        Ljob.Text = "..."
        LQtt.Text = "..."
        LScope.Text = "..."
        LProductionCode.Text = "..."
        Lremark.Text = "..."
        tsam.Checked = False
        tmoi.Checked = False
        tpur.Checked = False
        traf.Checked = False
        tger.Checked = False
        tvia.Checked = False
        tontest.Checked = False
        tlabnum.Focus()
    End Sub

    Private Sub MetroTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControl1.SelectedIndexChanged
        If MetroTabControl1.SelectedTab Is MetroTabPage2 Then
            ReceiptListTableAdapter.FillByThisMonth(HCQC_NewDataset.ReceiptList)
        End If
    End Sub

    Private Sub tdatereceive_GotFocus(sender As Object, e As EventArgs) Handles tdatereceive.GotFocus
        tdatereceive.SelectAll()
    End Sub

    Private Sub tsamqtt_GotFocus(sender As Object, e As EventArgs) Handles tsamqtt.GotFocus
        tsamqtt.SelectAll()
    End Sub

    Private Sub tsampling_GotFocus(sender As Object, e As EventArgs) Handles tsampling.GotFocus
        tsampling.SelectAll()
    End Sub

    Private Sub tsampler_GotFocus(sender As Object, e As EventArgs) Handles tsampler.GotFocus
        tsampler.SelectAll()
    End Sub

    Private Sub tpack_GotFocus(sender As Object, e As EventArgs) Handles tpack.GotFocus
        tpack.SelectAll()
    End Sub

    Private Sub tseed_GotFocus(sender As Object, e As EventArgs) Handles tseed.GotFocus
        tseed.SelectAll()
    End Sub

    Private Sub tlabel_GotFocus(sender As Object, e As EventArgs) Handles tlabel.GotFocus
        tlabel.SelectAll()
    End Sub

    Private Sub tremark_GotFocus(sender As Object, e As EventArgs) Handles tremark.GotFocus, tcopy.GotFocus
        tremark.SelectAll()
    End Sub

    Private Sub MetroTabPage1_Click(sender As Object, e As EventArgs) Handles MetroTabPage1.Click

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Sample_Receipt_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp

    End Sub


    Private Sub LabelPrinter_MouseEnter(sender As Object, e As EventArgs) Handles LabelPrinter.MouseEnter
        LabelPrinter.BackColor = Color.FromArgb(70, 179, 226)
    End Sub

    Private Sub LabelPrinter_MouseLeave(sender As Object, e As EventArgs) Handles LabelPrinter.MouseLeave
        LabelPrinter.BackColor = Color.Transparent
    End Sub
End Class