Public Class StaffForm
    Dim st As New StaffClass
    Private Sub StaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvStaff.DataSource = st.Show()
    End Sub

    Private Sub dgvStaff_SelectionChanged(sender As Object, e As EventArgs) Handles dgvStaff.SelectionChanged
        st.selectedStaffChange(Me, New EventArgs)

        txtID.Text = st.st_ID
        txtName.Text = st.st_Name
        cboGender.Text = st.st_Gender
        dtpDOB.Text = st.st_DOB
    End Sub
End Class