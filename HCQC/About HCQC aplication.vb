Public Class About_HCQC_aplication

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        Clipboard.SetText(MetroLink1.Text)
    End Sub

    Private Sub MetroButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton2.Click
        Clipboard.SetText("www.facebook.com/azkiya_amala1")
    End Sub

    Private Sub About_HCQC_aplication_Load(sender As Object, e As EventArgs) Handles Me.Load
        LabelStatus.Text = LicenseManager.LicenseStatus
    End Sub

End Class