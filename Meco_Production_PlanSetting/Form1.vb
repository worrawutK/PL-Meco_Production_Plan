Public Class Form1

    Dim _TableExPlan As DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        '      Me.PLMecoCapaDataTableAdapter.Fill(Me.DBxDataSet1.PLMecoCapaData)

        updateExPlan()
        DatePlan.Value = DatePlan.Value.AddDays(1)

    End Sub
    Dim MCNoEx As String = ""
    Private Sub MCNoExData()
        If MCNoEx1.Checked Then
            MCNoEx = "PL-M-01"
        ElseIf MCNoEx2.Checked Then
            MCNoEx = "PL-M-02"
        ElseIf MCNoEx3.Checked Then
            MCNoEx = "PL-M-03"
        End If
    End Sub
    Private Sub updateExPlan()
        MCNoExData()
        _TableExPlan = New DataTable

        PLMecoPlanDataTableAdapter.FillEdit(DBxDataSet.PLMecoPlanData, DateExPlan.Value.Date, MCNoEx)
        _TableExPlan.Columns.Add("Package")
        _TableExPlan.Columns.Add("Plan")
        _TableExPlan.Columns.Add("Group")

        For Each data As DBxDataSet.PLMecoPlanDataRow In DBxDataSet.PLMecoPlanData
            Dim rows As DataRow = _TableExPlan.NewRow
            rows("Package") = data.Package
            rows("Plan") = data.DayPlan
            rows("Group") = data.GroupPKG
            _TableExPlan.Rows.Add(rows)
        Next
        ViewEXPlan.DataSource = _TableExPlan
        ViewEXPlan.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ViewEXPlan.Columns(1).Width = 60
        ViewEXPlan.Columns(2).Width = 60

    End Sub
    Dim MCNo As String = Nothing
    Dim val As RadioButton
    Private Sub MCNo1_CheckedChanged(sender As Object, e As EventArgs) Handles MCNo1.CheckedChanged, MCNo3.CheckedChanged, MCNo2.CheckedChanged, MCNo4.CheckedChanged, MCNo6.CheckedChanged, MCNo5.CheckedChanged


        val = CType(sender, RadioButton)
        MCNo = val.Text
        If MCNo = "" Then
            MCNo = "PL-M-01"
        End If


    End Sub
    Dim _Table As DBxDataSet.PLMecoPlanDataDataTable
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim OPNo As String = InputBox("Input OPNo").Trim
        If Not (IsNumeric(OPNo) AndAlso OPNo.Length = 6) Then
            MsgBox("กรุณาใส่ OPNo")
            Exit Sub
        End If

        PlanDateTableAdapter1.Fill(DBxDataSet.PlanDate, DatePlan.Value.Date, MCNo) '+-2เดือน
        If DBxDataSet.PlanDate.Rows.Count >= 1 Then
            MsgBox("มี Plan นี้วันนี้แล้ว")
            Exit Sub
        End If
        If MCNo = "" Then
            MsgBox("กรุณาเลือก MCNo")
            Exit Sub
        End If
        ' Dim OPNo As String = InputBox("Input OPNo")
        _Table = New DBxDataSet.PLMecoPlanDataDataTable
        For Each data As DataRow In _TableExPlan.Rows
            Dim rowShow As DBxDataSet.PLMecoPlanDataRow = _Table.NewRow
            If IsDBNull(data("Package")) Or IsDBNull(data("Plan")) Or IsDBNull(data("Group")) Then
                MsgBox("กรุณาตรวจสอบข้อมูล")
                Exit Sub
            End If
            rowShow.Package = data("Package")
            rowShow.MCNo = MCNo

            rowShow.DayPlan = data("Plan")
            rowShow.GroupPKG = data("Group")
            rowShow.PlanDay = DatePlan.Value.Date '"2016-11-24"

            If System.Net.Dns.GetHostName.Length > 12 Then
                rowShow.PlanBy = OPNo
            Else
                rowShow.PlanBy = System.Net.Dns.GetHostName & "(" & OPNo & ")"
            End If
            rowShow.UpdateDate = Now
            ' Label1.Text = DateTimePicker1.Value.Date
            _Table.Rows.Add(rowShow)
        Next
        ViewPlan.DataSource = _Table
        PLMecoPlanDataTableAdapter.Update(_Table)

        MCNo = Nothing
        val.Checked = False
        ViewPlan.Columns(1).HeaderText = "Plan"
        ViewPlan.Columns(2).Visible = False
        ViewPlan.Columns(3).Visible = False
        ViewPlan.Columns(6).HeaderText = "Group"
        ViewPlan.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ViewPlan.Columns(1).Width = 50
        ViewPlan.Columns(4).Width = 60
        ViewPlan.Columns(5).Width = 70
        ViewPlan.Columns(6).Width = 50
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateExPlan.ValueChanged, MCNoEx1.CheckedChanged, MCNoEx2.CheckedChanged, MCNoEx3.CheckedChanged, MCNoEx4.CheckedChanged, MCNoEx6.CheckedChanged, MCNoEx5.CheckedChanged
        '  PLMecoPlanDataTableAdapter.FillBy(DBxDataSet.PLMecoPlanData, DateTimePicker3.Value.Date)
        Try
            Dim Val As RadioButton = CType(sender, RadioButton)
            MCNoEx = Val.Text

        Catch ex As Exception

        End Try
        Try
            updateExPlan()
        Catch ex As Exception

        End Try
        ' 
    End Sub

    'Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ViewPlan.CellEndEdit
    '    '   ViewPlan.DataSource = _Table
    '    PLMecoPlanDataTableAdapter.Update(_Table)
    'End Sub
    '*****************************************************************************************************************
    Private Sub UPdateCapa()

        PLMecoCapaDataTableAdapter.Update(DBxDataSet.PLMecoCapaData)

    End Sub
    Private Sub PLMecoCapaDataDataGridView_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles ViewCapa.UserDeletedRow
        '  UPdateCapa()
    End Sub
    Private Sub PLMecoCapaDataDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ViewCapa.CellEndEdit

        'UPdateCapa()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UPdateCapa()
        MsgBox("บันทึกเรียบร้อย")
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    ViewPlan.DataSource = _Table
    '    PLMecoPlanDataTableAdapter.Update(_Table)
    'End Sub

    'Private Sub DataGridView1_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles ViewPlan.UserDeletedRow
    '    ViewPlan.DataSource = _Table
    '    PLMecoPlanDataTableAdapter.Update(_Table)
    'End Sub
    Dim MCNoEdit As String = ""
    Private Sub MCNoEditData()
        If MCNoEdit1.Checked Then
            MCNoEdit = "PL-M-01"
        ElseIf MCNoEdit2.Checked Then
            MCNoEdit = "PL-M-02"
        ElseIf MCNoEdit3.Checked Then
            MCNoEdit = "PL-M-03"
        End If
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TapControl.SelectedIndexChanged
        MCNoEditData()
        Dim valTab As TabControl = CType(sender, TabControl)
        '  Dim NameTab As String = valTab.SelectedTab.Name
        Dim TabIndex As String = valTab.SelectedTab.Name

        If TabIndex = "EditCapa" Or TabIndex = "SelectGroup" Then
            PLMecoCapaDataTableAdapter.Fill(DBxDataSet.PLMecoCapaData)
            ViewGroup.DataSource = DBxDataSet.PLMecoCapaData
            ViewGroup.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            ViewGroup.Columns(1).Visible = False
            ViewGroup.Columns(2).Visible = False
            ViewGroup.Columns(3).Visible = False
        ElseIf TabIndex = "AddPlan" Then
            PLMecoPlanDataTableAdapter.FillBy(DBxDataSet.PLMecoPlanData, DateExPlan.Value.Date)
        ElseIf TabIndex = "EditPlan" Then
            PLMecoPlanDataTableAdapter.FillEdit(DBxDataSet.PLMecoPlanData, DateTimePicker2.Value.Date, MCNoEdit)
        ElseIf TabIndex = "SettingJIG" Then
            Me.PLMecoJigToolTableAdapter.Fill(Me.DBxDataSet.PLMecoJigTool)

        End If

    End Sub
    Dim valDate As DateTimePicker
    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged, MCNoEdit3.CheckedChanged, MCNoEdit2.CheckedChanged, MCNoEdit1.CheckedChanged, RadioButton1.CheckedChanged, RadioButton3.CheckedChanged, RadioButton2.CheckedChanged
        Try
            Dim MCNoEditRB As RadioButton = CType(sender, RadioButton)
            MCNoEdit = MCNoEditRB.Text
        Catch ex As Exception

        End Try

        PLMecoPlanDataTableAdapter.FillEdit(DBxDataSet.PLMecoPlanData, DateTimePicker2.Value.Date, MCNoEdit)
    End Sub

    Private Sub DataGridView2_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ViewEdit.CellEndEdit

        '   UpdatePlan()
    End Sub

    Private Sub DataGridView2_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles ViewEdit.UserDeletedRow

        'UpdatePlan()
    End Sub
    Private Sub UpdatePlan(OPNo As String)
        For Each data As DBxDataSet.PLMecoPlanDataRow In DBxDataSet.PLMecoPlanData
            If System.Net.Dns.GetHostName.Length > 12 Then
                data.PlanBy = OPNo
            Else
                data.PlanBy = System.Net.Dns.GetHostName & "(" & OPNo & ")"
            End If
            data.UpdateDate = Now
        Next
        PLMecoPlanDataTableAdapter.Update(DBxDataSet.PLMecoPlanData)
    End Sub

    Private Sub SaveEditPlan_Click(sender As Object, e As EventArgs) Handles btSaveEditPlan.Click
        Dim OPNo As String = InputBox("Input OPNo").Trim
        If Not (IsNumeric(OPNo) AndAlso OPNo.Length = 6) Then
            MsgBox("กรุณาใส่ OPNo")
            Exit Sub
        End If
        UpdatePlan(OPNo)
        MsgBox("บันทึกเรียบร้อย")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PLMecoJigToolTableAdapter.Update(DBxDataSet.PLMecoJigTool)
        MsgBox("บันทึกเรียบร้อย")
    End Sub

    Private Sub ComboBox2_Click(sender As Object, e As EventArgs)
        Dim val As ComboBox = CType(sender, ComboBox)
        Dim nameJig As String = ""
        If val.Name = "cbGripperNo" Then
            nameJig = "Gripper"
        ElseIf val.Name = "cbNozzleFront" Then
            nameJig = "Nozzle"
        ElseIf val.Name = "cbNozzleBack" Then
            nameJig = "Nozzle"
        ElseIf val.Name = "cbRoller" Then
            nameJig = "Roller"
        End If

        val.Items.Clear()
        PLMecoJigToolTableAdapter.FillTool(DBxDataSet.PLMecoJigTool, nameJig)
        For Each data As DBxDataSet.PLMecoJigToolRow In DBxDataSet.PLMecoJigTool
            val.Items.Add(data.NameJIG)
        Next
    End Sub







    Private Sub Button5_Click(sender As Object, e As EventArgs)
        PLMecoToolTypeTableAdapter.Update(DBxDataSet.PLMecoToolType)
        MsgBox("บันทึกเรียบร้อย")
    End Sub

    Private Sub ComboBox2_Click_1(sender As Object, e As EventArgs) Handles cbGroup.Click
        ToolTypeListTableAdapter1.Fill(DBxDataSet.ToolTypeList)
        cbGroup.Items.Clear()
        For Each data As DBxDataSet.ToolTypeListRow In DBxDataSet.ToolTypeList
            cbGroup.Items.Add(data.GroupName)
        Next
    End Sub

    Private Sub SaveGroup_Click(sender As Object, e As EventArgs) Handles btSaveSelectGroup.Click
        PLMecoCapaDataTableAdapter.Fill(DBxDataSet.PLMecoCapaData)
        For Each data As DBxDataSet.PLMecoCapaDataRow In DBxDataSet.PLMecoCapaData
            If data.Package = cbPackage.Text Then
                data.GroupName = cbGroup.Text
            End If
        Next
        PLMecoCapaDataTableAdapter.Update(DBxDataSet.PLMecoCapaData)
        ViewGroup.DataSource = DBxDataSet.PLMecoCapaData

    End Sub



    Private Sub cbPackage_Click(sender As Object, e As EventArgs) Handles cbPackage.Click
        PLMecoCapaDataTableAdapter.Fill(DBxDataSet.PLMecoCapaData)
        cbPackage.Items.Clear()
        For Each data As DBxDataSet.PLMecoCapaDataRow In DBxDataSet.PLMecoCapaData
            cbPackage.Items.Add(data.Package)
        Next
    End Sub

    Private Sub AddItem_Click(sender As Object, e As EventArgs) Handles JIG1.Click, JIG9.Click, JIG8.Click, JIG7.Click, JIG6.Click, JIG5.Click, JIG2.Click, JIG3.Click, JIG16.Click, JIG15.Click, JIG12.Click, JIG14.Click, JIG11.Click, JIG13.Click, JIG10.Click, JIG4.Click
        Dim val As ComboBox = CType(sender, ComboBox)
        'Dim nameJig As String = ""
        'If val.Name = "cbGripperNo" Then
        '    nameJig = "Gripper"
        'ElseIf val.Name = "cbNozzleFront" Then
        '    nameJig = "Nozzle"
        'ElseIf val.Name = "cbNozzleBack" Then
        '    nameJig = "Nozzle"
        'ElseIf val.Name = "cbRoller" Then
        '    nameJig = "Roller"
        'End If
        Dim Tool As String = ""
        If val.Name = "JIG1" Then
            Tool = TypeJIG1.Text
        ElseIf val.Name = "JIG2" Then
            Tool = TypeJIG2.Text
        ElseIf val.Name = "JIG3" Then
            Tool = TypeJIG3.Text
        ElseIf val.Name = "JIG4" Then
            Tool = TypeJIG4.Text
        ElseIf val.Name = "JIG5" Then
            Tool = TypeJIG5.Text
        ElseIf val.Name = "JIG6" Then
            Tool = TypeJIG6.Text
        ElseIf val.Name = "JIG7" Then
            Tool = TypeJIG7.Text
        ElseIf val.Name = "JIG8" Then
            Tool = TypeJIG8.Text
        ElseIf val.Name = "JIG9" Then
            Tool = TypeJIG9.Text
        ElseIf val.Name = "JIG10" Then
            Tool = TypeJIG10.Text
        ElseIf val.Name = "JIG11" Then
            Tool = TypeJIG11.Text
        ElseIf val.Name = "JIG12" Then
            Tool = TypeJIG12.Text
        ElseIf val.Name = "JIG13" Then
            Tool = TypeJIG13.Text
        ElseIf val.Name = "JIG14" Then
            Tool = TypeJIG14.Text
        ElseIf val.Name = "JIG15" Then
            Tool = TypeJIG15.Text
        ElseIf val.Name = "JIG16" Then
            Tool = TypeJIG16.Text
        End If
        val.Items.Clear()
        PLMecoJigToolTableAdapter.FillTool(DBxDataSet.PLMecoJigTool, Tool)
        '   PLMecoJigToolTableAdapter.Fill(DBxDataSet.PLMecoJigTool)
        For Each data As DBxDataSet.PLMecoJigToolRow In DBxDataSet.PLMecoJigTool
            val.Items.Add(data.NameJIG)
        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        PLMecoToolTypeTableAdapter.Fill(DBxDataSet.PLMecoToolType)
        If tbGroup.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ")
            Exit Sub
        End If
        For Each data As DBxDataSet.PLMecoToolTypeRow In DBxDataSet.PLMecoToolType

            If data.GroupName = tbGroup.Text Then
                MsgBox("มี Group " & tbGroup.Text & " นี้ในระบบแล้ว")
                Exit Sub

            End If
        Next
        Dim AddGroup As Boolean = False
        Dim TypeJIG() As String = {Trim(TypeJIG1.Text), Trim(TypeJIG2.Text), Trim(TypeJIG3.Text), Trim(TypeJIG4.Text), Trim(TypeJIG5.Text), Trim(TypeJIG6.Text), Trim(TypeJIG7.Text), Trim(TypeJIG8.Text), Trim(TypeJIG9.Text), Trim(TypeJIG10.Text), Trim(TypeJIG11.Text), Trim(TypeJIG12.Text), Trim(TypeJIG13.Text), Trim(TypeJIG14.Text), Trim(TypeJIG15.Text), Trim(TypeJIG16.Text)}
        Dim NameJIG() As String = {Trim(JIG1.Text), Trim(JIG2.Text), Trim(JIG3.Text), Trim(JIG4.Text), Trim(JIG5.Text), Trim(JIG6.Text), Trim(JIG7.Text), Trim(JIG8.Text), Trim(JIG9.Text), Trim(JIG10.Text), Trim(JIG11.Text), Trim(JIG12.Text), Trim(JIG13.Text), Trim(JIG14.Text), Trim(JIG15.Text), Trim(JIG16.Text)}
        Dim NumberJIG() As String = {Trim(NumberJIG1.Text), Trim(NumberJIG2.Text), Trim(NumberJIG3.Text), Trim(NumberJIG4.Text), Trim(NumberJIG5.Text), Trim(NumberJIG6.Text), Trim(NumberJIG7.Text), Trim(NumberJIG8.Text), Trim(NumberJIG9.Text), Trim(NumberJIG10.Text), Trim(NumberJIG11.Text), Trim(NumberJIG12.Text), Trim(NumberJIG13.Text), Trim(NumberJIG14.Text), Trim(NumberJIG15.Text), Trim(NumberJIG16.Text)}
        For i = 0 To NameJIG.Length - 1
            If NameJIG(i) = "-" Or NumberJIG(i) = "0" Or TypeJIG(i) = "-" Then
                ' MsgBox("กรุณากรอกข้อมูลให้ครบ")
                '  Exit Sub
            Else
                Dim rows As DBxDataSet.PLMecoToolTypeRow = DBxDataSet.PLMecoToolType.NewRow
                rows.GroupName = tbGroup.Text
                rows.NameJIG = NameJIG(i)
                rows.UsageUnit = NumberJIG(i)
                DBxDataSet.PLMecoToolType.Rows.Add(rows)
                AddGroup = True
            End If

        Next
        ' DataGridView2.DataSource = DBxDataSet.PLMecoToolType
        PLMecoToolTypeTableAdapter.Update(DBxDataSet.PLMecoToolType)
        If AddGroup = True Then
            MsgBox("เพิ่ม Group เรียบร้อย")
        Else
            MsgBox("ข้อมุลไม่ถูกต้อง")
        End If

    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        PLMecoToolTypeTableAdapter.Update(DBxDataSet.PLMecoToolType)
    End Sub

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        If TabControl1.SelectedIndex = 1 Then
            PLMecoToolTypeTableAdapter.Fill(DBxDataSet.PLMecoToolType)
        End If

    End Sub

    Private Sub TapControl_Selected(sender As Object, e As TabControlEventArgs) Handles TapControl.Selected

        'MsgBox(TapControl.SelectedIndex.ToString)
        If TapControl.SelectedIndex = 5 Then
            PLMecoToolTypeTableAdapter.Fill(DBxDataSet.PLMecoToolType)
        End If
    End Sub






















    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    PLMecoPlanDataTableAdapter.Update(_Table)
    'End Sub


End Class
