Public Class ReportForm

    Public ReportPetCafe As New ReportPetCafeClass

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        dtgInformation.DataSource = ReportPetCafe.ShowReport(dtpStart.Value.Date, dptEnd.Value.Date)
        txtTotalDollar.Text = ReportPetCafe.TotalDollar(dtpStart.Value.Date, dptEnd.Value.Date)
        txtTotalRiel.Text = ReportPetCafe.TotalRiel(dtpStart.Value.Date, dptEnd.Value.Date)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Location = New Point(0, 0)
        Size = SystemInformation.PrimaryMonitorSize
    End Sub
End Class