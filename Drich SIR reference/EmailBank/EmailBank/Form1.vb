Public Class Form1

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbDataSet.SR' table. You can move, or remove it, as needed.
        Me.SRTableAdapter.Fill(Me.DbDataSet.SR)
        'TODO: This line of code loads data into the 'DbDataSet.EmailTemplates' table. You can move, or remove it, as needed.
        Me.EmailTemplatesTableAdapter.Fill(Me.DbDataSet.EmailTemplates)
        'TODO: This line of code loads data into the 'DbDataSet.EmailCategory' table. You can move, or remove it, as needed.
        cmbbxEmailCat.Text = "All"
        Timer1.Start()

        Dim TA As New dbDataSetTableAdapters.SRTableAdapter
        TA.FillByShiftDate(DbDataSet.SR, DateTimePicker1.Value.Date)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim TA As New dbDataSetTableAdapters.SRTableAdapter
        TA.FillByDateSaved(DbDataSet.SR, DateTimePicker1.Value.Date)
        lblDate.Text = DateAndTime.Now
        Label7.Text = DataGridView1.Rows.Count.ToString + " Email Processed Today"
        If DGV.Rows.Count = 0 Then
            RichTextBox1.Clear()
        End If

    End Sub

    Private Sub cmbbxEmailCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxEmailCat.SelectedIndexChanged
        Dim TA As New dbDataSetTableAdapters.EmailTemplatesTableAdapter
        If cmbbxEmailCat.Text = "All" Then
            Me.EmailTemplatesTableAdapter.Fill(Me.DbDataSet.EmailTemplates)
            Exit Sub
        End If

        TA.FillByCategory(DbDataSet.EmailTemplates, cmbbxEmailCat.Text)

    End Sub

    Private Sub DGV_MouseClick(sender As Object, e As MouseEventArgs) Handles DGV.MouseClick

        Dim TA As New dbDataSetTableAdapters.EmailTemplatesTableAdapter
        If DGV.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim TB = TA.GetDataByID(DGV.SelectedCells(0).Value.ToString)
        If TB.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim R As dbDataSet.EmailTemplatesRow = TB.Rows(0)

        RichTextBox1.Text = R.Email

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


        s.Text = Val(s.Text) + Val(1)
        If s.Text = 60 Then
            m.Text = Val(m.Text) + Val(1)
            s.Text = 0
        End If
    End Sub

    Private Sub txtbxSR_TextChanged(sender As Object, e As EventArgs) Handles txtbxSR.TextChanged
        Timer2.Start()
    End Sub

    Private Sub btnSR_Stop_Click(sender As Object, e As EventArgs) Handles btnSR_Stop.Click

        Dim ET As String = DGV.SelectedCells(1).Value.ToString

        If txtbxSR.Text = "" Then
            MsgBox("Please provide SR Number", MsgBoxStyle.OkOnly, "Cannot be Saved")
            Exit Sub
        End If

        If DGV.Rows.Count = 0 Then
            ET = ""
        End If

        If MsgBox("Are you Done?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim TA As New dbDataSetTableAdapters.SRTableAdapter
        Dim aht As String

        aht = m.Text + " min " + s.Text + " sec "

        TA.Insert(txtbxSR.Text, lblDate.Text, ET, aht, DateTimePicker1.Value.Date)

        Timer2.Stop()
        btnSR_Stop.BackColor = Color.LightGreen

    End Sub

    Private Sub btnSR_New_Click(sender As Object, e As EventArgs) Handles btnSR_New.Click
        m.Text = 0
        s.Text = 0
        btnSR_Stop.BackColor = Color.DarkSlateGray
        txtbxSR.Clear()
        Timer2.Stop()

    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        RichTextBox1.SelectAll()
        RichTextBox1.Copy()
    End Sub

    Private Sub b_Click(sender As Object, e As EventArgs) Handles b.Click
        If Editor.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim TA As New dbDataSetTableAdapters.EmailTemplatesTableAdapter
            If cmbbxEmailCat.Text = "All" Then
                Me.EmailTemplatesTableAdapter.Fill(Me.DbDataSet.EmailTemplates)
            Else
                TA.FillByCategory(DbDataSet.EmailTemplates, cmbbxEmailCat.Text)
            End If


            Editor.TextBox1.Clear()
            Editor.RichTextBox1.Clear()

        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Updater.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim TA As New dbDataSetTableAdapters.EmailTemplatesTableAdapter
            If cmbbxEmailCat.Text = "All" Then
                Me.EmailTemplatesTableAdapter.Fill(Me.DbDataSet.EmailTemplates)
            Else
                TA.FillByCategory(DbDataSet.EmailTemplates, cmbbxEmailCat.Text)
            End If

            Updater.TextBox1.Clear()
            Updater.RichTextBox1.Clear()

        End If


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim TA As New dbDataSetTableAdapters.EmailTemplatesTableAdapter
        If MsgBox("Are you sure you want to delete this template?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            TA.DeleteQuerybyID(DGV.SelectedCells(0).Value.ToString)
            If cmbbxEmailCat.Text = "All" Then
                Me.EmailTemplatesTableAdapter.Fill(Me.DbDataSet.EmailTemplates)
            Else
                TA.FillByCategory(DbDataSet.EmailTemplates, cmbbxEmailCat.Text)
            End If
            RichTextBox1.Clear()
        End If
    End Sub

    Private Sub btnSR_VR_Click(sender As Object, e As EventArgs) Handles btnSR_VR.Click
        If ViewSR.ShowDialog = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If
    End Sub

    Private Sub btnEmailSearch_Click(sender As Object, e As EventArgs) Handles btnEmailSearch.Click
        Dim TA As New dbDataSetTableAdapters.EmailTemplatesTableAdapter
        If cmbbxEmailCat.Text <> "All" Then
            TA.FillByEmailSearching(DbDataSet.EmailTemplates, txtbxEmailSearch.Text, cmbbxEmailCat.Text)
        Else
            TA.FillByEmailTitle(DbDataSet.EmailTemplates, txtbxEmailSearch.Text)
        End If

        'If txtbxEmailSearch.TextLength > 0 Then
        '    Me.EmailTemplatesBindingSource.Filter = _
        '        String.Format("Register EmailTitle Like '%" & txtbxEmailSearch.Text & "%'")
        'Else
        '    Me.EmailTemplatesBindingSource.Filter = String.Empty

        'End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub txtbxEmailSearch_TextChanged(sender As Object, e As EventArgs) Handles txtbxEmailSearch.TextChanged
  
    End Sub

   
End Class
