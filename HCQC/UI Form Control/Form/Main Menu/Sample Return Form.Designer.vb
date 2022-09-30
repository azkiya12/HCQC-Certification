<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sample_Return_Form
    Inherits MetroFramework.Forms.MetroForm

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sample_Return_Form))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.Tnama = New MetroFramework.Controls.MetroTextBox()
        Me.Tremark = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.Lharvest = New MetroFramework.Controls.MetroLabel()
        Me.Lfarmer = New MetroFramework.Controls.MetroLabel()
        Me.Lvariety = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.Lreqnum = New MetroFramework.Controls.MetroLabel()
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.BtnSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.Ljob = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.LLocation = New MetroFramework.Controls.MetroLabel()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(64, 161)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Taken by"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(64, 190)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(54, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Remark"
        '
        'Tnama
        '
        '
        '
        '
        Me.Tnama.CustomButton.Image = Nothing
        Me.Tnama.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.Tnama.CustomButton.Name = ""
        Me.Tnama.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.Tnama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Tnama.CustomButton.TabIndex = 1
        Me.Tnama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Tnama.CustomButton.UseSelectable = True
        Me.Tnama.CustomButton.Visible = False
        Me.Tnama.Lines = New String(-1) {}
        Me.Tnama.Location = New System.Drawing.Point(137, 161)
        Me.Tnama.MaxLength = 32767
        Me.Tnama.Name = "Tnama"
        Me.Tnama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Tnama.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Tnama.SelectedText = ""
        Me.Tnama.SelectionLength = 0
        Me.Tnama.SelectionStart = 0
        Me.Tnama.ShortcutsEnabled = True
        Me.Tnama.Size = New System.Drawing.Size(174, 23)
        Me.Tnama.TabIndex = 0
        Me.Tnama.UseSelectable = True
        Me.Tnama.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Tnama.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Tremark
        '
        '
        '
        '
        Me.Tremark.CustomButton.Image = Nothing
        Me.Tremark.CustomButton.Location = New System.Drawing.Point(130, 2)
        Me.Tremark.CustomButton.Name = ""
        Me.Tremark.CustomButton.Size = New System.Drawing.Size(41, 41)
        Me.Tremark.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Tremark.CustomButton.TabIndex = 1
        Me.Tremark.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Tremark.CustomButton.UseSelectable = True
        Me.Tremark.CustomButton.Visible = False
        Me.Tremark.Lines = New String(-1) {}
        Me.Tremark.Location = New System.Drawing.Point(137, 190)
        Me.Tremark.MaxLength = 32767
        Me.Tremark.Multiline = True
        Me.Tremark.Name = "Tremark"
        Me.Tremark.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Tremark.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Tremark.SelectedText = ""
        Me.Tremark.SelectionLength = 0
        Me.Tremark.SelectionStart = 0
        Me.Tremark.ShortcutsEnabled = True
        Me.Tremark.Size = New System.Drawing.Size(174, 46)
        Me.Tremark.TabIndex = 1
        Me.Tremark.UseSelectable = True
        Me.Tremark.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Tremark.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.MetroLabel3.TabIndex = 0
        Me.MetroLabel3.Text = "Variety"
        Me.MetroLabel3.UseCustomForeColor = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel4.Location = New System.Drawing.Point(245, 60)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(42, 15)
        Me.MetroLabel4.TabIndex = 0
        Me.MetroLabel4.Text = "Farmer"
        Me.MetroLabel4.UseCustomForeColor = True
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
        Me.MetroLabel5.TabIndex = 0
        Me.MetroLabel5.Text = "Harvest"
        Me.MetroLabel5.UseCustomForeColor = True
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
        Me.Lharvest.TabIndex = 0
        Me.Lharvest.Text = "Harvest"
        Me.Lharvest.UseCustomForeColor = True
        '
        'Lfarmer
        '
        Me.Lfarmer.AutoSize = True
        Me.Lfarmer.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Lfarmer.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Lfarmer.ForeColor = System.Drawing.Color.Black
        Me.Lfarmer.Location = New System.Drawing.Point(245, 75)
        Me.Lfarmer.Name = "Lfarmer"
        Me.Lfarmer.Size = New System.Drawing.Size(47, 15)
        Me.Lfarmer.TabIndex = 0
        Me.Lfarmer.Text = "Farmer"
        Me.Lfarmer.UseCustomForeColor = True
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
        Me.Lvariety.TabIndex = 0
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
        Me.MetroLabel9.TabIndex = 0
        Me.MetroLabel9.Text = "Request Number"
        Me.MetroLabel9.UseCustomForeColor = True
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
        Me.Lreqnum.TabIndex = 0
        Me.Lreqnum.Text = "11"
        Me.Lreqnum.UseCustomForeColor = True
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
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
        Me.BtnSave.Location = New System.Drawing.Point(137, 242)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSave.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnSave.selected = False
        Me.BtnSave.Size = New System.Drawing.Size(174, 34)
        Me.BtnSave.TabIndex = 56
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Textcolor = System.Drawing.Color.White
        Me.BtnSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.MetroLabel6.TabIndex = 0
        Me.MetroLabel6.Text = "Lot/Job"
        Me.MetroLabel6.UseCustomForeColor = True
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
        Me.Ljob.TabIndex = 0
        Me.Ljob.Text = "Job/Lot"
        Me.Ljob.UseCustomForeColor = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel7.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel7.Location = New System.Drawing.Point(245, 100)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(49, 15)
        Me.MetroLabel7.TabIndex = 0
        Me.MetroLabel7.Text = "Location"
        Me.MetroLabel7.UseCustomForeColor = True
        '
        'LLocation
        '
        Me.LLocation.AutoSize = True
        Me.LLocation.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LLocation.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LLocation.ForeColor = System.Drawing.Color.Black
        Me.LLocation.Location = New System.Drawing.Point(245, 115)
        Me.LLocation.Name = "LLocation"
        Me.LLocation.Size = New System.Drawing.Size(54, 15)
        Me.LLocation.TabIndex = 0
        Me.LLocation.Text = "Location"
        Me.LLocation.UseCustomForeColor = True
        '
        'Sample_Return_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 311)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Tremark)
        Me.Controls.Add(Me.Tnama)
        Me.Controls.Add(Me.MetroLabel2)
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
        Me.Controls.Add(Me.MetroLabel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Sample_Return_Form"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Sample Return"
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroLabel
    Friend WithEvents MetroLabel2 As MetroLabel
    Friend WithEvents Tnama As MetroTextBox
    Friend WithEvents Tremark As MetroTextBox
    Friend WithEvents BtnSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MetroLabel3 As MetroLabel
    Friend WithEvents MetroLabel4 As MetroLabel
    Friend WithEvents MetroLabel5 As MetroLabel
    Friend WithEvents Lharvest As MetroLabel
    Friend WithEvents Lfarmer As MetroLabel
    Friend WithEvents Lvariety As MetroLabel
    Friend WithEvents MetroLabel9 As MetroLabel
    Friend WithEvents Lreqnum As MetroLabel
    Friend WithEvents MetroStyleExtender1 As Components.MetroStyleExtender
    Friend WithEvents MetroStyleManager1 As Components.MetroStyleManager
    Friend WithEvents Ljob As MetroLabel
    Friend WithEvents MetroLabel6 As MetroLabel
    Friend WithEvents LLocation As MetroLabel
    Friend WithEvents MetroLabel7 As MetroLabel
End Class
