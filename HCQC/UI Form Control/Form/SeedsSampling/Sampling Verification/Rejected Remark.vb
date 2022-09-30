Imports System.Data.SqlClient

Public Class Rejected_Remark

    Private Sub BtnSave2_Click(sender As Object, e As EventArgs) Handles BtnSave2.Click
        Try
            If _isBOF("receipt", "labnum", LabelLabNumber.Text) = False Then
                Using cmd As New SqlCommand("sp_QcConfirm", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@Id_request", Lreqnum.Text)
                    cmd.Parameters.Add("@Id_login", SqlDbType.Int).Value = login.Luserid.Text
                    cmd.Parameters.Add("@Tgl_confirm", SqlDbType.DateTime).Value = Now
                    cmd.Parameters.Add("@Status", SqlDbType.Bit).Value = 1
                    cmd.Parameters.Add("@Labnum", SqlDbType.VarChar).Value = DBNull.Value
                    cmd.Parameters.Add("@StatusConf", SqlDbType.Int).Value = 2  ''status 2 adalah Rejected
                    cmd.Parameters.Add("@remark", SqlDbType.VarChar).Value = TRemarkReject.Text

                    con.Open()
                    cmd.ExecuteScalar()
                    Me.DialogResult = DialogResult.OK
                End Using
            Else
                MetroMessageBox.Show(Me, "Nomor Lab ini sudah di Terima QC Laboatorium")
                Me.Close()
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, "erorr  " & ex.Message, Me.Text, 211)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub Rejected_Remark_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class