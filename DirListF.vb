Public Class DirListF
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
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents UpdateListB As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DirList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MPrintB As System.Windows.Forms.Button
    Friend WithEvents LoadF As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(DirListF))
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.UpdateListB = New System.Windows.Forms.Button
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.DirList = New System.Windows.Forms.ListView
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.MPrintB = New System.Windows.Forms.Button
        Me.LoadF = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
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
        'UpdateListB
        '
        Me.UpdateListB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.UpdateListB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.UpdateListB.Location = New System.Drawing.Point(304, 288)
        Me.UpdateListB.Name = "UpdateListB"
        Me.UpdateListB.Size = New System.Drawing.Size(144, 23)
        Me.UpdateListB.TabIndex = 1
        Me.UpdateListB.Text = "به روز رسانی"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "آیدی"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "موجر"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 146
        '
        'DirList
        '
        Me.DirList.BackColor = System.Drawing.Color.DarkGray
        Me.DirList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DirList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader7, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader5})
        Me.DirList.ForeColor = System.Drawing.Color.White
        Me.DirList.FullRowSelect = True
        Me.DirList.GridLines = True
        Me.DirList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.DirList.Location = New System.Drawing.Point(0, 0)
        Me.DirList.MultiSelect = False
        Me.DirList.Name = "DirList"
        Me.DirList.Size = New System.Drawing.Size(680, 280)
        Me.DirList.TabIndex = 0
        Me.DirList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "دیرکرد - روز"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 72
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
        Me.ColumnHeader5.Width = 140
        '
        'MPrintB
        '
        Me.MPrintB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.MPrintB.Image = CType(resources.GetObject("MPrintB.Image"), System.Drawing.Image)
        Me.MPrintB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MPrintB.Location = New System.Drawing.Point(232, 288)
        Me.MPrintB.Name = "MPrintB"
        Me.MPrintB.Size = New System.Drawing.Size(64, 24)
        Me.MPrintB.TabIndex = 15
        Me.MPrintB.Text = "چاپ"
        Me.MPrintB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LoadF
        '
        Me.LoadF.Interval = 1
        '
        'DirListF
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(679, 320)
        Me.Controls.Add(Me.MPrintB)
        Me.Controls.Add(Me.UpdateListB)
        Me.Controls.Add(Me.DirList)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "DirListF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "لیست اقساط مشتریان بدهکار"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "DefIns"
    Private Shared m_vb6FormDefInstance As DirListF
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As DirListF
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New DirListF
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As DirListF)
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

    Private Sub DirListF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadF.Start()
    End Sub

    Private Sub DirList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DirList.DoubleClick
        If DirList.SelectedItems.Count > 0 Then
            Dim ViewFormM As New ViewF
            ViewFormM.SHParvandeNum.Text = DirList.SelectedItems(0).SubItems(6).Text
            ViewFormM.ShowDialog()
        End If
    End Sub

    Private Sub Get_Setting_Dir_List()
        DirList.Items.Clear()
        Dim FDate As String
        Dim TDate As String
        Try
            DBConn = New DBConnection
            DBConn.connectMe("SELECT * FROM AnyMoshtari WHERE IfPardakht=False;")
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
                                    If Dirkard(Shamsi, d1("TPardakht".ToString)) = True Then
                                        FDate = d1("TPardakht".ToString)
                                        FDate = Microsoft.VisualBasic.Left(FDate, 2) & Mid(FDate, 4, 2) & Microsoft.VisualBasic.Right(FDate, 2)
                                        TDate = Microsoft.VisualBasic.Left(Shamsi, 2) & Mid(Shamsi, 4, 2) & Microsoft.VisualBasic.Right(Shamsi, 2)
                                        Item = DirList.Items.Add(d1("ID".ToString))
                                        With Item
                                            .SubItems.Add(Diff(FDate, TDate))
                                            .SubItems.Add(d1("Tell".ToString))
                                            .SubItems.Add(d1("Mostajer".ToString))
                                            .SubItems.Add(d1("Moajer".ToString))
                                            .SubItems.Add(d1("Ghest".ToString))
                                            .SubItems.Add(d1("SHParvandeNum".ToString))
                                        End With
                                        Application.DoEvents()
                                    End If
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
        Get_Setting_Dir_List()
    End Sub

    Private Sub MPrintB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPrintB.Click
        If DirList.Items.Count = 0 Then MessageBox("لیست اقساط مشتریان بدهکار خالی است.", MsgBoxStyle.OKOnly, "چاپ لیست اقساط مشتریان بدهکار") : Exit Sub
        For I As Integer = 0 To DirList.Items.Count - 1
            Try
                DBConn = New DBConnection
                DBConn.connectMe("Insert Into DReport (SHParvandeNum,Ghest,Moajer,Mostajer,Tell,Dirkard) Values ('" & DirList.Items(I).SubItems(6).Text & "', '" & DirList.Items(I).SubItems(5).Text & "', '" & DirList.Items(I).SubItems(4).Text & "', '" & DirList.Items(I).SubItems(3).Text & "', '" & DirList.Items(I).SubItems(2).Text & "', '" & DirList.Items(I).SubItems(1).Text & "');")
                Try
                    DBConn.OLEComm.Connection = DBConn.OLEConn
                    DBConn.OLEComm.ExecuteNonQuery()
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    Exit Sub
                End Try
                Try
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    Exit Sub
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                Exit Sub
            End Try
        Next
        If MessageBox("آیا می خواهید لیست اقساط مشتریان بدهکار را چاپ کنید؟", MsgBoxStyle.SystemModal, "چاپ لیست اقساط مشتریان بدهکار") = True Then
            Dim PrintForm As New PrintF
            PrintForm.WP.Text = 3
            PrintForm.ShowDialog()
        End If
        Try
            DBConn = New DBConnection
            DBConn.connectMe("Delete From DReport;")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                DBConn.OLEComm.ExecuteNonQuery()
                DBConn.OLEConn.Close()
                Try
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    Exit Sub
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                Exit Sub
            End Try
        Catch err As System.Exception
            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            Exit Sub
        End Try
    End Sub

    Private Sub LoadF_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadF.Tick
        LoadF.Stop()
        Get_Setting_Dir_List()
    End Sub
End Class
