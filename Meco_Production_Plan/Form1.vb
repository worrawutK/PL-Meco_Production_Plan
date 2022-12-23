Imports System.IO
Imports System.Net
Imports System.Data.SqlClient
Imports System.Security.Permissions
Imports System.ComponentModel
Imports System.Text
Imports System.Web.Services.Description
Imports System.Net.Security
Imports System.Web.Script.Serialization
Imports MessageDialog
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Collections.Specialized.BitVector32
Imports System.Security.Policy
Imports Newtonsoft.Json.Linq

Public Class Form1
    Dim _TablePlanDay As DBxDataSet1.PLMecoPlanDataDataTable
    Dim _TableTOP3 As DataTable 'As DBxDataSet1.PLMecoPlanDataDataTable

    Dim TimeStart As TimeSpan = New TimeSpan(8, 5, 0)
    Dim dataViewQ As DataView
    Dim _TableGroupTOP3 As DBxDataSet1.PLMecoPlanGroupDataTable ' = New DBxDataSet1.PLMecoPlanGroupDataTable
    Dim timeENDTOSTRART As TimeSpan
    Dim TIMEUPDATE As TimeSpan
    Dim WIPQryDate As String = Now.Date.AddMonths(-2) '& " 08:00:00"
    Dim create As Boolean = False
    Dim DateWip As String 'DateTime
    Dim DateWIPDN As Int16
    Dim MecoPlanday As String '= Format(Now.Date, "yyyy-MM-dd")
    Dim PlanDayDivide As Integer = 1
    '    Dim Percent As Integer = 70
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        PlanDayDivide = My.Settings.PlanDayDivide
        CbPercentBooking.Text = My.Settings.Percent
        Dim date1 As DateTime = Date.Now

        If My.Settings.MCNo = "PL-M-01" Then
            DataTablePathTOP = "\\172.16.0.100\_Setup\CellController\10_PL\PL Meco Queue\Meco_Reflow\DataTableMCNo01.xml"
        ElseIf My.Settings.MCNo = "PL-M-02" Then
            DataTablePathTOP = "\\172.16.0.100\_Setup\CellController\10_PL\PL Meco Queue\Meco_Reflow\DataTableMCNo02.xml"
        ElseIf My.Settings.MCNo = "PL-M-03" Then
            DataTablePathTOP = "\\172.16.0.100\_Setup\CellController\10_PL\PL Meco Queue\Meco_Reflow\DataTableMCNo03.xml"
        ElseIf My.Settings.MCNo = "PL-M-04" Then
            DataTablePathTOP = "\\172.16.0.100\_Setup\CellController\10_PL\PL Meco Queue\Meco_Reflow\DataTableMCNo04.xml"
        ElseIf My.Settings.MCNo = "PL-M-05" Then
            DataTablePathTOP = "\\172.16.0.100\_Setup\CellController\10_PL\PL Meco Queue\Meco_Reflow\DataTableMCNo05.xml"
        ElseIf My.Settings.MCNo = "PL-M-06" Then
            DataTablePathTOP = "\\172.16.0.100\_Setup\CellController\10_PL\PL Meco Queue\Meco_Reflow\DataTableMCNo06.xml"
        End If

        date1 = Date.Now
        _TablePlanDay = New DBxDataSet1.PLMecoPlanDataDataTable
        _TableGroupTOP3 = New DBxDataSet1.PLMecoPlanGroupDataTable

        _TableGroupTOP3.Columns.Add("Period")
        DNtime()

        date1 = Date.Now

        Try
            Updata()

            date1 = Date.Now
        Catch ex As Exception

            SaveCatchLog(ex.ToString, "Updata()")

            date1 = Date.Now
        End Try


        Try

            selects()

            date1 = Date.Now
        Catch ex As Exception

            SaveCatchLog(ex.ToString, "selects()")

            date1 = Date.Now
        End Try
        Try
            RunTOP1()

            date1 = Date.Now
        Catch ex As Exception
            SaveCatchLog(ex.ToString, "RunTOP1()")
            '    Debug.Print((Date.Now - date1).ToString & ">>9")
            date1 = Date.Now
        End Try

        ' CheckTool()
        formload = True
        StratService()
        lbTimeUpdate.Text = "Update :" & Now

        TextBoxQr.Focus()
        PanelQr.BackColor = Color.LawnGreen
    End Sub
    Private Sub AutoPlan()
        PlMecoPlanData1TableAdapter1.FillBy(DBxDataSet11.PLMecoPlanData1, MecoPlanday, My.Settings.MCNo)
        Dim LastPlan As Date
        If DBxDataSet11.PLMecoPlanData1.Rows.Count < 1 Then
            LastPlan = CDate(MecoPlanday)
            For i = 1 To 7
                MecoPlanday = Format(LastPlan.AddDays(-i), "yyyy-MM-dd")
                PlMecoPlanData1TableAdapter1.FillBy(DBxDataSet11.PLMecoPlanData1, MecoPlanday, My.Settings.MCNo)
                If DBxDataSet11.PLMecoPlanData1.Rows.Count >= 1 Then
                    Dim _data As DBxDataSet1.PLMecoPlanData1DataTable = New DBxDataSet1.PLMecoPlanData1DataTable

                    For Each data As DBxDataSet1.PLMecoPlanData1Row In DBxDataSet11.PLMecoPlanData1
                        Dim row As DBxDataSet1.PLMecoPlanData1Row = _data.NewRow
                        row.Package = data.Package
                        row.DayPlan = data.DayPlan
                        row.MCNo = data.MCNo
                        row.PlanDay = LastPlan
                        row.GroupPKG = data.GroupPKG
                        row.PlanBy = System.Net.Dns.GetHostName & "(Auto)"
                        row.UpdateDate = Now
                        _data.Rows.Add(row)

                    Next
                    PlMecoPlanData1TableAdapter1.Update(_data)
                    Exit For
                End If
            Next


        End If
    End Sub


    Dim dayresult As Integer
    Dim PKGDay As String

    Dim DataTablePathTOP As String
    Private Sub selects()
        'LoadPicture()



        If My.Settings.MCNo = "PL-M-01" Then
            Label2.Text = "Meco#1 Machine Information"
        ElseIf My.Settings.MCNo = "PL-M-02" Then
            Label2.Text = "Meco#2 Machine Information"
        ElseIf My.Settings.MCNo = "PL-M-03" Then
            Label2.Text = "Meco#3 Machine Information"
        ElseIf My.Settings.MCNo = "PL-M-04" Then
            Label2.Text = "Meco#4 Machine Information"
        ElseIf My.Settings.MCNo = "PL-M-05" Then
            Label2.Text = "Meco#5 Machine Information"
        ElseIf My.Settings.MCNo = "PL-M-06" Then
            Label2.Text = "Meco#6 Machine Information"
        End If
        Dim date1 As Date = Date.Now

        Dim _TableGroup As DBxDataSet1.PLMecoPlanGroupDataTable = New DBxDataSet1.PLMecoPlanGroupDataTable
        TestWipSumTableAdapter1.Fill(DBxDataSet11.TestWipSum, My.Settings.MCNo, MecoPlanday)

        PlMecoPlanData1TableAdapter1.FillBy(DBxDataSet11.PLMecoPlanData1, MecoPlanday, My.Settings.MCNo)
        '   Debug.Print((Date.Now - date1).ToString & ">>99")
        For Each data As DBxDataSet1.TestWipSumRow In DBxDataSet11.TestWipSum
            Dim PKG As String = ""

            For Each dataplan As DBxDataSet1.PLMecoPlanData1Row In DBxDataSet11.PLMecoPlanData1

                If data.GroupPKG = dataplan.GroupPKG Then
                    If PKG = "" Then
                        PKG = dataplan.Package
                    Else
                        PKG = PKG & "/" & dataplan.Package
                    End If
                End If
            Next

            Dim insertdata As DBxDataSet1.PLMecoPlanGroupRow = _TableGroup.NewRow
            insertdata.WIP = data.WIP
            insertdata.Package = PKG
            insertdata.RESULT = data.RESULT
            Dim group As String
            If data.GroupPKG.Length = 1 Then
                group = "0" & data.GroupPKG
            Else
                group = data.GroupPKG
            End If
            insertdata.GroupPKG = group
            insertdata.DayPlan = data.DAYPLAN

            _TableGroup.Rows.Add(insertdata)

        Next



        ViewPlanDay.DataSource = ResultDay(_TableGroup)

        ViewPlanDay.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ViewPlanDay.Columns(0).Width = 150
        ViewPlanDay.Columns(1).Width = 150
        ViewPlanDay.Columns(2).Width = 200
        ViewPlanDay.Columns(4).Width = 150
        'ViewTop3.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'ViewTop3.Columns(0).Width = 150
        'ViewTop3.Columns(1).Width = 150
        'ViewTop3.Columns(2).Width = 150
        'ViewTop3.Columns(4).Width = 150
        'ViewTop3.Columns(5).Width = 200
        '  ------------------------------------------------------------------------------
        Dim count2 As Integer = 1
        Dim Groupnum As Integer = 4  'เลื่อนคิวที่ wip น้อยกว่า20%
        Dim iR As Integer
        Dim ChangeQ As Boolean = False
        Dim DataTablePath As String = My.Application.Info.DirectoryPath & "\DataTableXml.xml"
        ''******************************************************************************************************************************************************************************
        'If System.IO.File.Exists(DataTablePath) = True And IsNothing(ViewTop3.DataSource) Then  'open data

        '    _TableGroupTOP3.ReadXml(DataTablePath)

        '    create = True
        '    dataViewQ = New DataView(_TableGroupTOP3) 'เรียง Data 1-n
        '    dataViewQ.Sort = "GroupPKG"

        '    ViewTop3.DataSource = dataViewQ


        'End If


        '   CheckToolTableAdapter1.Fill(DBxDataSet11.CheckTool)
        Dim sumRow As Integer = 0

        For Each top3 As DataRow In _TableGroup.Rows
            sumRow += 1
            'create
            If create = False Then

                Dim insertdataTOP3 As DataRow = _TableGroupTOP3.NewRow
                Dim toolOver As Boolean = False
                Dim PKGG() As String = Split(top3("Package"), "/")

                If ((top3("WIP") / Math.Ceiling(top3("DayPlan") / PlanDayDivide) * 100) > My.Settings.Percent And ((top3("RESULT") / Math.Ceiling(top3("DayPlan") / PlanDayDivide) * 100) < 100)) And count2 <= 3 And toolOver = False And top3("WIP") <> 0 Then 'ตรวจสอบ TOP คิวที่ wip มากกว่า 20% ((top3("RESULT") / (top3("DayPlan") / PlanDayDivide) * 100) < 130)) 

                    '   Groupnum = top3("GroupPKG")
                    If top3("Package") = "" Then

                    End If
                    insertdataTOP3("WIP") = top3("WIP")
                    insertdataTOP3("Package") = top3("Package")
                    insertdataTOP3("DayPlan") = Math.Ceiling(Math.Ceiling(top3("DayPlan") / PlanDayDivide) * 1.3)
                    insertdataTOP3("RESULT") = top3("RESULT")
                    ' insertdataTOP3("PlanDay") = top3("PlanDay")
                    Dim strGroupTop3 As String = ""

                    If count2.ToString.Length = 1 Then
                        strGroupTop3 = "0" & count2
                    Else
                        strGroupTop3 = count2
                    End If
                    insertdataTOP3("GroupPKG") = strGroupTop3


                    count2 += 1

                Else

                    insertdataTOP3("WIP") = top3("WIP")
                    insertdataTOP3("Package") = top3("Package")
                    insertdataTOP3("DayPlan") = Math.Ceiling(Math.Ceiling(top3("DayPlan") / PlanDayDivide) * 1.3)
                    insertdataTOP3("RESULT") = top3("RESULT")
                    Dim strGroup As String = ""
                    If Groupnum.ToString.Length = 1 Then
                        strGroup = "0" & Groupnum
                    Else
                        strGroup = Groupnum
                    End If
                    insertdataTOP3("GroupPKG") = strGroup

                    Groupnum += 1
                End If
                _TableGroupTOP3.Rows.Add(insertdataTOP3)
            Else
                'Update
                For Each DATARR As DataColumn In _TableGroupTOP3.Columns
                    DATARR.ReadOnly = False
                Next

                If (CInt(top3("WIP")) = 0 Or ((top3("RESULT") / Math.Ceiling(top3("DayPlan") / PlanDayDivide) * 100) >= 130)) And CInt(_TableGroupTOP3.Rows(iR)("GroupPKG")) = 1 Then
                    If _TableGroup.Rows.Count < 9 Then
                        _TableGroupTOP3.Rows(iR)("GroupPKG") = "0" & _TableGroup.Rows.Count + 1
                    Else
                        _TableGroupTOP3.Rows(iR)("GroupPKG") = _TableGroup.Rows.Count + 1
                    End If

                    ChangeQ = True

                End If



                _TableGroupTOP3.Rows(iR)("WIP") = top3("WIP")
                _TableGroupTOP3.Rows(iR)("Package") = top3("Package")
                _TableGroupTOP3.Rows(iR)("DayPlan") = Math.Ceiling(Math.Ceiling(top3("DayPlan") / PlanDayDivide) * 1.3)
                _TableGroupTOP3.Rows(iR)("RESULT") = top3("RESULT")

            End If
            iR += 1
        Next
        '--------------*********
        '  DATATABLETEST = New DataTable
        dataViewQ = New DataView(_TableGroupTOP3) 'เรียง Data 1-n
        dataViewQ.Sort = "GroupPKG"
        '  DATATABLETEST = dataViewQ.ToTable
        ' _TableGroupTOP3 = DATATABLETEST
        Time_Calculator(ChangeQ, False)

        ViewTop3.DataSource = dataViewQ
        ViewTop3.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ViewTop3.Columns(0).Width = 150
        ViewTop3.Columns(1).Width = 150
        ViewTop3.Columns(2).Width = 150
        ViewTop3.Columns(4).Width = 150
        ViewTop3.Columns(5).Width = 200

        _TableGroupTOP3.WriteXml(DataTablePath)
        If My.Settings.Debug = False Then
            _TableGroupTOP3.WriteXml(DataTablePathTOP)
        Else
            lbStatus.Text = "Test Debug"
        End If

        'Dim dataTable As DataTable = dataViewQ.ToTable
        'dataTable.WriteXml(DataTablePathTOP)


        My.Settings.TimeStr = TIMEUPDATE
        My.Settings.Save()
        create = True


        'Update UseTop 3 rows
        Dim tmpList As New List(Of String)

        For i = 0 To 2
            If ViewTop3.Rows(i).DataBoundItem("Package").ToString Like "*/*" Then
                Dim PKG() As String = Split(ViewTop3.Rows(i).DataBoundItem("Package").ToString, "/")
                For Each Package As String In PKG
                    tmpList.Add(Package)
                Next
            Else
                tmpList.Add(ViewTop3.Rows(i).DataBoundItem("Package").ToString)
            End If

        Next
        For Each planday As DBxDataSet1.PLMecoPlanData1Row In DBxDataSet11.PLMecoPlanData1

            If tmpList.Contains(planday.Package) Then 'if in array
                planday.UseTop = True
                For Each Viewdata As DataRowView In dataViewQ
                    Dim Array() As String = Split(Viewdata("Package"), "/")
                    If Array.Length > 1 Then
                        If Array(0) = planday.Package Or Array(1) = planday.Package Then
                            Dim TimeTop3() As String = Split(Viewdata("Period"), "-")
                            planday.PKGStartPlan = Format(Now, "yyyy-MM-dd") & " " & TimeTop3(0)
                            planday.PKGEndPlan = Format(Now, "yyyy-MM-dd") & " " & TimeTop3(1)
                        End If

                    Else
                        If Array(0) = planday.Package Then
                            Dim TimeTop3() As String = Split(Viewdata("Period"), "-")
                            planday.PKGStartPlan = Format(Now, "yyyy-MM-dd") & " " & TimeTop3(0)
                            planday.PKGEndPlan = Format(Now, "yyyy-MM-dd") & " " & TimeTop3(1)
                        End If

                    End If

                Next
            Else
                planday.UseTop = False
            End If

        Next
        PlMecoPlanData1TableAdapter1.Update(DBxDataSet11.PLMecoPlanData1)
        '   DataGridView2.DataSource = _tableTool

        SettingColumns()
        Check_Running()

    End Sub

    Dim loadDay As Boolean
    Private Sub Time_Calculator(ByVal STATUS As Boolean, ByVal TOOL As Boolean)
        Dim CheckGroupPKG As Integer = 4
        Dim countWIP0 As Integer = 1

        Dim STR As TimeSpan = timeENDTOSTRART
        '******************************************************************************************************************************************************************************
        'If My.Settings.TimeStr <> TIMEUPDATE Then
        '    TIMEUPDATE = My.Settings.TimeStr

        'End If
        TIMEUPDATE = My.Settings.TimeStr
        PlMecoCapaDataTableAdapter1.FillUpdate(DBxDataSet11.PLMecoCapaData) 'Fill บ่อย
        Dim UPDATETIME As TimeSpan = TIMEUPDATE
        Dim GroupCount As Int16 = 0
        For Each DATA As DataRowView In dataViewQ

            If create = False Then
                Dim DataSplit As String() = DATA("Package").Split(CChar("/"))
                ' PlMecoCapaDataTableAdapter1.Fill(DBxDataSet11.PLMecoCapaData, DataSplit(0))
                Dim GG As Double
                Dim JJ As Double
                Dim Timee As Double
                Dim TimeTotal As TimeSpan

                Dim TimeEND As TimeSpan

                For Each Capa As DBxDataSet1.PLMecoCapaDataRow In DBxDataSet11.PLMecoCapaData
                    If Capa.Package = DataSplit(0) Then


                        Dim WIP As Integer = DATA("WIP")
                        Dim Result As Integer = DATA("Result")
                        If DATA("WIP") = "0" Then
                            Exit For
                        ElseIf (DATA("WIP") + DATA("RESULT") / (DATA("DayPlan") / PlanDayDivide) * 100) > 130 Then
                            WIP = (CInt(DATA("DayPlan")) * 1.3) - DATA("RESULT")
                        End If
                        GG = Capa.F_LotRate * WIP 'DATA("WIP")
                        JJ = (GG / Capa.Capa) * 60 + Capa.TypeChange
                        Timee = JJ / 0.85
                        TimeTotal = New TimeSpan(0, Timee, 0)
                        TimeEND = TimeTotal + TimeStart
                        '    If DATA("WIP") Then
                        If DATA("GroupPKG") = "01" Then
                            TimeEND = Now.TimeOfDay + TimeTotal
                            '-------
                            'GG = Capa.F_LotRate * Result 'DATA("WIP")
                            'JJ = (GG / Capa.Capa) * 60 + Capa.TypeChange
                            'Timee = JJ / 0.85
                            'TimeTotal = New TimeSpan(0, Timee, 0)
                            If loadDay = True Then
                                TimeStart = My.Settings.TimeStr
                                loadDay = False
                            Else
                                TimeStart = Now.TimeOfDay '- TimeTotal
                            End If

                            '-------------------------
                            timeENDTOSTRART = TimeEND
                            TIMEUPDATE = TimeStart

                        End If
                        Exit For
                    End If
                Next
                DATA("Period") = TimeStart.ToString("hh\:mm") & "-" & TimeEND.ToString("hh\:mm")


                TimeStart = TimeEND
            Else
                If STATUS = True Then

                    If CInt(DATA("GroupPKG")) = CheckGroupPKG Then
                        If (DATA("WIP") / (DATA("DayPlan") / PlanDayDivide) * 100) > My.Settings.Percent Then 'And toolOver = False
                            If CInt(DATA("GroupPKG")) <= 10 Then
                                DATA("GroupPKG") = "0" & DATA("GroupPKG") - countWIP0
                            Else
                                DATA("GroupPKG") = DATA("GroupPKG") - countWIP0
                            End If
                        Else
                            CheckGroupPKG += 1
                            countWIP0 += 1
                        End If

                    Else
                        If CInt(DATA("GroupPKG")) <= 10 Then
                            DATA("GroupPKG") = "0" & DATA("GroupPKG") - 1
                        Else
                            DATA("GroupPKG") = DATA("GroupPKG") - 1
                        End If
                    End If

                    Dim DataSplit As String() = DATA("Package").Split(CChar("/"))
                    '      PlMecoCapaDataTableAdapter1.Fill(DBxDataSet11.PLMecoCapaData, DataSplit(0)) 'Fill บ่อย

                    Dim GG As Double
                    Dim JJ As Double
                    Dim Timee As Double
                    Dim TimeTotal As TimeSpan

                    Dim TimeEND As TimeSpan

                    For Each Capa As DBxDataSet1.PLMecoCapaDataRow In DBxDataSet11.PLMecoCapaData
                        If Capa.Package = DataSplit(0) Then

                            Dim WIP As Integer = DATA("WIP")
                            If DATA("WIP") = "0" Then
                                Exit For
                            ElseIf (DATA("WIP") + DATA("RESULT") / (DATA("DayPlan") / PlanDayDivide) * 100) > 130 Then '(DATA("WIP") / (DATA("DayPlan") / PlanDayDivide) * 100) > 130 Then
                                WIP = (CInt(DATA("DayPlan")) * 1.3) - DATA("RESULT")
                            End If
                            GG = Capa.F_LotRate * WIP ' DATA("WIP")
                            JJ = (GG / Capa.Capa) * 60 + Capa.TypeChange
                            Timee = JJ / 0.85
                            TimeTotal = New TimeSpan(0, Timee, 0)
                            TimeEND = TimeTotal + timeENDTOSTRART

                            If DATA("GroupPKG") = "01" Then
                                TimeEND = Now.TimeOfDay + TimeTotal
                                timeENDTOSTRART = Now.TimeOfDay
                                TIMEUPDATE = timeENDTOSTRART
                                ' My.Settings.TimeStr = timeENDTOSTRART
                                '   My.Settings.Save()
                            End If
                            Exit For
                        End If
                    Next

                    DATA("Period") = timeENDTOSTRART.ToString("hh\:mm") & "-" & TimeEND.ToString("hh\:mm")


                    timeENDTOSTRART = TimeEND

                Else
                    Dim DataSplit As String() = DATA("Package").Split(CChar("/"))
                    '   PlMecoCapaDataTableAdapter1.Fill(DBxDataSet11.PLMecoCapaData, DataSplit(0))
                    Dim GG As Double
                    Dim JJ As Double
                    Dim Timee As Double
                    Dim TimeTotal As TimeSpan

                    Dim TimeEND As TimeSpan
                    For Each Capa As DBxDataSet1.PLMecoCapaDataRow In DBxDataSet11.PLMecoCapaData
                        If Capa.Package = DataSplit(0) Then
                            Dim WIP As Integer = DATA("WIP")
                            If DATA("WIP") = "0" Then
                                Exit For
                            ElseIf (DATA("WIP") + DATA("RESULT") / (DATA("DayPlan") / PlanDayDivide) * 100) > 130 Then '(DATA("WIP") / (DATA("DayPlan") / PlanDayDivide) * 100) > 130 Then
                                WIP = (CInt(DATA("DayPlan")) * 1.3) - DATA("RESULT")
                            End If
                            GG = Capa.F_LotRate * WIP 'DATA("WIP")
                            JJ = (GG / Capa.Capa) * 60 + Capa.TypeChange
                            Timee = JJ / 0.85
                            TimeTotal = New TimeSpan(0, Timee, 0)
                            TimeEND = TimeTotal + UPDATETIME
                            GroupCount += 1
                            If DATA("GroupPKG") = "01" Or GroupCount = 1 Then

                                TimeEND = Now.TimeOfDay + TimeTotal
                                timeENDTOSTRART = TimeEND
                                TIMEUPDATE = UPDATETIME
                                UPDATETIME = Now.TimeOfDay
                                ''---------------------------------------------------------------------- Now.TimeOfDay
                            End If
                            Exit For
                        End If
                    Next

                    DATA("Period") = UPDATETIME.ToString("hh\:mm") & "-" & TimeEND.ToString("hh\:mm")

                    UPDATETIME = TimeEND
                End If
            End If
        Next

    End Sub
    Private Sub QueryUpdate() 'Update plan Sort by now but cannot update new package

        ' lbTimeUpdate.Text = Now
        datedebug = Now

        Try
            Updata()
        Catch ex As Exception
            SaveCatchLog(ex.ToString, "Updata()")
        End Try
        Try
            RunTOP1()
        Catch ex As Exception
            SaveCatchLog(ex.ToString, "RunTOP1()")

        End Try
        lbTimeUpdate.Text = "Update :" & Now
        Debug.Print((Now - datedebug).ToString & "Select1")
        '   Label3.Text = timee.ToString
        '  Debug.Print((Now - datee).ToString & ">>End")
        '  Debug.Print((Date.Now - DDa).ToString & ">>41")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btUpdate.Click
        QueryUpdate()
    End Sub
    Dim datedebug As Date
    Private Sub Updata()
        Try

            AutoPlan()

        Catch ex As Exception
            SaveCatchLog(ex.ToString, "AutoPlan()")
        End Try

        'If loadDay = True Or DateWip Like "*08:00:00*" Then
        '    listResult.Clear()

        'End If
        'Dim ListTableResule As DataTable = New DataTable
        'ListTableResule.Columns.Add("Result")
        'ListTableResule.Columns.Add("PKG")

        '    Dim DDa As DateTime = Date.Now


        PlMecoCapaDataTableAdapter1.FillUpdate(DBxDataSet11.PLMecoCapaData)
        Dim endWIP As DateTime = CDate(DateWip).AddHours(+12)
        ResultMecoTableAdapter1.Fill(DBxDataSet11.ResultMeco, My.Settings.MCNo, CDate(DateWip), endWIP) ' DateWip  Result Now.Date & " 08:00:00"


        PlMecoPlanData1TableAdapter1.FillBy(DBxDataSet11.PLMecoPlanData1, MecoPlanday, My.Settings.MCNo)
        'ApcsdbwipTableAdapter1.Fill(DBxDataSet11.APCSDBWIP)


        Dim WIPIPMAdapters As New DBxDataSet1TableAdapters.PLIPMWipTableAdapter 'count wip package PLIPMWip

        Dim WIPIPM As DBxDataSet1.PLIPMWipDataTable = WIPIPMAdapters.GetData() '2  sec

        Dim lotdatas As List(Of LotData) = GetWIPData()
        For Each Data As DBxDataSet1.PLMecoPlanData1Row In DBxDataSet11.PLMecoPlanData1
            'Data WIP APCSDB
            Dim CheckPKG As Boolean = False

            Dim lotdata_pkg As List(Of LotData) = lotdatas.Where(Function(x) x.Package.ToUpper.Trim = Data.Package.ToUpper.Trim).ToList
            If lotdata_pkg.Count > 0 Then
                CheckPKG = True
                Data.WIP = lotdata_pkg.Count
            End If

            'For Each lotdata In lotdatas.Where(Function(x) x.Package.ToUpper.Trim = Data.Package.ToUpper.Trim)
            '    'If Data.Package = lotdata Then
            '    '    Data.WIP = lotdata.WIP
            '    '    CheckPKG = True
            '    'End If
            'Next


            'For Each apcsData As DBxDataSet1.APCSDBWIPRow In DBxDataSet11.APCSDBWIP

            '    If Data.Package = apcsData.FORM_NAME Then
            '        Data.WIP = apcsData.WIP
            '        CheckPKG = True
            '    End If

            'Next

            If CheckPKG = False Then
                Dim count As Integer = 0
                Dim packageList As List(Of String) = New List(Of String)
                For Each dataa As DBxDataSet1.PLIPMWipRow In WIPIPM 'count wip package PLIPMWip
                    If dataa.Package = Data.Package Then
                        count += 1
                    End If
                    packageList.Add(dataa.Package)
                Next
                If packageList.Contains(Data.Package) Then
                    Data.WIP = count
                Else
                    Data.WIP = "0"
                End If

            End If
            'Data Result
            Dim CheckResule As Boolean = False
            For Each dataResult As DBxDataSet1.ResultMecoRow In DBxDataSet11.ResultMeco
                If Data.Package.Trim = dataResult.Package.Trim() Then
                    '  Resule += Resule
                    Data.Result = dataResult.Result
                    CheckResule = True
                End If
            Next
            If CheckResule = False Then
                Data.Result = "0"
            End If

        Next


        PlMecoPlanData1TableAdapter1.Update(DBxDataSet11.PLMecoPlanData1)

    End Sub

    Private Function ResultDay(ByVal _TableGroup As DBxDataSet1.PLMecoPlanGroupDataTable)

        Dim _TableGroupNow As New DBxDataSet1.PLMecoPlanGroupDataTable

        For Each _dataRow As DataRow In _TableGroup
            _TableGroupNow.ImportRow(_dataRow)
        Next

        For Each DATARR As DataColumn In _TableGroupNow.Columns
            DATARR.ReadOnly = False
        Next
        If CDate(DateWip).TimeOfDay.ToString Like "*20:00:00*" Then
            Dim DateWIP2 As String = CDate(DateWip).ToShortDateString & " 08:00:00"


            ResultMecoTableAdapter1.Fill(DBxDataSet11.ResultMeco, My.Settings.MCNo, DateWIP2, CDate(DateWIP2).AddHours(+12).ToString)

            For Each data As DBxDataSet1.PLMecoPlanGroupRow In _TableGroupNow
                For Each Result As DBxDataSet1.ResultMecoRow In DBxDataSet11.ResultMeco
                    If data.Package Like "*" & Result.Package & "*" Then
                        data.RESULT = Result.Result + data.RESULT
                        '   Exit For
                    End If
                Next
            Next
        End If
        Return _TableGroupNow

    End Function
    Private Sub TimerUpdate_Tick(sender As Object, e As EventArgs) Handles TimerUpdate.Tick
        QueryUpdate()
    End Sub



    Private Sub TimerNow_Tick(sender As Object, e As EventArgs) Handles TimerNow.Tick
        DNtime()

    End Sub
    Dim formload As Boolean = False
    Private Sub DNtime()

        If Format(Now, "HH:mm:ss") > "08:00:00" And DateWIPDN <> 1 And Format(Now, "HH:mm:ss") < "20:00:00" Then
            DateWip = Format(Now.Date, "yyyy/MM/dd") & " 08:00:00"
            DateWIPDN = 1
            DayNight.Text = "Day"

            create = False

            MecoPlanday = Format(Now.Date, "yyyy-MM-dd") ' "2016-12-06" '


            If formload = True Then


                If DateWIPDN = 1 And create = False Then
                    TimeStart = New TimeSpan(8, 5, 0)
                    _TableGroupTOP3.Clear()
                    My.Settings.TimeStr = New TimeSpan(Now.Hour, Now.Minute, Now.Second) 'New TimeSpan(8, 5, 0)
                    loadDay = True
                    Try
                        Updata()
                    Catch ex As Exception
                        SaveCatchLog(ex.ToString, "Updata()")
                    End Try
                    Try
                        RunTOP1()
                    Catch ex As Exception
                        SaveCatchLog(ex.ToString, "RunTOP1()")

                    End Try
                ElseIf DateWIPDN = 2 And DateWIPDN = 3 And create = False Then
                    '  TimeStart = New TimeSpan(20, 5, 0)

                    '  _TableGroupTOP3.Clear()
                    '  My.Settings.TimeStr = New TimeSpan(20, 5, 0)
                End If
            End If
        ElseIf Format(Now, "HH:mm:ss") > "20:00:00" And DateWIPDN <> 3 Then
            DateWip = Format(Now.Date, "yyyy/MM/dd") & " 20:00:00"
            DateWIPDN = 1
            DayNight.Text = "Night"

            MecoPlanday = Format(Now.Date, "yyyy-MM-dd") ' "2016-12-06" '

        ElseIf Format(Now, "HH:mm:ss") < "08:00:00" And DateWIPDN <> 3 Then
            DateWip = Format(Now.Date.AddDays(-1), "yyyy/MM/dd") & " 20:00:00"
            DateWIPDN = 3
            DayNight.Text = "Night"
            '  _TableGroupTOP3.Clear()
            MecoPlanday = Format(Now.Date.AddDays(-1), "yyyy-MM-dd")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim DataTablePath As String = My.Application.Info.DirectoryPath & "\DataTableXml.xml"
        If System.IO.File.Exists(DataTablePath) = True Then
            'And IsNothing(ViewTop3.DataSource) Then  'open data

            _TableGroupTOP3.ReadXml(DataTablePath)

            create = True
            dataViewQ = New DataView(_TableGroupTOP3) 'เรียง Data 1-n
            dataViewQ.Sort = "GroupPKG"

            ViewTop3.DataSource = dataViewQ

        End If

    End Sub

    Private Sub btOPERATION_Click(sender As Object, e As EventArgs) Handles btOPERATION.Click, btWAITING.Click, btTYPECHANGE.Click, btSTOP.Click, btPMREQUEST.Click, btOPM.Click, btBRAKETIME.Click
        Dim Val As Button = CType(sender, Button)
        lbStatus.Text = Val.Text
        lbStatusColor.BackColor = Val.BackColor
    End Sub
    Dim _TableUseTool As DataTable = New DataTable

    Dim PKG_UP As String
    Dim pKG As String
    Dim PKG_Down As String
    Dim rowss As Int16 = 1
    Dim rowNow As String
    Dim rowlest As String
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btDown.Click
        lbMC.Text = "กรุณาเลือก Package"
        If BT_Check = False Then
            MsgBox("กรุณาเลือก Package")
            Exit Sub
        Else
            BT_Check = False
        End If
        Dim Count As Int16 = 0
        _TableGroupTOP3.DefaultView.Sort = "GroupPKG"
        Dim group As String
        For Each data As DataRow In _TableGroupTOP3

            If (data("GroupPKG") = "03" And pKG = data("Package")) Then
                MsgBox("Not Q")
                Exit Sub
            End If
            If pKG = data("Package") Then

                Dim GroupPKG As String
                If data("GroupPKG") + 1 < 10 Then
                    GroupPKG = "0" & data("GroupPKG") + 1
                Else
                    GroupPKG = data("GroupPKG") + 1
                End If
                data("GroupPKG") = GroupPKG
                group = GroupPKG
            End If
            If PKG_Down = data("Package") Then
                Dim GroupPKG As String
                If data("GroupPKG") + 1 < 10 Then
                    GroupPKG = "0" & data("GroupPKG") - 1
                Else
                    GroupPKG = data("GroupPKG") - 1
                End If
                data("GroupPKG") = GroupPKG

            End If

        Next

        '   ViewTop3.DataSource = dataViewQ ' _TableGroupTOP3
        dataViewQ = New DataView(_TableGroupTOP3)
        ViewTop3.DataSource = _TableGroupTOP3
        selects()
        SettingColumns()

    End Sub
    Dim BT_Check As Boolean
    Private Sub ViewTop3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ViewTop3.CellClick
        If e.RowIndex <> -1 Then
            pKG = ViewTop3.Rows(e.RowIndex).Cells(3).Value
            BT_Check = True
            lbMC.Text = pKG
        Else
            pKG = Nothing
            Exit Sub
        End If

        If e.RowIndex < 2 Then
            PKG_Down = ViewTop3.Rows(e.RowIndex + 1).Cells(3).Value
        Else
            PKG_Down = Nothing
        End If
        If e.RowIndex >= 1 Then
            PKG_UP = ViewTop3.Rows(e.RowIndex - 1).Cells(3).Value
        Else
            PKG_UP = Nothing
        End If
        rowss = e.RowIndex + 1


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btUp.Click
        lbMC.Text = "กรุณาเลือก Package"
        If BT_Check = False Then
            MsgBox("กรุณาเลือก Package")
            Exit Sub
        Else
            BT_Check = False
        End If
        Dim Count As Int16 = 0
        _TableGroupTOP3.DefaultView.Sort = "GroupPKG"
        Dim group As String
        For Each data As DataRow In _TableGroupTOP3

            If pKG = data("Package") Then
                If data("GroupPKG") = "01" Then
                    MsgBox("Not Q")
                    Exit Sub
                End If
                Dim GroupPKG As String
                If data("GroupPKG") + 1 < 10 Then
                    GroupPKG = "0" & data("GroupPKG") - 1
                Else
                    GroupPKG = data("GroupPKG") - 1
                End If
                data("GroupPKG") = GroupPKG
                group = GroupPKG
            End If
            If PKG_UP = data("Package") Then
                Dim GroupPKG As String
                If data("GroupPKG") + 1 < 10 Then
                    GroupPKG = "0" & data("GroupPKG") + 1
                Else
                    GroupPKG = data("GroupPKG") + 1
                End If
                data("GroupPKG") = GroupPKG

            End If

        Next

        ViewTop3.DataSource = _TableGroupTOP3
        selects()
        SettingColumns()
    End Sub

    Private Sub SettingColumns()
        If StatusRun = True Then
            ViewTop3.Rows(0).DefaultCellStyle.BackColor = Color.LawnGreen
            ViewTop3.Rows(0).DefaultCellStyle.SelectionBackColor = Color.Green
        End If
        ViewTop3.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        ViewTop3.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        ViewTop3.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        ViewTop3.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        ViewTop3.Columns(4).HeaderText = "Plan" '/" & DayNight.Text
        ViewTop3.Columns(1).HeaderText = "Result" '/" & DayNight.Text
        ViewTop3.Columns(5).DisplayIndex = 0
        ViewTop3.Columns(3).DisplayIndex = 1
        ViewTop3.Columns(4).DisplayIndex = 2
        ViewTop3.Columns(1).DisplayIndex = 3
        If My.Settings.Debug = False Then
            ViewTop3.Columns(2).Visible = False
        End If
        ViewPlanDay.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        ViewPlanDay.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        ' ViewPlanDay.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        ViewPlanDay.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        ViewPlanDay.Columns(4).HeaderText = "Plan"
        ViewPlanDay.Columns(2).HeaderText = "Priority"
        ViewPlanDay.Columns(1).HeaderText = "Result"
        ViewPlanDay.Columns(2).DisplayIndex = 0
        ViewPlanDay.Columns(3).DisplayIndex = 1
        ViewPlanDay.Columns(4).DisplayIndex = 2
        ViewPlanDay.Columns(1).DisplayIndex = 3
        ViewPlanDay.Columns(0).DisplayIndex = 4

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Timer1.Enabled = False
        '   selects()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles btExit.Click
        Me.Close()

    End Sub
    Dim PKGRun As String
    Dim c_OldOPNo As String
    Private Sub LoadPicture()
        Dim PLData As New DBxDataSet1TableAdapters.PLDataTableAdapter
        Dim Pltable As DBxDataSet1.PLDataDataTable = PLData.GetData(My.Settings.MCNo, MecoPlanday)

        Dim OPNo As String = "-"
        If Pltable.Rows.Count < 1 Then
            '   MsgBox("No Run Machine")
            pbOpno.BackgroundImage = Meco_Production_Plan.My.Resources.Resources.user
            lbOPNo.Text = ""
            Exit Sub
        Else
            PKGRun = Pltable.Rows(0)("Package").ToString()
            OPNo = Pltable.Rows(0)("OPNo").ToString()

        End If
        If c_OldOPNo = OPNo Then
            Return
        End If
        lbOPNo.Text = OPNo

        Try
            Dim oldImage As Image = pbOpno.BackgroundImage

            Dim tClient As WebClient = New WebClient

            'Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData("http://webserv.thematrix.net/lsi/employees/Images/" & OPNo & ".jpg")))
            Dim tImage2 As Bitmap = Bitmap.FromStream(New MemoryStream(CallApi_GetUserAuthrization(OPNo)))  'Bitmap.FromStream(New MemoryStream(APISendGET(OPNo)))
            pbOpno.BackgroundImage = tImage2

            If oldImage Is Nothing Then
                oldImage.Dispose()
            End If




            'Using (var streamWriter = New StreamWriter(httpRequest.GetRequestStream()))
            '{
            '    StreamWriter.Write(json);
            '}

            'String jsonResult = "";
            'var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            'Using (var streamReader = New StreamReader(httpResponse.GetResponseStream()))
            '{
            '    jsonResult = StreamReader.ReadToEnd();
            '}

            'ApiLotInfo apiResultInfo = New JavaScriptSerializer().Deserialize < ApiLotInfo > (jsonResult);
            'Return apiResultInfo;

        Catch ex As Exception
            SaveCatchLog(ex.Message, "http://webserv.thematrix.net/lsi/employees/Images/" & OPNo & ".jpg")
        End Try

    End Sub
    Public Class UserInfo
        Private c_OpNo As String
        Public Property emp_Num() As String
            Get
                Return c_OpNo
            End Get
            Set(ByVal value As String)
                c_OpNo = value
            End Set
        End Property
        Private c_Permission As String
        Public Property permission() As String
            Get
                Return c_Permission
            End Get
            Set(ByVal value As String)
                c_Permission = value
            End Set
        End Property
    End Class
    Private Function APISendGET(opNo As String) As Byte()
        Dim webRequestSetting As New HttpWebRequestSetting
        webRequestSetting.UserName = "000000"
        webRequestSetting.Password = "P@$$w0rd"
        webRequestSetting.Url = "http://rohmapi/api/Man/GetUserIdentification"

        Dim jsonResult As String = ""
        Dim httpRequest As HttpWebRequest = CType(WebRequest.Create(webRequestSetting.Url), HttpWebRequest)
        httpRequest.Credentials = New NetworkCredential(webRequestSetting.UserName, webRequestSetting.Password)
        httpRequest.Method = "POST"
        httpRequest.ContentType = "application/json; charset=utf-8"
        httpRequest.Headers.Add("Authorization", "Bearer ")

        Dim json As String = New JavaScriptSerializer().Serialize(New UserInfo With {.emp_Num = opNo, .permission = ""})
        Using streamWriter As New StreamWriter(httpRequest.GetRequestStream())
            streamWriter.Write(json)
        End Using


        Dim httpResponse = CType(httpRequest.GetResponse(), HttpWebResponse)

        Using streamReader As New StreamReader(httpResponse.GetResponseStream())
            jsonResult = streamReader.ReadToEnd()
            Using ms As New MemoryStream
                streamReader.BaseStream.CopyTo(ms)
                Return ms.ToArray()
            End Using
        End Using

        'Dim student0 As New Object
        'With student0
        '    .First = "Michael"
        '    .Last = "Tucker"
        'End With



        'Dim jsonResult As String = ""
        ' Dim httpResponse = CType(httpRequest.GetResponse(), HttpWebResponse)

        'Console.WriteLine(httpResponse.StatusCode);
        'Dim js As System.Web.Script.Serialization.JavaScriptSerializer = New System.Web.Script.Serialization.JavaScriptSerializer()
        ''js.Deserialize<ESCard>(jsonResult); 
        'Return js.Deserialize(Of String)(jsonResult)
    End Function
    Public Function CallApi_GetUserAuthrization(emp_no As String) As Byte()

        Dim url As String = "http://rohmapi/api/Man/GetUserIdentification"

        Dim json As String = New JavaScriptSerializer().Serialize(New UserInfo With {.emp_Num = emp_no, .permission = ""})

        Dim httpRequest As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        httpRequest.Method = "Post"
        httpRequest.ContentType = "application/json; charset=utf-8"

        Dim CheckAuthenAPI As String = CheckAuthorizationApi()
        httpRequest.Headers.Add("Authorization", "Basic " + CheckAuthenAPI)


        Dim jsonResult As String = ""
        '    Dim is_Pass = ""
        Using streamWriter As New StreamWriter(httpRequest.GetRequestStream())
            streamWriter.Write(json)
        End Using
        Try
            Dim httpResponse = CType(httpRequest.GetResponse(), HttpWebResponse)
            Using streamReader As New StreamReader(httpResponse.GetResponseStream())
                jsonResult = streamReader.ReadToEnd()
                Dim data = JObject.Parse(jsonResult)
                Return CType(data("information")(0)("picture_data"), Byte())
            End Using
        Catch ex As Exception
            Return Nothing
        End Try

        'Try
        '    {

        '    }
        '    Catch
        '    {
        '        Return Json(is_Pass, JsonRequestBehavior.AllowGet);
        '    } 
        '    Return Json(is_Pass, JsonRequestBehavior.AllowGet);
    End Function


    Public Function CheckAuthorizationApi() As String
        Dim username As String = "000000"
        Dim password As String = "P@$$w0rd"
        Dim svcCredentials As String = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(username + ":" + password))

        Return svcCredentials

    End Function






    '    // Other way to whithout help of BlogSites class
    '    //object blogObject = js.Deserialize<object>(jsonResult);
    '    //var blogObject2 = js.Deserialize<ESCard>(jsonResult);




    '    Return js.Deserialize < ESCard > (jsonResult); ;
    '}
    Private Function ClearJigtool()
        Try
            Dim JigtoolAdapters As New DBxDataSet1TableAdapters.PLMecoJigToolTableAdapter
            Dim PL_JigtoolTable As DBxDataSet1.PLMecoJigToolDataTable
            PL_JigtoolTable = JigtoolAdapters.GetDataBy()
            For Each data As DBxDataSet1.PLMecoJigToolRow In PL_JigtoolTable
                data.UseJIG = 0
            Next
            JigtoolAdapters.Update(PL_JigtoolTable)
            Return True
        Catch ex As Exception
            Return False
        End Try


    End Function
    Private Function UseJigtool(ByVal MCNo2 As String, ByVal MCNo3 As String)
        Dim GroupPKGAdapters As New DBxDataSet1TableAdapters.PLMecoPlanData1TableAdapter
        Dim GroupPKGTable As DBxDataSet1.PLMecoPlanData1DataTable


        'use tool
        Try
            If PKG_Running2 <> "" Then
                GroupPKGTable = GroupPKGAdapters.GetDataBy2(PKG_Running2, MecoPlanday, MCNo2)
                Dim result As String = AddUsage(GroupPKGTable.Rows(0)("GroupPKG").ToString(), MecoPlanday, MCNo2)
                If result Like "True*" Then
                    'MsgBox(result)
                    'OK CODING
                Else
                    ' MsgBox(result)
                    '  NG CODING
                End If
            End If
        Catch ex As Exception
            SaveCatchLog(ex.Message, "UseJigtool-PKG_Running2")
        End Try
        Try

            If PKG_Running3 <> "" Then
                GroupPKGTable = GroupPKGAdapters.GetDataBy2(PKG_Running3, MecoPlanday, MCNo3)
                Dim result As String = AddUsage(GroupPKGTable.Rows(0)("GroupPKG").ToString(), MecoPlanday, MCNo3)
                If result Like "True*" Then
                    'MsgBox(result)
                    'OK CODING
                Else
                    ' MsgBox(result)
                    '  NG CODING
                End If
            End If
        Catch ex As Exception
            SaveCatchLog(ex.Message, "UseJigtool-PKG_Running3")
        End Try


        CheckTool()
        Try
            If PKG_Running <> "" Then
                GroupPKGTable = GroupPKGAdapters.GetDataBy2(PKG_Running, MecoPlanday, My.Settings.MCNo)
                Dim result As String = AddUsage(GroupPKGTable.Rows(0)("GroupPKG").ToString(), MecoPlanday, My.Settings.MCNo)
                If result Like "True*" Then
                    'MsgBox(result)
                    'OK CODING
                Else
                    ' MsgBox(result)
                    '  NG CODING
                End If
            End If
        Catch ex As Exception
            SaveCatchLog(ex.Message, "UseJigtool-PKG_Running")
        End Try
        Return True

    End Function
    Private Function CheckTool()

        For Each column As DataGridViewColumn In ViewTop3.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        Dim GroupPKGAdapters As New DBxDataSet1TableAdapters.PLMecoPlanData1TableAdapter
        Dim GroupPKGTable As DBxDataSet1.PLMecoPlanData1DataTable

        GroupPKGTable = GroupPKGAdapters.GetDataBy(MecoPlanday, My.Settings.MCNo)
        For Each data As DBxDataSet1.PLMecoPlanData1Row In GroupPKGTable

            Dim result As String = ToolCheck(data.GroupPKG, MecoPlanday, My.Settings.MCNo)
            If result Like "True*" Then
                For Each PKGTOP3 As DataGridViewRow In ViewTop3.Rows
                    If PKGTOP3.Cells(3).Value Like "*" & data.Package & "*" Then
                        PKGTOP3.DefaultCellStyle.ForeColor = Color.Black
                        PKGTOP3.DefaultCellStyle.BackColor = Color.LawnGreen
                        PKGTOP3.DefaultCellStyle.SelectionBackColor = Color.LawnGreen
                        PKGTOP3.DefaultCellStyle.SelectionForeColor = Color.Black

                        'Exit For
                    End If


                Next
            Else
                For Each PKGTOP3 As DataGridViewRow In ViewTop3.Rows
                    If PKGTOP3.Cells(3).Value Like "*" & data.Package & "*" Then
                        '  PKGTOP3.DefaultCellStyle.ForeColor = Color.Red
                        PKGTOP3.DefaultCellStyle.BackColor = Color.Red
                        PKGTOP3.DefaultCellStyle.ForeColor = Color.White
                        PKGTOP3.DefaultCellStyle.SelectionBackColor = Color.Red
                        PKGTOP3.DefaultCellStyle.SelectionForeColor = Color.White
                        ' Exit For
                    End If
                Next
            End If

        Next

        Return True
    End Function
    Dim StatusRun As Boolean
    Dim PKG_Running As String
    Dim PKG_Running2 As String
    Dim PKG_Running3 As String
    Dim RunningAdapters As New DBxDataSet1TableAdapters.PLDataTableAdapter
    Dim PL_RunningTable As DBxDataSet1.PLDataDataTable
    Dim PL_RunningTable2 As DBxDataSet1.PLDataDataTable
    Dim PL_RunningTable3 As DBxDataSet1.PLDataDataTable
    Private Sub Check_Running()

        PKG_Running = ""
        PKG_Running2 = ""
        PKG_Running3 = ""

        Dim MCNo2 As String = ""
        Dim MCNo3 As String = ""
        If My.Settings.MCNo = "PL-M-01" Then
            MCNo2 = "PL-M-02"
            MCNo3 = "PL-M-03"
        ElseIf My.Settings.MCNo = "PL-M-02" Then
            MCNo2 = "PL-M-01"
            MCNo3 = "PL-M-03"
        ElseIf My.Settings.MCNo = "PL-M-03" Then
            MCNo2 = "PL-M-01"
            MCNo3 = "PL-M-02"
        End If
        Dim OPNo As String = ""
        PL_RunningTable = RunningAdapters.GetDataBy(My.Settings.MCNo)
        If PL_RunningTable.Rows.Count > 0 Then
            PKG_Running = PL_RunningTable.Rows(0)("Package").ToString()
            OPNo = PL_RunningTable.Rows(0)("OPNo").ToString()
        End If

        PL_RunningTable2 = RunningAdapters.GetDataBy(MCNo2)
        If PL_RunningTable2.Rows.Count > 0 Then
            PKG_Running2 = PL_RunningTable2.Rows(0)("Package").ToString()
        End If

        PL_RunningTable3 = RunningAdapters.GetDataBy(MCNo3)
        If PL_RunningTable3.Rows.Count > 0 Then
            PKG_Running3 = PL_RunningTable3.Rows(0)("Package").ToString()
        End If

        ClearJigtool()

        UseJigtool(MCNo2, MCNo3)

        If PKG_Running <> "" Then
            Label1.Text = ""
            lbPKGRUN.Text = "Machine Running : " & PKG_Running
            lbOPNo.Text = OPNo
            If c_OldOPNo = OPNo Then
                Return
            End If
            'PictureOPNo
            Dim oldImage As Image = pbOpno.BackgroundImage
            Dim tClient As WebClient = New WebClient
            ' Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData("http://webserv.thematrix.net/lsi/employees/Images/" & OPNo & ".jpg")))
            Dim tImage2 As Bitmap = Bitmap.FromStream(New MemoryStream(CallApi_GetUserAuthrization(OPNo)))  'Bitmap.FromStream(New MemoryStream(APISendGET(OPNo)))

            pbOpno.BackgroundImage = tImage2
            If oldImage Is Nothing Then
                oldImage.Dispose()
            End If

            For Each data As DataRowView In dataViewQ
                Dim PKG() As String = Split(data("Package"), "/")

                If PKG.Contains(PKG_Running) Then
                    For Each DATATOP3 As DataGridViewRow In ViewTop3.Rows
                        If PKG_Running Like "*" & DATATOP3.Cells(3).Value & "*" Then
                            ViewTop3.MultiSelect = False
                            DATATOP3.Selected = True
                        End If

                    Next


                    lbPlan.Text = "Plan : " & data("DayPlan")
                    lbResult.Text = "Result : " & data("Result")
                    lbWIP.Text = "WIP : " & data("WIP")
                    lbPKGRUN.ForeColor = Color.Green
                    lbPlan.ForeColor = Color.Green
                    lbResult.ForeColor = Color.Green
                    lbWIP.ForeColor = Color.Green
                    Exit For
                End If
            Next
        Else

            Label1.Text = "Machine Stop"
            lbPKGRUN.Text = ""
            lbPlan.Text = ""
            lbResult.Text = ""
            lbWIP.Text = ""
            lbPKGRUN.ForeColor = Color.Red
            lbPlan.ForeColor = Color.Red
            lbResult.ForeColor = Color.Red
            lbWIP.ForeColor = Color.Red


            pbOpno.BackgroundImage = Meco_Production_Plan.My.Resources.Resources.user
            lbOPNo.Text = ""

        End If

        'If Pltable.Rows.Count < 1 Then
        '    '   MsgBox("No Run Machine")
        '    PictureBox1.BackgroundImage = Meco_Production_Plan.My.Resources.Resources.user
        '    lbOPNo.Text = ""
        '    Exit Sub
        'Else
        '    ' PKGRun = Pltable.Rows(0)("Package").ToString()
        '    ' OPNo = Pltable.Rows(0)("OPNo").ToString()

        'End If


    End Sub


    Private Sub RunTOP1()

        Dim PKGRun As String = Nothing
        Dim PKGTOP2 As String = Nothing
        Dim GroupRun As String = Nothing
        _TableGroupTOP3.DefaultView.Sort = "GroupPKG"
        For Each data As DataRow In _TableGroupTOP3
            Dim PKGarray() As String = Split(data("Package"), "/")

            If data("GroupPKG") = "02" Then
                PKGTOP2 = data("Package")
                '  PKGTOP = data("Package")
            End If

            If PKGarray.Contains(PKG_Running) Then
                GroupRun = data("GroupPKG")
                PKGRun = data("Package")
            End If

        Next
        If GroupRun = "01" Then
            '  Return False
            '  Exit Sub

        Else
            For Each dataRun As DataRow In _TableGroupTOP3
                If PKGRun = dataRun("Package") Then
                    dataRun("GroupPKG") = "01"

                Else
                    If dataRun("GroupPKG") >= GroupRun Then

                    Else
                        If dataRun("GroupPKG") + 1 < 10 Then
                            dataRun("GroupPKG") = "0" & dataRun("GroupPKG") + 1
                        Else
                            dataRun("GroupPKG") = dataRun("GroupPKG") + 1
                        End If
                    End If


                End If


            Next
            dataViewQ = New DataView(_TableGroupTOP3)
            ViewTop3.DataSource = dataViewQ ' _TableGroupTOP3
        End If

        Try
            selects()
        Catch ex As Exception
            '  MsgBox("selects :" & ex.Message.ToString)
            SaveCatchLog(ex.ToString, "selects()")
        End Try

    End Sub


    Private Sub ToolCheck_Click(sender As Object, e As EventArgs) Handles btToolCheck.Click

        Dim GroupPKGTOP As String = ViewTop3.Rows(0).Cells(2).Value
        Dim PKGTOP() As String = Split(ViewTop3.Rows(0).Cells(3).Value, "/")
        btToolCheck.Text = PKGTOP(0) & "-" & GroupPKGTOP


        '   If PKGTOP.Contains(PKG_Running) Then
        Dim result As String = ToolCheck(GroupPKGTOP, MecoPlanday, My.Settings.MCNo)

        If result Like "True*" Then

        Else
            'NG CODING
        End If

        MsgBox(result.ToString)

    End Sub
    Private Sub AddUsage_Click(sender As Object, e As EventArgs) Handles btAddUsage.Click

        Dim result As String = AddUsage("01", "2016-12-06", "PL-M-03")

        If result Like "True*" Then

            'OK CODING
        Else
            '  NG CODING
        End If

        MsgBox(result.ToString)
    End Sub
    Private Sub RemoveFromUsage_Click_2(sender As Object, e As EventArgs) Handles btRemoveFromUsage.Click

        Dim GroupPKGTOP As String = ViewTop3.Rows(0).Cells(2).Value
        Dim PKGTOP() As String = Split(ViewTop3.Rows(0).Cells(3).Value, "/")
        btRemoveFromUsage.Text = PKGTOP(0) & "-" & GroupPKGTOP

        Dim result As String = RemoveFromUsage(GroupPKGTOP, MecoPlanday, My.Settings.MCNo)

        If result Like "True*" Then

            'OK CODING
        Else
            '  NG CODING
        End If

        MsgBox(result.ToString)
    End Sub
    Private Function ToolCheck(ByVal GroupPackageID As String, ByVal PlanDay As String, ByVal MCNo As String) As String

        Try
            Dim Reason As String = ""
            Dim RESULT As Boolean = False


            Dim PkgGroupAdapters As New DBxDataSet1TableAdapters.PL_GroupTableAdapter
            Dim PkgGroupTable As DBxDataSet1.PL_GroupDataTable = PkgGroupAdapters.GetData(GroupPackageID, PlanDay, MCNo)    'Search by GroupPackageID for find GroupName
            Dim ToolGroupAdapters As New DBxDataSet1TableAdapters.PLToolTypeTableAdapter
            Dim ToolTable As New DBxDataSet1.PLToolTypeDataTable
            Dim ToolStockAdapters As New DBxDataSet1TableAdapters.PLMecoJigToolTableAdapter
            Dim ToolStockTable As New DBxDataSet1.PLMecoJigToolDataTable



            If PkgGroupTable.Rows.Count > 0 Then
                ToolGroupAdapters.Fill(ToolTable, PkgGroupTable.Rows(0)("GroupName").ToString)   'Use GroupName find tool usage name
            Else
                Reason = "This GroupPackage ID Not found"
                Return RESULT.ToString & " :" & Reason
            End If

            Dim ToolListHash As New Hashtable
            Dim ToolList As New List(Of String)


            For Each Row As DBxDataSet1.PLToolTypeRow In ToolTable  'Keep Tool usage data in list
                ToolList.Add(Row.NameJIG)
                ToolListHash.Add(Row.NameJIG, Row.UsageUnit)
            Next
            For i = 1 To 16                    'Maximum Tool per group 16 tools and change no use array to ""
                If ToolList.Count < i Then
                    ToolList.Add("")
                End If
            Next


            ' finding tool stock by tool name
            ToolStockTable = ToolStockAdapters.GetData(ToolList(0), ToolList(1), ToolList(2), ToolList(3), ToolList(4), ToolList(5), ToolList(6), ToolList(7), ToolList(8), ToolList(9), ToolList(10), ToolList(11), ToolList(12), ToolList(13), ToolList(14), ToolList(15))

            DataGridView1.DataSource = ToolStockTable
            DataGridView2.DataSource = ToolTable


            'Check stock with request

            For Each rw As DBxDataSet1.PLMecoJigToolRow In ToolStockTable
                If CInt(rw.Stock - rw.UseJIG) < CInt(ToolListHash(rw.NameJIG)) Then      'stock - UseJig must be lower than request quantity in check list
                    RESULT = False
                    Exit For
                Else
                    RESULT = True
                End If

            Next

            Return RESULT.ToString & " :" & Reason

        Catch ex As Exception

            Return " False :" & ex.ToString

        End Try

    End Function

    Private Function AddUsage(ByVal GroupPackageID As String, ByVal PlanDay As String, ByVal MCNo As String) As String
        Try
            Dim Reason As String = ""
            Dim RESULT As Boolean = False

            Dim PkgGroupAdapters As New DBxDataSet1TableAdapters.PL_GroupTableAdapter
            Dim PkgGroupTable As DBxDataSet1.PL_GroupDataTable = PkgGroupAdapters.GetData(GroupPackageID, PlanDay, MCNo)
            Dim ToolGroupAdapters As New DBxDataSet1TableAdapters.PLToolTypeTableAdapter
            Dim ToolTable As New DBxDataSet1.PLToolTypeDataTable
            Dim ToolStockAdapters As New DBxDataSet1TableAdapters.PLMecoJigToolTableAdapter
            Dim ToolStockTable As New DBxDataSet1.PLMecoJigToolDataTable


            If PkgGroupTable.Rows.Count > 0 Then
                ToolGroupAdapters.Fill(ToolTable, PkgGroupTable.Rows(0)("GroupName").ToString)   'Use GroupName find tool usage name
            Else
                Reason = "This GroupPackage ID Not found"
                Return RESULT.ToString & " :" & Reason
            End If
            Dim ToolListHash As New Hashtable
            Dim ToolList As New List(Of String)
            Dim keyColl As ICollection = ToolListHash.Keys

            For Each Row As DBxDataSet1.PLToolTypeRow In ToolTable
                ToolList.Add(Row.NameJIG)
                ToolListHash.Add(Row.NameJIG, Row.UsageUnit)

            Next


            For i = 1 To 16
                If ToolList.Count < i Then
                    ToolList.Add("")
                End If
            Next


            Dim Value As Integer = 0
            ToolStockTable = ToolStockAdapters.GetData(ToolList(0), ToolList(1), ToolList(2), ToolList(3), ToolList(4), ToolList(5), ToolList(6), ToolList(7), ToolList(8), ToolList(9), ToolList(10), ToolList(11), ToolList(12), ToolList(13), ToolList(14), ToolList(15))

            For Each rw As DBxDataSet1.PLMecoJigToolRow In ToolStockTable

                Value = CInt(rw.UseJIG) + CInt(ToolListHash(rw.NameJIG))
                If Value > rw.Stock Then
                    Reason = "Can Not add over stock (" & rw.NameJIG & ")"
                    RESULT = False
                    Return RESULT.ToString & " :" & Reason
                End If

                rw.UseJIG = Value
                RESULT = True
            Next

            ToolStockAdapters.Update(ToolStockTable)
            DataGridView1.DataSource = ToolStockTable
            DataGridView2.DataSource = ToolTable

            Return RESULT.ToString & " :" & Reason
        Catch ex As Exception
            Return " False :" & ex.ToString
        End Try

    End Function

    Private Function RemoveFromUsage(ByVal GroupPackageID As String, ByVal PlanDay As String, ByVal MCNo As String) As String
        Try
            Dim Reason As String = ""
            Dim RESULT As Boolean = False


            Dim PkgGroupAdapters As New DBxDataSet1TableAdapters.PL_GroupTableAdapter
            Dim PkgGroupTable As DBxDataSet1.PL_GroupDataTable = PkgGroupAdapters.GetData(GroupPackageID, PlanDay, MCNo)  'Search by GroupPackageID for find GroupName
            Dim ToolGroupAdapters As New DBxDataSet1TableAdapters.PLToolTypeTableAdapter
            Dim ToolTable As New DBxDataSet1.PLToolTypeDataTable
            Dim ToolStockAdapters As New DBxDataSet1TableAdapters.PLMecoJigToolTableAdapter
            Dim ToolStockTable As New DBxDataSet1.PLMecoJigToolDataTable

            If PkgGroupTable.Rows.Count > 0 Then
                ToolGroupAdapters.Fill(ToolTable, PkgGroupTable.Rows(0)("GroupName").ToString)   'Use GroupName find tool usage name
            Else
                Reason = "This GroupPackage ID Not found"
                Return RESULT.ToString & " :" & Reason
            End If

            Dim ToolListHash As New Hashtable
            Dim ToolList As New List(Of String)


            For Each Row As DBxDataSet1.PLToolTypeRow In ToolTable  'Keep Tool usage data in list
                ToolList.Add(Row.NameJIG)
                ToolListHash.Add(Row.NameJIG, Row.UsageUnit)

            Next


            For i = 1 To 16                    'Maximum Tool per group 16 tools and change no use array to ""
                If ToolList.Count < i Then
                    ToolList.Add("")
                End If
            Next


            ' finding tool stock by tool name
            ToolStockTable = ToolStockAdapters.GetData(ToolList(0), ToolList(1), ToolList(2), ToolList(3), ToolList(4), ToolList(5), ToolList(6), ToolList(7), ToolList(8), ToolList(9), ToolList(10), ToolList(11), ToolList(12), ToolList(13), ToolList(14), ToolList(15))

            DataGridView1.DataSource = ToolStockTable
            DataGridView2.DataSource = ToolTable


            'Check stock with request
            Dim Value As Integer = 0
            For Each rw As DBxDataSet1.PLMecoJigToolRow In ToolStockTable

                Value = CInt(rw.UseJIG) - CInt(ToolListHash(rw.NameJIG))
                If Value < 0 Then
                    Reason = "Usage Tool (" & rw.NameJIG & ")were zero already"
                    Return RESULT.ToString & " :" & Reason
                End If

                rw.UseJIG = Value
                RESULT = True
            Next

            ToolStockAdapters.Update(ToolStockTable)
            DataGridView1.DataSource = ToolStockTable
            DataGridView2.DataSource = ToolTable
            Return RESULT.ToString & " :" & Reason

        Catch ex As Exception
            Return " False :" & ex.ToString
        End Try
    End Function

    Public DIR_LOG As String = My.Application.Info.DirectoryPath & "\LOG"
    Public Sub SaveCatchLog(ByVal message As String, ByVal fnName As String)
        If Directory.Exists(DIR_LOG & "\BackUp") = False Then
            Directory.CreateDirectory(DIR_LOG & "\BackUp")
        End If
        Dim arr As String() = Directory.GetFiles(DIR_LOG)
        If arr.Length >= 50 Then
            Dim arr1 As String() = Directory.GetFiles(DIR_LOG & "\BackUp")
            For Each strData1 As String In arr1
                File.Delete(strData1)
            Next
            For Each strData As String In arr
                Dim pathSource As String = strData
                Dim pathdes As String = strData.Replace(DIR_LOG, DIR_LOG & "\BackUp")
                File.Move(pathSource, pathdes)
            Next

            Directory.CreateDirectory(DIR_LOG & "\BackUp")

        End If

        Using sw As StreamWriter = New StreamWriter(Path.Combine(DIR_LOG, "Catch_" & Now.ToString("yyyyMMdd") & ".log"), True)
            sw.WriteLine(Now.ToString("yyyy/MM/dd HH:mm:ss.fff") & " " & fnName & ">" & message)
        End Using
    End Sub
    'Dim TickNow As Boolean
    'Private Sub TimerlbShow_Tick(sender As Object, e As EventArgs) Handles TimerlbShow.Tick

    '    If TickNow = False Then

    '        lbPKGRUN.Visible = False
    '        lbPlan.Visible = False
    '        lbResult.Visible = False
    '        lbWIP.Visible = False
    '        TickNow = True
    '    Else

    '        lbPKGRUN.Visible = True
    '        lbPlan.Visible = True
    '        lbResult.Visible = True
    '        lbWIP.Visible = True
    '        TickNow = False
    '    End If

    'End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btUpdateNewPKG.Click

        ' Exit Sub

        create = False
        _TableGroupTOP3.Clear()
        Try
            Updata()

        Catch ex As Exception
            '   MsgBox("Updata :" & ex.Message.ToString)
            SaveCatchLog(ex.ToString, "Updata()")
        End Try
        Dim Str As DateTime = Date.Now
        '   Dim timee As TimeSpan
        Try
            RunTOP1()

        Catch ex As Exception
            '  MsgBox("selects :" & ex.Message.ToString)
            SaveCatchLog(ex.ToString, "RunTOP1()")
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Check_Running()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            My.Settings.Percent = CInt(CbPercentBooking.Text)
            My.Settings.Save()

            MsgBox("บันทึกสำเร็จ")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub
