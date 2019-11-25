Module MainModule

    Sub Main()

        Dim prod As New Product
        Dim sellDate As DateTime

        prod.SellStartDate = #5/1/2019#

        sellDate = prod.CalculateSellEndDate(30)

        Console.WriteLine(sellDate)
        Console.ReadKey()

    End Sub

End Module
