Imports System.Data.SqlClient

Imports System.Configuration

Public Class DbHelper

    Public Shared Function GetConnection() As SqlConnection

        Dim connStr As String = ConfigurationManager.ConnectionStrings("CouponDb").ConnectionString

        Return New SqlConnection(connStr)

    End Function

End Class
