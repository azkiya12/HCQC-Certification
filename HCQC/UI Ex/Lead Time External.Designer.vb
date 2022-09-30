<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lead_Time_External
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid
        Me.ExtrnlleadtimeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_serverDataSet = New WindowsApplication1.HCQC_serverDataSet
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.Extrnl_leadtimeTableAdapter = New WindowsApplication1.HCQC_serverDataSetTableAdapters.extrnl_leadtimeTableAdapter
        Me.NolabDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VarietyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NojobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.uk_bnh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WeightADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnitADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WeightBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnitBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.JnsbnhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DtqcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UjikaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UjiraDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UjidtDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.test_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pengamatan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VgfncDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vg_tgl_input = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ESTIMASI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RealDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LeadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EvaluasiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExtrnlleadtimeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(23, 63)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(105, 23)
        Me.MetroButton1.TabIndex = 2
        Me.MetroButton1.Text = "Refresh"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowDrop = True
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToOrderColumns = True
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NolabDataGridViewTextBoxColumn, Me.VarietyDataGridViewTextBoxColumn, Me.NojobDataGridViewTextBoxColumn, Me.uk_bnh, Me.WeightADataGridViewTextBoxColumn, Me.UnitADataGridViewTextBoxColumn, Me.WeightBDataGridViewTextBoxColumn, Me.UnitBDataGridViewTextBoxColumn, Me.JnsbnhDataGridViewTextBoxColumn, Me.DtqcDataGridViewTextBoxColumn, Me.UjikaDataGridViewCheckBoxColumn, Me.UjiraDataGridViewCheckBoxColumn, Me.UjidtDataGridViewCheckBoxColumn, Me.test_date, Me.FistDataGridViewTextBoxColumn, Me.Pengamatan, Me.VgfncDataGridViewTextBoxColumn, Me.vg_tgl_input, Me.ESTIMASI, Me.RealDataGridViewTextBoxColumn, Me.LeadDataGridViewTextBoxColumn, Me.EvaluasiDataGridViewTextBoxColumn})
        Me.MetroGrid1.DataSource = Me.ExtrnlleadtimeBindingSource
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
        Me.MetroGrid1.Size = New System.Drawing.Size(1023, 513)
        Me.MetroGrid1.TabIndex = 3
        '
        'ExtrnlleadtimeBindingSource
        '
        Me.ExtrnlleadtimeBindingSource.DataMember = "extrnl_leadtime"
        Me.ExtrnlleadtimeBindingSource.DataSource = Me.HCQC_serverDataSet
        '
        'HCQC_serverDataSet
        '
        Me.HCQC_serverDataSet.DataSetName = "HCQC_serverDataSet"
        Me.HCQC_serverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        Me.MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Teal
        '
        'Extrnl_leadtimeTableAdapter
        '
        Me.Extrnl_leadtimeTableAdapter.ClearBeforeFill = True
        '
        'NolabDataGridViewTextBoxColumn
        '
        Me.NolabDataGridViewTextBoxColumn.DataPropertyName = "no_lab"
        Me.NolabDataGridViewTextBoxColumn.HeaderText = "Lab No"
        Me.NolabDataGridViewTextBoxColumn.Name = "NolabDataGridViewTextBoxColumn"
        '
        'VarietyDataGridViewTextBoxColumn
        '
        Me.VarietyDataGridViewTextBoxColumn.DataPropertyName = "variety"
        Me.VarietyDataGridViewTextBoxColumn.HeaderText = "Variety"
        Me.VarietyDataGridViewTextBoxColumn.Name = "VarietyDataGridViewTextBoxColumn"
        '
        'NojobDataGridViewTextBoxColumn
        '
        Me.NojobDataGridViewTextBoxColumn.DataPropertyName = "nojob"
        Me.NojobDataGridViewTextBoxColumn.HeaderText = "Job No"
        Me.NojobDataGridViewTextBoxColumn.Name = "NojobDataGridViewTextBoxColumn"
        '
        'uk_bnh
        '
        Me.uk_bnh.DataPropertyName = "uk_bnh"
        Me.uk_bnh.HeaderText = "Type"
        Me.uk_bnh.Name = "uk_bnh"
        '
        'WeightADataGridViewTextBoxColumn
        '
        Me.WeightADataGridViewTextBoxColumn.DataPropertyName = "weightA"
        Me.WeightADataGridViewTextBoxColumn.HeaderText = "WeightLot"
        Me.WeightADataGridViewTextBoxColumn.Name = "WeightADataGridViewTextBoxColumn"
        '
        'UnitADataGridViewTextBoxColumn
        '
        Me.UnitADataGridViewTextBoxColumn.DataPropertyName = "unitA"
        Me.UnitADataGridViewTextBoxColumn.HeaderText = "Unit"
        Me.UnitADataGridViewTextBoxColumn.Name = "UnitADataGridViewTextBoxColumn"
        '
        'WeightBDataGridViewTextBoxColumn
        '
        Me.WeightBDataGridViewTextBoxColumn.DataPropertyName = "weightB"
        Me.WeightBDataGridViewTextBoxColumn.HeaderText = "Packagin"
        Me.WeightBDataGridViewTextBoxColumn.Name = "WeightBDataGridViewTextBoxColumn"
        '
        'UnitBDataGridViewTextBoxColumn
        '
        Me.UnitBDataGridViewTextBoxColumn.DataPropertyName = "unitB"
        Me.UnitBDataGridViewTextBoxColumn.HeaderText = "Unit"
        Me.UnitBDataGridViewTextBoxColumn.Name = "UnitBDataGridViewTextBoxColumn"
        '
        'JnsbnhDataGridViewTextBoxColumn
        '
        Me.JnsbnhDataGridViewTextBoxColumn.DataPropertyName = "jns_bnh"
        Me.JnsbnhDataGridViewTextBoxColumn.HeaderText = "Jns Benih"
        Me.JnsbnhDataGridViewTextBoxColumn.Name = "JnsbnhDataGridViewTextBoxColumn"
        '
        'DtqcDataGridViewTextBoxColumn
        '
        Me.DtqcDataGridViewTextBoxColumn.DataPropertyName = "Dtqc"
        Me.DtqcDataGridViewTextBoxColumn.HeaderText = "Received"
        Me.DtqcDataGridViewTextBoxColumn.Name = "DtqcDataGridViewTextBoxColumn"
        '
        'UjikaDataGridViewCheckBoxColumn
        '
        Me.UjikaDataGridViewCheckBoxColumn.DataPropertyName = "uji_ka"
        Me.UjikaDataGridViewCheckBoxColumn.HeaderText = "uji_ka"
        Me.UjikaDataGridViewCheckBoxColumn.Name = "UjikaDataGridViewCheckBoxColumn"
        Me.UjikaDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UjikaDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'UjiraDataGridViewCheckBoxColumn
        '
        Me.UjiraDataGridViewCheckBoxColumn.DataPropertyName = "uji_ra"
        Me.UjiraDataGridViewCheckBoxColumn.HeaderText = "uji_ra"
        Me.UjiraDataGridViewCheckBoxColumn.Name = "UjiraDataGridViewCheckBoxColumn"
        Me.UjiraDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UjiraDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'UjidtDataGridViewCheckBoxColumn
        '
        Me.UjidtDataGridViewCheckBoxColumn.DataPropertyName = "uji_dt"
        Me.UjidtDataGridViewCheckBoxColumn.HeaderText = "uji_dt"
        Me.UjidtDataGridViewCheckBoxColumn.Name = "UjidtDataGridViewCheckBoxColumn"
        Me.UjidtDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UjidtDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'test_date
        '
        Me.test_date.DataPropertyName = "test_date"
        Me.test_date.HeaderText = "Tanggal Uji"
        Me.test_date.Name = "test_date"
        '
        'FistDataGridViewTextBoxColumn
        '
        Me.FistDataGridViewTextBoxColumn.DataPropertyName = "Fist"
        Me.FistDataGridViewTextBoxColumn.HeaderText = "Est 1stCount"
        Me.FistDataGridViewTextBoxColumn.Name = "FistDataGridViewTextBoxColumn"
        Me.FistDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Pengamatan
        '
        Me.Pengamatan.DataPropertyName = "Pengamatan"
        Me.Pengamatan.HeaderText = "Est 2ndCount"
        Me.Pengamatan.Name = "Pengamatan"
        Me.Pengamatan.ReadOnly = True
        '
        'VgfncDataGridViewTextBoxColumn
        '
        Me.VgfncDataGridViewTextBoxColumn.DataPropertyName = "vg_fn_c"
        Me.VgfncDataGridViewTextBoxColumn.HeaderText = "2ndCount"
        Me.VgfncDataGridViewTextBoxColumn.Name = "VgfncDataGridViewTextBoxColumn"
        '
        'vg_tgl_input
        '
        Me.vg_tgl_input.DataPropertyName = "vg_tgl_input"
        Me.vg_tgl_input.HeaderText = "DT Input"
        Me.vg_tgl_input.Name = "vg_tgl_input"
        '
        'ESTIMASI
        '
        Me.ESTIMASI.DataPropertyName = "ESTIMASI"
        Me.ESTIMASI.HeaderText = "ESTIMASI"
        Me.ESTIMASI.Name = "ESTIMASI"
        Me.ESTIMASI.ReadOnly = True
        '
        'RealDataGridViewTextBoxColumn
        '
        Me.RealDataGridViewTextBoxColumn.DataPropertyName = "Real"
        Me.RealDataGridViewTextBoxColumn.HeaderText = "Real"
        Me.RealDataGridViewTextBoxColumn.Name = "RealDataGridViewTextBoxColumn"
        Me.RealDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LeadDataGridViewTextBoxColumn
        '
        Me.LeadDataGridViewTextBoxColumn.DataPropertyName = "lead"
        Me.LeadDataGridViewTextBoxColumn.HeaderText = "Lead Time"
        Me.LeadDataGridViewTextBoxColumn.Name = "LeadDataGridViewTextBoxColumn"
        '
        'EvaluasiDataGridViewTextBoxColumn
        '
        Me.EvaluasiDataGridViewTextBoxColumn.DataPropertyName = "Evaluasi"
        Me.EvaluasiDataGridViewTextBoxColumn.HeaderText = "Evaluasi"
        Me.EvaluasiDataGridViewTextBoxColumn.Name = "EvaluasiDataGridViewTextBoxColumn"
        Me.EvaluasiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Lead_Time_External
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 628)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Controls.Add(Me.MetroButton1)
        Me.Name = "Lead_Time_External"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Lead Time External"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExtrnlleadtimeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents HCQC_serverDataSet As WindowsApplication1.HCQC_serverDataSet
    Friend WithEvents ExtrnlleadtimeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Extrnl_leadtimeTableAdapter As WindowsApplication1.HCQC_serverDataSetTableAdapters.extrnl_leadtimeTableAdapter
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
    Friend WithEvents NolabDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VarietyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NojobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents uk_bnh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WeightADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WeightBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JnsbnhDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DtqcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UjikaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UjiraDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UjidtDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents test_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FistDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pengamatan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VgfncDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vg_tgl_input As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTIMASI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RealDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LeadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EvaluasiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
