Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Reflection
Imports DgvFilterPopup

Public Class Request_Sampling_From
    Public Event UC_Button1Click()
    Public cek As Boolean = False
    Public vid As Integer

    Public Shared Sub SetDoubleBuffered(ByVal control As Control)
        GetType(Control).InvokeMember("DoubleBuffered", BindingFlags.SetProperty Or BindingFlags.Instance Or BindingFlags.NonPublic, Nothing, control, New Object() {True})
    End Sub

    Public Sub OnRefreshEventHendler()
        Spl_request1TableAdapter.Fill(HCQC_NewDataset.Spl_request1)
    End Sub


    Private Sub Request_Sampling_From_Load(sender As Object, e As EventArgs) Handles Me.Load
        'LinkThisMonth_Click(sender, e)

        'filter Control Header Gridview1
        Dim DgvFilter As New DgvFilterManager
        DgvFilter.DataGridView = MetroGrid1
        MetroGrid1.ColumnHeadersHeight = 25

        'Show Format Date Time Seting on Personal Computer
        LabelDate.Text = "dd-MM-yyyy"
        tgl_hvs.Text = Today.ToString(LabelDate.Text)
        tid_hvsprod.Select()
        SetDoubleBuffered(MetroTabControl1)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ''filter wajib di isi
        If tvariety.Text = "" Then
            MetroMessageBox.Show(Me, "Variety harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tvariety.WithError = True
        ElseIf tgl_hvs.MaskCompleted = False Then
            MetroMessageBox.Show(Me, "Harvest Date harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        ElseIf String.IsNullOrEmpty(tlotqtt.Text) Then
            MetroMessageBox.Show(Me, "Weight (kg) harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        ElseIf String.IsNullOrEmpty(tscope.Text) Then
            MetroMessageBox.Show(Me, "Pilih Lot Scope (Raw Material/ Gravity/ Periodc/ etc)!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        Else
            Dim tglharvest As Date
            tglharvest = Date.ParseExact(tgl_hvs.Text, formatDate, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None)
            Try
                If BtnSave.Text = "Save" Then
                    'Proses Insert record ke database
                    _RunSQL(
                        "INSERT INTO [dbo].[spl_request]
                       ([id_login]   
                       ,[id_hvsprod]
                       ,[variety]
                       ,[farmer]
                       ,[location]
                       ,[harvest]
                       ,[nomnl]
                       ,[nojob]
                       ,[weight]
                       ,[scope]
                       ,[bag]
                       ,[test_sampling]
                       ,[test_moi]
                       ,[test_pur]
                       ,[test_ger]
                       ,[test_via]
                       ,[test_raf]
                       ,[remark]                       
                       ,[input_by]
                       ,[input_date])
                 VALUES
                       ('" & login.Luserid.Text & "'   
                       ,'" & tid_hvsprod.Text.Trim & "'
                       ,'" & tvariety.Text.ToUpper & "'
                       ,'" & tfarmer.Text.ToUpper & "'
                       ,'" & tlocation.Text.ToUpper & "'
                       ,'" & tglharvest.ToString("yyyy-MM-dd") & "'
                       ,'" & tnoman.Text & "'
                       ,'" & tlotref.Text & "'
                       ," & Math.Round(CDbl(tlotqtt.Text), 2) & "
                       ,'" & tscope.Text & "'
                       ," & CInt(tbag.Text) & "
                       ,'" & tsampling.CheckState & "'
                       ,'" & tmoi.CheckState & "'
                       ,'" & tpur.CheckState & "'
                       ,'" & tger.CheckState & "'
                       ,'" & tvia.CheckState & "'
                       ,'" & traf.CheckState & "'
                       ,'" & tremark.Text & "'
                       ,'" & GetIPAddress() & "'
                       ,GETDATE() )"
                    )
                ElseIf BtnSave.Text = "Update" Then
                    _RunSQL(" UPDATE [dbo].[spl_request]
                                SET [id_login] = '" & login.Luserid.Text & "'
                                    ,[id_hvsprod] = '" & tid_hvsprod.Text.Trim & "'
                                    ,[variety] = '" & tvariety.Text.ToUpper & "'
                                    ,[farmer] = '" & tfarmer.Text.ToUpper & "'
                                    ,[location] = '" & tlocation.Text.ToUpper & "'
                                    ,[harvest] = '" & tglharvest.ToString("yyyy-MM-dd") & "'
                                    ,[nomnl] = '" & tnoman.Text & "'
                                    ,[nojob] = '" & tlotref.Text & "'
                                    ,[weight] = " & Math.Round(CDbl(tlotqtt.Text), 2) & "
                                    ,[scope] = '" & tscope.Text & "'
                                    ,[bag]=" & CInt(tbag.Text) & "
                                    ,[test_sampling] = '" & tsampling.CheckState & "'
                                    ,[test_moi] ='" & tmoi.CheckState & "'
                                    ,[test_pur] = '" & tpur.CheckState & "'
                                    ,[test_ger] = '" & tger.CheckState & "'
                                    ,[test_via] = '" & tvia.CheckState & "'
                                    ,[test_raf] = '" & traf.CheckState & "'
                                    ,[remark] = '" & tremark.Text & "'
                                    ,[update_user] = '" & login.Luserid.Text & "'
                                    ,[update_by] = '" & GetIPAddress() & "'
                                    ,[update_date] = GETDATE()
                                WHERE [id]=" & vid & "
                            ")
                End If
                'LinkThisMonth_Click(sender, e)
                LinkClear_Click(sender, e)

                'notification neet to verification
                'MainForm.LabelNotifVerivicaion.Text = VerificationCount(MainForm.PanelNotifVerification)
                'MainForm.Containermenu2.LabelNotifContainerTracing.Text = VerificationCount(MainForm.Containermenu2.Panel2)
            Catch ex As Exception
                MetroMessageBox.Show(Me, "Error : " & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, 211)
                Return
            Finally
                con.Close()
                tid_hvsprod.Focus()
            End Try
        End If
    End Sub

    'Control untuk mengedit conten/value pada gridview
    Private Sub MetroGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick
        Dim i As Integer
        'Dim tgl As Date

        If e.RowIndex = -1 OrElse MetroGrid1.Columns(e.ColumnIndex).Name <> "ColmEdit" Then Return

        With MetroGrid1
            i = .CurrentRow.Index
            vid = .Rows(i).Cells("IdColumn").Value
            If MetroGrid1.Columns(e.ColumnIndex).Name = "ColmEdit" Then

                Dim strlogin As Integer = _DataToValue("Select [id_login] from [HCQC_server].[dbo].[spl_request] WHERE [id]=" & vid & "")
                If strlogin = login.Luserid.Text Then
                    tid_hvsprod.Text = .Rows(i).Cells("IdhvsprodColumn").Value.ToString
                    tvariety.Text = .Rows(i).Cells("varietyColumn").Value.ToString
                    tfarmer.Text = .Rows(i).Cells("farmerColumn").Value.ToString
                    tlocation.Text = .Rows(i).Cells("LocationColumn").Value.ToString
                    tcrop.Text = _DataToValue("select crop FROM dbo.category_crop RIGHT OUTER JOIN
                         dbo.spl_request ON dbo.category_crop.prodcode = dbo.spl_request.variety 
						 where variety='" & tvariety.Text & "'")
                    tgl_hvs.Text = _DataToValueDate("Select [harvest] from [HCQC_server].[dbo].[spl_request] WHERE [id]=" & vid & "").ToString(LabelDate.Text)
                    tnoman.Text = .Rows(i).Cells("NomnlColumn").Value.ToString
                    tlotref.Text = .Rows(i).Cells("NojobColumn").Value.ToString
                    tlotqtt.Text = .Rows(i).Cells("WeightColumn").Value.ToString
                    tscope.Text = .Rows(i).Cells("ScopeColumn").Value.ToString
                    tbag.Text = _DataToValue("Select [bag] from [HCQC_server].[dbo].[spl_request] WHERE [id]=" & vid & "")

                    tsampling.Checked = Convert.ToBoolean(_DataToValue("Select [test_sampling] from [HCQC_server].[dbo].[spl_request] WHERE [id]=" & vid & ""))
                    tmoi.Checked = Convert.ToBoolean(_DataToValue("Select [test_moi] from [HCQC_server].[dbo].[spl_request] WHERE [id]=" & vid & ""))
                    tpur.Checked = Convert.ToBoolean(_DataToValue("Select [test_pur] from [HCQC_server].[dbo].[spl_request] WHERE [id]=" & vid & ""))
                    traf.Checked = Convert.ToBoolean(_DataToValue("Select [test_raf] from [HCQC_server].[dbo].[spl_request] WHERE [id]=" & vid & ""))
                    tger.Checked = Convert.ToBoolean(_DataToValue("Select [test_ger] from [HCQC_server].[dbo].[spl_request] WHERE [id]=" & vid & ""))
                    tvia.Checked = Convert.ToBoolean(_DataToValue("Select [test_via] from [HCQC_server].[dbo].[spl_request] WHERE [id]=" & vid & ""))
                    tremark.Text = _DataToValue("Select [remark] from [HCQC_server].[dbo].[spl_request] WHERE [id]=" & vid & "")
                    BtnSave.Text = "Update"
                Else
                    MetroMessageBox.Show(Me, "Can only be edited the user request by " & _DataToValue("Select [nama_req] from [qc_confirm_view] Where [id]=" & vid & ""))
                End If

            End If
        End With

    End Sub

    'Control untuk Buton Delete pada gridview1
    Private Sub MetroGrid1_DelCellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick
        If e.RowIndex = -1 OrElse MetroGrid1.Columns(e.ColumnIndex).Name <> "ColmDelete" Then Return

        If MetroGrid1.Columns(e.ColumnIndex).Name = "ColmDelete" Then
            With MetroGrid1
                Dim i As Integer = .CurrentRow.Index
                vid = .Rows(i).Cells("IdColumn").Value
            End With
            Dim idinput As Integer = _DataToValue("Select [id_login] from [HCQC_server].[dbo].[spl_request] WHERE [id]=" & vid & "")
            Dim idlevel As Integer = _DataToValue("Select [userlevel] from [HCQC_server].[dbo].[login] WHERE [id]=" & login.Luserid.Text & "")
            'cek apakah user login adalah yang input request tersebut
            'atau userlevel dengan level (4,1,5,9)
            Dim arraystr() As String = {4, 1, 5, 9}
            Dim singlestr As String = idlevel

            If login.Luserid.Text = idinput Or arraystr.Contains(singlestr) Then
                With MetroGrid1
                    Dim i As Integer = .CurrentRow.Index
                    ' mendapatkan Nomor Request
                    Dim Vid_req As String = .Rows(i).Cells("IdColumn").Value
                    'Mencari Nomor Request jika sudah masuk dalam daftar QC Confirmation/Verivication
                    If _isBOF("qc_confirm", "id_request", Vid_req) = True Then
                        'Jika ada maka harus di hapus/Delete verificationnya
                        MetroMessageBox.Show(Me, "Sample request ini sudah di Verivikasi oleh HCQC. Mohon hubungi bagian Staff Verifikasi Semple untuk melakukan Cancel Verivication. Terimakasih...")
                        Return
                    End If
                End With

                Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk menghapus data ini", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
                If result = DialogResult.Yes Then
                    With MetroGrid1
                        openDB()
                        Using cmd As New SqlCommand("sp_SplRequestDel", con)
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Parameters.AddWithValue("@id_request", .Rows(e.RowIndex).Cells("IdColumn").Value)
                            cmd.ExecuteScalar()
                            con.Close()
                        End Using
                        'refresh Gridview
                        LinkThisMonth_Click(sender, e)
                    End With
                Else
                    Return
                End If
            Else
                MetroMessageBox.Show(Me, "Can only be edited/delete the user request by " & _DataToValue("Select [nama_req] from [qc_confirm_view] Where [id]=" & vid) & " Or HCQC Staff ")
            End If

        End If
    End Sub

    Private Sub MetroTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControl1.SelectedIndexChanged
        'or suppose *finance tab* index is 0 
        If MetroTabControl1.SelectedTab Is MetroTabPage3 Then

        End If
    End Sub

    'Private Sub LinkAll_Click(sender As Object, e As EventArgs) Handles LinkAll.Click
    '    SearchCustomers(LinkAll.Text)
    'End Sub

    'Private Sub LinkThisMonth_Click(sender As Object, e As EventArgs) Handles LinkThisMonth.Click
    '    SearchCustomers(LinkThisMonth.Text)
    'End Sub

    'Private Sub Link2MonthAgo_Click(sender As Object, e As EventArgs) Handles Link2MonthAgo.Click
    '    SearchCustomers(Link2MonthAgo.Text)
    'End Sub


    Private Sub LinkClear_Click(sender As Object, e As EventArgs) Handles LinkClearRequest.Click
        BtnSave.Text = "Save"

        tid_hvsprod.Text = ""
        tvariety.Text = ""
        tfarmer.Text = ""
        tlocation.Text = ""
        tnoman.Text = ""
        tlotref.Text = ""
        tlotqtt.Text = ""
        tscope.Text = ""
        tbag.Text = ""
        tgl_hvs.Text = Today.ToString(LabelDate.Text)
        tsampling.CheckState = CheckState.Unchecked
        tmoi.CheckState = CheckState.Unchecked
        tpur.CheckState = CheckState.Unchecked
        tger.CheckState = CheckState.Unchecked
        tvia.CheckState = CheckState.Unchecked
        traf.CheckState = CheckState.Unchecked
        tremark.Text = ""
        tcrop.Text = ""
        tid_hvsprod.Focus()

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        MetroMessageBox.Show(Me, "Tombol pada Kolom input Variety ini akan melakukan filter pencarian sesuai input-an", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
    End Sub

    Private Sub tid_hvsprod_KeyDown(sender As Object, e As KeyEventArgs) Handles tid_hvsprod.KeyDown
        If e.KeyCode = Keys.Enter Then
            If _isBOF("[harvestprod]", "[idcode]", tid_hvsprod.Text) = True Then
                tvariety.Text = _DataToValue("SELECT [variety] From [HCQC_server].[dbo].[harvestprod] WHERE [idcode]=" & tid_hvsprod.Text & "")
                tfarmer.Text = _DataToValue("SELECT [cgrname] From [HCQC_server].[dbo].[harvestprod] WHERE [idcode]=" & tid_hvsprod.Text & "")
                tlocation.Text = _DataToValue("SELECT [dusun] From [HCQC_server].[dbo].[harvestprod] WHERE [idcode]=" & tid_hvsprod.Text & "")
                tgl_hvs.Text = _DataToValueDate("SELECT [harvest] From [HCQC_server].[dbo].[harvestprod] WHERE [idcode]=" & tid_hvsprod.Text & "").ToString(LabelDate.Text)
                tlotref.Text = _DataToValue("SELECT case when [joblot] IS NULL then '' else [joblot] end as [joblot] from [HCQC_server].[dbo].[harvestprod] WHERE [idcode]=" & tid_hvsprod.Text & "")
                'tnoman.Text = _DataToValue("SELECT max[nomnl] as maxman FROM [spl_request] WHERE [id_hvsprod]='" & tid_hvsprod.Text & "'")
                tid_hvsprod.SelectAll()
            Else
                MetroMessageBox.Show(Me, "Data Production Planing not found")
            End If
        End If
    End Sub

    Private Sub tgl_hvs_TypeValidationCompleted(sender As Object, e As TypeValidationEventArgs) Handles tgl_hvs.TypeValidationCompleted
        If (Not e.IsValidInput) Then
            Me.MetroToolTip1.ToolTipTitle = "Invalid Date"
            Me.MetroToolTip1.Show("   The data you supplied must be a valid date in the format " + LabelDate.Text + "   ", Me.tgl_hvs, -5, -30, 4000)
            'e.Cancel = True
        End If
    End Sub

    Private Sub tgl_hvs_KeyDown(sender As Object, e As KeyEventArgs) Handles tgl_hvs.KeyDown
        Me.MetroToolTip1.Hide(Me.tgl_hvs)
    End Sub

    Private Sub tvariety_KeyDown(sender As Object, e As KeyEventArgs) Handles tvariety.KeyDown
        Me.MetroToolTip1.Hide(Me.tgl_hvs)
        If e.KeyCode = Keys.Enter Then
            tvariety_ButtonClick(sender, e)
            tgl_hvs.Focus()
        End If
    End Sub

    Private Sub LinkSelectallRequest_Click(sender As Object, e As EventArgs) Handles LinkSelectallRequest.Click
        tsampling.CheckState = CheckState.Checked
        tmoi.CheckState = CheckState.Checked
        tpur.CheckState = CheckState.Checked
        tger.CheckState = CheckState.Checked
        tvia.CheckState = CheckState.Checked
        traf.CheckState = CheckState.Checked
    End Sub

    Private Sub tbag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbag.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Size_change(sender As Object, e As EventArgs) Handles MetroPanel1.SizeChanged
        MetroPanel1.MaximumSize = New Size(Screen.PrimaryScreen.Bounds.Height - 12, 310)

        MetroLabel2.Location = New Point(MetroLabel2.Location.X, MetroPanel1.Location.Y + MetroPanel1.Size.Height + 25)

        MetroGrid1.Location = New Point(MetroLabel2.Location.X, MetroPanel1.Location.Y + MetroPanel1.Size.Height + 56)
        MetroGrid1.Size = New Size(MetroTabPage1.Size.Width - 15, MetroTabPage1.Size.Height - MetroLabel2.Location.Y - 15)

        LinkThisMonth.Location = New Point(MetroLabel2.Location.X + 66 + 6, MetroLabel2.Location.Y)
        Link2MonthAgo.Location = New Point(LinkThisMonth.Location.X + 70, MetroLabel2.Location.Y)
        LinkAll.Location = New Point(Link2MonthAgo.Location.X + 77, MetroLabel2.Location.Y)
        Tsearch.Location = New Point(LinkAll.Location.X + 32 + 36, MetroLabel2.Location.Y)
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Multy_Request_Sample.ShowDialog(Me)
    End Sub

    Private Sub OnOptionsSave(ByVal strData As String)
        'Or whatever you want to do on frmMain with Options Data.
        tid_hvsprod.Text = strData

    End Sub

    Private Sub LinkFind_Click(sender As Object, e As EventArgs) Handles LinkFind.Click
        Dim ListProduction = New List_of_Production_Number
        AddHandler ListProduction.SaveProductionNo, AddressOf OnOptionsSave
        ListProduction.ShowDialog(Me)
    End Sub

    'Private Sub Tsearch_KeyUp(sender As Object, e As KeyEventArgs)
    '    MetroGrid1.DataSource = Me.PopulateDataGridView()
    'End Sub

    Private Sub tvariety_TextChanged(sender As Object, e As EventArgs) Handles tvariety.TextChanged
        If String.IsNullOrEmpty(tvariety.Text) Then
            tcrop.Text = ""
        Else
            tcrop.Text = _DataToValue("select crop FROM dbo.category_crop where dbo.category_crop.prodcode ='" & tvariety.Text & "'")
        End If
    End Sub

    Private Sub Link2MonthAgo_Click(sender As Object, e As EventArgs) Handles Link2MonthAgo.Click
        Qc_confirm_viewerTableAdapter.FillByLastMonth(HCQC_NewDataset.qc_confirm_viewer)
        MetroGrid1.Refresh()
        Tsearch.Tag = "2month_ago"
    End Sub

    Private Sub LinkThisMonth_Click(sender As Object, e As EventArgs) Handles LinkThisMonth.Click
        'Dim sql As String
        'sql = "SELECT qc_confirm_view.* FROM qc_confirm_view WHERE ([input_date] >= DATEADD(dd, 1, EOMONTH(GETDATE(), - 1))) AND ([input_date] < DATEADD(dd, 1, EOMONTH(GETDATE()))) Order by id desc"
        'Dim da As New SqlDataAdapter(sql, con)
        Qc_confirm_viewerTableAdapter.FillByThisMonth(HCQC_NewDataset.qc_confirm_viewer)
        MetroGrid1.Refresh()
        Tsearch.Tag = "this_month"
    End Sub

    Private Sub LinkAll_Click(sender As Object, e As EventArgs) Handles LinkAll.Click
        Qc_confirm_viewerTableAdapter.Fill(HCQC_NewDataset.qc_confirm_viewer)
        MetroGrid1.Refresh()
        Tsearch.Tag = "all"
    End Sub

    Private Sub tvariety_ButtonClick(sender As Object, e As EventArgs) Handles tvariety.ButtonClick
        If String.IsNullOrEmpty(tvariety.Text) Then
            Return
        Else
            Qc_confirm_viewerTableAdapter.FillByVariety(HCQC_NewDataset.qc_confirm_viewer, "%" + tvariety.Text + "%")
        End If
    End Sub

    Private Sub tscope_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscope.SelectedIndexChanged
        If tscope.SelectedIndex = 0 Then
            tsampling.CheckState = CheckState.Checked
            tmoi.CheckState = CheckState.Checked
            tpur.CheckState = CheckState.Checked
            traf.CheckState = CheckState.Checked
            tger.CheckState = CheckState.Checked
            tvia.CheckState = CheckState.Checked
        End If

        If tscope.SelectedIndex = 1 Then
            tsampling.CheckState = CheckState.Checked
            tmoi.CheckState = CheckState.Checked
            tpur.CheckState = CheckState.Checked
            traf.CheckState = CheckState.Checked
            tger.CheckState = CheckState.Unchecked
            tvia.CheckState = CheckState.Unchecked
        End If

        If tscope.SelectedIndex = 2 Then
            tsampling.CheckState = CheckState.Unchecked
            tmoi.CheckState = CheckState.Unchecked
            tpur.CheckState = CheckState.Unchecked
            traf.CheckState = CheckState.Unchecked
            tger.CheckState = CheckState.Checked
            tvia.CheckState = CheckState.Unchecked
        End If

        If tscope.SelectedIndex = 3 Then
            tsampling.CheckState = CheckState.Checked
            tmoi.CheckState = CheckState.Unchecked
            tpur.CheckState = CheckState.Unchecked
            traf.CheckState = CheckState.Unchecked
            tger.CheckState = CheckState.Checked
            tvia.CheckState = CheckState.Unchecked
        End If

        If tscope.SelectedIndex = 4 Then
            tsampling.CheckState = CheckState.Unchecked
            tmoi.CheckState = CheckState.Unchecked
            tpur.CheckState = CheckState.Unchecked
            traf.CheckState = CheckState.Unchecked
            tger.CheckState = CheckState.Checked
            tvia.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub LinkLoad_Click(sender As Object, e As EventArgs) Handles LinkLoad.Click
        OnRefreshEventHendler()
        LinkLoad.Text = "Refresh"
    End Sub

    Private Sub Tsearch_ButtonClick(sender As Object, e As EventArgs) Handles Tsearch.ButtonClick
        If String.IsNullOrEmpty(Tsearch.Text) Then
            LinkThisMonth_Click(sender, e)
        Else
            Qc_confirm_viewerTableAdapter.FillByStrVariable(HCQC_NewDataset.qc_confirm_viewer, "%" + Tsearch.Text + "%")
        End If

    End Sub

    Private Sub Tsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles Tsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Tsearch_ButtonClick(sender, e)
        End If
    End Sub
End Class
