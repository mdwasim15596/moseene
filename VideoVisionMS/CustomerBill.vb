Imports System.Data
Imports System.Data.SqlClient
Public Class CustomerBill
    Dim AmountPaid As Boolean
    Private Sub CustomerBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rbNo.Checked = True
        btnOk.Enabled = False
    End Sub
    Private Sub tbCustomerID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCustomerID.TextChanged
        Dim CUST_ID, CUSTOMERNAME, PACKAGESELECTED, AMOUNT, STARTDATE As String
        Dim id As String = tbCustomerID.Text
        Dim str As String = "select * from Customer_Records where CUST_ID= '" & id & "' "
        Try
            dr = RetrieveQuery(str)
            Do While dr.Read
                CUST_ID = dr(0)
                CUSTOMERNAME = dr(1)
                PACKAGESELECTED = dr(4)
                AMOUNT = dr(5)
                STARTDATE = dr(6)
                tbCustomerID.Text = CUST_ID
                tbCustomerName.Text = CUSTOMERNAME
                tbPackageSelected.Text = PACKAGESELECTED
                tbAmount.Text = AMOUNT
                dtpStartDAte.Value = STARTDATE
                dtpTodaysdate.Value = Today.Date
                TotalDays()
                TotalAmount()
                con.Close()
                Exit Sub

            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()
        If tbCustomerID.Text = "" Then
            tbCustomerName.Text = ""
            tbPackageSelected.Text = ""
            tbAmount.Text = ""
        End If
    End Sub
    Private Sub rbYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbYes.CheckedChanged
        AmountPaid = 1
        btnOk.Enabled = True
    End Sub
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If tbCustomerID.Text = "" Or tbCustomerName.Text = "" Or tbAmount.Text = "" Then
            MessageBox.Show("please insert all the required information....")
            tbCustomerID.Focus()
        ElseIf tbCustomerName.Text = "" Then
            MessageBox.Show("please insert Customer Name")
            tbCustomerName.Focus()
        Else
            Try
                Dim str As String = "Insert into Customer_Bill(CUST_ID,CUSTOMER_NAME,PACKAGE_SELECTED,AMOUNT,START_DATE,END_DATE,AMOUNT_PAID,TOTAL_AMOUNT) values('" & tbCustomerID.Text & "','" & tbCustomerName.Text & "','" & tbPackageSelected.Text & "','" & tbAmount.Text & "','" & dtpStartDAte.Value.Date.ToString("dd-MMM-yyyy") & "','" & dtpTodaysdate.Value.Date.ToString("dd-MMM-yyyy") & "','" & AmountPaid & "','" & tbTotalAmount.Text & "')"
                If (ExecuteQuery(str) = True) Then
                    UpdateStartDate()
                    clearcontrols()
                    rbNo.Checked = True
                    btnOk.Enabled = False
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub rbNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNo.CheckedChanged
        AmountPaid = 0
    End Sub
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        clearcontrols()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim s = MessageBox.Show("Are you sur you want to cancel", "Bill", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If s = Windows.Forms.DialogResult.Yes Then
            Me.Hide()
            MDI.Show()
        ElseIf s = Windows.Forms.DialogResult.No Then
            Me.Show()
        End If
    End Sub
    Private Sub tbTotalDays_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbTotalDays.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TotalDays()
        Try
            Dim sd As Date = dtpStartDAte.Value
            Dim ed As Date = dtpTodaysdate.Value
            Dim totaldate As Integer = ed.Subtract(sd).TotalDays
            tbTotalDays.Text = totaldate
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub TotalAmount()
        Try
            If Val(tbTotalDays.Text) = 0 Then
                tbTotalAmount.Text = CInt(tbAmount.Text) * 0
            ElseIf Val(tbTotalDays.Text) > 0 And Val(tbTotalDays.Text) <= 30 Then
                tbTotalAmount.Text = CInt(tbAmount.Text) * 1
            ElseIf Val(tbTotalDays.Text) > 30 And Val(tbTotalDays.Text) <= 60 Then
                tbTotalAmount.Text = CInt(tbAmount.Text) * 2
            ElseIf Val(tbTotalDays.Text) > 60 And Val(tbTotalDays.Text) <= 90 Then
                tbTotalAmount.Text = CInt(tbAmount.Text) * 3
            ElseIf Val(tbTotalDays.Text) > 90 And Val(tbTotalDays.Text) <= 120 Then
                tbTotalAmount.Text = CInt(tbAmount.Text) * 4
            ElseIf Val(tbTotalDays.Text) > 120 And Val(tbTotalDays.Text) <= 150 Then
                tbTotalAmount.Text = CInt(tbAmount.Text) * 5
            ElseIf Val(tbTotalDays.Text) > 150 And Val(tbTotalDays.Text) <= 180 Then
                tbTotalAmount.Text = CInt(tbAmount.Text) * 6
            ElseIf Val(tbTotalDays.Text) > 180 And Val(tbTotalDays.Text) <= 210 Then
                tbTotalAmount.Text = CInt(tbAmount.Text) * 7
            ElseIf Val(tbTotalDays.Text) > 210 And Val(tbTotalDays.Text) <= 240 Then
                tbTotalAmount.Text = CInt(tbAmount.Text) * 8
            ElseIf Val(tbTotalDays.Text) > 240 And Val(tbTotalDays.Text) <= 270 Then
                tbTotalAmount.Text = CInt(tbAmount.Text) * 8
            ElseIf Val(tbTotalDays.Text) > 270 And Val(tbTotalDays.Text) <= 300 Then
                tbTotalAmount.Text = CInt(tbAmount.Text) * 9
            ElseIf Val(tbTotalDays.Text) > 300 And Val(tbTotalDays.Text) <= 330 Then
                tbTotalAmount.Text = CInt(tbAmount.Text) * 10
            ElseIf Val(tbTotalDays.Text) > 330 And Val(tbTotalDays.Text) <= 360 Then
                tbTotalAmount.Text = CInt(tbAmount.Text) * 11
            ElseIf Val(tbTotalDays.Text) > 360 And Val(tbTotalDays.Text) <= 390 Then
                tbTotalAmount.Text = CInt(tbAmount.Text) * 12
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub clearcontrols()
        tbCustomerID.Clear()
        tbCustomerName.Clear()
        tbPackageSelected.Clear()
        tbAmount.Clear()
        tbTotalDays.Clear()
        tbTotalAmount.Clear()
        rbNo.Checked = True
    End Sub
    Private Sub UpdateStartDate()
        Dim str = "Update  Customer_Records set DATE_OF_JOINING = '" & dtpTodaysdate.Value.Date.ToString("dd-MMM-yyyy") & "' where CUST_ID = '" & tbCustomerID.Text & "' "
        If (ExecuteQuery(str) = True) Then
            MessageBox.Show("Bill Successfully Generated for " + tbCustomerName.Text)
        End If
    End Sub

    Private Sub btnViewBills_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewBills.Click
        ALLBILLS.Show()
    End Sub
End Class