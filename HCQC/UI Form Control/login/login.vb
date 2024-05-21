Public Class login

    Private WithEvents timer As New Timer()
    Private timerCount As Integer = 0

    Private notifyIcon As NotifyIcon
    Dim Signin As New Signin With {
            .Dock = DockStyle.Fill
        }
    Dim Signup As New Signup With {
            .Dock = DockStyle.Fill
        }

    Public Sub BtnLoginShow_Click(sender As Object, e As EventArgs) Handles BtnLoginShow.Click

        If Not MetroPanel2.Controls.Contains(Signin) Then
            MetroPanel2.Controls.Remove(Signup)
            MetroPanel2.Controls.Add(Signin)
            Lfooter.Text = "Dont have a member"
            BtnLoginShow.Text = "Create Now"
            'Me.Size = New Size(592, 312)
        Else
            MetroPanel2.Controls.Remove(Signin)
            MetroPanel2.Controls.Add(Signup)
            Lfooter.Text = "Already a member"
            BtnLoginShow.Text = "Login"
            Me.Size = New Size(592, 377)
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles Me.Load
        'efek dari transparan ke solid view
        Fade_in(Me)
        MetroPanel2.Controls.Add(Signin)

        ' Membuat instance NotifyIcon
        notifyIcon = New NotifyIcon()
        notifyIcon.Icon = SystemIcons.Information

        ' Mengatur event handler untuk mouse click pada ikon notifikasi
        AddHandler notifyIcon.MouseClick, AddressOf NotifyIcon_MouseClick

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub

    Private Sub BunifuImageButton1_MouseEnter(sender As Object, e As EventArgs) Handles BunifuImageButton1.MouseEnter
        BunifuImageButton1.BackColor = Color.Red
    End Sub

    Private Sub BunifuImageButton1_MouseLeave(sender As Object, e As EventArgs) Handles BunifuImageButton1.MouseLeave
        BunifuImageButton1.BackColor = Color.Transparent
    End Sub

    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel1.Click

    End Sub

    Private Sub BunifuCustomLabel6_Click(sender As Object, e As EventArgs) Handles Laboutme.Click
        About_HCQC_aplication.Show()
    End Sub

    Private Sub Laboutme_MouseHover(sender As Object, e As EventArgs) Handles Laboutme.MouseHover
        Laboutme.BackColor = Color.FromName("MenuHighlight")

    End Sub

    Private Sub Laboutme_MouseLeave(sender As Object, e As EventArgs) Handles Laboutme.MouseLeave
        Laboutme.BackColor = Color.FromName("Transparent")

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
        ' Menampilkan notifikasi menggunakan BalloonTip
        notifyIcon.Visible = True
        notifyIcon.BalloonTipTitle = "Judul Notifikasi"
        notifyIcon.BalloonTipText = "Isi pesan notifikasi"
        notifyIcon.ShowBalloonTip(5000)

        ' Mengaktifkan timer untuk menyembunyikan ikon notifikasi setelah 5 detik
        'Timer.Start()
    End Sub

    Private Sub NotifyIcon_MouseClick(sender As Object, e As MouseEventArgs)
        ' Menghilangkan ikon notifikasi dari system tray
        notifyIcon.Visible = False
    End Sub
End Class