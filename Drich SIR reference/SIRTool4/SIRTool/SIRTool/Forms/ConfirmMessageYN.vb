Imports System.Windows.Forms

Public Class ConfirmMessageYesNo


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub


    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
        Me.Close()
    End Sub
End Class
