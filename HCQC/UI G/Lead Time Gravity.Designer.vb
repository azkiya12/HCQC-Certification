<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lead_Time_Gravity
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
        Me.LeadviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_serverDataSet = New WindowsApplication1.HCQC_serverDataSet
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.LeadviewTableAdapter = New WindowsApplication1.HCQC_serverDataSetTableAdapters.leadviewTableAdapter
        Me.NolabDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VarietyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nomnl = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NojobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.uk_bnh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReceivedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.test_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fist = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pengamatan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UjikaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UjiraDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UjidtDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ka_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dt_t = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vg_fn_c = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vg_tgl_input = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ESTIMASI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ESTIMASIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LeadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Evaluasi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ket = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeadviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NolabDataGridViewTextBoxColumn, Me.VarietyDataGridViewTextBoxColumn, Me.nomnl, Me.NojobDataGridViewTextBoxColumn, Me.uk_bnh, Me.ReceivedDataGridViewTextBoxColumn, Me.test_date, Me.Fist, Me.Pengamatan, Me.UjikaDataGridViewCheckBoxColumn, Me.UjiraDataGridViewCheckBoxColumn, Me.UjidtDataGridViewCheckBoxColumn, Me.ka_date, Me.dt_t, Me.vg_fn_c, Me.vg_tgl_input, Me.ESTIMASI, Me.ESTIMASIDataGridViewTextBoxColumn, Me.LeadDataGridViewTextBoxColumn, Me.Evaluasi, Me.ket})
        Me.MetroGrid1.DataSource = Me.LeadviewBindingSource
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
        Me.MetroGrid1.TabIndex = 0
        '
        'LeadviewBindingSource
        '
        Me.LeadviewBindingSource.DataMember = "leadview"
        Me.LeadviewBindingSource.DataSource = Me.HCQC_serverDataSet
        '
        'HCQC_serverDataSet
        '
        Me.HCQC_serverDataSet.DataSetName = "HCQC_serverDataSet"
        Me.HCQC_serverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
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
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(134, 63)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(105, 23)
        Me.MetroButton2.TabIndex = 3
        Me.MetroButton2.Text = "Print Preview"
        Me.MetroButton2.UseSelectable = True
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'LeadviewTableAdapter
        '
        Me.LeadviewTableAdapter.ClearBeforeFill = True
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
        'nomnl
        '
        Me.nomnl.DataPropertyName = "nomnl"
        Me.nomnl.HeaderText = "Manual"
        Me.nomnl.Name = "nomnl"
        '
        'NojobDataGridViewTextBoxColumn
        '
        Me.NojobDataGridViewTextBoxColumn.DataPropertyName = "nojob"
        Me.NojobDataGridViewTextBoxColumn.HeaderText = "Job No"
        Me.NojobDataGridViewTextBoxColumn.Name = "NojobDataGridViewTextBoxColumn"
        Me.NojobDataGridViewTextBoxColumn.Width = 75
        '
        'uk_bnh
        '
        Me.uk_bnh.DataPropertyName = "uk_bnh"
        Me.uk_bnh.HeaderText = "Type"
        Me.uk_bnh.Name = "uk_bnh"
        '
        'ReceivedDataGridViewTextBoxColumn
        '
        Me.ReceivedDataGridViewTextBoxColumn.DataPropertyName = "Received"
        Me.ReceivedDataGridViewTextBoxColumn.HeaderText = "Received"
        Me.ReceivedDataGridViewTextBoxColumn.Name = "ReceivedDataGridViewTextBoxColumn"
        '
        'test_date
        '
        Me.test_date.DataPropertyName = "test_date"
        Me.test_date.HeaderText = "Tanggal Uji"
        Me.test_date.Name = "test_date"
        '
        'Fist
        '
        Me.Fist.DataPropertyName = "Fist"
        Me.Fist.HeaderText = "Est 1stCount"
        Me.Fist.Name = "Fist"
        Me.Fist.ReadOnly = True
        '
        'Pengamatan
        '
        Me.Pengamatan.DataPropertyName = "Pengamatan"
        Me.Pengamatan.HeaderText = "Est 2ndCount"
        Me.Pengamatan.Name = "Pengamatan"
        Me.Pengamatan.ReadOnly = True
        '
        'UjikaDataGridViewCheckBoxColumn
        '
        Me.UjikaDataGridViewCheckBoxColumn.DataPropertyName = "uji_ka"
        Me.UjikaDataGridViewCheckBoxColumn.HeaderText = "uji_ka"
        Me.UjikaDataGridViewCheckBoxColumn.Name = "UjikaDataGridViewCheckBoxColumn"
        Me.UjikaDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UjikaDataGridViewCheckBoxColumn.Width = 50
        '
        'UjiraDataGridViewCheckBoxColumn
        '
        Me.UjiraDataGridViewCheckBoxColumn.DataPropertyName = "uji_ra"
        Me.UjiraDataGridViewCheckBoxColumn.HeaderText = "uji_ra"
        Me.UjiraDataGridViewCheckBoxColumn.Name = "UjiraDataGridViewCheckBoxColumn"
        Me.UjiraDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UjiraDataGridViewCheckBoxColumn.Width = 50
        '
        'UjidtDataGridViewCheckBoxColumn
        '
        Me.UjidtDataGridViewCheckBoxColumn.DataPropertyName = "uji_dt"
        Me.UjidtDataGridViewCheckBoxColumn.HeaderText = "uji_dt"
        Me.UjidtDataGridViewCheckBoxColumn.Name = "UjidtDataGridViewCheckBoxColumn"
        Me.UjidtDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UjidtDataGridViewCheckBoxColumn.Width = 50
        '
        'ka_date
        '
        Me.ka_date.DataPropertyName = "ka_date"
        Me.ka_date.HeaderText = "KA"
        Me.ka_date.Name = "ka_date"
        '
        'dt_t
        '
        Me.dt_t.DataPropertyName = "dt_t"
        Me.dt_t.HeaderText = "RA"
        Me.dt_t.Name = "dt_t"
        '
        'vg_fn_c
        '
        Me.vg_fn_c.DataPropertyName = "vg_fn_c"
        Me.vg_fn_c.HeaderText = "2ndCount"
        Me.vg_fn_c.Name = "vg_fn_c"
        '
        'vg_tgl_input
        '
        Me.vg_tgl_input.DataPropertyName = "vg_tgl_input"
        Me.vg_tgl_input.HeaderText = "DT Input"
        Me.vg_tgl_input.Name = "vg_tgl_input"
        Me.vg_tgl_input.ToolTipText = "Tanggal Penginputan Data"
        '
        'ESTIMASI
        '
        Me.ESTIMASI.DataPropertyName = "ESTIMASI"
        Me.ESTIMASI.HeaderText = "ESTIMASI"
        Me.ESTIMASI.Name = "ESTIMASI"
        Me.ESTIMASI.ReadOnly = True
        '
        'ESTIMASIDataGridViewTextBoxColumn
        '
        Me.ESTIMASIDataGridViewTextBoxColumn.DataPropertyName = "Real"
        Me.ESTIMASIDataGridViewTextBoxColumn.HeaderText = "Real Time"
        Me.ESTIMASIDataGridViewTextBoxColumn.Name = "ESTIMASIDataGridViewTextBoxColumn"
        Me.ESTIMASIDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LeadDataGridViewTextBoxColumn
        '
        Me.LeadDataGridViewTextBoxColumn.DataPropertyName = "lead"
        Me.LeadDataGridViewTextBoxColumn.HeaderText = "Lead Time"
        Me.LeadDataGridViewTextBoxColumn.Name = "LeadDataGridViewTextBoxColumn"
        '
        'Evaluasi
        '
        Me.Evaluasi.DataPropertyName = "Evaluasi"
        Me.Evaluasi.HeaderText = "Evaluasi"
        Me.Evaluasi.Name = "Evaluasi"
        Me.Evaluasi.ReadOnly = True
        Me.Evaluasi.ToolTipText = "negativ is lebih cepat jika positiv is lebih lambat/telat dari waktu yang di tent" & _
            "ukan"
        '
        'ket
        '
        Me.ket.DataPropertyName = "ket"
        Me.ket.HeaderText = "Keterangan"
        Me.ket.Name = "ket"
        '
        'Lead_Time_Gravity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 628)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Name = "Lead_Time_Gravity"
        Me.Text = "Lead Time Gravity"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeadviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents HCQC_serverDataSet As WindowsApplication1.HCQC_serverDataSet
    Friend WithEvents LeadviewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LeadviewTableAdapter As WindowsApplication1.HCQC_serverDataSetTableAdapters.leadviewTableAdapter
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents NolabDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VarietyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomnl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NojobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents uk_bnh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceivedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents test_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fist As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pengamatan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UjikaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UjiraDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UjidtDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ka_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dt_t As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vg_fn_c As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vg_tgl_input As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTIMASI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTIMASIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LeadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Evaluasi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ket As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
