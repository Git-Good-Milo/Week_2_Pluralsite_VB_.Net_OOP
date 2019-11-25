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
        Dim new_calc As Decimal

        new_calc = profit.CalculateProfit()
        If new_calc < 0 Then
            Console.WriteLine($"No profit made with a loss of {new_calc}")
        ElseIf new_calc > 0 Then
            Console.WriteLine($"A profit of {new_calc} was made")
        End If

        ' Code to demonstrate how shared fucntions work using the product class
        ' Notice how an instace of the class was not needed
        Console.WriteLine(Product.CalculateTheProfit(900, 1400))

        Console.ReadKey()
    End Sub

End Module
