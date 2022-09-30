Imports System.Globalization
Imports System.Text.RegularExpressions
Imports MetroFramework
Imports MetroFramework.Forms
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommandBuilder
Imports System.Data

Public Class DayaTumbuhFG

    Private Sub btnCari2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari2.Click
        Dim sql As String = ""
        openDB()
       
        sql = "Select * From fg_vg WHERE (no_lab= '" & tnolab.Text & "') and (char='Normal Seedling (%)')"
        cmd = New SqlClient.SqlCommand(sql, con)
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        dread = cmd.ExecuteReader
        If dread.Read = True Then
            con.Close()
            openDB()
            sql = "Select * From fg_vg WHERE (no_lab= '" & tnolab.Text & "') and (char='Normal Seedling (%)')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                tNml1.Text = dread("t1").ToString
                tNml2.Text = dread("t2").ToString
                tNml3.Text = dread.Item("t3").ToString
                tNml4.Text = dread.Item("t4").ToString
                tNmlArg.Text = dread.Item("avrg").ToString
                tNmlPrc.Text = dread.Item("percn").ToString
            End If
            con.Close()
            openDB()
            sql = "Select * From fg_vg WHERE (no_lab= '" & tnolab.Text & "') and (char='Abnormal Seedling (%)')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                tAbNml1.Text = dread.Item("t1").ToString '("0,0")
                tAbNml2.Text = dread.Item("t2").ToString '("0,0")
                tAbNml3.Text = dread.Item("t3").ToString
                tAbNml4.Text = dread.Item("t4").ToString
                tAbNmlArg.Text = dread.Item("avrg").ToString
                tAbNmlPrc.Text = dread.Item("percn").ToString
            End If
            con.Close()
            openDB()
            sql = "Select * From fg_vg WHERE (no_lab= '" & tnolab.Text & "') and (char='Hard Seed (%)')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                tHd1.Text = dread.Item("t1").ToString
                tHd2.Text = dread.Item("t2").ToString
                tHd3.Text = dread.Item("t3").ToString
                tHd4.Text = dread.Item("t4").ToString
                tHdArg.Text = dread.Item("avrg").ToString
                tHdPrc.Text = dread.Item("percn").ToString
            End If
            con.Close()
            openDB()
            sql = "Select * From fg_vg WHERE (no_lab= '" & tnolab.Text & "') and (char='Fresh Seed (%)')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                tFrs1.Text = dread.Item("t1").ToString
                tFrs2.Text = dread.Item("t2").ToString
                tFrs3.Text = dread.Item("t3").ToString
                tFrs4.Text = dread.Item("t4").ToString
                tFrsArg.Text = dread.Item("avrg").ToString
                tFrsPrc.Text = dread.Item("percn").ToString
            End If
            con.Close()
            openDB()
            sql = "Select * From fg_vg WHERE (no_lab= '" & tnolab.Text & "') and (char='Dead Seed (%)')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                tDd1.Text = dread.Item("t1").ToString
                tDd2.Text = dread.Item("t2").ToString
                tDd3.Text = dread.Item("t3").ToString
                tDd4.Text = dread.Item("t4").ToString
                tDdArg.Text = dread.Item("avrg").ToString
                tDdPrc.Text = dread.Item("percn").ToString
            End If
            con.Close()
            openDB()
            sql = "Select * From fg_vg WHERE (no_lab= '" & tnolab.Text & "') and (char='Index Vigor (%)')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                tVg1.Text = dread.Item("t1").ToString
                tVg2.Text = dread.Item("t2").ToString
                tVg3.Text = dread.Item("t3").ToString
                tVg4.Text = dread.Item("t4").ToString
                tVgArg.Text = dread.Item("avrg").ToString
                tVgPrc.Text = dread.Item("percn").ToString
            End If
            con.Close()
            openDB()
            sql = "Select * From fg_vg WHERE (no_lab= '" & tnolab.Text & "') and (char='Germination (%)')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                tGm1.Text = dread.Item("t1").ToString
                tGm2.Text = dread.Item("t2").ToString
                tGm3.Text = dread.Item("t3").ToString
                tGm4.Text = dread.Item("t4").ToString
                tGmArg.Text = dread.Item("avrg").ToString
                tGmPrc.Text = dread.Item("percn").ToString
            End If
            con.Close()
            openDB()
            sql = "Select * From fg_id WHERE (no_lab= '" & tnolab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                tvariety.Text = dread.Item("variety")
                tnojob.Text = dread.Item("nojob")
                'tnomnl.Text = dread.Item("nomnl")
                Dim tgluji As Date = dread.Item("t_dt")
                Dim tglfist As Date = dread.Item("fs_c")
                Dim tglfinl As Date = dread.Item("fn_c")
                tgl_uji.Text = tgluji.ToString("dd-MM-yyyy")
                tgl_fs.Text = tglfist.ToString("dd-MM-yyyy")
                tgl_fn.Text = tglfinl.ToString("dd-MM-yyyy")
                tanalys.Text = dread.Item("analys")
                If Not dread.Item("gm").ToString = "" Then
                    If dread.Item("gm").ToString = "Between Paper" Then
                        ckbetwen.Checked = True
                    ElseIf dread.Item("gm").ToString = "Top of Paper" Then
                        cektop.Checked = True
                    ElseIf dread.Item("gm").ToString = "Pleated Paper" Then
                        tpleated.Checked = True
                    ElseIf dread.Item("gm").ToString = "Top of Sand" Then
                        ttopsand.Checked = True
                    ElseIf dread.Item("gm").ToString = "Sand" Then
                        tsand.Checked = True
                    End If
                Else
                    ckbetwen.Checked = False
                    cektop.Checked = False
                    tpleated.Checked = False
                    ttopsand.Checked = False
                    tsand.Checked = False
                End If
            End If
            btnSave.Enabled = False
            btnEdit.Enabled = True
            btnDelete.Enabled = True
        Else
            Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data tidak ditemukan!. Apakah anda ingin melanjutkan pencarian data?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
            If result = DialogResult.Yes Then
                tnolab.Focus()
            ElseIf result = DialogResult.No Then
                btnSave.Enabled = True
                btnEdit.Enabled = False
                btnDelete.Enabled = False
                tnolab.Focus()
            End If
        End If

        con.Close()
    End Sub

    Private Sub btncari1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncari1.Click
        Dim sql As String = ""
        openDB()
        sql = "Select * From fg_vg WHERE (no_lab= '" & tnolab.Text & "')"
        cmd = New SqlClient.SqlCommand(sql, con)
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        dread = cmd.ExecuteReader
        If dread.Read = False Then
            openDB()
            sql = "Select * From fg_id WHERE (no_lab= '" & tnolab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                tvariety.Text = dread.Item("variety")
                tnojob.Text = dread.Item("nojob")
            Else
                Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data tidak ditemukan!. No Lab. belum terdaftar di Peneriamaan Sampel Masuk!. Click 'Yes' untuk merubah No. Lab. Click 'No' untuk input data yang baru", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                If result = DialogResult.OK Then
                    Me.tnolab.Focus()
                ElseIf result = DialogResult.No Then
                    btnSave.Enabled = True
                    btnEdit.Enabled = False
                    btnDelete.Enabled = False
                    Me.tnolab.Focus()
                End If
            End If
        Else
            Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data sudah ada!. Apakah anda ingin melanjutkan pencarian data?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
            If result = DialogResult.Yes Then
                tnolab.Focus()
            ElseIf result = DialogResult.No Then
                btnSave.Enabled = True
                btnEdit.Enabled = False
                btnDelete.Enabled = False
                Me.tnolab.Focus()
            End If
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If tnolab.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "No. Lab harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tvariety.Focus()
        ElseIf tvariety.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Variety harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tnojob.Focus()
        ElseIf tnojob.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "No Job harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tnojob.Focus()
        ElseIf tanalys.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Analyst harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tanalys.Focus()
        ElseIf ckbetwen.Checked = False And cektop.Checked = False And tpleated.Checked = False And ttopsand.Checked = False And tsand.Checked = False Then
            MetroFramework.MetroMessageBox.Show(Me, "Methods harus dipilih!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            ckbetwen.Focus()
        Else
            Dim hrini As Date = Today
            Dim ck As Boolean = False
            Dim mtd As String = ""
            If ckbetwen.Checked = True Then
                mtd = ckbetwen.Text
            ElseIf cektop.Checked = True Then
                mtd = cektop.Text
            ElseIf tpleated.Checked = True Then
                mtd = tpleated.Text
            ElseIf ttopsand.Checked = True Then
                mtd = ttopsand.Text
            ElseIf tsand.Checked = True Then
                mtd = tsand.Text
            End If
            'Return
            _RunSQL("Update fg_id SET t_dt ='" & CDate(tgl_uji.Text) & "', fs_c ='" & CDate(tgl_fs.Text) & "', fn_c ='" & CDate(tgl_fn.Text) & "', analys ='" & tanalys.Text & "', gm ='" & mtd & "',vg_tgl_input='" & Now & "' WHERE (no_lab = '" & tnolab.Text & "')")

            openDB()
            Dim sqlvg As String
            Dim xvg As Integer
            For values As Integer = 1 To 7
                If values = 1 Then
                    'NRML
                    sqlvg = "Insert Into fg_vg(no_lab,char,t1,t2,t3,t4,avrg,percn) values('" & tnolab.Text & "','Normal Seedling (%)','" & Val(tNml1.Text) & "','" & Val(tNml2.Text) & "','" & Val(tNml3.Text) & "','" & Val(tNml4.Text) & "','" & Val(tNmlArg.Text) & "','" & Val(tNmlPrc.Text) & "')"
                    cmdvg = New SqlClient.SqlCommand(sqlvg, con)
                    xvg = cmdvg.ExecuteNonQuery
                ElseIf values = 2 Then
                    'AB NORML
                    sqlvg = "Insert Into fg_vg(no_lab,char,t1,t2,t3,t4,avrg,percn) values('" & tnolab.Text & "','Abnormal Seedling (%)','" & Val(tAbNml1.Text) & "','" & Val(tAbNml2.Text) & "','" & Val(tAbNml3.Text) & "','" & Val(tAbNml4.Text) & "','" & Val(tAbNmlArg.Text) & "','" & Val(tAbNmlPrc.Text) & "')"
                    cmdvg = New SqlClient.SqlCommand(sqlvg, con)
                    xvg = cmdvg.ExecuteNonQuery
                ElseIf values = 3 Then
                    ''VIGOR
                    sqlvg = "Insert Into fg_vg(no_lab,char,t1,t2,t3,t4,avrg,percn) values('" & tnolab.Text & "','Index Vigor (%)','" & Val(tVg1.Text) & "','" & Val(tVg2.Text) & "','" & Val(tVg3.Text) & "','" & Val(tVg4.Text) & "','" & Val(tVgArg.Text) & "','" & Val(tVgPrc.Text) & "')"
                    cmdvg = New SqlClient.SqlCommand(sqlvg, con)
                    xvg = cmdvg.ExecuteNonQuery
                ElseIf values = 4 Then
                    'HARD SED
                    sqlvg = "Insert Into fg_vg(no_lab,char,t1,t2,t3,t4,avrg,percn) values('" & tnolab.Text & "','Hard Seed (%)','" & Val(tHd1.Text) & "','" & Val(tHd2.Text) & "','" & Val(tHd3.Text) & "','" & Val(tHd4.Text) & "','" & Val(tHdArg.Text) & "','" & Val(tHdPrc.Text) & "')"
                    cmdvg = New SqlClient.SqlCommand(sqlvg, con)
                    xvg = cmdvg.ExecuteNonQuery
                ElseIf values = 5 Then
                    'FRESS
                    sqlvg = "Insert Into fg_vg(no_lab,char,t1,t2,t3,t4,avrg,percn) values('" & tnolab.Text & "','Fresh Seed (%)','" & Val(tFrs1.Text) & "','" & Val(tFrs2.Text) & "','" & Val(tFrs3.Text) & "','" & Val(tFrs4.Text) & "','" & Val(tFrsArg.Text) & "','" & Val(tFrsPrc.Text) & "')"
                    cmdvg = New SqlClient.SqlCommand(sqlvg, con)
                    xvg = cmdvg.ExecuteNonQuery
                ElseIf values = 6 Then
                    'DEAD
                    sqlvg = "Insert Into fg_vg(no_lab,char,t1,t2,t3,t4,avrg,percn) values('" & tnolab.Text & "','Dead Seed (%)','" & Val(tDd1.Text) & "','" & Val(tDd2.Text) & "','" & Val(tDd3.Text) & "','" & Val(tDd4.Text) & "','" & Val(tDdArg.Text) & "','" & Val(tDdPrc.Text) & "')"
                    cmdvg = New SqlClient.SqlCommand(sqlvg, con)
                    xvg = cmdvg.ExecuteNonQuery
                ElseIf values = 7 Then
                    'GERMIN
                    sqlvg = "Insert Into fg_vg(no_lab,char,t1,t2,t3,t4,avrg,percn) values('" & tnolab.Text & "','Germination (%)','" & Val(tGm1.Text) & "','" & Val(tGm2.Text) & "','" & Val(tGm3.Text) & "','" & Val(tGm4.Text) & "','" & Val(tGmArg.Text) & "','" & Val(tGmPrc.Text) & "')"
                    cmdvg = New SqlClient.SqlCommand(sqlvg, con)
                    xvg = cmdvg.ExecuteNonQuery
                End If
            Next
            con.Close()
            tnolab.Focus()
            'Bersihkan()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If tnolab.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "No. Lab harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tnolab.Focus()
        ElseIf tvariety.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Variety harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tvariety.Focus()
        ElseIf tnojob.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "No Job harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tnojob.Focus()
        Else
            Dim hrini As Date = Today
            Dim mtd As String = ""
            If ckbetwen.Checked = True Then
                mtd = ckbetwen.Text
            ElseIf cektop.Checked = True Then
                mtd = cektop.Text
            ElseIf tpleated.Checked = True Then
                mtd = tpleated.Text
            ElseIf ttopsand.Checked = True Then
                mtd = ttopsand.Text
            ElseIf tsand.Checked = True Then
                mtd = tsand.Text
            End If
            _RunSQL("Update fg_id SET t_dt ='" & CDate(tgl_uji.Text) & "', fs_c ='" & CDate(tgl_fs.Text) & "', fn_c ='" & CDate(tgl_fn.Text) & "', analys ='" & tanalys.Text & "', gm ='" & mtd & "', vg_tgl_input='" & Now & "' WHERE (no_lab = '" & tnolab.Text & "')")

            openDB()
            Dim sqlvg As String
            Dim xvg As Integer
            For values As Integer = 1 To 7
                If values = 1 Then
                    sqlvg = "Update fg_vg Set no_lab='" & tnolab.Text & "', t1='" & Val(tNml1.Text) & "',t2='" & Val(tNml2.Text) & "',t3='" & Val(tNml3.Text) & "',t4='" & Val(tNml4.Text) & "',avrg='" & Val(tNmlArg.Text) & "',percn='" & Val(tNmlPrc.Text) & "' Where (no_lab='" & tnolab.Text & "') And (char='Normal Seedling (%)')"
                    cmdvg = New SqlClient.SqlCommand(sqlvg, con)
                    xvg = cmdvg.ExecuteNonQuery
                ElseIf values = 2 Then
                    sqlvg = "Update fg_vg Set no_lab='" & tnolab.Text & "', t1='" & Val(tAbNml1.Text) & "',t2='" & Val(tAbNml2.Text) & "',t3='" & Val(tAbNml3.Text) & "',t4='" & Val(tAbNml4.Text) & "',avrg='" & Val(tAbNmlArg.Text) & "',percn='" & Val(tAbNmlPrc.Text) & "' Where (no_lab='" & tnolab.Text & "') And (char='Abnormal Seedling (%)')"
                    cmdvg = New SqlClient.SqlCommand(sqlvg, con)
                    xvg = cmdvg.ExecuteNonQuery
                ElseIf values = 3 Then
                    sqlvg = "Update fg_vg Set no_lab='" & tnolab.Text & "', t1='" & Val(tVg1.Text) & "',t2='" & Val(tVg2.Text) & "',t3='" & Val(tVg3.Text) & "',t4='" & Val(tVg4.Text) & "',avrg='" & Val(tVgArg.Text) & "',percn='" & Val(tVgPrc.Text) & "' Where (no_lab='" & tnolab.Text & "') And (char='Index Vigor (%)')"
                    cmdvg = New SqlClient.SqlCommand(sqlvg, con)
                    xvg = cmdvg.ExecuteNonQuery
                ElseIf values = 4 Then
                    sqlvg = "Update fg_vg Set no_lab='" & tnolab.Text & "', t1='" & Val(tHd1.Text) & "',t2='" & Val(tHd2.Text) & "',t3='" & Val(tHd3.Text) & "',t4='" & Val(tHd4.Text) & "',avrg='" & Val(tHdArg.Text) & "',percn='" & Val(tHdPrc.Text) & "' Where (no_lab='" & tnolab.Text & "') And (char='Hard Seed (%)')"
                    cmdvg = New SqlClient.SqlCommand(sqlvg, con)
                    xvg = cmdvg.ExecuteNonQuery
                ElseIf values = 5 Then
                    sqlvg = "Update fg_vg Set no_lab='" & tnolab.Text & "', t1='" & Val(tFrs1.Text) & "',t2='" & Val(tFrs2.Text) & "',t3='" & Val(tFrs3.Text) & "',t4='" & Val(tFrs4.Text) & "',avrg='" & Val(tFrsArg.Text) & "',percn='" & Val(tFrsPrc.Text) & "' Where (no_lab='" & tnolab.Text & "') And (char='Fresh Seed (%)')"
                    cmdvg = New SqlClient.SqlCommand(sqlvg, con)
                    xvg = cmdvg.ExecuteNonQuery
                ElseIf values = 6 Then
                    sqlvg = "Update fg_vg Set no_lab='" & tnolab.Text & "', t1='" & Val(tDd1.Text) & "',t2='" & Val(tDd2.Text) & "',t3='" & Val(tDd3.Text) & "',t4='" & Val(tDd4.Text) & "',avrg='" & Val(tDdArg.Text) & "',percn='" & Val(tDdPrc.Text) & "' Where (no_lab='" & tnolab.Text & "') And (char='Dead Seed (%)')"
                    cmdvg = New SqlClient.SqlCommand(sqlvg, con)
                    xvg = cmdvg.ExecuteNonQuery
                ElseIf values = 7 Then
                    sqlvg = "Update fg_vg Set no_lab='" & tnolab.Text & "', t1='" & Val(tGm1.Text) & "',t2='" & Val(tGm2.Text) & "',t3='" & Val(tGm3.Text) & "',t4='" & Val(tGm4.Text) & "',avrg='" & Val(tGmArg.Text) & "',percn='" & Val(tGmPrc.Text) & "' Where (no_lab='" & tnolab.Text & "') And (char='Germination (%)')"
                    cmdvg = New SqlClient.SqlCommand(sqlvg, con)
                    xvg = cmdvg.ExecuteNonQuery
                End If
            Next
            con.Close()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk menghapus data ini " + tnolab.Text, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
        If result = DialogResult.Yes Then
            _RunSQL("DELETE FROM fg_vg WHERE(no_lab = '" & tnolab.Text & "')")
            _RunSQL("Update fg_id SET t_dt =NULL, fs_c =NULL, fn_c =NULL, analys =NULL, gm ='', vg_tgl_input=NULL WHERE (no_lab = '" & tnolab.Text & "')")
            Me.tnolab.Focus()
            'MetroClear()
        ElseIf result = DialogResult.No Then
            Me.tnolab.Focus()
        End If
    End Sub

    Private Sub tNml1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tNml1.GotFocus
        Me.tNml1.SelectAll()
    End Sub

    Private Sub tNml2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tNml2.GotFocus
        Me.tNml2.SelectAll()
    End Sub

    Private Sub tNml3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tNml3.GotFocus
        Me.tNml3.SelectAll()
    End Sub

    Private Sub tNml4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tNml4.GotFocus
        Me.tNml4.SelectAll()
    End Sub

    Private Sub tNmlArg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tNml1.TextChanged, tNml2.TextChanged, tNml3.TextChanged, tNml4.TextChanged
        Dim ts1, ts2, ts3, ts4 As Decimal
        Try
            ts1 = Convert.ToDecimal(tNml1.Text)
        Catch
            ts1 = 0
        End Try
        Try
            ts2 = Convert.ToDecimal(tNml2.Text)
        Catch
            ts2 = 0
        End Try
        Try
            ts3 = Convert.ToDecimal(tNml3.Text)
        Catch
            ts3 = 0
        End Try
        Try
            ts4 = Convert.ToDecimal(tNml4.Text)
        Catch
            ts4 = 0
        End Try
        tNmlArg.Text = ((ts1 + ts2 + ts3 + ts4) / 4).ToString("00.00")

        tGm1.Text = tNml1.Text
        tGm2.Text = tNml2.Text
        tGm3.Text = tNml3.Text
        tGm4.Text = tNml4.Text
    End Sub

    Private Sub tAbNml1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tAbNml1.GotFocus
        Me.tAbNml1.SelectAll()
    End Sub

    Private Sub tAbNml2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tAbNml2.GotFocus
        Me.tAbNml2.SelectAll()
    End Sub

    Private Sub tAbNml3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tAbNml3.GotFocus
        Me.tAbNml3.SelectAll()
    End Sub

    Private Sub tAbNml4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tAbNml4.GotFocus
        Me.tAbNml4.SelectAll()
    End Sub

    Private Sub tAbNmlArg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tAbNml1.TextChanged, tAbNml2.TextChanged, tAbNml3.TextChanged, tAbNml4.TextChanged
        Dim ts1, ts2, ts3, ts4 As Decimal
        Try
            ts1 = Convert.ToDecimal(tAbNml1.Text)
        Catch
            ts1 = 0
        End Try
        Try
            ts2 = Convert.ToDecimal(tAbNml2.Text)
        Catch
            ts2 = 0
        End Try
        Try
            ts3 = Convert.ToDecimal(tAbNml3.Text)
        Catch
            ts3 = 0
        End Try
        Try
            ts4 = Convert.ToDecimal(tAbNml4.Text)
        Catch
            ts4 = 0
        End Try
        tAbNmlArg.Text = ((ts1 + ts2 + ts3 + ts4) / 4).ToString("00.00")
    End Sub

    Private Sub tHd1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tHd1.GotFocus
        Me.tHd1.SelectAll()
    End Sub

    Private Sub tHd2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tHd2.GotFocus
        Me.tHd2.SelectAll()
    End Sub

    Private Sub tHd3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tHd3.GotFocus
        Me.tHd3.SelectAll()
    End Sub

    Private Sub tHd4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tHd4.GotFocus
        Me.tHd4.SelectAll()
    End Sub

    Private Sub tHdArg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tHd1.TextChanged, tHd2.TextChanged, tHd3.TextChanged, tHd4.TextChanged
        Dim ts1, ts2, ts3, ts4 As Decimal
        Try
            ts1 = Convert.ToDecimal(tHd1.Text)
        Catch
            ts1 = 0
        End Try
        Try
            ts2 = Convert.ToDecimal(tHd2.Text)
        Catch
            ts2 = 0
        End Try
        Try
            ts3 = Convert.ToDecimal(tHd3.Text)
        Catch
            ts3 = 0
        End Try
        Try
            ts4 = Convert.ToDecimal(tHd4.Text)
        Catch
            ts4 = 0
        End Try
        tHdArg.Text = ((ts1 + ts2 + ts3 + ts4) / 4).ToString("00.00")
    End Sub

    Private Sub tFrs1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tFrs1.GotFocus
        Me.tFrs1.SelectAll()
    End Sub

    Private Sub tFrs2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tFrs2.GotFocus
        Me.tFrs2.SelectAll()
    End Sub

    Private Sub tFrs3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tFrs3.GotFocus
        Me.tFrs3.SelectAll()
    End Sub

    Private Sub tFrs4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tFrs4.GotFocus
        Me.tFrs4.SelectAll()
    End Sub

    Private Sub tFrsArg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tFrs1.TextChanged, tFrs2.TextChanged, tFrs3.TextChanged, tFrs4.TextChanged
        Dim ts1, ts2, ts3, ts4 As Decimal
        Try
            ts1 = Convert.ToDecimal(tFrs1.Text)
        Catch
            ts1 = 0
        End Try
        Try
            ts2 = Convert.ToDecimal(tFrs2.Text)
        Catch
            ts2 = 0
        End Try
        Try
            ts3 = Convert.ToDecimal(tFrs3.Text)
        Catch
            ts3 = 0
        End Try
        Try
            ts4 = Convert.ToDecimal(tFrs4.Text)
        Catch
            ts4 = 0
        End Try
        tFrsArg.Text = ((ts1 + ts2 + ts3 + ts4) / 4).ToString("00.00")
    End Sub

    Private Sub tDd1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tDd1.GotFocus
        Me.tDd1.SelectAll()
    End Sub

    Private Sub tDd2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tDd2.GotFocus
        Me.tDd2.SelectAll()
    End Sub

    Private Sub tDd3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tDd3.GotFocus
        Me.tDd3.SelectAll()
    End Sub

    Private Sub tDd4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tDd4.GotFocus
        Me.tDd4.SelectAll()
    End Sub

    Private Sub tDdArg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tDd1.TextChanged, tDd2.TextChanged, tDd3.TextChanged, tDd4.TextChanged
        Dim ts1, ts2, ts3, ts4 As Decimal
        Try
            ts1 = Convert.ToDecimal(tDd1.Text)
        Catch
            ts1 = 0
        End Try
        Try
            ts2 = Convert.ToDecimal(tDd2.Text)
        Catch
            ts2 = 0
        End Try
        Try
            ts3 = Convert.ToDecimal(tDd3.Text)
        Catch
            ts3 = 0
        End Try
        Try
            ts4 = Convert.ToDecimal(tDd4.Text)
        Catch
            ts4 = 0
        End Try
        tDdArg.Text = ((ts1 + ts2 + ts3 + ts4) / 4).ToString("00.00")
    End Sub

    Private Sub tVg1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tVg1.GotFocus
        Me.tVg1.SelectAll()
    End Sub

    Private Sub tVg2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tVg2.GotFocus
        Me.tVg2.SelectAll()
    End Sub

    Private Sub tVg3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tVg3.GotFocus
        Me.tVg3.SelectAll()
    End Sub

    Private Sub tVg4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tVg4.GotFocus
        Me.tVg4.SelectAll()
    End Sub

    Private Sub tVgArg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tVg1.TextChanged, tVg2.TextChanged, tVg3.TextChanged, tVg4.TextChanged
        Dim ts1, ts2, ts3, ts4 As Decimal
        Try
            ts1 = Convert.ToDecimal(tVg1.Text)
        Catch
            ts1 = 0
        End Try
        Try
            ts2 = Convert.ToDecimal(tVg2.Text)
        Catch
            ts2 = 0
        End Try
        Try
            ts3 = Convert.ToDecimal(tVg3.Text)
        Catch
            ts3 = 0
        End Try
        Try
            ts4 = Convert.ToDecimal(tVg4.Text)
        Catch
            ts4 = 0
        End Try
        tVgArg.Text = ((ts1 + ts2 + ts3 + ts4) / 4).ToString("00.00")
    End Sub

    Private Sub tGm1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tGm1.GotFocus
        Me.tGm1.SelectAll()
    End Sub

    Private Sub tGm2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tGm2.GotFocus
        Me.tGm2.SelectAll()
    End Sub

    Private Sub tGm3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tGm3.GotFocus
        Me.tGm3.SelectAll()
    End Sub

    Private Sub tGm4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tGm4.GotFocus
        Me.tGm4.SelectAll()
    End Sub
    Private Sub tGmArg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tGm1.TextChanged, tGm2.TextChanged, tGm3.TextChanged, tGm4.TextChanged
        Dim ts1, ts2, ts3, ts4 As Decimal
        Try
            ts1 = Convert.ToDecimal(tGm1.Text)
        Catch
            ts1 = 0
        End Try
        Try
            ts2 = Convert.ToDecimal(tGm2.Text)
        Catch
            ts2 = 0
        End Try
        Try
            ts3 = Convert.ToDecimal(tGm3.Text)
        Catch
            ts3 = 0
        End Try
        Try
            ts4 = Convert.ToDecimal(tGm4.Text)
        Catch
            ts4 = 0
        End Try
        tGmArg.Text = ((ts1 + ts2 + ts3 + ts4) / 4).ToString("00.00")
    End Sub

    Private Sub tNmlArg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tNmlArg.GotFocus
        Me.tNmlArg.SelectAll()
    End Sub
    Private Sub tNmlPrc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tNmlArg.TextChanged
        tNmlPrc.Text = CInt(tNmlArg.Text)
    End Sub

    Private Sub tAbNmlArg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tAbNmlArg.GotFocus
        Me.tAbNmlArg.SelectAll()
    End Sub

    Private Sub tAbNmlPrc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tAbNmlArg.TextChanged
        tAbNmlPrc.Text = CInt(tAbNmlArg.Text)
    End Sub

    Private Sub tHdArg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tHdArg.GotFocus
        Me.tHdArg.SelectAll()
    End Sub

    Private Sub tHdPrc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tHdArg.TextChanged
        tHdPrc.Text = CInt(tHdArg.Text)
    End Sub

    Private Sub tFrsArg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tFrsArg.GotFocus
        Me.tFrsArg.SelectAll()
    End Sub

    Private Sub tFrsPrc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tFrsArg.TextChanged
        tFrsPrc.Text = CInt(tFrsArg.Text)
    End Sub

    Private Sub tDdArg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tDdArg.GotFocus
        Me.tDdArg.SelectAll()
    End Sub

    Private Sub tDdPrc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tDdArg.TextChanged
        tDdPrc.Text = CInt(tDdArg.Text)
    End Sub

    Private Sub tGmArg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tGmArg.GotFocus
        Me.tGmArg.SelectAll()
    End Sub

    Private Sub tGmPrc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tGmArg.TextChanged
        tGmPrc.Text = CInt(tGmArg.Text)
    End Sub

    Private Sub tVgArg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tVgArg.GotFocus
        Me.tVgArg.SelectAll()
    End Sub

    Private Sub tVgPrc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tVgArg.TextChanged
        tVgPrc.Text = CInt(tVgArg.Text)
    End Sub
    Public varts1 As Integer
    Public varts2 As Integer
    Public varts3 As Integer
    Public varts4 As Integer
    Public varts5 As Integer
    Private Sub bntcekVal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntcekVal.Click
        Try
            test1()
            test2()
            test3()
            test4()
            test5()
        Catch ex As Exception

        End Try

        If varts1 <> 100 Then
            tval1.Text = varts1
        Else
            tval1.Text = "v"
        End If

        If varts2 <> 100 Then
            tval2.Text = varts2
        Else
            tval2.Text = "v"
        End If

        If varts3 <> 100 Then
            tval3.Text = varts3
        Else
            tval3.Text = "v"
        End If

        If varts4 <> 100 Then
            tval4.Text = varts4
        Else
            tval4.Text = "v"
        End If

        If varts5 <> 100 Then
            tval5.Text = varts5
        Else
            tval5.Text = "v"
        End If

    End Sub
    Private Sub test1()
        Dim ts1, ts2, ts3, ts5, ts4 As Decimal

        Try
            ts1 = Convert.ToDecimal(tNml1.Text)
        Catch
            ts1 = 0
        End Try
        Try
            ts2 = Convert.ToDecimal(tAbNml1.Text)
        Catch
            ts2 = 0
        End Try
        Try
            ts3 = Convert.ToDecimal(tHd1.Text)
        Catch
            ts3 = 0
        End Try
        Try
            ts4 = Convert.ToDecimal(tFrs1.Text)
        Catch
            ts4 = 0
        End Try
        Try
            ts5 = Convert.ToDecimal(tDd1.Text)
        Catch
            ts5 = 0
        End Try
        varts1 = ((ts1 + ts2 + ts3 + ts4 + ts5)).ToString
    End Sub
    Private Sub test2()
        Dim ts1, ts2, ts3, ts5, ts4 As Decimal

        Try
            ts1 = Convert.ToDecimal(tNml2.Text)
        Catch
            ts1 = 0
        End Try
        Try
            ts2 = Convert.ToDecimal(tAbNml2.Text)
        Catch
            ts2 = 0
        End Try
        Try
            ts3 = Convert.ToDecimal(tHd2.Text)
        Catch
            ts3 = 0
        End Try
        Try
            ts4 = Convert.ToDecimal(tFrs2.Text)
        Catch
            ts4 = 0
        End Try
        Try
            ts5 = Convert.ToDecimal(tDd2.Text)
        Catch
            ts5 = 0
        End Try
        varts2 = ((ts1 + ts2 + ts3 + ts4 + ts5)).ToString
    End Sub

    Private Sub test3()
        Dim ts1, ts2, ts3, ts5, ts4 As Decimal

        Try
            ts1 = Convert.ToDecimal(tNml3.Text)
        Catch
            ts1 = 0
        End Try
        Try
            ts2 = Convert.ToDecimal(tAbNml3.Text)
        Catch
            ts2 = 0
        End Try
        Try
            ts3 = Convert.ToDecimal(tHd3.Text)
        Catch
            ts3 = 0
        End Try
        Try
            ts4 = Convert.ToDecimal(tFrs3.Text)
        Catch
            ts4 = 0
        End Try
        Try
            ts5 = Convert.ToDecimal(tDd3.Text)
        Catch
            ts5 = 0
        End Try
        varts3 = ((ts1 + ts2 + ts3 + ts4 + ts5)).ToString
    End Sub
    Private Sub test4()
        Dim ts1, ts2, ts3, ts5, ts4 As Decimal

        Try
            ts1 = Convert.ToDecimal(tNml4.Text)
        Catch
            ts1 = 0
        End Try
        Try
            ts2 = Convert.ToDecimal(tAbNml4.Text)
        Catch
            ts2 = 0
        End Try
        Try
            ts3 = Convert.ToDecimal(tHd4.Text)
        Catch
            ts3 = 0
        End Try
        Try
            ts4 = Convert.ToDecimal(tFrs4.Text)
        Catch
            ts4 = 0
        End Try
        Try
            ts5 = Convert.ToDecimal(tDd4.Text)
        Catch
            ts5 = 0
        End Try
        varts4 = ((ts1 + ts2 + ts3 + ts4 + ts5)).ToString
    End Sub
    Private Sub test5()
        Dim ts1, ts2, ts3, ts5, ts4 As Decimal

        Try
            ts1 = Convert.ToDecimal(tNmlPrc.Text)
        Catch
            ts1 = 0
        End Try
        Try
            ts2 = Convert.ToDecimal(tAbNmlPrc.Text)
        Catch
            ts2 = 0
        End Try
        Try
            ts3 = Convert.ToDecimal(tHdPrc.Text)
        Catch
            ts3 = 0
        End Try
        Try
            ts4 = Convert.ToDecimal(tFrsPrc.Text)
        Catch
            ts4 = 0
        End Try
        Try
            ts5 = Convert.ToDecimal(tDdPrc.Text)
        Catch
            ts5 = 0
        End Try
        varts5 = ((ts1 + ts2 + ts3 + ts4 + ts5)).ToString
    End Sub

    Private Sub tnolab_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tnolab.GotFocus
        Me.AcceptButton = btncari1
    End Sub

    Private Sub tNmlPrc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tNmlPrc.GotFocus
        Me.tNmlPrc.SelectAll()
    End Sub

    Private Sub tAbNmlPrc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tAbNmlPrc.GotFocus
        Me.tAbNmlPrc.SelectAll()
    End Sub

    Private Sub tHdPrc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tHdPrc.GotFocus
        Me.tHdPrc.SelectAll()
    End Sub

    Private Sub tFrsPrc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tFrsPrc.GotFocus
        Me.tFrsPrc.SelectAll()
    End Sub

    Private Sub tDdPrc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tDdPrc.GotFocus
        Me.tDdPrc.SelectAll()
    End Sub

    Private Sub tVgPrc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tVgPrc.GotFocus
        Me.tVgPrc.SelectAll()
    End Sub

    Private Sub tGmPrc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tGmPrc.GotFocus
        Me.tGmPrc.SelectAll()
    End Sub
End Class