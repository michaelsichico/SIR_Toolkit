Imports SIRTool

Public Class mainform
    Dim a As New MainWindow

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Dim min_break As Integer = 30
    Dim min_lunch As Integer = 60
    Dim min_rest As Integer = 15
    Dim min_hold As Integer

    Dim sec_break As Integer = 0
    Dim sec_lunch As Integer = 0
    Dim sec_rest As Integer = 0
    Dim sec_hold As Integer = 0

    Dim msec_break As Integer = 0
    Dim msec_lunch As Integer = 0
    Dim msec_rest As Integer = 0
    Dim msec_hold As Integer = 0

#Region "drag_form"
    Private Sub mainform_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub mainform_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub mainform_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
#End Region

#Region "close"
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_close_MouseEnter(sender As Object, e As EventArgs) Handles btn_close.MouseEnter
        'btn_close.BackgroundImage = Image.FromFile("C:\Users\sichi\documents\visual studio 2013\Projects\CSS Toolkit\CSS Toolkit\Resources\1433870751_exit.png")
    End Sub

    Private Sub btn_close_MouseLeave(sender As Object, e As EventArgs) Handles btn_close.MouseLeave
        'btn_close.BackgroundImage = Image.FromFile("C:\Users\sichi\documents\visual studio 2013\Projects\CSS Toolkit\CSS Toolkit\Resources\1433870751_exit_black.png")
    End Sub
#End Region

#Region "break_control"
    Private Sub btn_reset_break_Click(sender As Object, e As EventArgs)
        min_break = 30
        sec_break = 0
        msec_break = 0
        lbl_min_break.Text = min_break.ToString("00")
        lbl_sec_break.Text = sec_break.ToString("00")
        Timer1.Enabled = False
    End Sub

    Private Sub btn_break_Click(sender As Object, e As EventArgs) Handles btn_break.Click

        If Timer1.Enabled = False Then
            Timer1.Enabled = True
            btn_break.BackgroundImage = My.Resources._1436996236_pause
        ElseIf Timer1.Enabled = True Then
            Timer1.Enabled = False
            btn_break.BackgroundImage = My.Resources._1433873769_play_arrow
        End If

    End Sub

    Private Sub btn_stop_break_Click(sender As Object, e As EventArgs)
        Timer1.Enabled = False
    End Sub
#End Region

#Region "break_timer"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If msec_break > 0 Then
            msec_break -= 1
        End If
        If sec_break > 0 Then
            If msec_break = 0 Then
                sec_break -= 1
                msec_break = 59
            End If
        End If
        If min_break > 0 Then
            If sec_break = 0 Then
                If msec_break = 0 Then
                    min_break -= 1
                    sec_break = 59
                    msec_break = 59
                End If
            End If
        End If

        If msec_break = 0 Then
            If sec_break = 0 Then
                If min_break = 0 Then
                    Timer1.Enabled = False
                End If
            End If
        End If

        lbl_min_break.Text = min_break.ToString("00")
        lbl_sec_break.Text = sec_break.ToString("00")
    End Sub
#End Region

#Region "lunch_control"
    Private Sub btn_lunch_Click(sender As Object, e As EventArgs) Handles btn_lunch.Click
        If Timer2.Enabled = False Then
            Timer2.Enabled = True
            btn_lunch.BackgroundImage = My.Resources._1436996236_pause
        ElseIf Timer2.Enabled = True Then
            Timer2.Enabled = False
            btn_lunch.BackgroundImage = My.Resources._1433873769_play_arrow
        End If
    End Sub

    Private Sub btn_stop_lunch_Click(sender As Object, e As EventArgs)
        Timer2.Enabled = False
    End Sub

    Private Sub btn_reset_lunch_Click(sender As Object, e As EventArgs)
        Timer2.Enabled = False
        min_lunch = 60
        sec_lunch = 0
        msec_lunch = 0
        lbl_min_lunch.Text = min_lunch.ToString("00")
        lbl_sec_lunch.Text = sec_lunch.ToString("00")
    End Sub
