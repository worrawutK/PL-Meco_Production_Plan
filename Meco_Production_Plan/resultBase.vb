Public Class resultBase
    Private c_IsPass As Boolean
    Public Property IsPass() As Boolean
        Get
            Return c_IsPass
        End Get
        Set(ByVal value As Boolean)
            c_IsPass = value
        End Set
    End Property
    Private c_ErrorNo As String
    Public Property ErrorNo() As String
        Get
            Return c_ErrorNo
        End Get
        Set(ByVal value As String)
            c_ErrorNo = value
        End Set
    End Property
    Private c_Reason As String
    Public Property Reason() As String
        Get
            Return c_Reason
        End Get
        Set(ByVal value As String)
            c_Reason = value
        End Set
    End Property
    Private c_Comment As String
    Public Property Comment() As String
        Get
            Return c_Comment
        End Get
        Set(ByVal value As String)
            c_Comment = value
        End Set
    End Property
End Class
