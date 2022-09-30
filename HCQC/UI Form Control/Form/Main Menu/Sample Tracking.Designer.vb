<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sample_Tracking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sample_Tracking))
        Dim SimpleContextButton1 As DevExpress.Utils.SimpleContextButton = New DevExpress.Utils.SimpleContextButton()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LInkRefresh = New MetroFramework.Controls.MetroLink()
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.StartDate = New System.Windows.Forms.DateTimePicker()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.BtnFilterDate = New Bunifu.Framework.UI.BunifuImageButton()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.EndDate = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.MetroLink2 = New MetroFramework.Controls.MetroLink()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ReportstatuspengujianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_NewDataset = New WindowsApplication1.HCQC_NewDataset()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collabnum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colid_hvsprod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvariety = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnomnl = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnojob = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colweight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfarmer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colharvest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colscope = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltest_sampling = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltest_moi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltest_pur = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltest_ger = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltest_via = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltest_raf = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltest_ontest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colinput_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceipt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbrt_in = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceipt_Input = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsampler = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstatus_confirm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsampling = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRaf_Test = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRaf_Result = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRaf_Analys = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRaf_input = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMoi_Test = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMoi_Analys = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMoi_input = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGer_TestLog = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGer_Test = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGer_1st = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGer_1st_Est = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGer_2nd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGer_2nd_Est = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGer_Analys = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGer_input = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVia_Test = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVia_Analys = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVia_input = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPur_Test = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPur_Analys = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPur_input = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuick_Raf = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRetunQC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReturnQC_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatusResult = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldays_est = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldate_est = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmoisture_log = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpurity_log = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colrafaction_log = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colviability_log = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgervigor_log = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgerout_log = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmoisture_namelog = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpurity_namelog = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colrafaction_namelog = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colviability_namelog = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgertest_namelog = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgerout_namelog = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgervigor_namelog = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colaccept_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LinkLastMonth1 = New MetroFramework.Controls.MetroLink()
        Me.LinkThisMonth1 = New MetroFramework.Controls.MetroLink()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.CboxParameterCari = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdhvsprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarietyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FarmerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HarvestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomnlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.request_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OfficerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportsampelambilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.Lraf = New MetroFramework.Controls.MetroLabel()
        Me.tweight = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.tlabnum = New MetroFramework.Controls.MetroTextBox()
        Me.tscope = New MetroFramework.Controls.MetroLabel()
        Me.tlotref = New MetroFramework.Controls.MetroLabel()
        Me.Tnama = New MetroFramework.Controls.MetroTextBox()
        Me.tnomnl = New MetroFramework.Controls.MetroLabel()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.tSearchReturn = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.Lfarmer = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.Lreqnum = New MetroFramework.Controls.MetroLabel()
        Me.tVariety = New MetroFramework.Controls.MetroLabel()
        Me.BtnSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.tharvest = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.Tremark = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.BtnCariLab = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Ltgl_update = New MetroFramework.Controls.MetroLabel()
        Me.Labelupdate = New MetroFramework.Controls.MetroLabel()
        Me.LLocation = New MetroFramework.Controls.MetroLabel()
        Me.Report_status_pengujianTableAdapter = New WindowsApplication1.HCQC_NewDatasetTableAdapters.report_status_pengujianTableAdapter()
        Me.Report_sampel_ambilTableAdapter = New WindowsApplication1.HCQC_NewDatasetTableAdapters.report_sampel_ambilTableAdapter()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        CType(Me.BtnFilterDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportstatuspengujianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage2.SuspendLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportsampelambilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LInkRefresh
        '
        Me.LInkRefresh.AutoSize = True
        Me.LInkRefresh.BackColor = System.Drawing.Color.Transparent
        Me.LInkRefresh.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LInkRefresh.Location = New System.Drawing.Point(3, 22)
        Me.LInkRefresh.Name = "LInkRefresh"
        Me.LInkRefresh.Size = New System.Drawing.Size(54, 23)
        Me.LInkRefresh.TabIndex = 80
        Me.LInkRefresh.Text = "Refresh"
        Me.LInkRefresh.UseCustomBackColor = True
        Me.LInkRefresh.UseSelectable = True
        Me.LInkRefresh.UseStyleColors = True
        '
        'StartDate
        '
        Me.MetroStyleExtender1.SetApplyMetroTheme(Me.StartDate, True)
        Me.StartDate.CustomFormat = "dd-mmm-yyyy"
        Me.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.StartDate.Location = New System.Drawing.Point(276, 25)
        Me.StartDate.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.StartDate.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(106, 20)
        Me.StartDate.TabIndex = 90
        Me.StartDate.Value = New Date(2022, 9, 19, 0, 0, 0, 0)
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Nothing
        Me.MetroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Location = New System.Drawing.Point(3, 3)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(999, 549)
        Me.MetroTabControl1.TabIndex = 81
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel19)
        Me.MetroTabPage1.Controls.Add(Me.BtnFilterDate)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel18)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel16)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel15)
        Me.MetroTabPage1.Controls.Add(Me.EndDate)
        Me.MetroTabPage1.Controls.Add(Me.StartDate)
        Me.MetroTabPage1.Controls.Add(Me.ComboBoxEdit1)
        Me.MetroTabPage1.Controls.Add(Me.MetroLink2)
        Me.MetroTabPage1.Controls.Add(Me.MetroLink1)
        Me.MetroTabPage1.Controls.Add(Me.GridControl1)
        Me.MetroTabPage1.Controls.Add(Me.LinkLastMonth1)
        Me.MetroTabPage1.Controls.Add(Me.LinkThisMonth1)
        Me.MetroTabPage1.Controls.Add(Me.LInkRefresh)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(991, 507)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Sample Tracking   "
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'MetroLabel19
        '
        Me.MetroLabel19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel19.Location = New System.Drawing.Point(887, 7)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(92, 15)
        Me.MetroLabel19.TabIndex = 152
        Me.MetroLabel19.Text = " Setting GridView"
        '
        'BtnFilterDate
        '
        Me.BtnFilterDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnFilterDate.Image = CType(resources.GetObject("BtnFilterDate.Image"), System.Drawing.Image)
        Me.BtnFilterDate.ImageActive = Nothing
        Me.BtnFilterDate.Location = New System.Drawing.Point(518, 22)
        Me.BtnFilterDate.Name = "BtnFilterDate"
        Me.BtnFilterDate.Size = New System.Drawing.Size(38, 23)
        Me.BtnFilterDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnFilterDate.TabIndex = 151
        Me.BtnFilterDate.TabStop = False
        Me.BtnFilterDate.Zoom = 10
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel18.Location = New System.Drawing.Point(388, 28)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(12, 15)
        Me.MetroLabel18.TabIndex = 94
        Me.MetroLabel18.Text = "-"
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel16.Location = New System.Drawing.Point(406, 7)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(53, 15)
        Me.MetroLabel16.TabIndex = 93
        Me.MetroLabel16.Text = "End Date"
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel15.Location = New System.Drawing.Point(276, 7)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(59, 15)
        Me.MetroLabel15.TabIndex = 92
        Me.MetroLabel15.Text = "Start Date"
        '
        'EndDate
        '
        Me.EndDate.CustomFormat = "dd-mmm-yyyy"
        Me.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EndDate.Location = New System.Drawing.Point(406, 25)
        Me.EndDate.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.EndDate.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(106, 20)
        Me.EndDate.TabIndex = 91
        Me.EndDate.Value = New Date(2022, 9, 19, 0, 0, 0, 0)
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(772, 25)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        SimpleContextButton1.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Center
        SimpleContextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far
        SimpleContextButton1.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Right
        SimpleContextButton1.Id = New System.Guid("1c5390a2-4707-44f9-ba6b-367a99011a00")
        SimpleContextButton1.ImageOptionsCollection.ItemHovered.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        SimpleContextButton1.ImageOptionsCollection.ItemNormal.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        SimpleContextButton1.ImageOptionsCollection.ItemPressed.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        SimpleContextButton1.Name = "simpleContextButton1"
        Me.ComboBoxEdit1.Properties.ContextButtons.Add(SimpleContextButton1)
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"SetView1", "GerView"})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(112, 20)
        Me.ComboBoxEdit1.TabIndex = 89
        '
        'MetroLink2
        '
        Me.MetroLink2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLink2.AutoSize = True
        Me.MetroLink2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLink2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroLink2.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.MetroLink2.Location = New System.Drawing.Point(943, 25)
        Me.MetroLink2.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLink2.Name = "MetroLink2"
        Me.MetroLink2.Size = New System.Drawing.Size(45, 23)
        Me.MetroLink2.TabIndex = 88
        Me.MetroLink2.Text = "Save"
        Me.MetroLink2.UseCustomBackColor = True
        Me.MetroLink2.UseSelectable = True
        Me.MetroLink2.UseStyleColors = True
        '
        'MetroLink1
        '
        Me.MetroLink1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLink1.AutoSize = True
        Me.MetroLink1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLink1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroLink1.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.MetroLink1.Location = New System.Drawing.Point(887, 25)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(56, 23)
        Me.MetroLink1.TabIndex = 87
        Me.MetroLink1.Text = "Delete"
        Me.MetroLink1.UseCustomBackColor = True
        Me.MetroLink1.UseSelectable = True
        Me.MetroLink1.UseStyleColors = True
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.ReportstatuspengujianBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(3, 51)
        Me.GridControl1.LookAndFeel.SkinName = "The Bezier"
        Me.GridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(985, 453)
        Me.GridControl1.TabIndex = 86
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ReportstatuspengujianBindingSource
        '
        Me.ReportstatuspengujianBindingSource.DataMember = "report_status_pengujian"
        Me.ReportstatuspengujianBindingSource.DataSource = Me.HCQC_NewDataset
        '
        'HCQC_NewDataset
        '
        Me.HCQC_NewDataset.DataSetName = "HCQC_NewDataset"
        Me.HCQC_NewDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.collabnum, Me.colid_hvsprod, Me.colvariety, Me.colnomnl, Me.colnojob, Me.colweight, Me.colfarmer, Me.collocation, Me.colharvest, Me.colscope, Me.coltest_sampling, Me.coltest_moi, Me.coltest_pur, Me.coltest_ger, Me.coltest_via, Me.coltest_raf, Me.coltest_ontest, Me.colinput_date, Me.colReceipt, Me.colbrt_in, Me.colReceipt_Input, Me.colsampler, Me.colstatus_confirm, Me.colsampling, Me.colRaf_Test, Me.colRaf_Result, Me.colRaf_Analys, Me.colRaf_input, Me.colMoi_Test, Me.colMoi_Analys, Me.colMoi_input, Me.colGer_TestLog, Me.colGer_Test, Me.colGer_1st, Me.colGer_1st_Est, Me.colGer_2nd, Me.colGer_2nd_Est, Me.colGer_Analys, Me.colGer_input, Me.colVia_Test, Me.colVia_Analys, Me.colVia_input, Me.colPur_Test, Me.colPur_Analys, Me.colPur_input, Me.colQuick_Raf, Me.colRetunQC, Me.colReturnQC_Name, Me.colStatusResult, Me.coldays_est, Me.coldate_est, Me.colmoisture_log, Me.colpurity_log, Me.colrafaction_log, Me.colviability_log, Me.colgervigor_log, Me.colgerout_log, Me.colmoisture_namelog, Me.colpurity_namelog, Me.colrafaction_namelog, Me.colviability_namelog, Me.colgertest_namelog, Me.colgerout_namelog, Me.colgervigor_namelog, Me.colaccept_date})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.GridView1.OptionsCustomization.CustomizationFormSearchBoxVisible = True
        Me.GridView1.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridView1.OptionsMenu.ShowSummaryItemMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colid
        '
        Me.colid.Caption = "No Request"
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        Me.colid.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colid.Visible = True
        Me.colid.VisibleIndex = 0
        '
        'collabnum
        '
        Me.collabnum.Caption = "Lab Number"
        Me.collabnum.FieldName = "labnum"
        Me.collabnum.Name = "collabnum"
        Me.collabnum.Visible = True
        Me.collabnum.VisibleIndex = 2
        Me.collabnum.Width = 98
        '
        'colid_hvsprod
        '
        Me.colid_hvsprod.Caption = "No Production"
        Me.colid_hvsprod.FieldName = "id_hvsprod"
        Me.colid_hvsprod.Name = "colid_hvsprod"
        Me.colid_hvsprod.Visible = True
        Me.colid_hvsprod.VisibleIndex = 1
        Me.colid_hvsprod.Width = 90
        '
        'colvariety
        '
        Me.colvariety.Caption = "Variety"
        Me.colvariety.FieldName = "variety"
        Me.colvariety.Name = "colvariety"
        Me.colvariety.Visible = True
        Me.colvariety.VisibleIndex = 3
        '
        'colnomnl
        '
        Me.colnomnl.Caption = "Manual"
        Me.colnomnl.FieldName = "nomnl"
        Me.colnomnl.Name = "colnomnl"
        Me.colnomnl.Visible = True
        Me.colnomnl.VisibleIndex = 4
        Me.colnomnl.Width = 55
        '
        'colnojob
        '
        Me.colnojob.Caption = "Lot/Job"
        Me.colnojob.FieldName = "nojob"
        Me.colnojob.Name = "colnojob"
        Me.colnojob.Visible = True
        Me.colnojob.VisibleIndex = 5
        '
        'colweight
        '
        Me.colweight.Caption = "Weight (kg)"
        Me.colweight.FieldName = "weight"
        Me.colweight.Name = "colweight"
        Me.colweight.Visible = True
        Me.colweight.VisibleIndex = 8
        Me.colweight.Width = 79
        '
        'colfarmer
        '
        Me.colfarmer.Caption = "Farmer"
        Me.colfarmer.FieldName = "farmer"
        Me.colfarmer.Name = "colfarmer"
        Me.colfarmer.Visible = True
        Me.colfarmer.VisibleIndex = 6
        Me.colfarmer.Width = 94
        '
        'collocation
        '
        Me.collocation.Caption = "Location"
        Me.collocation.FieldName = "location"
        Me.collocation.Name = "collocation"
        Me.collocation.Visible = True
        Me.collocation.VisibleIndex = 7
        '
        'colharvest
        '
        Me.colharvest.Caption = "Harvest"
        Me.colharvest.FieldName = "harvest"
        Me.colharvest.Name = "colharvest"
        Me.colharvest.Visible = True
        Me.colharvest.VisibleIndex = 9
        '
        'colscope
        '
        Me.colscope.Caption = "Scope"
        Me.colscope.FieldName = "scope"
        Me.colscope.Name = "colscope"
        Me.colscope.Visible = True
        Me.colscope.VisibleIndex = 10
        Me.colscope.Width = 87
        '
        'coltest_sampling
        '
        Me.coltest_sampling.Caption = "Test Sampling"
        Me.coltest_sampling.FieldName = "test_sampling"
        Me.coltest_sampling.Name = "coltest_sampling"
        Me.coltest_sampling.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.coltest_sampling.Visible = True
        Me.coltest_sampling.VisibleIndex = 12
        Me.coltest_sampling.Width = 80
        '
        'coltest_moi
        '
        Me.coltest_moi.Caption = "Test Moisture"
        Me.coltest_moi.FieldName = "test_moi"
        Me.coltest_moi.Name = "coltest_moi"
        Me.coltest_moi.Visible = True
        Me.coltest_moi.VisibleIndex = 13
        Me.coltest_moi.Width = 79
        '
        'coltest_pur
        '
        Me.coltest_pur.Caption = "Test Purity"
        Me.coltest_pur.FieldName = "test_pur"
        Me.coltest_pur.Name = "coltest_pur"
        Me.coltest_pur.Visible = True
        Me.coltest_pur.VisibleIndex = 14
        Me.coltest_pur.Width = 67
        '
        'coltest_ger
        '
        Me.coltest_ger.Caption = "Test Germination"
        Me.coltest_ger.FieldName = "test_ger"
        Me.coltest_ger.Name = "coltest_ger"
        Me.coltest_ger.Visible = True
        Me.coltest_ger.VisibleIndex = 15
        Me.coltest_ger.Width = 93
        '
        'coltest_via
        '
        Me.coltest_via.Caption = "Test Viability"
        Me.coltest_via.FieldName = "test_via"
        Me.coltest_via.Name = "coltest_via"
        Me.coltest_via.Visible = True
        Me.coltest_via.VisibleIndex = 16
        Me.coltest_via.Width = 74
        '
        'coltest_raf
        '
        Me.coltest_raf.Caption = "Test Rafaction"
        Me.coltest_raf.FieldName = "test_raf"
        Me.coltest_raf.Name = "coltest_raf"
        Me.coltest_raf.Visible = True
        Me.coltest_raf.VisibleIndex = 17
        Me.coltest_raf.Width = 83
        '
        'coltest_ontest
        '
        Me.coltest_ontest.Caption = "On TestDB"
        Me.coltest_ontest.FieldName = "test_ontest"
        Me.coltest_ontest.Name = "coltest_ontest"
        '
        'colinput_date
        '
        Me.colinput_date.Caption = "Request Date"
        Me.colinput_date.FieldName = "input_date"
        Me.colinput_date.Name = "colinput_date"
        Me.colinput_date.Visible = True
        Me.colinput_date.VisibleIndex = 18
        Me.colinput_date.Width = 80
        '
        'colReceipt
        '
        Me.colReceipt.Caption = "Receipt Date"
        Me.colReceipt.FieldName = "Receipt"
        Me.colReceipt.Name = "colReceipt"
        Me.colReceipt.Visible = True
        Me.colReceipt.VisibleIndex = 19
        Me.colReceipt.Width = 76
        '
        'colbrt_in
        '
        Me.colbrt_in.Caption = "Receipt Sample (g)"
        Me.colbrt_in.FieldName = "brt_in"
        Me.colbrt_in.Name = "colbrt_in"
        Me.colbrt_in.Width = 113
        '
        'colReceipt_Input
        '
        Me.colReceipt_Input.Caption = "Receipt Input"
        Me.colReceipt_Input.FieldName = "Receipt_Input"
        Me.colReceipt_Input.Name = "colReceipt_Input"
        Me.colReceipt_Input.Width = 97
        '
        'colsampler
        '
        Me.colsampler.Caption = "Sampler"
        Me.colsampler.FieldName = "sampler"
        Me.colsampler.Name = "colsampler"
        Me.colsampler.Width = 67
        '
        'colstatus_confirm
        '
        Me.colstatus_confirm.Caption = "Status QC"
        Me.colstatus_confirm.FieldName = "status_confirm"
        Me.colstatus_confirm.Name = "colstatus_confirm"
        Me.colstatus_confirm.Visible = True
        Me.colstatus_confirm.VisibleIndex = 11
        '
        'colsampling
        '
        Me.colsampling.Caption = "Sampling"
        Me.colsampling.FieldName = "sampling"
        Me.colsampling.Name = "colsampling"
        Me.colsampling.Visible = True
        Me.colsampling.VisibleIndex = 20
        Me.colsampling.Width = 67
        '
        'colRaf_Test
        '
        Me.colRaf_Test.Caption = "Rafaction Test"
        Me.colRaf_Test.FieldName = "Raf_Test"
        Me.colRaf_Test.Name = "colRaf_Test"
        Me.colRaf_Test.Width = 80
        '
        'colRaf_Result
        '
        Me.colRaf_Result.Caption = "Rafaction Result"
        Me.colRaf_Result.FieldName = "Raf_Result"
        Me.colRaf_Result.Name = "colRaf_Result"
        Me.colRaf_Result.Width = 67
        '
        'colRaf_Analys
        '
        Me.colRaf_Analys.Caption = "Rafaction Analys"
        Me.colRaf_Analys.FieldName = "Raf_Analys"
        Me.colRaf_Analys.Name = "colRaf_Analys"
        Me.colRaf_Analys.Width = 67
        '
        'colRaf_input
        '
        Me.colRaf_input.Caption = "Rafaction input"
        Me.colRaf_input.FieldName = "Raf_input"
        Me.colRaf_input.Name = "colRaf_input"
        Me.colRaf_input.Width = 83
        '
        'colMoi_Test
        '
        Me.colMoi_Test.Caption = "Moisture Test"
        Me.colMoi_Test.FieldName = "Moi_Test"
        Me.colMoi_Test.Name = "colMoi_Test"
        Me.colMoi_Test.Width = 92
        '
        'colMoi_Analys
        '
        Me.colMoi_Analys.Caption = "Moisture Analys"
        Me.colMoi_Analys.FieldName = "Moi_Analys"
        Me.colMoi_Analys.Name = "colMoi_Analys"
        Me.colMoi_Analys.Width = 93
        '
        'colMoi_input
        '
        Me.colMoi_input.Caption = "Moisture Input"
        Me.colMoi_input.FieldName = "Moi_input"
        Me.colMoi_input.Name = "colMoi_input"
        Me.colMoi_input.Width = 93
        '
        'colGer_TestLog
        '
        Me.colGer_TestLog.Caption = "GerTest_log"
        Me.colGer_TestLog.FieldName = "Ger_TestLog"
        Me.colGer_TestLog.Name = "colGer_TestLog"
        Me.colGer_TestLog.Visible = True
        Me.colGer_TestLog.VisibleIndex = 25
        Me.colGer_TestLog.Width = 101
        '
        'colGer_Test
        '
        Me.colGer_Test.Caption = "Germination Test"
        Me.colGer_Test.FieldName = "Ger_Test"
        Me.colGer_Test.Name = "colGer_Test"
        Me.colGer_Test.Width = 109
        '
        'colGer_1st
        '
        Me.colGer_1st.Caption = "Germination 1st"
        Me.colGer_1st.FieldName = "Ger_1st"
        Me.colGer_1st.Name = "colGer_1st"
        Me.colGer_1st.Width = 88
        '
        'colGer_1st_Est
        '
        Me.colGer_1st_Est.Caption = "Germ 1st Estm"
        Me.colGer_1st_Est.FieldName = "Ger_1st_Est"
        Me.colGer_1st_Est.Name = "colGer_1st_Est"
        Me.colGer_1st_Est.Width = 82
        '
        'colGer_2nd
        '
        Me.colGer_2nd.Caption = "Germination 2nd"
        Me.colGer_2nd.FieldName = "Ger_2nd"
        Me.colGer_2nd.Name = "colGer_2nd"
        Me.colGer_2nd.Width = 91
        '
        'colGer_2nd_Est
        '
        Me.colGer_2nd_Est.Caption = "Germ 2nd Estm"
        Me.colGer_2nd_Est.FieldName = "Ger_2nd_Est"
        Me.colGer_2nd_Est.Name = "colGer_2nd_Est"
        Me.colGer_2nd_Est.Width = 88
        '
        'colGer_Analys
        '
        Me.colGer_Analys.Caption = "Germination Analys"
        Me.colGer_Analys.FieldName = "Ger_Analys"
        Me.colGer_Analys.Name = "colGer_Analys"
        Me.colGer_Analys.Width = 116
        '
        'colGer_input
        '
        Me.colGer_input.Caption = "Germination Input"
        Me.colGer_input.FieldName = "Ger_input"
        Me.colGer_input.Name = "colGer_input"
        Me.colGer_input.Width = 99
        '
        'colVia_Test
        '
        Me.colVia_Test.Caption = "Viability Test"
        Me.colVia_Test.FieldName = "Via_Test"
        Me.colVia_Test.Name = "colVia_Test"
        Me.colVia_Test.Width = 82
        '
        'colVia_Analys
        '
        Me.colVia_Analys.Caption = "Viability Analys"
        Me.colVia_Analys.FieldName = "Via_Analys"
        Me.colVia_Analys.Name = "colVia_Analys"
        Me.colVia_Analys.Width = 99
        '
        'colVia_input
        '
        Me.colVia_input.Caption = "Viability Input"
        Me.colVia_input.FieldName = "Via_input"
        Me.colVia_input.Name = "colVia_input"
        Me.colVia_input.Width = 93
        '
        'colPur_Test
        '
        Me.colPur_Test.Caption = "Purity Test"
        Me.colPur_Test.FieldName = "Pur_Test"
        Me.colPur_Test.Name = "colPur_Test"
        Me.colPur_Test.Width = 80
        '
        'colPur_Analys
        '
        Me.colPur_Analys.Caption = "Purity Analys"
        Me.colPur_Analys.FieldName = "Pur_Analys"
        Me.colPur_Analys.Name = "colPur_Analys"
        Me.colPur_Analys.Width = 88
        '
        'colPur_input
        '
        Me.colPur_input.Caption = "Purity Input"
        Me.colPur_input.FieldName = "Pur_input"
        Me.colPur_input.Name = "colPur_input"
        Me.colPur_input.Width = 67
        '
        'colQuick_Raf
        '
        Me.colQuick_Raf.Caption = "Quick Result Raf"
        Me.colQuick_Raf.FieldName = "Quick_Raf"
        Me.colQuick_Raf.Name = "colQuick_Raf"
        Me.colQuick_Raf.Visible = True
        Me.colQuick_Raf.VisibleIndex = 28
        Me.colQuick_Raf.Width = 104
        '
        'colRetunQC
        '
        Me.colRetunQC.FieldName = "RetunQC"
        Me.colRetunQC.Name = "colRetunQC"
        Me.colRetunQC.Visible = True
        Me.colRetunQC.VisibleIndex = 29
        Me.colRetunQC.Width = 67
        '
        'colReturnQC_Name
        '
        Me.colReturnQC_Name.FieldName = "ReturnQC_Name"
        Me.colReturnQC_Name.Name = "colReturnQC_Name"
        Me.colReturnQC_Name.Width = 87
        '
        'colStatusResult
        '
        Me.colStatusResult.Caption = "Status Result"
        Me.colStatusResult.FieldName = "StatusResult"
        Me.colStatusResult.Name = "colStatusResult"
        Me.colStatusResult.Visible = True
        Me.colStatusResult.VisibleIndex = 30
        '
        'coldays_est
        '
        Me.coldays_est.Caption = "Days Est."
        Me.coldays_est.FieldName = "days_est"
        Me.coldays_est.Name = "coldays_est"
        Me.coldays_est.Visible = True
        Me.coldays_est.VisibleIndex = 31
        '
        'coldate_est
        '
        Me.coldate_est.Caption = "Date Est."
        Me.coldate_est.FieldName = "date_est"
        Me.coldate_est.Name = "coldate_est"
        Me.coldate_est.Visible = True
        Me.coldate_est.VisibleIndex = 32
        '
        'colmoisture_log
        '
        Me.colmoisture_log.FieldName = "moisture_log"
        Me.colmoisture_log.Name = "colmoisture_log"
        Me.colmoisture_log.Visible = True
        Me.colmoisture_log.VisibleIndex = 21
        '
        'colpurity_log
        '
        Me.colpurity_log.FieldName = "purity_log"
        Me.colpurity_log.Name = "colpurity_log"
        Me.colpurity_log.Visible = True
        Me.colpurity_log.VisibleIndex = 22
        '
        'colrafaction_log
        '
        Me.colrafaction_log.FieldName = "rafaction_log"
        Me.colrafaction_log.Name = "colrafaction_log"
        Me.colrafaction_log.Visible = True
        Me.colrafaction_log.VisibleIndex = 23
        '
        'colviability_log
        '
        Me.colviability_log.FieldName = "viability_log"
        Me.colviability_log.Name = "colviability_log"
        Me.colviability_log.Visible = True
        Me.colviability_log.VisibleIndex = 24
        '
        'colgervigor_log
        '
        Me.colgervigor_log.Caption = "GerVigor_log"
        Me.colgervigor_log.FieldName = "gervigor_log"
        Me.colgervigor_log.Name = "colgervigor_log"
        Me.colgervigor_log.Visible = True
        Me.colgervigor_log.VisibleIndex = 26
        Me.colgervigor_log.Width = 94
        '
        'colgerout_log
        '
        Me.colgerout_log.Caption = "GerOut_log"
        Me.colgerout_log.FieldName = "gerout_log"
        Me.colgerout_log.Name = "colgerout_log"
        Me.colgerout_log.Visible = True
        Me.colgerout_log.VisibleIndex = 27
        Me.colgerout_log.Width = 101
        '
        'colmoisture_namelog
        '
        Me.colmoisture_namelog.FieldName = "moisture_namelog"
        Me.colmoisture_namelog.Name = "colmoisture_namelog"
        '
        'colpurity_namelog
        '
        Me.colpurity_namelog.FieldName = "purity_namelog"
        Me.colpurity_namelog.Name = "colpurity_namelog"
        '
        'colrafaction_namelog
        '
        Me.colrafaction_namelog.FieldName = "rafaction_namelog"
        Me.colrafaction_namelog.Name = "colrafaction_namelog"
        '
        'colviability_namelog
        '
        Me.colviability_namelog.FieldName = "viability_namelog"
        Me.colviability_namelog.Name = "colviability_namelog"
        '
        'colgertest_namelog
        '
        Me.colgertest_namelog.Caption = "GerTest_namelog"
        Me.colgertest_namelog.FieldName = "gertest_namelog"
        Me.colgertest_namelog.Name = "colgertest_namelog"
        '
        'colgerout_namelog
        '
        Me.colgerout_namelog.Caption = "GerOut_namelog"
        Me.colgerout_namelog.FieldName = "gerout_namelog"
        Me.colgerout_namelog.Name = "colgerout_namelog"
        '
        'colgervigor_namelog
        '
        Me.colgervigor_namelog.Caption = "GerVigor_namelog"
        Me.colgervigor_namelog.FieldName = "gervigor_namelog"
        Me.colgervigor_namelog.Name = "colgervigor_namelog"
        '
        'colaccept_date
        '
        Me.colaccept_date.FieldName = "accept_date"
        Me.colaccept_date.Name = "colaccept_date"
        Me.colaccept_date.Visible = True
        Me.colaccept_date.VisibleIndex = 33
        '
        'LinkLastMonth1
        '
        Me.LinkLastMonth1.AutoSize = True
        Me.LinkLastMonth1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLastMonth1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLastMonth1.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkLastMonth1.Location = New System.Drawing.Point(184, 22)
        Me.LinkLastMonth1.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkLastMonth1.Name = "LinkLastMonth1"
        Me.LinkLastMonth1.Size = New System.Drawing.Size(70, 23)
        Me.LinkLastMonth1.TabIndex = 83
        Me.LinkLastMonth1.Text = "Last Month"
        Me.LinkLastMonth1.UseCustomBackColor = True
        Me.LinkLastMonth1.UseSelectable = True
        Me.LinkLastMonth1.UseStyleColors = True
        '
        'LinkThisMonth1
        '
        Me.LinkThisMonth1.AutoSize = True
        Me.LinkThisMonth1.BackColor = System.Drawing.Color.Transparent
        Me.LinkThisMonth1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkThisMonth1.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkThisMonth1.Location = New System.Drawing.Point(114, 22)
        Me.LinkThisMonth1.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkThisMonth1.Name = "LinkThisMonth1"
        Me.LinkThisMonth1.Size = New System.Drawing.Size(70, 23)
        Me.LinkThisMonth1.TabIndex = 84
        Me.LinkThisMonth1.Text = "This Month"
        Me.LinkThisMonth1.UseCustomBackColor = True
        Me.LinkThisMonth1.UseSelectable = True
        Me.LinkThisMonth1.UseStyleColors = True
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.CboxParameterCari)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel14)
        Me.MetroTabPage2.Controls.Add(Me.MetroGrid1)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel7)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel6)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel8)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel13)
        Me.MetroTabPage2.Controls.Add(Me.Lraf)
        Me.MetroTabPage2.Controls.Add(Me.tweight)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel17)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage2.Controls.Add(Me.tlabnum)
        Me.MetroTabPage2.Controls.Add(Me.tscope)
        Me.MetroTabPage2.Controls.Add(Me.tlotref)
        Me.MetroTabPage2.Controls.Add(Me.Tnama)
        Me.MetroTabPage2.Controls.Add(Me.tnomnl)
        Me.MetroTabPage2.Controls.Add(Me.BunifuSeparator2)
        Me.MetroTabPage2.Controls.Add(Me.tSearchReturn)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel4)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel12)
        Me.MetroTabPage2.Controls.Add(Me.Lfarmer)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel1)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel11)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel9)
        Me.MetroTabPage2.Controls.Add(Me.Lreqnum)
        Me.MetroTabPage2.Controls.Add(Me.tVariety)
        Me.MetroTabPage2.Controls.Add(Me.BtnSave)
        Me.MetroTabPage2.Controls.Add(Me.tharvest)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel5)
        Me.MetroTabPage2.Controls.Add(Me.Tremark)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel3)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel10)
        Me.MetroTabPage2.Controls.Add(Me.BtnCariLab)
        Me.MetroTabPage2.Controls.Add(Me.Ltgl_update)
        Me.MetroTabPage2.Controls.Add(Me.Labelupdate)
        Me.MetroTabPage2.Controls.Add(Me.LLocation)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(991, 507)
        Me.MetroTabPage2.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Sample Rertrun Farmer"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'CboxParameterCari
        '
        Me.CboxParameterCari.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.CboxParameterCari.FormattingEnabled = True
        Me.CboxParameterCari.ItemHeight = 19
        Me.CboxParameterCari.Items.AddRange(New Object() {"Labnum", "Production Code"})
        Me.CboxParameterCari.Location = New System.Drawing.Point(3, 66)
        Me.CboxParameterCari.Name = "CboxParameterCari"
        Me.CboxParameterCari.Size = New System.Drawing.Size(131, 25)
        Me.CboxParameterCari.TabIndex = 317
        Me.CboxParameterCari.UseSelectable = True
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MetroLabel14.Location = New System.Drawing.Point(3, 294)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(226, 19)
        Me.MetroLabel14.TabIndex = 316
        Me.MetroLabel14.Text = "Data Sample Raw Material Tolak"
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.MetroGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroGrid1.AutoGenerateColumns = False
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdhvsprodDataGridViewTextBoxColumn, Me.LabnumDataGridViewTextBoxColumn, Me.VarietyDataGridViewTextBoxColumn, Me.FarmerDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.HarvestDataGridViewTextBoxColumn, Me.NomnlDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.request_date, Me.OfficerDataGridViewTextBoxColumn, Me.RemarkDataGridViewTextBoxColumn, Me.TglDataGridViewTextBoxColumn})
        Me.MetroGrid1.DataSource = Me.ReportsampelambilBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(3, 316)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(985, 188)
        Me.MetroGrid1.TabIndex = 315
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID Reqest"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Width = 90
        '
        'IdhvsprodDataGridViewTextBoxColumn
        '
        Me.IdhvsprodDataGridViewTextBoxColumn.DataPropertyName = "id_hvsprod"
        Me.IdhvsprodDataGridViewTextBoxColumn.HeaderText = "Production Code"
        Me.IdhvsprodDataGridViewTextBoxColumn.Name = "IdhvsprodDataGridViewTextBoxColumn"
        Me.IdhvsprodDataGridViewTextBoxColumn.Width = 90
        '
        'LabnumDataGridViewTextBoxColumn
        '
        Me.LabnumDataGridViewTextBoxColumn.DataPropertyName = "labnum"
        Me.LabnumDataGridViewTextBoxColumn.HeaderText = "Lab Number"
        Me.LabnumDataGridViewTextBoxColumn.Name = "LabnumDataGridViewTextBoxColumn"
        '
        'VarietyDataGridViewTextBoxColumn
        '
        Me.VarietyDataGridViewTextBoxColumn.DataPropertyName = "variety"
        Me.VarietyDataGridViewTextBoxColumn.HeaderText = "Variety"
        Me.VarietyDataGridViewTextBoxColumn.Name = "VarietyDataGridViewTextBoxColumn"
        Me.VarietyDataGridViewTextBoxColumn.Width = 80
        '
        'FarmerDataGridViewTextBoxColumn
        '
        Me.FarmerDataGridViewTextBoxColumn.DataPropertyName = "farmer"
        Me.FarmerDataGridViewTextBoxColumn.HeaderText = "Farmer"
        Me.FarmerDataGridViewTextBoxColumn.Name = "FarmerDataGridViewTextBoxColumn"
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        '
        'HarvestDataGridViewTextBoxColumn
        '
        Me.HarvestDataGridViewTextBoxColumn.DataPropertyName = "harvest"
        Me.HarvestDataGridViewTextBoxColumn.HeaderText = "Harvest"
        Me.HarvestDataGridViewTextBoxColumn.Name = "HarvestDataGridViewTextBoxColumn"
        '
        'NomnlDataGridViewTextBoxColumn
        '
        Me.NomnlDataGridViewTextBoxColumn.DataPropertyName = "nomnl"
        Me.NomnlDataGridViewTextBoxColumn.HeaderText = "Manual"
        Me.NomnlDataGridViewTextBoxColumn.Name = "NomnlDataGridViewTextBoxColumn"
        Me.NomnlDataGridViewTextBoxColumn.Width = 75
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "Weight (kg)"
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        Me.WeightDataGridViewTextBoxColumn.Width = 80
        '
        'request_date
        '
        Me.request_date.DataPropertyName = "request_date"
        Me.request_date.HeaderText = "SRequest date"
        Me.request_date.Name = "request_date"
        '
        'OfficerDataGridViewTextBoxColumn
        '
        Me.OfficerDataGridViewTextBoxColumn.DataPropertyName = "officer"
        Me.OfficerDataGridViewTextBoxColumn.HeaderText = "Taken by"
        Me.OfficerDataGridViewTextBoxColumn.Name = "OfficerDataGridViewTextBoxColumn"
        '
        'RemarkDataGridViewTextBoxColumn
        '
        Me.RemarkDataGridViewTextBoxColumn.DataPropertyName = "remark"
        Me.RemarkDataGridViewTextBoxColumn.HeaderText = "Remark"
        Me.RemarkDataGridViewTextBoxColumn.Name = "RemarkDataGridViewTextBoxColumn"
        '
        'TglDataGridViewTextBoxColumn
        '
        Me.TglDataGridViewTextBoxColumn.DataPropertyName = "tgl"
        Me.TglDataGridViewTextBoxColumn.HeaderText = "Taken Date"
        Me.TglDataGridViewTextBoxColumn.Name = "TglDataGridViewTextBoxColumn"
        '
        'ReportsampelambilBindingSource
        '
        Me.ReportsampelambilBindingSource.DataMember = "report_sampel_ambil"
        Me.ReportsampelambilBindingSource.DataSource = Me.HCQC_NewDataset
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.BackColor = System.Drawing.SystemColors.Control
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel7.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel7.Location = New System.Drawing.Point(3, 11)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(330, 19)
        Me.MetroLabel7.TabIndex = 301
        Me.MetroLabel7.Text = "Form untuk pengembalian sample terTolak ke petani"
        Me.MetroLabel7.UseCustomForeColor = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel6.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel6.Location = New System.Drawing.Point(532, 202)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(64, 15)
        Me.MetroLabel6.TabIndex = 285
        Me.MetroLabel6.Text = "Weight (kg)"
        Me.MetroLabel6.UseCustomForeColor = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MetroLabel8.Location = New System.Drawing.Point(3, 40)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel8.TabIndex = 303
        Me.MetroLabel8.Text = "Input Data"
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel13.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel13.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel13.Location = New System.Drawing.Point(532, 109)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(49, 15)
        Me.MetroLabel13.TabIndex = 308
        Me.MetroLabel13.Text = "Location"
        Me.MetroLabel13.UseCustomForeColor = True
        '
        'Lraf
        '
        Me.Lraf.AutoSize = True
        Me.Lraf.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Lraf.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Lraf.ForeColor = System.Drawing.Color.Black
        Me.Lraf.Location = New System.Drawing.Point(664, 81)
        Me.Lraf.Name = "Lraf"
        Me.Lraf.Size = New System.Drawing.Size(16, 15)
        Me.Lraf.TabIndex = 310
        Me.Lraf.Text = "..."
        Me.Lraf.UseCustomForeColor = True
        '
        'tweight
        '
        Me.tweight.AutoSize = True
        Me.tweight.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.tweight.ForeColor = System.Drawing.Color.White
        Me.tweight.Location = New System.Drawing.Point(532, 217)
        Me.tweight.Name = "tweight"
        Me.tweight.Size = New System.Drawing.Size(21, 19)
        Me.tweight.TabIndex = 284
        Me.tweight.Text = "..."
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MetroLabel17.Location = New System.Drawing.Point(369, 40)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(142, 19)
        Me.MetroLabel17.TabIndex = 292
        Me.MetroLabel17.Text = "Sample Information"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel2.Location = New System.Drawing.Point(369, 109)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(40, 15)
        Me.MetroLabel2.TabIndex = 283
        Me.MetroLabel2.Text = "Variety"
        Me.MetroLabel2.UseCustomForeColor = True
        '
        'tlabnum
        '
        '
        '
        '
        Me.tlabnum.CustomButton.Image = Nothing
        Me.tlabnum.CustomButton.Location = New System.Drawing.Point(106, 1)
        Me.tlabnum.CustomButton.Name = ""
        Me.tlabnum.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tlabnum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tlabnum.CustomButton.TabIndex = 1
        Me.tlabnum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tlabnum.CustomButton.UseSelectable = True
        Me.tlabnum.CustomButton.Visible = False
        Me.tlabnum.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.tlabnum.ForeColor = System.Drawing.Color.Black
        Me.tlabnum.Lines = New String(-1) {}
        Me.tlabnum.Location = New System.Drawing.Point(140, 66)
        Me.tlabnum.MaxLength = 32767
        Me.tlabnum.Name = "tlabnum"
        Me.tlabnum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tlabnum.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tlabnum.SelectedText = ""
        Me.tlabnum.SelectionLength = 0
        Me.tlabnum.SelectionStart = 0
        Me.tlabnum.ShortcutsEnabled = True
        Me.tlabnum.Size = New System.Drawing.Size(128, 23)
        Me.tlabnum.TabIndex = 300
        Me.tlabnum.UseCustomForeColor = True
        Me.tlabnum.UseSelectable = True
        Me.tlabnum.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tlabnum.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tscope
        '
        Me.tscope.AutoSize = True
        Me.tscope.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.tscope.ForeColor = System.Drawing.Color.White
        Me.tscope.Location = New System.Drawing.Point(369, 81)
        Me.tscope.Name = "tscope"
        Me.tscope.Size = New System.Drawing.Size(21, 19)
        Me.tscope.TabIndex = 279
        Me.tscope.Text = "..."
        '
        'tlotref
        '
        Me.tlotref.AutoSize = True
        Me.tlotref.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.tlotref.ForeColor = System.Drawing.Color.White
        Me.tlotref.Location = New System.Drawing.Point(418, 167)
        Me.tlotref.Name = "tlotref"
        Me.tlotref.Size = New System.Drawing.Size(21, 19)
        Me.tlotref.TabIndex = 286
        Me.tlotref.Text = "..."
        '
        'Tnama
        '
        '
        '
        '
        Me.Tnama.CustomButton.Image = Nothing
        Me.Tnama.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.Tnama.CustomButton.Name = ""
        Me.Tnama.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.Tnama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Tnama.CustomButton.TabIndex = 1
        Me.Tnama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Tnama.CustomButton.UseSelectable = True
        Me.Tnama.CustomButton.Visible = False
        Me.Tnama.Lines = New String(-1) {}
        Me.Tnama.Location = New System.Drawing.Point(94, 131)
        Me.Tnama.MaxLength = 32767
        Me.Tnama.Name = "Tnama"
        Me.Tnama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Tnama.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Tnama.SelectedText = ""
        Me.Tnama.SelectionLength = 0
        Me.Tnama.SelectionStart = 0
        Me.Tnama.ShortcutsEnabled = True
        Me.Tnama.Size = New System.Drawing.Size(174, 23)
        Me.Tnama.TabIndex = 293
        Me.Tnama.UseSelectable = True
        Me.Tnama.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Tnama.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tnomnl
        '
        Me.tnomnl.AutoSize = True
        Me.tnomnl.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.tnomnl.ForeColor = System.Drawing.Color.White
        Me.tnomnl.Location = New System.Drawing.Point(369, 167)
        Me.tnomnl.Name = "tnomnl"
        Me.tnomnl.Size = New System.Drawing.Size(21, 19)
        Me.tnomnl.TabIndex = 287
        Me.tnomnl.Text = "..."
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(350, 40)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(13, 219)
        Me.BunifuSeparator2.TabIndex = 302
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = True
        '
        'tSearchReturn
        '
        Me.tSearchReturn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tSearchReturn.CustomButton.Image = Global.WindowsApplication1.My.Resources.Resources.Find
        Me.tSearchReturn.CustomButton.Location = New System.Drawing.Point(224, 1)
        Me.tSearchReturn.CustomButton.Name = ""
        Me.tSearchReturn.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tSearchReturn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tSearchReturn.CustomButton.TabIndex = 1
        Me.tSearchReturn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tSearchReturn.CustomButton.UseSelectable = True
        Me.tSearchReturn.ForeColor = System.Drawing.Color.Black
        Me.tSearchReturn.Lines = New String(-1) {}
        Me.tSearchReturn.Location = New System.Drawing.Point(742, 287)
        Me.tSearchReturn.MaxLength = 32767
        Me.tSearchReturn.Name = "tSearchReturn"
        Me.tSearchReturn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tSearchReturn.PromptText = "Search..."
        Me.tSearchReturn.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tSearchReturn.SelectedText = ""
        Me.tSearchReturn.SelectionLength = 0
        Me.tSearchReturn.SelectionStart = 0
        Me.tSearchReturn.ShortcutsEnabled = True
        Me.tSearchReturn.ShowButton = True
        Me.tSearchReturn.ShowClearButton = True
        Me.tSearchReturn.Size = New System.Drawing.Size(246, 23)
        Me.tSearchReturn.TabIndex = 313
        Me.tSearchReturn.UseCustomForeColor = True
        Me.tSearchReturn.UseSelectable = True
        Me.tSearchReturn.WaterMark = "Search..."
        Me.tSearchReturn.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tSearchReturn.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(29, 135)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel4.TabIndex = 294
        Me.MetroLabel4.Text = "Taken by"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel12.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel12.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel12.Location = New System.Drawing.Point(532, 66)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(42, 15)
        Me.MetroLabel12.TabIndex = 307
        Me.MetroLabel12.Text = "Farmer"
        Me.MetroLabel12.UseCustomForeColor = True
        '
        'Lfarmer
        '
        Me.Lfarmer.AutoSize = True
        Me.Lfarmer.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Lfarmer.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Lfarmer.ForeColor = System.Drawing.Color.Black
        Me.Lfarmer.Location = New System.Drawing.Point(532, 81)
        Me.Lfarmer.Name = "Lfarmer"
        Me.Lfarmer.Size = New System.Drawing.Size(16, 15)
        Me.Lfarmer.TabIndex = 304
        Me.Lfarmer.Text = "..."
        Me.Lfarmer.UseCustomForeColor = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(34, 160)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(54, 19)
        Me.MetroLabel1.TabIndex = 296
        Me.MetroLabel1.Text = "Remark"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel11.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel11.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel11.Location = New System.Drawing.Point(664, 66)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(67, 15)
        Me.MetroLabel11.TabIndex = 311
        Me.MetroLabel11.Text = "Hasil Rafaksi"
        Me.MetroLabel11.UseCustomForeColor = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel9.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel9.Location = New System.Drawing.Point(369, 202)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(93, 15)
        Me.MetroLabel9.TabIndex = 291
        Me.MetroLabel9.Text = "Request Number"
        Me.MetroLabel9.UseCustomForeColor = True
        '
        'Lreqnum
        '
        Me.Lreqnum.AutoSize = True
        Me.Lreqnum.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Lreqnum.ForeColor = System.Drawing.Color.White
        Me.Lreqnum.Location = New System.Drawing.Point(369, 217)
        Me.Lreqnum.Name = "Lreqnum"
        Me.Lreqnum.Size = New System.Drawing.Size(21, 19)
        Me.Lreqnum.TabIndex = 289
        Me.Lreqnum.Text = "..."
        '
        'tVariety
        '
        Me.tVariety.AutoSize = True
        Me.tVariety.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.tVariety.ForeColor = System.Drawing.Color.White
        Me.tVariety.Location = New System.Drawing.Point(369, 124)
        Me.tVariety.Name = "tVariety"
        Me.tVariety.Size = New System.Drawing.Size(21, 19)
        Me.tVariety.TabIndex = 282
        Me.tVariety.Text = "..."
        '
        'BtnSave
        '
        Me.BtnSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.BorderRadius = 0
        Me.BtnSave.ButtonText = "Save"
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.DisabledColor = System.Drawing.Color.Gray
        Me.BtnSave.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnSave.Iconimage = CType(resources.GetObject("BtnSave.Iconimage"), System.Drawing.Image)
        Me.BtnSave.Iconimage_right = Nothing
        Me.BtnSave.Iconimage_right_Selected = Nothing
        Me.BtnSave.Iconimage_Selected = Nothing
        Me.BtnSave.IconMarginLeft = 0
        Me.BtnSave.IconMarginRight = 0
        Me.BtnSave.IconRightVisible = False
        Me.BtnSave.IconRightZoom = 0R
        Me.BtnSave.IconVisible = False
        Me.BtnSave.IconZoom = 90.0R
        Me.BtnSave.IsTab = False
        Me.BtnSave.Location = New System.Drawing.Point(94, 212)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSave.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnSave.selected = False
        Me.BtnSave.Size = New System.Drawing.Size(174, 34)
        Me.BtnSave.TabIndex = 297
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Textcolor = System.Drawing.Color.White
        Me.BtnSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tharvest
        '
        Me.tharvest.AutoSize = True
        Me.tharvest.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.tharvest.ForeColor = System.Drawing.Color.White
        Me.tharvest.Location = New System.Drawing.Point(532, 171)
        Me.tharvest.Name = "tharvest"
        Me.tharvest.Size = New System.Drawing.Size(21, 19)
        Me.tharvest.TabIndex = 280
        Me.tharvest.Text = "..."
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel5.Location = New System.Drawing.Point(532, 156)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(73, 15)
        Me.MetroLabel5.TabIndex = 281
        Me.MetroLabel5.Text = "Harvest Date"
        Me.MetroLabel5.UseCustomForeColor = True
        '
        'Tremark
        '
        '
        '
        '
        Me.Tremark.CustomButton.Image = Nothing
        Me.Tremark.CustomButton.Location = New System.Drawing.Point(130, 2)
        Me.Tremark.CustomButton.Name = ""
        Me.Tremark.CustomButton.Size = New System.Drawing.Size(41, 41)
        Me.Tremark.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Tremark.CustomButton.TabIndex = 1
        Me.Tremark.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Tremark.CustomButton.UseSelectable = True
        Me.Tremark.CustomButton.Visible = False
        Me.Tremark.Lines = New String(-1) {}
        Me.Tremark.Location = New System.Drawing.Point(94, 160)
        Me.Tremark.MaxLength = 32767
        Me.Tremark.Multiline = True
        Me.Tremark.Name = "Tremark"
        Me.Tremark.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Tremark.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Tremark.SelectedText = ""
        Me.Tremark.SelectionLength = 0
        Me.Tremark.SelectionStart = 0
        Me.Tremark.ShortcutsEnabled = True
        Me.Tremark.Size = New System.Drawing.Size(174, 46)
        Me.Tremark.TabIndex = 295
        Me.Tremark.UseSelectable = True
        Me.Tremark.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Tremark.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel3.Location = New System.Drawing.Point(369, 152)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(93, 15)
        Me.MetroLabel3.TabIndex = 288
        Me.MetroLabel3.Text = "Manual    Lot/Job"
        Me.MetroLabel3.UseCustomForeColor = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel10.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel10.Location = New System.Drawing.Point(369, 66)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(38, 15)
        Me.MetroLabel10.TabIndex = 290
        Me.MetroLabel10.Text = "Scope"
        Me.MetroLabel10.UseCustomForeColor = True
        '
        'BtnCariLab
        '
        Me.BtnCariLab.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnCariLab.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnCariLab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCariLab.BorderRadius = 0
        Me.BtnCariLab.ButtonText = "Cari"
        Me.BtnCariLab.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCariLab.DisabledColor = System.Drawing.Color.Gray
        Me.BtnCariLab.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnCariLab.Iconimage = Nothing
        Me.BtnCariLab.Iconimage_right = Nothing
        Me.BtnCariLab.Iconimage_right_Selected = Nothing
        Me.BtnCariLab.Iconimage_Selected = Nothing
        Me.BtnCariLab.IconMarginLeft = 5
        Me.BtnCariLab.IconMarginRight = 0
        Me.BtnCariLab.IconRightVisible = False
        Me.BtnCariLab.IconRightZoom = 0R
        Me.BtnCariLab.IconVisible = False
        Me.BtnCariLab.IconZoom = 150.0R
        Me.BtnCariLab.IsTab = False
        Me.BtnCariLab.Location = New System.Drawing.Point(274, 66)
        Me.BtnCariLab.Name = "BtnCariLab"
        Me.BtnCariLab.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnCariLab.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCariLab.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnCariLab.selected = False
        Me.BtnCariLab.Size = New System.Drawing.Size(45, 23)
        Me.BtnCariLab.TabIndex = 298
        Me.BtnCariLab.TabStop = False
        Me.BtnCariLab.Text = "Cari"
        Me.BtnCariLab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCariLab.Textcolor = System.Drawing.Color.White
        Me.BtnCariLab.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Ltgl_update
        '
        Me.Ltgl_update.AutoSize = True
        Me.Ltgl_update.Location = New System.Drawing.Point(140, 105)
        Me.Ltgl_update.Name = "Ltgl_update"
        Me.Ltgl_update.Size = New System.Drawing.Size(18, 19)
        Me.Ltgl_update.TabIndex = 312
        Me.Ltgl_update.Text = "..."
        Me.Ltgl_update.Visible = False
        '
        'Labelupdate
        '
        Me.Labelupdate.AutoSize = True
        Me.Labelupdate.Location = New System.Drawing.Point(3, 105)
        Me.Labelupdate.Name = "Labelupdate"
        Me.Labelupdate.Size = New System.Drawing.Size(131, 19)
        Me.Labelupdate.TabIndex = 294
        Me.Labelupdate.Text = "Pernah diambil pada"
        Me.Labelupdate.Visible = False
        '
        'LLocation
        '
        Me.LLocation.AutoSize = True
        Me.LLocation.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LLocation.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LLocation.ForeColor = System.Drawing.Color.Black
        Me.LLocation.Location = New System.Drawing.Point(532, 124)
        Me.LLocation.Name = "LLocation"
        Me.LLocation.Size = New System.Drawing.Size(16, 15)
        Me.LLocation.TabIndex = 305
        Me.LLocation.Text = "..."
        Me.LLocation.UseCustomForeColor = True
        '
        'Report_status_pengujianTableAdapter
        '
        Me.Report_status_pengujianTableAdapter.ClearBeforeFill = True
        '
        'Report_sampel_ambilTableAdapter
        '
        Me.Report_sampel_ambilTableAdapter.ClearBeforeFill = True
        '
        'Sample_Tracking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Name = "Sample_Tracking"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(1005, 555)
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        CType(Me.BtnFilterDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportstatuspengujianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportsampelambilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LInkRefresh As MetroLink
    Friend WithEvents MetroStyleExtender1 As Components.MetroStyleExtender
    Friend WithEvents MetroStyleManager1 As Components.MetroStyleManager
    Friend WithEvents MetroTabControl1 As MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroTabPage
    Friend WithEvents LinkLastMonth1 As MetroLink
    Friend WithEvents LinkThisMonth1 As MetroLink
    Friend WithEvents MetroLabel17 As MetroLabel
    Friend WithEvents Lreqnum As MetroLabel
    Friend WithEvents MetroLabel10 As MetroLabel
    Friend WithEvents MetroLabel9 As MetroLabel
    Friend WithEvents tweight As MetroLabel
    Friend WithEvents MetroLabel6 As MetroLabel
    Friend WithEvents tscope As MetroLabel
    Friend WithEvents tharvest As MetroLabel
    Friend WithEvents MetroLabel5 As MetroLabel
    Friend WithEvents tlotref As MetroLabel
    Friend WithEvents tnomnl As MetroLabel
    Friend WithEvents MetroLabel3 As MetroLabel
    Friend WithEvents tVariety As MetroLabel
    Friend WithEvents MetroLabel2 As MetroLabel
    Friend WithEvents BtnSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Tremark As MetroTextBox
    Friend WithEvents Tnama As MetroTextBox
    Friend WithEvents MetroLabel1 As MetroLabel
    Friend WithEvents MetroLabel4 As MetroLabel
    Friend WithEvents BtnCariLab As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents tlabnum As MetroTextBox
    Friend WithEvents MetroLabel7 As MetroLabel
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents MetroLabel8 As MetroLabel
    Friend WithEvents MetroLabel11 As MetroLabel
    Friend WithEvents Lraf As MetroLabel
    Friend WithEvents Lfarmer As MetroLabel
    Friend WithEvents LLocation As MetroLabel
    Friend WithEvents MetroLabel12 As MetroLabel
    Friend WithEvents MetroLabel13 As MetroLabel
    Friend WithEvents Ltgl_update As MetroLabel
    Friend WithEvents Labelupdate As MetroLabel
    Friend WithEvents tSearchReturn As MetroTextBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collabnum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colid_hvsprod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvariety As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnomnl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnojob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colweight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfarmer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colharvest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colscope As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltest_sampling As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltest_moi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltest_pur As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltest_ger As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltest_via As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltest_raf As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltest_ontest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colinput_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceipt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbrt_in As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceipt_Input As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsampler As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsampling As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRaf_Test As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRaf_Result As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRaf_Analys As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRaf_input As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMoi_Test As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMoi_Analys As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMoi_input As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGer_TestLog As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGer_Test As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGer_1st As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGer_1st_Est As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGer_2nd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGer_2nd_Est As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGer_Analys As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGer_input As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVia_Test As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVia_Analys As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVia_input As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPur_Test As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPur_Analys As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPur_input As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuick_Raf As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRetunQC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReturnQC_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatusResult As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldays_est As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReportstatuspengujianBindingSource As BindingSource
    Friend WithEvents HCQC_NewDataset As HCQC_NewDataset
    Friend WithEvents Report_status_pengujianTableAdapter As HCQC_NewDatasetTableAdapters.report_status_pengujianTableAdapter
    Friend WithEvents colstatus_confirm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MetroGrid1 As MetroGrid
    Friend WithEvents ReportsampelambilBindingSource As BindingSource
    Friend WithEvents Report_sampel_ambilTableAdapter As HCQC_NewDatasetTableAdapters.report_sampel_ambilTableAdapter
    Friend WithEvents MetroLabel14 As MetroLabel
    Friend WithEvents coldate_est As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmoisture_log As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpurity_log As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colrafaction_log As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colviability_log As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgerout_log As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmoisture_namelog As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpurity_namelog As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colrafaction_namelog As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colviability_namelog As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgertest_namelog As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgerout_namelog As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CboxParameterCari As MetroComboBox
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdhvsprodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabnumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarietyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FarmerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HarvestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomnlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents request_date As DataGridViewTextBoxColumn
    Friend WithEvents OfficerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemarkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TglDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents colgervigor_log As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgervigor_namelog As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MetroLink1 As MetroLink
    Friend WithEvents MetroLink2 As MetroLink
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents colaccept_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MetroLabel18 As MetroLabel
    Friend WithEvents MetroLabel16 As MetroLabel
    Friend WithEvents MetroLabel15 As MetroLabel
    Friend WithEvents EndDate As DateTimePicker
    Friend WithEvents StartDate As DateTimePicker
    Friend WithEvents MetroLabel19 As MetroLabel
    Friend WithEvents BtnFilterDate As Bunifu.Framework.UI.BunifuImageButton
End Class
