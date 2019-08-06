Imports System.Data
Imports System.Data.SqlClient
Public Class CustomerRecords
    Dim sda As SqlDataAdapter
    Private Sub CustomerRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillComboPackage()
        tbAmount.Clear()
    End Sub
    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If tbCustomerID.Text = "" Then
            MessageBox.Show("Error in updating....")
            tbCustomerID.Focus()
        ElseIf tbCustomerName.Text = "" Then
            MessageBox.Show("Please enter Customer Name")
            tbCustomerName.Focus()
        ElseIf tbAddress.Text = "" Then
            MessageBox.Show("Please enter Customer's Address")
            tbAddress.Focus()
        ElseIf tbMobileNo.Text = "" Then
            MessageBox.Show("please insert Mobile Number")
            tbMobileNo.Focus()
        ElseIf tbMobileNo.Text.Length < 10 Then
            MessageBox.Show("number should contain 10 digits")
            tbMobileNo.Focus()
        ElseIf tbMobileNo.Text.Length > 10 Then
            MessageBox.Show("number should contain less than or equal to 10 digits...")
            tbMobileNo.Focus()
        ElseIf cbPackageSelected.SelectedIndex = -1 Then
            MessageBox.Show("Please select Package")
            cbPackageSelected.Focus()
        ElseIf DateTimePicker1.Value.Date > Today Then
            MessageBox.Show("Cannot Select future Date")
            DateTimePicker1.Focus()
        Else
            Try
                Dim str As String = "update Customer_Records set CUSTOMER_NAME ='" & tbCustomerName.Text & "', ADDRESS='" & tbAddress.Text & "',MOBILE_NO='" & tbMobileNo.Text & "',PACKAGE_SELECTED='" & cbPackageSelected.SelectedItem & "',AMOUNT='" & tbAmount.Text & "',DATE_OF_JOINING='" & DateTimePicker1.Value.Date.ToString("dd-MMM-yyyy") & "' where CUST_ID = '" & tbCustomerID.Text & "'"
                If (ExecuteQuery(str) = True) Then
                    MessageBox.Show("Record updated successfully")
                    Me.Hide()
                    clearrecords()
                End If
            Catch ex As Exception
                'MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If tbCustomerID.Text = "" Or tbCustomerName.Text = "" Or tbAddress.Text = "" Or tbMobileNo.Text = "" Or tbAmount.Text = "" Or DateTimePicker1.Value.Date > System.DateTime.Now Then
            MessageBox.Show("Error in deleting....")
            tbCustomerID.Focus()
            Exit Sub
        End If
        Try
            Dim str As String = "delete from Customer_Records where CUST_ID='" & tbCustomerID.Text & "'"
            Dim s = MessageBox.Show("Are you sure to delete", "Delete Records", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If s = vbYes Then
                If (ExecuteQuery(str) = True) Then
                    MessageBox.Show("Record deleted succesfully")
                    Me.Hide()
                    clearrecords()
                    CustomerDatabase.Show()
                    DateTimePicker1.Text = CStr(Date.Now)
                End If
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tbCustomerID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCustomerID.TextChanged
        Dim CUST_ID, CUSTOMERNAME, ADDRESS, PHONENO, PACKAGESELECTED, AMOUNT, DATEOFJOINING As String
        Dim id As String = tbCustomerID.Text
        Dim str As String = "select * from Customer_Records where CUST_ID= '" & id & "' "
        Try
            dr = RetrieveQuery(str)
            Do While dr.Read
                CUST_ID = dr(0)
                CUSTOMERNAME = dr(1)
                ADDRESS = dr(2)
                PHONENO = dr(3)
                PACKAGESELECTED = dr(4)
                AMOUNT = dr(5)
                DATEOFJOINING = dr(6)
                tbCustomerID.Text = CUST_ID
                tbCustomerName.Text = CUSTOMERNAME
                tbAddress.Text = ADDRESS
                tbMobileNo.Text = PHONENO
                cbPackageSelected.Text = PACKAGESELECTED
                tbAmount.Text = AMOUNT
                DateTimePicker1.Value = DATEOFJOINING
                con.Close()
                Exit Sub

            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()
        If tbCustomerID.Text = "" Then
            tbCustomerName.Text = ""
            tbAddress.Text = ""
            tbMobileNo.Text = ""
            cbPackageSelected.SelectedIndex = -1
            tbAmount.Text = ""
        End If
    End Sub
    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
    End Sub
    Private Sub cbPackageSelected_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPackageSelected.SelectedIndexChanged
        retrievetocb()
    End Sub
    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        clearrecords()
        tbCustomerID.Focus()
    End Sub
    Private Sub btnVIEWALLCUSTOMERS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVIEWALLCUSTOMERS.Click
        CustomerDatabase.Show()
    End Sub
    Private Sub FillComboPackage()
        Dim x As Integer
        Dim max As String
        Dim constr As String = "Data Source=MRLAPPY\IMRANKHAN;Initial Catalog=VideoVisionMS;Integrated Security=True"
        ' Dim constr = "Data Source=SAJID-PC;Initial Catalog=VideoVisionMS;Integrated Security=True"
        Dim sqlstr = "Select PACKAGE_NAME,PACKAGE_AMOUNT from PAckages"
        Dim con = New SqlConnection(constr)
        Dim cmd = New SqlCommand(sqlstr, con)
        Dim adp = New SqlDataAdapter(cmd)
        adp.Fill(ds, "Packages")
        max = ds.Tables("Packages").Rows.Count
        For x = 0 To max - 1
            cbPackageSelected.Items.Add(ds.Tables("Packages").Rows(x).Item(0))
        Next
    End Sub
    Private Sub clearrecords()
        tbCustomerID.Text = ""
        tbCustomerName.Text = ""
        tbAddress.Text = ""
        tbMobileNo.Text = ""
        cbPackageSelected.SelectedIndex = -1
        tbAmount.Text = ""

    End Sub

    Private Sub tbMobileNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbMobileNo.KeyPress
        Dim keychar = e.KeyChar
        If Not Char.IsDigit(e.KeyChar) And (AscW(keychar) <> 8) Then
            e.Handled = True
        End If
    End Sub
    Private Function retrievetocb() As Boolean
        Dim strstring As String
        Dim datarow As DataTableReader
        strstring = "SELECT PACKAGE_AMOUNT FROM Packages WHERE PACKAGE_NAME = '" & cbPackageSelected.Text & "'"
        Try
            Module1.OpenCon()
            adp = New SqlDataAdapter(strstring, con)
            adp.Fill(ds, "Packages")
            datarow = ds.Tables("Packages").CreateDataReader()
            If datarow.HasRows() = True Then
                While datarow.Read()
                    tbAmount.Text = datarow.Item("PACKAGE_AMOUNT")
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Module1.CloseCon()
        End Try
        Return True
    End Function
End Class