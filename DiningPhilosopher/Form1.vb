Imports System.Threading


Public Class Form1

    Dim state(4) As Integer
    Dim sem(4) As Semaphore
    Dim philPics(4) As PictureBox
    Dim forkPics(4) As PictureBox

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim tot As Integer = 5 ' this is the total number of philosophers
        Dim philosopher(tot - 1) As Philosopher

        Console.WriteLine("The button has been pressed!")

        For i As Integer = 0 To philosopher.Length - 1
            state(i) = 0
            sem(i) = New Semaphore(1, 3)
            philosopher(i).total = tot
            philosopher(i).number = i
            philosopher(i).trd = New Thread(AddressOf EatingProcedure)
            philosopher(i).trd.IsBackground = True
            philosopher(i).trd.Start(philosopher(i))
        Next i

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

    Private Structure Philosopher
        Dim total As Integer
        Dim trd As Thread
        Dim number As Integer


    End Structure

    Private Sub EatingProcedure(ByVal info As Philosopher)
        Dim left As Integer = (info.number + (info.total - 1)) Mod info.total
        Dim right As Integer = (info.number + 1) Mod info.total
        Console.WriteLine("I am philosopher number " & info.number & " My left neighbor is " & left & " and right is " & right)


        Do
            Thread.Sleep(1500)

            Dim randomInt As Integer
            randomInt = GetRandom(1, 10)
            If (randomInt = 7) Then
                state(info.number) = 1    ' philosopher is hungry
                philPics(info.number).Image = My.Resources.hungry
                Thread.Sleep(500)
                Console.WriteLine("Philosopher number " & info.number & " is hungry! Going to try to eat...")

                sem(left).WaitOne()              ' attempts left
                sem(info.number).WaitOne()       ' attempts right

                state(info.number) = 2     ' is eating
                philPics(info.number).Image = My.Resources.eating
                forkPics(left).Image = Nothing
                forkPics(info.number).Image = Nothing
                Console.WriteLine("Philosopher number " & info.number & " is eating! " & left & " and " & right & " are blocked.")

                Thread.Sleep(5000)         ' time to eat!


                state(info.number) = 0      ' back to thinking
                philPics(info.number).Image = My.Resources.thinking
                forkPics(left).Image = My.Resources.fork
                forkPics(info.number).Image = My.Resources.fork
                Thread.Sleep(500)
                sem(left).Release()         ' release left fork
                sem(info.number).Release()        ' release right fork
                Console.WriteLine("Philosopher number " & info.number & " has released his forks! " & left & " and " & right & " can eat now!")


            End If
        Loop

        'do philsopher things
    End Sub
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        ' by making Generator static, we preserve the same instance '
        ' (i.e., do not create new instances with the same seed over and over) '
        ' between calls '
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function
End Class
