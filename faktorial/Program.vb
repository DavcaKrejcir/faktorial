Imports System

Module Module1
    Sub Main()
        Dim cislo As Integer
        Dim vysledek As Integer = 1

        Console.Write("Zadejte cel� ��slo: ")
        cislo = Val(Console.ReadLine())

        For x As Integer = 1 To cislo
            vysledek *= x
        Next

        Console.WriteLine("Faktori�l ��sla " & cislo & " je " & vysledek)
        Console.ReadKey()
    End Sub
End Module