Public Class GhPrintF
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
    Friend WithEvents UnSGLList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader45 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader48 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader49 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader50 As System.Windows.Forms.ColumnHeader
    Friend WithEvents UnSGRList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents AddB As System.Windows.Forms.Button
    Friend WithEvents EditB As System.Windows.Forms.Button
    Friend WithEvents DeleteB As System.Windows.Forms.Button
    Friend WithEvents RefreshB As System.Windows.Forms.Button
    Friend WithEvents PrintB As System.Windows.Forms.Button
    Friend WithEvents GHNum As System.Windows.Forms.TextBox
    Friend WithEvents SG As System.Windows.Forms.TextBox
    Friend WithEvents CheckB As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GoldCount As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(GhPrintF))
        Me.UnSGLList = New System.Windows.Forms.ListView
        Me.ColumnHeader45 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader48 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader49 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader50 = New System.Windows.Forms.ColumnHeader
        Me.UnSGRList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.AddB = New System.Windows.Forms.Button
        Me.EditB = New System.Windows.Forms.Button
        Me.DeleteB = New System.Windows.Forms.Button
        Me.RefreshB = New System.Windows.Forms.Button
        Me.PrintB = New System.Windows.Forms.Button
        Me.GHNum = New System.Windows.Forms.TextBox
        Me.SG = New System.Windows.Forms.TextBox
        Me.CheckB = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GoldCount = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'UnSGLList
        '
        Me.UnSGLList.BackColor = System.Drawing.Color.DarkGray
        Me.UnSGLList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UnSGLList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader45, Me.ColumnHeader48, Me.ColumnHeader49, Me.ColumnHeader50})
        Me.UnSGLList.ForeColor = System.Drawing.Color.White
        Me.UnSGLList.FullRowSelect = True
        Me.UnSGLList.GridLines = True
        Me.UnSGLList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.UnSGLList.Location = New System.Drawing.Point(0, 0)
        Me.UnSGLList.MultiSelect = False
        Me.UnSGLList.Name = "UnSGLList"
        Me.UnSGLList.Size = New System.Drawing.Size(336, 352)
        Me.UnSGLList.TabIndex = 1
        Me.UnSGLList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader45
        '
        Me.ColumnHeader45.Text = "آیدی"
        Me.ColumnHeader45.Width = 0
        '
        'ColumnHeader48
        '
        Me.ColumnHeader48.Text = "مستاجر"
        Me.ColumnHeader48.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader48.Width = 130
        '
        'ColumnHeader49
        '
        Me.ColumnHeader49.Text = "شماره پرونده"
        Me.ColumnHeader49.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader49.Width = 89
        '
        'ColumnHeader50
        '
        Me.ColumnHeader50.Text = "مقدار گرم طلا"
        Me.ColumnHeader50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader50.Width = 92
        '
        'UnSGRList
        '
        Me.UnSGRList.BackColor = System.Drawing.Color.DarkGray
        Me.UnSGRList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UnSGRList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.UnSGRList.ForeColor = System.Drawing.Color.White
        Me.UnSGRList.FullRowSelect = True
        Me.UnSGRList.GridLines = True
        Me.UnSGRList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.UnSGRList.Location = New System.Drawing.Point(339, 0)
        Me.UnSGRList.MultiSelect = False
        Me.UnSGRList.Name = "UnSGRList"
        Me.UnSGRList.Size = New System.Drawing.Size(336, 352)
        Me.UnSGRList.TabIndex = 0
        Me.UnSGRList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "آیدی"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "مستاجر"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 130
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "شماره پرونده"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 89
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "مقدار گرم طلا"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 92
        '
        'AddB
        '
        Me.AddB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.AddB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AddB.Location = New System.Drawing.Point(560, 392)
        Me.AddB.Name = "AddB"
        Me.AddB.Size = New System.Drawing.Size(104, 24)
        Me.AddB.TabIndex = 2
        Me.AddB.Text = "اضافه کردن"
        '
        'EditB
        '
        Me.EditB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.EditB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.EditB.Location = New System.Drawing.Point(448, 392)
        Me.EditB.Name = "EditB"
        Me.EditB.Size = New System.Drawing.Size(104, 23)
        Me.EditB.TabIndex = 3
        Me.EditB.Text = "ویرایش"
        '
        'DeleteB
        '
        Me.DeleteB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.DeleteB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DeleteB.Location = New System.Drawing.Point(336, 392)
        Me.DeleteB.Name = "DeleteB"
        Me.DeleteB.Size = New System.Drawing.Size(104, 23)
        Me.DeleteB.TabIndex = 4
        Me.DeleteB.Text = "حذف"
        '
        'RefreshB
        '
        Me.RefreshB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.RefreshB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RefreshB.Location = New System.Drawing.Point(112, 392)
        Me.RefreshB.Name = "RefreshB"
        Me.RefreshB.Size = New System.Drawing.Size(104, 23)
        Me.RefreshB.TabIndex = 6
        Me.RefreshB.Text = "به روز رسانی"
        '
        'PrintB
        '
        Me.PrintB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.PrintB.Image = CType(resources.GetObject("PrintB.Image"), System.Drawing.Image)
        Me.PrintB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PrintB.Location = New System.Drawing.Point(8, 392)
        Me.PrintB.Name = "PrintB"
        Me.PrintB.Size = New System.Drawing.Size(96, 24)
        Me.PrintB.TabIndex = 7
        Me.PrintB.Text = "چاپ قرارداد"
        Me.PrintB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GHNum
        '
        Me.GHNum.Location = New System.Drawing.Point(-8, 408)
        Me.GHNum.Name = "GHNum"
        Me.GHNum.Size = New System.Drawing.Size(40, 23)
        Me.GHNum.TabIndex = 29
        Me.GHNum.Text = ""
        Me.GHNum.Visible = False
        '
        'SG
        '
        Me.SG.Location = New System.Drawing.Point(32, 408)
        Me.SG.Name = "SG"
        Me.SG.Size = New System.Drawing.Size(40, 23)
        Me.SG.TabIndex = 30
        Me.SG.Text = ""
        Me.SG.Visible = False
        '
        'CheckB
        '
        Me.CheckB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.CheckB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckB.Location = New System.Drawing.Point(224, 392)
        Me.CheckB.Name = "CheckB"
        Me.CheckB.Size = New System.Drawing.Size(104, 24)
        Me.CheckB.TabIndex = 5
        Me.CheckB.Text = "بررسی"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(536, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "مقدار کل طلا - گرم :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GoldCount
        '
        Me.GoldCount.BackColor = System.Drawing.Color.White
        Me.GoldCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GoldCount.Location = New System.Drawing.Point(408, 360)
        Me.GoldCount.Name = "GoldCount"
        Me.GoldCount.Size = New System.Drawing.Size(128, 23)
        Me.GoldCount.TabIndex = 32
        Me.GoldCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GhPrintF
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(674, 424)
        Me.Controls.Add(Me.GoldCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckB)
        Me.Controls.Add(Me.PrintB)
        Me.Controls.Add(Me.RefreshB)
        Me.Controls.Add(Me.DeleteB)
        Me.Controls.Add(Me.EditB)
        Me.Controls.Add(Me.AddB)
        Me.Controls.Add(Me.UnSGRList)
        Me.Controls.Add(Me.UnSGLList)
        Me.Controls.Add(Me.SG)
        Me.Controls.Add(Me.GHNum)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "GhPrintF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "چاپ قرارداد"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "DefIns"
    Private Shared m_vb6FormDefInstance As GhPrintF
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As GhPrintF
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New GhPrintF
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As GhPrintF)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region

