Imports System.Globalization
Imports System.Text.RegularExpressions
Imports MetroFramework
Imports MetroFramework.Forms
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommandBuilder
Imports System.Data
Imports DgvFilterPopup

Public Class PenerimaanSampleRM
    Dim tglnow As Date = Today
    Public jenis As String
    Public no1 As String

    Public Sub AutoNumber()
        'PENOMORAN KODE LAB. AUTOMATIS
        Try
            If openDB() = False Then
                MsgBox("Tidak Terhubung ke Database")
            Else
                Dim sql As String = ""
                Dim strTam As String = ""
                Dim strVal As String = ""
                no1 = WindowsApplication1.Module2.ConvertToRomanNumeral(Month(Today)) + "/" + tglnow.ToString("yyyy")
                sql = "Select no_lab from rm_msk Where no_lab LIKE '%/" & no1 & "' ORDER by no_lab DESC"
                cmd = New SqlClient.SqlCommand(sql, con)
                dread = cmd.ExecuteReader
                If dread.Read() Then
                    strTam = Mid(dread.Item("no_lab"), 3, 4)
                Else
                    tnolab.Text = "RM0001/" & WindowsApplication1.Module2.ConvertToRomanNumeral(Month(Today)) & "/" & Year(Today)
                End If
                strVal = Val(strTam) + 1
                jenis = strVal
                tnolab.Text = "RM" & Mid("000", 1, 4 - strVal.Length) & strVal & "/" & WindowsApplication1.Module2.ConvertToRomanNumeral(Month(Today)) & "/" & Year(Today)
            End If
        Catch ex As Exception
            MsgBox("Terjadi Error : " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub PenerimaanSampleRM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'HCQC_serverDataSet.rm_msk' table. You can move, or remove it, as needed.
        Me.Rm_mskTableAdapter.Fill(Me.HCQC_serverDataSet.rm_msk)

        Dim DgvFilter As New DgvFilterManager
        DgvFilter.DataGridView = MetroGrid1
        MetroGrid1.ColumnHeadersHeight = 25

        tTgl_in.Text = tglnow.ToString("dd-MM-yyyy")
        '
        'penomoran Automatis
        AutoNumber()
        ''
    End Sub

    Private Sub MetroTile1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile1.Click
        Try
            Dim sql As String = ""
            openDB()
            sql = "Select * From rm_msk WHERE (no_lab= '" & tnolab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                tPPC.Text = dread.Item("taken")
                Dim tglmsk As Date = dread.Item("Dtqc")
                tTgl_in.Text = tglmsk.ToString("dd-MM-yyyy")

                tvariety.Text = dread.Item("variety")
                tfarmer.Text = dread.Item("farmer")
                tlokasi.Text = dread.Item("lokasi")
                Dim tglhvs As Date = dread.Item("hv_dt")
                tDatehvs.Text = tglhvs.ToString("dd-MM-yyyy")
                tweight.Text = dread.Item("weight")
                tbrt_in.Text = dread.Item("brt_in")

                chk_KA.Checked = dread.Item("uji_ka")
                chk_RA.Checked = dread.Item("uji_ra")
                chk_DT.Checked = dread.Item("uji_dt")

                tab_kmsn.Text = dread.Item("ab_kmsn")
                tab_bnh.Text = dread.Item("ab_bnh")
                tab_label.Text = dread.Item("ab_label")
                tuk_bnh1.Text = dread.Item("uk_bnh")

                tPPC2.Text = dread.Item("ppc2")
                tKet.Text = dread.Item("ket")
                If Not IsDBNull(dread.Item("tgl_srtjln")) Then
                    Dim tgljln As Date = dread.Item("tgl_srtjln")
                    Ttgl_srtjln.Text = tgljln.ToString("dd-MM-yyyy")
                Else
                    Ttgl_srtjln.Text = ""
                End If


                btnSave.Enabled = False
                btnEdit.Enabled = True
                btnDelete.Enabled = True
            Else
                Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data tidak ditemukan!. Apakah anda ingin melanjutkan pencarian data?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                If result = DialogResult.Yes Then
                    tnolab.Focus()
                ElseIf result = DialogResult.No Then
                    Me.tnolab.Focus()
                    btnSave.Enabled = True
                    btnEdit.Enabled = False
                    btnDelete.Enabled = False
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
        If tvariety.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Variety harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tvariety.Focus()
        ElseIf tfarmer.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "No Job harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tfarmer.Focus()
        ElseIf tlokasi.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Class harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tlokasi.Focus()
        ElseIf tDatehvs.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Harvest Date harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tDatehvs.Focus()
        ElseIf tweight.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Weight(kg) harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tweight.Focus()
        ElseIf tbrt_in.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Berat Masuk harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tbrt_in.Focus()
        ElseIf tPPC.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "PPC harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tPPC.Focus()
        Else

            _RunSQL("INSERT INTO rm_msk(no_lab, taken, Dtqc, variety, farmer, lokasi, hv_dt, weight, brt_in, uji_ka, uji_ra, uji_dt, ab_kmsn, ab_bnh, ab_label, ket, uk_bnh, ppc2, tgl_srtjln, tgl_input_spl)" & _
                    "VALUES('" & tnolab.Text & "','" & tPPC.Text & "','" & CDate(tTgl_in.Text) & "','" & tvariety.Text & "','" & tfarmer.Text & "','" & tlokasi.Text & "'," & _
                    "'" & CDate(tDatehvs.Text) & "','" & Val(tweight.Text) & "','" & Val(tbrt_in.Text) & "','" & chk_KA.CheckState & "','" & chk_RA.CheckState & "'," & _
                    "'" & chk_DT.CheckState & "','" & tab_kmsn.Text & "','" & tab_bnh.Text & "','" & tab_label.Text & "','" & tKet.Text & "','" & tuk_bnh1.Text & "','" & tPPC2.Text & "','" & CDate(Ttgl_srtjln.Text) & "','" & Now & "')")
            Me.Rm_mskTableAdapter.Fill(Me.HCQC_serverDataSet.rm_msk)
            bersihkan()
            '
            'penomoran Automatis
            AutoNumber()
            '
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        _RunSQL("UPDATE rm_msk SET no_lab ='" & tnolab.Text & "', taken ='" & tPPC.Text & "', Dtqc ='" & CDate(tTgl_in.Text) & "', variety ='" & tvariety.Text & "', farmer ='" & tfarmer.Text & "', lokasi ='" & tlokasi.Text & "', hv_dt ='" & CDate(tDatehvs.Text) & "', weight ='" & Val(tweight.Text) & "', brt_in ='" & Val(tbrt_in.Text) & "'," & _
                "uji_ka ='" & chk_KA.CheckState & "', uji_ra ='" & chk_RA.CheckState & "', uji_dt ='" & chk_DT.CheckState & "', ab_kmsn ='" & tab_kmsn.Text & "', ab_bnh ='" & tab_bnh.Text & "', ab_label ='" & tab_label.Text & "', ket ='" & tKet.Text & "',uk_bnh='" & tuk_bnh1.Text & "', ppc2='" & tPPC2.Text & "', tgl_srtjln='" & CDate(Ttgl_srtjln.Text) & "', tgl_input_spl='" & Now & "' " & _
                " WHERE (no_lab='" & tnolab.Text & "')")
        Me.Rm_mskTableAdapter.Fill(Me.HCQC_serverDataSet.rm_msk)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk menghapus data ini " + tnolab.Text, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
        If result = DialogResult.Yes Then
            _RunSQL("DELETE FROM rm_msk WHERE (no_lab='" & tnolab.Text & "')")
            Me.Rm_mskTableAdapter.Fill(Me.HCQC_serverDataSet.rm_msk)
            Me.tnolab.Focus()
            Me.MetroGrid1.Update()
            bersihkan()
        ElseIf result = DialogResult.No Then
            Me.tnolab.Focus()
        End If
    End Sub

    Private Sub MetroButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton2.Click
        '
        'penomoran Automatis
        AutoNumber()
        '
        btnSave.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
    End Sub

    'Coding untuk penomoran automatis pada datagrid
    Private Sub MetroGrid1_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles MetroGrid1.RowPostPaint
        MetroGrid1 = DirectCast(sender, DataGridView)
        Dim rowNumber As String = (e.RowIndex + 1).ToString()
        While rowNumber.Length < MetroGrid1.RowCount.ToString().Length
            rowNumber = "0" & rowNumber
        End While

        Dim size As SizeF = e.Graphics.MeasureString(rowNumber, Me.Font)
        If MetroGrid1.RowHeadersWidth < CInt(size.Width + 20) Then
            MetroGrid1.RowHeadersWidth = CInt(size.Width + 20)
        End If

        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(rowNumber, MetroGrid1.Font, b, e.RowBounds.Location.X + 15, _
        e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

    Private Sub tvariety_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvariety.GotFocus
        tvariety.SelectAll()
    End Sub

    Private Sub tfarmer_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tfarmer.GotFocus
        tfarmer.SelectAll()
    End Sub

    Private Sub tlokasi_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tlokasi.GotFocus
        tlokasi.SelectAll()
    End Sub

    Private Sub tDatehvs_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tDatehvs.GotFocus
        tDatehvs.SelectAll()
    End Sub

    Private Sub tweight_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tweight.GotFocus
        tweight.SelectAll()
    End Sub

    Private Sub tTgl_in_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tTgl_in.GotFocus, Ttgl_srtjln.GotFocus
        tTgl_in.SelectAll()
    End Sub

    Private Sub tbrt_in_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbrt_in.GotFocus
        tbrt_in.SelectAll()
    End Sub

    Private Sub tPPC_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tPPC.GotFocus
        tPPC.SelectAll()
    End Sub

    Private Sub tab_label_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tab_label.GotFocus
        tab_label.SelectAll()
    End Sub

    Private Sub tab_kmsn_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tab_kmsn.GotFocus
        tab_kmsn.SelectAll()
    End Sub

    Private Sub tab_bnh_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tab_bnh.GotFocus
        tab_bnh.SelectAll()
    End Sub

    Private Sub tKet_FormClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub tKet_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tKet.GotFocus
        tKet.SelectAll()
    End Sub

    Public Sub bersihkan()
        tvariety.Text = ""
        tfarmer.Text = ""
        tlokasi.Text = ""
        tDatehvs.Text = ""
        tweight.Text = ""
        tbrt_in.Text = ""
        'tPPC.Text = ""
        tKet.Text = ""
    End Sub
End Class