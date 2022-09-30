Public Class Print_Label
    Private Sub Print_Label_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Hide default button
        CrystalReportViewer1.ShowPrintButton = False

        ' New print button
        For Each ctrl As Control In CrystalReportViewer1.Controls
            If TypeOf ctrl Is System.Windows.Forms.ToolStrip Then
                Dim btnNew As New ToolStripButton
                btnNew.Text = "Print"
                btnNew.ToolTipText = "Print"
                btnNew.Image = My.Resources.print_30px
                btnNew.DisplayStyle = ToolStripItemDisplayStyle.Image

                CType(ctrl, ToolStrip).Items.Insert(0, btnNew)
                ''Menambah properti btnClik yang di alamatkan ke tsItem_click
                AddHandler btnNew.Click, AddressOf tsItem_Click
            End If
        Next
        ' ---------------------------------------------
    End Sub

    Private Sub tsItem_Click(sender As System.Object, e As System.EventArgs)
        '' Put your code here, before print
        '-------------------------------------------
        Dim printDialog As PrintDialog = New PrintDialog()
        Dim dr As DialogResult = printDialog.ShowDialog()
        If dr = DialogResult.OK Then
            Dim crReportDocument As ReportDocument = CType(CrystalReportViewer1.ReportSource, ReportDocument)

            Dim printDocument1 As System.Drawing.Printing.PrintDocument = New System.Drawing.Printing.PrintDocument()
            'Dim nCopy As Integer = printDocument1.PrinterSettings.Copies
            'Dim sPage As Integer = printDocument1.PrinterSettings.FromPage
            'Dim ePage As Integer = printDocument1.PrinterSettings.ToPage
            Dim nCopy As Integer = printDialog.PrinterSettings.Copies
            Dim cColl As Boolean = printDialog.PrinterSettings.Collate
            Dim sPage As Integer = printDialog.PrinterSettings.FromPage
            Dim ePage As Integer = printDialog.PrinterSettings.ToPage
            crReportDocument.PrintOptions.PrinterName = printDialog.PrinterSettings.PrinterName
            'crReportDocument.PrintOptions.PrinterName = printDocument1.PrinterSettings.PrinterName
            crReportDocument.PrintToPrinter(nCopy, cColl, sPage, ePage)

            ''Proses Insert to Database here
            'If LabelMark.Text = "LA1" Then
            '    Report_Label_Production.btnDelete_Click(sender, e)
            'ElseIf LabelMark.Text = "LA2" Or LabelMark.Text = "LA3" Or LabelMark.Text = "LA4" Then
            '    Report_Label_HCQC.btnDelete_Click(sender, e)
            'End If
            ''-------------------------------
        End If

    End Sub

    Private Sub Print_Label_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

End Class