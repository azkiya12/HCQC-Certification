Public Class Check_in_Sample

    ''-------Close Button Clik---Back to Page 8 (Home)--------
    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        NavigationFrame1.SelectedPage = NavigationPage8
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        NavigationFrame1.SelectedPage = NavigationPage8
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        NavigationFrame1.SelectedPage = NavigationPage8
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        NavigationFrame1.SelectedPage = NavigationPage8
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        NavigationFrame1.SelectedPage = NavigationPage8
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        NavigationFrame1.SelectedPage = NavigationPage8
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        NavigationFrame1.SelectedPage = NavigationPage8
    End Sub

    Private Sub LinkRafactionTest_Click(sender As Object, e As EventArgs) Handles LinkRafactionTest.Click
        NavigationFrame1.SelectedPage = NavigationPage2
    End Sub

    Private Sub BunifuFlatButton10_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton10.Click
        NavigationFrame1.SelectedPage = NavigationPage8
    End Sub

    Private Sub BunifuFlatButton11_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton11.Click
        NavigationFrame1.SelectedPage = NavigationPage8
    End Sub


    ''-------Button Clik go to Target Title Menu Page--------
    Private Sub LinkViability_Click(sender As Object, e As EventArgs) Handles LinkViability.Click
        NavigationFrame1.SelectedPage = NavigationPage5
        CheckInVia1.bersih()
        CheckInVia1.tlabnumVia.Text = ""
    End Sub

    Private Sub LinkReturnQC_Click(sender As Object, e As EventArgs) Handles LinkReturnQC.Click
        NavigationFrame1.SelectedPage = NavigationPage6
        CheckOutQC1.bersih()
        CheckOutQC1.tlabnumOutQC.Text = ""
    End Sub

    Private Sub LinkReceiptHCP_Click(sender As Object, e As EventArgs) Handles LinkReceiptHCP.Click
        NavigationFrame1.SelectedPage = NavigationPage7
        CheckReturnHCP1.bersih()
        CheckReturnHCP1.tlabnum.Text = ""
        CheckReturnHCP1.Btn_del.Enabled = False
        CheckReturnHCP1.Btn_save.Text = "Save"
    End Sub

    Private Sub LinkMoistureTest_Click_1(sender As Object, e As EventArgs) Handles LinkMoistureTest.Click
        NavigationFrame1.SelectedPage = NavigationPage3
        CheckInKa1.Bersihka()
        CheckInKa1.TLabnumKa.Text = ""
    End Sub

    Private Sub LinkPurityTest_Click(sender As Object, e As EventArgs) Handles LinkPurityTest.Click
        NavigationFrame1.SelectedPage = NavigationPage4
        CheckInPur1.bersihPur()
        CheckInPur1.tlabnumPur.Text = ""
    End Sub

    Private Sub LinkGerminationTest_Click(sender As Object, e As EventArgs) Handles LinkGerminationTest.Click
        'check Test Germination
        NavigationFrame1.SelectedPage = NavigationPage1
        CheckInGer1.bersihGer()
        CheckInGer1.tlabnumGer.Text = ""
    End Sub

    Private Sub LinkVigor_Click(sender As Object, e As EventArgs) Handles LinkVigor.Click
        'check out germination
        NavigationFrame1.SelectedPage = NavigationPage9
        CheckInVigor1.bersihGer()
        CheckInVigor1.tlabnumGer.Text = ""
    End Sub

    Private Sub Link1Count_Click(sender As Object, e As EventArgs) Handles Link1Count.Click
        'check in vigor
        NavigationFrame1.SelectedPage = NavigationPage11
        CheckIn1Count1.bersihGer()
        CheckIn1Count1.tlabnumGer.Text = ""
    End Sub

End Class