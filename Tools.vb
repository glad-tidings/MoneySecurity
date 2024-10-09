Public Class Tools
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
    Friend WithEvents AboutLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Report As System.Windows.Forms.PictureBox
    Friend WithEvents Backup As System.Windows.Forms.PictureBox
    Friend WithEvents Archive As System.Windows.Forms.PictureBox
    Friend WithEvents Moshtari As System.Windows.Forms.PictureBox
    Friend WithEvents Logo As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
    Friend WithEvents Admin As System.Windows.Forms.PictureBox
    Friend WithEvents NoteBook As System.Windows.Forms.PictureBox
    Friend WithEvents VHesab As System.Windows.Forms.PictureBox
    Friend WithEvents BHesab As System.Windows.Forms.PictureBox
    Friend WithEvents About As System.Windows.Forms.PictureBox
    Friend WithEvents Sarmaie As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Tools))
        Me.AboutLogo = New System.Windows.Forms.PictureBox
        Me.NoteBook = New System.Windows.Forms.PictureBox
        Me.Report = New System.Windows.Forms.PictureBox
        Me.Backup = New System.Windows.Forms.PictureBox
        Me.Archive = New System.Windows.Forms.PictureBox
        Me.Moshtari = New System.Windows.Forms.PictureBox
        Me.Logo = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.Admin = New System.Windows.Forms.PictureBox
        Me.VHesab = New System.Windows.Forms.PictureBox
        Me.BHesab = New System.Windows.Forms.PictureBox
        Me.About = New System.Windows.Forms.PictureBox
        Me.Sarmaie = New System.Windows.Forms.PictureBox
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AboutLogo
        '
        Me.AboutLogo.Image = CType(resources.GetObject("AboutLogo.Image"), System.Drawing.Image)
        Me.AboutLogo.Location = New System.Drawing.Point(8, 8)
        Me.AboutLogo.Name = "AboutLogo"
        Me.AboutLogo.Size = New System.Drawing.Size(56, 56)
        Me.AboutLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AboutLogo.TabIndex = 1
        Me.AboutLogo.TabStop = False
        Me.AboutLogo.Visible = False
        '
        'NoteBook
        '
        Me.NoteBook.Image = CType(resources.GetObject("NoteBook.Image"), System.Drawing.Image)
        Me.Logo.SetIndex(Me.NoteBook, CType(5, Short))
        Me.NoteBook.Location = New System.Drawing.Point(72, 40)
        Me.NoteBook.Name = "NoteBook"
        Me.NoteBook.Size = New System.Drawing.Size(24, 24)
        Me.NoteBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NoteBook.TabIndex = 38
        Me.NoteBook.TabStop = False
        Me.NoteBook.Visible = False
        '
        'Report
        '
        Me.Report.Image = CType(resources.GetObject("Report.Image"), System.Drawing.Image)
        Me.Logo.SetIndex(Me.Report, CType(4, Short))
        Me.Report.Location = New System.Drawing.Point(168, 8)
        Me.Report.Name = "Report"
        Me.Report.Size = New System.Drawing.Size(24, 24)
        Me.Report.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Report.TabIndex = 37
        Me.Report.TabStop = False
        Me.Report.Visible = False
        '
        'Backup
        '
        Me.Backup.Image = CType(resources.GetObject("Backup.Image"), System.Drawing.Image)
        Me.Logo.SetIndex(Me.Backup, CType(3, Short))
        Me.Backup.Location = New System.Drawing.Point(144, 8)
        Me.Backup.Name = "Backup"
        Me.Backup.Size = New System.Drawing.Size(24, 24)
        Me.Backup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Backup.TabIndex = 36
        Me.Backup.TabStop = False
        Me.Backup.Visible = False
        '
        'Archive
        '
        Me.Archive.Image = CType(resources.GetObject("Archive.Image"), System.Drawing.Image)
        Me.Logo.SetIndex(Me.Archive, CType(2, Short))
        Me.Archive.Location = New System.Drawing.Point(120, 8)
        Me.Archive.Name = "Archive"
        Me.Archive.Size = New System.Drawing.Size(24, 24)
        Me.Archive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Archive.TabIndex = 35
        Me.Archive.TabStop = False
        Me.Archive.Visible = False
        '
        'Moshtari
        '
        Me.Moshtari.Image = CType(resources.GetObject("Moshtari.Image"), System.Drawing.Image)
        Me.Logo.SetIndex(Me.Moshtari, CType(1, Short))
        Me.Moshtari.Location = New System.Drawing.Point(96, 8)
        Me.Moshtari.Name = "Moshtari"
        Me.Moshtari.Size = New System.Drawing.Size(24, 24)
        Me.Moshtari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Moshtari.TabIndex = 34
        Me.Moshtari.TabStop = False
        Me.Moshtari.Visible = False
        '
        'Admin
        '
        Me.Admin.Image = CType(resources.GetObject("Admin.Image"), System.Drawing.Image)
        Me.Logo.SetIndex(Me.Admin, CType(0, Short))
        Me.Admin.Location = New System.Drawing.Point(72, 8)
        Me.Admin.Name = "Admin"
        Me.Admin.Size = New System.Drawing.Size(24, 24)
        Me.Admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Admin.TabIndex = 33
        Me.Admin.TabStop = False
        Me.Admin.Visible = False
        '
        'VHesab
        '
        Me.VHesab.Image = CType(resources.GetObject("VHesab.Image"), System.Drawing.Image)
        Me.Logo.SetIndex(Me.VHesab, CType(6, Short))
        Me.VHesab.Location = New System.Drawing.Point(96, 40)
        Me.VHesab.Name = "VHesab"
        Me.VHesab.Size = New System.Drawing.Size(24, 24)
        Me.VHesab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.VHesab.TabIndex = 39
        Me.VHesab.TabStop = False
        Me.VHesab.Visible = False
        '
        'BHesab
        '
        Me.BHesab.Image = CType(resources.GetObject("BHesab.Image"), System.Drawing.Image)
        Me.Logo.SetIndex(Me.BHesab, CType(7, Short))
        Me.BHesab.Location = New System.Drawing.Point(120, 40)
        Me.BHesab.Name = "BHesab"
        Me.BHesab.Size = New System.Drawing.Size(24, 24)
        Me.BHesab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BHesab.TabIndex = 40
        Me.BHesab.TabStop = False
        Me.BHesab.Visible = False
        '
        'About
        '
        Me.About.Image = CType(resources.GetObject("About.Image"), System.Drawing.Image)
        Me.Logo.SetIndex(Me.About, CType(9, Short))
        Me.About.Location = New System.Drawing.Point(152, 40)
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(24, 24)
        Me.About.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.About.TabIndex = 41
        Me.About.TabStop = False
        Me.About.Visible = False
        '
        'Sarmaie
        '
        Me.Sarmaie.Image = CType(resources.GetObject("Sarmaie.Image"), System.Drawing.Image)
        Me.Logo.SetIndex(Me.Sarmaie, CType(8, Short))
        Me.Sarmaie.Location = New System.Drawing.Point(184, 32)
        Me.Sarmaie.Name = "Sarmaie"
        Me.Sarmaie.Size = New System.Drawing.Size(24, 24)
        Me.Sarmaie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Sarmaie.TabIndex = 43
        Me.Sarmaie.TabStop = False
        Me.Sarmaie.Visible = False
        '
        'Tools
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(216, 72)
        Me.Controls.Add(Me.Sarmaie)
        Me.Controls.Add(Me.About)
        Me.Controls.Add(Me.BHesab)
        Me.Controls.Add(Me.VHesab)
        Me.Controls.Add(Me.Report)
        Me.Controls.Add(Me.Backup)
        Me.Controls.Add(Me.Archive)
        Me.Controls.Add(Me.Moshtari)
        Me.Controls.Add(Me.Admin)
        Me.Controls.Add(Me.AboutLogo)
        Me.Controls.Add(Me.NoteBook)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tools"
        Me.ShowInTaskbar = False
        Me.Text = "Tools"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
