Public Class dataSet
    Public Shared Sub generate()
        ' Create new Random Object
        Dim rnd As Random = New Random() ' <-- A seed could be used here

        ' Generate dataSet
        For i = 0 To arrLength - 1
redo:
            Dim t As Integer = rnd.Next(arrMin, arrMax)
            If uniqueOnly = True And baseSet.Contains(t) Then
                GoTo redo
            End If
            baseSet.Add(t)
        Next
    End Sub
End Class
