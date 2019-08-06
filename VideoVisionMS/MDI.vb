Public Class MDI
    Private Sub ABOUTORGANIZATIONToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABOUTORGANIZATIONToolStripMenuItem1.Click
        AboutUs.Focus()
        AboutUs.Show()
    End Sub

    Private Sub NEWENTRYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NEWENTRYToolStripMenuItem.Click
        CustomerNewEntry.Focus()
        CustomerNewEntry.Show()
    End Sub

    Private Sub EXISTINGCUSTOMERSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXISTINGCUSTOMERSToolStripMenuItem.Click
        CustomerRecords.Focus()
        CustomerRecords.Show()

    End Sub

    Private Sub PACKAGESLISTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PACKAGESLISTSToolStripMenuItem.Click
        PackagesList.Focus()
        PackagesList.Show()
    End Sub
    Private Sub NEWIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NEWIDToolStripMenuItem.Click
        NewAdmin.Focus()
        NewAdmin.Show()
    End Sub
    Private Sub DATABASEGRIDVIEWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATABASEGRIDVIEWToolStripMenuItem.Click
        CustomerDatabase.Focus()
        CustomerDatabase.Show()
    End Sub

    Private Sub EMPLOYEEDETAILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMPLOYEEDETAILSToolStripMenuItem.Click
        EmployeeDetails.Focus()
        EmployeeDetails.Show()
    End Sub
    Private Sub CUSTOMERBILLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUSTOMERBILLToolStripMenuItem.Click
        CustomerBill.Focus()
        CustomerBill.Show()
    End Sub
    Private Sub ALLBILLSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALLBILLSToolStripMenuItem.Click
        ALLBILLS.Focus()
        ALLBILLS.Show()
    End Sub
    Private Sub SIGNOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SIGNOUTToolStripMenuItem.Click
        Dim ans As Integer
        ans = MsgBox("Are you sure you want to exit from this system????", vbYesNo + vbQuestion, "Signout")
        If ans = MsgBoxResult.No Then
            Exit Sub
        Else
            End
        End If
    End Sub
End Class