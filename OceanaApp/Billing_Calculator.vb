Public Class Billing_Calculator

    Dim Paid, Total As Integer

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        Me.Close()
    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        If TxtPaid.Text <> "" Then
            Total = CDec(TxtTotal.Text.Substring(2))
            Paid = CDec(TxtPaid.Text)
            TxtChange.Text = "RM" & Paid - Total
        Else
            MessageBox.Show("Please fill in paid amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

End Class