#Region "Decs"

    Dim DBConn As DBConnection
    Dim err As System.Exception
    Dim iCounter As Integer
    Dim Item As ListViewItem
    Dim RL As Boolean = False
    Dim LL As Boolean = False
    Dim Ex As Boolean

#End Region

    Private Sub GhPrintF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SG.Text = GhPrintFormSG
        GHNum.Text = GhPrintFormGHNum
        Get_Setting()
    End Sub

    Private Sub Get_Setting()
        Dim I As Integer = 0
        Dim GoldC As Double = 0
        UnSGRList.Items.Clear()
        UnSGLList.Items.Clear()
        Try
            DBConn = New DBConnection
            DBConn.connectMe("SELECT * FROM AnySGozari WHERE GharardadNum='" & GHNum.Text & "';")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d.Read
                    I = I + 1
                    Select Case I Mod 2
                        Case 0
                            Item = UnSGLList.Items.Add(d("ID".ToString))
                            With Item
                                .SubItems.Add(d("Mostajer".ToString))
                                .SubItems.Add(d("SHParvandeNum".ToString))
                                .SubItems.Add(d("CGGold".ToString))
                                GoldC += d("CGGold".ToString)
                            End With
                        Case 1
                            Item = UnSGRList.Items.Add(d("ID".ToString))
                            With Item
                                .SubItems.Add(d("Mostajer".ToString))
                                .SubItems.Add(d("SHParvandeNum".ToString))
                                .SubItems.Add(d("CGGold".ToString))
                                GoldC += d("CGGold".ToString)
                            End With
                    End Select
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
        GoldCount.Text = GoldC
    End Sub

    Private Sub AddB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddB.Click
        Dim UnSGAddForm As New UnSGAddF
        UnSGAddForm.GHNum.Text = GHNum.Text
        UnSGAddForm.Sarmaiegozar.Text = SG.Text
        UnSGAddForm.ShowDialog()
        Get_Setting()
    End Sub

    Private Sub DeleteB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteB.Click
        If UnSGRList.SelectedItems.Count <> 0 Or UnSGLList.SelectedItems.Count <> 0 Then
            If MessageBox("آیا می خواهید خط موبایل مورد نظر را حذف کنید؟ ", MsgBoxStyle.YesNo, "بخش سرمایه گذاری") = True Then
                If UnSGRList.SelectedItems.Count <> 0 And UnSGLList.SelectedItems.Count <> 0 Then
                    If RL = True Then
                        Try
                            DBConn = New DBConnection
                            DBConn.connectMe("Delete From AnySGozari WHERE ID = " & UnSGRList.SelectedItems(0).SubItems(0).Text & ";")
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
                    Else
                        Try
                            DBConn = New DBConnection
                            DBConn.connectMe("Delete From AnySGozari WHERE ID = " & UnSGLList.SelectedItems(0).SubItems(0).Text & ";")
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
                    End If
                Else
                    If UnSGRList.SelectedItems.Count <> 0 Then
                        Try
                            DBConn = New DBConnection
                            DBConn.connectMe("Delete From AnySGozari WHERE ID = " & UnSGRList.SelectedItems(0).SubItems(0).Text & ";")
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
                    Else
                        Try
                            DBConn = New DBConnection
                            DBConn.connectMe("Delete From AnySGozari WHERE ID = " & UnSGLList.SelectedItems(0).SubItems(0).Text & ";")
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
                    End If
                End If
                Get_Setting()
            End If
        Else
            MessageBox("برای حذف خط موبایل لطفا ابتدا خط موبایل مورد نطر را انتخاب کنید.", MsgBoxStyle.OKOnly, "بخش سرمایه گذاری")
        End If
    End Sub

    Private Sub UnSGRList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UnSGRList.Click
        RL = True
        LL = False
    End Sub

    Private Sub UnSGLList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UnSGLList.Click
        LL = True
        RL = False
    End Sub

    Private Sub RefreshB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshB.Click
        Dim ID As String
        Try
            DBConn = New DBConnection
            DBConn.connectMe("SELECT * FROM MoshtariList WHERE IsBlackCancel=False ORDER BY SHParvandeNum;")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d.Read
                    If SG.Text = d("MoajerFN".ToString) & " " & d("MoajerLN".ToString) Then
                        Ex = False
                        For I As Integer = 0 To UnSGRList.Items.Count - 1
                            If UnSGRList.Items.Item(I).SubItems(2).Text = d("SHParvandeNum".ToString) Then Ex = True : ID = UnSGRList.Items.Item(I).SubItems(0).Text : GoTo [Continue]
                        Next
                        For J As Integer = 0 To UnSGLList.Items.Count - 1
                            If UnSGLList.Items.Item(J).SubItems(2).Text = d("SHParvandeNum".ToString) Then Ex = True : ID = UnSGLList.Items.Item(J).SubItems(0).Text : GoTo [Continue]
                        Next
