<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CMManageTemplates
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
        Me.DbPanel2 = New SIRTool.dbPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DbPanel3 = New SIRTool.dbPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.DbPanel27 = New SIRTool.dbPanel()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DGVCMSpiels = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMShortcutKeysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbDataSet = New SIRTool.dbDataSet()
        Me.DbPanel4 = New SIRTool.dbPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CMShortcutKeysTableAdapter = New SIRTool.dbDataSetTableAdapters.CMShortcutKeysTableAdapter()
        Me.DbPanel1.SuspendLayout()
        Me.DbPanel2.SuspendLayout()
        Me.DbPanel3.SuspendLayout()
        Me.DbPanel27.SuspendLayout()
        CType(Me.DGVCMSpiels, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMShortcutKeysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DbPanel1
        '
        Me.DbPanel1.BackColor = System.Drawing.Color.White
        Me.DbPanel1.Controls.Add(Me.DbPanel2)
        Me.DbPanel1.Controls.Add(Me.DbPanel3)
        Me.DbPanel1.Controls.Add(Me.DbPanel27)
        Me.DbPanel1.Controls.Add(Me.TextBox4)
        Me.DbPanel1.Controls.Add(Me.TextBox1)
        Me.DbPanel1.Controls.Add(Me.DGVCMSpiels)
        Me.DbPanel1.Controls.Add(Me.DbPanel4)
        Me.DbPanel1.Controls.Add(Me.Label1)
        Me.DbPanel1.Controls.Add(Me.Button2)
        Me.DbPanel1.Controls.Add(Me.Button3)
        Me.DbPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DbPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DbPanel1.Name = "DbPanel1"
        Me.DbPanel1.Size = New System.Drawing.Size(727, 371)
        Me.DbPanel1.TabIndex = 9
        '
        'DbPanel2
        '
        Me.DbPanel2.BackColor = System.Drawing.Color.DimGray
        Me.DbPanel2.Controls.Add(Me.Label2)
        Me.DbPanel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DbPanel2.Location = New System.Drawing.Point(16, 51)
        Me.DbPanel2.Name = "DbPanel2"
        Me.DbPanel2.Size = New System.Drawing.Size(302, 24)
        Me.DbPanel2.TabIndex = 125
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(2, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Shortcut Keys"
        '
        'DbPanel3
        '
        Me.DbPanel3.BackColor = System.Drawing.Color.DimGray
        Me.DbPanel3.Controls.Add(Me.Label3)
        Me.DbPanel3.Controls.Add(Me.TextBox3)
        Me.DbPanel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DbPanel3.Location = New System.Drawing.Point(324, 87)
        Me.DbPanel3.Name = "DbPanel3"
        Me.DbPanel3.Size = New System.Drawing.Size(391, 24)
        Me.DbPanel3.TabIndex = 125
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(2, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Title"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(0, -27)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(391, 21)
        Me.TextBox3.TabIndex = 29
        '
        'DbPanel27
        '
        Me.DbPanel27.BackColor = System.Drawing.Color.DimGray
        Me.DbPanel27.Controls.Add(Me.Label33)
        Me.DbPanel27.Controls.Add(Me.TextBox2)
        Me.DbPanel27.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DbPanel27.Location = New System.Drawing.Point(324, 134)
        Me.DbPanel27.Name = "DbPanel27"
        Me.DbPanel27.Size = New System.Drawing.Size(391, 24)
        Me.DbPanel27.TabIndex = 125
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label33.Location = New System.Drawing.Point(2, 5)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(44, 13)
        Me.Label33.TabIndex = 67
        Me.Label33.Text = "Content"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(0, -27)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(391, 21)
        Me.TextBox2.TabIndex = 29
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(324, 108)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(391, 28)
        Me.TextBox4.TabIndex = 29
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(324, 155)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(391, 171)
        Me.TextBox1.TabIndex = 29
        '
        'DGVCMSpiels
        '
        Me.DGVCMSpiels.AllowUserToAddRows = False
        Me.DGVCMSpiels.AllowUserToDeleteRows = False
        Me.DGVCMSpiels.AllowUserToResizeColumns = False
        Me.DGVCMSpiels.AllowUserToResizeRows = False
        Me.DGVCMSpiels.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DGVCMSpiels.AutoGenerateColumns = False
        Me.DGVCMSpiels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVCMSpiels.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVCMSpiels.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVCMSpiels.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.IndexDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.ContentDataGridViewTextBoxColumn})
        Me.DGVCMSpiels.DataSource = Me.CMShortcutKeysBindingSource
        Me.DGVCMSpiels.Location = New System.Drawing.Point(16, 72)
        Me.DGVCMSpiels.MultiSelect = False
        Me.DGVCMSpiels.Name = "DGVCMSpiels"
        Me.DGVCMSpiels.ReadOnly = True
        Me.DGVCMSpiels.RowHeadersVisible = False
        Me.DGVCMSpiels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCMSpiels.Size = New System.Drawing.Size(302, 254)
        Me.DGVCMSpiels.TabIndex = 28
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.FillWeight = 99.49239!
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'IndexDataGridViewTextBoxColumn
        '
        Me.IndexDataGridViewTextBoxColumn.DataPropertyName = "Index"
        Me.IndexDataGridViewTextBoxColumn.FillWeight = 51.0191!
        Me.IndexDataGridViewTextBoxColumn.HeaderText = "Index"
        Me.IndexDataGridViewTextBoxColumn.Name = "IndexDataGridViewTextBoxColumn"
        Me.IndexDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.FillWeight = 149.9961!
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContentDataGridViewTextBoxColumn
        '
        Me.ContentDataGridViewTextBoxColumn.DataPropertyName = "Content"
        Me.ContentDataGridViewTextBoxColumn.FillWeight = 99.49239!
        Me.ContentDataGridViewTextBoxColumn.HeaderText = "Content"
        Me.ContentDataGridViewTextBoxColumn.Name = "ContentDataGridViewTextBoxColumn"
        Me.ContentDataGridViewTextBoxColumn.ReadOnly = True
        Me.ContentDataGridViewTextBoxColumn.Visible = False
        '
        'CMShortcutKeysBindingSource
        '
        Me.CMShortcutKeysBindingSource.DataMember = "CMShortcutKeys"
        Me.CMShortcutKeysBindingSource.DataSource = Me.DbDataSetBindingSource
        '
        'DbDataSetBindingSource
        '
        Me.DbDataSetBindingSource.DataSource = Me.DbDataSet
        Me.DbDataSetBindingSource.Position = 0
        '
        'DbDataSet
        '
        Me.DbDataSet.DataSetName = "dbDataSet"
        Me.DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DbPanel4
        '
        Me.DbPanel4.BackColor = System.Drawing.Color.Red
        Me.DbPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.DbPanel4.Location = New System.Drawing.Point(0, 0)
        Me.DbPanel4.Name = "DbPanel4"
        Me.DbPanel4.Size = New System.Drawing.Size(727, 3)
        Me.DbPanel4.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "CM Manage Templates"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(605, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 33)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Firebrick
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(605, 332)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 33)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'CMShortcutKeysTableAdapter
        '
        Me.CMShortcutKeysTableAdapter.ClearBeforeFill = True
        '
        'CMManageTemplates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 371)
        Me.Controls.Add(Me.DbPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CMManageTemplates"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.DbPanel1.ResumeLayout(False)
        Me.DbPanel1.PerformLayout()
        Me.DbPanel2.ResumeLayout(False)
        Me.DbPanel2.PerformLayout()
        Me.DbPanel3.ResumeLayout(False)
        Me.DbPanel3.PerformLayout()
        Me.DbPanel27.ResumeLayout(False)
        Me.DbPanel27.PerformLayout()
        CType(Me.DGVCMSpiels, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMShortcutKeysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DbPanel1 As SIRTool.dbPanel
    Friend WithEvents DbPanel2 As SIRTool.dbPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DbPanel3 As SIRTool.dbPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents DbPanel27 As SIRTool.dbPanel
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DGVCMSpiels As System.Windows.Forms.DataGridView
    Friend WithEvents DbPanel4 As SIRTool.dbPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DbDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DbDataSet As SIRTool.dbDataSet
    Friend WithEvents CMShortcutKeysBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CMShortcutKeysTableAdapter As SIRTool.dbDataSetTableAdapters.CMShortcutKeysTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
