Imports System.Data.SqlClient

Public Class Details

    Public Sub Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = True


        '  Dim table As DataTable = New DataTable("TABLE")
        ' Declare variables for DataColumn and DataRow objects. 
        '   Dim column As DataColumn

        '    column = New DataColumn()
        '    column.DataType = Type.GetType("System.String")
        '    column.ColumnName = "Col 1"
        ' Add the column to the table.
        '   table.Columns.Add(column)

        '  column = New DataColumn()
        '  column.DataType = Type.GetType("System.String")
        '  column.ColumnName = "Col 2"
        ' Add the column to the table.
        '  table.Columns.Add(column)

        '  table.Rows.Add("Row 1", "Row 1")
        ' table.Rows.Add("Row 2", "Row 2")
        'table.Rows.Add("Row 3", "Row 3")

        '   DataGridView1.DataSource = table

        '   With DataGridView1

        ' Set property values appropriate for read-only display and  
        ' limited interactivity. 
        ' .AllowUserToAddRows = False
        '.AllowUserToDeleteRows = False
        '.AllowUserToOrderColumns = True
        '.ReadOnly = True
        ''.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        '.MultiSelect = False
        '.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        '.AllowUserToResizeColumns = False
        '.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        '.AllowUserToResizeRows = False
        '.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        ' Special Appearance
        ' '''   .RowHeadersVisible = False
        '   .Font = New Font("CourierNew", 10)
        '
        '     .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        '
        '.Columns("Col 1").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ' .Columns("Col 1").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '
        '.Columns("Col 2").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        '.Columns("Col 2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'End With

        ' DataGridView1.Rows(0).Selected = True
        updateDB()
        cboStatus.SelectedIndex = 0
        txtDateEncoded.ReadOnly = True
        'Feature: Disable Object Here to Force user to click new
    End Sub
    Private Sub updateDB()
        Dim chk As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn
        chk.HeaderText = "OK"
        chk.Name = "Check"
        DataGridView2.Columns.Add(chk)
        DataGridView2.ColumnCount = 6
        DataGridView2.Columns(1).Name = "Container No"
        DataGridView2.Columns(2).Name = "NOP"
        DataGridView2.Columns(3).Name = "TOP"
        DataGridView2.Columns(4).Name = "Refund"
        DataGridView2.Columns(5).Name = "Size"
        DataGridView2.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView2.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView2.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView2.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView2.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView2.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView2.Columns(0).AutoSizeMode = vbYes
        DataGridView2.Columns(1).AutoSizeMode = vbYes
        DataGridView2.Columns(2).AutoSizeMode = vbYes
        DataGridView2.Columns(3).AutoSizeMode = vbYes
        DataGridView2.Columns(4).AutoSizeMode = vbYes
        DataGridView2.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Dim row As ArrayList = New ArrayList
        DataGridView2.Rows.Add(row.ToArray())
        row = New ArrayList
        DataGridView2.Rows.Add(row.ToArray())

        row = New ArrayList
        DataGridView2.Rows.Add(row.ToArray())

        row = New ArrayList
        DataGridView2.Rows.Add(row.ToArray())

        row = New ArrayList
        DataGridView2.Rows.Add(row.ToArray())


        DataGridView3.ColumnCount = 2
        DataGridView3.Columns(0).Name = "Count"
        DataGridView3.Columns(1).Name = "Size"
        DataGridView3.Columns(0).AutoSizeMode = vbYes
        DataGridView3.RowHeadersVisible = False
        DataGridView3.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        DataGridView3.Rows.Add(row.ToArray())
        row = New ArrayList
        DataGridView3.Rows.Add(row.ToArray())
        row = New ArrayList
        DataGridView3.Rows.Add(row.ToArray())
        row = New ArrayList
        DataGridView3.Rows.Add(row.ToArray())
        row = New ArrayList
        DataGridView3.Rows.Add(row.ToArray())


    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView2.CellFormatting
        DataGridView2.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)

    End Sub

    Private Sub txtFileNo_TextChanged(sender As Object, e As EventArgs) Handles txtFileNo.TextChanged

    End Sub

    Private Sub txtDescription_TextChanged(sender As Object, e As EventArgs) Handles txtDescription.TextChanged

    End Sub



    Public Sub getData()
        MessageBox.Show(txtFileNo.Text)
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = DataGridView1.Rows(e.RowIndex)
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index
            If Not String.IsNullOrEmpty(DataGridView1.Item(0, i).Value.ToString) Then
                ClearDetails()
                txtFileNo.Text = DataGridView1.Item(0, i).Value
                txtCustomer.Text = DataGridView1.Item(1, i).Value
                FileNo = DataGridView1.Item(0, i).Value
                Customer = DataGridView1.Item(1, i).Value
                FW.GetAllDataDetails(FileNo)

                populateToFields()
            Else
                txtFileNo.Text = ""
                txtCustomer.Text = ""
            End If
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
        txtETA.Text = FW.ETA
        txtEDA.Text = FW.EDA
        txtBroker.Text = FW.Broker
        TextBox6.Text = FW.SupplierName
        TextBox7.Text = FW.SupplierAddress
        TextBox8.Text = FW.SupplierInfo
        TextBox9.Text = FW.ShippingLine
        TextBox10.Text = FW.Pier
        TextBox11.Text = FW.RegNo
        txtVessel.Text = FW.Vessel
        TextBox19.Text = FW.BillOfLading
        TextBox14.Text = FW.Forwarder1
        TextBox15.Text = FW.Forwarder2
        TextBox16.Text = FW.ContactPerson
        TextBox17.Text = FW.Warehouse
        TextBox18.Text = FW.TelNos
        TextBox20.Text = FW.FAX
        TextBox21.Text = FW.ContainerSize
        TextBox22.Text = FW.ContainerQty
        TextBox23.Text = FW.ContainerDescription
        TextBox24.Text = FW.TotalContainer
        TextBox25.Text = FW.UOM
        TextBox26.Text = FW.ContainerDeposit
        TextBox27.Text = FW.TotalRefund

        If FW.PaymentType = "Cash" Then
            RadioButton1.Checked = True
        End If

        If FW.PaymentType = "Check" Then
            RadioButton2.Checked = True
        End If

        '.Text = FW.RemoveStatus
        If FW.Regular = "1" Then
            CheckBox1.Checked = True
        End If

        If FW.Priority = "1" Then
            CheckBox2.Checked = True
        End If

        If FW.LackOfDoc = "1" Then
            CheckBox3.Checked = True
        End If

        If FW.AirWayBill = "1" Then
            CheckBox4.Checked = True
        End If

        If FW.SelfFunded = "1" Then
            CheckBox5.Checked = True
        End If

        If FW.LC = "1" Then
            CheckBox11.Checked = True
        End If

        If FW.FCL = "1" Then
            CheckBox6.Checked = True
        End If

        If FW.LCL = "1" Then
            CheckBox7.Checked = True
        End If

        If FW.Manifest = "1" Then
            CheckBox8.Checked = True
        End If

        If FW.Telex = "1" Then
            CheckBox9.Checked = True
        End If

        If FW.OBL = "1" Then
            CheckBox10.Checked = True
        End If



        TextBox13.Text = FW.LCDate
        TextBox12.Text = FW.LCBank
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
        txtETA.Text = ""
        txtEDA.Text = ""
        txtBroker.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        txtVessel.Text = ""
        TextBox19.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
        TextBox17.Text = ""
        TextBox18.Text = ""
        TextBox20.Text = ""
        TextBox21.Text = ""
        TextBox22.Text = ""
        TextBox23.Text = ""
        TextBox24.Text = ""
        TextBox25.Text = ""
        TextBox26.Text = ""
        TextBox27.Text = ""
        TextBox13.Text = ""
        TextBox12.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox11.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
    End Sub


End Class