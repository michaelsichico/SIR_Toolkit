Imports System.Windows.Forms

Public Class ManageNotes

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ManageNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDS.Notes' table. You can move, or remove it, as needed.
        Me.NotesTableAdapter.Fill(Me.DBDS.Notes)

    End Sub

    Private Sub DGVProbcat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProbcat.CellContentClick
        
    End Sub

    Private Sub DGVProbcat_MouseClick(sender As Object, e As MouseEventArgs) Handles DGVProbcat.MouseClick
        Dim TA As New DBDSTableAdapters.NotesTableAdapter
        Dim TB = TA.GetDataByNoteTitle(DGVProbcat.SelectedCells(0).Value)
        Dim R As DBDS.NotesRow = TB.Rows(0)

        TextBox1.Text = R.NoteTitle
        txtbxNotes.Text = R.Notes

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If DGVProbcat.Rows.Count = 0 Then
            Exit Sub
        End If

        If TextBox1.Text = "" Then
            Exit Sub
        End If

        Dim TA As New DBDSTableAdapters.NotesTableAdapter
        Dim TB = TA.GetDataByNoteTitle(TextBox1.Text)

        If TB.Rows.Count <> 0 Then
            MessageBx.Label1.Text = "Error"
            MessageBx.Label2.Text = "Notes already exist"
            If MessageBx.ShowDialog() = Windows.Forms.DialogResult.OK Then
                MessageBx.Close()
            End If
            Exit Sub
        End If
        TA.Insert(TextBox1.Text, txtbxNotes.Text)
        MessageBx.Label1.Text = "Success"
        MessageBx.Label2.Text = "Notes has been successfully added to the database"
        If MessageBx.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MessageBx.Close()
        End If


        TA.Fill(DBDS.Notes)



    End Sub
End Class
