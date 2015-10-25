' ITCS 3146 Operating System and Networking 
' Dining Philosophers demonstration
'
' Group 3
' Nicholas Dinio
' Matthew Corbett
' Murilo Costa
' Henry Dejong
' Christopher Dong
' Jonathan Dymond
' Aulia Fauzi


Imports System.Threading


Public Class Form1

    Dim state(4) As Integer
    Dim sem(4) As Semaphore
    Dim philPics(4) As PictureBox   ' Picture box arrays for UI
    Dim forkPics(4) As PictureBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tot As Integer = 5 ' this is the total number of philosophers
        Dim philosopher(tot - 1) As Philosopher

        Console.WriteLine("The button has been pressed!")

        For i As Integer = 0 To philosopher.Length - 1
            state(i) = 0    ' Initialize states
            sem(i) = New Semaphore(1, 3)
            philosopher(i).total = tot      ' Initialize philosphers, create threads, start threads
            philosopher(i).number = i
            philosopher(i).trd = New Thread(AddressOf EatingProcedure)
            philosopher(i).trd.IsBackground = True
            philosopher(i).trd.Start(philosopher(i))
        Next i

        ' Initialize pictures of forks and philosophers on UI
        philPics(0) = Me.picPhil0
        philPics(1) = Me.picPhil1
        philPics(2) = Me.picPhil2
        philPics(3) = Me.picPhil3
        philPics(4) = Me.picPhil4

        forkPics(0) = Me.picFork0
        forkPics(1) = Me.picFork1
        forkPics(2) = Me.picFork2
        forkPics(3) = Me.picFork3
        forkPics(4) = Me.picFork4

    End Sub

    ' The philosopher strucutre creates unique information to each philosopher
    Private Structure Philosopher
        Dim total As Integer
        Dim trd As Thread
        Dim number As Integer


    End Structure

    Private Sub EatingProcedure(ByVal info As Philosopher)
        Dim left As Integer = (info.number + (info.total - 1)) Mod info.total
        Dim right As Integer = (info.number + 1) Mod info.total
        Console.WriteLine("I am philosopher number " & info.number & " My left neighbor is " & left & " and right is " & Right)

        Do
            Thread.Sleep(1500)

            Dim randomInt As Integer
            randomInt = GetRandom(1, 10)
            If (randomInt = 7) Then ' If randomly 7 then eat. Why 7? Because.

                'Philosopher is hungry
                state(info.number) = 1  'Hungry State
                philPics(info.number).Image = My.Resources.hungry
                Thread.Sleep(500)
                Console.WriteLine("Philosopher number " & info.number & " is hungry! Going to try to eat...")

                'Philosopher attempts to eat
                sem(left).WaitOne()              ' Attempts left fork
                sem(info.number).WaitOne()       ' Attempts right fork

                'Philosopher is eating
                state(info.number) = 2     'Eating state
                philPics(info.number).Image = My.Resources.eating
                forkPics(left).Image = Nothing
                forkPics(info.number).Image = Nothing
                Console.WriteLine("Philosopher number " & info.number & " is eating! " & left & " and " & Right & " are blocked.")
                Thread.Sleep(5000)         'Eating time

                'Philosopher goes back to thinking
                state(info.number) = 0  'Thinking state
                philPics(info.number).Image = My.Resources.thinking
                forkPics(left).Image = My.Resources.fork
                forkPics(info.number).Image = My.Resources.fork
                Thread.Sleep(500)
                sem(left).Release()                 ' Release left fork
                sem(info.number).Release()          ' Release right fork
                Console.WriteLine("Philosopher number " & info.number & " has released his forks! " & left & " and " & Right & " can eat now!")

            End If
        Loop

    End Sub
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        ' Just a random number generator. Nothing to see here.
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function
End Class
