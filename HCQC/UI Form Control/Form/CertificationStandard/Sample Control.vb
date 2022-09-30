Imports System.Globalization

Public Class Sample_Control
    Sub bersih()
        tVariety.Text = "..."
        tnomnl.Text = "..."
        tlotref.Text = "..."
        tharvest.Text = "..."
        tweight.Text = "..."
        tscope.Text = "..."
    End Sub

    Public jenis, Vstring As String
    Public Vtimes As Integer

    Public Sub Perulangan()
        'Penentuan banyak Bulan berikutnya untuk di Test Ulang
        'DENGAN VARIABEL "Vtime" sebagai acuan
        Vstring = Microsoft.VisualBasic.Left(tVariety.Text, 2)
        If (Vstring <> "SC") And (Vstring <> "WM") Then
            Vtimes = 3
        Else
            If (Microsoft.VisualBasic.Left(tVariety.Text, 2) = "SC") Then
                'mengabil value bulan berikutnya pada database
                Vtimes = Val(_DataToValue("SELECT times FROM plot WHERE (variety LIKE '" & Vstring & "%')"))
            ElseIf tVariety.Text = "WM-1002" Or tVariety.Text = "WM-1012" Or tVariety.Text = "WM-1017" Or tVariety.Text = "WM-1029" Or tVariety.Text = "WM-1032" Then
                Vtimes = Val(_DataToValue("SELECT times FROM plot WHERE (variety LIKE '" & Vstring & "%')"))
            Else
                Vtimes = 3
            End If
        End If
    End Sub

    Public Sub FunctionUpdate()
        Perulangan()
        Try
            Dim tgltest As Date = ttestdate.Text
            Dim sql As String = ""
            If _isBOFAND("receipt", "labnum", tlabnum.Text) = True Then
                If _isBOF("periodic_schedule", "labnum", tlabnum.Text) = False Then
                    _RunSQL("INSERT INTO periodic_schedule ([id_request]
                                                            ,[id_login]
                                                            ,[labnum]
                                                            ,[test_date]
                                                            ,[time]) VALUES ('" & Lreqnum.Text & "','" & login.Luserid.Text & "','" & tlabnum.Text & "', '" & tgltest.ToString("yyyy-MM-dd") & "', " & Vtimes & " )")
                    Me.tlabnum.Focus()
                Else
                    Dim tgljln As Date = _DataToValueDate("SELECT [test_date] FROM [periodic_schedule] WHERE [labnum]='" & tlabnum.Text & "'")
                    tgljln.ToString("dd-MM-yyyy")
                    Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data sudah pernah di Upload pada tanggal " + tgljln.ToString("dd-MM-yyyy") + " . Apakan anda ingin memperbaharui tanggal Test Sample???", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                    If result = DialogResult.Yes Then
                        _RunSQL("UPDATE periodic_schedule SET id_request='" & Lreqnum.Text & "',id_login='" & login.Luserid.Text & "',test_date='" & tgltest.ToString("yyyy-MM-dd") & "', time=" & Vtimes & " WHERE (labnum='" & tlabnum.Text & "') AND id_request='" & Lreqnum.Text & "'")
                        Me.tlabnum.Focus()
                        bersih()
                    ElseIf result = DialogResult.No Then
                        bersih()
                    End If
                End If
            Else
                Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data tidak ditemukan!. Nomor Lab anda mungkin kurang tepat.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                If result = DialogResult.OK Then
                    Me.tlabnum.Focus()
                End If
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Error : " & ex.Message, Me.Text, MessageBoxButtons.OK, 211)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Sample_Control_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Show Format Date Time Seting on Personal Computer
        LabelDate1.Text = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern

        ttestdate.Text = Today.ToString(LabelDate1.Text)
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        FunctionUpdate()
    End Sub

    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click

        If _isBOFAND("receipt", "labnum", tlabnum.Text) = True Then
            Lreqnum.Text = _DataToValue("SELECT [id] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
            tVariety.Text = _DataToValue("SELECT [variety] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
            tlotref.Text = _DataToValue("SELECT [nojob] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
            tnomnl.Text = _DataToValue("SELECT [nomnl] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
            tscope.Text = _DataToValue("SELECT [scope] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
            tweight.Text = _DataToValue("SELECT [weight] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
            Dim tglhvs As Date = _DataToValueDate("SELECT [harvest] FROM [qc_confirm_view] WHERE (labnum='" & tlabnum.Text & "') ")

            tharvest.Text = tglhvs.ToString("dd-MM-yyyy")

            If _isBOF("periodic_schedule", "labnum", tlabnum.Text) = True Then
                Dim tgljln As Date = _DataToValueDate("SELECT [test_date] FROM periodic_schedule WHERE  (labnum= '" & tlabnum.Text & "')")
                tgljln.ToString("dd-MM-yyyy")
                MetroMessageBox.Show(Me, "Data '" & tVariety.Text & "' BERAT '" & tweight.Text & "' sudah pernah di Upload pada tanggal " + tgljln, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                ttestdate.Text = tgljln.ToString("dd-MM-yyyy")
            End If
        Else
            Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data tidak ditemukan!. Periksa kembali Lab Number yang anda input", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            If result = DialogResult.OK Then
                Me.tlabnum.Focus()
            End If
        End If

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            Dim sql As String = ""
            openDB()
            sql = "SELECT [labnum],[test_date]  FROM periodic_schedule WHERE (labnum= '" & tlabnum.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk mengkosongkan Tanggal Test pada No Lab" + tlabnum.Text, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
                If result = DialogResult.Yes Then
                    _RunSQL("DELETE [periodic_schedule] WHERE ([labnum]='" & tlabnum.Text & "')")
                    Me.tlabnum.Focus()
                ElseIf result = DialogResult.No Then
                    Me.tlabnum.Focus()
                End If
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Data tidak ditemukan!. Periksa kembali No Lab yang anda input" + tlabnum.Text, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, 211)
                Me.tlabnum.Focus()
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Error : " & ex.Message, Me.Text, MessageBoxButtons.OK, 211)
            Return
        Finally
            con.Close()
        End Try
    End Sub

    ''ShortCut Keyboard... ALT+X
    Private Sub Sample_Control_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.X AndAlso e.Alt) Then
            FunctionUpdate()
        End If
    End Sub

    Private Sub MetroLink3_Click(sender As Object, e As EventArgs) Handles MetroLink3.Click
        ttestdate.Text = Today
    End Sub

    'ShortCut Keyboard... do while key press Enter on Lab Number
    Private Sub tlabnum_KeyDown(sender As Object, e As KeyEventArgs) Handles tlabnum.KeyDown
        If ((e.KeyCode = Keys.Enter)) Then
            BtnFind_Click(sender, e)
        End If
    End Sub

End Class