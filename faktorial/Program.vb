Imports System

Module Module1
        Sub Main()
        Dim cislo As Integer
        Dim vysledek As Integer = 1
        Console.Write("Zadejte celé èíslo: ")
        cislo = Console.ReadLine()

        For x As Integer = 1 To cislo
            vysledek *= x
        Next

        Console.WriteLine("Faktoriál èísla " & cislo & " je " & vysledek)
        Console.ReadKey()
        End Sub
    End Module

