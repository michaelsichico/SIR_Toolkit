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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DbDataSet = New EmailBank.dbDataSet()
        Me.EmailTemplatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmailTemplatesTableAdapter = New EmailBank.dbDataSetTableAdapters.EmailTemplatesTableAdapter()
        Me.SRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SRTableAdapter = New EmailBank.dbDataSetTableAdapters.SRTableAdapter()
        Me.DbPanel1 = New EmailBank.DBPanel()
        Me.DbPanel4 = New EmailBank.DBPanel()
        Me.DbPanel6 = New EmailBank.DBPanel()
        Me.cmbbxEmailCat = New System.Windows.Forms.ComboBox()
        Me.DbPanel7 = New EmailBank.DBPanel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.DbPanel10 = New EmailBank.DBPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnEmailSearch = New System.Windows.Forms.Button()
        Me.txtbxEmailSearch = New System.Windows.Forms.TextBox()
        Me.DbPanel5 = New EmailBank.DBPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DbPanel9 = New EmailBank.DBPanel()
        Me.s = New System.Windows.Forms.Label()
        Me.DbPanel8 = New EmailBank.DBPanel()
        Me.m = New System.Windows.Forms.Label()
        Me.txtbxSR = New System.Windows.Forms.TextBox()
        Me.btnSR_Stop = New System.Windows.Forms.Button()
        Me.btnSR_VR = New System.Windows.Forms.Button()
        Me.btnSR_New = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.b = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.DbPanel2 = New EmailBank.DBPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AHT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShiftDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailTemplateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AHTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateSavedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.DbPanel3 = New EmailBank.DBPanel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTemplatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DbPanel1.SuspendLayout()
        Me.DbPanel4.SuspendLayout()
        Me.DbPanel6.SuspendLayout()
        Me.DbPanel7.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DbPanel10.SuspendLayout()
        Me.DbPanel5.SuspendLayout()
        Me.DbPanel9.SuspendLayout()
        Me.DbPanel8.SuspendLayout()
        Me.DbPanel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DbPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DbDataSet
        '
        Me.DbDataSet.DataSetName = "dbDataSet"
        Me.DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmailTemplatesBindingSource
        '
        Me.EmailTemplatesBindingSource.DataMember = "EmailTemplates"
        Me.EmailTemplatesBindingSource.DataSource = Me.DbDataSet
        '
        'EmailTemplatesTableAdapter
        '
        Me.EmailTemplatesTableAdapter.ClearBeforeFill = True
        '
        'SRBindingSource
        '
        Me.SRBindingSource.DataMember = "SR"
        Me.SRBindingSource.DataSource = Me.DbDataSet
        '
        'SRTableAdapter
        '
        Me.SRTableAdapter.ClearBeforeFill = True
        '
        'DbPanel1
        '
        Me.DbPanel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DbPanel1.Controls.Add(Me.DbPanel4)
        Me.DbPanel1.Controls.Add(Me.DbPanel2)
        Me.DbPanel1.Controls.Add(Me.DbPanel3)
        Me.DbPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DbPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DbPanel1.Name = "DbPanel1"
        Me.DbPanel1.Size = New System.Drawing.Size(598, 493)
        Me.DbPanel1.TabIndex = 0
        '
        'DbPanel4
        '
        Me.DbPanel4.Controls.Add(Me.DbPanel6)
        Me.DbPanel4.Controls.Add(Me.DbPanel5)
        Me.DbPanel4.Controls.Add(Me.btnDelete)
        Me.DbPanel4.Controls.Add(Me.btnEdit)
        Me.DbPanel4.Controls.Add(Me.b)
        Me.DbPanel4.Controls.Add(Me.btnCopy)
        Me.DbPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DbPanel4.Location = New System.Drawing.Point(0, 56)
        Me.DbPanel4.Name = "DbPanel4"
        Me.DbPanel4.Size = New System.Drawing.Size(598, 404)
        Me.DbPanel4.TabIndex = 4
        '
        'DbPanel6
        '
        Me.DbPanel6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DbPanel6.Controls.Add(Me.cmbbxEmailCat)
        Me.DbPanel6.Controls.Add(Me.DbPanel7)
        Me.DbPanel6.Controls.Add(Me.btnEmailSearch)
        Me.DbPanel6.Controls.Add(Me.txtbxEmailSearch)
        Me.DbPanel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.DbPanel6.Location = New System.Drawing.Point(141, 43)
        Me.DbPanel6.Name = "DbPanel6"
        Me.DbPanel6.Size = New System.Drawing.Size(457, 361)
        Me.DbPanel6.TabIndex = 4
        '
        'cmbbxEmailCat
        '
        Me.cmbbxEmailCat.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DbDataSet, "EmailCategory.EmailCategoryEmailTemplates.Category", True))
        Me.cmbbxEmailCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxEmailCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxEmailCat.FormattingEnabled = True
        Me.cmbbxEmailCat.Items.AddRange(New Object() {"All", "General", "Probing", "Followup", "Sales", "Detection", "Distribution", "Install", "Malware", "Non-Support", "Performance", "Registration", "Refund Concerns", "Update", "Using the Product", "Support Concerns", "Others"})
        Me.cmbbxEmailCat.Location = New System.Drawing.Point(7, 6)
        Me.cmbbxEmailCat.Name = "cmbbxEmailCat"
        Me.cmbbxEmailCat.Size = New System.Drawing.Size(120, 23)
        Me.cmbbxEmailCat.TabIndex = 3
        '
        'DbPanel7
        '
        Me.DbPanel7.Controls.Add(Me.SplitContainer1)
        Me.DbPanel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DbPanel7.Location = New System.Drawing.Point(0, 33)
        Me.DbPanel7.Name = "DbPanel7"
        Me.DbPanel7.Size = New System.Drawing.Size(457, 328)
        Me.DbPanel7.TabIndex = 2
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DGV)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.RichTextBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DbPanel10)
        Me.SplitContainer1.Size = New System.Drawing.Size(457, 328)
        Me.SplitContainer1.SplitterDistance = 180
        Me.SplitContainer1.TabIndex = 3
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AutoGenerateColumns = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.CategoryDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.DGV.DataSource = Me.EmailTemplatesBindingSource
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV.Location = New System.Drawing.Point(0, 0)
        Me.DGV.MultiSelect = False
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(180, 328)
        Me.DGV.TabIndex = 2
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "EmailTitle"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Email Template"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoryDataGridViewTextBoxColumn.Visible = False
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailDataGridViewTextBoxColumn.Visible = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 24)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(273, 304)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'DbPanel10
        '
        Me.DbPanel10.Controls.Add(Me.Label6)
        Me.DbPanel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.DbPanel10.Location = New System.Drawing.Point(0, 0)
        Me.DbPanel10.Name = "DbPanel10"
        Me.DbPanel10.Size = New System.Drawing.Size(273, 24)
        Me.DbPanel10.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Preview"
        '
        'btnEmailSearch
        '
        Me.btnEmailSearch.Location = New System.Drawing.Point(347, 6)
        Me.btnEmailSearch.Name = "btnEmailSearch"
        Me.btnEmailSearch.Size = New System.Drawing.Size(107, 24)
        Me.btnEmailSearch.TabIndex = 1
        Me.btnEmailSearch.Text = "Search"
        Me.btnEmailSearch.UseVisualStyleBackColor = True
        '
        'txtbxEmailSearch
        '
        Me.txtbxEmailSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEmailSearch.Location = New System.Drawing.Point(130, 7)
        Me.txtbxEmailSearch.Name = "txtbxEmailSearch"
        Me.txtbxEmailSearch.Size = New System.Drawing.Size(215, 22)
        Me.txtbxEmailSearch.TabIndex = 0
        '
        'DbPanel5
        '
        Me.DbPanel5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.DbPanel5.BackgroundImage = Global.EmailBank.My.Resources.Resources.subbg
        Me.DbPanel5.Controls.Add(Me.Label3)
        Me.DbPanel5.Controls.Add(Me.Label2)
        Me.DbPanel5.Controls.Add(Me.DbPanel9)
        Me.DbPanel5.Controls.Add(Me.DbPanel8)
        Me.DbPanel5.Controls.Add(Me.txtbxSR)
        Me.DbPanel5.Controls.Add(Me.btnSR_Stop)
        Me.DbPanel5.Controls.Add(Me.btnSR_VR)
        Me.DbPanel5.Controls.Add(Me.btnSR_New)
        Me.DbPanel5.Controls.Add(Me.Label5)
        Me.DbPanel5.Controls.Add(Me.Label4)
        Me.DbPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.DbPanel5.Location = New System.Drawing.Point(0, 0)
        Me.DbPanel5.Name = "DbPanel5"
        Me.DbPanel5.Size = New System.Drawing.Size(598, 43)
        Me.DbPanel5.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(553, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 9)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Sec"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(509, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 9)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Min"
        '
        'DbPanel9
        '
        Me.DbPanel9.BackColor = System.Drawing.Color.Transparent
        Me.DbPanel9.Controls.Add(Me.s)
        Me.DbPanel9.Location = New System.Drawing.Point(553, 4)
        Me.DbPanel9.Name = "DbPanel9"
        Me.DbPanel9.Size = New System.Drawing.Size(40, 26)
        Me.DbPanel9.TabIndex = 9
        '
        's
        '
        Me.s.AutoSize = True
        Me.s.BackColor = System.Drawing.Color.Transparent
        Me.s.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.s.Location = New System.Drawing.Point(-4, 2)
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(26, 28)
        Me.s.TabIndex = 5
        Me.s.Text = "0"
        '
        'DbPanel8
        '
        Me.DbPanel8.BackColor = System.Drawing.Color.Transparent
        Me.DbPanel8.Controls.Add(Me.m)
        Me.DbPanel8.Location = New System.Drawing.Point(510, 4)
        Me.DbPanel8.Name = "DbPanel8"
        Me.DbPanel8.Size = New System.Drawing.Size(41, 26)
        Me.DbPanel8.TabIndex = 9
        '
        'm
        '
        Me.m.AutoSize = True
        Me.m.BackColor = System.Drawing.Color.Transparent
        Me.m.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.m.Location = New System.Drawing.Point(-5, 3)
        Me.m.Name = "m"
        Me.m.Size = New System.Drawing.Size(26, 28)
        Me.m.TabIndex = 5
        Me.m.Text = "0"
        '
        'txtbxSR
        '
        Me.txtbxSR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSR.Location = New System.Drawing.Point(30, 9)
        Me.txtbxSR.Name = "txtbxSR"
        Me.txtbxSR.Size = New System.Drawing.Size(159, 24)
        Me.txtbxSR.TabIndex = 8
        '
        'btnSR_Stop
        '
        Me.btnSR_Stop.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSR_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSR_Stop.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSR_Stop.Location = New System.Drawing.Point(193, 7)
        Me.btnSR_Stop.Name = "btnSR_Stop"
        Me.btnSR_Stop.Size = New System.Drawing.Size(71, 27)
        Me.btnSR_Stop.TabIndex = 6
        Me.btnSR_Stop.Text = "Save"
        Me.btnSR_Stop.UseVisualStyleBackColor = False
        '
        'btnSR_VR
        '
        Me.btnSR_VR.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSR_VR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSR_VR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSR_VR.Location = New System.Drawing.Point(339, 7)
        Me.btnSR_VR.Name = "btnSR_VR"
        Me.btnSR_VR.Size = New System.Drawing.Size(100, 27)
        Me.btnSR_VR.TabIndex = 3
        Me.btnSR_VR.Text = "View Records"
        Me.btnSR_VR.UseVisualStyleBackColor = False
        '
        'btnSR_New
        '
        Me.btnSR_New.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSR_New.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSR_New.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSR_New.Location = New System.Drawing.Point(266, 7)
        Me.btnSR_New.Name = "btnSR_New"
        Me.btnSR_New.Size = New System.Drawing.Size(71, 27)
        Me.btnSR_New.TabIndex = 7
        Me.btnSR_New.Text = "New"
        Me.btnSR_New.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Adobe Heiti Std R", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(465, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "AHT:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Adobe Heiti Std R", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(5, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "SR:"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DimGray
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.Location = New System.Drawing.Point(12, 203)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(123, 32)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.DimGray
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEdit.Location = New System.Drawing.Point(12, 169)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(123, 32)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'b
        '
        Me.b.BackColor = System.Drawing.Color.DimGray
        Me.b.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.b.Location = New System.Drawing.Point(12, 135)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(123, 32)
        Me.b.TabIndex = 3
        Me.b.Text = "Create"
        Me.b.UseVisualStyleBackColor = False
        '
        'btnCopy
        '
        Me.btnCopy.BackgroundImage = Global.EmailBank.My.Resources.Resources.buutn
        Me.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCopy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCopy.Location = New System.Drawing.Point(12, 49)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(123, 82)
        Me.btnCopy.TabIndex = 3
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'DbPanel2
        '
        Me.DbPanel2.BackColor = System.Drawing.Color.SteelBlue
        Me.DbPanel2.BackgroundImage = Global.EmailBank.My.Resources.Resources.header
        Me.DbPanel2.Controls.Add(Me.DataGridView1)
        Me.DbPanel2.Controls.Add(Me.Label7)
        Me.DbPanel2.Controls.Add(Me.DateTimePicker1)
        Me.DbPanel2.Controls.Add(Me.lblDate)
        Me.DbPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.DbPanel2.Location = New System.Drawing.Point(0, 0)
        Me.DbPanel2.Name = "DbPanel2"
        Me.DbPanel2.Size = New System.Drawing.Size(598, 56)
        Me.DbPanel2.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.AHT, Me.IDDataGridViewTextBoxColumn1, Me.SRDataGridViewTextBoxColumn, Me.ShiftDateDataGridViewTextBoxColumn, Me.EmailTemplateDataGridViewTextBoxColumn, Me.AHTDataGridViewTextBoxColumn, Me.DateSavedDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SRBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(165, 31)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(38, 17)
        Me.DataGridView1.TabIndex = 6
        Me.DataGridView1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "EmailTitle"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Email Template"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'AHT
        '
        Me.AHT.DataPropertyName = "AHT"
        Me.AHT.HeaderText = "AHT"
        Me.AHT.Name = "AHT"
        Me.AHT.ReadOnly = True
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'SRDataGridViewTextBoxColumn
        '
        Me.SRDataGridViewTextBoxColumn.DataPropertyName = "SR"
        Me.SRDataGridViewTextBoxColumn.HeaderText = "SR"
        Me.SRDataGridViewTextBoxColumn.Name = "SRDataGridViewTextBoxColumn"
        Me.SRDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShiftDateDataGridViewTextBoxColumn
        '
        Me.ShiftDateDataGridViewTextBoxColumn.DataPropertyName = "ShiftDate"
        Me.ShiftDateDataGridViewTextBoxColumn.HeaderText = "ShiftDate"
        Me.ShiftDateDataGridViewTextBoxColumn.Name = "ShiftDateDataGridViewTextBoxColumn"
        Me.ShiftDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailTemplateDataGridViewTextBoxColumn
        '
        Me.EmailTemplateDataGridViewTextBoxColumn.DataPropertyName = "EmailTemplate"
        Me.EmailTemplateDataGridViewTextBoxColumn.HeaderText = "EmailTemplate"
        Me.EmailTemplateDataGridViewTextBoxColumn.Name = "EmailTemplateDataGridViewTextBoxColumn"
        Me.EmailTemplateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AHTDataGridViewTextBoxColumn
        '
        Me.AHTDataGridViewTextBoxColumn.DataPropertyName = "AHT"
        Me.AHTDataGridViewTextBoxColumn.HeaderText = "AHT"
        Me.AHTDataGridViewTextBoxColumn.Name = "AHTDataGridViewTextBoxColumn"
        Me.AHTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateSavedDataGridViewTextBoxColumn
        '
        Me.DateSavedDataGridViewTextBoxColumn.DataPropertyName = "DateSaved"
        Me.DateSavedDataGridViewTextBoxColumn.HeaderText = "DateSaved"
        Me.DateSavedDataGridViewTextBoxColumn.Name = "DateSavedDataGridViewTextBoxColumn"
        Me.DateSavedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(422, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "0 Email Processed Today"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(165, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(38, 20)
        Me.DateTimePicker1.TabIndex = 2
        Me.DateTimePicker1.Visible = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDate.Location = New System.Drawing.Point(463, 9)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(108, 13)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "10/27/2014 7:27 AM"
        '
        'DbPanel3
        '
        Me.DbPanel3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.DbPanel3.Controls.Add(Me.CheckBox1)
        Me.DbPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DbPanel3.Location = New System.Drawing.Point(0, 460)
        Me.DbPanel3.Name = "DbPanel3"
        Me.DbPanel3.Size = New System.Drawing.Size(598, 33)
        Me.DbPanel3.TabIndex = 1
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(11, 9)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(96, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Always on Top"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 493)
        Me.Controls.Add(Me.DbPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTemplatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DbPanel1.ResumeLayout(False)
        Me.DbPanel4.ResumeLayout(False)
        Me.DbPanel6.ResumeLayout(False)
        Me.DbPanel6.PerformLayout()
        Me.DbPanel7.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DbPanel10.ResumeLayout(False)
        Me.DbPanel10.PerformLayout()
        Me.DbPanel5.ResumeLayout(False)
        Me.DbPanel5.PerformLayout()
        Me.DbPanel9.ResumeLayout(False)
        Me.DbPanel9.PerformLayout()
        Me.DbPanel8.ResumeLayout(False)
        Me.DbPanel8.PerformLayout()
        Me.DbPanel2.ResumeLayout(False)
        Me.DbPanel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DbPanel3.ResumeLayout(False)
        Me.DbPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DbPanel1 As EmailBank.DBPanel
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents DbPanel3 As EmailBank.DBPanel
    Friend WithEvents DbPanel2 As EmailBank.DBPanel
    Friend WithEvents DbPanel4 As EmailBank.DBPanel
    Friend WithEvents DbPanel5 As EmailBank.DBPanel
    Friend WithEvents btnEmailSearch As System.Windows.Forms.Button
    Friend WithEvents txtbxEmailSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents b As System.Windows.Forms.Button
    Friend WithEvents DbPanel6 As EmailBank.DBPanel
    Friend WithEvents btnSR_VR As System.Windows.Forms.Button
    Friend WithEvents DbPanel7 As EmailBank.DBPanel
    Friend WithEvents txtbxSR As System.Windows.Forms.TextBox
    Friend WithEvents btnSR_Stop As System.Windows.Forms.Button
    Friend WithEvents btnSR_New As System.Windows.Forms.Button
    Friend WithEvents m As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents DbPanel8 As EmailBank.DBPanel
    Friend WithEvents cmbbxEmailCat As System.Windows.Forms.ComboBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents DbDataSet As EmailBank.dbDataSet
    Friend WithEvents EmailTemplatesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmailTemplatesTableAdapter As EmailBank.dbDataSetTableAdapters.EmailTemplatesTableAdapter
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents s As System.Windows.Forms.Label
    Friend WithEvents DbPanel9 As EmailBank.DBPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DbPanel10 As EmailBank.DBPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AHT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SRTableAdapter As EmailBank.dbDataSetTableAdapters.SRTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShiftDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailTemplateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AHTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateSavedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
