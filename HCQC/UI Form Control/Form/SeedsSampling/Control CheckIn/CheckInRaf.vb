Public Class CheckInRaf
    Private Sub Btn_save_ger_Click(sender As Object, e As EventArgs) Handles Btn_save_raf.Click
        Dim strIdreq As Integer
        ''check/memastikan data yang ada di sample Receipt
        If _isBOFAND("receipt", "labnum", tlabnumRaf.Text) = True Then
            ''menentukan apakah nanti ini data baru atau data yang diperbaharui
            If _isBOFAND2("periodic_schedule", "labnum", tlabnumRaf.Text, "[test_on]", LabelRaf.Text) = False Then
                ''megirimpesan kepastian dari pada tindakan user
                Dim result As Integer = MetroMessageBox.Show(Me, "Check in Lab Number" + tlabnumRaf.Text, "Rafaction Test Check IN", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
                If result = DialogResult.Yes Then
                    ''exekusi data baru
                    ''mengambil nomor Identitas Sample Request
                    strIdreq = _DataToValue("SELECT id_request FROM receipt WHERE labnum='" & tlabnumRaf.Text & "'")
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
                               ,'" & tlabnumRaf.Text & "'
                               ,'" & LabelRaf.Text & "'
                               ,Convert(date, getdate())
                               )")
                    bersihRaf()
                    tlabnumRaf.Focus()
                End If
            Else
                ''exekusi data yang di perbaharui
                Dim tgljln As Date = _DataToValueDate("SELECT [test_date] FROM [periodic_schedule] WHERE [labnum]='" & tlabnumRaf.Text & "' AND [test_on]='" & LabelRaf.Text & "'")
                tgljln.ToString("dd-MM-yyyy")
                Dim result As Integer = MetroMessageBox.Show(Me, "Data sudah pernah di Upload pada tanggal " + tgljln.ToString("dd-MM-yyyy") + " . Apakan anda ingin memperbaharui tanggal Test Sample?", "Rafaction Test Check IN", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                If result = DialogResult.Yes Then
                    strIdreq = _DataToValue("SELECT id_request FROM receipt WHERE labnum='" & tlabnumRaf.Text & "'")
                    _RunSQL("UPDATE periodic_schedule SET id_request='" & strIdreq & "', id_login='" & login.Luserid.Text & "', test_date=Convert(date, '" & tTestDateGer.Text & "', 105) WHERE (labnum='" & tlabnumRaf.Text & "') AND [test_on]='" & LabelRaf.Text & "'")
                    Me.tlabnumRaf.Focus()
                    bersihRaf()
                ElseIf result = DialogResult.No Then
                    tlabnumRaf.Focus()
                    Return
                End If
            End If
        Else
            Dim result As Integer = MetroMessageBox.Show(Me, "Data tidak ditemukan!. Periksa kembali Lab Number yang anda input", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.None, 211)
            If result = DialogResult.OK Then
                Me.tlabnumRaf.Focus()
            End If
        End If
    End Sub

    Private Sub BtnFindRaf_Click(sender As Object, e As EventArgs) Handles BtnFindRaf.Click
        ''check/memastikan data yang ada di sample Receipt
        If _isBOFAND("receipt", "labnum", tlabnumRaf.Text) = True Then
            ''TAMPILKAN DATA DI LABEL
            tTestDateGer.Text = Today.ToString(LabelDate1.Text)
            LreqnumGer.Text = _DataToValue("SELECT [id] FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum] ='" & tlabnumRaf.Text & "'")
            LvarietyGer.Text = _DataToValue("SELECT [variety] FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum] = '" & tlabnumRaf.Text & "'")
            LfarmerGer.Text = _DataToValue("SELECT [farmer] FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum] = '" & tlabnumRaf.Text & "'")
            LjobGer.Text = _DataToValue("SELECT CONCAT([nomnl], ' - ', [nojob]) FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum] = '" & tlabnumRaf.Text & "'")
            LLocationgGer.Text = _DataToValue("SELECT [location] FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum] = '" & tlabnumRaf.Text & "'")
            LharvestGer.Text = _DataToValueDate("SELECT [harvest] FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum] = '" & tlabnumRaf.Text & "'")

            ''menentukan apakah nanti ini data baru atau data yang diperbaharui
            If _isBOFAND2("periodic_schedule", "labnum", tlabnumRaf.Text, "[test_on]", LabelRaf.Text) = False Then
                Btn_save_raf.Enabled = True
                Btn_del_raf.Enabled = False
                Btn_save_raf.Text = "Save"
                'Btn_save_raf.Focus()
            Else
                ''exekusi data yang di perbaharui
                Dim tgljln As Date = _DataToValueDate("SELECT [test_date] FROM [periodic_schedule] WHERE [labnum]='" & tlabnumRaf.Text & "' AND [test_on]='" & LabelRaf.Text & "'")
                tTestDateGer.Text = tgljln.ToString("dd-MM-yyyy")
                Dim result As Integer = MetroMessageBox.Show(Me, "Data sudah pernah di Upload pada tanggal " + tgljln.ToString("dd-MM-yyyy") + " . Apakan anda ingin memperbaharui tanggal Test Sample?", "Rafaction Test Check IN", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                If result = DialogResult.Yes Then
                    ''menampilkan data ke texbox dengan textButtonSave menjadi Update
                    Btn_save_raf.Enabled = True
                    Btn_del_raf.Visible = True
                    Btn_del_raf.Enabled = True
                    Btn_save_raf.Text = "Update"
                    Me.tTestDateGer.Focus()
                ElseIf result = DialogResult.No Then
                    bersihRaf()
                    tlabnumRaf.Focus()
                    Return
                End If
            End If
        Else
            Dim result As Integer = MetroMessageBox.Show(Me, "Data tidak ditemukan!. Periksa kembali Lab Number yang anda input", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.None, 211)
            If result = DialogResult.OK Then
                Me.tlabnumRaf.Focus()
            End If
        End If
    End Sub

    Private Sub tlabnumRaf_KeyDown(sender As Object, e As KeyEventArgs) Handles tlabnumRaf.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnFindRaf_Click(sender, e)
            tTestDateGer.Focus()
        End If
    End Sub

    Private Sub tTestDateGer_KeyDown(sender As Object, e As KeyEventArgs) Handles tTestDateGer.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Btn_save_raf.Enabled Then
                Btn_save_ger_Click(sender, e)
            Else
                BtnFindRaf_Click(sender, e)
            End If
        End If
    End Sub
    Sub bersihRaf()
        tTestDateGer.Text = Today.ToString(LabelDate1.Text)
        LreqnumGer.Text = ""
        LvarietyGer.Text = ""
        LfarmerGer.Text = ""
        LjobGer.Text = ""
        LLocationgGer.Text = ""
        LharvestGer.Text = ""
        Btn_save_raf.Text = "Save"
        Btn_del_raf.Visible = False
        Btn_del_raf.Enabled = False
        Btn_save_raf.Enabled = False
    End Sub

    Private Sub CheckInRaf_Load(sender As Object, e As EventArgs) Handles Me.Load
        tTestDateGer.Text = Today.ToString(LabelDate1.Text)
        Btn_del_raf.Enabled = False
        Btn_save_raf.Enabled = False
    End Sub

    Private Sub Btn_del_raf_Click(sender As Object, e As EventArgs) Handles Btn_del_raf.Click
        Dim result As Integer = MetroMessageBox.Show(Me, "Apakan anda ingin menghapus Test Sample Rafaction Lab Number " + tlabnumRaf.Text + " ?", "Rafaction Test Check IN", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, 211)
        If result = DialogResult.OK Then
            _RunSQL("DELETE periodic_schedule WHERE (labnum='" & tlabnumRaf.Text & "') AND [test_on]='" & LabelRaf.Text & "'")
            bersihRaf()
        End If
    End Sub

    Private Sub tlabnumRaf_GotFocus(sender As Object, e As EventArgs) Handles tlabnumRaf.GotFocus
        tlabnumRaf.SelectAll()
    End Sub
End Class