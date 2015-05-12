Imports System.Math
Public Class Form1
    Dim number1 As Double
    Dim number2 As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        number1 = Val(TextBox1.Text)
        number2 = Sqrt(number1)
        MessageBox.Show("the square root of " & number1 & " is " & number2)
    End Sub
End Class
