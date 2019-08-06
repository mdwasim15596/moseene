Imports System.Data
Imports System.Data.SqlClient
Public Class CustomerDatabase
    Sub fillDatagrid()
        Dim da As New SqlDataAdapter("select * from Customer_Records", con)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Private Sub Database_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillDatagrid()
    End Sub

    
End Class