<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Import
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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
        Me.Import_Data_Excel1 = New Import_Data_Excel()
        Me.SuspendLayout()
        '
        'Import_Data_Excel1
        '
        Me.Import_Data_Excel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Import_Data_Excel1.Location = New System.Drawing.Point(23, 63)
        Me.Import_Data_Excel1.Name = "Import_Data_Excel1"
        Me.Import_Data_Excel1.Padding = New System.Windows.Forms.Padding(4)
        Me.Import_Data_Excel1.Size = New System.Drawing.Size(754, 364)
        Me.Import_Data_Excel1.TabIndex = 0
        Me.Import_Data_Excel1.UseSelectable = True
        '
        'Form_Import
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Import_Data_Excel1)
        Me.Name = "Form_Import"
        Me.Text = "Import File"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Import_Data_Excel1 As Import_Data_Excel
End Class
