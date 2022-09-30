Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Signin
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim strEncPass1 As String
        strEncPass1 = Encrypt(tpass.Text)
        Try
            openDB()
            Using cmd As New SqlCommand("sp_Loginform", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = tusername.Text.Trim()
                cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = strEncPass1
                Dim r As SqlDataReader = cmd.ExecuteReader()
                ' If the SqlDataReader.Read returns true then there is a customer with that ID'
                If r.HasRows Then
                    r.Read()
                    Dim id As String = r.Item("id")
                    login.Luserid.Text = id
                    MsgSuccess.StartPosition = FormStartPosition.CenterParent
                    MsgSuccess.ShowDialog(Me)
                    _RunSQL_nomsgbox("UPDATE [dbo].[login] SET [status] =1 WHERE id='" & id & "'")
                    'global_form.Show()
                    MainForm.Show()
                    tpass.Clear()
                    login.Hide()
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Oops, Username or Password that's not the right. Please try again!", "Login", MessageBoxButtons.OK, 211)
                End If
            End Using
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Error Login: " & ex.Message, "Login", MessageBoxButtons.OK, 211)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Signin_Load(sender As Object, e As EventArgs) Handles Me.Load
        tpass.Clear()
    End Sub

    Private Sub tpass_KeyDown(sender As Object, e As KeyEventArgs) Handles tpass.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnlogin_Click(sender, e)
        End If
    End Sub

    Private Sub tusername_KeyDown(sender As Object, e As KeyEventArgs) Handles tusername.KeyDown
        If e.KeyCode = Keys.Enter Then
            tpass.Focus()
            tpass.SelectAll()
        End If
    End Sub

    Private Sub tpass_Validating(sender As Object, e As CancelEventArgs) Handles tpass.Validating

    End Sub
End Class
