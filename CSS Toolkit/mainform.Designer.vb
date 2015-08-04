<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainform
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainform))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_sec_break = New System.Windows.Forms.Label()
        Me.lbl_min_break = New System.Windows.Forms.Label()
        Me.btn_break = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_sec_lunch = New System.Windows.Forms.Label()
        Me.lbl_min_lunch = New System.Windows.Forms.Label()
        Me.btn_lunch = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_sec_rest = New System.Windows.Forms.Label()
        Me.lbl_min_rest = New System.Windows.Forms.Label()
        Me.btn_rest = New System.Windows.Forms.Button()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_feedback = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbl_sec_break)
        Me.GroupBox1.Controls.Add(Me.lbl_min_break)
        Me.GroupBox1.Controls.Add(Me.btn_break)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 218)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 50)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Break"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = ":"
        '
        'lbl_sec_break
        '
        Me.lbl_sec_break.AutoSize = True
        Me.lbl_sec_break.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sec_break.Location = New System.Drawing.Point(47, 16)
        Me.lbl_sec_break.Name = "lbl_sec_break"
        Me.lbl_sec_break.Size = New System.Drawing.Size(30, 24)
        Me.lbl_sec_break.TabIndex = 7
        Me.lbl_sec_break.Text = "00"
        '
        'lbl_min_break
        '
        Me.lbl_min_break.AutoSize = True
        Me.lbl_min_break.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_min_break.Location = New System.Drawing.Point(6, 16)
        Me.lbl_min_break.Name = "lbl_min_break"
        Me.lbl_min_break.Size = New System.Drawing.Size(30, 24)
        Me.lbl_min_break.TabIndex = 6
        Me.lbl_min_break.Text = "30"
        '
        'btn_break
        '
        Me.btn_break.BackColor = System.Drawing.Color.Transparent
        Me.btn_break.BackgroundImage = Global.SIR_Toolkit.My.Resources.Resources._1433873769_play_arrow
        Me.btn_break.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_break.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btn_break.FlatAppearance.BorderSize = 0
        Me.btn_break.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btn_break.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_break.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_break.Location = New System.Drawing.Point(83, 19)
        Me.btn_break.Name = "btn_break"
        Me.btn_break.Size = New System.Drawing.Size(20, 20)
        Me.btn_break.TabIndex = 3
        Me.btn_break.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lbl_sec_lunch)
        Me.GroupBox2.Controls.Add(Me.lbl_min_lunch)
        Me.GroupBox2.Controls.Add(Me.btn_lunch)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(148, 218)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(130, 50)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lunch"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = ":"
        '
        'lbl_sec_lunch
        '
        Me.lbl_sec_lunch.AutoSize = True
        Me.lbl_sec_lunch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sec_lunch.Location = New System.Drawing.Point(51, 18)
        Me.lbl_sec_lunch.Name = "lbl_sec_lunch"
        Me.lbl_sec_lunch.Size = New System.Drawing.Size(30, 24)
        Me.lbl_sec_lunch.TabIndex = 7
        Me.lbl_sec_lunch.Text = "00"
        '
        'lbl_min_lunch
        '
        Me.lbl_min_lunch.AutoSize = True
        Me.lbl_min_lunch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_min_lunch.Location = New System.Drawing.Point(11, 18)
        Me.lbl_min_lunch.Name = "lbl_min_lunch"
        Me.lbl_min_lunch.Size = New System.Drawing.Size(30, 24)
        Me.lbl_min_lunch.TabIndex = 6
        Me.lbl_min_lunch.Text = "60"
        '
        'btn_lunch
        '
        Me.btn_lunch.BackColor = System.Drawing.Color.Transparent
        Me.btn_lunch.BackgroundImage = Global.SIR_Toolkit.My.Resources.Resources._1433873769_play_arrow
        Me.btn_lunch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_lunch.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btn_lunch.FlatAppearance.BorderSize = 0
        Me.btn_lunch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btn_lunch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_lunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_lunch.Location = New System.Drawing.Point(84, 20)
        Me.btn_lunch.Name = "btn_lunch"
        Me.btn_lunch.Size = New System.Drawing.Size(20, 20)
        Me.btn_lunch.TabIndex = 3
        Me.btn_lunch.UseVisualStyleBackColor = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.lbl_sec_rest)
        Me.GroupBox3.Controls.Add(Me.lbl_min_rest)
        Me.GroupBox3.Controls.Add(Me.btn_rest)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(284, 218)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(130, 50)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Restroom"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 24)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = ":"
        '
        'lbl_sec_rest
        '
        Me.lbl_sec_rest.AutoSize = True
        Me.lbl_sec_rest.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sec_rest.Location = New System.Drawing.Point(52, 18)
        Me.lbl_sec_rest.Name = "lbl_sec_rest"
        Me.lbl_sec_rest.Size = New System.Drawing.Size(30, 24)
        Me.lbl_sec_rest.TabIndex = 7
        Me.lbl_sec_rest.Text = "00"
        '
        'lbl_min_rest
        '
        Me.lbl_min_rest.AutoSize = True
        Me.lbl_min_rest.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_min_rest.Location = New System.Drawing.Point(12, 18)
        Me.lbl_min_rest.Name = "lbl_min_rest"
        Me.lbl_min_rest.Size = New System.Drawing.Size(30, 24)
        Me.lbl_min_rest.TabIndex = 6
        Me.lbl_min_rest.Text = "15"
        '
        'btn_rest
        '
        Me.btn_rest.BackColor = System.Drawing.Color.Transparent
        Me.btn_rest.BackgroundImage = Global.SIR_Toolkit.My.Resources.Resources._1433873769_play_arrow
        Me.btn_rest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_rest.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btn_rest.FlatAppearance.BorderSize = 0
        Me.btn_rest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btn_rest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_rest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rest.Location = New System.Drawing.Point(85, 20)
        Me.btn_rest.Name = "btn_rest"
        Me.btn_rest.Size = New System.Drawing.Size(20, 20)
        Me.btn_rest.TabIndex = 3
        Me.btn_rest.UseVisualStyleBackColor = False
        '
        'Timer3
        '
        Me.Timer3.Interval = 10
        '
        'Timer4
        '
        Me.Timer4.Interval = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(118, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(197, 24)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "SIR Toolkit 改 (KAI)"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.BackgroundImage = Global.SIR_Toolkit.My.Resources.Resources.SEM2
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button9.Location = New System.Drawing.Point(224, 92)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(100, 100)
        Me.Button9.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.Button9, "SEM")
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.SIR_Toolkit.My.Resources.Resources.AboutUs
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.Location = New System.Drawing.Point(470, 238)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(30, 30)
        Me.Button3.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.Button3, "About Us")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.SIR_Toolkit.My.Resources.Resources.TimeZone2
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Location = New System.Drawing.Point(438, 92)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 100)
        Me.Button2.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.Button2, "Timezone Converter")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_feedback
        '
        Me.btn_feedback.BackColor = System.Drawing.Color.Transparent
        Me.btn_feedback.BackgroundImage = Global.SIR_Toolkit.My.Resources.Resources.Feedback
        Me.btn_feedback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_feedback.FlatAppearance.BorderSize = 0
        Me.btn_feedback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btn_feedback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_feedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_feedback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_feedback.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_feedback.Location = New System.Drawing.Point(506, 238)
        Me.btn_feedback.Name = "btn_feedback"
        Me.btn_feedback.Size = New System.Drawing.Size(30, 30)
        Me.btn_feedback.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.btn_feedback, "Project Diamond")
        Me.btn_feedback.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = Global.SIR_Toolkit.My.Resources.Resources.Hot_Issues2
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button6.Location = New System.Drawing.Point(332, 92)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 100)
        Me.Button6.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.Button6, "Hot Issue")
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = Global.SIR_Toolkit.My.Resources.Resources.Contacts11
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button5.Location = New System.Drawing.Point(118, 92)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 100)
        Me.Button5.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.Button5, "Contacts")
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.SIR_Toolkit.My.Resources.Resources.Notes1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(12, 92)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 100)
        Me.Button1.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.Button1, "SIR Tool")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.BackgroundImage = Global.SIR_Toolkit.My.Resources.Resources.no
        Me.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_close.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Location = New System.Drawing.Point(516, 12)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(20, 20)
        Me.btn_close.TabIndex = 4
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SIR_Toolkit.My.Resources.Resources.Tball
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(321, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 14)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "V 1.4"
        '
        'mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.SIR_Toolkit.My.Resources.Resources.white_wallpaper_14
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(550, 280)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_feedback)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Name = "mainform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIR Toolkit"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_break As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_sec_break As System.Windows.Forms.Label
    Friend WithEvents lbl_min_break As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_sec_lunch As System.Windows.Forms.Label
    Friend WithEvents lbl_min_lunch As System.Windows.Forms.Label
    Friend WithEvents btn_lunch As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_sec_rest As System.Windows.Forms.Label
    Friend WithEvents lbl_min_rest As System.Windows.Forms.Label
    Friend WithEvents btn_rest As System.Windows.Forms.Button
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_feedback As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
