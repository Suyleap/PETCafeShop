Public Class DrinkFoodClass

    Public Con As New ConnectionDbPetCafe
    Public Id, Name As String
    Public Price As Double

    Public Sub New()

    End Sub

    Public Sub New(id As String, name As String, price As Double)
        Me.Id = id
        Me.Name = name
        Me.Price = price
    End Sub

    Public Property Ids As String
        Get
            Return Id
        End Get
        Set(value As String)
            Id = value
        End Set
    End Property

    Public Property Names As String
        Get
            Return Name
        End Get
        Set(value As String)
            Name = value
        End Set
    End Property

    Public Property Prices As Double
        Get
            Return Price
        End Get
        Set(value As Double)
            Price = value
        End Set
    End Property

    Public Sub InsertHotDrink(id As String, name As String, price As Double)

        Con.SqLs = "Insert into HotDrink values('" & id & "','" & name & "'," & price & ")"
        Con.UseDatabase(Con.SqLs)
        Con.CloseConnection()
    End Sub

    Public Sub InsertIceDrink(ByVal id As String, ByVal name As String, ByVal price As Double)

        Con.SqLs = "Insert into IceDrink values('" & id & "','" & name & "'," & price & ")"
        Con.UseDatabase(Con.SqLs)
        Con.CloseConnection()
    End Sub

    Public Sub InsertFrabDrink(ByVal id As String, ByVal name As String, ByVal price As Double)

        Con.SqLs = "Insert into FrabDrink values('" & id & "','" & name & "'," & price & ")"
        Con.UseDatabase(Con.SqLs)
        Con.CloseConnection()
    End Sub

    Public Sub InsertFood(ByVal id As String, ByVal name As String, ByVal price As Double)

        Con.SqLs = "Insert into Food values('" & id & "','" & name & "'," & price & ")"
        Con.UseDatabase(Con.SqLs)
        Con.CloseConnection()
    End Sub

    Public Sub DeleteHotDrink(ByVal id As String)

        Con.SqLs = "Delete * from HotDrink Where ID='" & id & "'"
        Con.UseDatabase(Con.SqLs)
        Con.CloseConnection()
    End Sub

    Public Sub DeleteIceDrink(ByVal id As String)

        Con.SqLs = "Delete * from IceDrink Where ID='" & id & "'"
        Con.UseDatabase(Con.SqLs)
        Con.CloseConnection()
    End Sub

    Public Sub DeleteFrabDrink(ByVal id As String)

        Con.SqLs = "Delete * from FrabDrink Where ID='" & id & "'"
        Con.UseDatabase(Con.SqLs)
        Con.CloseConnection()
    End Sub

    Public Sub DeleteFood(ByVal id As String)

        Con.SqLs = "Delete * from Food Where ID='" & id & "'"
        Con.UseDatabase(Con.SqLs)
        Con.CloseConnection()
    End Sub

    Public Sub UpdateHotDrink(ByVal id As String, ByVal name As String, ByVal price As Double)

        Con.SqLs = "Update HotDrink Set Name='" & name & "', Price=" & price & " Where ID='" & id & "'"
        Con.UseDatabase(Con.SqLs)
        Con.CloseConnection()
    End Sub

    Public Sub UpdateIceDrink(ByVal id As String, ByVal name As String, ByVal price As Double)

        Con.SqLs = "Update IceDrink Set Name='" & name & "', Price=" & price & " Where ID='" & id & "'"
        Con.UseDatabase(Con.SqLs)
        Con.CloseConnection()
    End Sub

    Public Sub UpdateFrabDrink(ByVal id As String, ByVal name As String, ByVal price As Double)

        Con.SqLs = "Update FrabDrink Set Name='" & name & "', Price=" & price & " Where ID='" & id & "'"
        Con.UseDatabase(Con.SqLs)
        Con.CloseConnection()
    End Sub

    Public Sub UpdateFood(ByVal id As String, ByVal name As String, ByVal price As Double)

        Con.SqLs = "Update Food Set Name='" & name & "', Price=" & price & " Where ID='" & id & "'"
        Con.UseDatabase(Con.SqLs)
        Con.CloseConnection()
    End Sub

    Public Function ShowHotDrink(ByVal showall As List(Of DrinkFoodClass)) As Object
        showall = New List(Of DrinkFoodClass)

        Dim dfc As DrinkFoodClass
        Con.SqLs = "Select * from HotDrink"
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read
            dfc = New DrinkFoodClass(Con.Reader.Item(0), Con.Reader.Item(1), Con.Reader.Item(2))
            showall.Add(dfc)
        End While
        Con.CloseConnection()
        Return showall
    End Function

    Public Function ShowIceDrink(ByVal showall As List(Of DrinkFoodClass)) As Object
        showall = New List(Of DrinkFoodClass)

        Dim dfc As DrinkFoodClass
        Con.SqLs = "Select * from IceDrink"
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read
            dfc = New DrinkFoodClass(Con.Reader.Item(0), Con.Reader.Item(1), Con.Reader.Item(2))
            showall.Add(dfc)
        End While
        Con.CloseConnection()
        Return showall
    End Function

    Public Function ShowFrabDrink(ByVal showall As List(Of DrinkFoodClass)) As Object
        showall = New List(Of DrinkFoodClass)

        Dim dfc As DrinkFoodClass
        Con.SqLs = "Select * from FrabDrink"
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read
            dfc = New DrinkFoodClass(Con.Reader.Item(0), Con.Reader.Item(1), Con.Reader.Item(2))
            showall.Add(dfc)
        End While
        Con.CloseConnection()
        Return showall
    End Function

    Public Function ShowFood(ByVal showall As List(Of DrinkFoodClass)) As Object
        showall = New List(Of DrinkFoodClass)

        Dim dfc As DrinkFoodClass
        Con.SqLs = "Select * from Food"
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read
            dfc = New DrinkFoodClass(Con.Reader.Item(0), Con.Reader.Item(1), Con.Reader.Item(2))
            showall.Add(dfc)
        End While
        Con.CloseConnection()
        Return showall
    End Function

End Class
