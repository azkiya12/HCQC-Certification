<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DirectImportGlobalReportSAS
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroProgressBar1 = New MetroFramework.Controls.MetroProgressBar()
        Me.btnSubmit = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.Lstatus = New MetroFramework.Controls.MetroLabel()
        Me.ProgressSpinner1 = New MetroFramework.Controls.MetroProgressSpinner()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.LinkGetData = New MetroFramework.Controls.MetroLink()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.TManual = New MetroFramework.Controls.MetroTextBox()
        Me.TRemark = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.Lscope = New MetroFramework.Controls.MetroLabel()
        Me.Lwerehouse = New MetroFramework.Controls.MetroLabel()
        Me.Ldoc_date = New MetroFramework.Controls.MetroLabel()
        Me.Lweight = New MetroFramework.Controls.MetroLabel()
        Me.Lharvest = New MetroFramework.Controls.MetroLabel()
        Me.Ljobno = New MetroFramework.Controls.MetroLabel()
        Me.Lvariety = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroProgressBar1
        '
        Me.MetroProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroProgressBar1.Location = New System.Drawing.Point(0, -2)
        Me.MetroProgressBar1.Name = "MetroProgressBar1"
        Me.MetroProgressBar1.Size = New System.Drawing.Size(771, 10)
        Me.MetroProgressBar1.Step = 1
        Me.MetroProgressBar1.TabIndex = 81
        Me.MetroProgressBar1.Visible = False
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(193, 129)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(60, 23)
        Me.btnSubmit.TabIndex = 80
        Me.btnSubmit.Text = "Cari"
        Me.btnSubmit.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(550, 19)
        Me.MetroLabel1.TabIndex = 79
        Me.MetroLabel1.Text = "Direct load data from SAS Detail WIP Stock per Item per Warehouse (with Harvest D" &
    "ate Info)"
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Nothing
        '
        'Lstatus
        '
        Me.Lstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lstatus.AutoSize = True
        Me.Lstatus.BackColor = System.Drawing.Color.Gray
        Me.Lstatus.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Lstatus.ForeColor = System.Drawing.Color.Gray
        Me.Lstatus.Location = New System.Drawing.Point(46, 466)
        Me.Lstatus.Name = "Lstatus"
        Me.Lstatus.Size = New System.Drawing.Size(56, 15)
        Me.Lstatus.TabIndex = 82
        Me.Lstatus.Text = "Loading..."
        Me.Lstatus.UseCustomForeColor = True
        Me.Lstatus.Visible = False
        '
        'ProgressSpinner1
        '
        Me.ProgressSpinner1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProgressSpinner1.Location = New System.Drawing.Point(23, 466)
        Me.ProgressSpinner1.Maximum = 100
        Me.ProgressSpinner1.Name = "ProgressSpinner1"
        Me.ProgressSpinner1.Size = New System.Drawing.Size(19, 19)
        Me.ProgressSpinner1.TabIndex = 83
        Me.ProgressSpinner1.UseSelectable = True
        Me.ProgressSpinner1.Visible = False
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'LinkGetData
        '
        Me.LinkGetData.AutoSize = True
        Me.LinkGetData.BackColor = System.Drawing.Color.Transparent
        Me.LinkGetData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkGetData.Location = New System.Drawing.Point(23, 79)
        Me.LinkGetData.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkGetData.Name = "LinkGetData"
        Me.LinkGetData.Size = New System.Drawing.Size(84, 23)
        Me.LinkGetData.TabIndex = 87
        Me.LinkGetData.Text = "Get Data SAS"
        Me.LinkGetData.UseCustomBackColor = True
        Me.LinkGetData.UseSelectable = True
        Me.LinkGetData.UseStyleColors = True
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(62, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(102, 129)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(84, 23)
        Me.MetroTextBox1.TabIndex = 88
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 133)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel2.TabIndex = 89
        Me.MetroLabel2.Text = "Lot/Job No"
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.MetroLabel12)
        Me.MetroPanel1.Controls.Add(Me.Lscope)
        Me.MetroPanel1.Controls.Add(Me.Lwerehouse)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel11)
        Me.MetroPanel1.Controls.Add(Me.TManual)
        Me.MetroPanel1.Controls.Add(Me.Ldoc_date)
        Me.MetroPanel1.Controls.Add(Me.Lweight)
        Me.MetroPanel1.Controls.Add(Me.TRemark)
        Me.MetroPanel1.Controls.Add(Me.Lharvest)
        Me.MetroPanel1.Controls.Add(Me.Ljobno)
        Me.MetroPanel1.Controls.Add(Me.MetroButton1)
        Me.MetroPanel1.Controls.Add(Me.Lvariety)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel9)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel8)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel7)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel6)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 155)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(771, 110)
        Me.MetroPanel1.TabIndex = 90
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel12.Location = New System.Drawing.Point(23, 45)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel12.TabIndex = 93
        Me.MetroLabel12.Text = "Remark"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel11.Location = New System.Drawing.Point(23, 12)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel11.TabIndex = 92
        Me.MetroLabel11.Text = "Manual"
        '
        'TManual
        '
        '
        '
        '
        Me.TManual.CustomButton.Image = Nothing
        Me.TManual.CustomButton.Location = New System.Drawing.Point(33, 1)
        Me.TManual.CustomButton.Name = ""
        Me.TManual.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.TManual.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TManual.CustomButton.TabIndex = 1
        Me.TManual.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TManual.CustomButton.UseSelectable = True
        Me.TManual.CustomButton.Visible = False
        Me.TManual.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.TManual.Lines = New String(-1) {}
        Me.TManual.Location = New System.Drawing.Point(84, 12)
        Me.TManual.MaxLength = 32767
        Me.TManual.Name = "TManual"
        Me.TManual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TManual.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TManual.SelectedText = ""
        Me.TManual.SelectionLength = 0
        Me.TManual.SelectionStart = 0
        Me.TManual.ShortcutsEnabled = True
        Me.TManual.Size = New System.Drawing.Size(55, 23)
        Me.TManual.TabIndex = 91
        Me.TManual.UseSelectable = True
        Me.TManual.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TManual.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'TRemark
        '
        '
        '
        '
        Me.TRemark.CustomButton.Image = Nothing
        Me.TRemark.CustomButton.Location = New System.Drawing.Point(129, 1)
        Me.TRemark.CustomButton.Name = ""
        Me.TRemark.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.TRemark.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TRemark.CustomButton.TabIndex = 1
        Me.TRemark.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TRemark.CustomButton.UseSelectable = True
        Me.TRemark.CustomButton.Visible = False
        Me.TRemark.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.TRemark.Lines = New String(-1) {}
        Me.TRemark.Location = New System.Drawing.Point(84, 41)
        Me.TRemark.MaxLength = 32767
        Me.TRemark.Name = "TRemark"
        Me.TRemark.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TRemark.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TRemark.SelectedText = ""
        Me.TRemark.SelectionLength = 0
        Me.TRemark.SelectionStart = 0
        Me.TRemark.ShortcutsEnabled = True
        Me.TRemark.Size = New System.Drawing.Size(151, 23)
        Me.TRemark.TabIndex = 91
        Me.TRemark.UseSelectable = True
        Me.TRemark.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TRemark.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(84, 70)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(111, 23)
        Me.MetroButton1.TabIndex = 91
        Me.MetroButton1.Text = "Request Sample"
        Me.MetroButton1.UseSelectable = True
        '
        'Lscope
        '
        Me.Lscope.AutoSize = True
        Me.Lscope.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Lscope.Location = New System.Drawing.Point(524, 50)
        Me.Lscope.Name = "Lscope"
        Me.Lscope.Size = New System.Drawing.Size(12, 19)
        Me.Lscope.TabIndex = 15
        Me.Lscope.Text = ":"
        '
        'Lwerehouse
        '
        Me.Lwerehouse.AutoSize = True
        Me.Lwerehouse.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Lwerehouse.Location = New System.Drawing.Point(602, 31)
        Me.Lwerehouse.Name = "Lwerehouse"
        Me.Lwerehouse.Size = New System.Drawing.Size(12, 19)
        Me.Lwerehouse.TabIndex = 14
        Me.Lwerehouse.Text = ":"
        '
        'Ldoc_date
        '
        Me.Ldoc_date.AutoSize = True
        Me.Ldoc_date.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Ldoc_date.Location = New System.Drawing.Point(587, 12)
        Me.Ldoc_date.Name = "Ldoc_date"
        Me.Ldoc_date.Size = New System.Drawing.Size(12, 19)
        Me.Ldoc_date.TabIndex = 13
        Me.Ldoc_date.Text = ":"
        '
        'Lweight
        '
        Me.Lweight.AutoSize = True
        Me.Lweight.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Lweight.Location = New System.Drawing.Point(338, 69)
        Me.Lweight.Name = "Lweight"
        Me.Lweight.Size = New System.Drawing.Size(12, 19)
        Me.Lweight.TabIndex = 12
        Me.Lweight.Text = ":"
        '
        'Lharvest
        '
        Me.Lharvest.AutoSize = True
        Me.Lharvest.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Lharvest.Location = New System.Drawing.Point(338, 50)
        Me.Lharvest.Name = "Lharvest"
        Me.Lharvest.Size = New System.Drawing.Size(12, 19)
        Me.Lharvest.TabIndex = 11
        Me.Lharvest.Text = ":"
        '
        'Ljobno
        '
        Me.Ljobno.AutoSize = True
        Me.Ljobno.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Ljobno.Location = New System.Drawing.Point(338, 31)
        Me.Ljobno.Name = "Ljobno"
        Me.Ljobno.Size = New System.Drawing.Size(12, 19)
        Me.Ljobno.TabIndex = 10
        Me.Ljobno.Text = ":"
        '
        'Lvariety
        '
        Me.Lvariety.AutoSize = True
        Me.Lvariety.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Lvariety.Location = New System.Drawing.Point(338, 12)
        Me.Lvariety.Name = "Lvariety"
        Me.Lvariety.Size = New System.Drawing.Size(12, 19)
        Me.Lvariety.TabIndex = 9
        Me.Lvariety.Text = ":"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel9.Location = New System.Drawing.Point(469, 50)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(49, 19)
        Me.MetroLabel9.TabIndex = 8
        Me.MetroLabel9.Text = "Status"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel8.Location = New System.Drawing.Point(469, 31)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(127, 19)
        Me.MetroLabel8.TabIndex = 7
        Me.MetroLabel8.Text = "Warehouse Name"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel7.Location = New System.Drawing.Point(469, 12)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(112, 19)
        Me.MetroLabel7.TabIndex = 6
        Me.MetroLabel7.Text = "Document Date"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel6.Location = New System.Drawing.Point(244, 69)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel6.TabIndex = 5
        Me.MetroLabel6.Text = "Weight (kg)"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel5.Location = New System.Drawing.Point(244, 50)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel5.TabIndex = 4
        Me.MetroLabel5.Text = "Harvest"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.Location = New System.Drawing.Point(244, 31)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "Lot/Job No"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.Location = New System.Drawing.Point(244, 12)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "Variety"
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Location = New System.Drawing.Point(23, 271)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(725, 196)
        Me.MetroTabControl1.TabIndex = 92
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.MetroGrid1)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(717, 154)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "History Sample"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
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
        Me.MetroGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(0, 0)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.ReadOnly = True
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
        Me.MetroGrid1.Size = New System.Drawing.Size(717, 154)
        Me.MetroGrid1.StandardTab = True
        Me.MetroGrid1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroGrid1.TabIndex = 92
        '
        'DirectImportGlobalReportSAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 490)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.Controls.Add(Me.LinkGetData)
        Me.Controls.Add(Me.ProgressSpinner1)
        Me.Controls.Add(Me.Lstatus)
        Me.Controls.Add(Me.MetroProgressBar1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "DirectImportGlobalReportSAS"
        Me.Resizable = False
        Me.Text = "Direct Global Stock SAS"
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroProgressBar1 As MetroProgressBar
    Friend WithEvents btnSubmit As MetroButton
    Friend WithEvents MetroLabel1 As MetroLabel
    Friend WithEvents MetroStyleManager1 As Components.MetroStyleManager
    Friend WithEvents Lstatus As MetroLabel
    Friend WithEvents ProgressSpinner1 As MetroProgressSpinner
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LinkGetData As MetroLink
    Friend WithEvents MetroTextBox1 As MetroTextBox
    Friend WithEvents MetroLabel2 As MetroLabel
    Friend WithEvents MetroPanel1 As MetroPanel
    Friend WithEvents MetroLabel9 As MetroLabel
    Friend WithEvents MetroLabel8 As MetroLabel
    Friend WithEvents MetroLabel7 As MetroLabel
    Friend WithEvents MetroLabel6 As MetroLabel
    Friend WithEvents MetroLabel5 As MetroLabel
    Friend WithEvents MetroLabel4 As MetroLabel
    Friend WithEvents MetroLabel3 As MetroLabel
    Friend WithEvents Lscope As MetroLabel
    Friend WithEvents Lwerehouse As MetroLabel
    Friend WithEvents Ldoc_date As MetroLabel
    Friend WithEvents Lweight As MetroLabel
    Friend WithEvents Lharvest As MetroLabel
    Friend WithEvents Ljobno As MetroLabel
    Friend WithEvents Lvariety As MetroLabel
    Friend WithEvents MetroButton1 As MetroButton
    Friend WithEvents MetroLabel12 As MetroLabel
    Friend WithEvents MetroLabel11 As MetroLabel
    Friend WithEvents TManual As MetroTextBox
    Friend WithEvents TRemark As MetroTextBox
    Friend WithEvents MetroTabControl1 As MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroTabPage
    Friend WithEvents MetroGrid1 As MetroGrid
End Class
