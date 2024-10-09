Public Class ViewF
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
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents AMList As System.Windows.Forms.ListView
    Friend WithEvents SHParvandeNum As System.Windows.Forms.TextBox
    Friend WithEvents MoveB As System.Windows.Forms.Button
    Friend WithEvents IsArchive As System.Windows.Forms.CheckBox
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PeGet As System.Windows.Forms.TextBox
    Friend WithEvents MPrintB As System.Windows.Forms.Button
    Friend WithEvents DeleteB As System.Windows.Forms.Button
    Friend WithEvents CancelMoveB As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ViewF))
        Me.AMList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.SHParvandeNum = New System.Windows.Forms.TextBox
        Me.MoveB = New System.Windows.Forms.Button
        Me.IsArchive = New System.Windows.Forms.CheckBox
        Me.PeGet = New System.Windows.Forms.TextBox
        Me.MPrintB = New System.Windows.Forms.Button
        Me.DeleteB = New System.Windows.Forms.Button
        Me.CancelMoveB = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'AMList
        '
        Me.AMList.BackColor = System.Drawing.Color.DarkGray
        Me.AMList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AMList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader12, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.AMList.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.AMList.ForeColor = System.Drawing.Color.White
        Me.AMList.FullRowSelect = True
        Me.AMList.GridLines = True
        Me.AMList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.AMList.Location = New System.Drawing.Point(0, 0)
        Me.AMList.MultiSelect = False
        Me.AMList.Name = "AMList"
        Me.AMList.Size = New System.Drawing.Size(915, 160)
        Me.AMList.TabIndex = 0
        Me.AMList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "آیدی"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "پرداختی"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader12.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "جمع پرداخت"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "مبلغ دیرکرد"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "تاریخ وصول"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "تاریخ پرداخت"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 86
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "تلفن تماس"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 102
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "اقساط"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 53
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "مبلغ"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 94
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "مستاجر"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 130
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "موجر"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader10.Width = 124
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "قسط"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader11.Width = 46
        '
        'SHParvandeNum
        '
        Me.SHParvandeNum.Location = New System.Drawing.Point(0, 192)
        Me.SHParvandeNum.Name = "SHParvandeNum"
        Me.SHParvandeNum.Size = New System.Drawing.Size(32, 23)
        Me.SHParvandeNum.TabIndex = 3
        Me.SHParvandeNum.TabStop = False
        Me.SHParvandeNum.Text = ""
        Me.SHParvandeNum.Visible = False
        '
        'MoveB
        '
        Me.MoveB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.MoveB.Enabled = False
        Me.MoveB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MoveB.Location = New System.Drawing.Point(584, 168)
        Me.MoveB.Name = "MoveB"
        Me.MoveB.Size = New System.Drawing.Size(208, 24)
        Me.MoveB.TabIndex = 1
        Me.MoveB.Text = "فرستادن به لیست بایگانی"
        '
        'IsArchive
        '
        Me.IsArchive.Location = New System.Drawing.Point(32, 192)
        Me.IsArchive.Name = "IsArchive"
        Me.IsArchive.Size = New System.Drawing.Size(16, 16)
        Me.IsArchive.TabIndex = 4
        Me.IsArchive.TabStop = False
        Me.IsArchive.Visible = False
        '
        'PeGet
        '
        Me.PeGet.Location = New System.Drawing.Point(48, 192)
        Me.PeGet.Name = "PeGet"
        Me.PeGet.Size = New System.Drawing.Size(32, 23)
        Me.PeGet.TabIndex = 5
        Me.PeGet.TabStop = False
        Me.PeGet.Text = ""
        Me.PeGet.Visible = False
        '
        'MPrintB
        '
        Me.MPrintB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.MPrintB.Image = CType(resources.GetObject("MPrintB.Image"), System.Drawing.Image)
        Me.MPrintB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MPrintB.Location = New System.Drawing.Point(120, 168)
        Me.MPrintB.Name = "MPrintB"
        Me.MPrintB.Size = New System.Drawing.Size(64, 24)
        Me.MPrintB.TabIndex = 4
        Me.MPrintB.Text = "چاپ"
        Me.MPrintB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DeleteB
        '
        Me.DeleteB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.DeleteB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DeleteB.Location = New System.Drawing.Point(200, 168)
        Me.DeleteB.Name = "DeleteB"
        Me.DeleteB.Size = New System.Drawing.Size(128, 24)
        Me.DeleteB.TabIndex = 3
        Me.DeleteB.Text = "حذف پرداخت"
        '
        'CancelMoveB
        '
        Me.CancelMoveB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.CancelMoveB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CancelMoveB.Location = New System.Drawing.Point(344, 168)
        Me.CancelMoveB.Name = "CancelMoveB"
        Me.CancelMoveB.Size = New System.Drawing.Size(224, 24)
        Me.CancelMoveB.TabIndex = 2
        Me.CancelMoveB.Text = "لغو حساب و انتقال به بایگانی"
        '
        'ViewF
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(914, 200)
        Me.Controls.Add(Me.CancelMoveB)
        Me.Controls.Add(Me.DeleteB)
        Me.Controls.Add(Me.MPrintB)
        Me.Controls.Add(Me.PeGet)
        Me.Controls.Add(Me.SHParvandeNum)
        Me.Controls.Add(Me.MoveB)
        Me.Controls.Add(Me.IsArchive)
        Me.Controls.Add(Me.AMList)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نمایش اطلاعات مشتری"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Decs"
    Dim DBConn As DBConnection
    Dim err As System.Exception
    Dim iCounter As Integer
    Dim Item As ListViewItem
    Public CancelP As Boolean = False
