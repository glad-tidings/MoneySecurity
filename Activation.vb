Module Activation

    Public Function DriveSerialNumber(ByVal Drive As String) As String
        Dim FSO As New Scripting.FileSystemObject
        Dim S As String
        Dim Serial As Long
        If FSO.DriveExists(Drive) = False Then DriveSerialNumber = "Drive not exist" : Exit Function
        If FSO.GetDrive(Drive).IsReady = True Then
            Serial = FSO.GetDrive(Drive).SerialNumber
            S = Microsoft.VisualBasic.Right(Hex(Serial), 8)
        Else
            S = ""
        End If
        Select Case S.Length
            Case 0
                DriveSerialNumber = "0000-0000"
            Case 1
                DriveSerialNumber = "0000-000" & S
            Case 2
                DriveSerialNumber = "0000-00" & S
            Case 3
                DriveSerialNumber = "0000-0" & S
            Case 4
                DriveSerialNumber = "0000-" & S
            Case 5
                DriveSerialNumber = "000" & Microsoft.VisualBasic.Left(S, 1) & "-" & Microsoft.VisualBasic.Right(S, 4)
            Case 6
                DriveSerialNumber = "00" & Microsoft.VisualBasic.Left(S, 2) & "-" & Microsoft.VisualBasic.Right(S, 4)
            Case 7
                DriveSerialNumber = "0" & Microsoft.VisualBasic.Left(S, 3) & "-" & Microsoft.VisualBasic.Right(S, 4)
            Case 8
                DriveSerialNumber = Microsoft.VisualBasic.Left(S, 4) & "-" & Microsoft.VisualBasic.Right(S, 4)
        End Select
    End Function

    Public Function SystemID(ByVal Index As Integer) As String
        Dim FSO As New Scripting.FileSystemObject
        Dim Serial As Long
        Dim Drive As String = "C"
        Dim HDSerial As Long
        Dim HDS As String
        Dim HardSeri8alNumber As String
        HDSerial = 0
        For I As Integer = 1 To 5
            If FSO.DriveExists(Drive) = True Then
                If FSO.GetDrive(Drive).IsReady = True Then
                    If FSO.GetDrive(Drive).DriveType = Scripting.DriveTypeConst.Fixed Then
                        Serial = FSO.GetDrive(Drive).SerialNumber
                        If Serial < 0 Then Serial = Serial * -1
                        HDSerial = HDSerial + Serial
                    End If
                End If
            End If
            Drive = Chr(Asc(Drive) + 1).ToString
        Next
        HDS = Microsoft.VisualBasic.Right(Hex(HDSerial), 8)
        Select Case HDS.Length
            Case 0
                HardSeri8alNumber = "00000000"
            Case 1
                HardSeri8alNumber = "0000000" & HDS
            Case 2
                HardSeri8alNumber = "000000" & HDS
            Case 3
                HardSeri8alNumber = "00000" & HDS
            Case 4
                HardSeri8alNumber = "0000" & HDS
            Case 5
                HardSeri8alNumber = "000" & HDS
            Case 6
                HardSeri8alNumber = "00" & HDS
            Case 7
                HardSeri8alNumber = "0" & HDS
            Case 8
                HardSeri8alNumber = HDS
        End Select
        Select Case Index
            Case 1
                SystemID = Microsoft.VisualBasic.Left(Hex(Microsoft.VisualBasic.Left(HardSeri8alNumber, 4).GetHashCode), 4)
            Case 2
                SystemID = Microsoft.VisualBasic.Right(Hex(Microsoft.VisualBasic.Left(HardSeri8alNumber, 4).GetHashCode), 4)
            Case 3
                SystemID = Microsoft.VisualBasic.Left(Hex(Microsoft.VisualBasic.Right(HardSeri8alNumber, 4).GetHashCode), 4)
            Case 4
                SystemID = Microsoft.VisualBasic.Right(Hex(Microsoft.VisualBasic.Right(HardSeri8alNumber, 4).GetHashCode), 4)
        End Select
    End Function

    Public Function ActivationCode(ByVal Index As Integer) As String
        Dim A
        Dim B
        A = SystemID(Index).GetHashCode
        B = ProgramCode(Index).GetHashCode
        ActivationCode = Mid(Hex((A + B + 1000) \ 2), Index + 1, 4)
    End Function

    Public Function ProgramCode(ByVal Index As Integer) As String
        Select Case Index
            Case 1
                ProgramCode = "RWHA"
            Case 2
                ProgramCode = "579G"
            Case 3
                ProgramCode = "C4ES"
            Case 4
                ProgramCode = "5MRF"
        End Select
    End Function

    Public Function ActiveCode() As String
        ActiveCode = ActivationCode(1) & "-" & ActivationCode(2) & "-" & ActivationCode(3) & "-" & ActivationCode(4)
    End Function

End Module
