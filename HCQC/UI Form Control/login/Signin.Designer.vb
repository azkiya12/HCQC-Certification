<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signin
    Inherits System.Windows.Forms.UserControl

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Signin))
        Me.tusername = New MetroFramework.Controls.MetroTextBox()
        Me.tpass = New MetroFramework.Controls.MetroTextBox()
        Me.btnlogin = New MetroFramework.Controls.MetroTile()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLink2 = New MetroFramework.Controls.MetroLink()
        Me.Lusername = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'tusername
        '
        Me.tusername.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.tusername.CustomButton.Image = Nothing
        Me.tusername.CustomButton.Location = New System.Drawing.Point(133, 2)
        Me.tusername.CustomButton.Name = ""
        Me.tusername.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.tusername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tusername.CustomButton.TabIndex = 1
        Me.tusername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tusername.CustomButton.UseSelectable = True
        Me.tusername.CustomButton.Visible = False
        Me.tusername.DisplayIcon = True
        Me.tusername.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tusername.Lines = New String(-1) {}
        Me.tusername.Location = New System.Drawing.Point(36, 123)
        Me.tusername.MaxLength = 32767
        Me.tusername.Name = "tusername"
        Me.tusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        'Me.tusername.PromptText = "Username"
        Me.tusername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tusername.SelectedText = ""
        Me.tusername.SelectionLength = 0
        Me.tusername.SelectionStart = 0
        Me.tusername.ShortcutsEnabled = True
        Me.tusername.Size = New System.Drawing.Size(159, 28)
        Me.tusername.TabIndex = 0
        Me.tusername.UseSelectable = True
        Me.tusername.WaterMark = "Username"
        Me.tusername.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tusername.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tpass
        '
        Me.tpass.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.tpass.CustomButton.Image = Nothing
        Me.tpass.CustomButton.Location = New System.Drawing.Point(133, 2)
        Me.tpass.CustomButton.Name = ""
        Me.tpass.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.tpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tpass.CustomButton.TabIndex = 1
        Me.tpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tpass.CustomButton.UseSelectable = True
        Me.tpass.CustomButton.Visible = False
        Me.tpass.DisplayIcon = True
        Me.tpass.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tpass.Lines = New String(-1) {}
        Me.tpass.Location = New System.Drawing.Point(36, 157)
        Me.tpass.MaxLength = 32767
        Me.tpass.Name = "tpass"
        Me.tpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        'Me.tpass.PromptText = "Password"
        Me.tpass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tpass.SelectedText = ""
        Me.tpass.SelectionLength = 0
        Me.tpass.SelectionStart = 0
        Me.tpass.ShortcutsEnabled = True
        Me.tpass.Size = New System.Drawing.Size(159, 28)
        Me.tpass.TabIndex = 1
        Me.tpass.UseSelectable = True
        Me.tpass.UseSystemPasswordChar = True
        Me.tpass.WaterMark = "Password"
        Me.tpass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tpass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnlogin
        '
        Me.btnlogin.ActiveControl = Nothing
        Me.btnlogin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.Location = New System.Drawing.Point(36, 194)
        Me.btnlogin.Margin = New System.Windows.Forms.Padding(6)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(159, 37)
        Me.btnlogin.TabIndex = 3
        Me.btnlogin.Text = "LOGIN"
        Me.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnlogin.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnlogin.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.btnlogin.UseSelectable = True
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroPanel2.BackColor = System.Drawing.Color.Transparent
        Me.MetroPanel2.BackgroundImage = CType(resources.GetObject("MetroPanel2.BackgroundImage"), System.Drawing.Image)
        Me.MetroPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MetroPanel2.HorizontalScrollbarBarColor = False
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(81, 16)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(70, 67)
        Me.MetroPanel2.TabIndex = 4
        Me.MetroPanel2.UseCustomBackColor = True
        Me.MetroPanel2.VerticalScrollbarBarColor = False
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.Location = New System.Drawing.Point(80, 84)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(71, 25)
        Me.MetroLabel2.TabIndex = 5
        Me.MetroLabel2.Text = "Sign In"
        Me.MetroLabel2.UseCustomBackColor = True
        '
        'MetroLink2
        '
        Me.MetroLink2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroLink2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLink2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroLink2.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.MetroLink2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MetroLink2.Location = New System.Drawing.Point(90, 238)
        Me.MetroLink2.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLink2.Name = "MetroLink2"
        Me.MetroLink2.Size = New System.Drawing.Size(105, 20)
        Me.MetroLink2.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLink2.TabIndex = 6
        Me.MetroLink2.Text = "Forgot Password ?"
        Me.MetroLink2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroLink2.UseCustomBackColor = True
        Me.MetroLink2.UseSelectable = True
        Me.MetroLink2.UseStyleColors = True
        '
        'Lusername
        '
        Me.Lusername.AutoSize = True
        Me.Lusername.BackColor = System.Drawing.Color.Transparent
        Me.Lusername.ForeColor = System.Drawing.Color.Transparent
        Me.Lusername.Location = New System.Drawing.Point(80, 0)
        Me.Lusername.Name = "Lusername"
        Me.Lusername.Size = New System.Drawing.Size(72, 19)
        Me.Lusername.TabIndex = 7
        Me.Lusername.Text = "Lusername"
        Me.Lusername.UseCustomBackColor = True
        Me.Lusername.UseCustomForeColor = True
        '
        'Signin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Lusername)
        Me.Controls.Add(Me.MetroLink2)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.tpass)
        Me.Controls.Add(Me.tusername)
        Me.Name = "Signin"
        Me.Size = New System.Drawing.Size(237, 281)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tusername As MetroTextBox
    Friend WithEvents tpass As MetroTextBox
    Friend WithEvents btnlogin As MetroTile
    Friend WithEvents MetroPanel2 As MetroPanel
    Friend WithEvents MetroLabel2 As MetroLabel
    Friend WithEvents MetroLink2 As MetroLink
    Friend WithEvents Lusername As MetroLabel
End Class
