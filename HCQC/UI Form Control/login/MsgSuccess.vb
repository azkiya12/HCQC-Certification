Imports System.ComponentModel

Public Class MsgSuccess
    Private WithEvents timer As New Timer()
    Private timerCount As Integer = 0

    Private Sub Success_Message_Control_Load(sender As Object, e As EventArgs) Handles Me.Load
        Fade_in(Me)
        BunifuFlatButton1.Select()

        ' Membuat instance timer
        timer = New Timer With {
            .Interval = 1000, ' Set interval timer ke 2000 ms (2 detik)
            .Enabled = False ' Mulai dengan timer nonaktif
            }

        timerCount = 5
        BunifuFlatButton1.Text = "OK (" & timerCount.ToString() & ")"
        timer.Start() ' Memulai timer

    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick

        timerCount -= 1
        BunifuFlatButton1.Text = "OK (" & timerCount.ToString() & ")"

        If timerCount = -1 Then
            ' Menjalankan fungsi button click
            BunifuFlatButton1_Click(sender, e)

            ' Menghentikan timer setelah menjalankan fungsi button click
            timer.Stop()
        End If

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
        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Space Then
            BunifuFlatButton1_Click(sender, e)
        End If
    End Sub
End Class