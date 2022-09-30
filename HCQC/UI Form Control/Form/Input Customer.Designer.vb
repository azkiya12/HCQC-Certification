<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Input_Customer
    Inherits MetroFramework.Forms.MetroForm
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
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.Customer_Info1 = New WindowsApplication1.Customer_Info()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        '
        'MetroStyleExtender1
        '
        Me.MetroStyleExtender1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Customer_Info1
        '
        Me.Customer_Info1.AutoScroll = True
        Me.Customer_Info1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Customer_Info1.Location = New System.Drawing.Point(20, 60)
        Me.Customer_Info1.Name = "Customer_Info1"
        Me.Customer_Info1.Size = New System.Drawing.Size(690, 356)
        Me.Customer_Info1.TabIndex = 0
        '
        'Input_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 436)
        Me.Controls.Add(Me.Customer_Info1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Input_Customer"
        Me.ShowInTaskbar = False
        Me.Text = "Profile"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroStyleManager1 As Components.MetroStyleManager
    Friend WithEvents MetroStyleExtender1 As Components.MetroStyleExtender
    Friend WithEvents Customer_Info1 As Customer_Info
End Class
