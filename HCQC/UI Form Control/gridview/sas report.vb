Imports DgvFilterPopup

Public Class sas_report
    Private Sub sas_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCQC_serverDataSet.report_gravity_sas' table. You can move, or remove it, as needed.
        Me.Report_gravity_sasTableAdapter.Fill(Me.HCQC_serverDataSet.report_gravity_sas)

        Dim DgvFilter As New DgvFilterManager
        DgvFilter.DataGridView = MetroGrid1
        MetroGrid1.ColumnHeadersHeight = 25
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        'TODO: This line of code loads data into the 'HCQC_serverDataSet.report_gravity_sas' table. You can move, or remove it, as needed.
        Me.Report_gravity_sasTableAdapter.Fill(Me.HCQC_serverDataSet.report_gravity_sas)
    End Sub

    Private Sub MetroGrid1_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles MetroGrid1.RowPostPaint
        'penomoran pada MetroGrid view
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
        e.Graphics.DrawString(rowNumber, MetroGrid1.Font, b, e.RowBounds.Location.X + 15,
        e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click

        openDB()
        Dim sqlComm As New SqlClient.SqlCommand("sp_ReportPrintsas", con)
        Try
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.ExecuteNonQuery()
            MetroMessageBox.Show(Me, "Good job...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Something trouble in the Update Print : ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, 211)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub sas_report_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.Containermenu2.BtnListReportSas.Enabled = True
    End Sub
End Class