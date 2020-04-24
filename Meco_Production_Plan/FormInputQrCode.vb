Public Class FormInputQrCode
    Private c_InputType As InputType
    Private c_QrCode As String
    Public Property QrCode() As String
        Get
            Return c_QrCode
        End Get
        Set(ByVal value As String)
            'c_QrCode = value
        End Set
    End Property
    Sub New(inputType As InputType)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        c_InputType = inputType
        Select Case inputType
            Case InputType.Slip252
                LabelHeader.Text = "Please Input Lot Slip"
                LabelHeader.BackColor = Color.DarkOrange
            Case InputType.Carrier
                LabelHeader.Text = "Please Input Load Carrier"
                LabelHeader.BackColor = Color.LawnGreen
                ProgressBar1.Maximum = CType(inputType, Int16)
        End Select
    End Sub

    Private Sub FormInputQrCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Enum InputType
        Slip252 = 252
        Carrier = 11
    End Enum

    Private Sub TextBoxQr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxQr.KeyPress
        Try
            If ProgressBar1.Value < ProgressBar1.Maximum Then
                ProgressBar1.Value += 1
            End If

            If e.KeyChar = Chr(13) Then
                If TextBoxQr.Text.Length <> CType(c_InputType, Int32) Then
                    MessageBox.Show("Qr Code ไม่ถูกต้อง [" & TextBoxQr.Text.Length.ToString & "]")
                    TextBoxQr.Text = ""
                    ProgressBar1.Value = 0
                    Return
                End If
                c_QrCode = TextBoxQr.Text
                Me.DialogResult = DialogResult.OK
            End If
        Catch ex As Exception

        Finally

        End Try

    End Sub
End Class