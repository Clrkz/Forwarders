Public Class Advances

    Private Sub Advances_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = True
        cboStatus.SelectedIndex = 0
        txtEmployee.Text = FW.gs_User
        txtEncodedBy.Text = FW.gs_User
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
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpTransDate.ValueChanged

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        FW.InsertTempAdvExpense()
    End Sub

    Public Sub populateToFields()
        txtFileNo.Text = FW.FileNo
        txtCustomer.Text = FW.Customer
        txtConsignee.Text = FW.Consignee
    End Sub

    Public Sub ClearDetails()
        chkReceipted.Checked = False
        cboStatus.SelectedIndex = 0
        For Each txt In {txtRefNo, txtFileNo, txtCustomer, txtConsignee, txtRemarks, txtShipmentCode, txtCANo, txtPort, textParticular, txtAmount, txtApprovedAmount, txtLiquidated, txtTotalAmount, txtTotalApprovedAmount, txtTotalLiquidated, txtNote, txtNotedBy, txtApprovedBy, txtComments}
            txt.Clear()
        Next

        dgvAdvExpenses.DataSource = Nothing
        dgvAdvExpenses.Refresh()

    End Sub
End Class