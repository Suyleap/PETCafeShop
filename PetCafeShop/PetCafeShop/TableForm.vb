﻿
Public Class TableForm

    Private tbpcc As New TablePetCafeClass
    Private con As New ConnectionDBPetCafe

    Private Sub TableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flpnTable.Controls.Clear() '
        flpnTable.Controls.Add(tbpcc.ShowTableButton())
        Me.Refresh()
        txtID.ReadOnly = True
        txtID.Text = tbpcc.AutoGenerateTableID()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        tbpcc.Insert(txtID.Text, txtName.Text, False)
        Me.Refresh()
        Application.Restart()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        tbpcc.DeleteTABLE((txtName.Text))
        Me.Refresh()
        Application.Restart()
    End Sub
End Class