[Continue]:
                        If Ex = False Then
                            Try
                                DBConn = New DBConnection
                                DBConn.connectMe("Insert Into AnySGozari (GharardadNum,CGGold,SHParvandeNum,Mostajer) Values ('" & GHNum.Text & "', '" & d("CGGold".ToString) & "', '" & d("SHParvandeNum".ToString) & "', '" & d("MostajerFN".ToString) & " " & d("MostajerLN".ToString) & "');")
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
                        Else
                            Try
                                DBConn = New DBConnection
                                DBConn.connectMe("Update AnySGozari SET GharardadNum='" & GHNum.Text & "',CGGold='" & d("CGGold".ToString) & "',SHParvandeNum='" & d("SHParvandeNum".ToString) & "',Mostajer='" & d("MostajerFN".ToString) & " " & d("MostajerLN".ToString) & "' WHERE ID=" & ID & ";")
                                DBConn.OLEComm.Connection = DBConn.OLEConn
                                DBConn.OLEComm.ExecuteNonQuery()
                                DBConn.OLEConn.Close()
                            Catch err As System.Exception
                                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                            End Try
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
        Get_Setting()
    End Sub

    Private Sub PrintB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintB.Click
        'If UnSGRList.Items.Count = 0 And UnSGLList.Items.Count = 0 Then MessageBox("لیست روزانه اقساط مشتریان خالی است.", MsgBoxStyle.OKOnly, "چاپ لیست روزانه اقساط مشتریان") : Exit Sub
        Dim Male, Female, FT, TT, MC As String
        Dim GG As Double
        MC = UnSGRList.Items.Count + UnSGLList.Items.Count
        For I As Integer = 0 To UnSGRList.Items.Count - 1
            GG += CDbl(UnSGRList.Items.Item(I).SubItems(3).Text)
        Next
        For I As Integer = 0 To UnSGLList.Items.Count - 1
            GG += CDbl(UnSGLList.Items.Item(I).SubItems(3).Text)
        Next
        Try
            DBConn = New DBConnection
            DBConn.connectMe("SELECT * FROM SGozari WHERE GharardadNum=" & GHNum.Text & ";")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d.Read
                    If d("Male".ToString) = True Then Male = "" Else Male = "X"
                    If d("Female".ToString) = True Then Female = "" Else Female = "X"
                    FT = Microsoft.VisualBasic.Right(d("FT".ToString), 2) & "/" & Mid(d("FT".ToString), 4, 2) & "/" & Microsoft.VisualBasic.Left(d("FT".ToString), 2)
                    TT = Microsoft.VisualBasic.Right(d("TT".ToString), 2) & "/" & Mid(d("TT".ToString), 4, 2) & "/" & Microsoft.VisualBasic.Left(d("TT".ToString), 2)
                    Try
                        DBConn = New DBConnection
                        DBConn.connectMe("Insert Into SGReport (Sarmaiegozar,Farzand,SHenasnameNum,Sadereh,YBirth,Addrress,FT,TT,Mablagh,Mahiane,Male,Female,MoshtariCount,GGold) Values ('" & d("SFName".ToString) & " " & d("SLName".ToString) & "', '" & d("Farzand".ToString) & "', '" & d("SHenasnameNum".ToString) & "', '" & d("Sadereh".ToString) & "', '" & d("YBirth".ToString) & "', '" & d("Addrress".ToString) & "', '" & FT & "', '" & TT & "', '" & d("Mablagh".ToString) & "', '" & d("Mahiane".ToString) & "', '" & Male & "', '" & Female & "', '" & MC & "', '" & GG & "');")
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
        For I As Integer = 0 To UnSGRList.Items.Count - 1
            Try
                DBConn = New DBConnection
                If I = UnSGRList.Items.Count - 1 And UnSGRList.Items.Count <> UnSGLList.Items.Count Then
                    DBConn.connectMe("Insert Into UnSGReport (NumR,CGGoldR,SHParvandeNumR,MostajerR) Values ('" & ((I * 2) + 1) & "', '" & UnSGRList.Items(I).SubItems(3).Text & "', '" & UnSGRList.Items(I).SubItems(2).Text & "', '" & UnSGRList.Items(I).SubItems(1).Text & "');")
                Else
                    DBConn.connectMe("Insert Into UnSGReport (NumR,CGGoldR,SHParvandeNumR,MostajerR,NumL,CGGoldL,SHParvandeNumL,MostajerL) Values ('" & ((I * 2) + 1) & "', '" & UnSGRList.Items(I).SubItems(3).Text & "', '" & UnSGRList.Items(I).SubItems(2).Text & "', '" & UnSGRList.Items(I).SubItems(1).Text & "', '" & ((I * 2) + 2) & "', '" & UnSGLList.Items(I).SubItems(3).Text & "', '" & UnSGLList.Items(I).SubItems(2).Text & "', '" & UnSGLList.Items(I).SubItems(1).Text & "');")
                End If
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
        If MessageBox("آیا می خواهید قرارداد سرمایه کذار را چاپ کنید؟", MsgBoxStyle.SystemModal, "چاپ قرارداد سرمایه گذاری") = True Then
            Dim PrintForm As New PrintF
            PrintForm.WP.Text = 14
            PrintForm.ShowDialog()
        End If
        Try
            DBConn = New DBConnection
            DBConn.connectMe("Delete From SGReport;")
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
        Try
            DBConn = New DBConnection
            DBConn.connectMe("Delete From UnSGReport;")
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

    Private Sub EditB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditB.Click
        If UnSGRList.SelectedItems.Count <> 0 Or UnSGLList.SelectedItems.Count <> 0 Then
            Dim UnSGEditForm As New UnSGEditF
            If UnSGRList.SelectedItems.Count <> 0 And UnSGLList.SelectedItems.Count <> 0 Then
                If RL = True Then
                    UnSGEditForm.ID.Text = UnSGRList.SelectedItems(0).SubItems(0).Text
                Else
                    UnSGEditForm.ID.Text = UnSGLList.SelectedItems(0).SubItems(0).Text
                End If
            Else
                If UnSGRList.SelectedItems.Count <> 0 Then
                    UnSGEditForm.ID.Text = UnSGRList.SelectedItems(0).SubItems(0).Text
                Else
                    UnSGEditForm.ID.Text = UnSGLList.SelectedItems(0).SubItems(0).Text
                End If
            End If
            UnSGEditForm.Sarmaiegozar.Text = SG.Text
            UnSGEditForm.ShowDialog()
            Get_Setting()
        Else
            MessageBox("برای ویرایش خط موبایل لطفا ابتدا خط موبایل مورد نطر را انتخاب کنید.", MsgBoxStyle.OKOnly, "بخش سرمایه گذاری")
        End If
    End Sub

    Private Sub CheckB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckB.Click
        Dim CheckForm As New CheckF
        CheckForm.ShowDialog()
        UnSGRList.BackColor = System.Drawing.Color.DarkGray
        UnSGLList.BackColor = System.Drawing.Color.DarkGray
        Dim Exist As Boolean
        For I As Integer = 0 To CheckForm.CGGoldList.Items.Count - 1
            Exist = False
            For J As Integer = 0 To UnSGRList.Items.Count - 1
                If CheckForm.CGGoldList.Items.Item(I) = UnSGRList.Items(J).SubItems(3).Text And UnSGRList.Items(J).BackColor.Name.ToString <> "Goldenrod" Then
                    UnSGRList.Items(J).BackColor = System.Drawing.Color.Goldenrod
                    Exist = True
                    GoTo Continue1
                End If
            Next
            For J As Integer = 0 To UnSGLList.Items.Count - 1
                If CheckForm.CGGoldList.Items.Item(I) = UnSGLList.Items(J).SubItems(3).Text And UnSGLList.Items(J).BackColor.Name.ToString <> "Goldenrod" Then
                    UnSGLList.Items(J).BackColor = System.Drawing.Color.Goldenrod
                    Exist = True
                    GoTo Continue1
                End If
            Next
Continue1:
            If Exist = False Then
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("Insert Into AnySGozari (GharardadNum,CGGold,SHParvandeNum,Mostajer) Values ('" & GHNum.Text & "', '" & CheckForm.CGGoldList.Items.Item(I) & "', '', '');")
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
            End If
        Next
        Get_Setting()
        For I As Integer = 0 To CheckForm.CGGoldList.Items.Count - 1
            For J As Integer = 0 To UnSGRList.Items.Count - 1
                If CheckForm.CGGoldList.Items.Item(I) = UnSGRList.Items(J).SubItems(3).Text And UnSGRList.Items(J).BackColor.Name.ToString <> "Goldenrod" Then
                    UnSGRList.Items(J).BackColor = System.Drawing.Color.Goldenrod
                    GoTo Continue2
                End If
            Next
            For J As Integer = 0 To UnSGLList.Items.Count - 1
                If CheckForm.CGGoldList.Items.Item(I) = UnSGLList.Items(J).SubItems(3).Text And UnSGLList.Items(J).BackColor.Name.ToString <> "Goldenrod" Then
                    UnSGLList.Items(J).BackColor = System.Drawing.Color.Goldenrod
                    GoTo Continue2
                End If
            Next
Continue2:
        Next
    End Sub
End Class
