Public Class LoaderF
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
    Friend WithEvents LoaderImage As System.Windows.Forms.PictureBox
    Friend WithEvents LoaderTime As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(LoaderF))
        Me.LoaderImage = New System.Windows.Forms.PictureBox
        Me.LoaderTime = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LoaderImage
        '
        Me.LoaderImage.Image = CType(resources.GetObject("LoaderImage.Image"), System.Drawing.Image)
        Me.LoaderImage.Location = New System.Drawing.Point(0, 0)
        Me.LoaderImage.Name = "LoaderImage"
        Me.LoaderImage.Size = New System.Drawing.Size(463, 220)
        Me.LoaderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.LoaderImage.TabIndex = 0
        Me.LoaderImage.TabStop = False
        '
        'LoaderTime
        '
        Me.LoaderTime.Interval = 1000
        '
        'LoaderF
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(463, 220)
        Me.Controls.Add(Me.LoaderImage)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoaderF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Decs"
    Dim DBConn As DBConnection
    Dim I As Integer = 0
#End Region

    Private Sub LoaderTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoaderTime.Tick
        I = I + 1
        If I > 3 Then
            Check_Activate()
        ElseIf I = 2 Then
            For I As Integer = 0 To 9
                MainForm.Get_Setting(I)
                Application.DoEvents()
            Next
        End If
    End Sub

    Private Sub LoaderF_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoaderTime.Enabled = True
    End Sub

    Private Sub Check_Activate()
        LoaderTime.Enabled = False
        Try
            If GetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Register", "ActiveCode") = ActiveCode() Then
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM Administrator WHERE God=True;")
                    DBConn.OLEComm.Connection = DBConn.OLEConn
                    Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                    Do While d.Read
                        If d("Reg".ToString) = True Then
                            Dim LoginForm As New LoginF
                            LoginForm.Show()
                            Me.Hide()
                        Else
                            Dim RegAdminForm As New RegAdminF
                            RegAdminForm.Show()
                            Me.Hide()
                        End If
                    Loop
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    Me.Hide()
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی : " & err.Message, MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxRtlReading, "بانک اطلاعاتی")
                    End
                End Try
            Else
                GoTo Get_Error
            End If
        Catch err As System.Exception
            GoTo Get_Error
        End Try
        Exit Sub
Get_Error:
        Dim ActivationForm As New ActivationF
        ActivationForm.Show()
        Me.Hide()
    End Sub

    Private Sub LoaderF_Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs) Handles MyBase.Invalidated
        If (UBound(Diagnostics.Process.GetProcessesByName(Diagnostics.Process.GetCurrentProcess.ProcessName)) > 0) = True Then
            End
        End If
    End Sub
End Class
