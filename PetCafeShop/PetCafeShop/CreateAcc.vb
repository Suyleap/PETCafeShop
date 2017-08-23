Public Class CreateAcc

    Public Acc As New Account()
    Public Stf As New StaffForm()
    Public Ri As New RightClass()

    Property GetId As String
    Property GetStaffId As String
    Property GetRightId As String

    Private Sub CreateAcc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        cmd()
        Refresh()
    End Sub

    Private Sub Cmd()
        Try
            txtConfirm.PasswordChar = ""
            txtPassword.PasswordChar = ""
            txtConfirm.MaxLength = 14
            txtPassword.MaxLength = 14
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Refresh()
    End Sub

    Private Sub Clear()
        txtConfirm.Text = ""
        txtPassword.Text = ""
        txtUserName.Text = ""
        Refresh()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If (txtConfirm.Text = txtPassword.Text) Then
            txtConfirm.Text = txtPassword.Text
            acc.InsertAcc(getID, getStaffID, txtUserName.Text, txtConfirm.Text)
            ri.InsertRight(getRightID, getID, txtUserName.Text, False, False, False)
            Close()
        Else
            MsgBox("Please Fill both Password")
            txtPassword.Text = ""
            txtConfirm.Text = ""
            txtPassword.Focus()
        End If
        Refresh()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
        Refresh()
    End Sub

End Class