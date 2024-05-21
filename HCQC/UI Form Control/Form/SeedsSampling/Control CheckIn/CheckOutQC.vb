Imports System.Data.SqlClient

Public Class CheckOutQC

    Sub sampleretunDialogShow()
        Dim strlabnum, strrequest, strstatus As String
        strlabnum = Me.tlabnumOutQC.Text.ToUpper
        strrequest = _DataToValue("SELECT [id_request] FROM [receipt] WHERE [labnum]='" & strlabnum & "'")
        Dim SampleReturnQc = New Sample_Return
        SampleReturnQc.LabelLabNumber.Text = strlabnum
        SampleReturnQc.Lreqnum.Text = strrequest
        SampleReturnQc.Lvariety.Text = _DataToValue("SELECT [variety] From [qc_confirm_viewer] WHERE [id]=" & strrequest & "")
        SampleReturnQc.Lfarmer.Text = _DataToValue("Select [farmer] From [qc_confirm_viewer] Where [id]=" & strrequest & "")
        SampleReturnQc.Ljob.Text = _DataToValue("Select [nojob] from [qc_confirm_viewer] Where [id]=" & strrequest & "")
        SampleReturnQc.Lharvest.Text = _DataToValueDate("Select [harvest] From [qc_confirm_viewer] Where [id]=" & strrequest & "").ToString("dd-MM-yyyy")
        SampleReturnQc.LLocation.Text = _DataToValue("Select [location] from [qc_confirm_viewer] Where [id]=" & strrequest & "")

        strstatus = _DataToValue("Select [status] From [qc_kembali] where [id_request]=" & strrequest & "")
        If strstatus = "False" Then
            SampleReturnQc.CheckReject.Checked = True
        ElseIf strstatus = "True" Then
            SampleReturnQc.CheckAccept.Checked = True
        End If

        If Btn_save_QC.Text = "Edit" Then
            SampleReturnQc.BtnSave.Text = "Update"
        Else
            SampleReturnQc.BtnSave.Text = "Save"
        End If

        If SampleReturnQc.ShowDialog(Me) = DialogResult.OK Then
            SampleReturnQc.Close()
            Me.tlabnumOutQC.SelectAll()
        End If
    End Sub

    Private Sub Btn_save_QC_Click(sender As Object, e As EventArgs) Handles Btn_save_QC.Click
        Dim find_variety, find_request As String
        find_variety = _DataToValue("SELECT [variety] FROM qc_confirm_viewer WHERE [labnum]='" & tlabnumOutQC.Text & "'")
        find_request = _DataToValue("SELECT [id] FROM qc_confirm_viewer WHERE [labnum]='" & tlabnumOutQC.Text & "'")

        If String.IsNullOrEmpty(Trim(tlabnumOutQC.Text)) Then
            MetroMessageBox.Show(Me, "Pastikan Lab Number di input dengan benar", "Check Out Sample QC", MessageBoxButtons.OK, MessageBoxIcon.Warning, 211)
        Else
            If find_variety = LvarietyGer.Text And find_request = LreqnumGer.Text Then
                sampleretunDialogShow()
            Else
                MetroMessageBox.Show(Me, "Pastikan data tampilan sesuai dengan Lab Number.", "Check Out Sample QC", MessageBoxButtons.OK, MessageBoxIcon.Warning, 211)
            End If
        End If

    End Sub

    Private Sub CheckOutQC_Load(sender As Object, e As EventArgs) Handles Me.Load
        bersih()
    End Sub

    Sub bersih()
        tTestDateGer.Text = ""
        LreqnumGer.Text = ""
        LvarietyGer.Text = ""
        LfarmerGer.Text = ""
        LjobGer.Text = ""
        LLocationgGer.Text = ""
        LharvestGer.Text = ""
        Lstatus.Text = ""
        Btn_save_QC.Text = ""
        Btn_save_QC.Text = "Save"
        Btn_del_QC.Enabled = False
        Btn_save_QC.Enabled = False
    End Sub

    Private Sub BtnFindOutQC_Click(sender As Object, e As EventArgs) Handles BtnFindOutQC.Click
        Dim strlabnum, strrequest As String
        strlabnum = Me.tlabnumOutQC.Text
        strrequest = _DataToValue("SELECT [id_request] FROM [receipt] WHERE [labnum]='" & strlabnum & "'")
        ''check/memastikan data yang ada di sample Receipt
        If _isBOFAND("receipt", "labnum", tlabnumOutQC.Text) = True Then

            Dim controls As New Dictionary(Of String, Control) From {
                    {"variety", LvarietyGer},
                    {"farmer", LfarmerGer},
                    {"location", LLocationgGer},
                    {"harvest", LharvestGer},
                    {"job", LjobGer}
                }
            ReadDataFromDatabase(tlabnumOutQC.Text, controls)

            ''Check apakah data sudah ada apa belum
            ''megirimpesan kepastian dari pada tindakan user dan memberitahu data sudah masuk apa belum
            If _isBOF("[qc_kembali]", "[id_request]", strrequest) = False Then
                ''Jika data belum pernah masuk
                tTestDateGer.Text = Today.ToString(LabelDate1.Text)
                LreqnumGer.Text = strrequest

                Lstatus.Text = _DataToValue("SELECT CASE WHEN [quick_ra]=1 THEN 'LULUS' ELSE 'TOLAK' END AS [status] FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [id] = '" & strrequest & "'")

                Btn_save_QC.Text = "Save"
                Btn_save_QC.Enabled = True
                Btn_del_QC.Enabled = False
                Btn_save_QC.Focus()
            Else
                ''megirimpesan kepastian dari pada tindakan user dan memberitahu data sudah masuk apa belum
                ''Jika data sudah pernah masuk
                MetroMessageBox.Show(Me, "Lab Number sudah pernah di Check OUT QC", "Check Out Sample QC", MessageBoxButtons.OK, MessageBoxIcon.Question, 211)
                tTestDateGer.Text = _DataToValueDate("SELECT [tgl_kirim] FROM [HCQC_server].[dbo].[qc_kembali] WHERE [id_request] ='" & strrequest & "'")
                LreqnumGer.Text = strrequest

                Lstatus.Text = _DataToValue("SELECT CASE WHEN [quick_ra]=1 THEN 'LULUS' ELSE 'TOLAK' END AS [status] FROM [HCQC_server].[dbo].[qc_confirm_viewer] WHERE [id] = '" & strrequest & "'")

                Btn_save_QC.Text = "Edit"
                Btn_save_QC.Enabled = True
                Btn_del_QC.Enabled = True
                Btn_save_QC.Focus()
            End If
        Else
            MetroMessageBox.Show(Me, "Lab Number belum pernah diterima di penerimaan sample", "Check Out Sample QC", MessageBoxButtons.OK, MessageBoxIcon.Warning, 211)
        End If
    End Sub

    Private Sub tlabnumOutQC_GotFocus(sender As Object, e As EventArgs) Handles tlabnumOutQC.GotFocus
        tlabnumOutQC.SelectAll()
    End Sub

    Private Sub tlabnumOutQC_KeyDown(sender As Object, e As KeyEventArgs) Handles tlabnumOutQC.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnFindOutQC_Click(sender, e)
            'bersih()
            'tlabnumOutQC.Focus()
        End If
    End Sub

    Private Sub Btn_save_QC_KeyDown(sender As Object, e As KeyEventArgs) Handles Btn_save_QC.KeyDown
        If e.KeyCode = Keys.Enter Then
            Btn_save_QC_Click(sender, e)
        End If
    End Sub

    Private Sub Btn_del_QC_Click(sender As Object, e As EventArgs) Handles Btn_del_QC.Click
        Dim strlabnum, strrequest As String
        strlabnum = Me.tlabnumOutQC.Text
        strrequest = _DataToValue("SELECT [id_request] FROM [receipt] WHERE [labnum]='" & strlabnum & "'")
        Dim result As Integer = MetroMessageBox.Show(Me, "Apakan anda ingin menghapus CHECK OUT Lab Number " + tlabnumOutQC.Text + " ?", "Check OUT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, 211)
        If result = DialogResult.OK Then
            _RunSQL("DELETE [qc_kembali] WHERE ( [id_request]='" & strrequest & "') ")
            openDB()
            Using cmd As New SqlCommand("sp_QcReturnDel", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Id_request", strrequest)
                cmd.ExecuteScalar()
                con.Close()
            End Using
        End If
    End Sub

End Class