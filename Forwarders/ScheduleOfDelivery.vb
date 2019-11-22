Public Class ScheduleOfDelivery
    Private Sub ScheduleOfDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = True
        cboStatus.SelectedIndex = 0
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
    Public Sub populateToFields()
        txtFileNo.Text = FW.FileNo
        txtCustomer.Text = FW.Customer
        txtCosignee.Text = FW.Consignee
        txtSalesPerson.Text = FW.SalesPerson
        txtDescription.Text = FW.Description
        txtCodeNumber.Text = FW.ControlNo
        cboStatus.Text = FW.Status
        txtDateEncoded.Text = FW.DateEncoded
        TextBox1.Text = FW.CAS
        TextBox2.Text = FW.ReceivedDate
        TextBox3.Text = FW.ReceivedBy
        TextBox4.Text = FW.ExpirationDate
        TextBox5.Text = FW.ApprovalDate

    End Sub
    Public Sub ClearDetails()
        txtFileNo.Text = ""
        txtCustomer.Text = ""
        txtCosignee.Text = ""
        txtSalesPerson.Text = ""
        txtDescription.Text = ""
        txtCodeNumber.Text = ""
        cboStatus.SelectedIndex = 0
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""

    End Sub

End Class