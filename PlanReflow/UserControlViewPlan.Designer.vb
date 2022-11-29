<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControlViewPlan
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlMecoPlanGroupTableAdapter1 = New PlanReflow.DBxDataSet1TableAdapters.PLMecoPlanGroupTableAdapter()
        Me.DBxDataSet11 = New PlanReflow.DBxDataSet1()
        Me.Period = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Package = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayPlan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESULT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RFWIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupPKG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBxDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(657, 638)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Turquoise
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 25
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Period, Me.Package, Me.DayPlan, Me.RESULT, Me.WIP, Me.RFWIP, Me.GroupPKG})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(0, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(657, 596)
        Me.DataGridView1.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.MintCream
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(657, 42)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Meco#0 Machine"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlMecoPlanGroupTableAdapter1
        '
        Me.PlMecoPlanGroupTableAdapter1.ClearBeforeFill = True
        '
        'DBxDataSet11
        '
        Me.DBxDataSet11.DataSetName = "DBxDataSet1"
        Me.DBxDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Period
        '
        Me.Period.DataPropertyName = "Period"
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        Me.Period.DefaultCellStyle = DataGridViewCellStyle2
        Me.Period.HeaderText = "Period"
        Me.Period.Name = "Period"
        Me.Period.ReadOnly = True
        Me.Period.Width = 75
        '
        'Package
        '
        Me.Package.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Package.DataPropertyName = "Package"
        Me.Package.HeaderText = "Package"
        Me.Package.Name = "Package"
        Me.Package.ReadOnly = True
        '
        'DayPlan
        '
        Me.DayPlan.DataPropertyName = "DayPlan"
        Me.DayPlan.HeaderText = "P"
        Me.DayPlan.Name = "DayPlan"
        Me.DayPlan.ReadOnly = True
        Me.DayPlan.Width = 28
        '
        'RESULT
        '
        Me.RESULT.DataPropertyName = "RESULT"
        Me.RESULT.HeaderText = "R"
        Me.RESULT.Name = "RESULT"
        Me.RESULT.ReadOnly = True
        Me.RESULT.Width = 28
        '
        'WIP
        '
        Me.WIP.DataPropertyName = "WIP"
        Me.WIP.HeaderText = "MW"
        Me.WIP.Name = "WIP"
        Me.WIP.ReadOnly = True
        Me.WIP.Width = 28
        '
        'RFWIP
        '
        Me.RFWIP.DataPropertyName = "RFWIP"
        Me.RFWIP.HeaderText = "RW"
        Me.RFWIP.Name = "RFWIP"
        Me.RFWIP.ReadOnly = True
        Me.RFWIP.Width = 28
        '
        'GroupPKG
        '
        Me.GroupPKG.DataPropertyName = "GroupPKG"
        Me.GroupPKG.HeaderText = "GroupPKG"
        Me.GroupPKG.Name = "GroupPKG"
        Me.GroupPKG.ReadOnly = True
        Me.GroupPKG.Visible = False
        '
        'UserControlViewPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserControlViewPlan"
        Me.Size = New System.Drawing.Size(657, 638)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBxDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PlMecoPlanGroupTableAdapter1 As DBxDataSet1TableAdapters.PLMecoPlanGroupTableAdapter
    Friend WithEvents DBxDataSet11 As DBxDataSet1
    Friend WithEvents Period As DataGridViewTextBoxColumn
    Friend WithEvents Package As DataGridViewTextBoxColumn
    Friend WithEvents DayPlan As DataGridViewTextBoxColumn
    Friend WithEvents RESULT As DataGridViewTextBoxColumn
    Friend WithEvents WIP As DataGridViewTextBoxColumn
    Friend WithEvents RFWIP As DataGridViewTextBoxColumn
    Friend WithEvents GroupPKG As DataGridViewTextBoxColumn
End Class
