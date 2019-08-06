Imports System.Data
Imports System.Data.SqlClient
Public Class CustomerNewEntry
    Dim sda As SqlDataAdapter

    Private Sub CustomerNewEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddtoCombo()
        tbAmount.Clear()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If tbCustomerID.Text = "" Then
            MessageBox.Show("please insert Customer ID")
            tbCustomerID.Focus()
        ElseIf tbCustomerName.Text = "" Then
            MessageBox.Show("please insert Customer Name")
            tbCustomerName.Focus()
        ElseIf tbAddress.Text = "" Then
            MessageBox.Show("please insert Customer Address")
            tbAddress.Focus()
        ElseIf tbMobileno.Text = "" Then
            MessageBox.Show("please insert Mobile Number")
            tbMobileno.Focus()
        ElseIf tbMobileno.Text.Length < 10 Then
            MessageBox.Show("number should contain 10 digits")
            tbMobileno.Focus()
        ElseIf tbMobileno.Text.Length > 10 Then
            MessageBox.Show("number should contain less than or equal to 10 digits...")
            tbMobileno.Focus()
        ElseIf cbPackageSelected.SelectedIndex = -1 Then
            MessageBox.Show("Please select Package")
            cbPackageSelected.Focus()
            'ElseIf DateTimePicker1.Value.Date > Today Then
            '    MessageBox.Show("Cannot Select future Date")
            '    DateTimePicker1.Focus()
        Else
            Try
                Dim str As String = "Insert into Customer_Records(CUST_ID,CUSTOMER_NAME,ADDRESS,MOBILE_NO,PACKAGE_SELECTED,AMOUNT,DATE_OF_JOINING) values('" & tbCustomerID.Text & "','" & tbCustomerName.Text & "','" & tbAddress.Text & "','" & tbMobileno.Text & "','" & cbPackageSelected.SelectedItem & "','" & tbAmount.Text & "','" & DateTimePicker1.Value.Date.ToString("dd-MMM-yyyy") & "')"
                If (ExecuteQuery(str) = True) Then
                    MessageBox.Show("Record inserted successfully")
                    Me.Hide()
                    clearrecords()
                    MDI.Show()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        clearrecords()
        tbCustomerID.Focus()
    End Sub
    Private Sub cbPackageSelected_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPackageSelected.SelectedIndexChanged
        retrievetocb()
    End Sub
    Private Sub clearrecords()
        tbCustomerID.Text = ""
        tbCustomerName.Text = ""
        tbAddress.Text = ""
        tbMobileno.Text = ""
        cbPackageSelected.SelectedIndex = -1
        tbAmount.Text = ""

    End Sub
    Private Sub AddtoCombo()
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
    Private Sub tbMobileno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbMobileno.KeyPress
        Dim keychar = e.KeyChar
        If Not Char.IsDigit(e.KeyChar) And (AscW(keychar) <> 8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnVIEWALLCUSTOMERS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVIEWALLCUSTOMERS.Click
        CustomerDatabase.Show()
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