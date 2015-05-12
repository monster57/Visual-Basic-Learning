Public Class Form1
    Dim Message As String = ""
  
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number1, number2, inputNum, i, sum As Integer
        inputNum = Val(input.Text)
        number1 = 0
        number2 = 1
        Message = Message & number1 & " " & number2
        For i = 3 To inputNum
            sum = number1 + number2
            number1 = number2
            number2 = sum
            Message = Message & " " & number2
        Next i
        MessageBox.Show(Message)
    End Sub
End Class
