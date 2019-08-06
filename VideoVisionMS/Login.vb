Imports System.Data
Imports System.Data.SqlClient
Public Class Login
    Dim constr As String = "Data Source=MRLAPPY\IMRANKHAN;Initial Catalog=VideoVisionMS;Integrated Security=True"
    'Dim constr As String = "Data Source=SAJID-PC;Initial Catalog=VideoVisionMS;Integrated Security=True"
    Public con As New SqlConnection(constr)
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public adp As SqlDataAdapter
    Public ds As New DataSet

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If tbUsername.Text = "" Or tbPass.Text = "" Then
            MessageBox.Show("Please enter username & password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf tbUsername.Text = "" Then
            MessageBox.Show("Please enter username", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbUsername.Focus()
        ElseIf tbPass.Text = "" Then
            MessageBox.Show("Please enter password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "select Username,Password from Login where Username='" & tbUsername.Text & "' and Password='" & tbPass.Text & "'"
            Try
                con.Open()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            dr = cmd.ExecuteReader
            Try
                If dr.Read = False Then
                    tbUsername.BackColor = Color.Red
                    tbPass.BackColor = Color.Red
                    MessageBox.Show("Wrong username or password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    tbUsername.Text = ""
                    tbPass.Text = ""
                    tbUsername.Focus()
                Else
                    MessageBox.Show("Login successful...")
                    tbUsername.BackColor = Color.White
                    tbPass.BackColor = Color.White
                    Me.Hide()
                    MDI.Show()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            con.Close()

        End If

    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLear.Click
        tbUsername.Text = ""
        tbPass.Text = ""
    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim s = MessageBox.Show("Are you Sure you want to EXIT", "EXIT APPLICATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If s = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        Else
            Me.Refresh()
        End If
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

