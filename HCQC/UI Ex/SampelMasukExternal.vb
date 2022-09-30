Imports System.Globalization
Imports System.Text.RegularExpressions
Imports MetroFramework
Imports MetroFramework.Forms
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommandBuilder
Imports System.Data

Public Class SampelMasukExternal
    Dim tglnow As Date = Today
    Public jenis As String
    Public no1 As String

    Private Sub MetroLink1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroLink1.Click
        'Dim _pnl As New SampelMasukExternal(Me)
        AddHandler Me.Closed, AddressOf pnl_Closed
        'AddHandler _pnl.Shown, AddressOf pnl_Shown
        Me.swiper(False)

        If MinForm.SampelMasukToolStripMenuItem.Enabled = False Then
            MinForm.SampelMasukToolStripMenuItem.Enabled = True
        End If

    End Sub
    '--!Warning to Delete Below!------
    Private Sub pnl_Closed(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub AutoNumber()
        Try
            If openDB() = False Then
                MsgBox("Tidak Terhubung ke Database")
            Else
                Dim sql As String = ""
                Dim strTam As String = ""
                Dim strVal As String = ""
                no1 = WindowsApplication1.Module2.ConvertToRomanNumeral(Month(Today)) + "/" + tglnow.ToString("yyyy")
                sql = "Select no_lab from extnl_msk Where no_lab LIKE '%/" & no1 & "' ORDER by no_lab DESC"
                cmd = New SqlClient.SqlCommand(sql, con)
                dread = cmd.ExecuteReader
                If dread.Read() Then
                    'JIKA NO LAB DITEMUKAN LEBIH DARI SATU
                    strTam = Mid(dread.Item("no_lab"), 2, 4)
                Else
                    tnolab.Text = "E0001/" & WindowsApplication1.Module2.ConvertToRomanNumeral(Month(Today)) & "/" & Year(Today)
                End If
                strVal = Val(strTam) + 1
                jenis = strVal
                tnolab.Text = "E" & Mid("000", 1, 4 - strVal.Length) & strVal & "/" & WindowsApplication1.Module2.ConvertToRomanNumeral(Month(Today)) & "/" & Year(Today)
            End If
        Catch ex As Exception
            MsgBox("Terjadi Error : " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub SampelMasukExternal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '
        'penomoran Automatis
        AutoNumber()
        tTgl_msk.Text = tglnow.ToString("dd-MM-yyyy")

    End Sub

    Private Sub MetroButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton2.Click
        'Penomoran AutoNumber
        AutoNumber()

        btnSave.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        tvarety.Focus()
    End Sub

    Private Sub btnCari1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari1.Click
        Try
            Dim sql As String = ""
            openDB()
            sql = "Select * From extnl_msk WHERE (no_lab= '" & tnolab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                tvarety.Text = dread.Item("variety")
                tnojob.Text = dread.Item("nojob")
                tppc.Text = dread.Item("taken")
                tweightA.Text = dread.Item("weightA")
                tweightB.Text = dread.Item("weightB")
                CunitA.Text = dread.Item("unitA")
                CunitB.Text = dread.Item("unitB")
                tnama.Text = dread.Item("nama")
                tasal.Text = dread.Item("asal")

                'Dim tglhvs As Date = 
                tdatehvs.Text = dread.Item("hv_dt")

                Dim tglexp As Date = dread.Item("exp_dt")
                texpdate.Text = tglexp.ToString("dd-MM-yyyy")

                Dim tglmsk As Date = dread.Item("Dtqc")
                tTgl_msk.Text = tglmsk.ToString("dd-MM-yyyy")

                tbrt_msk.Text = dread.Item("brt_in")
                tuk_bnh.Text = dread.Item("uk_bnh")
                chkKA.Checked = dread.Item("uji_ka")
                chkRaf.Checked = dread.Item("uji_ra")
                chkDT.Checked = dread.Item("uji_dt")
                chkAAT.Checked = dread.Item("uji_aat")
                chkTZ.Checked = dread.Item("uji_tz")
                chkECT.Checked = dread.Item("uji_ect")

                tppc.Text = dread.Item("taken")
                tppc2.Text = dread.Item("ppc2")
                tket.Text = dread.Item("ket")
                tjns_bnh.Text = dread.Item("jns_bnh")
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
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Error : " & ex.Message, Me.Text, MessageBoxButtons.OK, 211)
            Return
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If tvarety.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Variety harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tvarety.Focus()
        ElseIf tnojob.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "No Job harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tnojob.Focus()
        ElseIf tbrt_msk.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Berat Masuk harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tbrt_msk.Focus()
        ElseIf tppc.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Taken by harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tppc.Focus()
        Else
            '
            'Perulangan tidak diterapkan pada GRAVITY
            'Proses Insert Rerecord Database
            '
            _RunSQL("INSERT INTO extnl_msk  (no_lab, variety, nojob, weightA, weightB, unitA, unitB, nama, asal, hv_dt, exp_dt, Dtqc, brt_in, uk_bnh, uji_ka, uji_ra, uji_dt, uji_aat, uji_tz, uji_ect, taken, ppc2, ket, jns_bnh) " & _
                    "VALUES('" & tnolab.Text & "','" & tvarety.Text & "','" & tnojob.Text & "','" & tweightA.Text & "','" & tweightB.Text & "','" & CunitA.Text & "','" & CunitB.Text & "','" & tnama.Text & "','" & tasal.Text & "','" & tdatehvs.Text & "','" & CDate(texpdate.Text) & "','" & CDate(tTgl_msk.Text) & "','" & tbrt_msk.Text & "','" & tuk_bnh.Text & "','" & chkKA.CheckState & "','" & chkRaf.CheckState & "','" & chkDT.CheckState & "','" & chkAAT.CheckState & "','" & chkTZ.CheckState & "','" & chkECT.CheckState & "','" & tppc.Text & "','" & tppc2.Text & "','" & tket.Text & "', '" & tjns_bnh.Text & "')")
            'Me.Wip_mskTableAdapter.Fill(Me.HCQC_serverDataSet.wip_msk)
            Bersihkan()
            '
            'Penomoran Automatis
            '
            AutoNumber()

        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        _RunSQL("Update extnl_msk SET variety ='" & tvarety.Text & "', nojob ='" & tnojob.Text & "', weightA ='" & tweightA.Text & "', weightB ='" & tweightB.Text & "', unitA ='" & CunitA.Text & "', unitB ='" & CunitB.Text & "', nama ='" & tnama.Text & "', asal ='" & tasal.Text & "', hv_dt ='" & tdatehvs.Text & "', exp_dt ='" & CDate(texpdate.Text) & "', Dtqc ='" & CDate(tTgl_msk.Text) & "', brt_in ='" & tbrt_msk.Text & "', uk_bnh ='" & tuk_bnh.Text & "', uji_ka ='" & chkKA.CheckState & "', uji_ra ='" & chkRaf.CheckState & "', uji_dt ='" & chkDT.CheckState & "', uji_aat ='" & chkAAT.CheckState & "', uji_tz ='" & chkTZ.CheckState & "', uji_ect ='" & chkECT.CheckState & "', taken ='" & tppc.Text & "', ppc2 ='" & tppc2.Text & "', ket ='" & tket.Text & "', jns_bnh='" & tjns_bnh.Text & "' WHERE (no_lab='" & tnolab.Text & "')")
        Bersihkan()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk menghapus data ini " + tnolab.Text, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
        If result = DialogResult.Yes Then
            _RunSQL("DELETE FROM extnl_msk WHERE (no_lab = '" & tnolab.Text & "')")
            'Me.Wip_mskTableAdapter.Fill(Me.HCQC_serverDataSet.wip_msk)
            Me.tnolab.Focus()
            'Me.MetroGrid1.Update()
            Bersihkan()
        ElseIf result = DialogResult.No Then
            btnSave.Enabled = True
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            Me.tnolab.Focus()
        End If
    End Sub

    Public Sub Bersihkan()
        tvarety.Text = ""
        tnojob.Text = ""
        tweightA.Text = ""
        tweightB.Text = ""
        CunitA.Text = ""
        CunitB.Text = ""
        'tnama.Text = ""
        'tasal.Text = ""
        tdatehvs.Text = ""
        texpdate.Text = ""

        tbrt_msk.Text = ""
        tuk_bnh.Text = ""
        'tppc.Text = ""
        'tppc2.Text = ""
        'chkKA.Checked = False
        'chkRaf.Checked = False
        'chkDT.Checked = False
        chkAAT.Checked = False
        chkTZ.Checked = False
        chkECT.Checked = False
        tket.Text = ""
    End Sub

    'Private Sub tnolab_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tnolab.GotFocus
    '    Me.AcceptButton = btnCari1
    'End Sub

    'Private Sub tnojob_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tnojob.LostFocus
    '    Me.AcceptButton = Nothing
    'End Sub
End Class