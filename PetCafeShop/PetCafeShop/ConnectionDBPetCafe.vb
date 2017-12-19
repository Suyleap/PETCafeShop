Imports System.Data.OleDb

Public Class ConnectionDbPetCafe

    Public Cnn As OleDbConnection
    Public Cmd As OleDbCommand
    Public Reader As OleDbDataReader
    Public Adp As OleDbDataAdapter
    Public Sql As String

    Public Property SqLs As String
        Get
            Return Sql
        End Get
        Set(value As String)
            Sql = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Function ConnectDatabase() As Object
<<<<<<< HEAD
        Dim LEAPSQL As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\cafe\PetCafeShop\PetCafeShop\PetCafeShopDatabase.accdb;"
        Dim DYSQL As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Work\PetCafeShop\PetCafeShop\PetCafeShop\PetCafeShopDatabase.accdb;"
=======
        Dim LEAPSQL As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Cafe\PetCafeShop\PetCafeShop\PetCafeShopDatabase.accdb;"
        Dim DYSQL As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Work\Cafe\PetCafeShop\PetCafeShop\PetCafeShopDatabase.accdb;"
>>>>>>> 0129b6b2f34487b534ee0a72620179399c38fba5
        Try
            cnn = New OleDbConnection(LEAPSQL)
            cnn.Open()
        Catch ex As Exception
            cnn = New OleDbConnection(DYSQL)
            cnn.Open()
        End Try
        Return cnn
    End Function

    Public Function UseDatabase(ByRef sql As String) As Object

        ConnectDatabase()
        SqLs = sql
        Cmd = New OleDbCommand(SqLs, Cnn)
        Cmd.ExecuteNonQuery() 
        Return Cmd
    End Function

    Public Function UseDatabasetoread(ByRef sql As String) As Object

        ConnectDatabase()
        SqLs = sql
        Cmd = New OleDbCommand(SqLs, Cnn)
        Reader = Cmd.ExecuteReader()
        
        Return Cmd
    End Function

    Public Function CloseConnection()
        cnn.Close()
        Return cnn
    End Function

End Class
