﻿Public Class TableForm

    Public Tbpcc As New TablePetCafeClass
    Public Con As New ConnectionDbPetCafe

    Private Sub TableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flpnTable.Controls.Clear() '
        flpnTable.Controls.Add(Tbpcc.ShowTableButton(txtStaffId.Text))
        txtID.ReadOnly = True
        txtID.Text = tbpcc.AutoGenerateTableID()
        FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Location = New Point(0, 0)
        Size = SystemInformation.PrimaryMonitorSize
        gbtable.Enabled = False

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        tbpcc.Insert(txtID.Text, txtName.Text, False)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        tbpcc.DeleteTABLE((txtName.Text))
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        gbtable.Enabled = True
    End Sub

    Private Sub btnDrinkFood_Click(sender As Object, e As EventArgs) Handles btnDrinkFood.Click
        Close()
        DrinkFoodForm.ShowDialog()
    End Sub

    Private Sub btnLoadTableForm_Click(sender As Object, e As EventArgs) Handles btnLoadTableForm.Click
        TableForm_Load(Me, New EventArgs)
    End Sub

End Class
