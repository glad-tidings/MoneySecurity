Public Class EditViewF
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
    Friend WithEvents IsArchive As System.Windows.Forms.CheckBox
    Friend WithEvents SHParvandeNum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CancelB As System.Windows.Forms.Button
    Friend WithEvents OKB As System.Windows.Forms.Button
    Friend WithEvents GhestT As System.Windows.Forms.TextBox
    Friend WithEvents AghsatCount As System.Windows.Forms.Label
    Friend WithEvents MablagheGh As System.Windows.Forms.Label
    Friend WithEvents Mostajer As System.Windows.Forms.Label
    Friend WithEvents Moajer As System.Windows.Forms.Label
    Friend WithEvents Ghest As System.Windows.Forms.Label
    Friend WithEvents TPardakht As System.Windows.Forms.Label
    Friend WithEvents TVosool As System.Windows.Forms.Label
    Friend WithEvents MDirkard As System.Windows.Forms.Label
    Friend WithEvents JPardakht As System.Windows.Forms.Label
    Friend WithEvents TarikheGha As System.Windows.Forms.TextBox
    Friend WithEvents JTakhir As System.Windows.Forms.TextBox
    Friend WithEvents ID As System.Windows.Forms.TextBox
    Friend WithEvents ChangeB As System.Windows.Forms.Button
    Friend WithEvents PeGet As System.Windows.Forms.TextBox
    Friend WithEvents Tell As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.IsArchive = New System.Windows.Forms.CheckBox
        Me.SHParvandeNum = New System.Windows.Forms.TextBox
        Me.GhestT = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.CancelB = New System.Windows.Forms.Button
        Me.OKB = New System.Windows.Forms.Button
        Me.Tell = New System.Windows.Forms.Label
        Me.AghsatCount = New System.Windows.Forms.Label
        Me.MablagheGh = New System.Windows.Forms.Label
        Me.Mostajer = New System.Windows.Forms.Label
        Me.Moajer = New System.Windows.Forms.Label
        Me.Ghest = New System.Windows.Forms.Label
        Me.TPardakht = New System.Windows.Forms.Label
        Me.TVosool = New System.Windows.Forms.Label
        Me.MDirkard = New System.Windows.Forms.Label
        Me.JPardakht = New System.Windows.Forms.Label
        Me.TarikheGha = New System.Windows.Forms.TextBox
        Me.JTakhir = New System.Windows.Forms.TextBox
        Me.ID = New System.Windows.Forms.TextBox
        Me.ChangeB = New System.Windows.Forms.Button
        Me.PeGet = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'IsArchive
        '
        Me.IsArchive.Location = New System.Drawing.Point(96, 368)
        Me.IsArchive.Name = "IsArchive"
        Me.IsArchive.Size = New System.Drawing.Size(16, 16)
        Me.IsArchive.TabIndex = 6
        Me.IsArchive.TabStop = False
        Me.IsArchive.Visible = False
        '
        'SHParvandeNum
        '
        Me.SHParvandeNum.Location = New System.Drawing.Point(32, 368)
        Me.SHParvandeNum.Name = "SHParvandeNum"
        Me.SHParvandeNum.Size = New System.Drawing.Size(32, 23)
        Me.SHParvandeNum.TabIndex = 5
        Me.SHParvandeNum.TabStop = False
        Me.SHParvandeNum.Text = ""
        Me.SHParvandeNum.Visible = False
        '
        'GhestT
        '
        Me.GhestT.Location = New System.Drawing.Point(64, 368)
        Me.GhestT.Name = "GhestT"
        Me.GhestT.Size = New System.Drawing.Size(32, 23)
        Me.GhestT.TabIndex = 7
        Me.GhestT.TabStop = False
        Me.GhestT.Text = ""
        Me.GhestT.Visible = False
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(272, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "قسط :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(272, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "موجر :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(256, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "مستاجر :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(272, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "مبلغ :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label5.Location = New System.Drawing.Point(264, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "اقساط :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label6.Location = New System.Drawing.Point(232, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "تلفن تماس :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label7.Location = New System.Drawing.Point(232, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 23)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "تاریخ پرداخت :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label8.Location = New System.Drawing.Point(240, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 23)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "تاریخ وصول :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label9.Location = New System.Drawing.Point(240, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 23)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "مبلغ دیرکرد :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label10.Location = New System.Drawing.Point(232, 304)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 23)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "جمع پرداخت :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CancelB
        '
        Me.CancelB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.CancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CancelB.Location = New System.Drawing.Point(80, 344)
        Me.CancelB.Name = "CancelB"
        Me.CancelB.Size = New System.Drawing.Size(80, 24)
        Me.CancelB.TabIndex = 0
        Me.CancelB.Text = "لغو"
        '
        'OKB
        '
        Me.OKB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.OKB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OKB.Location = New System.Drawing.Point(176, 344)
        Me.OKB.Name = "OKB"
        Me.OKB.Size = New System.Drawing.Size(80, 24)
        Me.OKB.TabIndex = 18
        Me.OKB.Text = "تایید"
        '
        'Tell
        '
        Me.Tell.BackColor = System.Drawing.Color.White
        Me.Tell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tell.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Tell.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Tell.Location = New System.Drawing.Point(96, 176)
        Me.Tell.Name = "Tell"
        Me.Tell.Size = New System.Drawing.Size(128, 23)
        Me.Tell.TabIndex = 19
        Me.Tell.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AghsatCount
        '
        Me.AghsatCount.BackColor = System.Drawing.Color.White
        Me.AghsatCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AghsatCount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.AghsatCount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AghsatCount.Location = New System.Drawing.Point(96, 144)
        Me.AghsatCount.Name = "AghsatCount"
        Me.AghsatCount.Size = New System.Drawing.Size(128, 23)
        Me.AghsatCount.TabIndex = 20
        Me.AghsatCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MablagheGh
        '
        Me.MablagheGh.BackColor = System.Drawing.Color.White
        Me.MablagheGh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MablagheGh.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MablagheGh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MablagheGh.Location = New System.Drawing.Point(96, 112)
        Me.MablagheGh.Name = "MablagheGh"
        Me.MablagheGh.Size = New System.Drawing.Size(128, 23)
        Me.MablagheGh.TabIndex = 21
        Me.MablagheGh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Mostajer
        '
        Me.Mostajer.BackColor = System.Drawing.Color.White
        Me.Mostajer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Mostajer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Mostajer.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Mostajer.Location = New System.Drawing.Point(24, 80)
        Me.Mostajer.Name = "Mostajer"
        Me.Mostajer.Size = New System.Drawing.Size(200, 23)
        Me.Mostajer.TabIndex = 22
        Me.Mostajer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Moajer
        '
        Me.Moajer.BackColor = System.Drawing.Color.White
        Me.Moajer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Moajer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Moajer.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Moajer.Location = New System.Drawing.Point(24, 48)
        Me.Moajer.Name = "Moajer"
        Me.Moajer.Size = New System.Drawing.Size(200, 23)
        Me.Moajer.TabIndex = 23
        Me.Moajer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ghest
        '
        Me.Ghest.BackColor = System.Drawing.Color.White
        Me.Ghest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ghest.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Ghest.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Ghest.Location = New System.Drawing.Point(96, 16)
        Me.Ghest.Name = "Ghest"
        Me.Ghest.Size = New System.Drawing.Size(128, 23)
        Me.Ghest.TabIndex = 24
        Me.Ghest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TPardakht
        '
        Me.TPardakht.BackColor = System.Drawing.Color.White
        Me.TPardakht.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TPardakht.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TPardakht.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TPardakht.Location = New System.Drawing.Point(96, 208)
        Me.TPardakht.Name = "TPardakht"
        Me.TPardakht.Size = New System.Drawing.Size(128, 23)
        Me.TPardakht.TabIndex = 25
        Me.TPardakht.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TVosool
        '
        Me.TVosool.BackColor = System.Drawing.Color.White
        Me.TVosool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TVosool.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TVosool.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TVosool.Location = New System.Drawing.Point(96, 240)
        Me.TVosool.Name = "TVosool"
        Me.TVosool.Size = New System.Drawing.Size(128, 23)
        Me.TVosool.TabIndex = 26
        Me.TVosool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MDirkard
        '
        Me.MDirkard.BackColor = System.Drawing.Color.White
        Me.MDirkard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MDirkard.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MDirkard.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MDirkard.Location = New System.Drawing.Point(96, 272)
        Me.MDirkard.Name = "MDirkard"
        Me.MDirkard.Size = New System.Drawing.Size(128, 23)
        Me.MDirkard.TabIndex = 27
        Me.MDirkard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'JPardakht
        '
        Me.JPardakht.BackColor = System.Drawing.Color.White
        Me.JPardakht.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.JPardakht.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.JPardakht.ForeColor = System.Drawing.SystemColors.WindowText
        Me.JPardakht.Location = New System.Drawing.Point(96, 304)
        Me.JPardakht.Name = "JPardakht"
        Me.JPardakht.Size = New System.Drawing.Size(128, 23)
        Me.JPardakht.TabIndex = 28
        Me.JPardakht.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TarikheGha
        '
        Me.TarikheGha.Location = New System.Drawing.Point(112, 368)
        Me.TarikheGha.Name = "TarikheGha"
        Me.TarikheGha.Size = New System.Drawing.Size(32, 23)
        Me.TarikheGha.TabIndex = 29
        Me.TarikheGha.TabStop = False
        Me.TarikheGha.Text = ""
        Me.TarikheGha.Visible = False
        '
        'JTakhir
        '
        Me.JTakhir.Location = New System.Drawing.Point(144, 368)
        Me.JTakhir.Name = "JTakhir"
        Me.JTakhir.Size = New System.Drawing.Size(32, 23)
        Me.JTakhir.TabIndex = 30
        Me.JTakhir.TabStop = False
        Me.JTakhir.Text = ""
        Me.JTakhir.Visible = False
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(0, 368)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(32, 23)
        Me.ID.TabIndex = 31
        Me.ID.TabStop = False
        Me.ID.Text = ""
        Me.ID.Visible = False
        '
        'ChangeB
        '
        Me.ChangeB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.ChangeB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ChangeB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChangeB.Location = New System.Drawing.Point(48, 241)
        Me.ChangeB.Name = "ChangeB"
        Me.ChangeB.Size = New System.Drawing.Size(40, 20)
        Me.ChangeB.TabIndex = 32
        Me.ChangeB.Text = "تغییر"
        '
        'PeGet
        '
        Me.PeGet.Location = New System.Drawing.Point(176, 368)
        Me.PeGet.Name = "PeGet"
        Me.PeGet.Size = New System.Drawing.Size(32, 23)
        Me.PeGet.TabIndex = 33
        Me.PeGet.TabStop = False
        Me.PeGet.Text = ""
        Me.PeGet.Visible = False
        '
        'EditViewF
        '
        Me.AcceptButton = Me.OKB
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.CancelB
        Me.ClientSize = New System.Drawing.Size(336, 376)
        Me.Controls.Add(Me.PeGet)
        Me.Controls.Add(Me.ChangeB)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.JTakhir)
        Me.Controls.Add(Me.TarikheGha)
        Me.Controls.Add(Me.JPardakht)
        Me.Controls.Add(Me.MDirkard)
        Me.Controls.Add(Me.TVosool)
        Me.Controls.Add(Me.TPardakht)
        Me.Controls.Add(Me.Ghest)
        Me.Controls.Add(Me.Moajer)
        Me.Controls.Add(Me.Mostajer)
        Me.Controls.Add(Me.MablagheGh)
        Me.Controls.Add(Me.AghsatCount)
        Me.Controls.Add(Me.Tell)
        Me.Controls.Add(Me.OKB)
        Me.Controls.Add(Me.CancelB)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GhestT)
        Me.Controls.Add(Me.IsArchive)
        Me.Controls.Add(Me.SHParvandeNum)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditViewF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Decs"

    Dim DBConn As DBConnection
    Dim err As System.Exception
    Dim iCounter As Integer
    Dim Item As ListViewItem

#End Region

    Private Sub EditViewF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case IsArchive.Checked
            Case True
                Me.Text = "اطلاعات مشتری به شماره پرونده " & SHParvandeNum.Text
                OKB.Visible = False
                CancelB.Text = "تایید"
                CancelB.Left = 128
                ChangeB.Visible = False
            Case False
                Me.Text = "ویرایش اطلاعات مشتری به شماره پرونده " & SHParvandeNum.Text
        End Select
        Try
            DBConn = New DBConnection
            DBConn.connectMe("SELECT * FROM MoshtariList WHERE SHParvandeNum=" & SHParvandeNum.Text & ";")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d.Read
                    Moajer.Text = d("MoajerFN".ToString) & " " & d("MoajerLN".ToString)
                    Mostajer.Text = d("MostajerFN".ToString) & " " & d("MostajerLN".ToString)
                    MablagheGh.Text = d("MablagheGh".ToString)
                    JTakhir.Text = d("JTakhir".ToString)
                    AghsatCount.Text = d("AghsatCount".ToString)
                    Tell.Text = d("Tell".ToString)
                    TarikheGha.Text = d("TarikheGha".ToString)
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
        Ghest.Text = GhestT.Text
        Select Case ((Mid(TarikheGha.Text, 4, 2) + Int(GhestT.Text)) Mod 12)
            Case 0
                TPardakht.Text = ((Microsoft.VisualBasic.Left(TarikheGha.Text, 2) + ((Mid(TarikheGha.Text, 4, 2)) + Int(GhestT.Text)) \ 12) - 1) & "/12" & Microsoft.VisualBasic.Right(TarikheGha.Text, 3)
            Case 1, 2, 3, 4, 5, 6, 7, 8, 9
                TPardakht.Text = (Microsoft.VisualBasic.Left(TarikheGha.Text, 2) + ((Mid(TarikheGha.Text, 4, 2)) + Int(GhestT.Text)) \ 12) & "/0" & ((Mid(TarikheGha.Text, 4, 2) + Int(GhestT.Text)) Mod 12) & Microsoft.VisualBasic.Right(TarikheGha.Text, 3)
            Case 10, 11
                TPardakht.Text = (Microsoft.VisualBasic.Left(TarikheGha.Text, 2) + ((Mid(TarikheGha.Text, 4, 2)) + Int(GhestT.Text)) \ 12) & "/" & ((Mid(TarikheGha.Text, 4, 2) + Int(GhestT.Text)) Mod 12) & Microsoft.VisualBasic.Right(TarikheGha.Text, 3)
        End Select
        TVosool.Text = Shamsi()
        If Diff(Microsoft.VisualBasic.Left(TPardakht.Text, 2) & Mid(TPardakht.Text, 4, 2) & Microsoft.VisualBasic.Right(TPardakht.Text, 2), Microsoft.VisualBasic.Left(TVosool.Text, 2) & Mid(TVosool.Text, 4, 2) & Microsoft.VisualBasic.Right(TVosool.Text, 2)) < 0 Then
            MDirkard.Text = 0
        Else
            MDirkard.Text = Diff(Microsoft.VisualBasic.Left(TPardakht.Text, 2) & Mid(TPardakht.Text, 4, 2) & Microsoft.VisualBasic.Right(TPardakht.Text, 2), Microsoft.VisualBasic.Left(TVosool.Text, 2) & Mid(TVosool.Text, 4, 2) & Microsoft.VisualBasic.Right(TVosool.Text, 2)) * JTakhir.Text
        End If
        JPardakht.Text = Int(MablagheGh.Text) + Int(MDirkard.Text)
    End Sub

    Private Sub OKB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKB.Click
        Me.Enabled = False
        Try
            DBConn = New DBConnection
            DBConn.connectMe("Update AnyMoshtari SET Moajer='" & Moajer.Text & "',Mostajer='" & Mostajer.Text & "',MablagheGh='" & MablagheGh.Text & "',AghsatCount='" & AghsatCount.Text & "',Tell='" & Tell.Text & "',TPardakht='" & TPardakht.Text & "',TVosool='" & TVosool.Text & "',MDirkard='" & MDirkard.Text & "',JPardakht='" & JPardakht.Text & "',IfPardakht=True WHERE ID=" & ID.Text & ";")
            DBConn.OLEComm.Connection = DBConn.OLEConn
            DBConn.OLEComm.ExecuteNonQuery()
            DBConn.OLEConn.Close()
        Catch err As System.Exception
            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            GoTo Get_Error
        End Try
        Try
            DBConn = New DBConnection
            DBConn.connectMe("Insert Into HVList (Mostajer,Moajer,SHParvandeNum,Tell,Mablagh,Tarikh) Values ('" & Mostajer.Text & "', '" & Moajer.Text & "', '" & SHParvandeNum.Text & "', '" & Tell.Text & "', '" & MablagheGh.Text & "', '" & TVosool.Text & "');")
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
        Try
            DBConn = New DBConnection
            DBConn.connectMe("Insert Into PReport (TVosool,MDirkard,JPardakht,PeGet) Values ('" & TVosool.Text & "', '" & MDirkard.Text & "', '" & JPardakht.Text & "', '" & PeGet.Text & "');")
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
        If MessageBox("آیا می خواهید رسید قسط را چاپ کنید؟", MsgBoxStyle.SystemModal, "چاپ رسید قسط") = True Then
            Dim PrintForm As New PrintF
            PrintForm.WP.Text = 2
            PrintForm.ShowDialog()
        End If
        Try
            DBConn = New DBConnection
            DBConn.connectMe("Delete From PReport;")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                DBConn.OLEComm.ExecuteNonQuery()
                DBConn.OLEConn.Close()
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
        Me.Close()
        Exit Sub
Get_Error:
        Me.Enabled = True
    End Sub

    Private Sub TVosool_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TVosool.DoubleClick
        If IsArchive.Checked = False Then
            Dim InputBoxForm As New InputBoxF
            InputBoxForm.TVosool.Text = TVosool.Text
            InputBoxForm.ShowDialog()
            TVosool.Text = InputBoxForm.TVosool.Text
        End If
    End Sub

    Private Sub ChangeB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeB.Click
        Dim InputBoxForm As New InputBoxF
        InputBoxForm.TVosool.Text = TVosool.Text
        InputBoxForm.ShowDialog()
        TVosool.Text = InputBoxForm.TVosool.Text
        If Diff(Microsoft.VisualBasic.Left(TPardakht.Text, 2) & Mid(TPardakht.Text, 4, 2) & Microsoft.VisualBasic.Right(TPardakht.Text, 2), Microsoft.VisualBasic.Left(TVosool.Text, 2) & Mid(TVosool.Text, 4, 2) & Microsoft.VisualBasic.Right(TVosool.Text, 2)) < 0 Then
            MDirkard.Text = 0
        Else
            MDirkard.Text = Diff(Microsoft.VisualBasic.Left(TPardakht.Text, 2) & Mid(TPardakht.Text, 4, 2) & Microsoft.VisualBasic.Right(TPardakht.Text, 2), Microsoft.VisualBasic.Left(TVosool.Text, 2) & Mid(TVosool.Text, 4, 2) & Microsoft.VisualBasic.Right(TVosool.Text, 2)) * JTakhir.Text
        End If
        JPardakht.Text = Int(MablagheGh.Text) + Int(MDirkard.Text)
    End Sub
End Class
