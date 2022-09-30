Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Text

Public Class DirectImportGlobalReportSAS

    Function GetDataTable(ByRef errorMsg As String, ByVal html As String) As DataTable

        ' Create new DataTable instance.
        Dim table As New DataTable
        Dim searchString As String = "*****end of file*****   "

        ' Create four typed columns in the DataTable.
        Dim names = {"warehouse_name", "job_no", "end_balance", "uom_code", "status", "document_date", "vigor", "ka", "dt", "purity", "harvest_date"}
        Dim headers = {"warehouse_name", "job_no", "end_balance", "uom_code", "status", "document_date", "vigor", "ka", "dt", "purity", "harvest_date"}
        Dim icol As Integer = 0
        errorMsg = ""

        '-- Insert columns to DataTable 14
        '-- How many do you want?
        For index = 0 To names.Count - 1
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

        Dim TextLine As String
        Dim SplitLine() As String
        Try
            Using objReader As New StringReader(html)
                Dim counter As Integer = 0
                Do While objReader.Peek() <> -1
                    'Baca isi dari file
                    TextLine = objReader.ReadLine()
                    'identifikasi pembatas antar column
                    SplitLine = Split(TextLine, "|")
                    'If Not TextLine.Contains("SC-") Then '--add multiple containt
                    If counter > 0 Then
                        ''Proses Insert ke DataTable
                        table.Rows.Add(SplitLine(2),
                                        SplitLine(3),
                                        SplitLine(4),
                                        SplitLine(5),
                                        SplitLine(6),
                                        CDate(SplitLine(7)).ToString("dd-MM-yyyy"),
                                        SplitLine(9),
                                        SplitLine(10),
                                        SplitLine(11),
                                        SplitLine(12),
                                        CDate(SplitLine(13)).ToString("dd-MM-yyyy"))
                    End If
                    counter += 1
                    'End If
                Loop
                Return table
                'return empty if no error occured
                errorMsg = ""
            End Using
        Catch ex As Exception
            MsgBox("Erro Upload : " & ex.ToString)
            errorMsg = "Error Upload DataTable : " & ex.ToString
            Return table
        End Try

    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MetroGrid1.Columns.Clear()
        Dim names = {"Varietas", "job_no", "harvest_date", "weight_kg", "document_date", "warehouse_name", "status"}
        Dim headers = {"Varietas", "job_no", "harvest_date", "weight_kg", "document_date", "warehouse_name", "status"}
        Dim i As Integer = 0
        'Add Columns to DataGridView
        Try
            For index = 0 To names.Count - 1 'How many do you want?
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

        Dim rows() As DataRow = tbglobalSAS.Select("job_no = '" & MetroTextBox1.Text & "'")

        'If rows.Count > i Then
        MetroGrid1.Rows.Clear()

        For Each row As DataRow In rows
            Lwerehouse.Text = row(0)
            Ljobno.Text = row(1).ToString
            Lweight.Text = row(2).ToString
            Lscope.Text = row(4).ToString
            Ldoc_date.Text = row(5).ToString
            Lharvest.Text = row(10).ToString
            Lvariety.Text = _DataToValue("Select top(1) variety from spl_request where nojob='" & MetroTextBox1.Text & "' order by id desc")
        Next
        'End If

        'menampilkan datatable row data di console
        'For Each row As DataRow In tbglobalSAS.AsEnumerable()
        '    Console.WriteLine("#" & String.Join(",", row.ItemArray))
        'Next

        'ProgressSpinner1.Visible = False
        'Lstatus.Text = "loading..."
        'Lstatus.Visible = False
        'Dim table As DataTable = GetDataTable(epesan)

        '-- proses upload to database
        'If epesan = "" Then
        '    If table.Rows.Count >= 2 Then
        '        MetroProgressBar1.Maximum = table.Rows.Count + 1
        '        Try
        '            openDB()
        '            Using cmd1 As New SqlCommand("sp_HarvestProd", con)
        '                cmd1.CommandType = CommandType.StoredProcedure
        '                cmd1.Parameters.Add("@harvest", SqlDbType.SmallDateTime)
        '                cmd1.Parameters.Add("@variety", SqlDbType.VarChar)
        '                cmd1.Parameters.Add("@staff", SqlDbType.VarChar)
        '                cmd1.Parameters.Add("@kab", SqlDbType.VarChar)
        '                cmd1.Parameters.Add("@kec", SqlDbType.VarChar)
        '                cmd1.Parameters.Add("@desa", SqlDbType.VarChar)
        '                cmd1.Parameters.Add("@dusun", SqlDbType.VarChar)
        '                cmd1.Parameters.Add("@norencana", SqlDbType.VarChar)
        '                cmd1.Parameters.Add("@nokontrak", SqlDbType.VarChar)
        '                cmd1.Parameters.Add("@blokno", SqlDbType.VarChar)
        '                cmd1.Parameters.Add("@cgrno", SqlDbType.VarChar)
        '                cmd1.Parameters.Add("@cgrname", SqlDbType.VarChar)
        '                cmd1.Parameters.Add("@id_login", SqlDbType.Int)
        '                cmd1.Parameters.Add("@joblot", SqlDbType.VarChar)
        '                cmd1.Parameters.Add("@area", SqlDbType.VarChar)
        '                cmd1.Parameters.Add("@plantdate", SqlDbType.Date)
        '                cmd1.Parameters.Add("@area_ha", SqlDbType.Decimal)
        '                cmd1.Parameters.Add("@plant_qty", SqlDbType.Decimal)
        '                cmd1.Parameters.Add("@upload_id", SqlDbType.VarChar)
        '                MetroProgressBar1.Visible = True
        '                For i As Integer = 0 To table.Rows.Count - 1
        '                    With cmd1
        '                        .Parameters("@harvest").Value = table.Rows(i).Item(0).ToString
        '                        .Parameters("@area").Value = table.Rows(i).Item(1).ToString
        '                        .Parameters("@variety").Value = table.Rows(i).Item(2).ToString
        '                        .Parameters("@staff").Value = table.Rows(i).Item(3).ToString
        '                        .Parameters("@kab").Value = table.Rows(i).Item(4).ToString
        '                        .Parameters("@kec").Value = table.Rows(i).Item(5).ToString
        '                        .Parameters("@desa").Value = table.Rows(i).Item(6).ToString
        '                        .Parameters("@dusun").Value = table.Rows(i).Item(7).ToString
        '                        .Parameters("@plantdate").Value = table.Rows(i).Item(8).ToString
        '                        .Parameters("@area_ha").Value = CDec(table.Rows(i).Item(9).ToString)
        '                        .Parameters("@plant_qty").Value = CDec(table.Rows(i).Item(10).ToString)
        '                        .Parameters("@nokontrak").Value = table.Rows(i).Item(11).ToString
        '                        .Parameters("@norencana").Value = table.Rows(i).Item(12).ToString
        '                        .Parameters("@blokno").Value = table.Rows(i).Item(13).ToString
        '                        .Parameters("@cgrno").Value = table.Rows(i).Item(14).ToString
        '                        .Parameters("@cgrname").Value = table.Rows(i).Item(15).ToString
        '                        .Parameters("@joblot").Value = table.Rows(i).Item(16).ToString
        '                        .Parameters("@id_login").Value = login.Luserid.Text
        '                        .Parameters("@upload_id").Value = GetIPAddress()
        '                    End With
        '                    cmd1.ExecuteScalar()
        '                    MetroProgressBar1.Value += i
        '                Next

        '            End Using
        '            Dim result As DialogResult = MetroMessageBox.Show(Me, "Upload Harvest Production Succesfully", "Upload", MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
        '            If result = DialogResult.OK Then
        '                MetroProgressBar1.Visible = False
        '                Me.Close()
        '            End If
        '        Catch ex As Exception
        '            MessageBox.Show(ex.Message)
        '            Return
        '        Finally
        '            con.Close()
        '            MetroProgressBar1.Visible = False
        '        End Try
        '    Else
        'MetroMessageBox.Show(Me, "Jumlah baris data kurang dari 2 baris")
        '        Return
        '    End If
        'End If
    End Sub

    Private Sub DirectImportGlobalReportSAS_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim webAddress As String
        Dim html As String
        Dim searchString As String = "*****end of file*****   "
        webAddress = "http://10.15.13.2/cgi-bin/rwcgi60.exe?bisicsv+report=/inventory/stock_wip_with_harvest_date_info_csv.rdf+" &
                     "P_CROP_NAME=+P_CLASS_NAME=+P_AS_OF_DATE=" & Today.ToString("dd-MM-yyyy") & "+P_WAREHOUSE_NAME=+P_ITEM_CODE=+P_HARVEST_DATE_FROM=+" &
                     "P_HARVEST_DATE_UNTIL=+P_KA_FROM=0+P_KA_UNTIL=100+P_DT_FROM=0+P_DT_UNTIL=100+P_PURITY_FROM=0+P_PURITY_UNTIL=100+P_USERNAME=trinur"
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(webAddress), HttpWebRequest)

        Try
            'Lstatus.Text = "Loading Web Response request..."
            Using response As HttpWebResponse = request.GetResponse()
                Dim leng As Long = response.ContentLength
                'Lstatus.Text = "Loading Reading data response..."
                Using reader As New StreamReader(response.GetResponseStream())
                    html = reader.ReadToEnd()
                    If html.Contains("Oracle Reports Server") Then
                        MetroMessageBox.Show(Me, "Oracle Reports Server : Unable to communicate with the SAS Reports Server")
                        e.Result = "Oracle Reports Server : Unable to communicate with the Reports Server"
                    End If

                    'Console.WriteLine(html)
                    html = html.Substring(0, html.Length - searchString.Length)
                    'Console.WriteLine(html)
                    e.Result = html
                End Using
            End Using
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Connection Error : " & ex.Message)
            e.Result = "Connection Error : " & ex.Message
        End Try
    End Sub
    Dim tbglobalSAS As DataTable
    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ProgressSpinner1.Visible = False
        Dim pesan As String = ""
        tbglobalSAS = GetDataTable(pesan, e.Result)
        If tbglobalSAS IsNot Nothing AndAlso tbglobalSAS.Rows.Count > 0 Then
            'some code
            Lstatus.Text = "Global Stock WIP SAS | " & Today() & " | " & tbglobalSAS.Rows.Count.ToString & " Row"
        Else
            'some code
            Lstatus.Text = e.Result
        End If
        LinkGetData.Enabled = True
        LinkGetData.Text = "Update SAS"
    End Sub

    Private Sub LinkGetData_Click(sender As Object, e As EventArgs) Handles LinkGetData.Click
        ProgressSpinner1.Visible = True
        Lstatus.Visible = True
        LinkGetData.Enabled = False
        Lstatus.Text = "Loading get data from sas..."
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub MetroLabel3_Click(sender As Object, e As EventArgs) Handles MetroLabel3.Click

    End Sub

    Private Sub MetroLabel4_Click(sender As Object, e As EventArgs) Handles MetroLabel4.Click

    End Sub

    Private Sub Ljobno_Click(sender As Object, e As EventArgs) Handles Ljobno.Click

    End Sub
End Class