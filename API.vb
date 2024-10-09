Module API

    Public Declare Function LoadKeyboardLayout Lib "user32" Alias "LoadKeyboardLayoutA" (ByVal pwszKLID As String, ByVal flags As Long) As Long
    Public Declare Function sndPlaySound Lib "winmm.dll" Alias "sndPlaySoundA" (ByVal lpszSoundName As String, ByVal uFlags As Long) As Long
    Public Const SND_ASYNC = &H1
    Public Const SND_NODEFAULT = &H2
    Public Const MF_BYPOSITION As Integer = &H400
    Public VBKeyC As Boolean
    Public MoveArchive As Boolean = False
    Public UnLock As Boolean = False
    Public BitmapFile As Bitmap
    Public MainForm As New Main
    Public SortType As String = "Numeric"
    Public NewCol As Integer

    'CHArchiveListF'

    Public CHArchiveListFormViewMode As Integer
    Public CHArchiveListFormFT As String
    Public CHArchiveListFormTT As String
    Public CHArchiveListFormBNC As Integer
    Public CHArchiveListFormBN(100) As String

    'ReportModeF'

    Public ReportModeFormViewReport As String
    Public ReportListFormViewMode As Integer
    Public ReportListFormFT As String
    Public ReportListFormTT As String

    'GhPrintF

    Public GhPrintFormSG As String
    Public GhPrintFormGHNum As String

    'UnlockF

    Public UnlockFAdminID As String

    Public Function MessageBox(ByVal Message As String, ByVal Style As MsgBoxStyle, ByVal Title As String) As Boolean
        Dim MsgBoxForm As New MsgBoxF
        MsgBoxForm.MessageBox_Setting(Title, Message, Style)
        MsgBoxForm.ShowDialog()
        MessageBox = VBKeyC
    End Function

    Public Function Play_Sound(ByVal Sound As String)
        Select Case Sound
            Case "Beep"
                sndPlaySound(Sound, SND_ASYNC Or SND_NODEFAULT)
            Case "Message"
                sndPlaySound("Message.wav", SND_ASYNC Or SND_NODEFAULT)
            Case "Critical"
                sndPlaySound(Sound, SND_ASYNC Or SND_NODEFAULT)
        End Select
    End Function

    Public Function App_Path() As String
        If Right(Application.StartupPath, 1) = "\" Or Right(Application.StartupPath, 1) = "/" Then
            Return Application.StartupPath
        Else
            Return Application.StartupPath & "\"
        End If
    End Function

    Public Function ExistFile(ByVal FileName As String) As Boolean
        ExistFile = (Dir(FileName, vbNormal Or vbReadOnly Or vbHidden Or vbSystem Or vbArchive) <> "")
    End Function

    Public Function MakePreviewIcon(ByRef myFGImg As Drawing.Image) As Drawing.Image
        Dim myBGImg As New Bitmap(160, 112)
        Dim myGraphic As Drawing.Graphics = Graphics.FromImage(myBGImg)
        myGraphic.DrawImage(myFGImg, 0, 0, 160, 112)
        Dim myReturnImg As Image = DirectCast(myBGImg.Clone(), Image)
        myGraphic.DrawImage(myReturnImg, 0, 0)
        Return myReturnImg
    End Function

    Public Function ExecuteFile(ByVal FileName As String) As Boolean
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = FileName
        myProcess.StartInfo.UseShellExecute = True
        myProcess.StartInfo.RedirectStandardOutput = False
        myProcess.Start()
    End Function

End Module
