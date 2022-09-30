<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sample_Control
    Inherits MetroFramework.Controls.MetroUserControl

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sample_Control))
        Me.BtnFind = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tlabnum = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.ttestdate = New System.Windows.Forms.MaskedTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.tscope = New MetroFramework.Controls.MetroLabel()
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.tVariety = New MetroFramework.Controls.MetroLabel()
        Me.tnomnl = New MetroFramework.Controls.MetroLabel()
        Me.tharvest = New MetroFramework.Controls.MetroLabel()
        Me.tweight = New MetroFramework.Controls.MetroLabel()
        Me.tlotref = New MetroFramework.Controls.MetroLabel()
        Me.BtnDelete = New MetroFramework.Controls.MetroLink()
        Me.MetroLink3 = New MetroFramework.Controls.MetroLink()
        Me.Lreqnum = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.BtnUpdate = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.LabelKategori = New MetroFramework.Controls.MetroLabel()
        Me.LabelDate1 = New MetroFramework.Controls.MetroLabel()
        CType(Me.BtnFind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel2.SuspendLayout()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnFind
        '
        Me.BtnFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.ImageActive = Nothing
        Me.BtnFind.Location = New System.Drawing.Point(217, 52)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(38, 23)
        Me.BtnFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnFind.TabIndex = 85
        Me.BtnFind.TabStop = False
        Me.BtnFind.Zoom = 10
        '
        'tlabnum
        '
        '
        '
        '
        Me.tlabnum.CustomButton.Image = Nothing
        Me.tlabnum.CustomButton.Location = New System.Drawing.Point(171, 1)
        Me.tlabnum.CustomButton.Name = ""
        Me.tlabnum.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tlabnum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tlabnum.CustomButton.TabIndex = 1
        Me.tlabnum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tlabnum.CustomButton.UseSelectable = True
        Me.tlabnum.CustomButton.Visible = False
        Me.tlabnum.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tlabnum.Lines = New String(-1) {}
        Me.tlabnum.Location = New System.Drawing.Point(18, 52)
        Me.tlabnum.MaxLength = 32767
        Me.tlabnum.Name = "tlabnum"
        Me.tlabnum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tlabnum.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tlabnum.SelectedText = ""
        Me.tlabnum.SelectionLength = 0
        Me.tlabnum.SelectionStart = 0
        Me.tlabnum.ShortcutsEnabled = True
        Me.tlabnum.Size = New System.Drawing.Size(193, 23)
        Me.tlabnum.TabIndex = 1
        Me.tlabnum.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tlabnum.UseSelectable = True
        Me.tlabnum.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tlabnum.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel3.Location = New System.Drawing.Point(18, 132)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(93, 15)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "Manual    Lot/Job"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.Location = New System.Drawing.Point(18, 89)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(40, 15)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Variety"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(18, 34)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(73, 15)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Lab Number"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel2.Controls.Add(Me.ttestdate)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(18, 248)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.MetroPanel2.Size = New System.Drawing.Size(110, 23)
        Me.MetroPanel2.TabIndex = 16
        Me.MetroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroPanel2.UseStyleColors = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'ttestdate
        '
        Me.ttestdate.BackColor = System.Drawing.Color.Black
        Me.ttestdate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ttestdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ttestdate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttestdate.ForeColor = System.Drawing.Color.White
        Me.ttestdate.Location = New System.Drawing.Point(1, 1)
        Me.ttestdate.Mask = "00/00/0000"
        Me.ttestdate.Name = "ttestdate"
        Me.ttestdate.Size = New System.Drawing.Size(106, 18)
        Me.ttestdate.TabIndex = 0
        Me.ttestdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttestdate.ValidatingType = GetType(Date)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(18, 230)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(54, 15)
        Me.MetroLabel4.TabIndex = 8
        Me.MetroLabel4.Text = "Date Test"
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.Location = New System.Drawing.Point(182, 89)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(73, 15)
        Me.MetroLabel5.TabIndex = 3
        Me.MetroLabel5.Text = "Harvest Date"
        Me.MetroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel6.Location = New System.Drawing.Point(182, 132)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(64, 15)
        Me.MetroLabel6.TabIndex = 5
        Me.MetroLabel6.Text = "Weight (kg)"
        Me.MetroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'tscope
        '
        Me.tscope.AutoSize = True
        Me.tscope.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.tscope.ForeColor = System.Drawing.Color.White
        Me.tscope.Location = New System.Drawing.Point(182, 194)
        Me.tscope.Name = "tscope"
        Me.tscope.Size = New System.Drawing.Size(21, 19)
        Me.tscope.TabIndex = 15
        Me.tscope.Text = "..."
        Me.tscope.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tscope.UseCustomForeColor = True
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        Me.MetroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'tVariety
        '
        Me.tVariety.AutoSize = True
        Me.tVariety.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.tVariety.ForeColor = System.Drawing.Color.White
        Me.tVariety.Location = New System.Drawing.Point(18, 104)
        Me.tVariety.Name = "tVariety"
        Me.tVariety.Size = New System.Drawing.Size(21, 19)
        Me.tVariety.TabIndex = 9
        Me.tVariety.Text = "..."
        Me.tVariety.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tVariety.UseCustomForeColor = True
        '
        'tnomnl
        '
        Me.tnomnl.AutoSize = True
        Me.tnomnl.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.tnomnl.ForeColor = System.Drawing.Color.White
        Me.tnomnl.Location = New System.Drawing.Point(18, 147)
        Me.tnomnl.Name = "tnomnl"
        Me.tnomnl.Size = New System.Drawing.Size(21, 19)
        Me.tnomnl.TabIndex = 11
        Me.tnomnl.Text = "..."
        Me.tnomnl.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tnomnl.UseCustomForeColor = True
        '
        'tharvest
        '
        Me.tharvest.AutoSize = True
        Me.tharvest.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.tharvest.ForeColor = System.Drawing.Color.White
        Me.tharvest.Location = New System.Drawing.Point(182, 104)
        Me.tharvest.Name = "tharvest"
        Me.tharvest.Size = New System.Drawing.Size(21, 19)
        Me.tharvest.TabIndex = 10
        Me.tharvest.Text = "..."
        Me.tharvest.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tharvest.UseCustomForeColor = True
        '
        'tweight
        '
        Me.tweight.AutoSize = True
        Me.tweight.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.tweight.ForeColor = System.Drawing.Color.White
        Me.tweight.Location = New System.Drawing.Point(182, 147)
        Me.tweight.Name = "tweight"
        Me.tweight.Size = New System.Drawing.Size(21, 19)
        Me.tweight.TabIndex = 13
        Me.tweight.Text = "..."
        Me.tweight.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tweight.UseCustomForeColor = True
        '
        'tlotref
        '
        Me.tlotref.AutoSize = True
        Me.tlotref.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.tlotref.ForeColor = System.Drawing.Color.White
        Me.tlotref.Location = New System.Drawing.Point(65, 147)
        Me.tlotref.Name = "tlotref"
        Me.tlotref.Size = New System.Drawing.Size(21, 19)
        Me.tlotref.TabIndex = 12
        Me.tlotref.Text = "..."
        Me.tlotref.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tlotref.UseCustomForeColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Transparent
        Me.BtnDelete.ForeColor = System.Drawing.Color.Black
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.ImageSize = 40
        Me.BtnDelete.Location = New System.Drawing.Point(18, 337)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(237, 39)
        Me.BtnDelete.TabIndex = 21
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.BtnDelete.UseSelectable = True
        '
        'MetroLink3
        '
        Me.MetroLink3.AutoSize = True
        Me.MetroLink3.BackColor = System.Drawing.Color.Transparent
        Me.MetroLink3.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.MetroLink3.Location = New System.Drawing.Point(131, 248)
        Me.MetroLink3.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLink3.Name = "MetroLink3"
        Me.MetroLink3.Size = New System.Drawing.Size(56, 23)
        Me.MetroLink3.TabIndex = 17
        Me.MetroLink3.TabStop = False
        Me.MetroLink3.Text = "Today..."
        Me.MetroLink3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLink3.UseSelectable = True
        Me.MetroLink3.UseStyleColors = True
        '
        'Lreqnum
        '
        Me.Lreqnum.AutoSize = True
        Me.Lreqnum.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Lreqnum.ForeColor = System.Drawing.Color.White
        Me.Lreqnum.Location = New System.Drawing.Point(18, 194)
        Me.Lreqnum.Name = "Lreqnum"
        Me.Lreqnum.Size = New System.Drawing.Size(21, 19)
        Me.Lreqnum.TabIndex = 14
        Me.Lreqnum.Text = "..."
        Me.Lreqnum.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Lreqnum.UseCustomForeColor = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.MetroLabel7.Location = New System.Drawing.Point(20, 179)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(93, 15)
        Me.MetroLabel7.TabIndex = 6
        Me.MetroLabel7.Text = "Request Number"
        Me.MetroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnUpdate.Location = New System.Drawing.Point(18, 297)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(237, 34)
        Me.BtnUpdate.TabIndex = 20
        Me.BtnUpdate.Text = "&Update"
        Me.BtnUpdate.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.BtnUpdate.UseCustomBackColor = True
        Me.BtnUpdate.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.MetroLabel8.Location = New System.Drawing.Point(182, 179)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(38, 15)
        Me.MetroLabel8.TabIndex = 7
        Me.MetroLabel8.Text = "Scope"
        Me.MetroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroPanel1
        '
        Me.MetroPanel1.AutoScroll = True
        Me.MetroPanel1.Controls.Add(Me.MetroLabel9)
        Me.MetroPanel1.Controls.Add(Me.LabelKategori)
        Me.MetroPanel1.Controls.Add(Me.Lreqnum)
        Me.MetroPanel1.Controls.Add(Me.BtnUpdate)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel8)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel7)
        Me.MetroPanel1.Controls.Add(Me.tVariety)
        Me.MetroPanel1.Controls.Add(Me.MetroLink3)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel1.Controls.Add(Me.BtnDelete)
        Me.MetroPanel1.Controls.Add(Me.tnomnl)
        Me.MetroPanel1.Controls.Add(Me.MetroPanel2)
        Me.MetroPanel1.Controls.Add(Me.tlotref)
        Me.MetroPanel1.Controls.Add(Me.BtnFind)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel1.Controls.Add(Me.tlabnum)
        Me.MetroPanel1.Controls.Add(Me.tharvest)
        Me.MetroPanel1.Controls.Add(Me.tweight)
        Me.MetroPanel1.Controls.Add(Me.tscope)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel6)
        Me.MetroPanel1.Controls.Add(Me.LabelDate1)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel1.HorizontalScrollbar = True
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(282, 398)
        Me.MetroPanel1.TabIndex = 86
        Me.MetroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroPanel1.VerticalScrollbar = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MetroLabel9.Location = New System.Drawing.Point(3, 4)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(119, 19)
        Me.MetroLabel9.TabIndex = 87
        Me.MetroLabel9.Text = "Sample Check in"
        Me.MetroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel9.UseCustomForeColor = True
        '
        'LabelKategori
        '
        Me.LabelKategori.AutoSize = True
        Me.LabelKategori.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelKategori.ForeColor = System.Drawing.Color.Transparent
        Me.LabelKategori.Location = New System.Drawing.Point(132, 23)
        Me.LabelKategori.Name = "LabelKategori"
        Me.LabelKategori.Size = New System.Drawing.Size(123, 15)
        Me.LabelKategori.TabIndex = 86
        Me.LabelKategori.Text = "Nama Kategori Sample"
        Me.LabelKategori.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LabelKategori.UseCustomForeColor = True
        '
        'LabelDate1
        '
        Me.LabelDate1.AutoSize = True
        Me.LabelDate1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelDate1.Location = New System.Drawing.Point(55, 274)
        Me.LabelDate1.Name = "LabelDate1"
        Me.LabelDate1.Size = New System.Drawing.Size(73, 15)
        Me.LabelDate1.TabIndex = 8
        Me.LabelDate1.Text = "*DateFormat"
        Me.LabelDate1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LabelDate1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Sample_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroPanel1)
        Me.Name = "Sample_Control"
        Me.Size = New System.Drawing.Size(282, 398)
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.BtnFind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnFind As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents tlabnum As MetroTextBox
    Friend WithEvents MetroLabel3 As MetroLabel
    Friend WithEvents MetroLabel2 As MetroLabel
    Friend WithEvents MetroLabel1 As MetroLabel
    Friend WithEvents MetroPanel2 As MetroPanel
    Friend WithEvents ttestdate As MaskedTextBox
    Friend WithEvents MetroLabel4 As MetroLabel
    Friend WithEvents MetroLabel5 As MetroLabel
    Friend WithEvents MetroLabel6 As MetroLabel
    Friend WithEvents tscope As MetroLabel
    Friend WithEvents MetroStyleExtender1 As Components.MetroStyleExtender
    Friend WithEvents MetroStyleManager1 As Components.MetroStyleManager
    Friend WithEvents tweight As MetroLabel
    Friend WithEvents tharvest As MetroLabel
    Friend WithEvents tnomnl As MetroLabel
    Friend WithEvents tVariety As MetroLabel
    Friend WithEvents tlotref As MetroLabel
    Friend WithEvents BtnDelete As MetroLink
    Friend WithEvents MetroLink3 As MetroLink
    Friend WithEvents Lreqnum As MetroLabel
    Friend WithEvents MetroLabel7 As MetroLabel
    Friend WithEvents BtnUpdate As MetroButton
    Friend WithEvents MetroLabel8 As MetroLabel
    Friend WithEvents MetroPanel1 As MetroPanel
    Friend WithEvents LabelDate1 As MetroLabel
    Friend WithEvents LabelKategori As MetroLabel
    Friend WithEvents MetroLabel9 As MetroLabel
End Class
