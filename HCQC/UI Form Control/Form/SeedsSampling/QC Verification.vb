Imports System.Data
Imports System.Data.SqlClient
Imports DgvFilterPopup
Imports System.Reflection
Public Class QC_Verification
    Friend Event SaveLabnumber(ByVal strData As String)
    ReadOnly tglnow As Date = Today


    Private Sub QC_Verification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCQC_NewDataset.qc_confirm_view' table. You can move, or remove it, as needed.
        Me.Qc_confirm_viewerTableAdapter.FillByOnProcess(Me.HCQC_NewDataset.qc_confirm_viewer)

        ''METROGRID1 popup filter on Header
        Dim DgvFilter As New DgvFilterManager
        DgvFilter.DataGridView = MetroGrid1
        MetroGrid1.ColumnHeadersHeight = 25

        ''you can turn on double buffering.
        'Dim systemType As Type = Me.GetType()
        'Dim propertyInfo As PropertyInfo = systemType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        'propertyInfo.SetValue(Me, True, Nothing)
    End Sub

    Private Sub MetroGrid1_ApprovedContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick
        If e.RowIndex = -1 OrElse MetroGrid1.Columns(e.ColumnIndex).Name <> "AcceptedColumn" Then Return

        ''Procedure to Approved Sample Request
        Dim row As DataGridViewRow = MetroGrid1.Rows(e.RowIndex)
        If MetroGrid1.Columns(e.ColumnIndex).Name = "AcceptedColumn" Then
            If row.Cells("status_confirmColumn").Value <> "Accepted" Then
                Dim strlab As String
                strlab = AutoNumber()

                Using cmd As New SqlCommand("sp_QcConfirm", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@Id_request", row.Cells("idColumn").Value)
                    cmd.Parameters.Add("@Id_login", SqlDbType.Int).Value = login.Luserid.Text
                    cmd.Parameters.Add("@Tgl_confirm", SqlDbType.DateTime).Value = Now
                    cmd.Parameters.Add("@Status", SqlDbType.Bit).Value = 1
                    cmd.Parameters.Add("@Labnum", SqlDbType.VarChar).Value = strlab
                    cmd.Parameters.Add("@StatusConf", SqlDbType.Int).Value = 1
                    cmd.Parameters.Add("@remark", SqlDbType.VarChar).Value = ""

                    con.Open()
                    cmd.ExecuteScalar()
                    con.Close()
                End Using
                MetroGrid1.Rows.RemoveAt(e.RowIndex)

                'notification neet to verification
                MainForm.LabelNotifVerivicaion.Text = MainForm.LabelNotifVerivicaion.Text - 1
                MainForm.Containermenu2.LabelNotifContainerTracing.Text = MainForm.Containermenu2.LabelNotifContainerTracing.Text - 1

            Else
                MetroMessageBox.Show(Me, "This sample has been Approved")
            End If
        End If

    End Sub

    Private Sub MetroGrid1_RejectedContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick
        If e.RowIndex = -1 OrElse MetroGrid1.Columns(e.ColumnIndex).Name <> "RejectedColumn" Then Return

        ''Procedure to Rejected Sample Request
        Dim row As DataGridViewRow = MetroGrid1.Rows(e.RowIndex)
        If MetroGrid1.Columns(e.ColumnIndex).Name = "RejectedColumn" Then
            If _isBOF("receipt", "labnum", row.Cells("labnum").Value.ToString) = False Then
                ''menampilkan form dialog remark
                RaiseEvent SaveLabnumber(row.Cells("idColumn").Value)
                Dim RejectedDialog = New Rejected_Remark
                RejectedDialog.Lreqnum.Text = row.Cells("idColumn").Value
                RejectedDialog.Lvariety.Text = row.Cells("VarietyColumn").Value
                RejectedDialog.Lfarmer.Text = row.Cells("FarmerColumn").Value
                RejectedDialog.Ljob.Text = row.Cells("NomnlColumn").Value + "/" + row.Cells("NojobColumn").Value
                RejectedDialog.Lharvest.Text = row.Cells("HarvestColumn").Value
                RejectedDialog.LLocation.Text = row.Cells("LocationColumn").Value
                RejectedDialog.TRemarkReject.Text = row.Cells("InformationrejectedColumn").Value.ToString
                RejectedDialog.LabelLabNumber.Text = row.Cells("labnum").Value.ToString
                Dim strstatus As String = _DataToValue("SELECT [status_confirm] FROM [qc_confirm] WHERE [id_request]=" & row.Cells("idColumn").Value & "").ToString
                If Not IsDBNull(MetroGrid1.Rows(e.RowIndex).Cells.Item("TglconfirmColumn").Value) AndAlso strstatus = 2 Then
                    RejectedDialog.BtnSave2.Text = "Update"
                Else
                    RejectedDialog.BtnSave2.Text = "Save"
                End If

                If RejectedDialog.ShowDialog(Me) = DialogResult.OK Then
                    MetroGrid1.Rows.RemoveAt(e.RowIndex)
                    RejectedDialog.Close()
                    'notification neet to verification
                    MainForm.LabelNotifVerivicaion.Text = MainForm.LabelNotifVerivicaion.Text - 1
                    MainForm.Containermenu2.LabelNotifContainerTracing.Text = MainForm.Containermenu2.LabelNotifContainerTracing.Text - 1

                    'MainForm.LabelNotifVerivicaion.Text = VerificationCount(MainForm.PanelNotifVerification)
                    'MainForm.Containermenu2.LabelNotifContainerTracing.Text = VerificationCount(MainForm.Containermenu2.Panel2)
                End If
            Else
                MetroMessageBox.Show(Me, "Nomor Lab ini sudah di Terima QC Laboatorium")
            End If
        End If

    End Sub

    Private Sub MetroGrid1_DelCellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick
        If e.RowIndex = -1 OrElse MetroGrid1.Columns(e.ColumnIndex).Name <> "BtnDel" Then Return
        'If e.ColumnIndex = 14 Then
        Dim row As DataGridViewRow = MetroGrid1.Rows(e.RowIndex)
            If MetroGrid1.Columns(e.ColumnIndex).Name = "BtnDel" Then
            If Not IsDBNull(MetroGrid1.Rows(e.RowIndex).Cells.Item("TglconfirmColumn").Value) Then
                If _isBOF("[receipt]", "[id_request]", MetroGrid1.Rows(e.RowIndex).Cells.Item("IdColumn").Value) = False Then
                    Using cmd As New SqlCommand("sp_QcConfirmDel", con)
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.AddWithValue("@Id_request", row.Cells("IdColumn").Value)
                        cmd.Parameters.AddWithValue("@Tgl_confirm", row.Cells("TglconfirmColumn").Value)
                        cmd.Parameters.Add("@Status", SqlDbType.Bit).Value = 1
                        con.Open()
                        cmd.ExecuteScalar()
                        con.Close()
                    End Using
                    Me.Qc_confirm_viewerTableAdapter.FillByOnProcess(Me.HCQC_NewDataset.qc_confirm_viewer)

                    'notification neet to verification
                    MainForm.LabelNotifVerivicaion.Text = VerificationCount(MainForm.PanelNotifVerification)
                    MainForm.Containermenu2.LabelNotifContainerTracing.Text = VerificationCount(MainForm.Containermenu2.Panel2)

                    Return
                Else
                    MetroMessageBox.Show(Me, "Sample ini sudah masuk dalam proses Quality Control")
                End If
            End If

        End If
        'End If
    End Sub

    'Fungsi untuk mengubah ButtonCellColumn ke TextCellColumn
    Sub ButtonCelltoTextCell()
        For i As Integer = 0 To MetroGrid1.Rows.Count() - 1 Step +1
            If Not IsDBNull(MetroGrid1.Rows(i).Cells("NamaconDataGridViewTextBoxColumn").Value) Then
                'jika data sudah di isi/ada
                'Replace the ButtonCell for a TextCell'
                Dim cell As New DataGridViewButtonCell
                ''Set the value again'
                cell.FlatStyle = FlatStyle.Flat
                cell.UseColumnTextForButtonValue = True
                cell.Value = "Checked"
                ''Override the cell'
                MetroGrid1.Rows(i).Cells("BtnCheck") = cell
                'Me.MetroGrid1.Rows(i).Cells("BtnCheck").Value = "Checked"
            ElseIf IsDBNull(MetroGrid1.Rows(i).Cells("NamaconDataGridViewTextBoxColumn").Value) Then
                'jika data kosong
                ''Replace the ButtonDel for a TextCell
                Dim cell As New DataGridViewButtonCell
                ''Set the value again'
                cell.FlatStyle = FlatStyle.Flat
                cell.UseColumnTextForButtonValue = True
                cell.Value = "Check"
                Me.MetroGrid1.Rows(i).Cells("BtnCheck") = cell
            End If
        Next
    End Sub

    Public Function AutoNumber()
        'Try
        openDB()
        Dim sql As String = ""
        Dim strTam As String = ""
        Dim strVal As String = ""
        Dim no1, StrLabnum As String

        no1 = "QC" & Year(Today) & Date.Today.ToString("MM")
        sql = "SELECT labnum FROM qc_confirm WHERE labnum LIKE '" & no1 & "%' ORDER BY labnum DESC"
        cmd = New SqlCommand(sql, con)
        dread = cmd.ExecuteReader
        If dread.Read() Then
            strTam = Microsoft.VisualBasic.Right(dread.Item("labnum"), 4)
        Else
            StrLabnum = "QC" & Year(Today) & Date.Today.ToString("MM") & "0001"
        End If
        strVal = Val(strTam) + 1
        StrLabnum = "QC" & Year(Today) & Date.Today.ToString("MM") & Mid("000", 1, 4 - strVal.Length) & strVal
        con.Close()
        Return StrLabnum
        'Catch ex As Exception
        '    MsgBox("Terjadi Error : " & ex.Message)
        'Finally

        'End Try

    End Function

    Private Sub MetroGrid1_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles MetroGrid1.RowPostPaint
        'ButtonCelltoTextCell()

        ''penomoran pada MetroGrid1 view
        MetroGrid1 = DirectCast(sender, DataGridView)
        Dim rowNumber As String = (e.RowIndex + 1).ToString()
        While rowNumber.Length <MetroGrid1.RowCount.ToString().Length
            rowNumber = "0" & rowNumber
        End While

        Dim size As SizeF = e.Graphics.MeasureString(rowNumber, Me.Font)
        If MetroGrid1.RowHeadersWidth < CInt(size.Width + 20) Then
            MetroGrid1.RowHeadersWidth = CInt(size.Width + 20)
        End If

        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(rowNumber, MetroGrid1.Font, b, e.RowBounds.Location.X + 15,
        e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
        ''-----------------------------------------------------------------------------------------

    End Sub

    Private Sub MetroGrid1_RowValidated(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.RowValidated
        'ButtonCelltoTextCell()
    End Sub

    Private Sub MetroGrid1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles MetroGrid1.CellFormatting

    End Sub

    Private Sub LinkOnProcess_Click(sender As Object, e As EventArgs) Handles LinkOnProcess.Click
        Me.Qc_confirm_viewerTableAdapter.FillByOnProcess(Me.HCQC_NewDataset.qc_confirm_viewer)
    End Sub

    Private Sub LinkAccepted_Click(sender As Object, e As EventArgs) Handles LinkAccepted.Click
        Me.Qc_confirm_viewerTableAdapter.FillByAccepted(Me.HCQC_NewDataset.qc_confirm_viewer)
    End Sub

    Private Sub LinkAll_Click(sender As Object, e As EventArgs) Handles LinkAll.Click
        Me.Qc_confirm_viewerTableAdapter.Fill(Me.HCQC_NewDataset.qc_confirm_viewer)
    End Sub

    Private Sub LinkRejected_Click(sender As Object, e As EventArgs) Handles LinkRejected.Click
        Me.Qc_confirm_viewerTableAdapter.FillByRejected(Me.HCQC_NewDataset.qc_confirm_viewer)
    End Sub

    Private Sub Tsearch_ButtonClick(sender As Object, e As EventArgs) Handles Tsearch.ButtonClick
        If String.IsNullOrEmpty(Tsearch.Text) Then
            LinkOnProcess_Click(sender, e)
        Else
            Me.Qc_confirm_viewerTableAdapter.FillByVariable(Me.HCQC_NewDataset.qc_confirm_viewer, "%" + Trim(Tsearch.Text) + "%")
        End If
    End Sub

    Private Sub Tsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles Tsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Tsearch_ButtonClick(sender, e)
        End If
    End Sub
End Class
