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

                    AfterUserLogin()

                    r.Read()
                    Dim id As String = r.Item("id")
                    login.Luserid.Text = id

                    MsgSuccess.ShowDialog()
                    _RunSQL_nomsgbox("UPDATE [dbo].[login] SET [status] =1 WHERE id='" & id & "'")

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

    Private Async Sub AfterUserLogin()
        ' Panggil fungsi untuk mengecek localDB lisensi setelah login
        Dim result As (Boolean, Integer) = LicenseManager.CheckLicenseValidity
        Dim isValid As Boolean = result.Item1

        If Not isValid Then
            OpenLicenseKeyForm()
        End If

        'Periodic check to seatable
        Dim resultPeriodic As (Boolean, String, Integer) = Await LicenseManager.CheckLicensePeriodic
        If resultPeriodic.Item3 = 200 Then
            If Not resultPeriodic.Item1 Then
                MessageBox.Show("Your license has expired or is invalid. Please reactivate.", "Validation Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                OpenLicenseKeyForm()
            End If
        End If
    End Sub

    Sub OpenLicenseKeyForm()
        ' Jika lisensi tidak valid, tampilkan form LicenseKey
        Dim licenseForm As New LicenseKey()

        ' Tampilkan form LicenseEntryKeyForm sebagai dialog (user tidak bisa melanjutkan tanpa validasi lisensi)
        Dim resultLicense As DialogResult = licenseForm.ShowDialog()

        ' Jika form ditutup tanpa aktivasi (misalnya user menekan tombol "X"), tutup aplikasi
        If resultLicense = DialogResult.Cancel Then
            Environment.Exit(0)
        End If
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
End Class
