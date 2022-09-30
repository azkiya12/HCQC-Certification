<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_List_Moisture_Test
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
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid
        Me.ListMt2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_serverDataSet = New WindowsApplication1.HCQC_serverDataSet
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton
        Me.ListMt2TableAdapter = New WindowsApplication1.HCQC_serverDataSetTableAdapters.ListMt2TableAdapter
        Me.NolabDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VarietyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NomnlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NojobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DttDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Mr1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Mr2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AvrgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AnalysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tgl_input = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UjikaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListMt2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NolabDataGridViewTextBoxColumn, Me.VarietyDataGridViewTextBoxColumn, Me.NomnlDataGridViewTextBoxColumn, Me.NojobDataGridViewTextBoxColumn, Me.DttDataGridViewTextBoxColumn, Me.Mr1DataGridViewTextBoxColumn, Me.Mr2DataGridViewTextBoxColumn, Me.AvrgDataGridViewTextBoxColumn, Me.AnalysDataGridViewTextBoxColumn, Me.tgl_input, Me.UjikaDataGridViewCheckBoxColumn})
        Me.MetroGrid1.DataSource = Me.ListMt2BindingSource
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
        Me.MetroGrid1.Location = New System.Drawing.Point(23, 101)
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
        Me.MetroGrid1.Size = New System.Drawing.Size(866, 475)
        Me.MetroGrid1.TabIndex = 0
        '
        'ListMt2BindingSource
        '
        Me.ListMt2BindingSource.DataMember = "ListMt2"
        Me.ListMt2BindingSource.DataSource = Me.HCQC_serverDataSet
        '
        'HCQC_serverDataSet
        '
        Me.HCQC_serverDataSet.DataSetName = "HCQC_serverDataSet"
        Me.HCQC_serverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(23, 72)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(105, 23)
        Me.MetroButton1.TabIndex = 2
        Me.MetroButton1.Text = "Refresh"
        Me.MetroButton1.UseSelectable = True
        '
        'ListMt2TableAdapter
        '
        Me.ListMt2TableAdapter.ClearBeforeFill = True
        '
        'NolabDataGridViewTextBoxColumn
        '
        Me.NolabDataGridViewTextBoxColumn.DataPropertyName = "no_lab"
        Me.NolabDataGridViewTextBoxColumn.HeaderText = "Lab.No."
        Me.NolabDataGridViewTextBoxColumn.Name = "NolabDataGridViewTextBoxColumn"
        '
        'VarietyDataGridViewTextBoxColumn
        '
        Me.VarietyDataGridViewTextBoxColumn.DataPropertyName = "variety"
        Me.VarietyDataGridViewTextBoxColumn.HeaderText = "Variety"
        Me.VarietyDataGridViewTextBoxColumn.Name = "VarietyDataGridViewTextBoxColumn"
        Me.VarietyDataGridViewTextBoxColumn.Width = 75
        '
        'NomnlDataGridViewTextBoxColumn
        '
        Me.NomnlDataGridViewTextBoxColumn.DataPropertyName = "nomnl"
        Me.NomnlDataGridViewTextBoxColumn.HeaderText = "Manual"
        Me.NomnlDataGridViewTextBoxColumn.Name = "NomnlDataGridViewTextBoxColumn"
        Me.NomnlDataGridViewTextBoxColumn.Width = 60
        '
        'NojobDataGridViewTextBoxColumn
        '
        Me.NojobDataGridViewTextBoxColumn.DataPropertyName = "nojob"
        Me.NojobDataGridViewTextBoxColumn.HeaderText = "Job No."
        Me.NojobDataGridViewTextBoxColumn.Name = "NojobDataGridViewTextBoxColumn"
        '
        'DttDataGridViewTextBoxColumn
        '
        Me.DttDataGridViewTextBoxColumn.DataPropertyName = "Dt_t"
        Me.DttDataGridViewTextBoxColumn.HeaderText = "Test Date"
        Me.DttDataGridViewTextBoxColumn.Name = "DttDataGridViewTextBoxColumn"
        Me.DttDataGridViewTextBoxColumn.Width = 75
        '
        'Mr1DataGridViewTextBoxColumn
        '
        Me.Mr1DataGridViewTextBoxColumn.DataPropertyName = "mr1"
        Me.Mr1DataGridViewTextBoxColumn.HeaderText = "Repl 1"
        Me.Mr1DataGridViewTextBoxColumn.Name = "Mr1DataGridViewTextBoxColumn"
        Me.Mr1DataGridViewTextBoxColumn.Width = 75
        '
        'Mr2DataGridViewTextBoxColumn
        '
        Me.Mr2DataGridViewTextBoxColumn.DataPropertyName = "mr2"
        Me.Mr2DataGridViewTextBoxColumn.HeaderText = "Repl 2"
        Me.Mr2DataGridViewTextBoxColumn.Name = "Mr2DataGridViewTextBoxColumn"
        Me.Mr2DataGridViewTextBoxColumn.Width = 75
        '
        'AvrgDataGridViewTextBoxColumn
        '
        Me.AvrgDataGridViewTextBoxColumn.DataPropertyName = "avrg"
        Me.AvrgDataGridViewTextBoxColumn.HeaderText = "Avrg(%)"
        Me.AvrgDataGridViewTextBoxColumn.Name = "AvrgDataGridViewTextBoxColumn"
        Me.AvrgDataGridViewTextBoxColumn.Width = 75
        '
        'AnalysDataGridViewTextBoxColumn
        '
        Me.AnalysDataGridViewTextBoxColumn.DataPropertyName = "analys"
        Me.AnalysDataGridViewTextBoxColumn.HeaderText = "Analys"
        Me.AnalysDataGridViewTextBoxColumn.Name = "AnalysDataGridViewTextBoxColumn"
        Me.AnalysDataGridViewTextBoxColumn.Width = 75
        '
        'tgl_input
        '
        Me.tgl_input.DataPropertyName = "tgl_input"
        Me.tgl_input.HeaderText = "Input Date"
        Me.tgl_input.Name = "tgl_input"
        '
        'UjikaDataGridViewCheckBoxColumn
        '
        Me.UjikaDataGridViewCheckBoxColumn.DataPropertyName = "uji_ka"
        Me.UjikaDataGridViewCheckBoxColumn.HeaderText = "MC Test"
        Me.UjikaDataGridViewCheckBoxColumn.Name = "UjikaDataGridViewCheckBoxColumn"
        Me.UjikaDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UjikaDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.UjikaDataGridViewCheckBoxColumn.Width = 75
        '
        'Data_List_Moisture_Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 599)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Name = "Data_List_Moisture_Test"
        Me.Text = "Data List Moisture Test"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListMt2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents HCQC_serverDataSet As WindowsApplication1.HCQC_serverDataSet
    Friend WithEvents ListMt2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListMt2TableAdapter As WindowsApplication1.HCQC_serverDataSetTableAdapters.ListMt2TableAdapter
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents NolabDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VarietyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomnlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NojobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DttDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mr1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mr2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvrgDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnalysDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tgl_input As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UjikaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
