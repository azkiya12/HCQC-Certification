<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class containerusermenu
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
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.MetroLink2 = New MetroFramework.Controls.MetroLink()
        Me.MetroLink3 = New MetroFramework.Controls.MetroLink()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLink1
        '
        Me.MetroLink1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroLink1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink1.ImageSize = 35
        Me.MetroLink1.Location = New System.Drawing.Point(0, 82)
        Me.MetroLink1.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(173, 41)
        Me.MetroLink1.TabIndex = 0
        Me.MetroLink1.Text = "Log Out"
        Me.MetroLink1.UseSelectable = True
        Me.MetroLink1.UseStyleColors = True
        '
        'MetroLink2
        '
        Me.MetroLink2.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroLink2.Location = New System.Drawing.Point(0, 41)
        Me.MetroLink2.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLink2.Name = "MetroLink2"
        Me.MetroLink2.Size = New System.Drawing.Size(173, 41)
        Me.MetroLink2.TabIndex = 1
        Me.MetroLink2.Text = "Help"
        Me.MetroLink2.UseSelectable = True
        Me.MetroLink2.UseStyleColors = True
        '
        'MetroLink3
        '
        Me.MetroLink3.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroLink3.Location = New System.Drawing.Point(0, 0)
        Me.MetroLink3.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLink3.Name = "MetroLink3"
        Me.MetroLink3.Size = New System.Drawing.Size(173, 41)
        Me.MetroLink3.TabIndex = 2
        Me.MetroLink3.Text = "Profil"
        Me.MetroLink3.UseSelectable = True
        Me.MetroLink3.UseStyleColors = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MetroLink1)
        Me.Panel1.Controls.Add(Me.MetroLink2)
        Me.Panel1.Controls.Add(Me.MetroLink3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(173, 124)
        Me.Panel1.TabIndex = 3
        '
        'containerusermenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel1)
        Me.Name = "containerusermenu"
        Me.Size = New System.Drawing.Size(173, 124)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLink2 As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLink3 As MetroFramework.Controls.MetroLink
    Friend WithEvents Panel1 As Panel
End Class
