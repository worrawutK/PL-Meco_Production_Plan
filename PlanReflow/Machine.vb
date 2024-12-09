Public Class Machine
    Private c_MachineName As String
    Public Property MachineName() As String
        Get
            Return c_MachineName
        End Get
        Set(ByVal value As String)
            c_MachineName = value
        End Set
    End Property
    Private c_PahtData As String
    Public Property PahtData() As String
        Get
            Return c_PahtData
        End Get
        Set(ByVal value As String)
            c_PahtData = value
        End Set
    End Property
    Private c_Header As String
    Public Property Header() As String
        Get
            Return c_Header
        End Get
        Set(ByVal value As String)
            c_Header = value
        End Set
    End Property
End Class
