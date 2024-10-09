Public Class EditF
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
    Friend WithEvents AghsatCount As System.Windows.Forms.ComboBox
    Friend WithEvents Tozihat As System.Windows.Forms.TextBox
    Friend WithEvents MoPerson As System.Windows.Forms.TextBox
    Friend WithEvents Adrress As System.Windows.Forms.TextBox
    Friend WithEvents MablagheGh As System.Windows.Forms.TextBox
    Friend WithEvents MCancelMB As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MEditMB As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.TextBox
    Friend WithEvents JTakhir As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents NTashilat As System.Windows.Forms.Label
    Friend WithEvents ChangeB As System.Windows.Forms.Button
    Friend WithEvents TarikheFa As System.Windows.Forms.Label
    Friend WithEvents TarikheGha As System.Windows.Forms.Label
    Friend WithEvents VAghsatCount As System.Windows.Forms.TextBox
    Friend WithEvents MoajerFN As System.Windows.Forms.TextBox
    Friend WithEvents MoajerLN As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents MostajerFN As System.Windows.Forms.TextBox
    Friend WithEvents MostajerLN As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents MablagheVKH As System.Windows.Forms.TextBox
    Friend WithEvents SHParvandeNum As System.Windows.Forms.Label
    Friend WithEvents AddSGB As System.Windows.Forms.Button
    Friend WithEvents CGGold As System.Windows.Forms.TextBox
    Friend WithEvents VPicExist As System.Windows.Forms.CheckBox
    Friend WithEvents OpenGoldPic As System.Windows.Forms.OpenFileDialog
    Friend WithEvents VGoldPicPath As System.Windows.Forms.TextBox
    Friend WithEvents PicList As System.Windows.Forms.ImageList
    Friend WithEvents PicTabControl As System.Windows.Forms.TabControl
    Friend WithEvents GoldPicTab As System.Windows.Forms.TabPage
    Friend WithEvents GoldPanel As System.Windows.Forms.Panel
    Friend WithEvents PicPrev As System.Windows.Forms.PictureBox
    Friend WithEvents GoldPicBrowse As System.Windows.Forms.Button
    Friend WithEvents GoldPicPath As System.Windows.Forms.TextBox
    Friend WithEvents PicExist As System.Windows.Forms.CheckBox
    Friend WithEvents MoshtariPicTab As System.Windows.Forms.TabPage
    Friend WithEvents MPanel As System.Windows.Forms.Panel
    Friend WithEvents MPicPrev As System.Windows.Forms.PictureBox
    Friend WithEvents MPicBrowse As System.Windows.Forms.Button
    Friend WithEvents MPicPath As System.Windows.Forms.TextBox
    Friend WithEvents MPicExist As System.Windows.Forms.CheckBox
    Friend WithEvents TabIconList As System.Windows.Forms.ImageList
    Friend WithEvents MPicList As System.Windows.Forms.ImageList
    Friend WithEvents VMPicPath As System.Windows.Forms.TextBox
    Friend WithEvents VMPicExist As System.Windows.Forms.CheckBox
    Friend WithEvents Mobile As System.Windows.Forms.TextBox
    Friend WithEvents Office As System.Windows.Forms.TextBox
    Friend WithEvents Tell As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(EditF))
        Me.AghsatCount = New System.Windows.Forms.ComboBox
        Me.Tozihat = New System.Windows.Forms.TextBox
        Me.MoPerson = New System.Windows.Forms.TextBox
        Me.Adrress = New System.Windows.Forms.TextBox
        Me.CGGold = New System.Windows.Forms.TextBox
        Me.MablagheGh = New System.Windows.Forms.TextBox
        Me.MCancelMB = New System.Windows.Forms.Button
        Me.MEditMB = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ID = New System.Windows.Forms.TextBox
        Me.JTakhir = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.NTashilat = New System.Windows.Forms.Label
        Me.ChangeB = New System.Windows.Forms.Button
        Me.TarikheFa = New System.Windows.Forms.Label
        Me.TarikheGha = New System.Windows.Forms.Label
        Me.VAghsatCount = New System.Windows.Forms.TextBox
        Me.MoajerFN = New System.Windows.Forms.TextBox
        Me.MoajerLN = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.MostajerFN = New System.Windows.Forms.TextBox
        Me.MostajerLN = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.MablagheVKH = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.SHParvandeNum = New System.Windows.Forms.Label
        Me.AddSGB = New System.Windows.Forms.Button
        Me.VPicExist = New System.Windows.Forms.CheckBox
        Me.OpenGoldPic = New System.Windows.Forms.OpenFileDialog
        Me.VGoldPicPath = New System.Windows.Forms.TextBox
        Me.PicList = New System.Windows.Forms.ImageList(Me.components)
        Me.PicTabControl = New System.Windows.Forms.TabControl
        Me.GoldPicTab = New System.Windows.Forms.TabPage
        Me.GoldPanel = New System.Windows.Forms.Panel
        Me.PicPrev = New System.Windows.Forms.PictureBox
        Me.GoldPicBrowse = New System.Windows.Forms.Button
        Me.GoldPicPath = New System.Windows.Forms.TextBox
        Me.PicExist = New System.Windows.Forms.CheckBox
        Me.MoshtariPicTab = New System.Windows.Forms.TabPage
        Me.MPanel = New System.Windows.Forms.Panel
        Me.MPicPrev = New System.Windows.Forms.PictureBox
        Me.MPicBrowse = New System.Windows.Forms.Button
        Me.MPicPath = New System.Windows.Forms.TextBox
        Me.MPicExist = New System.Windows.Forms.CheckBox
        Me.TabIconList = New System.Windows.Forms.ImageList(Me.components)
        Me.MPicList = New System.Windows.Forms.ImageList(Me.components)
        Me.VMPicPath = New System.Windows.Forms.TextBox
        Me.VMPicExist = New System.Windows.Forms.CheckBox
        Me.Mobile = New System.Windows.Forms.TextBox
        Me.Office = New System.Windows.Forms.TextBox
        Me.Tell = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.PicTabControl.SuspendLayout()
        Me.GoldPicTab.SuspendLayout()
        Me.GoldPanel.SuspendLayout()
        Me.MoshtariPicTab.SuspendLayout()
        Me.MPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'AghsatCount
        '
        Me.AghsatCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AghsatCount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.AghsatCount.Location = New System.Drawing.Point(216, 80)
        Me.AghsatCount.Name = "AghsatCount"
        Me.AghsatCount.Size = New System.Drawing.Size(128, 24)
        Me.AghsatCount.TabIndex = 3
        '
        'Tozihat
        '
        Me.Tozihat.Location = New System.Drawing.Point(56, 560)
        Me.Tozihat.MaxLength = 0
        Me.Tozihat.Name = "Tozihat"
        Me.Tozihat.Size = New System.Drawing.Size(288, 23)
        Me.Tozihat.TabIndex = 16
        Me.Tozihat.Text = ""
        '
        'MoPerson
        '
        Me.MoPerson.Location = New System.Drawing.Point(56, 528)
        Me.MoPerson.MaxLength = 0
        Me.MoPerson.Name = "MoPerson"
        Me.MoPerson.Size = New System.Drawing.Size(288, 23)
        Me.MoPerson.TabIndex = 15
        Me.MoPerson.Text = ""
        '
        'Adrress
        '
        Me.Adrress.Location = New System.Drawing.Point(56, 432)
        Me.Adrress.MaxLength = 0
        Me.Adrress.Name = "Adrress"
        Me.Adrress.Size = New System.Drawing.Size(288, 23)
        Me.Adrress.TabIndex = 12
        Me.Adrress.Text = ""
        '
        'CGGold
        '
        Me.CGGold.Location = New System.Drawing.Point(216, 336)
        Me.CGGold.MaxLength = 11
        Me.CGGold.Name = "CGGold"
        Me.CGGold.Size = New System.Drawing.Size(128, 23)
        Me.CGGold.TabIndex = 10
        Me.CGGold.Text = ""
        Me.CGGold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MablagheGh
        '
        Me.MablagheGh.Location = New System.Drawing.Point(216, 112)
        Me.MablagheGh.MaxLength = 50
        Me.MablagheGh.Name = "MablagheGh"
        Me.MablagheGh.Size = New System.Drawing.Size(128, 23)
        Me.MablagheGh.TabIndex = 4
        Me.MablagheGh.Text = ""
        Me.MablagheGh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MCancelMB
        '
        Me.MCancelMB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.MCancelMB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.MCancelMB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MCancelMB.Location = New System.Drawing.Point(152, 592)
        Me.MCancelMB.Name = "MCancelMB"
        Me.MCancelMB.Size = New System.Drawing.Size(96, 23)
        Me.MCancelMB.TabIndex = 18
        Me.MCancelMB.Text = "لغو"
        '
        'MEditMB
        '
        Me.MEditMB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.MEditMB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MEditMB.Location = New System.Drawing.Point(264, 592)
        Me.MEditMB.Name = "MEditMB"
        Me.MEditMB.Size = New System.Drawing.Size(96, 23)
        Me.MEditMB.TabIndex = 17
        Me.MEditMB.Text = "ذخیره تغییرات"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label13.Location = New System.Drawing.Point(432, 560)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 24)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "توضیحات :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label12.Location = New System.Drawing.Point(376, 528)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 24)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "مشخصات شخصی :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.Location = New System.Drawing.Point(448, 432)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 24)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "آدرس :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.Location = New System.Drawing.Point(416, 400)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 24)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "تاریخ فسخ :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(416, 368)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 24)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "تاریخ قرارداد :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(400, 336)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 24)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "مقدار گرم طلا :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(432, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 24)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "مستاجر :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(448, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 24)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "موجر :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(416, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 24)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "مبلغ اقساط :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(408, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "تعداد اقساط :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(408, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "نوع تسهیلات :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(408, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "شماره پرونده :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(0, 616)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(24, 23)
        Me.ID.TabIndex = 52
        Me.ID.TabStop = False
        Me.ID.Text = ""
        Me.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ID.Visible = False
        '
        'JTakhir
        '
        Me.JTakhir.Location = New System.Drawing.Point(216, 144)
        Me.JTakhir.MaxLength = 50
        Me.JTakhir.Name = "JTakhir"
        Me.JTakhir.Size = New System.Drawing.Size(128, 23)
        Me.JTakhir.TabIndex = 5
        Me.JTakhir.Text = ""
        Me.JTakhir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label18.Location = New System.Drawing.Point(376, 144)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(120, 24)
        Me.Label18.TabIndex = 53
        Me.Label18.Text = "جریمه تاخیر روزانه :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NTashilat
        '
        Me.NTashilat.BackColor = System.Drawing.Color.White
        Me.NTashilat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NTashilat.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.NTashilat.Location = New System.Drawing.Point(216, 48)
        Me.NTashilat.Name = "NTashilat"
        Me.NTashilat.Size = New System.Drawing.Size(128, 23)
        Me.NTashilat.TabIndex = 2
        Me.NTashilat.Text = "موبایل قسطی"
        Me.NTashilat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ChangeB
        '
        Me.ChangeB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.ChangeB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ChangeB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChangeB.Location = New System.Drawing.Point(168, 368)
        Me.ChangeB.Name = "ChangeB"
        Me.ChangeB.Size = New System.Drawing.Size(40, 20)
        Me.ChangeB.TabIndex = 11
        Me.ChangeB.Text = "تغییر"
        '
        'TarikheFa
        '
        Me.TarikheFa.BackColor = System.Drawing.Color.White
        Me.TarikheFa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TarikheFa.Location = New System.Drawing.Point(216, 400)
        Me.TarikheFa.Name = "TarikheFa"
        Me.TarikheFa.Size = New System.Drawing.Size(128, 23)
        Me.TarikheFa.TabIndex = 65
        Me.TarikheFa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TarikheGha
        '
        Me.TarikheGha.BackColor = System.Drawing.Color.White
        Me.TarikheGha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TarikheGha.Location = New System.Drawing.Point(216, 368)
        Me.TarikheGha.Name = "TarikheGha"
        Me.TarikheGha.Size = New System.Drawing.Size(128, 23)
        Me.TarikheGha.TabIndex = 64
        Me.TarikheGha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VAghsatCount
        '
        Me.VAghsatCount.Location = New System.Drawing.Point(24, 616)
        Me.VAghsatCount.Name = "VAghsatCount"
        Me.VAghsatCount.Size = New System.Drawing.Size(24, 23)
        Me.VAghsatCount.TabIndex = 67
        Me.VAghsatCount.TabStop = False
        Me.VAghsatCount.Text = ""
        Me.VAghsatCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.VAghsatCount.Visible = False
        '
        'MoajerFN
        '
        Me.MoajerFN.Location = New System.Drawing.Point(320, 240)
        Me.MoajerFN.MaxLength = 20
        Me.MoajerFN.Name = "MoajerFN"
        Me.MoajerFN.Size = New System.Drawing.Size(104, 23)
        Me.MoajerFN.TabIndex = 6
        Me.MoajerFN.Text = ""
        '
        'MoajerLN
        '
        Me.MoajerLN.Location = New System.Drawing.Point(72, 240)
        Me.MoajerLN.MaxLength = 30
        Me.MoajerLN.Name = "MoajerLN"
        Me.MoajerLN.Size = New System.Drawing.Size(152, 23)
        Me.MoajerLN.TabIndex = 7
        Me.MoajerLN.Text = ""
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label16.Location = New System.Drawing.Point(224, 240)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 24)
        Me.Label16.TabIndex = 70
        Me.Label16.Text = "نام خانوادگی :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label15.Location = New System.Drawing.Point(424, 240)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 24)
        Me.Label15.TabIndex = 69
        Me.Label15.Text = "نام :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MostajerFN
        '
        Me.MostajerFN.Location = New System.Drawing.Point(320, 304)
        Me.MostajerFN.MaxLength = 20
        Me.MostajerFN.Name = "MostajerFN"
        Me.MostajerFN.Size = New System.Drawing.Size(104, 23)
        Me.MostajerFN.TabIndex = 8
        Me.MostajerFN.Text = ""
        '
        'MostajerLN
        '
        Me.MostajerLN.Location = New System.Drawing.Point(72, 304)
        Me.MostajerLN.MaxLength = 30
        Me.MostajerLN.Name = "MostajerLN"
        Me.MostajerLN.Size = New System.Drawing.Size(152, 23)
        Me.MostajerLN.TabIndex = 9
        Me.MostajerLN.Text = ""
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label17.Location = New System.Drawing.Point(224, 304)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 24)
        Me.Label17.TabIndex = 74
        Me.Label17.Text = "نام خانوادگی :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label14.Location = New System.Drawing.Point(424, 304)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 24)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "نام :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MablagheVKH
        '
        Me.MablagheVKH.Location = New System.Drawing.Point(216, 176)
        Me.MablagheVKH.MaxLength = 50
        Me.MablagheVKH.Name = "MablagheVKH"
        Me.MablagheVKH.Size = New System.Drawing.Size(128, 23)
        Me.MablagheVKH.TabIndex = 75
        Me.MablagheVKH.Text = ""
        Me.MablagheVKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label19.Location = New System.Drawing.Point(408, 176)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 24)
        Me.Label19.TabIndex = 76
        Me.Label19.Text = "مبلغ وام خط :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SHParvandeNum
        '
        Me.SHParvandeNum.BackColor = System.Drawing.Color.White
        Me.SHParvandeNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SHParvandeNum.Location = New System.Drawing.Point(216, 16)
        Me.SHParvandeNum.Name = "SHParvandeNum"
        Me.SHParvandeNum.Size = New System.Drawing.Size(128, 23)
        Me.SHParvandeNum.TabIndex = 1
        Me.SHParvandeNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AddSGB
        '
        Me.AddSGB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.AddSGB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AddSGB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.AddSGB.Location = New System.Drawing.Point(16, 240)
        Me.AddSGB.Name = "AddSGB"
        Me.AddSGB.Size = New System.Drawing.Size(48, 20)
        Me.AddSGB.TabIndex = 77
        Me.AddSGB.Text = "جستجو"
        '
        'VPicExist
        '
        Me.VPicExist.Location = New System.Drawing.Point(72, 616)
        Me.VPicExist.Name = "VPicExist"
        Me.VPicExist.Size = New System.Drawing.Size(16, 16)
        Me.VPicExist.TabIndex = 81
        Me.VPicExist.Visible = False
        '
        'OpenGoldPic
        '
        Me.OpenGoldPic.Filter = "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg"
        Me.OpenGoldPic.Title = "باز کردن عکس طلا"
        '
        'VGoldPicPath
        '
        Me.VGoldPicPath.BackColor = System.Drawing.Color.White
        Me.VGoldPicPath.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.VGoldPicPath.Location = New System.Drawing.Point(48, 616)
        Me.VGoldPicPath.Name = "VGoldPicPath"
        Me.VGoldPicPath.ReadOnly = True
        Me.VGoldPicPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.VGoldPicPath.Size = New System.Drawing.Size(24, 20)
        Me.VGoldPicPath.TabIndex = 82
        Me.VGoldPicPath.Text = ""
        Me.VGoldPicPath.Visible = False
        '
        'PicList
        '
        Me.PicList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.PicList.ImageSize = New System.Drawing.Size(160, 112)
        Me.PicList.TransparentColor = System.Drawing.Color.Transparent
        '
        'PicTabControl
        '
        Me.PicTabControl.Controls.Add(Me.GoldPicTab)
        Me.PicTabControl.Controls.Add(Me.MoshtariPicTab)
        Me.PicTabControl.ImageList = Me.TabIconList
        Me.PicTabControl.Location = New System.Drawing.Point(16, 16)
        Me.PicTabControl.Multiline = True
        Me.PicTabControl.Name = "PicTabControl"
        Me.PicTabControl.SelectedIndex = 0
        Me.PicTabControl.Size = New System.Drawing.Size(184, 208)
        Me.PicTabControl.TabIndex = 87
        '
        'GoldPicTab
        '
        Me.GoldPicTab.Controls.Add(Me.GoldPanel)
        Me.GoldPicTab.Controls.Add(Me.PicExist)
        Me.GoldPicTab.ImageIndex = 0
        Me.GoldPicTab.Location = New System.Drawing.Point(4, 25)
        Me.GoldPicTab.Name = "GoldPicTab"
        Me.GoldPicTab.Size = New System.Drawing.Size(176, 179)
        Me.GoldPicTab.TabIndex = 0
        Me.GoldPicTab.Text = "طلا"
        '
        'GoldPanel
        '
        Me.GoldPanel.Controls.Add(Me.PicPrev)
        Me.GoldPanel.Controls.Add(Me.GoldPicBrowse)
        Me.GoldPanel.Controls.Add(Me.GoldPicPath)
        Me.GoldPanel.Location = New System.Drawing.Point(0, 32)
        Me.GoldPanel.Name = "GoldPanel"
        Me.GoldPanel.Size = New System.Drawing.Size(176, 144)
        Me.GoldPanel.TabIndex = 29
        '
        'PicPrev
        '
        Me.PicPrev.BackColor = System.Drawing.Color.White
        Me.PicPrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicPrev.Location = New System.Drawing.Point(8, 28)
        Me.PicPrev.Name = "PicPrev"
        Me.PicPrev.Size = New System.Drawing.Size(160, 112)
        Me.PicPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicPrev.TabIndex = 9
        Me.PicPrev.TabStop = False
        '
        'GoldPicBrowse
        '
        Me.GoldPicBrowse.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.GoldPicBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GoldPicBrowse.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GoldPicBrowse.Location = New System.Drawing.Point(8, 4)
        Me.GoldPicBrowse.Name = "GoldPicBrowse"
        Me.GoldPicBrowse.Size = New System.Drawing.Size(48, 20)
        Me.GoldPicBrowse.TabIndex = 8
        Me.GoldPicBrowse.Text = "جستجو"
        '
        'GoldPicPath
        '
        Me.GoldPicPath.BackColor = System.Drawing.Color.White
        Me.GoldPicPath.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GoldPicPath.Location = New System.Drawing.Point(64, 4)
        Me.GoldPicPath.MaxLength = 0
        Me.GoldPicPath.Name = "GoldPicPath"
        Me.GoldPicPath.ReadOnly = True
        Me.GoldPicPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GoldPicPath.Size = New System.Drawing.Size(104, 20)
        Me.GoldPicPath.TabIndex = 7
        Me.GoldPicPath.Text = ""
        '
        'PicExist
        '
        Me.PicExist.Checked = True
        Me.PicExist.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PicExist.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.PicExist.Location = New System.Drawing.Point(88, 8)
        Me.PicExist.Name = "PicExist"
        Me.PicExist.Size = New System.Drawing.Size(80, 24)
        Me.PicExist.TabIndex = 28
        Me.PicExist.Text = "عکس طلا"
        Me.PicExist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MoshtariPicTab
        '
        Me.MoshtariPicTab.Controls.Add(Me.MPanel)
        Me.MoshtariPicTab.Controls.Add(Me.MPicExist)
        Me.MoshtariPicTab.ImageIndex = 1
        Me.MoshtariPicTab.Location = New System.Drawing.Point(4, 25)
        Me.MoshtariPicTab.Name = "MoshtariPicTab"
        Me.MoshtariPicTab.Size = New System.Drawing.Size(176, 179)
        Me.MoshtariPicTab.TabIndex = 1
        Me.MoshtariPicTab.Text = "مشتری"
        Me.MoshtariPicTab.Visible = False
        '
        'MPanel
        '
        Me.MPanel.Controls.Add(Me.MPicPrev)
        Me.MPanel.Controls.Add(Me.MPicBrowse)
        Me.MPanel.Controls.Add(Me.MPicPath)
        Me.MPanel.Location = New System.Drawing.Point(0, 32)
        Me.MPanel.Name = "MPanel"
        Me.MPanel.Size = New System.Drawing.Size(176, 144)
        Me.MPanel.TabIndex = 31
        '
        'MPicPrev
        '
        Me.MPicPrev.BackColor = System.Drawing.Color.White
        Me.MPicPrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MPicPrev.Location = New System.Drawing.Point(8, 28)
        Me.MPicPrev.Name = "MPicPrev"
        Me.MPicPrev.Size = New System.Drawing.Size(160, 112)
        Me.MPicPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MPicPrev.TabIndex = 9
        Me.MPicPrev.TabStop = False
        '
        'MPicBrowse
        '
        Me.MPicBrowse.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.MPicBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MPicBrowse.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MPicBrowse.Location = New System.Drawing.Point(8, 4)
        Me.MPicBrowse.Name = "MPicBrowse"
        Me.MPicBrowse.Size = New System.Drawing.Size(48, 20)
        Me.MPicBrowse.TabIndex = 8
        Me.MPicBrowse.Text = "جستجو"
        '
        'MPicPath
        '
        Me.MPicPath.BackColor = System.Drawing.Color.White
        Me.MPicPath.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MPicPath.Location = New System.Drawing.Point(64, 4)
        Me.MPicPath.MaxLength = 0
        Me.MPicPath.Name = "MPicPath"
        Me.MPicPath.ReadOnly = True
        Me.MPicPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MPicPath.Size = New System.Drawing.Size(104, 20)
        Me.MPicPath.TabIndex = 7
        Me.MPicPath.Text = ""
        '
        'MPicExist
        '
        Me.MPicExist.Checked = True
        Me.MPicExist.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MPicExist.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MPicExist.Location = New System.Drawing.Point(64, 8)
        Me.MPicExist.Name = "MPicExist"
        Me.MPicExist.TabIndex = 30
        Me.MPicExist.Text = "عکس مشتری"
        Me.MPicExist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabIconList
        '
        Me.TabIconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.TabIconList.ImageSize = New System.Drawing.Size(16, 16)
        Me.TabIconList.ImageStream = CType(resources.GetObject("TabIconList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.TabIconList.TransparentColor = System.Drawing.Color.Transparent
        '
        'MPicList
        '
        Me.MPicList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.MPicList.ImageSize = New System.Drawing.Size(160, 120)
        Me.MPicList.TransparentColor = System.Drawing.Color.Transparent
        '
        'VMPicPath
        '
        Me.VMPicPath.BackColor = System.Drawing.Color.White
        Me.VMPicPath.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.VMPicPath.Location = New System.Drawing.Point(88, 616)
        Me.VMPicPath.Name = "VMPicPath"
        Me.VMPicPath.ReadOnly = True
        Me.VMPicPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.VMPicPath.Size = New System.Drawing.Size(24, 20)
        Me.VMPicPath.TabIndex = 89
        Me.VMPicPath.Text = ""
        Me.VMPicPath.Visible = False
        '
        'VMPicExist
        '
        Me.VMPicExist.Location = New System.Drawing.Point(112, 616)
        Me.VMPicExist.Name = "VMPicExist"
        Me.VMPicExist.Size = New System.Drawing.Size(16, 16)
        Me.VMPicExist.TabIndex = 88
        Me.VMPicExist.Visible = False
        '
        'Mobile
        '
        Me.Mobile.Location = New System.Drawing.Point(24, 496)
        Me.Mobile.MaxLength = 12
        Me.Mobile.Name = "Mobile"
        Me.Mobile.Size = New System.Drawing.Size(96, 23)
        Me.Mobile.TabIndex = 95
        Me.Mobile.Text = ""
        Me.Mobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Office
        '
        Me.Office.Location = New System.Drawing.Point(176, 496)
        Me.Office.MaxLength = 12
        Me.Office.Name = "Office"
        Me.Office.Size = New System.Drawing.Size(96, 23)
        Me.Office.TabIndex = 92
        Me.Office.Text = ""
        Me.Office.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tell
        '
        Me.Tell.Location = New System.Drawing.Point(336, 496)
        Me.Tell.MaxLength = 12
        Me.Tell.Name = "Tell"
        Me.Tell.Size = New System.Drawing.Size(96, 23)
        Me.Tell.TabIndex = 91
        Me.Tell.Text = ""
        Me.Tell.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.Location = New System.Drawing.Point(456, 464)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 24)
        Me.Label11.TabIndex = 90
        Me.Label11.Text = "تلفن :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label22.Location = New System.Drawing.Point(120, 496)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 24)
        Me.Label22.TabIndex = 96
        Me.Label22.Text = "موبایل :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label20.Location = New System.Drawing.Point(272, 496)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 24)
        Me.Label20.TabIndex = 93
        Me.Label20.Text = "محل کار :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label21.Location = New System.Drawing.Point(432, 496)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 24)
        Me.Label21.TabIndex = 94
        Me.Label21.Text = "منزل :"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EditF
        '
        Me.AcceptButton = Me.MEditMB
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.MCancelMB
        Me.ClientSize = New System.Drawing.Size(514, 624)
        Me.Controls.Add(Me.Mobile)
        Me.Controls.Add(Me.Office)
        Me.Controls.Add(Me.Tell)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.VMPicPath)
        Me.Controls.Add(Me.VMPicExist)
        Me.Controls.Add(Me.PicTabControl)
        Me.Controls.Add(Me.VGoldPicPath)
        Me.Controls.Add(Me.VPicExist)
        Me.Controls.Add(Me.AddSGB)
        Me.Controls.Add(Me.SHParvandeNum)
        Me.Controls.Add(Me.MablagheVKH)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.MostajerFN)
        Me.Controls.Add(Me.MostajerLN)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.MoajerFN)
        Me.Controls.Add(Me.MoajerLN)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.VAghsatCount)
        Me.Controls.Add(Me.ChangeB)
        Me.Controls.Add(Me.TarikheFa)
        Me.Controls.Add(Me.TarikheGha)
        Me.Controls.Add(Me.NTashilat)
        Me.Controls.Add(Me.JTakhir)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.AghsatCount)
        Me.Controls.Add(Me.Tozihat)
        Me.Controls.Add(Me.MoPerson)
        Me.Controls.Add(Me.Adrress)
        Me.Controls.Add(Me.CGGold)
        Me.Controls.Add(Me.MablagheGh)
        Me.Controls.Add(Me.MCancelMB)
        Me.Controls.Add(Me.MEditMB)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
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
        Me.Name = "EditF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.Text = "ویرایش اطلاعات مشتری"
        Me.PicTabControl.ResumeLayout(False)
        Me.GoldPicTab.ResumeLayout(False)
        Me.GoldPanel.ResumeLayout(False)
        Me.MoshtariPicTab.ResumeLayout(False)
        Me.MPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Decs"

    Dim DBConn As DBConnection
    Dim err As System.Exception
    Dim iCounter As Integer
    Dim Item As ListViewItem

