Public Class OrderForm

    Public Odpc As New OrderProccessingClass

    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TableForm.Close()
        FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Location = New Point(0, 0)
        Size = SystemInformation.PrimaryMonitorSize
        rdoHot.Checked = True
        rdoFood.Checked = True
        Refresh()
    End Sub

    Private Sub rdoHot_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHot.CheckedChanged
        flpnDrink.Controls.Clear()
        flpnDrink.Controls.Add(odpc.ShowHotButton)
        Refresh()
    End Sub

    Private Sub rdoIce_CheckedChanged(sender As Object, e As EventArgs) Handles rdoIce.CheckedChanged
        flpnDrink.Controls.Clear()
        flpnDrink.Controls.Add(odpc.ShowIceButton)
        Refresh()
    End Sub

    Private Sub rdoFrab_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFrab.CheckedChanged
        flpnDrink.Controls.Clear()
        flpnDrink.Controls.Add(odpc.ShowFrabButton)
        Refresh()
    End Sub

    Private Sub rdoFood_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFood.CheckedChanged
        flpnbuttonFood.Controls.Clear()
        flpnbuttonFood.Controls.Add(odpc.ShowFoodButton)
        Refresh()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Odpc.CancelPreOrder()
        Refresh()
        Close()
    End Sub

    Private Sub txtRmd_TextChanged(sender As Object, e As EventArgs) Handles txtRmd.TextChanged
        Try
            If txtRmd.Text = "" Then
                txtCmd.Text = 0
            ElseIf Convert.ToDouble(txtRmd.Text < txtTotalDollar.Text) Then
                txtCmd.Text = 0
            ElseIf Convert.ToDouble(txtRmd.Text >= txtTotalDollar.Text) Then
                txtCmd.Text = Convert.ToDouble(txtRmd.Text - txtTotalDollar.Text).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Refresh()
    End Sub

    Private Sub txtRmr_TextChanged(sender As Object, e As EventArgs) Handles txtRmr.TextChanged
        Try
            If txtRmr.Text = Nothing Then
                txtCmr.Text = 0
            ElseIf Convert.ToDouble(txtRmr.Text < txtTotalRiel.Text) Then
                txtCmr.Text = 0
            ElseIf Convert.ToDouble(txtRmr.Text >= txtTotalRiel.Text) Then
                txtCmr.Text = Convert.ToDouble(txtRmr.Text - txtTotalRiel.Text).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Refresh()
    End Sub

    Private Sub Mouse_Enter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        Try
            flpnOrders.Controls.Clear()
            flpnOrders.Controls.Add(Odpc.ShowPreOrder())
            If txtDiscount.Text = Nothing Then
                txtTotalDollar.Text = odpc.CalculateGrandTotal().ToString
                txtTotalRiel.Text = Convert.ToDouble(odpc.CalculateGrandTotal() * 4100).ToString
            Else
                txtTotalDollar.Text = Convert.ToDouble(odpc.CalculateGrandTotal - odpc.CalculateGrandTotalWithDiscount(txtDiscount.Text)).ToString
                txtTotalRiel.Text = Convert.ToDouble((odpc.CalculateGrandTotal - odpc.CalculateGrandTotalWithDiscount(txtDiscount.Text)) * 4100).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Refresh()
    End Sub

    Private Sub btnPn_Click(sender As Object, e As EventArgs) Handles btnPn.Click
        odpc.PayNow(txtInvoice.Text, txtSeller.Text, txtTable.Text, txtDiscount.Text)
        odpc.PrintPayNow(txtInvoice.Text, txtTotalDollar.Text, txtTotalRiel.Text, txtSeller.Text, Convert.ToInt16(txtTable.Text), txtDiscount.Text)
        odpc.CancelPreOrder()
        TableForm.Close()
        Refresh()
        Close()
    End Sub

    Private Sub btnPlt_Click(sender As Object, e As EventArgs) Handles btnPlt.Click
        odpc.PayLatter(txtInvoice.Text, txtSeller.Text, txtTable.Text, txtDiscount.Text)
        odpc.CancelPreOrder()
        TableForm.Close()
        Refresh()
        Close()
    End Sub

    Private Sub btnpdplt_Click(sender As Object, e As EventArgs) Handles btnuplt.Click
        odpc.UpdatePayLatter(txtInvoice.Text, txtSeller.Text, txtTable.Text, txtDiscount.Text)
        odpc.CancelPreOrder()
        TableForm.Close()
        Refresh()
        Close()
    End Sub

    Private Sub btnupn_Click(sender As Object, e As EventArgs) Handles btnupn.Click
        odpc.UpdatePayNow(txtInvoice.Text, txtSeller.Text, txtTable.Text, txtDiscount.Text)
        odpc.PrintPayNow(txtInvoice.Text, txtTotalDollar.Text, txtTotalRiel.Text, txtSeller.Text, Convert.ToInt16(txtTable.Text), txtDiscount.Text)
        odpc.CancelPreOrder()
        TableForm.Close()
        Refresh()
        Close()
    End Sub

    Private Sub btnpplt_Click(sender As Object, e As EventArgs) Handles btnpplt.Click
        odpc.PrintPayLatter(txtInvoice.Text, txtTotalDollar.Text, txtTotalRiel.Text, txtSeller.Text, Convert.ToInt16(txtTable.Text), txtDiscount.Text)
        Refresh()
    End Sub
End Class