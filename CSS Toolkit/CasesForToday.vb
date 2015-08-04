Imports System.Windows.Forms

Public Class CasesForToday
    Private Sub CaseofToday()
        ListBox1.Items.Clear()
        ' MsgBox(DateTimePicker1.Text)
        If My.Computer.FileSystem.DirectoryExists("Cases\" & DateTimePicker1.Text) Then
            Dim di As New IO.DirectoryInfo("Cases\" & DateTimePicker1.Text)
            Dim diar1 As IO.FileInfo() = di.GetFiles()
            Dim dra As IO.FileInfo

            'list the names of all files in the specified directory
            For Each dra In diar1
                ListBox1.Items.Add(dra)
            Next
        Else

        End If
    End Sub


    Private Sub CasesForToday_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        DateTimePicker1.Text = MainWindow.DateTimePicker1.Text
        CaseofToday()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
       Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim FILE_NAME As String
        FILE_NAME = "Cases\" & DateTimePicker1.Text & "\" & ListBox1.SelectedItem.ToString

        If System.IO.File.Exists(FILE_NAME) = True Then
            Process.Start(FILE_NAME)

        Else
            MsgBox("File Does Not Exist")
        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        CaseofToday()
    End Sub
End Class
