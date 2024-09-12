Imports System.Configuration
Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json.Linq
Imports System.Security.Cryptography

Public Class Form1

    'Fungsi yang akan melakukan request Get secara asinkron dan mengembalikan hasil konten 
    'sebagai String. Fungsi ini juga menangani error secara sederhana 
    'dengan menampilkan pesan jika ada kesalahan.
    Public Async Function GetWebContentAsync(ByVal url As String) As Task(Of String)
        ' Membuat instance HttpClient
        Using client As New HttpClient()
            Try
                ' Mengirimkan permintaan GET ke URL
                Dim response As HttpResponseMessage = Await client.GetAsync(url)

                ' Memastikan request berhasil dengan status code 200
                response.EnsureSuccessStatusCode()

                ' Membaca konten respons
                Dim content As String = Await response.Content.ReadAsStringAsync()

                Return content ' Kembalikan konten sebagai string
            Catch ex As Exception
                MessageBox.Show("Error during HTTP request: " & ex.Message)
                Return Nothing
            End Try
        End Using
    End Function


    'Fungsi ini akan mengirimkan data dalam format JSON ke endpoint API SeaTable dan 
    'mengembalikan True jika permintaan berhasil, atau False jika terjadi kegagalan.
    'Jika Anda ingin menambah data ke SeaTable, Anda dapat menggunakan request POST
    Public Async Function PostDataToSeaTable(ByVal apiUrl As String, ByVal accessToken As String, ByVal data As JObject) As Task(Of Boolean)
        ' Membuat instance HttpClient
        Using client As New HttpClient()
            Try
                ' Menambahkan header Authorization
                client.DefaultRequestHeaders.Authorization = New System.Net.Http.Headers.AuthenticationHeaderValue("Token", accessToken)

                ' Mengonversi data JSON ke format StringContent
                Dim jsonContent As StringContent = New StringContent(data.ToString(), System.Text.Encoding.UTF8, "application/json")

                ' Mengirim permintaan POST ke API
                Dim response As HttpResponseMessage = Await client.PostAsync(apiUrl, jsonContent)

                ' Memeriksa jika request berhasil
                If response.IsSuccessStatusCode Then
                    Return True
                Else
                    MessageBox.Show("Failed to post data. Status Code: " & response.StatusCode.ToString())
                    Return False
                End If
            Catch ex As Exception
                MessageBox.Show("Error during POST request: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    'implementasi menggunakan HttpClient di VB.NET untuk mengakses SeaTable
    Public Async Function SeaTableLoginAsync(ByVal apiToken As String) As Task(Of (String, String))
        Try
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
            Dim accessToken As String = jsonResponse("access_token").ToString()
            Dim dtable_uuid As String = jsonResponse("dtable_uuid").ToString()
            Console.WriteLine(accessToken)
            Console.WriteLine(dtable_uuid)
            Return (accessToken, dtable_uuid)
        Catch ex As Exception
            Console.WriteLine("Login Error: " & ex.Message)
            Return Nothing
        End Try
    End Function

    'Mengambil Data dari SeaTable Base: Setelah login dan mendapatkan akses token, 
    'Anda bisa menggunakan token ini untuk mengakses data dari Base SeaTable.
    Public Async Function GetSeaTableDataAsync(ByVal baseUrl As String, ByVal accessToken As String) As Task(Of JArray)
        Try
            ' Membuat instance HttpClient
            Using client As New HttpClient()
                ' Menambahkan token akses ke header
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " & accessToken)

                ' Mengirimkan GET request untuk mendapatkan data
                Dim response As HttpResponseMessage = Await client.GetAsync(baseUrl)
                response.EnsureSuccessStatusCode()

                ' Membaca konten respons
                Dim content As String = Await response.Content.ReadAsStringAsync()

                ' Parsing respons JSON untuk mendapatkan data sebagai JArray
                Dim jsonResponse As JObject = JObject.Parse(content)
                Dim rows As JArray = jsonResponse("rows").ToObject(Of JArray)()

                Return rows ' Kembalikan data dalam format JArray
            End Using
        Catch ex As Exception
            Console.WriteLine("Error fetching data: " & ex.Message)
            Return Nothing
        End Try
    End Function


    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Dapatkan token API dari SeaTable
        Dim apiToken As String = "d2ccc17a4e704dd20e23197a745c11fee6472223"
        Dim result As (String, String) = Await SeaTableLoginAsync(apiToken)

        Dim accessToken As String = result.Item1
        Dim base_uuid As String = result.Item2

        ' URL base SeaTable yang ingin diakses
        '"/api-gateway/api/v2/dtables/" & base_uuid & "/rows/PWDCv97CTg2BlUGuPYsYYw/?table_name=SerialNumber&convert_keys=true"
        Dim baseUrl As String = "https://cloud.seatable.io/api-gateway/api/v2/dtables/" & base_uuid & "/rows/?table_name=SerialNumber&convert_keys=true"

        ' Mengambil data dari SeaTable
        Dim data As JArray = Await GetSeaTableDataAsync(baseUrl, accessToken)

        ' Menampilkan data pada console (atau masukkan ke dalam DataGridView)
        If data IsNot Nothing Then
            For Each row As JObject In data
                Console.WriteLine(row("key").ToString())
            Next
        End If
    End Sub
End Class