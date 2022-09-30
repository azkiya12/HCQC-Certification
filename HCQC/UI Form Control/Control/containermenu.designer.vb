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
        Me.PnSampling = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelNotifContainerTracing = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BtnSamArchive = New System.Windows.Forms.Button()
        Me.BtnCheckin = New System.Windows.Forms.Button()
        Me.BtnSamReceipt2 = New System.Windows.Forms.Button()
        Me.BtnQcMenu = New System.Windows.Forms.Button()
        Me.PnInternal = New System.Windows.Forms.Panel()
        Me.BtnListDetail = New System.Windows.Forms.Button()
        Me.BtnInspection = New System.Windows.Forms.Button()
        Me.BtnViability = New System.Windows.Forms.Button()
        Me.BtnRafraction = New System.Windows.Forms.Button()
        Me.PnStandar = New System.Windows.Forms.Panel()
        Me.BtnDetailList2 = New System.Windows.Forms.Button()
        Me.BtnGermination = New System.Windows.Forms.Button()
        Me.BtnPurity = New System.Windows.Forms.Button()
        Me.BtnMoisture = New System.Windows.Forms.Button()
        Me.PnMonitor = New System.Windows.Forms.Panel()
        Me.BtnListReportSas = New System.Windows.Forms.Button()
        Me.BtnInspectionList = New System.Windows.Forms.Button()
        Me.BtnLeadTime = New System.Windows.Forms.Button()
        Me.Panel1 = New MetroFramework.Controls.MetroPanel()
        Me.PnMainMenu = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnHarvestPlan = New System.Windows.Forms.Button()
        Me.BtnPeriodic = New System.Windows.Forms.Button()
        Me.BtnGlobal = New System.Windows.Forms.Button()
        Me.BtnTracking = New System.Windows.Forms.Button()
        Me.BtnRequest = New System.Windows.Forms.Button()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnMonitor = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnInternal = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnStandard = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnSampling = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnMainMenu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PnSampling.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PnInternal.SuspendLayout()
        Me.PnStandar.SuspendLayout()
        Me.PnMonitor.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PnMainMenu.SuspendLayout()
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
        'PnSampling
        '
        Me.PnSampling.AutoSize = True
        Me.PnSampling.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.PnSampling.Controls.Add(Me.Panel2)
        Me.PnSampling.Controls.Add(Me.BtnSamArchive)
        Me.PnSampling.Controls.Add(Me.BtnCheckin)
        Me.PnSampling.Controls.Add(Me.BtnSamReceipt2)
        Me.PnSampling.Controls.Add(Me.BtnQcMenu)
        Me.BunifuTransition1.SetDecoration(Me.PnSampling, BunifuAnimatorNS.DecorationType.None)
        Me.PnSampling.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnSampling.Location = New System.Drawing.Point(0, 254)
        Me.PnSampling.Margin = New System.Windows.Forms.Padding(0)
        Me.PnSampling.Name = "PnSampling"
        Me.PnSampling.Size = New System.Drawing.Size(198, 116)
        Me.PnSampling.TabIndex = 5
        Me.PnSampling.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Controls.Add(Me.LabelNotifContainerTracing)
        Me.BunifuTransition1.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Location = New System.Drawing.Point(145, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(32, 18)
        Me.Panel2.TabIndex = 14
        '
        'LabelNotifContainerTracing
        '
        Me.LabelNotifContainerTracing.AutoEllipsis = True
        Me.LabelNotifContainerTracing.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.LabelNotifContainerTracing, BunifuAnimatorNS.DecorationType.None)
        Me.LabelNotifContainerTracing.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNotifContainerTracing.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.LabelNotifContainerTracing.Location = New System.Drawing.Point(3, 1)
        Me.LabelNotifContainerTracing.Name = "LabelNotifContainerTracing"
        Me.LabelNotifContainerTracing.Size = New System.Drawing.Size(26, 18)
        Me.LabelNotifContainerTracing.TabIndex = 9
        Me.LabelNotifContainerTracing.Text = "123"
        Me.LabelNotifContainerTracing.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnSamArchive
        '
        Me.BunifuTransition1.SetDecoration(Me.BtnSamArchive, BunifuAnimatorNS.DecorationType.None)
        Me.BtnSamArchive.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSamArchive.FlatAppearance.BorderSize = 0
        Me.BtnSamArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSamArchive.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSamArchive.Location = New System.Drawing.Point(0, 87)
        Me.BtnSamArchive.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnSamArchive.Name = "BtnSamArchive"
        Me.BtnSamArchive.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnSamArchive.Size = New System.Drawing.Size(198, 29)
        Me.BtnSamArchive.TabIndex = 7
        Me.BtnSamArchive.Text = "Sample Archive FG"
        Me.BtnSamArchive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSamArchive.UseVisualStyleBackColor = True
        '
        'BtnCheckin
        '
        Me.BunifuTransition1.SetDecoration(Me.BtnCheckin, BunifuAnimatorNS.DecorationType.None)
        Me.BtnCheckin.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCheckin.FlatAppearance.BorderSize = 0
        Me.BtnCheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCheckin.ForeColor = System.Drawing.Color.Transparent
        Me.BtnCheckin.Location = New System.Drawing.Point(0, 58)
        Me.BtnCheckin.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnCheckin.Name = "BtnCheckin"
        Me.BtnCheckin.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnCheckin.Size = New System.Drawing.Size(198, 29)
        Me.BtnCheckin.TabIndex = 9
        Me.BtnCheckin.Text = "Test Check In"
        Me.BtnCheckin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCheckin.UseVisualStyleBackColor = True
        '
        'BtnSamReceipt2
        '
        Me.BunifuTransition1.SetDecoration(Me.BtnSamReceipt2, BunifuAnimatorNS.DecorationType.None)
        Me.BtnSamReceipt2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSamReceipt2.FlatAppearance.BorderSize = 0
        Me.BtnSamReceipt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSamReceipt2.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSamReceipt2.Location = New System.Drawing.Point(0, 29)
        Me.BtnSamReceipt2.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnSamReceipt2.Name = "BtnSamReceipt2"
        Me.BtnSamReceipt2.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnSamReceipt2.Size = New System.Drawing.Size(198, 29)
        Me.BtnSamReceipt2.TabIndex = 8
        Me.BtnSamReceipt2.Text = "Sample Receipt"
        Me.BtnSamReceipt2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSamReceipt2.UseVisualStyleBackColor = True
        '
        'BtnQcMenu
        '
        Me.BunifuTransition1.SetDecoration(Me.BtnQcMenu, BunifuAnimatorNS.DecorationType.None)
        Me.BtnQcMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnQcMenu.FlatAppearance.BorderSize = 0
        Me.BtnQcMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnQcMenu.ForeColor = System.Drawing.Color.Transparent
        Me.BtnQcMenu.Location = New System.Drawing.Point(0, 0)
        Me.BtnQcMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnQcMenu.Name = "BtnQcMenu"
        Me.BtnQcMenu.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnQcMenu.Size = New System.Drawing.Size(198, 29)
        Me.BtnQcMenu.TabIndex = 13
        Me.BtnQcMenu.Text = "Testing Request"
        Me.BtnQcMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnQcMenu.UseVisualStyleBackColor = True
        '
        'PnInternal
        '
        Me.PnInternal.AutoSize = True
        Me.PnInternal.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.PnInternal.Controls.Add(Me.BtnListDetail)
        Me.PnInternal.Controls.Add(Me.BtnInspection)
        Me.PnInternal.Controls.Add(Me.BtnViability)
        Me.PnInternal.Controls.Add(Me.BtnRafraction)
        Me.BunifuTransition1.SetDecoration(Me.PnInternal, BunifuAnimatorNS.DecorationType.None)
        Me.PnInternal.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnInternal.Location = New System.Drawing.Point(0, 566)
        Me.PnInternal.Margin = New System.Windows.Forms.Padding(0)
        Me.PnInternal.Name = "PnInternal"
        Me.PnInternal.Size = New System.Drawing.Size(198, 116)
        Me.PnInternal.TabIndex = 9
        Me.PnInternal.Visible = False
        '
        'BtnListDetail
        '
        Me.BunifuTransition1.SetDecoration(Me.BtnListDetail, BunifuAnimatorNS.DecorationType.None)
        Me.BtnListDetail.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnListDetail.FlatAppearance.BorderSize = 0
        Me.BtnListDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnListDetail.ForeColor = System.Drawing.Color.Transparent
        Me.BtnListDetail.Location = New System.Drawing.Point(0, 87)
        Me.BtnListDetail.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnListDetail.Name = "BtnListDetail"
        Me.BtnListDetail.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnListDetail.Size = New System.Drawing.Size(198, 29)
        Me.BtnListDetail.TabIndex = 16
        Me.BtnListDetail.Text = "Detail List"
        Me.BtnListDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnListDetail.UseVisualStyleBackColor = True
        '
        'BtnInspection
        '
        Me.BunifuTransition1.SetDecoration(Me.BtnInspection, BunifuAnimatorNS.DecorationType.None)
        Me.BtnInspection.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnInspection.FlatAppearance.BorderSize = 0
        Me.BtnInspection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInspection.ForeColor = System.Drawing.Color.Transparent
        Me.BtnInspection.Location = New System.Drawing.Point(0, 58)
        Me.BtnInspection.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnInspection.Name = "BtnInspection"
        Me.BtnInspection.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnInspection.Size = New System.Drawing.Size(198, 29)
        Me.BtnInspection.TabIndex = 15
        Me.BtnInspection.Text = "Inspection RM"
        Me.BtnInspection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInspection.UseVisualStyleBackColor = True
        Me.BtnInspection.Visible = False
        '
        'BtnViability
        '
        Me.BunifuTransition1.SetDecoration(Me.BtnViability, BunifuAnimatorNS.DecorationType.None)
        Me.BtnViability.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnViability.FlatAppearance.BorderSize = 0
        Me.BtnViability.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnViability.ForeColor = System.Drawing.Color.Transparent
        Me.BtnViability.Location = New System.Drawing.Point(0, 29)
        Me.BtnViability.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnViability.Name = "BtnViability"
        Me.BtnViability.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnViability.Size = New System.Drawing.Size(198, 29)
        Me.BtnViability.TabIndex = 14
        Me.BtnViability.Text = "Viability Test"
        Me.BtnViability.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnViability.UseVisualStyleBackColor = True
        '
        'BtnRafraction
        '
        Me.BunifuTransition1.SetDecoration(Me.BtnRafraction, BunifuAnimatorNS.DecorationType.None)
        Me.BtnRafraction.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRafraction.FlatAppearance.BorderSize = 0
        Me.BtnRafraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRafraction.ForeColor = System.Drawing.Color.Transparent
        Me.BtnRafraction.Location = New System.Drawing.Point(0, 0)
        Me.BtnRafraction.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnRafraction.Name = "BtnRafraction"
        Me.BtnRafraction.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnRafraction.Size = New System.Drawing.Size(198, 29)
        Me.BtnRafraction.TabIndex = 13
        Me.BtnRafraction.Text = "Internal Rafaction"
        Me.BtnRafraction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRafraction.UseVisualStyleBackColor = True
        '
        'PnStandar
        '
        Me.PnStandar.AutoSize = True
        Me.PnStandar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.PnStandar.Controls.Add(Me.BtnDetailList2)
        Me.PnStandar.Controls.Add(Me.BtnGermination)
        Me.PnStandar.Controls.Add(Me.BtnPurity)
        Me.PnStandar.Controls.Add(Me.BtnMoisture)
        Me.BunifuTransition1.SetDecoration(Me.PnStandar, BunifuAnimatorNS.DecorationType.None)
        Me.PnStandar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnStandar.Location = New System.Drawing.Point(0, 410)
        Me.PnStandar.Margin = New System.Windows.Forms.Padding(0)
        Me.PnStandar.Name = "PnStandar"
        Me.PnStandar.Size = New System.Drawing.Size(198, 116)
        Me.PnStandar.TabIndex = 11
        Me.PnStandar.Visible = False
        '
        'BtnDetailList2
        '
        Me.BunifuTransition1.SetDecoration(Me.BtnDetailList2, BunifuAnimatorNS.DecorationType.None)
        Me.BtnDetailList2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDetailList2.FlatAppearance.BorderSize = 0
        Me.BtnDetailList2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDetailList2.ForeColor = System.Drawing.Color.Transparent
        Me.BtnDetailList2.Location = New System.Drawing.Point(0, 87)
        Me.BtnDetailList2.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnDetailList2.Name = "BtnDetailList2"
        Me.BtnDetailList2.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnDetailList2.Size = New System.Drawing.Size(198, 29)
        Me.BtnDetailList2.TabIndex = 11
        Me.BtnDetailList2.Text = "Detail List"
        Me.BtnDetailList2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDetailList2.UseVisualStyleBackColor = True
        '
        'BtnGermination
        '
        Me.BunifuTransition1.SetDecoration(Me.BtnGermination, BunifuAnimatorNS.DecorationType.None)
        Me.BtnGermination.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnGermination.FlatAppearance.BorderSize = 0
        Me.BtnGermination.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGermination.ForeColor = System.Drawing.Color.Transparent
        Me.BtnGermination.Location = New System.Drawing.Point(0, 58)
        Me.BtnGermination.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnGermination.Name = "BtnGermination"
        Me.BtnGermination.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnGermination.Size = New System.Drawing.Size(198, 29)
        Me.BtnGermination.TabIndex = 10
        Me.BtnGermination.Text = "Gemination Test"
        Me.BtnGermination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGermination.UseVisualStyleBackColor = True
        '
        'BtnPurity
        '
        Me.BunifuTransition1.SetDecoration(Me.BtnPurity, BunifuAnimatorNS.DecorationType.None)
        Me.BtnPurity.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPurity.FlatAppearance.BorderSize = 0
        Me.BtnPurity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPurity.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPurity.Location = New System.Drawing.Point(0, 29)
        Me.BtnPurity.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnPurity.Name = "BtnPurity"
        Me.BtnPurity.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnPurity.Size = New System.Drawing.Size(198, 29)
        Me.BtnPurity.TabIndex = 9
        Me.BtnPurity.Text = "Purity ISTA Test"
        Me.BtnPurity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPurity.UseVisualStyleBackColor = True
        '
        'BtnMoisture
        '
        Me.BunifuTransition1.SetDecoration(Me.BtnMoisture, BunifuAnimatorNS.DecorationType.None)
        Me.BtnMoisture.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnMoisture.FlatAppearance.BorderSize = 0
        Me.BtnMoisture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMoisture.ForeColor = System.Drawing.Color.Transparent
        Me.BtnMoisture.Location = New System.Drawing.Point(0, 0)
        Me.BtnMoisture.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnMoisture.Name = "BtnMoisture"
        Me.BtnMoisture.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnMoisture.Size = New System.Drawing.Size(198, 29)
        Me.BtnMoisture.TabIndex = 8
        Me.BtnMoisture.Text = "Moisture Test"
        Me.BtnMoisture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMoisture.UseVisualStyleBackColor = True
        '
        'PnMonitor
        '
        Me.PnMonitor.AutoSize = True
        Me.PnMonitor.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.PnMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PnMonitor.Controls.Add(Me.BtnListReportSas)
        Me.PnMonitor.Controls.Add(Me.BtnInspectionList)
        Me.PnMonitor.Controls.Add(Me.BtnLeadTime)
        Me.BunifuTransition1.SetDecoration(Me.PnMonitor, BunifuAnimatorNS.DecorationType.None)
        Me.PnMonitor.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnMonitor.Location = New System.Drawing.Point(0, 722)
        Me.PnMonitor.Margin = New System.Windows.Forms.Padding(0)
        Me.PnMonitor.Name = "PnMonitor"
        Me.PnMonitor.Size = New System.Drawing.Size(198, 87)
        Me.PnMonitor.TabIndex = 13
        Me.PnMonitor.Visible = False
        '
        'BtnListReportSas
        '
        Me.BunifuTransition1.SetDecoration(Me.BtnListReportSas, BunifuAnimatorNS.DecorationType.None)
        Me.BtnListReportSas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnListReportSas.FlatAppearance.BorderSize = 0
        Me.BtnListReportSas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnListReportSas.ForeColor = System.Drawing.Color.Transparent
        Me.BtnListReportSas.Location = New System.Drawing.Point(0, 58)
        Me.BtnListReportSas.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnListReportSas.Name = "BtnListReportSas"
        Me.BtnListReportSas.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnListReportSas.Size = New System.Drawing.Size(198, 29)
        Me.BtnListReportSas.TabIndex = 13
        Me.BtnListReportSas.Text = "Report SAS"
        Me.BtnListReportSas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnListReportSas.UseVisualStyleBackColor = True
        '
        'BtnInspectionList
        '
        Me.BunifuTransition1.SetDecoration(Me.BtnInspectionList, BunifuAnimatorNS.DecorationType.None)
        Me.BtnInspectionList.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnInspectionList.FlatAppearance.BorderSize = 0
        Me.BtnInspectionList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInspectionList.ForeColor = System.Drawing.Color.Transparent
        Me.BtnInspectionList.Location = New System.Drawing.Point(0, 29)
        Me.BtnInspectionList.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnInspectionList.Name = "BtnInspectionList"
        Me.BtnInspectionList.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnInspectionList.Size = New System.Drawing.Size(198, 29)
        Me.BtnInspectionList.TabIndex = 12
        Me.BtnInspectionList.Text = "Data List Inspection"
        Me.BtnInspectionList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInspectionList.UseVisualStyleBackColor = True
        Me.BtnInspectionList.Visible = False
        '
        'BtnLeadTime
        '
        Me.BunifuTransition1.SetDecoration(Me.BtnLeadTime, BunifuAnimatorNS.DecorationType.None)
        Me.BtnLeadTime.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnLeadTime.FlatAppearance.BorderSize = 0
        Me.BtnLeadTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLeadTime.ForeColor = System.Drawing.Color.Transparent
        Me.BtnLeadTime.Location = New System.Drawing.Point(0, 0)
        Me.BtnLeadTime.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnLeadTime.Name = "BtnLeadTime"
        Me.BtnLeadTime.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnLeadTime.Size = New System.Drawing.Size(198, 29)
        Me.BtnLeadTime.TabIndex = 11
        Me.BtnLeadTime.Text = "Lead Time and Status"
        Me.BtnLeadTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLeadTime.UseVisualStyleBackColor = True
        Me.BtnLeadTime.Visible = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel1.Controls.Add(Me.PnMonitor)
        Me.Panel1.Controls.Add(Me.BtnMonitor)
        Me.Panel1.Controls.Add(Me.PnInternal)
        Me.Panel1.Controls.Add(Me.BtnInternal)
        Me.Panel1.Controls.Add(Me.PnStandar)
        Me.Panel1.Controls.Add(Me.BtnStandard)
        Me.Panel1.Controls.Add(Me.PnSampling)
        Me.Panel1.Controls.Add(Me.BtnSampling)
        Me.Panel1.Controls.Add(Me.PnMainMenu)
        Me.Panel1.Controls.Add(Me.BtnMainMenu)
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.HorizontalScrollbar = True
        Me.Panel1.HorizontalScrollbarBarColor = False
        Me.Panel1.HorizontalScrollbarHighlightOnWheel = False
        Me.Panel1.HorizontalScrollbarSize = 0
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 780)
        Me.Panel1.TabIndex = 0
        Me.Panel1.UseCustomBackColor = True
        Me.Panel1.UseCustomForeColor = True
        Me.Panel1.UseStyleColors = True
        Me.Panel1.VerticalScrollbar = True
        Me.Panel1.VerticalScrollbarBarColor = True
        Me.Panel1.VerticalScrollbarHighlightOnWheel = True
        Me.Panel1.VerticalScrollbarSize = 8
        '
        'PnMainMenu
        '
        Me.PnMainMenu.AutoSize = True
        Me.PnMainMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.PnMainMenu.Controls.Add(Me.Button1)
        Me.PnMainMenu.Controls.Add(Me.BtnHarvestPlan)
        Me.PnMainMenu.Controls.Add(Me.BtnPeriodic)
        Me.PnMainMenu.Controls.Add(Me.BtnGlobal)
        Me.PnMainMenu.Controls.Add(Me.BtnTracking)
        Me.PnMainMenu.Controls.Add(Me.BtnRequest)
        Me.BunifuTransition1.SetDecoration(Me.PnMainMenu, BunifuAnimatorNS.DecorationType.None)
        Me.PnMainMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnMainMenu.Location = New System.Drawing.Point(0, 40)
        Me.PnMainMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.PnMainMenu.Name = "PnMainMenu"
        Me.PnMainMenu.Size = New System.Drawing.Size(198, 174)
        Me.PnMainMenu.TabIndex = 16
        Me.PnMainMenu.Visible = False
        '
        'Button1
        '
        Me.BunifuTransition1.SetDecoration(Me.Button1, BunifuAnimatorNS.DecorationType.None)
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(0, 145)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(198, 29)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Customer Info"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnHarvestPlan
        '
        Me.BunifuTransition1.SetDecoration(Me.BtnHarvestPlan, BunifuAnimatorNS.DecorationType.None)
        Me.BtnHarvestPlan.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnHarvestPlan.FlatAppearance.BorderSize = 0
        Me.BtnHarvestPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHarvestPlan.ForeColor = System.Drawing.Color.Transparent
        Me.BtnHarvestPlan.Location = New System.Drawing.Point(0, 116)
        Me.BtnHarvestPlan.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnHarvestPlan.Name = "BtnHarvestPlan"
        Me.BtnHarvestPlan.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnHarvestPlan.Size = New System.Drawing.Size(198, 29)
        Me.BtnHarvestPlan.TabIndex = 17
        Me.BtnHarvestPlan.Text = "Harvest Planning"
        Me.BtnHarvestPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHarvestPlan.UseVisualStyleBackColor = True
        '
        'BtnPeriodic
        '
        Me.BunifuTransition1.SetDecoration(Me.BtnPeriodic, BunifuAnimatorNS.DecorationType.None)
        Me.BtnPeriodic.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPeriodic.FlatAppearance.BorderSize = 0
        Me.BtnPeriodic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPeriodic.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPeriodic.Location = New System.Drawing.Point(0, 87)
        Me.BtnPeriodic.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnPeriodic.Name = "BtnPeriodic"
        Me.BtnPeriodic.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnPeriodic.Size = New System.Drawing.Size(198, 29)
        Me.BtnPeriodic.TabIndex = 14
        Me.BtnPeriodic.Text = "Periodic Schedule"
        Me.BtnPeriodic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPeriodic.UseVisualStyleBackColor = True
        '
        'BtnGlobal
        '
        Me.BunifuTransition1.SetDecoration(Me.BtnGlobal, BunifuAnimatorNS.DecorationType.None)
        Me.BtnGlobal.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnGlobal.FlatAppearance.BorderSize = 0
        Me.BtnGlobal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGlobal.ForeColor = System.Drawing.Color.Transparent
        Me.BtnGlobal.Location = New System.Drawing.Point(0, 58)
        Me.BtnGlobal.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnGlobal.Name = "BtnGlobal"
        Me.BtnGlobal.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnGlobal.Size = New System.Drawing.Size(198, 29)
        Me.BtnGlobal.TabIndex = 13
        Me.BtnGlobal.Text = "Global Report"
        Me.BtnGlobal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGlobal.UseVisualStyleBackColor = True
        '
        'BtnTracking
        '
        Me.BunifuTransition1.SetDecoration(Me.BtnTracking, BunifuAnimatorNS.DecorationType.None)
        Me.BtnTracking.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTracking.FlatAppearance.BorderSize = 0
        Me.BtnTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTracking.ForeColor = System.Drawing.Color.Transparent
        Me.BtnTracking.Location = New System.Drawing.Point(0, 29)
        Me.BtnTracking.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnTracking.Name = "BtnTracking"
        Me.BtnTracking.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnTracking.Size = New System.Drawing.Size(198, 29)
        Me.BtnTracking.TabIndex = 15
        Me.BtnTracking.Text = "Tracking"
        Me.BtnTracking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTracking.UseVisualStyleBackColor = True
        '
        'BtnRequest
        '
        Me.BunifuTransition1.SetDecoration(Me.BtnRequest, BunifuAnimatorNS.DecorationType.None)
        Me.BtnRequest.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRequest.FlatAppearance.BorderSize = 0
        Me.BtnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRequest.ForeColor = System.Drawing.Color.Transparent
        Me.BtnRequest.Location = New System.Drawing.Point(0, 0)
        Me.BtnRequest.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnRequest.Name = "BtnRequest"
        Me.BtnRequest.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnRequest.Size = New System.Drawing.Size(198, 29)
        Me.BtnRequest.TabIndex = 11
        Me.BtnRequest.Text = "Request Form"
        Me.BtnRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRequest.UseVisualStyleBackColor = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 12
        Me.BunifuElipse1.TargetControl = Me.Panel2
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "  Reporting"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 50.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(0, 809)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(198, 40)
        Me.BunifuFlatButton1.TabIndex = 14
        Me.BunifuFlatButton1.Text = "  Reporting"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnMonitor
        '
        Me.BtnMonitor.Activecolor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BtnMonitor.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMonitor.BorderRadius = 0
        Me.BtnMonitor.ButtonText = "  Monitoring"
        Me.BtnMonitor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BtnMonitor, BunifuAnimatorNS.DecorationType.None)
        Me.BtnMonitor.DisabledColor = System.Drawing.Color.Gray
        Me.BtnMonitor.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnMonitor.Enabled = False
        Me.BtnMonitor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMonitor.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnMonitor.Iconimage = CType(resources.GetObject("BtnMonitor.Iconimage"), System.Drawing.Image)
        Me.BtnMonitor.Iconimage_right = Nothing
        Me.BtnMonitor.Iconimage_right_Selected = Nothing
        Me.BtnMonitor.Iconimage_Selected = Nothing
        Me.BtnMonitor.IconMarginLeft = 0
        Me.BtnMonitor.IconMarginRight = 0
        Me.BtnMonitor.IconRightVisible = True
        Me.BtnMonitor.IconRightZoom = 0R
        Me.BtnMonitor.IconVisible = True
        Me.BtnMonitor.IconZoom = 50.0R
        Me.BtnMonitor.IsTab = False
        Me.BtnMonitor.Location = New System.Drawing.Point(0, 682)
        Me.BtnMonitor.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnMonitor.Name = "BtnMonitor"
        Me.BtnMonitor.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnMonitor.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BtnMonitor.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnMonitor.selected = False
        Me.BtnMonitor.Size = New System.Drawing.Size(198, 40)
        Me.BtnMonitor.TabIndex = 12
        Me.BtnMonitor.Text = "  Monitoring"
        Me.BtnMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMonitor.Textcolor = System.Drawing.Color.White
        Me.BtnMonitor.TextFont = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMonitor.Visible = False
        '
        'BtnInternal
        '
        Me.BtnInternal.Activecolor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BtnInternal.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnInternal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnInternal.BorderRadius = 0
        Me.BtnInternal.ButtonText = "  Internal Quality"
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
        Me.BtnInternal.Location = New System.Drawing.Point(0, 526)
        Me.BtnInternal.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnInternal.Name = "BtnInternal"
        Me.BtnInternal.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnInternal.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BtnInternal.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnInternal.selected = False
        Me.BtnInternal.Size = New System.Drawing.Size(198, 40)
        Me.BtnInternal.TabIndex = 8
        Me.BtnInternal.Text = "  Internal Quality"
        Me.BtnInternal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInternal.Textcolor = System.Drawing.Color.White
        Me.BtnInternal.TextFont = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnStandard
        '
        Me.BtnStandard.Activecolor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BtnStandard.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnStandard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnStandard.BorderRadius = 0
        Me.BtnStandard.ButtonText = "  Certification Standard"
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
        Me.BtnStandard.Location = New System.Drawing.Point(0, 370)
        Me.BtnStandard.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnStandard.Name = "BtnStandard"
        Me.BtnStandard.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnStandard.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BtnStandard.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnStandard.selected = False
        Me.BtnStandard.Size = New System.Drawing.Size(198, 40)
        Me.BtnStandard.TabIndex = 10
        Me.BtnStandard.Text = "  Certification Standard"
        Me.BtnStandard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnStandard.Textcolor = System.Drawing.Color.White
        Me.BtnStandard.TextFont = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnSampling
        '
        Me.BtnSampling.Activecolor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BtnSampling.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnSampling.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSampling.BorderRadius = 0
        Me.BtnSampling.ButtonText = "  QC Menu"
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
        Me.BtnSampling.Location = New System.Drawing.Point(0, 214)
        Me.BtnSampling.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnSampling.Name = "BtnSampling"
        Me.BtnSampling.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnSampling.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BtnSampling.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnSampling.selected = False
        Me.BtnSampling.Size = New System.Drawing.Size(198, 40)
        Me.BtnSampling.TabIndex = 2
        Me.BtnSampling.Text = "  QC Menu"
        Me.BtnSampling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSampling.Textcolor = System.Drawing.Color.White
        Me.BtnSampling.TextFont = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnMainMenu
        '
        Me.BtnMainMenu.Activecolor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BtnMainMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMainMenu.BorderRadius = 0
        Me.BtnMainMenu.ButtonText = "  Main Menu"
        Me.BtnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BtnMainMenu, BunifuAnimatorNS.DecorationType.None)
        Me.BtnMainMenu.DisabledColor = System.Drawing.Color.Gray
        Me.BtnMainMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnMainMenu.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMainMenu.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnMainMenu.Iconimage = CType(resources.GetObject("BtnMainMenu.Iconimage"), System.Drawing.Image)
        Me.BtnMainMenu.Iconimage_right = Nothing
        Me.BtnMainMenu.Iconimage_right_Selected = Nothing
        Me.BtnMainMenu.Iconimage_Selected = Nothing
        Me.BtnMainMenu.IconMarginLeft = 0
        Me.BtnMainMenu.IconMarginRight = 0
        Me.BtnMainMenu.IconRightVisible = False
        Me.BtnMainMenu.IconRightZoom = 0R
        Me.BtnMainMenu.IconVisible = True
        Me.BtnMainMenu.IconZoom = 50.0R
        Me.BtnMainMenu.IsTab = False
        Me.BtnMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.BtnMainMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnMainMenu.Name = "BtnMainMenu"
        Me.BtnMainMenu.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnMainMenu.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BtnMainMenu.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnMainMenu.selected = False
        Me.BtnMainMenu.Size = New System.Drawing.Size(198, 40)
        Me.BtnMainMenu.TabIndex = 15
        Me.BtnMainMenu.Text = "  Main Menu"
        Me.BtnMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMainMenu.Textcolor = System.Drawing.Color.White
        Me.BtnMainMenu.TextFont = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'containermenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Name = "containermenu"
        Me.Size = New System.Drawing.Size(215, 780)
        Me.PnSampling.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PnInternal.ResumeLayout(False)
        Me.PnStandar.ResumeLayout(False)
        Me.PnMonitor.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PnMainMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BtnSampling As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PnSampling As Panel
    Friend WithEvents BtnSamArchive As Button
    Friend WithEvents BtnInternal As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PnInternal As Panel
    Friend WithEvents BtnListDetail As Button
    Friend WithEvents BtnViability As Button
    Friend WithEvents BtnRafraction As Button
    Friend WithEvents BtnStandard As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PnStandar As Panel
    Friend WithEvents BtnDetailList2 As Button
    Friend WithEvents BtnGermination As Button
    Friend WithEvents BtnPurity As Button
    Friend WithEvents BtnMoisture As Button
    Friend WithEvents BtnMonitor As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PnMonitor As Panel
    Friend WithEvents BtnListReportSas As Button
    Friend WithEvents BtnInspectionList As Button
    Friend WithEvents BtnLeadTime As Button
    Friend WithEvents Panel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents BtnInspection As Button
    Friend WithEvents BtnSamReceipt2 As Button
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BtnMainMenu As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PnMainMenu As Panel
    Friend WithEvents BtnPeriodic As Button
    Friend WithEvents BtnGlobal As Button
    Friend WithEvents BtnRequest As Button
    Friend WithEvents BtnTracking As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnCheckin As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelNotifContainerTracing As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BtnQcMenu As Button
    Friend WithEvents BtnHarvestPlan As Button
End Class
