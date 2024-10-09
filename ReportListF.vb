Public Class ReportListF
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
    Friend WithEvents PrintB As System.Windows.Forms.Button
    Friend WithEvents HBList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader34 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader36 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader37 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader38 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader39 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader40 As System.Windows.Forms.ColumnHeader
    Friend WithEvents HVList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader33 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader32 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader30 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader31 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ReportListF))
        Me.PrintB = New System.Windows.Forms.Button
        Me.HBList = New System.Windows.Forms.ListView
        Me.ColumnHeader34 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader36 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader37 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader38 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader39 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader40 = New System.Windows.Forms.ColumnHeader
        Me.HVList = New System.Windows.Forms.ListView
        Me.ColumnHeader25 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader33 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader32 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader26 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader29 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader30 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader31 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'PrintB
        '
        Me.PrintB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.PrintB.Image = CType(resources.GetObject("PrintB.Image"), System.Drawing.Image)
        Me.PrintB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PrintB.Location = New System.Drawing.Point(248, 264)
        Me.PrintB.Name = "PrintB"
        Me.PrintB.Size = New System.Drawing.Size(72, 24)
        Me.PrintB.TabIndex = 18
        Me.PrintB.Text = "چاپ"
        Me.PrintB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HBList
        '
        Me.HBList.BackColor = System.Drawing.Color.DarkGray
        Me.HBList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HBList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader34, Me.ColumnHeader36, Me.ColumnHeader37, Me.ColumnHeader38, Me.ColumnHeader39, Me.ColumnHeader40})
        Me.HBList.ForeColor = System.Drawing.Color.White
        Me.HBList.FullRowSelect = True
        Me.HBList.GridLines = True
        Me.HBList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.HBList.Location = New System.Drawing.Point(0, 0)
        Me.HBList.MultiSelect = False
        Me.HBList.Name = "HBList"
        Me.HBList.Size = New System.Drawing.Size(568, 256)
        Me.HBList.TabIndex = 24
        Me.HBList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader34
        '
        Me.ColumnHeader34.Text = "آیدی"
        Me.ColumnHeader34.Width = 0
        '
        'ColumnHeader36
        '
        Me.ColumnHeader36.Text = "تاریخ برداشت"
        Me.ColumnHeader36.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader36.Width = 91
        '
        'ColumnHeader37
        '
        Me.ColumnHeader37.Text = "مبلغ برداشت"
        Me.ColumnHeader37.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader37.Width = 95
        '
        'ColumnHeader38
        '
        Me.ColumnHeader38.Text = "موضوع برداشت"
        Me.ColumnHeader38.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader38.Width = 146
        '
        'ColumnHeader39
        '
        Me.ColumnHeader39.Text = "شماره موبایل"
        Me.ColumnHeader39.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader39.Width = 102
        '
        'ColumnHeader40
        '
        Me.ColumnHeader40.Text = "پرداخت کننده"
        Me.ColumnHeader40.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader40.Width = 134
        '
        'HVList
        '
        Me.HVList.BackColor = System.Drawing.Color.DarkGray
        Me.HVList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HVList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader25, Me.ColumnHeader33, Me.ColumnHeader32, Me.ColumnHeader26, Me.ColumnHeader29, Me.ColumnHeader30, Me.ColumnHeader31})
        Me.HVList.ForeColor = System.Drawing.Color.White
        Me.HVList.FullRowSelect = True
        Me.HVList.GridLines = True
        Me.HVList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.HVList.Location = New System.Drawing.Point(0, 0)
        Me.HVList.MultiSelect = False
        Me.HVList.Name = "HVList"
        Me.HVList.Size = New System.Drawing.Size(568, 256)
        Me.HVList.TabIndex = 25
        Me.HVList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "آیدی"
        Me.ColumnHeader25.Width = 0
        '
        'ColumnHeader33
        '
        Me.ColumnHeader33.Text = "تاریخ وصول"
        Me.ColumnHeader33.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader33.Width = 78
        '
        'ColumnHeader32
        '
        Me.ColumnHeader32.Text = "مبلغ وصول"
        Me.ColumnHeader32.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader32.Width = 81
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "تلفن تماس"
        Me.ColumnHeader26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader26.Width = 89
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "شماره پرونده"
        Me.ColumnHeader29.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader29.Width = 89
        '
        'ColumnHeader30
        '
        Me.ColumnHeader30.Text = "موجر"
        Me.ColumnHeader30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader30.Width = 112
        '
        'ColumnHeader31
        '
        Me.ColumnHeader31.Text = "مستاجر"
        Me.ColumnHeader31.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader31.Width = 119
        '
        'ReportListF
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(568, 296)
        Me.Controls.Add(Me.HVList)
        Me.Controls.Add(Me.HBList)
        Me.Controls.Add(Me.PrintB)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ReportListF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "DefIns"
    Private Shared m_vb6FormDefInstance As ReportListF
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As ReportListF
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New ReportListF
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As ReportListF)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region

