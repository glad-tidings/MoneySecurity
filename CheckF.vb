Public Class CheckF
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckB As System.Windows.Forms.Button
    Friend WithEvents FinishB As System.Windows.Forms.Button
    Friend WithEvents CGGold As System.Windows.Forms.TextBox
    Friend WithEvents CGGoldList As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.CGGold = New System.Windows.Forms.TextBox
        Me.CheckB = New System.Windows.Forms.Button
        Me.FinishB = New System.Windows.Forms.Button
        Me.CGGoldList = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(168, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "مقدار طلا - گرم :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CGGold
        '
        Me.CGGold.Location = New System.Drawing.Point(24, 16)
        Me.CGGold.Name = "CGGold"
        Me.CGGold.Size = New System.Drawing.Size(144, 23)
        Me.CGGold.TabIndex = 0
        Me.CGGold.Text = ""
        Me.CGGold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CheckB
        '
        Me.CheckB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckB.Location = New System.Drawing.Point(152, 56)
        Me.CheckB.Name = "CheckB"
        Me.CheckB.TabIndex = 1
        Me.CheckB.Text = "بررسی"
        '
        'FinishB
        '
        Me.FinishB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.FinishB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.FinishB.Location = New System.Drawing.Point(64, 56)
        Me.FinishB.Name = "FinishB"
        Me.FinishB.TabIndex = 2
        Me.FinishB.Text = "پایان"
        '
        'CGGoldList
        '
        Me.CGGoldList.ItemHeight = 16
        Me.CGGoldList.Location = New System.Drawing.Point(0, 72)
        Me.CGGoldList.Name = "CGGoldList"
        Me.CGGoldList.Size = New System.Drawing.Size(24, 20)
        Me.CGGoldList.TabIndex = 4
        Me.CGGoldList.Visible = False
        '
        'CheckF
        '
        Me.AcceptButton = Me.CheckB
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.CancelButton = Me.FinishB
        Me.ClientSize = New System.Drawing.Size(290, 88)
        Me.ControlBox = False
        Me.Controls.Add(Me.CGGold)
        Me.Controls.Add(Me.CGGoldList)
        Me.Controls.Add(Me.FinishB)
        Me.Controls.Add(Me.CheckB)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "CheckF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بررسی طلاهای تحویل داده شده به سرمایه گذار"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CheckB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckB.Click
        If IsNullChr("Real", CGGold.Text) = False Then MsgBox("خطا در نوشتن مقدار گرم طلا", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بررسی خطها") : Exit Sub
        CGGoldList.Items.Add(CGGold.Text)
        CGGold.Text = ""
    End Sub

    Private Sub CheckF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadKeyboardLayout("00000429", 1)
    End Sub

    Private Sub CheckF_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        LoadKeyboardLayout("00000409", 1)
    End Sub
End Class
