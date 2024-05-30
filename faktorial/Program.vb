Imports System

Module Module1
    Sub Main()
        Dim cislo As Integer
        Dim vysledek As Integer = 1

        Console.Write("Zadejte celé èíslo (maximálnì 10): ")
        cislo = Val(Console.ReadLine())

        If cislo > 10 Then
            Console.WriteLine("Èíslo je pøíliš velké, faktoriál nelze vypoèítat.")
        Else
            For x As Integer = 1 To cislo
                vysledek *= x
            Next

            Console.WriteLine("Faktoriál èísla " & cislo & " je " & vysledek)
        End If

        Console.ReadKey()
    End Sub
End Module