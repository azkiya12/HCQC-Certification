<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_List_Refraction
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
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.RafactionListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_serverDataSet = New WindowsApplication1.HCQC_serverDataSet
        Me.RafactionListTableAdapter = New WindowsApplication1.HCQC_serverDataSetTableAdapters.RafactionListTableAdapter
        Me.NolabDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VarietyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NomnlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NojobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DttDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.psd_n = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Paws1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Paps1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PaosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Paim1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.YgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IndDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PasedwgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.t_ra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ResulDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AnalysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TglinputDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RafactionListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Location = New System.Drawing.Point(23, 63)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(1182, 423)
        Me.MetroTabControl1.TabIndex = 1
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.MetroGrid1)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(1174, 381)
        Me.MetroTabPage1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Internal Refraction"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NolabDataGridViewTextBoxColumn, Me.VarietyDataGridViewTextBoxColumn, Me.NomnlDataGridViewTextBoxColumn, Me.NojobDataGridViewTextBoxColumn, Me.DttDataGridViewTextBoxColumn, Me.psd_n, Me.Paws1DataGridViewTextBoxColumn, Me.Paps1DataGridViewTextBoxColumn, Me.PaosDataGridViewTextBoxColumn, Me.Paim1DataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.YgDataGridViewTextBoxColumn, Me.UsDataGridViewTextBoxColumn, Me.RtDataGridViewTextBoxColumn, Me.IndDataGridViewTextBoxColumn, Me.BrDataGridViewTextBoxColumn, Me.OdDataGridViewTextBoxColumn, Me.GrDataGridViewTextBoxColumn, Me.FgDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn3, Me.CrDataGridViewTextBoxColumn, Me.OvDataGridViewTextBoxColumn, Me.PasedwgDataGridViewTextBoxColumn, Me.t_ra, Me.ResulDataGridViewCheckBoxColumn, Me.AnalysDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn4, Me.TglinputDataGridViewTextBoxColumn})
        Me.MetroGrid1.DataSource = Me.RafactionListBindingSource
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
        Me.MetroGrid1.Location = New System.Drawing.Point(3, 15)
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
        Me.MetroGrid1.Size = New System.Drawing.Size(1168, 361)
        Me.MetroGrid1.TabIndex = 2
        '
        'MetroButton1
        '
        Me.MetroButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton1.Location = New System.Drawing.Point(1100, 34)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(105, 23)
        Me.MetroButton1.TabIndex = 2
        Me.MetroButton1.Text = "Refresh"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        '
        'RafactionListBindingSource
        '
        Me.RafactionListBindingSource.DataMember = "RafactionList"
        Me.RafactionListBindingSource.DataSource = Me.HCQC_serverDataSet
        '
        'HCQC_serverDataSet
        '
        Me.HCQC_serverDataSet.DataSetName = "HCQC_serverDataSet"
        Me.HCQC_serverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RafactionListTableAdapter
        '
        Me.RafactionListTableAdapter.ClearBeforeFill = True
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
        'DttDataGridViewTextBoxColumn
        '
        Me.DttDataGridViewTextBoxColumn.DataPropertyName = "dt_t"
        Me.DttDataGridViewTextBoxColumn.HeaderText = "Date Test"
        Me.DttDataGridViewTextBoxColumn.Name = "DttDataGridViewTextBoxColumn"
        Me.DttDataGridViewTextBoxColumn.Width = 75
        '
        'psd_n
        '
        Me.psd_n.DataPropertyName = "psd_n"
        Me.psd_n.HeaderText = "PSD No."
        Me.psd_n.Name = "psd_n"
        Me.psd_n.Width = 75
        '
        'Paws1DataGridViewTextBoxColumn
        '
        Me.Paws1DataGridViewTextBoxColumn.DataPropertyName = "pa_ws1"
        Me.Paws1DataGridViewTextBoxColumn.HeaderText = "PA Ws"
        Me.Paws1DataGridViewTextBoxColumn.Name = "Paws1DataGridViewTextBoxColumn"
        Me.Paws1DataGridViewTextBoxColumn.Width = 65
        '
        'Paps1DataGridViewTextBoxColumn
        '
        Me.Paps1DataGridViewTextBoxColumn.DataPropertyName = "pa_ps1"
        Me.Paps1DataGridViewTextBoxColumn.HeaderText = "PA Pure"
        Me.Paps1DataGridViewTextBoxColumn.Name = "Paps1DataGridViewTextBoxColumn"
        Me.Paps1DataGridViewTextBoxColumn.Width = 50
        '
        'PaosDataGridViewTextBoxColumn
        '
        Me.PaosDataGridViewTextBoxColumn.DataPropertyName = "pa_os"
        Me.PaosDataGridViewTextBoxColumn.HeaderText = "PA Oth"
        Me.PaosDataGridViewTextBoxColumn.Name = "PaosDataGridViewTextBoxColumn"
        Me.PaosDataGridViewTextBoxColumn.Width = 70
        '
        'Paim1DataGridViewTextBoxColumn
        '
        Me.Paim1DataGridViewTextBoxColumn.DataPropertyName = "pa_im1"
        Me.Paim1DataGridViewTextBoxColumn.HeaderText = "PA Inert"
        Me.Paim1DataGridViewTextBoxColumn.Name = "Paim1DataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ws"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Work Spl"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ps"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Pale Sd"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'YgDataGridViewTextBoxColumn
        '
        Me.YgDataGridViewTextBoxColumn.DataPropertyName = "yg"
        Me.YgDataGridViewTextBoxColumn.HeaderText = "Young"
        Me.YgDataGridViewTextBoxColumn.Name = "YgDataGridViewTextBoxColumn"
        Me.YgDataGridViewTextBoxColumn.Width = 50
        '
        'UsDataGridViewTextBoxColumn
        '
        Me.UsDataGridViewTextBoxColumn.DataPropertyName = "us"
        Me.UsDataGridViewTextBoxColumn.HeaderText = "Under Sz"
        Me.UsDataGridViewTextBoxColumn.Name = "UsDataGridViewTextBoxColumn"
        Me.UsDataGridViewTextBoxColumn.Width = 50
        '
        'RtDataGridViewTextBoxColumn
        '
        Me.RtDataGridViewTextBoxColumn.DataPropertyName = "rt"
        Me.RtDataGridViewTextBoxColumn.HeaderText = "Rotten"
        Me.RtDataGridViewTextBoxColumn.Name = "RtDataGridViewTextBoxColumn"
        Me.RtDataGridViewTextBoxColumn.Width = 60
        '
        'IndDataGridViewTextBoxColumn
        '
        Me.IndDataGridViewTextBoxColumn.DataPropertyName = "Ind"
        Me.IndDataGridViewTextBoxColumn.HeaderText = "Insect Damage"
        Me.IndDataGridViewTextBoxColumn.Name = "IndDataGridViewTextBoxColumn"
        Me.IndDataGridViewTextBoxColumn.Width = 50
        '
        'BrDataGridViewTextBoxColumn
        '
        Me.BrDataGridViewTextBoxColumn.DataPropertyName = "br"
        Me.BrDataGridViewTextBoxColumn.HeaderText = "Broken"
        Me.BrDataGridViewTextBoxColumn.Name = "BrDataGridViewTextBoxColumn"
        Me.BrDataGridViewTextBoxColumn.Width = 50
        '
        'OdDataGridViewTextBoxColumn
        '
        Me.OdDataGridViewTextBoxColumn.DataPropertyName = "od"
        Me.OdDataGridViewTextBoxColumn.HeaderText = "Other Deterio"
        Me.OdDataGridViewTextBoxColumn.Name = "OdDataGridViewTextBoxColumn"
        Me.OdDataGridViewTextBoxColumn.Width = 50
        '
        'GrDataGridViewTextBoxColumn
        '
        Me.GrDataGridViewTextBoxColumn.DataPropertyName = "gr"
        Me.GrDataGridViewTextBoxColumn.HeaderText = "Growth"
        Me.GrDataGridViewTextBoxColumn.Name = "GrDataGridViewTextBoxColumn"
        Me.GrDataGridViewTextBoxColumn.Width = 60
        '
        'FgDataGridViewTextBoxColumn
        '
        Me.FgDataGridViewTextBoxColumn.DataPropertyName = "fg"
        Me.FgDataGridViewTextBoxColumn.HeaderText = "Fungi"
        Me.FgDataGridViewTextBoxColumn.Name = "FgDataGridViewTextBoxColumn"
        Me.FgDataGridViewTextBoxColumn.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "im"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Inert Metter"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'CrDataGridViewTextBoxColumn
        '
        Me.CrDataGridViewTextBoxColumn.DataPropertyName = "cr"
        Me.CrDataGridViewTextBoxColumn.HeaderText = "Crack"
        Me.CrDataGridViewTextBoxColumn.Name = "CrDataGridViewTextBoxColumn"
        Me.CrDataGridViewTextBoxColumn.Width = 50
        '
        'OvDataGridViewTextBoxColumn
        '
        Me.OvDataGridViewTextBoxColumn.DataPropertyName = "ov"
        Me.OvDataGridViewTextBoxColumn.HeaderText = "CVL"
        Me.OvDataGridViewTextBoxColumn.Name = "OvDataGridViewTextBoxColumn"
        Me.OvDataGridViewTextBoxColumn.Width = 50
        '
        'PasedwgDataGridViewTextBoxColumn
        '
        Me.PasedwgDataGridViewTextBoxColumn.DataPropertyName = "pa_sedwg"
        Me.PasedwgDataGridViewTextBoxColumn.HeaderText = "1000sd"
        Me.PasedwgDataGridViewTextBoxColumn.Name = "PasedwgDataGridViewTextBoxColumn"
        Me.PasedwgDataGridViewTextBoxColumn.Width = 60
        '
        't_ra
        '
        Me.t_ra.DataPropertyName = "t_ra"
        Me.t_ra.HeaderText = "SUM RA"
        Me.t_ra.Name = "t_ra"
        Me.t_ra.ReadOnly = True
        '
        'ResulDataGridViewCheckBoxColumn
        '
        Me.ResulDataGridViewCheckBoxColumn.DataPropertyName = "resul"
        Me.ResulDataGridViewCheckBoxColumn.HeaderText = "Result"
        Me.ResulDataGridViewCheckBoxColumn.Name = "ResulDataGridViewCheckBoxColumn"
        Me.ResulDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ResulDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ResulDataGridViewCheckBoxColumn.Width = 50
        '
        'AnalysDataGridViewTextBoxColumn
        '
        Me.AnalysDataGridViewTextBoxColumn.DataPropertyName = "analys"
        Me.AnalysDataGridViewTextBoxColumn.HeaderText = "Analys"
        Me.AnalysDataGridViewTextBoxColumn.Name = "AnalysDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ket"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Remark"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'TglinputDataGridViewTextBoxColumn
        '
        Me.TglinputDataGridViewTextBoxColumn.DataPropertyName = "tgl_input"
        Me.TglinputDataGridViewTextBoxColumn.HeaderText = "Input Date"
        Me.TglinputDataGridViewTextBoxColumn.Name = "TglinputDataGridViewTextBoxColumn"
        Me.TglinputDataGridViewTextBoxColumn.Width = 75
        '
        'Data_List_Refraction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1228, 509)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Name = "Data_List_Refraction"
        Me.Text = "Data List Refraction"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RafactionListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents SedwgDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KetDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents HCQC_serverDataSet As WindowsApplication1.HCQC_serverDataSet
    Friend WithEvents RafactionListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RafactionListTableAdapter As WindowsApplication1.HCQC_serverDataSetTableAdapters.RafactionListTableAdapter
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents NolabDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VarietyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomnlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NojobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DttDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents psd_n As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Paws1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Paps1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Paim1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YgDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FgDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OvDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasedwgDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t_ra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResulDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnalysDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglinputDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
