<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_List_Inspection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_List_Inspection))
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.HCQC_serverDataSet = New WindowsApplication1.HCQC_serverDataSet()
        Me.ReportinspectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Report_inspectionTableAdapter = New WindowsApplication1.HCQC_serverDataSetTableAdapters.report_inspectionTableAdapter()
        Me.LabnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarietyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FarmerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HarvestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScopeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DttDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnalysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VgmtdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Te1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Te2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Te3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Te4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeargDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeprcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglinputDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnRefresh = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportinspectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LabnumDataGridViewTextBoxColumn, Me.VarietyDataGridViewTextBoxColumn, Me.FarmerDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.HarvestDataGridViewTextBoxColumn, Me.ScopeDataGridViewTextBoxColumn, Me.DateinDataGridViewTextBoxColumn, Me.DttDataGridViewTextBoxColumn, Me.ContdateDataGridViewTextBoxColumn, Me.AnalysDataGridViewTextBoxColumn, Me.VgmtdDataGridViewTextBoxColumn, Me.Te1DataGridViewTextBoxColumn, Me.Te2DataGridViewTextBoxColumn, Me.Te3DataGridViewTextBoxColumn, Me.Te4DataGridViewTextBoxColumn, Me.TeargDataGridViewTextBoxColumn, Me.TeprcDataGridViewTextBoxColumn, Me.TglinputDataGridViewTextBoxColumn})
        Me.MetroGrid1.DataSource = Me.ReportinspectionBindingSource
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
        'HCQC_serverDataSet
        '
        Me.HCQC_serverDataSet.DataSetName = "HCQC_serverDataSet"
        Me.HCQC_serverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportinspectionBindingSource
        '
        Me.ReportinspectionBindingSource.DataMember = "report_inspection"
        Me.ReportinspectionBindingSource.DataSource = Me.HCQC_serverDataSet
        '
        'Report_inspectionTableAdapter
        '
        Me.Report_inspectionTableAdapter.ClearBeforeFill = True
        '
        'LabnumDataGridViewTextBoxColumn
        '
        Me.LabnumDataGridViewTextBoxColumn.DataPropertyName = "labnum"
        Me.LabnumDataGridViewTextBoxColumn.HeaderText = "Lab Num"
        Me.LabnumDataGridViewTextBoxColumn.Name = "LabnumDataGridViewTextBoxColumn"
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
        'ScopeDataGridViewTextBoxColumn
        '
        Me.ScopeDataGridViewTextBoxColumn.DataPropertyName = "scope"
        Me.ScopeDataGridViewTextBoxColumn.HeaderText = "Scope"
        Me.ScopeDataGridViewTextBoxColumn.Name = "ScopeDataGridViewTextBoxColumn"
        '
        'DateinDataGridViewTextBoxColumn
        '
        Me.DateinDataGridViewTextBoxColumn.DataPropertyName = "datein"
        Me.DateinDataGridViewTextBoxColumn.HeaderText = "Receipt"
        Me.DateinDataGridViewTextBoxColumn.Name = "DateinDataGridViewTextBoxColumn"
        '
        'DttDataGridViewTextBoxColumn
        '
        Me.DttDataGridViewTextBoxColumn.DataPropertyName = "Dt_t"
        Me.DttDataGridViewTextBoxColumn.HeaderText = "Date Test"
        Me.DttDataGridViewTextBoxColumn.Name = "DttDataGridViewTextBoxColumn"
        '
        'ContdateDataGridViewTextBoxColumn
        '
        Me.ContdateDataGridViewTextBoxColumn.DataPropertyName = "Cont_date"
        Me.ContdateDataGridViewTextBoxColumn.HeaderText = "Count Date"
        Me.ContdateDataGridViewTextBoxColumn.Name = "ContdateDataGridViewTextBoxColumn"
        '
        'AnalysDataGridViewTextBoxColumn
        '
        Me.AnalysDataGridViewTextBoxColumn.DataPropertyName = "analys"
        Me.AnalysDataGridViewTextBoxColumn.HeaderText = "Analyst"
        Me.AnalysDataGridViewTextBoxColumn.Name = "AnalysDataGridViewTextBoxColumn"
        '
        'VgmtdDataGridViewTextBoxColumn
        '
        Me.VgmtdDataGridViewTextBoxColumn.DataPropertyName = "vg_mtd"
        Me.VgmtdDataGridViewTextBoxColumn.HeaderText = "Method"
        Me.VgmtdDataGridViewTextBoxColumn.Name = "VgmtdDataGridViewTextBoxColumn"
        '
        'Te1DataGridViewTextBoxColumn
        '
        Me.Te1DataGridViewTextBoxColumn.DataPropertyName = "te1"
        Me.Te1DataGridViewTextBoxColumn.HeaderText = "Test 1"
        Me.Te1DataGridViewTextBoxColumn.Name = "Te1DataGridViewTextBoxColumn"
        Me.Te1DataGridViewTextBoxColumn.Width = 75
        '
        'Te2DataGridViewTextBoxColumn
        '
        Me.Te2DataGridViewTextBoxColumn.DataPropertyName = "te2"
        Me.Te2DataGridViewTextBoxColumn.HeaderText = "Test 2"
        Me.Te2DataGridViewTextBoxColumn.Name = "Te2DataGridViewTextBoxColumn"
        Me.Te2DataGridViewTextBoxColumn.Width = 75
        '
        'Te3DataGridViewTextBoxColumn
        '
        Me.Te3DataGridViewTextBoxColumn.DataPropertyName = "te3"
        Me.Te3DataGridViewTextBoxColumn.HeaderText = "Test 3"
        Me.Te3DataGridViewTextBoxColumn.Name = "Te3DataGridViewTextBoxColumn"
        Me.Te3DataGridViewTextBoxColumn.Width = 75
        '
        'Te4DataGridViewTextBoxColumn
        '
        Me.Te4DataGridViewTextBoxColumn.DataPropertyName = "te4"
        Me.Te4DataGridViewTextBoxColumn.HeaderText = "Test 4"
        Me.Te4DataGridViewTextBoxColumn.Name = "Te4DataGridViewTextBoxColumn"
        Me.Te4DataGridViewTextBoxColumn.Width = 75
        '
        'TeargDataGridViewTextBoxColumn
        '
        Me.TeargDataGridViewTextBoxColumn.DataPropertyName = "tearg"
        Me.TeargDataGridViewTextBoxColumn.HeaderText = "Average"
        Me.TeargDataGridViewTextBoxColumn.Name = "TeargDataGridViewTextBoxColumn"
        Me.TeargDataGridViewTextBoxColumn.Width = 75
        '
        'TeprcDataGridViewTextBoxColumn
        '
        Me.TeprcDataGridViewTextBoxColumn.DataPropertyName = "teprc"
        Me.TeprcDataGridViewTextBoxColumn.HeaderText = "Percn"
        Me.TeprcDataGridViewTextBoxColumn.Name = "TeprcDataGridViewTextBoxColumn"
        Me.TeprcDataGridViewTextBoxColumn.Width = 75
        '
        'TglinputDataGridViewTextBoxColumn
        '
        Me.TglinputDataGridViewTextBoxColumn.DataPropertyName = "tgl_input"
        Me.TglinputDataGridViewTextBoxColumn.HeaderText = "Input Date"
        Me.TglinputDataGridViewTextBoxColumn.Name = "TglinputDataGridViewTextBoxColumn"
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
        'Data_List_Inspection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Name = "Data_List_Inspection"
        Me.Text = "Data List Inspection Raw Material"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportinspectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroGrid1 As MetroGrid
    Friend WithEvents BtnRefresh As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents HCQC_serverDataSet As HCQC_serverDataSet
    Friend WithEvents ReportinspectionBindingSource As BindingSource
    Friend WithEvents Report_inspectionTableAdapter As HCQC_serverDataSetTableAdapters.report_inspectionTableAdapter
    Friend WithEvents LabnumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarietyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FarmerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HarvestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScopeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DttDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnalysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VgmtdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Te1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Te2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Te3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Te4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeargDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeprcDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TglinputDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
