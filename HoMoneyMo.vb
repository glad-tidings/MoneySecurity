Module HoMoneyMo

    Function Get_HoMoney(ByVal Money As Long) As String
        Get_HoMoney = ""
        If IIIIIIkan(Money) <> "" Then
            If (Money \ 1000000000000) <> 0 Then
                Get_HoMoney = Get_HoMoney & " و " & IIIIIIkan(Money)
            Else
                Get_HoMoney = IIIIIIkan(Money)
            End If
        End If
        If IIIIIkan(Money) <> "" Then
            If (Money \ 1000000000) <> 0 Then
                Get_HoMoney = Get_HoMoney & " و " & IIIIIkan(Money)
            Else
                Get_HoMoney = IIIIIkan(Money)
            End If
        End If
        If IIIIkan(Money) <> "" Then
            If (Money \ 1000000) <> 0 Then
                Get_HoMoney = Get_HoMoney & " و " & IIIIkan(Money)
            Else
                Get_HoMoney = IIIIkan(Money)
            End If
        End If
        If Money \ 100 <> 0 Then
            If IIIkan(Money) <> "" Then
                If (Money \ 1000) <> 0 Then
                    Get_HoMoney = Get_HoMoney & " و " & IIIkan(Money)
                Else
                    Get_HoMoney = IIIkan(Money)
                End If
            End If
        End If
        If Money \ 10 <> 0 Then
            If IIkan(Money) <> "" Then
                If (Money \ 100) <> 0 Then
                    Get_HoMoney = Get_HoMoney & " و " & IIkan(Money)
                Else
                    Get_HoMoney = IIkan(Money)
                End If
            End If
        End If
        If Money > 0 Then
            If Ikan(Money) <> "" Then
                If (Money \ 10) <> 0 Then
                    Get_HoMoney = Get_HoMoney & " و " & Ikan(Money)
                Else
                    Get_HoMoney = Ikan(Money)
                End If
            End If
        Else
            Get_HoMoney = "صفر"
        End If
    End Function

    Function Ikan(ByVal Money As Long) As String
        Select Case Money Mod 10
            Case 1
                Ikan = "یک"
            Case 2
                Ikan = "دو"
            Case 3
                Ikan = "سه"
            Case 4
                Ikan = "چهار"
            Case 5
                Ikan = "پنج"
            Case 6
                Ikan = "شش"
            Case 7
                Ikan = "هفت"
            Case 8
                Ikan = "هشت"
            Case 9
                Ikan = "نه"
        End Select
        If ((Money \ 10) Mod 10) = 1 Then Ikan = ""
    End Function

    Function IIkan(ByVal Money As Long) As String
        Select Case (Money \ 10) Mod 10
            Case 1
                Select Case Money Mod 10
                    Case 0
                        IIkan = "ده" : Exit Function
                    Case 1
                        IIkan = "یازده" : Exit Function
                    Case 2
                        IIkan = "دوازده" : Exit Function
                    Case 3
                        IIkan = "سیزده" : Exit Function
                    Case 4
                        IIkan = "چهارده" : Exit Function
                    Case 5
                        IIkan = "پانزده" : Exit Function
                    Case 6
                        IIkan = "شانزده" : Exit Function
                    Case 7
                        IIkan = "هفده" : Exit Function
                    Case 8
                        IIkan = "هجده" : Exit Function
                    Case 9
                        IIkan = "نوزده" : Exit Function
                End Select
            Case 2
                IIkan = "بیست"
            Case 3
                IIkan = "سی"
            Case 4
                IIkan = "چهل"
            Case 5
                IIkan = "پنجاه"
            Case 6
                IIkan = "شصت"
            Case 7
                IIkan = "هفتاد"
            Case 8
                IIkan = "هشتاد"
            Case 9
                IIkan = "نود"
        End Select
    End Function

    Function IIIkan(ByVal Money As Long) As String
        Select Case (Money \ 100) Mod 10
            Case 1
                IIIkan = "یکصد"
            Case 2
                IIIkan = "دویست"
            Case 3
                IIIkan = "سیصد"
            Case 4
                IIIkan = "چهارصد"
            Case 5
                IIIkan = "پانصد"
            Case 6
                IIIkan = "ششصد"
            Case 7
                IIIkan = "هفتصد"
            Case 8
                IIIkan = "هشتصد"
            Case 9
                IIIkan = "نهصد"
        End Select
    End Function

    Function IIIIkan(ByVal Money As Long) As String
        If (Money \ 1000) <> 0 And (Money Mod 1000000) <> 0 Then IIIIkan = Get_HoMoney((Money \ 1000) Mod 1000) & " هزار"
    End Function

    Function IIIIIkan(ByVal Money As Long) As String
        If (Money \ 1000000) <> 0 And (Money Mod 1000000000) <> 0 Then IIIIIkan = Get_HoMoney((Money \ 1000000) Mod 1000) & " میلیون"
    End Function

    Function IIIIIIkan(ByVal Money As Long) As String
        If (Money \ 1000000000) <> 0 Then IIIIIIkan = Get_HoMoney((Money \ 1000000000) Mod 1000) & " میلیارد"
    End Function

End Module
