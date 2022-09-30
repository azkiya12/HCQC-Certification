Imports System.Globalization

Public Class PurityTest
    Private Sub tlabnum_KeyDown(sender As Object, e As KeyEventArgs) Handles tlabnum.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrEmpty(tlabnum.Text) Then
                MetroMessageBox.Show(Me, "Lab Number harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                Return
            Else
                If _isBOFAND("purity", "labnum", tlabnum.Text) = False Then
                    openDB()
                    Dim sql As String
                    sql = "Select * From receipt WHERE (labnum= '" & tlabnum.Text & "')"
                    cmd = New SqlClient.SqlCommand(sql, con) With {
                        .CommandType = CommandType.Text,
                        .CommandText = sql
                    }
                    dread = cmd.ExecuteReader
                    If dread.Read = True Then
                        Lreqnum.Text = _DataToValue("SELECT [id] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                        tvariety.Text = _DataToValue("SELECT [variety] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                        tlotref.Text = _DataToValue("SELECT [nojob] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                        tnoman.Text = _DataToValue("SELECT [nomnl] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                        tscope.Text = _DataToValue("SELECT [scope] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                        tanalyst.Text = _DataToValue("SELECT [purity_namelog] FROM [report_status_pengujian] WHERE [labnum] = '" & tlabnum.Text & "'")
                        Dim tgluji As Date = _DataToValue("SELECT [purity_log] FROM [report_status_pengujian] WHERE [labnum]='" & tlabnum.Text & "'")
                        ttgldate.Text = tgluji.ToString(LabelDate1.Text)
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, "Data Lab Number tidak ditemukan!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                        tlabnum.Focus()
                    End If
                Else
                    Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data Purity sudah pernah di input!. Apakah anda ingin melihat data tersebut?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                    If result = DialogResult.Yes Then
                        BtnFind_Click(sender, e)
                    ElseIf result = DialogResult.No Then
                        BtnSave.Enabled = True
                        BtnUpdate.Enabled = False
                        BtnDel.Enabled = False
                    End If
                End If

            End If
        End If

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If String.IsNullOrEmpty(tlabnum.Text) Then
            MetroMessageBox.Show(Me, "Lab Number harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        ElseIf String.IsNullOrEmpty(tvariety.Text) Or tvariety.Text = "..." Then
            MetroMessageBox.Show(Me, "Pastikan identitas sample sudah benar!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        ElseIf tpurpass.Checked = False And tpurnotpass.Checked = False Then
            MetroMessageBox.Show(Me, "Attention Result Purity", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        ElseIf String.IsNullOrEmpty(twork.Text) Then
            MetroMessageBox.Show(Me, "Working Sample (g) tidak boleh kosong", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            twork.WithError = True
            Return
        ElseIf Lreqnum.Text <> _DataToValue("SELECT [id] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ") Then
            MetroMessageBox.Show(Me, "Pastikan No Lab " + tlabnum.Text + "sesuai dengan Identitas Sample", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, 211)
            Return
        Else
            If _isBOFAND("purity", "labnum", tlabnum.Text) = False Or _isBOFAND("purity", "id_request", Lreqnum.Text) Then
                If tvariety.Text = "" Then
                    MetroMessageBox.Show(Me, "No. Lab harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                    tvariety.Focus()
                Else
                    Dim tgltest As Date
                    Dim rsl As Boolean = False
                    If tpurpass.Checked = True Then
                        rsl = True
                    ElseIf tpurnotpass.Checked = True Then
                        rsl = False
                    End If

                    tgltest = Date.ParseExact(ttgldate.Text, formatDate, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None)
                    _RunSQL(" INSERT INTO [purity]  ([id_request]
                                            ,[id_login]
                                            ,[labnum]
                                            ,[idbalance]
                                            ,[psdnum]
                                            ,[ws]
                                            ,[pure]
                                            ,[other]
                                            ,[inert]
                                            ,[kindseed]
                                            ,[kindmetter]
                                            ,[1000seed]
                                            ,[testdate]
                                            ,[analyst]
                                            ,[remark]
                                            ,[result]
                                            ,[input_by]
                                            ,[input_at])                                                
                            VALUES (" & Lreqnum.Text & ",'" & login.Luserid.Text & "','" & tlabnum.Text & "', '" & tidbalance.Text & "', '" & tpsdnum.Text & "', " & Val(twork.Text) & ", " & Val(tpure.Text) & ",
                                    " & Val(tother.Text) & ", " & Val(tinert.Text) & ", '" & tkindother.Text & "', '" & tkindinert.Text & "', " & Val(t1thseed.Text) & ", '" & tgltest.ToString("yyyy-MM-dd") & "',
                                    '" & tanalyst.Text & "', '" & tremark.Text & "', '" & rsl & "', '" & GetIPAddress() & "', GETDATE())  ")
                    tlabnum.Focus()
                    Bersih2()
                End If
            Else
                MetroMessageBox.Show(Me, "Data sudah pernah di input", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            End If
        End If
    End Sub

    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click
        If String.IsNullOrEmpty(tlabnum.Text) Then
            MetroMessageBox.Show(Me, "Lab Number harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        Else
            Try
                openDB()
                Dim sql As String = "SELECT * FROM purity WHERE (labnum= '" & tlabnum.Text & "') AND delete_at IS NUll"

                cmd = New SqlClient.SqlCommand(sql, con) With {
                    .CommandType = CommandType.Text,
                    .CommandText = sql
                }
                dread = cmd.ExecuteReader
                If dread.Read = True Then
                    tidbalance.Text = dread.Item("idbalance")
                    tpsdnum.Text = dread.Item("psdnum")
                    twork.Text = dread.Item("ws")
                    tpure.Text = dread.Item("pure")
                    tother.Text = dread.Item("other")
                    tinert.Text = dread.Item("inert")
                    tkindother.Text = dread.Item("kindseed")
                    tkindinert.Text = dread.Item("kindmetter")
                    t1thseed.Text = dread.Item("1000seed")
                    tanalyst.Text = dread.Item("analyst")
                    Dim tgldate As Date = dread.Item("testdate")
                    ttgldate.Text = tgldate.ToString(LabelDate1.Text)
                    tremark.Text = dread.Item("remark")

                    If Not IsDBNull(dread.Item("result")) Then
                        If dread.Item("result") = True Then
                            tpurpass.Checked = True
                        Else
                            tpurnotpass.Checked = True
                        End If
                    Else
                        tpurpass.Checked = False
                        tpurnotpass.Checked = False
                    End If

                    con.Close()
                    openDB()
                    sql = "Select labnum From receipt WHERE (labnum = '" & tlabnum.Text & "')"
                    cmd = New SqlClient.SqlCommand(sql, con) With {
                        .CommandType = CommandType.Text,
                        .CommandText = sql
                    }
                    dread = cmd.ExecuteReader
                    If dread.Read = True Then
                        Lreqnum.Text = _DataToValue("SELECT [id] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                        tvariety.Text = _DataToValue("SELECT [variety] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                        tlotref.Text = _DataToValue("SELECT [nojob] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                        tnoman.Text = _DataToValue("SELECT [nomnl] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                        tscope.Text = _DataToValue("SELECT [scope] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                    End If
                    BtnSave.Enabled = False
                    BtnUpdate.Enabled = True
                    BtnDel.Enabled = True
                Else
                    Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data tidak ditemukan!. Click 'Yes' untuk melanjutkan pencarian. Click 'No' untuk Input Data Baru", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                    If result = DialogResult.Yes Then
                        Me.tlabnum.Focus()
                    ElseIf result = DialogResult.No Then
                        BtnSave.Enabled = True
                        BtnUpdate.Enabled = False
                        BtnDel.Enabled = False
                        Me.tlabnum.Focus()
                    End If
                End If
            Catch ex As Exception
                MetroMessageBox.Show(Me, ex.Message, Me.Text)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If String.IsNullOrEmpty(tlabnum.Text) Then
            MetroMessageBox.Show(Me, "Lab Number harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        ElseIf String.IsNullOrEmpty(tvariety.Text) Or tvariety.Text = "..." Then
            MetroMessageBox.Show(Me, "Pastikan identitas sample sudah benar!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        Else
            Dim rsl As Boolean = False
            If tpurpass.Checked = True Then
                rsl = True
            ElseIf tpurnotpass.Checked = True Then
                rsl = False
            End If
            Dim tgltest As Date
            tgltest = Date.ParseExact(ttgldate.Text, formatDate, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None)
            _RunSQL(" UPDATE [purity] SET  [idbalance]='" & tidbalance.Text & "'
                                      ,[psdnum]='" & tpsdnum.Text & "'
                                      ,[ws]=" & Val(twork.Text) & "
                                      ,[pure]=" & Val(tpure.Text) & "
                                      ,[other]=" & Val(tother.Text) & "
                                      ,[inert]=" & Val(tinert.Text) & "
                                      ,[kindseed]='" & tkindother.Text & "'
                                      ,[kindmetter]='" & tkindinert.Text & "'
                                      ,[1000seed]=" & Val(t1thseed.Text) & "
                                      ,[testdate]='" & tgltest.ToString("yyyy-MM-dd") & "'
                                      ,[analyst]='" & tanalyst.Text & "'
                                      ,[remark]='" & tremark.Text & "'
                                      ,[result]='" & rsl & "'
                                      ,[update_by]='" & login.Luserid.Text & "'
                                      ,[update_at]= GETDATE()
                                  WHERE ([labnum]='" & tlabnum.Text & "')  AND delete_at IS NUll")

            If strupdate = 1 Then
                Bersih2()
                BtnSave.Enabled = True
                BtnUpdate.Enabled = False
                BtnDel.Enabled = False
            End If
        End If

    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        If String.IsNullOrEmpty(tlabnum.Text) Then
            MetroMessageBox.Show(Me, "Lab Number harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        ElseIf String.IsNullOrEmpty(tvariety.Text) Or tvariety.Text = "..." Then
            MetroMessageBox.Show(Me, "Pastikan identitas sample sudah benar!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        Else
            If _isBOF("purity", "labnum", tlabnum.Text) = True Then
                Dim result As Integer = MetroMessageBox.Show(Me, "Apakah anda yakin untuk menghapus data ini " + tlabnum.Text, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
                If result = DialogResult.Yes Then
                    _RunSQL("DELETE [purity] WHERE ([labnum]= '" & tlabnum.Text & "') AND id_request='" & Lreqnum.Text & "'")
                    Me.tlabnum.Focus()
                    tscope.Text = "..."
                    tvariety.Text = "..."
                    tnoman.Text = "..."
                    tlotref.Text = "..."
                    Lreqnum.Text = "..."
                    Bersih2()
                    BtnSave.Enabled = True
                    BtnUpdate.Enabled = False
                    BtnDel.Enabled = False
                ElseIf result = DialogResult.No Then
                    BtnSave.Enabled = True
                    BtnUpdate.Enabled = False
                    BtnDel.Enabled = False
                    Me.tlabnum.Focus()
                End If
            Else
                MetroMessageBox.Show(Me, "Data Nomor Lab tersebut tidak ditemukan")
            End If
        End If
    End Sub

    Private Sub tidbalance_GotFocus(sender As Object, e As EventArgs) Handles tidbalance.GotFocus
        tidbalance.SelectAll()
    End Sub

    Private Sub tpsdnum_GotFocus(sender As Object, e As EventArgs) Handles tpsdnum.GotFocus
        tpsdnum.SelectAll()
    End Sub

    Private Sub twork_GotFocus(sender As Object, e As EventArgs) Handles twork.GotFocus
        twork.SelectAll()
        twork.WithError = False
    End Sub

    Private Sub tpure_GotFocus(sender As Object, e As EventArgs) Handles tpure.GotFocus
        tpure.SelectAll()
    End Sub

    Private Sub tother_GotFocus(sender As Object, e As EventArgs) Handles tother.GotFocus
        tother.SelectAll()
    End Sub

    Private Sub tinert_GotFocus(sender As Object, e As EventArgs) Handles tinert.GotFocus
        tinert.SelectAll()
    End Sub

    Private Sub tkindother_GotFocus(sender As Object, e As EventArgs) Handles tkindother.GotFocus
        tkindother.SelectAll()
    End Sub

    Private Sub tkindinert_GotFocus(sender As Object, e As EventArgs) Handles tkindinert.GotFocus
        tkindinert.SelectAll()
    End Sub

    Private Sub tanalyst_GotFocus(sender As Object, e As EventArgs) Handles tanalyst.GotFocus
        tanalyst.SelectAll()
    End Sub

    Private Sub tremark_GotFocus(sender As Object, e As EventArgs) Handles tremark.GotFocus
        tremark.SelectAll()
    End Sub

    Private Sub ttgldate_GotFocus(sender As Object, e As EventArgs) Handles ttgldate.GotFocus
        ttgldate.SelectAll()
    End Sub

    Private Sub LToleransi_TextChanged(sender As Object, e As EventArgs) Handles tpure.TextChanged, tother.TextChanged, tinert.TextChanged
        Dim bc As Decimal
        bc = Val(Trim(tpure.Text)) + Val(Trim(tother.Text)) + Val(Trim(tinert.Text))

        Try
            Linert.Text = FormatPercent(Convert.ToDecimal(tinert.Text) / Convert.ToDecimal(bc))
        Catch ex As Exception
            Linert.Text = ""
            'MetroMessageBox.Show(Me, "Ada yang salah pada Inert Metter atau Working Sample. Coba di cek ya?", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
        End Try

        Try
            Lother.Text = FormatPercent(Convert.ToDecimal(tother.Text) / Convert.ToDecimal(bc))
        Catch ex As Exception
            Lother.Text = ""
            'MetroMessageBox.Show(Me, "Ada yang salah pada Other Seed atau Working Sample. Coba di cek ya?", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
        End Try

        Try
            LPure.Text = FormatPercent(Convert.ToDecimal(tpure.Text) / Convert.ToDecimal(bc))
        Catch ex As Exception
            LPure.Text = ""
            'MetroMessageBox.Show(Me, "Ada yang salah pada Pure Seed atau Working Sample. Coba di cek ya?", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
        End Try

        bc = Val(Trim(tpure.Text)) + Val(Trim(tother.Text)) + Val(Trim(tinert.Text))
        LToleransi.Text = Math.Round((Val(twork.Text) - (bc)) / Val(twork.Text) * 100, 2) & "% <= 5%"

    End Sub

    Private Sub BtnDel_GotFocus(sender As Object, e As EventArgs) Handles BtnDel.GotFocus
        If BtnDel.Enabled = True Then
            BtnDel.BorderRadius = 5
            BtnDel.Normalcolor = Color.FromArgb(0, 153, 255)
        End If
    End Sub

    Private Sub BtnSave_GotFocus(sender As Object, e As EventArgs) Handles BtnSave.GotFocus
        If BtnSave.Enabled = True Then
            BtnSave.BorderRadius = 5
            BtnSave.Normalcolor = Color.FromArgb(0, 153, 255)
        End If
    End Sub

    Private Sub BtnUpdate_GotFocus(sender As Object, e As EventArgs) Handles BtnUpdate.GotFocus
        If BtnUpdate.Enabled = True Then
            BtnUpdate.BorderRadius = 5
            BtnUpdate.Normalcolor = Color.FromArgb(0, 153, 255)
        End If
    End Sub

    Private Sub BtnDel_LostFocus(sender As Object, e As EventArgs) Handles BtnDel.LostFocus
        If BtnDel.Enabled = True Then
            BtnDel.BorderRadius = 0
            BtnDel.Normalcolor = Color.FromArgb(0, 122, 204)
        End If
    End Sub

    Private Sub BtnSave_LostFocus(sender As Object, e As EventArgs) Handles BtnSave.LostFocus
        If BtnSave.Enabled = True Then
            BtnSave.BorderRadius = 0
            BtnSave.Normalcolor = Color.FromArgb(0, 122, 204)
        End If
    End Sub

    Private Sub BtnUpdate_LostFocus(sender As Object, e As EventArgs) Handles BtnUpdate.LostFocus
        If BtnUpdate.Enabled = True Then
            BtnUpdate.BorderRadius = 0
            BtnUpdate.Normalcolor = Color.FromArgb(0, 122, 204)
        End If
    End Sub

    Sub Bersih2()
        tlabnum.Text = ""
        tidbalance.Text = "HCQC"
        tpsdnum.Text = ""
        tpure.Text = ""
        tother.Text = ""
        tinert.Text = ""
        tkindother.Text = ""
        tkindinert.Text = ""
        t1thseed.Text = ""
        tremark.Text = ""
        'tanalyst.Text = ""
        'ttgldate.Text = Today.ToString(LabelDate1.Text)
    End Sub

End Class