Public Class StaffClass

    Public st_ID As String
    Public st_Name As String
    Public st_Gender As String
    Public st_DOB As Date
    'Public st_Age As Byte
    Public st_Address As String
    Public st_Phone As String
    Public st_Email As String
    Public st_Salary As Double
    Public st_StartDateWork As Date
    Private con As New ConnectionDBPetCafe

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal name As String, ByVal gender As String, ByVal dob As Date, ByVal address As String, ByVal phone As String, ByVal email As String, ByVal salary As Double, ByVal sdw As Date)
        Me.st_ID = id
        Me.st_Name = name
        Me.st_Gender = gender
        Me.st_DOB = dob
        Me.st_Address = address
        Me.st_Phone = phone
        Me.st_Email = email
        Me.st_Salary = salary
        Me.st_StartDateWork = sdw
    End Sub

    Public Property StaffID As String
        Get
            Return Me.st_ID
        End Get
        Set(value As String)
            Me.st_ID = value
        End Set
    End Property
    Public Property StaffName As String
        Get
            Return Me.st_Name
        End Get
        Set(value As String)
            Me.st_Name = value
        End Set
    End Property
    Public Property StaffGender As String
        Get
            Return Me.st_Gender
        End Get
        Set(value As String)
            Me.st_Gender = value
        End Set
    End Property
    Public Property StaffDateOfBirth As Date
        Get
            Return Me.st_DOB
        End Get
        Set(value As Date)
            Me.st_DOB = value
        End Set
    End Property
    Public Property StaffAddress As String
        Get
            Return Me.st_Address
        End Get
        Set(value As String)
            Me.st_Address = value
        End Set
    End Property
    Public Property StaffPhone As String
        Get
            Return Me.st_Phone
        End Get
        Set(value As String)
            Me.st_Phone = value
        End Set
    End Property
    Public Property StaffEmail As String
        Get
            Return Me.st_Email
        End Get
        Set(value As String)
            Me.st_Email = value
        End Set
    End Property
    Public Property StaffSalary As Double
        Get
            Return Me.st_Salary
        End Get
        Set(value As Double)
            Me.st_Salary = value
        End Set
    End Property
    Public Property StaffStartDateWork As Date
        Get
            Return Me.st_StartDateWork
        End Get
        Set(value As Date)
            Me.st_StartDateWork = value
        End Set
    End Property
    Protected Function CountAge() As Byte
        Return (Convert.ToInt32((Today - st_DOB)) / 365)
    End Function
    Public Sub InsertStaff(ByVal id As String, ByVal name As String, ByVal gender As String, ByVal dob As Date, ByVal address As String, ByVal phone As String, ByVal email As String, ByVal salary As Double, ByVal sdw As Date)
        Try
            con.SQLs = "INSERT into Staff values('" & id & "','" & name & "','" & gender & "','" & dob.ToString() & "'," & CountAge() & ",'" & address & "','" & phone & "','" & email & "','" & salary & "','" & sdw.ToString() & "')"
            con.UseDatabase(con.SQLs)
        Catch ex As Exception
            MsgBox("Sorry We Can't")
        End Try
    End Sub
    Public Sub DeleteStaff(ByVal id As String)
        Try
            con.SQLs = "DELETE * From Staff Where StaffID=('" & id & "')"

        Catch ex As Exception

        End Try
    End Sub


End Class
