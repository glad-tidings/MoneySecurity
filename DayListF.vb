Public Class DayListF
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
    Friend WithEvents UpdateListB As System.Windows.Forms.Button
    Friend WithEvents MPrintB As System.Windows.Forms.Button
    Friend WithEvents DayList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LoadF As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(DayListF))
        Me.UpdateListB = New System.Windows.Forms.Button
        Me.MPrintB = New System.Windows.Forms.Button
        Me.DayList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.LoadF = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'UpdateListB
        '
        Me.UpdateListB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.UpdateListB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.UpdateListB.Location = New System.Drawing.Point(272, 264)
        Me.UpdateListB.Name = "UpdateListB"
        Me.UpdateListB.Size = New System.Drawing.Size(144, 23)
        Me.UpdateListB.TabIndex = 1
        Me.UpdateListB.Text = "به روز رسانی"
        '
        'MPrintB
        '
        Me.MPrintB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.MPrintB.Image = CType(resources.GetObject("MPrintB.Image"), System.Drawing.Image)
        Me.MPrintB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MPrintB.Location = New System.Drawing.Point(192, 264)
        Me.MPrintB.Name = "MPrintB"
        Me.MPrintB.Size = New System.Drawing.Size(64, 24)
        Me.MPrintB.TabIndex = 14
        Me.MPrintB.Text = "چاپ"
        Me.MPrintB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DayList
        '
        Me.DayList.BackColor = System.Drawing.Color.DarkGray
        Me.DayList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DayList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader5})
        Me.DayList.ForeColor = System.Drawing.Color.White
        Me.DayList.FullRowSelect = True
        Me.DayList.GridLines = True
        Me.DayList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.DayList.Location = New System.Drawing.Point(0, 0)
        Me.DayList.MultiSelect = False
        Me.DayList.Name = "DayList"
        Me.DayList.Size = New System.Drawing.Size(610, 256)
        Me.DayList.TabIndex = 16
        Me.DayList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "آیدی"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "تلفن تماس"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 115
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "مستاجر"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 160
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "موجر"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 147
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "قسط"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 47
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "شماره پرونده"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 141
        '
        'LoadF
        '
        Me.LoadF.Interval = 1
        '
        'DayListF
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(609, 296)
        Me.Controls.Add(Me.DayList)
        Me.Controls.Add(Me.MPrintB)
        Me.Controls.Add(Me.UpdateListB)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "DayListF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "لیست روزانه اقساط مشتریان"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "DefIns"
    Private Shared m_vb6FormDefInstance As DayListF
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As DayListF
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New DayListF
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As DayListF)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region

#Region "Decs"

    Dim DBConn As DBConnection
    Dim err As System.Exception
    Dim iCounter As Integer
    Dim Item As ListViewItem
    Dim TabC(6) As Boolean
    Dim IFNE As Boolean = False

#End Region

    Private Sub DayListF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadF.Start()
    End Sub

    Private Sub DayList_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If DayList.SelectedItems.Count > 0 Then
            Dim ViewFormM As New ViewF
            ViewFormM.SHParvandeNum.Text = DayList.SelectedItems(0).SubItems(5).Text
            ViewFormM.ShowDialog()
        End If
    End Sub

    Private Sub Get_Setting_Day_List()
        DayList.Items.Clear()
        Try
            DBConn = New DBConnection
            DBConn.connectMe("SELECT * FROM AnyMoshtari WHERE TPardakht='" & Shamsi() & "' and IfPardakht=false ORDER BY SHParvandeNum;")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d1 As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d1.Read
                    Try
                        DBConn = New DBConnection
                        DBConn.connectMe("SELECT * FROM MoshtariList WHERE SHParvandeNum=" & d1("SHParvandeNum".ToString) & ";")
                        Try
                            DBConn.OLEComm.Connection = DBConn.OLEConn
                            Dim d2 As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                            Do While d2.Read
                                If d2("IsBlackCancel".ToString) = False Then
                                    Item = DayList.Items.Add(d1("ID".ToString))
                                    With Item
                                        .SubItems.Add(d1("Tell".ToString))
                                        .SubItems.Add(d1("Mostajer".ToString))
                                        .SubItems.Add(d1("Moajer".ToString))
                                        .SubItems.Add(d1("Ghest".ToString))
                                        .SubItems.Add(d1("SHParvandeNum".ToString))
                                    End With
                                    Application.DoEvents()
                                End If
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

    Private Sub UpdateListB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateListB.Click
        Get_Setting_Day_List()
    End Sub

    Private Sub MPrintB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPrintB.Click
        If DayList.Items.Count = 0 Then MessageBox("لیست روزانه اقساط مشتریان خالی است.", MsgBoxStyle.OKOnly, "چاپ لیست روزانه اقساط مشتریان") : Exit Sub
        For I As Integer = 0 To DayList.Items.Count - 1
            Try
                DBConn = New DBConnection
                DBConn.connectMe("Insert Into DaReport (SHParvandeNum,Ghest,Moajer,Mostajer,Tell) Values ('" & DayList.Items(I).SubItems(5).Text & "', '" & DayList.Items(I).SubItems(4).Text & "', '" & DayList.Items(I).SubItems(3).Text & "', '" & DayList.Items(I).SubItems(2).Text & "', '" & DayList.Items(I).SubItems(1).Text & "');")
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
        If MessageBox("آیا می خواهید لیست روزانه اقساط مشتریان را چاپ کنید؟", MsgBoxStyle.SystemModal, "چاپ لیست روزانه اقساط مشتریان") = True Then
            Dim PrintForm As New PrintF
            PrintForm.WP.Text = 4
            PrintForm.ShowDialog()
        End If
        Try
            DBConn = New DBConnection
            DBConn.connectMe("Delete From DaReport;")
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

    Private Sub LoadF_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadF.Tick
        LoadF.Stop()
        Get_Setting_Day_List()
    End Sub
End Class
