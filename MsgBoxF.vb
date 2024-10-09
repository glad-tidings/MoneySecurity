Public Class MsgBoxF
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents NoB As System.Windows.Forms.Button
    Friend WithEvents YesB As System.Windows.Forms.Button
    Friend WithEvents OKB As System.Windows.Forms.Button
    Friend WithEvents MessageL As System.Windows.Forms.Label
    Friend WithEvents ExitIcon As System.Windows.Forms.PictureBox
    Friend WithEvents MsgIcon As System.Windows.Forms.PictureBox
    Friend WithEvents ExitFIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents CriticalIcon As System.Windows.Forms.PictureBox
    Friend WithEvents CriticalFIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents PrinterIcon As System.Windows.Forms.PictureBox
    Friend WithEvents PrinterFIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents SuccessIcon As System.Windows.Forms.PictureBox
    Friend WithEvents FaildIcon As System.Windows.Forms.PictureBox
    Friend WithEvents SuccessFIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents FaildFIcon As System.Windows.Forms.NotifyIcon
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MsgBoxF))
        Me.NoB = New System.Windows.Forms.Button
        Me.YesB = New System.Windows.Forms.Button
        Me.MessageL = New System.Windows.Forms.Label
        Me.OKB = New System.Windows.Forms.Button
        Me.ExitIcon = New System.Windows.Forms.PictureBox
        Me.MsgIcon = New System.Windows.Forms.PictureBox
        Me.CriticalIcon = New System.Windows.Forms.PictureBox
        Me.CriticalFIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ExitFIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PrinterFIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PrinterIcon = New System.Windows.Forms.PictureBox
        Me.SuccessIcon = New System.Windows.Forms.PictureBox
        Me.FaildIcon = New System.Windows.Forms.PictureBox
        Me.SuccessFIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.FaildFIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'NoB
        '
        Me.NoB.BackColor = System.Drawing.SystemColors.Control
        Me.NoB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.NoB.Image = CType(resources.GetObject("NoB.Image"), System.Drawing.Image)
        Me.NoB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NoB.Location = New System.Drawing.Point(80, 40)
        Me.NoB.Name = "NoB"
        Me.NoB.Size = New System.Drawing.Size(72, 23)
        Me.NoB.TabIndex = 1
        Me.NoB.Text = "خیر"
        Me.NoB.Visible = False
        '
        'YesB
        '
        Me.YesB.BackColor = System.Drawing.SystemColors.Control
        Me.YesB.Image = CType(resources.GetObject("YesB.Image"), System.Drawing.Image)
        Me.YesB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.YesB.Location = New System.Drawing.Point(176, 40)
        Me.YesB.Name = "YesB"
        Me.YesB.Size = New System.Drawing.Size(72, 23)
        Me.YesB.TabIndex = 0
        Me.YesB.Text = "بله"
        Me.YesB.Visible = False
        '
        'MessageL
        '
        Me.MessageL.AutoSize = True
        Me.MessageL.Location = New System.Drawing.Point(8, 8)
        Me.MessageL.Name = "MessageL"
        Me.MessageL.Size = New System.Drawing.Size(0, 19)
        Me.MessageL.TabIndex = 2
        '
        'OKB
        '
        Me.OKB.BackColor = System.Drawing.SystemColors.Control
        Me.OKB.Location = New System.Drawing.Point(128, 40)
        Me.OKB.Name = "OKB"
        Me.OKB.Size = New System.Drawing.Size(72, 23)
        Me.OKB.TabIndex = 0
        Me.OKB.Text = "تایید"
        Me.OKB.Visible = False
        '
        'ExitIcon
        '
        Me.ExitIcon.Image = CType(resources.GetObject("ExitIcon.Image"), System.Drawing.Image)
        Me.ExitIcon.Location = New System.Drawing.Point(0, 56)
        Me.ExitIcon.Name = "ExitIcon"
        Me.ExitIcon.Size = New System.Drawing.Size(54, 61)
        Me.ExitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ExitIcon.TabIndex = 3
        Me.ExitIcon.TabStop = False
        Me.ExitIcon.Visible = False
        '
        'MsgIcon
        '
        Me.MsgIcon.Location = New System.Drawing.Point(272, 0)
        Me.MsgIcon.Name = "MsgIcon"
        Me.MsgIcon.Size = New System.Drawing.Size(56, 56)
        Me.MsgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MsgIcon.TabIndex = 4
        Me.MsgIcon.TabStop = False
        Me.MsgIcon.Visible = False
        '
        'CriticalIcon
        '
        Me.CriticalIcon.Image = CType(resources.GetObject("CriticalIcon.Image"), System.Drawing.Image)
        Me.CriticalIcon.Location = New System.Drawing.Point(32, 56)
        Me.CriticalIcon.Name = "CriticalIcon"
        Me.CriticalIcon.Size = New System.Drawing.Size(44, 46)
        Me.CriticalIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CriticalIcon.TabIndex = 5
        Me.CriticalIcon.TabStop = False
        Me.CriticalIcon.Visible = False
        '
        'CriticalFIcon
        '
        Me.CriticalFIcon.Icon = CType(resources.GetObject("CriticalFIcon.Icon"), System.Drawing.Icon)
        Me.CriticalFIcon.Text = ""
        '
        'ExitFIcon
        '
        Me.ExitFIcon.Icon = CType(resources.GetObject("ExitFIcon.Icon"), System.Drawing.Icon)
        Me.ExitFIcon.Text = ""
        '
        'PrinterFIcon
        '
        Me.PrinterFIcon.Icon = CType(resources.GetObject("PrinterFIcon.Icon"), System.Drawing.Icon)
        Me.PrinterFIcon.Text = ""
        '
        'PrinterIcon
        '
        Me.PrinterIcon.Image = CType(resources.GetObject("PrinterIcon.Image"), System.Drawing.Image)
        Me.PrinterIcon.Location = New System.Drawing.Point(48, 56)
        Me.PrinterIcon.Name = "PrinterIcon"
        Me.PrinterIcon.Size = New System.Drawing.Size(54, 61)
        Me.PrinterIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PrinterIcon.TabIndex = 6
        Me.PrinterIcon.TabStop = False
        Me.PrinterIcon.Visible = False
        '
        'SuccessIcon
        '
        Me.SuccessIcon.Image = CType(resources.GetObject("SuccessIcon.Image"), System.Drawing.Image)
        Me.SuccessIcon.Location = New System.Drawing.Point(88, 56)
        Me.SuccessIcon.Name = "SuccessIcon"
        Me.SuccessIcon.Size = New System.Drawing.Size(54, 61)
        Me.SuccessIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SuccessIcon.TabIndex = 7
        Me.SuccessIcon.TabStop = False
        Me.SuccessIcon.Visible = False
        '
        'FaildIcon
        '
        Me.FaildIcon.Image = CType(resources.GetObject("FaildIcon.Image"), System.Drawing.Image)
        Me.FaildIcon.Location = New System.Drawing.Point(136, 56)
        Me.FaildIcon.Name = "FaildIcon"
        Me.FaildIcon.Size = New System.Drawing.Size(54, 61)
        Me.FaildIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FaildIcon.TabIndex = 8
        Me.FaildIcon.TabStop = False
        Me.FaildIcon.Visible = False
        '
        'SuccessFIcon
        '
        Me.SuccessFIcon.Icon = CType(resources.GetObject("SuccessFIcon.Icon"), System.Drawing.Icon)
        Me.SuccessFIcon.Text = ""
        '
        'FaildFIcon
        '
        Me.FaildFIcon.Icon = CType(resources.GetObject("FaildFIcon.Icon"), System.Drawing.Icon)
        Me.FaildFIcon.Text = ""
        '
        'MsgBoxF
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(330, 72)
        Me.Controls.Add(Me.OKB)
        Me.Controls.Add(Me.MessageL)
        Me.Controls.Add(Me.YesB)
        Me.Controls.Add(Me.NoB)
        Me.Controls.Add(Me.ExitIcon)
        Me.Controls.Add(Me.MsgIcon)
        Me.Controls.Add(Me.CriticalIcon)
        Me.Controls.Add(Me.PrinterIcon)
        Me.Controls.Add(Me.SuccessIcon)
        Me.Controls.Add(Me.FaildIcon)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MsgBoxF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub YesB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YesB.Click
        VBKeyC = True
        Me.Close()
    End Sub

    Private Sub NoB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoB.Click
        VBKeyC = False
        Me.Close()
    End Sub

    Public Sub MessageBox_Setting(ByVal Title As String, ByVal Message As String, ByVal Style As MsgBoxStyle)
        MessageL.Text = Message
        Me.Text = Title
        Me.Width = MessageL.Width + 24
        If Me.Width < 190 Then Me.Width = 190
        Select Case Style
            Case MsgBoxStyle.YesNo
                Me.Icon = Nothing
                YesB.Visible = True
                NoB.Visible = True
                OKB.Visible = False
                NoB.Left = (Me.Width / 2) - 88
                YesB.Left = NoB.Left + 96
                Me.ControlBox = False
                Me.AcceptButton = YesB
                Me.CancelButton = NoB
            Case MsgBoxStyle.OKOnly
                Me.Icon = CriticalFIcon.Icon
                Beep()
                Me.Width = Me.Width + 50
                MsgIcon.Visible = True
                MsgIcon.Image = CriticalIcon.Image
                MsgIcon.Left = Me.Width - 64
                YesB.Visible = False
                NoB.Visible = False
                OKB.Visible = True
                OKB.Left = (Me.Width / 2) - (OKB.Width / 2)
                Me.AcceptButton = OKB
            Case MsgBoxStyle.Exclamation
                Me.Icon = SuccessFIcon.Icon
                Beep()
                Me.Width = Me.Width + 50
                MsgIcon.Visible = True
                MsgIcon.Image = SuccessIcon.Image
                MsgIcon.Left = Me.Width - 64
                YesB.Visible = False
                NoB.Visible = False
                OKB.Visible = True
                OKB.Left = (Me.Width / 2) - (OKB.Width / 2)
                Me.AcceptButton = OKB
            Case MsgBoxStyle.Information
                Me.Icon = FaildFIcon.Icon
                Beep()
                Me.Width = Me.Width + 50
                MsgIcon.Visible = True
                MsgIcon.Image = FaildIcon.Image
                MsgIcon.Left = Me.Width - 64
                YesB.Visible = False
                NoB.Visible = False
                OKB.Visible = True
                OKB.Left = (Me.Width / 2) - (OKB.Width / 2)
                Me.AcceptButton = OKB
            Case MsgBoxStyle.YesNoCancel
                Me.Icon = ExitFIcon.Icon
                Me.Height = 120
                Me.Width = Me.Width + 50
                YesB.Top = 56
                NoB.Top = 56
                MsgIcon.Visible = True
                MsgIcon.Image = ExitIcon.Image
                MsgIcon.Left = Me.Width - 64
                MessageL.Top = 16
                YesB.Visible = True
                NoB.Visible = True
                OKB.Visible = False
                NoB.Left = (Me.Width / 2) - 88
                YesB.Left = NoB.Left + 96
                Me.ControlBox = False
                Me.AcceptButton = YesB
                Me.CancelButton = NoB
            Case MsgBoxStyle.SystemModal
                Me.Icon = PrinterFIcon.Icon
                Me.Height = 120
                Me.Width = Me.Width + 50
                YesB.Top = 56
                NoB.Top = 56
                MsgIcon.Visible = True
                MsgIcon.Image = PrinterIcon.Image
                MsgIcon.Left = Me.Width - 64
                MessageL.Top = 16
                YesB.Visible = True
                NoB.Visible = True
                OKB.Visible = False
                NoB.Left = (Me.Width / 2) - 88
                YesB.Left = NoB.Left + 96
                Me.ControlBox = False
                Me.AcceptButton = YesB
                Me.CancelButton = NoB
        End Select
    End Sub

    Private Sub OKB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKB.Click
        Me.Close()
    End Sub
End Class
