Imports System

Module Module1
    Sub Main()
        Dim cislo As Integer
        Dim vysledek As Integer = 1

        Console.Write("Zadejte cel� ��slo (0 a� 10): ")
        cislo = Val(Console.ReadLine())

        If cislo < 0 Then
            Console.WriteLine("Z�porn� ��slo nen� platn�. Zadejte pros�m nez�porn� cel� ��slo.")
        ElseIf cislo > 10 Then
            Console.WriteLine("��slo je p��li� velk�, faktori�l nelze vypo��tat pro ��sla v�t�� ne� 10.")
        Else
            For x As Integer = 1 To cislo
                vysledek *= x
            Next

            Console.WriteLine("Faktori�l ��sla " & cislo & " je " & vysledek)
        End If

        Console.ReadKey()
    End Sub
End Module
