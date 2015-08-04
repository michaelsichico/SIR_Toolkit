Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SaveCommand.Click
        Dim failinimi As String = "C:\MyData.txt"
3:
    Public Property nimi() As String
04
	        Get
05
	            Return failinimi
06
	        End Get
07
	        Set(ByVal value As String)
08
	            failinimi = value
09
	        End Set
10
	    End Property
11
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
12:
        Try
13:
            Me.MainText1.Text = My.Computer.FileSystem.ReadAllText(failinimi)
14:
        Catch ex As IO.FileNotFoundException
15:
            Me.MainText1.Text = ""
16:
        End Try
17:
    End Sub
18
    Private Sub SaveCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveCommand.Click
19:
        Try
20:
            My.Computer.FileSystem.WriteAllText(failinimi, Me.MainText1.Text, False)
21:
        Catch ex As IO.IOException
22:
            Me.Note.Text = "Error occurred"
23:
        End Try
24:

25:
        Me.Note.Text = "Data has been saved"
26:
    End Sub
27

28
    Private Sub MainText1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainText1.TextChanged
29:
        Me.Note.Text = Len(MainText1.Text) & " characters."
30:
    End Sub
End Class
