Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Linq
Public Class MonitorPlan

    'Private MachineList As List(Of String) = New List(Of String)
    Private MachineList As List(Of Machine) = New List(Of Machine)
    Private ListPKGNotReflow As List(Of String) = New List(Of String)
    Private PathXmlMachineList As String = My.Application.Info.DirectoryPath & "\MachineList.xml"
    Private PathXmlListPKGNotReflow As String = My.Application.Info.DirectoryPath & "\ListPKGNotReflow.xml"
    Private timeUpdate As TimeSpan = New TimeSpan(0, 5, 0)
    Private Sub XmlSave(fileOb As Object, pathFile As String)
        Dim fs As FileStream = New FileStream(pathFile, FileMode.Create)
        Dim bs As New XmlSerializer(fileOb.GetType())
        bs.Serialize(fs, fileOb)
    End Sub
    Private Sub XmlLoad(ByRef fileOb As Object, pathFile As String)
        If File.Exists(pathFile) Then
            Dim fs As FileStream = New FileStream(pathFile, FileMode.Open)
            Dim bs As New XmlSerializer(fileOb.GetType())
            fileOb = bs.Deserialize(fs)
        Else
            MsgBox("Not found:" & pathFile)
        End If
    End Sub
    Private daa As New DataTable
    Private Sub MonitorPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            'For i = 1 To 4
            '    Dim mcc As New Machine
            '    mcc.MachineName = "MecoNo0" & i
            '    mcc.PahtData = "\\172.16.0.100\_Setup\CellController\10_PL\PL Meco Queue\Meco_Reflow\DataTableMCNo0" & i & ".xml"
            '    mcc.Header = "Meco#" & i & " Machine"
            '    MachineList.Add(mcc)
            'Next
            ' XmlSave(MachineList, PathXmlMachineList)
            XmlLoad(MachineList, PathXmlMachineList)
            XmlLoad(ListPKGNotReflow, PathXmlListPKGNotReflow)
            If MachineList.Count = 0 Then
                Exit Sub
            End If

            For Each McPath As Machine In MachineList
                Dim _TableMCNo As DBxDataSet1.PLMecoPlanGroupDataTable = New DBxDataSet1.PLMecoPlanGroupDataTable
                '_TableMCNo.Columns.Add("Period")
                '_TableMCNo.Columns.Add("RFWIP")
                _TableMCNo.ReadXml(McPath.PahtData)

                RfwipTableAdapter1.Fill(DBxDataSet11.RFWIP)
                For Each data As DBxDataSet1.PLMecoPlanGroupRow In _TableMCNo
                    Dim CountRFWIP As Int16 = 0
                    For Each RFWIP As DBxDataSet1.RFWIPRow In DBxDataSet11.RFWIP
                        If data.Package Like "*" & RFWIP.Package & "*" And Not ListPKGNotReflow.Contains(data.Package) Then
                            CountRFWIP += 1
                        End If
                    Next
                    data.RFWIP = CountRFWIP
                Next
                'Dim xx = (From u In _TableMCNo.AsEnumerable()
                '          Where u.Field(Of String)("Package") = "TO252" Select u).Distinct() ' 
                Dim dataTable As IEnumerable(Of DBxDataSet1.PLMecoPlanGroupRow) = (From u In _TableMCNo.AsEnumerable()
                                                                                   Order By u.Period Ascending Select u).Distinct()
                ' daa = dataTable.CopyToDataTable()
                _TableMCNo = New DBxDataSet1.PLMecoPlanGroupDataTable()
                For Each rw As DBxDataSet1.PLMecoPlanGroupRow In dataTable
                    Dim row As DBxDataSet1.PLMecoPlanGroupRow = _TableMCNo.NewRow
                    row.Package = rw.Package
                    row.DayPlan = rw.DayPlan
                    row.GroupPKG = rw.GroupPKG
                    row.Period = rw.Period
                    row.RESULT = rw.RESULT
                    row.WIP = rw.WIP
                    row.RFWIP = rw.RFWIP
                    _TableMCNo.Rows.Add(row)
                Next
                For Each item As Control In Panel2.Controls
                    If item.GetType Is GetType(UserControlViewPlan) Then
                        Dim uc As UserControlViewPlan = CType(item, UserControlViewPlan)
                        If uc.Name = McPath.MachineName Then
                            uc.MachineName = McPath.Header
                            uc.Data = _TableMCNo
                        End If
                    End If
                Next
            Next

        Catch ex As Exception
            SaveCatchLog(ex.Message.ToString(), "LoadData")
            'MsgBox(ex.Message.ToString())
        End Try
    End Sub
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
            '    File.Move(arr., DIR_LOG & "\BackUp")
        End If
        'Using sw As StreamReader = New StreamReader(Path.Combine(DIR_LOG, "Catch_" & Now.ToString("yyyyMMdd") & ".log"), True)
        '    sw.WriteLine(Now.ToString("yyyy/MM/dd HH:mm:ss.fff") & " " & fnName & ">" & message)
        'End Using

        Using sw As StreamWriter = New StreamWriter(Path.Combine(DIR_LOG, "Catch_" & Now.ToString("yyyyMMdd") & ".log"), True)
            sw.WriteLine(Now.ToString("yyyy/MM/dd HH:mm:ss.fff") & " " & fnName & ">" & message)
        End Using
    End Sub
    Private Sub TimeCountUpdate()

        If timeUpdate.TotalSeconds = 0 Then
            LoadData()
            timeUpdate = New TimeSpan(0, 5, 0)
        End If
        timeUpdate = timeUpdate - New TimeSpan(0, 0, 1)
        LabelTimeUpdate.Text = "Update  In:" & timeUpdate.ToString("mm") & ":" & timeUpdate.ToString("ss") & " min."
    End Sub
    Private Sub BtExit_Click(sender As Object, e As EventArgs) Handles btExit.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'LoadData()
        TimeCountUpdate()
    End Sub
End Class