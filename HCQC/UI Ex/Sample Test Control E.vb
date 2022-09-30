Imports MetroFramework

Public Class Sample_Test_Control_E
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            Dim sql As String = ""
            openDB()
            sql = "Select no_lab,test_date  From extnl_msk WHERE (no_lab= '" & tnolab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                If IsDBNull(dread.Item("test_date")) Then
                    _RunSQL("UPDATE extnl_msk SET test_date='" & CDate(Tdate.Text) & "' WHERE (no_lab='" & tnolab.Text & "')")
                    Me.tnolab.Focus()
                Else
                    Dim tgljln As Date = dread.Item("test_date")
                    tgljln.ToString("dd-MM-yyyy")
                    Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data sudah pernah di Upload pada tanggal " + tgljln.ToString("dd-MM-yyyy") + " . Apakan anda ingin memperbaharui tanggal Test Sample???", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                    If result = DialogResult.Yes Then
                        _RunSQL("UPDATE extnl_msk SET test_date='" & CDate(Tdate.Text) & "' WHERE (no_lab='" & tnolab.Text & "')")
                        Me.tnolab.Focus()
                        bersih()
                    ElseIf result = DialogResult.No Then
                        bersih()
                    End If
                End If
            Else
                Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data tidak ditemukan!. Nomor Lab anda mungkin kurang tepat.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                If result = DialogResult.OK Then
                    Me.tnolab.Focus()
                End If
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Error : " & ex.Message, Me.Text, MessageBoxButtons.OK, 211)
            Return
        End Try
    End Sub
    Private Sub MetroTile1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari1.Click
        Try
            Dim sql As String = ""
            openDB()
            sql = "Select * From extnl_msk WHERE (no_lab= '" & tnolab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                If IsDBNull(dread.Item("test_date")) Then
                    Dim tglmsk As Date = dread.Item("Dtqc")

                    tvariety.Text = dread.Item("variety")
                    tnojob.Text = dread.Item("nojob")
                    tdatehvs.Text = dread.Item("hv_dt")
                    tweight.Text = dread.Item("weightA")


                    btnEdit.Enabled = True
                Else
                    Dim tgljln As Date = dread.Item("test_date")
                    tgljln.ToString("dd-MM-yyyy")
                    Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data '" & dread.Item("variety") & "' BERAT '" & dread.Item("weightA") & "'sudah pernah di Upload pada tanggal " + tgljln.ToString("dd-MM-yyyy"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                    tnojob.Text = dread.Item("nojob")
                    tvariety.Text = dread.Item("variety")
                    tdatehvs.Text = dread.Item("hv_dt")
                    tweight.Text = dread.Item("weightA")
                    Dim tgltes As Date = dread.Item("test_date")
                    Tdate.Text = tgltes.ToString("dd-MM-yyyy")
                    btnEdit.Enabled = True
                End If
            Else
                Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data tidak ditemukan!. Periksa kembali No Lab yang anda input", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                If result = DialogResult.OK Then
                    Me.tnolab.Focus()
                End If
            End If

        Catch ex As Exception
            MetroMessageBox.Show(Me, "Error : " & ex.Message, Me.Text, MessageBoxButtons.OK, 211)
            Return
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Sample_Test_Control_FG_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub Sample_Test_Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.tnolab.Focus()
        Timer1.Start()
        Tdate.Text = Today.ToString("dd-MM-yyy")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        MetroLabel6.Text = TimeOfDay.ToString("h:mm:ss tt")
        MetroLabel7.Text = Today
    End Sub

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKosong.Click
        Try
            Dim sql As String = ""
            openDB()
            sql = "Select no_lab,test_date  From extnl_msk WHERE (no_lab= '" & tnolab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk mengkosongkan Tanggal Test pada No Lab" + tnolab.Text, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
                If result = DialogResult.Yes Then
                    _RunSQL("UPDATE extnl_msk SET test_date=null WHERE (no_lab='" & tnolab.Text & "')")
                    Me.tnolab.Focus()
                ElseIf result = DialogResult.No Then
                    Me.tnolab.Focus()
                End If
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Data tidak ditemukan!. Periksa kembali No Lab yang anda input" + tnolab.Text, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, 211)
                Me.tnolab.Focus()
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Error : " & ex.Message, Me.Text, MessageBoxButtons.OK, 211)
            Return
        End Try
    End Sub

    Private Sub tnolab_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tnolab.TextChanged
        Me.AcceptButton = btnCari1
    End Sub

    Sub bersih()
        tvariety.Text = ""
        tnojob.Text = ""
        tdatehvs.Text = ""
        tweight.Text = ""
    End Sub
End Class