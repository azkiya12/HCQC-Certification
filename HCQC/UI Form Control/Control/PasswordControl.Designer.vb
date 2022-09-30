<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PasswordControl))
        Me.BunifuSeparator4 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel18 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel16 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tpass1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tpass2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BtnSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SuspendLayout()
        '
        'BunifuSeparator4
        '
        Me.BunifuSeparator4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator4.LineThickness = 1
        Me.BunifuSeparator4.Location = New System.Drawing.Point(23, 63)
        Me.BunifuSeparator4.Name = "BunifuSeparator4"
        Me.BunifuSeparator4.Size = New System.Drawing.Size(343, 6)
        Me.BunifuSeparator4.TabIndex = 31
        Me.BunifuSeparator4.Transparency = 255
        Me.BunifuSeparator4.Vertical = False
        '
        'BunifuCustomLabel18
        '
        Me.BunifuCustomLabel18.AutoSize = True
        Me.BunifuCustomLabel18.Location = New System.Drawing.Point(20, 81)
        Me.BunifuCustomLabel18.Name = "BunifuCustomLabel18"
        Me.BunifuCustomLabel18.Size = New System.Drawing.Size(78, 13)
        Me.BunifuCustomLabel18.TabIndex = 29
        Me.BunifuCustomLabel18.Text = "New Password"
        '
        'BunifuCustomLabel16
        '
        Me.BunifuCustomLabel16.AutoSize = True
        Me.BunifuCustomLabel16.Location = New System.Drawing.Point(20, 138)
        Me.BunifuCustomLabel16.Name = "BunifuCustomLabel16"
        Me.BunifuCustomLabel16.Size = New System.Drawing.Size(122, 13)
        Me.BunifuCustomLabel16.TabIndex = 30
        Me.BunifuCustomLabel16.Text = "Re-Type New Password"
        '
        'tpass1
        '
        Me.tpass1.BorderColorFocused = System.Drawing.Color.Blue
        Me.tpass1.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tpass1.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tpass1.BorderThickness = 1
        Me.tpass1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tpass1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.tpass1.ForeColor = System.Drawing.Color.Black
        Me.tpass1.isPassword = True
        Me.tpass1.Location = New System.Drawing.Point(23, 96)
        Me.tpass1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 10)
        Me.tpass1.Name = "tpass1"
        Me.tpass1.Size = New System.Drawing.Size(343, 32)
        Me.tpass1.TabIndex = 26
        Me.tpass1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tpass2
        '
        Me.tpass2.BorderColorFocused = System.Drawing.Color.Blue
        Me.tpass2.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tpass2.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tpass2.BorderThickness = 1
        Me.tpass2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tpass2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.tpass2.ForeColor = System.Drawing.Color.Black
        Me.tpass2.isPassword = True
        Me.tpass2.Location = New System.Drawing.Point(23, 153)
        Me.tpass2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 10)
        Me.tpass2.Name = "tpass2"
        Me.tpass2.Size = New System.Drawing.Size(343, 32)
        Me.tpass2.TabIndex = 27
        Me.tpass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnSave
        '
        Me.BtnSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
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
        Me.BtnSave.Location = New System.Drawing.Point(222, 210)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BtnSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BtnSave.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnSave.selected = False
        Me.BtnSave.Size = New System.Drawing.Size(144, 37)
        Me.BtnSave.TabIndex = 32
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Textcolor = System.Drawing.Color.White
        Me.BtnSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PasswordControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 270)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BunifuSeparator4)
        Me.Controls.Add(Me.BunifuCustomLabel18)
        Me.Controls.Add(Me.BunifuCustomLabel16)
        Me.Controls.Add(Me.tpass1)
        Me.Controls.Add(Me.tpass2)
        Me.Name = "PasswordControl"
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuSeparator4 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel18 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel16 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tpass1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tpass2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BtnSave As Bunifu.Framework.UI.BunifuFlatButton
End Class
