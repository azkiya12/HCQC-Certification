Imports System.Drawing.Printing
Public Class Select_Printer

    Friend Event SavedOptions(ByVal strData As String)
    Private Sub Select_Printer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pkInstalledPrinters As String

        ' Find all printers installed
        For Each pkInstalledPrinters In
            PrinterSettings.InstalledPrinters
            MetroComboBox1.Items.Add(pkInstalledPrinters)
        Next pkInstalledPrinters

        ' Set the combo to the first printer in the list
        MetroComboBox1.SelectedIndex = 0
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        RaiseEvent SavedOptions(MetroComboBox1.Items(MetroComboBox1.SelectedIndex).ToString)
        Close()
    End Sub

    Private Sub Select_Printer_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub LinkCalibrate_Click(sender As Object, e As EventArgs) Handles LinkCalibrate.Click
        If MetroComboBox1.Text.Contains("ZPL") Then
            Dim calibration As String
            calibration = "~jc^xa^jus^xz"
            Printer.RawHelper.SendStringToPrinter(MetroComboBox1.Text, calibration)
        Else
            MetroMessageBox.Show(Me, "Calibrasi Label hanya untuk printer ZebraZPL")
        End If
    End Sub
End Class