<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Advances
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtRefNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmployee = New System.Windows.Forms.TextBox()
        Me.txtFileNo = New System.Windows.Forms.TextBox()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.txtConsignee = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtShipmentCode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpTransDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCANo = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvAdvExpenses = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotalLiquidated = New System.Windows.Forms.TextBox()
        Me.txtTotalApprovedAmount = New System.Windows.Forms.TextBox()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.txtTotalAll = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtEncodedBy = New System.Windows.Forms.TextBox()
        Me.txtNotedBy = New System.Windows.Forms.TextBox()
        Me.txtApprovedBy = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txtLiquidated = New System.Windows.Forms.TextBox()
        Me.txtApprovedAmount = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.textParticular = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        CType(Me.dgvAdvExpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(78, 13)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(84, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Receipted"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtRefNo
        '
        Me.txtRefNo.Location = New System.Drawing.Point(78, 36)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(156, 20)
        Me.txtRefNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ref No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Employee"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(12, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "File No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Customer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Remarks"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Consignee"
        '
        'txtEmployee
        '
        Me.txtEmployee.Location = New System.Drawing.Point(78, 57)
        Me.txtEmployee.Name = "txtEmployee"
        Me.txtEmployee.Size = New System.Drawing.Size(156, 20)
        Me.txtEmployee.TabIndex = 8
        '
        'txtFileNo
        '
        Me.txtFileNo.Location = New System.Drawing.Point(78, 79)
        Me.txtFileNo.Name = "txtFileNo"
        Me.txtFileNo.Size = New System.Drawing.Size(156, 20)
        Me.txtFileNo.TabIndex = 9
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(78, 101)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(156, 20)
        Me.txtCustomer.TabIndex = 10
        '
        'txtConsignee
        '
        Me.txtConsignee.Location = New System.Drawing.Point(78, 123)
        Me.txtConsignee.Name = "txtConsignee"
        Me.txtConsignee.Size = New System.Drawing.Size(156, 20)
        Me.txtConsignee.TabIndex = 11
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(78, 144)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtRemarks.Size = New System.Drawing.Size(650, 53)
        Me.txtRemarks.TabIndex = 12
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(376, 35)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(121, 21)
        Me.cboStatus.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(333, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(240, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "ADMINISTRATOR SYSTEM,."
        '
        'txtShipmentCode
        '
        Me.txtShipmentCode.Location = New System.Drawing.Point(376, 79)
        Me.txtShipmentCode.Name = "txtShipmentCode"
        Me.txtShipmentCode.Size = New System.Drawing.Size(121, 20)
        Me.txtShipmentCode.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(291, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Shipment Code"
        '
        'dtpTransDate
        '
        Me.dtpTransDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTransDate.Location = New System.Drawing.Point(565, 36)
        Me.dtpTransDate.Name = "dtpTransDate"
        Me.dtpTransDate.Size = New System.Drawing.Size(83, 20)
        Me.dtpTransDate.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(503, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Trans Date"
        '
        'txtCANo
        '
        Me.txtCANo.Location = New System.Drawing.Point(565, 62)
        Me.txtCANo.Name = "txtCANo"
        Me.txtCANo.Size = New System.Drawing.Size(83, 20)
        Me.txtCANo.TabIndex = 20
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(565, 88)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(83, 20)
        Me.txtPort.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(518, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "CA No."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(533, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Port"
        '
        'dgvAdvExpenses
        '
        Me.dgvAdvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAdvExpenses.Location = New System.Drawing.Point(12, 203)
        Me.dgvAdvExpenses.Name = "dgvAdvExpenses"
        Me.dgvAdvExpenses.Size = New System.Drawing.Size(719, 195)
        Me.dgvAdvExpenses.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 404)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "&Details"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(378, 400)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Total"
        '
        'txtTotalLiquidated
        '
        Me.txtTotalLiquidated.Location = New System.Drawing.Point(613, 397)
        Me.txtTotalLiquidated.Name = "txtTotalLiquidated"
        Me.txtTotalLiquidated.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalLiquidated.TabIndex = 27
        '
        'txtTotalApprovedAmount
        '
        Me.txtTotalApprovedAmount.Location = New System.Drawing.Point(514, 397)
        Me.txtTotalApprovedAmount.Name = "txtTotalApprovedAmount"
        Me.txtTotalApprovedAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalApprovedAmount.TabIndex = 28
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Location = New System.Drawing.Point(415, 397)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalAmount.TabIndex = 29
        '
        'txtTotalAll
        '
        Me.txtTotalAll.Location = New System.Drawing.Point(135, 434)
        Me.txtTotalAll.Multiline = True
        Me.txtTotalAll.Name = "txtTotalAll"
        Me.txtTotalAll.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTotalAll.Size = New System.Drawing.Size(578, 53)
        Me.txtTotalAll.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(93, 455)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Total"
        '
        'txtEncodedBy
        '
        Me.txtEncodedBy.Location = New System.Drawing.Point(135, 493)
        Me.txtEncodedBy.Name = "txtEncodedBy"
        Me.txtEncodedBy.Size = New System.Drawing.Size(100, 20)
        Me.txtEncodedBy.TabIndex = 32
        '
        'txtNotedBy
        '
        Me.txtNotedBy.Location = New System.Drawing.Point(297, 493)
        Me.txtNotedBy.Name = "txtNotedBy"
        Me.txtNotedBy.Size = New System.Drawing.Size(100, 20)
        Me.txtNotedBy.TabIndex = 33
        '
        'txtApprovedBy
        '
        Me.txtApprovedBy.Location = New System.Drawing.Point(477, 493)
        Me.txtApprovedBy.Name = "txtApprovedBy"
        Me.txtApprovedBy.Size = New System.Drawing.Size(100, 20)
        Me.txtApprovedBy.TabIndex = 34
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(59, 496)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Encoded By"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(240, 496)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 13)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Noted By"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(403, 496)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 13)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Approved By"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(135, 519)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtComments.Size = New System.Drawing.Size(262, 53)
        Me.txtComments.TabIndex = 38
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(59, 534)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 26)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "Pending" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comments" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(817, 337)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 59
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'txtLiquidated
        '
        Me.txtLiquidated.Location = New System.Drawing.Point(840, 298)
        Me.txtLiquidated.Name = "txtLiquidated"
        Me.txtLiquidated.Size = New System.Drawing.Size(111, 20)
        Me.txtLiquidated.TabIndex = 58
        '
        'txtApprovedAmount
        '
        Me.txtApprovedAmount.Location = New System.Drawing.Point(840, 272)
        Me.txtApprovedAmount.Name = "txtApprovedAmount"
        Me.txtApprovedAmount.Size = New System.Drawing.Size(111, 20)
        Me.txtApprovedAmount.TabIndex = 57
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(840, 246)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(111, 20)
        Me.txtAmount.TabIndex = 56
        '
        'textParticular
        '
        Me.textParticular.Location = New System.Drawing.Point(840, 220)
        Me.textParticular.Name = "textParticular"
        Me.textParticular.Size = New System.Drawing.Size(111, 20)
        Me.textParticular.TabIndex = 55
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(778, 301)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 13)
        Me.Label23.TabIndex = 54
        Me.Label23.Text = "Liquidated"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(742, 275)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(92, 13)
        Me.Label22.TabIndex = 53
        Me.Label22.Text = "Approved Amount"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(791, 249)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 13)
        Me.Label21.TabIndex = 52
        Me.Label21.Text = "Amount"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(783, 223)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 13)
        Me.Label20.TabIndex = 51
        Me.Label20.Text = "Particular"
        '
        'Advances
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 595)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.txtLiquidated)
        Me.Controls.Add(Me.txtApprovedAmount)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.textParticular)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtApprovedBy)
        Me.Controls.Add(Me.txtNotedBy)
        Me.Controls.Add(Me.txtEncodedBy)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtTotalAll)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.txtTotalApprovedAmount)
        Me.Controls.Add(Me.txtTotalLiquidated)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvAdvExpenses)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.txtCANo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpTransDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtShipmentCode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtConsignee)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.txtFileNo)
        Me.Controls.Add(Me.txtEmployee)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRefNo)
        Me.Controls.Add(Me.CheckBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Advances"
        Me.Text = "Advances"
        CType(Me.dgvAdvExpenses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtRefNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmployee As TextBox
    Friend WithEvents txtFileNo As TextBox
    Friend WithEvents txtCustomer As TextBox
    Friend WithEvents txtConsignee As TextBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtShipmentCode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpTransDate As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCANo As TextBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents dgvAdvExpenses As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTotalLiquidated As TextBox
    Friend WithEvents txtTotalApprovedAmount As TextBox
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents txtTotalAll As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtEncodedBy As TextBox
    Friend WithEvents txtNotedBy As TextBox
    Friend WithEvents txtApprovedBy As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtComments As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents btnInsert As Button
    Friend WithEvents txtLiquidated As TextBox
    Friend WithEvents txtApprovedAmount As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents textParticular As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
End Class
