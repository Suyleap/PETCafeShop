Public Class TablePetCafeClass

    Public TableId As String
    Public TableNumber As Integer
    Public Con As New ConnectionDbPetCafe

    Public Sub New()

    End Sub

    Public Sub New(ByVal tableid As String, ByVal tablenumber As Integer)
        Me.TableID = tableid
        Me.TableNumber = tablenumber
    End Sub

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
        Try
            con.SQLs = "Insert into TablePetCafe values('" & tableid & "','" & tablenumber & "'," & free & ")"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Deletetable(ByVal tablenumber As String)
        Try
            Con.SQLs = "Delete * from TablePetCafe Where NumberTable=" & Convert.ToInt16(tablenumber)
            Con.UseDatabase(Con.SQLs)
        Catch ex As Exception
            MsgBox("Sorry we can't")
        End Try
    End Sub

    Public Function ShowTableButton() As Windows.Forms.FlowLayoutPanel
        Dim flpn As New Windows.Forms.FlowLayoutPanel
        flpn.Controls.Clear()
        flpn.Name = "flpnTables"
        flpn.AutoScroll = True
        flpn.Location = New Point(6, 39)
        flpn.Size = New Size(839, 516)
        Try
            con.SQLs = "Select * from TablePetCafe"
            con.UseDatabasetoread(con.SQLs)
            Dim i As Integer = 0
            Dim bt(50) As Windows.Forms.Button
            While con.reader.Read
                bt(i) = New Windows.Forms.Button
                bt(i).Size = New Size(190, 55)
                bt(i).Text = con.reader.Item(1)
                bt(i).Name = con.reader.Item(1)
                If con.reader.Item(2) = True Then
                    bt(i).BackColor = Color.Red
                Else : bt(i).BackColor = Color.Green
                End If
                bt(i).Refresh()
                flpn.Controls.AddRange({bt(i)})
                flpn.Refresh()
                If bt(i).BackColor = Color.Green Then
                    AddHandler bt(i).Click, AddressOf GointoOrderForm_GreenButton
                ElseIf bt(i).BackColor = Color.Red Then
                    AddHandler bt(i).Click, AddressOf GointoOrderForm_RedButton
                End If
                i = i + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.CloseConnection()
        Return flpn
    End Function

    Private Function AutoIdInvoice() As String
        Dim id As String
        Try
            Con.SQLs = "SELECT * FROM Orders"
            Con.UseDatabasetoread(Con.SQLs)
            While Con.reader.Read
                id = Con.reader.Item(1).ToString
                id = id + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return id
    End Function

    Private Sub GointoOrderForm_RedButton(sender As Object, e As EventArgs)
        Dim tablenumber As New Button
        Dim odf As New OrderForm
        Dim seller As String
        Dim bs As New BindingSource
        Dim invoice As Integer
        tablenumber = sender
        tablenumber.Name = sender.ToString.Remove(0, 35)
        tablenumber.Refresh()
        Insert_into_Preorder(tablenumber.Name)
        Try
            con.SQLs = "Select * from Orders where Table=" & Convert.ToInt16(tablenumber.Name) & " and Pay=" & False & ""
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read.ToString
                seller = con.reader.Item(2)
                invoice = con.reader.Item(1)
                bs.DataSource = seller
                con.SQLs = "Insert into PreOrder values('" & con.reader.Item(4) & "'," & Convert.ToInt16(con.reader.Item(5)) & "," & Convert.ToDouble(con.reader.Item(6)) & "," & Convert.ToDouble(con.reader.Item(7)) & "," & tablenumber.Name & ",'" & con.reader.Item(2) & "')"
                con.UseDatabase(con.SQLs)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        seller = bs.DataSource
        odf.Show()
        odf.btnPlt.Visible = False
        odf.btnPn.Visible = False
        odf.txtTable.Text = tablenumber.Name
        odf.txtInvoice.Text = invoice
        odf.txtSeller.Text = seller
        odf.Refresh()
    End Sub

    Private Sub GointoOrderForm_GreenButton(sender As Object, e As EventArgs)
        Dim tablenumber As New Button
        Dim odf As New OrderForm
        tablenumber = sender
        tablenumber.Name = sender.ToString.Remove(0, 35)
        tablenumber.Refresh()
        Insert_into_Preorder(tablenumber.Name)
        odf.Show()
        odf.btnuplt.Visible = False
        odf.btnupn.Visible = False
        odf.txtTable.Text = tablenumber.Name
        odf.txtSeller.Text = "hello"
        odf.txtInvoice.Text = AutoIDInvoice()
        odf.Refresh()
    End Sub

    Public Sub Insert_into_Preorder(ByVal drinkname As String)
        Try
            con.SQLs = "Insert into PreOrder values('" & drinkname & "','" & 0 & "'," & 0 & "," & 0 & "," & drinkname & ",'" & "hello" & "')"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function AutoGenerateTableId() As String
        Try
            Dim stringId As String
            Dim intId As Integer
            Con.SQLs = "SELECT Last(TableID) FROM TablePetCafe"
            Con.UseDatabasetoread(Con.SQLs)
            While Con.reader.Read()
                If Con.reader.Item(0).ToString() = "" Then
                    TableID = "TB1"
                Else
                    StringID = Con.reader.Item(0).ToString()
                    intID = Convert.ToInt16(StringID.Substring(2))
                    intID += 1
                    TableID = String.Concat("TB", intID)
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return TableID
    End Function

End Class
