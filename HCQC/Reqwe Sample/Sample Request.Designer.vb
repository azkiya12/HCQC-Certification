<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sample_Request
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel
        Me.tdatehvs = New System.Windows.Forms.MaskedTextBox
        Me.btnCari2 = New MetroFramework.Controls.MetroTile
        Me.btnDelete = New MetroFramework.Controls.MetroButton
        Me.btnEdit = New MetroFramework.Controls.MetroButton
        Me.btnSave = New MetroFramework.Controls.MetroButton
        Me.chkRepro = New MetroFramework.Controls.MetroCheckBox
        Me.chkWIP = New MetroFramework.Controls.MetroCheckBox
        Me.tcls = New MetroFramework.Controls.MetroTextBox
        Me.tweight = New MetroFramework.Controls.MetroTextBox
        Me.tnojob = New MetroFramework.Controls.MetroTextBox
        Me.tnomnl = New MetroFramework.Controls.MetroTextBox
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel
        Me.tvariety = New MetroFramework.Controls.MetroTextBox
        Me.tnolab = New MetroFramework.Controls.MetroTextBox
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel
        Me.chkDT = New MetroFramework.Controls.MetroCheckBox
        Me.chkRaf = New MetroFramework.Controls.MetroCheckBox
        Me.chkKA = New MetroFramework.Controls.MetroCheckBox
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel
        Me.tPPC2 = New MetroFramework.Controls.MetroTextBox
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel
        Me.tket = New MetroFramework.Controls.MetroTextBox
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid
        Me.NoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VarietyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NomnlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NojobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HvdtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReproDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UjikaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.UjiraDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.UjidtDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.KetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InbyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.input_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.update_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SplrqweBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_serverDataSet = New WindowsApplication1.HCQC_serverDataSet
        Me.Spl_rqweTableAdapter = New WindowsApplication1.HCQC_serverDataSetTableAdapters.spl_rqweTableAdapter
        Me.MetroPanel3.SuspendLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplrqweBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroButton2
        '
        Me.MetroButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Add
        Me.MetroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MetroButton2.Location = New System.Drawing.Point(834, 31)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(36, 23)
        Me.MetroButton2.TabIndex = 142
        Me.MetroButton2.UseSelectable = True
        '
        'MetroPanel3
        '
        Me.MetroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel3.Controls.Add(Me.tdatehvs)
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(122, 165)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.MetroPanel3.Size = New System.Drawing.Size(116, 23)
        Me.MetroPanel3.TabIndex = 132
        Me.MetroPanel3.UseStyleColors = True
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'tdatehvs
        '
        Me.tdatehvs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tdatehvs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tdatehvs.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdatehvs.Location = New System.Drawing.Point(1, 1)
        Me.tdatehvs.Mask = "00/00/0000"
        Me.tdatehvs.Name = "tdatehvs"
        Me.tdatehvs.Size = New System.Drawing.Size(112, 18)
        Me.tdatehvs.TabIndex = 20
        Me.tdatehvs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tdatehvs.ValidatingType = GetType(Date)
        '
        'btnCari2
        '
        Me.btnCari2.ActiveControl = Nothing
        Me.btnCari2.Location = New System.Drawing.Point(242, 135)
        Me.btnCari2.Name = "btnCari2"
        Me.btnCari2.Size = New System.Drawing.Size(46, 23)
        Me.btnCari2.TabIndex = 137
        Me.btnCari2.TabStop = False
        Me.btnCari2.Text = "Cari"
        Me.btnCari2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnCari2.UseSelectable = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.DisplayFocus = True
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(791, 159)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(79, 29)
        Me.btnDelete.TabIndex = 140
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseSelectable = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.DisplayFocus = True
        Me.btnEdit.Enabled = False
        Me.btnEdit.Location = New System.Drawing.Point(709, 159)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(79, 29)
        Me.btnEdit.TabIndex = 139
        Me.btnEdit.Text = "Update"
        Me.btnEdit.UseSelectable = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.DisplayFocus = True
        Me.btnSave.Location = New System.Drawing.Point(709, 108)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(161, 45)
        Me.btnSave.TabIndex = 138
        Me.btnSave.Text = "Save"
        Me.btnSave.UseSelectable = True
        '
        'chkRepro
        '
        Me.chkRepro.AutoSize = True
        Me.chkRepro.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkRepro.Location = New System.Drawing.Point(560, 140)
        Me.chkRepro.Name = "chkRepro"
        Me.chkRepro.Size = New System.Drawing.Size(61, 19)
        Me.chkRepro.TabIndex = 135
        Me.chkRepro.Text = "Repro"
        Me.chkRepro.UseSelectable = True
        Me.chkRepro.UseStyleColors = True
        '
        'chkWIP
        '
        Me.chkWIP.AutoSize = True
        Me.chkWIP.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkWIP.Location = New System.Drawing.Point(560, 169)
        Me.chkWIP.Name = "chkWIP"
        Me.chkWIP.Size = New System.Drawing.Size(63, 19)
        Me.chkWIP.TabIndex = 136
        Me.chkWIP.Text = "WIP V"
        Me.chkWIP.UseSelectable = True
        Me.chkWIP.UseStyleColors = True
        '
        'tcls
        '
        '
        '
        '
        Me.tcls.CustomButton.Image = Nothing
        Me.tcls.CustomButton.Location = New System.Drawing.Point(94, 1)
        Me.tcls.CustomButton.Name = ""
        Me.tcls.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tcls.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tcls.CustomButton.TabIndex = 1
        Me.tcls.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tcls.CustomButton.UseSelectable = True
        Me.tcls.CustomButton.Visible = False
        Me.tcls.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tcls.Lines = New String(-1) {}
        Me.tcls.Location = New System.Drawing.Point(424, 136)
        Me.tcls.MaxLength = 32767
        Me.tcls.Name = "tcls"
        Me.tcls.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tcls.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tcls.SelectedText = ""
        Me.tcls.SelectionLength = 0
        Me.tcls.SelectionStart = 0
        Me.tcls.Size = New System.Drawing.Size(116, 23)
        Me.tcls.TabIndex = 134
        Me.tcls.UseSelectable = True
        Me.tcls.UseStyleColors = True
        Me.tcls.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tcls.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tweight
        '
        '
        '
        '
        Me.tweight.CustomButton.Image = Nothing
        Me.tweight.CustomButton.Location = New System.Drawing.Point(94, 1)
        Me.tweight.CustomButton.Name = ""
        Me.tweight.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tweight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tweight.CustomButton.TabIndex = 1
        Me.tweight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tweight.CustomButton.UseSelectable = True
        Me.tweight.CustomButton.Visible = False
        Me.tweight.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tweight.Lines = New String(-1) {}
        Me.tweight.Location = New System.Drawing.Point(424, 107)
        Me.tweight.MaxLength = 32767
        Me.tweight.Name = "tweight"
        Me.tweight.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tweight.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tweight.SelectedText = ""
        Me.tweight.SelectionLength = 0
        Me.tweight.SelectionStart = 0
        Me.tweight.Size = New System.Drawing.Size(116, 23)
        Me.tweight.TabIndex = 133
        Me.tweight.UseSelectable = True
        Me.tweight.UseStyleColors = True
        Me.tweight.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tweight.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tnojob
        '
        '
        '
        '
        Me.tnojob.CustomButton.Image = Nothing
        Me.tnojob.CustomButton.Location = New System.Drawing.Point(56, 1)
        Me.tnojob.CustomButton.Name = ""
        Me.tnojob.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tnojob.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tnojob.CustomButton.TabIndex = 1
        Me.tnojob.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tnojob.CustomButton.UseSelectable = True
        Me.tnojob.CustomButton.Visible = False
        Me.tnojob.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tnojob.Lines = New String(-1) {}
        Me.tnojob.Location = New System.Drawing.Point(160, 135)
        Me.tnojob.Margin = New System.Windows.Forms.Padding(3, 3, 2, 3)
        Me.tnojob.MaxLength = 32767
        Me.tnojob.Name = "tnojob"
        Me.tnojob.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tnojob.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tnojob.SelectedText = ""
        Me.tnojob.SelectionLength = 0
        Me.tnojob.SelectionStart = 0
        Me.tnojob.Size = New System.Drawing.Size(78, 23)
        Me.tnojob.TabIndex = 131
        Me.tnojob.UseSelectable = True
        Me.tnojob.UseStyleColors = True
        Me.tnojob.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tnojob.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tnomnl
        '
        '
        '
        '
        Me.tnomnl.CustomButton.Image = Nothing
        Me.tnomnl.CustomButton.Location = New System.Drawing.Point(11, 1)
        Me.tnomnl.CustomButton.Name = ""
        Me.tnomnl.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tnomnl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tnomnl.CustomButton.TabIndex = 1
        Me.tnomnl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tnomnl.CustomButton.UseSelectable = True
        Me.tnomnl.CustomButton.Visible = False
        Me.tnomnl.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tnomnl.Lines = New String(-1) {}
        Me.tnomnl.Location = New System.Drawing.Point(122, 135)
        Me.tnomnl.Margin = New System.Windows.Forms.Padding(3, 3, 2, 3)
        Me.tnomnl.MaxLength = 32767
        Me.tnomnl.Name = "tnomnl"
        Me.tnomnl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tnomnl.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tnomnl.SelectedText = ""
        Me.tnomnl.SelectionLength = 0
        Me.tnomnl.SelectionStart = 0
        Me.tnomnl.Size = New System.Drawing.Size(33, 23)
        Me.tnomnl.TabIndex = 130
        Me.tnomnl.UseSelectable = True
        Me.tnomnl.UseStyleColors = True
        Me.tnomnl.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tnomnl.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel18.Location = New System.Drawing.Point(23, 70)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(104, 19)
        Me.MetroLabel18.TabIndex = 129
        Me.MetroLabel18.Text = "Sample Identity"
        Me.MetroLabel18.UseStyleColors = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel10.Location = New System.Drawing.Point(334, 140)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(40, 19)
        Me.MetroLabel10.TabIndex = 128
        Me.MetroLabel10.Text = "Class"
        '
        'tvariety
        '
        '
        '
        '
        Me.tvariety.CustomButton.Image = Nothing
        Me.tvariety.CustomButton.Location = New System.Drawing.Point(94, 1)
        Me.tvariety.CustomButton.Name = ""
        Me.tvariety.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tvariety.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tvariety.CustomButton.TabIndex = 1
        Me.tvariety.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tvariety.CustomButton.UseSelectable = True
        Me.tvariety.CustomButton.Visible = False
        Me.tvariety.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tvariety.Lines = New String(-1) {}
        Me.tvariety.Location = New System.Drawing.Point(122, 107)
        Me.tvariety.MaxLength = 32767
        Me.tvariety.Name = "tvariety"
        Me.tvariety.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tvariety.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tvariety.SelectedText = ""
        Me.tvariety.SelectionLength = 0
        Me.tvariety.SelectionStart = 0
        Me.tvariety.Size = New System.Drawing.Size(116, 23)
        Me.tvariety.TabIndex = 127
        Me.tvariety.UseSelectable = True
        Me.tvariety.UseStyleColors = True
        Me.tvariety.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tvariety.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tnolab
        '
        Me.tnolab.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tnolab.CustomButton.Image = Nothing
        Me.tnolab.CustomButton.Location = New System.Drawing.Point(119, 1)
        Me.tnolab.CustomButton.Name = ""
        Me.tnolab.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tnolab.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tnolab.CustomButton.TabIndex = 1
        Me.tnolab.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tnolab.CustomButton.UseSelectable = True
        Me.tnolab.Icon = Global.WindowsApplication1.My.Resources.Resources.Find
        Me.tnolab.Lines = New String(-1) {}
        Me.tnolab.Location = New System.Drawing.Point(687, 31)
        Me.tnolab.MaxLength = 32767
        Me.tnolab.Multiline = True
        Me.tnolab.Name = "tnolab"
        Me.tnolab.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tnolab.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tnolab.SelectedText = ""
        Me.tnolab.SelectionLength = 0
        Me.tnolab.SelectionStart = 0
        Me.tnolab.ShowButton = True
        Me.tnolab.Size = New System.Drawing.Size(141, 23)
        Me.tnolab.TabIndex = 126
        Me.tnolab.UseSelectable = True
        Me.tnolab.UseStyleColors = True
        Me.tnolab.WaterMark = "Search ID Number"
        Me.tnolab.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tnolab.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(334, 110)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel5.TabIndex = 125
        Me.MetroLabel5.Text = "Weight (kg)"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(32, 169)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel4.TabIndex = 124
        Me.MetroLabel4.Text = "Harvest Date"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(32, 139)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel3.TabIndex = 123
        Me.MetroLabel3.Text = "Job No."
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(32, 111)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel2.TabIndex = 122
        Me.MetroLabel2.Text = "Variety"
        '
        'chkDT
        '
        Me.chkDT.AutoSize = True
        Me.chkDT.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkDT.Location = New System.Drawing.Point(367, 307)
        Me.chkDT.Name = "chkDT"
        Me.chkDT.Size = New System.Drawing.Size(101, 19)
        Me.chkDT.TabIndex = 146
        Me.chkDT.Text = "Germination"
        Me.chkDT.UseSelectable = True
        Me.chkDT.UseStyleColors = True
        '
        'chkRaf
        '
        Me.chkRaf.AutoSize = True
        Me.chkRaf.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkRaf.Location = New System.Drawing.Point(367, 282)
        Me.chkRaf.Name = "chkRaf"
        Me.chkRaf.Size = New System.Drawing.Size(127, 19)
        Me.chkRaf.TabIndex = 145
        Me.chkRaf.Text = "Purity/Refraction"
        Me.chkRaf.UseSelectable = True
        Me.chkRaf.UseStyleColors = True
        '
        'chkKA
        '
        Me.chkKA.AutoSize = True
        Me.chkKA.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkKA.Location = New System.Drawing.Point(367, 256)
        Me.chkKA.Name = "chkKA"
        Me.chkKA.Size = New System.Drawing.Size(80, 19)
        Me.chkKA.TabIndex = 144
        Me.chkKA.Text = "Moisture"
        Me.chkKA.UseSelectable = True
        Me.chkKA.UseStyleColors = True
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel12.Location = New System.Drawing.Point(340, 234)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(87, 19)
        Me.MetroLabel12.TabIndex = 143
        Me.MetroLabel12.Text = "Test Request"
        Me.MetroLabel12.UseStyleColors = True
        '
        'tPPC2
        '
        '
        '
        '
        Me.tPPC2.CustomButton.Image = Nothing
        Me.tPPC2.CustomButton.Location = New System.Drawing.Point(94, 1)
        Me.tPPC2.CustomButton.Name = ""
        Me.tPPC2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tPPC2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tPPC2.CustomButton.TabIndex = 1
        Me.tPPC2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tPPC2.CustomButton.UseSelectable = True
        Me.tPPC2.CustomButton.Visible = False
        Me.tPPC2.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tPPC2.Lines = New String(-1) {}
        Me.tPPC2.Location = New System.Drawing.Point(424, 165)
        Me.tPPC2.MaxLength = 32767
        Me.tPPC2.Name = "tPPC2"
        Me.tPPC2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tPPC2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tPPC2.SelectedText = ""
        Me.tPPC2.SelectionLength = 0
        Me.tPPC2.SelectionStart = 0
        Me.tPPC2.Size = New System.Drawing.Size(116, 23)
        Me.tPPC2.TabIndex = 147
        Me.tPPC2.UseSelectable = True
        Me.tPPC2.UseStyleColors = True
        Me.tPPC2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tPPC2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel17.Location = New System.Drawing.Point(334, 169)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel17.TabIndex = 148
        Me.MetroLabel17.Text = "Input by"
        '
        'tket
        '
        '
        '
        '
        Me.tket.CustomButton.Image = Nothing
        Me.tket.CustomButton.Location = New System.Drawing.Point(181, 2)
        Me.tket.CustomButton.Name = ""
        Me.tket.CustomButton.Size = New System.Drawing.Size(61, 61)
        Me.tket.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tket.CustomButton.TabIndex = 1
        Me.tket.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tket.CustomButton.UseSelectable = True
        Me.tket.CustomButton.Visible = False
        Me.tket.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tket.Lines = New String(-1) {}
        Me.tket.Location = New System.Drawing.Point(32, 256)
        Me.tket.MaxLength = 32767
        Me.tket.Multiline = True
        Me.tket.Name = "tket"
        Me.tket.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tket.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tket.SelectedText = ""
        Me.tket.SelectionLength = 0
        Me.tket.SelectionStart = 0
        Me.tket.Size = New System.Drawing.Size(245, 66)
        Me.tket.TabIndex = 150
        Me.tket.UseSelectable = True
        Me.tket.UseStyleColors = True
        Me.tket.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tket.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel16.Location = New System.Drawing.Point(32, 234)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel16.TabIndex = 149
        Me.MetroLabel16.Text = "Remark"
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToOrderColumns = True
        Me.MetroGrid1.AllowUserToResizeRows = False
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoidDataGridViewTextBoxColumn, Me.VarietyDataGridViewTextBoxColumn, Me.NomnlDataGridViewTextBoxColumn, Me.NojobDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.HvdtDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.ReproDataGridViewTextBoxColumn, Me.WipDataGridViewTextBoxColumn, Me.UjikaDataGridViewCheckBoxColumn, Me.UjiraDataGridViewCheckBoxColumn, Me.UjidtDataGridViewCheckBoxColumn, Me.KetDataGridViewTextBoxColumn, Me.InbyDataGridViewTextBoxColumn, Me.input_date, Me.update_date})
        Me.MetroGrid1.DataSource = Me.SplrqweBindingSource
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
        Me.MetroGrid1.Location = New System.Drawing.Point(32, 358)
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
        Me.MetroGrid1.Size = New System.Drawing.Size(838, 179)
        Me.MetroGrid1.TabIndex = 151
        '
        'NoidDataGridViewTextBoxColumn
        '
        Me.NoidDataGridViewTextBoxColumn.DataPropertyName = "no_id"
        Me.NoidDataGridViewTextBoxColumn.HeaderText = "ID No"
        Me.NoidDataGridViewTextBoxColumn.Name = "NoidDataGridViewTextBoxColumn"
        Me.NoidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VarietyDataGridViewTextBoxColumn
        '
        Me.VarietyDataGridViewTextBoxColumn.DataPropertyName = "variety"
        Me.VarietyDataGridViewTextBoxColumn.HeaderText = "Variety"
        Me.VarietyDataGridViewTextBoxColumn.Name = "VarietyDataGridViewTextBoxColumn"
        '
        'NomnlDataGridViewTextBoxColumn
        '
        Me.NomnlDataGridViewTextBoxColumn.DataPropertyName = "nomnl"
        Me.NomnlDataGridViewTextBoxColumn.HeaderText = "No. Manual"
        Me.NomnlDataGridViewTextBoxColumn.Name = "NomnlDataGridViewTextBoxColumn"
        '
        'NojobDataGridViewTextBoxColumn
        '
        Me.NojobDataGridViewTextBoxColumn.DataPropertyName = "nojob"
        Me.NojobDataGridViewTextBoxColumn.HeaderText = "Job No"
        Me.NojobDataGridViewTextBoxColumn.Name = "NojobDataGridViewTextBoxColumn"
        '
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "Class"
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        '
        'HvdtDataGridViewTextBoxColumn
        '
        Me.HvdtDataGridViewTextBoxColumn.DataPropertyName = "hv_dt"
        Me.HvdtDataGridViewTextBoxColumn.HeaderText = "Harvest"
        Me.HvdtDataGridViewTextBoxColumn.Name = "HvdtDataGridViewTextBoxColumn"
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "Weight(kg)"
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        '
        'ReproDataGridViewTextBoxColumn
        '
        Me.ReproDataGridViewTextBoxColumn.DataPropertyName = "repro"
        Me.ReproDataGridViewTextBoxColumn.HeaderText = "Repro"
        Me.ReproDataGridViewTextBoxColumn.Name = "ReproDataGridViewTextBoxColumn"
        '
        'WipDataGridViewTextBoxColumn
        '
        Me.WipDataGridViewTextBoxColumn.DataPropertyName = "wip"
        Me.WipDataGridViewTextBoxColumn.HeaderText = "wip"
        Me.WipDataGridViewTextBoxColumn.Name = "WipDataGridViewTextBoxColumn"
        '
        'UjikaDataGridViewCheckBoxColumn
        '
        Me.UjikaDataGridViewCheckBoxColumn.DataPropertyName = "uji_ka"
        Me.UjikaDataGridViewCheckBoxColumn.HeaderText = "uji_ka"
        Me.UjikaDataGridViewCheckBoxColumn.Name = "UjikaDataGridViewCheckBoxColumn"
        '
        'UjiraDataGridViewCheckBoxColumn
        '
        Me.UjiraDataGridViewCheckBoxColumn.DataPropertyName = "uji_ra"
        Me.UjiraDataGridViewCheckBoxColumn.HeaderText = "uji_ra"
        Me.UjiraDataGridViewCheckBoxColumn.Name = "UjiraDataGridViewCheckBoxColumn"
        '
        'UjidtDataGridViewCheckBoxColumn
        '
        Me.UjidtDataGridViewCheckBoxColumn.DataPropertyName = "uji_dt"
        Me.UjidtDataGridViewCheckBoxColumn.HeaderText = "uji_dt"
        Me.UjidtDataGridViewCheckBoxColumn.Name = "UjidtDataGridViewCheckBoxColumn"
        '
        'KetDataGridViewTextBoxColumn
        '
        Me.KetDataGridViewTextBoxColumn.DataPropertyName = "ket"
        Me.KetDataGridViewTextBoxColumn.HeaderText = "Keterangan"
        Me.KetDataGridViewTextBoxColumn.Name = "KetDataGridViewTextBoxColumn"
        '
        'InbyDataGridViewTextBoxColumn
        '
        Me.InbyDataGridViewTextBoxColumn.DataPropertyName = "in_by"
        Me.InbyDataGridViewTextBoxColumn.HeaderText = "Input by"
        Me.InbyDataGridViewTextBoxColumn.Name = "InbyDataGridViewTextBoxColumn"
        '
        'input_date
        '
        Me.input_date.DataPropertyName = "input_date"
        Me.input_date.HeaderText = "Input Date"
        Me.input_date.Name = "input_date"
        '
        'update_date
        '
        Me.update_date.DataPropertyName = "update_date"
        Me.update_date.HeaderText = "Update Date"
        Me.update_date.Name = "update_date"
        '
        'SplrqweBindingSource
        '
        Me.SplrqweBindingSource.DataMember = "spl_rqwe"
        Me.SplrqweBindingSource.DataSource = Me.HCQC_serverDataSet
        '
        'HCQC_serverDataSet
        '
        Me.HCQC_serverDataSet.DataSetName = "HCQC_serverDataSet"
        Me.HCQC_serverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Spl_rqweTableAdapter
        '
        Me.Spl_rqweTableAdapter.ClearBeforeFill = True
        '
        'Sample_Request
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 560)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Controls.Add(Me.tket)
        Me.Controls.Add(Me.MetroLabel16)
        Me.Controls.Add(Me.tPPC2)
        Me.Controls.Add(Me.MetroLabel17)
        Me.Controls.Add(Me.chkDT)
        Me.Controls.Add(Me.chkRaf)
        Me.Controls.Add(Me.chkKA)
        Me.Controls.Add(Me.MetroLabel12)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroPanel3)
        Me.Controls.Add(Me.btnCari2)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.chkRepro)
        Me.Controls.Add(Me.chkWIP)
        Me.Controls.Add(Me.tcls)
        Me.Controls.Add(Me.tweight)
        Me.Controls.Add(Me.tnojob)
        Me.Controls.Add(Me.tnomnl)
        Me.Controls.Add(Me.MetroLabel18)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.tvariety)
        Me.Controls.Add(Me.tnolab)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Name = "Sample_Request"
        Me.Padding = New System.Windows.Forms.Padding(20, 70, 20, 20)
        Me.Text = "Sampling Request"
        Me.MetroPanel3.ResumeLayout(False)
        Me.MetroPanel3.PerformLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplrqweBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents tdatehvs As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnCari2 As MetroFramework.Controls.MetroTile
    Friend WithEvents btnDelete As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEdit As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents chkRepro As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkWIP As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents tcls As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tweight As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tnojob As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tnomnl As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tvariety As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tnolab As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents chkDT As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkRaf As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkKA As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tPPC2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tket As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents HCQC_serverDataSet As WindowsApplication1.HCQC_serverDataSet
    Friend WithEvents SplrqweBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Spl_rqweTableAdapter As WindowsApplication1.HCQC_serverDataSetTableAdapters.spl_rqweTableAdapter
    Friend WithEvents NoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VarietyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomnlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NojobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HvdtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReproDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UjikaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents UjiraDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents UjidtDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents KetDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InbyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents input_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents update_date As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
