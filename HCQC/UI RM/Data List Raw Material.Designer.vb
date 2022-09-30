<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_List_Raw_Material
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
        Me.NolabDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VarietyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FarmerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LokasiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HvdtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DtqcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DttDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.mr1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.mr2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AvrgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vg_Dt_t = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VgfncDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AbnormalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HardDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FreshDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DeadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VgmtdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vg_analys = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vg_tgl_input = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TglprintDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ket = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RawMaterialJoinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_serverDataSet = New WindowsApplication1.HCQC_serverDataSet
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.RawMaterialJoinTableAdapter = New WindowsApplication1.HCQC_serverDataSetTableAdapters.RawMaterialJoinTableAdapter
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RawMaterialJoinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroGrid1
        '
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NolabDataGridViewTextBoxColumn, Me.VarietyDataGridViewTextBoxColumn, Me.FarmerDataGridViewTextBoxColumn, Me.LokasiDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.HvdtDataGridViewTextBoxColumn, Me.DtqcDataGridViewTextBoxColumn, Me.DttDataGridViewTextBoxColumn, Me.mr1, Me.mr2, Me.AvrgDataGridViewTextBoxColumn, Me.vg_Dt_t, Me.VgfncDataGridViewTextBoxColumn, Me.VgDataGridViewTextBoxColumn, Me.DtDataGridViewTextBoxColumn, Me.AbnormalDataGridViewTextBoxColumn, Me.HardDataGridViewTextBoxColumn, Me.FreshDataGridViewTextBoxColumn, Me.DeadDataGridViewTextBoxColumn, Me.VgmtdDataGridViewTextBoxColumn, Me.vg_analys, Me.vg_tgl_input, Me.TglprintDataGridViewTextBoxColumn, Me.ket})
        Me.MetroGrid1.DataSource = Me.RawMaterialJoinBindingSource
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
        Me.MetroGrid1.Size = New System.Drawing.Size(1150, 446)
        Me.MetroGrid1.TabIndex = 0
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
        Me.VarietyDataGridViewTextBoxColumn.Width = 75
        '
        'FarmerDataGridViewTextBoxColumn
        '
        Me.FarmerDataGridViewTextBoxColumn.DataPropertyName = "farmer"
        Me.FarmerDataGridViewTextBoxColumn.HeaderText = "Farmer"
        Me.FarmerDataGridViewTextBoxColumn.Name = "FarmerDataGridViewTextBoxColumn"
        '
        'LokasiDataGridViewTextBoxColumn
        '
        Me.LokasiDataGridViewTextBoxColumn.DataPropertyName = "lokasi"
        Me.LokasiDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LokasiDataGridViewTextBoxColumn.Name = "LokasiDataGridViewTextBoxColumn"
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "Weight (Kg)"
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        Me.WeightDataGridViewTextBoxColumn.Width = 75
        '
        'HvdtDataGridViewTextBoxColumn
        '
        Me.HvdtDataGridViewTextBoxColumn.DataPropertyName = "hv_dt"
        Me.HvdtDataGridViewTextBoxColumn.HeaderText = "Harvest"
        Me.HvdtDataGridViewTextBoxColumn.Name = "HvdtDataGridViewTextBoxColumn"
        Me.HvdtDataGridViewTextBoxColumn.Width = 75
        '
        'DtqcDataGridViewTextBoxColumn
        '
        Me.DtqcDataGridViewTextBoxColumn.DataPropertyName = "Dtqc"
        Me.DtqcDataGridViewTextBoxColumn.HeaderText = "Received"
        Me.DtqcDataGridViewTextBoxColumn.Name = "DtqcDataGridViewTextBoxColumn"
        Me.DtqcDataGridViewTextBoxColumn.Width = 75
        '
        'DttDataGridViewTextBoxColumn
        '
        Me.DttDataGridViewTextBoxColumn.DataPropertyName = "Dt_t"
        Me.DttDataGridViewTextBoxColumn.HeaderText = "Test Date KA"
        Me.DttDataGridViewTextBoxColumn.Name = "DttDataGridViewTextBoxColumn"
        Me.DttDataGridViewTextBoxColumn.Width = 72
        '
        'mr1
        '
        Me.mr1.DataPropertyName = "mr1"
        Me.mr1.HeaderText = "KA1"
        Me.mr1.Name = "mr1"
        Me.mr1.Width = 75
        '
        'mr2
        '
        Me.mr2.DataPropertyName = "mr2"
        Me.mr2.HeaderText = "KA2"
        Me.mr2.Name = "mr2"
        Me.mr2.Width = 75
        '
        'AvrgDataGridViewTextBoxColumn
        '
        Me.AvrgDataGridViewTextBoxColumn.DataPropertyName = "avrg"
        Me.AvrgDataGridViewTextBoxColumn.HeaderText = "Avrg KA"
        Me.AvrgDataGridViewTextBoxColumn.Name = "AvrgDataGridViewTextBoxColumn"
        Me.AvrgDataGridViewTextBoxColumn.Width = 75
        '
        'vg_Dt_t
        '
        Me.vg_Dt_t.DataPropertyName = "vg_Dt_t"
        Me.vg_Dt_t.HeaderText = "Test Date DB"
        Me.vg_Dt_t.Name = "vg_Dt_t"
        '
        'VgfncDataGridViewTextBoxColumn
        '
        Me.VgfncDataGridViewTextBoxColumn.DataPropertyName = "vg_fn_c"
        Me.VgfncDataGridViewTextBoxColumn.HeaderText = "2nd Count"
        Me.VgfncDataGridViewTextBoxColumn.Name = "VgfncDataGridViewTextBoxColumn"
        '
        'VgDataGridViewTextBoxColumn
        '
        Me.VgDataGridViewTextBoxColumn.DataPropertyName = "vg"
        Me.VgDataGridViewTextBoxColumn.HeaderText = "Vigor"
        Me.VgDataGridViewTextBoxColumn.Name = "VgDataGridViewTextBoxColumn"
        Me.VgDataGridViewTextBoxColumn.Width = 70
        '
        'DtDataGridViewTextBoxColumn
        '
        Me.DtDataGridViewTextBoxColumn.DataPropertyName = "dt"
        Me.DtDataGridViewTextBoxColumn.HeaderText = "Germ"
        Me.DtDataGridViewTextBoxColumn.Name = "DtDataGridViewTextBoxColumn"
        Me.DtDataGridViewTextBoxColumn.Width = 70
        '
        'AbnormalDataGridViewTextBoxColumn
        '
        Me.AbnormalDataGridViewTextBoxColumn.DataPropertyName = "Abnormal"
        Me.AbnormalDataGridViewTextBoxColumn.HeaderText = "Abnormal"
        Me.AbnormalDataGridViewTextBoxColumn.Name = "AbnormalDataGridViewTextBoxColumn"
        Me.AbnormalDataGridViewTextBoxColumn.Width = 75
        '
        'HardDataGridViewTextBoxColumn
        '
        Me.HardDataGridViewTextBoxColumn.DataPropertyName = "Hard"
        Me.HardDataGridViewTextBoxColumn.HeaderText = "Hard"
        Me.HardDataGridViewTextBoxColumn.Name = "HardDataGridViewTextBoxColumn"
        Me.HardDataGridViewTextBoxColumn.Width = 70
        '
        'FreshDataGridViewTextBoxColumn
        '
        Me.FreshDataGridViewTextBoxColumn.DataPropertyName = "Fresh"
        Me.FreshDataGridViewTextBoxColumn.HeaderText = "Fresh"
        Me.FreshDataGridViewTextBoxColumn.Name = "FreshDataGridViewTextBoxColumn"
        Me.FreshDataGridViewTextBoxColumn.Width = 70
        '
        'DeadDataGridViewTextBoxColumn
        '
        Me.DeadDataGridViewTextBoxColumn.DataPropertyName = "Dead"
        Me.DeadDataGridViewTextBoxColumn.HeaderText = "Dead"
        Me.DeadDataGridViewTextBoxColumn.Name = "DeadDataGridViewTextBoxColumn"
        Me.DeadDataGridViewTextBoxColumn.Width = 70
        '
        'VgmtdDataGridViewTextBoxColumn
        '
        Me.VgmtdDataGridViewTextBoxColumn.DataPropertyName = "vg_mtd"
        Me.VgmtdDataGridViewTextBoxColumn.HeaderText = "Method"
        Me.VgmtdDataGridViewTextBoxColumn.Name = "VgmtdDataGridViewTextBoxColumn"
        '
        'vg_analys
        '
        Me.vg_analys.DataPropertyName = "vg_analys"
        Me.vg_analys.FillWeight = 75.0!
        Me.vg_analys.HeaderText = "Analys"
        Me.vg_analys.Name = "vg_analys"
        '
        'vg_tgl_input
        '
        Me.vg_tgl_input.DataPropertyName = "vg_tgl_input"
        Me.vg_tgl_input.HeaderText = "Input Date"
        Me.vg_tgl_input.Name = "vg_tgl_input"
        '
        'TglprintDataGridViewTextBoxColumn
        '
        Me.TglprintDataGridViewTextBoxColumn.DataPropertyName = "tgl_print"
        Me.TglprintDataGridViewTextBoxColumn.HeaderText = "Print Out"
        Me.TglprintDataGridViewTextBoxColumn.Name = "TglprintDataGridViewTextBoxColumn"
        '
        'ket
        '
        Me.ket.DataPropertyName = "ket"
        Me.ket.HeaderText = "ket"
        Me.ket.Name = "ket"
        '
        'RawMaterialJoinBindingSource
        '
        Me.RawMaterialJoinBindingSource.DataMember = "RawMaterialJoin"
        Me.RawMaterialJoinBindingSource.DataSource = Me.HCQC_serverDataSet
        '
        'HCQC_serverDataSet
        '
        Me.HCQC_serverDataSet.DataSetName = "HCQC_serverDataSet"
        Me.HCQC_serverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        Me.MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Yellow
        '
        'RawMaterialJoinTableAdapter
        '
        Me.RawMaterialJoinTableAdapter.ClearBeforeFill = True
        '
        'Data_List_Raw_Material
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1196, 571)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Name = "Data_List_Raw_Material"
        Me.Padding = New System.Windows.Forms.Padding(20, 70, 20, 20)
        Me.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Text = "Data List Raw Material"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RawMaterialJoinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents HCQC_serverDataSet As WindowsApplication1.HCQC_serverDataSet
    Friend WithEvents RawMaterialJoinBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RawMaterialJoinTableAdapter As WindowsApplication1.HCQC_serverDataSetTableAdapters.RawMaterialJoinTableAdapter
    Friend WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents NolabDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VarietyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FarmerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LokasiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HvdtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DtqcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DttDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mr1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mr2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvrgDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vg_Dt_t As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VgfncDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VgDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AbnormalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HardDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FreshDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VgmtdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vg_analys As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vg_tgl_input As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglprintDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ket As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
