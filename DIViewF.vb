Public Class DIViewF
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OKB As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.TextBox
    Friend WithEvents Message As System.Windows.Forms.Label
    Friend WithEvents Subject As System.Windows.Forms.Label
    Friend WithEvents DeleteB As System.Windows.Forms.Button
    Friend WithEvents NextB As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Message = New System.Windows.Forms.Label
        Me.OKB = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Subject = New System.Windows.Forms.Label
        Me.ID = New System.Windows.Forms.TextBox
        Me.DeleteB = New System.Windows.Forms.Button
        Me.NextB = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Message
        '
        Me.Message.BackColor = System.Drawing.Color.White
        Me.Message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Message.Location = New System.Drawing.Point(16, 48)
        Me.Message.Name = "Message"
        Me.Message.Size = New System.Drawing.Size(456, 320)
        Me.Message.TabIndex = 0
        '
        'OKB
        '
        Me.OKB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.OKB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OKB.Location = New System.Drawing.Point(224, 376)
        Me.OKB.Name = "OKB"
        Me.OKB.Size = New System.Drawing.Size(88, 23)
        Me.OKB.TabIndex = 10
        Me.OKB.Text = "تایید"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(488, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "متن :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(472, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 24)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "موضوع :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Subject
        '
        Me.Subject.BackColor = System.Drawing.Color.White
        Me.Subject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Subject.Location = New System.Drawing.Point(16, 16)
        Me.Subject.Name = "Subject"
        Me.Subject.Size = New System.Drawing.Size(456, 24)
        Me.Subject.TabIndex = 13
        Me.Subject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(0, 392)
        Me.ID.Name = "ID"
        Me.ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ID.Size = New System.Drawing.Size(32, 23)
        Me.ID.TabIndex = 14
        Me.ID.Text = ""
        Me.ID.Visible = False
        '
        'DeleteB
        '
        Me.DeleteB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.DeleteB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.DeleteB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DeleteB.Location = New System.Drawing.Point(328, 376)
        Me.DeleteB.Name = "DeleteB"
        Me.DeleteB.Size = New System.Drawing.Size(88, 23)
        Me.DeleteB.TabIndex = 15
        Me.DeleteB.Text = "حذف"
        Me.DeleteB.Visible = False
        '
        'NextB
        '
        Me.NextB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.NextB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.NextB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.NextB.Location = New System.Drawing.Point(120, 376)
        Me.NextB.Name = "NextB"
        Me.NextB.Size = New System.Drawing.Size(88, 23)
        Me.NextB.TabIndex = 16
        Me.NextB.Text = "تعویق"
        Me.NextB.Visible = False
        '
        'DIViewF
        '
        Me.AcceptButton = Me.OKB
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(538, 408)
        Me.Controls.Add(Me.NextB)
        Me.Controls.Add(Me.DeleteB)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Subject)
        Me.Controls.Add(Me.OKB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Message)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DIViewF"
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
    Dim TabC(6) As Boolean
    Dim IFNE As Boolean = False

#End Region

    Private Sub DIViewF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DBConn = New DBConnection
            DBConn.connectMe("SELECT * FROM NoteBook WHERE ID=" & ID.Text & ";")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d.Read
                    Me.Text = "نوشته شده توسط " & d("Writer".ToString) & " در تاریخ " & d("WriteDate".ToString)
                    Subject.Text = d("Subject".ToString)
                    Message.Text = d("Message".ToString)
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

    Private Sub OKB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKB.Click
        Me.Hide()
    End Sub

    Private Sub DeleteB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteB.Click
        Try
            DBConn = New DBConnection
            DBConn.connectMe("Delete From NoteBook WHERE ID = " & ID.Text & ";")
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
        MainForm.Get_Setting(5)
        Me.Close()
    End Sub

    Private Sub NextB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextB.Click
        Try
            DBConn = New DBConnection
            DBConn.connectMe("Update NoteBook SET AlarmTime='" & TaTime() & "' WHERE ID=" & ID.Text & ";")
            DBConn.OLEComm.Connection = DBConn.OLEConn
            DBConn.OLEComm.ExecuteNonQuery()
            DBConn.OLEConn.Close()
        Catch err As System.Exception
            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
        End Try
        Me.Close()
    End Sub
End Class
