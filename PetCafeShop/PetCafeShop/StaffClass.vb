Public Class StaffClass

    Public Stid As String
    Public StName As String
    Public StGender As String
    Public StDOb As Date
    Public StAge As Byte
    Public StAddress As String
    Public StPhone As String
    Public StEmail As String
    Public StPosition As String
    Public StSalary As Double
    Public StStartDateWork As Date
    Public Con As New ConnectionDbPetCafe

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal name As String, ByVal gender As String, ByVal dob As Date, ByVal age As Integer, ByVal address As String, ByVal phone As String, ByVal email As String, ByVal position As String, ByVal salary As Double, ByVal sdw As Date)
        Stid = id
        StName = name
        StGender = gender
        StDOb = dob
        StAge = age
        StAddress = address
        StPhone = phone
        StEmail = email
        StPosition = position
        StSalary = salary
        StStartDateWork = sdw
    End Sub

    Public Property StaffId As String
        Get
            Return Stid
        End Get
        Set(value As String)
            Stid = value
        End Set
    End Property

    Public Property StaffName As String
        Get
            Return StName
        End Get
        Set(value As String)
            StName = value
        End Set
    End Property

    Public Property StaffGender As String
        Get
            Return StGender
        End Get
        Set(value As String)
            StGender = value
        End Set
    End Property

    Public Property StaffDateOfBirth As Date
        Get
            Return StDOb
        End Get
        Set(value As Date)
            StDOb = value
        End Set
    End Property

    Public Property StaffAge As Byte
        Get
            Return StAge
        End Get
        Set(value As Byte)
            StAge = value
        End Set
    End Property

    Public Property StaffAddress As String
        Get
            Return StAddress
        End Get
        Set(value As String)
            StAddress = value
        End Set
    End Property

    Public Property StaffPhone As String
        Get
            Return StPhone
        End Get
        Set(value As String)
            StPhone = value
        End Set
    End Property

    Public Property StaffEmail As String
        Get
            Return StEmail
        End Get
        Set(value As String)
            StEmail = value
        End Set
    End Property

    Public Property StaffPosition As String
        Get
            Return StPosition
        End Get
        Set(value As String)
            StPosition = value
        End Set
    End Property

    Public Property StaffSalary As Double
        Get
            Return StSalary
        End Get
        Set(value As Double)
            StSalary = value
        End Set
    End Property

    Public Property StaffStartDateWork As Date
        Get
            Return StStartDateWork
        End Get
        Set(value As Date)
            StStartDateWork = value
        End Set
    End Property

    Public Sub InsertStaff(ByVal id As String, ByVal name As String, ByVal gender As String, ByVal dob As Date, ByVal age As Byte, ByVal address As String, ByVal phone As String, ByVal email As String, ByVal position As String, ByVal salary As Double, ByVal sdw As Date)

        Con.SqLs = "INSERT into Staff values('" & id & "','" & name & "','" & gender & "','" & dob.ToString() & "'," & age & ",'" & address & "','" & phone & "','" & email & "','" & position & "','" & salary & "','" & sdw.ToString() & "')"
        Con.UseDatabase(Con.SqLs)
        
    End Sub

    Public Sub UpdateStaff(ByVal id As String, ByVal name As String, ByVal gender As String, ByVal dob As Date, ByVal age As Byte, ByVal address As String, ByVal phone As String, ByVal email As String, ByVal position As String, ByVal salary As Double, ByVal sdw As Date)

        Con.SqLs = "UPDATE Staff set Name='" & name & "',Gender ='" & gender & "', BirthDay ='" & dob.ToString() & "',Age =" & age & ",Address ='" & address & "',Phone ='" & phone & "',Email ='" & email & "',Salary =" & salary & ",StartWorkDay ='" & sdw.ToString() & "' Where StaffID='" & id & "'"
        Con.UseDatabase(Con.SqLs)
        
    End Sub

    Public Sub DeleteStaff(ByVal id As String)

        Con.SqLs = "DELETE * From Staff Where StaffID=('" & id & "')"
        Con.UseDatabase(Con.SqLs)
        
    End Sub

    Public Function Show() As Object
        Dim bs As New BindingSource
        Dim stcl As StaffClass
        Dim stcls As New List(Of StaffClass)

        Con.SqLs = "Select * from Staff"
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read
            stcl = New StaffClass(Con.Reader.Item(0), Con.Reader.Item(1), Con.Reader.Item(2), Con.Reader.Item(3), Con.Reader.Item(4),
                                             Con.Reader.Item(5), Con.Reader.Item(6), Con.Reader.Item(7), Con.Reader.Item(8), Con.Reader.Item(9), Con.Reader.Item(10))
            stcls.Add(stcl)
            bs.DataSource = stcls
        End While
        
        Return bs
    End Function

    Public Sub SelectedStaffChange(ByVal sender As Object)

        Con.SqLs = "Select * from Staff Where StaffID='" & sender.ToString() & "'"
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read()
            Stid = Con.Reader.Item(0)
            StName = Con.Reader.Item(1)
            StGender = Con.Reader.Item(2)
            StDOb = Con.Reader.Item(3)
            StAge = Con.Reader.Item(4)
            StAddress = Con.Reader.Item(5)
            StPhone = Con.Reader.Item(6)
            StEmail = Con.Reader.Item(7)
            StPosition = Con.Reader.Item(8)
            StSalary = Con.Reader.Item(9)
            StStartDateWork = Con.Reader.Item(10)
        End While
        
    End Sub

    Public Function AutoGenerateStaffId() As String

        Dim stringId As String
        Dim intId As Integer
        Con.SqLs = "Select Last(StaffID) from Staff"
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read()
            If Con.Reader.Item(0).ToString() = "" Then
                Stid = "St1"
            Else
                stringId = Con.Reader.Item(0).ToString()
                intId = Convert.ToInt16(stringId.Substring(2))
                intId += 1
                Stid = String.Concat("St", intId)
            End If
        End While
        
        Return Stid
    End Function

    Public Function SearchAll(ByVal sender As Object) As Object
        Dim bs As New BindingSource

        Dim stcl As StaffClass
        Dim stcls As New List(Of StaffClass)
        Con.SqLs = "Select * From Staff where StaffID like'%" & sender.ToString() & "%' OR Name like '%" & sender.ToString() & "%' OR Gender like '%" &
                    sender.ToString() & "%' OR Age like '%" & sender.ToString() & "%' OR Address like '%" & sender.ToString() & "%' OR Phone like '%" &
                    sender.ToString() & "%' OR Email like '%" & sender.ToString() & "%' OR Salary like '%" & sender.ToString() & "%'"
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read
            stcl = New StaffClass(Con.Reader.Item(0), Con.Reader.Item(1), Con.Reader.Item(2), Con.Reader.Item(3), Con.Reader.Item(4),
                                             Con.Reader.Item(5), Con.Reader.Item(6), Con.Reader.Item(7), Con.Reader.Item(8), Con.Reader.Item(9), Con.Reader.Item(10))
            stcls.Add(stcl)
            bs.DataSource = stcls
        End While
        
        Return bs
    End Function

End Class
