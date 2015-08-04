Imports System.Windows.Forms

Public Class ManageSolution



    Private Sub ManageSolution_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProbcatTableAdapter.FillByProductID(Me.DBDS.Probcat, "Antivirus Product")
        reloadall()
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

    Private Sub DGVProbcat_MouseClick(sender As Object, e As EventArgs) Handles DGVProbcat.MouseClick
        Dim TA As New DBDSTableAdapters.ProbcatTableAdapter

        If ComboBox1.Text = "" Then
            Exit Sub
        End If

        If DGVProbcat.Rows.Count = 0 Then
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

        Dim TA3 As New DBDSTableAdapters.TemplateTableAdapter
        Dim TB3 = TA3.GetDataBySubcatIDTemplateT(R2.ID, DGVProbcat.SelectedCells(1).Value)
        If TB3.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim R3 As DBDS.TemplateRow = TB3.Rows(0)

        TextBox1.Text = R3.TemplateTitle
        txtbxNotes.Text = R3.Template


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

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

        Dim TA3 As New DBDSTableAdapters.TemplateTableAdapter

        Dim TB3 = TA3.GetDataBySubcatIDTemplateT(R2.ID, TextBox1.Text)
        If TB3.Rows.Count <> 0 Then
            MessageBx.Label1.Text = "Error"
            MessageBx.Label2.Text = "Item already exist"
            If MessageBx.ShowDialog() = Windows.Forms.DialogResult.OK Then
                MessageBx.Close()
            End If
            Exit Sub
        End If

        TA3.Insert(TextBox1.Text, R2.ID, txtbxNotes.Text)
        MessageBx.Label1.Text = "Success"
        MessageBx.Label2.Text = "Item has been successfully added to the database"
        If MessageBx.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MessageBx.Close()
        End If
        reloadtemplate()

    End Sub

    Private Sub reloadtemplate()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim TA As New DBDSTableAdapters.ProbcatTableAdapter

        If ComboBox1.Text = "" Then
            Exit Sub
        End If

        If DGVProbcat.Rows.Count = 0 Then
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

        Dim TA3 As New DBDSTableAdapters.TemplateTableAdapter

        Dim TB3 = TA3.GetDataBySubcatIDTemplateT(R2.ID, DGVProbcat.SelectedCells(1).Value)

        Dim R3 As DBDS.TemplateRow = TB3.Rows(0)

        TA3.UpdateQuerybyTID(TextBox1.Text, R2.ID, txtbxNotes.Text, R3.ID)

        MessageBx.Label1.Text = "Success"
        MessageBx.Label2.Text = "Item has been successfully updated"
            If MessageBx.ShowDialog() = Windows.Forms.DialogResult.OK Then
                MessageBx.Close()
            End If
        reloadtemplate()


    End Sub

    Private Sub DGVProbcat_MouseClick(sender As Object, e As MouseEventArgs) Handles DGVProbcat.MouseClick

    End Sub

    Private Sub DGVProbcat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProbcat.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim TA As New DBDSTableAdapters.ProbcatTableAdapter

        If ComboBox1.Text = "" Then
            Exit Sub
        End If

        If DGVProbcat.Rows.Count = 0 Then
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

        Dim TA3 As New DBDSTableAdapters.TemplateTableAdapter

        Dim TB3 = TA3.GetDataBySubcatIDTemplateT(R2.ID, DGVProbcat.SelectedCells(1).Value)

        Dim R3 As DBDS.TemplateRow = TB3.Rows(0)

        If MsgBox("Are you sure you want to delete this template?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            TA3.DeleteQuerybyID(R3.ID)
        End If

        MessageBx.Label1.Text = "Success"
        MessageBx.Label2.Text = "Item has been successfully deleted"
        If MessageBx.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MessageBx.Close()
        End If
        TextBox1.Text = ""
        txtbxNotes.Text = ""
        reloadtemplate()
    End Sub
End Class
