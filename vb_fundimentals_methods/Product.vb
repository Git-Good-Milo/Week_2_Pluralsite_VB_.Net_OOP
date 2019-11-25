Public Class Product

    Public Property ProductID As Integer
    Public Property Name As String
    Public Property ProductNumber As String
    Public Property Color As String
    Public Property ListPrice As Decimal
    Public Property StandardCost As Decimal
    Public Property Size As String
    Public Property Weight As Decimal
    Public Property SellStartDate As DateTime
    Public Property SellEndDate As DateTime

    Public ReadOnly Property NameAndNumber() As String
        ' This can be used when your property only needs to be read (Get) and not Set

        Get
            Return Name + "-" + ProductNumber
        End Get
    End Property

    Function CalculateSellEndDate(ByVal days As Integer) As DateTime ' Functions have to have a datatype assgined to them unlike Sub qu
        ' This does not return a value, only performs some kind of operation 
        SellEndDate = SellStartDate.AddDays(days)

        Return SellEndDate
        ' Instead of using Return, you can assgin the ouptput you want to the name of the function
        ' ie, <CalculateSellEndDate = SellEndDate>
        ' This will provide the same output as the Return parameter
    End Function

    Function CalculateProfit(Optional ByVal newCost As Decimal = 0) As Decimal
        If newCost <> 0 Then
            StandardCost = newCost
        End If

        Return ListPrice - StandardCost
    End Function

End Class
