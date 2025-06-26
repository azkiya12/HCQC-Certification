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
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.StartDate = New System.Windows.Forms.DateTimePicker()
        Me.Tsearch = New MetroFramework.Controls.MetroTextBox()
        Me.BtnFilterDate = New Bunifu.Framework.UI.BunifuImageButton()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.EndDate = New System.Windows.Forms.DateTimePicker()
        Me.LinkLastMonth1 = New MetroFramework.Controls.MetroLink()
        Me.LinkThisMonth1 = New MetroFramework.Controls.MetroLink()
        Me.ReportistaviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_serverDataSet = New WindowsApplication1.HCQC_serverDataSet()
        Me.Report_ista_viewTableAdapter = New WindowsApplication1.HCQC_serverDataSetTableAdapters.report_ista_viewTableAdapter()
        Me.DetailColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Labnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductionCodeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarietyColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HarvestColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomnlColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NojobColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScopeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateinColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConcludedColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MeanColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurityColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seed1000 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnQcPassColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFilterDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportistaviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DetailColumn, Me.Labnum, Me.ProductionCodeColumn, Me.VarietyColumn, Me.HarvestColumn, Me.NomnlColumn, Me.NojobColumn, Me.WeightColumn, Me.ScopeColumn, Me.DateinColumn, Me.ConcludedColumn, Me.MeanColumn, Me.PurityColumn, Me.seed1000, Me.DtColumn, Me.BtnQcPassColumn})
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
        Me.MetroGrid1.Location = New System.Drawing.Point(23, 104)
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
        Me.MetroGrid1.Size = New System.Drawing.Size(900, 323)
        Me.MetroGrid1.TabIndex = 0
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        '
        'StartDate
        '
        Me.MetroStyleExtender1.SetApplyMetroTheme(Me.StartDate, True)
        Me.StartDate.CustomFormat = "dd-mmm-yyyy"
        Me.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.StartDate.Location = New System.Drawing.Point(185, 78)
        Me.StartDate.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.StartDate.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(106, 20)
        Me.StartDate.TabIndex = 154
        Me.StartDate.Value = New Date(2022, 9, 19, 0, 0, 0, 0)
        '
        'Tsearch
        '
        Me.Tsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Tsearch.Location = New System.Drawing.Point(733, 75)
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
        'BtnFilterDate
        '
        Me.BtnFilterDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnFilterDate.Image = CType(resources.GetObject("BtnFilterDate.Image"), System.Drawing.Image)
        Me.BtnFilterDate.ImageActive = Nothing
        Me.BtnFilterDate.Location = New System.Drawing.Point(427, 75)
        Me.BtnFilterDate.Name = "BtnFilterDate"
        Me.BtnFilterDate.Size = New System.Drawing.Size(38, 23)
        Me.BtnFilterDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnFilterDate.TabIndex = 159
        Me.BtnFilterDate.TabStop = False
        Me.BtnFilterDate.Zoom = 10
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel18.Location = New System.Drawing.Point(297, 81)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(12, 15)
        Me.MetroLabel18.TabIndex = 158
        Me.MetroLabel18.Text = "-"
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel16.Location = New System.Drawing.Point(315, 60)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(53, 15)
        Me.MetroLabel16.TabIndex = 157
        Me.MetroLabel16.Text = "End Date"
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel15.Location = New System.Drawing.Point(185, 60)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(59, 15)
        Me.MetroLabel15.TabIndex = 156
        Me.MetroLabel15.Text = "Start Date"
        '
        'EndDate
        '
        Me.EndDate.CustomFormat = "dd-mmm-yyyy"
        Me.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EndDate.Location = New System.Drawing.Point(315, 78)
        Me.EndDate.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.EndDate.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(106, 20)
        Me.EndDate.TabIndex = 155
        Me.EndDate.Value = New Date(2022, 9, 19, 0, 0, 0, 0)
        '
        'LinkLastMonth1
        '
        Me.LinkLastMonth1.AutoSize = True
        Me.LinkLastMonth1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLastMonth1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLastMonth1.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkLastMonth1.Location = New System.Drawing.Point(93, 75)
        Me.LinkLastMonth1.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkLastMonth1.Name = "LinkLastMonth1"
        Me.LinkLastMonth1.Size = New System.Drawing.Size(70, 23)
        Me.LinkLastMonth1.TabIndex = 152
        Me.LinkLastMonth1.Text = "Last Month"
        Me.LinkLastMonth1.UseCustomBackColor = True
        Me.LinkLastMonth1.UseSelectable = True
        Me.LinkLastMonth1.UseStyleColors = True
        '
        'LinkThisMonth1
        '
        Me.LinkThisMonth1.AutoSize = True
        Me.LinkThisMonth1.BackColor = System.Drawing.Color.Transparent
        Me.LinkThisMonth1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkThisMonth1.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkThisMonth1.Location = New System.Drawing.Point(23, 75)
        Me.LinkThisMonth1.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkThisMonth1.Name = "LinkThisMonth1"
        Me.LinkThisMonth1.Size = New System.Drawing.Size(70, 23)
        Me.LinkThisMonth1.TabIndex = 153
        Me.LinkThisMonth1.Text = "This Month"
        Me.LinkThisMonth1.UseCustomBackColor = True
        Me.LinkThisMonth1.UseSelectable = True
        Me.LinkThisMonth1.UseStyleColors = True
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
        'Report_ista_viewTableAdapter
        '
        Me.Report_ista_viewTableAdapter.ClearBeforeFill = True
        '
        'DetailColumn
        '
        Me.DetailColumn.DataPropertyName = "status"
        Me.DetailColumn.HeaderText = "Detail"
        Me.DetailColumn.Name = "DetailColumn"
        Me.DetailColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DetailColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'seed1000
        '
        Me.seed1000.DataPropertyName = "seed1000"
        Me.seed1000.HeaderText = "Seed1000"
        Me.seed1000.Name = "seed1000"
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
        Me.Controls.Add(Me.BtnFilterDate)
        Me.Controls.Add(Me.MetroLabel18)
        Me.Controls.Add(Me.MetroLabel16)
        Me.Controls.Add(Me.MetroLabel15)
        Me.Controls.Add(Me.EndDate)
        Me.Controls.Add(Me.StartDate)
        Me.Controls.Add(Me.LinkLastMonth1)
        Me.Controls.Add(Me.LinkThisMonth1)
        Me.Controls.Add(Me.Tsearch)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ista_report"
        Me.Text = "Certification Standart"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFilterDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportistaviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroGrid1 As MetroGrid
    Friend WithEvents MetroStyleExtender1 As Components.MetroStyleExtender
    Friend WithEvents MetroStyleManager1 As Components.MetroStyleManager
    Friend WithEvents HCQC_serverDataSet As HCQC_serverDataSet
    Friend WithEvents ReportistaviewBindingSource As BindingSource
    Friend WithEvents Report_ista_viewTableAdapter As HCQC_serverDataSetTableAdapters.report_ista_viewTableAdapter
    Friend WithEvents Tsearch As MetroTextBox
    Friend WithEvents BtnFilterDate As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents MetroLabel18 As MetroLabel
    Friend WithEvents MetroLabel16 As MetroLabel
    Friend WithEvents MetroLabel15 As MetroLabel
    Friend WithEvents EndDate As DateTimePicker
    Friend WithEvents StartDate As DateTimePicker
    Friend WithEvents LinkLastMonth1 As MetroLink
    Friend WithEvents LinkThisMonth1 As MetroLink
    Friend WithEvents DetailColumn As DataGridViewTextBoxColumn
    Friend WithEvents Labnum As DataGridViewTextBoxColumn
    Friend WithEvents ProductionCodeColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarietyColumn As DataGridViewTextBoxColumn
    Friend WithEvents HarvestColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomnlColumn As DataGridViewTextBoxColumn
    Friend WithEvents NojobColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScopeColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateinColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConcludedColumn As DataGridViewTextBoxColumn
    Friend WithEvents MeanColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurityColumn As DataGridViewTextBoxColumn
    Friend WithEvents seed1000 As DataGridViewTextBoxColumn
    Friend WithEvents DtColumn As DataGridViewTextBoxColumn
    Friend WithEvents BtnQcPassColumn As DataGridViewButtonColumn
End Class
