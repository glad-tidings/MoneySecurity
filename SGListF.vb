Public Class SGListF
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
    Friend WithEvents CancelB As System.Windows.Forms.Button
    Friend WithEvents OKB As System.Windows.Forms.Button
    Friend WithEvents VSGList As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SGList As System.Windows.Forms.ComboBox
    Friend WithEvents FName As System.Windows.Forms.ColumnHeader
    Friend WithEvents LName As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CancelB = New System.Windows.Forms.Button
        Me.OKB = New System.Windows.Forms.Button
        Me.VSGList = New System.Windows.Forms.ListView
        Me.FName = New System.Windows.Forms.ColumnHeader
        Me.LName = New System.Windows.Forms.ColumnHeader
        Me.SGList = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'CancelB
        '
        Me.CancelB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.CancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CancelB.Location = New System.Drawing.Point(40, 64)
        Me.CancelB.Name = "CancelB"
        Me.CancelB.Size = New System.Drawing.Size(96, 23)
        Me.CancelB.TabIndex = 2
        Me.CancelB.Text = "لغو"
        '
        'OKB
        '
        Me.OKB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.OKB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OKB.Location = New System.Drawing.Point(152, 64)
        Me.OKB.Name = "OKB"
        Me.OKB.Size = New System.Drawing.Size(96, 23)
        Me.OKB.TabIndex = 1
        Me.OKB.Text = "تایید"
        '
        'VSGList
        '
        Me.VSGList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FName, Me.LName})
        Me.VSGList.Location = New System.Drawing.Point(0, 72)
        Me.VSGList.MultiSelect = False
        Me.VSGList.Name = "VSGList"
        Me.VSGList.Size = New System.Drawing.Size(32, 32)
        Me.VSGList.TabIndex = 20
        Me.VSGList.View = System.Windows.Forms.View.Details
        Me.VSGList.Visible = False
        '
        'FName
        '
        Me.FName.Text = "First Name"
        '
        'LName
        '
        Me.LName.Text = "Last Name"
        Me.LName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SGList
        '
        Me.SGList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SGList.Location = New System.Drawing.Point(16, 24)
        Me.SGList.Name = "SGList"
        Me.SGList.Size = New System.Drawing.Size(168, 24)
        Me.SGList.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(184, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 23)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "سرمایه گذار :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SGListF
        '
        Me.AcceptButton = Me.OKB
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.CancelB
        Me.ClientSize = New System.Drawing.Size(292, 96)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SGList)
        Me.Controls.Add(Me.VSGList)
        Me.Controls.Add(Me.CancelB)
        Me.Controls.Add(Me.OKB)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SGListF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.Text = "لیست سرمایه گذاران"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Decs"
    Dim DBConn As DBConnection
    Dim iCounter As Integer
    Public OK As Boolean = False
    Dim Item As ListViewItem
#End Region

    Private Sub SGListF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SGList.Items.Clear()
        VSGList.Items.Clear()
        SGList.Items.Add("")
        Item = VSGList.Items.Add("")
        Item.SubItems.Add("")
        Try
            DBConn = New DBConnection
            DBConn.connectMe("SELECT * FROM SGozari ORDER BY GharardadNum;")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d.Read
                    SGList.Items.Add(d("SFName".ToString) & " " & d("SLName".ToString))
                    Item = VSGList.Items.Add(d("SFName".ToString))
                    Item.SubItems.Add(d("SLName".ToString))
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
        If SGList.Text <> "" Then
            OK = True
        End If
        Me.Close()
    End Sub
End Class
