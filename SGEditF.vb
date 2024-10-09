Public Class SGEditF
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
    Friend WithEvents Female As System.Windows.Forms.RadioButton
    Friend WithEvents Male As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CancelB As System.Windows.Forms.Button
    Friend WithEvents Mablagh As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Mahiane As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ChangeFB As System.Windows.Forms.Button
    Friend WithEvents ChangeGhB As System.Windows.Forms.Button
    Friend WithEvents TarikheFa As System.Windows.Forms.Label
    Friend WithEvents TarikheGha As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Addrress As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents YBirth As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Sadereh As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SHenasnameNum As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Farzand As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EditB As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Tell As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Tozih As System.Windows.Forms.TextBox
    Friend WithEvents GharardadNum As System.Windows.Forms.Label
    Friend WithEvents SLName As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents SFName As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents SetDefaultB As System.Windows.Forms.Button
    Friend WithEvents SetNowB As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SGEditF))
        Me.Female = New System.Windows.Forms.RadioButton
        Me.Male = New System.Windows.Forms.RadioButton
        Me.Label11 = New System.Windows.Forms.Label
        Me.CancelB = New System.Windows.Forms.Button
        Me.EditB = New System.Windows.Forms.Button
        Me.Mablagh = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Mahiane = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ChangeFB = New System.Windows.Forms.Button
        Me.ChangeGhB = New System.Windows.Forms.Button
        Me.TarikheFa = New System.Windows.Forms.Label
        Me.TarikheGha = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Addrress = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.YBirth = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Sadereh = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.SHenasnameNum = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Farzand = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ID = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Tozih = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Tell = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.GharardadNum = New System.Windows.Forms.Label
        Me.SLName = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.SFName = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.SetDefaultB = New System.Windows.Forms.Button
        Me.SetNowB = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Female
        '
        Me.Female.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Female.Location = New System.Drawing.Point(120, 112)
        Me.Female.Name = "Female"
        Me.Female.Size = New System.Drawing.Size(40, 24)
        Me.Female.TabIndex = 3
        Me.Female.Text = "زن"
        '
        'Male
        '
        Me.Male.Checked = True
        Me.Male.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Male.Location = New System.Drawing.Point(184, 112)
        Me.Male.Name = "Male"
        Me.Male.Size = New System.Drawing.Size(40, 24)
        Me.Male.TabIndex = 2
        Me.Male.TabStop = True
        Me.Male.Text = "مرد"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.Location = New System.Drawing.Point(344, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 24)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "جنسیت :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CancelB
        '
        Me.CancelB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.CancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CancelB.Location = New System.Drawing.Point(104, 504)
        Me.CancelB.Name = "CancelB"
        Me.CancelB.Size = New System.Drawing.Size(96, 23)
        Me.CancelB.TabIndex = 16
        Me.CancelB.Text = "لغو"
        '
        'EditB
        '
        Me.EditB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.EditB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.EditB.Location = New System.Drawing.Point(224, 504)
        Me.EditB.Name = "EditB"
        Me.EditB.Size = New System.Drawing.Size(96, 23)
        Me.EditB.TabIndex = 15
        Me.EditB.Text = "ذخیره تغییرات"
        '
        'Mablagh
        '
        Me.Mablagh.Location = New System.Drawing.Point(104, 464)
        Me.Mablagh.MaxLength = 50
        Me.Mablagh.Name = "Mablagh"
        Me.Mablagh.Size = New System.Drawing.Size(120, 23)
        Me.Mablagh.TabIndex = 14
        Me.Mablagh.Text = ""
        Me.Mablagh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.Location = New System.Drawing.Point(320, 464)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 24)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "مبلغ سرمایه :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Mahiane
        '
        Me.Mahiane.Location = New System.Drawing.Point(104, 432)
        Me.Mahiane.MaxLength = 50
        Me.Mahiane.Name = "Mahiane"
        Me.Mahiane.Size = New System.Drawing.Size(120, 23)
        Me.Mahiane.TabIndex = 13
        Me.Mahiane.Text = ""
        Me.Mahiane.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(232, 432)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(176, 24)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "مبلغ پرداختی به سرمایه گذار :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ChangeFB
        '
        Me.ChangeFB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.ChangeFB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ChangeFB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChangeFB.Location = New System.Drawing.Point(56, 400)
        Me.ChangeFB.Name = "ChangeFB"
        Me.ChangeFB.Size = New System.Drawing.Size(40, 20)
        Me.ChangeFB.TabIndex = 12
        Me.ChangeFB.Text = "تغییر"
        '
        'ChangeGhB
        '
        Me.ChangeGhB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.ChangeGhB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ChangeGhB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChangeGhB.Location = New System.Drawing.Point(56, 368)
        Me.ChangeGhB.Name = "ChangeGhB"
        Me.ChangeGhB.Size = New System.Drawing.Size(40, 20)
        Me.ChangeGhB.TabIndex = 11
        Me.ChangeGhB.Text = "تغییر"
        '
        'TarikheFa
        '
        Me.TarikheFa.BackColor = System.Drawing.Color.White
        Me.TarikheFa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TarikheFa.Location = New System.Drawing.Point(104, 400)
        Me.TarikheFa.Name = "TarikheFa"
        Me.TarikheFa.Size = New System.Drawing.Size(120, 23)
        Me.TarikheFa.TabIndex = 47
        Me.TarikheFa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TarikheGha
        '
        Me.TarikheGha.BackColor = System.Drawing.Color.White
        Me.TarikheGha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TarikheGha.Location = New System.Drawing.Point(104, 368)
        Me.TarikheGha.Name = "TarikheGha"
        Me.TarikheGha.Size = New System.Drawing.Size(120, 23)
        Me.TarikheGha.TabIndex = 46
        Me.TarikheGha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.Location = New System.Drawing.Point(328, 400)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 24)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "تاریخ فسخ :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(328, 368)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 24)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "تاریخ قرارداد :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Addrress
        '
        Me.Addrress.Location = New System.Drawing.Point(104, 272)
        Me.Addrress.MaxLength = 250
        Me.Addrress.Name = "Addrress"
        Me.Addrress.Size = New System.Drawing.Size(120, 23)
        Me.Addrress.TabIndex = 8
        Me.Addrress.Text = ""
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(360, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 24)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "آدرس :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'YBirth
        '
        Me.YBirth.Location = New System.Drawing.Point(104, 240)
        Me.YBirth.MaxLength = 50
        Me.YBirth.Name = "YBirth"
        Me.YBirth.Size = New System.Drawing.Size(120, 23)
        Me.YBirth.TabIndex = 7
        Me.YBirth.Text = ""
        Me.YBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(352, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 24)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "متولد :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Sadereh
        '
        Me.Sadereh.Location = New System.Drawing.Point(104, 208)
        Me.Sadereh.MaxLength = 50
        Me.Sadereh.Name = "Sadereh"
        Me.Sadereh.Size = New System.Drawing.Size(120, 23)
        Me.Sadereh.TabIndex = 6
        Me.Sadereh.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(352, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 24)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "صادره :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SHenasnameNum
        '
        Me.SHenasnameNum.Location = New System.Drawing.Point(104, 176)
        Me.SHenasnameNum.MaxLength = 50
        Me.SHenasnameNum.Name = "SHenasnameNum"
        Me.SHenasnameNum.Size = New System.Drawing.Size(120, 23)
        Me.SHenasnameNum.TabIndex = 5
        Me.SHenasnameNum.Text = ""
        Me.SHenasnameNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(296, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 24)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "شماره شناسنامه :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Farzand
        '
        Me.Farzand.Location = New System.Drawing.Point(104, 144)
        Me.Farzand.MaxLength = 50
        Me.Farzand.Name = "Farzand"
        Me.Farzand.Size = New System.Drawing.Size(120, 23)
        Me.Farzand.TabIndex = 4
        Me.Farzand.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(360, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 24)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "فرزند :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(320, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "سرمایه گذار :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(0, 520)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(24, 23)
        Me.ID.TabIndex = 51
        Me.ID.Text = ""
        Me.ID.Visible = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label12.Location = New System.Drawing.Point(312, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label12.Size = New System.Drawing.Size(96, 24)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "شماره قرارداد :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tozih
        '
        Me.Tozih.Location = New System.Drawing.Point(104, 336)
        Me.Tozih.MaxLength = 250
        Me.Tozih.Name = "Tozih"
        Me.Tozih.Size = New System.Drawing.Size(120, 23)
        Me.Tozih.TabIndex = 10
        Me.Tozih.Text = ""
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label14.Location = New System.Drawing.Point(344, 336)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 24)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "توضیحات :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tell
        '
        Me.Tell.Location = New System.Drawing.Point(104, 304)
        Me.Tell.MaxLength = 50
        Me.Tell.Name = "Tell"
        Me.Tell.Size = New System.Drawing.Size(120, 23)
        Me.Tell.TabIndex = 9
        Me.Tell.Text = ""
        Me.Tell.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label13.Location = New System.Drawing.Point(368, 304)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 24)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "تلفن :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GharardadNum
        '
        Me.GharardadNum.BackColor = System.Drawing.Color.White
        Me.GharardadNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GharardadNum.Location = New System.Drawing.Point(104, 16)
        Me.GharardadNum.Name = "GharardadNum"
        Me.GharardadNum.Size = New System.Drawing.Size(120, 23)
        Me.GharardadNum.TabIndex = 59
        Me.GharardadNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SLName
        '
        Me.SLName.Location = New System.Drawing.Point(16, 80)
        Me.SLName.MaxLength = 50
        Me.SLName.Name = "SLName"
        Me.SLName.Size = New System.Drawing.Size(120, 23)
        Me.SLName.TabIndex = 62
        Me.SLName.Text = ""
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label15.Location = New System.Drawing.Point(136, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 24)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "نام خانوادگی :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SFName
        '
        Me.SFName.Location = New System.Drawing.Point(232, 80)
        Me.SFName.MaxLength = 50
        Me.SFName.Name = "SFName"
        Me.SFName.Size = New System.Drawing.Size(120, 23)
        Me.SFName.TabIndex = 60
        Me.SFName.Text = ""
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label16.Location = New System.Drawing.Point(352, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 24)
        Me.Label16.TabIndex = 61
        Me.Label16.Text = "نام :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SetDefaultB
        '
        Me.SetDefaultB.BackColor = System.Drawing.SystemColors.Control
        Me.SetDefaultB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.SetDefaultB.Image = CType(resources.GetObject("SetDefaultB.Image"), System.Drawing.Image)
        Me.SetDefaultB.Location = New System.Drawing.Point(16, 368)
        Me.SetDefaultB.Name = "SetDefaultB"
        Me.SetDefaultB.Size = New System.Drawing.Size(32, 20)
        Me.SetDefaultB.TabIndex = 11
        Me.SetDefaultB.TabStop = False
        '
        'SetNowB
        '
        Me.SetNowB.BackColor = System.Drawing.SystemColors.Control
        Me.SetNowB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.SetNowB.Image = CType(resources.GetObject("SetNowB.Image"), System.Drawing.Image)
        Me.SetNowB.Location = New System.Drawing.Point(16, 400)
        Me.SetNowB.Name = "SetNowB"
        Me.SetNowB.Size = New System.Drawing.Size(32, 20)
        Me.SetNowB.TabIndex = 12
        Me.SetNowB.TabStop = False
        '
        'SGEditF
        '
        Me.AcceptButton = Me.EditB
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.CancelB
        Me.ClientSize = New System.Drawing.Size(426, 536)
        Me.Controls.Add(Me.SetNowB)
        Me.Controls.Add(Me.SetDefaultB)
        Me.Controls.Add(Me.SLName)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.SFName)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GharardadNum)
        Me.Controls.Add(Me.Tozih)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Tell)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Male)
        Me.Controls.Add(Me.Mablagh)
        Me.Controls.Add(Me.Mahiane)
        Me.Controls.Add(Me.Addrress)
        Me.Controls.Add(Me.YBirth)
        Me.Controls.Add(Me.Sadereh)
        Me.Controls.Add(Me.SHenasnameNum)
        Me.Controls.Add(Me.Farzand)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Female)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CancelB)
        Me.Controls.Add(Me.EditB)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ChangeFB)
        Me.Controls.Add(Me.ChangeGhB)
        Me.Controls.Add(Me.TarikheFa)
        Me.Controls.Add(Me.TarikheGha)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SGEditF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.Text = "ویرایش اطلاعات سرمایه گذار"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Decs"

    Dim DBConn As DBConnection
    Dim err As System.Exception
    Dim iCounter As Integer
    Dim TarikheG, TarikheF, Temp As String

