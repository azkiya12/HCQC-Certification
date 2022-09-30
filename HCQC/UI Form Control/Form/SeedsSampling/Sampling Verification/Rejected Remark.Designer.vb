<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rejected_Remark
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
        Me.TRemarkReject = New MetroFramework.Controls.MetroTextBox()
        Me.BtnSave2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Lreqnum = New MetroFramework.Controls.MetroLabel()
        Me.Lvariety = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.Lfarmer = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.Ljob = New MetroFramework.Controls.MetroLabel()
        Me.LLocation = New MetroFramework.Controls.MetroLabel()
        Me.Lharvest = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.BtnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelLabNumber = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'TRemarkReject
        '
        Me.TRemarkReject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TRemarkReject.CustomButton.Image = Nothing
        Me.TRemarkReject.CustomButton.Location = New System.Drawing.Point(343, 1)
        Me.TRemarkReject.CustomButton.Name = ""
        Me.TRemarkReject.CustomButton.Size = New System.Drawing.Size(49, 49)
        Me.TRemarkReject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TRemarkReject.CustomButton.TabIndex = 1
        Me.TRemarkReject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TRemarkReject.CustomButton.UseSelectable = True
        Me.TRemarkReject.CustomButton.Visible = False
        Me.TRemarkReject.Lines = New String(-1) {}
        Me.TRemarkReject.Location = New System.Drawing.Point(23, 152)
        Me.TRemarkReject.MaxLength = 32767
        Me.TRemarkReject.Multiline = True
        Me.TRemarkReject.Name = "TRemarkReject"
        Me.TRemarkReject.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TRemarkReject.PromptText = "Remark"
        Me.TRemarkReject.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TRemarkReject.SelectedText = ""
        Me.TRemarkReject.SelectionLength = 0
        Me.TRemarkReject.SelectionStart = 0
        Me.TRemarkReject.ShortcutsEnabled = True
        Me.TRemarkReject.Size = New System.Drawing.Size(393, 51)
        Me.TRemarkReject.TabIndex = 0
        Me.TRemarkReject.UseSelectable = True
        Me.TRemarkReject.WaterMark = "Remark"
        Me.TRemarkReject.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TRemarkReject.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'BtnSave2
        '
        Me.BtnSave2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSave2.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.BtnSave2.Appearance.Options.UseBackColor = True
        Me.BtnSave2.Appearance.Options.UseFont = True
        Me.BtnSave2.Appearance.Options.UseForeColor = True
        Me.BtnSave2.AppearanceDisabled.BackColor = System.Drawing.Color.Silver
        Me.BtnSave2.AppearanceDisabled.Options.UseBackColor = True
        Me.BtnSave2.AppearanceHovered.BackColor = System.Drawing.Color.DarkRed
        Me.BtnSave2.AppearanceHovered.ForeColor = System.Drawing.Color.Red
        Me.BtnSave2.AppearanceHovered.Options.UseForeColor = True
        Me.BtnSave2.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSave2.AppearancePressed.Options.UseBackColor = True
        Me.BtnSave2.Location = New System.Drawing.Point(308, 209)
        Me.BtnSave2.Name = "BtnSave2"
        Me.BtnSave2.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[True]
        Me.BtnSave2.Size = New System.Drawing.Size(108, 30)
        Me.BtnSave2.TabIndex = 52
        Me.BtnSave2.Text = "Save"
        '
        'Lreqnum
        '
        Me.Lreqnum.AutoSize = True
        Me.Lreqnum.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Lreqnum.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Lreqnum.ForeColor = System.Drawing.Color.Black
        Me.Lreqnum.Location = New System.Drawing.Point(23, 75)
        Me.Lreqnum.Name = "Lreqnum"
        Me.Lreqnum.Size = New System.Drawing.Size(21, 15)
        Me.Lreqnum.TabIndex = 70
        Me.Lreqnum.Text = "11"
        Me.Lreqnum.UseCustomForeColor = True
        '
        'Lvariety
        '
        Me.Lvariety.AutoSize = True
        Me.Lvariety.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Lvariety.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Lvariety.ForeColor = System.Drawing.Color.Black
        Me.Lvariety.Location = New System.Drawing.Point(137, 75)
        Me.Lvariety.Margin = New System.Windows.Forms.Padding(3, 0, 3, 6)
        Me.Lvariety.Name = "Lvariety"
        Me.Lvariety.Size = New System.Drawing.Size(46, 15)
        Me.Lvariety.TabIndex = 71
        Me.Lvariety.Text = "Variety"
        Me.Lvariety.UseCustomForeColor = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel9.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel9.Location = New System.Drawing.Point(23, 60)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(93, 15)
        Me.MetroLabel9.TabIndex = 72
        Me.MetroLabel9.Text = "Request Number"
        Me.MetroLabel9.UseCustomForeColor = True
        '
        'Lfarmer
        '
        Me.Lfarmer.AutoSize = True
        Me.Lfarmer.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Lfarmer.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Lfarmer.ForeColor = System.Drawing.Color.Black
        Me.Lfarmer.Location = New System.Drawing.Point(250, 75)
        Me.Lfarmer.Name = "Lfarmer"
        Me.Lfarmer.Size = New System.Drawing.Size(47, 15)
        Me.Lfarmer.TabIndex = 73
        Me.Lfarmer.Text = "Farmer"
        Me.Lfarmer.UseCustomForeColor = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel3.Location = New System.Drawing.Point(137, 60)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(40, 15)
        Me.MetroLabel3.TabIndex = 74
        Me.MetroLabel3.Text = "Variety"
        Me.MetroLabel3.UseCustomForeColor = True
        '
        'Ljob
        '
        Me.Ljob.AutoSize = True
        Me.Ljob.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Ljob.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Ljob.ForeColor = System.Drawing.Color.Black
        Me.Ljob.Location = New System.Drawing.Point(23, 115)
        Me.Ljob.Name = "Ljob"
        Me.Ljob.Size = New System.Drawing.Size(49, 15)
        Me.Ljob.TabIndex = 75
        Me.Ljob.Text = "Job/Lot"
        Me.Ljob.UseCustomForeColor = True
        '
        'LLocation
        '
        Me.LLocation.AutoSize = True
        Me.LLocation.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LLocation.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LLocation.ForeColor = System.Drawing.Color.Black
        Me.LLocation.Location = New System.Drawing.Point(250, 115)
        Me.LLocation.Name = "LLocation"
        Me.LLocation.Size = New System.Drawing.Size(54, 15)
        Me.LLocation.TabIndex = 76
        Me.LLocation.Text = "Location"
        Me.LLocation.UseCustomForeColor = True
        '
        'Lharvest
        '
        Me.Lharvest.AutoSize = True
        Me.Lharvest.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Lharvest.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Lharvest.ForeColor = System.Drawing.Color.Black
        Me.Lharvest.Location = New System.Drawing.Point(137, 115)
        Me.Lharvest.Name = "Lharvest"
        Me.Lharvest.Size = New System.Drawing.Size(51, 15)
        Me.Lharvest.TabIndex = 77
        Me.Lharvest.Text = "Harvest"
        Me.Lharvest.UseCustomForeColor = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel4.Location = New System.Drawing.Point(250, 60)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(42, 15)
        Me.MetroLabel4.TabIndex = 78
        Me.MetroLabel4.Text = "Farmer"
        Me.MetroLabel4.UseCustomForeColor = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel6.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel6.Location = New System.Drawing.Point(23, 100)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(45, 15)
        Me.MetroLabel6.TabIndex = 79
        Me.MetroLabel6.Text = "Job/Lot"
        Me.MetroLabel6.UseCustomForeColor = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel7.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel7.Location = New System.Drawing.Point(250, 100)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(49, 15)
        Me.MetroLabel7.TabIndex = 80
        Me.MetroLabel7.Text = "Location"
        Me.MetroLabel7.UseCustomForeColor = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel5.Location = New System.Drawing.Point(137, 100)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(46, 15)
        Me.MetroLabel5.TabIndex = 81
        Me.MetroLabel5.Text = "Harvest"
        Me.MetroLabel5.UseCustomForeColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.BtnCancel.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Appearance.Options.UseBackColor = True
        Me.BtnCancel.Appearance.Options.UseBorderColor = True
        Me.BtnCancel.Appearance.Options.UseFont = True
        Me.BtnCancel.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent
        Me.BtnCancel.AppearanceDisabled.Options.UseBackColor = True
        Me.BtnCancel.AppearanceDisabled.Options.UseBorderColor = True
        Me.BtnCancel.AppearanceHovered.BackColor = System.Drawing.Color.Silver
        Me.BtnCancel.AppearanceHovered.Options.UseBackColor = True
        Me.BtnCancel.AppearancePressed.BackColor = System.Drawing.Color.LightGray
        Me.BtnCancel.AppearancePressed.Options.UseBackColor = True
        Me.BtnCancel.Location = New System.Drawing.Point(196, 209)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.BtnCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[True]
        Me.BtnCancel.Size = New System.Drawing.Size(108, 30)
        Me.BtnCancel.TabIndex = 52
        Me.BtnCancel.Text = "Cancel"
        '
        'LabelLabNumber
        '
        Me.LabelLabNumber.AutoSize = True
        Me.LabelLabNumber.BackColor = System.Drawing.Color.Transparent
        Me.LabelLabNumber.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelLabNumber.ForeColor = System.Drawing.Color.LightGray
        Me.LabelLabNumber.Location = New System.Drawing.Point(23, 206)
        Me.LabelLabNumber.Name = "LabelLabNumber"
        Me.LabelLabNumber.Size = New System.Drawing.Size(61, 15)
        Me.LabelLabNumber.TabIndex = 82
        Me.LabelLabNumber.Text = "labnumber"
        Me.LabelLabNumber.UseCustomForeColor = True
        '
        'Rejected_Remark
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 262)
        Me.Controls.Add(Me.LabelLabNumber)
        Me.Controls.Add(Me.Lreqnum)
        Me.Controls.Add(Me.Lvariety)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.Lfarmer)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.Ljob)
        Me.Controls.Add(Me.LLocation)
        Me.Controls.Add(Me.Lharvest)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave2)
        Me.Controls.Add(Me.TRemarkReject)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Rejected_Remark"
        Me.Resizable = False
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Rejected Remark"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TRemarkReject As MetroTextBox
    Friend WithEvents BtnSave2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Lreqnum As MetroLabel
    Friend WithEvents Lvariety As MetroLabel
    Friend WithEvents MetroLabel9 As MetroLabel
    Friend WithEvents Lfarmer As MetroLabel
    Friend WithEvents MetroLabel3 As MetroLabel
    Friend WithEvents Ljob As MetroLabel
    Friend WithEvents LLocation As MetroLabel
    Friend WithEvents Lharvest As MetroLabel
    Friend WithEvents MetroLabel4 As MetroLabel
    Friend WithEvents MetroLabel6 As MetroLabel
    Friend WithEvents MetroLabel7 As MetroLabel
    Friend WithEvents MetroLabel5 As MetroLabel
    Friend WithEvents BtnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelLabNumber As MetroLabel
End Class
