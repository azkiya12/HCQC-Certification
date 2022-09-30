Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Parameter_Grafity

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If tnolab.Text.Length = 0 Or tnolab.Text.Length < 0 Or tnolab.Text.Length >= 18 Then
            ErrorProvider2.SetError(tnolab, "Kode Laboratorium belum diisi")
            Return
        Else
            ErrorProvider2.Clear()
        End If

        If ComboBox1.Text.Length = 0 Then
            ErrorProvider2.SetError(ComboBox1, "Tentukan Certifikasi")
            Return
        Else
            ErrorProvider2.Clear()
        End If

        If ComboBox1.Text = "WIP CERTIFICATION" Then
            If MessageBox.Show("Laporan pada No. Lab " & tnolab.Text, "Pesan", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
                CRGrafti.Show()
            End If
        ElseIf ComboBox1.Text = "PERIODIC CERTIFICATION" Then
            If MessageBox.Show("Laporan pada No. Lab " & tnolab.Text, "Pesan", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
                CRPeriodic.Show()
            End If
        ElseIf ComboBox1.Text = "FINISH GOODS CERITIFICATION" Then
            If MessageBox.Show("Laporan pada No. Lab " & tnolab.Text, "Pesan", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
                CRFinishGood.Show()
            End If
        ElseIf ComboBox1.Text = "EKTERNAL" Then
            If MessageBox.Show("Laporan pada No. Lab " & tnolab.Text, "Pesan", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
                CRExternal.Show()
            End If
        End If
        'CRGrafti.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class