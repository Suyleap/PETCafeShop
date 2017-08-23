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
        St.st_ID = stid
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
            St.st_ID = value
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
        Try
            con.SQLs = "INSERT INTO Login_Acc values('" & id.ToString() & "','" & stid.ToString() & "','" & username & "','" & pw & "')"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub UpdateAcc(ByVal id As String, ByVal stid As String, ByVal username As String, ByVal pw As String)
        Try
            con.SQLs = "UPDATE Login_Acc SET [StaffID]='" & stid & "',[UserName]='" & username & "',[PassWord]='" & pw & "' WHERE [Acc_ID]='" & id & "'"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub DeleteAcc(ByVal stid As String)
        Try
            Con.SQLs = "DELETE * From Login_Acc where StaffID='" & stid & "'"
            Con.UseDatabase(Con.SQLs)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Show(ByVal stid As String)
        Try
            con.SQLs = "SELECT * From Login_Acc Where StaffID='" & stid & "'"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read
                acc_ID = Con.reader.Item(0)
                St.st_ID = Con.reader.Item(1)
                acc_UserName = Con.reader.Item(2)
                acc_Password = Con.reader.Item(3)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function CheckingAcc(ByVal stid As String) As String
        Try
            con.SQLs = "SELECT * From Login_Acc WHERE StaffID='" & stid & "'"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read()
                St.st_ID = Con.reader.Item(1)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return St.st_ID
    End Function
    Public Sub Login(ByVal username As String, ByVal password As String)
        Try
            con.SQLs = "SELECT * From Login_Acc Where UserName='" & username & "' And PassWord='" & password & "'"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read
                acc_ID = Con.reader.Item(0)
                St.st_ID = Con.reader.Item(1)
                acc_UserName = Con.reader.Item(2)
                acc_Password = Con.reader.Item(3)
            End While
        Catch ex As Exception
            MsgBox("Login Fail Please make sure you had enter correct both fields")
        End Try
    End Sub

    Public Function AutoGenerateAccId() As String
        Try
            Dim stringId As String
            Dim intId As Integer
            Con.SQLs = "Select Last(Acc_ID) from Login_Acc"
            Con.UseDatabasetoread(Con.SQLs)
            While Con.reader.Read()
                If Con.reader.Item(0).ToString() = "" Then
                    acc_ID = "ACC1"
                Else
                    StringID = Con.reader.Item(0).ToString()
                    intID = Convert.ToInt16(StringID.Substring(3))
                    intID += 1
                    acc_ID = String.Concat("ACC", intId)
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return acc_ID
    End Function

End Class
