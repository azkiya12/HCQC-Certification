<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrintZPL
    Inherits System.Windows.Forms.Form

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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.DatasetBarCode = New WindowsApp1.DatasetBarCode()
        Me.QcconfirmviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Qc_confirm_viewTableAdapter = New WindowsApp1.DatasetBarCodeTableAdapters.qc_confirm_viewTableAdapter()
        Me.CheckColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarietyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FarmerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HarvestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomnlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NojobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScopeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamareqDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InputdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaconDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglconfirmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LabnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamappcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglkirimDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RafaksiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OfficerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdhvsprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestsamplingDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestmoiDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestpurDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestgerDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestviaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestrafDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CropDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LA2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LA3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LA4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatasetBarCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QcconfirmviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckColumn, Me.IdDataGridViewTextBoxColumn, Me.VarietyDataGridViewTextBoxColumn, Me.FarmerDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.HarvestDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.NomnlDataGridViewTextBoxColumn, Me.NojobDataGridViewTextBoxColumn, Me.ScopeDataGridViewTextBoxColumn, Me.NamareqDataGridViewTextBoxColumn, Me.InputdateDataGridViewTextBoxColumn, Me.NamaconDataGridViewTextBoxColumn, Me.TglconfirmDataGridViewTextBoxColumn, Me.StatusDataGridViewCheckBoxColumn, Me.LabnumDataGridViewTextBoxColumn, Me.NamappcDataGridViewTextBoxColumn, Me.TglkirimDataGridViewTextBoxColumn, Me.RafaksiDataGridViewTextBoxColumn, Me.OfficerDataGridViewTextBoxColumn, Me.RemarkDataGridViewTextBoxColumn, Me.TglDataGridViewTextBoxColumn, Me.IdhvsprodDataGridViewTextBoxColumn, Me.TestsamplingDataGridViewCheckBoxColumn, Me.TestmoiDataGridViewCheckBoxColumn, Me.TestpurDataGridViewCheckBoxColumn, Me.TestgerDataGridViewCheckBoxColumn, Me.TestviaDataGridViewCheckBoxColumn, Me.TestrafDataGridViewCheckBoxColumn, Me.CropDataGridViewTextBoxColumn, Me.LA2DataGridViewTextBoxColumn, Me.LA3DataGridViewTextBoxColumn, Me.LA4DataGridViewTextBoxColumn})
        Me.MetroGrid1.DataSource = Me.QcconfirmviewBindingSource
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
        Me.MetroGrid1.Location = New System.Drawing.Point(12, 12)
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
        Me.MetroGrid1.Size = New System.Drawing.Size(490, 284)
        Me.MetroGrid1.TabIndex = 0
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(619, 218)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(125, 37)
        Me.MetroButton1.TabIndex = 1
        Me.MetroButton1.Text = "MetroButton1"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(519, 35)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Printer Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(516, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(638, 22)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(125, 32)
        Me.MetroButton2.TabIndex = 1
        Me.MetroButton2.Text = "MetroButton1"
        Me.MetroButton2.UseSelectable = True
        '
        'DatasetBarCode
        '
        Me.DatasetBarCode.DataSetName = "DatasetBarCode"
        Me.DatasetBarCode.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QcconfirmviewBindingSource
        '
        Me.QcconfirmviewBindingSource.DataMember = "qc_confirm_view"
        Me.QcconfirmviewBindingSource.DataSource = Me.DatasetBarCode
        '
        'Qc_confirm_viewTableAdapter
        '
        Me.Qc_confirm_viewTableAdapter.ClearBeforeFill = True
        '
        'CheckColumn
        '
        Me.CheckColumn.HeaderText = ""
        Me.CheckColumn.Name = "CheckColumn"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'VarietyDataGridViewTextBoxColumn
        '
        Me.VarietyDataGridViewTextBoxColumn.DataPropertyName = "variety"
        Me.VarietyDataGridViewTextBoxColumn.HeaderText = "variety"
        Me.VarietyDataGridViewTextBoxColumn.Name = "VarietyDataGridViewTextBoxColumn"
        '
        'FarmerDataGridViewTextBoxColumn
        '
        Me.FarmerDataGridViewTextBoxColumn.DataPropertyName = "farmer"
        Me.FarmerDataGridViewTextBoxColumn.HeaderText = "farmer"
        Me.FarmerDataGridViewTextBoxColumn.Name = "FarmerDataGridViewTextBoxColumn"
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "location"
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        '
        'HarvestDataGridViewTextBoxColumn
        '
        Me.HarvestDataGridViewTextBoxColumn.DataPropertyName = "harvest"
        Me.HarvestDataGridViewTextBoxColumn.HeaderText = "harvest"
        Me.HarvestDataGridViewTextBoxColumn.Name = "HarvestDataGridViewTextBoxColumn"
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "weight"
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        '
        'NomnlDataGridViewTextBoxColumn
        '
        Me.NomnlDataGridViewTextBoxColumn.DataPropertyName = "nomnl"
        Me.NomnlDataGridViewTextBoxColumn.HeaderText = "nomnl"
        Me.NomnlDataGridViewTextBoxColumn.Name = "NomnlDataGridViewTextBoxColumn"
        '
        'NojobDataGridViewTextBoxColumn
        '
        Me.NojobDataGridViewTextBoxColumn.DataPropertyName = "nojob"
        Me.NojobDataGridViewTextBoxColumn.HeaderText = "nojob"
        Me.NojobDataGridViewTextBoxColumn.Name = "NojobDataGridViewTextBoxColumn"
        '
        'ScopeDataGridViewTextBoxColumn
        '
        Me.ScopeDataGridViewTextBoxColumn.DataPropertyName = "scope"
        Me.ScopeDataGridViewTextBoxColumn.HeaderText = "scope"
        Me.ScopeDataGridViewTextBoxColumn.Name = "ScopeDataGridViewTextBoxColumn"
        '
        'NamareqDataGridViewTextBoxColumn
        '
        Me.NamareqDataGridViewTextBoxColumn.DataPropertyName = "nama_req"
        Me.NamareqDataGridViewTextBoxColumn.HeaderText = "nama_req"
        Me.NamareqDataGridViewTextBoxColumn.Name = "NamareqDataGridViewTextBoxColumn"
        '
        'InputdateDataGridViewTextBoxColumn
        '
        Me.InputdateDataGridViewTextBoxColumn.DataPropertyName = "input_date"
        Me.InputdateDataGridViewTextBoxColumn.HeaderText = "input_date"
        Me.InputdateDataGridViewTextBoxColumn.Name = "InputdateDataGridViewTextBoxColumn"
        '
        'NamaconDataGridViewTextBoxColumn
        '
        Me.NamaconDataGridViewTextBoxColumn.DataPropertyName = "nama_con"
        Me.NamaconDataGridViewTextBoxColumn.HeaderText = "nama_con"
        Me.NamaconDataGridViewTextBoxColumn.Name = "NamaconDataGridViewTextBoxColumn"
        '
        'TglconfirmDataGridViewTextBoxColumn
        '
        Me.TglconfirmDataGridViewTextBoxColumn.DataPropertyName = "tgl_confirm"
        Me.TglconfirmDataGridViewTextBoxColumn.HeaderText = "tgl_confirm"
        Me.TglconfirmDataGridViewTextBoxColumn.Name = "TglconfirmDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewCheckBoxColumn
        '
        Me.StatusDataGridViewCheckBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewCheckBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewCheckBoxColumn.Name = "StatusDataGridViewCheckBoxColumn"
        '
        'LabnumDataGridViewTextBoxColumn
        '
        Me.LabnumDataGridViewTextBoxColumn.DataPropertyName = "labnum"
        Me.LabnumDataGridViewTextBoxColumn.HeaderText = "labnum"
        Me.LabnumDataGridViewTextBoxColumn.Name = "LabnumDataGridViewTextBoxColumn"
        '
        'NamappcDataGridViewTextBoxColumn
        '
        Me.NamappcDataGridViewTextBoxColumn.DataPropertyName = "nama_ppc"
        Me.NamappcDataGridViewTextBoxColumn.HeaderText = "nama_ppc"
        Me.NamappcDataGridViewTextBoxColumn.Name = "NamappcDataGridViewTextBoxColumn"
        '
        'TglkirimDataGridViewTextBoxColumn
        '
        Me.TglkirimDataGridViewTextBoxColumn.DataPropertyName = "tgl_kirim"
        Me.TglkirimDataGridViewTextBoxColumn.HeaderText = "tgl_kirim"
        Me.TglkirimDataGridViewTextBoxColumn.Name = "TglkirimDataGridViewTextBoxColumn"
        '
        'RafaksiDataGridViewTextBoxColumn
        '
        Me.RafaksiDataGridViewTextBoxColumn.DataPropertyName = "rafaksi"
        Me.RafaksiDataGridViewTextBoxColumn.HeaderText = "rafaksi"
        Me.RafaksiDataGridViewTextBoxColumn.Name = "RafaksiDataGridViewTextBoxColumn"
        Me.RafaksiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OfficerDataGridViewTextBoxColumn
        '
        Me.OfficerDataGridViewTextBoxColumn.DataPropertyName = "officer"
        Me.OfficerDataGridViewTextBoxColumn.HeaderText = "officer"
        Me.OfficerDataGridViewTextBoxColumn.Name = "OfficerDataGridViewTextBoxColumn"
        '
        'RemarkDataGridViewTextBoxColumn
        '
        Me.RemarkDataGridViewTextBoxColumn.DataPropertyName = "remark"
        Me.RemarkDataGridViewTextBoxColumn.HeaderText = "remark"
        Me.RemarkDataGridViewTextBoxColumn.Name = "RemarkDataGridViewTextBoxColumn"
        '
        'TglDataGridViewTextBoxColumn
        '
        Me.TglDataGridViewTextBoxColumn.DataPropertyName = "tgl"
        Me.TglDataGridViewTextBoxColumn.HeaderText = "tgl"
        Me.TglDataGridViewTextBoxColumn.Name = "TglDataGridViewTextBoxColumn"
        '
        'IdhvsprodDataGridViewTextBoxColumn
        '
        Me.IdhvsprodDataGridViewTextBoxColumn.DataPropertyName = "id_hvsprod"
        Me.IdhvsprodDataGridViewTextBoxColumn.HeaderText = "id_hvsprod"
        Me.IdhvsprodDataGridViewTextBoxColumn.Name = "IdhvsprodDataGridViewTextBoxColumn"
        '
        'TestsamplingDataGridViewCheckBoxColumn
        '
        Me.TestsamplingDataGridViewCheckBoxColumn.DataPropertyName = "test_sampling"
        Me.TestsamplingDataGridViewCheckBoxColumn.HeaderText = "test_sampling"
        Me.TestsamplingDataGridViewCheckBoxColumn.Name = "TestsamplingDataGridViewCheckBoxColumn"
        Me.TestsamplingDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TestsamplingDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TestmoiDataGridViewCheckBoxColumn
        '
        Me.TestmoiDataGridViewCheckBoxColumn.DataPropertyName = "test_moi"
        Me.TestmoiDataGridViewCheckBoxColumn.HeaderText = "test_moi"
        Me.TestmoiDataGridViewCheckBoxColumn.Name = "TestmoiDataGridViewCheckBoxColumn"
        Me.TestmoiDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TestmoiDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TestpurDataGridViewCheckBoxColumn
        '
        Me.TestpurDataGridViewCheckBoxColumn.DataPropertyName = "test_pur"
        Me.TestpurDataGridViewCheckBoxColumn.HeaderText = "test_pur"
        Me.TestpurDataGridViewCheckBoxColumn.Name = "TestpurDataGridViewCheckBoxColumn"
        Me.TestpurDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TestpurDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TestgerDataGridViewCheckBoxColumn
        '
        Me.TestgerDataGridViewCheckBoxColumn.DataPropertyName = "test_ger"
        Me.TestgerDataGridViewCheckBoxColumn.HeaderText = "test_ger"
        Me.TestgerDataGridViewCheckBoxColumn.Name = "TestgerDataGridViewCheckBoxColumn"
        Me.TestgerDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TestgerDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TestviaDataGridViewCheckBoxColumn
        '
        Me.TestviaDataGridViewCheckBoxColumn.DataPropertyName = "test_via"
        Me.TestviaDataGridViewCheckBoxColumn.HeaderText = "test_via"
        Me.TestviaDataGridViewCheckBoxColumn.Name = "TestviaDataGridViewCheckBoxColumn"
        Me.TestviaDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TestviaDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TestrafDataGridViewCheckBoxColumn
        '
        Me.TestrafDataGridViewCheckBoxColumn.DataPropertyName = "test_raf"
        Me.TestrafDataGridViewCheckBoxColumn.HeaderText = "test_raf"
        Me.TestrafDataGridViewCheckBoxColumn.Name = "TestrafDataGridViewCheckBoxColumn"
        Me.TestrafDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TestrafDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CropDataGridViewTextBoxColumn
        '
        Me.CropDataGridViewTextBoxColumn.DataPropertyName = "crop"
        Me.CropDataGridViewTextBoxColumn.HeaderText = "crop"
        Me.CropDataGridViewTextBoxColumn.Name = "CropDataGridViewTextBoxColumn"
        '
        'LA2DataGridViewTextBoxColumn
        '
        Me.LA2DataGridViewTextBoxColumn.DataPropertyName = "LA2"
        Me.LA2DataGridViewTextBoxColumn.HeaderText = "LA2"
        Me.LA2DataGridViewTextBoxColumn.Name = "LA2DataGridViewTextBoxColumn"
        '
        'LA3DataGridViewTextBoxColumn
        '
        Me.LA3DataGridViewTextBoxColumn.DataPropertyName = "LA3"
        Me.LA3DataGridViewTextBoxColumn.HeaderText = "LA3"
        Me.LA3DataGridViewTextBoxColumn.Name = "LA3DataGridViewTextBoxColumn"
        '
        'LA4DataGridViewTextBoxColumn
        '
        Me.LA4DataGridViewTextBoxColumn.DataPropertyName = "LA4"
        Me.LA4DataGridViewTextBoxColumn.HeaderText = "LA4"
        Me.LA4DataGridViewTextBoxColumn.Name = "LA4DataGridViewTextBoxColumn"
        '
        'PrintZPL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 308)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Name = "PrintZPL"
        Me.Text = "Zebra Tech Support"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatasetBarCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QcconfirmviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents DatasetBarCode As DatasetBarCode
    Friend WithEvents QcconfirmviewBindingSource As BindingSource
    Friend WithEvents Qc_confirm_viewTableAdapter As DatasetBarCodeTableAdapters.qc_confirm_viewTableAdapter
    Friend WithEvents CheckColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarietyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FarmerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HarvestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomnlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NojobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScopeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamareqDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InputdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaconDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TglconfirmDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents LabnumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamappcDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TglkirimDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RafaksiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OfficerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemarkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TglDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdhvsprodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestsamplingDataGridViewCheckBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestmoiDataGridViewCheckBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestpurDataGridViewCheckBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestgerDataGridViewCheckBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestviaDataGridViewCheckBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestrafDataGridViewCheckBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CropDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LA2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LA3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LA4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
