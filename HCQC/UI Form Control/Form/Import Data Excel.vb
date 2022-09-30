Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.Data
Imports System.Text
Imports Utilities.BunifuButton.Transitions
Imports Microsoft.SqlServer
Imports System.Net
Imports System.Text.RegularExpressions

Public Class Import_Data_Excel
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        MetroGrid1.Columns.Clear()
        If Not String.IsNullOrEmpty(MetroTextBox1.Text) Then
            Dim MyConnection As OleDb.OleDbConnection
            Dim DtSet As DataSet
            Dim MyCommand As OleDb.OleDbDataAdapter
            MyConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & MetroTextBox1.Text & ";Extended Properties=""Excel 12.0;IMEX=1""")
            MyCommand = New OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection)
            DtSet = New DataSet
            MyCommand.Fill(DtSet, "[Sheet1$]")
            MetroGrid1.DataSource = DtSet
            MetroGrid1.DataMember = "[Sheet1$]"
            MyConnection.Close()
        Else
            MetroMessageBox.Show(Form.ActiveForm, "Please Select file fist...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
        End If

        If MetroGrid1.Rows.Count <= 0 Then
            BtnUpload.Enabled = False
        Else
            BtnUpload.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If Not String.IsNullOrEmpty(MetroTextBox1.Text) Then
            ReadCSVGoogle(MetroTextBox1.Text)
        Else
            MetroMessageBox.Show(Form.ActiveForm, "Please 'Click to Browse...' and Select file first...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
        End If

    End Sub

    Private Sub ReadCSVGoogle(strPart As String)
        MetroGrid1.Columns.Clear()
        ' Load data from SAS and Write to text strPart
        If Check_DireckLoad.Checked Then
            Dim webAddress As String
            webAddress = "http://10.15.13.2/cgi-bin/rwcgi60.exe?bisicsv+report=/production/weekly_harvest_planning_csv.rdf+P_HARVEST_DATE_FROM=" &
                          DateFrom.Value.ToString("dd-MM-yyyy") & "+P_HARVEST_DATE_UNTIL=" & DateTo.Value.ToString("dd-MM-yyyy") &
                          "+P_CROP_NAME=+P_PARENTAREA=+P_AREA=+P_ITEM_CODE=+P_LOCATION=+P_STAFF=+P_USERNAME=trinur"
            Dim request As WebRequest = WebRequest.Create(webAddress)
            Using response As WebResponse = request.GetResponse()
                Using reader As New StreamReader(response.GetResponseStream())
                    Dim html As String = reader.ReadToEnd()
                    File.WriteAllText(strPart, html)
                    Console.WriteLine(html)
                End Using
            End Using
        End If

        'create column table
        Dim dt As New DataTable
        Dim names = {"HarvestColumn", "AreaColumn", "Variety", "Staff", "Location", "Column1", "Column2", "Column3", "PlantDate", "AreaHa", "Qty", "NoKontrak", "NoRencanaPanen", "BlockNo", "CGRNo", "CGRName", "NoLot"}
        Dim headers = {"Harvest Date", "Area", "Variety", "Staff", "Location", "Column1", "Column2", "Column3", "Plant Date", "Area Ha", "Qty kg", "NoKontrak", "NoRencanaPanen", "BlockNo", "CGRNo", "CGRName", "NoLot"}
        Dim i As Integer = 0

        ' Add Columns to DataTable
        Try
            For index = 0 To 16 'How many do you want?
                Dim column As New DataColumn()
                With column
                    .Caption = headers(i)
                    .ColumnName = names(i)
                    .DataType = Type.GetType("System.String")
                    ' Use the Text property for the button text for all cells rather
                    ' than using each cell's value as the text for its own button.
                End With
                dt.Columns.Add(column)
                i = i + 1
            Next
        Catch ex As Exception
            MessageBox.Show("DataTable " & ex.Message)
        End Try

        i = 0
        'Add Columns to DataGridView
        Try
            For index = 0 To 16 'How many do you want?
                Dim column As New DataGridViewTextBoxColumn
                With column
                    .HeaderText = headers(i)
                    .Name = names(i)
                    ' Use the Text property for the button text for all cells rather
                    ' than using each cell's value as the text for its own button.
                End With
                MetroGrid1.Columns.Insert(index, column)
                i = i + 1
            Next
        Catch ex As Exception
            MessageBox.Show("DataGridView " & ex.Message)
        End Try

        Dim fName As String = strPart
        Dim TextLine As String
        Dim SplitLine() As String
        Try
            If File.Exists(fName) = True Then
                Using objReader As New System.IO.StreamReader(fName, Encoding.ASCII)
                    Dim counter As Integer = 0
                    Do While objReader.Peek() <> -1
                        'Baca isi dari file
                        TextLine = objReader.ReadLine().Replace("Dariyono, A.Md", "Dariyono A.Md")
                        'identifikasi pembatas antar column
                        SplitLine = Split(TextLine, ",")
                        If Not TextLine.Contains("SC-") Then ''OrElse Not TextLine.Contains("SC-") --add multiple containt
                            If counter > 0 Then
                                ''Proses Insert ke DataTable
                                dt.Rows.Add(CDate(SplitLine(0)).ToString("dd-MMM-yyyy"),
                                                        SplitLine(1),
                                                        SplitLine(2),
                                                       SplitLine(3),
                                                        SplitLine(4),
                                                        SplitLine(5),
                                                        SplitLine(6),
                                                        SplitLine(7),
                                                        SplitLine(8),
                                                        CDec(SplitLine(9)),
                                                        CDec(SplitLine(10)),
                                                        SplitLine(11),
                                                        SplitLine(12),
                                                        SplitLine(13),
                                                        SplitLine(14),
                                                        SplitLine(15), "")

                                ''Proses Insert ke table Gridview
                                Me.MetroGrid1.Rows.Add(CDate(SplitLine(0)).ToString("dd-MMM-yyyy"),
                                                        SplitLine(1),
                                                        SplitLine(2),
                                                       SplitLine(3),
                                                        SplitLine(4),
                                                        SplitLine(5),
                                                        SplitLine(6),
                                                        SplitLine(7),
                                                        SplitLine(8),
                                                        CDec(SplitLine(9)),
                                                        CDec(SplitLine(10)),
                                                        SplitLine(11),
                                                        SplitLine(12),
                                                        SplitLine(13),
                                                        SplitLine(14),
                                                        SplitLine(15), "")
                            End If
                            counter += 1
                        End If
                    Loop
                End Using
            Else
                MsgBox("File Does Not Exist")
            End If
        Catch ex As Exception
            MessageBox.Show("Proses insert row" & ex.Message)
        End Try


        If MetroGrid1.Rows.Count <= 0 Then
            BtnUpload.Enabled = False
        Else
            BtnUpload.Enabled = True
        End If
    End Sub

    Private Sub MetroTextBox1_Click(sender As Object, e As EventArgs) Handles MetroTextBox1.Click
        '' -- Open file directory
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            MetroTextBox1.Text = strFileName
        End If


    End Sub
    Private Sub MetroGrid1_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles MetroGrid1.RowPostPaint
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

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles BtnUpload.Click
        MetroProgressBar1.Visible = True
        MetroProgressBar1.Maximum = MetroGrid1.Rows.Count

        '-- proses upload to database
        Try
            openDB()
            Using cmd1 As New SqlCommand("sp_HarvestProd", con)
                cmd1.CommandType = CommandType.StoredProcedure
                cmd1.Parameters.Add("@harvest", SqlDbType.SmallDateTime)
                cmd1.Parameters.Add("@variety", SqlDbType.VarChar)
                cmd1.Parameters.Add("@staff", SqlDbType.VarChar)
                cmd1.Parameters.Add("@kab", SqlDbType.VarChar)
                cmd1.Parameters.Add("@kec", SqlDbType.VarChar)
                cmd1.Parameters.Add("@desa", SqlDbType.VarChar)
                cmd1.Parameters.Add("@dusun", SqlDbType.VarChar)
                cmd1.Parameters.Add("@norencana", SqlDbType.VarChar)
                cmd1.Parameters.Add("@nokontrak", SqlDbType.VarChar)
                cmd1.Parameters.Add("@blokno", SqlDbType.VarChar)
                cmd1.Parameters.Add("@cgrno", SqlDbType.VarChar)
                cmd1.Parameters.Add("@cgrname", SqlDbType.VarChar)
                cmd1.Parameters.Add("@id_login", SqlDbType.Int)
                cmd1.Parameters.Add("@joblot", SqlDbType.VarChar)
                cmd1.Parameters.Add("@area", SqlDbType.VarChar)
                cmd1.Parameters.Add("@plantdate", SqlDbType.Date)
                cmd1.Parameters.Add("@area_ha", SqlDbType.Decimal)
                cmd1.Parameters.Add("@plant_qty", SqlDbType.Decimal)
                cmd1.Parameters.Add("@upload_id", SqlDbType.VarChar)

                For i As Integer = 0 To MetroGrid1.Rows.Count - 1
                    With cmd1
                        .Parameters("@harvest").Value = MetroGrid1.Rows(i).Cells(0).Value
                        .Parameters("@area").Value = MetroGrid1.Rows(i).Cells(1).Value
                        .Parameters("@variety").Value = MetroGrid1.Rows(i).Cells(2).Value
                        .Parameters("@staff").Value = MetroGrid1.Rows(i).Cells(3).Value
                        .Parameters("@kab").Value = MetroGrid1.Rows(i).Cells(4).Value
                        .Parameters("@kec").Value = MetroGrid1.Rows(i).Cells(5).Value
                        .Parameters("@desa").Value = MetroGrid1.Rows(i).Cells(6).Value
                        .Parameters("@dusun").Value = MetroGrid1.Rows(i).Cells(7).Value
                        .Parameters("@plantdate").Value = MetroGrid1.Rows(i).Cells(8).Value
                        .Parameters("@area_ha").Value = CDec(MetroGrid1.Rows(i).Cells(9).Value)
                        .Parameters("@plant_qty").Value = CDec(MetroGrid1.Rows(i).Cells(10).Value)
                        .Parameters("@nokontrak").Value = MetroGrid1.Rows(i).Cells(11).Value
                        .Parameters("@norencana").Value = MetroGrid1.Rows(i).Cells(12).Value
                        .Parameters("@blokno").Value = MetroGrid1.Rows(i).Cells(13).Value
                        .Parameters("@cgrno").Value = MetroGrid1.Rows(i).Cells(14).Value
                        .Parameters("@cgrname").Value = MetroGrid1.Rows(i).Cells(15).Value
                        .Parameters("@joblot").Value = MetroGrid1.Rows(i).Cells(16).Value
                        .Parameters("@id_login").Value = login.Luserid.Text
                        .Parameters("@upload_id").Value = GetIPAddress()
                    End With
                    cmd1.ExecuteScalar()
                    MetroProgressBar1.Value += i
                Next

            End Using
            Dim result As DialogResult = MetroMessageBox.Show(Me, "Upload Harvest Production Succesfully", "Upload", MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            If result = DialogResult.OK Then
                MetroProgressBar1.Visible = False
                Dispose()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        Finally
            con.Close()
            MetroProgressBar1.Visible = False
        End Try

    End Sub

    Private Sub MetroGrid1_Validating(sender As Object, e As CancelEventArgs) Handles MetroGrid1.Validating
        If MetroGrid1.Rows.Count <= 0 Then
            BtnUpload.Enabled = False
        Else
            BtnUpload.Enabled = True
        End If
    End Sub

    Private Sub Import_Data_Excel_Load(sender As Object, e As EventArgs) Handles Me.Load
        If MetroGrid1.Rows.Count = 0 Then
            BtnUpload.Enabled = False
        End If
    End Sub

    Private Sub Check_DireckLoad_CheckStateChanged(sender As Object, e As EventArgs) Handles Check_DireckLoad.CheckStateChanged
        If Check_DireckLoad.Checked Then
            Label_from.Visible = True
            Label_to.Visible = True
            DateFrom.Visible = True
            DateTo.Visible = True
        Else
            Label_from.Visible = False
            Label_to.Visible = False
            DateFrom.Visible = False
            DateTo.Visible = False
        End If
    End Sub

    Function GetDataTable() As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable
        Dim searchString As String = "Total, ALL Area"
        ' Create four typed columns in the DataTable.
        Dim names = {"HarvestColumn", "AreaColumn", "Variety", "Staff", "Location", "Column1", "Column2", "Column3", "PlantDate", "AreaHa", "Qty", "NoKontrak", "NoRencanaPanen", "BlockNo", "CGRNo", "CGRName", "NoLot"}
        Dim headers = {"Harvest Date", "Area", "Variety", "Staff", "Location", "Column1", "Column2", "Column3", "Plant Date", "Area Ha", "Qty kg", "NoKontrak", "NoRencanaPanen", "BlockNo", "CGRNo", "CGRName", "NoLot"}
        Dim icol As Integer = 0

        '-- Insert columns to DataTable
        Try
            For index = 0 To 16 'How many do you want?
                Dim column As New DataColumn()
                With column
                    .Caption = headers(icol)
                    .ColumnName = names(icol)
                    .DataType = Type.GetType("System.String")
                    ' Use the Text property for the button text for all cells rather
                    ' than using each cell's value as the text for its own button.
                End With
                table.Columns.Add(column)
                icol = icol + 1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        ' -- Load data from SAS
        Dim webAddress As String
        Dim html As String
        webAddress = "http://10.15.13.2/cgi-bin/rwcgi60.exe?bisicsv+report=/production/weekly_harvest_planning_csv.rdf+P_HARVEST_DATE_FROM=" &
                      DateFrom.Value.ToString("dd-MM-yyyy") & "+P_HARVEST_DATE_UNTIL=" & DateTo.Value.ToString("dd-MM-yyyy") &
                      "+P_CROP_NAME=+P_PARENTAREA=+P_AREA=+P_ITEM_CODE=+P_LOCATION=+P_STAFF=+P_USERNAME=trinur"
        Dim request As WebRequest = WebRequest.Create(webAddress)
        Using response As WebResponse = request.GetResponse()
            Using reader As New StreamReader(response.GetResponseStream())
                html = reader.ReadToEnd()

                For index As Integer = html.Length - 1 To 0 Step -1
                    If html.Contains(searchString) Then
                        html = html.Remove(index)
                    End If
                Next
                html = html.Substring(0, html.Length - searchString.Length)
                Console.WriteLine(html)

                Dim TextLine As String
                Dim SplitLine() As String

                Using objReader As New StringReader(html)
                        Dim counter As Integer = 0
                        Do While objReader.Peek() <> -1
                            'Baca isi dari file
                            TextLine = objReader.ReadLine().Replace("Dariyono, A.Md", "Dariyono A.Md")
                            'identifikasi pembatas antar column
                            SplitLine = Split(TextLine, ",")
                            If Not TextLine.Contains("SC-") Then '--add multiple containt
                                If counter > 0 Then
                                    ''Proses Insert ke DataTable
                                    table.Rows.Add(CDate(SplitLine(0)).ToString("dd-MMM-yyyy"),
                                                        SplitLine(1),
                                                        SplitLine(2),
                                                        SplitLine(3),
                                                        SplitLine(4),
                                                        SplitLine(5),
                                                        SplitLine(6),
                                                        SplitLine(7),
                                                        SplitLine(8),
                                                        CDec(SplitLine(9)),
                                                        CDec(SplitLine(10)),
                                                        SplitLine(11),
                                                        SplitLine(12),
                                                        SplitLine(13),
                                                        SplitLine(14),
                                                        SplitLine(15), "")
                                End If
                                counter += 1
                            End If
                        Loop
                    End Using
                'Catch ex As Exception
                '    MessageBox.Show("Function Table " + ex.Message)
                'End Try
            End Using
        End Using
        Console.WriteLine(html)
        ' Add five rows with those columns filled in the DataTable


        Return table
    End Function

    Private Sub MetroButton2_Click_1(sender As Object, e As EventArgs)
        Dim table As DataTable = GetDataTable()
        MetroGrid1.DataSource = table

    End Sub
End Class


