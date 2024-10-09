Public Class HVAddF
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ChangeB As System.Windows.Forms.Button
    Friend WithEvents Mostajer As System.Windows.Forms.TextBox
    Friend WithEvents Moajer As System.Windows.Forms.TextBox
    Friend WithEvents SHParvandeNum As System.Windows.Forms.TextBox
    Friend WithEvents MablagheVosool As System.Windows.Forms.TextBox
    Friend WithEvents TarikheVosool As System.Windows.Forms.Label
    Friend WithEvents CancelB As System.Windows.Forms.Button
    Friend WithEvents AddB As System.Windows.Forms.Button
    Friend WithEvents Tell As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Mostajer = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Moajer = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SHParvandeNum = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Tell = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.MablagheVosool = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ChangeB = New System.Windows.Forms.Button
        Me.TarikheVosool = New System.Windows.Forms.Label
        Me.CancelB = New System.Windows.Forms.Button
        Me.AddB = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Mostajer
        '
        Me.Mostajer.Location = New System.Drawing.Point(64, 16)
        Me.Mostajer.MaxLength = 50
        Me.Mostajer.Name = "Mostajer"
        Me.Mostajer.Size = New System.Drawing.Size(120, 23)
        Me.Mostajer.TabIndex = 0
        Me.Mostajer.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "مستاجر :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Moajer
        '
        Me.Moajer.Location = New System.Drawing.Point(64, 48)
        Me.Moajer.MaxLength = 50
        Me.Moajer.Name = "Moajer"
        Me.Moajer.Size = New System.Drawing.Size(120, 23)
        Me.Moajer.TabIndex = 1
        Me.Moajer.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(240, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "موجر :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SHParvandeNum
        '
        Me.SHParvandeNum.Location = New System.Drawing.Point(64, 80)
        Me.SHParvandeNum.MaxLength = 50
        Me.SHParvandeNum.Name = "SHParvandeNum"
        Me.SHParvandeNum.Size = New System.Drawing.Size(120, 23)
        Me.SHParvandeNum.TabIndex = 2
        Me.SHParvandeNum.Text = ""
        Me.SHParvandeNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(200, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "شماره پرونده :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tell
        '
        Me.Tell.Location = New System.Drawing.Point(64, 112)
        Me.Tell.MaxLength = 11
        Me.Tell.Name = "Tell"
        Me.Tell.Size = New System.Drawing.Size(120, 23)
        Me.Tell.TabIndex = 3
        Me.Tell.Text = ""
        Me.Tell.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(208, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "تلفن تماس :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MablagheVosool
        '
        Me.MablagheVosool.Location = New System.Drawing.Point(64, 144)
        Me.MablagheVosool.MaxLength = 50
        Me.MablagheVosool.Name = "MablagheVosool"
        Me.MablagheVosool.Size = New System.Drawing.Size(120, 23)
        Me.MablagheVosool.TabIndex = 4
        Me.MablagheVosool.Text = ""
        Me.MablagheVosool.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(216, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "مبلغ وصول :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(208, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "تاریخ وصول :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ChangeB
        '
        Me.ChangeB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.ChangeB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ChangeB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChangeB.Location = New System.Drawing.Point(16, 176)
        Me.ChangeB.Name = "ChangeB"
        Me.ChangeB.Size = New System.Drawing.Size(40, 20)
        Me.ChangeB.TabIndex = 5
        Me.ChangeB.Text = "تغییر"
        '
        'TarikheVosool
        '
        Me.TarikheVosool.BackColor = System.Drawing.Color.White
        Me.TarikheVosool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TarikheVosool.Location = New System.Drawing.Point(64, 176)
        Me.TarikheVosool.Name = "TarikheVosool"
        Me.TarikheVosool.Size = New System.Drawing.Size(120, 23)
        Me.TarikheVosool.TabIndex = 13
        Me.TarikheVosool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CancelB
        '
        Me.CancelB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.CancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CancelB.Location = New System.Drawing.Point(48, 216)
        Me.CancelB.Name = "CancelB"
        Me.CancelB.Size = New System.Drawing.Size(96, 23)
        Me.CancelB.TabIndex = 7
        Me.CancelB.Text = "لغو"
        '
        'AddB
        '
        Me.AddB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.AddB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AddB.Location = New System.Drawing.Point(160, 216)
        Me.AddB.Name = "AddB"
        Me.AddB.Size = New System.Drawing.Size(96, 23)
        Me.AddB.TabIndex = 6
        Me.AddB.Text = "وصول"
        '
        'HVAddF
        '
        Me.AcceptButton = Me.AddB
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.CancelB
        Me.ClientSize = New System.Drawing.Size(306, 248)
        Me.Controls.Add(Me.CancelB)
        Me.Controls.Add(Me.AddB)
        Me.Controls.Add(Me.ChangeB)
        Me.Controls.Add(Me.TarikheVosool)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MablagheVosool)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Tell)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SHParvandeNum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Moajer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Mostajer)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HVAddF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.Text = "وصول"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Decs"

    Dim DBConn As DBConnection
    Dim err As System.Exception
    Dim iCounter As Integer

#End Region

    Private Sub ChangeB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeB.Click
        Dim InputBoxForm As New InputBoxF
        InputBoxForm.TVosool.Text = TarikheVosool.Text
        InputBoxForm.Message.Text = "لطفا در صورت اشتباه بودن تاریخ وصول درج شده توسط برنامه تاریخ وصول صحیح را وارد کنید."
        InputBoxForm.ShowDialog()
        TarikheVosool.Text = InputBoxForm.TVosool.Text
    End Sub

    Private Sub AddB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddB.Click
        Me.Enabled = False
        If IsNullChr("Str", Mostajer.Text) = False Then MsgBox("خطا در نوشتن نام و نانم خانوادگی مستاجر", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "حسابداری - وصول") : GoTo Get_Error
        If IsNullChr("Str", Moajer.Text) = False Then MsgBox("خطا در نوشتن نام و نانم خانوادگی موجر", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "حسابداری - وصول") : GoTo Get_Error
        If IsNullChr("Int", SHParvandeNum.Text, False) = False Then MsgBox("خطا در نوشتن شماره پرونده", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "حسابداری - وصول") : GoTo Get_Error
        If IsNullChr("Int", Tell.Text) = False Then MsgBox("خطا در نوشتن شماره تلفن تماس", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "حسابداری - وصول") : GoTo Get_Error
        If IsNullChr("Int", MablagheVosool.Text, False) = False Then MsgBox("خطا در نوشتن مبلغ وصول", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "حسابداری - وصول") : GoTo Get_Error
        Try
            DBConn = New DBConnection
            DBConn.connectMe("Insert Into HVList (Mostajer,Moajer,SHParvandeNum,Tell,Mablagh,Tarikh) Values ('" & Mostajer.Text & "', '" & Moajer.Text & "', '" & SHParvandeNum.Text & "', '" & Tell.Text & "', '" & MablagheVosool.Text & "', '" & TarikheVosool.Text & "');")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                DBConn.OLEComm.ExecuteNonQuery()
                DBConn.OLEConn.Close()
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
        Me.Close()
        Exit Sub
Get_Error:
        Me.Enabled = True
    End Sub

    Private Sub HVAddF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadKeyboardLayout("00000429", 1)
        TarikheVosool.Text = Shamsi()
    End Sub

    Private Sub HVAddF_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        LoadKeyboardLayout("00000409", 1)
    End Sub
End Class
