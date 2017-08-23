Public Class UpdateAccount

    Public Acc As New Account
    Public Ri As New RightClass
    Property getRightID As String
    Property getStaffID As String

    Private Sub CreateAcc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        acc.Show(getStaffID)
        txtUserName.Text = acc.acc_UserName
        txtConfirm.Text = acc.acc_Password
        txtPassword.Text = acc.acc_Password
        cmd()
        Refresh()
    End Sub

    Private Sub Cmd()
        Try
            txtConfirm.PasswordChar = "*"
            txtPassword.PasswordChar = "*"
            txtConfirm.MaxLength = 14
            txtPassword.MaxLength = 14
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Refresh()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If (txtConfirm.Text = txtPassword.Text) Then
            txtConfirm.Text = txtPassword.Text
            acc.UpdateAcc(acc.AccID, getStaffID, txtUserName.Text, txtConfirm.Text)
            ri.UpdateRight(getRightID, False, False, False)
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