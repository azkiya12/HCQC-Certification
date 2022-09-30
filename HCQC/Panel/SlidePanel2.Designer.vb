<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SlidePanel2
    Inherits MetroFramework.Controls.MetroUserControl

    Dim _owner As Form = Nothing
    Dim _loader As Boolean = False

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(ByVal owner As Form)
        Me.new()
        Me.Visible = False

        _owner = owner
        owner.Controls.Add(Me)
        Me.BringToFront()
        AddHandler owner.Resize, AddressOf owner_Resize
        'AddHandler Me.Click, AddressOf pnlSlider_Click
        ResizeForm()
    End Sub

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
        Me.SuspendLayout()
        '
        'SlidePanel1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "SlidePanel1"
        Me.Size = New System.Drawing.Size(156, 127)
        Me.ResumeLayout(False)

    End Sub

End Class
