Public Class Choose

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        Dim st As New StaffForm
        st.ShowDialog()
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        Dim ri As New RightForm
        ri.ShowDialog()
    End Sub

    Private Sub btnSell_Click(sender As Object, e As EventArgs) Handles btnSell.Click
        Dim sell As New TableForm
        sell.txtStaffId.Text = "admin"
        sell.ShowDialog()
    End Sub

    Private Sub Choose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginForm.Close()
        FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Dim backupform As New BackUpForm
        backupform.ShowDialog()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click

    End Sub
End Class