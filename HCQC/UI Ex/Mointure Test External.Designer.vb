<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mointure_Test_External
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton
        Me.tTgl_mt = New System.Windows.Forms.MaskedTextBox
        Me.MetroPanel4 = New MetroFramework.Controls.MetroPanel
        Me.btnDelete = New MetroFramework.Controls.MetroButton
        Me.btnEdit = New MetroFramework.Controls.MetroButton
        Me.btnSave = New MetroFramework.Controls.MetroButton
        Me.MetroLabel30 = New MetroFramework.Controls.MetroLabel
        Me.tCari1 = New MetroFramework.Controls.MetroTile
        Me.tnojob = New MetroFramework.Controls.MetroTextBox
        Me.tnomnl = New MetroFramework.Controls.MetroTextBox
        Me.tvariety = New MetroFramework.Controls.MetroTextBox
        Me.tno_lab = New MetroFramework.Controls.MetroTextBox
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel
        Me.tanalys = New MetroFramework.Controls.MetroTextBox
        Me.tmt_avrg = New MetroFramework.Controls.MetroTextBox
        Me.tmt2 = New MetroFramework.Controls.MetroTextBox
        Me.tmt1 = New MetroFramework.Controls.MetroTextBox
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid
        Me.MetroPanel4.SuspendLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroButton2
        '
        Me.MetroButton2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Add
        Me.MetroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MetroButton2.Location = New System.Drawing.Point(257, 111)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(36, 23)
        Me.MetroButton2.TabIndex = 144
        Me.MetroButton2.UseSelectable = True
        '
        'tTgl_mt
        '
        Me.tTgl_mt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tTgl_mt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tTgl_mt.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tTgl_mt.Location = New System.Drawing.Point(1, 1)
        Me.tTgl_mt.Mask = "00/00/0000"
        Me.tTgl_mt.Name = "tTgl_mt"
        Me.tTgl_mt.Size = New System.Drawing.Size(118, 19)
        Me.tTgl_mt.TabIndex = 8
        Me.tTgl_mt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tTgl_mt.ValidatingType = GetType(Date)
        '
        'MetroPanel4
        '
        Me.MetroPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel4.Controls.Add(Me.tTgl_mt)
        Me.MetroPanel4.HorizontalScrollbarBarColor = True
        Me.MetroPanel4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.HorizontalScrollbarSize = 10
        Me.MetroPanel4.Location = New System.Drawing.Point(178, 238)
        Me.MetroPanel4.Name = "MetroPanel4"
        Me.MetroPanel4.Padding = New System.Windows.Forms.Padding(1)
        Me.MetroPanel4.Size = New System.Drawing.Size(122, 23)
        Me.MetroPanel4.TabIndex = 133
        Me.MetroPanel4.TabStop = True
        Me.MetroPanel4.UseStyleColors = True
        Me.MetroPanel4.VerticalScrollbarBarColor = True
        Me.MetroPanel4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.VerticalScrollbarSize = 10
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(625, 267)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(79, 29)
        Me.btnDelete.TabIndex = 137
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseSelectable = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Enabled = False
        Me.btnEdit.Location = New System.Drawing.Point(543, 267)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(79, 29)
        Me.btnEdit.TabIndex = 136
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseSelectable = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(543, 216)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(161, 45)
        Me.btnSave.TabIndex = 135
        Me.btnSave.Text = "Save"
        Me.btnSave.UseSelectable = True
        '
        'MetroLabel30
        '
        Me.MetroLabel30.AutoSize = True
        Me.MetroLabel30.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel30.Location = New System.Drawing.Point(74, 78)
        Me.MetroLabel30.Name = "MetroLabel30"
        Me.MetroLabel30.Size = New System.Drawing.Size(114, 19)
        Me.MetroLabel30.TabIndex = 142
        Me.MetroLabel30.Text = "Sample Identity"
        Me.MetroLabel30.UseStyleColors = True
        '
        'tCari1
        '
        Me.tCari1.ActiveControl = Nothing
        Me.tCari1.Location = New System.Drawing.Point(205, 111)
        Me.tCari1.Name = "tCari1"
        Me.tCari1.Size = New System.Drawing.Size(46, 23)
        Me.tCari1.TabIndex = 141
        Me.tCari1.Text = "Cari"
        Me.tCari1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.tCari1.UseSelectable = True
        '
        'tnojob
        '
        '
        '
        '
        Me.tnojob.CustomButton.Image = Nothing
        Me.tnojob.CustomButton.Location = New System.Drawing.Point(77, 1)
        Me.tnojob.CustomButton.Name = ""
        Me.tnojob.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tnojob.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tnojob.CustomButton.TabIndex = 1
        Me.tnojob.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tnojob.CustomButton.UseSelectable = True
        Me.tnojob.CustomButton.Visible = False
        Me.tnojob.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tnojob.Lines = New String(-1) {}
        Me.tnojob.Location = New System.Drawing.Point(605, 111)
        Me.tnojob.MaxLength = 32767
        Me.tnojob.Name = "tnojob"
        Me.tnojob.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tnojob.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tnojob.SelectedText = ""
        Me.tnojob.SelectionLength = 0
        Me.tnojob.SelectionStart = 0
        Me.tnojob.Size = New System.Drawing.Size(99, 23)
        Me.tnojob.TabIndex = 129
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
        Me.tnomnl.Location = New System.Drawing.Point(567, 111)
        Me.tnomnl.Margin = New System.Windows.Forms.Padding(3, 3, 2, 3)
        Me.tnomnl.MaxLength = 32767
        Me.tnomnl.Name = "tnomnl"
        Me.tnomnl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tnomnl.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tnomnl.SelectedText = ""
        Me.tnomnl.SelectionLength = 0
        Me.tnomnl.SelectionStart = 0
        Me.tnomnl.Size = New System.Drawing.Size(33, 23)
        Me.tnomnl.TabIndex = 127
        Me.tnomnl.UseSelectable = True
        Me.tnomnl.UseStyleColors = True
        Me.tnomnl.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tnomnl.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.tvariety.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tvariety.Lines = New String(-1) {}
        Me.tvariety.Location = New System.Drawing.Point(367, 111)
        Me.tvariety.MaxLength = 32767
        Me.tvariety.Name = "tvariety"
        Me.tvariety.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tvariety.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tvariety.SelectedText = ""
        Me.tvariety.SelectionLength = 0
        Me.tvariety.SelectionStart = 0
        Me.tvariety.Size = New System.Drawing.Size(114, 23)
        Me.tvariety.TabIndex = 126
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
        Me.tno_lab.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tno_lab.Lines = New String(-1) {}
        Me.tno_lab.Location = New System.Drawing.Point(85, 111)
        Me.tno_lab.MaxLength = 32767
        Me.tno_lab.Name = "tno_lab"
        Me.tno_lab.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tno_lab.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tno_lab.SelectedText = ""
        Me.tno_lab.SelectionLength = 0
        Me.tno_lab.SelectionStart = 0
        Me.tno_lab.Size = New System.Drawing.Size(114, 23)
        Me.tno_lab.TabIndex = 123
        Me.tno_lab.UseSelectable = True
        Me.tno_lab.UseStyleColors = True
        Me.tno_lab.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tno_lab.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(505, 115)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel5.TabIndex = 140
        Me.MetroLabel5.Text = "No. Job"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel6.Location = New System.Drawing.Point(305, 115)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel6.TabIndex = 139
        Me.MetroLabel6.Text = "Variety"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel7.Location = New System.Drawing.Point(23, 115)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel7.TabIndex = 138
        Me.MetroLabel7.Text = "No. Lab"
        '
        'tanalys
        '
        '
        '
        '
        Me.tanalys.CustomButton.Image = Nothing
        Me.tanalys.CustomButton.Location = New System.Drawing.Point(100, 1)
        Me.tanalys.CustomButton.Name = ""
        Me.tanalys.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tanalys.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tanalys.CustomButton.TabIndex = 1
        Me.tanalys.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tanalys.CustomButton.UseSelectable = True
        Me.tanalys.CustomButton.Visible = False
        Me.tanalys.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tanalys.Lines = New String(-1) {}
        Me.tanalys.Location = New System.Drawing.Point(178, 273)
        Me.tanalys.MaxLength = 32767
        Me.tanalys.Name = "tanalys"
        Me.tanalys.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tanalys.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tanalys.SelectedText = ""
        Me.tanalys.SelectionLength = 0
        Me.tanalys.SelectionStart = 0
        Me.tanalys.Size = New System.Drawing.Size(122, 23)
        Me.tanalys.TabIndex = 134
        Me.tanalys.UseSelectable = True
        Me.tanalys.UseStyleColors = True
        Me.tanalys.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tanalys.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tmt_avrg
        '
        '
        '
        '
        Me.tmt_avrg.CustomButton.Image = Nothing
        Me.tmt_avrg.CustomButton.Location = New System.Drawing.Point(100, 1)
        Me.tmt_avrg.CustomButton.Name = ""
        Me.tmt_avrg.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tmt_avrg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tmt_avrg.CustomButton.TabIndex = 1
        Me.tmt_avrg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tmt_avrg.CustomButton.UseSelectable = True
        Me.tmt_avrg.CustomButton.Visible = False
        Me.tmt_avrg.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tmt_avrg.Lines = New String(-1) {}
        Me.tmt_avrg.Location = New System.Drawing.Point(178, 204)
        Me.tmt_avrg.MaxLength = 32767
        Me.tmt_avrg.Name = "tmt_avrg"
        Me.tmt_avrg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tmt_avrg.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tmt_avrg.SelectedText = ""
        Me.tmt_avrg.SelectionLength = 0
        Me.tmt_avrg.SelectionStart = 0
        Me.tmt_avrg.Size = New System.Drawing.Size(122, 23)
        Me.tmt_avrg.TabIndex = 132
        Me.tmt_avrg.UseSelectable = True
        Me.tmt_avrg.UseStyleColors = True
        Me.tmt_avrg.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tmt_avrg.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tmt2
        '
        '
        '
        '
        Me.tmt2.CustomButton.Image = Nothing
        Me.tmt2.CustomButton.Location = New System.Drawing.Point(36, 1)
        Me.tmt2.CustomButton.Name = ""
        Me.tmt2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tmt2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tmt2.CustomButton.TabIndex = 1
        Me.tmt2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tmt2.CustomButton.UseSelectable = True
        Me.tmt2.CustomButton.Visible = False
        Me.tmt2.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tmt2.Lines = New String(-1) {}
        Me.tmt2.Location = New System.Drawing.Point(242, 175)
        Me.tmt2.MaxLength = 32767
        Me.tmt2.Name = "tmt2"
        Me.tmt2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tmt2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tmt2.SelectedText = ""
        Me.tmt2.SelectionLength = 0
        Me.tmt2.SelectionStart = 0
        Me.tmt2.Size = New System.Drawing.Size(58, 23)
        Me.tmt2.TabIndex = 131
        Me.tmt2.UseSelectable = True
        Me.tmt2.UseStyleColors = True
        Me.tmt2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tmt2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tmt1
        '
        '
        '
        '
        Me.tmt1.CustomButton.Image = Nothing
        Me.tmt1.CustomButton.Location = New System.Drawing.Point(36, 1)
        Me.tmt1.CustomButton.Name = ""
        Me.tmt1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tmt1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tmt1.CustomButton.TabIndex = 1
        Me.tmt1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tmt1.CustomButton.UseSelectable = True
        Me.tmt1.CustomButton.Visible = False
        Me.tmt1.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tmt1.Lines = New String(-1) {}
        Me.tmt1.Location = New System.Drawing.Point(178, 175)
        Me.tmt1.MaxLength = 32767
        Me.tmt1.Name = "tmt1"
        Me.tmt1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tmt1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tmt1.SelectedText = ""
        Me.tmt1.SelectionLength = 0
        Me.tmt1.SelectionStart = 0
        Me.tmt1.Size = New System.Drawing.Size(58, 23)
        Me.tmt1.TabIndex = 130
        Me.tmt1.UseSelectable = True
        Me.tmt1.UseStyleColors = True
        Me.tmt1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tmt1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(23, 277)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel4.TabIndex = 128
        Me.MetroLabel4.Text = "Analyst"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 248)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel3.TabIndex = 125
        Me.MetroLabel3.Text = "Test Date"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 208)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(136, 19)
        Me.MetroLabel2.TabIndex = 124
        Me.MetroLabel2.Text = "Moisture Average (%)"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 179)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(149, 19)
        Me.MetroLabel1.TabIndex = 122
        Me.MetroLabel1.Text = "Moisture Rate 1 && 2 (%)"
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToResizeRows = False
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
        Me.MetroGrid1.Location = New System.Drawing.Point(23, 360)
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
        Me.MetroGrid1.Size = New System.Drawing.Size(684, 225)
        Me.MetroGrid1.TabIndex = 145
        '
        'Mointure_Test_External
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 608)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroPanel4)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.MetroLabel30)
        Me.Controls.Add(Me.tCari1)
        Me.Controls.Add(Me.tnojob)
        Me.Controls.Add(Me.tnomnl)
        Me.Controls.Add(Me.tvariety)
        Me.Controls.Add(Me.tno_lab)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.tanalys)
        Me.Controls.Add(Me.tmt_avrg)
        Me.Controls.Add(Me.tmt2)
        Me.Controls.Add(Me.tmt1)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "Mointure_Test_External"
        Me.Padding = New System.Windows.Forms.Padding(20, 70, 20, 20)
        Me.ShowIcon = False
        Me.Text = "Mointure Test External"
        Me.MetroPanel4.ResumeLayout(False)
        Me.MetroPanel4.PerformLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents tTgl_mt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MetroPanel4 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnDelete As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEdit As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel30 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tCari1 As MetroFramework.Controls.MetroTile
    Friend WithEvents tnojob As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tnomnl As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tvariety As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tno_lab As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tanalys As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tmt_avrg As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tmt2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tmt1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
End Class
