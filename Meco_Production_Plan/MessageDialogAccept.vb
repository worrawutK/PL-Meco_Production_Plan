Public Class MessageDialogAccept
    Private c_McNo As String
    Private c_LotNo As String
    Sub New(title As String, mc As String, lotno As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        labelAlarmTitle.Text = title
        c_McNo = mc
        c_LotNo = lotno
    End Sub
    Private Sub MessageDialogAccept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pictureBoxTitelBar.Image = Resources.Greenbar
        'pictureBoxDismiss.Image = Rohm.Common.CellController.Properties.Resources.btnGreenOK
        labelAlarmTitle.Parent = pictureBoxTitelBar
        LabelDetail.Text = "กรุณา Input LotNo " & c_LotNo & vbCrLf & "  ที่เครื่อง " & c_McNo & " ได้เลยครับ"
    End Sub
End Class