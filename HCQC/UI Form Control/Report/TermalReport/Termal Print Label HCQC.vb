Public Class Termal_Print_Label_HCQC
    Private Sub Termal_Print_Label_HCQC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCQC_NewDataset.qc_confirm_view' table. You can move, or remove it, as needed.
        Me.Qc_confirm_viewTableAdapter.Fill(Me.HCQC_NewDataset.qc_confirm_view)

    End Sub
End Class