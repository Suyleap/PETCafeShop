Public Class RightClass

    Public RightId As String
    Public RightStaffFrom As Boolean
    Public RightSellForm As Boolean
    Public RightRightForm As Boolean
    Public Acc As New Account
    Public Con As New ConnectionDbPetCafe

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal accid As String, ByVal username As String, ByVal stform As Boolean, ByVal sellform As Boolean, ByVal right As Boolean)
        RightId = id
        Acc.acc_ID = accid
        Acc.acc_UserName = username
        RightStaffFrom = stform
        RightSellForm = sellform
        RightRightForm = right
    End Sub

    Public Property Id() As String
        Get
            Return RightId
        End Get
        Set(value As String)
            RightId = value
        End Set
    End Property

    Public ReadOnly Property Name() As String
        Get
            Return Acc.acc_UserName
        End Get
    End Property

    Public Property StaffForm() As Boolean
        Get
            Return RightStaffFrom
        End Get
        Set(value As Boolean)
            RightStaffFrom = value
        End Set
    End Property

    Public Property SellForm() As Boolean
        Get
            Return RightSellForm
        End Get
        Set(value As Boolean)
            RightSellForm = value
        End Set
    End Property

    Public Property RightForm() As Boolean
        Get
            Return RightRightForm
        End Get
        Set(value As Boolean)
            RightRightForm = value
        End Set
    End Property

    Public Sub InsertRight(ByVal text As String, ByVal accid As String, ByVal username As String, ByVal stform As Boolean, ByVal sellforms As Boolean, ByVal right As Boolean)

        Con.SqLs = "INSERT INTO Rightss values('" & text & "','" & accid & "','" & username & "'," & stform & "," & sellforms & "," & right & ")"
        Con.UseDatabase(Con.SqLs)
        Con.CloseConnection()
    End Sub

    Public Sub DeleteRight(ByVal text As String)

        Con.SqLs = "DELETE * From Rightss where Acc_ID='" & text & "'"
        Con.UseDatabase(Con.SqLs)
        Con.CloseConnection()
    End Sub

    Public Sub UpdateRight(ByVal text As String, ByVal stform As Boolean, ByVal sellforms As Boolean, ByVal right As Boolean)

        Con.SqLs = "UPDATE Rightss Set [StaffForm]=" & stform & ", [SellForm]= " & sellforms & ", [RightForm] = " & right & " where Right_ID='" & text & "'"
        Con.UseDatabase(Con.SqLs)
        Con.CloseConnection()
    End Sub

    Public Function Show() As Object
        Dim bs As New BindingSource
        Dim right As RightClass
        Dim rights As New List(Of RightClass)

        Con.SqLs = "Select * from Rightss"
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read
            right = New RightClass(Con.Reader.Item(0), Con.Reader.Item(1), Con.Reader.Item(2), Con.Reader.Item(3), Con.Reader.Item(4), Con.Reader.Item(5))
            rights.Add(right)
            bs.DataSource = right
        End While
        Con.CloseConnection()
        Return bs
    End Function

    Public Sub SelectedRightChange(ByVal sender As Object)

        Con.SqLs = "Select * from Rightss Where Right_ID='" & sender & "'"
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read()
            RightId = Con.Reader.Item(0)
            Acc.acc_ID = Con.Reader.Item(1)
            Acc.acc_UserName = Con.Reader.Item(2)
            RightStaffFrom = Con.Reader.Item(3)
            RightSellForm = Con.Reader.Item(4)
            RightRightForm = Con.Reader.Item(5)
        End While
        Con.CloseConnection()
    End Sub

    Public Sub CheckRight(ByVal accid As String)

        Con.SqLs = "Select * from Rightss Where Acc_ID='" & accid & "'"
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read()
            RightId = Con.Reader.Item(0)
            Acc.acc_ID = Con.Reader.Item(1)
            Acc.acc_UserName = Con.Reader.Item(2)
            RightStaffFrom = Con.Reader.Item(3)
            RightSellForm = Con.Reader.Item(4)
            RightRightForm = Con.Reader.Item(5)
        End While
        Con.CloseConnection()
    End Sub

    Public Sub GotoForm()
        Dim ch As New Choose
        If RightRightForm = True And RightSellForm = True And RightStaffFrom = True Then
            ch.ShowDialog()
        ElseIf RightRightForm = False And RightStaffFrom = True And RightSellForm = True Then
            ch.btnRight.Enabled = False
            ch.ShowDialog()
        ElseIf RightRightForm = False And RightStaffFrom = True And RightSellForm = False Then
            ch.btnRight.Enabled = False
            ch.btnSell.Enabled = False
            ch.ShowDialog()
        ElseIf RightRightForm = True And RightStaffFrom = True And RightSellForm = False Then
            ch.btnSell.Enabled = False
            ch.ShowDialog()
        ElseIf RightRightForm = False And RightStaffFrom = False And RightSellForm = True Then
            Dim tb As New TableForm
            tb.txtStaffId.Text = Acc.AccUserName
            tb.ShowDialog()
        Else
            MsgBox("Please Input correct login")
        End If
    End Sub

    Public Function AutoGenerateRightId() As String

        Dim stringId As String
        Dim intId As Integer
        Con.SqLs = "SELECT Last(Right_ID) FROM Rightss"
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read()
            If Con.Reader.Item(0).ToString() = "" Then
                RightId = "RIGHT1"
            Else
                stringId = Con.Reader.Item(0).ToString()
                intId = Convert.ToInt16(stringId.Substring(5))
                intId += 1
                RightId = String.Concat("RIGHT", intId)
            End If
        End While
        Con.CloseConnection()
        Return RightId
    End Function

    Public Function SearchAll(ByVal sender As Object)
        Dim bs As New BindingSource

        Dim ri As RightClass
        Dim lri As New List(Of RightClass)
        Con.SqLs = "Select * from Rightss where Right_ID like '%" & sender & "%' OR Acc_ID like '%" & sender & "%' OR Acc_UserName like'%" & sender & "%'"
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read
            ri = New RightClass(Con.Reader.Item(0), Con.Reader.Item(1), Con.Reader.Item(2), Con.Reader.Item(3), Con.Reader.Item(4), Con.Reader.Item(5))
            lri.Add(ri)
            bs.DataSource = lri
        End While
        Con.CloseConnection()
        Return bs
    End Function

End Class
