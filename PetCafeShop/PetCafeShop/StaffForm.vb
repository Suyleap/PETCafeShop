Public Class StaffForm
    Dim st As New StaffClass
    Private Sub StaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvStaff.DataSource = st.Show()
        dgvStaff.ReadOnly = True
        Clear()
    End Sub

    Private Sub dgvStaff_SelectionChanged(sender As Object, e As EventArgs) Handles dgvStaff.SelectionChanged

        st.selectedStaffChange(dgvStaff.CurrentRow.Cells(0).Value.ToString())

        txtID.Text = st.st_ID
        txtName.Text = st.st_Name
        cboGender.Text = st.st_Gender
        dtpDOB.Text = st.st_DOB
        txtAge.Text = st.st_Age
        txtAddress.Text = st.st_Address
        txtPhone.Text = st.st_Phone
        txtEmail.Text = st.st_Email
        txtPosition.Text = st.st_Position
        txtSalary.Text = st.st_Salary
        dtpSWD.Text = st.st_StartDateWork
    End Sub
    Private Sub Clear()
        txtID.Text = ""
        txtName.Text = ""
        cboGender.Text = ""
        dtpDOB.Text = ""
        txtAge.Text = ""
        txtAddress.Text = ""
        txtPhone.Text = ""
        txtEmail.Text = ""
        txtPosition.Text = ""
        txtSalary.Text = ""
        dtpSWD.Text = ""
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        st.InsertStaff(txtID.Text, txtName.Text, cboGender.Text, Convert.ToDateTime(dtpDOB.Text), txtAddress.Text, txtPhone.Text, txtEmail.Text, txtPosition.Text, Convert.ToDouble(txtSalary.Text), Convert.ToDateTime(dtpSWD.Text))
        dgvStaff.DataSource = st.Show()
        Me.Refresh()
    End Sub
End Class