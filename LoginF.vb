Public Class LoginF
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LoginB As System.Windows.Forms.Button
    Friend WithEvents CancelB As System.Windows.Forms.Button
    Friend WithEvents AdminPass As System.Windows.Forms.TextBox
    Friend WithEvents AdminID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(LoginF))
        Me.LoginB = New System.Windows.Forms.Button
        Me.CancelB = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.AdminPass = New System.Windows.Forms.TextBox
        Me.AdminID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoginB
        '
        Me.LoginB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LoginB.Location = New System.Drawing.Point(136, 184)
        Me.LoginB.Name = "LoginB"
        Me.LoginB.TabIndex = 2
        Me.LoginB.Text = "ورود"
        '
        'CancelB
        '
        Me.CancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CancelB.Location = New System.Drawing.Point(48, 184)
        Me.CancelB.Name = "CancelB"
        Me.CancelB.TabIndex = 3
        Me.CancelB.Text = "لغو"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 96)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ورود به برنامه"
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
        'AdminPass
        '
        Me.AdminPass.Font = New System.Drawing.Font("Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.AdminPass.Location = New System.Drawing.Point(24, 144)
        Me.AdminPass.MaxLength = 50
        Me.AdminPass.Name = "AdminPass"
        Me.AdminPass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.AdminPass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AdminPass.Size = New System.Drawing.Size(128, 23)
        Me.AdminPass.TabIndex = 1
        Me.AdminPass.Text = ""
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
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(168, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "کلمه عبور :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(168, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "نام کاربری :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LoginF
        '
        Me.AcceptButton = Me.LoginB
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.CancelB
        Me.ClientSize = New System.Drawing.Size(258, 216)
        Me.Controls.Add(Me.AdminPass)
        Me.Controls.Add(Me.AdminID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CancelB)
        Me.Controls.Add(Me.LoginB)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Decs"

    Dim DBConn As DBConnection
    Dim err As System.Exception
    Dim iCounter As Integer
    Dim Exist As Boolean = False

#End Region

    Private Sub LoginB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginB.Click
        If IsNullChr("User", AdminID.Text) = False Then GoTo Get_Error
        If IsNullChr("Pass", AdminPass.Text) = False Then GoTo Get_Error
        Try
            DBConn = New DBConnection
            DBConn.connectMe("SELECT * FROM Administrator;")
            For iCounter = 0 To DBConn.getData("AdminID").Count - 1
                If DBConn.dataReturned.Item(iCounter) = AdminID.Text Then Exist = True : Exit For
            Next
            Try
                DBConn.OLEConn.Close()
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                GoTo Get_Error
            End Try
        Catch err As System.Exception
            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
        End Try
        If Exist = False Then GoTo Get_Error
        Try
            DBConn = New DBConnection
            DBConn.connectMe("SELECT * FROM Administrator WHERE AdminID='" & AdminID.Text & "';")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d.Read
                    If d("AdminPass".ToString) = EnCodePass(AdminPass.Text) Then
                        If d("Active".ToString) = False Then
                            MessageBox("شناسه کاربری شما توسط مدیر کل غیر فعال شده است.", MsgBoxStyle.OKOnly, "ورود به برنامه")
                            AdminID.Text = ""
                            AdminPass.Text = ""
                            AdminID.Focus()
                            Exit Sub
                        End If
                        'Dim MainForm As New Main
                        With MainForm
                            .IsGod.Checked = d("God".ToString)
                            .OnAdminID.Text = d("AdminID".ToString)
                            .UserLogin.Text = "  " & d("FullName".ToString) & " "
                            .UserLogin.ToolTipText = "کاربر آنلاین : " & d("FullName".ToString)
                            .FullMList.Checked = d("FullMList".ToString)
                            .DeleteB.Enabled = .FullMList.Checked
                            .EditB.Enabled = .FullMList.Checked
                            If d("God".ToString) = True Then .AdminAcc.Text = "  مدیر کل" Else .AdminAcc.Text = "  مدیر"
                            If d("Administrator".ToString) = True Then .AdminEn.Text = " فعال " Else .AdminEn.Text = " غیر فعال " : .BMT.Enabled = False : .BMTMenu.Enabled = False
                            If d("MList".ToString) = True Then .MoshtariEn.Text = " فعال " Else .MoshtariEn.Text = " غیر فعال " : .LMT.Enabled = False : .LMTMenu.Enabled = False : .FindMenu.Enabled = False
                            If d("BList".ToString) = True Then .ArchiveEn.Text = " فعال " Else .ArchiveEn.Text = " غیر فعال " : .LBT.Enabled = False : .LBTMenu.Enabled = False
                            If d("Backup".ToString) = True Then .BackupEn.Text = " فعال " Else .BackupEn.Text = " غیر فعال " : .BPGT.Enabled = False : .BPGTMenu.Enabled = False
                            If d("Report".ToString) = True Then .ReportEn.Text = " فعال " Else .ReportEn.Text = " غیر فعال " : .BGDT.Enabled = False : .BGDTMenu.Enabled = False
                            If d("HVosool".ToString) = True Then .VHesabEn.Text = " فعال " Else .VHesabEn.Text = " غیر فعال " : .VHT.Enabled = False : .VHTMenu.Enabled = False : .HVRMenu.Enabled = False
                            If d("HBardasht".ToString) = True Then .BHesabEn.Text = " فعال " Else .BHesabEn.Text = " غیر فعال " : .BHT.Enabled = False : .BHTMenu.Enabled = False : .HBRMenu.Enabled = False
                            If d("SG".ToString) = True Then .SGEn.Text = " فعال " Else .SGEn.Text = " غیر فعال " : .BSGT.Enabled = False : .SGTMenu.Enabled = False
                            .Show()
                        End With
                        Me.Hide()
                    Else
                        GoTo Get_Error
                    End If
                Loop
                Try
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    GoTo Get_Error
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                GoTo Get_Error
            End Try
        Catch err As System.Exception
            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            GoTo Get_Error
        End Try
        Exit Sub
Get_Error:
        MessageBox("نام کاربری یا کلمه عبور اشتباه وارد شده", MsgBoxStyle.OKOnly, "ورود به برنامه")
        AdminID.Text = ""
        AdminPass.Text = ""
        AdminID.Focus()
    End Sub

    Private Sub CancelB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelB.Click
        Me.Close()
    End Sub

    Private Sub LoginF_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        End
    End Sub

    Private Sub AdminID_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdminID.GotFocus, AdminPass.GotFocus
        LoadKeyboardLayout("00000409", 1)
    End Sub
End Class
