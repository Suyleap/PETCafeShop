Public Class TablePetCafeClass

    Public TableId As String
    Public TableNumber As Integer
    Private _orderprocessing As OrderProccessingClass
    Private _odf As OrderForm
    Private _flpn As FlowLayoutPanel
    Public Con As New ConnectionDbPetCafe

    Public Sub New()

    End Sub

    Public Sub New(ByVal tableid As String, ByVal tablenumber As Integer)
        Me.TableID = tableid
        Me.TableNumber = tablenumber
    End Sub

    Public Property Seller As String

    Public Property Invoice As Integer

    Public Property TableIDs As String
        Get
            Return TableID
        End Get
        Set(value As String)
            TableID = value
        End Set
    End Property

    Public Property TableNumbers As Integer
        Get
            Return TableNumber
        End Get
        Set(value As Integer)
            TableNumber = value
        End Set
    End Property

    Public Sub Insert(ByVal tableid As String, ByVal tablenumber As Integer, ByVal free As Boolean)

        Con.SqLs = "Insert into TablePetCafe values('" & tableid & "','" & tablenumber & "'," & free & ")"
        Con.UseDatabase(Con.SqLs)
        Con.CloseConnection()
    End Sub

    Public Sub Deletetable(ByVal text As String)

        Con.SqLs = "Delete * from TablePetCafe Where NumberTable=" & Convert.ToInt16(text)
        Con.UseDatabase(Con.SqLs)
        Con.CloseConnection()
    End Sub

    Public Function ShowTableButton(sellername As String) As Windows.Forms.FlowLayoutPanel

        _flpn = New FlowLayoutPanel
        _flpn.Controls.Clear()
        _flpn.Name = "flpnTables"
        _flpn.AutoScroll = True
        _flpn.Location = New Point(6, 39)
        _flpn.Size = New Size(839, 516)

        Con.SqLs = "Select * from TablePetCafe"
        Con.UseDatabasetoread(Con.SqLs)
        Dim i As Integer
        Dim bt(50) As Windows.Forms.Button
        While Con.Reader.Read
            bt(i) = New Windows.Forms.Button
            bt(i).Size = New Size(190, 55)
            bt(i).Text = Con.Reader.Item(1)
            bt(i).Name = Con.Reader.Item(1)
            If Con.Reader.Item(2) = True Then
                bt(i).BackColor = Color.Red
            Else : bt(i).BackColor = Color.Green
            End If
            bt(i).Refresh()
            _flpn.Controls.AddRange({bt(i)})
            _flpn.Refresh()
            If bt(i).BackColor = Color.Green Then
                AddHandler bt(i).Click, AddressOf GointoOrderForm_GreenButton
            ElseIf bt(i).BackColor = Color.Red Then
                AddHandler bt(i).Click, AddressOf GointoOrderForm_RedButton
            End If
            i = i + 1
        End While
        Seller = sellername
        Con.CloseConnection()
        Return _flpn
    End Function

    Private Sub GointoOrderForm_RedButton(sender As Object, e As EventArgs)

        Dim tablenumberbutton As Button

        'Clear Preorder table
        _orderprocessing = New OrderProccessingClass()
        _orderprocessing.CancelPreOrder()

        'Call Order form 
        _odf = New OrderForm

        'get value from table number
        tablenumberbutton = sender
        tablenumberbutton.Name = sender.ToString.Remove(0, 35)
        tablenumberbutton.Refresh()

        Insert_into_Preorder(tablenumberbutton.Name)

        Con.SqLs = "Select * from Orders where Table=" & Convert.ToInt16(tablenumberbutton.Name) & " and Pay=" & False & ""
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read.ToString
            Seller = Con.Reader.Item(2)
            Invoice = Con.Reader.Item(1)
            Con.SqLs = "Insert into PreOrder values('" & Con.Reader.Item(4) & "'," & Convert.ToInt16(Con.Reader.Item(5)) & "," & Convert.ToDouble(Con.Reader.Item(6)) & "," & Convert.ToDouble(Con.Reader.Item(7)) & "," & tablenumberbutton.Name & ")"
            Con.UseDatabase(Con.SqLs)
        End While
        Con.CloseConnection()
        _odf.btnPlt.Visible = False
        _odf.btnPn.Visible = False
        _odf.txtTable.Text = tablenumberbutton.Name
        _odf.txtInvoice.Text = invoice
        _odf.txtSeller.Text = Seller
        _odf.ShowDialog()

    End Sub

    Private Sub GointoOrderForm_GreenButton(sender As Object, e As EventArgs)

        'Clear Preorder table
        _orderprocessing = New OrderProccessingClass
        _orderprocessing.CancelPreOrder()

        Dim tablenumberbutton As Button
        _odf = New OrderForm
        tablenumberbutton = sender
        tablenumberbutton.Name = sender.ToString.Remove(0, 35)
        tablenumberbutton.Refresh()
        Insert_into_Preorder(tablenumberbutton.Name)
        

        _odf.txtSeller.Text = Seller
        _odf.btnuplt.Visible = False
        _odf.btnupn.Visible = False
        _odf.txtTable.Text = tablenumberbutton.Name
        _odf.ShowDialog()

    End Sub

    Public Sub Insert_into_Preorder(ByVal drinkname As String)

        Con.SqLs = "Insert into PreOrder values('" & drinkname & "','" & 0 & "'," & 0 & "," & 0 & "," & drinkname & ")"
        Con.UseDatabase(Con.SqLs)
        Con.CloseConnection()
    End Sub

    Public Function AutoGenerateTableId() As String

        Dim stringId As String
        Dim intId As Integer
        Con.SqLs = "SELECT Last(TableID) FROM TablePetCafe"
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read()
            If Con.Reader.Item(0).ToString() = "" Then
                TableId = "TB1"
            Else
                stringId = Con.Reader.Item(0).ToString()
                intId = Convert.ToInt16(stringId.Substring(2))
                intId += 1
                TableId = String.Concat("TB", intId)
            End If
        End While
        Con.CloseConnection()
        Return TableId
    End Function

End Class
