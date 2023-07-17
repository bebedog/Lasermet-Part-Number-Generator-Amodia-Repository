Public Class GeneralUserDashboard
    Private Sub btnAddPart_Click(sender As Object, e As EventArgs) Handles btnAddPart.Click

        Me.Close()
        newPartOptions.Show()

    End Sub

    Private Sub btnSearchInventory_Click(sender As Object, e As EventArgs) Handles btnSearchInventory.Click

        'Dim categories As New List(Of String)

        'For Each dr As DataRow In login.categoriesTable.Rows
        '    categories.Add(dr(0))
        'Next

        SearchDB.populateInventoryDGV()
        'SearchDB.tbCategoryFilter.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        'SearchDB.tbCategoryFilter.AutoCompleteSource = AutoCompleteSource.CustomSource
        'SearchDB.tbCategoryFilter.AutoCompleteCustomSource.AddRange(categories.Distinct.ToArray)
        'SearchDB.panelSearchFilters.Visible = True
        'SearchDB.panelSearchFilters.Enabled = True
        'SearchDB.Size = New Size(800, 600)
        'SearchDB.dgvSearchResults.Size = New Size(768, 258)
        'SearchDB.dgvSearchResults.Location = New Point(8, 232)
        'SearchDB.StartPosition = FormStartPosition.CenterScreen
        Me.Close()
        SearchDB.Show()

    End Sub

    Private Sub GeneralUserDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = $"User Dashboard for {login.firstname} {login.surname}"
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        login.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnViewRequests_Click(sender As Object, e As EventArgs) Handles btnViewRequests.Click
        SearchDB.populateRequestStatus()
        SearchDB.Show()
        Me.Close()
    End Sub
End Class