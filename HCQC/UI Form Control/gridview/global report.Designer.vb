<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class global_report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(global_report))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.ReportglobalviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_serverDataSet = New WindowsApplication1.HCQC_serverDataSet()
        Me.Report_global_viewTableAdapter = New WindowsApplication1.HCQC_serverDataSetTableAdapters.report_global_viewTableAdapter()
        Me.LabnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductionCodeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarietyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FarmerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HarvestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomnlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NojobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScopeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoimeanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pureColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RaftotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViameanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportglobalviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.BorderRadius = 0
        Me.BtnSave.ButtonText = "Refresh"
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
        Me.BtnSave.Location = New System.Drawing.Point(23, 63)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSave.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnSave.selected = True
        Me.BtnSave.Size = New System.Drawing.Size(126, 30)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "Refresh"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Textcolor = System.Drawing.Color.White
        Me.BtnSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LabnumDataGridViewTextBoxColumn, Me.ProductionCodeColumn, Me.VarietyDataGridViewTextBoxColumn, Me.FarmerDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.HarvestDataGridViewTextBoxColumn, Me.NomnlDataGridViewTextBoxColumn, Me.NojobDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.ScopeDataGridViewTextBoxColumn, Me.DateinDataGridViewTextBoxColumn, Me.MoimeanDataGridViewTextBoxColumn, Me.pureColumn, Me.DtDataGridViewTextBoxColumn, Me.RaftotalDataGridViewTextBoxColumn, Me.ViameanDataGridViewTextBoxColumn})
        Me.MetroGrid1.DataSource = Me.ReportglobalviewBindingSource
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
        Me.MetroGrid1.GridColor = System.Drawing.Color.White
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
        Me.MetroGrid1.Size = New System.Drawing.Size(908, 328)
        Me.MetroGrid1.TabIndex = 3
        Me.MetroGrid1.VirtualMode = True
        '
        'ReportglobalviewBindingSource
        '
        Me.ReportglobalviewBindingSource.DataMember = "report_global_view"
        Me.ReportglobalviewBindingSource.DataSource = Me.HCQC_serverDataSet
        '
        'HCQC_serverDataSet
        '
        Me.HCQC_serverDataSet.DataSetName = "HCQC_serverDataSet"
        Me.HCQC_serverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Report_global_viewTableAdapter
        '
        Me.Report_global_viewTableAdapter.ClearBeforeFill = True
        '
        'LabnumDataGridViewTextBoxColumn
        '
        Me.LabnumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.LabnumDataGridViewTextBoxColumn.DataPropertyName = "labnum"
        Me.LabnumDataGridViewTextBoxColumn.HeaderText = "Lab Number"
        Me.LabnumDataGridViewTextBoxColumn.MinimumWidth = 50
        Me.LabnumDataGridViewTextBoxColumn.Name = "LabnumDataGridViewTextBoxColumn"
        Me.LabnumDataGridViewTextBoxColumn.Width = 50
        '
        'ProductionCodeColumn
        '
        Me.ProductionCodeColumn.DataPropertyName = "id_hvsprod"
        Me.ProductionCodeColumn.HeaderText = "Production Code"
        Me.ProductionCodeColumn.Name = "ProductionCodeColumn"
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
        Me.NomnlDataGridViewTextBoxColumn.HeaderText = "Manual No"
        Me.NomnlDataGridViewTextBoxColumn.Name = "NomnlDataGridViewTextBoxColumn"
        Me.NomnlDataGridViewTextBoxColumn.Width = 70
        '
        'NojobDataGridViewTextBoxColumn
        '
        Me.NojobDataGridViewTextBoxColumn.DataPropertyName = "nojob"
        Me.NojobDataGridViewTextBoxColumn.HeaderText = "Lot/Job"
        Me.NojobDataGridViewTextBoxColumn.Name = "NojobDataGridViewTextBoxColumn"
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "Weight (kg)"
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        Me.WeightDataGridViewTextBoxColumn.Width = 70
        '
        'ScopeDataGridViewTextBoxColumn
        '
        Me.ScopeDataGridViewTextBoxColumn.DataPropertyName = "scope"
        Me.ScopeDataGridViewTextBoxColumn.HeaderText = "Scope"
        Me.ScopeDataGridViewTextBoxColumn.Name = "ScopeDataGridViewTextBoxColumn"
        '
        'DateinDataGridViewTextBoxColumn
        '
        Me.DateinDataGridViewTextBoxColumn.DataPropertyName = "datein"
        Me.DateinDataGridViewTextBoxColumn.HeaderText = "Sample Received"
        Me.DateinDataGridViewTextBoxColumn.Name = "DateinDataGridViewTextBoxColumn"
        '
        'MoimeanDataGridViewTextBoxColumn
        '
        Me.MoimeanDataGridViewTextBoxColumn.DataPropertyName = "moi_mean"
        Me.MoimeanDataGridViewTextBoxColumn.HeaderText = "Moisture (%)"
        Me.MoimeanDataGridViewTextBoxColumn.Name = "MoimeanDataGridViewTextBoxColumn"
        '
        'pureColumn
        '
        Me.pureColumn.DataPropertyName = "pure"
        Me.pureColumn.HeaderText = "Purity (%)"
        Me.pureColumn.Name = "pureColumn"
        '
        'DtDataGridViewTextBoxColumn
        '
        Me.DtDataGridViewTextBoxColumn.DataPropertyName = "dt"
        Me.DtDataGridViewTextBoxColumn.HeaderText = "Germination (%)"
        Me.DtDataGridViewTextBoxColumn.Name = "DtDataGridViewTextBoxColumn"
        '
        'RaftotalDataGridViewTextBoxColumn
        '
        Me.RaftotalDataGridViewTextBoxColumn.DataPropertyName = "raf_total"
        Me.RaftotalDataGridViewTextBoxColumn.HeaderText = "Rafaction (%)"
        Me.RaftotalDataGridViewTextBoxColumn.Name = "RaftotalDataGridViewTextBoxColumn"
        Me.RaftotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ViameanDataGridViewTextBoxColumn
        '
        Me.ViameanDataGridViewTextBoxColumn.DataPropertyName = "via_mean"
        Me.ViameanDataGridViewTextBoxColumn.HeaderText = "Viability (%)"
        Me.ViameanDataGridViewTextBoxColumn.Name = "ViameanDataGridViewTextBoxColumn"
        '
        'global_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 450)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Controls.Add(Me.BtnSave)
        Me.Name = "global_report"
        Me.Text = "Global Report"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportglobalviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MetroGrid1 As MetroGrid
    Friend WithEvents CropDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CroptypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LotidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LotqttDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HCQC_serverDataSet As HCQC_serverDataSet
    Friend WithEvents ReportglobalviewBindingSource As BindingSource
    Friend WithEvents Report_global_viewTableAdapter As HCQC_serverDataSetTableAdapters.report_global_viewTableAdapter
    Friend WithEvents LabnumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductionCodeColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarietyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FarmerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HarvestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomnlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NojobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScopeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MoimeanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents pureColumn As DataGridViewTextBoxColumn
    Friend WithEvents DtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RaftotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ViameanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
