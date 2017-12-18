Public Class RightForm

    Public Ri As New RightClass
    Public Stfrom As Boolean
    Public Sellform As Boolean
    Public Rig As Boolean

    Private Sub RightForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Choose.Close()
        txtSearch.Text = ""
        dgvRight.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'dgvRight.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvRight.ReadOnly = True
        dgvRight.DataSource = Ri.Show()
        FormBorderStyle = Windows.Forms.FormBorderStyle.None
        btnSearch.Enabled = True
        btnSearch.Visible = True
        btnStop.Visible = False
        txtSearch.Enabled = False
    End Sub

    Private Sub dgvRight_SelectionChanged(sender As Object, e As EventArgs) Handles dgvRight.SelectionChanged
        Ri.SelectedRightChange(dgvRight.CurrentRow.Cells(0).Value.ToString())
        txtUser.Text = Ri.Acc.acc_UserName
        CheckBox()
    End Sub

    Private Sub CheckBox()
            If Ri.RightStaffFrom = True Then
                cboStaffForm.Checked = True
                stfrom = True
            Else
                cboStaffForm.Checked = False
                stfrom = False
            End If
            If Ri.RightSellForm = True Then
                cboSellForm.Checked = True
                sellform = True
            Else
                cboSellForm.Checked = False
                sellform = False
            End If
            If Ri.RightRightForm = True Then
                cboRight.Checked = True
                rig = True
            Else
                cboRight.Checked = False
                rig = False
            End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub GetValue()
            If cboStaffForm.Checked = True Then
                stfrom = True
            Else
                stfrom = False
            End If
            If cboSellForm.Checked = True Then
                sellform = True
            Else
                sellform = False
            End If
            If cboRight.Checked = True Then
                rig = True
            Else
                rig = False
            End If

    End Sub

    Private Sub Rm(sender As Object, e As EventArgs)
        dgvRight.DataSource = Ri.Show()
        RemoveHandler MouseLeave, AddressOf Rm

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
            GetValue()
            ri.UpdateRight(dgvRight.CurrentRow.Cells(0).Value.ToString(), stfrom, sellform, rig)
            AddHandler MouseLeave, AddressOf Rm
            RightForm_Load(Me, e)

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dgvRight.DataSource = ri.SearchAll(txtSearch.Text)

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        RightForm_Load(Me, e)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        txtSearch.Enabled = True
        btnSearch.Enabled = False
        btnSearch.Visible = False
        btnStop.Enabled = True
        btnStop.Visible = True

    End Sub
End Class