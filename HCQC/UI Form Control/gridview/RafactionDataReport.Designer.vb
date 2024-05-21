<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RafactionDataReport
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RafactionDataReport))
        Me.Tsearch = New MetroFramework.Controls.MetroTextBox()
        Me.LinkRefresh = New MetroFramework.Controls.MetroLink()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdbalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarietyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FarmerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HarvestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomnlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NojobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScopeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequestdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResultDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DttDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CvlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnalysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RafactionviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_NewDataset = New WindowsApplication1.HCQC_NewDataset()
        Me.Rafaction_viewTableAdapter = New WindowsApplication1.HCQC_NewDatasetTableAdapters.rafaction_viewTableAdapter()
        Me.BtnFilterDate = New Bunifu.Framework.UI.BunifuImageButton()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.EndDate = New System.Windows.Forms.DateTimePicker()
        Me.StartDate = New System.Windows.Forms.DateTimePicker()
        Me.LinkLastYear = New MetroFramework.Controls.MetroLink()
        Me.LinkThisYear = New MetroFramework.Controls.MetroLink()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RafactionviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFilterDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Tsearch.Location = New System.Drawing.Point(587, 72)
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
        Me.Tsearch.TabIndex = 157
        Me.Tsearch.UseSelectable = True
        Me.Tsearch.WaterMark = "Search..."
        Me.Tsearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Tsearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'LinkRefresh
        '
        Me.LinkRefresh.AutoSize = True
        Me.LinkRefresh.BackColor = System.Drawing.Color.Transparent
        Me.LinkRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkRefresh.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.LinkRefresh.Image = Global.WindowsApplication1.My.Resources.Resources.appbar_refresh
        Me.LinkRefresh.Location = New System.Drawing.Point(23, 72)
        Me.LinkRefresh.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkRefresh.Name = "LinkRefresh"
        Me.LinkRefresh.Size = New System.Drawing.Size(64, 23)
        Me.LinkRefresh.TabIndex = 156
        Me.LinkRefresh.Text = "Refresh"
        Me.LinkRefresh.UseCustomBackColor = True
        Me.LinkRefresh.UseSelectable = True
        Me.LinkRefresh.UseStyleColors = True
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroGrid1.AutoGenerateColumns = False
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.LabnumDataGridViewTextBoxColumn, Me.IdbalanceDataGridViewTextBoxColumn, Me.VarietyDataGridViewTextBoxColumn, Me.FarmerDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.HarvestDataGridViewTextBoxColumn, Me.NomnlDataGridViewTextBoxColumn, Me.NojobDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.ScopeDataGridViewTextBoxColumn, Me.RequestdateDataGridViewTextBoxColumn, Me.ResultDataGridViewTextBoxColumn, Me.DttDataGridViewTextBoxColumn, Me.WsDataGridViewTextBoxColumn, Me.PsDataGridViewTextBoxColumn, Me.YgDataGridViewTextBoxColumn, Me.UsDataGridViewTextBoxColumn, Me.RtDataGridViewTextBoxColumn, Me.IndDataGridViewTextBoxColumn, Me.BrDataGridViewTextBoxColumn, Me.OdDataGridViewTextBoxColumn, Me.GrDataGridViewTextBoxColumn, Me.FgDataGridViewTextBoxColumn, Me.ImDataGridViewTextBoxColumn, Me.CrDataGridViewTextBoxColumn, Me.CvlDataGridViewTextBoxColumn, Me.KetDataGridViewTextBoxColumn, Me.AnalysDataGridViewTextBoxColumn, Me.RemarkDataGridViewTextBoxColumn})
        Me.MetroGrid1.DataSource = Me.RafactionviewBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(23, 101)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(754, 326)
        Me.MetroGrid1.TabIndex = 160
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'LabnumDataGridViewTextBoxColumn
        '
        Me.LabnumDataGridViewTextBoxColumn.DataPropertyName = "labnum"
        Me.LabnumDataGridViewTextBoxColumn.HeaderText = "Labnum"
        Me.LabnumDataGridViewTextBoxColumn.Name = "LabnumDataGridViewTextBoxColumn"
        '
        'IdbalanceDataGridViewTextBoxColumn
        '
        Me.IdbalanceDataGridViewTextBoxColumn.DataPropertyName = "idbalance"
        Me.IdbalanceDataGridViewTextBoxColumn.HeaderText = "ID Balance"
        Me.IdbalanceDataGridViewTextBoxColumn.Name = "IdbalanceDataGridViewTextBoxColumn"
        '
        'VarietyDataGridViewTextBoxColumn
        '
        Me.VarietyDataGridViewTextBoxColumn.DataPropertyName = "variety"
        Me.VarietyDataGridViewTextBoxColumn.HeaderText = "Variety"
        Me.VarietyDataGridViewTextBoxColumn.Name = "VarietyDataGridViewTextBoxColumn"
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
        Me.NomnlDataGridViewTextBoxColumn.HeaderText = "Nomnl"
        Me.NomnlDataGridViewTextBoxColumn.Name = "NomnlDataGridViewTextBoxColumn"
        '
        'NojobDataGridViewTextBoxColumn
        '
        Me.NojobDataGridViewTextBoxColumn.DataPropertyName = "nojob"
        Me.NojobDataGridViewTextBoxColumn.HeaderText = "No Job"
        Me.NojobDataGridViewTextBoxColumn.Name = "NojobDataGridViewTextBoxColumn"
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "Weight (kg)"
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        '
        'ScopeDataGridViewTextBoxColumn
        '
        Me.ScopeDataGridViewTextBoxColumn.DataPropertyName = "scope"
        Me.ScopeDataGridViewTextBoxColumn.HeaderText = "Scope"
        Me.ScopeDataGridViewTextBoxColumn.Name = "ScopeDataGridViewTextBoxColumn"
        '
        'RequestdateDataGridViewTextBoxColumn
        '
        Me.RequestdateDataGridViewTextBoxColumn.DataPropertyName = "request_date"
        Me.RequestdateDataGridViewTextBoxColumn.HeaderText = "Request Date"
        Me.RequestdateDataGridViewTextBoxColumn.Name = "RequestdateDataGridViewTextBoxColumn"
        '
        'ResultDataGridViewTextBoxColumn
        '
        Me.ResultDataGridViewTextBoxColumn.DataPropertyName = "result"
        Me.ResultDataGridViewTextBoxColumn.HeaderText = "Result"
        Me.ResultDataGridViewTextBoxColumn.Name = "ResultDataGridViewTextBoxColumn"
        Me.ResultDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DttDataGridViewTextBoxColumn
        '
        Me.DttDataGridViewTextBoxColumn.DataPropertyName = "dt_t"
        Me.DttDataGridViewTextBoxColumn.HeaderText = "Test Date"
        Me.DttDataGridViewTextBoxColumn.Name = "DttDataGridViewTextBoxColumn"
        '
        'WsDataGridViewTextBoxColumn
        '
        Me.WsDataGridViewTextBoxColumn.DataPropertyName = "ws"
        Me.WsDataGridViewTextBoxColumn.HeaderText = "Work S (g)"
        Me.WsDataGridViewTextBoxColumn.Name = "WsDataGridViewTextBoxColumn"
        '
        'PsDataGridViewTextBoxColumn
        '
        Me.PsDataGridViewTextBoxColumn.DataPropertyName = "ps"
        Me.PsDataGridViewTextBoxColumn.HeaderText = "Pale (g)"
        Me.PsDataGridViewTextBoxColumn.Name = "PsDataGridViewTextBoxColumn"
        '
        'YgDataGridViewTextBoxColumn
        '
        Me.YgDataGridViewTextBoxColumn.DataPropertyName = "yg"
        Me.YgDataGridViewTextBoxColumn.HeaderText = "Young (g)"
        Me.YgDataGridViewTextBoxColumn.Name = "YgDataGridViewTextBoxColumn"
        '
        'UsDataGridViewTextBoxColumn
        '
        Me.UsDataGridViewTextBoxColumn.DataPropertyName = "us"
        Me.UsDataGridViewTextBoxColumn.HeaderText = "Under Size (g)"
        Me.UsDataGridViewTextBoxColumn.Name = "UsDataGridViewTextBoxColumn"
        '
        'RtDataGridViewTextBoxColumn
        '
        Me.RtDataGridViewTextBoxColumn.DataPropertyName = "rt"
        Me.RtDataGridViewTextBoxColumn.HeaderText = "Rotten (g)"
        Me.RtDataGridViewTextBoxColumn.Name = "RtDataGridViewTextBoxColumn"
        '
        'IndDataGridViewTextBoxColumn
        '
        Me.IndDataGridViewTextBoxColumn.DataPropertyName = "Ind"
        Me.IndDataGridViewTextBoxColumn.HeaderText = "Insect Damage (g)"
        Me.IndDataGridViewTextBoxColumn.Name = "IndDataGridViewTextBoxColumn"
        '
        'BrDataGridViewTextBoxColumn
        '
        Me.BrDataGridViewTextBoxColumn.DataPropertyName = "br"
        Me.BrDataGridViewTextBoxColumn.HeaderText = "Broken (g)"
        Me.BrDataGridViewTextBoxColumn.Name = "BrDataGridViewTextBoxColumn"
        '
        'OdDataGridViewTextBoxColumn
        '
        Me.OdDataGridViewTextBoxColumn.DataPropertyName = "od"
        Me.OdDataGridViewTextBoxColumn.HeaderText = "Other Deterio (g)"
        Me.OdDataGridViewTextBoxColumn.Name = "OdDataGridViewTextBoxColumn"
        '
        'GrDataGridViewTextBoxColumn
        '
        Me.GrDataGridViewTextBoxColumn.DataPropertyName = "gr"
        Me.GrDataGridViewTextBoxColumn.HeaderText = "Growth (g)"
        Me.GrDataGridViewTextBoxColumn.Name = "GrDataGridViewTextBoxColumn"
        '
        'FgDataGridViewTextBoxColumn
        '
        Me.FgDataGridViewTextBoxColumn.DataPropertyName = "fg"
        Me.FgDataGridViewTextBoxColumn.HeaderText = "Fungi (g)"
        Me.FgDataGridViewTextBoxColumn.Name = "FgDataGridViewTextBoxColumn"
        '
        'ImDataGridViewTextBoxColumn
        '
        Me.ImDataGridViewTextBoxColumn.DataPropertyName = "im"
        Me.ImDataGridViewTextBoxColumn.HeaderText = "Innert Metter (g)"
        Me.ImDataGridViewTextBoxColumn.Name = "ImDataGridViewTextBoxColumn"
        '
        'CrDataGridViewTextBoxColumn
        '
        Me.CrDataGridViewTextBoxColumn.DataPropertyName = "cr"
        Me.CrDataGridViewTextBoxColumn.HeaderText = "Crack (g)"
        Me.CrDataGridViewTextBoxColumn.Name = "CrDataGridViewTextBoxColumn"
        '
        'CvlDataGridViewTextBoxColumn
        '
        Me.CvlDataGridViewTextBoxColumn.DataPropertyName = "cvl"
        Me.CvlDataGridViewTextBoxColumn.HeaderText = "CVL (g)"
        Me.CvlDataGridViewTextBoxColumn.Name = "CvlDataGridViewTextBoxColumn"
        '
        'KetDataGridViewTextBoxColumn
        '
        Me.KetDataGridViewTextBoxColumn.DataPropertyName = "ket"
        Me.KetDataGridViewTextBoxColumn.HeaderText = "Remark"
        Me.KetDataGridViewTextBoxColumn.Name = "KetDataGridViewTextBoxColumn"
        '
        'AnalysDataGridViewTextBoxColumn
        '
        Me.AnalysDataGridViewTextBoxColumn.DataPropertyName = "analys"
        Me.AnalysDataGridViewTextBoxColumn.HeaderText = "Analys"
        Me.AnalysDataGridViewTextBoxColumn.Name = "AnalysDataGridViewTextBoxColumn"
        '
        'RemarkDataGridViewTextBoxColumn
        '
        Me.RemarkDataGridViewTextBoxColumn.DataPropertyName = "remark"
        Me.RemarkDataGridViewTextBoxColumn.HeaderText = "Sample Note"
        Me.RemarkDataGridViewTextBoxColumn.Name = "RemarkDataGridViewTextBoxColumn"
        '
        'RafactionviewBindingSource
        '
        Me.RafactionviewBindingSource.DataMember = "rafaction_view"
        Me.RafactionviewBindingSource.DataSource = Me.HCQC_NewDataset
        '
        'HCQC_NewDataset
        '
        Me.HCQC_NewDataset.DataSetName = "HCQC_NewDataset"
        Me.HCQC_NewDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Rafaction_viewTableAdapter
        '
        Me.Rafaction_viewTableAdapter.ClearBeforeFill = True
        '
        'BtnFilterDate
        '
        Me.BtnFilterDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnFilterDate.Image = CType(resources.GetObject("BtnFilterDate.Image"), System.Drawing.Image)
        Me.BtnFilterDate.ImageActive = Nothing
        Me.BtnFilterDate.Location = New System.Drawing.Point(496, 75)
        Me.BtnFilterDate.Name = "BtnFilterDate"
        Me.BtnFilterDate.Size = New System.Drawing.Size(31, 20)
        Me.BtnFilterDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnFilterDate.TabIndex = 166
        Me.BtnFilterDate.TabStop = False
        Me.BtnFilterDate.Zoom = 10
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel18.Location = New System.Drawing.Point(366, 78)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(12, 15)
        Me.MetroLabel18.TabIndex = 165
        Me.MetroLabel18.Text = "-"
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel16.Location = New System.Drawing.Point(384, 57)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(53, 15)
        Me.MetroLabel16.TabIndex = 164
        Me.MetroLabel16.Text = "End Date"
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel15.Location = New System.Drawing.Point(254, 57)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(59, 15)
        Me.MetroLabel15.TabIndex = 163
        Me.MetroLabel15.Text = "Start Date"
        '
        'EndDate
        '
        Me.EndDate.CustomFormat = "dd-mmm-yyyy"
        Me.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EndDate.Location = New System.Drawing.Point(384, 75)
        Me.EndDate.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.EndDate.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(106, 20)
        Me.EndDate.TabIndex = 162
        Me.EndDate.Value = New Date(2024, 3, 15, 0, 0, 0, 0)
        '
        'StartDate
        '
        Me.StartDate.CustomFormat = "dd-mmm-yyyy"
        Me.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.StartDate.Location = New System.Drawing.Point(254, 75)
        Me.StartDate.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.StartDate.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(106, 20)
        Me.StartDate.TabIndex = 161
        Me.StartDate.Value = New Date(2024, 3, 15, 0, 0, 0, 0)
        '
        'LinkLastYear
        '
        Me.LinkLastYear.AutoSize = True
        Me.LinkLastYear.BackColor = System.Drawing.Color.Transparent
        Me.LinkLastYear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLastYear.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkLastYear.Location = New System.Drawing.Point(157, 72)
        Me.LinkLastYear.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkLastYear.Name = "LinkLastYear"
        Me.LinkLastYear.Size = New System.Drawing.Size(77, 23)
        Me.LinkLastYear.TabIndex = 167
        Me.LinkLastYear.Text = "Last Year"
        Me.LinkLastYear.UseCustomBackColor = True
        Me.LinkLastYear.UseSelectable = True
        Me.LinkLastYear.UseStyleColors = True
        '
        'LinkThisYear
        '
        Me.LinkThisYear.AutoSize = True
        Me.LinkThisYear.BackColor = System.Drawing.Color.Transparent
        Me.LinkThisYear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkThisYear.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkThisYear.Location = New System.Drawing.Point(87, 72)
        Me.LinkThisYear.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkThisYear.Name = "LinkThisYear"
        Me.LinkThisYear.Size = New System.Drawing.Size(70, 23)
        Me.LinkThisYear.TabIndex = 168
        Me.LinkThisYear.Text = "This Year"
        Me.LinkThisYear.UseCustomBackColor = True
        Me.LinkThisYear.UseSelectable = True
        Me.LinkThisYear.UseStyleColors = True
        '
        'RafactionDataReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LinkLastYear)
        Me.Controls.Add(Me.LinkThisYear)
        Me.Controls.Add(Me.BtnFilterDate)
        Me.Controls.Add(Me.MetroLabel18)
        Me.Controls.Add(Me.MetroLabel16)
        Me.Controls.Add(Me.MetroLabel15)
        Me.Controls.Add(Me.EndDate)
        Me.Controls.Add(Me.StartDate)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Controls.Add(Me.Tsearch)
        Me.Controls.Add(Me.LinkRefresh)
        Me.Name = "RafactionDataReport"
        Me.Text = "Rafaction Data Report"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RafactionviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFilterDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tsearch As MetroTextBox
    Friend WithEvents LinkRefresh As MetroLink
    Friend WithEvents MetroGrid1 As MetroGrid
    Friend WithEvents HCQC_NewDataset As HCQC_NewDataset
    Friend WithEvents RafactionviewBindingSource As BindingSource
    Friend WithEvents Rafaction_viewTableAdapter As HCQC_NewDatasetTableAdapters.rafaction_viewTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabnumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdbalanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarietyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FarmerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HarvestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomnlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NojobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScopeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RequestdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResultDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DttDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CvlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnalysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemarkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BtnFilterDate As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents MetroLabel18 As MetroLabel
    Friend WithEvents MetroLabel16 As MetroLabel
    Friend WithEvents MetroLabel15 As MetroLabel
    Friend WithEvents EndDate As DateTimePicker
    Friend WithEvents StartDate As DateTimePicker
    Friend WithEvents LinkLastYear As MetroLink
    Friend WithEvents LinkThisYear As MetroLink
End Class
