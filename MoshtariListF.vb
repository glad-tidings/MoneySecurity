Public Class MoshtariListF
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
    Friend WithEvents MPrintB As System.Windows.Forms.Button
    Friend WithEvents UpdateListB As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents RTR As System.Windows.Forms.ComboBox
    Friend WithEvents MList As System.Windows.Forms.ListView
    Friend WithEvents RTRO As System.Windows.Forms.ListView
    Friend WithEvents FromR As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToR As System.Windows.Forms.ColumnHeader
    Friend WithEvents DBList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PutBlackCancel As System.Windows.Forms.CheckBox
    Friend WithEvents LoadF As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MoshtariListF))
        Me.MPrintB = New System.Windows.Forms.Button
        Me.RTR = New System.Windows.Forms.ComboBox
        Me.UpdateListB = New System.Windows.Forms.Button
        Me.MList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.RTRO = New System.Windows.Forms.ListView
        Me.FromR = New System.Windows.Forms.ColumnHeader
        Me.ToR = New System.Windows.Forms.ColumnHeader
        Me.DBList = New System.Windows.Forms.ListView
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader19 = New System.Windows.Forms.ColumnHeader
        Me.PutBlackCancel = New System.Windows.Forms.CheckBox
        Me.LoadF = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'MPrintB
        '
        Me.MPrintB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.MPrintB.Image = CType(resources.GetObject("MPrintB.Image"), System.Drawing.Image)
        Me.MPrintB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MPrintB.Location = New System.Drawing.Point(248, 416)
        Me.MPrintB.Name = "MPrintB"
        Me.MPrintB.Size = New System.Drawing.Size(64, 24)
        Me.MPrintB.TabIndex = 23
        Me.MPrintB.Text = "چاپ"
        Me.MPrintB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RTR
        '
        Me.RTR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RTR.Location = New System.Drawing.Point(568, 8)
        Me.RTR.Name = "RTR"
        Me.RTR.Size = New System.Drawing.Size(96, 24)
        Me.RTR.TabIndex = 24
        '
        'UpdateListB
        '
        Me.UpdateListB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.UpdateListB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.UpdateListB.Location = New System.Drawing.Point(328, 416)
        Me.UpdateListB.Name = "UpdateListB"
        Me.UpdateListB.Size = New System.Drawing.Size(144, 23)
        Me.UpdateListB.TabIndex = 22
        Me.UpdateListB.Text = "به روز رسانی"
        '
        'MList
        '
        Me.MList.BackColor = System.Drawing.Color.DarkGray
        Me.MList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader7, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.MList.ForeColor = System.Drawing.Color.White
        Me.MList.GridLines = True
        Me.MList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MList.Location = New System.Drawing.Point(0, 40)
        Me.MList.MultiSelect = False
        Me.MList.Name = "MList"
        Me.MList.Size = New System.Drawing.Size(720, 364)
        Me.MList.TabIndex = 21
        Me.MList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "آیدی"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "مبلغ قسط"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 78
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "تاریخ قرارداد"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 79
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "تعداد اقساط"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "مقدار گرم طلا"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "تلفن تماس"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 81
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "موجر"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 93
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "مستاجر"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 90
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "شماره پرونده"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 87
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "ردیف"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader10.Width = 42
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(664, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 24)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "ردیف :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RTRO
        '
        Me.RTRO.BackColor = System.Drawing.Color.DarkGray
        Me.RTRO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RTRO.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FromR, Me.ToR})
        Me.RTRO.ForeColor = System.Drawing.Color.White
        Me.RTRO.FullRowSelect = True
        Me.RTRO.GridLines = True
        Me.RTRO.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.RTRO.Location = New System.Drawing.Point(0, 432)
        Me.RTRO.MultiSelect = False
        Me.RTRO.Name = "RTRO"
        Me.RTRO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RTRO.Size = New System.Drawing.Size(40, 16)
        Me.RTRO.TabIndex = 26
        Me.RTRO.View = System.Windows.Forms.View.Details
        Me.RTRO.Visible = False
        '
        'FromR
        '
        Me.FromR.Text = "FromR"
        Me.FromR.Width = 52
        '
        'ToR
        '
        Me.ToR.Text = "ToR"
        Me.ToR.Width = 36
        '
        'DBList
        '
        Me.DBList.BackColor = System.Drawing.Color.DarkGray
        Me.DBList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DBList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19})
        Me.DBList.ForeColor = System.Drawing.Color.White
        Me.DBList.FullRowSelect = True
        Me.DBList.GridLines = True
        Me.DBList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.DBList.Location = New System.Drawing.Point(40, 432)
        Me.DBList.MultiSelect = False
        Me.DBList.Name = "DBList"
        Me.DBList.Size = New System.Drawing.Size(40, 16)
        Me.DBList.TabIndex = 28
        Me.DBList.View = System.Windows.Forms.View.Details
        Me.DBList.Visible = False
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "آیدی"
        Me.ColumnHeader11.Width = 0
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "مبلغ قسط"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader12.Width = 74
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "تاریخ قرارداد"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader13.Width = 75
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "تعداد اقساط"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader14.Width = 77
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "شماره موبایل"
        Me.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader15.Width = 86
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "شماره منزل"
        Me.ColumnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader16.Width = 77
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "موجر"
        Me.ColumnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader17.Width = 106
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "مستاجر"
        Me.ColumnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader18.Width = 103
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "شماره پرونده"
        Me.ColumnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader19.Width = 83
        '
        'PutBlackCancel
        '
        Me.PutBlackCancel.Location = New System.Drawing.Point(392, 8)
        Me.PutBlackCancel.Name = "PutBlackCancel"
        Me.PutBlackCancel.Size = New System.Drawing.Size(160, 24)
        Me.PutBlackCancel.TabIndex = 30
        Me.PutBlackCancel.Text = "درج پرونده های مسدود"
        '
        'LoadF
        '
        Me.LoadF.Interval = 1
        '
        'MoshtariListF
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(719, 448)
        Me.Controls.Add(Me.PutBlackCancel)
        Me.Controls.Add(Me.DBList)
        Me.Controls.Add(Me.RTRO)
        Me.Controls.Add(Me.MPrintB)
        Me.Controls.Add(Me.RTR)
        Me.Controls.Add(Me.UpdateListB)
        Me.Controls.Add(Me.MList)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MoshtariListF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "لیست اصلی مشتریان"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "DefIns"
    Private Shared m_vb6FormDefInstance As MoshtariListF
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As MoshtariListF
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New MoshtariListF
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As MoshtariListF)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region

