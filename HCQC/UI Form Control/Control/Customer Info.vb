Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Customer_Info
    Dim TextClick As Boolean
    Private Sub Customer_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TAddInfo.BackColor = Input_Customer.BackColor
        Tname.Text = _DataToValue("SELECT COALESCE(name , '') As name FROM [HCQC_server].[dbo].[login] WHERE [id]='" & login.Luserid.Text & "'")
        Tlahir.Text = _DataToValue("SELECT COALESCE([tempat_lahir], '') As tempat_lahir FROM [HCQC_server].[dbo].[login] WHERE [id]='" & login.Luserid.Text & "'")
        ttgllahir.Value = _DataToValue("SELECT COALESCE([tgl_lahir], '') As tgl_lahir  FROM [HCQC_server].[dbo].[login] WHERE [id]='" & login.Luserid.Text & "'")

        TCompany.Text = _DataToValue("SELECT COALESCE([dept], '') As dept FROM [HCQC_server].[dbo].[login] WHERE [id]='" & login.Luserid.Text & "'")
        TJabatan.Text = _DataToValue("SELECT COALESCE([jabatan], '') As dept FROM [HCQC_server].[dbo].[login] WHERE [id]='" & login.Luserid.Text & "'")
        TPendidikan.Text = _DataToValue("SELECT COALESCE([pendidikan], '') As pendidikan FROM [HCQC_server].[dbo].[login] WHERE [id]='" & login.Luserid.Text & "'")
        TPhone.Text = _DataToValue("SELECT COALESCE([phone], '') As phone FROM [HCQC_server].[dbo].[login] WHERE [id]='" & login.Luserid.Text & "'")
        Talamat.Text = _DataToValue("SELECT COALESCE([alamat], '') As alamat FROM [HCQC_server].[dbo].[login] WHERE [id]='" & login.Luserid.Text & "'")
        TAddInfo.Text = _DataToValue("SELECT COALESCE([keterangan], '') As keterangan FROM [HCQC_server].[dbo].[login] WHERE [id]='" & login.Luserid.Text & "'")

        TUser_name.Text = _DataToValue("SELECT COALESCE([username], '') As username FROM [HCQC_server].[dbo].[login] WHERE [id]='" & login.Luserid.Text & "'")
        Temail.Text = _DataToValue("SELECT COALESCE([email], '') As email FROM [HCQC_server].[dbo].[login] WHERE [id]='" & login.Luserid.Text & "'")

    End Sub

    Private Sub MetroPanel1_MouseEnter(sender As Object, e As EventArgs) Handles MetroPanel1.MouseEnter, TAddInfo.MouseEnter
        MetroPanel1.BackColor = Color.Blue
    End Sub

    Private Sub MetroPanel1_MouseLeave(sender As Object, e As EventArgs) Handles MetroPanel1.MouseLeave, TAddInfo.MouseLeave
        If TextClick = False Then
            MetroPanel1.BackColor = Color.FromArgb(218, 220, 224)
        End If
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TAddInfo.Click
        TextClick = True
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TAddInfo.LostFocus
        TextClick = False
    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As CancelEventArgs) Handles TAddInfo.Validating
        If TextClick = True Then
            MetroPanel1.BackColor = Color.Blue
        Else
            MetroPanel1.BackColor = Color.FromArgb(218, 220, 224)
        End If
    End Sub

    Function _isBOFuniq(ByVal table As String, ByVal field As String, ByVal whereValue As Object, ByVal iduser As String) As Boolean
        'Gunakan fungsi ini untuk mengecek data ada atau tidak , Contoh :
        'If _isBOF("NamaField", "NamaTable", "Nilai") = False Then
        '    MsgBox("Barang tidak ada")
        'Else
        '    MsgBox("Barang Ada")
        'End If

        Dim p As Integer
        p = _DataToValue("Select count(" & field & ") from " & table & " Where " & field & " = '" & whereValue & "' and [id]<>" & iduser & "")
        If 0 < p Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim Title As String = "Profile Update"
        If Not String.IsNullOrEmpty(TUser_name.Text) Then
            If _isBOFuniq("[login]", "username", TUser_name.Text, login.Luserid.Text) = False Then
                If Not String.IsNullOrEmpty(Tname.Text) Then
                    If Not String.IsNullOrEmpty(Temail.Text) Then
                        If IsValidEmailAddress(Temail.Text) = True Then
                            If _isBOFuniq("[login]", "[email]", Temail.Text, login.Luserid.Text) = False Then
                                Dim query As String = String.Empty
                                query &= "UPDATE [dbo].[login] "
                                query &= "SET [username] = @colusername
                                                ,[email] = @colemail
                                                ,[name] = @colname
                                                ,[tempat_lahir] = @coltempatlahir
                                                ,[tgl_lahir]= @coltgllahir
                                                ,[alamat] = @colalamat
                                                ,[pendidikan] = @colpendidikan
                                                ,[dept] = @coldept
                                                ,[jabatan] = @coljabatan
                                                ,[phone] = @colphone
                                                ,[keterangan] = @colketerangan "
                                query &= " WHERE [id]=@colID"

                                Using conn As New SqlConnection("Data Source=10.15.13.91\SQLEXPRESS;Initial CataLog=HCQC_server;User ID=admin;Password=administrator")
                                    Using comm As New SqlCommand()
                                        With comm
                                            .Connection = conn
                                            .CommandType = CommandType.Text
                                            .CommandText = query
                                            .Parameters.AddWithValue("@colusername", TUser_name.Text)
                                            .Parameters.AddWithValue("@colemail", Temail.Text)
                                            .Parameters.AddWithValue("@colname", Tname.Text)
                                            .Parameters.AddWithValue("@coltempatlahir", Tlahir.Text)
                                            .Parameters.Add("@coltgllahir", SqlDbType.DateTime).Value = Format(DateValue(ttgllahir.Value), "yyyy/MM/dd")
                                            .Parameters.AddWithValue("@colalamat", Talamat.Text)
                                            .Parameters.AddWithValue("@colpendidikan", TPendidikan.Text)
                                            .Parameters.AddWithValue("@coldept", TCompany.Text)
                                            .Parameters.AddWithValue("@coljabatan", TJabatan.Text)
                                            .Parameters.AddWithValue("@colphone", TPhone.Text)
                                            .Parameters.AddWithValue("@colketerangan", TAddInfo.Text)
                                            .Parameters.AddWithValue("@colID", login.Luserid.Text)
                                        End With
                                        Try
                                            conn.Open()
                                            comm.ExecuteNonQuery()
                                            MetroMessageBox.Show(Me, "Success Change Password", "Profile", MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                                        Catch ex As SqlException
                                            MetroMessageBox.Show(Me, ex.Message & " Troble error Change Password", "Profile", MessageBoxButtons.OK, MessageBoxIcon.None, 211)
                                        End Try
                                    End Using
                                End Using
                            Else
                                MetroMessageBox.Show(Me, "Email already used. try another one", Title, 211)
                                Temail.BorderColorFocused = Color.Red
                            End If
                        Else
                            MetroMessageBox.Show(Me, "Email vailed to confirmation", Title, 211)
                            Temail.Select()
                            Temail.BorderColorFocused = Color.Red
                        End If
                    Else
                        MetroMessageBox.Show(Me, "Request Email", Title, 211)
                    End If
                Else
                    MetroMessageBox.Show(Me, "Request Full Name", Title, 211)
                    Tname.BorderColorFocused = Color.Red
                End If
            Else
                MetroMessageBox.Show(login, "Fill Username and must be uniq. Try again please ", Title, 211)
                TUser_name.BorderColorFocused = Color.Red
            End If
        Else
            MetroMessageBox.Show(Me, "Enter Username. Try again please ", Title, 211)
            TUser_name.BorderColorFocused = Color.Red
        End If

    End Sub

    Private Sub BtnChangePass_Click(sender As Object, e As EventArgs) Handles BtnChangePass.Click
        PasswordControl.ShowDialog(Me)
    End Sub
End Class

