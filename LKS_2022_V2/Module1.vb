Imports System.Data.SqlClient
Module Module1
    Public conn As SqlConnection
    Public da As SqlDataAdapter
    Public rd As SqlDataReader
    Public dt As DataTable
    Public ds As DataSet
    Public cmd As SqlCommand
    Public MyDB As String
    Public Sub koneksi()
        MyDB = "Data Source = " & Environment.MachineName.ToString() & "\SQLEXPRESS;initial catalog = LKS_2022_V1;integrated security = true"
        conn = New SqlConnection(MyDB)
        If conn.State = ConnectionState.Closed Then conn.Open
    End Sub
End Module
