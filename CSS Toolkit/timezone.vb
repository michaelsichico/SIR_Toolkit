Imports System.Collections.ObjectModel
Imports System.Globalization.DaylightTime

Public Class timezone

    Private Sub timezone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim totalTime As DateTime
        Dim dt As DateTime = dateNABU.Text & " " & timeNabu.Text
        Dim tzInfo As TimeZoneInfo

        Try
            If ComboBox1.SelectedIndex = 0 Then
                tzInfo = TimeZoneInfo.FindSystemTimeZoneById("Atlantic Standard Time")
                totalTime = TimeZoneInfo.ConvertTime(dt, tzInfo, System.TimeZoneInfo.Local)
                TextBox1.Text = totalTime.ToString

            ElseIf ComboBox1.SelectedIndex = 1 Then
                tzInfo = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time")
                totalTime = TimeZoneInfo.ConvertTime(dt, tzInfo, System.TimeZoneInfo.Local)
                TextBox1.Text = totalTime.ToString

            ElseIf ComboBox1.SelectedIndex = 2 Then
                tzInfo = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time")
                totalTime = TimeZoneInfo.ConvertTime(dt, tzInfo, System.TimeZoneInfo.Local)
                TextBox1.Text = totalTime.ToString

            ElseIf ComboBox1.SelectedIndex = 3 Then
                tzInfo = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time")
                totalTime = TimeZoneInfo.ConvertTime(dt, tzInfo, System.TimeZoneInfo.Local)
                TextBox1.Text = totalTime.ToString

            ElseIf ComboBox1.SelectedIndex = 4 Then
                tzInfo = TimeZoneInfo.FindSystemTimeZoneById("Mountain Standard Time")
                totalTime = TimeZoneInfo.ConvertTime(dt, tzInfo, System.TimeZoneInfo.Local)
                TextBox1.Text = totalTime.ToString
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim totalTime As DateTime
        Dim dt As DateTime = dateAPEC.Text & " " & timeAPEC.Text
        Dim tzInfo As TimeZoneInfo

        Try
            If ComboBox2.SelectedIndex = 0 Then
                tzInfo = TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time")
                totalTime = TimeZoneInfo.ConvertTime(dt, tzInfo, System.TimeZoneInfo.Local)
                TextBox2.Text = totalTime.ToString

            ElseIf ComboBox2.SelectedIndex = 1 Then
                tzInfo = TimeZoneInfo.FindSystemTimeZoneById("Cen. Australia Standard Time")
                totalTime = TimeZoneInfo.ConvertTime(dt, tzInfo, System.TimeZoneInfo.Local)
                TextBox2.Text = totalTime.ToString

            ElseIf ComboBox2.SelectedIndex = 2 Then
                tzInfo = TimeZoneInfo.FindSystemTimeZoneById("W. Australia Standard Time")
                totalTime = TimeZoneInfo.ConvertTime(dt, tzInfo, System.TimeZoneInfo.Local)
                TextBox2.Text = totalTime.ToString

            ElseIf ComboBox2.SelectedIndex = 3 Then
                tzInfo = TimeZoneInfo.FindSystemTimeZoneById("New Zealand Standard Time")
                totalTime = TimeZoneInfo.ConvertTime(dt, tzInfo, System.TimeZoneInfo.Local)
                TextBox2.Text = totalTime.ToString
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class