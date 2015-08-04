<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MoreSolution
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
        Me.DbPanel1 = New SIRTool.dbPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_RSh4 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DbPanel2 = New SIRTool.dbPanel()
        Me.DbPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DbPanel1
        '
        Me.DbPanel1.BackColor = System.Drawing.Color.White
        Me.DbPanel1.Controls.Add(Me.Label2)
        Me.DbPanel1.Controls.Add(Me.Label1)
        Me.DbPanel1.Controls.Add(Me.TextBox1)
        Me.DbPanel1.Controls.Add(Me.Button1)
        Me.DbPanel1.Controls.Add(Me.Button2)
        Me.DbPanel1.Controls.Add(Me.btn_RSh4)
        Me.DbPanel1.Controls.Add(Me.ListBox1)
        Me.DbPanel1.Controls.Add(Me.DbPanel2)
        Me.DbPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DbPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DbPanel1.Name = "DbPanel1"
        Me.DbPanel1.Size = New System.Drawing.Size(268, 356)
        Me.DbPanel1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(106, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Solution Templates"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 26)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Note: You  can add more by creating more" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "text file on this link:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBox1
        '
        Me.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox1.Location = New System.Drawing.Point(3, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(262, 20)
        Me.TextBox1.TabIndex = 66
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(4, 323)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 65
        Me.Button1.Text = "View"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(162, 323)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 31)
        Me.Button2.TabIndex = 65
        Me.Button2.Text = "Insert and Close"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_RSh4
        '
        Me.btn_RSh4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_RSh4.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_RSh4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_RSh4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_RSh4.Location = New System.Drawing.Point(80, 323)
        Me.btn_RSh4.Name = "btn_RSh4"
        Me.btn_RSh4.Size = New System.Drawing.Size(81, 31)
        Me.btn_RSh4.TabIndex = 65
        Me.btn_RSh4.Text = "Insert"
        Me.btn_RSh4.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(3, 31)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(262, 251)
        Me.ListBox1.TabIndex = 2
        '
        'DbPanel2
        '
        Me.DbPanel2.BackColor = System.Drawing.Color.Red
        Me.DbPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.DbPanel2.Location = New System.Drawing.Point(0, 0)
        Me.DbPanel2.Name = "DbPanel2"
        Me.DbPanel2.Size = New System.Drawing.Size(268, 3)
        Me.DbPanel2.TabIndex = 1
        '
        'MoreSolution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 356)
        Me.Controls.Add(Me.DbPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MoreSolution"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "MoreSolution"
        Me.TopMost = True
        Me.DbPanel1.ResumeLayout(False)
        Me.DbPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DbPanel1 As SIRTool.dbPanel
    Friend WithEvents DbPanel2 As SIRTool.dbPanel
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btn_RSh4 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
