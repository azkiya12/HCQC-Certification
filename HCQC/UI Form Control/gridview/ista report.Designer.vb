<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ista_report
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ista_report))
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.ReportistaviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_serverDataSet = New WindowsApplication1.HCQC_serverDataSet()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.Report_ista_viewTableAdapter = New WindowsApplication1.HCQC_serverDataSetTableAdapters.report_ista_viewTableAdapter()
        Me.LinkRefresh = New MetroFramework.Controls.MetroLink()
        Me.Tsearch = New MetroFramework.Controls.MetroTextBox()
        Me.DetailColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Labnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductionCodeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarietyColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FarmerColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HarvestColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomnlColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NojobColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScopeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateinColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.samplingColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConcludedColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MeanColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurityColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seedColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnQcPassColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportistaviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
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
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DetailColumn, Me.Labnum, Me.ProductionCodeColumn, Me.VarietyColumn, Me.FarmerColumn, Me.LocationColumn, Me.HarvestColumn, Me.NomnlColumn, Me.NojobColumn, Me.WeightColumn, Me.ScopeColumn, Me.DateinColumn, Me.samplingColumn, Me.ConcludedColumn, Me.MeanColumn, Me.PurityColumn, Me.seedColumn, Me.DtColumn, Me.BtnQcPassColumn})
        Me.MetroGrid1.DataSource = Me.ReportistaviewBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(23, 89)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(900, 338)
        Me.MetroGrid1.TabIndex = 0
        '
        'ReportistaviewBindingSource
        '
        Me.ReportistaviewBindingSource.DataMember = "report_ista_view"
        Me.ReportistaviewBindingSource.DataSource = Me.HCQC_serverDataSet
        '
        'HCQC_serverDataSet
        '
        Me.HCQC_serverDataSet.DataSetName = "HCQC_serverDataSet"
        Me.HCQC_serverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        '
        'Report_ista_viewTableAdapter
        '
        Me.Report_ista_viewTableAdapter.ClearBeforeFill = True
        '
        'LinkRefresh
        '
        Me.LinkRefresh.AutoSize = True
        Me.LinkRefresh.BackColor = System.Drawing.Color.Transparent
        Me.LinkRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkRefresh.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.LinkRefresh.Location = New System.Drawing.Point(23, 60)
        Me.LinkRefresh.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkRefresh.Name = "LinkRefresh"
        Me.LinkRefresh.Size = New System.Drawing.Size(70, 23)
        Me.LinkRefresh.TabIndex = 60
        Me.LinkRefresh.Text = "Refresh"
        Me.LinkRefresh.UseCustomBackColor = True
        Me.LinkRefresh.UseSelectable = True
        Me.LinkRefresh.UseStyleColors = True
        '
        'Tsearch
        '
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
        Me.Tsearch.Location = New System.Drawing.Point(96, 60)
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
        Me.Tsearch.TabIndex = 62
        Me.Tsearch.UseSelectable = True
        Me.Tsearch.WaterMark = "Search..."
        Me.Tsearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Tsearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'DetailColumn
        '
        Me.DetailColumn.DataPropertyName = "status"
        Me.DetailColumn.HeaderText = "Detail"
        Me.DetailColumn.Name = "DetailColumn"
        Me.DetailColumn.Text = "Detail"
        Me.DetailColumn.Width = 60
        '
        'Labnum
        '
        Me.Labnum.DataPropertyName = "labnum"
        Me.Labnum.HeaderText = "Lab Number"
        Me.Labnum.Name = "Labnum"
        '
        'ProductionCodeColumn
        '
        Me.ProductionCodeColumn.DataPropertyName = "id_hvsprod"
        Me.ProductionCodeColumn.HeaderText = "Production Code"
        Me.ProductionCodeColumn.Name = "ProductionCodeColumn"
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
        'NomnlColumn
        '
        Me.NomnlColumn.DataPropertyName = "nomnl"
        Me.NomnlColumn.HeaderText = "Manual"
        Me.NomnlColumn.Name = "NomnlColumn"
        '
        'NojobColumn
        '
        Me.NojobColumn.DataPropertyName = "nojob"
        Me.NojobColumn.HeaderText = "Lot/Job"
        Me.NojobColumn.Name = "NojobColumn"
        '
        'WeightColumn
        '
        Me.WeightColumn.DataPropertyName = "weight"
        Me.WeightColumn.HeaderText = "Weight (kg)"
        Me.WeightColumn.Name = "WeightColumn"
        '
        'ScopeColumn
        '
        Me.ScopeColumn.DataPropertyName = "scope"
        Me.ScopeColumn.HeaderText = "Scope"
        Me.ScopeColumn.Name = "ScopeColumn"
        '
        'DateinColumn
        '
        Me.DateinColumn.DataPropertyName = "datein"
        Me.DateinColumn.HeaderText = "Sample Received"
        Me.DateinColumn.Name = "DateinColumn"
        '
        'samplingColumn
        '
        Me.samplingColumn.DataPropertyName = "sampling"
        Me.samplingColumn.HeaderText = "Date of Sampling"
        Me.samplingColumn.Name = "samplingColumn"
        '
        'ConcludedColumn
        '
        Me.ConcludedColumn.DataPropertyName = "date_concl"
        Me.ConcludedColumn.HeaderText = "Date Concluded"
        Me.ConcludedColumn.Name = "ConcludedColumn"
        '
        'MeanColumn
        '
        Me.MeanColumn.DataPropertyName = "mean"
        Me.MeanColumn.HeaderText = "Moisture %"
        Me.MeanColumn.Name = "MeanColumn"
        '
        'PurityColumn
        '
        Me.PurityColumn.DataPropertyName = "pure"
        Me.PurityColumn.HeaderText = "Pure %"
        Me.PurityColumn.Name = "PurityColumn"
        Me.PurityColumn.ReadOnly = True
        '
        'seedColumn
        '
        Me.seedColumn.DataPropertyName = "1000seed"
        Me.seedColumn.HeaderText = "1000seed"
        Me.seedColumn.Name = "seedColumn"
        '
        'DtColumn
        '
        Me.DtColumn.DataPropertyName = "dt"
        Me.DtColumn.HeaderText = "Germination %"
        Me.DtColumn.Name = "DtColumn"
        '
        'BtnQcPassColumn
        '
        Me.BtnQcPassColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnQcPassColumn.HeaderText = "Conclution "
        Me.BtnQcPassColumn.Name = "BtnQcPassColumn"
        Me.BtnQcPassColumn.Text = "Button"
        Me.BtnQcPassColumn.UseColumnTextForButtonValue = True
        Me.BtnQcPassColumn.Width = 60
        '
        'ista_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 450)
        Me.Controls.Add(Me.Tsearch)
        Me.Controls.Add(Me.LinkRefresh)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ista_report"
        Me.Text = "Certification"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportistaviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroGrid1 As MetroGrid
    Friend WithEvents MetroStyleExtender1 As Components.MetroStyleExtender
    Friend WithEvents MetroStyleManager1 As Components.MetroStyleManager
    Friend WithEvents HCQC_serverDataSet As HCQC_serverDataSet
    Friend WithEvents ReportistaviewBindingSource As BindingSource
    Friend WithEvents Report_ista_viewTableAdapter As HCQC_serverDataSetTableAdapters.report_ista_viewTableAdapter
    Friend WithEvents LinkRefresh As MetroLink
    Friend WithEvents Tsearch As MetroTextBox
    Friend WithEvents DetailColumn As DataGridViewLinkColumn
    Friend WithEvents Labnum As DataGridViewTextBoxColumn
    Friend WithEvents ProductionCodeColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarietyColumn As DataGridViewTextBoxColumn
    Friend WithEvents FarmerColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationColumn As DataGridViewTextBoxColumn
    Friend WithEvents HarvestColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomnlColumn As DataGridViewTextBoxColumn
    Friend WithEvents NojobColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScopeColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateinColumn As DataGridViewTextBoxColumn
    Friend WithEvents samplingColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConcludedColumn As DataGridViewTextBoxColumn
    Friend WithEvents MeanColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurityColumn As DataGridViewTextBoxColumn
    Friend WithEvents seedColumn As DataGridViewTextBoxColumn
    Friend WithEvents DtColumn As DataGridViewTextBoxColumn
    Friend WithEvents BtnQcPassColumn As DataGridViewButtonColumn
End Class
