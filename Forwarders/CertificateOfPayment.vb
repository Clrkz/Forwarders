Public Class CertificateOfPayment
    Private Sub CertificateOfPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = True
        cboStatus.SelectedIndex = 0
        txtDateEncoded.ReadOnly = True
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

    Public Sub populateToFieldsCertidicateOfpayment()
        TextBox48.Text = FW.CPNo
        TextBox49.Text = FW.copConsignee
        TextBox50.Text = FW.Manufacturer
        TextBox52.Text = FW.Series
        TextBox53.Text = FW.copClass
        TextBox54.Text = FW.Color
        TextBox55.Text = FW.YearModel
        TextBox56.Text = FW.EngineNo
        TextBox57.Text = FW.SerialNo
        TextBox58.Text = FW.EngineDisplacement
        TextBox59.Text = FW.Examiner
        TextBox62.Text = FW.DateofDelivery
        TextBox61.Text = FW.RecievedBy
        TextBox60.Text = FW.RecievedDate
        TextBox51.Text = FW.IssuedDate

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
        TextBox48.Text = ""
        TextBox49.Text = ""
        TextBox50.Text = ""
        TextBox52.Text = ""
        TextBox53.Text = ""
        TextBox54.Text = ""
        TextBox55.Text = ""
        TextBox56.Text = ""
        TextBox57.Text = ""
        TextBox58.Text = ""
        TextBox59.Text = ""
        TextBox62.Text = ""
        TextBox61.Text = ""
        TextBox60.Text = ""
        TextBox51.Text = ""

    End Sub

End Class