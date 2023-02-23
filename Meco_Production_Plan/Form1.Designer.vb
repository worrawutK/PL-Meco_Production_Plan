<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DayNight = New System.Windows.Forms.Label()
        Me.lbPKGRUN = New System.Windows.Forms.Label()
        Me.Time = New System.Windows.Forms.Label()
        Me.TimerNow = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btAddUsage = New System.Windows.Forms.Button()
        Me.btUpdate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbOPNo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbTimeUpdate = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.CbPercentBooking = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btUpdateNewPKG = New System.Windows.Forms.Button()
        Me.lbWIP = New System.Windows.Forms.Label()
        Me.lbResult = New System.Windows.Forms.Label()
        Me.lbPlan = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lbMC = New System.Windows.Forms.Label()
        Me.btUp = New System.Windows.Forms.Button()
        Me.btDown = New System.Windows.Forms.Button()
        Me.pbOpno = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ViewTop3 = New System.Windows.Forms.DataGridView()
        Me.ViewPlanDay = New System.Windows.Forms.DataGridView()
        Me.btRemoveFromUsage = New System.Windows.Forms.Button()
        Me.btToolCheck = New System.Windows.Forms.Button()
        Me.TimerUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.lbStatusColor = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btOPERATION = New System.Windows.Forms.Button()
        Me.btWAITING = New System.Windows.Forms.Button()
        Me.btSTOP = New System.Windows.Forms.Button()
        Me.btBRAKETIME = New System.Windows.Forms.Button()
        Me.btTYPECHANGE = New System.Windows.Forms.Button()
        Me.btOPM = New System.Windows.Forms.Button()
        Me.btPMREQUEST = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btExit = New System.Windows.Forms.Button()
        Me.TimerlbShow = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxQr = New System.Windows.Forms.TextBox()
        Me.PictureBoxQr = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelQr = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TestWipSumTableAdapter1 = New Meco_Production_Plan.DBxDataSet1TableAdapters.TestWipSumTableAdapter()
        Me.PlMecoCapaDataTableAdapter1 = New Meco_Production_Plan.DBxDataSet1TableAdapters.PLMecoCapaDataTableAdapter()
        Me.ResultMecoTableAdapter1 = New Meco_Production_Plan.DBxDataSet1TableAdapters.ResultMecoTableAdapter()
        Me.PlMecoPlanGroupTableAdapter1 = New Meco_Production_Plan.DBxDataSet1TableAdapters.PLMecoPlanGroupTableAdapter()
        Me.DBxDataSet11 = New Meco_Production_Plan.DBxDataSet1()
        Me.PlMecoPlanData1TableAdapter1 = New Meco_Production_Plan.DBxDataSet1TableAdapters.PLMecoPlanData1TableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOpno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewTop3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewPlanDay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxQr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelQr.SuspendLayout()
        CType(Me.DBxDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DayNight
        '
        Me.DayNight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DayNight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DayNight.Location = New System.Drawing.Point(543, 120)
        Me.DayNight.Name = "DayNight"
        Me.DayNight.Size = New System.Drawing.Size(352, 25)
        Me.DayNight.TabIndex = 20
        Me.DayNight.Text = "Day or Night"
        Me.DayNight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DayNight.Visible = False
        '
        'lbPKGRUN
        '
        Me.lbPKGRUN.AutoSize = True
        Me.lbPKGRUN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPKGRUN.ForeColor = System.Drawing.Color.Red
        Me.lbPKGRUN.Location = New System.Drawing.Point(735, 20)
        Me.lbPKGRUN.Name = "lbPKGRUN"
        Me.lbPKGRUN.Size = New System.Drawing.Size(101, 25)
        Me.lbPKGRUN.TabIndex = 19
        Me.lbPKGRUN.Text = "PKGRUN"
        '
        'Time
        '
        Me.Time.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Time.Location = New System.Drawing.Point(885, 131)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(352, 25)
        Me.Time.TabIndex = 18
        Me.Time.Text = "DateTime"
        Me.Time.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TimerNow
        '
        Me.TimerNow.Enabled = True
        Me.TimerNow.Interval = 1000
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(31, 890)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1834, 114)
        Me.TextBox1.TabIndex = 17
        Me.TextBox1.Text = "Other Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(463, 39)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Meco#1 Machine Information"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1126, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "load"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'btAddUsage
        '
        Me.btAddUsage.Location = New System.Drawing.Point(954, 124)
        Me.btAddUsage.Name = "btAddUsage"
        Me.btAddUsage.Size = New System.Drawing.Size(75, 23)
        Me.btAddUsage.TabIndex = 10
        Me.btAddUsage.Text = "AddUsage"
        Me.btAddUsage.UseVisualStyleBackColor = True
        Me.btAddUsage.Visible = False
        '
        'btUpdate
        '
        Me.btUpdate.Location = New System.Drawing.Point(1596, 647)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(102, 53)
        Me.btUpdate.TabIndex = 10
        Me.btUpdate.Text = "Update"
        Me.btUpdate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(414, 54)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Shift Production Plan"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbOPNo
        '
        Me.lbOPNo.AutoSize = True
        Me.lbOPNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOPNo.Location = New System.Drawing.Point(1646, 480)
        Me.lbOPNo.Name = "lbOPNo"
        Me.lbOPNo.Size = New System.Drawing.Size(50, 16)
        Me.lbOPNo.TabIndex = 7
        Me.lbOPNo.Text = "OP No."
        Me.lbOPNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbTimeUpdate)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.CbPercentBooking)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btUpdateNewPKG)
        Me.Panel1.Controls.Add(Me.lbWIP)
        Me.Panel1.Controls.Add(Me.lbResult)
        Me.Panel1.Controls.Add(Me.lbPlan)
        Me.Panel1.Controls.Add(Me.DataGridView2)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.lbMC)
        Me.Panel1.Controls.Add(Me.btUp)
        Me.Panel1.Controls.Add(Me.btDown)
        Me.Panel1.Controls.Add(Me.lbOPNo)
        Me.Panel1.Controls.Add(Me.lbPKGRUN)
        Me.Panel1.Controls.Add(Me.btUpdate)
        Me.Panel1.Controls.Add(Me.pbOpno)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ViewTop3)
        Me.Panel1.Controls.Add(Me.ViewPlanDay)
        Me.Panel1.Location = New System.Drawing.Point(31, 162)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1834, 722)
        Me.Panel1.TabIndex = 15
        '
        'lbTimeUpdate
        '
        Me.lbTimeUpdate.AutoSize = True
        Me.lbTimeUpdate.Location = New System.Drawing.Point(1593, 501)
        Me.lbTimeUpdate.Name = "lbTimeUpdate"
        Me.lbTimeUpdate.Size = New System.Drawing.Size(48, 13)
        Me.lbTimeUpdate.TabIndex = 35
        Me.lbTimeUpdate.Text = "Update :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1638, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Percent Booking"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(1783, 1)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(45, 23)
        Me.Button6.TabIndex = 34
        Me.Button6.Text = "Set"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'CbPercentBooking
        '
        Me.CbPercentBooking.FormattingEnabled = True
        Me.CbPercentBooking.Items.AddRange(New Object() {"10", "20", "30", "40", "50", "60", "70", "80", "90", "100"})
        Me.CbPercentBooking.Location = New System.Drawing.Point(1730, 3)
        Me.CbPercentBooking.Name = "CbPercentBooking"
        Me.CbPercentBooking.Size = New System.Drawing.Size(47, 21)
        Me.CbPercentBooking.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(465, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 25)
        Me.Label1.TabIndex = 32
        '
        'btUpdateNewPKG
        '
        Me.btUpdateNewPKG.Location = New System.Drawing.Point(1596, 564)
        Me.btUpdateNewPKG.Name = "btUpdateNewPKG"
        Me.btUpdateNewPKG.Size = New System.Drawing.Size(102, 53)
        Me.btUpdateNewPKG.TabIndex = 32
        Me.btUpdateNewPKG.Text = "Update " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "New PKG."
        Me.btUpdateNewPKG.UseVisualStyleBackColor = True
        '
        'lbWIP
        '
        Me.lbWIP.AutoSize = True
        Me.lbWIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbWIP.ForeColor = System.Drawing.Color.Red
        Me.lbWIP.Location = New System.Drawing.Point(1452, 20)
        Me.lbWIP.Name = "lbWIP"
        Me.lbWIP.Size = New System.Drawing.Size(51, 25)
        Me.lbWIP.TabIndex = 31
        Me.lbWIP.Text = "WIP"
        '
        'lbResult
        '
        Me.lbResult.AutoSize = True
        Me.lbResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbResult.ForeColor = System.Drawing.Color.Red
        Me.lbResult.Location = New System.Drawing.Point(1287, 20)
        Me.lbResult.Name = "lbResult"
        Me.lbResult.Size = New System.Drawing.Size(73, 25)
        Me.lbResult.TabIndex = 31
        Me.lbResult.Text = "Result"
        '
        'lbPlan
        '
        Me.lbPlan.AutoSize = True
        Me.lbPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPlan.ForeColor = System.Drawing.Color.Red
        Me.lbPlan.Location = New System.Drawing.Point(1130, 20)
        Me.lbPlan.Name = "lbPlan"
        Me.lbPlan.Size = New System.Drawing.Size(55, 25)
        Me.lbPlan.TabIndex = 31
        Me.lbPlan.Text = "Plan"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(575, 378)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(558, 150)
        Me.DataGridView2.TabIndex = 23
        Me.DataGridView2.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(43, 378)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(526, 150)
        Me.DataGridView1.TabIndex = 23
        Me.DataGridView1.Visible = False
        '
        'lbMC
        '
        Me.lbMC.AutoSize = True
        Me.lbMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbMC.Location = New System.Drawing.Point(1591, 72)
        Me.lbMC.Name = "lbMC"
        Me.lbMC.Size = New System.Drawing.Size(162, 25)
        Me.lbMC.TabIndex = 30
        Me.lbMC.Text = "Select Package"
        '
        'btUp
        '
        Me.btUp.BackgroundImage = Global.Meco_Production_Plan.My.Resources.Resources.arrow_up
        Me.btUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btUp.Location = New System.Drawing.Point(1619, 105)
        Me.btUp.Name = "btUp"
        Me.btUp.Size = New System.Drawing.Size(49, 65)
        Me.btUp.TabIndex = 28
        Me.btUp.UseVisualStyleBackColor = True
        '
        'btDown
        '
        Me.btDown.BackgroundImage = Global.Meco_Production_Plan.My.Resources.Resources.arrow_down
        Me.btDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btDown.Location = New System.Drawing.Point(1619, 176)
        Me.btDown.Name = "btDown"
        Me.btDown.Size = New System.Drawing.Size(49, 65)
        Me.btDown.TabIndex = 26
        Me.btDown.UseVisualStyleBackColor = True
        '
        'pbOpno
        '
        Me.pbOpno.BackgroundImage = Global.Meco_Production_Plan.My.Resources.Resources.user
        Me.pbOpno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbOpno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbOpno.Location = New System.Drawing.Point(1596, 318)
        Me.pbOpno.Name = "pbOpno"
        Me.pbOpno.Size = New System.Drawing.Size(142, 159)
        Me.pbOpno.TabIndex = 5
        Me.pbOpno.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(414, 53)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Today Production Plan"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ViewTop3
        '
        Me.ViewTop3.AllowUserToAddRows = False
        Me.ViewTop3.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ViewTop3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ViewTop3.ColumnHeadersHeight = 50
        Me.ViewTop3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ViewTop3.Location = New System.Drawing.Point(27, 59)
        Me.ViewTop3.Name = "ViewTop3"
        Me.ViewTop3.ReadOnly = True
        Me.ViewTop3.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ViewTop3.RowTemplate.Height = 50
        Me.ViewTop3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewTop3.Size = New System.Drawing.Size(1548, 200)
        Me.ViewTop3.TabIndex = 4
        '
        'ViewPlanDay
        '
        Me.ViewPlanDay.AllowUserToAddRows = False
        Me.ViewPlanDay.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ViewPlanDay.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ViewPlanDay.ColumnHeadersHeight = 38
        Me.ViewPlanDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ViewPlanDay.Location = New System.Drawing.Point(27, 318)
        Me.ViewPlanDay.Name = "ViewPlanDay"
        Me.ViewPlanDay.ReadOnly = True
        Me.ViewPlanDay.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ViewPlanDay.RowTemplate.Height = 38
        Me.ViewPlanDay.Size = New System.Drawing.Size(1548, 382)
        Me.ViewPlanDay.TabIndex = 0
        '
        'btRemoveFromUsage
        '
        Me.btRemoveFromUsage.Location = New System.Drawing.Point(1035, 124)
        Me.btRemoveFromUsage.Name = "btRemoveFromUsage"
        Me.btRemoveFromUsage.Size = New System.Drawing.Size(75, 23)
        Me.btRemoveFromUsage.TabIndex = 31
        Me.btRemoveFromUsage.Text = "Remove"
        Me.btRemoveFromUsage.UseVisualStyleBackColor = True
        Me.btRemoveFromUsage.Visible = False
        '
        'btToolCheck
        '
        Me.btToolCheck.Location = New System.Drawing.Point(873, 124)
        Me.btToolCheck.Name = "btToolCheck"
        Me.btToolCheck.Size = New System.Drawing.Size(75, 23)
        Me.btToolCheck.TabIndex = 27
        Me.btToolCheck.Text = "Check"
        Me.btToolCheck.UseVisualStyleBackColor = True
        Me.btToolCheck.Visible = False
        '
        'TimerUpdate
        '
        Me.TimerUpdate.Interval = 300000
        '
        'lbStatus
        '
        Me.lbStatus.BackColor = System.Drawing.Color.White
        Me.lbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStatus.Location = New System.Drawing.Point(0, 0)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(1833, 66)
        Me.lbStatus.TabIndex = 21
        Me.lbStatus.Text = "OPERATION"
        Me.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbStatusColor
        '
        Me.lbStatusColor.BackColor = System.Drawing.Color.Green
        Me.lbStatusColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStatusColor.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbStatusColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStatusColor.Location = New System.Drawing.Point(0, 73)
        Me.lbStatusColor.Name = "lbStatusColor"
        Me.lbStatusColor.Size = New System.Drawing.Size(1833, 32)
        Me.lbStatusColor.TabIndex = 22
        Me.lbStatusColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbStatus)
        Me.Panel2.Controls.Add(Me.lbStatusColor)
        Me.Panel2.Location = New System.Drawing.Point(32, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1833, 105)
        Me.Panel2.TabIndex = 23
        '
        'btOPERATION
        '
        Me.btOPERATION.BackColor = System.Drawing.Color.Green
        Me.btOPERATION.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btOPERATION.ForeColor = System.Drawing.Color.White
        Me.btOPERATION.Location = New System.Drawing.Point(31, 1010)
        Me.btOPERATION.Name = "btOPERATION"
        Me.btOPERATION.Size = New System.Drawing.Size(138, 58)
        Me.btOPERATION.TabIndex = 24
        Me.btOPERATION.Text = "OPERATION"
        Me.btOPERATION.UseVisualStyleBackColor = False
        '
        'btWAITING
        '
        Me.btWAITING.BackColor = System.Drawing.Color.Yellow
        Me.btWAITING.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btWAITING.Location = New System.Drawing.Point(175, 1010)
        Me.btWAITING.Name = "btWAITING"
        Me.btWAITING.Size = New System.Drawing.Size(138, 58)
        Me.btWAITING.TabIndex = 24
        Me.btWAITING.Text = "WAITING LOT"
        Me.btWAITING.UseVisualStyleBackColor = False
        '
        'btSTOP
        '
        Me.btSTOP.BackColor = System.Drawing.Color.Yellow
        Me.btSTOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btSTOP.Location = New System.Drawing.Point(319, 1010)
        Me.btSTOP.Name = "btSTOP"
        Me.btSTOP.Size = New System.Drawing.Size(138, 58)
        Me.btSTOP.TabIndex = 24
        Me.btSTOP.Text = "PLAN STOP"
        Me.btSTOP.UseVisualStyleBackColor = False
        '
        'btBRAKETIME
        '
        Me.btBRAKETIME.BackColor = System.Drawing.Color.Yellow
        Me.btBRAKETIME.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btBRAKETIME.Location = New System.Drawing.Point(463, 1010)
        Me.btBRAKETIME.Name = "btBRAKETIME"
        Me.btBRAKETIME.Size = New System.Drawing.Size(138, 58)
        Me.btBRAKETIME.TabIndex = 24
        Me.btBRAKETIME.Text = "BRAKE TIME"
        Me.btBRAKETIME.UseVisualStyleBackColor = False
        '
        'btTYPECHANGE
        '
        Me.btTYPECHANGE.BackColor = System.Drawing.Color.RoyalBlue
        Me.btTYPECHANGE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btTYPECHANGE.ForeColor = System.Drawing.Color.White
        Me.btTYPECHANGE.Location = New System.Drawing.Point(607, 1010)
        Me.btTYPECHANGE.Name = "btTYPECHANGE"
        Me.btTYPECHANGE.Size = New System.Drawing.Size(138, 58)
        Me.btTYPECHANGE.TabIndex = 24
        Me.btTYPECHANGE.Text = "TYPE CHANGE"
        Me.btTYPECHANGE.UseVisualStyleBackColor = False
        '
        'btOPM
        '
        Me.btOPM.BackColor = System.Drawing.Color.RoyalBlue
        Me.btOPM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btOPM.ForeColor = System.Drawing.Color.White
        Me.btOPM.Location = New System.Drawing.Point(751, 1010)
        Me.btOPM.Name = "btOPM"
        Me.btOPM.Size = New System.Drawing.Size(138, 58)
        Me.btOPM.TabIndex = 24
        Me.btOPM.Text = "OPM"
        Me.btOPM.UseVisualStyleBackColor = False
        '
        'btPMREQUEST
        '
        Me.btPMREQUEST.BackColor = System.Drawing.Color.Red
        Me.btPMREQUEST.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btPMREQUEST.ForeColor = System.Drawing.Color.White
        Me.btPMREQUEST.Location = New System.Drawing.Point(894, 1010)
        Me.btPMREQUEST.Name = "btPMREQUEST"
        Me.btPMREQUEST.Size = New System.Drawing.Size(138, 58)
        Me.btPMREQUEST.TabIndex = 25
        Me.btPMREQUEST.Text = "PM REQUEST"
        Me.btPMREQUEST.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 30000
        '
        'btExit
        '
        Me.btExit.Location = New System.Drawing.Point(1774, 1010)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(91, 57)
        Me.btExit.TabIndex = 31
        Me.btExit.Text = "Exit"
        Me.btExit.UseVisualStyleBackColor = True
        '
        'TimerlbShow
        '
        Me.TimerlbShow.Interval = 500
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(1205, 842)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView3.TabIndex = 32
        Me.DataGridView3.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(486, 131)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 23)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "CHECKTOOL"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(583, 131)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "08:00:00"
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1240, 715)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Ver 1.22"
        '
        'TextBoxQr
        '
        Me.TextBoxQr.BackColor = System.Drawing.Color.White
        Me.TextBoxQr.Location = New System.Drawing.Point(1584, 1015)
        Me.TextBoxQr.Name = "TextBoxQr"
        Me.TextBoxQr.Size = New System.Drawing.Size(1, 20)
        Me.TextBoxQr.TabIndex = 37
        '
        'PictureBoxQr
        '
        Me.PictureBoxQr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxQr.Image = Global.Meco_Production_Plan.My.Resources.Resources.qr_code
        Me.PictureBoxQr.Location = New System.Drawing.Point(4, 4)
        Me.PictureBoxQr.Name = "PictureBoxQr"
        Me.PictureBoxQr.Size = New System.Drawing.Size(59, 51)
        Me.PictureBoxQr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxQr.TabIndex = 38
        Me.PictureBoxQr.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.Meco_Production_Plan.My.Resources.Resources.minimize_window_xxl
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(1676, 1009)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 58)
        Me.Button3.TabIndex = 36
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PanelQr
        '
        Me.PanelQr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelQr.Controls.Add(Me.PictureBoxQr)
        Me.PanelQr.Location = New System.Drawing.Point(1591, 1010)
        Me.PanelQr.Name = "PanelQr"
        Me.PanelQr.Size = New System.Drawing.Size(69, 61)
        Me.PanelQr.TabIndex = 39
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(32, 1071)
        Me.ProgressBar1.Maximum = 252
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1833, 6)
        Me.ProgressBar1.TabIndex = 40
        '
        'TestWipSumTableAdapter1
        '
        Me.TestWipSumTableAdapter1.ClearBeforeFill = True
        '
        'PlMecoCapaDataTableAdapter1
        '
        Me.PlMecoCapaDataTableAdapter1.ClearBeforeFill = True
        '
        'ResultMecoTableAdapter1
        '
        Me.ResultMecoTableAdapter1.ClearBeforeFill = True
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
        'PlMecoPlanData1TableAdapter1
        '
        Me.PlMecoPlanData1TableAdapter1.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1292, 732)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.PanelQr)
        Me.Controls.Add(Me.TextBoxQr)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.btRemoveFromUsage)
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.btPMREQUEST)
        Me.Controls.Add(Me.btOPM)
        Me.Controls.Add(Me.btTYPECHANGE)
        Me.Controls.Add(Me.btBRAKETIME)
        Me.Controls.Add(Me.btToolCheck)
        Me.Controls.Add(Me.btSTOP)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btWAITING)
        Me.Controls.Add(Me.btOPERATION)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btAddUsage)
        Me.Controls.Add(Me.DayNight)
        Me.Controls.Add(Me.Time)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOpno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewTop3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewPlanDay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxQr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelQr.ResumeLayout(False)
        CType(Me.DBxDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TestWipSumTableAdapter1 As DBxDataSet1TableAdapters.TestWipSumTableAdapter
    Friend WithEvents PlMecoCapaDataTableAdapter1 As DBxDataSet1TableAdapters.PLMecoCapaDataTableAdapter
    Friend WithEvents ResultMecoTableAdapter1 As DBxDataSet1TableAdapters.ResultMecoTableAdapter
    Friend WithEvents PlMecoPlanGroupTableAdapter1 As DBxDataSet1TableAdapters.PLMecoPlanGroupTableAdapter
    Friend WithEvents DBxDataSet11 As DBxDataSet1
    Friend WithEvents DayNight As Label
    Friend WithEvents lbPKGRUN As Label
    Friend WithEvents Time As Label
    Friend WithEvents TimerNow As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btAddUsage As Button
    Friend WithEvents btUpdate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lbOPNo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbOpno As PictureBox
    Friend WithEvents ViewTop3 As DataGridView
    Friend WithEvents ViewPlanDay As DataGridView
    Friend WithEvents TimerUpdate As Timer
    Friend WithEvents PlMecoPlanData1TableAdapter1 As DBxDataSet1TableAdapters.PLMecoPlanData1TableAdapter
    Friend WithEvents lbStatus As Label
    Friend WithEvents lbStatusColor As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btOPERATION As Button
    Friend WithEvents btWAITING As Button
    Friend WithEvents btSTOP As Button
    Friend WithEvents btBRAKETIME As Button
    Friend WithEvents btTYPECHANGE As Button
    Friend WithEvents btOPM As Button
    Friend WithEvents btPMREQUEST As Button
    Friend WithEvents btToolCheck As Button
    Friend WithEvents btDown As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents btUp As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbMC As Label
    Friend WithEvents btExit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btRemoveFromUsage As Button
    Friend WithEvents lbWIP As Label
    Friend WithEvents lbResult As Label
    Friend WithEvents lbPlan As Label
    Friend WithEvents TimerlbShow As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents btUpdateNewPKG As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents CbPercentBooking As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lbTimeUpdate As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBoxQr As TextBox
    Friend WithEvents PictureBoxQr As PictureBox
    Friend WithEvents PanelQr As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
