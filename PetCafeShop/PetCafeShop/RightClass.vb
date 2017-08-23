Public Class RightClass

    Public right_ID As String
    Public right_StaffFrom As Boolean
    Public right_SellForm As Boolean
    Public right_RightForm As Boolean
    Public Acc As New Account
    Public Con As New ConnectionDbPetCafe

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal accid As String, ByVal username As String, ByVal stform As Boolean, ByVal sellform As Boolean, ByVal right As Boolean)
        right_ID = id
        Acc.acc_ID = accid
        Acc.acc_UserName = username
        right_StaffFrom = stform
        right_SellForm = sellform
        right_RightForm = right
    End Sub

    Public Property ID() As String
        Get
            Return right_ID
        End Get
        Set(value As String)
            right_ID = value
        End Set
    End Property

    Public ReadOnly Property Name() As String
        Get
            Return Acc.acc_UserName
        End Get
    End Property

    Public Property StaffForm() As Boolean
        Get
            Return right_StaffFrom
        End Get
        Set(value As Boolean)
            right_StaffFrom = value
        End Set
    End Property

    Public Property SellForm() As Boolean
        Get
            Return right_SellForm
        End Get
        Set(value As Boolean)
            right_SellForm = value
        End Set
    End Property

    Public Property RightForm() As Boolean
        Get
            Return right_RightForm
        End Get
        Set(value As Boolean)
            right_RightForm = value
        End Set
    End Property

    Public Sub InsertRight(ByVal id As String, ByVal accid As String, ByVal username As String, ByVal stform As Boolean, ByVal sellform As Boolean, ByVal right As Boolean)
        Try
            con.SQLs = "INSERT INTO Rightss values('" & id & "','" & accid & "','" & username & "'," & stform & "," & sellform & "," & right & ")"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub DeleteRight(ByVal id As String)
        Try
            con.SQLs = "DELETE * From Rightss where Right_ID='" & id & "'"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub UpdateRight(ByVal id As String, ByVal stform As Boolean, ByVal sellform As Boolean, ByVal right As Boolean)
        Try
            con.SQLs = "UPDATE Rightss Set [StaffForm]=" & stform & ", [SellForm]= " & sellform & ", [RightForm] = " & right & " where Right_ID='" & id & "'"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function Show() As Object
        Dim bs As New BindingSource
        Dim right As RightClass
        Dim rights As New List(Of RightClass)
        Try
            con.SQLs = "Select * from Rightss"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read
                right = New RightClass(con.reader.Item(0), con.reader.Item(1), con.reader.Item(2), con.reader.Item(3), con.reader.Item(4), con.reader.Item(5))
                rights.Add(right)
                bs.DataSource = right
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return bs
    End Function

    Public Sub selectedRightChange(ByVal sender As Object)
        Try
            con.SQLs = "Select * from Rightss Where Right_ID='" & sender & "'"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read()
                right_ID = Con.reader.Item(0)
                Acc.acc_ID = Con.reader.Item(1)
                Acc.acc_UserName = Con.reader.Item(2)
                right_StaffFrom = Con.reader.Item(3)
                right_SellForm = Con.reader.Item(4)
                right_RightForm = Con.reader.Item(5)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub CheckRight(ByVal accid As String)
        Try
            con.SQLs = "Select * from Rightss Where Acc_ID='" & accid & "'"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read()
                right_ID = Con.reader.Item(0)
                Acc.acc_ID = Con.reader.Item(1)
                Acc.acc_UserName = Con.reader.Item(2)
                right_StaffFrom = Con.reader.Item(3)
                right_SellForm = Con.reader.Item(4)
                right_RightForm = Con.reader.Item(5)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GotoForm()
        Dim ch As New Choose
        If right_RightForm = True And right_SellForm = True And right_StaffFrom = True Then
            ch.Show()
        ElseIf right_RightForm = False And right_StaffFrom = True And right_SellForm = True Then
            ch.btnRight.Enabled = False
            ch.Show()
        ElseIf right_RightForm = False And right_StaffFrom = True And right_SellForm = False Then
            ch.btnRight.Enabled = False
            ch.btnSell.Enabled = False
            ch.Show()
        ElseIf right_RightForm = True And right_StaffFrom = True And right_SellForm = False Then
            ch.btnSell.Enabled = False
            ch.Show()
        ElseIf right_RightForm = False And right_StaffFrom = False And right_SellForm = True Then
            Dim tb As New TableForm
            tb.Show()
        Else
            MsgBox("Please Input correct login")
        End If
    End Sub

    Public Function autoGenerateRightID() As String
        Try
            Dim stringId As String
            Dim intId As Integer
            con.SQLs = "SELECT Last(Right_ID) FROM Rightss"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read()
                If con.reader.Item(0).ToString() = "" Then
                    right_ID = "RIGHT1"
                Else
                    StringID = con.reader.Item(0).ToString()
                    intID = Convert.ToInt16(StringID.Substring(5))
                    intID += 1
                    right_ID = String.Concat("RIGHT", intID)
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return right_ID
    End Function

    Public Function SearchAll(ByVal sender As Object)
        Dim bs As New BindingSource
        Try
            Dim ri As RightClass
            Dim lri As New List(Of RightClass)
            con.SQLs = "Select * from Rightss where Right_ID like '%" & sender & "%' OR Acc_ID like '%" & sender & "%' OR Acc_UserName like'%" & sender & "%'"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read
                ri = New RightClass(con.reader.Item(0), con.reader.Item(1), con.reader.Item(2), con.reader.Item(3), con.reader.Item(4), con.reader.Item(5))
                lri.Add(ri)
                bs.DataSource = lri
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return bs
    End Function

End Class
