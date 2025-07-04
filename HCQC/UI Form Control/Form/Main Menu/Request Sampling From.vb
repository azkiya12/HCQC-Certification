﻿Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Reflection
Imports DgvFilterPopup

Public Class Request_Sampling_From
    Public Event UC_Button1Click()
    Public cek As Boolean = False
    Public vid As Integer

    ' Variabel global untuk menampung inspection lot WIP
    Public inspLot As String

    Public Shared Sub SetDoubleBuffered(ByVal control As Control)
        GetType(Control).InvokeMember("DoubleBuffered", BindingFlags.SetProperty Or BindingFlags.Instance Or BindingFlags.NonPublic, Nothing, control, New Object() {True})
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
        tunit.SelectedIndex = 0
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
                 VALUES
                       ('" & login.Luserid.Text & "'   
                       ,'" & tid_hvsprod.Text.Trim & "'
                       ,'" & tvariety.Text.ToUpper & "'
                       ,'" & tfarmer.Text.ToUpper & "'
                       ,'" & tlocation.Text.ToUpper & "'
                       ,'" & tglharvest.ToString("yyyy-MM-dd") & "'
                       ,'" & tnoman.Text & "'
                       ,'" & tlotref.Text & "'
                       ,'" & tinsplot.Text & "'
                       ," & Math.Round(CDbl(tlotqtt.Text), 2) & "
                       ,'" & tunit.Text & "'
                       ,'" & tscope.Text & "'
                       ," & CInt(tbag.Text) & "
                       ,'" & tsampling.CheckState & "'
                       ,'" & tmoi.CheckState & "'
                       ,'" & tpur.CheckState & "'
                       ,'" & tger.CheckState & "'
                       ,'" & tvia.CheckState & "'
                       ,'" & traf.CheckState & "'
                       ,'" & tremark.Text & "'
                       ,'" & tloc_sample.Text & "'
                       ,'" & tkarantina.CheckState & "'
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
                                    ,[insplot] = '" & tinsplot.Text & "'
                                    ,[weight] = " & Math.Round(CDbl(tlotqtt.Text), 2) & "
                                    ,[unit] = '" & tunit.Text & "'
                                    ,[scope] = '" & tscope.Text & "'
                                    ,[bag]=" & CInt(tbag.Text) & "
                                    ,[test_sampling] = '" & tsampling.CheckState & "'
                                    ,[test_moi] ='" & tmoi.CheckState & "'
                                    ,[test_pur] = '" & tpur.CheckState & "'
                                    ,[test_ger] = '" & tger.CheckState & "'
                                    ,[test_via] = '" & tvia.CheckState & "'
                                    ,[test_raf] = '" & traf.CheckState & "'
                                    ,[remark] = '" & tremark.Text & "'
                                    ,[loc_sample]='" & tloc_sample.Text & "'
                                    ,[kesehatan_benih]='" & tkarantina.CheckState & "'
                                    ,[update_user] = '" & login.Luserid.Text & "'
                                    ,[update_by] = '" & GetIPAddress() & "'
                                    ,[update_date] = GETDATE()
                                WHERE [id]=" & vid & "
                            ")
                End If
                'LinkThisMonth_Click(sender, e)
                LinkClear_Click(sender, e)
                MetroGrid1.Refresh()
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
            '' ### Parameter vid penting untuk melakukan update pada spl_request
            vid = .Rows(i).Cells("IdColumn").Value
            If MetroGrid1.Columns(e.ColumnIndex).Name = "ColmEdit" Then

                Dim strlogin As Integer = _DataToValue("Select [id_login] from [HCQC_server].[dbo].[spl_request] WHERE [id]=" & vid & "")
                If strlogin = login.Luserid.Text Then
                    tid_hvsprod.Text = .Rows(i).Cells("IdhvsprodColumn").Value.ToString
                    tDOVendor.Text = .Rows(i).Cells("norencana").Value.ToString
                    tvariety.Text = .Rows(i).Cells("varietyColumn").Value.ToString
                    tfarmer.Text = .Rows(i).Cells("farmerColumn").Value.ToString
                    tlocation.Text = .Rows(i).Cells("LocationColumn").Value.ToString
                    tcrop.Text = _DataToValue("select crop FROM dbo.category_crop RIGHT OUTER JOIN
                         dbo.spl_request ON dbo.category_crop.prodcode = dbo.spl_request.variety 
						 where variety='" & tvariety.Text & "'")
                    tnoman.Text = .Rows(i).Cells("NomnlColumn").Value.ToString
                    tlotref.Text = .Rows(i).Cells("NojobColumn").Value.ToString
                    tinsplot.Text = _DataToValue("Select [insplot] from [HCQC_server].[dbo].[spl_request] WHERE [id]=" & vid & "")
                    tlotqtt.Text = .Rows(i).Cells("WeightColumn").Value.ToString
                    tunit.Text = .Rows(i).Cells("UnitColumn").Value.ToString
                    tscope.Text = .Rows(i).Cells("ScopeColumn").Value.ToString
                    tloc_sample.Text = .Rows(i).Cells("loc_sampleColumn").Value.ToString

                    Dim NoRencana As String = _DataToValue("SELECT [norencana] From [HCQC_server].[dbo].[harvestprod] WHERE [idcode]=" & tid_hvsprod.Text)
                    tDOVendor.Text = NoRencana.Replace(" ", "")

                    Try
                        Using dread As SqlDataReader = GetSpl_RequestData(vid)
                            If dread IsNot Nothing AndAlso dread.HasRows Then
                                While dread.Read()
                                    Dim harvestDate As DateTime
                                    If DateTime.TryParse(dread.Item("harvest").ToString(), harvestDate) Then
                                        tgl_hvs.Text = harvestDate.ToString("dd-MM-yyyy")
                                    End If
                                    'tgl_hvs.Text = dread.Item("harvest").ToString(LabelDate.Text)
                                    tinsplot.Text = dread.Item("insplot")
                                    tbag.Text = dread.Item("bag")

                                    tsampling.Checked = Convert.ToBoolean(dread.Item("test_sampling"))
                                    tmoi.Checked = Convert.ToBoolean(dread.Item("test_moi"))
                                    tpur.Checked = Convert.ToBoolean(dread.Item("test_pur"))
                                    traf.Checked = Convert.ToBoolean(dread.Item("test_raf"))
                                    tger.Checked = Convert.ToBoolean(dread.Item("test_ger"))
                                    tvia.Checked = Convert.ToBoolean(dread.Item("test_via"))
                                    tkarantina.Checked = Convert.ToBoolean(dread.Item("kesehatan_benih"))
                                    tremark.Text = dread.Item("remark")
                                End While
                            End If

                        End Using
                    Catch ex As Exception
                        MetroMessageBox.Show(Form.ActiveForm, "Error Get Data: " + ex.Message, Form.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, 211)
                    Finally
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                    End Try

                    BtnSave.Text = "Update"
                Else
                    MetroMessageBox.Show(Me, "Can only be edited the user request by " & _DataToValue("Select [req_name] from [qc_confirm_viewer] Where [id]=" & vid & ""))
                End If

            End If
        End With

    End Sub

    Private Function GetSpl_RequestData(ByVal vid As String) As SqlDataReader
        'Function untuk manmpilkan identitas secara dinamis, contoh:

        Dim sql As String = "SELECT   [insplot],loc_sample, harvest, [bag], [test_sampling], [test_moi], [test_pur], [test_raf], [test_ger], [test_via], [kesehatan_benih], remark
                            FROM [HCQC_server].[dbo].[spl_request] WHERE ([id] = @ID)"
        openDB()
        Dim cmd As New SqlCommand(sql, con) With {
            .CommandType = CommandType.Text
        }
        cmd.Parameters.Add(New SqlParameter("@ID", vid))
        '        con.Open()
        Return cmd.ExecuteReader(CommandBehavior.CloseConnection)
    End Function

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
                MetroMessageBox.Show(Me, "Can only be edited/delete the user request by " & _DataToValue("Select [req_name] from [qc_confirm_viewer] Where [id]=" & vid) & " Or HCQC Staff ")
            End If

        End If
    End Sub

    Private Sub MetroTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControl1.SelectedIndexChanged
        'or suppose *finance tab* index is 0 
        If MetroTabControl1.SelectedTab Is MetroTabPage3 Then

        End If
    End Sub


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
        tkarantina.CheckState = CheckState.Unchecked
        tremark.Text = ""
        tcrop.Text = ""
        tid_hvsprod.Focus()

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        MetroMessageBox.Show(Me, "Tombol pada Kolom input Variety ini akan melakukan filter pencarian sesuai input-an", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
    End Sub

    '' Mencari Production Plan dengan key production_code
    Private Sub Tid_hvsprod_KeyDown(sender As Object, e As KeyEventArgs) Handles tid_hvsprod.KeyDown
        Dim sql As String

        If e.KeyCode = Keys.Enter Then
            If _isBOF("[harvestprod]", "[idcode]", tid_hvsprod.Text) = True Then
                Try
                    openDB()
                    sql = "SELECT [variety], cgrname, dusun,harvest, [area], plant_qty, case when [joblot] IS NULL then '' else [joblot] end as [joblot], [norencana] From [HCQC_server].[dbo].[harvestprod] WHERE [idcode]=" & tid_hvsprod.Text

                    Using cmd As New SqlClient.SqlCommand(sql, con)
                        cmd.CommandType = CommandType.Text
                        Dim dread As SqlDataReader = cmd.ExecuteReader()
                        If dread.Read() Then
                            tvariety.Text = dread.Item("variety")
                            tfarmer.Text = dread.Item("cgrname")
                            tlocation.Text = dread.Item("dusun")
                            tlotref.Text = dread.Item("joblot")
                            tDOVendor.Text = dread.Item("norencana")
                            tlotqtt.Text = dread.Item("plant_qty")

                            Dim myValue As String = dread.Item("area")

                            If Not tloc_sample.Items.Contains(myValue) Then
                                tloc_sample.Items.Add(myValue) ' Tambahkan ke ComboBox
                            End If

                            tloc_sample.SelectedItem = myValue ' Pilih item tersebut

                            ' Asumsikan dread.Item("harvest") adalah DateTime
                            Dim harvestDate As DateTime = Convert.ToDateTime(dread.Item("harvest"))

                            ' Jika Anda ingin memformat sesuai dengan LabelDate.Text (misal "dd-MM-yyyy")
                            Dim formattedDate As String = harvestDate.ToString("dd-MM-yyyy")

                            ' Menampilkan di textbox tgl_hvs
                            tgl_hvs.Text = formattedDate
                            'tgl_hvs.Text = dread.Item("harvest").ToString(LabelDate.Text)
                        End If
                    End Using

                Catch ex As Exception
                    MetroMessageBox.Show(Form.ActiveForm, "Error Get Data Production: " + ex.Message, Form.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, 211)
                Finally
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                End Try

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
        'hanya angka
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Size_change(sender As Object, e As EventArgs) Handles MetroPanel1.SizeChanged
        MetroPanel1.MaximumSize = New Size(Screen.PrimaryScreen.Bounds.Width - 12, 350)

        MetroLabel2.Location = New Point(MetroLabel2.Location.X, MetroPanel1.Location.Y + MetroPanel1.Size.Height + 25)

        MetroGrid1.Location = New Point(MetroLabel2.Location.X, MetroPanel1.Location.Y + MetroPanel1.Size.Height + 56)
        MetroGrid1.Size = New Size(MetroTabPage1.Size.Width - 15, MetroTabPage1.Size.Height - MetroLabel2.Location.Y - 15)

        LinkThisMonth.Location = New Point(MetroLabel2.Location.X + 66 + 6, MetroLabel2.Location.Y)
        Link2MonthAgo.Location = New Point(LinkThisMonth.Location.X + 70, MetroLabel2.Location.Y)

        Tsearch.Location = New Point(Link2MonthAgo.Location.X + 32 + 70, MetroLabel2.Location.Y)
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Multy_Request_Sample.ShowDialog(Me)
    End Sub

    Private Sub OnOptionsSave(ByVal strData As String)
        'Or whatever you want to do on frmMain with Options Data.
        tid_hvsprod.Text = strData

        ' Membuat objek KeyEventArgs untuk mensimulasikan tombol yang ditekan
        Dim keyArgs As New KeyEventArgs(Keys.Enter) ' Simulasi tombol Enter

        ' Memanggil subroutine secara manual
        Tid_hvsprod_KeyDown(tid_hvsprod, keyArgs)
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
        Qc_confirm_viewerTableAdapter.FillByThisMonth(HCQC_NewDataset.qc_confirm_viewer)
        MetroGrid1.Refresh()
        Tsearch.Tag = "this_month"
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

    Private Sub LinkFindVendor_Click(sender As Object, e As EventArgs) Handles LinkFindVendor.Click
        Dim sql As String

        If _isBOF("[harvestprod]", "[norencana]", tDOVendor.Text) = True Then
            Try
                openDB()
                sql = "SELECT idcode, [variety], cgrname, blokno, harvest, [area], [plant_qty], case when [joblot] IS NULL then '' else [joblot] end as [joblot], [norencana] From [HCQC_server].[dbo].[harvestprod] WHERE [norencana]='" & tDOVendor.Text & "'"

                Using cmd As New SqlClient.SqlCommand(sql, con)
                    cmd.CommandType = CommandType.Text
                    Dim dread As SqlDataReader = cmd.ExecuteReader()
                    If dread.Read() Then
                        tid_hvsprod.Text = dread.Item("idcode")
                        tvariety.Text = dread.Item("variety")
                        tfarmer.Text = dread.Item("cgrname")
                        tlocation.Text = dread.Item("blokno") ''material/lokasi
                        tlotref.Text = dread.Item("joblot")
                        tDOVendor.Text = dread.Item("norencana")
                        tlotqtt.Text = dread.Item("plant_qty")
                        tunit.Text = "KG"

                        Dim myValue As String = dread.Item("area")
                        If Not tloc_sample.Items.Contains(myValue) Then
                            tloc_sample.Items.Add(myValue) ' Tambahkan ke ComboBox
                        End If

                        tloc_sample.SelectedItem = myValue ' Pilih item tersebut


                        ' Asumsikan dread.Item("harvest") adalah DateTime
                        Dim harvestDate As DateTime = Convert.ToDateTime(dread.Item("harvest"))

                        ' Jika Anda ingin memformat sesuai dengan LabelDate.Text (misal "dd-MM-yyyy")
                        Dim formattedDate As String = harvestDate.ToString("dd-MM-yyyy")

                        ' Menampilkan di textbox tgl_hvs
                        tgl_hvs.Text = formattedDate
                        'tgl_hvs.Text = dread.Item("harvest").ToString(LabelDate.Text)
                    End If
                End Using

            Catch ex As Exception
                MetroMessageBox.Show(Form.ActiveForm, "Error Get Data Vendor: " + ex.Message, Form.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, 211)
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try

            tid_hvsprod.SelectAll()
        Else
            MetroMessageBox.Show(Me, "Data ID Vendor not found")
        End If
    End Sub

    Private Sub tDOVendor_KeyDown(sender As Object, e As KeyEventArgs) Handles tDOVendor.KeyDown
        If e.KeyCode = Keys.Enter Then
            LinkFindVendor_Click(sender, e)
        End If
    End Sub

    Private Sub tloc_sample_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tloc_sample.SelectedIndexChanged

    End Sub

    Private Sub tlotqtt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tlotqtt.KeyPress
        ' Izinkan hanya angka, titik, koma, dan backspace
        If Not Char.IsControl(e.KeyChar) AndAlso
           Not Char.IsDigit(e.KeyChar) AndAlso
           e.KeyChar <> "."c AndAlso
           e.KeyChar <> ","c Then

            e.Handled = True
        End If

        'Penjelasan:
        'Char.IsDigit(e.KeyChar) → angka 0–9
        'Char.IsControl(e.KeyChar) → untuk mengizinkan tombol kontrol seperti backspace
        'e.KeyChar <> "."c → izinkan titik
        'e.KeyChar <> ","c → izinkan koma
        'e.Handled = True → membatalkan input selain yang diizinkan

    End Sub

    Private Sub MetroLinkThisM_Click(sender As Object, e As EventArgs) Handles MetroLinkThisM.Click
        Spl_request1TableAdapter.FillByThisMonth(HCQC_NewDataset.Spl_request1)
    End Sub

    Private Sub MetroLinkLastM_Click(sender As Object, e As EventArgs) Handles MetroLinkLastM.Click
        Spl_request1TableAdapter.FillByLastMonth(HCQC_NewDataset.Spl_request1)
    End Sub

    Private Sub MetroTextBoxParam_ButtonClick(sender As Object, e As EventArgs) Handles MetroTextBoxParam.ButtonClick
        If String.IsNullOrEmpty(MetroTextBoxParam.Text) Then
            Return
        Else
            Spl_request1TableAdapter.FillByParameter(HCQC_NewDataset.Spl_request1, "%" + MetroTextBoxParam.Text + "%")
        End If
    End Sub

    Private Sub MetroTextBoxParam_KeyDown(sender As Object, e As KeyEventArgs) Handles MetroTextBoxParam.KeyDown
        If e.KeyCode = Keys.Enter Then
            MetroTextBoxParam_ButtonClick(sender, e)
        End If
    End Sub
End Class
