'================================================================================
'FILE        : login.vb
'AUTHORS     : Jayson O. Amodia, Elyn Abby Toledo, Kathryn Marie P. Sigaya
'DESCRIPTION : This file shows the processes and design menu of the login page of the Part Number Generator.
'COPYRIGHT   : 04 July 2023
'REVISION HISTORY
'Date: 			By: 		Description:
'2023/07/04     Sigaya      Documentation
'================================================================================

' References of important packages and/or directories 
Imports System.IO
Imports System.Threading.Tasks
Imports Squirrel
Imports BCrypt.Net.BCrypt

'================================================================================
'CLASS       : login
'DESCRIPTION : Class that stores variables, functions, and other classes for the login processes
'================================================================================

Public Class login

    'declare variables as public string
    Public username As String
    Public firstname As String
    Public surname As String
    Public account_type As String
    Public user_email As String
    Public user_department As String
    Public user_location As String
    Public user_mondayid As String

    'Declare variables here as public instances of other classes
    'DataTable stores data in memory. The data has columns and rows much like an actual table
    Public categoriesTable As New DataTable
    'List is a type of resizable array. It is dynamically sized
    Public usernames As New List(Of String)
    Public usersTable As New DataTable

    '================================================================================
    'CLASS       : UpdateInfo
    'DESCRIPTION : Class that has the variables be instances in the ReleaseEntry class
    '================================================================================
    '<----- START of Squirrel Objects ----->
    Public Class UpdateInfo
        Public CurrentlyInstalledVersion As ReleaseEntry
        Public FutureReleaseEntry As ReleaseEntry
        Public ReleasesToApply As List(Of ReleaseEntry)
    End Class

    '================================================================================
    'CLASS       : ReleaseEntry
    'DESCRIPTION : Class that has the variables be declared as string. This class
    '              holds the details of the Release Entry.
    '================================================================================
    Public Class ReleaseEntry
        Public Property SHA1 As String
        Public Property Filename As String
        Public Property Filesize As Long
        Public Property IsDelta As Boolean
    End Class
    '<----- END of Squirrel Objects ----->

    '================================================================================
    'FUNCTION   : CheckForUpdates
    'DESCRIPTION: Checks for release updates for this program via the GitHub Repository provided.    
    'ARGUMENTS  : None
    'RETURNS    : Task - asynchronous operation
    '================================================================================
    '"Async" allows this method to be executed alongside other running processes
    '"As Task" is the data type to be returned for this function. since this is declared as an async function
    Private Async Function CheckForUpdates() As Task

        'The "Try" block will be executed first. This block might have exceptions during runtime, to which the execution will be stopped and the "catch" block will be executed next.
        'The "Catch" block will be executed if there is an exception occured. 
        'The "Finally" block will be executed regardless if there is an exception or not.
        Try
            '"Using" is a statement where the object is properly discarded once the operation is done for resource saving purposes
            '"Await" is a keyword that temporarily suspends the execution of the block or function, and delegates the execution to the method where the "Await" keyword is used
            'UpdateManager is from Squirrel
            Using manager = Await UpdateManager.GitHubUpdateManager($"https://github.com/bebedog/Lasermet-Part-Number-Generator-Amodia-Repository")
                'Await manager.UpdateApp()
                '"Dim" is the variable declaration for visual basic
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
                    Await manager.UpdateApp()
                    MessageBox.Show($"Lasermet Part Number Generator v{latestVersion} is now available on GitHub." + Environment.NewLine +
                                    $"Once this instance is closed, please reopen the program.", "Update available!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Application.Exit()
                Else
                    'no new update.
                End If

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Oops, something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    '================================================================================
    'SUBROUTINE   : checkAccountCred
    'DESCRIPTION  : Checks for the inputted login credentials with the stored details in the PostgreSQL database.   
    'ARGUMENTS    : None
    '================================================================================
    Private Sub checkAccountCred()

        Dim passwordHash As String = BCrypt.Net.BCrypt.HashPassword(tbPassword.Text)

        'check if both textboxes are empty
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
            'if both textboxes are not empty, then connect to the database
            Call connectPostGre()

            Try
                'For Each [element] As [DataType] In [Group]
                'adds the username to the table of users that where retrieved from the database
                For Each dr As DataRow In usersTable.Rows
                    usernames.Add(dr(0))
                Next

                'if the inputted username isn't found in the table of usernames(?) then, the username isn't found
                If usernames.IndexOf(tbUsername.Text) < 0 Then
                    MessageBox.Show("Username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    enableAllControls()
                Else 'why did it only loop for one dr only though
                    For Each dr As DataRow In usersTable.Rows
                        If dr(0) = tbUsername.Text Then
                            'checks if the password inputted is correct
                            If BCrypt.Net.BCrypt.Verify(tbPassword.Text, dr(1)) = True Then
                                'set variables to that specific user
                                'the dr() corresponds to the data row found in the database. the index starts at zero
                                username = tbUsername.Text
                                firstname = dr(4)
                                surname = dr(5)
                                account_type = dr(3)
                                user_location = dr(8)
                                user_department = dr(9)
                                user_mondayid = dr(10)
                                'saves most recent logged in user to the settings file of the vb program
                                My.Settings.mostRecentUser = tbUsername.Text
                                My.Settings.Save()

                                'checks for the account type and shows the respective menu
                                Select Case account_type
                                    Case "App Admin"
                                        'if the user is "App Admin", show the dashboard for App Admin
                                        MessageBox.Show($"Welcome {firstname}!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        If DialogResult.OK Then
                                            enableAllControls()
                                            Me.Hide()
                                            AppAdminDashboard.Show()
                                        End If

                                    Case "Inventory Admin"
                                        'if the user is "Inventory Admin", show the dashboard for Inventory Admin
                                        MessageBox.Show($"Welcome {firstname}!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        If DialogResult.OK Then
                                            enableAllControls()
                                            Me.Hide()
                                            InventoryAdminDashboard.Show()
                                        End If

                                    Case "General User"
                                        'if the user is "General User", show the dashboard for General User
                                        MessageBox.Show($"Welcome {firstname}!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        If DialogResult.OK Then
                                            enableAllControls()
                                            Me.Hide()
                                            GeneralUserDashboard.Show()
                                        End If

                                    Case "Dept. Manager"
                                        'if the user is "Dept. Manager", show the dashboard for Dept. Manager
                                        MessageBox.Show($"Welcome {firstname}!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        If DialogResult.OK Then
                                            enableAllControls()
                                            Me.Hide()
                                            AppAdminDashboard.Show()
                                        End If

                                    Case "Gen. Manager"
                                        'if the user is "Gen. Manager", show the dashboard for Gen. Manager
                                        MessageBox.Show($"Welcome {firstname}!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        If DialogResult.OK Then
                                            enableAllControls()
                                            Me.Hide()
                                            InventoryAdminDashboard.Show()
                                        End If
                                End Select

                            Else
                                'if the username exists but the password is wrong, prompt "incorrect password"
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

    '================================================================================
    'SUBROUTINE   : disableAllControls
    'DESCRIPTION  : Disables all controls controllable by user interactions in the current form
    'ARGUMENTS    : None
    '================================================================================
    Private Sub disableAllControls()
        For Each c As Control In Me.Controls
            c.Enabled = False
        Next
    End Sub

    '================================================================================
    'SUBROUTINE   : enableAllControls
    'DESCRIPTION  : Enables all controls controllable by user interactions in the current form   
    'ARGUMENTS    : None
    '================================================================================
    Private Sub enableAllControls()
        For Each c As Control In Me.Controls
            c.Enabled = True
        Next
    End Sub

    '================================================================================
    'SUBROUTINE   : enableAllControls
    'DESCRIPTION  : Enables all controls controllable by user interactions in the current form   
    'ARGUMENTS    : None
    '================================================================================
    Public Sub getCategoriesfromDB()
        'connect to database
        Call connectPostGre()
        Try
            'the double quotation marks are there for the string/text itself! for the execution of the query to the database
            Dim sqlQuery As String = "SELECT * from ""Categories"""
            'odbc = open database connectivity
            pda = New Odbc.OdbcDataAdapter()
            Dim pdcb As New Odbc.OdbcCommandBuilder(pda)
            pda.SelectCommand = New Odbc.OdbcCommand(sqlQuery, pcon)
            pcon.Open()
            pda.Fill(categoriesTable) 'empty table?
            pcon.Close()

        Catch ex As Exception
            'checks if the odbc driver for postresql exists in the current machine
            If ex.Message.Contains("Data source name not found and no default driver specified") Then
                pcon.Close()
                Dim installDriver As DialogResult = MessageBox.Show("You need to install the ODBC driver for PostgreSQL in your PC to be able to use this application. Would you like to proceed?", "Driver not found.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If installDriver = DialogResult.OK Then
                    'if the user chooses "Yes" in the dialog prompt, install the odbc driver
                    installDBDriver()
                Else
                    'if "No", it closes the application
                    Application.Exit()
                End If

            Else
                'show error message if other exceptions were encountered!
                MessageBox.Show(ex.Message)
            End If
        End Try

    End Sub

    '================================================================================
    'SUBROUTINE   : getUsernamesfromDB
    'DESCRIPTION  : Retrieves all usernames that are present in the specified database.  
    'ARGUMENTS    : None
    '================================================================================
    Private Sub getUsernamesfromDB()

        'connect to the database first
        Call connectPostGre()

        Try

            Dim sqlQuery As String = "SELECT * from ""users"";"
            'pda = postgresql database adapter?
            pda = New Odbc.OdbcDataAdapter()
            'pdcb = postgresql database connection builder?
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

    '================================================================================
    'SUBROUTINE   : btnLogin_Click
    'DESCRIPTION  : Disables form controls and executes the checkAccountCred function. 
    'ARGUMENTS    : None
    '================================================================================
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        disableAllControls()
        checkAccountCred()
    End Sub

    '================================================================================
    'SUBROUTINE   : login_keyDown
    'DESCRIPTION  : Executes checkAccountCred if the enter key is pressed during login.  
    'ARGUMENTS    : None
    '================================================================================
    Private Sub login_keyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            checkAccountCred()
        End If
    End Sub

    '================================================================================
    'SUBROUTINE   : btnRequestAccount_Click
    'DESCRIPTION  : Shows the RequestAccount menu after pressing the Request Account button.  
    'ARGUMENTS    : None
    '================================================================================
    Private Sub btnRequestAccount_Click(sender As Object, e As EventArgs) Handles btnRequestAccount.Click
        Me.Hide()
        RequestAccount.Show()
    End Sub

    '================================================================================
    'SUBROUTINE   : login_Load
    'DESCRIPTION  : Asynchronous subroutine that checks for program releases in Github, and retrieves all needed data from the database 
    'ARGUMENTS    : None
    '================================================================================
    Private Async Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = $"{My.Application.Info.AssemblyName} {My.Application.Info.Version.ToString}"
        Me.Text = "Lasermet Master List System"

        disableAllControls()
        Await CheckForUpdates()



        getCategoriesfromDB()
        getUsernamesfromDB()
        enableAllControls()

        If My.Settings.mostRecentUser IsNot Nothing Then
            'sets the username field to the most recent user
            tbUsername.Text = My.Settings.mostRecentUser.ToString
        End If

    End Sub

    '================================================================================
    'SUBROUTINE   : btnChangePW_Click
    'DESCRIPTION  : Shows the change password menu.  
    'ARGUMENTS    : None
    '================================================================================
    Private Sub btnChangePW_Click(sender As Object, e As EventArgs) Handles btnChangePW.Click
        Me.Hide()
        ChangePassword.Show()
    End Sub

    '================================================================================
    'SUBROUTINE   : installDBDriver
    'DESCRIPTION  : Installs the database driver for PostgreSQL in the user machine
    'ARGUMENTS    : None
    '================================================================================
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