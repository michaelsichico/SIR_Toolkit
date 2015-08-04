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
        Me.components = New System.ComponentModel.Container()
        Me.ProbcatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBDS = New SIRTool.DBDS()
        Me.TemplateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubcatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PCEBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBEDS = New SIRTool.DBEDS()
        Me.ProbcatTableAdapter = New SIRTool.DBDSTableAdapters.ProbcatTableAdapter()
        Me.SubcatTableAdapter = New SIRTool.DBDSTableAdapters.SubcatTableAdapter()
        Me.TemplateTableAdapter = New SIRTool.DBDSTableAdapters.TemplateTableAdapter()
        Me.DBEDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProbcatTableAdapter1 = New SIRTool.DBEDSTableAdapters.ProbcatTableAdapter()
        Me.SubcatTableAdapter1 = New SIRTool.DBEDSTableAdapters.SubcatTableAdapter()
        Me.TemplateTableAdapter1 = New SIRTool.DBEDSTableAdapters.TemplateTableAdapter()
        Me.SCEBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.TEBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotesTableAdapter1 = New SIRTool.DBDSTableAdapters.NotesTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DbPanel1 = New SIRTool.dbPanel()
        Me.m2 = New System.Windows.Forms.NumericUpDown()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rdbtnSSTS = New System.Windows.Forms.RadioButton()
        Me.rdbtnSSPOP = New System.Windows.Forms.RadioButton()
        Me.rd = New System.Windows.Forms.RadioButton()
        Me.s2 = New System.Windows.Forms.Label()
        Me.Button41 = New System.Windows.Forms.Button()
        Me.DbPanel3 = New SIRTool.dbPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button38 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.txtbxSR = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.txtbxNotes = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rdbtnPSN = New System.Windows.Forms.RadioButton()
        Me.rdbtnPSY = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbtnFCN = New System.Windows.Forms.RadioButton()
        Me.rdbtnFCY = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbxSN = New System.Windows.Forms.TextBox()
        Me.txtbxON = New System.Windows.Forms.TextBox()
        Me.txtbxEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbxClientname = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.DbPanel2 = New SIRTool.dbPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button44 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button46 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button45 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button43 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button47 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button39 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.DbPanel5 = New SIRTool.dbPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button42 = New System.Windows.Forms.Button()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.DbPanel6 = New SIRTool.dbPanel()
        Me.Button40 = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Button32 = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Button33 = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Button34 = New System.Windows.Forms.Button()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button35 = New System.Windows.Forms.Button()
        Me.Button36 = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button37 = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.DbPanel4 = New SIRTool.dbPanel()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ProbcatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TemplateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubcatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCEBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBEDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBEDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCEBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.DbPanel1.SuspendLayout()
        CType(Me.m2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.DbPanel3.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.DbPanel2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.DbPanel5.SuspendLayout()
        Me.DbPanel6.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProbcatBindingSource
        '
        Me.ProbcatBindingSource.DataMember = "Probcat"
        Me.ProbcatBindingSource.DataSource = Me.DBDS
        '
        'DBDS
        '
        Me.DBDS.DataSetName = "DBDS"
        Me.DBDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TemplateBindingSource
        '
        Me.TemplateBindingSource.DataMember = "Template"
        Me.TemplateBindingSource.DataSource = Me.DBDS
        '
        'SubcatBindingSource
        '
        Me.SubcatBindingSource.DataMember = "Subcat"
        Me.SubcatBindingSource.DataSource = Me.DBDS
        '
        'PCEBS
        '
        Me.PCEBS.DataMember = "Probcat"
        Me.PCEBS.DataSource = Me.DBEDS
        '
        'DBEDS
        '
        Me.DBEDS.DataSetName = "DBEDS"
        Me.DBEDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProbcatTableAdapter
        '
        Me.ProbcatTableAdapter.ClearBeforeFill = True
        '
        'SubcatTableAdapter
        '
        Me.SubcatTableAdapter.ClearBeforeFill = True
        '
        'TemplateTableAdapter
        '
        Me.TemplateTableAdapter.ClearBeforeFill = True
        '
        'DBEDSBindingSource
        '
        Me.DBEDSBindingSource.DataSource = Me.DBEDS
        Me.DBEDSBindingSource.Position = 0
        '
        'ProbcatTableAdapter1
        '
        Me.ProbcatTableAdapter1.ClearBeforeFill = True
        '
        'SubcatTableAdapter1
        '
        Me.SubcatTableAdapter1.ClearBeforeFill = True
        '
        'TemplateTableAdapter1
        '
        Me.TemplateTableAdapter1.ClearBeforeFill = True
        '
        'SCEBS
        '
        Me.SCEBS.DataMember = "Subcat"
        Me.SCEBS.DataSource = Me.DBEDS
        '
        'TEBS
        '
        Me.TEBS.DataMember = "Template"
        Me.TEBS.DataSource = Me.DBEDS
        '
        'NotesTableAdapter1
        '
        Me.NotesTableAdapter1.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(355, 728)
        Me.TabControl2.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DbPanel1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(347, 702)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Phone"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DbPanel1
        '
        Me.DbPanel1.BackColor = System.Drawing.Color.White
        Me.DbPanel1.Controls.Add(Me.m2)
        Me.DbPanel1.Controls.Add(Me.Label30)
        Me.DbPanel1.Controls.Add(Me.Label21)
        Me.DbPanel1.Controls.Add(Me.ProgressBar1)
        Me.DbPanel1.Controls.Add(Me.GroupBox6)
        Me.DbPanel1.Controls.Add(Me.s2)
        Me.DbPanel1.Controls.Add(Me.Button41)
        Me.DbPanel1.Controls.Add(Me.DbPanel3)
        Me.DbPanel1.Controls.Add(Me.RichTextBox1)
        Me.DbPanel1.Controls.Add(Me.txtbxSR)
        Me.DbPanel1.Controls.Add(Me.Label6)
        Me.DbPanel1.Controls.Add(Me.SplitContainer1)
        Me.DbPanel1.Controls.Add(Me.Button2)
        Me.DbPanel1.Controls.Add(Me.GroupBox3)
        Me.DbPanel1.Controls.Add(Me.GroupBox1)
        Me.DbPanel1.Controls.Add(Me.Label31)
        Me.DbPanel1.Controls.Add(Me.Label17)
        Me.DbPanel1.Controls.Add(Me.Label32)
        Me.DbPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DbPanel1.Location = New System.Drawing.Point(3, 3)
        Me.DbPanel1.Name = "DbPanel1"
        Me.DbPanel1.Size = New System.Drawing.Size(341, 696)
        Me.DbPanel1.TabIndex = 0
        '
        'm2
        '
        Me.m2.Location = New System.Drawing.Point(221, 269)
        Me.m2.Name = "m2"
        Me.m2.Size = New System.Drawing.Size(52, 20)
        Me.m2.TabIndex = 24
        Me.m2.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(178, 261)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(13, 13)
        Me.Label30.TabIndex = 23
        Me.Label30.Text = "0"
        Me.Label30.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(152, 261)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(13, 13)
        Me.Label21.TabIndex = 23
        Me.Label21.Text = "0"
        Me.Label21.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(13, 274)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(200, 10)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 18
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rdbtnSSTS)
        Me.GroupBox6.Controls.Add(Me.rdbtnSSPOP)
        Me.GroupBox6.Controls.Add(Me.rd)
        Me.GroupBox6.Location = New System.Drawing.Point(197, 233)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(134, 31)
        Me.GroupBox6.TabIndex = 17
        Me.GroupBox6.TabStop = False
        '
        'rdbtnSSTS
        '
        Me.rdbtnSSTS.AutoSize = True
        Me.rdbtnSSTS.ForeColor = System.Drawing.Color.Black
        Me.rdbtnSSTS.Location = New System.Drawing.Point(8, 10)
        Me.rdbtnSSTS.Name = "rdbtnSSTS"
        Me.rdbtnSSTS.Size = New System.Drawing.Size(39, 17)
        Me.rdbtnSSTS.TabIndex = 0
        Me.rdbtnSSTS.TabStop = True
        Me.rdbtnSSTS.Text = "TS"
        Me.rdbtnSSTS.UseVisualStyleBackColor = True
        '
        'rdbtnSSPOP
        '
        Me.rdbtnSSPOP.AutoSize = True
        Me.rdbtnSSPOP.ForeColor = System.Drawing.Color.Black
        Me.rdbtnSSPOP.Location = New System.Drawing.Point(85, 10)
        Me.rdbtnSSPOP.Name = "rdbtnSSPOP"
        Me.rdbtnSSPOP.Size = New System.Drawing.Size(47, 17)
        Me.rdbtnSSPOP.TabIndex = 0
        Me.rdbtnSSPOP.TabStop = True
        Me.rdbtnSSPOP.Text = "POP"
        Me.rdbtnSSPOP.UseVisualStyleBackColor = True
        '
        'rd
        '
        Me.rd.AutoSize = True
        Me.rd.ForeColor = System.Drawing.Color.Black
        Me.rd.Location = New System.Drawing.Point(47, 10)
        Me.rd.Name = "rd"
        Me.rd.Size = New System.Drawing.Size(39, 17)
        Me.rd.TabIndex = 0
        Me.rd.TabStop = True
        Me.rd.Text = "CS"
        Me.rd.UseVisualStyleBackColor = True
        '
        's2
        '
        Me.s2.AutoSize = True
        Me.s2.BackColor = System.Drawing.Color.Transparent
        Me.s2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.s2.Location = New System.Drawing.Point(246, 271)
        Me.s2.Name = "s2"
        Me.s2.Size = New System.Drawing.Size(20, 16)
        Me.s2.TabIndex = 2
        Me.s2.Text = "00"
        '
        'Button41
        '
        Me.Button41.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button41.BackColor = System.Drawing.Color.SeaGreen
        Me.Button41.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button41.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button41.Location = New System.Drawing.Point(279, 267)
        Me.Button41.Name = "Button41"
        Me.Button41.Size = New System.Drawing.Size(52, 24)
        Me.Button41.TabIndex = 22
        Me.Button41.Text = "Hold"
        Me.Button41.UseVisualStyleBackColor = False
        '
        'DbPanel3
        '
        Me.DbPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DbPanel3.Controls.Add(Me.Label1)
        Me.DbPanel3.Controls.Add(Me.Label16)
        Me.DbPanel3.Controls.Add(Me.Button14)
        Me.DbPanel3.Controls.Add(Me.Button13)
        Me.DbPanel3.Controls.Add(Me.Button38)
        Me.DbPanel3.Controls.Add(Me.Button1)
        Me.DbPanel3.Controls.Add(Me.Button8)
        Me.DbPanel3.Controls.Add(Me.Button3)
        Me.DbPanel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DbPanel3.Location = New System.Drawing.Point(0, 3)
        Me.DbPanel3.Name = "DbPanel3"
        Me.DbPanel3.Size = New System.Drawing.Size(341, 62)
        Me.DbPanel3.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SIR Tool"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(233, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 21)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "00:00:00:000"
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.Gray
        Me.Button14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button14.Location = New System.Drawing.Point(299, 42)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(30, 5)
        Me.Button14.TabIndex = 7
        Me.Button14.Text = "Save"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.Gray
        Me.Button13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button13.Location = New System.Drawing.Point(268, 42)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(30, 5)
        Me.Button13.TabIndex = 7
        Me.Button13.Text = "Save"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button38
        '
        Me.Button38.BackColor = System.Drawing.Color.Firebrick
        Me.Button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button38.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button38.Location = New System.Drawing.Point(152, 30)
        Me.Button38.Name = "Button38"
        Me.Button38.Size = New System.Drawing.Size(71, 26)
        Me.Button38.TabIndex = 7
        Me.Button38.Text = "Open"
        Me.Button38.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(80, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 26)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Gray
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button8.Location = New System.Drawing.Point(236, 42)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(30, 5)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Save"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Firebrick
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(8, 30)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(71, 26)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "New"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(279, 644)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(48, 21)
        Me.RichTextBox1.TabIndex = 17
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        '
        'txtbxSR
        '
        Me.txtbxSR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSR.Location = New System.Drawing.Point(38, 240)
        Me.txtbxSR.Name = "txtbxSR"
        Me.txtbxSR.Size = New System.Drawing.Size(153, 22)
        Me.txtbxSR.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(13, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "SR:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(15, 313)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtbxNotes)
        Me.SplitContainer1.Size = New System.Drawing.Size(314, 321)
        Me.SplitContainer1.SplitterDistance = 153
        Me.SplitContainer1.TabIndex = 16
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(314, 153)
        Me.TabControl1.TabIndex = 15
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Button7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.ComboBox3)
        Me.TabPage2.Controls.Add(Me.ComboBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(306, 127)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Solutions"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ProbcatBindingSource
        Me.ComboBox1.DisplayMember = "Probcat"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(86, 10)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(206, 21)
        Me.ComboBox1.TabIndex = 18
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button6.BackColor = System.Drawing.Color.SteelBlue
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button6.Location = New System.Drawing.Point(9, 93)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(127, 28)
        Me.Button6.TabIndex = 21
        Me.Button6.Text = "Manage Templates"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(6, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Prob Category:"
        '
        'Button7
        '
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button7.BackColor = System.Drawing.Color.SteelBlue
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button7.Location = New System.Drawing.Point(138, 93)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(82, 28)
        Me.Button7.TabIndex = 22
        Me.Button7.Text = "Clear"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(6, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Sub Category:"
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button5.BackColor = System.Drawing.Color.SteelBlue
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.Location = New System.Drawing.Point(222, 93)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 28)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Insert"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(6, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Template:"
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.TemplateBindingSource
        Me.ComboBox3.DisplayMember = "TemplateTitle"
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(86, 64)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(206, 21)
        Me.ComboBox3.TabIndex = 19
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.SubcatBindingSource
        Me.ComboBox2.DisplayMember = "Subcat"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(86, 37)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(206, 21)
        Me.ComboBox2.TabIndex = 20
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TextBox7)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Button9)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.ComboBox4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(306, 127)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Notes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TextBox7.Location = New System.Drawing.Point(9, 32)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(288, 58)
        Me.TextBox7.TabIndex = 31
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.SteelBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(88, 94)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 28)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "Manage Notes"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button9.BackColor = System.Drawing.Color.SteelBlue
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button9.Location = New System.Drawing.Point(219, 94)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 28)
        Me.Button9.TabIndex = 30
        Me.Button9.Text = "Insert"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(6, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Notes Title:"
        '
        'ComboBox4
        '
        Me.ComboBox4.DataSource = Me.DBDS
        Me.ComboBox4.DisplayMember = "Notes.NoteTitle"
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(68, 6)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(226, 21)
        Me.ComboBox4.TabIndex = 26
        '
        'txtbxNotes
        '
        Me.txtbxNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxNotes.Location = New System.Drawing.Point(0, 0)
        Me.txtbxNotes.Multiline = True
        Me.txtbxNotes.Name = "txtbxNotes"
        Me.txtbxNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtbxNotes.Size = New System.Drawing.Size(314, 164)
        Me.txtbxNotes.TabIndex = 12
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.Window
        Me.Button2.Location = New System.Drawing.Point(11, 643)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(320, 47)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Copy to Clipboard"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox3.Location = New System.Drawing.Point(11, 289)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(320, 345)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resolution:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(211, 8)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(101, 13)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Template Generator"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtbxSN)
        Me.GroupBox1.Controls.Add(Me.txtbxON)
        Me.GroupBox1.Controls.Add(Me.txtbxEmail)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtbxClientname)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox1.Location = New System.Drawing.Point(11, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 162)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entitlement"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rdbtnPSN)
        Me.GroupBox4.Controls.Add(Me.rdbtnPSY)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Location = New System.Drawing.Point(186, 121)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(115, 35)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        '
        'rdbtnPSN
        '
        Me.rdbtnPSN.AutoSize = True
        Me.rdbtnPSN.ForeColor = System.Drawing.Color.Black
        Me.rdbtnPSN.Location = New System.Drawing.Point(74, 12)
        Me.rdbtnPSN.Name = "rdbtnPSN"
        Me.rdbtnPSN.Size = New System.Drawing.Size(39, 17)
        Me.rdbtnPSN.TabIndex = 0
        Me.rdbtnPSN.TabStop = True
        Me.rdbtnPSN.Text = "No"
        Me.rdbtnPSN.UseVisualStyleBackColor = True
        '
        'rdbtnPSY
        '
        Me.rdbtnPSY.AutoSize = True
        Me.rdbtnPSY.ForeColor = System.Drawing.Color.Black
        Me.rdbtnPSY.Location = New System.Drawing.Point(33, 12)
        Me.rdbtnPSY.Name = "rdbtnPSY"
        Me.rdbtnPSY.Size = New System.Drawing.Size(43, 17)
        Me.rdbtnPSY.TabIndex = 0
        Me.rdbtnPSY.TabStop = True
        Me.rdbtnPSY.Text = "Yes"
        Me.rdbtnPSY.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(5, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 13)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "PS:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbtnFCN)
        Me.GroupBox2.Controls.Add(Me.rdbtnFCY)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(165, 35)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'rdbtnFCN
        '
        Me.rdbtnFCN.AutoSize = True
        Me.rdbtnFCN.ForeColor = System.Drawing.Color.Black
        Me.rdbtnFCN.Location = New System.Drawing.Point(120, 12)
        Me.rdbtnFCN.Name = "rdbtnFCN"
        Me.rdbtnFCN.Size = New System.Drawing.Size(39, 17)
        Me.rdbtnFCN.TabIndex = 0
        Me.rdbtnFCN.TabStop = True
        Me.rdbtnFCN.Text = "No"
        Me.rdbtnFCN.UseVisualStyleBackColor = True
        '
        'rdbtnFCY
        '
        Me.rdbtnFCY.AutoSize = True
        Me.rdbtnFCY.ForeColor = System.Drawing.Color.Black
        Me.rdbtnFCY.Location = New System.Drawing.Point(79, 12)
        Me.rdbtnFCY.Name = "rdbtnFCY"
        Me.rdbtnFCY.Size = New System.Drawing.Size(43, 17)
        Me.rdbtnFCY.TabIndex = 0
        Me.rdbtnFCY.TabStop = True
        Me.rdbtnFCY.Text = "Yes"
        Me.rdbtnFCY.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(6, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "First Contact:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(17, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Serial Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(17, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Order Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(17, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Email Address:"
        '
        'txtbxSN
        '
        Me.txtbxSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSN.Location = New System.Drawing.Point(95, 72)
        Me.txtbxSN.Name = "txtbxSN"
        Me.txtbxSN.Size = New System.Drawing.Size(206, 22)
        Me.txtbxSN.TabIndex = 10
        '
        'txtbxON
        '
        Me.txtbxON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxON.Location = New System.Drawing.Point(95, 98)
        Me.txtbxON.Name = "txtbxON"
        Me.txtbxON.Size = New System.Drawing.Size(206, 22)
        Me.txtbxON.TabIndex = 10
        '
        'txtbxEmail
        '
        Me.txtbxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEmail.Location = New System.Drawing.Point(95, 46)
        Me.txtbxEmail.Name = "txtbxEmail"
        Me.txtbxEmail.Size = New System.Drawing.Size(206, 22)
        Me.txtbxEmail.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(17, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Client Name:"
        '
        'txtbxClientname
        '
        Me.txtbxClientname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxClientname.Location = New System.Drawing.Point(95, 20)
        Me.txtbxClientname.Name = "txtbxClientname"
        Me.txtbxClientname.Size = New System.Drawing.Size(206, 22)
        Me.txtbxClientname.TabIndex = 10
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label31.Location = New System.Drawing.Point(264, 271)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(12, 16)
        Me.Label31.TabIndex = 2
        Me.Label31.Text = "s"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(234, 271)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(18, 16)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "m"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label32.Location = New System.Drawing.Point(219, 271)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(20, 16)
        Me.Label32.TabIndex = 2
        Me.Label32.Text = "00"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.DbPanel2)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(347, 702)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Chat"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'DbPanel2
        '
        Me.DbPanel2.BackColor = System.Drawing.Color.White
        Me.DbPanel2.Controls.Add(Me.Label12)
        Me.DbPanel2.Controls.Add(Me.Button18)
        Me.DbPanel2.Controls.Add(Me.Label10)
        Me.DbPanel2.Controls.Add(Me.Button19)
        Me.DbPanel2.Controls.Add(Me.GroupBox7)
        Me.DbPanel2.Controls.Add(Me.GroupBox5)
        Me.DbPanel2.Controls.Add(Me.Button20)
        Me.DbPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DbPanel2.Location = New System.Drawing.Point(3, 3)
        Me.DbPanel2.Name = "DbPanel2"
        Me.DbPanel2.Size = New System.Drawing.Size(341, 696)
        Me.DbPanel2.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(225, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 21)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "00:00:00:000"
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.Gray
        Me.Button18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button18.Location = New System.Drawing.Point(292, 29)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(30, 5)
        Me.Button18.TabIndex = 23
        Me.Button18.Text = "Save"
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.Label10.Location = New System.Drawing.Point(8, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 24)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Chat Tool"
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.Gray
        Me.Button19.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button19.Location = New System.Drawing.Point(261, 29)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(30, 5)
        Me.Button19.TabIndex = 24
        Me.Button19.Text = "Save"
        Me.Button19.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Button26)
        Me.GroupBox7.Controls.Add(Me.Button24)
        Me.GroupBox7.Controls.Add(Me.Button25)
        Me.GroupBox7.Controls.Add(Me.Button44)
        Me.GroupBox7.Controls.Add(Me.Button23)
        Me.GroupBox7.Controls.Add(Me.Button46)
        Me.GroupBox7.Controls.Add(Me.Button22)
        Me.GroupBox7.Controls.Add(Me.Button45)
        Me.GroupBox7.Controls.Add(Me.Button21)
        Me.GroupBox7.Controls.Add(Me.Button43)
        Me.GroupBox7.Controls.Add(Me.Button17)
        Me.GroupBox7.Controls.Add(Me.Button16)
        Me.GroupBox7.Controls.Add(Me.Button15)
        Me.GroupBox7.Controls.Add(Me.Button12)
        Me.GroupBox7.Location = New System.Drawing.Point(3, 39)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(331, 173)
        Me.GroupBox7.TabIndex = 20
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Spiels"
        '
        'Button26
        '
        Me.Button26.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button26.BackColor = System.Drawing.Color.SteelBlue
        Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button26.ForeColor = System.Drawing.SystemColors.Window
        Me.Button26.Location = New System.Drawing.Point(113, 103)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(48, 28)
        Me.Button26.TabIndex = 21
        Me.Button26.Text = "Prb2"
        Me.Button26.UseVisualStyleBackColor = False
        '
        'Button24
        '
        Me.Button24.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button24.BackColor = System.Drawing.Color.SteelBlue
        Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button24.ForeColor = System.Drawing.SystemColors.Window
        Me.Button24.Location = New System.Drawing.Point(66, 103)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(48, 28)
        Me.Button24.TabIndex = 21
        Me.Button24.Text = "Prb2"
        Me.Button24.UseVisualStyleBackColor = False
        '
        'Button25
        '
        Me.Button25.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button25.BackColor = System.Drawing.Color.SteelBlue
        Me.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button25.ForeColor = System.Drawing.SystemColors.Window
        Me.Button25.Location = New System.Drawing.Point(19, 103)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(48, 28)
        Me.Button25.TabIndex = 21
        Me.Button25.Text = "Prbe1"
        Me.Button25.UseVisualStyleBackColor = False
        '
        'Button44
        '
        Me.Button44.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button44.BackColor = System.Drawing.Color.SteelBlue
        Me.Button44.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button44.ForeColor = System.Drawing.SystemColors.Window
        Me.Button44.Location = New System.Drawing.Point(240, 19)
        Me.Button44.Name = "Button44"
        Me.Button44.Size = New System.Drawing.Size(73, 28)
        Me.Button44.TabIndex = 21
        Me.Button44.Text = "NR A"
        Me.Button44.UseVisualStyleBackColor = False
        '
        'Button23
        '
        Me.Button23.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button23.BackColor = System.Drawing.Color.SteelBlue
        Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button23.ForeColor = System.Drawing.SystemColors.Window
        Me.Button23.Location = New System.Drawing.Point(170, 19)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(70, 28)
        Me.Button23.TabIndex = 21
        Me.Button23.Text = "NR A"
        Me.Button23.UseVisualStyleBackColor = False
        '
        'Button46
        '
        Me.Button46.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button46.BackColor = System.Drawing.Color.Gray
        Me.Button46.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button46.ForeColor = System.Drawing.SystemColors.Window
        Me.Button46.Location = New System.Drawing.Point(170, 131)
        Me.Button46.Name = "Button46"
        Me.Button46.Size = New System.Drawing.Size(143, 28)
        Me.Button46.TabIndex = 21
        Me.Button46.Text = "Manage  Spiels"
        Me.Button46.UseVisualStyleBackColor = False
        '
        'Button22
        '
        Me.Button22.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button22.BackColor = System.Drawing.Color.SteelBlue
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button22.ForeColor = System.Drawing.SystemColors.Window
        Me.Button22.Location = New System.Drawing.Point(170, 103)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(143, 28)
        Me.Button22.TabIndex = 21
        Me.Button22.Text = "Closing Spiel"
        Me.Button22.UseVisualStyleBackColor = False
        '
        'Button45
        '
        Me.Button45.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button45.BackColor = System.Drawing.Color.SteelBlue
        Me.Button45.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button45.ForeColor = System.Drawing.SystemColors.Window
        Me.Button45.Location = New System.Drawing.Point(170, 75)
        Me.Button45.Name = "Button45"
        Me.Button45.Size = New System.Drawing.Size(143, 28)
        Me.Button45.TabIndex = 21
        Me.Button45.Text = "Phishing"
        Me.Button45.UseVisualStyleBackColor = False
        '
        'Button21
        '
        Me.Button21.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button21.BackColor = System.Drawing.Color.SteelBlue
        Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button21.ForeColor = System.Drawing.SystemColors.Window
        Me.Button21.Location = New System.Drawing.Point(170, 47)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(143, 28)
        Me.Button21.TabIndex = 21
        Me.Button21.Text = "FCR"
        Me.Button21.UseVisualStyleBackColor = False
        '
        'Button43
        '
        Me.Button43.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button43.BackColor = System.Drawing.Color.SteelBlue
        Me.Button43.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button43.ForeColor = System.Drawing.SystemColors.Window
        Me.Button43.Location = New System.Drawing.Point(90, 131)
        Me.Button43.Name = "Button43"
        Me.Button43.Size = New System.Drawing.Size(71, 28)
        Me.Button43.TabIndex = 21
        Me.Button43.Text = "Hold B"
        Me.Button43.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button17.BackColor = System.Drawing.Color.SteelBlue
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.ForeColor = System.Drawing.SystemColors.Window
        Me.Button17.Location = New System.Drawing.Point(19, 131)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(71, 28)
        Me.Button17.TabIndex = 21
        Me.Button17.Text = "Hold A"
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button16.BackColor = System.Drawing.Color.SteelBlue
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.ForeColor = System.Drawing.SystemColors.Window
        Me.Button16.Location = New System.Drawing.Point(18, 75)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(143, 28)
        Me.Button16.TabIndex = 21
        Me.Button16.Text = "Restating Concern"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button15.BackColor = System.Drawing.Color.SteelBlue
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.ForeColor = System.Drawing.SystemColors.Window
        Me.Button15.Location = New System.Drawing.Point(18, 47)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(143, 28)
        Me.Button15.TabIndex = 21
        Me.Button15.Text = "OS Proactive"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button12.BackColor = System.Drawing.Color.SteelBlue
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.ForeColor = System.Drawing.SystemColors.Window
        Me.Button12.Location = New System.Drawing.Point(18, 19)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(143, 28)
        Me.Button12.TabIndex = 21
        Me.Button12.Text = "Opening Spiel"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.Button47)
        Me.GroupBox5.Controls.Add(Me.Button10)
        Me.GroupBox5.Controls.Add(Me.Button11)
        Me.GroupBox5.Controls.Add(Me.Button39)
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 218)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(331, 473)
        Me.GroupBox5.TabIndex = 20
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Cases:"
        '
        'Button47
        '
        Me.Button47.BackColor = System.Drawing.Color.Firebrick
        Me.Button47.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button47.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button47.Location = New System.Drawing.Point(240, 19)
        Me.Button47.Name = "Button47"
        Me.Button47.Size = New System.Drawing.Size(71, 26)
        Me.Button47.TabIndex = 24
        Me.Button47.Text = "Paste"
        Me.Button47.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Firebrick
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button10.Location = New System.Drawing.Point(166, 19)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(71, 26)
        Me.Button10.TabIndex = 24
        Me.Button10.Text = "Open"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Firebrick
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button11.Location = New System.Drawing.Point(93, 19)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(70, 26)
        Me.Button11.TabIndex = 22
        Me.Button11.Text = "Save"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button39
        '
        Me.Button39.BackColor = System.Drawing.Color.Firebrick
        Me.Button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button39.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button39.Location = New System.Drawing.Point(18, 19)
        Me.Button39.Name = "Button39"
        Me.Button39.Size = New System.Drawing.Size(71, 26)
        Me.Button39.TabIndex = 23
        Me.Button39.Text = "New"
        Me.Button39.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(6, 51)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(325, 422)
        Me.TextBox1.TabIndex = 19
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.Gray
        Me.Button20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button20.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button20.Location = New System.Drawing.Point(229, 29)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(30, 5)
        Me.Button20.TabIndex = 25
        Me.Button20.Text = "Save"
        Me.Button20.UseVisualStyleBackColor = False
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.DbPanel5)
        Me.TabPage6.Controls.Add(Me.Label20)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(347, 702)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "Email"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'DbPanel5
        '
        Me.DbPanel5.BackColor = System.Drawing.Color.White
        Me.DbPanel5.Controls.Add(Me.Label13)
        Me.DbPanel5.Controls.Add(Me.Button42)
        Me.DbPanel5.Controls.Add(Me.TextBox8)
        Me.DbPanel5.Controls.Add(Me.DbPanel6)
        Me.DbPanel5.Controls.Add(Me.RichTextBox2)
        Me.DbPanel5.Controls.Add(Me.TextBox4)
        Me.DbPanel5.Controls.Add(Me.Label24)
        Me.DbPanel5.Controls.Add(Me.SplitContainer2)
        Me.DbPanel5.Controls.Add(Me.Button37)
        Me.DbPanel5.Controls.Add(Me.GroupBox10)
        Me.DbPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DbPanel5.Location = New System.Drawing.Point(0, 0)
        Me.DbPanel5.Name = "DbPanel5"
        Me.DbPanel5.Size = New System.Drawing.Size(347, 702)
        Me.DbPanel5.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(277, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "SIR Notes"
        '
        'Button42
        '
        Me.Button42.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button42.BackColor = System.Drawing.Color.SteelBlue
        Me.Button42.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button42.ForeColor = System.Drawing.SystemColors.Window
        Me.Button42.Location = New System.Drawing.Point(14, 264)
        Me.Button42.Name = "Button42"
        Me.Button42.Size = New System.Drawing.Size(320, 34)
        Me.Button42.TabIndex = 20
        Me.Button42.Text = "Copy Notes to Clipboard"
        Me.Button42.UseVisualStyleBackColor = False
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(14, 103)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox8.Size = New System.Drawing.Size(320, 155)
        Me.TextBox8.TabIndex = 19
        '
        'DbPanel6
        '
        Me.DbPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DbPanel6.Controls.Add(Me.Button40)
        Me.DbPanel6.Controls.Add(Me.Label22)
        Me.DbPanel6.Controls.Add(Me.Label23)
        Me.DbPanel6.Controls.Add(Me.Button27)
        Me.DbPanel6.Controls.Add(Me.Button29)
        Me.DbPanel6.Controls.Add(Me.Button31)
        Me.DbPanel6.Controls.Add(Me.Button28)
        Me.DbPanel6.Controls.Add(Me.Button30)
        Me.DbPanel6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DbPanel6.Location = New System.Drawing.Point(0, 3)
        Me.DbPanel6.Name = "DbPanel6"
        Me.DbPanel6.Size = New System.Drawing.Size(341, 62)
        Me.DbPanel6.TabIndex = 18
        '
        'Button40
        '
        Me.Button40.BackColor = System.Drawing.Color.Firebrick
        Me.Button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button40.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button40.Location = New System.Drawing.Point(155, 33)
        Me.Button40.Name = "Button40"
        Me.Button40.Size = New System.Drawing.Size(71, 26)
        Me.Button40.TabIndex = 21
        Me.Button40.Text = "Open"
        Me.Button40.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(10, 3)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(111, 24)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Email Tool"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label23.Location = New System.Drawing.Point(236, 21)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(103, 21)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "00:00:00:000"
        '
        'Button27
        '
        Me.Button27.BackColor = System.Drawing.Color.Gray
        Me.Button27.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button27.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button27.Location = New System.Drawing.Point(302, 45)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(30, 5)
        Me.Button27.TabIndex = 7
        Me.Button27.Text = "Save"
        Me.Button27.UseVisualStyleBackColor = False
        '
        'Button29
        '
        Me.Button29.BackColor = System.Drawing.Color.Firebrick
        Me.Button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button29.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button29.Location = New System.Drawing.Point(83, 33)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(70, 26)
        Me.Button29.TabIndex = 7
        Me.Button29.Text = "Save"
        Me.Button29.UseVisualStyleBackColor = False
        '
        'Button31
        '
        Me.Button31.BackColor = System.Drawing.Color.Firebrick
        Me.Button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button31.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button31.Location = New System.Drawing.Point(11, 33)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(71, 26)
        Me.Button31.TabIndex = 7
        Me.Button31.Text = "New"
        Me.Button31.UseVisualStyleBackColor = False
        '
        'Button28
        '
        Me.Button28.BackColor = System.Drawing.Color.Gray
        Me.Button28.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button28.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button28.Location = New System.Drawing.Point(271, 45)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(30, 5)
        Me.Button28.TabIndex = 7
        Me.Button28.Text = "Save"
        Me.Button28.UseVisualStyleBackColor = False
        '
        'Button30
        '
        Me.Button30.BackColor = System.Drawing.Color.Gray
        Me.Button30.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button30.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button30.Location = New System.Drawing.Point(239, 45)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(30, 5)
        Me.Button30.TabIndex = 7
        Me.Button30.Text = "Save"
        Me.Button30.UseVisualStyleBackColor = False
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(280, 649)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(48, 21)
        Me.RichTextBox2.TabIndex = 17
        Me.RichTextBox2.Text = ""
        Me.RichTextBox2.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(40, 73)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(155, 22)
        Me.TextBox4.TabIndex = 10
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label24.Location = New System.Drawing.Point(15, 78)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(25, 13)
        Me.Label24.TabIndex = 11
        Me.Label24.Text = "SR:"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer2.Location = New System.Drawing.Point(18, 328)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TabControl3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(314, 321)
        Me.SplitContainer2.SplitterDistance = 124
        Me.SplitContainer2.TabIndex = 16
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage3)
        Me.TabControl3.Controls.Add(Me.TabPage7)
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl3.Location = New System.Drawing.Point(0, 0)
        Me.TabControl3.MinimumSize = New System.Drawing.Size(314, 126)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(314, 126)
        Me.TabControl3.TabIndex = 15
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ComboBox5)
        Me.TabPage3.Controls.Add(Me.Button32)
        Me.TabPage3.Controls.Add(Me.Label25)
        Me.TabPage3.Controls.Add(Me.Button33)
        Me.TabPage3.Controls.Add(Me.Label26)
        Me.TabPage3.Controls.Add(Me.Button34)
        Me.TabPage3.Controls.Add(Me.ComboBox7)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(306, 100)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "Email"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ComboBox5
        '
        Me.ComboBox5.DataSource = Me.ProbcatBindingSource
        Me.ComboBox5.DisplayMember = "Probcat"
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(86, 10)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(206, 21)
        Me.ComboBox5.TabIndex = 18
        '
        'Button32
        '
        Me.Button32.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button32.BackColor = System.Drawing.Color.SteelBlue
        Me.Button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button32.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button32.Location = New System.Drawing.Point(10, 64)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(127, 28)
        Me.Button32.TabIndex = 21
        Me.Button32.Text = "Manage Templates"
        Me.Button32.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label25.Location = New System.Drawing.Point(6, 13)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(77, 13)
        Me.Label25.TabIndex = 15
        Me.Label25.Text = "Prob Category:"
        '
        'Button33
        '
        Me.Button33.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button33.BackColor = System.Drawing.Color.SteelBlue
        Me.Button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button33.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button33.Location = New System.Drawing.Point(139, 64)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(82, 28)
        Me.Button33.TabIndex = 22
        Me.Button33.Text = "Clear"
        Me.Button33.UseVisualStyleBackColor = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label26.Location = New System.Drawing.Point(6, 40)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(74, 13)
        Me.Label26.TabIndex = 16
        Me.Label26.Text = "Sub Category:"
        '
        'Button34
        '
        Me.Button34.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button34.BackColor = System.Drawing.Color.SteelBlue
        Me.Button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button34.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button34.Location = New System.Drawing.Point(223, 64)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(75, 28)
        Me.Button34.TabIndex = 23
        Me.Button34.Text = "View"
        Me.Button34.UseVisualStyleBackColor = False
        '
        'ComboBox7
        '
        Me.ComboBox7.DataSource = Me.SubcatBindingSource
        Me.ComboBox7.DisplayMember = "Subcat"
        Me.ComboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(86, 37)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(206, 21)
        Me.ComboBox7.TabIndex = 20
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.TextBox5)
        Me.TabPage7.Controls.Add(Me.Button35)
        Me.TabPage7.Controls.Add(Me.Button36)
        Me.TabPage7.Controls.Add(Me.Label28)
        Me.TabPage7.Controls.Add(Me.ComboBox8)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(306, 100)
        Me.TabPage7.TabIndex = 0
        Me.TabPage7.Text = "Notes"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.Location = New System.Drawing.Point(9, 32)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(288, 31)
        Me.TextBox5.TabIndex = 31
        '
        'Button35
        '
        Me.Button35.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button35.BackColor = System.Drawing.Color.SteelBlue
        Me.Button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button35.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button35.Location = New System.Drawing.Point(88, 67)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(127, 28)
        Me.Button35.TabIndex = 28
        Me.Button35.Text = "Manage Notes"
        Me.Button35.UseVisualStyleBackColor = False
        '
        'Button36
        '
        Me.Button36.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button36.BackColor = System.Drawing.Color.SteelBlue
        Me.Button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button36.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button36.Location = New System.Drawing.Point(219, 67)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(75, 28)
        Me.Button36.TabIndex = 30
        Me.Button36.Text = "Insert"
        Me.Button36.UseVisualStyleBackColor = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label28.Location = New System.Drawing.Point(6, 9)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(61, 13)
        Me.Label28.TabIndex = 25
        Me.Label28.Text = "Notes Title:"
        '
        'ComboBox8
        '
        Me.ComboBox8.DataSource = Me.DBDS
        Me.ComboBox8.DisplayMember = "Notes.NoteTitle"
        Me.ComboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Location = New System.Drawing.Point(68, 6)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(226, 21)
        Me.ComboBox8.TabIndex = 26
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.DataGridView1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.TextBox6)
        Me.SplitContainer3.Size = New System.Drawing.Size(307, 187)
        Me.SplitContainer3.SplitterDistance = 112
        Me.SplitContainer3.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(307, 112)
        Me.DataGridView1.TabIndex = 0
        '
        'TextBox6
        '
        Me.TextBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox6.Location = New System.Drawing.Point(0, 0)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox6.Size = New System.Drawing.Size(307, 71)
        Me.TextBox6.TabIndex = 20
        '
        'Button37
        '
        Me.Button37.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button37.BackColor = System.Drawing.Color.SteelBlue
        Me.Button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button37.ForeColor = System.Drawing.SystemColors.Window
        Me.Button37.Location = New System.Drawing.Point(14, 662)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(320, 34)
        Me.Button37.TabIndex = 14
        Me.Button37.Text = "Copy Email to Clipboard"
        Me.Button37.UseVisualStyleBackColor = False
        '
        'GroupBox10
        '
        Me.GroupBox10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GroupBox10.Controls.Add(Me.Label29)
        Me.GroupBox10.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox10.Location = New System.Drawing.Point(18, 304)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(316, 352)
        Me.GroupBox10.TabIndex = 12
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Email Templates"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(233, 8)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(82, 13)
        Me.Label29.TabIndex = 24
        Me.Label29.Text = "Email Generator"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.Label20.Location = New System.Drawing.Point(15, 10)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(111, 24)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Email Tool"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "SR"
        Me.OpenFileDialog1.Filter = "Text files|*.txt|All files|*.*"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'DbPanel4
        '
        Me.DbPanel4.BackColor = System.Drawing.Color.Red
        Me.DbPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.DbPanel4.Location = New System.Drawing.Point(0, 0)
        Me.DbPanel4.Name = "DbPanel4"
        Me.DbPanel4.Size = New System.Drawing.Size(355, 3)
        Me.DbPanel4.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 728)
        Me.Controls.Add(Me.DbPanel4)
        Me.Controls.Add(Me.TabControl2)
        Me.MaximumSize = New System.Drawing.Size(371, 1200)
        Me.MinimumSize = New System.Drawing.Size(371, 726)
        Me.Name = "Form1"
        CType(Me.ProbcatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TemplateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubcatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCEBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBEDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBEDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCEBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.DbPanel1.ResumeLayout(False)
        Me.DbPanel1.PerformLayout()
        CType(Me.m2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.DbPanel3.ResumeLayout(False)
        Me.DbPanel3.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.DbPanel2.ResumeLayout(False)
        Me.DbPanel2.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.DbPanel5.ResumeLayout(False)
        Me.DbPanel5.PerformLayout()
        Me.DbPanel6.ResumeLayout(False)
        Me.DbPanel6.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DbPanel1 As SIRTool.dbPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdbtnSSPOP As System.Windows.Forms.RadioButton
    Friend WithEvents rd As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnSSTS As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbxSR As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtbxNotes As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DBDS As SIRTool.DBDS
    Friend WithEvents ProbcatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProbcatTableAdapter As SIRTool.DBDSTableAdapters.ProbcatTableAdapter
    Friend WithEvents SubcatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubcatTableAdapter As SIRTool.DBDSTableAdapters.SubcatTableAdapter
    Friend WithEvents TemplateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TemplateTableAdapter As SIRTool.DBDSTableAdapters.TemplateTableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbtnPSN As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnPSY As System.Windows.Forms.RadioButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbtnFCN As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnFCY As System.Windows.Forms.RadioButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtbxSN As System.Windows.Forms.TextBox
    Friend WithEvents txtbxON As System.Windows.Forms.TextBox
    Friend WithEvents txtbxEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbxClientname As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents DBEDS As SIRTool.DBEDS
    Friend WithEvents DBEDSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProbcatTableAdapter1 As SIRTool.DBEDSTableAdapters.ProbcatTableAdapter
    Friend WithEvents SubcatTableAdapter1 As SIRTool.DBEDSTableAdapters.SubcatTableAdapter
    Friend WithEvents TemplateTableAdapter1 As SIRTool.DBEDSTableAdapters.TemplateTableAdapter
    Friend WithEvents PCEBS As System.Windows.Forms.BindingSource
    Friend WithEvents SCEBS As System.Windows.Forms.BindingSource
    Friend WithEvents TEBS As System.Windows.Forms.BindingSource
    Friend WithEvents NotesTableAdapter1 As SIRTool.DBDSTableAdapters.NotesTableAdapter
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents DbPanel3 As SIRTool.dbPanel
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents DbPanel4 As SIRTool.dbPanel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DbPanel2 As SIRTool.dbPanel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents DbPanel5 As SIRTool.dbPanel
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents DbPanel6 As SIRTool.dbPanel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Button27 As System.Windows.Forms.Button
    Friend WithEvents Button28 As System.Windows.Forms.Button
    Friend WithEvents Button29 As System.Windows.Forms.Button
    Friend WithEvents Button30 As System.Windows.Forms.Button
    Friend WithEvents Button31 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents Button32 As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Button33 As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Button34 As System.Windows.Forms.Button
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button35 As System.Windows.Forms.Button
    Friend WithEvents Button36 As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents ComboBox8 As System.Windows.Forms.ComboBox
    Friend WithEvents Button37 As System.Windows.Forms.Button
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button38 As System.Windows.Forms.Button
    Friend WithEvents Button41 As System.Windows.Forms.Button
    Friend WithEvents Button40 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents s2 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents m2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Button42 As System.Windows.Forms.Button
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Button26 As System.Windows.Forms.Button
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents Button44 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button46 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Button45 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button43 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button47 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button39 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer

End Class
