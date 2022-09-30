Public Class DataGridDevexpress
    Private Sub DataGridDevexpress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatasetBarCode.qc_confirm_view' table. You can move, or remove it, as needed.
        Me.Qc_confirm_viewTableAdapter.Fill(Me.DatasetBarCode.qc_confirm_view)

    End Sub
End Class