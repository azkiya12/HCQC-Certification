Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Kategori_Crop
    Private Sub BtnChangePass_Click(sender As Object, e As EventArgs) Handles BtnChangePass.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If (Not String.IsNullOrEmpty(ComboBox1.Text)) Or (ComboBox1.SelectedIndex > -1) Then
            If Val(_DataToValue("SELECT count(prodcode)
                          FROM [HCQC_server].[dbo].[category_crop]
                          where prodcode='" & TprodCode.Text & "'")) > 0 And BtnSave.Text = "Add" Then
                TprodCode.WithError = True
                TprodCode.Focus()
                MetroMessageBox.Show(Me, TprodCode.Text & " This product already exists")
                Return
            End If

            If BtnSave.Text = "Add" Then
                Dim query As String = String.Empty
                query &= "INSERT [dbo].[category_crop] "
                query &= "([crop], [prodcode], [comname], [type]) VALUES "
                query &= "(@crop, @prodcode, @comname, @type)"

                Using conn As New SqlConnection("Data Source=10.15.13.91\SQLEXPRESS;Initial CataLog=HCQC_server;User ID=admin;Password=administrator")
                    Using comm As New SqlCommand()
                        With comm
                            .Connection = conn
                            .CommandType = CommandType.Text
                            .CommandText = query
                            .Parameters.AddWithValue("@crop", TcropName.Text)
                            .Parameters.AddWithValue("@prodcode", TprodCode.Text)
                            .Parameters.AddWithValue("@comname", TComersName.Text)
                            .Parameters.AddWithValue("@type", ComboBox1.SelectedText)
                        End With

                        Try
                            conn.Open()
                            comm.ExecuteNonQuery()
                            conn.Close()
                            Category_List.OnRefreshEventHendler()
                            MetroMessageBox.Show(Me, "Success Add. Thanks...", "Profile", MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                            Me.DialogResult = DialogResult.OK
                        Catch ex As SqlException
                            MetroMessageBox.Show(Me, ex.Message & " Troble error Category Add", "Category Crop", MessageBoxButtons.OK, MessageBoxIcon.None, 211)
                        End Try

                    End Using
                End Using
                'End If

            ElseIf BtnSave.Text = "Update" Then
                Dim query As String = String.Empty
                query &= "UPDATE [dbo].[category_crop] SET "
                query &= "[crop] = @crop
                     ,[prodcode] = @prodcode
                     ,[comname] = @comname
                     ,[type]=@type"
                query &= " WHERE id=@id"

                Using conn As New SqlConnection("Data Source=10.15.13.91\SQLEXPRESS;Initial CataLog=HCQC_server;User ID=admin;Password=administrator")
                    Using comm As New SqlCommand()
                        With comm
                            .Connection = conn
                            .CommandType = CommandType.Text
                            .CommandText = query
                            .Parameters.AddWithValue("@id", Tid.Text)
                            .Parameters.AddWithValue("@crop", TcropName.Text)
                            .Parameters.AddWithValue("@prodcode", TprodCode.Text)
                            .Parameters.AddWithValue("@comname", TComersName.Text)
                            .Parameters.AddWithValue("@type", ComboBox1.Text)
                        End With

                        Try
                            conn.Open()
                            comm.ExecuteNonQuery()
                            conn.Close()
                            MetroMessageBox.Show(Me, "Success Change Password", "Profile", MessageBoxButtons.OK, MessageBoxIcon.Information, 211)
                            Me.DialogResult = DialogResult.OK
                        Catch ex As SqlException
                            MetroMessageBox.Show(Me, ex.Message & " Troble error Change Password", "Profile", MessageBoxButtons.OK, MessageBoxIcon.None, 211)
                        End Try
                    End Using
                End Using
            End If
        Else
            MetroMessageBox.Show(Me, "Select Type of crop")
        End If
    End Sub

    Private Sub TprodCode_TextChanged(sender As Object, e As EventArgs) Handles TprodCode.TextChanged
        TprodCode.WithError = False
    End Sub

    Private Sub Kategori_Crop_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub TprodCode_Validating(sender As Object, e As CancelEventArgs) Handles TprodCode.Validating
        If Val(_DataToValue("SELECT count(prodcode)
                          FROM [HCQC_server].[dbo].[category_crop]
                          where prodcode='" & TprodCode.Text & "'")) > 0 Then
            TprodCode.WithError = True
            Return
        End If
    End Sub

    Private Sub MyBase_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class