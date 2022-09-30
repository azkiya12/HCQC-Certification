<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Print_Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Print_Report))
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.LinkClearAll = New MetroFramework.Controls.MetroLink()
        Me.BtnSendBack = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnSend = New Bunifu.Framework.UI.BunifuImageButton()
        Me.MetroGrid2 = New MetroFramework.Controls.MetroGrid()
        Me.CheckColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LabNumberColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarietyColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManualColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScopeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.CheckBox1 = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.CheckColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarietyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CropDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FarmerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HarvestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomnlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NojobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScopeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiveddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportexternalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_NewDataset = New WindowsApplication1.HCQC_NewDataset()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.LabelMark2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LabelCount2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.BtnPreview2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.tSearchReturn = New MetroFramework.Controls.MetroTextBox()
        Me.Report_externalTableAdapter = New WindowsApplication1.HCQC_NewDatasetTableAdapters.report_externalTableAdapter()
        CType(Me.BtnSendBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportexternalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 465)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(205, 15)
        Me.MetroLabel5.TabIndex = 80
        Me.MetroLabel5.Text = "Step 1 : Select and check on this data list"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.Location = New System.Drawing.Point(567, 465)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(244, 15)
        Me.MetroLabel4.TabIndex = 79
        Me.MetroLabel4.Text = "Step 2 : Evaluation Lab Number that will to print"
        '
        'LinkClearAll
        '
        Me.LinkClearAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkClearAll.AutoSize = True
        Me.LinkClearAll.BackColor = System.Drawing.Color.Transparent
        Me.LinkClearAll.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkClearAll.Location = New System.Drawing.Point(742, 60)
        Me.LinkClearAll.Name = "LinkClearAll"
        Me.LinkClearAll.Size = New System.Drawing.Size(57, 23)
        Me.LinkClearAll.TabIndex = 78
        Me.LinkClearAll.Text = "Clear All"
        Me.LinkClearAll.UseCustomBackColor = True
        Me.LinkClearAll.UseSelectable = True
        Me.LinkClearAll.UseStyleColors = True
        '
        'BtnSendBack
        '
        Me.BtnSendBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSendBack.BackColor = System.Drawing.Color.Brown
        Me.BtnSendBack.Image = CType(resources.GetObject("BtnSendBack.Image"), System.Drawing.Image)
        Me.BtnSendBack.ImageActive = Nothing
        Me.BtnSendBack.Location = New System.Drawing.Point(522, 248)
        Me.BtnSendBack.Name = "BtnSendBack"
        Me.BtnSendBack.Size = New System.Drawing.Size(39, 24)
        Me.BtnSendBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnSendBack.TabIndex = 76
        Me.BtnSendBack.TabStop = False
        Me.BtnSendBack.Zoom = 10
        '
        'BtnSend
        '
        Me.BtnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSend.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnSend.Image = CType(resources.GetObject("BtnSend.Image"), System.Drawing.Image)
        Me.BtnSend.ImageActive = Nothing
        Me.BtnSend.Location = New System.Drawing.Point(522, 218)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(39, 24)
        Me.BtnSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnSend.TabIndex = 77
        Me.BtnSend.TabStop = False
        Me.BtnSend.Zoom = 10
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
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.MetroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckColumn1, Me.LabNumberColumn, Me.VarietyColumn, Me.ManualColumn, Me.LotColumn, Me.WeightColumn, Me.ScopeColumn})
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid2.DefaultCellStyle = DataGridViewCellStyle16
        Me.MetroGrid2.EnableHeadersVisualStyles = False
        Me.MetroGrid2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid2.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid2.Location = New System.Drawing.Point(567, 89)
        Me.MetroGrid2.Name = "MetroGrid2"
        Me.MetroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid2.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.MetroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid2.Size = New System.Drawing.Size(232, 366)
        Me.MetroGrid2.TabIndex = 75
        '
        'CheckColumn1
        '
        Me.CheckColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckColumn1.HeaderText = ""
        Me.CheckColumn1.Name = "CheckColumn1"
        Me.CheckColumn1.Width = 40
        '
        'LabNumberColumn
        '
        Me.LabNumberColumn.HeaderText = "Lab  Number"
        Me.LabNumberColumn.Name = "LabNumberColumn"
        Me.LabNumberColumn.ReadOnly = True
        '
        'VarietyColumn
        '
        Me.VarietyColumn.HeaderText = "Variety"
        Me.VarietyColumn.Name = "VarietyColumn"
        Me.VarietyColumn.ReadOnly = True
        '
        'ManualColumn
        '
        Me.ManualColumn.HeaderText = "Manual"
        Me.ManualColumn.Name = "ManualColumn"
        Me.ManualColumn.Width = 80
        '
        'LotColumn
        '
        Me.LotColumn.HeaderText = "Lot/Job"
        Me.LotColumn.Name = "LotColumn"
        Me.LotColumn.ReadOnly = True
        '
        'WeightColumn
        '
        Me.WeightColumn.HeaderText = "Weight (kg)"
        Me.WeightColumn.Name = "WeightColumn"
        Me.WeightColumn.ReadOnly = True
        '
        'ScopeColumn
        '
        Me.ScopeColumn.HeaderText = "Scope"
        Me.ScopeColumn.Name = "ScopeColumn"
        Me.ScopeColumn.ReadOnly = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Location = New System.Drawing.Point(23, 60)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(83, 23)
        Me.MetroLabel6.TabIndex = 74
        Me.MetroLabel6.Text = "Data List"
        Me.MetroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.Location = New System.Drawing.Point(189, 60)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(75, 23)
        Me.CheckBox1.TabIndex = 73
        Me.CheckBox1.Text = "Select All"
        Me.CheckBox1.UseSelectable = True
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MetroGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle18
        Me.MetroGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroGrid1.AutoGenerateColumns = False
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckColumn, Me.IdDataGridViewTextBoxColumn, Me.LabnumDataGridViewTextBoxColumn, Me.VarietyDataGridViewTextBoxColumn, Me.CropDataGridViewTextBoxColumn, Me.FarmerDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.HarvestDataGridViewTextBoxColumn, Me.NomnlDataGridViewTextBoxColumn, Me.NojobDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.ScopeDataGridViewTextBoxColumn, Me.ReceiveddateDataGridViewTextBoxColumn})
        Me.MetroGrid1.DataSource = Me.ReportexternalBindingSource
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle20
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(23, 89)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(493, 366)
        Me.MetroGrid1.TabIndex = 72
        '
        'CheckColumn
        '
        Me.CheckColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckColumn.HeaderText = ""
        Me.CheckColumn.Name = "CheckColumn"
        Me.CheckColumn.Width = 40
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Request ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Width = 60
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
        'CropDataGridViewTextBoxColumn
        '
        Me.CropDataGridViewTextBoxColumn.DataPropertyName = "crop"
        Me.CropDataGridViewTextBoxColumn.HeaderText = "Crop"
        Me.CropDataGridViewTextBoxColumn.Name = "CropDataGridViewTextBoxColumn"
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
        '
        'NojobDataGridViewTextBoxColumn
        '
        Me.NojobDataGridViewTextBoxColumn.DataPropertyName = "nojob"
        Me.NojobDataGridViewTextBoxColumn.HeaderText = "Lot/Job Sas"
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
        'ReceiveddateDataGridViewTextBoxColumn
        '
        Me.ReceiveddateDataGridViewTextBoxColumn.DataPropertyName = "received_date"
        Me.ReceiveddateDataGridViewTextBoxColumn.HeaderText = "Received Date"
        Me.ReceiveddateDataGridViewTextBoxColumn.Name = "ReceiveddateDataGridViewTextBoxColumn"
        '
        'ReportexternalBindingSource
        '
        Me.ReportexternalBindingSource.DataMember = "report_external"
        Me.ReportexternalBindingSource.DataSource = Me.HCQC_NewDataset
        '
        'HCQC_NewDataset
        '
        Me.HCQC_NewDataset.DataSetName = "HCQC_NewDataset"
        Me.HCQC_NewDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MetroLabel10
        '
        Me.MetroLabel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel10.Location = New System.Drawing.Point(834, 465)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(74, 15)
        Me.MetroLabel10.TabIndex = 96
        Me.MetroLabel10.Text = "Step 3 :  Print"
        '
        'LabelMark2
        '
        Me.LabelMark2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelMark2.AutoSize = True
        Me.LabelMark2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelMark2.ForeColor = System.Drawing.Color.DarkGray
        Me.LabelMark2.Location = New System.Drawing.Point(834, 382)
        Me.LabelMark2.Name = "LabelMark2"
        Me.LabelMark2.Size = New System.Drawing.Size(25, 15)
        Me.LabelMark2.TabIndex = 105
        Me.LabelMark2.Text = "LA1"
        Me.LabelMark2.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LabelMark2.UseCustomForeColor = True
        '
        'MetroLabel11
        '
        Me.MetroLabel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(834, 182)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(165, 38)
        Me.MetroLabel11.TabIndex = 104
        Me.MetroLabel11.Text = "2. Tranfer or Send back To " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Printable List"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel12.Location = New System.Drawing.Point(849, 257)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(84, 15)
        Me.MetroLabel12.TabIndex = 103
        Me.MetroLabel12.Text = "Printed Count"
        Me.MetroLabel12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(849, 108)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(158, 55)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 100
        Me.PictureBox2.TabStop = False
        '
        'LabelCount2
        '
        Me.LabelCount2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCount2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelCount2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LabelCount2.Location = New System.Drawing.Point(942, 257)
        Me.LabelCount2.Name = "LabelCount2"
        Me.LabelCount2.Size = New System.Drawing.Size(65, 15)
        Me.LabelCount2.TabIndex = 98
        Me.LabelCount2.Text = "..."
        Me.LabelCount2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MetroLabel15
        '
        Me.MetroLabel15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(834, 86)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(173, 19)
        Me.MetroLabel15.TabIndex = 99
        Me.MetroLabel15.Text = "1. Select kotak pada DataList"
        '
        'BtnPreview2
        '
        Me.BtnPreview2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnPreview2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPreview2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnPreview2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPreview2.BorderRadius = 0
        Me.BtnPreview2.ButtonText = "Preview Cetak"
        Me.BtnPreview2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPreview2.DisabledColor = System.Drawing.Color.Gray
        Me.BtnPreview2.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnPreview2.Iconimage = CType(resources.GetObject("BtnPreview2.Iconimage"), System.Drawing.Image)
        Me.BtnPreview2.Iconimage_right = Nothing
        Me.BtnPreview2.Iconimage_right_Selected = Nothing
        Me.BtnPreview2.Iconimage_Selected = Nothing
        Me.BtnPreview2.IconMarginLeft = 0
        Me.BtnPreview2.IconMarginRight = 0
        Me.BtnPreview2.IconRightVisible = False
        Me.BtnPreview2.IconRightZoom = 0R
        Me.BtnPreview2.IconVisible = False
        Me.BtnPreview2.IconZoom = 50.0R
        Me.BtnPreview2.IsTab = False
        Me.BtnPreview2.Location = New System.Drawing.Point(834, 349)
        Me.BtnPreview2.Name = "BtnPreview2"
        Me.BtnPreview2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnPreview2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPreview2.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnPreview2.selected = True
        Me.BtnPreview2.Size = New System.Drawing.Size(173, 30)
        Me.BtnPreview2.TabIndex = 97
        Me.BtnPreview2.Text = "Preview Cetak"
        Me.BtnPreview2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPreview2.Textcolor = System.Drawing.Color.White
        Me.BtnPreview2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tSearchReturn
        '
        Me.tSearchReturn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tSearchReturn.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.tSearchReturn.CustomButton.Location = New System.Drawing.Point(224, 1)
        Me.tSearchReturn.CustomButton.Name = ""
        Me.tSearchReturn.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tSearchReturn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tSearchReturn.CustomButton.TabIndex = 1
        Me.tSearchReturn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tSearchReturn.CustomButton.UseSelectable = True
        Me.tSearchReturn.ForeColor = System.Drawing.Color.Black
        Me.tSearchReturn.Lines = New String(-1) {}
        Me.tSearchReturn.Location = New System.Drawing.Point(270, 60)
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
        Me.tSearchReturn.TabIndex = 314
        Me.tSearchReturn.UseCustomForeColor = True
        Me.tSearchReturn.UseSelectable = True
        Me.tSearchReturn.WaterMark = "Search..."
        Me.tSearchReturn.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tSearchReturn.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Report_externalTableAdapter
        '
        Me.Report_externalTableAdapter.ClearBeforeFill = True
        '
        'Print_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 500)
        Me.Controls.Add(Me.tSearchReturn)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.LabelMark2)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.MetroLabel12)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LabelCount2)
        Me.Controls.Add(Me.MetroLabel15)
        Me.Controls.Add(Me.BtnPreview2)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.LinkClearAll)
        Me.Controls.Add(Me.BtnSendBack)
        Me.Controls.Add(Me.BtnSend)
        Me.Controls.Add(Me.MetroGrid2)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Name = "Print_Report"
        Me.Text = "Print Report"
        CType(Me.BtnSendBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportexternalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel5 As MetroLabel
    Friend WithEvents MetroLabel4 As MetroLabel
    Friend WithEvents LinkClearAll As MetroLink
    Friend WithEvents BtnSendBack As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BtnSend As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents MetroGrid2 As MetroGrid
    Friend WithEvents MetroLabel6 As MetroLabel
    Friend WithEvents CheckBox1 As MetroCheckBox
    Friend WithEvents MetroGrid1 As MetroGrid
    Friend WithEvents MetroLabel10 As MetroLabel
    Friend WithEvents LabelMark2 As MetroLabel
    Friend WithEvents MetroLabel11 As MetroLabel
    Friend WithEvents MetroLabel12 As MetroLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LabelCount2 As MetroLabel
    Friend WithEvents MetroLabel15 As MetroLabel
    Friend WithEvents BtnPreview2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents tSearchReturn As MetroTextBox
    Friend WithEvents HCQC_NewDataset As HCQC_NewDataset
    Friend WithEvents ReportexternalBindingSource As BindingSource
    Friend WithEvents Report_externalTableAdapter As HCQC_NewDatasetTableAdapters.report_externalTableAdapter
    Friend WithEvents CheckColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabnumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarietyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CropDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FarmerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HarvestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomnlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NojobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScopeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReceiveddateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CheckColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents LabNumberColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarietyColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManualColumn As DataGridViewTextBoxColumn
    Friend WithEvents LotColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScopeColumn As DataGridViewTextBoxColumn
End Class
