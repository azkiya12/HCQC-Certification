<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckIn1Count
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckIn1Count))
        Me.MetroLabel87 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.tTestDateGer = New System.Windows.Forms.MaskedTextBox()
        Me.LabelDate1 = New MetroFramework.Controls.MetroLabel()
        Me.Btn_del_ger = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_save_ger = New Bunifu.Framework.UI.BunifuFlatButton()
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
        Me.tlabnumGer = New MetroFramework.Controls.MetroTextBox()
        Me.LabelGer = New MetroFramework.Controls.MetroLabel()
        Me.BtnFindGer = New Bunifu.Framework.UI.BunifuImageButton()
        Me.MetroPanel2.SuspendLayout()
        CType(Me.BtnFindGer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel87
        '
        Me.MetroLabel87.AutoSize = True
        Me.MetroLabel87.Location = New System.Drawing.Point(0, 82)
        Me.MetroLabel87.Name = "MetroLabel87"
        Me.MetroLabel87.Size = New System.Drawing.Size(122, 19)
        Me.MetroLabel87.TabIndex = 167
        Me.MetroLabel87.Text = "Check in Test  Date "
        Me.MetroLabel87.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel2.Controls.Add(Me.tTestDateGer)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 104)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.MetroPanel2.Size = New System.Drawing.Size(123, 23)
        Me.MetroPanel2.TabIndex = 166
        Me.MetroPanel2.UseStyleColors = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'tTestDateGer
        '
        Me.tTestDateGer.BackColor = System.Drawing.Color.Black
        Me.tTestDateGer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tTestDateGer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tTestDateGer.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tTestDateGer.ForeColor = System.Drawing.Color.White
        Me.tTestDateGer.Location = New System.Drawing.Point(1, 1)
        Me.tTestDateGer.Mask = "00/00/0000"
        Me.tTestDateGer.Name = "tTestDateGer"
        Me.tTestDateGer.Size = New System.Drawing.Size(119, 18)
        Me.tTestDateGer.TabIndex = 131
        Me.tTestDateGer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tTestDateGer.ValidatingType = GetType(Date)
        '
        'LabelDate1
        '
        Me.LabelDate1.AutoSize = True
        Me.LabelDate1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelDate1.Location = New System.Drawing.Point(129, 109)
        Me.LabelDate1.Name = "LabelDate1"
        Me.LabelDate1.Size = New System.Drawing.Size(71, 15)
        Me.LabelDate1.TabIndex = 165
        Me.LabelDate1.Text = "dd-MM-yyyy"
        Me.LabelDate1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Btn_del_ger
        '
        Me.Btn_del_ger.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Btn_del_ger.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_del_ger.BackColor = System.Drawing.Color.Transparent
        Me.Btn_del_ger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_del_ger.BorderRadius = 0
        Me.Btn_del_ger.ButtonText = "Delete"
        Me.Btn_del_ger.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_del_ger.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_del_ger.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_del_ger.Iconimage = Nothing
        Me.Btn_del_ger.Iconimage_right = Nothing
        Me.Btn_del_ger.Iconimage_right_Selected = Nothing
        Me.Btn_del_ger.Iconimage_Selected = Nothing
        Me.Btn_del_ger.IconMarginLeft = 0
        Me.Btn_del_ger.IconMarginRight = 0
        Me.Btn_del_ger.IconRightVisible = True
        Me.Btn_del_ger.IconRightZoom = 0R
        Me.Btn_del_ger.IconVisible = True
        Me.Btn_del_ger.IconZoom = 90.0R
        Me.Btn_del_ger.IsTab = False
        Me.Btn_del_ger.Location = New System.Drawing.Point(0, 289)
        Me.Btn_del_ger.Name = "Btn_del_ger"
        Me.Btn_del_ger.Normalcolor = System.Drawing.Color.Transparent
        Me.Btn_del_ger.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_del_ger.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_del_ger.selected = False
        Me.Btn_del_ger.Size = New System.Drawing.Size(304, 34)
        Me.Btn_del_ger.TabIndex = 164
        Me.Btn_del_ger.Text = "Delete"
        Me.Btn_del_ger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_del_ger.Textcolor = System.Drawing.Color.White
        Me.Btn_del_ger.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_save_ger
        '
        Me.Btn_save_ger.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Btn_save_ger.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_save_ger.BackColor = System.Drawing.Color.DimGray
        Me.Btn_save_ger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_save_ger.BorderRadius = 0
        Me.Btn_save_ger.ButtonText = "Save"
        Me.Btn_save_ger.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_save_ger.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_save_ger.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_save_ger.Iconimage = Nothing
        Me.Btn_save_ger.Iconimage_right = Nothing
        Me.Btn_save_ger.Iconimage_right_Selected = Nothing
        Me.Btn_save_ger.Iconimage_Selected = Nothing
        Me.Btn_save_ger.IconMarginLeft = 0
        Me.Btn_save_ger.IconMarginRight = 0
        Me.Btn_save_ger.IconRightVisible = True
        Me.Btn_save_ger.IconRightZoom = 0R
        Me.Btn_save_ger.IconVisible = True
        Me.Btn_save_ger.IconZoom = 90.0R
        Me.Btn_save_ger.IsTab = False
        Me.Btn_save_ger.Location = New System.Drawing.Point(0, 249)
        Me.Btn_save_ger.Name = "Btn_save_ger"
        Me.Btn_save_ger.Normalcolor = System.Drawing.Color.DimGray
        Me.Btn_save_ger.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_save_ger.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_save_ger.selected = False
        Me.Btn_save_ger.Size = New System.Drawing.Size(304, 34)
        Me.Btn_save_ger.TabIndex = 163
        Me.Btn_save_ger.Text = "Save"
        Me.Btn_save_ger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_save_ger.Textcolor = System.Drawing.Color.White
        Me.Btn_save_ger.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LreqnumGer
        '
        Me.LreqnumGer.AutoSize = True
        Me.LreqnumGer.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LreqnumGer.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LreqnumGer.ForeColor = System.Drawing.Color.White
        Me.LreqnumGer.Location = New System.Drawing.Point(0, 166)
        Me.LreqnumGer.Name = "LreqnumGer"
        Me.LreqnumGer.Size = New System.Drawing.Size(21, 15)
        Me.LreqnumGer.TabIndex = 151
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
        Me.LvarietyGer.Location = New System.Drawing.Point(122, 166)
        Me.LvarietyGer.Margin = New System.Windows.Forms.Padding(3, 0, 3, 6)
        Me.LvarietyGer.Name = "LvarietyGer"
        Me.LvarietyGer.Size = New System.Drawing.Size(46, 15)
        Me.LvarietyGer.TabIndex = 152
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
        Me.MetroLabel9.Location = New System.Drawing.Point(0, 151)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(93, 15)
        Me.MetroLabel9.TabIndex = 153
        Me.MetroLabel9.Text = "Request Number"
        Me.MetroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'LfarmerGer
        '
        Me.LfarmerGer.AutoSize = True
        Me.LfarmerGer.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LfarmerGer.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LfarmerGer.ForeColor = System.Drawing.Color.White
        Me.LfarmerGer.Location = New System.Drawing.Point(234, 166)
        Me.LfarmerGer.Name = "LfarmerGer"
        Me.LfarmerGer.Size = New System.Drawing.Size(47, 15)
        Me.LfarmerGer.TabIndex = 154
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
        Me.MetroLabel5.Location = New System.Drawing.Point(122, 151)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(40, 15)
        Me.MetroLabel5.TabIndex = 155
        Me.MetroLabel5.Text = "Variety"
        Me.MetroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'LjobGer
        '
        Me.LjobGer.AutoSize = True
        Me.LjobGer.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LjobGer.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LjobGer.ForeColor = System.Drawing.Color.White
        Me.LjobGer.Location = New System.Drawing.Point(0, 206)
        Me.LjobGer.Name = "LjobGer"
        Me.LjobGer.Size = New System.Drawing.Size(49, 15)
        Me.LjobGer.TabIndex = 156
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
        Me.LLocationgGer.Location = New System.Drawing.Point(122, 206)
        Me.LLocationgGer.Name = "LLocationgGer"
        Me.LLocationgGer.Size = New System.Drawing.Size(54, 15)
        Me.LLocationgGer.TabIndex = 157
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
        Me.LharvestGer.Location = New System.Drawing.Point(234, 206)
        Me.LharvestGer.Name = "LharvestGer"
        Me.LharvestGer.Size = New System.Drawing.Size(51, 15)
        Me.LharvestGer.TabIndex = 158
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
        Me.MetroLabel6.Location = New System.Drawing.Point(234, 151)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(42, 15)
        Me.MetroLabel6.TabIndex = 159
        Me.MetroLabel6.Text = "Farmer"
        Me.MetroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel7.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel7.Location = New System.Drawing.Point(0, 191)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(88, 15)
        Me.MetroLabel7.TabIndex = 160
        Me.MetroLabel7.Text = "Manual/Job SAS"
        Me.MetroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel10.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel10.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel10.Location = New System.Drawing.Point(122, 191)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(49, 15)
        Me.MetroLabel10.TabIndex = 161
        Me.MetroLabel10.Text = "Location"
        Me.MetroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel11.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel11.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel11.Location = New System.Drawing.Point(234, 191)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(46, 15)
        Me.MetroLabel11.TabIndex = 162
        Me.MetroLabel11.Text = "Harvest"
        Me.MetroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'tlabnumGer
        '
        '
        '
        '
        Me.tlabnumGer.CustomButton.Image = Nothing
        Me.tlabnumGer.CustomButton.Location = New System.Drawing.Point(238, 1)
        Me.tlabnumGer.CustomButton.Name = ""
        Me.tlabnumGer.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tlabnumGer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tlabnumGer.CustomButton.TabIndex = 1
        Me.tlabnumGer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tlabnumGer.CustomButton.UseSelectable = True
        Me.tlabnumGer.CustomButton.Visible = False
        Me.tlabnumGer.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tlabnumGer.ForeColor = System.Drawing.Color.White
        Me.tlabnumGer.Lines = New String(-1) {}
        Me.tlabnumGer.Location = New System.Drawing.Point(0, 38)
        Me.tlabnumGer.MaxLength = 32767
        Me.tlabnumGer.Name = "tlabnumGer"
        Me.tlabnumGer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tlabnumGer.PromptText = "Lab Number"
        Me.tlabnumGer.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tlabnumGer.SelectedText = ""
        Me.tlabnumGer.SelectionLength = 0
        Me.tlabnumGer.SelectionStart = 0
        Me.tlabnumGer.ShortcutsEnabled = True
        Me.tlabnumGer.Size = New System.Drawing.Size(260, 23)
        Me.tlabnumGer.TabIndex = 149
        Me.tlabnumGer.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tlabnumGer.UseSelectable = True
        Me.tlabnumGer.WaterMark = "Lab Number"
        Me.tlabnumGer.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tlabnumGer.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'LabelGer
        '
        Me.LabelGer.AutoSize = True
        Me.LabelGer.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.LabelGer.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.LabelGer.Location = New System.Drawing.Point(0, 0)
        Me.LabelGer.Name = "LabelGer"
        Me.LabelGer.Size = New System.Drawing.Size(157, 25)
        Me.LabelGer.TabIndex = 148
        Me.LabelGer.Text = "Germination Vigor"
        Me.LabelGer.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'BtnFindGer
        '
        Me.BtnFindGer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnFindGer.Image = CType(resources.GetObject("BtnFindGer.Image"), System.Drawing.Image)
        Me.BtnFindGer.ImageActive = Nothing
        Me.BtnFindGer.Location = New System.Drawing.Point(266, 38)
        Me.BtnFindGer.Name = "BtnFindGer"
        Me.BtnFindGer.Size = New System.Drawing.Size(38, 23)
        Me.BtnFindGer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnFindGer.TabIndex = 150
        Me.BtnFindGer.TabStop = False
        Me.BtnFindGer.Zoom = 10
        '
        'CheckIn1Count
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroLabel87)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.LabelDate1)
        Me.Controls.Add(Me.Btn_del_ger)
        Me.Controls.Add(Me.Btn_save_ger)
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
        Me.Controls.Add(Me.tlabnumGer)
        Me.Controls.Add(Me.LabelGer)
        Me.Controls.Add(Me.BtnFindGer)
        Me.Name = "CheckIn1Count"
        Me.Size = New System.Drawing.Size(319, 326)
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        CType(Me.BtnFindGer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel87 As MetroLabel
    Friend WithEvents MetroPanel2 As MetroPanel
    Friend WithEvents tTestDateGer As MaskedTextBox
    Friend WithEvents LabelDate1 As MetroLabel
    Friend WithEvents Btn_del_ger As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_save_ger As Bunifu.Framework.UI.BunifuFlatButton
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
    Friend WithEvents tlabnumGer As MetroTextBox
    Friend WithEvents LabelGer As MetroLabel
    Friend WithEvents BtnFindGer As Bunifu.Framework.UI.BunifuImageButton
End Class
