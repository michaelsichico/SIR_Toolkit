<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSR
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
        Me.SRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbDataSet = New EmailBank.dbDataSet()
        Me.DbPanel3 = New EmailBank.DBPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SRTableAdapter = New EmailBank.dbDataSetTableAdapters.SRTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DbPanel1 = New EmailBank.DBPanel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DbPanel4 = New EmailBank.DBPanel()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShiftDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailTemplateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AHT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DbPanel2 = New EmailBank.DBPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.SRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DbPanel3.SuspendLayout()
        Me.DbPanel1.SuspendLayout()
        Me.DbPanel4.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DbPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SRBindingSource
        '
        Me.SRBindingSource.DataMember = "SR"
        Me.SRBindingSource.DataSource = Me.DbDataSet
        '
        'DbDataSet
        '
        Me.DbDataSet.DataSetName = "dbDataSet"
        Me.DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DbPanel3
        '
        Me.DbPanel3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.DbPanel3.Controls.Add(Me.Button1)
        Me.DbPanel3.Controls.Add(Me.Button2)
        Me.DbPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DbPanel3.Location = New System.Drawing.Point(0, 453)
        Me.DbPanel3.Name = "DbPanel3"
        Me.DbPanel3.Size = New System.Drawing.Size(518, 42)
        Me.DbPanel3.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(306, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(411, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 32)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SRTableAdapter
        '
        Me.SRTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        '
        'DbPanel1
        '
        Me.DbPanel1.BackgroundImage = Global.EmailBank.My.Resources.Resources.subbgb
        Me.DbPanel1.Controls.Add(Me.DateTimePicker1)
        Me.DbPanel1.Controls.Add(Me.Button4)
        Me.DbPanel1.Controls.Add(Me.Button3)
        Me.DbPanel1.Controls.Add(Me.DbPanel4)
        Me.DbPanel1.Controls.Add(Me.TextBox1)
        Me.DbPanel1.Controls.Add(Me.Label2)
        Me.DbPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DbPanel1.Location = New System.Drawing.Point(0, 56)
        Me.DbPanel1.Name = "DbPanel1"
        Me.DbPanel1.Size = New System.Drawing.Size(518, 397)
        Me.DbPanel1.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(306, 11)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DimGray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(270, 9)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(27, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "R"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DimGray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(200, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(67, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'DbPanel4
        '
        Me.DbPanel4.Controls.Add(Me.DGV)
        Me.DbPanel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DbPanel4.Location = New System.Drawing.Point(0, 39)
        Me.DbPanel4.Name = "DbPanel4"
        Me.DbPanel4.Size = New System.Drawing.Size(518, 358)
        Me.DbPanel4.TabIndex = 6
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
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.SRDataGridViewTextBoxColumn, Me.ShiftDateDataGridViewTextBoxColumn, Me.EmailTemplateDataGridViewTextBoxColumn, Me.AHT, Me.EmailTitle})
        Me.DGV.DataSource = Me.SRBindingSource
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV.Location = New System.Drawing.Point(0, 0)
        Me.DGV.MultiSelect = False
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(518, 358)
        Me.DGV.TabIndex = 5
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
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
        'AHT
        '
        Me.AHT.DataPropertyName = "AHT"
        Me.AHT.HeaderText = "AHT"
        Me.AHT.Name = "AHT"
        Me.AHT.ReadOnly = True
        '
        'EmailTitle
        '
        Me.EmailTitle.DataPropertyName = "EmailTitle"
        Me.EmailTitle.HeaderText = "Email Template"
        Me.EmailTitle.Name = "EmailTitle"
        Me.EmailTitle.ReadOnly = True
        Me.EmailTitle.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(44, 10)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(152, 21)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(14, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "SR"
        '
        'DbPanel2
        '
        Me.DbPanel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.DbPanel2.BackgroundImage = Global.EmailBank.My.Resources.Resources.header_trans
        Me.DbPanel2.Controls.Add(Me.Label3)
        Me.DbPanel2.Controls.Add(Me.Label1)
        Me.DbPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.DbPanel2.Location = New System.Drawing.Point(0, 0)
        Me.DbPanel2.Name = "DbPanel2"
        Me.DbPanel2.Size = New System.Drawing.Size(518, 56)
        Me.DbPanel2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(330, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "0 Email Processed Today"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SR Record"
        '
        'ViewSR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 495)
        Me.Controls.Add(Me.DbPanel1)
        Me.Controls.Add(Me.DbPanel3)
        Me.Controls.Add(Me.DbPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewSR"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.SRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DbPanel3.ResumeLayout(False)
        Me.DbPanel1.ResumeLayout(False)
        Me.DbPanel1.PerformLayout()
        Me.DbPanel4.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DbPanel2.ResumeLayout(False)
        Me.DbPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DbPanel1 As EmailBank.DBPanel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DbPanel3 As EmailBank.DBPanel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DbPanel2 As EmailBank.DBPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DbPanel4 As EmailBank.DBPanel
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DbDataSet As EmailBank.dbDataSet
    Friend WithEvents SRBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SRTableAdapter As EmailBank.dbDataSetTableAdapters.SRTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShiftDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailTemplateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AHT As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
