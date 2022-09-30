Imports System.IO
Imports System.Net

Public Class DirectStockOnProcess
    Function GetDataTableStock(ByRef errorMsg As String) As DataTable

        ' Create new DataTable instance.
        Dim table As New DataTable

        ' Create four typed columns in the DataTable.
        Dim names = {"job_no", "tag_weight", "tag_position", "unit"}
        Dim headers = {"job_no", "tag_weight", "tag_position", "unit"}
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

        '-- DateTo.Value.ToString("dd-MM-yyyy")
        '-- Load data from SAS
        Dim webAddress As String
        Dim html As String
        webAddress = "http://10.15.13.2/cgi-bin/rwcgi60.exe?bisicsv+report=/process/stock_on_process_csv.rdf+P_CROP_NAME=+P_ITEM_CODE=+P_USERNAME=trinur"
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(webAddress), HttpWebRequest)

        Try
            'Lstatus.Text = "Loading Web Response request..."
            Using response As HttpWebResponse = request.GetResponse()
                Dim leng As Long = response.ContentLength
                'MsgBox(leng)
                'Lstatus.Text = "Loading Reading data response..."
                Using reader As New StreamReader(response.GetResponseStream())
                    html = reader.ReadToEnd()
                    If html.Contains("Oracle Reports Server") Then
                        MetroMessageBox.Show(Me, "Oracle Reports Server : Unable to communicate with the SAS Reports Server")
                        errorMsg = "Oracle Reports Server : Unable to communicate with the Reports Server"
                        Exit Function
                    End If

                End Using
            End Using
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Connection Error : " & ex.Message)
            errorMsg = "Connection Error : " & ex.Message
            Exit Function
        End Try


        Dim TextLine, taqposition As String
        Dim taqweight As Decimal
        Dim SplitLine() As String
        Try
            Using objReader As New StringReader(html)
                Dim counter As Integer = 0

                Do While objReader.Peek() <> -1
                    'Baca isi dari file
                    TextLine = objReader.ReadLine()
                    'Console.WriteLine(TextLine)
                    'identifikasi pembatas antar column
                    SplitLine = Split(TextLine, ",")


                    If counter > 0 Then
                        taqposition = IIf(Val(SplitLine(4)) > 0, "ear_sortir",
                                            IIf(Val(SplitLine(5)) > 0, "ear_drying",
                                                IIf(Val(SplitLine(6)) > 0, "shelling",
                                                    IIf(Val(SplitLine(7)) > 0, "seed_drying",
                                                        IIf(Val(SplitLine(8)) > 0, "seed_grading", "")
                                                        )
                                                    )
                                                )
                                            )
                        taqweight = IIf(Val(SplitLine(4)) > 0, SplitLine(4),
                                            IIf(Val(SplitLine(5)) > 0, SplitLine(5),
                                                IIf(Val(SplitLine(6)) > 0, SplitLine(6),
                                                    IIf(Val(SplitLine(7)) > 0, SplitLine(7),
                                                        IIf(Val(SplitLine(8)) > 0, SplitLine(8), 0)
                                                        )
                                                    )
                                                )
                                            )
                        Console.WriteLine(taqposition & "  " & taqweight)
                        ''Proses Insert ke DataTable
                        table.Rows.Add(RTrim(LTrim(SplitLine(3))),
                                        taqposition,
                                        taqweight,
                                        RTrim(LTrim(SplitLine(2))))
                    End If
                    counter += 1

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

    Private Sub btnStokonprocess_Click(sender As Object, e As EventArgs) Handles btnStokonprocess.Click
        Dim pesan As String = ""
        Dim tbstockonproses As DataTable = GetDataTableStock(pesan)
        'menampilkan datatable row data di console
        'For Each row As DataRow In tbstockonproses.AsEnumerable()
        '    Console.WriteLine("#" & String.Join(",", row.ItemArray))
        'Next
    End Sub
End Class