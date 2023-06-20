Imports System.IO
Imports System.Data.SqlClient

Public Class BatchPartRequest

    Dim batchRequestTable As New DataTable

    Private Sub btnImportFile_Click(sender As Object, e As EventArgs) Handles btnImportFile.Click
        OpenFileDialog1.ShowDialog()

        If DialogResult.OK Then
            'Console.WriteLine(OpenFileDialog1.FileName)
            ExceltoDGV(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub ExceltoDGV(filename As String)

        Try

            Dim con As System.Data.OleDb.OleDbConnection
            Dim command As System.Data.OleDb.OleDbDataAdapter
            Dim dtset As System.Data.DataSet

            con = New System.Data.OleDb.OleDbConnection($"provider=Microsoft.Jet.OLEDB.4.0;Data Source='{filename}';Extended Properties=Excel 8.0;")
            command = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM [BatchRequestTable$]", con)
            command.TableMappings.Add("Table", "Batch Request")
            dtset = New System.Data.DataSet
            command.Fill(dtset, "[BatchRequestTable$]")

            'For Each dc As DataColumn In dtset.Tables(0).Columns
            '    batchRequestTable.Columns.Add(dc)
            'Next

            'For Each dr As DataRow In dtset.Tables(0).Rows
            '    batchRequestTable.Rows.Add(dr)
            'Next

            batchRequestTable = dtset.Tables(0)

            For Each dr As DataRow In batchRequestTable.Rows

                If dr(0).ToString <> "" Then

                    For i = 0 To batchRequestTable.Columns.Count - 1

                        If IsDBNull(dr.Item(i)) Then

                            dr.Item(i) = "-"

                        End If

                    Next

                Else

                    dr.Delete()


                End If

            Next

            batchRequestTable.AcceptChanges()
            dgvBatchRequest.DataSource = batchRequestTable
            btnSendRequest.Enabled = True

            ToolStripStatusLabel1.Text = $"{batchRequestTable.Rows.Count} parts for request."

            con.Close()

        Catch ex As Exception

            MessageBox.Show($"Error encountered while uploading file. {Environment.NewLine} {ex.Message}", "Exception caught during file upload", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try




    End Sub

    Private Sub CSVtoDGV(filename As String)

        Try

            If Path.GetExtension(filename).ToLower() <> ".csv" Then

                MessageBox.Show("Please select a valid .csv file", "Invalid file type", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                batchRequestTable.Clear()
                dgvBatchRequest.Columns.Clear()

                Dim SR As StreamReader = New StreamReader(filename)
                Dim line As String = SR.ReadLine
                Dim strArray As String() = line.Split(","c)
                Dim row As DataRow

                For Each s As String In strArray
                    batchRequestTable.Columns.Add(New DataColumn(s))
                Next

                Do
                    line = SR.ReadLine
                    If Not String.IsNullOrEmpty(line) Then
                        If Not line.Replace(",", "") = String.Empty Then
                            row = batchRequestTable.NewRow()
                            row.ItemArray = line.Split(","c)
                            batchRequestTable.Rows.Add(row)
                        Else
                            Exit Do
                        End If
                    Else
                        Exit Do
                    End If
                Loop

                batchRequestTable.Columns.Add("Category").SetOrdinal(4)
                batchRequestTable.Columns.Add("Subcategory").SetOrdinal(5)
                batchRequestTable.Columns.Add("Group Name").SetOrdinal(6)

                For Each dr As DataRow In batchRequestTable.Rows

                    Dim categoryNum As String = dr(0).ToString.Trim.Split("-")(2)

                    For Each c As DataRow In login.categoriesTable.Rows

                        If c(3).ToString.Trim.Split("-")(2) = categoryNum Then

                            dr.Item(4) = c(0)
                            dr.Item(5) = c(1)
                            dr.Item(6) = c(2)

                        End If

                    Next

                Next

                dgvBatchRequest.DataSource = batchRequestTable
                btnSendRequest.Enabled = True

                Dim requestCount As Integer = 0

                For Each dr As DataGridViewRow In dgvBatchRequest.Rows
                    Dim rowArr As New List(Of String)

                    For i = 0 To dgvBatchRequest.Columns.Count - 1

                        If dr.Cells(i).Value IsNot Nothing Then
                            rowArr.Add(dr.Cells(i).Value.ToString)
                        Else
                            rowArr.Add(" ")
                        End If

                    Next

                    If String.IsNullOrWhiteSpace(String.Join(" ", rowArr.ToArray)) = False Then
                        requestCount = requestCount + 1
                    End If

                Next

                ToolStripStatusLabel1.Text = $"{requestCount} parts for request."

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message, ":(", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try



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

    Private Async Sub sendBatchRequest()

        Call connectPostGre()

        If batchRequestTable IsNot Nothing Then

            Dim partsRequested As New List(Of List(Of String))
            Dim failedRequests As New List(Of List(Of String))
            Dim row As Integer = 0
            Dim row_f As Integer = 0

            Try


                For Each dr As DataRow In batchRequestTable.Rows


                    Dim partDescription As String = dr(4)
                    Dim partNum As String = dr(0)


                    Try

                        Dim requestDate As String = DateTime.Now().ToString("yyyy-MM-dd HH:mm:ss")

                        disableControls()
                        ToolStripStatusLabel1.Text = "Sending batch request to Lasermet Database..."

                        Dim pcm As New Odbc.OdbcCommand
                        pcm = pcon.CreateCommand()

                        With pcm
                            .CommandText = "INSERT INTO ""LasermetPARTS_forApproval"" (lasermet_part_no, description, specifications, category, subcategory, group_name, date_added, requested_by, drawing_no, department, issues_nominal_code, issues_cost_center, supplier, mpn, supplier_ref_no, warehouse, part_location) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?,?,?,?,?)"
                            .Parameters.Add("@lasermet_part_no", Odbc.OdbcType.VarChar).Value = partNum
                            .Parameters.Add("@description", Odbc.OdbcType.VarChar).Value = partDescription
                            .Parameters.Add("@specifications", Odbc.OdbcType.VarChar).Value = dr(5)
                            .Parameters.Add("@category", Odbc.OdbcType.VarChar).Value = dr(9)
                            .Parameters.Add("@subcategory", Odbc.OdbcType.VarChar).Value = dr(10)
                            .Parameters.Add("@group_name", Odbc.OdbcType.VarChar).Value = dr(11)
                            .Parameters.Add("@date_added", Odbc.OdbcType.VarChar).Value = requestDate
                            .Parameters.Add("@requested_by", Odbc.OdbcType.VarChar).Value = login.username
                            .Parameters.Add("@drawing_no", Odbc.OdbcType.VarChar).Value = dr(3)
                            .Parameters.Add("@department", Odbc.OdbcType.VarChar).Value = dr(1)
                            .Parameters.Add("@issues_nominal_code", Odbc.OdbcType.VarChar).Value = dr(12)
                            .Parameters.Add("@issues_cost_center", Odbc.OdbcType.VarChar).Value = dr(13)
                            .Parameters.Add("@supplier", Odbc.OdbcType.VarChar).Value = dr(6)
                            .Parameters.Add("@mpn", Odbc.OdbcType.VarChar).Value = dr(8)
                            .Parameters.Add("@supplier_ref_no", Odbc.OdbcType.VarChar).Value = dr(7)
                            .Parameters.Add("@warehouse", Odbc.OdbcType.VarChar).Value = dr(15)
                            .Parameters.Add("@part_location", Odbc.OdbcType.VarChar).Value = dr(14)
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
                            Dim partDescs As New List(Of String)
                            pcon.Open()
                            pda.Fill(dtable)
                            pcon.Close()

                            Dim request_id As Integer

                            For Each dr2 As DataRow In dtable.Rows
                                partNums.Add(dr2(0))
                                partDescs.Add(dr2(1))
                                If dr2(0) = partNum And dr2(1) = partDescription Then
                                    request_id = dr2(9)
                                    Exit For
                                End If
                            Next

                            If partNums.IndexOf(partNum) >= 0 And partDescs.IndexOf(partDescription) >= 0 Then

                                Dim mondaystatus = Await createMondayItem(partNum, dr(3), dr(9), dr(10), dr(11), partDescription, dr(5), "Batch Request", request_id, dr(12), dr(13), requestDate, dr(14), dr(15), dr(6), dr(8), dr(7))
                                If mondaystatus(0) = "success" Then
                                    partsRequested.Add(New List(Of String))
                                    partsRequested(row).Add(partNum)
                                    partsRequested(row).Add(partDescription)
                                    row = row + 1
                                    ToolStripStatusLabel1.Text = $"Request sent for {partsRequested.Count} / {batchRequestTable.Rows.Count} parts"
                                Else
                                    failedRequests.Add(New List(Of String))
                                    failedRequests(row_f).Add(partNum)
                                    failedRequests(row_f).Add(partDescription)
                                    row_f = row_f + 1
                                    ToolStripStatusLabel1.Text = $"Request failed for {partNum} | {partDescription}"
                                End If
                            Else
                                Console.WriteLine($"Request failed for {partNum} | {partDescription}")
                            End If

                        Catch ex As Exception
                            Console.WriteLine(ex.Message)
                            pcon.Close()
                        End Try

                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                        pcon.Close()
                    End Try

                Next

                MessageBox.Show($"{partsRequested.Count} parts submitted for approval", "Thanks", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            Catch ex As Exception

                MessageBox.Show($"An error occured while submitting your request:{Environment.NewLine}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                pcon.Close()

            End Try

        Else
            MessageBox.Show($"No CSV File Uploaded", "Nothing to send", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btnSendRequest_Click(sender As Object, e As EventArgs) Handles btnSendRequest.Click
        sendBatchRequest()
    End Sub

    Private Sub BatchPartRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSendRequest.Enabled = False
    End Sub

    Private Sub btnGetTemplate_Click(sender As Object, e As EventArgs) Handles btnGetTemplate.Click



        dlgSaveTemplate.Filter = "Excel (*.xls)|*.xls"
        dlgSaveTemplate.FilterIndex = 2
        dlgSaveTemplate.RestoreDirectory = True
        If dlgSaveTemplate.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllBytes(dlgSaveTemplate.FileName, My.Resources.BatchRequestTemplate)
            Process.Start(dlgSaveTemplate.FileName)
        End If

    End Sub
End Class