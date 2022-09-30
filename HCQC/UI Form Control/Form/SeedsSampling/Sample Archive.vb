Imports System.Globalization
Public Class Sample_Archive
    Sub BersihInformation()
        Lreqnum.Text = "..."
        tVariety.Text = "..."
        tnomnl.Text = "..."
        tlotref.Text = "..."
        tharvest.Text = "..."
        tweight.Text = "..."
        tscope.Text = "..."
    End Sub

    Sub BersihTextbox()
        tlabnum.Text = ""
        tDayaBerkecambah.Text = ""
        tMurni.Text = ""
        tKadarAir.Text = ""
        tKemasan.Text = ""
        tUnit.Text = ""
        texpdate.Text = ""
    End Sub
    Public Sub FunctionUpdate()
        If String.IsNullOrEmpty(tlabnum.Text) Then
            MetroMessageBox.Show(Me, "Lab Number harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        ElseIf String.IsNullOrEmpty(tBoxnum.Text) Then
            MetroMessageBox.Show(Me, "Box Number harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        ElseIf String.IsNullOrEmpty(tVariety.Text) Or tVariety.Text = "..." Then
            MetroMessageBox.Show(Me, "Pastikan identitas sample sudah benar!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        Else
            Try
                Dim sql As String = ""
                Dim TglArchiveDate, TglExpDate As Date
                TglArchiveDate = Date.ParseExact(tarchivedate.Text, formatDate, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None)
                TglExpDate = Date.ParseExact(texpdate.Text, formatDate, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None)
                If _isBOFAND("receipt", "labnum", tlabnum.Text) = True Then
                    If _isBOF("archive", "labnum", tlabnum.Text) = False Then
                        _RunSQL("INSERT INTO archive (id_login
                                                    ,id_request
                                                    ,[labnum]
                                                    ,boxnum
                                                    ,lokasi
                                                    ,[dberkecambah]
                                                    ,[kemurnian]
                                                    ,[kadarair]
                                                    ,[expired]
                                                    ,[kemasan]
                                                    ,[unit_kem]
                                                    ,[arsipdate]
                                                    ,[input_at]
                                                    ,[input_by]) 
                                VALUES ('" & login.Luserid.Text & "'
                                ,'" & Lreqnum.Text & "'
                                ,'" & tlabnum.Text & "'
                                ,'" & tBoxnum.Text & "'
                                ,'" & tlocation.Text & "'
                                ," & Val(tDayaBerkecambah.Text) & "
                                ," & Val(tMurni.Text) & "
                                ," & Val(tKadarAir.Text) & "
                                ,'" & TglExpDate.ToString("yyyy-MM-dd") & "'
                                ," & Val(tKemasan.Text) & "
                                ,'" & tUnit.Text & "'
                                ,'" & TglArchiveDate.ToString("yyyy-MM-dd") & "'
                                ,GETDATE()
                                ,'" & GetIPAddress() & "')")

                        BersihInformation()
                        BersihTextbox()
                        Me.tlabnum.Focus()
                    Else
                        Dim tgljln As Date = _DataToValueDate("SELECT [arsipdate] FROM [archive] WHERE [labnum]='" & tlabnum.Text & "'")
                        tgljln.ToString("dd-MMM-yyyy")
                        Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data sudah pernah di Arsip pada tanggal " + tgljln.ToString("dd-MMM-yyyy") + ". Apakan anda ingin memperbaharui data???", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                        If result = DialogResult.Yes Then
                            _RunSQL("UPDATE archive 
                                        SET id_login = '" & login.Luserid.Text & "'
                                        ,id_request = '" & Lreqnum.Text & "'
                                        ,boxnum = '" & tBoxnum.Text & "'
                                        ,lokasi = '" & tlocation.Text & "'
                                        ,[dberkecambah] = " & Val(tDayaBerkecambah.Text) & "
                                        ,[kemurnian] = " & Val(tMurni.Text) & "
                                        ,[kadarair] = " & Val(tKadarAir.Text) & "
                                        ,expired = '" & TglExpDate.ToString("yyyy-MM-dd") & "'
                                        ,[kemasan] = " & Val(tKemasan.Text) & "
                                        ,[unit_kem] = '" & tUnit.Text & "'
                                        ,arsipdate = '" & TglArchiveDate.ToString("yyyy-MM-dd") & "' 
                                        ,update_at = GETDATE()
                                    WHERE (labnum = '" & tlabnum.Text & "')")
                            BersihInformation()
                            BersihTextbox()
                            Me.tlabnum.Focus()
                        ElseIf result = DialogResult.No Then
                            tlabnum.SelectAll()
                        End If
                    End If
                Else
                    Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data tidak ditemukan!. Nomor Lab anda mungkin kurang tepat.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                    If result = DialogResult.OK Then
                        Me.tlabnum.SelectAll()
                    End If
                End If
            Catch ex As Exception
                MetroMessageBox.Show(Me, "Error : " & ex.Message, Me.Text, MessageBoxButtons.OK, 211)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Sample_Archive_Load(sender As Object, e As EventArgs) Handles Me.Load
        LabelDate.Text = "dd-MM-yyyy"
        LabelDateExp.Text = LabelDate.Text
        tarchivedate.Text = Today.ToString(LabelDate.Text)
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        FunctionUpdate()
    End Sub
    Private Sub BtnUpdate_GotFocus(sender As Object, e As EventArgs) Handles BtnUpdate.GotFocus
        BtnUpdate.BorderRadius = 5
        BtnUpdate.Normalcolor = Color.FromArgb(0, 153, 255)
    End Sub

    Private Sub BtnUpdate_LostFocus(sender As Object, e As EventArgs) Handles BtnUpdate.LostFocus
        BtnUpdate.BorderRadius = 0
        BtnUpdate.Normalcolor = Color.FromArgb(0, 122, 204)
    End Sub
    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click
        If _isBOFAND("receipt", "labnum", tlabnum.Text) = True Then
            Lreqnum.Text = _DataToValue("SELECT [id] FROM [qc_confirm_view] WHERE [labnum]='" & tlabnum.Text & "'")
            tVariety.Text = _DataToValue("SELECT [variety] FROM [qc_confirm_view] WHERE [labnum]='" & tlabnum.Text & "'")
            tnomnl.Text = _DataToValue("SELECT [nomnl] FROM [qc_confirm_view] WHERE [labnum]='" & tlabnum.Text & "' ")
            tlotref.Text = _DataToValue("SELECT [nojob] FROM [qc_confirm_view] WHERE [labnum]='" & tlabnum.Text & "' ")
            Dim tglhvs As Date = _DataToValueDate("SELECT [harvest] FROM [qc_confirm_view] WHERE [labnum]='" & tlabnum.Text & "' ")
            tharvest.Text = tglhvs.ToString(LabelDate.Text)
            tweight.Text = _DataToValue("SELECT [weight] FROM [qc_confirm_view] WHERE [labnum]='" & tlabnum.Text & "' ")
            tscope.Text = _DataToValue("SELECT [scope] FROM [qc_confirm_view] WHERE [labnum]='" & tlabnum.Text & "' ")

            If _isBOF("archive", "labnum", tlabnum.Text) = True Then

                Dim tglarsip As Date = _DataToValueDate("SELECT [arsipdate] FROM [archive] WHERE  (labnum= '" & tlabnum.Text & "')")
                tglarsip.ToString("dd-MMM-yyyy")
                MetroMessageBox.Show(Me, "Data '" & tVariety.Text & "' BERAT '" & tweight.Text & "' sudah pernah di Upload pada tanggal " + tglarsip, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                tarchivedate.Text = tglarsip.ToString(LabelDate.Text)
                Dim expdate As Date = _DataToValueDate("SELECT [expired] FROM [HCQC_server].[dbo].[archive] WHERE (labnum= '" & tlabnum.Text & "')")
                texpdate.Text = expdate.ToString(LabelDate.Text)

                tDayaBerkecambah.Text = _DataToValue("SELECT [dberkecambah] FROM archive WHERE labnum='" & tlabnum.Text & "'")
                tMurni.Text = _DataToValue("SELECT [kemurnian] FROM archive WHERE labnum='" & tlabnum.Text & "'")
                tKadarAir.Text = _DataToValue("SELECT [kadarair] FROM archive WHERE labnum='" & tlabnum.Text & "'")

                tKemasan.Text = _DataToValue("SELECT [kemasan] FROM archive WHERE labnum='" & tlabnum.Text & "'")
                tUnit.Text = _DataToValue("Select [unit_kem] FROM archive WHERE labnum='" & tlabnum.Text & "'")
                tBoxnum.Text = _DataToValue("SELECT boxnum FROM archive WHERE labnum='" & tlabnum.Text & "'")
                tlocation.Text = _DataToValue("SELECT lokasi FROM archive WHERE labnum='" & tlabnum.Text & "'")
                BtnUpdate.Text = "&Update"
                BtnDelete.Enabled = True
            Else
                BtnUpdate.Text = "Save"
                BtnDelete.Enabled = False
                'Bersih()
            End If
        Else
            Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data tidak ditemukan!. Periksa kembali Lab Number yang anda input", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            If result = DialogResult.OK Then
                Me.tlabnum.SelectAll()
            End If
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If String.IsNullOrEmpty(tlabnum.Text) Then
            MetroMessageBox.Show(Me, "Lab Number harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        ElseIf String.IsNullOrEmpty(tVariety.Text) Or tVariety.Text = "..." Then
            MetroMessageBox.Show(Me, "Pastikan identitas sample sudah benar!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        Else
            Try
                If _isBOF("archive", "labnum", tlabnum.Text) = True Then
                    Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk mengkosongkan Tanggal Test pada No Lab" + tlabnum.Text, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
                    If result = DialogResult.Yes Then
                        _RunSQL("DELETE [archive] WHERE ([labnum]='" & tlabnum.Text & "')")
                        BersihInformation()
                        BersihTextbox()
                        Me.tlabnum.Focus()
                    ElseIf result = DialogResult.No Then
                        Me.tlabnum.SelectAll()
                    End If
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Data tidak ditemukan!. Periksa kembali No Lab yang anda input" + tlabnum.Text, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, 211)
                    Me.tlabnum.Focus()
                End If
            Catch ex As Exception
                MetroMessageBox.Show(Me, "Error : " & ex.Message, Me.Text, MessageBoxButtons.OK, 211)
            End Try
        End If
    End Sub

    'Sortcut keypress Alt + X to Save Button
    Private Sub Sample_Archive_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.Alt AndAlso (e.KeyCode = Keys.X)) Then
            FunctionUpdate()
        End If
    End Sub

    Private Sub tlabnum_KeyDown(sender As Object, e As KeyEventArgs) Handles tlabnum.KeyDown
        If ((e.KeyCode = Keys.Enter)) Then
            BtnFind_Click(sender, e)
        End If
    End Sub

    Private Sub MetroLink3_Click(sender As Object, e As EventArgs) Handles MetroLink3.Click
        tarchivedate.Text = Today.ToString(LabelDate.Text)
    End Sub

    Private Sub texpdate_GotFocus(sender As Object, e As EventArgs) Handles texpdate.GotFocus
        texpdate.SelectAll()
    End Sub

    Private Sub tarchivedate_GotFocus(sender As Object, e As EventArgs) Handles tarchivedate.GotFocus
        tarchivedate.SelectAll()
    End Sub

    Private Sub tDayaBerkecambah_GotFocus(sender As Object, e As EventArgs) Handles tDayaBerkecambah.GotFocus
        tDayaBerkecambah.SelectAll()
    End Sub

    Private Sub tMurni_GotFocus(sender As Object, e As EventArgs) Handles tMurni.GotFocus
        tMurni.SelectAll()
    End Sub

    Private Sub tKadarAir_GotFocus(sender As Object, e As EventArgs) Handles tKadarAir.GotFocus
        tKadarAir.SelectAll()
    End Sub

    Private Sub tKemasan_GotFocus(sender As Object, e As EventArgs) Handles tKemasan.GotFocus
        tKemasan.SelectAll()
    End Sub

    Private Sub tBoxnum_GotFocus(sender As Object, e As EventArgs) Handles tBoxnum.GotFocus
        tBoxnum.SelectAll()
    End Sub

    Private Sub tlocation_GotFocus(sender As Object, e As EventArgs) Handles tlocation.GotFocus
        tlocation.SelectAll()
    End Sub

    Private Sub LinkBack_Click(sender As Object, e As EventArgs) Handles LinkBack.Click
        NavigationFrame1.SelectedPage = NavigationPage1
    End Sub

    Private Sub LinkDataList_Click(sender As Object, e As EventArgs) Handles LinkDataList.Click
        NavigationFrame1.SelectedPage = NavigationPage2
        Me.Report_arsip_sample_viewTableAdapter.FillByLastMonth(Me.HCQC_serverDataSet.report_arsip_sample_view)
    End Sub

    Private Sub LinkThisMonth_Click(sender As Object, e As EventArgs) Handles LinkThisMonth.Click
        Me.Report_arsip_sample_viewTableAdapter.FillByThisMonth(Me.HCQC_serverDataSet.report_arsip_sample_view)
    End Sub

    Private Sub LinkLastMonth_Click(sender As Object, e As EventArgs) Handles LinkLastMonth.Click
        Me.Report_arsip_sample_viewTableAdapter.FillByLastMonth(Me.HCQC_serverDataSet.report_arsip_sample_view)
    End Sub

    Private Sub Tsearch_ButtonClick(sender As Object, e As EventArgs) Handles Tsearch.ButtonClick
        Me.Report_arsip_sample_viewTableAdapter.FillByVariable(Me.HCQC_serverDataSet.report_arsip_sample_view, "%" + Trim(Tsearch.Text) + "%")
    End Sub

    Private Sub Tsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles Tsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Tsearch_ButtonClick(sender, e)
        End If
    End Sub
End Class