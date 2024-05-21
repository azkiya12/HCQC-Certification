<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HC_Sample_Test_Control
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
        Me.components = New System.ComponentModel.Container()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ReportstatuspengujianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_NewDataset = New HCQC_NewDataset()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collabnum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colid_hvsprod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvariety = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnomnl = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnojob = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colweight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfarmer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colharvest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colscope = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltest_sampling = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltest_moi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltest_pur = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltest_ger = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltest_via = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltest_raf = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltest_ontest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colinput_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceipt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbrt_in = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceipt_Input = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsampler = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsampling = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRaf_Test = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRaf_Result = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRaf_Analys = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRaf_input = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMoi_Test = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMoi_Analys = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMoi_input = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGer_TestLog = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGer_Test = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGer_1st = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGer_1st_Est = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGer_2nd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGer_2nd_Est = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGer_Analys = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGer_input = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVia_Test = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVia_Analys = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVia_input = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPur_Test = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPur_Analys = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPur_input = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuick_Raf = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRetunQC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReturnQC_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatusResult = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldays_est = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Report_status_pengujianTableAdapter = New HCQC_NewDatasetTableAdapters.report_status_pengujianTableAdapter()
        Me.LinkRefresh = New MetroFramework.Controls.MetroLink()
        Me.coldate_est = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportstatuspengujianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.ReportstatuspengujianBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(20, 60)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(760, 370)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ReportstatuspengujianBindingSource
        '
        Me.ReportstatuspengujianBindingSource.DataMember = "report_status_pengujian"
        Me.ReportstatuspengujianBindingSource.DataSource = Me.HCQC_NewDataset
        '
        'HCQC_NewDataset
        '
        Me.HCQC_NewDataset.DataSetName = "HCQC_NewDataset"
        Me.HCQC_NewDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.collabnum, Me.colid_hvsprod, Me.colvariety, Me.colnomnl, Me.colnojob, Me.colweight, Me.colfarmer, Me.collocation, Me.colharvest, Me.colscope, Me.coltest_sampling, Me.coltest_moi, Me.coltest_pur, Me.coltest_ger, Me.coltest_via, Me.coltest_raf, Me.coltest_ontest, Me.colinput_date, Me.colReceipt, Me.colbrt_in, Me.colReceipt_Input, Me.colsampler, Me.colsampling, Me.colRaf_Test, Me.colRaf_Result, Me.colRaf_Analys, Me.colRaf_input, Me.colMoi_Test, Me.colMoi_Analys, Me.colMoi_input, Me.colGer_TestLog, Me.colGer_Test, Me.colGer_1st, Me.colGer_1st_Est, Me.colGer_2nd, Me.colGer_2nd_Est, Me.colGer_Analys, Me.colGer_input, Me.colVia_Test, Me.colVia_Analys, Me.colVia_input, Me.colPur_Test, Me.colPur_Analys, Me.colPur_input, Me.colQuick_Raf, Me.colRetunQC, Me.colReturnQC_Name, Me.colStatusResult, Me.coldays_est, Me.coldate_est})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.GridView1.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colid
        '
        Me.colid.Caption = "No Request"
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        Me.colid.Visible = True
        Me.colid.VisibleIndex = 0
        '
        'collabnum
        '
        Me.collabnum.Caption = "Lab Number"
        Me.collabnum.FieldName = "labnum"
        Me.collabnum.Name = "collabnum"
        Me.collabnum.Visible = True
        Me.collabnum.VisibleIndex = 2
        Me.collabnum.Width = 98
        '
        'colid_hvsprod
        '
        Me.colid_hvsprod.Caption = "No Production"
        Me.colid_hvsprod.FieldName = "id_hvsprod"
        Me.colid_hvsprod.Name = "colid_hvsprod"
        Me.colid_hvsprod.Visible = True
        Me.colid_hvsprod.VisibleIndex = 1
        Me.colid_hvsprod.Width = 90
        '
        'colvariety
        '
        Me.colvariety.Caption = "Variety"
        Me.colvariety.FieldName = "variety"
        Me.colvariety.Name = "colvariety"
        Me.colvariety.Visible = True
        Me.colvariety.VisibleIndex = 3
        '
        'colnomnl
        '
        Me.colnomnl.Caption = "Manual"
        Me.colnomnl.FieldName = "nomnl"
        Me.colnomnl.Name = "colnomnl"
        Me.colnomnl.Visible = True
        Me.colnomnl.VisibleIndex = 4
        '
        'colnojob
        '
        Me.colnojob.Caption = "Lot/Job"
        Me.colnojob.FieldName = "nojob"
        Me.colnojob.Name = "colnojob"
        Me.colnojob.Visible = True
        Me.colnojob.VisibleIndex = 5
        '
        'colweight
        '
        Me.colweight.Caption = "Weight (kg)"
        Me.colweight.FieldName = "weight"
        Me.colweight.Name = "colweight"
        Me.colweight.Visible = True
        Me.colweight.VisibleIndex = 8
        Me.colweight.Width = 79
        '
        'colfarmer
        '
        Me.colfarmer.Caption = "Farmer"
        Me.colfarmer.FieldName = "farmer"
        Me.colfarmer.Name = "colfarmer"
        Me.colfarmer.Visible = True
        Me.colfarmer.VisibleIndex = 6
        Me.colfarmer.Width = 94
        '
        'collocation
        '
        Me.collocation.Caption = "Location"
        Me.collocation.FieldName = "location"
        Me.collocation.Name = "collocation"
        Me.collocation.Visible = True
        Me.collocation.VisibleIndex = 7
        '
        'colharvest
        '
        Me.colharvest.Caption = "Harvest"
        Me.colharvest.FieldName = "harvest"
        Me.colharvest.Name = "colharvest"
        Me.colharvest.Visible = True
        Me.colharvest.VisibleIndex = 9
        '
        'colscope
        '
        Me.colscope.Caption = "Scope"
        Me.colscope.FieldName = "scope"
        Me.colscope.Name = "colscope"
        Me.colscope.Visible = True
        Me.colscope.VisibleIndex = 10
        Me.colscope.Width = 109
        '
        'coltest_sampling
        '
        Me.coltest_sampling.Caption = "Test Sampling"
        Me.coltest_sampling.FieldName = "test_sampling"
        Me.coltest_sampling.Name = "coltest_sampling"
        Me.coltest_sampling.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.coltest_sampling.Visible = True
        Me.coltest_sampling.VisibleIndex = 11
        Me.coltest_sampling.Width = 80
        '
        'coltest_moi
        '
        Me.coltest_moi.Caption = "Test Moisture"
        Me.coltest_moi.FieldName = "test_moi"
        Me.coltest_moi.Name = "coltest_moi"
        Me.coltest_moi.Visible = True
        Me.coltest_moi.VisibleIndex = 12
        Me.coltest_moi.Width = 79
        '
        'coltest_pur
        '
        Me.coltest_pur.Caption = "Test Purity"
        Me.coltest_pur.FieldName = "test_pur"
        Me.coltest_pur.Name = "coltest_pur"
        Me.coltest_pur.Visible = True
        Me.coltest_pur.VisibleIndex = 13
        Me.coltest_pur.Width = 67
        '
        'coltest_ger
        '
        Me.coltest_ger.Caption = "Test Germination"
        Me.coltest_ger.FieldName = "test_ger"
        Me.coltest_ger.Name = "coltest_ger"
        Me.coltest_ger.Visible = True
        Me.coltest_ger.VisibleIndex = 14
        Me.coltest_ger.Width = 93
        '
        'coltest_via
        '
        Me.coltest_via.Caption = "Test Viability"
        Me.coltest_via.FieldName = "test_via"
        Me.coltest_via.Name = "coltest_via"
        Me.coltest_via.Visible = True
        Me.coltest_via.VisibleIndex = 15
        Me.coltest_via.Width = 74
        '
        'coltest_raf
        '
        Me.coltest_raf.Caption = "Test Rafaction"
        Me.coltest_raf.FieldName = "test_raf"
        Me.coltest_raf.Name = "coltest_raf"
        Me.coltest_raf.Visible = True
        Me.coltest_raf.VisibleIndex = 16
        Me.coltest_raf.Width = 83
        '
        'coltest_ontest
        '
        Me.coltest_ontest.Caption = "On TestDB"
        Me.coltest_ontest.FieldName = "test_ontest"
        Me.coltest_ontest.Name = "coltest_ontest"
        '
        'colinput_date
        '
        Me.colinput_date.Caption = "Request Date"
        Me.colinput_date.FieldName = "input_date"
        Me.colinput_date.Name = "colinput_date"
        Me.colinput_date.Visible = True
        Me.colinput_date.VisibleIndex = 17
        Me.colinput_date.Width = 80
        '
        'colReceipt
        '
        Me.colReceipt.Caption = "Receipt Date"
        Me.colReceipt.FieldName = "Receipt"
        Me.colReceipt.Name = "colReceipt"
        Me.colReceipt.Visible = True
        Me.colReceipt.VisibleIndex = 18
        Me.colReceipt.Width = 76
        '
        'colbrt_in
        '
        Me.colbrt_in.Caption = "Receipt Sample (g)"
        Me.colbrt_in.FieldName = "brt_in"
        Me.colbrt_in.Name = "colbrt_in"
        Me.colbrt_in.Width = 113
        '
        'colReceipt_Input
        '
        Me.colReceipt_Input.Caption = "Receipt Input"
        Me.colReceipt_Input.FieldName = "Receipt_Input"
        Me.colReceipt_Input.Name = "colReceipt_Input"
        Me.colReceipt_Input.Width = 97
        '
        'colsampler
        '
        Me.colsampler.Caption = "Sampler"
        Me.colsampler.FieldName = "sampler"
        Me.colsampler.Name = "colsampler"
        Me.colsampler.Width = 67
        '
        'colsampling
        '
        Me.colsampling.Caption = "Sampling"
        Me.colsampling.FieldName = "sampling"
        Me.colsampling.Name = "colsampling"
        Me.colsampling.Visible = True
        Me.colsampling.VisibleIndex = 19
        Me.colsampling.Width = 67
        '
        'colRaf_Test
        '
        Me.colRaf_Test.Caption = "Raf Test"
        Me.colRaf_Test.FieldName = "Raf_Test"
        Me.colRaf_Test.Name = "colRaf_Test"
        Me.colRaf_Test.Visible = True
        Me.colRaf_Test.VisibleIndex = 20
        Me.colRaf_Test.Width = 80
        '
        'colRaf_Result
        '
        Me.colRaf_Result.Caption = "Raf Result"
        Me.colRaf_Result.FieldName = "Raf_Result"
        Me.colRaf_Result.Name = "colRaf_Result"
        Me.colRaf_Result.Width = 67
        '
        'colRaf_Analys
        '
        Me.colRaf_Analys.Caption = "Raf Analys"
        Me.colRaf_Analys.FieldName = "Raf_Analys"
        Me.colRaf_Analys.Name = "colRaf_Analys"
        Me.colRaf_Analys.Width = 67
        '
        'colRaf_input
        '
        Me.colRaf_input.Caption = "Raf input"
        Me.colRaf_input.FieldName = "Raf_input"
        Me.colRaf_input.Name = "colRaf_input"
        Me.colRaf_input.Width = 83
        '
        'colMoi_Test
        '
        Me.colMoi_Test.Caption = "Moisture Test"
        Me.colMoi_Test.FieldName = "Moi_Test"
        Me.colMoi_Test.Name = "colMoi_Test"
        Me.colMoi_Test.Visible = True
        Me.colMoi_Test.VisibleIndex = 21
        Me.colMoi_Test.Width = 92
        '
        'colMoi_Analys
        '
        Me.colMoi_Analys.Caption = "Moisture Analys"
        Me.colMoi_Analys.FieldName = "Moi_Analys"
        Me.colMoi_Analys.Name = "colMoi_Analys"
        Me.colMoi_Analys.Width = 93
        '
        'colMoi_input
        '
        Me.colMoi_input.Caption = "Moisture Input"
        Me.colMoi_input.FieldName = "Moi_input"
        Me.colMoi_input.Name = "colMoi_input"
        Me.colMoi_input.Width = 93
        '
        'colGer_TestLog
        '
        Me.colGer_TestLog.Caption = "Germination Test Log"
        Me.colGer_TestLog.FieldName = "Ger_TestLog"
        Me.colGer_TestLog.Name = "colGer_TestLog"
        Me.colGer_TestLog.Visible = True
        Me.colGer_TestLog.VisibleIndex = 22
        Me.colGer_TestLog.Width = 123
        '
        'colGer_Test
        '
        Me.colGer_Test.Caption = "Germination Test"
        Me.colGer_Test.FieldName = "Ger_Test"
        Me.colGer_Test.Name = "colGer_Test"
        Me.colGer_Test.Width = 109
        '
        'colGer_1st
        '
        Me.colGer_1st.Caption = "Germination 1st"
        Me.colGer_1st.FieldName = "Ger_1st"
        Me.colGer_1st.Name = "colGer_1st"
        Me.colGer_1st.Visible = True
        Me.colGer_1st.VisibleIndex = 24
        Me.colGer_1st.Width = 88
        '
        'colGer_1st_Est
        '
        Me.colGer_1st_Est.Caption = "Germ 1st Estm"
        Me.colGer_1st_Est.FieldName = "Ger_1st_Est"
        Me.colGer_1st_Est.Name = "colGer_1st_Est"
        Me.colGer_1st_Est.Visible = True
        Me.colGer_1st_Est.VisibleIndex = 23
        Me.colGer_1st_Est.Width = 82
        '
        'colGer_2nd
        '
        Me.colGer_2nd.Caption = "Germination 2nd"
        Me.colGer_2nd.FieldName = "Ger_2nd"
        Me.colGer_2nd.Name = "colGer_2nd"
        Me.colGer_2nd.Visible = True
        Me.colGer_2nd.VisibleIndex = 26
        Me.colGer_2nd.Width = 91
        '
        'colGer_2nd_Est
        '
        Me.colGer_2nd_Est.Caption = "Germ 2nd Estm"
        Me.colGer_2nd_Est.FieldName = "Ger_2nd_Est"
        Me.colGer_2nd_Est.Name = "colGer_2nd_Est"
        Me.colGer_2nd_Est.Visible = True
        Me.colGer_2nd_Est.VisibleIndex = 25
        Me.colGer_2nd_Est.Width = 88
        '
        'colGer_Analys
        '
        Me.colGer_Analys.Caption = "Germination Analys"
        Me.colGer_Analys.FieldName = "Ger_Analys"
        Me.colGer_Analys.Name = "colGer_Analys"
        Me.colGer_Analys.Width = 116
        '
        'colGer_input
        '
        Me.colGer_input.Caption = "Germination Input"
        Me.colGer_input.FieldName = "Ger_input"
        Me.colGer_input.Name = "colGer_input"
        Me.colGer_input.Width = 99
        '
        'colVia_Test
        '
        Me.colVia_Test.Caption = "Viability Test"
        Me.colVia_Test.FieldName = "Via_Test"
        Me.colVia_Test.Name = "colVia_Test"
        Me.colVia_Test.Visible = True
        Me.colVia_Test.VisibleIndex = 27
        Me.colVia_Test.Width = 82
        '
        'colVia_Analys
        '
        Me.colVia_Analys.Caption = "Viability Analys"
        Me.colVia_Analys.FieldName = "Via_Analys"
        Me.colVia_Analys.Name = "colVia_Analys"
        Me.colVia_Analys.Width = 99
        '
        'colVia_input
        '
        Me.colVia_input.Caption = "Viability Input"
        Me.colVia_input.FieldName = "Via_input"
        Me.colVia_input.Name = "colVia_input"
        Me.colVia_input.Width = 93
        '
        'colPur_Test
        '
        Me.colPur_Test.Caption = "Purity Test"
        Me.colPur_Test.FieldName = "Pur_Test"
        Me.colPur_Test.Name = "colPur_Test"
        Me.colPur_Test.Visible = True
        Me.colPur_Test.VisibleIndex = 28
        Me.colPur_Test.Width = 80
        '
        'colPur_Analys
        '
        Me.colPur_Analys.Caption = "Purity Analys"
        Me.colPur_Analys.FieldName = "Pur_Analys"
        Me.colPur_Analys.Name = "colPur_Analys"
        Me.colPur_Analys.Width = 88
        '
        'colPur_input
        '
        Me.colPur_input.Caption = "Purity Input"
        Me.colPur_input.FieldName = "Pur_input"
        Me.colPur_input.Name = "colPur_input"
        Me.colPur_input.Width = 67
        '
        'colQuick_Raf
        '
        Me.colQuick_Raf.Caption = "Quick Result Raf"
        Me.colQuick_Raf.FieldName = "Quick_Raf"
        Me.colQuick_Raf.Name = "colQuick_Raf"
        Me.colQuick_Raf.Width = 104
        '
        'colRetunQC
        '
        Me.colRetunQC.FieldName = "RetunQC"
        Me.colRetunQC.Name = "colRetunQC"
        Me.colRetunQC.Visible = True
        Me.colRetunQC.VisibleIndex = 29
        Me.colRetunQC.Width = 67
        '
        'colReturnQC_Name
        '
        Me.colReturnQC_Name.FieldName = "ReturnQC_Name"
        Me.colReturnQC_Name.Name = "colReturnQC_Name"
        Me.colReturnQC_Name.Width = 87
        '
        'colStatusResult
        '
        Me.colStatusResult.Caption = "Status Result"
        Me.colStatusResult.FieldName = "StatusResult"
        Me.colStatusResult.Name = "colStatusResult"
        Me.colStatusResult.Visible = True
        Me.colStatusResult.VisibleIndex = 30
        '
        'coldays_est
        '
        Me.coldays_est.Caption = "Days Est."
        Me.coldays_est.FieldName = "days_est"
        Me.coldays_est.Name = "coldays_est"
        Me.coldays_est.Visible = True
        Me.coldays_est.VisibleIndex = 31
        '
        'Report_status_pengujianTableAdapter
        '
        Me.Report_status_pengujianTableAdapter.ClearBeforeFill = True
        '
        'LinkRefresh
        '
        Me.LinkRefresh.AutoSize = True
        Me.LinkRefresh.BackColor = System.Drawing.Color.Transparent
        Me.LinkRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkRefresh.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.LinkRefresh.Location = New System.Drawing.Point(273, 29)
        Me.LinkRefresh.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkRefresh.Name = "LinkRefresh"
        Me.LinkRefresh.Size = New System.Drawing.Size(70, 23)
        Me.LinkRefresh.TabIndex = 58
        Me.LinkRefresh.Text = "Refresh"
        Me.LinkRefresh.UseCustomBackColor = True
        Me.LinkRefresh.UseSelectable = True
        Me.LinkRefresh.UseStyleColors = True
        '
        'coldate_est
        '
        Me.coldate_est.Caption = "Date Est."
        Me.coldate_est.FieldName = "date_est"
        Me.coldate_est.Name = "coldate_est"
        Me.coldate_est.Visible = True
        Me.coldate_est.VisibleIndex = 32
        '
        'HC_Sample_Test_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LinkRefresh)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "HC_Sample_Test_Control"
        Me.Text = "HC Sample Test Control"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportstatuspengujianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_NewDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents HCQC_NewDataset As HCQC_NewDataset
    Friend WithEvents ReportstatuspengujianBindingSource As BindingSource
    Friend WithEvents Report_status_pengujianTableAdapter As HCQC_NewDatasetTableAdapters.report_status_pengujianTableAdapter
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colid_hvsprod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collabnum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvariety As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnomnl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnojob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colweight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfarmer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colharvest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colscope As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltest_sampling As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltest_moi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltest_pur As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltest_ger As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltest_via As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltest_raf As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colinput_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceipt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbrt_in As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceipt_Input As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsampler As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsampling As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRaf_Test As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRaf_Result As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRaf_Analys As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRaf_input As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMoi_Test As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMoi_Analys As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMoi_input As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGer_Test As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGer_1st As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGer_2nd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGer_Analys As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGer_input As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVia_Test As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVia_Analys As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVia_input As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPur_Test As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPur_Analys As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPur_input As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuick_Raf As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRetunQC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReturnQC_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGer_TestLog As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LinkRefresh As MetroLink
    Friend WithEvents coltest_ontest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGer_1st_Est As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGer_2nd_Est As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatusResult As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldays_est As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate_est As DevExpress.XtraGrid.Columns.GridColumn
End Class
