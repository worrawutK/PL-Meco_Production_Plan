Public Class LotData
    Private c_LotNo As String
    Public Property LotNo() As String
        Get
            Return c_LotNo
        End Get
        Set(ByVal value As String)
            c_LotNo = value
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

    Private c_FlowName As String
    Public Property FlowName() As String
        Get
            Return c_FlowName
        End Get
        Set(ByVal value As String)
            c_FlowName = value
        End Set
    End Property
    'Private c_QualityState As String
    'Public Property QualityState() As String
    '    Get
    '        Return c_QualityState
    '    End Get
    '    Set(ByVal value As String)
    '        c_QualityState = value
    '    End Set
    'End Property
    Private c_ProcessState As String
    Public Property ProcessState() As String
        Get
            Return c_ProcessState
        End Get
        Set(ByVal value As String)
            c_ProcessState = value
        End Set
    End Property
    Private c_IsSpecialFlow As Integer
    Public Property IsSpecialFlow() As Integer
        Get
            Return c_IsSpecialFlow
        End Get
        Set(ByVal value As Integer)
            c_IsSpecialFlow = value
        End Set
    End Property
    'Private c_Delay As String
    'Public Property Delay() As String
    '    Get
    '        Return c_Delay
    '    End Get
    '    Set(ByVal value As String)
    '        c_Delay = value
    '    End Set
    'End Property
    'Private c_PackageGroup As String
    'Public Property PackageGroup() As String
    '    Get
    '        Return c_PackageGroup
    '    End Get
    '    Set(ByVal value As String)
    '        c_PackageGroup = value
    '    End Set
    'End Property
    'Private c_ProcessName As String
    'Public Property ProcessName() As String
    '    Get
    '        Return c_ProcessName
    '    End Get
    '    Set(ByVal value As String)
    '        c_ProcessName = value
    '    End Set
    'End Property
    'Private c_Priority As Integer
    'Public Property Priority() As Integer
    '    Get
    '        Return c_Priority
    '    End Get
    '    Set(ByVal value As Integer)
    '        c_Priority = value
    '    End Set
    'End Property
End Class
