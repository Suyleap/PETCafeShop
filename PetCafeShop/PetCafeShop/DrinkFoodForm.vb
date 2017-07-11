Public Class DrinkFoodForm

    Private DFC As New DrinkFoodClass

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        OrderForm.Show()
        Me.Refresh()
        Me.Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Insert()
        Me.Refresh()
        Me.Clear()
    End Sub

    Public Sub Insert()
        If txtID.Text = "" Or txtName.Text = "" Or txtPrice.Text = "" Then Return
        If rdoHot.Checked Then
            DFC.InsertHotDrink(txtID.Text, txtName.Text, txtPrice.Text)
        ElseIf rdoIce.Checked Then
            DFC.InsertIceDrink(txtID.Text, txtName.Text, txtPrice.Text)
        ElseIf rdoFrab.Checked Then
            DFC.InsertFrabDrink(txtID.Text, txtName.Text, txtPrice.Text)
        ElseIf rdoFood.Checked Then
            DFC.InsertFood(txtID.Text, txtName.Text, txtPrice.Text)
        End If
        Me.Refresh()
    End Sub

    Public Sub Deletes()
        If txtID.Text = "" And txtName.Text = "" And txtPrice.Text = "" Then Return
        If rdoHot.Checked Then
            DFC.DeleteHotDrink(txtID.Text)
        ElseIf rdoIce.Checked Then
            DFC.DeleteIceDrink(txtID.Text)
        ElseIf rdoFrab.Checked Then
            DFC.DeleteFrabDrink(txtID.Text)
        ElseIf rdoFood.Checked Then
            DFC.DeleteFood(txtID.Text)
        End If
        Me.Refresh()
    End Sub

    Public Sub Updates()
        If txtID.Text = "" And txtName.Text = "" And txtPrice.Text = "" Then Return
        If rdoHot.Checked Then
            DFC.UpdateHotDrink(txtID.Text, txtName.Text, txtPrice.Text)
        ElseIf rdoIce.Checked Then
            DFC.UpdateIceDrink(txtID.Text, txtName.Text, txtPrice.Text)
        ElseIf rdoFrab.Checked Then
            DFC.UpdateFrabDrink(txtID.Text, txtName.Text, txtPrice.Text)
        ElseIf rdoFood.Checked Then
            DFC.UpdateFood(txtID.Text, txtName.Text, txtPrice.Text)
        End If
        Me.Refresh()
    End Sub

    Public Sub ShowInsert()
        Dim bs As New BindingSource
        Dim sh As New List(Of DrinkFoodClass)
        If rdoHot.Checked Then
            dtg.DataSource = DFC.ShowHotDrink(sh)
        ElseIf rdoIce.Checked Then
            dtg.DataSource = DFC.ShowIceDrink(sh)
        ElseIf rdoFrab.Checked Then
            dtg.DataSource = DFC.ShowFrabDrink(sh)
        ElseIf rdoFood.Checked Then
            dtg.DataSource = DFC.ShowFood(sh)
        End If
        Me.Refresh()
    End Sub

    Public Sub Clear()
        txtID.Text = ""
        txtName.Text = ""
        txtPrice.Text = ""
        Me.Refresh()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.Clear()
        Me.Refresh()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.Deletes()
        Me.Refresh()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Me.Updates()
        Me.Refresh()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs)
        Me.ShowInsert()
        Me.Refresh()
    End Sub

    Private Sub DrinkFoodForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdoHot.Checked = True
        Me.Refresh()
        Me.ShowInsert()
        Me.Refresh()
    End Sub

    Private Sub rdoHot_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHot.CheckedChanged
        Me.ShowInsert()
        Me.Refresh()
    End Sub

    Private Sub rdoIce_CheckedChanged(sender As Object, e As EventArgs) Handles rdoIce.CheckedChanged
        Me.ShowInsert()
        Me.Refresh()
    End Sub

    Private Sub rdoFrab_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFrab.CheckedChanged
        Me.ShowInsert()
        Me.Refresh()
    End Sub

    Private Sub rdoFood_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFood.CheckedChanged
        Me.ShowInsert()
        Me.Refresh()
    End Sub
End Class