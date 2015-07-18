Module mainRoutine

    '' Instances ''

    ' parameters
    Public arrLength As Integer
    Public arrMin As Integer
    Public arrMax As Integer
    Public uniqueOnly As Boolean

    ' data set
    Public baseSet As List(Of Integer)

    ' performance variables
    Public sWatch As Stopwatch
    Public finished As List(Of Boolean)
    Public times As List(Of Double)

    ' Main Loop
    Sub Main()
        ' Console Window Setup
        Console.Title = "Sorting Algorithm Comparison"
        Console.ForegroundColor = ConsoleColor.White
        Console.WindowLeft = 0
        Console.WindowTop = 0

        ' Publication/Version Info
        Console.WriteLine("Comparison of various sorting algorithms")
        Console.WriteLine("Written in VB.Net")
        Console.WriteLine("by Matt Spencer")
        Console.WriteLine("")
        Console.WriteLine("Version 1.0 Updated 2015.4.12")
        Console.WriteLine("")
        Console.Write("Press any key to continue...")
        Console.ReadKey()
        Console.Clear()

        ' Algorithm Descriptions
        Console.WriteLine("--------------------------------")
        Console.WriteLine("Algorithm Summaries")
        Console.WriteLine("--------------------------------")
        Console.WriteLine("")
        Console.WriteLine("Insertion Sort: Very simple and poorly performing")
        Console.WriteLine("Selection Sort: Very fast for small lists")
        Console.WriteLine("Bubble Sort: Very fast for lists that are almost sorted")
        Console.WriteLine("System.Linq: Built-in Linq function for benchmarking")
        Console.WriteLine("")
        Console.WriteLine("")

        ' Data Input
        Console.Write("Number of Integers in Set: ")
        arrLength = Console.ReadLine

        Console.Write("Min Value: ")
        arrMin = Console.ReadLine()

        Console.Write("Max Value: ")
        arrMax = Console.ReadLine()
err:
        Console.Write("Only Unique values (Y/N)?")
        Dim key As ConsoleKeyInfo = Console.ReadKey
        If key.Key = ConsoleKey.Y Then
            uniqueOnly = True
        ElseIf key.Key = ConsoleKey.N Then
            uniqueOnly = False
        Else
            Console.WriteLine("Please input Y or N.")
            Console.Clear()
            GoTo err
        End If

        ' Begin Sorting
        Console.WriteLine("")
        Console.Write("Press any key to begin...")
        Console.ReadKey()
        Console.Clear()

        ' Initialize dataset
        baseSet = New List(Of Integer)

        ' Initialize performance measures
        sWatch = New Stopwatch
        finished = New List(Of Boolean)
        times = New List(Of Double)
        For i = 0 To 4
            finished.Add(False)
            times.Add(0)
        Next

        ' Generate data set
        dataSet.generate()

        ' Begin thread manager
        threadManager.start()
    End Sub
End Module
