Imports System.IO
Imports System.Net

Public Class Reflow

    Private Sub LoadData()
        Dim ListPKGNotReflow As List(Of String) = New List(Of String)
        ListPKGNotReflow.Add("WSOF5")
        ListPKGNotReflow.Add("WSOF6")
        ListPKGNotReflow.Add("WSOF6I")
        ListPKGNotReflow.Add("SIP9")

        Try
            Dim MCNo01Path As String = "\\172.16.0.100\_Setup\CellController\10_PL\PL Meco Queue\Meco_Reflow\DataTableMCNo01.xml"
            If System.IO.File.Exists(MCNo01Path) = True Then
                Dim _TableMCNo01 As DBxDataSet1.PLMecoPlanGroupDataTable = New DBxDataSet1.PLMecoPlanGroupDataTable
                '_TableMCNo01.Columns.Add("Period")
                '_TableMCNo01.Columns.Add("RFWIP")
                Dim dataView01 As DataView
                _TableMCNo01.ReadXml(MCNo01Path)

                RfwipTableAdapter1.Fill(DBxDataSet11.RFWIP)
                For Each data As DataRow In _TableMCNo01
                    Dim CountRFWIP As Int16 = 0
                    For Each RFWIP As DBxDataSet1.RFWIPRow In DBxDataSet11.RFWIP
                        If data("Package") Like "*" & RFWIP.Package & "*" And Not ListPKGNotReflow.Contains(data("Package")) Then
                            CountRFWIP += 1
                        End If
                    Next
                    data("RFWIP") = CountRFWIP
                Next

                dataView01 = New DataView(_TableMCNo01) 'เรียง Data 1-n
                dataView01.Sort = "GroupPKG"

                ViewMeco1.DataSource = dataView01
                For Each column As DataGridViewColumn In ViewMeco1.Columns
                    column.SortMode = DataGridViewColumnSortMode.NotSortable
                Next

                For Each DATA As DataGridViewRow In ViewMeco1.Rows


                    If DATA.Cells(0).Value + DATA.Cells(1).Value >= DATA.Cells(4).Value Then

                        DATA.DefaultCellStyle.ForeColor = Color.Black
                        DATA.DefaultCellStyle.BackColor = Color.Yellow

                    Else
                        DATA.DefaultCellStyle.ForeColor = Color.Black
                        DATA.DefaultCellStyle.BackColor = Color.LawnGreen
                    End If
                Next



            End If
        Catch ex As Exception
            SaveCatchLog(ex.ToString, "MCNo01Path")
        End Try

        Try
            Dim MCNo02Path As String = "\\172.16.0.100\_Setup\CellController\10_PL\PL Meco Queue\Meco_Reflow\DataTableMCNo02.xml"
            If System.IO.File.Exists(MCNo02Path) = True Then
                Dim _TableMCNo02 As DBxDataSet1.PLMecoPlanGroupDataTable = New DBxDataSet1.PLMecoPlanGroupDataTable
                '_TableMCNo02.Columns.Add("Period")
                '_TableMCNo02.Columns.Add("RFWIP")
                Dim dataView02 As DataView
                _TableMCNo02.ReadXml(MCNo02Path)

                dataView02 = New DataView(_TableMCNo02) 'เรียง Data 1-n
                dataView02.Sort = "GroupPKG"

                RfwipTableAdapter1.Fill(DBxDataSet11.RFWIP)
                For Each data As DataRow In _TableMCNo02
                    Dim CountRFWIP As Int16 = 0
                    For Each RFWIP As DBxDataSet1.RFWIPRow In DBxDataSet11.RFWIP
                        If data("Package") Like "*" & RFWIP.Package & "*" And Not ListPKGNotReflow.Contains(data("Package")) Then
                            CountRFWIP += 1
                        End If
                    Next
                    data("RFWIP") = CountRFWIP
                Next

                ViewMeco2.DataSource = dataView02

                For Each column As DataGridViewColumn In ViewMeco2.Columns
                    column.SortMode = DataGridViewColumnSortMode.NotSortable
                Next

                For Each DATA As DataGridViewRow In ViewMeco2.Rows


                    If DATA.Cells(0).Value + DATA.Cells(1).Value >= DATA.Cells(4).Value Then

                        DATA.DefaultCellStyle.ForeColor = Color.Black
                        DATA.DefaultCellStyle.BackColor = Color.Yellow

                    Else
                        DATA.DefaultCellStyle.ForeColor = Color.Black
                        DATA.DefaultCellStyle.BackColor = Color.LawnGreen
                    End If
                Next


            End If

        Catch ex As Exception
            SaveCatchLog(ex.ToString, "MCNo02Path")
        End Try

        Try
            Dim MCNo03Path As String = "\\172.16.0.100\_Setup\CellController\10_PL\PL Meco Queue\Meco_Reflow\DataTableMCNo03.xml"
            If System.IO.File.Exists(MCNo03Path) = True Then
                Dim _TableMCNo03 As DBxDataSet1.PLMecoPlanGroupDataTable = New DBxDataSet1.PLMecoPlanGroupDataTable
                '_TableMCNo03.Columns.Add("Period")
                '_TableMCNo03.Columns.Add("RFWIP")
                Dim dataView03 As DataView
                _TableMCNo03.ReadXml(MCNo03Path)

                dataView03 = New DataView(_TableMCNo03) 'เรียง Data 1-n
                dataView03.Sort = "GroupPKG"

                RfwipTableAdapter1.Fill(DBxDataSet11.RFWIP)
                For Each data As DataRow In _TableMCNo03
                    Dim CountRFWIP As Int16 = 0
                    For Each RFWIP As DBxDataSet1.RFWIPRow In DBxDataSet11.RFWIP
                        If data("Package") Like "*" & RFWIP.Package & "*" And Not ListPKGNotReflow.Contains(data("Package")) Then
                            CountRFWIP += 1
                        End If
                    Next
                    data("RFWIP") = CountRFWIP
                Next

                ViewMeco3.DataSource = dataView03



                For Each column As DataGridViewColumn In ViewMeco3.Columns
                    column.SortMode = DataGridViewColumnSortMode.NotSortable
                Next

                For Each DATA As DataGridViewRow In ViewMeco3.Rows


                    If DATA.Cells(0).Value + DATA.Cells(1).Value >= DATA.Cells(4).Value Then

                        DATA.DefaultCellStyle.ForeColor = Color.Black
                        DATA.DefaultCellStyle.BackColor = Color.Yellow

                    Else
                        DATA.DefaultCellStyle.ForeColor = Color.Black
                        DATA.DefaultCellStyle.BackColor = Color.LawnGreen
                    End If
                Next

            End If
        Catch ex As Exception
            SaveCatchLog(ex.ToString, "MCNo03Path")
        End Try

        SettingColumns()
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

    Private Sub SettingColumns()

        ViewMeco1.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ViewMeco1.Columns(0).Width = 50
        ViewMeco1.Columns(1).Width = 50
        ViewMeco1.Columns(2).Width = 50
        ViewMeco1.Columns(4).Width = 50
        ViewMeco1.Columns(5).Width = 80
        ViewMeco1.Columns(6).Width = 50

        ViewMeco1.Columns(6).HeaderText = "RFW"
        ViewMeco1.Columns(4).HeaderText = "P" '/" & DayNight.Text
        ViewMeco1.Columns(1).HeaderText = "R" '/" & DayNight.Text
        ViewMeco1.Columns(0).HeaderText = "MW"
        ViewMeco1.Columns(5).DisplayIndex = 0
        ViewMeco1.Columns(3).DisplayIndex = 1
        ViewMeco1.Columns(4).DisplayIndex = 2
        ViewMeco1.Columns(1).DisplayIndex = 3
        ViewMeco1.Columns(2).Visible = False


        ViewMeco2.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ViewMeco2.Columns(0).Width = 50
        ViewMeco2.Columns(1).Width = 50
        ViewMeco2.Columns(2).Width = 50
        ViewMeco2.Columns(4).Width = 50
        ViewMeco2.Columns(5).Width = 80
        ViewMeco2.Columns(6).Width = 50

        ViewMeco2.Columns(6).HeaderText = "RFW"
        ViewMeco2.Columns(4).HeaderText = "P" '/" & DayNight.Text
        ViewMeco2.Columns(1).HeaderText = "R" '/" & DayNight.Text
        ViewMeco2.Columns(0).HeaderText = "MW"
        ViewMeco2.Columns(5).DisplayIndex = 0
        ViewMeco2.Columns(3).DisplayIndex = 1
        ViewMeco2.Columns(4).DisplayIndex = 2
        ViewMeco2.Columns(1).DisplayIndex = 3
        ViewMeco2.Columns(2).Visible = False


        ViewMeco3.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ViewMeco3.Columns(0).Width = 25
        ViewMeco3.Columns(1).Width = 25
        ViewMeco3.Columns(2).Width = 50
        ViewMeco3.Columns(4).Width = 25
        ViewMeco3.Columns(5).Width = 80
        ViewMeco3.Columns(6).Width = 25


        ViewMeco3.Columns(6).HeaderText = "RFW"
        ViewMeco3.Columns(4).HeaderText = "P" '/" & DayNight.Text
        ViewMeco3.Columns(1).HeaderText = "R" '/" & DayNight.Text
        ViewMeco3.Columns(0).HeaderText = "MW"
        ViewMeco3.Columns(5).DisplayIndex = 0
        ViewMeco3.Columns(3).DisplayIndex = 1
        ViewMeco3.Columns(4).DisplayIndex = 2
        ViewMeco3.Columns(1).DisplayIndex = 3
        ViewMeco3.Columns(2).Visible = False
    End Sub





    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles btExit.Click
        Me.Close()
        '   Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Reflow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoadData()
    End Sub


End Class
