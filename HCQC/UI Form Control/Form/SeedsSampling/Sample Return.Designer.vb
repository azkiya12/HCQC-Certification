<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sample_Return
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sample_Return))
        Me.CheckAccept = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.CheckReject = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.LabelAccept = New MetroFramework.Controls.MetroLabel()
        Me.LabelReject = New MetroFramework.Controls.MetroLabel()
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
        Me.BtnCancel = New MetroFramework.Controls.MetroLink()
        Me.BtnSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.LabelLabNumber = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'CheckAccept
        '
        Me.CheckAccept.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CheckAccept.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CheckAccept.Checked = False
        Me.CheckAccept.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.CheckAccept.ForeColor = System.Drawing.Color.White
        Me.CheckAccept.Location = New System.Drawing.Point(71, 147)
        Me.CheckAccept.Name = "CheckAccept"
        Me.CheckAccept.Size = New System.Drawing.Size(20, 20)
        Me.CheckAccept.TabIndex = 75
        '
        'CheckReject
        '
        Me.CheckReject.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CheckReject.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CheckReject.Checked = False
        Me.CheckReject.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.CheckReject.ForeColor = System.Drawing.Color.White
        Me.CheckReject.Location = New System.Drawing.Point(171, 147)
        Me.CheckReject.Name = "CheckReject"
        Me.CheckReject.Size = New System.Drawing.Size(20, 20)
        Me.CheckReject.TabIndex = 76
        '
        'LabelAccept
        '
        Me.LabelAccept.AutoSize = True
        Me.LabelAccept.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LabelAccept.ForeColor = System.Drawing.Color.Black
        Me.LabelAccept.Location = New System.Drawing.Point(23, 148)
        Me.LabelAccept.Name = "LabelAccept"
        Me.LabelAccept.Size = New System.Drawing.Size(42, 19)
        Me.LabelAccept.TabIndex = 77
        Me.LabelAccept.Text = "Lulus"
        Me.LabelAccept.UseCustomForeColor = True
        '
        'LabelReject
        '
        Me.LabelReject.AutoSize = True
        Me.LabelReject.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LabelReject.ForeColor = System.Drawing.Color.Black
        Me.LabelReject.Location = New System.Drawing.Point(120, 148)
        Me.LabelReject.Name = "LabelReject"
        Me.LabelReject.Size = New System.Drawing.Size(45, 19)
        Me.LabelReject.TabIndex = 78
        Me.LabelReject.Text = "Tolak"
        Me.LabelReject.UseCustomForeColor = True
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
        Me.Lreqnum.TabIndex = 79
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
        Me.Lvariety.TabIndex = 80
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
        Me.MetroLabel9.TabIndex = 81
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
        Me.Lfarmer.TabIndex = 82
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
        Me.MetroLabel3.TabIndex = 83
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
        Me.Ljob.TabIndex = 84
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
        Me.LLocation.TabIndex = 85
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
        Me.Lharvest.TabIndex = 86
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
        Me.MetroLabel4.TabIndex = 87
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
        Me.MetroLabel6.TabIndex = 88
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
        Me.MetroLabel7.TabIndex = 89
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
        Me.MetroLabel5.TabIndex = 90
        Me.MetroLabel5.Text = "Harvest"
        Me.MetroLabel5.UseCustomForeColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(219, 183)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 34)
        Me.BtnCancel.TabIndex = 92
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseSelectable = True
        '
        'BtnSave
        '
        Me.BtnSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.BorderRadius = 0
        Me.BtnSave.ButtonText = "Submit"
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
        Me.BtnSave.Location = New System.Drawing.Point(23, 183)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSave.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnSave.selected = False
        Me.BtnSave.Size = New System.Drawing.Size(190, 34)
        Me.BtnSave.TabIndex = 91
        Me.BtnSave.Text = "Submit"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Textcolor = System.Drawing.Color.White
        Me.BtnSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LabelLabNumber
        '
        Me.LabelLabNumber.AutoSize = True
        Me.LabelLabNumber.BackColor = System.Drawing.Color.Transparent
        Me.LabelLabNumber.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelLabNumber.ForeColor = System.Drawing.Color.LightGray
        Me.LabelLabNumber.Location = New System.Drawing.Point(7, 234)
        Me.LabelLabNumber.Name = "LabelLabNumber"
        Me.LabelLabNumber.Size = New System.Drawing.Size(61, 15)
        Me.LabelLabNumber.TabIndex = 93
        Me.LabelLabNumber.Text = "labnumber"
        Me.LabelLabNumber.UseCustomForeColor = True
        '
        'Sample_Return
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 254)
        Me.Controls.Add(Me.LabelLabNumber)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
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
        Me.Controls.Add(Me.CheckAccept)
        Me.Controls.Add(Me.CheckReject)
        Me.Controls.Add(Me.LabelAccept)
        Me.Controls.Add(Me.LabelReject)
        Me.Name = "Sample_Return"
        Me.Text = "Sample Return from QC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckAccept As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents CheckReject As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents LabelAccept As MetroLabel
    Friend WithEvents LabelReject As MetroLabel
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
    Friend WithEvents BtnCancel As MetroLink
    Friend WithEvents BtnSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents LabelLabNumber As MetroLabel
End Class
