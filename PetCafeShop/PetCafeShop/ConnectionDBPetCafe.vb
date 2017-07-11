Imports System.Data.OleDb

Public Class ConnectionDBPetCafe

    Public cnn As OleDbConnection
    Public cmd As OleDbCommand
    Public reader As OleDbDataReader
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
        SQL = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Shiwu\Documents\Visual Studio 2012\Projects\PetCafeShop\PetCafeShopDatabase.accdb;"
        cnn = New OleDbConnection(SQL)
        Try
            cnn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
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
