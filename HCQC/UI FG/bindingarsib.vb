Public Class Bindingarsib

    Private Sub Bindingarsib_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TAMPIL()
        'Me.Fg_idTableAdapter.Fill(Me.HCQC_serverDataSet.fg_id)
    End Sub
    '--load data from database
    Sub TAMPIL()
        openDB()
        cmd = New SqlClient.SqlCommand("SELECT * FROM fg_id WHERE nojob LIKE '%" & Finish_Goods_Arsip.tnojob.Text & "%'", con)
        adapter = New SqlClient.SqlDataAdapter With {
            .SelectCommand = cmd
        }
        Dim dset As DataSet = New Data.DataSet
        adapter.Fill(dset, "c")
        MetroGrid1.DataSource = dset
        MetroGrid1.DataMember = "c"
    End Sub
    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        'Dim _pnl As New SampelMasukExternal(Me)
        AddHandler Me.Closed2, AddressOf Pnl_Closed2
        'AddHandler _pnl.Shown, AddressOf pnl_Shown
        Me.swiper2(False)

    End Sub
    '--!Warning to Delete Below!------
    Private Sub Pnl_Closed2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    '--Funsi untuk upluad conten yang di klik ke form Finish_Goods_Arsip
    Private Sub MetroGrid1_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick

        Dim i As Integer
        Dim dt As String = "ddMMyyy"
        With MetroGrid1
            If e.RowIndex >= 0 Then
                'Find current mouse cursor position
                Dim p As Point = MetroGrid1.PointToClient(Cursor.Position)
                Dim hit As DataGridView.HitTestInfo = MetroGrid1.HitTest(p.X, p.Y)

                If (hit.Type = DataGridViewHitTestType.Cell) Then
                    'Mouse is over a cell
                    If hit.ColumnIndex = 0 Then
                        If hit.RowIndex = e.RowIndex Then
                            'And it's browser button cell for the same row. Abort validation here.
                            i = .CurrentRow.Index
                            Finish_Goods_Arsip.tno_lab.Text = .Rows(i).Cells("nolab").Value.ToString
                            Finish_Goods_Arsip.tnojob.Text = .Rows(i).Cells("nojob").Value.ToString
                            Finish_Goods_Arsip.tvariety.Text = .Rows(i).Cells("variety").Value.ToString
                            dt = .Rows(i).Cells("hvdt").Value.ToString
                            Finish_Goods_Arsip.texpdate.Text = Format(CDate(dt), "dd-MM-yyyy")
                            Finish_Goods_Arsip.tka_ars.Text = .Rows(i).Cells("ka_ars").Value.ToString
                            Finish_Goods_Arsip.tdt_ars.Text = .Rows(i).Cells("dt_ars").Value.ToString
                            Finish_Goods_Arsip.tbrt_ars.Text = .Rows(i).Cells("brt_ars").Value.ToString
                            Finish_Goods_Arsip.cbox_unit.Text = .Rows(i).Cells("brtunit_ars").Value.ToString
                            Finish_Goods_Arsip.tkardus_ars.Text = .Rows(i).Cells("kardus").Value.ToString
                            'Funsi menutup panel slide
                            AddHandler Me.Closed2, AddressOf Pnl_Closed2
                            Me.swiper2(False)
                            Exit Sub
                        End If
                    End If
                End If
            End If
        End With


    End Sub

End Class