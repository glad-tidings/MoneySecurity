Public Class DBConnection

#Region "Class Import"

    Friend WithEvents OLEConn As New System.Data.OleDb.OleDbConnection
    Friend WithEvents OLEComm As New System.Data.OleDb.OleDbCommand
    Public Shared dataReturned As New ArrayList

#End Region

#Region "class Function"

    Function connectMe(ByVal DBString) As Boolean
        Dim DBProvider As String = "Provider=Microsoft.Jet.OLEDB.4.0"
        Dim DBMode As String = "Mode=ReadWrite"
        Dim DBPath As String = "Data source=" & App_Path() & "MoneySec.DataBase.dll"
        Dim DBPass As String = "Jet OLEDB:Database Password=bhmz2006hgt10"
        Try
            OLEConn.ConnectionString = DBProvider & ";" & DBMode & ";" & DBPath '& ";" & DBPass
            OLEConn.Open()
            OLEComm.CommandText = DBString
            Return True
        Catch err As System.Exception
            'MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            Return False
        End Try
    End Function

    Function ReconnectMe(ByVal DBString) As Boolean
        Dim DBProvider As String = "Provider=Microsoft.Jet.OLEDB.4.0"
        Dim DBMode As String = "Mode=ReadWrite"
        Dim DBPath As String = "Data source=" & App_Path() & "Resid\MoneySec.Resid.DataBase.dll"
        Dim DBPass As String = "Jet OLEDB:Database Password=bhmz2006hgt10"
        Try
            OLEConn.ConnectionString = DBProvider & ";" & DBMode & ";" & DBPath '& ";" & DBPass
            OLEConn.Open()
            OLEComm.CommandText = DBString
            Return True
        Catch err As System.Exception
            'MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            Return False
        End Try
    End Function

    Function getData(ByVal FieldName As String) As ArrayList
        Try
            OLEComm.Connection = OLEConn
            getData = New ArrayList
            Dim d As OleDb.OleDbDataReader = OLEComm.ExecuteReader()
            Do While d.Read
                getData.Add(d(FieldName.ToString))
            Loop
            dataReturned = getData
            Try
                OLEConn.Close()
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            End Try
        Catch err As System.Exception
            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
        End Try
    End Function

#End Region

End Class