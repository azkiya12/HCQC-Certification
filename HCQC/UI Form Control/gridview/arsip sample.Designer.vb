<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class arsip_sample
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(arsip_sample))
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.BtnRefresh = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.HCQC_serverDataSet = New HCQC_serverDataSet()
        Me.ReportarsipsampleviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Report_arsip_sample_viewTableAdapter = New HCQC_serverDataSetTableAdapters.report_arsip_sample_viewTableAdapter()
        Me.LabnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScopeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarietyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomnlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotqttDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrtinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArsipdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LokasiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BoxnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestroydateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportarsipsampleviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LabnumDataGridViewTextBoxColumn, Me.ScopeDataGridViewTextBoxColumn, Me.VarietyDataGridViewTextBoxColumn, Me.NomnlDataGridViewTextBoxColumn, Me.LotidDataGridViewTextBoxColumn, Me.LotqttDataGridViewTextBoxColumn, Me.BrtinDataGridViewTextBoxColumn, Me.DateinDataGridViewTextBoxColumn, Me.ArsipdateDataGridViewTextBoxColumn, Me.LokasiDataGridViewTextBoxColumn, Me.BoxnumDataGridViewTextBoxColumn, Me.DestroydateDataGridViewTextBoxColumn})
        Me.MetroGrid1.DataSource = Me.ReportarsipsampleviewBindingSource
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
        Me.MetroGrid1.Location = New System.Drawing.Point(23, 99)
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
        Me.MetroGrid1.Size = New System.Drawing.Size(754, 328)
        Me.MetroGrid1.TabIndex = 0
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRefresh.BorderRadius = 0
        Me.BtnRefresh.ButtonText = "Refresh"
        Me.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRefresh.DisabledColor = System.Drawing.Color.Gray
        Me.BtnRefresh.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnRefresh.Iconimage = CType(resources.GetObject("BtnRefresh.Iconimage"), System.Drawing.Image)
        Me.BtnRefresh.Iconimage_right = Nothing
        Me.BtnRefresh.Iconimage_right_Selected = Nothing
        Me.BtnRefresh.Iconimage_Selected = Nothing
        Me.BtnRefresh.IconMarginLeft = 0
        Me.BtnRefresh.IconMarginRight = 0
        Me.BtnRefresh.IconRightVisible = True
        Me.BtnRefresh.IconRightZoom = 0R
        Me.BtnRefresh.IconVisible = True
        Me.BtnRefresh.IconZoom = 50.0R
        Me.BtnRefresh.IsTab = False
        Me.BtnRefresh.Location = New System.Drawing.Point(23, 63)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnRefresh.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnRefresh.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnRefresh.selected = True
        Me.BtnRefresh.Size = New System.Drawing.Size(126, 30)
        Me.BtnRefresh.TabIndex = 3
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefresh.Textcolor = System.Drawing.Color.White
        Me.BtnRefresh.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'HCQC_serverDataSet
        '
        Me.HCQC_serverDataSet.DataSetName = "HCQC_serverDataSet"
        Me.HCQC_serverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportarsipsampleviewBindingSource
        '
        Me.ReportarsipsampleviewBindingSource.DataMember = "report_arsip_sample_view"
        Me.ReportarsipsampleviewBindingSource.DataSource = Me.HCQC_serverDataSet
        '
        'Report_arsip_sample_viewTableAdapter
        '
        Me.Report_arsip_sample_viewTableAdapter.ClearBeforeFill = True
        '
        'LabnumDataGridViewTextBoxColumn
        '
        Me.LabnumDataGridViewTextBoxColumn.DataPropertyName = "labnum"
        Me.LabnumDataGridViewTextBoxColumn.HeaderText = "No Lab"
        Me.LabnumDataGridViewTextBoxColumn.Name = "LabnumDataGridViewTextBoxColumn"
        '
        'ScopeDataGridViewTextBoxColumn
        '
        Me.ScopeDataGridViewTextBoxColumn.DataPropertyName = "scope"
        Me.ScopeDataGridViewTextBoxColumn.HeaderText = "Scope"
        Me.ScopeDataGridViewTextBoxColumn.Name = "ScopeDataGridViewTextBoxColumn"
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
        Me.NomnlDataGridViewTextBoxColumn.HeaderText = "No Mnl"
        Me.NomnlDataGridViewTextBoxColumn.Name = "NomnlDataGridViewTextBoxColumn"
        Me.NomnlDataGridViewTextBoxColumn.Width = 65
        '
        'LotidDataGridViewTextBoxColumn
        '
        Me.LotidDataGridViewTextBoxColumn.DataPropertyName = "lotid"
        Me.LotidDataGridViewTextBoxColumn.HeaderText = "LOT"
        Me.LotidDataGridViewTextBoxColumn.Name = "LotidDataGridViewTextBoxColumn"
        '
        'LotqttDataGridViewTextBoxColumn
        '
        Me.LotqttDataGridViewTextBoxColumn.DataPropertyName = "lotqtt"
        Me.LotqttDataGridViewTextBoxColumn.HeaderText = "Berat Lot (kg)"
        Me.LotqttDataGridViewTextBoxColumn.Name = "LotqttDataGridViewTextBoxColumn"
        '
        'BrtinDataGridViewTextBoxColumn
        '
        Me.BrtinDataGridViewTextBoxColumn.DataPropertyName = "brt_in"
        Me.BrtinDataGridViewTextBoxColumn.HeaderText = "Berat Sampel (g)"
        Me.BrtinDataGridViewTextBoxColumn.Name = "BrtinDataGridViewTextBoxColumn"
        '
        'DateinDataGridViewTextBoxColumn
        '
        Me.DateinDataGridViewTextBoxColumn.DataPropertyName = "datein"
        Me.DateinDataGridViewTextBoxColumn.HeaderText = "Tanggal Terima"
        Me.DateinDataGridViewTextBoxColumn.Name = "DateinDataGridViewTextBoxColumn"
        '
        'ArsipdateDataGridViewTextBoxColumn
        '
        Me.ArsipdateDataGridViewTextBoxColumn.DataPropertyName = "arsipdate"
        Me.ArsipdateDataGridViewTextBoxColumn.HeaderText = "Tanggal Arsip"
        Me.ArsipdateDataGridViewTextBoxColumn.Name = "ArsipdateDataGridViewTextBoxColumn"
        '
        'LokasiDataGridViewTextBoxColumn
        '
        Me.LokasiDataGridViewTextBoxColumn.DataPropertyName = "lokasi"
        Me.LokasiDataGridViewTextBoxColumn.HeaderText = "Lokasi"
        Me.LokasiDataGridViewTextBoxColumn.Name = "LokasiDataGridViewTextBoxColumn"
        '
        'BoxnumDataGridViewTextBoxColumn
        '
        Me.BoxnumDataGridViewTextBoxColumn.DataPropertyName = "boxnum"
        Me.BoxnumDataGridViewTextBoxColumn.HeaderText = "No Box"
        Me.BoxnumDataGridViewTextBoxColumn.Name = "BoxnumDataGridViewTextBoxColumn"
        '
        'DestroydateDataGridViewTextBoxColumn
        '
        Me.DestroydateDataGridViewTextBoxColumn.DataPropertyName = "destroydate"
        Me.DestroydateDataGridViewTextBoxColumn.HeaderText = "Tanggal Pemusnahan"
        Me.DestroydateDataGridViewTextBoxColumn.Name = "DestroydateDataGridViewTextBoxColumn"
        '
        'arsip_sample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Name = "arsip_sample"
        Me.Text = "Arsip Sample"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportarsipsampleviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroGrid1 As MetroGrid
    Friend WithEvents BtnRefresh As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents HCQC_serverDataSet As HCQC_serverDataSet
    Friend WithEvents ReportarsipsampleviewBindingSource As BindingSource
    Friend WithEvents Report_arsip_sample_viewTableAdapter As HCQC_serverDataSetTableAdapters.report_arsip_sample_viewTableAdapter
    Friend WithEvents LabnumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScopeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarietyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomnlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LotidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LotqttDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrtinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArsipdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LokasiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BoxnumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DestroydateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
