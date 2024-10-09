Public Class UnSGAddF
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
    Friend WithEvents CancelB As System.Windows.Forms.Button
    Friend WithEvents MoveB As System.Windows.Forms.Button
    Friend WithEvents SHParvandeNum As System.Windows.Forms.TextBox
    Friend WithEvents Mostajer As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Sarmaiegozar As System.Windows.Forms.Label
    Friend WithEvents GHNum As System.Windows.Forms.TextBox
    Friend WithEvents CGGold As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CGGold = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SHParvandeNum = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Mostajer = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CancelB = New System.Windows.Forms.Button
        Me.MoveB = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Sarmaiegozar = New System.Windows.Forms.Label
        Me.GHNum = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'CGGold
        '
        Me.CGGold.Location = New System.Drawing.Point(16, 48)
        Me.CGGold.MaxLength = 50
        Me.CGGold.Name = "CGGold"
        Me.CGGold.Size = New System.Drawing.Size(144, 23)
        Me.CGGold.TabIndex = 0
        Me.CGGold.Text = ""
        Me.CGGold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "مقدار گرم طلا :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SHParvandeNum
        '
        Me.SHParvandeNum.Location = New System.Drawing.Point(16, 80)
        Me.SHParvandeNum.MaxLength = 50
        Me.SHParvandeNum.Name = "SHParvandeNum"
        Me.SHParvandeNum.Size = New System.Drawing.Size(144, 23)
        Me.SHParvandeNum.TabIndex = 1
        Me.SHParvandeNum.Text = ""
        Me.SHParvandeNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(168, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "شماره پرونده :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Mostajer
        '
        Me.Mostajer.Location = New System.Drawing.Point(16, 112)
        Me.Mostajer.MaxLength = 50
        Me.Mostajer.Name = "Mostajer"
        Me.Mostajer.Size = New System.Drawing.Size(144, 23)
        Me.Mostajer.TabIndex = 2
        Me.Mostajer.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(192, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "مستاجر :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CancelB
        '
        Me.CancelB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.CancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CancelB.Location = New System.Drawing.Point(32, 152)
        Me.CancelB.Name = "CancelB"
        Me.CancelB.Size = New System.Drawing.Size(96, 23)
        Me.CancelB.TabIndex = 4
        Me.CancelB.Text = "لغو"
        '
        'MoveB
        '
        Me.MoveB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.MoveB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MoveB.Location = New System.Drawing.Point(144, 152)
        Me.MoveB.Name = "MoveB"
        Me.MoveB.Size = New System.Drawing.Size(96, 23)
        Me.MoveB.TabIndex = 3
        Me.MoveB.Text = "انتقال"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(168, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "سرمایه گذار :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Sarmaiegozar
        '
        Me.Sarmaiegozar.BackColor = System.Drawing.Color.White
        Me.Sarmaiegozar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Sarmaiegozar.Location = New System.Drawing.Point(16, 16)
        Me.Sarmaiegozar.Name = "Sarmaiegozar"
        Me.Sarmaiegozar.Size = New System.Drawing.Size(144, 23)
        Me.Sarmaiegozar.TabIndex = 11
        '
        'GHNum
        '
        Me.GHNum.Location = New System.Drawing.Point(0, 168)
        Me.GHNum.Name = "GHNum"
        Me.GHNum.Size = New System.Drawing.Size(24, 23)
        Me.GHNum.TabIndex = 25
        Me.GHNum.Text = ""
        Me.GHNum.Visible = False
        '
        'UnSGAddF
        '
        Me.AcceptButton = Me.MoveB
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.CancelB
        Me.ClientSize = New System.Drawing.Size(274, 184)
        Me.Controls.Add(Me.GHNum)
        Me.Controls.Add(Me.Sarmaiegozar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CancelB)
        Me.Controls.Add(Me.MoveB)
        Me.Controls.Add(Me.Mostajer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SHParvandeNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CGGold)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UnSGAddF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.Text = "تحویل طلا به سرمایه گذار"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Decs"

    Dim DBConn As DBConnection
    Dim err As System.Exception
    Dim iCounter As Integer

#End Region

    Private Sub MoveB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveB.Click
        Me.Enabled = False
        If IsNullChr("Real", CGGold.Text) = False Then MsgBox("خطا در نوشتن مقدار گرم طلا", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش سرمایه گذاری") : GoTo Get_Error
        If IsNullChr("Int", SHParvandeNum.Text, False) = False Then MsgBox("خطا در نوشتن شماره پرونده", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش سرمایه گذاری") : GoTo Get_Error
        If IsNullChr("Str", Mostajer.Text, False) = False Then MsgBox("خطا در نوشتن نام مستاجر", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش سرمایه گذاری") : GoTo Get_Error
        Try
            DBConn = New DBConnection
            DBConn.connectMe("Insert Into AnySGozari (GharardadNum,CGGold,SHParvandeNum,Mostajer) Values ('" & GHNum.Text & "', '" & CGGold.Text & "', '" & SHParvandeNum.Text & "', '" & Mostajer.Text & "');")
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

    Private Sub UnSGAddF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadKeyboardLayout("00000429", 1)
    End Sub

    Private Sub UnSGAddF_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        LoadKeyboardLayout("00000409", 1)
    End Sub
End Class
