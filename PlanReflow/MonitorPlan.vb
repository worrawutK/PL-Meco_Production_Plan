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
            For i = 1 To 5
                Dim mcc As New Machine
                mcc.MachineName = "MecoNo0" & i
                mcc.PahtData = "\\172.16.0.115\MachineData\PL\Plan\Meco_Reflow\DataTableMCNo0" & i & ".xml"
                mcc.Header = "Meco#" & i & " Machine"
                MachineList.Add(mcc)
            Next

            If (Not File.Exists(PathXmlMachineList)) Then
                'Frist Install need XmlSave
                XmlSave(MachineList, PathXmlMachineList)
                XmlSave(ListPKGNotReflow, PathXmlListPKGNotReflow)
            End If
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

                Dim reflowWipData = GetReflowWIP(0)

                'RfwipTableAdapter1.Fill(DBxDataSet11.RFWIP)
                For Each data As DBxDataSet1.PLMecoPlanGroupRow In _TableMCNo
                    Dim CountRFWIP As Int16 = 0
                    'For Each RFWIP As DBxDataSet1.RFWIPRow In DBxDataSet11.RFWIP
                    '    If data.Package Like "*" & RFWIP.Package & "*" And Not ListPKGNotReflow.Contains(data.Package) Then
                    '        CountRFWIP += 1
                    '    End If
                    'Next
                    For Each RFWIP1 In reflowWipData
                        If data.Package Like "*" & RFWIP1.Package & "*" And Not ListPKGNotReflow.Contains(data.Package) Then
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
    Private c_ReflowData As New List(Of ReflowData)
    Private Function GetReflowWIP(jobId As Integer) As List(Of ReflowData)
        Dim dataTable As New DataTable

        Using cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection("Data Source = 172.16.0.102; Initial Catalog = StoredProcedureDB; Persist Security Info = True; User ID = system; Password = 'p@$$w0rd'")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[atom].[sp_get_user_main]"
            cmd.Parameters.Add("@process", SqlDbType.VarChar).Value = "RF"
            cmd.Parameters.Add("@wip_state", SqlDbType.Int).Value = 20
            'cmd.Parameters.Add("@process_state", SqlDbType.Int).Value = "Abnormal WIP Wait"
            cmd.Connection.Open()
            Using reader As SqlClient.SqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    dataTable.Load(reader)
                    '                    DataRow row = tmpDataTable.Rows[0];
                    '                    ret = (bool)row["enabled"];
                End If

            End Using
            cmd.Connection.Close()
        End Using
        Dim reflowData As New List(Of ReflowData)
        For Each lotdatas As DataRow In dataTable.Rows
            Dim lotdata As New ReflowData
            lotdata.LotNo = CType(lotdatas("lot_no"), String).Trim
            lotdata.JobName = CType(lotdatas("operation"), String).Trim
            lotdata.Package = CType(lotdatas("package"), String).Trim
            lotdata.Device = CType(lotdatas("device"), String).Trim

            Dim _lotState As New LotState?
            Select Case lotdatas("process_state").ToString().ToUpper().Trim()
                Case "WAIT"
                    _lotState = LotState.WIP
                Case "ABNORMAL WIP"
                    _lotState = LotState.AbnormalWIP
                Case "PROCESSING"
                    _lotState = LotState.Processing
            End Select

            Dim _lotQualityState As New LotQualityState?
            Select Case lotdatas("quality_state").ToString().ToUpper().Trim()
                Case "NORMAL"
                    _lotQualityState = LotQualityState.Normal
                Case "HOLD"
                    _lotQualityState = LotQualityState.Hold
                Case "SPECIAL FLOW"
                    _lotQualityState = LotQualityState.SpecialFlow
            End Select

            lotdata.ProcessState = _lotState
            lotdata.QualityState = _lotQualityState
            reflowData.Add(lotdata)
        Next


        'Using (SqlCommand cmd = New SqlCommand())
        '        {
        '            cmd.Connection = New SqlConnection("Data Source = 172.16.0.102; Initial Catalog = StoredProcedureDB; Persist Security Info = True; User ID = system; Password = 'p@$$w0rd'");
        '            cmd.CommandType = CommandType.StoredProcedure;
        '            cmd.CommandText = "[cellcon].[sp_get_frame_control]";
        '            cmd.Parameters.Add("@job", SqlDbType.VarChar).Value = jobName;
        '            cmd.Connection.Open();
        '            Using (SqlDataReader rd = cmd.ExecuteReader())
        '            {
        '                If (rd.HasRows) Then
        '                                    {
        '                    tmpDataTable.Load(rd);
        '                    DataRow row = tmpDataTable.Rows[0];
        '                    ret = (bool)row["enabled"];
        '                }
        '            }
        '            cmd.Connection.Close();
        '        }
        Return reflowData
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