Public Class ActivationF
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents SysID4 As System.Windows.Forms.Label
    Friend WithEvents SysID3 As System.Windows.Forms.Label
    Friend WithEvents SysID2 As System.Windows.Forms.Label
    Friend WithEvents SysID1 As System.Windows.Forms.Label
    Friend WithEvents SerialNum1 As System.Windows.Forms.Label
    Friend WithEvents SerialNum2 As System.Windows.Forms.Label
    Friend WithEvents SerialNum3 As System.Windows.Forms.Label
    Friend WithEvents SerialNum4 As System.Windows.Forms.Label
    Friend WithEvents ActiveCo1 As System.Windows.Forms.TextBox
    Friend WithEvents ActiveCo2 As System.Windows.Forms.TextBox
    Friend WithEvents ActiveCo3 As System.Windows.Forms.TextBox
    Friend WithEvents ActiveCo4 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ActiveB As System.Windows.Forms.Button
    Friend WithEvents CancelB As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LastName As System.Windows.Forms.TextBox
    Friend WithEvents FirstName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ActivationF))
        Me.SysID4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SysID3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.SysID2 = New System.Windows.Forms.Label
        Me.SysID1 = New System.Windows.Forms.Label
        Me.SerialNum1 = New System.Windows.Forms.Label
        Me.SerialNum2 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.SerialNum3 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.SerialNum4 = New System.Windows.Forms.Label
        Me.ActiveCo1 = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.ActiveCo2 = New System.Windows.Forms.TextBox
        Me.ActiveCo3 = New System.Windows.Forms.TextBox
        Me.ActiveCo4 = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.ActiveB = New System.Windows.Forms.Button
        Me.CancelB = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.LastName = New System.Windows.Forms.TextBox
        Me.FirstName = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SysID4
        '
        Me.SysID4.BackColor = System.Drawing.Color.White
        Me.SysID4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SysID4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.SysID4.Location = New System.Drawing.Point(256, 112)
        Me.SysID4.Name = "SysID4"
        Me.SysID4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SysID4.Size = New System.Drawing.Size(64, 23)
        Me.SysID4.TabIndex = 0
        Me.SysID4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(336, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "کد سیستم :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SysID3
        '
        Me.SysID3.BackColor = System.Drawing.Color.White
        Me.SysID3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SysID3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.SysID3.Location = New System.Drawing.Point(176, 112)
        Me.SysID3.Name = "SysID3"
        Me.SysID3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SysID3.Size = New System.Drawing.Size(64, 23)
        Me.SysID3.TabIndex = 2
        Me.SysID3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(240, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "-"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(160, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "-"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(80, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "-"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SysID2
        '
        Me.SysID2.BackColor = System.Drawing.Color.White
        Me.SysID2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SysID2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.SysID2.Location = New System.Drawing.Point(96, 112)
        Me.SysID2.Name = "SysID2"
        Me.SysID2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SysID2.Size = New System.Drawing.Size(64, 23)
        Me.SysID2.TabIndex = 6
        Me.SysID2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SysID1
        '
        Me.SysID1.BackColor = System.Drawing.Color.White
        Me.SysID1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SysID1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.SysID1.Location = New System.Drawing.Point(16, 112)
        Me.SysID1.Name = "SysID1"
        Me.SysID1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SysID1.Size = New System.Drawing.Size(64, 23)
        Me.SysID1.TabIndex = 7
        Me.SysID1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SerialNum1
        '
        Me.SerialNum1.BackColor = System.Drawing.Color.White
        Me.SerialNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SerialNum1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.SerialNum1.Location = New System.Drawing.Point(16, 152)
        Me.SerialNum1.Name = "SerialNum1"
        Me.SerialNum1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SerialNum1.Size = New System.Drawing.Size(64, 23)
        Me.SerialNum1.TabIndex = 15
        Me.SerialNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SerialNum2
        '
        Me.SerialNum2.BackColor = System.Drawing.Color.White
        Me.SerialNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SerialNum2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.SerialNum2.Location = New System.Drawing.Point(96, 152)
        Me.SerialNum2.Name = "SerialNum2"
        Me.SerialNum2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SerialNum2.Size = New System.Drawing.Size(64, 23)
        Me.SerialNum2.TabIndex = 14
        Me.SerialNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(80, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 23)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "-"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(160, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 23)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "-"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(240, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 23)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "-"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SerialNum3
        '
        Me.SerialNum3.BackColor = System.Drawing.Color.White
        Me.SerialNum3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SerialNum3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.SerialNum3.Location = New System.Drawing.Point(176, 152)
        Me.SerialNum3.Name = "SerialNum3"
        Me.SerialNum3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SerialNum3.Size = New System.Drawing.Size(64, 23)
        Me.SerialNum3.TabIndex = 10
        Me.SerialNum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(328, 152)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 23)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "سریال برنامه :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SerialNum4
        '
        Me.SerialNum4.BackColor = System.Drawing.Color.White
        Me.SerialNum4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SerialNum4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.SerialNum4.Location = New System.Drawing.Point(256, 152)
        Me.SerialNum4.Name = "SerialNum4"
        Me.SerialNum4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SerialNum4.Size = New System.Drawing.Size(64, 23)
        Me.SerialNum4.TabIndex = 8
        Me.SerialNum4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ActiveCo1
        '
        Me.ActiveCo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ActiveCo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ActiveCo1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ActiveCo1.Location = New System.Drawing.Point(16, 272)
        Me.ActiveCo1.MaxLength = 4
        Me.ActiveCo1.Name = "ActiveCo1"
        Me.ActiveCo1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ActiveCo1.Size = New System.Drawing.Size(64, 22)
        Me.ActiveCo1.TabIndex = 2
        Me.ActiveCo1.Text = ""
        Me.ActiveCo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Black
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 192)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(408, 1)
        Me.Label17.TabIndex = 17
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ActiveCo2
        '
        Me.ActiveCo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ActiveCo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ActiveCo2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ActiveCo2.Location = New System.Drawing.Point(96, 272)
        Me.ActiveCo2.MaxLength = 4
        Me.ActiveCo2.Name = "ActiveCo2"
        Me.ActiveCo2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ActiveCo2.Size = New System.Drawing.Size(64, 22)
        Me.ActiveCo2.TabIndex = 3
        Me.ActiveCo2.Text = ""
        Me.ActiveCo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ActiveCo3
        '
        Me.ActiveCo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ActiveCo3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ActiveCo3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ActiveCo3.Location = New System.Drawing.Point(176, 272)
        Me.ActiveCo3.MaxLength = 4
        Me.ActiveCo3.Name = "ActiveCo3"
        Me.ActiveCo3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ActiveCo3.Size = New System.Drawing.Size(64, 22)
        Me.ActiveCo3.TabIndex = 4
        Me.ActiveCo3.Text = ""
        Me.ActiveCo3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ActiveCo4
        '
        Me.ActiveCo4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ActiveCo4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ActiveCo4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ActiveCo4.Location = New System.Drawing.Point(256, 272)
        Me.ActiveCo4.MaxLength = 4
        Me.ActiveCo4.Name = "ActiveCo4"
        Me.ActiveCo4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ActiveCo4.Size = New System.Drawing.Size(64, 22)
        Me.ActiveCo4.TabIndex = 5
        Me.ActiveCo4.Text = ""
        Me.ActiveCo4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(320, 272)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 23)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "کد فعال سازی :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ActiveB
        '
        Me.ActiveB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.ActiveB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ActiveB.Location = New System.Drawing.Point(224, 312)
        Me.ActiveB.Name = "ActiveB"
        Me.ActiveB.Size = New System.Drawing.Size(88, 23)
        Me.ActiveB.TabIndex = 6
        Me.ActiveB.Text = "فعال سازی"
        '
        'CancelB
        '
        Me.CancelB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.CancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CancelB.Location = New System.Drawing.Point(112, 312)
        Me.CancelB.Name = "CancelB"
        Me.CancelB.Size = New System.Drawing.Size(88, 23)
        Me.CancelB.TabIndex = 7
        Me.CancelB.Text = "لغو"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(80, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 23)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "-"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(160, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 23)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "-"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(240, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 23)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "-"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(384, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 23)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "نام :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(328, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 23)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "نام خانوادگی :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LastName
        '
        Me.LastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LastName.Location = New System.Drawing.Point(176, 240)
        Me.LastName.MaxLength = 0
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(144, 23)
        Me.LastName.TabIndex = 1
        Me.LastName.Text = ""
        '
        'FirstName
        '
        Me.FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FirstName.Location = New System.Drawing.Point(176, 208)
        Me.FirstName.MaxLength = 0
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(144, 23)
        Me.FirstName.TabIndex = 0
        Me.FirstName.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(416, 96)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label10.Location = New System.Drawing.Point(80, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(328, 32)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "فعال سازی برنامه"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'ActivationF
        '
        Me.AcceptButton = Me.ActiveB
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.CancelB
        Me.ClientSize = New System.Drawing.Size(426, 344)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CancelB)
        Me.Controls.Add(Me.ActiveB)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.ActiveCo4)
        Me.Controls.Add(Me.ActiveCo3)
        Me.Controls.Add(Me.ActiveCo2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.ActiveCo1)
        Me.Controls.Add(Me.SerialNum1)
        Me.Controls.Add(Me.SerialNum2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.SerialNum3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.SerialNum4)
        Me.Controls.Add(Me.SysID1)
        Me.Controls.Add(Me.SysID2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SysID3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SysID4)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ActivationF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ActiveCo1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActiveCo1.TextChanged
        If ActiveCo1.TextLength = ActiveCo1.MaxLength Then ActiveCo2.Focus()
    End Sub

    Private Sub ActiveCo2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActiveCo2.TextChanged
        If ActiveCo2.TextLength = ActiveCo1.MaxLength Then ActiveCo3.Focus()
    End Sub

    Private Sub ActiveCo3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActiveCo3.TextChanged
        If ActiveCo3.TextLength = ActiveCo1.MaxLength Then ActiveCo4.Focus()
    End Sub

    Private Sub ActivationF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SysID1.Text = SystemID(1)
        SysID2.Text = SystemID(2)
        SysID3.Text = SystemID(3)
        SysID4.Text = SystemID(4)
        SerialNum1.Text = ProgramCode(1)
        SerialNum2.Text = ProgramCode(2)
        SerialNum3.Text = ProgramCode(3)
        SerialNum4.Text = ProgramCode(4)
    End Sub

    Private Sub ActiveB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActiveB.Click
        Dim InCode As String
        Dim OutCode As String
        InCode = ActiveCo1.Text & "-" & ActiveCo2.Text & "-" & ActiveCo3.Text & "-" & ActiveCo4.Text
        OutCode = ProgramCode(1) & "-" & ProgramCode(2) & "-" & ProgramCode(3) & "-" & ProgramCode(4)
        If InCode = ActiveCode() Then
            SetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Register", "FirstName", FirstName.Text)
            SetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Register", "LastName", LastName.Text)
            SetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Register", "SerialNumber", OutCode)
            SetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Register", "ActiveCode", InCode)
            MessageBox("برنامه با موفقیت فعال شد.", MsgBoxStyle.Exclamation, "فعال سازی")
            Dim RegAdminForm As New RegAdminF
            RegAdminForm.Show()
            Me.Hide()
        Else
            MessageBox("کد فعال سازی اشتباه است.", MsgBoxStyle.Information, "فعال سازی")
        End If
    End Sub

    Private Sub ActivationF_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        End
    End Sub

    Private Sub FirstName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles FirstName.GotFocus, LastName.GotFocus
        LoadKeyboardLayout("00000429", 1)
    End Sub

    Private Sub ActiveCo1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ActiveCo1.GotFocus, ActiveCo2.GotFocus, ActiveCo3.GotFocus, ActiveCo4.GotFocus
        LoadKeyboardLayout("00000409", 1)
    End Sub

    Private Sub ActivationF_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        LoadKeyboardLayout("00000409", 1)
    End Sub

    Private Sub CancelB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelB.Click
        Me.Close()
    End Sub
End Class
