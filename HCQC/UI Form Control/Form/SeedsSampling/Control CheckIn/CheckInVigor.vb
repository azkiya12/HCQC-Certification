Public Class CheckInVigor
    Private Sub Btn_save_ger_Click(sender As Object, e As EventArgs) Handles Btn_save_ger.Click
        Dim strIdreq As Integer
        ''check/memastikan data yang ada sudah di sample Receipt
        If _isBOFAND("receipt", "labnum", tlabnumGer.Text) = True Then
            ''menentukan apakah nanti ini data baru atau data yang diperbaharui
            If _isBOFAND2("periodic_schedule", "labnum", tlabnumGer.Text, "[test_on]", LabelGer.Text) = False Then
                ''megirimpesan kepastian dari pada tindakan user
                Dim result As Integer = MetroMessageBox.Show(Me, "Check out Germination Lab Number " + tlabnumGer.Text + ", Variety " + LvarietyGer.Text + ", JOB " + LjobGer.Text, "Germination Test Check OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 211)
                If result = DialogResult.Yes Then
                    ''exekusi data baru
                    ''mengambil nomor Identitas Sample Request
                    strIdreq = _DataToValue("SELECT id_request FROM receipt WHERE labnum='" & tlabnumGer.Text & "'")
                    _RunSQL("INSERT INTO [dbo].[periodic_schedule]
                               ([id_request]
                               ,[id_login]
                               ,[labnum]
                               ,[test_on]
                               ,[test_date]
                               )
                             VALUES
                               ('" & strIdreq & "'
                               ,'" & login.Luserid.Text & "'
                               ,'" & tlabnumGer.Text & "'
                               ,'" & LabelGer.Text & "'
                               ,Convert(date, getdate())
                               )")
                    bersihGer()
                    tlabnumGer.Focus()
                End If
            Else
                ''exekusi data yang di perbaharui
                Dim tgljln As Date = _DataToValueDate("SELECT [test_date] FROM [periodic_schedule] WHERE [labnum]='" & tlabnumGer.Text & "' AND [test_on]='" & LabelGer.Text & "'")
                tgljln.ToString("dd-MM-yyyy")
                Dim result As Integer = MetroMessageBox.Show(Me, "Data " + tlabnumGer.Text + "sudah pernah di Check IN pada tanggal " + tgljln.ToString("dd-MM-yyyy") + " . Apakan anda ingin memperbaiki tanggal Test Sample?", "Germination Test Check IN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 211)
                If result = DialogResult.Yes Then
                    strIdreq = _DataToValue("SELECT id_request FROM receipt WHERE labnum='" & tlabnumGer.Text & "'")
                    _RunSQL("UPDATE periodic_schedule SET id_request='" & strIdreq & "', id_login='" & login.Luserid.Text & "', test_date=Convert(date, '" & tTestDateGer.Text & "',105) WHERE (labnum='" & tlabnumGer.Text & "') AND [test_on]='" & LabelGer.Text & "'")
                    Me.tlabnumGer.Focus()
                    bersihGer()
                ElseIf result = DialogResult.No Then
                    tlabnumGer.Focus()
                    Return
                End If
            End If
        Else
            Dim result As Integer = MetroMessageBox.Show(Me, "Data tidak ditemukan!. Periksa kembali Lab Number yang anda input", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            If result = DialogResult.OK Then
                Me.tlabnumGer.Focus()
            End If
        End If
    End Sub

    Private Sub BtnFindGer_Click(sender As Object, e As EventArgs) Handles BtnFindGer.Click
        ''check/memastikan data yang ada di sample Receipt
        If _isBOFAND("receipt", "labnum", tlabnumGer.Text) = True Then
            ''TAMPILKAN DATA DI LABEL
            tTestDateGer.Text = Today.ToString(LabelDate1.Text)
            LreqnumGer.Text = _DataToValue("SELECT [id] FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum] ='" & tlabnumGer.Text & "'")
            LvarietyGer.Text = _DataToValue("SELECT [variety] FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum] = '" & tlabnumGer.Text & "'")
            LfarmerGer.Text = _DataToValue("SELECT [farmer] FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum] = '" & tlabnumGer.Text & "'")
            LjobGer.Text = _DataToValue("SELECT CONCAT([nomnl], ' - ', [nojob]) FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum] = '" & tlabnumGer.Text & "'")
            LLocationgGer.Text = _DataToValue("SELECT [location] FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum] = '" & tlabnumGer.Text & "'")
            LharvestGer.Text = _DataToValueDate("SELECT [harvest] FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum] = '" & tlabnumGer.Text & "'")

            If _isBOFAND2("periodic_schedule", "labnum", tlabnumGer.Text, "[test_on]", "Germination Test") = False Then
                MetroMessageBox.Show(Me, "Anda melawatkan tahap untuk Check IN Germination Test atau Pengujian DT", "Germination Test Check OUT", MessageBoxButtons.OK, MessageBoxIcon.Warning, 211)
                Return
            End If

            ''menentukan apakah nanti ini data baru atau data yang diperbaharui
            If _isBOFAND2("periodic_schedule", "labnum", tlabnumGer.Text, "[test_on]", LabelGer.Text) = False Then
                ''exekusi data yang di Baru

                'MetroPanel2.Enabled = False
                Btn_save_ger.Enabled = True
                Btn_del_ger.Enabled = False
                Btn_save_ger.Text = "Save"
                Btn_save_ger.Focus()
            Else
                ''exekusi data yang di perbaharui
                Dim tgljln As Date = _DataToValueDate("SELECT [test_date] FROM [periodic_schedule] WHERE [labnum]='" & tlabnumGer.Text & "' AND [test_on]='" & LabelGer.Text & "'")
                tTestDateGer.Text = tgljln.ToString("dd-MM-yyyy")
                Dim result As Integer = MetroMessageBox.Show(Me, "Data sudah pernah di Upload pada tanggal " + tgljln.ToString("dd-MM-yyyy") + " . Apakan anda ingin memperbaharui tanggal Test Sample?", "Germination Test Check OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                If result = DialogResult.Yes Then
                    ''menampilkan data ke texbox dengan textButtonSave menjadi Update
                    ' MetroPanel2.Enabled = True
                    Btn_save_ger.Enabled = True
                    Btn_del_ger.Enabled = True
                    Btn_save_ger.Text = "Update"
                    Me.tTestDateGer.Focus()
                ElseIf result = DialogResult.No Then
                    bersihGer()
                    MetroPanel2.Enabled = False
                    Btn_save_ger.Text = "Save"
                    tlabnumGer.Focus()
                    Return
                End If
            End If
        Else
            Dim result As Integer = MetroMessageBox.Show(Me, "Data tidak ditemukan!. Periksa kembali Lab Number yang anda input", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.None, 211)
            If result = DialogResult.OK Then
                Me.tlabnumGer.Focus()
            End If
        End If
    End Sub

    Private Sub tlabnumGer_KeyDown(sender As Object, e As KeyEventArgs) Handles tlabnumGer.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnFindGer_Click(sender, e)
            tTestDateGer.Focus()
        End If
    End Sub

    Private Sub tTestDateGer_KeyDown(sender As Object, e As KeyEventArgs) Handles tTestDateGer.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Btn_save_ger.Enabled Then
                Btn_save_ger_Click(sender, e)
            Else
                BtnFindGer_Click(sender, e)
            End If

        End If
    End Sub

    Sub bersihGer()
        tTestDateGer.Text = Today.ToString(LabelDate1.Text)
        LreqnumGer.Text = ""
        LvarietyGer.Text = ""
        LfarmerGer.Text = ""
        LjobGer.Text = ""
        LLocationgGer.Text = ""
        LharvestGer.Text = ""
        Btn_save_ger.Text = "Save"
        Btn_del_ger.Enabled = False
        Btn_save_ger.Enabled = False
    End Sub

    Private Sub CheckInGer_Load(sender As Object, e As EventArgs) Handles Me.Load
        tTestDateGer.Text = Today.ToString(LabelDate1.Text)
        Btn_save_ger.Enabled = False
        Btn_del_ger.Enabled = False
    End Sub

    Private Sub Btn_del_ger_Click(sender As Object, e As EventArgs) Handles Btn_del_ger.Click
        Dim result As Integer = MetroMessageBox.Show(Me, "Apakan anda ingin menghapus Test Sample Germination Lab Number " + tlabnumGer.Text + " ?", "Germination Test Check OUT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, 211)
        If result = DialogResult.OK Then
            _RunSQL("DELETE periodic_schedule WHERE (labnum='" & tlabnumGer.Text & "') AND [test_on]='" & LabelGer.Text & "'")
            bersihGer()
        End If
    End Sub

    Private Sub tlabnumGer_GotFocus(sender As Object, e As EventArgs) Handles tlabnumGer.GotFocus
        tlabnumGer.SelectAll()
    End Sub

    Private Sub Btn_save_ger_KeyDown(sender As Object, e As KeyEventArgs) Handles Btn_save_ger.KeyDown
        If e.KeyCode = Keys.Enter Then
            Btn_save_ger_Click(sender, e)
            tlabnumGer.Focus()
        End If
    End Sub
End Class