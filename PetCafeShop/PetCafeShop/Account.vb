Public Class Account

    Public acc_ID As String
    Public acc_UserName As String
    Public acc_Password As String
    Dim st As New StaffClass
    Dim con As New ConnectionDBPetCafe

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal stid As String, ByVal username As String, ByVal pw As String)
        Me.acc_ID = id
        Me.st.st_ID = stid
        Me.acc_UserName = username
        Me.acc_Password = pw
    End Sub

    Public Property AccID() As String
        Get
            Return Me.acc_ID
        End Get
        Set(value As String)
            Me.acc_ID = value
        End Set
    End Property

    Public WriteOnly Property AccStaffID() As String
        Set(value As String)
            Me.st.st_ID = value
        End Set
    End Property

    Public Property AccUserName() As String
        Get
            Return Me.acc_UserName
        End Get
        Set(value As String)
            Me.acc_UserName = value
        End Set
    End Property

    Public Property AccPassword() As String
        Get
            Return Me.acc_Password
        End Get
        Set(value As String)
            Me.acc_Password = value
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

    Public Sub DeleteAcc(ByVal id As String, ByVal stid As String)
        Try
            con.SQLs = "DELETE * From Login_Acc where Acc_ID='" & id & "' AND StaffID='" & stid & "'"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Show(ByVal stid As String)
        Try
            con.SQLs = "SELECT * From Login_Acc Where StaffID='" & stid & "'"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read
                Me.acc_ID = con.reader.Item(0)
                Me.st.st_ID = con.reader.Item(1)
                Me.acc_UserName = con.reader.Item(2)
                Me.acc_Password = con.reader.Item(3)
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
                Me.st.st_ID = con.reader.Item(1)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Me.st.st_ID
    End Function

    Public Function AutoGenerateAccID() As String
        Try
            Dim StringID As String
            Dim intID As Integer
            con.SQLs = "Select Last(Acc_ID) from Login_Acc"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read()
                If con.reader.Item(0).ToString() = "" Then
                    Me.acc_ID = "Acc1"
                Else
                    StringID = con.reader.Item(0).ToString()
                    intID = Convert.ToInt16(StringID.Substring(2))
                    intID += 1
                    Me.acc_ID = String.Concat("Acc", intID)
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return acc_ID
    End Function
End Class
