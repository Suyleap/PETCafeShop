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

    Public Sub Insert(ByVal tableid As String, ByVal tablenumber As Integer, ByVal free As Boolean)
        Try
            con.SQLs = "Insert into TablePetCafe values('" & tableid & "','" & tablenumber & "'," & free & ")"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox(ex.Message)
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

    Private Function AutoIDInvoice() As String
        Dim id As Long
        Try
            con.SQLs = "Select * from Orders"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read
                id = con.reader.Item(1)
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
        con.SQLs = "Insert into PreOrder values('" & tablenumber.Name & "','" & 0 & "'," & 0 & "," & 0 & "," & tablenumber.Name & ",'" & "hello" & "')"
        con.UseDatabase(con.SQLs)
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