#Region "SQL Service"


    ' SQL service broker
    Private Const statusMessage As String =
     "{0} changes have occurred."
    Private changeCount As Integer = 0
    Private connection As SqlConnection = Nothing
    Private command1 As SqlCommand = Nothing
    Private dataToWatch1 As DataSet = Nothing
    Private Const tableName1 As String = "DailyProcessOperationRate"
    Private changeCount1 As Integer = 0
    Private Sub StratService()
        '   Me.Label2.Text = String.Format(statusMessage, changeCount)

        ' Remove any existing dependency connection, then create a new one.
        SqlDependency.Stop(GetConnectionString())
        SqlDependency.Start(GetConnectionString())

        If connection Is Nothing Then
            connection = New SqlConnection(GetConnectionString())
        End If

        If command1 Is Nothing Then
            ' GetSQL is a local procedure that returns
            ' a paramaterized SQL string. You might want
            ' to use a stored procedure in your application.
            command1 = New SqlCommand(GetSQLTest(), connection)
        End If


        If dataToWatch1 Is Nothing Then
            dataToWatch1 = New DataSet()
        End If


        GetData1(True)
    End Sub
    Private Function GetConnectionString() As String
        ' To avoid storing the connection string in your code,
        ' you can retrive it from a configuration file.
        'Return "Data Source=CLIENT-205\SQLEXPRESS;Initial Catalog=DBTest;Integrated Security=False;User ID=sa;Password=1234"
        '172.16.0.102;Initial Catalog=DBx;User ID=dbxuser
        ' Return "Data Source=172.16.0.102;Initial Catalog=DBx;User ID=sa;Password=5dcda45fc424*"
        'Return "Data Source=172.16.0.102;Initial Catalog=DBx;Persist Security Info=True;User ID=sa;Password=5dcda45fc424*"
        Return My.Settings.DBxConnectionString
        ' Return "Data Source=172.16.0.102;Initial Catalog=DBxDW;Persist Security Info=True;User ID=sa;Password=5dcda45fc424*"
    End Function
    Private Function GetSQLTest() As String
        '****** WARNING *****
        'http://www.codeproject.com/Articles/12335/Using-SqlDependency-for-data-change-events

        '    Dim frm As MonitorPassBoxMP = New MonitorPassBoxMP
        Dim MCno As String = "" ' frm.ReadTextBoxNum()
        ' Return "SELECT MCNo, LotNo, LotStartTime, LotEndTime, Material, Remark FROM dbo.PLData where   LotNo ='1739A1187V'"
        Return "SELECT MCNo, LotNo, LotStartTime, LotEndTime, Material, ABNormal, LoadCount, UnloadCount, OPNo, MagazineNo, SelfConVersion, NetVersion, InputQtyAdjust, TotalGoodAdjust, TotalNGAdjust, DummyQty, OPJudgement, Remark FROM dbo.PLData where MCNo ='" & My.Settings.MCNo & "' and LotEndTime is null" 'MCNo='MP-PB-99' DATEADD(HOUR, -1, getdate())  order by LotStartTime desc
    End Function

    Private Sub GetData1(Start As Boolean)
        ' Empty the dataset so that there is only
        ' one batch worth of data displayed.
        dataToWatch1.Clear()

        ' Make sure the command object does not already have
        ' a notification object associated with it.
        command1.Notification = Nothing

        ' Create and bind the SqlDependency object
        ' to the command object.
        Dim dependency1 As New SqlDependency(command1)
        AddHandler dependency1.OnChange, AddressOf dependency1_OnChange

        Using adapter As New SqlDataAdapter(command1)
            adapter.Fill(dataToWatch1, tableName1)
            '    Me.DataGridView2.DataSource = dataToWatch1
            '    Me.DataGridView2.DataMember = tableName1

        End Using
        ' Query
        If Start = False Then
            'load update not load start
            QueryUpdate()
        End If




    End Sub
    'Private Sub Query()

    'End Sub
    Private Sub dependency1_OnChange(ByVal sender As Object, ByVal e As SqlNotificationEventArgs)

        ' This event will occur on a thread pool thread.
        ' It is illegal to update the UI from a worker thread
        ' The following code checks to see if it is safe
        ' update the UI.
        Dim i As ISynchronizeInvoke = CType(Me, ISynchronizeInvoke)

        ' If InvokeRequired returns True, the code
        ' is executing on a worker thread.
        If i.InvokeRequired Then
            ' Create a delegate to perform the thread switch
            Dim tempDelegate As New OnChangeEventHandler(AddressOf dependency1_OnChange)

            Dim args() As Object = {sender, e}

            ' Marshal the data from the worker thread
            ' to the UI thread.
            i.BeginInvoke(tempDelegate, args)

            Return
        End If

        ' Remove the handler since it's only good
        ' for a single notification
        Dim dependency1 As SqlDependency = CType(sender, SqlDependency)

        RemoveHandler dependency1.OnChange, AddressOf dependency1_OnChange


        '  changeCount1 += 1
        '   Me.Label2.Text = String.Format(statusMessage, changeCount1)


        'With Me.ListBox2.Items
        '    .Clear()
        '    .Add("Info:   " & e.Info.ToString())
        '    .Add("Source: " & e.Source.ToString())
        '    .Add("Type:   " & e.Type.ToString())
        'End With


        If e.Type <> SqlNotificationType.Change Then
            Exit Sub
        End If

        ' Reload the dataset that's bound to the grid.
        GetData1(False)
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TimerlbShow_Tick(sender As Object, e As EventArgs) Handles TimerlbShow.Tick

    End Sub

    Private Sub TextBoxQr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxQr.KeyPress
        If ProgressBar1.Value < ProgressBar1.Maximum Then
            ProgressBar1.Value += 1
        End If

        If e.KeyChar = Chr(13) Then
            Try
                If TextBoxQr.Text.Length <> 252 Then
                    MessageBox.Show("Qr Code ไม่ถูกต้อง [" & TextBoxQr.Text.Length.ToString & "]")
                    TextBoxQr.Text = ""
                    ProgressBar1.Value = 0
                    Return
                End If
                Dim lotno As String = TextBoxQr.Text.Substring(30, 10).Trim()
                Dim result As resultBase = CheckSetupLot(lotno, My.Settings.MCNo, lbOPNo.Text)
                If Not result.IsPass Then
                    MessageDialog.MessageBoxDialog.ShowMessageDialog("CheckSetupLot", result.Reason & vbCr & result.Comment, "Stored", result.ErrorNo)
                Else
                    Dim frm As MessageDialogAccept = New MessageDialogAccept("Setup", My.Settings.MCNo, lotno)
                    frm.ShowDialog()
                End If
                TextBoxQr.Text = ""
                ProgressBar1.Value = 0
                SaveCatchLog("lotNo:" + lotno + ", MCNo:" + My.Settings.MCNo + ",opno:" + lbOPNo.Text, "CheckSetupLot")

            Catch ex As Exception
                SaveCatchLog(ex.Message.ToString, "TextBoxQr_KeyPress")
            Finally
                TextBoxQr.Focus()
            End Try

        End If
    End Sub

    Private Sub TextBoxQr_Leave(sender As Object, e As EventArgs) Handles TextBoxQr.Leave
        PanelQr.BackColor = Color.Red
    End Sub

    Private Sub PictureBoxQr_Click(sender As Object, e As EventArgs) Handles PictureBoxQr.Click
        PanelQr.BackColor = Color.LawnGreen
        ProgressBar1.Value = 0
        TextBoxQr.Text = ""
        TextBoxQr.Focus()
    End Sub
#End Region
End Class
