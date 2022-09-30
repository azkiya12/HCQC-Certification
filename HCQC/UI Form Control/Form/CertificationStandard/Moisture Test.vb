Imports MetroFramework.Forms
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Globalization

Public Class Moisture_Test
    Dim tglnow As Date = Today
    Public jenis As String
    Public no1 As String
    Dim tglinput As Date

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If String.IsNullOrEmpty(tlabnum.Text) Then
            MetroMessageBox.Show(Me, "Lab Number harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        ElseIf tlabnum.Text = "" Or tvariety.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Data harus lengkap!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
        ElseIf Lreqnum.Text <> _DataToValue("SELECT [id] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ") Then
            MetroMessageBox.Show(Me, "Pastikan No Lab " + tlabnum.Text + "sesuai dengan Identitas Sample", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, 211)
            Return
        Else
            If _isBOF("receipt", "labnum", tlabnum.Text) = True Then
                ''Identifikasi tombol Save atau Update
                If BtnSave.Text = "Save" Then
                    If _isBOF("[moisture]", "labnum", tlabnum.Text) = False Then
                        If _isBOF("[moisture_oven]", "labnum", tlabnum.Text) = False Then
                            Dim tgltest As Date
                            tgltest = Date.ParseExact(ttgltest.Text, formatDate, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None)
                            'Prosedur to INSERT moisture id
                            _RunSQL(" INSERT INTO [moisture] ([id_request]
                                    ,[id_login]
                                    ,[labnum]
                                    ,[ground]
                                    ,[prepare]
                                    ,[temp]
                                    ,[period]
                                    ,[equipment]
                                    ,[idbalance]
                                    ,[mois1]
                                    ,[mois2]
                                    ,[mean]
                                    ,[toleran]
                                    ,[testdate]
                                    ,[analys]
                                    ,[input_by]
                                    ,[input_at])                                   
                            VALUES ('" & Lreqnum.Text & "','" & login.Luserid.Text & "','" & tlabnum.Text & "', '" & tmethod.Text & "', '" & TPreparation.Text & "', '" & ttemp.Text & "', '" & tperiod.Text & "',
                                    '" & tequip.Text & "', '" & tbalanc.Text & "', " & Val(tmoi1.Text) & ", " & Val(tmoi2.Text) & ", " & Val(tmoimean.Text) & ", '" & ttoleran.CheckState & "',
                                    '" & tgltest.ToString("yyyy-MM-dd") & "', '" & tanalyst.Text & "', '" & GetIPAddress() & "', GETDATE() ) ")

                            ''Prosedur INSERT MOISTURE_OVEN value
                            If tmethod.Text = "Oven" Then
                                _RunSQL_nomsgbox("INSERT INTO [dbo].[moisture_oven]
                                        ([id_login]
                                        ,[id_request]
                                        ,[labnum]
                                        ,[repication]
                                        ,[container]
                                        ,[con_weight]
                                        ,[con_fill_weight]
                                        ,[dry_weight]
                                        ,[input_at])
                                    VALUES
                                        ('" & login.Luserid.Text & "'
                                        ,'" & Lreqnum.Text & "'
                                        ,'" & tlabnum.Text & "'
                                        ,1
                                        ,'" & Trim(TContIDRep1.Text) & "'
                                        ,'" & Trim(TContWgRep1.Text) & "'
                                        ,'" & Trim(TContWgFillRep1.Text) & "'
                                        ,'" & Trim(TWgDryRep1.Text) & "'
                                        ,GETDATE()),
                                        
                                        ('" & login.Luserid.Text & "'
                                        ,'" & Lreqnum.Text & "'
                                        ,'" & tlabnum.Text & "'
                                        ,2
                                        ,'" & Trim(TContIDRep2.Text) & "'
                                        ,'" & Trim(TContWgRep2.Text) & "'
                                        ,'" & Trim(TContWgFillRep2.Text) & "'
                                        ,'" & Trim(TWgDryRep2.Text) & "'
                                        ,GETDATE())")
                                LabelResult.Text = ""

                            End If
                            bersih2()
                            bersih2oven()
                        Else
                            MetroMessageBox.Show(Me, "Data sudah pernah di input petugas   MsLv2")
                        End If
                    Else
                        MetroMessageBox.Show(Me, "Data sudah pernah di input petugas   MsLv1")
                    End If
                ElseIf BtnSave.Text = "Update" Then
                    Dim result As Integer = MetroMessageBox.Show(Me, "Anda yakin untuk mengubah data ini?", "Informasi Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, 211)
                    If result = DialogResult.OK Then
                        BtnUpdate_Click(sender, e)
                    End If
                End If
            Else
                MetroMessageBox.Show(Me, "Lab Number belum pernah masuk di Sample Receipt")
            End If
            tlabnum.Focus()
        End If
    End Sub

    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click
        If String.IsNullOrEmpty(tlabnum.Text) Then
            MetroMessageBox.Show(Me, "Lab Number harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        Else
            Try
                openDB()
                Dim sql As String = "Select * From moisture WHERE (labnum= '" & tlabnum.Text & "') "
                cmd = New SqlClient.SqlCommand(sql, con) With {
                    .CommandType = CommandType.Text,
                    .CommandText = sql
                }
                dread = cmd.ExecuteReader
                If dread.Read = True Then
                    tmethod.Text = dread.Item("ground")
                    TPreparation.Text = dread.Item("prepare")
                    ttemp.Text = dread.Item("temp")
                    tperiod.Text = dread.Item("period")
                    tequip.Text = dread.Item("equipment")
                    tbalanc.Text = dread.Item("idbalance")
                    tmoi1.Text = dread.Item("mois1").ToString '("0,0")
                    tmoi2.Text = dread.Item("mois2").ToString '("0,0")
                    tmoimean.Text = dread.Item("mean").ToString '("0.0")
                    ttoleran.Checked = dread.Item("toleran")
                    tanalyst.Text = dread.Item("analys")
                    Dim tgltes As Date = dread.Item("testdate")
                    ttgltest.Text = tgltes.ToString(LabelDate1.Text)

                    ''mengambil data identitas sample dari sample_request
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
                    End If

                    ''mengambil data dari method jika OVEN
                    If tmethod.Text = "Oven" Then
                        ''Replication 1 in Oven Method
                        TContIDRep1.Text = _DataToValue("SELECT [container] FROM [moisture_oven] WHERE [repication]=1 AND labnum='" & tlabnum.Text & "'")
                        TContWgRep1.Text = _DataToValue("SELECT [con_weight] FROM [moisture_oven] WHERE [repication]=1 AND labnum='" & tlabnum.Text & "'")
                        TContWgFillRep1.Text = _DataToValue("SELECT [con_fill_weight] FROM [moisture_oven] WHERE [repication]=1 AND labnum='" & tlabnum.Text & "'")
                        TWgDryRep1.Text = _DataToValue("SELECT [dry_weight] FROM [moisture_oven] WHERE [repication]=1 AND labnum='" & tlabnum.Text & "'")

                        ''Replication 2 in Oven Method
                        TContIDRep2.Text = _DataToValue("SELECT [container] FROM [moisture_oven] WHERE [repication]=2 AND labnum='" & tlabnum.Text & "'")
                        TContWgRep2.Text = _DataToValue("SELECT [con_weight] FROM [moisture_oven] WHERE [repication]=2 AND labnum='" & tlabnum.Text & "'")
                        TContWgFillRep2.Text = _DataToValue("SELECT [con_fill_weight] FROM [moisture_oven] WHERE [repication]=2 AND labnum='" & tlabnum.Text & "'")
                        TWgDryRep2.Text = _DataToValue("SELECT [dry_weight] FROM [moisture_oven] WHERE [repication]=2 AND labnum='" & tlabnum.Text & "'")

                    End If
                    tlabnum.SelectAll()
                    BtnSave.Text = "Update"
                    BtnDel.Enabled = True
                Else
                    Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data tidak ditemukan!. Apakah anda ingin melanjutkan pencarian data?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                    If result = DialogResult.Yes Then
                        tlabnum.Focus()
                    ElseIf result = DialogResult.No Then
                        BtnSave.Text = "Save"
                        BtnDel.Enabled = False
                        tlabnum.SelectAll()
                    End If
                End If

            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, "Error " + ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs)
        If String.IsNullOrEmpty(tlabnum.Text) Then
            MetroMessageBox.Show(Me, "Lab Number harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        ElseIf String.IsNullOrEmpty(tvariety.Text) Or tvariety.Text = "..." Then
            MetroMessageBox.Show(Me, "Pastikan identitas sample sudah benar!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            Return
        Else
            Dim tgltest As Date
            tgltest = Date.ParseExact(ttgltest.Text, formatDate, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None)
            _RunSQL(" UPDATE [moisture] SET [ground]='" & tmethod.Text & "'
                                    ,[prepare]='" & TPreparation.Text & "'
                                    ,[temp]='" & ttemp.Text & "'
                                    ,[period]='" & tperiod.Text & "'
                                    ,[equipment]='" & tequip.Text & "'
                                    ,[idbalance]='" & tbalanc.Text & "'
                                    ,[mois1]='" & Val(tmoi1.Text) & "'
                                    ,[mois2]='" & Val(tmoi2.Text) & "'
                                    ,[mean]='" & Val(tmoimean.Text) & "'
                                    ,[toleran]='" & ttoleran.CheckState & "'
                                    ,[testdate]='" & tgltest.ToString("yyyy-MM-dd") & "'
                                    ,[analys]='" & tanalyst.Text & "'
                                    ,[update_by]='" & login.Luserid.Text & "'
                                    ,[update_at]= GETDATE()
                                    ,[id_login]='" & login.Luserid.Text & "'
                                    WHERE ([labnum]='" & tlabnum.Text & "')
                  ")


            If tmethod.Text = "Oven" Then
                ''memastikan data ada atau tidak
                If _isBOF("[moisture_oven]", "[labnum]", tlabnum.Text) = True Then
                    For strvalue As Integer = 1 To 2
                        If strvalue = 1 Then
                            _RunSQL_nomsgbox("UPDATE [moisture_oven] 
                                             SET [id_login] = '" & login.Luserid.Text & "'
                                                ,[id_request] = '" & Lreqnum.Text & "'                                                
                                                ,[container] = '" & Trim(TContIDRep1.Text) & "'
                                                ,[con_weight] = '" & Trim(TContWgRep1.Text) & "'
                                                ,[con_fill_weight] = '" & Trim(TContWgFillRep1.Text) & "'
                                                ,[dry_weight] = '" & Trim(TWgDryRep1.Text) & "'
                                                ,[input_at] = GETDATE()
                                            WHERE [labnum] = '" & tlabnum.Text & "' and [repication] = 1")
                        ElseIf strvalue = 2 Then
                            _RunSQL_nomsgbox("UPDATE [moisture_oven] 
                                             SET [id_login] = '" & login.Luserid.Text & "'
                                                ,[id_request] = '" & Lreqnum.Text & "'                                                
                                                ,[container] = '" & Trim(TContIDRep2.Text) & "'
                                                ,[con_weight] = '" & Trim(TContWgRep2.Text) & "'
                                                ,[con_fill_weight] = '" & Trim(TContWgFillRep2.Text) & "'
                                                ,[dry_weight] = '" & Trim(TWgDryRep2.Text) & "'
                                                ,[input_at] = GETDATE()
                                            WHERE [labnum] = '" & tlabnum.Text & "' and [repication] = 2")
                        End If
                    Next
                Else
                    _RunSQL_nomsgbox("INSERT INTO [dbo].[moisture_oven]
                                        ([id_login]
                                        ,[id_request]
                                        ,[labnum]
                                        ,[repication]
                                        ,[container]
                                        ,[con_weight]
                                        ,[con_fill_weight]
                                        ,[dry_weight]
                                        ,[input_at])
                                    VALUES
                                        ('" & login.Luserid.Text & "'
                                        ,'" & Lreqnum.Text & "'
                                        ,'" & tlabnum.Text & "'
                                        ,1
                                        ,'" & Trim(TContIDRep1.Text) & "'
                                        ,'" & Trim(TContWgRep1.Text) & "'
                                        ,'" & Trim(TContWgFillRep1.Text) & "'
                                        ,'" & Trim(TWgDryRep1.Text) & "'
                                        ,GETDATE()),
                                        
                                        ('" & login.Luserid.Text & "'
                                        ,'" & Lreqnum.Text & "'
                                        ,'" & tlabnum.Text & "'
                                        ,2
                                        ,'" & Trim(TContIDRep2.Text) & "'
                                        ,'" & Trim(TContWgRep2.Text) & "'
                                        ,'" & Trim(TContWgFillRep2.Text) & "'
                                        ,'" & Trim(TWgDryRep2.Text) & "'
                                        ,GETDATE())")
                End If

            ElseIf tmethod.Text = "Moisture Meter" Then
                ''JIKA methode di ubah menjadi alat maka data di table moisture oven harus di hapus
                If _isBOF("[moisture_oven]", "[labnum]", tlabnum.Text) = True Then
                    _RunSQL_nomsgbox("DELETE [moisture_oven] WHERE [labnum]= '" & tlabnum.Text & "'")
                End If
                bersih2oven()
            End If
            BtnSave.Text = "Save"
            bersih2()
            bersih2oven()
            tlabnum.Focus()
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
            If _isBOF("moisture", "labnum", tlabnum.Text) = True Then
                Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Apakah anda yakin untuk menghapus data ini " + tlabnum.Text, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
                If result = DialogResult.Yes Then
                    _RunSQL("DELETE [moisture] WHERE ([labnum]= '" & tlabnum.Text & "') AND id_request=" & Lreqnum.Text & " ")
                    _RunSQL_nomsgbox("DELETE [moisture_oven] WHERE [labnum]= '" & tlabnum.Text & "'")
                    bersih2()
                    bersih2oven()
                    Me.tlabnum.Focus()
                    'Bersihkan()
                ElseIf result = DialogResult.No Then
                    BtnSave.Text = "Save"
                    BtnDel.Enabled = False
                    Me.tlabnum.Focus()
                    Me.tlabnum.SelectAll()
                End If
            Else
                MetroMessageBox.Show(Me, "Data dengan Nomor Lab tersebut tidak ada")
            End If
        End If
    End Sub

    Private Sub tmoi1_GotFocus(sender As Object, e As EventArgs) Handles tmoi1.GotFocus
        tmoi1.SelectAll()
    End Sub

    Private Sub tmoi2_GotFocus(sender As Object, e As EventArgs) Handles tmoi2.GotFocus
        tmoi2.SelectAll()
    End Sub

    Private Sub tlabnum_KeyDown(sender As Object, e As KeyEventArgs) Handles tlabnum.KeyDown

        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrEmpty(tlabnum.Text) Then
                MetroMessageBox.Show(Me, "Lab Number harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                Return
            Else

                If _isBOF("moisture", "labnum", tlabnum.Text) = False Then

                    If _isBOF("receipt", "labnum", tlabnum.Text) = True Then
                        Lreqnum.Text = _DataToValue("SELECT [id] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                        tvariety.Text = _DataToValue("SELECT [variety] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                        tlotref.Text = _DataToValue("SELECT [nojob] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                        tnoman.Text = _DataToValue("SELECT [nomnl] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                        tscope.Text = _DataToValue("SELECT [scope] FROM [qc_confirm_view] WHERE (labnum= '" & tlabnum.Text & "') ")
                        tanalyst.Text = _DataToValue("SELECT [moisture_namelog] FROM [report_status_pengujian] WHERE [labnum] = '" & tlabnum.Text & "'")
                        Dim tgluji As Date = _DataToValue("SELECT [moisture_log] FROM [report_status_pengujian] WHERE [labnum]='" & tlabnum.Text & "'")
                        ttgltest.Text = tgluji.ToString(LabelDate1.Text)
                        tlabnum.SelectAll()
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, "Data " & tlabnum.Text & " belum masuk QC Receipt Sample", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                        tlabnum.Focus()
                    End If
                Else
                    Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Data Moisture lab number " & tlabnum.Text & " sudah pernah di input!. Click 'Yes' untuk menampilkan data atau Click 'No' untuk input data baru", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 211)
                    If result = DialogResult.Yes Then
                        BtnFind_Click(sender, e)
                    ElseIf result = DialogResult.No Then
                        LabelResult.Text = ""
                        LabelDevide.Text = ""
                        BtnSave.Text = "Save"
                        BtnDel.Enabled = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Moisture_Load(sender As Object, e As EventArgs) Handles Me.Load
        BtnDel.Enabled = False
        LabelResult.Text = ""
        LabelDevide.Text = ""
        'LabelDate1.Text = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern
    End Sub

    Private Sub BtnSave_GotFocus(sender As Object, e As EventArgs) Handles BtnSave.GotFocus
        If BtnSave.Enabled = True Then
            BtnSave.BorderRadius = 5
            BtnSave.Normalcolor = Color.FromArgb(0, 153, 255)
        End If
    End Sub

    Private Sub BtnDel_GotFocus(sender As Object, e As EventArgs) Handles BtnDel.GotFocus
        If BtnDel.Enabled = True Then
            BtnDel.BorderRadius = 5
            BtnDel.Normalcolor = Color.FromArgb(0, 153, 255)
        End If
    End Sub

    Private Sub BtnSave_LostFocus(sender As Object, e As EventArgs) Handles BtnSave.LostFocus
        If BtnSave.Enabled = True Then
            BtnSave.BorderRadius = 0
            BtnSave.Normalcolor = Color.FromArgb(0, 122, 204)
        End If
    End Sub

    Private Sub BtnDelete_LostFocus(sender As Object, e As EventArgs) Handles BtnDel.LostFocus
        If BtnDel.Enabled = True Then
            BtnDel.BorderRadius = 0
            BtnDel.Normalcolor = Color.FromArgb(0, 122, 204)
        End If
    End Sub

    Private Sub TextOvenCalculation1_TextChanged(sender As Object, e As EventArgs) Handles TContWgRep1.TextChanged, TContWgFillRep1.TextChanged, TWgDryRep1.TextChanged
        Dim str1M1, str1M2, str1M3, result As Double
        str1M1 = Val(TContWgRep1.Text)
        str1M2 = Val(TContWgFillRep1.Text)
        str1M3 = Val(TWgDryRep1.Text)

        ''pastikan function ini untuk Method OVEN
        ''
        If tmethod.Text = "Oven" Then
            Try
                result = (str1M2 - str1M3) / (str1M2 - str1M1) * 100
                tmoi1.Text = Math.Round(result, 3)
            Catch ex As Exception
                MetroMessageBox.Show(Me, "Attempted to divide by zero")
            End Try
        End If

    End Sub

    Private Sub TextOvenCalculation2_TextChanged(sender As Object, e As EventArgs) Handles TContWgRep2.TextChanged, TContWgFillRep2.TextChanged, TWgDryRep2.TextChanged
        Dim str2m1, str2M2, str2M3, result As Double
        str2m1 = Val(TContWgRep2.Text)
        str2M2 = Val(TContWgFillRep2.Text)
        str2M3 = Val(TWgDryRep2.Text)

        ''pastikan function ini untuk Method OVEN
        ''
        If tmethod.Text = "Oven" Then
            Try
                result = (str2M2 - str2M3) / (str2M2 - str2m1) * 100
                tmoi2.Text = Math.Round(result, 3).ToString
            Catch ex As Exception
                MetroMessageBox.Show(Me, "Attempted to divide by zero")
            End Try
        End If
    End Sub

    Private Sub Tmoimean_TextChanege(sender As Object, e As EventArgs) Handles tmoi1.TextChanged, tmoi2.TextChanged
        Dim mt1, mt2 As Decimal
        Try
            mt1 = Convert.ToDecimal(tmoi1.Text)
        Catch
            mt1 = 0
        End Try
        Try
            mt2 = Convert.ToDecimal(tmoi2.Text)
        Catch
            mt2 = 0
        End Try
        tmoimean.Text = ((mt1 + mt2) / 2).ToString("0.0")

        If Math.Abs(mt1 - mt2) > 0.2 Then
            ttoleran.CheckState = CheckState.Unchecked
            LabelResult.Text = "No"
            LabelDevide.Text = Math.Abs(mt1 - mt2)
        Else
            ttoleran.CheckState = CheckState.Checked
            LabelResult.Text = "Yes"
            LabelDevide.Text = Math.Abs(mt1 - mt2)
        End If
    End Sub

    Private Sub tmethod_SelectedValueChanged(sender As Object, e As EventArgs) Handles tmethod.SelectedValueChanged
        If tmethod.Text = "Oven" Then
            'ttemp.Text = ""
            ttemp.PromptText = "Pilih..."
            ttemp.Enabled = True

            'tperiod.Text = ""
            tperiod.PromptText = "Pilih..."
            tperiod.Enabled = True

            'TPreparation.Text = ""
            TPreparation.PromptText = "Pilih..."
            TPreparation.Enabled = True

            TContIDRep1.Text = ""
            TContWgRep1.Text = ""
            TContWgFillRep1.Text = ""
            TWgDryRep1.Text = ""

            TContIDRep1.Enabled = True
            TContWgRep1.Enabled = True
            TContWgFillRep1.Enabled = True
            TWgDryRep1.Enabled = True

            TContIDRep2.Text = ""
            TContWgRep2.Text = ""
            TContWgFillRep2.Text = ""
            TWgDryRep2.Text = ""

            TContIDRep2.Enabled = True
            TContWgRep2.Enabled = True
            TContWgFillRep2.Enabled = True
            TWgDryRep2.Enabled = True

            tmoi1.Text = ""
            tmoi2.Text = ""
        ElseIf tmethod.Text = "Moisture Meter" Then

            ttemp.SelectedIndex = -1
            ttemp.PromptText = ""
            ttemp.Enabled = False

            tperiod.SelectedIndex = -1
            tperiod.PromptText = ""
            tperiod.Enabled = False

            TPreparation.SelectedIndex = -1
            TPreparation.PromptText = ""
            TPreparation.Enabled = False

            TContIDRep1.Text = "na"
            TContWgRep1.Text = "na"
            TContWgFillRep1.Text = "na"
            TWgDryRep1.Text = "na"

            TContIDRep1.Enabled = False
            TContWgRep1.Enabled = False
            TContWgFillRep1.Enabled = False
            TWgDryRep1.Enabled = False

            TContIDRep2.Text = "na"
            TContWgRep2.Text = "na"
            TContWgFillRep2.Text = "na"
            TWgDryRep2.Text = "na"

            TContIDRep2.Enabled = False
            TContWgRep2.Enabled = False
            TContWgFillRep2.Enabled = False
            TWgDryRep2.Enabled = False

            tmoi1.Text = ""
            tmoi2.Text = ""
        End If
    End Sub

    Sub bersih2()
        tlabnum.Text = ""
        tmethod.Text = ""
        TPreparation.Text = ""
        ttemp.Text = ""
        tperiod.Text = ""
        tequip.Text = "HCQC"
        tbalanc.Text = "HCQC"

        tmoi1.Text = ""
        tmoi2.Text = ""
        tmoimean.Text = ""

        ttoleran.Checked = False
        'tanalyst.Text = ""
        LabelResult.Text = ""
        LabelDevide.Text = ""

    End Sub
    Sub bersih2oven()
        ''Replication 1 in Oven Method
        TContIDRep1.Text = ""
        TContWgRep1.Text = ""
        TContWgFillRep1.Text = ""
        TWgDryRep1.Text = ""

        ''Replication 2 in Oven Method
        TContIDRep2.Text = ""
        TContWgRep2.Text = ""
        TContWgFillRep2.Text = ""
        TWgDryRep2.Text = ""
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) 
        If _isBOF("moisture_oven", "labnum", Lreqnum.Text) = False Then
            If tmethod.Text = "Oven" Then
                _RunSQL_nomsgbox("INSERT INTO [dbo].[moisture_oven]
                                        ([id_login]
                                        ,[id_request]
                                        ,[labnum]
                                        ,[repication]
                                        ,[container]
                                        ,[con_weight]
                                        ,[con_fill_weight]
                                        ,[dry_weight]
                                        ,[input_at])
                                    VALUES
                                        ('" & login.Luserid.Text & "'
                                        ,'" & Lreqnum.Text & "'
                                        ,'" & tlabnum.Text & "'
                                        ,1
                                        ,'" & Trim(TContIDRep1.Text) & "'
                                        ,'" & Trim(TContWgRep1.Text) & "'
                                        ,'" & Trim(TContWgFillRep1.Text) & "'
                                        ,'" & Trim(TWgDryRep1.Text) & "'
                                        ,GETDATE()),
                                        
                                        ('" & login.Luserid.Text & "'
                                        ,'" & Lreqnum.Text & "'
                                        ,'" & tlabnum.Text & "'
                                        ,2
                                        ,'" & Trim(TContIDRep2.Text) & "'
                                        ,'" & Trim(TContWgRep2.Text) & "'
                                        ,'" & Trim(TContWgFillRep2.Text) & "'
                                        ,'" & Trim(TWgDryRep2.Text) & "'
                                        ,GETDATE())")
                LabelResult.Text = ""
                bersih2()
                bersih2oven()
            End If
        Else
            MsgBox("data sudah ada")
        End If

    End Sub

    Private Sub BtnSave_KeyDown(sender As Object, e As KeyEventArgs) Handles BtnSave.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Space Then
            BtnSave_Click(sender, e)
        End If
    End Sub

End Class