#End Region

    Private Sub SGEditF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadKeyboardLayout("00000429", 1)
        Get_Setting()
    End Sub

    Private Sub SGEditF_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        LoadKeyboardLayout("00000409", 1)
    End Sub

    Private Sub Get_Setting()
        Try
            DBConn = New DBConnection
            DBConn.connectMe("SELECT * FROM SGozari WHERE ID = " & ID.Text & ";")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d.Read
                    GharardadNum.Text = d("GharardadNum".ToString)
                    SFName.Text = d("SFName".ToString)
                    SLName.Text = d("SLName".ToString)
                    Male.Checked = d("Male".ToString)
                    Female.Checked = d("Female".ToString)
                    Farzand.Text = d("Farzand".ToString)
                    SHenasnameNum.Text = d("SHenasnameNum".ToString)
                    Sadereh.Text = d("Sadereh".ToString)
                    YBirth.Text = d("YBirth".ToString)
                    Addrress.Text = d("Addrress".ToString)
                    Tell.Text = d("Tell".ToString)
                    Tozih.Text = d("Tozih".ToString)
                    TarikheG = d("FT".ToString)
                    TarikheF = d("TT".ToString)
                    Mahiane.Text = d("Mahiane".ToString)
                    Mablagh.Text = d("Mablagh".ToString)
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
        TarikheGha.Text = TarikheG
        TarikheFa.Text = TarikheF
    End Sub

    Private Sub EditB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditB.Click
        Me.Enabled = False
        If IsNullChr("Int", GharardadNum.Text) = False Then MsgBox("خطا در نوشتن شماره قرارداد", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش سرمایه گذاری") : GoTo Get_Error
        If IsNullChr("Str", SFName.Text) = False Then MsgBox("خطا در نوشتن نام سرمایه گذار", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش سرمایه گذاری") : GoTo Get_Error
        If IsNullChr("Str", SLName.Text) = False Then MsgBox("خطا در نوشتن نام خانوادگی سرمایه گذار", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش سرمایه گذاری") : GoTo Get_Error
        If IsNullChr("Str", Farzand.Text) = False Then MsgBox("خطا در نوشتن نام پدر", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش سرمایه گذاری") : GoTo Get_Error
        If IsNullChr("Str", SHenasnameNum.Text) = False Then MsgBox("خطا در نوشتن شماره شناسنامه", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش سرمایه گذاری") : GoTo Get_Error
        If IsNullChr("Str", Sadereh.Text) = False Then MsgBox("خطا در نوشتن محل صدور پرونده", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش سرمایه گذاری") : GoTo Get_Error
        If IsNullChr("Int", YBirth.Text) = False Then MsgBox("خطا در نوشتن سال تولد", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش سرمایه گذاری") : GoTo Get_Error
        If IsNullChr("Str", Addrress.Text) = False Then MsgBox("خطا در نوشتن آدرس ", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش سرمایه گذاری") : GoTo Get_Error
        If IsNullChr("Int", Tell.Text, False) = False Then MsgBox("خطا در نوشتن تلفن ", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش سرمایه گذاری") : GoTo Get_Error
        If IsNullChr("Str", Tozih.Text, False) = False Then MsgBox("خطا در نوشتن توضیحات ", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش سرمایه گذاری") : GoTo Get_Error
        If IsNullChr("Int", Mahiane.Text) = False Then MsgBox("خطا در نوشتن مبلغ پرداختی به سرمایه گذار", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش سرمایه گذاری") : GoTo Get_Error
        If IsNullChr("Int", Mablagh.Text) = False Then MsgBox("خطا در نوشتن مبلغ سرمایه", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش سرمایه گذاری") : GoTo Get_Error
        Try
            DBConn = New DBConnection
            DBConn.connectMe("Update SGozari SET GharardadNum=" & GharardadNum.Text & ",SFName='" & SFName.Text & "',SLName='" & SLName.Text & "',Farzand='" & Farzand.Text & "',SHenasnameNum='" & SHenasnameNum.Text & "',Sadereh='" & Sadereh.Text & "',YBirth='" & YBirth.Text & "',Addrress='" & Addrress.Text & "',Tell='" & Tell.Text & "',Tozih='" & Tozih.Text & "',FT='" & TarikheGha.Text & "',TT='" & TarikheFa.Text & "',Mahiane='" & Mahiane.Text & "',Mablagh='" & Mablagh.Text & "',Male=" & Male.Checked & ",Female=" & Female.Checked & " WHERE ID=" & ID.Text & ";")
            DBConn.OLEComm.Connection = DBConn.OLEConn
            DBConn.OLEComm.ExecuteNonQuery()
            DBConn.OLEConn.Close()
        Catch err As System.Exception
            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            GoTo Get_Error
        End Try
        Try
            DBConn = New DBConnection
            DBConn.connectMe("Delete From AnySGozari WHERE GharardadNum='" & GharardadNum.Text & "';")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                DBConn.OLEComm.ExecuteNonQuery()
                DBConn.OLEConn.Close()
                Try
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    GoTo Get_Error
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                GoTo Get_Error
            End Try
        Catch err As System.Exception
            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            GoTo Get_Error
        End Try
        Try
            DBConn = New DBConnection
            DBConn.connectMe("SELECT * FROM MoshtariList WHERE IsBlackCancel=False ORDER BY SHParvandeNum;")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d.Read
                    If SFName.Text & " " & SLName.Text = d("MoajerFN".ToString) & " " & d("MoajerLN".ToString) Then
                        Try
                            DBConn = New DBConnection
                            DBConn.connectMe("Insert Into AnySGozari (GharardadNum,CGGold,SHParvandeNum,Mostajer) Values ('" & GharardadNum.Text & "', '" & d("CGGold".ToString) & "', '" & d("SHParvandeNum".ToString) & "', '" & d("MostajerFN".ToString) & " " & d("MostajerLN".ToString) & "');")
                            Try
                                DBConn.OLEComm.Connection = DBConn.OLEConn
                                DBConn.OLEComm.ExecuteNonQuery()
                                DBConn.OLEConn.Close()
                            Catch err As System.Exception
                                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                                GoTo Get_Error
                            End Try
                            Try
                                DBConn.OLEConn.Close()
                            Catch err As System.Exception
                                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                                GoTo Get_Error
                            End Try
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                            GoTo Get_Error
                        End Try
                    End If
                Loop
                Try
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    GoTo Get_Error
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                GoTo Get_Error
            End Try
        Catch err As System.Exception
            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            GoTo Get_Error
        End Try
        Me.Close()
        Exit Sub
Get_Error:
        Me.Enabled = True
    End Sub

    Private Sub ChangeGhB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeGhB.Click
        Dim InputBoxForm As New InputBoxF
        InputBoxForm.TVosool.Text = TarikheGha.Text
        InputBoxForm.Message.Text = "لطفا در صورت اشتباه بودن تاریخ قرارداد درج شده توسط برنامه تاریخ قرارداد صحیح را وارد کنید."
        InputBoxForm.ShowDialog()
        TarikheGha.Text = InputBoxForm.TVosool.Text
        Temp = InputBoxForm.TVosool.Text
        TarikheFa.Text = Replace(Temp, Microsoft.VisualBasic.Left(Temp, 2), (Int(Microsoft.VisualBasic.Left(Temp, 2)) + 1))
    End Sub

    Private Sub ChangeFB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeFB.Click
        Dim InputBoxForm As New InputBoxF
        InputBoxForm.TVosool.Text = TarikheFa.Text
        InputBoxForm.Message.Text = "لطفا در صورت اشتباه بودن تاریخ قرارداد درج شده توسط برنامه تاریخ قرارداد صحیح را وارد کنید."
        InputBoxForm.ShowDialog()
        TarikheFa.Text = InputBoxForm.TVosool.Text
    End Sub

    Private Sub SetDefaultB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetDefaultB.Click
        TarikheGha.Text = TarikheG
        TarikheFa.Text = TarikheF
    End Sub

    Private Sub SetNowB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetNowB.Click
        TarikheGha.Text = Shamsi()
        TarikheFa.Text = Shamsi(1)
    End Sub
End Class
