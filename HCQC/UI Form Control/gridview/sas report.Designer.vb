<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sas_report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sas_report))
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.ReportgravitysasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_serverDataSet = New HCQC_serverDataSet()
        Me.BtnRefresh = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnPrint = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Report_gravity_sasTableAdapter = New HCQC_serverDataSetTableAdapters.report_gravity_sasTableAdapter()
        Me.LabnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarietyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomnlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NojobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScopeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubstrateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScndcountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mois1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mois2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MeanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.ThseedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbnormalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HardDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FreshDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VgtglinputDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglprintDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportgravitysasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LabnumDataGridViewTextBoxColumn, Me.VarietyDataGridViewTextBoxColumn, Me.NomnlDataGridViewTextBoxColumn, Me.NojobDataGridViewTextBoxColumn, Me.ScopeDataGridViewTextBoxColumn, Me.SubstrateDataGridViewTextBoxColumn, Me.ScndcountDataGridViewTextBoxColumn, Me.Mois1DataGridViewTextBoxColumn, Me.Mois2DataGridViewTextBoxColumn, Me.MeanDataGridViewTextBoxColumn, Me.WsDataGridViewTextBoxColumn, Me.PureDataGridViewTextBoxColumn, Me.YgDataGridViewTextBoxColumn, Me.UsDataGridViewTextBoxColumn, Me.RtDataGridViewTextBoxColumn, Me.IndDataGridViewTextBoxColumn, Me.BrDataGridViewTextBoxColumn, Me.OdDataGridViewTextBoxColumn, Me.GrDataGridViewTextBoxColumn, Me.FgDataGridViewTextBoxColumn, Me.ImDataGridViewTextBoxColumn, Me.CrDataGridViewTextBoxColumn, Me.CvlDataGridViewTextBoxColumn, Me.ThseedDataGridViewTextBoxColumn, Me.DTDataGridViewTextBoxColumn, Me.AbnormalDataGridViewTextBoxColumn, Me.VGDataGridViewTextBoxColumn, Me.HardDataGridViewTextBoxColumn, Me.FreshDataGridViewTextBoxColumn, Me.DeadDataGridViewTextBoxColumn, Me.VgtglinputDataGridViewTextBoxColumn, Me.TglprintDataGridViewTextBoxColumn})
        Me.MetroGrid1.DataSource = Me.ReportgravitysasBindingSource
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
        Me.MetroGrid1.Location = New System.Drawing.Point(23, 99)
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
        Me.MetroGrid1.Size = New System.Drawing.Size(754, 328)
        Me.MetroGrid1.TabIndex = 0
        '
        'ReportgravitysasBindingSource
        '
        Me.ReportgravitysasBindingSource.DataMember = "report_gravity_sas"
        Me.ReportgravitysasBindingSource.DataSource = Me.HCQC_serverDataSet
        '
        'HCQC_serverDataSet
        '
        Me.HCQC_serverDataSet.DataSetName = "HCQC_serverDataSet"
        Me.HCQC_serverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRefresh.BorderRadius = 0
        Me.BtnRefresh.ButtonText = "Refresh"
        Me.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRefresh.DisabledColor = System.Drawing.Color.Gray
        Me.BtnRefresh.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnRefresh.Iconimage = CType(resources.GetObject("BtnRefresh.Iconimage"), System.Drawing.Image)
        Me.BtnRefresh.Iconimage_right = Nothing
        Me.BtnRefresh.Iconimage_right_Selected = Nothing
        Me.BtnRefresh.Iconimage_Selected = Nothing
        Me.BtnRefresh.IconMarginLeft = 0
        Me.BtnRefresh.IconMarginRight = 0
        Me.BtnRefresh.IconRightVisible = True
        Me.BtnRefresh.IconRightZoom = 0R
        Me.BtnRefresh.IconVisible = True
        Me.BtnRefresh.IconZoom = 50.0R
        Me.BtnRefresh.IsTab = False
        Me.BtnRefresh.Location = New System.Drawing.Point(23, 63)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnRefresh.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnRefresh.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnRefresh.selected = True
        Me.BtnRefresh.Size = New System.Drawing.Size(126, 30)
        Me.BtnRefresh.TabIndex = 4
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefresh.Textcolor = System.Drawing.Color.White
        Me.BtnRefresh.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnPrint
        '
        Me.BtnPrint.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrint.BorderRadius = 0
        Me.BtnPrint.ButtonText = "Print Check Out"
        Me.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrint.DisabledColor = System.Drawing.Color.Gray
        Me.BtnPrint.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnPrint.Iconimage = CType(resources.GetObject("BtnPrint.Iconimage"), System.Drawing.Image)
        Me.BtnPrint.Iconimage_right = Nothing
        Me.BtnPrint.Iconimage_right_Selected = Nothing
        Me.BtnPrint.Iconimage_Selected = Nothing
        Me.BtnPrint.IconMarginLeft = 0
        Me.BtnPrint.IconMarginRight = 0
        Me.BtnPrint.IconRightVisible = True
        Me.BtnPrint.IconRightZoom = 0R
        Me.BtnPrint.IconVisible = True
        Me.BtnPrint.IconZoom = 70.0R
        Me.BtnPrint.IsTab = False
        Me.BtnPrint.Location = New System.Drawing.Point(636, 63)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnPrint.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPrint.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnPrint.selected = True
        Me.BtnPrint.Size = New System.Drawing.Size(141, 30)
        Me.BtnPrint.TabIndex = 4
        Me.BtnPrint.Text = "Print Check Out"
        Me.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPrint.Textcolor = System.Drawing.Color.White
        Me.BtnPrint.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Report_gravity_sasTableAdapter
        '
        Me.Report_gravity_sasTableAdapter.ClearBeforeFill = True
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
        '
        'NomnlDataGridViewTextBoxColumn
        '
        Me.NomnlDataGridViewTextBoxColumn.DataPropertyName = "nomnl"
        Me.NomnlDataGridViewTextBoxColumn.HeaderText = "Manual Number"
        Me.NomnlDataGridViewTextBoxColumn.Name = "NomnlDataGridViewTextBoxColumn"
        '
        'NojobDataGridViewTextBoxColumn
        '
        Me.NojobDataGridViewTextBoxColumn.DataPropertyName = "nojob"
        Me.NojobDataGridViewTextBoxColumn.HeaderText = "Job Number"
        Me.NojobDataGridViewTextBoxColumn.Name = "NojobDataGridViewTextBoxColumn"
        '
        'ScopeDataGridViewTextBoxColumn
        '
        Me.ScopeDataGridViewTextBoxColumn.DataPropertyName = "scope"
        Me.ScopeDataGridViewTextBoxColumn.HeaderText = "Scope"
        Me.ScopeDataGridViewTextBoxColumn.Name = "ScopeDataGridViewTextBoxColumn"
        '
        'SubstrateDataGridViewTextBoxColumn
        '
        Me.SubstrateDataGridViewTextBoxColumn.DataPropertyName = "substrate"
        Me.SubstrateDataGridViewTextBoxColumn.HeaderText = "Substrate"
        Me.SubstrateDataGridViewTextBoxColumn.Name = "SubstrateDataGridViewTextBoxColumn"
        '
        'ScndcountDataGridViewTextBoxColumn
        '
        Me.ScndcountDataGridViewTextBoxColumn.DataPropertyName = "scnd_count"
        Me.ScndcountDataGridViewTextBoxColumn.HeaderText = "2nd_Count"
        Me.ScndcountDataGridViewTextBoxColumn.Name = "ScndcountDataGridViewTextBoxColumn"
        '
        'Mois1DataGridViewTextBoxColumn
        '
        Me.Mois1DataGridViewTextBoxColumn.DataPropertyName = "mois1"
        Me.Mois1DataGridViewTextBoxColumn.HeaderText = "Moisture_1"
        Me.Mois1DataGridViewTextBoxColumn.Name = "Mois1DataGridViewTextBoxColumn"
        '
        'Mois2DataGridViewTextBoxColumn
        '
        Me.Mois2DataGridViewTextBoxColumn.DataPropertyName = "mois2"
        Me.Mois2DataGridViewTextBoxColumn.HeaderText = "Moisture_2"
        Me.Mois2DataGridViewTextBoxColumn.Name = "Mois2DataGridViewTextBoxColumn"
        '
        'MeanDataGridViewTextBoxColumn
        '
        Me.MeanDataGridViewTextBoxColumn.DataPropertyName = "mean"
        Me.MeanDataGridViewTextBoxColumn.HeaderText = "Mean"
        Me.MeanDataGridViewTextBoxColumn.Name = "MeanDataGridViewTextBoxColumn"
        '
        'WsDataGridViewTextBoxColumn
        '
        Me.WsDataGridViewTextBoxColumn.DataPropertyName = "ws"
        Me.WsDataGridViewTextBoxColumn.HeaderText = "Work Sample"
        Me.WsDataGridViewTextBoxColumn.Name = "WsDataGridViewTextBoxColumn"
        '
        'PureDataGridViewTextBoxColumn
        '
        Me.PureDataGridViewTextBoxColumn.DataPropertyName = "pure"
        Me.PureDataGridViewTextBoxColumn.HeaderText = "Pure"
        Me.PureDataGridViewTextBoxColumn.Name = "PureDataGridViewTextBoxColumn"
        '
        'YgDataGridViewTextBoxColumn
        '
        Me.YgDataGridViewTextBoxColumn.DataPropertyName = "yg"
        Me.YgDataGridViewTextBoxColumn.HeaderText = "Young"
        Me.YgDataGridViewTextBoxColumn.Name = "YgDataGridViewTextBoxColumn"
        '
        'UsDataGridViewTextBoxColumn
        '
        Me.UsDataGridViewTextBoxColumn.DataPropertyName = "us"
        Me.UsDataGridViewTextBoxColumn.HeaderText = "Under Size"
        Me.UsDataGridViewTextBoxColumn.Name = "UsDataGridViewTextBoxColumn"
        '
        'RtDataGridViewTextBoxColumn
        '
        Me.RtDataGridViewTextBoxColumn.DataPropertyName = "rt"
        Me.RtDataGridViewTextBoxColumn.HeaderText = "Rotten"
        Me.RtDataGridViewTextBoxColumn.Name = "RtDataGridViewTextBoxColumn"
        '
        'IndDataGridViewTextBoxColumn
        '
        Me.IndDataGridViewTextBoxColumn.DataPropertyName = "Ind"
        Me.IndDataGridViewTextBoxColumn.HeaderText = "Insect Demage"
        Me.IndDataGridViewTextBoxColumn.Name = "IndDataGridViewTextBoxColumn"
        '
        'BrDataGridViewTextBoxColumn
        '
        Me.BrDataGridViewTextBoxColumn.DataPropertyName = "br"
        Me.BrDataGridViewTextBoxColumn.HeaderText = "Broken"
        Me.BrDataGridViewTextBoxColumn.Name = "BrDataGridViewTextBoxColumn"
        '
        'OdDataGridViewTextBoxColumn
        '
        Me.OdDataGridViewTextBoxColumn.DataPropertyName = "od"
        Me.OdDataGridViewTextBoxColumn.HeaderText = "Other Deterio"
        Me.OdDataGridViewTextBoxColumn.Name = "OdDataGridViewTextBoxColumn"
        '
        'GrDataGridViewTextBoxColumn
        '
        Me.GrDataGridViewTextBoxColumn.DataPropertyName = "gr"
        Me.GrDataGridViewTextBoxColumn.HeaderText = "Growth"
        Me.GrDataGridViewTextBoxColumn.Name = "GrDataGridViewTextBoxColumn"
        '
        'FgDataGridViewTextBoxColumn
        '
        Me.FgDataGridViewTextBoxColumn.DataPropertyName = "fg"
        Me.FgDataGridViewTextBoxColumn.HeaderText = "Fungi"
        Me.FgDataGridViewTextBoxColumn.Name = "FgDataGridViewTextBoxColumn"
        '
        'ImDataGridViewTextBoxColumn
        '
        Me.ImDataGridViewTextBoxColumn.DataPropertyName = "im"
        Me.ImDataGridViewTextBoxColumn.HeaderText = "Inert Metter"
        Me.ImDataGridViewTextBoxColumn.Name = "ImDataGridViewTextBoxColumn"
        '
        'CrDataGridViewTextBoxColumn
        '
        Me.CrDataGridViewTextBoxColumn.DataPropertyName = "cr"
        Me.CrDataGridViewTextBoxColumn.HeaderText = "Crack"
        Me.CrDataGridViewTextBoxColumn.Name = "CrDataGridViewTextBoxColumn"
        '
        'CvlDataGridViewTextBoxColumn
        '
        Me.CvlDataGridViewTextBoxColumn.DataPropertyName = "cvl"
        Me.CvlDataGridViewTextBoxColumn.HeaderText = "CVL"
        Me.CvlDataGridViewTextBoxColumn.Name = "CvlDataGridViewTextBoxColumn"
        '
        'ThseedDataGridViewTextBoxColumn
        '
        Me.ThseedDataGridViewTextBoxColumn.DataPropertyName = "thseed"
        Me.ThseedDataGridViewTextBoxColumn.HeaderText = "1th_Seed"
        Me.ThseedDataGridViewTextBoxColumn.Name = "ThseedDataGridViewTextBoxColumn"
        '
        'DTDataGridViewTextBoxColumn
        '
        Me.DTDataGridViewTextBoxColumn.DataPropertyName = "DT"
        Me.DTDataGridViewTextBoxColumn.HeaderText = "DT"
        Me.DTDataGridViewTextBoxColumn.Name = "DTDataGridViewTextBoxColumn"
        '
        'AbnormalDataGridViewTextBoxColumn
        '
        Me.AbnormalDataGridViewTextBoxColumn.DataPropertyName = "Abnormal"
        Me.AbnormalDataGridViewTextBoxColumn.HeaderText = "Abnormal"
        Me.AbnormalDataGridViewTextBoxColumn.Name = "AbnormalDataGridViewTextBoxColumn"
        '
        'VGDataGridViewTextBoxColumn
        '
        Me.VGDataGridViewTextBoxColumn.DataPropertyName = "VG"
        Me.VGDataGridViewTextBoxColumn.HeaderText = "VG"
        Me.VGDataGridViewTextBoxColumn.Name = "VGDataGridViewTextBoxColumn"
        '
        'HardDataGridViewTextBoxColumn
        '
        Me.HardDataGridViewTextBoxColumn.DataPropertyName = "Hard"
        Me.HardDataGridViewTextBoxColumn.HeaderText = "Hard"
        Me.HardDataGridViewTextBoxColumn.Name = "HardDataGridViewTextBoxColumn"
        '
        'FreshDataGridViewTextBoxColumn
        '
        Me.FreshDataGridViewTextBoxColumn.DataPropertyName = "Fresh"
        Me.FreshDataGridViewTextBoxColumn.HeaderText = "Fresh"
        Me.FreshDataGridViewTextBoxColumn.Name = "FreshDataGridViewTextBoxColumn"
        '
        'DeadDataGridViewTextBoxColumn
        '
        Me.DeadDataGridViewTextBoxColumn.DataPropertyName = "Dead"
        Me.DeadDataGridViewTextBoxColumn.HeaderText = "Dead"
        Me.DeadDataGridViewTextBoxColumn.Name = "DeadDataGridViewTextBoxColumn"
        '
        'VgtglinputDataGridViewTextBoxColumn
        '
        Me.VgtglinputDataGridViewTextBoxColumn.DataPropertyName = "vg_tgl_input"
        Me.VgtglinputDataGridViewTextBoxColumn.HeaderText = "VG_Tgl_Input"
        Me.VgtglinputDataGridViewTextBoxColumn.Name = "VgtglinputDataGridViewTextBoxColumn"
        '
        'TglprintDataGridViewTextBoxColumn
        '
        Me.TglprintDataGridViewTextBoxColumn.DataPropertyName = "tgl_print"
        Me.TglprintDataGridViewTextBoxColumn.HeaderText = "Tgl_Print"
        Me.TglprintDataGridViewTextBoxColumn.Name = "TglprintDataGridViewTextBoxColumn"
        '
        'sas_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Name = "sas_report"
        Me.Text = "Report Print SAS"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportgravitysasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroGrid1 As MetroGrid
    Friend WithEvents BtnRefresh As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnPrint As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents HCQC_serverDataSet As HCQC_serverDataSet
    Friend WithEvents ReportgravitysasBindingSource As BindingSource
    Friend WithEvents Report_gravity_sasTableAdapter As HCQC_serverDataSetTableAdapters.report_gravity_sasTableAdapter
    Friend WithEvents LabnumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarietyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomnlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NojobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScopeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubstrateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScndcountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Mois1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Mois2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MeanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PureDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
    Friend WithEvents ThseedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AbnormalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HardDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FreshDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VgtglinputDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TglprintDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
