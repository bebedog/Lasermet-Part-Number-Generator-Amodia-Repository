Imports Newtonsoft.Json
Imports System.Threading


Public Class LasermetPNG

    Public categoriesTable As New DataTable
    Public partsTable As New DataTable

    Private Sub populateSubcategories(ByVal category As String)

        Dim subcategories As New List(Of String)

        For Each dr As DataRow In login.categoriesTable.Rows
            If dr(0) = category Then
                If dr(1) <> "N/A" Then
                    subcategories.Add(dr(1))
                Else
                    subcategories.Add("-")
                End If
            End If
        Next

        cbSubcategories.Items.AddRange(subcategories.Distinct.ToArray)
        cbSubcategories.Enabled = True
        lblSubcategory.Enabled = True
        cbSubcategories.SelectedIndex = 0
    End Sub

    Public Sub populateCategories(ByVal dept As String)

        categoriesTable.Columns.Clear()

        Dim categories As New AutoCompleteStringCollection
        Dim categoriesList As New List(Of String)
        categoriesTable.Columns.Add("category", GetType(System.String))
        categoriesTable.Columns.Add("subcategories", GetType(System.String))
        categoriesTable.Columns.Add("groupnames", GetType(System.String))
        categoriesTable.Columns.Add("category_no", GetType(System.String))
        categoriesTable.Columns.Add("department", GetType(System.String))

        Try

            For Each dr As DataRow In login.categoriesTable.Rows

                If dept = "All" Then

                    Dim row As DataRow = categoriesTable.NewRow()

                    categoriesList.Add(dr(0))
                    row.Item("category") = dr(0)
                    row.Item("subcategories") = dr(1)
                    row.Item("groupnames") = dr(2)
                    row.Item("category_no") = dr(3)
                    row.Item("department") = dr(4)

                    categoriesTable.Rows.Add(row)

                Else

                    If dr(4) = dept Then

                        Dim row As DataRow = categoriesTable.NewRow()

                        categoriesList.Add(dr(0))
                        row.Item("category") = dr(0)
                        row.Item("subcategories") = dr(1)
                        row.Item("groupnames") = dr(2)
                        row.Item("category_no") = dr(3)
                        row.Item("department") = dr(4)

                        categoriesTable.Rows.Add(row)

                    End If

                End If


            Next

            cbCategories.Items.AddRange(categoriesList.Distinct.ToArray)
            cbCategories.Enabled = True
            lblCategory.Enabled = True
            cbCategories.SelectedIndex = 0
            btnBack.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Exception caught. See console", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.Message)
            pcon.Close()
        End Try



    End Sub

    Private Sub populateGroupNames(ByVal subcategory As String)

        Dim groupnames As New List(Of String)

        For Each dr As DataRow In login.categoriesTable.Rows

            If subcategory <> "-" Then
                If dr(1) = cbSubcategories.SelectedItem Then
                    If dr(0) = cbCategories.SelectedItem Then
                        groupnames.Add(dr(2))
                    End If
                End If
            ElseIf dr(0) = cbCategories.SelectedItem Then
                groupnames.Add(dr(2))
            End If
        Next

        cbGroupNames.Items.AddRange(groupnames.Distinct.ToArray)
        cbGroupNames.SelectedIndex = 0
        enableControls()

    End Sub

    Private Sub disableControls()

        For Each c As Control In Me.Controls
            c.Enabled = False
        Next

    End Sub

    Private Sub enableControls()

        For Each c As Control In Me.Controls
            c.Enabled = True
        Next

    End Sub

    Public Async Sub generatePartNo(ByVal category As String, ByVal subcategory As String, ByVal groupName As String, ByVal location As String, ByVal description As String, ByVal specs As String, ByVal comments As String, drawing_no As String, UKNomCode As String, UKCC As String, supplier As String, mpn As String, srn As String, warehouse As String)

        If checkForDuplicates(description) = False Then

            disableControls()
            requestStatus.Text = "Sending request to Lasermet database..."

            Dim categoryNo As String

            Dim plantNo As String

            Dim seriesNo As String

            Dim LNpartNo As String

            Dim partsCount As Integer = 0

            For Each dr As DataRow In login.categoriesTable.Rows
                If subcategory = "-" Then
                    If dr(0) = category And dr(2) = groupName Then
                        categoryNo = dr(3).ToString.Split("-")(2)
                    End If
                ElseIf dr(0) = category Then
                    If dr(1) = subcategory Then
                        If dr(2) = groupName Then
                            categoryNo = dr(3).ToString.Split("-")(2)
                        End If
                    End If
                End If
            Next

            If location = "United Kingdom" Then
                plantNo = "1"
            ElseIf location = "Cebu, PH" Then
                plantNo = "2"
            End If

            LNpartNo = $"LN-{plantNo}-{categoryNo}"

            Try

                Dim requestDate As String = DateTime.Now().ToString("yyyy-MM-dd HH:mm:ss")

                Dim pcm As New Odbc.OdbcCommand
                pcm = pcon.CreateCommand()

                With pcm
                    .CommandText = "INSERT INTO ""LasermetPARTS_forApproval"" (lasermet_part_no, description, specifications, category, subcategory, group_name, comments, date_added, requested_by, department, drawing_no, issues_nominal_code, issues_cost_center, supplier, mpn, supplier_ref_no, warehouse, part_location) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
                    .Parameters.Add("@lasermet_part_no", Odbc.OdbcType.VarChar).Value = LNpartNo
                    .Parameters.Add("@description", Odbc.OdbcType.VarChar).Value = description
                    .Parameters.Add("@specifications", Odbc.OdbcType.VarChar).Value = specs
                    .Parameters.Add("@category", Odbc.OdbcType.VarChar).Value = category
                    .Parameters.Add("@subcategory", Odbc.OdbcType.VarChar).Value = subcategory
                    .Parameters.Add("@group_name", Odbc.OdbcType.VarChar).Value = groupName
                    .Parameters.Add("@comments", Odbc.OdbcType.VarChar).Value = comments
                    .Parameters.Add("@date_added", Odbc.OdbcType.VarChar).Value = requestDate
                    .Parameters.Add("@requested_by", Odbc.OdbcType.VarChar).Value = login.username
                    .Parameters.Add("@department", Odbc.OdbcType.VarChar).Value = login.user_department
                    .Parameters.Add("@drawing_no", Odbc.OdbcType.VarChar).Value = drawing_no
                    .Parameters.Add("@issues_nominal_code", Odbc.OdbcType.VarChar).Value = UKNomCode
                    .Parameters.Add("@issues_cost_center", Odbc.OdbcType.VarChar).Value = UKCC
                    .Parameters.Add("@supplier", Odbc.OdbcType.VarChar).Value = supplier
                    .Parameters.Add("@mpn", Odbc.OdbcType.VarChar).Value = mpn
                    .Parameters.Add("@supplier_ref_no", Odbc.OdbcType.VarChar).Value = srn
                    .Parameters.Add("@warehouse", Odbc.OdbcType.VarChar).Value = warehouse
                    .Parameters.Add("@part_location", Odbc.OdbcType.VarChar).Value = location
                End With


                pcon.Open()
                pcm.ExecuteNonQuery()
                pcon.Close()

                'Check if new part was added to DB.

                Try

                    Dim sqlQuery As String = "SELECT * from ""LasermetPARTS_forApproval"" ORDER BY date_added DESC"
                    pda = New Odbc.OdbcDataAdapter()
                    Dim pdcb As New Odbc.OdbcCommandBuilder(pda)
                    pda.SelectCommand = New Odbc.OdbcCommand(sqlQuery, pcon)
                    Dim dtable As New DataTable()
                    Dim partNums As New List(Of String)
                    pcon.Open()
                    pda.Fill(dtable)
                    pcon.Close()

                    Dim request_id As String

                    For Each dr As DataRow In dtable.Rows
                        partNums.Add(dr(0))
                        partNums.Add(dr(1))
                        If dr(0) = LNpartNo And dr(1) = description Then
                            request_id = dr(9)
                        End If

                    Next

                    If partNums.IndexOf(LNpartNo) < 0 And partNums.IndexOf(description) < 0 Then
                        MessageBox.Show("New part not submitted for review", "Submission error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        'MessageBox.Show("Part addition request has been submitted for review.", "Request sent for approval", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        requestStatus.Text = "Uploading request to Monday.com..."

                        Dim mondaystatus = Await createMondayItem(LNpartNo, drawing_no, category, subcategory, groupName, description, specs, comments, request_id, UKNomCode, UKCC, requestDate, location, warehouse, supplier, mpn, srn)

                        requestStatus.Text = mondaystatus(1)

                        If mondaystatus(1) = "Request succesfully sent for approval" Then
                            MessageBox.Show("Request succesfully sent for approval", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If DialogResult.OK Then
                                Select Case login.account_type
                                    Case "App Admin"
                                        Me.Close()
                                        AppAdminDashboard.Show()
                                    Case "Inventory Admin"
                                        Me.Close()
                                        InventoryAdminDashboard.Show()
                                    Case "General User"
                                        Me.Close()
                                        GeneralUserDashboard.Show()
                                    Case "Dept. Manager"
                                        Me.Close()
                                        InventoryAdminDashboard.Show()
                                End Select
                            End If
                        End If

                    End If

                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                    pcon.Close()
                End Try

            Catch ex As Exception
                Console.WriteLine(ex.Message)
                pcon.Close()
            End Try

        Else
            MessageBox.Show("A part with the same description already exists. Please check the database before proceeding", "Duplicate found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            requestStatus.Text = "Duplicate found. Please coordinate with your manager and update your request."
            If DialogResult.OK Then
                Exit Sub
            End If

        End If



    End Sub

    Private Sub LasermetPNG_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Single Master List Request"

        disableControls()
        Call connectPostGre()

        cbDepartment.SelectedIndex = 0
        populateCategories(cbDepartment.Text)

        cbLocation.Items.Add("United Kingdom")
        cbLocation.Items.Add("Cebu, PH")
        cbLocation.DropDownStyle = ComboBoxStyle.DropDownList


    End Sub

    Private Sub cbCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategories.SelectedIndexChanged

        If cbCategories.Items.IndexOf(cbCategories.Text) < 0 Then
            MessageBox.Show("Category Not Found. Please select from the list we provided", "Inpur Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            cbSubcategories.Items.Clear()
            populateSubcategories(cbCategories.SelectedItem)
            If cbLocation.Text = "Bournemouth" Then
                setNominalCodesAndCostCenter(cbCategories.SelectedItem)
            End If
        End If
    End Sub

    Private Sub cbSubcategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSubcategories.SelectedIndexChanged

        If cbSubcategories.Items.IndexOf(cbSubcategories.Text) < 0 Then
            MessageBox.Show("Subcategory Not Found. Please select from the list we provided", "Inpur Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            cbGroupNames.Items.Clear()
            populateGroupNames(cbSubcategories.SelectedItem)
        End If

    End Sub

    Private Sub btnSendRequest_Click(sender As Object, e As EventArgs) Handles btnSendRequest.Click

        Dim specs As String
        Dim comments As String

        Dim emptyfields As Integer = 0

        Dim requiredInputs As New List(Of Control)

        requiredInputs.Add(cbCategories)
        requiredInputs.Add(cbSubcategories)
        requiredInputs.Add(cbGroupNames)
        requiredInputs.Add(cbLocation)
        requiredInputs.Add(tbDescription)

        For Each c As Control In requiredInputs

            If String.IsNullOrWhiteSpace(c.Text) Then
                emptyfields += 1
            ElseIf TypeOf c Is ComboBox Then
                If c.Name = "cbCategories" Then
                    If cbCategories.Items.IndexOf(c.Text) < 0 Then
                        MessageBox.Show("Please review your selected Category", "Inpur Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                ElseIf c.Name = "cbSubcategories" Then
                    If cbSubcategories.Items.IndexOf(c.Text) < 0 Then
                        MessageBox.Show("Please review your selected subcategory", "Inpur Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                ElseIf c.Name = "cbGroupNames" Then
                    If cbGroupNames.Items.IndexOf(c.Text) < 0 Then
                        MessageBox.Show("Please review your selected group name", "Inpur Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                ElseIf c.Name = "cbLocation" Then
                    If cbLocation.Items.IndexOf(c.Text) < 0 Then
                        MessageBox.Show("Please review your selected Location", "Inpur Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        Next

        If String.IsNullOrWhiteSpace(tbSpecs.Text) Then
            specs = "N/A"
        Else
            specs = tbSpecs.Text
        End If

        If String.IsNullOrWhiteSpace(tbComments.Text) Then
            comments = "N/A"
        Else
            comments = tbComments.Text
        End If

        If emptyfields > 0 Then
            MessageBox.Show("Please fill up all required fields", ">:(", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            generatePartNo(cbCategories.Text, cbSubcategories.Text, cbGroupNames.Text, cbLocation.Text, tbDescription.Text, specs, comments, tbProjectNum.Text, tbUKNominalCode.Text, tbUKCC.Text, tbSupplier.Text, tbMPN.Text, tbSRN.Text, cbWarehouse.Text)
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Select Case login.account_type
            Case "App Admin"
                Me.Close()
                AppAdminDashboard.Show()

            Case "Inventory Admin"
                Me.Close()
                InventoryAdminDashboard.Show()

            Case "General User"
                Me.Close()
                GeneralUserDashboard.Show()

            Case "Dept. Manager"
                Me.Close()
                AppAdminDashboard.Show()

        End Select
    End Sub

    Private Sub cbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartment.SelectedIndexChanged

        cbCategories.Items.Clear()
        populateCategories(cbDepartment.Text)

    End Sub

    Private Sub setNominalCodesAndCostCenter(category As String)

        For Each dr As DataRow In login.categoriesTable.Rows

            If dr(0) = category Then

                tbUKNominalCode.Text = dr(5)
                tbUKCC.Text = dr(6)
                Exit For

            End If

        Next

    End Sub

    Private Sub cbLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLocation.SelectedIndexChanged

        If cbLocation.Text = "United Kingdom" Then


            cbWarehouse.Items.Clear()
            cbWarehouse.Items.Add("Bournemouth")
            cbWarehouse.Items.Add("Haydock")
            cbWarehouse.SelectedIndex = 0
            cbWarehouse.Enabled = True

        Else

            cbWarehouse.Items.Clear()
            cbWarehouse.Items.Add("N/A")
            cbWarehouse.SelectedIndex = 0
            cbWarehouse.Enabled = False

        End If


    End Sub

    Private Sub cbWarehouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbWarehouse.SelectedIndexChanged

        If cbWarehouse.Text = "Bournemouth" Or cbWarehouse.Text = "Haydock" Then

            For Each dr As DataRow In login.categoriesTable.Rows

                If dr(0) = cbCategories.Text Then

                    tbUKNominalCode.Text = dr(5)
                    tbUKCC.Text = dr(6)

                End If

            Next

        Else

            tbUKNominalCode.Text = "-"
            tbUKCC.Text = "-"

        End If

    End Sub




    'Private Sub cbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartment.SelectedIndexChanged

    '    populateCategories()

    'End Sub
End Class
