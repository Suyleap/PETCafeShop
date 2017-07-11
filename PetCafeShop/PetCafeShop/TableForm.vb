
Public Class TableForm

    Private tbpcc As New TablePetCafeClass
    Private con As New ConnectionDBPetCafe

    Private Sub TableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flpnTable.Controls.Clear() '
        flpnTable.Controls.Add(tbpcc.ShowTableButton())
        Me.Refresh()
    End Sub

End Class
