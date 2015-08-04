Public Class Class1
    Public Sub CountDown(countmin As Integer, countsec As Integer, countmsec As Integer, timer As Timer, _
                                txtmin As Label, txtsec As Label, txtmsec As Label)
        txtmin.Text = countmin
        txtsec.Text = countsec
        txtmsec.Text = countmsec
    End Sub
End Class
