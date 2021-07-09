Public Class ReflowData
    Private c_LotNo As String
    Public Property LotNo() As String
        Get
            Return c_LotNo
        End Get
        Set(ByVal value As String)
            c_LotNo = value
        End Set
    End Property
    Private c_JobName As String
    Public Property JobName() As String
        Get
            Return c_JobName
        End Get
        Set(ByVal value As String)
            c_JobName = value
        End Set
    End Property
    Private c_Package As String
    Public Property Package() As String
        Get
            Return c_Package
        End Get
        Set(ByVal value As String)
            c_Package = value
        End Set
    End Property
    Private c_Device As String
    Public Property Device() As String
        Get
            Return c_Device
        End Get
        Set(ByVal value As String)
            c_Device = value
        End Set
    End Property
    Private c_ProcessState As LotState?
    Public Property ProcessState() As LotState?
        Get
            Return c_ProcessState
        End Get
        Set(ByVal value As LotState?)
            c_ProcessState = value
        End Set
    End Property
    Private c_QualityState As LotQualityState?
    Public Property QualityState() As LotQualityState?
        Get
            Return c_QualityState
        End Get
        Set(ByVal value As LotQualityState?)
            c_QualityState = value
        End Set
    End Property

End Class
Public Enum LotState
    WIP
    AbnormalWIP
    Setup
    Processing
    AbnormalStart

End Enum
Public Enum LotQualityState
    Normal
    Hold
    SpecialFlow
End Enum