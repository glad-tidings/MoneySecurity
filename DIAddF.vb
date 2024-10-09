Public Class DIAddF
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CancelB As System.Windows.Forms.Button
    Friend WithEvents AddB As System.Windows.Forms.Button
    Friend WithEvents Writer As System.Windows.Forms.Label
    Friend WithEvents Subject As System.Windows.Forms.TextBox
    Friend WithEvents WriteDate As System.Windows.Forms.Label
    Friend WithEvents Message As System.Windows.Forms.TextBox
    Friend WithEvents AdminID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DD As System.Windows.Forms.TextBox
    Friend WithEvents MM As System.Windows.Forms.TextBox
    Friend WithEvents YY As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents HO As System.Windows.Forms.NumericUpDown
    Friend WithEvents MIN As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Users As System.Windows.Forms.CheckedListBox
    Friend WithEvents ClearAll As System.Windows.Forms.LinkLabel
    Friend WithEvents CheckAll As System.Windows.Forms.LinkLabel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents AlarmCheck As System.Windows.Forms.CheckBox
    Friend WithEvents AlarmGroup As System.Windows.Forms.GroupBox
    Friend WithEvents PrimCheck As System.Windows.Forms.CheckBox
    Friend WithEvents PrimGroup As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Writer = New System.Windows.Forms.Label
        Me.Subject = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.WriteDate = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Message = New System.Windows.Forms.TextBox
        Me.CancelB = New System.Windows.Forms.Button
        Me.AddB = New System.Windows.Forms.Button
        Me.AdminID = New System.Windows.Forms.TextBox
        Me.AlarmGroup = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.MIN = New System.Windows.Forms.NumericUpDown
        Me.HO = New System.Windows.Forms.NumericUpDown
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.YY = New System.Windows.Forms.TextBox
        Me.MM = New System.Windows.Forms.TextBox
        Me.DD = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.AlarmCheck = New System.Windows.Forms.CheckBox
        Me.PrimCheck = New System.Windows.Forms.CheckBox
        Me.PrimGroup = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.ClearAll = New System.Windows.Forms.LinkLabel
        Me.CheckAll = New System.Windows.Forms.LinkLabel
        Me.Users = New System.Windows.Forms.CheckedListBox
        Me.AlarmGroup.SuspendLayout()
        CType(Me.MIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PrimGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(472, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "نویسنده :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Writer
        '
        Me.Writer.BackColor = System.Drawing.Color.White
        Me.Writer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Writer.Location = New System.Drawing.Point(320, 16)
        Me.Writer.Name = "Writer"
        Me.Writer.Size = New System.Drawing.Size(152, 23)
        Me.Writer.TabIndex = 3
        Me.Writer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Subject
        '
        Me.Subject.Location = New System.Drawing.Point(16, 80)
        Me.Subject.MaxLength = 0
        Me.Subject.Name = "Subject"
        Me.Subject.Size = New System.Drawing.Size(456, 23)
        Me.Subject.TabIndex = 0
        Me.Subject.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(496, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "تاریخ :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'WriteDate
        '
        Me.WriteDate.BackColor = System.Drawing.Color.White
        Me.WriteDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WriteDate.Location = New System.Drawing.Point(320, 48)
        Me.WriteDate.Name = "WriteDate"
        Me.WriteDate.Size = New System.Drawing.Size(152, 24)
        Me.WriteDate.TabIndex = 6
        Me.WriteDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(480, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 24)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "موضوع :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(496, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 24)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "متن :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Message
        '
        Me.Message.Location = New System.Drawing.Point(16, 112)
        Me.Message.MaxLength = 0
        Me.Message.Multiline = True
        Me.Message.Name = "Message"
        Me.Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Message.Size = New System.Drawing.Size(456, 168)
        Me.Message.TabIndex = 1
        Me.Message.Text = ""
        '
        'CancelB
        '
        Me.CancelB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.CancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CancelB.Location = New System.Drawing.Point(168, 448)
        Me.CancelB.Name = "CancelB"
        Me.CancelB.Size = New System.Drawing.Size(96, 23)
        Me.CancelB.TabIndex = 9
        Me.CancelB.Text = "لغو"
        '
        'AddB
        '
        Me.AddB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.AddB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AddB.Location = New System.Drawing.Point(280, 448)
        Me.AddB.Name = "AddB"
        Me.AddB.Size = New System.Drawing.Size(96, 23)
        Me.AddB.TabIndex = 8
        Me.AddB.Text = "اضافه کردن"
        '
        'AdminID
        '
        Me.AdminID.Location = New System.Drawing.Point(0, 464)
        Me.AdminID.Name = "AdminID"
        Me.AdminID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AdminID.Size = New System.Drawing.Size(32, 23)
        Me.AdminID.TabIndex = 10
        Me.AdminID.TabStop = False
        Me.AdminID.Text = ""
        Me.AdminID.Visible = False
        '
        'AlarmGroup
        '
        Me.AlarmGroup.Controls.Add(Me.Label14)
        Me.AlarmGroup.Controls.Add(Me.Label13)
        Me.AlarmGroup.Controls.Add(Me.Label12)
        Me.AlarmGroup.Controls.Add(Me.Label11)
        Me.AlarmGroup.Controls.Add(Me.Label10)
        Me.AlarmGroup.Controls.Add(Me.Label9)
        Me.AlarmGroup.Controls.Add(Me.MIN)
        Me.AlarmGroup.Controls.Add(Me.HO)
        Me.AlarmGroup.Controls.Add(Me.Label8)
        Me.AlarmGroup.Controls.Add(Me.Label7)
        Me.AlarmGroup.Controls.Add(Me.Label4)
        Me.AlarmGroup.Controls.Add(Me.YY)
        Me.AlarmGroup.Controls.Add(Me.MM)
        Me.AlarmGroup.Controls.Add(Me.DD)
        Me.AlarmGroup.Controls.Add(Me.Label2)
        Me.AlarmGroup.Enabled = False
        Me.AlarmGroup.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AlarmGroup.Location = New System.Drawing.Point(16, 288)
        Me.AlarmGroup.Name = "AlarmGroup"
        Me.AlarmGroup.Size = New System.Drawing.Size(256, 144)
        Me.AlarmGroup.TabIndex = 11
        Me.AlarmGroup.TabStop = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label14.Location = New System.Drawing.Point(136, 88)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 16)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "دقیقه"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label13.Location = New System.Drawing.Point(72, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 16)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "ساعت"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 16)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "سال"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.Location = New System.Drawing.Point(80, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 16)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "ماه"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.Location = New System.Drawing.Point(144, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "روز"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.Location = New System.Drawing.Point(128, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(8, 24)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = ":"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MIN
        '
        Me.MIN.BackColor = System.Drawing.Color.White
        Me.MIN.Location = New System.Drawing.Point(80, 112)
        Me.MIN.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.MIN.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MIN.Name = "MIN"
        Me.MIN.ReadOnly = True
        Me.MIN.Size = New System.Drawing.Size(40, 23)
        Me.MIN.TabIndex = 6
        Me.MIN.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'HO
        '
        Me.HO.BackColor = System.Drawing.Color.White
        Me.HO.Location = New System.Drawing.Point(144, 112)
        Me.HO.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.HO.Name = "HO"
        Me.HO.ReadOnly = True
        Me.HO.Size = New System.Drawing.Size(40, 23)
        Me.HO.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(184, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 24)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "ساعت :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(64, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(8, 24)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "/"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(8, 24)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "/"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'YY
        '
        Me.YY.Location = New System.Drawing.Point(16, 56)
        Me.YY.MaxLength = 2
        Me.YY.Name = "YY"
        Me.YY.Size = New System.Drawing.Size(40, 23)
        Me.YY.TabIndex = 4
        Me.YY.Text = ""
        Me.YY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MM
        '
        Me.MM.Location = New System.Drawing.Point(80, 56)
        Me.MM.MaxLength = 2
        Me.MM.Name = "MM"
        Me.MM.Size = New System.Drawing.Size(40, 23)
        Me.MM.TabIndex = 3
        Me.MM.Text = ""
        Me.MM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DD
        '
        Me.DD.Location = New System.Drawing.Point(144, 56)
        Me.DD.MaxLength = 2
        Me.DD.Name = "DD"
        Me.DD.Size = New System.Drawing.Size(40, 23)
        Me.DD.TabIndex = 2
        Me.DD.Text = ""
        Me.DD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "تاریخ :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AlarmCheck
        '
        Me.AlarmCheck.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AlarmCheck.Location = New System.Drawing.Point(152, 288)
        Me.AlarmCheck.Name = "AlarmCheck"
        Me.AlarmCheck.TabIndex = 12
        Me.AlarmCheck.Text = "هشدار دهنده"
        Me.AlarmCheck.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PrimCheck
        '
        Me.PrimCheck.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.PrimCheck.Location = New System.Drawing.Point(400, 288)
        Me.PrimCheck.Name = "PrimCheck"
        Me.PrimCheck.Size = New System.Drawing.Size(120, 24)
        Me.PrimCheck.TabIndex = 14
        Me.PrimCheck.Text = "سطح دسترسی"
        Me.PrimCheck.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PrimGroup
        '
        Me.PrimGroup.Controls.Add(Me.Label15)
        Me.PrimGroup.Controls.Add(Me.ClearAll)
        Me.PrimGroup.Controls.Add(Me.CheckAll)
        Me.PrimGroup.Controls.Add(Me.Users)
        Me.PrimGroup.Enabled = False
        Me.PrimGroup.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.PrimGroup.Location = New System.Drawing.Point(288, 288)
        Me.PrimGroup.Name = "PrimGroup"
        Me.PrimGroup.Size = New System.Drawing.Size(240, 144)
        Me.PrimGroup.TabIndex = 13
        Me.PrimGroup.TabStop = False
        '
        'Label15
        '
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(128, 112)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(8, 23)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "|"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ClearAll
        '
        Me.ClearAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ClearAll.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.ClearAll.Location = New System.Drawing.Point(16, 112)
        Me.ClearAll.Name = "ClearAll"
        Me.ClearAll.Size = New System.Drawing.Size(112, 24)
        Me.ClearAll.TabIndex = 4
        Me.ClearAll.TabStop = True
        Me.ClearAll.Text = "غیر فعال کردن همه"
        Me.ClearAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckAll
        '
        Me.CheckAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckAll.ForeColor = System.Drawing.Color.Blue
        Me.CheckAll.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.CheckAll.Location = New System.Drawing.Point(136, 112)
        Me.CheckAll.Name = "CheckAll"
        Me.CheckAll.Size = New System.Drawing.Size(90, 24)
        Me.CheckAll.TabIndex = 3
        Me.CheckAll.TabStop = True
        Me.CheckAll.Text = "فعال کردن همه"
        Me.CheckAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckAll.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'Users
        '
        Me.Users.CheckOnClick = True
        Me.Users.Location = New System.Drawing.Point(16, 32)
        Me.Users.Name = "Users"
        Me.Users.Size = New System.Drawing.Size(208, 76)
        Me.Users.Sorted = True
        Me.Users.TabIndex = 1
        '
        'DIAddF
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.CancelB
        Me.ClientSize = New System.Drawing.Size(546, 480)
        Me.Controls.Add(Me.PrimCheck)
        Me.Controls.Add(Me.PrimGroup)
        Me.Controls.Add(Me.AlarmCheck)
        Me.Controls.Add(Me.AlarmGroup)
        Me.Controls.Add(Me.AdminID)
        Me.Controls.Add(Me.CancelB)
        Me.Controls.Add(Me.AddB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Message)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.WriteDate)
        Me.Controls.Add(Me.Subject)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Writer)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DIAddF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نوشتن یاداشت جدید"
        Me.AlarmGroup.ResumeLayout(False)
        CType(Me.MIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PrimGroup.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Decs"

    Dim DBConn As DBConnection
    Dim err As System.Exception
    Dim iCounter As Integer

#End Region

    Private Sub DIAddF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadKeyboardLayout("00000429", 1)
        WriteDate.Text = Shamsi()
        Try
            DBConn = New DBConnection
            DBConn.connectMe("SELECT * FROM Administrator;")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d.Read
                    If d("AdminID".ToString) = AdminID.Text Then
                        Writer.Text = d("FullName".ToString)
                    Else
                        Users.Items.Add(d("FullName".ToString))
                    End If
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
    End Sub

    Private Sub AddB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddB.Click
        Me.Enabled = False
        Dim DBMessage As String
        Dim DBPrem As String
        Dim TChCo As Integer
        Dim FChCo As Integer
        If IsNullChr("Str", Subject.Text) = False Then MsgBox("خطا در نوشتن موضوع پیغام", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "دفتر یاداشت") : GoTo Get_Error
        If Message.Text = "" Then MsgBox("لطفا پیغام را بنویسید.", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "دفتر یاداشت") : GoTo Get_Error
        If AlarmCheck.Checked = True And DD.TextLength = 1 Then DD.Text = "0" & DD.Text
        If AlarmCheck.Checked = True And MM.TextLength = 1 Then MM.Text = "0" & MM.Text
        If AlarmCheck.Checked = True And IsNullChr("Int", DD.TextLength) = False Then MsgBox("خطا در نوشتن تاریخ", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "دفتر یاداشت") : GoTo Get_Error
        If AlarmCheck.Checked = True And IsNullChr("Int", MM.TextLength) = False Then MsgBox("خطا در نوشتن تاریخ", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "دفتر یاداشت") : GoTo Get_Error
        If AlarmCheck.Checked = True And IsNullChr("Int", YY.TextLength) = False Then MsgBox("خطا در نوشتن تاریخ", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "دفتر یاداشت") : GoTo Get_Error
        If PrimCheck.Checked = True Then
            If Users.CheckedItems.Count = Users.Items.Count And Users.Items.Count <> 0 And Users.Items.Count <> 1 Then
                DBPrem = "All"
            ElseIf Users.CheckedItems.Count = 0 Then
                DBPrem = "Clear"
            Else
                DBPrem = Users.CheckedItems.Item(0)
            End If
        Else
            DBPrem = "All"
        End If
        If AlarmCheck.Checked = True Then
            DBMessage = "Insert Into NoteBook (AdminID,Writer,WriteDate,Subject,Message,Alarm,AlarmDate,AlarmTime,Prem) Values ('" & AdminID.Text & "', '" & Writer.Text & "', '" & WriteDate.Text & "', '" & Subject.Text & "', '" & Message.Text & "', " & True & ", '" & YY.Text & "/" & MM.Text & "/" & DD.Text & "', '" & MIN.Text & ":" & HO.Text & "', '" & DBPrem & "');"
        Else
            DBMessage = "Insert Into NoteBook (AdminID,Writer,WriteDate,Subject,Message,Alarm,Prem) Values ('" & AdminID.Text & "', '" & Writer.Text & "', '" & WriteDate.Text & "', '" & Subject.Text & "', '" & Message.Text & "', " & False & ", '" & DBPrem & "');"
        End If
        Try
            DBConn = New DBConnection
            DBConn.connectMe(DBMessage)
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                DBConn.OLEComm.ExecuteNonQuery()
                DBConn.OLEConn.Close()
                Me.Close()
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                GoTo Get_Error
            End Try
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
        Exit Sub
Get_Error:
        Me.Enabled = True
    End Sub

    Private Sub DIAddF_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        LoadKeyboardLayout("00000409", 1)
    End Sub

    Private Sub AlarmCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlarmCheck.CheckedChanged
        AlarmGroup.Enabled = AlarmCheck.Checked
    End Sub

    Private Sub DD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DD.TextChanged
        If DD.TextLength = DD.MaxLength Then MM.Focus()
    End Sub

    Private Sub MM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MM.TextChanged
        If MM.TextLength = MM.MaxLength Then YY.Focus()
    End Sub

    Private Sub CheckAll_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CheckAll.LinkClicked
        For I As Integer = 0 To Users.Items.Count - 1
            Users.SetItemChecked(I, True)
        Next
    End Sub

    Private Sub ClearAll_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ClearAll.LinkClicked
        For I As Integer = 0 To Users.Items.Count - 1
            Users.SetItemChecked(I, False)
        Next
    End Sub

    Private Sub Users_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Users.SelectedIndexChanged
        For I As Integer = 0 To Users.Items.Count - 1
            Users.SetItemChecked(I, False)
        Next
        Users.SetItemChecked(Users.SelectedIndex, False)
    End Sub

    Private Sub PrimCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrimCheck.CheckedChanged
        PrimGroup.Enabled = PrimCheck.Checked
    End Sub
End Class
