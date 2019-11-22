Public Class MainFW
    Private Sub MainFW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = True
    End Sub
    Private Sub txtFileNo_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFileNo.GotFocus
        If txtFileNo.Text = "F3 to search" Then
            txtFileNo.Text = ""
        End If
    End Sub
    Private Sub txtFileNo_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFileNo.LostFocus
        If txtFileNo.Text = "" Then
            txtFileNo.Text = "F3 to search"
        End If
    End Sub
End Class