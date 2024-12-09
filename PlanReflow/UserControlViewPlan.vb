Public Class UserControlViewPlan
    'Sub New(dataTable As DataTable)

    '    ' This call is required by the designer.
    '    InitializeComponent()
    '    ' Add any initialization after the InitializeComponent() call.
    '    c_DataBinding.DataSource = dataTable
    'End Sub
    Private c_Machine As Machine
    Public Property Machine() As Machine
        Get
            Return c_Machine
        End Get
        Set(ByVal value As Machine)
            c_Machine = value
        End Set
    End Property
    Private Sub UserControlViewPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'DataGridView1.DataSource = Data
    End Sub
    Private Sub ControlDataGridView(dataView As DataGridView)
        dataView.Columns("Period").DisplayIndex = 0
        dataView.Columns("Package").DisplayIndex = 1
        dataView.Columns("DayPlan").DisplayIndex = 2
        dataView.Columns("RESULT").DisplayIndex = 3
        dataView.Columns("WIP").DisplayIndex = 4
        dataView.Columns("RFWIP").DisplayIndex = 5
        'dataView.ColumnHeadersDefaultCellStyle.BackColor = Color.Red
        For Each row As DataGridViewRow In dataView.Rows
            If row.Cells("RESULT").Value + row.Cells("WIP").Value >= row.Cells("DayPlan").Value Then
                row.DefaultCellStyle.BackColor = Color.Yellow
            Else
                row.DefaultCellStyle.BackColor = Color.LawnGreen
            End If

        Next
    End Sub
    Private c_Data As New DBxDataSet1.PLMecoPlanGroupDataTable
    Public Property Data() As DBxDataSet1.PLMecoPlanGroupDataTable
        Get
            Return c_Data
        End Get
        Set(ByVal value As DBxDataSet1.PLMecoPlanGroupDataTable)
            c_Data = value
            If Not value Is Nothing Then
                DataGridView1.DataSource = value
                DataGridView1.ClearSelection()
                ControlDataGridView(DataGridView1)
            End If

        End Set
    End Property
    Private c_MachineName As String
    Public Property MachineName() As String
        Get
            Return c_MachineName
        End Get
        Set(ByVal value As String)
            c_MachineName = value
            If value Is Nothing Then
                'Label1.Text = "Meco#00 Machine"
            Else
                Label1.Text = value
            End If
        End Set
    End Property

End Class
