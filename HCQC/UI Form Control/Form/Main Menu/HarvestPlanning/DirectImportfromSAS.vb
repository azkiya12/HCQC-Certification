Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Text

Public Class DirectImportfromSAS
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If DateTo.Value < DateFrom.Value Then
            MetroMessageBox.Show(Me, "DATE END harus lebih besar dari pada DATE START")
            Exit Sub
        End If

        Dim epesan As String = ""
        Dim table As DataTable = GetDataTable(epesan)
        '-- proses upload to database
        If epesan = "" Then
            If table.Rows.Count >= 2 Then
                MetroProgressBar1.Maximum = table.Rows.Count + 1
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
                        MetroProgressBar1.Visible = True
                        For i As Integer = 0 To table.Rows.Count - 1
                            With cmd1
                                .Parameters("@harvest").Value = table.Rows(i).Item(0).ToString
                                .Parameters("@area").Value = table.Rows(i).Item(1).ToString
                                .Parameters("@variety").Value = table.Rows(i).Item(2).ToString
                                .Parameters("@staff").Value = table.Rows(i).Item(3).ToString
                                .Parameters("@kab").Value = table.Rows(i).Item(4).ToString
                                .Parameters("@kec").Value = table.Rows(i).Item(5).ToString
                                .Parameters("@desa").Value = table.Rows(i).Item(6).ToString
                                .Parameters("@dusun").Value = table.Rows(i).Item(7).ToString
                                .Parameters("@plantdate").Value = table.Rows(i).Item(8).ToString
                                .Parameters("@area_ha").Value = CDec(table.Rows(i).Item(9).ToString)
                                .Parameters("@plant_qty").Value = CDec(table.Rows(i).Item(10).ToString)
                                .Parameters("@nokontrak").Value = table.Rows(i).Item(11).ToString
                                .Parameters("@norencana").Value = table.Rows(i).Item(12).ToString
                                .Parameters("@blokno").Value = table.Rows(i).Item(13).ToString
                                .Parameters("@cgrno").Value = table.Rows(i).Item(14).ToString
                                .Parameters("@cgrname").Value = table.Rows(i).Item(15).ToString
                                .Parameters("@joblot").Value = table.Rows(i).Item(16).ToString
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
                        Me.Close()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Return
                Finally
                    con.Close()
                    MetroProgressBar1.Visible = False
                End Try
            Else
                MetroMessageBox.Show(Me, "Jumlah baris data kurang dari 2 baris")
                Return
            End If
        End If

    End Sub

    Private Sub DirectImportfromSAS_Load(sender As Object, e As EventArgs) Handles Me.Load
        DateFrom.Value = Today
        DateTo.Value = Today
    End Sub

    Function GetDataTable(ByRef errorMsg As String) As DataTable

        ' Create new DataTable instance.
        Dim table As New DataTable
        Dim searchString As String = "Total|ALL Area"
        ' Create four typed columns in the DataTable.
        Dim names = {"HarvestColumn", "AreaColumn", "Variety", "Staff", "Location", "Column1", "Column2", "Column3", "PlantDate", "AreaHa", "Qty", "NoKontrak", "NoRencanaPanen", "BlockNo", "CGRNo", "CGRName", "NoLot"}
        Dim headers = {"Harvest Date", "Area", "Variety", "Staff", "Location", "Column1", "Column2", "Column3", "Plant Date", "Area Ha", "Qty kg", "NoKontrak", "NoRencanaPanen", "BlockNo", "CGRNo", "CGRName", "NoLot"}
        Dim icol As Integer = 0
        errorMsg = ""
        '-- Insert columns to DataTable
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

        ' -- Load data from SAS
        Dim webAddress As String
        Dim html As String
        webAddress = "http://10.15.13.2/cgi-bin/rwcgi60.exe?bisicsv+report=/production/weekly_harvest_planning_csv.rdf+P_HARVEST_DATE_FROM=" &
                      DateFrom.Value.ToString("dd-MM-yyyy") & "+P_HARVEST_DATE_UNTIL=" & DateTo.Value.ToString("dd-MM-yyyy") &
                      "+P_CROP_NAME=+P_PARENTAREA=+P_AREA=+P_ITEM_CODE=+P_LOCATION=+P_STAFF=+P_USERNAME=trinur"
        Dim request As WebRequest = WebRequest.Create(webAddress)
        Try
            Using response As WebResponse = request.GetResponse()
                Using reader As New StreamReader(response.GetResponseStream())
                    html = reader.ReadToEnd()
                    If html.Contains("Oracle Reports Server") Then
                        MetroMessageBox.Show(Me, "Oracle Reports Server : Unable to communicate with the SAS Reports Server")
                        errorMsg = "Oracle Reports Server : Unable to communicate with the Reports Server"
                        Exit Function
                    End If

                    For index As Integer = html.Length - 1 To 0 Step -1
                        If html.Contains(searchString) Then
                            html = html.Remove(index)
                        End If
                    Next
                    html = html.Substring(0, html.Length - searchString.Length)
                    Console.WriteLine(html)
                End Using
            End Using
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Connection Error : " & ex.Message)
            errorMsg = "Connection Error : " & ex.Message
            Exit Function
        End Try

        Dim TextLine As String
        Dim SplitLine() As String

        Try
            Using objReader As New StringReader(html)

                Dim counter As Integer = 0
                Do While objReader.Peek() <> -1
                    'Baca isi dari file
                    TextLine = objReader.ReadLine().Replace("Dariyono, A.Md", "Dariyono A.Md")
                    Console.WriteLine("1##" & TextLine)
                    TextLine = TextLine.Replace("|", ",")
                    Console.WriteLine("2####" & TextLine)
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
                Return table
                'return empty if no error occured
                errorMsg = ""
            End Using
        Catch ex As Exception
            MsgBox("Erro Upload : " & ex.ToString)
            errorMsg = "Error Upload DataTable : " & ex.ToString
        End Try

    End Function
End Class