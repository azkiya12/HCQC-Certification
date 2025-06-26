<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Multy_Request_Sample
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Multy_Request_Sample))
        Me.MetroGrid2 = New MetroFramework.Controls.MetroGrid()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.TComboScope = New MetroFramework.Controls.MetroComboBox()
        Me.traf = New MetroFramework.Controls.MetroCheckBox()
        Me.tvia = New MetroFramework.Controls.MetroCheckBox()
        Me.tger = New MetroFramework.Controls.MetroCheckBox()
        Me.tpur = New MetroFramework.Controls.MetroCheckBox()
        Me.tmoi = New MetroFramework.Controls.MetroCheckBox()
        Me.tsampling = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.Linkadd = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.LinkClear = New MetroFramework.Controls.MetroLink()
        Me.BtnSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.BtnClearSelected = New MetroFramework.Controls.MetroLink()
        Me.tkarantina = New MetroFramework.Controls.MetroCheckBox()
        Me.LinkImport = New MetroFramework.Controls.MetroLink()
        Me.BtnSetAll = New MetroFramework.Controls.MetroButton()
        Me.BtnSetSelected = New MetroFramework.Controls.MetroButton()
        Me.BtnTestSetSelected = New MetroFramework.Controls.MetroButton()
        Me.CheckColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProductionCodeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dovendorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarietyColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsplotColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FarmerColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HarvestColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManualColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BagColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.smplLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScopeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KetColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MetroGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroGrid2
        '
        Me.MetroGrid2.AllowUserToAddRows = False
        Me.MetroGrid2.AllowUserToResizeRows = False
        Me.MetroGrid2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckColumn1, Me.ProductionCodeColumn, Me.dovendorColumn, Me.VarietyColumn, Me.InsplotColumn, Me.FarmerColumn, Me.LocationColumn, Me.HarvestColumn, Me.ManualColumn, Me.LotColumn, Me.WeightColumn, Me.UnitColumn, Me.BagColumn, Me.smplLocation, Me.ScopeColumn, Me.KetColumn})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid2.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid2.EnableHeadersVisualStyles = False
        Me.MetroGrid2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid2.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid2.Location = New System.Drawing.Point(23, 86)
        Me.MetroGrid2.Name = "MetroGrid2"
        Me.MetroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid2.Size = New System.Drawing.Size(861, 353)
        Me.MetroGrid2.TabIndex = 77
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.Location = New System.Drawing.Point(23, 461)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(241, 15)
        Me.MetroLabel4.TabIndex = 78
        Me.MetroLabel4.Text = "Step 2 : Evaluation Request List that will to Save"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(923, 86)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(121, 19)
        Me.MetroLabel1.TabIndex = 79
        Me.MetroLabel1.Text = "1. Scope of Sample"
        '
        'TComboScope
        '
        Me.TComboScope.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TComboScope.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.TComboScope.FormattingEnabled = True
        Me.TComboScope.ItemHeight = 19
        Me.TComboScope.Items.AddRange(New Object() {"Raw Material", "Gravity", "Periodic", "Finish Good", "Other"})
        Me.TComboScope.Location = New System.Drawing.Point(944, 108)
        Me.TComboScope.Name = "TComboScope"
        Me.TComboScope.Size = New System.Drawing.Size(172, 25)
        Me.TComboScope.TabIndex = 80
        Me.TComboScope.UseSelectable = True
        '
        'traf
        '
        Me.traf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.traf.AutoSize = True
        Me.traf.BackColor = System.Drawing.Color.Transparent
        Me.traf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.traf.Location = New System.Drawing.Point(943, 282)
        Me.traf.Name = "traf"
        Me.traf.Size = New System.Drawing.Size(97, 15)
        Me.traf.TabIndex = 89
        Me.traf.Text = "Rafaction Test"
        Me.traf.UseSelectable = True
        '
        'tvia
        '
        Me.tvia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tvia.AutoSize = True
        Me.tvia.BackColor = System.Drawing.Color.Transparent
        Me.tvia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.tvia.Location = New System.Drawing.Point(943, 324)
        Me.tvia.Name = "tvia"
        Me.tvia.Size = New System.Drawing.Size(89, 15)
        Me.tvia.TabIndex = 91
        Me.tvia.Text = "Viability Test"
        Me.tvia.UseSelectable = True
        '
        'tger
        '
        Me.tger.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tger.AutoSize = True
        Me.tger.BackColor = System.Drawing.Color.Transparent
        Me.tger.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.tger.Location = New System.Drawing.Point(943, 303)
        Me.tger.Name = "tger"
        Me.tger.Size = New System.Drawing.Size(113, 15)
        Me.tger.TabIndex = 90
        Me.tger.Text = "Germination Test"
        Me.tger.UseSelectable = True
        '
        'tpur
        '
        Me.tpur.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tpur.AutoSize = True
        Me.tpur.BackColor = System.Drawing.Color.Transparent
        Me.tpur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.tpur.Location = New System.Drawing.Point(943, 261)
        Me.tpur.Name = "tpur"
        Me.tpur.Size = New System.Drawing.Size(78, 15)
        Me.tpur.TabIndex = 88
        Me.tpur.Text = "Purity Test"
        Me.tpur.UseSelectable = True
        '
        'tmoi
        '
        Me.tmoi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tmoi.AutoSize = True
        Me.tmoi.BackColor = System.Drawing.Color.Transparent
        Me.tmoi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.tmoi.Location = New System.Drawing.Point(943, 240)
        Me.tmoi.Name = "tmoi"
        Me.tmoi.Size = New System.Drawing.Size(94, 15)
        Me.tmoi.TabIndex = 87
        Me.tmoi.Text = "Moisture Test"
        Me.tmoi.UseSelectable = True
        '
        'tsampling
        '
        Me.tsampling.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsampling.AutoSize = True
        Me.tsampling.BackColor = System.Drawing.Color.Transparent
        Me.tsampling.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.tsampling.Location = New System.Drawing.Point(944, 198)
        Me.tsampling.Name = "tsampling"
        Me.tsampling.Size = New System.Drawing.Size(73, 15)
        Me.tsampling.TabIndex = 86
        Me.tsampling.Text = "Sampling"
        Me.tsampling.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(923, 176)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(163, 19)
        Me.MetroLabel2.TabIndex = 92
        Me.MetroLabel2.Text = "2. Test Laboratory Request"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel7.Location = New System.Drawing.Point(911, 442)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(208, 34)
        Me.MetroLabel7.TabIndex = 94
        Me.MetroLabel7.Text = "Step 3 : Select Request option and Click button to Save"
        Me.MetroLabel7.WrapToLine = True
        '
        'Linkadd
        '
        Me.Linkadd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Linkadd.AutoSize = True
        Me.Linkadd.BackColor = System.Drawing.Color.Transparent
        Me.Linkadd.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.Linkadd.Location = New System.Drawing.Point(813, 57)
        Me.Linkadd.Name = "Linkadd"
        Me.Linkadd.Size = New System.Drawing.Size(71, 23)
        Me.Linkadd.TabIndex = 96
        Me.Linkadd.Text = "+ Add Data"
        Me.Linkadd.UseCustomBackColor = True
        Me.Linkadd.UseSelectable = True
        Me.Linkadd.UseStyleColors = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 60)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(120, 23)
        Me.MetroLabel3.TabIndex = 95
        Me.MetroLabel3.Text = "Request List"
        Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkClear
        '
        Me.LinkClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkClear.AutoSize = True
        Me.LinkClear.BackColor = System.Drawing.Color.Transparent
        Me.LinkClear.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkClear.Location = New System.Drawing.Point(658, 57)
        Me.LinkClear.Name = "LinkClear"
        Me.LinkClear.Size = New System.Drawing.Size(57, 23)
        Me.LinkClear.TabIndex = 96
        Me.LinkClear.Text = "Clear All"
        Me.LinkClear.UseCustomBackColor = True
        Me.LinkClear.UseSelectable = True
        Me.LinkClear.UseStyleColors = True
        '
        'BtnSave
        '
        Me.BtnSave.Active = True
        Me.BtnSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.BorderRadius = 0
        Me.BtnSave.ButtonText = "Save"
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.DisabledColor = System.Drawing.Color.Gray
        Me.BtnSave.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnSave.Iconimage = CType(resources.GetObject("BtnSave.Iconimage"), System.Drawing.Image)
        Me.BtnSave.Iconimage_right = Nothing
        Me.BtnSave.Iconimage_right_Selected = Nothing
        Me.BtnSave.Iconimage_Selected = Nothing
        Me.BtnSave.IconMarginLeft = 0
        Me.BtnSave.IconMarginRight = 0
        Me.BtnSave.IconRightVisible = True
        Me.BtnSave.IconRightZoom = 0R
        Me.BtnSave.IconVisible = True
        Me.BtnSave.IconZoom = 50.0R
        Me.BtnSave.IsTab = False
        Me.BtnSave.Location = New System.Drawing.Point(923, 409)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSave.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnSave.selected = True
        Me.BtnSave.Size = New System.Drawing.Size(193, 30)
        Me.BtnSave.TabIndex = 93
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Textcolor = System.Drawing.Color.White
        Me.BtnSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 442)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(214, 15)
        Me.MetroLabel5.TabIndex = 97
        Me.MetroLabel5.Text = "Step 1 : Get data from button +Add Data"
        '
        'BtnClearSelected
        '
        Me.BtnClearSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClearSelected.AutoSize = True
        Me.BtnClearSelected.BackColor = System.Drawing.Color.Transparent
        Me.BtnClearSelected.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.BtnClearSelected.Location = New System.Drawing.Point(721, 57)
        Me.BtnClearSelected.Name = "BtnClearSelected"
        Me.BtnClearSelected.Size = New System.Drawing.Size(86, 23)
        Me.BtnClearSelected.TabIndex = 96
        Me.BtnClearSelected.Text = "Clear Selected"
        Me.BtnClearSelected.UseCustomBackColor = True
        Me.BtnClearSelected.UseSelectable = True
        Me.BtnClearSelected.UseStyleColors = True
        '
        'tkarantina
        '
        Me.tkarantina.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tkarantina.AutoSize = True
        Me.tkarantina.BackColor = System.Drawing.Color.Transparent
        Me.tkarantina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.tkarantina.Location = New System.Drawing.Point(944, 219)
        Me.tkarantina.Name = "tkarantina"
        Me.tkarantina.Size = New System.Drawing.Size(110, 15)
        Me.tkarantina.TabIndex = 100
        Me.tkarantina.Text = "Kesehatan Benih"
        Me.tkarantina.UseSelectable = True
        '
        'LinkImport
        '
        Me.LinkImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkImport.AutoSize = True
        Me.LinkImport.BackColor = System.Drawing.Color.Transparent
        Me.LinkImport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkImport.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.LinkImport.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.LinkImport.Location = New System.Drawing.Point(543, 57)
        Me.LinkImport.Name = "LinkImport"
        Me.LinkImport.Size = New System.Drawing.Size(99, 23)
        Me.LinkImport.TabIndex = 107
        Me.LinkImport.TabStop = False
        Me.LinkImport.Text = "Import Data"
        Me.LinkImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LinkImport.UseCustomBackColor = True
        Me.LinkImport.UseSelectable = True
        Me.LinkImport.UseStyleColors = True
        '
        'BtnSetAll
        '
        Me.BtnSetAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSetAll.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.BtnSetAll.Location = New System.Drawing.Point(945, 139)
        Me.BtnSetAll.Name = "BtnSetAll"
        Me.BtnSetAll.Size = New System.Drawing.Size(76, 22)
        Me.BtnSetAll.TabIndex = 108
        Me.BtnSetAll.Text = "Set All"
        Me.BtnSetAll.UseSelectable = True
        '
        'BtnSetSelected
        '
        Me.BtnSetSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSetSelected.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.BtnSetSelected.Location = New System.Drawing.Point(1040, 139)
        Me.BtnSetSelected.Name = "BtnSetSelected"
        Me.BtnSetSelected.Size = New System.Drawing.Size(76, 22)
        Me.BtnSetSelected.TabIndex = 109
        Me.BtnSetSelected.Text = "Set Selected"
        Me.BtnSetSelected.UseSelectable = True
        '
        'BtnTestSetSelected
        '
        Me.BtnTestSetSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnTestSetSelected.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.BtnTestSetSelected.Location = New System.Drawing.Point(1040, 345)
        Me.BtnTestSetSelected.Name = "BtnTestSetSelected"
        Me.BtnTestSetSelected.Size = New System.Drawing.Size(76, 22)
        Me.BtnTestSetSelected.TabIndex = 111
        Me.BtnTestSetSelected.Text = "Set Selected"
        Me.BtnTestSetSelected.UseSelectable = True
        '
        'CheckColumn1
        '
        Me.CheckColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckColumn1.HeaderText = ""
        Me.CheckColumn1.Name = "CheckColumn1"
        Me.CheckColumn1.Width = 40
        '
        'ProductionCodeColumn
        '
        Me.ProductionCodeColumn.HeaderText = "Production Code"
        Me.ProductionCodeColumn.Name = "ProductionCodeColumn"
        '
        'dovendorColumn
        '
        Me.dovendorColumn.HeaderText = "DO Vendor"
        Me.dovendorColumn.Name = "dovendorColumn"
        Me.dovendorColumn.Width = 90
        '
        'VarietyColumn
        '
        Me.VarietyColumn.HeaderText = "Variety"
        Me.VarietyColumn.Name = "VarietyColumn"
        Me.VarietyColumn.Width = 80
        '
        'InsplotColumn
        '
        Me.InsplotColumn.HeaderText = "Insp. Lot"
        Me.InsplotColumn.Name = "InsplotColumn"
        '
        'FarmerColumn
        '
        Me.FarmerColumn.HeaderText = "Farmer"
        Me.FarmerColumn.Name = "FarmerColumn"
        Me.FarmerColumn.Width = 80
        '
        'LocationColumn
        '
        Me.LocationColumn.HeaderText = "Location"
        Me.LocationColumn.Name = "LocationColumn"
        '
        'HarvestColumn
        '
        Me.HarvestColumn.HeaderText = "Harvest"
        Me.HarvestColumn.Name = "HarvestColumn"
        '
        'ManualColumn
        '
        Me.ManualColumn.HeaderText = "Manual"
        Me.ManualColumn.Name = "ManualColumn"
        Me.ManualColumn.Width = 70
        '
        'LotColumn
        '
        Me.LotColumn.HeaderText = "Lot/Job"
        Me.LotColumn.Name = "LotColumn"
        Me.LotColumn.Width = 80
        '
        'WeightColumn
        '
        Me.WeightColumn.HeaderText = "Weight"
        Me.WeightColumn.Name = "WeightColumn"
        '
        'UnitColumn
        '
        Me.UnitColumn.HeaderText = "Unit"
        Me.UnitColumn.Name = "UnitColumn"
        Me.UnitColumn.Width = 65
        '
        'BagColumn
        '
        Me.BagColumn.HeaderText = "Bags"
        Me.BagColumn.Name = "BagColumn"
        Me.BagColumn.Width = 65
        '
        'smplLocation
        '
        Me.smplLocation.HeaderText = "Sample Location"
        Me.smplLocation.Name = "smplLocation"
        Me.smplLocation.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.smplLocation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ScopeColumn
        '
        Me.ScopeColumn.HeaderText = "Scope"
        Me.ScopeColumn.Name = "ScopeColumn"
        '
        'KetColumn
        '
        Me.KetColumn.HeaderText = "Keterangan"
        Me.KetColumn.Name = "KetColumn"
        '
        'Multy_Request_Sample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 496)
        Me.Controls.Add(Me.BtnTestSetSelected)
        Me.Controls.Add(Me.BtnSetSelected)
        Me.Controls.Add(Me.BtnSetAll)
        Me.Controls.Add(Me.LinkImport)
        Me.Controls.Add(Me.tkarantina)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.BtnClearSelected)
        Me.Controls.Add(Me.LinkClear)
        Me.Controls.Add(Me.Linkadd)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.traf)
        Me.Controls.Add(Me.tvia)
        Me.Controls.Add(Me.tger)
        Me.Controls.Add(Me.tpur)
        Me.Controls.Add(Me.tmoi)
        Me.Controls.Add(Me.tsampling)
        Me.Controls.Add(Me.TComboScope)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroGrid2)
        Me.Name = "Multy_Request_Sample"
        Me.Text = "Multipel Request Sample"
        CType(Me.MetroGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroGrid2 As MetroGrid
    Friend WithEvents MetroLabel4 As MetroLabel
    Friend WithEvents MetroLabel1 As MetroLabel
    Friend WithEvents TComboScope As MetroComboBox
    Friend WithEvents traf As MetroCheckBox
    Friend WithEvents tvia As MetroCheckBox
    Friend WithEvents tger As MetroCheckBox
    Friend WithEvents tpur As MetroCheckBox
    Friend WithEvents tmoi As MetroCheckBox
    Friend WithEvents tsampling As MetroCheckBox
    Friend WithEvents MetroLabel2 As MetroLabel
    Friend WithEvents BtnSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MetroLabel7 As MetroLabel
    Friend WithEvents Linkadd As MetroLink
    Friend WithEvents MetroLabel3 As MetroLabel
    Friend WithEvents LinkClear As MetroLink
    Friend WithEvents MetroLabel5 As MetroLabel
    Friend WithEvents BtnClearSelected As MetroLink
    Friend WithEvents tkarantina As MetroCheckBox
    Friend WithEvents LinkImport As MetroLink
    Friend WithEvents BtnSetAll As MetroButton
    Friend WithEvents BtnSetSelected As MetroButton
    Friend WithEvents BtnTestSetSelected As MetroButton
    Friend WithEvents CheckColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents ProductionCodeColumn As DataGridViewTextBoxColumn
    Friend WithEvents dovendorColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarietyColumn As DataGridViewTextBoxColumn
    Friend WithEvents InsplotColumn As DataGridViewTextBoxColumn
    Friend WithEvents FarmerColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationColumn As DataGridViewTextBoxColumn
    Friend WithEvents HarvestColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManualColumn As DataGridViewTextBoxColumn
    Friend WithEvents LotColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitColumn As DataGridViewTextBoxColumn
    Friend WithEvents BagColumn As DataGridViewTextBoxColumn
    Friend WithEvents smplLocation As DataGridViewTextBoxColumn
    Friend WithEvents ScopeColumn As DataGridViewTextBoxColumn
    Friend WithEvents KetColumn As DataGridViewTextBoxColumn
End Class
