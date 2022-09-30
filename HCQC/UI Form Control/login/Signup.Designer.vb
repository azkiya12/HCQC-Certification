<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Signup
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Signup))
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.BtnCreate = New MetroFramework.Controls.MetroTile()
        Me.tpass = New MetroFramework.Controls.MetroTextBox()
        Me.tusername = New MetroFramework.Controls.MetroTextBox()
        Me.trepass = New MetroFramework.Controls.MetroTextBox()
        Me.temail = New MetroFramework.Controls.MetroTextBox()
        Me.tuserlevel = New MetroFramework.Controls.MetroComboBox()
        Me.MetroPanel5 = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel6 = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel4 = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.tfullname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.Location = New System.Drawing.Point(90, 53)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(76, 25)
        Me.MetroLabel2.TabIndex = 8
        Me.MetroLabel2.Text = "Sign up"
        Me.MetroLabel2.UseCustomBackColor = True
        '
        'BtnCreate
        '
        Me.BtnCreate.ActiveControl = Nothing
        Me.BtnCreate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCreate.Location = New System.Drawing.Point(49, 296)
        Me.BtnCreate.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(172, 37)
        Me.BtnCreate.TabIndex = 10
        Me.BtnCreate.Text = "Create Account"
        Me.BtnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnCreate.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCreate.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.BtnCreate.UseSelectable = True
        '
        'tpass
        '
        Me.tpass.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.tpass.CustomButton.Image = Nothing
        Me.tpass.CustomButton.Location = New System.Drawing.Point(146, 2)
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
        Me.tpass.Location = New System.Drawing.Point(49, 225)
        Me.tpass.MaxLength = 32767
        Me.tpass.Name = "tpass"
        Me.tpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.tpass.PromptText = "Password"
        Me.tpass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tpass.SelectedText = ""
        Me.tpass.SelectionLength = 0
        Me.tpass.SelectionStart = 0
        Me.tpass.ShortcutsEnabled = True
        Me.tpass.Size = New System.Drawing.Size(172, 28)
        Me.tpass.TabIndex = 4
        Me.tpass.UseSelectable = True
        Me.tpass.UseSystemPasswordChar = True
        Me.tpass.WaterMark = "Password"
        Me.tpass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tpass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tusername
        '
        Me.tusername.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.tusername.CustomButton.Image = Nothing
        Me.tusername.CustomButton.Location = New System.Drawing.Point(146, 2)
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
        Me.tusername.Location = New System.Drawing.Point(49, 88)
        Me.tusername.MaxLength = 32767
        Me.tusername.Name = "tusername"
        Me.tusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tusername.PromptText = "Username"
        Me.tusername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tusername.SelectedText = ""
        Me.tusername.SelectionLength = 0
        Me.tusername.SelectionStart = 0
        Me.tusername.ShortcutsEnabled = True
        Me.tusername.Size = New System.Drawing.Size(172, 28)
        Me.tusername.TabIndex = 0
        Me.tusername.UseSelectable = True
        Me.tusername.WaterMark = "Username"
        Me.tusername.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tusername.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'trepass
        '
        Me.trepass.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.trepass.CustomButton.Image = Nothing
        Me.trepass.CustomButton.Location = New System.Drawing.Point(146, 2)
        Me.trepass.CustomButton.Name = ""
        Me.trepass.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.trepass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.trepass.CustomButton.TabIndex = 1
        Me.trepass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.trepass.CustomButton.UseSelectable = True
        Me.trepass.CustomButton.Visible = False
        Me.trepass.DisplayIcon = True
        Me.trepass.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.trepass.Lines = New String(-1) {}
        Me.trepass.Location = New System.Drawing.Point(49, 259)
        Me.trepass.MaxLength = 32767
        Me.trepass.Name = "trepass"
        Me.trepass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.trepass.PromptText = "Retype Password"
        Me.trepass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.trepass.SelectedText = ""
        Me.trepass.SelectionLength = 0
        Me.trepass.SelectionStart = 0
        Me.trepass.ShortcutsEnabled = True
        Me.trepass.Size = New System.Drawing.Size(172, 28)
        Me.trepass.TabIndex = 5
        Me.trepass.UseSelectable = True
        Me.trepass.UseSystemPasswordChar = True
        Me.trepass.WaterMark = "Retype Password"
        Me.trepass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.trepass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'temail
        '
        Me.temail.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.temail.CustomButton.Image = Nothing
        Me.temail.CustomButton.Location = New System.Drawing.Point(146, 2)
        Me.temail.CustomButton.Name = ""
        Me.temail.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.temail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.temail.CustomButton.TabIndex = 1
        Me.temail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.temail.CustomButton.UseSelectable = True
        Me.temail.CustomButton.Visible = False
        Me.temail.DisplayIcon = True
        Me.temail.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.temail.Lines = New String(-1) {}
        Me.temail.Location = New System.Drawing.Point(49, 156)
        Me.temail.MaxLength = 32767
        Me.temail.Name = "temail"
        Me.temail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.temail.PromptText = "email_name@domain.com"
        Me.temail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.temail.SelectedText = ""
        Me.temail.SelectionLength = 0
        Me.temail.SelectionStart = 0
        Me.temail.ShortcutsEnabled = True
        Me.temail.Size = New System.Drawing.Size(172, 28)
        Me.temail.TabIndex = 2
        Me.temail.UseSelectable = True
        Me.temail.WaterMark = "email_name@domain.com"
        Me.temail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.temail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tuserlevel
        '
        Me.tuserlevel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tuserlevel.FormattingEnabled = True
        Me.tuserlevel.ItemHeight = 23
        Me.tuserlevel.Items.AddRange(New Object() {"1", "2", "3"})
        Me.tuserlevel.Location = New System.Drawing.Point(49, 190)
        Me.tuserlevel.Name = "tuserlevel"
        Me.tuserlevel.PromptText = "User Level..."
        Me.tuserlevel.Size = New System.Drawing.Size(172, 29)
        Me.tuserlevel.Style = MetroFramework.MetroColorStyle.Blue
        Me.tuserlevel.TabIndex = 3
        Me.tuserlevel.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tuserlevel.UseSelectable = True
        Me.tuserlevel.UseStyleColors = True
        '
        'MetroPanel5
        '
        Me.MetroPanel5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroPanel5.BackColor = System.Drawing.Color.Transparent
        Me.MetroPanel5.BackgroundImage = CType(resources.GetObject("MetroPanel5.BackgroundImage"), System.Drawing.Image)
        Me.MetroPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MetroPanel5.HorizontalScrollbarBarColor = True
        Me.MetroPanel5.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel5.HorizontalScrollbarSize = 10
        Me.MetroPanel5.Location = New System.Drawing.Point(15, 225)
        Me.MetroPanel5.Name = "MetroPanel5"
        Me.MetroPanel5.Size = New System.Drawing.Size(28, 28)
        Me.MetroPanel5.TabIndex = 12
        Me.MetroPanel5.UseCustomBackColor = True
        Me.MetroPanel5.VerticalScrollbarBarColor = True
        Me.MetroPanel5.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel5.VerticalScrollbarSize = 10
        '
        'MetroPanel6
        '
        Me.MetroPanel6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroPanel6.BackColor = System.Drawing.Color.Transparent
        Me.MetroPanel6.BackgroundImage = CType(resources.GetObject("MetroPanel6.BackgroundImage"), System.Drawing.Image)
        Me.MetroPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MetroPanel6.HorizontalScrollbarBarColor = True
        Me.MetroPanel6.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel6.HorizontalScrollbarSize = 10
        Me.MetroPanel6.Location = New System.Drawing.Point(15, 190)
        Me.MetroPanel6.Name = "MetroPanel6"
        Me.MetroPanel6.Size = New System.Drawing.Size(28, 28)
        Me.MetroPanel6.TabIndex = 12
        Me.MetroPanel6.UseCustomBackColor = True
        Me.MetroPanel6.VerticalScrollbarBarColor = True
        Me.MetroPanel6.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel6.VerticalScrollbarSize = 10
        '
        'MetroPanel4
        '
        Me.MetroPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroPanel4.BackColor = System.Drawing.Color.Transparent
        Me.MetroPanel4.BackgroundImage = CType(resources.GetObject("MetroPanel4.BackgroundImage"), System.Drawing.Image)
        Me.MetroPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MetroPanel4.HorizontalScrollbarBarColor = True
        Me.MetroPanel4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.HorizontalScrollbarSize = 10
        Me.MetroPanel4.Location = New System.Drawing.Point(15, 156)
        Me.MetroPanel4.Name = "MetroPanel4"
        Me.MetroPanel4.Size = New System.Drawing.Size(28, 28)
        Me.MetroPanel4.TabIndex = 12
        Me.MetroPanel4.UseCustomBackColor = True
        Me.MetroPanel4.VerticalScrollbarBarColor = True
        Me.MetroPanel4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.VerticalScrollbarSize = 10
        '
        'MetroPanel3
        '
        Me.MetroPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroPanel3.BackColor = System.Drawing.Color.Transparent
        Me.MetroPanel3.BackgroundImage = CType(resources.GetObject("MetroPanel3.BackgroundImage"), System.Drawing.Image)
        Me.MetroPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(15, 88)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(28, 28)
        Me.MetroPanel3.TabIndex = 12
        Me.MetroPanel3.UseCustomBackColor = True
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
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
        Me.MetroPanel2.Location = New System.Drawing.Point(90, 4)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(76, 67)
        Me.MetroPanel2.TabIndex = 7
        Me.MetroPanel2.UseCustomBackColor = True
        Me.MetroPanel2.VerticalScrollbarBarColor = False
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'tfullname
        '
        Me.tfullname.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.tfullname.CustomButton.Image = Nothing
        Me.tfullname.CustomButton.Location = New System.Drawing.Point(146, 2)
        Me.tfullname.CustomButton.Name = ""
        Me.tfullname.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.tfullname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tfullname.CustomButton.TabIndex = 1
        Me.tfullname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tfullname.CustomButton.UseSelectable = True
        Me.tfullname.CustomButton.Visible = False
        Me.tfullname.DisplayIcon = True
        Me.tfullname.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tfullname.Lines = New String(-1) {}
        Me.tfullname.Location = New System.Drawing.Point(49, 122)
        Me.tfullname.MaxLength = 32767
        Me.tfullname.Name = "tfullname"
        Me.tfullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tfullname.PromptText = "Full Name"
        Me.tfullname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tfullname.SelectedText = ""
        Me.tfullname.SelectionLength = 0
        Me.tfullname.SelectionStart = 0
        Me.tfullname.ShortcutsEnabled = True
        Me.tfullname.Size = New System.Drawing.Size(172, 28)
        Me.tfullname.TabIndex = 1
        Me.tfullname.UseSelectable = True
        Me.tfullname.WaterMark = "Full Name"
        Me.tfullname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tfullname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroPanel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroPanel1.BackgroundImage = CType(resources.GetObject("MetroPanel1.BackgroundImage"), System.Drawing.Image)
        Me.MetroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(15, 122)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(28, 28)
        Me.MetroPanel1.TabIndex = 12
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        '
        'Signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.tuserlevel)
        Me.Controls.Add(Me.MetroPanel5)
        Me.Controls.Add(Me.MetroPanel6)
        Me.Controls.Add(Me.MetroPanel4)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.MetroPanel3)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.trepass)
        Me.Controls.Add(Me.tpass)
        Me.Controls.Add(Me.temail)
        Me.Controls.Add(Me.tfullname)
        Me.Controls.Add(Me.tusername)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Name = "Signup"
        Me.Size = New System.Drawing.Size(256, 353)
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel2 As MetroLabel
    Friend WithEvents MetroPanel2 As MetroPanel
    Friend WithEvents BtnCreate As MetroTile
    Friend WithEvents tpass As MetroTextBox
    Friend WithEvents tusername As MetroTextBox
    Friend WithEvents trepass As MetroTextBox
    Friend WithEvents temail As MetroTextBox
    Friend WithEvents MetroPanel3 As MetroPanel
    Friend WithEvents MetroPanel4 As MetroPanel
    Friend WithEvents MetroPanel5 As MetroPanel
    Friend WithEvents tuserlevel As MetroComboBox
    Friend WithEvents MetroPanel6 As MetroPanel
    Friend WithEvents tfullname As MetroTextBox
    Friend WithEvents MetroPanel1 As MetroPanel
    Friend WithEvents MetroStyleExtender1 As Components.MetroStyleExtender
    Friend WithEvents MetroStyleManager1 As Components.MetroStyleManager
End Class
