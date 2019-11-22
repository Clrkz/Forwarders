Public Class CustomInfo
    Private Sub CustomInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = True
        'cboStatus.SelectedIndex = 0
        txtDateEncoded.ReadOnly = True
        Timer1.Start()
        TextBox45.Text = TimeOfDay.ToString("hh:mm:ss")
        TextBox46.Text = TimeOfDay.ToString("hh:mm:ss")
        TextBox47.Text = TimeOfDay.ToString("hh:mm:ss")
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
        'tiytyu

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
        TextBox30.Text = ""
        TextBox31.Text = ""
        TextBox32.Text = ""
        TextBox33.Text = ""
        TextBox34.Text = ""
        TextBox35.Text = ""
        TextBox36.Text = ""
        TextBox37.Text = ""
        TextBox38.Text = ""
        TextBox39.Text = ""
        TextBox40.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox2.Text = ""
        ComboBox1.Text = ""
        TextBox41.Text = ""
        TextBox42.Text = ""
        ComboBox5.Text = ""
        TextBox45.Text = ""
        TextBox43.Text = ""
        ComboBox6.Text = ""
        TextBox46.Text = ""
        CheckBox12.Checked = False
        ComboBox7.Text = ""
        TextBox47.Text = ""
        TextBox44.Text = ""
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub Label58_Click(sender As Object, e As EventArgs) Handles Label58.Click

    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
    Public Sub populateToFieldsCustomInfo()

        TextBox30.Text = FW.OfficeCode
        TextBox31.Text = FW.CECode
        TextBox32.Text = FW.CountryofOrigin
        TextBox33.Text = FW.TermsofDelievery
        TextBox34.Text = FW.Currency
        TextBox35.Text = FW.ExchangeRate
        TextBox36.Text = FW.TotalCustomsValue
        TextBox37.Text = FW.PickupLocation
        TextBox38.Text = FW.LocationofGoods
        TextBox39.Text = FW.PortofLoading
        TextBox40.Text = FW.PortofDischarge
        ComboBox3.Text = FW.StorageBegin
        ComboBox4.Text = FW.StorageEnd
        ComboBox2.Text = FW.DemurrageBegin
        ComboBox1.Text = FW.DemurrageEnd
        TextBox41.Text = FW.CBM
        TextBox42.Text = FW.EntryNo
        ComboBox5.Text = FW.TimeSendDate
        TextBox45.Text = FW.TimeSendTime
        TextBox43.Text = FW.Selectivity
        ComboBox6.Text = FW.FinalAssessDate
        TextBox46.Text = FW.FinalAssessTime
        If FW.Payment = "1" Then
            CheckBox12.Checked = True
        End If

        ComboBox7.Text = FW.PaymentTimeDate
        TextBox47.Text = FW.PaymentTime
        TextBox44.Text = FW.CUDVAT
    End Sub

    Private Sub ComboBox5_ValueChanged(sender As Object, e As EventArgs) Handles ComboBox5.ValueChanged
        TextBox45.Text = TimeOfDay.ToString("hh:mm:ss")
    End Sub

    Private Sub ComboBox6_ValueChanged(sender As Object, e As EventArgs) Handles ComboBox6.ValueChanged
        TextBox46.Text = TimeOfDay.ToString("hh:mm:ss")
    End Sub

    Private Sub ComboBox7_ValueChanged(sender As Object, e As EventArgs) Handles ComboBox7.ValueChanged
        TextBox47.Text = TimeOfDay.ToString("hh:mm:ss")
    End Sub
End Class