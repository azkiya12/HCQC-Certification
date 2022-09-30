Imports System.Globalization
Imports System.Text.RegularExpressions
Imports MetroFramework
Imports MetroFramework.Forms
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommandBuilder
Imports System.Data

Public Class Daya_Tumbuh_Periodik

    Private Sub btnCari2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCari2.Click
        Dim sql As String = ""
        openDB()
        sql = "Select * From periodik_vg WHERE (no_lab= '" & tnolab.Text & "') and (char1s='Normal Seedling (%)')"
        cmd = New SqlClient.SqlCommand(sql, con)
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        dread = cmd.ExecuteReader
        If dread.Read = True Then
            con.Close()
            openDB()
            sql = "Select * From periodik_vg WHERE (no_lab= '" & tnolab.Text & "') and (char1s='Normal Seedling (%)')"
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
            sql = "Select * From periodik_vg WHERE (no_lab= '" & tnolab.Text & "') and (char1s='Abnormal Seedling (%)')"
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
            sql = "Select * From periodik_vg WHERE (no_lab= '" & tnolab.Text & "') and (char1s='Hard Seed (%)')"
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
            sql = "Select * From periodik_vg WHERE (no_lab= '" & tnolab.Text & "') and (char1s='Fresh Seed (%)')"
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
            sql = "Select * From periodik_vg WHERE (no_lab= '" & tnolab.Text & "') and (char1s='Dead Seed (%)')"
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
            sql = "Select * From periodik_vg WHERE (no_lab= '" & tnolab.Text & "') and (char1s='Index Vigor (%)')"
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
            sql = "Select * From periodik_vg WHERE (no_lab= '" & tnolab.Text & "') and (char1s='Germination (%)')"
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
            sql = "Select * From periodik_msk WHERE (no_lab= '" & tnolab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                tvariety.Text = dread.Item("variety")
                tnojob.Text = dread.Item("nojob")
                tnomnl.Text = dread.Item("nomnl")
                Dim tgluji As Date = dread.Item("vg_Dt_t")
                Dim tglfist As Date = dread.Item("vg_fs_c")
                Dim tglfinl As Date = dread.Item("vg_fn_c")
                tgl_uji.Text = tgluji.ToString("dd-MM-yyyy")
                tgl_fs.Text = tglfist.ToString("dd-MM-yyyy")
                tgl_fn.Text = tglfinl.ToString("dd-MM-yyyy")
                tanalys.Text = dread.Item("vg_analys")
                If Not dread.Item("vg_mtd").ToString = "" Then
                    If dread.Item("vg_mtd").ToString = "Between Paper" Then
                        ckbetwen.Checked = True
                    ElseIf dread.Item("vg_mtd").ToString = "Top of Paper" Then
                        cektop.Checked = True
                    ElseIf dread.Item("vg_mtd").ToString = "Pleated Paper" Then
                        tpleated.Checked = True
                    ElseIf dread.Item("vg_mtd").ToString = "Top of Sand" Then
                        ttopsand.Checked = True
                    ElseIf dread.Item("vg_mtd").ToString = "Sand" Then
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
End Class