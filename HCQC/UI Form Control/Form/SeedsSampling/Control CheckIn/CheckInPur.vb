Public Class CheckInPur
    Private Sub Btn_save_Pur_Click(sender As Object, e As EventArgs) Handles Btn_save_Pur.Click
        Dim strIdreq As Integer
        ''check/memastikan data yang ada di sample Receipt
        If _isBOFAND("receipt", "labnum", tlabnumPur.Text) = True Then
            ''menentukan apakah nanti ini data baru atau data yang diperbaharui
            If _isBOFAND2("periodic_schedule", "labnum", tlabnumPur.Text, "[test_on]", LabelPur.Text) = False Then
                ''megirimpesan kepastian dari pada tindakan user
                Dim result As Integer = MetroMessageBox.Show(Me, "Check in Lab Number" + tlabnumPur.Text, "Purity Test Check IN", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
                If result = DialogResult.Yes Then
                    ''exekusi data baru
                    ''mengambil nomor Identitas Sample Request
                    strIdreq = _DataToValue("SELECT id_request FROM receipt WHERE labnum='" & tlabnumPur.Text & "'")
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
                               ,'" & tlabnumPur.Text & "'
                               ,'" & LabelPur.Text & "'
                               ,CONVERT(DATE, GETDATE())
                               )")
                    bersihPur()
                    tlabnumPur.Focus()
                End If
            Else
                ''exekusi data yang di perbaharui
                Dim tgljln As Date = _DataToValueDate("SELECT [test_date] FROM [periodic_schedule] WHERE [labnum]='" & tlabnumPur.Text & "' AND [test_on]='" & LabelPur.Text & "'")
                tgljln.ToString("dd-MM-yyyy")
                Dim result As Integer = MetroMessageBox.Show(Me, "Data sudah pernah di Upload pada tanggal " + tgljln.ToString("dd-MM-yyyy") + " . Apakan anda ingin memperbaharui tanggal Test Sample?", "Purity Test Check IN", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                If result = DialogResult.Yes Then
                    strIdreq = _DataToValue("SELECT id_request FROM receipt WHERE labnum='" & tlabnumPur.Text & "'")
                    _RunSQL("UPDATE periodic_schedule SET id_request='" & strIdreq & "',id_login='" & login.Luserid.Text & "',test_date=Convert(date, '" & tTestDateGer.Text & "', 105) WHERE (labnum='" & tlabnumPur.Text & "') AND [test_on]='" & LabelPur.Text & "'")
                    Me.tlabnumPur.Focus()
                    bersihPur()
                ElseIf result = DialogResult.No Then
                    tlabnumPur.Focus()
                    Return
                End If
            End If
        Else
            Dim result As Integer = MetroMessageBox.Show(Me, "Data tidak ditemukan!. Periksa kembali Lab Number yang anda input", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            If result = DialogResult.OK Then
                Me.tlabnumPur.Focus()
            End If
        End If
    End Sub

    Private Sub BtnFindPur_Click(sender As Object, e As EventArgs) Handles BtnFindPur.Click
        ''check/memastikan data yang ada di sample Receipt
        If _isBOFAND("receipt", "labnum", tlabnumPur.Text) = True Then

            ''TAMPILKAN DATA DI LABEL
            tTestDateGer.Text = Today.ToString(LabelDate1.Text)
            Dim controls As New Dictionary(Of String, Control) From {
                {"id", LreqnumGer},
                {"variety", LvarietyGer},
                {"farmer", LfarmerGer},
                {"location", LLocationGer},
                {"harvest", LharvestGer},
                {"job", LjobGer}
            }
            ReadDataFromDatabase(tlabnumPur.Text, controls)

            ''menentukan apakah nanti ini data baru atau data yang diperbaharui
            If _isBOFAND2("periodic_schedule", "labnum", tlabnumPur.Text, "[test_on]", LabelPur.Text) = False Then
                Btn_save_Pur.Enabled = True
                Btn_del_Pur.Enabled = False
                Btn_save_Pur.Text = "Save"
                Btn_save_Pur.Focus()
            Else
                ''exekusi data yang di perbaharui
                Dim tgljln As Date = _DataToValueDate("SELECT [test_date] FROM [periodic_schedule] WHERE [labnum]='" & tlabnumPur.Text & "' AND [test_on]='" & LabelPur.Text & "'")
                tTestDateGer.Text = tgljln.ToString("dd-MM-yyyy")
                Dim result As Integer = MetroMessageBox.Show(Me, "Data sudah pernah di Upload pada tanggal " + tgljln.ToString("dd-MM-yyyy") + " . Apakan anda ingin memperbaharui tanggal Test Sample?", "Germination Test Check IN", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                If result = DialogResult.Yes Then
                    ''menampilkan data ke texbox dengan textButtonSave menjadi Update
                    Btn_save_Pur.Enabled = True
                    Btn_del_Pur.Visible = True
                    Btn_del_Pur.Enabled = True
                    Btn_save_Pur.Text = "Update"
                    Me.tTestDateGer.Focus()
                ElseIf result = DialogResult.No Then
                    bersihPur()
                    tlabnumPur.Focus()
                    Return
                End If
            End If
        Else
            Dim result As Integer = MetroMessageBox.Show(Me, "Data tidak ditemukan!. Periksa kembali Lab Number yang anda input", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            If result = DialogResult.OK Then
                Me.tlabnumPur.Focus()
            End If
        End If
    End Sub

    Private Sub tlabnumPur_KeyDown(sender As Object, e As KeyEventArgs) Handles tlabnumPur.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnFindPur_Click(sender, e)
            tTestDateGer.Focus()
        End If
    End Sub

    Private Sub tTestDateGer_KeyDown(sender As Object, e As KeyEventArgs) Handles tTestDateGer.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Btn_save_Pur.Enabled Then
                Btn_save_Pur_Click(sender, e)
            Else
                BtnFindPur_Click(sender, e)
            End If

        End If
    End Sub

    Private Sub CheckInGer_Load(sender As Object, e As EventArgs) Handles Me.Load
        tTestDateGer.Text = Today.ToString(LabelDate1.Text)
        Btn_del_Pur.Visible = False
        Btn_save_Pur.Enabled = False
    End Sub

    Private Sub Btn_del_Pur_Click(sender As Object, e As EventArgs) Handles Btn_del_Pur.Click
        Dim result As Integer = MetroMessageBox.Show(Me, "Apakan anda ingin menghapus Test Sample Germination Lab Number " + tlabnumPur.Text + " ?", "Germination Test Check IN", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, 211)
        If result = DialogResult.OK Then
            _RunSQL("DELETE periodic_schedule WHERE (labnum='" & tlabnumPur.Text & "') AND [test_on]='" & LabelPur.Text & "'")
            bersihPur()
        End If
    End Sub

    Sub bersihPur()
        tTestDateGer.Text = Today.ToString(LabelDate1.Text)
        LreqnumGer.Text = ""
        LvarietyGer.Text = ""
        LfarmerGer.Text = ""
        LjobGer.Text = ""
        LLocationGer.Text = ""
        LharvestGer.Text = ""

        Btn_save_Pur.Text = "Save"
        Btn_del_Pur.Visible = False
        Btn_del_Pur.Enabled = False
        Btn_save_Pur.Enabled = False
    End Sub

    Private Sub tlabnumPur_GotFocus(sender As Object, e As EventArgs) Handles tlabnumPur.GotFocus
        tlabnumPur.SelectAll()
    End Sub
End Class