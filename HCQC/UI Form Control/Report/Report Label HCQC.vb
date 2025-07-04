﻿Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DgvFilterPopup
Imports ZXing
Imports ZXing.Common

Public Class Report_Label_HCQC
    Private barManager1 As BarManager
    Private popupMenu1 As PopupMenu
    Private btnFinishGood As BarButtonItem
    Private btnPeriodic As BarButtonItem
    Private btnOther As BarButtonItem
    Private btnRawMaterial As BarButtonItem
    Private btnGravity As BarButtonItem
    Private btnShowAll As BarButtonItem

    Private Sub DropDownOption()
        barManager1 = New BarManager()
        barManager1.Form = Me
        popupMenu1 = New PopupMenu(barManager1)
        btnRawMaterial = New BarButtonItem(barManager1, "Raw Material")
        btnGravity = New BarButtonItem(barManager1, "Gravity")
        btnPeriodic = New BarButtonItem(barManager1, "Periodic")
        btnFinishGood = New BarButtonItem(barManager1, "Finish Good")
        btnOther = New BarButtonItem(barManager1, "Print Other")
        btnShowAll = New BarButtonItem(barManager1, "Show All")

        popupMenu1.AddItem(btnRawMaterial)
        popupMenu1.AddItem(btnGravity)
        popupMenu1.AddItem(btnPeriodic)
        popupMenu1.AddItem(btnFinishGood)
        popupMenu1.AddItem(btnOther)
        popupMenu1.AddItem(btnShowAll)

        DropDownButton1.DropDownControl = popupMenu1
        AddHandler DropDownButton1.Click, New System.EventHandler(AddressOf Me.DropDownButton1_Click)

        btnRawMaterial.Tag = "rawmaterial"
        AddHandler btnRawMaterial.ItemClick, AddressOf Me.btnRawMaterial_ItemClick
        btnGravity.Tag = "gravity"
        AddHandler btnGravity.ItemClick, AddressOf Me.btnGravity_itemcClick
        btnPeriodic.Tag = "periodic"
        AddHandler btnPeriodic.ItemClick, AddressOf Me.btnPeriodic_ItemClick
        btnFinishGood.Tag = "finishgood"
        AddHandler btnFinishGood.ItemClick, AddressOf Me.btnFinish_Good_ItemClick
        btnOther.Tag = "other"
        AddHandler btnOther.ItemClick, AddressOf Me.btnOther_ItemClick
        btnShowAll.Tag = "showall"
        AddHandler btnShowAll.ItemClick, AddressOf Me.btnShowAll_ItemClick

    End Sub

    Private Sub UpdateDropDownButton(ByVal submenuItem As BarItem)
        DropDownButton1.Text = submenuItem.Caption
        DropDownButton1.Tag = submenuItem.Tag
    End Sub

    Private Sub Raw_Material()
        Me.TermalDataTableTableAdapter.FillByParameterScope(Me.HCQC_NewDataset.TermalDataTable, "Raw Material")
    End Sub

    Private Sub Gravity()
        Me.TermalDataTableTableAdapter.FillByParameterScope(Me.HCQC_NewDataset.TermalDataTable, "Gravity")
    End Sub

    Private Sub Periodic()
        Me.TermalDataTableTableAdapter.FillByParameterScope(Me.HCQC_NewDataset.TermalDataTable, "Periodic")
    End Sub

    Private Sub Finish_Good()
        Me.TermalDataTableTableAdapter.FillByParameterScope(Me.HCQC_NewDataset.TermalDataTable, "Finish Good")
    End Sub

    Private Sub Other()
        Me.TermalDataTableTableAdapter.FillByParameterScope(Me.HCQC_NewDataset.TermalDataTable, "Other")
    End Sub
    Private Sub ShowAll()
        Me.TermalDataTableTableAdapter.FillByShowAll(Me.HCQC_NewDataset.TermalDataTable)
    End Sub


    Private Sub DropDownButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownButton1.Click
        MetroPanel1.Enabled = False
        Dim tag As String = (TryCast(sender, DropDownButton)).Tag.ToString()
        If tag = "rawmaterial" Then
            Raw_Material()
        End If

        If tag = "gravity" Then
            Gravity()
        End If

        If tag = "periodic" Then
            Periodic()
        End If

        If tag = "finishgood" Then
            Finish_Good()
        End If

        If tag = "other" Then
            Other()
        End If

        If tag = "showall" Then
            ShowAll()
        End If
        MetroPanel1.Enabled = True
    End Sub

    Private Sub btnRawMaterial_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        UpdateDropDownButton(e.Item)
        Raw_Material()
    End Sub

    Private Sub btnGravity_itemcClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        UpdateDropDownButton(e.Item)
        Gravity()
    End Sub

    Private Sub btnPeriodic_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        UpdateDropDownButton(e.Item)
        Periodic()
    End Sub

    Private Sub btnFinish_Good_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        UpdateDropDownButton(e.Item)
        Finish_Good()
    End Sub

    Private Sub btnOther_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        UpdateDropDownButton(e.Item)
        Other()
    End Sub

    Private Sub btnShowAll_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        UpdateDropDownButton(e.Item)
        ShowAll()
    End Sub

    Private Sub Report_Label_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCQC_NewDataset.TermalDataTable' table. You can move, or remove it, as needed.

        'BindGrid()
        DropDownOption()
        UpdateDropDownButton(btnRawMaterial)
        'Menamoilkan nomor urut pada datagrid view

        Dim DgvFilter1 As New DgvFilterManager()
        DgvFilter1.DataGridView = MetroGrid1
        MetroGrid1.ColumnHeadersHeight = 25


        ''mendapatkan nama default printer name
        LabelPrinter.Text = GetDefaultPrinter()
        LabelPrinter2.Text = GetDefaultPrinter()

        MetroTabControl1.SelectedTab = MetroTabPage1
    End Sub

    Private Sub Report_Label_HCQC_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub


    Function SqlToBinding(column As String, parameter As String)
        Dim hasil As String
        hasil = _DataToValue("SELECT case WHEN " & column & " IS NULL THEN '-' else " & column & " end as columne
                              From  category_crop RIGHT OUTER JOIN
                                    qc_confirm_view ON category_crop.prodcode LIKE '%' + qc_confirm_view.variety + '%' LEFT OUTER JOIN
                                    spl_request ON qc_confirm_view.id = spl_request.id LEFT OUTER JOIN
                                    log_view_print_la2 ON qc_confirm_view.labnum = log_view_print_la2.labnum
                              WHERE        (qc_confirm_view.labnum='" & parameter & "')")
        Return hasil
    End Function
    Function SqlToBindingDate(column As String, parameter As String)
        Dim hasil As String
        hasil = _DataToValue("SELECT case WHEN " & column & " IS NULL THEN '-' else convert(Varchar," & column & ",105) end as columne
                              From  category_crop RIGHT OUTER JOIN
                                    qc_confirm_view ON category_crop.prodcode LIKE '%' + qc_confirm_view.variety + '%' LEFT OUTER JOIN
                                    spl_request ON qc_confirm_view.id = spl_request.id LEFT OUTER JOIN
                                    log_view_print_la2 ON qc_confirm_view.labnum = log_view_print_la2.labnum
                              WHERE        (qc_confirm_view.labnum='" & parameter & "')")
        Return hasil
    End Function

    Function SqlToBinding2(column As String, parameter As String)
        Dim hasil As String
        hasil = _DataToValue("SELECT case WHEN " & column & " IS NULL THEN '-' else " & column & " end as columne
                              From  category_crop RIGHT OUTER JOIN
                                    qc_confirm_viewer ON category_crop.prodcode LIKE '%' + qc_confirm_viewer.variety + '%'
                              WHERE        (qc_confirm_viewer.labnum='" & parameter & "')")
        Return hasil
    End Function
    Function SqlToBindingDate2(column As String, parameter As String)
        Dim hasil As String
        hasil = _DataToValue("SELECT case WHEN " & column & " IS NULL THEN '-' else convert(Varchar," & column & ",105) end as columne
                              From  category_crop RIGHT OUTER JOIN
                                    qc_confirm_viewerer ON category_crop.prodcode LIKE '%' + qc_confirm_viewer.variety + '%'
                              WHERE        (qc_confirm_viewer.labnum='" & parameter & "')")
        Return hasil
    End Function

    Public Sub FlagRawStorage()
        ''mengirim tanda/flag/mark ke database telah di print
        For Each row As DataGridViewRow In MetroGrid2.Rows
            Using cmd As New SqlCommand("sp_InsertTglPrintLabel", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_login", SqlDbType.Int).Value = login.Luserid.Text
                If MetroTabControl1.SelectedTab Is MetroTabPage1 Then
                    cmd.Parameters.AddWithValue("@Id_barcode", row.Cells("LabNumberColumn").Value)  ''mengambil nilai/value dari dalam gridview.row.cell tertentu
                    cmd.Parameters.Add("@mark", SqlDbType.VarChar).Value = LabelMark.Text
                Else
                    cmd.Parameters.AddWithValue("@Id_barcode", row.Cells("idproductionColumn").Value)  ''mengambil nilai/value dari dalam gridview.row.cell tertentu
                    cmd.Parameters.Add("@mark", SqlDbType.VarChar).Value = "LA1"
                End If

                con.Open()
                cmd.ExecuteScalar()
                con.Close()
            End Using
        Next
    End Sub

    Public Sub TermalPrintLA1()
        Dim VCode, Vharvest, VCrop, VKontrak, VNoRen, Vpetani As String
        Dim zplcom As String

        For Each row As DataGridViewRow In MetroGrid2.Rows
            If Not IsDBNull(row.Cells("idproductionColumn").Value) AndAlso row.Cells("idproductionColumn").Value <> "" AndAlso row.Cells("idproductionColumn").Value <> 0 Then

                VCode = CType(row.Cells("idproductionColumn").Value, String)
                Dim columns As String = "case when [norencana] IS NULL THEN '' ELSE [norencana] end as [norencana], " &
                                    "case when [nokontrak] IS NULL THEN '' ELSE [nokontrak] END AS [nokontrak], " &
                                    "area, convert(varchar, [harvest], 103) as harvest, cgrname"
                Dim tableName As String = "[harvestprod]"
                Dim filter As String = "[idcode]=" & VCode

                Dim data As DataTable = GetData(columns, tableName, filter)

                ' Memeriksa apakah ada baris yang dikembalikan
                If data.Rows.Count > 0 Then
                    ' Mengambil nilai dari field tertentu (misalnya, kolom pertama)
                    'Dim fieldValue As String = data.Rows(0)("nama_barang").ToString()
                    VNoRen = data.Rows(0)("norencana").ToString()
                    VKontrak = data.Rows(0)("nokontrak").ToString()
                    VCrop = data.Rows(0)("area").ToString()
                    Vharvest = data.Rows(0)("harvest").ToString()
                    Vpetani = data.Rows(0)("cgrname").ToString()
                Else
                    MessageBox.Show("Data Production tidak ditemukan.")
                    Return
                End If

                zplcom = "CT~~CD,~CC^~CT~
                        ^XA
                        ~TA000
                        ~JSN
                        ^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR6,6
                        ~SD30
                        ^JUS^LRN^CI27^PA0,1,1,0
                        ^XZ

                        ^XA
                        ^MMT^LS0
                        ^BY3,3,30^FT45,54^BCN,,Y,N
                        ^FH\^FD>;" & VCode.Insert(8, ">6") & "^FS
                        ^FT238,128^AAN,18,10^FB156,1,0,R^FH\^FD" & VNoRen & "^FS
                        ^FT19,107^A@N,14,13,TT0003M_^FH\^CI28^FDNo. Kontrak^FS^CI27
                        ^FT106,106^AAN,18,10^FB288,1,0,R^FH\^FD" & VKontrak & "^FS
                        ^FT19,128^A@N,17,18,TT0003M_^FH\^CI28^FD" & Vpetani & "^FS^CI27
                        ^FT19,153^A@N,17,18,TT0003M_^FH\^CI28^FD" & VCrop & "^FS^CI27
                        ^FPH,1^FT269,153^A@N,17,18,TT0003M_^FB124,1,9,R^FH\^CI28^FDP: " & Vharvest & "^FS^CI27
                        ^BY3,3,30^FT469,54^BCN,,Y,N
                        ^FH\^FD>;" & VCode.Insert(8, ">6") & "^FS
                        ^FT662,128^AAN,18,10^FB156,1,0,R^FH\^FDK" & VNoRen & "^FS
                        ^FT443,107^A@N,14,13,TT0003M_^FH\^CI28^FDNo. Kontrak^FS^CI27
                        ^FT530,106^AAN,18,10^FB288,1,0,R^FH\^FD" & VKontrak & "^FS
                        ^FT443,128^A@N,17,18,TT0003M_^FH\^CI28^FD" & Vpetani & "^FS^CI27
                        ^FT443,153^A@N,17,18,TT0003M_^FH\^CI28^FD" & VCrop & "^FS^CI27
                        ^FPH,1^FT693,153^A@N,17,18,TT0003M_^FB124,1,9,R^FH\^CI28^FDP: " & Vharvest & "^FS^CI27
                        ^PQ" & trequestcopy.Text & ",0,1,Y
                        ^XZ"

                Printer.RawHelper.SendStringToPrinter(LabelPrinter2.Text, zplcom)
            End If
        Next

    End Sub

    Public Sub TermalPrintLA2(sender As Object, e As EventArgs)
        Dim labzpl, v_labnum, V_variety, V_manual, V_job, V_scope As String
        Dim zplcom As String

        For Each row As DataGridViewRow In MetroGrid2.Rows
            v_labnum = CType(row.Cells("LabNumberColumn").Value, String)
            V_variety = CType(row.Cells("VarietyColumn").Value, String)
            V_manual = CType(row.Cells("ManualColumn").Value, String)
            V_job = CType(row.Cells("LotColumn").Value, String)
            V_scope = CType(row.Cells("ScopeColumn").Value, String)
            labzpl = IIf(Len(v_labnum) >= 9, v_labnum.Insert(2, ">5"), v_labnum)

            Select Case V_scope
                Case "Raw Material"
                    V_scope = "RM"
                Case "Gravity"
                    V_scope = "G"
                Case "Periodic"
                    V_scope = "P"
                Case "Finish Good"
                    V_scope = "FG"
                Case "Other"
                    V_scope = "OT"
            End Select

            zplcom = "CT~~CD,~CC^~CT~
                        ^XA
                        ~TA000
                        ~JSN
                        ^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR5,5
                        ~SD30
                        ^JUS^LRN^CI27^PA0,1,1,0
                        ^XZ

                        ^XA
                        ^MMT^PW831^LL120^LS0
                        ^BY2,3,20^FT15,70^BCN,,N,N
                        ^FH\^FD>:" & labzpl & "^FS
                        ^FT0,36^AAN,18,10^FB260,1,0,C^FH\^FD" & v_labnum & "\5C&^FS
                        ^FPH,1^FT0,92^A0N,17,18^FB260,1,4,C^FH\^CI28^FD" & V_variety & "; " & V_manual & " / \5C&^FS^CI27
                        ^FT0,36^AAN,18,10^FB243,1,0,R^FH\^FD" & V_scope & "^FS
                        ^FPH,1^FT0,110^A0N,17,18^FB259,1,4,C^FH\^CI28^FD" & V_job & "\5C&^FS^CI27
                        ^BY2,3,20^FT303,70^BCN,,N,N
                        ^FH\^FD>:" & labzpl & "^FS
                        ^FT5,36^AAN,18,10^FB826,1,0,C^FH\^FD" & v_labnum & "\5C&^FS
                        ^FPH,1^FT5,92^A0N,17,18^FB826,1,4,C^FH\^CI28^FD" & V_variety & "; " & V_manual & " / \5C&^FS^CI27
                        ^FT0,36^AAN,18,10^FB531,1,0,R^FH\^FD" & V_scope & "^FS
                        ^FPH,1^FT4,110^A0N,17,18^FB827,1,4,C^FH\^CI28^FD" & V_job & "\5C&^FS^CI27
                        ^BY2,3,20^FT585,70^BCN,,N,N
                        ^FH\^FD>:" & labzpl & "^FS
                        ^FT579,36^AAN,18,10^FB252,1,0,C^FH\^FD" & v_labnum & "\5C&^FS
                        ^FPH,1^FT579,92^A0N,17,18^FB252,1,4,C^FH\^CI28^FD" & V_variety & "; " & V_manual & " / \5C&^FS^CI27
                        ^FT0,36^AAN,18,10^FB818,1,0,R^FH\^FD" & V_scope & "^FS
                        ^FPH,1^FT578,110^A0N,17,18^FB253,1,4,C^FH\^CI28^FD" & V_job & "\5C&^FS^CI27
                        ^PQ1,0,1,Y
                        ^XZ"
            Printer.RawHelper.SendStringToPrinter(LabelPrinter.Text, zplcom)
        Next

    End Sub

    Public Sub TermalPrintLA4(sender As Object, e As EventArgs)
        ''Membuat list datagrid yang CheckBox Selected
        'Dim selectedRows As List(Of DataGridViewRow) = (From row In MetroGrid2.Rows.Cast(Of DataGridViewRow)()
        '                                                Where Convert.ToBoolean(row.Cells("CheckColumn").Value) = True).ToList()
        ''Deklarasi variable untuk Template termal printer
        Dim V_idprod, V_Crop, V_harvest1, V_variety1, V_farmer, v_labnum, V_variety2, Vlot, V_weight, V_sampling, V_sampler, V_scope, V_Bags As String
        Dim B_moisture, B_Purity, B_germination, B_sampling, B_rafaction, B_rapit As String
        Dim V_moisture, V_Purity, V_germination, V_Bsampling, V_rafaction, V_rapit As String
        Dim zplcom As String

        'If MessageBox.Show(String.Format("Do you want to delete {0} rows?", selectedRows.Count), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
        For Each row As DataGridViewRow In MetroGrid2.Rows
            V_idprod = CType(row.Cells("idproductionColumn").Value, String)
            V_Crop = CType(row.Cells("CropColumn").Value, String)
            V_harvest1 = CType(row.Cells("HarvestColumn2").Value, String)
            V_variety1 = CType(row.Cells("VarietyColumn").Value, String)
            Vlot = CType(row.Cells("ManualColumn").Value, String) + " / " + CType(row.Cells("LotColumn").Value, String)

            v_labnum = CType(row.Cells("LabNumberColumn").Value, String)
            V_farmer = _DataToValue("SELECT [farmer] FROM [spl_request] WHERE [id_hvsprod]='" & V_idprod & "'")
            V_variety2 = V_variety1
            V_weight = CType(row.Cells("WeightColumn").Value, String)
            V_sampling = CType(row.Cells("SamplingColumn").Value, String)
            V_sampler = ""
            V_scope = CType(row.Cells("ScopeColumn").Value, String)
            V_Bags = _DataToValue("SELECT [bag] FROM [spl_request] WHERE [id]=" & _DataToValue("SELECT [id] FROM [qc_confirm_view] WHERE [labnum]='" & v_labnum & "'"))

            B_moisture = CType(row.Cells("moistureColumn").Value, String)
            B_Purity = CType(row.Cells("PurityColumn").Value, String)
            B_germination = CType(row.Cells("GerminationColumn").Value, String)
            B_sampling = CType(row.Cells("SamplingTestColumn").Value, String)
            B_rafaction = CType(row.Cells("RafactionColumn").Value, String)
            B_rapit = CType(row.Cells("RapitColumn").Value, String)

            V_moisture = CType(IIf(B_moisture = "True", "8", "2"), String)
            V_Purity = CType(IIf(B_Purity = "True", "8", "2"), String)
            V_germination = CType(IIf(B_germination = "True", "8", "2"), String)
            V_Bsampling = CType(IIf(B_sampling = "True", "8", "2"), String)
            V_rafaction = CType(IIf(B_rafaction = "True", "8", "2"), String)
            V_rapit = CType(IIf(B_rapit = "True", "8", "2"), String)
            zplcom = "CT~~CD,~CC^~CT~
                            ^XA
                            ~TA000
                            ~JSN
                            ^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR5,5
                            ~SD15
                            ^JUS^LRN^CI27^PA0,1,1,0
                            ^XZ
                            ^XA
                            ^MMT^PW799^LL400^LS0
                            ^FT121,55^A@N,17,18,TT0003M_^FH\^CI28^FDHORTICULTURE CROP QUALITY CONTROL^FS^CI27
                            ^FT121,72^A@N,17,18,TT0003M_^FH\^CI28^FDPT BISI INTERNATIONAL TBK^FS^CI27
                            ^FT121,90^A@N,17,18,TT0003M_^FH\^CI28^FDPARE WATES STREET KM 9,^FS^CI27
                            ^FT121,107^A@N,17,18,TT0003M_^FH\^CI28^FDSUMBERAGUNG-PLOSOKLATEN-KEDIRI^FS^CI27
                            ^FPH,1^FT669,22^A@R,14,13,TT0003M_^FH\^CI28^FDVariety:^FS^CI27
                            ^FT50,363^A@N,17,18,TT0003M_^FH\^CI28^FDHarvest^FS^CI27
                            ^FPH,1^FT650,22^A@R,14,13,TT0003M_^FH\^CI28^FDQuantity (kg):^FS^CI27
                            ^FT669,188^A@R,14,13,TT0003M_^FB94,1,7,R^FH\^CI28^FDSampling Date:^FS^CI27
                            ^FT630,193^A@R,14,13,TT0003M_^FB89,1,7,R^FH\^CI28^FDSeed Sampler:^FS^CI27
                            ^FO740,303^GB12,12,8^FS
                            ^FT740,319^A@R,14,13,TT0003M_^FH\^CI28^FDMoisture^FS^CI27
                            ^FT716,319^A@R,14,13,TT0003M_^FH\^CI28^FDPurity^FS^CI27
                            ^FT691,319^A@R,14,13,TT0003M_^FH\^CI28^FDGermination^FS^CI27
                            ^FT667,319^A@R,14,13,TT0003M_^FH\^CI28^FDSampling^FS^CI27
                            ^FT643,319^A@R,14,13,TT0003M_^FH\^CI28^FDRafaction^FS^CI27
                            ^FT618,319^A@R,14,13,TT0003M_^FH\^CI28^FDRapid test^FS^CI27
                            ^FO740,303^GB12,12," & V_moisture & "^FS
                            ^FO715,303^GB12,12," & V_Purity & "^FS
                            ^FO691,303^GB12,12," & V_germination & "^FS
                            ^FO667,303^GB12,12," & V_Bsampling & "^FS
                            ^FO642,303^GB12,12," & V_rafaction & "^FS
                            ^FO618,303^GB12,12," & V_rapit & "^FS
                            ^FO604,291^GB160,0,2^FS
                            ^FO582,0^GB0,400,2^FS
                            ^FO521,0^GB0,400,2^FS
                            ^FT553,30^A@R,17,18,TT0003M_^FH\^CI28^FD#ISO/IEC 17025^FS^CI27
                            ^FT536,30^A@R,17,18,TT0003M_^FH\^CI28^FD[LP-866-IDN]^FS^CI27
                            ^FT553,186^A@R,17,18,TT0003M_^FH\^CI28^FD#ISO-9001^FS^CI27
                            ^FT536,186^A@R,17,18,TT0003M_^FH\^CI28^FDCertified^FS^CI27
                            ^FT553,305^A@R,17,18,TT0003M_^FH\^CI28^FD#ISTA^FS^CI27
                            ^FT536,305^A@R,17,18,TT0003M_^FH\^CI28^FDMember^FS^CI27
                            ^FO33,34^GFA,493,1020,12,:Z64:eJytk7FKxEAQhjcXwhUWnkVAsDjwBWwPr0gCXp9A5nkucHBY+QwnNoKN5XHTXGfpKxxWVuZKC8k4O9nsLriChSGEny9/JrP/ziql1ES5a+bp2tOdkxE4HWNjdQK51WPaB/kJbqxOobR6Sscgn+PWagDX0JK+ghxxF+Qtfbj2w37mdmERURfkiPiLn/7J7/cT7N+ta2f6v9YwF57oV5yNzifrxKx5JJ8gNpxnLL8AKPlOhRN9ZnTMJFJuJoUKjB8v8B5lC5gnUIBsTUb0Qq/8ldKbBQt+I3yO+ID8eO55xZWET1t6766oPfS8rrlYrvQw4HbG/o3SQwL1meFjTl8ntO85DAnpNGOTaORxXgCtyEwE6IZMQlx7hWaCpFEzWad6AXQQnQjvA+XiT2gmOvK4WrZtOwwcF7IDqrtp3L64g+HPv39e/nBF5aIY9Oj89nLQyeRGOb4eWX9VeP7G89f5oOPHu7ef9b8BVai9bQ==:F9AD

                            ^BY2,3,38^FT714,22^BCR,,Y,N
                            ^FH\^FD>:QC>5" & v_labnum.Substring(v_labnum.Length - 10) & "^FS

                            ^BY4,3,58^FT50,199^BCN,,Y,N
                            ^FH\^FD>;" & V_idprod.Insert(8, ">6") & "^FS

                            ^FT50,304^A@N,23,22,TT0003M_^FH\^CI28^FD" & V_Crop & "^FS^CI27
                            ^FT50,272^A@N,23,22,TT0003M_^FH\^CI28^FD" & V_variety1 & "^FS^CI27
                            ^FT50,336^A@N,20,20,TT0003M_^FH\^CI28^FD" & V_farmer & " / " & Vlot & "^FS^CI27
                            ^FPH,1^FT121,363^A@N,17,18,TT0003M_^FH\^CI28^FD" & V_harvest1 & "^FS^CI27

                            ^FT669,76^A@R,14,13,TT0003M_^FH\^CI28^FD" & V_variety2 & "^FS^CI27
                            ^FT650,121^A@R,14,13,TT0003M_^FH\^CI28^FD" & V_weight & "^FS^CI27
                            ^FT652,209^A@R,14,13,TT0003M_^FB73,1,7,R^FH\^CI28^FD" & V_sampling & "^FS^CI27
                            ^FT614,186^A@R,14,13,TT0003M_^FB96,1,7,R^FH\^CI28^FD" & V_sampler & "^FS^CI27
                            ^FT614,22^A@R,14,13,TT0003M_^FH\^CI28^FD" & V_scope.ToUpper & "^FS^CI27
                            ^FT632,22^A@R,14,13,TT0003M_^FH\^CI28^FD" & V_Bags & " Bags^FS^CI27
                            ^PQ1,0,1,Y
                            ^XZ                            
                            "
            Printer.RawHelper.SendStringToPrinter(LabelPrinter.Text, zplcom)
        Next

    End Sub

    Public Function Truncate(value As String, length As Integer) As String
        ' If argument is too big, return the original string.
        ' ... Otherwise take a substring from the string's start index.
        If length > value.Length Then
            Return value
        Else
            Return value.Substring(0, length)
        End If
    End Function


    Public Sub TermalPrintLA42(sender As Object, e As EventArgs)
        ''Membuat list datagrid yang CheckBox Selected
        'Dim selectedRows As List(Of DataGridViewRow) = (From row In MetroGrid2.Rows.Cast(Of DataGridViewRow)()
        '                                                Where Convert.ToBoolean(row.Cells("CheckColumn").Value) = True).ToList()
        ''Deklarasi variable untuk Template termal printer
        Dim V_ID, V_idprod, V_Crop, V_harvest1, V_variety1, V_farmer, v_labnum, Vlot, V_weight, V_sampling, V_sampler, V_scope, V_Bags, V_Location As String
        Dim B_moisture, B_Purity, B_germination, B_sampling, B_rafaction, B_rapit As String
        Dim V_moisture, V_Purity, V_germination, V_Bsampling, V_rafaction, V_rapit As String
        Dim zplcom As String

        'If MessageBox.Show(String.Format("Do you want to delete {0} rows?", selectedRows.Count), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
        For Each row As DataGridViewRow In MetroGrid2.Rows
            V_idprod = CType(row.Cells("idproductionColumn").Value, String)
            V_Crop = CType(row.Cells("CropColumn").Value, String)
            V_harvest1 = CType(row.Cells("HarvestColumn2").Value, String)
            V_variety1 = CType(row.Cells("VarietyColumn").Value, String)

            Vlot = CType(row.Cells("ManualColumn").Value, String) + "; " + CType(row.Cells("LotColumn").Value, String)


            v_labnum = CType(row.Cells("LabNumberColumn").Value, String)
            V_ID = _DataToValue("SELECT [id] FROM [qc_confirm_viewer] WHERE [labnum]='" & v_labnum & "'")

            Dim columns As String = "farmer,bag,loc_sample"
            Dim tableName As String = "[spl_request]"
            Dim filter As String = "[id]=" & V_ID

            Dim data As DataTable = GetData(columns, tableName, filter)

            ' Memeriksa apakah ada baris yang dikembalikan
            If data.Rows.Count > 0 Then
                ' Mengambil nilai dari field tertentu (misalnya, kolom pertama)
                'Dim fieldValue As String = data.Rows(0)("nama_barang").ToString()
                V_farmer = data.Rows(0)("farmer").ToString()
                V_Bags = data.Rows(0)("bag").ToString()
                V_Location = data.Rows(0)("loc_sample").ToString()
            Else
                MessageBox.Show("Data Production tidak ditemukan.")
                Return
            End If


            V_weight = CType(row.Cells("WeightColumn").Value, String)
            V_sampling = CType(row.Cells("SamplingColumn").Value, String)
            V_sampler = ""
            V_scope = CType(row.Cells("ScopeColumn").Value, String)

            B_moisture = CType(row.Cells("moistureColumn").Value, String)
            B_Purity = CType(row.Cells("PurityColumn").Value, String)
            B_germination = CType(row.Cells("GerminationColumn").Value, String)
            B_sampling = CType(row.Cells("SamplingTestColumn").Value, String)
            B_rafaction = CType(row.Cells("RafactionColumn").Value, String)
            B_rapit = CType(row.Cells("RapitColumn").Value, String)

            V_moisture = CType(IIf(B_moisture = "True", "8", "2"), String)
            V_Purity = CType(IIf(B_Purity = "True", "8", "2"), String)
            V_germination = CType(IIf(B_germination = "True", "8", "2"), String)
            V_Bsampling = CType(IIf(B_sampling = "True", "8", "2"), String)
            V_rafaction = CType(IIf(B_rafaction = "True", "8", "2"), String)
            V_rapit = CType(IIf(B_rapit = "True", "8", "2"), String)

            Dim labzpl, noprodzpl As String
            labzpl = IIf(Len(v_labnum) >= 9, v_labnum.Insert(2, ">5"), v_labnum)
            If V_idprod.Length >= 8 Then
                noprodzpl = V_idprod.Insert(8, ">6")
            Else
                noprodzpl = ""
            End If
            'noprodzpl = IIf(V_idprod.Length >= 8, V_idprod.Insert(8, ">6"), V_idprod)

            zplcom = "CT~~CD,~CC^~CT~
                        ^XA
                        ~TA000
                        ~JSN
                        ^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR6,6
                        ~SD30
                        ^JUS^LRN^CI27^PA0,1,1,0
                        ^XZ

                        ^XA
                        ^MMT^LS0
                        ^BY3,3,32^FT41,58^BCN,,N,N
                        ^FH\^FD>:" & labzpl & "^FS
                        ^FT40,160^A@N,23,22,TT0003M_^FH\^CI28^FD" & Vlot & "^FS^CI27
                        ^FT403,185^AAN,18,10^FH\^FD" & UCase(V_scope) & "^FS
                        ^BY3,3,30^FT754,34^BCR,,Y,N
                        ^FH\^FD>" & IIf(V_scope = "Finish Good" Or V_scope = "Other", ":" & labzpl, ";" & noprodzpl) & "^FS
                        ^FO631,0^GB0,398,2^FS
                        ^FT40,128^A@N,23,22,TT0003M_^FH\^CI28^FD" & V_variety1 & " ; " & V_farmer & "^FS^CI27
                        ^FT41,83^AAN,27,15^FH\^FD" & v_labnum & "^FS
                        ^FO52,261^GB16,16," & V_moisture & ",,8^FS
                        ^FT74,275^A@N,17,18,TT0003M_^FH\^CI28^FDMoisture^FS^CI27
                        ^FT313,237^A@N,17,18,TT0003M_^FH\^CI28^FDRafaction^FS^CI27
                        ^FT74,314^A@N,17,18,TT0003M_^FH\^CI28^FDGermination^FS^CI27
                        ^FT313,275^A@N,17,18,TT0003M_^FH\^CI28^FDPurity^FS^CI27
                        ^FT313,314^A@N,17,18,TT0003M_^FH\^CI28^FDViability^FS^CI27
                        ^FO288,222^GB16,16," & V_rafaction & ",,8^FS
                        ^FO52,299^GB16,16," & V_germination & ",,8^FS
                        ^FO288,261^GB16,16," & V_Purity & ",,8^FS
                        ^FO288,299^GB16,16," & V_rapit & ",,8^FS
                        ^FT74,237^A@N,17,18,TT0003M_^FH\^CI28^FDSampling^FS^CI27
                        ^FO52,222^GB15,15," & V_Bsampling & ",,8^FS
                        ^FO40,212^GB504,155,2^FS
                        ^FO40,250^GB504,0,2^FS
                        ^FO176,212^GB0,117,2^FS
                        ^FO280,212^GB0,154,2^FS
                        ^FO40,288^GB504,0,2^FS
                        ^FO40,327^GB504,0,2^FS
                        ^FO434,212^GB0,116,2^FS
                        ^FT43,344^A@N,14,13,TT0003M_^FH\^CI28^FDSampler :^FS^CI27
                        ^FT284,344^A@N,14,13,TT0003M_^FH\^CI28^FDDate Sampling :^FS^CI27
                        ^FT40,192^A@N,23,22,TT0003M_^FH\^CI28^FDQty:" & V_weight & " kg ; " & V_Bags & " Bags^FS^CI27
                        ^BY3,3,30^FT594,41^BCR,,Y,N
                        ^FH\^FD>;" & noprodzpl & "^FS                        
                        ^FPH,3^FT702,41^A@R,23,22,TT0003M_^FH\^CI28^FD" & V_variety1 & " ^FS^CI27
                        ^FPH,3^FT674,41^A@R,23,22,TT0003M_^FH\^CI28^FD" & Vlot & "^FS^CI27
                        ^FPH,1^FT642,41^A@R,23,22,TT0003M_^FH\^CI28^FDQty:" & V_weight & " kg ; " & V_Bags & " Bags^FS^CI27
                        ^FT77,306^AAB,27,15^FH\^FD" & V_Location.ToUpper & "^FS
                        ^PQ1,0,1,Y
                        ^XZ"
            Printer.RawHelper.SendStringToPrinter(LabelPrinter.Text, zplcom)
        Next

    End Sub

    Public Sub TermalPrintA42024(sender As Object, e As EventArgs)
        ''Membuat list datagrid yang CheckBox Selected
        'Dim selectedRows As List(Of DataGridViewRow) = (From row In MetroGrid2.Rows.Cast(Of DataGridViewRow)()
        '                                                Where Convert.ToBoolean(row.Cells("CheckColumn").Value) = True).ToList()
        ''Deklarasi variable untuk Template termal printer
        Dim V_ID, V_idprod, V_Crop, V_harvest1, V_variety1, V_farmer, v_labnum, VManualLot, V_weight, V_sampling, V_scope, V_Bags, V_Location As String
        Dim B_moisture, B_Purity, B_germination, B_sampling, B_rafaction, B_rapit As String
        Dim V_moisture, V_Purity, V_germination, V_Bsampling, V_rafaction, V_rapit As String
        Dim zplcom As String

        'If MessageBox.Show(String.Format("Do you want to delete {0} rows?", selectedRows.Count), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
        For Each row As DataGridViewRow In MetroGrid2.Rows
            V_idprod = CType(row.Cells("idproductionColumn").Value, String)
            V_Crop = CType(row.Cells("CropColumn").Value, String)
            V_harvest1 = CType(row.Cells("HarvestColumn2").Value, String)
            V_variety1 = CType(row.Cells("VarietyColumn").Value, String)

            VManualLot = CType(row.Cells("ManualColumn").Value, String) + "; " + CType(row.Cells("LotColumn").Value, String)
            v_labnum = CType(row.Cells("LabNumberColumn").Value, String)
            V_ID = _DataToValue("SELECT [id] FROM [qc_confirm_viewer] WHERE [labnum]='" & v_labnum & "'")

            Dim columns As String = "dbo.spl_request.farmer,dbo.spl_request.bag,dbo.spl_request.loc_sample, [crop]"
            Dim tableName As String = "dbo.spl_request LEFT OUTER JOIN dbo.category_crop ON dbo.spl_request.variety = dbo.category_crop.prodcode"
            Dim filter As String = "dbo.spl_request.[id]=" & V_ID

            Dim data As DataTable = GetData(columns, tableName, filter)

            ' Memeriksa apakah ada baris yang dikembalikan
            If data.Rows.Count > 0 Then
                'Mengambil nilai dari field tertentu (misalnya, kolom pertama)
                'Dim fieldValue As String = data.Rows(0)("nama_barang").ToString()
                V_farmer = data.Rows(0)("farmer").ToString()
                V_Bags = data.Rows(0)("bag").ToString()
                V_Location = data.Rows(0)("loc_sample").ToString()
                V_Crop = data.Rows(0)("crop").ToString()
            Else
                MessageBox.Show("Data Production tidak ditemukan.")
                Return
            End If

            V_weight = CType(row.Cells("WeightColumn").Value, String)
            V_sampling = CType(row.Cells("SamplingColumn").Value, String)
            V_scope = CType(row.Cells("ScopeColumn").Value, String)

            B_moisture = CType(row.Cells("moistureColumn").Value, String)
            B_Purity = CType(row.Cells("PurityColumn").Value, String)
            B_germination = CType(row.Cells("GerminationColumn").Value, String)
            B_sampling = CType(row.Cells("SamplingTestColumn").Value, String)
            B_rafaction = CType(row.Cells("RafactionColumn").Value, String)
            B_rapit = CType(row.Cells("RapitColumn").Value, String)

            V_Bsampling = CType(IIf(B_sampling = "True", "8", "2"), String)
            V_moisture = CType(IIf(B_moisture = "True", "8", "2"), String)
            V_rafaction = CType(IIf(B_rafaction = "True", "8", "2"), String)
            V_Purity = CType(IIf(B_Purity = "True", "8", "2"), String)
            V_germination = CType(IIf(B_germination = "True", "8", "2"), String)
            V_rapit = CType(IIf(B_rapit = "True", "8", "2"), String)

            Dim labzpl, noprodzpl As String
            labzpl = IIf(Len(v_labnum) >= 9, v_labnum.Insert(2, ">5"), v_labnum)
            If V_idprod.Length >= 8 Then
                noprodzpl = V_idprod.Insert(8, ">6")
            Else
                noprodzpl = ""
            End If


            zplcom = "CT~~CD,~CC^~CT~
            ^XA
            ~TA000
            ~JSN
            ^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR6,6
            ~SD30
            ^JUS^LRN^CI27^PA0,1,1,0
            ^XZ

            ^XA
            ^MMT^PW799^LL400^LS0
            ^FO92,211^GB463,159,2^FS
            ^FT101,331^A@N,20,20,TT0003M_^FH\^CI28^FDSampler ^FS^CI27
            ^FT101,362^A@N,20,20,TT0003M_^FH\^CI28^FDDate of Sampling^FS^CI27
            ^FT101,299^A@N,20,20,TT0003M_^FH\^CI28^FDSample Weight* (g)^FS^CI27
            ^FT101,268^A@N,20,20,TT0003M_^FH\^CI28^FDEquipments used^FS^CI27
            ^FT102,388^A@N,17,18,TT0003M_^FH\^CI28^FD*estimation from weighing on sampling location^FS^CI27
            ^FT101,235^A@N,20,20,TT0003M_^FH\^CI28^FDTotal primary samples^FS^CI27
            ^FO320,211^GB0,158,2^FS
            ^FO92,243^GB463,0,2^FS
            ^FO92,275^GB463,0,2^FS
            ^FO92,306^GB463,0,2^FS
            ^FO92,337^GB463,0,2^FS
            ^FPH,3^FT52,321^A0B,23,23^FH\^CI28^FDSUBMITTED SAMPLE^FS^CI27
            ^FT101,117^A0N,20,23^FH\^CI28^FD" & V_Crop & "; " & V_variety1 & "^FS^CI27
            ^FT101,144^A0N,20,23^FH\^CI28^FD" & V_farmer & "^FS^CI27
            ^FPH,1^FT101,164^ADN,18,10^FH\^FD" & VManualLot & "; " & V_Location.ToUpper & "^FS
            ^FPH,1^FT101,191^ADN,18,10^FH\^FD" & V_weight & " (kg); " & V_Bags & " Bags^FS
            ^BY3,3,23^FT598,386^BCB,,Y,N
            ^FH\^FD>" & IIf(noprodzpl = "", ":" & labzpl, ";" & noprodzpl) & "^FS

            ^FO642,3^GFA,45,1580,4,:Z64:eJw7wMDAcIABAQ6g4VHxUfFR8VHxUfFRcQAt+cVB:193B
            ^BY3,3,33^FT41,56^BCN,,N,N
            ^FH\^FD>:" & labzpl & "^FS
            ^FT738,380^A@B,20,20,TT0003M_^FH\^CI28^FD" & V_variety1 & "^FS^CI27
            ^FT738,400^A@B,20,20,TT0003M_^FB377,1,11,R^FH\^CI28^FD" & VManualLot & "^FS^CI27
            ^FT766,400^A@B,20,20,TT0003M_^FB377,1,11,R^FH\^CI28^FD" & V_weight & " KG^FS^CI27
            ^BY3,3,23^FT685,386^BCB,,Y,N
            ^FH\^FD>" & IIf(V_scope = "Finish Good" Or V_scope = "Other", ":" & labzpl, ";" & noprodzpl) & "^FS
            ^FT766,380^A@B,20,20,TT0003M_^FH\^CI28^FD" & V_farmer & " ^FS^CI27

            ^FT101,90^A0N,20,23^FH\^CI28^FD" & UCase(V_scope) & "^FS^CI27
            ^FO436,17^GB76,31,1^FS
            ^FT465,41^A0N,20,23^FH\^CI28^FDSAM^FS^CI27
            ^FO514,17^GB41,31,1^FS
            ^FO444,24^GE16,17," & V_Bsampling & "^FS
            ^FO436,47^GB76,31,1^FS
            ^FT465,71^A0N,20,23^FH\^CI28^FDMOI^FS^CI27
            ^FO514,47^GB41,31,1^FS
            ^FO444,54^GE16,17," & V_moisture & "^FS
            ^FO436,77^GB76,31,1^FS
            ^FT465,101^A0N,20,23^FH\^CI28^FDRAF^FS^CI27
            ^FO514,77^GB41,31,1^FS
            ^FO444,84^GE16,17," & V_rafaction & "^FS
            ^FO436,107^GB76,31,1^FS
            ^FT465,131^A0N,20,23^FH\^CI28^FDPUR^FS^CI27
            ^FO514,107^GB41,31,1^FS
            ^FO444,114^GE16,17," & V_Purity & "^FS
            ^FO436,137^GB76,31,1^FS
            ^FT465,160^A0N,20,23^FH\^CI28^FDGER^FS^CI27
            ^FO514,137^GB41,31,1^FS
            ^FO444,143^GE16,17," & V_germination & "^FS
            ^FO436,166^GB76,31,1^FS
            ^FT465,190^A0N,20,23^FH\^CI28^FDVIA^FS^CI27
            ^FO514,166^GB41,31,1^FS
            ^FO444,173^GE16,17," & V_rapit & "^FS
            ^FT77,306^AAB,27,15^FH\^FD" & v_labnum & "^FS
            ^PQ1,0,1,Y
            ^XZ
            "
            Printer.RawHelper.SendStringToPrinter(LabelPrinter.Text, zplcom)
        Next

    End Sub
    'Fungsi untuk Checkbox Select All pada DataGrid------------------------------------------------------------------
    Private Sub HeaderCheckBox_Clicked(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox1.Click
        'Necessary to end the edit mode of the Cell.
        MetroGrid1.EndEdit()

        'Loop and check and uncheck all row CheckBoxes based on Header Cell CheckBox.
        For Each row As DataGridViewRow In MetroGrid1.Rows
            Dim checkBox As DataGridViewCheckBoxCell = (TryCast(row.Cells("CheckColumn"), DataGridViewCheckBoxCell))
            checkBox.Value = CheckBox1.Checked
        Next
    End Sub
    Private Sub DataGridView_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        'Check to ensure that the row CheckBox is clicked.
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then

            'Loop to verify whether all row CheckBoxes are checked or not.
            Dim isChecked As Boolean = True
            For Each row As DataGridViewRow In MetroGrid1.Rows
                If Convert.ToBoolean(row.Cells("CheckColumn").EditedFormattedValue) = False Then
                    isChecked = False

                    Exit For
                End If
            Next
            CheckBox1.Checked = isChecked
        End If

    End Sub
    Public Sub dataGridView1_CountSelected(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles MetroGrid1.CellValueChanged
        'If MetroGrid1.Columns(e.ColumnIndex).Name = "CheckColumn" Then
        '    Dim count1 As Integer = 0
        '    For Each row As DataGridViewRow In MetroGrid1.Rows
        '        If row.Cells("CheckColumn").Value IsNot Nothing And row.Cells("CheckColumn").Value = True Then
        '            count1 += 1
        '        End If
        '    Next
        '    LabelCount.Text = count1
        'End If
    End Sub
    '------------------------------------------------------------------Fungsi untuk Checkbox Select All pada DataGrid

    ''' <summary>
    ''' Funsi untuk menampilkan barcode kedalam Crystal Report
    ''' </summary>

    Public Shared Function ConvertToByteArray(ByVal value As Bitmap) As Byte()
        'Fungsion untuk Convert Bitmap to Byte Array
        Dim bitmapBytes As Byte()
        Using stream As New System.IO.MemoryStream
            value.Save(stream, System.Drawing.Imaging.ImageFormat.Png)
            bitmapBytes = stream.ToArray
        End Using
        Return bitmapBytes
    End Function

    Public Function EncodeBarCode(ByVal barcodeValue As String, ByVal barcodeSize As Int32) As Bitmap
        ''Fungsion untuk membuat BarCode Type QR_CODE
        Dim Writer = New BarcodeWriter With
            {
            .Format = BarcodeFormat.QR_CODE,
            .Options = New EncodingOptions() With {.Height = barcodeSize, .Width = barcodeSize, .Margin = 1}
            }
        Return Writer.Write(barcodeValue)
    End Function

    Public Function EncodeQrCode2(ByVal barcodeValue As String, ByVal barcodeSize As Int32) As Bitmap
        ''Fungsion untuk membuat Barcode 2D Type 128
        Dim Writer = New BarcodeWriter() With
            {
            .Format = BarcodeFormat.CODE_128,
            .Options = New EncodingOptions() With {.Height = barcodeSize, .Width = barcodeSize, .Margin = 1}
            }
        Return Writer.Write(barcodeValue)
    End Function

    Public Sub btnDelete_Click(sender As Object, e As EventArgs)
        ''Pada sub btnDelete_Click ini akan menerima sinyal dari Print Label kertas biasa pada tombol PrintCrystalReport
        ''Membuat list datagrid yang CheckBox Selected
        Dim selectedRows As List(Of DataGridViewRow) = (From row In MetroGrid2.Rows.Cast(Of DataGridViewRow)()
                                                        Where Convert.ToBoolean(row.Cells("CheckColumn").Value) = True).ToList()
        'If MessageBox.Show(String.Format("Do you want to delete {0} rows?", selectedRows.Count), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
        For Each row As DataGridViewRow In MetroGrid2.Rows
            Using cmd As New SqlCommand("sp_InsertTglPrintLabel", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_login", SqlDbType.Int).Value = login.Luserid.Text
                cmd.Parameters.AddWithValue("@Id_barcode", row.Cells("LabNumberColumn").Value)  ''mengambil nilai/value dari dalam gridview.row.cell tertentu

                cmd.Parameters.Add("@mark", SqlDbType.VarChar).Value = LabelMark.Text
                con.Open()
                cmd.ExecuteScalar()
                con.Close()
            End Using
        Next

    End Sub

    Private Sub BtnPreview_Click(sender As Object, e As EventArgs) Handles BtnPreview.Click
        If Not LabelCount.Text = "..." Or LabelCount.Text = "0" Then
            If String.IsNullOrEmpty(LabelCount.Text) = False And LabelCount.Text > 0 Then
                If RadioA2internal.Checked = True Then
                    'Internal Lab Label
                    TermalPrintLA2(sender, e)
                    FlagRawStorage()
                    'ElseIf RadioA3SubLabel.Checked = True Then
                    '    TermalPrintLA3(sender, e)
                    '    FlagRawStorage()
                ElseIf RadioA4LabelSample.Checked = True Then
                    'Sampling Lab Label
                    TermalPrintA42024(sender, e)
                    FlagRawStorage()
                Else
                    MetroMessageBox.Show(Me, "2. Pilih Label Type")
                End If
            Else
                MetroMessageBox.Show(Me, "1. Select kotak pada DataList")
            End If
        Else
            MetroMessageBox.Show(Me, "1. Select kotak pada DataList")
        End If

    End Sub

    Public Function GetDefaultPrinter() As String
        Dim settings As PrinterSettings = New PrinterSettings()
        Return settings.PrinterName
    End Function

    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        ' loop to check if the checkbox cell is checked
        For i As Integer = 0 To MetroGrid1.Rows.Count() - 1 Step +1

            ' rowAlreadyExist => if the row already exist on MetroGrid2
            Dim rowAlreadyExist As Boolean = False
            Dim check As Boolean = MetroGrid1.Rows(i).Cells(0).Value
            Dim row As DataGridViewRow = MetroGrid1.Rows(i)
            If check = True Then

                'Check the MetroGrid2 have one row or more
                If MetroGrid2.Rows.Count() > 0 Then

                    'filtering loop to see if the row already exist on MetroGrid2
                    For j As Integer = 0 To MetroGrid2.Rows.Count() - 1 Step +1
                        'membandingkan MetroGrid1 pada Column(3) Lab number dengan MetroGrid2 pada Column(1) Lab number
                        If row.Cells("LabnumColumn").Value.ToString() = MetroGrid2.Rows(j).Cells(1).Value.ToString() Then
                            rowAlreadyExist = True
                            Exit For
                        End If
                    Next

                    If rowAlreadyExist = False Then
                        MetroGrid2.Rows.Add(False,
                                            row.Cells("LabnumColumn").Value.ToString(),
                                            row.Cells("norencana").Value.ToString(), '' ID VEndor
                                            SqlToBinding2("category_crop.crop", row.Cells("LabnumColumn").Value.ToString()),
                                            row.Cells("VarietyColumn1").Value.ToString(),
                                            row.Cells("NomnlColumn").Value.ToString(),
                                            row.Cells("NojobColumn").Value.ToString(),
                                            row.Cells("HarvestColumn").Value,
                                            row.Cells("WeightColumn1").Value.ToString(),
                                            row.Cells("ScopeColumn1").Value.ToString(),
                                            "",
                                            "",
                                            SqlToBinding2("qc_confirm_viewer.test_moi", row.Cells("LabnumColumn").Value.ToString()),
                                            SqlToBinding2("qc_confirm_viewer.test_pur", row.Cells("LabnumColumn").Value.ToString()),
                                            SqlToBinding2("qc_confirm_viewer.test_ger", row.Cells("LabnumColumn").Value.ToString()),
                                            SqlToBinding2("qc_confirm_viewer.test_sampling", row.Cells("LabnumColumn").Value.ToString()),
                                            SqlToBinding2("qc_confirm_viewer.test_raf", row.Cells("LabnumColumn").Value.ToString()),
                                            SqlToBinding2("qc_confirm_viewer.test_via", row.Cells("LabnumColumn").Value.ToString())
                                            )
                    End If

                Else
                    MetroGrid2.Rows.Add(False,
                                        row.Cells("LabnumColumn").Value.ToString(),
                                        row.Cells("norencana").Value.ToString(), 'ID Vendor
                                        SqlToBinding2("category_crop.crop", row.Cells("LabnumColumn").Value.ToString()),
                                        row.Cells("VarietyColumn1").Value.ToString(),
                                        row.Cells("NomnlColumn").Value.ToString(),
                                        row.Cells("NojobColumn").Value.ToString(),
                                        row.Cells("HarvestColumn").Value,
                                        row.Cells("WeightColumn1").Value.ToString(),
                                        row.Cells("ScopeColumn1").Value.ToString(),
                                        "",
                                        "",
                                        SqlToBinding2("qc_confirm_viewer.test_moi", row.Cells("LabnumColumn").Value.ToString()),
                                        SqlToBinding2("qc_confirm_viewer.test_pur", row.Cells("LabnumColumn").Value.ToString()),
                                        SqlToBinding2("qc_confirm_viewer.test_ger", row.Cells("LabnumColumn").Value.ToString()),
                                        SqlToBinding2("qc_confirm_viewer.test_sampling", row.Cells("LabnumColumn").Value.ToString()),
                                        SqlToBinding2("qc_confirm_viewer.test_raf", row.Cells("LabnumColumn").Value.ToString()),
                                        SqlToBinding2("qc_confirm_viewer.test_via", row.Cells("LabnumColumn").Value.ToString())
                                        )
                End If
            End If
        Next
        Dim int As Integer
        int = MetroGrid2.Rows.Count()
        LabelCount.Text = int
    End Sub


    Private Sub BtnSendBack_Click(sender As Object, e As EventArgs) Handles BtnSendBack.Click
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
        Dim int As Integer
        int = MetroGrid2.Rows.Count()
        LabelCount.Text = int
    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        MetroGrid2.Rows.Clear()
        Dim int As Integer
        int = MetroGrid2.Rows.Count()
        LabelCount.Text = int
    End Sub

    Private Sub RadioA2internal_CheckedChanged(sender As Object, e As EventArgs) Handles RadioA2internal.CheckedChanged
        LabelMark.Text = "LA2"
    End Sub

    Private Sub RadioA3SubLabel_CheckedChanged(sender As Object, e As EventArgs)
        LabelMark.Text = "LA3"
    End Sub

    Private Sub RadioA4LabelSample_CheckedChanged(sender As Object, e As EventArgs) Handles RadioA4LabelSample.CheckedChanged
        LabelMark.Text = "LA4"
    End Sub

    Private Sub LabelPrinter_Click(sender As Object, e As EventArgs) Handles LabelPrinter.Click
        Dim Select_Printer = New Select_Printer
        AddHandler Select_Printer.SavedOptions, AddressOf OnOptionsSave
        Select_Printer.ShowDialog(Me)
    End Sub

    Private Sub LabelPrinter2_Click(sender As Object, e As EventArgs) Handles LabelPrinter2.Click
        Dim Select_Printer = New Select_Printer
        AddHandler Select_Printer.SavedOptions, AddressOf OnOptionsSave
        Select_Printer.ShowDialog(Me)
    End Sub

    Private Sub OnOptionsSave(ByVal strData As String)
        'Or whatever you want to do on frmMain with Options Data.
        If MetroTabControl1.SelectedTab Is MetroTabPage1 Then
            LabelPrinter.Text = strData
        Else
            LabelPrinter2.Text = strData
        End If
    End Sub

    Private Sub BtnPreview2_Click(sender As Object, e As EventArgs) Handles BtnPreview2.Click
        If trequestcopy.Text <= 0 Then
            MetroMessageBox.Show(Me, "Number Of Copy must be more than 0")
            trequestcopy.Focus()
        Else
            If Not LabelCount.Text = "..." Then
                If String.IsNullOrEmpty(LabelCount.Text) = False And LabelCount.Text > 0 Then
                    If LabelPrinter.Text.Contains("ZPL") Then
                        TermalPrintLA1()
                        FlagRawStorage()
                    Else
                        MetroMessageBox.Show(Me, "Label ini hanya bisa di cetak dengan Zebra ZPL Termal Printer")
                    End If
                Else
                    MetroMessageBox.Show(Me, "1. Select kotak pada DataList")
                End If
            Else
                MetroMessageBox.Show(Me, "1. Select kotak pada DataList")
            End If
        End If
    End Sub

    Private Sub Tsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles Tsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Tsearch_ButtonClick(sender, e)
        End If
    End Sub

    Private Sub Tsearch_ButtonClick(sender As Object, e As EventArgs) Handles Tsearch.ButtonClick
        If String.IsNullOrEmpty(Tsearch.Text) = False Then
            Me.TermalDataTableTableAdapter.FillByParameterLabnum(Me.HCQC_NewDataset.TermalDataTable, "%" + Trim(Tsearch.Text) + "%")
        End If
    End Sub

    Private Sub Report_Label_HCQC_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub LinkFiltertoPrint_Click(sender As Object, e As EventArgs) Handles LinkFiltertoPrint.Click
        MetroPanel1.Enabled = False
        TermalDataTableTableAdapter.FillByNotPrint(Me.HCQC_NewDataset.TermalDataTable)
        MetroPanel1.Enabled = True
    End Sub

End Class