Imports System.Data.SqlClient

Public Class Confirmation
    Public Function AutoNumber()
        'Try
        openDB()
        Dim sql As String = ""
        Dim strTam As String = ""
        Dim strVal As String = ""
        Dim no1, StrLabnum As String

        no1 = "QC" & Year(Today) & Date.Today.ToString("MM")
        sql = "SELECT labnum FROM qc_confirm WHERE labnum LIKE '" & no1 & "%' ORDER BY labnum DESC"
        cmd = New SqlCommand(sql, con)
        dread = cmd.ExecuteReader
        If dread.Read() Then
            strTam = Microsoft.VisualBasic.Right(dread.Item("labnum"), 4)
        Else
            StrLabnum = "QC" & Year(Today) & Date.Today.ToString("MM") & "0001"
        End If
        con.Close()
        strVal = Val(strTam) + 1
        StrLabnum = "QC" & Year(Today) & Date.Today.ToString("MM") & Mid("000", 1, 4 - strVal.Length) & strVal
        Return StrLabnum
        'Catch ex As Exception
        '    MsgBox("Terjadi Error : " & ex.Message)
        'Finally

        'End Try
    End Function

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

    Private Sub Confirmation_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Try
            Dim vlab As String
            Dim vcheckstate As Short = 0
            vlab = AutoNumber()

            If CheckAccept.Checked = True Then
                vcheckstate = 1
            ElseIf CheckReject.Checked = True Then
                vcheckstate = 2
            Else
                If MetroMessageBox.Show(Me, "The confirmation option Aprove or Reject button has not been selected", "Confirmation", MessageBoxButtons.RetryCancel, 211) = DialogResult.Cancel Then
                    Me.Close()
                End If
                Return
            End If

            If _isBOF("receipt", "labnum", LabelLabNumber.Text) = False Then
                If _DataToValue("SELECT [status_confirm] FROM [qc_confirm] WHERE [id_request]=" & Lreqnum.Text & "").ToString <> vcheckstate.ToString Or IsDBNull(_DataToValue("SELECT [status_confirm] FROM [qc_confirm] WHERE [id_request]=" & Lreqnum.Text & "")) Then
                    Using cmd As New SqlCommand("sp_QcConfirm", con)
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.AddWithValue("@Id_request", Lreqnum.Text)
                        cmd.Parameters.Add("@Id_login", SqlDbType.Int).Value = login.Luserid.Text
                        cmd.Parameters.Add("@Tgl_confirm", SqlDbType.DateTime).Value = Now
                        cmd.Parameters.Add("@Status", SqlDbType.Bit).Value = 1
                        cmd.Parameters.Add("@Labnum", SqlDbType.VarChar).Value = vlab
                        cmd.Parameters.Add("@StatusConf", SqlDbType.Int).Value = vcheckstate
                        cmd.Parameters.Add("@remark", SqlDbType.VarChar).Value = TRemarkReject.Text

                        con.Open()
                        cmd.ExecuteScalar()
                        Me.DialogResult = DialogResult.OK
                    End Using
                End If
            Else
                MetroMessageBox.Show(Me, "Nomor Lab ini sudah di Terima QC Laboatorium")
                Me.Close()
            End If
            ''StoredProcedure sp_QcConfirm akan melakukan INSERT atau UPDATE secara automatis
        Catch ex As Exception
            MetroMessageBox.Show(Me, "erorr  " & ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub Confirmation_CursorChanged(sender As Object, e As EventArgs) Handles Me.CursorChanged

    End Sub
End Class