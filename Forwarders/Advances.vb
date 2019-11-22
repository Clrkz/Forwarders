Public Class Advances

    Private Sub Advances_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = True
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpTransDate.ValueChanged

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        FW.InsertTempAdvExpense()
    End Sub
End Class