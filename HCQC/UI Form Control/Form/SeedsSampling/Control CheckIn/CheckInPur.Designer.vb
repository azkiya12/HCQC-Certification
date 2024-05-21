<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckInPur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckInPur))
        Me.MetroLabel87 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.tTestDateGer = New System.Windows.Forms.MaskedTextBox()
        Me.LabelDate1 = New MetroFramework.Controls.MetroLabel()
        Me.Btn_del_Pur = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_save_Pur = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.LreqnumGer = New MetroFramework.Controls.MetroLabel()
        Me.LvarietyGer = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.LfarmerGer = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.LjobGer = New MetroFramework.Controls.MetroLabel()
        Me.LLocationGer = New MetroFramework.Controls.MetroLabel()
        Me.LharvestGer = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.tlabnumPur = New MetroFramework.Controls.MetroTextBox()
        Me.LabelPur = New MetroFramework.Controls.MetroLabel()
        Me.BtnFindPur = New Bunifu.Framework.UI.BunifuImageButton()
        Me.MetroPanel2.SuspendLayout()
        CType(Me.BtnFindPur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel87
        '
        Me.MetroLabel87.AutoSize = True
        Me.MetroLabel87.Location = New System.Drawing.Point(3, 84)
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
        Me.MetroPanel2.Location = New System.Drawing.Point(3, 106)
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
        Me.tTestDateGer.TabIndex = 31
        Me.tTestDateGer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tTestDateGer.ValidatingType = GetType(Date)
        '
        'LabelDate1
        '
        Me.LabelDate1.AutoSize = True
        Me.LabelDate1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelDate1.Location = New System.Drawing.Point(132, 111)
        Me.LabelDate1.Name = "LabelDate1"
        Me.LabelDate1.Size = New System.Drawing.Size(71, 15)
        Me.LabelDate1.TabIndex = 165
        Me.LabelDate1.Text = "dd-MM-yyyy"
        Me.LabelDate1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Btn_del_Pur
        '
        Me.Btn_del_Pur.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Btn_del_Pur.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_del_Pur.BackColor = System.Drawing.Color.Transparent
        Me.Btn_del_Pur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_del_Pur.BorderRadius = 0
        Me.Btn_del_Pur.ButtonText = "Delete"
        Me.Btn_del_Pur.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_del_Pur.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_del_Pur.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_del_Pur.Iconimage = Nothing
        Me.Btn_del_Pur.Iconimage_right = Nothing
        Me.Btn_del_Pur.Iconimage_right_Selected = Nothing
        Me.Btn_del_Pur.Iconimage_Selected = Nothing
        Me.Btn_del_Pur.IconMarginLeft = 0
        Me.Btn_del_Pur.IconMarginRight = 0
        Me.Btn_del_Pur.IconRightVisible = True
        Me.Btn_del_Pur.IconRightZoom = 0R
        Me.Btn_del_Pur.IconVisible = True
        Me.Btn_del_Pur.IconZoom = 90.0R
        Me.Btn_del_Pur.IsTab = False
        Me.Btn_del_Pur.Location = New System.Drawing.Point(3, 292)
        Me.Btn_del_Pur.Name = "Btn_del_Pur"
        Me.Btn_del_Pur.Normalcolor = System.Drawing.Color.Transparent
        Me.Btn_del_Pur.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_del_Pur.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_del_Pur.selected = False
        Me.Btn_del_Pur.Size = New System.Drawing.Size(304, 34)
        Me.Btn_del_Pur.TabIndex = 164
        Me.Btn_del_Pur.Text = "Delete"
        Me.Btn_del_Pur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_del_Pur.Textcolor = System.Drawing.Color.White
        Me.Btn_del_Pur.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_save_Pur
        '
        Me.Btn_save_Pur.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Btn_save_Pur.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_save_Pur.BackColor = System.Drawing.Color.DimGray
        Me.Btn_save_Pur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_save_Pur.BorderRadius = 0
        Me.Btn_save_Pur.ButtonText = "Save"
        Me.Btn_save_Pur.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_save_Pur.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_save_Pur.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_save_Pur.Iconimage = Nothing
        Me.Btn_save_Pur.Iconimage_right = Nothing
        Me.Btn_save_Pur.Iconimage_right_Selected = Nothing
        Me.Btn_save_Pur.Iconimage_Selected = Nothing
        Me.Btn_save_Pur.IconMarginLeft = 0
        Me.Btn_save_Pur.IconMarginRight = 0
        Me.Btn_save_Pur.IconRightVisible = True
        Me.Btn_save_Pur.IconRightZoom = 0R
        Me.Btn_save_Pur.IconVisible = True
        Me.Btn_save_Pur.IconZoom = 90.0R
        Me.Btn_save_Pur.IsTab = False
        Me.Btn_save_Pur.Location = New System.Drawing.Point(3, 252)
        Me.Btn_save_Pur.Name = "Btn_save_Pur"
        Me.Btn_save_Pur.Normalcolor = System.Drawing.Color.DimGray
        Me.Btn_save_Pur.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_save_Pur.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_save_Pur.selected = False
        Me.Btn_save_Pur.Size = New System.Drawing.Size(304, 34)
        Me.Btn_save_Pur.TabIndex = 163
        Me.Btn_save_Pur.Text = "Save"
        Me.Btn_save_Pur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_save_Pur.Textcolor = System.Drawing.Color.White
        Me.Btn_save_Pur.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LreqnumGer
        '
        Me.LreqnumGer.AutoSize = True
        Me.LreqnumGer.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LreqnumGer.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LreqnumGer.ForeColor = System.Drawing.Color.White
        Me.LreqnumGer.Location = New System.Drawing.Point(3, 168)
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
        Me.LvarietyGer.Location = New System.Drawing.Point(125, 168)
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
        Me.MetroLabel9.Location = New System.Drawing.Point(3, 153)
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
        Me.LfarmerGer.Location = New System.Drawing.Point(237, 168)
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
        Me.MetroLabel5.Location = New System.Drawing.Point(125, 153)
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
        Me.LjobGer.Location = New System.Drawing.Point(3, 208)
        Me.LjobGer.Name = "LjobGer"
        Me.LjobGer.Size = New System.Drawing.Size(49, 15)
        Me.LjobGer.TabIndex = 156
        Me.LjobGer.Text = "Job/Lot"
        Me.LjobGer.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LjobGer.UseCustomForeColor = True
        '
        'LLocationGer
        '
        Me.LLocationGer.AutoSize = True
        Me.LLocationGer.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LLocationGer.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LLocationGer.ForeColor = System.Drawing.Color.White
        Me.LLocationGer.Location = New System.Drawing.Point(125, 208)
        Me.LLocationGer.Name = "LLocationGer"
        Me.LLocationGer.Size = New System.Drawing.Size(54, 15)
        Me.LLocationGer.TabIndex = 157
        Me.LLocationGer.Text = "Location"
        Me.LLocationGer.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LLocationGer.UseCustomForeColor = True
        '
        'LharvestGer
        '
        Me.LharvestGer.AutoSize = True
        Me.LharvestGer.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LharvestGer.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LharvestGer.ForeColor = System.Drawing.Color.White
        Me.LharvestGer.Location = New System.Drawing.Point(237, 208)
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
        Me.MetroLabel6.Location = New System.Drawing.Point(237, 153)
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
        Me.MetroLabel7.Location = New System.Drawing.Point(3, 193)
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
        Me.MetroLabel10.Location = New System.Drawing.Point(125, 193)
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
        Me.MetroLabel11.Location = New System.Drawing.Point(237, 193)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(46, 15)
        Me.MetroLabel11.TabIndex = 162
        Me.MetroLabel11.Text = "Harvest"
        Me.MetroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'tlabnumPur
        '
        '
        '
        '
        Me.tlabnumPur.CustomButton.Image = Nothing
        Me.tlabnumPur.CustomButton.Location = New System.Drawing.Point(244, 1)
        Me.tlabnumPur.CustomButton.Name = ""
        Me.tlabnumPur.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tlabnumPur.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tlabnumPur.CustomButton.TabIndex = 1
        Me.tlabnumPur.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tlabnumPur.CustomButton.UseSelectable = True
        Me.tlabnumPur.CustomButton.Visible = False
        Me.tlabnumPur.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tlabnumPur.Lines = New String(-1) {}
        Me.tlabnumPur.Location = New System.Drawing.Point(3, 30)
        Me.tlabnumPur.MaxLength = 32767
        Me.tlabnumPur.Name = "tlabnumPur"
        Me.tlabnumPur.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tlabnumPur.PromptText = "Lab Number"
        Me.tlabnumPur.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tlabnumPur.SelectedText = ""
        Me.tlabnumPur.SelectionLength = 0
        Me.tlabnumPur.SelectionStart = 0
        Me.tlabnumPur.ShortcutsEnabled = True
        Me.tlabnumPur.Size = New System.Drawing.Size(266, 23)
        Me.tlabnumPur.TabIndex = 169
        Me.tlabnumPur.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tlabnumPur.UseSelectable = True
        Me.tlabnumPur.WaterMark = "Lab Number"
        Me.tlabnumPur.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tlabnumPur.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'LabelPur
        '
        Me.LabelPur.AutoSize = True
        Me.LabelPur.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.LabelPur.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.LabelPur.Location = New System.Drawing.Point(3, 0)
        Me.LabelPur.Name = "LabelPur"
        Me.LabelPur.Size = New System.Drawing.Size(92, 25)
        Me.LabelPur.TabIndex = 168
        Me.LabelPur.Text = "Purity Test"
        Me.LabelPur.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'BtnFindPur
        '
        Me.BtnFindPur.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnFindPur.Image = CType(resources.GetObject("BtnFindPur.Image"), System.Drawing.Image)
        Me.BtnFindPur.ImageActive = Nothing
        Me.BtnFindPur.Location = New System.Drawing.Point(275, 30)
        Me.BtnFindPur.Name = "BtnFindPur"
        Me.BtnFindPur.Size = New System.Drawing.Size(38, 23)
        Me.BtnFindPur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnFindPur.TabIndex = 170
        Me.BtnFindPur.TabStop = False
        Me.BtnFindPur.Zoom = 10
        '
        'CheckInPur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlabnumPur)
        Me.Controls.Add(Me.LabelPur)
        Me.Controls.Add(Me.BtnFindPur)
        Me.Controls.Add(Me.MetroLabel87)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.LabelDate1)
        Me.Controls.Add(Me.Btn_del_Pur)
        Me.Controls.Add(Me.Btn_save_Pur)
        Me.Controls.Add(Me.LreqnumGer)
        Me.Controls.Add(Me.LvarietyGer)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.LfarmerGer)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.LjobGer)
        Me.Controls.Add(Me.LLocationGer)
        Me.Controls.Add(Me.LharvestGer)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Name = "CheckInPur"
        Me.Size = New System.Drawing.Size(319, 326)
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        CType(Me.BtnFindPur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel87 As MetroLabel
    Friend WithEvents MetroPanel2 As MetroPanel
    Friend WithEvents tTestDateGer As MaskedTextBox
    Friend WithEvents LabelDate1 As MetroLabel
    Friend WithEvents Btn_del_Pur As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_save_Pur As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents LreqnumGer As MetroLabel
    Friend WithEvents LvarietyGer As MetroLabel
    Friend WithEvents MetroLabel9 As MetroLabel
    Friend WithEvents LfarmerGer As MetroLabel
    Friend WithEvents MetroLabel5 As MetroLabel
    Friend WithEvents LjobGer As MetroLabel
    Friend WithEvents LLocationGer As MetroLabel
    Friend WithEvents LharvestGer As MetroLabel
    Friend WithEvents MetroLabel6 As MetroLabel
    Friend WithEvents MetroLabel7 As MetroLabel
    Friend WithEvents MetroLabel10 As MetroLabel
    Friend WithEvents MetroLabel11 As MetroLabel
    Friend WithEvents tlabnumPur As MetroTextBox
    Friend WithEvents LabelPur As MetroLabel
    Friend WithEvents BtnFindPur As Bunifu.Framework.UI.BunifuImageButton
End Class
