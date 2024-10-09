Public Class HelpListF
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
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FCLName As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents HList As System.Windows.Forms.ListView
    Friend WithEvents PutBlackCancel As System.Windows.Forms.CheckBox
    Friend WithEvents LoadF As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(HelpListF))
        Me.MPrintB = New System.Windows.Forms.Button
        Me.UpdateListB = New System.Windows.Forms.Button
        Me.HList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.FCLName = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PutBlackCancel = New System.Windows.Forms.CheckBox
        Me.LoadF = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'MPrintB
        '
        Me.MPrintB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.MPrintB.Image = CType(resources.GetObject("MPrintB.Image"), System.Drawing.Image)
        Me.MPrintB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MPrintB.Location = New System.Drawing.Point(168, 360)
        Me.MPrintB.Name = "MPrintB"
        Me.MPrintB.Size = New System.Drawing.Size(64, 24)
        Me.MPrintB.TabIndex = 18
        Me.MPrintB.Text = "چاپ"
        Me.MPrintB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UpdateListB
        '
        Me.UpdateListB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.UpdateListB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.UpdateListB.Location = New System.Drawing.Point(248, 360)
        Me.UpdateListB.Name = "UpdateListB"
        Me.UpdateListB.Size = New System.Drawing.Size(144, 23)
        Me.UpdateListB.TabIndex = 17
        Me.UpdateListB.Text = "به روز رسانی"
        '
        'HList
        '
        Me.HList.BackColor = System.Drawing.Color.DarkGray
        Me.HList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader7, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.HList.ForeColor = System.Drawing.Color.White
        Me.HList.FullRowSelect = True
        Me.HList.GridLines = True
        Me.HList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.HList.Location = New System.Drawing.Point(0, 40)
        Me.HList.MultiSelect = False
        Me.HList.Name = "HList"
        Me.HList.Size = New System.Drawing.Size(567, 312)
        Me.HList.TabIndex = 16
        Me.HList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "آیدی"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "تلفن تماس"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 114
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "شماره پرونده"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 125
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "نام خانوادگی مستاجر"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 182
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "نام مستاجر"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 145
        '
        'FCLName
        '
        Me.FCLName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FCLName.Location = New System.Drawing.Point(344, 8)
        Me.FCLName.Name = "FCLName"
        Me.FCLName.Size = New System.Drawing.Size(72, 24)
        Me.FCLName.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(416, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 24)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "حرف اول نام خانوادگی :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PutBlackCancel
        '
        Me.PutBlackCancel.Location = New System.Drawing.Point(168, 8)
        Me.PutBlackCancel.Name = "PutBlackCancel"
        Me.PutBlackCancel.Size = New System.Drawing.Size(160, 24)
        Me.PutBlackCancel.TabIndex = 21
        Me.PutBlackCancel.Text = "درج پرونده های مسدود"
        '
        'LoadF
        '
        Me.LoadF.Interval = 1
        '
        'HelpListF
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(565, 392)
        Me.Controls.Add(Me.PutBlackCancel)
        Me.Controls.Add(Me.MPrintB)
        Me.Controls.Add(Me.FCLName)
        Me.Controls.Add(Me.UpdateListB)
        Me.Controls.Add(Me.HList)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "HelpListF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "لیست راهنما"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "DefIns"
    Private Shared m_vb6FormDefInstance As HelpListF
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As HelpListF
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New HelpListF
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As HelpListF)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region

#Region "Decs"

    Dim DBConn As DBConnection
    Dim err As System.Exception
    Dim iCounter As Integer
    Dim Item As ListViewItem

