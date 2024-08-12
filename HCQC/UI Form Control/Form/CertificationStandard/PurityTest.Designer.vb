<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PurityTest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PurityTest))
        Me.BtnFind = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tlabnum = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.tidbalance = New MetroFramework.Controls.MetroTextBox()
        Me.tpsdnum = New MetroFramework.Controls.MetroTextBox()
        Me.twork = New MetroFramework.Controls.MetroTextBox()
        Me.tpure = New MetroFramework.Controls.MetroTextBox()
        Me.tother = New MetroFramework.Controls.MetroTextBox()
        Me.tinert = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.tkindother = New MetroFramework.Controls.MetroTextBox()
        Me.tkindinert = New MetroFramework.Controls.MetroTextBox()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.ttgldate = New System.Windows.Forms.MaskedTextBox()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.BtnUpdate = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnDel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.tanalyst = New MetroFramework.Controls.MetroTextBox()
        Me.LPure = New MetroFramework.Controls.MetroLabel()
        Me.Lother = New MetroFramework.Controls.MetroLabel()
        Me.Linert = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.LToleransi = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.tpurnotpass = New MetroFramework.Controls.MetroRadioButton()
        Me.tpurpass = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel20 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.tremark = New MetroFramework.Controls.MetroTextBox()
        Me.t1thseed = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.Lreqnum = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.tscope = New MetroFramework.Controls.MetroLabel()
        Me.tlotref = New MetroFramework.Controls.MetroLabel()
        Me.tnoman = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel21 = New MetroFramework.Controls.MetroLabel()
        Me.tvariety = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel22 = New MetroFramework.Controls.MetroLabel()
        Me.LabelDate1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        CType(Me.BtnFind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnFind
        '
        Me.BtnFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.ImageActive = Nothing
        Me.BtnFind.Location = New System.Drawing.Point(304, 10)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(38, 23)
        Me.BtnFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnFind.TabIndex = 64
        Me.BtnFind.TabStop = False
        Me.BtnFind.Zoom = 10
        '
        'tlabnum
        '
        Me.tlabnum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.tlabnum.CustomButton.Image = Nothing
        Me.tlabnum.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.tlabnum.CustomButton.Name = ""
        Me.tlabnum.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tlabnum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tlabnum.CustomButton.TabIndex = 1
        Me.tlabnum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tlabnum.CustomButton.UseSelectable = True
        Me.tlabnum.CustomButton.Visible = False
        Me.tlabnum.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tlabnum.Lines = New String(-1) {}
        Me.tlabnum.Location = New System.Drawing.Point(140, 10)
        Me.tlabnum.MaxLength = 32767
        Me.tlabnum.Name = "tlabnum"
        Me.tlabnum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tlabnum.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tlabnum.SelectedText = ""
        Me.tlabnum.SelectionLength = 0
        Me.tlabnum.SelectionStart = 0
        Me.tlabnum.ShortcutsEnabled = True
        Me.tlabnum.Size = New System.Drawing.Size(158, 23)
        Me.tlabnum.TabIndex = 61
        Me.tlabnum.UseSelectable = True
        Me.tlabnum.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tlabnum.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(49, 14)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(85, 19)
        Me.MetroLabel1.TabIndex = 58
        Me.MetroLabel1.Text = "Lab Number"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(64, 119)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel4.TabIndex = 65
        Me.MetroLabel4.Text = "Balance ID"
        Me.MetroLabel4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(48, 148)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel5.TabIndex = 66
        Me.MetroLabel5.Text = "PSD Number"
        Me.MetroLabel5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(8, 184)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(126, 19)
        Me.MetroLabel6.TabIndex = 67
        Me.MetroLabel6.Text = "Working Sample (g)"
        Me.MetroLabel6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(45, 217)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel7.TabIndex = 68
        Me.MetroLabel7.Text = "Pure Seed (g)"
        Me.MetroLabel7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(38, 246)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(96, 19)
        Me.MetroLabel8.TabIndex = 69
        Me.MetroLabel8.Text = "Other Seed (g)"
        Me.MetroLabel8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(35, 275)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(99, 19)
        Me.MetroLabel9.TabIndex = 70
        Me.MetroLabel9.Text = "Inert Metter (g)"
        Me.MetroLabel9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tidbalance
        '
        '
        '
        '
        Me.tidbalance.CustomButton.Image = Nothing
        Me.tidbalance.CustomButton.Location = New System.Drawing.Point(142, 1)
        Me.tidbalance.CustomButton.Name = ""
        Me.tidbalance.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tidbalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tidbalance.CustomButton.TabIndex = 1
        Me.tidbalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tidbalance.CustomButton.UseSelectable = True
        Me.tidbalance.CustomButton.Visible = False
        Me.tidbalance.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tidbalance.Lines = New String(-1) {}
        Me.tidbalance.Location = New System.Drawing.Point(140, 115)
        Me.tidbalance.MaxLength = 32767
        Me.tidbalance.Name = "tidbalance"
        Me.tidbalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tidbalance.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tidbalance.SelectedText = ""
        Me.tidbalance.SelectionLength = 0
        Me.tidbalance.SelectionStart = 0
        Me.tidbalance.ShortcutsEnabled = True
        Me.tidbalance.Size = New System.Drawing.Size(164, 23)
        Me.tidbalance.TabIndex = 71
        Me.tidbalance.UseSelectable = True
        Me.tidbalance.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tidbalance.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tpsdnum
        '
        '
        '
        '
        Me.tpsdnum.CustomButton.Image = Nothing
        Me.tpsdnum.CustomButton.Location = New System.Drawing.Point(76, 1)
        Me.tpsdnum.CustomButton.Name = ""
        Me.tpsdnum.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tpsdnum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tpsdnum.CustomButton.TabIndex = 1
        Me.tpsdnum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tpsdnum.CustomButton.UseSelectable = True
        Me.tpsdnum.CustomButton.Visible = False
        Me.tpsdnum.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tpsdnum.Lines = New String(-1) {}
        Me.tpsdnum.Location = New System.Drawing.Point(140, 144)
        Me.tpsdnum.MaxLength = 32767
        Me.tpsdnum.Name = "tpsdnum"
        Me.tpsdnum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tpsdnum.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tpsdnum.SelectedText = ""
        Me.tpsdnum.SelectionLength = 0
        Me.tpsdnum.SelectionStart = 0
        Me.tpsdnum.ShortcutsEnabled = True
        Me.tpsdnum.Size = New System.Drawing.Size(98, 23)
        Me.tpsdnum.TabIndex = 72
        Me.tpsdnum.UseSelectable = True
        Me.tpsdnum.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tpsdnum.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'twork
        '
        '
        '
        '
        Me.twork.CustomButton.Image = Nothing
        Me.twork.CustomButton.Location = New System.Drawing.Point(76, 1)
        Me.twork.CustomButton.Name = ""
        Me.twork.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.twork.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.twork.CustomButton.TabIndex = 1
        Me.twork.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.twork.CustomButton.UseSelectable = True
        Me.twork.CustomButton.Visible = False
        Me.twork.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.twork.Lines = New String(-1) {}
        Me.twork.Location = New System.Drawing.Point(140, 184)
        Me.twork.MaxLength = 32767
        Me.twork.Name = "twork"
        Me.twork.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.twork.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.twork.SelectedText = ""
        Me.twork.SelectionLength = 0
        Me.twork.SelectionStart = 0
        Me.twork.ShortcutsEnabled = True
        Me.twork.Size = New System.Drawing.Size(98, 23)
        Me.twork.TabIndex = 73
        Me.twork.UseSelectable = True
        Me.twork.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.twork.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tpure
        '
        '
        '
        '
        Me.tpure.CustomButton.Image = Nothing
        Me.tpure.CustomButton.Location = New System.Drawing.Point(76, 1)
        Me.tpure.CustomButton.Name = ""
        Me.tpure.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tpure.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tpure.CustomButton.TabIndex = 1
        Me.tpure.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tpure.CustomButton.UseSelectable = True
        Me.tpure.CustomButton.Visible = False
        Me.tpure.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tpure.Lines = New String(-1) {}
        Me.tpure.Location = New System.Drawing.Point(140, 213)
        Me.tpure.MaxLength = 32767
        Me.tpure.Name = "tpure"
        Me.tpure.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tpure.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tpure.SelectedText = ""
        Me.tpure.SelectionLength = 0
        Me.tpure.SelectionStart = 0
        Me.tpure.ShortcutsEnabled = True
        Me.tpure.Size = New System.Drawing.Size(98, 23)
        Me.tpure.TabIndex = 74
        Me.tpure.UseSelectable = True
        Me.tpure.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tpure.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tother
        '
        '
        '
        '
        Me.tother.CustomButton.Image = Nothing
        Me.tother.CustomButton.Location = New System.Drawing.Point(76, 1)
        Me.tother.CustomButton.Name = ""
        Me.tother.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tother.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tother.CustomButton.TabIndex = 1
        Me.tother.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tother.CustomButton.UseSelectable = True
        Me.tother.CustomButton.Visible = False
        Me.tother.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tother.Lines = New String(-1) {}
        Me.tother.Location = New System.Drawing.Point(140, 242)
        Me.tother.MaxLength = 32767
        Me.tother.Name = "tother"
        Me.tother.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tother.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tother.SelectedText = ""
        Me.tother.SelectionLength = 0
        Me.tother.SelectionStart = 0
        Me.tother.ShortcutsEnabled = True
        Me.tother.Size = New System.Drawing.Size(98, 23)
        Me.tother.TabIndex = 75
        Me.tother.UseSelectable = True
        Me.tother.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tother.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tinert
        '
        '
        '
        '
        Me.tinert.CustomButton.Image = Nothing
        Me.tinert.CustomButton.Location = New System.Drawing.Point(76, 1)
        Me.tinert.CustomButton.Name = ""
        Me.tinert.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tinert.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tinert.CustomButton.TabIndex = 1
        Me.tinert.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tinert.CustomButton.UseSelectable = True
        Me.tinert.CustomButton.Visible = False
        Me.tinert.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tinert.Lines = New String(-1) {}
        Me.tinert.Location = New System.Drawing.Point(140, 271)
        Me.tinert.MaxLength = 32767
        Me.tinert.Name = "tinert"
        Me.tinert.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tinert.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tinert.SelectedText = ""
        Me.tinert.SelectionLength = 0
        Me.tinert.SelectionStart = 0
        Me.tinert.ShortcutsEnabled = True
        Me.tinert.Size = New System.Drawing.Size(98, 23)
        Me.tinert.TabIndex = 76
        Me.tinert.UseSelectable = True
        Me.tinert.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tinert.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(8, 344)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(126, 19)
        Me.MetroLabel10.TabIndex = 77
        Me.MetroLabel10.Text = "Kind of Other Seeds"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(10, 373)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(124, 19)
        Me.MetroLabel11.TabIndex = 78
        Me.MetroLabel11.Text = "Kind of Inert Matter"
        '
        'tkindother
        '
        '
        '
        '
        Me.tkindother.CustomButton.Image = Nothing
        Me.tkindother.CustomButton.Location = New System.Drawing.Point(142, 1)
        Me.tkindother.CustomButton.Name = ""
        Me.tkindother.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tkindother.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tkindother.CustomButton.TabIndex = 1
        Me.tkindother.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tkindother.CustomButton.UseSelectable = True
        Me.tkindother.CustomButton.Visible = False
        Me.tkindother.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tkindother.Lines = New String(-1) {}
        Me.tkindother.Location = New System.Drawing.Point(140, 340)
        Me.tkindother.MaxLength = 32767
        Me.tkindother.Name = "tkindother"
        Me.tkindother.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tkindother.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tkindother.SelectedText = ""
        Me.tkindother.SelectionLength = 0
        Me.tkindother.SelectionStart = 0
        Me.tkindother.ShortcutsEnabled = True
        Me.tkindother.Size = New System.Drawing.Size(164, 23)
        Me.tkindother.TabIndex = 80
        Me.tkindother.UseSelectable = True
        Me.tkindother.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tkindother.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tkindinert
        '
        '
        '
        '
        Me.tkindinert.CustomButton.Image = Nothing
        Me.tkindinert.CustomButton.Location = New System.Drawing.Point(142, 1)
        Me.tkindinert.CustomButton.Name = ""
        Me.tkindinert.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tkindinert.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tkindinert.CustomButton.TabIndex = 1
        Me.tkindinert.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tkindinert.CustomButton.UseSelectable = True
        Me.tkindinert.CustomButton.Visible = False
        Me.tkindinert.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tkindinert.Lines = New String(-1) {}
        Me.tkindinert.Location = New System.Drawing.Point(140, 369)
        Me.tkindinert.MaxLength = 32767
        Me.tkindinert.Name = "tkindinert"
        Me.tkindinert.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tkindinert.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tkindinert.SelectedText = ""
        Me.tkindinert.SelectionLength = 0
        Me.tkindinert.SelectionStart = 0
        Me.tkindinert.ShortcutsEnabled = True
        Me.tkindinert.Size = New System.Drawing.Size(164, 23)
        Me.tkindinert.TabIndex = 81
        Me.tkindinert.UseSelectable = True
        Me.tkindinert.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tkindinert.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel2.Controls.Add(Me.ttgldate)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(140, 300)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.MetroPanel2.Size = New System.Drawing.Size(123, 23)
        Me.MetroPanel2.TabIndex = 77
        Me.MetroPanel2.UseStyleColors = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'ttgldate
        '
        Me.ttgldate.BackColor = System.Drawing.Color.Black
        Me.ttgldate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ttgldate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ttgldate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttgldate.ForeColor = System.Drawing.Color.White
        Me.ttgldate.Location = New System.Drawing.Point(1, 1)
        Me.ttgldate.Mask = "00/00/0000"
        Me.ttgldate.Name = "ttgldate"
        Me.ttgldate.Size = New System.Drawing.Size(119, 18)
        Me.ttgldate.TabIndex = 31
        Me.ttgldate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttgldate.ValidatingType = GetType(Date)
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel13.Location = New System.Drawing.Point(68, 304)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel13.TabIndex = 82
        Me.MetroLabel13.Text = "Test Date"
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUpdate.BorderRadius = 0
        Me.BtnUpdate.ButtonText = "Update"
        Me.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdate.DisabledColor = System.Drawing.Color.Gray
        Me.BtnUpdate.Enabled = False
        Me.BtnUpdate.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnUpdate.Iconimage = CType(resources.GetObject("BtnUpdate.Iconimage"), System.Drawing.Image)
        Me.BtnUpdate.Iconimage_right = Nothing
        Me.BtnUpdate.Iconimage_right_Selected = Nothing
        Me.BtnUpdate.Iconimage_Selected = Nothing
        Me.BtnUpdate.IconMarginLeft = 0
        Me.BtnUpdate.IconMarginRight = 0
        Me.BtnUpdate.IconRightVisible = True
        Me.BtnUpdate.IconRightZoom = 0R
        Me.BtnUpdate.IconVisible = True
        Me.BtnUpdate.IconZoom = 90.0R
        Me.BtnUpdate.IsTab = False
        Me.BtnUpdate.Location = New System.Drawing.Point(242, 461)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnUpdate.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnUpdate.selected = True
        Me.BtnUpdate.Size = New System.Drawing.Size(100, 34)
        Me.BtnUpdate.TabIndex = 87
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Textcolor = System.Drawing.Color.White
        Me.BtnUpdate.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnDel
        '
        Me.BtnDel.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDel.BorderRadius = 0
        Me.BtnDel.ButtonText = "Delete"
        Me.BtnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDel.DisabledColor = System.Drawing.Color.Gray
        Me.BtnDel.Enabled = False
        Me.BtnDel.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnDel.Iconimage = CType(resources.GetObject("BtnDel.Iconimage"), System.Drawing.Image)
        Me.BtnDel.Iconimage_right = Nothing
        Me.BtnDel.Iconimage_right_Selected = Nothing
        Me.BtnDel.Iconimage_Selected = Nothing
        Me.BtnDel.IconMarginLeft = 0
        Me.BtnDel.IconMarginRight = 0
        Me.BtnDel.IconRightVisible = True
        Me.BtnDel.IconRightZoom = 0R
        Me.BtnDel.IconVisible = True
        Me.BtnDel.IconZoom = 90.0R
        Me.BtnDel.IsTab = False
        Me.BtnDel.Location = New System.Drawing.Point(348, 461)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnDel.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnDel.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnDel.selected = True
        Me.BtnDel.Size = New System.Drawing.Size(100, 34)
        Me.BtnDel.TabIndex = 88
        Me.BtnDel.Text = "Delete"
        Me.BtnDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDel.Textcolor = System.Drawing.Color.White
        Me.BtnDel.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnSave
        '
        Me.BtnSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
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
        Me.BtnSave.IconZoom = 90.0R
        Me.BtnSave.IsTab = False
        Me.BtnSave.Location = New System.Drawing.Point(8, 461)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSave.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnSave.selected = True
        Me.BtnSave.Size = New System.Drawing.Size(206, 34)
        Me.BtnSave.TabIndex = 86
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Textcolor = System.Drawing.Color.White
        Me.BtnSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(84, 402)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel12.TabIndex = 78
        Me.MetroLabel12.Text = "Analyst"
        '
        'tanalyst
        '
        '
        '
        '
        Me.tanalyst.CustomButton.Image = Nothing
        Me.tanalyst.CustomButton.Location = New System.Drawing.Point(101, 1)
        Me.tanalyst.CustomButton.Name = ""
        Me.tanalyst.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tanalyst.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tanalyst.CustomButton.TabIndex = 1
        Me.tanalyst.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tanalyst.CustomButton.UseSelectable = True
        Me.tanalyst.CustomButton.Visible = False
        Me.tanalyst.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tanalyst.Lines = New String(-1) {}
        Me.tanalyst.Location = New System.Drawing.Point(140, 398)
        Me.tanalyst.MaxLength = 32767
        Me.tanalyst.Name = "tanalyst"
        Me.tanalyst.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tanalyst.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tanalyst.SelectedText = ""
        Me.tanalyst.SelectionLength = 0
        Me.tanalyst.SelectionStart = 0
        Me.tanalyst.ShortcutsEnabled = True
        Me.tanalyst.Size = New System.Drawing.Size(123, 23)
        Me.tanalyst.TabIndex = 82
        Me.tanalyst.UseSelectable = True
        Me.tanalyst.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tanalyst.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'LPure
        '
        Me.LPure.AutoSize = True
        Me.LPure.Location = New System.Drawing.Point(254, 217)
        Me.LPure.Name = "LPure"
        Me.LPure.Size = New System.Drawing.Size(0, 0)
        Me.LPure.TabIndex = 68
        Me.LPure.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Lother
        '
        Me.Lother.AutoSize = True
        Me.Lother.Location = New System.Drawing.Point(254, 246)
        Me.Lother.Name = "Lother"
        Me.Lother.Size = New System.Drawing.Size(0, 0)
        Me.Lother.TabIndex = 69
        Me.Lother.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Linert
        '
        Me.Linert.AutoSize = True
        Me.Linert.Location = New System.Drawing.Point(254, 275)
        Me.Linert.Name = "Linert"
        Me.Linert.Size = New System.Drawing.Size(0, 0)
        Me.Linert.TabIndex = 70
        Me.Linert.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroPanel1.AutoScroll = True
        Me.MetroPanel1.Controls.Add(Me.LToleransi)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel14)
        Me.MetroPanel1.Controls.Add(Me.tpurnotpass)
        Me.MetroPanel1.Controls.Add(Me.tpurpass)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel20)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel1.Controls.Add(Me.tremark)
        Me.MetroPanel1.Controls.Add(Me.t1thseed)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel19)
        Me.MetroPanel1.Controls.Add(Me.Lreqnum)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel16)
        Me.MetroPanel1.Controls.Add(Me.tscope)
        Me.MetroPanel1.Controls.Add(Me.tlotref)
        Me.MetroPanel1.Controls.Add(Me.tnoman)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel21)
        Me.MetroPanel1.Controls.Add(Me.tvariety)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel22)
        Me.MetroPanel1.Controls.Add(Me.BtnDel)
        Me.MetroPanel1.Controls.Add(Me.BtnUpdate)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.Controls.Add(Me.BtnSave)
        Me.MetroPanel1.Controls.Add(Me.MetroPanel2)
        Me.MetroPanel1.Controls.Add(Me.LabelDate1)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel13)
        Me.MetroPanel1.Controls.Add(Me.tlabnum)
        Me.MetroPanel1.Controls.Add(Me.tanalyst)
        Me.MetroPanel1.Controls.Add(Me.tkindinert)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel12)
        Me.MetroPanel1.Controls.Add(Me.tkindother)
        Me.MetroPanel1.Controls.Add(Me.BtnFind)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel11)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel10)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel1.Controls.Add(Me.tinert)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel6)
        Me.MetroPanel1.Controls.Add(Me.tother)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel7)
        Me.MetroPanel1.Controls.Add(Me.tpure)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel8)
        Me.MetroPanel1.Controls.Add(Me.twork)
        Me.MetroPanel1.Controls.Add(Me.LPure)
        Me.MetroPanel1.Controls.Add(Me.tpsdnum)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel9)
        Me.MetroPanel1.Controls.Add(Me.tidbalance)
        Me.MetroPanel1.Controls.Add(Me.Lother)
        Me.MetroPanel1.Controls.Add(Me.Linert)
        Me.MetroPanel1.HorizontalScrollbar = True
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(6, 6)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(503, 498)
        Me.MetroPanel1.TabIndex = 89
        Me.MetroPanel1.VerticalScrollbar = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'LToleransi
        '
        Me.LToleransi.AutoSize = True
        Me.LToleransi.Location = New System.Drawing.Point(356, 242)
        Me.LToleransi.Name = "LToleransi"
        Me.LToleransi.Size = New System.Drawing.Size(27, 19)
        Me.LToleransi.TabIndex = 268
        Me.LToleransi.Text = "0%"
        Me.LToleransi.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel14.Location = New System.Drawing.Point(356, 217)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(113, 19)
        Me.MetroLabel14.TabIndex = 267
        Me.MetroLabel14.Text = "Tolerace (fp/fk)"
        Me.MetroLabel14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tpurnotpass
        '
        Me.tpurnotpass.AutoSize = True
        Me.tpurnotpass.Location = New System.Drawing.Point(364, 383)
        Me.tpurnotpass.Name = "tpurnotpass"
        Me.tpurnotpass.Size = New System.Drawing.Size(69, 15)
        Me.tpurnotpass.TabIndex = 266
        Me.tpurnotpass.TabStop = True
        Me.tpurnotpass.Text = "Not Pass"
        Me.tpurnotpass.UseSelectable = True
        '
        'tpurpass
        '
        Me.tpurpass.AutoSize = True
        Me.tpurpass.Location = New System.Drawing.Point(364, 362)
        Me.tpurpass.Name = "tpurpass"
        Me.tpurpass.Size = New System.Drawing.Size(46, 15)
        Me.tpurpass.TabIndex = 265
        Me.tpurpass.TabStop = True
        Me.tpurpass.Text = "Pass"
        Me.tpurpass.UseSelectable = True
        '
        'MetroLabel20
        '
        Me.MetroLabel20.AutoSize = True
        Me.MetroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel20.Location = New System.Drawing.Point(356, 340)
        Me.MetroLabel20.Name = "MetroLabel20"
        Me.MetroLabel20.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel20.TabIndex = 264
        Me.MetroLabel20.Text = "Raf Result"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(84, 430)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(54, 19)
        Me.MetroLabel3.TabIndex = 263
        Me.MetroLabel3.Text = "Remark"
        '
        'tremark
        '
        '
        '
        '
        Me.tremark.CustomButton.Image = Nothing
        Me.tremark.CustomButton.Location = New System.Drawing.Point(142, 1)
        Me.tremark.CustomButton.Name = ""
        Me.tremark.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tremark.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tremark.CustomButton.TabIndex = 1
        Me.tremark.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tremark.CustomButton.UseSelectable = True
        Me.tremark.CustomButton.Visible = False
        Me.tremark.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tremark.Lines = New String(-1) {}
        Me.tremark.Location = New System.Drawing.Point(140, 426)
        Me.tremark.MaxLength = 32767
        Me.tremark.Name = "tremark"
        Me.tremark.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tremark.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tremark.SelectedText = ""
        Me.tremark.SelectionLength = 0
        Me.tremark.SelectionStart = 0
        Me.tremark.ShortcutsEnabled = True
        Me.tremark.Size = New System.Drawing.Size(164, 23)
        Me.tremark.TabIndex = 83
        Me.tremark.UseSelectable = True
        Me.tremark.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tremark.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        't1thseed
        '
        '
        '
        '
        Me.t1thseed.CustomButton.Image = Nothing
        Me.t1thseed.CustomButton.Location = New System.Drawing.Point(72, 1)
        Me.t1thseed.CustomButton.Name = ""
        Me.t1thseed.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.t1thseed.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.t1thseed.CustomButton.TabIndex = 1
        Me.t1thseed.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.t1thseed.CustomButton.UseSelectable = True
        Me.t1thseed.CustomButton.Visible = False
        Me.t1thseed.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.t1thseed.Lines = New String(-1) {}
        Me.t1thseed.Location = New System.Drawing.Point(356, 184)
        Me.t1thseed.MaxLength = 32767
        Me.t1thseed.Name = "t1thseed"
        Me.t1thseed.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.t1thseed.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.t1thseed.SelectedText = ""
        Me.t1thseed.SelectionLength = 0
        Me.t1thseed.SelectionStart = 0
        Me.t1thseed.ShortcutsEnabled = True
        Me.t1thseed.Size = New System.Drawing.Size(94, 23)
        Me.t1thseed.TabIndex = 77
        Me.t1thseed.UseSelectable = True
        Me.t1thseed.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.t1thseed.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel19.Location = New System.Drawing.Point(356, 162)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(94, 19)
        Me.MetroLabel19.TabIndex = 261
        Me.MetroLabel19.Text = "1000 Seed (g)"
        '
        'Lreqnum
        '
        Me.Lreqnum.AutoSize = True
        Me.Lreqnum.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Lreqnum.ForeColor = System.Drawing.Color.White
        Me.Lreqnum.Location = New System.Drawing.Point(355, 72)
        Me.Lreqnum.Name = "Lreqnum"
        Me.Lreqnum.Size = New System.Drawing.Size(21, 19)
        Me.Lreqnum.TabIndex = 259
        Me.Lreqnum.Text = "..."
        Me.Lreqnum.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Lreqnum.UseCustomForeColor = True
        Me.Lreqnum.Visible = False
        '
        'MetroLabel2
        '
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.MetroLabel2.Location = New System.Drawing.Point(32, 53)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(102, 15)
        Me.MetroLabel2.TabIndex = 260
        Me.MetroLabel2.Text = "Scope"
        Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.MetroLabel16.Location = New System.Drawing.Point(355, 53)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(93, 15)
        Me.MetroLabel16.TabIndex = 260
        Me.MetroLabel16.Text = "Request Number"
        Me.MetroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel16.Visible = False
        '
        'tscope
        '
        Me.tscope.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.tscope.ForeColor = System.Drawing.Color.White
        Me.tscope.Location = New System.Drawing.Point(32, 72)
        Me.tscope.Name = "tscope"
        Me.tscope.Size = New System.Drawing.Size(102, 19)
        Me.tscope.TabIndex = 253
        Me.tscope.Text = "..."
        Me.tscope.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.tscope.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tscope.UseCustomForeColor = True
        '
        'tlotref
        '
        Me.tlotref.AutoSize = True
        Me.tlotref.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.tlotref.ForeColor = System.Drawing.Color.White
        Me.tlotref.Location = New System.Drawing.Point(276, 72)
        Me.tlotref.Name = "tlotref"
        Me.tlotref.Size = New System.Drawing.Size(21, 19)
        Me.tlotref.TabIndex = 256
        Me.tlotref.Text = "..."
        Me.tlotref.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tlotref.UseCustomForeColor = True
        '
        'tnoman
        '
        Me.tnoman.AutoSize = True
        Me.tnoman.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.tnoman.ForeColor = System.Drawing.Color.White
        Me.tnoman.Location = New System.Drawing.Point(225, 72)
        Me.tnoman.Name = "tnoman"
        Me.tnoman.Size = New System.Drawing.Size(21, 19)
        Me.tnoman.TabIndex = 257
        Me.tnoman.Text = "..."
        Me.tnoman.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tnoman.UseCustomForeColor = True
        '
        'MetroLabel21
        '
        Me.MetroLabel21.AutoSize = True
        Me.MetroLabel21.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel21.Location = New System.Drawing.Point(225, 53)
        Me.MetroLabel21.Name = "MetroLabel21"
        Me.MetroLabel21.Size = New System.Drawing.Size(93, 15)
        Me.MetroLabel21.TabIndex = 258
        Me.MetroLabel21.Text = "Manual    Lot/Job"
        Me.MetroLabel21.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'tvariety
        '
        Me.tvariety.AutoSize = True
        Me.tvariety.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.tvariety.ForeColor = System.Drawing.Color.White
        Me.tvariety.Location = New System.Drawing.Point(140, 72)
        Me.tvariety.Name = "tvariety"
        Me.tvariety.Size = New System.Drawing.Size(21, 19)
        Me.tvariety.TabIndex = 254
        Me.tvariety.Text = "..."
        Me.tvariety.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tvariety.UseCustomForeColor = True
        '
        'MetroLabel22
        '
        Me.MetroLabel22.AutoSize = True
        Me.MetroLabel22.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel22.Location = New System.Drawing.Point(140, 53)
        Me.MetroLabel22.Name = "MetroLabel22"
        Me.MetroLabel22.Size = New System.Drawing.Size(40, 15)
        Me.MetroLabel22.TabIndex = 255
        Me.MetroLabel22.Text = "Variety"
        Me.MetroLabel22.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'LabelDate1
        '
        Me.LabelDate1.AutoSize = True
        Me.LabelDate1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelDate1.Location = New System.Drawing.Point(269, 305)
        Me.LabelDate1.Name = "LabelDate1"
        Me.LabelDate1.Size = New System.Drawing.Size(71, 15)
        Me.LabelDate1.TabIndex = 82
        Me.LabelDate1.Text = "dd-MM-yyyy"
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        Me.MetroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'PurityTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroPanel1)
        Me.Name = "PurityTest"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(509, 510)
        CType(Me.BtnFind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnFind As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents tlabnum As MetroTextBox
    Friend WithEvents MetroLabel1 As MetroLabel
    Friend WithEvents MetroLabel4 As MetroLabel
    Friend WithEvents MetroLabel5 As MetroLabel
    Friend WithEvents MetroLabel6 As MetroLabel
    Friend WithEvents MetroLabel7 As MetroLabel
    Friend WithEvents MetroLabel8 As MetroLabel
    Friend WithEvents MetroLabel9 As MetroLabel
    Friend WithEvents tidbalance As MetroTextBox
    Friend WithEvents tpsdnum As MetroTextBox
    Friend WithEvents twork As MetroTextBox
    Friend WithEvents tpure As MetroTextBox
    Friend WithEvents tother As MetroTextBox
    Friend WithEvents tinert As MetroTextBox
    Friend WithEvents MetroLabel10 As MetroLabel
    Friend WithEvents MetroLabel11 As MetroLabel
    Friend WithEvents tkindother As MetroTextBox
    Friend WithEvents tkindinert As MetroTextBox
    Friend WithEvents MetroPanel2 As MetroPanel
    Friend WithEvents ttgldate As MaskedTextBox
    Friend WithEvents MetroLabel13 As MetroLabel
    Friend WithEvents BtnUpdate As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnDel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MetroLabel12 As MetroLabel
    Friend WithEvents tanalyst As MetroTextBox
    Friend WithEvents LPure As MetroLabel
    Friend WithEvents Lother As MetroLabel
    Friend WithEvents Linert As MetroLabel
    Friend WithEvents MetroPanel1 As MetroPanel
    Friend WithEvents MetroStyleExtender1 As Components.MetroStyleExtender
    Friend WithEvents MetroStyleManager1 As Components.MetroStyleManager
    Friend WithEvents Lreqnum As MetroLabel
    Friend WithEvents MetroLabel16 As MetroLabel
    Friend WithEvents tscope As MetroLabel
    Friend WithEvents tlotref As MetroLabel
    Friend WithEvents tnoman As MetroLabel
    Friend WithEvents MetroLabel21 As MetroLabel
    Friend WithEvents tvariety As MetroLabel
    Friend WithEvents MetroLabel22 As MetroLabel
    Friend WithEvents MetroLabel2 As MetroLabel
    Friend WithEvents LabelDate1 As MetroLabel
    Friend WithEvents t1thseed As MetroTextBox
    Friend WithEvents MetroLabel19 As MetroLabel
    Friend WithEvents MetroLabel3 As MetroLabel
    Friend WithEvents tremark As MetroTextBox
    Friend WithEvents tpurnotpass As MetroRadioButton
    Friend WithEvents tpurpass As MetroRadioButton
    Friend WithEvents MetroLabel20 As MetroLabel
    Friend WithEvents MetroLabel14 As MetroLabel
    Friend WithEvents LToleransi As MetroLabel
End Class
