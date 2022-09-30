Imports System.Globalization

Public Class Germination_Test

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If tlabnum.Text = "" Then
            MetroMessageBox.Show(Me, "Identitas sampel harus diisi", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tlabnum.Focus()
        ElseIf String.IsNullOrEmpty(tVariety.Text) Or tVariety.Text = "..." Then
            MetroMessageBox.Show(Me, "Pastikan identitas sample sudah benar!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        ElseIf Lreqnum.Text <> _DataToValue("SELECT [id] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ") Then
            MetroMessageBox.Show(Me, "Pastikan No Lab " + tlabnum.Text + "sesuai dengan Identitas Sample", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, 211)
            Return
        Else
            If _isBOF("receipt", "labnum", tlabnum.Text) = True Then
                'cek kesamaan antara % Germination dan % Normal
                If tGmPrc.Text = tNmlPrc.Text Then
                    If _isBOF("germination_id", "labnum", tlabnum.Text) = False Then
                        If _isBOF("germination", "labnum", tlabnum.Text) = False Then

                            Dim tgluji As Date
                            tgluji = Date.ParseExact(Ttestdate.Text, formatDate, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None)
                            Dim tglfist As Date
                            tglfist = Date.ParseExact(tfistdate.Text, formatDate, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None)
                            Dim tglfinl As Date
                            tglfinl = Date.ParseExact(Tfinaldate.Text, formatDate, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None)
                            'Prosedur to insert to ID Germination
                            _RunSQL("INSERT INTO [germination_id]
                                (id_request
                                , labnum
                                , test_date
                                , fist_count
                                , scnd_count
                                , analyst
                                , substrate
                                , temp
                                , treatment
                                , abnormality
                                , dt_input_by
                                , vg_tgl_input)
                            VALUES
                                ('" & Lreqnum.Text & "'
                                ,'" & tlabnum.Text & "'
                                ,'" & tgluji.ToString("yyyy-MM-dd") & "'
                                ,'" & tglfist.ToString("yyyy-MM-dd") & "'
                                ,'" & tglfinl.ToString("yyyy-MM-dd") & "'
                                ,'" & tanalyst.Text & "'
                                ,'" & Tsubst.Text & "'
                                ,'" & Ttemperatur.Text & "'
                                ,'" & Ttreatment.Text & "'
                                ,'" & tabnormal.Text & "'
                                ,'" & login.Luserid.Text & "'
                                ,GETDATE()) ")

                            'Prosedur INSERT Germinator value
                            _RunSQL_nomsgbox("INSERT INTO [dbo].[germination]

                                ([labnum]
                                ,[character]
                                ,[t1]
                                ,[t2]
                                ,[t3]
                                ,[t4]
                                ,[avrg]
                                ,[percn])

                            VALUES

                                ('" & tlabnum.Text & "'
                                ,'Normal Seedling (%)'
                                ," & Val(tNml1.Text) & "
                                ," & Val(tNml2.Text) & "
                                ," & Val(tNml3.Text) & "
                                ," & Val(tNml4.Text) & "
                                ," & Val(tNmlArg.Text) & "
                                ," & Val(tNmlPrc.Text) & "),
                                
                                ('" & tlabnum.Text & "'
                                ,'Abnormal Seedling (%)'
                                ," & Val(tAbNml1.Text) & "
                                ," & Val(tAbNml2.Text) & "
                                ," & Val(tAbNml3.Text) & "
                                ," & Val(tAbNml4.Text) & "
                                ," & Val(tAbNmlArg.Text) & "
                                ," & Val(tAbNmlPrc.Text) & "),

                                ('" & tlabnum.Text & "'
                                ,'Hard Seed (%)'
                                ," & Val(tHd1.Text) & "
                                ," & Val(tHd2.Text) & "
                                ," & Val(tHd3.Text) & "
                                ," & Val(tHd4.Text) & "
                                ," & Val(tHdArg.Text) & "
                                ," & Val(tHdPrc.Text) & "),
                                
                                ('" & tlabnum.Text & "'
                                ,'Fresh Seed (%)'
                                ," & Val(tFrs1.Text) & "
                                ," & Val(tFrs2.Text) & "
                                ," & Val(tFrs3.Text) & "
                                ," & Val(tFrs4.Text) & "
                                ," & Val(tFrsArg.Text) & "
                                ," & Val(tFrsPrc.Text) & "),

                                ('" & tlabnum.Text & "'
                                ,'Dead Seed (%)'
                                ," & Val(tDd1.Text) & "
                                ," & Val(tDd2.Text) & "
                                ," & Val(tDd3.Text) & "
                                ," & Val(tDd4.Text) & "
                                ," & Val(tDdArg.Text) & "
                                ," & Val(tDdPrc.Text) & "),
                                
                                ('" & tlabnum.Text & "'
                                ,'Index Vigor (%)'
                                ," & Val(tVg1.Text) & "
                                ," & Val(tVg2.Text) & "
                                ," & Val(tVg3.Text) & "
                                ," & Val(tVg4.Text) & "
                                ," & Val(tVgArg.Text) & "
                                ," & Val(tVgPrc.Text) & "),

                                ('" & tlabnum.Text & "'
                                ,'Germination (%)'
                                ," & Val(tGm1.Text) & "
                                ," & Val(tGm2.Text) & "
                                ," & Val(tGm3.Text) & "
                                ," & Val(tGm4.Text) & "
                                ," & Val(tGmArg.Text) & "
                                ," & Val(tGmPrc.Text) & ")
                    ")
                            tlabnum.Focus()
                            bersih2()
                        Else
                            MetroMessageBox.Show(Me, "Data sudah pernah di input petugas")
                        End If
                    Else
                        MetroMessageBox.Show(Me, "Data sudah pernah di input petugas")
                    End If
                Else
                    MetroMessageBox.Show(Me, "Germination Persen tidak sama dengan Normal Percen", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, 211)
                    tGmPrc.WithError = True
                End If
            Else
                MetroMessageBox.Show(Me, "Lab Number belum pernah masuk di Sample Receipt")
            End If

            'Return


        End If
    End Sub

    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click
        If String.IsNullOrEmpty(tlabnum.Text) Then
            MetroMessageBox.Show(Me, "Lab Number harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        Else
            openDB()
            Dim sql As String = "Select * From germination WHERE (labnum= '" & tlabnum.Text & "') and ([character]='Normal Seedling (%)')"
            cmd = New SqlClient.SqlCommand(sql, con) With {
                .CommandType = CommandType.Text,
                .CommandText = sql
            }
            dread = cmd.ExecuteReader
            If dread.Read = True Then
                'Normal Seedling (%)'
                tNml1.Text = _DataToValue("SELECT t1 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and ([character]='Normal Seedling (%)') ")
                tNml2.Text = _DataToValue("SELECT t2 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and ([character]='Normal Seedling (%)') ")
                tNml3.Text = _DataToValue("SELECT t3 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and ([character]='Normal Seedling (%)') ")
                tNml4.Text = _DataToValue("SELECT t4 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and ([character]='Normal Seedling (%)') ")
                tNmlArg.Text = _DataToValue("SELECT avrg FROM germination WHERE (labnum= '" & tlabnum.Text & "') and ([character]='Normal Seedling (%)') ")
                tNmlPrc.Text = _DataToValue("SELECT percn FROM germination WHERE (labnum= '" & tlabnum.Text & "') and ([character]='Normal Seedling (%)') ")

                'Abnormal Seedling (%)'
                tAbNml1.Text = _DataToValue("SELECT t1 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Abnormal Seedling (%)' ")
                tAbNml2.Text = _DataToValue("SELECT t2 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Abnormal Seedling (%)' ")
                tAbNml3.Text = _DataToValue("SELECT t3 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Abnormal Seedling (%)' ")
                tAbNml4.Text = _DataToValue("SELECT t4 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Abnormal Seedling (%)' ")
                tAbNmlArg.Text = _DataToValue("SELECT avrg FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Abnormal Seedling (%)' ")
                tAbNmlPrc.Text = _DataToValue("SELECT percn FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Abnormal Seedling (%)' ")

                'Hard Seedling (%)'
                tHd1.Text = _DataToValue("SELECT t1 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Hard Seed (%)' ")
                tHd2.Text = _DataToValue("SELECT t2 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Hard Seed (%)' ")
                tHd3.Text = _DataToValue("SELECT t3 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Hard Seed (%)' ")
                tHd4.Text = _DataToValue("SELECT t4 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Hard Seed (%)' ")
                tHdArg.Text = _DataToValue("SELECT avrg FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Hard Seed (%)' ")
                tHdPrc.Text = _DataToValue("SELECT percn FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Hard Seed (%)' ")

                'Fresh Seedling (%)'
                tFrs1.Text = _DataToValue("SELECT t1 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Fresh Seed (%)' ")
                tFrs2.Text = _DataToValue("SELECT t2 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Fresh Seed (%)' ")
                tFrs3.Text = _DataToValue("SELECT t3 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Fresh Seed (%)' ")
                tFrs4.Text = _DataToValue("SELECT t4 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Fresh Seed (%)' ")
                tFrsArg.Text = _DataToValue("SELECT avrg FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Fresh Seed (%)' ")
                tFrsPrc.Text = _DataToValue("SELECT percn FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Fresh Seed (%)' ")

                'Dead Seed (%)'
                tDd1.Text = _DataToValue("SELECT t1 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Dead Seed (%)' ")
                tDd2.Text = _DataToValue("SELECT t2 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Dead Seed (%)' ")
                tDd3.Text = _DataToValue("SELECT t3 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Dead Seed (%)' ")
                tDd4.Text = _DataToValue("SELECT t4 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Dead Seed (%)' ")
                tDdArg.Text = _DataToValue("SELECT avrg FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Dead Seed (%)' ")
                tDdPrc.Text = _DataToValue("SELECT percn FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Dead Seed (%)' ")

                'Index Vigor (%)'
                tVg1.Text = _DataToValue("SELECT t1 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Index Vigor (%)' ")
                tVg2.Text = _DataToValue("SELECT t2 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Index Vigor (%)' ")
                tVg3.Text = _DataToValue("SELECT t3 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Index Vigor (%)' ")
                tVg4.Text = _DataToValue("SELECT t4 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Index Vigor (%)' ")
                tVgArg.Text = _DataToValue("SELECT avrg FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Index Vigor (%)' ")
                tVgPrc.Text = _DataToValue("SELECT percn FROM germination WHERE (labnum= '" & tlabnum.Text & "') and [character]='Index Vigor (%)' ")

                'Gemination (%)'
                tGm1.Text = _DataToValue("SELECT t1 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and ([character]='Germination (%)') ")
                tGm2.Text = _DataToValue("SELECT t2 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and ([character]='Germination (%)') ")
                tGm3.Text = _DataToValue("SELECT t3 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and ([character]='Germination (%)') ")
                tGm4.Text = _DataToValue("SELECT t4 FROM germination WHERE (labnum= '" & tlabnum.Text & "') and ([character]='Germination (%)') ")
                tGmArg.Text = _DataToValue("SELECT avrg FROM germination WHERE (labnum= '" & tlabnum.Text & "') and ([character]='Germination (%)') ")
                tGmPrc.Text = _DataToValue("SELECT percn FROM germination WHERE (labnum= '" & tlabnum.Text & "') and ([character]='Germination (%)') ")

                'Get Value from Table germination_id
                Dim tgluji As Date = _DataToValue("SELECT [test_date] FROM [germination_id] WHERE [labnum]='" & tlabnum.Text & "'")
                Dim tglfist As Date = _DataToValue("SELECT [fist_count] FROM [germination_id] WHERE [labnum]='" & tlabnum.Text & "'")
                Dim tglfinl As Date = _DataToValue("SELECT [scnd_count] FROM [germination_id] WHERE [labnum]='" & tlabnum.Text & "'")
                Ttestdate.Text = tgluji.ToString(labeldate1.Text)
                tfistdate.Text = tglfist.ToString(labeldate2.Text)
                Tfinaldate.Text = tglfinl.ToString(labeldate3.Text)

                tanalyst.Text = _DataToValue("SELECT [analyst] FROM [germination_id] WHERE [labnum]='" & tlabnum.Text & "'")
                Tsubst.Text = _DataToValue("SELECT [substrate] FROM [germination_id] WHERE [labnum]='" & tlabnum.Text & "'")
                Ttemperatur.Text = _DataToValue("SELECT [temp] FROM [germination_id] WHERE [labnum]='" & tlabnum.Text & "'")
                Ttreatment.Text = _DataToValue("SELECT [treatment] FROM [germination_id] WHERE [labnum]='" & tlabnum.Text & "'")
                tabnormal.Text = _DataToValue("SELECT [abnormality] FROM [germination_id] WHERE [labnum]='" & tlabnum.Text & "'")

                openDB()
                sql = "Select labnum From receipt WHERE (labnum= '" & tlabnum.Text & "') AND delete_at is NULL"
                cmd = New SqlClient.SqlCommand(sql, con) With {
                    .CommandType = CommandType.Text,
                    .CommandText = sql
                }
                dread = cmd.ExecuteReader
                If dread.Read = True Then
                    Lreqnum.Text = _DataToValue("SELECT [id] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                    tlotid.Text = _DataToValue("SELECT [nojob] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                    tnomnl.Text = _DataToValue("SELECT [nomnl] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                    tVariety.Text = _DataToValue("SELECT [variety] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                    tscope.Text = _DataToValue("SELECT [scope] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                    btnSave.Enabled = False
                    btnUpdate.Enabled = True
                    btnDelete.Enabled = True
                    con.Close()
                End If

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
        End If
    End Sub

    Private Sub btnUpdate_ControlRemoved(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If tlabnum.Text = "" Or tVariety.Text = "..." Then
            MetroFramework.MetroMessageBox.Show(Me, "Identitas sample harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tlabnum.Focus()
        Else
            Dim tgluji As Date
            tgluji = Date.ParseExact(Ttestdate.Text, formatDate, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None)
            Dim tglfist As Date
            tglfist = Date.ParseExact(tfistdate.Text, formatDate, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None)
            Dim tglfinl As Date
            tglfinl = Date.ParseExact(Tfinaldate.Text, formatDate, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None)
            _RunSQL("Update germination_id SET id_request='" & Lreqnum.Text & "',test_date ='" & tgluji.ToString("yyyy-MM-dd") & "', fist_count ='" & tglfist.ToString("yyyy-MM-dd") & "', scnd_count ='" & tglfinl.ToString("yyyy-MM-dd") & "', analyst ='" & tanalyst.Text & "', substrate ='" & Tsubst.Text & "', temp='" & Ttemperatur.Text & "', treatment='" & Ttreatment.Text & "', vg_tgl_input= GETDATE(), abnormality='" & tabnormal.Text & "' WHERE (labnum = '" & tlabnum.Text & "') ")

            For values As Integer = 1 To 7
                If values = 1 Then
                    _RunSQL_nomsgbox("Update germination Set labnum='" & tlabnum.Text & "', t1='" & Val(tNml1.Text) & "',t2='" & Val(tNml2.Text) & "',t3='" & Val(tNml3.Text) & "',t4='" & Val(tNml4.Text) & "',avrg='" & Val(tNmlArg.Text) & "',percn='" & Val(tNmlPrc.Text) & "' Where (labnum='" & tlabnum.Text & "') And ([character]='Normal Seedling (%)')")
                ElseIf values = 2 Then
                    _RunSQL_nomsgbox("Update germination Set labnum='" & tlabnum.Text & "', t1='" & Val(tAbNml1.Text) & "',t2='" & Val(tAbNml2.Text) & "',t3='" & Val(tAbNml3.Text) & "',t4='" & Val(tAbNml4.Text) & "',avrg='" & Val(tAbNmlArg.Text) & "',percn='" & Val(tAbNmlPrc.Text) & "' Where (labnum='" & tlabnum.Text & "') And ([character]='Abnormal Seedling (%)')")
                ElseIf values = 3 Then
                    _RunSQL_nomsgbox("Update germination Set labnum='" & tlabnum.Text & "', t1='" & Val(tVg1.Text) & "',t2='" & Val(tVg2.Text) & "',t3='" & Val(tVg3.Text) & "',t4='" & Val(tVg4.Text) & "',avrg='" & Val(tVgArg.Text) & "',percn='" & Val(tVgPrc.Text) & "' Where (labnum='" & tlabnum.Text & "') And ([character]='Index Vigor (%)')")
                ElseIf values = 4 Then
                    _RunSQL_nomsgbox("Update germination Set labnum='" & tlabnum.Text & "', t1='" & Val(tHd1.Text) & "',t2='" & Val(tHd2.Text) & "',t3='" & Val(tHd3.Text) & "',t4='" & Val(tHd4.Text) & "',avrg='" & Val(tHdArg.Text) & "',percn='" & Val(tHdPrc.Text) & "' Where (labnum='" & tlabnum.Text & "') And ([character]='Hard Seed (%)')")
                ElseIf values = 5 Then
                    _RunSQL_nomsgbox("Update germination Set labnum='" & tlabnum.Text & "', t1='" & Val(tFrs1.Text) & "',t2='" & Val(tFrs2.Text) & "',t3='" & Val(tFrs3.Text) & "',t4='" & Val(tFrs4.Text) & "',avrg='" & Val(tFrsArg.Text) & "',percn='" & Val(tFrsPrc.Text) & "' Where (labnum='" & tlabnum.Text & "') And ([character]='Fresh Seed (%)')")
                ElseIf values = 6 Then
                    _RunSQL_nomsgbox("Update germination Set labnum='" & tlabnum.Text & "', t1='" & Val(tDd1.Text) & "',t2='" & Val(tDd2.Text) & "',t3='" & Val(tDd3.Text) & "',t4='" & Val(tDd4.Text) & "',avrg='" & Val(tDdArg.Text) & "',percn='" & Val(tDdPrc.Text) & "' Where (labnum='" & tlabnum.Text & "') And ([character]='Dead Seed (%)')")
                ElseIf values = 7 Then
                    _RunSQL_nomsgbox("Update germination Set labnum='" & tlabnum.Text & "', t1='" & Val(tGm1.Text) & "',t2='" & Val(tGm2.Text) & "',t3='" & Val(tGm3.Text) & "',t4='" & Val(tGm4.Text) & "',avrg='" & Val(tGmArg.Text) & "',percn='" & Val(tGmPrc.Text) & "' Where (labnum='" & tlabnum.Text & "') And ([character]='Germination (%)')")
                End If
            Next

        End If
    End Sub

    Private Sub btncari1_Click(sender As Object, e As EventArgs) Handles btncari1.Click
        If String.IsNullOrEmpty(tlabnum.Text) Then
            MetroMessageBox.Show(Me, "Lab Number harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        Else
            ''_isBOF jika pada table germination ADA value yg sama dengan tlabnum.text maka
            ''akan dilanjutkan mengambil data receipt (varietas, lotid, dll)
            If _isBOF("germination", "labnum", tlabnum.Text) = False Then
                If _isBOF("receipt", "labnum", tlabnum.Text) = True Then
                    Lreqnum.Text = _DataToValue("SELECT [id] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                    tlotid.Text = _DataToValue("SELECT [nojob] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                    tnomnl.Text = _DataToValue("SELECT [nomnl] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                    tVariety.Text = _DataToValue("SELECT [variety] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                    tscope.Text = _DataToValue("SELECT [scope] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                    tanalyst.Text = _DataToValue("SELECT [gerout_namelog] FROM [report_status_pengujian] WHERE [labnum] = '" & tlabnum.Text & "'")
                    Dim tgluji As Date = _DataToValue("SELECT [Ger_TestLog] FROM [report_status_pengujian] WHERE [labnum]='" & tlabnum.Text & "'")
                    Dim tglvigor As Date = _DataToValue("SELECT CASE WHEN [gervigor_log] IS NULL THEN [gerout_log] ELSE [gervigor_log] END AS [gervigor] FROM [report_status_pengujian] WHERE [labnum]='" & tlabnum.Text & "'")
                    Dim tglfinl As Date = _DataToValue("SELECT [gerout_log] FROM [report_status_pengujian] WHERE [labnum]='" & tlabnum.Text & "'")
                    Ttestdate.Text = tgluji.ToString(labeldate1.Text)
                    tfistdate.Text = tglvigor.ToString(labeldate2.Text)
                    Tfinaldate.Text = tglfinl.ToString(labeldate3.Text)
                Else
                    Dim result As Integer = MetroMessageBox.Show(Me, "Data tidak ditemukan!. No Lab. belum terdaftar di Peneriamaan Sampel Masuk!.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                    If result = DialogResult.OK Then
                        Me.tlabnum.Focus()
                    ElseIf result = DialogResult.No Then
                        btnSave.Enabled = True
                        btnUpdate.Enabled = False
                        btnDelete.Enabled = False
                        Me.tlabnum.Focus()
                    End If
                End If
            Else
                Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data sudah ada!. Apakah anda ingin melanjutkan pencarian data?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                If result = DialogResult.Yes Then
                    tlabnum.Focus()
                ElseIf result = DialogResult.No Then
                    btnSave.Enabled = True
                    btnUpdate.Enabled = False
                    btnDelete.Enabled = False
                    Me.tlabnum.Focus()
                End If
            End If
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrEmpty(tlabnum.Text) Then
            MetroMessageBox.Show(Me, "Lab Number harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        ElseIf String.IsNullOrEmpty(tVariety.Text) Or tVariety.Text = "..." Then
            MetroMessageBox.Show(Me, "Pastikan identitas sample sudah benar!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        Else
            Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk menghapus data ini " + tlabnum.Text, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
            If result = DialogResult.Yes Then
                _RunSQL("DELETE [germination]  WHERE ([labnum]= '" & tlabnum.Text & "')")
                _RunSQL_nomsgbox("DELETE [germination_id] WHERE [labnum]='" & tlabnum.Text & "'")
                Me.tlabnum.Focus()
                'Bersihkan()
            ElseIf result = DialogResult.No Then
                btnSave.Enabled = True
                btnUpdate.Enabled = False
                btnDelete.Enabled = False
                Me.tlabnum.Focus()
            End If
        End If
    End Sub

    Private Sub tlabnum_KeyDown(sender As Object, e As KeyEventArgs) Handles tlabnum.KeyDown
        If e.KeyCode = Keys.Enter Then
            btncari1_Click(sender, e)
        End If
    End Sub

    Dim myTextBoxes, myTextBoxes2, myTextBoxes3, myTextBoxes4, myTextBoxes5, myTextBoxes6, myTextBoxes7 As New List(Of MetroFramework.Controls.MetroTextBox)

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

    Private Function Calculate2(ByVal TheTextboxes2 As List(Of MetroFramework.Controls.MetroTextBox)) As String
        Dim ReturnValue As String = String.Empty
        Dim TextBoxSum As Integer = 0
        Dim Items As Integer = 0
        Dim TextBoxValue As Integer = 0
        For Each SingleTextBox As MetroFramework.Controls.MetroTextBox In TheTextboxes2
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

    Private Function Calculate3(ByVal TheTextboxes3 As List(Of MetroFramework.Controls.MetroTextBox)) As String
        Dim ReturnValue As String = String.Empty
        Dim TextBoxSum As Integer = 0
        Dim Items As Integer = 0
        Dim TextBoxValue As Integer = 0
        For Each SingleTextBox As MetroFramework.Controls.MetroTextBox In TheTextboxes3
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

    Private Function Calculate4(ByVal TheTextboxes4 As List(Of MetroFramework.Controls.MetroTextBox)) As String
        Dim ReturnValue As String = String.Empty
        Dim TextBoxSum As Integer = 0
        Dim Items As Integer = 0
        Dim TextBoxValue As Integer = 0
        For Each SingleTextBox As MetroFramework.Controls.MetroTextBox In TheTextboxes4
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

    Private Function Calculate5(ByVal TheTextboxes5 As List(Of MetroFramework.Controls.MetroTextBox)) As String
        Dim ReturnValue As String = String.Empty
        Dim TextBoxSum As Integer = 0
        Dim Items As Integer = 0
        Dim TextBoxValue As Integer = 0
        For Each SingleTextBox As MetroFramework.Controls.MetroTextBox In TheTextboxes5
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

    Private Function Calculate6(ByVal TheTextboxes6 As List(Of MetroFramework.Controls.MetroTextBox)) As String
        Dim ReturnValue As String = String.Empty
        Dim TextBoxSum As Integer = 0
        Dim Items As Integer = 0
        Dim TextBoxValue As Integer = 0
        For Each SingleTextBox As MetroFramework.Controls.MetroTextBox In TheTextboxes6
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

    Private Function Calculate7(ByVal TheTextboxes7 As List(Of MetroFramework.Controls.MetroTextBox)) As String
        Dim ReturnValue As String = String.Empty
        Dim TextBoxSum As Integer = 0
        Dim Items As Integer = 0
        Dim TextBoxValue As Integer = 0
        For Each SingleTextBox As MetroFramework.Controls.MetroTextBox In TheTextboxes7
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
    Private Sub Germination_Test_Load(sender As Object, e As EventArgs) Handles Me.Load
        myTextBoxes.Add(tNml1)
        myTextBoxes.Add(tNml2)
        myTextBoxes.Add(tNml3)
        myTextBoxes.Add(tNml4)

        myTextBoxes2.Add(tAbNml1)
        myTextBoxes2.Add(tAbNml2)
        myTextBoxes2.Add(tAbNml3)
        myTextBoxes2.Add(tAbNml4)

        myTextBoxes3.Add(tHd1)
        myTextBoxes3.Add(tHd2)
        myTextBoxes3.Add(tHd3)
        myTextBoxes3.Add(tHd4)

        myTextBoxes4.Add(tFrs1)
        myTextBoxes4.Add(tFrs2)
        myTextBoxes4.Add(tFrs3)
        myTextBoxes4.Add(tFrs4)

        myTextBoxes5.Add(tDd1)
        myTextBoxes5.Add(tDd2)
        myTextBoxes5.Add(tDd3)
        myTextBoxes5.Add(tDd4)

        myTextBoxes6.Add(tVg1)
        myTextBoxes6.Add(tVg2)
        myTextBoxes6.Add(tVg3)
        myTextBoxes6.Add(tVg4)

        myTextBoxes7.Add(tGm1)
        myTextBoxes7.Add(tGm2)
        myTextBoxes7.Add(tGm3)
        myTextBoxes7.Add(tGm4)

        'labeldate1.Text = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern
        'labeldate2.Text = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern
        'labeldate3.Text = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern

        MetroTabControl1.SelectedIndex = 0
    End Sub

    Private Sub tAbNml1_GotFocus(sender As Object, e As EventArgs) Handles tAbNml1.GotFocus
        tAbNml1.SelectAll()
    End Sub

    Private Sub tAbNml2_GotFocus(sender As Object, e As EventArgs) Handles tAbNml2.GotFocus
        tAbNml2.SelectAll()
    End Sub

    Private Sub tAbNml3_GotFocus(sender As Object, e As EventArgs) Handles tAbNml3.GotFocus
        tAbNml3.SelectAll()
    End Sub

    Private Sub tAbNml4_GotFocus(sender As Object, e As EventArgs) Handles tAbNml4.GotFocus
        tAbNml4.SelectAll()
    End Sub

    Private Sub tNml1_GotFocus(sender As Object, e As EventArgs) Handles tNml1.GotFocus
        tNml1.SelectAll()
    End Sub

    Private Sub tNml2_GotFocus(sender As Object, e As EventArgs) Handles tNml2.GotFocus
        tNml2.SelectAll()
    End Sub

    Private Sub tNml3_GotFocus(sender As Object, e As EventArgs) Handles tNml3.GotFocus
        tNml3.SelectAll()
    End Sub

    Private Sub tNml4_GotFocus(sender As Object, e As EventArgs) Handles tNml4.GotFocus
        tNml4.SelectAll()
    End Sub

    Private Sub tHd1_GotFocus(sender As Object, e As EventArgs) Handles tHd1.GotFocus
        tHd1.SelectAll()
    End Sub

    Private Sub tHd2_GotFocus(sender As Object, e As EventArgs) Handles tHd2.GotFocus
        tHd2.SelectAll()
    End Sub

    Private Sub tHd3_GotFocus(sender As Object, e As EventArgs) Handles tHd3.GotFocus
        tHd3.SelectAll()
    End Sub

    Private Sub tHd4_GotFocus(sender As Object, e As EventArgs) Handles tHd4.GotFocus
        tHd4.SelectAll()
    End Sub

    Private Sub tFrs1_GotFocus(sender As Object, e As EventArgs) Handles tFrs1.GotFocus
        tFrs1.SelectAll()
    End Sub

    Private Sub tFrs2_GotFocus(sender As Object, e As EventArgs) Handles tFrs2.GotFocus
        tFrs2.SelectAll()
    End Sub

    Private Sub tFrs3_GotFocus(sender As Object, e As EventArgs) Handles tFrs3.GotFocus
        tFrs3.SelectAll()
    End Sub

    Private Sub tFrs4_GotFocus(sender As Object, e As EventArgs) Handles tFrs4.GotFocus
        tFrs4.SelectAll()
    End Sub

    Private Sub tDd1_GotFocus(sender As Object, e As EventArgs) Handles tDd1.GotFocus
        tDd1.SelectAll()
    End Sub

    Private Sub tDd2_GotFocus(sender As Object, e As EventArgs) Handles tDd2.GotFocus
        tDd2.SelectAll()
    End Sub

    Private Sub tDd3_GotFocus(sender As Object, e As EventArgs) Handles tDd3.GotFocus
        tDd3.SelectAll()
    End Sub

    Private Sub tDd4_GotFocus(sender As Object, e As EventArgs) Handles tDd4.GotFocus
        tDd4.SelectAll()
    End Sub

    Private Sub tVg1_GotFocus(sender As Object, e As EventArgs) Handles tVg1.GotFocus
        tVg1.SelectAll()
    End Sub

    Private Sub tval2_GotFocus(sender As Object, e As EventArgs) Handles tval2.GotFocus
        tVg2.SelectAll()
    End Sub

    Private Sub tval3_GotFocus(sender As Object, e As EventArgs) Handles tval3.GotFocus
        tVg3.SelectAll()
    End Sub

    Private Sub tval4_GotFocus(sender As Object, e As EventArgs) Handles tval4.GotFocus
        tVg4.SelectAll()
    End Sub

    Private Sub tNmlArg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tNml1.TextChanged, tNml2.TextChanged, tNml3.TextChanged, tNml4.TextChanged
        '      
        'Fungsi Average Dinamic
        '
        tNmlArg.Text = Calculate((myTextBoxes))
        '
        '
        tGm1.Text = tNml1.Text
        tGm2.Text = tNml2.Text
        tGm3.Text = tNml3.Text
        tGm4.Text = tNml4.Text
        tGmArg.Text = tNmlArg.Text
        tGmPrc.Text = tNmlPrc.Text
    End Sub

    Private Sub tAbNmlArg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tAbNml1.TextChanged, tAbNml2.TextChanged, tAbNml3.TextChanged, tAbNml4.TextChanged
        'Fungsi Average Dinamic
        '
        tAbNmlArg.Text = Calculate2((myTextBoxes2))
        '
    End Sub
    Private Sub tHdArg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tHd1.TextChanged, tHd2.TextChanged, tHd3.TextChanged, tHd4.TextChanged
        'Fungsi Average Dinamic
        '
        tHdArg.Text = Calculate3((myTextBoxes3))
        '
    End Sub
    Private Sub tFrsArg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tFrs1.TextChanged, tFrs2.TextChanged, tFrs3.TextChanged, tFrs4.TextChanged
        ''Fungsi Average Dinamic
        '
        tFrsArg.Text = Calculate4((myTextBoxes4))
        '
    End Sub
    Private Sub tDdArg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tDd1.TextChanged, tDd2.TextChanged, tDd3.TextChanged, tDd4.TextChanged
        ''Fungsi Average Dinamic
        '
        tDdArg.Text = Calculate5((myTextBoxes5))
        '
    End Sub
    Private Sub tVgArg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tVg1.TextChanged, tVg2.TextChanged, tVg3.TextChanged, tVg4.TextChanged
        ''Fungsi Average Dinamic
        '
        tVgArg.Text = Calculate6((myTextBoxes6))

    End Sub
    Private Sub tGmArg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tGm1.TextChanged, tGm2.TextChanged, tGm3.TextChanged, tGm4.TextChanged
        ''Fungsi Average Dinamic
        '
        tGmArg.Text = Calculate7((myTextBoxes7))
        '
    End Sub
    Private Sub tNmlPrc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tNmlArg.TextChanged
        'tNmlPrc.Text = CInt(tNmlArg.Text)

        Dim ts1, ts2, ts3, ts4 As Decimal
        Try
            ts1 = Convert.ToDecimal(tNml1.Text)
        Catch
            ts1 = 0
        End Try
        Try
            ts2 = Convert.ToDecimal(tNml2.Text)
        Catch
            ts2 = 0
        End Try
        Try
            ts3 = Convert.ToDecimal(tNml3.Text)
        Catch
            ts3 = 0
        End Try
        Try
            ts4 = Convert.ToDecimal(tNml4.Text)
        Catch
            ts4 = 0
        End Try
        tNmlPrc.Text = CInt((ts1 + ts2 + ts3 + ts4) / Convert.ToDecimal(tbagi.Text)) '.ToString("00.00")


    End Sub

    Private Sub tAbNmlArg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tAbNmlArg.GotFocus
        Me.tAbNmlArg.SelectAll()
    End Sub

    Private Sub tAbNmlPrc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tAbNmlArg.TextChanged
        'tAbNmlPrc.Text = CInt(tAbNmlArg.Text)
        Dim ts1, ts2, ts3, ts4 As Decimal
        Try
            ts1 = Convert.ToDecimal(tAbNml1.Text)
        Catch
            ts1 = 0
        End Try
        Try
            ts2 = Convert.ToDecimal(tAbNml2.Text)
        Catch
            ts2 = 0
        End Try
        Try
            ts3 = Convert.ToDecimal(tAbNml3.Text)
        Catch
            ts3 = 0
        End Try
        Try
            ts4 = Convert.ToDecimal(tAbNml4.Text)
        Catch
            ts4 = 0
        End Try
        tAbNmlPrc.Text = CInt((ts1 + ts2 + ts3 + ts4) / Convert.ToDecimal(tbagi.Text)) '.ToString("00.00")

    End Sub

    Private Sub tHdArg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tHdArg.GotFocus
        Me.tHdArg.SelectAll()
    End Sub

    Private Sub tHdPrc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tHdArg.TextChanged
        'tHdPrc.Text = CInt(tHdArg.Text)
        Dim ts1, ts2, ts3, ts4 As Decimal
        Try
            ts1 = Convert.ToDecimal(tHd1.Text)
        Catch
            ts1 = 0
        End Try
        Try
            ts2 = Convert.ToDecimal(tHd2.Text)
        Catch
            ts2 = 0
        End Try
        Try
            ts3 = Convert.ToDecimal(tHd3.Text)
        Catch
            ts3 = 0
        End Try
        Try
            ts4 = Convert.ToDecimal(tHd4.Text)
        Catch
            ts4 = 0
        End Try
        tHdPrc.Text = CInt((ts1 + ts2 + ts3 + ts4) / Convert.ToDecimal(tbagi.Text)) '.ToString("00.00")
    End Sub

    Private Sub tFrsArg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tFrsArg.GotFocus
        Me.tFrsArg.SelectAll()
    End Sub

    Private Sub tFrsPrc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tFrsArg.TextChanged
        'tFrsPrc.Text = CInt(tFrsArg.Text)
        Dim ts1, ts2, ts3, ts4 As Decimal
        Try
            ts1 = Convert.ToDecimal(tFrs1.Text)
        Catch
            ts1 = 0
        End Try
        Try
            ts2 = Convert.ToDecimal(tFrs2.Text)
        Catch
            ts2 = 0
        End Try
        Try
            ts3 = Convert.ToDecimal(tFrs3.Text)
        Catch
            ts3 = 0
        End Try
        Try
            ts4 = Convert.ToDecimal(tFrs4.Text)
        Catch
            ts4 = 0
        End Try
        tFrsPrc.Text = CInt((ts1 + ts2 + ts3 + ts4) / Convert.ToDecimal(tbagi.Text)) '.ToString("00.00")

    End Sub

    Private Sub tDdArg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tDdArg.GotFocus
        Me.tDdArg.SelectAll()
    End Sub

    Private Sub tDdPrc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tDdArg.TextChanged
        'tDdPrc.Text = CInt(tDdArg.Text)
        Dim ts1, ts2, ts3, ts4 As Decimal
        Try
            ts1 = Convert.ToDecimal(tDd1.Text)
        Catch
            ts1 = 0
        End Try
        Try
            ts2 = Convert.ToDecimal(tDd2.Text)
        Catch
            ts2 = 0
        End Try
        Try
            ts3 = Convert.ToDecimal(tDd3.Text)
        Catch
            ts3 = 0
        End Try
        Try
            ts4 = Convert.ToDecimal(tDd4.Text)
        Catch
            ts4 = 0
        End Try
        tDdPrc.Text = CInt((ts1 + ts2 + ts3 + ts4) / Convert.ToDecimal(tbagi.Text)) '.ToString("00.00")
    End Sub

    Private Sub tGmArg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tGmArg.GotFocus
        Me.tGmArg.SelectAll()
    End Sub

    Private Sub tGmPrc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tGmArg.TextChanged
        'tGmPrc.Text = CInt(tGmArg.Text)
        Dim ts1, ts2, ts3, ts4 As Decimal
        Try
            ts1 = Convert.ToDecimal(tGm1.Text)
        Catch
            ts1 = 0
        End Try
        Try
            ts2 = Convert.ToDecimal(tGm2.Text)
        Catch
            ts2 = 0
        End Try
        Try
            ts3 = Convert.ToDecimal(tGm3.Text)
        Catch
            ts3 = 0
        End Try
        Try
            ts4 = Convert.ToDecimal(tGm4.Text)
        Catch
            ts4 = 0
        End Try
        tGmPrc.Text = CInt((ts1 + ts2 + ts3 + ts4) / Convert.ToDecimal(tbagi.Text)) '.ToString("00.00")

        ''
    End Sub

    Private Sub tVgArg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tVgArg.GotFocus
        Me.tVgArg.SelectAll()
    End Sub

    Private Sub tVgPrc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tVgArg.TextChanged
        'tVgPrc.Text = CInt(tVgArg.Text)
        Dim ts1, ts2, ts3, ts4 As Decimal
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
        tVgPrc.Text = CInt((ts1 + ts2 + ts3 + ts4) / Convert.ToDecimal(tbagi.Text)) '.ToString("00.00")
    End Sub

    Public varts1 As Integer
    Public varts2 As Integer
    Public varts3 As Integer
    Public varts4 As Integer
    Public varts5 As Integer


    Private Sub bntcekVal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntcekVal.Click
        Try
            test1()
            test2()
            test3()
            test4()
            test5()
        Catch ex As Exception

        End Try

        If varts1 <> 100 Then
            tval1.Text = varts1
        Else
            tval1.Text = "v"
        End If

        If varts2 <> 100 Then
            tval2.Text = varts2
        Else
            tval2.Text = "v"
        End If

        If varts3 <> 100 Then
            tval3.Text = varts3
        Else
            tval3.Text = "v"
        End If

        If varts4 <> 100 Then
            tval4.Text = varts4
        Else
            tval4.Text = "v"
        End If

        If varts5 <> 100 Then
            tval5.Text = varts5
        Else
            tval5.Text = "v"
        End If

    End Sub
    Private Sub test1()
        Dim ts1, ts2, ts3, ts5, ts4 As Decimal

        Try
            ts1 = Convert.ToDecimal(tNml1.Text)
        Catch
            ts1 = 0
        End Try
        Try
            ts2 = Convert.ToDecimal(tAbNml1.Text)
        Catch
            ts2 = 0
        End Try
        Try
            ts3 = Convert.ToDecimal(tHd1.Text)
        Catch
            ts3 = 0
        End Try
        Try
            ts4 = Convert.ToDecimal(tFrs1.Text)
        Catch
            ts4 = 0
        End Try
        Try
            ts5 = Convert.ToDecimal(tDd1.Text)
        Catch
            ts5 = 0
        End Try
        varts1 = ((ts1 + ts2 + ts3 + ts4 + ts5)).ToString
    End Sub
    Private Sub test2()
        Dim ts1, ts2, ts3, ts5, ts4 As Decimal

        Try
            ts1 = Convert.ToDecimal(tNml2.Text)
        Catch
            ts1 = 0
        End Try
        Try
            ts2 = Convert.ToDecimal(tAbNml2.Text)
        Catch
            ts2 = 0
        End Try
        Try
            ts3 = Convert.ToDecimal(tHd2.Text)
        Catch
            ts3 = 0
        End Try
        Try
            ts4 = Convert.ToDecimal(tFrs2.Text)
        Catch
            ts4 = 0
        End Try
        Try
            ts5 = Convert.ToDecimal(tDd2.Text)
        Catch
            ts5 = 0
        End Try
        varts2 = ((ts1 + ts2 + ts3 + ts4 + ts5)).ToString
    End Sub

    Private Sub test3()
        Dim ts1, ts2, ts3, ts5, ts4 As Decimal

        Try
            ts1 = Convert.ToDecimal(tNml3.Text)
        Catch
            ts1 = 0
        End Try
        Try
            ts2 = Convert.ToDecimal(tAbNml3.Text)
        Catch
            ts2 = 0
        End Try
        Try
            ts3 = Convert.ToDecimal(tHd3.Text)
        Catch
            ts3 = 0
        End Try
        Try
            ts4 = Convert.ToDecimal(tFrs3.Text)
        Catch
            ts4 = 0
        End Try
        Try
            ts5 = Convert.ToDecimal(tDd3.Text)
        Catch
            ts5 = 0
        End Try
        varts3 = ((ts1 + ts2 + ts3 + ts4 + ts5)).ToString
    End Sub
    Private Sub test4()
        Dim ts1, ts2, ts3, ts5, ts4 As Decimal

        Try
            ts1 = Convert.ToDecimal(tNml4.Text)
        Catch
            ts1 = 0
        End Try
        Try
            ts2 = Convert.ToDecimal(tAbNml4.Text)
        Catch
            ts2 = 0
        End Try
        Try
            ts3 = Convert.ToDecimal(tHd4.Text)
        Catch
            ts3 = 0
        End Try
        Try
            ts4 = Convert.ToDecimal(tFrs4.Text)
        Catch
            ts4 = 0
        End Try
        Try
            ts5 = Convert.ToDecimal(tDd4.Text)
        Catch
            ts5 = 0
        End Try
        varts4 = ((ts1 + ts2 + ts3 + ts4 + ts5)).ToString
    End Sub
    Private Sub test5()
        Dim ts1, ts2, ts3, ts5, ts4 As Decimal

        Try
            ts1 = Convert.ToDecimal(tNmlPrc.Text)
        Catch
            ts1 = 0
        End Try
        Try
            ts2 = Convert.ToDecimal(tAbNmlPrc.Text)
        Catch
            ts2 = 0
        End Try
        Try
            ts3 = Convert.ToDecimal(tHdPrc.Text)
        Catch
            ts3 = 0
        End Try
        Try
            ts4 = Convert.ToDecimal(tFrsPrc.Text)
        Catch
            ts4 = 0
        End Try
        Try
            ts5 = Convert.ToDecimal(tDdPrc.Text)
        Catch
            ts5 = 0
        End Try
        varts5 = ((ts1 + ts2 + ts3 + ts4 + ts5)).ToString
    End Sub

    Private Sub MetroTabControl1_Click(sender As Object, e As EventArgs) Handles MetroTabControl1.Click
        '' Gets the number of TabPage objects in the tabControl1 controls collection.  
        'Dim tabCount As Integer = MetroTabControl1.TabPages.Count
        'For tabIndex As Integer = 0 To tabCount - 1
        '    If MetroTabControl1.GetTabRect(tabIndex).Contains(e.Location) Then
        '        ...  ' clicked on tab with index tabIndex '
        '    End If
        'Next
    End Sub

    Sub bersih2()
        tabnormal.Text = ""

        tNml1.Text = ""
        tNml2.Text = ""
        tNml3.Text = ""
        tNml4.Text = ""

        tAbNml1.Text = ""
        tAbNml2.Text = ""
        tAbNml3.Text = ""
        tAbNml4.Text = ""

        tHd1.Text = ""
        tHd2.Text = ""
        tHd3.Text = ""
        tHd4.Text = ""

        tFrs1.Text = ""
        tFrs2.Text = ""
        tFrs3.Text = ""
        tFrs4.Text = ""

        tDd1.Text = ""
        tDd2.Text = ""
        tDd3.Text = ""
        tDd4.Text = ""

        tVg1.Text = ""
        tVg2.Text = ""
        tVg3.Text = ""
        tVg4.Text = ""

        tGm1.Text = ""
        tGm2.Text = ""
        tGm3.Text = ""
        tGm4.Text = ""

        Lreqnum.Text = "..."
        tlotid.Text = "..."
        tnomnl.Text = "..."
        tVariety.Text = "..."
        tscope.Text = "..."
    End Sub

    Private Sub tlabnum_GotFocus(sender As Object, e As EventArgs) Handles tlabnum.GotFocus
        tlabnum.SelectAll()
    End Sub

    Private Sub tGmPrc_NotifError(sender As Object, e As EventArgs) Handles tGmPrc.TextChanged, tGmArg.TextChanged
        tGmPrc.WithError = False
    End Sub
End Class