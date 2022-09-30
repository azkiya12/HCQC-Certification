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
        Me.BtnLogOut = New MetroFramework.Controls.MetroLink()
        Me.BtnProfil = New MetroFramework.Controls.MetroLink()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnLogOut
        '
        Me.BtnLogOut.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogOut.ImageSize = 35
        Me.BtnLogOut.Location = New System.Drawing.Point(0, 41)
        Me.BtnLogOut.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(173, 41)
        Me.BtnLogOut.TabIndex = 0
        Me.BtnLogOut.Text = "Log Out"
        Me.BtnLogOut.UseSelectable = True
        Me.BtnLogOut.UseStyleColors = True
        '
        'BtnProfil
        '
        Me.BtnProfil.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnProfil.Location = New System.Drawing.Point(0, 0)
        Me.BtnProfil.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnProfil.Name = "BtnProfil"
        Me.BtnProfil.Size = New System.Drawing.Size(173, 41)
        Me.BtnProfil.TabIndex = 2
        Me.BtnProfil.Text = "Profil"
        Me.BtnProfil.UseSelectable = True
        Me.BtnProfil.UseStyleColors = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnLogOut)
        Me.Panel1.Controls.Add(Me.BtnProfil)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(173, 87)
        Me.Panel1.TabIndex = 3
        '
        'containerusermenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel1)
        Me.Name = "containerusermenu"
        Me.Size = New System.Drawing.Size(173, 87)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnLogOut As MetroFramework.Controls.MetroLink
    Friend WithEvents BtnProfil As MetroFramework.Controls.MetroLink
    Friend WithEvents Panel1 As Panel
End Class
