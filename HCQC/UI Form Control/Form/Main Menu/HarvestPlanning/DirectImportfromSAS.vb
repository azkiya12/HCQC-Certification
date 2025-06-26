Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Threading.Tasks

Public Class DirectImportfromSAS
    Private Async Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If DateTo.Value < DateFrom.Value Then
            MetroMessageBox.Show(Me, "DATE END harus lebih besar dari pada DATE START")
            Exit Sub
        End If

        ' Memperbarui status awal
        MetroProgressSpinner1.Visible = True
        LabelStatus.Text = "Mengambil Data..."
        Await Task.Delay(1500)

        'Dim epesan As String = ""
        'Dim table As DataTable = GetDataTable(epesan)

        ' Mendapatkan hasil dari fungsi GetDataTableAsync
        Dim result As (DataTable, String) = Await GetDataTableAsync()

        ' Memisahkan tuple menjadi dua variabel
        Dim table As DataTable = result.Item1
        Dim epesan As String = result.Item2

        LabelStatus.Text = "Finish get data web content..."
        Await Task.Delay(1000)

        '-- proses upload to database
        If String.IsNullOrEmpty(epesan) Then
            LabelStatus.Text = "Loading upload database..."
            Await Task.Delay(1000)
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
                                .Parameters("@joblot").Value = table.Rows(i).Item(19).ToString
                                .Parameters("@id_login").Value = login.Luserid.Text
                                .Parameters("@upload_id").Value = GetIPAddress()
                            End With
                            cmd1.ExecuteScalar()
                            MetroProgressBar1.Value += i
                            'Console.WriteLine("UploadNoRencana " & table.Rows(i).Item(12).ToString)
                        Next

                    End Using
                    Dim pesan As DialogResult = MetroMessageBox.Show(Me, "Upload Harvest Production Succesfully", "Upload", MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                    If pesan = DialogResult.OK Then
                        MetroProgressBar1.Visible = False
                        Me.Close()
                    End If
                Catch ex As Exception
                    MetroMessageBox.Show(Me, ex.Message, "Masalah Upload")
                    Return
                Finally
                    con.Close()
                    MetroProgressBar1.Visible = False
                    LabelStatus.Text = ""
                    MetroProgressSpinner1.Visible = False
                End Try
            Else
                MetroMessageBox.Show(Me, "Jumlah baris data kurang dari 2 baris", "SAS Data")
                Return
            End If
        Else
            MetroMessageBox.Show(Me, epesan)
            LabelStatus.Text = "Unable to communicate with the SAS Reports Server"
            MetroProgressSpinner1.Visible = False
            MetroProgressBar1.Visible = False
        End If

    End Sub

    Private Sub DirectImportfromSAS_Load(sender As Object, e As EventArgs) Handles Me.Load
        DateFrom.Value = Today
        DateTo.Value = Today
    End Sub

    Function GetDataTable(ByRef errorMsg As String) As DataTable

        ' Create new DataTable instance.
        Dim table As New DataTable

        ' Create four typed columns in the DataTable.
        Dim names = {"HarvestColumn", "AreaColumn", "Variety", "Staff", "Location", "Column1", "Column2", "Column3", "PlantDate", "AreaHa", "Qty", "NoKontrak", "NoRencanaPanen", "BlockNo", "CGRNo", "CGRName", "NoSJManual", "GRDate", "GR NO", "NoLot"}
        Dim headers = {"Harvest Date", "Area", "Variety", "Staff", "Location", "Column1", "Column2", "Column3", "Plant Date", "Area Ha", "Qty kg", "NoKontrak", "NoRencanaPanen", "BlockNo", "CGRNo", "CGRName", "NoSJManual", "GRDate", "GR NO", "NoLot"}
        Dim icol As Integer = 0
        errorMsg = ""
        '-- Insert columns to DataTable
        For index = 0 To 19 'How many do you want?
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
        Dim html As String
        Dim webAddress As String
        Dim searchString As String = "Total|"
        Dim caseInsensitive As StringComparison = StringComparison.OrdinalIgnoreCase

        webAddress = "http://10.15.13.2/cgi-bin/rwcgi60.exe?bisicsv+report=/production/weekly_harvest_planning_csv.rdf+P_HARVEST_DATE_FROM=" &
                      DateFrom.Value.ToString("dd-MM-yyyy") & "+P_HARVEST_DATE_UNTIL=" & DateTo.Value.ToString("dd-MM-yyyy") &
                      "+P_CROP_NAME=+P_PARENTAREA=+P_AREA=+P_ITEM_CODE=+P_LOCATION=+P_STAFF=+P_USERNAME=trinur"
        Dim request As WebRequest = WebRequest.Create(webAddress)
        Try
            Using response As WebResponse = request.GetResponse()
                Using reader As New StreamReader(response.GetResponseStream())
                    html = reader.ReadToEnd()
                    If html.IndexOf("Oracle Reports Server", caseInsensitive) >= 0 Then
                        MetroMessageBox.Show(Me, "Oracle Reports Server : Unable to communicate with the SAS Reports Server")
                        errorMsg = "Oracle Reports Server : Unable to communicate with the Reports Server"
                        Return Nothing
                    End If

                    'Menghapus bari yang memuliki content TOTAL|
                    For index As Integer = html.Length - 1 To 0 Step -1
                        If html.IndexOf(searchString, caseInsensitive) >= 0 Then
                            html = html.Remove(index)
                        End If
                    Next
                    html = html.Substring(0, html.Length - searchString.Length)
                    Console.WriteLine("###Raw Data Harvest Planing###")
                    Console.WriteLine(html)
                End Using
            End Using
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Connection Error : " & ex.Message)
            errorMsg = "Connection Error : " & ex.Message
            Return Nothing
        End Try

        Dim TextLine As String
        Dim SplitLine() As String

        ' Daftar substring yang ingin dihindari
        Dim substringsToAvoid As New List(Of String) From {
            "sc-", "fc/rd"
        }

        ' Daftar pasangan nama dan jabatan untuk penggantian
        Dim replacements As New Dictionary(Of String, String) From {
            {"Dariyono, A.Md", "Dariyono A.Md"},
            {"Imron Hamzah, S.P", "Imron Hamzah S.P"}
        }
        Try
            Using objReader As New StringReader(html)

                Dim counter As Integer = 0
                Do While objReader.Peek() <> -1
                    'Baca isi dari file
                    TextLine = objReader.ReadLine()

                    ' Lakukan penggantian nama dengan jabatan
                    For Each kvp In replacements
                        TextLine = TextLine.Replace(kvp.Key, kvp.Value)
                    Next

                    Console.WriteLine("1##" & TextLine)
                    TextLine = TextLine.Replace("|", ",")
                    Console.WriteLine("2####" & TextLine)

                    'identifikasi pembatas antar column
                    SplitLine = Split(TextLine, ",")

                    ' Periksa apakah TextLine mengandung salah satu substring dalam substringsToAvoid
                    Dim containsSubstring As Boolean = substringsToAvoid.Any(Function(substring) TextLine.IndexOf(substring, StringComparison.OrdinalIgnoreCase) >= 0)

                    If Not containsSubstring Then
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
                                                    SplitLine(15),
                                                    SplitLine(16),
                                                    SplitLine(17),
                                                    SplitLine(18), "")
                            Console.WriteLine("Upload ### " & TextLine)
                        End If
                        counter += 1
                    End If
                Loop
                Return table
                'return empty if no error occured
                ' errorMsg = ""
            End Using
        Catch ex As Exception
            MsgBox("Erro Upload : " & ex.ToString)
            errorMsg = "Error Upload DataTable : " & ex.ToString
            Return Nothing
        End Try

    End Function

    Public Async Function GetWebContentAsync(ByVal webAddress As String, ByVal searchString As String, ByVal caseInsensitive As Boolean) As Task(Of (String, String))
        'Debug.WriteLine("---GetWebContentAsync---")
        LabelStatus.Text = "Loading SAS Web Content..."
        Await Task.Delay(1500)
        Dim html As String = String.Empty
        Dim errorMsg As String = String.Empty
        Dim resulCaseInsensitive As StringComparison
        resulCaseInsensitive = If(caseInsensitive, StringComparison.OrdinalIgnoreCase, StringComparison.Ordinal)
        Try
            Dim request As WebRequest = WebRequest.Create(webAddress)
            Using response As WebResponse = Await request.GetResponseAsync()
                Using reader As New StreamReader(response.GetResponseStream())
                    html = Await reader.ReadToEndAsync()

                    ' Menampilkan raw HTML di konsol
                    'Debug.WriteLine("### Raw Data Harvest Planning ###")
                    'Debug.WriteLine(html)

                    If html.IndexOf("Oracle Reports Server", resulCaseInsensitive) >= 0 Then
                        errorMsg = "Oracle Reports Server : Unable to communicate with the SAS Reports Server"
                        Debug.WriteLine(errorMsg)
                        Return (Nothing, errorMsg)
                    End If

                    ' Example process of removing part of the string

                    'html = html.Remove(html.IndexOf(searchString, resulCaseInsensitive), searchString.Length)
                    'Debug.WriteLine("---AFTER FILTER TOTAL---")
                    'Debug.WriteLine(html)


                    For index As Integer = html.Length - 1 To 0 Step -1
                        If html.IndexOf(searchString, resulCaseInsensitive) >= 0 Then
                            html = html.Remove(index)
                        End If
                    Next
                    'Debug.WriteLine("---AFTER FILTER TOTAL---")
                    'Debug.WriteLine(html)

                    html = html.Substring(0, html.Length - searchString.Length)
                    Debug.WriteLine("---AFTER FILTER SUBTRING---")
                    Debug.WriteLine(html)
                End Using
            End Using
        Catch ex As Exception
            errorMsg = "Connection Error: " & ex.Message
        End Try

        Debug.WriteLine("---Finish GetWebContentAsync---")
        Return (html, errorMsg)
    End Function


    Public Async Function GetDataTableAsync() As Task(Of (DataTable, String))
        'Debug.WriteLine("---GetDataTableAsync---")

        ' Create new DataTable instance.
        Dim table As New DataTable

        ' Create four typed columns in the DataTable.
        Dim names = {"HarvestColumn", "AreaColumn", "Variety", "Staff", "Location", "Column1", "Column2", "Column3", "PlantDate", "AreaHa", "Qty", "NoKontrak", "NoRencanaPanen", "BlockNo", "CGRNo", "CGRName", "NoSJManual", "GRDate", "GR NO", "NoLot"}
        Dim headers = {"Harvest Date", "Area", "Variety", "Staff", "Location", "Column1", "Column2", "Column3", "Plant Date", "Area Ha", "Qty kg", "NoKontrak", "NoRencanaPanen", "BlockNo", "CGRNo", "CGRName", "NoSJManual", "GRDate", "GR NO", "NoLot"}
        Dim icol As Integer = 0

        '-- Insert columns to DataTable
        For index = 0 To 19 'How many do you want?
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

        Dim errorMsg As String = ""
        Dim webAddress As String
        Dim searchString As String = "Total|"

        webAddress = $"http://10.15.13.2/cgi-bin/rwcgi60.exe?bisicsv+report=/production/weekly_harvest_planning_csv.rdf+
                        P_HARVEST_DATE_FROM={DateFrom.Value:dd-MM-yyyy}+P_HARVEST_DATE_UNTIL={DateTo.Value:dd-MM-yyyy}+
                        P_CROP_NAME=+P_PARENTAREA=+P_AREA=+P_ITEM_CODE=+P_LOCATION=+P_STAFF=+P_USERNAME=trinur"
        Try
            ' Memanggil fungsi GetWebContentAsync dan menangkap hasil tuple
            Dim result As (String, String) = Await GetWebContentAsync(webAddress, searchString, True)

            ' Menugaskan nilai dari tuple ke variabel terpisah
            Dim html As String = result.Item1
            Dim webErrorMsg As String = result.Item2
            Debug.WriteLine("Menangkap hasil GetWeb")
            Debug.WriteLine(html)

            LabelStatus.Text = "Loading filtering data web content..."
            Await Task.Delay(1500)

            ' Memeriksa apakah ada kesalahan saat mengambil data dari web
            If Not String.IsNullOrEmpty(webErrorMsg) Then
                errorMsg = webErrorMsg
                Return (Nothing, errorMsg)
            End If

            Dim TextLine As String
            Dim SplitLine() As String

            ' Daftar substring yang ingin dihindari
            Dim substringsToAvoid As New List(Of String) From {
                "sc-", "fc/rd"
            }

            ' Daftar pasangan nama dan jabatan untuk penggantian
            Dim replacements As New Dictionary(Of String, String) From {
                {", A.Md", " A.Md"},
                {", S.P", " S.P"},
                {", S.Pd", " S.Pd"}
            }

            ' Proses html dan masukkan ke dalam DataTable
            Using objReader As New StringReader(html)

                Dim counter As Integer = 0
                Do While objReader.Peek() <> -1
                    'Baca isi dari file
                    TextLine = objReader.ReadLine()

                    ' Lakukan penggantian nama dengan jabatan
                    For Each kvp In replacements
                        TextLine = TextLine.Replace(kvp.Key, kvp.Value)
                    Next

                    Console.WriteLine("1##" & TextLine)
                    TextLine = TextLine.Replace("|", ",")
                    Console.WriteLine("2####" & TextLine)

                    'identifikasi pembatas antar column
                    SplitLine = Split(TextLine, ",")

                    ' Periksa apakah TextLine mengandung salah satu substring dalam substringsToAvoid
                    Dim containsSubstring As Boolean = substringsToAvoid.Any(Function(substring) TextLine.IndexOf(substring, StringComparison.OrdinalIgnoreCase) >= 0)

                    If Not containsSubstring Then
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
                                                    SplitLine(15),
                                                    SplitLine(16),
                                                    SplitLine(17),
                                                    SplitLine(18), "")
                            Console.WriteLine("Upload ### " & TextLine)
                        End If
                        counter += 1
                    End If
                Loop
            End Using
            ' Contoh sederhana untuk menambahkan hasil HTML sebagai satu kolom ke dalam tabel
            'table.Columns.Add("Content", GetType(String))
            'table.Rows.Add(html)

            Debug.WriteLine("---Finish GetDataTableAsync---")
            Return (table, errorMsg)
        Catch ex As Exception
            errorMsg = "Error: " & ex.Message
            'Console.WriteLine("---Finish Error GetDataTableAsync---")
            Return (Nothing, errorMsg)
        End Try


    End Function

    Public Async Sub Uji_asycGEtData()
        ' Memperbarui status awal
        LabelStatus.Text = "Mengambil Data..."
        Await Task.Delay(1500)
        ' Mendapatkan hasil dari fungsi GetDataTableAsync
        Dim result As (DataTable, String) = Await GetDataTableAsync()

        ' Memperbarui status setelah data diperoleh
        LabelStatus.Text = "Data diperoleh, siap ditampilkan."
        Await Task.Delay(1500)
        ' Memisahkan tuple menjadi dua variabel
        Dim table As DataTable = result.Item1
        Dim epesan As String = result.Item2

        ' Iterasi melalui baris dan kolom DataTable untuk menampilkan data
        For Each row As DataRow In table.Rows
            For Each col As DataColumn In table.Columns
                Console.Write(row(col).ToString() & ",") ' Menampilkan setiap kolom diikuti dengan tab
            Next
            Console.WriteLine("-") ' Pindah ke baris berikutnya
        Next

        ' Tunggu input dari user agar console tidak langsung tertutup
        Console.WriteLine("OK")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Uji_asycGEtData()
    End Sub
End Class