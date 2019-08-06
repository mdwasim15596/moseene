
Imports System.Data.SqlClient
Imports System.Data
Public Class ALLBILLS
    Dim adp As SqlDataAdapter
    Dim dt As DataTable
    Dim ds As DataSet
    Dim delete As String
    Private Sub filldatagrid()
        Dim adp As New SqlDataAdapter("select * from Customer_Bill", con)
        dt = New DataTable
        adp.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Private Sub ALLBILLS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        filldatagrid()
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Module1.OpenCon()
            For i As Integer = Me.DataGridView1.SelectedRows.Count - 1 To 0 Step -1
                delete = "delete Customer_Bill where CUST_ID ='" & Me.DataGridView1.SelectedRows(i).Cells(1).Value.ToString & "'"
                adp = New SqlDataAdapter(delete, con)
                ds = New DataSet
                adp.Fill(ds)
                Me.DataGridView1.Rows.Remove(Me.DataGridView1.SelectedRows(i))
            Next
            filldatagrid()
            MessageBox.Show("Deleted Successfully", "Informed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back.Click
        Me.Hide()
    End Sub
End Class
