
Public Class TableForm

    Private tbpcc As New TablePetCafeClass
    Private con As New ConnectionDBPetCafe

    Private Sub TableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Choose.Close()
        flpnTable.Controls.Clear() '
        flpnTable.Controls.Add(tbpcc.ShowTableButton())
        Me.Refresh()
        txtID.ReadOnly = True
        txtID.Text = tbpcc.AutoGenerateTableID()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Location = New Point(0, 0)
        Me.Size = SystemInformation.PrimaryMonitorSize
        gbtable.Enabled = False
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

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        gbtable.Enabled = True
    End Sub

    Private Sub btnDrinkFood_Click(sender As Object, e As EventArgs) Handles btnDrinkFood.Click
        Me.Close()
        DrinkFoodForm.Show()
    End Sub
End Class
