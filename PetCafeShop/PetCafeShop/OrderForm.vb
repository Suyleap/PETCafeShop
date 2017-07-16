Public Class OrderForm

    Private odpc As New OrderProccessingClass

    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdoHot.Checked = True
        Me.Refresh()
        rdoFood.Checked = True
        Me.Refresh()
    End Sub

    Private Sub Mouse_Hover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        flpnOrders.Controls.Clear()
        flpnOrders.Controls.Add(Me.odpc.ShowPreOrder())
        Me.Refresh()
    End Sub

    Private Sub rdoHot_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHot.CheckedChanged
        flpnDrink.Controls.Clear()
        flpnDrink.Controls.Add(odpc.ShowHotButton)
        Me.Refresh()
    End Sub

    Private Sub rdoIce_CheckedChanged(sender As Object, e As EventArgs) Handles rdoIce.CheckedChanged
        flpnDrink.Controls.Clear()
        flpnDrink.Controls.Add(odpc.ShowIceButton)
        Me.Refresh()
    End Sub

    Private Sub rdoFrab_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFrab.CheckedChanged
        flpnDrink.Controls.Clear()
        flpnDrink.Controls.Add(odpc.ShowFrabButton)
        Me.Refresh()
    End Sub

    Private Sub rdoFood_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFood.CheckedChanged
        flpnbuttonFood.Controls.Clear()
        flpnbuttonFood.Controls.Add(odpc.ShowFoodButton)
        Me.Refresh()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.odpc.CancelPreOrder()
        Me.Refresh()
        Application.Restart()
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
       
    End Sub

End Class