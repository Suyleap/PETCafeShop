Public Class LoginForm

    Dim acc As New Account
    Dim right As New RightClass

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Try
            Try
                acc.Login(txtUserName.Text, txtPassword.Text)
            Catch ex As Exception
                txtUserName.Text = ""
                txtPassword.Text = ""
                txtUserName.Focus()
            End Try
            right.CheckRight(acc.acc_ID)
            right.GotoForm()
        Catch ex As Exception
            MsgBox("Please correct your login")
        End Try
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserName.Text = ""
        txtPassword.Text = ""
        txtPassword.PasswordChar = "*"
        txtUserName.Focus()
    End Sub
End Class