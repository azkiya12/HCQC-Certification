Imports DgvFilterPopup
Imports MetroFramework
Imports MetroFramework.Forms
Public Class Lead_Time_RM
    Private Structure pageDetails
        Dim columns As Integer
        Dim rows As Integer
        Dim startCol As Integer
        Dim startRow As Integer
    End Structure
    Private pages As Dictionary(Of Integer, pageDetails)
    Dim maxPagesWide As Integer
    Dim maxPagesTall As Integer
    'Used to save left coordinates of columns
    Dim arrColumnLefts = New ArrayList()
    'Used to save column widths
    Dim arrColumnWidths = New ArrayList()
    'Used to get and set the datagridview cell height
    Dim iCellHeight As Integer = 0
    Dim iTotalWidth As Integer = 0
    'Used as counter
    Dim iCount As Integer = 0
    Dim iRow As Integer = 0
    'Used to check whether we are printing first page
    Dim bFirstPage As Boolean = False
    'Used to check whether we are printing a new page
    Dim bNewPage As Boolean = False
    'Used for the header height
    Dim iHeaderHeight As Integer = 0

    Dim strFormat = New StringFormat()

    Private Sub Lead_Time_RM_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Theme = My.Settings.tema
        Me.MetroStyleManager1.Theme = My.Settings.tema
    End Sub

    Private Sub Lead_Time_RM_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub Lead_Time_RM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCQC_serverDataSet.rm_leadtime' table. You can move, or remove it, as needed.
        Me.Rm_leadtimeTableAdapter.Fill(Me.HCQC_serverDataSet.rm_leadtime)

        Dim DgvFilter As New DgvFilterManager
        DgvFilter.DataGridView = MetroGrid1
        MetroGrid1.ColumnHeadersHeight = 25
    End Sub

    Private Sub MetroGrid1_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles MetroGrid1.DataBindingComplete
        'Hightlight list whit specific character
        If My.Settings.tema = MetroThemeStyle.Dark Then
            For Each row As DataGridViewRow In MetroGrid1.Rows
                If Not IsDBNull(row.Cells("ESTIMASI").Value) Then
                    If row.Cells("ESTIMASI").Value < Today.AddDays(+2) And IsDBNull(row.Cells("vg_tgl_input").Value) Then
                        row.DefaultCellStyle.BackColor = Color.FromArgb(0, 7, 35)
                    End If
                End If
            Next
        ElseIf My.Settings.tema = MetroThemeStyle.Light Then
            For Each row As DataGridViewRow In MetroGrid1.Rows
                If Not IsDBNull(row.Cells("ESTIMASI").Value) Then
                    If row.Cells("ESTIMASI").Value < Today.AddDays(+2) And IsDBNull(row.Cells("vg_tgl_input").Value) Then
                        row.DefaultCellStyle.BackColor = Color.Cornsilk
                    End If
                End If
            Next
        End If

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

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        Me.Rm_leadtimeTableAdapter.Fill(Me.HCQC_serverDataSet.rm_leadtime)
    End Sub
End Class