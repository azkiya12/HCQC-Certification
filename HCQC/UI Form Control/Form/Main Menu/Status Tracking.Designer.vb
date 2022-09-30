<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Status_Tracking
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
        Me.Lreqnum = New MetroFramework.Controls.MetroLabel()
        Me.Lvariety = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.Lfarmer = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.Ljob = New MetroFramework.Controls.MetroLabel()
        Me.Lharvest = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.BtnSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.LLocation = New MetroFramework.Controls.MetroLabel()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.LabelLabnum = New MetroFramework.Controls.MetroLabel()
        Me.traf = New MetroFramework.Controls.MetroCheckBox()
        Me.tvia = New MetroFramework.Controls.MetroCheckBox()
        Me.tger = New MetroFramework.Controls.MetroCheckBox()
        Me.tpur = New MetroFramework.Controls.MetroCheckBox()
        Me.tmoi = New MetroFramework.Controls.MetroCheckBox()
        Me.Lraf = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.LlabNum = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Tstatus = New MetroFramework.Controls.MetroLabel()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lreqnum
        '
        Me.Lreqnum.AutoSize = True
        Me.Lreqnum.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Lreqnum.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Lreqnum.ForeColor = System.Drawing.Color.Black
        Me.Lreqnum.Location = New System.Drawing.Point(23, 75)
        Me.Lreqnum.Name = "Lreqnum"
        Me.Lreqnum.Size = New System.Drawing.Size(21, 15)
        Me.Lreqnum.TabIndex = 70
        Me.Lreqnum.Text = "11"
        Me.Lreqnum.UseCustomForeColor = True
        '
        'Lvariety
        '
        Me.Lvariety.AutoSize = True
        Me.Lvariety.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Lvariety.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Lvariety.ForeColor = System.Drawing.Color.Black
        Me.Lvariety.Location = New System.Drawing.Point(145, 75)
        Me.Lvariety.Margin = New System.Windows.Forms.Padding(3, 0, 3, 6)
        Me.Lvariety.Name = "Lvariety"
        Me.Lvariety.Size = New System.Drawing.Size(46, 15)
        Me.Lvariety.TabIndex = 71
        Me.Lvariety.Text = "Variety"
        Me.Lvariety.UseCustomForeColor = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel9.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel9.Location = New System.Drawing.Point(23, 60)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(93, 15)
        Me.MetroLabel9.TabIndex = 72
        Me.MetroLabel9.Text = "Request Number"
        Me.MetroLabel9.UseCustomForeColor = True
        '
        'Lfarmer
        '
        Me.Lfarmer.AutoSize = True
        Me.Lfarmer.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Lfarmer.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Lfarmer.ForeColor = System.Drawing.Color.Black
        Me.Lfarmer.Location = New System.Drawing.Point(257, 75)
        Me.Lfarmer.Name = "Lfarmer"
        Me.Lfarmer.Size = New System.Drawing.Size(47, 15)
        Me.Lfarmer.TabIndex = 73
        Me.Lfarmer.Text = "Farmer"
        Me.Lfarmer.UseCustomForeColor = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel3.Location = New System.Drawing.Point(145, 60)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(40, 15)
        Me.MetroLabel3.TabIndex = 74
        Me.MetroLabel3.Text = "Variety"
        Me.MetroLabel3.UseCustomForeColor = True
        '
        'Ljob
        '
        Me.Ljob.AutoSize = True
        Me.Ljob.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Ljob.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Ljob.ForeColor = System.Drawing.Color.Black
        Me.Ljob.Location = New System.Drawing.Point(23, 115)
        Me.Ljob.Name = "Ljob"
        Me.Ljob.Size = New System.Drawing.Size(49, 15)
        Me.Ljob.TabIndex = 75
        Me.Ljob.Text = "Job/Lot"
        Me.Ljob.UseCustomForeColor = True
        '
        'Lharvest
        '
        Me.Lharvest.AutoSize = True
        Me.Lharvest.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Lharvest.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Lharvest.ForeColor = System.Drawing.Color.Black
        Me.Lharvest.Location = New System.Drawing.Point(257, 115)
        Me.Lharvest.Name = "Lharvest"
        Me.Lharvest.Size = New System.Drawing.Size(51, 15)
        Me.Lharvest.TabIndex = 77
        Me.Lharvest.Text = "Harvest"
        Me.Lharvest.UseCustomForeColor = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel4.Location = New System.Drawing.Point(257, 60)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(42, 15)
        Me.MetroLabel4.TabIndex = 78
        Me.MetroLabel4.Text = "Farmer"
        Me.MetroLabel4.UseCustomForeColor = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel6.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel6.Location = New System.Drawing.Point(23, 100)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(88, 15)
        Me.MetroLabel6.TabIndex = 79
        Me.MetroLabel6.Text = "Manual/Job SAS"
        Me.MetroLabel6.UseCustomForeColor = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel5.Location = New System.Drawing.Point(257, 100)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(46, 15)
        Me.MetroLabel5.TabIndex = 81
        Me.MetroLabel5.Text = "Harvest"
        Me.MetroLabel5.UseCustomForeColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Activecolor = System.Drawing.Color.LightGray
        Me.BtnSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.BackColor = System.Drawing.Color.Transparent
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.BorderRadius = 0
        Me.BtnSave.ButtonText = "Close"
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.DisabledColor = System.Drawing.Color.Gray
        Me.BtnSave.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnSave.Iconimage = Nothing
        Me.BtnSave.Iconimage_right = Nothing
        Me.BtnSave.Iconimage_right_Selected = Nothing
        Me.BtnSave.Iconimage_Selected = Nothing
        Me.BtnSave.IconMarginLeft = 0
        Me.BtnSave.IconMarginRight = 0
        Me.BtnSave.IconRightVisible = True
        Me.BtnSave.IconRightZoom = 0R
        Me.BtnSave.IconVisible = True
        Me.BtnSave.IconZoom = 90.0R
        Me.BtnSave.IsTab = False
        Me.BtnSave.Location = New System.Drawing.Point(23, 403)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Normalcolor = System.Drawing.Color.Transparent
        Me.BtnSave.OnHovercolor = System.Drawing.Color.LightGray
        Me.BtnSave.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnSave.selected = False
        Me.BtnSave.Size = New System.Drawing.Size(512, 34)
        Me.BtnSave.TabIndex = 83
        Me.BtnSave.Text = "Close"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSave.Textcolor = System.Drawing.Color.DimGray
        Me.BtnSave.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Refresh"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(23, 363)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(512, 34)
        Me.BunifuFlatButton1.TabIndex = 84
        Me.BunifuFlatButton1.Text = "Refresh"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.DimGray
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel7.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel7.Location = New System.Drawing.Point(373, 100)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(49, 15)
        Me.MetroLabel7.TabIndex = 80
        Me.MetroLabel7.Text = "Location"
        Me.MetroLabel7.UseCustomForeColor = True
        '
        'LLocation
        '
        Me.LLocation.AutoSize = True
        Me.LLocation.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LLocation.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LLocation.ForeColor = System.Drawing.Color.Black
        Me.LLocation.Location = New System.Drawing.Point(373, 115)
        Me.LLocation.Name = "LLocation"
        Me.LLocation.Size = New System.Drawing.Size(54, 15)
        Me.LLocation.TabIndex = 76
        Me.LLocation.Text = "Location"
        Me.LLocation.UseCustomForeColor = True
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.MetroGrid1.Location = New System.Drawing.Point(23, 198)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.ReadOnly = True
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
        Me.MetroGrid1.Size = New System.Drawing.Size(512, 159)
        Me.MetroGrid1.TabIndex = 82
        '
        'LabelLabnum
        '
        Me.LabelLabnum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelLabnum.AutoSize = True
        Me.LabelLabnum.BackColor = System.Drawing.Color.Transparent
        Me.LabelLabnum.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelLabnum.ForeColor = System.Drawing.Color.DimGray
        Me.LabelLabnum.Location = New System.Drawing.Point(491, 180)
        Me.LabelLabnum.Name = "LabelLabnum"
        Me.LabelLabnum.Size = New System.Drawing.Size(44, 15)
        Me.LabelLabnum.TabIndex = 91
        Me.LabelLabnum.Text = "labnum"
        Me.LabelLabnum.UseCustomForeColor = True
        Me.LabelLabnum.Visible = False
        '
        'traf
        '
        Me.traf.AutoSize = True
        Me.traf.BackColor = System.Drawing.Color.Transparent
        Me.traf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.traf.Location = New System.Drawing.Point(145, 163)
        Me.traf.Name = "traf"
        Me.traf.Size = New System.Drawing.Size(96, 15)
        Me.traf.TabIndex = 95
        Me.traf.TabStop = False
        Me.traf.Text = "Rafaction Test"
        Me.traf.UseCustomBackColor = True
        Me.traf.UseCustomForeColor = True
        Me.traf.UseSelectable = True
        '
        'tvia
        '
        Me.tvia.AutoSize = True
        Me.tvia.BackColor = System.Drawing.Color.Transparent
        Me.tvia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.tvia.Location = New System.Drawing.Point(261, 142)
        Me.tvia.Name = "tvia"
        Me.tvia.Size = New System.Drawing.Size(88, 15)
        Me.tvia.TabIndex = 97
        Me.tvia.TabStop = False
        Me.tvia.Text = "Viability Test"
        Me.tvia.UseCustomBackColor = True
        Me.tvia.UseCustomForeColor = True
        Me.tvia.UseSelectable = True
        '
        'tger
        '
        Me.tger.AutoSize = True
        Me.tger.BackColor = System.Drawing.Color.Transparent
        Me.tger.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.tger.Location = New System.Drawing.Point(261, 163)
        Me.tger.Name = "tger"
        Me.tger.Size = New System.Drawing.Size(112, 15)
        Me.tger.TabIndex = 96
        Me.tger.TabStop = False
        Me.tger.Text = "Germination Test"
        Me.tger.UseCustomBackColor = True
        Me.tger.UseCustomForeColor = True
        Me.tger.UseSelectable = True
        '
        'tpur
        '
        Me.tpur.AutoSize = True
        Me.tpur.BackColor = System.Drawing.Color.Transparent
        Me.tpur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.tpur.Location = New System.Drawing.Point(145, 142)
        Me.tpur.Name = "tpur"
        Me.tpur.Size = New System.Drawing.Size(77, 15)
        Me.tpur.TabIndex = 94
        Me.tpur.TabStop = False
        Me.tpur.Text = "Purity Test"
        Me.tpur.UseCustomBackColor = True
        Me.tpur.UseCustomForeColor = True
        Me.tpur.UseSelectable = True
        '
        'tmoi
        '
        Me.tmoi.AutoSize = True
        Me.tmoi.BackColor = System.Drawing.Color.Transparent
        Me.tmoi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.tmoi.Location = New System.Drawing.Point(23, 142)
        Me.tmoi.Name = "tmoi"
        Me.tmoi.Size = New System.Drawing.Size(93, 15)
        Me.tmoi.TabIndex = 93
        Me.tmoi.TabStop = False
        Me.tmoi.Text = "Moisture Test"
        Me.tmoi.UseCustomBackColor = True
        Me.tmoi.UseCustomForeColor = True
        Me.tmoi.UseSelectable = True
        '
        'Lraf
        '
        Me.Lraf.AutoSize = True
        Me.Lraf.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Lraf.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Lraf.ForeColor = System.Drawing.Color.Black
        Me.Lraf.Location = New System.Drawing.Point(373, 75)
        Me.Lraf.Name = "Lraf"
        Me.Lraf.Size = New System.Drawing.Size(64, 15)
        Me.Lraf.TabIndex = 98
        Me.Lraf.Text = "lulus Tolak"
        Me.Lraf.UseCustomForeColor = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel2.Location = New System.Drawing.Point(373, 60)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(67, 15)
        Me.MetroLabel2.TabIndex = 99
        Me.MetroLabel2.Text = "Hasil Rafaksi"
        Me.MetroLabel2.UseCustomForeColor = True
        '
        'LlabNum
        '
        Me.LlabNum.AutoSize = True
        Me.LlabNum.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LlabNum.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LlabNum.ForeColor = System.Drawing.Color.Black
        Me.LlabNum.Location = New System.Drawing.Point(145, 115)
        Me.LlabNum.Margin = New System.Windows.Forms.Padding(3, 0, 3, 6)
        Me.LlabNum.Name = "LlabNum"
        Me.LlabNum.Size = New System.Drawing.Size(75, 15)
        Me.LlabNum.TabIndex = 100
        Me.LlabNum.Text = "Lab Number"
        Me.LlabNum.UseCustomForeColor = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel8.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel8.Location = New System.Drawing.Point(145, 100)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(70, 15)
        Me.MetroLabel8.TabIndex = 101
        Me.MetroLabel8.Text = "Lab Number"
        Me.MetroLabel8.UseCustomForeColor = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel1.Location = New System.Drawing.Point(466, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(38, 15)
        Me.MetroLabel1.TabIndex = 103
        Me.MetroLabel1.Text = "Status"
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'Tstatus
        '
        Me.Tstatus.AutoSize = True
        Me.Tstatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tstatus.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Tstatus.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Tstatus.ForeColor = System.Drawing.Color.Black
        Me.Tstatus.Location = New System.Drawing.Point(466, 75)
        Me.Tstatus.Name = "Tstatus"
        Me.Tstatus.Size = New System.Drawing.Size(62, 15)
        Me.Tstatus.TabIndex = 102
        Me.Tstatus.Text = "Approved"
        Me.Tstatus.UseCustomForeColor = True
        '
        'Status_Tracking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 460)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.Tstatus)
        Me.Controls.Add(Me.LlabNum)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.Lraf)
        Me.Controls.Add(Me.traf)
        Me.Controls.Add(Me.tvia)
        Me.Controls.Add(Me.tger)
        Me.Controls.Add(Me.tpur)
        Me.Controls.Add(Me.tmoi)
        Me.Controls.Add(Me.LabelLabnum)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Controls.Add(Me.Lreqnum)
        Me.Controls.Add(Me.Lvariety)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.Lfarmer)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.Ljob)
        Me.Controls.Add(Me.LLocation)
        Me.Controls.Add(Me.Lharvest)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Status_Tracking"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Status Tracking"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lreqnum As MetroLabel
    Friend WithEvents Lvariety As MetroLabel
    Friend WithEvents MetroLabel9 As MetroLabel
    Friend WithEvents Lfarmer As MetroLabel
    Friend WithEvents MetroLabel3 As MetroLabel
    Friend WithEvents Ljob As MetroLabel
    Friend WithEvents Lharvest As MetroLabel
    Friend WithEvents MetroLabel4 As MetroLabel
    Friend WithEvents MetroLabel6 As MetroLabel
    Friend WithEvents MetroLabel5 As MetroLabel
    Friend WithEvents BtnSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MetroLabel7 As MetroLabel
    Friend WithEvents LLocation As MetroLabel
    Friend WithEvents MetroGrid1 As MetroGrid
    Friend WithEvents LabelLabnum As MetroLabel
    Friend WithEvents traf As MetroCheckBox
    Friend WithEvents tvia As MetroCheckBox
    Friend WithEvents tger As MetroCheckBox
    Friend WithEvents tpur As MetroCheckBox
    Friend WithEvents tmoi As MetroCheckBox
    Friend WithEvents Lraf As MetroLabel
    Friend WithEvents MetroLabel2 As MetroLabel
    Friend WithEvents LlabNum As MetroLabel
    Friend WithEvents MetroLabel8 As MetroLabel
    Friend WithEvents MetroLabel1 As MetroLabel
    Friend WithEvents Tstatus As MetroLabel
End Class
