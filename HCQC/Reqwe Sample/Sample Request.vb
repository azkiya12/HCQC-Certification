Imports DgvFilterPopup
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports MetroFramework
Imports MetroFramework.Forms
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommandBuilder
Imports System.Data
Public Class Sample_Request

    Public Sub Bersihkan()
        tnolab.Text = ""
        tvariety.Text = ""
        tnomnl.Text = ""
        tnojob.Text = ""
        tdatehvs.Text = ""
        tweight.Text = ""
        'tcls.Text = ""
        tPPC2.Text = ""
        tket.Text = ""
        chkKA.Checked = False
        chkRaf.Checked = False
        chkDT.Checked = False
        chkRepro.Checked = False
        chkWIP.Checked = False
    End Sub

    Private Sub Sample_Request_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub Sample_Request_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCQC_serverDataSet.spl_rqwe' table. You can move, or remove it, as needed.
        Me.Spl_rqweTableAdapter.Fill(Me.HCQC_serverDataSet.spl_rqwe)

        ''METROGRID1
        Dim DgvFilter As New DgvFilterManager With {
            .DataGridView = MetroGrid1
        }
        MetroGrid1.ColumnHeadersHeight = 25
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        _RunSQL("INSERT INTO spl_rqwe" &
                      "(variety, nomnl, nojob, class, hv_dt, weight, uji_ka, uji_ra, uji_dt, ket, repro, wip, in_by, input_date, update_date)" &
                "VALUES     ('" & tvariety.Text & "','" & tnomnl.Text & "','" & tnojob.Text & "','" & tcls.Text & "','" & tdatehvs.Text & "','" & tweight.Text & "','" & chkKA.CheckState & "','" & chkRaf.CheckState & "','" & chkDT.CheckState & "','" & tket.Text & "','" & chkRepro.Text & "','" & chkWIP.Text & "','" & tPPC2.Text & "','" & Now & "','" & Now & "')")
        Me.Spl_rqweTableAdapter.Fill(Me.HCQC_serverDataSet.spl_rqwe)
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
        _RunSQL("Update spl_rqwe " &
                 "SET              variety ='" & tvariety.Text & "', nomnl ='" & tnomnl.Text & "', nojob ='" & tnojob.Text & "', class ='" & tcls.Text & "', hv_dt ='" & tdatehvs.Text & "', weight ='" & tweight.Text & "', uji_ka ='" & chkKA.CheckState & "', uji_ra ='" & chkRaf.CheckState & "', uji_dt ='" & chkDT.CheckState & "', ket ='" & tket.Text & "', repro ='" & chkRepro.Text & "', wip ='" & chkWIP.Text & "', in_by ='" & tPPC2.Text & "', update_date='" & Now & "' " &
                 "WHERE     no_id ='" & tnolab.Text & "' ")
        Me.Spl_rqweTableAdapter.Fill(Me.HCQC_serverDataSet.spl_rqwe)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk menghapus data ini " + tnolab.Text, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
        If result = DialogResult.Yes Then
            _RunSQL("DELETE FROM spl_rqwe WHERE (no_id = '" & tnolab.Text & "')")
            Me.Spl_rqweTableAdapter.Fill(Me.HCQC_serverDataSet.spl_rqwe)
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
        e.Graphics.DrawString(rowNumber, MetroGrid1.Font, b, e.RowBounds.Location.X + 15,
        e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

    Private Sub tvarety_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvariety.GotFocus
        tvariety.SelectAll()
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

    Private Sub tket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tket.GotFocus
        tket.SelectAll()
    End Sub

    Private Sub tPPC2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tPPC2.GotFocus
        tPPC2.SelectAll()
    End Sub

    Private Sub tnolab_ButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tnolab.ButtonClick
        Try
            Dim sql As String = ""
            openDB()
            sql = "SELECT * FROM spl_rqwe WHERE (no_id= '" & tnolab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                tvariety.Text = dread.Item("variety")
                tnomnl.Text = dread.Item("nomnl")
                tnojob.Text = dread.Item("nojob")
                Dim tglhvs As Date = dread.Item("hv_dt")
                tdatehvs.Text = tglhvs.ToString("dd-MM-yyyy")
                tweight.Text = dread.Item("weight")
                tcls.Text = dread.Item("class")
                tPPC2.Text = dread.Item("in_by")
                tket.Text = dread.Item("ket")
                chkKA.Checked = dread.Item("uji_ka")
                chkRaf.Checked = dread.Item("uji_ra")
                chkDT.Checked = dread.Item("uji_dt")
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

End Class