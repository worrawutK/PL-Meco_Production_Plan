<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageDialogAccept
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.labelErrorNo = New System.Windows.Forms.Label()
        Me.labelAlarmTitle = New System.Windows.Forms.Label()
        Me.pictureBoxTitelBar = New System.Windows.Forms.PictureBox()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.pictureBoxDismiss = New System.Windows.Forms.PictureBox()
        Me.LabelDetail = New System.Windows.Forms.Label()
        Me.panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.pictureBoxTitelBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.panel3.SuspendLayout()
        CType(Me.pictureBoxDismiss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel4
        '
        Me.panel4.BackColor = System.Drawing.Color.Transparent
        Me.panel4.Controls.Add(Me.LabelDetail)
        Me.panel4.Controls.Add(Me.PictureBox1)
        Me.panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel4.Location = New System.Drawing.Point(0, 93)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(498, 237)
        Me.panel4.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Meco_Production_Plan.My.Resources.Resources.PictureBoxStickerYeah
        Me.PictureBox1.Location = New System.Drawing.Point(157, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 177)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.labelErrorNo)
        Me.panel2.Controls.Add(Me.labelAlarmTitle)
        Me.panel2.Controls.Add(Me.pictureBoxTitelBar)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(498, 93)
        Me.panel2.TabIndex = 12
        '
        'labelErrorNo
        '
        Me.labelErrorNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelErrorNo.BackColor = System.Drawing.Color.Transparent
        Me.labelErrorNo.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelErrorNo.ForeColor = System.Drawing.Color.White
        Me.labelErrorNo.Location = New System.Drawing.Point(492, 30)
        Me.labelErrorNo.Name = "labelErrorNo"
        Me.labelErrorNo.Size = New System.Drawing.Size(0, 27)
        Me.labelErrorNo.TabIndex = 4
        Me.labelErrorNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labelAlarmTitle
        '
        Me.labelAlarmTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.labelAlarmTitle.AutoSize = True
        Me.labelAlarmTitle.BackColor = System.Drawing.Color.Transparent
        Me.labelAlarmTitle.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAlarmTitle.ForeColor = System.Drawing.Color.White
        Me.labelAlarmTitle.Location = New System.Drawing.Point(95, 30)
        Me.labelAlarmTitle.Name = "labelAlarmTitle"
        Me.labelAlarmTitle.Size = New System.Drawing.Size(285, 29)
        Me.labelAlarmTitle.TabIndex = 0
        Me.labelAlarmTitle.Text = "ALARM INFORMATION"
        '
        'pictureBoxTitelBar
        '
        Me.pictureBoxTitelBar.BackColor = System.Drawing.Color.Transparent
        Me.pictureBoxTitelBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBoxTitelBar.Image = Global.Meco_Production_Plan.My.Resources.Resources.Greenbar
        Me.pictureBoxTitelBar.Location = New System.Drawing.Point(0, 0)
        Me.pictureBoxTitelBar.Name = "pictureBoxTitelBar"
        Me.pictureBoxTitelBar.Size = New System.Drawing.Size(498, 93)
        Me.pictureBoxTitelBar.TabIndex = 0
        Me.pictureBoxTitelBar.TabStop = False
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.Menu
        Me.panel1.Controls.Add(Me.panel4)
        Me.panel1.Controls.Add(Me.panel2)
        Me.panel1.Controls.Add(Me.panel3)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(498, 389)
        Me.panel1.TabIndex = 3
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.Transparent
        Me.panel3.Controls.Add(Me.pictureBoxDismiss)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel3.Location = New System.Drawing.Point(0, 330)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(498, 59)
        Me.panel3.TabIndex = 11
        '
        'pictureBoxDismiss
        '
        Me.pictureBoxDismiss.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBoxDismiss.Image = Global.Meco_Production_Plan.My.Resources.Resources.btnGreenOK
        Me.pictureBoxDismiss.Location = New System.Drawing.Point(384, 5)
        Me.pictureBoxDismiss.Name = "pictureBoxDismiss"
        Me.pictureBoxDismiss.Size = New System.Drawing.Size(102, 51)
        Me.pictureBoxDismiss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBoxDismiss.TabIndex = 4
        Me.pictureBoxDismiss.TabStop = False
        '
        'LabelDetail
        '
        Me.LabelDetail.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDetail.Location = New System.Drawing.Point(0, 0)
        Me.LabelDetail.Name = "LabelDetail"
        Me.LabelDetail.Size = New System.Drawing.Size(498, 51)
        Me.LabelDetail.TabIndex = 1
        Me.LabelDetail.Text = "-"
        Me.LabelDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MessageDialogAccept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 389)
        Me.Controls.Add(Me.panel1)
        Me.Name = "MessageDialogAccept"
        Me.Text = "MessageDialogAccept"
        Me.panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.pictureBoxTitelBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel3.ResumeLayout(False)
        CType(Me.pictureBoxDismiss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pictureBoxTitelBar As PictureBox
    Protected WithEvents panel4 As Panel
    Private WithEvents panel2 As Panel
    Private WithEvents labelErrorNo As Label
    Private WithEvents labelAlarmTitle As Label
    Private WithEvents panel1 As Panel
    Private WithEvents panel3 As Panel
    Private WithEvents pictureBoxDismiss As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelDetail As Label
End Class
