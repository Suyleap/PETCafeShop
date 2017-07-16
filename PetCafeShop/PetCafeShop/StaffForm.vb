Public Class StaffForm
    Dim st As New StaffClass
    Private Sub StaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvStaff.DataSource = st.Show()
    End Sub
End Class