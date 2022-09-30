<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Harvest_Planning
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Harvest_Planning))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RealTimeSource1 = New DevExpress.Data.RealTimeSource()
        Me.HarvestProductionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_NewDataset = New WindowsApplication1.HCQC_NewDataset()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colidcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcrop = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colharvest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvariety = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstaff = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkab = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkec = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldesa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldusun = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnorencana = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnokontrak = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colblokno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcgrno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcgrname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colupload_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coljoblot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.HarvestProductionTableAdapter = New WindowsApplication1.HCQC_NewDatasetTableAdapters.HarvestProductionTableAdapter()
        Me.NavigationFrame1 = New DevExpress.XtraBars.Navigation.NavigationFrame()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.trequestcopy = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.LabelMark = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.LabelPrinter = New MetroFramework.Controls.MetroLink()
        Me.Label9 = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelCount = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.BtnPreview = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnSendBack = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnSend = New Bunifu.Framework.UI.BunifuImageButton()
        Me.MetroGrid2 = New MetroFramework.Controls.MetroGrid()
        Me.CekColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarietyColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CropColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlantColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContractColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HarvestColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.CheckColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdcodeColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.areaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarietyColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CropColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.norencanaColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HarvestColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContractColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CgrColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Count = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastPrint = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reporta1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MetroLink2 = New MetroFramework.Controls.MetroLink()
        Me.linkClearAll = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.LInkRefresh = New MetroFramework.Controls.MetroLink()
        Me.CheckBox1 = New MetroFramework.Controls.MetroCheckBox()
        Me.LinkData = New MetroFramework.Controls.MetroLink()
        Me.LinkReport = New MetroFramework.Controls.MetroLink()
        Me.Report_a1TableAdapter = New WindowsApplication1.HCQC_NewDatasetTableAdapters.report_a1TableAdapter()
        Me.LinkImport = New MetroFramework.Controls.MetroLink()
        Me.LinkDirectUpdateSAS = New MetroFramework.Controls.MetroLink()
        Me.ComboBtn1 = New MetroFramework.Controls.MetroComboBox()
        CType(Me.HarvestProductionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavigationFrame1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationFrame1.SuspendLayout()
        Me.NavigationPage1.SuspendLayout()
        Me.NavigationPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSendBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reporta1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RealTimeSource1
        '
        Me.RealTimeSource1.DataSource = Me.HarvestProductionBindingSource
        Me.RealTimeSource1.DisplayableProperties = "idcode;type;crop;harvest;variety;staff;kab;kec;desa;dusun;norencana;nokontrak;blo" &
    "kno;cgrno;cgrname;upload_date;joblot"
        '
        'HarvestProductionBindingSource
        '
        Me.HarvestProductionBindingSource.DataMember = "HarvestProduction"
        Me.HarvestProductionBindingSource.DataSource = Me.HCQC_NewDataset
        '
        'HCQC_NewDataset
        '
        Me.HCQC_NewDataset.DataSetName = "HCQC_NewDataset"
        Me.HCQC_NewDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.RealTimeSource1
        Me.GridControl1.Location = New System.Drawing.Point(0, 32)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(886, 362)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colidcode, Me.coltype, Me.colcrop, Me.colharvest, Me.colvariety, Me.colstaff, Me.colkab, Me.colkec, Me.coldesa, Me.coldusun, Me.colnorencana, Me.colnokontrak, Me.colblokno, Me.colcgrno, Me.colcgrname, Me.colupload_date, Me.coljoblot})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsMenu.ShowFooterItem = True
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colharvest, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colidcode
        '
        Me.colidcode.Caption = "Production Code"
        Me.colidcode.FieldName = "idcode"
        Me.colidcode.Name = "colidcode"
        Me.colidcode.Visible = True
        Me.colidcode.VisibleIndex = 0
        Me.colidcode.Width = 96
        '
        'coltype
        '
        Me.coltype.Caption = "Type"
        Me.coltype.FieldName = "type"
        Me.coltype.Name = "coltype"
        Me.coltype.Visible = True
        Me.coltype.VisibleIndex = 1
        Me.coltype.Width = 45
        '
        'colcrop
        '
        Me.colcrop.Caption = "Crop"
        Me.colcrop.FieldName = "crop"
        Me.colcrop.Name = "colcrop"
        Me.colcrop.Visible = True
        Me.colcrop.VisibleIndex = 2
        Me.colcrop.Width = 99
        '
        'colharvest
        '
        Me.colharvest.Caption = "Harvest"
        Me.colharvest.FieldName = "harvest"
        Me.colharvest.Name = "colharvest"
        Me.colharvest.Visible = True
        Me.colharvest.VisibleIndex = 3
        '
        'colvariety
        '
        Me.colvariety.Caption = "Variety"
        Me.colvariety.FieldName = "variety"
        Me.colvariety.Name = "colvariety"
        Me.colvariety.Visible = True
        Me.colvariety.VisibleIndex = 4
        Me.colvariety.Width = 76
        '
        'colstaff
        '
        Me.colstaff.Caption = "Staff"
        Me.colstaff.FieldName = "staff"
        Me.colstaff.Name = "colstaff"
        Me.colstaff.Visible = True
        Me.colstaff.VisibleIndex = 5
        Me.colstaff.Width = 117
        '
        'colkab
        '
        Me.colkab.Caption = "Kab"
        Me.colkab.FieldName = "kab"
        Me.colkab.Name = "colkab"
        Me.colkab.Visible = True
        Me.colkab.VisibleIndex = 6
        '
        'colkec
        '
        Me.colkec.Caption = "Kec"
        Me.colkec.FieldName = "kec"
        Me.colkec.Name = "colkec"
        Me.colkec.Visible = True
        Me.colkec.VisibleIndex = 7
        '
        'coldesa
        '
        Me.coldesa.Caption = "desa"
        Me.coldesa.FieldName = "desa"
        Me.coldesa.Name = "coldesa"
        Me.coldesa.Visible = True
        Me.coldesa.VisibleIndex = 8
        '
        'coldusun
        '
        Me.coldusun.Caption = "Dusun"
        Me.coldusun.FieldName = "dusun"
        Me.coldusun.Name = "coldusun"
        Me.coldusun.Visible = True
        Me.coldusun.VisibleIndex = 9
        '
        'colnorencana
        '
        Me.colnorencana.Caption = "No Rencana"
        Me.colnorencana.FieldName = "norencana"
        Me.colnorencana.Name = "colnorencana"
        Me.colnorencana.Visible = True
        Me.colnorencana.VisibleIndex = 10
        '
        'colnokontrak
        '
        Me.colnokontrak.Caption = "No Kontrak"
        Me.colnokontrak.FieldName = "nokontrak"
        Me.colnokontrak.Name = "colnokontrak"
        Me.colnokontrak.Visible = True
        Me.colnokontrak.VisibleIndex = 11
        Me.colnokontrak.Width = 133
        '
        'colblokno
        '
        Me.colblokno.Caption = "No Block"
        Me.colblokno.FieldName = "blokno"
        Me.colblokno.Name = "colblokno"
        Me.colblokno.Visible = True
        Me.colblokno.VisibleIndex = 12
        '
        'colcgrno
        '
        Me.colcgrno.Caption = "No CGR"
        Me.colcgrno.FieldName = "cgrno"
        Me.colcgrno.Name = "colcgrno"
        Me.colcgrno.Visible = True
        Me.colcgrno.VisibleIndex = 13
        '
        'colcgrname
        '
        Me.colcgrname.Caption = "CGR Name"
        Me.colcgrname.FieldName = "cgrname"
        Me.colcgrname.Name = "colcgrname"
        Me.colcgrname.Visible = True
        Me.colcgrname.VisibleIndex = 14
        '
        'colupload_date
        '
        Me.colupload_date.Caption = "Upload"
        Me.colupload_date.FieldName = "upload_date"
        Me.colupload_date.Name = "colupload_date"
        Me.colupload_date.Visible = True
        Me.colupload_date.VisibleIndex = 16
        '
        'coljoblot
        '
        Me.coljoblot.Caption = "Lot/Job"
        Me.coljoblot.FieldName = "joblot"
        Me.coljoblot.Name = "coljoblot"
        Me.coljoblot.Visible = True
        Me.coljoblot.VisibleIndex = 15
        '
        'HarvestProductionTableAdapter
        '
        Me.HarvestProductionTableAdapter.ClearBeforeFill = True
        '
        'NavigationFrame1
        '
        Me.NavigationFrame1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NavigationFrame1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.NavigationFrame1.Appearance.Options.UseBackColor = True
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage1)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage2)
        Me.NavigationFrame1.Location = New System.Drawing.Point(23, 86)
        Me.NavigationFrame1.Name = "NavigationFrame1"
        Me.NavigationFrame1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.NavigationPage1, Me.NavigationPage2})
        Me.NavigationFrame1.SelectedPage = Me.NavigationPage2
        Me.NavigationFrame1.Size = New System.Drawing.Size(886, 394)
        Me.NavigationFrame1.TabIndex = 1
        Me.NavigationFrame1.Text = "NavigationFrame1"
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Caption = "NavigationPage1"
        Me.NavigationPage1.Controls.Add(Me.MetroLink1)
        Me.NavigationPage1.Controls.Add(Me.GridControl1)
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Size = New System.Drawing.Size(886, 394)
        '
        'MetroLink1
        '
        Me.MetroLink1.AutoSize = True
        Me.MetroLink1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLink1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroLink1.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.MetroLink1.Location = New System.Drawing.Point(3, 3)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(84, 23)
        Me.MetroLink1.TabIndex = 107
        Me.MetroLink1.TabStop = False
        Me.MetroLink1.Text = "Refresh"
        Me.MetroLink1.UseCustomBackColor = True
        Me.MetroLink1.UseSelectable = True
        Me.MetroLink1.UseStyleColors = True
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Controls.Add(Me.MetroLabel4)
        Me.NavigationPage2.Controls.Add(Me.MetroLabel3)
        Me.NavigationPage2.Controls.Add(Me.trequestcopy)
        Me.NavigationPage2.Controls.Add(Me.MetroLabel7)
        Me.NavigationPage2.Controls.Add(Me.LabelMark)
        Me.NavigationPage2.Controls.Add(Me.MetroLabel8)
        Me.NavigationPage2.Controls.Add(Me.MetroLabel9)
        Me.NavigationPage2.Controls.Add(Me.LabelPrinter)
        Me.NavigationPage2.Controls.Add(Me.Label9)
        Me.NavigationPage2.Controls.Add(Me.PictureBox1)
        Me.NavigationPage2.Controls.Add(Me.LabelCount)
        Me.NavigationPage2.Controls.Add(Me.MetroLabel2)
        Me.NavigationPage2.Controls.Add(Me.BtnPreview)
        Me.NavigationPage2.Controls.Add(Me.BtnSendBack)
        Me.NavigationPage2.Controls.Add(Me.BtnSend)
        Me.NavigationPage2.Controls.Add(Me.MetroGrid2)
        Me.NavigationPage2.Controls.Add(Me.MetroGrid1)
        Me.NavigationPage2.Controls.Add(Me.MetroLink2)
        Me.NavigationPage2.Controls.Add(Me.linkClearAll)
        Me.NavigationPage2.Controls.Add(Me.MetroLabel6)
        Me.NavigationPage2.Controls.Add(Me.MetroLabel1)
        Me.NavigationPage2.Controls.Add(Me.LInkRefresh)
        Me.NavigationPage2.Controls.Add(Me.CheckBox1)
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Size = New System.Drawing.Size(886, 394)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.Location = New System.Drawing.Point(442, 379)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(222, 15)
        Me.MetroLabel4.TabIndex = 108
        Me.MetroLabel4.Text = "Step 2 : Evaluation ID Code that will to print"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel3.Location = New System.Drawing.Point(3, 379)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(205, 15)
        Me.MetroLabel3.TabIndex = 109
        Me.MetroLabel3.Text = "Step 1 : Select and check on this data list"
        '
        'trequestcopy
        '
        Me.trequestcopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.trequestcopy.CustomButton.Image = Nothing
        Me.trequestcopy.CustomButton.Location = New System.Drawing.Point(19, 1)
        Me.trequestcopy.CustomButton.Name = ""
        Me.trequestcopy.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.trequestcopy.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.trequestcopy.CustomButton.TabIndex = 1
        Me.trequestcopy.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.trequestcopy.CustomButton.UseSelectable = True
        Me.trequestcopy.CustomButton.Visible = False
        Me.trequestcopy.Lines = New String() {"1"}
        Me.trequestcopy.Location = New System.Drawing.Point(811, 196)
        Me.trequestcopy.MaxLength = 32767
        Me.trequestcopy.Name = "trequestcopy"
        Me.trequestcopy.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.trequestcopy.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.trequestcopy.SelectedText = ""
        Me.trequestcopy.SelectionLength = 0
        Me.trequestcopy.SelectionStart = 0
        Me.trequestcopy.ShortcutsEnabled = True
        Me.trequestcopy.Size = New System.Drawing.Size(41, 23)
        Me.trequestcopy.TabIndex = 106
        Me.trequestcopy.Text = "1"
        Me.trequestcopy.UseSelectable = True
        Me.trequestcopy.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.trequestcopy.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel7
        '
        Me.MetroLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(679, 196)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(123, 19)
        Me.MetroLabel7.TabIndex = 105
        Me.MetroLabel7.Text = "3. Number of Copy"
        '
        'LabelMark
        '
        Me.LabelMark.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelMark.AutoSize = True
        Me.LabelMark.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelMark.ForeColor = System.Drawing.Color.DarkGray
        Me.LabelMark.Location = New System.Drawing.Point(679, 325)
        Me.LabelMark.Name = "LabelMark"
        Me.LabelMark.Size = New System.Drawing.Size(25, 15)
        Me.LabelMark.TabIndex = 104
        Me.LabelMark.Text = "LA1"
        Me.LabelMark.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LabelMark.UseCustomForeColor = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(679, 125)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(165, 38)
        Me.MetroLabel8.TabIndex = 103
        Me.MetroLabel8.Text = "2. Tranfer or Send back To " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Printable List"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel9.Location = New System.Drawing.Point(694, 170)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(81, 15)
        Me.MetroLabel9.TabIndex = 102
        Me.MetroLabel9.Text = "Printed Count"
        Me.MetroLabel9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelPrinter
        '
        Me.LabelPrinter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelPrinter.BackColor = System.Drawing.Color.Transparent
        Me.LabelPrinter.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LabelPrinter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelPrinter.Location = New System.Drawing.Point(679, 254)
        Me.LabelPrinter.Name = "LabelPrinter"
        Me.LabelPrinter.Size = New System.Drawing.Size(207, 23)
        Me.LabelPrinter.TabIndex = 101
        Me.LabelPrinter.Text = "..."
        Me.LabelPrinter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelPrinter.UseCustomBackColor = True
        Me.LabelPrinter.UseSelectable = True
        Me.LabelPrinter.UseStyleColors = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label9.Location = New System.Drawing.Point(679, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 15)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Termal Printer :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(694, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 99
        Me.PictureBox1.TabStop = False
        '
        'LabelCount
        '
        Me.LabelCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCount.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LabelCount.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.LabelCount.Location = New System.Drawing.Point(787, 170)
        Me.LabelCount.Name = "LabelCount"
        Me.LabelCount.Size = New System.Drawing.Size(65, 15)
        Me.LabelCount.TabIndex = 97
        Me.LabelCount.Text = "..."
        Me.LabelCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(679, 29)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(173, 19)
        Me.MetroLabel2.TabIndex = 98
        Me.MetroLabel2.Text = "1. Select kotak pada DataList"
        '
        'BtnPreview
        '
        Me.BtnPreview.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPreview.BorderRadius = 0
        Me.BtnPreview.ButtonText = "Print"
        Me.BtnPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPreview.DisabledColor = System.Drawing.Color.Gray
        Me.BtnPreview.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnPreview.Iconimage = CType(resources.GetObject("BtnPreview.Iconimage"), System.Drawing.Image)
        Me.BtnPreview.Iconimage_right = Nothing
        Me.BtnPreview.Iconimage_right_Selected = Nothing
        Me.BtnPreview.Iconimage_Selected = Nothing
        Me.BtnPreview.IconMarginLeft = 0
        Me.BtnPreview.IconMarginRight = 0
        Me.BtnPreview.IconRightVisible = False
        Me.BtnPreview.IconRightZoom = 0R
        Me.BtnPreview.IconVisible = False
        Me.BtnPreview.IconZoom = 50.0R
        Me.BtnPreview.IsTab = False
        Me.BtnPreview.Location = New System.Drawing.Point(679, 292)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnPreview.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPreview.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnPreview.selected = True
        Me.BtnPreview.Size = New System.Drawing.Size(173, 30)
        Me.BtnPreview.TabIndex = 96
        Me.BtnPreview.Text = "Print"
        Me.BtnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPreview.Textcolor = System.Drawing.Color.White
        Me.BtnPreview.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnSendBack
        '
        Me.BtnSendBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSendBack.BackColor = System.Drawing.Color.Brown
        Me.BtnSendBack.Image = CType(resources.GetObject("BtnSendBack.Image"), System.Drawing.Image)
        Me.BtnSendBack.ImageActive = Nothing
        Me.BtnSendBack.Location = New System.Drawing.Point(397, 187)
        Me.BtnSendBack.Name = "BtnSendBack"
        Me.BtnSendBack.Size = New System.Drawing.Size(39, 24)
        Me.BtnSendBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnSendBack.TabIndex = 94
        Me.BtnSendBack.TabStop = False
        Me.BtnSendBack.Zoom = 10
        '
        'BtnSend
        '
        Me.BtnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSend.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnSend.Image = CType(resources.GetObject("BtnSend.Image"), System.Drawing.Image)
        Me.BtnSend.ImageActive = Nothing
        Me.BtnSend.Location = New System.Drawing.Point(397, 157)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(39, 24)
        Me.BtnSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnSend.TabIndex = 95
        Me.BtnSend.TabStop = False
        Me.BtnSend.Zoom = 10
        '
        'MetroGrid2
        '
        Me.MetroGrid2.AllowUserToAddRows = False
        Me.MetroGrid2.AllowUserToDeleteRows = False
        Me.MetroGrid2.AllowUserToResizeRows = False
        Me.MetroGrid2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.MetroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CekColumn, Me.IdColumn, Me.VarietyColumn, Me.CropColumn, Me.PlantColumn, Me.ContractColumn, Me.HarvestColumn2})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid2.DefaultCellStyle = DataGridViewCellStyle8
        Me.MetroGrid2.EnableHeadersVisualStyles = False
        Me.MetroGrid2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid2.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid2.Location = New System.Drawing.Point(442, 29)
        Me.MetroGrid2.Name = "MetroGrid2"
        Me.MetroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid2.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.MetroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid2.Size = New System.Drawing.Size(231, 347)
        Me.MetroGrid2.TabIndex = 93
        '
        'CekColumn
        '
        Me.CekColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.CekColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CekColumn.HeaderText = ""
        Me.CekColumn.MinimumWidth = 50
        Me.CekColumn.Name = "CekColumn"
        Me.CekColumn.Width = 50
        '
        'IdColumn
        '
        Me.IdColumn.HeaderText = "Production Code"
        Me.IdColumn.Name = "IdColumn"
        '
        'VarietyColumn
        '
        Me.VarietyColumn.HeaderText = "Variety"
        Me.VarietyColumn.Name = "VarietyColumn"
        '
        'CropColumn
        '
        Me.CropColumn.HeaderText = "Area"
        Me.CropColumn.Name = "CropColumn"
        '
        'PlantColumn
        '
        Me.PlantColumn.HeaderText = "Plant No"
        Me.PlantColumn.Name = "PlantColumn"
        '
        'ContractColumn
        '
        Me.ContractColumn.HeaderText = "Contract No"
        Me.ContractColumn.Name = "ContractColumn"
        '
        'HarvestColumn2
        '
        Me.HarvestColumn2.HeaderText = "Harvest"
        Me.HarvestColumn2.Name = "HarvestColumn2"
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroGrid1.AutoGenerateColumns = False
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckColumn, Me.IdcodeColumn1, Me.areaColumn, Me.VarietyColumn1, Me.CropColumn1, Me.norencanaColumn1, Me.HarvestColumn1, Me.ContractColumn1, Me.CgrColumn1, Me.Count, Me.LastPrint})
        Me.MetroGrid1.DataSource = Me.Reporta1BindingSource
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle11
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(3, 29)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(388, 347)
        Me.MetroGrid1.TabIndex = 92
        '
        'CheckColumn
        '
        Me.CheckColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckColumn.HeaderText = ""
        Me.CheckColumn.Name = "CheckColumn"
        Me.CheckColumn.Width = 55
        '
        'IdcodeColumn1
        '
        Me.IdcodeColumn1.DataPropertyName = "idcode"
        Me.IdcodeColumn1.HeaderText = "Production Code"
        Me.IdcodeColumn1.Name = "IdcodeColumn1"
        '
        'areaColumn
        '
        Me.areaColumn.DataPropertyName = "area"
        Me.areaColumn.HeaderText = "Area"
        Me.areaColumn.Name = "areaColumn"
        '
        'VarietyColumn1
        '
        Me.VarietyColumn1.DataPropertyName = "variety"
        Me.VarietyColumn1.HeaderText = "Variety"
        Me.VarietyColumn1.Name = "VarietyColumn1"
        '
        'CropColumn1
        '
        Me.CropColumn1.DataPropertyName = "crop"
        Me.CropColumn1.HeaderText = "Crop"
        Me.CropColumn1.Name = "CropColumn1"
        '
        'norencanaColumn1
        '
        Me.norencanaColumn1.DataPropertyName = "norencana"
        Me.norencanaColumn1.HeaderText = "No Rencana"
        Me.norencanaColumn1.Name = "norencanaColumn1"
        '
        'HarvestColumn1
        '
        Me.HarvestColumn1.DataPropertyName = "harvest"
        Me.HarvestColumn1.HeaderText = "Harvest Date"
        Me.HarvestColumn1.Name = "HarvestColumn1"
        '
        'ContractColumn1
        '
        Me.ContractColumn1.DataPropertyName = "nokontrak"
        Me.ContractColumn1.HeaderText = "Contact No"
        Me.ContractColumn1.Name = "ContractColumn1"
        '
        'CgrColumn1
        '
        Me.CgrColumn1.DataPropertyName = "cgrname"
        Me.CgrColumn1.HeaderText = "CGR Name"
        Me.CgrColumn1.Name = "CgrColumn1"
        '
        'Count
        '
        Me.Count.DataPropertyName = "Count"
        Me.Count.HeaderText = "Print Count"
        Me.Count.Name = "Count"
        Me.Count.Width = 70
        '
        'LastPrint
        '
        Me.LastPrint.DataPropertyName = "LastPrint"
        Me.LastPrint.HeaderText = "Last Print"
        Me.LastPrint.Name = "LastPrint"
        '
        'Reporta1BindingSource
        '
        Me.Reporta1BindingSource.DataMember = "report_a1"
        Me.Reporta1BindingSource.DataSource = Me.HCQC_NewDataset
        '
        'MetroLink2
        '
        Me.MetroLink2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLink2.AutoSize = True
        Me.MetroLink2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLink2.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.MetroLink2.Location = New System.Drawing.Point(229, 3)
        Me.MetroLink2.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLink2.Name = "MetroLink2"
        Me.MetroLink2.Size = New System.Drawing.Size(81, 23)
        Me.MetroLink2.TabIndex = 91
        Me.MetroLink2.Text = "Fillter To Print"
        Me.MetroLink2.UseCustomBackColor = True
        Me.MetroLink2.UseSelectable = True
        Me.MetroLink2.UseStyleColors = True
        '
        'linkClearAll
        '
        Me.linkClearAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkClearAll.AutoSize = True
        Me.linkClearAll.BackColor = System.Drawing.Color.Transparent
        Me.linkClearAll.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.linkClearAll.Location = New System.Drawing.Point(617, 0)
        Me.linkClearAll.Name = "linkClearAll"
        Me.linkClearAll.Size = New System.Drawing.Size(57, 23)
        Me.linkClearAll.TabIndex = 90
        Me.linkClearAll.Text = "Clear All"
        Me.linkClearAll.UseCustomBackColor = True
        Me.linkClearAll.UseSelectable = True
        Me.linkClearAll.UseStyleColors = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Location = New System.Drawing.Point(3, 0)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(83, 23)
        Me.MetroLabel6.TabIndex = 88
        Me.MetroLabel6.Text = "Data List"
        Me.MetroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.Location = New System.Drawing.Point(442, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(83, 23)
        Me.MetroLabel1.TabIndex = 89
        Me.MetroLabel1.Text = "Printable List"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LInkRefresh
        '
        Me.LInkRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LInkRefresh.AutoSize = True
        Me.LInkRefresh.BackColor = System.Drawing.Color.Transparent
        Me.LInkRefresh.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LInkRefresh.Location = New System.Drawing.Point(175, 3)
        Me.LInkRefresh.Margin = New System.Windows.Forms.Padding(0)
        Me.LInkRefresh.Name = "LInkRefresh"
        Me.LInkRefresh.Size = New System.Drawing.Size(54, 23)
        Me.LInkRefresh.TabIndex = 87
        Me.LInkRefresh.Text = "Refresh"
        Me.LInkRefresh.UseCustomBackColor = True
        Me.LInkRefresh.UseSelectable = True
        Me.LInkRefresh.UseStyleColors = True
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.Location = New System.Drawing.Point(313, 3)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(78, 23)
        Me.CheckBox1.TabIndex = 86
        Me.CheckBox1.Text = "Select All"
        Me.CheckBox1.UseSelectable = True
        '
        'LinkData
        '
        Me.LinkData.AutoSize = True
        Me.LinkData.BackColor = System.Drawing.Color.Transparent
        Me.LinkData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkData.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.LinkData.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.LinkData.Location = New System.Drawing.Point(23, 57)
        Me.LinkData.Name = "LinkData"
        Me.LinkData.Size = New System.Drawing.Size(136, 23)
        Me.LinkData.TabIndex = 105
        Me.LinkData.TabStop = False
        Me.LinkData.Text = "Data Production"
        Me.LinkData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkData.UseCustomBackColor = True
        Me.LinkData.UseSelectable = True
        Me.LinkData.UseStyleColors = True
        '
        'LinkReport
        '
        Me.LinkReport.AutoSize = True
        Me.LinkReport.BackColor = System.Drawing.Color.Transparent
        Me.LinkReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkReport.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.LinkReport.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.LinkReport.Location = New System.Drawing.Point(165, 57)
        Me.LinkReport.Name = "LinkReport"
        Me.LinkReport.Size = New System.Drawing.Size(148, 23)
        Me.LinkReport.TabIndex = 106
        Me.LinkReport.TabStop = False
        Me.LinkReport.Text = "Barcode Production"
        Me.LinkReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkReport.UseCustomBackColor = True
        Me.LinkReport.UseSelectable = True
        Me.LinkReport.UseStyleColors = True
        '
        'Report_a1TableAdapter
        '
        Me.Report_a1TableAdapter.ClearBeforeFill = True
        '
        'LinkImport
        '
        Me.LinkImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkImport.AutoSize = True
        Me.LinkImport.BackColor = System.Drawing.Color.Transparent
        Me.LinkImport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkImport.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.LinkImport.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.LinkImport.Location = New System.Drawing.Point(810, 57)
        Me.LinkImport.Name = "LinkImport"
        Me.LinkImport.Size = New System.Drawing.Size(99, 23)
        Me.LinkImport.TabIndex = 106
        Me.LinkImport.TabStop = False
        Me.LinkImport.Text = "Import Data"
        Me.LinkImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LinkImport.UseCustomBackColor = True
        Me.LinkImport.UseSelectable = True
        Me.LinkImport.UseStyleColors = True
        '
        'LinkDirectUpdateSAS
        '
        Me.LinkDirectUpdateSAS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkDirectUpdateSAS.AutoSize = True
        Me.LinkDirectUpdateSAS.BackColor = System.Drawing.Color.Transparent
        Me.LinkDirectUpdateSAS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkDirectUpdateSAS.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.LinkDirectUpdateSAS.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.LinkDirectUpdateSAS.Location = New System.Drawing.Point(673, 57)
        Me.LinkDirectUpdateSAS.Name = "LinkDirectUpdateSAS"
        Me.LinkDirectUpdateSAS.Size = New System.Drawing.Size(131, 23)
        Me.LinkDirectUpdateSAS.TabIndex = 106
        Me.LinkDirectUpdateSAS.TabStop = False
        Me.LinkDirectUpdateSAS.Text = "Direct Import SAS"
        Me.LinkDirectUpdateSAS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LinkDirectUpdateSAS.UseCustomBackColor = True
        Me.LinkDirectUpdateSAS.UseSelectable = True
        Me.LinkDirectUpdateSAS.UseStyleColors = True
        '
        'ComboBtn1
        '
        Me.ComboBtn1.DisplayFocus = True
        Me.ComboBtn1.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.ComboBtn1.FontWeight = MetroFramework.MetroComboBoxWeight.Light
        Me.ComboBtn1.ItemHeight = 19
        Me.ComboBtn1.Items.AddRange(New Object() {"2022", "2021"})
        Me.ComboBtn1.Location = New System.Drawing.Point(319, 55)
        Me.ComboBtn1.Name = "ComboBtn1"
        Me.ComboBtn1.PromptText = "Pilih Tahun"
        Me.ComboBtn1.Size = New System.Drawing.Size(79, 25)
        Me.ComboBtn1.Style = MetroFramework.MetroColorStyle.Blue
        Me.ComboBtn1.TabIndex = 107
        Me.ComboBtn1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ComboBtn1.UseSelectable = True
        Me.ComboBtn1.UseStyleColors = True
        '
        'Harvest_Planning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 503)
        Me.Controls.Add(Me.ComboBtn1)
        Me.Controls.Add(Me.LinkDirectUpdateSAS)
        Me.Controls.Add(Me.LinkImport)
        Me.Controls.Add(Me.LinkReport)
        Me.Controls.Add(Me.LinkData)
        Me.Controls.Add(Me.NavigationFrame1)
        Me.Name = "Harvest_Planning"
        Me.Text = "Harvest Planning Production"
        CType(Me.HarvestProductionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavigationFrame1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationFrame1.ResumeLayout(False)
        Me.NavigationPage1.ResumeLayout(False)
        Me.NavigationPage1.PerformLayout()
        Me.NavigationPage2.ResumeLayout(False)
        Me.NavigationPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSendBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reporta1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RealTimeSource1 As DevExpress.Data.RealTimeSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents HCQC_NewDataset As HCQC_NewDataset
    Friend WithEvents HarvestProductionBindingSource As BindingSource
    Friend WithEvents HarvestProductionTableAdapter As HCQC_NewDatasetTableAdapters.HarvestProductionTableAdapter
    Friend WithEvents colidcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcrop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colharvest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvariety As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstaff As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkab As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkec As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldesa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldusun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnorencana As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnokontrak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colblokno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcgrno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcgrname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colupload_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coljoblot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NavigationFrame1 As DevExpress.XtraBars.Navigation.NavigationFrame
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents MetroLink2 As MetroLink
    Friend WithEvents linkClearAll As MetroLink
    Friend WithEvents MetroLabel6 As MetroLabel
    Friend WithEvents MetroLabel1 As MetroLabel
    Friend WithEvents LInkRefresh As MetroLink
    Friend WithEvents CheckBox1 As MetroCheckBox
    Friend WithEvents BtnSendBack As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BtnSend As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents MetroGrid2 As MetroGrid
    Friend WithEvents CekColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IdColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarietyColumn As DataGridViewTextBoxColumn
    Friend WithEvents CropColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlantColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContractColumn As DataGridViewTextBoxColumn
    Friend WithEvents HarvestColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents MetroGrid1 As MetroGrid
    Friend WithEvents trequestcopy As MetroTextBox
    Friend WithEvents MetroLabel7 As MetroLabel
    Friend WithEvents LabelMark As MetroLabel
    Friend WithEvents MetroLabel8 As MetroLabel
    Friend WithEvents MetroLabel9 As MetroLabel
    Friend WithEvents LabelPrinter As MetroLink
    Friend WithEvents Label9 As MetroLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelCount As MetroLabel
    Friend WithEvents MetroLabel2 As MetroLabel
    Friend WithEvents BtnPreview As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MetroLabel4 As MetroLabel
    Friend WithEvents MetroLabel3 As MetroLabel
    Friend WithEvents LinkData As MetroLink
    Friend WithEvents LinkReport As MetroLink
    Friend WithEvents Reporta1BindingSource As BindingSource
    Friend WithEvents CheckColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IdcodeColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents areaColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarietyColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CropColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents norencanaColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents HarvestColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ContractColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CgrColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Count As DataGridViewTextBoxColumn
    Friend WithEvents LastPrint As DataGridViewTextBoxColumn
    Friend WithEvents Report_a1TableAdapter As HCQC_NewDatasetTableAdapters.report_a1TableAdapter
    Friend WithEvents LinkImport As MetroLink
    Friend WithEvents MetroLink1 As MetroLink
    Friend WithEvents LinkDirectUpdateSAS As MetroLink
    Friend WithEvents ComboBtn1 As MetroComboBox
End Class
