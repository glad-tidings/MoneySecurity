Public Class InputBoxF
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
    Friend WithEvents DD As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OKB As System.Windows.Forms.Button
    Friend WithEvents MM As System.Windows.Forms.TextBox
    Friend WithEvents YY As System.Windows.Forms.TextBox
    Friend WithEvents CancelB As System.Windows.Forms.Button
    Friend WithEvents TVosool As System.Windows.Forms.TextBox
    Friend WithEvents Message As System.Windows.Forms.TextBox
    Friend WithEvents HideMenu As System.Windows.Forms.ContextMenu
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DD = New System.Windows.Forms.TextBox
        Me.MM = New System.Windows.Forms.TextBox
        Me.YY = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.OKB = New System.Windows.Forms.Button
        Me.CancelB = New System.Windows.Forms.Button
        Me.TVosool = New System.Windows.Forms.TextBox
        Me.Message = New System.Windows.Forms.TextBox
        Me.HideMenu = New System.Windows.Forms.ContextMenu
        Me.SuspendLayout()
        '
        'DD
        '
        Me.DD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DD.Location = New System.Drawing.Point(184, 96)
        Me.DD.MaxLength = 2
        Me.DD.Name = "DD"
        Me.DD.Size = New System.Drawing.Size(32, 23)
        Me.DD.TabIndex = 0
        Me.DD.Text = ""
        Me.DD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MM
        '
        Me.MM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MM.Location = New System.Drawing.Point(128, 96)
        Me.MM.MaxLength = 2
        Me.MM.Name = "MM"
        Me.MM.Size = New System.Drawing.Size(32, 23)
        Me.MM.TabIndex = 1
        Me.MM.Text = ""
        Me.MM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'YY
        '
        Me.YY.ForeColor = System.Drawing.SystemColors.ControlText
        Me.YY.Location = New System.Drawing.Point(72, 96)
        Me.YY.MaxLength = 2
        Me.YY.Name = "YY"
        Me.YY.Size = New System.Drawing.Size(32, 23)
        Me.YY.TabIndex = 2
        Me.YY.Text = ""
        Me.YY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(168, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(8, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "/"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(112, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(8, 24)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "/"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OKB
        '
        Me.OKB.BackColor = System.Drawing.SystemColors.Control
        Me.OKB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OKB.Location = New System.Drawing.Point(152, 136)
        Me.OKB.Name = "OKB"
        Me.OKB.Size = New System.Drawing.Size(80, 24)
        Me.OKB.TabIndex = 3
        Me.OKB.Text = "تایید"
        '
        'CancelB
        '
        Me.CancelB.BackColor = System.Drawing.SystemColors.Control
        Me.CancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CancelB.Location = New System.Drawing.Point(56, 136)
        Me.CancelB.Name = "CancelB"
        Me.CancelB.Size = New System.Drawing.Size(80, 24)
        Me.CancelB.TabIndex = 4
        Me.CancelB.Text = "لغو"
        '
        'TVosool
        '
        Me.TVosool.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(0, Byte))
        Me.TVosool.Location = New System.Drawing.Point(0, 160)
        Me.TVosool.MaxLength = 2
        Me.TVosool.Name = "TVosool"
        Me.TVosool.Size = New System.Drawing.Size(32, 23)
        Me.TVosool.TabIndex = 8
        Me.TVosool.TabStop = False
        Me.TVosool.Text = ""
        Me.TVosool.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TVosool.Visible = False
        '
        'Message
        '
        Me.Message.BackColor = System.Drawing.SystemColors.Control
        Me.Message.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Message.ContextMenu = Me.HideMenu
        Me.Message.Cursor = System.Windows.Forms.Cursors.Default
        Me.Message.Location = New System.Drawing.Point(16, 16)
        Me.Message.Multiline = True
        Me.Message.Name = "Message"
        Me.Message.ReadOnly = True
        Me.Message.Size = New System.Drawing.Size(256, 64)
        Me.Message.TabIndex = 9
        Me.Message.TabStop = False
        Me.Message.Text = ""
        '
        'HideMenu
        '
        Me.HideMenu.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'InputBoxF
        '
        Me.AcceptButton = Me.OKB
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.CancelB
        Me.ClientSize = New System.Drawing.Size(290, 168)
        Me.Controls.Add(Me.TVosool)
        Me.Controls.Add(Me.CancelB)
        Me.Controls.Add(Me.OKB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.YY)
        Me.Controls.Add(Me.MM)
        Me.Controls.Add(Me.DD)
        Me.Controls.Add(Me.Message)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InputBoxF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub OKB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKB.Click
        If IsNullChr("Int", DD.Text) = False Then MsgBox("خطا در نوشتن تاریخ در قسمت روز", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "تغییر تاریخ") : Exit Sub
        If DD.Text < 0 Or DD.Text > 31 Then MsgBox("خطا در نوشتن تاریخ در قسمت روز", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "تغییر تاریخ") : Exit Sub
        If IsNullChr("Int", MM.Text) = False Then MsgBox("خطا در نوشتن تاریخ در قسمت ماه", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "تغییر تاریخ") : Exit Sub
        If MM.Text < 0 Or MM.Text > 12 Then MsgBox("خطا در نوشتن تاریخ در قسمت ماه", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "تغییر تاریخ") : Exit Sub
        If IsNullChr("Int", YY.Text) = False Then MsgBox("خطا در نوشتن تاریخ در قسمت سال", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "تغییر تاریخ") : Exit Sub
        If DD.TextLength = 1 Then DD.Text = "0" & DD.Text
        If MM.TextLength = 1 Then MM.Text = "0" & MM.Text
        If YY.TextLength = 1 Then YY.Text = "0" & YY.Text
        TVosool.Text = YY.Text & "/" & MM.Text & "/" & DD.Text
        Me.Close()
    End Sub

    Private Sub DD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DD.TextChanged
        If DD.TextLength = DD.MaxLength Then MM.Focus()
    End Sub

    Private Sub MM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MM.TextChanged
        If MM.TextLength = MM.MaxLength Then YY.Focus()
    End Sub

    Private Sub InputBoxF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadKeyboardLayout("00000429", 1)
        DD.Text = Microsoft.VisualBasic.Right(TVosool.Text, 2)
        MM.Text = Mid(TVosool.Text, 4, 2)
        YY.Text = Microsoft.VisualBasic.Left(TVosool.Text, 2)
    End Sub

    Private Sub Message_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Message.MouseDown
        DD.Focus()
    End Sub
End Class
