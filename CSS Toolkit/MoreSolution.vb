﻿Public Class MoreSolution

    Private Sub MoreSolution_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = MainWindow.Location

        ListBox1.Items.Clear()
        ' MsgBox(DateTimePicker1.Text)
        If My.Computer.FileSystem.DirectoryExists("Solutions\") Then
            Dim di As New IO.DirectoryInfo("Solutions\")
            Dim diar1 As IO.FileInfo() = di.GetFiles()
            Dim dra As IO.FileInfo

            'list the names of all files in the specified directory
            For Each dra In diar1
                ListBox1.Items.Add(dra)
                TextBox1.AutoCompleteCustomSource.Add(dra.ToString)
            Next
        Else

        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.Text = "" Then
            Exit Sub
        End If
        TextBox1.Text = ListBox1.SelectedItem.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim FILE_NAME As String
        FILE_NAME = "Solutions" & "\" & TextBox1.Text

        If System.IO.File.Exists(FILE_NAME) = True Then
            Process.Start(FILE_NAME)

        Else
            MsgBox("File Does Not Exist")
        End If

    End Sub

    Private Sub btn_RSh4_Click(sender As Object, e As EventArgs) Handles btn_RSh4.Click
        MainWindow.loadresolutiontemplate("Solutions\" & TextBox1.Text)
        MainWindow.loadresolutiontemplateemail("Solutions\" & TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MainWindow.loadresolutiontemplate("Solutions\" & TextBox1.Text)
        MainWindow.loadresolutiontemplateemail("Solutions\" & TextBox1.Text)
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Process.Start("Solutions")
    End Sub
End Class