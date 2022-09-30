Imports System.Configuration
Imports System.Data.SqlClient

Public Class Signup
    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles Me.Load
        'mengambil record dari database ke combobox
        _ComboData("SELECT [namelevel] From [HCQC_server].[dbo].[login_level] where [id]!=5", Me.tuserlevel)
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Dim StrEncPass1, StrEncPass2 As String


        If Not String.IsNullOrEmpty(tusername.Text) Then
            If _isBOF("[login]", "username", tusername.Text) = False Then
                If Not String.IsNullOrEmpty(tfullname.Text) Then
                    If Not String.IsNullOrEmpty(temail.Text) Then
                        If IsValidEmailAddress(temail.Text) = True Then
                            If _isBOF("[login]", "[email]", temail.Text) = False Then
                                If Not String.IsNullOrEmpty(tuserlevel.Text) Then
                                    If Not String.IsNullOrEmpty(tpass.Text) And Not String.IsNullOrEmpty(trepass.Text) Then
                                        StrEncPass1 = Encrypt(tpass.Text)
                                        StrEncPass2 = Encrypt(trepass.Text)
                                        If StrEncPass1 = StrEncPass2 Then
                                            openDB()
                                            Using cmd As New SqlCommand("sp_CreateUserLogin", con)
                                                cmd.CommandType = CommandType.StoredProcedure
                                                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = tusername.Text.Trim()
                                                cmd.Parameters.Add("@fullname", SqlDbType.VarChar).Value = tfullname.Text.Trim()
                                                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = temail.Text.Trim()
                                                cmd.Parameters.Add("@userlevel", SqlDbType.VarChar).Value = _DataToValue("SELECT id FROM login_level WHERE namelevel='" & tuserlevel.Text & "'")
                                                cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = StrEncPass1
                                                con.Open()
                                                Dim o As Object = cmd.ExecuteScalar()
                                                If o IsNot Nothing Then
                                                    Dim id As String = o.ToString()
                                                    login.Luserid.Text = id
                                                End If
                                                con.Close()
                                            End Using
                                            MsgSuccess.StartPosition = FormStartPosition.CenterParent
                                            MsgSuccess.ShowDialog(Me)
                                            login.BtnLoginShow_Click(sender, e)
                                        Else
                                            MetroMessageBox.Show(Me, "Entered password not same", Me.MetroLabel2.Text, 211)
                                            tpass.Select()
                                        End If
                                    Else
                                        MetroMessageBox.Show(Me, "The password must not be blank")
                                    End If
                                Else
                                    MetroMessageBox.Show(Me, "Choose one user level", Me.MetroLabel2.Text, 211)
                                    'tuserlevel.WithError = True
                                End If
                            Else
                                MetroMessageBox.Show(Me, "Email already used. try another one", Me.MetroLabel2.Text, 211)
                                temail.WithError = True
                            End If
                        Else
                            MetroMessageBox.Show(Me, "Email vailed to confirmation", Me.MetroLabel2.Text, 211)
                            temail.Select()
                            temail.WithError = True
                        End If
                    Else
                        MetroMessageBox.Show(Me, "Request Email", Me.MetroLabel2.Text, 211)
                    End If
                Else
                    MetroMessageBox.Show(Me, "Request Full Name", Me.MetroLabel2.Text, 211)
                    tfullname.WithError = True
                End If
            Else
                MetroMessageBox.Show(login, "Fill Username and must be uniq. Try again please ", Me.MetroLabel2.Text, 211)
                tusername.WithError = True
            End If
        Else
            MetroMessageBox.Show(Me, "Enter Username. Try again please ", Me.MetroLabel2.Text, 211)
            tusername.WithError = True
        End If

    End Sub

    Private Sub tusername_TextChanged(sender As Object, e As EventArgs) Handles tusername.TextChanged
        tusername.WithError = False
    End Sub

    Private Sub temail_TextChanged(sender As Object, e As EventArgs) Handles temail.TextChanged
        temail.WithError = False
    End Sub

    Private Sub tfullname_TextChanged(sender As Object, e As EventArgs) Handles tfullname.TextChanged
        tfullname.WithError = False
    End Sub
End Class
