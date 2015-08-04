Imports System.Windows.Forms

Public Class ViewSR



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim TA As New dbDataSetTableAdapters.SRTableAdapter
        TA.FillBySR(DbDataSet.SR, TextBox1.Text)
    End Sub

    Private Sub ViewSR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbDataSet.SR' table. You can move, or remove it, as needed.
        'Me.SRTableAdapter.Fill(Me.DbDataSet.SR)
        Dim TA As New dbDataSetTableAdapters.SRTableAdapter
        TA.FillByDateSaved(DbDataSet.SR, DateTimePicker1.Value.Date)
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim TA As New dbDataSetTableAdapters.SRTableAdapter

        TA.FillByDateSaved(DbDataSet.SR, DateTimePicker1.Value.Date)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = DGV.Rows.Count.ToString + " Email Processed Today"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim TA As New dbDataSetTableAdapters.SRTableAdapter
        TA.FillByDateSaved(DbDataSet.SR, DateTimePicker1.Value.Date)
        TextBox1.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim TA As New dbDataSetTableAdapters.SRTableAdapter
            TA.FillByDateSaved(DbDataSet.SR, DateTimePicker1.Value.Date)
            TA.DeleteQueryByID(DGV.SelectedCells(0).Value)
            TA.FillByDateSaved(DbDataSet.SR, DateTimePicker1.Value.Date)
        Else : Exit Sub
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