#Region "Decs"
    Dim DBConn As DBConnection
    Dim Item As ListViewItem
#End Region

    Private Sub ReportListF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HVList.Visible = False
        HBList.Visible = False
        Select Case ReportModeFormViewReport
            Case "V"
                HVList.Visible = True
                Me.Text = "نمایش لیست حسابداری - وصول"
                Select Case ReportListFormViewMode
                    Case 1
                        Try
                            DBConn = New DBConnection
                            DBConn.connectMe("SELECT * FROM HVList ORDER BY Tarikh;")
                            Try
                                DBConn.OLEComm.Connection = DBConn.OLEConn
                                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                                Do While d.Read
                                    Item = HVList.Items.Add(d("ID".ToString))
                                    With Item
                                        .SubItems.Add(d("Tarikh".ToString))
                                        .SubItems.Add(d("Mablagh".ToString))
                                        .SubItems.Add(d("Tell".ToString))
                                        .SubItems.Add(d("SHParvandeNum".ToString))
                                        .SubItems.Add(d("Moajer".ToString))
                                        .SubItems.Add(d("Mostajer".ToString))
                                    End With
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
                    Case 2
                        Try
                            DBConn = New DBConnection
                            DBConn.connectMe("SELECT * FROM HVList WHERE Tarikh='" & ReportListFormFT & "' ORDER BY Tarikh;")
                            Try
                                DBConn.OLEComm.Connection = DBConn.OLEConn
                                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                                Do While d.Read
                                    Item = HVList.Items.Add(d("ID".ToString))
                                    With Item
                                        .SubItems.Add(d("Tarikh".ToString))
                                        .SubItems.Add(d("Mablagh".ToString))
                                        .SubItems.Add(d("Tell".ToString))
                                        .SubItems.Add(d("SHParvandeNum".ToString))
                                        .SubItems.Add(d("Moajer".ToString))
                                        .SubItems.Add(d("Mostajer".ToString))
                                    End With
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
                    Case 3
                        Try
                            DBConn = New DBConnection
                            DBConn.connectMe("SELECT * FROM HVList WHERE " & Get_Tarikhs(ReportListFormFT, ReportListFormTT) & " ORDER BY Tarikh;")
                            Try
                                DBConn.OLEComm.Connection = DBConn.OLEConn
                                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                                Do While d.Read
                                    Item = HVList.Items.Add(d("ID".ToString))
                                    With Item
                                        .SubItems.Add(d("Tarikh".ToString))
                                        .SubItems.Add(d("Mablagh".ToString))
                                        .SubItems.Add(d("Tell".ToString))
                                        .SubItems.Add(d("SHParvandeNum".ToString))
                                        .SubItems.Add(d("Moajer".ToString))
                                        .SubItems.Add(d("Mostajer".ToString))
                                    End With
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
                End Select
            Case "B"
                HBList.Visible = True
                Me.Text = "نمایش لیست حسابداری - برداشت"
                Select Case ReportListFormViewMode
                    Case 1
                        Try
                            DBConn = New DBConnection
                            DBConn.connectMe("SELECT * FROM HBList ORDER BY Tarikh;")
                            Try
                                DBConn.OLEComm.Connection = DBConn.OLEConn
                                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                                Do While d.Read
                                    Item = HBList.Items.Add(d("ID".ToString))
                                    With Item
                                        .SubItems.Add(d("Tarikh".ToString))
                                        .SubItems.Add(d("Mablagh".ToString))
                                        .SubItems.Add(d("ForSub".ToString))
                                        .SubItems.Add(d("MobileNum".ToString))
                                        .SubItems.Add(d("Pardakhter".ToString))
                                    End With
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
                    Case 2
                        Try
                            DBConn = New DBConnection
                            DBConn.connectMe("SELECT * FROM HBList WHERE Tarikh='" & ReportListFormFT & "' ORDER BY Tarikh;")
                            Try
                                DBConn.OLEComm.Connection = DBConn.OLEConn
                                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                                Do While d.Read
                                    Item = HBList.Items.Add(d("ID".ToString))
                                    With Item
                                        .SubItems.Add(d("Tarikh".ToString))
                                        .SubItems.Add(d("Mablagh".ToString))
                                        .SubItems.Add(d("ForSub".ToString))
                                        .SubItems.Add(d("MobileNum".ToString))
                                        .SubItems.Add(d("Pardakhter".ToString))
                                    End With
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
                    Case 3
                        Try
                            DBConn = New DBConnection
                            DBConn.connectMe("SELECT * FROM HBList WHERE " & Get_Tarikhs(ReportListFormFT, ReportListFormTT) & " ORDER BY Tarikh;")
                            Try
                                DBConn.OLEComm.Connection = DBConn.OLEConn
                                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                                Do While d.Read
                                    Item = HBList.Items.Add(d("ID".ToString))
                                    With Item
                                        .SubItems.Add(d("Tarikh".ToString))
                                        .SubItems.Add(d("Mablagh".ToString))
                                        .SubItems.Add(d("ForSub".ToString))
                                        .SubItems.Add(d("MobileNum".ToString))
                                        .SubItems.Add(d("Pardakhter".ToString))
                                    End With
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
                End Select
        End Select
    End Sub

    Function Get_Tarikhs(ByVal FT As String, ByVal TT As String) As String
        Dim Ekh As Long
        Ekh = Diff(Microsoft.VisualBasic.Left(FT, 2) & Mid(FT, 4, 2) & Microsoft.VisualBasic.Right(FT, 2), Microsoft.VisualBasic.Left(TT, 2) & Mid(TT, 4, 2) & Microsoft.VisualBasic.Right(TT, 2))
        Get_Tarikhs = ""
        For I As Integer = 0 To Ekh
            If I <> Ekh Then Get_Tarikhs = Get_Tarikhs & "Tarikh='" & SubtractDay(TT, I) & "' or " Else Get_Tarikhs = Get_Tarikhs & "Tarikh='" & SubtractDay(TT, I) & "'"
        Next
    End Function

    Private Sub PrintB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintB.Click
        Dim I As Integer
        Select Case ReportModeFormViewReport
            Case "V"
                If HVList.Items.Count = 0 Then MessageBox("لیست حسابداری - وصول خالی است.", MsgBoxStyle.OKOnly, "چاپ لیست حسابداری - وصول") : Exit Sub
                I = 0
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM HVList;")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            I = I + 1
                            Try
                                DBConn = New DBConnection
                                DBConn.connectMe("Insert Into HVReport (Num,Mostajer,Moajer,SHParvandeNum,Tell,Mablagh,Tarikh) Values ('" & I & "', '" & d("Mostajer".ToString) & "', '" & d("Moajer".ToString) & "', '" & d("SHParvandeNum".ToString) & "', '" & d("Tell".ToString) & "', '" & d("Mablagh".ToString) & "', '" & d("Tarikh".ToString) & "');")
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
                If MessageBox("آیا می خواهید لیست حسابداری - وصول را چاپ کنید؟", MsgBoxStyle.SystemModal, "چاپ لیست حسابداری - وصول") = True Then
                    Dim PrintForm As New PrintF
                    PrintForm.WP.Text = 10
                    PrintForm.ShowDialog()
                End If
            Case "B"
                If HBList.Items.Count = 0 Then MessageBox("لیست حسابداری - برداشت خالی است.", MsgBoxStyle.OKOnly, "چاپ لیست حسابداری - برداشت") : Exit Sub
                I = 0
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM HBList;")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            I = I + 1
                            Try
                                DBConn = New DBConnection
                                DBConn.connectMe("Insert Into HBReport (Num,Pardakhter,MobileNum,ForSub,Mablagh,Tarikh) Values ('" & I & "', '" & d("Pardakhter".ToString) & "', '" & d("MobileNum".ToString) & "', '" & d("ForSub".ToString) & "', '" & d("Mablagh".ToString) & "', '" & d("Tarikh".ToString) & "');")
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
                If MessageBox("آیا می خواهید لیست حسابداری - برداشت را چاپ کنید؟", MsgBoxStyle.SystemModal, "چاپ لیست حسابداری - برداشت") = True Then
                    Dim PrintForm As New PrintF
                    PrintForm.WP.Text = 11
                    PrintForm.ShowDialog()
                End If
        End Select
    End Sub
End Class
