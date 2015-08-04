Imports System.Data.OleDb

Public Class issue

    Dim cn As OleDbConnection
    Dim cm As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim dt As New DataTable

    Private Sub issue_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            cn.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub issue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'open connection to test .xls
            cn.ConnectionString = "provider=Microsoft.Jet.OLEDB.4.0; Data Source=bin\Debug\ Excel\Issue.xls; Extended Properties 8.0;"
            cn.Open()
            'load file from .xls to datagrid view
            ' FillDataGridView("select from [Data Agen$]")
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
End Class