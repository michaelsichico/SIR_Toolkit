Imports System.Windows.Forms

Public Class ConfirmSave


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub ConfirmSave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Waiting For Customer"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
