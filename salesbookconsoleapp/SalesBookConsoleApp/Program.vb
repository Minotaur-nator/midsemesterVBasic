Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("DAILY SALES & DICOUNT TRACKER")
        Console.WriteLine("------------------------------------")
        Dim decItemPrice As Decimal
        Dim intQuantity As Integer
        Dim decTotalSales As Decimal = 0
        Dim strContinue As String = "Y"
        Dim decDiscountRate As Decimal
        Dim decFinalTotal As Decimal

        Do While strContinue.ToUpper() = "Y"
            Console.Write("Enter Item Price: ")
            decItemPrice = CDec(Console.ReadLine())

            Console.Write("Enter quantity sold: ")
            intQuantity = CInt(Console.ReadLine())

            decTotalSales += (decItemPrice * intQuantity)

            Console.Write("Do you want to enter another sale? (Y/N): ")
            strContinue = Console.ReadLine()
        Loop

        Select Case decTotalSales
            Case Is < 100
                decDiscountRate = 0D
            Case 100 To 500
                decDiscountRate = 0.05D
            Case Is > 500
                decDiscountRate = 0.1D
            Case Else
                decDiscountRate = 0D
        End Select

        decFinalTotal = decTotalSales - (decTotalSales * decDiscountRate)
        Console.WriteLine("------------------------------------")
        Console.WriteLine("-------RECEIPT-------")
        Console.WriteLine("------------------------------------")
        Console.WriteLine("Total Sales: " & decTotalSales.ToString("C2"))
        Console.WriteLine("Discount Applied: " & (decDiscountRate * 100) & "%")
        Console.WriteLine("Final Amount Due: " & decFinalTotal.ToString("C2"))
    End Sub
End Module
