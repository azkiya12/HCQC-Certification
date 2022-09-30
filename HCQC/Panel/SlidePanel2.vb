Imports Transitions

Public Class SlidePanel2
    Public Event Closed2 As EventHandler
    Public Event Shown2 As EventHandler

    Private Sub pnlSlider_Click(ByVal sender As Object, ByVal e As EventArgs)
        swiper2(False)
    End Sub

    Private Sub owner_Resize(ByVal sender As Object, ByVal e As EventArgs)
        ResizeForm()
    End Sub

    Private Sub ResizeForm()
        Me.Width = _owner.Width
        Me.Height = _owner.Height - 70
        Me.Location = New Point(If(_loader, 0, _owner.Width), 50)
    End Sub

    Public Sub swiper2(Optional ByVal show As Boolean = False)
        Me.Visible = True
        Dim _transasition As Transition = New Transitions.Transition(New TransitionType_EaseInEaseOut(500))
        _transasition.add(Me, "Left", IIf(show, 0, Me.Width))
        _transasition.run()

        While Me.Left <> IIf(show, 0, Me.Width)
            Application.DoEvents()
        End While

        If Not show Then
            RaiseEvent Closed2(Me, New EventArgs)
            RemoveHandler _owner.Resize, AddressOf owner_Resize
            _owner.Controls.Remove(Me)
            Me.Dispose()
        Else
            _loader = True
            ResizeForm()
            RaiseEvent Shown2(Me, New EventArgs)
        End If
    End Sub

End Class
