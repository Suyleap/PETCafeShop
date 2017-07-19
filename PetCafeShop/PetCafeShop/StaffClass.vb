Public Class StaffClass

    Public st_ID As String
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
    Private con As New ConnectionDBPetCafe

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal name As String, ByVal gender As String, ByVal dob As Date, ByVal age As Integer, ByVal address As String, ByVal phone As String, ByVal email As String, ByVal position As String, ByVal salary As Double, ByVal sdw As Date)
        Me.st_ID = id
        Me.st_Name = name
        Me.st_Gender = gender
        Me.st_DOB = dob
        Me.st_Age = age
        Me.st_Address = address
        Me.st_Phone = phone
        Me.st_Email = email
        Me.st_Position = position
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
    Public Property StaffAge As Byte
        Get
            Return Me.st_Age
        End Get
        Set(value As Byte)
            Me.st_Age = value
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
    Public Property StaffPosition As String
        Get
            Return Me.st_Position
        End Get
        Set(value As String)
            Me.st_Position = value
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
            Return bs
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.CloseConnection()
        'Return dtgStaff
    End Function
    ' Public Event DataModified(sender As Object, e As EventArgs)
    Public Sub selectedStaffChange(ByVal sender As Object)
        Try
            'Dim dgvSt As New DataGridView

            con.SQLs = "Select * from Staff Where StaffID='" & sender.ToString() & "'"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read()
                Me.st_ID = con.reader.Item(0)
                Me.st_Name = con.reader.Item(1)
                Me.st_Gender = con.reader.Item(2)
                Me.st_DOB = con.reader.Item(3)
                Me.st_Age = con.reader.Item(4)
                Me.st_Address = con.reader.Item(5)
                Me.st_Phone = con.reader.Item(6)
                Me.st_Email = con.reader.Item(7)
                Me.st_Position = con.reader.Item(8)
                Me.st_Salary = con.reader.Item(9)
                Me.st_StartDateWork = con.reader.Item(10)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function autoGenerateStaffID() As String
        Try
            Dim StringID As String
            Dim intID As Integer
            con.SQLs = "Select Last(StaffID) from Staff"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read()
                If con.reader.Item(0).ToString() = "" Then
                    st_ID = "St1"
                Else
                    StringID = con.reader.Item(0).ToString()
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
        Try
            Dim bs As New BindingSource
            Dim stcl As New StaffClass
            Dim stcls As New List(Of StaffClass)
            con.SQLs = "Select * From Staff where StaffID like'%" & sender.ToString() & "%' OR Name like '%" & sender.ToString() & "%'"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read
                stcl = New StaffClass(con.reader.Item(0), con.reader.Item(1), con.reader.Item(2), con.reader.Item(3), con.reader.Item(4),
                                                 con.reader.Item(5), con.reader.Item(6), con.reader.Item(7), con.reader.Item(8), con.reader.Item(9), con.reader.Item(10))
                stcls.Add(stcl)
                bs.DataSource = stcls
            End While
            Return bs
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
End Class
