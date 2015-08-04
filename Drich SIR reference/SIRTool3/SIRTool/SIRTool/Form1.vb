Imports System
Imports System.IO
Imports System.Text

Public Class Form1

    Private stopwatch As New Stopwatch

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = Me.stopwatch.Elapsed
        Label16.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", _
        Math.Floor(elapsed.TotalHours), _
        elapsed.Minutes, elapsed.Seconds, _
        elapsed.Milliseconds)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'reset all the fields
        txtbxClientname.Text = ""
        txtbxEmail.Text = ""
        txtbxON.Text = ""
        txtbxSN.Text = ""
        txtbxSR.Text = ""
        rdbtnFCN.Checked = False
        rdbtnFCY.Checked = False
        rdbtnPSN.Checked = False
        rdbtnPSY.Checked = False


        txtbxNotes.Text = "[Symptoms]" & vbNewLine &
                        "=====================================" & vbNewLine &
                        "- " & vbNewLine &
                        " " & vbNewLine &
                        "[Issue]" & vbNewLine &
                        "=====================================" & vbNewLine &
                        "- " & vbNewLine &
                        " " & vbNewLine &
                        "[Resolution]" & vbNewLine &
                        "=====================================" & vbNewLine &
                        "- Entitlement Check" & vbNewLine &
                        "- Verified Concern" & vbNewLine &
                        "- " & vbNewLine &
                        "- FCR" & vbNewLine &
                        "- Remind SR" & vbNewLine &
                        " " & vbNewLine &
                        "EOC" & vbNewLine
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDS.Template' table. You can move, or remove it, as needed.
        Me.ProbcatTableAdapter.FillByProductID(Me.DBDS.Probcat, "Antivirus Product")
        Me.ProbcatTableAdapter1.FillByProduct(Me.DBEDS.Probcat, "Antivirus Product")
        Me.NotesTableAdapter1.Fill(Me.DBDS.Notes)
        reloadall()

        TabControl1.Height = 155
        TabControl1.Width = 314


        txtbxNotes.Text = "[Symptoms]" & vbNewLine &
                        "=====================================" & vbNewLine &
                        "- " & vbNewLine &
                        " " & vbNewLine &
                        "[Issue]" & vbNewLine &
                        "=====================================" & vbNewLine &
                        "- " & vbNewLine &
                        " " & vbNewLine &
                        "[Resolution]" & vbNewLine &
                        "=====================================" & vbNewLine &
                        "- " & vbNewLine &
                        " " & vbNewLine &
                        "EOC"


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim TA As New DBDSTableAdapters.ProbcatTableAdapter

        If ComboBox1.Text = "" Then
            Exit Sub
        End If

        Dim TB = TA.GetDataByProbcatProduct(ComboBox1.Text, "Antivirus Product")
        Dim R As DBDS.ProbcatRow = TB.Rows(0)

        Me.SubcatTableAdapter.FillByProbcatID(Me.DBDS.Subcat, R.ID)

        Dim TA2 As New DBDSTableAdapters.SubcatTableAdapter
        Dim TB2 = TA2.GetDataByProbcatIDSubcat(R.ID, ComboBox2.Text)
        Dim R2 As DBDS.SubcatRow = TB2.Rows(0)

        Me.TemplateTableAdapter.FillBySubcatID(Me.DBDS.Template, R2.ID)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        txtbxNotes.Text = "[Symptoms]" & vbNewLine &
                        "=====================================" & vbNewLine &
                        "- " & vbNewLine &
                        " " & vbNewLine &
                        "[Issue]" & vbNewLine &
                        "=====================================" & vbNewLine &
                        "- " & vbNewLine &
                        " " & vbNewLine &
                        "[Resolution]" & vbNewLine &
                        "=====================================" & vbNewLine &
                        "- " & vbNewLine &
                        " " & vbNewLine &
                        "EOC"
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'copy all data
        Dim SS As String

        If rdbtnSSTS.Checked = True Then
            SS = "TS"
        ElseIf rdbtnSSPOP.Checked = True Then
            SS = "POP"
        Else
            SS = "CS"
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

        RichTextBox1.SelectAll()
        RichTextBox1.Copy()


        MessageBx.Label1.Text = "Compiled"
        MessageBx.Label2.Text = "Ready to paste SIR notes."
        If MessageBx.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MessageBx.Close()
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If txtbxSR.Text = "" Then
            MessageBx.Label1.Text = "Error"
            MessageBx.Label2.Text = "Service Request Number Field is Empty."
            If MessageBx.ShowDialog() = Windows.Forms.DialogResult.OK Then
                MessageBx.Close()
            End If
            Exit Sub
        End If


        Button2.PerformClick()

        Dim dateformat As String = DateTime.Now.ToString("MM-dd-yyyy")

        My.Computer.FileSystem.CreateDirectory("Cases\" & dateformat)
        RichTextBox1.SaveFile("Cases\" & dateformat & "\Phones_SR" & txtbxSR.Text & ".txt", _
        RichTextBoxStreamType.PlainText)

        MessageBx.Label1.Text = "Saved!"
        MessageBx.Label2.Text = "Case has been successfully saved at: " & vbNewLine &
                "Cases\" & dateformat & "\SR" & txtbxSR.Text & ".txt"
        If MessageBx.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MessageBx.Close()
        End If

    End Sub

    Private Sub txtbxSN_TextChanged(sender As Object, e As EventArgs) Handles txtbxSN.TextChanged
        Dim x As Integer

        If x = 0 Then
            If txtbxSN.TextLength = 4 Or txtbxSN.TextLength = 9 Or txtbxSN.TextLength = 14 Or txtbxSN.TextLength = 19 Then
                txtbxSN.AppendText("-")
                x = 1
            End If
        ElseIf x = 1 Then
            x = 0
            Exit Sub
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim TA As New DBDSTableAdapters.ProbcatTableAdapter

        If ComboBox1.Text = "" Then
            Exit Sub
        End If

        Dim TB = TA.GetDataByProbcatProduct(ComboBox1.Text, "Antivirus Product")
        If TB.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim R As DBDS.ProbcatRow = TB.Rows(0)

        Dim TA2 As New DBDSTableAdapters.SubcatTableAdapter
        Dim TB2 = TA2.GetDataByProbcatIDSubcat(R.ID, ComboBox2.Text)
        If TB2.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim R2 As DBDS.SubcatRow = TB2.Rows(0)

        Me.TemplateTableAdapter.FillBySubcatID(Me.DBDS.Template, R2.ID)
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    

    Private Sub reloadall()
        Dim TA As New DBDSTableAdapters.ProbcatTableAdapter

        If ComboBox1.Text = "" Then
            Exit Sub
        End If

        Dim TB = TA.GetDataByProbcatProduct(ComboBox1.Text, "Antivirus Product")
        Dim R As DBDS.ProbcatRow = TB.Rows(0)

        Me.SubcatTableAdapter.FillByProbcatID(Me.DBDS.Subcat, R.ID)

        Dim TA2 As New DBDSTableAdapters.SubcatTableAdapter
        Dim TB2 = TA2.GetDataByProbcatIDSubcat(R.ID, ComboBox2.Text)
        Dim R2 As DBDS.SubcatRow = TB2.Rows(0)

        Me.TemplateTableAdapter.FillBySubcatID(Me.DBDS.Template, R2.ID)




        
    End Sub

    

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'insert solution

        Dim TA As New DBDSTableAdapters.ProbcatTableAdapter

        If ComboBox1.Text = "" Then
            Exit Sub
        End If

        Dim TB = TA.GetDataByProbcatProduct(ComboBox1.Text, "Antivirus Product")
        If TB.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim R As DBDS.ProbcatRow = TB.Rows(0)

        Dim TA2 As New DBDSTableAdapters.SubcatTableAdapter
        Dim TB2 = TA2.GetDataByProbcatIDSubcat(R.ID, ComboBox2.Text)
        Dim R2 As DBDS.SubcatRow = TB2.Rows(0)

        Dim TA3 As New DBDSTableAdapters.TemplateTableAdapter
        Dim TB3 = TA3.GetDataBySubcatIDTemplateT(R2.ID, ComboBox3.Text)
        Dim R3 As DBDS.TemplateRow = TB3.rows(0)

        txtbxNotes.SelectedText = R3.Template

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

        Dim TA As New DBDSTableAdapters.NotesTableAdapter

        If ComboBox4.Text = "" Then
            Exit Sub
        End If

        Dim TB = TA.GetDataByNoteTitle(ComboBox4.Text)
        If TB.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim R As DBDS.NotesRow = TB.Rows(0)


        TextBox7.Text = R.Notes


    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        If ManageSolution.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ManageSolution.Close()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Timer1.Start()
        Me.stopwatch.Start()
        Button14.Enabled = False
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Timer1.Stop()
        Me.stopwatch.Stop()
        Button14.Enabled = True
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.stopwatch.Reset()
        Label16.Text = "00:00:00:000"
    End Sub

    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ManageNotes.ShowDialog = Windows.Forms.DialogResult.OK Then
            ManageNotes.Close()
        End If
    End Sub


    Private Sub Form1_MaximumSizeChanged(sender As Object, e As EventArgs) Handles Me.MaximumSizeChanged

    End Sub

    Private Sub DbPanel3_Paint(sender As Object, e As PaintEventArgs) Handles DbPanel3.Paint

    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        Dim dateformat As String = DateTime.Now.ToString("MM-dd-yyyy")
        If OpenFileDialog1.CheckPathExists <> False Then
            OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.CurrentDirectory & "\Cases\" & dateformat

        Else
            OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.CurrentDirectory & "\Cases\"
        End If

        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then

            OpenFile.RichTextBox1.AppendText(File.ReadAllText(OpenFileDialog1.FileName))

            OpenFile.ShowDialog()

        End If

        'Process.Start("explorer.exe", My.Computer.FileSystem.CurrentDirectory & "Cases\" & DateFormat)
    End Sub

    Private Sub startAHT() Handles txtbxClientname.TextChanged, txtbxEmail.TextChanged, txtbxON.TextChanged, txtbxSR.TextChanged, txtbxNotes.TextChanged
        If txtbxClientname.Text <> "" Or txtbxEmail.Text <> "" Or txtbxON.Text <> "" Or txtbxSN.Text <> "" Or txtbxSR.Text <> "" Then
            Button8.PerformClick()
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If Label32.Text = 0 And s2.Text = 0 Then
            ProgressBar1.Value = ProgressBar1.Maximum
            Exit Sub
        End If

        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer2.Stop()
            Button41.BackColor = Color.DarkRed
        Else

            ProgressBar1.Value = (((Label21.Text)) / ((m2.Value) * 60)) * 100
            Label30.Text = ProgressBar1.Value
        End If

        If s2.Text = 60 Or s2.Text = 0 Then
            Label32.Text = Val(Label32.Text) - Val(1)
            s2.Text = 60
        End If
        Label21.Text = Val(Label21.Text) + 1
        s2.Text = Val(s2.Text) - Val(1)
    End Sub

    Private Sub startAHT(sender As Object, e As EventArgs) Handles txtbxSR.TextChanged, txtbxON.TextChanged, txtbxNotes.TextChanged, txtbxEmail.TextChanged, txtbxClientname.TextChanged

    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        If Button41.Text = "Hold" Then
            Button41.Text = "InCalls"
            Timer2.Start()
            Button41.BackColor = Color.DarkGreen
            m2.Visible = False
            Label32.Text = m2.Value
        Else
            Button41.Text = "Hold"
            s2.Text = "00"
            Label21.Text = 0
            ProgressBar1.Value = ProgressBar1.Minimum
            Timer2.Stop()
            Button41.BackColor = Color.SeaGreen
            m2.Visible = True
        End If

    End Sub

    

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        TextBox8.Text = "[Symptoms]" & vbNewLine &
                        "=====================================" & vbNewLine &
                        "- " & vbNewLine &
                        " " & vbNewLine &
                        "[Issue]" & vbNewLine &
                        "=====================================" & vbNewLine &
                        "- " & vbNewLine &
                        " " & vbNewLine &
                        "[R1]" & vbNewLine &
                        "=====================================" & vbNewLine &
                        "- " & vbNewLine &
                        " " & vbNewLine &
                        "Status"
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        TextBox8.SelectAll()
        TextBox8.Copy()
    End Sub
End Class
