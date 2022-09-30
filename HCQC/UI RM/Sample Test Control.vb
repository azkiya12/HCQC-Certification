Imports MetroFramework

Public Class Sample_Test_Control

    Private Sub Sample_Test_Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.tnolab.Focus()
        Timer1.Start()
        Tdate.Text = Today.ToString("dd-MM-yyyy")
        tvgdate.Text = Today.ToString("dd-MM-yyyy")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        MetroLabel6.Text = TimeOfDay.ToString("h:mm:ss tt")
        MetroLabel7.Text = Today
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            Dim sql As String = ""
            openDB()
            sql = "Select no_lab,test_date  From rm_msk WHERE (no_lab= '" & tnolab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con) With {
                .CommandType = CommandType.Text,
                .CommandText = sql
            }
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                If IsDBNull(dread.Item("test_date")) Then
                    _RunSQL("UPDATE rm_msk SET test_date='" & CDate(Tdate.Text) & "' WHERE (no_lab='" & tnolab.Text & "')")
                    Me.tnolab.Focus()
                Else
                    Dim tgljln As Date = dread.Item("test_date")
                    tgljln.ToString("dd-MM-yyyy")
                    Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data sudah pernah di Upload pada tanggal " + tgljln.ToString("dd-MM-yyyy") + " . Apakan anda ingin memperbaharui tanggal Test Sample???", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                    If result = DialogResult.Yes Then
                        _RunSQL("UPDATE rm_msk SET test_date='" & CDate(Tdate.Text) & "' WHERE (no_lab='" & tnolab.Text & "')")
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

    Private Sub MetroTile1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        Try
            Dim sql As String = ""
            openDB()
            sql = "Select * From rm_msk WHERE (no_lab= '" & tnolab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                If IsDBNull(dread.Item("test_date")) Then
                    tvariety.Text = dread.Item("variety")
                    tfarmer.Text = dread.Item("farmer")
                    tlokasi.Text = dread.Item("lokasi")
                    Dim tglhvs As Date = dread.Item("hv_dt")
                    tDatehvs.Text = tglhvs.ToString("dd-MM-yyyy")
                    tweight.Text = dread.Item("weight")

                    btnEdit.Enabled = True
                Else
                    Dim tgljln As Date = dread.Item("test_date")
                    tgljln.ToString("dd-MM-yyyy")
                    Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data '" & dread.Item("variety") & "' BERAT '" & dread.Item("weight") & "'sudah pernah di Upload pada tanggal " + tgljln.ToString("dd-MM-yyyy"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                    tvariety.Text = dread.Item("variety")
                    tfarmer.Text = dread.Item("farmer")
                    tlokasi.Text = dread.Item("lokasi")
                    Dim tglhvs As Date = dread.Item("hv_dt")
                    tDatehvs.Text = tglhvs.ToString("dd-MM-yyyy")
                    tweight.Text = dread.Item("weight")
                    Dim tgltes As Date = dread.Item("test_date")
                    Tdate.Text = tgltes.ToString("dd-MM-yyyy")
                    btnEdit.Enabled = True
                End If
            Else
                Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data tidak ditemukan!. Periksa kembali No Lab yang anda input", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                If result = DialogResult.OK Then
                    tnolab.Focus()
                End If
            End If

        Catch ex As Exception
            MetroMessageBox.Show(Me, "Error : " & ex.Message, Me.Text, MessageBoxButtons.OK, 211)
            Return
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub tnolab_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tnolab.TextChanged
        Me.AcceptButton = BtnCari

    End Sub

    Private Sub btnKosng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKosng.Click
        Try
            Dim sql As String = ""
            openDB()
            sql = "Select no_lab,test_date  From rm_msk WHERE (no_lab= '" & tnolab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk mengkosongkan Tanggal Test pada No Lab" + tnolab.Text, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
                If result = DialogResult.Yes Then
                    _RunSQL("UPDATE rm_msk SET test_date=null WHERE (no_lab='" & tnolab.Text & "')")
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

    Sub bersih()
       
        tvariety.Text = ""
        tfarmer.Text = ""
        tlokasi.Text = ""
        tDatehvs.Text = ""
        tweight.Text = ""

    End Sub

    '--------------------TabIndex Vigor---------------
    Private Sub btn_CekDateVg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CekDateVg.Click
        Try
            Dim sql As String = ""
            openDB()
            sql = "Select no_lab,vg_date  From rm_msk WHERE (no_lab= '" & tnolab2.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                If IsDBNull(dread.Item("vg_date")) Then
                    _RunSQL("UPDATE rm_msk SET vg_date='" & CDate(tvgdate.Text) & "' WHERE (no_lab='" & tnolab2.Text & "')")
                    Me.tnolab2.Focus()
                Else
                    Dim tglvg As Date = dread.Item("vg_date")
                    tglvg.ToString("dd-MM-yyyy")
                    Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data sudah pernah di Upload pada tanggal " + tglvg.ToString("dd-MM-yyyy") + " . Apakan anda ingin memperbaharui tanggal Vigor Test Sample???", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                    If result = DialogResult.Yes Then
                        _RunSQL("UPDATE rm_msk SET vg_date='" & CDate(tvgdate.Text) & "' WHERE (no_lab='" & tnolab2.Text & "')")
                        Me.tnolab2.Focus()
                        bersih()
                    ElseIf result = DialogResult.No Then
                        bersih()
                    End If
                End If
            Else
                Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data tidak ditemukan!. Nomor Lab anda mungkin kurang tepat.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                If result = DialogResult.OK Then
                    Me.tnolab2.Focus()
                End If
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Error : " & ex.Message, Me.Text, MessageBoxButtons.OK, 211)
            Return
        End Try
    End Sub

    Private Sub btn_KosongkanVg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_KosongkanVg.Click
        Try
            Dim sql As String = ""
            openDB()
            sql = "Select no_lab,vg_date  From rm_msk WHERE (no_lab= '" & tnolab2.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk mengkosongkan Tanggal Test pada No Lab" + tnolab.Text, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
                If result = DialogResult.Yes Then
                    _RunSQL("UPDATE rm_msk SET vg_date=null WHERE (no_lab='" & tnolab.Text & "')")
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

    Sub bersih2()

        tvariety2.Text = ""
        tfarmer2.Text = ""
        tlokasi2.Text = ""
        thvsdate2.Text = ""
        tweight2.Text = ""

    End Sub

    Private Sub MetroTile4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncari2.Click
        Try
            Dim sql As String = ""
            openDB()
            sql = "Select * From rm_msk WHERE (no_lab= '" & tnolab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                If IsDBNull(dread.Item("vg_date")) Then
                    tvariety2.Text = dread.Item("variety")
                    tfarmer2.Text = dread.Item("farmer")
                    tlokasi2.Text = dread.Item("lokasi")
                    Dim tglhvs2 As Date = dread.Item("hv_dt")
                    thvsdate2.Text = tglhvs2.ToString("dd-MM-yyyy")
                    tweight2.Text = dread.Item("weight")

                    btn_CekDateVg.Enabled = True
                Else
                    Dim tgljln2 As Date = dread.Item("vg_date")
                    tgljln2.ToString("dd-MM-yyyy")
                    Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data '" & dread.Item("variety") & "' BERAT '" & dread.Item("weight") & "'sudah pernah di Upload pada tanggal " + tgljln2.ToString("dd-MM-yyyy"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                    tvariety2.Text = dread.Item("variety")
                    tfarmer2.Text = dread.Item("farmer")
                    tlokasi2.Text = dread.Item("lokasi")
                    Dim tglhvs2 As Date = dread.Item("hv_dt")
                    thvsdate2.Text = tglhvs2.ToString("dd-MM-yyyy")
                    tweight2.Text = dread.Item("weight")
                    Dim tgltes2 As Date = dread.Item("vg_date")
                    tvgdate.Text = tgltes2.ToString("dd-MM-yyyy")
                    btnEdit.Enabled = True
                End If
            Else
                Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data tidak ditemukan!. Periksa kembali No Lab yang anda input", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                If result = DialogResult.OK Then
                    tnolab2.Focus()
                End If
            End If

        Catch ex As Exception
            MetroMessageBox.Show(Me, "Error : " & ex.Message, Me.Text, MessageBoxButtons.OK, 211)
            Return
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub tnolab2_FormClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub tnolab2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tnolab2.TextChanged
        Me.AcceptButton = btncari2
    End Sub

End Class