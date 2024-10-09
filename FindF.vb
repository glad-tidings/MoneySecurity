Public Class FindF
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
    Friend WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LNFind As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents NFind As System.Windows.Forms.TextBox
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FindF))
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.LNFind = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnFind = New System.Windows.Forms.Button
        Me.txtFind = New System.Windows.Forms.TextBox
        Me.NFind = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(368, 8)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox1.TabIndex = 4
        Me.pictureBox1.TabStop = False
        '
        'LNFind
        '
        Me.LNFind.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LNFind.Location = New System.Drawing.Point(8, 64)
        Me.LNFind.Name = "LNFind"
        Me.LNFind.Size = New System.Drawing.Size(392, 16)
        Me.LNFind.TabIndex = 11
        Me.LNFind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancel.Location = New System.Drawing.Point(8, 40)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "لغو"
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.SystemColors.Control
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFind.Location = New System.Drawing.Point(8, 7)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(80, 25)
        Me.btnFind.TabIndex = 1
        Me.btnFind.Text = "جستجو"
        '
        'txtFind
        '
        Me.txtFind.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtFind.Location = New System.Drawing.Point(4, 87)
        Me.txtFind.MaxLength = 50
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(400, 23)
        Me.txtFind.TabIndex = 0
        Me.txtFind.Text = ""
        '
        'NFind
        '
        Me.NFind.Location = New System.Drawing.Point(0, 104)
        Me.NFind.Name = "NFind"
        Me.NFind.Size = New System.Drawing.Size(24, 23)
        Me.NFind.TabIndex = 12
        Me.NFind.TabStop = False
        Me.NFind.Text = ""
        Me.NFind.Visible = False
        '
        'FindF
        '
        Me.AcceptButton = Me.btnFind
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(408, 117)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.LNFind)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.NFind)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FindF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "جستجو"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Desc"
    Public OKClick As Boolean = False
#End Region

    Private Sub FindF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadKeyboardLayout("00000429", 1)
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        If IsNullChr("Str", txtFind.Text) = False Then
            Select Case NFind.Text
                Case 1
                    MsgBox("خطا در نوشتن شماره شناسایی پرونده", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "جستجو")
                Case 2
                    MsgBox("خطا در نوشتن نام و نام خانوادگی موجر", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "جستجو")
                Case 3
                    MsgBox("خطا در نوشتن نام و نام خانوادگی مستاجر", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "جستجو")
                Case 4
                    MsgBox("خطا در نوشتن شماره تلفن تماس مشتری", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "جستجو")
            End Select
            Exit Sub
        End If
        OKClick = True
        Me.Close()
    End Sub

    Private Sub FindF_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        LoadKeyboardLayout("00000409", 1)
    End Sub
End Class
