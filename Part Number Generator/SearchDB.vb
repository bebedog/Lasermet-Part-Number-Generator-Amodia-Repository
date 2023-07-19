'================================================================================
'FILE        : SearchDB.vb
'AUTHORS     : Jayson O. Amodia, Elyn Abby Toledo, Kathryn Marie P. Sigaya
'DESCRIPTION : This file shows the processes and design menus of the four options found in the dashboard of the Part Number Generator.
'COPYRIGHT   : 13 July 2023
'REVISION HISTORY
'Date: 			By: 		Description:
'2023/07/13     Sigaya      Documentation
'================================================================================

Imports System.Text
Imports System.Threading

'================================================================================
'CLASS       : SearchDB
'DESCRIPTION : Class that stores variables, functions, and other classes for the SearchDB file
'=============================================================================
Public Class SearchDB

    Public resultsTable As New DataTable()
    Dim tableBindingSource As New BindingSource()
    Public inventoryTable As New DataTable
    Public accountRequestsTable As New DataTable()
    Dim csvSavepath As String = ""

    '================================================================================
    'SUBROUTINE   : populateAccountRequestsDGV
    'DESCRIPTION  : Populates the Account Requests DataGridView.
    'ARGUMENTS    : None
    '================================================================================
    Public Sub populateAccountRequestsDGV()

        panelMasterListOptions.Hide()

        panelSearchFilters.Visible = False
        panelSearchFilters.Enabled = False
        Me.StartPosition = StartPosition.CenterScreen
        Me.Size = New Size(800, 600)
        dgvSearchResults.Size = New Size(Me.Width - 32, Me.Height - 152)
        dgvSearchResults.Location = New Point(8, 42)
        dgvSearchResults.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right

        Me.Text = "New User Account Requests"

        Call connectPostGre()

        dgvSearchResults.Columns.Clear()
        tableBindingSource.DataSource = Nothing
        dgvSearchResults.DataSource = Nothing

        ToolStripStatusLabel1.Text = "(̿▀̿ ̿Ĺ̯̿̿▀̿ ̿)̄"

        Try

            Dim sqlQuery As String

            Select Case login.account_type
                Case "App Admin"
                    sqlQuery = "SELECT * from ""account_requests"" ORDER BY date_requested DESC"
                Case "Dept. Manager"
                    sqlQuery = $"SELECT * FROM ""account_requests"" WHERE department = '{login.user_department}' ORDER BY date_requested DESC"
            End Select


            pda = New Odbc.OdbcDataAdapter()
            Dim pdcb As New Odbc.OdbcCommandBuilder(pda)
            pda.SelectCommand = New Odbc.OdbcCommand(sqlQuery, pcon)
            Dim dtable As New DataTable()

            pcon.Open()
            pda.Fill(dtable)
            pcon.Close()

            accountRequestsTable.Columns.Clear()
            accountRequestsTable.Columns.Add("Username")
            accountRequestsTable.Columns.Add("E-mail")
            accountRequestsTable.Columns.Add("First Name")
            accountRequestsTable.Columns.Add("Surname")
            accountRequestsTable.Columns.Add("Department")
            accountRequestsTable.Columns.Add("Location")
            accountRequestsTable.Columns.Add("Date Requested")
            accountRequestsTable.Columns.Add("Password")
            accountRequestsTable.Columns.Add("Monday ID")

            For Each dr As DataRow In dtable.Rows

                Dim row As DataRow = accountRequestsTable.NewRow

                row.Item(0) = dr(0)
                row.Item(1) = dr(2)
                row.Item(2) = dr(3)
                row.Item(3) = dr(4)
                row.Item(4) = dr(7)
                row.Item(5) = dr(6)
                row.Item(6) = dr(5)
                row.Item(7) = dr(1)
                row.Item(8) = dr(8)

                accountRequestsTable.Rows.Add(row)

            Next

            Dim allRows As DataColumn = accountRequestsTable.Columns.Add("_AllRows")

            For Each dr As DataRow In accountRequestsTable.Rows

                Dim sb As New StringBuilder

                For i = 0 To accountRequestsTable.Columns.Count - 1
                    sb.Append(dr(i).ToString())
                    sb.Append("\t")
                Next

                dr(allRows) = sb.ToString()

            Next

            accountRequestsTable.TableName = "Accounts Requests"

            Dim user_types As New DataGridViewComboBoxColumn()
            Dim btnApprove As New DataGridViewButtonColumn
            Dim btnDeny As New DataGridViewButtonColumn

            'set Values for user_types combobox

            user_types.HeaderText = "Account Type"
            user_types.Name = "user_types"
            user_types.Items.Add("General User")
            user_types.Items.Add("Dept. Manager")
            user_types.Items.Add("Gen. Manager")
            user_types.Items.Add("Inventory Admin")
            user_types.Items.Add("App Admin")

            'configure btn columns

            btnApprove.HeaderText = "Approve"
            btnApprove.Name = "btnApprove"
            btnApprove.Text = "Approve"
            btnApprove.UseColumnTextForButtonValue = True

            btnDeny.HeaderText = "Deny"
            btnDeny.Name = "btnDeny"
            btnDeny.Text = "Deny"
            btnDeny.UseColumnTextForButtonValue = True

            dgvSearchResults.DataSource = accountRequestsTable
            dgvSearchResults.Columns.Add(user_types)
            dgvSearchResults.Columns.Add(btnApprove)
            dgvSearchResults.Columns.Add(btnDeny)

            For Each c As DataGridViewColumn In dgvSearchResults.Columns
                If c.HeaderText <> "Account Type" Then
                    c.ReadOnly = True
                End If
            Next

            dgvSearchResults.Columns(6).ReadOnly = False
            dgvSearchResults.Columns(7).Visible = False
            dgvSearchResults.Columns(9).Visible = False

            Console.WriteLine(dgvSearchResults.DataSource.TableName)
            dgvSearchResults.Refresh()

            ToolStripStatusLabel1.Text = $"{dgvSearchResults.Rows.Count} account requests for approval"


        Catch ex As Exception
            MessageBox.Show($"Exception thrown at SearchDB.populateAccountRequestsDGV:{Environment.NewLine}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            pcon.Close()
        End Try

    End Sub

    '================================================================================
    'SUBROUTINE   : populateInventoryDGV
    'DESCRIPTION  : Populates the Inventory DataGridView.
    'ARGUMENTS    : None
    '================================================================================
    Public Sub populateInventoryDGV()

        panelMasterListOptions.Show()

        Dim categories As New List(Of String)

        For Each dr As DataRow In login.categoriesTable.Rows
            categories.Add(dr(0))
        Next

        tbCategoryFilter.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tbCategoryFilter.AutoCompleteSource = AutoCompleteSource.CustomSource
        tbCategoryFilter.AutoCompleteCustomSource.AddRange(categories.Distinct.ToArray)
        panelSearchFilters.Visible = True
        panelSearchFilters.Enabled = True
        Me.Size = New Size(800, 600)
        dgvSearchResults.Size = New Size(Me.Width - 32, Me.Height - 342)
        dgvSearchResults.Location = New Point(8, 232)

        Me.Text = "Current Master List DB"

        Call connectPostGre()

        ToolStripStatusLabel1.Text = "(̿▀̿ ̿Ĺ̯̿̿▀̿ ̿)̄"

        dgvSearchResults.Columns.Clear()
        tableBindingSource.DataSource = Nothing
        dgvSearchResults.DataSource = Nothing

        Try

            Dim sqlQuery As String = "SELECT * from ""LasermetPARTS"" ORDER BY final_approval_date DESC"


            pda = New Odbc.OdbcDataAdapter()
            Dim pdcb As New Odbc.OdbcCommandBuilder(pda)
            pda.SelectCommand = New Odbc.OdbcCommand(sqlQuery, pcon)
            Dim dtable As New DataTable()

            pcon.Open()
            pda.Fill(dtable)
            pcon.Close()

            If login.account_type.Contains("Admin") Or login.account_type.Contains("Manager") Then

                'Load DGV with "Update" Option

                Dim btnUpdate As New DataGridViewButtonColumn

                btnUpdate.HeaderText = "Update Inventory Item"
                btnUpdate.Name = "btnUpdate"
                btnUpdate.Text = "Update Inventory Item"
                btnUpdate.UseColumnTextForButtonValue = True


                inventoryTable.Columns.Add("Lasermet_Part_Num")
                inventoryTable.Columns.Add("Lasermet_Drawing_No")
                inventoryTable.Columns.Add("Location")
                inventoryTable.Columns.Add("Warehouse")
                inventoryTable.Columns.Add("Description")
                inventoryTable.Columns.Add("Specifications")
                inventoryTable.Columns.Add("Manufacturer_Part_No.")
                inventoryTable.Columns.Add("Category")
                inventoryTable.Columns.Add("Subcategory")
                inventoryTable.Columns.Add("Group_Name")
                inventoryTable.Columns.Add("Supplier")
                inventoryTable.Columns.Add("Supplier_Ref_No.")
                inventoryTable.Columns.Add("Comments")
                inventoryTable.Columns.Add("Current_Stock")
                inventoryTable.Columns.Add("Added_by")
                inventoryTable.Columns.Add("Approved_by")
                inventoryTable.Columns.Add("Last_Updated")
                inventoryTable.Columns.Add("Updated_by")
                inventoryTable.Columns.Add("Department")
                inventoryTable.Columns.Add("UK_Nominal_Code")
                inventoryTable.Columns.Add("UK_Cost_Center")
                inventoryTable.Columns.Add("Manager_Approval_Date")
                inventoryTable.Columns.Add("Final_Approval_Date")

                For Each dr As DataRow In dtable.Rows

                    Dim row As DataRow = inventoryTable.NewRow()

                    row.Item("Lasermet_Part_Num") = dr(0)
                    row.Item("Lasermet_Drawing_No") = dr(11)
                    row.Item("Location") = dr(25)
                    row.Item("Warehouse") = dr(24)
                    row.Item("Description") = dr(1)
                    row.Item("Specifications") = dr(2)
                    row.Item("Manufacturer_Part_No.") = dr(20)
                    row.Item("Category") = dr(3)
                    row.Item("Subcategory") = dr(4)
                    row.Item("Group_Name") = dr(5)
                    row.Item("Supplier") = dr(18)
                    row.Item("Supplier_Ref_No.") = dr(21)
                    row.Item("Comments") = dr(6)
                    row.Item("Current_Stock") = dr(7)
                    row.Item("Added_by") = dr(8)
                    row.Item("Approved_by") = dr(9)
                    row.Item("Last_Updated") = dr(12)
                    row.Item("Updated_by") = dr(13)
                    row.Item("Department") = dr(14)
                    row.Item("UK_Nominal_Code") = dr(15)
                    row.Item("UK_Cost_Center") = dr(16)
                    row.Item("Manager_Approval_Date") = dr(17)
                    row.Item("Final_Approval_Date") = dr(10)

                    inventoryTable.Rows.Add(row)

                Next

                Dim allRows As DataColumn = inventoryTable.Columns.Add("_AllRows")

                For Each dr As DataRow In inventoryTable.Rows

                    Dim sb As New StringBuilder

                    For i = 0 To inventoryTable.Columns.Count - 1
                        sb.Append(dr(i).ToString())
                        sb.Append("\t")
                    Next

                    dr(allRows) = sb.ToString()

                Next

                inventoryTable.TableName = "Inventory Table"

                dgvSearchResults.DataSource = inventoryTable
                dgvSearchResults.Columns(0).HeaderText = "Lasermet Part No."
                dgvSearchResults.Columns(1).HeaderText = "Lasermet Drawing No."
                dgvSearchResults.Columns(2).HeaderText = "Location"
                dgvSearchResults.Columns(3).HeaderText = "Warehouse"
                dgvSearchResults.Columns(4).HeaderText = "Description"
                dgvSearchResults.Columns(5).HeaderText = "Specifications"
                dgvSearchResults.Columns(6).HeaderText = "Manufacturer Part No."
                dgvSearchResults.Columns(7).HeaderText = "Category"
                dgvSearchResults.Columns(8).HeaderText = "Subcategory"
                dgvSearchResults.Columns(9).HeaderText = "Group Name"
                dgvSearchResults.Columns(10).HeaderText = "Supplier"
                dgvSearchResults.Columns(11).HeaderText = "Supplier Ref. No."
                dgvSearchResults.Columns(12).HeaderText = "Comments"
                dgvSearchResults.Columns(13).HeaderText = "Current Stock"
                dgvSearchResults.Columns(14).HeaderText = "Added By"
                dgvSearchResults.Columns(15).HeaderText = "Approved By"
                dgvSearchResults.Columns(16).HeaderText = "Last Updated"
                dgvSearchResults.Columns(17).HeaderText = "Updated by"
                dgvSearchResults.Columns(18).HeaderText = "Department"
                dgvSearchResults.Columns(19).HeaderText = "UK Nominal Code"
                dgvSearchResults.Columns(20).HeaderText = "UK Cost Center"
                dgvSearchResults.Columns(21).HeaderText = "Manager Approval Date"
                dgvSearchResults.Columns(22).HeaderText = "Final Approval Date"

                dgvSearchResults.Columns(23).Visible = False
                dgvSearchResults.Columns.Insert(8, btnUpdate)

                For Each c As DataGridViewColumn In dgvSearchResults.Columns
                    c.ReadOnly = True
                Next

                dgvSearchResults.Refresh()

                ToolStripStatusLabel1.Text = $"{dgvSearchResults.Rows.Count} parts found"

            ElseIf login.account_type = "General User" Then

                inventoryTable.Columns.Add("Lasermet_Part_Num")
                inventoryTable.Columns.Add("Lasermet_Drawing_No")
                inventoryTable.Columns.Add("Location")
                inventoryTable.Columns.Add("Warehouse")
                inventoryTable.Columns.Add("Description")
                inventoryTable.Columns.Add("Specifications")
                inventoryTable.Columns.Add("Manufacturer_Part_No.")
                inventoryTable.Columns.Add("Category")
                inventoryTable.Columns.Add("Subcategory")
                inventoryTable.Columns.Add("Group_Name")
                inventoryTable.Columns.Add("Supplier")
                inventoryTable.Columns.Add("Supplier_Ref_No.")
                inventoryTable.Columns.Add("Comments")
                inventoryTable.Columns.Add("Current_Stock")
                inventoryTable.Columns.Add("Added_by")
                inventoryTable.Columns.Add("Approved_by")
                inventoryTable.Columns.Add("Last_Updated")
                inventoryTable.Columns.Add("Updated_by")
                inventoryTable.Columns.Add("Department")
                inventoryTable.Columns.Add("UK_Nominal_Code")
                inventoryTable.Columns.Add("UK_Cost_Center")
                inventoryTable.Columns.Add("Manager_Approval_Date")
                inventoryTable.Columns.Add("Final_Approval_Date")

                For Each dr As DataRow In dtable.Rows

                    Dim row As DataRow = inventoryTable.NewRow()

                    row.Item("Lasermet_Part_Num") = dr(0)
                    row.Item("Lasermet_Drawing_No") = dr(11)
                    row.Item("Location") = dr(25)
                    row.Item("Warehouse") = dr(24)
                    row.Item("Description") = dr(1)
                    row.Item("Specifications") = dr(2)
                    row.Item("Manufacturer_Part_No.") = dr(20)
                    row.Item("Category") = dr(3)
                    row.Item("Subcategory") = dr(4)
                    row.Item("Group_Name") = dr(5)
                    row.Item("Supplier") = dr(18)
                    row.Item("Supplier_Ref_No.") = dr(21)
                    row.Item("Comments") = dr(6)
                    row.Item("Current_Stock") = dr(7)
                    row.Item("Added_by") = dr(8)
                    row.Item("Approved_by") = dr(9)
                    row.Item("Last_Updated") = dr(12)
                    row.Item("Updated_by") = dr(13)
                    row.Item("Department") = dr(14)
                    row.Item("UK_Nominal_Code") = dr(15)
                    row.Item("UK_Cost_Center") = dr(16)
                    row.Item("Manager_Approval_Date") = dr(17)
                    row.Item("Final_Approval_Date") = dr(10)

                    inventoryTable.Rows.Add(row)

                Next

                Dim allRows As DataColumn = inventoryTable.Columns.Add("_AllRows")

                For Each dr As DataRow In inventoryTable.Rows

                    Dim sb As New StringBuilder

                    For i = 0 To inventoryTable.Columns.Count - 1
                        sb.Append(dr(i).ToString())
                        sb.Append("\t")
                    Next

                    dr(allRows) = sb.ToString()

                Next

                inventoryTable.TableName = "Inventory Table"

                dgvSearchResults.DataSource = inventoryTable
                dgvSearchResults.Columns(0).HeaderText = "Lasermet Part No."
                dgvSearchResults.Columns(1).HeaderText = "Lasermet Drawing No."
                dgvSearchResults.Columns(2).HeaderText = "Location"
                dgvSearchResults.Columns(3).HeaderText = "Warehouse"
                dgvSearchResults.Columns(4).HeaderText = "Description"
                dgvSearchResults.Columns(5).HeaderText = "Specifications"
                dgvSearchResults.Columns(6).HeaderText = "Manufacturer Part No."
                dgvSearchResults.Columns(7).HeaderText = "Category"
                dgvSearchResults.Columns(8).HeaderText = "Subcategory"
                dgvSearchResults.Columns(9).HeaderText = "Group Name"
                dgvSearchResults.Columns(10).HeaderText = "Supplier"
                dgvSearchResults.Columns(11).HeaderText = "Supplier Ref. No."
                dgvSearchResults.Columns(12).HeaderText = "Comments"
                dgvSearchResults.Columns(13).HeaderText = "Current Stock"
                dgvSearchResults.Columns(14).HeaderText = "Added By"
                dgvSearchResults.Columns(15).HeaderText = "Approved By"
                dgvSearchResults.Columns(16).HeaderText = "Last Updated"
                dgvSearchResults.Columns(17).HeaderText = "Updated by"
                dgvSearchResults.Columns(18).HeaderText = "Department"
                dgvSearchResults.Columns(19).HeaderText = "UK Nominal Code"
                dgvSearchResults.Columns(20).HeaderText = "UK Cost Center"
                dgvSearchResults.Columns(21).HeaderText = "Manager Approval Date"
                dgvSearchResults.Columns(22).HeaderText = "Final Approval Date"

                dgvSearchResults.Columns(23).Visible = False

                For Each c As DataGridViewColumn In dgvSearchResults.Columns
                    c.ReadOnly = True
                Next

                dgvSearchResults.Refresh()

                ToolStripStatusLabel1.Text = $"{dgvSearchResults.Rows.Count} parts found"

            End If

        Catch ex As Exception

            MessageBox.Show($"Exception thrown at SearchDB.populateInventoryDGV:{Environment.NewLine}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            pcon.Close()

        End Try

    End Sub

    '================================================================================
    'FUNCTION     : populateApprovalDGV
    'DESCRIPTION  : Populates the pending Part Requests DataGridView.
    'ARGUMENTS    : None
    'RETURNS      : DataTable - stores data in memory, essential in SQL 
    '================================================================================
    Public Function populateApprovalDGV() As DataTable

        panelMasterListOptions.Hide()

        panelSearchFilters.Visible = False
        panelSearchFilters.Enabled = False
        Me.Size = New Size(800, 600)
        dgvSearchResults.Size = New Size(Me.Width - 32, Me.Height - 152)
        dgvSearchResults.Location = New Point(8, 42)
        dgvSearchResults.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right



        Me.Text = "New Master List Requests"

        Call connectPostGre()

        resultsTable.Columns.Clear()
        dgvSearchResults.Columns.Clear()
        ToolStripStatusLabel1.Text = "(̿▀̿ ̿Ĺ̯̿̿▀̿ ̿)̄"

        Try

            Dim sqlQuery As String

            'no case for general user
            Select Case login.account_type
                Case "Dept. Manager"
                    sqlQuery = $"SELECT * FROM ""LasermetPARTS_forApproval"" WHERE ""department"" = '{login.user_department}' AND ""manager_approval"" IS NULL OR ""manager_approval"" = 'Needs additional information' AND ""final_approval"" IS NULL AND ""requested_by"" IN (SELECT ""username"" FROM ""users"" WHERE ""user_type"" = 'General User' OR ""user_type"" = 'App Admin')"
                Case "Gen. Manager"
                    sqlQuery = $"SELECT * FROM ""LasermetPARTS_forApproval"" WHERE ""requested_by"" IN (SELECT ""username"" FROM ""users"" WHERE ""user_type"" = 'Dept. Manager')"
                Case "Inventory Admin"
                    sqlQuery = $"SELECT * from ""LasermetPARTS_forApproval"" WHERE ""manager_approval"" = 'Approved' AND ""part_location"" = '{login.user_location}' AND ""final_approval"" IS NULL OR ""final_approval"" = 'Needs additional information' ORDER BY date_added DESC"
                Case "App Admin"
                    sqlQuery = "SELECT * from ""LasermetPARTS_forApproval"" ORDER BY date_added DESC"
            End Select


            pda = New Odbc.OdbcDataAdapter()
            Dim pdcb As New Odbc.OdbcCommandBuilder(pda)
            pda.SelectCommand = New Odbc.OdbcCommand(sqlQuery, pcon)
            Dim dtable As New DataTable()

            pcon.Open()
            pda.Fill(dtable)
            pcon.Close()

            resultsTable.Columns.Add("Lasermet_Part_Num")
            resultsTable.Columns.Add("Lasermet_Drawing_No")
            resultsTable.Columns.Add("Location")
            resultsTable.Columns.Add("Warehouse")
            resultsTable.Columns.Add("Description")
            resultsTable.Columns.Add("Specifications")
            resultsTable.Columns.Add("Manufacturer_Part_No.")
            resultsTable.Columns.Add("Category")
            resultsTable.Columns.Add("Subcategory")
            resultsTable.Columns.Add("Group_Name")
            resultsTable.Columns.Add("Supplier")
            resultsTable.Columns.Add("Supplier_Ref_No.")
            resultsTable.Columns.Add("Comments")
            resultsTable.Columns.Add("Request_ID")
            resultsTable.Columns.Add("Requested_by")
            resultsTable.Columns.Add("Request_Date")
            resultsTable.Columns.Add("Department")
            resultsTable.Columns.Add("UK_Nominal_Code")
            resultsTable.Columns.Add("UK_Cost_Center")
            resultsTable.Columns.Add("Monday_ID")
            resultsTable.Columns.Add("Manager_Approval")
            resultsTable.Columns.Add("Manager_Approval_Date")
            resultsTable.Columns.Add("Final_Approval")
            resultsTable.Columns.Add("Final_Approval_Date")

            For Each dr As DataRow In dtable.Rows

                Dim row As DataRow = resultsTable.NewRow()

                row.Item("Lasermet_Part_Num") = dr(0)
                row.Item("Lasermet_Drawing_No") = dr(11)
                row.Item("Location") = dr(26)
                row.Item("Warehouse") = dr(25)
                row.Item("Description") = dr(1)
                row.Item("Specifications") = dr(2)
                row.Item("Manufacturer_Part_No.") = dr(21)
                row.Item("Category") = dr(6)
                row.Item("Subcategory") = dr(7)
                row.Item("Group_Name") = dr(8)
                row.Item("Supplier") = dr(20)
                row.Item("Supplier_Ref_No.") = dr(22)
                row.Item("Comments") = dr(3)
                row.Item("Request_ID") = dr(9)
                row.Item("Requested_by") = dr(10)
                row.Item("Request_Date") = dr(5)
                row.Item("Department") = dr(12)
                row.Item("UK_Nominal_Code") = dr(16)
                row.Item("UK_Cost_Center") = dr(17)
                row.Item("Monday_ID") = dr(13)
                row.Item("Manager_Approval") = dr(14)
                row.Item("Manager_Approval_Date") = dr(18)
                row.Item("Final_Approval") = dr(15)
                row.Item("Final_Approval_Date") = dr(19)

                resultsTable.Rows.Add(row)

            Next

            Dim allRows As DataColumn = resultsTable.Columns.Add("_AllRows")

            For Each dr As DataRow In resultsTable.Rows

                Dim sb As New StringBuilder

                For i = 0 To resultsTable.Columns.Count - 1
                    sb.Append(dr(i).ToString())
                    sb.Append("\t")
                Next

                dr(allRows) = sb.ToString()

            Next

            resultsTable.TableName = "Parts for Approval"

            dgvSearchResults.DataSource = resultsTable
            dgvSearchResults.Columns(0).HeaderText = "Lasermet Part No."
            dgvSearchResults.Columns(1).HeaderText = "Lasermet Drawing No."
            dgvSearchResults.Columns(2).HeaderText = "Location"
            dgvSearchResults.Columns(3).HeaderText = "Warehouse"
            dgvSearchResults.Columns(4).HeaderText = "Description"
            dgvSearchResults.Columns(5).HeaderText = "Specifications"
            dgvSearchResults.Columns(6).HeaderText = "Manufacturer Part No."
            dgvSearchResults.Columns(7).HeaderText = "Category"
            dgvSearchResults.Columns(8).HeaderText = "Subcategory"
            dgvSearchResults.Columns(9).HeaderText = "Group Name"
            dgvSearchResults.Columns(10).HeaderText = "Supplier"
            dgvSearchResults.Columns(11).HeaderText = "Supplier Ref. No."
            dgvSearchResults.Columns(12).HeaderText = "Comments"
            dgvSearchResults.Columns(13).Visible = False 'Hide request ID column
            dgvSearchResults.Columns(14).HeaderText = "Requested By"
            dgvSearchResults.Columns(15).HeaderText = "Request Date"
            dgvSearchResults.Columns(16).HeaderText = "Department"
            dgvSearchResults.Columns(17).HeaderText = "UK Nominal Code"
            dgvSearchResults.Columns(18).HeaderText = "UK Cost Center"
            dgvSearchResults.Columns(19).Visible = False 'Hide Monday_ID column
            dgvSearchResults.Columns(20).HeaderText = "Manager Approval"
            dgvSearchResults.Columns(21).HeaderText = "Manager Approval Date"
            dgvSearchResults.Columns(22).HeaderText = "Final Approval"
            dgvSearchResults.Columns(23).HeaderText = "Final Approval Date"

            dgvSearchResults.Columns(24).Visible = False


            Dim btnApprove As New DataGridViewButtonColumn
            Dim btnDeny As New DataGridViewButtonColumn
            Dim btnrequestInfo As New DataGridViewButtonColumn

            btnApprove.HeaderText = "Approve"
            btnDeny.HeaderText = "Deny"
            btnrequestInfo.HeaderText = "Request for More Info"

            btnApprove.Text = "Approve"
            btnDeny.Text = "Deny"
            btnrequestInfo.Text = "Request for More Info"

            btnApprove.Name = "btnApprove"
            btnDeny.Name = "btnDeny"
            btnrequestInfo.Name = "btnrequestInfo"

            btnApprove.UseColumnTextForButtonValue = True
            btnDeny.UseColumnTextForButtonValue = True
            btnrequestInfo.UseColumnTextForButtonValue = True

            dgvSearchResults.Columns.Add(btnApprove)
            dgvSearchResults.Columns.Add(btnDeny)
            dgvSearchResults.Columns.Add(btnrequestInfo)

            For Each c As DataGridViewColumn In dgvSearchResults.Columns
                c.ReadOnly = True
            Next

            For i = 0 To dgvSearchResults.Columns.Count - 1

                dgvSearchResults.Columns(i).DefaultCellStyle.WrapMode = DataGridViewTriState.True

            Next

            dgvSearchResults.Refresh()
            ToolStripStatusLabel1.Text = $"{dgvSearchResults.Rows.Count} part request for approval"

        Catch ex As Exception

            MessageBox.Show($"Exception thrown at SearchDB.populateResultsDGV:{Environment.NewLine}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            pcon.Close()

        End Try

    End Function

    '================================================================================
    'SUBROUTINE   : tbSearchKeyword_TextChanged
    'DESCRIPTION  : Changes the current search text.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '================================================================================
    Private Sub tbSearchKeyword_TextChanged(sender As Object, e As EventArgs) Handles tbSearchKeyword.TextChanged

        Dim dt As DataTable = dgvSearchResults.DataSource

        dt.DefaultView.RowFilter = String.Format("_AllRows like '%{0}%'", tbSearchKeyword.Text.Trim())
        dgvSearchResults.Refresh()

    End Sub

    '================================================================================
    'SUBROUTINE   : btnBack_Click
    'DESCRIPTION  : Returns to the dashboard based on the type of user account.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '================================================================================
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
                InventoryAdminDashboard.Show()

            Case "Gen. Manager"
                Me.Close()
                InventoryAdminDashboard.Show()

            Case "General User"
                Me.Close()
                GeneralUserDashboard.Show()
        End Select
    End Sub

    '================================================================================
    'SUBROUTINE   : dgvSearchResults_CellContentClick
    'DESCRIPTION  : Display DataGridView results based on the dashboard option clicked.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '================================================================================
    'note: much better if the option-specific windows are divided into their own separate modules
    Private Sub dgvSearchResults_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchResults.CellContentClick

        Dim sendergrid = DirectCast(sender, DataGridView)

        'variables for parts requests

        Dim partNo As String
        Dim partDesc As String
        Dim partSpecs As String
        Dim partCategory As String
        Dim partSubcategory As String
        Dim partGroup As String
        Dim partcomments As String
        Dim partRequester As String
        Dim partRequestID As Integer
        'change data type of the current stock variable here (originally Integer)
        Dim partStockCount As String
        Dim partDrawingNo As String
        Dim partDepartment As String
        Dim monday_id As String
        Dim UKNominalCode As String
        Dim UKCostCenter As String
        Dim supplier As String
        Dim mpn As String
        Dim srn As String
        Dim warehouse As String
        Dim location As String

        'variables for account requests

        Dim username As String
        Dim password As String
        Dim user_email As String
        Dim account_type As String
        Dim firstname As String
        Dim surname As String
        Dim department As String

        If dgvSearchResults.DataSource.TableName = "Parts for Approval" Then

            For i = 0 To sendergrid.Columns.Count - 1

                Select Case sendergrid.Columns(i).HeaderText
                    Case "Lasermet Part No."
                        partNo = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "Description"
                        partDesc = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "Specifications"
                        partSpecs = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "Category"
                        partCategory = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "Subcategory"
                        partSubcategory = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "Group Name"
                        partGroup = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "Comments"
                        partcomments = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "Requested By"
                        partRequester = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "Request_ID"
                        partRequestID = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "Lasermet Drawing No."
                        If Not IsDBNull(sendergrid.CurrentRow.Cells(i).Value.ToString) Then
                            partDrawingNo = sendergrid.CurrentRow.Cells(i).Value.ToString
                        Else
                            partDrawingNo = "N/A"
                        End If
                    Case "Department"
                        If IsDBNull(sendergrid.CurrentRow.Cells(i).Value) = False Then
                            partDepartment = sendergrid.CurrentRow.Cells(i).Value.ToString
                        Else
                            partDepartment = "N/A"
                        End If

                    Case "Monday_ID"
                        monday_id = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "UK Nominal Code"
                        UKNominalCode = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "UK Cost Center"
                        UKCostCenter = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "Supplier"
                        supplier = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "Manufacturer Part No."
                        mpn = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "Supplier Ref. No."
                        srn = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "Location"
                        location = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "Warehouse"
                        warehouse = sendergrid.CurrentRow.Cells(i).Value.ToString
                End Select

            Next

            If TypeOf sendergrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then

                If sendergrid.Columns(e.ColumnIndex).HeaderText = "Approve" Then

                    Dim confirmApproval As DialogResult = MessageBox.Show("Would you like to review and update this request before approving?", "Confirm approval", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

                    If confirmApproval = DialogResult.Yes Then
                        UpdateForm.populateUpdateForm(partNo, partDesc, partSpecs, partCategory, partSubcategory, partGroup, partcomments, partStockCount, partDrawingNo, partDepartment, partRequestID, partRequester, monday_id, UKNominalCode, UKCostCenter, location, warehouse, supplier, mpn, srn)
                        UpdateForm.btnUpdate.Text = "Approve"
                        Me.Close()
                        UpdateForm.Show()
                    ElseIf confirmApproval = DialogResult.No Then
                        approvePart(partNo, partDesc, partSpecs, partCategory, partSubcategory, partGroup, partcomments, partRequester, login.username, partRequestID, partDrawingNo, partDepartment, monday_id, UKNominalCode, UKCostCenter, warehouse, location,, ToolStripStatusLabel1, supplier, mpn, srn)
                    End If



                ElseIf sendergrid.Columns(e.ColumnIndex).HeaderText = "Deny" Then

                    Dim denyOptions As DialogResult = MessageBox.Show($"Would you like to leave a comment before proceeding?", $"Deny Request for {partNo} by {partRequester}", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

                    If denyOptions = DialogResult.Yes Then
                        RequestForMoreInfoOrDeny.getRequestInfo(monday_id, partNo, partDrawingNo, partDesc, partSpecs, partCategory, partSubcategory, partGroup, UKNominalCode, UKCostCenter, partRequestID, partRequester, warehouse, location, supplier, mpn, srn)
                        RequestForMoreInfoOrDeny.Text = "Deny Part Request"
                        RequestForMoreInfoOrDeny.btnUpdate.Text = "Deny"
                        Me.Close()
                        RequestForMoreInfoOrDeny.Show()

                    ElseIf denyOptions = DialogResult.No Then

                        denyPart(partNo, partRequestID, partRequester, monday_id, partDrawingNo, partDesc, partSpecs, partCategory, partSubcategory, partGroup, UKNominalCode, UKCostCenter, location, warehouse, supplier, mpn, srn,,, ToolStripStatusLabel1)

                    End If


                ElseIf sendergrid.Columns(e.ColumnIndex).HeaderText = "Request for More Info" Then

                    RequestForMoreInfoOrDeny.getRequestInfo(monday_id, partNo, partDrawingNo, partDesc, partSpecs, partCategory, partSubcategory, partGroup, UKNominalCode, UKCostCenter, partRequestID, partRequester, warehouse, location, supplier, mpn, srn)
                    RequestForMoreInfoOrDeny.Text = "Request for More Information"
                    Me.Close()
                    RequestForMoreInfoOrDeny.Show()

                End If

            End If

        ElseIf dgvSearchResults.DataSource.TableName = "Accounts Requests" Then

            For i = 0 To sendergrid.Columns.Count - 1

                Select Case sendergrid.Columns(i).HeaderText
                    Case "Username"
                        username = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "Password"
                        password = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "E-mail"
                        user_email = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "First Name"
                        firstname = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "Surname"
                        surname = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "Account Type"
                        If sendergrid.CurrentRow.Cells(i).Value IsNot Nothing Then
                            account_type = sendergrid.CurrentRow.Cells(i).Value.ToString
                        Else
                            account_type = "N/A"
                        End If
                    Case "Location"
                        location = sendergrid.CurrentRow.Cells(i).Value.ToString()
                    Case "Department"
                        department = sendergrid.CurrentRow.Cells(i).Value.ToString()
                    Case "Monday ID"
                        monday_id = sendergrid.CurrentRow.Cells(i).Value.ToString()
                End Select

            Next

            Try

                If TypeOf sendergrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then

                    If sendergrid.Columns(e.ColumnIndex).HeaderText = "Approve" Then
                        If account_type = "N/A" Then
                            MessageBox.Show("Please assign a User Type to this account", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            approveUser(username, password, user_email, account_type, firstname, surname, location, department, monday_id)

                        End If
                    ElseIf sendergrid.Columns(e.ColumnIndex).HeaderText = "Deny" Then

                        denyUserRequest(username, password, user_email, firstname, surname)

                    End If

                End If

            Catch ex As Exception

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

        ElseIf dgvSearchResults.DataSource.TableName = "Inventory Table" Then

            For i = 0 To sendergrid.Columns.Count - 1

                Select Case sendergrid.Columns(i).HeaderText
                    Case "Lasermet Part No."
                        partNo = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "Description"
                        partDesc = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "Specifications"
                        If Not IsDBNull(sendergrid.CurrentRow.Cells(i).Value) Then
                            partSpecs = sendergrid.CurrentRow.Cells(i).Value.ToString
                        Else
                            partSpecs = "N/A"
                        End If
                    Case "Supplier"
                        supplier = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "Category"
                        partCategory = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "Subcategory"
                        partSubcategory = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "Group Name"
                        partGroup = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "Comments"
                        If Not IsDBNull(sendergrid.CurrentRow.Cells(i).Value) Then
                            partcomments = sendergrid.CurrentRow.Cells(i).Value.ToString
                        Else
                            partcomments = "N/A"
                        End If
                    Case "Requested By"
                        partRequester = sendergrid.CurrentRow.Cells(i).Value.ToString
                    Case "Request_ID"
                        partRequestID = sendergrid.CurrentRow.Cells(i).Value.ToString

                    Case "Current Stock"
                        If Not IsDBNull(sendergrid.CurrentRow.Cells(i).Value) Then
                            partStockCount = sendergrid.CurrentRow.Cells(i).Value
                        Else
                            partStockCount = 0
                        End If
                    Case "Lasermet Drawing No."
                        If Not IsDBNull(sendergrid.CurrentRow.Cells(i).Value.ToString) Then
                            partDrawingNo = sendergrid.CurrentRow.Cells(i).Value.ToString
                        Else
                            partDrawingNo = "N/A"
                        End If
                    Case "UK Nominal Code"
                        If Not IsDBNull(sendergrid.CurrentRow.Cells(i).Value.ToString) Then
                            UKNominalCode = sendergrid.CurrentRow.Cells(i).Value.ToString
                        Else
                            UKNominalCode = "N/A"
                        End If
                    Case "UK Cost Center"
                        If Not IsDBNull(sendergrid.CurrentRow.Cells(i).Value.ToString) Then
                            UKCostCenter = sendergrid.CurrentRow.Cells(i).Value.ToString
                        Else
                            UKCostCenter = "N/A"
                        End If
                    Case "Manufacturer Part No."
                        If Not IsDBNull(sendergrid.CurrentRow.Cells(i).Value.ToString) Then
                            mpn = sendergrid.CurrentRow.Cells(i).Value.ToString
                        Else
                            mpn = "N/A"
                        End If
                    Case "Supplier Ref. No."
                        If Not IsDBNull(sendergrid.CurrentRow.Cells(i).Value.ToString) Then
                            srn = sendergrid.CurrentRow.Cells(i).Value.ToString
                        Else
                            srn = "N/A"
                        End If
                    Case "Location"
                        If Not IsDBNull(sendergrid.CurrentRow.Cells(i).Value.ToString) Then
                            location = sendergrid.CurrentRow.Cells(i).Value.ToString
                        Else
                            location = "N/A"
                        End If
                    Case "Warehouse"
                        If Not IsDBNull(sendergrid.CurrentRow.Cells(i).Value.ToString) Then
                            warehouse = sendergrid.CurrentRow.Cells(i).Value.ToString
                        Else
                            warehouse = "N/A"
                        End If
                End Select

            Next

            If TypeOf sendergrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then

                If sendergrid.Columns(e.ColumnIndex).HeaderText = "Update Inventory Item" Then

                    UpdateForm.populateUpdateForm(partNo, partDesc, partSpecs, partCategory, partSubcategory, partGroup, partcomments, partStockCount, partDrawingNo, department, partRequestID, partRequester, monday_id, UKNominalCode, UKCostCenter, location, warehouse, supplier, mpn, srn)
                    UpdateForm.btnUpdate.Text = "Update"
                    Me.Close()
                    UpdateForm.Show()

                End If

            End If

        End If

    End Sub

    '================================================================================
    'SUBROUTINE   : denyUserRequest
    'DESCRIPTION  : Denies the user account request.
    'ARGUMENTS    : username, password, email, first_name, surname - String
    '================================================================================
    Private Sub denyUserRequest(username As String, password As String, email As String, first_name As String, surname As String)

        Call connectPostGre()

        Try

            pcm = pcon.CreateCommand()
            With pcm
                .CommandText = "DELETE FROM ""account_requests"" WHERE ""username"" = ? AND ""e-mail"" = ?;"
                .Parameters.Add("@username", Odbc.OdbcType.VarChar).Value = username
                .Parameters.Add("@e-mail", Odbc.OdbcType.VarChar).Value = email
            End With
            pcon.Open()
            pcm.ExecuteNonQuery()
            pcon.Close()
            MessageBox.Show($"Request to add {username} has been removed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If DialogResult.OK Then
                accountRequestsTable.Clear()
                dgvSearchResults.Columns.Clear()
                tableBindingSource.DataSource = Nothing
                dgvSearchResults.DataSource = Nothing
                populateAccountRequestsDGV()
            End If

        Catch ex As Exception
            MessageBox.Show("An error occured while approving the request", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            pcon.Close()
        End Try

    End Sub

    '================================================================================
    'SUBROUTINE   : approveUser
    'DESCRIPTION  : Approves the user account request.
    'ARGUMENTS    : username, password, email, user_type, first_name, surname, location, department, monday_id - String
    '================================================================================
    Private Sub approveUser(username As String, password As String,
                            email As String, user_type As String,
                            first_name As String, surname As String,
                            location As String, department As String, monday_id As String)

        Call connectPostGre()

        Try

            Dim pcm As New Odbc.OdbcCommand
            pcm = pcon.CreateCommand()


            With pcm
                .CommandText = "INSERT INTO ""users"" (""username"", ""password"", ""e-mail"", ""user_type"", ""first_name"", ""surname"", ""date_added"", ""approved_by"", ""location"", ""department"", ""monday_id"") VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
                .Parameters.Add("@username", Odbc.OdbcType.VarChar).Value = username
                .Parameters.Add("@password", Odbc.OdbcType.VarChar).Value = password
                .Parameters.Add("@e-mail", Odbc.OdbcType.VarChar).Value = email
                .Parameters.Add("@user_type", Odbc.OdbcType.VarChar).Value = user_type
                .Parameters.Add("@first_name", Odbc.OdbcType.VarChar).Value = first_name
                .Parameters.Add("@surname", Odbc.OdbcType.VarChar).Value = surname
                .Parameters.Add("@date_added", Odbc.OdbcType.VarChar).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                .Parameters.Add("@approved_by", Odbc.OdbcType.VarChar).Value = login.username
                .Parameters.Add("@location", Odbc.OdbcType.VarChar).Value = location
                .Parameters.Add("@department", Odbc.OdbcType.VarChar).Value = department
                .Parameters.Add("@monday_id", Odbc.OdbcType.VarChar).Value = monday_id
            End With

            pcon.Open()
            pcm.ExecuteNonQuery()
            pcon.Close()

            'Check if approval was successful

            Try

                Dim sqlQuery As String = "SELECT * from ""users"";"
                pda = New Odbc.OdbcDataAdapter()
                Dim pdcb As New Odbc.OdbcCommandBuilder(pda)
                pda.SelectCommand = New Odbc.OdbcCommand(sqlQuery, pcon)
                Dim dtable As New DataTable()
                Dim emails As New List(Of String)
                pcon.Open()
                pda.Fill(dtable)
                pcon.Close()

                For Each dr As DataRow In dtable.Rows
                    emails.Add(dr(2))
                Next

                If emails.IndexOf(email) < 0 Then
                    Throw New System.Exception("An error occured while approving this request")
                Else
                    pcm = pcon.CreateCommand()
                    With pcm
                        .CommandText = "DELETE FROM ""account_requests"" WHERE ""username"" = ? AND ""e-mail"" = ?;"
                        .Parameters.Add("@username", Odbc.OdbcType.VarChar).Value = username
                        .Parameters.Add("@e-mail", Odbc.OdbcType.VarChar).Value = email
                    End With
                    pcon.Open()
                    pcm.ExecuteNonQuery()
                    pcon.Close()
                    MessageBox.Show($"Request to add {username} has been approved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If DialogResult.OK Then
                        accountRequestsTable.Clear()
                        dgvSearchResults.Columns.Clear()
                        tableBindingSource.DataSource = Nothing
                        dgvSearchResults.DataSource = Nothing
                        populateAccountRequestsDGV()
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show("An error occured while approving the request", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                pcon.Close()
            End Try

        Catch ex As Exception
            MessageBox.Show("An error occured while approving the request", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            pcon.Close()
        End Try

    End Sub

    '================================================================================
    'SUBROUTINE   : denyPart
    'DESCRIPTION  : Denies the part number request.
    'ARGUMENTS    : partNo, request_id, requester, monday_id, dwg_no, description,
    '               specs, category, subcategory, group_name, revCC, issCC, location,
    '               warehouse, supplier, mpn, srn, comments - String
    '               form      - Form
    '               statusbar - ToolStripStatusLabel
    '================================================================================
    Public Async Sub denyPart(ByVal partNo As String, ByVal request_id As String,
                              requester As String, monday_id As String,
                              dwg_no As String, description As String,
                              specs As String, category As String,
                              subcategory As String, group_name As String,
                              revCC As String, issCC As String,
                              location As String, warehouse As String,
                              supplier As String, mpn As String,
                              srn As String, Optional comments As String = "Part request denied",
                              Optional form As Form = Nothing, Optional statusbar As ToolStripStatusLabel = Nothing)

        Try

            If statusbar IsNot Nothing Then
                statusbar.Text = "Updating request status...."
            End If

            Dim mondayUpdate = Await updateStatusOnMonday(monday_id, "Denied", partNo, dwg_no, description, specs, category, subcategory, group_name, revCC, issCC, location, warehouse, comments, ToolStripStatusLabel1,,, supplier, mpn, srn)

            If mondayUpdate(0) = "success" Then

                If statusbar IsNot Nothing Then
                    statusbar.Text = mondayUpdate(1)
                End If

                Try

                    If form IsNot Nothing Then
                        resultsTable.Clear()
                        dgvSearchResults.Columns.Clear()
                        populateApprovalDGV()
                        form.Close()
                        Me.Show()
                    Else
                        resultsTable.Clear()
                        dgvSearchResults.Columns.Clear()
                        tableBindingSource.DataSource = Nothing
                        dgvSearchResults.DataSource = Nothing
                        populateApprovalDGV()
                    End If

                Catch ex As Exception
                    MessageBox.Show("An error occured while approving the request", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    pcon.Close()
                End Try

            End If

            resultsTable.Clear()
            dgvSearchResults.Columns.Clear()
            tableBindingSource.DataSource = Nothing
            dgvSearchResults.DataSource = Nothing
            populateApprovalDGV()

        Catch ex As Exception
            Console.WriteLine("SearchDB.denyPart Exception: " & ex.Message)
            MessageBox.Show("Exception caught. See console", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.Message)

        End Try

    End Sub

    '================================================================================
    'SUBROUTINE   : approvePart
    'DESCRIPTION  : Approves the part number request.
    'ARGUMENTS    : partNo, description, specifications, category, subcategory, group_name,
    '               comments, requester, approver, request_id, drawingno, department, monday_id,
    '               revCC, issCC, warehouse, location, supplier, mpn, srn - String
    '               form      - Form
    '               statusbar - ToolStripStatusLabel
    '================================================================================
    Public Async Sub approvePart(ByVal partNo As String,
                                 ByVal description As String,
                                 ByVal specifications As String,
                                 ByVal category As String,
                                 ByVal subcategory As String,
                                 ByVal group_name As String,
                                 ByVal comments As String,
                                 ByVal requester As String,
                                 ByVal approver As String,
                                 request_id As String,
                                 drawingno As String,
                                 department As String,
                                 monday_id As String,
                                 revCC As String,
                                 issCC As String,
                                 warehouse As String,
                                 location As String,
                                 Optional form As Form = Nothing,
                                 Optional statusbar As ToolStripStatusLabel = Nothing,
                                 Optional supplier As String = "",
                                 Optional mpn As String = "",
                                 Optional srn As String = "")

        If checkForDuplicates(description) = False Then

            'error is somewhere starting here
            If statusbar IsNot Nothing Then
                statusbar.Text = "Updating status on Monday.com...."
            End If
            ToolStripStatusLabel1.Text = "Updating status on Monday.com...."

            Console.WriteLine("Passed here at statusbar If Condition")

            Dim mondayApproval As String()

            Select Case login.account_type

                Case "Inventory Admin"

                    mondayApproval = Await updateStatusOnMonday(monday_id, "Approved", partNo, drawingno, description, specifications, category, subcategory, group_name, revCC, issCC, location, warehouse, comments, ToolStripStatusLabel1, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), supplier, mpn, srn)

                Case Else

                    mondayApproval = Await updateStatusOnMonday(monday_id, "Approved", partNo, drawingno, description, specifications, category, subcategory, group_name, revCC, issCC, location, warehouse, comments, ToolStripStatusLabel1, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), supplier, mpn, srn)

            End Select

            Console.WriteLine("Passed here at Select Case")

            If mondayApproval(0) = "success" Then

                If statusbar IsNot Nothing Then
                    statusbar.Text = mondayApproval(1)
                End If
                Console.WriteLine("Passed here at mondayApproval If condition")


                Try

                    If form IsNot Nothing Then
                        resultsTable.Clear()
                        dgvSearchResults.Columns.Clear()
                        populateApprovalDGV()
                        form.Close()
                        Me.Show()
                    Else
                        resultsTable.Clear()
                        dgvSearchResults.Columns.Clear()
                        tableBindingSource.DataSource = Nothing
                        dgvSearchResults.DataSource = Nothing
                        populateApprovalDGV()
                    End If

                Catch ex As Exception
                    Console.WriteLine("SearchDB.approvePart Exception: " & ex.Message)
                    MessageBox.Show("An error occured while approving the request", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    pcon.Close()
                End Try

            End If

        Else
            MessageBox.Show("A part with the same description already exists. Kindly check the database before proceeding", "Duplicate part found", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If DialogResult.OK Then

                If form IsNot Nothing Then
                    populateApprovalDGV()
                    form.Close()
                    Me.Show()
                Else
                    resultsTable.Clear()
                    dgvSearchResults.Columns.Clear()
                    tableBindingSource.DataSource = Nothing
                    dgvSearchResults.DataSource = Nothing
                    populateApprovalDGV()
                End If

            End If


        End If



    End Sub

    '================================================================================
    'SUBROUTINE   : populateRequestStatus
    'DESCRIPTION  : Populates the Request Status / Inventory requests.
    'ARGUMENTS    : None
    '================================================================================
    Public Sub populateRequestStatus()

        panelSearchFilters.Visible = False
        panelSearchFilters.Enabled = False
        Me.Size = New Size(800, 600)
        dgvSearchResults.Size = New Size(768, 448)
        dgvSearchResults.Location = New Point(8, 42)


        Me.Text = "New Inventory Requests"

        Call connectPostGre()

        resultsTable.Columns.Clear()
        ToolStripStatusLabel1.Text = "(̿▀̿ ̿Ĺ̯̿̿▀̿ ̿)̄"

        Try

            Dim partsRequests As New DataTable()

            Dim sqlQuery As String = $"SELECT * FROM ""LasermetPARTS_forApproval"" WHERE ""requested_by"" = '{login.username}'"

            pda = New Odbc.OdbcDataAdapter()
            Dim pdcb As New Odbc.OdbcCommandBuilder(pda)
            pda.SelectCommand = New Odbc.OdbcCommand(sqlQuery, pcon)
            Dim dtable As New DataTable()

            pcon.Open()
            pda.Fill(dtable)
            pcon.Close()

            partsRequests.Columns.Add("Lasermet Part No.") '0
            partsRequests.Columns.Add("Lasermet Drawing / Mfg. No.") '11
            partsRequests.Columns.Add("Description") '1
            partsRequests.Columns.Add("Specifications") '2
            partsRequests.Columns.Add("Category") '6
            partsRequests.Columns.Add("Subcategory") '7
            partsRequests.Columns.Add("Group Name") '8
            partsRequests.Columns.Add("Date Requested") '5
            partsRequests.Columns.Add("Manager Approval") '14
            partsRequests.Columns.Add("Final Approval") '15
            partsRequests.Columns.Add("Comments") '3
            partsRequests.Columns.Add("Update Request")

            For Each dr As DataRow In dtable.Rows
                Dim row As DataRow = partsRequests.NewRow

                row.Item("Lasermet Part No.") = dr(0)
                row.Item("Lasermet Drawing / Mfg. No.") = dr(11)
                row.Item("Description") = dr(1)
                row.Item("Specifications") = dr(2)
                row.Item("Category") = dr(6)
                row.Item("Subcategory") = dr(7)
                row.Item("Group Name") = dr(8)
                row.Item("Date Requested") = dr(5)
                row.Item("Manager Approval") = dr(14)
                row.Item("Final Approval") = dr(15)
                row.Item("Comments") = dr(3)

                partsRequests.Rows.Add(row)

            Next

            Dim rowsCompiled As DataColumn = partsRequests.Columns.Add("_AllRows")



            For Each dr As DataRow In partsRequests.Rows
                Dim sb As New StringBuilder

                For i = 0 To partsRequests.Columns.Count - 1

                    If dr(i) IsNot Nothing Then

                        sb.Append(dr(i))
                        sb.Append("\t")

                    End If
                Next

                dr(rowsCompiled) = sb.ToString()

            Next


            dgvSearchResults.DataSource = partsRequests
            dgvSearchResults.Columns(dgvSearchResults.Columns("_AllRows").Index).Visible = False
            dgvSearchResults.Columns("Update Request").Visible = False


            Dim managerApproval As DataGridViewCell
            Dim finalApproval As DataGridViewCell

            Dim cellStyle As New DataGridViewCellStyle


            cellStyle.BackColor = Drawing.Color.FromArgb(176, 221, 232)
            cellStyle.Font = New Font(dgvSearchResults.DefaultCellStyle.Font, FontStyle.Bold)

            For Each row As DataGridViewRow In dgvSearchResults.Rows

                managerApproval = row.Cells(dgvSearchResults.Columns("Manager Approval").Index)
                finalApproval = row.Cells(dgvSearchResults.Columns("Final Approval").Index)

                If String.IsNullOrEmpty(managerApproval.Value.ToString) = False Then

                    Dim x As String = managerApproval.Value

                    If x = "Needs additional information" Then

                        row.Cells(dgvSearchResults.Columns("Update Request").Index).Value = "Update"
                        row.DefaultCellStyle = cellStyle
                        dgvSearchResults.Columns("Update Request").Visible = True

                    End If


                End If


                If String.IsNullOrEmpty(finalApproval.Value.ToString) = False Then

                    Dim x As String = finalApproval.Value

                    If x = "Needs additional information" Then

                        row.Cells(dgvSearchResults.Columns("Update Request").Index).Value = "Update"
                        row.DefaultCellStyle = cellStyle
                        dgvSearchResults.Columns("Update Request").Visible = True

                    End If


                End If

            Next


            For Each dgc As DataGridViewColumn In dgvSearchResults.Columns
                dgc.ReadOnly = True
            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            pcon.Close()
        End Try

    End Sub

    '================================================================================
    'SUBROUTINE   : chbCategory_CheckedChanged
    'DESCRIPTION  : Changes the text for the category filters.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '================================================================================
    Private Sub chbCategory_CheckedChanged(sender As Object, e As EventArgs) Handles chbCategory.CheckedChanged

        If chbCategory.Checked = True Then
            tbCategoryFilter.Enabled = True
            tbCategoryFilter.PromptText = ""
        Else
            tbCategoryFilter.Enabled = False
            tbCategoryFilter.Text = String.Empty
            tbCategoryFilter.PromptText = "Filter by Category"
        End If

    End Sub

    '================================================================================
    'SUBROUTINE   : chbSubcategory_CheckedChanged
    'DESCRIPTION  : Changes the text for the subcategory filters.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '================================================================================
    Private Sub chbSubcategory_CheckedChanged(sender As Object, e As EventArgs) Handles chbSubcategory.CheckedChanged

        If chbSubcategory.Checked = True Then
            tbSubcategoryFilter.Enabled = True
            tbSubcategoryFilter.PromptText = ""
        Else
            tbSubcategoryFilter.Enabled = False
            tbSubcategoryFilter.Text = String.Empty
            tbSubcategoryFilter.PromptText = "Filter by Subcategory"
        End If

    End Sub

    '================================================================================
    'SUBROUTINE   : chbGroupName_CheckedChanged
    'DESCRIPTION  : Changes the text for the group name filters.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '================================================================================
    Private Sub chbGroupName_CheckedChanged(sender As Object, e As EventArgs) Handles chbGroupName.CheckedChanged

        If chbGroupName.Checked = True Then
            tbFilterbyGroupName.Enabled = True
            tbFilterbyGroupName.PromptText = ""
        Else
            tbFilterbyGroupName.Enabled = False
            tbFilterbyGroupName.Text = String.Empty
            tbFilterbyGroupName.PromptText = "Filter by Group Name"
        End If

    End Sub

    '================================================================================
    'SUBROUTINE   : chbDescription_CheckedChanged
    'DESCRIPTION  : Changes the text for the description filters.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '================================================================================
    Private Sub chbDescription_CheckedChanged(sender As Object, e As EventArgs) Handles chbDescription.CheckedChanged

        If chbDescription.Checked = True Then
            tbFilterbyDescription.Enabled = True
            tbFilterbyDescription.PromptText = ""
        Else
            tbFilterbyDescription.Enabled = False
            tbFilterbyDescription.Text = String.Empty
            tbFilterbyDescription.PromptText = "Filter by Description"
        End If

    End Sub

    '================================================================================
    'SUBROUTINE   : chbSpecs_CheckedChanged
    'DESCRIPTION  : Changes the text for the specification filters.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '================================================================================
    Private Sub chbSpecs_CheckedChanged(sender As Object, e As EventArgs) Handles chbSpecs.CheckedChanged

        If chbSpecs.Checked = True Then
            tbFilterbySpecs.Enabled = True
            tbFilterbySpecs.PromptText = ""
        Else
            tbFilterbySpecs.Enabled = False
            tbFilterbySpecs.Text = String.Empty
            tbFilterbySpecs.PromptText = "Filter by Specifications"
        End If

    End Sub

    '================================================================================
    'SUBROUTINE   : chbPartNo_CheckedChanged
    'DESCRIPTION  : Changes the text for the part number filters.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '================================================================================
    Private Sub chbPartNo_CheckedChanged(sender As Object, e As EventArgs) Handles chbPartNo.CheckedChanged

        If chbPartNo.Checked = True Then
            tbFilterByPartNo.Enabled = True
            tbFilterByPartNo.PromptText = ""
        Else
            tbFilterByPartNo.Enabled = False
            tbFilterByPartNo.Text = String.Empty
            tbFilterByPartNo.PromptText = "Filter by Part No."
        End If

    End Sub

    '================================================================================
    'SUBROUTINE   : chbFilterByMFGorDWG_CheckedChanged
    'DESCRIPTION  : Changes the text for the manufacturing and drawing number filters.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '===============================================================================
    Private Sub chbFilterByMFGorDWG_CheckedChanged(sender As Object, e As EventArgs) Handles chbFilterByMFGorDWG.CheckedChanged

        If chbFilterByMFGorDWG.Checked = True Then
            tbFilterByMfgOrDwg.Enabled = True
            tbFilterByMfgOrDwg.PromptText = ""
        Else
            tbFilterByMfgOrDwg.Enabled = False
            tbFilterByMfgOrDwg.Text = String.Empty
            tbFilterByMfgOrDwg.PromptText = "Filter by Mfg. / Drawing No."
        End If

    End Sub

    '================================================================================
    'SUBROUTINE   : chbFilterByDept_CheckedChanged
    'DESCRIPTION  : Changes the text for the Department filters.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '===============================================================================
    Private Sub chbFilterByDept_CheckedChanged(sender As Object, e As EventArgs) Handles chbFilterByDept.CheckedChanged

        If chbFilterByDept.Checked = True Then
            tbFilterbyDept.Enabled = True
            tbFilterbyDept.PromptText = ""
        Else
            tbFilterbyDept.Enabled = False
            tbFilterbyDept.Text = String.Empty
            tbFilterbyDept.PromptText = "Filter by Department"
        End If

    End Sub

    '================================================================================
    'SUBROUTINE   : filterDB
    'DESCRIPTION  : Filters the database based on the filter selected.
    'ARGUMENTS    : None
    '===============================================================================
    Private Sub filterDB()
        Dim sb As StringBuilder = New StringBuilder()
        Dim activeFilters As New List(Of String)

        For Each c As Control In gbFilters.Controls
            If c.GetType = GetType(MetroFramework.Controls.MetroTextBox) Then
                If c.Enabled = True And String.IsNullOrWhiteSpace(c.Text) = False Then
                    If c.Name = "tbCategoryFilter" Then

                        sb.AppendFormat("Category like '%{0}%' and ", c.Text)


                    ElseIf c.Name = "tbSubcategoryFilter" Then

                        sb.AppendFormat("Subcategory like '%{0}%' and ", c.Text)


                    ElseIf c.Name = "tbFilterbyGroupName" Then

                        sb.AppendFormat("Group_Name like '%{0}%' and ", c.Text)

                    ElseIf c.Name = "tbFilterByPartNo" Then

                        sb.AppendFormat("Lasermet_Part_Num like '%{0}%' and ", c.Text)

                    ElseIf c.Name = "tbFilterbyDescription" Then

                        sb.AppendFormat("Description like '%{0}%' and ", c.Text)


                    ElseIf c.Name = "tbFilterbySpecs" Then

                        sb.AppendFormat("Specifications like '%{0}%' and ", c.Text)


                    ElseIf c.Name = "tbFilterByMfgorDwg" Then

                        sb.AppendFormat("Lasermet_Drawing_No like '%{0}%' and ", c.Text)


                    ElseIf c.Name = "tbFilterbyDept" Then

                        sb.AppendFormat("Department like '%{0}%' and ", c.Text)

                    ElseIf c.Name = "tbSearchAll" Then

                        sb.AppendFormat("_AllRows like '%{0}%' and  ", c.Text)

                    End If
                End If
            End If
        Next



        Dim dt As DataTable = dgvSearchResults.DataSource
        Dim query As String = sb.ToString().Trim
        If query.Length >= 5 Then

            query = query.Remove(query.Length - 4)

        Else
            query = ""
        End If

        dt.DefaultView.RowFilter = query.Trim
        ToolStripStatusLabel1.Text = $"{dgvSearchResults.Rows.Count} parts found"
        dgvSearchResults.Refresh()
    End Sub

    '===============================================================================
    'SUBROUTINE   : tbCategoryFilter_TextChanged
    'DESCRIPTION  : Filters the database based on the category.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '===============================================================================
    Private Sub tbCategoryFilter_TextChanged(sender As Object, e As EventArgs) Handles tbCategoryFilter.TextChanged

        filterDB()

    End Sub

    '===============================================================================
    'SUBROUTINE   : tbSubcategoryFilter_TextChanged
    'DESCRIPTION  : Filters the database based on the subcategory.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '===============================================================================
    Private Sub tbSubcategoryFilter_TextChanged(sender As Object, e As EventArgs) Handles tbSubcategoryFilter.TextChanged

        filterDB()

    End Sub

    '===============================================================================
    'SUBROUTINE   : tbFilterbyGroupName_TextChanged
    'DESCRIPTION  : Filters the database based on the group name.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '===============================================================================
    Private Sub tbFilterbyGroupName_TextChanged(sender As Object, e As EventArgs) Handles tbFilterbyGroupName.TextChanged

        filterDB()

    End Sub

    '===============================================================================
    'SUBROUTINE   : tbFilterbyDescription_TextChanged
    'DESCRIPTION  : Filters the database based on the description.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '===============================================================================
    Private Sub tbFilterbyDescription_TextChanged(sender As Object, e As EventArgs) Handles tbFilterbyDescription.TextChanged

        filterDB()

    End Sub

    '===============================================================================
    'SUBROUTINE   : tbFilterbySpecs_TextChanged
    'DESCRIPTION  : Filters the database based on the specifications.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '===============================================================================
    Private Sub tbFilterbySpecs_TextChanged(sender As Object, e As EventArgs) Handles tbFilterbySpecs.TextChanged

        filterDB()

    End Sub

    '===============================================================================
    'SUBROUTINE   : tbFilterByPartNo_TextChanged
    'DESCRIPTION  : Filters the database based on the part numbers.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '===============================================================================
    Private Sub tbFilterByPartNo_TextChanged(sender As Object, e As EventArgs) Handles tbFilterByPartNo.TextChanged

        filterDB()

    End Sub

    '===============================================================================
    'SUBROUTINE   : tbFilterByMfgOrDwg_TextChanged
    'DESCRIPTION  : Filters the database based on the manufacturing or drawing number.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '===============================================================================
    Private Sub tbFilterByMfgOrDwg_TextChanged(sender As Object, e As EventArgs) Handles tbFilterByMfgOrDwg.TextChanged

        filterDB()

    End Sub

    '===============================================================================
    'SUBROUTINE   : tbFilterbyDept_TextChanged
    'DESCRIPTION  : Filters the database based on the department.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '===============================================================================
    Private Sub tbFilterbyDept_TextChanged(sender As Object, e As EventArgs) Handles tbFilterbyDept.TextChanged

        filterDB()

    End Sub

    '===============================================================================
    'SUBROUTINE   : tbSearchAll_TextChanged
    'DESCRIPTION  : Filters the database by full.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '===============================================================================
    Private Sub tbSearchAll_TextChanged(sender As Object, e As EventArgs) Handles tbSearchAll.TextChanged

        filterDB()

    End Sub

    '===============================================================================
    'SUBROUTINE   : SearchDB_Load
    'DESCRIPTION  : Loads the SearchDB window.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '===============================================================================
    Private Sub SearchDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = StartPosition.CenterScreen
        Me.Size = New Size(800, 600)

        For i = 0 To dgvSearchResults.Columns.Count - 1

            dgvSearchResults.Columns(i).DefaultCellStyle.WrapMode = DataGridViewTriState.True

        Next
    End Sub

    '===============================================================================
    'SUBROUTINE   : btnBack2_Click
    'DESCRIPTION  : Loads the dashboard based on the user account.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '===============================================================================
    Private Sub btnBack2_Click(sender As Object, e As EventArgs) Handles btnBack2.Click

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

            Case "Gen. Manager"
                Me.Close()
                InventoryAdminDashboard.Show()

            Case "General User"
                Me.Close()
                GeneralUserDashboard.Show()
        End Select

    End Sub

    '===============================================================================
    'SUBROUTINE   : btnExport_Click
    'DESCRIPTION  : Selects the file directory to save the csv file during importing.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '===============================================================================
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        selectDirectory()

    End Sub

    '===============================================================================
    'SUBROUTINE   : selectDirectory
    'DESCRIPTION  : Selects the file directory to save the csv file during importing.
    'ARGUMENTS    : None
    '===============================================================================
    Private Sub selectDirectory()
        Dim selectFolder As DialogResult = FolderBrowserDialog1.ShowDialog()
        FolderBrowserDialog1.Description = "Select where you want to save your CSV file."
        If selectFolder.OK Then
            csvSavepath = FolderBrowserDialog1.SelectedPath

            If csvSavepath <> "" Or csvSavepath IsNot Nothing Or csvSavepath.Length >= 3 Then
                Dim filename As String = csvSavepath + "\" + DateTime.Now.ToString("yyyyMMdd_HHmmss_") + ("MasterList.csv")
                dtTableToCSV(inventoryTable, filename)
            Else
                MessageBox.Show("Please select a folder to save your file in.", "No folder selected", MessageBoxButtons.OK)
            End If

        ElseIf selectFolder.Cancel Then
            MessageBox.Show($"Your file will be saved on {Application.StartupPath}", "Select Directory", MessageBoxButtons.OK)
            If DialogResult.OK Then
                csvSavepath = Application.StartupPath + "\" + DateTime.Now.ToString("yyyyMMdd_HHmmss_") + ("YTD.csv")
            End If
        End If

        If csvSavepath <> "" Or csvSavepath.Length > 3 Then

            btnExport.Enabled = True

        End If

    End Sub

    '===============================================================================
    'SUBROUTINE   : dtTableToCSV
    'DESCRIPTION  : Imports the directory table to CSV file.
    'ARGUMENTS    : dt       - Datatable
    '               filename - String
    '               headers  - Boolean, optional
    '               delim    - String
    '===============================================================================
    Private Function dtTableToCSV(dt As DataTable, filename As String,
                                  Optional headers As Boolean = True,
                                  Optional delim As String = ",")
        Try
            btnExport.Enabled = False
            Dim txt As String
            Dim csvWriter As IO.StreamWriter = IO.File.AppendText(filename)
            Dim fileloc As String = filename
            Dim n = 0
            If IO.File.Exists(filename) Then

                Dim CSVcolumns As String() = {"Stock item code", "AnalysisValue\1", "Stock item name", "Stock item description", "Product group", "Tax code", "Issues - account number", "Revenue - account number", "Allow Sales order", "BOM Details", "Revenue - cost centre", "Issues - cost centre"}

                Dim CSVtable As New DataTable

                For i = 0 To CSVcolumns.Count - 1
                    CSVtable.Columns.Add(CSVcolumns(i))
                Next

                For Each dr As DataRow In dt.Rows

                    Dim row As DataRow = CSVtable.NewRow

                    row.Item("Stock item code") = dr(0)
                    row.Item("AnalysisValue\1") = dr(1)
                    row.Item("Stock item name") = dr(4)
                    row.Item("Stock item description") = dr(4)
                    row.Item("Product group") = "-"
                    row.Item("Tax code") = "-"
                    row.Item("Issues - account number") = dr(19)
                    row.Item("Revenue - account number") = "-"
                    row.Item("Allow Sales order") = "-"
                    row.Item("BOM Details") = "-"
                    row.Item("Revenue - cost centre") = "-"
                    row.Item("Issues - cost centre") = dr(20)

                    CSVtable.Rows.Add(row)

                Next

                If headers = True Then
                    For Each column As DataColumn In CSVtable.Columns
                        If n = 0 Then
                            txt += column.ColumnName
                        Else
                            txt += delim + column.ColumnName
                        End If
                        n += 1
                    Next
                End If
                txt += vbCrLf
                n = 0
                For Each row As DataRow In CSVtable.Rows
                    Dim line As String = ""

                    For Each column As DataColumn In CSVtable.Columns
                        line += delim & row(column.ColumnName).ToString()
                    Next
                    If dt.Rows.Count - 1 = n Then
                        txt += line.Substring(1)
                    Else
                        txt += line.Substring(1) & vbCrLf
                    End If
                    n += 1
                Next


            End If



            csvWriter.Write(txt)
            csvWriter.Close()
            Dim openCSV As DialogResult = MessageBox.Show($"File created at {fileloc}. Would you like to open the save folder?", "File created succesfully.", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If openCSV = DialogResult.Yes Then
                Process.Start("explorer.exe", csvSavepath)
            Else
                btnExport.Enabled = True
                csvSavepath = ""
            End If
        Catch ex As Exception
            MessageBox.Show("Please select a valid save directory", "Invalid save location.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If DialogResult.OK Then
                btnExport.Enabled = True
            End If
        End Try
    End Function
End Class