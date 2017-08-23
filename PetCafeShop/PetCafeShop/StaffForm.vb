Public Class StaffForm

    Public St As New StaffClass
    Public Acc As New Account
    Public Ri As New RightClass

    Private Sub StaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Choose.Close()
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
        btnSearch.Enabled = True
        btnNew.Visible = True
        FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Location = New Point(0, 0)
        Size = SystemInformation.PrimaryMonitorSize
        btnNew.Enabled = True
        Refresh()
    End Sub

    Private Sub EmptyInput()
        Try
            If txtName.Text.Trim = "" Then
                    MsgBox("Please fill Name")
                    txtName.Focus()
            ElseIf txtAddress.Text.Trim = "" Then
                MsgBox("Please fill Address")
                txtAddress.Focus()
            ElseIf txtPhone.Text.Trim = "" Then
                MsgBox("Please fill Phone")
                txtPhone.Focus()
            ElseIf txtEmail.Text.Trim = "" Then
                MsgBox("Please fill Email")
                txtEmail.Focus()
            ElseIf txtPosition.Text.Trim = "" Then
                MsgBox("Please fill Position")
                txtPosition.Focus()
            ElseIf txtSalary.Text.Trim = "" Then
                MsgBox("Please fill Salary")
                txtSalary.Focus()
            ElseIf dtpDOB.Value >= Today Then
                MsgBox("Incorrect Date of Birth")
                dtpDOB.Focus()
            ElseIf dtpSWD.Value > Today.AddDays(1) Then
                MsgBox("Incorrect Start Work Date ")
                dtpSWD.Focus()
                dtpSWD.Value = Today
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Refresh()
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
        Try
            If acc.CheckingAcc(txtID.Text) = st.st_ID Then
                btnUpdateAcc.Enabled = True
                btnUpdateAcc.Visible = True
                btnNew.Visible = False
            Else
                btnNew.Enabled = True
                btnNew.Visible = True
                btnUpdateAcc.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Refresh()
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
        Refresh()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
        Refresh()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            st.InsertStaff(txtID.Text, txtName.Text, cboGender.Text, Convert.ToDateTime(dtpDOB.Text), Convert.ToByte(txtAge.Text), txtAddress.Text, txtPhone.Text, txtEmail.Text, txtPosition.Text, Convert.ToDouble(txtSalary.Text), Convert.ToDateTime(dtpSWD.Text))
            AddHandler MouseLeave, AddressOf moove
            txtID.Text = st.autoGenerateStaffID()
            StaffForm_Load(Me, e)
        Catch ex As Exception
            EmptyInput()
        End Try
        Refresh()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        st.DeleteStaff(dgvStaff.CurrentRow.Cells(0).Value.ToString())
        AddHandler MouseLeave, AddressOf moove
        txtID.Text = st.autoGenerateStaffID()
        Refresh()
        btnEdit.Enabled = True
        btnEdit.Visible = True
        btnUpdate.Visible = False
        btnDelete.Enabled = False
        btnAdd.Enabled = True
        btnDS.PerformClick()
        StaffForm_Load(Me, e)
        Refresh()
    End Sub

    Private Sub Moove(sender As Object, e As EventArgs)
        dgvStaff.DataSource = St.Show()
        RemoveHandler MouseLeave, AddressOf Moove
        Clear()
        txtID.Text = St.AutoGenerateStaffId()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            st.UpdateStaff(dgvStaff.CurrentRow.Cells(0).Value.ToString(), txtName.Text, cboGender.Text, Convert.ToDateTime(dtpDOB.Text), Convert.ToByte(txtAge.Text), txtAddress.Text, txtPhone.Text, txtEmail.Text, txtPosition.Text, Convert.ToDouble(txtSalary.Text), Convert.ToDateTime(dtpSWD.Text))
            AddHandler MouseLeave, AddressOf moove
            txtID.Text = st.autoGenerateStaffID()
            Refresh()
            btnUpdate.Visible = False
            btnUpdate.Enabled = False
            btnEdit.Visible = True
            btnEdit.Enabled = True
            btnDelete.Enabled = False
            btnAdd.Enabled = True
            btnDS.PerformClick()
            StaffForm_Load(Me, e)
        Catch ex As Exception
            EmptyInput()
        End Try
        Refresh()
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
        Refresh()
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
        Refresh()
    End Sub

    Private Sub dtpDOB_LostFocus(sender As Object, e As EventArgs) Handles dtpDOB.LostFocus
        txtAge.Text = Today.Year - Convert.ToDateTime(dtpDOB.Text).Year
        Refresh()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        txtSearch.Enabled = True
        DisableInput()
        btnSearch.Visible = False
        btnDS.Visible = True
        btnAdd.Enabled = False
        btnNew.Enabled = False
        Refresh()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dgvStaff.DataSource = st.SearchAll(txtSearch.Text)
        dgvStaff.Enabled = True
        Clear()
        Refresh()
    End Sub

    Private Sub btnDS_Click(sender As Object, e As EventArgs) Handles btnDS.Click
        txtSearch.Enabled = False
        EnableInput()
        btnSearch.Visible = True
        btnDS.Visible = False
        txtSearch.Text = ""
        Refresh()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        dgvStaff.Enabled = True
        btnUpdate.Visible = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        dgvStaff.Focus()
        btnAdd.Enabled = False
        EnableInput()
        btnSearch.Enabled = False
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
            Else
                btnNew.Enabled = True
                btnNew.Visible = True
                btnUpdateAcc.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Refresh()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim objFormAcc As New CreateAcc
        objFormAcc.getID = acc.AutoGenerateAccID()
        objFormAcc.getStaffID = txtID.Text
        objFormAcc.getRightID = ri.autoGenerateRightID()
        objFormAcc.Show()
        Refresh()
    End Sub

    Private Sub btnUpdateAcc_Click(sender As Object, e As EventArgs) Handles btnUpdateAcc.Click
        Dim udpAcc As New UpdateAccount
        udpAcc.getStaffID = txtID.Text
        udpAcc.getRightID = ri.right_ID
        udpAcc.Show()
        Refresh()
    End Sub

End Class