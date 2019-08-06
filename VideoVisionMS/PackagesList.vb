Imports System.Data
Imports System.Data.SqlClient
Public Class PackagesList
   

    Sub fillDatagrid()
        Dim da As New SqlDataAdapter("select * from Packages", con)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub PackagesList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillDatagrid()
    End Sub
End Class