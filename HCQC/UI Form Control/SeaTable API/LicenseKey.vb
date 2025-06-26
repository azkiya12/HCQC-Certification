Imports System.Net
Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json.Linq

Public Class LicenseKey

    Private Async Sub UnlockButton_Click(sender As Object, e As EventArgs) Handles UnlockButton.Click
        Dim licenseKey As String = SerialNumber.Text ' Lisensi diambil dari input atau file lokal
        Dim isValid As Boolean
        Dim errorCode As Integer
        Dim errorMsg As String = ""

        'lakukan pengecekan internet network 
        If Not IsNetworkAvailable() Then
            MessageBox.Show(Me, "Please check your Internet Access.", "Connection Server Failed", vbOK)
            Return
        End If

        ' Dapatkan Access_token dan Base UUID dari SeaTable
        Dim result As (String, String) = Await GetBaseToken_SeaTable(LicenseManager.ApiToken)

        LicenseManager.access_token = result.Item1
        LicenseManager.BaseUUID = result.Item2

        Dim resultCheckLicenseStatus As (Boolean, String, Integer) = Await CheckLicenseStatus(licenseKey)

        isValid = resultCheckLicenseStatus.Item1
        errorMsg = resultCheckLicenseStatus.Item2
        errorCode = resultCheckLicenseStatus.Item3

        If errorCode = 200 Then
            If isValid Then
                MessageBox.Show($"{errorMsg} ")
                TxtStatus.Text = "Licence Active"


                ' Tutup form dan kembalikan DialogResult.OK
                Me.DialogResult = DialogResult.OK
                Me.Close()

                'Buka form Dashboard
            Else
                MessageBox.Show($"{errorMsg} and code {errorCode}")

                'Application.Exit()
            End If

            TxtStatus.Text = LicenseManager.LicenseStatus
        Else
            MessageBox.Show(Me, "The serial key you entered is incorrect. Make sure you have entered all characters correctly, including uppercase letters and numbers.", "Validation Alert", vbOK)
        End If
    End Sub

    Public Async Function GetBaseToken_SeaTable(ByVal apiToken As String) As Task(Of (String, String))
        Try
            ' Generate Base-Token
            ' URL untuk login API SeaTable
            Dim requestUrl As String = "https://cloud.seatable.io/api/v2.1/dtable/app-access-token/"

            ' Menambahkan header Authorization
            Dim client As New HttpClient()
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " & apiToken)

            ' Mengirimkan GET request untuk mendapatkan token
            Dim response As HttpResponseMessage = Await client.GetAsync(requestUrl)
            response.EnsureSuccessStatusCode()

            ' Membaca response sebagai string
            Dim content As String = Await response.Content.ReadAsStringAsync()

            ' Parsing JSON untuk mendapatkan access token
            Dim jsonResponse As JObject = JObject.Parse(content)
            LicenseManager.access_token = jsonResponse("access_token").ToString()
            LicenseManager.BaseUUID = jsonResponse("dtable_uuid").ToString()

            'Set variable to insert to DB
            Dim app_name As String = jsonResponse("app_name").ToString()
            Dim accessToken As String = jsonResponse("access_token").ToString()
            Dim dtable_uuid As String = jsonResponse("dtable_uuid").ToString()
            Dim workspace_id As String = jsonResponse("workspace_id").ToString()
            Dim dtable_name As String = jsonResponse("dtable_name").ToString()
            Dim use_api_gateway As String = jsonResponse("use_api_gateway").ToString()


            'Console.WriteLine(accessToken)
            'Console.WriteLine(dtable_uuid)
            Return (accessToken, dtable_uuid)
        Catch ex As Exception
            Console.WriteLine("Login Error: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Async Function CheckLicenseStatus(licenseKey As String) As Task(Of (Boolean, String, Integer))

        Try
            ' Mendapatkan data licensi dari SeaTable
            'Dim licenseData As JObject = Await GetLicenseAsync(licenseKey)

            'mendapatkan data Licensikey menggunakan SQL
            Dim sqlQuery As String = $"SELECT id, ApkId, ApkName, LicenseKey, start_date, period, end_date, last_access, status_key, _id FROM SerialNumber WHERE ApkId='{LicenseManager.ApkID}' AND LicenseKey='{licenseKey}'"
            Dim result As (JArray, String, Integer) = Await QuerySeaTableWithSQL(sqlQuery)

            ' Menugaskan nilai dari tuple ke variabel terpisah
            Dim licenseData As JArray = result.Item1
            Dim errorMsg As String = result.Item2
            Dim statusCode As Integer = result.Item3

            Dim startDate As DateTime
            Dim endDate As DateTime

            If statusCode <> 200 Then
                MessageBox.Show($"Error Code {statusCode}: " & errorMsg)
                Return (False, errorMsg, statusCode)
            End If

            ' Check if the result is empty
            If licenseData Is Nothing OrElse licenseData.Count = 0 Then
                ' Display message if no data was found
                'MessageBox.Show("No data found based on the given query.", "Query ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return (False, "Licence Key authentication failed.", statusCode)
            Else
                Dim app_name As String = ""
                Dim apk_id As String = ""
                Dim serial_number As String = ""
                Dim status As String = ""
                Dim dateFormat As String = "yyyy-MM-dd" ' Sesuaikan dengan format tanggal di JSON
                Dim row_id As String = ""

                ' Process the result if data is found
                For Each jObject As JObject In licenseData
                    app_name = jObject("ApkName").ToString()
                    apk_id = jObject("ApkId").ToString()
                    serial_number = jObject("LicenseKey").ToString
                    status = jObject("status_key").ToString
                    startDate = DateTime.Parse(jObject("start_date").ToString())
                    endDate = DateTime.Parse(jObject("end_date").ToString())
                    row_id = jObject("_id").ToString()
                Next

                startDate = startDate.ToString("yyyy-MM-dd")
                endDate = endDate.ToString("yyyy-MM-dd")
                Console.WriteLine("start date: " & startDate.ToString("yyyy-MM-dd"))
                Console.WriteLine("end date: " & endDate.ToString("yyyy-MM-dd"))
                'Console.WriteLine($"{app_name}, {apk_id}, {serial_number}, {status}")

                'Check apakah terdapat baris data maka true
                If _isBOF("[HCQC_server].[dbo].[credential_api]", "apk_id", apk_id) Then
                    _RunSQL_nomsgbox($"UPDATE [dbo].[credential_api]
                               SET [app_name] = '{app_name}'
                                  ,[apk_id] = '{apk_id}'
                                  ,[serial_number] = '{serial_number}'
                                  ,[start_date]='{startDate:yyyy-MM-dd}'
                                  ,[end_date]='{endDate:yyyy-MM-dd}'
                                  ,[status] = '{status}'
                                  ,[last_check_date] = GETDATE()
                             WHERE id=1")

                    Console.WriteLine("Update DB credensial")
                Else
                    _RunSQL_nomsgbox($"INSERT INTO [dbo].[credential_api]
                                   ([app_name]
                                   ,[apk_id]
                                   ,[serial_number]
                                   ,[start_date]
                                   ,[end_date]
                                   ,[status]
                                   ,[last_check_date])
                             VALUES
                                    ('{app_name}'
                                    ,'{apk_id}'
                                    ,'{serial_number}'
                                    ,'{startDate:yyyy-MM-dd}'
                                    ,'{endDate:yyyy-MM-dd}'
                                    ,'{status}'
                                    ,GETDATE())")

                    Console.WriteLine("Save DB Credensial")
                End If

                LicenseManager.SerialNumber = serial_number
                LicenseManager.LicenseStatus = status
                LicenseManager.ExpiredDate = endDate
                LicenseManager.LastCheckDate = _DataToValueDate("SELECT TOP(1) [last_check_date] FROM [HCQC_server].[dbo].[credential_api]")
                LicenseManager.Row_Id = row_id

                UpdateSeaTableRow()
            End If
            ' Mendapatkan tanggal mulai dan berakhir dari lisensi
            'Console.WriteLine($"Query result: {licenseData.ToString()}")

            ' Mengecek apakah lisensi masih aktif
            If LicenseManager.LicenseStatus = "Active" Then
                If DateTime.Now >= startDate AndAlso DateTime.Now <= endDate Then
                    ' Lisensi masih aktif
                    Return (True, "Licence Key authentication success", statusCode)
                Else
                    ' Lisensi sudah kedaluwarsa
                    Return (False, $"Licence Key authentication failed. Licence Expired on {endDate.ToString("dd-MM-yyyy")}", statusCode)
                End If
            Else
                ' Lisensi sudah kedaluwarsa
                Return (False, "The license key is no longer active.", statusCode)
            End If
        Catch ex As Exception
            'MessageBox.Show("Error: " & ex.Message)
            Return (False, "Error: " & ex.Message, 404)
        End Try
    End Function

    Public Async Function QuerySeaTableWithSQL(sqlQuery As String) As Task(Of (JArray, String, Integer))
        Dim baseUrl As String = $"https://cloud.seatable.io/api-gateway/api/v2/dtables/{LicenseManager.BaseUUID}/sql" ' Endpoint SeaTable SQL API
        Dim result As JArray = Nothing
        Dim errorMsg As String = String.Empty
        Dim statusCode As Integer = 0

        ' Mempersiapkan request HTTP
        Using client As New HttpClient()
            ' Tambahkan header Authorization dengan API token
            client.DefaultRequestHeaders.Authorization = New Headers.AuthenticationHeaderValue("Token", LicenseManager.access_token)

            ' Persiapkan content request
            Dim content As New StringContent($"{{""sql"": ""{sqlQuery}"",""convert_keys"":true}}", Encoding.UTF8, "application/json")

            Try
                MessageBox.Show("Sending Request")
                ' Kirim POST request ke API SeaTable SQL
                Dim response As HttpResponseMessage = Await client.PostAsync(baseUrl, content)
                ' Baca konten respon
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()
                ' Parse respon JSON
                Dim jsonResponse As JObject = JObject.Parse(responseContent)

                ' Cek status respon
                Select Case response.StatusCode
                    Case HttpStatusCode.OK ' Status 200 - Request berhasil
                        result = jsonResponse("results")
                        errorMsg = "OK"
                        statusCode = response.StatusCode

                    Case HttpStatusCode.Unauthorized ' Status 401 - Unauthorized
                        MessageBox.Show("Access denied: Invalid or expired license key.")

                        result = Nothing
                        errorMsg = "Unauthorized"
                        statusCode = response.StatusCode

                    Case HttpStatusCode.NotFound ' Status 404 - License key tidak ditemukan
                        MessageBox.Show("License key not found.")

                        result = Nothing
                        errorMsg = " License key tidak ditemukan"
                        statusCode = response.StatusCode

                    Case Else ' Untuk status kode lainnya
                        result = Nothing
                        errorMsg = jsonResponse("error_message")
                        statusCode = response.StatusCode
                End Select

            Catch ex As HttpRequestException
                MessageBox.Show($"Request Error: {ex.Message}")
            End Try
        End Using
        Console.WriteLine($"{result}, {errorMsg}, {statusCode}")
        Return (result, errorMsg, statusCode)
    End Function

    Public Async Sub UpdateSeaTableRow()
        Console.WriteLine("Update column seaTable last_access")
        ' UUID dari tabel SeaTable Anda
        Dim baseUUID As String = LicenseManager.BaseUUID

        ' Token otorisasi
        Dim accessToken As String = LicenseManager.access_token

        ' ID baris yang ingin diperbarui
        Dim rowID As String = LicenseManager.Row_Id

        ' Data yang ingin diperbarui (JObject format)
        Dim newValue As DateTime = DateTime.Now
        Dim dataToUpdate As String
        dataToUpdate = $"{{""updates"":[{{""row"":{{""last_access"":""{newValue:O}""}},""row_id"":""{rowID}""}}],""table_name"":""SerialNumber""}}"
        ' Mengisi data untuk update

        ' Memanggil fungsi UpdateRowInSeaTable untuk mengupdate data
        Dim result As String = Await LicenseManager.UpdateRowInSeaTable(baseUUID, rowID, accessToken, dataToUpdate)

        ' Menampilkan hasil

        Console.WriteLine(newValue.ToString("O") & ":" & result)
    End Sub

    Private Sub LicenseKey_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Jika form ditutup tanpa aktivasi, kembalikan DialogResult.Cancel
        If Me.DialogResult <> DialogResult.OK Then
            Me.DialogResult = DialogResult.Cancel
        End If
    End Sub

    Private Sub LicenseKey_Load(sender As Object, e As EventArgs) Handles Me.Load
        TxtID.Text = LicenseManager.ApkID
        TxtStatus.Text = LicenseManager.LicenseStatus
        SerialNumber.Text = LicenseManager.SerialNumber

        If String.IsNullOrEmpty(LicenseManager.SerialNumber) Then
            ToggleSwitch1.Visible = False
        Else
            SerialNumber.Enabled = False
        End If
    End Sub

    Private Sub ToggleSwitch1_Toggled(sender As Object, e As EventArgs) Handles ToggleSwitch1.Toggled
        If ToggleSwitch1.IsOn Then
            SerialNumber.Enabled = True
        Else
            SerialNumber.Enabled = False
        End If
    End Sub
End Class