#End Region

    Private Sub EditF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadKeyboardLayout("00000429", 1)
        For I As Integer = 1 To 60
            AghsatCount.Items.Add(I)
        Next
        Try
            DBConn = New DBConnection
            DBConn.connectMe("SELECT * FROM MoshtariList WHERE SHParvandeNum=" & SHParvandeNum.Text & ";")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d.Read
                    MablagheGh.Text = d("MablagheGh".ToString)
                    JTakhir.Text = d("JTakhir".ToString)
                    MablagheVKH.Text = d("MablagheVKH".ToString)
                    MoajerFN.Text = d("MoajerFN".ToString)
                    MoajerLN.Text = d("MoajerLN".ToString)
                    MostajerFN.Text = d("MostajerFN".ToString)
                    MostajerLN.Text = d("MostajerLN".ToString)
                    CGGold.Text = d("CGGold".ToString)
                    TarikheGha.Text = d("TarikheGha".ToString)
                    AghsatCount.Text = d("AghsatCount".ToString)
                    Adrress.Text = d("Adrress".ToString)
                    Tell.Text = d("Tell".ToString)
                    Office.Text = d("Office".ToString)
                    Mobile.Text = d("Mobile".ToString)
                    MoPerson.Text = d("MoPerson".ToString)
                    Tozihat.Text = d("Tozihat".ToString)
                    PicExist.Checked = d("PicExist".ToString)
                    VPicExist.Checked = d("PicExist".ToString)
                    MPicExist.Checked = d("MPicExist".ToString)
                    VMPicExist.Checked = d("MPicExist".ToString)
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
        VAghsatCount.Text = AghsatCount.Text
        If PicExist.Checked = True Then
            GoldPicPath.Text = App_Path() & "GPics\" & SHParvandeNum.Text & ".jpg"
            VGoldPicPath.Text = App_Path() & "GPics\" & SHParvandeNum.Text & ".jpg"
            BitmapFile = New Bitmap(App_Path() & "GPics\" & SHParvandeNum.Text & ".jpg")
            PicList.Images.Clear()
            PicList.Images.Add(MakePreviewIcon(BitmapFile))
            BitmapFile.Dispose()
            PicPrev.Image = PicList.Images(0)
            PicPrev.Cursor = System.Windows.Forms.Cursors.Hand
        End If
        If MPicExist.Checked = True Then
            MPicPath.Text = App_Path() & "MPics\" & SHParvandeNum.Text & ".jpg"
            VMPicPath.Text = App_Path() & "MPics\" & SHParvandeNum.Text & ".jpg"
            BitmapFile = New Bitmap(App_Path() & "MPics\" & SHParvandeNum.Text & ".jpg")
            MPicList.Images.Clear()
            MPicList.Images.Add(MakePreviewIcon(BitmapFile))
            BitmapFile.Dispose()
            MPicPrev.Image = MPicList.Images(0)
            MPicPrev.Cursor = System.Windows.Forms.Cursors.Hand
        End If
    End Sub

    Private Sub MEditMB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEditMB.Click
        Me.Enabled = False
        If IsNullChr("Int", SHParvandeNum.Text) = False Then MsgBox("خطا در نوشتن شماره شناسایی پرونده", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "لیست مشتریان") : GoTo Get_Error
        If IsNullChr("Int", MablagheGh.Text) = False Then MsgBox("خطا در نوشتن مبلغ اقساط", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "لیست مشتریان") : GoTo Get_Error
        If IsNullChr("Int", JTakhir.Text) = False Then MsgBox("خطا در نوشتن جریمه تاخیر روزانه", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "لیست مشتریان") : GoTo Get_Error
        If IsNullChr("Int", MablagheVKH.Text) = False Then MsgBox("خطا در نوشتن مبلغ وام خظ", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "لیست مشتریان") : GoTo Get_Error
        If IsNullChr("Str", MoajerFN.Text) = False Then MsgBox("خطا در نوشتن نام موجر", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "لیست مشتریان") : GoTo Get_Error
        If IsNullChr("Str", MoajerLN.Text) = False Then MsgBox("خطا در نوشتن نام خانوادگی موجر", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "لیست مشتریان") : GoTo Get_Error
        If IsNullChr("Str", MostajerFN.Text) = False Then MsgBox("خطا در نوشتن نام مستاجر", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "لیست مشتریان") : GoTo Get_Error
        If IsNullChr("Str", MostajerLN.Text) = False Then MsgBox("خطا در نوشتن نام خانوادگی مستاجر", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "لیست مشتریان") : GoTo Get_Error
        If IsNullChr("Real", CGGold.Text) = False Then MsgBox("خطا در نوشتن مقدار گرم طلا", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "لیست مشتریان") : GoTo Get_Error
        If IsNullChr("Str", Adrress.Text, False) = False Then MsgBox("خطا در نوشتن آدرس", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "لیست مشتریان") : GoTo Get_Error
        If IsNullChr("Int", Tell.Text, False) = False Or IsNullChr("Int", Mobile.Text, False) = False Then MsgBox("خطا در نوشتن شماره تلفن", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "لیست مشتریان") : GoTo Get_Error
        If IsNullChr("Str", MoPerson.Text, False) = False Then MsgBox("خطا در نوشتن مشخصات شخصی", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "لیست مشتریان") : GoTo Get_Error
        If IsNullChr("Str", Tozihat.Text, False) = False Then MsgBox("خطا در نوشتن توضیحات", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "لیست مشتریان") : GoTo Get_Error
        If PicExist.Checked = True And GoldPicPath.Text = "" Then MsgBox("لطفا عکس طلا را وارد کنید.", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "لیست مشتریان") : GoTo Get_Error
        If MPicExist.Checked = True And MPicPath.Text = "" Then MsgBox("لطفا عکس مشتری را وارد کنید.", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "لیست مشتریان") : GoTo Get_Error
        If VGoldPicPath.Text <> GoldPicPath.Text Then
            If VPicExist.Checked = True And ExistFile(App_Path() & "GPics\" & SHParvandeNum.Text & ".jpg") = True Then
                Kill(App_Path() & "GPics\" & SHParvandeNum.Text & ".jpg")
            End If
            If PicExist.Checked = True Then
                If GoldPicPath.Text <> "" Then
                    FileCopy(GoldPicPath.Text, App_Path() & "GPics\" & SHParvandeNum.Text & ".jpg")
                End If
            End If
        End If
        If VMPicPath.Text <> MPicPath.Text Then
            If VMPicExist.Checked = True And ExistFile(App_Path() & "MPics\" & SHParvandeNum.Text & ".jpg") = True Then
                Kill(App_Path() & "MPics\" & SHParvandeNum.Text & ".jpg")
            End If
            If MPicExist.Checked = True Then
                If MPicPath.Text <> "" Then
                    FileCopy(MPicPath.Text, App_Path() & "MPics\" & SHParvandeNum.Text & ".jpg")
                End If
            End If
        End If
        Try
            DBConn = New DBConnection
            DBConn.connectMe("Update MoshtariList SET SHParvandeNum=" & SHParvandeNum.Text & ",AghsatCount='" & AghsatCount.Text & "',MablagheGh='" & MablagheGh.Text & "',JTakhir='" & JTakhir.Text & "',MablagheVKH='" & MablagheVKH.Text & "',MoajerFN='" & MoajerFN.Text & "',MoajerLN='" & MoajerLN.Text & "',MostajerFN='" & MostajerFN.Text & "',MostajerLN='" & MostajerLN.Text & "',CGGold='" & CGGold.Text & "',TarikheGha='" & TarikheGha.Text & "',TarikheFa='" & TarikheFa.Text & "',Adrress='" & Adrress.Text & "',Tell='" & Tell.Text & "',Office='" & Office.Text & "',Mobile='" & Mobile.Text & "',MoPerson='" & MoPerson.Text & "',Tozihat='" & Tozihat.Text & "',PicExist=" & PicExist.Checked & ",MPicExist=" & MPicExist.Checked & " WHERE ID=" & ID.Text & ";")
            DBConn.OLEComm.Connection = DBConn.OLEConn
            DBConn.OLEComm.ExecuteNonQuery()
            DBConn.OLEConn.Close()
        Catch err As System.Exception
            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            GoTo Get_Error
        End Try
        Dim TPardakht As String
        Dim CAC As Boolean
        Dim IDAM As String
        Dim IPAM As Boolean
        If VAghsatCount.Text = AghsatCount.Text Then CAC = False Else CAC = True
        Select Case CAC
            Case False
                For I As Integer = 1 To AghsatCount.Text
                    Try
                        DBConn = New DBConnection
                        DBConn.connectMe("SELECT * FROM AnyMoshtari WHERE SHParvandeNum='" & SHParvandeNum.Text & "';")
                        Try
                            DBConn.OLEComm.Connection = DBConn.OLEConn
                            Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                            Do While d.Read
                                If d("Ghest".ToString) = I Then
                                    IDAM = d("ID".ToString)
                                    IPAM = d("IfPardakht".ToString)
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
                    Select Case IPAM
                        Case True
                            Try
                                DBConn = New DBConnection
                                DBConn.connectMe("Update AnyMoshtari SET SHParvandeNum='" & SHParvandeNum.Text & "' WHERE ID=" & IDAM & ";")
                                DBConn.OLEComm.Connection = DBConn.OLEConn
                                DBConn.OLEComm.ExecuteNonQuery()
                                DBConn.OLEConn.Close()
                            Catch err As System.Exception
                                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                                GoTo Get_Error
                            End Try
                        Case False
                            Select Case ((Mid(TarikheGha.Text, 4, 2) + I) Mod 12)
                                Case 0
                                    TPardakht = ((Microsoft.VisualBasic.Left(TarikheGha.Text, 2) + ((Mid(TarikheGha.Text, 4, 2)) + I) \ 12) - 1) & "/12" & Microsoft.VisualBasic.Right(TarikheGha.Text, 3)
                                Case 1, 2, 3, 4, 5, 6, 7, 8, 9
                                    TPardakht = (Microsoft.VisualBasic.Left(TarikheGha.Text, 2) + ((Mid(TarikheGha.Text, 4, 2)) + I) \ 12) & "/0" & ((Mid(TarikheGha.Text, 4, 2) + I) Mod 12) & Microsoft.VisualBasic.Right(TarikheGha.Text, 3)
                                Case 10, 11
                                    TPardakht = (Microsoft.VisualBasic.Left(TarikheGha.Text, 2) + ((Mid(TarikheGha.Text, 4, 2)) + I) \ 12) & "/" & ((Mid(TarikheGha.Text, 4, 2) + I) Mod 12) & Microsoft.VisualBasic.Right(TarikheGha.Text, 3)
                            End Select
                            Try
                                DBConn = New DBConnection
                                DBConn.connectMe("Update AnyMoshtari SET SHParvandeNum='" & SHParvandeNum.Text & "',Moajer='" & MoajerFN.Text & " " & MoajerLN.Text & "',Mostajer='" & MostajerFN.Text & " " & MostajerLN.Text & "',Tell='" & Tell.Text & "',TPardakht='" & TPardakht & "' WHERE ID=" & IDAM & ";")
                                DBConn.OLEComm.Connection = DBConn.OLEConn
                                DBConn.OLEComm.ExecuteNonQuery()
                                DBConn.OLEConn.Close()
                            Catch err As System.Exception
                                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                                GoTo Get_Error
                            End Try
                    End Select
                Next
            Case True
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("Delete From AnyMoshtari WHERE SHParvandeNum = '" & SHParvandeNum.Text & "';")
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
                For I As Integer = 1 To AghsatCount.Text
                    Select Case ((Mid(TarikheGha.Text, 4, 2) + I) Mod 12)
                        Case 0
                            TPardakht = ((Microsoft.VisualBasic.Left(TarikheGha.Text, 2) + ((Mid(TarikheGha.Text, 4, 2)) + I) \ 12) - 1) & "/12" & Microsoft.VisualBasic.Right(TarikheGha.Text, 3)
                        Case 1, 2, 3, 4, 5, 6, 7, 8, 9
                            TPardakht = (Microsoft.VisualBasic.Left(TarikheGha.Text, 2) + ((Mid(TarikheGha.Text, 4, 2)) + I) \ 12) & "/0" & ((Mid(TarikheGha.Text, 4, 2) + I) Mod 12) & Microsoft.VisualBasic.Right(TarikheGha.Text, 3)
                        Case 10, 11
                            TPardakht = (Microsoft.VisualBasic.Left(TarikheGha.Text, 2) + ((Mid(TarikheGha.Text, 4, 2)) + I) \ 12) & "/" & ((Mid(TarikheGha.Text, 4, 2) + I) Mod 12) & Microsoft.VisualBasic.Right(TarikheGha.Text, 3)
                    End Select
                    Try
                        DBConn = New DBConnection
                        DBConn.connectMe("Insert Into AnyMoshtari (Ghest,SHParvandeNum,Moajer,Mostajer,CGGold,TPardakht) Values (" & I & ", '" & SHParvandeNum.Text & "', '" & MoajerFN.Text & " " & MoajerLN.Text & "', '" & MostajerFN.Text & " " & MostajerLN.Text & "', '" & CGGold.Text & "', '" & TPardakht & "');")
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
                Next
        End Select
        Try
            DBConn = New DBConnection
            DBConn.connectMe("Update AnySGozari SET CGGold='" & CGGold.Text & "',Mostajer='" & MostajerFN.Text & " " & MostajerLN.Text & "' WHERE SHParvandeNum='" & SHParvandeNum.Text & "';")
            DBConn.OLEComm.Connection = DBConn.OLEConn
            DBConn.OLEComm.ExecuteNonQuery()
            DBConn.OLEConn.Close()
        Catch err As System.Exception
            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            GoTo Get_Error
        End Try
        Me.Close()
        Exit Sub
Get_Error:
        Me.Enabled = True
    End Sub

    Private Sub AghsatCount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AghsatCount.SelectedIndexChanged
        Select Case ((Mid(TarikheGha.Text, 4, 2) + AghsatCount.SelectedItem) Mod 12)
            Case 0
                TarikheFa.Text = ((Microsoft.VisualBasic.Left(TarikheGha.Text, 2) + ((Mid(TarikheGha.Text, 4, 2) + AghsatCount.SelectedItem) \ 12)) - 1) & "/12" & Microsoft.VisualBasic.Right(TarikheGha.Text, 3)
            Case 1, 2, 3, 4, 5, 6, 7, 8, 9
                TarikheFa.Text = (Microsoft.VisualBasic.Left(TarikheGha.Text, 2) + ((Mid(TarikheGha.Text, 4, 2) + AghsatCount.SelectedItem) \ 12)) & "/0" & ((Mid(TarikheGha.Text, 4, 2) + AghsatCount.SelectedItem) Mod 12) & Microsoft.VisualBasic.Right(TarikheGha.Text, 3)
            Case 10, 11
                TarikheFa.Text = (Microsoft.VisualBasic.Left(TarikheGha.Text, 2) + ((Mid(TarikheGha.Text, 4, 2) + AghsatCount.SelectedItem) \ 12)) & "/" & ((Mid(TarikheGha.Text, 4, 2) + AghsatCount.SelectedItem) Mod 12) & Microsoft.VisualBasic.Right(TarikheGha.Text, 3)
        End Select
    End Sub

    Private Sub EditF_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        LoadKeyboardLayout("00000409", 1)
    End Sub

    Private Sub ChangeB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeB.Click
        Dim InputBoxForm As New InputBoxF
        InputBoxForm.TVosool.Text = TarikheGha.Text
        InputBoxForm.Message.Text = "لطفا در صورت اشتباه بودن تاریخ قرارداد درج شده توسط برنامه تاریخ قرارداد صحیح را وارد کنید."
        InputBoxForm.ShowDialog()
        TarikheGha.Text = InputBoxForm.TVosool.Text
        Select Case ((Mid(TarikheGha.Text, 4, 2) + AghsatCount.SelectedItem) Mod 12)
            Case 0
                TarikheFa.Text = ((Microsoft.VisualBasic.Left(TarikheGha.Text, 2) + ((Mid(TarikheGha.Text, 4, 2) + AghsatCount.SelectedItem) \ 12)) - 1) & "/12" & Microsoft.VisualBasic.Right(TarikheGha.Text, 3)
            Case 1, 2, 3, 4, 5, 6, 7, 8, 9
                TarikheFa.Text = (Microsoft.VisualBasic.Left(TarikheGha.Text, 2) + ((Mid(TarikheGha.Text, 4, 2) + AghsatCount.SelectedItem) \ 12)) & "/0" & ((Mid(TarikheGha.Text, 4, 2) + AghsatCount.SelectedItem) Mod 12) & Microsoft.VisualBasic.Right(TarikheGha.Text, 3)
            Case 10, 11
                TarikheFa.Text = (Microsoft.VisualBasic.Left(TarikheGha.Text, 2) + ((Mid(TarikheGha.Text, 4, 2) + AghsatCount.SelectedItem) \ 12)) & "/" & ((Mid(TarikheGha.Text, 4, 2) + AghsatCount.SelectedItem) Mod 12) & Microsoft.VisualBasic.Right(TarikheGha.Text, 3)
        End Select
    End Sub

    Private Sub AddSGB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSGB.Click
        Dim SGListForm As New SGListF
        SGListForm.ShowDialog()
        If SGListForm.OK Then
            MoajerFN.Text = SGListForm.VSGList.Items(SGListForm.SGList.SelectedIndex).SubItems(0).Text
            MoajerLN.Text = SGListForm.VSGList.Items(SGListForm.SGList.SelectedIndex).SubItems(1).Text
        End If
    End Sub

    Private Sub PicExist_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicExist.CheckedChanged
        GoldPanel.Enabled = PicExist.Checked
        If PicExist.Checked = False Then GoldPicPath.Text = "" : PicPrev.Image = Nothing : PicPrev.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub GoldPicBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoldPicBrowse.Click
        If OpenGoldPic.ShowDialog = DialogResult.OK Then
            GoldPicPath.Text = OpenGoldPic.FileName
            BitmapFile = New Bitmap(OpenGoldPic.FileName)
            PicList.Images.Clear()
            PicList.Images.Add(MakePreviewIcon(BitmapFile))
            BitmapFile.Dispose()
            PicPrev.Image = PicList.Images(0)
            PicPrev.Cursor = System.Windows.Forms.Cursors.Hand
        End If
    End Sub

    Private Sub MPicExist_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPicExist.CheckedChanged
        MPanel.Enabled = MPicExist.Checked
        If MPicExist.Checked = False Then MPicPath.Text = "" : MPicPrev.Image = Nothing : MPicPrev.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub MPicBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPicBrowse.Click
        If OpenGoldPic.ShowDialog = DialogResult.OK Then
            MPicPath.Text = OpenGoldPic.FileName
            BitmapFile = New Bitmap(OpenGoldPic.FileName)
            MPicList.Images.Clear()
            MPicList.Images.Add(MakePreviewIcon(BitmapFile))
            BitmapFile.Dispose()
            MPicPrev.Image = MPicList.Images(0)
            MPicPrev.Cursor = System.Windows.Forms.Cursors.Hand
        End If
    End Sub

    Private Sub PicPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicPrev.Click
        If GoldPicPath.Text <> "" Then ExecuteFile(GoldPicPath.Text)
    End Sub

    Private Sub MPicPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPicPrev.Click
        If MPicPath.Text <> "" Then ExecuteFile(MPicPath.Text)
    End Sub
End Class
