Public Class StaffForm

    Dim st As New StaffClass

<<<<<<< HEAD
=======

    Dim acc As New Account
>>>>>>> 133a2bcc7baf81e81884dbd2c8c88030dd05b607
    Private Sub StaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvStaff.DataSource = st.Show()
        dgvStaff.ReadOnly = True
        Clear()
        cboGender.Text = "Female"
        txtID.Text = st.autoGenerateStaffID()
        txtSearch.Enabled = False
        btnSearch.Visible = True
        btnDS.Visible = False
        dgvStaff.Enabled = False
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        btnUpdate.Visible = False
        btnUpdateAcc.Visible = False
        btnUpdateAcc.Enabled = False
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
        btnEdit.Enabled = True
        btnEdit.Visible = True
        btnUpdate.Visible = False
        btnDelete.Enabled = False
        btnAdd.Enabled = True
    End Sub

    Private Sub moove(sender As Object, e As EventArgs)
        dgvStaff.DataSource = st.Show()
        RemoveHandler MouseLeave, AddressOf moove
        Clear()
        txtID.Text = st.autoGenerateStaffID()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        st.UpdateStaff(dgvStaff.CurrentRow.Cells(0).Value.ToString(), txtName.Text, cboGender.Text, Convert.ToDateTime(dtpDOB.Text), Convert.ToByte(txtAge.Text), txtAddress.Text, txtPhone.Text, txtEmail.Text, txtPosition.Text, Convert.ToDouble(txtSalary.Text), Convert.ToDateTime(dtpSWD.Text))
        AddHandler MouseLeave, AddressOf moove
        txtID.Text = st.autoGenerateStaffID()
        Me.Refresh()
        btnUpdate.Visible = False
        btnUpdate.Enabled = False
        btnEdit.Visible = True
        btnEdit.Enabled = True
        btnDelete.Enabled = False
        btnAdd.Enabled = True
    End Sub

    Private Sub DisableInput()
        txtAddress.Enabled = False
        txtName.Enabled = False
        cboGender.Enabled = False
        dtpDOB.Enabled = False
        dtpSWD.Enabled = False
        txtPhone.Enabled = False
        txtSalary.Enabled = False
        txtPosition.Enabled = False
        txtEmail.Enabled = False
    End Sub

    Private Sub EnableInput()
        txtAddress.Enabled = True
        txtName.Enabled = True
        cboGender.Enabled = True
        dtpDOB.Enabled = True
        dtpSWD.Enabled = True
        txtPhone.Enabled = True
        txtSalary.Enabled = True
        txtPosition.Enabled = True
        txtEmail.Enabled = True
    End Sub

    Private Sub dtpDOB_LostFocus(sender As Object, e As EventArgs) Handles dtpDOB.LostFocus
        txtAge.Text = Today.Year - Convert.ToDateTime(dtpDOB.Text).Year
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        txtSearch.Enabled = True
        DisableInput()
        btnSearch.Visible = False
        btnDS.Visible = True
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dgvStaff.DataSource = st.SearchAll(txtSearch.Text)
        dgvStaff.Enabled = True
        Clear()
    End Sub

    Private Sub btnDS_Click(sender As Object, e As EventArgs) Handles btnDS.Click
        txtSearch.Enabled = False
        EnableInput()
        btnSearch.Visible = True
        btnDS.Visible = False
        txtSearch.Text = ""
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        dgvStaff.Enabled = True
        btnUpdate.Visible = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        dgvStaff.Focus()
        btnAdd.Enabled = False
        btnDS.PerformClick()
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
        Try
            If acc.CheckingAcc(txtID.Text) = st.st_ID Then
                btnUpdateAcc.Enabled = True
                btnUpdateAcc.Visible = True
                btnNew.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim objFormAcc As New CreateAcc
        objFormAcc.getID = acc.AutoGenerateAccID()
        objFormAcc.getStaffID = txtID.Text
        objFormAcc.Show()
    End Sub

<<<<<<< HEAD
=======
    Private Sub btnUpdateAcc_Click(sender As Object, e As EventArgs) Handles btnUpdateAcc.Click
        Dim udpAcc As New Update_Account
        udpAcc.getStaffID = txtID.Text
        ' udpAcc.getID = acc.acc_ID
        udpAcc.Show()
    End Sub
>>>>>>> 133a2bcc7baf81e81884dbd2c8c88030dd05b607
End Class