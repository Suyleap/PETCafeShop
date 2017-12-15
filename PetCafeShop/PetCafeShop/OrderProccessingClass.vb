Public Class OrderProccessingClass

    Public Con As New ConnectionDBPetCafe
    Public Dfc As New DrinkFoodClass
    Private _flpn As FlowLayoutPanel

    Private _bt As Button
    Private ReadOnly _bta(50) As Button

    Public Total As Double
    Public Quantity As Integer
    Public Drinkname As String = "Nothing"
    Public TableNumber As String = 0
    Public Seller As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal name As String, ByVal quantity As Integer, ByVal price As Double, ByVal total As Double)
        Me.Name = name
        Me.Quantity = quantity
        Me.Price = price
        Me.Total = total
    End Sub

    Public Property Name As String
        Get
            Return dfc.Name
        End Get
        Set(value As String)
            dfc.Name = value
        End Set
    End Property

    Public Property Quantitys As Integer
        Get
            Return Quantity
        End Get
        Set(value As Integer)
            Quantity = value
        End Set
    End Property

    Public Property Price As Double
        Get
            Return dfc.Price
        End Get
        Set(value As Double)
            dfc.Price = value
        End Set
    End Property

    Public Property Totals As Double

    ' Public Property Sellers As String

    Public Function ShowHotButton() As Windows.Forms.FlowLayoutPanel

        _flpn = New FlowLayoutPanel
        _flpn.Controls.Clear()
        _flpn.Name = "flpnHotDrink"
        _flpn.AutoScroll = True
        _flpn.Location = New Point(16, 78)
        _flpn.Size = New Size(579, 213)

        Con.SqLs = "Select * from HotDrink"
        Con.UseDatabasetoread(Con.SqLs)
        Dim i As Integer

        _bta(50) = New Button
        While Con.Reader.Read
            _bta(i) = New Windows.Forms.Button
            _bta(i).Size = New Size(166, 55)
            _bta(i).Text = Con.Reader.Item(1)
            _bta(i).Name = Con.Reader.Item(1)

            _flpn.Controls.AddRange({_bta(i)})

            AddHandler _bta(i).Click, AddressOf HotbuttonClick
            i = i + 1
        End While
        
        Con.CloseConnection()
        Return _flpn
    End Function

    Public Function ShowIceButton() As Windows.Forms.FlowLayoutPanel
        ' 
        _flpn = New FlowLayoutPanel()
        _flpn.Controls.Clear()
        _flpn.Name = "flpnIceDrink"
        _flpn.AutoScroll = True
        _flpn.Location = New Point(16, 78)
        _flpn.Size = New Size(579, 213)

        Con.SqLs = "Select * from IceDrink"
        Con.UseDatabasetoread(Con.SqLs)
        Dim i As Integer

        _bta(50) = New Button()
        While Con.Reader.Read
            _bta(i) = New Windows.Forms.Button
            _bta(i).Size = New Size(166, 55)
            _bta(i).Text = Con.Reader.Item(1)

            _flpn.Controls.AddRange({_bta(i)})

            AddHandler _bta(i).Click, AddressOf IcebuttonClick
            i = i + 1
        End While
        
        Con.CloseConnection()
        Return _flpn
    End Function

    Public Function ShowFrabButton() As Windows.Forms.FlowLayoutPanel

        _flpn = New FlowLayoutPanel()
        _flpn.Controls.Clear()
        _flpn.Name = "flpnFrabDrink"
        _flpn.AutoScroll = True
        _flpn.Location = New Point(16, 78)
        _flpn.Size = New Size(579, 213)

        Con.SqLs = "Select * from FrabDrink"
        Con.UseDatabasetoread(Con.SqLs)
        Dim i As Integer

        _bta(50) = New Button()
        While Con.Reader.Read
            _bta(i) = New Windows.Forms.Button
            _bta(i).Size = New Size(166, 55)
            _bta(i).Text = Con.Reader.Item(1)

            _flpn.Controls.AddRange({_bta(i)})
            AddHandler _bta(i).Click, AddressOf FrabbuttonClick
            i = i + 1

        End While
        
        Con.CloseConnection()
        Return _flpn
    End Function

    Public Function ShowFoodButton() As Windows.Forms.FlowLayoutPanel

        _flpn = New FlowLayoutPanel
        _flpn.Controls.Clear()
        _flpn.AutoScroll = True
        _flpn.Location = New Point(15, 353)
        _flpn.Size = New Size(579, 213)
        _flpn.Name = "flpnFoods"

        Con.SqLs = "Select * from Food"
        Con.UseDatabasetoread(Con.SqLs)
        Dim i As Integer

        _bta(50) = New Button()
        While Con.Reader.Read
            _bta(i) = New Windows.Forms.Button
            _bta(i).Size = New Size(166, 55)
            _bta(i).Text = Con.Reader.Item(1)

            _flpn.Controls.AddRange({_bta(i)})

            AddHandler _bta(i).Click, AddressOf FoodbuttonClick
            i = i + 1
        End While
        
        Con.CloseConnection()
        Return _flpn
    End Function

    Public Sub HotbuttonClick(ByVal sender As Object, ByVal e As EventArgs)

        _bt = New Button()
        _bt.Name = sender.ToString.Remove(0, 35)
        Con.SqLs = "Select * from HotDrink Where Name='" & _bt.Name & "'"
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read
            Name = Con.Reader.Item(1)
            Price = Con.Reader.Item(2)
        End While
        InsertPreOrder()
        
    End Sub

    Public Sub IcebuttonClick(ByVal sender As Object, ByVal e As EventArgs)


        _bt = New Button()
        _bt.Name = sender.ToString.Remove(0, 35)
        Con.SqLs = "Select * from IceDrink Where Name='" & _bt.Name & "'"
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read
            Name = Con.Reader.Item(1)
            Price = Con.Reader.Item(2)
        End While
        InsertPreOrder()
        
    End Sub

    Public Sub FrabbuttonClick(ByVal sender As Object, ByVal e As EventArgs)


        _bt = New Button()
        _bt.Name = sender.ToString.Remove(0, 35)
        Con.SqLs = "Select * from FrabDrink Where Name='" & _bt.Name & "'"
            Con.UseDatabasetoread(Con.SqLs)
            While Con.Reader.Read
                Name = Con.Reader.Item(1)
                Price = Con.Reader.Item(2)
            End While
        InsertPreOrder()

    End Sub

    Public Sub FoodbuttonClick(ByVal sender As Object, ByVal e As EventArgs)


        _bt = New Button()
        _bt.Name = sender.ToString.Remove(0, 35)
        Con.SqLs = "Select * from Food Where Name='" & _bt.Name & "'"
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read
            Name = Con.Reader.Item(1)
            Price = Con.Reader.Item(2)
        End While
        InsertPreOrder()
        
    End Sub

    Public Sub InsertPreOrder()

        Con.SqLs = "Select * from PreOrder "
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read.ToString
            Drinkname = Con.Reader.Item(0)
            TableNumber = Con.Reader.Item(4)
            If Drinkname = TableNumber Then
                Try
                    Quantity = Con.Reader.Item(1) + 1
                    Con.SqLs = "Insert into PreOrder values('" & Name & "','" & Quantity & "'," & Price & "," & Price * Quantity & "," & TableNumber & ")"
                    Con.UseDatabase(Con.SqLs)
                Catch ex As Exception
                End Try
            ElseIf Drinkname = Name Then
                Quantity = Con.Reader.Item(1) + 1
                Con.SqLs = "Update PreOrder Set Quantity=" & Quantity & ",GrandTotal=" & Price * Quantity & " Where DrinkName='" & Name & "' and Table=" & TableNumber & ""
                Con.UseDatabase(Con.SqLs)
                Exit While
            End If
        End While

        Con.CloseConnection()
    End Sub

    Public Function ShowPreOrder() As Windows.Forms.DataGridView
        Dim bs As New BindingSource
        Dim dtgOrder As New Windows.Forms.DataGridView
        dtgOrder.Name = "dtgOrder"
        dtgOrder.Size = New Size(362, 567)
        dtgOrder.Location = New Point(21, 131)
        dtgOrder.ReadOnly = True
        Dim odpc As OrderProccessingClass
        Dim odpcs As New List(Of OrderProccessingClass)

        Con.SqLs = "Select * from PreOrder where Quantity<> 0"
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read.ToString
            odpc = New OrderProccessingClass(Con.Reader.Item(0), Con.Reader.Item(1), Con.Reader.Item(2), Con.Reader.Item(3))
            odpcs.Add(odpc)
            bs.DataSource = odpcs
        End While
        dtgOrder.DataSource = bs
        dtgOrder.Refresh()
        
        Con.CloseConnection()
        Return dtgOrder
    End Function

    Public Sub CancelPreOrder()

        Con.SqLs = "Delete * from PreOrder Where DrinkName <>'" & "Nothing" & "'"
        Con.UseDatabase(Con.SqLs)
        
        Con.CloseConnection()
    End Sub

    

    Public Sub PayNow(ByVal sellname As String, ByVal table As Integer, ByVal discount As String)
        Dim i As Integer = SelectMakItem_Orders()
        Dim j As Integer = SelectMakOrderNumber_Orders()
        Con.SqLs = "Select * from PreOrder where Quantity<> 0"
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read.ToString
            InsertInto_Orders(i, j, sellname, table, Con.Reader.Item(0), Con.Reader.Item(1), Con.Reader.Item(2), discount, True)
            i = i + 1
        End While
        UpdateTableToFree(table)

    End Sub

    Public Sub PayLatter(ByVal sellname As String, ByVal table As Integer, ByVal discount As String)
        Dim i As Integer = SelectMakItem_Orders()
        Dim j As Integer = SelectMakOrderNumber_Orders()
        Con.SqLs = "Select * from PreOrder where Quantity<> 0"
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read.ToString
            InsertInto_Orders(i, j, sellname, table, Con.Reader.Item(0), Con.Reader.Item(1), Con.Reader.Item(2), discount, False)
            i = i + 1
        End While
        UpdateTableToBusy(table)

    End Sub

    Public Sub UpdatePayLatter(ByVal ordernumber As Integer, ByVal sellname As String, ByVal table As Integer, ByVal discount As String)
        Dim dn(20) As String
        Dim qtt(20), i As Integer
        Dim p(20) As Double
        i = 0
        Dim j As Integer = SelectMakItem_Orders()

        Con.SqLs = "Select * from PreOrder where Quantity<> 0"
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read.ToString
            dn(i) = Con.Reader.Item(0)
            qtt(i) = Con.Reader.Item(1)
            p(i) = Con.Reader.Item(2)
            DeleteOrders_ByDrinkName_Quantity_Table_OrderNumber(dn(i), qtt(i), table, ordernumber)
            InsertInto_Orders(j, ordernumber, sellname, table, dn(i), qtt(i), p(i), discount, False)
            j = j + 1
            i = i + 1
        End While

        UpdateTableToBusy(table)
    End Sub

    Public Sub UpdatePayNow(ByVal ordernumber As Integer, ByVal sellname As String, ByVal table As Integer, ByVal discount As String)
        Dim dn(20) As String
        Dim qtt(20), i As Integer
        Dim p(20) As Double
        Dim j As Integer = SelectMakItem_Orders()
        i = 0

        Con.SqLs = "Select * from PreOrder where Quantity<> 0"
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read.ToString
            dn(i) = Con.Reader.Item(0)
            qtt(i) = Con.Reader.Item(1)
            p(i) = Con.Reader.Item(2)
            DeleteOrders_ByDrinkName_Quantity_Table_OrderNumber(dn(i), qtt(i), table, ordernumber)
            InsertInto_Orders(j, ordernumber, sellname, table, dn(i), qtt(i), p(i), discount, True)
            i = i + 1
            j = j + 1
        End While

        UpdateTableToFree(table)
    End Sub

    Public Sub DeleteOrders_ByDrinkName_Quantity_Table_OrderNumber(ByVal drinkname As String, ByVal quantity As Integer, ByVal table As Integer, ByVal ordernumber As Integer)

        Con.SqLs = "Delete * from Orders Where DrinkName ='" & drinkname & "' and Quantity<=" & quantity & " and Table=" & table & " and OrderNumber=" & ordernumber & " "
        Con.UseDatabase(Con.SqLs)

    End Sub

    Public Sub InsertInto_Orders(ByVal item As Integer, ByVal ordernumber As Integer, ByVal seller As String, ByVal table As Integer, ByVal drinkname As String, ByVal quantity As Integer, ByVal price As Double, ByVal discount As String, ByVal pay As Boolean)

        Con.SqLs = "Insert into Orders values(" & item & "," & ordernumber & ",'" & seller & "','" & table & "','" & drinkname & "'," & quantity & "," & price & "," & quantity * price & ",'" & discount & "'," & pay & ",'" & DateTime.Today.Date.ToString & "')"
        Con.UseDatabase(Con.SqLs)

    End Sub

    Public Function SelectMakItem_Orders() As Integer
        Dim j As Integer

        Con.SqLs = "Select MAX([Item]) from Orders "
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read
            j = Con.Reader.Item(0)
        End While
        j = j + 1

        Return j
    End Function

    Public Function SelectMakOrderNumber_Orders() As Integer
        Dim k As Integer

        Con.SqLs = "Select MAX([OrderNumber]) from Orders "
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read
            k = Con.Reader.Item(0)
        End While
        k = k + 1

        Return k
    End Function

    Public Sub UpdateTableToFree(ByVal table As Integer)

        Dim frees As Boolean = False
        Con.SqLs = "Update TablePetCafe Set Frees=" & frees & " Where NumberTable=" & table & ""
        Con.UseDatabase(Con.SqLs)
        
    End Sub

    Public Sub UpdateTableToBusy(ByVal table As Integer)

        Dim frees As Boolean = True
        Con.SqLs = "Update TablePetCafe Set Frees=" & frees & " Where NumberTable=" & table & ""
        Con.UseDatabase(Con.SqLs)
        
    End Sub

    'Public Sub PrintPayNow(ByVal ordernumber As Integer, ByVal gttdl As String, ByVal gttr As String, ByVal sellname As String, ByVal table As Integer, ByVal discount As String)
    '    Dim dct As String = ""
    '    Dim dcts As String

    '    Con.SqLs = "Select * from Orders where Table=" & table & " and OrderNumber=" & ordernumber & ""
    '    Con.UseDatabasetoread(Con.SqLs)
    '    While Con.Reader.Read.ToString
    '        dcts = Con.Reader.Item(4) + " " + Con.Reader.Item(5).ToString + " " + Con.Reader.Item(6).ToString + " " + Con.Reader.Item(7).ToString + " " + vbNewLine
    '        dct = dct + dcts
    '    End While
    '    InsertIntoPrintInvoice(SelectMaxItem_PrintIvoice, ordernumber, dct, gttdl, gttr, sellname, table, discount)
    '    DeleteOrders_ByTable_Ordernumber(table, ordernumber)
    'End Sub

    'Public Sub PrintPayLatter(ByVal ordernumber As Integer, ByVal gttdl As String, ByVal gttr As String, ByVal sellname As String, ByVal table As Integer, ByVal discount As String)
    '    Dim dct As String = ""
    '    Dim dcts As String

    '    Con.SqLs = "Select * from Orders where Table=" & table & " and OrderNumber='" & ordernumber & "'"
    '    Con.UseDatabasetoread(Con.SqLs)
    '    While Con.Reader.Read.ToString
    '        dcts = Con.Reader.Item(4) + " " + Con.Reader.Item(5).ToString + " " + Con.Reader.Item(6).ToString + " " + Con.Reader.Item(7).ToString + " " + vbNewLine
    '        dct = dct + dcts
    '    End While
    '    InsertIntoPrintInvoice(SelectMaxItem_PrintIvoice, ordernumber, dct, gttdl, gttr, sellname, table, discount)
    'End Sub

    Public Function SelectMaxItem_PrintIvoice() As Integer
        Dim j As Integer

        Con.SqLs = "Select MAX([Item]) from PrintInvoice "
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read
            j = Con.Reader.Item(0)
        End While
        j = j + 1
        
        Return j
    End Function

    Public Sub InsertIntoPrintInvoice(ByVal j As Integer, ByVal ordernumber As Integer, ByVal description As String, ByVal gttdl As Double, ByVal gttr As Double, ByVal sellname As String, ByVal table As Integer, ByVal discount As String)

        Con.SqLs = "Insert into PrintInvoice values(" & j & "," & ordernumber & ",'" & description & "'," & gttdl & "," & gttr & "," & table & ",'" & sellname & "'," & discount & ")"
        Con.UseDatabase(Con.SqLs)

    End Sub

    Public Sub DeleteOrders_ByTable_Ordernumber(ByVal table As Integer, ByVal ordernumber As Integer)

        Con.SqLs = "Delete * from Orders where Table=" & table & " and OrderNumber=" & ordernumber & ""
        Con.UseDatabase(Con.SqLs)

    End Sub

    Public Function CalculateChangeCashDolar(ByVal receivdolar As String) As String
        Dim rcd As Double
        Dim cgtt As Double = CalculateGrandTotal()

        rcd = receivdolar - cgtt

        Return rcd
    End Function

    Public Function CalculateChangeCashRiel(ByVal receivriel As String) As String
        Dim rcr As Double
        Dim cgtt As Double = CalculateGrandTotal() * 4100
            rcr = receivriel - cgtt
        Return rcr
    End Function

    Public Function CalculateGrandTotalWithDiscount(ByVal discount As Double) As String
        Dim dc, dcs As Double
        dcs = discount
       
            dc = (CalculateGrandTotal() * dcs) / 100

        Return dc
    End Function

    Public Function CalculateGrandTotal() As String
        Dim grandtotal As Double = 0

        Con.SqLs = "Select * from PreOrder where Quantity<> 0"
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read
            grandtotal = grandtotal + Con.Reader.Item(3)
        End While
        
        Return grandtotal
    End Function

End Class
