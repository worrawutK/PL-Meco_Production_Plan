Module ModuleAdo
    Public Function CheckSetupLot(lotNo As String, machine As String, carrierNo As String, opno As String) As resultBase
        Dim result As resultBase = New resultBase()
        Dim is_pass As Integer = 0
        Dim message As String = ""
        Dim errorNo As String = "00"
        Using cmd As New SqlClient.SqlCommand()
            cmd.Connection = New SqlClient.SqlConnection("Data Source = 172.16.0.102; Initial Catalog = StoredProcedureDB; Persist Security Info = True; User ID = system; Password = 'p@$$w0rd'")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "[cellcon].[sp_get_result_lotsetup]"
            cmd.Parameters.Add("@mcno", SqlDbType.VarChar).Value = machine
            cmd.Parameters.Add("@lotno", SqlDbType.VarChar).Value = lotNo
            cmd.Parameters.Add("@opno", SqlDbType.VarChar).Value = opno
            cmd.Parameters.Add("@carrierno", SqlDbType.VarChar).Value = carrierNo
            cmd.Connection.Open()
            Using rd = cmd.ExecuteReader()
                While (rd.Read())
                    is_pass = CType(rd("is_pass"), Integer)
                    message = CType(rd("message"), String)
                    errorNo = CType(rd("code"), String)
                End While
            End Using
        End Using
        If is_pass = 1 Then
            result.IsPass = True
        Else
            result.IsPass = False
            result.Reason = message
            result.ErrorNo = errorNo
        End If
        Return result
    End Function
End Module
