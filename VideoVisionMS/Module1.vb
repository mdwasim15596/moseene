Imports System.Data
Imports System.Data.SqlClient
Module Module1
    Dim constr As String = "Data Source=MRLAPPY\IMRANKHAN;Initial Catalog=VideoVisionMS;Integrated Security=True"
    'Dim constr As String = "Data Source=SAJID-PC;Initial Catalog=VideoVisionMS;Integrated Security=True"
    'Dim constr As String = "Data Source=RAZI;Initial Catalog=VideoVisionMS;Integrated Security=True"
    Public con As New SqlConnection(constr)
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public adp As SqlDataAdapter
    Public ds As New DataSet
    Public dv As New DataView
    Public cnumber As String
    Public Sub OpenCon()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub CloseCon()
        Try
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Function RetrieveQuery(ByVal strQuery As String) As SqlDataReader
        Try
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = strQuery
            dr = cmd.ExecuteReader
            RetrieveQuery = dr
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return dr
        End Try
    End Function
    Public Function ExecuteQuery(ByVal strQuery As String) As Boolean
        Try
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = strQuery
            cmd.ExecuteNonQuery()
            CloseCon()
            ExecuteQuery = True
        Catch ex As Exception
            ExecuteQuery = False
            MessageBox.Show(ex.Message)
        End Try
    End Function


End Module
