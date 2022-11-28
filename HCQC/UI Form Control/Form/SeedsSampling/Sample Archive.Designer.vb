<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sample_Archive
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sample_Archive))
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.NavigationFrame1 = New DevExpress.XtraBars.Navigation.NavigationFrame()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.LinkDataList = New MetroFramework.Controls.MetroLink()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.tUnit = New MetroFramework.Controls.MetroComboBox()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.tKemasan = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.tKadarAir = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.tMurni = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.tDayaBerkecambah = New MetroFramework.Controls.MetroTextBox()
        Me.LabelDateExp = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.texpdate = New System.Windows.Forms.MaskedTextBox()
        Me.LabelDate = New MetroFramework.Controls.MetroLabel()
        Me.Lreqnum = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLink3 = New MetroFramework.Controls.MetroLink()
        Me.BtnDelete = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.tweight = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.tscope = New MetroFramework.Controls.MetroLabel()
        Me.tlabnum = New MetroFramework.Controls.MetroTextBox()
        Me.tharvest = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.tBoxnum = New MetroFramework.Controls.MetroTextBox()
        Me.tlotref = New MetroFramework.Controls.MetroLabel()
        Me.tlocation = New MetroFramework.Controls.MetroTextBox()
        Me.tnomnl = New MetroFramework.Controls.MetroLabel()
        Me.BtnFind = New Bunifu.Framework.UI.BunifuImageButton()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.tarchivedate = New System.Windows.Forms.MaskedTextBox()
        Me.tVariety = New MetroFramework.Controls.MetroLabel()
        Me.BtnUpdate = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.MetroPanel4 = New MetroFramework.Controls.MetroPanel()
        Me.LinkAll = New MetroFramework.Controls.MetroLink()
        Me.LinkThisMonth = New MetroFramework.Controls.MetroLink()
        Me.LinkLastMonth = New MetroFramework.Controls.MetroLink()
        Me.Tsearch = New MetroFramework.Controls.MetroTextBox()
        Me.LinkBack = New MetroFramework.Controls.MetroLink()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ReportarsipsampleviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_serverDataSet = New WindowsApplication1.HCQC_serverDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.collabnum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvariety = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnomnl = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collotid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collotqtt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbrt_in = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldatein = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colscope = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colarsipdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collokasi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colboxnum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldestroydate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colharvest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnojob = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colweight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldberkecambah = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkemurnian = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkadarair = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colexpired = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkemasan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colunit_kem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colinput_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Report_arsip_sample_viewTableAdapter = New WindowsApplication1.HCQC_serverDataSetTableAdapters.report_arsip_sample_viewTableAdapter()
        Me.colawal_exp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmasa_berlaku = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colP1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colP2 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavigationFrame1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationFrame1.SuspendLayout()
        Me.NavigationPage1.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroPanel3.SuspendLayout()
        CType(Me.BtnFind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel2.SuspendLayout()
        Me.NavigationPage2.SuspendLayout()
        Me.MetroPanel4.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportarsipsampleviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        Me.MetroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'NavigationFrame1
        '
        Me.NavigationFrame1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.NavigationFrame1.Appearance.Options.UseBackColor = True
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage1)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage2)
        Me.NavigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavigationFrame1.Location = New System.Drawing.Point(6, 6)
        Me.NavigationFrame1.Name = "NavigationFrame1"
        Me.NavigationFrame1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.NavigationPage1, Me.NavigationPage2})
        Me.NavigationFrame1.SelectedPage = Me.NavigationPage2
        Me.NavigationFrame1.Size = New System.Drawing.Size(701, 452)
        Me.NavigationFrame1.TabIndex = 281
        Me.NavigationFrame1.Text = "NavigationFrame1"
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Controls.Add(Me.LinkDataList)
        Me.NavigationPage1.Controls.Add(Me.MetroPanel1)
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Size = New System.Drawing.Size(701, 452)
        '
        'LinkDataList
        '
        Me.LinkDataList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkDataList.AutoSize = True
        Me.LinkDataList.BackColor = System.Drawing.Color.Transparent
        Me.LinkDataList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkDataList.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.LinkDataList.Location = New System.Drawing.Point(529, 3)
        Me.LinkDataList.Name = "LinkDataList"
        Me.LinkDataList.Size = New System.Drawing.Size(169, 23)
        Me.LinkDataList.TabIndex = 102
        Me.LinkDataList.TabStop = False
        Me.LinkDataList.Text = "Data List Archives |>"
        Me.LinkDataList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LinkDataList.UseCustomBackColor = True
        Me.LinkDataList.UseSelectable = True
        Me.LinkDataList.UseStyleColors = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.AutoScroll = True
        Me.MetroPanel1.Controls.Add(Me.tUnit)
        Me.MetroPanel1.Controls.Add(Me.BunifuSeparator2)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel17)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel16)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel15)
        Me.MetroPanel1.Controls.Add(Me.tKemasan)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel14)
        Me.MetroPanel1.Controls.Add(Me.tKadarAir)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel13)
        Me.MetroPanel1.Controls.Add(Me.tMurni)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel11)
        Me.MetroPanel1.Controls.Add(Me.tDayaBerkecambah)
        Me.MetroPanel1.Controls.Add(Me.LabelDateExp)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel12)
        Me.MetroPanel1.Controls.Add(Me.MetroPanel3)
        Me.MetroPanel1.Controls.Add(Me.LabelDate)
        Me.MetroPanel1.Controls.Add(Me.Lreqnum)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel10)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel9)
        Me.MetroPanel1.Controls.Add(Me.MetroLink3)
        Me.MetroPanel1.Controls.Add(Me.BtnDelete)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.Controls.Add(Me.tweight)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel6)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel7)
        Me.MetroPanel1.Controls.Add(Me.tscope)
        Me.MetroPanel1.Controls.Add(Me.tlabnum)
        Me.MetroPanel1.Controls.Add(Me.tharvest)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel8)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel1.Controls.Add(Me.tBoxnum)
        Me.MetroPanel1.Controls.Add(Me.tlotref)
        Me.MetroPanel1.Controls.Add(Me.tlocation)
        Me.MetroPanel1.Controls.Add(Me.tnomnl)
        Me.MetroPanel1.Controls.Add(Me.BtnFind)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel1.Controls.Add(Me.MetroPanel2)
        Me.MetroPanel1.Controls.Add(Me.tVariety)
        Me.MetroPanel1.Controls.Add(Me.BtnUpdate)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel1.HorizontalScrollbar = True
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 31)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(701, 421)
        Me.MetroPanel1.TabIndex = 1
        Me.MetroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroPanel1.VerticalScrollbar = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'tUnit
        '
        Me.tUnit.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.tUnit.FormattingEnabled = True
        Me.tUnit.ItemHeight = 19
        Me.tUnit.Items.AddRange(New Object() {"kg", "g", "Biji"})
        Me.tUnit.Location = New System.Drawing.Point(132, 224)
        Me.tUnit.Name = "tUnit"
        Me.tUnit.Size = New System.Drawing.Size(70, 25)
        Me.tUnit.TabIndex = 8
        Me.tUnit.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tUnit.UseSelectable = True
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(330, 3)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(13, 390)
        Me.BunifuSeparator2.TabIndex = 279
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = True
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MetroLabel17.Location = New System.Drawing.Point(349, 0)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(142, 19)
        Me.MetroLabel17.TabIndex = 278
        Me.MetroLabel17.Text = "Sample Information"
        Me.MetroLabel17.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel17.UseCustomForeColor = True
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel16.Location = New System.Drawing.Point(132, 206)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(94, 15)
        Me.MetroLabel16.TabIndex = 275
        Me.MetroLabel16.Text = "Satuan Kemasan"
        Me.MetroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel15.Location = New System.Drawing.Point(5, 206)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(88, 15)
        Me.MetroLabel15.TabIndex = 275
        Me.MetroLabel15.Text = "Netto Kemasan"
        Me.MetroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'tKemasan
        '
        '
        '
        '
        Me.tKemasan.CustomButton.Image = Nothing
        Me.tKemasan.CustomButton.Location = New System.Drawing.Point(75, 1)
        Me.tKemasan.CustomButton.Name = ""
        Me.tKemasan.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tKemasan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tKemasan.CustomButton.TabIndex = 1
        Me.tKemasan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tKemasan.CustomButton.UseSelectable = True
        Me.tKemasan.CustomButton.Visible = False
        Me.tKemasan.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tKemasan.Lines = New String(-1) {}
        Me.tKemasan.Location = New System.Drawing.Point(5, 224)
        Me.tKemasan.MaxLength = 32767
        Me.tKemasan.Name = "tKemasan"
        Me.tKemasan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tKemasan.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tKemasan.SelectedText = ""
        Me.tKemasan.SelectionLength = 0
        Me.tKemasan.SelectionStart = 0
        Me.tKemasan.ShortcutsEnabled = True
        Me.tKemasan.Size = New System.Drawing.Size(97, 23)
        Me.tKemasan.TabIndex = 7
        Me.tKemasan.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tKemasan.UseSelectable = True
        Me.tKemasan.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tKemasan.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel14.Location = New System.Drawing.Point(227, 149)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(55, 15)
        Me.MetroLabel14.TabIndex = 273
        Me.MetroLabel14.Text = "Kadar Air"
        Me.MetroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'tKadarAir
        '
        '
        '
        '
        Me.tKadarAir.CustomButton.Image = Nothing
        Me.tKadarAir.CustomButton.Location = New System.Drawing.Point(50, 1)
        Me.tKadarAir.CustomButton.Name = ""
        Me.tKadarAir.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tKadarAir.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tKadarAir.CustomButton.TabIndex = 1
        Me.tKadarAir.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tKadarAir.CustomButton.UseSelectable = True
        Me.tKadarAir.CustomButton.Visible = False
        Me.tKadarAir.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tKadarAir.Lines = New String(-1) {}
        Me.tKadarAir.Location = New System.Drawing.Point(227, 167)
        Me.tKadarAir.MaxLength = 32767
        Me.tKadarAir.Name = "tKadarAir"
        Me.tKadarAir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tKadarAir.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tKadarAir.SelectedText = ""
        Me.tKadarAir.SelectionLength = 0
        Me.tKadarAir.SelectionStart = 0
        Me.tKadarAir.ShortcutsEnabled = True
        Me.tKadarAir.Size = New System.Drawing.Size(72, 23)
        Me.tKadarAir.TabIndex = 6
        Me.tKadarAir.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tKadarAir.UseSelectable = True
        Me.tKadarAir.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tKadarAir.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel13.Location = New System.Drawing.Point(130, 149)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(72, 15)
        Me.MetroLabel13.TabIndex = 271
        Me.MetroLabel13.Text = "Benih Murni"
        Me.MetroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'tMurni
        '
        '
        '
        '
        Me.tMurni.CustomButton.Image = Nothing
        Me.tMurni.CustomButton.Location = New System.Drawing.Point(50, 1)
        Me.tMurni.CustomButton.Name = ""
        Me.tMurni.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tMurni.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tMurni.CustomButton.TabIndex = 1
        Me.tMurni.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tMurni.CustomButton.UseSelectable = True
        Me.tMurni.CustomButton.Visible = False
        Me.tMurni.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tMurni.Lines = New String(-1) {}
        Me.tMurni.Location = New System.Drawing.Point(130, 167)
        Me.tMurni.MaxLength = 32767
        Me.tMurni.Name = "tMurni"
        Me.tMurni.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tMurni.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tMurni.SelectedText = ""
        Me.tMurni.SelectionLength = 0
        Me.tMurni.SelectionStart = 0
        Me.tMurni.ShortcutsEnabled = True
        Me.tMurni.Size = New System.Drawing.Size(72, 23)
        Me.tMurni.TabIndex = 5
        Me.tMurni.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tMurni.UseSelectable = True
        Me.tMurni.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tMurni.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel11.Location = New System.Drawing.Point(5, 149)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(108, 15)
        Me.MetroLabel11.TabIndex = 269
        Me.MetroLabel11.Text = "Daya Berkecambah"
        Me.MetroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'tDayaBerkecambah
        '
        '
        '
        '
        Me.tDayaBerkecambah.CustomButton.Image = Nothing
        Me.tDayaBerkecambah.CustomButton.Location = New System.Drawing.Point(75, 1)
        Me.tDayaBerkecambah.CustomButton.Name = ""
        Me.tDayaBerkecambah.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tDayaBerkecambah.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tDayaBerkecambah.CustomButton.TabIndex = 1
        Me.tDayaBerkecambah.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tDayaBerkecambah.CustomButton.UseSelectable = True
        Me.tDayaBerkecambah.CustomButton.Visible = False
        Me.tDayaBerkecambah.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tDayaBerkecambah.Lines = New String(-1) {}
        Me.tDayaBerkecambah.Location = New System.Drawing.Point(5, 167)
        Me.tDayaBerkecambah.MaxLength = 32767
        Me.tDayaBerkecambah.Name = "tDayaBerkecambah"
        Me.tDayaBerkecambah.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tDayaBerkecambah.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tDayaBerkecambah.SelectedText = ""
        Me.tDayaBerkecambah.SelectionLength = 0
        Me.tDayaBerkecambah.SelectionStart = 0
        Me.tDayaBerkecambah.ShortcutsEnabled = True
        Me.tDayaBerkecambah.Size = New System.Drawing.Size(97, 23)
        Me.tDayaBerkecambah.TabIndex = 4
        Me.tDayaBerkecambah.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tDayaBerkecambah.UseSelectable = True
        Me.tDayaBerkecambah.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tDayaBerkecambah.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'LabelDateExp
        '
        Me.LabelDateExp.AutoSize = True
        Me.LabelDateExp.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelDateExp.Location = New System.Drawing.Point(227, 105)
        Me.LabelDateExp.Name = "LabelDateExp"
        Me.LabelDateExp.Size = New System.Drawing.Size(69, 15)
        Me.LabelDateExp.TabIndex = 267
        Me.LabelDateExp.Text = "*formatdate"
        Me.LabelDateExp.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel12.Location = New System.Drawing.Point(186, 61)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(73, 15)
        Me.MetroLabel12.TabIndex = 265
        Me.MetroLabel12.Text = "Expired Date"
        Me.MetroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroPanel3
        '
        Me.MetroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel3.Controls.Add(Me.texpdate)
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(186, 79)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.MetroPanel3.Size = New System.Drawing.Size(110, 23)
        Me.MetroPanel3.TabIndex = 3
        Me.MetroPanel3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroPanel3.UseStyleColors = True
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'texpdate
        '
        Me.texpdate.BackColor = System.Drawing.Color.Black
        Me.texpdate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.texpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.texpdate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texpdate.ForeColor = System.Drawing.Color.White
        Me.texpdate.Location = New System.Drawing.Point(1, 1)
        Me.texpdate.Mask = "00/00/0000"
        Me.texpdate.Name = "texpdate"
        Me.texpdate.Size = New System.Drawing.Size(106, 18)
        Me.texpdate.TabIndex = 0
        Me.texpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.texpdate.ValidatingType = GetType(Date)
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelDate.Location = New System.Drawing.Point(46, 105)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(69, 15)
        Me.LabelDate.TabIndex = 263
        Me.LabelDate.Text = "*formatdate"
        Me.LabelDate.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Lreqnum
        '
        Me.Lreqnum.AutoSize = True
        Me.Lreqnum.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Lreqnum.ForeColor = System.Drawing.Color.White
        Me.Lreqnum.Location = New System.Drawing.Point(349, 134)
        Me.Lreqnum.Name = "Lreqnum"
        Me.Lreqnum.Size = New System.Drawing.Size(21, 19)
        Me.Lreqnum.TabIndex = 261
        Me.Lreqnum.Text = "..."
        Me.Lreqnum.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Lreqnum.UseCustomForeColor = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.MetroLabel10.Location = New System.Drawing.Point(513, 119)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(38, 15)
        Me.MetroLabel10.TabIndex = 262
        Me.MetroLabel10.Text = "Scope"
        Me.MetroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.MetroLabel9.Location = New System.Drawing.Point(349, 119)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(93, 15)
        Me.MetroLabel9.TabIndex = 262
        Me.MetroLabel9.Text = "Request Number"
        Me.MetroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLink3
        '
        Me.MetroLink3.AutoSize = True
        Me.MetroLink3.BackColor = System.Drawing.Color.Transparent
        Me.MetroLink3.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.MetroLink3.Location = New System.Drawing.Point(118, 79)
        Me.MetroLink3.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLink3.Name = "MetroLink3"
        Me.MetroLink3.Size = New System.Drawing.Size(56, 23)
        Me.MetroLink3.TabIndex = 113
        Me.MetroLink3.Text = "Today..."
        Me.MetroLink3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLink3.UseSelectable = True
        Me.MetroLink3.UseStyleColors = True
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Transparent
        Me.BtnDelete.Enabled = False
        Me.BtnDelete.ForeColor = System.Drawing.Color.Black
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.ImageSize = 40
        Me.BtnDelete.Location = New System.Drawing.Point(5, 375)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(237, 34)
        Me.BtnDelete.TabIndex = 12
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.BtnDelete.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(73, 15)
        Me.MetroLabel1.TabIndex = 93
        Me.MetroLabel1.Text = "Lab Number"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'tweight
        '
        Me.tweight.AutoSize = True
        Me.tweight.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.tweight.ForeColor = System.Drawing.Color.White
        Me.tweight.Location = New System.Drawing.Point(513, 84)
        Me.tweight.Name = "tweight"
        Me.tweight.Size = New System.Drawing.Size(21, 19)
        Me.tweight.TabIndex = 108
        Me.tweight.Text = "..."
        Me.tweight.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tweight.UseCustomForeColor = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(5, 61)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(74, 15)
        Me.MetroLabel4.TabIndex = 98
        Me.MetroLabel4.Text = "Archive Date"
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel6.Location = New System.Drawing.Point(513, 69)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(64, 15)
        Me.MetroLabel6.TabIndex = 109
        Me.MetroLabel6.Text = "Weight (kg)"
        Me.MetroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel7.Location = New System.Drawing.Point(5, 266)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(74, 15)
        Me.MetroLabel7.TabIndex = 97
        Me.MetroLabel7.Text = "Box Number"
        Me.MetroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'tscope
        '
        Me.tscope.AutoSize = True
        Me.tscope.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.tscope.ForeColor = System.Drawing.Color.White
        Me.tscope.Location = New System.Drawing.Point(513, 134)
        Me.tscope.Name = "tscope"
        Me.tscope.Size = New System.Drawing.Size(21, 19)
        Me.tscope.TabIndex = 103
        Me.tscope.Text = "..."
        Me.tscope.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tscope.UseCustomForeColor = True
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
        Me.tlabnum.Location = New System.Drawing.Point(5, 18)
        Me.tlabnum.Margin = New System.Windows.Forms.Padding(3, 3, 3, 9)
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
        'tharvest
        '
        Me.tharvest.AutoSize = True
        Me.tharvest.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.tharvest.ForeColor = System.Drawing.Color.White
        Me.tharvest.Location = New System.Drawing.Point(513, 41)
        Me.tharvest.Name = "tharvest"
        Me.tharvest.Size = New System.Drawing.Size(21, 19)
        Me.tharvest.TabIndex = 104
        Me.tharvest.Text = "..."
        Me.tharvest.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tharvest.UseCustomForeColor = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel8.Location = New System.Drawing.Point(132, 266)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(53, 15)
        Me.MetroLabel8.TabIndex = 97
        Me.MetroLabel8.Text = "Location"
        Me.MetroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.Location = New System.Drawing.Point(513, 26)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(73, 15)
        Me.MetroLabel5.TabIndex = 105
        Me.MetroLabel5.Text = "Harvest Date"
        Me.MetroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'tBoxnum
        '
        '
        '
        '
        Me.tBoxnum.CustomButton.Image = Nothing
        Me.tBoxnum.CustomButton.Location = New System.Drawing.Point(75, 1)
        Me.tBoxnum.CustomButton.Name = ""
        Me.tBoxnum.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tBoxnum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tBoxnum.CustomButton.TabIndex = 1
        Me.tBoxnum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tBoxnum.CustomButton.UseSelectable = True
        Me.tBoxnum.CustomButton.Visible = False
        Me.tBoxnum.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tBoxnum.Lines = New String(-1) {}
        Me.tBoxnum.Location = New System.Drawing.Point(5, 284)
        Me.tBoxnum.MaxLength = 32767
        Me.tBoxnum.Name = "tBoxnum"
        Me.tBoxnum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tBoxnum.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tBoxnum.SelectedText = ""
        Me.tBoxnum.SelectionLength = 0
        Me.tBoxnum.SelectionStart = 0
        Me.tBoxnum.ShortcutsEnabled = True
        Me.tBoxnum.Size = New System.Drawing.Size(97, 23)
        Me.tBoxnum.TabIndex = 9
        Me.tBoxnum.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tBoxnum.UseSelectable = True
        Me.tBoxnum.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tBoxnum.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tlotref
        '
        Me.tlotref.AutoSize = True
        Me.tlotref.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.tlotref.ForeColor = System.Drawing.Color.White
        Me.tlotref.Location = New System.Drawing.Point(398, 84)
        Me.tlotref.Name = "tlotref"
        Me.tlotref.Size = New System.Drawing.Size(21, 19)
        Me.tlotref.TabIndex = 110
        Me.tlotref.Text = "..."
        Me.tlotref.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tlotref.UseCustomForeColor = True
        '
        'tlocation
        '
        '
        '
        '
        Me.tlocation.CustomButton.Image = Nothing
        Me.tlocation.CustomButton.Location = New System.Drawing.Point(88, 1)
        Me.tlocation.CustomButton.Name = ""
        Me.tlocation.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tlocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tlocation.CustomButton.TabIndex = 1
        Me.tlocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tlocation.CustomButton.UseSelectable = True
        Me.tlocation.CustomButton.Visible = False
        Me.tlocation.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tlocation.Lines = New String(-1) {}
        Me.tlocation.Location = New System.Drawing.Point(132, 284)
        Me.tlocation.MaxLength = 32767
        Me.tlocation.Name = "tlocation"
        Me.tlocation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tlocation.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tlocation.SelectedText = ""
        Me.tlocation.SelectionLength = 0
        Me.tlocation.SelectionStart = 0
        Me.tlocation.ShortcutsEnabled = True
        Me.tlocation.Size = New System.Drawing.Size(110, 23)
        Me.tlocation.TabIndex = 10
        Me.tlocation.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tlocation.UseSelectable = True
        Me.tlocation.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tlocation.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tnomnl
        '
        Me.tnomnl.AutoSize = True
        Me.tnomnl.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.tnomnl.ForeColor = System.Drawing.Color.White
        Me.tnomnl.Location = New System.Drawing.Point(349, 84)
        Me.tnomnl.Name = "tnomnl"
        Me.tnomnl.Size = New System.Drawing.Size(21, 19)
        Me.tnomnl.TabIndex = 111
        Me.tnomnl.Text = "..."
        Me.tnomnl.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tnomnl.UseCustomForeColor = True
        '
        'BtnFind
        '
        Me.BtnFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.ImageActive = Nothing
        Me.BtnFind.Location = New System.Drawing.Point(204, 18)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(38, 23)
        Me.BtnFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnFind.TabIndex = 100
        Me.BtnFind.TabStop = False
        Me.BtnFind.Zoom = 10
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel3.Location = New System.Drawing.Point(349, 69)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(93, 15)
        Me.MetroLabel3.TabIndex = 112
        Me.MetroLabel3.Text = "Manual    Lot/Job"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel2.Controls.Add(Me.tarchivedate)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(5, 79)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.MetroPanel2.Size = New System.Drawing.Size(110, 23)
        Me.MetroPanel2.TabIndex = 2
        Me.MetroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroPanel2.UseStyleColors = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'tarchivedate
        '
        Me.tarchivedate.BackColor = System.Drawing.Color.Black
        Me.tarchivedate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tarchivedate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tarchivedate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tarchivedate.ForeColor = System.Drawing.Color.White
        Me.tarchivedate.Location = New System.Drawing.Point(1, 1)
        Me.tarchivedate.Mask = "00/00/0000"
        Me.tarchivedate.Name = "tarchivedate"
        Me.tarchivedate.Size = New System.Drawing.Size(106, 18)
        Me.tarchivedate.TabIndex = 0
        Me.tarchivedate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tarchivedate.ValidatingType = GetType(Date)
        '
        'tVariety
        '
        Me.tVariety.AutoSize = True
        Me.tVariety.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.tVariety.ForeColor = System.Drawing.Color.White
        Me.tVariety.Location = New System.Drawing.Point(349, 41)
        Me.tVariety.Name = "tVariety"
        Me.tVariety.Size = New System.Drawing.Size(21, 19)
        Me.tVariety.TabIndex = 106
        Me.tVariety.Text = "..."
        Me.tVariety.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tVariety.UseCustomForeColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUpdate.BorderRadius = 0
        Me.BtnUpdate.ButtonText = "&Save"
        Me.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdate.DisabledColor = System.Drawing.Color.Gray
        Me.BtnUpdate.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnUpdate.Iconimage = CType(resources.GetObject("BtnUpdate.Iconimage"), System.Drawing.Image)
        Me.BtnUpdate.Iconimage_right = Nothing
        Me.BtnUpdate.Iconimage_right_Selected = Nothing
        Me.BtnUpdate.Iconimage_Selected = Nothing
        Me.BtnUpdate.IconMarginLeft = 0
        Me.BtnUpdate.IconMarginRight = 0
        Me.BtnUpdate.IconRightVisible = False
        Me.BtnUpdate.IconRightZoom = 0R
        Me.BtnUpdate.IconVisible = False
        Me.BtnUpdate.IconZoom = 90.0R
        Me.BtnUpdate.IsTab = True
        Me.BtnUpdate.Location = New System.Drawing.Point(5, 335)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnUpdate.OnHoverTextColor = System.Drawing.Color.Black
        Me.BtnUpdate.selected = True
        Me.BtnUpdate.Size = New System.Drawing.Size(237, 34)
        Me.BtnUpdate.TabIndex = 11
        Me.BtnUpdate.Text = "&Save"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnUpdate.Textcolor = System.Drawing.Color.White
        Me.BtnUpdate.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.Location = New System.Drawing.Point(349, 26)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(40, 15)
        Me.MetroLabel2.TabIndex = 107
        Me.MetroLabel2.Text = "Variety"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Controls.Add(Me.MetroPanel4)
        Me.NavigationPage2.Controls.Add(Me.Tsearch)
        Me.NavigationPage2.Controls.Add(Me.LinkBack)
        Me.NavigationPage2.Controls.Add(Me.GridControl1)
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Size = New System.Drawing.Size(701, 452)
        '
        'MetroPanel4
        '
        Me.MetroPanel4.Controls.Add(Me.LinkAll)
        Me.MetroPanel4.Controls.Add(Me.LinkThisMonth)
        Me.MetroPanel4.Controls.Add(Me.LinkLastMonth)
        Me.MetroPanel4.HorizontalScrollbarBarColor = True
        Me.MetroPanel4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.HorizontalScrollbarSize = 10
        Me.MetroPanel4.Location = New System.Drawing.Point(77, 3)
        Me.MetroPanel4.Name = "MetroPanel4"
        Me.MetroPanel4.Size = New System.Drawing.Size(190, 23)
        Me.MetroPanel4.TabIndex = 106
        Me.MetroPanel4.VerticalScrollbarBarColor = True
        Me.MetroPanel4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.VerticalScrollbarSize = 10
        '
        'LinkAll
        '
        Me.LinkAll.AutoSize = True
        Me.LinkAll.BackColor = System.Drawing.Color.Transparent
        Me.LinkAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkAll.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkAll.Location = New System.Drawing.Point(147, 0)
        Me.LinkAll.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkAll.Name = "LinkAll"
        Me.LinkAll.Size = New System.Drawing.Size(32, 23)
        Me.LinkAll.TabIndex = 102
        Me.LinkAll.Text = "All"
        Me.LinkAll.UseCustomBackColor = True
        Me.LinkAll.UseSelectable = True
        Me.LinkAll.UseStyleColors = True
        '
        'LinkThisMonth
        '
        Me.LinkThisMonth.AutoSize = True
        Me.LinkThisMonth.BackColor = System.Drawing.Color.Transparent
        Me.LinkThisMonth.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkThisMonth.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkThisMonth.Location = New System.Drawing.Point(0, 0)
        Me.LinkThisMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkThisMonth.Name = "LinkThisMonth"
        Me.LinkThisMonth.Size = New System.Drawing.Size(70, 23)
        Me.LinkThisMonth.TabIndex = 104
        Me.LinkThisMonth.Text = "This Month"
        Me.LinkThisMonth.UseCustomBackColor = True
        Me.LinkThisMonth.UseSelectable = True
        Me.LinkThisMonth.UseStyleColors = True
        '
        'LinkLastMonth
        '
        Me.LinkLastMonth.AutoSize = True
        Me.LinkLastMonth.BackColor = System.Drawing.Color.Transparent
        Me.LinkLastMonth.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLastMonth.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkLastMonth.Location = New System.Drawing.Point(70, 0)
        Me.LinkLastMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkLastMonth.Name = "LinkLastMonth"
        Me.LinkLastMonth.Size = New System.Drawing.Size(77, 23)
        Me.LinkLastMonth.TabIndex = 103
        Me.LinkLastMonth.Text = "Last Month"
        Me.LinkLastMonth.UseCustomBackColor = True
        Me.LinkLastMonth.UseSelectable = True
        Me.LinkLastMonth.UseStyleColors = True
        '
        'Tsearch
        '
        Me.Tsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Tsearch.CustomButton.Image = Global.WindowsApplication1.My.Resources.Resources.Find
        Me.Tsearch.CustomButton.Location = New System.Drawing.Point(168, 1)
        Me.Tsearch.CustomButton.Name = ""
        Me.Tsearch.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.Tsearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Tsearch.CustomButton.TabIndex = 1
        Me.Tsearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Tsearch.CustomButton.UseSelectable = True
        Me.Tsearch.Lines = New String(-1) {}
        Me.Tsearch.Location = New System.Drawing.Point(508, 3)
        Me.Tsearch.MaxLength = 32767
        Me.Tsearch.Name = "Tsearch"
        Me.Tsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Tsearch.PromptText = "Search..."
        Me.Tsearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Tsearch.SelectedText = ""
        Me.Tsearch.SelectionLength = 0
        Me.Tsearch.SelectionStart = 0
        Me.Tsearch.ShortcutsEnabled = True
        Me.Tsearch.ShowButton = True
        Me.Tsearch.Size = New System.Drawing.Size(190, 23)
        Me.Tsearch.TabIndex = 105
        Me.Tsearch.UseSelectable = True
        Me.Tsearch.WaterMark = "Search..."
        Me.Tsearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Tsearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'LinkBack
        '
        Me.LinkBack.AutoSize = True
        Me.LinkBack.BackColor = System.Drawing.Color.Transparent
        Me.LinkBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkBack.Location = New System.Drawing.Point(3, 3)
        Me.LinkBack.Name = "LinkBack"
        Me.LinkBack.Size = New System.Drawing.Size(68, 23)
        Me.LinkBack.TabIndex = 101
        Me.LinkBack.TabStop = False
        Me.LinkBack.Text = "<| Back"
        Me.LinkBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkBack.UseCustomBackColor = True
        Me.LinkBack.UseSelectable = True
        Me.LinkBack.UseStyleColors = True
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.ReportarsipsampleviewBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(3, 32)
        Me.GridControl1.LookAndFeel.SkinName = "The Bezier"
        Me.GridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(695, 417)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ReportarsipsampleviewBindingSource
        '
        Me.ReportarsipsampleviewBindingSource.DataMember = "report_arsip_sample_view"
        Me.ReportarsipsampleviewBindingSource.DataSource = Me.HCQC_serverDataSet
        '
        'HCQC_serverDataSet
        '
        Me.HCQC_serverDataSet.DataSetName = "HCQC_serverDataSet"
        Me.HCQC_serverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.collabnum, Me.colvariety, Me.colnomnl, Me.collotid, Me.collotqtt, Me.colbrt_in, Me.coldatein, Me.colscope, Me.colarsipdate, Me.collokasi, Me.colboxnum, Me.coldestroydate, Me.colharvest, Me.colnojob, Me.colweight, Me.coldberkecambah, Me.colkemurnian, Me.colkadarair, Me.colexpired, Me.colkemasan, Me.colunit_kem, Me.colinput_at, Me.colmasa_berlaku, Me.colawal_exp, Me.colP1, Me.colP2})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsCustomization.CustomizationFormSearchBoxVisible = True
        Me.GridView1.OptionsHint.ShowCellHints = False
        Me.GridView1.OptionsPrint.PrintDetails = True
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'collabnum
        '
        Me.collabnum.Caption = "Labnum"
        Me.collabnum.FieldName = "labnum"
        Me.collabnum.Name = "collabnum"
        Me.collabnum.Visible = True
        Me.collabnum.VisibleIndex = 1
        Me.collabnum.Width = 135
        '
        'colvariety
        '
        Me.colvariety.Caption = "Variety"
        Me.colvariety.FieldName = "variety"
        Me.colvariety.Name = "colvariety"
        Me.colvariety.Visible = True
        Me.colvariety.VisibleIndex = 2
        Me.colvariety.Width = 156
        '
        'colnomnl
        '
        Me.colnomnl.Caption = "Manual"
        Me.colnomnl.FieldName = "nomnl"
        Me.colnomnl.Name = "colnomnl"
        '
        'collotid
        '
        Me.collotid.Caption = "ID"
        Me.collotid.FieldName = "lotid"
        Me.collotid.Name = "collotid"
        '
        'collotqtt
        '
        Me.collotqtt.Caption = "Lot_Qtt"
        Me.collotqtt.FieldName = "lotqtt"
        Me.collotqtt.Name = "collotqtt"
        '
        'colbrt_in
        '
        Me.colbrt_in.Caption = "Weight (gr)"
        Me.colbrt_in.FieldName = "brt_in"
        Me.colbrt_in.Name = "colbrt_in"
        '
        'coldatein
        '
        Me.coldatein.Caption = "Date_in"
        Me.coldatein.FieldName = "datein"
        Me.coldatein.Name = "coldatein"
        '
        'colscope
        '
        Me.colscope.Caption = "Scope"
        Me.colscope.FieldName = "scope"
        Me.colscope.Name = "colscope"
        '
        'colarsipdate
        '
        Me.colarsipdate.Caption = "Arsip Date"
        Me.colarsipdate.FieldName = "arsipdate"
        Me.colarsipdate.Name = "colarsipdate"
        '
        'collokasi
        '
        Me.collokasi.Caption = "Location"
        Me.collokasi.FieldName = "lokasi"
        Me.collokasi.Name = "collokasi"
        '
        'colboxnum
        '
        Me.colboxnum.Caption = "Box No"
        Me.colboxnum.FieldName = "boxnum"
        Me.colboxnum.Name = "colboxnum"
        Me.colboxnum.Visible = True
        Me.colboxnum.VisibleIndex = 0
        Me.colboxnum.Width = 95
        '
        'coldestroydate
        '
        Me.coldestroydate.Caption = "Destroy_Date"
        Me.coldestroydate.FieldName = "destroydate"
        Me.coldestroydate.Name = "coldestroydate"
        '
        'colharvest
        '
        Me.colharvest.Caption = "Harvest_Date"
        Me.colharvest.FieldName = "harvest"
        Me.colharvest.Name = "colharvest"
        '
        'colnojob
        '
        Me.colnojob.Caption = "Job/Lot No"
        Me.colnojob.FieldName = "nojob"
        Me.colnojob.Name = "colnojob"
        Me.colnojob.Visible = True
        Me.colnojob.VisibleIndex = 3
        Me.colnojob.Width = 101
        '
        'colweight
        '
        Me.colweight.Caption = "Weight (kg)"
        Me.colweight.FieldName = "weight"
        Me.colweight.Name = "colweight"
        '
        'coldberkecambah
        '
        Me.coldberkecambah.Caption = "DB"
        Me.coldberkecambah.FieldName = "dberkecambah"
        Me.coldberkecambah.Name = "coldberkecambah"
        Me.coldberkecambah.Visible = True
        Me.coldberkecambah.VisibleIndex = 4
        Me.coldberkecambah.Width = 64
        '
        'colkemurnian
        '
        Me.colkemurnian.Caption = "Purity"
        Me.colkemurnian.FieldName = "kemurnian"
        Me.colkemurnian.Name = "colkemurnian"
        Me.colkemurnian.Visible = True
        Me.colkemurnian.VisibleIndex = 5
        Me.colkemurnian.Width = 67
        '
        'colkadarair
        '
        Me.colkadarair.Caption = "KA"
        Me.colkadarair.FieldName = "kadarair"
        Me.colkadarair.Name = "colkadarair"
        Me.colkadarair.Visible = True
        Me.colkadarair.VisibleIndex = 6
        Me.colkadarair.Width = 56
        '
        'colexpired
        '
        Me.colexpired.Caption = "Exp. Date"
        Me.colexpired.FieldName = "expired"
        Me.colexpired.Name = "colexpired"
        Me.colexpired.Visible = True
        Me.colexpired.VisibleIndex = 7
        Me.colexpired.Width = 81
        '
        'colkemasan
        '
        Me.colkemasan.Caption = "Packaging"
        Me.colkemasan.FieldName = "kemasan"
        Me.colkemasan.Name = "colkemasan"
        Me.colkemasan.Visible = True
        Me.colkemasan.VisibleIndex = 8
        Me.colkemasan.Width = 81
        '
        'colunit_kem
        '
        Me.colunit_kem.Caption = "Pack Unit"
        Me.colunit_kem.FieldName = "unit_kem"
        Me.colunit_kem.Name = "colunit_kem"
        Me.colunit_kem.Visible = True
        Me.colunit_kem.VisibleIndex = 9
        Me.colunit_kem.Width = 81
        '
        'colinput_at
        '
        Me.colinput_at.Caption = "Input_at"
        Me.colinput_at.FieldName = "input_at"
        Me.colinput_at.Name = "colinput_at"
        Me.colinput_at.Visible = True
        Me.colinput_at.VisibleIndex = 10
        Me.colinput_at.Width = 100
        '
        'Report_arsip_sample_viewTableAdapter
        '
        Me.Report_arsip_sample_viewTableAdapter.ClearBeforeFill = True
        '
        'colawal_exp
        '
        Me.colawal_exp.FieldName = "awal_exp"
        Me.colawal_exp.Name = "colawal_exp"
        '
        'colmasa_berlaku
        '
        Me.colmasa_berlaku.FieldName = "masa_berlaku"
        Me.colmasa_berlaku.Name = "colmasa_berlaku"
        '
        'colP1
        '
        Me.colP1.FieldName = "P1"
        Me.colP1.Name = "colP1"
        '
        'colP2
        '
        Me.colP2.FieldName = "P2"
        Me.colP2.Name = "colP2"
        '
        'Sample_Archive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.NavigationFrame1)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Sample_Archive"
        Me.Padding = New System.Windows.Forms.Padding(6)
        Me.Size = New System.Drawing.Size(713, 464)
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavigationFrame1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationFrame1.ResumeLayout(False)
        Me.NavigationPage1.ResumeLayout(False)
        Me.NavigationPage1.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.MetroPanel3.ResumeLayout(False)
        Me.MetroPanel3.PerformLayout()
        CType(Me.BtnFind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.NavigationPage2.ResumeLayout(False)
        Me.NavigationPage2.PerformLayout()
        Me.MetroPanel4.ResumeLayout(False)
        Me.MetroPanel4.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportarsipsampleviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroStyleExtender1 As Components.MetroStyleExtender
    Friend WithEvents MetroStyleManager1 As Components.MetroStyleManager
    Friend WithEvents NavigationFrame1 As DevExpress.XtraBars.Navigation.NavigationFrame
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents MetroPanel1 As MetroPanel
    Friend WithEvents tUnit As MetroComboBox
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents MetroLabel17 As MetroLabel
    Friend WithEvents MetroLabel16 As MetroLabel
    Friend WithEvents MetroLabel15 As MetroLabel
    Friend WithEvents tKemasan As MetroTextBox
    Friend WithEvents MetroLabel14 As MetroLabel
    Friend WithEvents tKadarAir As MetroTextBox
    Friend WithEvents MetroLabel13 As MetroLabel
    Friend WithEvents tMurni As MetroTextBox
    Friend WithEvents MetroLabel11 As MetroLabel
    Friend WithEvents tDayaBerkecambah As MetroTextBox
    Friend WithEvents LabelDateExp As MetroLabel
    Friend WithEvents MetroLabel12 As MetroLabel
    Friend WithEvents MetroPanel3 As MetroPanel
    Friend WithEvents texpdate As MaskedTextBox
    Friend WithEvents LabelDate As MetroLabel
    Friend WithEvents Lreqnum As MetroLabel
    Friend WithEvents MetroLabel10 As MetroLabel
    Friend WithEvents MetroLabel9 As MetroLabel
    Friend WithEvents MetroLink3 As MetroLink
    Friend WithEvents BtnDelete As MetroLink
    Friend WithEvents MetroLabel1 As MetroLabel
    Friend WithEvents tweight As MetroLabel
    Friend WithEvents MetroLabel4 As MetroLabel
    Friend WithEvents MetroLabel6 As MetroLabel
    Friend WithEvents MetroLabel7 As MetroLabel
    Friend WithEvents tscope As MetroLabel
    Friend WithEvents tlabnum As MetroTextBox
    Friend WithEvents tharvest As MetroLabel
    Friend WithEvents MetroLabel8 As MetroLabel
    Friend WithEvents MetroLabel5 As MetroLabel
    Friend WithEvents tBoxnum As MetroTextBox
    Friend WithEvents tlotref As MetroLabel
    Friend WithEvents tlocation As MetroTextBox
    Friend WithEvents tnomnl As MetroLabel
    Friend WithEvents BtnFind As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents MetroLabel3 As MetroLabel
    Friend WithEvents MetroPanel2 As MetroPanel
    Friend WithEvents tarchivedate As MaskedTextBox
    Friend WithEvents tVariety As MetroLabel
    Friend WithEvents BtnUpdate As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MetroLabel2 As MetroLabel
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ReportarsipsampleviewBindingSource As BindingSource
    Friend WithEvents HCQC_serverDataSet As HCQC_serverDataSet
    Friend WithEvents collabnum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvariety As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnomnl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collotid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collotqtt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbrt_in As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldatein As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colscope As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colarsipdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collokasi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colboxnum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldestroydate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colharvest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnojob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colweight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldberkecambah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkemurnian As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkadarair As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colexpired As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkemasan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colunit_kem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colinput_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Report_arsip_sample_viewTableAdapter As HCQC_serverDataSetTableAdapters.report_arsip_sample_viewTableAdapter
    Friend WithEvents LinkBack As MetroLink
    Friend WithEvents LinkDataList As MetroLink
    Friend WithEvents LinkAll As MetroLink
    Friend WithEvents LinkLastMonth As MetroLink
    Friend WithEvents LinkThisMonth As MetroLink
    Friend WithEvents Tsearch As MetroTextBox
    Friend WithEvents MetroPanel4 As MetroPanel
    Friend WithEvents colmasa_berlaku As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colawal_exp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colP1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colP2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
