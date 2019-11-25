Public Class Product
    Sub New()
        StandardCost = 500
        ListPrice = 900
        SellStartDate = DateTime.Now
    End Sub

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

    ' The folowing functions will be used to demonstarte Overloading methods

    Overloads Function CalculateProfit() As Decimal
        Return CalculateProfit(StandardCost)
    End Function

    Overloads Function CalculateProfit(ByVal newCost As Decimal)
        If newCost <> 0 Then
            StandardCost = newCost
        End If

        Return ListPrice - StandardCost
    End Function



    ' This is a function to demonstarte optional methods
    'Function CalculateProfit(Optional ByVal newCost As Decimal = 0) As Decimal
    '    If newCost <> 0 Then
    '        StandardCost = newCost
    '    End If

    '    Return ListPrice - StandardCost
    'End Function

End Class
