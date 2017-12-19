Public Class Account

    Public acc_ID As String
    Public acc_UserName As String
    Public acc_Password As String
    Public St As New StaffClass
    Public Con As New ConnectionDBPetCafe

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal stid As String, ByVal username As String, ByVal pw As String)
        acc_ID = id
        St.Stid = stid
        acc_UserName = username
        acc_Password = pw
    End Sub

    Public Property AccId() As String
        Get
            Return acc_ID
        End Get
        Set(value As String)
            acc_ID = value
        End Set
    End Property

    Public WriteOnly Property AccStaffId() As String
        Set(value As String)
            St.Stid = value
        End Set
    End Property

    Public Property AccUserName() As String
        Get
            Return acc_UserName
        End Get
        Set(value As String)
            acc_UserName = value
        End Set
    End Property

    Public Property AccPassword() As String
        Get
            Return acc_Password
        End Get
        Set(value As String)
            acc_Password = value
        End Set
    End Property

    Public Sub InsertAcc(ByVal id As String, ByVal stid As String, ByVal username As String, ByVal pw As String)
        Con.SqLs = "INSERT INTO Login_Acc values('" & id.ToString() & "','" & stid.ToString() & "','" & username & "','" & pw & "')"
        Con.UseDatabase(Con.SqLs)
        Con.CloseConnection()
    End Sub

    Public Sub UpdateAcc(ByVal id As String, ByVal stid As String, ByVal username As String, ByVal pw As String)
        Con.SQLs = "UPDATE Login_Acc SET [StaffID]='" & stid & "',[UserName]='" & username & "',[PassWord]='" & pw & "' WHERE [Acc_ID]='" & id & "'"
        Con.UseDatabase(Con.SqLs)
        Con.CloseConnection()
    End Sub

    Public Sub DeleteAcc(ByVal stid As String)
            Con.SQLs = "DELETE * From Login_Acc where StaffID='" & stid & "'"
        Con.UseDatabase(Con.SqLs)
        Con.CloseConnection()
    End Sub

    Public Sub Show(ByVal stid As String)

        Con.SQLs = "SELECT * From Login_Acc Where StaffID='" & stid & "'"
        Con.UseDatabasetoread(Con.SQLs)
        While Con.reader.Read
            acc_ID = Con.reader.Item(0)
            St.Stid = Con.reader.Item(1)
            acc_UserName = Con.reader.Item(2)
            acc_Password = Con.reader.Item(3)
        End While
        Con.CloseConnection()
    End Sub

    Public Function CheckingAcc(ByVal stid As String) As String

        Con.SQLs = "SELECT * From Login_Acc WHERE StaffID='" & stid & "'"
        Con.UseDatabasetoread(Con.SQLs)
        While Con.reader.Read()
            St.Stid = Con.reader.Item(1)
        End While
        Con.CloseConnection()
        Return St.Stid
    End Function
    Public Sub Login(ByVal username As String, ByVal password As String)

        Con.SQLs = "SELECT * From Login_Acc Where UserName='" & username & "' And PassWord='" & password & "'"
        Con.UseDatabasetoread(Con.SQLs)
        While Con.reader.Read
            acc_ID = Con.reader.Item(0)
            St.Stid = Con.reader.Item(1)
            acc_UserName = Con.reader.Item(2)
            acc_Password = Con.reader.Item(3)
        End While
        Con.CloseConnection()
    End Sub

    Public Function AutoGenerateAccId() As String

        Dim stringId As String
        Dim intId As Integer
        Con.SQLs = "Select Last(Acc_ID) from Login_Acc"
        Con.UseDatabasetoread(Con.SQLs)
        While Con.reader.Read()
            If Con.reader.Item(0).ToString() = "" Then
                acc_ID = "ACC1"
            Else
                stringId = Con.reader.Item(0).ToString()
                intId = Convert.ToInt16(stringId.Substring(3))
                intId += 1
                acc_ID = String.Concat("ACC", intId)
            End If
        End While
        Con.CloseConnection()
        Return acc_ID
    End Function

End Class
