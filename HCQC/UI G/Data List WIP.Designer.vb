<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_List_WIP
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
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton
        Me.WipinspectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_serverDataSet = New WindowsApplication1.HCQC_serverDataSet
        Me.Wip_inspectionTableAdapter = New WindowsApplication1.HCQC_serverDataSetTableAdapters.wip_inspectionTableAdapter
        Me.NolabDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VarietyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NojobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VgmtdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VgfncDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Mr1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Mr2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AvrgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Paps1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.YgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IndDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PasedwgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AbnormalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HardDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FreshDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DeadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GermDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vg_tgl_input = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tgl_print = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WipinspectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NolabDataGridViewTextBoxColumn, Me.VarietyDataGridViewTextBoxColumn, Me.NojobDataGridViewTextBoxColumn, Me.VgmtdDataGridViewTextBoxColumn, Me.VgfncDataGridViewTextBoxColumn, Me.Mr1DataGridViewTextBoxColumn, Me.Mr2DataGridViewTextBoxColumn, Me.AvrgDataGridViewTextBoxColumn, Me.WsDataGridViewTextBoxColumn, Me.Paps1DataGridViewTextBoxColumn, Me.YgDataGridViewTextBoxColumn, Me.UsDataGridViewTextBoxColumn, Me.RtDataGridViewTextBoxColumn, Me.IndDataGridViewTextBoxColumn, Me.BrDataGridViewTextBoxColumn, Me.OdDataGridViewTextBoxColumn, Me.GrDataGridViewTextBoxColumn, Me.FgDataGridViewTextBoxColumn, Me.ImDataGridViewTextBoxColumn, Me.CrDataGridViewTextBoxColumn, Me.OvDataGridViewTextBoxColumn, Me.PasedwgDataGridViewTextBoxColumn, Me.DtDataGridViewTextBoxColumn, Me.AbnormalDataGridViewTextBoxColumn, Me.VgDataGridViewTextBoxColumn, Me.HardDataGridViewTextBoxColumn, Me.FreshDataGridViewTextBoxColumn, Me.DeadDataGridViewTextBoxColumn, Me.GermDataGridViewTextBoxColumn, Me.vg_tgl_input, Me.tgl_print})
        Me.MetroGrid1.DataSource = Me.WipinspectionBindingSource
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
        Me.MetroGrid1.Size = New System.Drawing.Size(862, 336)
        Me.MetroGrid1.TabIndex = 0
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(23, 63)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(105, 23)
        Me.MetroButton1.TabIndex = 4
        Me.MetroButton1.Text = "Refresh"
        Me.MetroButton1.UseSelectable = True
        '
        'WipinspectionBindingSource
        '
        Me.WipinspectionBindingSource.DataMember = "wip_inspection"
        Me.WipinspectionBindingSource.DataSource = Me.HCQC_serverDataSet
        '
        'HCQC_serverDataSet
        '
        Me.HCQC_serverDataSet.DataSetName = "HCQC_serverDataSet"
        Me.HCQC_serverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Wip_inspectionTableAdapter
        '
        Me.Wip_inspectionTableAdapter.ClearBeforeFill = True
        '
        'NolabDataGridViewTextBoxColumn
        '
        Me.NolabDataGridViewTextBoxColumn.DataPropertyName = "no_lab"
        Me.NolabDataGridViewTextBoxColumn.HeaderText = "No Lab"
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
        Me.NojobDataGridViewTextBoxColumn.HeaderText = "No Job"
        Me.NojobDataGridViewTextBoxColumn.Name = "NojobDataGridViewTextBoxColumn"
        '
        'VgmtdDataGridViewTextBoxColumn
        '
        Me.VgmtdDataGridViewTextBoxColumn.DataPropertyName = "vg_mtd"
        Me.VgmtdDataGridViewTextBoxColumn.HeaderText = "Method"
        Me.VgmtdDataGridViewTextBoxColumn.Name = "VgmtdDataGridViewTextBoxColumn"
        '
        'VgfncDataGridViewTextBoxColumn
        '
        Me.VgfncDataGridViewTextBoxColumn.DataPropertyName = "vg_fn_c"
        Me.VgfncDataGridViewTextBoxColumn.HeaderText = "Final Count"
        Me.VgfncDataGridViewTextBoxColumn.Name = "VgfncDataGridViewTextBoxColumn"
        '
        'Mr1DataGridViewTextBoxColumn
        '
        Me.Mr1DataGridViewTextBoxColumn.DataPropertyName = "mr1"
        Me.Mr1DataGridViewTextBoxColumn.HeaderText = "MT-1"
        Me.Mr1DataGridViewTextBoxColumn.Name = "Mr1DataGridViewTextBoxColumn"
        '
        'Mr2DataGridViewTextBoxColumn
        '
        Me.Mr2DataGridViewTextBoxColumn.DataPropertyName = "mr2"
        Me.Mr2DataGridViewTextBoxColumn.HeaderText = "MT-2"
        Me.Mr2DataGridViewTextBoxColumn.Name = "Mr2DataGridViewTextBoxColumn"
        '
        'AvrgDataGridViewTextBoxColumn
        '
        Me.AvrgDataGridViewTextBoxColumn.DataPropertyName = "avrg"
        Me.AvrgDataGridViewTextBoxColumn.HeaderText = "Total KA"
        Me.AvrgDataGridViewTextBoxColumn.Name = "AvrgDataGridViewTextBoxColumn"
        '
        'WsDataGridViewTextBoxColumn
        '
        Me.WsDataGridViewTextBoxColumn.DataPropertyName = "ws"
        Me.WsDataGridViewTextBoxColumn.HeaderText = "WorkSpl"
        Me.WsDataGridViewTextBoxColumn.Name = "WsDataGridViewTextBoxColumn"
        '
        'Paps1DataGridViewTextBoxColumn
        '
        Me.Paps1DataGridViewTextBoxColumn.DataPropertyName = "pa_ps1"
        Me.Paps1DataGridViewTextBoxColumn.HeaderText = "PureSd"
        Me.Paps1DataGridViewTextBoxColumn.Name = "Paps1DataGridViewTextBoxColumn"
        '
        'YgDataGridViewTextBoxColumn
        '
        Me.YgDataGridViewTextBoxColumn.DataPropertyName = "yg"
        Me.YgDataGridViewTextBoxColumn.HeaderText = "Young"
        Me.YgDataGridViewTextBoxColumn.Name = "YgDataGridViewTextBoxColumn"
        '
        'UsDataGridViewTextBoxColumn
        '
        Me.UsDataGridViewTextBoxColumn.DataPropertyName = "us"
        Me.UsDataGridViewTextBoxColumn.HeaderText = "UnderSz"
        Me.UsDataGridViewTextBoxColumn.Name = "UsDataGridViewTextBoxColumn"
        '
        'RtDataGridViewTextBoxColumn
        '
        Me.RtDataGridViewTextBoxColumn.DataPropertyName = "rt"
        Me.RtDataGridViewTextBoxColumn.HeaderText = "Rotten"
        Me.RtDataGridViewTextBoxColumn.Name = "RtDataGridViewTextBoxColumn"
        '
        'IndDataGridViewTextBoxColumn
        '
        Me.IndDataGridViewTextBoxColumn.DataPropertyName = "Ind"
        Me.IndDataGridViewTextBoxColumn.HeaderText = "Insect"
        Me.IndDataGridViewTextBoxColumn.Name = "IndDataGridViewTextBoxColumn"
        '
        'BrDataGridViewTextBoxColumn
        '
        Me.BrDataGridViewTextBoxColumn.DataPropertyName = "br"
        Me.BrDataGridViewTextBoxColumn.HeaderText = "Broken"
        Me.BrDataGridViewTextBoxColumn.Name = "BrDataGridViewTextBoxColumn"
        '
        'OdDataGridViewTextBoxColumn
        '
        Me.OdDataGridViewTextBoxColumn.DataPropertyName = "od"
        Me.OdDataGridViewTextBoxColumn.HeaderText = "Other"
        Me.OdDataGridViewTextBoxColumn.Name = "OdDataGridViewTextBoxColumn"
        '
        'GrDataGridViewTextBoxColumn
        '
        Me.GrDataGridViewTextBoxColumn.DataPropertyName = "gr"
        Me.GrDataGridViewTextBoxColumn.HeaderText = "Growth"
        Me.GrDataGridViewTextBoxColumn.Name = "GrDataGridViewTextBoxColumn"
        '
        'FgDataGridViewTextBoxColumn
        '
        Me.FgDataGridViewTextBoxColumn.DataPropertyName = "fg"
        Me.FgDataGridViewTextBoxColumn.HeaderText = "Fungi"
        Me.FgDataGridViewTextBoxColumn.Name = "FgDataGridViewTextBoxColumn"
        '
        'ImDataGridViewTextBoxColumn
        '
        Me.ImDataGridViewTextBoxColumn.DataPropertyName = "im"
        Me.ImDataGridViewTextBoxColumn.HeaderText = "Inert"
        Me.ImDataGridViewTextBoxColumn.Name = "ImDataGridViewTextBoxColumn"
        '
        'CrDataGridViewTextBoxColumn
        '
        Me.CrDataGridViewTextBoxColumn.DataPropertyName = "cr"
        Me.CrDataGridViewTextBoxColumn.HeaderText = "Crack"
        Me.CrDataGridViewTextBoxColumn.Name = "CrDataGridViewTextBoxColumn"
        '
        'OvDataGridViewTextBoxColumn
        '
        Me.OvDataGridViewTextBoxColumn.DataPropertyName = "ov"
        Me.OvDataGridViewTextBoxColumn.HeaderText = "CVL"
        Me.OvDataGridViewTextBoxColumn.Name = "OvDataGridViewTextBoxColumn"
        '
        'PasedwgDataGridViewTextBoxColumn
        '
        Me.PasedwgDataGridViewTextBoxColumn.DataPropertyName = "pa_sedwg"
        Me.PasedwgDataGridViewTextBoxColumn.HeaderText = "1000sd"
        Me.PasedwgDataGridViewTextBoxColumn.Name = "PasedwgDataGridViewTextBoxColumn"
        '
        'DtDataGridViewTextBoxColumn
        '
        Me.DtDataGridViewTextBoxColumn.DataPropertyName = "dt"
        Me.DtDataGridViewTextBoxColumn.HeaderText = "DT"
        Me.DtDataGridViewTextBoxColumn.Name = "DtDataGridViewTextBoxColumn"
        '
        'AbnormalDataGridViewTextBoxColumn
        '
        Me.AbnormalDataGridViewTextBoxColumn.DataPropertyName = "Abnormal"
        Me.AbnormalDataGridViewTextBoxColumn.HeaderText = "Abnormal"
        Me.AbnormalDataGridViewTextBoxColumn.Name = "AbnormalDataGridViewTextBoxColumn"
        '
        'VgDataGridViewTextBoxColumn
        '
        Me.VgDataGridViewTextBoxColumn.DataPropertyName = "vg"
        Me.VgDataGridViewTextBoxColumn.HeaderText = "VG"
        Me.VgDataGridViewTextBoxColumn.Name = "VgDataGridViewTextBoxColumn"
        '
        'HardDataGridViewTextBoxColumn
        '
        Me.HardDataGridViewTextBoxColumn.DataPropertyName = "Hard"
        Me.HardDataGridViewTextBoxColumn.HeaderText = "Hard"
        Me.HardDataGridViewTextBoxColumn.Name = "HardDataGridViewTextBoxColumn"
        '
        'FreshDataGridViewTextBoxColumn
        '
        Me.FreshDataGridViewTextBoxColumn.DataPropertyName = "Fresh"
        Me.FreshDataGridViewTextBoxColumn.HeaderText = "Fresh"
        Me.FreshDataGridViewTextBoxColumn.Name = "FreshDataGridViewTextBoxColumn"
        '
        'DeadDataGridViewTextBoxColumn
        '
        Me.DeadDataGridViewTextBoxColumn.DataPropertyName = "Dead"
        Me.DeadDataGridViewTextBoxColumn.HeaderText = "Dead"
        Me.DeadDataGridViewTextBoxColumn.Name = "DeadDataGridViewTextBoxColumn"
        '
        'GermDataGridViewTextBoxColumn
        '
        Me.GermDataGridViewTextBoxColumn.DataPropertyName = "Germ"
        Me.GermDataGridViewTextBoxColumn.HeaderText = "Germ"
        Me.GermDataGridViewTextBoxColumn.Name = "GermDataGridViewTextBoxColumn"
        '
        'vg_tgl_input
        '
        Me.vg_tgl_input.DataPropertyName = "vg_tgl_input"
        Me.vg_tgl_input.HeaderText = "vg_tgl_input"
        Me.vg_tgl_input.Name = "vg_tgl_input"
        '
        'tgl_print
        '
        Me.tgl_print.DataPropertyName = "tgl_print"
        Me.tgl_print.HeaderText = "tgl_print"
        Me.tgl_print.Name = "tgl_print"
        '
        'Data_List_WIP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 451)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Name = "Data_List_WIP"
        Me.Text = "Data_List_WIP"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WipinspectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents HCQC_serverDataSet As WindowsApplication1.HCQC_serverDataSet
    Friend WithEvents WipinspectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Wip_inspectionTableAdapter As WindowsApplication1.HCQC_serverDataSetTableAdapters.wip_inspectionTableAdapter
    Friend WithEvents NolabDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VarietyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NojobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VgmtdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VgfncDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mr1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mr2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvrgDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Paps1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YgDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FgDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OvDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasedwgDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AbnormalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VgDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HardDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FreshDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GermDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vg_tgl_input As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tgl_print As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
