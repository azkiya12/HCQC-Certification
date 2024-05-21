<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Multy_Request_Sample
    Inherits MetroFramework.Forms.MetroForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Multy_Request_Sample))
        Me.SplrequestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_NewDataset = New HCQC_NewDataset()
        Me.MetroGrid2 = New MetroFramework.Controls.MetroGrid()
        Me.CheckColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.idproductionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarietyColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FarmerColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HarvestColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManualColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BagColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KetColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Spl_requestTableAdapter = New HCQC_NewDatasetTableAdapters.spl_requestTableAdapter()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.TComboScope = New MetroFramework.Controls.MetroComboBox()
        Me.traf = New MetroFramework.Controls.MetroCheckBox()
        Me.tvia = New MetroFramework.Controls.MetroCheckBox()
        Me.tger = New MetroFramework.Controls.MetroCheckBox()
        Me.tpur = New MetroFramework.Controls.MetroCheckBox()
        Me.tmoi = New MetroFramework.Controls.MetroCheckBox()
        Me.tsampling = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.Linkadd = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.LinkClear = New MetroFramework.Controls.MetroLink()
        Me.BtnSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.BtnClearSelected = New MetroFramework.Controls.MetroLink()
        Me.LprosesSave = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.tloc_sample = New MetroFramework.Controls.MetroComboBox()
        CType(Me.SplrequestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplrequestBindingSource
        '
        Me.SplrequestBindingSource.DataMember = "spl_request"
        Me.SplrequestBindingSource.DataSource = Me.HCQC_NewDataset
        '
        'HCQC_NewDataset
        '
        Me.HCQC_NewDataset.DataSetName = "HCQC_NewDataset"
        Me.HCQC_NewDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MetroGrid2
        '
        Me.MetroGrid2.AllowUserToAddRows = False
        Me.MetroGrid2.AllowUserToDeleteRows = False
        Me.MetroGrid2.AllowUserToResizeRows = False
        Me.MetroGrid2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckColumn1, Me.idproductionColumn, Me.VarietyColumn, Me.FarmerColumn, Me.LocationColumn, Me.HarvestColumn, Me.ManualColumn, Me.LotColumn, Me.WeightColumn, Me.BagColumn, Me.KetColumn})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid2.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid2.EnableHeadersVisualStyles = False
        Me.MetroGrid2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid2.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid2.Location = New System.Drawing.Point(23, 86)
        Me.MetroGrid2.Name = "MetroGrid2"
        Me.MetroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid2.Size = New System.Drawing.Size(861, 353)
        Me.MetroGrid2.TabIndex = 77
        '
        'CheckColumn1
        '
        Me.CheckColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckColumn1.HeaderText = ""
        Me.CheckColumn1.Name = "CheckColumn1"
        Me.CheckColumn1.Width = 40
        '
        'idproductionColumn
        '
        Me.idproductionColumn.HeaderText = "Production Code"
        Me.idproductionColumn.Name = "idproductionColumn"
        Me.idproductionColumn.ReadOnly = True
        Me.idproductionColumn.Width = 90
        '
        'VarietyColumn
        '
        Me.VarietyColumn.HeaderText = "Variety"
        Me.VarietyColumn.Name = "VarietyColumn"
        Me.VarietyColumn.ReadOnly = True
        Me.VarietyColumn.Width = 80
        '
        'FarmerColumn
        '
        Me.FarmerColumn.HeaderText = "Farmer"
        Me.FarmerColumn.Name = "FarmerColumn"
        Me.FarmerColumn.Width = 80
        '
        'LocationColumn
        '
        Me.LocationColumn.HeaderText = "Location"
        Me.LocationColumn.Name = "LocationColumn"
        Me.LocationColumn.ReadOnly = True
        '
        'HarvestColumn
        '
        Me.HarvestColumn.HeaderText = "Harvest"
        Me.HarvestColumn.Name = "HarvestColumn"
        Me.HarvestColumn.ReadOnly = True
        '
        'ManualColumn
        '
        Me.ManualColumn.HeaderText = "Manual"
        Me.ManualColumn.Name = "ManualColumn"
        Me.ManualColumn.Width = 70
        '
        'LotColumn
        '
        Me.LotColumn.HeaderText = "Lot/Job"
        Me.LotColumn.Name = "LotColumn"
        Me.LotColumn.Width = 80
        '
        'WeightColumn
        '
        Me.WeightColumn.HeaderText = "Weight (kg)"
        Me.WeightColumn.Name = "WeightColumn"
        '
        'BagColumn
        '
        Me.BagColumn.HeaderText = "Bags"
        Me.BagColumn.Name = "BagColumn"
        Me.BagColumn.Width = 65
        '
        'KetColumn
        '
        Me.KetColumn.HeaderText = "Keterangan"
        Me.KetColumn.Name = "KetColumn"
        '
        'Spl_requestTableAdapter
        '
        Me.Spl_requestTableAdapter.ClearBeforeFill = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.Location = New System.Drawing.Point(23, 461)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(241, 15)
        Me.MetroLabel4.TabIndex = 78
        Me.MetroLabel4.Text = "Step 2 : Evaluation Request List that will to Save"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(923, 86)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(121, 19)
        Me.MetroLabel1.TabIndex = 79
        Me.MetroLabel1.Text = "1. Scope of Sample"
        '
        'TComboScope
        '
        Me.TComboScope.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TComboScope.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.TComboScope.FormattingEnabled = True
        Me.TComboScope.ItemHeight = 19
        Me.TComboScope.Items.AddRange(New Object() {"Raw Material", "Gravity", "Periodic", "Finish Good", "Other"})
        Me.TComboScope.Location = New System.Drawing.Point(944, 108)
        Me.TComboScope.Name = "TComboScope"
        Me.TComboScope.Size = New System.Drawing.Size(172, 25)
        Me.TComboScope.TabIndex = 80
        Me.TComboScope.UseSelectable = True
        '
        'traf
        '
        Me.traf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.traf.AutoSize = True
        Me.traf.BackColor = System.Drawing.Color.Transparent
        Me.traf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.traf.Location = New System.Drawing.Point(944, 289)
        Me.traf.Name = "traf"
        Me.traf.Size = New System.Drawing.Size(96, 15)
        Me.traf.TabIndex = 89
        Me.traf.Text = "Rafaction Test"
        Me.traf.UseSelectable = True
        '
        'tvia
        '
        Me.tvia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tvia.AutoSize = True
        Me.tvia.BackColor = System.Drawing.Color.Transparent
        Me.tvia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.tvia.Location = New System.Drawing.Point(944, 331)
        Me.tvia.Name = "tvia"
        Me.tvia.Size = New System.Drawing.Size(88, 15)
        Me.tvia.TabIndex = 91
        Me.tvia.Text = "Viability Test"
        Me.tvia.UseSelectable = True
        '
        'tger
        '
        Me.tger.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tger.AutoSize = True
        Me.tger.BackColor = System.Drawing.Color.Transparent
        Me.tger.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.tger.Location = New System.Drawing.Point(944, 310)
        Me.tger.Name = "tger"
        Me.tger.Size = New System.Drawing.Size(112, 15)
        Me.tger.TabIndex = 90
        Me.tger.Text = "Germination Test"
        Me.tger.UseSelectable = True
        '
        'tpur
        '
        Me.tpur.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tpur.AutoSize = True
        Me.tpur.BackColor = System.Drawing.Color.Transparent
        Me.tpur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.tpur.Location = New System.Drawing.Point(944, 268)
        Me.tpur.Name = "tpur"
        Me.tpur.Size = New System.Drawing.Size(77, 15)
        Me.tpur.TabIndex = 88
        Me.tpur.Text = "Purity Test"
        Me.tpur.UseSelectable = True
        '
        'tmoi
        '
        Me.tmoi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tmoi.AutoSize = True
        Me.tmoi.BackColor = System.Drawing.Color.Transparent
        Me.tmoi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.tmoi.Location = New System.Drawing.Point(944, 247)
        Me.tmoi.Name = "tmoi"
        Me.tmoi.Size = New System.Drawing.Size(93, 15)
        Me.tmoi.TabIndex = 87
        Me.tmoi.Text = "Moisture Test"
        Me.tmoi.UseSelectable = True
        '
        'tsampling
        '
        Me.tsampling.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsampling.AutoSize = True
        Me.tsampling.BackColor = System.Drawing.Color.Transparent
        Me.tsampling.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.tsampling.Location = New System.Drawing.Point(944, 226)
        Me.tsampling.Name = "tsampling"
        Me.tsampling.Size = New System.Drawing.Size(73, 15)
        Me.tsampling.TabIndex = 86
        Me.tsampling.Text = "Sampling"
        Me.tsampling.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(923, 204)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(163, 19)
        Me.MetroLabel2.TabIndex = 92
        Me.MetroLabel2.Text = "3. Test Laboratory Request"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel7.Location = New System.Drawing.Point(911, 442)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(208, 34)
        Me.MetroLabel7.TabIndex = 94
        Me.MetroLabel7.Text = "Step 3 : Select Request option and Click button to Save"
        Me.MetroLabel7.WrapToLine = True
        '
        'Linkadd
        '
        Me.Linkadd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Linkadd.AutoSize = True
        Me.Linkadd.BackColor = System.Drawing.Color.Transparent
        Me.Linkadd.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.Linkadd.Location = New System.Drawing.Point(813, 57)
        Me.Linkadd.Name = "Linkadd"
        Me.Linkadd.Size = New System.Drawing.Size(71, 23)
        Me.Linkadd.TabIndex = 96
        Me.Linkadd.Text = "+ Add Data"
        Me.Linkadd.UseCustomBackColor = True
        Me.Linkadd.UseSelectable = True
        Me.Linkadd.UseStyleColors = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 60)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(120, 23)
        Me.MetroLabel3.TabIndex = 95
        Me.MetroLabel3.Text = "Request List"
        Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkClear
        '
        Me.LinkClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkClear.AutoSize = True
        Me.LinkClear.BackColor = System.Drawing.Color.Transparent
        Me.LinkClear.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkClear.Location = New System.Drawing.Point(658, 57)
        Me.LinkClear.Name = "LinkClear"
        Me.LinkClear.Size = New System.Drawing.Size(57, 23)
        Me.LinkClear.TabIndex = 96
        Me.LinkClear.Text = "Clear All"
        Me.LinkClear.UseCustomBackColor = True
        Me.LinkClear.UseSelectable = True
        Me.LinkClear.UseStyleColors = True
        '
        'BtnSave
        '
        Me.BtnSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.BtnSave.IconRightVisible = True
        Me.BtnSave.IconRightZoom = 0R
        Me.BtnSave.IconVisible = True
        Me.BtnSave.IconZoom = 50.0R
        Me.BtnSave.IsTab = False
        Me.BtnSave.Location = New System.Drawing.Point(926, 363)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSave.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnSave.selected = True
        Me.BtnSave.Size = New System.Drawing.Size(193, 30)
        Me.BtnSave.TabIndex = 93
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Textcolor = System.Drawing.Color.White
        Me.BtnSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 442)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(214, 15)
        Me.MetroLabel5.TabIndex = 97
        Me.MetroLabel5.Text = "Step 1 : Get data from button +Add Data"
        '
        'BtnClearSelected
        '
        Me.BtnClearSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClearSelected.AutoSize = True
        Me.BtnClearSelected.BackColor = System.Drawing.Color.Transparent
        Me.BtnClearSelected.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.BtnClearSelected.Location = New System.Drawing.Point(721, 57)
        Me.BtnClearSelected.Name = "BtnClearSelected"
        Me.BtnClearSelected.Size = New System.Drawing.Size(86, 23)
        Me.BtnClearSelected.TabIndex = 96
        Me.BtnClearSelected.Text = "Clear Selected"
        Me.BtnClearSelected.UseCustomBackColor = True
        Me.BtnClearSelected.UseSelectable = True
        Me.BtnClearSelected.UseStyleColors = True
        '
        'LprosesSave
        '
        Me.LprosesSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LprosesSave.AutoSize = True
        Me.LprosesSave.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LprosesSave.ForeColor = System.Drawing.Color.LightGray
        Me.LprosesSave.Location = New System.Drawing.Point(926, 420)
        Me.LprosesSave.Name = "LprosesSave"
        Me.LprosesSave.Size = New System.Drawing.Size(16, 15)
        Me.LprosesSave.TabIndex = 94
        Me.LprosesSave.Text = "..."
        Me.LprosesSave.UseCustomForeColor = True
        Me.LprosesSave.WrapToLine = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(923, 146)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(120, 19)
        Me.MetroLabel6.TabIndex = 98
        Me.MetroLabel6.Text = "2. Sample Location"
        '
        'tloc_sample
        '
        Me.tloc_sample.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tloc_sample.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.tloc_sample.FormattingEnabled = True
        Me.tloc_sample.ItemHeight = 19
        Me.tloc_sample.Items.AddRange(New Object() {"Gudang A", "Gudang B", "Gudang C", "Gudang E", "Gudang G", "Gudang WP", "CR C", "CR E", "CR F", "CR G"})
        Me.tloc_sample.Location = New System.Drawing.Point(944, 167)
        Me.tloc_sample.Name = "tloc_sample"
        Me.tloc_sample.Size = New System.Drawing.Size(172, 25)
        Me.tloc_sample.TabIndex = 99
        Me.tloc_sample.UseSelectable = True
        '
        'Multy_Request_Sample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 496)
        Me.Controls.Add(Me.tloc_sample)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.BtnClearSelected)
        Me.Controls.Add(Me.LinkClear)
        Me.Controls.Add(Me.Linkadd)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.LprosesSave)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.traf)
        Me.Controls.Add(Me.tvia)
        Me.Controls.Add(Me.tger)
        Me.Controls.Add(Me.tpur)
        Me.Controls.Add(Me.tmoi)
        Me.Controls.Add(Me.tsampling)
        Me.Controls.Add(Me.TComboScope)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroGrid2)
        Me.Name = "Multy_Request_Sample"
        Me.Text = "Multipel Request Sample"
        CType(Me.SplrequestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroGrid2 As MetroGrid
    Friend WithEvents HCQC_NewDataset As HCQC_NewDataset
    Friend WithEvents SplrequestBindingSource As BindingSource
    Friend WithEvents Spl_requestTableAdapter As HCQC_NewDatasetTableAdapters.spl_requestTableAdapter
    Friend WithEvents MetroLabel4 As MetroLabel
    Friend WithEvents MetroLabel1 As MetroLabel
    Friend WithEvents TComboScope As MetroComboBox
    Friend WithEvents traf As MetroCheckBox
    Friend WithEvents tvia As MetroCheckBox
    Friend WithEvents tger As MetroCheckBox
    Friend WithEvents tpur As MetroCheckBox
    Friend WithEvents tmoi As MetroCheckBox
    Friend WithEvents tsampling As MetroCheckBox
    Friend WithEvents MetroLabel2 As MetroLabel
    Friend WithEvents BtnSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MetroLabel7 As MetroLabel
    Friend WithEvents Linkadd As MetroLink
    Friend WithEvents MetroLabel3 As MetroLabel
    Friend WithEvents LinkClear As MetroLink
    Friend WithEvents MetroLabel5 As MetroLabel
    Friend WithEvents BtnClearSelected As MetroLink
    Friend WithEvents LprosesSave As MetroLabel
    Friend WithEvents CheckColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents idproductionColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarietyColumn As DataGridViewTextBoxColumn
    Friend WithEvents FarmerColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationColumn As DataGridViewTextBoxColumn
    Friend WithEvents HarvestColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManualColumn As DataGridViewTextBoxColumn
    Friend WithEvents LotColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightColumn As DataGridViewTextBoxColumn
    Friend WithEvents BagColumn As DataGridViewTextBoxColumn
    Friend WithEvents KetColumn As DataGridViewTextBoxColumn
    Friend WithEvents MetroLabel6 As MetroLabel
    Friend WithEvents tloc_sample As MetroComboBox
End Class
