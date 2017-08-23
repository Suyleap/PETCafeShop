Public Class Background

    Public Login As New LoginForm

    Private Sub Background_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Location = New Point(0, 0)
        Size = SystemInformation.PrimaryMonitorSize
        login.ShowDialog()
        login.TopMost = True
        login.Activate()
        Refresh()
    End Sub

End Class