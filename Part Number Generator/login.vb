﻿Imports System.IO
Imports System.Threading.Tasks
Imports Squirrel
Imports BCrypt.Net.BCrypt


Public Class login

    Public username As String
    Public firstname As String
    Public surname As String
    Public account_type As String
    Public user_email As String
    Public user_department As String
    Public user_location As String
    Public user_mondayid As String

    Public categoriesTable As New DataTable
    Public usernames As New List(Of String)
    Public usersTable As New DataTable


    'START of Squirrel Objects
    Public Class UpdateInfo
        Public CurrentlyInstalledVersion As ReleaseEntry
        Public FutureReleaseEntry As ReleaseEntry
        Public ReleasesToApply As List(Of ReleaseEntry)
    End Class

    Public Class ReleaseEntry
        Public Property SHA1 As String
        Public Property Filename As String
        Public Property Filesize As Long
        Public Property IsDelta As Boolean
    End Class
    'END of Squirrel Objects

    Private Async Function CheckForUpdates() As Task
        Try
            Using manager = Await UpdateManager.GitHubUpdateManager($"https://github.com/bebedog/Lasermet-Part-Number-Generator-Amodia-Repository")
                'Await manager.UpdateApp()
                Dim results = Await manager.CheckForUpdate()
                Console.WriteLine(results)

                'the CheckForUpdate method returns an UpdateInfo Object which has the following parameters

                ' Public Class UpdateInfo
                '{
                '	Public ReleaseEntry CurrentlyInstalledVersion;
                '	Public ReleaseEntry FutureReleaseEntry;
                '	Public List<ReleaseEntry> ReleasesToApply;
                '}

                'The ReleaseEntry is an Object with the following parameters:

                'public interface ReleaseEntry
                '{
                '    public string SHA1;
                '    public string Filename;
                '    public long Filesize;
                '    public bool IsDelta;
                '}
                Dim numberOfUpdates As Integer = results.ReleasesToApply.Count
                If (numberOfUpdates > 0) Then
                    'this means that there is a new update.
                    Dim latestVersion = results.ReleasesToApply(numberOfUpdates - 1).Version.ToString
                    MessageBox.Show($"Lasermet Part Number Generator v{latestVersion} is now available on GitHub." + Environment.NewLine +
                                    $"Once this instance is closed, please reopen the program.", "Update available!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Await manager.UpdateApp()
                    Application.Exit()
                Else
                    'no new update.
                End If


            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Oops, something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub checkAccountCred()

        Dim passwordHash As String = BCrypt.Net.BCrypt.HashPassword(tbPassword.Text)

        If String.IsNullOrWhiteSpace(tbUsername.Text) Then
            MessageBox.Show("Please enter your username!", "No username?", MessageBoxButtons.OK, MessageBoxIcon.Error)
            enableAllControls()
        ElseIf String.IsNullOrWhiteSpace(tbPassword.Text) Then
            MessageBox.Show("Please enter your password!", "No password?", MessageBoxButtons.OK, MessageBoxIcon.Error)
            enableAllControls()
        ElseIf String.IsNullOrWhiteSpace(tbUsername.Text) And String.IsNullOrWhiteSpace(tbPassword.Text) Then
            MessageBox.Show("Please enter your username and password!", "No username and password?", MessageBoxButtons.OK, MessageBoxIcon.Error)
            enableAllControls()
        Else
            Call connectPostGre()

            Try

                For Each dr As DataRow In usersTable.Rows

                    usernames.Add(dr(0))

                Next

                If usernames.IndexOf(tbUsername.Text) < 0 Then
                    MessageBox.Show("Username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    enableAllControls()
                Else
                    For Each dr As DataRow In usersTable.Rows
                        If dr(0) = tbUsername.Text Then
                            If BCrypt.Net.BCrypt.Verify(tbPassword.Text, dr(1)) = True Then
                                username = tbUsername.Text
                                firstname = dr(4)
                                surname = dr(5)
                                account_type = dr(3)
                                user_location = dr(8)
                                user_department = dr(9)
                                user_mondayid = dr(10)
                                My.Settings.mostRecentUser = tbUsername.Text
                                My.Settings.Save()

                                Select Case account_type
                                    Case "App Admin"
                                        MessageBox.Show($"Welcome {firstname}!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        If DialogResult.OK Then
                                            enableAllControls()
                                            Me.Hide()
                                            AppAdminDashboard.Show()
                                        End If

                                    Case "Inventory Admin"
                                        MessageBox.Show($"Welcome {firstname}!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                        If DialogResult.OK Then
                                            enableAllControls()
                                            Me.Hide()
                                            InventoryAdminDashboard.Show()
                                        End If

                                    Case "General User"

                                        MessageBox.Show($"Welcome {firstname}!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                        If DialogResult.OK Then
                                            enableAllControls()
                                            Me.Hide()
                                            GeneralUserDashboard.Show()
                                        End If

                                    Case "Dept. Manager"
                                        MessageBox.Show($"Welcome {firstname}!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                        If DialogResult.OK Then
                                            enableAllControls()
                                            Me.Hide()
                                            AppAdminDashboard.Show()
                                        End If

                                    Case "Gen. Manager"
                                        MessageBox.Show($"Welcome {firstname}!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                        If DialogResult.OK Then
                                            enableAllControls()
                                            Me.Hide()
                                            InventoryAdminDashboard.Show()
                                        End If

                                End Select

                            Else
                                MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                enableAllControls()

                            End If

                        End If
                    Next
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, $"Exception thrown", MessageBoxButtons.OK, MessageBoxIcon.Error)
                pcon.Close()
            End Try
        End If

    End Sub

    Private Sub disableAllControls()

        For Each c As Control In Me.Controls
            c.Enabled = False
        Next

    End Sub

    Private Sub enableAllControls()

        For Each c As Control In Me.Controls
            c.Enabled = True
        Next

    End Sub

    Public Sub getCategoriesfromDB()

        Call connectPostGre()

        Try

            Dim sqlQuery As String = "SELECT * from ""Categories"""
            pda = New Odbc.OdbcDataAdapter()
            Dim pdcb As New Odbc.OdbcCommandBuilder(pda)
            pda.SelectCommand = New Odbc.OdbcCommand(sqlQuery, pcon)
            pcon.Open()
            pda.Fill(categoriesTable)
            pcon.Close()

        Catch ex As Exception
            If ex.Message.Contains("Data source name not found and no default driver specified") Then
                pcon.Close()
                Dim installDriver As DialogResult = MessageBox.Show("You need to install the ODBC driver for PostgreSQL in your PC to be able to use this application. Would you like to proceed?", "Driver not found.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If installDriver = DialogResult.OK Then
                    installDBDriver()
                Else
                    Application.Exit()
                End If

            Else
                MessageBox.Show(ex.Message)
            End If
        End Try

    End Sub

    Private Sub getUsernamesfromDB()

        Call connectPostGre()

        Try

            Dim sqlQuery As String = "SELECT * from ""users"";"
            pda = New Odbc.OdbcDataAdapter()
            Dim pdcb As New Odbc.OdbcCommandBuilder(pda)
            pda.SelectCommand = New Odbc.OdbcCommand(sqlQuery, pcon)

            pcon.Open()
            pda.Fill(usersTable)
            pcon.Close()

            For Each dr As DataRow In usersTable.Rows

                usernames.Add(dr(0))

            Next
            tbUsername.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            tbUsername.AutoCompleteSource = AutoCompleteSource.CustomSource
            tbUsername.AutoCompleteCustomSource.AddRange(usernames.ToArray)


        Catch ex As Exception

            If ex.Message.Contains("Data source name not found and no default driver specified") Then
                pcon.Close()
                Dim installDriver As DialogResult = MessageBox.Show("You need to install the ODBC driver for PostgreSQL in your PC to be able to use this application. Would you like to proceed?", "Driver not found.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If installDriver = DialogResult.OK Then
                    installDBDriver()
                Else
                    Application.Exit()
                End If
            Else
                MessageBox.Show(ex.Message)
            End If

        End Try

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        disableAllControls()
        checkAccountCred()

    End Sub

    Private Sub login_keyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbPassword.KeyDown

        If e.KeyCode = Keys.Enter Then
            checkAccountCred()
        End If

    End Sub

    Private Sub btnRequestAccount_Click(sender As Object, e As EventArgs) Handles btnRequestAccount.Click
        Me.Hide()
        RequestAccount.Show()
    End Sub

    Private Async Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Await CheckForUpdates()

        ToolStripStatusLabel1.Text = $"{My.Application.Info.AssemblyName} {My.Application.Info.Version.ToString}"
        Me.Text = "Lasermet Master List System"

        disableAllControls()
        getCategoriesfromDB()
        getUsernamesfromDB()
        enableAllControls()

        If My.Settings.mostRecentUser IsNot Nothing Then
            tbUsername.Text = My.Settings.mostRecentUser.ToString
        End If

    End Sub

    Private Sub btnChangePW_Click(sender As Object, e As EventArgs) Handles btnChangePW.Click
        Me.Hide()
        ChangePassword.Show()
    End Sub

    Private Sub installDBDriver()


        Try

            Dim PostgreSQLDSN_Registry As Microsoft.Win32.RegistryKey = My.Computer.Registry.LocalMachine.OpenSubKey("Software\WOW6432Node\ODBC\ODBC.INI\PostgreSQL35W")
            Dim PostgreSQLDriver_Registry As Microsoft.Win32.RegistryKey = My.Computer.Registry.LocalMachine.OpenSubKey("Software\WOW6432Node\psqlODBC")

            If PostgreSQLDriver_Registry Is Nothing Then
                Dim filepath As String = $"{Application.StartupPath}\odbcdriver.msi"
                My.Computer.FileSystem.WriteAllBytes(filepath, My.Resources.psqlodbc_x86, True)
                Dim instProcess As New Process
                instProcess.StartInfo.FileName = filepath
                instProcess.Start()
                instProcess.WaitForExit()
                Application.Restart()

            ElseIf PostgreSQLDSN_Registry Is Nothing Then

                Dim filepath As String = $"{Application.StartupPath}\PostgreSQL35W.reg"
                My.Computer.FileSystem.WriteAllBytes(filepath, My.Resources.PostgreSQL35W, True)

                Dim regProcess As New Process
                regProcess.StartInfo.FileName = filepath
                regProcess.Start()
                regProcess.WaitForExit()
                Dim confirmInstall As DialogResult = MessageBox.Show("Setup for Database Registry has been completed. Kindly click OK to exit and manually restart the application.", "DSN Installed.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If confirmInstall = DialogResult.OK Then
                    Application.Restart()
                End If

            End If

        Catch ex As Exception

            Console.WriteLine(ex.Message)

        End Try

    End Sub


End Class