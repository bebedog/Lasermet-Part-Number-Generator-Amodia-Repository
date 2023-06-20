Public Class AppAdminDashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = $"Dashboard for {login.firstname} {login.surname}"

    End Sub

    Private Sub btnAddPart_Click(sender As Object, e As EventArgs) Handles btnAddPart.Click

        newPartOptions.Show()
        Me.Close()

    End Sub

    Private Sub btnSearchParts_Click(sender As Object, e As EventArgs) Handles btnSearchParts.Click

        SearchDB.populateApprovalDGV()
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

    Private Sub btnAccountsRequests_Click(sender As Object, e As EventArgs) Handles btnAccountsRequests.Click

        SearchDB.populateAccountRequestsDGV()
        'SearchDB.panelSearchFilters.Visible = False
        'SearchDB.panelSearchFilters.Enabled = False
        'SearchDB.Size = New Size(800, 600)
        'SearchDB.dgvSearchResults.Size = New Size(768, 448)
        'SearchDB.dgvSearchResults.Location = New Point(8, 42)
        'SearchDB.Location = New Point(0, 0)
        Me.Close()
        SearchDB.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        login.Show()
        Me.Close()

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub

End Class