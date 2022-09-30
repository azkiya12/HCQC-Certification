<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckReturnHCP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckReturnHCP))
        Me.MetroLabel87 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.tTestDate = New System.Windows.Forms.MaskedTextBox()
        Me.LabelDate1 = New MetroFramework.Controls.MetroLabel()
        Me.Btn_del = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_save = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Lreqnum = New MetroFramework.Controls.MetroLabel()
        Me.Lvariety = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.Lfarmer = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.Ljob = New MetroFramework.Controls.MetroLabel()
        Me.LLocationg = New MetroFramework.Controls.MetroLabel()
        Me.Lharvest = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.tlabnum = New MetroFramework.Controls.MetroTextBox()
        Me.LabelGer = New MetroFramework.Controls.MetroLabel()
        Me.BtnFind = New Bunifu.Framework.UI.BunifuImageButton()
        Me.MetroPanel2.SuspendLayout()
        CType(Me.BtnFind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel87
        '
        Me.MetroLabel87.AutoSize = True
        Me.MetroLabel87.Location = New System.Drawing.Point(0, 82)
        Me.MetroLabel87.Name = "MetroLabel87"
        Me.MetroLabel87.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel87.TabIndex = 167
        Me.MetroLabel87.Text = "Check Date "
        Me.MetroLabel87.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel2.Controls.Add(Me.tTestDate)
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
        'tTestDate
        '
        Me.tTestDate.BackColor = System.Drawing.Color.Black
        Me.tTestDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tTestDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tTestDate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tTestDate.ForeColor = System.Drawing.Color.White
        Me.tTestDate.Location = New System.Drawing.Point(1, 1)
        Me.tTestDate.Mask = "00/00/0000"
        Me.tTestDate.Name = "tTestDate"
        Me.tTestDate.Size = New System.Drawing.Size(119, 18)
        Me.tTestDate.TabIndex = 31
        Me.tTestDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tTestDate.ValidatingType = GetType(Date)
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
        'Btn_del
        '
        Me.Btn_del.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Btn_del.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_del.BackColor = System.Drawing.Color.Transparent
        Me.Btn_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_del.BorderRadius = 0
        Me.Btn_del.ButtonText = "Delete"
        Me.Btn_del.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_del.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_del.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_del.Iconimage = Nothing
        Me.Btn_del.Iconimage_right = Nothing
        Me.Btn_del.Iconimage_right_Selected = Nothing
        Me.Btn_del.Iconimage_Selected = Nothing
        Me.Btn_del.IconMarginLeft = 0
        Me.Btn_del.IconMarginRight = 0
        Me.Btn_del.IconRightVisible = True
        Me.Btn_del.IconRightZoom = 0R
        Me.Btn_del.IconVisible = True
        Me.Btn_del.IconZoom = 90.0R
        Me.Btn_del.IsTab = False
        Me.Btn_del.Location = New System.Drawing.Point(0, 289)
        Me.Btn_del.Name = "Btn_del"
        Me.Btn_del.Normalcolor = System.Drawing.Color.Transparent
        Me.Btn_del.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_del.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_del.selected = False
        Me.Btn_del.Size = New System.Drawing.Size(304, 34)
        Me.Btn_del.TabIndex = 164
        Me.Btn_del.Text = "Delete"
        Me.Btn_del.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_del.Textcolor = System.Drawing.Color.White
        Me.Btn_del.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_save
        '
        Me.Btn_save.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_save.BackColor = System.Drawing.Color.DimGray
        Me.Btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_save.BorderRadius = 0
        Me.Btn_save.ButtonText = "Save"
        Me.Btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_save.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_save.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_save.Iconimage = Nothing
        Me.Btn_save.Iconimage_right = Nothing
        Me.Btn_save.Iconimage_right_Selected = Nothing
        Me.Btn_save.Iconimage_Selected = Nothing
        Me.Btn_save.IconMarginLeft = 0
        Me.Btn_save.IconMarginRight = 0
        Me.Btn_save.IconRightVisible = True
        Me.Btn_save.IconRightZoom = 0R
        Me.Btn_save.IconVisible = True
        Me.Btn_save.IconZoom = 90.0R
        Me.Btn_save.IsTab = False
        Me.Btn_save.Location = New System.Drawing.Point(0, 249)
        Me.Btn_save.Name = "Btn_save"
        Me.Btn_save.Normalcolor = System.Drawing.Color.DimGray
        Me.Btn_save.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_save.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_save.selected = False
        Me.Btn_save.Size = New System.Drawing.Size(304, 34)
        Me.Btn_save.TabIndex = 163
        Me.Btn_save.Text = "Save"
        Me.Btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_save.Textcolor = System.Drawing.Color.White
        Me.Btn_save.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Lreqnum
        '
        Me.Lreqnum.AutoSize = True
        Me.Lreqnum.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Lreqnum.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Lreqnum.ForeColor = System.Drawing.Color.White
        Me.Lreqnum.Location = New System.Drawing.Point(0, 166)
        Me.Lreqnum.Name = "Lreqnum"
        Me.Lreqnum.Size = New System.Drawing.Size(21, 15)
        Me.Lreqnum.TabIndex = 151
        Me.Lreqnum.Text = "11"
        Me.Lreqnum.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Lreqnum.UseCustomForeColor = True
        '
        'Lvariety
        '
        Me.Lvariety.AutoSize = True
        Me.Lvariety.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Lvariety.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Lvariety.ForeColor = System.Drawing.Color.White
        Me.Lvariety.Location = New System.Drawing.Point(122, 166)
        Me.Lvariety.Margin = New System.Windows.Forms.Padding(3, 0, 3, 6)
        Me.Lvariety.Name = "Lvariety"
        Me.Lvariety.Size = New System.Drawing.Size(46, 15)
        Me.Lvariety.TabIndex = 152
        Me.Lvariety.Text = "Variety"
        Me.Lvariety.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Lvariety.UseCustomForeColor = True
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
        'Lfarmer
        '
        Me.Lfarmer.AutoSize = True
        Me.Lfarmer.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Lfarmer.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Lfarmer.ForeColor = System.Drawing.Color.White
        Me.Lfarmer.Location = New System.Drawing.Point(234, 166)
        Me.Lfarmer.Name = "Lfarmer"
        Me.Lfarmer.Size = New System.Drawing.Size(47, 15)
        Me.Lfarmer.TabIndex = 154
        Me.Lfarmer.Text = "Farmer"
        Me.Lfarmer.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Lfarmer.UseCustomForeColor = True
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
        'Ljob
        '
        Me.Ljob.AutoSize = True
        Me.Ljob.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Ljob.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Ljob.ForeColor = System.Drawing.Color.White
        Me.Ljob.Location = New System.Drawing.Point(0, 206)
        Me.Ljob.Name = "Ljob"
        Me.Ljob.Size = New System.Drawing.Size(49, 15)
        Me.Ljob.TabIndex = 156
        Me.Ljob.Text = "Job/Lot"
        Me.Ljob.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Ljob.UseCustomForeColor = True
        '
        'LLocationg
        '
        Me.LLocationg.AutoSize = True
        Me.LLocationg.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LLocationg.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LLocationg.ForeColor = System.Drawing.Color.White
        Me.LLocationg.Location = New System.Drawing.Point(122, 206)
        Me.LLocationg.Name = "LLocationg"
        Me.LLocationg.Size = New System.Drawing.Size(54, 15)
        Me.LLocationg.TabIndex = 157
        Me.LLocationg.Text = "Location"
        Me.LLocationg.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LLocationg.UseCustomForeColor = True
        '
        'Lharvest
        '
        Me.Lharvest.AutoSize = True
        Me.Lharvest.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Lharvest.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Lharvest.ForeColor = System.Drawing.Color.White
        Me.Lharvest.Location = New System.Drawing.Point(234, 206)
        Me.Lharvest.Name = "Lharvest"
        Me.Lharvest.Size = New System.Drawing.Size(51, 15)
        Me.Lharvest.TabIndex = 158
        Me.Lharvest.Text = "Harvest"
        Me.Lharvest.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Lharvest.UseCustomForeColor = True
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
        'tlabnum
        '
        '
        '
        '
        Me.tlabnum.CustomButton.Image = Nothing
        Me.tlabnum.CustomButton.Location = New System.Drawing.Point(238, 1)
        Me.tlabnum.CustomButton.Name = ""
        Me.tlabnum.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tlabnum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tlabnum.CustomButton.TabIndex = 1
        Me.tlabnum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tlabnum.CustomButton.UseSelectable = True
        Me.tlabnum.CustomButton.Visible = False
        Me.tlabnum.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tlabnum.ForeColor = System.Drawing.Color.White
        Me.tlabnum.Lines = New String(-1) {}
        Me.tlabnum.Location = New System.Drawing.Point(0, 38)
        Me.tlabnum.MaxLength = 32767
        Me.tlabnum.Name = "tlabnum"
        Me.tlabnum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tlabnum.PromptText = "Lab Number"
        Me.tlabnum.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tlabnum.SelectedText = ""
        Me.tlabnum.SelectionLength = 0
        Me.tlabnum.SelectionStart = 0
        Me.tlabnum.ShortcutsEnabled = True
        Me.tlabnum.Size = New System.Drawing.Size(260, 23)
        Me.tlabnum.TabIndex = 149
        Me.tlabnum.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tlabnum.UseSelectable = True
        Me.tlabnum.WaterMark = "Lab Number"
        Me.tlabnum.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tlabnum.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'LabelGer
        '
        Me.LabelGer.AutoSize = True
        Me.LabelGer.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.LabelGer.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.LabelGer.Location = New System.Drawing.Point(0, 0)
        Me.LabelGer.Name = "LabelGer"
        Me.LabelGer.Size = New System.Drawing.Size(102, 25)
        Me.LabelGer.TabIndex = 148
        Me.LabelGer.Text = "Return HCP"
        Me.LabelGer.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'BtnFind
        '
        Me.BtnFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.ImageActive = Nothing
        Me.BtnFind.Location = New System.Drawing.Point(266, 38)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(38, 23)
        Me.BtnFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnFind.TabIndex = 150
        Me.BtnFind.TabStop = False
        Me.BtnFind.Zoom = 10
        '
        'CheckReturnHCP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroLabel87)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.LabelDate1)
        Me.Controls.Add(Me.Btn_del)
        Me.Controls.Add(Me.Btn_save)
        Me.Controls.Add(Me.Lreqnum)
        Me.Controls.Add(Me.Lvariety)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.Lfarmer)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.Ljob)
        Me.Controls.Add(Me.LLocationg)
        Me.Controls.Add(Me.Lharvest)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.tlabnum)
        Me.Controls.Add(Me.LabelGer)
        Me.Controls.Add(Me.BtnFind)
        Me.Name = "CheckReturnHCP"
        Me.Size = New System.Drawing.Size(319, 326)
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        CType(Me.BtnFind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel87 As MetroLabel
    Friend WithEvents MetroPanel2 As MetroPanel
    Friend WithEvents tTestDate As MaskedTextBox
    Friend WithEvents LabelDate1 As MetroLabel
    Friend WithEvents Btn_del As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_save As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Lreqnum As MetroLabel
    Friend WithEvents Lvariety As MetroLabel
    Friend WithEvents MetroLabel9 As MetroLabel
    Friend WithEvents Lfarmer As MetroLabel
    Friend WithEvents MetroLabel5 As MetroLabel
    Friend WithEvents Ljob As MetroLabel
    Friend WithEvents LLocationg As MetroLabel
    Friend WithEvents Lharvest As MetroLabel
    Friend WithEvents MetroLabel6 As MetroLabel
    Friend WithEvents MetroLabel7 As MetroLabel
    Friend WithEvents MetroLabel10 As MetroLabel
    Friend WithEvents MetroLabel11 As MetroLabel
    Friend WithEvents tlabnum As MetroTextBox
    Friend WithEvents LabelGer As MetroLabel
    Friend WithEvents BtnFind As Bunifu.Framework.UI.BunifuImageButton
End Class
