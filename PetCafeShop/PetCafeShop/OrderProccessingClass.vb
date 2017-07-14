Public Class OrderProccessingClass

    Private con As New ConnectionDBPetCafe
    Private dfc As New DrinkFoodClass
    Private Total As Double
    Private Quantity As Integer
    Private Drinkname As String = "Nothing"
    Private TableNumber As String = 0

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
            Return Me.Quantity
        End Get
        Set(value As Integer)
            Me.Quantity = value
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
        Get
            Return Me.Total
        End Get
        Set(value As Double)
            Me.Total = value
        End Set
    End Property

    Public Function ShowHotButton() As Windows.Forms.FlowLayoutPanel
        Dim flpn As New Windows.Forms.FlowLayoutPanel
        flpn.Controls.Clear()
        flpn.Name = "flpnHotDrink"
        flpn.AutoScroll = True
        flpn.Location = New Point(423, 153)
        flpn.Size = New Size(579, 213)
        Try
            con.SQLs = "Select * from HotDrink"
            con.UseDatabasetoread(con.SQLs)
            Dim i As Integer = 0
            Dim bt(50) As Windows.Forms.Button
            While con.reader.Read
                bt(i) = New Windows.Forms.Button
                bt(i).Size = New Size(166, 55)
                bt(i).Text = con.reader.Item(1)
                bt(i).Name = con.reader.Item(1)
                bt(i).Refresh()
                flpn.Controls.AddRange({bt(i)})
                flpn.Refresh()
                AddHandler bt(i).Click, AddressOf HotbuttonClick
                i = i + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.CloseConnection()
        Return flpn
    End Function

    Public Function ShowIceButton() As Windows.Forms.FlowLayoutPanel
        Dim flpn As New FlowLayoutPanel
        flpn.Controls.Clear()
        flpn.Name = "flpnIceDrink"
        flpn.AutoScroll = True
        flpn.Location = New Point(423, 153)
        flpn.Size = New Size(579, 213)
        Try
            con.SQLs = "Select * from IceDrink"
            con.UseDatabasetoread(con.SQLs)
            Dim i As Integer = 0
            Dim bt(50) As Windows.Forms.Button
            While con.reader.Read
                bt(i) = New Windows.Forms.Button
                bt(i).Size = New Size(166, 55)
                bt(i).Text = con.reader.Item(1)
                bt(i).Refresh()
                flpn.Controls.AddRange({bt(i)})
                flpn.Refresh()
                AddHandler bt(i).Click, AddressOf IcebuttonClick
                i = i + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.CloseConnection()
        Return flpn
    End Function

    Public Function ShowFrabButton() As Windows.Forms.FlowLayoutPanel
        Dim flpn As New FlowLayoutPanel
        flpn.Controls.Clear()
        flpn.Name = "flpnFrabDrink"
        flpn.AutoScroll = True
        flpn.Location = New Point(423, 153)
        flpn.Size = New Size(579, 213)
        Try
            con.SQLs = "Select * from FrabDrink"
            con.UseDatabasetoread(con.SQLs)
            Dim i As Integer = 0
            Dim bt(50) As Windows.Forms.Button
            While con.reader.Read
                bt(i) = New Windows.Forms.Button
                bt(i).Size = New Size(166, 55)
                bt(i).Text = con.reader.Item(1)
                bt(i).Refresh()
                flpn.Controls.AddRange({bt(i)})
                AddHandler bt(i).Click, AddressOf FrabbuttonClick
                i = i + 1
                flpn.Refresh()
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.CloseConnection()
        Return flpn
    End Function

    Public Function ShowFoodButton() As Windows.Forms.FlowLayoutPanel
        Dim flpn As New Windows.Forms.FlowLayoutPanel
        flpn.Controls.Clear()
        flpn.AutoScroll = True
        flpn.Location = New Point(422, 405)
        flpn.Size = New Size(579, 213)
        flpn.Name = "flpnFoods"
        Try
            con.SQLs = "Select * from Food"
            con.UseDatabasetoread(con.SQLs)
            Dim i As Integer = 0
            Dim bt(50) As Windows.Forms.Button
            While con.reader.Read
                bt(i) = New Windows.Forms.Button
                bt(i).Size = New Size(166, 55)
                bt(i).Text = con.reader.Item(1)
                bt(i).Refresh()
                flpn.Controls.AddRange({bt(i)})
                flpn.Refresh()
                AddHandler bt(i).Click, AddressOf FoodbuttonClick
                i = i + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.CloseConnection()
        Return flpn
    End Function

    Public Sub HotbuttonClick(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim bt As New Button
            bt.Name = sender.ToString.Remove(0, 35)
            con.SQLs = "Select * from HotDrink Where Name='" & bt.Name & "'"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read
                Me.Name = con.reader.Item(1)
                Me.Price = con.reader.Item(2)
            End While
            Me.InsertPreOrder()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub IcebuttonClick(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim bt As New Button
            bt.Name = sender.ToString.Remove(0, 35)
            con.SQLs = "Select * from IceDrink Where Name='" & bt.Name & "'"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read
                Me.Name = con.reader.Item(1)
                Me.Price = con.reader.Item(2)
            End While
            Me.InsertPreOrder()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub FrabbuttonClick(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim bt As New Button
            bt.Name = sender.ToString.Remove(0, 35)
            con.SQLs = "Select * from FrabDrink Where Name='" & bt.Name & "'"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read
                Me.Name = con.reader.Item(1)
                Me.Price = con.reader.Item(2)
            End While
            Me.InsertPreOrder()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub FoodbuttonClick(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim bt As New Button
            bt.Name = sender.ToString.Remove(0, 35)
            con.SQLs = "Select * from Food Where Name='" & bt.Name & "'"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read
                Me.Name = con.reader.Item(1)
                Me.Price = con.reader.Item(2)
            End While
            Me.InsertPreOrder()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub InsertPreOrder()
        Try
            Dim odf As New OrderForm
            odf.Controls.Add(ShowPreOrder())
            con.SQLs = "Select * from PreOrder "
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read
                Drinkname = con.reader.Item(0)
                TableNumber = con.reader.Item(4)
                If TableNumber = TableNumber And Drinkname = TableNumber Then
                    Quantity = con.reader.Item(1) + 1
                    con.SQLs = "Insert into PreOrder values('" & Me.Name & "','" & Quantity & "'," & Me.Price & "," & Me.Price * Quantity & "," & TableNumber & ")"
                    con.UseDatabase(con.SQLs)
                ElseIf TableNumber = TableNumber And Drinkname = Me.Name Then
                    Quantity = con.reader.Item(1) + 1
                    con.SQLs = "Update PreOrder Set Quantity=" & Quantity & ",GrandTotal=" & Me.Price * Quantity & " Where DrinkName='" & Me.Name & "' and Table=" & TableNumber & ""
                    con.UseDatabase(con.SQLs)
                    Exit While
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.CloseConnection()
    End Sub

    Public Function ShowPreOrder() As Windows.Forms.FlowLayoutPanel
        Dim bs As New BindingSource
        Dim flpnOrders As New Windows.Forms.FlowLayoutPanel
        flpnOrders.Name = "flpnOrder"
        flpnOrders.Size = New Size(362, 395)
        flpnOrders.Location = New Point(55, 213)
        flpnOrders.AutoScroll = True
        Dim dtgOrder As New Windows.Forms.DataGridView
        dtgOrder.Name = "dtgOrder"
        dtgOrder.Size = New Size(362, 567)
        dtgOrder.Location = New Point(47, 112)
        dtgOrder.ReadOnly = True
        Dim odpc As OrderProccessingClass
        Dim odpcs As New List(Of OrderProccessingClass)
        Try
            con.SQLs = "Select * from PreOrder where Quantity<> 0"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read
                odpc = New OrderProccessingClass(con.reader.Item(0), con.reader.Item(1), con.reader.Item(2), con.reader.Item(3))
                odpcs.Add(odpc)
                bs.DataSource = odpcs
            End While
            dtgOrder.DataSource = bs
            dtgOrder.Refresh()
            flpnOrders.Controls.Add(dtgOrder)
            flpnOrders.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.CloseConnection()
        Return flpnOrders
    End Function

    Public Sub CancelPreOrder()
        Try
            con.SQLs = "Delete * from PreOrder Where DrinkName <>'" & "Nothing" & "'"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.CloseConnection()
    End Sub

End Class
