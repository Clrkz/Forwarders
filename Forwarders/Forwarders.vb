Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports ADODB
Imports System.IO
Imports System.Data.SqlClient
Imports System.Windows.Controls

Public Class MDIForwarders
    Dim WithEvents aTimer As New System.Windows.Forms.Timer
    Dim count As Int32
    Dim arr(7) As String
    Dim but(7) As String
    Private f As Form

    'panel.VerticalScroll.Visible = False Or panel.HorizontalScroll.Visible = False
    Private Sub aTimer_Tick(ByVal sender As Object,
                            ByVal e As System.EventArgs) Handles aTimer.Tick
        ToolStripStatusLabel2.Text = DateTime.Now.ToString("MMMM dd, yyyy h:mm:ss tt")
    End Sub

    Private Sub Form1_Shown(ByVal sender As Object,
                            ByVal e As System.EventArgs) Handles Me.Shown
        aTimer.Interval = 250
        aTimer.Start()
    End Sub

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        NewData()
        ' Create a new instance of the child form.
        ' Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        'ChildForm.MdiParent = Me 
        'm_ChildFormNumber += 1
        'ChildForm.Text = "Window " & m_ChildFormNumber 
        'ChildForm.Show()  
        'Details.newtran = True 
        'CallTreeView() 

    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIForwarders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FWDataSet.Screen' table. You can move, or remove it, as needed.
        Me.AutoScroll = True
        Panel1.AutoScroll = True
        mdl.ds = New DataSet
        mdl.adapter = New SqlDataAdapter("SELECT * FROM Button", mdl.conn)

        count = mdl.adapter.Fill(mdl.ds, "Button")

        setButtons()

        If arr(0).Equals("Disable") Then
            NewToolStripButton.Visible = False
        Else
            NewToolStripButton.Visible = True
        End If

        If arr(1).Equals("Disable") Then
            ToolStripButton1.Visible = False
        Else
            ToolStripButton1.Visible = True
        End If

        If arr(2).Equals("Disable") Then
            ToolStripButton2.Visible = False
        Else
            ToolStripButton2.Visible = True
        End If

        If arr(3).Equals("Disable") Then
            tsbMoveFirst.Visible = False
        Else
            tsbMoveFirst.Visible = True
        End If

        If arr(4).Equals("Disable") Then
            tsbMoveLast.Visible = False
        Else
            tsbMoveLast.Visible = True
        End If

        If arr(5).Equals("Disable") Then
            tsbNext.Visible = False
        Else
            tsbNext.Visible = True
        End If

        If arr(6).Equals("Disable") Then
            tsbPrevious.Visible = False
        Else
            tsbPrevious.Visible = True
        End If

        'ToolStripButton1.Visible = False

        ToolStripStatusLabel3.Text = ("USER: " + FW.gs_User)
        'If (gs_User = "forwarder") Then 'Make a form for Forwarder Welcome Screen
        f = New Blank
        'ElseIf (gs_User = "broker") Then 'Make a form for Broker Welcome Screen
        ' f = New Advances
        ' ElseIf (gs_User = "admin") Then 'Make a form for Admin Welcome Screen
        ' f = New MainFW
        ' End If
        f.TopLevel = False

        Me.Panel1.Controls.Add(f)

        f.Dock = DockStyle.Fill
        f.Show()
        Dim Forwarding As TreeNode
        Dim Brokerage As TreeNode
        'Dim UserSettings As TreeNode
        ' If (FW.gs_User = "admin") Then
        'Forwarding = New TreeNode("Forwarder")
        'TreeView1.Nodes.Add(Forwarding)
        'Forwarding.Nodes.Add("Details")
        'Forwarding.Nodes.Add("Custom Info")
        'Forwarding.Nodes.Add("History")
        'Forwarding.Nodes.Add("Certificate Of Payment")
        'Forwarding.Nodes.Add("Schedule Of Delivery")
        'Brokerage = New TreeNode("Brokerage")
        'TreeView1.Nodes.Add(Brokerage)
        'Brokerage.Nodes.Add("Advances")
        'Brokerage.Nodes.Add("Liquidation")
        'UserSettings = New TreeNode("User Settings")
        'TreeView1.Nodes.Add(UserSettings)
        'Me.TreeView1.Nodes(0).ExpandAll()
        'Me.TreeView1.Nodes(1).ExpandAll()
        BindTreeViewAdmin()

        'ElseIf (FW.gs_User = "forwarder") Then
        '    BindTreeViewForwarder()
        'Forwarding = New TreeNode("Forwarder")
        'TreeView1.Nodes.Add(Forwarding)
        'Forwarding.Nodes.Add("Details")
        'Forwarding.Nodes.Add("Custom Info")
        'Forwarding.Nodes.Add("History")
        'Forwarding.Nodes.Add("Certificate Of Payment")
        'Forwarding.Nodes.Add("Schedule Of Delivery")
        'Me.TreeView1.Nodes(0).ExpandAll()
        ' ElseIf (FW.gs_User = "broker") Then
        '     BindTreeViewBrokerage()
        'Brokerage = New TreeNode("Brokerage")
        'TreeView1.Nodes.Add(Brokerage)
        'Brokerage.Nodes.Add("Advances")
        'Brokerage.Nodes.Add("Liquidation")
        'Me.TreeView1.Nodes(0).ExpandAll()
        ' End If 
    End Sub


    Private Sub Form_Close(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        frmLogin.Show()

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

        CallTreeView()


    End Sub

    Sub CallTreeView()

        Me.Panel1.Controls.Remove(Advances)
        Me.Panel1.Controls.Remove(Liquidation)
        Me.Panel1.Controls.Remove(MainFW)
        Me.Panel1.Controls.Remove(Details)
        Me.Panel1.Controls.Remove(CustomInfo)
        Me.Panel1.Controls.Remove(History)
        Me.Panel1.Controls.Remove(CertificateOfPayment)
        Me.Panel1.Controls.Remove(ScheduleOfDelivery)
        Me.Panel1.Controls.Remove(UserPermissions)
        Me.Panel1.Controls.Remove(Billing)
        Panel1.Controls.Clear()

        Dim node As TreeNode
        node = TreeView1.SelectedNode
        Select Case node.Text
            Case "Advances"
                With Advances
                    .ControlBox = False
                    .MinimizeBox = False
                    .MaximizeBox = False
                    .ShowInTaskbar = False
                    .FormBorderStyle = FormBorderStyle.FixedToolWindow
                    .Text = ""
                    .Dock = DockStyle.Fill
                    .TopLevel = False
                    .FormBorderStyle = FormBorderStyle.FixedToolWindow
                    Panel1.Controls.Add(Advances)
                    .BringToFront()
                    .Show()
                End With

            Case "Liquidation"
                With Liquidation
                    .ControlBox = False
                    .MinimizeBox = False
                    .MaximizeBox = False
                    .ShowInTaskbar = False
                    .FormBorderStyle = FormBorderStyle.FixedToolWindow
                    .Text = ""
                    .Dock = DockStyle.Fill
                    .TopLevel = False
                    .FormBorderStyle = FormBorderStyle.FixedToolWindow
                    Panel1.Controls.Add(Liquidation)
                    .BringToFront()
                    .Show()
                End With

            Case "Main"
                With MainFW
                    .ControlBox = False
                    .MinimizeBox = False
                    .MaximizeBox = False
                    .ShowInTaskbar = False
                    .FormBorderStyle = FormBorderStyle.FixedToolWindow
                    .Text = ""
                    .Dock = DockStyle.Fill
                    .TopLevel = False
                    .FormBorderStyle = FormBorderStyle.FixedToolWindow
                    Panel1.Controls.Add(MainFW)
                    .BringToFront()
                    .Show()
                End With

            Case "Details"
                With Details
                    .ControlBox = False
                    .MinimizeBox = False
                    .MaximizeBox = False
                    .ShowInTaskbar = False
                    .FormBorderStyle = FormBorderStyle.FixedToolWindow
                    .Text = ""
                    .Dock = DockStyle.Fill
                    .TopLevel = False
                    .FormBorderStyle = FormBorderStyle.FixedToolWindow
                    Panel1.Controls.Add(Details)
                    .BringToFront()
                    .Show()
                End With

            Case "Custom Info"
                With CustomInfo
                    .ControlBox = False
                    .MinimizeBox = False
                    .MaximizeBox = False
                    .ShowInTaskbar = False
                    .FormBorderStyle = FormBorderStyle.FixedToolWindow
                    .Text = ""
                    .Dock = DockStyle.Fill
                    .TopLevel = False
                    .FormBorderStyle = FormBorderStyle.FixedToolWindow
                    Panel1.Controls.Add(CustomInfo)
                    .BringToFront()
                    .Show()
                End With

            Case "History"

                With History
                    .ControlBox = False
                    .MinimizeBox = False
                    .MaximizeBox = False
                    .ShowInTaskbar = False
                    .FormBorderStyle = FormBorderStyle.FixedToolWindow
                    .Text = ""
                    .Dock = DockStyle.Fill
                    .TopLevel = False
                    .FormBorderStyle = FormBorderStyle.FixedToolWindow
                    Panel1.Controls.Add(History)
                    .BringToFront()
                    .Show()
                End With
            Case "Certificate Of Payment"

                With CertificateOfPayment
                    .ControlBox = False
                    .MinimizeBox = False
                    .MaximizeBox = False
                    .ShowInTaskbar = False
                    .FormBorderStyle = FormBorderStyle.FixedToolWindow
                    .Text = ""
                    .Dock = DockStyle.Fill
                    .TopLevel = False
                    .FormBorderStyle = FormBorderStyle.FixedToolWindow
                    Panel1.Controls.Add(CertificateOfPayment)
                    .BringToFront()
                    .Show()
                End With

            Case "Schedule Of Delivery"



                With ScheduleOfDelivery
                    .ControlBox = False
                    .MinimizeBox = False
                    .MaximizeBox = False
                    .ShowInTaskbar = False
                    .FormBorderStyle = FormBorderStyle.FixedToolWindow
                    .Text = ""
                    .Dock = DockStyle.Fill
                    .TopLevel = False
                    .FormBorderStyle = FormBorderStyle.FixedToolWindow
                    Panel1.Controls.Add(ScheduleOfDelivery)
                    .BringToFront()
                    .Show()
                End With

            Case "User Settings"


                With UserPermissions
                    .ControlBox = False
                    .MinimizeBox = False
                    .MaximizeBox = False
                    .ShowInTaskbar = False
                    .FormBorderStyle = FormBorderStyle.FixedToolWindow
                    .Text = ""
                    .Dock = DockStyle.Fill
                    .TopLevel = False
                    .FormBorderStyle = FormBorderStyle.FixedToolWindow
                    Panel1.Controls.Add(UserPermissions)
                    .BringToFront()
                    .Show()
                End With


            Case "Billing"

                With Billing
                    .ControlBox = False
                    .MinimizeBox = False
                    .MaximizeBox = False
                    .ShowInTaskbar = False
                    .FormBorderStyle = FormBorderStyle.FixedToolWindow
                    .Text = ""
                    .Dock = DockStyle.Fill
                    .TopLevel = False
                    .FormBorderStyle = FormBorderStyle.FixedToolWindow
                    Panel1.Controls.Add(Billing)
                    .BringToFront()
                    .Show()
                End With


        End Select
    End Sub

    Sub BindTreeViewAdmin()
        Dim connetionString = mdl.connectionString
        Dim conn As System.Data.SqlClient.SqlConnection = New SqlClient.SqlConnection(connetionString)
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim pke(0) As DataColumn
        Dim i As Integer
        Dim j As Integer
        Try

            cmd.CommandText = "Select * From Users Inner Join UserScreen On Users.UserID=UserScreen.UserID Inner Join Screen on UserScreen.ScreenID=Screen.ScreenID Where UserScreen.UserID='" + gs_User + "'"
            da.SelectCommand = cmd
            da.SelectCommand.Connection = conn
            da.Fill(dt)
            pke(0) = dt.Columns("ScreenID")
            dt.PrimaryKey = pke
            conn.Close()


            TreeView1.Nodes.Add("Forwarders")
            TreeView1.Nodes.Add("Brokerage")
            TreeView1.Nodes.Add("Admin")
            For j = 0 To dt.Rows.Count - 1
                If (dt.Rows(j).Item("Status") = "Enable") Then
                    If (dt.Rows(j).Item("FormParent") = "Forwarders") Then
                        TreeView1.Nodes(i).Nodes.Add(dt.Rows(j).Item("NodeName"))
                        Me.TreeView1.Nodes(0).ExpandAll()
                    ElseIf (dt.Rows(j).Item("FormParent") = "Brokerage") Then
                        TreeView1.Nodes(i + 1).Nodes.Add(dt.Rows(j).Item("NodeName"))
                        Me.TreeView1.Nodes(1).ExpandAll()
                    ElseIf (dt.Rows(j).Item("FormParent") = "Admin") Then
                        TreeView1.Nodes(i + 2).Nodes.Add(dt.Rows(j).Item("NodeName"))
                        Me.TreeView1.Nodes(2).ExpandAll()
                    End If
                End If

            Next




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub BindTreeViewForwarder()
        Dim connetionString = mdl.connectionString
        Dim conn As System.Data.SqlClient.SqlConnection = New SqlClient.SqlConnection(connetionString)
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim pke(0) As DataColumn
        Dim i As Integer
        Dim j As Integer
        Try

            cmd.CommandText = "Select * from SCREEN "
            da.SelectCommand = cmd
            da.SelectCommand.Connection = conn
            da.Fill(dt)
            pke(0) = dt.Columns("ScreenID")
            dt.PrimaryKey = pke
            conn.Close()


            TreeView1.Nodes.Add("Forwarders")
            For j = 0 To dt.Rows.Count - 1

                TreeView1.Nodes(i).Nodes.Add(dt.Rows(j).Item("NodeName"))
            Next
            Me.TreeView1.Nodes(0).ExpandAll()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub BindTreeViewBrokerage()
        Dim connetionString = mdl.connectionString
        Dim conn As System.Data.SqlClient.SqlConnection = New SqlClient.SqlConnection(connetionString)
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim pke(0) As DataColumn
        Dim i As Integer
        Dim j As Integer
        Try

            cmd.CommandText = "Select * from SCREEN where Status='Active' AND FormParent='Brokerage'"
            da.SelectCommand = cmd
            da.SelectCommand.Connection = conn
            da.Fill(dt)
            pke(0) = dt.Columns("ScreenID")
            dt.PrimaryKey = pke
            conn.Close()


            TreeView1.Nodes.Add("Brokerage")
            For j = 0 To dt.Rows.Count - 1
                TreeView1.Nodes(i).Nodes.Add(dt.Rows(j).Item("NodeName"))
            Next




            Me.TreeView1.Nodes(0).ExpandAll()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub setButtons()
        Dim rs2 As New ADODB.Recordset
        Dim userid(count) As String, status(count) As String, buttonid(count) As String
        rs2.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rs2.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rs2.LockType = ADODB.LockTypeEnum.adLockBatchOptimistic

        'MsgBox("1")

        For I = 0 To count - 1
            rs2.Open("SELECT userid, buttonid, status FROM UserButton WHERE (buttonid = '" & I + 1 & "' AND userid = '" & mdl.log & "')", gs_Conn, 3)

            status(I) = rs2.Fields("status").Value
            buttonid(I) = rs2.Fields("buttonid").Value

            arr(I) = status(I)
            but(I) = buttonid(I)

            rs2.Close()
        Next I
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        SaveData()
    End Sub


    Sub SaveData()
        Dim node As TreeNode
        node = TreeView1.SelectedNode
        Select Case node.Text
            Case "Advances"
                FW.InsertAdvances()
            Case "Liquidation"

            Case "Main"

            Case "Details"
                FW.InsertDetails()
            Case "Custom Info"
                FW.InsertCustomInfo()
            Case "History"

            Case "Certificate Of Payment"
                FW.InsertCertificateOfPayment()
            Case "Schedule Of Delivery"

            Case "User Settings"

            Case "Billing"

        End Select
    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click


        Dim node As TreeNode
        node = TreeView1.SelectedNode
        Select Case node.Text
            Case "Advances"

            Case "Liquidation"

            Case "Main"

            Case "Details"
                Details.ClearDetails()
                Details.DataGridView1.DataSource = Nothing
                Details.DataGridView1.Refresh()
                MessageBox.Show("Transaction Cancelled")

            Case "Custom Info"
                CustomInfo.ClearDetails()
            'Details.DataGridView1.DataSource = Nothing
            'Details.DataGridView1.Refresh()
            'MessageBox.Show("Transaction Cancelled")
            Case "History"
                History.ClearDetails()
            Case "Certificate Of Payment"
                CertificateOfPayment.ClearDetails()
            Case "Schedule Of Delivery"
                ScheduleOfDelivery.ClearDetails()
            Case "User Settings"

            Case "Billing"

        End Select



    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveData()
    End Sub

    Private Sub SearchToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem1.Click
        SearchData()
    End Sub

    Private Sub tsbSearch_Click(sender As Object, e As EventArgs) Handles tsbSearch.Click
        SearchData()
    End Sub

    Sub SearchData()
        Dim node As TreeNode
        node = TreeView1.SelectedNode
        Select Case node.Text
            Case "Advances"

            Case "Liquidation"

            Case "Main"

            Case "Details"
                If Details.txtFileNo.Text = "" Then
                    MessageBox.Show("Enter File Number")
                Else
                    FW.FilterData(Details.txtFileNo.Text)
                End If

            Case "Custom Info"
                If CustomInfo.txtFileNo.Text = "" Then
                    MessageBox.Show("Enter File Number")
                Else
                    FW.GetAllDataDetails(CustomInfo.txtFileNo.Text)
                    FW.GetAllCustomInfo(CustomInfo.txtFileNo.Text)
                    CustomInfo.populateToFields()
                    CustomInfo.populateToFieldsCustomInfo()
                End If

            Case "History"
                If History.txtFileNo.Text = "" Then
                    MessageBox.Show("Enter File Number")
                Else
                    FW.GetAllDataDetails(History.txtFileNo.Text)
                    History.populateToFields()
                End If
            Case "Certificate Of Payment"
                If CertificateOfPayment.txtFileNo.Text = "" Then
                    MessageBox.Show("Enter File Number")
                Else
                    FW.GetAllDataDetails(CertificateOfPayment.txtFileNo.Text)
                    FW.GetAllCertificateOfpayment(CertificateOfPayment.txtFileNo.Text)
                    CertificateOfPayment.populateToFields()
                    CertificateOfPayment.populateToFieldsCertidicateOfpayment()

                End If
            Case "Schedule Of Delivery"
                If ScheduleOfDelivery.txtFileNo.Text = "" Then
                    MessageBox.Show("Enter File Number")
                Else
                    FW.GetAllDataDetails(ScheduleOfDelivery.txtFileNo.Text)
                    ScheduleOfDelivery.populateToFields()
                End If
            Case "User Settings"

            Case "Billing"

        End Select
    End Sub

    Sub NewData()

        Dim node As TreeNode
        node = TreeView1.SelectedNode
        Select Case node.Text
            Case "Advances"

            Case "Liquidation"

            Case "Main"

            Case "Details"
                'Feature: Enable Disabled Object Here
                Dim milliseconds = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalMilliseconds)
                Details.txtFileNo.Text = "FN" + milliseconds.ToString
                Details.txtCodeNumber.Text = "CN" + milliseconds.ToString

            Case "Custom Info"
                'Insert Custom Info for Specific File No

            Case "History"

            Case "Certificate Of Payment"

            Case "Schedule Of Delivery"

            Case "User Settings"

            Case "Billing"

        End Select
    End Sub
End Class
