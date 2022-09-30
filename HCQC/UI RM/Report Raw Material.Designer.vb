<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_Raw_Material
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.Prenolab = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(240, 99)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(91, 23)
        Me.MetroButton2.TabIndex = 27
        Me.MetroButton2.Text = "Print"
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(143, 99)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(91, 23)
        Me.MetroButton1.TabIndex = 26
        Me.MetroButton1.Text = "Preview"
        Me.MetroButton1.UseSelectable = True
        '
        'Prenolab
        '
        '
        '
        '
        Me.Prenolab.CustomButton.Image = Nothing
        Me.Prenolab.CustomButton.Location = New System.Drawing.Point(223, 1)
        Me.Prenolab.CustomButton.Name = ""
        Me.Prenolab.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.Prenolab.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Prenolab.CustomButton.TabIndex = 1
        Me.Prenolab.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Prenolab.CustomButton.UseSelectable = True
        Me.Prenolab.CustomButton.Visible = False
        Me.Prenolab.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Prenolab.Lines = New String(-1) {}
        Me.Prenolab.Location = New System.Drawing.Point(86, 70)
        Me.Prenolab.MaxLength = 32767
        Me.Prenolab.Name = "Prenolab"
        Me.Prenolab.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Prenolab.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Prenolab.SelectedText = ""
        Me.Prenolab.SelectionLength = 0
        Me.Prenolab.SelectionStart = 0
        Me.Prenolab.ShortcutsEnabled = True
        Me.Prenolab.Size = New System.Drawing.Size(245, 23)
        Me.Prenolab.Style = MetroFramework.MetroColorStyle.Orange
        Me.Prenolab.TabIndex = 25
        Me.Prenolab.UseSelectable = True
        Me.Prenolab.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Prenolab.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(24, 70)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel1.TabIndex = 23
        Me.MetroLabel1.Text = "No. Lab"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(24, 149)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(868, 570)
        Me.CrystalReportViewer1.TabIndex = 20
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        Me.MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Yellow
        '
        'Report_Raw_Material
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 733)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.Prenolab)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "Report_Raw_Material"
        Me.Padding = New System.Windows.Forms.Padding(20, 70, 20, 20)
        Me.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Text = "Report Raw Material"
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Prenolab As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
End Class
