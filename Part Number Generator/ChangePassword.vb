'================================================================================
'FILE        : ChangePassword.vb
'AUTHORS     : Jayson O. Amodia, Elyn Abby Toledo, Kathryn Marie P. Sigaya
'DESCRIPTION : This file shows the processes and design menu of the Change Password Menu of the program.
'COPYRIGHT   : 07 July 2023
'REVISION HISTORY
'Date: 			By: 		Description:
'2023/07/07     Sigaya      Documentation
'================================================================================

'================================================================================
'CLASS       : ChangePassword
'DESCRIPTION : Class that stores variables, functions, and other classes for the Change Password Menu.
'================================================================================
Public Class ChangePassword

    '================================================================================
    'SUBROUTINE   : btnBack_Click
    'DESCRIPTION  : Subroutine that returns to the Login menu.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '================================================================================
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        login.Show()
    End Sub

    '================================================================================
    'SUBROUTINE   : ChangePassword_Load
    'DESCRIPTION  : Subroutine that suggests usernames upon input.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '================================================================================
    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'suggests usernames via selection
        tbUsername.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tbUsername.AutoCompleteSource = AutoCompleteSource.CustomSource
        tbUsername.AutoCompleteCustomSource.AddRange(login.usernames.ToArray)

    End Sub

    '================================================================================
    'SUBROUTINE   : ChangePassword_Close
    'DESCRIPTION  : Subroutine that closes the Change Password Menu.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '================================================================================
    Private Sub ChangePassword_Close(sender As Object, e As EventArgs) Handles MyBase.Closed

        Application.Restart()

    End Sub

    '================================================================================
    'SUBROUTINE   : ChangePW
    'DESCRIPTION  : Subroutine that changes the user's password.
    'ARGUMENTS    : username, oldpassword, newpassword - String
    '================================================================================
    Private Sub ChangePW(username As String, oldpassword As String, newpassword As String)

        If login.usernames.IndexOf(username) < 0 Then

            MessageBox.Show("ඞ SUSSY", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            'the table is found at login.vb
            For Each dr As DataRow In login.usersTable.Rows

                'so the data row format in the usersTable is
                'column zero - username
                'column one - password
                If dr(0) = username Then
                    If BCrypt.Net.BCrypt.Verify(oldpassword, dr(1)) = True Then

                        Call connectPostGre()

                        Try

                            Dim pcm As New Odbc.OdbcCommand
                            pcm = pcon.CreateCommand()

                            With pcm
                                .CommandText = "UPDATE ""users"" SET ""password"" = ? WHERE ""username"" = ?"
                                .Parameters.Add("@password", Odbc.OdbcType.VarChar).Value = BCrypt.Net.BCrypt.HashPassword(newpassword)
                                .Parameters.Add("@username", Odbc.OdbcType.VarChar).Value = username
                            End With


                            pcon.Open()
                            pcm.ExecuteNonQuery()
                            pcon.Close()

                            'Check if new user was added to DB.

                            Try

                                Dim sqlQuery As String = "SELECT * from ""users"""
                                pda = New Odbc.OdbcDataAdapter()
                                Dim pdcb As New Odbc.OdbcCommandBuilder(pda)
                                pda.SelectCommand = New Odbc.OdbcCommand(sqlQuery, pcon)
                                Dim dtable As New DataTable()
                                pcon.Open()
                                pda.Fill(dtable)
                                pcon.Close()

                                For Each ur As DataRow In dtable.Rows

                                    'refer to "users" table in PostGreSQL
                                    'column 0 - username
                                    'column 1 - password
                                    If ur(0) = username Then

                                        If BCrypt.Net.BCrypt.Verify(newpassword, ur(1)) Then

                                            MessageBox.Show("Password changed succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            If DialogResult.OK Then
                                                Application.Restart()
                                            End If

                                        End If

                                    End If

                                Next

                            Catch ex As Exception
                                Console.WriteLine(ex.Message)
                                pcon.Close()
                            End Try

                        Catch ex As Exception
                            Console.WriteLine(ex.Message)
                            pcon.Close()
                        End Try

                    Else
                        MessageBox.Show("Incorrect Password", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        enableAllControls()

                    End If
                End If

            Next

        End If


    End Sub

    '================================================================================
    'SUBROUTINE   : enableAllControls
    'DESCRIPTION  : Enables all controls in the current window.
    'ARGUMENTS    : none
    '================================================================================
    Private Sub enableAllControls()

        For Each c As Control In Me.Controls
            c.Enabled = True
        Next

    End Sub

    '================================================================================
    'SUBROUTINE   : disableAllControls
    'DESCRIPTION  : Disables all controls in the current window.
    'ARGUMENTS    : none
    '================================================================================
    Private Sub disableAllControls()

        For Each c As Control In Me.Controls
            c.Enabled = False
        Next

    End Sub

    '================================================================================
    'SUBROUTINE   : btnChangePW_Click
    'DESCRIPTION  : Checks all fields if they were filled out.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '================================================================================
    Private Sub btnChangePW_Click(sender As Object, e As EventArgs) Handles btnChangePW.Click

        If String.IsNullOrWhiteSpace(tbUsername.Text) Or String.IsNullOrWhiteSpace(tbPasswordOld.Text) Or String.IsNullOrWhiteSpace(tbPasswordNew.Text) Then

            MessageBox.Show("Kindly fill up all the above fields", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            disableAllControls()
            ChangePW(tbUsername.Text, tbPasswordOld.Text, tbPasswordNew.Text)

        End If
    End Sub
End Class