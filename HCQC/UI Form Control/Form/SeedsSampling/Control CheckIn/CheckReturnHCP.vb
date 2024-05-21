Public Class CheckReturnHCP

    Sub bersih()
        tTestDate.Text = Today.ToString(LabelDate1.Text)
        Lreqnum.Text = ""
        Lvariety.Text = ""
        Lfarmer.Text = ""
        Ljob.Text = ""
        LLocationg.Text = ""
        Lharvest.Text = ""
        Btn_save.Text = "Save"
        Btn_del.Enabled = False
        Btn_save.Enabled = False
    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click
        Dim strIdreq As Integer
        ''check/memastikan data LabNum ada di sample Receipt
        If _isBOFAND("receipt", "labnum", tlabnum.Text) = True Then
            ''menentukan apakah nanti ini data baru atau data yang diperbaharui
            If _isBOFAND("[spl_return]", "labnum", tlabnum.Text) = False Then
                ''megirimpesan Validation Message dari pada tindakan user
                Dim result As Integer = MetroMessageBox.Show(Me, "Check in Lab Number" + tlabnum.Text, "Sample Return HCP", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
                If result = DialogResult.Yes Then
                    ''exekusi data baru
                    ''mengambil nomor Identitas Sample Request
                    strIdreq = _DataToValue("SELECT id_request FROM receipt WHERE labnum='" & tlabnum.Text & "'")
                    _RunSQL("INSERT INTO [dbo].[spl_return]
                               ([id_request]
                               ,[id_login]
                               ,[labnum]
                               ,[tgl_terima]
                               
                               )
                         VALUES
                               ('" & strIdreq & "'
                               ,'" & login.Luserid.Text & "'
                               ,'" & tlabnum.Text & "'
                               ,Convert(date, '" & tTestDate.Text & "')
                               
                               )")
                    bersih()
                    tlabnum.Focus()
                End If
            Else
                ''exekusi data yang di perbaharui
                Dim tgljln As Date = _DataToValueDate("SELECT [tgl_terima] FROM [spl_return] WHERE [labnum]='" & tlabnum.Text & "'")
                tgljln.ToString("dd-MM-yyyy")
                Dim result As Integer = MetroMessageBox.Show(Me, "Data sudah pernah di Upload pada tanggal " + tgljln.ToString("dd-MM-yyyy") + " . Apakan anda ingin memperbaharui Tanggal?", "Sample Return HCP", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                If result = DialogResult.Yes Then
                    strIdreq = _DataToValue("SELECT id_request FROM receipt WHERE labnum='" & tlabnum.Text & "'")
                    _RunSQL("UPDATE [spl_return] SET id_request='" & strIdreq & "', id_login='" & login.Luserid.Text & "', [tgl_terima]=Convert(date, '" & tTestDate.Text & "', 105) WHERE (labnum='" & tlabnum.Text & "')")
                    Me.tlabnum.Focus()
                    bersih()
                ElseIf result = DialogResult.No Then
                    tlabnum.Focus()
                    Return
                End If
            End If
        Else
            Dim result As Integer = MetroMessageBox.Show(Me, "Data tidak ditemukan!. Periksa kembali Lab Number yang anda input", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            If result = DialogResult.OK Then
                Me.tlabnum.Focus()
            End If
        End If
    End Sub

    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click
        ''check/memastikan data LabNum yang ada di sample Receipt
        If _isBOFAND("receipt", "labnum", tlabnum.Text) = True Then
            ''TAMPILKAN DATA DI LABEL
            tTestDate.Text = Today.ToString(LabelDate1.Text)

            Dim controls As New Dictionary(Of String, Control) From {
                {"id", Lreqnum},
                {"variety", Lvariety},
                {"farmer", Lfarmer},
                {"location", LLocationg},
                {"harvest", Lharvest},
                {"job", Ljob}
            }
            ReadDataFromDatabase(tlabnum.Text, controls)

            ''menentukan apakah nanti ini data baru atau data yang diperbaharui
            If _isBOFAND("[spl_return]", "labnum", tlabnum.Text) = False Then
                'MetroPanel2.Enabled = False
                Btn_save.Enabled = True
                Btn_del.Enabled = False

                Btn_save.Text = "Save"
                Btn_save.Focus()
            Else
                ''exekusi data yang di perbaharui
                Dim tgljln As Date = _DataToValueDate("SELECT [test_date] FROM [spl_return] WHERE [labnum]='" & tlabnum.Text & "'")
                tTestDate.Text = tgljln.ToString("dd-MM-yyyy")
                Dim result As Integer = MetroMessageBox.Show(Me, "Data sudah pernah di Upload pada tanggal " + tgljln.ToString("dd-MM-yyyy") + " . Apakan anda ingin memperbaharui tanggal?", "Sample Return HCP", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                If result = DialogResult.Yes Then
                    ''menampilkan data ke texbox dengan textButtonSave menjadi Update
                    'MetroPanel2.Enabled = True
                    Btn_save.Enabled = True
                    Btn_del.Enabled = True
                    Btn_save.Text = "Update"
                    Me.tTestDate.Focus()
                ElseIf result = DialogResult.No Then
                    bersih()
                    MetroPanel2.Enabled = False
                    Btn_save.Text = "Save"
                    tlabnum.Focus()
                    Return
                End If
            End If
        Else
            Dim result As Integer = MetroMessageBox.Show(Me, "Data tidak ditemukan!. Periksa kembali Lab Number yang anda input", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.None, 211)
            If result = DialogResult.OK Then
                Me.tlabnum.Focus()
            End If
        End If
    End Sub

    Private Sub tlabnum_KeyDown(sender As Object, e As KeyEventArgs) Handles tlabnum.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnFind_Click(sender, e)
            tTestDate.Focus()
        End If
    End Sub

    Private Sub tTestDate_KeyDown(sender As Object, e As KeyEventArgs) Handles tTestDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Btn_save.Enabled Then
                Btn_save_Click(sender, e)
            Else
                BtnFind_Click(sender, e)
            End If

        End If
    End Sub

    Private Sub CheckReturnHCP_Load(sender As Object, e As EventArgs) Handles Me.Load
        tTestDate.Text = Today.ToString(LabelDate1.Text)
        Btn_save.Enabled = False
        Btn_del.Enabled = False
    End Sub

    Private Sub Btn_del_Click(sender As Object, e As EventArgs) Handles Btn_del.Click
        Dim result As Integer = MetroMessageBox.Show(Me, "Apakan anda ingin menghapus Sample Return HCP Lab Number " + tlabnum.Text + " ?", "Sample Return HCP", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, 211)
        If result = DialogResult.OK Then
            _RunSQL("DELETE [spl_return] WHERE (labnum='" & tlabnum.Text & "') ")
            bersih()
        End If
    End Sub

    Private Sub tlabnum_GotFocus(sender As Object, e As EventArgs) Handles tlabnum.GotFocus
        tlabnum.SelectAll()
    End Sub

    Private Sub Btn_save_KeyDown(sender As Object, e As KeyEventArgs) Handles Btn_save.KeyDown
        If e.KeyCode = Keys.Enter Then
            Btn_save_Click(sender, e)
            tlabnum.Focus()
        End If
    End Sub
End Class