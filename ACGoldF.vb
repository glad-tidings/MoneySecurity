Public Class ACGoldF
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
    Friend WithEvents OKB As System.Windows.Forms.Button
    Friend WithEvents SumGold As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SumGold = New System.Windows.Forms.Label
        Me.OKB = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'SumGold
        '
        Me.SumGold.BackColor = System.Drawing.Color.White
        Me.SumGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SumGold.Location = New System.Drawing.Point(13, 13)
        Me.SumGold.Name = "SumGold"
        Me.SumGold.Size = New System.Drawing.Size(392, 128)
        Me.SumGold.TabIndex = 0
        Me.SumGold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OKB
        '
        Me.OKB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OKB.Location = New System.Drawing.Point(168, 152)
        Me.OKB.Name = "OKB"
        Me.OKB.Size = New System.Drawing.Size(80, 23)
        Me.OKB.TabIndex = 1
        Me.OKB.Text = "تایید"
        '
        'ACGoldF
        '
        Me.AcceptButton = Me.OKB
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(418, 184)
        Me.ControlBox = False
        Me.Controls.Add(Me.OKB)
        Me.Controls.Add(Me.SumGold)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ACGoldF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.Text = "مجموع طلا"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Decs"

    Dim DBConn As DBConnection
    Public JMode As String

#End Region

    Private Sub ACGold_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case JMode
            Case "G"
                Me.Text = "مجموع طلا"
                Dim dblCGold As Double
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM MoshtariList WHERE IsArchive=False;")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            dblCGold += CDbl(d("CGGold".ToString))
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
                SumGold.Text = (Int(dblCGold) \ 1000) & " کیلو گرم و " & (Int(dblCGold) Mod 1000) & " گرم و " & (Int((dblCGold Mod 1) / 0.001)) & " سوت"
            Case "SG"
                Me.Text = "مجموع سرمایه"
                Dim dblCSGozari As Double
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM SGozari;")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            dblCSGozari += CDbl(d("Mablagh".ToString))
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
                SumGold.Text = Get_HoMoney(dblCSGozari) & " ریال"
            Case "MV"
                Me.Text = "مجموع مبلغ وام"
                Dim dblCMablagheVKH As Double
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM MoshtariList WHERE IsArchive=False;")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            dblCMablagheVKH += CDbl(d("MablagheVKH".ToString))
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
                SumGold.Text = Get_HoMoney(dblCMablagheVKH) & " تومان"
        End Select
    End Sub

    Private Sub OKB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKB.Click
        Me.Close()
    End Sub
End Class
