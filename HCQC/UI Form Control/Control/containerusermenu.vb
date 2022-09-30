Public Class containerusermenu
    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        _RunSQL_nomsgbox("UPDATE [dbo].[login] SET [status] =0 WHERE id='" & login.Luserid.Text & "'")
        MainForm.Close()
    End Sub

    Private Sub BtnProfil_Click(sender As Object, e As EventArgs) Handles BtnProfil.Click
        Dim uc_inputCustomer As Form = New Input_Customer
        uc_inputCustomer.ShowDialog(MainForm)
    End Sub
End Class
