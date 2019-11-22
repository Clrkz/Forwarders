Option Explicit On
Imports System.Data
Imports System.Data.OleDb
Imports ADODB
Imports System.IO
Imports System.Data.SqlClient

Module FW
    Public count As Int16
    Public gs_Conn As String = "FILE NAME=" & App_Path() & "\FW.udl"
    Public gs_User As String
    'get all search data from Details Tab
    Public FileNo,
Customer,
Consignee,
SalesPerson,
Description,
ControlNo,
Status,
DateEncoded,
CAS,
ReceivedDate,
ReceivedBy,
ExpirationDate,
ApprovalDate,
ETA,
EDA,
Broker,
SupplierName,
SupplierAddress,
SupplierInfo,
ShippingLine,
Pier,
RegNo,
Vessel,
BillOfLading,
Forwarder1,
Forwarder2,
ContactPerson,
Warehouse,
TelNos,
FAX,
ContainerSize,
ContainerQty,
ContainerDescription,
TotalContainer,
UOM,
ContainerDeposit,
TotalRefund,
PaymentType,
RemoveStatus,
Regular,
Priority,
LackOfDoc,
AirWayBill,
SelfFunded,
LC,
FCL,
LCL,
Manifest,
Telex,
OBL,
LCDate,
LCBank As String

    Public CustomInfoFileNo,
OfficeCode,
CECode,
CountryofOrigin,
TermsofDelievery,
Currency,
ExchangeRate,
TotalCustomsValue,
PickupLocation,
LocationofGoods,
PortofLoading,
PortofDischarge,
StorageBegin,
StorageEnd,
DemurrageBegin,
DemurrageEnd,
CBM,
EntryNo,
TimeSendDate,
TimeSendTime,
Selectivity,
FinalAssessDate,
FinalAssessTime,
Payment,
PaymentTimeDate,
PaymentTime,
CUDVAT As String

    Public copFileNo,
