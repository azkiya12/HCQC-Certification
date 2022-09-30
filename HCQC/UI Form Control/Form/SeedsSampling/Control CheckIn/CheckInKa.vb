Public Class CheckInKa
    Private Sub BtnSaveKa_Click(sender As Object, e As EventArgs) Handles BtnSaveKa.Click
        Dim strIdreq As Integer
        ''check/memastikan data yang ada di sample Receipt
        If _isBOFAND("receipt", "labnum", TLabnumKa.Text) = True Then
            ''menentukan apakah nanti ini data baru atau data yang diperbaharui
            If _isBOFAND2("periodic_schedule", "labnum", TLabnumKa.Text, "[test_on]", LabelMoi.Text) = False Then
                ''megirimpesan kepastian dari pada tindakan user
                Dim result As Integer = MetroMessageBox.Show(Me, "Check in Lab Number" + TLabnumKa.Text, "Moisture Test Check IN", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
                If result = DialogResult.Yes Then
                    ''exekusi data baru
                    ''mengambil nomor Identitas Sample Request
                    strIdreq = _DataToValue("SELECT id_request FROM receipt WHERE labnum='" & TLabnumKa.Text & "'")
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
                               ,'" & TLabnumKa.Text & "'
                               ,'" & LabelMoi.Text & "'
                               ,GETDATE()
                               )")
                    Bersihka()
                    TLabnumKa.Focus()
                End If
            Else
                ''exekusi data yang di perbaharui
                Dim tgljln As Date = _DataToValueDate("SELECT [test_date] FROM [periodic_schedule] WHERE [labnum]='" & TLabnumKa.Text & "' AND [test_on]='" & LabelMoi.Text & "'")
                tgljln.ToString("dd-MM-yyyy")
                Dim result As Integer = MetroMessageBox.Show(Me, "Data " + TLabnumKa.Text + " sudah pernah di Check IN pada tanggal " + tgljln.ToString("dd-MM-yyyy") + " . Apakan anda ingin memperbaharui tanggal Test Sample?", "Moisture Test Check IN", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                If result = DialogResult.Yes Then
                    strIdreq = _DataToValue("SELECT id_request FROM receipt WHERE labnum='" & TLabnumKa.Text & "'")
                    _RunSQL("UPDATE periodic_schedule SET id_request='" & strIdreq & "',id_login='" & login.Luserid.Text & "',test_date=Convert(date, '" & TTestDateKa.Text & "', 120) WHERE (labnum='" & TLabnumKa.Text & "') AND [test_on]='" & LabelMoi.Text & "'")
                    Me.TLabnumKa.Focus()
                    bersihKa()
                ElseIf result = DialogResult.No Then
                    TLabnumKa.Focus()
                    Return
                End If
            End If
        Else
            Dim result As Integer = MetroMessageBox.Show(Me, "Data tidak ditemukan!. Periksa kembali Lab Number yang anda input", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            If result = DialogResult.OK Then
                Me.TLabnumKa.Focus()
            End If
        End If
    End Sub

    Private Sub BtnFindMoi_Click(sender As Object, e As EventArgs) Handles BtnFindMoi.Click
        ''check/memastikan data yang ada di sample Receipt
        If _isBOFAND("receipt", "labnum", TLabnumKa.Text) = True Then
            ''TAMPILKAN DATA DI LABEL
            TTestDateKa.Text = Today.ToString(LabelDate1.Text)
            LabelIdKa.Text = _DataToValue("SELECT [id] FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum] ='" & TLabnumKa.Text & "'")
            LabelVarietyKa.Text = _DataToValue("SELECT [variety] FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum] = '" & TLabnumKa.Text & "'")
            LabelFarmerKa.Text = _DataToValue("SELECT [farmer] FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum] = '" & TLabnumKa.Text & "'")
            LabelJobKa.Text = _DataToValue("SELECT CONCAT([nomnl], ' - ', [nojob]) FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum] = '" & TLabnumKa.Text & "'")
            LabelLocationKa.Text = _DataToValue("SELECT [location] FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum] = '" & TLabnumKa.Text & "'")
            LabelHarvestKa.Text = _DataToValueDate("SELECT [harvest] FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [labnum] = '" & TLabnumKa.Text & "'")

            ''menentukan apakah nanti ini data baru atau data yang diperbaharui
            If _isBOFAND2("periodic_schedule", "labnum", TLabnumKa.Text, "[test_on]", LabelMoi.Text) = False Then
                BtnSaveKa.Enabled = True
                BtnDelKa.Enabled = False
                BtnSaveKa.Text = "Save"
                'BtnSaveKa.Focus()
            Else
                ''exekusi data yang di perbaharui
                Dim tgljln As Date = _DataToValueDate("SELECT [test_date] FROM [periodic_schedule] WHERE [labnum]='" & TLabnumKa.Text & "' AND [test_on]='" & LabelMoi.Text & "'")
                TTestDateKa.Text = tgljln.ToString("dd-MM-yyyy")
                Dim result As Integer = MetroMessageBox.Show(Me, "Data sudah pernah di Upload pada tanggal " + tgljln.ToString("dd-MM-yyyy") + " . Apakan anda ingin memperbaharui tanggal Test Sample?", "Moisture Test Check IN", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                If result = DialogResult.Yes Then
                    BtnSaveKa.Enabled = True
                    BtnDelKa.Visible = True
                    BtnDelKa.Enabled = True
                    BtnSaveKa.Text = "Update"
                    'BtnSaveKa.Focus()
                ElseIf result = DialogResult.No Then
                    Bersihka()
                    TLabnumKa.Focus()
                    Return
                End If
            End If
        Else
            Dim result As Integer = MetroMessageBox.Show(Me, "Data tidak ditemukan!. Periksa kembali Lab Number yang anda input", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.None, 211)
            If result = DialogResult.OK Then
                Me.TLabnumKa.Focus()
            End If
        End If

    End Sub

    Private Sub tlabnumMoi_KeyDown(sender As Object, e As KeyEventArgs) Handles TLabnumKa.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnFindMoi_Click(sender, e)
            TTestDateKa.Focus()
        End If
    End Sub

    Private Sub TTestDateKa_KeyDown(sender As Object, e As KeyEventArgs) Handles TTestDateKa.KeyDown
        If e.KeyCode = Keys.Enter Then
            If BtnSaveKa.Enabled Then
                BtnSaveKa_Click(sender, e)
            Else
                BtnFindMoi_Click(sender, e)
            End If

        End If
    End Sub

    Sub Bersihka()
        TTestDateKa.Text = Today.ToString(LabelDate1.Text)
        LabelIdKa.Text = ""
        LabelVarietyKa.Text = ""
        LabelFarmerKa.Text = ""
        LabelJobKa.Text = ""
        LabelLocationKa.Text = ""
        LabelHarvestKa.Text = ""


        BtnSaveKa.Enabled = False
        BtnSaveKa.Text = "Save"
        BtnDelKa.Visible = False
        BtnDelKa.Enabled = False

    End Sub

    Private Sub BtnDelKa_Click(sender As Object, e As EventArgs) Handles BtnDelKa.Click
        Dim result As Integer = MetroMessageBox.Show(Me, "Apakan anda ingin menghapus Test Sample Moisture Test Lab Number " + TLabnumKa.Text + " ?", "Moisture Test Check IN", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, 211)
        If result = DialogResult.OK Then
            _RunSQL("DELETE periodic_schedule WHERE (labnum='" & TLabnumKa.Text & "') AND [test_on]='" & LabelMoi.Text & "'")
            Bersihka()
        End If
    End Sub

    Private Sub TLabnumKa_GotFocus(sender As Object, e As EventArgs) Handles TLabnumKa.GotFocus
        TLabnumKa.SelectAll()
    End Sub

    Private Sub CheckInKa_Load(sender As Object, e As EventArgs) Handles Me.Load
        TTestDateKa.Text = Today.ToString(LabelDate1.Text)
        BtnDelKa.Visible = False
        BtnSaveKa.Enabled = False
    End Sub
End Class