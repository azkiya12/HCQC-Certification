<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QC_Verification
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.QcconfirmviewerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_NewDataset = New HCQC_NewDataset()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.LinkRejected = New MetroFramework.Controls.MetroLink()
        Me.LinkAll = New MetroFramework.Controls.MetroLink()
        Me.LinkAccepted = New MetroFramework.Controls.MetroLink()
        Me.LinkOnProcess = New MetroFramework.Controls.MetroLink()
        Me.Tsearch = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.Qc_confirm_viewerTableAdapter = New HCQC_NewDatasetTableAdapters.qc_confirm_viewerTableAdapter()
        Me.AcceptedColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.RejectedColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.status_confirmColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.labnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productioncolumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cropColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarietyColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FarmerColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomnlColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NojobColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScopeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.remarkColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HarvestColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bagsColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.samplingColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.moiColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.purityColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.gerColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.viaColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.rafColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.idColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReqnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglconfirmColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaconDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InformationrejectedColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnDel = New System.Windows.Forms.DataGridViewLinkColumn()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QcconfirmviewerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToOrderColumns = True
        Me.MetroGrid1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.MetroGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.AutoGenerateColumns = False
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CausesValidation = False
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AcceptedColumn, Me.RejectedColumn, Me.status_confirmColumn, Me.labnum, Me.productioncolumn, Me.cropColumn, Me.VarietyColumn, Me.FarmerColumn, Me.NomnlColumn, Me.NojobColumn, Me.ScopeColumn, Me.WeightColumn, Me.remarkColumn, Me.LocationColumn, Me.HarvestColumn, Me.bagsColumn, Me.samplingColumn, Me.moiColumn, Me.purityColumn, Me.gerColumn, Me.viaColumn, Me.rafColumn, Me.idColumn, Me.ReqnameDataGridViewTextBoxColumn, Me.TglconfirmColumn, Me.NamaconDataGridViewTextBoxColumn, Me.InformationrejectedColumn, Me.BtnDel})
        Me.MetroGrid1.DataSource = Me.QcconfirmviewerBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(0, 0)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.MetroGrid1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(862, 413)
        Me.MetroGrid1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroGrid1.TabIndex = 0
        Me.MetroGrid1.VirtualMode = True
        '
        'QcconfirmviewerBindingSource
        '
        Me.QcconfirmviewerBindingSource.DataMember = "qc_confirm_viewer"
        Me.QcconfirmviewerBindingSource.DataSource = Me.HCQC_NewDataset
        '
        'HCQC_NewDataset
        '
        Me.HCQC_NewDataset.DataSetName = "HCQC_NewDataset"
        Me.HCQC_NewDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        Me.MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroPanel1.Controls.Add(Me.MetroGrid1)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(3, 36)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(862, 413)
        Me.MetroPanel1.TabIndex = 1
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.LinkRejected)
        Me.MetroPanel2.Controls.Add(Me.LinkAll)
        Me.MetroPanel2.Controls.Add(Me.LinkAccepted)
        Me.MetroPanel2.Controls.Add(Me.LinkOnProcess)
        Me.MetroPanel2.Controls.Add(Me.Tsearch)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(865, 33)
        Me.MetroPanel2.TabIndex = 2
        Me.MetroPanel2.UseStyleColors = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'LinkRejected
        '
        Me.LinkRejected.AutoSize = True
        Me.LinkRejected.BackColor = System.Drawing.Color.Transparent
        Me.LinkRejected.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkRejected.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkRejected.Location = New System.Drawing.Point(242, 7)
        Me.LinkRejected.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkRejected.Name = "LinkRejected"
        Me.LinkRejected.Size = New System.Drawing.Size(72, 23)
        Me.LinkRejected.TabIndex = 89
        Me.LinkRejected.TabStop = False
        Me.LinkRejected.Text = "Rejected"
        Me.LinkRejected.UseCustomBackColor = True
        Me.LinkRejected.UseSelectable = True
        Me.LinkRejected.UseStyleColors = True
        '
        'LinkAll
        '
        Me.LinkAll.AutoSize = True
        Me.LinkAll.BackColor = System.Drawing.Color.Transparent
        Me.LinkAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkAll.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkAll.Location = New System.Drawing.Point(314, 7)
        Me.LinkAll.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkAll.Name = "LinkAll"
        Me.LinkAll.Size = New System.Drawing.Size(48, 23)
        Me.LinkAll.TabIndex = 88
        Me.LinkAll.TabStop = False
        Me.LinkAll.Text = "All"
        Me.LinkAll.UseCustomBackColor = True
        Me.LinkAll.UseSelectable = True
        Me.LinkAll.UseStyleColors = True
        '
        'LinkAccepted
        '
        Me.LinkAccepted.AutoSize = True
        Me.LinkAccepted.BackColor = System.Drawing.Color.Transparent
        Me.LinkAccepted.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkAccepted.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkAccepted.Location = New System.Drawing.Point(173, 7)
        Me.LinkAccepted.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkAccepted.Name = "LinkAccepted"
        Me.LinkAccepted.Size = New System.Drawing.Size(72, 23)
        Me.LinkAccepted.TabIndex = 88
        Me.LinkAccepted.TabStop = False
        Me.LinkAccepted.Text = "Accepted"
        Me.LinkAccepted.UseCustomBackColor = True
        Me.LinkAccepted.UseSelectable = True
        Me.LinkAccepted.UseStyleColors = True
        '
        'LinkOnProcess
        '
        Me.LinkOnProcess.AutoSize = True
        Me.LinkOnProcess.BackColor = System.Drawing.Color.Transparent
        Me.LinkOnProcess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkOnProcess.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkOnProcess.Location = New System.Drawing.Point(101, 7)
        Me.LinkOnProcess.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkOnProcess.Name = "LinkOnProcess"
        Me.LinkOnProcess.Size = New System.Drawing.Size(72, 23)
        Me.LinkOnProcess.TabIndex = 88
        Me.LinkOnProcess.TabStop = False
        Me.LinkOnProcess.Text = "On Process"
        Me.LinkOnProcess.UseCustomBackColor = True
        Me.LinkOnProcess.UseSelectable = True
        Me.LinkOnProcess.UseStyleColors = True
        '
        'Tsearch
        '
        Me.Tsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Tsearch.CustomButton.Image = My.Resources.Resources.Find
        Me.Tsearch.CustomButton.Location = New System.Drawing.Point(168, 1)
        Me.Tsearch.CustomButton.Name = ""
        Me.Tsearch.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.Tsearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Tsearch.CustomButton.TabIndex = 1
        Me.Tsearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Tsearch.CustomButton.UseSelectable = True
        Me.Tsearch.Lines = New String(-1) {}
        Me.Tsearch.Location = New System.Drawing.Point(672, 7)
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
        Me.Tsearch.Style = MetroFramework.MetroColorStyle.Green
        Me.Tsearch.TabIndex = 58
        Me.Tsearch.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Tsearch.UseSelectable = True
        Me.Tsearch.WaterMark = "Search..."
        Me.Tsearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Tsearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MetroLabel2.Location = New System.Drawing.Point(3, 7)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Data List"
        Me.MetroLabel2.UseCustomBackColor = True
        Me.MetroLabel2.UseCustomForeColor = True
        '
        'Qc_confirm_viewerTableAdapter
        '
        Me.Qc_confirm_viewerTableAdapter.ClearBeforeFill = True
        '
        'AcceptedColumn
        '
        Me.AcceptedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.AcceptedColumn.HeaderText = "Button"
        Me.AcceptedColumn.LinkColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AcceptedColumn.MinimumWidth = 60
        Me.AcceptedColumn.Name = "AcceptedColumn"
        Me.AcceptedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AcceptedColumn.Text = "Accepted"
        Me.AcceptedColumn.ToolTipText = "Accepted"
        Me.AcceptedColumn.UseColumnTextForLinkValue = True
        Me.AcceptedColumn.Width = 60
        '
        'RejectedColumn
        '
        Me.RejectedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.RejectedColumn.HeaderText = "Button"
        Me.RejectedColumn.LinkColor = System.Drawing.Color.Silver
        Me.RejectedColumn.MinimumWidth = 60
        Me.RejectedColumn.Name = "RejectedColumn"
        Me.RejectedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RejectedColumn.Text = "Rejected"
        Me.RejectedColumn.ToolTipText = "Rejected"
        Me.RejectedColumn.UseColumnTextForLinkValue = True
        Me.RejectedColumn.Width = 60
        '
        'status_confirmColumn
        '
        Me.status_confirmColumn.DataPropertyName = "status_confirm"
        Me.status_confirmColumn.HeaderText = "Status"
        Me.status_confirmColumn.Name = "status_confirmColumn"
        Me.status_confirmColumn.ReadOnly = True
        Me.status_confirmColumn.Width = 70
        '
        'labnum
        '
        Me.labnum.DataPropertyName = "labnum"
        Me.labnum.HeaderText = "Lab Number"
        Me.labnum.Name = "labnum"
        '
        'productioncolumn
        '
        Me.productioncolumn.DataPropertyName = "id_hvsprod"
        Me.productioncolumn.HeaderText = "Production Code"
        Me.productioncolumn.Name = "productioncolumn"
        '
        'cropColumn
        '
        Me.cropColumn.DataPropertyName = "crop"
        Me.cropColumn.HeaderText = "Crop"
        Me.cropColumn.Name = "cropColumn"
        '
        'VarietyColumn
        '
        Me.VarietyColumn.DataPropertyName = "variety"
        Me.VarietyColumn.HeaderText = "Variety"
        Me.VarietyColumn.Name = "VarietyColumn"
        '
        'FarmerColumn
        '
        Me.FarmerColumn.DataPropertyName = "farmer"
        Me.FarmerColumn.HeaderText = "Farmer"
        Me.FarmerColumn.Name = "FarmerColumn"
        '
        'NomnlColumn
        '
        Me.NomnlColumn.DataPropertyName = "nomnl"
        Me.NomnlColumn.HeaderText = "Manual"
        Me.NomnlColumn.Name = "NomnlColumn"
        Me.NomnlColumn.Width = 60
        '
        'NojobColumn
        '
        Me.NojobColumn.DataPropertyName = "nojob"
        Me.NojobColumn.HeaderText = "Lot/Job"
        Me.NojobColumn.Name = "NojobColumn"
        '
        'ScopeColumn
        '
        Me.ScopeColumn.DataPropertyName = "scope"
        Me.ScopeColumn.HeaderText = "Scope"
        Me.ScopeColumn.Name = "ScopeColumn"
        '
        'WeightColumn
        '
        Me.WeightColumn.DataPropertyName = "weight"
        Me.WeightColumn.HeaderText = "Weight (kg)"
        Me.WeightColumn.Name = "WeightColumn"
        '
        'remarkColumn
        '
        Me.remarkColumn.DataPropertyName = "remark"
        Me.remarkColumn.HeaderText = "Remark"
        Me.remarkColumn.Name = "remarkColumn"
        Me.remarkColumn.ToolTipText = "Remark Request"
        '
        'LocationColumn
        '
        Me.LocationColumn.DataPropertyName = "location"
        Me.LocationColumn.HeaderText = "Location"
        Me.LocationColumn.Name = "LocationColumn"
        '
        'HarvestColumn
        '
        Me.HarvestColumn.DataPropertyName = "harvest"
        Me.HarvestColumn.HeaderText = "Harvest"
        Me.HarvestColumn.Name = "HarvestColumn"
        '
        'bagsColumn
        '
        Me.bagsColumn.DataPropertyName = "bag"
        Me.bagsColumn.HeaderText = "Bags"
        Me.bagsColumn.Name = "bagsColumn"
        '
        'samplingColumn
        '
        Me.samplingColumn.DataPropertyName = "test_sampling"
        Me.samplingColumn.HeaderText = "Sampling"
        Me.samplingColumn.Name = "samplingColumn"
        Me.samplingColumn.Width = 75
        '
        'moiColumn
        '
        Me.moiColumn.DataPropertyName = "test_moi"
        Me.moiColumn.HeaderText = "Moisture"
        Me.moiColumn.Name = "moiColumn"
        Me.moiColumn.Width = 75
        '
        'purityColumn
        '
        Me.purityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.purityColumn.DataPropertyName = "test_pur"
        Me.purityColumn.HeaderText = "Purity"
        Me.purityColumn.Name = "purityColumn"
        Me.purityColumn.Width = 44
        '
        'gerColumn
        '
        Me.gerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.gerColumn.DataPropertyName = "test_ger"
        Me.gerColumn.HeaderText = "Germ"
        Me.gerColumn.Name = "gerColumn"
        Me.gerColumn.Width = 44
        '
        'viaColumn
        '
        Me.viaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.viaColumn.DataPropertyName = "test_via"
        Me.viaColumn.HeaderText = "Rapid"
        Me.viaColumn.Name = "viaColumn"
        Me.viaColumn.Width = 46
        '
        'rafColumn
        '
        Me.rafColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.rafColumn.DataPropertyName = "test_raf"
        Me.rafColumn.HeaderText = "Rafaction"
        Me.rafColumn.Name = "rafColumn"
        Me.rafColumn.Width = 66
        '
        'idColumn
        '
        Me.idColumn.DataPropertyName = "id"
        Me.idColumn.HeaderText = "Request Number"
        Me.idColumn.Name = "idColumn"
        '
        'ReqnameDataGridViewTextBoxColumn
        '
        Me.ReqnameDataGridViewTextBoxColumn.DataPropertyName = "req_name"
        Me.ReqnameDataGridViewTextBoxColumn.HeaderText = "Req. Name"
        Me.ReqnameDataGridViewTextBoxColumn.Name = "ReqnameDataGridViewTextBoxColumn"
        '
        'TglconfirmColumn
        '
        Me.TglconfirmColumn.DataPropertyName = "tgl_confirm"
        Me.TglconfirmColumn.HeaderText = "Confirm Date"
        Me.TglconfirmColumn.Name = "TglconfirmColumn"
        '
        'NamaconDataGridViewTextBoxColumn
        '
        Me.NamaconDataGridViewTextBoxColumn.DataPropertyName = "nama_con"
        Me.NamaconDataGridViewTextBoxColumn.HeaderText = "Confirm Name"
        Me.NamaconDataGridViewTextBoxColumn.Name = "NamaconDataGridViewTextBoxColumn"
        '
        'InformationrejectedColumn
        '
        Me.InformationrejectedColumn.DataPropertyName = "information_rejected"
        Me.InformationrejectedColumn.HeaderText = "Remark Rejected"
        Me.InformationrejectedColumn.Name = "InformationrejectedColumn"
        '
        'BtnDel
        '
        Me.BtnDel.HeaderText = "Undo"
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BtnDel.Text = "Delete"
        Me.BtnDel.ToolTipText = "Delete"
        Me.BtnDel.UseColumnTextForLinkValue = True
        Me.BtnDel.Width = 70
        '
        'QC_Verification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Name = "QC_Verification"
        Me.Size = New System.Drawing.Size(865, 452)
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QcconfirmviewerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroGrid1 As MetroGrid
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MetroStyleManager1 As Components.MetroStyleManager
    Friend WithEvents MetroStyleExtender1 As Components.MetroStyleExtender
    Friend WithEvents MetroPanel1 As MetroPanel
    Friend WithEvents MetroPanel2 As MetroPanel
    Friend WithEvents MetroLabel2 As MetroLabel
    Friend WithEvents Tsearch As MetroTextBox
    Friend WithEvents LinkAll As MetroLink
    Friend WithEvents LinkAccepted As MetroLink
    Friend WithEvents LinkOnProcess As MetroLink
    Friend WithEvents LinkRejected As MetroLink
    Friend WithEvents QcconfirmviewerBindingSource As BindingSource
    Friend WithEvents HCQC_NewDataset As HCQC_NewDataset
    Friend WithEvents Qc_confirm_viewerTableAdapter As HCQC_NewDatasetTableAdapters.qc_confirm_viewerTableAdapter
    Friend WithEvents AcceptedColumn As DataGridViewLinkColumn
    Friend WithEvents RejectedColumn As DataGridViewLinkColumn
    Friend WithEvents status_confirmColumn As DataGridViewTextBoxColumn
    Friend WithEvents labnum As DataGridViewTextBoxColumn
    Friend WithEvents productioncolumn As DataGridViewTextBoxColumn
    Friend WithEvents cropColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarietyColumn As DataGridViewTextBoxColumn
    Friend WithEvents FarmerColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomnlColumn As DataGridViewTextBoxColumn
    Friend WithEvents NojobColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScopeColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightColumn As DataGridViewTextBoxColumn
    Friend WithEvents remarkColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationColumn As DataGridViewTextBoxColumn
    Friend WithEvents HarvestColumn As DataGridViewTextBoxColumn
    Friend WithEvents bagsColumn As DataGridViewTextBoxColumn
    Friend WithEvents samplingColumn As DataGridViewCheckBoxColumn
    Friend WithEvents moiColumn As DataGridViewCheckBoxColumn
    Friend WithEvents purityColumn As DataGridViewCheckBoxColumn
    Friend WithEvents gerColumn As DataGridViewCheckBoxColumn
    Friend WithEvents viaColumn As DataGridViewCheckBoxColumn
    Friend WithEvents rafColumn As DataGridViewCheckBoxColumn
    Friend WithEvents idColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReqnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TglconfirmColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaconDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InformationrejectedColumn As DataGridViewTextBoxColumn
    Friend WithEvents BtnDel As DataGridViewLinkColumn
End Class
