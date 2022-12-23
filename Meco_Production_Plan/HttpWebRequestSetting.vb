Friend Class HttpWebRequestSetting
    Private c_Url As String
    Public Property Url() As String
        Get
            Return c_Url
        End Get
        Set(ByVal value As String)
            c_Url = value
        End Set
    End Property
    Private c_UserName As String
    Public Property UserName() As String
        Get
            Return c_UserName
        End Get
        Set(ByVal value As String)
            c_UserName = value
        End Set
    End Property
    Private c_Password As String
    Public Property Password() As String
        Get
            Return c_Password
        End Get
        Set(ByVal value As String)
            c_Password = value
        End Set
    End Property
End Class
