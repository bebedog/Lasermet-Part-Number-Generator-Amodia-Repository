Public Class ChangePassword
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        login.Show()
    End Sub

    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tbUsername.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tbUsername.AutoCompleteSource = AutoCompleteSource.CustomSource
        tbUsername.AutoCompleteCustomSource.AddRange(login.usernames.ToArray)

    End Sub

    Private Sub ChangePassword_Close(sender As Object, e As EventArgs) Handles MyBase.Closed

        Application.Restart()

    End Sub

    Private Sub ChangePW(username As String, oldpassword As String, newpassword As String)

        If login.usernames.IndexOf(username) < 0 Then

            MessageBox.Show("ඞ SUSSY", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            For Each dr As DataRow In login.usersTable.Rows

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

    Private Sub enableAllControls()

        For Each c As Control In Me.Controls
            c.Enabled = True
        Next

    End Sub

    Private Sub disableAllControls()

        For Each c As Control In Me.Controls
            c.Enabled = False
        Next

    End Sub

    Private Sub btnChangePW_Click(sender As Object, e As EventArgs) Handles btnChangePW.Click

        If String.IsNullOrWhiteSpace(tbUsername.Text) Or String.IsNullOrWhiteSpace(tbPasswordOld.Text) Or String.IsNullOrWhiteSpace(tbPasswordNew.Text) Then

            MessageBox.Show("Kindly fill up all the above fields", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            disableAllControls()
            ChangePW(tbUsername.Text, tbPasswordOld.Text, tbPasswordNew.Text)

        End If



    End Sub
End Class