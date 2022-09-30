<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Termal_Print_Label_HCQC
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
        Me.QcconfirmviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_NewDataset = New WindowsApplication1.HCQC_NewDataset()
        Me.Qc_confirm_viewTableAdapter = New WindowsApplication1.HCQC_NewDatasetTableAdapters.qc_confirm_viewTableAdapter()
        Me.LA4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LA3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LA2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CropDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestrafDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TestviaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TestgerDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TestpurDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TestmoiDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TestsamplingDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RemarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglconfirmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaconDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamareqDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScopeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NojobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomnlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HarvestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FarmerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarietyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdhvsprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        CType(Me.QcconfirmviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QcconfirmviewBindingSource
        '
        Me.QcconfirmviewBindingSource.DataMember = "qc_confirm_view"
        Me.QcconfirmviewBindingSource.DataSource = Me.HCQC_NewDataset
        '
        'HCQC_NewDataset
        '
        Me.HCQC_NewDataset.DataSetName = "HCQC_NewDataset"
        Me.HCQC_NewDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Qc_confirm_viewTableAdapter
        '
        Me.Qc_confirm_viewTableAdapter.ClearBeforeFill = True
        '
        'LA4DataGridViewTextBoxColumn
        '
        Me.LA4DataGridViewTextBoxColumn.DataPropertyName = "LA4"
        Me.LA4DataGridViewTextBoxColumn.HeaderText = "LA4"
        Me.LA4DataGridViewTextBoxColumn.Name = "LA4DataGridViewTextBoxColumn"
        '
        'LA3DataGridViewTextBoxColumn
        '
        Me.LA3DataGridViewTextBoxColumn.DataPropertyName = "LA3"
        Me.LA3DataGridViewTextBoxColumn.HeaderText = "LA3"
        Me.LA3DataGridViewTextBoxColumn.Name = "LA3DataGridViewTextBoxColumn"
        '
        'LA2DataGridViewTextBoxColumn
        '
        Me.LA2DataGridViewTextBoxColumn.DataPropertyName = "LA2"
        Me.LA2DataGridViewTextBoxColumn.HeaderText = "LA2"
        Me.LA2DataGridViewTextBoxColumn.Name = "LA2DataGridViewTextBoxColumn"
        '
        'CropDataGridViewTextBoxColumn
        '
        Me.CropDataGridViewTextBoxColumn.DataPropertyName = "crop"
        Me.CropDataGridViewTextBoxColumn.HeaderText = "Crop"
        Me.CropDataGridViewTextBoxColumn.Name = "CropDataGridViewTextBoxColumn"
        '
        'TestrafDataGridViewCheckBoxColumn
        '
        Me.TestrafDataGridViewCheckBoxColumn.DataPropertyName = "test_raf"
        Me.TestrafDataGridViewCheckBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TestrafDataGridViewCheckBoxColumn.HeaderText = "test_raf"
        Me.TestrafDataGridViewCheckBoxColumn.Name = "TestrafDataGridViewCheckBoxColumn"
        '
        'TestviaDataGridViewCheckBoxColumn
        '
        Me.TestviaDataGridViewCheckBoxColumn.DataPropertyName = "test_via"
        Me.TestviaDataGridViewCheckBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TestviaDataGridViewCheckBoxColumn.HeaderText = "test_via"
        Me.TestviaDataGridViewCheckBoxColumn.Name = "TestviaDataGridViewCheckBoxColumn"
        '
        'TestgerDataGridViewCheckBoxColumn
        '
        Me.TestgerDataGridViewCheckBoxColumn.DataPropertyName = "test_ger"
        Me.TestgerDataGridViewCheckBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TestgerDataGridViewCheckBoxColumn.HeaderText = "test_ger"
        Me.TestgerDataGridViewCheckBoxColumn.Name = "TestgerDataGridViewCheckBoxColumn"
        '
        'TestpurDataGridViewCheckBoxColumn
        '
        Me.TestpurDataGridViewCheckBoxColumn.DataPropertyName = "test_pur"
        Me.TestpurDataGridViewCheckBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TestpurDataGridViewCheckBoxColumn.HeaderText = "test_pur"
        Me.TestpurDataGridViewCheckBoxColumn.Name = "TestpurDataGridViewCheckBoxColumn"
        '
        'TestmoiDataGridViewCheckBoxColumn
        '
        Me.TestmoiDataGridViewCheckBoxColumn.DataPropertyName = "test_moi"
        Me.TestmoiDataGridViewCheckBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TestmoiDataGridViewCheckBoxColumn.HeaderText = "test_moi"
        Me.TestmoiDataGridViewCheckBoxColumn.Name = "TestmoiDataGridViewCheckBoxColumn"
        '
        'TestsamplingDataGridViewCheckBoxColumn
        '
        Me.TestsamplingDataGridViewCheckBoxColumn.DataPropertyName = "test_sampling"
        Me.TestsamplingDataGridViewCheckBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TestsamplingDataGridViewCheckBoxColumn.HeaderText = "test_sampling"
        Me.TestsamplingDataGridViewCheckBoxColumn.Name = "TestsamplingDataGridViewCheckBoxColumn"
        '
        'RemarkDataGridViewTextBoxColumn
        '
        Me.RemarkDataGridViewTextBoxColumn.DataPropertyName = "remark"
        Me.RemarkDataGridViewTextBoxColumn.HeaderText = "remark"
        Me.RemarkDataGridViewTextBoxColumn.Name = "RemarkDataGridViewTextBoxColumn"
        '
        'TglconfirmDataGridViewTextBoxColumn
        '
        Me.TglconfirmDataGridViewTextBoxColumn.DataPropertyName = "tgl_confirm"
        Me.TglconfirmDataGridViewTextBoxColumn.HeaderText = "tgl_confirm"
        Me.TglconfirmDataGridViewTextBoxColumn.Name = "TglconfirmDataGridViewTextBoxColumn"
        '
        'NamaconDataGridViewTextBoxColumn
        '
        Me.NamaconDataGridViewTextBoxColumn.DataPropertyName = "nama_con"
        Me.NamaconDataGridViewTextBoxColumn.HeaderText = "nama_conf"
        Me.NamaconDataGridViewTextBoxColumn.Name = "NamaconDataGridViewTextBoxColumn"
        '
        'NamareqDataGridViewTextBoxColumn
        '
        Me.NamareqDataGridViewTextBoxColumn.DataPropertyName = "nama_req"
        Me.NamareqDataGridViewTextBoxColumn.HeaderText = "nama_req"
        Me.NamareqDataGridViewTextBoxColumn.Name = "NamareqDataGridViewTextBoxColumn"
        '
        'ScopeDataGridViewTextBoxColumn
        '
        Me.ScopeDataGridViewTextBoxColumn.DataPropertyName = "scope"
        Me.ScopeDataGridViewTextBoxColumn.HeaderText = "Scope"
        Me.ScopeDataGridViewTextBoxColumn.Name = "ScopeDataGridViewTextBoxColumn"
        '
        'NojobDataGridViewTextBoxColumn
        '
        Me.NojobDataGridViewTextBoxColumn.DataPropertyName = "nojob"
        Me.NojobDataGridViewTextBoxColumn.HeaderText = "Job Sas"
        Me.NojobDataGridViewTextBoxColumn.Name = "NojobDataGridViewTextBoxColumn"
        '
        'NomnlDataGridViewTextBoxColumn
        '
        Me.NomnlDataGridViewTextBoxColumn.DataPropertyName = "nomnl"
        Me.NomnlDataGridViewTextBoxColumn.HeaderText = "Manual"
        Me.NomnlDataGridViewTextBoxColumn.Name = "NomnlDataGridViewTextBoxColumn"
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "Weight (kg)"
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        '
        'HarvestDataGridViewTextBoxColumn
        '
        Me.HarvestDataGridViewTextBoxColumn.DataPropertyName = "harvest"
        Me.HarvestDataGridViewTextBoxColumn.HeaderText = "Harvest"
        Me.HarvestDataGridViewTextBoxColumn.Name = "HarvestDataGridViewTextBoxColumn"
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        '
        'FarmerDataGridViewTextBoxColumn
        '
        Me.FarmerDataGridViewTextBoxColumn.DataPropertyName = "farmer"
        Me.FarmerDataGridViewTextBoxColumn.HeaderText = "Farmer"
        Me.FarmerDataGridViewTextBoxColumn.Name = "FarmerDataGridViewTextBoxColumn"
        '
        'VarietyDataGridViewTextBoxColumn
        '
        Me.VarietyDataGridViewTextBoxColumn.DataPropertyName = "variety"
        Me.VarietyDataGridViewTextBoxColumn.HeaderText = "Variety"
        Me.VarietyDataGridViewTextBoxColumn.Name = "VarietyDataGridViewTextBoxColumn"
        '
        'LabnumDataGridViewTextBoxColumn
        '
        Me.LabnumDataGridViewTextBoxColumn.DataPropertyName = "labnum"
        Me.LabnumDataGridViewTextBoxColumn.HeaderText = "ID QC"
        Me.LabnumDataGridViewTextBoxColumn.Name = "LabnumDataGridViewTextBoxColumn"
        '
        'IdhvsprodDataGridViewTextBoxColumn
        '
        Me.IdhvsprodDataGridViewTextBoxColumn.DataPropertyName = "id_hvsprod"
        Me.IdhvsprodDataGridViewTextBoxColumn.HeaderText = "ID Production"
        Me.IdhvsprodDataGridViewTextBoxColumn.Name = "IdhvsprodDataGridViewTextBoxColumn"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID Request"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'CheckColumn
        '
        Me.CheckColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckColumn.HeaderText = ""
        Me.CheckColumn.Name = "CheckColumn"
        Me.CheckColumn.Width = 40
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckColumn, Me.IdDataGridViewTextBoxColumn, Me.IdhvsprodDataGridViewTextBoxColumn, Me.LabnumDataGridViewTextBoxColumn, Me.VarietyDataGridViewTextBoxColumn, Me.FarmerDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.HarvestDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.NomnlDataGridViewTextBoxColumn, Me.NojobDataGridViewTextBoxColumn, Me.ScopeDataGridViewTextBoxColumn, Me.NamareqDataGridViewTextBoxColumn, Me.NamaconDataGridViewTextBoxColumn, Me.TglconfirmDataGridViewTextBoxColumn, Me.RemarkDataGridViewTextBoxColumn, Me.TestsamplingDataGridViewCheckBoxColumn, Me.TestmoiDataGridViewCheckBoxColumn, Me.TestpurDataGridViewCheckBoxColumn, Me.TestgerDataGridViewCheckBoxColumn, Me.TestviaDataGridViewCheckBoxColumn, Me.TestrafDataGridViewCheckBoxColumn, Me.CropDataGridViewTextBoxColumn, Me.LA2DataGridViewTextBoxColumn, Me.LA3DataGridViewTextBoxColumn, Me.LA4DataGridViewTextBoxColumn})
        Me.MetroGrid1.DataSource = Me.QcconfirmviewBindingSource
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
        Me.MetroGrid1.Size = New System.Drawing.Size(661, 340)
        Me.MetroGrid1.TabIndex = 1
        '
        'Termal_Print_Label_HCQC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 460)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Name = "Termal_Print_Label_HCQC"
        Me.Text = "Termal Print Label HCQC"
        CType(Me.QcconfirmviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HCQC_NewDataset As HCQC_NewDataset
    Friend WithEvents QcconfirmviewBindingSource As BindingSource
    Friend WithEvents Qc_confirm_viewTableAdapter As HCQC_NewDatasetTableAdapters.qc_confirm_viewTableAdapter
    Friend WithEvents LA4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LA3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LA2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CropDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestrafDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TestviaDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TestgerDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TestpurDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TestmoiDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TestsamplingDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents RemarkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TglconfirmDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaconDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamareqDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScopeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NojobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomnlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HarvestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FarmerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarietyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabnumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdhvsprodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CheckColumn As DataGridViewCheckBoxColumn
    Friend WithEvents MetroGrid1 As MetroGrid
End Class
