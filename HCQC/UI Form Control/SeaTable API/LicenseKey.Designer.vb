<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LicenseKey
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LicenseKey))
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties9 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties10 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties11 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties12 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtID = New DevExpress.XtraEditors.LabelControl()
        Me.TxtStatus = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.SerialNumber = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.UnlockButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.ToggleSwitch1 = New DevExpress.XtraEditors.ToggleSwitch()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToggleSwitch1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(28, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(159, 25)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "HCQC Certification"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(28, 85)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "ID"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(28, 104)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "Status"
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(45, 85)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(11, 13)
        Me.TxtID.TabIndex = 4
        Me.TxtID.Text = "ID"
        '
        'TxtStatus
        '
        Me.TxtStatus.Location = New System.Drawing.Point(66, 104)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.Size = New System.Drawing.Size(32, 13)
        Me.TxtStatus.TabIndex = 5
        Me.TxtStatus.Text = "Status"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(28, 163)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl6.TabIndex = 6
        Me.LabelControl6.Text = "Licence Key"
        '
        'SerialNumber
        '
        Me.SerialNumber.AcceptsReturn = False
        Me.SerialNumber.AcceptsTab = False
        Me.SerialNumber.AnimationSpeed = 200
        Me.SerialNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.SerialNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.SerialNumber.BackColor = System.Drawing.Color.Transparent
        Me.SerialNumber.BackgroundImage = CType(resources.GetObject("SerialNumber.BackgroundImage"), System.Drawing.Image)
        Me.SerialNumber.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.SerialNumber.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.SerialNumber.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SerialNumber.BorderColorIdle = System.Drawing.Color.Silver
        Me.SerialNumber.BorderRadius = 10
        Me.SerialNumber.BorderThickness = 1
        Me.SerialNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.SerialNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SerialNumber.DefaultFont = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.SerialNumber.DefaultText = ""
        Me.SerialNumber.FillColor = System.Drawing.Color.White
        Me.SerialNumber.HideSelection = True
        Me.SerialNumber.IconLeft = Nothing
        Me.SerialNumber.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.SerialNumber.IconPadding = 10
        Me.SerialNumber.IconRight = Nothing
        Me.SerialNumber.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.SerialNumber.Lines = New String(-1) {}
        Me.SerialNumber.Location = New System.Drawing.Point(28, 182)
        Me.SerialNumber.MaxLength = 32767
        Me.SerialNumber.MinimumSize = New System.Drawing.Size(100, 35)
        Me.SerialNumber.Modified = False
        Me.SerialNumber.Multiline = False
        Me.SerialNumber.Name = "SerialNumber"
        StateProperties7.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties7.FillColor = System.Drawing.Color.Empty
        StateProperties7.ForeColor = System.Drawing.Color.Empty
        StateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.SerialNumber.OnActiveState = StateProperties7
        StateProperties8.BorderColor = System.Drawing.Color.Empty
        StateProperties8.FillColor = System.Drawing.Color.White
        StateProperties8.ForeColor = System.Drawing.Color.Empty
        StateProperties8.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.SerialNumber.OnDisabledState = StateProperties8
        StateProperties9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties9.FillColor = System.Drawing.Color.Empty
        StateProperties9.ForeColor = System.Drawing.Color.Empty
        StateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.SerialNumber.OnHoverState = StateProperties9
        StateProperties10.BorderColor = System.Drawing.Color.Silver
        StateProperties10.FillColor = System.Drawing.Color.White
        StateProperties10.ForeColor = System.Drawing.Color.Empty
        StateProperties10.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.SerialNumber.OnIdleState = StateProperties10
        Me.SerialNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SerialNumber.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.SerialNumber.PlaceholderText = "Enter key"
        Me.SerialNumber.ReadOnly = False
        Me.SerialNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SerialNumber.SelectedText = ""
        Me.SerialNumber.SelectionLength = 0
        Me.SerialNumber.SelectionStart = 0
        Me.SerialNumber.ShortcutsEnabled = True
        Me.SerialNumber.Size = New System.Drawing.Size(332, 35)
        Me.SerialNumber.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.SerialNumber.TabIndex = 7
        Me.SerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SerialNumber.TextMarginBottom = 0
        Me.SerialNumber.TextMarginLeft = 5
        Me.SerialNumber.TextMarginTop = 0
        Me.SerialNumber.TextPlaceholder = "Enter key"
        Me.SerialNumber.UseSystemPasswordChar = False
        Me.SerialNumber.WordWrap = True
        '
        'UnlockButton
        '
        Me.UnlockButton.AllowToggling = False
        Me.UnlockButton.AnimationSpeed = 200
        Me.UnlockButton.AutoGenerateColors = False
        Me.UnlockButton.BackColor = System.Drawing.Color.Transparent
        Me.UnlockButton.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.UnlockButton.BackgroundImage = CType(resources.GetObject("UnlockButton.BackgroundImage"), System.Drawing.Image)
        Me.UnlockButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.UnlockButton.ButtonText = "Activate License"
        Me.UnlockButton.ButtonTextMarginLeft = 0
        Me.UnlockButton.ColorContrastOnClick = 45
        Me.UnlockButton.ColorContrastOnHover = 45
        Me.UnlockButton.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.UnlockButton.CustomizableEdges = BorderEdges2
        Me.UnlockButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.UnlockButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.UnlockButton.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.UnlockButton.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.UnlockButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.UnlockButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.UnlockButton.ForeColor = System.Drawing.Color.White
        Me.UnlockButton.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.UnlockButton.IconMarginLeft = 11
        Me.UnlockButton.IconPadding = 10
        Me.UnlockButton.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.UnlockButton.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.UnlockButton.IdleBorderRadius = 10
        Me.UnlockButton.IdleBorderThickness = 1
        Me.UnlockButton.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.UnlockButton.IdleIconLeftImage = Nothing
        Me.UnlockButton.IdleIconRightImage = Nothing
        Me.UnlockButton.IndicateFocus = False
        Me.UnlockButton.Location = New System.Drawing.Point(28, 234)
        Me.UnlockButton.Name = "UnlockButton"
        StateProperties11.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties11.BorderRadius = 10
        StateProperties11.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties11.BorderThickness = 1
        StateProperties11.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties11.ForeColor = System.Drawing.Color.White
        StateProperties11.IconLeftImage = Nothing
        StateProperties11.IconRightImage = Nothing
        Me.UnlockButton.onHoverState = StateProperties11
        StateProperties12.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties12.BorderRadius = 10
        StateProperties12.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties12.BorderThickness = 1
        StateProperties12.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties12.ForeColor = System.Drawing.Color.White
        StateProperties12.IconLeftImage = Nothing
        StateProperties12.IconRightImage = Nothing
        Me.UnlockButton.OnPressedState = StateProperties12
        Me.UnlockButton.Size = New System.Drawing.Size(332, 45)
        Me.UnlockButton.TabIndex = 8
        Me.UnlockButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UnlockButton.TextMarginLeft = 0
        Me.UnlockButton.UseDefaultRadiusAndThickness = True
        '
        'ToggleSwitch1
        '
        Me.ToggleSwitch1.Location = New System.Drawing.Point(265, 160)
        Me.ToggleSwitch1.Name = "ToggleSwitch1"
        Me.ToggleSwitch1.Properties.OffText = "Lock"
        Me.ToggleSwitch1.Properties.OnText = "Unlock"
        Me.ToggleSwitch1.Size = New System.Drawing.Size(95, 19)
        Me.ToggleSwitch1.TabIndex = 10
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 0
        Me.BunifuElipse1.TargetControl = Me
        '
        'LicenseKey
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 316)
        Me.Controls.Add(Me.ToggleSwitch1)
        Me.Controls.Add(Me.UnlockButton)
        Me.Controls.Add(Me.SerialNumber)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.TxtStatus)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.ShowIcon = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LicenseKey"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LicenseKey"
        Me.TopMost = True
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToggleSwitch1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SerialNumber As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents UnlockButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents ToggleSwitch1 As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
End Class
