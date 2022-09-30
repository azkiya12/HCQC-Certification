Public Class Sample_Return_Form

    Private Sub Sample_Return_Form_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If _isBOF("[spl_ambil]", "[id_request]", Lreqnum.Text) = False Then
            'MsgBox("sample request number kosong")
            _RunSQL("INSERT INTO [dbo].[spl_ambil]
                               ([id_request]
                               ,[id_login]
                               ,[officer]
                               ,[remark]
                               ,[tgl]   )
                         VALUES
                               (" & Val(Lreqnum.Text) & "
                               ," & Val(login.Luserid.Text) & "
                               ,'" & Tnama.Text & "'
                               ,'" & Tremark.Text & "'
                               ,GETDATE())
                ")
            If strupdate = 1 Then
                Me.DialogResult = DialogResult.OK
            End If
        Else
            _RunSQL("UPDATE [dbo].[spl_ambil]
                        SET [id_login] = " & Val(login.Luserid.Text) & "
                            ,[officer] = '" & Tnama.Text & "'
                            ,[remark] = '" & Tremark.Text & "'
                            ,[tgl] = GETDATE()
                      WHERE [id_request] = " & Val(Lreqnum.Text) & " 
            ")
            If strupdate = 1 Then
                Me.DialogResult = DialogResult.OK
            End If
        End If
    End Sub

    Private Sub Sample_Return_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
