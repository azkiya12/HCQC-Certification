<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_List_Periodik
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
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton
        Me.HCQC_serverDataSet = New WindowsApplication1.HCQC_serverDataSet
        Me.PeriodikmskBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Periodik_mskTableAdapter = New WindowsApplication1.HCQC_serverDataSetTableAdapters.periodik_mskTableAdapter
        Me.NolabDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VarietyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NomnlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NojobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HvdtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DtqcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NextTsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BrtinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UkbnhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TakenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ppc2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UjikaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UjiraDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UjidtDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AbkmsnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AbbnhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AblabelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeriodikmskBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NolabDataGridViewTextBoxColumn, Me.VarietyDataGridViewTextBoxColumn, Me.NomnlDataGridViewTextBoxColumn, Me.NojobDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.HvdtDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.DtqcDataGridViewTextBoxColumn, Me.NextTsDataGridViewTextBoxColumn, Me.BrtinDataGridViewTextBoxColumn, Me.UkbnhDataGridViewTextBoxColumn, Me.TakenDataGridViewTextBoxColumn, Me.ppc2, Me.UjikaDataGridViewCheckBoxColumn, Me.UjiraDataGridViewCheckBoxColumn, Me.UjidtDataGridViewCheckBoxColumn, Me.AbkmsnDataGridViewTextBoxColumn, Me.AbbnhDataGridViewTextBoxColumn, Me.AblabelDataGridViewTextBoxColumn, Me.KetDataGridViewTextBoxColumn})
        Me.MetroGrid1.DataSource = Me.PeriodikmskBindingSource
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
        Me.MetroGrid1.Location = New System.Drawing.Point(23, 102)
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
        Me.MetroGrid1.Size = New System.Drawing.Size(946, 423)
        Me.MetroGrid1.TabIndex = 0
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        Me.MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Green
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(23, 73)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(105, 23)
        Me.MetroButton1.TabIndex = 2
        Me.MetroButton1.Text = "Refresh"
        Me.MetroButton1.UseSelectable = True
        '
        'HCQC_serverDataSet
        '
        Me.HCQC_serverDataSet.DataSetName = "HCQC_serverDataSet"
        Me.HCQC_serverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PeriodikmskBindingSource
        '
        Me.PeriodikmskBindingSource.DataMember = "periodik_msk"
        Me.PeriodikmskBindingSource.DataSource = Me.HCQC_serverDataSet
        '
        'Periodik_mskTableAdapter
        '
        Me.Periodik_mskTableAdapter.ClearBeforeFill = True
        '
        'NolabDataGridViewTextBoxColumn
        '
        Me.NolabDataGridViewTextBoxColumn.DataPropertyName = "no_lab"
        Me.NolabDataGridViewTextBoxColumn.HeaderText = "Lab. No."
        Me.NolabDataGridViewTextBoxColumn.Name = "NolabDataGridViewTextBoxColumn"
        '
        'VarietyDataGridViewTextBoxColumn
        '
        Me.VarietyDataGridViewTextBoxColumn.DataPropertyName = "variety"
        Me.VarietyDataGridViewTextBoxColumn.HeaderText = "Variety"
        Me.VarietyDataGridViewTextBoxColumn.Name = "VarietyDataGridViewTextBoxColumn"
        '
        'NomnlDataGridViewTextBoxColumn
        '
        Me.NomnlDataGridViewTextBoxColumn.DataPropertyName = "nomnl"
        Me.NomnlDataGridViewTextBoxColumn.HeaderText = "Manual"
        Me.NomnlDataGridViewTextBoxColumn.Name = "NomnlDataGridViewTextBoxColumn"
        Me.NomnlDataGridViewTextBoxColumn.Width = 50
        '
        'NojobDataGridViewTextBoxColumn
        '
        Me.NojobDataGridViewTextBoxColumn.DataPropertyName = "nojob"
        Me.NojobDataGridViewTextBoxColumn.HeaderText = "Job No."
        Me.NojobDataGridViewTextBoxColumn.Name = "NojobDataGridViewTextBoxColumn"
        Me.NojobDataGridViewTextBoxColumn.Width = 75
        '
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "Class"
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        Me.ClassDataGridViewTextBoxColumn.Width = 45
        '
        'HvdtDataGridViewTextBoxColumn
        '
        Me.HvdtDataGridViewTextBoxColumn.DataPropertyName = "hv_dt"
        Me.HvdtDataGridViewTextBoxColumn.HeaderText = "Harvert"
        Me.HvdtDataGridViewTextBoxColumn.Name = "HvdtDataGridViewTextBoxColumn"
        Me.HvdtDataGridViewTextBoxColumn.Width = 75
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "Weight (Kg)"
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        Me.WeightDataGridViewTextBoxColumn.Width = 75
        '
        'DtqcDataGridViewTextBoxColumn
        '
        Me.DtqcDataGridViewTextBoxColumn.DataPropertyName = "Dtqc"
        Me.DtqcDataGridViewTextBoxColumn.HeaderText = "Received"
        Me.DtqcDataGridViewTextBoxColumn.Name = "DtqcDataGridViewTextBoxColumn"
        Me.DtqcDataGridViewTextBoxColumn.Width = 75
        '
        'NextTsDataGridViewTextBoxColumn
        '
        Me.NextTsDataGridViewTextBoxColumn.DataPropertyName = "NextTs"
        Me.NextTsDataGridViewTextBoxColumn.HeaderText = "NextTs"
        Me.NextTsDataGridViewTextBoxColumn.Name = "NextTsDataGridViewTextBoxColumn"
        Me.NextTsDataGridViewTextBoxColumn.ReadOnly = True
        Me.NextTsDataGridViewTextBoxColumn.Width = 75
        '
        'BrtinDataGridViewTextBoxColumn
        '
        Me.BrtinDataGridViewTextBoxColumn.DataPropertyName = "brt_in"
        Me.BrtinDataGridViewTextBoxColumn.HeaderText = "Weight In (Kg)"
        Me.BrtinDataGridViewTextBoxColumn.Name = "BrtinDataGridViewTextBoxColumn"
        Me.BrtinDataGridViewTextBoxColumn.Width = 75
        '
        'UkbnhDataGridViewTextBoxColumn
        '
        Me.UkbnhDataGridViewTextBoxColumn.DataPropertyName = "uk_bnh"
        Me.UkbnhDataGridViewTextBoxColumn.HeaderText = "Ukuran Benih"
        Me.UkbnhDataGridViewTextBoxColumn.Name = "UkbnhDataGridViewTextBoxColumn"
        Me.UkbnhDataGridViewTextBoxColumn.Width = 75
        '
        'TakenDataGridViewTextBoxColumn
        '
        Me.TakenDataGridViewTextBoxColumn.DataPropertyName = "taken"
        Me.TakenDataGridViewTextBoxColumn.HeaderText = "Taken"
        Me.TakenDataGridViewTextBoxColumn.Name = "TakenDataGridViewTextBoxColumn"
        Me.TakenDataGridViewTextBoxColumn.Width = 75
        '
        'ppc2
        '
        Me.ppc2.DataPropertyName = "ppc2"
        Me.ppc2.HeaderText = "PPC2"
        Me.ppc2.Name = "ppc2"
        Me.ppc2.Width = 75
        '
        'UjikaDataGridViewCheckBoxColumn
        '
        Me.UjikaDataGridViewCheckBoxColumn.DataPropertyName = "uji_ka"
        Me.UjikaDataGridViewCheckBoxColumn.HeaderText = "uji_ka"
        Me.UjikaDataGridViewCheckBoxColumn.Name = "UjikaDataGridViewCheckBoxColumn"
        Me.UjikaDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UjikaDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.UjikaDataGridViewCheckBoxColumn.Width = 60
        '
        'UjiraDataGridViewCheckBoxColumn
        '
        Me.UjiraDataGridViewCheckBoxColumn.DataPropertyName = "uji_ra"
        Me.UjiraDataGridViewCheckBoxColumn.HeaderText = "uji_ra"
        Me.UjiraDataGridViewCheckBoxColumn.Name = "UjiraDataGridViewCheckBoxColumn"
        Me.UjiraDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UjiraDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.UjiraDataGridViewCheckBoxColumn.Width = 60
        '
        'UjidtDataGridViewCheckBoxColumn
        '
        Me.UjidtDataGridViewCheckBoxColumn.DataPropertyName = "uji_dt"
        Me.UjidtDataGridViewCheckBoxColumn.HeaderText = "uji_dt"
        Me.UjidtDataGridViewCheckBoxColumn.Name = "UjidtDataGridViewCheckBoxColumn"
        Me.UjidtDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UjidtDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.UjidtDataGridViewCheckBoxColumn.Width = 60
        '
        'AbkmsnDataGridViewTextBoxColumn
        '
        Me.AbkmsnDataGridViewTextBoxColumn.DataPropertyName = "ab_kmsn"
        Me.AbkmsnDataGridViewTextBoxColumn.HeaderText = "Kemasan"
        Me.AbkmsnDataGridViewTextBoxColumn.Name = "AbkmsnDataGridViewTextBoxColumn"
        Me.AbkmsnDataGridViewTextBoxColumn.Width = 75
        '
        'AbbnhDataGridViewTextBoxColumn
        '
        Me.AbbnhDataGridViewTextBoxColumn.DataPropertyName = "ab_bnh"
        Me.AbbnhDataGridViewTextBoxColumn.HeaderText = "Kondisi Benih"
        Me.AbbnhDataGridViewTextBoxColumn.Name = "AbbnhDataGridViewTextBoxColumn"
        Me.AbbnhDataGridViewTextBoxColumn.Width = 75
        '
        'AblabelDataGridViewTextBoxColumn
        '
        Me.AblabelDataGridViewTextBoxColumn.DataPropertyName = "ab_label"
        Me.AblabelDataGridViewTextBoxColumn.HeaderText = "Label"
        Me.AblabelDataGridViewTextBoxColumn.Name = "AblabelDataGridViewTextBoxColumn"
        Me.AblabelDataGridViewTextBoxColumn.Width = 75
        '
        'KetDataGridViewTextBoxColumn
        '
        Me.KetDataGridViewTextBoxColumn.DataPropertyName = "ket"
        Me.KetDataGridViewTextBoxColumn.HeaderText = "Remark"
        Me.KetDataGridViewTextBoxColumn.Name = "KetDataGridViewTextBoxColumn"
        '
        'Data_List_Periodik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 548)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Name = "Data_List_Periodik"
        Me.Padding = New System.Windows.Forms.Padding(20, 70, 20, 20)
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Data List Periodic"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeriodikmskBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents HCQC_serverDataSet As WindowsApplication1.HCQC_serverDataSet
    Friend WithEvents PeriodikmskBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Periodik_mskTableAdapter As WindowsApplication1.HCQC_serverDataSetTableAdapters.periodik_mskTableAdapter
    Friend WithEvents NolabDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VarietyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomnlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NojobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HvdtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DtqcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NextTsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BrtinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UkbnhDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TakenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ppc2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UjikaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UjiraDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UjidtDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AbkmsnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AbbnhDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AblabelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KetDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
