﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sample_Test_Control_P
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
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton
        Me.btnEdit = New MetroFramework.Controls.MetroButton
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel
        Me.tdatehvs = New System.Windows.Forms.MaskedTextBox
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile
        Me.tcls = New MetroFramework.Controls.MetroTextBox
        Me.tweight = New MetroFramework.Controls.MetroTextBox
        Me.tnojob = New MetroFramework.Controls.MetroTextBox
        Me.tnomnl = New MetroFramework.Controls.MetroTextBox
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel
        Me.tvariety = New MetroFramework.Controls.MetroTextBox
        Me.tnolab = New MetroFramework.Controls.MetroTextBox
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel
        Me.Tdate = New System.Windows.Forms.MaskedTextBox
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel3.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(23, 228)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(85, 19)
        Me.MetroLabel7.TabIndex = 165
        Me.MetroLabel7.Text = "dd-MM-yyyy"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(125, 228)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel6.TabIndex = 164
        Me.MetroLabel6.Text = "Time"
        '
        'MetroButton1
        '
        Me.MetroButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton1.DisplayFocus = True
        Me.MetroButton1.Location = New System.Drawing.Point(500, 218)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(79, 29)
        Me.MetroButton1.TabIndex = 162
        Me.MetroButton1.Text = "Kosongkan"
        Me.MetroButton1.UseSelectable = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.DisplayFocus = True
        Me.btnEdit.Location = New System.Drawing.Point(415, 218)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(79, 29)
        Me.btnEdit.TabIndex = 163
        Me.btnEdit.Text = "&Cek Date"
        Me.btnEdit.UseSelectable = True
        '
        'Timer1
        '
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        Me.MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Green
        '
        'MetroPanel3
        '
        Me.MetroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel3.Controls.Add(Me.tdatehvs)
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(415, 106)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.MetroPanel3.Size = New System.Drawing.Size(116, 23)
        Me.MetroPanel3.TabIndex = 176
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
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.Location = New System.Drawing.Point(217, 106)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(46, 23)
        Me.MetroTile1.TabIndex = 180
        Me.MetroTile1.Text = "Cari"
        Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.MetroTile1.UseSelectable = True
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
        Me.tcls.Location = New System.Drawing.Point(415, 164)
        Me.tcls.MaxLength = 32767
        Me.tcls.Name = "tcls"
        Me.tcls.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tcls.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tcls.SelectedText = ""
        Me.tcls.SelectionLength = 0
        Me.tcls.SelectionStart = 0
        Me.tcls.Size = New System.Drawing.Size(116, 23)
        Me.tcls.TabIndex = 178
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
        Me.tweight.Location = New System.Drawing.Point(415, 135)
        Me.tweight.MaxLength = 32767
        Me.tweight.Name = "tweight"
        Me.tweight.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tweight.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tweight.SelectedText = ""
        Me.tweight.SelectionLength = 0
        Me.tweight.SelectionStart = 0
        Me.tweight.Size = New System.Drawing.Size(116, 23)
        Me.tweight.TabIndex = 177
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
        Me.tnojob.CustomButton.Location = New System.Drawing.Point(54, 1)
        Me.tnojob.CustomButton.Name = ""
        Me.tnojob.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tnojob.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tnojob.CustomButton.TabIndex = 1
        Me.tnojob.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tnojob.CustomButton.UseSelectable = True
        Me.tnojob.CustomButton.Visible = False
        Me.tnojob.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tnojob.Lines = New String(-1) {}
        Me.tnojob.Location = New System.Drawing.Point(135, 164)
        Me.tnojob.MaxLength = 32767
        Me.tnojob.Name = "tnojob"
        Me.tnojob.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tnojob.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tnojob.SelectedText = ""
        Me.tnojob.SelectionLength = 0
        Me.tnojob.SelectionStart = 0
        Me.tnojob.Size = New System.Drawing.Size(76, 23)
        Me.tnojob.TabIndex = 175
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
        Me.tnomnl.Location = New System.Drawing.Point(97, 164)
        Me.tnomnl.Margin = New System.Windows.Forms.Padding(3, 3, 2, 3)
        Me.tnomnl.MaxLength = 32767
        Me.tnomnl.Name = "tnomnl"
        Me.tnomnl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tnomnl.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tnomnl.SelectedText = ""
        Me.tnomnl.SelectionLength = 0
        Me.tnomnl.SelectionStart = 0
        Me.tnomnl.Size = New System.Drawing.Size(33, 23)
        Me.tnomnl.TabIndex = 174
        Me.tnomnl.UseSelectable = True
        Me.tnomnl.UseStyleColors = True
        Me.tnomnl.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tnomnl.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel10.Location = New System.Drawing.Point(325, 168)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(40, 19)
        Me.MetroLabel10.TabIndex = 173
        Me.MetroLabel10.Text = "Class"
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
        Me.tvariety.Location = New System.Drawing.Point(97, 134)
        Me.tvariety.MaxLength = 32767
        Me.tvariety.Name = "tvariety"
        Me.tvariety.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tvariety.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tvariety.SelectedText = ""
        Me.tvariety.SelectionLength = 0
        Me.tvariety.SelectionStart = 0
        Me.tvariety.Size = New System.Drawing.Size(114, 23)
        Me.tvariety.TabIndex = 172
        Me.tvariety.UseSelectable = True
        Me.tvariety.UseStyleColors = True
        Me.tvariety.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tvariety.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tnolab
        '
        '
        '
        '
        Me.tnolab.CustomButton.Image = Nothing
        Me.tnolab.CustomButton.Location = New System.Drawing.Point(92, 1)
        Me.tnolab.CustomButton.Name = ""
        Me.tnolab.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tnolab.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tnolab.CustomButton.TabIndex = 1
        Me.tnolab.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tnolab.CustomButton.UseSelectable = True
        Me.tnolab.CustomButton.Visible = False
        Me.tnolab.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tnolab.Lines = New String(-1) {}
        Me.tnolab.Location = New System.Drawing.Point(97, 106)
        Me.tnolab.MaxLength = 32767
        Me.tnolab.Name = "tnolab"
        Me.tnolab.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tnolab.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tnolab.SelectedText = ""
        Me.tnolab.SelectionLength = 0
        Me.tnolab.SelectionStart = 0
        Me.tnolab.Size = New System.Drawing.Size(114, 23)
        Me.tnolab.TabIndex = 171
        Me.tnolab.UseSelectable = True
        Me.tnolab.UseStyleColors = True
        Me.tnolab.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tnolab.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(325, 138)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel5.TabIndex = 170
        Me.MetroLabel5.Text = "Weight (kg)"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(325, 110)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel4.TabIndex = 169
        Me.MetroLabel4.Text = "Harvest Date"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 168)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel3.TabIndex = 168
        Me.MetroLabel3.Text = "Job No."
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 138)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel2.TabIndex = 167
        Me.MetroLabel2.Text = "Variety"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 110)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel1.TabIndex = 166
        Me.MetroLabel1.Text = "Lab No."
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel19.Location = New System.Drawing.Point(23, 70)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(104, 19)
        Me.MetroLabel19.TabIndex = 182
        Me.MetroLabel19.Text = "Sample Identity"
        Me.MetroLabel19.UseStyleColors = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel1.Controls.Add(Me.Tdate)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(97, 193)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.MetroPanel1.Size = New System.Drawing.Size(116, 23)
        Me.MetroPanel1.TabIndex = 184
        Me.MetroPanel1.UseStyleColors = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'Tdate
        '
        Me.Tdate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tdate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tdate.Location = New System.Drawing.Point(1, 1)
        Me.Tdate.Mask = "00/00/0000"
        Me.Tdate.Name = "Tdate"
        Me.Tdate.Size = New System.Drawing.Size(112, 18)
        Me.Tdate.TabIndex = 20
        Me.Tdate.TabStop = False
        Me.Tdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Tdate.ValidatingType = GetType(Date)
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel8.Location = New System.Drawing.Point(23, 197)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel8.TabIndex = 183
        Me.MetroLabel8.Text = "Date"
        '
        'Sample_Test_Control_P
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 283)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel19)
        Me.Controls.Add(Me.MetroPanel3)
        Me.Controls.Add(Me.MetroTile1)
        Me.Controls.Add(Me.tcls)
        Me.Controls.Add(Me.tweight)
        Me.Controls.Add(Me.tnojob)
        Me.Controls.Add(Me.tnomnl)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.tvariety)
        Me.Controls.Add(Me.tnolab)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btnEdit)
        Me.Name = "Sample_Test_Control_P"
        Me.Padding = New System.Windows.Forms.Padding(20, 70, 20, 20)
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Sample Test Control P"
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel3.ResumeLayout(False)
        Me.MetroPanel3.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEdit As MetroFramework.Controls.MetroButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents tdatehvs As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents tcls As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tweight As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tnojob As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tnomnl As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tvariety As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tnolab As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents Tdate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
End Class
