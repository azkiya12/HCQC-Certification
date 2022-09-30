Imports System.Globalization
Imports DevExpress.XtraEditors

Public Class Internal_Rafraction_Test

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If String.IsNullOrEmpty(tlabnum.Text) Then
            MetroMessageBox.Show(Me, "Lab Number harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        ElseIf String.IsNullOrEmpty(tvariety.Text) Or tvariety.Text = "..." Then
            MetroMessageBox.Show(Me, "Pastikan identitas sample sudah benar!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        ElseIf Trim(twork.Text).Length > 0 AndAlso val(twork.Text) < 0 Then
            MetroMessageBox.Show(Me, "Pastikan Work Sample sudah benar!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            twork.WithError = True
            Return
        ElseIf Lreqnum.Text <> _DataToValue("SELECT [id] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ") Then
            MetroMessageBox.Show(Me, "Pastikan No Lab " + tlabnum.Text + "sesuai dengan Identitas Sample", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, 211)
            Return
        Else
            If _isBOFAND("rafaction", "labnum", tlabnum.Text) = False Then

                If tvariety.Text = "" Then
                    MetroMessageBox.Show(Me, "Data harus lengkap", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                    tvariety.Focus()
                Else
                    Dim rsl As Boolean = False
                    If tirpass.Checked = True Then
                        rsl = True
                    ElseIf tirnotpass.Checked = True Then
                        rsl = False
                    End If
                    Dim tgltest As Date
                    tgltest = Date.ParseExact(dtgl_uji.Text, formatDate, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None)
                    _RunSQL(" INSERT INTO [rafaction] ([id_request]
                                            ,[id_login]
                                            ,[labnum]
                                            ,[idbalance]
                                            ,[ws]
                                            ,[ps]
                                            ,[yg]
                                            ,[us]
                                            ,[rt]
                                            ,[Ind]
                                            ,[br]
                                            ,[od]
                                            ,[gr]
                                            ,[fg]
                                            ,[im]
                                            ,[cr]
                                            ,[cvl]
                                            ,[resul]
                                            ,[dt_t]
                                            ,[analys]
                                            ,[ket]
                                            ,[arsipcek]
                                            ,[input_by]
                                            ,[input_at]) 
                            VALUES ('" & Lreqnum.Text & "','" & login.Luserid.Text & "','" & tlabnum.Text & "', '" & tidbalance.Text & "'," & Val(twork.Text) & ", " & Val(tpale.Text) & ", " & Val(tyoung.Text) & ", " & Val(tunder.Text) & ", " & Val(trotten.Text) & ", " & Val(tinsect.Text) & ",
                                    " & Val(tbroken.Text) & ", " & Val(tother.Text) & ", " & Val(tgrowth.Text) & ", " & Val(tfungi.Text) & ", " & Val(tinert.Text) & ", " & Val(tcrack.Text) & "," & Val(tcvl.Text) & ",
                                    '" & rsl & "', '" & tgltest.ToString("yyyy-MM-dd") & "', '" & tanalyst.Text & "','" & tremark.Text & "', " & cekArsip.CheckState & ", '" & GetIPAddress() & "', GETDATE())  ")
                    Bersih2()
                    tlabnum.Focus()

                End If

            Else
                MetroMessageBox.Show(Me, "Data " & tlabnum.Text & " sudah pernah di Save", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
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
                Dim sql As String = "SELECT * FROM rafaction WHERE (labnum= '" & tlabnum.Text & "') AND delete_at IS NUll"

                cmd = New SqlClient.SqlCommand(sql, con) With {
                    .CommandType = CommandType.Text,
                    .CommandText = sql
                }
                dread = cmd.ExecuteReader
                If dread.Read = True Then
                    tidbalance.Text = dread.Item("idbalance")
                    twork.Text = dread.Item("ws")
                    tpale.Text = dread.Item("ps")
                    tyoung.Text = dread.Item("yg")
                    tunder.Text = dread.Item("us")
                    trotten.Text = dread.Item("rt")
                    tinsect.Text = dread.Item("Ind")
                    tbroken.Text = dread.Item("br")
                    tother.Text = dread.Item("od")
                    tgrowth.Text = dread.Item("gr")
                    tfungi.Text = dread.Item("fg")
                    tinert.Text = dread.Item("im")
                    tcrack.Text = dread.Item("cr")
                    tcvl.Text = dread.Item("cvl")
                    If dread.Item("resul") = True Then
                        tirpass.Checked = True
                    Else
                        tirnotpass.Checked = True
                    End If
                    Dim tgldate As Date = dread.Item("dt_t")
                    dtgl_uji.Text = tgldate.ToString(LabelDateFormat.Text)
                    tanalyst.Text = dread.Item("analys")
                    tremark.Text = dread.Item("ket")

                    If IsDBNull(dread.Item("arsipcek")) = False Then
                        If dread.Item("arsipcek") = True Then
                            cekArsip.Checked = True
                        Else
                            cekArsip.Checked = False
                        End If
                    Else
                        cekArsip.Enabled = False
                    End If


                    con.Close()
                    openDB()
                    sql = "Select labnum FROM receipt WHERE (labnum = '" & tlabnum.Text & "') AND delete_at IS NULL"
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
                    Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data tidak ditemukan!. Click 'Yes' untuk menampilkan data. Click 'No' untuk reset form", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                    If result = DialogResult.Yes Then
                        Me.tlabnum.SelectAll()
                    ElseIf result = DialogResult.No Then
                        BtnSave.Enabled = True
                        BtnUpdate.Enabled = False
                        BtnDel.Enabled = False
                        Me.tlabnum.SelectAll()
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
            ''radio button
            Dim rsl As Boolean = False
            If tirpass.Checked = True Then
                rsl = True
            ElseIf tirnotpass.Checked = True Then
                rsl = False
            End If
            ''convert format date
            Dim tgltest As Date
            tgltest = Date.ParseExact(dtgl_uji.Text, formatDate, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None)

            _RunSQL(" UPDATE [rafaction] SET  [idbalance]='" & tidbalance.Text & "'
                                          ,[ws]=" & Val(twork.Text) & "
                                          ,[ps]=" & Val(tpale.Text) & "
                                          ,[yg]=" & Val(tyoung.Text) & "
                                          ,[us]=" & Val(tunder.Text) & "
                                          ,[rt]=" & Val(trotten.Text) & "
                                          ,[Ind]=" & Val(tinsect.Text) & "
                                          ,[br]=" & Val(tbroken.Text) & "
                                          ,[od]=" & Val(tother.Text) & "
                                          ,[gr]=" & Val(tgrowth.Text) & "
                                          ,[fg]=" & Val(tfungi.Text) & "
                                          ,[im]=" & Val(tinert.Text) & "
                                          ,[cr]=" & Val(tcrack.Text) & "
                                          ,[cvl]=" & Val(tcvl.Text) & "
                                          ,[resul]='" & rsl & "'
                                          ,[dt_t]='" & tgltest.ToString("yyyy-MM-dd") & "'
                                          ,[analys]='" & tanalyst.Text & "'
                                          ,[ket]='" & tremark.Text & "'
                                          ," & IIf(_DataToValue("select count(id) from [rafaction] where arsipcek is not null and labnum = '" & tlabnum.Text & "'") > 0, "[arsipcek] = '" & (cekArsip.CheckState) & "'", "[arsipcek]=null") & "
                                          ,[update_by]='" & login.Luserid.Text & "'
                                          ,[update_at]= GETDATE()
                                    WHERE [labnum]='" & tlabnum.Text & "'
                 ")
            Bersih2()
            BtnSave.Enabled = True
            BtnUpdate.Enabled = False
            BtnDel.Enabled = False
            tlabnum.Focus()

        End If

    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        If String.IsNullOrEmpty(tlabnum.Text) Then
            MetroMessageBox.Show(Me, "Lab Number harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        Else
            Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk menghapus data ini " + tlabnum.Text, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
            If result = DialogResult.Yes Then
                _RunSQL("DELETE [rafaction] WHERE ([labnum]= '" & tlabnum.Text & "')")
                Bersih2()
                Me.tlabnum.Focus()
            ElseIf result = DialogResult.No Then
                BtnSave.Enabled = True
                BtnUpdate.Enabled = False
                BtnDel.Enabled = False
                Me.tlabnum.SelectAll()
            End If
        End If
    End Sub

    Private Sub tlabnum_KeyDown(sender As Object, e As KeyEventArgs) Handles tlabnum.KeyDown
        If e.KeyCode = Keys.Enter Then
            openDB()
            Dim sql As String = "Select labnum From rafaction WHERE (labnum= '" & tlabnum.Text & "') AND delete_at IS NUll"
            cmd = New SqlClient.SqlCommand(sql, con) With {
                .CommandType = CommandType.Text,
                .CommandText = sql
            }
            dread = cmd.ExecuteReader
            If dread.Read = False Then
                openDB()
                sql = "Select labnum From receipt WHERE (labnum= '" & tlabnum.Text & "')"
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
                    tanalyst.Text = _DataToValue("SELECT [rafaction_namelog] FROM [report_status_pengujian] WHERE [labnum] = '" & tlabnum.Text & "'")
                    Dim tgluji As Date = _DataToValue("SELECT [rafaction_log] FROM [report_status_pengujian] WHERE [labnum]='" & tlabnum.Text & "'")
                    dtgl_uji.Text = tgluji.ToString(LabelDateFormat.Text)
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Data tidak ditemukan!. Apakah anda ingin melanjutkan pencarian data?", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, 211)
                    'tlabnum.Focus()
                    tlabnum.SelectAll()
                End If
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Data Rafaksi sudah pernah di input!.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, 211)
                'tlabnum.Focus()
                tlabnum.SelectAll()
            End If
            con.Close()
        End If
    End Sub

    Private Sub ttotal_TextChanged(sender As Object, e As EventArgs) Handles tpale.TextChanged, tyoung.TextChanged, tunder.TextChanged, trotten.TextChanged, tinsect.TextChanged, tbroken.TextChanged, tother.TextChanged, tgrowth.TextChanged, tfungi.TextChanged, tinert.TextChanged, tcrack.TextChanged, tcvl.TextChanged
        Dim totalrafaksi As Decimal
        totalrafaksi = Val(tpale.Text) + Val(tyoung.Text) + Val(tunder.Text) + Val(trotten.Text) +
                       Val(tinsect.Text) + Val(tbroken.Text) + Val(tother.Text) + Val(tgrowth.Text) +
                       Val(tfungi.Text) + Val(tinert.Text) + Val(tcrack.Text) + Val(tcvl.Text)
        Ltotal.Text = FormatPercent(totalrafaksi / Val(twork.Text))
    End Sub

    Private Sub Lpale_TextChanged(sender As Object, e As EventArgs) Handles tpale.TextChanged
        Try
            Lpale.Text = FormatPercent(Convert.ToDecimal(tpale.Text) / Convert.ToDecimal(twork.Text))
        Catch ex As Exception
            Lpale.Text = ""
        End Try
    End Sub

    Private Sub Lyoung_TextChanged(sender As Object, e As EventArgs) Handles tyoung.TextChanged
        Try
            Lyoung.Text = FormatPercent(Convert.ToDecimal(tyoung.Text) / Convert.ToDecimal(twork.Text))
        Catch ex As Exception
            Lyoung.Text = ""
        End Try
    End Sub

    Private Sub Lunder_TextChanged(sender As Object, e As EventArgs) Handles tunder.TextChanged
        Try
            Lunder.Text = FormatPercent(Convert.ToDecimal(tunder.Text) / Convert.ToDecimal(twork.Text))
        Catch ex As Exception
            Lunder.Text = ""
        End Try
    End Sub

    Private Sub Lrotten_TextChanged(sender As Object, e As EventArgs) Handles trotten.TextChanged
        Try
            Lrotten.Text = FormatPercent(Convert.ToDecimal(trotten.Text) / Convert.ToDecimal(twork.Text))
        Catch ex As Exception
            Lrotten.Text = ""
        End Try
    End Sub

    Private Sub Linsect_TextChanged(sender As Object, e As EventArgs) Handles tinsect.TextChanged
        Try
            Linsect.Text = FormatPercent(Convert.ToDecimal(tinsect.Text) / Convert.ToDecimal(twork.Text))
        Catch ex As Exception
            Linsect.Text = ""
        End Try
    End Sub

    Private Sub Lbroken_TextChanged(sender As Object, e As EventArgs) Handles tbroken.TextChanged
        Try
            Lbroken.Text = FormatPercent(Convert.ToDecimal(tbroken.Text) / Convert.ToDecimal(twork.Text))
        Catch ex As Exception
            Lbroken.Text = ""
        End Try
    End Sub

    Private Sub Lother_TextChanged(sender As Object, e As EventArgs) Handles tother.TextChanged
        Try
            Lother.Text = FormatPercent(Convert.ToDecimal(tother.Text) / Convert.ToDecimal(twork.Text))
        Catch ex As Exception
            Lother.Text = ""
        End Try
    End Sub

    Private Sub Lgrowth_TextChanged(sender As Object, e As EventArgs) Handles tgrowth.TextChanged
        Try
            Lgrowth.Text = FormatPercent(Convert.ToDecimal(tgrowth.Text) / Convert.ToDecimal(twork.Text))
        Catch ex As Exception
            Lgrowth.Text = ""
        End Try
    End Sub

    Private Sub Lfungi_TextChanged(sender As Object, e As EventArgs) Handles tfungi.TextChanged
        Try
            Lfungi.Text = FormatPercent(Convert.ToDecimal(tfungi.Text) / Convert.ToDecimal(twork.Text))
        Catch ex As Exception
            Lfungi.Text = ""
        End Try
    End Sub

    Private Sub Linert_TextChanged(sender As Object, e As EventArgs) Handles tinert.TextChanged
        Try
            Linert.Text = FormatPercent(Convert.ToDecimal(tinert.Text) / Convert.ToDecimal(twork.Text))
        Catch ex As Exception
            Linert.Text = ""
        End Try
    End Sub

    Private Sub Lcrack_TextChanged(sender As Object, e As EventArgs) Handles tcrack.TextChanged
        Try
            Lcrack.Text = FormatPercent(Convert.ToDecimal(tcrack.Text) / Convert.ToDecimal(twork.Text))
        Catch ex As Exception
            Lcrack.Text = ""
        End Try
    End Sub

    Private Sub Lcvl_TextChanged(sender As Object, e As EventArgs) Handles tcvl.TextChanged
        Try
            Lcvl.Text = FormatPercent(Convert.ToDecimal(tcvl.Text) / Convert.ToDecimal(twork.Text))
        Catch ex As Exception
            Lcvl.Text = ""
        End Try
    End Sub

    Private Sub BtnSave_KeyDown(sender As Object, e As KeyEventArgs) Handles BtnSave.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Space Then
            BtnSave_Click(sender, e)
        End If
    End Sub

    Private Sub BtnSave_GotFocus(sender As Object, e As EventArgs) Handles BtnSave.GotFocus, BtnSave.MouseEnter
        BtnSave.BorderRadius = 5
        BtnSave.Normalcolor = Color.FromArgb(0, 153, 255)
    End Sub

    Private Sub BtnSave_LostFocus(sender As Object, e As EventArgs) Handles BtnSave.LostFocus, BtnSave.MouseLeave
        BtnSave.BorderRadius = 0
        BtnSave.Normalcolor = Color.FromArgb(0, 122, 204)
    End Sub

    Private Sub Internal_Rafraction_Test_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtgl_uji.Text = Today.ToString(LabelDateFormat.Text)
    End Sub

    Sub Bersih2()
        tlabnum.Text = ""
        tidbalance.Text = "HCQC"
        twork.Text = ""
        tpale.Text = ""
        tyoung.Text = ""
        tunder.Text = ""
        trotten.Text = ""
        tinsect.Text = ""
        tbroken.Text = ""
        tother.Text = ""
        tgrowth.Text = ""
        tfungi.Text = ""
        tinert.Text = ""
        tcrack.Text = ""
        tcvl.Text = ""

        tirpass.Checked = True
        tirnotpass.Checked = False

        tremark.Text = ""
    End Sub

    Private Sub twork_GotFocus(sender As Object, e As EventArgs) Handles twork.GotFocus
        twork.WithError = False
    End Sub
End Class