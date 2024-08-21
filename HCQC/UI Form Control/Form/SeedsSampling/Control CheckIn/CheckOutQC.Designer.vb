<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckOutQC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckOutQC))
        Me.MetroLabel87 = New MetroFramework.Controls.MetroLabel()
        Me.LabelDate1 = New MetroFramework.Controls.MetroLabel()
        Me.Btn_del_QC = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_save_QC = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.LreqnumGer = New MetroFramework.Controls.MetroLabel()
        Me.LvarietyGer = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.LfarmerGer = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.LjobGer = New MetroFramework.Controls.MetroLabel()
        Me.LLocationgGer = New MetroFramework.Controls.MetroLabel()
        Me.LharvestGer = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.tlabnumOutQC = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.BtnFindOutQC = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tTestDateGer = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.Lstatus = New MetroFramework.Controls.MetroLabel()
        CType(Me.BtnFindOutQC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel87
        '
        Me.MetroLabel87.AutoSize = True
        Me.MetroLabel87.Location = New System.Drawing.Point(0, 82)
        Me.MetroLabel87.Name = "MetroLabel87"
        Me.MetroLabel87.Size = New System.Drawing.Size(95, 19)
        Me.MetroLabel87.TabIndex = 201
        Me.MetroLabel87.Text = "Check Our QC"
        Me.MetroLabel87.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'LabelDate1
        '
        Me.LabelDate1.AutoSize = True
        Me.LabelDate1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelDate1.Location = New System.Drawing.Point(3, 122)
        Me.LabelDate1.Name = "LabelDate1"
        Me.LabelDate1.Size = New System.Drawing.Size(71, 15)
        Me.LabelDate1.TabIndex = 199
        Me.LabelDate1.Text = "dd-MM-yyyy"
        Me.LabelDate1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Btn_del_QC
        '
        Me.Btn_del_QC.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Btn_del_QC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_del_QC.BackColor = System.Drawing.Color.Transparent
        Me.Btn_del_QC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_del_QC.BorderRadius = 0
        Me.Btn_del_QC.ButtonText = "Delete"
        Me.Btn_del_QC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_del_QC.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_del_QC.Enabled = False
        Me.Btn_del_QC.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_del_QC.Iconimage = Nothing
        Me.Btn_del_QC.Iconimage_right = Nothing
        Me.Btn_del_QC.Iconimage_right_Selected = Nothing
        Me.Btn_del_QC.Iconimage_Selected = Nothing
        Me.Btn_del_QC.IconMarginLeft = 0
        Me.Btn_del_QC.IconMarginRight = 0
        Me.Btn_del_QC.IconRightVisible = True
        Me.Btn_del_QC.IconRightZoom = 0R
        Me.Btn_del_QC.IconVisible = True
        Me.Btn_del_QC.IconZoom = 90.0R
        Me.Btn_del_QC.IsTab = False
        Me.Btn_del_QC.Location = New System.Drawing.Point(3, 292)
        Me.Btn_del_QC.Name = "Btn_del_QC"
        Me.Btn_del_QC.Normalcolor = System.Drawing.Color.Transparent
        Me.Btn_del_QC.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_del_QC.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_del_QC.selected = False
        Me.Btn_del_QC.Size = New System.Drawing.Size(304, 34)
        Me.Btn_del_QC.TabIndex = 198
        Me.Btn_del_QC.Text = "Delete"
        Me.Btn_del_QC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_del_QC.Textcolor = System.Drawing.Color.White
        Me.Btn_del_QC.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_save_QC
        '
        Me.Btn_save_QC.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Btn_save_QC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_save_QC.BackColor = System.Drawing.Color.DimGray
        Me.Btn_save_QC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_save_QC.BorderRadius = 0
        Me.Btn_save_QC.ButtonText = "Save"
        Me.Btn_save_QC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_save_QC.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_save_QC.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_save_QC.Iconimage = Nothing
        Me.Btn_save_QC.Iconimage_right = Nothing
        Me.Btn_save_QC.Iconimage_right_Selected = Nothing
        Me.Btn_save_QC.Iconimage_Selected = Nothing
        Me.Btn_save_QC.IconMarginLeft = 0
        Me.Btn_save_QC.IconMarginRight = 0
        Me.Btn_save_QC.IconRightVisible = True
        Me.Btn_save_QC.IconRightZoom = 0R
        Me.Btn_save_QC.IconVisible = True
        Me.Btn_save_QC.IconZoom = 90.0R
        Me.Btn_save_QC.IsTab = False
        Me.Btn_save_QC.Location = New System.Drawing.Point(3, 252)
        Me.Btn_save_QC.Name = "Btn_save_QC"
        Me.Btn_save_QC.Normalcolor = System.Drawing.Color.DimGray
        Me.Btn_save_QC.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_save_QC.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_save_QC.selected = False
        Me.Btn_save_QC.Size = New System.Drawing.Size(304, 34)
        Me.Btn_save_QC.TabIndex = 197
        Me.Btn_save_QC.Text = "Save"
        Me.Btn_save_QC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_save_QC.Textcolor = System.Drawing.Color.White
        Me.Btn_save_QC.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LreqnumGer
        '
        Me.LreqnumGer.AutoSize = True
        Me.LreqnumGer.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LreqnumGer.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LreqnumGer.ForeColor = System.Drawing.Color.White
        Me.LreqnumGer.Location = New System.Drawing.Point(3, 166)
        Me.LreqnumGer.Name = "LreqnumGer"
        Me.LreqnumGer.Size = New System.Drawing.Size(21, 15)
        Me.LreqnumGer.TabIndex = 185
        Me.LreqnumGer.Text = "11"
        Me.LreqnumGer.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LreqnumGer.UseCustomForeColor = True
        '
        'LvarietyGer
        '
        Me.LvarietyGer.AutoSize = True
        Me.LvarietyGer.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LvarietyGer.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LvarietyGer.ForeColor = System.Drawing.Color.White
        Me.LvarietyGer.Location = New System.Drawing.Point(125, 166)
        Me.LvarietyGer.Margin = New System.Windows.Forms.Padding(3, 0, 3, 6)
        Me.LvarietyGer.Name = "LvarietyGer"
        Me.LvarietyGer.Size = New System.Drawing.Size(46, 15)
        Me.LvarietyGer.TabIndex = 186
        Me.LvarietyGer.Text = "Variety"
        Me.LvarietyGer.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LvarietyGer.UseCustomForeColor = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel9.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel9.Location = New System.Drawing.Point(3, 151)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(93, 15)
        Me.MetroLabel9.TabIndex = 187
        Me.MetroLabel9.Text = "Request Number"
        Me.MetroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'LfarmerGer
        '
        Me.LfarmerGer.AutoSize = True
        Me.LfarmerGer.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LfarmerGer.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LfarmerGer.ForeColor = System.Drawing.Color.White
        Me.LfarmerGer.Location = New System.Drawing.Point(237, 166)
        Me.LfarmerGer.Name = "LfarmerGer"
        Me.LfarmerGer.Size = New System.Drawing.Size(47, 15)
        Me.LfarmerGer.TabIndex = 188
        Me.LfarmerGer.Text = "Farmer"
        Me.LfarmerGer.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LfarmerGer.UseCustomForeColor = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel5.Location = New System.Drawing.Point(125, 151)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(40, 15)
        Me.MetroLabel5.TabIndex = 189
        Me.MetroLabel5.Text = "Variety"
        Me.MetroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'LjobGer
        '
        Me.LjobGer.AutoSize = True
        Me.LjobGer.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LjobGer.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LjobGer.ForeColor = System.Drawing.Color.White
        Me.LjobGer.Location = New System.Drawing.Point(3, 206)
        Me.LjobGer.Name = "LjobGer"
        Me.LjobGer.Size = New System.Drawing.Size(49, 15)
        Me.LjobGer.TabIndex = 190
        Me.LjobGer.Text = "Job/Lot"
        Me.LjobGer.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LjobGer.UseCustomForeColor = True
        '
        'LLocationgGer
        '
        Me.LLocationgGer.AutoSize = True
        Me.LLocationgGer.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LLocationgGer.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LLocationgGer.ForeColor = System.Drawing.Color.White
        Me.LLocationgGer.Location = New System.Drawing.Point(125, 206)
        Me.LLocationgGer.Name = "LLocationgGer"
        Me.LLocationgGer.Size = New System.Drawing.Size(54, 15)
        Me.LLocationgGer.TabIndex = 191
        Me.LLocationgGer.Text = "Location"
        Me.LLocationgGer.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LLocationgGer.UseCustomForeColor = True
        '
        'LharvestGer
        '
        Me.LharvestGer.AutoSize = True
        Me.LharvestGer.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LharvestGer.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LharvestGer.ForeColor = System.Drawing.Color.White
        Me.LharvestGer.Location = New System.Drawing.Point(237, 206)
        Me.LharvestGer.Name = "LharvestGer"
        Me.LharvestGer.Size = New System.Drawing.Size(51, 15)
        Me.LharvestGer.TabIndex = 192
        Me.LharvestGer.Text = "Harvest"
        Me.LharvestGer.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LharvestGer.UseCustomForeColor = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel6.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel6.Location = New System.Drawing.Point(237, 151)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(42, 15)
        Me.MetroLabel6.TabIndex = 193
        Me.MetroLabel6.Text = "Farmer"
        Me.MetroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel7.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel7.Location = New System.Drawing.Point(3, 191)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(88, 15)
        Me.MetroLabel7.TabIndex = 194
        Me.MetroLabel7.Text = "Manual/Job SAS"
        Me.MetroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel10.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel10.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel10.Location = New System.Drawing.Point(125, 191)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(49, 15)
        Me.MetroLabel10.TabIndex = 195
        Me.MetroLabel10.Text = "Location"
        Me.MetroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel11.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel11.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel11.Location = New System.Drawing.Point(237, 191)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(46, 15)
        Me.MetroLabel11.TabIndex = 196
        Me.MetroLabel11.Text = "Harvest"
        Me.MetroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'tlabnumOutQC
        '
        Me.tlabnumOutQC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.tlabnumOutQC.CustomButton.Image = Nothing
        Me.tlabnumOutQC.CustomButton.Location = New System.Drawing.Point(238, 1)
        Me.tlabnumOutQC.CustomButton.Name = ""
        Me.tlabnumOutQC.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tlabnumOutQC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tlabnumOutQC.CustomButton.TabIndex = 1
        Me.tlabnumOutQC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tlabnumOutQC.CustomButton.UseSelectable = True
        Me.tlabnumOutQC.CustomButton.Visible = False
        Me.tlabnumOutQC.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tlabnumOutQC.Lines = New String(-1) {}
        Me.tlabnumOutQC.Location = New System.Drawing.Point(3, 28)
        Me.tlabnumOutQC.MaxLength = 32767
        Me.tlabnumOutQC.Name = "tlabnumOutQC"
        Me.tlabnumOutQC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tlabnumOutQC.PromptText = "Lab Number"
        Me.tlabnumOutQC.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tlabnumOutQC.SelectedText = ""
        Me.tlabnumOutQC.SelectionLength = 0
        Me.tlabnumOutQC.SelectionStart = 0
        Me.tlabnumOutQC.ShortcutsEnabled = True
        Me.tlabnumOutQC.Size = New System.Drawing.Size(260, 23)
        Me.tlabnumOutQC.TabIndex = 203
        Me.tlabnumOutQC.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tlabnumOutQC.UseSelectable = True
        Me.tlabnumOutQC.WaterMark = "Lab Number"
        Me.tlabnumOutQC.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tlabnumOutQC.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(136, 25)
        Me.MetroLabel1.TabIndex = 202
        Me.MetroLabel1.Text = "Sample Out QC"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'BtnFindOutQC
        '
        Me.BtnFindOutQC.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnFindOutQC.Image = CType(resources.GetObject("BtnFindOutQC.Image"), System.Drawing.Image)
        Me.BtnFindOutQC.ImageActive = Nothing
        Me.BtnFindOutQC.Location = New System.Drawing.Point(269, 28)
        Me.BtnFindOutQC.Name = "BtnFindOutQC"
        Me.BtnFindOutQC.Size = New System.Drawing.Size(38, 23)
        Me.BtnFindOutQC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnFindOutQC.TabIndex = 204
        Me.BtnFindOutQC.TabStop = False
        Me.BtnFindOutQC.Zoom = 10
        '
        'tTestDateGer
        '
        Me.tTestDateGer.AutoSize = True
        Me.tTestDateGer.FontSize = MetroFramework.MetroLabelSize.Small
        Me.tTestDateGer.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.tTestDateGer.ForeColor = System.Drawing.Color.White
        Me.tTestDateGer.Location = New System.Drawing.Point(3, 101)
        Me.tTestDateGer.Name = "tTestDateGer"
        Me.tTestDateGer.Size = New System.Drawing.Size(32, 15)
        Me.tTestDateGer.TabIndex = 206
        Me.tTestDateGer.Text = "date"
        Me.tTestDateGer.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tTestDateGer.UseCustomForeColor = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(197, 82)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(91, 19)
        Me.MetroLabel2.TabIndex = 201
        Me.MetroLabel2.Text = "Status Sample"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Lstatus
        '
        Me.Lstatus.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Lstatus.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Lstatus.ForeColor = System.Drawing.Color.White
        Me.Lstatus.Location = New System.Drawing.Point(202, 101)
        Me.Lstatus.Name = "Lstatus"
        Me.Lstatus.Size = New System.Drawing.Size(86, 15)
        Me.Lstatus.TabIndex = 207
        Me.Lstatus.Text = "status"
        Me.Lstatus.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Lstatus.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Lstatus.UseCustomForeColor = True
        '
        'CheckOutQC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Lstatus)
        Me.Controls.Add(Me.tTestDateGer)
        Me.Controls.Add(Me.tlabnumOutQC)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.BtnFindOutQC)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel87)
        Me.Controls.Add(Me.LabelDate1)
        Me.Controls.Add(Me.Btn_del_QC)
        Me.Controls.Add(Me.Btn_save_QC)
        Me.Controls.Add(Me.LreqnumGer)
        Me.Controls.Add(Me.LvarietyGer)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.LfarmerGer)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.LjobGer)
        Me.Controls.Add(Me.LLocationgGer)
        Me.Controls.Add(Me.LharvestGer)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Name = "CheckOutQC"
        Me.Size = New System.Drawing.Size(319, 326)
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.BtnFindOutQC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel87 As MetroLabel
    Friend WithEvents LabelDate1 As MetroLabel
    Friend WithEvents Btn_del_QC As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_save_QC As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents LreqnumGer As MetroLabel
    Friend WithEvents LvarietyGer As MetroLabel
    Friend WithEvents MetroLabel9 As MetroLabel
    Friend WithEvents LfarmerGer As MetroLabel
    Friend WithEvents MetroLabel5 As MetroLabel
    Friend WithEvents LjobGer As MetroLabel
    Friend WithEvents LLocationgGer As MetroLabel
    Friend WithEvents LharvestGer As MetroLabel
    Friend WithEvents MetroLabel6 As MetroLabel
    Friend WithEvents MetroLabel7 As MetroLabel
    Friend WithEvents MetroLabel10 As MetroLabel
    Friend WithEvents MetroLabel11 As MetroLabel
    Friend WithEvents tlabnumOutQC As MetroTextBox
    Friend WithEvents MetroLabel1 As MetroLabel
    Friend WithEvents BtnFindOutQC As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents tTestDateGer As MetroLabel
    Friend WithEvents MetroLabel2 As MetroLabel
    Friend WithEvents Lstatus As MetroLabel
End Class
