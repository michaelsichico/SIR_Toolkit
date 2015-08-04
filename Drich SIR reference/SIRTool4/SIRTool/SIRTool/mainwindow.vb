Imports System
Imports System.IO
Imports System.Text


Public Class mainwindow
    Dim chatskmousehover As Integer
    Dim cmskmousehover As Integer
    Private stopwatch As New Stopwatch

    'load main window
    Private Sub mainwindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbemailDS.Template' table. You can move, or remove it, as needed.
        Me.TemplateTableAdapter.Fill(Me.DbemailDS.Template)
        'TODO: This line of code loads data into the 'DbemailDS.Subcat' table. You can move, or remove it, as needed.
        Me.SubcatTableAdapter.Fill(Me.DbemailDS.Subcat)
        'TODO: This line of code loads data into the 'DbemailDS.Probcat' table. You can move, or remove it, as needed.
        Me.ProbcatTableAdapter.FillByProduct(Me.DbemailDS.Probcat, "Antivirus Product")
        'TODO: This line of code loads data into the 'DbDataSet.CaseManagement' table. You can move, or remove it, as needed.
        Me.CaseManagementTableAdapter.Fill(Me.DbDataSet.CaseManagement)
        loaddataforemail()
    End Sub

    'CHAT ***********************************************************************************************

    'Open Chat Shortcut keys
    Private Sub Label47_Click(sender As Object, e As EventArgs) Handles Label47.Click
        ChatManageSpiels.ShowDialog()
    End Sub

    'add item logs
    Private Sub Chat_btnAdd_Click(sender As Object, e As EventArgs) Handles Chat_btnAdd.Click
        Dim dateformat As String = DateTime.Now
        NumericUpDown1.Value = NumericUpDown1.Value + 1

        Chat_txtbxLogs.AppendText(dateformat & vbNewLine & "[" & NumericUpDown1.Value &
                        "]=============================================" & vbNewLine & vbNewLine &
                        "Title: " & vbNewLine &
                        "Product: []HE []MR []EL []MS []SS []PWM" & vbNewLine &
                        "Version: " & vbNewLine &
                        "Customer Type: []New []Existing []Renewal" & vbNewLine &
                        "Description: " & vbNewLine & vbNewLine & vbNewLine)

    End Sub

    'save logs
    Private Sub Button116_Click(sender As Object, e As EventArgs) Handles Button116.Click
        Dim dateformat As String = DateTime.Now.ToString("MM-dd-yyyy")

        My.Computer.FileSystem.CreateDirectory("Cases\" & dateformat)

        RichTextBox2.Text = Chat_txtbxLogs.Text
        RichTextBox2.SaveFile("Cases\" & dateformat & "\ChatCaseLogs.txt", _
            RichTextBoxStreamType.PlainText)

        ConfirmMessage.Label1.Text = "Successful!"
        ConfirmMessage.TextBox1.Text = "Case Logs has been successfully saved!"
        ConfirmMessage.ShowDialog()


    End Sub

    'open logs
    Private Sub Button114_Click(sender As Object, e As EventArgs) Handles Button114.Click
        Dim dateformat As String = DateTime.Now.ToString("MM-dd-yyyy")
        If OpenFileDialog1.CheckPathExists <> False Then
            OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.CurrentDirectory & "\Cases\" & dateformat

        Else
            OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.CurrentDirectory & "\Cases\"
        End If

        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then

            If Chat_txtbxLogs.Text = "" Then
                Chat_txtbxLogs.AppendText(File.ReadAllText(OpenFileDialog1.FileName))
                Exit Sub
            End If

            ConfirmMessageYesNo.Label1.Text = "Warning"
            ConfirmMessageYesNo.TextBox1.Text = "Opening a log file will replace the current data, are you sure you want to continue?"

            If ConfirmMessageYesNo.ShowDialog = Windows.Forms.DialogResult.Yes Then
                Chat_txtbxLogs.AppendText(File.ReadAllText(OpenFileDialog1.FileName))
            Else
                Exit Sub
            End If

        End If

    End Sub

    'clear logs
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        If Chat_txtbxLogs.Text = "" Then
            Exit Sub
        End If
        ConfirmMessageYesNo.Label1.Text = "Warning"
        ConfirmMessageYesNo.TextBox1.Text = "The current data will be deleted, are you sure you want to continue?"

        If ConfirmMessageYesNo.ShowDialog = Windows.Forms.DialogResult.Yes Then
            Chat_txtbxLogs.Text = ""
        Else
            Exit Sub
        End If
    End Sub
    
    'Mousehover
    Private Sub getdataChatSK()
        Dim TA As New dbDataSetTableAdapters.ChatShortcutKeysTableAdapter
        Dim TB = TA.GetDataByID(chatskmousehover)
        Dim R As dbDataSet.ChatShortcutKeysRow = TB.Rows(0)
        TextBox7.Text = R.Title
    End Sub
    'get data to mousehover components:
    Private Sub Chat_btnSK1_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK1.MouseHover
        chatskmousehover = Chat_btnSK1.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK1_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK1.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK2_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK2.MouseHover
        chatskmousehover = Chat_btnSK2.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK2_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK2.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK3_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK3.MouseHover
        chatskmousehover = Chat_btnSK3.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK3_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK3.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK4_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK4.MouseHover
        chatskmousehover = Chat_btnSK4.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK4_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK4.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK5_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK5.MouseHover
        chatskmousehover = Chat_btnSK5.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK5_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK5.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK6_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK6.MouseHover
        chatskmousehover = Chat_btnSK6.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK6_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK4.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK7_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK7.MouseHover
        chatskmousehover = Chat_btnSK7.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK7_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK7.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK8_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK8.MouseHover
        chatskmousehover = Chat_btnSK8.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK8_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK8.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK9_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK9.MouseHover
        chatskmousehover = Chat_btnSK9.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK9_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK9.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK10_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK10.MouseHover
        chatskmousehover = Chat_btnSK10.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK10_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK10.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK11_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK11.MouseHover
        chatskmousehover = Chat_btnSK11.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK11_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK11.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK12_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK12.MouseHover
        chatskmousehover = Chat_btnSK12.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK12_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK12.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK13_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK13.MouseHover
        chatskmousehover = Chat_btnSK13.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK13_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK13.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK14_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK14.MouseHover
        chatskmousehover = Chat_btnSK14.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK14_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK14.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK15_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK15.MouseHover
        chatskmousehover = Chat_btnSK15.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK15_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK15.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK16_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK16.MouseHover
        chatskmousehover = Chat_btnSK16.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK16_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK16.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK17_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK17.MouseHover
        chatskmousehover = Chat_btnSK17.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK17_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK17.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK18_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK18.MouseHover
        chatskmousehover = Chat_btnSK18.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK18_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK18.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK19_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK19.MouseHover
        chatskmousehover = Chat_btnSK19.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK19_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK19.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK20_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK20.MouseHover
        chatskmousehover = Chat_btnSK20.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK20_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK20.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK21_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK21.MouseHover
        chatskmousehover = Chat_btnSK21.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK21_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK21.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK22_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK22.MouseHover
        chatskmousehover = Chat_btnSK22.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK22_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK22.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK23_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK23.MouseHover
        chatskmousehover = Chat_btnSK23.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK23_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK23.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK24_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK24.MouseHover
        chatskmousehover = Chat_btnSK24.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK24_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK24.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK25_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK25.MouseHover
        chatskmousehover = Chat_btnSK25.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK25_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK25.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK26_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK26.MouseHover
        chatskmousehover = Chat_btnSK26.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK26_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK26.MouseLeave
        TextBox7.Text = ""
    End Sub
    Private Sub Chat_btnSK27_MouseHover(sender As Object, e As EventArgs) Handles Chat_btnSK27.MouseHover
        chatskmousehover = Chat_btnSK27.Text
        getdataChatSK()
    End Sub
    Private Sub Chat_btnSK27_MouseLeave(sender As Object, e As EventArgs) Handles Chat_btnSK27.MouseLeave
        TextBox7.Text = ""
    End Sub

    'MouseClick
    Private Sub getdataChatSKClick()
        Dim TA As New dbDataSetTableAdapters.ChatShortcutKeysTableAdapter
        Dim TB = TA.GetDataByID(chatskmousehover)
        If TB.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim R As dbDataSet.ChatShortcutKeysRow = TB.Rows(0)
        RichTextBox3.Text = R.Content
        RichTextBox3.SelectAll()
        RichTextBox3.Copy()
    End Sub
    'mouseclick get data
    Private Sub Chat_btnSK1_Click(sender As Object, e As EventArgs) Handles Chat_btnSK1.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK2_Click(sender As Object, e As EventArgs) Handles Chat_btnSK2.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK10_Click(sender As Object, e As EventArgs) Handles Chat_btnSK10.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK4_Click(sender As Object, e As EventArgs) Handles Chat_btnSK4.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK19_Click(sender As Object, e As EventArgs) Handles Chat_btnSK19.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK11_Click(sender As Object, e As EventArgs) Handles Chat_btnSK11.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK20_Click(sender As Object, e As EventArgs) Handles Chat_btnSK20.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK8_Click(sender As Object, e As EventArgs) Handles Chat_btnSK8.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK13_Click(sender As Object, e As EventArgs) Handles Chat_btnSK13.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK22_Click(sender As Object, e As EventArgs) Handles Chat_btnSK22.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK3_Click(sender As Object, e As EventArgs) Handles Chat_btnSK3.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK17_Click(sender As Object, e As EventArgs) Handles Chat_btnSK17.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK26_Click(sender As Object, e As EventArgs) Handles Chat_btnSK26.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK24_Click(sender As Object, e As EventArgs) Handles Chat_btnSK24.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK12_Click(sender As Object, e As EventArgs) Handles Chat_btnSK12.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK21_Click(sender As Object, e As EventArgs) Handles Chat_btnSK21.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK16_Click(sender As Object, e As EventArgs) Handles Chat_btnSK16.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK25_Click(sender As Object, e As EventArgs) Handles Chat_btnSK25.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK7_Click(sender As Object, e As EventArgs) Handles Chat_btnSK7.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK14_Click(sender As Object, e As EventArgs) Handles Chat_btnSK14.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK23_Click(sender As Object, e As EventArgs) Handles Chat_btnSK23.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK9_Click(sender As Object, e As EventArgs) Handles Chat_btnSK9.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK18_Click(sender As Object, e As EventArgs) Handles Chat_btnSK18.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK27_Click(sender As Object, e As EventArgs) Handles Chat_btnSK27.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK6_Click(sender As Object, e As EventArgs) Handles Chat_btnSK6.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK15_Click(sender As Object, e As EventArgs) Handles Chat_btnSK15.Click
        getdataChatSKClick()
    End Sub
    Private Sub Chat_btnSK5_Click(sender As Object, e As EventArgs) Handles Chat_btnSK5.Click
        getdataChatSKClick()
    End Sub




    'Case Management =============================================================

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        If TextBox8.Text = "" Then
            Button77.Enabled = False
            Button76.Enabled = False
        Else
            Button77.Enabled = True
            Button76.Enabled = True
        End If
    End Sub

    'Clear data
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox8.Text = ""
        TextBox10.Text = ""
        ComboBox9.Text = " "
        ComboBox8.Text = " "
        ComboBox4.Text = " "

    End Sub
    'add data
    Private Sub Button77_Click(sender As Object, e As EventArgs) Handles Button77.Click
        Dim TA As New dbDataSetTableAdapters.CaseManagementTableAdapter
        Dim TB = TA.GetDataBySR(TextBox8.Text)

        If TextBox8.Text = "" Then
            ConfirmMessage.Label1.Text = "Oops!"
            ConfirmMessage.TextBox1.Text = "SR should not be empty, please try again"
            ConfirmMessage.ShowDialog()
            Exit Sub
        End If

        'check if exist, if yes update if no add
        If TB.Rows.Count <> 0 Then
            ConfirmMessageYesNo.Label1.Text = "Oops!"
            ConfirmMessageYesNo.TextBox1.Text = "This SR already exist, would you like to update it?"
            If ConfirmMessageYesNo.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                TA.UpdateQueryBySR(ComboBox9.Text, ComboBox4.Text, ComboBox8.Text, TextBox10.Text, Date.Now, TextBox8.Text)
                ConfirmMessage.Label1.Text = "Success!"
                ConfirmMessage.TextBox1.Text = "Item has been successfully updated"
                ConfirmMessage.ShowDialog()
                TA.Fill(DbDataSet.CaseManagement)
                Exit Sub
            Else
                Exit Sub
            End If

        End If



        TA.Insert(TextBox8.Text, ComboBox9.Text, ComboBox4.Text, ComboBox8.Text, TextBox10.Text, Date.Now)

        ConfirmMessage.Label1.Text = "Success!"
        ConfirmMessage.TextBox1.Text = "New Item for Casemanagement has been successfully added"
        ConfirmMessage.ShowDialog()

        TA.Fill(DbDataSet.CaseManagement)

    End Sub

    'Delete Data
    Private Sub Button76_Click(sender As Object, e As EventArgs) Handles Button76.Click
        Dim TA As New dbDataSetTableAdapters.CaseManagementTableAdapter
        Dim TB = TA.GetDataBySR(TextBox8.Text)

        If TextBox8.Text = "" Then
            ConfirmMessage.Label1.Text = "Oops!"
            ConfirmMessage.TextBox1.Text = "SR should not be empty, please try again"
            ConfirmMessage.ShowDialog()
            Exit Sub
        End If

        If DGVProbcat.Rows.Count = 0 Then
            ConfirmMessage.Label1.Text = "Oops!"
            ConfirmMessage.TextBox1.Text = "You have no open cases to delete."
            ConfirmMessage.ShowDialog()
            Exit Sub
        End If

        'check if exist, if yes update if no add
        If TB.Rows.Count <> 0 Then
            ConfirmMessageYesNo.Label1.Text = "Confirmation"
            ConfirmMessageYesNo.TextBox1.Text = "Are you sure you want to delete this item?"
            If ConfirmMessageYesNo.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                TA.DeleteQueryIDSR(DGVProbcat.SelectedCells(0).Value, TextBox8.Text)
                ConfirmMessage.Label1.Text = "Success!"
                ConfirmMessage.TextBox1.Text = "Item has been successfully deleted"
                ConfirmMessage.ShowDialog()
                TA.Fill(DbDataSet.CaseManagement)
                Exit Sub
            Else
                Exit Sub
            End If

        End If
    End Sub

    'load on click
    Private Sub DGVProbcat_Click(sender As Object, e As EventArgs) Handles DGVProbcat.Click
        Dim TA As New dbDataSetTableAdapters.CaseManagementTableAdapter

        If DGVProbcat.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim TB = TA.GetDataBySR(DGVProbcat.SelectedCells(1).Value)
        If TB.Rows.Count = 0 Then
            Exit Sub
        End If
        

        Dim R As dbDataSet.CaseManagementRow = TB.Rows(0)

        TextBox8.Text = R.SR
        ComboBox9.Text = R.Status
        ComboBox4.Text = R.Followup
        ComboBox8.Text = R.Rating
        TextBox10.Text = R.Todo
    End Sub

    'open CM Template Manager
    Private Sub Label48_Click(sender As Object, e As EventArgs) Handles Label48.Click
        If CMManageTemplates.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.CaseManagementTableAdapter.Fill(DbDataSet.CaseManagement)
        End If
    End Sub


    'mainwindow - CM
    Private Sub getdataCMSK()
        Dim TA As New dbDataSetTableAdapters.CMShortcutKeysTableAdapter
        Dim TB = TA.GetDataByID(cmskmousehover)
        Dim R As dbDataSet.CMShortcutKeysRow = TB.Rows(0)
        TextBox6.Text = R.Title
    End Sub
    'show title on hover
    Private Sub CM_btnSK1_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK1.MouseHover
        cmskmousehover = CM_btnSK1.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK1_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK1.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK2_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK2.MouseHover
        cmskmousehover = CM_btnSK2.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK2_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK2.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK3_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK3.MouseHover
        cmskmousehover = CM_btnSK3.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK3_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK3.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK4_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK4.MouseHover
        cmskmousehover = CM_btnSK4.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK4_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK4.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK5_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK5.MouseHover
        cmskmousehover = CM_btnSK5.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK5_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK5.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK6_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK6.MouseHover
        cmskmousehover = CM_btnSK6.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK6_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK4.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK7_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK7.MouseHover
        cmskmousehover = CM_btnSK7.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK7_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK7.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK8_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK8.MouseHover
        cmskmousehover = CM_btnSK8.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK8_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK8.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK9_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK9.MouseHover
        cmskmousehover = CM_btnSK9.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK9_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK9.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK10_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK10.MouseHover
        cmskmousehover = CM_btnSK10.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK10_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK10.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK11_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK11.MouseHover
        cmskmousehover = CM_btnSK11.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK11_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK11.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK12_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK12.MouseHover
        cmskmousehover = CM_btnSK12.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK12_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK12.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK13_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK13.MouseHover
        cmskmousehover = CM_btnSK13.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK13_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK13.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK14_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK14.MouseHover
        cmskmousehover = CM_btnSK14.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK14_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK14.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK15_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK15.MouseHover
        cmskmousehover = CM_btnSK15.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK15_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK15.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK16_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK16.MouseHover
        cmskmousehover = CM_btnSK16.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK16_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK16.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK17_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK17.MouseHover
        cmskmousehover = CM_btnSK17.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK17_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK17.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK18_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK18.MouseHover
        cmskmousehover = CM_btnSK18.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK18_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK18.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK19_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK19.MouseHover
        cmskmousehover = CM_btnSK19.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK19_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK19.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK20_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK20.MouseHover
        cmskmousehover = CM_btnSK20.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK20_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK20.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK21_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK21.MouseHover
        cmskmousehover = CM_btnSK21.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK21_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK21.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK22_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK22.MouseHover
        cmskmousehover = CM_btnSK22.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK22_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK22.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK23_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK23.MouseHover
        cmskmousehover = CM_btnSK23.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK23_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK23.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK24_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK24.MouseHover
        cmskmousehover = CM_btnSK24.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK24_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK24.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK25_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK25.MouseHover
        cmskmousehover = CM_btnSK25.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK25_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK25.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK26_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK26.MouseHover
        cmskmousehover = CM_btnSK26.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK26_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK26.MouseLeave
        TextBox6.Text = ""
    End Sub
    Private Sub CM_btnSK27_MouseHover(sender As Object, e As EventArgs) Handles CM_btnSK27.MouseHover
        cmskmousehover = CM_btnSK27.Text
        getdataCMSK()
    End Sub
    Private Sub CM_btnSK27_MouseLeave(sender As Object, e As EventArgs) Handles CM_btnSK27.MouseLeave
        TextBox6.Text = ""
    End Sub

    'mouse on click
    Private Sub getdataCMSKClick()
        Dim TA As New dbDataSetTableAdapters.CMShortcutKeysTableAdapter
        Dim TB = TA.GetDataByID(cmskmousehover)
        If TB.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim R As dbDataSet.CMShortcutKeysRow = TB.Rows(0)
        RichTextBox4.Text = R.Content
        RichTextBox4.SelectAll()
        RichTextBox4.Copy()
    End Sub
    'mouseclick get data
    Private Sub CM_btnSK1_Click(sender As Object, e As EventArgs) Handles CM_btnSK1.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK2_Click(sender As Object, e As EventArgs) Handles CM_btnSK2.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK10_Click(sender As Object, e As EventArgs) Handles CM_btnSK10.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK4_Click(sender As Object, e As EventArgs) Handles CM_btnSK4.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK19_Click(sender As Object, e As EventArgs) Handles CM_btnSK19.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK11_Click(sender As Object, e As EventArgs) Handles CM_btnSK11.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK20_Click(sender As Object, e As EventArgs) Handles CM_btnSK20.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK8_Click(sender As Object, e As EventArgs) Handles CM_btnSK8.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK13_Click(sender As Object, e As EventArgs) Handles CM_btnSK13.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK22_Click(sender As Object, e As EventArgs) Handles CM_btnSK22.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK3_Click(sender As Object, e As EventArgs) Handles CM_btnSK3.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK17_Click(sender As Object, e As EventArgs) Handles CM_btnSK17.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK26_Click(sender As Object, e As EventArgs) Handles CM_btnSK26.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK24_Click(sender As Object, e As EventArgs) Handles CM_btnSK24.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK12_Click(sender As Object, e As EventArgs) Handles CM_btnSK12.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK21_Click(sender As Object, e As EventArgs) Handles CM_btnSK21.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK16_Click(sender As Object, e As EventArgs) Handles CM_btnSK16.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK25_Click(sender As Object, e As EventArgs) Handles CM_btnSK25.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK7_Click(sender As Object, e As EventArgs) Handles CM_btnSK7.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK14_Click(sender As Object, e As EventArgs) Handles CM_btnSK14.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK23_Click(sender As Object, e As EventArgs) Handles CM_btnSK23.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK9_Click(sender As Object, e As EventArgs) Handles CM_btnSK9.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK18_Click(sender As Object, e As EventArgs) Handles CM_btnSK18.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK27_Click(sender As Object, e As EventArgs) Handles CM_btnSK27.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK6_Click(sender As Object, e As EventArgs) Handles CM_btnSK6.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK15_Click(sender As Object, e As EventArgs) Handles CM_btnSK15.Click
        getdataCMSKClick()
    End Sub
    Private Sub CM_btnSK5_Click(sender As Object, e As EventArgs) Handles CM_btnSK5.Click
        getdataCMSKClick()
    End Sub


    'EMAIL ============================================================================

    'reset all data
    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    'Save file
    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click

        If TextBox3.Text = "" Then
            Exit Sub
        End If
        RichTextBox5.Text = TextBox4.Text
        Dim dateformat As String = DateTime.Now.ToString("MM-dd-yyyy")

        My.Computer.FileSystem.CreateDirectory("Cases\" & dateformat)
        RichTextBox5.SaveFile("Cases\" & dateformat & "\Email_SR" & TextBox3.Text & ".txt", _
        RichTextBoxStreamType.PlainText)

        ConfirmMessage.Label1.Text = "Saved!"
        ConfirmMessage.TextBox1.Text = "Case has been successfully saved at: " & vbNewLine &
                "Cases\" & dateformat & "\SR" & TextBox3.Text & ".txt"
        If ConfirmMessage.ShowDialog() = Windows.Forms.DialogResult.OK Then
            NumericUpDown2.Value = NumericUpDown2.Value + 1
            ConfirmMessage.Close()
            Button20.PerformClick()
            Button19.PerformClick()

        End If
    End Sub

    'open a file
    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim dateformat As String = DateTime.Now.ToString("MM-dd-yyyy")
        If OpenFileDialog1.CheckPathExists <> False Then
            OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.CurrentDirectory & "\Cases\" & dateformat
        Else
            OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.CurrentDirectory & "\Cases\"
        End If

        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            TextViewer.RichTextBox1.AppendText(File.ReadAllText(OpenFileDialog1.FileName))
            TextViewer.ShowDialog()
        End If
    End Sub

    'timer start button
    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Timer1.Start()
        Me.stopwatch.Start()
        Button19.Enabled = False
    End Sub

    'stop timer
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Timer1.Stop()
        Me.stopwatch.Stop()
        Button19.Enabled = True
    End Sub

    'reset timer
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Me.stopwatch.Reset()
        Label12.Text = "00:00:00:000"
    End Sub

    'timer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = Me.stopwatch.Elapsed
        Label12.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", _
        Math.Floor(elapsed.TotalHours), _
        elapsed.Minutes, elapsed.Seconds, _
        elapsed.Milliseconds)
    End Sub

    'start time on sr enter
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text <> "" Then
            Button21.PerformClick()
        End If
    End Sub

    'loaddataonstartup
    Private Sub loaddataforemail()
        Dim TA As New dbemailDSTableAdapters.ProbcatTableAdapter

        If ComboBox5.Text = "" Then
            Exit Sub
        End If

        Dim TB = TA.GetDataByProbcatProduct(ComboBox5.Text, "Antivirus Product")
        Dim R As dbemailDS.ProbcatRow = TB.Rows(0)

        Me.SubcatTableAdapter.FillByProbcatID(Me.DbemailDS.Subcat, R.ID)

        Dim TA2 As New dbemailDSTableAdapters.SubcatTableAdapter
        Dim TB2 = TA2.GetDataByProbcatIDSubcat(R.ID, ComboBox7.Text)
        Dim R2 As dbemailDS.SubcatRow = TB2.Rows(0)

        Me.TemplateTableAdapter.FillBySubcatID(Me.DbemailDS.Template, R2.ID)
    End Sub

    'probcat selected
    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        Dim TA As New dbemailDSTableAdapters.ProbcatTableAdapter

        If ComboBox5.Text = "" Then
            Exit Sub
        End If

        Dim TB = TA.GetDataByProbcatProduct(ComboBox5.Text, "Antivirus Product")
        Dim R As dbemailDS.ProbcatRow = TB.Rows(0)

        Me.SubcatTableAdapter.FillByProbcatID(Me.DbemailDS.Subcat, R.ID)

        Dim TA2 As New dbemailDSTableAdapters.SubcatTableAdapter
        Dim TB2 = TA2.GetDataByProbcatIDSubcat(R.ID, ComboBox7.Text)
        Dim R2 As dbemailDS.SubcatRow = TB2.Rows(0)

        Me.TemplateTableAdapter.FillBySubcatID(Me.DbemailDS.Template, R2.ID)
    End Sub

    'subcat selected
    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        Dim TA As New dbemailDSTableAdapters.ProbcatTableAdapter

        If ComboBox5.Text = "" Then
            Exit Sub
        End If

        Dim TB = TA.GetDataByProbcatProduct(ComboBox5.Text, "Antivirus Product")
        If TB.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim R As dbemailDS.ProbcatRow = TB.Rows(0)

        'Me.SubcatTableAdapter.FillByProbcatID(Me.DbemailDS.Subcat, R.ID)

        Dim TA2 As New dbemailDSTableAdapters.SubcatTableAdapter
        Dim TB2 = TA2.GetDataByProbcatIDSubcat(R.ID, ComboBox7.Text)
        If TB2.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim R2 As dbemailDS.SubcatRow = TB2.Rows(0)

        Me.TemplateTableAdapter.FillBySubcatID(Me.DbemailDS.Template, R2.ID)
    End Sub

    'preview
    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click

        Dim TA As New dbemailDSTableAdapters.ProbcatTableAdapter

        If ComboBox5.Text = "" Then
            Exit Sub
        End If

        Dim TB = TA.GetDataByProbcatProduct(ComboBox5.Text, "Antivirus Product")
        If TB.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim R As dbemailDS.ProbcatRow = TB.Rows(0)

        'Me.SubcatTableAdapter.FillByProbcatID(Me.DbemailDS.Subcat, R.ID)

        Dim TA2 As New dbemailDSTableAdapters.SubcatTableAdapter
        Dim TB2 = TA2.GetDataByProbcatIDSubcat(R.ID, ComboBox7.Text)
        If TB2.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim R2 As dbemailDS.SubcatRow = TB2.Rows(0)
        
        Dim TA3 As New dbemailDSTableAdapters.TemplateTableAdapter
        Dim TB3 = TA3.GetDataBySubcatIDTemplateT(R2.ID, ComboBox6.Text)
        If TB3.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim R3 As dbemailDS.TemplateRow = TB3.Rows(0)

        RichTextBox5.Text = R3.Template

        TextViewer.TextBox1.Text = RichTextBox5.Text
        TextViewer.RichTextBox1.Visible = True
        TextViewer.RichTextBox1.Text = RichTextBox5.Text
        TextViewer.ShowDialog()

    End Sub
End Class
