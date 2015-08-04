<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MainText1 = New System.Windows.Forms.RichTextBox()
        Me.SaveCommand = New System.Windows.Forms.Button()
        Me.Note = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MainText1
        '
        Me.MainText1.Location = New System.Drawing.Point(44, 104)
        Me.MainText1.Name = "MainText1"
        Me.MainText1.Size = New System.Drawing.Size(136, 28)
        Me.MainText1.TabIndex = 0
        Me.MainText1.Text = ""
        '
        'SaveCommand
        '
        Me.SaveCommand.Location = New System.Drawing.Point(77, 156)
        Me.SaveCommand.Name = "SaveCommand"
        Me.SaveCommand.Size = New System.Drawing.Size(116, 26)
        Me.SaveCommand.TabIndex = 1
        Me.SaveCommand.Text = "Save"
        Me.SaveCommand.UseVisualStyleBackColor = True
        '
        'Note
        '
        Me.Note.AutoSize = True
        Me.Note.Location = New System.Drawing.Point(49, 84)
        Me.Note.Name = "Note"
        Me.Note.Size = New System.Drawing.Size(30, 13)
        Me.Note.TabIndex = 2
        Me.Note.Text = "Note"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 302)
        Me.Controls.Add(Me.Note)
        Me.Controls.Add(Me.SaveCommand)
        Me.Controls.Add(Me.MainText1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainText1 As System.Windows.Forms.RichTextBox
    Friend WithEvents SaveCommand As System.Windows.Forms.Button
    Friend WithEvents Note As System.Windows.Forms.Label

End Class
