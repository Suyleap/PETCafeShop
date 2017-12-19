Public Class ReportForm

    Public ReportPetCafe As New ReportPetCafeClass

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        dtgInformation.DataSource = ReportPetCafe.ShowReport(dtpStart.Value.Date, dptEnd.Value.Date)
    End Sub

End Class