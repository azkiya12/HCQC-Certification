Imports MetroFramework

Public Class Sample_Test_Control_G

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            Dim sql As String = ""
            openDB()
            sql = "Select no_lab,test_date  From wip_msk WHERE (no_lab= '" & tnolab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                If IsDBNull(dread.Item("test_date")) Then
                    _RunSQL("UPDATE wip_msk SET test_date='" & CDate(Tdate.Text) & "' WHERE (no_lab='" & tnolab.Text & "')")
                    Me.tnolab.Focus()
                Else
                    Dim tgljln As Date = dread.Item("test_date")
                    tgljln.ToString("dd-MM-yyyy")
                    Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data sudah pernah di Upload pada tanggal " + tgljln.ToString("dd-MM-yyyy") + " . Apakan anda ingin memperbaharui tanggal Test Sample???", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                    If result = DialogResult.Yes Then
                        _RunSQL("UPDATE wip_msk SET test_date='" & CDate(Tdate.Text) & "' WHERE (no_lab='" & tnolab.Text & "')")
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

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        Try
            Dim sql As String = ""
            openDB()
            sql = "Select no_lab,test_date  From wip_msk WHERE (no_lab= '" & tnolab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk mengkosongkan Tanggal Test pada No Lab" + tnolab.Text, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
                If result = DialogResult.Yes Then
                    _RunSQL("UPDATE wip_msk SET test_date=null WHERE (no_lab='" & tnolab.Text & "')")
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

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari1.Click
        Try
            Dim sql As String = ""
            openDB()
            sql = "Select * From wip_msk WHERE (no_lab= '" & tnolab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                If IsDBNull(dread.Item("test_date")) Then
                    Dim tglmsk As Date = dread.Item("Dtqc")

                    tnojob.Text = dread.Item("nojob")
                    tcls.Text = dread.Item("class")
                    tvarety.Text = dread.Item("variety")
                    Dim tglhvs As Date = dread.Item("hv_dt")
                    tdatehvs.Text = tglhvs.ToString("dd-MM-yyyy")
                    tnomnl.Text = dread.Item("nomnl")
                    tweight.Text = dread.Item("weight")

                    btnEdit.Enabled = True
                Else
                    Dim tgljln As Date = dread.Item("test_date")
                    tgljln.ToString("dd-MM-yyyy")
                    Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data '" & dread.Item("variety") & "' BERAT '" & dread.Item("weight") & "'sudah pernah di Upload pada tanggal " + tgljln.ToString("dd-MM-yyyy"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                    tnojob.Text = dread.Item("nojob")
                    tcls.Text = dread.Item("class")
                    tvarety.Text = dread.Item("variety")
                    Dim tglhvs As Date = dread.Item("hv_dt")
                    tdatehvs.Text = tglhvs.ToString("dd-MM-yyyy")
                    tnomnl.Text = dread.Item("nomnl")
                    tweight.Text = dread.Item("weight")
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

    Private Sub Sample_Test_Control_G_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
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

    Private Sub tnolab_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tnolab.TextChanged
        Me.AcceptButton = btnCari1
    End Sub

    Sub bersih()

        tvarety.Text = ""
        tnomnl.Text = ""
        tnojob.Text = ""
        tcls.Text = ""
        tDatehvs.Text = ""
        tweight.Text = ""
    End Sub
End Class