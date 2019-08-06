Imports System.Data
Imports System.Data.SqlClient
Public Class EmployeeDetails
    Sub fillDatagrid()
        Dim da As New SqlDataAdapter("select * from Employee", con)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillDatagrid()
    End Sub
    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        If tbEmpid.Text = "" Then
            MessageBox.Show("please insert Employee ID")
            tbEmpid.Focus()
        ElseIf tbEmpName.Text = "" Then
            MessageBox.Show("please insert Employee Name")
            tbEmpName.Focus()
        ElseIf tbempAddress.Text = "" Then
            MessageBox.Show("please insert Employee Address")
            tbempAddress.Focus()
        ElseIf tbMobileNo.Text = "" Then
            MessageBox.Show("please insert Mobile Number")
            tbMobileNo.Focus()
        ElseIf tbMobileNo.Text.Length < 10 Then
            MessageBox.Show("number should contain 10 digits")
            tbMobileNo.Focus()
        ElseIf tbMobileNo.Text.Length > 10 Then
            MessageBox.Show("number should contain less than or equal to 10 digits...")
            tbMobileNo.Focus()
        Else
            Try
                Dim str As String = "Insert into Employee(EMP_ID,EMP_NAME,EMP_ADDRESS,MOBILE_NO)values('" & tbEmpid.Text & "','" & tbEmpName.Text & "','" & tbempAddress.Text & "','" & tbMobileNo.Text & "')"
                If (ExecuteQuery(str) = True) Then
                    fillDatagrid()
                    MessageBox.Show("Record added succesfully..")
                    clearrecords()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If tbEmpid.Text = "" Or tbEmpName.Text = "" Or tbempAddress.Text = "" Or tbMobileNo.Text = "" Then
            MessageBox.Show("Error in updating....")
            tbEmpName.Focus()
            Exit Sub
        End If
        Try
            Dim str As String = "update employee set EMP_NAME ='" & tbEmpName.Text & "',EMP_ADDRESS='" & tbempAddress.Text & "',MOBILE_NO='" & tbMobileNo.Text & "' where EMP_ID = '" & tbEmpid.Text & "'"
            If (ExecuteQuery(str) = True) Then
                fillDatagrid()
                MessageBox.Show("Record updated successfully")
                clearrecords()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If tbEmpid.Text = "" Or tbEmpName.Text = "" Or tbempAddress.Text = "" Or tbMobileNo.Text = "" Then
            MessageBox.Show("Error in deleting....")
            tbEmpid.Focus()
            Exit Sub
        End If
        Try
            Dim str As String = "delete from Employee where EMP_ID ='" & tbEmpid.Text & "'"

            Dim s = MessageBox.Show("Are you sure to delete", "Delete Records", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If s = vbYes Then
                If (ExecuteQuery(str) = True) Then
                    fillDatagrid()
                    clearrecords()
                    MessageBox.Show("Record Successfully Deleted")
                End If
            Else
                clearrecords()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        clearrecords()
    End Sub

    Private Sub tbEmpid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbEmpid.TextChanged
        Dim ID, EMPADDRESS, EMPNAME, EMPMOBILE As String
        Dim empid As String = tbEmpid.Text
        Dim str As String = "select * from Employee where EMP_ID= '" & empid & "' "
        Try
            dr = RetrieveQuery(str)
            Do While dr.Read
                ID = dr(0)
                EMPNAME = dr(1)
                EMPADDRESS = dr(2)
                EMPMOBILE = dr(3)
                tbEmpid.Text = ID
                tbEmpName.Text = EMPNAME
                tbempAddress.Text = EMPADDRESS
                tbMobileNo.Text = EMPMOBILE
                con.Close()
                Exit Sub
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
        If tbEmpid.Text = "" Then
            clearrecords()
        End If
    End Sub
    Private Sub tbMobileNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbMobileNo.KeyPress
        Dim keychar = e.KeyChar
        If Not Char.IsDigit(e.KeyChar) And (AscW(keychar) <> 8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub clearrecords()
        tbEmpid.Clear()
        tbEmpName.Clear()
        tbempAddress.Clear()
        tbMobileNo.Clear()
    End Sub
 
End Class