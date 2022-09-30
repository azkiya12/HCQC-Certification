Public Class Inspection_RM
    Dim myTextBoxes As New List(Of MetroFramework.Controls.MetroTextBox)

    Private Sub Inspection_RM_Load(sender As Object, e As EventArgs) Handles Me.Load
        myTextBoxes.Add(tVg1)
        myTextBoxes.Add(tVg2)
        myTextBoxes.Add(tVg3)
        myTextBoxes.Add(tVg4)

    End Sub

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
        openDB()
        Dim sql As String = "Select * From rm_inp WHERE (no_lab= '" & tlabnum.Text & "')"
        cmd = New SqlClient.SqlCommand(sql, con) With {
            .CommandType = CommandType.Text,
            .CommandText = sql
        }
        dread = cmd.ExecuteReader
        If dread.Read = False Then
            openDB()
            sql = "Select labnum From receipt WHERE (labnum= '" & tlabnum.Text & "')"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                Lreqnum.Text = _DataToValue("SELECT [id] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                Lvariety.Text = _DataToValue("SELECT [variety] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                Lfarmer.Text = _DataToValue("SELECT [farmer] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                Lharvest.Text = _DataToValue("SELECT [harvest] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                LLocation.Text = _DataToValue("SELECT [location] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                Ljob.Text = _DataToValue("SELECT [nojob] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
            Else
                Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Sample Belum ada!. Apakah anda ingin melanjutkan pencarian data?", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                If result = DialogResult.OK Then
                    tlabnum.Focus()
                End If
            End If
        Else
            Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data sudah ada!. Apakah anda ingin melihat data tersebut?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
            If result = DialogResult.Yes Then
                BtnFind_Click(sender, e)
            ElseIf result = DialogResult.No Then
                tlabnum.Focus()
            End If
        End If
        con.Close()
    End Sub

    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click
        Dim sql As String
        Try
            openDB()
            sql = "Select * From rm_inp WHERE (no_lab= '" & tlabnum.Text & "')"
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
                ttestdate.Text = tgluji.ToString("dd-MM-yyyy")
                tcountdate.Text = tglfn.ToString("dd-MM-yyyy")
                tanalyst.Text = dread.Item("analys")
                tmethod.Text = dread.Item("vg_mtd")
                openDB()
                sql = "Select * From receipt WHERE (labnum= '" & tlabnum.Text & "')"
                cmd = New SqlClient.SqlCommand(sql, con)
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                dread = cmd.ExecuteReader
                If dread.Read = True Then
                    Lreqnum.Text = _DataToValue("SELECT [id] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                    Lvariety.Text = _DataToValue("SELECT [variety] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                    Lfarmer.Text = _DataToValue("SELECT [farmer] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                    Lharvest.Text = _DataToValue("SELECT [harvest] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                    LLocation.Text = _DataToValue("SELECT [location] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                    Ljob.Text = _DataToValue("SELECT [nojob] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                End If
                btnSave.Enabled = False
                btnUpdate.Enabled = True
                btnDelete.Enabled = True
            Else
                Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data tidak ditemukan!. Apakah anda ingin melanjutkan pencarian data?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                If result = DialogResult.Yes Then
                    tlabnum.Focus()
                ElseIf result = DialogResult.No Then
                    btnSave.Enabled = True
                    btnUpdate.Enabled = False
                    btnDelete.Enabled = False
                    tlabnum.Focus()
                End If
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Error " + ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub tlabnum_GotFocus(sender As Object, e As EventArgs) Handles tlabnum.GotFocus
        'Me.AcceptButton = btncari1
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If tlabnum.Text = "" Or Lvariety.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "No. Lab harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
        ElseIf ttestdate.MaskCompleted = False Then
            Dim UseDate As DateTime = CDate(tcountdate.Text)
            If (UseDate < DateTime.Now) Then
                Me.MetroToolTip1.ToolTipTitle = "Invalid Date"
                Me.MetroToolTip1.Show("The date in this field must be greate than today's date.", Me.ttestdate, -5, -30, 5000)
            End If
        ElseIf ttestdate.MaskCompleted = False Then
            Dim UseDate As DateTime = CDate(tcountdate.Text)
            If (UseDate < DateTime.Now) Then
                Me.MetroToolTip1.ToolTipTitle = "Invalid Date"
                Me.MetroToolTip1.Show("The date in this field must be greate than today's date.", Me.tcountdate, -5, -30, 5000)
            End If
        Else
            _RunSQL("INSERT INTO rm_inp(no_lab, te1, te2, te3, te4, tearg, teprc, Dt_t, Cont_date, analys, tgl_input, vg_mtd) " &
                    "VALUES('" & tlabnum.Text & "','" & Val(tVg1.Text) & "','" & Val(tVg2.Text) & "','" & Val(tVg3.Text) & "','" & Val(tVg4.Text) & "','" & Val(tVgArg.Text) & "','" & Val(tVgPrc.Text) & "','" & CDate(ttestdate.Text) & "','" & CDate(tcountdate.Text) & "','" & tanalyst.Text & "','" & Now & "','" & tmethod.Text & "')")
            tlabnum.Focus()
            bersihkan()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If tlabnum.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "No. Lab harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
        ElseIf tcountdate.MaskCompleted = False Then
            Dim UseDate As DateTime = CDate(tcountdate.Text)
            If (UseDate < CDate(ttestdate.Text)) Then
                Me.MetroToolTip1.ToolTipTitle = "Invalid Date"
                Me.MetroToolTip1.Show("The date in this field must be greate than Test Date.", Me.tcountdate, -5, -30, 5000)
            End If
        Else
            Dim hrini As Date = Today
            _RunSQL("UPDATE rm_inp SET te1='" & Val(tVg1.Text) & "', te2='" & Val(tVg2.Text) & "', te3='" & Val(tVg3.Text) & "', te4='" & Val(tVg4.Text) & "', tearg='" & Val(tVgArg.Text) & "', teprc='" & Val(tVgPrc.Text) & "', Dt_t='" & CDate(ttestdate.Text) & "', Cont_date='" & CDate(tcountdate.Text) & "', analys='" & tanalyst.Text & "', tgl_input='" & Now & "', vg_mtd='" & tmethod.Text & "' WHERE (no_lab = '" & tlabnum.Text & "')")
            tlabnum.Focus()
            bersihkan()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If tlabnum.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Sample Identity kosong, mohon di lengkapi.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tlabnum.Focus()
        Else
            Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk menghapus data ini " + tlabnum.Text, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
            If result = DialogResult.Yes Then
                _RunSQL("DELETE FROM rm_inp WHERE (no_lab = '" & tlabnum.Text & "')")
                Me.tlabnum.Focus()
                bersihkan()
            ElseIf result = DialogResult.No Then
                btnSave.Enabled = True
                btnUpdate.Enabled = False
                btnDelete.Enabled = False
                Me.tlabnum.Focus()
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
    ' validasi menapilkan tooltips jika inputan tidak sesuai format
    Private Sub ttestdate_TypeValidationCompleted(sender As Object, e As TypeValidationEventArgs) Handles ttestdate.TypeValidationCompleted
        If (Not e.IsValidInput) Then
            Me.MetroToolTip1.ToolTipTitle = "invalid Date"
            Me.MetroToolTip1.Show("The data you supplied must be a valid date in the format dd-mm-yyyy.", Me.ttestdate, -5, -30, 5000)
            e.Cancel = True
        End If
    End Sub
    ' validasi menapilkan tooltips jika inputan tidak sesuai format
    Private Sub tcountdate_TypeValidationCompleted(sender As Object, e As TypeValidationEventArgs) Handles tcountdate.TypeValidationCompleted
        If (Not e.IsValidInput) Then
            Me.MetroToolTip1.ToolTipTitle = "invalid Date"
            Me.MetroToolTip1.Show("The data you supplied must be a valid date in the format dd-mm-yyyy.", Me.tcountdate, -5, -30, 5000)
        End If
    End Sub
End Class