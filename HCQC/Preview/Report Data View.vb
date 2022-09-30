Imports DgvFilterPopup
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Report_Data_View
    Private Sub Report_Data_View_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCQC_serverDataSet.wip_msk' table. You can move, or remove it, as needed.
        Me.Wip_mskTableAdapter.Fill(Me.HCQC_serverDataSet.wip_msk)

        Dim DgvFilter As New DgvFilterManager
        DgvFilter.DataGridView = MetroGrid1
        MetroGrid1.ColumnHeadersHeight = 25
    End Sub

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        Dim rpt As New Coba_WIP_Certification 'The report you created.
        Dim daptr As New SqlDataAdapter()
        Dim daptr1 As New SqlDataAdapter()
        Dim daptr2 As New SqlDataAdapter()
        Dim daptr3 As New SqlDataAdapter()
        Dim daptr4 As New SqlDataAdapter()
        Dim myDS As New HCQC_serverDataSet() 'The DataSet you created.
        Dim con1 As New SqlConnection
        Dim sql As String
        openDB()
        sql = "SELECT * FROM wip_id"
        daptr = New SqlDataAdapter(sql, con)
        'daptr = New SqlDataAdapter(MetroGrid1.SelectedRows, con)
        Sql = "SELECT * FROM wip_mt"
        daptr1 = New SqlDataAdapter(Sql, con)
        Sql = "SELECT * FROM wip_pa"
        daptr3 = New SqlDataAdapter(Sql, con)
        Sql = "SELECT *  FROM wip_ir"
        daptr2 = New SqlDataAdapter(Sql, con)
        Sql = "SELECT * FROM wip_vg"
        daptr4 = New SqlDataAdapter(Sql, con)

        myDS = New HCQC_serverDataSet
        'daptr.Fill(myDS, 0, 25, "wip_id")
        daptr1.Fill(myDS, "wip_mt")
        daptr3.Fill(myDS, "wip_pa")
        daptr2.Fill(myDS, "wip_ir")
        daptr4.Fill(myDS, "wip_vg")
        rpt.Database.Tables(0).SetDataSource(myDS)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
    'Private Sub populategrid()
    '    Dim dtcCheck As New DataColumn("Select")
    '    dtcCheck.DataType = System.Type.GetType("System.Boolean")
    '    dtcCheck.DefaultValue = False
    '    daptr = New SqlDataAdapter("SELECT * FROM wip_msk", con)
    '    ds = New DataSet
    '    adpt.Fill(ds, "reports")
    '    'dvEmp = New DataView
    '    'dvEmp.Table = dsEmp.Tables(0)
    '    dt = New DataTable
    '    dt = ds.Tables("reports")
    '    dt.Columns.Add(dtcCheck)
    '    MetroGrid1.DataSource = dt
    'End Sub

    Private Sub MetroButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton2.Click
        Try
            If CrystalReportViewer1.ViewCount < 0 Then
                MetroButton2.Enabled = False
            Else
                MetroButton2.Enabled = True
                If MetroButton2.Enabled = True Then
                    CrystalReportViewer1.PrintReport()
                End If
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, 211)
        End Try
    End Sub
End Class