Imports System.Globalization
Imports System.Text.RegularExpressions
Imports MetroFramework
Imports MetroFramework.Forms
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommandBuilder
Imports System.Data
Public Class PurityAndRafakctionAnalysis

    Private Sub PurityAndRafakctionAnalysis_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub PurityAndRafakctionAnalysis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCQC_serverDataSet.wip_ir2' table. You can move, or remove it, as needed.
        Me.Wip_ir2TableAdapter.Fill(Me.HCQC_serverDataSet.wip_ir2)

    End Sub

    Private Sub btncari1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncari1.Click
        Dim sql As String = ""
        Try
            openDB()
            sql = "Select * From wip_ir2 WHERE (no_lab= '" & tnolab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = False Then
                openDB()
                sql = "Select * From wip_msk WHERE (no_lab= '" & tnolab.Text & "')"
                cmd = New SqlClient.SqlCommand(sql, con)
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                dread = cmd.ExecuteReader
                If dread.Read = True Then
                    tvariety.Text = dread.Item("variety")
                    tnojob.Text = dread.Item("nojob")
                    tnomnl.Text = dread.Item("nomnl")
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
                Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data sudah ada!. Click 'YES' untuk melanjutka pencarian. Clik 'No' untuk Data Baru", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                If result = DialogResult.Yes Then
                    Me.tnolab.Focus()
                ElseIf result = DialogResult.No Then
                    btnSave.Enabled = True
                    btnEdit.Enabled = False
                    btnDelete.Enabled = False
                    Me.tnolab.Focus()
                End If
            End If

        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, Me.Text)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Cari2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari2.Click
        Dim sql As String = ""
        Try
            openDB()
            sql = "Select * From wip_ir2 WHERE (no_lab= '" & tnolab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                tPA_ws.Text = dread.Item("pa_ws1")
                tPA_ps.Text = dread.Item("pa_ps1")
                tPA_os.Text = dread.Item("pa_os")
                tPA_im.Text = dread.Item("pa_im1")
                tIRws.Text = dread.Item("ws")
                tIRps.Text = dread.Item("ps")
                tIRyg.Text = dread.Item("yg")
                tIRus.Text = dread.Item("us")
                tIRrt.Text = dread.Item("rt")
                tIRid.Text = dread.Item("Ind")
                tIRbr.Text = dread.Item("br")
                tIRod.Text = dread.Item("od")
                tIRgr.Text = dread.Item("gr")
                tIRfg.Text = dread.Item("fg")
                tIRim.Text = dread.Item("im")
                tIRcr.Text = dread.Item("cr")
                tIRcvl.Text = dread.Item("ov")
                tIR1rbsed.Text = dread.Item("pa_sedwg")
                tanalys.Text = dread.Item("analys")
                tPSD_n.Text = dread.Item("psd_n")

                Dim tglmsk As Date = dread.Item("dt_t")
                dtgl_uji.Text = tglmsk.ToString("dd-MM-yyyy")
                tket.Text = dread.Item("ket")

                If dread.Item("resul") = True Then
                    tirpass.Checked = True
                Else
                    tirnotpass.Checked = True
                End If

                con.Close()
                openDB()
                sql = "Select * From wip_msk WHERE (no_lab= '" & tnolab.Text & "')"
                cmd = New SqlClient.SqlCommand(sql, con)
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                dread = cmd.ExecuteReader
                If dread.Read = True Then
                    tvariety.Text = dread.Item("variety")
                    tnojob.Text = dread.Item("nojob")
                    tnomnl.Text = dread.Item("nomnl")
                End If
                btnSave.Enabled = False
                btnEdit.Enabled = True
                btnDelete.Enabled = True
            Else
                Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data tidak ditemukan!. Click 'Yes' untuk melanjutkan pencarian. Click 'No' untuk Input Data Baru", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                If result = DialogResult.Yes Then
                    Me.tnolab.Focus()
                ElseIf result = DialogResult.No Then
                    btnSave.Enabled = True
                    btnEdit.Enabled = False
                    btnDelete.Enabled = False
                    Me.tnolab.Focus()
                End If
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, Me.Text)
        Finally
            con.Close()
        End Try

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
        Else
            Dim hrini As Date = Today
            Dim ck As Boolean = False
            Dim rsl As Boolean = False
            If tirpass.Checked = True Then
                rsl = True
            ElseIf tirnotpass.Checked = True Then
                rsl = False
            End If
            _RunSQL("INSERT INTO wip_ir2" & _
                      "(no_lab, pa_ws1, pa_sedwg, pa_ps1, pa_os, pa_im1, ws, ps, yg, us, rt, Ind, br, od, gr, fg, im, cr, ov, dt_t, analys, resul, cek, ket, tgl_input, psd_n)" & _
                      "VALUES ('" & tnolab.Text & "'," & Val(tPA_ws.Text) & "," & Val(tIR1rbsed.Text) & "," & Val(tPA_ps.Text) & "," & Val(tPA_os.Text) & "," & Val(tPA_im.Text) & "," & Val(tIRws.Text) & "," & Val(tIRps.Text) & "," & _
                      "" & Val(tIRyg.Text) & "," & Val(tIRus.Text) & "," & Val(tIRrt.Text) & "," & Val(tIRid.Text) & "," & Val(tIRbr.Text) & "," & Val(tIRod.Text) & "," & Val(tIRgr.Text) & "," & Val(tIRfg.Text) & "," & Val(tIRim.Text) & _
                      "," & Val(tIRcr.Text) & "," & Val(tIRcvl.Text) & ",'" & CDate(dtgl_uji.Text) & "','" & tanalys.Text & "','" & rsl & "','" & ck & "','" & tket.Text & "','" & CDate(hrini) & "','" & tPSD_n.Text & "')")
            Me.Wip_ir2TableAdapter.Fill(Me.HCQC_serverDataSet.wip_ir2)
            tnolab.Focus()
            bersihkan()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim hrini As Date = Today
        Dim ck As Boolean = False
        Dim rsl As Boolean = False
        If tirpass.Checked = True Then
            rsl = True
        ElseIf tirnotpass.Checked = True Then
            rsl = False
        End If
        _RunSQL("UPDATE    wip_ir2 " & _
                "SET pa_ws1 =" & tPA_ws.Text & ", pa_sedwg =" & tIR1rbsed.Text & ", pa_ps1 =" & tPA_ps.Text & ", pa_os =" & tPA_os.Text & ", pa_im1 =" & tPA_im.Text & ", ws =" & tIRws.Text & ", ps =" & tIRps.Text & ", yg =" & tIRyg.Text & ", us =" & tIRus.Text & ", rt =" & tIRrt.Text & ", Ind =" & tIRid.Text & ", br =" & tIRbr.Text & ", od =" & tIRod.Text & ", gr =" & tIRgr.Text & ", fg =" & tIRfg.Text & ", im =" & tIRim.Text & ", cr =" & tIRcr.Text & ", ov =" & tIRcvl.Text & ", dt_t ='" & CDate(dtgl_uji.Text) & "', analys ='" & tanalys.Text & "', resul ='" & rsl & "', " & _
                "cek ='" & ck & "', ket ='" & tket.Text & "', tgl_input ='" & CDate(hrini) & "', psd_n='" & tPSD_n.Text & "'" & _
                "WHERE (no_lab='" & tnolab.Text & "') ")
        Me.Wip_ir2TableAdapter.Fill(Me.HCQC_serverDataSet.wip_ir2)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk menghapus data ini " + tnolab.Text, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
        If result = DialogResult.Yes Then
            _RunSQL("DELETE FROM wip_ir2 WHERE (no_lab = '" & tnolab.Text & "')")
            'Me.Wip_ir2TableAdapter.Fill(Me.HCQC_serverDataSet.wip_ir2)
            Me.tnolab.Focus()
            Me.MetroGrid1.Update()
            'Bersihkan()
        ElseIf result = DialogResult.No Then
            btnSave.Enabled = True
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            Me.tnolab.Focus()
        End If
    End Sub

    Private Sub tPA_ps_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tPA_ps.TextChanged, tPA_ws.TextChanged
        Dim ps1, ps2 As Decimal
        Try
            ps1 = Convert.ToDecimal(tPA_ws.Text)
        Catch
            ps1 = 0
        End Try
        Try
            ps2 = Convert.ToDecimal(tPA_ps.Text)
        Catch
            ps2 = 0
        End Try
        If ps1 <> 0 Then
            tPAps1.Text = ((ps2 / ps1) * 100).ToString("00.0")
        End If
    End Sub

    Private Sub tPA_os_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tPA_os.TextChanged, tPA_ws.TextChanged
        Dim ps1, ps2 As Decimal
        Try
            ps1 = Convert.ToDecimal(tPA_ws.Text)
        Catch
            ps1 = 0
        End Try
        Try
            ps2 = Convert.ToDecimal(tPA_os.Text)
        Catch
            ps2 = 0
        End Try
        If ps1 <> 0 Then
            tPAos1.Text = ((ps2 / ps1) * 100).ToString("00.0")
        End If
    End Sub

    Private Sub tPA_im_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tPA_im.TextChanged, tPA_ws.TextChanged, tPSD_n.TextChanged
        Dim ps1, ps2 As Decimal
        Try
            ps1 = Convert.ToDecimal(tPA_ws.Text)
        Catch
            ps1 = 0
        End Try
        Try
            ps2 = Convert.ToDecimal(tPA_im.Text)
        Catch
            ps2 = 0
        End Try
        If ps1 <> 0 Then
            tPAim1.Text = ((ps2 / ps1) * 100).ToString("00.0")
        End If
    End Sub

    Private Sub tIRps_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tIRps.TextChanged, tIRws.TextChanged, tPA_ws.TextChanged, tPA_ps.TextChanged
        Dim ps1, ps2 As Decimal
        Try
            ps1 = Convert.ToDecimal(tIRws.Text)
        Catch
            ps1 = 0
        End Try
        Try
            ps2 = Convert.ToDecimal(tIRps.Text)
        Catch
            ps2 = 0
        End Try
        If ps1 <> 0 Then
            tIRps1.Text = ((ps2 / ps1) * 100).ToString("0.00")
        End If
    End Sub

    Private Sub tIRyg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tIRyg.GotFocus
        Me.tIRyg.SelectAll()
    End Sub

    Private Sub tIRyg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tIRyg.TextChanged, tIRws.TextChanged
        Dim ps1, ps2 As Decimal
        Try
            ps1 = Convert.ToDecimal(tIRws.Text)
        Catch
            ps1 = 0
        End Try
        Try
            ps2 = Convert.ToDecimal(tIRyg.Text)
        Catch
            ps2 = 0
        End Try
        If ps1 <> 0 Then
            tIRyg1.Text = ((ps2 / ps1) * 100).ToString("0.00")
        End If
    End Sub

    Private Sub tIRus_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tIRus.TextChanged, tIRws.TextChanged
        Dim ps1, ps2 As Decimal
        Try
            ps1 = Convert.ToDecimal(tIRws.Text)
        Catch
            ps1 = 0
        End Try
        Try
            ps2 = Convert.ToDecimal(tIRus.Text)
        Catch
            ps2 = 0
        End Try
        If ps1 <> 0 Then
            tIRus1.Text = ((ps2 / ps1) * 100).ToString("0.00")
        End If
    End Sub

    Private Sub tIRrt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tIRrt.GotFocus
        Me.tIRrt.SelectAll()
    End Sub

    Private Sub tIRrt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tIRrt.TextChanged, tIRws.TextChanged
        Dim ps1, ps2 As Decimal
        Try
            ps1 = Convert.ToDecimal(tIRws.Text)
        Catch
            ps1 = 0
        End Try
        Try
            ps2 = Convert.ToDecimal(tIRrt.Text)
        Catch
            ps2 = 0
        End Try
        If ps1 <> 0 Then
            tIRrt1.Text = ((ps2 / ps1) * 100).ToString("0.00")
        End If

    End Sub

    Private Sub tIRid_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tIRid.TextChanged, tIRws.TextChanged
        Dim ps1, ps2 As Decimal
        Try
            ps1 = Convert.ToDecimal(tIRws.Text)
        Catch
            ps1 = 0
        End Try
        Try
            ps2 = Convert.ToDecimal(tIRid.Text)
        Catch
            ps2 = 0
        End Try
        If ps1 <> 0 Then
            tIRid1.Text = ((ps2 / ps1) * 100).ToString("0.00")
        End If
    End Sub

    Private Sub tIRbr_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tIRbr.TextChanged, tIRws.TextChanged
        Dim ps1, ps2 As Decimal
        Try
            ps1 = Convert.ToDecimal(tIRws.Text)
        Catch
            ps1 = 0
        End Try
        Try
            ps2 = Convert.ToDecimal(tIRbr.Text)
        Catch
            ps2 = 0
        End Try
        If ps1 <> 0 Then
            tIRbr1.Text = ((ps2 / ps1) * 100).ToString("0.00")
        End If
    End Sub

    Private Sub tIRod_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tIRod.TextChanged, tIRws.TextChanged
        Dim ps1, ps2 As Decimal
        Try
            ps1 = Convert.ToDecimal(tIRws.Text)
        Catch
            ps1 = 0
        End Try
        Try
            ps2 = Convert.ToDecimal(tIRod.Text)
        Catch
            ps2 = 0
        End Try
        If ps1 <> 0 Then
            tIRod1.Text = ((ps2 / ps1) * 100).ToString("0.00")
        End If
    End Sub

    Private Sub tIRgr_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tIRgr.TextChanged, tIRws.TextChanged
        Dim ps1, ps2 As Decimal
        Try
            ps1 = Convert.ToDecimal(tIRws.Text)
        Catch
            ps1 = 0
        End Try
        Try
            ps2 = Convert.ToDecimal(tIRgr.Text)
        Catch
            ps2 = 0
        End Try
        If ps1 <> 0 Then
            tIRgr1.Text = ((ps2 / ps1) * 100).ToString("0.00")
        End If
    End Sub

    Private Sub tIRfg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tIRfg.TextChanged, tIRws.TextChanged
        Dim ps1, ps2 As Decimal
        Try
            ps1 = Convert.ToDecimal(tIRws.Text)
        Catch
            ps1 = 0
        End Try
        Try
            ps2 = Convert.ToDecimal(tIRfg.Text)
        Catch
            ps2 = 0
        End Try
        If ps1 <> 0 Then
            tIRfg1.Text = ((ps2 / ps1) * 100).ToString("0.00")
        End If
    End Sub

    Private Sub tIRim_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tIRim.TextChanged, tIRws.TextChanged
        Dim ps1, ps2 As Decimal
        Try
            ps1 = Convert.ToDecimal(tIRws.Text)
        Catch
            ps1 = 0
        End Try
        Try
            ps2 = Convert.ToDecimal(tIRim.Text)
        Catch
            ps2 = 0
        End Try
        If ps1 <> 0 Then
            tIRim1.Text = ((ps2 / ps1) * 100).ToString("0.00")
        End If
    End Sub

    Private Sub tIRcr_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tIRcr.TextChanged, tIRws.TextChanged
        Dim ps1, ps2 As Decimal
        Try
            ps1 = Convert.ToDecimal(tIRws.Text)
        Catch
            ps1 = 0
        End Try
        Try
            ps2 = Convert.ToDecimal(tIRcr.Text)
        Catch
            ps2 = 0
        End Try
        If ps1 <> 0 Then
            tIRcr1.Text = ((ps2 / ps1) * 100).ToString("0.00")
        End If
    End Sub

    Private Sub tIRcvl_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tIRcvl.TextChanged, tIRws.TextChanged
        Dim ps1, ps2 As Decimal
        Try
            ps1 = Convert.ToDecimal(tIRws.Text)
        Catch
            ps1 = 0
        End Try
        Try
            ps2 = Convert.ToDecimal(tIRcvl.Text)
        Catch
            ps2 = 0
        End Try
        If ps1 <> 0 Then
            tIRcvl1.Text = ((ps2 / ps1) * 100).ToString("0.00")
        End If
    End Sub

    Private Sub tIRus_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tIRus.GotFocus
        Me.tIRus.SelectAll()
    End Sub

    Private Sub tIRps_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tIRps.GotFocus
        Me.tIRps.SelectAll()
    End Sub

    Private Sub tIRid_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tIRid.GotFocus
        Me.tIRid.SelectAll()
    End Sub

    Private Sub tnolab_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tnolab.GotFocus
        Me.AcceptButton = btncari1
    End Sub

    Private Sub tIR1rbsed_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tIR1rbsed.GotFocus
        Me.tIR1rbsed.SelectAll()
    End Sub

    Private Sub tanalys_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tanalys.Click
        Me.tanalys.SelectAll()
    End Sub

    Private Sub tIRim_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tIRim.GotFocus
        Me.tIRim.SelectAll()
    End Sub

    Private Sub tIRcvl_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tIRcvl.GotFocus
        Me.tIRcvl.SelectAll()
    End Sub

    Private Sub tIRcr_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tIRcr.GotFocus
        Me.tIRcr.SelectAll()
    End Sub

    Private Sub tIRfg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tIRfg.GotFocus
        Me.tIRfg.SelectAll()
    End Sub

    Private Sub tIRgr_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tIRgr.GotFocus
        Me.tIRgr.SelectAll()
    End Sub

    Private Sub tIRbr_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tIRbr.GotFocus
        Me.tIRbr.SelectAll()
    End Sub

    Private Sub tanalys_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tanalys.GotFocus
        Me.tanalys.SelectAll()
    End Sub

    Public Sub bersihkan()
        tPA_ws.Text = ""
        tPA_ps.Text = ""
        tPA_os.Text = ""
        tPA_im.Text = ""
        tIRws.Text = ""
        tIRps.Text = ""
        tIRyg.Text = ""
        tIRus.Text = ""
        tIRrt.Text = ""
        tIRid.Text = ""
        tIRbr.Text = ""
        tIRod.Text = ""
        tIRgr.Text = ""
        tIRfg.Text = ""
        tIRim.Text = ""
        tIRcr.Text = ""
        tIRcvl.Text = ""
        tIR1rbsed.Text = ""
        'tanalys.Text = ""
        'dtgl_uji.Text = ""
    End Sub

End Class