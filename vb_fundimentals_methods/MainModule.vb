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

        ' Code to show Product Class inheriting from CommonBase Class
        Dim prod2 As New Product
        prod2.IsActive = True
        prod2.CreatedBy = "Man like Milo"
        ' The methods and fucntions from Product Class have not been affected by the inheritance 
        ' and can still be used
        prod2.ListPrice = 600

        ' Code to Show how a With statement can be used in conjuntion with a class during inheritance
        ' The With Key word allows us to chain properties in a Class without having to referecnce thre variable name
        Dim prod3 As New Product With {
            .ProductID = 700,
            .Name = "10 Speed Bike",
            .ProductNumber = "12d-dja8-a"
        }
        Console.WriteLine(prod3.ToString())

        Dim cust As New Customer With {
            .CustomerID = 1,
            .CompanyName = "Beach Computer Consulting",
            .FirstName = "Bruce",
            .LastName = "Jones"
        }
        Console.WriteLine(cust.ToString())


        Console.ReadKey()
    End Sub

End Module
