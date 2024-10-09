Public Class RegAdminF
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
    Friend WithEvents FullName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ReAdminPass As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AdminPass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CancelB As System.Windows.Forms.Button
    Friend WithEvents RegisterB As System.Windows.Forms.Button
    Friend WithEvents AdminID As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(RegAdminF))
        Me.FullName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ReAdminPass = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.AdminPass = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CancelB = New System.Windows.Forms.Button
        Me.RegisterB = New System.Windows.Forms.Button
        Me.AdminID = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FullName
        '
        Me.FullName.Location = New System.Drawing.Point(24, 144)
        Me.FullName.MaxLength = 50
        Me.FullName.Name = "FullName"
        Me.FullName.Size = New System.Drawing.Size(128, 23)
        Me.FullName.TabIndex = 1
        Me.FullName.Text = ""
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(152, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 24)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "نام و نام خانوادگی :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ReAdminPass
        '
        Me.ReAdminPass.Font = New System.Drawing.Font("Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.ReAdminPass.Location = New System.Drawing.Point(24, 208)
        Me.ReAdminPass.MaxLength = 50
        Me.ReAdminPass.Name = "ReAdminPass"
        Me.ReAdminPass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.ReAdminPass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ReAdminPass.Size = New System.Drawing.Size(128, 23)
        Me.ReAdminPass.TabIndex = 3
        Me.ReAdminPass.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(168, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 23)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "تکرار کلمه عبور :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdminPass
        '
        Me.AdminPass.Font = New System.Drawing.Font("Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.AdminPass.Location = New System.Drawing.Point(24, 176)
        Me.AdminPass.MaxLength = 50
        Me.AdminPass.Name = "AdminPass"
        Me.AdminPass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.AdminPass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AdminPass.Size = New System.Drawing.Size(128, 23)
        Me.AdminPass.TabIndex = 2
        Me.AdminPass.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(200, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "کلمه عبور :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(200, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "نام کاربری :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 96)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "تثبیت مدیر کل"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'CancelB
        '
        Me.CancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CancelB.Location = New System.Drawing.Point(64, 240)
        Me.CancelB.Name = "CancelB"
        Me.CancelB.TabIndex = 5
        Me.CancelB.Text = "لغو"
        '
        'RegisterB
        '
        Me.RegisterB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RegisterB.Location = New System.Drawing.Point(152, 240)
        Me.RegisterB.Name = "RegisterB"
        Me.RegisterB.TabIndex = 4
        Me.RegisterB.Text = "تثبیت"
        '
        'AdminID
        '
        Me.AdminID.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.AdminID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.AdminID.Location = New System.Drawing.Point(24, 112)
        Me.AdminID.MaxLength = 50
        Me.AdminID.Name = "AdminID"
        Me.AdminID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AdminID.Size = New System.Drawing.Size(128, 22)
        Me.AdminID.TabIndex = 0
        Me.AdminID.Text = ""
        '
        'RegAdminF
        '
        Me.AcceptButton = Me.RegisterB
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.CancelButton = Me.CancelB
        Me.ClientSize = New System.Drawing.Size(290, 272)
        Me.ControlBox = False
        Me.Controls.Add(Me.AdminID)
        Me.Controls.Add(Me.FullName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ReAdminPass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AdminPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CancelB)
        Me.Controls.Add(Me.RegisterB)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RegAdminF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تثبیت مدیر کل"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Decs"

    Dim DBConn As DBConnection
    Dim err As System.Exception
    Dim iCounter As Integer

#End Region

    Private Sub RegAdminF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CancelB.Enabled = False
    End Sub

    Private Sub RegisterB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterB.Click
        Me.Enabled = False
        If IsNullChr("User", AdminID.Text) = False Then MsgBox("خطا در نوشتن نام کاربری", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "تثبیت مدیر کل") : GoTo Get_Error
        If IsNullChr("Str", FullName.Text) = False Then MsgBox("خطا در نوشتن نام کامل", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "تثبیت مدیر کل") : GoTo Get_Error
        If IsNullChr("Pass", AdminPass.Text) = False Then MsgBox("خطا در نوشتن کلمه عبور", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "تثبیت مدیر کل") : GoTo Get_Error
        If IsNullChr("Pass", ReAdminPass.Text) = False Then MsgBox("خطا در نوشتن تکرار کلمه عبور", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "تثبیت مدیر کل") : GoTo Get_Error
        If AdminPass.Text <> ReAdminPass.Text Then MsgBox("کلمه عبور و تکرار آن هماهنگی ندارند", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "تثبیت مدیر کل") : GoTo Get_Error
        Try
            DBConn = New DBConnection
            DBConn.connectMe("Update Administrator SET AdminID='" & AdminID.Text & "',FullName='" & FullName.Text & "',AdminPass='" & EnCodePass(AdminPass.Text) & "',Reg=True WHERE God=True;")
            DBConn.OLEComm.Connection = DBConn.OLEConn
            DBConn.OLEComm.ExecuteNonQuery()
            DBConn.OLEConn.Close()
        Catch err As System.Exception
            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            GoTo Get_Error
        End Try
        Dim LoginForm As New LoginF
        LoginForm.Show()
        Me.Hide()
        Exit Sub
Get_Error:
        Me.Enabled = True
    End Sub

    Private Sub AdminID_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminID.GotFocus
        LoadKeyboardLayout("00000409", 1)
    End Sub

    Private Sub FullName_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullName.GotFocus
        LoadKeyboardLayout("00000429", 1)
    End Sub

    Private Sub AdminPass_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminPass.GotFocus, ReAdminPass.GotFocus
        LoadKeyboardLayout("00000409", 1)
    End Sub

    Private Sub RegAdminF_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        LoadKeyboardLayout("00000409", 1)
    End Sub
End Class
