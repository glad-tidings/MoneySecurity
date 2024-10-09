Module ShamsiDate

    Public Function Rooz(ByVal F_Date As Long) As Byte
        'این تابع عدد مربوط به روز یك تاریخ را برمگرداند
        Rooz = F_Date Mod 100
    End Function

    Function Mah(ByVal F_Date As Long) As Byte
        'این تابع عدد مربوط به ماه یك تاریخ را برمگرداند
        Mah = Int((F_Date Mod 10000) / 100)
    End Function

    Public Function Sal(ByVal F_Date As Long) As Byte
        'این تابع عدد مربوط به سال یك تاریخ را برمگرداند
        Sal = Int(F_Date / 10000)
    End Function
    Public Function Kabiseh(ByVal OnlySal As Object) As Byte
        'ورودی تابع عدد دورقمی است
        'این تابع كبیسه بودن سال را برمیگرداند
        'اگر سال كبیسه باشد عدد یك و درغیر اینصورت صفر را بر میگرداند
        Kabiseh = 0
        If OnlySal >= 75 Then
            If (OnlySal - 75) Mod 4 = 0 Then
                Kabiseh = 1
                Exit Function
            End If
        ElseIf OnlySal <= 70 Then
            If (70 - OnlySal) Mod 4 = 0 Then
                Kabiseh = 1
                Exit Function
            End If
        End If
    End Function

    Function ValidDate(ByVal F_Date As Long) As Boolean
        Dim M, S, R As Byte
        ' این تابع اعتبار یك عدد ورودی را از نظر تاریخ هجری شمسی بررسی می كند
        ' را برمی گرداند False واگر نامعتبر باشد True اگر تاریخ معتبر باشد
        ValidDate = True
        S = Sal(F_Date)
        M = Mah(F_Date)
        R = Rooz(F_Date)
        '********
        If F_Date < 100101 Then
            ValidDate = False
            Exit Function
        End If

        If M > 12 Or M = 0 Or R = 0 Then
            ValidDate = False
            Exit Function
        End If

        If R > MahDays(S, M) Then
            ValidDate = False
            Exit Function
        End If
    End Function

    Public Function AddDay(ByVal F_Date As Long, ByVal add As Integer) As Long
        Dim K, M, S, R, Days As Byte
        R = Rooz(F_Date)
        M = Mah(F_Date)
        S = Sal(F_Date)
        K = Kabiseh(S)
        'تبدیل روز به عدد 1 جهت ادامه محاسبات و یا اتمام محاسبه
        Days = MahDays(S, M)
        If add > Days - R Then
            add = add - (Days - R + 1)
            R = 1
            If M < 12 Then
                M = M + 1
            Else
                M = 1
                S = S + 1
            End If
        Else
            R = R + add
            add = 0
        End If
        While add > 0
            K = Kabiseh(S) 'كبیسه: 1 و غیر كبیسه: 0
            Days = MahDays(S, M) 'تعداد روزهای ماه فعلی
            Select Case add
                Case Is < Days
                    'اگر تعداد روزهای افزودنی كمتر از یك ماه باشد
                    R = R + add
                    add = 0
                Case Days To IIf(K = 0, 365, 366) - 1
                    'اگر تعداد روزهای افزودنی بیشتر از یك ماه و كمتر از یك سال باشد
                    add = add - Days
                    If M < 12 Then
                        M = M + 1
                    Else
                        S = S + 1
                        M = 1
                    End If
                Case Else
                    'اگر تعداد روزهای افزودنی بیشتر از یك سال باشد
                    S = S + 1
                    add = add - IIf(K = 0, 365, 366)
            End Select
        End While
        AddDay = (S * 10000) + (M * 100) + (R)
    End Function

    Public Function Shamsi(Optional ByVal Belave As Integer = 0) As String
        'تاریخ جاری سیستم را به تاریخ هجری شمسی تبدیل می كند
        Dim Shamsi_Mabna As Long
        Dim Miladi_Mabna As Date
        Dim Year As Integer
        Dim Dif As Long
        'در اینجا 80/10/11 با 2002/01/01 معادل قرارداده شده
        Shamsi_Mabna = 791012
        Miladi_Mabna = #1/1/2001#
        Dif = DateDiff("d", Miladi_Mabna, Today)
        If Dif < 0 Then
            Shamsi = "تاریخ جاری سیستم شما نادرست است , آنرا اصلاح كنید."
        Else
            Year = Left(AddDay(Shamsi_Mabna, Dif), 2)
            Year += Belave
            Shamsi = Year & "/" & Mid(AddDay(Shamsi_Mabna, Dif), 3, 2) & "/" & Right(AddDay(Shamsi_Mabna, Dif), 2)
        End If
    End Function

    Public Function Long_Shamsi() As String
        'تاریخ جاری سیستم را به تاریخ هجری شمسی تبدیل می كند
        Dim Shamsi_Mabna As Long
        Dim Miladi_mabna As Date
        Dim Dif As Long
        'در اینجا 80/10/11 با 2002/01/01 معادل قرارداده شده
        Shamsi_Mabna = 791012
        Miladi_mabna = #1/1/2001#
        Dif = DateDiff("d", Miladi_mabna, Today)
        If Dif < 0 Then
            Long_Shamsi = "تاریخ جاری سیستم شما نادرست است , آنرا اصلاح كنید."
        Else
            Long_Shamsi = DayWeek(AddDay(Shamsi_Mabna, Dif)) & " " & Right(AddDay(Shamsi_Mabna, Dif), 2) + " " + MonthName(Mid(AddDay(Shamsi_Mabna, Dif), 3, 2)) + " سال 13" + Left(AddDay(Shamsi_Mabna, Dif), 2)
        End If
    End Function

    Public Function DayWeek(ByVal F_Date As Long) As String
        Dim N As Byte
        N = DayWeekNo(F_Date)
        Select Case N
            Case 0
                DayWeek = "شنبه"
            Case 1
                DayWeek = "یكشنبه"
            Case 2
                DayWeek = "دوشنبه"
            Case 3
                DayWeek = "سه‌شنبه"
            Case 4
                DayWeek = "چهارشنبه"
            Case 5
                DayWeek = "پنج‌شنبه"
            Case 6
                DayWeek = "جمعه"
        End Select
    End Function

    Public Function Diff(ByVal FromDate As Long, ByVal To_Date As Long) As Long
        'این تابع تعداد روزهای بین دو تاریخ را ارائه می كند
        Dim Tmp As Long
        Dim S1, M1, r1, S2, m2, r2 As Integer
        Dim Sumation As Single
        Dim Flag As Boolean
        Flag = False
        If FromDate = 0 Or IsDBNull(FromDate) = True Or To_Date = 0 Or IsDBNull(To_Date) = True Then
            Diff = 0
            Exit Function
        End If
        If FromDate > To_Date Then
            'اگر تاریخ شروع از تاریخ پایان بزرگتر باشد آنها موقتا جابجا می شوند
            Flag = True
            Tmp = FromDate
            FromDate = To_Date
            To_Date = Tmp
        End If
        r1 = Rooz(FromDate)
        M1 = Mah(FromDate)
        S1 = Sal(FromDate)
        r2 = Rooz(To_Date)
        m2 = Mah(To_Date)
        S2 = Sal(To_Date)
        Sumation = 0
        Do While S1 < S2 - 1 Or (S1 = S2 - 1 And (M1 < m2 Or (M1 = m2 And r1 <= r2)))
            'اگر یك سال یا بیشتر اختلاف بود
            If Kabiseh((S1)) = 1 Then
                If M1 = 12 And r1 = 30 Then
                    Sumation = Sumation + 365
                    r1 = 29
                Else
                    Sumation = Sumation + 366
                End If
            Else
                Sumation = Sumation + 365
            End If
            S1 = S1 + 1
        Loop
        Do While S1 < S2 Or M1 < m2 - 1 Or (M1 = m2 - 1 And r1 < r2)
            'اگر یك ماه یا بیشتر اختلاف بود
            Select Case M1
                Case 1 To 6
                    If M1 = 6 And r1 = 31 Then
                        Sumation = Sumation + 30
                        r1 = 30
                    Else
                        Sumation = Sumation + 31
                    End If
                    M1 = M1 + 1
                Case 7 To 11
                    If M1 = 11 And r1 = 30 And Kabiseh(S1) = 0 Then
                        Sumation = Sumation + 29
                        r1 = 29
                    Else
                        Sumation = Sumation + 30
                    End If
                    M1 = M1 + 1
                Case 12
                    If Kabiseh(S1) = 1 Then
                        Sumation = Sumation + 30
                    Else
                        Sumation = Sumation + 29
                    End If
                    S1 = S1 + 1
                    M1 = 1
            End Select
        Loop
        If M1 = m2 Then
            Sumation = Sumation + (r2 - r1)
        Else
            Select Case M1
                Case 1 To 6
                    Sumation = Sumation + (31 - r1) + r2
                Case 7 To 11
                    Sumation = Sumation + (30 - r1) + r2
                Case 12
                    If Kabiseh(S1) = 1 Then
                        Sumation = Sumation + (30 - r1) + r2
                    Else
                        Sumation = Sumation + (29 - r1) + r2
                    End If
            End Select
        End If
        If Flag = True Then
            Sumation = -Sumation
        End If
        Diff = Sumation
    End Function

    Public Function DayWeekNo(ByVal F_Date As Long) As String
        'این تابع یك تاریخ را دریافت كرده و مشخص می كند چه روزی از هفته است
        'اگر شنبه باشد عدد 0
        'اگر 1شنبه باشد عدد 1
        '......
        'اگر جمعه باشد عدد 6
        Dim day As String
        Dim Shmsi_Mabna As Long
        Dim Dif As Long
        'مبنا 80/10/11
        Shmsi_Mabna = 801011
        Dif = Diff(Shmsi_Mabna, F_Date)
        If Shmsi_Mabna > F_Date Then
            Dif = -Dif
        End If
        'با توجه به اینكه 80/10/11 3شنبه است محاسبه میشود day متغیر
        day = (Dif + 3) Mod 7
        If day < 0 Then
            DayWeekNo = day + 7
        Else
            DayWeekNo = day
        End If
    End Function

    Function DayName(ByVal Day_Num As Integer) As String
        Dim Iekan As String
        Dim Dahgan As String
        Select Case Day_Num Mod 10
            Case 1
                Iekan = "یکم"
            Case 2
                Iekan = "دوم"
            Case 3
                Iekan = "سوم"
            Case 4
                Iekan = "چهارم"
            Case 5
                Iekan = "پنجم"
            Case 6
                Iekan = "ششم"
            Case 7
                Iekan = "هفتم"
            Case 8
                Iekan = "هشتم"
            Case 9
                Iekan = "نهم"
        End Select
        Select Case Day_Num \ 10
            Case 1
                Select Case Day_Num Mod 10
                    Case 1
                        DayName = "یازدهم" : Exit Function
                    Case 2
                        DayName = "دوازدهم" : Exit Function
                    Case 3
                        DayName = "سیزدهم" : Exit Function
                    Case 4
                        DayName = "چهاردهم" : Exit Function
                    Case 5
                        DayName = "پانزدهم" : Exit Function
                    Case 6
                        DayName = "شانزدهم" : Exit Function
                    Case 7
                        DayName = "هفدهم" : Exit Function
                    Case 8
                        DayName = "هجدهم" : Exit Function
                    Case 9
                        DayName = "نوزدهم" : Exit Function
                End Select
                Dahgan = "ده"
            Case 2
                Dahgan = "بیست"
            Case 3
                Dahgan = "سی"
            Case 4
                Dahgan = "چهل"
            Case 5
                Dahgan = "پنجاه"
            Case 6
                Dahgan = "شضت"
            Case 7
                Dahgan = "هفتاد"
            Case 8
                Dahgan = "هشتاد"
            Case 9
                Dahgan = "نود"
        End Select
        If Iekan = "" Then
            DayName = Dahgan & "م"
        ElseIf Dahgan = "" Then
            DayName = Iekan
        Else
            DayName = Dahgan & " و " & Iekan
        End If
    End Function

    Function MonthName(ByVal Month_Num As Integer) As String
        Select Case Month_Num
            Case 1
                MonthName = "فروردین"
            Case 2
                MonthName = "اردیبهشت"
            Case 3
                MonthName = "خرداد"
            Case 4
                MonthName = "تیر"
            Case 5
                MonthName = "مرداد"
            Case 6
                MonthName = "شهریور"
            Case 7
                MonthName = "مهر"
            Case 8
                MonthName = "آبان"
            Case 9
                MonthName = "آذر"
            Case 10
                MonthName = "دی"
            Case 11
                MonthName = "بهمن"
            Case 12
                MonthName = "اسفند"
        End Select
    End Function

    Function YearName(ByVal Year_Num As Integer) As String
        Dim Iekan As String
        Dim Dahgan As String
        Dim Sadgan As String
        Dim Hezargan As String
        Select Case Year_Num Mod 10
            Case 1
                Iekan = "یک"
            Case 2
                Iekan = "دو"
            Case 3
                Iekan = "سه"
            Case 4
                Iekan = "چهار"
            Case 5
                Iekan = "پنج"
            Case 6
                Iekan = "شش"
            Case 7
                Iekan = "هفت"
            Case 8
                Iekan = "هشت"
            Case 9
                Iekan = "نه"
        End Select
        Select Case (Year_Num \ 10) Mod 10
            Case 1
                Select Case Year_Num Mod 10
                    Case 1
                        YearName = "یازده" : Exit Function
                    Case 2
                        YearName = "دوازده" : Exit Function
                    Case 3
                        YearName = "سیزده" : Exit Function
                    Case 4
                        YearName = "چهارده" : Exit Function
                    Case 5
                        YearName = "پانزده" : Exit Function
                    Case 6
                        YearName = "شانزده" : Exit Function
                    Case 7
                        YearName = "هفده" : Exit Function
                    Case 8
                        YearName = "هجده" : Exit Function
                    Case 9
                        YearName = "نوزده" : Exit Function
                End Select
                Dahgan = "ده"
            Case 2
                Dahgan = "بیست"
            Case 3
                Dahgan = "سی"
            Case 4
                Dahgan = "چهل"
            Case 5
                Dahgan = "پنجاه"
            Case 6
                Dahgan = "شضت"
            Case 7
                Dahgan = "هفتاد"
            Case 8
                Dahgan = "هشتاد"
            Case 9
                Dahgan = "نود"
        End Select
        Select Case (Year_Num \ 100) Mod 10
            Case 1
                Sadgan = "یکصد"
            Case 2
                Sadgan = "دویصت"
            Case 3
                Sadgan = "سیصد"
            Case 4
                Sadgan = "چهارصد"
            Case 5
                Sadgan = "پانصد"
            Case 6
                Sadgan = "ششصد"
            Case 7
                Sadgan = "هفتصد"
            Case 8
                Sadgan = "هشتصد"
            Case 9
                Sadgan = "نهصد"
        End Select
        Select Case Year_Num \ 1000
            Case 1
                Hezargan = "یک هزار"
            Case 2
                Hezargan = "دو هزار"
            Case 3
                Hezargan = "سه هزار"
            Case 4
                Hezargan = "چهار هزار"
            Case 5
                Hezargan = "پنج هزار"
            Case 6
                Hezargan = "شش هزار"
            Case 7
                Hezargan = "هفت هزار"
            Case 8
                Hezargan = "هشت هزار"
            Case 9
                Hezargan = "نه هزار"
        End Select
        If Hezargan <> "" Then
            If Sadgan = "" Then YearName = Hezargan Else YearName = Hezargan & " و "
        End If
        If Sadgan <> "" Then
            If Dahgan = "" Then YearName = YearName & Sadgan Else YearName = YearName & Sadgan & " و "
        End If
        If Dahgan <> "" Then
            If Iekan = "" Then YearName = YearName & Dahgan Else YearName = YearName & Dahgan & " و "
        End If
        If Iekan <> "" Then YearName = YearName & Iekan
    End Function

    Function SalMah(ByVal F_Date As Long) As Integer
        'چهار رقم اول تاریخ كه معرف سال و ماه است را برمی گرداند
        SalMah = Val(Left$(F_Date, 4))
    End Function

    Function MahDays(ByVal Sal As Byte, ByVal Mah As Byte) As Byte
        'این تابع تعداد روزهای یك ماه را برمی گرداند
        Select Case Mah
            Case 1 To 6
                MahDays = 31
            Case 7 To 11
                MahDays = 30
            Case 12
                If Kabiseh(Sal) = 1 Then
                    MahDays = 30
                Else
                    MahDays = 29
                End If
        End Select
    End Function

    Function NextMah(ByVal Sal_Mah As Integer) As Integer
        If (Sal_Mah Mod 100) = 12 Then
            NextMah = (Int(Sal_Mah / 100) + 1) * 100 + 1
        Else
            NextMah = Sal_Mah + 1
        End If
    End Function

    Function PreviousMah(ByVal Sal_Mah As Integer) As Integer
        If (Sal_Mah Mod 100) = 1 Then
            PreviousMah = (Int(Sal_Mah / 100) - 1) * 100 + 12
        Else
            PreviousMah = Sal_Mah - 1
        End If
    End Function

    Function SubtractDay(ByVal F_Date As String, ByVal Subtract As Long) As String
        'به تعداد روز معینی از یك تاریخ كم كرده و تاریخ حاصله را ارائه میكند
        F_Date = Int(Left(F_Date, 2) & Mid(F_Date, 4, 2) & Right(F_Date, 2))
        Dim FSubtractDay As Long
        Dim K, M, S, R, Days As Byte
        R = Rooz(F_Date)
        M = Mah(F_Date)
        S = Sal(F_Date)
        K = Kabiseh(S)
        'تبدیل روز به عدد 1 جهت ادامه محاسبات و یا اتمام محاسبه
        If Subtract >= R - 1 Then
            Subtract = Subtract - (R - 1)
            R = 1
        Else
            R = R - Subtract
            Subtract = 0
        End If
        While Subtract > 0
            K = Kabiseh(S - 1) 'كبیسه: 1 و غیر كبیسه: 0
            Days = MahDays(IIf(M >= 2, S, S - 1), IIf(M >= 2, M - 1, 12)) 'تعداد روزهای ماه قبلی
            Select Case Subtract
                Case Is < Days
                    'اگر تعداد روزهای كاهش كمتر از یك ماه باشد
                    R = Days - Subtract + 1
                    Subtract = 0
                    If M >= 2 Then
                        M = M - 1
                    Else
                        S = S - 1
                        M = 12
                    End If
                Case Days To IIf(K = 0, 365, 366) - 1
                    'اگر تعداد روزهای كاهش بیشتر از یك ماه و كمتر از یك سال باشد
                    Subtract = Subtract - Days
                    If M >= 2 Then
                        M = M - 1
                    Else
                        S = S - 1
                        M = 12
                    End If
                Case Else
                    'اگر تعداد روزهای كاهش بیشتر از یك سال باشد
                    S = S - 1
                    Subtract = Subtract - IIf(K = 0, 365, 366)
            End Select
        End While
        FSubtractDay = (S * 10000) + (M * 100) + (R)
        SubtractDay = Left(FSubtractDay, 2) & "/" & Mid(FSubtractDay, 3, 2) & "/" & Right(FSubtractDay, 2)
    End Function

    Public Function Dirkard(ByVal F_Date As String, ByVal S_Date As String) As Boolean
        F_Date = Left(F_Date, 2) & Mid(F_Date, 4, 2) & Right(F_Date, 2)
        S_Date = Left(S_Date, 2) & Mid(S_Date, 4, 2) & Right(S_Date, 2)
        If F_Date > S_Date Then
            Return True
        Else
            Return False
        End If
    End Function

    Function MeTime() As String
        Dim TOD As Integer = TimeOfDay.Ticks \ 600000000
        Dim Min As Integer = TOD Mod 60
        Dim Hou As Integer = TOD \ 60
        MeTime = Hou & ":" & Min
    End Function

    Function TaTime() As String
        Dim TOD As Integer = (TimeOfDay.Ticks \ 600000000) + 10
        Dim Min As Integer = TOD Mod 60
        Dim Hou As Integer = TOD \ 60
        TaTime = Hou & ":" & Min
    End Function

    Function MidTime() As String
        Dim TOD As Integer = TimeOfDay.Ticks \ 600000000
        Dim Min As String = TOD Mod 60
        Dim Hou As String = TOD \ 60
        If Len(Min) = 1 Then Min = "0" & Min
        If Len(Hou) = 1 Then Hou = "0" & Hou
        MidTime = Hou & ":" & Min
    End Function

    Function HoTa(ByVal F_Date As String) As String
        Dim F_Day As Integer = Int(Right(F_Date, 2))
        Dim F_Month As Integer = Int(Mid(F_Date, 4, 2))
        Dim F_Year As Integer = Int(Left(F_Date, 2))
        HoTa = DayName(F_Day) & " " & MonthName(F_Month) & " " & YearName(F_Year)
    End Function

End Module