#End Region

    Private Sub ViewF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Get_Setting()
        AMList.Height = 23 + (AMList.Items.Count * 17)
        If AMList.Height > 471 Then AMList.Height = 465
        Select Case IsArchive.Checked
            Case True
                Me.Height = AMList.Height + 32
                MoveB.Visible = False
                CancelMoveB.Visible = False
                MPrintB.Visible = False
                DeleteB.Visible = False
            Case False
                Me.Height = AMList.Height + 75
                MoveB.Top = Me.Height - 65
                CancelMoveB.Top = Me.Height - 65
                MPrintB.Top = Me.Height - 65
                DeleteB.Top = Me.Height - 65
        End Select
        Me.Text = "نمایش اطلاعات مشتری به شماره پرونده " & SHParvandeNum.Text
        If IsArchive.Checked = False Then
            For I As Integer = 0 To AMList.Items.Count - 1
                If AMList.Items(I).SubItems(1).Text = "False" Then Exit Sub
            Next
            MoveB.Enabled = True
        End If
    End Sub

    Private Sub AMList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AMList.DoubleClick
        If AMList.SelectedItems.Count > 0 Then
            Dim EditViewForm As New EditViewF
            EditViewForm.SHParvandeNum.Text = SHParvandeNum.Text
            EditViewForm.IsArchive.Checked = IsArchive.Checked
            EditViewForm.ID.Text = AMList.SelectedItems(0).SubItems(0).Text
            EditViewForm.GhestT.Text = AMList.SelectedItems(0).SubItems(11).Text
            EditViewForm.PeGet.Text = PeGet.Text
            EditViewForm.ShowDialog()
            If IsArchive.Checked = False Then
                Get_Setting()
                For I As Integer = 0 To AMList.Items.Count - 1
                    If AMList.Items(I).SubItems(1).Text = "False" Then Exit Sub
                Next
                MoveB.Enabled = True
            End If
        End If
    End Sub

    Private Sub Get_Setting()
        AMList.Items.Clear()
        Try
            DBConn = New DBConnection
            DBConn.connectMe("SELECT * FROM AnyMoshtari WHERE SHParvandeNum='" & SHParvandeNum.Text & "' ORDER BY Ghest;")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d.Read
                    If d("IfPardakht".ToString) = True Then
                        Item = AMList.Items.Add(d("ID".ToString))
                        With Item
                            .SubItems.Add("True")
                            .SubItems.Add(d("JPardakht".ToString))
                            .SubItems.Add(d("MDirkard".ToString))
                            .SubItems.Add(d("TVosool".ToString))
                            .SubItems.Add(d("TPardakht".ToString))
                            .SubItems.Add(d("Tell".ToString))
                            .SubItems.Add(d("AghsatCount".ToString))
                            .SubItems.Add(d("MablagheGh".ToString))
                            .SubItems.Add(d("Mostajer".ToString))
                            .SubItems.Add(d("Moajer".ToString))
                            .SubItems.Add(d("Ghest".ToString))
                            .BackColor = System.Drawing.Color.LightGray
                            .ForeColor = System.Drawing.Color.Black
                        End With
                    Else
                        Item = AMList.Items.Add(d("ID".ToString))
                        With Item
                            .SubItems.Add("False")
                            .SubItems.Add("")
                            .SubItems.Add("")
                            .SubItems.Add("")
                            .SubItems.Add("")
                            .SubItems.Add("")
                            .SubItems.Add("")
                            .SubItems.Add("")
                            .SubItems.Add("")
                            .SubItems.Add("")
                            .SubItems.Add(d("Ghest".ToString))
                            .BackColor = System.Drawing.Color.DarkGray
                            .ForeColor = System.Drawing.Color.White
                        End With
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

    Private Sub MoveB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveB.Click
        MessageBox("آیا می خواهید مشتری مورد نظر با شماره پرونده " & SHParvandeNum.Text & " را به بایگانی انتقال دهید؟", MsgBoxStyle.YesNo, "انتقال مشتریها")
        If VBKeyC = False Then Exit Sub
        Try
            DBConn = New DBConnection
            DBConn.connectMe("Update MoshtariList SET IsArchive=True,IsCancel=False WHERE SHParvandeNum=" & SHParvandeNum.Text & ";")
            DBConn.OLEComm.Connection = DBConn.OLEConn
            DBConn.OLEComm.ExecuteNonQuery()
            DBConn.OLEConn.Close()
            MoveArchive = True
            Me.Close()
        Catch err As System.Exception
            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
        End Try
    End Sub

    Private Sub MPrintB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPrintB.Click
        If AMList.SelectedItems.Count > 0 Then
            Dim MR(9) As String
            Dim TarikhePa As String
            Dim I As Integer
            I = AMList.SelectedItems(0).SubItems(11).Text
            Try
                DBConn = New DBConnection
                DBConn.connectMe("SELECT * FROM MoshtariList WHERE SHParvandeNum=" & SHParvandeNum.Text & ";")
                Try
                    DBConn.OLEComm.Connection = DBConn.OLEConn
                    Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                    Do While d.Read
                        MR(0) = SHParvandeNum.Text
                        MR(1) = d("MoajerFN".ToString) & " " & d("MoajerLN".ToString)
                        MR(2) = d("MostajerFN".ToString) & " " & d("MostajerLN".ToString)
                        MR(3) = d("MablagheGh".ToString)
                        MR(4) = d("AghsatCount".ToString)
                        MR(5) = d("NTashilat".ToString)
                        MR(6) = d("JTakhir".ToString)
                        MR(7) = d("TarikheGha".ToString)
                        MR(8) = d("CGGold".ToString)
                        MR(9) = d("Tell".ToString)
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
            Select Case ((Mid(MR(7), 4, 2) + I) Mod 12)
                Case 0
                    TarikhePa = ((Microsoft.VisualBasic.Left(MR(7), 2) + ((Mid(MR(7), 4, 2)) + I) \ 12) - 1) & "/12" & Microsoft.VisualBasic.Right(MR(7), 3)
                Case 1, 2, 3, 4, 5, 6, 7, 8, 9
                    TarikhePa = (Microsoft.VisualBasic.Left(MR(7), 2) + ((Mid(MR(7), 4, 2)) + I) \ 12) & "/0" & ((Mid(MR(7), 4, 2) + I) Mod 12) & Microsoft.VisualBasic.Right(MR(7), 3)
                Case 10, 11
                    TarikhePa = (Microsoft.VisualBasic.Left(MR(7), 2) + ((Mid(MR(7), 4, 2)) + I) \ 12) & "/" & ((Mid(MR(7), 4, 2) + I) Mod 12) & Microsoft.VisualBasic.Right(MR(7), 3)
            End Select
            Try
                DBConn = New DBConnection
                DBConn.connectMe("Insert Into MReport (SHParvandeNum,Moajer,Mostajer,MablagheGh,TarikhePa,AghsatCount,Ghest,NTashilat,JTakhir,CGGold,Tell) Values ('" & MR(0) & "', '" & MR(1) & "', '" & MR(2) & "', '" & MR(3) & "', '" & TarikhePa & "', '" & MR(4) & "', '" & I & "', '" & MR(5) & "', '" & MR(6) & "', '" & MR(8) & "', '" & MR(9) & "');")
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
            If MessageBox("آیا می خواهید قسط مشتری را چاپ کنید؟", MsgBoxStyle.SystemModal, "چاپ قسط") = True Then
                Dim PrintForm As New PrintF
                PrintForm.WP.Text = 1
                PrintForm.ShowDialog()
            End If
            Try
                DBConn = New DBConnection
                DBConn.connectMe("Delete From MReport;")
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
            MessageBox("برای چاپ قسط مشتری لطفا ابتدا قسط مورد نطر را انتخاب کنید.", MsgBoxStyle.OKOnly, "لیست مشتریان")
        End If
    End Sub

    Private Sub DeleteB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteB.Click
        If AMList.SelectedItems.Count > 0 Then
            If MessageBox("آیا می خواهید پرداخت مشتری را حذف کنید؟", MsgBoxStyle.YesNo, "حذف پرداخت") = True Then
                Dim Pardakht As Boolean
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM AnyMoshtari WHERE ID=" & AMList.SelectedItems(0).SubItems(0).Text & ";")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            Pardakht = d("IfPardakht".ToString)
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
                If Pardakht = False Then
                    MessageBox("قسط مورد نظر پرداخت نشده است.", MsgBoxStyle.OKOnly, "حذف پرداخت")
                    Exit Sub
                End If
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("Update AnyMoshtari SET IfPardakht=False WHERE ID=" & AMList.SelectedItems(0).SubItems(0).Text & ";")
                    DBConn.OLEComm.Connection = DBConn.OLEConn
                    DBConn.OLEComm.ExecuteNonQuery()
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
                Get_Setting()
                For J As Integer = 0 To AMList.Items.Count - 1
                    If AMList.Items(J).SubItems(1).Text = "False" Then MoveB.Enabled = False : Exit Sub
                Next
                MoveB.Enabled = True
            End If
        End If
    End Sub

    Private Sub CancelMoveB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelMoveB.Click
        If MessageBox("آیا می خواهید حساب مشتری مورد نظر با شماره پرونده " & SHParvandeNum.Text & " را لغو و به بایگانی انتقال دهید؟", MsgBoxStyle.YesNo, "انتقال مشتریها") = True Then
            Try
                DBConn = New DBConnection
                DBConn.connectMe("Update MoshtariList SET IsArchive=True, IsCancel=True WHERE SHParvandeNum=" & SHParvandeNum.Text & ";")
                DBConn.OLEComm.Connection = DBConn.OLEConn
                DBConn.OLEComm.ExecuteNonQuery()
                DBConn.OLEConn.Close()
                MoveArchive = True
                CancelP = True
                Me.Close()
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            End Try
        End If
    End Sub
End Class