#Region "Decs"

    Dim DBConn As DBConnection
    Dim err As System.Exception
    Dim iCounter As Integer
    Dim J As Integer
    Dim K As Integer
    Dim Item As ListViewItem

#End Region

    Private Sub MoshtariListF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadF.Start()
    End Sub

    Private Sub Get_Radif(ByVal Index As Integer)
        RTR.Items.Clear()
        RTRO.Items.Clear()
        K = 1
        DBConn = New DBConnection
        If PutBlackCancel.Checked = False Then
            DBConn.connectMe("SELECT * FROM MoshtariList WHERE IsBlackCancel=false;")
        Else
            DBConn.connectMe("SELECT * FROM MoshtariList;")
        End If
        iCounter = DBConn.getData("ID").Count
        DBConn.OLEConn.Close()
        If iCounter Mod 20 = 0 Then J = iCounter \ 20 Else J = (iCounter \ 20) + 1
        For I As Integer = 1 To J
            If I = J Then
                RTR.Items.Add(K & " تا " & iCounter)
                Item = RTRO.Items.Add(K - 1)
                With Item
                    .SubItems.Add(iCounter - 1)
                End With
            Else
                RTR.Items.Add(K & " تا " & K + 19)
                Item = RTRO.Items.Add(K - 1)
                With Item
                    .SubItems.Add(K + 18)
                End With
            End If
            K = K + 20
        Next
        If RTR.Items.Count <> 0 Then RTR.SelectedIndex = Index
    End Sub

    Private Sub Get_Setting()
        DBList.Items.Clear()
        If RTR.Items.Count = 0 Then Exit Sub
        Try
            DBConn = New DBConnection
            If PutBlackCancel.Checked = False Then
                DBConn.connectMe("SELECT * FROM MoshtariList WHERE IsBlackCancel=false ORDER BY SHParvandeNum;")
            Else
                DBConn.connectMe("SELECT * FROM MoshtariList ORDER BY SHParvandeNum;")
            End If
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d.Read
                    Item = DBList.Items.Add(d("ID".ToString))
                    With Item
                        .SubItems.Add(d("MablagheGh".ToString))
                        .SubItems.Add(d("TarikheGha".ToString))
                        .SubItems.Add(d("AghsatCount".ToString))
                        .SubItems.Add(d("CGGold".ToString))
                        .SubItems.Add(d("Tell".ToString))
                        .SubItems.Add(d("MoajerFN".ToString) & " " & d("MoajerLN".ToString))
                        .SubItems.Add(d("MostajerFN".ToString) & " " & d("MostajerLN".ToString))
                        .SubItems.Add(d("SHParvandeNum".ToString))
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
        MList.Items.Clear()
        For I As Integer = RTRO.Items.Item(RTR.SelectedIndex).SubItems(0).Text To RTRO.Items.Item(RTR.SelectedIndex).SubItems(1).Text
            Item = MList.Items.Add(DBList.Items.Item(I).SubItems(0).Text)
            With Item
                .SubItems.Add(DBList.Items.Item(I).SubItems(1).Text)
                .SubItems.Add(DBList.Items.Item(I).SubItems(2).Text)
                .SubItems.Add(DBList.Items.Item(I).SubItems(3).Text)
                .SubItems.Add(DBList.Items.Item(I).SubItems(4).Text)
                .SubItems.Add(DBList.Items.Item(I).SubItems(5).Text)
                .SubItems.Add(DBList.Items.Item(I).SubItems(6).Text)
                .SubItems.Add(DBList.Items.Item(I).SubItems(7).Text)
                .SubItems.Add(DBList.Items.Item(I).SubItems(8).Text)
                .SubItems.Add(I + 1)
            End With
            Application.DoEvents()
        Next
    End Sub

    Private Sub RTR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RTR.SelectedIndexChanged
        Get_Setting()
    End Sub

    Private Sub UpdateListB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateListB.Click
        Get_Radif(RTR.SelectedIndex)
    End Sub

    Private Sub MPrintB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPrintB.Click
        If MList.Items.Count = 0 Then MessageBox("لیست مشتریان خالی است.", MsgBoxStyle.OKOnly, "چاپ لیست مشتریان") : Exit Sub
        For I As Integer = 0 To MList.Items.Count - 1
            Try
                DBConn = New DBConnection
                DBConn.connectMe("Insert Into MLReport (NUM,SHParvandeNum,Mostajer,Moajer,Tell,CGGold,AghsatCount,TarikheGha,MablagheGh,FR,TR) Values ('" & MList.Items(I).SubItems(9).Text & "', '" & MList.Items(I).SubItems(8).Text & "', '" & MList.Items(I).SubItems(7).Text & "', '" & MList.Items(I).SubItems(6).Text & "', '" & MList.Items(I).SubItems(5).Text & "', '" & MList.Items(I).SubItems(4).Text & "', '" & MList.Items(I).SubItems(3).Text & "', '" & MList.Items(I).SubItems(2).Text & "', '" & MList.Items(I).SubItems(1).Text & "', '" & (Int(RTRO.Items.Item(RTR.SelectedIndex).SubItems(0).Text) + 1) & "', '" & (Int(RTRO.Items.Item(RTR.SelectedIndex).SubItems(1).Text) + 1) & "');")
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
        Next
        If MessageBox("آیا می خواهید لیست مشتریان ردیفهای " & RTR.Text & " را چاپ کنید؟", MsgBoxStyle.SystemModal, "چاپ لیست مشتریان") = True Then
            Dim PrintForm As New PrintF
            PrintForm.WP.Text = 9
            PrintForm.ShowDialog()
        End If
        Try
            DBConn = New DBConnection
            DBConn.connectMe("Delete From MLReport;")
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
    End Sub

    Private Sub PutBlackCancel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PutBlackCancel.CheckedChanged
        Get_Radif(0)
    End Sub

    Private Sub LoadF_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadF.Tick
        LoadF.Stop()
        Get_Radif(0)
    End Sub
End Class
