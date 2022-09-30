Imports DgvFilterPopup
Imports MetroFramework
Imports MetroFramework.Forms

Public Class Lead_Time_Gravity
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

    Private Sub Lead_Time_Gravity_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Theme = My.Settings.tema
        Me.MetroStyleManager1.Theme = My.Settings.tema
    End Sub

    Private Sub Lead_Time_Gravity_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub Lead_Time_Gravity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCQC_serverDataSet.leadview' table. You can move, or remove it, as needed.
        Me.LeadviewTableAdapter.Fill(Me.HCQC_serverDataSet.leadview)

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
        Me.LeadviewTableAdapter.Fill(Me.HCQC_serverDataSet.leadview)
    End Sub

    Private Sub MetroButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton2.Click
        'Dim ppd As New PrintPreviewDialog
        ''If (Windows.Forms.DialogResult.OK) Then
        'ppd.Document = PrintDocument1
        'ppd.WindowState = FormWindowState.Maximized
        'ppd.ShowDialog()
        ''End If
        '-----------------------------------------------------
        '*Open the print dialog
        Dim Printdialog1 As New PrintDialog()
        Printdialog1.Document = PrintDocument1
        Printdialog1.UseEXDialog = True
        'Get the document
        If (Printdialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
            PrintDocument1.DocumentName = "Lead Time"
            PrintDocument1.Print()
        End If
        '*
        'Note: In case you want to show the Print Preview Dialog instead of 
        'Print Dialog then comment the above code and uncomment the following code
        '*
    End Sub

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        'MsgBox("starting printpage 1")
        Try
            strFormat.Alignment = StringAlignment.Near
            strFormat.LineAlignment = StringAlignment.Center
            strFormat.Trimming = StringTrimming.EllipsisCharacter

            arrColumnLefts.Clear()
            arrColumnWidths.Clear()
            iCellHeight = 0
            bFirstPage = True
            bNewPage = True
            'Calculating Total Widths
            iTotalWidth = 0
            For Each dgvGridCol As DataGridViewColumn In MetroGrid1.Columns
                iTotalWidth = iTotalWidth + dgvGridCol.Width
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'MsgBox("starting printpage 2")
        Try

            'Set the left margin
            Dim iLeftMargin As Integer = e.MarginBounds.Left
            'Set the top margin
            Dim iTopMargin As Integer = e.MarginBounds.Top

            'Whether more pages have to print or not
            Dim bMorePagesToPrint As Boolean = False
            Dim iTmpWidth As Integer = 0
            'For the first page to print set the cell width and header height
            If bFirstPage = True Then
                For Each Gridcol As DataGridViewColumn In MetroGrid1.Columns
                    iTmpWidth = CType(Math.Floor(CType(CType(Gridcol.Width, Double) / CType(iTotalWidth, Double) * CType(iTotalWidth, Double) * (CType(e.MarginBounds.Width, Double) / CType(iTotalWidth, Double)), Double)), Integer)
                    iHeaderHeight = CType((e.Graphics.MeasureString(Gridcol.HeaderText, Gridcol.InheritedStyle.Font, iTmpWidth).Height) + 11, Integer)

                    'Save width and height of headers
                    arrColumnLefts.Add(iLeftMargin)
                    arrColumnWidths.Add(iTmpWidth)
                    iLeftMargin = iLeftMargin + iTmpWidth
                Next
            End If

            'Loop till all the grid rows not get printed
            'iRow = 0
            While iRow <= MetroGrid1.Rows.Count - 1
                Dim GridRow As DataGridViewRow = MetroGrid1.Rows(iRow)
                'Set the cell height
                iCellHeight = GridRow.Height + 5
                Dim iCount As Integer = 0
                'Check whether the current page settings allo more rows to print
                If iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top Then
                    bNewPage = True
                    bFirstPage = False
                    bMorePagesToPrint = True
                    '********* what should this be **********
                    Exit While
                Else
                    If bNewPage = True Then
                        'Draw header
                        e.Graphics.DrawString("Fibre Requirements", New Font(MetroGrid1.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top - e.Graphics.MeasureString("Customer Summary", New Font(MetroGrid1.Font, FontStyle.Bold), e.MarginBounds.Width).Height - 13)
                        Dim strDate As String = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString()
                        'Draw Date
                        e.Graphics.DrawString(strDate, New Font(MetroGrid1.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width - e.Graphics.MeasureString(strDate, New Font(MetroGrid1.Font, FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top - e.Graphics.MeasureString("Customer Summary", New Font(New Font(MetroGrid1.Font, FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13)
                        'Draw Columns                 
                        iTopMargin = e.MarginBounds.Top
                        For Each GridCol As DataGridViewColumn In MetroGrid1.Columns
                            e.Graphics.FillRectangle(New SolidBrush(Color.LightGray), New Rectangle(CType(arrColumnLefts(iCount), Integer), iTopMargin, CType(arrColumnWidths(iCount), Integer), iHeaderHeight))
                            e.Graphics.DrawRectangle(Pens.Black, New Rectangle(CType(arrColumnLefts(iCount), Integer), iTopMargin, CType(arrColumnWidths(iCount), Integer), iHeaderHeight))
                            e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font, New SolidBrush(GridCol.InheritedStyle.ForeColor), New RectangleF(CType(arrColumnLefts(iCount), Integer), iTopMargin, CType(arrColumnWidths(iCount), Integer), iHeaderHeight), strFormat)
                            iCount = iCount + 1
                        Next GridCol
                        bNewPage = False
                        iTopMargin += iHeaderHeight
                    End If
                    iCount = 0
                    'Draw Columns Contents                
                    For Each Cel As DataGridViewCell In GridRow.Cells
                        If Not IsDBNull(Cel.Value) Then
                            e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font, New SolidBrush(Cel.InheritedStyle.ForeColor), New RectangleF(CType(arrColumnLefts(iCount), Integer), CType(iTopMargin, Single), CType(arrColumnWidths(iCount), Integer), CType(iCellHeight, Single)), strFormat)
                        End If
                        'Drawing Cells Borders 
                        e.Graphics.DrawRectangle(Pens.Black, New Rectangle(CType(arrColumnLefts(iCount), Integer), iTopMargin, CType(arrColumnWidths(iCount), Integer), iCellHeight))
                        iCount = iCount + 1
                    Next
                End If
                iRow = iRow + 1
                iTopMargin = iTopMargin + iCellHeight
            End While
            'If more lines exist, print another page.
            If bMorePagesToPrint = True Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch exc As Exception
            MessageBox.Show(exc.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LeadviewBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeadviewBindingSource.CurrentChanged

    End Sub
End Class