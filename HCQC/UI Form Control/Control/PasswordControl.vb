Imports System.Data.SqlClient

Public Class PasswordControl
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim StrEncPass1, StrEncPass2 As String
        If Not String.IsNullOrEmpty(tpass1.Text) And Not String.IsNullOrEmpty(tpass2.Text) Then
            StrEncPass1 = Encrypt(tpass1.Text)
            StrEncPass2 = Encrypt(tpass2.Text)
            If StrEncPass1 = StrEncPass2 Then

                Dim query As String = String.Empty
                query &= "UPDATE [dbo].[login] SET [pass]="
                query &= "                     @colPass WHERE [id]=@colID  "

                Using conn As New SqlConnection("Data Source=10.15.13.91\SQLEXPRESS;Initial CataLog=HCQC_server;User ID=admin;Password=administrator")
                    Using comm As New SqlCommand()
                        With comm
                            .Connection = conn
                            .CommandType = CommandType.Text
                            .CommandText = query
                            .Parameters.AddWithValue("@colPass", StrEncPass1)
                            .Parameters.AddWithValue("@colID", login.Luserid.Text)
                        End With
                        Try
                            conn.Open()
                            comm.ExecuteNonQuery()
                            conn.Close()
                            MetroMessageBox.Show(Me, "Success Change Password", "Profile", MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                            Me.Close()
                        Catch ex As SqlException
                            MetroMessageBox.Show(Me, "Troble error Change Password", "Profile", MessageBoxButtons.OK, MessageBoxIcon.None, 211)
                        End Try
                    End Using
                End Using
                '_RunSQL_nomsgbox("UPDATE [dbo].[login] SET [pass]='" & StrEncPass1 & "' WHERE [id]=" & login.Luserid.Text & "")
            Else
                MetroMessageBox.Show(Me, "Password not match")
                tpass1.Text = ""
                tpass1.Text = ""
            End If
        Else
            MetroMessageBox.Show(Me, "The password must not be blank")
        End If
    End Sub

    Private Sub PasswordControl_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

End Class