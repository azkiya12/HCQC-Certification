<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_Label_Production
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report_Label_Production))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.CheckColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdcodeColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.areaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarietyColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CropColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.norencanaColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HarvestColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContractColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CgrColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Count = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastPrint = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reporta1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_NewDataset = New WindowsApplication1.HCQC_NewDataset()
        Me.CheckBox1 = New MetroFramework.Controls.MetroCheckBox()
        Me.LInkRefresh = New MetroFramework.Controls.MetroLink()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.BtnPreview = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.LabelCount = New MetroFramework.Controls.MetroLabel()
        Me.MetroGrid2 = New MetroFramework.Controls.MetroGrid()
        Me.CekColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarietyColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CropColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlantColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContractColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HarvestColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnSend = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnSendBack = New Bunifu.Framework.UI.BunifuImageButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.LabelPrinter = New MetroFramework.Controls.MetroLink()
        Me.Label9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.LabelMark = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.trequestcopy = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLink2 = New MetroFramework.Controls.MetroLink()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.Report_a1TableAdapter = New WindowsApplication1.HCQC_NewDatasetTableAdapters.report_a1TableAdapter()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reporta1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSendBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckColumn, Me.IdcodeColumn1, Me.areaColumn, Me.VarietyColumn1, Me.CropColumn1, Me.norencanaColumn1, Me.HarvestColumn1, Me.ContractColumn1, Me.CgrColumn1, Me.Count, Me.LastPrint})
        Me.MetroGrid1.DataSource = Me.Reporta1BindingSource
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
        Me.MetroGrid1.Location = New System.Drawing.Point(23, 92)
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
        Me.MetroGrid1.Size = New System.Drawing.Size(382, 373)
        Me.MetroGrid1.TabIndex = 0
        '
        'CheckColumn
        '
        Me.CheckColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckColumn.HeaderText = ""
        Me.CheckColumn.Name = "CheckColumn"
        Me.CheckColumn.Width = 55
        '
        'IdcodeColumn1
        '
        Me.IdcodeColumn1.DataPropertyName = "idcode"
        Me.IdcodeColumn1.HeaderText = "Production Code"
        Me.IdcodeColumn1.Name = "IdcodeColumn1"
        Me.IdcodeColumn1.Width = 90
        '
        'areaColumn
        '
        Me.areaColumn.DataPropertyName = "area"
        Me.areaColumn.HeaderText = "Area"
        Me.areaColumn.Name = "areaColumn"
        '
        'VarietyColumn1
        '
        Me.VarietyColumn1.DataPropertyName = "variety"
        Me.VarietyColumn1.HeaderText = "Variety"
        Me.VarietyColumn1.Name = "VarietyColumn1"
        Me.VarietyColumn1.Width = 80
        '
        'CropColumn1
        '
        Me.CropColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.CropColumn1.DataPropertyName = "crop"
        Me.CropColumn1.HeaderText = "Crop"
        Me.CropColumn1.MinimumWidth = 130
        Me.CropColumn1.Name = "CropColumn1"
        Me.CropColumn1.Width = 130
        '
        'norencanaColumn1
        '
        Me.norencanaColumn1.DataPropertyName = "norencana"
        Me.norencanaColumn1.HeaderText = "No Rencana"
        Me.norencanaColumn1.Name = "norencanaColumn1"
        '
        'HarvestColumn1
        '
        Me.HarvestColumn1.DataPropertyName = "harvest"
        Me.HarvestColumn1.HeaderText = "Harvest Date"
        Me.HarvestColumn1.Name = "HarvestColumn1"
        '
        'ContractColumn1
        '
        Me.ContractColumn1.DataPropertyName = "nokontrak"
        Me.ContractColumn1.HeaderText = "Contract No"
        Me.ContractColumn1.Name = "ContractColumn1"
        '
        'CgrColumn1
        '
        Me.CgrColumn1.DataPropertyName = "cgrname"
        Me.CgrColumn1.HeaderText = "CGR Name"
        Me.CgrColumn1.Name = "CgrColumn1"
        '
        'Count
        '
        Me.Count.DataPropertyName = "Count"
        Me.Count.HeaderText = "Print Count"
        Me.Count.Name = "Count"
        Me.Count.Width = 70
        '
        'LastPrint
        '
        Me.LastPrint.DataPropertyName = "LastPrint"
        Me.LastPrint.HeaderText = "Last Print"
        Me.LastPrint.Name = "LastPrint"
        '
        'Reporta1BindingSource
        '
        Me.Reporta1BindingSource.DataMember = "report_a1"
        Me.Reporta1BindingSource.DataSource = Me.HCQC_NewDataset
        '
        'HCQC_NewDataset
        '
        Me.HCQC_NewDataset.DataSetName = "HCQC_NewDataset"
        Me.HCQC_NewDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.Location = New System.Drawing.Point(327, 63)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(78, 23)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Select All"
        Me.CheckBox1.UseSelectable = True
        '
        'LInkRefresh
        '
        Me.LInkRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LInkRefresh.AutoSize = True
        Me.LInkRefresh.BackColor = System.Drawing.Color.Transparent
        Me.LInkRefresh.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LInkRefresh.Location = New System.Drawing.Point(264, 63)
        Me.LInkRefresh.Name = "LInkRefresh"
        Me.LInkRefresh.Size = New System.Drawing.Size(57, 23)
        Me.LInkRefresh.TabIndex = 57
        Me.LInkRefresh.Text = "Refresh"
        Me.LInkRefresh.UseCustomBackColor = True
        Me.LInkRefresh.UseSelectable = True
        Me.LInkRefresh.UseStyleColors = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(711, 114)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(696, 92)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(173, 19)
        Me.MetroLabel2.TabIndex = 59
        Me.MetroLabel2.Text = "1. Select kotak pada DataList"
        '
        'BtnPreview
        '
        Me.BtnPreview.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPreview.BorderRadius = 0
        Me.BtnPreview.ButtonText = "Print"
        Me.BtnPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPreview.DisabledColor = System.Drawing.Color.Gray
        Me.BtnPreview.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnPreview.Iconimage = CType(resources.GetObject("BtnPreview.Iconimage"), System.Drawing.Image)
        Me.BtnPreview.Iconimage_right = Nothing
        Me.BtnPreview.Iconimage_right_Selected = Nothing
        Me.BtnPreview.Iconimage_Selected = Nothing
        Me.BtnPreview.IconMarginLeft = 0
        Me.BtnPreview.IconMarginRight = 0
        Me.BtnPreview.IconRightVisible = True
        Me.BtnPreview.IconRightZoom = 0R
        Me.BtnPreview.IconVisible = True
        Me.BtnPreview.IconZoom = 50.0R
        Me.BtnPreview.IsTab = False
        Me.BtnPreview.Location = New System.Drawing.Point(696, 355)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnPreview.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPreview.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnPreview.selected = True
        Me.BtnPreview.Size = New System.Drawing.Size(173, 30)
        Me.BtnPreview.TabIndex = 58
        Me.BtnPreview.Text = "Print"
        Me.BtnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPreview.Textcolor = System.Drawing.Color.White
        Me.BtnPreview.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LabelCount
        '
        Me.LabelCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCount.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelCount.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.LabelCount.Location = New System.Drawing.Point(804, 233)
        Me.LabelCount.Name = "LabelCount"
        Me.LabelCount.Size = New System.Drawing.Size(65, 15)
        Me.LabelCount.TabIndex = 59
        Me.LabelCount.Text = "..."
        Me.LabelCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MetroGrid2
        '
        Me.MetroGrid2.AllowUserToAddRows = False
        Me.MetroGrid2.AllowUserToDeleteRows = False
        Me.MetroGrid2.AllowUserToResizeRows = False
        Me.MetroGrid2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MetroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CekColumn, Me.IdColumn, Me.VarietyColumn, Me.CropColumn, Me.PlantColumn, Me.ContractColumn, Me.HarvestColumn2})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid2.DefaultCellStyle = DataGridViewCellStyle5
        Me.MetroGrid2.EnableHeadersVisualStyles = False
        Me.MetroGrid2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid2.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid2.Location = New System.Drawing.Point(456, 92)
        Me.MetroGrid2.Name = "MetroGrid2"
        Me.MetroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid2.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.MetroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid2.Size = New System.Drawing.Size(231, 373)
        Me.MetroGrid2.TabIndex = 61
        '
        'CekColumn
        '
        Me.CekColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.CekColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CekColumn.HeaderText = ""
        Me.CekColumn.MinimumWidth = 50
        Me.CekColumn.Name = "CekColumn"
        Me.CekColumn.Width = 50
        '
        'IdColumn
        '
        Me.IdColumn.HeaderText = "Production Code"
        Me.IdColumn.Name = "IdColumn"
        '
        'VarietyColumn
        '
        Me.VarietyColumn.HeaderText = "Variety"
        Me.VarietyColumn.Name = "VarietyColumn"
        '
        'CropColumn
        '
        Me.CropColumn.HeaderText = "Area"
        Me.CropColumn.Name = "CropColumn"
        '
        'PlantColumn
        '
        Me.PlantColumn.HeaderText = "Plant No"
        Me.PlantColumn.Name = "PlantColumn"
        '
        'ContractColumn
        '
        Me.ContractColumn.HeaderText = "Contract No"
        Me.ContractColumn.Name = "ContractColumn"
        '
        'HarvestColumn2
        '
        Me.HarvestColumn2.HeaderText = "Harvest"
        Me.HarvestColumn2.Name = "HarvestColumn2"
        '
        'BtnSend
        '
        Me.BtnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSend.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnSend.Image = CType(resources.GetObject("BtnSend.Image"), System.Drawing.Image)
        Me.BtnSend.ImageActive = Nothing
        Me.BtnSend.Location = New System.Drawing.Point(411, 220)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(39, 24)
        Me.BtnSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnSend.TabIndex = 62
        Me.BtnSend.TabStop = False
        Me.BtnSend.Zoom = 10
        '
        'BtnSendBack
        '
        Me.BtnSendBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSendBack.BackColor = System.Drawing.Color.Brown
        Me.BtnSendBack.Image = CType(resources.GetObject("BtnSendBack.Image"), System.Drawing.Image)
        Me.BtnSendBack.ImageActive = Nothing
        Me.BtnSendBack.Location = New System.Drawing.Point(411, 250)
        Me.BtnSendBack.Name = "BtnSendBack"
        Me.BtnSendBack.Size = New System.Drawing.Size(39, 24)
        Me.BtnSendBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnSendBack.TabIndex = 62
        Me.BtnSendBack.TabStop = False
        Me.BtnSendBack.Zoom = 10
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.Location = New System.Drawing.Point(456, 63)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(83, 23)
        Me.MetroLabel1.TabIndex = 59
        Me.MetroLabel1.Text = "Printable List"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        '
        'MetroLink1
        '
        Me.MetroLink1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLink1.AutoSize = True
        Me.MetroLink1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLink1.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.MetroLink1.Location = New System.Drawing.Point(631, 63)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(57, 23)
        Me.MetroLink1.TabIndex = 63
        Me.MetroLink1.Text = "Clear All"
        Me.MetroLink1.UseCustomBackColor = True
        Me.MetroLink1.UseSelectable = True
        Me.MetroLink1.UseStyleColors = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 468)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(205, 15)
        Me.MetroLabel3.TabIndex = 64
        Me.MetroLabel3.Text = "Step 1 : Select and check on this data list"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.Location = New System.Drawing.Point(456, 468)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(222, 15)
        Me.MetroLabel4.TabIndex = 64
        Me.MetroLabel4.Text = "Step 2 : Evaluation ID Code that will to print"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.Location = New System.Drawing.Point(696, 468)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(161, 15)
        Me.MetroLabel5.TabIndex = 64
        Me.MetroLabel5.Text = "Step 3 : Click button to Printing"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Location = New System.Drawing.Point(23, 63)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(83, 23)
        Me.MetroLabel6.TabIndex = 59
        Me.MetroLabel6.Text = "Data List"
        Me.MetroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelPrinter
        '
        Me.LabelPrinter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelPrinter.BackColor = System.Drawing.Color.Transparent
        Me.LabelPrinter.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LabelPrinter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelPrinter.Location = New System.Drawing.Point(696, 317)
        Me.LabelPrinter.Name = "LabelPrinter"
        Me.LabelPrinter.Size = New System.Drawing.Size(208, 23)
        Me.LabelPrinter.TabIndex = 78
        Me.LabelPrinter.Text = "..."
        Me.LabelPrinter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelPrinter.UseCustomBackColor = True
        Me.LabelPrinter.UseSelectable = True
        Me.LabelPrinter.UseStyleColors = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label9.Location = New System.Drawing.Point(696, 303)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 15)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "Termal Printer :"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(696, 188)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(165, 38)
        Me.MetroLabel8.TabIndex = 81
        Me.MetroLabel8.Text = "2. Tranfer or Send back To " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Printable List"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel9.Location = New System.Drawing.Point(711, 233)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(81, 15)
        Me.MetroLabel9.TabIndex = 80
        Me.MetroLabel9.Text = "Printed Count"
        Me.MetroLabel9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelMark
        '
        Me.LabelMark.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelMark.AutoSize = True
        Me.LabelMark.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelMark.ForeColor = System.Drawing.Color.DarkGray
        Me.LabelMark.Location = New System.Drawing.Point(696, 388)
        Me.LabelMark.Name = "LabelMark"
        Me.LabelMark.Size = New System.Drawing.Size(25, 15)
        Me.LabelMark.TabIndex = 82
        Me.LabelMark.Text = "LA1"
        Me.LabelMark.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LabelMark.UseCustomForeColor = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(696, 259)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(123, 19)
        Me.MetroLabel7.TabIndex = 83
        Me.MetroLabel7.Text = "3. Number of Copy"
        '
        'trequestcopy
        '
        Me.trequestcopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.trequestcopy.CustomButton.Image = Nothing
        Me.trequestcopy.CustomButton.Location = New System.Drawing.Point(19, 1)
        Me.trequestcopy.CustomButton.Name = ""
        Me.trequestcopy.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.trequestcopy.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.trequestcopy.CustomButton.TabIndex = 1
        Me.trequestcopy.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.trequestcopy.CustomButton.UseSelectable = True
        Me.trequestcopy.CustomButton.Visible = False
        Me.trequestcopy.Lines = New String() {"1"}
        Me.trequestcopy.Location = New System.Drawing.Point(828, 259)
        Me.trequestcopy.MaxLength = 32767
        Me.trequestcopy.Name = "trequestcopy"
        Me.trequestcopy.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.trequestcopy.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.trequestcopy.SelectedText = ""
        Me.trequestcopy.SelectionLength = 0
        Me.trequestcopy.SelectionStart = 0
        Me.trequestcopy.ShortcutsEnabled = True
        Me.trequestcopy.Size = New System.Drawing.Size(41, 23)
        Me.trequestcopy.TabIndex = 84
        Me.trequestcopy.Text = "1"
        Me.trequestcopy.UseSelectable = True
        Me.trequestcopy.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.trequestcopy.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLink2
        '
        Me.MetroLink2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLink2.AutoSize = True
        Me.MetroLink2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLink2.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.MetroLink2.Location = New System.Drawing.Point(166, 63)
        Me.MetroLink2.Name = "MetroLink2"
        Me.MetroLink2.Size = New System.Drawing.Size(92, 23)
        Me.MetroLink2.TabIndex = 85
        Me.MetroLink2.Text = "Fillter To Print"
        Me.MetroToolTip1.SetToolTip(Me.MetroLink2, "Data Grid will fillter Harvest date from today and print is null")
        Me.MetroLink2.UseCustomBackColor = True
        Me.MetroLink2.UseSelectable = True
        Me.MetroLink2.UseStyleColors = True
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'Report_a1TableAdapter
        '
        Me.Report_a1TableAdapter.ClearBeforeFill = True
        '
        'Report_Label_Production
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 503)
        Me.Controls.Add(Me.MetroLink2)
        Me.Controls.Add(Me.trequestcopy)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.LabelMark)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.LabelPrinter)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLink1)
        Me.Controls.Add(Me.BtnSendBack)
        Me.Controls.Add(Me.BtnSend)
        Me.Controls.Add(Me.MetroGrid2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelCount)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.BtnPreview)
        Me.Controls.Add(Me.LInkRefresh)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Name = "Report_Label_Production"
        Me.Text = "Report Label Production"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reporta1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSendBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroGrid1 As MetroGrid
    Friend WithEvents CheckBox1 As MetroCheckBox
    Friend WithEvents LInkRefresh As MetroLink
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroLabel2 As MetroLabel
    Friend WithEvents BtnPreview As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents LabelCount As MetroLabel
    Friend WithEvents HCQC_NewDataset As HCQC_NewDataset
    Friend WithEvents Reporta1BindingSource As BindingSource
    Friend WithEvents Report_a1TableAdapter As HCQC_NewDatasetTableAdapters.report_a1TableAdapter
    Friend WithEvents MetroGrid2 As MetroGrid
    Friend WithEvents BtnSend As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BtnSendBack As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents MetroLabel1 As MetroLabel
    Friend WithEvents MetroStyleExtender1 As Components.MetroStyleExtender
    Friend WithEvents MetroStyleManager1 As Components.MetroStyleManager
    Friend WithEvents MetroLink1 As MetroLink
    Friend WithEvents MetroLabel4 As MetroLabel
    Friend WithEvents MetroLabel3 As MetroLabel
    Friend WithEvents MetroLabel5 As MetroLabel
    Friend WithEvents MetroLabel6 As MetroLabel
    Friend WithEvents LabelPrinter As MetroLink
    Friend WithEvents Label9 As MetroLabel
    Friend WithEvents MetroLabel8 As MetroLabel
    Friend WithEvents MetroLabel9 As MetroLabel
    Friend WithEvents LabelMark As MetroLabel
    Friend WithEvents KontrakColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents trequestcopy As MetroTextBox
    Friend WithEvents MetroLabel7 As MetroLabel
    Friend WithEvents MetroLink2 As MetroLink
    Friend WithEvents MetroToolTip1 As Components.MetroToolTip
    Friend WithEvents CekColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IdColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarietyColumn As DataGridViewTextBoxColumn
    Friend WithEvents CropColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlantColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContractColumn As DataGridViewTextBoxColumn
    Friend WithEvents HarvestColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents CheckColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IdcodeColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents areaColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarietyColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CropColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents norencanaColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents HarvestColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ContractColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CgrColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Count As DataGridViewTextBoxColumn
    Friend WithEvents LastPrint As DataGridViewTextBoxColumn
End Class
