Imports RestSharp
Imports Newtonsoft.Json
Imports System.Threading

Module MondayAPIFunctions

    Private apiKey As String = My.Resources.apiKey
    Dim queryTimeOut As Integer = 10000

    Private createItemQuery As String

    'Start of classes declaration for Monday

    Public Class PersonsAndTeam
        Public Property id As Integer
        Public Property kind As String
    End Class

    Public Class Person
        Public Property personsAndTeams As PersonsAndTeam()
    End Class

    Public Class MultipleColumnValues
        Public Property text8 As String 'Lasermet Drawing No.
        Public Property text1 As String 'Description
        Public Property text84 As String 'Specifications
        Public Property text As String 'Category
        Public Property text5 As String 'Subcategory
        Public Property text53 As String 'Group Name
        Public Property person As Person 'Requester
        Public Property people7 As Person 'Manager

        Public Property name As String 'Item Name (Lasermet Part No.)

        Public Property status As String 'Manager Approval
        Public Property color As String 'Final Approval
        Public Property text3 As String
        Public Property text13 As String
        Public Property text9 As String
        Public Property text2 As String
        Public Property text54 As String 'Request Date
        Public Property text17 As String 'Manager Approval Date
        Public Property text4 As String 'Final Approval Date
        Public Property text0 As String 'Supplier
        Public Property text85 As String 'Manufacturer Part No.
        Public Property text36 As String 'Supplier Reference No.

        Public Property text51 As String 'Location

        Public Property text45 As String


    End Class

    Public Class CreateItem
        Public Property id As String
    End Class

    Public Class Data
        Public Property create_item As CreateItem
        Public Property users As User()
    End Class

    Public Class CreateItemOnMonday
        Public Property data As Data
        Public Property account_id As Integer
    End Class

    Public Class User
        Public Property id As Integer
        Public Property name As String
        Public Property email As String
    End Class

    Public Class MondayUsers
        Public Property data As Data
        Public Property account_id As Integer
    End Class

    'End of classes declaration for Monday

    Dim mondayBoardID As String = "4158815611"

    Public Async Function createMondayItem(part_no As String, drawing_no As String, ByVal category As String, ByVal subcategory As String, ByVal groupName As String, ByVal description As String, ByVal specs As String, ByVal comments As String, request_id As String, UKNomCode As String, UKCC As String, requestDate As String, location As String, warehouse As String, Optional supplier As String = "", Optional mpn As String = "", Optional srn As String = "") As Task(Of String())



        Select Case location
            Case "United Kingdom"
                createItemQuery = "mutation{create_item(board_id:" + mondayBoardID + ", group_id:""topics"", item_name:""" + part_no + """){id name}}"
            Case "Cebu, PH"
                createItemQuery = "mutation{create_item(board_id:" + mondayBoardID + ", group_id:""new_group68312"", item_name:""" + part_no + """){id name}}"
        End Select

        Dim recons As Integer

createNewItem:

        Try
            For retries = 1 To 30
                If retries <> 30 Then
                    Dim mondayResponse As Object = Await SendMondayRequest(createItemQuery)

                    If mondayResponse(0) = "error" Then

                        Return {"error", $"Error occured while connecting to Monday. Retrying ({retries}/30)"}
                    Else

                        recons = 0
                        Dim requestItem = JsonConvert.DeserializeObject(Of CreateItemOnMonday)(mondayResponse(1))
                        Dim monday_id As String = requestItem.data.create_item.id

                        Dim updateResult = Await updateMondayColumns(request_id, part_no, drawing_no, category, subcategory, groupName, description, specs, comments, monday_id, UKNomCode, UKCC, requestDate, location, warehouse, supplier, mpn, srn)

                        Return updateResult

                        Exit For

                    End If
                Else
                    Throw New Exception("Error occured while connecting to Monday.com")

                End If
            Next

        Catch ex As Exception
            If recons >= 0 And recons < 30 Then
                recons += 1
                Return {"error", $"Attempting to reconnect to Monday {recons}/30"}
                Thread.Sleep(1000)
                GoTo createNewItem
            ElseIf recons >= 30 Then
                MessageBox.Show("Failed to connect to Monday. Press OK to restart", "Connection Issue", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If DialogResult.OK Then
                    Application.Restart()
                End If
            End If
            Exit Function
        End Try

    End Function

    Public Async Function updateMondayColumns(item_id As String, part_no As String, drawing_no As String, ByVal category As String, ByVal subcategory As String, ByVal groupName As String, ByVal description As String, ByVal specs As String, ByVal comments As String, monday_id As String, UKNomCode As String, UKCC As String, requestDate As String, location As String, warehouse As String, Optional supplier As String = "", Optional mpn As String = "", Optional srn As String = "") As Task(Of String())


        Dim changeColumnsQuery As New MultipleColumnValues()
        changeColumnsQuery.name = part_no
        changeColumnsQuery.text8 = drawing_no
        changeColumnsQuery.text1 = description
        changeColumnsQuery.text84 = specs
        changeColumnsQuery.text = category
        changeColumnsQuery.text5 = subcategory
        changeColumnsQuery.text53 = groupName
        changeColumnsQuery.text3 = comments
        changeColumnsQuery.text9 = UKNomCode
        changeColumnsQuery.text2 = UKCC
        changeColumnsQuery.text13 = login.user_department
        changeColumnsQuery.text54 = requestDate
        changeColumnsQuery.text0 = supplier
        changeColumnsQuery.text85 = mpn
        changeColumnsQuery.text36 = srn
        changeColumnsQuery.text51 = location
        changeColumnsQuery.text45 = warehouse

        Dim requester As New Person()
        Dim requester_info As New PersonsAndTeam()
        Dim requester_infolist As New List(Of PersonsAndTeam)
        requester_info.id = login.user_mondayid
        requester_info.kind = "person"
        requester_infolist.Add(requester_info)
        requester.personsAndTeams = requester_infolist.ToArray

        Dim manager As New Person()
        Dim manager_info As New PersonsAndTeam()
        Dim manager_infolist As New List(Of PersonsAndTeam)

        Select Case login.user_department
            Case "Electronics"
                For Each dr As DataRow In login.usersTable.Rows
                    If dr(3) = "Dept. Manager" And dr(9) = "Electronics" Then
                        manager_info.id = dr(10)
                        Exit For
                    End If
                Next
            Case "Mechanical"
                For Each dr As DataRow In login.usersTable.Rows
                    If dr(3) = "Dept. Manager" And dr(9) = "Mechanical" Then
                        manager_info.id = dr(10)
                        Exit For
                    End If
                Next
        End Select

        'manager_info.id = "15093407"
        manager_info.kind = "person"
        manager_infolist.Add(manager_info)
        manager.personsAndTeams = manager_infolist.ToArray


        changeColumnsQuery.person = requester
        changeColumnsQuery.people7 = manager

        Dim column_values = JsonConvert.SerializeObject(changeColumnsQuery).ToString
        column_values = column_values.Replace("""", "\""")

        Dim changeColumnsOnMonday As String = "mutation{change_multiple_column_values(item_id:" + monday_id + ", board_id:" + mondayBoardID + ", column_values: """ + column_values + """){id}}"

        If monday_id <> "" Then
            Dim recons As Integer

sendQuery:
            Try

                For retries = 1 To 30
                    If retries <> 30 Then
                        Dim mondayResponse As Object = Await SendMondayRequest(changeColumnsOnMonday)

                        If mondayResponse(0) = "error" Then

                            Return {"error", $"Error occured while connecting to Monday. Retrying ({retries}/30)"}
                        Else
                            recons = 0

                            Try

                                Dim pcm As New Odbc.OdbcCommand
                                pcm = pcon.CreateCommand()

                                If monday_id <> "" Then

                                End If

                                With pcm
                                    .CommandText = "UPDATE ""LasermetPARTS_forApproval"" SET ""monday_id"" = ? WHERE ""lasermet_part_no"" = ? AND ""request_id"" = ?"
                                    .Parameters.Add("@monday_id", Odbc.OdbcType.VarChar).Value = monday_id
                                    .Parameters.Add("@lasermet_part_no", Odbc.OdbcType.VarChar).Value = part_no
                                    .Parameters.Add("@request_id", Odbc.OdbcType.VarChar).Value = item_id
                                End With


                                pcon.Open()
                                pcm.ExecuteNonQuery()
                                pcon.Close()

                                Return {"success", "Request succesfully sent for approval"}

                                Exit For

                            Catch ex As Exception

                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                pcon.Close()

                            End Try

                        End If
                    End If
                Next



            Catch ex As Exception
                If recons > 0 And recons < 30 Then
                    recons += 1
                    Return {"error", $"Attempting to reconnect to Monday {recons}/30"}
                    Thread.Sleep(1000)
                    GoTo sendQuery
                ElseIf recons >= 30 Then
                    MessageBox.Show("Failed to connect to Monday. Press OK to restart", "Connection Issue", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    If DialogResult.OK Then
                        Application.Restart()
                    End If
                End If
                Exit Function
            End Try

        Else

            Exit Function

        End If


    End Function

    Public Async Function updateStatusOnMonday(monday_id As String, status As String, part_no As String, dwg_no As String, description As String, specs As String, category As String, subcategory As String, group_name As String, revCC As String, issCC As String, location As String, warehouse As String, Optional comments As String = "N/A", Optional ctrl As ToolStripStatusLabel = Nothing, Optional managerApprovalDate As String = "", Optional finalApprovalDate As String = "", Optional supplier As String = "", Optional mpn As String = "", Optional srn As String = "") As Task(Of String())

        Dim finalpartNo As String = part_no

        If login.account_type = "Inventory Admin" And status = "Approved" Then

            'Generate final part no. to be added to database.

            Dim partsNums As New List(Of Integer)
            Dim categoryNo As String = part_no.Split("-")(2)

            'Check final database

            Try

                Dim sqlQuery As String = "SELECT * from ""LasermetPARTS"""
                pda = New Odbc.OdbcDataAdapter()
                Dim pdcb As New Odbc.OdbcCommandBuilder(pda)
                pda.SelectCommand = New Odbc.OdbcCommand(sqlQuery, pcon)
                Dim partsTable As New DataTable()
                pcon.Open()
                pda.Fill(partsTable)
                pcon.Close()

                For Each dr As DataRow In partsTable.Rows

                    Dim catNo As String = dr(0).ToString.Split("-")(2)

                    If catNo = categoryNo Then
                        partsNums.Add(dr(0).ToString.Split("-")(3).Replace("0", "").Trim)
                    End If
                Next

            Catch ex As Exception
                MessageBox.Show("Exception caught. See console", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Console.WriteLine(ex.Message)
            End Try

            'Check temporary database for fully approved parts with same category number


            Try

                Dim sqlQuery As String = "SELECT * from ""LasermetPARTS_forApproval"" WHERE ""manager_approval"" = 'Approved' AND ""final_approval"" = 'Approved'"
                pda = New Odbc.OdbcDataAdapter()
                Dim pdcb As New Odbc.OdbcCommandBuilder(pda)
                pda.SelectCommand = New Odbc.OdbcCommand(sqlQuery, pcon)
                Dim partsTable As New DataTable()
                pcon.Open()
                pda.Fill(partsTable)
                pcon.Close()

                For Each dr As DataRow In partsTable.Rows

                    Dim catNo As String = dr(0).ToString.Split("-")(2)

                    If catNo = categoryNo Then
                        partsNums.Add(dr(0).ToString.Split("-")(3).Replace("0", "").Trim)
                    End If
                Next

            Catch ex As Exception
                MessageBox.Show("Exception caught. See console", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Console.WriteLine(ex.Message)
            End Try

            Dim seriesNo As String = ""

            If partsNums IsNot Nothing AndAlso partsNums.Count > 0 Then
                Dim nth As Integer = partsNums.Max + 1
                seriesNo = Strings.StrDup(5 - nth.ToString.Length, "0") + nth.ToString
            Else
                seriesNo = "00001"
            End If

            finalpartNo = $"{part_no}-{seriesNo}"

        End If

        Dim responseString As String()
        Dim changeColumnsQuery As New MultipleColumnValues()

        Select Case login.account_type

            Case "Inventory Admin"
                changeColumnsQuery.name = finalpartNo
                changeColumnsQuery.color = status
                changeColumnsQuery.text8 = dwg_no
                changeColumnsQuery.text1 = description
                changeColumnsQuery.text84 = specs
                changeColumnsQuery.text = category
                changeColumnsQuery.text5 = subcategory
                changeColumnsQuery.text53 = group_name
                changeColumnsQuery.text9 = revCC
                changeColumnsQuery.text2 = issCC
                changeColumnsQuery.text0 = supplier
                changeColumnsQuery.text4 = finalApprovalDate
                changeColumnsQuery.text85 = mpn
                changeColumnsQuery.text36 = srn
                changeColumnsQuery.text51 = location
                changeColumnsQuery.text45 = warehouse

            Case Else
                changeColumnsQuery.name = part_no
                changeColumnsQuery.status = status
                changeColumnsQuery.text8 = dwg_no
                changeColumnsQuery.text1 = description
                changeColumnsQuery.text84 = specs
                changeColumnsQuery.text = category
                changeColumnsQuery.text5 = subcategory
                changeColumnsQuery.text53 = group_name
                changeColumnsQuery.text9 = revCC
                changeColumnsQuery.text2 = issCC
                changeColumnsQuery.text0 = supplier
                changeColumnsQuery.text17 = managerApprovalDate
                changeColumnsQuery.text85 = mpn
                changeColumnsQuery.text36 = srn
                changeColumnsQuery.text51 = location
                changeColumnsQuery.text45 = warehouse

        End Select

        changeColumnsQuery.text3 = comments

        Dim settings As New JsonSerializerSettings

        settings.NullValueHandling = NullValueHandling.Ignore

        Dim queryString = JsonConvert.SerializeObject(changeColumnsQuery, settings)
        queryString = queryString.Replace("""", "\""")

        Dim changeColumnsOnMonday As String

        Select Case status
            Case "Approved"
                Select Case login.account_type
                    Case "Dept. Manager"
                        changeColumnsOnMonday = "mutation{change_multiple_column_values(item_id:" + monday_id + ", board_id:" + mondayBoardID + ", column_values: """ + queryString + """, create_labels_if_missing: true){id}}"
                    Case "Gen. Manager"
                        changeColumnsOnMonday = "mutation{change_multiple_column_values(item_id:" + monday_id + ", board_id:" + mondayBoardID + ", column_values: """ + queryString + """, create_labels_if_missing: true){id}}"
                    Case "Inventory Admin"
                        changeColumnsOnMonday = "mutation{change_multiple_column_values(item_id:" + monday_id + ", board_id:" + mondayBoardID + ", column_values: """ + queryString + """, create_labels_if_missing: true){id}}"
                    Case "App Admin"
                        changeColumnsOnMonday = "mutation{change_multiple_column_values(item_id:" + monday_id + ", board_id:" + mondayBoardID + ", column_values: """ + queryString + """, create_labels_if_missing: true){id}}"
                End Select

            Case "Denied"
                Select Case login.account_type

                    Case "Dept. Manager"
                        changeColumnsOnMonday = "mutation{change_multiple_column_values(item_id:" + monday_id + ", board_id:" + mondayBoardID + ", column_values: """ + queryString + """, create_labels_if_missing: true){id}}"
                    Case "Gen. Manager"
                        changeColumnsOnMonday = "mutation{change_multiple_column_values(item_id:" + monday_id + ", board_id:" + mondayBoardID + ", column_values: """ + queryString + """, create_labels_if_missing: true){id}}"
                    Case "Inventory Admin"
                        changeColumnsOnMonday = "mutation{change_multiple_column_values(item_id:" + monday_id + ", board_id:" + mondayBoardID + ", column_values: """ + queryString + """, create_labels_if_missing: true){id}}"
                    Case "App Admin"
                        changeColumnsOnMonday = "mutation{change_multiple_column_values(item_id:" + monday_id + ", board_id:" + mondayBoardID + ", column_values: """ + queryString + """, create_labels_if_missing: true){id}}"
                End Select
            Case "Needs additional information"
                changeColumnsOnMonday = "mutation{change_multiple_column_values(item_id:" + monday_id + ", board_id:" + mondayBoardID + ", column_values: """ + queryString + """, create_labels_if_missing: true){id}}"
        End Select


        Dim recons As Integer
sendQuery:
        Try

            For retries = 1 To 30
                If retries <> 30 Then
                    Dim mondayResponse As Object = Await SendMondayRequest(changeColumnsOnMonday)


                    If mondayResponse(0) = "error" Then

                        responseString = {"error", $"Error occured while connecting to Monday. Retrying ({retries}/30)"}
                        ctrl.Text = responseString(1)

                    Else

                        Dim sqlQuery As String

                        Select Case login.account_type
                            Case "Inventory Admin"
                                sqlQuery = "UPDATE ""LasermetPARTS_forApproval"" SET ""lasermet_part_no"" = ?, ""final_approval"" = ?, ""description"" = ?, ""specifications"" = ?, ""category"" = ?, ""subcategory"" = ?, ""group_name"" = ?, ""drawing_no"" = ?, ""comments"" = ?, ""issues_nominal_code"" = ?, ""issues_cost_center"" = ?, ""final_approval_date"" = ?, ""supplier"" = ?, ""mpn"" = ?, ""supplier_ref_no"" = ?, ""warehouse"" = ?, ""part_location"" = ? WHERE ""monday_id"" = ?"
                            Case Else
                                sqlQuery = "UPDATE ""LasermetPARTS_forApproval"" SET ""lasermet_part_no"" = ?, ""manager_approval"" = ?, ""description"" = ?, ""specifications"" = ?, ""category"" = ?, ""subcategory"" = ?, ""group_name"" = ?, ""drawing_no"" = ?, ""comments"" = ?, ""issues_nominal_code"" = ?, ""issues_cost_center"" = ?, ""manager_approval_date"" = ?, ""supplier"" = ?, ""mpn"" = ?, ""supplier_ref_no"" = ?, ""warehouse"" = ?, ""part_location"" = ? WHERE ""monday_id"" = ?"
                        End Select


                        Select Case status
                            Case "Approved"
                                Select Case login.account_type
                                    Case "Dept. Manager"
                                        responseString = {"success", "Manager Approval completed."}
                                    Case "Gen. Manager"
                                        responseString = {"success", "Manager Approval completed."}
                                    Case "Inventory Admin"
                                        responseString = {"success", "Final Approval completed."}
                                    Case "App Admin"
                                        responseString = {"success", "Manager Approval completed."}
                                End Select

                            Case "Denied"

                                Select Case login.account_type
                                    Case "Dept. Manager"
                                        responseString = {"success", "Request denied by Dept. Manager"}
                                    Case "Gen. Manager"
                                        responseString = {"success", "Request denied by Gen. Manager"}
                                    Case "Inventory Admin"
                                        responseString = {"success", "Request denied by Inventory Admin"}
                                    Case "App Admin"
                                        responseString = {"success", "Request denied by App Admin"}
                                End Select

                            Case "Needs additional information"

                                responseString = {"success", "Update sent on Monday"}

                        End Select

                        recons = 0

                        Try

                            Dim pcm As New Odbc.OdbcCommand
                            pcm = pcon.CreateCommand()

                            With pcm
                                .CommandText = sqlQuery

                                Select Case login.account_type
                                    Case "Inventory Admin"
                                        .Parameters.Add("@lasermet_part_no", Odbc.OdbcType.VarChar).Value = finalpartNo
                                        .Parameters.Add("@final_approval", Odbc.OdbcType.VarChar).Value = status
                                        .Parameters.Add("@description", Odbc.OdbcType.VarChar).Value = description
                                        .Parameters.Add("@specifications", Odbc.OdbcType.VarChar).Value = specs
                                        .Parameters.Add("@category", Odbc.OdbcType.VarChar).Value = category
                                        .Parameters.Add("@subcategory", Odbc.OdbcType.VarChar).Value = subcategory
                                        .Parameters.Add("@group_name", Odbc.OdbcType.VarChar).Value = group_name
                                        .Parameters.Add("@drawing_no", Odbc.OdbcType.VarChar).Value = dwg_no
                                        .Parameters.Add("@comments", Odbc.OdbcType.VarChar).Value = comments
                                        .Parameters.Add("@issues_nominal_code", Odbc.OdbcType.VarChar).Value = revCC
                                        .Parameters.Add("@issues_cost_center", Odbc.OdbcType.VarChar).Value = issCC
                                        .Parameters.Add("@final_approval_date", Odbc.OdbcType.VarChar).Value = finalApprovalDate
                                        .Parameters.Add("@supplier", Odbc.OdbcType.VarChar).Value = supplier
                                        .Parameters.Add("@mpn", Odbc.OdbcType.VarChar).Value = mpn
                                        .Parameters.Add("@supplier_ref_no", Odbc.OdbcType.VarChar).Value = srn
                                        .Parameters.Add("@warehouse", Odbc.OdbcType.VarChar).Value = warehouse
                                        .Parameters.Add("@part_location", Odbc.OdbcType.VarChar).Value = location
                                        .Parameters.Add("@monday_id", Odbc.OdbcType.VarChar).Value = monday_id
                                    Case Else
                                        .Parameters.Add("@lasermet_part_no", Odbc.OdbcType.VarChar).Value = part_no
                                        .Parameters.Add("@manager_approval", Odbc.OdbcType.VarChar).Value = status
                                        .Parameters.Add("@description", Odbc.OdbcType.VarChar).Value = description
                                        .Parameters.Add("@specifications", Odbc.OdbcType.VarChar).Value = specs
                                        .Parameters.Add("@category", Odbc.OdbcType.VarChar).Value = category
                                        .Parameters.Add("@subcategory", Odbc.OdbcType.VarChar).Value = subcategory
                                        .Parameters.Add("@group_name", Odbc.OdbcType.VarChar).Value = group_name
                                        .Parameters.Add("@drawing_no", Odbc.OdbcType.VarChar).Value = dwg_no
                                        .Parameters.Add("@comments", Odbc.OdbcType.VarChar).Value = comments
                                        .Parameters.Add("@issues_nominal_code", Odbc.OdbcType.VarChar).Value = revCC
                                        .Parameters.Add("@issues_cost_center", Odbc.OdbcType.VarChar).Value = issCC
                                        .Parameters.Add("@manager_approval_date", Odbc.OdbcType.VarChar).Value = managerApprovalDate
                                        .Parameters.Add("@supplier", Odbc.OdbcType.VarChar).Value = supplier
                                        .Parameters.Add("@mpn", Odbc.OdbcType.VarChar).Value = mpn
                                        .Parameters.Add("@supplier_ref_no", Odbc.OdbcType.VarChar).Value = srn
                                        .Parameters.Add("@warehouse", Odbc.OdbcType.VarChar).Value = warehouse
                                        .Parameters.Add("@part_location", Odbc.OdbcType.VarChar).Value = location
                                        .Parameters.Add("@monday_id", Odbc.OdbcType.VarChar).Value = monday_id
                                End Select


                            End With


                            pcon.Open()
                            pcm.ExecuteNonQuery()
                            pcon.Close()

                            If ctrl IsNot Nothing Then
                                ctrl.Text = responseString(1)
                            End If


                            Return responseString

                            Exit For

                        Catch ex As Exception

                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            pcon.Close()

                        End Try

                    End If
                End If
            Next



        Catch ex As Exception
            If recons >= 0 And recons < 30 Then
                recons += 1
                Return {"error", $"Attempting to reconnect to Monday {recons}/30"}
                Thread.Sleep(1000)
                GoTo sendQuery
            ElseIf recons >= 30 Then
                MessageBox.Show("Failed to connect to Monday. Press OK to restart", "Connection Issue", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If DialogResult.OK Then
                    Application.Restart()
                End If
            End If
            Exit Function
        End Try

        Return responseString

    End Function

    Public Async Function SendMondayRequest(ByVal myQuery As String) As Task(Of Object)
        Dim options = New RestClientOptions("https://api.monday.com/v2")
        options.ThrowOnAnyError = True
        options.MaxTimeout = queryTimeOut
        Dim client = New RestClient(options)
        Dim request = New RestRequest()
        request.Timeout = queryTimeOut
        request.Method = Method.Post
        request.AddHeader("Authorization", apiKey)
        request.AddQueryParameter("query", myQuery)
        Dim response = New RestResponse
        response = Await client.PostAsync(request)
        'If response.IsSuccessStatusCode = True Then
        '    Return response.Content
        'Else
        '    Return False
        'End If
        If response.IsSuccessStatusCode Then
            'response has a statuscode of 200
            'but it might have a parse error, which still is status 200.
            If response.Content.Contains("error") Or response.Content.Contains("error_message") Or response.Content.Contains("errors") Then
                'response has a status code 200, but has a monday.com error.
                Return {"error", response.Content}
            Else
                'response has a status code 200, with readable results.
                Return {"success", response.Content}
            End If
        Else
            Throw New System.Exception("An error has occured at function: SendMondayRequestVersion2")
        End If
    End Function

    Public Async Function getMondayID(email As String) As Task(Of String)

        Dim getUsers As String = "query{ users{ id name email }}"
        Dim monday_id As String

        Dim recons As Integer
sendQuery:
        Try

            For retries = 1 To 30
                If retries <> 30 Then
                    Dim usersFromMonday As Object = Await SendMondayRequest(getUsers)

                    If usersFromMonday(0) = "error" Then

                        Return $"Error occured while connecting to Monday. Retrying ({retries}/30)"
                    Else

                        Dim sqlQuery As String
                        Dim responseString As String

                        Dim mondayUsersList As MondayUsers = JsonConvert.DeserializeObject(Of MondayUsers)(usersFromMonday(1))

                        For Each user In mondayUsersList.data.users

                            If user.email = email Then
                                monday_id = user.id
                            End If

                        Next


                        recons = 0

                        Return monday_id

                    End If
                End If
            Next



        Catch ex As Exception
            If recons > 0 And recons < 30 Then
                recons += 1
                Return $"Attempting to reconnect to Monday {recons}/30"
                Thread.Sleep(1000)
                GoTo sendQuery
            ElseIf recons >= 30 Then
                MessageBox.Show("Failed to connect to Monday. Press OK to restart", "Connection Issue", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If DialogResult.OK Then
                    Application.Restart()
                End If
            End If
            Exit Function
        End Try

    End Function

End Module
