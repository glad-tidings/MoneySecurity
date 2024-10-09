Module CheckInput

    Function IsNullChr(ByVal ObjectFCh As String, ByVal Character As String, Optional ByVal MNEmpty As Boolean = True) As Boolean
        If MNEmpty = True And Character = "" Then Return False : Exit Function
        Dim Temp As Boolean = True
        For I As Integer = 1 To Character.Length
            If CheckChr(ObjectFCh, Right(Left(Character, I), 1)) = False Then Temp = False : Exit For
        Next
        If Temp Then
            Return True
        Else
            Return False
        End If
    End Function

    Function CheckChr(ByVal ObjectFCh As String, ByVal Character As String) As Boolean
        Dim AccessChr As String
        Select Case ObjectFCh
            Case "Int"
                AccessChr = "0123456789"
            Case "Real"
                AccessChr = "0123456789."
            Case "Str"
                AccessChr = "آابپتثجچحخدذرزژسشصضطظعغفقکگلمنوهیيئ-_ 0123456789"
            Case "User"
                AccessChr = "abcdefghijklmnopqrstuvwxyz-_0123456789"
            Case "Pass"
                AccessChr = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ `~!@#$%^&*()-_=+\|[{]};:',<.>/?0123456789" & """"
        End Select
        If InStr(AccessChr, Character) = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

End Module
