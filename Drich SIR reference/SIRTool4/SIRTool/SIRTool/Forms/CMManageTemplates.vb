Imports System.Windows.Forms

Public Class CMManageTemplates



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub CMManageTemplates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbDataSet.CMShortcutKeys' table. You can move, or remove it, as needed.
        Me.CMShortcutKeysTableAdapter.Fill(Me.DbDataSet.CMShortcutKeys)
        'TODO: This line of code loads data into the 'DbDataSet.CaseManagement' table. You can move, or remove it, as needed.


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox4.Text = "" Then
            ConfirmMessage.Label1.Text = "Oops!"
            ConfirmMessage.TextBox1.Text = "Title cannot be empty. Please try again"
            ConfirmMessage.ShowDialog()
            Exit Sub
        End If

        Dim TA As New dbDataSetTableAdapters.CMShortcutKeysTableAdapter
        TA.UpdateQueryByID(DGVCMSpiels.SelectedCells(1).Value, TextBox1.Text, TextBox4.Text, DGVCMSpiels.SelectedCells(1).Value)
        ConfirmMessage.Label1.Text = "Success!"
        ConfirmMessage.TextBox1.Text = "Template successfully updated"
        ConfirmMessage.ShowDialog()
        TA.Fill(DbDataSet.CMShortcutKeys)
    End Sub



    Private Sub DGVCMSpiels_Click(sender As Object, e As EventArgs) Handles DGVCMSpiels.Click
        If DGVCMSpiels.SelectedCells(2).Value = "" Then
            TextBox1.Text = ""
        Else
            TextBox4.Text = DGVCMSpiels.SelectedCells(2).Value
            TextBox1.Text = DGVCMSpiels.SelectedCells(3).Value
        End If
    End Sub
End Class
