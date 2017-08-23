Public Class RightForm

    Public Ri As New RightClass
    Dim stfrom As Boolean
    Dim sellform As Boolean
    Dim rig As Boolean

    Private Sub RightForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Choose.Close()
        txtSearch.Text = ""
        dgvRight.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'dgvRight.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvRight.ReadOnly = True
        dgvRight.DataSource = ri.Show()
        FormBorderStyle = Windows.Forms.FormBorderStyle.None
        btnSearch.Enabled = True
        btnSearch.Visible = True
        btnStop.Visible = False
        txtSearch.Enabled = False
        Refresh()
    End Sub

    Private Sub dgvRight_SelectionChanged(sender As Object, e As EventArgs) Handles dgvRight.SelectionChanged
        Try
            ri.selectedRightChange(dgvRight.CurrentRow.Cells(0).Value.ToString())
            txtUser.Text = ri.acc.acc_UserName
            CheckBox()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Refresh()
    End Sub

    Private Sub CheckBox()
        Try
            If ri.right_StaffFrom = True Then
                cboStaffForm.Checked = True
                stfrom = True
            Else
                cboStaffForm.Checked = False
                stfrom = False
            End If
            If ri.right_SellForm = True Then
                cboSellForm.Checked = True
                sellform = True
            Else
                cboSellForm.Checked = False
                sellform = False
            End If
            If ri.right_RightForm = True Then
                cboRight.Checked = True
                rig = True
            Else
                cboRight.Checked = False
                rig = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Refresh()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
        Refresh()
    End Sub

    Private Sub GetValue()
        Try
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Refresh()
    End Sub

    Private Sub Rm(sender As Object, e As EventArgs)
        dgvRight.DataSource = Ri.Show()
        RemoveHandler MouseLeave, AddressOf Rm
        Refresh()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            GetValue()
            ri.UpdateRight(dgvRight.CurrentRow.Cells(0).Value.ToString(), stfrom, sellform, rig)
            AddHandler MouseLeave, AddressOf Rm
            RightForm_Load(Me, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Refresh()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dgvRight.DataSource = ri.SearchAll(txtSearch.Text)
        Refresh()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        RightForm_Load(Me, e)
        Refresh()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        txtSearch.Enabled = True
        btnSearch.Enabled = False
        btnSearch.Visible = False
        btnStop.Enabled = True
        btnStop.Visible = True
        Refresh()
    End Sub

End Class