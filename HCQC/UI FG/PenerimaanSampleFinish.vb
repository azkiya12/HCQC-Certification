Imports DgvFilterPopup
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports MetroFramework
Imports MetroFramework.Forms
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommandBuilder
Imports System.Data

Public Class PenerimaanSampleFinish
    Dim tglnow As Date = Today
    Public jenis As String
    Public no1 As String

    Private Sub PenerimaanSampleFinish_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCQC_serverDataSet.fg_id' table. You can move, or remove it, as needed.
        Me.Fg_idTableAdapter.Fill(Me.HCQC_serverDataSet.fg_id)
        tTgl_msk.Text = tglnow.ToString("dd-MM-yyyy")
        'penomoran Automatis
        Try
            If openDB() = False Then
                MsgBox("Tidak Terhubung ke Database")
            Else
                Dim sql As String = ""
                Dim strTam As String = ""
                Dim strVal As String = ""
                no1 = WindowsApplication1.Module2.ConvertToRomanNumeral(Month(Today)) + "/" + tglnow.ToString("yyyy")
                sql = "Select no_lab from fg_id Where no_lab LIKE '%/" & no1 & "' ORDER by no_lab DESC"
                cmd = New SqlClient.SqlCommand(sql, con)
                dread = cmd.ExecuteReader
                If dread.Read() Then
                    'JIKA NO LAB DITEMUKAN LEBIH DARI SATU
                    strTam = Mid(dread.Item("no_lab"), 3, 4)
                Else
                    tnolab.Text = "FG0001/" & WindowsApplication1.Module2.ConvertToRomanNumeral(Month(Today)) & "/" & Year(Today)
                End If
                strVal = Val(strTam) + 1
                jenis = strVal
                tnolab.Text = "FG" & Mid("000", 1, 4 - strVal.Length) & strVal & "/" & WindowsApplication1.Module2.ConvertToRomanNumeral(Month(Today)) & "/" & Year(Today)
            End If
        Catch ex As Exception
            MsgBox("Terjadi Error : " & ex.Message)
        Finally
            con.Close()
        End Try
        btnEdit.Enabled = False
        btnDelete.Enabled = False
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
                no1 = WindowsApplication1.Module2.ConvertToRomanNumeral(Month(Today)) + "/" + tglnow.ToString("yyyy")
                sql = "Select no_lab from fg_id Where no_lab LIKE '%/" & no1 & "' ORDER by no_lab DESC"
                cmd = New SqlClient.SqlCommand(sql, con)
                dread = cmd.ExecuteReader
                If dread.Read() Then
                    'JIKA NO LAB DITEMUKAN LEBIH DARI SATU
                    strTam = Mid(dread.Item("no_lab"), 3, 4)
                Else
                    tnolab.Text = "FG0001/" & WindowsApplication1.Module2.ConvertToRomanNumeral(Month(Today)) & "/" & Year(Today)
                End If
                strVal = Val(strTam) + 1
                jenis = strVal
                tnolab.Text = "FG" & Mid("000", 1, 4 - strVal.Length) & strVal & "/" & WindowsApplication1.Module2.ConvertToRomanNumeral(Month(Today)) & "/" & Year(Today)
            End If
        Catch ex As Exception
            MsgBox("Terjadi Error : " & ex.Message)
        Finally
            con.Close()
        End Try
        btnSave.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        tvarety.Focus()
    End Sub

    Private Sub btnCari1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari1.Click

        Try
            Dim sql As String = ""
            openDB()
            sql = "Select * From fg_id WHERE (no_lab= '" & tnolab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                tvarety.Text = dread.Item("variety")
                tnojob.Text = dread.Item("nojob")
                Dim tglexp As Date = dread.Item("hv_dt")
                ttgl_exp.Text = tglexp.ToString("dd-MM-yyyy")
                tweight.Text = dread.Item("weight")
                tcls.Text = dread.Item("class")
                tuk_bnh.Text = dread.Item("uk_bnh")

                Dim tglmsk As Date = dread.Item("Dtqc")
                tTgl_msk.Text = tglmsk.ToString("dd-MM-yyyy")
                tbrt_msk.Text = dread.Item("brt_in")
                tppc.Text = dread.Item("take")
                tPPC2.Text = dread.Item("ppc2")

                chkST.Checked = dread.Item("st")
                chkKA.Checked = dread.Item("uji_ka")
                chkDT.Checked = dread.Item("uji_dt")

                tab_kmsn.Text = dread.Item("ab_kmsn")
                tab_bnh.Text = dread.Item("ab_bnh")
                tab_label.Text = dread.Item("ab_label")
                tket.Text = dread.Item("ket")

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
        ElseIf ttgl_exp.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Harvest Date harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            ttgl_exp.Focus()
        ElseIf tweight.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Weight(kg) harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tweight.Focus()
        ElseIf tcls.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Class harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tcls.Focus()
        ElseIf tbrt_msk.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Berat Masuk harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tbrt_msk.Focus()
        ElseIf tppc.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "PPC harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tppc.Focus()
        Else
            _RunSQL("INSERT INTO   fg_id " &
                    "(no_lab, take, Dtqc, to1, adres, nojob, class, variety, hv_dt, weight, brt_in, st, uji_ka, uji_dt, ket, ab_kmsn, ab_bnh, ab_label, uk_bnh, ppc2) " &
                    "VALUES ('" & tnolab.Text & "','" & tppc.Text & "','" & CDate(tTgl_msk.Text) & "','','','" & tnojob.Text & "','" & tcls.Text & "','" & tvarety.Text & "','" & CDate(ttgl_exp.Text) & "','" & Val(tweight.Text) & "','" & Val(tbrt_msk.Text) & "','" & chkST.CheckState & "','" & chkKA.CheckState & "','" & chkDT.CheckState & "'," &
                    "'" & tket.Text & "','" & tab_kmsn.Text & "','" & tab_bnh.Text & "','" & tab_label.Text & "', '" & tuk_bnh.Text & "','" & tPPC2.Text & "')")
            Me.Fg_idTableAdapter.Fill(Me.HCQC_serverDataSet.fg_id)
            Bersihkan()
            Try
                openDB()
                Dim sql As String = ""
                Dim strTam As String = ""
                Dim strVal As String = ""
                no1 = WindowsApplication1.Module2.ConvertToRomanNumeral(Month(Today)) + "/" + tglnow.ToString("yyyy")
                sql = "Select no_lab from fg_id Where no_lab LIKE '%/" & no1 & "' ORDER by no_lab DESC"
                cmd = New SqlClient.SqlCommand(sql, con)
                dread = cmd.ExecuteReader
                If dread.Read() Then
                    strTam = Mid(dread.Item("no_lab"), 3, 4)
                Else
                    tnolab.Text = "FG0001/" & WindowsApplication1.Module2.ConvertToRomanNumeral(Month(Today)) & "/" & Year(Today)
                End If
                strVal = Val(strTam) + 1
                jenis = strVal
                tnolab.Text = "FG" & Mid("000", 1, 4 - strVal.Length) & strVal & "/" & WindowsApplication1.Module2.ConvertToRomanNumeral(Month(Today)) & "/" & Year(Today)

            Catch ex As Exception
                MsgBox("Terjadi Error : " & ex.Message)
            Finally
                con.Close()
            End Try
           
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        _RunSQL("UPDATE    fg_id " & _
                    "SET       take ='" & tppc.Text & "', Dtqc ='" & CDate(tTgl_msk.Text) & "', nojob ='" & tnojob.Text & "', class ='" & tcls.Text & "', variety ='" & tvarety.Text & "', hv_dt ='" & CDate(ttgl_exp.Text) & "', weight ='" & Val(tweight.Text) & "', brt_in ='" & Val(tbrt_msk.Text) & "', st ='" & chkST.CheckState & "', uji_ka ='" & chkKA.CheckState & "', uji_dt ='" & chkDT.CheckState & "', ket ='" & tket.Text & "', ab_kmsn ='" & tab_kmsn.Text & "', ab_bnh ='" & tab_bnh.Text & "', ab_label ='" & tab_label.Text & "', uk_bnh='" & tuk_bnh.Text & "', ppc2='" & tPPC2.Text & "'" & _
                    "WHERE     (no_lab = '" & tnolab.Text & "')")
        Me.Fg_idTableAdapter.Fill(Me.HCQC_serverDataSet.fg_id)
        If strupdate = 1 Then
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            btnSave.Enabled = False
        End If
        Bersihkan()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk menghapus data ini " + tnolab.Text, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
        If result = DialogResult.Yes Then
            _RunSQL("DELETE FROM fg_id WHERE (no_lab = '" & tnolab.Text & "')")
            Me.Fg_idTableAdapter.Fill(Me.HCQC_serverDataSet.fg_id)
            Me.tnolab.Focus()
            Bersihkan()
        ElseIf result = DialogResult.No Then
            btnSave.Enabled = True
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            Me.tnolab.Focus()
        End If
    End Sub

    Private Sub MetroGrid1_RowEnter(ByVal sender As Object, ByVal e As DataGridViewRowPostPaintEventArgs) Handles MetroGrid1.RowPostPaint
        'penomoran pada MetroGrid view
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

    Public Sub Bersihkan()
        tvarety.Text = ""
        tnojob.Text = ""
        ttgl_exp.Text = ""
        tweight.Text = ""
        'tTgl_msk.Text = ""
        tbrt_msk.Text = ""

        'tab_kmsn.Text = ""
        'tab_bnh.Text = ""
        'tab_label.Text = ""
        tket.Text = ""

    End Sub

    Private Sub tnolab_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tnolab.GotFocus
        Me.AcceptButton = btnCari1
        tnolab.SelectAll()
    End Sub

    Private Sub tnojob_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tnojob.GotFocus
        Me.AcceptButton = MetroTile2
        tnojob.SelectAll()
    End Sub

    Private Sub tnojob_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tnojob.LostFocus
        Me.AcceptButton = Nothing
    End Sub

    Private Sub MetroTile2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile2.Click
        Dim xloop1 As Integer
        Dim sPola As String
        Dim sbuka As String
        Dim SBetul As Boolean

        sPola = tnojob.Text + "*"

        For xloop1 = 1 To MetroGrid1.RowCount - 1
            sbuka = MetroGrid1.Rows(xloop1 - 1).Cells(2).Value
            SBetul = UCase(sbuka) Like UCase(sPola)
            If SBetul = True Then
                MetroGrid1.CurrentCell = MetroGrid1.Item(0, xloop1 - 1)
                Exit Sub
            End If
        Next

    End Sub
End Class