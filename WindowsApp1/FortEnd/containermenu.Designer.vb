<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class containermenu
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(containermenu))
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BtnSampling = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PnSampling = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnInternal = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PnInternal = New System.Windows.Forms.Panel()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.BtnStandard = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PnStandar = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BtnQuality = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PnMonitor = New System.Windows.Forms.Panel()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Panel1 = New MetroFramework.Controls.MetroPanel()
        Me.PnSampling.SuspendLayout()
        Me.PnInternal.SuspendLayout()
        Me.PnStandar.SuspendLayout()
        Me.PnMonitor.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.BunifuTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.BunifuTransition1.DefaultAnimation = Animation1
        '
        'BtnSampling
        '
        Me.BtnSampling.Activecolor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BtnSampling.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnSampling.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSampling.BorderRadius = 0
        Me.BtnSampling.ButtonText = "Seeds Sampling"
        Me.BtnSampling.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BtnSampling, BunifuAnimatorNS.DecorationType.None)
        Me.BtnSampling.DisabledColor = System.Drawing.Color.Gray
        Me.BtnSampling.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSampling.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSampling.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnSampling.Iconimage = CType(resources.GetObject("BtnSampling.Iconimage"), System.Drawing.Image)
        Me.BtnSampling.Iconimage_right = Nothing
        Me.BtnSampling.Iconimage_right_Selected = Nothing
        Me.BtnSampling.Iconimage_Selected = Nothing
        Me.BtnSampling.IconMarginLeft = 0
        Me.BtnSampling.IconMarginRight = 0
        Me.BtnSampling.IconRightVisible = False
        Me.BtnSampling.IconRightZoom = 0R
        Me.BtnSampling.IconVisible = True
        Me.BtnSampling.IconZoom = 50.0R
        Me.BtnSampling.IsTab = False
        Me.BtnSampling.Location = New System.Drawing.Point(0, 0)
        Me.BtnSampling.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnSampling.Name = "BtnSampling"
        Me.BtnSampling.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnSampling.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BtnSampling.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnSampling.selected = False
        Me.BtnSampling.Size = New System.Drawing.Size(215, 40)
        Me.BtnSampling.TabIndex = 2
        Me.BtnSampling.Text = "Seeds Sampling"
        Me.BtnSampling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSampling.Textcolor = System.Drawing.Color.White
        Me.BtnSampling.TextFont = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PnSampling
        '
        Me.PnSampling.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.PnSampling.Controls.Add(Me.Button4)
        Me.PnSampling.Controls.Add(Me.Button3)
        Me.PnSampling.Controls.Add(Me.Button2)
        Me.PnSampling.Controls.Add(Me.Button1)
        Me.BunifuTransition1.SetDecoration(Me.PnSampling, BunifuAnimatorNS.DecorationType.None)
        Me.PnSampling.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnSampling.Location = New System.Drawing.Point(0, 40)
        Me.PnSampling.Margin = New System.Windows.Forms.Padding(0)
        Me.PnSampling.Name = "PnSampling"
        Me.PnSampling.Size = New System.Drawing.Size(215, 130)
        Me.PnSampling.TabIndex = 5
        Me.PnSampling.Visible = False
        '
        'Button4
        '
        Me.BunifuTransition1.SetDecoration(Me.Button4, BunifuAnimatorNS.DecorationType.None)
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Transparent
        Me.Button4.Location = New System.Drawing.Point(0, 87)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(215, 29)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Sample Archive"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.BunifuTransition1.SetDecoration(Me.Button3, BunifuAnimatorNS.DecorationType.None)
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(0, 58)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(215, 29)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Sample Control"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.BunifuTransition1.SetDecoration(Me.Button2, BunifuAnimatorNS.DecorationType.None)
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(0, 29)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(215, 29)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Sample Receipt"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.BunifuTransition1.SetDecoration(Me.Button1, BunifuAnimatorNS.DecorationType.None)
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(215, 29)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Customer Information"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnInternal
        '
        Me.BtnInternal.Activecolor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BtnInternal.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnInternal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnInternal.BorderRadius = 0
        Me.BtnInternal.ButtonText = "Internal Quality"
        Me.BtnInternal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BtnInternal, BunifuAnimatorNS.DecorationType.None)
        Me.BtnInternal.DisabledColor = System.Drawing.Color.Gray
        Me.BtnInternal.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnInternal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInternal.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnInternal.Iconimage = CType(resources.GetObject("BtnInternal.Iconimage"), System.Drawing.Image)
        Me.BtnInternal.Iconimage_right = Nothing
        Me.BtnInternal.Iconimage_right_Selected = Nothing
        Me.BtnInternal.Iconimage_Selected = Nothing
        Me.BtnInternal.IconMarginLeft = 0
        Me.BtnInternal.IconMarginRight = 0
        Me.BtnInternal.IconRightVisible = True
        Me.BtnInternal.IconRightZoom = 0R
        Me.BtnInternal.IconVisible = True
        Me.BtnInternal.IconZoom = 50.0R
        Me.BtnInternal.IsTab = False
        Me.BtnInternal.Location = New System.Drawing.Point(0, 170)
        Me.BtnInternal.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnInternal.Name = "BtnInternal"
        Me.BtnInternal.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnInternal.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BtnInternal.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnInternal.selected = False
        Me.BtnInternal.Size = New System.Drawing.Size(215, 40)
        Me.BtnInternal.TabIndex = 8
        Me.BtnInternal.Text = "Internal Quality"
        Me.BtnInternal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInternal.Textcolor = System.Drawing.Color.White
        Me.BtnInternal.TextFont = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PnInternal
        '
        Me.PnInternal.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.PnInternal.Controls.Add(Me.Button14)
        Me.PnInternal.Controls.Add(Me.Button13)
        Me.PnInternal.Controls.Add(Me.Button12)
        Me.PnInternal.Controls.Add(Me.Button11)
        Me.PnInternal.Controls.Add(Me.Button10)
        Me.BunifuTransition1.SetDecoration(Me.PnInternal, BunifuAnimatorNS.DecorationType.None)
        Me.PnInternal.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnInternal.Location = New System.Drawing.Point(0, 210)
        Me.PnInternal.Margin = New System.Windows.Forms.Padding(0)
        Me.PnInternal.Name = "PnInternal"
        Me.PnInternal.Size = New System.Drawing.Size(215, 153)
        Me.PnInternal.TabIndex = 9
        Me.PnInternal.Visible = False
        '
        'Button14
        '
        Me.BunifuTransition1.SetDecoration(Me.Button14, BunifuAnimatorNS.DecorationType.None)
        Me.Button14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.ForeColor = System.Drawing.Color.Transparent
        Me.Button14.Location = New System.Drawing.Point(0, 116)
        Me.Button14.Margin = New System.Windows.Forms.Padding(0)
        Me.Button14.Name = "Button14"
        Me.Button14.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button14.Size = New System.Drawing.Size(215, 29)
        Me.Button14.TabIndex = 17
        Me.Button14.Text = "Print Out"
        Me.Button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.BunifuTransition1.SetDecoration(Me.Button13, BunifuAnimatorNS.DecorationType.None)
        Me.Button13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.ForeColor = System.Drawing.Color.Transparent
        Me.Button13.Location = New System.Drawing.Point(0, 87)
        Me.Button13.Margin = New System.Windows.Forms.Padding(0)
        Me.Button13.Name = "Button13"
        Me.Button13.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button13.Size = New System.Drawing.Size(215, 29)
        Me.Button13.TabIndex = 16
        Me.Button13.Text = "Detail List"
        Me.Button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.BunifuTransition1.SetDecoration(Me.Button12, BunifuAnimatorNS.DecorationType.None)
        Me.Button12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.ForeColor = System.Drawing.Color.Transparent
        Me.Button12.Location = New System.Drawing.Point(0, 58)
        Me.Button12.Margin = New System.Windows.Forms.Padding(0)
        Me.Button12.Name = "Button12"
        Me.Button12.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button12.Size = New System.Drawing.Size(215, 29)
        Me.Button12.TabIndex = 15
        Me.Button12.Text = "Inspection RM"
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.BunifuTransition1.SetDecoration(Me.Button11, BunifuAnimatorNS.DecorationType.None)
        Me.Button11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.ForeColor = System.Drawing.Color.Transparent
        Me.Button11.Location = New System.Drawing.Point(0, 29)
        Me.Button11.Margin = New System.Windows.Forms.Padding(0)
        Me.Button11.Name = "Button11"
        Me.Button11.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button11.Size = New System.Drawing.Size(215, 29)
        Me.Button11.TabIndex = 14
        Me.Button11.Text = "Viability Test"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.BunifuTransition1.SetDecoration(Me.Button10, BunifuAnimatorNS.DecorationType.None)
        Me.Button10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.ForeColor = System.Drawing.Color.Transparent
        Me.Button10.Location = New System.Drawing.Point(0, 0)
        Me.Button10.Margin = New System.Windows.Forms.Padding(0)
        Me.Button10.Name = "Button10"
        Me.Button10.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button10.Size = New System.Drawing.Size(215, 29)
        Me.Button10.TabIndex = 13
        Me.Button10.Text = "Internal Refraction"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.UseVisualStyleBackColor = True
        '
        'BtnStandard
        '
        Me.BtnStandard.Activecolor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BtnStandard.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnStandard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnStandard.BorderRadius = 0
        Me.BtnStandard.ButtonText = "Certification Standard"
        Me.BtnStandard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BtnStandard, BunifuAnimatorNS.DecorationType.None)
        Me.BtnStandard.DisabledColor = System.Drawing.Color.Gray
        Me.BtnStandard.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnStandard.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStandard.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnStandard.Iconimage = CType(resources.GetObject("BtnStandard.Iconimage"), System.Drawing.Image)
        Me.BtnStandard.Iconimage_right = Nothing
        Me.BtnStandard.Iconimage_right_Selected = Nothing
        Me.BtnStandard.Iconimage_Selected = Nothing
        Me.BtnStandard.IconMarginLeft = 0
        Me.BtnStandard.IconMarginRight = 0
        Me.BtnStandard.IconRightVisible = False
        Me.BtnStandard.IconRightZoom = 0R
        Me.BtnStandard.IconVisible = True
        Me.BtnStandard.IconZoom = 50.0R
        Me.BtnStandard.IsTab = False
        Me.BtnStandard.Location = New System.Drawing.Point(0, 363)
        Me.BtnStandard.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnStandard.Name = "BtnStandard"
        Me.BtnStandard.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnStandard.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BtnStandard.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnStandard.selected = False
        Me.BtnStandard.Size = New System.Drawing.Size(215, 40)
        Me.BtnStandard.TabIndex = 10
        Me.BtnStandard.Text = "Certification Standard"
        Me.BtnStandard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnStandard.Textcolor = System.Drawing.Color.White
        Me.BtnStandard.TextFont = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PnStandar
        '
        Me.PnStandar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.PnStandar.Controls.Add(Me.Button9)
        Me.PnStandar.Controls.Add(Me.Button8)
        Me.PnStandar.Controls.Add(Me.Button7)
        Me.PnStandar.Controls.Add(Me.Button6)
        Me.PnStandar.Controls.Add(Me.Button5)
        Me.BunifuTransition1.SetDecoration(Me.PnStandar, BunifuAnimatorNS.DecorationType.None)
        Me.PnStandar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnStandar.Location = New System.Drawing.Point(0, 403)
        Me.PnStandar.Margin = New System.Windows.Forms.Padding(0)
        Me.PnStandar.Name = "PnStandar"
        Me.PnStandar.Size = New System.Drawing.Size(215, 160)
        Me.PnStandar.TabIndex = 11
        Me.PnStandar.Visible = False
        '
        'Button9
        '
        Me.BunifuTransition1.SetDecoration(Me.Button9, BunifuAnimatorNS.DecorationType.None)
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.ForeColor = System.Drawing.Color.Transparent
        Me.Button9.Location = New System.Drawing.Point(0, 116)
        Me.Button9.Margin = New System.Windows.Forms.Padding(0)
        Me.Button9.Name = "Button9"
        Me.Button9.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button9.Size = New System.Drawing.Size(215, 29)
        Me.Button9.TabIndex = 12
        Me.Button9.Text = "Print Out"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.BunifuTransition1.SetDecoration(Me.Button8, BunifuAnimatorNS.DecorationType.None)
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.Color.Transparent
        Me.Button8.Location = New System.Drawing.Point(0, 87)
        Me.Button8.Margin = New System.Windows.Forms.Padding(0)
        Me.Button8.Name = "Button8"
        Me.Button8.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button8.Size = New System.Drawing.Size(215, 29)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = "Detail List"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.BunifuTransition1.SetDecoration(Me.Button7, BunifuAnimatorNS.DecorationType.None)
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Transparent
        Me.Button7.Location = New System.Drawing.Point(0, 58)
        Me.Button7.Margin = New System.Windows.Forms.Padding(0)
        Me.Button7.Name = "Button7"
        Me.Button7.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button7.Size = New System.Drawing.Size(215, 29)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "Gemination Test"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.BunifuTransition1.SetDecoration(Me.Button6, BunifuAnimatorNS.DecorationType.None)
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.Transparent
        Me.Button6.Location = New System.Drawing.Point(0, 29)
        Me.Button6.Margin = New System.Windows.Forms.Padding(0)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button6.Size = New System.Drawing.Size(215, 29)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Purity ISTA Test"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.BunifuTransition1.SetDecoration(Me.Button5, BunifuAnimatorNS.DecorationType.None)
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Transparent
        Me.Button5.Location = New System.Drawing.Point(0, 0)
        Me.Button5.Margin = New System.Windows.Forms.Padding(0)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button5.Size = New System.Drawing.Size(215, 29)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Moisture Test"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = True
        '
        'BtnQuality
        '
        Me.BtnQuality.Activecolor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BtnQuality.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnQuality.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnQuality.BorderRadius = 0
        Me.BtnQuality.ButtonText = "Monitoring"
        Me.BtnQuality.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BtnQuality, BunifuAnimatorNS.DecorationType.None)
        Me.BtnQuality.DisabledColor = System.Drawing.Color.Gray
        Me.BtnQuality.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnQuality.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuality.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnQuality.Iconimage = CType(resources.GetObject("BtnQuality.Iconimage"), System.Drawing.Image)
        Me.BtnQuality.Iconimage_right = Nothing
        Me.BtnQuality.Iconimage_right_Selected = Nothing
        Me.BtnQuality.Iconimage_Selected = Nothing
        Me.BtnQuality.IconMarginLeft = 0
        Me.BtnQuality.IconMarginRight = 0
        Me.BtnQuality.IconRightVisible = True
        Me.BtnQuality.IconRightZoom = 0R
        Me.BtnQuality.IconVisible = True
        Me.BtnQuality.IconZoom = 50.0R
        Me.BtnQuality.IsTab = False
        Me.BtnQuality.Location = New System.Drawing.Point(0, 563)
        Me.BtnQuality.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnQuality.Name = "BtnQuality"
        Me.BtnQuality.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnQuality.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BtnQuality.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnQuality.selected = False
        Me.BtnQuality.Size = New System.Drawing.Size(215, 40)
        Me.BtnQuality.TabIndex = 12
        Me.BtnQuality.Text = "Monitoring"
        Me.BtnQuality.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnQuality.Textcolor = System.Drawing.Color.White
        Me.BtnQuality.TextFont = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PnMonitor
        '
        Me.PnMonitor.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.PnMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PnMonitor.Controls.Add(Me.Button20)
        Me.PnMonitor.Controls.Add(Me.Button15)
        Me.PnMonitor.Controls.Add(Me.Button16)
        Me.PnMonitor.Controls.Add(Me.Button17)
        Me.PnMonitor.Controls.Add(Me.Button18)
        Me.PnMonitor.Controls.Add(Me.Button19)
        Me.BunifuTransition1.SetDecoration(Me.PnMonitor, BunifuAnimatorNS.DecorationType.None)
        Me.PnMonitor.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnMonitor.Location = New System.Drawing.Point(0, 603)
        Me.PnMonitor.Margin = New System.Windows.Forms.Padding(0)
        Me.PnMonitor.Name = "PnMonitor"
        Me.PnMonitor.Size = New System.Drawing.Size(215, 202)
        Me.PnMonitor.TabIndex = 13
        Me.PnMonitor.Visible = False
        '
        'Button20
        '
        Me.BunifuTransition1.SetDecoration(Me.Button20, BunifuAnimatorNS.DecorationType.None)
        Me.Button20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button20.FlatAppearance.BorderSize = 0
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button20.ForeColor = System.Drawing.Color.Transparent
        Me.Button20.Location = New System.Drawing.Point(0, 145)
        Me.Button20.Margin = New System.Windows.Forms.Padding(0)
        Me.Button20.Name = "Button20"
        Me.Button20.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button20.Size = New System.Drawing.Size(215, 29)
        Me.Button20.TabIndex = 13
        Me.Button20.Text = "Report SAS"
        Me.Button20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.BunifuTransition1.SetDecoration(Me.Button15, BunifuAnimatorNS.DecorationType.None)
        Me.Button15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.ForeColor = System.Drawing.Color.Transparent
        Me.Button15.Location = New System.Drawing.Point(0, 116)
        Me.Button15.Margin = New System.Windows.Forms.Padding(0)
        Me.Button15.Name = "Button15"
        Me.Button15.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button15.Size = New System.Drawing.Size(215, 29)
        Me.Button15.TabIndex = 12
        Me.Button15.Text = "Data List Inspection"
        Me.Button15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.BunifuTransition1.SetDecoration(Me.Button16, BunifuAnimatorNS.DecorationType.None)
        Me.Button16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button16.FlatAppearance.BorderSize = 0
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.ForeColor = System.Drawing.Color.Transparent
        Me.Button16.Location = New System.Drawing.Point(0, 87)
        Me.Button16.Margin = New System.Windows.Forms.Padding(0)
        Me.Button16.Name = "Button16"
        Me.Button16.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button16.Size = New System.Drawing.Size(215, 29)
        Me.Button16.TabIndex = 11
        Me.Button16.Text = "Lead Time"
        Me.Button16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.BunifuTransition1.SetDecoration(Me.Button17, BunifuAnimatorNS.DecorationType.None)
        Me.Button17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button17.FlatAppearance.BorderSize = 0
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.ForeColor = System.Drawing.Color.Transparent
        Me.Button17.Location = New System.Drawing.Point(0, 58)
        Me.Button17.Margin = New System.Windows.Forms.Padding(0)
        Me.Button17.Name = "Button17"
        Me.Button17.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button17.Size = New System.Drawing.Size(215, 29)
        Me.Button17.TabIndex = 10
        Me.Button17.Text = "Customer Info"
        Me.Button17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.BunifuTransition1.SetDecoration(Me.Button18, BunifuAnimatorNS.DecorationType.None)
        Me.Button18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button18.FlatAppearance.BorderSize = 0
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.ForeColor = System.Drawing.Color.Transparent
        Me.Button18.Location = New System.Drawing.Point(0, 29)
        Me.Button18.Margin = New System.Windows.Forms.Padding(0)
        Me.Button18.Name = "Button18"
        Me.Button18.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button18.Size = New System.Drawing.Size(215, 29)
        Me.Button18.TabIndex = 9
        Me.Button18.Text = "Periodic Schedule"
        Me.Button18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.BunifuTransition1.SetDecoration(Me.Button19, BunifuAnimatorNS.DecorationType.None)
        Me.Button19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button19.FlatAppearance.BorderSize = 0
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.ForeColor = System.Drawing.Color.Transparent
        Me.Button19.Location = New System.Drawing.Point(0, 0)
        Me.Button19.Margin = New System.Windows.Forms.Padding(0)
        Me.Button19.Name = "Button19"
        Me.Button19.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button19.Size = New System.Drawing.Size(215, 29)
        Me.Button19.TabIndex = 8
        Me.Button19.Text = "Global Report"
        Me.Button19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PnMonitor)
        Me.Panel1.Controls.Add(Me.BtnQuality)
        Me.Panel1.Controls.Add(Me.PnStandar)
        Me.Panel1.Controls.Add(Me.BtnStandard)
        Me.Panel1.Controls.Add(Me.PnInternal)
        Me.Panel1.Controls.Add(Me.BtnInternal)
        Me.Panel1.Controls.Add(Me.PnSampling)
        Me.Panel1.Controls.Add(Me.BtnSampling)
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.HorizontalScrollbar = True
        Me.Panel1.HorizontalScrollbarBarColor = False
        Me.Panel1.HorizontalScrollbarHighlightOnWheel = False
        Me.Panel1.HorizontalScrollbarSize = 0
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 805)
        Me.Panel1.TabIndex = 0
        Me.Panel1.UseCustomBackColor = True
        Me.Panel1.UseCustomForeColor = True
        Me.Panel1.VerticalScrollbar = True
        Me.Panel1.VerticalScrollbarBarColor = True
        Me.Panel1.VerticalScrollbarHighlightOnWheel = True
        Me.Panel1.VerticalScrollbarSize = 8
        '
        'containermenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Name = "containermenu"
        Me.Size = New System.Drawing.Size(215, 805)
        Me.PnSampling.ResumeLayout(False)
        Me.PnInternal.ResumeLayout(False)
        Me.PnStandar.ResumeLayout(False)
        Me.PnMonitor.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BtnSampling As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PnSampling As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnInternal As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PnInternal As Panel
    Friend WithEvents Button14 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents BtnStandard As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PnStandar As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents BtnQuality As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PnMonitor As Panel
    Friend WithEvents Button20 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Panel1 As MetroFramework.Controls.MetroPanel
End Class
