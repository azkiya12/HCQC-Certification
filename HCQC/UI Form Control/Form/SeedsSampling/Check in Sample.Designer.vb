<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Check_in_Sample
    Inherits MetroFramework.Controls.MetroUserControl

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
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.NavigationFrame1 = New DevExpress.XtraBars.Navigation.NavigationFrame()
        Me.NavigationPage3 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.CheckInKa1 = New CheckInKa()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.NavigationPage4 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.CheckInPur1 = New CheckInPur()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.CheckInGer1 = New CheckInGer()
        Me.BunifuFlatButton7 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.CheckInRaf1 = New CheckInRaf()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.NavigationPage5 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.CheckInVia1 = New CheckInVia()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.NavigationPage6 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.CheckOutQC1 = New CheckOutQC()
        Me.BunifuFlatButton5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.NavigationPage7 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.CheckReturnHCP1 = New CheckReturnHCP()
        Me.BunifuFlatButton6 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.NavigationPage8 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Link1Count = New MetroFramework.Controls.MetroLink()
        Me.LinkVigor = New MetroFramework.Controls.MetroLink()
        Me.LinkReceiptHCP = New MetroFramework.Controls.MetroLink()
        Me.LinkReturnQC = New MetroFramework.Controls.MetroLink()
        Me.LinkGerminationTest = New MetroFramework.Controls.MetroLink()
        Me.LinkViability = New MetroFramework.Controls.MetroLink()
        Me.LinkRafactionTest = New MetroFramework.Controls.MetroLink()
        Me.LinkPurityTest = New MetroFramework.Controls.MetroLink()
        Me.LinkMoistureTest = New MetroFramework.Controls.MetroLink()
        Me.NavigationPage9 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.CheckInVigor1 = New CheckInVigor()
        Me.BunifuFlatButton10 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.NavigationPage11 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.BunifuFlatButton11 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.CheckIn1Count1 = New CheckIn1Count()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.BunifuFlatButton8 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.NavigationPage10 = New DevExpress.XtraBars.Navigation.NavigationPage()
        CType(Me.NavigationFrame1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationFrame1.SuspendLayout()
        Me.NavigationPage3.SuspendLayout()
        Me.NavigationPage4.SuspendLayout()
        Me.NavigationPage1.SuspendLayout()
        Me.NavigationPage2.SuspendLayout()
        Me.NavigationPage5.SuspendLayout()
        Me.NavigationPage6.SuspendLayout()
        Me.NavigationPage7.SuspendLayout()
        Me.NavigationPage8.SuspendLayout()
        Me.NavigationPage9.SuspendLayout()
        Me.NavigationPage11.SuspendLayout()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NavigationFrame1
        '
        Me.NavigationFrame1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.NavigationFrame1.Appearance.Options.UseBackColor = True
        Me.MetroStyleExtender1.SetApplyMetroTheme(Me.NavigationFrame1, True)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage3)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage4)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage1)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage2)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage5)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage6)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage7)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage8)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage9)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage11)
        Me.NavigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavigationFrame1.Location = New System.Drawing.Point(0, 0)
        Me.NavigationFrame1.Name = "NavigationFrame1"
        Me.NavigationFrame1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.NavigationPage1, Me.NavigationPage2, Me.NavigationPage3, Me.NavigationPage4, Me.NavigationPage5, Me.NavigationPage6, Me.NavigationPage7, Me.NavigationPage8, Me.NavigationPage9, Me.NavigationPage11})
        Me.NavigationFrame1.SelectedPage = Me.NavigationPage8
        Me.NavigationFrame1.Size = New System.Drawing.Size(723, 479)
        Me.NavigationFrame1.TabIndex = 95
        Me.NavigationFrame1.Text = "NavigationFrame1"
        Me.NavigationFrame1.TransitionAnimationProperties.FrameInterval = 1000
        '
        'NavigationPage3
        '
        Me.NavigationPage3.Controls.Add(Me.CheckInKa1)
        Me.NavigationPage3.Controls.Add(Me.BunifuFlatButton2)
        Me.NavigationPage3.Name = "NavigationPage3"
        Me.NavigationPage3.Size = New System.Drawing.Size(723, 479)
        '
        'CheckInKa1
        '
        Me.CheckInKa1.Location = New System.Drawing.Point(0, 0)
        Me.CheckInKa1.Name = "CheckInKa1"
        Me.CheckInKa1.Size = New System.Drawing.Size(317, 310)
        Me.CheckInKa1.TabIndex = 89
        Me.CheckInKa1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.CheckInKa1.UseSelectable = True
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Close"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Nothing
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = False
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = False
        Me.BunifuFlatButton2.IconZoom = 90.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(3, 316)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.Red
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(304, 34)
        Me.BunifuFlatButton2.TabIndex = 88
        Me.BunifuFlatButton2.Text = "Close"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'NavigationPage4
        '
        Me.NavigationPage4.Controls.Add(Me.CheckInPur1)
        Me.NavigationPage4.Controls.Add(Me.BunifuFlatButton3)
        Me.NavigationPage4.Name = "NavigationPage4"
        Me.NavigationPage4.Size = New System.Drawing.Size(723, 479)
        '
        'CheckInPur1
        '
        Me.CheckInPur1.Location = New System.Drawing.Point(0, 0)
        Me.CheckInPur1.Name = "CheckInPur1"
        Me.CheckInPur1.Size = New System.Drawing.Size(319, 326)
        Me.CheckInPur1.TabIndex = 89
        Me.CheckInPur1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.CheckInPur1.UseSelectable = True
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "Close"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = Nothing
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = False
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = False
        Me.BunifuFlatButton3.IconZoom = 90.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(3, 332)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.Red
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(304, 34)
        Me.BunifuFlatButton3.TabIndex = 88
        Me.BunifuFlatButton3.Text = "Close"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Controls.Add(Me.CheckInGer1)
        Me.NavigationPage1.Controls.Add(Me.BunifuFlatButton7)
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Size = New System.Drawing.Size(723, 479)
        Me.NavigationPage1.Tag = "Moisture"
        '
        'CheckInGer1
        '
        Me.CheckInGer1.Location = New System.Drawing.Point(0, 0)
        Me.CheckInGer1.Name = "CheckInGer1"
        Me.CheckInGer1.Size = New System.Drawing.Size(319, 326)
        Me.CheckInGer1.TabIndex = 92
        Me.CheckInGer1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.CheckInGer1.UseSelectable = True
        '
        'BunifuFlatButton7
        '
        Me.BunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuFlatButton7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton7.BorderRadius = 0
        Me.BunifuFlatButton7.ButtonText = "Close"
        Me.BunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.Iconimage = Nothing
        Me.BunifuFlatButton7.Iconimage_right = Nothing
        Me.BunifuFlatButton7.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton7.Iconimage_Selected = Nothing
        Me.BunifuFlatButton7.IconMarginLeft = 0
        Me.BunifuFlatButton7.IconMarginRight = 0
        Me.BunifuFlatButton7.IconRightVisible = False
        Me.BunifuFlatButton7.IconRightZoom = 0R
        Me.BunifuFlatButton7.IconVisible = False
        Me.BunifuFlatButton7.IconZoom = 90.0R
        Me.BunifuFlatButton7.IsTab = False
        Me.BunifuFlatButton7.Location = New System.Drawing.Point(6, 332)
        Me.BunifuFlatButton7.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.BunifuFlatButton7.Name = "BunifuFlatButton7"
        Me.BunifuFlatButton7.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.OnHovercolor = System.Drawing.Color.Red
        Me.BunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton7.selected = False
        Me.BunifuFlatButton7.Size = New System.Drawing.Size(304, 34)
        Me.BunifuFlatButton7.TabIndex = 89
        Me.BunifuFlatButton7.Text = "Close"
        Me.BunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton7.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton7.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Controls.Add(Me.CheckInRaf1)
        Me.NavigationPage2.Controls.Add(Me.BunifuFlatButton1)
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Size = New System.Drawing.Size(723, 479)
        Me.NavigationPage2.Tag = "Purity"
        '
        'CheckInRaf1
        '
        Me.CheckInRaf1.Location = New System.Drawing.Point(0, 0)
        Me.CheckInRaf1.Name = "CheckInRaf1"
        Me.CheckInRaf1.Size = New System.Drawing.Size(315, 332)
        Me.CheckInRaf1.TabIndex = 89
        Me.CheckInRaf1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.CheckInRaf1.UseSelectable = True
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Close"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = False
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = False
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(6, 338)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.Red
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(304, 34)
        Me.BunifuFlatButton1.TabIndex = 88
        Me.BunifuFlatButton1.Text = "Close"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'NavigationPage5
        '
        Me.NavigationPage5.Controls.Add(Me.CheckInVia1)
        Me.NavigationPage5.Controls.Add(Me.BunifuFlatButton4)
        Me.NavigationPage5.Name = "NavigationPage5"
        Me.NavigationPage5.Size = New System.Drawing.Size(723, 479)
        '
        'CheckInVia1
        '
        Me.CheckInVia1.Location = New System.Drawing.Point(0, 0)
        Me.CheckInVia1.Name = "CheckInVia1"
        Me.CheckInVia1.Size = New System.Drawing.Size(319, 326)
        Me.CheckInVia1.TabIndex = 89
        Me.CheckInVia1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.CheckInVia1.UseSelectable = True
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 0
        Me.BunifuFlatButton4.ButtonText = "Close"
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = Nothing
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = False
        Me.BunifuFlatButton4.IconRightZoom = 0R
        Me.BunifuFlatButton4.IconVisible = False
        Me.BunifuFlatButton4.IconZoom = 90.0R
        Me.BunifuFlatButton4.IsTab = False
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(3, 332)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.Red
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(304, 34)
        Me.BunifuFlatButton4.TabIndex = 88
        Me.BunifuFlatButton4.Text = "Close"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'NavigationPage6
        '
        Me.NavigationPage6.Controls.Add(Me.CheckOutQC1)
        Me.NavigationPage6.Controls.Add(Me.BunifuFlatButton5)
        Me.NavigationPage6.Name = "NavigationPage6"
        Me.NavigationPage6.Size = New System.Drawing.Size(723, 479)
        '
        'CheckOutQC1
        '
        Me.CheckOutQC1.Location = New System.Drawing.Point(3, 3)
        Me.CheckOutQC1.Name = "CheckOutQC1"
        Me.CheckOutQC1.Size = New System.Drawing.Size(717, 326)
        Me.CheckOutQC1.TabIndex = 91
        Me.CheckOutQC1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.CheckOutQC1.UseSelectable = True
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuFlatButton5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton5.BorderRadius = 0
        Me.BunifuFlatButton5.ButtonText = "Close"
        Me.BunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.Iconimage = Nothing
        Me.BunifuFlatButton5.Iconimage_right = Nothing
        Me.BunifuFlatButton5.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton5.Iconimage_Selected = Nothing
        Me.BunifuFlatButton5.IconMarginLeft = 0
        Me.BunifuFlatButton5.IconMarginRight = 0
        Me.BunifuFlatButton5.IconRightVisible = False
        Me.BunifuFlatButton5.IconRightZoom = 0R
        Me.BunifuFlatButton5.IconVisible = False
        Me.BunifuFlatButton5.IconZoom = 90.0R
        Me.BunifuFlatButton5.IsTab = False
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(6, 335)
        Me.BunifuFlatButton5.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.Red
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton5.selected = False
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(304, 34)
        Me.BunifuFlatButton5.TabIndex = 90
        Me.BunifuFlatButton5.Text = "Close"
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'NavigationPage7
        '
        Me.NavigationPage7.Controls.Add(Me.CheckReturnHCP1)
        Me.NavigationPage7.Controls.Add(Me.BunifuFlatButton6)
        Me.NavigationPage7.Name = "NavigationPage7"
        Me.NavigationPage7.Size = New System.Drawing.Size(723, 479)
        '
        'CheckReturnHCP1
        '
        Me.CheckReturnHCP1.Location = New System.Drawing.Point(3, 3)
        Me.CheckReturnHCP1.Name = "CheckReturnHCP1"
        Me.CheckReturnHCP1.Size = New System.Drawing.Size(319, 326)
        Me.CheckReturnHCP1.TabIndex = 95
        Me.CheckReturnHCP1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.CheckReturnHCP1.UseSelectable = True
        '
        'BunifuFlatButton6
        '
        Me.BunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuFlatButton6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuFlatButton6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton6.BorderRadius = 0
        Me.BunifuFlatButton6.ButtonText = "Close"
        Me.BunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.Iconimage = Nothing
        Me.BunifuFlatButton6.Iconimage_right = Nothing
        Me.BunifuFlatButton6.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton6.Iconimage_Selected = Nothing
        Me.BunifuFlatButton6.IconMarginLeft = 0
        Me.BunifuFlatButton6.IconMarginRight = 0
        Me.BunifuFlatButton6.IconRightVisible = False
        Me.BunifuFlatButton6.IconRightZoom = 0R
        Me.BunifuFlatButton6.IconVisible = False
        Me.BunifuFlatButton6.IconZoom = 90.0R
        Me.BunifuFlatButton6.IsTab = False
        Me.BunifuFlatButton6.Location = New System.Drawing.Point(3, 335)
        Me.BunifuFlatButton6.Name = "BunifuFlatButton6"
        Me.BunifuFlatButton6.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.OnHovercolor = System.Drawing.Color.Red
        Me.BunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton6.selected = False
        Me.BunifuFlatButton6.Size = New System.Drawing.Size(304, 34)
        Me.BunifuFlatButton6.TabIndex = 94
        Me.BunifuFlatButton6.Text = "Close"
        Me.BunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton6.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton6.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'NavigationPage8
        '
        Me.NavigationPage8.Controls.Add(Me.BunifuSeparator2)
        Me.NavigationPage8.Controls.Add(Me.Link1Count)
        Me.NavigationPage8.Controls.Add(Me.LinkVigor)
        Me.NavigationPage8.Controls.Add(Me.LinkReceiptHCP)
        Me.NavigationPage8.Controls.Add(Me.LinkReturnQC)
        Me.NavigationPage8.Controls.Add(Me.LinkGerminationTest)
        Me.NavigationPage8.Controls.Add(Me.LinkViability)
        Me.NavigationPage8.Controls.Add(Me.LinkRafactionTest)
        Me.NavigationPage8.Controls.Add(Me.LinkPurityTest)
        Me.NavigationPage8.Controls.Add(Me.LinkMoistureTest)
        Me.NavigationPage8.Name = "NavigationPage8"
        Me.NavigationPage8.Size = New System.Drawing.Size(723, 479)
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(47, 110)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(21, 23)
        Me.BunifuSeparator2.TabIndex = 110
        Me.BunifuSeparator2.TabStop = False
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'Link1Count
        '
        Me.Link1Count.AutoSize = True
        Me.Link1Count.BackColor = System.Drawing.Color.Transparent
        Me.Link1Count.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Link1Count.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.Link1Count.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.Link1Count.Location = New System.Drawing.Point(71, 110)
        Me.Link1Count.Name = "Link1Count"
        Me.Link1Count.Size = New System.Drawing.Size(180, 23)
        Me.Link1Count.TabIndex = 108
        Me.Link1Count.TabStop = False
        Me.Link1Count.Text = "Germination Vigor"
        Me.Link1Count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Link1Count.UseCustomBackColor = True
        Me.Link1Count.UseSelectable = True
        Me.Link1Count.UseStyleColors = True
        '
        'LinkVigor
        '
        Me.LinkVigor.AutoSize = True
        Me.LinkVigor.BackColor = System.Drawing.Color.Transparent
        Me.LinkVigor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkVigor.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.LinkVigor.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.LinkVigor.Location = New System.Drawing.Point(44, 139)
        Me.LinkVigor.Name = "LinkVigor"
        Me.LinkVigor.Size = New System.Drawing.Size(180, 23)
        Me.LinkVigor.TabIndex = 107
        Me.LinkVigor.TabStop = False
        Me.LinkVigor.Text = "Check out Germination"
        Me.LinkVigor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkVigor.UseCustomBackColor = True
        Me.LinkVigor.UseSelectable = True
        Me.LinkVigor.UseStyleColors = True
        '
        'LinkReceiptHCP
        '
        Me.LinkReceiptHCP.AutoSize = True
        Me.LinkReceiptHCP.BackColor = System.Drawing.Color.Transparent
        Me.LinkReceiptHCP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkReceiptHCP.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.LinkReceiptHCP.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.LinkReceiptHCP.Location = New System.Drawing.Point(491, 52)
        Me.LinkReceiptHCP.Name = "LinkReceiptHCP"
        Me.LinkReceiptHCP.Size = New System.Drawing.Size(180, 23)
        Me.LinkReceiptHCP.TabIndex = 106
        Me.LinkReceiptHCP.TabStop = False
        Me.LinkReceiptHCP.Text = "Return HCP"
        Me.LinkReceiptHCP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkReceiptHCP.UseCustomBackColor = True
        Me.LinkReceiptHCP.UseSelectable = True
        Me.LinkReceiptHCP.UseStyleColors = True
        '
        'LinkReturnQC
        '
        Me.LinkReturnQC.AutoSize = True
        Me.LinkReturnQC.BackColor = System.Drawing.Color.Transparent
        Me.LinkReturnQC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkReturnQC.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.LinkReturnQC.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.LinkReturnQC.Location = New System.Drawing.Point(491, 23)
        Me.LinkReturnQC.Name = "LinkReturnQC"
        Me.LinkReturnQC.Size = New System.Drawing.Size(180, 23)
        Me.LinkReturnQC.TabIndex = 104
        Me.LinkReturnQC.TabStop = False
        Me.LinkReturnQC.Text = "QC Check Out"
        Me.LinkReturnQC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkReturnQC.UseCustomBackColor = True
        Me.LinkReturnQC.UseSelectable = True
        Me.LinkReturnQC.UseStyleColors = True
        '
        'LinkGerminationTest
        '
        Me.LinkGerminationTest.AutoSize = True
        Me.LinkGerminationTest.BackColor = System.Drawing.Color.Transparent
        Me.LinkGerminationTest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkGerminationTest.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.LinkGerminationTest.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.LinkGerminationTest.Location = New System.Drawing.Point(44, 81)
        Me.LinkGerminationTest.Name = "LinkGerminationTest"
        Me.LinkGerminationTest.Size = New System.Drawing.Size(180, 23)
        Me.LinkGerminationTest.TabIndex = 105
        Me.LinkGerminationTest.TabStop = False
        Me.LinkGerminationTest.Text = "Germination Test"
        Me.LinkGerminationTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkGerminationTest.UseCustomBackColor = True
        Me.LinkGerminationTest.UseSelectable = True
        Me.LinkGerminationTest.UseStyleColors = True
        '
        'LinkViability
        '
        Me.LinkViability.AutoSize = True
        Me.LinkViability.BackColor = System.Drawing.Color.Transparent
        Me.LinkViability.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkViability.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.LinkViability.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.LinkViability.Location = New System.Drawing.Point(266, 52)
        Me.LinkViability.Name = "LinkViability"
        Me.LinkViability.Size = New System.Drawing.Size(180, 23)
        Me.LinkViability.TabIndex = 103
        Me.LinkViability.TabStop = False
        Me.LinkViability.Text = "Viability Test"
        Me.LinkViability.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkViability.UseCustomBackColor = True
        Me.LinkViability.UseSelectable = True
        Me.LinkViability.UseStyleColors = True
        '
        'LinkRafactionTest
        '
        Me.LinkRafactionTest.AutoSize = True
        Me.LinkRafactionTest.BackColor = System.Drawing.Color.Transparent
        Me.LinkRafactionTest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkRafactionTest.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.LinkRafactionTest.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.LinkRafactionTest.Location = New System.Drawing.Point(266, 23)
        Me.LinkRafactionTest.Name = "LinkRafactionTest"
        Me.LinkRafactionTest.Size = New System.Drawing.Size(180, 23)
        Me.LinkRafactionTest.TabIndex = 102
        Me.LinkRafactionTest.TabStop = False
        Me.LinkRafactionTest.Text = "Rafaction Test"
        Me.LinkRafactionTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkRafactionTest.UseCustomBackColor = True
        Me.LinkRafactionTest.UseSelectable = True
        Me.LinkRafactionTest.UseStyleColors = True
        '
        'LinkPurityTest
        '
        Me.LinkPurityTest.AutoSize = True
        Me.LinkPurityTest.BackColor = System.Drawing.Color.Transparent
        Me.LinkPurityTest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkPurityTest.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.LinkPurityTest.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.LinkPurityTest.Location = New System.Drawing.Point(44, 52)
        Me.LinkPurityTest.Name = "LinkPurityTest"
        Me.LinkPurityTest.Size = New System.Drawing.Size(180, 23)
        Me.LinkPurityTest.TabIndex = 101
        Me.LinkPurityTest.TabStop = False
        Me.LinkPurityTest.Text = "Purity Test"
        Me.LinkPurityTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkPurityTest.UseCustomBackColor = True
        Me.LinkPurityTest.UseSelectable = True
        Me.LinkPurityTest.UseStyleColors = True
        '
        'LinkMoistureTest
        '
        Me.LinkMoistureTest.AutoSize = True
        Me.LinkMoistureTest.BackColor = System.Drawing.Color.Transparent
        Me.LinkMoistureTest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkMoistureTest.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.LinkMoistureTest.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.LinkMoistureTest.Location = New System.Drawing.Point(44, 23)
        Me.LinkMoistureTest.Name = "LinkMoistureTest"
        Me.LinkMoistureTest.Size = New System.Drawing.Size(180, 23)
        Me.LinkMoistureTest.TabIndex = 100
        Me.LinkMoistureTest.TabStop = False
        Me.LinkMoistureTest.Text = "Moisture Test"
        Me.LinkMoistureTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkMoistureTest.UseCustomBackColor = True
        Me.LinkMoistureTest.UseSelectable = True
        Me.LinkMoistureTest.UseStyleColors = True
        '
        'NavigationPage9
        '
        Me.NavigationPage9.Controls.Add(Me.CheckInVigor1)
        Me.NavigationPage9.Controls.Add(Me.BunifuFlatButton10)
        Me.NavigationPage9.Name = "NavigationPage9"
        Me.NavigationPage9.Size = New System.Drawing.Size(723, 479)
        '
        'CheckInVigor1
        '
        Me.CheckInVigor1.Location = New System.Drawing.Point(3, 3)
        Me.CheckInVigor1.Name = "CheckInVigor1"
        Me.CheckInVigor1.Size = New System.Drawing.Size(319, 326)
        Me.CheckInVigor1.TabIndex = 96
        Me.CheckInVigor1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.CheckInVigor1.UseSelectable = True
        '
        'BunifuFlatButton10
        '
        Me.BunifuFlatButton10.Activecolor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuFlatButton10.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton10.BorderRadius = 0
        Me.BunifuFlatButton10.ButtonText = "Close"
        Me.BunifuFlatButton10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton10.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton10.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton10.Iconimage = Nothing
        Me.BunifuFlatButton10.Iconimage_right = Nothing
        Me.BunifuFlatButton10.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton10.Iconimage_Selected = Nothing
        Me.BunifuFlatButton10.IconMarginLeft = 0
        Me.BunifuFlatButton10.IconMarginRight = 0
        Me.BunifuFlatButton10.IconRightVisible = False
        Me.BunifuFlatButton10.IconRightZoom = 0R
        Me.BunifuFlatButton10.IconVisible = False
        Me.BunifuFlatButton10.IconZoom = 90.0R
        Me.BunifuFlatButton10.IsTab = False
        Me.BunifuFlatButton10.Location = New System.Drawing.Point(3, 335)
        Me.BunifuFlatButton10.Name = "BunifuFlatButton10"
        Me.BunifuFlatButton10.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton10.OnHovercolor = System.Drawing.Color.Red
        Me.BunifuFlatButton10.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton10.selected = False
        Me.BunifuFlatButton10.Size = New System.Drawing.Size(304, 34)
        Me.BunifuFlatButton10.TabIndex = 95
        Me.BunifuFlatButton10.Text = "Close"
        Me.BunifuFlatButton10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton10.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton10.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'NavigationPage11
        '
        Me.NavigationPage11.Controls.Add(Me.BunifuFlatButton11)
        Me.NavigationPage11.Controls.Add(Me.CheckIn1Count1)
        Me.NavigationPage11.Name = "NavigationPage11"
        Me.NavigationPage11.Size = New System.Drawing.Size(723, 479)
        '
        'BunifuFlatButton11
        '
        Me.BunifuFlatButton11.Activecolor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuFlatButton11.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton11.BorderRadius = 0
        Me.BunifuFlatButton11.ButtonText = "Close"
        Me.BunifuFlatButton11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton11.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton11.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton11.Iconimage = Nothing
        Me.BunifuFlatButton11.Iconimage_right = Nothing
        Me.BunifuFlatButton11.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton11.Iconimage_Selected = Nothing
        Me.BunifuFlatButton11.IconMarginLeft = 0
        Me.BunifuFlatButton11.IconMarginRight = 0
        Me.BunifuFlatButton11.IconRightVisible = False
        Me.BunifuFlatButton11.IconRightZoom = 0R
        Me.BunifuFlatButton11.IconVisible = False
        Me.BunifuFlatButton11.IconZoom = 90.0R
        Me.BunifuFlatButton11.IsTab = False
        Me.BunifuFlatButton11.Location = New System.Drawing.Point(3, 335)
        Me.BunifuFlatButton11.Name = "BunifuFlatButton11"
        Me.BunifuFlatButton11.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton11.OnHovercolor = System.Drawing.Color.Red
        Me.BunifuFlatButton11.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton11.selected = False
        Me.BunifuFlatButton11.Size = New System.Drawing.Size(304, 34)
        Me.BunifuFlatButton11.TabIndex = 96
        Me.BunifuFlatButton11.Text = "Close"
        Me.BunifuFlatButton11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton11.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton11.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'CheckIn1Count1
        '
        Me.CheckIn1Count1.Location = New System.Drawing.Point(3, 3)
        Me.CheckIn1Count1.Name = "CheckIn1Count1"
        Me.CheckIn1Count1.Size = New System.Drawing.Size(319, 326)
        Me.CheckIn1Count1.TabIndex = 0
        Me.CheckIn1Count1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.CheckIn1Count1.UseSelectable = True
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        Me.MetroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'BunifuFlatButton8
        '
        Me.BunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuFlatButton8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuFlatButton8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton8.BorderRadius = 0
        Me.BunifuFlatButton8.ButtonText = "Close"
        Me.BunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton8.Iconimage = Nothing
        Me.BunifuFlatButton8.Iconimage_right = Nothing
        Me.BunifuFlatButton8.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton8.Iconimage_Selected = Nothing
        Me.BunifuFlatButton8.IconMarginLeft = 0
        Me.BunifuFlatButton8.IconMarginRight = 0
        Me.BunifuFlatButton8.IconRightVisible = False
        Me.BunifuFlatButton8.IconRightZoom = 0R
        Me.BunifuFlatButton8.IconVisible = False
        Me.BunifuFlatButton8.IconZoom = 90.0R
        Me.BunifuFlatButton8.IsTab = False
        Me.BunifuFlatButton8.Location = New System.Drawing.Point(3, 330)
        Me.BunifuFlatButton8.Name = "BunifuFlatButton8"
        Me.BunifuFlatButton8.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton8.OnHovercolor = System.Drawing.Color.Red
        Me.BunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton8.selected = False
        Me.BunifuFlatButton8.Size = New System.Drawing.Size(304, 34)
        Me.BunifuFlatButton8.TabIndex = 95
        Me.BunifuFlatButton8.Text = "Close"
        Me.BunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton8.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton8.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'NavigationPage10
        '
        Me.NavigationPage10.Caption = "NavigationPage10"
        Me.NavigationPage10.Name = "NavigationPage10"
        Me.NavigationPage10.Size = New System.Drawing.Size(723, 479)
        '
        'Check_in_Sample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.NavigationFrame1)
        Me.DoubleBuffered = True
        Me.Name = "Check_in_Sample"
        Me.Size = New System.Drawing.Size(723, 479)
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.UseStyleColors = True
        CType(Me.NavigationFrame1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationFrame1.ResumeLayout(False)
        Me.NavigationPage3.ResumeLayout(False)
        Me.NavigationPage4.ResumeLayout(False)
        Me.NavigationPage1.ResumeLayout(False)
        Me.NavigationPage2.ResumeLayout(False)
        Me.NavigationPage5.ResumeLayout(False)
        Me.NavigationPage6.ResumeLayout(False)
        Me.NavigationPage7.ResumeLayout(False)
        Me.NavigationPage8.ResumeLayout(False)
        Me.NavigationPage8.PerformLayout()
        Me.NavigationPage9.ResumeLayout(False)
        Me.NavigationPage11.ResumeLayout(False)
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroStyleExtender1 As Components.MetroStyleExtender
    Friend WithEvents MetroStyleManager1 As Components.MetroStyleManager
    Friend WithEvents NavigationFrame1 As DevExpress.XtraBars.Navigation.NavigationFrame
    Friend WithEvents NavigationPage3 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage4 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage5 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage6 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage7 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage8 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents LinkReceiptHCP As MetroLink
    Friend WithEvents LinkReturnQC As MetroLink
    Friend WithEvents LinkGerminationTest As MetroLink
    Friend WithEvents LinkViability As MetroLink
    Friend WithEvents LinkRafactionTest As MetroLink
    Friend WithEvents LinkPurityTest As MetroLink
    Friend WithEvents LinkMoistureTest As MetroLink
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton6 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton7 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents CheckInVia1 As CheckInVia
    Friend WithEvents CheckInPur1 As CheckInPur
    Friend WithEvents CheckInKa1 As CheckInKa
    Friend WithEvents CheckInRaf1 As CheckInRaf
    Friend WithEvents CheckInGer1 As CheckInGer
    Friend WithEvents CheckOutQC1 As CheckOutQC
    Friend WithEvents CheckReturnHCP1 As CheckReturnHCP
    Friend WithEvents LinkVigor As MetroLink
    Friend WithEvents BunifuFlatButton8 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents NavigationPage9 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents BunifuFlatButton10 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents CheckInVigor1 As CheckInVigor
    Friend WithEvents Link1Count As MetroLink
    Friend WithEvents NavigationPage10 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage11 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents BunifuFlatButton11 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents CheckIn1Count1 As CheckIn1Count
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
End Class
