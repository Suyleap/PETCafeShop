Public Class LoginForm

    Dim acc As New Account
    Dim rights As New RightClass

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
            rights.CheckRight(acc.acc_ID)
            rights.GotoForm()
            txtUserName.Text = ""
            txtPassword.Text = ""
        Catch ex As Exception
            MsgBox("Please correct your login")
        End Try
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserName.Text = ""
        txtPassword.Text = ""
        txtPassword.PasswordChar = "*"
        txtUserName.Focus()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub
End Class