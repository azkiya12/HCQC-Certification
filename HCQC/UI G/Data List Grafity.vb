Imports DgvFilterPopup
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports MetroFramework
Imports MetroFramework.Forms
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommandBuilder
Imports System.Data
Public Class Data_List_Grafity

    Private Sub Data_List_Grafity_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Theme = My.Settings.tema
        Me.MetroStyleManager1.Theme = My.Settings.tema
    End Sub

    Private Sub Data_List_Grafity_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub Data_List_Grafity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCQC_serverDataSet.GrafitiJoin' table. You can move, or remove it, as needed.
        Me.GrafitiJoinTableAdapter.Fill(Me.HCQC_serverDataSet.GrafitiJoin)
        'TODO: This line of code loads data into the 'HCQC_serverDataSet.GrafityNewJoin' table. You can move, or remove it, as needed.
        Me.GrafityNewJoinTableAdapter.Fill(Me.HCQC_serverDataSet.GrafityNewJoin)

        ''METROGRID1
        Dim DgvFilter As New DgvFilterManager
        DgvFilter.DataGridView = MetroGrid1
        MetroGrid1.ColumnHeadersHeight = 25
        ''METROGRID2
        Dim DgvFilter2 As New DgvFilterManager
        DgvFilter2.DataGridView = MetroGrid2
        MetroGrid2.ColumnHeadersHeight = 25
    End Sub

    Private Sub MetroGrid1_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles MetroGrid1.RowPostPaint
        'penomoran pada MetroGrid1 view
        MetroGrid1 = DirectCast(sender, DataGridView)
        Dim rowNumber As String = (e.RowIndex + 1).ToString()
        While rowNumber.Length < MetroGrid1.RowCount.ToString().Length
            rowNumber = "0" & rowNumber
        End While

        Dim size As SizeF = e.Graphics.MeasureString(rowNumber, Me.Font)
        If MetroGrid1.RowHeadersWidth < CInt(size.Width + 20) Then
            MetroGrid1.RowHeadersWidth = CInt(size.Width + 20)
        End If

        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(rowNumber, MetroGrid1.Font, b, e.RowBounds.Location.X + 15, _
        e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

    Private Sub MetroGrid2_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles MetroGrid2.RowPostPaint
        'penomoran pada MetroGrid2 view
        MetroGrid2 = DirectCast(sender, DataGridView)
        Dim rowNumber As String = (e.RowIndex + 1).ToString()
        While rowNumber.Length < MetroGrid1.RowCount.ToString().Length
            rowNumber = "0" & rowNumber
        End While

        Dim size As SizeF = e.Graphics.MeasureString(rowNumber, Me.Font)
        If MetroGrid2.RowHeadersWidth < CInt(size.Width + 20) Then
            MetroGrid2.RowHeadersWidth = CInt(size.Width + 20)
        End If

        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(rowNumber, MetroGrid1.Font, b, e.RowBounds.Location.X + 15, _
        e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub
    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        Me.GrafityNewJoinTableAdapter.Fill(Me.HCQC_serverDataSet.GrafityNewJoin)
        Me.GrafitiJoinTableAdapter.Fill(Me.HCQC_serverDataSet.GrafitiJoin)
    End Sub
End Class