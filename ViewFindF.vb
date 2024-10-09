Public Class ViewFindF
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
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents NFind As System.Windows.Forms.TextBox
    Friend WithEvents FList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.FList = New System.Windows.Forms.ListView
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.txtFind = New System.Windows.Forms.TextBox
        Me.NFind = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'FList
        '
        Me.FList.BackColor = System.Drawing.Color.DarkGray
        Me.FList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader1, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.FList.ForeColor = System.Drawing.Color.White
        Me.FList.FullRowSelect = True
        Me.FList.GridLines = True
        Me.FList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.FList.Location = New System.Drawing.Point(0, 0)
        Me.FList.MultiSelect = False
        Me.FList.Name = "FList"
        Me.FList.Size = New System.Drawing.Size(568, 256)
        Me.FList.TabIndex = 12
        Me.FList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "آیدی"
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "بایگانی"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "تلفن تماس"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 115
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "مستاجر"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 160
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "موجر"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 150
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "شماره پرونده"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader10.Width = 143
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(0, 240)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(40, 23)
        Me.txtFind.TabIndex = 13
        Me.txtFind.Text = ""
        Me.txtFind.Visible = False
        '
        'NFind
        '
        Me.NFind.Location = New System.Drawing.Point(40, 240)
        Me.NFind.Name = "NFind"
        Me.NFind.Size = New System.Drawing.Size(40, 23)
        Me.NFind.TabIndex = 15
        Me.NFind.Text = ""
        Me.NFind.Visible = False
        '
        'ViewFindF
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(568, 256)
        Me.Controls.Add(Me.NFind)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.FList)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewFindF"
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

#End Region

    Private Sub ViewFindF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case NFind.Text
            Case 1
                FList.Items.Clear()
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM MoshtariList WHERE SHParvandeNum=" & txtFind.Text & ";")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            Item = FList.Items.Add(d("ID".ToString))
                            With Item
                                .SubItems.Add(d("IsArchive".ToString))
                                .SubItems.Add(d("Tell".ToString))
                                .SubItems.Add(d("MostajerFN".ToString) & " " & d("MostajerLN".ToString))
                                .SubItems.Add(d("MoajerFN".ToString) & " " & d("MoajerLN".ToString))
                                .SubItems.Add(d("SHParvandeNum".ToString))
                                If d("IsArchive".ToString) = True Then .BackColor = System.Drawing.Color.Goldenrod
                                If d("IsCancel".ToString) = True Then .BackColor = System.Drawing.Color.RosyBrown
                                If d("IsBlackCancel".ToString) = True Then .BackColor = System.Drawing.Color.Black
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
                FList.Items.Clear()
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM MoshtariList ORDER BY SHParvandeNum;")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            If txtFind.Text = d("MoajerFN".ToString) & " " & d("MoajerLN".ToString) Then
                                Item = FList.Items.Add(d("ID".ToString))
                                With Item
                                    .SubItems.Add(d("IsArchive".ToString))
                                    .SubItems.Add(d("Tell".ToString))
                                    .SubItems.Add(d("MostajerFN".ToString) & " " & d("MostajerLN".ToString))
                                    .SubItems.Add(d("MoajerFN".ToString) & " " & d("MoajerLN".ToString))
                                    .SubItems.Add(d("SHParvandeNum".ToString))
                                    If d("IsArchive".ToString) = True Then .BackColor = System.Drawing.Color.Goldenrod
                                    If d("IsCancel".ToString) = True Then .BackColor = System.Drawing.Color.RosyBrown
                                    If d("IsBlackCancel".ToString) = True Then .BackColor = System.Drawing.Color.Black
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
            Case 3
                FList.Items.Clear()
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM MoshtariList ORDER BY SHParvandeNum;")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            If txtFind.Text = d("MostajerFN".ToString) & " " & d("MostajerLN".ToString) Then
                                Item = FList.Items.Add(d("ID".ToString))
                                With Item
                                    .SubItems.Add(d("IsArchive".ToString))
                                    .SubItems.Add(d("Tell".ToString))
                                    .SubItems.Add(d("MostajerFN".ToString) & " " & d("MostajerLN".ToString))
                                    .SubItems.Add(d("MoajerFN".ToString) & " " & d("MoajerLN".ToString))
                                    .SubItems.Add(d("SHParvandeNum".ToString))
                                    If d("IsArchive".ToString) = True Then .BackColor = System.Drawing.Color.Goldenrod
                                    If d("IsCancel".ToString) = True Then .BackColor = System.Drawing.Color.RosyBrown
                                    If d("IsBlackCancel".ToString) = True Then .BackColor = System.Drawing.Color.Black
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
            Case 4
                FList.Items.Clear()
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM MoshtariList WHERE Tell='" & txtFind.Text & "' ORDER BY SHParvandeNum;")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            Item = FList.Items.Add(d("ID".ToString))
                            With Item
                                .SubItems.Add(d("IsArchive".ToString))
                                .SubItems.Add(d("Tell".ToString))
                                .SubItems.Add(d("MostajerFN".ToString) & " " & d("MostajerLN".ToString))
                                .SubItems.Add(d("MoajerFN".ToString) & " " & d("MoajerLN".ToString))
                                .SubItems.Add(d("SHParvandeNum".ToString))
                                If d("IsArchive".ToString) = True Then .BackColor = System.Drawing.Color.Goldenrod
                                If d("IsCancel".ToString) = True Then .BackColor = System.Drawing.Color.RosyBrown
                                If d("IsBlackCancel".ToString) = True Then .BackColor = System.Drawing.Color.Black
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
    End Sub

    Private Sub FList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles FList.DoubleClick
        If FList.SelectedItems.Count > 0 Then
            Dim ViewFormM As New ViewF
            ViewFormM.SHParvandeNum.Text = FList.SelectedItems(0).SubItems(5).Text
            If FList.SelectedItems(0).SubItems(1).Text = "True" Then ViewFormM.IsArchive.Checked = True
            ViewFormM.ShowDialog()
        End If
    End Sub
End Class
