Imports System.Data.SqlClient
Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks

Public Class LicenseManager
    Public Const ApkID As String = "11ee9d5a-9e50-4a0c-bfd4-a906bf72197d"

    'Token untuk akses ke API SeaTable Cloud 
    Public Shared Property ApiToken As String = "2d6fd3c5bc1b76ca71a142b6352ddcefbe61539f"
    Public Shared Property SerialNumber As String
    Public Shared Property LicenseStatus As String
    Public Shared Property ExpiredDate As Date
    Public Shared Property LastCheckDate As DateTime
    Public Shared Property Row_Id As String

    ' Properti statis untuk menyimpan informasi Token dan BaseUUID
    ' Token API SeaTable Anda
    Public Shared Property access_token As String
    ' UUID dari base yang Anda buat di SeaTable
    Public Shared Property BaseUUID As String

    ' URL endpoint SeaTable API
    Private Const BaseUrl As String = "https://cloud.seatable.io/api/v2.1/dtables/"

    ' Fungsi untuk memverifikasi lisensi
    Public Shared Function CheckLicenseValidity() As (IsValid As Boolean, ErrorCode As Integer)

        ' Logika untuk memeriksa lisensi
        Dim isValid As Boolean = True ' Atau False, sesuai dengan logika lisensi Anda
        Dim errorCode As Integer = 0 ' 0 jika tidak ada error, atau kode error yang sesuai

        ' Query untuk mendapatkan data lisensi
        Dim sql As String = "SELECT [serial_number]
                                  ,[start_date]
                                  ,[end_date]
                                  ,[status]
                                  ,[last_check_date]
                              FROM [HCQC_server].[dbo].[credential_api]"
        openDB()
        Using cmd As New SqlCommand(sql, con)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then

                    ' Ambil data dari database
                    SerialNumber = reader.GetString(0)
                    Dim startDate As Date = reader.GetDateTime(1)
                    ExpiredDate = reader.GetDateTime(2)
                    LicenseStatus = reader.GetString(3)
                    LastCheckDate = reader.GetDateTime(4)

                    Console.WriteLine($"Startdate: {startDate}")
                    Console.WriteLine($"expiredDate: {ExpiredDate}")
                    Console.WriteLine($"LicenseStatus: {LicenseStatus}")

                    ' Cek masa aktif berdasarkan tanggal saat ini
                    Dim currentDate As Date = Date.Now
                    If currentDate >= startDate AndAlso currentDate <= ExpiredDate AndAlso LicenseStatus.ToLower = "active".ToLower Then
                        ' Lisensi valid
                        Console.WriteLine("after login license valid")
                        Return (True, 200)
                    Else
                        ' Lisensi tidak valid atau sudah kadaluarsa
                        Console.WriteLine("after login license not valid")
                        Return (False, 200)
                    End If
                Else

                    ' Data lisensi tidak ditemukan
                    Console.WriteLine("after login license no found")
                    Return (False, 404)
                End If
            End Using
        End Using

    End Function

    Public Shared Async Function CheckLicensePeriodic() As Task(Of (isValid As Boolean, errorMsg As String, errorCode As Integer))

        'Periodic check to seatable
        Dim checkInterval = TimeSpan.FromDays(7)
        Dim isValid As Boolean
        Dim errorCode As Integer = 404
        Dim errorMsg As String = ""

        If DateTime.Now - LastCheckDate >= checkInterval Then
            Console.WriteLine("Check Periodic License")
            ' Lakukan pengecekan ke SeaTable
            If IsNetworkAvailable() Then
                ' Dapatkan Access_token dan Base UUID dari SeaTable
                Dim result As (String, String) = Await LicenseKey.GetBaseToken_SeaTable(LicenseManager.ApiToken)

                LicenseManager.access_token = result.Item1
                LicenseManager.BaseUUID = result.Item2

                ''Get data API SeaTable and update Loca Data
                Dim resultCheckLicenseStatus As (Boolean, String, Integer) = Await LicenseKey.CheckLicenseStatus(SerialNumber)

                isValid = resultCheckLicenseStatus.Item1
                errorMsg = resultCheckLicenseStatus.Item2
                errorCode = resultCheckLicenseStatus.Item3

            Else
                Console.WriteLine("Network Not Aviable")
            End If
        Else
            Console.WriteLine("Periodic interval Pass")
        End If

        Return (isValid, errorMsg, errorCode)
    End Function

    Public Shared Async Function UpdateRowInSeaTable(ByVal baseUUID As String, ByVal rowID As String, ByVal accessToken As String, ByVal dataToUpdate As String) As Task(Of String)
        ' URL SeaTable API untuk update row tertentu
        Dim url As String = $"https://cloud.seatable.io/api-gateway/api/v2/dtables/{baseUUID}/rows/"

        ' Membuat HttpClient untuk mengirim request
        Using client As New HttpClient()
            ' Menambahkan access token ke header Authorization
            client.DefaultRequestHeaders.Authorization = New Headers.AuthenticationHeaderValue("Token", accessToken)

            ' Mengkonversi data yang ingin diupdate ke format JSON
            Dim jsonData As String = dataToUpdate.ToString()

            ' Membuat content yang akan dikirim
            Dim content As New StringContent(jsonData, Encoding.UTF8, "application/json")

            ' Mengirim PATCH request ke SeaTable API
            Try
                Dim response As HttpResponseMessage = Await client.PutAsync(url, content)

                ' Memeriksa apakah request berhasil
                If response.IsSuccessStatusCode Then
                    ' Mendapatkan response sebagai string
                    Dim result As String = Await response.Content.ReadAsStringAsync()
                    Return result ' Mengembalikan hasil response
                Else
                    ' Jika ada error, menampilkan status code
                    Return $"Error:{response.StatusCode} - {response.StatusCode.ToString()}"
                End If
            Catch ex As Exception
                ' Menangkap kesalahan jika request gagal
                Return $"Exception: {ex.Message}"
            End Try
        End Using
    End Function
End Class
