Imports DgvFilterPopup
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports MetroFramework
Imports MetroFramework.Forms
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommandBuilder
Imports System.Data

Public Class PenerimaanSamplePeriodik
    Dim tglnow As Date = Today
    Public jenis, Vstring, no1 As String
    Public Vtimes As Integer

    Private Sub PenerimaanSamplePeriodik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCQC_serverDataSet.periodik_msk' table. You can move, or remove it, as needed.
        Me.Periodik_mskTableAdapter.Fill(Me.HCQC_serverDataSet.periodik_msk)
        MetroGrid1.ColumnHeadersHeight = 25
        tTgl_msk.Text = tglnow.ToString("dd-MM-yyyy")

        'Pernomoran Automatis
        Try
            If openDB() = False Then
                MsgBox("Tidak Terhubung ke Database")
            Else
                Dim sql As String = ""
                Dim strTam As String = ""
                Dim strVal As String = ""
                no1 = Module2.ConvertToRomanNumeral(Month(Today)) + "/" + tglnow.ToString("yyyy")
                sql = "Select no_lab from periodik_msk Where no_lab LIKE '%/" & no1 & "' ORDER by no_lab DESC"
                cmd = New SqlClient.SqlCommand(sql, con)
                dread = cmd.ExecuteReader
                If dread.Read() Then
                    strTam = Mid(dread.Item("no_lab"), 2, 4)
                Else
                    tnolab.Text = "P0001/" & Module2.ConvertToRomanNumeral(Month(Today)) & "/" & Year(Today)
                End If
                strVal = Val(strTam) + 1
                jenis = strVal
                tnolab.Text = "P" & Mid("000", 1, 4 - strVal.Length) & strVal & "/" & Module2.ConvertToRomanNumeral(Month(Today)) & "/" & Year(Today)
            End If
        Catch ex As Exception
            MsgBox("Terjadi Error : " & ex.Message)
        Finally
            con.Close()
        End Try

        ''METROGRID1
        Dim DgvFilter As New DgvFilterManager
        DgvFilter.DataGridView = MetroGrid1
        MetroGrid1.ColumnHeadersHeight = 25
    End Sub
    Private Sub MetroButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton2.Click
        Try
            If openDB() = False Then
                MsgBox("Tidak Terhubung ke Database")
            Else
                Dim sql As String = ""
                Dim strTam As String = ""
                Dim strVal As String = ""
                no1 = Module2.ConvertToRomanNumeral(Month(Today)) + "/" + tglnow.ToString("yyyy")
                sql = "Select no_lab from periodik_msk Where no_lab LIKE '%/" & no1 & "' ORDER by no_lab DESC"
                cmd = New SqlClient.SqlCommand(sql, con)
                dread = cmd.ExecuteReader
                If dread.Read() Then
                    strTam = Mid(dread.Item("no_lab"), 2, 4)
                Else
                    tnolab.Text = "P0001/" & Module2.ConvertToRomanNumeral(Month(Today)) & "/" & Year(Today)
                End If
                strVal = Val(strTam) + 1
                jenis = strVal
                tnolab.Text = "P" & Mid("000", 1, 4 - strVal.Length) & strVal & "/" & Module2.ConvertToRomanNumeral(Month(Today)) & "/" & Year(Today)
            End If
        Catch ex As Exception
            MsgBox("Terjadi Error : " & ex.Message)
        Finally
            con.Close()
        End Try
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnEdit.Enabled = False
    End Sub
    Private Sub MetroTile1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile1.Click

        Try
            Dim sql As String = ""
            openDB()
            sql = "Select * From periodik_msk WHERE (no_lab= '" & tnolab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                tPPC.Text = dread.Item("taken")

                Dim tglmsk As Date = dread.Item("Dtqc")
                tTgl_msk.Text = tglmsk.ToString("dd-MM-yyyy")

                tnojob.Text = dread.Item("nojob")
                tcls.Text = dread.Item("class")
                tvariety.Text = dread.Item("variety")

                Dim tglhvs As Date = dread.Item("hv_dt")
                tdatehvs.Text = tglhvs.ToString("dd-MM-yyyy")

                tnomnl.Text = dread.Item("nomnl")
                tweight.Text = dread.Item("weight")
                tBrt_in.Text = dread.Item("brt_in")
                chkuji_KA.Checked = dread.Item("uji_ka")
                chkuji_RA.Checked = dread.Item("uji_ra")
                chkuji_DT.Checked = dread.Item("uji_dt")
                tPPC2.Text = dread.Item("ppc2")
                tab_kmsn.Text = dread.Item("ab_kmsn")
                tab_bnh.Text = dread.Item("ab_bnh")
                tab_label.Text = dread.Item("ab_label")
                tket.Text = dread.Item("ket")
                tuk_bnh.Text = dread.Item("uk_bnh")

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
    'Private Sub tnojob_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tnojob.LostFocus
    '    Me.AcceptButton = Nothing
    'End Sub
    Private Sub MetroTile2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile2.Click
        Dim xloop1 As Integer
        Dim sPola As String
        Dim sbuka As String
        Dim SBetul As Boolean

        sPola = tnojob.Text + "*"

        For xloop1 = 1 To MetroGrid1.RowCount - 1
            sbuka = MetroGrid1.Rows(xloop1 - 1).Cells(3).Value
            SBetul = UCase(sbuka) Like UCase(sPola)
            If SBetul = True Then
                MetroGrid1.CurrentCell = MetroGrid1.Item(0, xloop1 - 1)
                Exit Sub
            End If
        Next

    End Sub
    Public Sub Bersihkan()
        tvariety.Text = ""
        tnomnl.Text = ""
        tnojob.Text = ""
        tdatehvs.Text = ""
        tweight.Text = ""
        'tcls.Text=""
        'tTgl_msk.Text = ""
        tBrt_in.Text = ""
        'tab_kmsn.Text = ""
        'tab_bnh.Text = ""
        'tab_label.Text = ""
        tket.Text = ""

    End Sub

    Public Sub Perulangan()
        'Penentuan banyak Bulan berikutnya untuk di Test Ulang
        'DENGAN VARIABEL "Vtime" sebagai acuan
        Vstring = Left(tvariety.Text, 2)
        If (Vstring <> "SC") And (Vstring <> "WM") Then
            Vtimes = 3
            Vstring = Left(tvariety.Text, 2)
            jenis = "True"
        Else
            If (Left(tvariety.Text, 2) = "SC") Then
                Vstring = "SC"
                Vstring = Left(tvariety.Text, 2)
                'mengabil value bulan berikutnya pada database
                Vtimes = Val(_DataToValue("SELECT times FROM plot WHERE (variety LIKE '" & Vstring & "%')"))
            ElseIf tvariety.Text = "WM-1002" Or tvariety.Text = "WM-1012" Or tvariety.Text = "WM-1017" Or tvariety.Text = "WM-1029" Or tvariety.Text = "WM-1032" Then
                Vstring = tvariety.Text
                Vstring = Left(tvariety.Text, 2)
                'mengabil value bulan berikutnya pada database
                Vtimes = Val(_DataToValue("SELECT times FROM plot WHERE (variety LIKE '" & Vstring & "%')"))
            Else
                Vtimes = 3
            End If
        End If
    End Sub

    Private Shadows Function Left(text As String, v As Integer) As String
        Throw New NotImplementedException()
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If tvariety.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Variety harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tvariety.Focus()
        ElseIf tnojob.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "No Job harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tnojob.Focus()
        ElseIf tdatehvs.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Harvest Date harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tdatehvs.Focus()
        ElseIf tweight.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Weight(kg) harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tweight.Focus()
        ElseIf tcls.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Class harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tcls.Focus()
        ElseIf tBrt_in.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Berat Masuk harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tBrt_in.Focus()
        ElseIf tPPC.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "PPC harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tPPC.Focus()
        ElseIf tPPC2.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "PPC2 harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tPPC2.Focus()
        ElseIf tuk_bnh.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Ukuran Sampel harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tuk_bnh.Focus()
        Else
            'Penentuan banyak Bulan berikutnya untuk di Test Ulang
            'DENGAN VARIABEL "Vtime" sebagai acuan
            Perulangan()

            'Proses Insert Rerecord Database
            _RunSQL("INSERT INTO periodik_msk(no_lab, taken, Dtqc, nojob, class, variety, hv_dt, nomnl, weight, brt_in, uji_ka, uji_ra, uji_dt, ppc2, ab_kmsn, ab_bnh, ab_label, ket, uk_bnh, times)" &
                    "VALUES('" & tnolab.Text & "','" & tPPC.Text & "','" & CDate(tTgl_msk.Text) & "','" & tnojob.Text & "','" & tcls.Text & "','" & tvariety.Text & "','" & CDate(tdatehvs.Text) & "','" & tnomnl.Text & "','" & Val(tweight.Text) & "'," &
                           "'" & Val(tBrt_in.Text) & "','" & chkuji_KA.CheckState & "','" & chkuji_RA.CheckState & "','" & chkuji_DT.CheckState & "','" & tPPC2.Text & "','" & tab_kmsn.Text & "','" & tab_bnh.Text & "','" & tab_label.Text & "','" & tket.Text & "','" & tuk_bnh.Text & "','" & Vtimes & "')")
            'Me.Periodik_mskTableAdapter.Fill(Me.HCQC_serverDataSet.periodik_msk)
            Bersihkan()
            Try
                openDB()
                Dim sql As String = ""
                Dim strTam As String = ""
                Dim strVal As String = ""
                no1 = Module2.ConvertToRomanNumeral(Month(Today)) + "/" + tglnow.ToString("yyyy")
                sql = "Select no_lab from periodik_msk Where no_lab LIKE '%/" & no1 & "' ORDER by no_lab DESC"
                cmd = New SqlClient.SqlCommand(sql, con)
                dread = cmd.ExecuteReader
                If dread.Read() Then
                    strTam = Mid(dread.Item("no_lab"), 2, 4)
                Else
                    tnolab.Text = "P0001/" & Module2.ConvertToRomanNumeral(Month(Today)) & "/" & Year(Today)
                End If
                strVal = Val(strTam) + 1
                jenis = strVal
                tnolab.Text = "P" & Mid("000", 1, 4 - strVal.Length) & strVal & "/" & Module2.ConvertToRomanNumeral(Month(Today)) & "/" & Year(Today)

            Catch ex As Exception
                MsgBox("Terjadi Error : " & ex.Message)
            Finally
                con.Close()
            End Try

        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        'Penentuan banyak Bulan berikutnya untuk di Test Ulang
        'DENGAN VARIABEL "Vtime" sebagai acuan
        Perulangan()

        'perbaikan 
        _RunSQL("UPDATE periodik_msk SET taken ='" & tPPC.Text & "', Dtqc ='" & CDate(tTgl_msk.Text) & "', nomnl='" & tnomnl.Text & "',nojob ='" & tnojob.Text & "', class ='" & tcls.Text & "', variety ='" & tvariety.Text & "', hv_dt ='" & CDate(tdatehvs.Text) & "'," & _
                " weight ='" & Val(tweight.Text) & "', brt_in ='" & Val(tBrt_in.Text) & "', uji_ka ='" & chkuji_KA.CheckState & "', uji_ra ='" & chkuji_RA.CheckState & "', uji_dt ='" & chkuji_DT.CheckState & "', ab_kmsn ='" & tab_kmsn.Text & "'," & _
                " ab_bnh='" & tab_bnh.Text & "', ab_label='" & tab_label.Text & "', ket ='" & tket.Text & "',uk_bnh='" & tuk_bnh.Text & "',times='" & Vtimes & "',ppc2='" & tPPC2.Text & "'" & _
                " WHERE (no_lab='" & tnolab.Text & "')")
        Me.Periodik_mskTableAdapter.Fill(Me.HCQC_serverDataSet.periodik_msk)
        Bersihkan()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk menghapus data ini " + tnolab.Text, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
        If result = DialogResult.Yes Then
            _RunSQL("DELETE FROM periodik_msk WHERE (no_lab = '" & tnolab.Text & "')")
            Me.Periodik_mskTableAdapter.Fill(Me.HCQC_serverDataSet.periodik_msk)
            Me.tnolab.Focus()
            Me.MetroGrid1.Update()
            Bersihkan()
        ElseIf result = DialogResult.No Then
            Me.tnolab.Focus()
        End If
    End Sub

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

    Private Sub tnomnl_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tnomnl.GotFocus
        tnomnl.SelectAll()
    End Sub

    Private Sub tnolab_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tnolab.GotFocus
        Me.AcceptButton = MetroTile1
        tnolab.SelectAll()
    End Sub

    Private Sub tnojob_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tnojob.GotFocus
        Me.AcceptButton = MetroTile2
        tnojob.SelectAll()
    End Sub

    Private Sub tnojob_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tnojob.LostFocus
        Me.AcceptButton = Nothing
    End Sub

    Private Sub tdatehvs_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdatehvs.GotFocus
        tdatehvs.SelectAll()
    End Sub

    Private Sub tweight_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tweight.GotFocus
        tweight.SelectAll()
    End Sub

    Private Sub tcls_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tcls.GotFocus
        tcls.SelectAll()
    End Sub

    Private Sub tBrt_in_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tBrt_in.GotFocus
        tBrt_in.SelectAll()
    End Sub

    Private Sub tPPC_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tPPC.GotFocus
        tPPC.SelectAll()
    End Sub

    Private Sub tab_kmsn_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tab_kmsn.GotFocus
        tab_kmsn.SelectAll()
    End Sub

    Private Sub tab_bnh_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tab_bnh.GotFocus
        tab_bnh.SelectAll()
    End Sub

    Private Sub tab_label_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tab_label.GotFocus, tPPC2.GotFocus
        tab_label.SelectAll()
    End Sub

    Private Sub tket_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tket.GotFocus
        tket.SelectAll()
    End Sub

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        Me.Periodik_mskTableAdapter.Fill(Me.HCQC_serverDataSet.periodik_msk)
    End Sub
End Class