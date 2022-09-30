Option Explicit On
Option Strict On
Option Infer Off

Public Class PrintZPL
    Private Sub PrintZPL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatasetBarCode.qc_confirm_view' table. You can move, or remove it, as needed.
        Me.Qc_confirm_viewTableAdapter.Fill(Me.DatasetBarCode.qc_confirm_view)
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click

        Dim V_idprod, V_Crop, V_harvest1, V_variety1, v_labnum, V_variety2, Vlot, V_weight, V_sampling, V_sampler, V_subtrac As String
        Dim B_moisture, B_Purity, B_germination, B_sampling, B_rafaction, B_rapit As String
        Dim V_moisture, V_Purity, V_germination, V_Bsampling, V_rafaction, V_rapit As String
        For Each row As DataGridViewRow In MetroGrid1.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("CheckColumn").Value)
            If isSelected Then
                Dim zplcom As String

                V_idprod = CType(row.Cells("IdhvsprodDataGridViewTextBoxColumn").Value, String)
                V_Crop = CType(row.Cells("CropDataGridViewTextBoxColumn").Value, String)
                V_harvest1 = CType(row.Cells("HarvestDataGridViewTextBoxColumn").Value, String)
                V_variety1 = CType(row.Cells("VarietyDataGridViewTextBoxColumn").Value, String)
                Vlot = CType(row.Cells("NomnlDataGridViewTextBoxColumn").Value, String) + "/" + CType(row.Cells("NojobDataGridViewTextBoxColumn").Value, String)

                v_labnum = CType(row.Cells("LabnumDataGridViewTextBoxColumn").Value, String)
                V_variety2 = V_variety1
                V_weight = CType(row.Cells("WeightDataGridViewTextBoxColumn").Value, String)
                V_sampling = CType(row.Cells("TglconfirmDataGridViewTextBoxColumn").Value, String)
                V_sampler = ""
                V_subtrac = CType(row.Cells("ScopeDataGridViewTextBoxColumn").Value, String)

                B_moisture = CType(row.Cells("TestmoiDataGridViewCheckBoxColumn").Value, String)
                B_Purity = CType(row.Cells("TestpurDataGridViewCheckBoxColumn").Value, String)
                B_germination = CType(row.Cells("TestgerDataGridViewCheckBoxColumn").Value, String)
                B_sampling = CType(row.Cells("TestsamplingDataGridViewCheckBoxColumn").Value, String)
                B_rafaction = CType(row.Cells("TestrafDataGridViewCheckBoxColumn").Value, String)
                B_rapit = CType(row.Cells("TestviaDataGridViewCheckBoxColumn").Value, String)

                V_moisture = CType(IIf(B_moisture = "True", "8", "2"), String)
                V_Purity = CType(IIf(B_Purity = "True", "8", "2"), String)
                V_germination = CType(IIf(B_germination = "True", "8", "2"), String)
                V_Bsampling = CType(IIf(B_sampling = "True", "8", "2"), String)
                V_rafaction = CType(IIf(B_rafaction = "True", "8", "2"), String)
                V_rapit = CType(IIf(B_rapit = "True", "8", "2"), String)
                zplcom = "CT~~CD,~CC^~CT~
                            ^XA
                            ^DFE:Label10x5cm.ZPL^FS
                            ~TA000
                            ~JSN
                            ^LT0
                            ^MNW
                            ^MTT
                            ^PON
                            ^PMN
                            ^LH0,0
                            ^JMA
                            ^PR6,6
                            ~SD15
                            ^JUS
                            ^LRN
                            ^CI27
                            ^PA0,1,1,0
                            ^MMT
                            ^PW799
                            ^LL400
                            ^LS0
                            ^FT121,55^A@N,17,18,TT0003M_^FH\^CI28^FDHORTICULTURE CROP QUALITY CONTROL^FS^CI27
                            ^FT121,73^A@N,17,18,TT0003M_^FH\^CI28^FDPT BISI INTERNATIONAL TBK^FS^CI27
                            ^FT121,91^A@N,17,18,TT0003M_^FH\^CI28^FDPARE WATES STREET KM 9,^FS^CI27
                            ^FT121,109^A@N,17,18,TT0003M_^FH\^CI28^FDSUMBERAGUNG-PLOSOKLATEN-KEDIRI^FS^CI27
                            ^FPH,1^FT662,20^A@R,14,13,TT0003M_^FH\^CI28^FDVariety:^FS^CI27
                            ^FT49,292^A@N,23,22,TT0003M_^FH\^CI28^FDVariety :^FS^CI27
                            ^FT49,318^A@N,23,22,TT0003M_^FH\^CI28^FDCrop:^FS^CI27
                            ^FT49,344^A@N,23,22,TT0003M_^FH\^CI28^FDHarvest Date:^FS^CI27
                            ^FT49,373^A@N,23,22,TT0003M_^FH\^CI28^FDLot/Refrence Number:^FS^CI27
                            ^FPH,1^FT639,20^A@R,14,13,TT0003M_^FH\^CI28^FDQuantity (kg):^FS^CI27
                            ^FT664,188^A@R,14,13,TT0003M_^FB94,1,7,R^FH\^CI28^FDSampling Date:^FS^CI27
                            ^FT627,193^A@R,14,13,TT0003M_^FB89,1,7,R^FH\^CI28^FDSeed Sampler:^FS^CI27
                            ^FT740,319^A@R,14,13,TT0003M_^FH\^CI28^FDMoisture^FS^CI27
                            ^FT715,319^A@R,14,13,TT0003M_^FH\^CI28^FDPurity^FS^CI27
                            ^FT691,319^A@R,14,13,TT0003M_^FH\^CI28^FDGermination^FS^CI27
                            ^FT667,319^A@R,14,13,TT0003M_^FH\^CI28^FDSampling^FS^CI27
                            ^FT642,319^A@R,14,13,TT0003M_^FH\^CI28^FDRafaction^FS^CI27
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
                            ^BY2,3,45^FT707,30^BCR,,Y,N
                            ^FH\^FD>:QC>5" & v_labnum.Substring(v_labnum.Length - 10) & "^FS
                            ^BY4,3,80^FT49,221^BCN,,Y,N
                            ^FH\^FD>;" & V_idprod & ">65^FS
                            ^FT113,318^A@N,23,22,TT0003M_^FH\^CI28^FD" & V_Crop & "^FS^CI27
                            ^FT191,344^A@N,23,22,TT0003M_^FH\^CI28^FD" & V_harvest1 & "^FS^CI27
                            ^FT135,292^A@N,23,22,TT0003M_^FH\^CI28^FD" & V_variety1 & "^FS^CI27
                            ^FT277,373^A@N,23,22,TT0003M_^FH\^CI28^FD" & Vlot & "^FS^CI27
                            ^FT662,76^A@R,14,13,TT0003M_^FH\^CI28^FD" & V_variety2 & "^FS^CI27
                            ^FT639,121^A@R,14,13,TT0003M_^FH\^CI28^FD" & V_weight & "^FS^CI27
                            ^FT645,209^A@R,14,13,TT0003M_^FB73,1,7,R^FH\^CI28^FD" & V_sampling.Substring(0, 10) & "^FS^CI27
                            ^FT611,186^A@R,14,13,TT0003M_^FB96,1,7,R^FH\^CI28^FD" & V_sampler & "^FS^CI27
                            ^FT615,20^A@R,14,13,TT0003M_^FH\^CI28^FD" & V_subtrac & "^FS^CI27
                            ^XZ

                            ^XA
                            ^XFE:Label10x5cm.ZPL^FS
                            ^PQ1,0,1
                            ^XZ
                            "
                Printer.RawHelper.SendStringToPrinter("ZDesigner ZD230-203dpi ZPL", zplcom)
            End If
        Next
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click

    End Sub
End Class