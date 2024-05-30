Imports System

Module Module1
    Sub Main()
        Dim cislo As Integer
        Dim vysledek As Integer

        While True
            vysledek = 1
            Console.Write("Zadejte celé èíslo (0 až 10): ")
            cislo = Val(Console.ReadLine())

            If cislo < 0 Then
                Console.WriteLine("Záporné èíslo není platné. Zadejte prosím nezáporné celé èíslo.")
            ElseIf cislo > 10 Then
                Console.WriteLine("Èíslo je pøíliš velké, faktoriál nelze vypoèítat pro èísla vìtší než 10.")
            Else
                For x As Integer = 1 To cislo
                    vysledek *= x
                Next

                Console.WriteLine("Faktoriál èísla " & cislo & " je " & vysledek)
            End If

            Console.WriteLine("Pro nový výpoèet stisknìte jakoukoliv klávesu.")
            Console.ReadKey()
        End While
    End Sub
End Module