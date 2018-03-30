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
        Me.ViewCapa = New System.Windows.Forms.DataGridView()
        Me.PackageDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLotRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeChangeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLMecoCapaDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBxDataSet = New Meco_Production_PlanSetting.DBxDataSet()
        Me.TapControl = New System.Windows.Forms.TabControl()
        Me.AddPlan = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DatePlan = New System.Windows.Forms.DateTimePicker()
        Me.MCNo1 = New System.Windows.Forms.RadioButton()
        Me.MCNo2 = New System.Windows.Forms.RadioButton()
        Me.MCNo4 = New System.Windows.Forms.RadioButton()
        Me.MCNo3 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MCNoEx4 = New System.Windows.Forms.RadioButton()
        Me.MCNoEx3 = New System.Windows.Forms.RadioButton()
        Me.MCNoEx2 = New System.Windows.Forms.RadioButton()
        Me.MCNoEx1 = New System.Windows.Forms.RadioButton()
        Me.DateExPlan = New System.Windows.Forms.DateTimePicker()
        Me.ViewPlan = New System.Windows.Forms.DataGridView()
        Me.ViewEXPlan = New System.Windows.Forms.DataGridView()
        Me.EditCapa = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.EditPlan = New System.Windows.Forms.TabPage()
        Me.ViewEdit = New System.Windows.Forms.DataGridView()
        Me.PackageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayPlanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MCNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlanDayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupPKGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLMecoPlanDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btSaveEditPlan = New System.Windows.Forms.Button()
        Me.MCNoEdit3 = New System.Windows.Forms.RadioButton()
        Me.MCNoEdit2 = New System.Windows.Forms.RadioButton()
        Me.MCNoEdit1 = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.SettingJIG = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NameJIGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UseJIGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeToolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLMecoJigToolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SettingGroup = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TypeJIG2 = New System.Windows.Forms.ComboBox()
        Me.TypeJIG14 = New System.Windows.Forms.ComboBox()
        Me.TypeJIG7 = New System.Windows.Forms.ComboBox()
        Me.TypeJIG4 = New System.Windows.Forms.ComboBox()
        Me.TypeJIG8 = New System.Windows.Forms.ComboBox()
        Me.TypeJIG12 = New System.Windows.Forms.ComboBox()
        Me.TypeJIG11 = New System.Windows.Forms.ComboBox()
        Me.TypeJIG6 = New System.Windows.Forms.ComboBox()
        Me.TypeJIG1 = New System.Windows.Forms.ComboBox()
        Me.TypeJIG15 = New System.Windows.Forms.ComboBox()
        Me.TypeJIG13 = New System.Windows.Forms.ComboBox()
        Me.TypeJIG9 = New System.Windows.Forms.ComboBox()
        Me.TypeJIG16 = New System.Windows.Forms.ComboBox()
        Me.TypeJIG3 = New System.Windows.Forms.ComboBox()
        Me.TypeJIG5 = New System.Windows.Forms.ComboBox()
        Me.TypeJIG10 = New System.Windows.Forms.ComboBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbGroup = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.JIG2 = New System.Windows.Forms.ComboBox()
        Me.JIG10 = New System.Windows.Forms.ComboBox()
        Me.JIG7 = New System.Windows.Forms.ComboBox()
        Me.JIG3 = New System.Windows.Forms.ComboBox()
        Me.JIG5 = New System.Windows.Forms.ComboBox()
        Me.JIG14 = New System.Windows.Forms.ComboBox()
        Me.JIG13 = New System.Windows.Forms.ComboBox()
        Me.JIG16 = New System.Windows.Forms.ComboBox()
        Me.JIG9 = New System.Windows.Forms.ComboBox()
        Me.JIG6 = New System.Windows.Forms.ComboBox()
        Me.JIG12 = New System.Windows.Forms.ComboBox()
        Me.JIG15 = New System.Windows.Forms.ComboBox()
        Me.JIG4 = New System.Windows.Forms.ComboBox()
        Me.JIG11 = New System.Windows.Forms.ComboBox()
        Me.JIG1 = New System.Windows.Forms.ComboBox()
        Me.JIG8 = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.NumberJIG7 = New System.Windows.Forms.ComboBox()
        Me.NumberJIG10 = New System.Windows.Forms.ComboBox()
        Me.NumberJIG6 = New System.Windows.Forms.ComboBox()
        Me.NumberJIG4 = New System.Windows.Forms.ComboBox()
        Me.NumberJIG16 = New System.Windows.Forms.ComboBox()
        Me.NumberJIG2 = New System.Windows.Forms.ComboBox()
        Me.NumberJIG15 = New System.Windows.Forms.ComboBox()
        Me.NumberJIG12 = New System.Windows.Forms.ComboBox()
        Me.NumberJIG1 = New System.Windows.Forms.ComboBox()
        Me.NumberJIG11 = New System.Windows.Forms.ComboBox()
        Me.NumberJIG8 = New System.Windows.Forms.ComboBox()
        Me.NumberJIG14 = New System.Windows.Forms.ComboBox()
        Me.NumberJIG9 = New System.Windows.Forms.ComboBox()
        Me.NumberJIG5 = New System.Windows.Forms.ComboBox()
        Me.NumberJIG13 = New System.Windows.Forms.ComboBox()
        Me.NumberJIG3 = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.PLMecoToolTypeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLMecoToolTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectGroup = New System.Windows.Forms.TabPage()
        Me.PLMecoToolTypeDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btSaveSelectGroup = New System.Windows.Forms.Button()
        Me.ViewGroup = New System.Windows.Forms.DataGridView()
        Me.cbGroup = New System.Windows.Forms.ComboBox()
        Me.cbPackage = New System.Windows.Forms.ComboBox()
        Me.lbMecoPlan = New System.Windows.Forms.Label()
        Me.DBxDataSet1 = New Meco_Production_PlanSetting.DBxDataSet()
        Me.PLMecoCapaDataTableAdapter = New Meco_Production_PlanSetting.DBxDataSetTableAdapters.PLMecoCapaDataTableAdapter()
        Me.PLMecoPlanDataTableAdapter = New Meco_Production_PlanSetting.DBxDataSetTableAdapters.PLMecoPlanDataTableAdapter()
        Me.PlanDateTableAdapter1 = New Meco_Production_PlanSetting.DBxDataSetTableAdapters.PlanDateTableAdapter()
        Me.PLMecoJigToolTableAdapter = New Meco_Production_PlanSetting.DBxDataSetTableAdapters.PLMecoJigToolTableAdapter()
        Me.PLMecoToolTypeTableAdapter = New Meco_Production_PlanSetting.DBxDataSetTableAdapters.PLMecoToolTypeTableAdapter()
        Me.ToolTypeListTableAdapter1 = New Meco_Production_PlanSetting.DBxDataSetTableAdapters.ToolTypeListTableAdapter()
        Me.TableAdapterManager = New Meco_Production_PlanSetting.DBxDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ViewCapa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLMecoCapaDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBxDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TapControl.SuspendLayout()
        Me.AddPlan.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ViewPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewEXPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EditCapa.SuspendLayout()
        Me.EditPlan.SuspendLayout()
        CType(Me.ViewEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLMecoPlanDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SettingJIG.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLMecoJigToolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SettingGroup.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PLMecoToolTypeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLMecoToolTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SelectGroup.SuspendLayout()
        CType(Me.PLMecoToolTypeDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBxDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ViewCapa
        '
        Me.ViewCapa.AutoGenerateColumns = False
        Me.ViewCapa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewCapa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PackageDataGridViewTextBoxColumn1, Me.FLotRateDataGridViewTextBoxColumn, Me.TypeChangeDataGridViewTextBoxColumn, Me.CapaDataGridViewTextBoxColumn})
        Me.ViewCapa.DataSource = Me.PLMecoCapaDataBindingSource
        Me.ViewCapa.Location = New System.Drawing.Point(22, 40)
        Me.ViewCapa.Name = "ViewCapa"
        Me.ViewCapa.Size = New System.Drawing.Size(844, 361)
        Me.ViewCapa.TabIndex = 1
        '
        'PackageDataGridViewTextBoxColumn1
        '
        Me.PackageDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PackageDataGridViewTextBoxColumn1.DataPropertyName = "Package"
        Me.PackageDataGridViewTextBoxColumn1.HeaderText = "Package"
        Me.PackageDataGridViewTextBoxColumn1.Name = "PackageDataGridViewTextBoxColumn1"
        '
        'FLotRateDataGridViewTextBoxColumn
        '
        Me.FLotRateDataGridViewTextBoxColumn.DataPropertyName = "F_LotRate"
        Me.FLotRateDataGridViewTextBoxColumn.HeaderText = "F_LotRate"
        Me.FLotRateDataGridViewTextBoxColumn.Name = "FLotRateDataGridViewTextBoxColumn"
        '
        'TypeChangeDataGridViewTextBoxColumn
        '
        Me.TypeChangeDataGridViewTextBoxColumn.DataPropertyName = "TypeChange"
        Me.TypeChangeDataGridViewTextBoxColumn.HeaderText = "TypeChange"
        Me.TypeChangeDataGridViewTextBoxColumn.Name = "TypeChangeDataGridViewTextBoxColumn"
        '
        'CapaDataGridViewTextBoxColumn
        '
        Me.CapaDataGridViewTextBoxColumn.DataPropertyName = "Capa"
        Me.CapaDataGridViewTextBoxColumn.HeaderText = "Capa"
        Me.CapaDataGridViewTextBoxColumn.Name = "CapaDataGridViewTextBoxColumn"
        '
        'PLMecoCapaDataBindingSource
        '
        Me.PLMecoCapaDataBindingSource.DataMember = "PLMecoCapaData"
        Me.PLMecoCapaDataBindingSource.DataSource = Me.DBxDataSet
        '
        'DBxDataSet
        '
        Me.DBxDataSet.DataSetName = "DBxDataSet"
        Me.DBxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TapControl
        '
        Me.TapControl.Controls.Add(Me.AddPlan)
        Me.TapControl.Controls.Add(Me.EditCapa)
        Me.TapControl.Controls.Add(Me.EditPlan)
        Me.TapControl.Controls.Add(Me.SettingJIG)
        Me.TapControl.Controls.Add(Me.SettingGroup)
        Me.TapControl.Controls.Add(Me.SelectGroup)
        Me.TapControl.Location = New System.Drawing.Point(33, 47)
        Me.TapControl.Name = "TapControl"
        Me.TapControl.SelectedIndex = 0
        Me.TapControl.Size = New System.Drawing.Size(1031, 650)
        Me.TapControl.TabIndex = 2
        '
        'AddPlan
        '
        Me.AddPlan.Controls.Add(Me.Panel1)
        Me.AddPlan.Controls.Add(Me.MCNoEx4)
        Me.AddPlan.Controls.Add(Me.MCNoEx3)
        Me.AddPlan.Controls.Add(Me.MCNoEx2)
        Me.AddPlan.Controls.Add(Me.MCNoEx1)
        Me.AddPlan.Controls.Add(Me.DateExPlan)
        Me.AddPlan.Controls.Add(Me.ViewPlan)
        Me.AddPlan.Controls.Add(Me.ViewEXPlan)
        Me.AddPlan.Location = New System.Drawing.Point(4, 22)
        Me.AddPlan.Name = "AddPlan"
        Me.AddPlan.Padding = New System.Windows.Forms.Padding(3)
        Me.AddPlan.Size = New System.Drawing.Size(1023, 624)
        Me.AddPlan.TabIndex = 1
        Me.AddPlan.Text = "Add Plan"
        Me.AddPlan.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DatePlan)
        Me.Panel1.Controls.Add(Me.MCNo1)
        Me.Panel1.Controls.Add(Me.MCNo2)
        Me.Panel1.Controls.Add(Me.MCNo4)
        Me.Panel1.Controls.Add(Me.MCNo3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(21, 466)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 96)
        Me.Panel1.TabIndex = 12
        '
        'DatePlan
        '
        Me.DatePlan.Location = New System.Drawing.Point(7, 13)
        Me.DatePlan.Name = "DatePlan"
        Me.DatePlan.Size = New System.Drawing.Size(200, 20)
        Me.DatePlan.TabIndex = 3
        '
        'MCNo1
        '
        Me.MCNo1.AutoSize = True
        Me.MCNo1.Checked = True
        Me.MCNo1.Location = New System.Drawing.Point(7, 45)
        Me.MCNo1.Name = "MCNo1"
        Me.MCNo1.Size = New System.Drawing.Size(65, 17)
        Me.MCNo1.TabIndex = 6
        Me.MCNo1.TabStop = True
        Me.MCNo1.Text = "PL-M-01"
        Me.MCNo1.UseVisualStyleBackColor = True
        '
        'MCNo2
        '
        Me.MCNo2.AutoSize = True
        Me.MCNo2.Location = New System.Drawing.Point(78, 45)
        Me.MCNo2.Name = "MCNo2"
        Me.MCNo2.Size = New System.Drawing.Size(65, 17)
        Me.MCNo2.TabIndex = 6
        Me.MCNo2.Text = "PL-M-02"
        Me.MCNo2.UseVisualStyleBackColor = True
        '
        'MCNo4
        '
        Me.MCNo4.AutoSize = True
        Me.MCNo4.Location = New System.Drawing.Point(220, 45)
        Me.MCNo4.Name = "MCNo4"
        Me.MCNo4.Size = New System.Drawing.Size(65, 17)
        Me.MCNo4.TabIndex = 6
        Me.MCNo4.Text = "PL-M-04"
        Me.MCNo4.UseVisualStyleBackColor = True
        '
        'MCNo3
        '
        Me.MCNo3.AutoSize = True
        Me.MCNo3.Location = New System.Drawing.Point(149, 45)
        Me.MCNo3.Name = "MCNo3"
        Me.MCNo3.Size = New System.Drawing.Size(65, 17)
        Me.MCNo3.TabIndex = 6
        Me.MCNo3.Text = "PL-M-03"
        Me.MCNo3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add Plan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MCNoEx4
        '
        Me.MCNoEx4.AutoSize = True
        Me.MCNoEx4.Location = New System.Drawing.Point(232, 19)
        Me.MCNoEx4.Name = "MCNoEx4"
        Me.MCNoEx4.Size = New System.Drawing.Size(65, 17)
        Me.MCNoEx4.TabIndex = 9
        Me.MCNoEx4.Text = "PL-M-04"
        Me.MCNoEx4.UseVisualStyleBackColor = True
        '
        'MCNoEx3
        '
        Me.MCNoEx3.AutoSize = True
        Me.MCNoEx3.Location = New System.Drawing.Point(161, 19)
        Me.MCNoEx3.Name = "MCNoEx3"
        Me.MCNoEx3.Size = New System.Drawing.Size(65, 17)
        Me.MCNoEx3.TabIndex = 9
        Me.MCNoEx3.Text = "PL-M-03"
        Me.MCNoEx3.UseVisualStyleBackColor = True
        '
        'MCNoEx2
        '
        Me.MCNoEx2.AutoSize = True
        Me.MCNoEx2.Location = New System.Drawing.Point(92, 19)
        Me.MCNoEx2.Name = "MCNoEx2"
        Me.MCNoEx2.Size = New System.Drawing.Size(65, 17)
        Me.MCNoEx2.TabIndex = 10
        Me.MCNoEx2.Text = "PL-M-02"
        Me.MCNoEx2.UseVisualStyleBackColor = True
        '
        'MCNoEx1
        '
        Me.MCNoEx1.AutoSize = True
        Me.MCNoEx1.Checked = True
        Me.MCNoEx1.Location = New System.Drawing.Point(21, 19)
        Me.MCNoEx1.Name = "MCNoEx1"
        Me.MCNoEx1.Size = New System.Drawing.Size(65, 17)
        Me.MCNoEx1.TabIndex = 11
        Me.MCNoEx1.TabStop = True
        Me.MCNoEx1.Text = "PL-M-01"
        Me.MCNoEx1.UseVisualStyleBackColor = True
        '
        'DateExPlan
        '
        Me.DateExPlan.Location = New System.Drawing.Point(21, 51)
        Me.DateExPlan.Name = "DateExPlan"
        Me.DateExPlan.Size = New System.Drawing.Size(200, 20)
        Me.DateExPlan.TabIndex = 8
        '
        'ViewPlan
        '
        Me.ViewPlan.AllowUserToAddRows = False
        Me.ViewPlan.AllowUserToDeleteRows = False
        Me.ViewPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewPlan.Location = New System.Drawing.Point(377, 87)
        Me.ViewPlan.Name = "ViewPlan"
        Me.ViewPlan.ReadOnly = True
        Me.ViewPlan.Size = New System.Drawing.Size(603, 377)
        Me.ViewPlan.TabIndex = 2
        '
        'ViewEXPlan
        '
        Me.ViewEXPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewEXPlan.Location = New System.Drawing.Point(21, 83)
        Me.ViewEXPlan.Name = "ViewEXPlan"
        Me.ViewEXPlan.Size = New System.Drawing.Size(320, 377)
        Me.ViewEXPlan.TabIndex = 0
        '
        'EditCapa
        '
        Me.EditCapa.Controls.Add(Me.Button3)
        Me.EditCapa.Controls.Add(Me.ViewCapa)
        Me.EditCapa.Location = New System.Drawing.Point(4, 22)
        Me.EditCapa.Name = "EditCapa"
        Me.EditCapa.Padding = New System.Windows.Forms.Padding(3)
        Me.EditCapa.Size = New System.Drawing.Size(942, 624)
        Me.EditCapa.TabIndex = 0
        Me.EditCapa.Text = "Edit Capa"
        Me.EditCapa.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(22, 407)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'EditPlan
        '
        Me.EditPlan.Controls.Add(Me.ViewEdit)
        Me.EditPlan.Controls.Add(Me.btSaveEditPlan)
        Me.EditPlan.Controls.Add(Me.MCNoEdit3)
        Me.EditPlan.Controls.Add(Me.MCNoEdit2)
        Me.EditPlan.Controls.Add(Me.MCNoEdit1)
        Me.EditPlan.Controls.Add(Me.DateTimePicker2)
        Me.EditPlan.Location = New System.Drawing.Point(4, 22)
        Me.EditPlan.Name = "EditPlan"
        Me.EditPlan.Padding = New System.Windows.Forms.Padding(3)
        Me.EditPlan.Size = New System.Drawing.Size(942, 624)
        Me.EditPlan.TabIndex = 2
        Me.EditPlan.Text = "Edit Plan"
        Me.EditPlan.UseVisualStyleBackColor = True
        '
        'ViewEdit
        '
        Me.ViewEdit.AutoGenerateColumns = False
        Me.ViewEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewEdit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PackageDataGridViewTextBoxColumn, Me.DayPlanDataGridViewTextBoxColumn, Me.MCNoDataGridViewTextBoxColumn, Me.PlanDayDataGridViewTextBoxColumn, Me.GroupPKGDataGridViewTextBoxColumn})
        Me.ViewEdit.DataSource = Me.PLMecoPlanDataBindingSource
        Me.ViewEdit.Location = New System.Drawing.Point(23, 48)
        Me.ViewEdit.Name = "ViewEdit"
        Me.ViewEdit.Size = New System.Drawing.Size(726, 310)
        Me.ViewEdit.TabIndex = 0
        '
        'PackageDataGridViewTextBoxColumn
        '
        Me.PackageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PackageDataGridViewTextBoxColumn.DataPropertyName = "Package"
        Me.PackageDataGridViewTextBoxColumn.HeaderText = "Package"
        Me.PackageDataGridViewTextBoxColumn.Name = "PackageDataGridViewTextBoxColumn"
        '
        'DayPlanDataGridViewTextBoxColumn
        '
        Me.DayPlanDataGridViewTextBoxColumn.DataPropertyName = "DayPlan"
        Me.DayPlanDataGridViewTextBoxColumn.HeaderText = "DayPlan"
        Me.DayPlanDataGridViewTextBoxColumn.Name = "DayPlanDataGridViewTextBoxColumn"
        '
        'MCNoDataGridViewTextBoxColumn
        '
        Me.MCNoDataGridViewTextBoxColumn.DataPropertyName = "MCNo"
        Me.MCNoDataGridViewTextBoxColumn.HeaderText = "MCNo"
        Me.MCNoDataGridViewTextBoxColumn.Name = "MCNoDataGridViewTextBoxColumn"
        '
        'PlanDayDataGridViewTextBoxColumn
        '
        Me.PlanDayDataGridViewTextBoxColumn.DataPropertyName = "PlanDay"
        Me.PlanDayDataGridViewTextBoxColumn.HeaderText = "PlanDay"
        Me.PlanDayDataGridViewTextBoxColumn.Name = "PlanDayDataGridViewTextBoxColumn"
        '
        'GroupPKGDataGridViewTextBoxColumn
        '
        Me.GroupPKGDataGridViewTextBoxColumn.DataPropertyName = "GroupPKG"
        Me.GroupPKGDataGridViewTextBoxColumn.HeaderText = "GroupPKG"
        Me.GroupPKGDataGridViewTextBoxColumn.Name = "GroupPKGDataGridViewTextBoxColumn"
        '
        'PLMecoPlanDataBindingSource
        '
        Me.PLMecoPlanDataBindingSource.DataMember = "PLMecoPlanData"
        Me.PLMecoPlanDataBindingSource.DataSource = Me.DBxDataSet
        '
        'btSaveEditPlan
        '
        Me.btSaveEditPlan.Location = New System.Drawing.Point(23, 380)
        Me.btSaveEditPlan.Name = "btSaveEditPlan"
        Me.btSaveEditPlan.Size = New System.Drawing.Size(75, 23)
        Me.btSaveEditPlan.TabIndex = 3
        Me.btSaveEditPlan.Text = "Save"
        Me.btSaveEditPlan.UseVisualStyleBackColor = True
        '
        'MCNoEdit3
        '
        Me.MCNoEdit3.AutoSize = True
        Me.MCNoEdit3.Location = New System.Drawing.Point(213, 18)
        Me.MCNoEdit3.Name = "MCNoEdit3"
        Me.MCNoEdit3.Size = New System.Drawing.Size(65, 17)
        Me.MCNoEdit3.TabIndex = 2
        Me.MCNoEdit3.Text = "PL-M-03"
        Me.MCNoEdit3.UseVisualStyleBackColor = True
        '
        'MCNoEdit2
        '
        Me.MCNoEdit2.AutoSize = True
        Me.MCNoEdit2.Location = New System.Drawing.Point(117, 18)
        Me.MCNoEdit2.Name = "MCNoEdit2"
        Me.MCNoEdit2.Size = New System.Drawing.Size(65, 17)
        Me.MCNoEdit2.TabIndex = 2
        Me.MCNoEdit2.Text = "PL-M-02"
        Me.MCNoEdit2.UseVisualStyleBackColor = True
        '
        'MCNoEdit1
        '
        Me.MCNoEdit1.AutoSize = True
        Me.MCNoEdit1.Checked = True
        Me.MCNoEdit1.Location = New System.Drawing.Point(21, 18)
        Me.MCNoEdit1.Name = "MCNoEdit1"
        Me.MCNoEdit1.Size = New System.Drawing.Size(65, 17)
        Me.MCNoEdit1.TabIndex = 2
        Me.MCNoEdit1.TabStop = True
        Me.MCNoEdit1.Text = "PL-M-01"
        Me.MCNoEdit1.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(309, 14)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 1
        '
        'SettingJIG
        '
        Me.SettingJIG.Controls.Add(Me.Button4)
        Me.SettingJIG.Controls.Add(Me.DataGridView1)
        Me.SettingJIG.Location = New System.Drawing.Point(4, 22)
        Me.SettingJIG.Name = "SettingJIG"
        Me.SettingJIG.Padding = New System.Windows.Forms.Padding(3)
        Me.SettingJIG.Size = New System.Drawing.Size(942, 624)
        Me.SettingJIG.TabIndex = 3
        Me.SettingJIG.Text = "Setting JIG"
        Me.SettingJIG.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(387, 582)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameJIGDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.UseJIGDataGridViewTextBoxColumn, Me.TypeToolDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PLMecoJigToolBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(449, 558)
        Me.DataGridView1.TabIndex = 0
        '
        'NameJIGDataGridViewTextBoxColumn
        '
        Me.NameJIGDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameJIGDataGridViewTextBoxColumn.DataPropertyName = "NameJIG"
        Me.NameJIGDataGridViewTextBoxColumn.HeaderText = "NameJIG"
        Me.NameJIGDataGridViewTextBoxColumn.Name = "NameJIGDataGridViewTextBoxColumn"
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        '
        'UseJIGDataGridViewTextBoxColumn
        '
        Me.UseJIGDataGridViewTextBoxColumn.DataPropertyName = "UseJIG"
        Me.UseJIGDataGridViewTextBoxColumn.HeaderText = "UseJIG"
        Me.UseJIGDataGridViewTextBoxColumn.Name = "UseJIGDataGridViewTextBoxColumn"
        Me.UseJIGDataGridViewTextBoxColumn.Visible = False
        '
        'TypeToolDataGridViewTextBoxColumn
        '
        Me.TypeToolDataGridViewTextBoxColumn.DataPropertyName = "TypeTool"
        Me.TypeToolDataGridViewTextBoxColumn.HeaderText = "TypeTool"
        Me.TypeToolDataGridViewTextBoxColumn.Name = "TypeToolDataGridViewTextBoxColumn"
        '
        'PLMecoJigToolBindingSource
        '
        Me.PLMecoJigToolBindingSource.DataMember = "PLMecoJigTool"
        Me.PLMecoJigToolBindingSource.DataSource = Me.DBxDataSet
        '
        'SettingGroup
        '
        Me.SettingGroup.Controls.Add(Me.TabControl1)
        Me.SettingGroup.Location = New System.Drawing.Point(4, 22)
        Me.SettingGroup.Name = "SettingGroup"
        Me.SettingGroup.Padding = New System.Windows.Forms.Padding(3)
        Me.SettingGroup.Size = New System.Drawing.Size(942, 624)
        Me.SettingGroup.TabIndex = 4
        Me.SettingGroup.Text = "Setting Group"
        Me.SettingGroup.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(930, 574)
        Me.TabControl1.TabIndex = 26
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Button7)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.tbGroup)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(922, 548)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "AddGroup"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TypeJIG2)
        Me.GroupBox1.Controls.Add(Me.TypeJIG14)
        Me.GroupBox1.Controls.Add(Me.TypeJIG7)
        Me.GroupBox1.Controls.Add(Me.TypeJIG4)
        Me.GroupBox1.Controls.Add(Me.TypeJIG8)
        Me.GroupBox1.Controls.Add(Me.TypeJIG12)
        Me.GroupBox1.Controls.Add(Me.TypeJIG11)
        Me.GroupBox1.Controls.Add(Me.TypeJIG6)
        Me.GroupBox1.Controls.Add(Me.TypeJIG1)
        Me.GroupBox1.Controls.Add(Me.TypeJIG15)
        Me.GroupBox1.Controls.Add(Me.TypeJIG13)
        Me.GroupBox1.Controls.Add(Me.TypeJIG9)
        Me.GroupBox1.Controls.Add(Me.TypeJIG16)
        Me.GroupBox1.Controls.Add(Me.TypeJIG3)
        Me.GroupBox1.Controls.Add(Me.TypeJIG5)
        Me.GroupBox1.Controls.Add(Me.TypeJIG10)
        Me.GroupBox1.Location = New System.Drawing.Point(233, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(195, 498)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TypeTool"
        '
        'TypeJIG2
        '
        Me.TypeJIG2.DisplayMember = "TypeTool"
        Me.TypeJIG2.FormattingEnabled = True
        Me.TypeJIG2.Items.AddRange(New Object() {"Gripper", "Nozzle", "Roller"})
        Me.TypeJIG2.Location = New System.Drawing.Point(60, 48)
        Me.TypeJIG2.Name = "TypeJIG2"
        Me.TypeJIG2.Size = New System.Drawing.Size(121, 21)
        Me.TypeJIG2.TabIndex = 2
        Me.TypeJIG2.Text = "-"
        Me.TypeJIG2.ValueMember = "TypeTool"
        '
        'TypeJIG14
        '
        Me.TypeJIG14.FormattingEnabled = True
        Me.TypeJIG14.Items.AddRange(New Object() {"Gripper", "Nozzle", "Roller"})
        Me.TypeJIG14.Location = New System.Drawing.Point(60, 372)
        Me.TypeJIG14.Name = "TypeJIG14"
        Me.TypeJIG14.Size = New System.Drawing.Size(121, 21)
        Me.TypeJIG14.TabIndex = 14
        Me.TypeJIG14.Text = "-"
        '
        'TypeJIG7
        '
        Me.TypeJIG7.FormattingEnabled = True
        Me.TypeJIG7.Items.AddRange(New Object() {"Gripper", "Nozzle", "Roller"})
        Me.TypeJIG7.Location = New System.Drawing.Point(60, 183)
        Me.TypeJIG7.Name = "TypeJIG7"
        Me.TypeJIG7.Size = New System.Drawing.Size(121, 21)
        Me.TypeJIG7.TabIndex = 7
        Me.TypeJIG7.Text = "-"
        '
        'TypeJIG4
        '
        Me.TypeJIG4.FormattingEnabled = True
        Me.TypeJIG4.Items.AddRange(New Object() {"Gripper", "Nozzle", "Roller"})
        Me.TypeJIG4.Location = New System.Drawing.Point(60, 102)
        Me.TypeJIG4.Name = "TypeJIG4"
        Me.TypeJIG4.Size = New System.Drawing.Size(121, 21)
        Me.TypeJIG4.TabIndex = 4
        Me.TypeJIG4.Text = "-"
        '
        'TypeJIG8
        '
        Me.TypeJIG8.FormattingEnabled = True
        Me.TypeJIG8.Items.AddRange(New Object() {"Gripper", "Nozzle", "Roller"})
        Me.TypeJIG8.Location = New System.Drawing.Point(60, 210)
        Me.TypeJIG8.Name = "TypeJIG8"
        Me.TypeJIG8.Size = New System.Drawing.Size(121, 21)
        Me.TypeJIG8.TabIndex = 8
        Me.TypeJIG8.Text = "-"
        '
        'TypeJIG12
        '
        Me.TypeJIG12.FormattingEnabled = True
        Me.TypeJIG12.Items.AddRange(New Object() {"Gripper", "Nozzle", "Roller"})
        Me.TypeJIG12.Location = New System.Drawing.Point(60, 318)
        Me.TypeJIG12.Name = "TypeJIG12"
        Me.TypeJIG12.Size = New System.Drawing.Size(121, 21)
        Me.TypeJIG12.TabIndex = 12
        Me.TypeJIG12.Text = "-"
        '
        'TypeJIG11
        '
        Me.TypeJIG11.FormattingEnabled = True
        Me.TypeJIG11.Items.AddRange(New Object() {"Gripper", "Nozzle", "Roller"})
        Me.TypeJIG11.Location = New System.Drawing.Point(60, 291)
        Me.TypeJIG11.Name = "TypeJIG11"
        Me.TypeJIG11.Size = New System.Drawing.Size(121, 21)
        Me.TypeJIG11.TabIndex = 11
        Me.TypeJIG11.Text = "-"
        '
        'TypeJIG6
        '
        Me.TypeJIG6.FormattingEnabled = True
        Me.TypeJIG6.Items.AddRange(New Object() {"Gripper", "Nozzle", "Roller"})
        Me.TypeJIG6.Location = New System.Drawing.Point(60, 156)
        Me.TypeJIG6.Name = "TypeJIG6"
        Me.TypeJIG6.Size = New System.Drawing.Size(121, 21)
        Me.TypeJIG6.TabIndex = 6
        Me.TypeJIG6.Text = "-"
        '
        'TypeJIG1
        '
        Me.TypeJIG1.FormattingEnabled = True
        Me.TypeJIG1.Items.AddRange(New Object() {"Gripper", "Nozzle", "Roller"})
        Me.TypeJIG1.Location = New System.Drawing.Point(60, 21)
        Me.TypeJIG1.Name = "TypeJIG1"
        Me.TypeJIG1.Size = New System.Drawing.Size(121, 21)
        Me.TypeJIG1.TabIndex = 1
        Me.TypeJIG1.Text = "-"
        '
        'TypeJIG15
        '
        Me.TypeJIG15.FormattingEnabled = True
        Me.TypeJIG15.Items.AddRange(New Object() {"Gripper", "Nozzle", "Roller"})
        Me.TypeJIG15.Location = New System.Drawing.Point(60, 399)
        Me.TypeJIG15.Name = "TypeJIG15"
        Me.TypeJIG15.Size = New System.Drawing.Size(121, 21)
        Me.TypeJIG15.TabIndex = 15
        Me.TypeJIG15.Text = "-"
        '
        'TypeJIG13
        '
        Me.TypeJIG13.FormattingEnabled = True
        Me.TypeJIG13.Items.AddRange(New Object() {"Gripper", "Nozzle", "Roller"})
        Me.TypeJIG13.Location = New System.Drawing.Point(60, 345)
        Me.TypeJIG13.Name = "TypeJIG13"
        Me.TypeJIG13.Size = New System.Drawing.Size(121, 21)
        Me.TypeJIG13.TabIndex = 13
        Me.TypeJIG13.Text = "-"
        '
        'TypeJIG9
        '
        Me.TypeJIG9.FormattingEnabled = True
        Me.TypeJIG9.Items.AddRange(New Object() {"Gripper", "Nozzle", "Roller"})
        Me.TypeJIG9.Location = New System.Drawing.Point(60, 237)
        Me.TypeJIG9.Name = "TypeJIG9"
        Me.TypeJIG9.Size = New System.Drawing.Size(121, 21)
        Me.TypeJIG9.TabIndex = 9
        Me.TypeJIG9.Text = "-"
        '
        'TypeJIG16
        '
        Me.TypeJIG16.FormattingEnabled = True
        Me.TypeJIG16.Items.AddRange(New Object() {"Gripper", "Nozzle", "Roller"})
        Me.TypeJIG16.Location = New System.Drawing.Point(60, 426)
        Me.TypeJIG16.Name = "TypeJIG16"
        Me.TypeJIG16.Size = New System.Drawing.Size(121, 21)
        Me.TypeJIG16.TabIndex = 16
        Me.TypeJIG16.Text = "-"
        '
        'TypeJIG3
        '
        Me.TypeJIG3.FormattingEnabled = True
        Me.TypeJIG3.Items.AddRange(New Object() {"Gripper", "Nozzle", "Roller"})
        Me.TypeJIG3.Location = New System.Drawing.Point(60, 75)
        Me.TypeJIG3.Name = "TypeJIG3"
        Me.TypeJIG3.Size = New System.Drawing.Size(121, 21)
        Me.TypeJIG3.TabIndex = 3
        Me.TypeJIG3.Text = "-"
        '
        'TypeJIG5
        '
        Me.TypeJIG5.FormattingEnabled = True
        Me.TypeJIG5.Items.AddRange(New Object() {"Gripper", "Nozzle", "Roller"})
        Me.TypeJIG5.Location = New System.Drawing.Point(60, 129)
        Me.TypeJIG5.Name = "TypeJIG5"
        Me.TypeJIG5.Size = New System.Drawing.Size(121, 21)
        Me.TypeJIG5.TabIndex = 5
        Me.TypeJIG5.Text = "-"
        '
        'TypeJIG10
        '
        Me.TypeJIG10.FormattingEnabled = True
        Me.TypeJIG10.Items.AddRange(New Object() {"Gripper", "Nozzle", "Roller"})
        Me.TypeJIG10.Location = New System.Drawing.Point(60, 264)
        Me.TypeJIG10.Name = "TypeJIG10"
        Me.TypeJIG10.Size = New System.Drawing.Size(121, 21)
        Me.TypeJIG10.TabIndex = 10
        Me.TypeJIG10.Text = "-"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(840, 510)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 19
        Me.Button7.Text = "Add"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Group Name :"
        '
        'tbGroup
        '
        Me.tbGroup.Location = New System.Drawing.Point(89, 23)
        Me.tbGroup.Name = "tbGroup"
        Me.tbGroup.Size = New System.Drawing.Size(118, 20)
        Me.tbGroup.TabIndex = 20
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.JIG2)
        Me.GroupBox2.Controls.Add(Me.JIG10)
        Me.GroupBox2.Controls.Add(Me.JIG7)
        Me.GroupBox2.Controls.Add(Me.JIG3)
        Me.GroupBox2.Controls.Add(Me.JIG5)
        Me.GroupBox2.Controls.Add(Me.JIG14)
        Me.GroupBox2.Controls.Add(Me.JIG13)
        Me.GroupBox2.Controls.Add(Me.JIG16)
        Me.GroupBox2.Controls.Add(Me.JIG9)
        Me.GroupBox2.Controls.Add(Me.JIG6)
        Me.GroupBox2.Controls.Add(Me.JIG12)
        Me.GroupBox2.Controls.Add(Me.JIG15)
        Me.GroupBox2.Controls.Add(Me.JIG4)
        Me.GroupBox2.Controls.Add(Me.JIG11)
        Me.GroupBox2.Controls.Add(Me.JIG1)
        Me.GroupBox2.Controls.Add(Me.JIG8)
        Me.GroupBox2.Location = New System.Drawing.Point(455, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(211, 498)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "JIG"
        '
        'JIG2
        '
        Me.JIG2.FormattingEnabled = True
        Me.JIG2.Location = New System.Drawing.Point(57, 52)
        Me.JIG2.Name = "JIG2"
        Me.JIG2.Size = New System.Drawing.Size(121, 21)
        Me.JIG2.TabIndex = 2
        Me.JIG2.Text = "-"
        '
        'JIG10
        '
        Me.JIG10.FormattingEnabled = True
        Me.JIG10.Location = New System.Drawing.Point(57, 268)
        Me.JIG10.Name = "JIG10"
        Me.JIG10.Size = New System.Drawing.Size(121, 21)
        Me.JIG10.TabIndex = 10
        Me.JIG10.Text = "-"
        '
        'JIG7
        '
        Me.JIG7.FormattingEnabled = True
        Me.JIG7.Location = New System.Drawing.Point(57, 187)
        Me.JIG7.Name = "JIG7"
        Me.JIG7.Size = New System.Drawing.Size(121, 21)
        Me.JIG7.TabIndex = 7
        Me.JIG7.Text = "-"
        '
        'JIG3
        '
        Me.JIG3.FormattingEnabled = True
        Me.JIG3.Location = New System.Drawing.Point(57, 79)
        Me.JIG3.Name = "JIG3"
        Me.JIG3.Size = New System.Drawing.Size(121, 21)
        Me.JIG3.TabIndex = 3
        Me.JIG3.Text = "-"
        '
        'JIG5
        '
        Me.JIG5.FormattingEnabled = True
        Me.JIG5.Location = New System.Drawing.Point(57, 133)
        Me.JIG5.Name = "JIG5"
        Me.JIG5.Size = New System.Drawing.Size(121, 21)
        Me.JIG5.TabIndex = 5
        Me.JIG5.Text = "-"
        '
        'JIG14
        '
        Me.JIG14.FormattingEnabled = True
        Me.JIG14.Location = New System.Drawing.Point(57, 376)
        Me.JIG14.Name = "JIG14"
        Me.JIG14.Size = New System.Drawing.Size(121, 21)
        Me.JIG14.TabIndex = 14
        Me.JIG14.Text = "-"
        '
        'JIG13
        '
        Me.JIG13.FormattingEnabled = True
        Me.JIG13.Location = New System.Drawing.Point(57, 349)
        Me.JIG13.Name = "JIG13"
        Me.JIG13.Size = New System.Drawing.Size(121, 21)
        Me.JIG13.TabIndex = 13
        Me.JIG13.Text = "-"
        '
        'JIG16
        '
        Me.JIG16.FormattingEnabled = True
        Me.JIG16.Location = New System.Drawing.Point(57, 430)
        Me.JIG16.Name = "JIG16"
        Me.JIG16.Size = New System.Drawing.Size(121, 21)
        Me.JIG16.TabIndex = 16
        Me.JIG16.Text = "-"
        '
        'JIG9
        '
        Me.JIG9.FormattingEnabled = True
        Me.JIG9.Location = New System.Drawing.Point(57, 241)
        Me.JIG9.Name = "JIG9"
        Me.JIG9.Size = New System.Drawing.Size(121, 21)
        Me.JIG9.TabIndex = 9
        Me.JIG9.Text = "-"
        '
        'JIG6
        '
        Me.JIG6.FormattingEnabled = True
        Me.JIG6.Location = New System.Drawing.Point(57, 160)
        Me.JIG6.Name = "JIG6"
        Me.JIG6.Size = New System.Drawing.Size(121, 21)
        Me.JIG6.TabIndex = 6
        Me.JIG6.Text = "-"
        '
        'JIG12
        '
        Me.JIG12.FormattingEnabled = True
        Me.JIG12.Location = New System.Drawing.Point(57, 322)
        Me.JIG12.Name = "JIG12"
        Me.JIG12.Size = New System.Drawing.Size(121, 21)
        Me.JIG12.TabIndex = 12
        Me.JIG12.Text = "-"
        '
        'JIG15
        '
        Me.JIG15.FormattingEnabled = True
        Me.JIG15.Location = New System.Drawing.Point(57, 403)
        Me.JIG15.Name = "JIG15"
        Me.JIG15.Size = New System.Drawing.Size(121, 21)
        Me.JIG15.TabIndex = 15
        Me.JIG15.Text = "-"
        '
        'JIG4
        '
        Me.JIG4.FormattingEnabled = True
        Me.JIG4.Location = New System.Drawing.Point(57, 106)
        Me.JIG4.Name = "JIG4"
        Me.JIG4.Size = New System.Drawing.Size(121, 21)
        Me.JIG4.TabIndex = 4
        Me.JIG4.Text = "-"
        '
        'JIG11
        '
        Me.JIG11.FormattingEnabled = True
        Me.JIG11.Location = New System.Drawing.Point(57, 295)
        Me.JIG11.Name = "JIG11"
        Me.JIG11.Size = New System.Drawing.Size(121, 21)
        Me.JIG11.TabIndex = 11
        Me.JIG11.Text = "-"
        '
        'JIG1
        '
        Me.JIG1.FormattingEnabled = True
        Me.JIG1.Location = New System.Drawing.Point(57, 25)
        Me.JIG1.Name = "JIG1"
        Me.JIG1.Size = New System.Drawing.Size(121, 21)
        Me.JIG1.TabIndex = 1
        Me.JIG1.Text = "-"
        '
        'JIG8
        '
        Me.JIG8.FormattingEnabled = True
        Me.JIG8.Location = New System.Drawing.Point(57, 214)
        Me.JIG8.Name = "JIG8"
        Me.JIG8.Size = New System.Drawing.Size(121, 21)
        Me.JIG8.TabIndex = 8
        Me.JIG8.Text = "-"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.NumberJIG7)
        Me.GroupBox3.Controls.Add(Me.NumberJIG10)
        Me.GroupBox3.Controls.Add(Me.NumberJIG6)
        Me.GroupBox3.Controls.Add(Me.NumberJIG4)
        Me.GroupBox3.Controls.Add(Me.NumberJIG16)
        Me.GroupBox3.Controls.Add(Me.NumberJIG2)
        Me.GroupBox3.Controls.Add(Me.NumberJIG15)
        Me.GroupBox3.Controls.Add(Me.NumberJIG12)
        Me.GroupBox3.Controls.Add(Me.NumberJIG1)
        Me.GroupBox3.Controls.Add(Me.NumberJIG11)
        Me.GroupBox3.Controls.Add(Me.NumberJIG8)
        Me.GroupBox3.Controls.Add(Me.NumberJIG14)
        Me.GroupBox3.Controls.Add(Me.NumberJIG9)
        Me.GroupBox3.Controls.Add(Me.NumberJIG5)
        Me.GroupBox3.Controls.Add(Me.NumberJIG13)
        Me.GroupBox3.Controls.Add(Me.NumberJIG3)
        Me.GroupBox3.Location = New System.Drawing.Point(700, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(215, 498)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "จำนวน"
        '
        'NumberJIG7
        '
        Me.NumberJIG7.FormattingEnabled = True
        Me.NumberJIG7.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.NumberJIG7.Location = New System.Drawing.Point(73, 192)
        Me.NumberJIG7.Name = "NumberJIG7"
        Me.NumberJIG7.Size = New System.Drawing.Size(121, 21)
        Me.NumberJIG7.TabIndex = 7
        Me.NumberJIG7.Text = "0"
        '
        'NumberJIG10
        '
        Me.NumberJIG10.FormattingEnabled = True
        Me.NumberJIG10.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.NumberJIG10.Location = New System.Drawing.Point(73, 273)
        Me.NumberJIG10.Name = "NumberJIG10"
        Me.NumberJIG10.Size = New System.Drawing.Size(121, 21)
        Me.NumberJIG10.TabIndex = 10
        Me.NumberJIG10.Text = "0"
        '
        'NumberJIG6
        '
        Me.NumberJIG6.FormattingEnabled = True
        Me.NumberJIG6.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.NumberJIG6.Location = New System.Drawing.Point(73, 165)
        Me.NumberJIG6.Name = "NumberJIG6"
        Me.NumberJIG6.Size = New System.Drawing.Size(121, 21)
        Me.NumberJIG6.TabIndex = 6
        Me.NumberJIG6.Text = "0"
        '
        'NumberJIG4
        '
        Me.NumberJIG4.FormattingEnabled = True
        Me.NumberJIG4.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.NumberJIG4.Location = New System.Drawing.Point(73, 111)
        Me.NumberJIG4.Name = "NumberJIG4"
        Me.NumberJIG4.Size = New System.Drawing.Size(121, 21)
        Me.NumberJIG4.TabIndex = 4
        Me.NumberJIG4.Text = "0"
        '
        'NumberJIG16
        '
        Me.NumberJIG16.FormattingEnabled = True
        Me.NumberJIG16.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.NumberJIG16.Location = New System.Drawing.Point(73, 435)
        Me.NumberJIG16.Name = "NumberJIG16"
        Me.NumberJIG16.Size = New System.Drawing.Size(121, 21)
        Me.NumberJIG16.TabIndex = 16
        Me.NumberJIG16.Text = "0"
        '
        'NumberJIG2
        '
        Me.NumberJIG2.FormattingEnabled = True
        Me.NumberJIG2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.NumberJIG2.Location = New System.Drawing.Point(73, 57)
        Me.NumberJIG2.Name = "NumberJIG2"
        Me.NumberJIG2.Size = New System.Drawing.Size(121, 21)
        Me.NumberJIG2.TabIndex = 2
        Me.NumberJIG2.Text = "0"
        '
        'NumberJIG15
        '
        Me.NumberJIG15.FormattingEnabled = True
        Me.NumberJIG15.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.NumberJIG15.Location = New System.Drawing.Point(73, 408)
        Me.NumberJIG15.Name = "NumberJIG15"
        Me.NumberJIG15.Size = New System.Drawing.Size(121, 21)
        Me.NumberJIG15.TabIndex = 15
        Me.NumberJIG15.Text = "0"
        '
        'NumberJIG12
        '
        Me.NumberJIG12.FormattingEnabled = True
        Me.NumberJIG12.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.NumberJIG12.Location = New System.Drawing.Point(73, 327)
        Me.NumberJIG12.Name = "NumberJIG12"
        Me.NumberJIG12.Size = New System.Drawing.Size(121, 21)
        Me.NumberJIG12.TabIndex = 12
        Me.NumberJIG12.Text = "0"
        '
        'NumberJIG1
        '
        Me.NumberJIG1.FormattingEnabled = True
        Me.NumberJIG1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.NumberJIG1.Location = New System.Drawing.Point(73, 30)
        Me.NumberJIG1.Name = "NumberJIG1"
        Me.NumberJIG1.Size = New System.Drawing.Size(121, 21)
        Me.NumberJIG1.TabIndex = 1
        Me.NumberJIG1.Text = "0"
        '
        'NumberJIG11
        '
        Me.NumberJIG11.FormattingEnabled = True
        Me.NumberJIG11.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.NumberJIG11.Location = New System.Drawing.Point(73, 300)
        Me.NumberJIG11.Name = "NumberJIG11"
        Me.NumberJIG11.Size = New System.Drawing.Size(121, 21)
        Me.NumberJIG11.TabIndex = 11
        Me.NumberJIG11.Text = "0"
        '
        'NumberJIG8
        '
        Me.NumberJIG8.FormattingEnabled = True
        Me.NumberJIG8.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.NumberJIG8.Location = New System.Drawing.Point(73, 219)
        Me.NumberJIG8.Name = "NumberJIG8"
        Me.NumberJIG8.Size = New System.Drawing.Size(121, 21)
        Me.NumberJIG8.TabIndex = 8
        Me.NumberJIG8.Text = "0"
        '
        'NumberJIG14
        '
        Me.NumberJIG14.FormattingEnabled = True
        Me.NumberJIG14.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.NumberJIG14.Location = New System.Drawing.Point(73, 381)
        Me.NumberJIG14.Name = "NumberJIG14"
        Me.NumberJIG14.Size = New System.Drawing.Size(121, 21)
        Me.NumberJIG14.TabIndex = 14
        Me.NumberJIG14.Text = "0"
        '
        'NumberJIG9
        '
        Me.NumberJIG9.FormattingEnabled = True
        Me.NumberJIG9.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.NumberJIG9.Location = New System.Drawing.Point(73, 246)
        Me.NumberJIG9.Name = "NumberJIG9"
        Me.NumberJIG9.Size = New System.Drawing.Size(121, 21)
        Me.NumberJIG9.TabIndex = 9
        Me.NumberJIG9.Text = "0"
        '
        'NumberJIG5
        '
        Me.NumberJIG5.FormattingEnabled = True
        Me.NumberJIG5.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.NumberJIG5.Location = New System.Drawing.Point(73, 138)
        Me.NumberJIG5.Name = "NumberJIG5"
        Me.NumberJIG5.Size = New System.Drawing.Size(121, 21)
        Me.NumberJIG5.TabIndex = 5
        Me.NumberJIG5.Text = "0"
        '
        'NumberJIG13
        '
        Me.NumberJIG13.FormattingEnabled = True
        Me.NumberJIG13.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.NumberJIG13.Location = New System.Drawing.Point(73, 354)
        Me.NumberJIG13.Name = "NumberJIG13"
        Me.NumberJIG13.Size = New System.Drawing.Size(121, 21)
        Me.NumberJIG13.TabIndex = 13
        Me.NumberJIG13.Text = "0"
        '
        'NumberJIG3
        '
        Me.NumberJIG3.FormattingEnabled = True
        Me.NumberJIG3.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.NumberJIG3.Location = New System.Drawing.Point(73, 84)
        Me.NumberJIG3.Name = "NumberJIG3"
        Me.NumberJIG3.Size = New System.Drawing.Size(121, 21)
        Me.NumberJIG3.TabIndex = 3
        Me.NumberJIG3.Text = "0"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.Controls.Add(Me.PLMecoToolTypeDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(922, 548)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "EditGroup"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(590, 458)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 26
        Me.Button8.Text = "SAVE"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'PLMecoToolTypeDataGridView
        '
        Me.PLMecoToolTypeDataGridView.AutoGenerateColumns = False
        Me.PLMecoToolTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PLMecoToolTypeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.PLMecoToolTypeDataGridView.DataSource = Me.PLMecoToolTypeBindingSource
        Me.PLMecoToolTypeDataGridView.Location = New System.Drawing.Point(216, 24)
        Me.PLMecoToolTypeDataGridView.Name = "PLMecoToolTypeDataGridView"
        Me.PLMecoToolTypeDataGridView.Size = New System.Drawing.Size(342, 457)
        Me.PLMecoToolTypeDataGridView.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "GroupName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "GroupName"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NameJIG"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NameJIG"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "UsageUnit"
        Me.DataGridViewTextBoxColumn3.HeaderText = "UsageUnit"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'PLMecoToolTypeBindingSource
        '
        Me.PLMecoToolTypeBindingSource.DataMember = "PLMecoToolType"
        Me.PLMecoToolTypeBindingSource.DataSource = Me.DBxDataSet
        '
        'SelectGroup
        '
        Me.SelectGroup.Controls.Add(Me.PLMecoToolTypeDataGridView1)
        Me.SelectGroup.Controls.Add(Me.btSaveSelectGroup)
        Me.SelectGroup.Controls.Add(Me.ViewGroup)
        Me.SelectGroup.Controls.Add(Me.cbGroup)
        Me.SelectGroup.Controls.Add(Me.cbPackage)
        Me.SelectGroup.Location = New System.Drawing.Point(4, 22)
        Me.SelectGroup.Name = "SelectGroup"
        Me.SelectGroup.Padding = New System.Windows.Forms.Padding(3)
        Me.SelectGroup.Size = New System.Drawing.Size(942, 624)
        Me.SelectGroup.TabIndex = 5
        Me.SelectGroup.Text = "Select Group"
        Me.SelectGroup.UseVisualStyleBackColor = True
        '
        'PLMecoToolTypeDataGridView1
        '
        Me.PLMecoToolTypeDataGridView1.AllowUserToAddRows = False
        Me.PLMecoToolTypeDataGridView1.AllowUserToDeleteRows = False
        Me.PLMecoToolTypeDataGridView1.AutoGenerateColumns = False
        Me.PLMecoToolTypeDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PLMecoToolTypeDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.PLMecoToolTypeDataGridView1.DataSource = Me.PLMecoToolTypeBindingSource
        Me.PLMecoToolTypeDataGridView1.Location = New System.Drawing.Point(419, 81)
        Me.PLMecoToolTypeDataGridView1.Name = "PLMecoToolTypeDataGridView1"
        Me.PLMecoToolTypeDataGridView1.ReadOnly = True
        Me.PLMecoToolTypeDataGridView1.RowHeadersVisible = False
        Me.PLMecoToolTypeDataGridView1.Size = New System.Drawing.Size(478, 365)
        Me.PLMecoToolTypeDataGridView1.TabIndex = 4
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "GroupName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "GroupName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NameJIG"
        Me.DataGridViewTextBoxColumn5.HeaderText = "NameJIG"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UsageUnit"
        Me.DataGridViewTextBoxColumn6.HeaderText = "UsageUnit"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'btSaveSelectGroup
        '
        Me.btSaveSelectGroup.Location = New System.Drawing.Point(380, 19)
        Me.btSaveSelectGroup.Name = "btSaveSelectGroup"
        Me.btSaveSelectGroup.Size = New System.Drawing.Size(75, 23)
        Me.btSaveSelectGroup.TabIndex = 3
        Me.btSaveSelectGroup.Text = "Save"
        Me.btSaveSelectGroup.UseVisualStyleBackColor = True
        '
        'ViewGroup
        '
        Me.ViewGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewGroup.Location = New System.Drawing.Point(30, 81)
        Me.ViewGroup.Name = "ViewGroup"
        Me.ViewGroup.Size = New System.Drawing.Size(293, 321)
        Me.ViewGroup.TabIndex = 2
        '
        'cbGroup
        '
        Me.cbGroup.FormattingEnabled = True
        Me.cbGroup.Location = New System.Drawing.Point(213, 22)
        Me.cbGroup.Name = "cbGroup"
        Me.cbGroup.Size = New System.Drawing.Size(121, 21)
        Me.cbGroup.TabIndex = 1
        '
        'cbPackage
        '
        Me.cbPackage.FormattingEnabled = True
        Me.cbPackage.Location = New System.Drawing.Point(30, 23)
        Me.cbPackage.Name = "cbPackage"
        Me.cbPackage.Size = New System.Drawing.Size(121, 21)
        Me.cbPackage.TabIndex = 0
        '
        'lbMecoPlan
        '
        Me.lbMecoPlan.AutoSize = True
        Me.lbMecoPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbMecoPlan.Location = New System.Drawing.Point(31, 9)
        Me.lbMecoPlan.Name = "lbMecoPlan"
        Me.lbMecoPlan.Size = New System.Drawing.Size(141, 31)
        Me.lbMecoPlan.TabIndex = 3
        Me.lbMecoPlan.Text = "Meco Plan"
        '
        'DBxDataSet1
        '
        Me.DBxDataSet1.DataSetName = "DBxDataSet"
        Me.DBxDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLMecoCapaDataTableAdapter
        '
        Me.PLMecoCapaDataTableAdapter.ClearBeforeFill = True
        '
        'PLMecoPlanDataTableAdapter
        '
        Me.PLMecoPlanDataTableAdapter.ClearBeforeFill = True
        '
        'PlanDateTableAdapter1
        '
        Me.PlanDateTableAdapter1.ClearBeforeFill = True
        '
        'PLMecoJigToolTableAdapter
        '
        Me.PLMecoJigToolTableAdapter.ClearBeforeFill = True
        '
        'PLMecoToolTypeTableAdapter
        '
        Me.PLMecoToolTypeTableAdapter.ClearBeforeFill = True
        '
        'ToolTypeListTableAdapter1
        '
        Me.ToolTypeListTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PLMecoCapaDataTableAdapter = Me.PLMecoCapaDataTableAdapter
        Me.TableAdapterManager.PLMecoJigToolTableAdapter = Me.PLMecoJigToolTableAdapter
        Me.TableAdapterManager.PLMecoPlanDataTableAdapter = Me.PLMecoPlanDataTableAdapter
        Me.TableAdapterManager.PLMecoToolTypeTableAdapter = Me.PLMecoToolTypeTableAdapter
        Me.TableAdapterManager.UpdateOrder = Meco_Production_PlanSetting.DBxDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1020, 708)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Ver1.00"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 730)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbMecoPlan)
        Me.Controls.Add(Me.TapControl)
        Me.Name = "Form1"
        Me.Text = "Meco Plan"
        CType(Me.ViewCapa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLMecoCapaDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBxDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TapControl.ResumeLayout(False)
        Me.AddPlan.ResumeLayout(False)
        Me.AddPlan.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ViewPlan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewEXPlan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EditCapa.ResumeLayout(False)
        Me.EditPlan.ResumeLayout(False)
        Me.EditPlan.PerformLayout()
        CType(Me.ViewEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLMecoPlanDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SettingJIG.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLMecoJigToolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SettingGroup.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PLMecoToolTypeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLMecoToolTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SelectGroup.ResumeLayout(False)
        CType(Me.PLMecoToolTypeDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBxDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PLMecoCapaDataBindingSource As BindingSource
    Friend WithEvents PLMecoCapaDataTableAdapter As DBxDataSetTableAdapters.PLMecoCapaDataTableAdapter
    Friend WithEvents ViewCapa As DataGridView
    Friend WithEvents TapControl As TabControl
    Friend WithEvents EditCapa As TabPage
    Friend WithEvents AddPlan As TabPage
    Friend WithEvents PLMecoPlanDataBindingSource As BindingSource
    Friend WithEvents PLMecoPlanDataTableAdapter As DBxDataSetTableAdapters.PLMecoPlanDataTableAdapter
    Friend WithEvents ViewEXPlan As DataGridView
    Friend WithEvents ViewPlan As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents DatePlan As DateTimePicker
    Friend WithEvents MCNo3 As RadioButton
    Friend WithEvents MCNo2 As RadioButton
    Friend WithEvents MCNo1 As RadioButton
    Friend WithEvents PlanDateTableAdapter1 As DBxDataSetTableAdapters.PlanDateTableAdapter
    Friend WithEvents EditPlan As TabPage
    Friend WithEvents ViewEdit As DataGridView
    Friend WithEvents DateExPlan As DateTimePicker
    Friend WithEvents lbMecoPlan As Label
    Friend WithEvents MCNoEx3 As RadioButton
    Friend WithEvents MCNoEx2 As RadioButton
    Friend WithEvents MCNoEx1 As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MCNoEdit3 As RadioButton
    Friend WithEvents MCNoEdit2 As RadioButton
    Friend WithEvents MCNoEdit1 As RadioButton
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents btSaveEditPlan As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents SettingJIG As TabPage
    Friend WithEvents Button4 As Button
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PLMecoJIGToolIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents SettingGroup As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DBxDataSet1 As DBxDataSet
    Friend WithEvents PLMecoJigToolBindingSource As BindingSource
    Friend WithEvents PLMecoJigToolTableAdapter As DBxDataSetTableAdapters.PLMecoJigToolTableAdapter
    Friend WithEvents DBxDataSet As DBxDataSet
    Friend WithEvents PLMecoToolTypeTableAdapter As DBxDataSetTableAdapters.PLMecoToolTypeTableAdapter
    Friend WithEvents SelectGroup As TabPage
    Friend WithEvents ToolTypeListTableAdapter1 As DBxDataSetTableAdapters.ToolTypeListTableAdapter
    Friend WithEvents cbPackage As ComboBox
    Friend WithEvents BeforeWIPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NozzleTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VacuumGripperTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cbGroup As ComboBox
    Friend WithEvents ViewGroup As DataGridView
    Friend WithEvents btSaveSelectGroup As Button
    Friend WithEvents NameJIGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UseJIGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeToolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JIG16 As ComboBox
    Friend WithEvents JIG15 As ComboBox
    Friend WithEvents JIG8 As ComboBox
    Friend WithEvents JIG12 As ComboBox
    Friend WithEvents JIG7 As ComboBox
    Friend WithEvents JIG14 As ComboBox
    Friend WithEvents JIG4 As ComboBox
    Friend WithEvents JIG11 As ComboBox
    Friend WithEvents JIG6 As ComboBox
    Friend WithEvents JIG13 As ComboBox
    Friend WithEvents JIG3 As ComboBox
    Friend WithEvents JIG10 As ComboBox
    Friend WithEvents JIG5 As ComboBox
    Friend WithEvents JIG9 As ComboBox
    Friend WithEvents NumberJIG1 As ComboBox
    Friend WithEvents JIG2 As ComboBox
    Friend WithEvents JIG1 As ComboBox
    Friend WithEvents NumberJIG16 As ComboBox
    Friend WithEvents NumberJIG14 As ComboBox
    Friend WithEvents NumberJIG8 As ComboBox
    Friend WithEvents NumberJIG12 As ComboBox
    Friend WithEvents NumberJIG6 As ComboBox
    Friend WithEvents NumberJIG10 As ComboBox
    Friend WithEvents NumberJIG4 As ComboBox
    Friend WithEvents NumberJIG2 As ComboBox
    Friend WithEvents NumberJIG15 As ComboBox
    Friend WithEvents NumberJIG7 As ComboBox
    Friend WithEvents NumberJIG13 As ComboBox
    Friend WithEvents NumberJIG5 As ComboBox
    Friend WithEvents NumberJIG11 As ComboBox
    Friend WithEvents NumberJIG3 As ComboBox
    Friend WithEvents NumberJIG9 As ComboBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tbGroup As TextBox
    Friend WithEvents TypeJIG16 As ComboBox
    Friend WithEvents TypeJIG15 As ComboBox
    Friend WithEvents TypeJIG8 As ComboBox
    Friend WithEvents TypeJIG12 As ComboBox
    Friend WithEvents TypeJIG7 As ComboBox
    Friend WithEvents TypeJIG14 As ComboBox
    Friend WithEvents TypeJIG4 As ComboBox
    Friend WithEvents TypeJIG11 As ComboBox
    Friend WithEvents TypeJIG6 As ComboBox
    Friend WithEvents TypeJIG13 As ComboBox
    Friend WithEvents TypeJIG3 As ComboBox
    Friend WithEvents TypeJIG10 As ComboBox
    Friend WithEvents TypeJIG5 As ComboBox
    Friend WithEvents TypeJIG9 As ComboBox
    Friend WithEvents TypeJIG2 As ComboBox
    Friend WithEvents TypeJIG1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PLMecoToolTypeDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents PLMecoToolTypeBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As DBxDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button8 As Button
    Friend WithEvents PackageDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FLotRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeChangeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CapaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PackageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DayPlanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MCNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlanDayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupPKGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PLMecoToolTypeDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents MCNo4 As RadioButton
    Friend WithEvents MCNoEx4 As RadioButton
End Class
