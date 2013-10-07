Option Strict On

Public Class Form1

    Dim stepNo As Integer

    Private Sub btnCompute_Click(sender As System.Object, e As System.EventArgs) Handles btnCompute.Click
        Dim N As Integer

        ' Check for valid input
        If Not IsNumeric(txtNumDisks.Text) Then
            MessageBox.Show("Please type a number.", "Error")
            Return
        End If

        N = CInt(txtNumDisks.Text)

        If (N < 1) Or (N > 12) Then
            MessageBox.Show("Please type a positive number between 1 and 12.", "Error")
            Return
        End If

        stepNo = 0
        lstInstructions.Items.Clear()

        ' Write your code below
        lstInstructions.Items.Add("Not implemented yet.")

    End Sub

    Sub main()
        Throw(1,3,10)
    End Sub


    End Sub

End Class