CPNo,
copConsignee,
Manufacturer,
Series,
copClass,
Color,
YearModel,
EngineNo,
SerialNo,
EngineDisplacement,
Examiner,
DateofDelivery,
RecievedBy,
RecievedDate,
IssuedDate As String



    Public Function App_Path() As String
        App_Path = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName
    End Function


    Public Sub InsertDetails()
        Dim deleteStatus As Integer = 0
        Dim payment, regular, priority, lod, awb, sf, lc, fcl, lcl, manifest, telex, obl As String

        If Details.CheckBox1.Checked Then
            regular = "1"
        Else
            regular = "0"
        End If

        If Details.CheckBox2.Checked Then
            priority = "1"
        Else
            priority = "0"
        End If


        If Details.CheckBox3.Checked Then
            lod = "1"
        Else
            lod = "0"
        End If

        If Details.CheckBox4.Checked Then
            awb = "1"
        Else
            awb = "0"
        End If

        If Details.CheckBox5.Checked Then
            sf = "1"
        Else
            sf = "0"
        End If

        If Details.CheckBox11.Checked Then
            lc = "1"
        Else
            lc = "0"
        End If

        If Details.CheckBox6.Checked Then
            fcl = "1"
        Else
            fcl = "0"
        End If

        If Details.CheckBox7.Checked Then
            lcl = "1"
        Else
            lcl = "0"
        End If

        If Details.CheckBox8.Checked Then
            manifest = "1"
        Else
            manifest = "0"
        End If

        If Details.CheckBox9.Checked Then
            telex = "1"
        Else
            telex = "0"
        End If

        If Details.CheckBox9.Checked Then
            telex = "1"
        Else
            telex = "0"
        End If


        If Details.CheckBox10.Checked Then
            obl = "1"
        Else
            obl = "0"
        End If



        If Details.RadioButton1.Checked Then
            payment = "Cash"
        End If

        If Details.RadioButton2.Checked Then
            payment = "Check"
        End If

        mdl.ds = New DataSet
        mdl.adapter = New SqlDataAdapter("INSERT INTO Details (
FileNo,
Customer,
Consignee,
SalesPerson,
Description,
ControlNo,
Status, 
CAS,
ReceivedDate,
ReceivedBy,
ExpirationDate,
ApprovalDate,
ETA,
EDA,
Broker,
SupplierName,
SupplierAddress,
SupplierInfo,
ShippingLine,
Pier,
RegNo,
Vessel,
BillOfLading,
Forwarder1,
Forwarder2,
ContactPerson,
Warehouse,
TelNos,
FAX,
ContainerSize,
ContainerQty,
ContainerDescription,
TotalContainer,
UOM,
ContainerDeposit,
TotalRefund,
PaymentType,
RemoveStatus,
Regular,
Priority,
LackOfDoc,
AirWayBill,
SelfFunded,
LC,
FCL,
LCL,
Manifest,
Telex,
OBL,
LCDate,
LCBank,
DateEncoded
) 
VALUES (
'" & Details.txtFileNo.Text.Trim & "' ,
'" & Details.txtCustomer.Text.Trim & "' , 
'" & Details.txtCosignee.Text.Trim & "' , 
'" & Details.txtSalesPerson.Text.Trim & "' , 
'" & Details.txtDescription.Text.Trim & "' , 
'" & Details.txtCodeNumber.Text.Trim & "' , 
'" & Details.cboStatus.Text & "' ,  
'" & Details.TextBox1.Text.Trim & "' ,
'" & Details.TextBox2.Text.Trim & "' , 
'" & Details.TextBox3.Text.Trim & "' , 
'" & Details.TextBox4.Text.Trim & "' , 
'" & Details.TextBox5.Text.Trim & "' , 
'" & Details.txtETA.Text.Trim & "' , 
'" & Details.txtEDA.Text.Trim & "' , 
'" & Details.txtBroker.Text.Trim & "' , 
'" & Details.TextBox6.Text.Trim & "' , 
'" & Details.TextBox7.Text.Trim & "' , 
'" & Details.TextBox8.Text.Trim & "' , 
'" & Details.TextBox9.Text.Trim & "' , 
'" & Details.TextBox10.Text.Trim & "' , 
'" & Details.TextBox11.Text.Trim & "' , 
'" & Details.txtVessel.Text.Trim & "' , 
'" & Details.TextBox19.Text.Trim & "' , 
'" & Details.TextBox14.Text.Trim & "' , 
'" & Details.TextBox15.Text.Trim & "' , 
'" & Details.TextBox16.Text.Trim & "' , 
'" & Details.TextBox17.Text.Trim & "' , 
'" & Details.TextBox18.Text.Trim & "' , 
'" & Details.TextBox20.Text.Trim & "' , 
'" & Details.TextBox21.Text.Trim & "' , 
'" & Details.TextBox22.Text.Trim & "' , 
'" & Details.TextBox23.Text.Trim & "' , 
'" & Details.TextBox24.Text.Trim & "' , 
'" & Details.TextBox25.Text.Trim & "' , 
'" & Details.TextBox26.Text.Trim & "' , 
'" & Details.TextBox27.Text.Trim & "' , 
'" & payment & "' , 
'" & deleteStatus & "' , 
'" & regular & "', 
'" & priority & "', 
'" & lod & "', 
'" & awb & "', 
'" & sf & "', 
'" & lc & "', 
'" & fcl & "', 
'" & lcl & "', 
'" & manifest & "', 
'" & telex & "', 
'" & obl & "', 
'" & Details.TextBox13.Text.Trim & "', 
'" & Details.TextBox12.Text.Trim & "' ,
CURRENT_TIMESTAMP
)", mdl.conn)
        mdl.adapter.Fill(mdl.ds, "Details")
        Details.ClearDetails()
        MessageBox.Show("Customer information successfully added.")
    End Sub

    Public Sub FilterData(valueToSearch As String)
        Dim Dataset As New DataSet
        Dim DataAdapter As New OleDbDataAdapter
        Dim rs As New ADODB.Recordset
        rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rs.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rs.LockType = ADODB.LockTypeEnum.adLockBatchOptimistic
        rs.Open("Select FileNo,Customer  From Details Where FileNo LIKE '%" + valueToSearch.Trim + "%'", gs_Conn, 2)

        DataAdapter.Fill(Dataset, rs, "Details")
        Details.DataGridView1.DataSource = Dataset.Tables(0)
        Details.DataGridView1.ReadOnly = True
        Details.DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Details.DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Public Sub GetAllDataDetails(valueToSearch As String)
        Dim Dataset As New DataSet
        Dim DataAdapter As New OleDbDataAdapter
        Dim rs As New ADODB.Recordset
        rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rs.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rs.LockType = ADODB.LockTypeEnum.adLockBatchOptimistic
        rs.Open("Select FileNo,
Customer,
Consignee,
SalesPerson,
Description,
ControlNo,
Status, 
DateEncoded,
CAS,
ReceivedDate,
ReceivedBy,
ExpirationDate,
ApprovalDate,
ETA,
EDA,
Broker,
SupplierName,
SupplierAddress,
SupplierInfo,
ShippingLine,
Pier,
RegNo,
Vessel,
BillOfLading,
Forwarder1,
Forwarder2,
ContactPerson,
Warehouse,
TelNos,
FAX,
ContainerSize,
ContainerQty,
ContainerDescription,
TotalContainer,
UOM,
ContainerDeposit,
TotalRefund,
PaymentType,
RemoveStatus,
Regular,
Priority,
LackOfDoc,
AirWayBill,
SelfFunded,
LC,
FCL,
LCL,
Manifest,
Telex,
OBL,
LCDate,
LCBank  From Details Where FileNo = '" + valueToSearch.Trim + "'", gs_Conn, 2)
        If rs.RecordCount = 0 Then
            MessageBox.Show("No record")
        Else
            FileNo = rs.Fields(0).Value.ToString
            Customer = rs.Fields(1).Value.ToString
            Consignee = rs.Fields(2).Value.ToString
            SalesPerson = rs.Fields(3).Value.ToString
            Description = rs.Fields(4).Value.ToString
            ControlNo = rs.Fields(5).Value.ToString
            Status = rs.Fields(6).Value.ToString
            DateEncoded = rs.Fields(7).Value.ToString
            CAS = rs.Fields(8).Value.ToString
            ReceivedDate = rs.Fields(9).Value.ToString
            ReceivedBy = rs.Fields(10).Value.ToString
            ExpirationDate = rs.Fields(11).Value.ToString
            ApprovalDate = rs.Fields(12).Value.ToString
            ETA = rs.Fields(13).Value.ToString
            EDA = rs.Fields(14).Value.ToString
            Broker = rs.Fields(15).Value.ToString
            SupplierName = rs.Fields(16).Value.ToString
            SupplierAddress = rs.Fields(17).Value.ToString
            SupplierInfo = rs.Fields(18).Value.ToString
            ShippingLine = rs.Fields(19).Value.ToString
            Pier = rs.Fields(20).Value.ToString
            RegNo = rs.Fields(21).Value.ToString
            Vessel = rs.Fields(22).Value.ToString
            BillOfLading = rs.Fields(23).Value.ToString
            Forwarder1 = rs.Fields(24).Value.ToString
            Forwarder2 = rs.Fields(25).Value.ToString
            ContactPerson = rs.Fields(26).Value.ToString
            Warehouse = rs.Fields(27).Value.ToString
            TelNos = rs.Fields(28).Value.ToString
            FAX = rs.Fields(29).Value.ToString
            ContainerSize = rs.Fields(30).Value.ToString
            ContainerQty = rs.Fields(31).Value.ToString
            ContainerDescription = rs.Fields(32).Value.ToString
            TotalContainer = rs.Fields(33).Value.ToString
            UOM = rs.Fields(34).Value.ToString
            ContainerDeposit = rs.Fields(35).Value.ToString
            TotalRefund = rs.Fields(36).Value.ToString
            PaymentType = rs.Fields(37).Value.ToString
            RemoveStatus = rs.Fields(38).Value.ToString
            Regular = rs.Fields(39).Value.ToString
            Priority = rs.Fields(40).Value.ToString
            LackOfDoc = rs.Fields(41).Value.ToString
            AirWayBill = rs.Fields(42).Value.ToString
            SelfFunded = rs.Fields(43).Value.ToString
            LC = rs.Fields(44).Value.ToString
            FCL = rs.Fields(45).Value.ToString
            LCL = rs.Fields(46).Value.ToString
            Manifest = rs.Fields(47).Value.ToString
            Telex = rs.Fields(48).Value.ToString
            OBL = rs.Fields(49).Value.ToString
            LCDate = rs.Fields(50).Value.ToString
            LCBank = rs.Fields(51).Value.ToString




            '  MessageBox.Show(Customer)
            DataAdapter.Fill(Dataset, rs, "Details")
        End If
        '   'Details.DataGridView1.DataSource = Dataset.Tables(0)
        '    Details.DataGridView1.ReadOnly = True
        '   Details.DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ''    Details.DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        ' Details.txtCosignee.Text = CStr(rs.Rows(2)("Consignee"))
        ' Details.txtCosignee.DataBindings.Add("Text", rs, "Consignee")
        'Details.txtCosignee.Text = CStr(rs.Rows(0)("Consignee"))
    End Sub



    Public Sub GetAllCustomInfo(valueToSearch As String)
        Dim Dataset As New DataSet
        Dim DataAdapter As New OleDbDataAdapter
        Dim rs As New ADODB.Recordset
        rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rs.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rs.LockType = ADODB.LockTypeEnum.adLockBatchOptimistic
        rs.Open("Select FileNo,
OfficeCode,
CECode,
CountryofOrigin,
TermsofDelievery,
Currency,
ExchangeRate,
TotalCustomsValue,
PickupLocation,
LocationofGoods,
PortofLoading,
PortofDischarge,
StorageBegin,
StorageEnd,
DemurrageBegin,
DemurrageEnd,
CBM,
EntryNo,
TimeSendDate,
TimeSendTime,
Selectivity,
FinalAssessDate,
FinalAssessTime,
Payment,
PaymentTimeDate,
PaymentTime,
CUDVAT From CustomInfo Where FileNo = '" + valueToSearch.Trim + "'", gs_Conn, 2)
        If rs.RecordCount = 0 Then
            ' MessageBox.Show("No record")
        Else
            CustomInfoFileNo = rs.Fields(0).Value.ToString
            OfficeCode = rs.Fields(1).Value.ToString
            CECode = rs.Fields(2).Value.ToString
            CountryofOrigin = rs.Fields(3).Value.ToString
            TermsofDelievery = rs.Fields(4).Value.ToString
            Currency = rs.Fields(5).Value.ToString
            ExchangeRate = rs.Fields(6).Value.ToString
            TotalCustomsValue = rs.Fields(7).Value.ToString
            PickupLocation = rs.Fields(8).Value.ToString
            LocationofGoods = rs.Fields(9).Value.ToString
            PortofLoading = rs.Fields(10).Value.ToString
            PortofDischarge = rs.Fields(11).Value.ToString
            StorageBegin = rs.Fields(12).Value.ToString
            StorageEnd = rs.Fields(13).Value.ToString
            DemurrageBegin = rs.Fields(14).Value.ToString
            DemurrageEnd = rs.Fields(15).Value.ToString
            CBM = rs.Fields(16).Value.ToString
            EntryNo = rs.Fields(17).Value.ToString
            TimeSendDate = rs.Fields(18).Value.ToString
            TimeSendTime = rs.Fields(19).Value.ToString
            Selectivity = rs.Fields(20).Value.ToString
            FinalAssessDate = rs.Fields(21).Value.ToString
            FinalAssessTime = rs.Fields(22).Value.ToString
            Payment = rs.Fields(23).Value.ToString
            PaymentTimeDate = rs.Fields(24).Value.ToString
            PaymentTime = rs.Fields(25).Value.ToString
            CUDVAT = rs.Fields(26).Value.ToString
            DataAdapter.Fill(Dataset, rs, "CustomInfo")
        End If
    End Sub

    Sub CountAdvExpense()
        mdl.ds = New DataSet
        mdl.adapter = New SqlDataAdapter("SELECT * FROM tempAdvExpenses", mdl.conn)

        count = mdl.adapter.Fill(mdl.ds, "tempAdvExpenses")
    End Sub

    Public Sub InsertTempAdvExpense()
        Dim particular, amount, approvedamount, liquidated As String

        particular = Advances.textParticular.Text.Trim
        amount = Advances.txtAmount.Text.Trim
        approvedamount = Advances.txtApprovedAmount.Text.Trim
        liquidated = Advances.txtLiquidated.Text.Trim

        CountAdvExpense()

        mdl.ds = New DataSet
        mdl.adapter = New SqlDataAdapter("INSERT INTO tempAdvExpenses(
ExpenseID,
Particular,
Amount,
ApprovedAmount,
Liquidated) VALUES(
'" & (count + 1) & "', 
'" & particular & "', 
'" & amount & "', 
'" & approvedamount & "', 
'" & liquidated & "')", mdl.conn)

        mdl.adapter.Fill(mdl.ds, "tempAdvExpenses")

        Advances.textParticular.Text = ""
        Advances.txtAmount.Text = ""
        Advances.txtApprovedAmount.Text = ""
        Advances.txtLiquidated.Text = ""

        updateDataGrid()
    End Sub

    Public Sub FilterData1(valueToSearch As String)
        Dim Dataset As New DataSet
        Dim DataAdapter As New OleDbDataAdapter
        Dim rs As New ADODB.Recordset
        rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rs.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rs.LockType = ADODB.LockTypeEnum.adLockBatchOptimistic
        rs.Open("SELECT ExpenseID, Particular, Amount, ApprovedAmount, Liquidated FROM tempAdvExpenses", gs_Conn, 3)

        DataAdapter.Fill(Dataset, rs, "AdvExpenses")
        Advances.dgvAdvExpenses.DataSource = Dataset.Tables(0)
        Advances.dgvAdvExpenses.ReadOnly = True
        Advances.dgvAdvExpenses.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Advances.dgvAdvExpenses.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Advances.dgvAdvExpenses.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Advances.dgvAdvExpenses.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Advances.dgvAdvExpenses.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Sub updateDataGrid()
        Advances.dgvAdvExpenses.RowHeadersVisible = False
        Advances.dgvAdvExpenses.ReadOnly = True
        Advances.dgvAdvExpenses.AllowUserToResizeRows = False
        FilterData1("")
    End Sub

    Public Sub InsertCustomInfo()
        Dim payment As String
        If CustomInfo.CheckBox12.Checked Then
            payment = "1"
        Else
            payment = "0"
        End If

        mdl.ds = New DataSet
        mdl.adapter = New SqlDataAdapter("INSERT INTO CustomInfo (
FileNo,
OfficeCode,
CECode,
CountryofOrigin,
TermsofDelievery,
Currency,
ExchangeRate,
TotalCustomsValue,
PickupLocation,
LocationofGoods,
PortofLoading,
PortofDischarge,
StorageBegin,
StorageEnd,
DemurrageBegin,
DemurrageEnd,
CBM,
EntryNo,
TimeSendDate,
TimeSendTime,
Selectivity,
FinalAssessDate,
FinalAssessTime,
Payment,
PaymentTimeDate,
PaymentTime,
CUDVAT
) 
VALUES (
'" & FW.FileNo & "' ,
'" & CustomInfo.TextBox30.Text.Trim & "' , 
'" & CustomInfo.TextBox31.Text.Trim & "' , 
'" & CustomInfo.TextBox32.Text.Trim & "' , 
'" & CustomInfo.TextBox33.Text.Trim & "' , 
'" & CustomInfo.TextBox34.Text.Trim & "' , 
'" & CustomInfo.TextBox35.Text.Trim & "' ,  
'" & CustomInfo.TextBox36.Text.Trim & "' ,
'" & CustomInfo.TextBox37.Text.Trim & "' , 
'" & CustomInfo.TextBox38.Text.Trim & "' , 
'" & CustomInfo.TextBox39.Text.Trim & "' , 
'" & CustomInfo.TextBox40.Text.Trim & "' , 
'" & CustomInfo.ComboBox3.Text & "' , 
'" & CustomInfo.ComboBox4.Text & "' , 
'" & CustomInfo.ComboBox2.Text & "' , 
'" & CustomInfo.ComboBox1.Text & "' , 
'" & CustomInfo.TextBox41.Text.Trim & "' , 
'" & CustomInfo.TextBox42.Text.Trim & "' , 
'" & CustomInfo.ComboBox5.Text & "' , 
'" & CustomInfo.TextBox45.Text.Trim & "' , 
'" & CustomInfo.TextBox43.Text.Trim & "' , 
'" & CustomInfo.ComboBox6.Text & "' , 
'" & CustomInfo.TextBox46.Text.Trim & "' , 
'" & payment & "' , 
'" & CustomInfo.ComboBox7.Text & "' , 
'" & CustomInfo.TextBox47.Text.Trim & "' , 
'" & CustomInfo.TextBox44.Text.Trim & "'  
)", mdl.conn)
        mdl.adapter.Fill(mdl.ds, "CustomInfo")
        MessageBox.Show("Custom information successfully added.")
    End Sub

    Sub InsertCertificateOfPayment()
        Dim payment As String
        If CustomInfo.CheckBox12.Checked Then
            payment = "1"
        Else
            payment = "0"
        End If

        mdl.ds = New DataSet
        mdl.adapter = New SqlDataAdapter("INSERT INTO CertificateOfPayment (
FileNo,
CPNo,
Consignee,
Manufacturer,
Series,
Class,
Color,
YearModel,
EngineNo,
SerialNo,
EngineDisplacement,
Examiner,
DateofDelivery,
RecievedBy,
RecievedDate,
IssuedDate
) 
VALUES (
'" & FW.FileNo & "' ,
'" & CertificateOfPayment.TextBox48.Text.Trim & "' , 
'" & CertificateOfPayment.TextBox49.Text.Trim & "' , 
'" & CertificateOfPayment.TextBox50.Text.Trim & "' , 
'" & CertificateOfPayment.TextBox52.Text.Trim & "' , 
'" & CertificateOfPayment.TextBox53.Text.Trim & "' , 
'" & CertificateOfPayment.TextBox54.Text.Trim & "' ,  
'" & CertificateOfPayment.TextBox55.Text.Trim & "' ,
'" & CertificateOfPayment.TextBox56.Text.Trim & "' , 
'" & CertificateOfPayment.TextBox57.Text.Trim & "' , 
'" & CertificateOfPayment.TextBox58.Text.Trim & "' , 
'" & CertificateOfPayment.TextBox59.Text.Trim & "' ,  
'" & CertificateOfPayment.TextBox62.Text.Trim & "' , 
'" & CertificateOfPayment.TextBox61.Text.Trim & "' ,  
'" & CertificateOfPayment.TextBox60.Text.Trim & "' , 
'" & CertificateOfPayment.TextBox51.Text.Trim & "' 
)", mdl.conn)
        mdl.adapter.Fill(mdl.ds, "CertificateOfPayment")
        MessageBox.Show("Certificate of payment successfully added.")
    End Sub

    Public Sub GetAllCertificateOfpayment(valueToSearch As String)
        Dim Dataset As New DataSet
        Dim DataAdapter As New OleDbDataAdapter
        Dim rs As New ADODB.Recordset
        rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rs.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rs.LockType = ADODB.LockTypeEnum.adLockBatchOptimistic
        rs.Open("Select FileNo,
CPNo,
Consignee,
Manufacturer,
Series,
Class,
Color,
YearModel,
EngineNo,
SerialNo,
EngineDisplacement,
Examiner,
DateofDelivery,
RecievedBy,
RecievedDate,
IssuedDate From CertificateOfPayment Where FileNo = '" + valueToSearch.Trim + "'", gs_Conn, 2)
        If rs.RecordCount = 0 Then
            ' MessageBox.Show("No record")
        Else
            copFileNo = rs.Fields(0).Value.ToString
            CPNo = rs.Fields(1).Value.ToString
            copConsignee = rs.Fields(2).Value.ToString
            Manufacturer = rs.Fields(3).Value.ToString
            Series = rs.Fields(4).Value.ToString
            copClass = rs.Fields(5).Value.ToString
            Color = rs.Fields(6).Value.ToString
            YearModel = rs.Fields(7).Value.ToString
            EngineNo = rs.Fields(8).Value.ToString
            SerialNo = rs.Fields(9).Value.ToString
            EngineDisplacement = rs.Fields(10).Value.ToString
            Examiner = rs.Fields(11).Value.ToString
            DateofDelivery = rs.Fields(12).Value.ToString
            RecievedBy = rs.Fields(13).Value.ToString
            RecievedDate = rs.Fields(14).Value.ToString
            IssuedDate = rs.Fields(15).Value.ToString
        End If
    End Sub

    Public Sub InsertAdvances()
        Dim receipted, refno, employee, fileno, customer, consignee, remarks, status, shipmentcode, transdate, cano, port As String

        If Advances.chkReceipted.Checked Then
            receipted = "1"
        Else
            receipted = "0"
        End If

        refno = Advances.txtRefNo.Text.Trim
        employee = Advances.txtEmployee.Text.Trim
        fileno = Advances.txtFileNo.Text.Trim
        customer = Advances.txtCustomer.Text.Trim
        consignee = Advances.txtConsignee.Text.Trim
        remarks = Advances.txtRemarks.Text.Trim
        status = Advances.cboStatus.Text.Trim
        shipmentcode = Advances.txtShipmentCode.Text.Trim
        transdate = Advances.dtpTransDate.Text.Trim
        cano = Advances.txtCANo.Text.Trim
        port = Advances.txtPort.Text.Trim

        mdl.ds = New DataSet
        mdl.adapter = New SqlDataAdapter("INSERT INTO Advances1(
RefNo, 
Employee, 
FileNo, 
Customer, 
Consignee, 
Remarks, 
Status, 
ShipmentCode, 
TranDate, 
CANo, 
Port, 
Receipted) VALUES(
'" & refno & "', 
'" & employee & "', 
'" & fileno & "', 
'" & customer & "', 
'" & consignee & "',
'" & remarks & "', 
'" & status & "', 
'" & shipmentcode & "', 
'" & transdate & "', 
'" & cano & "', 
'" & port & "', 
'" & receipted & "')", mdl.conn)
        mdl.adapter.Fill(mdl.ds, "Advances1")

        Dim note, encodedby, notedby, approvedby, comments As String

        note = Advances.txtNote.Text.Trim
        encodedby = Advances.txtEncodedBy.Text.Trim
        notedby = Advances.txtNotedBy.Text.Trim
        approvedby = Advances.txtApprovedBy.Text.Trim
        comments = Advances.txtComments.Text.Trim

        mdl.ds = New DataSet
        mdl.adapter = New SqlDataAdapter("INSERT INTO Advances3(
FileNo, 
Note, 
EncodedBy, 
NotedBy, 
ApprovedBy, 
Comment) VALUES(
'" & fileno & "', 
'" & note & "', 
'" & encodedby & "', 
'" & notedby & "', 
'" & approvedby & "', 
'" & comments & "')", mdl.conn)
        mdl.adapter.Fill(mdl.ds, "Advances3")

        mdl.ds = New DataSet
        mdl.adapter = New SqlDataAdapter("INSERT INTO Advances2 (
ExpenseID, 
Particular, 
Amount,
ApprovedAmount, 
Liquidated, 
FileNo) SELECT
ExpenseID, 
Particular, 
Amount, 
ApprovedAmount, 
Liquidated,'" & fileno & "' FROM tempAdvExpenses 
", mdl.conn)

        mdl.adapter.Fill(mdl.ds, "Advances2")
        MessageBox.Show("Advances successfully added.")

        truncate1()
    End Sub
    Public Sub truncate1()
        Dim query As String = "TRUNCATE TABLE tempAdvExpenses"

        Using conn As New SqlClient.SqlConnection(mdl.connectionString)
            Dim cmd As New SqlClient.SqlCommand(query, conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using
    End Sub

    Public Sub Liquid()
        Dim Dataset As New DataSet
        Dim DataAdapter As New OleDbDataAdapter
        Dim rs As New ADODB.Recordset

        Dim userid As String, password As String, firstname As String, middlename As String, lastname As String
        rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rs.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rs.LockType = ADODB.LockTypeEnum.adLockBatchOptimistic

        rs.Open("SELECT userid, password, firstname, middlename, lastname FROM TempUsers", gs_Conn, 3)
        userid = rs.Fields("userid").Value
        password = Security.GetHash(rs.Fields("password").Value)
        firstname = rs.Fields("firstname").Value
        middlename = rs.Fields("middlename").Value
        lastname = rs.Fields("lastname").Value
    End Sub
End Module
