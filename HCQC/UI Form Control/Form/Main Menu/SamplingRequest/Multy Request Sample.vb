Imports System.Data.SqlClient

Public Class Multy_Request_Sample

    Private Sub Multy_Request_Sample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCQC_NewDataset.spl_request' table. You can move, or remove it, as needed.
        'Me.Spl_requestTableAdapter.Fill(Me.HCQC_NewDataset.spl_request)
    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles Linkadd.Click
        Data_Request.ShowDialog(Me)
    End Sub

    Private Sub LinkClear_Click(sender As Object, e As EventArgs) Handles LinkClear.Click
        MetroGrid2.Rows.Clear()

        'Dim int As Integer
        'int = MetroGrid2.Rows.Count()
        'LabelCount.Text = int
    End Sub

    Private Sub BtnClearSelected_Click(sender As Object, e As EventArgs) Handles BtnClearSelected.Click
        ''menghapus row pada Datagrid2 yang terpilih(CheckBox Selected)
        For i As Integer = MetroGrid2.Rows.Count() - 1 To 0 Step -1
            Dim delete As Boolean
            delete = MetroGrid2.Rows(i).Cells(0).Value

            ' if the checkbox cell is checked
            If delete = True Then
                Dim row As DataGridViewRow
                row = MetroGrid2.Rows(i)
                MetroGrid2.Rows.Remove(row)
            End If
        Next

        ''Count Row value
        'Dim int As Integer
        'int = MetroGrid2.Rows.Count()
        'LabelCount.Text = int
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim tglharvest As Date
        Dim stridlogin As Integer = login.Luserid.Text
        Dim strscope As String
        Dim strSampling, strTestmoi, strTestPur, strTestRaf, strTestGer, strTestVia, strkarantina As Boolean
        strscope = TComboScope.Text
        strSampling = tsampling.CheckState
        strTestmoi = tmoi.CheckState
        strTestPur = tpur.CheckState
        strTestRaf = traf.CheckState
        strTestGer = tger.CheckState
        strTestVia = tvia.CheckState
        strkarantina = tkarantina.CheckState
        Try
            For Each row As DataGridViewRow In MetroGrid2.Rows
                Using cmd As New SqlCommand("INSERT INTO [spl_request] ([id_login]
                                                                   ,[id_hvsprod]
                                                                   ,[variety]
                                                                   ,[farmer]
                                                                   ,[location]
                                                                   ,[harvest]
                                                                   ,[nomnl]
                                                                   ,[nojob]
                                                                   ,[weight]
                                                                   ,[scope]
                                                                   ,[bag]
                                                                   ,[test_sampling]
                                                                   ,[test_moi]
                                                                   ,[test_pur]
                                                                   ,[test_ger]
                                                                   ,[test_via]
                                                                   ,[test_raf]
                                                                   ,[remark]
                                                                   ,[loc_sample]
                                                                   ,[kesehatan_benih]
                                                                   ,[input_by]
                                                                   ,[input_date]) 
                                                 VALUES (@idlogin, @idprod, @variety, @farmer, @location, @harvest, @nomnl, @nojob, @weight, @scope
                                ,@bag, @testSampling, @testmoi, @testpur, @testger, @testvia, @testraf, @remark, @loc_sample, @kesehatan_benih, @inputby, GETDATE())", con)
                    cmd.Parameters.AddWithValue("@idlogin", stridlogin)
                    cmd.Parameters.AddWithValue("@idprod", row.Cells("idproductionColumn").Value)
                    cmd.Parameters.AddWithValue("@variety", row.Cells("VarietyColumn").Value)
                    cmd.Parameters.AddWithValue("@farmer", row.Cells("FarmerColumn").Value)
                    cmd.Parameters.AddWithValue("@location", row.Cells("locationColumn").Value)
                    tglharvest = row.Cells("HarvestColumn").Value
                    cmd.Parameters.AddWithValue("@harvest", tglharvest.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@nomnl", row.Cells("ManualColumn").Value)
                    cmd.Parameters.AddWithValue("@nojob", row.Cells("LotColumn").Value)
                    cmd.Parameters.AddWithValue("@weight", row.Cells("WeightColumn").Value)
                    cmd.Parameters.AddWithValue("@bag", row.Cells("BagColumn").Value)

                    cmd.Parameters.AddWithValue("@scope", TComboScope.Text)
                    cmd.Parameters.AddWithValue("@testSampling", strSampling)
                    cmd.Parameters.AddWithValue("@testmoi", strTestmoi)
                    cmd.Parameters.AddWithValue("@testpur", strTestPur)
                    cmd.Parameters.AddWithValue("@testger", strTestGer)
                    cmd.Parameters.AddWithValue("@testvia", strTestVia)
                    cmd.Parameters.AddWithValue("@testraf", strTestRaf)
                    Dim remark As String
                    remark = IIf(row.Cells("KetColumn").Value Is Nothing, "", row.Cells("KetColumn").Value)
                    cmd.Parameters.AddWithValue("@remark", remark)
                    cmd.Parameters.AddWithValue("@loc_sample", tloc_sample.Text)
                    cmd.Parameters.AddWithValue("@kesehatan_benih", strkarantina)
                    cmd.Parameters.AddWithValue("@inputby", GetIPAddress)


                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                End Using
                LprosesSave.Text = row.ToString
            Next
            Dim result As Integer = MetroMessageBox.Show(Me, "Multiple Save Successes. You will leave this form", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 211)
            If result = DialogResult.Yes Then
                Me.Close()
            ElseIf result = DialogResult.No Then
                MetroGrid2.Rows.Clear()
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Troublesort " + ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop, 211)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub Multy_Request_Sample_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class