Imports System.Windows.Forms

Public Class TextViewer

  

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.Text = TextBox1.Text
        RichTextBox1.SelectAll()
        RichTextBox1.Copy()
    End Sub
End Class
