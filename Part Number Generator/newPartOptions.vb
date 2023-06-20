Public Class newPartOptions
    Private Sub btnSingleRequest_Click(sender As Object, e As EventArgs) Handles btnSingleRequest.Click
        Me.Close()
        LasermetPNG.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Select Case login.account_type
            Case "App Admin"
                Me.Close()
                AppAdminDashboard.Show()

            Case "Inventory Admin"
                Me.Close()
                InventoryAdminDashboard.Show()

            Case "Dept. Manager"
                Me.Close()
                AppAdminDashboard.Show()

            Case "General User"
                Me.Close()
                GeneralUserDashboard.Show()

        End Select
    End Sub

    Private Sub btnBatchRequest_Click(sender As Object, e As EventArgs) Handles btnBatchRequest.Click
        Me.Close()
        BatchPartRequest.Show()
    End Sub

    Private Sub newPartOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class