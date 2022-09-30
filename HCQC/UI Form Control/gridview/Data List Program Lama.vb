Public Class Data_List_Program_Lama
    Private Sub LinkDataListRM_Click(sender As Object, e As EventArgs) Handles LinkDataListRM.Click
        Data_List_Raw_Material.Show()
    End Sub

    Private Sub LinkDataListGravity_Click(sender As Object, e As EventArgs) Handles LinkDataListGravity.Click
        Data_List_Grafity.Show()
    End Sub

    Private Sub LinkDataListFG_Click(sender As Object, e As EventArgs) Handles LinkDataListFG.Click
        Data_List_Finish_Goods.Show()
    End Sub

    Private Sub LinkDataListExternal_Click(sender As Object, e As EventArgs) Handles LinkDataListExternal.Click
        Data_List_External.Show()
    End Sub

    Private Sub LinkDataListGermination_Click(sender As Object, e As EventArgs) Handles LinkDataListGermination.Click
        Data_List_Daya_Tumbuh.Show()
    End Sub

    Private Sub LinkDataListRM_MouseEnter(sender As Object, e As EventArgs) Handles LinkDataListRM.MouseEnter
        LinkDataListRM.BackColor = Color.FromArgb(70, 179, 226)
    End Sub

    Private Sub LinkDataListRM_MouseLeave(sender As Object, e As EventArgs) Handles LinkDataListRM.MouseLeave
        LinkDataListRM.BackColor = Color.Transparent
    End Sub

    Private Sub LinkDataListGravity_MouseEnter(sender As Object, e As EventArgs) Handles LinkDataListGravity.MouseEnter
        LinkDataListGravity.BackColor = Color.FromArgb(70, 179, 226)
    End Sub

    Private Sub LinkDataListGravity_MouseLeave(sender As Object, e As EventArgs) Handles LinkDataListGravity.MouseLeave
        LinkDataListGravity.BackColor = Color.Transparent
    End Sub

    Private Sub LinkDataListFG_MouseEnter(sender As Object, e As EventArgs) Handles LinkDataListFG.MouseEnter
        LinkDataListFG.BackColor = Color.FromArgb(70, 179, 226)
    End Sub

    Private Sub LinkDataListFG_MouseLeave(sender As Object, e As EventArgs) Handles LinkDataListFG.MouseLeave
        LinkDataListFG.BackColor = Color.Transparent
    End Sub

    Private Sub LinkDataListExternal_MouseEnter(sender As Object, e As EventArgs) Handles LinkDataListExternal.MouseEnter
        LinkDataListExternal.BackColor = Color.FromArgb(70, 179, 226)
    End Sub

    Private Sub LinkDataListExternal_MouseLeave(sender As Object, e As EventArgs) Handles LinkDataListExternal.MouseLeave
        LinkDataListExternal.BackColor = Color.Transparent
    End Sub
    Private Sub LinkDataListRafaction_Click(sender As Object, e As EventArgs) Handles LinkDataListRafaction.Click
        Data_List_Refraction.Show()
    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        HC_Sample_Test_Control.Show()
    End Sub

    Private Sub MetroLink1_MouseEnter(sender As Object, e As EventArgs) Handles MetroLink1.MouseEnter
        MetroLink1.BackColor = Color.FromArgb(70, 179, 226)
    End Sub

    Private Sub MetroLink1_MouseLeave(sender As Object, e As EventArgs) Handles MetroLink1.MouseLeave
        MetroLink1.BackColor = Color.Transparent
    End Sub

    Private Sub LinkDataListRafaction_MouseEnter(sender As Object, e As EventArgs) Handles LinkDataListRafaction.MouseEnter
        LinkDataListRafaction.BackColor = Color.FromArgb(70, 179, 226)
    End Sub

    Private Sub LinkDataListRafaction_MouseLeave(sender As Object, e As EventArgs) Handles LinkDataListRafaction.MouseLeave
        LinkDataListRafaction.BackColor = Color.Transparent
    End Sub

    Private Sub LinkDataListGermination_MouseEnter(sender As Object, e As EventArgs) Handles LinkDataListGermination.MouseEnter
        LinkDataListGermination.BackColor = Color.FromArgb(70, 179, 226)
    End Sub

    Private Sub LinkDataListGermination_MouseLeave(sender As Object, e As EventArgs) Handles LinkDataListGermination.MouseLeave
        LinkDataListGermination.BackColor = Color.Transparent
    End Sub
End Class