<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerControl
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerControl))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnBack = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnAdd = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.Idcust = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.NameGrid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Departemen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_serverDataSet = New WindowsApplication1.HCQC_serverDataSet()
        Me.CustomerTableAdapter = New WindowsApplication1.HCQC_serverDataSetTableAdapters.customerTableAdapter()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBack.BorderRadius = 0
        Me.BtnBack.ButtonText = "Back"
        Me.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBack.DisabledColor = System.Drawing.Color.Gray
        Me.BtnBack.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnBack.Iconimage = CType(resources.GetObject("BtnBack.Iconimage"), System.Drawing.Image)
        Me.BtnBack.Iconimage_right = Nothing
        Me.BtnBack.Iconimage_right_Selected = Nothing
        Me.BtnBack.Iconimage_Selected = Nothing
        Me.BtnBack.IconMarginLeft = 0
        Me.BtnBack.IconMarginRight = 0
        Me.BtnBack.IconRightVisible = True
        Me.BtnBack.IconRightZoom = 0R
        Me.BtnBack.IconVisible = True
        Me.BtnBack.IconZoom = 90.0R
        Me.BtnBack.IsTab = False
        Me.BtnBack.Location = New System.Drawing.Point(23, 262)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnBack.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnBack.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnBack.selected = False
        Me.BtnBack.Size = New System.Drawing.Size(115, 34)
        Me.BtnBack.TabIndex = 54
        Me.BtnBack.Text = "Back"
        Me.BtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBack.Textcolor = System.Drawing.Color.White
        Me.BtnBack.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnAdd
        '
        Me.BtnAdd.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAdd.BorderRadius = 0
        Me.BtnAdd.ButtonText = "Add"
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.DisabledColor = System.Drawing.Color.Gray
        Me.BtnAdd.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnAdd.Iconimage = CType(resources.GetObject("BtnAdd.Iconimage"), System.Drawing.Image)
        Me.BtnAdd.Iconimage_right = Nothing
        Me.BtnAdd.Iconimage_right_Selected = Nothing
        Me.BtnAdd.Iconimage_Selected = Nothing
        Me.BtnAdd.IconMarginLeft = 0
        Me.BtnAdd.IconMarginRight = 0
        Me.BtnAdd.IconRightVisible = True
        Me.BtnAdd.IconRightZoom = 0R
        Me.BtnAdd.IconVisible = True
        Me.BtnAdd.IconZoom = 90.0R
        Me.BtnAdd.IsTab = False
        Me.BtnAdd.Location = New System.Drawing.Point(423, 262)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnAdd.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAdd.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnAdd.selected = False
        Me.BtnAdd.Size = New System.Drawing.Size(115, 34)
        Me.BtnAdd.TabIndex = 54
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Textcolor = System.Drawing.Color.White
        Me.BtnAdd.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Nothing
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Idcust, Me.NameGrid, Me.Departemen, Me.Contact, Me.Email})
        Me.MetroGrid1.DataSource = Me.CustomerBindingSource
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
        Me.MetroGrid1.Location = New System.Drawing.Point(23, 63)
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
        Me.MetroGrid1.Size = New System.Drawing.Size(515, 193)
        Me.MetroGrid1.TabIndex = 55
        '
        'Idcust
        '
        Me.Idcust.DataPropertyName = "idcust"
        Me.Idcust.HeaderText = "ID Customer"
        Me.Idcust.Name = "Idcust"
        Me.Idcust.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Idcust.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'NameGrid
        '
        Me.NameGrid.DataPropertyName = "name"
        Me.NameGrid.HeaderText = "Name"
        Me.NameGrid.Name = "NameGrid"
        '
        'Departemen
        '
        Me.Departemen.DataPropertyName = "departemen"
        Me.Departemen.HeaderText = "Departemen"
        Me.Departemen.Name = "Departemen"
        '
        'Contact
        '
        Me.Contact.DataPropertyName = "contact"
        Me.Contact.HeaderText = "Contact"
        Me.Contact.Name = "Contact"
        '
        'Email
        '
        Me.Email.DataPropertyName = "email"
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.HCQC_serverDataSet
        '
        'HCQC_serverDataSet
        '
        Me.HCQC_serverDataSet.DataSetName = "HCQC_serverDataSet"
        Me.HCQC_serverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(171, 25)
        Me.BunifuImageButton1.Margin = New System.Windows.Forms.Padding(10)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(25, 25)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 56
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'CustomerControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 319)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnBack)
        Me.Name = "CustomerControl"
        Me.Text = "Customer List"
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnBack As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnAdd As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MetroStyleManager1 As Components.MetroStyleManager
    Friend WithEvents MetroGrid1 As MetroGrid
    Friend WithEvents HCQC_serverDataSet As HCQC_serverDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As HCQC_serverDataSetTableAdapters.customerTableAdapter
    Friend WithEvents Idcust As DataGridViewLinkColumn
    Friend WithEvents NameGrid As DataGridViewTextBoxColumn
    Friend WithEvents Departemen As DataGridViewTextBoxColumn
    Friend WithEvents Contact As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
End Class
