Imports DgvFilterPopup
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports MetroFramework
Imports MetroFramework.Forms
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommandBuilder
Imports System.Data

Public Class PenerimaSampelGravity
    Dim tglnow As Date = Today
    Public jenis, Vstring, no1 As String
    Public Vtimes As Integer

    Public Sub AutoNumber()
        Try
            openDB()
            Dim sql As String = ""
            Dim strTam As String = ""
            Dim strVal As String = ""
            no1 = WindowsApplication1.Module2.ConvertToRomanNumeral(Month(Today)) + "/" + tglnow.ToString("yyyy")
            sql = "Select no_lab from wip_msk Where no_lab LIKE '%/" & no1 & "' ORDER by no_lab DESC"
            cmd = New SqlClient.SqlCommand(sql, con)
            dread = cmd.ExecuteReader
            If dread.Read() Then
                strTam = Mid(dread.Item("no_lab"), 2, 4)
            Else
                tnolab.Text = "G0001/" & WindowsApplication1.Module2.ConvertToRomanNumeral(Month(Today)) & "/" & Year(Today)
            End If
            strVal = Val(strTam) + 1
            jenis = strVal
            tnolab.Text = "G" & Mid("000", 1, 4 - strVal.Length) & strVal & "/" & WindowsApplication1.Module2.ConvertToRomanNumeral(Month(Today)) & "/" & Year(Today)

        Catch ex As Exception
            MsgBox("Terjadi Error : " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub PenerimaSampelGravity_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub PenerimaSampelGravity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Wip_mskTableAdapter.Fill(Me.HCQC_serverDataSet.wip_msk)
        MetroGrid1.ColumnHeadersHeight = 25
        tTgl_msk.Text = tglnow.ToString("dd-MM-yyyy")
        '
        'penomoran Automatis
        AutoNumber()
        '
        ''METROGRID1
        Dim DgvFilter As New DgvFilterManager
        DgvFilter.DataGridView = MetroGrid1
        MetroGrid1.ColumnHeadersHeight = 25
    End Sub
    Private Sub MetroButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton2.Click
        'Penomoran AutoNumber
        AutoNumber()

        btnSave.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        tvarety.Focus()
    End Sub
    Private Sub BtnCari1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari1.Click
        Try
            Dim sql As String = ""
            openDB()
            sql = "Select * From wip_msk WHERE (no_lab= '" & tnolab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                tppc.Text = dread.Item("taken")
                Dim tglmsk As Date = dread.Item("Dtqc")
                tTgl_msk.Text = tglmsk.ToString("dd-MM-yyyy")
                tnojob.Text = dread.Item("nojob")
                tcls.Text = dread.Item("class")
                tvarety.Text = dread.Item("variety")
                Dim tglhvs As Date = dread.Item("hv_dt")
                tdatehvs.Text = tglhvs.ToString("dd-MM-yyyy")
                tnomnl.Text = dread.Item("nomnl")
                tweight.Text = dread.Item("weight")
                tbrt_msk.Text = dread.Item("brt_in")
                chkKA.Checked = dread.Item("uji_ka")
                chkRaf.Checked = dread.Item("uji_ra")
                chkDT.Checked = dread.Item("uji_dt")
                tab_kmsn.Text = dread.Item("ab_kmsn")
                tab_bnh.Text = dread.Item("ab_bnh")
                tab_label.Text = dread.Item("ab_label")
                tket.Text = dread.Item("ket")
                tuk_bnh.Text = dread.Item("uk_bnh")
                tPPC2.Text = dread.Item("ppc2")
                If dread.Item("repro").ToString = chkRepro.Text Then
                    chkRepro.Checked = True
                Else
                    chkRepro.Checked = False
                End If
                If dread.Item("wip").ToString = chkWIP.Text Then
                    chkWIP.Checked = True
                Else
                    chkWIP.Checked = False
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
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Error : " & ex.Message, Me.Text, MessageBoxButtons.OK, 211)
            Return
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnCari2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari2.Click
        Dim xloop1 As Integer
        Dim sPola As String
        Dim sbuka As String
        Dim SBetul As Boolean

        sPola = tnojob.Text + "*"

        For xloop1 = 1 To MetroGrid1.RowCount - 1
            sbuka = MetroGrid1.Rows(xloop1 - 1).Cells(4).Value
            SBetul = UCase(sbuka) Like UCase(sPola)
            If SBetul = True Then
                MetroGrid1.CurrentCell = MetroGrid1.Item(0, xloop1 - 1)
                Exit Sub
            End If
        Next
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim vrepro As String = ""
        If chkRepro.Checked = True Then
            vrepro = chkRepro.Text
        ElseIf chkRepro.Checked = False Then
            vrepro = ""
        End If

        Dim vwip As String = ""
        If chkWIP.Checked = True Then
            vwip = chkWIP.Text
        ElseIf chkWIP.Checked = False Then
            vwip = ""
        End If

        Try
            If tvarety.Text = "" Then
                MetroFramework.MetroMessageBox.Show(Me, "Variety harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                tvarety.Focus()
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
            ElseIf tbrt_msk.Text = "" Then
                MetroFramework.MetroMessageBox.Show(Me, "Berat Masuk harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                tbrt_msk.Focus()
            ElseIf tppc.Text = "" Then
                MetroFramework.MetroMessageBox.Show(Me, "PPC harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                tppc.Focus()
            Else
                'Perulangan tidak diterapkan pada GRAVITY
                'Proses Insert Rerecord Database
                '
                _RunSQL("INSERT INTO wip_msk(no_lab, taken, Dtqc, nojob, class, variety, hv_dt, nomnl, weight, brt_in, uji_ka, uji_ra, uji_dt, ab_kmsn, ab_bnh, ab_label, ket, repro, wip, uk_bnh, ppc2) " &
                        "VALUES('" & tnolab.Text & "','" & tppc.Text & "','" & CDate(tTgl_msk.Text) & "','" & tnojob.Text & "','" & tcls.Text & "','" & tvarety.Text & "','" & CDate(tdatehvs.Text) & "','" & tnomnl.Text & "','" & Val(tweight.Text) & "','" & Val(tbrt_msk.Text) & "','" & chkKA.CheckState & "','" & chkRaf.CheckState & "','" & chkDT.CheckState & "','" & tab_kmsn.Text & "','" & tab_bnh.Text & "','" & tab_label.Text & "','" & tket.Text & "','" & vrepro & "','" & vwip & "','" & tuk_bnh.Text & "','" & tPPC2.Text & "')")
                Me.Wip_mskTableAdapter.Fill(Me.HCQC_serverDataSet.wip_msk)
                Bersihkan()
                '
                'Penomoran Automatis
                '
                AutoNumber()

            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Error : " & ex.Message, Me.Text, MessageBoxButtons.OK, 211)
            Return
        End Try
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        Dim vrepro As String = ""
        If chkRepro.Checked = True Then
            vrepro = chkRepro.Text
        ElseIf chkRepro.Checked = False Then
            vrepro = ""
        End If

        Dim vwip As String = ""
        If chkWIP.Checked = True Then
            vwip = chkWIP.Text
        ElseIf chkWIP.Checked = False Then
            vwip = ""
        End If

        'perbaikan 
        _RunSQL("UPDATE wip_msk SET taken ='" & tppc.Text & "', Dtqc ='" & CDate(tTgl_msk.Text) & "', nomnl='" & tnomnl.Text & "',nojob ='" & tnojob.Text & "', class ='" & tcls.Text & "', variety ='" & tvarety.Text & "', hv_dt ='" & CDate(tdatehvs.Text) & "', weight ='" & Val(tweight.Text) & "', brt_in ='" & Val(tbrt_msk.Text) & "', uji_ka ='" & chkKA.CheckState & "', uji_ra ='" & chkRaf.CheckState & "', uji_dt ='" & chkDT.CheckState & "', ab_kmsn ='" & tab_kmsn.Text & "',ab_bnh='" & tab_bnh.Text & "', ab_label='" & tab_label.Text & "', ket ='" & tket.Text & "', repro ='" & vrepro & "', wip ='" & vwip & "', uk_bnh='" & tuk_bnh.Text & "', ppc2='" & tPPC2.Text & "' WHERE (no_lab='" & tnolab.Text & "')")
        Me.Wip_mskTableAdapter.Fill(Me.HCQC_serverDataSet.wip_msk)
        Bersihkan()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk menghapus data ini " + tnolab.Text, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
        If result = DialogResult.Yes Then
            _RunSQL("DELETE FROM wip_msk WHERE (no_lab = '" & tnolab.Text & "')")
            Me.Wip_mskTableAdapter.Fill(Me.HCQC_serverDataSet.wip_msk)
            Me.tnolab.Focus()
            Me.MetroGrid1.Update()
            Bersihkan()
        ElseIf result = DialogResult.No Then
            btnSave.Enabled = True
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            Me.tnolab.Focus()
        End If

    End Sub

    Private Sub tnolab_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tnolab.GotFocus
        Me.AcceptButton = btnCari1
    End Sub

    'penomoran pada MetroGrid view
    Private Sub MetroGrid1_RowEnter(ByVal sender As Object, ByVal e As DataGridViewRowPostPaintEventArgs) Handles MetroGrid1.RowPostPaint

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

    Private Sub tnojob_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tnojob.LostFocus
        Me.AcceptButton = Nothing
    End Sub
    Public Sub Bersihkan()
        tvarety.Text = ""
        tnomnl.Text = ""
        tnojob.Text = ""
        tdatehvs.Text = ""
        tweight.Text = ""
        'tcls.Text=""
        'tTgl_msk.Text = ""
        tbrt_msk.Text = ""
        chkRepro.Checked = False
        chkWIP.Checked = False
        'tab_kmsn.Text = ""
        'tab_bnh.Text = ""
        'tab_label.Text = ""
        tket.Text = ""

    End Sub

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        Me.Wip_mskTableAdapter.Fill(Me.HCQC_serverDataSet.wip_msk)
    End Sub

    Private Sub tvarety_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvarety.GotFocus
        tvarety.SelectAll()
    End Sub

    Private Sub tnomnl_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tnomnl.GotFocus
        tnomnl.SelectAll()
    End Sub

    Private Sub tnojob_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tnojob.GotFocus
        Me.AcceptButton = btnCari2
        tnojob.SelectAll()
    End Sub

    Private Sub tweight_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tweight.GotFocus
        tweight.SelectAll()
    End Sub

    Private Sub tcls_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tcls.GotFocus
        tcls.SelectAll()
    End Sub

    Private Sub tbrt_msk_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbrt_msk.GotFocus
        tbrt_msk.SelectAll()
    End Sub

    Private Sub tppc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tppc.GotFocus
        tppc.SelectAll()
    End Sub

    Private Sub tbrt_out_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tab_kmsn.GotFocus
        tab_kmsn.SelectAll()
    End Sub

    Private Sub tppc2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tab_bnh.GotFocus
        tab_bnh.SelectAll()
    End Sub

    Private Sub tab_label_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tab_label.GotFocus
        tab_label.SelectAll()
    End Sub

    Private Sub tket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tket.Click
        tket.SelectAll()
    End Sub

    Private Sub MetroButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class