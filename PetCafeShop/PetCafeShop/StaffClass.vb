﻿Public Class StaffClass

    Public st_ID As String
    Public st_Name As String
    Public st_Gender As String
    Public st_DOB As Date
    Public st_Age As Byte
    Public st_Address As String
    Public st_Phone As String
    Public st_Email As String
    Public st_Salary As Double
    Public st_StartDateWork As Date
    Private con As New ConnectionDBPetCafe

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal name As String, ByVal gender As String, ByVal dob As Date, ByVal age As Integer, ByVal address As String, ByVal phone As String, ByVal email As String, ByVal salary As Double, ByVal sdw As Date)
        Me.st_ID = id
        Me.st_Name = name
        Me.st_Gender = gender
        Me.st_DOB = dob
        Me.st_Age = age
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
        'Dim dtgStaff As New Windows.Forms.DataGridView
        'dtgStaff.Name = "dtgStaff"
        'dtgStaff.Size = New Size(362, 567)
        'dtgStaff.Location = New Point(47, 112)
        'dtgStaff.ReadOnly = True
        Dim stcl As StaffClass
        Dim stcls As New List(Of StaffClass)
        Try
            con.SQLs = "Select * from Staff"
            con.UseDatabasetoread(con.SQLs)
            While con.reader.Read
                stcl = New StaffClass(con.reader.Item(0), con.reader.Item(1), con.reader.Item(2), con.reader.Item(3), con.reader.Item(4),
                                                 con.reader.Item(5), con.reader.Item(6), con.reader.Item(7), con.reader.Item(8), con.reader.Item(9))
                stcls.Add(stcl)
                bs.DataSource = stcls
            End While
            'dtgStaff.DataSource = bs
            'dtgStaff.Refresh()
            Return bs
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.CloseConnection()
        'Return dtgStaff
    End Function
    ' Public Event DataModified(sender As Object, e As EventArgs)
    Public Sub selectedStaffChange(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim dgvSt As New DataGridView
            dgvSt.Name = sender.ToString.Remove(0, 35)
            con.SQLs = "Select * from Staff Where Name='" & dgvSt.Name & "'"
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
                Me.st_Salary = con.reader.Item(8)
                Me.st_StartDateWork = con.reader.Item(9)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub InsertToTextBox()
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class
