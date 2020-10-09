Imports System.Data
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class AcessoGenerico
    Private Shared iconexao As IDbConnection = Nothing
    Private Shared iadapter As IDbDataAdapter = Nothing
    Private Shared dbAdapter As DbDataAdapter = Nothing
    Private Shared ireader As IDataReader = Nothing

    Public Shared Function GetConnection(ByVal connType As Integer, ByVal connString As String) As IDbConnection
    Select Case connType
        Case 1
            iconexao = New OleDbConnection(connString)
        Case 2
            iconexao = New SqlConnection(connString)
        Case Else
    End Select
    Return iconexao
    End Function
    
    Public Shared Function GetDataAdapter(ByVal connType As Integer, ByVal connString As String, ByVal sql As String) As IDbDataAdapter
    Select Case connType
        Case 1
            iadapter = New OleDbDataAdapter(sql, connString)
        Case 2
            iadapter = New SqlDataAdapter(sql, connString)
        Case Else
    End Select
    Return iadapter
End Function
End Class
