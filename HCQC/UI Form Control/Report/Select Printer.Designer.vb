<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Select_Printer
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
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.LinkCalibrate = New MetroFramework.Controls.MetroLink()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.SuspendLayout()
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Location = New System.Drawing.Point(23, 85)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(327, 29)
        Me.MetroComboBox1.TabIndex = 0
        Me.MetroComboBox1.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Printer Name"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(265, 120)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(85, 29)
        Me.MetroButton1.TabIndex = 2
        Me.MetroButton1.Text = "Select"
        Me.MetroButton1.UseSelectable = True
        '
        'LinkCalibrate
        '
        Me.LinkCalibrate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkCalibrate.AutoSize = True
        Me.LinkCalibrate.BackColor = System.Drawing.Color.Transparent
        Me.LinkCalibrate.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkCalibrate.Location = New System.Drawing.Point(23, 126)
        Me.LinkCalibrate.Name = "LinkCalibrate"
        Me.LinkCalibrate.Size = New System.Drawing.Size(122, 23)
        Me.LinkCalibrate.TabIndex = 111
        Me.LinkCalibrate.Text = "Calibrate Printer Zebra"
        Me.MetroToolTip1.SetToolTip(Me.LinkCalibrate, "Calibrasi Media" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Menyesuaikan posisi pencetakan awal sesuai " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dengan gerakan dan " &
        "dimensi media cetak Anda.")
        Me.LinkCalibrate.UseCustomBackColor = True
        Me.LinkCalibrate.UseSelectable = True
        Me.LinkCalibrate.UseStyleColors = True
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'Select_Printer
        '
        Me.AcceptButton = Me.MetroButton1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 184)
        Me.Controls.Add(Me.LinkCalibrate)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroComboBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Select_Printer"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Select Printer"
        Me.TransparencyKey = System.Drawing.Color.Empty
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroComboBox1 As MetroComboBox
    Friend WithEvents MetroLabel1 As MetroLabel
    Friend WithEvents MetroButton1 As MetroButton
    Friend WithEvents LinkCalibrate As MetroLink
    Friend WithEvents MetroToolTip1 As Components.MetroToolTip
End Class
