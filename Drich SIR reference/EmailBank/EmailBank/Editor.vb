Imports System.Windows.Forms

Public Class Editor

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TA As New dbDataSetTableAdapters.EmailTemplatesTableAdapter

        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Please provide Title")
            Exit Sub
        ElseIf cmbbxEmailCat.Text = "" Then
            ErrorProvider1.SetError(cmbbxEmailCat, "Please select Category")
            Exit Sub
        End If
        TA.Insert(cmbbxEmailCat.Text, RichTextBox1.Text, TextBox1.Text)
        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim TA As New dbDataSetTableAdapters.EmailTemplatesTableAdapter
        TA.Insert(cmbbxEmailCat.Text, RichTextBox1.Text, TextBox1.Text)
        MsgBox("Template Successfully saved!", MsgBoxStyle.OkOnly)
        TextBox1.Clear()
        RichTextBox1.Clear()
    End Sub

    Private Sub Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
End Class
