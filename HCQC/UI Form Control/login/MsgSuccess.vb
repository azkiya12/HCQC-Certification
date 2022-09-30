Public Class MsgSuccess
    Private Sub Success_Message_Control_Load(sender As Object, e As EventArgs) Handles Me.Load
        Fade_in(Me)
        BunifuFlatButton1.Select()
    End Sub

    Private Sub BunifuFormFadeTransition1_TransitionEnd(sender As Object, e As EventArgs) Handles BunifuFormFadeTransition1.TransitionEnd
        Timer1.Start()
        PictureBox1.Enabled = True
        Label1.Enabled = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Enabled = False
        Timer1.Stop()
        Label1.Enabled = False
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Me.Close()
    End Sub

    Sub Form1_KeyPress(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Space Then
            BunifuFlatButton1_Click(sender, e)
        End If
    End Sub
End Class