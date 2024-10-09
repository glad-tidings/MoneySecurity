Module ErrorLog

    Function Set_Error_Log(ByVal ErrorDesc As String, ByVal ErrorSource As String, ByVal ErrorStackTrace As String)
        Dim FreeNum As Integer = FreeFile()
        FileOpen(FreeNum, "Error.log", OpenMode.Append)
        PrintLine(FreeNum, "Date : " & Format(Now, "yyyy/MM/dd"))
        PrintLine(FreeNum, "Time : " & Format(Now, "hh:mm:ss"))
        PrintLine(FreeNum, "Error Source : " & ErrorSource)
        PrintLine(FreeNum, "Error Description : " & ErrorDesc)
        PrintLine(FreeNum, "Error Stack Trace :" & vbCrLf & ErrorStackTrace)
        PrintLine(FreeNum, "------------------------------------------------")
        FileClose(FreeNum)
    End Function

End Module
