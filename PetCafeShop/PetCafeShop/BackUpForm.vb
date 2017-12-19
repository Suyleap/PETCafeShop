Imports System.IO

Public Class BackUpForm

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Try
            Dim fdb As New FolderBrowserDialog
            If fdb.ShowDialog() = vbOK Then
                File.Copy("D:\cafe\PetCafeShop\PetCafeShop\PetCafeShopDatabase.accdb", fdb.SelectedPath & String.Format("\PetCafeShopDatabase.accdb"))
            End If
            MsgBox("Back Up has Done...")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Try
            Dim fdb As New FolderBrowserDialog
            If fdb.ShowDialog() = vbOK Then
                File.Delete("D:\cafe\PetCafeShop\PetCafeShop\PetCafeShopDatabase.accdb")
                File.Copy(fdb.SelectedPath & String.Format("\PetCafeShopDatabase.accdb"), "D:\cafe\PetCafeShop\PetCafeShop\PetCafeShopDatabase.accdb")
            End If
            MsgBox("Restor has Done...")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BackUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class