Imports System.Data.SqlClient

Public Class Conclution

    Private Sub CheckAccept_VisibleChanged(sender As Object, e As EventArgs) Handles CheckAccept.VisibleChanged, CheckAccept.OnChange
        If CheckAccept.Checked = True Then
            CheckReject.Checked = False
        End If
    End Sub

    Private Sub CheckReject_VisibleChanged(sender As Object, e As EventArgs) Handles CheckReject.VisibleChanged, CheckReject.OnChange
        If CheckReject.Checked = True Then
            CheckAccept.Checked = False
        End If
    End Sub

    Private Sub Conclution_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim vcheckstate As Boolean
        If CheckAccept.Checked = True Then
            vcheckstate = 1
        ElseIf CheckReject.Checked = True Then
            vcheckstate = 0
        Else
            If MetroMessageBox.Show(Me, "The confirmation option has not been selected", "Confirmation", MessageBoxButtons.RetryCancel, 211) = DialogResult.Cancel Then
                Me.Close()
            End If
            Return
        End If

        openDB()
        Using cmd As New SqlCommand("sp_SplConclu", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Id_login", SqlDbType.Int).Value = login.Luserid.Text
            cmd.Parameters.AddWithValue("@Id_request", Lreqnum.Text)
            cmd.Parameters.AddWithValue("@labnum", Llabnum.Text)
            cmd.Parameters.Add("@Date_conclu", SqlDbType.DateTime).Value = Now
            cmd.Parameters.Add("@Status", SqlDbType.Bit).Value = vcheckstate
            cmd.Parameters.AddWithValue("@notes", TRemark.Text)
            cmd.ExecuteScalar()
            con.Close()
            Me.DialogResult = DialogResult.OK
        End Using

    End Sub

    Private Sub Conclution_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Llabnum.Text <> "..." Then
            Lreqnum.Text = _DataToValue("SELECT [id_request] FROM [HCQC_server].[dbo].[qc_confirm] WHERE [labnum]='" & Llabnum.Text & "'")
            TRemark.Text = _DataToValue("SELECT [remark] FROM [HCQC_server].[dbo].[spl_conclu] WHERE [id_request]='" & Lreqnum.Text & "'")

            Dim strstatus = _DataToValue("Select [status] From [spl_conclu] where [id_request]='" & Lreqnum.Text & "'")
            If strstatus = "False" Then
                CheckReject.Checked = True
            ElseIf strstatus = "True" Then
                CheckAccept.Checked = True
            End If
        End If
    End Sub
End Class