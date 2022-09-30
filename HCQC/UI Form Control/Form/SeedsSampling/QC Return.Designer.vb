<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QC_Return
    Inherits MetroFramework.Controls.MetroUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.Id_requestColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarietyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FarmerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HarvestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomnlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NojobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScopeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamareqDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglconfirmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamappcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglkirimColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RafaksiTextColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RafaksiColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BtnCheck = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BtnDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.QcconfirmviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_NewDataset = New WindowsApplication1.HCQC_NewDataset()
        Me.Qc_confirm_viewTableAdapter = New WindowsApplication1.HCQC_NewDatasetTableAdapters.qc_confirm_viewTableAdapter()
        Me.MetroLink2 = New MetroFramework.Controls.MetroLink()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QcconfirmviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        Me.MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_requestColumn, Me.VarietyDataGridViewTextBoxColumn, Me.FarmerDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.HarvestDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.NomnlDataGridViewTextBoxColumn, Me.NojobDataGridViewTextBoxColumn, Me.ScopeDataGridViewTextBoxColumn, Me.NamareqDataGridViewTextBoxColumn, Me.TglconfirmDataGridViewTextBoxColumn, Me.NamappcDataGridViewTextBoxColumn, Me.TglkirimColumn, Me.RafaksiTextColumn, Me.RafaksiColumn, Me.BtnCheck, Me.BtnDel})
        Me.MetroGrid1.DataSource = Me.QcconfirmviewBindingSource
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
        Me.MetroGrid1.Location = New System.Drawing.Point(3, 32)
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
        Me.MetroGrid1.Size = New System.Drawing.Size(775, 416)
        Me.MetroGrid1.TabIndex = 0
        '
        'Id_requestColumn
        '
        Me.Id_requestColumn.DataPropertyName = "id"
        Me.Id_requestColumn.HeaderText = "Request Number"
        Me.Id_requestColumn.Name = "Id_requestColumn"
        '
        'VarietyDataGridViewTextBoxColumn
        '
        Me.VarietyDataGridViewTextBoxColumn.DataPropertyName = "variety"
        Me.VarietyDataGridViewTextBoxColumn.HeaderText = "Variety"
        Me.VarietyDataGridViewTextBoxColumn.Name = "VarietyDataGridViewTextBoxColumn"
        '
        'FarmerDataGridViewTextBoxColumn
        '
        Me.FarmerDataGridViewTextBoxColumn.DataPropertyName = "farmer"
        Me.FarmerDataGridViewTextBoxColumn.HeaderText = "Farmer"
        Me.FarmerDataGridViewTextBoxColumn.Name = "FarmerDataGridViewTextBoxColumn"
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        '
        'HarvestDataGridViewTextBoxColumn
        '
        Me.HarvestDataGridViewTextBoxColumn.DataPropertyName = "harvest"
        Me.HarvestDataGridViewTextBoxColumn.HeaderText = "Harvest"
        Me.HarvestDataGridViewTextBoxColumn.Name = "HarvestDataGridViewTextBoxColumn"
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "Weight (kg)"
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        '
        'NomnlDataGridViewTextBoxColumn
        '
        Me.NomnlDataGridViewTextBoxColumn.DataPropertyName = "nomnl"
        Me.NomnlDataGridViewTextBoxColumn.HeaderText = "Manual"
        Me.NomnlDataGridViewTextBoxColumn.Name = "NomnlDataGridViewTextBoxColumn"
        '
        'NojobDataGridViewTextBoxColumn
        '
        Me.NojobDataGridViewTextBoxColumn.DataPropertyName = "nojob"
        Me.NojobDataGridViewTextBoxColumn.HeaderText = "Lot/Job"
        Me.NojobDataGridViewTextBoxColumn.Name = "NojobDataGridViewTextBoxColumn"
        '
        'ScopeDataGridViewTextBoxColumn
        '
        Me.ScopeDataGridViewTextBoxColumn.DataPropertyName = "scope"
        Me.ScopeDataGridViewTextBoxColumn.HeaderText = "Scope"
        Me.ScopeDataGridViewTextBoxColumn.Name = "ScopeDataGridViewTextBoxColumn"
        '
        'NamareqDataGridViewTextBoxColumn
        '
        Me.NamareqDataGridViewTextBoxColumn.DataPropertyName = "nama_req"
        Me.NamareqDataGridViewTextBoxColumn.HeaderText = "Request by"
        Me.NamareqDataGridViewTextBoxColumn.Name = "NamareqDataGridViewTextBoxColumn"
        '
        'TglconfirmDataGridViewTextBoxColumn
        '
        Me.TglconfirmDataGridViewTextBoxColumn.DataPropertyName = "tgl_confirm"
        Me.TglconfirmDataGridViewTextBoxColumn.HeaderText = "Appoved Date"
        Me.TglconfirmDataGridViewTextBoxColumn.Name = "TglconfirmDataGridViewTextBoxColumn"
        '
        'NamappcDataGridViewTextBoxColumn
        '
        Me.NamappcDataGridViewTextBoxColumn.DataPropertyName = "nama_ppc"
        Me.NamappcDataGridViewTextBoxColumn.HeaderText = "Return by"
        Me.NamappcDataGridViewTextBoxColumn.Name = "NamappcDataGridViewTextBoxColumn"
        '
        'TglkirimColumn
        '
        Me.TglkirimColumn.DataPropertyName = "tgl_kirim"
        Me.TglkirimColumn.HeaderText = "Retun Date"
        Me.TglkirimColumn.Name = "TglkirimColumn"
        '
        'RafaksiTextColumn
        '
        Me.RafaksiTextColumn.DataPropertyName = "rafaksi"
        Me.RafaksiTextColumn.HeaderText = "Rafaction"
        Me.RafaksiTextColumn.Name = "RafaksiTextColumn"
        Me.RafaksiTextColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'RafaksiColumn
        '
        Me.RafaksiColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RafaksiColumn.HeaderText = "Action"
        Me.RafaksiColumn.Items.AddRange(New Object() {"L", "TL"})
        Me.RafaksiColumn.Name = "RafaksiColumn"
        Me.RafaksiColumn.Width = 70
        '
        'BtnCheck
        '
        Me.BtnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCheck.HeaderText = "Delivery"
        Me.BtnCheck.Name = "BtnCheck"
        Me.BtnCheck.Text = "Send"
        Me.BtnCheck.UseColumnTextForButtonValue = True
        Me.BtnCheck.Width = 70
        '
        'BtnDel
        '
        Me.BtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDel.HeaderText = "Button"
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Text = "Clear"
        Me.BtnDel.UseColumnTextForButtonValue = True
        '
        'QcconfirmviewBindingSource
        '
        Me.QcconfirmviewBindingSource.DataMember = "qc_confirm_view"
        Me.QcconfirmviewBindingSource.DataSource = Me.HCQC_NewDataset
        '
        'HCQC_NewDataset
        '
        Me.HCQC_NewDataset.DataSetName = "HCQC_NewDataset"
        Me.HCQC_NewDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Qc_confirm_viewTableAdapter
        '
        Me.Qc_confirm_viewTableAdapter.ClearBeforeFill = True
        '
        'MetroLink2
        '
        Me.MetroLink2.AutoSize = True
        Me.MetroLink2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLink2.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.MetroLink2.Location = New System.Drawing.Point(3, 3)
        Me.MetroLink2.Name = "MetroLink2"
        Me.MetroLink2.Size = New System.Drawing.Size(57, 23)
        Me.MetroLink2.TabIndex = 57
        Me.MetroLink2.Text = "Refresh"
        Me.MetroLink2.UseCustomBackColor = True
        Me.MetroLink2.UseSelectable = True
        Me.MetroLink2.UseStyleColors = True
        '
        'QC_Return
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroLink2)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Name = "QC_Return"
        Me.Size = New System.Drawing.Size(781, 451)
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QcconfirmviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroStyleExtender1 As Components.MetroStyleExtender
    Friend WithEvents MetroStyleManager1 As Components.MetroStyleManager
    Friend WithEvents MetroGrid1 As MetroGrid
    Friend WithEvents QcconfirmviewBindingSource As BindingSource
    Friend WithEvents HCQC_NewDataset As HCQC_NewDataset
    Friend WithEvents Qc_confirm_viewTableAdapter As HCQC_NewDatasetTableAdapters.qc_confirm_viewTableAdapter
    Friend WithEvents MetroLink2 As MetroLink
    Friend WithEvents Id_requestColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarietyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FarmerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HarvestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomnlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NojobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScopeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamareqDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TglconfirmDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamappcDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TglkirimColumn As DataGridViewTextBoxColumn
    Friend WithEvents RafaksiTextColumn As DataGridViewTextBoxColumn
    Friend WithEvents RafaksiColumn As DataGridViewComboBoxColumn
    Friend WithEvents BtnCheck As DataGridViewButtonColumn
    Friend WithEvents BtnDel As DataGridViewButtonColumn
End Class
