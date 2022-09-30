Imports System.Drawing
Public Class Finish_Goods_Arsip
    Dim Tanggal As Date = Today

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If tno_lab.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "No. Lab harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tvariety.Focus()
        ElseIf tvariety.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Variety harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tnojob.Focus()
        ElseIf tnojob.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "No Job harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tnojob.Focus()
        ElseIf texpdate.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Tanggal Experied harus di isi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            texpdate.Focus()
        ElseIf tkardus_ars.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Nomor Kardus harus di isi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tkardus_ars.Focus()
        ElseIf tka_ars.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "KA(kadar Air) harus di isi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tka_ars.Focus()
        ElseIf tdt_ars.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "DT(Daya Tumbuh) harus di isi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tdt_ars.Focus()
        ElseIf tbrt_ars.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Berat Isi harus di isi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tbrt_ars.Focus()
        ElseIf cbox_unit.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Pilih salah satu Unit Berat Isi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            cbox_unit.Focus()
        Else
            _RunSQL("UPDATE fg_id SET kardus ='" & tkardus_ars.Text & "', tgl_arsip ='" & Today & "', ka_ars='" & tka_ars.Text & "', dt_ars='" & tdt_ars.Text & "', brt_ars='" & tbrt_ars.Text & "', brtunit_ars='" & cbox_unit.Text & "' WHERE (no_lab = '" & tno_lab.Text & "')")
            tnojob.Focus()
            Bersihkan()
        End If
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If tno_lab.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "No. Lab harus diisi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tvariety.Focus()
        ElseIf tvariety.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Variety harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tnojob.Focus()
        ElseIf tnojob.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "No Job harus ada!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            tnojob.Focus()
        ElseIf texpdate.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Tanggal Experied harus di isi!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
            texpdate.Focus()
        Else
            _RunSQL("UPDATE fg_id SET kardus ='Null', tgl_arsip ='Null', ka_ars='Null', dt_ars='Null', brt_ars='Null', brtunit_ars='Null' WHERE (no_lab = '" & tno_lab.Text & "')")
            tnojob.Focus()
            Bersihkan()
        End If
    End Sub

    Sub Bersihkan()
        tvariety.Text = ""
        tnojob.Text = ""
        tnojob.Text = ""
        texpdate.Text = ""
        'tkardus_ars.Text = ""
        tka_ars.Text = ""
        tdt_ars.Text = ""
        tbrt_ars.Text = ""
        'cbox_unit.Text = ""
    End Sub

    Private Sub Finish_Goods_Arsip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillSearchResult()

    End Sub

    'Fungsi Dropdown List TextBox
    Private Sub FillSearchResult()
        Dim AutoComp As New AutoCompleteStringCollection()
        Dim dsSerch As New DataSet

        openDB()

        Dim sql As String = "SELECT nojob FROM fg_id"
        adapter = New SqlClient.SqlDataAdapter(sql, con)
        adapter.Fill(dsSerch, "fg_id")
        For i As Integer = 0 To dsSerch.Tables(0).Rows.Count - 1
            AutoComp.Add(dsSerch.Tables(0).Rows(i)(0).ToString())
        Next

        tnojob.AutoCompleteCustomSource = AutoComp
        tnojob.AutoCompleteMode = AutoCompleteMode.Suggest
        tnojob.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub

    ''Mengubah Desain Border TextBox
    Private Sub MetroPanel2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Panel1.BorderStyle = Windows.Forms.BorderStyle.None
        e.Graphics.DrawRectangle(Pens.DeepSkyBlue, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1)
    End Sub

    Private Sub TCari1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tCari1.Click

        Dim _pnl As New Bindingarsib(Me)
        AddHandler _pnl.Shown2, AddressOf Pnl_Shown2
        _pnl.swiper2(True)
    End Sub
    'Private Sub pnl_Shown2 --terhubung dengan-- Private Sub tCari1_Click
    'Jangan Dihapus
    Private Sub Pnl_Shown2(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint
        Panel2.BorderStyle = Windows.Forms.BorderStyle.None
        e.Graphics.DrawRectangle(Pens.DeepSkyBlue, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1)
    End Sub

End Class