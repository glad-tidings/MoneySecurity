Module Encoding

    Public Function EnCodePass(ByVal Password As String) As String
        Dim EnCode As New System.Text.UnicodeEncoding
        Dim Buffer As Byte() = EnCode.GetBytes(Password)
        EnCodePass = Convert.ToBase64String(Buffer)
    End Function

    Public Function DeCodePass(ByVal Password As String) As String
        Dim EnCode As New System.Text.UnicodeEncoding
        Dim Buffer As Byte() = Convert.FromBase64String(Password)
        DeCodePass = EnCode.GetString(Buffer)
    End Function

End Module
