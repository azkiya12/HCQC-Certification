<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataGridDevexpress
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.QcconfirmviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatasetBarCode = New WindowsApp1.DatasetBarCode()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Qc_confirm_viewTableAdapter = New WindowsApp1.DatasetBarCodeTableAdapters.qc_confirm_viewTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QcconfirmviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatasetBarCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(776, 426)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'QcconfirmviewBindingSource
        '
        Me.QcconfirmviewBindingSource.DataMember = "qc_confirm_view"
        Me.QcconfirmviewBindingSource.DataSource = Me.DatasetBarCode
        '
        'DatasetBarCode
        '
        Me.DatasetBarCode.DataSetName = "DatasetBarCode"
        Me.DatasetBarCode.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'Qc_confirm_viewTableAdapter
        '
        Me.Qc_confirm_viewTableAdapter.ClearBeforeFill = True
        '
        'DataGridDevexpress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "DataGridDevexpress"
        Me.Text = "DataGridDevexpress"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QcconfirmviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatasetBarCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DatasetBarCode As DatasetBarCode
    Friend WithEvents QcconfirmviewBindingSource As BindingSource
    Friend WithEvents Qc_confirm_viewTableAdapter As DatasetBarCodeTableAdapters.qc_confirm_viewTableAdapter
End Class
