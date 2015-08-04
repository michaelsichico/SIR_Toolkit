<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageSolution
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
        Me.DbPanel1 = New SIRTool.dbPanel()
        Me.DGVProbcat = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TemplateTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubcatIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TemplateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TemplateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBDS = New SIRTool.DBDS()
        Me.txtbxNotes = New System.Windows.Forms.TextBox()
        Me.DbPanel2 = New SIRTool.dbPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.SubcatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ProbcatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableAdapterManager1 = New SIRTool.DBEDSTableAdapters.TableAdapterManager()
        Me.TemplateTableAdapter = New SIRTool.DBDSTableAdapters.TemplateTableAdapter()
        Me.ProbcatTableAdapter = New SIRTool.DBDSTableAdapters.ProbcatTableAdapter()
        Me.SubcatTableAdapter = New SIRTool.DBDSTableAdapters.SubcatTableAdapter()
        Me.DbPanel1.SuspendLayout()
        CType(Me.DGVProbcat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TemplateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubcatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProbcatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DbPanel1
        '
        Me.DbPanel1.BackColor = System.Drawing.Color.White
        Me.DbPanel1.Controls.Add(Me.DGVProbcat)
        Me.DbPanel1.Controls.Add(Me.txtbxNotes)
        Me.DbPanel1.Controls.Add(Me.DbPanel2)
        Me.DbPanel1.Controls.Add(Me.Label5)
        Me.DbPanel1.Controls.Add(Me.Label3)
        Me.DbPanel1.Controls.Add(Me.Label4)
        Me.DbPanel1.Controls.Add(Me.Label2)
        Me.DbPanel1.Controls.Add(Me.Button3)
        Me.DbPanel1.Controls.Add(Me.Button2)
        Me.DbPanel1.Controls.Add(Me.Button1)
        Me.DbPanel1.Controls.Add(Me.ComboBox2)
        Me.DbPanel1.Controls.Add(Me.ComboBox1)
        Me.DbPanel1.Controls.Add(Me.TextBox1)
        Me.DbPanel1.Controls.Add(Me.Label1)
        Me.DbPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DbPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DbPanel1.Name = "DbPanel1"
        Me.DbPanel1.Size = New System.Drawing.Size(708, 401)
        Me.DbPanel1.TabIndex = 0
        '
        'DGVProbcat
        '
        Me.DGVProbcat.AllowUserToAddRows = False
        Me.DGVProbcat.AllowUserToDeleteRows = False
        Me.DGVProbcat.AllowUserToResizeColumns = False
        Me.DGVProbcat.AllowUserToResizeRows = False
        Me.DGVProbcat.AutoGenerateColumns = False
        Me.DGVProbcat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVProbcat.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVProbcat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVProbcat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProbcat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.TemplateTitleDataGridViewTextBoxColumn, Me.SubcatIDDataGridViewTextBoxColumn, Me.TemplateDataGridViewTextBoxColumn})
        Me.DGVProbcat.DataSource = Me.TemplateBindingSource
        Me.DGVProbcat.Location = New System.Drawing.Point(19, 122)
        Me.DGVProbcat.MultiSelect = False
        Me.DGVProbcat.Name = "DGVProbcat"
        Me.DGVProbcat.ReadOnly = True
        Me.DGVProbcat.RowHeadersVisible = False
        Me.DGVProbcat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVProbcat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVProbcat.Size = New System.Drawing.Size(297, 257)
        Me.DGVProbcat.TabIndex = 3
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'TemplateTitleDataGridViewTextBoxColumn
        '
        Me.TemplateTitleDataGridViewTextBoxColumn.DataPropertyName = "TemplateTitle"
        Me.TemplateTitleDataGridViewTextBoxColumn.HeaderText = "Solution"
        Me.TemplateTitleDataGridViewTextBoxColumn.Name = "TemplateTitleDataGridViewTextBoxColumn"
        Me.TemplateTitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubcatIDDataGridViewTextBoxColumn
        '
        Me.SubcatIDDataGridViewTextBoxColumn.DataPropertyName = "SubcatID"
        Me.SubcatIDDataGridViewTextBoxColumn.HeaderText = "SubcatID"
        Me.SubcatIDDataGridViewTextBoxColumn.Name = "SubcatIDDataGridViewTextBoxColumn"
        Me.SubcatIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubcatIDDataGridViewTextBoxColumn.Visible = False
        '
        'TemplateDataGridViewTextBoxColumn
        '
        Me.TemplateDataGridViewTextBoxColumn.DataPropertyName = "Template"
        Me.TemplateDataGridViewTextBoxColumn.HeaderText = "Template"
        Me.TemplateDataGridViewTextBoxColumn.Name = "TemplateDataGridViewTextBoxColumn"
        Me.TemplateDataGridViewTextBoxColumn.ReadOnly = True
        Me.TemplateDataGridViewTextBoxColumn.Visible = False
        '
        'TemplateBindingSource
        '
        Me.TemplateBindingSource.DataMember = "Template"
        Me.TemplateBindingSource.DataSource = Me.DBDS
        '
        'DBDS
        '
        Me.DBDS.DataSetName = "DBDS"
        Me.DBDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtbxNotes
        '
        Me.txtbxNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtbxNotes.Location = New System.Drawing.Point(351, 138)
        Me.txtbxNotes.Multiline = True
        Me.txtbxNotes.Name = "txtbxNotes"
        Me.txtbxNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtbxNotes.Size = New System.Drawing.Size(339, 241)
        Me.txtbxNotes.TabIndex = 26
        '
        'DbPanel2
        '
        Me.DbPanel2.BackColor = System.Drawing.Color.Red
        Me.DbPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.DbPanel2.Location = New System.Drawing.Point(0, 0)
        Me.DbPanel2.Name = "DbPanel2"
        Me.DbPanel2.Size = New System.Drawing.Size(708, 3)
        Me.DbPanel2.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(348, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(16, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Problem Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(16, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Sub-Category:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(348, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Template Title:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Firebrick
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(577, 56)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 28)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Firebrick
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(365, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(471, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.SubcatBindingSource
        Me.ComboBox2.DisplayMember = "Subcat"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(109, 90)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(207, 21)
        Me.ComboBox2.TabIndex = 13
        '
        'SubcatBindingSource
        '
        Me.SubcatBindingSource.DataMember = "Subcat"
        Me.SubcatBindingSource.DataSource = Me.DBDS
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ProbcatBindingSource
        Me.ComboBox1.DisplayMember = "Probcat"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(109, 63)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(207, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'ProbcatBindingSource
        '
        Me.ProbcatBindingSource.DataMember = "Probcat"
        Me.ProbcatBindingSource.DataSource = Me.DBDS
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(431, 93)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(259, 20)
        Me.TextBox1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(14, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Manage Templates"
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.ProbcatTableAdapter = Nothing
        Me.TableAdapterManager1.SubcatTableAdapter = Nothing
        Me.TableAdapterManager1.TemplateTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = SIRTool.DBEDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TemplateTableAdapter
        '
        Me.TemplateTableAdapter.ClearBeforeFill = True
        '
        'ProbcatTableAdapter
        '
        Me.ProbcatTableAdapter.ClearBeforeFill = True
        '
        'SubcatTableAdapter
        '
        Me.SubcatTableAdapter.ClearBeforeFill = True
        '
        'ManageSolution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 401)
        Me.Controls.Add(Me.DbPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManageSolution"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ManageSolution"
        Me.DbPanel1.ResumeLayout(False)
        Me.DbPanel1.PerformLayout()
        CType(Me.DGVProbcat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TemplateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubcatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProbcatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DbPanel1 As SIRTool.dbPanel
    Friend WithEvents DbPanel2 As SIRTool.dbPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGVProbcat As System.Windows.Forms.DataGridView
    Friend WithEvents txtbxNotes As System.Windows.Forms.TextBox
    Friend WithEvents TableAdapterManager1 As SIRTool.DBEDSTableAdapters.TableAdapterManager
    Friend WithEvents DBDS As SIRTool.DBDS
    Friend WithEvents TemplateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TemplateTableAdapter As SIRTool.DBDSTableAdapters.TemplateTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TemplateTitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubcatIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TemplateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProbcatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProbcatTableAdapter As SIRTool.DBDSTableAdapters.ProbcatTableAdapter
    Friend WithEvents SubcatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubcatTableAdapter As SIRTool.DBDSTableAdapters.SubcatTableAdapter

End Class
