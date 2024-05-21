<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Periodic_Scedule
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Periodic_Scedule))
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.nojobColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnFilterDate = New Bunifu.Framework.UI.BunifuImageButton()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.EndDate = New System.Windows.Forms.DateTimePicker()
        Me.StartDate = New System.Windows.Forms.DateTimePicker()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.LinkRefresh = New MetroFramework.Controls.MetroLink()
        Me.LinkLastMonth = New MetroFramework.Controls.MetroLink()
        Me.LinkThisMonth = New MetroFramework.Controls.MetroLink()
        Me.LabnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarietyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HarvestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomnlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScopeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrtinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NexttestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportperiodicnextviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_serverDataSet = New HCQC_serverDataSet()
        Me.Report_periodicnext_viewTableAdapter = New HCQC_serverDataSetTableAdapters.report_periodicnext_viewTableAdapter()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFilterDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.ReportperiodicnextviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LabnumDataGridViewTextBoxColumn, Me.VarietyDataGridViewTextBoxColumn, Me.HarvestDataGridViewTextBoxColumn, Me.NomnlDataGridViewTextBoxColumn, Me.nojobColumn, Me.ScopeDataGridViewTextBoxColumn, Me.DateinDataGridViewTextBoxColumn, Me.BrtinDataGridViewTextBoxColumn, Me.RemarkDataGridViewTextBoxColumn, Me.TestdateDataGridViewTextBoxColumn, Me.TimeDataGridViewTextBoxColumn, Me.NexttestDataGridViewTextBoxColumn})
        Me.MetroGrid1.DataSource = Me.ReportperiodicnextviewBindingSource
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
        Me.MetroGrid1.Location = New System.Drawing.Point(24, 109)
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
        Me.MetroGrid1.Size = New System.Drawing.Size(754, 318)
        Me.MetroGrid1.TabIndex = 0
        '
        'nojobColumn
        '
        Me.nojobColumn.DataPropertyName = "nojob"
        Me.nojobColumn.HeaderText = "Lot/Job Sas"
        Me.nojobColumn.Name = "nojobColumn"
        '
        'BtnFilterDate
        '
        Me.BtnFilterDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnFilterDate.Image = CType(resources.GetObject("BtnFilterDate.Image"), System.Drawing.Image)
        Me.BtnFilterDate.ImageActive = Nothing
        Me.BtnFilterDate.Location = New System.Drawing.Point(497, 78)
        Me.BtnFilterDate.Name = "BtnFilterDate"
        Me.BtnFilterDate.Size = New System.Drawing.Size(31, 20)
        Me.BtnFilterDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnFilterDate.TabIndex = 164
        Me.BtnFilterDate.TabStop = False
        Me.BtnFilterDate.Zoom = 10
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel18.Location = New System.Drawing.Point(367, 81)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(12, 15)
        Me.MetroLabel18.TabIndex = 163
        Me.MetroLabel18.Text = "-"
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel16.Location = New System.Drawing.Point(385, 60)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(53, 15)
        Me.MetroLabel16.TabIndex = 162
        Me.MetroLabel16.Text = "End Date"
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel15.Location = New System.Drawing.Point(255, 60)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(59, 15)
        Me.MetroLabel15.TabIndex = 161
        Me.MetroLabel15.Text = "Start Date"
        '
        'EndDate
        '
        Me.EndDate.CustomFormat = "dd-mmm-yyyy"
        Me.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EndDate.Location = New System.Drawing.Point(385, 78)
        Me.EndDate.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.EndDate.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(106, 20)
        Me.EndDate.TabIndex = 160
        Me.EndDate.Value = New Date(2022, 9, 20, 8, 22, 25, 0)
        '
        'StartDate
        '
        Me.StartDate.CustomFormat = "dd-mmm-yyyy"
        Me.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.StartDate.Location = New System.Drawing.Point(255, 78)
        Me.StartDate.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.StartDate.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(106, 20)
        Me.StartDate.TabIndex = 159
        Me.StartDate.Value = New Date(2022, 9, 20, 0, 0, 0, 0)
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.LinkRefresh)
        Me.MetroPanel1.Controls.Add(Me.LinkLastMonth)
        Me.MetroPanel1.Controls.Add(Me.LinkThisMonth)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(24, 75)
        Me.MetroPanel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 8)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(225, 23)
        Me.MetroPanel1.TabIndex = 158
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'LinkRefresh
        '
        Me.LinkRefresh.AutoSize = True
        Me.LinkRefresh.BackColor = System.Drawing.Color.Transparent
        Me.LinkRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkRefresh.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.LinkRefresh.Location = New System.Drawing.Point(0, 0)
        Me.LinkRefresh.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkRefresh.Name = "LinkRefresh"
        Me.LinkRefresh.Size = New System.Drawing.Size(70, 23)
        Me.LinkRefresh.TabIndex = 57
        Me.LinkRefresh.Tag = "thisyear"
        Me.LinkRefresh.Text = "Refresh"
        Me.LinkRefresh.UseCustomBackColor = True
        Me.LinkRefresh.UseSelectable = True
        Me.LinkRefresh.UseStyleColors = True
        '
        'LinkLastMonth
        '
        Me.LinkLastMonth.AutoSize = True
        Me.LinkLastMonth.BackColor = System.Drawing.Color.Transparent
        Me.LinkLastMonth.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLastMonth.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkLastMonth.Location = New System.Drawing.Point(140, 0)
        Me.LinkLastMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkLastMonth.Name = "LinkLastMonth"
        Me.LinkLastMonth.Size = New System.Drawing.Size(77, 23)
        Me.LinkLastMonth.TabIndex = 86
        Me.LinkLastMonth.Text = "Last Month"
        Me.LinkLastMonth.UseCustomBackColor = True
        Me.LinkLastMonth.UseSelectable = True
        Me.LinkLastMonth.UseStyleColors = True
        '
        'LinkThisMonth
        '
        Me.LinkThisMonth.AutoSize = True
        Me.LinkThisMonth.BackColor = System.Drawing.Color.Transparent
        Me.LinkThisMonth.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkThisMonth.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkThisMonth.Location = New System.Drawing.Point(70, 0)
        Me.LinkThisMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkThisMonth.Name = "LinkThisMonth"
        Me.LinkThisMonth.Size = New System.Drawing.Size(70, 23)
        Me.LinkThisMonth.TabIndex = 87
        Me.LinkThisMonth.Text = "This Month"
        Me.LinkThisMonth.UseCustomBackColor = True
        Me.LinkThisMonth.UseSelectable = True
        Me.LinkThisMonth.UseStyleColors = True
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
        'ScopeDataGridViewTextBoxColumn
        '
        Me.ScopeDataGridViewTextBoxColumn.DataPropertyName = "scope"
        Me.ScopeDataGridViewTextBoxColumn.HeaderText = "Scope"
        Me.ScopeDataGridViewTextBoxColumn.Name = "ScopeDataGridViewTextBoxColumn"
        '
        'DateinDataGridViewTextBoxColumn
        '
        Me.DateinDataGridViewTextBoxColumn.DataPropertyName = "datein"
        Me.DateinDataGridViewTextBoxColumn.HeaderText = "Receipt Date"
        Me.DateinDataGridViewTextBoxColumn.Name = "DateinDataGridViewTextBoxColumn"
        '
        'BrtinDataGridViewTextBoxColumn
        '
        Me.BrtinDataGridViewTextBoxColumn.DataPropertyName = "brt_in"
        Me.BrtinDataGridViewTextBoxColumn.HeaderText = "Weight Sample (g)"
        Me.BrtinDataGridViewTextBoxColumn.Name = "BrtinDataGridViewTextBoxColumn"
        '
        'RemarkDataGridViewTextBoxColumn
        '
        Me.RemarkDataGridViewTextBoxColumn.DataPropertyName = "remark"
        Me.RemarkDataGridViewTextBoxColumn.HeaderText = "Remark"
        Me.RemarkDataGridViewTextBoxColumn.Name = "RemarkDataGridViewTextBoxColumn"
        '
        'TestdateDataGridViewTextBoxColumn
        '
        Me.TestdateDataGridViewTextBoxColumn.DataPropertyName = "test_date"
        Me.TestdateDataGridViewTextBoxColumn.HeaderText = "Test Date"
        Me.TestdateDataGridViewTextBoxColumn.Name = "TestdateDataGridViewTextBoxColumn"
        '
        'TimeDataGridViewTextBoxColumn
        '
        Me.TimeDataGridViewTextBoxColumn.DataPropertyName = "time"
        Me.TimeDataGridViewTextBoxColumn.HeaderText = "Time"
        Me.TimeDataGridViewTextBoxColumn.Name = "TimeDataGridViewTextBoxColumn"
        '
        'NexttestDataGridViewTextBoxColumn
        '
        Me.NexttestDataGridViewTextBoxColumn.DataPropertyName = "nexttest"
        Me.NexttestDataGridViewTextBoxColumn.HeaderText = "Next Test"
        Me.NexttestDataGridViewTextBoxColumn.Name = "NexttestDataGridViewTextBoxColumn"
        Me.NexttestDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReportperiodicnextviewBindingSource
        '
        Me.ReportperiodicnextviewBindingSource.DataMember = "report_periodicnext_view"
        Me.ReportperiodicnextviewBindingSource.DataSource = Me.HCQC_serverDataSet
        '
        'HCQC_serverDataSet
        '
        Me.HCQC_serverDataSet.DataSetName = "HCQC_serverDataSet"
        Me.HCQC_serverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Report_periodicnext_viewTableAdapter
        '
        Me.Report_periodicnext_viewTableAdapter.ClearBeforeFill = True
        '
        'Periodic_Scedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnFilterDate)
        Me.Controls.Add(Me.MetroLabel18)
        Me.Controls.Add(Me.MetroLabel16)
        Me.Controls.Add(Me.MetroLabel15)
        Me.Controls.Add(Me.EndDate)
        Me.Controls.Add(Me.StartDate)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Name = "Periodic_Scedule"
        Me.Text = "Periodic Scedule List"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFilterDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        CType(Me.ReportperiodicnextviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroGrid1 As MetroGrid
    Friend WithEvents HCQC_serverDataSet As HCQC_serverDataSet
    Friend WithEvents ReportperiodicnextviewBindingSource As BindingSource
    Friend WithEvents Report_periodicnext_viewTableAdapter As HCQC_serverDataSetTableAdapters.report_periodicnext_viewTableAdapter
    Friend WithEvents ClassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CropDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CroptypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LotidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LotqttDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabnumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarietyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HarvestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomnlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents nojobColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScopeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrtinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemarkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NexttestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BtnFilterDate As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents MetroLabel18 As MetroLabel
    Friend WithEvents MetroLabel16 As MetroLabel
    Friend WithEvents MetroLabel15 As MetroLabel
    Friend WithEvents EndDate As DateTimePicker
    Friend WithEvents StartDate As DateTimePicker
    Friend WithEvents MetroPanel1 As MetroPanel
    Friend WithEvents LinkRefresh As MetroLink
    Friend WithEvents LinkLastMonth As MetroLink
    Friend WithEvents LinkThisMonth As MetroLink
End Class
