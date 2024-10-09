Public Class ResidF
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
    Friend WithEvents ChangeGhB As System.Windows.Forms.Button
    Friend WithEvents Tarikh As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Mahiane As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PrintB As System.Windows.Forms.Button
    Friend WithEvents CancelB As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.TextBox
    Friend WithEvents Sarmaiegozar As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ResidF))
        Me.ChangeGhB = New System.Windows.Forms.Button
        Me.Tarikh = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Sarmaiegozar = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Mahiane = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.PrintB = New System.Windows.Forms.Button
        Me.CancelB = New System.Windows.Forms.Button
        Me.ID = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'ChangeGhB
        '
        Me.ChangeGhB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.ChangeGhB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ChangeGhB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChangeGhB.Location = New System.Drawing.Point(16, 80)
        Me.ChangeGhB.Name = "ChangeGhB"
        Me.ChangeGhB.Size = New System.Drawing.Size(40, 20)
        Me.ChangeGhB.TabIndex = 17
        Me.ChangeGhB.Text = "تغییر"
        '
        'Tarikh
        '
        Me.Tarikh.BackColor = System.Drawing.Color.White
        Me.Tarikh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tarikh.Location = New System.Drawing.Point(64, 80)
        Me.Tarikh.Name = "Tarikh"
        Me.Tarikh.Size = New System.Drawing.Size(120, 23)
        Me.Tarikh.TabIndex = 19
        Me.Tarikh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(200, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 24)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "تاریخ رسید :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Sarmaiegozar
        '
        Me.Sarmaiegozar.BackColor = System.Drawing.Color.White
        Me.Sarmaiegozar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Sarmaiegozar.Location = New System.Drawing.Point(64, 16)
        Me.Sarmaiegozar.Name = "Sarmaiegozar"
        Me.Sarmaiegozar.Size = New System.Drawing.Size(120, 23)
        Me.Sarmaiegozar.TabIndex = 20
        Me.Sarmaiegozar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(192, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "سرمایه گذار :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Mahiane
        '
        Me.Mahiane.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Mahiane.Location = New System.Drawing.Point(64, 48)
        Me.Mahiane.MaxLength = 50
        Me.Mahiane.Name = "Mahiane"
        Me.Mahiane.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Mahiane.Size = New System.Drawing.Size(120, 23)
        Me.Mahiane.TabIndex = 22
        Me.Mahiane.Text = ""
        Me.Mahiane.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(200, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 24)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "مبلغ رسید :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrintB
        '
        Me.PrintB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.PrintB.Image = CType(resources.GetObject("PrintB.Image"), System.Drawing.Image)
        Me.PrintB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PrintB.Location = New System.Drawing.Point(152, 120)
        Me.PrintB.Name = "PrintB"
        Me.PrintB.Size = New System.Drawing.Size(96, 24)
        Me.PrintB.TabIndex = 27
        Me.PrintB.Text = "تایید و چاپ"
        Me.PrintB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CancelB
        '
        Me.CancelB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.CancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CancelB.Location = New System.Drawing.Point(48, 120)
        Me.CancelB.Name = "CancelB"
        Me.CancelB.Size = New System.Drawing.Size(96, 23)
        Me.CancelB.TabIndex = 28
        Me.CancelB.Text = "لغو"
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(0, 136)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(24, 23)
        Me.ID.TabIndex = 52
        Me.ID.Text = ""
        Me.ID.Visible = False
        '
        'ResidF
        '
        Me.AcceptButton = Me.PrintB
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.CancelB
        Me.ClientSize = New System.Drawing.Size(298, 152)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.CancelB)
        Me.Controls.Add(Me.PrintB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Mahiane)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Sarmaiegozar)
        Me.Controls.Add(Me.ChangeGhB)
        Me.Controls.Add(Me.Tarikh)
        Me.Controls.Add(Me.Label8)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ResidF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.Text = "ارائه رسید"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Decs"
    Dim DBConn As DBConnection
#End Region

    Private Sub ChangeGhB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeGhB.Click
        Dim InputBoxForm As New InputBoxF
        InputBoxForm.TVosool.Text = Tarikh.Text
        InputBoxForm.Message.Text = "لطفا در صورت اشتباه بودن تاریخ درج شده توسط برنامه تاریخ صحیح را وارد کنید."
        InputBoxForm.ShowDialog()
        Tarikh.Text = InputBoxForm.TVosool.Text
    End Sub

    Private Sub ResidF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadKeyboardLayout("00000429", 1)
        Get_Setting()
    End Sub

    Private Sub Get_Setting()
        Try
            DBConn = New DBConnection
            DBConn.connectMe("SELECT * FROM SGozari WHERE ID = " & ID.Text & ";")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d.Read
                    Sarmaiegozar.Text = d("SFName".ToString) & " " & d("SLName".ToString)
                    Mahiane.Text = d("Mahiane".ToString)
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
        Tarikh.Text = Shamsi()
    End Sub

    Private Sub ResidF_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        LoadKeyboardLayout("00000409", 1)
    End Sub

    Private Sub PrintB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintB.Click
        If IsNullChr("Int", Mahiane.Text) = False Then MsgBox("ÎØÇ ÏÑ äæÔÊä ãÈáÛ ÑÓíÏ", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "ÇÑÇÆå ÑÓíÏ") : Exit Sub
        Try
            DBConn = New DBConnection
            DBConn.ReconnectMe("Insert Into ResidReport (Sarmaiegozar,Mahiane,Tarikh) Values ('" & Sarmaiegozar.Text & "', '" & Mahiane.Text & "', '" & Tarikh.Text & "');")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                DBConn.OLEComm.ExecuteNonQuery()
                DBConn.OLEConn.Close()
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            End Try
            Try
                DBConn.OLEConn.Close()
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            End Try
        Catch err As System.Exception
            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
        End Try
        Try
            DBConn = New DBConnection
            DBConn.ReconnectMe("Insert Into Resid (Sarmaiegozar,Mahiane,Tarikh) Values ('" & Sarmaiegozar.Text & "', '" & Mahiane.Text & "', '" & Tarikh.Text & "');")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                DBConn.OLEComm.ExecuteNonQuery()
                DBConn.OLEConn.Close()
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            End Try
            Try
                DBConn.OLEConn.Close()
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            End Try
        Catch err As System.Exception
            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
        End Try
        Dim PrintForm As New PrintF
        PrintForm.WP.Text = 18
        PrintForm.ShowDialog()
        Try
            DBConn = New DBConnection
            DBConn.ReconnectMe("Delete From ResidReport;")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                DBConn.OLEComm.ExecuteNonQuery()
                DBConn.OLEConn.Close()
                Try
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
            End Try
        Catch err As System.Exception
            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
        End Try
        Me.Close()
    End Sub
End Class
