Imports System.Globalization
Imports System.Text.RegularExpressions
Imports MetroFramework
Imports MetroFramework.Forms
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommandBuilder
Imports System.Data
Public Class Inspection_Raw_Material_Seedless
    Dim myTextBoxes As New List(Of MetroFramework.Controls.MetroTextBox)
    Dim DateCheck As Boolean = True
    Private Function Calculate(ByVal TheTextboxes As List(Of MetroFramework.Controls.MetroTextBox)) As String
        Dim ReturnValue As String = String.Empty
        Dim TextBoxSum As Integer = 0
        Dim Items As Integer = 0
        Dim TextBoxValue As Integer = 0
        For Each SingleTextBox As MetroFramework.Controls.MetroTextBox In TheTextboxes
            If Integer.TryParse(SingleTextBox.Text, TextBoxValue) Then
                TextBoxSum += TextBoxValue
                Items += 1
            End If
        Next
        If Items > 0 Then
            ReturnValue = (TextBoxSum / Items).ToString
        End If

        Return ReturnValue
    End Function

    Private Sub Inspection_Raw_Material_Seedless_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub Inspection_Raw_Material_Seedless_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        myTextBoxes.Add(tVg1)
        myTextBoxes.Add(tVg2)
        myTextBoxes.Add(tVg3)
        myTextBoxes.Add(tVg4)
        Me.MetroToolTip1.IsBalloon = True
    End Sub

    Private Sub tVg1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tVg1.GotFocus
        tVg1.SelectAll()
    End Sub

    Private Sub tVg2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tVg2.GotFocus
        tVg2.SelectAll()
    End Sub

    Private Sub tVg3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tVg3.GotFocus
        tVg3.SelectAll()
    End Sub

    Private Sub tVg4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tVg4.GotFocus
        tVg4.SelectAll()
    End Sub

    Private Sub tVgArg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tVg1.TextChanged, tVg2.TextChanged, tVg3.TextChanged, tVg4.TextChanged
        tVgArg.Text = Calculate((myTextBoxes))
    End Sub

    Private Sub tVgArg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tVgArg.GotFocus
        tVgArg.SelectAll()
    End Sub

    Private Sub tVgPrc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tVgArg.TextChanged
        'tVgPrc.Text = CInt(tVgArg.Text)
        Dim ts1, ts2, ts3, ts4, TTL As Decimal
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
        TTL = (ts1 + ts2 + ts3 + ts4) / Val(tbagi.Text) '.ToString("00.00")
        tVgPrc.Text = Math.Round(TTL, MidpointRounding.AwayFromZero)
    End Sub

    Private Sub tVgPrc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tVgPrc.GotFocus
        tVgPrc.SelectAll()
    End Sub

    Private Sub btncari1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncari1.Click
        Dim sql As String = ""
        openDB()
        sql = "Select * From rm_inp WHERE (no_lab= '" & tno_lab.Text & "')"
        cmd = New SqlClient.SqlCommand(sql, con)
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        dread = cmd.ExecuteReader
        If dread.Read = False Then
            openDB()
            sql = "Select * From rm_msk WHERE (no_lab= '" & tno_lab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                tvariety.Text = dread.Item("variety")
                tfarmer.Text = dread.Item("farmer")
                tweight.Text = dread.Item("weight")
                tlokasi.Text = dread.Item("lokasi")
                'Me.Wip_mt2TableAdapter.Fill(Me.HCQC_serverDataSet.wip_mt2)
            Else
                Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Sample Belum ada!. Apakah anda ingin melanjutkan pencarian data?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
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

    Private Sub btnCari2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari2.Click
        Dim sql As String = ""
        Try
            openDB()
            sql = "Select * From rm_inp WHERE (no_lab= '" & tno_lab.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                tVg1.Text = dread.Item("te1").ToString '("0,0")
                tVg2.Text = dread.Item("te2").ToString '("0,0")
                tVg3.Text = dread.Item("te3").ToString
                tVg4.Text = dread.Item("te4").ToString
                tVgArg.Text = dread.Item("tearg").ToString '("0.0")
                tVgPrc.Text = dread.Item("teprc").ToString
                Dim tgluji As Date = dread.Item("Dt_t")
                Dim tglfn As Date = dread.Item("Cont_date")
                tgl_uji.Text = tgluji.ToString("dd-MM-yyyy")
                tgl_fn.Text = tglfn.ToString("dd-MM-yyyy")
                tanalys.Text = dread.Item("analys")
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
                openDB()
                sql = "Select * From rm_msk WHERE (no_lab= '" & tno_lab.Text & "')"
                cmd = New SqlClient.SqlCommand(sql, con)
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                dread = cmd.ExecuteReader
                If dread.Read = True Then
                    tvariety.Text = dread.Item("variety")
                    tfarmer.Text = dread.Item("farmer")
                    tweight.Text = dread.Item("weight")
                    tlokasi.Text = dread.Item("lokasi")
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

    Private Sub tno_lab_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tno_lab.GotFocus
        Me.AcceptButton = btncari1
    End Sub

    'Hide the tooltip if the user starts typing again before the five-second display limit on the tooltip expires.
    Private Sub tgl_uji_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tgl_uji.KeyDown
        Me.MetroToolTip1.Hide(Me.tgl_uji)
    End Sub

    Private Sub tgl_uji_TypeValidationCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.TypeValidationEventArgs) Handles tgl_uji.TypeValidationCompleted
        If (Not e.IsValidInput) Then
            Me.MetroToolTip1.ToolTipTitle = "invalid Date"
            Me.MetroToolTip1.Show("The data you supplied must be a valid date in the format dd-mm-yyyy.", Me.tgl_uji, -5, -30, 5000)
            e.Cancel = True
        End If
    End Sub

    'Hide the tooltip if the user starts typing again before the five-second display limit on the tooltip expires.
    Private Sub tgl_fn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tgl_fn.KeyDown
        Me.MetroToolTip1.Hide(Me.tgl_fn)
    End Sub

    Private Sub tgl_fn_TypeValidationCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.TypeValidationEventArgs) Handles tgl_fn.TypeValidationCompleted
        If (Not e.IsValidInput) Then
            Me.MetroToolTip1.ToolTipTitle = "invalid Date"
            Me.MetroToolTip1.Show("The data you supplied must be a valid date in the format dd-mm-yyyy.", Me.tgl_fn, -5, -30, 5000)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If tno_lab.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "No. Lab harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tvariety.Focus()
        ElseIf tvariety.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Variety harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tweight.Focus()
        ElseIf tgl_uji.MaskCompleted = False Then
            Dim UseDate As DateTime = CDate(tgl_uji.Text)
            If (UseDate < DateTime.Now) Then
                Me.MetroToolTip1.ToolTipTitle = "Invalid Date"
                Me.MetroToolTip1.Show("The date in this field must be greate than today's date.", Me.tgl_uji, -5, -30, 5000)
                'tgl_uji.Focus()
            End If
        ElseIf tgl_fn.MaskCompleted = False Then
            Dim UseDate As DateTime = CDate(tgl_fn.Text)
            If (UseDate < DateTime.Now) Then
                Me.MetroToolTip1.ToolTipTitle = "Invalid Date"
                Me.MetroToolTip1.Show("The date in this field must be greate than today's date.", Me.tgl_fn, -5, -30, 5000)
                'tgl_uji.Focus()
            End If
        Else
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
            Dim hrini As Date = Today
            _RunSQL("INSERT INTO rm_inp(no_lab, te1, te2, te3, te4, tearg, teprc, Dt_t, Cont_date, analys, tgl_input, vg_mtd) " & _
                    "VALUES('" & tno_lab.Text & "','" & Val(tVg1.Text) & "','" & Val(tVg2.Text) & "','" & Val(tVg3.Text) & "','" & Val(tVg4.Text) & "','" & Val(tVgArg.Text) & "','" & Val(tVgPrc.Text) & "','" & CDate(tgl_uji.Text) & "','" & CDate(tgl_fn.Text) & "','" & tanalys.Text & "','" & Now & "','" & mtd & "')")
            ''Me.Wip_mt2TableAdapter.Fill
            tno_lab.Focus()
            bersihkan()
            'MsgBox("saved")
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If tno_lab.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "No. Lab harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tvariety.Focus()
        ElseIf tvariety.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Variety harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tweight.Focus()
        ElseIf tgl_fn.MaskCompleted = False Then
            Dim UseDate As DateTime = CDate(tgl_fn.Text)
            If (UseDate < CDate(tgl_uji.Text)) Then
                Me.MetroToolTip1.ToolTipTitle = "Invalid Date"
                Me.MetroToolTip1.Show("The date in this field must be greate than Test Date.", Me.tgl_fn, -5, -30, 5000)
                'tgl_uji.Focus()
            End If
        Else
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
            Dim hrini As Date = Today
            _RunSQL("UPDATE rm_inp SET te1='" & Val(tVg1.Text) & "', te2='" & Val(tVg2.Text) & "', te3='" & Val(tVg3.Text) & "', te4='" & Val(tVg4.Text) & "', tearg='" & Val(tVgArg.Text) & "', teprc='" & Val(tVgPrc.Text) & "', Dt_t='" & CDate(tgl_uji.Text) & "', Cont_date='" & CDate(tgl_fn.Text) & "', analys='" & tanalys.Text & "', tgl_input='" & Now & "', vg_mtd='" & mtd & "' WHERE (no_lab = '" & tno_lab.Text & "')")
            ''Me.Wip_mt2TableAdapter.Fill
            tno_lab.Focus()
            bersihkan()
            'MsgBox("saved")
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If tno_lab.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "No. Lab harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tvariety.Focus()
        ElseIf tvariety.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Variety harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tweight.Focus()
            Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk menghapus data ini " + tno_lab.Text, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
            If result = DialogResult.Yes Then
                _RunSQL("DELETE FROM rm_inp WHERE(no_lab = '" & tno_lab.Text & "')")
                'Me.Wip_mt2TableAdapter.Fill(Me.HCQC_serverDataSet.wip_mt2)
                Me.tno_lab.Focus()
                bersihkan()
            ElseIf result = DialogResult.No Then
                btnSave.Enabled = True
                btnEdit.Enabled = False
                btnDelete.Enabled = False
                Me.tno_lab.Focus()
            End If
        End If
    End Sub

    Public Sub bersihkan()
        tVg1.Text = ""
        tVg2.Text = ""
        tVg3.Text = ""
        tVg4.Text = ""
        tVgArg.Text = ""
        tVgPrc.Text = ""
    End Sub
End Class
