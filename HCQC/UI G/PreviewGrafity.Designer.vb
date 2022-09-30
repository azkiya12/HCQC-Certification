<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreviewGrafity
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Prenolab = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroRadioButton1 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton2 = New MetroFramework.Controls.MetroRadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(23, 191)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(868, 519)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(22, 151)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "No. Lab"
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
        Me.Prenolab.Location = New System.Drawing.Point(84, 147)
        Me.Prenolab.MaxLength = 32767
        Me.Prenolab.Name = "Prenolab"
        Me.Prenolab.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Prenolab.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Prenolab.SelectedText = ""
        Me.Prenolab.SelectionLength = 0
        Me.Prenolab.SelectionStart = 0
        Me.Prenolab.ShortcutsEnabled = True
        Me.Prenolab.Size = New System.Drawing.Size(245, 23)
        Me.Prenolab.TabIndex = 3
        Me.Prenolab.UseSelectable = True
        Me.Prenolab.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Prenolab.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(344, 147)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(91, 23)
        Me.MetroButton1.TabIndex = 4
        Me.MetroButton1.Text = "Preview"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(441, 147)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(91, 23)
        Me.MetroButton2.TabIndex = 5
        Me.MetroButton2.Text = "Print"
        Me.MetroButton2.UseSelectable = True
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = Nothing
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(203, 1)
        Me.MetroTextBox2.CustomButton.Name = ""
        Me.MetroTextBox2.CustomButton.Size = New System.Drawing.Size(41, 41)
        Me.MetroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox2.CustomButton.TabIndex = 1
        Me.MetroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox2.CustomButton.UseSelectable = True
        Me.MetroTextBox2.CustomButton.Visible = False
        Me.MetroTextBox2.Lines = New String(-1) {}
        Me.MetroTextBox2.Location = New System.Drawing.Point(84, 98)
        Me.MetroTextBox2.MaxLength = 32767
        Me.MetroTextBox2.Multiline = True
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.ShortcutsEnabled = True
        Me.MetroTextBox2.Size = New System.Drawing.Size(245, 43)
        Me.MetroTextBox2.TabIndex = 2
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 73)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(22, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "To"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(22, 98)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel3.TabIndex = 1
        Me.MetroLabel3.Text = "Address"
        '
        'MetroRadioButton1
        '
        Me.MetroRadioButton1.AutoSize = True
        Me.MetroRadioButton1.Location = New System.Drawing.Point(344, 77)
        Me.MetroRadioButton1.Name = "MetroRadioButton1"
        Me.MetroRadioButton1.Size = New System.Drawing.Size(92, 15)
        Me.MetroRadioButton1.TabIndex = 6
        Me.MetroRadioButton1.Text = "UJI LENGKAP"
        Me.MetroRadioButton1.UseSelectable = True
        '
        'MetroRadioButton2
        '
        Me.MetroRadioButton2.AutoSize = True
        Me.MetroRadioButton2.Location = New System.Drawing.Point(344, 100)
        Me.MetroRadioButton2.Name = "MetroRadioButton2"
        Me.MetroRadioButton2.Size = New System.Drawing.Size(54, 15)
        Me.MetroRadioButton2.TabIndex = 7
        Me.MetroRadioButton2.Text = "UJI DT"
        Me.MetroRadioButton2.UseSelectable = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Prosesing/HCP"})
        Me.ComboBox1.Location = New System.Drawing.Point(84, 64)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(245, 28)
        Me.ComboBox1.TabIndex = 1
        '
        'PreviewGrafity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(914, 733)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.MetroRadioButton2)
        Me.Controls.Add(Me.MetroRadioButton1)
        Me.Controls.Add(Me.MetroTextBox2)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.Prenolab)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "PreviewGrafity"
        Me.Text = "Report Viewer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Prenolab As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroRadioButton1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
