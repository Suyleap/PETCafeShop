Public Class Choose

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        Dim st As New StaffForm
        st.Show()
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        Dim ri As New RightForm
        ri.Show()
    End Sub

    Private Sub btnSell_Click(sender As Object, e As EventArgs) Handles btnSell.Click
        Dim sell As New TableForm
        sell.Show()
    End Sub
End Class