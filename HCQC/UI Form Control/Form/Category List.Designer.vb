<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Category_List
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CachedPeriodik_Certificate1 = New WindowsApplication1.CachedPeriodik_Certificate()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.CategorycropBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_NewDataset = New WindowsApplication1.HCQC_NewDataset()
        Me.MetroLink3 = New MetroFramework.Controls.MetroLink()
        Me.Category_cropTableAdapter = New WindowsApplication1.HCQC_NewDatasetTableAdapters.category_cropTableAdapter()
        Me.IdColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.CropColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdcodeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComnameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.typeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DelColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategorycropBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.MetroGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroGrid1.AutoGenerateColumns = False
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdColumn, Me.CropColumn, Me.ProdcodeColumn, Me.ComnameColumn, Me.typeColumn, Me.DelColumn})
        Me.MetroGrid1.DataSource = Me.CategorycropBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(23, 63)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.MetroGrid1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(516, 273)
        Me.MetroGrid1.TabIndex = 0
        '
        'CategorycropBindingSource
        '
        Me.CategorycropBindingSource.DataMember = "category_crop"
        Me.CategorycropBindingSource.DataSource = Me.HCQC_NewDataset
        '
        'HCQC_NewDataset
        '
        Me.HCQC_NewDataset.DataSetName = "HCQC_NewDataset"
        Me.HCQC_NewDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MetroLink3
        '
        Me.MetroLink3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLink3.AutoSize = True
        Me.MetroLink3.BackColor = System.Drawing.Color.Transparent
        Me.MetroLink3.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.MetroLink3.ImageSize = 50
        Me.MetroLink3.Location = New System.Drawing.Point(445, 37)
        Me.MetroLink3.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLink3.Name = "MetroLink3"
        Me.MetroLink3.Size = New System.Drawing.Size(94, 23)
        Me.MetroLink3.TabIndex = 88
        Me.MetroLink3.Text = "+ Add Category"
        Me.MetroLink3.UseCustomBackColor = True
        Me.MetroLink3.UseSelectable = True
        Me.MetroLink3.UseStyleColors = True
        '
        'Category_cropTableAdapter
        '
        Me.Category_cropTableAdapter.ClearBeforeFill = True
        '
        'IdColumn
        '
        Me.IdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.IdColumn.DataPropertyName = "id"
        Me.IdColumn.HeaderText = "ID"
        Me.IdColumn.MinimumWidth = 40
        Me.IdColumn.Name = "IdColumn"
        Me.IdColumn.ReadOnly = True
        Me.IdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdColumn.Width = 40
        '
        'CropColumn
        '
        Me.CropColumn.DataPropertyName = "crop"
        Me.CropColumn.HeaderText = "Crop Name"
        Me.CropColumn.Name = "CropColumn"
        '
        'ProdcodeColumn
        '
        Me.ProdcodeColumn.DataPropertyName = "prodcode"
        Me.ProdcodeColumn.HeaderText = "Product Code"
        Me.ProdcodeColumn.Name = "ProdcodeColumn"
        '
        'ComnameColumn
        '
        Me.ComnameColumn.DataPropertyName = "comname"
        Me.ComnameColumn.HeaderText = "Commercial Name"
        Me.ComnameColumn.Name = "ComnameColumn"
        '
        'typeColumn
        '
        Me.typeColumn.DataPropertyName = "type"
        Me.typeColumn.HeaderText = "Type"
        Me.typeColumn.Name = "typeColumn"
        Me.typeColumn.Width = 70
        '
        'DelColumn
        '
        Me.DelColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DelColumn.HeaderText = "Action"
        Me.DelColumn.Name = "DelColumn"
        Me.DelColumn.Text = "Delete"
        Me.DelColumn.UseColumnTextForButtonValue = True
        Me.DelColumn.Width = 60
        '
        'Category_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 359)
        Me.Controls.Add(Me.MetroLink3)
        Me.Controls.Add(Me.MetroGrid1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Category_List"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Category Crop List"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategorycropBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CachedPeriodik_Certificate1 As CachedPeriodik_Certificate
    Friend WithEvents MetroGrid1 As MetroGrid
    Friend WithEvents MetroLink3 As MetroLink
    Friend WithEvents HCQC_NewDataset As HCQC_NewDataset
    Friend WithEvents CategorycropBindingSource As BindingSource
    Friend WithEvents Category_cropTableAdapter As HCQC_NewDatasetTableAdapters.category_cropTableAdapter
    Friend WithEvents IdColumn As DataGridViewLinkColumn
    Friend WithEvents CropColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdcodeColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComnameColumn As DataGridViewTextBoxColumn
    Friend WithEvents typeColumn As DataGridViewTextBoxColumn
    Friend WithEvents DelColumn As DataGridViewButtonColumn
End Class
