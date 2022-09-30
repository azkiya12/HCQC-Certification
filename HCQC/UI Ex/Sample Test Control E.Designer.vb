<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sample_Test_Control_E
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
        Me.tdatehvs = New System.Windows.Forms.MaskedTextBox
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel
        Me.btnCari1 = New MetroFramework.Controls.MetroTile
        Me.tweight = New MetroFramework.Controls.MetroTextBox
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.tnojob = New MetroFramework.Controls.MetroTextBox
        Me.tvariety = New MetroFramework.Controls.MetroTextBox
        Me.tnolab = New MetroFramework.Controls.MetroTextBox
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel
        Me.btnEdit = New MetroFramework.Controls.MetroButton
        Me.btnKosong = New MetroFramework.Controls.MetroButton
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel
        Me.Tdate = New System.Windows.Forms.MaskedTextBox
        Me.MetroPanel3.SuspendLayout()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel19.Location = New System.Drawing.Point(23, 70)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(104, 19)
        Me.MetroLabel19.TabIndex = 201
        Me.MetroLabel19.Text = "Sample Identity"
        Me.MetroLabel19.UseStyleColors = True
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
        Me.MetroPanel3.TabIndex = 197
        Me.MetroPanel3.UseStyleColors = True
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'btnCari1
        '
        Me.btnCari1.ActiveControl = Nothing
        Me.btnCari1.Location = New System.Drawing.Point(217, 106)
        Me.btnCari1.Name = "btnCari1"
        Me.btnCari1.Size = New System.Drawing.Size(46, 23)
        Me.btnCari1.TabIndex = 200
        Me.btnCari1.Text = "Cari"
        Me.btnCari1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnCari1.UseSelectable = True
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
        Me.tweight.TabIndex = 198
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
        Me.tnojob.CustomButton.Location = New System.Drawing.Point(92, 1)
        Me.tnojob.CustomButton.Name = ""
        Me.tnojob.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tnojob.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tnojob.CustomButton.TabIndex = 1
        Me.tnojob.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tnojob.CustomButton.UseSelectable = True
        Me.tnojob.CustomButton.Visible = False
        Me.tnojob.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tnojob.Lines = New String(-1) {}
        Me.tnojob.Location = New System.Drawing.Point(97, 164)
        Me.tnojob.MaxLength = 32767
        Me.tnojob.Name = "tnojob"
        Me.tnojob.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tnojob.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tnojob.SelectedText = ""
        Me.tnojob.SelectionLength = 0
        Me.tnojob.SelectionStart = 0
        Me.tnojob.Size = New System.Drawing.Size(114, 23)
        Me.tnojob.TabIndex = 196
        Me.tnojob.UseSelectable = True
        Me.tnojob.UseStyleColors = True
        Me.tnojob.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tnojob.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.tvariety.TabIndex = 193
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
        Me.tnolab.TabIndex = 192
        Me.tnolab.UseSelectable = True
        Me.tnolab.UseStyleColors = True
        Me.tnolab.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tnolab.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(325, 110)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel4.TabIndex = 190
        Me.MetroLabel4.Text = "Harvest Date"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 138)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel2.TabIndex = 188
        Me.MetroLabel2.Text = "Variety"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(325, 138)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel5.TabIndex = 191
        Me.MetroLabel5.Text = "Weight (kg)"
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        Me.MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Teal
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 167)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel3.TabIndex = 189
        Me.MetroLabel3.Text = "Job No."
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 110)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel1.TabIndex = 187
        Me.MetroLabel1.Text = "Lab No."
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(23, 228)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(85, 19)
        Me.MetroLabel7.TabIndex = 186
        Me.MetroLabel7.Text = "dd-MM-yyyy"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(117, 228)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel6.TabIndex = 185
        Me.MetroLabel6.Text = "Time"
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.DisplayFocus = True
        Me.btnEdit.Location = New System.Drawing.Point(415, 218)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(79, 29)
        Me.btnEdit.TabIndex = 184
        Me.btnEdit.Text = "Cek Date"
        Me.btnEdit.UseSelectable = True
        '
        'btnKosong
        '
        Me.btnKosong.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKosong.DisplayFocus = True
        Me.btnKosong.Location = New System.Drawing.Point(500, 218)
        Me.btnKosong.Name = "btnKosong"
        Me.btnKosong.Size = New System.Drawing.Size(79, 29)
        Me.btnKosong.TabIndex = 183
        Me.btnKosong.Text = "Kosongkan"
        Me.MetroToolTip1.SetToolTip(Me.btnKosong, "Untuk mengkosongkan/tanggal yang sudah ada sesuai Lab No.")
        Me.btnKosong.UseSelectable = True
        '
        'Timer1
        '
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel8.Location = New System.Drawing.Point(23, 197)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel8.TabIndex = 190
        Me.MetroLabel8.Text = "Date"
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
        Me.MetroPanel1.TabIndex = 197
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
        Me.Tdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Tdate.ValidatingType = GetType(Date)
        '
        'Sample_Test_Control_E
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 283)
        Me.Controls.Add(Me.MetroLabel19)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.MetroPanel3)
        Me.Controls.Add(Me.btnCari1)
        Me.Controls.Add(Me.tweight)
        Me.Controls.Add(Me.tnojob)
        Me.Controls.Add(Me.tvariety)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.tnolab)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnKosong)
        Me.Name = "Sample_Test_Control_E"
        Me.Padding = New System.Windows.Forms.Padding(20, 70, 20, 20)
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Sample Test Control E"
        Me.MetroPanel3.ResumeLayout(False)
        Me.MetroPanel3.PerformLayout()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tdatehvs As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnCari1 As MetroFramework.Controls.MetroTile
    Friend WithEvents tweight As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
    Friend WithEvents tnojob As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tvariety As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tnolab As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnEdit As MetroFramework.Controls.MetroButton
    Friend WithEvents btnKosong As MetroFramework.Controls.MetroButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents Tdate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
End Class
