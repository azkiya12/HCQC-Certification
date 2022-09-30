<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Print_Label
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.LabelTitle = New MetroFramework.Controls.MetroLabel()
        Me.LabelSP = New MetroFramework.Controls.MetroLabel()
        Me.LabelMark = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroPanel1.Controls.Add(Me.CrystalReportViewer1)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(23, 63)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(800, 364)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowCopyButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(800, 364)
        Me.CrystalReportViewer1.TabIndex = 2
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Location = New System.Drawing.Point(245, 29)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(0, 0)
        Me.LabelTitle.TabIndex = 1
        '
        'LabelSP
        '
        Me.LabelSP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelSP.AutoSize = True
        Me.LabelSP.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelSP.ForeColor = System.Drawing.Color.DarkGray
        Me.LabelSP.Location = New System.Drawing.Point(87, 430)
        Me.LabelSP.Name = "LabelSP"
        Me.LabelSP.Size = New System.Drawing.Size(46, 15)
        Me.LabelSP.TabIndex = 2
        Me.LabelSP.Text = "LabelSP"
        Me.LabelSP.UseCustomForeColor = True
        '
        'LabelMark
        '
        Me.LabelMark.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelMark.AutoSize = True
        Me.LabelMark.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelMark.ForeColor = System.Drawing.Color.DarkGray
        Me.LabelMark.Location = New System.Drawing.Point(23, 430)
        Me.LabelMark.Name = "LabelMark"
        Me.LabelMark.Size = New System.Drawing.Size(58, 15)
        Me.LabelMark.TabIndex = 2
        Me.LabelMark.Text = "LabelMark"
        Me.LabelMark.UseCustomForeColor = True
        '
        'Print_Label
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 450)
        Me.Controls.Add(Me.LabelMark)
        Me.Controls.Add(Me.LabelSP)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Name = "Print_Label"
        Me.Text = "Preview Report"
        Me.MetroPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroPanel1 As MetroPanel
    Friend WithEvents LabelTitle As MetroLabel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents LabelSP As MetroLabel
    Friend WithEvents LabelMark As MetroLabel
End Class
