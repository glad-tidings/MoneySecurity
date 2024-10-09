Public Class UnSGEditF
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
    Friend WithEvents Sarmaiegozar As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CancelB As System.Windows.Forms.Button
    Friend WithEvents Mostajer As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SHParvandeNum As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.TextBox
    Friend WithEvents EditB As System.Windows.Forms.Button
    Friend WithEvents CGGold As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Sarmaiegozar = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.CancelB = New System.Windows.Forms.Button
        Me.EditB = New System.Windows.Forms.Button
        Me.Mostajer = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.SHParvandeNum = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CGGold = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ID = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Sarmaiegozar
        '
        Me.Sarmaiegozar.BackColor = System.Drawing.Color.White
        Me.Sarmaiegozar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Sarmaiegozar.Location = New System.Drawing.Point(16, 16)
        Me.Sarmaiegozar.Name = "Sarmaiegozar"
        Me.Sarmaiegozar.Size = New System.Drawing.Size(144, 23)
        Me.Sarmaiegozar.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(168, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 24)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "سرمایه گذار :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'EditB
        '
        Me.EditB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.EditB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.EditB.Location = New System.Drawing.Point(144, 152)
        Me.EditB.Name = "EditB"
        Me.EditB.Size = New System.Drawing.Size(96, 23)
        Me.EditB.TabIndex = 3
        Me.EditB.Text = "ویرایش"
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
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "مستاجر :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "شماره پرونده :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "مقدار گرم طلا :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(0, 168)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(24, 23)
        Me.ID.TabIndex = 22
        Me.ID.Text = ""
        Me.ID.Visible = False
        '
        'UnSGEditF
        '
        Me.AcceptButton = Me.EditB
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.CancelB
        Me.ClientSize = New System.Drawing.Size(274, 184)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Sarmaiegozar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CancelB)
        Me.Controls.Add(Me.EditB)
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
        Me.Name = "UnSGEditF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.Text = "ویرایش اطلاعات طلا محول"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Decs"

    Dim DBConn As DBConnection
    Dim err As System.Exception
    Dim iCounter As Integer

#End Region

    Private Sub UnSGEditF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadKeyboardLayout("00000429", 1)
        Try
            DBConn = New DBConnection
            DBConn.connectMe("SELECT * FROM AnySGozari WHERE ID = " & ID.Text & ";")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d.Read
                    CGGold.Text = d("CGGold".ToString)
                    SHParvandeNum.Text = d("SHParvandeNum".ToString)
                    Mostajer.Text = d("Mostajer".ToString)
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

    Private Sub EditB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditB.Click
        Me.Enabled = False
        If IsNullChr("Real", CGGold.Text) = False Then MsgBox("خطا در نوشتن مقدار گرم طلا", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش سرمایه گذاری") : GoTo Get_Error
        If IsNullChr("Int", SHParvandeNum.Text, False) = False Then MsgBox("خطا در نوشتن شماره پرونده", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش سرمایه گذاری") : GoTo Get_Error
        If IsNullChr("Str", Mostajer.Text, False) = False Then MsgBox("خطا در نوشتن نام مستاجر", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش سرمایه گذاری") : GoTo Get_Error
        Try
            DBConn = New DBConnection
            DBConn.connectMe("Update AnySGozari SET CGGold='" & CGGold.Text & "',SHParvandeNum='" & SHParvandeNum.Text & "',Mostajer='" & Mostajer.Text & "' WHERE ID=" & ID.Text & ";")
            DBConn.OLEComm.Connection = DBConn.OLEConn
            DBConn.OLEComm.ExecuteNonQuery()
            DBConn.OLEConn.Close()
        Catch err As System.Exception
            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            GoTo Get_Error
        End Try
        Me.Close()
        Exit Sub
Get_Error:
        Me.Enabled = True
    End Sub

    Private Sub UnSGEditF_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        LoadKeyboardLayout("00000409", 1)
    End Sub
End Class
