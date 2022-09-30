Imports DgvFilterPopup
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports MetroFramework
Imports MetroFramework.Forms
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommandBuilder
Imports System.Data

Public Class Data_List_Finish_Goods

    Private Sub Data_List_Finish_Goods_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Theme = My.Settings.tema
        'Me.Style = My.Settings.gaya
        Me.MetroStyleManager1.Theme = My.Settings.tema
        'Me.MetroStyleExtender1.Theme = My.Settings.tema
        'Me.MetroStyleManager1.Style = My.Settings.gaya
    End Sub

    Private Sub Data_List_Finish_Goods_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCQC_serverDataSet.Archive_fg' table. You can move, or remove it, as needed.
        Me.Archive_fgTableAdapter.Fill(Me.HCQC_serverDataSet.Archive_fg)
        'TODO: This line of code loads data into the 'HCQC_serverDataSet.fg_id' table. You can move, or remove it, as needed.
        Me.Fg_idTableAdapter.FillBy(Me.HCQC_serverDataSet.fg_id)
        'TODO: This line of code loads data into the 'HCQC_serverDataSet.FinishGdJoin' table. You can move, or remove it, as needed.
        Me.FinishGdJoinTableAdapter.Fill(Me.HCQC_serverDataSet.FinishGdJoin)

        ''METROGRID1
        Dim DgvFilter As New DgvFilterManager
        DgvFilter.DataGridView = MetroGrid1
        MetroGrid1.ColumnHeadersHeight = 25

        ''METROGRID2
        Dim DgvFilter2 As New DgvFilterManager
        DgvFilter2.DataGridView = MetroGrid3
        MetroGrid3.ColumnHeadersHeight = 25
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

    Private Sub MetroGrid2_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles MetroGrid3.RowPostPaint
        'penomoran pada MetroGrid1 view
        MetroGrid3 = DirectCast(sender, DataGridView)
        Dim rowNumber As String = (e.RowIndex + 1).ToString()
        While rowNumber.Length < MetroGrid3.RowCount.ToString().Length
            rowNumber = "0" & rowNumber
        End While

        Dim size As SizeF = e.Graphics.MeasureString(rowNumber, Me.Font)
        If MetroGrid3.RowHeadersWidth < CInt(size.Width + 20) Then
            MetroGrid3.RowHeadersWidth = CInt(size.Width + 20)
        End If

        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(rowNumber, MetroGrid1.Font, b, e.RowBounds.Location.X + 15, _
        e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        'TODO: This line of code loads data into the 'HCQC_serverDataSet.FinishGdJoin' table. You can move, or remove it, as needed.
        Me.FinishGdJoinTableAdapter.Fill(Me.HCQC_serverDataSet.FinishGdJoin)
        'TODO: This line of code loads data into the 'HCQC_serverDataSet.fg_id' table. You can move, or remove it, as needed.
        Me.Fg_idTableAdapter.FillBy(Me.HCQC_serverDataSet.fg_id)
    End Sub
End Class