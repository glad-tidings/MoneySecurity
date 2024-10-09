Friend Class ColumnSorter
    Implements IComparer
    Private col As Integer
    Private order As SortOrder

    Public Sub New()
        col = 0
        order = SortOrder.Ascending
    End Sub

    Public Sub New(ByVal column As Integer, ByVal order As SortOrder)
        col = column
        Me.order = order
    End Sub

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        'On Error Resume Next
        If col <> NewCol Then Exit Function
        Dim liX As ListViewItem
        Dim liY As ListViewItem
        Dim sTextX As String
        Dim sTextY As String
        Dim intRet As Integer
        liX = CType(x, ListViewItem)
        liY = CType(y, ListViewItem)
        sTextX = liX.SubItems(col).Text
        sTextY = liY.SubItems(col).Text
        Select Case SortType
            Case "String"
                intRet = String.Compare(sTextX, sTextY)
            Case "Numeric"
                intRet = 0
                If Double.Parse(sTextX) > Double.Parse(sTextY) Then intRet = 1
                If Double.Parse(sTextX) < Double.Parse(sTextY) Then intRet = -1
            Case "Date"
                intRet = Date.Compare(CType(sTextX, Date), CType(sTextY, Date))
        End Select
        If order = SortOrder.Descending Then
            intRet *= -1
        End If
        Return intRet
    End Function
End Class

