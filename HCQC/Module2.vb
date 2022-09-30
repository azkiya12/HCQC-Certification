Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Security
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions

Module Module2
    Dim ind() As Integer = {1, 2, 3, 4, 5, 9, 10, 50, 100, 500, 900, 1000}
    Dim rom() As String = {"I", "II", "III", "IV", "V", "IX", "X", "L", "C", "D", "CM", "M"}
    Dim limit As Integer = 11
    Dim output As String = ""

    Public Function ConvertToRomanNumeral(ByVal input As String) As String

        output = ""
        If input <> "" Then
            While Convert.ToUInt32(input) > 0
                input = Find(input)
            End While
        End If

        Return output
    End Function

    Public Function Find(ByVal Num As Integer) As Integer
        ''Referen to ConvertTORomanNUmber
        Dim i As Integer = 0
        While ind(i) <= Num
            i += 1
        End While
        If i <> 0 Then
            limit = i - 1
        Else
            limit = 0
        End If
        output = output & rom(limit)
        Num = Num - ind(limit)
        Return Num
    End Function

    ''' <summary>
    ''' Simple encrypting / decrypting in VB.Net
    ''' </summary>
    Public Function Encrypt(ByVal plainText As String) As String

        Dim passPhrase As String = "yourPassPhrase"
        Dim saltValue As String = "mySaltValue"
        Dim hashAlgorithm As String = "SHA1"

        Dim passwordIterations As Integer = 2
        Dim initVector As String = "@1B2c3D4e5F6g7H8"
        Dim keySize As Integer = 256

        Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
        Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)

        Dim plainTextBytes As Byte() = Encoding.UTF8.GetBytes(plainText)


        Dim password As New PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)

        Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)
        Dim symmetricKey As New RijndaelManaged()

        symmetricKey.Mode = CipherMode.CBC

        Dim encryptor As ICryptoTransform = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes)

        Dim memoryStream As New MemoryStream()
        Dim cryptoStream As New CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)

        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length)
        cryptoStream.FlushFinalBlock()
        Dim cipherTextBytes As Byte() = memoryStream.ToArray()
        memoryStream.Close()
        cryptoStream.Close()
        Dim cipherText As String = Convert.ToBase64String(cipherTextBytes)
        Return cipherText
    End Function
    Public Function Decrypt(ByVal cipherText As String) As String
        Dim passPhrase As String = "yourPassPhrase"
        Dim saltValue As String = "mySaltValue"
        Dim hashAlgorithm As String = "SHA1"

        Dim passwordIterations As Integer = 2
        Dim initVector As String = "@1B2c3D4e5F6g7H8"
        Dim keySize As Integer = 256
        ' Convert strings defining encryption key characteristics into byte
        ' arrays. Let us assume that strings only contain ASCII codes.
        ' If strings include Unicode characters, use Unicode, UTF7, or UTF8
        ' encoding.
        Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
        Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)

        ' Convert our ciphertext into a byte array.
        Dim cipherTextBytes As Byte() = Convert.FromBase64String(cipherText)

        ' First, we must create a password, from which the key will be 
        ' derived. This password will be generated from the specified 
        ' passphrase and salt value. The password will be created using
        ' the specified hash algorithm. Password creation can be done in
        ' several iterations.
        Dim password As New PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)

        ' Use the password to generate pseudo-random bytes for the encryption
        ' key. Specify the size of the key in bytes (instead of bits).
        Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)

        ' Create uninitialized Rijndael encryption object.
        Dim symmetricKey As New RijndaelManaged()

        ' It is reasonable to set encryption mode to Cipher Block Chaining
        ' (CBC). Use default options for other symmetric key parameters.
        symmetricKey.Mode = CipherMode.CBC

        ' Generate decryptor from the existing key bytes and initialization 
        ' vector. Key size will be defined based on the number of the key 
        ' bytes.
        Dim decryptor As ICryptoTransform = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes)

        ' Define memory stream which will be used to hold encrypted data.
        Dim memoryStream As New MemoryStream(cipherTextBytes)

        ' Define cryptographic stream (always use Read mode for encryption).
        Dim cryptoStream As New CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)

        ' Since at this point we don't know what the size of decrypted data
        ' will be, allocate the buffer long enough to hold ciphertext;
        ' plaintext is never longer than ciphertext.
        Dim plainTextBytes As Byte() = New Byte(cipherTextBytes.Length - 1) {}

        ' Start decrypting.
        Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)

        ' Close both streams.
        memoryStream.Close()
        cryptoStream.Close()

        ' Convert decrypted data into a string. 
        ' Let us assume that the original plaintext string was UTF8-encoded.
        Dim plainText As String = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount)

        ' Return decrypted string.   
        Return plainText
    End Function

    Function IsValidEmailAddress(ByVal emailAddress As String) As Boolean
        Dim valid As Boolean = True

        Try
            Dim a = New System.Net.Mail.MailAddress(emailAddress)
        Catch ex As FormatException
            valid = False
        End Try
        Return valid
    End Function

    'Fade in Form effect
    Public Sub Fade_in(ByVal Form As Form)
        For FadeIn = 0.0 To 1 Step 0.2
            Form.Opacity = FadeIn
            Form.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub

    'Fade out Form effect
    Public Sub Fade_out(ByVal Form As Form)
        For FadeOut = 90 To 10 Step -10
            Form.Opacity = FadeOut / 100
            Form.Refresh()
            Threading.Thread.Sleep(50)
        Next
    End Sub

    ''Count Number of Verification ne Proses
    Public Function VerificationCount(ByVal objec As Panel) As String
        Dim strValue As String = _DataToValue("SELECT Count([id]) as Count
                      FROM [HCQC_server].[dbo].[qc_confirm_viewer]
                      WHERE [status_confirm]  ='On Process'")
        If strValue <= 0 Then
            objec.Visible = False
        Else
            objec.Visible = True
        End If
        Return strValue
    End Function
End Module
