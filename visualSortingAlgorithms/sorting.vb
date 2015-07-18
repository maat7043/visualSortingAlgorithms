Public Class sorting
    Public Shared Sub selection(data As List(Of Integer))
        Dim n As Integer = data.Count
        Dim pos As Integer

        For i = 1 To n - 1
            pos = i
            For j = i + 1 To n - 1
                If data.Item(pos) > data.Item(j) Then
                    pos = j
                End If
            Next
            If Not pos = i Then
                Dim t As Integer = data.Item(i)
                data.Item(i) = data.Item(pos)
                data.Item(pos) = t
            End If
        Next

        finished.Item(0) = True
    End Sub

    Public Shared Sub insertion(data As List(Of Integer))
        Dim n As Integer = data.Count
        Dim d As Integer

        For i = 1 To n - 1
            d = i
            Try
                While d > 0 And data.Item(d) < data.Item(d - 1)
                    Dim t = data.Item(d)
                    data.Item(d) = data.Item(d - 1)
                    data.Item(d - 1) = t
                    d -= 1
                End While
            Catch
            End Try
        Next

        finished.Item(1) = True
    End Sub

    Public Shared Sub bubble(data As List(Of Integer))
        Dim n As Integer = data.Count

        For i = 1 To n - 1
            For j = 0 To n - i - 1
                If data.Item(j) > data.Item(j + 1) Then
                    Dim t = data.Item(j)
                    data.Item(j) = data.Item(j + 1)
                    data.Item(j + 1) = t
                End If
            Next
        Next

        finished.Item(2) = True
    End Sub

    Public Shared Sub linq(data As List(Of Integer))
        data.Sort()
        finished.Item(3) = True
    End Sub
End Class
