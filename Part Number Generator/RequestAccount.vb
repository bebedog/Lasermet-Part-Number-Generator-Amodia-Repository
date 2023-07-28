'================================================================================
'FILE        : RequestAccount.vb
'AUTHORS     : Jayson O. Amodia, Elyn Abby Toledo, Kathryn Marie P. Sigaya
'DESCRIPTION : This file shows the processes and design menu of the Request Account Menu of the program.
'COPYRIGHT   : 05 July 2023
'REVISION HISTORY
'Date: 			By: 		Description:
'2023/07/05     Sigaya      Documentation
'================================================================================

' References of important packages and/or directories 
Imports BCrypt.Net.BCrypt

'================================================================================
'CLASS       : RequestAccount
'DESCRIPTION : Class that stores variables, functions, and other classes for the Request Account Menu.
'================================================================================
Public Class RequestAccount

    '================================================================================
    'SUBROUTINE   : createAccountRequest
    'DESCRIPTION  : Asynchronous subroutine that retrieves the inputted information of the user for creating the account,
    '               and pushing them to the database.
    'ARGUMENTS    : firstName, surname, username, password, lasermet_email, location, department - String
    '================================================================================
    Private Async Sub createAccountRequest(firstname As String,
                                           surname As String,
                                           username As String,
                                           password As String,
                                           lasermet_email As String,
                                           location As String,
                                           department As String)

        'getMondayID function is found at the MondayAPIFunctions.vb file
        Dim monday_id As String = Await getMondayID(lasermet_email)

        If monday_id IsNot Nothing Or String.IsNullOrWhiteSpace(monday_id) = False Then

            'Check if e-mail and username already exists

            Call connectPostGre()

            Try

                Dim sqlQuery As String = "SELECT * from ""users"";"
                pda = New Odbc.OdbcDataAdapter()
                Dim pdcb As New Odbc.OdbcCommandBuilder(pda)
                pda.SelectCommand = New Odbc.OdbcCommand(sqlQuery, pcon)
                Dim dtable As New DataTable()
                Dim usernames As New List(Of String)
                Dim emails As New List(Of String)
                Dim passwordHashed As String = BCrypt.Net.BCrypt.HashPassword(password)

                pcon.Open()
                pda.Fill(dtable)
                pcon.Close()

                For Each dr As DataRow In dtable.Rows
                    usernames.Add(dr(0))
                    emails.Add(dr(2))
                Next

                If usernames.IndexOf(tbUsername.Text) >= 0 Then
                    MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                ElseIf emails.IndexOf(tbEmail.Text) >= 0 Then
                    MessageBox.Show("E-mail already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else

                    Try

                        Dim sqlQuery2 As String = "SELECT * from ""account_requests"" ORDER BY date_requested DESC"
                        pda = New Odbc.OdbcDataAdapter()
                        Dim pdcb2 As New Odbc.OdbcCommandBuilder(pda)
                        pda.SelectCommand = New Odbc.OdbcCommand(sqlQuery2, pcon)
                        Dim dtable2 As New DataTable()
                        Dim requests_emails As New List(Of String)
                        Dim requests_usernames As New List(Of String)
                        pcon.Open()
                        pda.Fill(dtable2)
                        pcon.Close()

                        For Each dr As DataRow In dtable2.Rows
                            requests_emails.Add(dr(2))
                            requests_usernames.Add(dr(0))
                        Next

                        If requests_emails.IndexOf(lasermet_email) >= 0 Then
                            MessageBox.Show($"A request was already submitted for the e-mail {lasermet_email}", "Duplicate request", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ElseIf requests_usernames.IndexOf(username) >= 0 Then
                            MessageBox.Show($"A request was already submitted for the username {username}", "Duplicate request", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            Try
                                Dim pcm As New Odbc.OdbcCommand
                                pcm = pcon.CreateCommand()

                                With pcm
                                    .CommandText = "INSERT INTO ""account_requests"" (""username"", ""password"", ""e-mail"", ""first_name"", ""surname"", ""date_requested"",""location"", ""department"", ""monday_id"") VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)"
                                    .Parameters.Add("@username", Odbc.OdbcType.VarChar).Value = username
                                    .Parameters.Add("@password", Odbc.OdbcType.VarChar).Value = passwordHashed
                                    .Parameters.Add("@e-mail", Odbc.OdbcType.VarChar).Value = lasermet_email
                                    .Parameters.Add("@first_name", Odbc.OdbcType.VarChar).Value = firstname
                                    .Parameters.Add("@surname", Odbc.OdbcType.VarChar).Value = surname
                                    .Parameters.Add("@date_added", Odbc.OdbcType.VarChar).Value = DateTime.Now().ToString("yyyy-MM-dd HH:mm:ss")
                                    .Parameters.Add("@location", Odbc.OdbcType.VarChar).Value = location
                                    .Parameters.Add("@department", Odbc.OdbcType.VarChar).Value = department
                                    .Parameters.Add("@monday_id", Odbc.OdbcType.VarChar).Value = monday_id
                                End With

                                pcon.Open()
                                pcm.ExecuteNonQuery()
                                pcon.Close()

                                'Check if account request was succesfully sent

                                Try

                                    Dim sqlQuery3 As String = "SELECT * from ""account_requests"" ORDER BY date_requested DESC"
                                    pda = New Odbc.OdbcDataAdapter()
                                    Dim pdcb3 As New Odbc.OdbcCommandBuilder(pda)
                                    pda.SelectCommand = New Odbc.OdbcCommand(sqlQuery2, pcon)
                                    Dim dtable3 As New DataTable()
                                    Dim requests2 As New List(Of String)
                                    pcon.Open()
                                    pda.Fill(dtable3)
                                    pcon.Close()

                                    For Each dr As DataRow In dtable3.Rows
                                        requests2.Add(dr(2))
                                    Next

                                    If requests2.IndexOf(lasermet_email) < 0 Then
                                        MessageBox.Show("Request not sent", "Submission error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Else
                                        Dim requestSent As DialogResult = MessageBox.Show("New account request sent for approval", "Request sent for approval", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        If DialogResult.OK Then
                                            Me.Close()
                                            login.Show()
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
                        End If

                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                        pcon.Close()
                    End Try

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, $"Exception thrown", MessageBoxButtons.OK, MessageBoxIcon.Error)
                pcon.Close()
            End Try

        Else
            MessageBox.Show("Please enter a valid Lasermet e-mail address", ">:(", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    '================================================================================
    'SUBROUTINE   : createAccountRequest
    'DESCRIPTION  : Asynchronous subroutine that retrieves the inputted information of the user for creating the account,
    '               and pushing them to the database.
    'ARGUMENTS    : firstName, surname, username, password, lasermet_email, location, department - String
    '================================================================================
    Private Sub btnSendRequest_Click(sender As Object, e As EventArgs) Handles btnSendRequest.Click
        disableAllControls(Me)

        Dim emptyFields As Integer = 0

        For Each c As Control In Me.Controls
            If c.GetType Is GetType(MetroFramework.Controls.MetroComboBox) Or c.GetType Is GetType(MetroFramework.Controls.MetroTextBox) Then

                If String.IsNullOrWhiteSpace(c.Text) Then
                    emptyFields += 1
                End If

            End If
        Next

        If emptyFields <= 0 Then
            createAccountRequest(tbFirstname.Text, tbSurname.Text, tbUsername.Text, tbPassword.Text, tbEmail.Text, cbLocation.Text, cbDepartment.Text)
        Else
            MessageBox.Show("Please fill up all the above fields", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Close()
        login.Show()
    End Sub

    Private Sub RequestAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbLocation.Items.Add("Bournemouth")
        cbLocation.Items.Add("Cebu, PH")
        cbLocation.SelectedIndex = 0
    End Sub

    Private Sub RequestAccount_Close(sender As Object, e As EventArgs) Handles MyBase.Closed

        Application.Restart()

    End Sub
End Class