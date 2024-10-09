Public Class HBAddF
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
    Friend WithEvents CancelB As System.Windows.Forms.Button
    Friend WithEvents AddB As System.Windows.Forms.Button
    Friend WithEvents ChangeB As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TarikheBardasht As System.Windows.Forms.Label
    Friend WithEvents MablagheBardasht As System.Windows.Forms.TextBox
    Friend WithEvents ForSub As System.Windows.Forms.TextBox
    Friend WithEvents Pardakhter As System.Windows.Forms.TextBox
    Friend WithEvents Tell As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CancelB = New System.Windows.Forms.Button
        Me.AddB = New System.Windows.Forms.Button
        Me.ChangeB = New System.Windows.Forms.Button
        Me.TarikheBardasht = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.MablagheBardasht = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ForSub = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Tell = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Pardakhter = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'CancelB
        '
        Me.CancelB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.CancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CancelB.Location = New System.Drawing.Point(48, 184)
        Me.CancelB.Name = "CancelB"
        Me.CancelB.Size = New System.Drawing.Size(96, 23)
        Me.CancelB.TabIndex = 6
        Me.CancelB.Text = "لغو"
        '
        'AddB
        '
        Me.AddB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.AddB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AddB.Location = New System.Drawing.Point(160, 184)
        Me.AddB.Name = "AddB"
        Me.AddB.Size = New System.Drawing.Size(96, 23)
        Me.AddB.TabIndex = 5
        Me.AddB.Text = "برداشت"
        '
        'ChangeB
        '
        Me.ChangeB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.ChangeB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ChangeB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChangeB.Location = New System.Drawing.Point(16, 144)
        Me.ChangeB.Name = "ChangeB"
        Me.ChangeB.Size = New System.Drawing.Size(40, 20)
        Me.ChangeB.TabIndex = 4
        Me.ChangeB.Text = "تغییر"
        '
        'TarikheBardasht
        '
        Me.TarikheBardasht.BackColor = System.Drawing.Color.White
        Me.TarikheBardasht.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TarikheBardasht.Location = New System.Drawing.Point(64, 144)
        Me.TarikheBardasht.Name = "TarikheBardasht"
        Me.TarikheBardasht.Size = New System.Drawing.Size(120, 23)
        Me.TarikheBardasht.TabIndex = 31
        Me.TarikheBardasht.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(192, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 24)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "تاریخ برداشت :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MablagheBardasht
        '
        Me.MablagheBardasht.Location = New System.Drawing.Point(64, 112)
        Me.MablagheBardasht.MaxLength = 50
        Me.MablagheBardasht.Name = "MablagheBardasht"
        Me.MablagheBardasht.Size = New System.Drawing.Size(120, 23)
        Me.MablagheBardasht.TabIndex = 3
        Me.MablagheBardasht.Text = ""
        Me.MablagheBardasht.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(200, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 24)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "مبلغ برداشت :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ForSub
        '
        Me.ForSub.Location = New System.Drawing.Point(64, 80)
        Me.ForSub.MaxLength = 50
        Me.ForSub.Name = "ForSub"
        Me.ForSub.Size = New System.Drawing.Size(120, 23)
        Me.ForSub.TabIndex = 2
        Me.ForSub.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(200, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "بابت موضوع :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tell
        '
        Me.Tell.Location = New System.Drawing.Point(64, 48)
        Me.Tell.MaxLength = 50
        Me.Tell.Name = "Tell"
        Me.Tell.Size = New System.Drawing.Size(120, 23)
        Me.Tell.TabIndex = 1
        Me.Tell.Text = ""
        Me.Tell.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "تلفن تماس :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pardakhter
        '
        Me.Pardakhter.Location = New System.Drawing.Point(64, 16)
        Me.Pardakhter.MaxLength = 50
        Me.Pardakhter.Name = "Pardakhter"
        Me.Pardakhter.Size = New System.Drawing.Size(120, 23)
        Me.Pardakhter.TabIndex = 0
        Me.Pardakhter.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "پرداخت کننده :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HBAddF
        '
        Me.AcceptButton = Me.AddB
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.CancelB
        Me.ClientSize = New System.Drawing.Size(306, 216)
        Me.Controls.Add(Me.CancelB)
        Me.Controls.Add(Me.AddB)
        Me.Controls.Add(Me.ChangeB)
        Me.Controls.Add(Me.TarikheBardasht)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MablagheBardasht)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ForSub)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Tell)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Pardakhter)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HBAddF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.Text = "برداشت"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Decs"

    Dim DBConn As DBConnection
    Dim err As System.Exception
    Dim iCounter As Integer

#End Region

    Private Sub HBAddF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadKeyboardLayout("00000429", 1)
        TarikheBardasht.Text = Shamsi()
    End Sub

    Private Sub HBAddF_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        LoadKeyboardLayout("00000409", 1)
    End Sub

    Private Sub ChangeB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeB.Click
        Dim InputBoxForm As New InputBoxF
        InputBoxForm.TVosool.Text = TarikheBardasht.Text
        InputBoxForm.Message.Text = "لطفا در صورت اشتباه بودن تاریخ برداشت درج شده توسط برنامه تاریخ برداشت صحیح را وارد کنید."
        InputBoxForm.ShowDialog()
        TarikheBardasht.Text = InputBoxForm.TVosool.Text
    End Sub

    Private Sub AddB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddB.Click
        Me.Enabled = False
        If IsNullChr("Str", Pardakhter.Text) = False Then MsgBox("خطا در نوشتن نام و نانم خانوادگی پرداخت کننده", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "حسابداری - برداشت") : GoTo Get_Error
        If IsNullChr("Int", Tell.Text, False) = False Then MsgBox("خطا در نوشتن شماره تلفن تماس", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "حسابداری - برداشت") : GoTo Get_Error
        If IsNullChr("Str", ForSub.Text) = False Then MsgBox("خطا در نوشتن موضوع پرداخت", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "حسابداری - برداشت") : GoTo Get_Error
        If IsNullChr("Int", MablagheBardasht.Text) = False Then MsgBox("خطا در نوشتن مبلغ پرداخت", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "حسابداری - برداشت") : GoTo Get_Error
        Try
            DBConn = New DBConnection
            DBConn.connectMe("Insert Into HBList (Pardakhter,Tell,ForSub,Mablagh,Tarikh) Values ('" & Pardakhter.Text & "', '" & Tell.Text & "', '" & ForSub.Text & "', '" & MablagheBardasht.Text & "', '" & TarikheBardasht.Text & "');")
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
End Class
