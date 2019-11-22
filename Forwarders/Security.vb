Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports ADODB
Imports System.Security.Cryptography
Imports System.Text

Public Class Security

    Function fCHK(ByVal uname As String, ByVal pword As String) As Boolean
        Dim da As New System.Data.OleDb.OleDbDataAdapter()
        Dim ds As New DataSet()


        Dim rsLogin As New ADODB.Recordset
        Dim logstr = ("SELECT userid, password From USERS WHERE userid='" & uname & "' and password='" & GetHash(pword) & "'")

        With rsLogin
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
            .CursorType = ADODB.CursorTypeEnum.adOpenStatic
            .LockType = ADODB.LockTypeEnum.adLockBatchOptimistic
            .Open(logstr, gs_Conn)

        End With



        With rsLogin

            If .EOF Then
                fCHK = False
            Else

                fCHK = True
                mdl.log = uname
            End If

        End With

    End Function


    Shared Function GetHash(theInput As String) As String

        Using hasher As MD5 = MD5.Create()    ' create hash object

            ' Convert to byte array and get hash
            Dim dbytes As Byte() =
                 hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))

            ' sb to create string from bytes
            Dim sBuilder As New StringBuilder()

            ' convert byte data to hex string
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n

            Return sBuilder.ToString()
        End Using

    End Function



End Class
