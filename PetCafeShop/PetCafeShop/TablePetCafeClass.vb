Public Class TablePetCafeClass

    Public TableID As String
    Public TableNumber As Integer
    Private con As New ConnectionDBPetCafe

    Public Sub New()

    End Sub

    Public Sub New(ByVal tableid As String, ByVal tablenumber As Integer)
        Me.TableID = tableid
        Me.TableNumber = tablenumber
    End Sub

    Public Property TableIDs As String
        Get
            Return Me.TableID
        End Get
        Set(value As String)
            Me.TableID = value
        End Set
    End Property

    Public Property TableNumbers As Integer
        Get
            Return Me.TableNumber
        End Get
        Set(value As Integer)
            Me.TableNumber = value
        End Set
    End Property

    Public Sub Insert(ByVal tableid As String, ByVal tablenumber As Integer)
        Try
            con.SQLs = "Insert into TablePetCafe values('" & tableid & "','" & tablenumber & "')"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox("Sorry we can't")
        End Try
    End Sub

    Public Sub DeleteTABLE(ByVal tablenumber As String)
        Try
            con.SQLs = "Delete * from TablePetCafe Where NumberTable=" & Convert.ToInt16(tablenumber)
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox("Sorry we can't")
        End Try
    End Sub

    Public Sub UpdateTable(ByVal tableid As String, ByVal tablenumber As Integer)
        Try
            con.SQLs = "Update HotDrink Set NumberTable='" & tablenumber & "' Where TableID='" & tableid & "'"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox("Sorry we can't")
        End Try
    End Sub

    Public Function Showtable(ByVal showall As List(Of TablePetCafeClass)) As Object
        showall = New List(Of TablePetCafeClass)
        Try
            Dim tbpcc As TablePetCafeClass
            con.SQLs = "Select * from HotDrink"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read
                tbpcc = New TablePetCafeClass(con.reader.Item(0), con.reader.Item(1))
                showall.Add(tbpcc)
            End While
        Catch ex As Exception
            MsgBox("Sorry we Can't")
        End Try
        Return showall
    End Function

    Public Function ShowTableButton() As Windows.Forms.FlowLayoutPanel
        Dim flpn As New Windows.Forms.FlowLayoutPanel
        flpn.Controls.Clear()
        flpn.Name = "flpnTables"
        flpn.AutoScroll = True
        flpn.Location = New Point(246, 128)
        flpn.Size = New Size(806, 406)
        Try
            con.SQLs = "Select * from TablePetCafe"
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
                AddHandler bt(i).Click, AddressOf GointoOrderForm
                i = i + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.CloseConnection()
        Return flpn
    End Function

    Private Function AutoIDInvoice() As String
        Dim id As Long
        Try
            con.SQLs = "Select * from Orders"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read
                id = con.reader.Item(0)
                id = id + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return id
    End Function

    Private Sub GointoOrderForm(sender As Object, e As EventArgs)
        Dim tablenumber As New Button
        Dim odf As New OrderForm
        tablenumber = sender
        tablenumber.Name = sender.ToString.Remove(0, 35)
        tablenumber.Refresh()
        Try
            con.SQLs = "Insert into PreOrder values('" & tablenumber.Name & "','" & 0 & "'," & 0 & "," & 0 & "," & tablenumber.Name & ",'" & "hello" & "')"
            con.UseDatabase(con.SQLs)
            odf.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        odf.txtTable.Text = tablenumber.Name
        odf.txtSeller.Text = "hello"
        odf.txtInvoice.Text = AutoIDInvoice()
        odf.Refresh()
    End Sub
End Class
