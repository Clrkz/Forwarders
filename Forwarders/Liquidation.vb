Public Class Liquidation
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Liquidation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = True
        FW.getLiquid("RN1574439213257")
    End Sub
End Class