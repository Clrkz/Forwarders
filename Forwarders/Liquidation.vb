Public Class Liquidation
    Dim selectedRow As Integer

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Liquidation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        selectedRow = DataGridView1.CurrentRow.Index + 1
        FW.getAdvancesID(selectedRow)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class