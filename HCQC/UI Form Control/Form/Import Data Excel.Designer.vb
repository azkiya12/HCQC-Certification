<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Import_Data_Excel
    Inherits MetroFramework.Controls.MetroUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Import_Data_Excel))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.BtnUpload = New MetroFramework.Controls.MetroButton()
        Me.MetroProgressBar1 = New MetroFramework.Controls.MetroProgressBar()
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.Label_to = New MetroFramework.Controls.MetroLabel()
        Me.Label_from = New MetroFramework.Controls.MetroLabel()
        Me.DateTo = New MetroFramework.Controls.MetroDateTime()
        Me.DateFrom = New MetroFramework.Controls.MetroDateTime()
        Me.Check_DireckLoad = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(7, 69)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(712, 232)
        Me.MetroGrid1.TabIndex = 6
        '
        'BtnUpload
        '
        Me.BtnUpload.Location = New System.Drawing.Point(545, 38)
        Me.BtnUpload.Name = "BtnUpload"
        Me.BtnUpload.Size = New System.Drawing.Size(113, 25)
        Me.BtnUpload.TabIndex = 4
        Me.BtnUpload.Text = "Upload To Server"
        Me.BtnUpload.UseSelectable = True
        '
        'MetroProgressBar1
        '
        Me.MetroProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroProgressBar1.Location = New System.Drawing.Point(7, 307)
        Me.MetroProgressBar1.Name = "MetroProgressBar1"
        Me.MetroProgressBar1.Size = New System.Drawing.Size(719, 10)
        Me.MetroProgressBar1.Step = 1
        Me.MetroProgressBar1.TabIndex = 8
        Me.MetroProgressBar1.Visible = False
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(692, 38)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(27, 25)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        ToolTipTitleItem1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipTitleItem1.Text = "Attention"
        ToolTipItem1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipItem1.ImageOptions.SvgImage = CType(resources.GetObject("resource.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        ToolTipItem1.Text = resources.GetString("ToolTipItem1.Text")
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.ToolTipController1.SetSuperTip(Me.BunifuImageButton2, SuperToolTip1)
        Me.BunifuImageButton2.TabIndex = 58
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 20
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(442, 38)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(97, 25)
        Me.MetroButton1.TabIndex = 59
        Me.MetroButton1.Text = "Open File CSV"
        Me.MetroButton1.UseSelectable = True
        '
        'Label_to
        '
        Me.Label_to.AutoSize = True
        Me.Label_to.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label_to.Location = New System.Drawing.Point(494, 13)
        Me.Label_to.Name = "Label_to"
        Me.Label_to.Size = New System.Drawing.Size(22, 19)
        Me.Label_to.TabIndex = 63
        Me.Label_to.Text = "to"
        Me.Label_to.Visible = False
        '
        'Label_from
        '
        Me.Label_from.AutoSize = True
        Me.Label_from.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label_from.Location = New System.Drawing.Point(323, 13)
        Me.Label_from.Name = "Label_from"
        Me.Label_from.Size = New System.Drawing.Size(38, 19)
        Me.Label_from.TabIndex = 62
        Me.Label_from.Text = "from"
        Me.Label_from.Visible = False
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd-MM-yyyy"
        Me.DateTo.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTo.Location = New System.Drawing.Point(522, 7)
        Me.DateTo.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.DateTo.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.DateTo.MinimumSize = New System.Drawing.Size(0, 25)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(108, 25)
        Me.DateTo.TabIndex = 61
        Me.DateTo.UseStyleColors = True
        Me.DateTo.Value = New Date(2022, 8, 1, 10, 9, 49, 0)
        Me.DateTo.Visible = False
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = ""
        Me.DateFrom.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFrom.Location = New System.Drawing.Point(367, 7)
        Me.DateFrom.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.DateFrom.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.DateFrom.MinimumSize = New System.Drawing.Size(0, 25)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(108, 25)
        Me.DateFrom.Style = MetroFramework.MetroColorStyle.Blue
        Me.DateFrom.TabIndex = 60
        Me.DateFrom.Theme = MetroFramework.MetroThemeStyle.Light
        Me.DateFrom.UseStyleColors = True
        Me.DateFrom.Value = New Date(2022, 8, 1, 10, 9, 49, 0)
        Me.DateFrom.Visible = False
        '
        'Check_DireckLoad
        '
        Me.Check_DireckLoad.AutoSize = True
        Me.Check_DireckLoad.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.Check_DireckLoad.Location = New System.Drawing.Point(7, 13)
        Me.Check_DireckLoad.Name = "Check_DireckLoad"
        Me.Check_DireckLoad.Size = New System.Drawing.Size(310, 19)
        Me.Check_DireckLoad.TabIndex = 66
        Me.Check_DireckLoad.Text = "Direct Load from SAS Weekly Harvest Planning"
        Me.Check_DireckLoad.UseSelectable = True
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(305, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.DisplayIcon = True
        Me.MetroTextBox1.Icon = Global.WindowsApplication1.My.Resources.Resources.Find
        Me.MetroTextBox1.IconRight = True
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(7, 38)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.PromptText = "Click to Browse..."
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(329, 25)
        Me.MetroTextBox1.TabIndex = 7
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMark = "Click to Browse..."
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(342, 38)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(97, 25)
        Me.MetroButton2.TabIndex = 67
        Me.MetroButton2.Text = "Open File Exel"
        Me.MetroButton2.UseSelectable = True
        '
        'Import_Data_Excel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.Check_DireckLoad)
        Me.Controls.Add(Me.Label_to)
        Me.Controls.Add(Me.Label_from)
        Me.Controls.Add(Me.DateTo)
        Me.Controls.Add(Me.DateFrom)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.BunifuImageButton2)
        Me.Controls.Add(Me.MetroProgressBar1)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Controls.Add(Me.BtnUpload)
        Me.Name = "Import_Data_Excel"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.Size = New System.Drawing.Size(733, 324)
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroGrid1 As MetroGrid
    Friend WithEvents BtnUpload As MetroButton
    Friend WithEvents MetroProgressBar1 As MetroProgressBar
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents MetroButton1 As MetroButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Label_to As MetroLabel
    Friend WithEvents Label_from As MetroLabel
    Friend WithEvents DateTo As MetroDateTime
    Friend WithEvents DateFrom As MetroDateTime
    Friend WithEvents Check_DireckLoad As MetroCheckBox
    Friend WithEvents MetroStyleManager1 As Components.MetroStyleManager
    Friend WithEvents MetroStyleExtender1 As Components.MetroStyleExtender
    Friend WithEvents MetroCheckBox1 As MetroCheckBox
    Friend WithEvents MetroTextBox1 As MetroTextBox
    Friend WithEvents MetroButton2 As MetroButton
End Class
