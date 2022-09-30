Public Class CheckInVia
    Private Sub Btn_save_Via_Click(sender As Object, e As EventArgs) Handles Btn_save_Via.Click
        Dim strIdreq As Integer
        ''check/memastikan data yang ada di sample Receipt
        If _isBOFAND("receipt", "labnum", tlabnumVia.Text) = True Then
            ''menentukan apakah nanti ini data baru atau data yang diperbaharui
            If _isBOFAND2("periodic_schedule", "labnum", tlabnumVia.Text, "[test_on]", LabelVia.Text) = False Then
                ''megirimpesan kepastian dari pada tindakan user
                Dim result As Integer = MetroMessageBox.Show(Me, "Check in Lab Number" + tlabnumVia.Text, "Viability Test Check IN", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
                If result = DialogResult.Yes Then
                    ''exekusi data baru
                    ''mengambil nomor Identitas Sample Request
                    strIdreq = _DataToValue("SELECT id_request FROM receipt WHERE labnum='" & tlabnumVia.Text & "'")
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
                               ,'" & tlabnumVia.Text & "'
                               ,'" & LabelVia.Text & "'
                               ,GETDATE()
                               )")
                    bersih()
                    tlabnumVia.Focus()
                End If
            Else
                ''exekusi data yang di perbaharui
                Dim tgljln As Date = _DataToValueDate("SELECT [test_date] FROM [periodic_schedule] WHERE [labnum]='" & tlabnumVia.Text & "' AND [test_on]='" & LabelVia.Text & "'")
                tgljln.ToString("dd-MM-yyyy")
                Dim result As Integer = MetroMessageBox.Show(Me, "Data sudah pernah di Upload pada tanggal " + tgljln.ToString("dd-MM-yyyy") + " . Apakan anda ingin memperbaharui tanggal Test Sample?", "Viability Test Check IN", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                If result = DialogResult.Yes Then
                    strIdreq = _DataToValue("SELECT id_request FROM receipt WHERE labnum='" & tlabnumVia.Text & "'")
                    _RunSQL("UPDATE periodic_schedule SET id_request='" & strIdreq & "', id_login='" & login.Luserid.Text & "', test_date=Convert(date, '" & tTestDateGer.Text & "', 105) WHERE (labnum='" & tlabnumVia.Text & "') AND [test_on]='" & LabelVia.Text & "'")
                    Me.tlabnumVia.Focus()
                    bersih()
                ElseIf result = DialogResult.No Then
                    tlabnumVia.Focus()
                    Return
                End If
            End If
        Else
            Dim result As Integer = MetroMessageBox.Show(Me, "Data tidak ditemukan!. Periksa kembali Lab Number yang anda input", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            If result = DialogResult.OK Then
                Me.tlabnumVia.Focus()
                Return
            End If
        End If
    End Sub

    Private Sub BtnFindVia_Click(sender As Object, e As EventArgs) Handles BtnFindVia.Click
        ''check/memastikan data yang ada di sample Receipt
        If _isBOFAND("receipt", "labnum", tlabnumVia.Text) = True Then
            ''TAMPILKAN DATA DI LABEL
            tTestDateGer.Text = Today.ToString(LabelDate1.Text)
            LreqnumGer.Text = _DataToValue("SELECT [id] FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum] ='" & tlabnumVia.Text & "'")
            LvarietyGer.Text = _DataToValue("SELECT [variety] FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum] = '" & tlabnumVia.Text & "'")
            LfarmerGer.Text = _DataToValue("SELECT [farmer] FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum] = '" & tlabnumVia.Text & "'")
            LjobGer.Text = _DataToValue("SELECT CONCAT([nomnl], ' - ', [nojob]) FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum] = '" & tlabnumVia.Text & "'")
            LLocationgGer.Text = _DataToValue("SELECT [location] FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum] = '" & tlabnumVia.Text & "'")
            LharvestGer.Text = _DataToValueDate("SELECT [harvest] FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum] = '" & tlabnumVia.Text & "'")

            ''menentukan apakah nanti ini data baru atau data yang diperbaharui
            If _isBOFAND2("periodic_schedule", "labnum", tlabnumVia.Text, "[test_on]", LabelVia.Text) = False Then
                Btn_save_Via.Enabled = True
                Btn_del_Via.Enabled = False
                Btn_save_Via.Text = "Save"
                'Btn_save_Via.Focus()
            Else
                ''exekusi data yang di perbaharui
                Dim tgljln As Date = _DataToValueDate("SELECT [test_date] FROM [periodic_schedule] WHERE [labnum]='" & tlabnumVia.Text & "' AND [test_on]='" & LabelVia.Text & "'")
                tTestDateGer.Text = tgljln.ToString("dd-MM-yyyy")
                Dim result As Integer = MetroMessageBox.Show(Me, "Data sudah pernah di Upload pada tanggal " + tgljln.ToString("dd-MM-yyyy") + " . Apakan anda ingin melihat tanggal Test Sample?", "Viability Test Check IN", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                If result = DialogResult.Yes Then
                    ''menampilkan data ke texbox dengan textButtonSave menjadi Update
                    Btn_save_Via.Enabled = True
                    Btn_del_Via.Visible = True
                    Btn_del_Via.Enabled = True
                    Btn_save_Via.Text = "Update"
                    Me.tTestDateGer.Focus()
                ElseIf result = DialogResult.No Then
                    bersih()
                    tlabnumVia.Focus()
                    Return
                End If
            End If
        Else
            Dim result As Integer = MetroMessageBox.Show(Me, "Data tidak ditemukan!. Periksa kembali Lab Number yang anda input", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.None, 211)
            If result = DialogResult.OK Then
                Me.tlabnumVia.Focus()
            End If
        End If
    End Sub

    Private Sub Btn_del_Via_Click(sender As Object, e As EventArgs) Handles Btn_del_Via.Click
        Dim result As Integer = MetroMessageBox.Show(Me, "Apakan anda ingin menghapus Test Sample Viability Lab Number " + tlabnumVia.Text + " ?", "Viability Test Check IN", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, 211)
        If result = DialogResult.OK Then
            _RunSQL("DELETE periodic_schedule WHERE (labnum='" & tlabnumVia.Text & "') AND [test_on]='" & LabelVia.Text & "'")
            bersih()
        End If
    End Sub

    Private Sub tlabnumVia_KeyDown(sender As Object, e As KeyEventArgs) Handles tlabnumVia.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnFindVia_Click(sender, e)
            tTestDateGer.Focus()
        End If
    End Sub

    Private Sub tTestDateGer_KeyDown(sender As Object, e As KeyEventArgs) Handles tTestDateGer.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Btn_save_Via.Enabled Then
                Btn_save_Via_Click(sender, e)
            Else
                BtnFindVia_Click(sender, e)
            End If

        End If
    End Sub

    Private Sub CheckInVia_Load(sender As Object, e As EventArgs) Handles Me.Load
        tTestDateGer.Text = Today.ToString(LabelDate1.Text)
        Btn_del_Via.Visible = False
        Btn_save_Via.Enabled = False
    End Sub

    Sub bersih()
        tTestDateGer.Text = Today.ToString(LabelDate1.Text)
        LreqnumGer.Text = ""
        LvarietyGer.Text = ""
        LfarmerGer.Text = ""
        LjobGer.Text = ""
        LLocationgGer.Text = ""
        LharvestGer.Text = ""
        Btn_save_Via.Text = "Save"
        Btn_del_Via.Visible = False
        Btn_del_Via.Enabled = False
        Btn_save_Via.Enabled = False
    End Sub

    Private Sub tlabnumVia_GotFocus(sender As Object, e As EventArgs) Handles tlabnumVia.GotFocus
        tlabnumVia.SelectAll()
    End Sub
End Class