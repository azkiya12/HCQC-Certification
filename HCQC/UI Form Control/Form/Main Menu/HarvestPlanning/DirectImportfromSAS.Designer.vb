<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DirectImportfromSAS
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
        Me.components = New System.ComponentModel.Container()
        Me.Label_to = New MetroFramework.Controls.MetroLabel()
        Me.Label_from = New MetroFramework.Controls.MetroLabel()
        Me.DateTo = New MetroFramework.Controls.MetroDateTime()
        Me.DateFrom = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnSubmit = New MetroFramework.Controls.MetroButton()
        Me.MetroProgressBar1 = New MetroFramework.Controls.MetroProgressBar()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroProgressSpinner1 = New MetroFramework.Controls.MetroProgressSpinner()
        Me.LabelStatus = New MetroFramework.Controls.MetroLabel()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_to
        '
        Me.Label_to.AutoSize = True
        Me.Label_to.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label_to.Location = New System.Drawing.Point(166, 97)
        Me.Label_to.Name = "Label_to"
        Me.Label_to.Size = New System.Drawing.Size(65, 19)
        Me.Label_to.TabIndex = 70
        Me.Label_to.Text = "Date End"
        '
        'Label_from
        '
        Me.Label_from.AutoSize = True
        Me.Label_from.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label_from.Location = New System.Drawing.Point(23, 97)
        Me.Label_from.Name = "Label_from"
        Me.Label_from.Size = New System.Drawing.Size(71, 19)
        Me.Label_from.TabIndex = 69
        Me.Label_from.Text = "Date Start"
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd-MM-yyyy"
        Me.DateTo.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTo.Location = New System.Drawing.Point(166, 119)
        Me.DateTo.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.DateTo.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.DateTo.MinimumSize = New System.Drawing.Size(0, 25)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(116, 25)
        Me.DateTo.TabIndex = 68
        Me.DateTo.UseStyleColors = True
        Me.DateTo.Value = New Date(2022, 8, 1, 10, 9, 49, 0)
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = ""
        Me.DateFrom.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFrom.Location = New System.Drawing.Point(23, 119)
        Me.DateFrom.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.DateFrom.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.DateFrom.MinimumSize = New System.Drawing.Size(0, 25)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(116, 25)
        Me.DateFrom.TabIndex = 67
        Me.DateFrom.UseStyleColors = True
        Me.DateFrom.Value = New Date(2022, 8, 15, 0, 0, 0, 0)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(325, 19)
        Me.MetroLabel1.TabIndex = 72
        Me.MetroLabel1.Text = "Direct import data from SAS Weekly Harvest Planning"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(312, 119)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 25)
        Me.btnSubmit.TabIndex = 73
        Me.btnSubmit.Text = "Upload"
        Me.btnSubmit.UseSelectable = True
        '
        'MetroProgressBar1
        '
        Me.MetroProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroProgressBar1.Location = New System.Drawing.Point(0, -2)
        Me.MetroProgressBar1.Name = "MetroProgressBar1"
        Me.MetroProgressBar1.Size = New System.Drawing.Size(431, 10)
        Me.MetroProgressBar1.Step = 1
        Me.MetroProgressBar1.TabIndex = 74
        Me.MetroProgressBar1.Visible = False
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Nothing
        '
        'MetroProgressSpinner1
        '
        Me.MetroProgressSpinner1.Location = New System.Drawing.Point(21, 164)
        Me.MetroProgressSpinner1.Margin = New System.Windows.Forms.Padding(1)
        Me.MetroProgressSpinner1.Maximum = 100
        Me.MetroProgressSpinner1.Name = "MetroProgressSpinner1"
        Me.MetroProgressSpinner1.Size = New System.Drawing.Size(16, 16)
        Me.MetroProgressSpinner1.TabIndex = 76
        Me.MetroProgressSpinner1.UseSelectable = True
        Me.MetroProgressSpinner1.Value = 35
        Me.MetroProgressSpinner1.Visible = False
        '
        'LabelStatus
        '
        Me.LabelStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelStatus.Location = New System.Drawing.Point(41, 164)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(0, 0)
        Me.LabelStatus.TabIndex = 77
        '
        'DirectImportfromSAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 201)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.MetroProgressSpinner1)
        Me.Controls.Add(Me.MetroProgressBar1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.Label_to)
        Me.Controls.Add(Me.Label_from)
        Me.Controls.Add(Me.DateTo)
        Me.Controls.Add(Me.DateFrom)
        Me.Name = "DirectImportfromSAS"
        Me.Text = "Direct Import SAS"
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_to As MetroLabel
    Friend WithEvents Label_from As MetroLabel
    Friend WithEvents DateTo As MetroDateTime
    Friend WithEvents DateFrom As MetroDateTime
    Friend WithEvents MetroLabel1 As MetroLabel
    Friend WithEvents btnSubmit As MetroButton
    Friend WithEvents MetroProgressBar1 As MetroProgressBar
    Friend WithEvents MetroStyleManager1 As Components.MetroStyleManager
    Friend WithEvents MetroProgressSpinner1 As MetroProgressSpinner
    Friend WithEvents LabelStatus As MetroLabel
End Class
