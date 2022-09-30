<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Finish_Goods_Arsip
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Me.btnDelete = New MetroFramework.Controls.MetroButton()
        Me.btnEdit = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel30 = New MetroFramework.Controls.MetroLabel()
        Me.tCari1 = New MetroFramework.Controls.MetroTile()
        Me.tvariety = New MetroFramework.Controls.MetroTextBox()
        Me.tno_lab = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.tkardus_ars = New MetroFramework.Controls.MetroTextBox()
        Me.texpdate = New System.Windows.Forms.MaskedTextBox()
        Me.tnojob = New System.Windows.Forms.TextBox()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tka_ars = New MetroFramework.Controls.MetroTextBox()
        Me.tdt_ars = New MetroFramework.Controls.MetroTextBox()
        Me.cbox_unit = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.tbrt_ars = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(340, 306)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(79, 29)
        Me.btnDelete.TabIndex = 142
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseSelectable = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Location = New System.Drawing.Point(258, 306)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(79, 29)
        Me.btnEdit.TabIndex = 141
        Me.btnEdit.Text = "Upload"
        Me.btnEdit.UseSelectable = True
        '
        'MetroLabel30
        '
        Me.MetroLabel30.AutoSize = True
        Me.MetroLabel30.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel30.Location = New System.Drawing.Point(75, 70)
        Me.MetroLabel30.Name = "MetroLabel30"
        Me.MetroLabel30.Size = New System.Drawing.Size(114, 19)
        Me.MetroLabel30.TabIndex = 123
        Me.MetroLabel30.Text = "Sample Identity"
        Me.MetroLabel30.UseStyleColors = True
        '
        'tCari1
        '
        Me.tCari1.ActiveControl = Nothing
        Me.tCari1.Location = New System.Drawing.Point(230, 103)
        Me.tCari1.Name = "tCari1"
        Me.tCari1.Size = New System.Drawing.Size(46, 23)
        Me.tCari1.TabIndex = 143
        Me.tCari1.Text = "Cari"
        Me.tCari1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.tCari1.UseSelectable = True
        '
        'tvariety
        '
        '
        '
        '
        Me.tvariety.CustomButton.Image = Nothing
        Me.tvariety.CustomButton.Location = New System.Drawing.Point(92, 1)
        Me.tvariety.CustomButton.Name = ""
        Me.tvariety.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tvariety.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tvariety.CustomButton.TabIndex = 1
        Me.tvariety.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tvariety.CustomButton.UseSelectable = True
        Me.tvariety.CustomButton.Visible = False
        Me.tvariety.Enabled = False
        Me.tvariety.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tvariety.Lines = New String(-1) {}
        Me.tvariety.Location = New System.Drawing.Point(23, 179)
        Me.tvariety.MaxLength = 32767
        Me.tvariety.Name = "tvariety"
        Me.tvariety.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tvariety.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tvariety.SelectedText = ""
        Me.tvariety.SelectionLength = 0
        Me.tvariety.SelectionStart = 0
        Me.tvariety.ShortcutsEnabled = True
        Me.tvariety.Size = New System.Drawing.Size(114, 23)
        Me.tvariety.TabIndex = 121
        Me.tvariety.UseSelectable = True
        Me.tvariety.UseStyleColors = True
        Me.tvariety.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tvariety.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tno_lab
        '
        '
        '
        '
        Me.tno_lab.CustomButton.Image = Nothing
        Me.tno_lab.CustomButton.Location = New System.Drawing.Point(92, 1)
        Me.tno_lab.CustomButton.Name = ""
        Me.tno_lab.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tno_lab.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tno_lab.CustomButton.TabIndex = 1
        Me.tno_lab.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tno_lab.CustomButton.UseSelectable = True
        Me.tno_lab.CustomButton.Visible = False
        Me.tno_lab.Enabled = False
        Me.tno_lab.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tno_lab.Lines = New String(-1) {}
        Me.tno_lab.Location = New System.Drawing.Point(168, 179)
        Me.tno_lab.MaxLength = 32767
        Me.tno_lab.Name = "tno_lab"
        Me.tno_lab.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tno_lab.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tno_lab.SelectedText = ""
        Me.tno_lab.SelectionLength = 0
        Me.tno_lab.SelectionStart = 0
        Me.tno_lab.ShortcutsEnabled = True
        Me.tno_lab.Size = New System.Drawing.Size(114, 23)
        Me.tno_lab.TabIndex = 122
        Me.tno_lab.UseSelectable = True
        Me.tno_lab.UseStyleColors = True
        Me.tno_lab.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tno_lab.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 107)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel5.TabIndex = 127
        Me.MetroLabel5.Text = "No. Job"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel6.Location = New System.Drawing.Point(23, 157)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel6.TabIndex = 126
        Me.MetroLabel6.Text = "Variety"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel7.Location = New System.Drawing.Point(168, 157)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel7.TabIndex = 124
        Me.MetroLabel7.Text = "No. Lab"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 284)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(76, 19)
        Me.MetroLabel3.TabIndex = 128
        Me.MetroLabel3.Text = "Kardus No."
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(305, 157)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel4.TabIndex = 128
        Me.MetroLabel4.Text = "EXP. Date"
        '
        'tkardus_ars
        '
        '
        '
        '
        Me.tkardus_ars.CustomButton.Image = Nothing
        Me.tkardus_ars.CustomButton.Location = New System.Drawing.Point(92, 1)
        Me.tkardus_ars.CustomButton.Name = ""
        Me.tkardus_ars.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tkardus_ars.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tkardus_ars.CustomButton.TabIndex = 1
        Me.tkardus_ars.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tkardus_ars.CustomButton.UseSelectable = True
        Me.tkardus_ars.CustomButton.Visible = False
        Me.tkardus_ars.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tkardus_ars.Lines = New String(-1) {}
        Me.tkardus_ars.Location = New System.Drawing.Point(23, 306)
        Me.tkardus_ars.MaxLength = 32767
        Me.tkardus_ars.Name = "tkardus_ars"
        Me.tkardus_ars.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tkardus_ars.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tkardus_ars.SelectedText = ""
        Me.tkardus_ars.SelectionLength = 0
        Me.tkardus_ars.SelectionStart = 0
        Me.tkardus_ars.ShortcutsEnabled = True
        Me.tkardus_ars.Size = New System.Drawing.Size(114, 23)
        Me.tkardus_ars.TabIndex = 128
        Me.tkardus_ars.UseSelectable = True
        Me.tkardus_ars.UseStyleColors = True
        Me.tkardus_ars.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tkardus_ars.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'texpdate
        '
        Me.texpdate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.texpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.texpdate.Font = New System.Drawing.Font("Segoe UI", 10.9!)
        Me.texpdate.Location = New System.Drawing.Point(2, 1)
        Me.texpdate.Mask = "00/00/0000"
        Me.texpdate.Name = "texpdate"
        Me.texpdate.Size = New System.Drawing.Size(109, 20)
        Me.texpdate.TabIndex = 123
        Me.texpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.texpdate.ValidatingType = GetType(Date)
        '
        'tnojob
        '
        Me.MetroStyleExtender1.SetApplyMetroTheme(Me.tnojob, True)
        Me.tnojob.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tnojob.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tnojob.BackColor = System.Drawing.SystemColors.Window
        Me.tnojob.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tnojob.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tnojob.Font = New System.Drawing.Font("Segoe UI", 10.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnojob.Location = New System.Drawing.Point(3, 1)
        Me.tnojob.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tnojob.Name = "tnojob"
        Me.tnojob.Size = New System.Drawing.Size(134, 20)
        Me.tnojob.TabIndex = 120
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        '
        'Panel1
        '
        Me.MetroStyleExtender1.SetApplyMetroTheme(Me.Panel1, True)
        Me.Panel1.Controls.Add(Me.tnojob)
        Me.Panel1.Location = New System.Drawing.Point(84, 103)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3, 1, 3, 2)
        Me.Panel1.Size = New System.Drawing.Size(140, 23)
        Me.Panel1.TabIndex = 120
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.texpdate)
        Me.Panel2.Location = New System.Drawing.Point(305, 179)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(2, 1, 3, 1)
        Me.Panel2.Size = New System.Drawing.Size(114, 23)
        Me.Panel2.TabIndex = 123
        '
        'tka_ars
        '
        '
        '
        '
        Me.tka_ars.CustomButton.Image = Nothing
        Me.tka_ars.CustomButton.Location = New System.Drawing.Point(30, 1)
        Me.tka_ars.CustomButton.Name = ""
        Me.tka_ars.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tka_ars.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tka_ars.CustomButton.TabIndex = 1
        Me.tka_ars.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tka_ars.CustomButton.UseSelectable = True
        Me.tka_ars.CustomButton.Visible = False
        Me.tka_ars.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tka_ars.Lines = New String(-1) {}
        Me.tka_ars.Location = New System.Drawing.Point(23, 238)
        Me.tka_ars.MaxLength = 32767
        Me.tka_ars.Name = "tka_ars"
        Me.tka_ars.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tka_ars.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tka_ars.SelectedText = ""
        Me.tka_ars.SelectionLength = 0
        Me.tka_ars.SelectionStart = 0
        Me.tka_ars.ShortcutsEnabled = True
        Me.tka_ars.Size = New System.Drawing.Size(52, 23)
        Me.tka_ars.TabIndex = 124
        Me.tka_ars.UseSelectable = True
        Me.tka_ars.UseStyleColors = True
        Me.tka_ars.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tka_ars.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tdt_ars
        '
        '
        '
        '
        Me.tdt_ars.CustomButton.Image = Nothing
        Me.tdt_ars.CustomButton.Location = New System.Drawing.Point(34, 1)
        Me.tdt_ars.CustomButton.Name = ""
        Me.tdt_ars.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tdt_ars.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tdt_ars.CustomButton.TabIndex = 1
        Me.tdt_ars.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tdt_ars.CustomButton.UseSelectable = True
        Me.tdt_ars.CustomButton.Visible = False
        Me.tdt_ars.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tdt_ars.Lines = New String(-1) {}
        Me.tdt_ars.Location = New System.Drawing.Point(81, 238)
        Me.tdt_ars.MaxLength = 32767
        Me.tdt_ars.Name = "tdt_ars"
        Me.tdt_ars.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tdt_ars.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tdt_ars.SelectedText = ""
        Me.tdt_ars.SelectionLength = 0
        Me.tdt_ars.SelectionStart = 0
        Me.tdt_ars.ShortcutsEnabled = True
        Me.tdt_ars.Size = New System.Drawing.Size(56, 23)
        Me.tdt_ars.TabIndex = 125
        Me.tdt_ars.UseSelectable = True
        Me.tdt_ars.UseStyleColors = True
        Me.tdt_ars.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tdt_ars.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cbox_unit
        '
        Me.cbox_unit.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbox_unit.FormattingEnabled = True
        Me.cbox_unit.ItemHeight = 19
        Me.cbox_unit.Items.AddRange(New Object() {"gr", "Kg", "Biji"})
        Me.cbox_unit.Location = New System.Drawing.Point(231, 236)
        Me.cbox_unit.Name = "cbox_unit"
        Me.cbox_unit.Size = New System.Drawing.Size(49, 25)
        Me.cbox_unit.TabIndex = 127
        Me.cbox_unit.UseSelectable = True
        Me.cbox_unit.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 216)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(26, 19)
        Me.MetroLabel1.TabIndex = 128
        Me.MetroLabel1.Text = "KA"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(81, 216)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(25, 19)
        Me.MetroLabel2.TabIndex = 128
        Me.MetroLabel2.Text = "DT"
        '
        'tbrt_ars
        '
        '
        '
        '
        Me.tbrt_ars.CustomButton.Image = Nothing
        Me.tbrt_ars.CustomButton.Location = New System.Drawing.Point(35, 1)
        Me.tbrt_ars.CustomButton.Name = ""
        Me.tbrt_ars.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbrt_ars.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbrt_ars.CustomButton.TabIndex = 1
        Me.tbrt_ars.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbrt_ars.CustomButton.UseSelectable = True
        Me.tbrt_ars.CustomButton.Visible = False
        Me.tbrt_ars.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbrt_ars.Lines = New String(-1) {}
        Me.tbrt_ars.Location = New System.Drawing.Point(168, 238)
        Me.tbrt_ars.MaxLength = 32767
        Me.tbrt_ars.Name = "tbrt_ars"
        Me.tbrt_ars.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbrt_ars.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbrt_ars.SelectedText = ""
        Me.tbrt_ars.SelectionLength = 0
        Me.tbrt_ars.SelectionStart = 0
        Me.tbrt_ars.ShortcutsEnabled = True
        Me.tbrt_ars.Size = New System.Drawing.Size(57, 23)
        Me.tbrt_ars.TabIndex = 126
        Me.tbrt_ars.UseSelectable = True
        Me.tbrt_ars.UseStyleColors = True
        Me.tbrt_ars.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbrt_ars.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel8.Location = New System.Drawing.Point(168, 216)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel8.TabIndex = 128
        Me.MetroLabel8.Text = "Berat Isi"
        '
        'MetroButton1
        '
        Me.MetroButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton1.Location = New System.Drawing.Point(240, 157)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(42, 19)
        Me.MetroButton1.TabIndex = 142
        Me.MetroButton1.Text = "CARI"
        Me.MetroButton1.UseSelectable = True
        '
        'Finish_Goods_Arsip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 373)
        Me.Controls.Add(Me.cbox_unit)
        Me.Controls.Add(Me.tbrt_ars)
        Me.Controls.Add(Me.tdt_ars)
        Me.Controls.Add(Me.tka_ars)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.MetroLabel30)
        Me.Controls.Add(Me.tCari1)
        Me.Controls.Add(Me.tvariety)
        Me.Controls.Add(Me.tno_lab)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.tkardus_ars)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Name = "Finish_Goods_Arsip"
        Me.Padding = New System.Windows.Forms.Padding(20, 70, 20, 20)
        Me.Text = "Finish Good Archives"
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDelete As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEdit As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel30 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tCari1 As MetroFramework.Controls.MetroTile
    Friend WithEvents tvariety As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tno_lab As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tkardus_ars As MetroFramework.Controls.MetroTextBox
    Friend WithEvents texpdate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tnojob As System.Windows.Forms.TextBox
    Friend WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
    Public WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tka_ars As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tdt_ars As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cbox_unit As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tbrt_ars As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
End Class
