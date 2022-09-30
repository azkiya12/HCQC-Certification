<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SampelMasukExternal
    'Inherits MetroFramework.Forms.MetroForm
    Inherits SlidePanel1
    Sub New(ByVal owner As MetroFramework.Forms.MetroForm)
        MyBase.new(owner)

        InitializeComponent()

        Me.StyleManager.Update()

    End Sub


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
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel
        Me.tdatehvs = New System.Windows.Forms.MaskedTextBox
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel
        Me.tTgl_msk = New System.Windows.Forms.MaskedTextBox
        Me.btnCari1 = New MetroFramework.Controls.MetroTile
        Me.btnDelete = New MetroFramework.Controls.MetroButton
        Me.btnEdit = New MetroFramework.Controls.MetroButton
        Me.btnSave = New MetroFramework.Controls.MetroButton
        Me.tket = New MetroFramework.Controls.MetroTextBox
        Me.tppc2 = New MetroFramework.Controls.MetroTextBox
        Me.chkDT = New MetroFramework.Controls.MetroCheckBox
        Me.chkRaf = New MetroFramework.Controls.MetroCheckBox
        Me.chkKA = New MetroFramework.Controls.MetroCheckBox
        Me.tppc = New MetroFramework.Controls.MetroTextBox
        Me.tbrt_msk = New MetroFramework.Controls.MetroTextBox
        Me.tweightA = New MetroFramework.Controls.MetroTextBox
        Me.tnojob = New MetroFramework.Controls.MetroTextBox
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel
        Me.tvarety = New MetroFramework.Controls.MetroTextBox
        Me.tnolab = New MetroFramework.Controls.MetroTextBox
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel
        Me.tasal = New MetroFramework.Controls.MetroTextBox
        Me.tweightB = New MetroFramework.Controls.MetroTextBox
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel
        Me.texpdate = New System.Windows.Forms.MaskedTextBox
        Me.CunitA = New System.Windows.Forms.ComboBox
        Me.CunitB = New System.Windows.Forms.ComboBox
        Me.tnama = New MetroFramework.Controls.MetroTextBox
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel
        Me.chkAAT = New MetroFramework.Controls.MetroCheckBox
        Me.chkTZ = New MetroFramework.Controls.MetroCheckBox
        Me.chkECT = New MetroFramework.Controls.MetroCheckBox
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip
        Me.tjns_bnh = New MetroFramework.Controls.MetroTextBox
        Me.tuk_bnh = New MetroFramework.Controls.MetroComboBox
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel
        Me.MetroPanel3.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel3
        '
        Me.MetroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel3.Controls.Add(Me.tdatehvs)
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(475, 132)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.MetroPanel3.Size = New System.Drawing.Size(116, 23)
        Me.MetroPanel3.TabIndex = 10
        Me.MetroPanel3.UseStyleColors = True
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'tdatehvs
        '
        Me.tdatehvs.BackColor = System.Drawing.SystemColors.Window
        Me.tdatehvs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tdatehvs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tdatehvs.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdatehvs.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tdatehvs.Location = New System.Drawing.Point(1, 1)
        Me.tdatehvs.Mask = "00/00/0000"
        Me.tdatehvs.Name = "tdatehvs"
        Me.tdatehvs.Size = New System.Drawing.Size(112, 18)
        Me.tdatehvs.TabIndex = 10
        Me.tdatehvs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tdatehvs.ValidatingType = GetType(Date)
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel2.Controls.Add(Me.tTgl_msk)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(125, 280)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.MetroPanel2.Size = New System.Drawing.Size(114, 23)
        Me.MetroPanel2.TabIndex = 20
        Me.MetroPanel2.UseStyleColors = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'tTgl_msk
        '
        Me.tTgl_msk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tTgl_msk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tTgl_msk.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tTgl_msk.Location = New System.Drawing.Point(1, 1)
        Me.tTgl_msk.Mask = "00/00/0000"
        Me.tTgl_msk.Name = "tTgl_msk"
        Me.tTgl_msk.Size = New System.Drawing.Size(110, 18)
        Me.tTgl_msk.TabIndex = 20
        Me.tTgl_msk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tTgl_msk.ValidatingType = GetType(Date)
        '
        'btnCari1
        '
        Me.btnCari1.ActiveControl = Nothing
        Me.btnCari1.Location = New System.Drawing.Point(261, 74)
        Me.btnCari1.Name = "btnCari1"
        Me.btnCari1.Size = New System.Drawing.Size(46, 23)
        Me.btnCari1.TabIndex = 157
        Me.btnCari1.TabStop = False
        Me.btnCari1.Text = "Cari"
        Me.btnCari1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnCari1.UseSelectable = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.DisplayFocus = True
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(859, 132)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(79, 29)
        Me.btnDelete.TabIndex = 42
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseSelectable = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.DisplayFocus = True
        Me.btnEdit.Enabled = False
        Me.btnEdit.Location = New System.Drawing.Point(777, 132)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(79, 29)
        Me.btnEdit.TabIndex = 41
        Me.btnEdit.Text = "Update"
        Me.btnEdit.UseSelectable = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.DisplayFocus = True
        Me.btnSave.Location = New System.Drawing.Point(777, 81)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(161, 45)
        Me.btnSave.TabIndex = 40
        Me.btnSave.Text = "Save"
        Me.btnSave.UseSelectable = True
        '
        'tket
        '
        '
        '
        '
        Me.tket.CustomButton.Image = Nothing
        Me.tket.CustomButton.Location = New System.Drawing.Point(271, 2)
        Me.tket.CustomButton.Name = ""
        Me.tket.CustomButton.Size = New System.Drawing.Size(61, 61)
        Me.tket.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tket.CustomButton.TabIndex = 1
        Me.tket.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tket.CustomButton.UseSelectable = True
        Me.tket.CustomButton.Visible = False
        Me.tket.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tket.Lines = New String(-1) {}
        Me.tket.Location = New System.Drawing.Point(44, 404)
        Me.tket.MaxLength = 225
        Me.tket.Multiline = True
        Me.tket.Name = "tket"
        Me.tket.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tket.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tket.SelectedText = ""
        Me.tket.SelectionLength = 0
        Me.tket.SelectionStart = 0
        Me.tket.Size = New System.Drawing.Size(335, 66)
        Me.tket.TabIndex = 37
        Me.tket.UseSelectable = True
        Me.tket.UseStyleColors = True
        Me.tket.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tket.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tppc2
        '
        '
        '
        '
        Me.tppc2.CustomButton.Image = Nothing
        Me.tppc2.CustomButton.Location = New System.Drawing.Point(94, 1)
        Me.tppc2.CustomButton.Name = ""
        Me.tppc2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tppc2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tppc2.CustomButton.TabIndex = 1
        Me.tppc2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tppc2.CustomButton.UseSelectable = True
        Me.tppc2.CustomButton.Visible = False
        Me.tppc2.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tppc2.Lines = New String(-1) {}
        Me.tppc2.Location = New System.Drawing.Point(340, 309)
        Me.tppc2.MaxLength = 32767
        Me.tppc2.Name = "tppc2"
        Me.tppc2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tppc2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tppc2.SelectedText = ""
        Me.tppc2.SelectionLength = 0
        Me.tppc2.SelectionStart = 0
        Me.tppc2.Size = New System.Drawing.Size(116, 23)
        Me.tppc2.TabIndex = 24
        Me.tppc2.UseSelectable = True
        Me.tppc2.UseStyleColors = True
        Me.tppc2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tppc2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'chkDT
        '
        Me.chkDT.AutoSize = True
        Me.chkDT.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkDT.Location = New System.Drawing.Point(525, 330)
        Me.chkDT.Name = "chkDT"
        Me.chkDT.Size = New System.Drawing.Size(130, 19)
        Me.chkDT.TabIndex = 33
        Me.chkDT.Text = "Germination Test"
        Me.chkDT.UseSelectable = True
        Me.chkDT.UseStyleColors = True
        '
        'chkRaf
        '
        Me.chkRaf.AutoSize = True
        Me.chkRaf.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkRaf.Location = New System.Drawing.Point(525, 305)
        Me.chkRaf.Name = "chkRaf"
        Me.chkRaf.Size = New System.Drawing.Size(123, 19)
        Me.chkRaf.TabIndex = 32
        Me.chkRaf.Text = "Purity Seed Test"
        Me.chkRaf.UseSelectable = True
        Me.chkRaf.UseStyleColors = True
        '
        'chkKA
        '
        Me.chkKA.AutoSize = True
        Me.chkKA.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkKA.Location = New System.Drawing.Point(525, 280)
        Me.chkKA.Name = "chkKA"
        Me.chkKA.Size = New System.Drawing.Size(109, 19)
        Me.chkKA.TabIndex = 31
        Me.chkKA.Text = "Moisture Test"
        Me.chkKA.UseSelectable = True
        Me.chkKA.UseStyleColors = True
        '
        'tppc
        '
        '
        '
        '
        Me.tppc.CustomButton.Image = Nothing
        Me.tppc.CustomButton.Location = New System.Drawing.Point(94, 1)
        Me.tppc.CustomButton.Name = ""
        Me.tppc.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tppc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tppc.CustomButton.TabIndex = 1
        Me.tppc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tppc.CustomButton.UseSelectable = True
        Me.tppc.CustomButton.Visible = False
        Me.tppc.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tppc.Lines = New String(-1) {}
        Me.tppc.Location = New System.Drawing.Point(340, 280)
        Me.tppc.MaxLength = 32767
        Me.tppc.Name = "tppc"
        Me.tppc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tppc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tppc.SelectedText = ""
        Me.tppc.SelectionLength = 0
        Me.tppc.SelectionStart = 0
        Me.tppc.Size = New System.Drawing.Size(116, 23)
        Me.tppc.TabIndex = 23
        Me.tppc.UseSelectable = True
        Me.tppc.UseStyleColors = True
        Me.tppc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tppc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tbrt_msk
        '
        '
        '
        '
        Me.tbrt_msk.CustomButton.Image = Nothing
        Me.tbrt_msk.CustomButton.Location = New System.Drawing.Point(92, 1)
        Me.tbrt_msk.CustomButton.Name = ""
        Me.tbrt_msk.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbrt_msk.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbrt_msk.CustomButton.TabIndex = 1
        Me.tbrt_msk.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbrt_msk.CustomButton.UseSelectable = True
        Me.tbrt_msk.CustomButton.Visible = False
        Me.tbrt_msk.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbrt_msk.Lines = New String(-1) {}
        Me.tbrt_msk.Location = New System.Drawing.Point(125, 309)
        Me.tbrt_msk.MaxLength = 32767
        Me.tbrt_msk.Name = "tbrt_msk"
        Me.tbrt_msk.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbrt_msk.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbrt_msk.SelectedText = ""
        Me.tbrt_msk.SelectionLength = 0
        Me.tbrt_msk.SelectionStart = 0
        Me.tbrt_msk.Size = New System.Drawing.Size(114, 23)
        Me.tbrt_msk.TabIndex = 21
        Me.tbrt_msk.UseSelectable = True
        Me.tbrt_msk.UseStyleColors = True
        Me.tbrt_msk.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbrt_msk.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tweightA
        '
        '
        '
        '
        Me.tweightA.CustomButton.Image = Nothing
        Me.tweightA.CustomButton.Location = New System.Drawing.Point(40, 1)
        Me.tweightA.CustomButton.Name = ""
        Me.tweightA.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tweightA.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tweightA.CustomButton.TabIndex = 1
        Me.tweightA.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tweightA.CustomButton.UseSelectable = True
        Me.tweightA.CustomButton.Visible = False
        Me.tweightA.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tweightA.Lines = New String(-1) {}
        Me.tweightA.Location = New System.Drawing.Point(125, 161)
        Me.tweightA.MaxLength = 32767
        Me.tweightA.Name = "tweightA"
        Me.tweightA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tweightA.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tweightA.SelectedText = ""
        Me.tweightA.SelectionLength = 0
        Me.tweightA.SelectionStart = 0
        Me.tweightA.Size = New System.Drawing.Size(62, 23)
        Me.tweightA.TabIndex = 4
        Me.MetroToolTip1.SetToolTip(Me.tweightA, "Jumlah tonase lot")
        Me.tweightA.UseSelectable = True
        Me.tweightA.UseStyleColors = True
        Me.tweightA.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tweightA.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tnojob
        '
        '
        '
        '
        Me.tnojob.CustomButton.Image = Nothing
        Me.tnojob.CustomButton.Location = New System.Drawing.Point(108, 1)
        Me.tnojob.CustomButton.Name = ""
        Me.tnojob.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tnojob.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tnojob.CustomButton.TabIndex = 1
        Me.tnojob.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tnojob.CustomButton.UseSelectable = True
        Me.tnojob.CustomButton.Visible = False
        Me.tnojob.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tnojob.Lines = New String(-1) {}
        Me.tnojob.Location = New System.Drawing.Point(125, 132)
        Me.tnojob.MaxLength = 32767
        Me.tnojob.Name = "tnojob"
        Me.tnojob.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tnojob.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tnojob.SelectedText = ""
        Me.tnojob.SelectionLength = 0
        Me.tnojob.SelectionStart = 0
        Me.tnojob.Size = New System.Drawing.Size(130, 23)
        Me.tnojob.TabIndex = 3
        Me.tnojob.UseSelectable = True
        Me.tnojob.UseStyleColors = True
        Me.tnojob.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tnojob.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel16.Location = New System.Drawing.Point(44, 382)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel16.TabIndex = 138
        Me.MetroLabel16.Text = "Remark"
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel15.Location = New System.Drawing.Point(270, 313)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel15.TabIndex = 137
        Me.MetroLabel15.Text = "Input by"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel12.Location = New System.Drawing.Point(501, 242)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(87, 19)
        Me.MetroLabel12.TabIndex = 134
        Me.MetroLabel12.Text = "Test Request"
        Me.MetroLabel12.UseStyleColors = True
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel11.Location = New System.Drawing.Point(29, 243)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(101, 19)
        Me.MetroLabel11.TabIndex = 133
        Me.MetroLabel11.Text = "Receipt Sample"
        Me.MetroLabel11.UseStyleColors = True
        '
        'tvarety
        '
        '
        '
        '
        Me.tvarety.CustomButton.Image = Nothing
        Me.tvarety.CustomButton.Location = New System.Drawing.Point(108, 1)
        Me.tvarety.CustomButton.Name = ""
        Me.tvarety.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tvarety.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tvarety.CustomButton.TabIndex = 1
        Me.tvarety.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tvarety.CustomButton.UseSelectable = True
        Me.tvarety.CustomButton.Visible = False
        Me.tvarety.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tvarety.Lines = New String(-1) {}
        Me.tvarety.Location = New System.Drawing.Point(125, 102)
        Me.tvarety.MaxLength = 32767
        Me.tvarety.Name = "tvarety"
        Me.tvarety.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tvarety.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tvarety.SelectedText = ""
        Me.tvarety.SelectionLength = 0
        Me.tvarety.SelectionStart = 0
        Me.tvarety.Size = New System.Drawing.Size(130, 23)
        Me.tvarety.TabIndex = 2
        Me.tvarety.UseSelectable = True
        Me.tvarety.UseStyleColors = True
        Me.tvarety.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tvarety.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tnolab
        '
        '
        '
        '
        Me.tnolab.CustomButton.Image = Nothing
        Me.tnolab.CustomButton.Location = New System.Drawing.Point(108, 1)
        Me.tnolab.CustomButton.Name = ""
        Me.tnolab.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tnolab.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tnolab.CustomButton.TabIndex = 1
        Me.tnolab.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tnolab.CustomButton.UseSelectable = True
        Me.tnolab.CustomButton.Visible = False
        Me.tnolab.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tnolab.Lines = New String(-1) {}
        Me.tnolab.Location = New System.Drawing.Point(125, 74)
        Me.tnolab.MaxLength = 32767
        Me.tnolab.Name = "tnolab"
        Me.tnolab.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tnolab.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tnolab.SelectedText = ""
        Me.tnolab.SelectionLength = 0
        Me.tnolab.SelectionStart = 0
        Me.tnolab.Size = New System.Drawing.Size(130, 23)
        Me.tnolab.TabIndex = 1
        Me.tnolab.UseSelectable = True
        Me.tnolab.UseStyleColors = True
        Me.tnolab.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tnolab.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel8.Location = New System.Drawing.Point(270, 284)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel8.TabIndex = 128
        Me.MetroLabel8.Text = "Taken by"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel7.Location = New System.Drawing.Point(42, 313)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel7.TabIndex = 127
        Me.MetroLabel7.Text = "Weight (g)"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel6.Location = New System.Drawing.Point(44, 284)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel6.TabIndex = 126
        Me.MetroLabel6.Text = "Date"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(42, 165)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(77, 19)
        Me.MetroLabel5.TabIndex = 125
        Me.MetroLabel5.Text = "Weight Lot"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(380, 136)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel4.TabIndex = 124
        Me.MetroLabel4.Text = "Harvest Date"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(42, 136)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel3.TabIndex = 123
        Me.MetroLabel3.Text = "Kode/ Lot"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(42, 106)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel2.TabIndex = 122
        Me.MetroLabel2.Text = "Variety"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(42, 78)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel1.TabIndex = 121
        Me.MetroLabel1.Text = "Lab. No."
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel10.Location = New System.Drawing.Point(380, 107)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel10.TabIndex = 132
        Me.MetroLabel10.Text = "From"
        '
        'tasal
        '
        '
        '
        '
        Me.tasal.CustomButton.Image = Nothing
        Me.tasal.CustomButton.Location = New System.Drawing.Point(161, 1)
        Me.tasal.CustomButton.Name = ""
        Me.tasal.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tasal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tasal.CustomButton.TabIndex = 1
        Me.tasal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tasal.CustomButton.UseSelectable = True
        Me.tasal.CustomButton.Visible = False
        Me.tasal.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tasal.Lines = New String(-1) {}
        Me.tasal.Location = New System.Drawing.Point(475, 103)
        Me.tasal.MaxLength = 32767
        Me.tasal.Name = "tasal"
        Me.tasal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tasal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tasal.SelectedText = ""
        Me.tasal.SelectionLength = 0
        Me.tasal.SelectionStart = 0
        Me.tasal.Size = New System.Drawing.Size(183, 23)
        Me.tasal.TabIndex = 9
        Me.MetroToolTip1.SetToolTip(Me.tasal, "Asal Benih")
        Me.tasal.UseSelectable = True
        Me.tasal.UseStyleColors = True
        Me.tasal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tasal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tweightB
        '
        '
        '
        '
        Me.tweightB.CustomButton.Image = Nothing
        Me.tweightB.CustomButton.Location = New System.Drawing.Point(40, 1)
        Me.tweightB.CustomButton.Name = ""
        Me.tweightB.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tweightB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tweightB.CustomButton.TabIndex = 1
        Me.tweightB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tweightB.CustomButton.UseSelectable = True
        Me.tweightB.CustomButton.Visible = False
        Me.tweightB.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tweightB.Lines = New String(-1) {}
        Me.tweightB.Location = New System.Drawing.Point(125, 190)
        Me.tweightB.MaxLength = 32767
        Me.tweightB.Name = "tweightB"
        Me.tweightB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tweightB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tweightB.SelectedText = ""
        Me.tweightB.SelectionLength = 0
        Me.tweightB.SelectionStart = 0
        Me.tweightB.Size = New System.Drawing.Size(62, 23)
        Me.tweightB.TabIndex = 6
        Me.MetroToolTip1.SetToolTip(Me.tweightB, "Berat Contoh Kirim")
        Me.tweightB.UseSelectable = True
        Me.tweightB.UseStyleColors = True
        Me.tweightB.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tweightB.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel17.Location = New System.Drawing.Point(380, 165)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel17.TabIndex = 124
        Me.MetroLabel17.Text = "EXP. Date"
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel1.Controls.Add(Me.texpdate)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(475, 161)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.MetroPanel1.Size = New System.Drawing.Size(116, 23)
        Me.MetroPanel1.TabIndex = 11
        Me.MetroPanel1.UseStyleColors = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'texpdate
        '
        Me.texpdate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.texpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.texpdate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texpdate.Location = New System.Drawing.Point(1, 1)
        Me.texpdate.Mask = "00/00/0000"
        Me.texpdate.Name = "texpdate"
        Me.texpdate.Size = New System.Drawing.Size(112, 18)
        Me.texpdate.TabIndex = 11
        Me.texpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.texpdate.ValidatingType = GetType(Date)
        '
        'CunitA
        '
        Me.CunitA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CunitA.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.CunitA.FormattingEnabled = True
        Me.CunitA.Items.AddRange(New Object() {"KG", "PACK"})
        Me.CunitA.Location = New System.Drawing.Point(193, 161)
        Me.CunitA.Name = "CunitA"
        Me.CunitA.Size = New System.Drawing.Size(62, 25)
        Me.CunitA.TabIndex = 5
        '
        'CunitB
        '
        Me.CunitB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CunitB.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.CunitB.FormattingEnabled = True
        Me.CunitB.Items.AddRange(New Object() {"GR", "KG", "PACK"})
        Me.CunitB.Location = New System.Drawing.Point(193, 190)
        Me.CunitB.Name = "CunitB"
        Me.CunitB.Size = New System.Drawing.Size(62, 25)
        Me.CunitB.TabIndex = 7
        '
        'tnama
        '
        '
        '
        '
        Me.tnama.CustomButton.Image = Nothing
        Me.tnama.CustomButton.Location = New System.Drawing.Point(161, 1)
        Me.tnama.CustomButton.Name = ""
        Me.tnama.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tnama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tnama.CustomButton.TabIndex = 1
        Me.tnama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tnama.CustomButton.UseSelectable = True
        Me.tnama.CustomButton.Visible = False
        Me.tnama.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tnama.Lines = New String(-1) {}
        Me.tnama.Location = New System.Drawing.Point(475, 74)
        Me.tnama.MaxLength = 32767
        Me.tnama.Name = "tnama"
        Me.tnama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tnama.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tnama.SelectedText = ""
        Me.tnama.SelectionLength = 0
        Me.tnama.SelectionStart = 0
        Me.tnama.Size = New System.Drawing.Size(183, 23)
        Me.tnama.TabIndex = 8
        Me.tnama.UseSelectable = True
        Me.tnama.UseStyleColors = True
        Me.tnama.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tnama.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel18.Location = New System.Drawing.Point(380, 81)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel18.TabIndex = 123
        Me.MetroLabel18.Text = "Name"
        '
        'MetroLink1
        '
        Me.MetroLink1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLink1.DisplayFocus = True
        Me.MetroLink1.Image = Global.WindowsApplication1.My.Resources.Resources.Right
        Me.MetroLink1.ImageSize = 45
        Me.MetroLink1.Location = New System.Drawing.Point(892, 28)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(69, 29)
        Me.MetroLink1.TabIndex = 167
        Me.MetroToolTip1.SetToolTip(Me.MetroLink1, "Close")
        Me.MetroLink1.UseSelectable = True
        Me.MetroLink1.UseStyleColors = True
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel19.Location = New System.Drawing.Point(29, 38)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(104, 19)
        Me.MetroLabel19.TabIndex = 133
        Me.MetroLabel19.Text = "Sample Identity"
        Me.MetroLabel19.UseStyleColors = True
        '
        'chkAAT
        '
        Me.chkAAT.AutoSize = True
        Me.chkAAT.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkAAT.Location = New System.Drawing.Point(692, 280)
        Me.chkAAT.Name = "chkAAT"
        Me.chkAAT.Size = New System.Drawing.Size(164, 19)
        Me.chkAAT.TabIndex = 34
        Me.chkAAT.Text = "Accelerated Aging Test"
        Me.chkAAT.UseSelectable = True
        Me.chkAAT.UseStyleColors = True
        '
        'chkTZ
        '
        Me.chkTZ.AutoSize = True
        Me.chkTZ.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkTZ.Location = New System.Drawing.Point(692, 305)
        Me.chkTZ.Name = "chkTZ"
        Me.chkTZ.Size = New System.Drawing.Size(125, 19)
        Me.chkTZ.TabIndex = 35
        Me.chkTZ.Text = "Tetrazolium Test"
        Me.chkTZ.UseSelectable = True
        Me.chkTZ.UseStyleColors = True
        '
        'chkECT
        '
        Me.chkECT.AutoSize = True
        Me.chkECT.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkECT.Location = New System.Drawing.Point(692, 330)
        Me.chkECT.Name = "chkECT"
        Me.chkECT.Size = New System.Drawing.Size(177, 19)
        Me.chkECT.TabIndex = 36
        Me.chkECT.Text = "Electric Conductivity Test"
        Me.chkECT.UseSelectable = True
        Me.chkECT.UseStyleColors = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel9.Location = New System.Drawing.Point(42, 342)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel9.TabIndex = 128
        Me.MetroLabel9.Text = "Type"
        '
        'MetroButton2
        '
        Me.MetroButton2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Add
        Me.MetroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MetroButton2.Location = New System.Drawing.Point(313, 74)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(36, 23)
        Me.MetroButton2.TabIndex = 164
        Me.MetroButton2.UseMnemonic = False
        Me.MetroButton2.UseSelectable = True
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'tjns_bnh
        '
        '
        '
        '
        Me.tjns_bnh.CustomButton.Image = Nothing
        Me.tjns_bnh.CustomButton.Location = New System.Drawing.Point(161, 1)
        Me.tjns_bnh.CustomButton.Name = ""
        Me.tjns_bnh.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tjns_bnh.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tjns_bnh.CustomButton.TabIndex = 1
        Me.tjns_bnh.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tjns_bnh.CustomButton.UseSelectable = True
        Me.tjns_bnh.CustomButton.Visible = False
        Me.tjns_bnh.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tjns_bnh.Lines = New String(-1) {}
        Me.tjns_bnh.Location = New System.Drawing.Point(475, 190)
        Me.tjns_bnh.MaxLength = 32767
        Me.tjns_bnh.Name = "tjns_bnh"
        Me.tjns_bnh.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tjns_bnh.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tjns_bnh.SelectedText = ""
        Me.tjns_bnh.SelectionLength = 0
        Me.tjns_bnh.SelectionStart = 0
        Me.tjns_bnh.Size = New System.Drawing.Size(183, 23)
        Me.tjns_bnh.TabIndex = 12
        Me.MetroToolTip1.SetToolTip(Me.tjns_bnh, "Jenis Benih")
        Me.tjns_bnh.UseSelectable = True
        Me.tjns_bnh.UseStyleColors = True
        Me.tjns_bnh.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tjns_bnh.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tuk_bnh
        '
        Me.tuk_bnh.FormattingEnabled = True
        Me.tuk_bnh.ItemHeight = 23
        Me.tuk_bnh.Items.AddRange(New Object() {"Kecil", "Sedang", "Besar", "Pasir"})
        Me.tuk_bnh.Location = New System.Drawing.Point(125, 338)
        Me.tuk_bnh.Name = "tuk_bnh"
        Me.tuk_bnh.Size = New System.Drawing.Size(114, 29)
        Me.tuk_bnh.TabIndex = 22
        Me.MetroToolTip1.SetToolTip(Me.tuk_bnh, "Ukuran Sampel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Diisi Kecil, Sedang, Besar")
        Me.tuk_bnh.UseSelectable = True
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel13.Location = New System.Drawing.Point(380, 194)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(76, 19)
        Me.MetroLabel13.TabIndex = 124
        Me.MetroLabel13.Text = "Jenis Benih"
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel14.Location = New System.Drawing.Point(42, 196)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel14.TabIndex = 168
        Me.MetroLabel14.Text = "Weight (g)"
        '
        'SampelMasukExternal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroLabel14)
        Me.Controls.Add(Me.tuk_bnh)
        Me.Controls.Add(Me.MetroLink1)
        Me.Controls.Add(Me.CunitB)
        Me.Controls.Add(Me.CunitA)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.MetroPanel3)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.btnCari1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tket)
        Me.Controls.Add(Me.tppc2)
        Me.Controls.Add(Me.chkECT)
        Me.Controls.Add(Me.chkTZ)
        Me.Controls.Add(Me.chkAAT)
        Me.Controls.Add(Me.chkDT)
        Me.Controls.Add(Me.chkRaf)
        Me.Controls.Add(Me.chkKA)
        Me.Controls.Add(Me.tppc)
        Me.Controls.Add(Me.tbrt_msk)
        Me.Controls.Add(Me.tjns_bnh)
        Me.Controls.Add(Me.tasal)
        Me.Controls.Add(Me.tweightB)
        Me.Controls.Add(Me.tweightA)
        Me.Controls.Add(Me.tnama)
        Me.Controls.Add(Me.tnojob)
        Me.Controls.Add(Me.MetroLabel16)
        Me.Controls.Add(Me.MetroLabel15)
        Me.Controls.Add(Me.MetroLabel12)
        Me.Controls.Add(Me.MetroLabel19)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.tvarety)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.tnolab)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel13)
        Me.Controls.Add(Me.MetroLabel17)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel18)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "SampelMasukExternal"
        Me.Padding = New System.Windows.Forms.Padding(20, 70, 20, 20)
        Me.Size = New System.Drawing.Size(961, 493)
        Me.UseStyleColors = True
        Me.MetroPanel3.ResumeLayout(False)
        Me.MetroPanel3.PerformLayout()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents tdatehvs As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents tTgl_msk As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnCari1 As MetroFramework.Controls.MetroTile
    Friend WithEvents btnDelete As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEdit As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents tket As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tppc2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents chkDT As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkRaf As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkKA As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents tppc As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbrt_msk As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tweightA As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tnojob As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tvarety As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tnolab As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tasal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tweightB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents texpdate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CunitA As System.Windows.Forms.ComboBox
    Friend WithEvents CunitB As System.Windows.Forms.ComboBox
    Friend WithEvents tnama As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents chkAAT As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkTZ As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkECT As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents tjns_bnh As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tuk_bnh As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
End Class
