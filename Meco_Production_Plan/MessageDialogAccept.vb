Public Class MessageDialogAccept

    Sub New(title As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        labelAlarmTitle.Text = title

    End Sub
    Private Sub MessageDialogAccept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pictureBoxTitelBar.Image = Resources.Greenbar
        'pictureBoxDismiss.Image = Rohm.Common.CellController.Properties.Resources.btnGreenOK
    End Sub
End Class