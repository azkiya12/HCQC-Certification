Public Class containermenu
    Private Sub BtnSampling_Click(sender As Object, e As EventArgs) Handles BtnSampling.Click
        If PnSampling.Visible = False Then
            BunifuTransition1.ShowSync(PnSampling, False, BunifuAnimatorNS.Animation.VertSlide)
        Else
            PnSampling.Visible = False
        End If
    End Sub

    Private Sub BtnInternal_Click(sender As Object, e As EventArgs) Handles BtnInternal.Click
        If PnInternal.Visible = False Then
            BunifuTransition1.ShowSync(PnInternal, False, BunifuAnimatorNS.Animation.VertSlide)
        Else
            PnInternal.Visible = False
        End If
    End Sub

    Private Sub BtnStandard_Click(sender As Object, e As EventArgs) Handles BtnStandard.Click
        If PnStandar.Visible = False Then
            BunifuTransition1.ShowSync(PnStandar, False, BunifuAnimatorNS.Animation.VertSlide)
        Else
            PnStandar.Visible = False
        End If
    End Sub

    Private Sub BtnQuality_Click(sender As Object, e As EventArgs) Handles BtnQuality.Click
        If PnMonitor.Visible = False Then
            BunifuTransition1.ShowSync(PnMonitor, False, BunifuAnimatorNS.Animation.VertSlide)
        Else
            PnMonitor.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
