Imports System.Windows.Forms

Public Class Updater



    Private Sub Updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim TA2 As New dbDataSetTableAdapters.EmailTemplatesTableAdapter

        Dim TB = TA2.GetDataByID(Form1.DGV.SelectedCells(0).Value.ToString)
        If TB.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim R As dbDataSet.EmailTemplatesRow = TB.Rows(0)

        TextBox1.Text = R.EmailTitle
        cmbbxEmailCat.Text = R.Category
        RichTextBox1.Text = R.Email


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TA As New dbDataSetTableAdapters.EmailTemplatesTableAdapter
        Dim ID As Integer = Form1.DGV.SelectedCells(0).Value.ToString

        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Please provide Title")
            Exit Sub
        ElseIf cmbbxEmailCat.Text = "" Then
            ErrorProvider1.SetError(cmbbxEmailCat, "Please select Category")
            Exit Sub
        End If
        If MsgBox("Are you sure you want to update the template?", MsgBoxStyle.YesNo) = vbYes Then
            TA.UpdateQueryByID(cmbbxEmailCat.Text, RichTextBox1.Text, TextBox1.Text, ID)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Exit Sub
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
