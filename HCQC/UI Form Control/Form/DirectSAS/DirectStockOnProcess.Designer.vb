<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DirectStockOnProcess
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnStokonprocess = New MetroFramework.Controls.MetroButton()
        Me.ProgressSpinner1 = New MetroFramework.Controls.MetroProgressSpinner()
        Me.Lstatus = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'btnStokonprocess
        '
        Me.btnStokonprocess.Location = New System.Drawing.Point(23, 63)
        Me.btnStokonprocess.Name = "btnStokonprocess"
        Me.btnStokonprocess.Size = New System.Drawing.Size(101, 23)
        Me.btnStokonprocess.TabIndex = 86
        Me.btnStokonprocess.Text = "Stock on Process"
        Me.btnStokonprocess.UseSelectable = True
        '
        'ProgressSpinner1
        '
        Me.ProgressSpinner1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProgressSpinner1.Location = New System.Drawing.Point(23, 422)
        Me.ProgressSpinner1.Maximum = 100
        Me.ProgressSpinner1.Name = "ProgressSpinner1"
        Me.ProgressSpinner1.Size = New System.Drawing.Size(19, 19)
        Me.ProgressSpinner1.TabIndex = 88
        Me.ProgressSpinner1.UseSelectable = True
        Me.ProgressSpinner1.Visible = False
        '
        'Lstatus
        '
        Me.Lstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lstatus.AutoSize = True
        Me.Lstatus.BackColor = System.Drawing.Color.Gray
        Me.Lstatus.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Lstatus.ForeColor = System.Drawing.Color.Gray
        Me.Lstatus.Location = New System.Drawing.Point(46, 422)
        Me.Lstatus.Name = "Lstatus"
        Me.Lstatus.Size = New System.Drawing.Size(56, 15)
        Me.Lstatus.TabIndex = 87
        Me.Lstatus.Text = "Loading..."
        Me.Lstatus.UseCustomForeColor = True
        Me.Lstatus.Visible = False
        '
        'DirectStockOnProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 450)
        Me.Controls.Add(Me.ProgressSpinner1)
        Me.Controls.Add(Me.Lstatus)
        Me.Controls.Add(Me.btnStokonprocess)
        Me.Name = "DirectStockOnProcess"
        Me.Text = "Direct Stock On Process"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnStokonprocess As MetroButton
    Friend WithEvents ProgressSpinner1 As MetroProgressSpinner
    Friend WithEvents Lstatus As MetroLabel
End Class
