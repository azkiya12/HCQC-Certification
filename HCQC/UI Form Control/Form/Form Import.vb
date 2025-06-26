Imports System.IO
Imports System.Net

Public Enum FormCaller
    None = 0
    Harvest_Planning = 1
    Multy_Request_Sample = 2
End Enum

Public Class Form_Import
    Public Property CallerSource As String
    Private Sub Import_Data_Excel1_Load(sender As Object, e As EventArgs) Handles Import_Data_Excel1.Load

    End Sub
    Private Sub OnUploadCompleted(sender As Object, e As EventArgs)
        ' Tutup form ketika upload selesai
        Me.Close() '
    End Sub

    Private Sub Form_Import_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Import_Data_Excel1.UploadCompleted, AddressOf OnUploadCompleted
    End Sub
End Class