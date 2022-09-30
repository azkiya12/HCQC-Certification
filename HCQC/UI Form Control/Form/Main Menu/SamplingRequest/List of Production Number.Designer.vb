<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List_of_Production_Number
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
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.Reporta1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_NewDataset = New WindowsApplication1.HCQC_NewDataset()
        Me.tsearch = New MetroFramework.Controls.MetroTextBox()
        Me.Report_a1TableAdapter = New WindowsApplication1.HCQC_NewDatasetTableAdapters.report_a1TableAdapter()
        Me.IdcodeColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.VarietyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CropDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CgrnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HarvestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NorencanaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NokontrakDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.joblot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastPrintDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reporta1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdcodeColumn, Me.VarietyDataGridViewTextBoxColumn, Me.CropDataGridViewTextBoxColumn, Me.CgrnameDataGridViewTextBoxColumn, Me.HarvestDataGridViewTextBoxColumn, Me.NorencanaDataGridViewTextBoxColumn, Me.NokontrakDataGridViewTextBoxColumn, Me.joblot, Me.kec, Me.CountDataGridViewTextBoxColumn, Me.LastPrintDataGridViewTextBoxColumn})
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
        Me.MetroGrid1.Location = New System.Drawing.Point(23, 63)
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
        Me.MetroGrid1.Size = New System.Drawing.Size(732, 297)
        Me.MetroGrid1.TabIndex = 0
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
        'tsearch
        '
        Me.tsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tsearch.CustomButton.Image = Nothing
        Me.tsearch.CustomButton.Location = New System.Drawing.Point(201, 1)
        Me.tsearch.CustomButton.Name = ""
        Me.tsearch.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tsearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tsearch.CustomButton.TabIndex = 1
        Me.tsearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tsearch.CustomButton.UseSelectable = True
        Me.tsearch.CustomButton.Visible = False
        Me.tsearch.Lines = New String(-1) {}
        Me.tsearch.Location = New System.Drawing.Point(532, 34)
        Me.tsearch.MaxLength = 32767
        Me.tsearch.Name = "tsearch"
        Me.tsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tsearch.PromptText = "Search"
        Me.tsearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tsearch.SelectedText = ""
        Me.tsearch.SelectionLength = 0
        Me.tsearch.SelectionStart = 0
        Me.tsearch.ShortcutsEnabled = True
        Me.tsearch.Size = New System.Drawing.Size(223, 23)
        Me.tsearch.TabIndex = 1
        Me.tsearch.UseSelectable = True
        Me.tsearch.WaterMark = "Search"
        Me.tsearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tsearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Report_a1TableAdapter
        '
        Me.Report_a1TableAdapter.ClearBeforeFill = True
        '
        'IdcodeColumn
        '
        Me.IdcodeColumn.DataPropertyName = "idcode"
        Me.IdcodeColumn.HeaderText = "Production Code"
        Me.IdcodeColumn.Name = "IdcodeColumn"
        Me.IdcodeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdcodeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
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
        'CgrnameDataGridViewTextBoxColumn
        '
        Me.CgrnameDataGridViewTextBoxColumn.DataPropertyName = "cgrname"
        Me.CgrnameDataGridViewTextBoxColumn.HeaderText = "CGR"
        Me.CgrnameDataGridViewTextBoxColumn.Name = "CgrnameDataGridViewTextBoxColumn"
        '
        'HarvestDataGridViewTextBoxColumn
        '
        Me.HarvestDataGridViewTextBoxColumn.DataPropertyName = "harvest"
        Me.HarvestDataGridViewTextBoxColumn.HeaderText = "Harvest"
        Me.HarvestDataGridViewTextBoxColumn.Name = "HarvestDataGridViewTextBoxColumn"
        '
        'NorencanaDataGridViewTextBoxColumn
        '
        Me.NorencanaDataGridViewTextBoxColumn.DataPropertyName = "norencana"
        Me.NorencanaDataGridViewTextBoxColumn.HeaderText = "Rencana"
        Me.NorencanaDataGridViewTextBoxColumn.Name = "NorencanaDataGridViewTextBoxColumn"
        '
        'NokontrakDataGridViewTextBoxColumn
        '
        Me.NokontrakDataGridViewTextBoxColumn.DataPropertyName = "nokontrak"
        Me.NokontrakDataGridViewTextBoxColumn.HeaderText = "Kontrak"
        Me.NokontrakDataGridViewTextBoxColumn.Name = "NokontrakDataGridViewTextBoxColumn"
        '
        'joblot
        '
        Me.joblot.DataPropertyName = "joblot"
        Me.joblot.HeaderText = "joblot"
        Me.joblot.Name = "joblot"
        '
        'kec
        '
        Me.kec.DataPropertyName = "kec"
        Me.kec.HeaderText = "kec"
        Me.kec.Name = "kec"
        '
        'CountDataGridViewTextBoxColumn
        '
        Me.CountDataGridViewTextBoxColumn.DataPropertyName = "Count"
        Me.CountDataGridViewTextBoxColumn.HeaderText = "Count"
        Me.CountDataGridViewTextBoxColumn.Name = "CountDataGridViewTextBoxColumn"
        '
        'LastPrintDataGridViewTextBoxColumn
        '
        Me.LastPrintDataGridViewTextBoxColumn.DataPropertyName = "LastPrint"
        Me.LastPrintDataGridViewTextBoxColumn.HeaderText = "LastPrint"
        Me.LastPrintDataGridViewTextBoxColumn.Name = "LastPrintDataGridViewTextBoxColumn"
        '
        'List_of_Production_Number
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 383)
        Me.Controls.Add(Me.tsearch)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Name = "List_of_Production_Number"
        Me.Text = "List of Production Number"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reporta1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroGrid1 As MetroGrid
    Friend WithEvents tsearch As MetroTextBox
    Friend WithEvents HCQC_NewDataset As HCQC_NewDataset
    Friend WithEvents Reporta1BindingSource As BindingSource
    Friend WithEvents Report_a1TableAdapter As HCQC_NewDatasetTableAdapters.report_a1TableAdapter
    Friend WithEvents IdcodeColumn As DataGridViewLinkColumn
    Friend WithEvents VarietyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CropDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CgrnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HarvestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NorencanaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NokontrakDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents joblot As DataGridViewTextBoxColumn
    Friend WithEvents kec As DataGridViewTextBoxColumn
    Friend WithEvents CountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastPrintDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
