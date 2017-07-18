Public Class StaffForm
    Dim st As New StaffClass
    Private Sub StaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvStaff.DataSource = st.Show()
        'dgvStaff.Enabled = False
        dgvStaff.ReadOnly = True
        Clear()
        cboGender.Text = "Female"
        txtID.Text = st.autoGenerateStaffID()
    End Sub
    Private Sub dgvStaff_SelectionChanged(sender As Object, e As EventArgs) Handles dgvStaff.SelectionChanged
        Try
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
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
        st.InsertStaff(txtID.Text, txtName.Text, cboGender.Text, Convert.ToDateTime(dtpDOB.Text), Convert.ToByte(txtAge.Text), txtAddress.Text, txtPhone.Text, txtEmail.Text, txtPosition.Text, Convert.ToDouble(txtSalary.Text), Convert.ToDateTime(dtpSWD.Text))
        AddHandler MouseLeave, AddressOf moove
        txtID.Text = st.autoGenerateStaffID()
        Me.Refresh()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        st.DeleteStaff(dgvStaff.CurrentRow.Cells(0).Value.ToString())
        AddHandler MouseLeave, AddressOf moove
        txtID.Text = st.autoGenerateStaffID()
        Me.Refresh()
    End Sub
    Private Sub moove(sender As Object, e As EventArgs)
        dgvStaff.DataSource = st.Show()
        RemoveHandler MouseLeave, AddressOf moove
        Clear()
        txtID.Text = st.autoGenerateStaffID()
    End Sub

  
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        st.UpdateStaff(dgvStaff.CurrentRow.Cells(0).Value.ToString(), txtName.Text, cboGender.Text, Convert.ToDateTime(dtpDOB.Text), Convert.ToByte(txtAge.Text), txtAddress.Text, txtPhone.Text, txtEmail.Text, txtPosition.Text, Convert.ToDouble(txtSalary.Text), Convert.ToDateTime(dtpSWD.Text))
        AddHandler MouseLeave, AddressOf moove
        txtID.Text = st.autoGenerateStaffID()
        Me.Refresh()
    End Sub

    Private Sub dtpDOB_LostFocus(sender As Object, e As EventArgs) Handles dtpDOB.LostFocus
        txtAge.Text = Today.Year - Convert.ToDateTime(dtpDOB.Text).Year
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        dgvStaff.DataSource = st.SearchAll(txtSearch.Text)
        Clear()
    End Sub
End Class