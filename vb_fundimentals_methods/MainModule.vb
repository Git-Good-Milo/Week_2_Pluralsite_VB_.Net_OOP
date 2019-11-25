Module MainModule

    Sub Main()

        ' Code to calculate dates from Product Clss
        Dim prod As New Product
        Dim sellDate As DateTime

        prod.SellStartDate = #5/1/2019#

        sellDate = prod.CalculateSellEndDate(30)
        Console.WriteLine(sellDate)

        ' Code to calculate money changes profit, loss etc
        Dim profit As New Product

        profit.StandardCost = 250
        profit.ListPrice = 500


        Console.WriteLine(profit.CalculateProfit())
        Console.WriteLine(profit.CalculateProfit(700))

        Console.ReadKey()
    End Sub

End Module
