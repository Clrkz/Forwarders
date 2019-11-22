Imports System.Data.SqlClient

Module mdl
    Public connectionString As String = "Data Source=khel;Initial Catalog=FW;User ID=sa;"
    Public conn As New SqlConnection(connectionString)
    Public adapter As New SqlDataAdapter
    Public ds As DataSet
    Public connStr As String
    Public log As String = ""
End Module
