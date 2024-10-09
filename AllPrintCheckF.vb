Public Class AllPrintCheckF
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
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents OKB As System.Windows.Forms.Button
    Friend WithEvents MSBPrintCheck As System.Windows.Forms.CheckBox
    Friend WithEvents MPrintCheck As System.Windows.Forms.CheckBox
    Friend WithEvents MInfPrintCheck As System.Windows.Forms.CheckBox
    Friend WithEvents MFormPrintCheck As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.MFormPrintCheck = New System.Windows.Forms.CheckBox
        Me.MInfPrintCheck = New System.Windows.Forms.CheckBox
        Me.MPrintCheck = New System.Windows.Forms.CheckBox
        Me.MSBPrintCheck = New System.Windows.Forms.CheckBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.OKB = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'MFormPrintCheck
        '
        Me.MFormPrintCheck.Checked = True
        Me.MFormPrintCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MFormPrintCheck.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MFormPrintCheck.Location = New System.Drawing.Point(30, 88)
        Me.MFormPrintCheck.Name = "MFormPrintCheck"
        Me.MFormPrintCheck.Size = New System.Drawing.Size(120, 24)
        Me.MFormPrintCheck.TabIndex = 49
        Me.MFormPrintCheck.Text = "‘‰«”Â „‘ —Ì"
        '
        'MInfPrintCheck
        '
        Me.MInfPrintCheck.Checked = True
        Me.MInfPrintCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MInfPrintCheck.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MInfPrintCheck.Location = New System.Drawing.Point(78, 56)
        Me.MInfPrintCheck.Name = "MInfPrintCheck"
        Me.MInfPrintCheck.Size = New System.Drawing.Size(72, 24)
        Me.MInfPrintCheck.TabIndex = 48
        Me.MInfPrintCheck.Text = "«ÿ·«⁄« "
        '
        'MPrintCheck
        '
        Me.MPrintCheck.Checked = True
        Me.MPrintCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MPrintCheck.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MPrintCheck.Location = New System.Drawing.Point(166, 88)
        Me.MPrintCheck.Name = "MPrintCheck"
        Me.MPrintCheck.Size = New System.Drawing.Size(64, 24)
        Me.MPrintCheck.TabIndex = 47
        Me.MPrintCheck.Text = "œ› —çÂ"
        '
        'MSBPrintCheck
        '
        Me.MSBPrintCheck.Checked = True
        Me.MSBPrintCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MSBPrintCheck.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MSBPrintCheck.Location = New System.Drawing.Point(166, 56)
        Me.MSBPrintCheck.Name = "MSBPrintCheck"
        Me.MSBPrintCheck.Size = New System.Drawing.Size(64, 24)
        Me.MSBPrintCheck.TabIndex = 46
        Me.MSBPrintCheck.Text = "”—»—ê"
        '
        'Label22
        '
        Me.Label22.ForeColor = System.Drawing.Color.Maroon
        Me.Label22.Location = New System.Drawing.Point(42, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(192, 23)
        Me.Label22.TabIndex = 45
        Me.Label22.Text = "›—„Â«Ì „Ê—œ ‰Ÿ— —« «‰ Œ«» ò‰Ìœ"
        '
        'OKB
        '
        Me.OKB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OKB.Location = New System.Drawing.Point(96, 128)
        Me.OKB.Name = "OKB"
        Me.OKB.Size = New System.Drawing.Size(72, 23)
        Me.OKB.TabIndex = 50
        Me.OKB.Text = " «ÌÌœ"
        '
        'AllPrintCheckF
        '
        Me.AcceptButton = Me.OKB
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(264, 160)
        Me.ControlBox = False
        Me.Controls.Add(Me.OKB)
        Me.Controls.Add(Me.MFormPrintCheck)
        Me.Controls.Add(Me.MInfPrintCheck)
        Me.Controls.Add(Me.MPrintCheck)
        Me.Controls.Add(Me.MSBPrintCheck)
        Me.Controls.Add(Me.Label22)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AllPrintCheckF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.Text = "›—„Â«Ì ¬„«œÂ ÃÂ  ç«Å"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub OKB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKB.Click
        Me.Close()
    End Sub
End Class
