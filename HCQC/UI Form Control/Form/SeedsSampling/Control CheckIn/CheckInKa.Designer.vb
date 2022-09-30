<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckInKa
    Inherits MetroFramework.Controls.MetroUserControl

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckInKa))
        Me.PanelTestDateKa = New MetroFramework.Controls.MetroPanel()
        Me.TTestDateKa = New System.Windows.Forms.MaskedTextBox()
        Me.LabelDate1 = New MetroFramework.Controls.MetroLabel()
        Me.BtnDelKa = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnSaveKa = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.LabelIdKa = New MetroFramework.Controls.MetroLabel()
        Me.LabelVarietyKa = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel23 = New MetroFramework.Controls.MetroLabel()
        Me.LabelFarmerKa = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel25 = New MetroFramework.Controls.MetroLabel()
        Me.LabelJobKa = New MetroFramework.Controls.MetroLabel()
        Me.LabelLocationKa = New MetroFramework.Controls.MetroLabel()
        Me.LabelHarvestKa = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel29 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel30 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel31 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel32 = New MetroFramework.Controls.MetroLabel()
        Me.TLabnumKa = New MetroFramework.Controls.MetroTextBox()
        Me.LabelMoi = New MetroFramework.Controls.MetroLabel()
        Me.BtnFindMoi = New Bunifu.Framework.UI.BunifuImageButton()
        Me.MetroLabel87 = New MetroFramework.Controls.MetroLabel()
        Me.PanelTestDateKa.SuspendLayout()
        CType(Me.BtnFindMoi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTestDateKa
        '
        Me.PanelTestDateKa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTestDateKa.Controls.Add(Me.TTestDateKa)
        Me.PanelTestDateKa.HorizontalScrollbarBarColor = True
        Me.PanelTestDateKa.HorizontalScrollbarHighlightOnWheel = False
        Me.PanelTestDateKa.HorizontalScrollbarSize = 10
        Me.PanelTestDateKa.Location = New System.Drawing.Point(3, 91)
        Me.PanelTestDateKa.Name = "PanelTestDateKa"
        Me.PanelTestDateKa.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelTestDateKa.Size = New System.Drawing.Size(123, 23)
        Me.PanelTestDateKa.TabIndex = 160
        Me.PanelTestDateKa.UseStyleColors = True
        Me.PanelTestDateKa.VerticalScrollbarBarColor = True
        Me.PanelTestDateKa.VerticalScrollbarHighlightOnWheel = False
        Me.PanelTestDateKa.VerticalScrollbarSize = 10
        '
        'TTestDateKa
        '
        Me.TTestDateKa.BackColor = System.Drawing.Color.Black
        Me.TTestDateKa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TTestDateKa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TTestDateKa.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTestDateKa.ForeColor = System.Drawing.Color.White
        Me.TTestDateKa.Location = New System.Drawing.Point(1, 1)
        Me.TTestDateKa.Mask = "00/00/0000"
        Me.TTestDateKa.Name = "TTestDateKa"
        Me.TTestDateKa.Size = New System.Drawing.Size(119, 18)
        Me.TTestDateKa.TabIndex = 31
        Me.TTestDateKa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TTestDateKa.ValidatingType = GetType(Date)
        '
        'LabelDate1
        '
        Me.LabelDate1.AutoSize = True
        Me.LabelDate1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelDate1.Location = New System.Drawing.Point(132, 96)
        Me.LabelDate1.Name = "LabelDate1"
        Me.LabelDate1.Size = New System.Drawing.Size(71, 15)
        Me.LabelDate1.TabIndex = 159
        Me.LabelDate1.Text = "dd-MM-yyyy"
        '
        'BtnDelKa
        '
        Me.BtnDelKa.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnDelKa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnDelKa.BackColor = System.Drawing.Color.Transparent
        Me.BtnDelKa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDelKa.BorderRadius = 0
        Me.BtnDelKa.ButtonText = "Delete"
        Me.BtnDelKa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelKa.DisabledColor = System.Drawing.Color.Gray
        Me.BtnDelKa.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnDelKa.Iconimage = Nothing
        Me.BtnDelKa.Iconimage_right = Nothing
        Me.BtnDelKa.Iconimage_right_Selected = Nothing
        Me.BtnDelKa.Iconimage_Selected = Nothing
        Me.BtnDelKa.IconMarginLeft = 0
        Me.BtnDelKa.IconMarginRight = 0
        Me.BtnDelKa.IconRightVisible = False
        Me.BtnDelKa.IconRightZoom = 0R
        Me.BtnDelKa.IconVisible = False
        Me.BtnDelKa.IconZoom = 90.0R
        Me.BtnDelKa.IsTab = False
        Me.BtnDelKa.Location = New System.Drawing.Point(3, 273)
        Me.BtnDelKa.Name = "BtnDelKa"
        Me.BtnDelKa.Normalcolor = System.Drawing.Color.Transparent
        Me.BtnDelKa.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnDelKa.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnDelKa.selected = False
        Me.BtnDelKa.Size = New System.Drawing.Size(304, 34)
        Me.BtnDelKa.TabIndex = 158
        Me.BtnDelKa.Text = "Delete"
        Me.BtnDelKa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnDelKa.Textcolor = System.Drawing.Color.White
        Me.BtnDelKa.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnSaveKa
        '
        Me.BtnSaveKa.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSaveKa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSaveKa.BackColor = System.Drawing.Color.DimGray
        Me.BtnSaveKa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSaveKa.BorderRadius = 0
        Me.BtnSaveKa.ButtonText = "Save"
        Me.BtnSaveKa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSaveKa.DisabledColor = System.Drawing.Color.Gray
        Me.BtnSaveKa.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnSaveKa.Iconimage = Nothing
        Me.BtnSaveKa.Iconimage_right = Nothing
        Me.BtnSaveKa.Iconimage_right_Selected = Nothing
        Me.BtnSaveKa.Iconimage_Selected = Nothing
        Me.BtnSaveKa.IconMarginLeft = 0
        Me.BtnSaveKa.IconMarginRight = 0
        Me.BtnSaveKa.IconRightVisible = False
        Me.BtnSaveKa.IconRightZoom = 0R
        Me.BtnSaveKa.IconVisible = False
        Me.BtnSaveKa.IconZoom = 90.0R
        Me.BtnSaveKa.IsTab = False
        Me.BtnSaveKa.Location = New System.Drawing.Point(3, 233)
        Me.BtnSaveKa.Name = "BtnSaveKa"
        Me.BtnSaveKa.Normalcolor = System.Drawing.Color.DimGray
        Me.BtnSaveKa.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSaveKa.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnSaveKa.selected = False
        Me.BtnSaveKa.Size = New System.Drawing.Size(304, 34)
        Me.BtnSaveKa.TabIndex = 157
        Me.BtnSaveKa.Text = "Save"
        Me.BtnSaveKa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSaveKa.Textcolor = System.Drawing.Color.White
        Me.BtnSaveKa.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LabelIdKa
        '
        Me.LabelIdKa.AutoSize = True
        Me.LabelIdKa.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelIdKa.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LabelIdKa.ForeColor = System.Drawing.Color.White
        Me.LabelIdKa.Location = New System.Drawing.Point(3, 145)
        Me.LabelIdKa.Name = "LabelIdKa"
        Me.LabelIdKa.Size = New System.Drawing.Size(21, 15)
        Me.LabelIdKa.TabIndex = 145
        Me.LabelIdKa.Text = "11"
        Me.LabelIdKa.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LabelIdKa.UseCustomForeColor = True
        '
        'LabelVarietyKa
        '
        Me.LabelVarietyKa.AutoSize = True
        Me.LabelVarietyKa.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelVarietyKa.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LabelVarietyKa.ForeColor = System.Drawing.Color.White
        Me.LabelVarietyKa.Location = New System.Drawing.Point(125, 145)
        Me.LabelVarietyKa.Margin = New System.Windows.Forms.Padding(3, 0, 3, 6)
        Me.LabelVarietyKa.Name = "LabelVarietyKa"
        Me.LabelVarietyKa.Size = New System.Drawing.Size(46, 15)
        Me.LabelVarietyKa.TabIndex = 146
        Me.LabelVarietyKa.Text = "Variety"
        Me.LabelVarietyKa.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LabelVarietyKa.UseCustomForeColor = True
        '
        'MetroLabel23
        '
        Me.MetroLabel23.AutoSize = True
        Me.MetroLabel23.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel23.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel23.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel23.Location = New System.Drawing.Point(3, 130)
        Me.MetroLabel23.Name = "MetroLabel23"
        Me.MetroLabel23.Size = New System.Drawing.Size(93, 15)
        Me.MetroLabel23.TabIndex = 147
        Me.MetroLabel23.Text = "Request Number"
        Me.MetroLabel23.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'LabelFarmerKa
        '
        Me.LabelFarmerKa.AutoSize = True
        Me.LabelFarmerKa.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelFarmerKa.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LabelFarmerKa.ForeColor = System.Drawing.Color.White
        Me.LabelFarmerKa.Location = New System.Drawing.Point(237, 145)
        Me.LabelFarmerKa.Name = "LabelFarmerKa"
        Me.LabelFarmerKa.Size = New System.Drawing.Size(47, 15)
        Me.LabelFarmerKa.TabIndex = 148
        Me.LabelFarmerKa.Text = "Farmer"
        Me.LabelFarmerKa.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LabelFarmerKa.UseCustomForeColor = True
        '
        'MetroLabel25
        '
        Me.MetroLabel25.AutoSize = True
        Me.MetroLabel25.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel25.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel25.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel25.Location = New System.Drawing.Point(125, 130)
        Me.MetroLabel25.Name = "MetroLabel25"
        Me.MetroLabel25.Size = New System.Drawing.Size(40, 15)
        Me.MetroLabel25.TabIndex = 149
        Me.MetroLabel25.Text = "Variety"
        Me.MetroLabel25.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'LabelJobKa
        '
        Me.LabelJobKa.AutoSize = True
        Me.LabelJobKa.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelJobKa.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LabelJobKa.ForeColor = System.Drawing.Color.White
        Me.LabelJobKa.Location = New System.Drawing.Point(3, 185)
        Me.LabelJobKa.Name = "LabelJobKa"
        Me.LabelJobKa.Size = New System.Drawing.Size(49, 15)
        Me.LabelJobKa.TabIndex = 150
        Me.LabelJobKa.Text = "Job/Lot"
        Me.LabelJobKa.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LabelJobKa.UseCustomForeColor = True
        '
        'LabelLocationKa
        '
        Me.LabelLocationKa.AutoSize = True
        Me.LabelLocationKa.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelLocationKa.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LabelLocationKa.ForeColor = System.Drawing.Color.White
        Me.LabelLocationKa.Location = New System.Drawing.Point(125, 185)
        Me.LabelLocationKa.Name = "LabelLocationKa"
        Me.LabelLocationKa.Size = New System.Drawing.Size(54, 15)
        Me.LabelLocationKa.TabIndex = 151
        Me.LabelLocationKa.Text = "Location"
        Me.LabelLocationKa.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LabelLocationKa.UseCustomForeColor = True
        '
        'LabelHarvestKa
        '
        Me.LabelHarvestKa.AutoSize = True
        Me.LabelHarvestKa.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelHarvestKa.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LabelHarvestKa.ForeColor = System.Drawing.Color.White
        Me.LabelHarvestKa.Location = New System.Drawing.Point(237, 185)
        Me.LabelHarvestKa.Name = "LabelHarvestKa"
        Me.LabelHarvestKa.Size = New System.Drawing.Size(51, 15)
        Me.LabelHarvestKa.TabIndex = 152
        Me.LabelHarvestKa.Text = "Harvest"
        Me.LabelHarvestKa.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LabelHarvestKa.UseCustomForeColor = True
        '
        'MetroLabel29
        '
        Me.MetroLabel29.AutoSize = True
        Me.MetroLabel29.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel29.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel29.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel29.Location = New System.Drawing.Point(237, 130)
        Me.MetroLabel29.Name = "MetroLabel29"
        Me.MetroLabel29.Size = New System.Drawing.Size(42, 15)
        Me.MetroLabel29.TabIndex = 153
        Me.MetroLabel29.Text = "Farmer"
        Me.MetroLabel29.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel30
        '
        Me.MetroLabel30.AutoSize = True
        Me.MetroLabel30.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel30.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel30.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel30.Location = New System.Drawing.Point(3, 170)
        Me.MetroLabel30.Name = "MetroLabel30"
        Me.MetroLabel30.Size = New System.Drawing.Size(88, 15)
        Me.MetroLabel30.TabIndex = 154
        Me.MetroLabel30.Text = "Manual/Job SAS"
        Me.MetroLabel30.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel31
        '
        Me.MetroLabel31.AutoSize = True
        Me.MetroLabel31.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel31.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel31.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel31.Location = New System.Drawing.Point(125, 170)
        Me.MetroLabel31.Name = "MetroLabel31"
        Me.MetroLabel31.Size = New System.Drawing.Size(49, 15)
        Me.MetroLabel31.TabIndex = 155
        Me.MetroLabel31.Text = "Location"
        Me.MetroLabel31.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel32
        '
        Me.MetroLabel32.AutoSize = True
        Me.MetroLabel32.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel32.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel32.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel32.Location = New System.Drawing.Point(237, 170)
        Me.MetroLabel32.Name = "MetroLabel32"
        Me.MetroLabel32.Size = New System.Drawing.Size(46, 15)
        Me.MetroLabel32.TabIndex = 156
        Me.MetroLabel32.Text = "Harvest"
        Me.MetroLabel32.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'TLabnumKa
        '
        '
        '
        '
        Me.TLabnumKa.CustomButton.Image = Nothing
        Me.TLabnumKa.CustomButton.Location = New System.Drawing.Point(171, 1)
        Me.TLabnumKa.CustomButton.Name = ""
        Me.TLabnumKa.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.TLabnumKa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TLabnumKa.CustomButton.TabIndex = 1
        Me.TLabnumKa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TLabnumKa.CustomButton.UseSelectable = True
        Me.TLabnumKa.CustomButton.Visible = False
        Me.TLabnumKa.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TLabnumKa.Lines = New String(-1) {}
        Me.TLabnumKa.Location = New System.Drawing.Point(3, 28)
        Me.TLabnumKa.MaxLength = 32767
        Me.TLabnumKa.Name = "TLabnumKa"
        Me.TLabnumKa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TLabnumKa.PromptText = "Lab Number"
        Me.TLabnumKa.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TLabnumKa.SelectedText = ""
        Me.TLabnumKa.SelectionLength = 0
        Me.TLabnumKa.SelectionStart = 0
        Me.TLabnumKa.ShortcutsEnabled = True
        Me.TLabnumKa.Size = New System.Drawing.Size(193, 23)
        Me.TLabnumKa.TabIndex = 143
        Me.TLabnumKa.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TLabnumKa.UseSelectable = True
        Me.TLabnumKa.WaterMark = "Lab Number"
        Me.TLabnumKa.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TLabnumKa.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'LabelMoi
        '
        Me.LabelMoi.AutoSize = True
        Me.LabelMoi.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.LabelMoi.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.LabelMoi.Location = New System.Drawing.Point(3, 0)
        Me.LabelMoi.Name = "LabelMoi"
        Me.LabelMoi.Size = New System.Drawing.Size(117, 25)
        Me.LabelMoi.TabIndex = 142
        Me.LabelMoi.Text = "Moisture Test"
        Me.LabelMoi.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'BtnFindMoi
        '
        Me.BtnFindMoi.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnFindMoi.Image = CType(resources.GetObject("BtnFindMoi.Image"), System.Drawing.Image)
        Me.BtnFindMoi.ImageActive = Nothing
        Me.BtnFindMoi.Location = New System.Drawing.Point(202, 28)
        Me.BtnFindMoi.Name = "BtnFindMoi"
        Me.BtnFindMoi.Size = New System.Drawing.Size(38, 23)
        Me.BtnFindMoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnFindMoi.TabIndex = 144
        Me.BtnFindMoi.TabStop = False
        Me.BtnFindMoi.Zoom = 10
        '
        'MetroLabel87
        '
        Me.MetroLabel87.AutoSize = True
        Me.MetroLabel87.Location = New System.Drawing.Point(3, 69)
        Me.MetroLabel87.Name = "MetroLabel87"
        Me.MetroLabel87.Size = New System.Drawing.Size(122, 19)
        Me.MetroLabel87.TabIndex = 161
        Me.MetroLabel87.Text = "Check in Test  Date "
        Me.MetroLabel87.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'CheckInKa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroLabel87)
        Me.Controls.Add(Me.PanelTestDateKa)
        Me.Controls.Add(Me.LabelDate1)
        Me.Controls.Add(Me.BtnDelKa)
        Me.Controls.Add(Me.BtnSaveKa)
        Me.Controls.Add(Me.LabelIdKa)
        Me.Controls.Add(Me.LabelVarietyKa)
        Me.Controls.Add(Me.MetroLabel23)
        Me.Controls.Add(Me.LabelFarmerKa)
        Me.Controls.Add(Me.MetroLabel25)
        Me.Controls.Add(Me.LabelJobKa)
        Me.Controls.Add(Me.LabelLocationKa)
        Me.Controls.Add(Me.LabelHarvestKa)
        Me.Controls.Add(Me.MetroLabel29)
        Me.Controls.Add(Me.MetroLabel30)
        Me.Controls.Add(Me.MetroLabel31)
        Me.Controls.Add(Me.MetroLabel32)
        Me.Controls.Add(Me.TLabnumKa)
        Me.Controls.Add(Me.LabelMoi)
        Me.Controls.Add(Me.BtnFindMoi)
        Me.Name = "CheckInKa"
        Me.Size = New System.Drawing.Size(317, 310)
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.PanelTestDateKa.ResumeLayout(False)
        Me.PanelTestDateKa.PerformLayout()
        CType(Me.BtnFindMoi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTestDateKa As MetroPanel
    Friend WithEvents TTestDateKa As MaskedTextBox
    Friend WithEvents LabelDate1 As MetroLabel
    Friend WithEvents BtnDelKa As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnSaveKa As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents LabelIdKa As MetroLabel
    Friend WithEvents LabelVarietyKa As MetroLabel
    Friend WithEvents MetroLabel23 As MetroLabel
    Friend WithEvents LabelFarmerKa As MetroLabel
    Friend WithEvents MetroLabel25 As MetroLabel
    Friend WithEvents LabelJobKa As MetroLabel
    Friend WithEvents LabelLocationKa As MetroLabel
    Friend WithEvents LabelHarvestKa As MetroLabel
    Friend WithEvents MetroLabel29 As MetroLabel
    Friend WithEvents MetroLabel30 As MetroLabel
    Friend WithEvents MetroLabel31 As MetroLabel
    Friend WithEvents MetroLabel32 As MetroLabel
    Friend WithEvents TLabnumKa As MetroTextBox
    Friend WithEvents LabelMoi As MetroLabel
    Friend WithEvents BtnFindMoi As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents MetroLabel87 As MetroLabel
End Class
