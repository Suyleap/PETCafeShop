Public Class OrderForm

    Public Odpc As New OrderProccessingClass


    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Location = New Point(0, 0)
        Size = SystemInformation.PrimaryMonitorSize
        rdoHot.Checked = True
        rdoFood.Checked = True
    End Sub

    Private Sub rdoHot_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHot.CheckedChanged
        flpnDrink.Controls.Clear()
        flpnDrink.Controls.Add(odpc.ShowHotButton)
    End Sub

    Private Sub rdoIce_CheckedChanged(sender As Object, e As EventArgs) Handles rdoIce.CheckedChanged
        flpnDrink.Controls.Clear()
        flpnDrink.Controls.Add(odpc.ShowIceButton)
    End Sub

    Private Sub rdoFrab_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFrab.CheckedChanged
        flpnDrink.Controls.Clear()
        flpnDrink.Controls.Add(odpc.ShowFrabButton)
    End Sub

    Private Sub rdoFood_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFood.CheckedChanged
        flpnbuttonFood.Controls.Clear()
        flpnbuttonFood.Controls.Add(odpc.ShowFoodButton)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Odpc.CancelPreOrder()
        Close()
    End Sub

    Private Sub txtRmd_TextChanged(sender As Object, e As EventArgs) Handles txtRmd.TextChanged

        If txtRmd.Text = "" Then
            txtCmd.Text = 0
        ElseIf Convert.ToDouble(txtRmd.Text <= txtTotalDollar.Text) Then
            txtCmd.Text = 0
        ElseIf Convert.ToDouble(txtRmd.Text >= txtTotalDollar.Text) Then
            txtCmd.Text = Convert.ToDouble(txtRmd.Text - txtTotalDollar.Text).ToString
        End If
    End Sub

    Private Sub txtRmr_TextChanged(sender As Object, e As EventArgs) Handles txtRmr.TextChanged

        If txtRmr.Text = Nothing Then
            txtCmr.Text = 0
        ElseIf Convert.ToDouble(txtRmr.Text <= txtTotalRiel.Text) Then
            txtCmr.Text = 0
        ElseIf Convert.ToDouble(txtRmr.Text >= txtTotalRiel.Text) Then
            txtCmr.Text = Convert.ToDouble(txtRmr.Text - txtTotalRiel.Text).ToString
        End If
        
    End Sub

    Private Sub Mouse_Enter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter

        flpnOrders.Controls.Clear()
        flpnOrders.Controls.Add(Odpc.ShowPreOrder())
        If txtDiscount.Text = Nothing Then
            txtTotalDollar.Text = Odpc.CalculateGrandTotal().ToString
            txtTotalRiel.Text = Convert.ToDouble(Odpc.CalculateGrandTotal() * 4100).ToString
        Else
            txtTotalDollar.Text = Convert.ToDouble(Odpc.CalculateGrandTotal - Odpc.CalculateGrandTotalWithDiscount(txtDiscount.Text)).ToString
            txtTotalRiel.Text = Convert.ToDouble((Odpc.CalculateGrandTotal - Odpc.CalculateGrandTotalWithDiscount(txtDiscount.Text)) * 4100).ToString
        End If
    End Sub

    Private Sub btnPn_Click(sender As Object, e As EventArgs) Handles btnPn.Click
        TableForm.btnClose.PerformClick()
        Odpc.PayNow(txtSeller.Text, txtTable.Text, txtDiscount.Text)
        Odpc.PrintPayNow(Odpc.MaxItemOrder, txtTotalDollar.Text, txtTotalRiel.Text, txtSeller.Text, Convert.ToInt16(txtTable.Text), txtDiscount.Text)
        Odpc.CancelPreOrder()
        Close()
    End Sub

    Private Sub btnPlt_Click(sender As Object, e As EventArgs) Handles btnPlt.Click
        TableForm.btnLoadTableForm.PerformClick()
        TableForm.btnClose.PerformClick()
        Odpc.PayLatter(txtSeller.Text, txtTable.Text, txtDiscount.Text)
        Odpc.CancelPreOrder()
        Close()

    End Sub

    Private Sub btnpdplt_Click(sender As Object, e As EventArgs) Handles btnuplt.Click
        TableForm.btnLoadTableForm.PerformClick()
        TableForm.btnClose.PerformClick()
        Odpc.UpdatePayLatter(txtInvoice.Text, txtSeller.Text, txtTable.Text, txtDiscount.Text)
        Odpc.CancelPreOrder()
        Close()
    End Sub

    Private Sub btnupn_Click(sender As Object, e As EventArgs) Handles btnupn.Click
        TableForm.btnLoadTableForm.PerformClick()
        TableForm.btnClose.PerformClick()
        Odpc.UpdatePayNow(txtInvoice.Text, txtSeller.Text, txtTable.Text, txtDiscount.Text)
        Odpc.PrintPayNow(txtInvoice.Text, txtTotalDollar.Text, txtTotalRiel.Text, txtSeller.Text, Convert.ToInt16(txtTable.Text), txtDiscount.Text)
        odpc.CancelPreOrder()
        Close()
    End Sub

    Private Sub btnpplt_Click(sender As Object, e As EventArgs) Handles btnpplt.Click
        ' odpc.PrintPayLatter(txtInvoice.Text, txtTotalDollar.Text, txtTotalRiel.Text, txtSeller.Text, Convert.ToInt16(txtTable.Text), txtDiscount.Text)
    End Sub

    Private Sub txtCmd_TextChanged(sender As Object, e As EventArgs) Handles txtCmd.TextChanged
        txtCmr.Text = Convert.ToDouble(txtCmd.Text) * 4000
    End Sub
End Class