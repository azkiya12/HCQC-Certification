<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Request_Sampling_From
    Inherits MetroFramework.Controls.MetroUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Request_Sampling_From))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.tid_hvsprod = New MetroFramework.Controls.MetroTextBox()
        Me.tgl_hvs = New System.Windows.Forms.MaskedTextBox()
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.Splrequest1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_NewDataset = New WindowsApplication1.HCQC_NewDataset()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colid_hvsprod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collabnum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcrop = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvariety = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfarmer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colharvest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colweight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbag = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnomnl = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnojob = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colloc_sample = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colscope = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnama_req = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltest_sampling = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltest_moi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltest_pur = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltest_ger = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltest_via = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltest_raf = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colinput_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstatus_confirm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colinformation_rejected = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltgl_confirm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.Tsearch = New MetroFramework.Controls.MetroTextBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.tloc_sample = New MetroFramework.Controls.MetroComboBox()
        Me.LinkFind = New MetroFramework.Controls.MetroLink()
        Me.BtnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.tcrop = New MetroFramework.Controls.MetroTextBox()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.LinkSelectallRequest = New MetroFramework.Controls.MetroLink()
        Me.tbag = New MetroFramework.Controls.MetroTextBox()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.LinkClearRequest = New MetroFramework.Controls.MetroLink()
        Me.tremark = New MetroFramework.Controls.MetroTextBox()
        Me.traf = New MetroFramework.Controls.MetroCheckBox()
        Me.tvia = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.tger = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.tpur = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.tmoi = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.tsampling = New MetroFramework.Controls.MetroCheckBox()
        Me.tscope = New MetroFramework.Controls.MetroComboBox()
        Me.LabelDate = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.tfarmer = New MetroFramework.Controls.MetroTextBox()
        Me.tlocation = New MetroFramework.Controls.MetroTextBox()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.tlotqtt = New MetroFramework.Controls.MetroTextBox()
        Me.tvariety = New MetroFramework.Controls.MetroTextBox()
        Me.tnoman = New MetroFramework.Controls.MetroTextBox()
        Me.tlotref = New MetroFramework.Controls.MetroTextBox()
        Me.LinkAll = New MetroFramework.Controls.MetroLink()
        Me.Link2MonthAgo = New MetroFramework.Controls.MetroLink()
        Me.LinkThisMonth = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.QcconfirmviewerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.LinkLoad = New MetroFramework.Controls.MetroLink()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Spl_request1TableAdapter = New WindowsApplication1.HCQC_NewDatasetTableAdapters.Spl_request1TableAdapter()
        Me.Qc_confirm_viewerTableAdapter = New WindowsApplication1.HCQC_NewDatasetTableAdapters.qc_confirm_viewerTableAdapter()
        Me.IdColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdhvsprodColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabnumColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScopeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarietyColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FarmerColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HarvestColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomnlColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NojobColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loc_sampleColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status_confirm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.req_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.req_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColmEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColmDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Splrequest1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel2.SuspendLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QcconfirmviewerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'tid_hvsprod
        '
        Me.tid_hvsprod.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        '
        '
        '
        Me.tid_hvsprod.CustomButton.Image = Nothing
        Me.tid_hvsprod.CustomButton.Location = New System.Drawing.Point(154, 1)
        Me.tid_hvsprod.CustomButton.Name = ""
        Me.tid_hvsprod.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tid_hvsprod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tid_hvsprod.CustomButton.TabIndex = 1
        Me.tid_hvsprod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tid_hvsprod.CustomButton.UseSelectable = True
        Me.tid_hvsprod.CustomButton.Visible = False
        Me.tid_hvsprod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tid_hvsprod.Lines = New String(-1) {}
        Me.tid_hvsprod.Location = New System.Drawing.Point(152, 38)
        Me.tid_hvsprod.MaxLength = 32767
        Me.tid_hvsprod.Name = "tid_hvsprod"
        Me.tid_hvsprod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tid_hvsprod.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tid_hvsprod.SelectedText = ""
        Me.tid_hvsprod.SelectionLength = 0
        Me.tid_hvsprod.SelectionStart = 0
        Me.tid_hvsprod.ShortcutsEnabled = True
        Me.tid_hvsprod.Size = New System.Drawing.Size(176, 23)
        Me.tid_hvsprod.TabIndex = 61
        Me.MetroToolTip1.SetToolTip(Me.tid_hvsprod, "  Press to get Variety; Farmer; Location; Harvest  ")
        Me.tid_hvsprod.UseCustomBackColor = True
        Me.tid_hvsprod.UseCustomForeColor = True
        Me.tid_hvsprod.UseSelectable = True
        Me.tid_hvsprod.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tid_hvsprod.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tgl_hvs
        '
        Me.tgl_hvs.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.tgl_hvs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tgl_hvs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tgl_hvs.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_hvs.ForeColor = System.Drawing.Color.Transparent
        Me.tgl_hvs.Location = New System.Drawing.Point(1, 1)
        Me.tgl_hvs.Mask = "00/00/0000"
        Me.tgl_hvs.Name = "tgl_hvs"
        Me.tgl_hvs.Size = New System.Drawing.Size(106, 18)
        Me.tgl_hvs.TabIndex = 0
        Me.tgl_hvs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tgl_hvs.ValidatingType = GetType(Date)
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroStyleExtender1.SetApplyMetroTheme(Me.GridControl1, True)
        Me.GridControl1.DataSource = Me.Splrequest1BindingSource
        Me.GridControl1.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.GridControl1.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.GridControl1.Location = New System.Drawing.Point(3, 29)
        Me.GridControl1.LookAndFeel.SkinName = "The Bezier"
        Me.GridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(812, 446)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'Splrequest1BindingSource
        '
        Me.Splrequest1BindingSource.DataMember = "Spl_request1"
        Me.Splrequest1BindingSource.DataSource = Me.HCQC_NewDataset
        '
        'HCQC_NewDataset
        '
        Me.HCQC_NewDataset.DataSetName = "HCQC_NewDataset"
        Me.HCQC_NewDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colid_hvsprod, Me.collabnum, Me.colcrop, Me.colvariety, Me.colfarmer, Me.collocation, Me.colharvest, Me.colweight, Me.colbag, Me.colnomnl, Me.colnojob, Me.colloc_sample, Me.colscope, Me.colnama_req, Me.coltest_sampling, Me.coltest_moi, Me.coltest_pur, Me.coltest_ger, Me.coltest_via, Me.coltest_raf, Me.colinput_date, Me.colstatus_confirm, Me.colinformation_rejected, Me.coltgl_confirm})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.GridView1.OptionsHint.ShowCellHints = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.PaintStyleName = "Skin"
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colinput_date, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colid
        '
        Me.colid.Caption = "Req Number"
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        Me.colid.Visible = True
        Me.colid.VisibleIndex = 0
        Me.colid.Width = 110
        '
        'colid_hvsprod
        '
        Me.colid_hvsprod.Caption = "Production Code"
        Me.colid_hvsprod.FieldName = "id_hvsprod"
        Me.colid_hvsprod.Name = "colid_hvsprod"
        Me.colid_hvsprod.Visible = True
        Me.colid_hvsprod.VisibleIndex = 1
        Me.colid_hvsprod.Width = 106
        '
        'collabnum
        '
        Me.collabnum.Caption = "Lab Number"
        Me.collabnum.FieldName = "labnum"
        Me.collabnum.Name = "collabnum"
        Me.collabnum.Visible = True
        Me.collabnum.VisibleIndex = 2
        Me.collabnum.Width = 89
        '
        'colcrop
        '
        Me.colcrop.Caption = "Crop"
        Me.colcrop.FieldName = "crop"
        Me.colcrop.Name = "colcrop"
        Me.colcrop.Visible = True
        Me.colcrop.VisibleIndex = 3
        Me.colcrop.Width = 109
        '
        'colvariety
        '
        Me.colvariety.Caption = "Variety"
        Me.colvariety.FieldName = "variety"
        Me.colvariety.Name = "colvariety"
        Me.colvariety.Visible = True
        Me.colvariety.VisibleIndex = 4
        Me.colvariety.Width = 76
        '
        'colfarmer
        '
        Me.colfarmer.Caption = "Farmer"
        Me.colfarmer.FieldName = "farmer"
        Me.colfarmer.Name = "colfarmer"
        Me.colfarmer.Visible = True
        Me.colfarmer.VisibleIndex = 5
        Me.colfarmer.Width = 110
        '
        'collocation
        '
        Me.collocation.Caption = "Loaction"
        Me.collocation.FieldName = "location"
        Me.collocation.Name = "collocation"
        Me.collocation.Visible = True
        Me.collocation.VisibleIndex = 6
        Me.collocation.Width = 117
        '
        'colharvest
        '
        Me.colharvest.Caption = "Harvest"
        Me.colharvest.FieldName = "harvest"
        Me.colharvest.Name = "colharvest"
        Me.colharvest.Visible = True
        Me.colharvest.VisibleIndex = 7
        Me.colharvest.Width = 88
        '
        'colweight
        '
        Me.colweight.Caption = "Weight (kg)"
        Me.colweight.FieldName = "weight"
        Me.colweight.Name = "colweight"
        Me.colweight.Visible = True
        Me.colweight.VisibleIndex = 8
        '
        'colbag
        '
        Me.colbag.Caption = "Bags"
        Me.colbag.FieldName = "bag"
        Me.colbag.Name = "colbag"
        Me.colbag.Visible = True
        Me.colbag.VisibleIndex = 15
        '
        'colnomnl
        '
        Me.colnomnl.Caption = "Manual"
        Me.colnomnl.FieldName = "nomnl"
        Me.colnomnl.Name = "colnomnl"
        Me.colnomnl.Visible = True
        Me.colnomnl.VisibleIndex = 9
        Me.colnomnl.Width = 56
        '
        'colnojob
        '
        Me.colnojob.Caption = "Lot/Job"
        Me.colnojob.FieldName = "nojob"
        Me.colnojob.Name = "colnojob"
        Me.colnojob.Visible = True
        Me.colnojob.VisibleIndex = 10
        Me.colnojob.Width = 61
        '
        'colloc_sample
        '
        Me.colloc_sample.CustomizationCaption = "Location Sample"
        Me.colloc_sample.FieldName = "loc_sample"
        Me.colloc_sample.Name = "colloc_sample"
        Me.colloc_sample.Visible = True
        Me.colloc_sample.VisibleIndex = 11
        '
        'colscope
        '
        Me.colscope.Caption = "Scope"
        Me.colscope.FieldName = "scope"
        Me.colscope.Name = "colscope"
        Me.colscope.Visible = True
        Me.colscope.VisibleIndex = 12
        '
        'colnama_req
        '
        Me.colnama_req.Caption = "Request by"
        Me.colnama_req.FieldName = "nama_req"
        Me.colnama_req.Name = "colnama_req"
        Me.colnama_req.Visible = True
        Me.colnama_req.VisibleIndex = 13
        Me.colnama_req.Width = 93
        '
        'coltest_sampling
        '
        Me.coltest_sampling.Caption = "Sampling Test"
        Me.coltest_sampling.FieldName = "test_sampling"
        Me.coltest_sampling.Name = "coltest_sampling"
        Me.coltest_sampling.Width = 94
        '
        'coltest_moi
        '
        Me.coltest_moi.Caption = "Moi Test"
        Me.coltest_moi.FieldName = "test_moi"
        Me.coltest_moi.Name = "coltest_moi"
        Me.coltest_moi.Width = 71
        '
        'coltest_pur
        '
        Me.coltest_pur.Caption = "Pur Test"
        Me.coltest_pur.FieldName = "test_pur"
        Me.coltest_pur.Name = "coltest_pur"
        Me.coltest_pur.Width = 62
        '
        'coltest_ger
        '
        Me.coltest_ger.Caption = "Ger Test"
        Me.coltest_ger.FieldName = "test_ger"
        Me.coltest_ger.Name = "coltest_ger"
        Me.coltest_ger.Width = 63
        '
        'coltest_via
        '
        Me.coltest_via.Caption = "Via Test"
        Me.coltest_via.FieldName = "test_via"
        Me.coltest_via.Name = "coltest_via"
        Me.coltest_via.Width = 61
        '
        'coltest_raf
        '
        Me.coltest_raf.Caption = "Raf Test"
        Me.coltest_raf.FieldName = "test_raf"
        Me.coltest_raf.Name = "coltest_raf"
        Me.coltest_raf.Width = 59
        '
        'colinput_date
        '
        Me.colinput_date.Caption = "Request Date"
        Me.colinput_date.FieldName = "input_date"
        Me.colinput_date.Name = "colinput_date"
        Me.colinput_date.Visible = True
        Me.colinput_date.VisibleIndex = 14
        Me.colinput_date.Width = 107
        '
        'colstatus_confirm
        '
        Me.colstatus_confirm.Caption = "Status Confirm"
        Me.colstatus_confirm.FieldName = "status_confirm"
        Me.colstatus_confirm.Name = "colstatus_confirm"
        Me.colstatus_confirm.Visible = True
        Me.colstatus_confirm.VisibleIndex = 16
        Me.colstatus_confirm.Width = 108
        '
        'colinformation_rejected
        '
        Me.colinformation_rejected.Caption = "Reject Info"
        Me.colinformation_rejected.FieldName = "information_rejected"
        Me.colinformation_rejected.Name = "colinformation_rejected"
        Me.colinformation_rejected.Visible = True
        Me.colinformation_rejected.VisibleIndex = 17
        '
        'coltgl_confirm
        '
        Me.coltgl_confirm.Caption = "Confirm QC Date"
        Me.coltgl_confirm.FieldName = "tgl_confirm"
        Me.coltgl_confirm.Name = "coltgl_confirm"
        Me.coltgl_confirm.Visible = True
        Me.coltgl_confirm.VisibleIndex = 18
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        Me.MetroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.AutoScroll = True
        Me.MetroTabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.MetroTabPage1.Controls.Add(Me.Tsearch)
        Me.MetroTabPage1.Controls.Add(Me.MetroPanel1)
        Me.MetroTabPage1.Controls.Add(Me.LinkAll)
        Me.MetroTabPage1.Controls.Add(Me.Link2MonthAgo)
        Me.MetroTabPage1.Controls.Add(Me.LinkThisMonth)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage1.Controls.Add(Me.MetroGrid1)
        Me.MetroTabPage1.HorizontalScrollbar = True
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(818, 478)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Request Form   "
        Me.MetroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabPage1.UseCustomBackColor = True
        Me.MetroTabPage1.VerticalScrollbar = True
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'Tsearch
        '
        '
        '
        '
        Me.Tsearch.CustomButton.Image = Global.WindowsApplication1.My.Resources.Resources.Find
        Me.Tsearch.CustomButton.Location = New System.Drawing.Point(194, 1)
        Me.Tsearch.CustomButton.Name = ""
        Me.Tsearch.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.Tsearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Tsearch.CustomButton.TabIndex = 1
        Me.Tsearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Tsearch.CustomButton.UseSelectable = True
        Me.Tsearch.Lines = New String(-1) {}
        Me.Tsearch.Location = New System.Drawing.Point(271, 278)
        Me.Tsearch.MaxLength = 32767
        Me.Tsearch.Name = "Tsearch"
        Me.Tsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Tsearch.PromptText = "Find..."
        Me.Tsearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Tsearch.SelectedText = ""
        Me.Tsearch.SelectionLength = 0
        Me.Tsearch.SelectionStart = 0
        Me.Tsearch.ShortcutsEnabled = True
        Me.Tsearch.ShowButton = True
        Me.Tsearch.Size = New System.Drawing.Size(216, 23)
        Me.Tsearch.Style = MetroFramework.MetroColorStyle.Blue
        Me.Tsearch.TabIndex = 59
        Me.Tsearch.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Tsearch.UseSelectable = True
        Me.Tsearch.WaterMark = "Find..."
        Me.Tsearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Tsearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroPanel1.AutoScroll = True
        Me.MetroPanel1.Controls.Add(Me.tloc_sample)
        Me.MetroPanel1.Controls.Add(Me.LinkFind)
        Me.MetroPanel1.Controls.Add(Me.BtnSave)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel6)
        Me.MetroPanel1.Controls.Add(Me.tcrop)
        Me.MetroPanel1.Controls.Add(Me.BunifuFlatButton1)
        Me.MetroPanel1.Controls.Add(Me.LinkSelectallRequest)
        Me.MetroPanel1.Controls.Add(Me.tbag)
        Me.MetroPanel1.Controls.Add(Me.BunifuImageButton2)
        Me.MetroPanel1.Controls.Add(Me.LinkClearRequest)
        Me.MetroPanel1.Controls.Add(Me.tremark)
        Me.MetroPanel1.Controls.Add(Me.traf)
        Me.MetroPanel1.Controls.Add(Me.tvia)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel10)
        Me.MetroPanel1.Controls.Add(Me.tger)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel11)
        Me.MetroPanel1.Controls.Add(Me.tpur)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.Controls.Add(Me.tmoi)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel13)
        Me.MetroPanel1.Controls.Add(Me.tsampling)
        Me.MetroPanel1.Controls.Add(Me.tscope)
        Me.MetroPanel1.Controls.Add(Me.LabelDate)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel15)
        Me.MetroPanel1.Controls.Add(Me.BunifuSeparator3)
        Me.MetroPanel1.Controls.Add(Me.BunifuSeparator2)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel17)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel7)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel18)
        Me.MetroPanel1.Controls.Add(Me.tfarmer)
        Me.MetroPanel1.Controls.Add(Me.tlocation)
        Me.MetroPanel1.Controls.Add(Me.MetroPanel2)
        Me.MetroPanel1.Controls.Add(Me.tlotqtt)
        Me.MetroPanel1.Controls.Add(Me.tid_hvsprod)
        Me.MetroPanel1.Controls.Add(Me.tvariety)
        Me.MetroPanel1.Controls.Add(Me.tnoman)
        Me.MetroPanel1.Controls.Add(Me.tlotref)
        Me.MetroPanel1.HorizontalScrollbar = True
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(3, 16)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(814, 229)
        Me.MetroPanel1.TabIndex = 56
        Me.MetroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroPanel1.VerticalScrollbar = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'tloc_sample
        '
        Me.tloc_sample.BackColor = System.Drawing.Color.Transparent
        Me.tloc_sample.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.tloc_sample.ForeColor = System.Drawing.Color.Transparent
        Me.tloc_sample.FormattingEnabled = True
        Me.tloc_sample.ItemHeight = 19
        Me.tloc_sample.Items.AddRange(New Object() {"Gudang A", "Gudang B", "Gudang C", "Gudang E", "Gudang G", "Gudang WP", "CR C", "CR E", "CR F", "CR G"})
        Me.tloc_sample.Location = New System.Drawing.Point(216, 239)
        Me.tloc_sample.Name = "tloc_sample"
        Me.tloc_sample.PromptText = "Sample Location..."
        Me.tloc_sample.Size = New System.Drawing.Size(120, 25)
        Me.tloc_sample.Style = MetroFramework.MetroColorStyle.Blue
        Me.tloc_sample.TabIndex = 94
        Me.tloc_sample.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tloc_sample.UseSelectable = True
        Me.tloc_sample.UseStyleColors = True
        '
        'LinkFind
        '
        Me.LinkFind.AutoSize = True
        Me.LinkFind.BackColor = System.Drawing.Color.Transparent
        Me.LinkFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkFind.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkFind.Location = New System.Drawing.Point(334, 38)
        Me.LinkFind.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkFind.Name = "LinkFind"
        Me.LinkFind.Size = New System.Drawing.Size(41, 23)
        Me.LinkFind.TabIndex = 93
        Me.LinkFind.TabStop = False
        Me.LinkFind.Text = "Find"
        Me.LinkFind.UseCustomBackColor = True
        Me.LinkFind.UseSelectable = True
        Me.LinkFind.UseStyleColors = True
        '
        'BtnSave
        '
        Me.BtnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Appearance.Options.UseBackColor = True
        Me.BtnSave.Appearance.Options.UseFont = True
        Me.BtnSave.AppearanceDisabled.BackColor = System.Drawing.Color.Silver
        Me.BtnSave.AppearanceDisabled.Options.UseBackColor = True
        Me.BtnSave.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSave.AppearanceHovered.Options.UseBackColor = True
        Me.BtnSave.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSave.AppearancePressed.Options.UseBackColor = True
        Me.BtnSave.Location = New System.Drawing.Point(537, 254)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[True]
        Me.BtnSave.Size = New System.Drawing.Size(176, 34)
        Me.BtnSave.TabIndex = 90
        Me.BtnSave.Text = "Save"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MetroLabel6.Location = New System.Drawing.Point(107, 100)
        Me.MetroLabel6.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel6.TabIndex = 92
        Me.MetroLabel6.Text = "Crop"
        Me.MetroLabel6.UseCustomBackColor = True
        Me.MetroLabel6.UseCustomForeColor = True
        '
        'tcrop
        '
        Me.tcrop.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        '
        '
        '
        Me.tcrop.CustomButton.Image = Nothing
        Me.tcrop.CustomButton.Location = New System.Drawing.Point(154, 1)
        Me.tcrop.CustomButton.Name = ""
        Me.tcrop.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tcrop.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tcrop.CustomButton.TabIndex = 1
        Me.tcrop.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tcrop.CustomButton.UseSelectable = True
        Me.tcrop.CustomButton.Visible = False
        Me.tcrop.Enabled = False
        Me.tcrop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tcrop.Lines = New String(-1) {}
        Me.tcrop.Location = New System.Drawing.Point(152, 96)
        Me.tcrop.MaxLength = 32767
        Me.tcrop.Name = "tcrop"
        Me.tcrop.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tcrop.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tcrop.SelectedText = ""
        Me.tcrop.SelectionLength = 0
        Me.tcrop.SelectionStart = 0
        Me.tcrop.ShortcutsEnabled = True
        Me.tcrop.Size = New System.Drawing.Size(176, 23)
        Me.tcrop.TabIndex = 62
        Me.tcrop.UseCustomBackColor = True
        Me.tcrop.UseCustomForeColor = True
        Me.tcrop.UseSelectable = True
        Me.tcrop.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tcrop.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Add Multiple"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = False
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = False
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(226, 0)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(91, 20)
        Me.BunifuFlatButton1.TabIndex = 90
        Me.BunifuFlatButton1.TabStop = False
        Me.BunifuFlatButton1.Text = "Add Multiple"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LinkSelectallRequest
        '
        Me.LinkSelectallRequest.AutoSize = True
        Me.LinkSelectallRequest.BackColor = System.Drawing.Color.Transparent
        Me.LinkSelectallRequest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkSelectallRequest.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkSelectallRequest.Location = New System.Drawing.Point(691, 0)
        Me.LinkSelectallRequest.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkSelectallRequest.Name = "LinkSelectallRequest"
        Me.LinkSelectallRequest.Size = New System.Drawing.Size(60, 23)
        Me.LinkSelectallRequest.TabIndex = 89
        Me.LinkSelectallRequest.TabStop = False
        Me.LinkSelectallRequest.Text = "Select all"
        Me.LinkSelectallRequest.UseCustomBackColor = True
        Me.LinkSelectallRequest.UseSelectable = True
        Me.LinkSelectallRequest.UseStyleColors = True
        '
        'tbag
        '
        '
        '
        '
        Me.tbag.CustomButton.Image = Nothing
        Me.tbag.CustomButton.Location = New System.Drawing.Point(36, 1)
        Me.tbag.CustomButton.Name = ""
        Me.tbag.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbag.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbag.CustomButton.TabIndex = 1
        Me.tbag.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbag.CustomButton.UseSelectable = True
        Me.tbag.CustomButton.Visible = False
        Me.tbag.Lines = New String(-1) {}
        Me.tbag.Location = New System.Drawing.Point(152, 268)
        Me.tbag.MaxLength = 32767
        Me.tbag.Name = "tbag"
        Me.tbag.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbag.PromptText = "zack"
        Me.tbag.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbag.SelectedText = ""
        Me.tbag.SelectionLength = 0
        Me.tbag.SelectionStart = 0
        Me.tbag.ShortcutsEnabled = True
        Me.tbag.Size = New System.Drawing.Size(58, 23)
        Me.tbag.TabIndex = 74
        Me.tbag.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tbag.UseSelectable = True
        Me.tbag.WaterMark = "zack"
        Me.tbag.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbag.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Black
        Me.BunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(307, 67)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(21, 23)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 57
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 20
        '
        'LinkClearRequest
        '
        Me.LinkClearRequest.AutoSize = True
        Me.LinkClearRequest.BackColor = System.Drawing.Color.Transparent
        Me.LinkClearRequest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkClearRequest.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkClearRequest.Location = New System.Drawing.Point(320, 0)
        Me.LinkClearRequest.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkClearRequest.Name = "LinkClearRequest"
        Me.LinkClearRequest.Size = New System.Drawing.Size(41, 23)
        Me.LinkClearRequest.TabIndex = 87
        Me.LinkClearRequest.TabStop = False
        Me.LinkClearRequest.Text = "Clear"
        Me.LinkClearRequest.UseCustomBackColor = True
        Me.LinkClearRequest.UseSelectable = True
        Me.LinkClearRequest.UseStyleColors = True
        '
        'tremark
        '
        Me.tremark.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        '
        '
        '
        Me.tremark.CustomButton.Image = Nothing
        Me.tremark.CustomButton.Location = New System.Drawing.Point(126, 2)
        Me.tremark.CustomButton.Name = ""
        Me.tremark.CustomButton.Size = New System.Drawing.Size(47, 47)
        Me.tremark.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tremark.CustomButton.TabIndex = 1
        Me.tremark.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tremark.CustomButton.UseSelectable = True
        Me.tremark.CustomButton.Visible = False
        Me.tremark.ForeColor = System.Drawing.Color.Transparent
        Me.tremark.Lines = New String(-1) {}
        Me.tremark.Location = New System.Drawing.Point(537, 194)
        Me.tremark.MaxLength = 32767
        Me.tremark.Multiline = True
        Me.tremark.Name = "tremark"
        Me.tremark.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tremark.PromptText = "remark"
        Me.tremark.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tremark.SelectedText = ""
        Me.tremark.SelectionLength = 0
        Me.tremark.SelectionStart = 0
        Me.tremark.ShortcutsEnabled = True
        Me.tremark.Size = New System.Drawing.Size(176, 52)
        Me.tremark.TabIndex = 82
        Me.tremark.UseCustomBackColor = True
        Me.tremark.UseCustomForeColor = True
        Me.tremark.UseSelectable = True
        Me.tremark.WaterMark = "remark"
        Me.tremark.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tremark.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'traf
        '
        Me.traf.AutoSize = True
        Me.traf.BackColor = System.Drawing.Color.Transparent
        Me.traf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.traf.Location = New System.Drawing.Point(537, 131)
        Me.traf.Name = "traf"
        Me.traf.Size = New System.Drawing.Size(96, 15)
        Me.traf.TabIndex = 79
        Me.traf.Text = "Rafaction Test"
        Me.traf.UseCustomBackColor = True
        Me.traf.UseCustomForeColor = True
        Me.traf.UseSelectable = True
        '
        'tvia
        '
        Me.tvia.AutoSize = True
        Me.tvia.BackColor = System.Drawing.Color.Transparent
        Me.tvia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.tvia.Location = New System.Drawing.Point(537, 173)
        Me.tvia.Name = "tvia"
        Me.tvia.Size = New System.Drawing.Size(88, 15)
        Me.tvia.TabIndex = 81
        Me.tvia.Text = "Viability Test"
        Me.tvia.UseCustomBackColor = True
        Me.tvia.UseCustomForeColor = True
        Me.tvia.UseSelectable = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MetroLabel10.Location = New System.Drawing.Point(94, 129)
        Me.MetroLabel10.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel10.TabIndex = 64
        Me.MetroLabel10.Text = "Farmer"
        Me.MetroLabel10.UseCustomBackColor = True
        Me.MetroLabel10.UseCustomForeColor = True
        '
        'tger
        '
        Me.tger.AutoSize = True
        Me.tger.BackColor = System.Drawing.Color.Transparent
        Me.tger.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.tger.Location = New System.Drawing.Point(537, 152)
        Me.tger.Name = "tger"
        Me.tger.Size = New System.Drawing.Size(112, 15)
        Me.tger.TabIndex = 80
        Me.tger.Text = "Germination Test"
        Me.tger.UseCustomBackColor = True
        Me.tger.UseCustomForeColor = True
        Me.tger.UseSelectable = True
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MetroLabel11.Location = New System.Drawing.Point(85, 158)
        Me.MetroLabel11.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel11.TabIndex = 66
        Me.MetroLabel11.Text = "Location"
        Me.MetroLabel11.UseCustomBackColor = True
        Me.MetroLabel11.UseCustomForeColor = True
        '
        'tpur
        '
        Me.tpur.AutoSize = True
        Me.tpur.BackColor = System.Drawing.Color.Transparent
        Me.tpur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.tpur.Location = New System.Drawing.Point(537, 110)
        Me.tpur.Name = "tpur"
        Me.tpur.Size = New System.Drawing.Size(77, 15)
        Me.tpur.TabIndex = 78
        Me.tpur.Text = "Purity Test"
        Me.tpur.UseCustomBackColor = True
        Me.tpur.UseCustomForeColor = True
        Me.tpur.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MetroLabel3.Location = New System.Drawing.Point(407, 4)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(113, 19)
        Me.MetroLabel3.TabIndex = 57
        Me.MetroLabel3.Text = "Testing Request"
        Me.MetroLabel3.UseCustomBackColor = True
        Me.MetroLabel3.UseCustomForeColor = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MetroLabel1.Location = New System.Drawing.Point(22, 4)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(142, 19)
        Me.MetroLabel1.TabIndex = 58
        Me.MetroLabel1.Text = "Sample Information"
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'tmoi
        '
        Me.tmoi.AutoSize = True
        Me.tmoi.BackColor = System.Drawing.Color.Transparent
        Me.tmoi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.tmoi.Location = New System.Drawing.Point(537, 89)
        Me.tmoi.Name = "tmoi"
        Me.tmoi.Size = New System.Drawing.Size(93, 15)
        Me.tmoi.TabIndex = 77
        Me.tmoi.Text = "Moisture Test"
        Me.tmoi.UseCustomBackColor = True
        Me.tmoi.UseCustomForeColor = True
        Me.tmoi.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MetroLabel5.Location = New System.Drawing.Point(34, 42)
        Me.MetroLabel5.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(112, 19)
        Me.MetroLabel5.TabIndex = 62
        Me.MetroLabel5.Text = "Production Code"
        Me.MetroLabel5.UseCustomBackColor = True
        Me.MetroLabel5.UseCustomForeColor = True
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MetroLabel13.Location = New System.Drawing.Point(95, 71)
        Me.MetroLabel13.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel13.TabIndex = 62
        Me.MetroLabel13.Text = "Variety"
        Me.MetroLabel13.UseCustomBackColor = True
        Me.MetroLabel13.UseCustomForeColor = True
        '
        'tsampling
        '
        Me.tsampling.AutoSize = True
        Me.tsampling.BackColor = System.Drawing.Color.Transparent
        Me.tsampling.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.tsampling.Location = New System.Drawing.Point(537, 68)
        Me.tsampling.Name = "tsampling"
        Me.tsampling.Size = New System.Drawing.Size(73, 15)
        Me.tsampling.TabIndex = 76
        Me.tsampling.Text = "Sampling"
        Me.tsampling.UseCustomBackColor = True
        Me.tsampling.UseCustomForeColor = True
        Me.tsampling.UseSelectable = True
        '
        'tscope
        '
        Me.tscope.BackColor = System.Drawing.Color.Transparent
        Me.tscope.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.tscope.ForeColor = System.Drawing.Color.Transparent
        Me.tscope.FormattingEnabled = True
        Me.tscope.ItemHeight = 19
        Me.tscope.Items.AddRange(New Object() {"Raw Material", "Gravity", "Periodic", "Finish Good", "Other"})
        Me.tscope.Location = New System.Drawing.Point(537, 37)
        Me.tscope.Name = "tscope"
        Me.tscope.PromptText = "Lot Scope..."
        Me.tscope.Size = New System.Drawing.Size(176, 25)
        Me.tscope.Style = MetroFramework.MetroColorStyle.Blue
        Me.tscope.TabIndex = 75
        Me.tscope.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tscope.UseSelectable = True
        Me.tscope.UseStyleColors = True
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.BackColor = System.Drawing.Color.Transparent
        Me.LabelDate.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelDate.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.LabelDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LabelDate.Location = New System.Drawing.Point(268, 186)
        Me.LabelDate.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(71, 15)
        Me.LabelDate.TabIndex = 67
        Me.LabelDate.Text = "*dateformat"
        Me.LabelDate.UseCustomBackColor = True
        Me.LabelDate.UseCustomForeColor = True
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MetroLabel15.Location = New System.Drawing.Point(57, 185)
        Me.MetroLabel15.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel15.TabIndex = 67
        Me.MetroLabel15.Text = "Harvest Date"
        Me.MetroLabel15.UseCustomBackColor = True
        Me.MetroLabel15.UseCustomForeColor = True
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 1
        Me.BunifuSeparator3.Location = New System.Drawing.Point(407, 23)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(338, 5)
        Me.BunifuSeparator3.TabIndex = 77
        Me.BunifuSeparator3.TabStop = False
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(22, 23)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(338, 5)
        Me.BunifuSeparator2.TabIndex = 78
        Me.BunifuSeparator2.TabStop = False
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MetroLabel17.Location = New System.Drawing.Point(37, 214)
        Me.MetroLabel17.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(109, 19)
        Me.MetroLabel17.TabIndex = 72
        Me.MetroLabel17.Text = "Lot/Job Number"
        Me.MetroLabel17.UseCustomBackColor = True
        Me.MetroLabel17.UseCustomForeColor = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MetroLabel4.Location = New System.Drawing.Point(423, 43)
        Me.MetroLabel4.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(108, 19)
        Me.MetroLabel4.TabIndex = 73
        Me.MetroLabel4.Text = "Process Posision"
        Me.MetroLabel4.UseCustomBackColor = True
        Me.MetroLabel4.UseCustomForeColor = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MetroLabel7.Location = New System.Drawing.Point(41, 269)
        Me.MetroLabel7.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(108, 19)
        Me.MetroLabel7.TabIndex = 73
        Me.MetroLabel7.Text = "Number of bags"
        Me.MetroLabel7.UseCustomBackColor = True
        Me.MetroLabel7.UseCustomForeColor = True
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MetroLabel18.Location = New System.Drawing.Point(67, 243)
        Me.MetroLabel18.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel18.TabIndex = 73
        Me.MetroLabel18.Text = "Weight (kg)"
        Me.MetroLabel18.UseCustomBackColor = True
        Me.MetroLabel18.UseCustomForeColor = True
        '
        'tfarmer
        '
        Me.tfarmer.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        '
        '
        '
        Me.tfarmer.CustomButton.Image = Nothing
        Me.tfarmer.CustomButton.Location = New System.Drawing.Point(154, 1)
        Me.tfarmer.CustomButton.Name = ""
        Me.tfarmer.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tfarmer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tfarmer.CustomButton.TabIndex = 1
        Me.tfarmer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tfarmer.CustomButton.UseSelectable = True
        Me.tfarmer.CustomButton.Visible = False
        Me.tfarmer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tfarmer.Lines = New String(-1) {}
        Me.tfarmer.Location = New System.Drawing.Point(152, 125)
        Me.tfarmer.MaxLength = 32767
        Me.tfarmer.Name = "tfarmer"
        Me.tfarmer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tfarmer.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tfarmer.SelectedText = ""
        Me.tfarmer.SelectionLength = 0
        Me.tfarmer.SelectionStart = 0
        Me.tfarmer.ShortcutsEnabled = True
        Me.tfarmer.Size = New System.Drawing.Size(176, 23)
        Me.tfarmer.TabIndex = 63
        Me.tfarmer.UseCustomBackColor = True
        Me.tfarmer.UseCustomForeColor = True
        Me.tfarmer.UseSelectable = True
        Me.tfarmer.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tfarmer.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tlocation
        '
        Me.tlocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        '
        '
        '
        Me.tlocation.CustomButton.Image = Nothing
        Me.tlocation.CustomButton.Location = New System.Drawing.Point(154, 1)
        Me.tlocation.CustomButton.Name = ""
        Me.tlocation.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tlocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tlocation.CustomButton.TabIndex = 1
        Me.tlocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tlocation.CustomButton.UseSelectable = True
        Me.tlocation.CustomButton.Visible = False
        Me.tlocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlocation.Lines = New String(-1) {}
        Me.tlocation.Location = New System.Drawing.Point(152, 154)
        Me.tlocation.MaxLength = 32767
        Me.tlocation.Name = "tlocation"
        Me.tlocation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tlocation.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tlocation.SelectedText = ""
        Me.tlocation.SelectionLength = 0
        Me.tlocation.SelectionStart = 0
        Me.tlocation.ShortcutsEnabled = True
        Me.tlocation.Size = New System.Drawing.Size(176, 23)
        Me.tlocation.TabIndex = 64
        Me.tlocation.UseCustomBackColor = True
        Me.tlocation.UseCustomForeColor = True
        Me.tlocation.UseSelectable = True
        Me.tlocation.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tlocation.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.MetroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel2.Controls.Add(Me.tgl_hvs)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(152, 181)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.MetroPanel2.Size = New System.Drawing.Size(110, 23)
        Me.MetroPanel2.TabIndex = 68
        Me.MetroPanel2.UseCustomBackColor = True
        Me.MetroPanel2.UseCustomForeColor = True
        Me.MetroPanel2.UseStyleColors = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'tlotqtt
        '
        Me.tlotqtt.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        '
        '
        '
        Me.tlotqtt.CustomButton.Image = Nothing
        Me.tlotqtt.CustomButton.Location = New System.Drawing.Point(36, 1)
        Me.tlotqtt.CustomButton.Name = ""
        Me.tlotqtt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tlotqtt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tlotqtt.CustomButton.TabIndex = 1
        Me.tlotqtt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tlotqtt.CustomButton.UseSelectable = True
        Me.tlotqtt.CustomButton.Visible = False
        Me.tlotqtt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlotqtt.Lines = New String(-1) {}
        Me.tlotqtt.Location = New System.Drawing.Point(152, 239)
        Me.tlotqtt.MaxLength = 32767
        Me.tlotqtt.Name = "tlotqtt"
        Me.tlotqtt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tlotqtt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tlotqtt.SelectedText = ""
        Me.tlotqtt.SelectionLength = 0
        Me.tlotqtt.SelectionStart = 0
        Me.tlotqtt.ShortcutsEnabled = True
        Me.tlotqtt.Size = New System.Drawing.Size(58, 23)
        Me.tlotqtt.TabIndex = 73
        Me.tlotqtt.UseCustomBackColor = True
        Me.tlotqtt.UseCustomForeColor = True
        Me.tlotqtt.UseSelectable = True
        Me.tlotqtt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tlotqtt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tvariety
        '
        Me.tvariety.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        '
        '
        '
        Me.tvariety.CustomButton.Image = Global.WindowsApplication1.My.Resources.Resources.appbar_refresh
        Me.tvariety.CustomButton.Location = New System.Drawing.Point(127, 1)
        Me.tvariety.CustomButton.Name = ""
        Me.tvariety.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tvariety.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tvariety.CustomButton.TabIndex = 1
        Me.tvariety.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tvariety.CustomButton.UseSelectable = True
        Me.tvariety.CustomButton.UseStyleColors = True
        Me.tvariety.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tvariety.Lines = New String(-1) {}
        Me.tvariety.Location = New System.Drawing.Point(152, 67)
        Me.tvariety.MaxLength = 32767
        Me.tvariety.Name = "tvariety"
        Me.tvariety.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tvariety.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tvariety.SelectedText = ""
        Me.tvariety.SelectionLength = 0
        Me.tvariety.SelectionStart = 0
        Me.tvariety.ShortcutsEnabled = True
        Me.tvariety.ShowButton = True
        Me.tvariety.Size = New System.Drawing.Size(149, 23)
        Me.tvariety.TabIndex = 61
        Me.tvariety.UseCustomBackColor = True
        Me.tvariety.UseCustomForeColor = True
        Me.tvariety.UseSelectable = True
        Me.tvariety.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tvariety.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tnoman
        '
        Me.tnoman.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        '
        '
        '
        Me.tnoman.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.tnoman.CustomButton.Location = New System.Drawing.Point(36, 1)
        Me.tnoman.CustomButton.Name = ""
        Me.tnoman.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tnoman.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tnoman.CustomButton.TabIndex = 1
        Me.tnoman.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tnoman.CustomButton.UseSelectable = True
        Me.tnoman.CustomButton.Visible = False
        Me.tnoman.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tnoman.Lines = New String(-1) {}
        Me.tnoman.Location = New System.Drawing.Point(152, 210)
        Me.tnoman.MaxLength = 32767
        Me.tnoman.Name = "tnoman"
        Me.tnoman.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tnoman.PromptText = "Manual"
        Me.tnoman.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tnoman.SelectedText = ""
        Me.tnoman.SelectionLength = 0
        Me.tnoman.SelectionStart = 0
        Me.tnoman.ShortcutsEnabled = True
        Me.tnoman.Size = New System.Drawing.Size(58, 23)
        Me.tnoman.TabIndex = 71
        Me.tnoman.UseCustomBackColor = True
        Me.tnoman.UseCustomForeColor = True
        Me.tnoman.UseSelectable = True
        Me.tnoman.WaterMark = "Manual"
        Me.tnoman.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tnoman.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tlotref
        '
        Me.tlotref.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        '
        '
        '
        Me.tlotref.CustomButton.Image = Nothing
        Me.tlotref.CustomButton.Location = New System.Drawing.Point(101, 1)
        Me.tlotref.CustomButton.Name = ""
        Me.tlotref.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tlotref.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tlotref.CustomButton.TabIndex = 1
        Me.tlotref.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tlotref.CustomButton.UseSelectable = True
        Me.tlotref.CustomButton.Visible = False
        Me.tlotref.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlotref.Lines = New String(-1) {}
        Me.tlotref.Location = New System.Drawing.Point(216, 210)
        Me.tlotref.MaxLength = 32767
        Me.tlotref.Name = "tlotref"
        Me.tlotref.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tlotref.PromptText = "id job sas/etc"
        Me.tlotref.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tlotref.SelectedText = ""
        Me.tlotref.SelectionLength = 0
        Me.tlotref.SelectionStart = 0
        Me.tlotref.ShortcutsEnabled = True
        Me.tlotref.Size = New System.Drawing.Size(123, 23)
        Me.tlotref.TabIndex = 72
        Me.tlotref.UseCustomBackColor = True
        Me.tlotref.UseCustomForeColor = True
        Me.tlotref.UseSelectable = True
        Me.tlotref.WaterMark = "id job sas/etc"
        Me.tlotref.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tlotref.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'LinkAll
        '
        Me.LinkAll.AutoSize = True
        Me.LinkAll.BackColor = System.Drawing.Color.Transparent
        Me.LinkAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkAll.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkAll.Location = New System.Drawing.Point(229, 278)
        Me.LinkAll.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkAll.Name = "LinkAll"
        Me.LinkAll.Size = New System.Drawing.Size(32, 23)
        Me.LinkAll.TabIndex = 55
        Me.LinkAll.Text = "All"
        Me.LinkAll.UseCustomBackColor = True
        Me.LinkAll.UseSelectable = True
        Me.LinkAll.UseStyleColors = True
        '
        'Link2MonthAgo
        '
        Me.Link2MonthAgo.AutoSize = True
        Me.Link2MonthAgo.BackColor = System.Drawing.Color.Transparent
        Me.Link2MonthAgo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Link2MonthAgo.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.Link2MonthAgo.Location = New System.Drawing.Point(152, 278)
        Me.Link2MonthAgo.Margin = New System.Windows.Forms.Padding(0)
        Me.Link2MonthAgo.Name = "Link2MonthAgo"
        Me.Link2MonthAgo.Size = New System.Drawing.Size(77, 23)
        Me.Link2MonthAgo.TabIndex = 55
        Me.Link2MonthAgo.Text = "Last Month"
        Me.Link2MonthAgo.UseCustomBackColor = True
        Me.Link2MonthAgo.UseSelectable = True
        Me.Link2MonthAgo.UseStyleColors = True
        '
        'LinkThisMonth
        '
        Me.LinkThisMonth.AutoSize = True
        Me.LinkThisMonth.BackColor = System.Drawing.Color.Transparent
        Me.LinkThisMonth.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkThisMonth.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkThisMonth.Location = New System.Drawing.Point(82, 278)
        Me.LinkThisMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkThisMonth.Name = "LinkThisMonth"
        Me.LinkThisMonth.Size = New System.Drawing.Size(70, 23)
        Me.LinkThisMonth.TabIndex = 55
        Me.LinkThisMonth.Text = "This Month"
        Me.LinkThisMonth.UseCustomBackColor = True
        Me.LinkThisMonth.UseSelectable = True
        Me.LinkThisMonth.UseStyleColors = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MetroLabel2.Location = New System.Drawing.Point(3, 279)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel2.TabIndex = 0
        Me.MetroLabel2.Text = "Data List"
        Me.MetroLabel2.UseCustomBackColor = True
        Me.MetroLabel2.UseCustomForeColor = True
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.MetroGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroGrid1.AutoGenerateColumns = False
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdColumn, Me.IdhvsprodColumn, Me.LabnumColumn, Me.ScopeColumn, Me.VarietyColumn, Me.FarmerColumn, Me.LocationColumn, Me.HarvestColumn, Me.WeightColumn, Me.NomnlColumn, Me.NojobColumn, Me.loc_sampleColumn, Me.status_confirm, Me.req_date, Me.req_name, Me.ColmEdit, Me.ColmDelete})
        Me.MetroGrid1.DataSource = Me.QcconfirmviewerBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(3, 306)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.ReadOnly = True
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.MetroGrid1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(814, 169)
        Me.MetroGrid1.TabIndex = 24
        Me.MetroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'QcconfirmviewerBindingSource
        '
        Me.QcconfirmviewerBindingSource.DataMember = "qc_confirm_viewer"
        Me.QcconfirmviewerBindingSource.DataSource = Me.HCQC_NewDataset
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(826, 520)
        Me.MetroTabControl1.TabIndex = 55
        Me.MetroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.LinkLoad)
        Me.MetroTabPage3.Controls.Add(Me.GridControl1)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(818, 478)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "List of Request   "
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'LinkLoad
        '
        Me.LinkLoad.AutoSize = True
        Me.LinkLoad.BackColor = System.Drawing.Color.Transparent
        Me.LinkLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLoad.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkLoad.Location = New System.Drawing.Point(3, 3)
        Me.LinkLoad.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkLoad.Name = "LinkLoad"
        Me.LinkLoad.Size = New System.Drawing.Size(105, 23)
        Me.LinkLoad.TabIndex = 88
        Me.LinkLoad.TabStop = False
        Me.LinkLoad.Text = "Click to Load Data"
        Me.LinkLoad.UseCustomBackColor = True
        Me.LinkLoad.UseSelectable = True
        Me.LinkLoad.UseStyleColors = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me.MetroGrid1
        '
        'Spl_request1TableAdapter
        '
        Me.Spl_request1TableAdapter.ClearBeforeFill = True
        '
        'Qc_confirm_viewerTableAdapter
        '
        Me.Qc_confirm_viewerTableAdapter.ClearBeforeFill = True
        '
        'IdColumn
        '
        Me.IdColumn.DataPropertyName = "id"
        Me.IdColumn.HeaderText = "Request Number"
        Me.IdColumn.Name = "IdColumn"
        Me.IdColumn.ReadOnly = True
        Me.IdColumn.Width = 80
        '
        'IdhvsprodColumn
        '
        Me.IdhvsprodColumn.DataPropertyName = "id_hvsprod"
        Me.IdhvsprodColumn.HeaderText = "Production Code"
        Me.IdhvsprodColumn.Name = "IdhvsprodColumn"
        Me.IdhvsprodColumn.ReadOnly = True
        Me.IdhvsprodColumn.Width = 90
        '
        'LabnumColumn
        '
        Me.LabnumColumn.DataPropertyName = "labnum"
        Me.LabnumColumn.HeaderText = "Lab Number"
        Me.LabnumColumn.Name = "LabnumColumn"
        Me.LabnumColumn.ReadOnly = True
        '
        'ScopeColumn
        '
        Me.ScopeColumn.DataPropertyName = "scope"
        Me.ScopeColumn.HeaderText = "Scope"
        Me.ScopeColumn.Name = "ScopeColumn"
        Me.ScopeColumn.ReadOnly = True
        '
        'VarietyColumn
        '
        Me.VarietyColumn.DataPropertyName = "variety"
        Me.VarietyColumn.HeaderText = "Variety"
        Me.VarietyColumn.Name = "VarietyColumn"
        Me.VarietyColumn.ReadOnly = True
        Me.VarietyColumn.Width = 80
        '
        'FarmerColumn
        '
        Me.FarmerColumn.DataPropertyName = "farmer"
        Me.FarmerColumn.HeaderText = "Farmer"
        Me.FarmerColumn.Name = "FarmerColumn"
        Me.FarmerColumn.ReadOnly = True
        Me.FarmerColumn.Width = 80
        '
        'LocationColumn
        '
        Me.LocationColumn.DataPropertyName = "location"
        Me.LocationColumn.HeaderText = "Location"
        Me.LocationColumn.Name = "LocationColumn"
        Me.LocationColumn.ReadOnly = True
        '
        'HarvestColumn
        '
        Me.HarvestColumn.DataPropertyName = "harvest"
        Me.HarvestColumn.HeaderText = "Harvest"
        Me.HarvestColumn.Name = "HarvestColumn"
        Me.HarvestColumn.ReadOnly = True
        Me.HarvestColumn.Width = 90
        '
        'WeightColumn
        '
        Me.WeightColumn.DataPropertyName = "weight"
        Me.WeightColumn.HeaderText = "Weight (kg)"
        Me.WeightColumn.Name = "WeightColumn"
        Me.WeightColumn.ReadOnly = True
        Me.WeightColumn.Width = 75
        '
        'NomnlColumn
        '
        Me.NomnlColumn.DataPropertyName = "nomnl"
        Me.NomnlColumn.HeaderText = "Manual"
        Me.NomnlColumn.Name = "NomnlColumn"
        Me.NomnlColumn.ReadOnly = True
        Me.NomnlColumn.Width = 70
        '
        'NojobColumn
        '
        Me.NojobColumn.DataPropertyName = "nojob"
        Me.NojobColumn.HeaderText = "Lot/Job"
        Me.NojobColumn.Name = "NojobColumn"
        Me.NojobColumn.ReadOnly = True
        Me.NojobColumn.Width = 80
        '
        'loc_sampleColumn
        '
        Me.loc_sampleColumn.DataPropertyName = "loc_sample"
        Me.loc_sampleColumn.HeaderText = "Sample Location"
        Me.loc_sampleColumn.Name = "loc_sampleColumn"
        Me.loc_sampleColumn.ReadOnly = True
        Me.loc_sampleColumn.Width = 80
        '
        'status_confirm
        '
        Me.status_confirm.DataPropertyName = "status_confirm"
        Me.status_confirm.HeaderText = "Status"
        Me.status_confirm.Name = "status_confirm"
        Me.status_confirm.ReadOnly = True
        Me.status_confirm.Width = 85
        '
        'req_date
        '
        Me.req_date.DataPropertyName = "req_date"
        Me.req_date.HeaderText = "Create at"
        Me.req_date.Name = "req_date"
        Me.req_date.ReadOnly = True
        Me.req_date.Width = 85
        '
        'req_name
        '
        Me.req_name.DataPropertyName = "req_name"
        Me.req_name.HeaderText = "Request by"
        Me.req_name.Name = "req_name"
        Me.req_name.ReadOnly = True
        '
        'ColmEdit
        '
        Me.ColmEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ColmEdit.HeaderText = "Button"
        Me.ColmEdit.Name = "ColmEdit"
        Me.ColmEdit.ReadOnly = True
        Me.ColmEdit.Text = "Edit"
        Me.ColmEdit.UseColumnTextForButtonValue = True
        Me.ColmEdit.Width = 65
        '
        'ColmDelete
        '
        Me.ColmDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ColmDelete.HeaderText = "Button"
        Me.ColmDelete.Name = "ColmDelete"
        Me.ColmDelete.ReadOnly = True
        Me.ColmDelete.Text = "Delete"
        Me.ColmDelete.UseColumnTextForButtonValue = True
        Me.ColmDelete.Width = 65
        '
        'Request_Sampling_From
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Name = "Request_Sampling_From"
        Me.Size = New System.Drawing.Size(826, 520)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Splrequest1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QcconfirmviewerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage3.ResumeLayout(False)
        Me.MetroTabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroToolTip1 As Components.MetroToolTip
    Friend WithEvents MetroStyleExtender1 As Components.MetroStyleExtender
    Friend WithEvents MetroStyleManager1 As Components.MetroStyleManager
    Friend WithEvents MetroTabPage1 As MetroTabPage
    Friend WithEvents MetroGrid1 As MetroGrid
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents HCQC_NewDataset As HCQC_NewDataset
    Friend WithEvents MetroLabel2 As MetroLabel
    Public WithEvents MetroTabControl1 As MetroTabControl
    Friend WithEvents MetroPanel1 As MetroPanel
    Friend WithEvents tremark As MetroTextBox
    Friend WithEvents traf As MetroCheckBox
    Friend WithEvents tvia As MetroCheckBox
    Friend WithEvents MetroLabel10 As MetroLabel
    Friend WithEvents tger As MetroCheckBox
    Friend WithEvents MetroLabel11 As MetroLabel
    Friend WithEvents tpur As MetroCheckBox
    Friend WithEvents MetroLabel3 As MetroLabel
    Friend WithEvents MetroLabel1 As MetroLabel
    Friend WithEvents tmoi As MetroCheckBox
    Friend WithEvents MetroLabel13 As MetroLabel
    Friend WithEvents tsampling As MetroCheckBox
    Friend WithEvents tscope As MetroComboBox
    Friend WithEvents MetroLabel15 As MetroLabel
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents MetroLabel17 As MetroLabel
    Friend WithEvents MetroLabel18 As MetroLabel
    Friend WithEvents tfarmer As MetroTextBox
    Friend WithEvents tlocation As MetroTextBox
    Friend WithEvents MetroPanel2 As MetroPanel
    Friend WithEvents tgl_hvs As MaskedTextBox
    Friend WithEvents tlotqtt As MetroTextBox
    Friend WithEvents tvariety As MetroTextBox
    Friend WithEvents tnoman As MetroTextBox
    Friend WithEvents tlotref As MetroTextBox
    Friend WithEvents MetroLabel4 As MetroLabel
    Friend WithEvents LinkAll As MetroLink
    Friend WithEvents Link2MonthAgo As MetroLink
    Friend WithEvents LinkThisMonth As MetroLink
    Friend WithEvents LinkClearRequest As MetroLink
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents MetroLabel5 As MetroLabel
    Friend WithEvents tid_hvsprod As MetroTextBox
    Friend WithEvents LabelDate As MetroLabel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents tbag As MetroTextBox
    Friend WithEvents MetroLabel7 As MetroLabel
    Friend WithEvents LinkSelectallRequest As MetroLink
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MetroLabel6 As MetroLabel
    Friend WithEvents tcrop As MetroTextBox
    Friend WithEvents MetroTabPage3 As MetroTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvariety As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfarmer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colharvest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colweight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnomnl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnojob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colscope As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnama_req As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colinput_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colid_hvsprod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltest_sampling As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltest_moi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltest_pur As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltest_ger As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltest_via As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltest_raf As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcrop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LinkFind As MetroLink
    Friend WithEvents colbag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdhvsprodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabnumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScopeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarietyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FarmerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HarvestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomnlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NojobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BagDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamareqDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BagColumn As DataGridViewTextBoxColumn
    Friend WithEvents Splrequest1BindingSource As BindingSource
    Friend WithEvents colstatus_confirm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Spl_request1TableAdapter As HCQC_NewDatasetTableAdapters.Spl_request1TableAdapter
    Friend WithEvents LinkLoad As MetroLink
    Friend WithEvents QcconfirmviewerBindingSource As BindingSource
    Friend WithEvents Qc_confirm_viewerTableAdapter As HCQC_NewDatasetTableAdapters.qc_confirm_viewerTableAdapter
    Friend WithEvents Tsearch As MetroTextBox
    Friend WithEvents tloc_sample As MetroComboBox
    Friend WithEvents collabnum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colinformation_rejected As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltgl_confirm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colloc_sample As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdhvsprodColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabnumColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScopeColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarietyColumn As DataGridViewTextBoxColumn
    Friend WithEvents FarmerColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationColumn As DataGridViewTextBoxColumn
    Friend WithEvents HarvestColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomnlColumn As DataGridViewTextBoxColumn
    Friend WithEvents NojobColumn As DataGridViewTextBoxColumn
    Friend WithEvents loc_sampleColumn As DataGridViewTextBoxColumn
    Friend WithEvents status_confirm As DataGridViewTextBoxColumn
    Friend WithEvents req_date As DataGridViewTextBoxColumn
    Friend WithEvents req_name As DataGridViewTextBoxColumn
    Friend WithEvents ColmEdit As DataGridViewButtonColumn
    Friend WithEvents ColmDelete As DataGridViewButtonColumn
End Class
