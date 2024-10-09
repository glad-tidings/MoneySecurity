Module Registry

    Public Function SetValue(ByVal Key As String, ByVal ValuePath As String, ByVal ValueName As String, ByVal Value As String)
        Dim CrSubKeyValue As Microsoft.Win32.RegistryKey
        Select Case Key
            Case "HKEY_CLASSES_ROOT"
                CrSubKeyValue = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(ValuePath)
                If (Not CrSubKeyValue Is Nothing) Then
                    CrSubKeyValue.SetValue(ValueName, Value)
                    CrSubKeyValue.Close()
                End If
            Case "HKEY_CURRENT_USER"
                CrSubKeyValue = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(ValuePath)
                If (Not CrSubKeyValue Is Nothing) Then
                    CrSubKeyValue.SetValue(ValueName, Value)
                    CrSubKeyValue.Close()
                End If
            Case "HKEY_LOCAL_MACHINE"
                CrSubKeyValue = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(ValuePath)
                If (Not CrSubKeyValue Is Nothing) Then
                    CrSubKeyValue.SetValue(ValueName, Value)
                    CrSubKeyValue.Close()
                End If
            Case "HKEY_USERS"
                CrSubKeyValue = Microsoft.Win32.Registry.Users.CreateSubKey(ValuePath)
                If (Not CrSubKeyValue Is Nothing) Then
                    CrSubKeyValue.SetValue(ValueName, Value)
                    CrSubKeyValue.Close()
                End If
            Case "HKEY_CURRENT_CONFIG"
                CrSubKeyValue = Microsoft.Win32.Registry.CurrentConfig.CreateSubKey(ValuePath)
                If (Not CrSubKeyValue Is Nothing) Then
                    CrSubKeyValue.SetValue(ValueName, Value)
                    CrSubKeyValue.Close()
                End If
        End Select
    End Function

    Public Function GetValue(ByVal Key As String, ByVal ValuePath As String, ByVal ValueName As String) As String
        Dim GeSubKeyValue As Microsoft.Win32.RegistryKey
        Select Case Key
            Case "HKEY_CLASSES_ROOT"
                GeSubKeyValue = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ValuePath)
                GetValue = CType(GeSubKeyValue.GetValue(ValueName), String)
                GeSubKeyValue.Close()
            Case "HKEY_CURRENT_USER"
                GeSubKeyValue = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(ValuePath)
                GetValue = CType(GeSubKeyValue.GetValue(ValueName), String)
                GeSubKeyValue.Close()
            Case "HKEY_LOCAL_MACHINE"
                GeSubKeyValue = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(ValuePath)
                GetValue = CType(GeSubKeyValue.GetValue(ValueName), String)
                GeSubKeyValue.Close()
            Case "HKEY_USERS"
                GeSubKeyValue = Microsoft.Win32.Registry.Users.OpenSubKey(ValuePath)
                GetValue = CType(GeSubKeyValue.GetValue(ValueName), String)
                GeSubKeyValue.Close()
            Case "HKEY_CURRENT_CONFIG"
                GeSubKeyValue = Microsoft.Win32.Registry.CurrentConfig.OpenSubKey(ValuePath)
                GetValue = CType(GeSubKeyValue.GetValue(ValueName), String)
                GeSubKeyValue.Close()
        End Select
    End Function

End Module
