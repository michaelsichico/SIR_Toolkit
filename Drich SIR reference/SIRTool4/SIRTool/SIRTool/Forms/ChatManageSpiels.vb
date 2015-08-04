Imports System.Windows.Forms

Public Class ChatManageSpiels

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub ChatManageSpiels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbDataSet.ChatShortcutKeys' table. You can move, or remove it, as needed.
        Me.ChatShortcutKeysTableAdapter.Fill(Me.DbDataSet.ChatShortcutKeys)
        'TODO: This line of code loads data into the 'DbDS.ChatShortcutKeys' table. You can move, or remove it, as needed.

    End Sub

    'update shortcut keys

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim TA As New dbDataSetTableAdapters.ChatShortcutKeysTableAdapter
        TA.UpdateQuerybyID(DGVChatSpiels.SelectedCells(1).Value, TextBox1.Text, TextBox4.Text, DGVChatSpiels.SelectedCells(0).Value)
        ConfirmMessage.Label1.Text = "Success!"
        ConfirmMessage.TextBox1.Text = "Spiel successfully updated"
        ConfirmMessage.ShowDialog()
        TA.Fill(DbDataSet.ChatShortcutKeys)
    End Sub

    'load data when click

    Private Sub DGVChatSpiels_Click(sender As Object, e As EventArgs) Handles DGVChatSpiels.Click
        If DGVChatSpiels.SelectedCells(2).Value = "" Then
            TextBox1.Text = ""
        Else
            TextBox4.Text = DGVChatSpiels.SelectedCells(2).Value
            TextBox1.Text = DGVChatSpiels.SelectedCells(3).Value
        End If


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox4.TextChanged
        If TextBox4.Text = "" Or TextBox1.Text = "" Then
            Button2.Enabled = False
        Else
            Button2.Enabled = True
        End If
    End Sub

    Private Sub DGVChatSpiels_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVChatSpiels.CellContentClick

    End Sub
End Class
