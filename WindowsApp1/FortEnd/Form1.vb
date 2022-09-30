Imports System.IO
Imports ZXing
Imports ZXing.Common
Imports ZXing.QrCode
Public Class Form1

    Dim saveFileDialog1 As New SaveFileDialog()
    Dim QR_Generate As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Size = New Size(1027, 450)

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        'Timer1.Start()
        Me.Close()
    End Sub

    Private Sub BunifuFlatButton1_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel1.MouseLeave

    End Sub

    Private Sub LinkLabel1_Click(sender As Object, e As EventArgs) Handles LinkLabel1.Click
        If Containerusermenu1.Visible = False Then
            BunifuTransition1.ShowSync(Containerusermenu1, False, BunifuAnimatorNS.Animation.VertSlide)
            LinkLabel1.LinkColor = Color.Black
        Else
            Containerusermenu1.Visible = False
            LinkLabel1.LinkColor = Color.White
        End If
    End Sub

    'Fungsion untuk Convert Bitmap to Byte Array
    Public Shared Function ConvertToByteArray(ByVal value As Bitmap) As Byte()
        Dim bitmapBytes As Byte()
        Using stream As New System.IO.MemoryStream
            value.Save(stream, System.Drawing.Imaging.ImageFormat.Png)
            bitmapBytes = stream.ToArray
        End Using
        Return bitmapBytes
    End Function

    ''Fungsion untuk membuat QRCODE
    Public Function EncodeQrCode(ByVal barcodeValue As String, ByVal barcodeSize As Int32) As Bitmap
        Dim writer = New BarcodeWriter() With
            {
            .Format = BarcodeFormat.QR_CODE,
            .Options = New EncodingOptions() With {.Height = barcodeSize, .Width = barcodeSize, .Margin = 1}
            }
        Return writer.Write(barcodeValue)
    End Function
    Private Sub MetroPanel1_MouseEnter(sender As Object, e As EventArgs) Handles MetroPanel1.MouseEnter
        Containerusermenu1.Visible = False
        LinkLabel1.LinkColor = Color.White
    End Sub

    Private Sub MetroTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MetroTextBox1.TextChanged
        Try
            Me.PictureBox1.Image = EncodeQrCode(Me.MetroTextBox1.Text, CType(PictureBox1.Size.Width, Int32))
        Catch ex As Exception

        End Try
    End Sub

    Sub saveImagetoDrive()
        'Save picturebox to *.png file
        Try
            saveFileDialog1.Filter = "PNG Image|*.png"
            saveFileDialog1.FileName = "QR_Code.png"
            Dim img As New Bitmap(PictureBox1.Image)
            If saveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                img.Save(saveFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub ShowReport()
        'Filling Products DataTable from DB
        Dim ta As New DatasetBarCodeTableAdapters.harvestprodTableAdapter
        Dim dt As New DatasetBarCode.harvestprodDataTable
        ta.Fill(dt)

        Dim row As DatasetBarCode.harvestprodRow
        For Each row In dt.Rows
            'Converting BItmap to Byte Array
            row.Barcode = ConvertToByteArray(EncodeQrCode(row.idcode.ToString(), 50))
        Next

        'Create a AveryMailLabels report object
        'and set its data source with the DataSet
        Dim report As New QRcodeprint '--file Crystal Report yg akan tampil

        'Dim rptFile As String = Server.MapPath("CrystalReportBarcode.rpt")
        'report.Load(rptFile)
        report.SetDataSource(CType(dt, DataTable))

        Me.CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        'saveImagetoDrive()
        ShowReport()
    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        upload_file.ShowDialog(Me)
    End Sub
End Class
