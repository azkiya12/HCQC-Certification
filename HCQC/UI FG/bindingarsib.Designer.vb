<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bindingarsib
    'Inherits MetroFramework.Forms.MetroForm
    Inherits SlidePanel2
    Sub New(ByVal owner As MetroFramework.Forms.MetroForm)
        MyBase.new(owner)

        InitializeComponent()

        Me.StyleManager.Update()

    End Sub


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid
        Me.FgidBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCQC_serverDataSet = New WindowsApplication1.HCQC_serverDataSet
        Me.Fg_idTableAdapter = New WindowsApplication1.HCQC_serverDataSetTableAdapters.fg_idTableAdapter
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton
        Me.Nolab = New System.Windows.Forms.DataGridViewLinkColumn
        Me.Variety = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nojob = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Hvdt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.brt_ars = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.brtunit_ars = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ket = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dtqc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ka_ars = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dt_ars = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.kardus = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FgidBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroGrid1.AutoGenerateColumns = False
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nolab, Me.Variety, Me.Nojob, Me.Hvdt, Me.brt_ars, Me.brtunit_ars, Me.Ket, Me.Dtqc, Me.ka_ars, Me.dt_ars, Me.kardus})
        Me.MetroGrid1.DataSource = Me.FgidBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(8, 8)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(620, 174)
        Me.MetroGrid1.TabIndex = 0
        '
        'FgidBindingSource
        '
        Me.FgidBindingSource.DataMember = "fg_id"
        Me.FgidBindingSource.DataSource = Me.HCQC_serverDataSet
        '
        'HCQC_serverDataSet
        '
        Me.HCQC_serverDataSet.DataSetName = "HCQC_serverDataSet"
        Me.HCQC_serverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Fg_idTableAdapter
        '
        Me.Fg_idTableAdapter.ClearBeforeFill = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroButton1.Location = New System.Drawing.Point(8, 188)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 1
        Me.MetroButton1.Text = "Back"
        Me.MetroButton1.UseSelectable = True
        '
        'Nolab
        '
        Me.Nolab.DataPropertyName = "no_lab"
        Me.Nolab.HeaderText = "no_lab"
        Me.Nolab.Name = "Nolab"
        Me.Nolab.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Nolab.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Variety
        '
        Me.Variety.DataPropertyName = "variety"
        Me.Variety.HeaderText = "variety"
        Me.Variety.Name = "Variety"
        '
        'Nojob
        '
        Me.Nojob.DataPropertyName = "nojob"
        Me.Nojob.HeaderText = "nojob"
        Me.Nojob.Name = "Nojob"
        Me.Nojob.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Hvdt
        '
        Me.Hvdt.DataPropertyName = "hv_dt"
        Me.Hvdt.HeaderText = "hv_dt"
        Me.Hvdt.Name = "Hvdt"
        '
        'brt_ars
        '
        Me.brt_ars.DataPropertyName = "brt_ars"
        Me.brt_ars.HeaderText = "Berat"
        Me.brt_ars.Name = "brt_ars"
        '
        'brtunit_ars
        '
        Me.brtunit_ars.DataPropertyName = "brtunit_ars"
        Me.brtunit_ars.HeaderText = "Satuan"
        Me.brtunit_ars.Name = "brtunit_ars"
        '
        'Ket
        '
        Me.Ket.DataPropertyName = "ket"
        Me.Ket.HeaderText = "Ket"
        Me.Ket.Name = "Ket"
        '
        'Dtqc
        '
        Me.Dtqc.DataPropertyName = "Dtqc"
        Me.Dtqc.HeaderText = "Tgl Masuk"
        Me.Dtqc.Name = "Dtqc"
        '
        'ka_ars
        '
        Me.ka_ars.DataPropertyName = "ka_ars"
        Me.ka_ars.HeaderText = "KA"
        Me.ka_ars.Name = "ka_ars"
        Me.ka_ars.Width = 75
        '
        'dt_ars
        '
        Me.dt_ars.DataPropertyName = "dt_ars"
        Me.dt_ars.HeaderText = "DT"
        Me.dt_ars.Name = "dt_ars"
        Me.dt_ars.Width = 75
        '
        'kardus
        '
        Me.kardus.DataPropertyName = "kardus"
        Me.kardus.HeaderText = "Kardus"
        Me.kardus.Name = "kardus"
        '
        'bindingarsib
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "bindingarsib"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(636, 221)
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FgidBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCQC_serverDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents FgidBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HCQC_serverDataSet As WindowsApplication1.HCQC_serverDataSet
    Friend WithEvents Fg_idTableAdapter As WindowsApplication1.HCQC_serverDataSetTableAdapters.fg_idTableAdapter
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Nolab As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Variety As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nojob As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hvdt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents brt_ars As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents brtunit_ars As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ket As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dtqc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ka_ars As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dt_ars As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kardus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
