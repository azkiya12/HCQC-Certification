<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parameter_Grafity
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tnolab = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.RdLinY = New System.Windows.Forms.RadioButton
        Me.RdLinN = New System.Windows.Forms.RadioButton
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(259, 108)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Select Certification"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"WIP CERTIFICATION", "PERIODIC CERTIFICATION", "FINISH GOODS CERITIFICATION", "EKTERNAL"})
        Me.ComboBox1.Location = New System.Drawing.Point(139, 23)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(195, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nomor Laboratorium"
        '
        'tnolab
        '
        Me.tnolab.Location = New System.Drawing.Point(139, 50)
        Me.tnolab.Name = "tnolab"
        Me.tnolab.Size = New System.Drawing.Size(195, 20)
        Me.tnolab.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(178, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Preview"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Cetak Garis"
        '
        'RdLinY
        '
        Me.RdLinY.AutoSize = True
        Me.RdLinY.Location = New System.Drawing.Point(139, 75)
        Me.RdLinY.Name = "RdLinY"
        Me.RdLinY.Size = New System.Drawing.Size(43, 17)
        Me.RdLinY.TabIndex = 14
        Me.RdLinY.TabStop = True
        Me.RdLinY.Text = "Yes"
        Me.RdLinY.UseVisualStyleBackColor = True
        '
        'RdLinN
        '
        Me.RdLinN.AutoSize = True
        Me.RdLinN.Location = New System.Drawing.Point(188, 75)
        Me.RdLinN.Name = "RdLinN"
        Me.RdLinN.Size = New System.Drawing.Size(39, 17)
        Me.RdLinN.TabIndex = 15
        Me.RdLinN.TabStop = True
        Me.RdLinN.Text = "No"
        Me.RdLinN.UseVisualStyleBackColor = True
        '
        'Parameter_Grafity
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 143)
        Me.Controls.Add(Me.RdLinN)
        Me.Controls.Add(Me.RdLinY)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tnolab)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Parameter_Grafity"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Preview Cerification"
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tnolab As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RdLinN As System.Windows.Forms.RadioButton
    Friend WithEvents RdLinY As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
