Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommandBuilder
Imports System.Globalization
Imports System.Data
Imports MetroFramework

Module Module1
    Public formatDate() As String = {"dd/MM/yyyy", "d/M/yyyy", "dd-MM-yyyy"}
    Public con As SqlClient.SqlConnection
    Public cmd As SqlClient.SqlCommand
    Public cmdmt As SqlClient.SqlCommand
    Public cmdpa As SqlClient.SqlCommand
    Public cmdir As SqlClient.SqlCommand
    Public cmdvg As SqlClient.SqlCommand
    Public dread As SqlClient.SqlDataReader
    Public strupdate As Integer = 0
    Dim mydatatable As DataTable
    Public adapter As SqlClient.SqlDataAdapter
    Private bindingSource1 As New BindingSource()
    Public CurrentCulture = New CultureInfo("id-ID")
    Public Function openDB() As Boolean
        'membuka database, namun outputnya sebagai boolean (true/false), anda bisa menggunakan untuk cek koneksi database
        con = New SqlConnection With {
            .ConnectionString = "Data Source=10.15.13.91\SQLEXPRESS;Initial CataLog=HCQC_server;User ID=admin;Password=administrator"
        }
        Try
            con.Open()
            Return True
        Catch ex As Exception
            MsgBox("Terjadi Error Koneksi Database : " & ex.Message)
            Return False
        End Try

    End Function
    Public Sub _ComboData(ByVal Sql As String, ByVal obj As Object)
        ''berguna jika anda ingin mengisi sebuah combobox dengan isi field pada database
        ''contoh : _ComboData("Select nama_barang from barang",Me.ComboBox1)
        openDB()
        cmd = New SqlCommand(Sql, con)
        Try
            obj.items.clear()

            dread = cmd.ExecuteReader

            While dread.Read()
                obj.items.add(dread.Item(0).ToString)
            End While

        Catch ex As Exception
            MsgBox("error _ComboData Load")

        Finally
            con.Close()
            con = Nothing
        End Try

    End Sub

    Public Sub _TableData(ByVal sql As String, ByVal obj As Object)
        ''untuk menampilkan data pada DataGridView dengan cepat, hanya 1 baris kode saja
        ''contoh : _TableData("Select * from barang",Me.DataGridView1)
        openDB()
        'cmd = New SqlClient.SqlCommand(sql, con)
        Try
            Dim da As New SqlDataAdapter(sql, con)
            Dim ds As New DataSet
            da.Fill(ds)
            Dim dt As New DataTable
            For Each dt In ds.Tables
                obj.DataSource = dt
            Next
        Catch ex As Exception
            MsgBox("Terjadi Error:" & ex.Message)
        Finally
            'dread.Close()
            con.Close()
        End Try
    End Sub

    Public Function _DataToValue(ByVal sql As String) As String
        '' Jika anda hanya menginginkan output 1 data bertipe string saja, maka anda membutuhkan fungsi ini. 
        '' Contoh event klik saat combobox yang menampilkan nama barang pada TextBox1 menampilkan kode barangnya
        '' Me.TextBox1.Text = _DataToValue("Select kode_barang from Barang Where nama_barang='" & Me.ComboBox1.Text & "'")

        openDB()
        cmd = New SqlClient.SqlCommand
        Try
            Dim p As String = ""
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader

            If dread.HasRows Then
                dread.Read()
                p = (dread.Item(0))
            End If

            Return p.ToString

        Catch ex As Exception
            Return ex.Message
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Function

    Public Function _DataToValueDate(ByVal sql As String) As Date
        ''Jika anda hanya menginginkan output 1 data bertipe datetime saja, maka anda membutuhkan fungsi ini. 
        'Contoh event klik saat combobox yang menampilkan nama barang pada TextBox1 menampilkan kode barangnya
        ''Me.TextBox1.Text = _DataToValue("Select kode_barang from Barang Where nama_barang='" & Me.ComboBox1.Text & "'")

        openDB()
        cmd = New SqlClient.SqlCommand
        Try
            Dim p As String
            p = ""
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dread = cmd.ExecuteReader

            If dread.HasRows Then
                dread.Read()
                p = (dread.Item(0))
            End If

            Return p.ToString

        Catch ex As Exception
            Return ex.Message
        Finally
            'dread.Close()
            con.Close()
        End Try
    End Function


    Public Sub _RunSQL(ByVal sql As String)
        ''Mengalami Insert,Edit,Delete yang kodenya ribet? Cukup panggil fungsi ini
        openDB()
        cmd = New SqlClient.SqlCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            'MessageBox.Show
            MetroFramework.MetroMessageBox.Show(Form.ActiveForm, "Sucsess  " + Left(sql, 7) + "..." + Right(sql, 31), Form.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            strupdate = 1
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Form.ActiveForm, "Error x: " & ex.Message & sql, Form.ActiveForm.Text, MessageBoxButtons.OK, 211)
            Return
            strupdate = 0
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub _RunSQL_nomsgbox(ByVal sql As String)
        ''Mengalami Insert,Edit,Delete yang kodenya ribet? Cukup panggil fungsi ini
        openDB()
        cmd = New SqlClient.SqlCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            'MessageBox.Show
            'MetroFramework.MetroMessageBox.Show(Form.ActiveForm, "Sucsess  " + Left(sql, 7) + "..." + Right(sql, 31), Form.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            strupdate = 1
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Form.ActiveForm, "Error x: " & ex.Message, Form.ActiveForm.Text, MessageBoxButtons.OK, 211)
            Return
            strupdate = 0
        Finally

            con.Close()
        End Try
    End Sub

    Function _isBOF(ByVal table As String, ByVal field As String, ByVal whereValue As Object) As Boolean
        'Gunakan fungsi ini untuk mengecek data ada atau tidak , Contoh :
        'If _isBOF("NamaField", "NamaTable", "Nilai") = False Then
        '    MsgBox("Barang tidak ada")
        'Else
        '    MsgBox("Barang Ada")
        'End If

        Dim p As Integer
        p = _DataToValue("Select count(" & field & ") from " & table & " Where " & field & " = '" & whereValue & "'")
        If 0 < p Then
            Return True
        Else
            Return False
        End If

    End Function

    Function _isBOFAND(ByVal table As String, ByVal field As String, ByVal whereValue As Object) As Boolean
        'Gunakan fungsi ini untuk mengecek data ada atau tidak , Contoh :
        'If _isBOF("barang", "kode_barang", "0001") = False Then
        '    MsgBox("Barang tidak ada")
        'Else
        '    MsgBox("Barang Ada")
        'End If

        Dim p As Integer
        p = _DataToValue("Select count(" & field & ") from " & table & " Where " & field & " = '" & whereValue & "' AND delete_at IS NULL")
        If 0 < p Then
            Return True
        Else
            Return False
        End If

    End Function

    Function _isBOFAND2(ByVal table As String, ByVal field As String, ByVal whereValue As Object, ByVal field2 As String, ByVal wherevalue2 As Object) As Boolean
        'Gunakan fungsi ini untuk mengecek data ada atau tidak , Contoh :
        'If _isBOF("barang", "kode_barang", "0001") = False Then
        '    MsgBox("Barang tidak ada")
        'Else
        '    MsgBox("Barang Ada")
        'End If

        Dim p As Integer
        p = _DataToValue("Select count(" & field & ") from " & table & " Where " & field & " = '" & whereValue & "' AND " & field2 & " = '" & wherevalue2 & "'")
        If 0 < p Then
            Return True
        Else
            Return False
        End If

    End Function
    Sub Clear(ByVal frm As Form)
        Dim ctrl As Control
        Dim txtControl As TextBox
        Dim cmdControl As ComboBox
        Dim chkControl As CheckBox
        For Each ctrl In frm.Controls
            If TypeOf ctrl Is TextBox Then
                txtControl = ctrl
                txtControl.Text = ""
            ElseIf TypeOf ctrl Is ComboBox Then
                cmdControl = ctrl
                cmdControl.Text = ""
            ElseIf TypeOf ctrl Is CheckBox Then
                chkControl = ctrl
                chkControl.Checked = False
            End If
        Next
    End Sub

    Public Sub MetroClear(ByVal frm As MetroFramework.Forms.MetroForm)
        Dim ctrl As Control
        Dim txtControl As TextBox
        Dim cmdControl As ComboBox
        Dim chkControl As CheckBox
        For Each ctrl In frm.Controls
            If TypeOf ctrl Is TextBox Then
                txtControl = ctrl
                txtControl.Text = ""
            ElseIf TypeOf ctrl Is ComboBox Then
                cmdControl = ctrl
                cmdControl.Text = ""
            ElseIf TypeOf ctrl Is CheckBox Then
                chkControl = ctrl
                chkControl.Checked = False
            End If
        Next
    End Sub

    Public Function GetIPAddress() As String
        GetIPAddress = String.Empty
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)

        For Each ipheal As System.Net.IPAddress In iphe.AddressList
            If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                GetIPAddress = ipheal.ToString()
            End If
        Next

    End Function

    Public Function ReadDataFromDatabase(ByVal labnum As String, ByVal controls As Dictionary(Of String, Control)) As Boolean
        'Function untuk manmpilkan identitas secara dinamis, contoh:

        'Dim controls As New Dictionary(Of String, Control) From {
        '        {"id", TextBox1},
        '        {"variety", TexBox2},
        '        {"farmer", Label1},
        '        {"location", Label2},
        '        {"harvest", LharvestGer},
        '        {"job", LjobGer}
        '    }
        'ReadDataFromDatabase(tlabnumGer.Text, controls)

        Try
            openDB()
            Dim sql As String = "SELECT [id], CONCAT([nomnl], ' - ', [nojob]) as job, [variety], [farmer], [location], [harvest]  
                             FROM [qc_confirm_viewer] WHERE (labnum = @labnum)"
            Using cmd As New SqlClient.SqlCommand(sql, con)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@labnum", labnum)
                Dim dread As SqlDataReader = cmd.ExecuteReader()
                If dread.Read() Then
                    For Each kvp As KeyValuePair(Of String, Control) In controls
                        Dim fieldName As String = kvp.Key
                        Dim control As Control = kvp.Value
                        If dread.Item(fieldName) IsNot DBNull.Value Then
                            control.Text = dread.Item(fieldName)
                        Else
                            control.Text = ""
                        End If
                    Next
                    Return True ' Data berhasil dibaca
                End If
            End Using
        Catch ex As Exception
            MetroMessageBox.Show(Form.ActiveForm, "Error ID Sample: " + ex.Message, Form.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, 211)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
        Return False ' Data tidak ditemukan atau terjadi kesalahan
    End Function

    Public Function GetData(ByVal columns As String, ByVal tableName As String, ByVal filter As String) As DataTable
        ' Function untuk mendapatkan data dengan menentukan kolom/field, table, filter
        ' contoh penggunaan

        'Dim columns As String = "kode_barang, nama_barang"
        'Dim tableName As String = "Barang"
        'Dim filter As String = "kategori = 'Alat Tulis'"

        'Dim data As DataTable = GetData(columns, tableName, filter)
        'DataGridView1.DataSource = data

        Dim dataTable As New DataTable()

        ' Membuat koneksi database
        openDB()

        Using con As New SqlConnection("connectionString")
            ' Membuat objek command
            Using cmd As New SqlCommand()
                ' Menetapkan koneksi ke command
                cmd.Connection = con
                ' Menetapkan jenis perintah sebagai teks
                cmd.CommandType = CommandType.Text
                ' Membangun query SQL berdasarkan parameter
                cmd.CommandText = $"SELECT {columns} FROM {tableName} WHERE {filter}"

                Try
                    ' Membuka koneksi
                    con.Open()
                    ' Membuat adapter data
                    Using adapter As New SqlDataAdapter(cmd)
                        ' Mengisi data ke DataTable
                        adapter.Fill(dataTable)
                    End Using
                Catch ex As Exception
                    ' Menampilkan pesan kesalahan jika terjadi
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using

        Return dataTable
    End Function
End Module
