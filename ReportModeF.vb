Public Class ReportModeF
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
    Friend WithEvents TarikhGroup As System.Windows.Forms.GroupBox
    Friend WithEvents ChangeTTB As System.Windows.Forms.Button
    Friend WithEvents TTarikh As System.Windows.Forms.Label
    Friend WithEvents ChangeFTB As System.Windows.Forms.Button
    Friend WithEvents FTarikh As System.Windows.Forms.Label
    Friend WithEvents ChangeTB As System.Windows.Forms.Button
    Friend WithEvents Tarikh As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FTR As System.Windows.Forms.RadioButton
    Friend WithEvents TR As System.Windows.Forms.RadioButton
    Friend WithEvents AllR As System.Windows.Forms.RadioButton
    Friend WithEvents CancelB As System.Windows.Forms.Button
    Friend WithEvents ViewB As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TarikhGroup = New System.Windows.Forms.GroupBox
        Me.ChangeTTB = New System.Windows.Forms.Button
        Me.TTarikh = New System.Windows.Forms.Label
        Me.ChangeFTB = New System.Windows.Forms.Button
        Me.FTarikh = New System.Windows.Forms.Label
        Me.ChangeTB = New System.Windows.Forms.Button
        Me.Tarikh = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.FTR = New System.Windows.Forms.RadioButton
        Me.TR = New System.Windows.Forms.RadioButton
        Me.AllR = New System.Windows.Forms.RadioButton
        Me.CancelB = New System.Windows.Forms.Button
        Me.ViewB = New System.Windows.Forms.Button
        Me.TarikhGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'TarikhGroup
        '
        Me.TarikhGroup.Controls.Add(Me.ChangeTTB)
        Me.TarikhGroup.Controls.Add(Me.TTarikh)
        Me.TarikhGroup.Controls.Add(Me.ChangeFTB)
        Me.TarikhGroup.Controls.Add(Me.FTarikh)
        Me.TarikhGroup.Controls.Add(Me.ChangeTB)
        Me.TarikhGroup.Controls.Add(Me.Tarikh)
        Me.TarikhGroup.Controls.Add(Me.Label1)
        Me.TarikhGroup.Controls.Add(Me.FTR)
        Me.TarikhGroup.Controls.Add(Me.TR)
        Me.TarikhGroup.Controls.Add(Me.AllR)
        Me.TarikhGroup.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.TarikhGroup.Location = New System.Drawing.Point(16, 16)
        Me.TarikhGroup.Name = "TarikhGroup"
        Me.TarikhGroup.Size = New System.Drawing.Size(456, 152)
        Me.TarikhGroup.TabIndex = 24
        Me.TarikhGroup.TabStop = False
        Me.TarikhGroup.Text = "نمایش"
        '
        'ChangeTTB
        '
        Me.ChangeTTB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.ChangeTTB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ChangeTTB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChangeTTB.Location = New System.Drawing.Point(16, 112)
        Me.ChangeTTB.Name = "ChangeTTB"
        Me.ChangeTTB.Size = New System.Drawing.Size(40, 20)
        Me.ChangeTTB.TabIndex = 5
        Me.ChangeTTB.Text = "تغییر"
        '
        'TTarikh
        '
        Me.TTarikh.BackColor = System.Drawing.Color.White
        Me.TTarikh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TTarikh.Location = New System.Drawing.Point(64, 112)
        Me.TTarikh.Name = "TTarikh"
        Me.TTarikh.Size = New System.Drawing.Size(96, 23)
        Me.TTarikh.TabIndex = 26
        Me.TTarikh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChangeFTB
        '
        Me.ChangeFTB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.ChangeFTB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ChangeFTB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChangeFTB.Location = New System.Drawing.Point(224, 112)
        Me.ChangeFTB.Name = "ChangeFTB"
        Me.ChangeFTB.Size = New System.Drawing.Size(40, 20)
        Me.ChangeFTB.TabIndex = 4
        Me.ChangeFTB.Text = "تغییر"
        '
        'FTarikh
        '
        Me.FTarikh.BackColor = System.Drawing.Color.White
        Me.FTarikh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FTarikh.Location = New System.Drawing.Point(272, 112)
        Me.FTarikh.Name = "FTarikh"
        Me.FTarikh.Size = New System.Drawing.Size(96, 23)
        Me.FTarikh.TabIndex = 24
        Me.FTarikh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChangeTB
        '
        Me.ChangeTB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.ChangeTB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ChangeTB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChangeTB.Location = New System.Drawing.Point(224, 72)
        Me.ChangeTB.Name = "ChangeTB"
        Me.ChangeTB.Size = New System.Drawing.Size(40, 20)
        Me.ChangeTB.TabIndex = 2
        Me.ChangeTB.Text = "تغییر"
        '
        'Tarikh
        '
        Me.Tarikh.BackColor = System.Drawing.Color.White
        Me.Tarikh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tarikh.Location = New System.Drawing.Point(272, 72)
        Me.Tarikh.Name = "Tarikh"
        Me.Tarikh.Size = New System.Drawing.Size(96, 23)
        Me.Tarikh.TabIndex = 22
        Me.Tarikh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(160, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "تا تاریخ :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FTR
        '
        Me.FTR.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.FTR.Location = New System.Drawing.Point(368, 112)
        Me.FTR.Name = "FTR"
        Me.FTR.Size = New System.Drawing.Size(72, 24)
        Me.FTR.TabIndex = 3
        Me.FTR.Text = "از تاریخ :"
        Me.FTR.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'TR
        '
        Me.TR.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.TR.Location = New System.Drawing.Point(376, 72)
        Me.TR.Name = "TR"
        Me.TR.Size = New System.Drawing.Size(64, 24)
        Me.TR.TabIndex = 1
        Me.TR.Text = "تاریخ :"
        Me.TR.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'AllR
        '
        Me.AllR.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AllR.Location = New System.Drawing.Point(392, 32)
        Me.AllR.Name = "AllR"
        Me.AllR.Size = New System.Drawing.Size(48, 24)
        Me.AllR.TabIndex = 0
        Me.AllR.Text = "همه"
        Me.AllR.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'CancelB
        '
        Me.CancelB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.CancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CancelB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CancelB.Location = New System.Drawing.Point(136, 184)
        Me.CancelB.Name = "CancelB"
        Me.CancelB.Size = New System.Drawing.Size(96, 23)
        Me.CancelB.TabIndex = 7
        Me.CancelB.Text = "لغو"
        '
        'ViewB
        '
        Me.ViewB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.ViewB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ViewB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ViewB.Location = New System.Drawing.Point(256, 184)
        Me.ViewB.Name = "ViewB"
        Me.ViewB.Size = New System.Drawing.Size(96, 23)
        Me.ViewB.TabIndex = 6
        Me.ViewB.Text = "نمایش"
        '
        'ReportModeF
        '
        Me.AcceptButton = Me.ViewB
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.CancelB
        Me.ClientSize = New System.Drawing.Size(490, 216)
        Me.Controls.Add(Me.TarikhGroup)
        Me.Controls.Add(Me.CancelB)
        Me.Controls.Add(Me.ViewB)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportModeF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "طریقه نمایش لیست"
        Me.TarikhGroup.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "DefIns"
    Private Shared m_vb6FormDefInstance As ReportModeF
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As ReportModeF
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New ReportModeF
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As ReportModeF)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region

    Private Sub ReportModeF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tarikh.Text = Shamsi()
        FTarikh.Text = Shamsi()
        TTarikh.Text = Shamsi()
        AllR.Checked = True
    End Sub

    Private Sub AllR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllR.CheckedChanged
        Tarikh.Enabled = False
        ChangeTB.Enabled = False
        FTarikh.Enabled = False
        ChangeFTB.Enabled = False
        TTarikh.Enabled = False
        ChangeTTB.Enabled = False
    End Sub

    Private Sub TR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TR.CheckedChanged
        If TR.Checked = True Then
            Tarikh.Enabled = True : ChangeTB.Enabled = True
            FTarikh.Enabled = False : ChangeFTB.Enabled = False : TTarikh.Enabled = False : ChangeTTB.Enabled = False
        End If
    End Sub

    Private Sub FTR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FTR.CheckedChanged
        If FTR.Checked = True Then
            FTarikh.Enabled = True : ChangeFTB.Enabled = True : TTarikh.Enabled = True : ChangeTTB.Enabled = True
            Tarikh.Enabled = False : ChangeTB.Enabled = False
        End If
    End Sub

    Private Sub ChangeTB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeTB.Click
        Dim InputBoxForm As New InputBoxF
        InputBoxForm.TVosool.Text = Tarikh.Text
        InputBoxForm.Message.Text = "áØÝÇ ÏÑ ÕæÑÊ ÇÔÊÈÇå ÈæÏä ÊÇÑíÎ ÒÇÑÔ ÏÑÌ ÔÏå ÊæÓØ ÈÑäÇãå ÊÇÑíÎ ÒÇÑÔ ÕÍíÍ ÑÇ æÇÑÏ ˜äíÏ."
        InputBoxForm.ShowDialog()
        Tarikh.Text = InputBoxForm.TVosool.Text
    End Sub

    Private Sub ChangeFTB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeFTB.Click
        Dim InputBoxForm As New InputBoxF
        InputBoxForm.TVosool.Text = FTarikh.Text
        InputBoxForm.Message.Text = "áØÝÇ ÏÑ ÕæÑÊ ÇÔÊÈÇå ÈæÏä ÊÇÑíÎ ÒÇÑÔ ÏÑÌ ÔÏå ÊæÓØ ÈÑäÇãå ÊÇÑíÎ ÒÇÑÔ ÕÍíÍ ÑÇ æÇÑÏ ˜äíÏ."
        InputBoxForm.ShowDialog()
        FTarikh.Text = InputBoxForm.TVosool.Text
    End Sub

    Private Sub ChangeTTB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeTTB.Click
        Dim InputBoxForm As New InputBoxF
        InputBoxForm.TVosool.Text = TTarikh.Text
        InputBoxForm.Message.Text = "áØÝÇ ÏÑ ÕæÑÊ ÇÔÊÈÇå ÈæÏä ÊÇÑíÎ ÒÇÑÔ ÏÑÌ ÔÏå ÊæÓØ ÈÑäÇãå ÊÇÑíÎ ÒÇÑÔ ÕÍíÍ ÑÇ æÇÑÏ ˜äíÏ."
        InputBoxForm.ShowDialog()
        TTarikh.Text = InputBoxForm.TVosool.Text
    End Sub

    Private Sub ViewB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewB.Click
        Me.Enabled = False
        If AllR.Checked = True Then
            ReportListFormViewMode = 1
        ElseIf TR.Checked = True Then
            ReportListFormViewMode = 2
            ReportListFormFT = Tarikh.Text
        Else
            Dim F_Tarikh As String = Microsoft.VisualBasic.Left(FTarikh.Text, 2) & Mid(FTarikh.Text, 4, 2) & Microsoft.VisualBasic.Right(FTarikh.Text, 2)
            Dim T_Tarikh As String = Microsoft.VisualBasic.Left(TTarikh.Text, 2) & Mid(TTarikh.Text, 4, 2) & Microsoft.VisualBasic.Right(TTarikh.Text, 2)
            If Dirkard(FTarikh.Text, TTarikh.Text) = True Then MsgBox("ÎØÇ ÏÑ ãÔÎÕ ˜ÑÏä ãÍÏæÏå ÊÇÑíÎ", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "ØÑíÞå äãÇíÔ áíÓÊ") : GoTo Get_Error
            If Diff(F_Tarikh, T_Tarikh) > 250 Then MsgBox("ãÍÏæÏå ÊÇÑíÎ ÈíÔÊÑ ÇÒ ÍÏ ãÌÇÒ ÇÓÊ. ãÍÏæÏå ÊÇ 250 ÑæÒ ÞÇÈá ÞÈæá ÇÓÊ.", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "ØÑíÞå äãÇíÔ áíÓÊ") : GoTo Get_Error
            ReportListFormViewMode = 3
            ReportListFormFT = FTarikh.Text
            ReportListFormTT = TTarikh.Text
        End If
        ReportListF.DefInstance.Show()
        Me.Close()
        Exit Sub
Get_Error:
        Me.Enabled = True
    End Sub
End Class
