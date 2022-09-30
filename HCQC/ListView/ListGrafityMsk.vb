Imports MetroFramework

Public Class ListGrafityMsk

        Private Sub ListGrafityMsk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'TODO: This line of code loads data into the 'HCQC_serverDataSet.wip_msk' table. You can move, or remove it, as needed.
            Me.Wip_mskTableAdapter.Fill(Me.HCQC_serverDataSet.wip_msk)

        End Sub

        Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            'Dim dt As New DataTable()
            'dt.Columns.AddRange(New DataColumn(1) {New DataColumn("Name"), New DataColumn("Country")})
            'For Each row As GridViewRow In MetroGrid1.Rows
            '    If row.RowType = DataControlRowType.DataRow Then
            '        Dim chkRow As CheckBox = TryCast(row.Cells(0).FindControl("chkRow"), CheckBox)
            '        If chkRow.Checked Then
            '            Dim name As String = row.Cells(1).Text
            '            Dim country As String = TryCast(row.Cells(2).FindControl("lblCountry"), Label).Text
            '            dt.Rows.Add(name, country)
            '        End If
            '    End If
            'Next
            'gvSelected.DataSource = dt
            'gvSelected.DataBind()
        End Sub
    End Class
