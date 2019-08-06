Imports System.Data
Imports System.Data.SqlClient
Public Class NewAdmin
    Sub fillDatagrid()
        Dim da As New SqlDataAdapter("select * from Login", con)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillDatagrid()
        tbUserID.Focus()
        btnUpdate.Visible = False
        btnDelete.Visible = False
        btnCancel.Visible = False
        tbUserID.Focus()
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        OpenCon()
        Dim tel As String
        tel = tbpass.Text
        If tel.Length < 5 Then
            MessageBox.Show("Password is too weak please enter new password...!!")
            tbpass.Focus()
        ElseIf tbUserID.Text = "" Then
            MessageBox.Show("Please enter Userid")
            tbUserID.Focus()
        ElseIf tbusername.Text = "" Then
            MessageBox.Show("Please enter Username")
            tbusername.Focus()
        ElseIf tbpass.Text = "" Then
            MessageBox.Show("Please enter password")
            tbpass.Focus()
        ElseIf tbpass.Text <> tbconfmpass.Text Then
            MessageBox.Show("Password mismatched")
            tbpass.Clear()
            tbconfmpass.Clear()
            tbpass.Focus()
        Else
            Try
                Dim str As String = "Insert into Login(USERID,USERNAME,PASSWORD)values('" & tbUserID.Text & "','" & tbusername.Text & "','" & tbpass.Text & "')"
                If (ExecuteQuery(str) = True) Then
                    fillDatagrid()
                    MessageBox.Show("Record inserted successfully")
                    clearcontrols()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If tbUserID.Text = "" Then
            MessageBox.Show("Please enter Userid")
            tbUserID.Focus()
        ElseIf tbusername.Text = "" Then
            MessageBox.Show("Please enter Username")
            tbusername.Focus()
        ElseIf tbpass.Text = "" Then
            MessageBox.Show("Please enter password")
            tbpass.Focus()
        ElseIf tbpass.Text <> tbconfmpass.Text Then
            MessageBox.Show("Password Mismatched")
            tbpass.Clear()
            tbconfmpass.Clear()
            tbpass.Focus()
        Else
            Try
                Dim str As String = "update login set  USERNAME = '" & tbusername.Text & "',PASSWORD='" & tbpass.Text & "' where USERID ='" & tbUserID.Text & "'"
                If (ExecuteQuery(str) = True) Then
                    fillDatagrid()
                    MessageBox.Show("Record updated successfully")
                    clearcontrols()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If tbUserID.Text = "" Or tbusername.Text = "" Or tbpass.Text = "" Or tbconfmpass.Text = "" Then
            MessageBox.Show("Error in deleting....")
            tbUserID.Focus()
        ElseIf tbpass.Text <> tbconfmpass.Text Then
            MessageBox.Show("Password Mismatched")
            tbconfmpass.Clear()
            tbconfmpass.Focus()
        Else
            Try
                Dim str As String = "delete from Login where USERID ='" & tbUserID.Text & "'"
                If (ExecuteQuery(str) = True) Then
                    fillDatagrid()
                    MessageBox.Show("Record deleted succesfully")
                    clearcontrols()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub
    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        tbUserID.Focus()
        btnCancel.Visible = True
        btnsave.Enabled = False
        btnedit.Enabled = False
        btnUpdate.Visible = True
        btnDelete.Visible = True
    End Sub
    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        clearcontrols()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        tbUserID.Focus()
        btnsave.Enabled = True
        btnedit.Enabled = True
        btnUpdate.Visible = False
        btnDelete.Visible = False
        btnCancel.Visible = False
    End Sub
    Private Sub clearcontrols()
        tbUserID.Text = ""
        tbusername.Text = ""
        tbpass.Text = ""
        tbconfmpass.Text = ""
        tbUserID.Focus()
    End Sub
    Private Sub tbUserID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbUserID.TextChanged
        Dim ID, USERNAME, PASSWORD As String
        Dim userid As String = tbUserID.Text
        Dim str As String = "select * from Login where USERID = '" & userid & "' "
        Try
            dr = RetrieveQuery(str)
            Do While dr.Read
                ID = dr(0)
                USERNAME = dr(1)
                PASSWORD = dr(2)
                tbUserID.Text = ID
                tbusername.Text = USERNAME
                tbpass.Text = PASSWORD
                con.Close()
                Exit Sub
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
        If tbUserID.Text = "" Then
            tbusername.Text = ""
            tbpass.Text = ""
            tbconfmpass.Text = ""
        End If
    End Sub
   
End Class