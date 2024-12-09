Module ModuleAdo
    Public Function CheckSetupLot(lotNo As String, machine As String, opno As String) As resultBase
        Dim result As resultBase = New resultBase()
        Dim is_pass As Integer = 0
        Dim message As String = ""
        Dim errorNo As String = "00"
        Dim comment As String = ""
        Using cmd As New SqlClient.SqlCommand()
            cmd.Connection = New SqlClient.SqlConnection("Data Source = 172.16.0.102; Initial Catalog = StoredProcedureDB; Persist Security Info = True; User ID = system; Password = 'p@$$w0rd'")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[cellcon].[sp_get_result_lotsetup]"
            cmd.Parameters.Add("@mcno", SqlDbType.VarChar).Value = machine
            cmd.Parameters.Add("@lotno", SqlDbType.VarChar).Value = lotNo
            cmd.Parameters.Add("@opno", SqlDbType.VarChar).Value = opno
            cmd.Parameters.Add("@carrierno", SqlDbType.VarChar).Value = "-"
            cmd.Connection.Open()
            Using rd = cmd.ExecuteReader()
                While (rd.Read())
                    is_pass = CType(rd("is_pass"), Integer)
                    message = CType(rd("message"), String)
                    errorNo = CType(rd("code"), String)
                    comment = CType(rd("comment"), String)
                End While
            End Using
            cmd.Connection.Close()
        End Using
        If is_pass = 1 Then
            result.IsPass = True
        Else
            result.IsPass = False
            result.Reason = message
            result.ErrorNo = errorNo
            result.Comment = comment
        End If
        Return result
    End Function
    Public Function GetWIPData() As List(Of LotData)

        Dim tb_Data As DataTable = New DataTable
        Dim dataList As List(Of LotData) = New List(Of LotData)
        Try
            Using cmd As New SqlClient.SqlCommand()
                cmd.Connection = New SqlClient.SqlConnection("Data Source = 172.16.0.102; Initial Catalog = StoredProcedureDB; Persist Security Info = True; User ID = system; Password = 'p@$$w0rd'")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "[cellcon].[sp_get_job_wip]"
                cmd.Parameters.Add("@job_name", SqlDbType.VarChar).Value = "PL"
                cmd.Connection.Open()
                Dim result = cmd.ExecuteReader()
                tb_Data.Load(result)
                cmd.Connection.Close()
            End Using

            For Each data As DataRow In tb_Data.Rows
                Dim lotdata As LotData = New LotData()
                lotdata.LotNo = CType(data("lot_no"), String)
                lotdata.Package = CType(data("package_name"), String)
                lotdata.Device = CType(data("device_name"), String)
                lotdata.FlowName = CType(data("job_name"), String)
                lotdata.ProcessState = CType(data("state"), String)
                'lotdata.QualityState = CType(data("LotNo"), String)
                lotdata.IsSpecialFlow = CType(data("is_special_flow"), Integer)
                'lotdata.Priority = CType(data("Priority"), Integer)
                'lotdata.Delay = CType(data("Delay"), String)
                'lotdata.PackageGroup = CType(data("PackageGroup"), String)
                'lotdata.ProcessName = CType(data("ProcessName"), String)
                dataList.Add(lotdata)
            Next
        Catch ex As Exception

        End Try

        Return dataList
    End Function
End Module
