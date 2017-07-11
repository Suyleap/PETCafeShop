Public Class DrinkFoodClass

    Private con As New ConnectionDBPetCafe
    Public ID, Name As String
    Public Price As Double

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal name As String, ByVal price As Double)
        Me.ID = id
        Me.Name = name
        Me.Price = price
    End Sub

    Public Property IDs As String
        Get
            Return Me.ID
        End Get
        Set(value As String)
            Me.ID = value
        End Set
    End Property

    Public Property Names As String
        Get
            Return Me.Name
        End Get
        Set(value As String)
            Me.Name = value
        End Set
    End Property

    Public Property Prices As Double
        Get
            Return Me.Price
        End Get
        Set(value As Double)
            Me.Price = value
        End Set
    End Property

    Public Sub InsertHotDrink(ByVal id As String, ByVal name As String, ByVal price As Double)
        Try
            con.SQLs = "Insert into HotDrink values('" & id & "','" & name & "'," & price & ")"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox("Sorry we can't")
        End Try
    End Sub

    Public Sub InsertIceDrink(ByVal id As String, ByVal name As String, ByVal price As Double)
        Try
            con.SQLs = "Insert into IceDrink values('" & id & "','" & name & "'," & price & ")"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox("Sorry we can't")
        End Try
    End Sub

    Public Sub InsertFrabDrink(ByVal id As String, ByVal name As String, ByVal price As Double)
        Try
            con.SQLs = "Insert into FrabDrink values('" & id & "','" & name & "'," & price & ")"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox("Sorry we can't")
        End Try
    End Sub

    Public Sub InsertFood(ByVal id As String, ByVal name As String, ByVal price As Double)
        Try
            con.SQLs = "Insert into Food values('" & id & "','" & name & "'," & price & ")"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox("Sorry we can't")
        End Try
    End Sub

    Public Sub DeleteHotDrink(ByVal id As String)
        Try
            con.SQLs = "Delete * from HotDrink Where ID='" & id & "'"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox("Sorry we can't")
        End Try
    End Sub

    Public Sub DeleteIceDrink(ByVal id As String)
        Try
            con.SQLs = "Delete * from IceDrink Where ID='" & id & "'"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox("Sorry we can't")
        End Try
    End Sub

    Public Sub DeleteFrabDrink(ByVal id As String)
        Try
            con.SQLs = "Delete * from FrabDrink Where ID='" & id & "'"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox("Sorry we can't")
        End Try
    End Sub

    Public Sub DeleteFood(ByVal id As String)
        Try
            con.SQLs = "Delete * from Food Where ID='" & id & "'"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox("Sorry we can't")
        End Try
    End Sub

    Public Sub UpdateHotDrink(ByVal id As String, ByVal name As String, ByVal price As Double)
        Try
            con.SQLs = "Update HotDrink Set Name='" & name & "', Price=" & price & " Where ID='" & id & "'"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox("Sorry we can't")
        End Try
    End Sub

    Public Sub UpdateIceDrink(ByVal id As String, ByVal name As String, ByVal price As Double)
        Try
            con.SQLs = "Update IceDrink Set Name='" & name & "', Price=" & price & " Where ID='" & id & "'"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox("Sorry we can't")
        End Try
    End Sub

    Public Sub UpdateFrabDrink(ByVal id As String, ByVal name As String, ByVal price As Double)
        Try
            con.SQLs = "Update FrabDrink Set Name='" & name & "', Price=" & price & " Where ID='" & id & "'"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox("Sorry we can't")
        End Try
    End Sub

    Public Sub UpdateFood(ByVal id As String, ByVal name As String, ByVal price As Double)
        Try
            con.SQLs = "Update Food Set Name='" & name & "', Price=" & price & " Where ID='" & id & "'"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox("Sorry we can't")
        End Try
    End Sub

    Public Function ShowHotDrink(ByVal showall As List(Of DrinkFoodClass)) As Object
        showall = New List(Of DrinkFoodClass)
        Try
            Dim dfc As DrinkFoodClass
            con.SQLs = "Select * from HotDrink"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read
                dfc = New DrinkFoodClass(con.reader.Item(0), con.reader.Item(1), con.reader.Item(2))
                showall.Add(dfc)
            End While
        Catch ex As Exception
            MsgBox("Sorry we Can't")
        End Try
        Return showall
    End Function

    Public Function ShowIceDrink(ByVal showall As List(Of DrinkFoodClass)) As Object
        showall = New List(Of DrinkFoodClass)
        Try
            Dim dfc As DrinkFoodClass
            con.SQLs = "Select * from IceDrink"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read
                dfc = New DrinkFoodClass(con.reader.Item(0), con.reader.Item(1), con.reader.Item(2))
                showall.Add(dfc)
            End While
        Catch ex As Exception
            MsgBox("Sorry we Can't")
        End Try
        Return showall
    End Function

    Public Function ShowFrabDrink(ByVal showall As List(Of DrinkFoodClass)) As Object
        showall = New List(Of DrinkFoodClass)
        Try
            Dim dfc As DrinkFoodClass
            con.SQLs = "Select * from FrabDrink"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read
                dfc = New DrinkFoodClass(con.reader.Item(0), con.reader.Item(1), con.reader.Item(2))
                showall.Add(dfc)
            End While
        Catch ex As Exception
            MsgBox("Sorry we Can't")
        End Try
        Return showall
    End Function

    Public Function ShowFood(ByVal showall As List(Of DrinkFoodClass)) As Object
        showall = New List(Of DrinkFoodClass)
        Try
            Dim dfc As DrinkFoodClass
            con.SQLs = "Select * from Food"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read
                dfc = New DrinkFoodClass(con.reader.Item(0), con.reader.Item(1), con.reader.Item(2))
                showall.Add(dfc)
            End While
        Catch ex As Exception
            MsgBox("Sorry we Can't")
        End Try
        Return showall
    End Function

End Class
