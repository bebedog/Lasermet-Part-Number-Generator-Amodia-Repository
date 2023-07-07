Public Class InventoryAdminDashboard

    Private Sub btnSearchParts_Click(sender As Object, e As EventArgs) Handles btnSearchParts.Click

        SearchDB.populateApprovalDGV()
        Me.Close()
        'SearchDB.panelSearchFilters.Visible = False
        'SearchDB.panelSearchFilters.Enabled = False
        'SearchDB.Size = New Size(800, 600)
        'SearchDB.dgvSearchResults.Size = New Size(768, 448)
        'SearchDB.dgvSearchResults.Location = New Point(8, 42)
        'SearchDB.Location = New Point(0, 0)
        Me.Close()
        SearchDB.Show()

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

    Private Sub InventoryAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = $"Inventory Admin Dashboard for {login.firstname} {login.surname}"
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Me.Close()
        login.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class