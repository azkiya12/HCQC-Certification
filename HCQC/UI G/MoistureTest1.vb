Imports MetroFramework.Forms
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommandBuilder
Imports System.Data
Imports DgvFilterPopup

Public Class MoistureTest1
    Dim tglnow As Date = Today
    Public jenis As String
    Public no1 As String

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If tno_lab.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "No. Lab harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tvariety.Focus()
        ElseIf tvariety.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Variety harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tnojob.Focus()
        ElseIf tnojob.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "No Job harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tnojob.Focus()
        Else
            'Dim hrini As Date = Today
            Dim ck As Boolean = False
            _RunSQL("INSERT INTO wip_mt2(no_lab, mr1, mr2, avrg, Dt_t, analys, tgl_input, cek) VALUES('" & tno_lab.Text & "','" & Val(tmt1.Text) & "','" & Val(tmt2.Text) & "','" & Val(tmt_avrg.Text) & "','" & CDate(tTgl_mt.Text) & "','" & tanalys.Text & "','" & Now & "','" & ck & "')")
            Me.Wip_mt2TableAdapter.Fill(Me.HCQC_serverDataSet.wip_mt2)
            tno_lab.Focus()
            'Bersihkan()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        _RunSQL("UPDATE wip_mt2 SET mr1 ='" & Val(tmt1.Text) & "', mr2 ='" & Val(tmt2.Text) & "', avrg ='" & Val(tmt_avrg.Text) & "', Dt_t ='" & CDate(tTgl_mt.Text) & "', analys ='" & tanalys.Text & "' WHERE (no_lab = '" & tno_lab.Text & "')")
        Me.Wip_mt2TableAdapter.Fill(Me.HCQC_serverDataSet.wip_mt2)
    End Sub

    Private Sub AddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton2.Click
        openDB()
        Dim sql As String = "Select * From wip_mt2 WHERE (no_lab= '" & tno_lab.Text & "')"
        cmd = New SqlClient.SqlCommand(sql, con) With {
            .CommandType = CommandType.Text,
            .CommandText = sql
        }

        dread = cmd.ExecuteReader
        If dread.Read = False Then
            openDB()
            sql = "Select * From wip_msk WHERE (no_lab= '" & tno_lab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                tvariety.Text = dread.Item("variety")
                tnojob.Text = dread.Item("nojob")
                tnomnl.Text = dread.Item("nomnl")
                Me.Wip_mt2TableAdapter.Fill(Me.HCQC_serverDataSet.wip_mt2)
            Else
                Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data tidak ditemukan!. Apakah anda ingin melanjutkan pencarian data?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                If result = DialogResult.Yes Then
                    tno_lab.Focus()
                ElseIf result = DialogResult.No Then

                End If
            End If
        Else
            Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data sudah ada!. Apakah anda ingin melanjutkan pencarian data?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
            If result = DialogResult.Yes Then
                tno_lab.Focus()
            ElseIf result = DialogResult.No Then

            End If
        End If
        con.Close()
    End Sub

    Private Sub tCari1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tCari1.Click
        Dim sql As String = ""
        Try
            openDB()
            sql = "Select * From wip_mt2 WHERE (no_lab= '" & tno_lab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                tmt1.Text = dread.Item("mr1").ToString '("0,0")
                tmt2.Text = dread.Item("mr2").ToString '("0,0")
                tmt_avrg.Text = dread.Item("avrg").ToString '("0.0")
                Dim tglmsk As Date = dread.Item("Dt_t")
                tTgl_mt.Text = tglmsk.ToString("dd-MM-yyyy")
                tanalys.Text = dread.Item("analys")
                openDB()
                sql = "Select * From wip_msk WHERE (no_lab= '" & tno_lab.Text & "')"
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
                Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data tidak ditemukan!. Apakah anda ingin melanjutkan pencarian data?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                If result = DialogResult.Yes Then
                    tno_lab.Focus()
                ElseIf result = DialogResult.No Then
                    btnSave.Enabled = True
                    btnEdit.Enabled = False
                    btnDelete.Enabled = False
                    tno_lab.Focus()
                End If
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Error " + ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub MoistureTest1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub MoistureTest1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCQC_serverDataSet.wip_mt2' table. You can move, or remove it, as needed.
        Me.Wip_mt2TableAdapter.Fill(Me.HCQC_serverDataSet.wip_mt2)
        ''METROGRID1
        Dim DgvFilter As New DgvFilterManager
        DgvFilter.DataGridView = MetroGrid1
        MetroGrid1.ColumnHeadersHeight = 25
    End Sub

    Private Sub tmt1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmt1.GotFocus
        tmt1.SelectAll()
    End Sub

    Private Sub tmt2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmt2.GotFocus
        tmt2.SelectAll()
    End Sub

    Private Sub avrg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmt2.TextChanged, tmt2.TextChanged
        Dim mt1, mt2 As Decimal
        Try
            mt1 = Convert.ToDecimal(tmt1.Text)
        Catch
            mt1 = 0
        End Try
        Try
            mt2 = Convert.ToDecimal(tmt2.Text)
        Catch
            mt2 = 0
        End Try
        tmt_avrg.Text = ((mt1 + mt2) / 2).ToString("0.0")
    End Sub

    Private Sub tno_lab_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tno_lab.GotFocus
        Me.AcceptButton = MetroButton2
    End Sub

    Private Sub tno_lab_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tno_lab.LostFocus
        Me.AcceptButton = Nothing
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk menghapus data ini " + tno_lab.Text, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
        If result = DialogResult.Yes Then
            _RunSQL("DELETE FROM wip_mt2 WHERE(no_lab = '" & tno_lab.Text & "')")
            Me.Wip_mt2TableAdapter.Fill(Me.HCQC_serverDataSet.wip_mt2)
            Me.tno_lab.Focus()
            Me.MetroGrid1.Update()
            'Bersihkan()
        ElseIf result = DialogResult.No Then
            btnSave.Enabled = True
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            Me.tno_lab.Focus()
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
End Class