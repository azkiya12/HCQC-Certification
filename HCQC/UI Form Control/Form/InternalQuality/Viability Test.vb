Imports System.Globalization

Public Class Viability_Test
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If tvariety.Text = "" Then
            MetroMessageBox.Show(Me, "Data harus lengkap", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, 211)
            tvariety.Focus()
            Return
        ElseIf _isBOF("receipt", "labnum", tlabnum.Text) = False Then
            MetroMessageBox.Show(Me, "Lab Number tidak ditemukan", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, 211)
            tlabnum.SelectAll()
            Return
        ElseIf Lreqnum.Text <> _DataToValue("SELECT [id] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ") Then
            MetroMessageBox.Show(Me, "Pastikan No Lab " + tlabnum.Text + "sesuai dengan Identitas Sample", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, 211)
            Return
        ElseIf _isBOFAND("viability", "labnum", tlabnum.Text) = False Then
            Dim idcategory As Integer
            idcategory = _DataToValue("SELECT id FROM category_via WHERE viability='" & tmethodvia.Text & "' and method='" & tmethodused.Text & "'")
            Dim tgltest As Date
            tgltest = Date.ParseExact(ttestdate.Text, formatDate, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None)

            _RunSQL(" INSERT INTO [dbo].[viability]
                                                   ([id_login]
                                                   ,[id_request]
                                                   ,[labnum]
                                                   ,[idcategory_via]
                                                   ,[subtrade]
                                                   ,[concentration]
                                                   ,[temp]
                                                   ,[time]
                                                   ,[equipment]
                                                   ,[character]
                                                   ,[rep1]
                                                   ,[rep2]
                                                   ,[rep3]
                                                   ,[rep4]
                                                   ,[mean]
                                                   ,[testdate]
                                                   ,[analyst]
                                                   ,[remark]
                                                   ,[input_by]
                                                   ,[input_at])
                                             VALUES
                                                   ('" & login.Luserid.Text & "'
                                                   ,'" & Lreqnum.Text & "'
                                                   ,'" & tlabnum.Text & "'
                                                   ," & idcategory & "
                                                   ," & IIf(tmethodvia.Text = "Tetrazolium", "'-'", "'" & tsubtrade.Text & "'") & "
                                                   ," & IIf(tmethodvia.Text = "Tetrazolium", Val(tconcentration.Text), "NULL") & "
                                                   ," & Val(ttemp.Text) & "
                                                   ," & Val(ttime.Text) & "
                                                   ,'" & tequip.Text & "'
                                                   ,'Viable'
                                                   ," & Val(tcount1.Text) & "
                                                   ," & Val(tcount2.Text) & "
                                                   ," & Val(tcount3.Text) & "
                                                   ," & Val(tcount4.Text) & "
                                                   ," & Val(tmean.Text) & "
                                                   ,'" & tgltest.ToString("yyyy-MM-dd") & "'
                                                   ,'" & tanalyst.Text & "'
                                                   ,'" & tremark.Text & "'
                                                   ,'" & login.Luserid.Text & "'
                                                   ,GETDATE())")
            bersih2()
            tlabnum.SelectAll()
        End If
    End Sub

    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click
        If String.IsNullOrEmpty(tlabnum.Text) Then
            MetroMessageBox.Show(Me, "Lab Number harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        Else
            Try
                openDB()
                Dim sql As String = "SELECT * FROM viability WHERE (labnum= '" & tlabnum.Text & "') AND delete_at IS NUll"

                cmd = New SqlClient.SqlCommand(sql, con) With {
                    .CommandType = CommandType.Text,
                    .CommandText = sql
                }

                dread = cmd.ExecuteReader
                If dread.Read = True Then
                    tlabnum.Text = dread.Item("labnum")
                    Dim Vid As String
                    Vid = dread.Item("idcategory_via")
                    tsubtrade.Text = dread.Item("subtrade")

                    ttemp.Text = dread.Item("temp")
                    ttime.Text = dread.Item("time")
                    tequip.Text = dread.Item("equipment")
                    tcount1.Text = dread.Item("rep1")
                    tcount2.Text = dread.Item("rep2")
                    tcount3.Text = dread.Item("rep3")
                    tcount4.Text = dread.Item("rep4")
                    tmean.Text = dread.Item("mean")
                    Dim tgldate As Date = dread.Item("testdate")
                    ttestdate.Text = tgldate.ToString(LabelFormatDate.Text)
                    tanalyst.Text = dread.Item("analyst")
                    tremark.Text = dread.Item("remark")
                    con.Close()
                    tconcentration.Text = _DataToValue("SELECT [concentration] FROM [viability] where labnum= '" & tlabnum.Text & "'")
                    tmethodvia.Text = _DataToValue("SELECT [viability] FROM [category_via] WHERE [id]='" & Vid & "'")
                    tmethodused.Text = _DataToValue("SELECT [method] FROM [category_via] WHERE [id]='" & Vid & "'")


                    Lreqnum.Text = _DataToValue("SELECT [id] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                    tvariety.Text = _DataToValue("SELECT [variety] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                    tlotref.Text = _DataToValue("SELECT [nojob] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                    tnoman.Text = _DataToValue("SELECT [nomnl] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                    tscope.Text = _DataToValue("SELECT [scope] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")

                    If tmethodvia.Text = "Tetrazolium" Then
                        tsubtrade.Text = ""
                        tsubtrade.PromptText = ""
                        tsubtrade.Enabled = False
                    Else
                        tconcentration.Text = "NULL"
                        tconcentration.Enabled = False
                    End If

                    BtnSave.Enabled = False
                    BtnUpdate.Enabled = True
                    BtnDelete.Enabled = True
                Else
                    Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data tidak ditemukan!. Click 'Yes' untuk input data baru.    Click 'No' untuk mengulangi pencarian", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                    If result = DialogResult.Yes Then
                        Me.tlabnum.SelectAll()
                        BtnSave.Enabled = True
                        BtnUpdate.Enabled = False
                        BtnDelete.Enabled = False
                    ElseIf result = DialogResult.No Then
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
            Dim idcategory As Integer
            idcategory = _DataToValue("SELECT id FROM category_via WHERE viability='" & tmethodvia.Text & "' and method='" & tmethodused.Text & "'")
            Dim tgltest As Date
            tgltest = Date.ParseExact(ttestdate.Text, formatDate, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None)
            _RunSQL(" UPDATE [dbo].[viability]
                        SET  [idcategory_via]=" & idcategory & "
                            ,[subtrade] = " & IIf(tmethodvia.Text = "Tetrazolium", "'-'", "'" & tsubtrade.Text & "'") & "
                            ,[concentration] = " & IIf(tmethodvia.Text = "Tetrazolium", Val(tconcentration.Text), "NULL") & "
                            ,[temp] = " & Val(ttemp.Text) & "
                            ,[time] = " & Val(ttime.Text) & "
                            ,[equipment] = '" & tequip.Text & "'
                            ,[rep1] = " & Val(tcount1.Text) & "
                            ,[rep2] = " & Val(tcount2.Text) & "
                            ,[rep3] = " & Val(tcount3.Text) & "
                            ,[rep4] = " & Val(tcount4.Text) & "
                            ,[mean] = " & Val(tmean.Text) & "
                            ,[testdate] = '" & tgltest.ToString("yyyy-MM-dd") & "'
                            ,[analyst] = '" & tanalyst.Text & "'
                            ,[remark] = '" & tremark.Text & "'
                            ,[update_by] = '" & login.Luserid.Text & "'
                            ,[update_at] = GETDATE()
                            
                        WHERE [labnum] = '" & tlabnum.Text & "' AND delete_at IS NUll
                 ")
        End If
        bersih2()
        tlabnum.SelectAll()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If String.IsNullOrEmpty(tlabnum.Text) Then
            MetroMessageBox.Show(Me, "Lab Number harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        Else
            If _isBOF("viability", "labnum", tlabnum.Text) = True Then
                Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk menghapus data ini " + tlabnum.Text, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
                If result = DialogResult.Yes Then
                    _RunSQL("DELETE [viability]  WHERE ([labnum]= '" & tlabnum.Text & "')")
                    Me.tlabnum.Focus()
                    'Bersihkan()
                ElseIf result = DialogResult.No Then
                    BtnSave.Enabled = True
                    BtnUpdate.Enabled = False
                    BtnDelete.Enabled = False
                    Me.tlabnum.Focus()
                End If
            Else
                MetroMessageBox.Show(Me, "Data dengan Nomor Lab " + tlabnum.Text + " tidak ada", "Notification Delete", MessageBoxButtons.OK, MessageBoxIcon.None, 211)
            End If
        End If
    End Sub

    Dim myTextBoxes As New List(Of MetroFramework.Controls.MetroTextBox)
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

    Private Sub tmean_TextChanged(sender As Object, e As EventArgs) Handles tcount1.TextChanged, tcount2.TextChanged, tcount3.TextChanged, tcount4.TextChanged
        tmean.Text = Calculate(myTextBoxes)
    End Sub

    Private Sub Viability_Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _ComboData("SELECT [viability] FROM [HCQC_server].[dbo].[category_via] Group by [viability]", Me.tmethodvia)

        'menambah/memasukan control pada array mytextboxes
        myTextBoxes.Add(tcount1)
        myTextBoxes.Add(tcount2)
        myTextBoxes.Add(tcount3)
        myTextBoxes.Add(tcount4)

        LabelFormatDate.Text = "dd-MM-yyyy"
    End Sub

    Private Sub tmethod_SelectedValueChanged(sender As Object, e As EventArgs) Handles tmethodvia.SelectedValueChanged
        _ComboData("SELECT [method] FROM [HCQC_server].[dbo].[category_via] WHERE [viability]='" & tmethodvia.Text & "'", Me.tmethodused)
        tmethodused.Enabled = True

        If tmethodvia.Text = "Tetrazolium" Then
            tconcentration.Text = ""
            tconcentration.Enabled = True
            tsubtrade.Text = "NULL"
            tsubtrade.PromptText = "NULL"
            tsubtrade.Enabled = False
        Else
            tconcentration.Text = "NULL"
            tconcentration.Enabled = False
            tsubtrade.Enabled = True
            tsubtrade.PromptText = ""
            tsubtrade.Text = ""
        End If
    End Sub

    Private Sub Ttime_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ttime.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                Ltime.Text = "Accept input number only"
            Else
                Ltime.Text = ""
            End If
        End If
    End Sub

    Private Sub tlabnum_KeyDown(sender As Object, e As KeyEventArgs) Handles tlabnum.KeyDown
        If e.KeyCode = Keys.Enter Then
            If _isBOFAND("viability", "labnum", tlabnum.Text) = False Then
                If _isBOFAND("receipt", "labnum", tlabnum.Text) = True Then
                    Lreqnum.Text = _DataToValue("SELECT [id] FROM [qc_confirm_viewer] WHERE (labnum= '" & tlabnum.Text & "') ")
                    tvariety.Text = _DataToValue("SELECT [variety] FROM [qc_confirm_viewer] WHERE (labnum= '" & tlabnum.Text & "') ")
                    tlotref.Text = _DataToValue("SELECT [nojob] FROM [qc_confirm_viewer] WHERE (labnum= '" & tlabnum.Text & "') ")
                    tnoman.Text = _DataToValue("SELECT [nomnl] FROM [qc_confirm_viewer] WHERE (labnum= '" & tlabnum.Text & "') ")
                    tscope.Text = _DataToValue("SELECT [scope] FROM [qc_confirm_viewer] WHERE (labnum= '" & tlabnum.Text & "') ")

                    Dim tgluji As Date
                    Dim sql As String
                    Try
                        openDB()
                        sql = "SELECT [viability_namelog],[viability_log]
                                FROM [report_status_pengujian] WHERE [labnum] = '" & tlabnum.Text & "'"
                        cmd = New SqlClient.SqlCommand(Sql, con) With {
                            .CommandType = CommandType.Text,
                            .CommandText = Sql
                        }
                        dread = cmd.ExecuteReader
                        If dread.Read = True Then
                            tgluji = dread.Item("viability_log")
                            ttestdate.Text = tgluji.ToString(LabelFormatDate.Text)

                            tanalyst.Text = dread.Item("viability_namelog")
                        End If
                    Catch ex As Exception
                        MetroMessageBox.Show(Me, "Warning: Mohon untuk melakukan check in/out sample untuk analis. Deskription: " + ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, 211)
                    Finally
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                    End Try

                    tlabnum.SelectAll()
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Data belum ada di penerimaan HCQC", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                    tlabnum.Focus()
                End If
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Data sudah pernah di input.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                tlabnum.Focus()
            End If
        End If
    End Sub

    Private Sub tcount1_GotFocus(sender As Object, e As EventArgs) Handles tcount1.GotFocus
        tcount1.SelectAll()
    End Sub

    Private Sub tcount2_GotFocus(sender As Object, e As EventArgs) Handles tcount2.GotFocus
        tcount2.SelectAll()
    End Sub

    Private Sub tcount3_GotFocus(sender As Object, e As EventArgs) Handles tcount3.GotFocus
        tcount3.SelectAll()
    End Sub

    Private Sub tcount4_GotFocus(sender As Object, e As EventArgs) Handles tcount4.GotFocus
        tcount4.SelectAll()
    End Sub

    Private Sub tmean_GotFocus(sender As Object, e As EventArgs) Handles tmean.GotFocus
        tmean.SelectAll()
    End Sub
    Private Sub BtnSave_GotFocus(sender As Object, e As EventArgs) Handles BtnSave.GotFocus, BtnSave.MouseEnter
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

    Private Sub BtnDelete_GotFocus(sender As Object, e As EventArgs) Handles BtnDelete.GotFocus
        If BtnDelete.Enabled = True Then
            BtnDelete.BorderRadius = 5
            BtnDelete.Normalcolor = Color.FromArgb(0, 153, 255)
        End If
    End Sub

    Private Sub BtnSave_LostFocus(sender As Object, e As EventArgs) Handles BtnSave.LostFocus, BtnSave.MouseLeave
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

    Private Sub BtnDelete_LostFocus(sender As Object, e As EventArgs) Handles BtnDelete.LostFocus
        If BtnDelete.Enabled = True Then
            BtnDelete.BorderRadius = 0
            BtnDelete.Normalcolor = Color.FromArgb(0, 122, 204)
        End If
    End Sub

    Sub bersih2()
        tlabnum.Text = ""
        'ttemp.Text = ""
        'ttime.Text = ""
        'tequip.Text = ""
        tcount1.Text = ""
        tcount2.Text = ""
        tcount3.Text = ""
        tcount4.Text = ""
        tmean.Text = ""
        'ttestdate.Text = Today.ToString(LabelFormatDate.Text)
        'tanalyst.Text = ""
        tconcentration.Text = ""
        tmethodvia.SelectedIndex = -1
        tmethodused.SelectedIndex = -1
        tsubtrade.SelectedIndex = -1
        tlabnum.Focus()
    End Sub

    Private Sub BtnSave_KeyDown(sender As Object, e As KeyEventArgs) Handles BtnSave.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Space Then
            BtnSave_Click(sender, e)
        End If
    End Sub

    Private Sub ttemp_GotFocus(sender As Object, e As EventArgs) Handles ttemp.GotFocus
        ttemp.SelectAll()
    End Sub

    Private Sub ttime_GotFocus(sender As Object, e As EventArgs) Handles ttime.GotFocus
        ttime.SelectAll()
    End Sub

    Private Sub tconcentration_GotFocus(sender As Object, e As EventArgs) Handles tconcentration.GotFocus
        tconcentration.SelectAll()
    End Sub
End Class
