'================================================================================
'FILE        : AppAdminDashboard.vb
'AUTHORS     : Jayson O. Amodia, Elyn Abby Toledo, Kathryn Marie P. Sigaya
'DESCRIPTION : This file shows the processes and design menu of the dashboard as App Admin of the Part Number Generator.
'COPYRIGHT   : 12 July 2023
'REVISION HISTORY
'Date: 			By: 		Description:
'2023/07/12     Sigaya      Documentation
'================================================================================

'================================================================================
'CLASS       : AppAdminDashboard
'DESCRIPTION : Class that stores variables, functions, and other classes for the App Admin Dashboard
'================================================================================
Public Class AppAdminDashboard

    '================================================================================
    'SUBROUTINE   : Dashboard_Load
    'DESCRIPTION  : Loads the App Admin Dashboard.  
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '================================================================================
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = $"Dashboard for {login.firstname} {login.surname}"

    End Sub

    '================================================================================
    'SUBROUTINE   : btnAddPart_Click
    'DESCRIPTION  : Shows the Part Requests menu that has the Single Part Request and the Batch Request options
    '               after you click the "Add New Part to Database" option.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '================================================================================
    Private Sub btnAddPart_Click(sender As Object, e As EventArgs) Handles btnAddPart.Click

        newPartOptions.Show()
        Me.Close()

    End Sub

    '================================================================================
    'SUBROUTINE   : btnSearchParts_Click
    'DESCRIPTION  : Shows the requested parts after you clicked the New Parts Requests option.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '================================================================================
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

    '================================================================================
    'SUBROUTINE   : btnSearchInventory_Click
    'DESCRIPTION  : Shows the Current Master List DB afte you click the "Search Master List" option.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '================================================================================
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

    '================================================================================
    'SUBROUTINE   : btnAccountsRequests_Click
    'DESCRIPTION  : Shows the account requests that are pending for approval.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '================================================================================
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

    '================================================================================
    'SUBROUTINE   : ExitToolStripMenuItem_Click
    'DESCRIPTION  : Shows the login menu after you click the "Log Out" option in the menu bar.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '================================================================================
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        login.Show()
        Me.Close()

    End Sub

    '================================================================================
    'SUBROUTINE   : ExitToolStripMenuItem1_Click
    'DESCRIPTION  : Exits the program after you click the "Exit" option in the menu bar.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '================================================================================
    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub

End Class