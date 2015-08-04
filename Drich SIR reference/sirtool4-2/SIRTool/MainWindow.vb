Imports System
Imports System.IO
Imports System.Text


Public Class MainWindow
    Dim WithEvents lv As LVX
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FILE_NAME As String
        FILE_NAME = "Cases"

        If System.IO.Directory.Exists(FILE_NAME) = True Then
            Process.Start(FILE_NAME)
        Else
            MsgBox("File Does Not Exist")
        End If
    End Sub

    'Load data
    Public Sub loadresolutiontemplate(filename)
        Dim FILE_NAME As String = filename
        Dim objReader As New System.IO.StreamReader(FILE_NAME)
        txtbxNotes.SelectedText = objReader.ReadToEnd
        objReader.Close()
    End Sub


    Public Sub loadresolutiontemplateemail(filename)
        Dim FILE_NAME As String = filename
        Dim objReader As New System.IO.StreamReader(FILE_NAME)
        TextBox1.SelectedText = objReader.ReadToEnd
        objReader.Close()
    End Sub

    Public Sub loademailtemplates(filename)
        RichTextBox5.Clear()
        Dim FILE_NAME As String = filename
        Dim objReader As New System.IO.StreamReader(FILE_NAME)
        RichTextBox5.AppendText(objReader.ReadToEnd)
        objReader.Close()
        RichTextBox5.SelectAll()
        MessageBox.Label1.Text = "Copied!"
        MessageBox.TextBox1.Text = "Ready to paste the template."
        RichTextBox5.Copy()
        If MessageBox.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MessageBox.Close()
        End If
    End Sub

    Public Sub loademailtemplatesemail(filename)
        RichTextBox5.Clear()
        Dim FILE_NAME As String = filename
        Dim objReader As New System.IO.StreamReader(FILE_NAME)
        RichTextBox5.AppendText(objReader.ReadToEnd)
        objReader.Close()
        RichTextBox5.SelectAll()
        RichTextBox5.Copy()
        MessageBox.Label1.Text = "Copied!"
        MessageBox.TextBox1.Text = "Ready to paste the template."
        If MessageBox.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MessageBox.Close()
        End If
    End Sub

    Private Sub loadtitletemplate(filename)
        cmbbx_SIRTitle.Items.Clear()
        cmbbx_SIRTitle.AutoCompleteCustomSource.Clear()
        ComboBox1.Items.Clear()
        ComboBox1.AutoCompleteCustomSource.Clear()
        Dim lines() As String =
         IO.File.ReadAllLines(filename)
        cmbbx_SIRTitle.Items.AddRange(lines)
        cmbbx_SIRTitle.AutoCompleteCustomSource.AddRange(lines)
        ComboBox1.Items.AddRange(lines)
        ComboBox1.AutoCompleteCustomSource.AddRange(lines)
    End Sub

    Private Sub loadSRHistory(filename)
        'txtbxSR.Clear()
        txtbxSR.AutoCompleteCustomSource.Clear()
        Dim lines() As String =
         IO.File.ReadAllLines(filename)
        txtbxSR.AutoCompleteCustomSource.AddRange(lines)
    End Sub

    Public Sub loadchatlogs(filename)
        Dim FILE_NAME As String = filename
        Dim objReader As New System.IO.StreamReader(FILE_NAME)
        TextBox3.SelectedText = "[" & NumericUpDown1.Value + 1 & "] " & objReader.ReadToEnd
        NumericUpDown1.Value += 1
        objReader.Close()
    End Sub
    '
    Private Sub btn_RSh1_Click(sender As Object, e As EventArgs) Handles btn_RSh1.Click
        loadresolutiontemplate("Solutions\General.txt")
    End Sub

    ''clear data
    Private Sub btnPhonesNew_Click(sender As Object, e As EventArgs) Handles btnPhonesNew.Click
        btn_TimerStop.PerformClick()
        btn_TimerReset.PerformClick()
        txtbxNotes.Clear()
        txtbxSR.Clear()
        txtbxClientname.Clear()
        txtbxEmail.Clear()
        txtbxON.Clear()
        txtbxSN.Clear()
        rdbtnFCN.Checked = False
        rdbtnPSN.Checked = False
        rdbtnPSY.Checked = False
        rdbtnSSCS.Checked = False
        rdbtnFCY.Checked = False
        rdbtnSSPOP.Checked = False
        rdbtnSSTS.Checked = False
        loadresolutiontemplate("defaultSIR.txt")
        loadtitletemplate("titletemplates.txt")
        RichTextBox2.Clear()
    End Sub

    Private Sub MainWindow_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPhonesNew.PerformClick()
        Button61.PerformClick()
        loadSRHistory("Cases\SR-Bank.txt")
        CaseofToday()
        loadnotes("Notes.txt")

        lv = New LVX(txtbxNotes)
        Me.Controls.Add(lv)
        lv.Hide()
        With lv.Items
            .Add("Hello")
            .Add("Rama")
            .Add("Krishna")
            .Add("Vasudeva")
        End With

    End Sub

    Private Sub lbl_SIRNew_Click(sender As Object, e As EventArgs) Handles lbl_SIRNew.Click
        If MsgBox("Are you sure you want to clear this notes?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            txtbxNotes.Clear()
            loadresolutiontemplate("defaultSIR.txt")
        End If

    End Sub

    '**********************************
    'SAVE DATA
    '**********************************

    Private Sub btnPhonesSave_Click(sender As Object, e As EventArgs) Handles btnPhonesSave.Click
        Timer1.Stop()

        If txtbxSR.TextLength <> 0 And (rdbtnSSTS.Checked = True Or rdbtnSSCS.Checked = True Or rdbtnSSPOP.Checked = True) And (rdbtnFCY.Checked = True Or rdbtnFCN.Checked = True) And (rdbtnPSY.Checked = True Or rdbtnPSN.Checked = True) Then

            btn_COPYSIR.PerformClick()

            If ConfirmSave.ShowDialog() = Windows.Forms.DialogResult.OK Then

                Dim dateformat As String = DateTimePicker1.Text
                My.Computer.FileSystem.CreateDirectory("Cases\" & dateformat)
                RichTextBox1.SaveFile("Cases\" & dateformat & "\Phones-SR" & txtbxSR.Text & " - " & ConfirmSave.ComboBox1.Text & " - " & cmbbx_SIRTitle.Text & ".txt", _
                RichTextBoxStreamType.PlainText)

                ConfirmSave.Close()

                MessageBox.Label1.Text = "Saved!"
                MessageBox.TextBox1.Text = "Case has been successfully saved at: Cases\" & dateformat & "\SR" & txtbxSR.Text & " - " & ConfirmSave.ComboBox1.Text & " - " & cmbbx_SIRTitle.Text & ".txt"
                If MessageBox.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    MessageBox.Close()
                End If
                CaseofToday()

            End If

            SaveCurrentSR()
            SaveTitleTemplates()
        Else
            MessageBox.Label1.Text = "Oops!"
            MessageBox.TextBox1.Text = "Incomplete information."
            MessageBox.TopMost = True
            MessageBox.ShowDialog()
        End If

    End Sub


    Private Sub SaveTitleTemplates()
        Dim TempTitle As String = cmbbx_SIRTitle.Text
        For i As Integer = 0 To cmbbx_SIRTitle.Items.Count - 1
            If TempTitle = cmbbx_SIRTitle.AutoCompleteCustomSource.Item(i) Then
                Exit Sub
            End If
        Next
        Dim objWriter As New System.IO.StreamWriter("TitleTemplates.txt", True)
        objWriter.WriteLine(cmbbx_SIRTitle.Text)
        objWriter.Close()
        loadtitletemplate("TitleTemplates.txt")
    End Sub

    Private Sub SaveCurrentSR()
        Dim SRBank As String = txtbxSR.Text & ","

        If txtbxClientname.Text <> "" Then
            SRBank += txtbxClientname.Text & ","
        Else
            SRBank += ","
        End If

        If txtbxEmail.Text <> "" Then
            SRBank += txtbxEmail.Text & ","
        Else
            SRBank += ","
        End If
        If txtbxSN.Text <> "" Then
            SRBank += txtbxSN.Text & ","
        Else
            SRBank += ","
        End If
        If txtbxON.Text <> "" Then
            SRBank += txtbxON.Text
        End If

        Dim TempSR As String = SRBank
        For i = 0 To txtbxSR.AutoCompleteCustomSource.Count - 1
            'MsgBox(TempSR)
            If TempSR = txtbxSR.AutoCompleteCustomSource.Item(i) Then
                Exit Sub
            End If
        Next

        Dim objWriter2 As New System.IO.StreamWriter("cases\SR-Bank.txt", True)
        objWriter2.WriteLine(SRBank)
        objWriter2.Close()
        loadSRHistory("Cases\SR-Bank.txt")


    End Sub

    Private Sub CaseofToday()
        If My.Computer.FileSystem.DirectoryExists("Cases\" & DateTimePicker1.Text) Then
            Dim counterf = My.Computer.FileSystem.GetFiles("Cases\" & DateTimePicker1.Text).Count
            If counterf = 0 Then
                Exit Sub
            End If
            Dim counterd = "Cases (" & counterf & ")"
            btn_CasesofToday.Text = counterd
        Else
            btn_CasesofToday.Text = "Cases (0)"
        End If

    End Sub

    Private Sub txtbxNotes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbxNotes.KeyDown
        If e.KeyCode = Keys.Escape Then
            lv.Hide()
        End If
        If (e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down) And lv.Visible Then
            lv.Focus()
            Exit Sub
        End If
        If e.Control Then
            If e.KeyCode = Keys.Space Then
                e.SuppressKeyPress = True
                lv.Location = New Point(Windows.Forms.Cursor.Position.X - Me.Left, Windows.Forms.Cursor.Position.Y - Me.Top)
                lv.Height = 100
                lv.BringToFront()
                lv.Show()
                Dim prevtext = txtbxNotes.Text.Substring(InStrRev(txtbxNotes.Text, " "))
                If prevtext = "" Then
                    txtbxNotes.Text.Substring(InStrRev(txtbxNotes.Text, vbLf))
                End If
                If prevtext <> "" Then
                    lv.SendKeyString(prevtext)
                Else
                    lv.SelectedIndex = 0
                End If
            End If
        End If
    End Sub

    Private Sub txtbxNotes_TextChanged(sender As Object, e As EventArgs) Handles txtbxNotes.TextChanged

    End Sub





    Private Sub btn_TimerStart_Click(sender As Object, e As EventArgs) Handles btn_TimerStart.Click
        Timer1.Start()
        Me.stopwatch.Start()
        btn_TimerReset.Enabled = False
    End Sub

    '***********************************************
    'AHT TIMER
    '***********************************************

    Private stopwatch As New Stopwatch
    Private Sub btn_TimerStop_Click(sender As Object, e As EventArgs) Handles btn_TimerStop.Click
        Timer1.Stop()
        Me.stopwatch.Stop()
        btn_TimerReset.Enabled = True
    End Sub

    Private Sub btn_TimerReset_Click(sender As Object, e As EventArgs) Handles btn_TimerReset.Click
        Me.stopwatch.Reset()
        Label16.Text = "00:00:00:000"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = Me.stopwatch.Elapsed
        Label16.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", _
        Math.Floor(elapsed.TotalHours), _
        elapsed.Minutes, elapsed.Seconds, _
        elapsed.Milliseconds)
    End Sub

    Private Sub txtbxSR_TextChanged(sender As Object, e As EventArgs) Handles txtbxSR.TextChanged
        If txtbxSR.Text <> "" Or txtbxClientname.Text <> "" Or txtbxEmail.Text <> "" Or txtbxON.Text <> "" Or txtbxSN.Text <> "" Or txtbxSR.Text <> "" Then
            btn_TimerStart.PerformClick()
        End If

        If InStr(txtbxSR.Text, ",") > 0 Then
            Dim str() As String
            str = Split(txtbxSR.Text, ",")
            For i = 0 To str.Count - 1
                'MsgBox(i & "/" & str.Count - 1)

                If i = 1 Then
                    txtbxClientname.Text = str(1)
                End If
                If i = 2 Then
                    txtbxEmail.Text = str(2)
                End If
                If i = 3 Then
                    txtbxSN.Text = str(3)
                End If
                If i = 4 Then
                    txtbxON.Text = str(4)
                End If
            Next
            txtbxSR.Text = str(0)
        Else

        End If
    End Sub

    Private Sub txtbxSN_TextChanged(sender As Object, e As EventArgs) Handles txtbxSN.TextChanged
        btn_TimerStart.PerformClick()
    End Sub



    Private Sub btn_COPYSIR_Click(sender As Object, e As EventArgs) Handles btn_COPYSIR.Click
        Timer2.Start()

        Dim SS As String
        If rdbtnSSTS.Checked = True Then
            SS = "TS"
        ElseIf rdbtnSSPOP.Checked = True Then
            SS = "POP"
        ElseIf rdbtnSSCS.Checked = True Then
            SS = "CS"
        Else
            SS = ""
        End If

        RichTextBox1.Text = "" &
        "SR: " & txtbxSR.Text & vbNewLine &
        "Skillset: " & SS & vbNewLine

        If txtbxClientname.Text <> "" Then
            RichTextBox1.AppendText("Caller Name: " & txtbxClientname.Text & vbNewLine)
        End If

        If txtbxEmail.Text <> "" Then
            RichTextBox1.AppendText("Email Address: " & txtbxEmail.Text & vbNewLine)
        End If

        If txtbxSN.Text <> "" Then
            RichTextBox1.AppendText("Serial Number: " & txtbxSN.Text & vbNewLine)
        End If

        If txtbxON.Text <> "" Then
            RichTextBox1.AppendText("Order Number: " & txtbxON.Text & vbNewLine)
        End If

        If rdbtnFCY.Checked = True Then
            RichTextBox1.AppendText("First Contact: Yes" & vbNewLine)
        ElseIf rdbtnFCN.Checked = True Then
            RichTextBox1.AppendText("First Contact: No" & vbNewLine)
        Else

        End If

        If rdbtnPSY.Checked = True Then
            RichTextBox1.AppendText("Premium: Yes" & vbNewLine)
        ElseIf rdbtnPSN.Checked = True Then
            RichTextBox1.AppendText("Premium: No" & vbNewLine)
        Else

        End If

        RichTextBox1.AppendText("********************************************************" & vbNewLine & vbNewLine)
        RichTextBox1.AppendText(txtbxNotes.Text)
        RichTextBox1.AppendText(vbNewLine & "Call Duration: " & Label16.Text)


        RichTextBox1.SelectAll()
        RichTextBox1.Copy()
        RichTextBox2.Clear()
        RichTextBox2.Paste()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If RichTextBox1.Text = RichTextBox2.Text Then
            btn_COPYSIR.BackColor = Color.DarkGreen
            Button59.BackColor = Color.DarkGreen
            RichTextBox2.Clear()
            RichTextBox2.Paste()
        Else
            btn_COPYSIR.BackColor = Color.SteelBlue
            Button59.BackColor = Color.SteelBlue
            Timer2.Stop()
        End If


    End Sub

    Private Sub btn_Hold_Click(sender As Object, e As EventArgs) Handles btn_Hold.Click
        If btn_Hold.Text = "Hold" Then
            btn_Hold.Text = "In-Calls"
            Timer3.Start()
            btn_Hold.BackColor = Color.DarkGreen
            m2.Visible = False
            Label32.Text = m2.Value
            txtbxNotes.AppendText("[Put Client on Hold: " & Label16.Text & "]" & vbNewLine)
        Else
            btn_Hold.Text = "Hold"
            s2.Text = "00"
            Label21.Text = 0
            prgrsbar_Hold.Value = prgrsbar_Hold.Minimum
            Timer3.Stop()
            btn_Hold.BackColor = Color.SeaGreen
            m2.Visible = True
            txtbxNotes.AppendText("[Get back to Client: " & Label16.Text & "]" & vbNewLine)
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        If Label32.Text = 0 And s2.Text = 0 Then
            prgrsbar_Hold.Value = prgrsbar_Hold.Maximum
            Exit Sub
        End If

        If prgrsbar_Hold.Value = prgrsbar_Hold.Maximum Then
            Timer3.Stop()
            btn_Hold.BackColor = Color.DarkRed
        Else

            prgrsbar_Hold.Value = (((Label21.Text)) / ((m2.Value) * 60)) * 100
            Label30.Text = prgrsbar_Hold.Value
        End If

        If s2.Text = 60 Or s2.Text = 0 Then
            Label32.Text = Val(Label32.Text) - Val(1)
            s2.Text = 60
        End If
        Label21.Text = Val(Label21.Text) + 1
        s2.Text = Val(s2.Text) - Val(1)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TopMost = True
        End If

        If CheckBox1.Checked = False Then
            TopMost = False
        End If
    End Sub



    Private Sub btn_CasesofToday_Click_1(sender As Object, e As EventArgs) Handles btn_CasesofToday.Click
        CasesForToday.ShowDialog()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        CaseofToday()
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        MoreSolution.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim FILE_NAME As String
        If TabControl2.SelectedTab.Text = "R Templates" Then
            FILE_NAME = "Solutions\"
        Else
            FILE_NAME = "Emails\"
        End If


        If System.IO.Directory.Exists(FILE_NAME) = True Then
            Process.Start(FILE_NAME)

        Else
            MsgBox("File Does Not Exist")
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Dim FILE_NAME As String
        FILE_NAME = "DefaultSIR.txt"

        If System.IO.File.Exists(FILE_NAME) = True Then
            Process.Start(FILE_NAME)
        Else
            MsgBox("File Does Not Exist")
        End If
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Dim FILE_NAME As String
        FILE_NAME = "TitleTemplates.txt"

        If System.IO.File.Exists(FILE_NAME) = True Then
            Process.Start(FILE_NAME)
        Else
            MsgBox("File Does Not Exist")
        End If
    End Sub

    Private Sub RichTextBox3_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox3.TextChanged
        RichTextBox3.SaveFile("Notes.txt", RichTextBoxStreamType.PlainText)
        'loadnotes("Notes.txt")
    End Sub
    Private Sub loadnotes(filename)
        Dim lines() As String =
         IO.File.ReadAllLines(filename)
        RichTextBox3.AppendText(File.ReadAllText("Notes.txt"))
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub



    Private Sub txtbxClientname_TextChanged(sender As Object, e As EventArgs) Handles txtbxClientname.TextChanged
        btn_TimerStart.PerformClick()
    End Sub

    Private Sub txtbxEmail_TextChanged(sender As Object, e As EventArgs) Handles txtbxEmail.TextChanged
        btn_TimerStart.PerformClick()
    End Sub

    Private Sub txtbxON_TextChanged(sender As Object, e As EventArgs) Handles txtbxON.TextChanged
        btn_TimerStart.PerformClick()
    End Sub


    Private Sub Button11_Click(sender As Object, e As EventArgs)
        MoreEmails.Show()
    End Sub

    Private Sub btn_RSh2_Click(sender As Object, e As EventArgs) Handles btn_RSh2.Click
        loadresolutiontemplate("Solutions\POP.txt")
    End Sub

    Private Sub btn_RSh3_Click(sender As Object, e As EventArgs) Handles btn_RSh3.Click
        loadresolutiontemplate("Solutions\Refund.txt")
    End Sub

    Private Sub btn_RSh10_Click(sender As Object, e As EventArgs) Handles btn_RSh10.Click
        loadresolutiontemplate("Solutions\TurnoffAR.txt")
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        loadresolutiontemplate("Solutions\ForgotPSW.txt")
    End Sub

    Private Sub btn_RSh4_Click(sender As Object, e As EventArgs) Handles btn_RSh4.Click
        loadresolutiontemplate("Solutions\InstallHowTo.txt")
    End Sub

    Private Sub btn_RSh11_Click(sender As Object, e As EventArgs) Handles btn_RSh11.Click
        loadresolutiontemplate("Solutions\Performance.txt")
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        loadresolutiontemplate("Solutions\Malware.txt")
    End Sub

    Private Sub btn_RSh6_Click(sender As Object, e As EventArgs) Handles btn_RSh6.Click
        loadresolutiontemplate("Solutions\EndorseCS.txt")
    End Sub

    Private Sub btn_RSh5_Click(sender As Object, e As EventArgs) Handles btn_RSh5.Click
        loadresolutiontemplate("Solutions\EndorseTS.txt")
    End Sub

    Private Sub btn_RSh7_Click(sender As Object, e As EventArgs) Handles btn_RSh7.Click
        loadresolutiontemplate("Solutions\EndorsePS.txt")
    End Sub

    Private Sub btn_RSh8_Click(sender As Object, e As EventArgs) Handles btn_RSh8.Click
        loadresolutiontemplate("Solutions\EndorseDR.txt")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        loadresolutiontemplate("Solutions\EndorseBBY.txt")
    End Sub

    Private Sub btn_RSh9_Click(sender As Object, e As EventArgs) Handles btn_RSh9.Click
        loadresolutiontemplate("Solutions\EndorseCorp.txt")
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs)
        loademailtemplates("Emails\General.txt")
    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs)
        loademailtemplates("Emails\Disconnected.txt")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        loademailtemplates("Emails\RefundConfirm.txt")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        loademailtemplates("Emails\EndorseOnline.txt")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        loademailtemplates("Emails\InstallQVC.txt")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        loademailtemplates("Emails\InstallPRM.txt")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        loademailtemplates("Emails\InstallMAX.txt")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        loademailtemplates("Emails\InstallTIS.txt")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        loademailtemplates("Emails\InstallTAV.txt")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
        loademailtemplates("Emails\InstallMAC.txt")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        loademailtemplates("Emails\ScrnshtHJT.txt")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        loademailtemplates("Emails\AirSupport.txt")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        loademailtemplates("Emails\Followup2.txt")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        loademailtemplates("Emails\Followup4.txt")
    End Sub


    '===================================================================
    'CHAT
    '===================================================================



    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub Button64_Click(sender As Object, e As EventArgs) Handles Button64.Click
        If Button64.Text = "Start" Then
            Button64.Text = "Stop"
            Timer4.Start()
            Button64.BackColor = Color.DarkGreen
            Label37.Text = 10
        Else
            Button64.Text = "Start"
            Label34.Text = "00"
            Label37.Text = 10
            Label33.Text = 0
            ProgressBar1.Value = ProgressBar1.Minimum
            Timer4.Stop()
            Button64.BackColor = Color.SeaGreen
        End If
    End Sub

    'clear data
    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles Button61.Click
        Button64.Text = "Stop"
        Button64.PerformClick()
        TextBox2.Text = ""
        ComboBox1.Text = ""
        TextBox1.Text = ""
        loadresolutiontemplateemail("DefaultSIR.txt")
    End Sub

    Private Sub Button65_Click(sender As Object, e As EventArgs) Handles Button65.Click
        Dim FILE_NAME As String
        FILE_NAME = "Cases"

        If System.IO.Directory.Exists(FILE_NAME) = True Then
            Process.Start(FILE_NAME)
        Else
            MsgBox("File Does Not Exist")
        End If
    End Sub

    Private Sub Button66_Click(sender As Object, e As EventArgs) Handles Button66.Click
        Dim FILE_NAME As String
        FILE_NAME = "Cases"

        If System.IO.Directory.Exists(FILE_NAME) = True Then
            Process.Start(FILE_NAME)
        Else
            MsgBox("File Does Not Exist")
        End If
    End Sub

    'Save Data
    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        'If ConfirmSave.ShowDialog() = Windows.Forms.DialogResult.OK Then
        RichTextBox1.Clear()
        RichTextBox1.AppendText(TextBox3.Text)
        Dim dateformat As String = DateTimePicker1.Text
        My.Computer.FileSystem.CreateDirectory("Cases\" & dateformat)
        RichTextBox1.SaveFile("Cases\" & dateformat & "\ChatLogs.txt", _
        RichTextBoxStreamType.PlainText)

        ConfirmSave.Close()

        MessageBox.Label1.Text = "Saved!"
        MessageBox.TextBox1.Text = "Case has been successfully saved at: Cases\" & dateformat & "\ChatLogs.txt"
        If MessageBox.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MessageBox.Close()
        End If


        'End If
    End Sub

    'Save data email
    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        Timer1.Stop()
        Button64.PerformClick()
        If TextBox2.Text = "" Then
            MessageBox.Label1.Text = "Oops!"
            MessageBox.TextBox1.Text = "Service Request Number Field is Empty."
            TopMost = True
            If MessageBox.ShowDialog() = Windows.Forms.DialogResult.OK Then
                MessageBox.Close()
            End If
            Exit Sub
        End If

        Button59.PerformClick()

        If ConfirmSave.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Dim dateformat As String = DateTimePicker1.Text
            My.Computer.FileSystem.CreateDirectory("Cases\" & dateformat)
            RichTextBox1.SaveFile("Cases\" & dateformat & "\Email-SR" & TextBox2.Text & " - " & ConfirmSave.ComboBox1.Text & " - " & ComboBox1.Text & ".txt", _
            RichTextBoxStreamType.PlainText)

            ConfirmSave.Close()

            MessageBox.Label1.Text = "Saved!"
            MessageBox.TextBox1.Text = "Case has been successfully saved at: " & "Cases\" & dateformat & "\Email-SR" & TextBox2.Text & " - " & ConfirmSave.ComboBox1.Text & " - " & ComboBox1.Text & ".txt"
            If MessageBox.ShowDialog() = Windows.Forms.DialogResult.OK Then
                MessageBox.Close()
            End If
            NumericUpDown2.Value += 1

        End If



    End Sub
    'copy to clipboard email case
    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        Timer2.Start()

        RichTextBox1.Text = "" &
        "SR: " & txtbxSR.Text & vbNewLine

        RichTextBox1.AppendText("********************************************************" & vbNewLine & vbNewLine)
        RichTextBox1.AppendText(txtbxNotes.Text)

        RichTextBox1.SelectAll()
        RichTextBox1.Copy()
        RichTextBox2.Clear()
        RichTextBox2.Paste()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If Label37.Text = 0 And Label34.Text = 0 Then
            ProgressBar1.Value = ProgressBar1.Maximum
            Exit Sub
        End If

        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer3.Stop()
            Button64.BackColor = Color.DarkRed
        Else

            ProgressBar1.Value = (((Label33.Text)) / ((10) * 60)) * 100
            Label26.Text = ProgressBar1.Value
        End If

        If Label34.Text = 60 Or Label34.Text = 0 Then
            Label37.Text = Val(Label37.Text) - Val(1)
            Label34.Text = 60
        End If
        Label33.Text = Val(Label33.Text) + 1
        Label34.Text = Val(Label34.Text) - Val(1)
    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        Dim FILE_NAME As String
        FILE_NAME = "DefaultSIR.txt"

        If System.IO.File.Exists(FILE_NAME) = True Then
            Process.Start(FILE_NAME)
        Else
            MsgBox("File Does Not Exist")
        End If
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        loadresolutiontemplateemail("Solutions\General.txt")
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        loadresolutiontemplateemail("Solutions\POP.txt")
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        loadresolutiontemplateemail("Solutions\Refund.txt")
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        loadresolutiontemplateemail("Solutions\TurnOffAR.txt")
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        loadresolutiontemplateemail("Solutions\ForgotPSW.txt")
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        loadresolutiontemplateemail("Solutions\InstallHowTo.txt")
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        loadresolutiontemplateemail("Solutions\Performance.txt")
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        loadresolutiontemplateemail("Solutions\Malware.txt")
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        loadresolutiontemplateemail("Solutions\EndorseCS.txt")
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        loadresolutiontemplateemail("Solutions\EndorseTS.txt")
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        loadresolutiontemplateemail("Solutions\EndorsePS.txt")
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        loadresolutiontemplateemail("Solutions\EndorseDR.txt")
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        loadresolutiontemplateemail("Solutions\EndorseBBY.txt")
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        loadresolutiontemplateemail("Solutions\EndorseCorp.txt")
    End Sub

    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        loademailtemplatesemail("Emails\General.txt")
    End Sub

    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        loademailtemplatesemail("Emails\Disconnected.txt")
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        loademailtemplatesemail("Emails\RefundConfirm.txt")
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        loademailtemplatesemail("Emails\EndorseOnline.txt")
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        loademailtemplatesemail("Emails\InstallQVC.txt")
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        loademailtemplatesemail("Emails\InstallPRM.txt")
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        loademailtemplatesemail("Emails\InstallMAX.txt")
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        loademailtemplatesemail("Emails\InstallTIS.txt")
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        loademailtemplatesemail("Emails\InstallTAV.txt")
    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        loademailtemplatesemail("Emails\InstallMAC.txt")
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        loademailtemplatesemail("Emails\ScrnshtHJT.txt")
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        loademailtemplatesemail("Emails\AirSupport.txt")
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        loademailtemplatesemail("Emails\Followup2.txt")
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        loademailtemplatesemail("Emails\Followup4.txt")
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        MoreSolution.Show()
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        MoreEmails.Show()
    End Sub

    Private Sub Label37_Click(sender As Object, e As EventArgs) Handles Label37.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text <> "" Then
            Button64.Text = "Stop"
            Timer4.Start()
            Button64.BackColor = Color.DarkGreen
        End If
    End Sub

    Private Sub Button60_Click(sender As Object, e As EventArgs) Handles Button60.Click
        loadchatlogs("DefaultChatLog.txt")
    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click
        Dim FILE_NAME As String
        FILE_NAME = "DefaultChatLog.txt"

        If System.IO.File.Exists(FILE_NAME) = True Then
            Process.Start(FILE_NAME)
        Else
            MsgBox("File Does Not Exist")
        End If
    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs) Handles Label29.Click
        If MsgBox("Are you sure you want to clear the logs?", vbYesNo) = MsgBoxResult.Yes Then
            TextBox3.Text = ""
        Else
            Exit Sub
        End If

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs)
        If txtbxClientname.Text = "" Then
            Exit Sub
        End If
        Dim str() = Split(txtbxClientname.Text, " ")
        Dim URL As String = "http://gc.digitalriver.com/gc/ent/customerService/orderSearch.do?firstname=" & str(0) & "&lastname=" & str(1)
        Process.Start(URL)
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        Dim URL As String = "http://tsew.trendmicro.com/en-us/MainPage.aspx#?result=0&action=gcsw&gcsw_email=" & txtbxEmail.Text
        Process.Start(URL)
    End Sub


    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        Dim URL As String = "http://tsew.trendmicro.com/en-us/MainPage.aspx#?result=0&action=gcsw&gcsw_sn=" & txtbxSN.Text
        Process.Start(URL)
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        Dim URL As String = "http://tsew.trendmicro.com/en-us/MainPage.aspx#?result=0&action=gcsw&gcsw_orderid=" & txtbxON.Text
        Process.Start(URL)
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        Dim URL As String = "http://gc.digitalriver.com/gc/ent/customerService/orderSearch.do?email=" & txtbxEmail.Text
        Process.Start(URL)
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        Dim URL As String = "http://gc.digitalriver.com/gc/ent/customerService/orderSearch.do?orderID=" & txtbxON.Text
        Process.Start(URL)
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        MsgBox("Coming Soon!")



    End Sub


    Private Sub rdbtnSSTS_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtnSSTS.CheckedChanged

    End Sub
End Class