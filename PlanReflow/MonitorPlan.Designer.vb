<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MonitorPlan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MonitorPlan))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelTimeUpdate = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelVer = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MecoNo05 = New PlanReflow.UserControlViewPlan()
        Me.MecoNo01 = New PlanReflow.UserControlViewPlan()
        Me.MecoNo02 = New PlanReflow.UserControlViewPlan()
        Me.MecoNo03 = New PlanReflow.UserControlViewPlan()
        Me.MecoNo04 = New PlanReflow.UserControlViewPlan()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btExit = New System.Windows.Forms.Button()
        Me.RfwipTableAdapter1 = New PlanReflow.DBxDataSet1TableAdapters.RFWIPTableAdapter()
        Me.DBxDataSet11 = New PlanReflow.DBxDataSet1()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DBxDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LabelTimeUpdate)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LabelVer)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btExit)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1342, 744)
        Me.Panel1.TabIndex = 33
        '
        'LabelTimeUpdate
        '
        Me.LabelTimeUpdate.AutoSize = True
        Me.LabelTimeUpdate.Location = New System.Drawing.Point(7, 660)
        Me.LabelTimeUpdate.Name = "LabelTimeUpdate"
        Me.LabelTimeUpdate.Size = New System.Drawing.Size(112, 13)
        Me.LabelTimeUpdate.TabIndex = 58
        Me.LabelTimeUpdate.Text = "Update  In: 00:00 min."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(585, 709)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 20)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "RW : Reflow WIP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(329, 709)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "R : Result"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(438, 709)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 20)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "MW : Meco WIP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 709)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "P : Plan"
        '
        'LabelVer
        '
        Me.LabelVer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelVer.AutoSize = True
        Me.LabelVer.Location = New System.Drawing.Point(1287, 8)
        Me.LabelVer.Name = "LabelVer"
        Me.LabelVer.Size = New System.Drawing.Size(44, 13)
        Me.LabelVer.TabIndex = 56
        Me.LabelVer.Text = "Ver2.02"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MecoNo05)
        Me.Panel2.Controls.Add(Me.MecoNo01)
        Me.Panel2.Controls.Add(Me.MecoNo02)
        Me.Panel2.Controls.Add(Me.MecoNo03)
        Me.Panel2.Controls.Add(Me.MecoNo04)
        Me.Panel2.Location = New System.Drawing.Point(-1, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1342, 580)
        Me.Panel2.TabIndex = 55
        '
        'MecoNo05
        '
        Me.MecoNo05.Location = New System.Drawing.Point(2, 16)
        Me.MecoNo05.Machine = Nothing
        Me.MecoNo05.MachineName = Nothing
        Me.MecoNo05.Name = "MecoNo05"
        Me.MecoNo05.Size = New System.Drawing.Size(267, 557)
        Me.MecoNo05.TabIndex = 59
        '
        'MecoNo01
        '
        Me.MecoNo01.Location = New System.Drawing.Point(1074, 16)
        Me.MecoNo01.Machine = Nothing
        Me.MecoNo01.MachineName = Nothing
        Me.MecoNo01.Name = "MecoNo01"
        Me.MecoNo01.Size = New System.Drawing.Size(267, 557)
        Me.MecoNo01.TabIndex = 0
        '
        'MecoNo02
        '
        Me.MecoNo02.Location = New System.Drawing.Point(806, 16)
        Me.MecoNo02.Machine = Nothing
        Me.MecoNo02.MachineName = Nothing
        Me.MecoNo02.Name = "MecoNo02"
        Me.MecoNo02.Size = New System.Drawing.Size(267, 557)
        Me.MecoNo02.TabIndex = 0
        '
        'MecoNo03
        '
        Me.MecoNo03.Location = New System.Drawing.Point(538, 16)
        Me.MecoNo03.Machine = Nothing
        Me.MecoNo03.MachineName = Nothing
        Me.MecoNo03.Name = "MecoNo03"
        Me.MecoNo03.Size = New System.Drawing.Size(267, 557)
        Me.MecoNo03.TabIndex = 0
        '
        'MecoNo04
        '
        Me.MecoNo04.Location = New System.Drawing.Point(270, 16)
        Me.MecoNo04.Machine = Nothing
        Me.MecoNo04.MachineName = Nothing
        Me.MecoNo04.Name = "MecoNo04"
        Me.MecoNo04.Size = New System.Drawing.Size(267, 557)
        Me.MecoNo04.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(163, 709)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 20)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Run"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(163, 685)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 20)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Stop"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LawnGreen
        Me.Label5.Location = New System.Drawing.Point(56, 708)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(56, 682)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 48
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Location = New System.Drawing.Point(20, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(482, 56)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "Meco Shift Production Plan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btExit
        '
        Me.btExit.Location = New System.Drawing.Point(1215, 682)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(120, 57)
        Me.btExit.TabIndex = 46
        Me.btExit.Text = "Exit"
        Me.btExit.UseVisualStyleBackColor = True
        '
        'RfwipTableAdapter1
        '
        Me.RfwipTableAdapter1.ClearBeforeFill = True
        '
        'DBxDataSet11
        '
        Me.DBxDataSet11.DataSetName = "DBxDataSet1"
        Me.DBxDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'MonitorPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MonitorPlan"
        Me.Text = "MonitorPlan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DBxDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btExit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MecoNo02 As UserControlViewPlan
    Friend WithEvents MecoNo03 As UserControlViewPlan
    Friend WithEvents MecoNo04 As UserControlViewPlan
    Friend WithEvents MecoNo01 As UserControlViewPlan
    Friend WithEvents RfwipTableAdapter1 As DBxDataSet1TableAdapters.RFWIPTableAdapter
    Friend WithEvents LabelVer As Label
    Friend WithEvents DBxDataSet11 As DBxDataSet1
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelTimeUpdate As Label
    Friend WithEvents MecoNo05 As UserControlViewPlan
End Class
