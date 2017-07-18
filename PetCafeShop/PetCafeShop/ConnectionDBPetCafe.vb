Imports System.Data.OleDb

Public Class ConnectionDBPetCafe

    Public cnn As OleDbConnection
    Public cmd As OleDbCommand
    Public reader As OleDbDataReader
    Public adp As OleDbDataAdapter
    Public SQL As String

    Public Property SQLs As String
        Get
            Return Me.SQL
        End Get
        Set(value As String)
            Me.SQL = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Function ConnectDatabase() As Object
        Dim LEAPSQL As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\cafe\PetCafeShop\PetCafeShop\PetCafeShopDatabase.accdb;"
        Dim DYSQL As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Work\New Cafe\PetCafeShop\PetCafeShop\PetCafeShopDatabase.accdb;"
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
        Try
            ConnectDatabase()
            Me.SQLs = sql
            cmd = New OleDbCommand(Me.SQLs, cnn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return cmd
    End Function

    Public Function UseDatabasetoread(ByRef sql As String) As Object
        Try
            ConnectDatabase()
            Me.SQLs = sql
            cmd = New OleDbCommand(Me.SQLs, cnn)
            reader = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return cmd
    End Function

    Public Function CloseConnection()
        cnn.Close()
        Return cnn
    End Function

End Class