#End Region

#Region "lunch_timer"
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If msec_lunch > 0 Then
            msec_lunch -= 1
        End If
        If sec_lunch > 0 Then
            If msec_lunch = 0 Then
                sec_lunch -= 1
                msec_lunch = 59
            End If
        End If
        If min_lunch > 0 Then
            If sec_lunch = 0 Then
                If msec_lunch = 0 Then
                    min_lunch -= 1
                    sec_lunch = 59
                    msec_lunch = 59
                End If
            End If
        End If

        If msec_lunch = 0 Then
            If sec_lunch = 0 Then
                If min_lunch = 0 Then
                    Timer2.Enabled = False
                End If
            End If
        End If

        lbl_min_lunch.Text = min_lunch.ToString("00")
        lbl_sec_lunch.Text = sec_lunch.ToString("00")
    End Sub
#End Region

#Region "rest_control"
    Private Sub btn_rest_Click(sender As Object, e As EventArgs) Handles btn_rest.Click
        If Timer3.Enabled = False Then
            Timer3.Enabled = True
            btn_rest.BackgroundImage = My.Resources._1436996236_pause
        ElseIf Timer3.Enabled = True Then
            Timer3.Enabled = False
            btn_rest.BackgroundImage = My.Resources._1433873769_play_arrow
        End If
    End Sub

    Private Sub btn_stop_rest_Click(sender As Object, e As EventArgs)
        Timer3.Enabled = False
    End Sub

    Private Sub btn_reset_rest_Click(sender As Object, e As EventArgs)
        min_rest = 15
        sec_rest = 0
        msec_rest = 0
        lbl_min_rest.Text = min_rest.ToString("00")
        lbl_sec_rest.Text = sec_rest.ToString("00")
        Timer3.Enabled = False
    End Sub
#End Region

#Region "restroom_timer"
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If msec_rest > 0 Then
            msec_rest -= 1
        End If
        If sec_rest > 0 Then
            If msec_rest = 0 Then
                sec_rest -= 1
                msec_rest = 59
            End If
        End If
        If min_rest > 0 Then
            If sec_rest = 0 Then
                If msec_rest = 0 Then
                    min_rest -= 1
                    sec_rest = 59
                    msec_rest = 59
                End If
            End If
        End If

        If msec_rest = 0 Then
            If sec_rest = 0 Then
                If min_rest = 0 Then
                    Timer3.Enabled = False
                End If
            End If
        End If

        lbl_min_rest.Text = min_rest.ToString("00")
        lbl_sec_rest.Text = sec_rest.ToString("00")
    End Sub
#End Region

#Region "hold_control"
    Private Sub btn_play_hold_Click(sender As Object, e As EventArgs)
        Try

            Timer4.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_stop_hold_Click(sender As Object, e As EventArgs)
        Timer4.Enabled = False
    End Sub

    Private Sub btn_reset_hold_Click(sender As Object, e As EventArgs)

        min_hold = 0
        sec_hold = 0
        msec_hold = 0

        Timer4.Enabled = False
    End Sub
#End Region

#Region "hold_timer"
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If msec_hold > 0 Then
            msec_hold -= 1
        End If
        If sec_hold > 0 Then
            If msec_hold = 0 Then
                sec_hold -= 1
                msec_hold = 59
            End If
        End If
        If min_hold > 0 Then
            If sec_hold = 0 Then
                If msec_hold = 0 Then
                    min_hold -= 1
                    sec_hold = 59
                    msec_hold = 59
                End If
            End If
        End If

        If msec_hold = 0 Then
            If sec_hold = 0 Then
                If min_hold = 0 Then
                    Timer4.Enabled = False
                End If
            End If
        End If

    End Sub
#End Region

    Private Sub btn_feedback_Click(sender As Object, e As EventArgs) Handles btn_feedback.Click
        feedbackform.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            a.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        chatform.Show()
    End Sub

    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        contacts.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        issue.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        timezone.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        SEMTool.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        About_Us.Show()
    End Sub
End Class
