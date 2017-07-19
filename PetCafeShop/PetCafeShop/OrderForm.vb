Public Class OrderForm

    Private odpc As New OrderProccessingClass

    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdoHot.Checked = True
        rdoFood.Checked = True
        Me.Refresh()
    End Sub

    Private Sub Mouse_Hover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        flpnOrders.Controls.Clear()
        flpnOrders.Controls.Add(Me.odpc.ShowPreOrder())
        txtTotalDollar.Text = Convert.ToDouble(odpc.CalculateGrandTotal - odpc.CalculateGrandTotalWithDiscount(txtDiscount.Text)).ToString
        txtTotalRiel.Text = (Convert.ToDouble(odpc.CalculateGrandTotal - odpc.CalculateGrandTotalWithDiscount(txtDiscount.Text)) * 4100).ToString
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

    Private Sub txtRmd_TextChanged(sender As Object, e As EventArgs) Handles txtRmd.TextChanged
        Try
            If txtRmd.Text = "" Then
                txtCmd.Text = "0 $"
            ElseIf txtRmd.Text < txtTotalDollar.Text Then
                txtCmd.Text = "0 $"
            ElseIf txtRmd.Text > txtTotalDollar.Text Then
                txtCmd.Text = Convert.ToDouble(txtRmd.Text - txtTotalDollar.Text).ToString + " $"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtRmr_TextChanged(sender As Object, e As EventArgs) Handles txtRmr.TextChanged
        Try
            If txtRmr.Text = "" Then
                txtCmr.Text = "0 R"
            ElseIf txtRmr.Text < txtTotalRiel.Text Then
                txtCmr.Text = "0 R"
            ElseIf txtRmr.Text > txtTotalRiel.Text Then
                txtCmr.Text = Convert.ToDouble(txtRmr.Text - txtTotalRiel.Text).ToString + " R"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class