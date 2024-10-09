Public Class AdminEditF
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
    Friend WithEvents OnAdminID As System.Windows.Forms.TextBox
    Friend WithEvents IsGod As System.Windows.Forms.CheckBox
    Friend WithEvents MCancelMB As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ReAdminPass As System.Windows.Forms.TextBox
    Friend WithEvents AdminPass As System.Windows.Forms.TextBox
    Friend WithEvents FullName As System.Windows.Forms.TextBox
    Friend WithEvents ID As System.Windows.Forms.TextBox
    Friend WithEvents MEditMB As System.Windows.Forms.Button
    Friend WithEvents AdminID As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AdminAcc As System.Windows.Forms.GroupBox
    Friend WithEvents LimitMList As System.Windows.Forms.RadioButton
    Friend WithEvents FullMList As System.Windows.Forms.RadioButton
    Friend WithEvents Check As System.Windows.Forms.CheckBox
    Friend WithEvents HVosool As System.Windows.Forms.CheckBox
    Friend WithEvents Report As System.Windows.Forms.CheckBox
    Friend WithEvents BList As System.Windows.Forms.CheckBox
    Friend WithEvents MList As System.Windows.Forms.CheckBox
    Friend WithEvents Administrator As System.Windows.Forms.CheckBox
    Friend WithEvents God As System.Windows.Forms.CheckBox
    Friend WithEvents SG As System.Windows.Forms.CheckBox
    Friend WithEvents HBardasht As System.Windows.Forms.CheckBox
    Friend WithEvents Backup As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OnAdminID = New System.Windows.Forms.TextBox
        Me.IsGod = New System.Windows.Forms.CheckBox
        Me.MCancelMB = New System.Windows.Forms.Button
        Me.MEditMB = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ReAdminPass = New System.Windows.Forms.TextBox
        Me.AdminPass = New System.Windows.Forms.TextBox
        Me.FullName = New System.Windows.Forms.TextBox
        Me.ID = New System.Windows.Forms.TextBox
        Me.AdminID = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.AdminAcc = New System.Windows.Forms.GroupBox
        Me.LimitMList = New System.Windows.Forms.RadioButton
        Me.FullMList = New System.Windows.Forms.RadioButton
        Me.Check = New System.Windows.Forms.CheckBox
        Me.HVosool = New System.Windows.Forms.CheckBox
        Me.Report = New System.Windows.Forms.CheckBox
        Me.BList = New System.Windows.Forms.CheckBox
        Me.MList = New System.Windows.Forms.CheckBox
        Me.Administrator = New System.Windows.Forms.CheckBox
        Me.God = New System.Windows.Forms.CheckBox
        Me.SG = New System.Windows.Forms.CheckBox
        Me.HBardasht = New System.Windows.Forms.CheckBox
        Me.Backup = New System.Windows.Forms.CheckBox
        Me.AdminAcc.SuspendLayout()
        Me.SuspendLayout()
        '
        'OnAdminID
        '
        Me.OnAdminID.Location = New System.Drawing.Point(16, 456)
        Me.OnAdminID.Name = "OnAdminID"
        Me.OnAdminID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OnAdminID.Size = New System.Drawing.Size(24, 23)
        Me.OnAdminID.TabIndex = 32
        Me.OnAdminID.TabStop = False
        Me.OnAdminID.Text = ""
        Me.OnAdminID.Visible = False
        '
        'IsGod
        '
        Me.IsGod.Location = New System.Drawing.Point(0, 456)
        Me.IsGod.Name = "IsGod"
        Me.IsGod.Size = New System.Drawing.Size(16, 16)
        Me.IsGod.TabIndex = 31
        Me.IsGod.TabStop = False
        Me.IsGod.Visible = False
        '
        'MCancelMB
        '
        Me.MCancelMB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.MCancelMB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.MCancelMB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MCancelMB.Location = New System.Drawing.Point(56, 440)
        Me.MCancelMB.Name = "MCancelMB"
        Me.MCancelMB.Size = New System.Drawing.Size(96, 23)
        Me.MCancelMB.TabIndex = 6
        Me.MCancelMB.Text = "لغو"
        '
        'MEditMB
        '
        Me.MEditMB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.MEditMB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MEditMB.Location = New System.Drawing.Point(176, 440)
        Me.MEditMB.Name = "MEditMB"
        Me.MEditMB.Size = New System.Drawing.Size(96, 23)
        Me.MEditMB.TabIndex = 5
        Me.MEditMB.Text = "ذخیره تغییرات"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(208, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 24)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "تکرار کلمه عبور :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(240, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 24)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "کلمه عبور :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(192, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 24)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "نام و نام خانوادگی :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "نام کاربری :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ReAdminPass
        '
        Me.ReAdminPass.Font = New System.Drawing.Font("Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.ReAdminPass.Location = New System.Drawing.Point(24, 152)
        Me.ReAdminPass.MaxLength = 50
        Me.ReAdminPass.Name = "ReAdminPass"
        Me.ReAdminPass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.ReAdminPass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ReAdminPass.Size = New System.Drawing.Size(160, 23)
        Me.ReAdminPass.TabIndex = 3
        Me.ReAdminPass.Text = ""
        '
        'AdminPass
        '
        Me.AdminPass.Font = New System.Drawing.Font("Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.AdminPass.Location = New System.Drawing.Point(24, 120)
        Me.AdminPass.MaxLength = 50
        Me.AdminPass.Name = "AdminPass"
        Me.AdminPass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.AdminPass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AdminPass.Size = New System.Drawing.Size(160, 23)
        Me.AdminPass.TabIndex = 2
        Me.AdminPass.Text = ""
        '
        'FullName
        '
        Me.FullName.Location = New System.Drawing.Point(24, 48)
        Me.FullName.MaxLength = 25
        Me.FullName.Name = "FullName"
        Me.FullName.Size = New System.Drawing.Size(160, 23)
        Me.FullName.TabIndex = 1
        Me.FullName.Text = ""
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(40, 456)
        Me.ID.Name = "ID"
        Me.ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ID.Size = New System.Drawing.Size(24, 23)
        Me.ID.TabIndex = 33
        Me.ID.TabStop = False
        Me.ID.Text = ""
        Me.ID.Visible = False
        '
        'AdminID
        '
        Me.AdminID.BackColor = System.Drawing.Color.White
        Me.AdminID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AdminID.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.AdminID.Location = New System.Drawing.Point(24, 16)
        Me.AdminID.Name = "AdminID"
        Me.AdminID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AdminID.Size = New System.Drawing.Size(160, 24)
        Me.AdminID.TabIndex = 0
        Me.AdminID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(24, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(288, 32)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = " در صورتیکه تمایل به تغییر کلمه عبور ندارید در قسمت کلمه عبور و تکرار آن چیزی ننو" & _
        "یسید"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdminAcc
        '
        Me.AdminAcc.Controls.Add(Me.LimitMList)
        Me.AdminAcc.Controls.Add(Me.FullMList)
        Me.AdminAcc.Controls.Add(Me.Check)
        Me.AdminAcc.Controls.Add(Me.HVosool)
        Me.AdminAcc.Controls.Add(Me.Report)
        Me.AdminAcc.Controls.Add(Me.BList)
        Me.AdminAcc.Controls.Add(Me.MList)
        Me.AdminAcc.Controls.Add(Me.Administrator)
        Me.AdminAcc.Controls.Add(Me.God)
        Me.AdminAcc.Controls.Add(Me.SG)
        Me.AdminAcc.Controls.Add(Me.HBardasht)
        Me.AdminAcc.Controls.Add(Me.Backup)
        Me.AdminAcc.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AdminAcc.Location = New System.Drawing.Point(24, 184)
        Me.AdminAcc.Name = "AdminAcc"
        Me.AdminAcc.Size = New System.Drawing.Size(286, 240)
        Me.AdminAcc.TabIndex = 4
        Me.AdminAcc.TabStop = False
        Me.AdminAcc.Text = " سطح دسترسی "
        '
        'LimitMList
        '
        Me.LimitMList.Enabled = False
        Me.LimitMList.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LimitMList.Location = New System.Drawing.Point(144, 112)
        Me.LimitMList.Name = "LimitMList"
        Me.LimitMList.Size = New System.Drawing.Size(120, 24)
        Me.LimitMList.TabIndex = 4
        Me.LimitMList.Text = "دسترسی محدود"
        '
        'FullMList
        '
        Me.FullMList.Checked = True
        Me.FullMList.Enabled = False
        Me.FullMList.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.FullMList.Location = New System.Drawing.Point(144, 88)
        Me.FullMList.Name = "FullMList"
        Me.FullMList.Size = New System.Drawing.Size(120, 24)
        Me.FullMList.TabIndex = 3
        Me.FullMList.TabStop = True
        Me.FullMList.Text = "دسترسی بالا"
        '
        'Check
        '
        Me.Check.Enabled = False
        Me.Check.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Check.Location = New System.Drawing.Point(56, 176)
        Me.Check.Name = "Check"
        Me.Check.Size = New System.Drawing.Size(80, 24)
        Me.Check.TabIndex = 9
        Me.Check.Text = "چاپ چک"
        Me.Check.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'HVosool
        '
        Me.HVosool.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HVosool.Location = New System.Drawing.Point(144, 176)
        Me.HVosool.Name = "HVosool"
        Me.HVosool.Size = New System.Drawing.Size(128, 24)
        Me.HVosool.TabIndex = 8
        Me.HVosool.Text = "حسابداری - وصول"
        Me.HVosool.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'Report
        '
        Me.Report.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Report.Location = New System.Drawing.Point(8, 144)
        Me.Report.Name = "Report"
        Me.Report.Size = New System.Drawing.Size(127, 24)
        Me.Report.TabIndex = 7
        Me.Report.Text = "بخش گزارش دهی"
        Me.Report.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'BList
        '
        Me.BList.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BList.Location = New System.Drawing.Point(32, 64)
        Me.BList.Name = "BList"
        Me.BList.TabIndex = 5
        Me.BList.Text = "لیست بایگانی"
        Me.BList.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'MList
        '
        Me.MList.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MList.Location = New System.Drawing.Point(160, 64)
        Me.MList.Name = "MList"
        Me.MList.Size = New System.Drawing.Size(112, 24)
        Me.MList.TabIndex = 2
        Me.MList.Text = "لیست مشتریان"
        Me.MList.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'Administrator
        '
        Me.Administrator.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Administrator.Location = New System.Drawing.Point(32, 32)
        Me.Administrator.Name = "Administrator"
        Me.Administrator.TabIndex = 1
        Me.Administrator.Text = "بخش مدیریت"
        Me.Administrator.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'God
        '
        Me.God.Enabled = False
        Me.God.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.God.Location = New System.Drawing.Point(200, 32)
        Me.God.Name = "God"
        Me.God.Size = New System.Drawing.Size(72, 24)
        Me.God.TabIndex = 0
        Me.God.TabStop = False
        Me.God.Text = "مدیر کل"
        Me.God.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'SG
        '
        Me.SG.Enabled = False
        Me.SG.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SG.Location = New System.Drawing.Point(8, 208)
        Me.SG.Name = "SG"
        Me.SG.Size = New System.Drawing.Size(130, 24)
        Me.SG.TabIndex = 11
        Me.SG.Text = "بخش سرمایه گذاری"
        Me.SG.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'HBardasht
        '
        Me.HBardasht.Enabled = False
        Me.HBardasht.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HBardasht.Location = New System.Drawing.Point(136, 208)
        Me.HBardasht.Name = "HBardasht"
        Me.HBardasht.Size = New System.Drawing.Size(136, 24)
        Me.HBardasht.TabIndex = 10
        Me.HBardasht.Text = "حسابداری - برداشت"
        Me.HBardasht.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'Backup
        '
        Me.Backup.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Backup.Location = New System.Drawing.Point(136, 144)
        Me.Backup.Name = "Backup"
        Me.Backup.Size = New System.Drawing.Size(136, 24)
        Me.Backup.TabIndex = 6
        Me.Backup.Text = "بخش پشتیبان گیری"
        Me.Backup.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'AdminEditF
        '
        Me.AcceptButton = Me.MEditMB
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.MCancelMB
        Me.ClientSize = New System.Drawing.Size(330, 472)
        Me.Controls.Add(Me.AdminAcc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MCancelMB)
        Me.Controls.Add(Me.AdminID)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.OnAdminID)
        Me.Controls.Add(Me.IsGod)
        Me.Controls.Add(Me.MEditMB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReAdminPass)
        Me.Controls.Add(Me.AdminPass)
        Me.Controls.Add(Me.FullName)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdminEditF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ویرایش اطلاعات مدیران"
        Me.AdminAcc.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Decs"

    Dim DBConn As DBConnection
    Dim err As System.Exception
    Dim iCounter As Integer

#End Region

    Private Sub AdminEditF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DBConn = New DBConnection
            DBConn.connectMe("SELECT * FROM Administrator WHERE ID=" & ID.Text & ";")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d.Read
                    AdminID.Text = d("AdminID".ToString)
                    FullName.Text = d("FullName".ToString)
                    God.Checked = d("God".ToString)
                    Administrator.Checked = d("Administrator".ToString)
                    MList.Checked = d("MList".ToString)
                    FullMList.Checked = d("FullMList".ToString)
                    LimitMList.Checked = Not d("FullMList".ToString)
                    BList.Checked = d("BList".ToString)
                    Backup.Checked = d("Backup".ToString)
                    Report.Checked = d("Report".ToString)
                    HVosool.Checked = d("HVosool".ToString)
                    HBardasht.Checked = d("HBardasht".ToString)
                    SG.Checked = d("SG".ToString)
                Loop
                Try
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            End Try
        Catch err As System.Exception
            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
        End Try
        If IsGod.Checked = False Then AdminAcc.Enabled = False
        If God.Checked = True Then AdminAcc.Enabled = False
    End Sub

    Private Sub MEditMB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEditMB.Click
        Me.Enabled = False
        If IsNullChr("Str", FullName.Text) = False Then MsgBox("خطا در نوشتن نام کامل", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش مدیریت") : GoTo Get_Error
        If IsNullChr("Pass", AdminPass.Text, False) = False Then MsgBox("خطا در نوشتن کلمه عبور", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش مدیریت") : GoTo Get_Error
        If IsNullChr("Pass", ReAdminPass.Text, False) = False Then MsgBox("خطا در نوشتن تکرار کلمه عبور", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش مدیریت") : GoTo Get_Error
        If AdminPass.Text <> ReAdminPass.Text Then MsgBox("کلمه عبور و تکرار آن هماهنگی ندارند", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش مدیریت") : GoTo Get_Error
        Try
            DBConn = New DBConnection
            If AdminPass.Text = "" Then
                DBConn.connectMe("Update Administrator SET AdminID='" & AdminID.Text & "',FullName='" & FullName.Text & "',God=" & God.Checked & ",Administrator=" & Administrator.Checked & ",MList=" & MList.Checked & ",FullMList=" & FullMList.Checked & ",BList=" & BList.Checked & ",Backup=" & Backup.Checked & ",Report=" & Report.Checked & ",HVosool=" & HVosool.Checked & " WHERE ID=" & ID.Text & ";")
            Else
                DBConn.connectMe("Update Administrator SET AdminID='" & AdminID.Text & "',FullName='" & FullName.Text & "',AdminPass='" & EnCodePass(AdminPass.Text) & "',God=" & God.Checked & ",Administrator=" & Administrator.Checked & ",MList=" & MList.Checked & ",FullMList=" & FullMList.Checked & ",BList=" & BList.Checked & ",Backup=" & Backup.Checked & ",Report=" & Report.Checked & ",HVosool=" & HVosool.Checked & " WHERE ID=" & ID.Text & ";")
            End If
            DBConn.OLEComm.Connection = DBConn.OLEConn
            DBConn.OLEComm.ExecuteNonQuery()
            DBConn.OLEConn.Close()
            Me.Close()
        Catch err As System.Exception
            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            GoTo Get_Error
        End Try
        Exit Sub
Get_Error:
        Me.Enabled = True
    End Sub

    Private Sub MList_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MList.CheckedChanged
        BList.Checked = MList.Checked
        FullMList.Enabled = MList.Checked
        LimitMList.Enabled = MList.Checked
    End Sub

    Private Sub BList_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BList.CheckedChanged
        MList.Checked = BList.Checked
    End Sub

    Private Sub FullName_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullName.GotFocus
        LoadKeyboardLayout("00000429", 1)
    End Sub

    Private Sub AdminPass_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdminPass.GotFocus, ReAdminPass.GotFocus
        LoadKeyboardLayout("00000409", 1)
    End Sub

    Private Sub AdminEditF_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        LoadKeyboardLayout("00000409", 1)
    End Sub

    Private Sub MList_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BList.Checked = MList.Checked
    End Sub

    Private Sub BList_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MList.Checked = BList.Checked
    End Sub
End Class
