Imports System.Threading

Public Class threadManager

    Private Shared pDone As Boolean = False
    Private Shared pManager As Thread
    Private Shared pDisplay As Thread
    Private Shared pThreads As List(Of Thread)

    Public Shared Sub start()
        ' Start thread manager
        pManager = New Thread(AddressOf manager)
        pManager.Start()

        'Start display manager
        pDisplay = New Thread(AddressOf display)
        pDisplay.Start()

        ' start sorting algorithms
        pThreads = New List(Of Thread)

        pThreads.Add(New Thread(AddressOf sorting.selection))
        pThreads.Add(New Thread(AddressOf sorting.insertion))
        pThreads.Add(New Thread(AddressOf sorting.bubble))
        pThreads.Add(New Thread(AddressOf sorting.linq))

        For i = 0 To 3
            pThreads.Item(i).Start(baseSet)
        Next
    End Sub
    Private Shared Sub manager()
        ' Start the timer
        sWatch.Start()

        ' tracking variables
        Dim elapsed As Double
        Dim done As Boolean = False

        ' begin manager/printing loop
        Do While done = False
            elapsed = sWatch.ElapsedMilliseconds / 1000

            ' check to see if they all finished
            done = True
            For i = 0 To 3
                If finished.Item(i) = False Then
                    done = False
                Else
                    If times.Item(i) = 0 Then
                        times.Item(i) = elapsed
                        pThreads.Item(i).Join()
                    End If
                End If
            Next
        Loop

        ' finished
        pDone = True
        Console.WriteLine("")
        Console.Write("Finished! Press any key to close the application...")
        Console.ReadKey()
    End Sub

    Private Shared Sub display()
        ' tracking variables
        Dim names As IList(Of String) = New List(Of String)
        names.Add("Selection: ")
        names.Add("Insertion: ")
        names.Add("Bubble: ")
        names.Add("Linq: ")

        ' begin manager/printing loop
        Do While pDone = False
            ' output the current status
            Console.Clear()
            Console.WriteLine("--------------------------------")
            Console.WriteLine("Algorithm Status")
            Console.WriteLine("--------------------------------")
            For i = 0 To 3
                If finished.Item(i) = False Then
                    Console.WriteLine(names.Item(i) & sWatch.ElapsedMilliseconds / 1000 & " seconds")
                Else
                    Console.WriteLine(names.Item(i) & times.Item(i) & " seconds")
                End If
            Next
            Thread.Sleep(200)
        Loop
    End Sub
End Class
