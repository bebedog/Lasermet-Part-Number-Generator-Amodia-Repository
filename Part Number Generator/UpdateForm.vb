Public Class UpdateForm

    Dim partnum_old As String
    Dim partdesc_old As String
    Dim partspecs_old As String
    Dim partcategory_old As String
    Dim partsubcategory_old As String
    Dim partgroupname_old As String
    Dim partcomments_old As String
    Dim partstock_old As Integer
    Dim projectnum_old As String
    Dim invDepartment As String
    Dim requestID As Integer
    Dim partRequester As String
    Dim partMondayID As String
    Dim revenueCC_old As String
    Dim issuesCC_old As String
    Dim partSupplier As String
    Dim mpn_old As String
    Dim srn_old As String
    Dim location As String
    Dim warehouse As String


    Private Function checkForDuplicates(description As String) As Boolean

        Call connectPostGre()

        Try

            Dim sqlQuery As String = $"SELECT * FROM ""LasermetPARTS"" WHERE ""description"" LIKE '{description.Replace(" ", "%")}'"
            pda = New Odbc.OdbcDataAdapter()
            Dim pdcb As New Odbc.OdbcCommandBuilder(pda)
            pda.SelectCommand = New Odbc.OdbcCommand(sqlQuery, pcon)
            Dim dtable As New DataTable()
            pcon.Open()
            pda.Fill(dtable)
            pcon.Close()

            If dtable.Rows.Count <= 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            MessageBox.Show("Exception caught. See console", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.Message)
            pcon.Close()
        End Try

    End Function

    Public Sub populateUpdateForm(partnum As String, partdesc As String, partspecs As String, partcategory As String, partsubcategory As String, partgroupname As String, partcomments As String, partstock As Integer, projectnum As String, department As String, request_id As Integer, requester As String, monday_id As String, revCC As String, issCC As String, location As String, warehouse As String, Optional supplier As String = "", Optional mpn As String = "", Optional srn As String = "")

        partnum_old = partnum
        partdesc_old = partdesc
        partspecs_old = partspecs
        partcategory_old = partcategory
        partsubcategory_old = partsubcategory
        partgroupname_old = partgroupname
        partcomments_old = partcomments
        partstock_old = partstock
        projectnum_old = projectnum
        invDepartment = department
        requestID = request_id
        partRequester = requester
        partMondayID = monday_id
        revenueCC_old = revCC
        issuesCC_old = issCC
        partSupplier = supplier
        mpn_old = mpn
        srn_old = srn


        If partnum.Split("-").Length = 4 Then
            tbPartNum.Text = partnum.Replace($"-{partnum.Split("-")(3)}", "")
        Else
            tbPartNum.Text = partnum
        End If

        tbDescription.Text = partdesc
        tbSpecifications.Text = partspecs
        tbComments.Text = partcomments
        tbCurrentStock.Text = partstock
        tbDrawingNo.Text = projectnum
        tbUKNominalCode.Text = revCC
        tbIssuesCC.Text = issCC
        tbSupplier.Text = supplier
        tbMPN.Text = mpn_old
        tbSRN.Text = srn_old

        Dim categoriesList As New List(Of String)
        Dim subcategoriesList As New List(Of String)
        Dim groupList As New List(Of String)

        For Each dr As DataRow In login.categoriesTable.Rows
            If dr(0) = partcategory Then
                cbDepartment.SelectedIndex = cbDepartment.Items.IndexOf(dr(4))
            End If
        Next

        For Each dr As DataRow In login.categoriesTable.Rows
            If dr(4) = cbDepartment.Text Then
                categoriesList.Add(dr(0))
            End If
        Next

        cbCategory.Items.AddRange(categoriesList.Distinct.ToArray)
        cbCategory.Text = partcategory

        For Each dr As DataRow In login.categoriesTable.Rows
            If dr(0) = partcategory Then
                subcategoriesList.Add(dr(1))
            End If
        Next

        cbSubcategory.Items.AddRange(subcategoriesList.Distinct.ToArray)
        cbSubcategory.Text = partsubcategory

        For Each dr As DataRow In login.categoriesTable.Rows
            If dr(0) = partcategory And dr(1) = partsubcategory Then
                groupList.Add(dr(2))
            End If
        Next

        cbGroupName.Items.AddRange(groupList.Distinct.ToArray)
        cbGroupName.Text = partgroupname

        cbLocation.Items.Add("United Kingdom")
        cbLocation.Items.Add("Cebu, PH")

        cbLocation.SelectedIndex = cbLocation.Items.IndexOf(location)
        cbWarehouse.SelectedIndex = cbWarehouse.Items.IndexOf(warehouse)


    End Sub

    Private Sub disableAllControls()

        For Each c As Control In Me.Controls
            c.Enabled = False
        Next

    End Sub

    Private Sub updateItem(oldpartnum As String, partdesc As String, partspecs As String, partcategory As String, partsubcategory As String, partgroupname As String, partcomments As String, partstock As Integer, projectnum As String, revCC As String, issCC As String, Optional supplier As String = "", Optional mpn As String = "", Optional srn As String = "")

        Call connectPostGre()


        Dim mondayID As String
        Dim newPartNum As String
        Dim newSeriesNum As String

        newPartNum = tbPartNum.Text

        Dim partNumsFromDB As New List(Of Integer)
        Dim partsCount As Integer

        If newPartNum.Split("-")(2) <> oldpartnum.Split("-")(2) Then

            Try

                'Update series number

                Dim sqlQuery_find As String = "SELECT * FROM ""LasermetPARTS"""
                pda = New Odbc.OdbcDataAdapter()
                Dim pdcb As New Odbc.OdbcCommandBuilder(pda)
                pda.SelectCommand = New Odbc.OdbcCommand(sqlQuery_find, pcon)
                Dim dtable As New DataTable()
                pcon.Open()
                pda.Fill(dtable)
                pcon.Close()

                For Each dr As DataRow In dtable.Rows

                    If dr(0).ToString.Split("-")(2) = newPartNum.ToString.Split("-")(2) Then

                        partNumsFromDB.Add(dr(0).ToString.Split("-")(3).Replace("0", "").Trim)

                    End If

                    If dr(0) = oldpartnum Then
                        mondayID = dr(19)
                    End If

                Next

                Try

                    Dim sqlQuery As String = "SELECT * from ""LasermetPARTS_forApproval"" WHERE ""manager_approval"" = 'Approved' AND ""final_approval"" = 'Approved'"
                    pda = New Odbc.OdbcDataAdapter()
                    Dim _pdcb As New Odbc.OdbcCommandBuilder(pda)
                    pda.SelectCommand = New Odbc.OdbcCommand(sqlQuery, pcon)
                    Dim partsTable As New DataTable()
                    pcon.Open()
                    pda.Fill(partsTable)
                    pcon.Close()

                    For Each dr As DataRow In partsTable.Rows

                        Dim catNo As String = dr(0).ToString.Split("-")(2)

                        If catNo = newPartNum.ToString.Split("-")(2) Then
                            partNumsFromDB.Add(dr(0).ToString.Split("-")(3).Replace("0", "").Trim)
                        End If
                    Next

                Catch ex As Exception
                    MessageBox.Show("Exception caught. See console", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Console.WriteLine(ex.Message)
                End Try


                If partNumsFromDB.Count > 0 Then
                    partsCount = partNumsFromDB.Max + 1
                Else
                    partsCount = 1
                End If

                newSeriesNum = $"{StrDup(5 - partsCount.ToString.Length, "0")}{partsCount}"

                newPartNum = $"{newPartNum}-{newSeriesNum}"

            Catch ex As Exception
                MessageBox.Show("Exception caught. See console", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Console.WriteLine(ex.Message)
                pcon.Close()
            End Try

        Else

            newPartNum = oldpartnum

        End If


        Try

            Dim sqlQuery_update As String = $"UPDATE ""LasermetPARTS"" SET ""lasermet_part_no"" = ?, ""description"" = ?, ""specifications"" = ?,""category"" = ?, ""subcategory"" = ?, ""group_name"" = ?, ""comments"" = ?, ""std_stocks"" = ?, ""date_updated"" = ?, ""updated_by"" = ?, ""drawing_no"" = ?, ""issues_nominal_code"" = ?, ""issues_cost_center"" = ?, ""supplier"" = ?, ""mpn"" = ?, ""supplier_ref_no"" = ?, ""warehouse"" = ?, ""part_location"" = ? WHERE ""lasermet_part_no"" = '{partnum_old}'"

            Dim pcm As New Odbc.OdbcCommand
            pcm = pcon.CreateCommand()

            With pcm

                .CommandText = sqlQuery_update
                .Parameters.Add("@lasermet_part_no", Odbc.OdbcType.VarChar).Value = newPartNum
                .Parameters.Add("@description", Odbc.OdbcType.VarChar).Value = tbDescription.Text
                .Parameters.Add("@specifications", Odbc.OdbcType.VarChar).Value = tbSpecifications.Text
                .Parameters.Add("@category", Odbc.OdbcType.VarChar).Value = cbCategory.Text
                .Parameters.Add("@subcategory", Odbc.OdbcType.VarChar).Value = cbSubcategory.Text
                .Parameters.Add("@group_name", Odbc.OdbcType.VarChar).Value = cbGroupName.Text
                .Parameters.Add("@comments", Odbc.OdbcType.VarChar).Value = tbComments.Text
                .Parameters.Add("@std_stocks", Odbc.OdbcType.VarChar).Value = tbCurrentStock.Text
                .Parameters.Add("@date_updated", Odbc.OdbcType.VarChar).Value = DateTime.Now().ToString("yyyy-MM-dd HH:mm:ss")
                .Parameters.Add("@updated_by", Odbc.OdbcType.VarChar).Value = login.username
                .Parameters.Add("@drawing_no", Odbc.OdbcType.VarChar).Value = tbDrawingNo.Text
                .Parameters.Add("@issues_nominal_code", Odbc.OdbcType.VarChar).Value = tbUKNominalCode.Text
                .Parameters.Add("@issues_cost_center", Odbc.OdbcType.VarChar).Value = tbIssuesCC.Text
                .Parameters.Add("@supplier", Odbc.OdbcType.VarChar).Value = tbSupplier.Text
                .Parameters.Add("@mpn", Odbc.OdbcType.VarChar).Value = tbMPN.Text
                .Parameters.Add("@supplier_ref_no", Odbc.OdbcType.VarChar).Value = tbMPN.Text
                .Parameters.Add("@warehouse", Odbc.OdbcType.VarChar).Value = cbWarehouse.Text
                .Parameters.Add("@part_location", Odbc.OdbcType.VarChar).Value = cbLocation.Text

            End With

            pcon.Open()
            pcm.ExecuteNonQuery()
            pcon.Close()

            'Check if update was successful

            Try

                Dim sqlQuery_check As String = "SELECT * from ""LasermetPARTS"" ORDER BY final_approval_date DESC"
                pda = New Odbc.OdbcDataAdapter()
                Dim pdcb_check As New Odbc.OdbcCommandBuilder(pda)
                pda.SelectCommand = New Odbc.OdbcCommand(sqlQuery_check, pcon)
                Dim dtable_check As New DataTable()
                Dim partNums As New List(Of String)
                pcon.Open()
                pda.Fill(dtable_check)
                pcon.Close()

                For Each dr As DataRow In dtable_check.Rows
                    partNums.Add(dr(0))
                Next

                If partNums.IndexOf(newPartNum) < 0 Then
                    Throw New System.Exception("An error occured while approving this request")
                Else

                    'updateMondayColumns("", newPartNum, tbDrawingNo.Text, cbCategory.Text, cbSubcategory.Text, cbGroupName.Text, tbDescription.Text, tbSpecifications.Text, tbComments.Text, mondayID, tbRevCC.Text, tbIssuesCC.Text, DateTime.Now().ToString("yyyy-MM-dd HH:mm:ss"), tbSupplier.Text)

                    MessageBox.Show("Update Successful", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If DialogResult.OK Then
                        disableAllControls()
                        Dim categories As New List(Of String)

                        For Each dr As DataRow In login.categoriesTable.Rows
                            categories.Add(dr(0))
                        Next

                        SearchDB.populateInventoryDGV()
                        SearchDB.tbCategoryFilter.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                        SearchDB.tbCategoryFilter.AutoCompleteSource = AutoCompleteSource.CustomSource
                        SearchDB.tbCategoryFilter.AutoCompleteCustomSource.AddRange(categories.Distinct.ToArray)
                        SearchDB.panelSearchFilters.Visible = True
                        SearchDB.panelSearchFilters.Enabled = True
                        SearchDB.Size = New Size(800, 600)
                        SearchDB.dgvSearchResults.Size = New Size(768, 258)
                        SearchDB.dgvSearchResults.Location = New Point(8, 232)
                        SearchDB.StartPosition = FormStartPosition.CenterScreen
                        Me.Close()
                        SearchDB.Show()
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ":(", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Console.WriteLine(ex.Message)
                pcon.Close()
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, ":(", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.Message)
            pcon.Close()
        End Try

    End Sub


    Private Sub UpdateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartment.SelectedIndexChanged

        Dim categories As New List(Of String)

        For Each dr As DataRow In login.categoriesTable.Rows

            If cbDepartment.Text = "All" Then

                categories.Add(dr(0))

            Else

                If dr(4) = cbDepartment.Text Then

                    categories.Add(dr(0))

                End If

            End If

        Next

        cbCategory.Items.Clear()
        cbCategory.Items.AddRange(categories.Distinct.ToArray)
        cbCategory.SelectedIndex = 0

    End Sub

    Private Sub cbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategory.SelectedIndexChanged

        If MyBase.Visible = True Then

            If tbPartNum.Text IsNot Nothing Or String.IsNullOrWhiteSpace(tbPartNum.Text) = False Then

                Dim categoryNo_New As String
                Dim categoryNo_Old As String
                Dim subcategories As New List(Of String)
                Dim groupnames As New List(Of String)

                categoryNo_Old = tbPartNum.Text.Split("-")(2)

                cbSubcategory.Enabled = False
                cbSubcategory.Items.Clear()
                cbGroupName.Enabled = False
                cbGroupName.Items.Clear()

                For Each dr As DataRow In login.categoriesTable.Rows
                    If dr(0) = cbCategory.Text Then
                        subcategories.Add(dr(1))
                    End If
                Next

                cbSubcategory.Items.AddRange(subcategories.Distinct.ToArray)
                cbSubcategory.SelectedIndex = 0

                For Each dr As DataRow In login.categoriesTable.Rows
                    If dr(0) = cbCategory.Text And dr(1) = cbSubcategory.Text Then
                        groupnames.Add(dr(2))
                    End If
                Next

                cbGroupName.Items.AddRange(groupnames.Distinct.ToArray)

                cbGroupName.SelectedIndex = 0

                For Each dr As DataRow In login.categoriesTable.Rows
                    If dr(0) = cbCategory.Text Then
                        If dr(1) = cbSubcategory.Text Then
                            If dr(2) = cbGroupName.Text Then
                                categoryNo_New = dr(3).ToString.Split("-")(2)
                            End If
                        End If

                        If tbPartNum.Text.Split("-")(1) = "1" Or cbLocation.Text = "United Kingdom" Then
                            tbUKNominalCode.Text = dr(5)
                            tbIssuesCC.Text = dr(6)
                        Else
                            tbUKNominalCode.Text = "N/A"
                            tbIssuesCC.Text = "N/A"
                        End If


                    End If
                Next

                If categoryNo_New IsNot Nothing Then

                    tbPartNum.Text = tbPartNum.Text.Replace(categoryNo_Old, categoryNo_New)

                End If



                cbSubcategory.Enabled = True
                cbGroupName.Enabled = True

            End If

        End If



    End Sub

    Private Sub cbSubcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSubcategory.SelectedIndexChanged

        If MyBase.Visible = True Then

            If tbPartNum.Text IsNot Nothing Or String.IsNullOrWhiteSpace(tbPartNum.Text) = False Then

                Dim categoryNo_New As String
                Dim categoryNo_Old As String
                Dim groupNames As New List(Of String)

                categoryNo_Old = tbPartNum.Text.Split("-")(2)

                cbGroupName.Enabled = False
                cbGroupName.Items.Clear()

                For Each dr As DataRow In login.categoriesTable.Rows
                    If dr(0) = cbCategory.Text And dr(1) = cbSubcategory.Text Then
                        groupNames.Add(dr(2))
                    End If
                Next

                cbGroupName.Items.AddRange(groupNames.Distinct.ToArray)
                cbGroupName.SelectedIndex = 0

                For Each dr As DataRow In login.categoriesTable.Rows
                    If dr(0) = cbCategory.Text Then
                        If dr(1) = cbSubcategory.Text Then
                            If dr(2) = cbGroupName.Text Then
                                categoryNo_New = dr(3).ToString.Split("-")(2)
                            End If
                        End If
                    End If
                Next

                If String.IsNullOrEmpty(categoryNo_New) = False Then
                    tbPartNum.Text = tbPartNum.Text.Replace(categoryNo_Old, categoryNo_New)
                Else

                    tbPartNum.Text = tbPartNum.Text

                End If

                cbSubcategory.Enabled = True
                cbGroupName.Enabled = True

            End If

        End If



    End Sub

    Private Sub cbGroupName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGroupName.SelectedIndexChanged

        If MyBase.Visible = True Then
            If tbPartNum.Text IsNot Nothing Or String.IsNullOrWhiteSpace(tbPartNum.Text) = False Then

                Dim categoryNo_New As String
                Dim categoryNo_Old As String

                categoryNo_Old = tbPartNum.Text.Split("-")(2)

                For Each dr As DataRow In login.categoriesTable.Rows
                    If dr(0) = cbCategory.Text Then
                        If dr(1) = cbSubcategory.Text Then
                            If dr(2) = cbGroupName.Text Then
                                categoryNo_New = dr(3).ToString.Split("-")(2)
                            End If
                        End If
                    End If
                Next

                If categoryNo_New IsNot Nothing Then

                    tbPartNum.Text = tbPartNum.Text.Replace(categoryNo_Old, categoryNo_New)

                End If



            End If

        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If btnUpdate.Text = "Update" Then

            For Each c As Control In Me.Controls
                If c.GetType() Is GetType(TextBox) Then
                    If String.IsNullOrWhiteSpace(c.Text) Then
                        If c.Name <> "tbCurrentStock" Then
                            c.Text = "N/A"
                        End If
                    End If
                End If
            Next

            If tbCurrentStock.Text <> "N/A" Then

                If IsNumeric(tbCurrentStock.Text) Then
                    updateItem(partnum_old, tbDescription.Text, tbSpecifications.Text, cbCategory.Text, cbSubcategory.Text, cbGroupName.Text, tbComments.Text, tbCurrentStock.Text, tbDrawingNo.Text, tbUKNominalCode.Text, tbIssuesCC.Text)
                Else
                    MessageBox.Show("Please enter a valid numeric value for 'Current Stock'", ">:(", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            End If

        ElseIf btnUpdate.Text = "Approve" Then

            disableAllControls()

            'addNewPart(tbPartNum.Text, tbDescription.Text, tbSpecifications.Text, cbCategory.Text, cbSubcategory.Text, cbGroupName.Text, tbComments.Text, partRequester, login.username, requestID, tbDrawingNo.Text, invDepartment)
            SearchDB.approvePart(tbPartNum.Text, tbDescription.Text, tbSpecifications.Text, cbCategory.Text, cbSubcategory.Text, cbGroupName.Text, tbComments.Text, partRequester, login.username, requestID, tbDrawingNo.Text, invDepartment, partMondayID, tbUKNominalCode.Text, tbIssuesCC.Text, cbWarehouse.Text, cbLocation.Text, Me, ToolStripStatusLabel1, tbSupplier.Text, tbMPN.Text, tbSRN.Text)

        End If





    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        disableAllControls()

        If btnUpdate.Text = "Update" Then

            Dim categories As New List(Of String)

            For Each dr As DataRow In login.categoriesTable.Rows
                categories.Add(dr(0))
            Next

            SearchDB.populateInventoryDGV()
            SearchDB.tbCategoryFilter.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            SearchDB.tbCategoryFilter.AutoCompleteSource = AutoCompleteSource.CustomSource
            SearchDB.tbCategoryFilter.AutoCompleteCustomSource.AddRange(categories.Distinct.ToArray)
            SearchDB.panelSearchFilters.Visible = True
            SearchDB.panelSearchFilters.Enabled = True
            SearchDB.Size = New Size(800, 600)
            SearchDB.dgvSearchResults.Size = New Size(768, 258)
            SearchDB.dgvSearchResults.Location = New Point(8, 232)
            SearchDB.StartPosition = FormStartPosition.CenterScreen
            Me.Close()
            SearchDB.Show()

        ElseIf btnUpdate.Text = "Approve" Then

            SearchDB.populateApprovalDGV()
            Me.Close()
            SearchDB.Show()

        End If


    End Sub

    Private Sub cbLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLocation.SelectedIndexChanged

        If cbLocation.Text = "United Kingdom" Then

            cbWarehouse.Items.Clear()
            cbWarehouse.Items.Add("Bournemouth")
            cbWarehouse.Items.Add("Haydock")
            cbWarehouse.Enabled = True

            tbPartNum.Text = tbPartNum.Text.Replace($"LN-{tbPartNum.Text.Split("-")(1)}", "LN-1")

            For Each dr As DataRow In login.categoriesTable.Rows

                If dr(0) = cbCategory.Text Then
                    tbUKNominalCode.Text = dr(5)
                    tbIssuesCC.Text = dr(6)

                    Exit For

                Else

                    tbUKNominalCode.Text = "N/A"
                    tbIssuesCC.Text = "N/A"

                End If
            Next

        Else

            cbWarehouse.Items.Clear()
            cbWarehouse.Items.Add("N/A")
            cbWarehouse.SelectedIndex = 0
            tbIssuesCC.Text = "N/A"
            tbUKNominalCode.Text = "N/A"
            cbWarehouse.Enabled = False

            tbPartNum.Text = tbPartNum.Text.Replace($"LN-{tbPartNum.Text.Split("-")(1)}", "LN-2")

        End If

    End Sub
End Class