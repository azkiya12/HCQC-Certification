

Partial Public Class HCQC_serverDataSet
    Partial Public Class report_internal_viewDataTable
        Private Sub report_internal_viewDataTable_report_internal_viewRowChanging(sender As Object, e As report_internal_viewRowChangeEvent) Handles Me.report_internal_viewRowChanging

        End Sub

    End Class

    Partial Class wip_inspectionDataTable

    End Class

    Partial Class rm_leadtimeDataTable

    End Class

    Partial Class leattimeDataTable

        'Private Sub leattimeDataTable_leattimeRowChanging(ByVal sender As System.Object, ByVal e As leattimeRowChangeEvent) Handles Me.leattimeRowChanging

        'End Sub

    End Class

    Partial Class GrafityNewJoinDataTable

        Private Sub GrafityNewJoinDataTable_GrafityNewJoinRowChanging(ByVal sender As System.Object, ByVal e As GrafityNewJoinRowChangeEvent) Handles Me.GrafityNewJoinRowChanging

        End Sub

    End Class

    Partial Class FinishGdJoinDataTable

        Private Sub FinishGdJoinDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.t_dtColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class ExternalJoinDataTable

    End Class

    Partial Class ExternalJoinDataTable

        Private Sub ExternalJoinDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging


        End Sub

    End Class

    Partial Class RawMaterialJoinDataTable

    End Class

End Class

Namespace HCQC_serverDataSetTableAdapters
    Partial Public Class report_global_viewTableAdapter
    End Class

    Partial Public Class rm_mskTableAdapter
    End Class
End Namespace

Namespace HCQC_serverDataSetTableAdapters
    
    Partial Public Class fg_idTableAdapter
    End Class
End Namespace