#End Region

    Private Sub HelpListF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadF.Start()
    End Sub

    Private Sub Get_Alefba()
        FCLName.Items.Add("الف")
        FCLName.Items.Add("ب")
        FCLName.Items.Add("پ")
        FCLName.Items.Add("ت")
        FCLName.Items.Add("ث")
        FCLName.Items.Add("ج")
        FCLName.Items.Add("چ")
        FCLName.Items.Add("ح")
        FCLName.Items.Add("خ")
        FCLName.Items.Add("د")
        FCLName.Items.Add("ذ")
        FCLName.Items.Add("ر")
        FCLName.Items.Add("ز")
        FCLName.Items.Add("ژ")
        FCLName.Items.Add("س")
        FCLName.Items.Add("ش")
        FCLName.Items.Add("ص")
        FCLName.Items.Add("ض")
        FCLName.Items.Add("ط")
        FCLName.Items.Add("ظ")
        FCLName.Items.Add("ع")
        FCLName.Items.Add("غ")
        FCLName.Items.Add("ف")
        FCLName.Items.Add("ق")
        FCLName.Items.Add("ک")
        FCLName.Items.Add("گ")
        FCLName.Items.Add("ل")
        FCLName.Items.Add("م")
        FCLName.Items.Add("ن")
        FCLName.Items.Add("و")
        FCLName.Items.Add("ه")
        FCLName.Items.Add("ی")
        FCLName.SelectedIndex = 0
    End Sub

    Private Sub FCLName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FCLName.SelectedIndexChanged
        Get_Setting()
    End Sub

    Private Sub Get_Setting()
        HList.Items.Clear()
        Try
            DBConn = New DBConnection
            If PutBlackCancel.Checked = False Then
                DBConn.connectMe("SELECT * FROM MoshtariList WHERE IsBlackCancel=false ORDER BY MostajerLN;")
            Else
                DBConn.connectMe("SELECT * FROM MoshtariList ORDER BY MostajerLN;")
            End If
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d.Read
                    If FCLName.Text = "الف" Then
                        If Microsoft.VisualBasic.Left(d("MostajerLN".ToString), 1) = "آ" Or Microsoft.VisualBasic.Left(d("MostajerLN".ToString), 1) = "ا" Then
                            Item = HList.Items.Add(d("ID".ToString))
                            With Item
                                .SubItems.Add(d("Tell".ToString))
                                .SubItems.Add(d("SHParvandeNum".ToString))
                                .SubItems.Add(d("MostajerLN".ToString))
                                .SubItems.Add(d("MostajerFN".ToString))
                            End With
                            Application.DoEvents()
                        End If
                    Else
                        If Microsoft.VisualBasic.Left(d("MostajerLN".ToString), 1) = FCLName.Text Then
                            Item = HList.Items.Add(d("ID".ToString))
                            With Item
                                .SubItems.Add(d("Tell".ToString))
                                .SubItems.Add(d("SHParvandeNum".ToString))
                                .SubItems.Add(d("MostajerLN".ToString))
                                .SubItems.Add(d("MostajerFN".ToString))
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
    End Sub

    Private Sub UpdateListB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateListB.Click
        Get_Setting()
    End Sub

    Private Sub MPrintB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPrintB.Click
        If HList.Items.Count = 0 Then MessageBox("لیست راهنما خالی است.", MsgBoxStyle.OKOnly, "چاپ لیست راهنما") : Exit Sub
        For I As Integer = 0 To HList.Items.Count - 1
            Try
                DBConn = New DBConnection
                DBConn.connectMe("Insert Into HeReport (SHParvandeNum,MostajerFN,MostajerLN,CGGold,MCH) Values ('" & HList.Items(I).SubItems(2).Text & "', '" & HList.Items(I).SubItems(4).Text & "', '" & HList.Items(I).SubItems(3).Text & "', '" & HList.Items(I).SubItems(1).Text & "', '" & FCLName.Text & "');")
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
        If MessageBox("آیا می خواهید لیست راهنمای مربوط به حرف " & FCLName.Text & " را چاپ کنید؟", MsgBoxStyle.SystemModal, "چاپ لیست راهنما") = True Then
            Dim PrintForm As New PrintF
            PrintForm.WP.Text = 6
            PrintForm.ShowDialog()
        End If
        Try
            DBConn = New DBConnection
            DBConn.connectMe("Delete From HeReport;")
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
        Get_Setting()
    End Sub

    Private Sub LoadF_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadF.Tick
        LoadF.Stop()
        Get_Alefba()
    End Sub
End Class
