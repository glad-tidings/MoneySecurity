Public Class PrintF
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
    Friend WithEvents ReportView As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents WP As System.Windows.Forms.TextBox
    Friend WithEvents ChequePrint As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ReportView = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.WP = New System.Windows.Forms.TextBox
        Me.ChequePrint = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'ReportView
        '
        Me.ReportView.ActiveViewIndex = -1
        Me.ReportView.DisplayGroupTree = False
        Me.ReportView.Location = New System.Drawing.Point(0, 0)
        Me.ReportView.Name = "ReportView"
        Me.ReportView.ReportSource = Nothing
        Me.ReportView.Size = New System.Drawing.Size(664, 400)
        Me.ReportView.TabIndex = 0
        Me.ReportView.TabStop = False
        '
        'WP
        '
        Me.WP.Location = New System.Drawing.Point(0, 384)
        Me.WP.Name = "WP"
        Me.WP.Size = New System.Drawing.Size(24, 23)
        Me.WP.TabIndex = 1
        Me.WP.Text = ""
        Me.WP.Visible = False
        '
        'ChequePrint
        '
        Me.ChequePrint.Location = New System.Drawing.Point(24, 384)
        Me.ChequePrint.Name = "ChequePrint"
        Me.ChequePrint.Size = New System.Drawing.Size(32, 23)
        Me.ChequePrint.TabIndex = 2
        Me.ChequePrint.Text = ""
        Me.ChequePrint.Visible = False
        '
        'PrintF
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(658, 400)
        Me.Controls.Add(Me.ChequePrint)
        Me.Controls.Add(Me.WP)
        Me.Controls.Add(Me.ReportView)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrintF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "چاپ"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub PrintF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = False
        Select Case WP.Text
            Case 1
                ReportView.ReportSource = "MoRe.rpt"
            Case 2
                ReportView.ReportSource = "PaRe.rpt"
            Case 3
                ReportView.ReportSource = "DiRe.rpt"
            Case 4
                ReportView.ReportSource = "DaRe.rpt"
            Case 5
                ReportView.ReportSource = "MDaRe.rpt"
            Case 6
                ReportView.ReportSource = "HeRe.rpt"
            Case 7
                ReportView.ReportSource = "MTRe.rpt"
            Case 8
                ReportView.ReportSource = "Cheque Print\" & ChequePrint.Text
            Case 9
                ReportView.ReportSource = "MLRe.rpt"
            Case 10
                ReportView.ReportSource = "HVLRe.rpt"
            Case 11
                ReportView.ReportSource = "HBLRe.rpt"
            Case 12
                ReportView.ReportSource = "MPLRe.rpt"
            Case 13
                ReportView.ReportSource = "CHARe.rpt"
            Case 14
                ReportView.ReportSource = "GHSGRe.rpt"
            Case 15
                ReportView.ReportSource = "SBRe.rpt"
            Case 16
                ReportView.ReportSource = "SGSBRe.rpt"
            Case 17
                ReportView.ReportSource = "MFTRe.rpt"
            Case 18
                ReportView.ReportSource = "Resid\ReSGRe.rpt"
            Case 19
                ReportView.ReportSource = "Factor\FaRe.rpt"
            Case 20
                ReportView.ReportSource = "Iransel\NSign.rpt"
            Case 21
                ReportView.ReportSource = "Iransel\OSign.rpt"
            Case 22
                ReportView.ReportSource = "InfMRe.rpt"
            Case 23
                ReportView.ReportSource = "CusIDRe.rpt"
        End Select
        ReportView.RefreshReport()
        Try
            ReportView.PrintReport()
        Catch err As System.Exception
            MsgBox("اشکال در چاپ لطفا دوباره تلاش کنید.", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "چاپ")
        End Try
        Me.Close()
    End Sub
End Class
