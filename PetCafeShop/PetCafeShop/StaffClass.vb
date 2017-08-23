Public Class StaffClass

    Public st_id As String
    Public st_Name As String
    Public st_Gender As String
    Public st_DOB As Date
    Public st_Age As Byte
    Public st_Address As String
    Public st_Phone As String
    Public st_Email As String
    Public st_Position As String
    Public st_Salary As Double
    Public st_StartDateWork As Date
    Public Con As New ConnectionDbPetCafe

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal name As String, ByVal gender As String, ByVal dob As Date, ByVal age As Integer, ByVal address As String, ByVal phone As String, ByVal email As String, ByVal position As String, ByVal salary As Double, ByVal sdw As Date)
        st_ID = id
        st_Name = name
        st_Gender = gender
        st_DOB = dob
        st_Age = age
        st_Address = address
        st_Phone = phone
        st_Email = email
        st_Position = position
        st_Salary = salary
        st_StartDateWork = sdw
    End Sub

    Public Property StaffId As String
        Get
            Return st_ID
        End Get
        Set(value As String)
            st_ID = value
        End Set
    End Property

    Public Property StaffName As String
        Get
            Return st_Name
        End Get
        Set(value As String)
            st_Name = value
        End Set
    End Property

    Public Property StaffGender As String
        Get
            Return st_Gender
        End Get
        Set(value As String)
            st_Gender = value
        End Set
    End Property

    Public Property StaffDateOfBirth As Date
        Get
            Return st_DOB
        End Get
        Set(value As Date)
            st_DOB = value
        End Set
    End Property

    Public Property StaffAge As Byte
        Get
            Return st_Age
        End Get
        Set(value As Byte)
            st_Age = value
        End Set
    End Property

    Public Property StaffAddress As String
        Get
            Return st_Address
        End Get
        Set(value As String)
            st_Address = value
        End Set
    End Property

    Public Property StaffPhone As String
        Get
            Return st_Phone
        End Get
        Set(value As String)
            st_Phone = value
        End Set
    End Property

    Public Property StaffEmail As String
        Get
            Return st_Email
        End Get
        Set(value As String)
            st_Email = value
        End Set
    End Property

    Public Property StaffPosition As String
        Get
            Return st_Position
        End Get
        Set(value As String)
            st_Position = value
        End Set
    End Property

    Public Property StaffSalary As Double
        Get
            Return st_Salary
        End Get
        Set(value As Double)
            st_Salary = value
        End Set
    End Property

    Public Property StaffStartDateWork As Date
        Get
            Return st_StartDateWork
        End Get
        Set(value As Date)
            st_StartDateWork = value
        End Set
    End Property

    Public Sub InsertStaff(ByVal id As String, ByVal name As String, ByVal gender As String, ByVal dob As Date, ByVal age As Byte, ByVal address As String, ByVal phone As String, ByVal email As String, ByVal position As String, ByVal salary As Double, ByVal sdw As Date)
        Try
            con.SQLs = "INSERT into Staff values('" & id & "','" & name & "','" & gender & "','" & dob.ToString() & "'," & age & ",'" & address & "','" & phone & "','" & email & "','" & position & "','" & salary & "','" & sdw.ToString() & "')"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub UpdateStaff(ByVal id As String, ByVal name As String, ByVal gender As String, ByVal dob As Date, ByVal age As Byte, ByVal address As String, ByVal phone As String, ByVal email As String, ByVal position As String, ByVal salary As Double, ByVal sdw As Date)
        Try
            con.SQLs = "UPDATE Staff set Name='" & name & "',Gender ='" & gender & "', BirthDay ='" & dob.ToString() & "',Age =" & age & ",Address ='" & address & "',Phone ='" & phone & "',Email ='" & email & "',Salary =" & salary & ",StartWorkDay ='" & sdw.ToString() & "' Where StaffID='" & id & "'"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub DeleteStaff(ByVal id As String)
        Try
            con.SQLs = "DELETE * From Staff Where StaffID=('" & id & "')"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function Show() As Object
        Dim bs As New BindingSource
        Dim stcl As StaffClass
        Dim stcls As New List(Of StaffClass)
        Try
            con.SQLs = "Select * from Staff"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read
                stcl = New StaffClass(con.reader.Item(0), con.reader.Item(1), con.reader.Item(2), con.reader.Item(3), con.reader.Item(4),
                                                 con.reader.Item(5), con.reader.Item(6), con.reader.Item(7), con.reader.Item(8), con.reader.Item(9), con.reader.Item(10))
                stcls.Add(stcl)
                bs.DataSource = stcls
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return bs
    End Function

    Public Sub SelectedStaffChange(ByVal sender As Object)
        Try
            Con.SQLs = "Select * from Staff Where StaffID='" & sender.ToString() & "'"
            Con.UseDatabasetoread(Con.SQLs)
            While Con.reader.Read()
                st_ID = Con.reader.Item(0)
                st_Name = Con.reader.Item(1)
                st_Gender = Con.reader.Item(2)
                st_DOB = Con.reader.Item(3)
                st_Age = Con.reader.Item(4)
                st_Address = Con.reader.Item(5)
                st_Phone = Con.reader.Item(6)
                st_Email = Con.reader.Item(7)
                st_Position = Con.reader.Item(8)
                st_Salary = Con.reader.Item(9)
                st_StartDateWork = Con.reader.Item(10)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function AutoGenerateStaffId() As String
        Try
            Dim stringId As String
            Dim intId As Integer
            Con.SQLs = "Select Last(StaffID) from Staff"
            Con.UseDatabasetoread(Con.SQLs)
            While Con.reader.Read()
                If Con.reader.Item(0).ToString() = "" Then
                    st_ID = "St1"
                Else
                    StringID = Con.reader.Item(0).ToString()
                    intID = Convert.ToInt16(StringID.Substring(2))
                    intID += 1
                    st_ID = String.Concat("St", intID)
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return st_ID
    End Function

    Public Function SearchAll(ByVal sender As Object) As Object
        Dim bs As New BindingSource
        Try
            Dim stcl As StaffClass
            Dim stcls As New List(Of StaffClass)
            con.SQLs = "Select * From Staff where StaffID like'%" & sender.ToString() & "%' OR Name like '%" & sender.ToString() & "%' OR Gender like '%" &
                        sender.ToString() & "%' OR Age like '%" & sender.ToString() & "%' OR Address like '%" & sender.ToString() & "%' OR Phone like '%" &
                        sender.ToString() & "%' OR Email like '%" & sender.ToString() & "%' OR Salary like '%" & sender.ToString() & "%'"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read
                stcl = New StaffClass(con.reader.Item(0), con.reader.Item(1), con.reader.Item(2), con.reader.Item(3), con.reader.Item(4),
                                                 con.reader.Item(5), con.reader.Item(6), con.reader.Item(7), con.reader.Item(8), con.reader.Item(9), con.reader.Item(10))
                stcls.Add(stcl)
                bs.DataSource = stcls
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return bs
    End Function

End Class
