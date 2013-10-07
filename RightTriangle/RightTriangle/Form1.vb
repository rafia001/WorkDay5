Option Strict On
Public Class Form1
    

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim a, b As Double
        a = CDbl(txtSideOne.Text)
        b = CDbl(txtSideTwo.Text)
        txtHyp.Text = Hypotenuse(a, b).ToString()
    End Sub

    Function Hypotenuse(ByVal x As Double, y As Double) As Double
        Dim z As Double
        z = Math.Sqrt(x ^ 2 + y ^ 2)
        Return z
    End Function

    



End Class
